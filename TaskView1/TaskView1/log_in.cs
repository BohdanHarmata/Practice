using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace TaskView1
{
    public partial class log_in : Form { 


    
        DataBase dataBase = new DataBase();

        public log_in()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void log_in_Load(object sender, EventArgs e)
        {
            loginTextBox.MaxLength = 50;
            passwordTextBox.MaxLength = 50;
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void logInButton_Click(object sender, EventArgs e)
        {
          

            var login_User = loginTextBox.Text;
            var password_User = passwordTextBox.Text;

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable dataTable = new DataTable();

            string querystring = $"select us_id, us_login, us_password from register where us_login = '{login_User}' and us_password = '{password_User}'";

            SqlCommand comand = new SqlCommand(querystring, dataBase.getConnection());

            adapter.SelectCommand = comand;
            adapter.Fill(dataTable);

            if (dataTable.Rows.Count == 1)
            {
                MessageBox.Show("Вхід виконано успішно!", "Успішно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MainWindow mainWindow = new MainWindow();
                mainWindow.Show();
                this.Hide();
            }



            else
            {
                MessageBox.Show("Такого аккаунту не існує!", "Зареєструйтесь!", MessageBoxButtons.OK, MessageBoxIcon.Information);     
            }
        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {
            passwordTextBox.PasswordChar = '*';
        }

        private void notAuthorise_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            sing_up sing_ = new sing_up();
            sing_.ShowDialog();
            this.Hide();
        }
    }
}

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
    public partial class sing_up : Form
    {
        DataBase dataBase = new DataBase();
        public sing_up()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;

        }

        private void sing_up_Load(object sender, EventArgs e)
        {
            loginTextBox1.MaxLength = 50;
            passwordTextBox1.MaxLength = 50;

        }

        private void registerButton1_Click(object sender, EventArgs e)
        {
            if (checkUser() == false)
            {


                var login = loginTextBox1.Text;
                var password = passwordTextBox1.Text;

                string queirstring = $"insert into register (us_login, us_password) values('{login}', '{password}')";
                SqlCommand command = new SqlCommand(queirstring, dataBase.getConnection());

                dataBase.openConection();

                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Аккаунт успішно створено!", "Успіх!");
                    log_in log_ = new log_in();
                    log_.ShowDialog();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Акаунт не створено!", "Провал!");
                }
                dataBase.closeConection();
            }
            else
            {
                
            }
        }

        public bool checkUser()
        {
            var login_user = loginTextBox1.Text;
            var password_user = passwordTextBox1.Text;

            SqlDataAdapter adapte = new SqlDataAdapter();
            DataTable dataTable = new DataTable();

            string querystring = $"select us_id, us_login, us_password from register where us_login = '{login_user}' and us_password = '{password_user}'";

            SqlCommand command = new SqlCommand(querystring, dataBase.getConnection());

            adapte.SelectCommand = command;
            adapte.Fill(dataTable);

            if (dataTable.Rows.Count > 0) 
            {
                MessageBox.Show("Користувач вже існує!", "Використайте інші дані!");
                log_in log_ = new log_in();
                log_.Show();
                this.Close();

                return true;
            }
            else
            {
                return false;
            }
        } 


        private void passwordTextBox1_TextChanged(object sender, EventArgs e)
        {
            passwordTextBox1.PasswordChar = '*';
        }
    }
}

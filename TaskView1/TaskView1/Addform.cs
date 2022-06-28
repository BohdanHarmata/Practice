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
    public partial class Addform : Form
    {

        DataBase dataBase = new DataBase();
        public Addform()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            dataBase.openConection();

            var topic = topicTextBox.Text;
            var semester = semestrTextBox.Text;
            var student = studentTextBox.Text;
            var task = taskTextBox.Text;
            int mark;
            var work = workTextBox.Text;

            if (int.TryParse(markTextBox.Text, out mark))
            {
                var addQuery = $"insert into rabota ( predmet_id, semester_id, student_id, zavdania_id, mark, rabota) " +
                    $"values( '{topic}', '{semester}', '{student}', '{task}', '{mark}', '{work}')";

                var comand = new SqlCommand(addQuery, dataBase.getConnection());
                comand.ExecuteNonQuery();

                MessageBox.Show("Дані додано","Успіх!");
            }
            else
            {
                MessageBox.Show("Дані не додано", "Провал!");
            }
            dataBase.closeConection();
            
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Hide();
        }
    }
}

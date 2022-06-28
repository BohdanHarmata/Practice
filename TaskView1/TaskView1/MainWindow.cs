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

    enum RowState
    {
        Existed,
        New,
        Modified,
        ModifiedNew,
        Deleted
    }

    public partial class MainWindow : Form
    {
        int selectRow;

        DataBase data = new DataBase();
        public MainWindow()
        {
           
            InitializeComponent();

        }

        private void createcolums()
        {
            dataGridView1.Columns.Add("id", "id");
            dataGridView1.Columns.Add("topic", "Предмет");
            dataGridView1.Columns.Add("semester", "Семестр");
            dataGridView1.Columns.Add("student", "Студент");
            dataGridView1.Columns.Add("task", "Завдання");
            dataGridView1.Columns.Add("mark", "Оцінка");
            dataGridView1.Columns.Add("work", "Назва роботи");
            dataGridView1.Columns.Add("isNew", string.Empty);
        }

        private void readSingleRow(DataGridView dataGrid, IDataRecord record)
        {
            dataGrid.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetInt32(2), record.GetString(3), 
                record.GetString(4), record.GetInt32(5),record.GetString(6), RowState.ModifiedNew );
        }

        private void dataRefresh(DataGridView dataGrid)
        {
            dataGrid.Rows.Clear();

            string querystring = $"select * from View_1 ";

            SqlCommand command = new SqlCommand(querystring, data.getConnection());

            data.openConection();

            SqlDataReader dataReader = command.ExecuteReader();

            while (dataReader.Read())
            {
                readSingleRow(dataGrid,dataReader);
            }
            dataReader.Close();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            createcolums();
            dataRefresh(dataGridView1);
        }
        
        private void searchData(DataGridView dataGrid)
        {
            dataGrid.Rows.Clear();

            string query = $"select * from View_1 where concat (rabota_id, predmet, semester, student, zavdania, mark, rabota) like '%" + searchTextBox + "%'";
            SqlCommand sqlCommand = new SqlCommand(query, data.getConnection());

            data.openConection();

            SqlDataReader read = sqlCommand.ExecuteReader();

            while (read.Read())
            {
                readSingleRow(dataGrid,read);
            }

            read.Close();
        }

        private void deleteRow()
        {
            int index = dataGridView1.CurrentCell.RowIndex;

            dataGridView1.Rows[index].Visible = false;

            if (dataGridView1.Rows[index].Cells[0].Value.ToString() == string.Empty)
            {
                dataGridView1.Rows[index].Cells[7].Value = RowState.Deleted;
                return;
            }

            dataGridView1.Rows[index].Cells[7].Value = RowState.Deleted;
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void task_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            selectRow = e.RowIndex;
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[selectRow];

                idTextBox.Text = row.Cells[0].Value.ToString();
                prdmetTextBox.Text = row.Cells[1].Value.ToString();
                semesterTextBox.Text = row.Cells[2].Value.ToString();
                studentTextBox.Text = row.Cells[3].Value.ToString();
                taskTextBox.Text = row.Cells[4].Value.ToString();
                markTextBox.Text = row.Cells[5].Value.ToString();
                workTextBox.Text = row.Cells[6].Value.ToString();
            }
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            dataRefresh(dataGridView1);
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            Addform addform = new Addform();
            addform.Show();
            this.Hide();
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            searchData(dataGridView1);
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            deleteRow();
        }

        private void changeDate()
        {
            var selectRowIndex = dataGridView1.CurrentCell.RowIndex;

            var id = idTextBox.Text;
            var topic = taskTextBox.Text;
            var semester = semesterTextBox.Text;
            var student = studentTextBox.Text;
            var task = taskTextBox.Text;
            int mark;
            var work = workTextBox.Text;

            if (dataGridView1.Rows[selectRowIndex].Cells[0].Value.ToString() != string.Empty)
            {
                if(int.TryParse(markTextBox.Text, out mark))
                {
                    dataGridView1.Rows[selectRowIndex].SetValues(id, topic, semester, student, task, mark, work);
                    dataGridView1.Rows[selectRowIndex].Cells[7].Value = RowState.Modified;
                }
                else
                {
                    MessageBox.Show("Оцінка повинен мати числовий формат","Увага!");
                }
            }
        }

        private void updateData()
        {
            data.openConection();

            for(int index = 0; index<dataGridView1.Rows.Count; index++)
            {
                var rowState = (RowState)dataGridView1.Rows[index].Cells[7].Value;

                if (rowState == RowState.ModifiedNew)
                    continue;
                if(rowState == RowState.Deleted)
                {
                    var id = Convert.ToInt32(dataGridView1.Rows[index].Cells[0].Value);
                    var deleteQuery = $"delete from rabota where rabota_id = '{id}'";

                    var command = new SqlCommand(deleteQuery, data.getConnection());
                    command.ExecuteNonQuery();
                }

                if (rowState == RowState.Modified)
                {
                    var id = dataGridView1.Rows[index].Cells[0].Value.ToString();
                    var topic = dataGridView1.Rows[index].Cells[1].Value.ToString();
                    var semester = dataGridView1.Rows[index].Cells[2].Value.ToString();
                    var student = dataGridView1.Rows[index].Cells[3].Value.ToString();
                    var task = dataGridView1.Rows[index].Cells[4].Value.ToString();
                    var mark = dataGridView1.Rows[index].Cells[5].Value.ToString();
                    var work = dataGridView1.Rows[index].Cells[6].Value.ToString();

                    var changeQuery = $"update rabota set  predmet_id = '{topic}', semester_id ='{semester}', student_id ='{student}'," +
                        $" zavdania_id = '{task}', mark = '{mark}', rabota = '{work}' where rabota_id = '{id}'";

                    var command = new SqlCommand(changeQuery,data.getConnection());
                    command.ExecuteNonQuery();
                }
            }

            data.closeConection();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            updateData();
        }

        private void changeButton_Click(object sender, EventArgs e)
        {
            changeDate();
        }

        private void function_Click(object sender, EventArgs e)
        {

        }
    }
}
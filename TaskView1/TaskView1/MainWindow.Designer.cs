namespace TaskView1
{
    partial class MainWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.addButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.changeButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.workTextBox = new System.Windows.Forms.TextBox();
            this.markTextBox = new System.Windows.Forms.TextBox();
            this.taskTextBox = new System.Windows.Forms.TextBox();
            this.workName = new System.Windows.Forms.Label();
            this.mark = new System.Windows.Forms.Label();
            this.task = new System.Windows.Forms.Label();
            this.student = new System.Windows.Forms.Label();
            this.studentTextBox = new System.Windows.Forms.TextBox();
            this.semester = new System.Windows.Forms.Label();
            this.semesterTextBox = new System.Windows.Forms.TextBox();
            this.predmet = new System.Windows.Forms.Label();
            this.prdmetTextBox = new System.Windows.Forms.TextBox();
            this.workId = new System.Windows.Forms.Label();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.function = new System.Windows.Forms.Label();
            this.refreshButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 80);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(878, 201);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(146, 49);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 2;
            this.addButton.Text = "Додати";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(146, 78);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 3;
            this.deleteButton.Text = "Видалити";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // changeButton
            // 
            this.changeButton.Location = new System.Drawing.Point(146, 107);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(75, 23);
            this.changeButton.TabIndex = 4;
            this.changeButton.Text = "Змінити";
            this.changeButton.UseVisualStyleBackColor = true;
            this.changeButton.Click += new System.EventHandler(this.changeButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(146, 136);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 5;
            this.saveButton.Text = "Зберегти";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(708, 31);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(154, 23);
            this.searchTextBox.TabIndex = 6;
            this.searchTextBox.TextChanged += new System.EventHandler(this.searchTextBox_TextChanged);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(12, 351);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.workTextBox);
            this.splitContainer1.Panel1.Controls.Add(this.markTextBox);
            this.splitContainer1.Panel1.Controls.Add(this.taskTextBox);
            this.splitContainer1.Panel1.Controls.Add(this.workName);
            this.splitContainer1.Panel1.Controls.Add(this.mark);
            this.splitContainer1.Panel1.Controls.Add(this.task);
            this.splitContainer1.Panel1.Controls.Add(this.student);
            this.splitContainer1.Panel1.Controls.Add(this.studentTextBox);
            this.splitContainer1.Panel1.Controls.Add(this.semester);
            this.splitContainer1.Panel1.Controls.Add(this.semesterTextBox);
            this.splitContainer1.Panel1.Controls.Add(this.predmet);
            this.splitContainer1.Panel1.Controls.Add(this.prdmetTextBox);
            this.splitContainer1.Panel1.Controls.Add(this.workId);
            this.splitContainer1.Panel1.Controls.Add(this.idTextBox);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.function);
            this.splitContainer1.Panel2.Controls.Add(this.saveButton);
            this.splitContainer1.Panel2.Controls.Add(this.addButton);
            this.splitContainer1.Panel2.Controls.Add(this.changeButton);
            this.splitContainer1.Panel2.Controls.Add(this.deleteButton);
            this.splitContainer1.Size = new System.Drawing.Size(878, 264);
            this.splitContainer1.SplitterDistance = 498;
            this.splitContainer1.TabIndex = 7;
            // 
            // workTextBox
            // 
            this.workTextBox.Location = new System.Drawing.Point(167, 180);
            this.workTextBox.Name = "workTextBox";
            this.workTextBox.Size = new System.Drawing.Size(154, 23);
            this.workTextBox.TabIndex = 20;
            // 
            // markTextBox
            // 
            this.markTextBox.Location = new System.Drawing.Point(167, 151);
            this.markTextBox.Name = "markTextBox";
            this.markTextBox.Size = new System.Drawing.Size(154, 23);
            this.markTextBox.TabIndex = 19;
            // 
            // taskTextBox
            // 
            this.taskTextBox.Location = new System.Drawing.Point(167, 122);
            this.taskTextBox.Name = "taskTextBox";
            this.taskTextBox.Size = new System.Drawing.Size(154, 23);
            this.taskTextBox.TabIndex = 18;
            // 
            // workName
            // 
            this.workName.AutoSize = true;
            this.workName.Location = new System.Drawing.Point(67, 188);
            this.workName.Name = "workName";
            this.workName.Size = new System.Drawing.Size(82, 15);
            this.workName.TabIndex = 15;
            this.workName.Text = "Назва роботи";
            // 
            // mark
            // 
            this.mark.AutoSize = true;
            this.mark.Location = new System.Drawing.Point(84, 159);
            this.mark.Name = "mark";
            this.mark.Size = new System.Drawing.Size(45, 15);
            this.mark.TabIndex = 14;
            this.mark.Text = "Оцінка";
            // 
            // task
            // 
            this.task.AutoSize = true;
            this.task.Location = new System.Drawing.Point(78, 130);
            this.task.Name = "task";
            this.task.Size = new System.Drawing.Size(58, 15);
            this.task.TabIndex = 13;
            this.task.Text = "Завдання";
            this.task.Click += new System.EventHandler(this.task_Click);
            // 
            // student
            // 
            this.student.AutoSize = true;
            this.student.Location = new System.Drawing.Point(79, 102);
            this.student.Name = "student";
            this.student.Size = new System.Drawing.Size(50, 15);
            this.student.TabIndex = 12;
            this.student.Text = "Студент";
            // 
            // studentTextBox
            // 
            this.studentTextBox.Location = new System.Drawing.Point(167, 94);
            this.studentTextBox.Name = "studentTextBox";
            this.studentTextBox.Size = new System.Drawing.Size(154, 23);
            this.studentTextBox.TabIndex = 8;
            // 
            // semester
            // 
            this.semester.AutoSize = true;
            this.semester.Location = new System.Drawing.Point(75, 73);
            this.semester.Name = "semester";
            this.semester.Size = new System.Drawing.Size(54, 15);
            this.semester.TabIndex = 11;
            this.semester.Text = "Семестр";
            // 
            // semesterTextBox
            // 
            this.semesterTextBox.Location = new System.Drawing.Point(167, 65);
            this.semesterTextBox.Name = "semesterTextBox";
            this.semesterTextBox.Size = new System.Drawing.Size(154, 23);
            this.semesterTextBox.TabIndex = 9;
            // 
            // predmet
            // 
            this.predmet.AutoSize = true;
            this.predmet.Location = new System.Drawing.Point(74, 44);
            this.predmet.Name = "predmet";
            this.predmet.Size = new System.Drawing.Size(55, 15);
            this.predmet.TabIndex = 10;
            this.predmet.Text = "Предмет";
            // 
            // prdmetTextBox
            // 
            this.prdmetTextBox.Location = new System.Drawing.Point(167, 36);
            this.prdmetTextBox.Name = "prdmetTextBox";
            this.prdmetTextBox.Size = new System.Drawing.Size(154, 23);
            this.prdmetTextBox.TabIndex = 10;
            // 
            // workId
            // 
            this.workId.AutoSize = true;
            this.workId.Location = new System.Drawing.Point(91, 15);
            this.workId.Name = "workId";
            this.workId.Size = new System.Drawing.Size(17, 15);
            this.workId.TabIndex = 9;
            this.workId.Text = "Id";
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(167, 7);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(154, 23);
            this.idTextBox.TabIndex = 11;
            // 
            // function
            // 
            this.function.AutoSize = true;
            this.function.Location = new System.Drawing.Point(115, 31);
            this.function.Name = "function";
            this.function.Size = new System.Drawing.Size(128, 15);
            this.function.TabIndex = 9;
            this.function.Text = "Взаємодія з таблицею";
            this.function.Click += new System.EventHandler(this.function_Click);
            // 
            // refreshButton
            // 
            this.refreshButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("refreshButton.BackgroundImage")));
            this.refreshButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.refreshButton.Location = new System.Drawing.Point(660, 24);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(42, 34);
            this.refreshButton.TabIndex = 10;
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 627);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.dataGridView1);
            this.Name = "MainWindow";
            this.Text = "Вікно перегляду";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridView1;
        private Button addButton;
        private Button deleteButton;
        private Button changeButton;
        private Button saveButton;
        private TextBox searchTextBox;
        private SplitContainer splitContainer1;
        private TextBox studentTextBox;
        private TextBox semesterTextBox;
        private TextBox prdmetTextBox;
        private TextBox idTextBox;
        private Label student;
        private Label semester;
        private Label predmet;
        private Label workId;
        private Label function;
        private Label mark;
        private Label task;
        private TextBox workTextBox;
        private TextBox markTextBox;
        private TextBox taskTextBox;
        private Label workName;
        private Button refreshButton;
    }
}
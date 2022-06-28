namespace TaskView1
{
    partial class Addform
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.addButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.semestrTextBox = new System.Windows.Forms.TextBox();
            this.studentTextBox = new System.Windows.Forms.TextBox();
            this.taskTextBox = new System.Windows.Forms.TextBox();
            this.markTextBox = new System.Windows.Forms.TextBox();
            this.workTextBox = new System.Windows.Forms.TextBox();
            this.topicTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(375, 292);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 1;
            this.addButton.Text = "Додати";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(88, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Предмет";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Enabled = false;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(41, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 30);
            this.label3.TabIndex = 4;
            this.label3.Text = "Додати дані";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(88, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Семестр";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(88, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "Студент";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(88, 203);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 15);
            this.label6.TabIndex = 7;
            this.label6.Text = "Завдання";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(88, 232);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 15);
            this.label7.TabIndex = 8;
            this.label7.Text = "Оцінка";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(88, 261);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 15);
            this.label8.TabIndex = 9;
            this.label8.Text = "Назва роботи";
            // 
            // semestrTextBox
            // 
            this.semestrTextBox.Location = new System.Drawing.Point(233, 137);
            this.semestrTextBox.Name = "semestrTextBox";
            this.semestrTextBox.Size = new System.Drawing.Size(100, 23);
            this.semestrTextBox.TabIndex = 10;
            // 
            // studentTextBox
            // 
            this.studentTextBox.Location = new System.Drawing.Point(233, 166);
            this.studentTextBox.Name = "studentTextBox";
            this.studentTextBox.Size = new System.Drawing.Size(100, 23);
            this.studentTextBox.TabIndex = 11;
            // 
            // taskTextBox
            // 
            this.taskTextBox.Location = new System.Drawing.Point(233, 195);
            this.taskTextBox.Name = "taskTextBox";
            this.taskTextBox.Size = new System.Drawing.Size(100, 23);
            this.taskTextBox.TabIndex = 12;
            this.taskTextBox.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // markTextBox
            // 
            this.markTextBox.Location = new System.Drawing.Point(233, 224);
            this.markTextBox.Name = "markTextBox";
            this.markTextBox.Size = new System.Drawing.Size(100, 23);
            this.markTextBox.TabIndex = 13;
            // 
            // workTextBox
            // 
            this.workTextBox.Location = new System.Drawing.Point(233, 253);
            this.workTextBox.Name = "workTextBox";
            this.workTextBox.Size = new System.Drawing.Size(100, 23);
            this.workTextBox.TabIndex = 14;
            // 
            // topicTextBox
            // 
            this.topicTextBox.Location = new System.Drawing.Point(233, 108);
            this.topicTextBox.Name = "topicTextBox";
            this.topicTextBox.Size = new System.Drawing.Size(100, 23);
            this.topicTextBox.TabIndex = 15;
            // 
            // Addform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 345);
            this.Controls.Add(this.topicTextBox);
            this.Controls.Add(this.workTextBox);
            this.Controls.Add(this.markTextBox);
            this.Controls.Add(this.taskTextBox);
            this.Controls.Add(this.studentTextBox);
            this.Controls.Add(this.semestrTextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.addButton);
            this.Name = "Addform";
            this.Text = "Додати дані";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button addButton;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox semestrTextBox;
        private TextBox studentTextBox;
        private TextBox taskTextBox;
        private TextBox markTextBox;
        private TextBox workTextBox;
        private TextBox topicTextBox;
    }
}
namespace TaskView1
{
    partial class sing_up
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(sing_up));
            this.passwordTextBox1 = new System.Windows.Forms.TextBox();
            this.paswordLable1 = new System.Windows.Forms.Label();
            this.loginlable1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.loginTextBox1 = new System.Windows.Forms.TextBox();
            this.registerButton1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // passwordTextBox1
            // 
            this.passwordTextBox1.Location = new System.Drawing.Point(219, 199);
            this.passwordTextBox1.Multiline = true;
            this.passwordTextBox1.Name = "passwordTextBox1";
            this.passwordTextBox1.Size = new System.Drawing.Size(140, 23);
            this.passwordTextBox1.TabIndex = 13;
            this.passwordTextBox1.TextChanged += new System.EventHandler(this.passwordTextBox1_TextChanged);
            // 
            // paswordLable1
            // 
            this.paswordLable1.AutoSize = true;
            this.paswordLable1.Location = new System.Drawing.Point(95, 207);
            this.paswordLable1.Name = "paswordLable1";
            this.paswordLable1.Size = new System.Drawing.Size(49, 15);
            this.paswordLable1.TabIndex = 12;
            this.paswordLable1.Text = "Пароль";
            // 
            // loginlable1
            // 
            this.loginlable1.AutoSize = true;
            this.loginlable1.Location = new System.Drawing.Point(95, 162);
            this.loginlable1.Name = "loginlable1";
            this.loginlable1.Size = new System.Drawing.Size(37, 15);
            this.loginlable1.TabIndex = 11;
            this.loginlable1.Text = "Логін";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(11, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(478, 80);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // loginTextBox1
            // 
            this.loginTextBox1.Location = new System.Drawing.Point(219, 154);
            this.loginTextBox1.Multiline = true;
            this.loginTextBox1.Name = "loginTextBox1";
            this.loginTextBox1.Size = new System.Drawing.Size(140, 23);
            this.loginTextBox1.TabIndex = 9;
            // 
            // registerButton1
            // 
            this.registerButton1.Location = new System.Drawing.Point(190, 239);
            this.registerButton1.Name = "registerButton1";
            this.registerButton1.Size = new System.Drawing.Size(107, 33);
            this.registerButton1.TabIndex = 8;
            this.registerButton1.Text = "Зареєструватись";
            this.registerButton1.UseVisualStyleBackColor = true;
            this.registerButton1.Click += new System.EventHandler(this.registerButton1_Click);
            // 
            // sing_up
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 339);
            this.Controls.Add(this.passwordTextBox1);
            this.Controls.Add(this.paswordLable1);
            this.Controls.Add(this.loginlable1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.loginTextBox1);
            this.Controls.Add(this.registerButton1);
            this.Name = "sing_up";
            this.Text = "Зареєструватись";
            this.Load += new System.EventHandler(this.sing_up_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox passwordTextBox1;
        private Label paswordLable1;
        private Label loginlable1;
        private PictureBox pictureBox1;
        private TextBox loginTextBox1;
        private Button registerButton1;
    }
}
namespace TaskView1
{
    partial class log_in
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(log_in));
            this.logInButton = new System.Windows.Forms.Button();
            this.loginTextBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.loginlable = new System.Windows.Forms.Label();
            this.paswordLable = new System.Windows.Forms.Label();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.notAuthorise = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // logInButton
            // 
            this.logInButton.Location = new System.Drawing.Point(193, 248);
            this.logInButton.Name = "logInButton";
            this.logInButton.Size = new System.Drawing.Size(107, 33);
            this.logInButton.TabIndex = 0;
            this.logInButton.Text = "Авторизуватись";
            this.logInButton.UseVisualStyleBackColor = true;
            this.logInButton.Click += new System.EventHandler(this.logInButton_Click);
            // 
            // loginTextBox
            // 
            this.loginTextBox.Location = new System.Drawing.Point(222, 163);
            this.loginTextBox.Multiline = true;
            this.loginTextBox.Name = "loginTextBox";
            this.loginTextBox.Size = new System.Drawing.Size(140, 23);
            this.loginTextBox.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(12, 45);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(478, 79);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // loginlable
            // 
            this.loginlable.AutoSize = true;
            this.loginlable.Location = new System.Drawing.Point(98, 171);
            this.loginlable.Name = "loginlable";
            this.loginlable.Size = new System.Drawing.Size(37, 15);
            this.loginlable.TabIndex = 4;
            this.loginlable.Text = "Логін";
            this.loginlable.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // paswordLable
            // 
            this.paswordLable.AutoSize = true;
            this.paswordLable.Location = new System.Drawing.Point(98, 216);
            this.paswordLable.Name = "paswordLable";
            this.paswordLable.Size = new System.Drawing.Size(49, 15);
            this.paswordLable.TabIndex = 5;
            this.paswordLable.Text = "Пароль";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(222, 208);
            this.passwordTextBox.Multiline = true;
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(140, 23);
            this.passwordTextBox.TabIndex = 6;
            this.passwordTextBox.TextChanged += new System.EventHandler(this.passwordTextBox_TextChanged);
            // 
            // notAuthorise
            // 
            this.notAuthorise.AutoSize = true;
            this.notAuthorise.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.notAuthorise.LinkColor = System.Drawing.Color.Gray;
            this.notAuthorise.Location = new System.Drawing.Point(193, 295);
            this.notAuthorise.Name = "notAuthorise";
            this.notAuthorise.Size = new System.Drawing.Size(107, 15);
            this.notAuthorise.TabIndex = 7;
            this.notAuthorise.TabStop = true;
            this.notAuthorise.Text = "Не зареєстровані?";
            this.notAuthorise.VisitedLinkColor = System.Drawing.Color.Gray;
            this.notAuthorise.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.notAuthorise_LinkClicked);
            // 
            // log_in
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 340);
            this.Controls.Add(this.notAuthorise);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.paswordLable);
            this.Controls.Add(this.loginlable);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.loginTextBox);
            this.Controls.Add(this.logInButton);
            this.Name = "log_in";
            this.Text = "Увійти";
            this.Load += new System.EventHandler(this.log_in_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button logInButton;
        private TextBox loginTextBox;
        private PictureBox pictureBox1;
        private Label loginlable;
        private Label paswordLable;
        private TextBox passwordTextBox;
        private LinkLabel notAuthorise;
    }
}
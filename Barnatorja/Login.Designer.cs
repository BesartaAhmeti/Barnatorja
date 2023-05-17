namespace Barnatorja
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            btnAdmin = new Button();
            btnLogin = new Button();
            pictureBox2 = new PictureBox();
            txtUserName = new TextBox();
            label4 = new Label();
            label1 = new Label();
            label2 = new Label();
            txtPassword = new TextBox();
            label5 = new Label();
            pictureBox1 = new PictureBox();
            btnClose = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnClose).BeginInit();
            SuspendLayout();
            // 
            // btnAdmin
            // 
            btnAdmin.BackColor = SystemColors.InactiveCaption;
            btnAdmin.Font = new Font("Sitka Small", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdmin.Location = new Point(699, 355);
            btnAdmin.Name = "btnAdmin";
            btnAdmin.Size = new Size(89, 43);
            btnAdmin.TabIndex = 24;
            btnAdmin.Text = "Admin";
            btnAdmin.UseVisualStyleBackColor = false;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = SystemColors.InactiveCaption;
            btnLogin.Font = new Font("Sitka Small", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogin.Location = new Point(600, 355);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(89, 43);
            btnLogin.TabIndex = 23;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(600, 66);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(152, 116);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 22;
            pictureBox2.TabStop = false;
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(600, 241);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(188, 23);
            txtUserName.TabIndex = 21;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Sitka Small", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.DarkSlateGray;
            label4.Location = new Point(600, 210);
            label4.Name = "label4";
            label4.Size = new Size(113, 28);
            label4.TabIndex = 20;
            label4.Text = "Username";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Small", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.DarkSlateGray;
            label1.Location = new Point(240, 412);
            label1.Name = "label1";
            label1.Size = new Size(301, 28);
            label1.TabIndex = 19;
            label1.Text = "Punuar nga Besa dhe Emona";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sitka Small", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.DarkSlateGray;
            label2.Location = new Point(600, 283);
            label2.Name = "label2";
            label2.Size = new Size(109, 28);
            label2.TabIndex = 18;
            label2.Text = "Password";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(600, 314);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(188, 23);
            txtPassword.TabIndex = 17;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Sitka Small", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.DarkSlateGray;
            label5.Location = new Point(258, 29);
            label5.Name = "label5";
            label5.Size = new Size(283, 43);
            label5.TabIndex = 16;
            label5.Text = "Barnatorja BeEm";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(67, 94);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(322, 288);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // btnClose
            // 
            btnClose.Image = (Image)resources.GetObject("btnClose.Image");
            btnClose.Location = new Point(777, 2);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(36, 33);
            btnClose.SizeMode = PictureBoxSizeMode.Zoom;
            btnClose.TabIndex = 25;
            btnClose.TabStop = false;
            btnClose.Click += btnClose_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(816, 489);
            Controls.Add(btnClose);
            Controls.Add(btnAdmin);
            Controls.Add(btnLogin);
            Controls.Add(pictureBox2);
            Controls.Add(txtUserName);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(txtPassword);
            Controls.Add(label5);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnClose).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnAdmin;
        private Button btnLogin;
        private PictureBox pictureBox2;
        private TextBox txtUserName;
        private Label label4;
        private Label label1;
        private Label label2;
        private TextBox txtPassword;
        private Label label5;
        private PictureBox pictureBox1;
        private PictureBox btnClose;
    }
}
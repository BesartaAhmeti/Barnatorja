namespace Barnatorja
{
    partial class Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            pictureBox1 = new PictureBox();
            btnClose = new PictureBox();
            label5 = new Label();
            label1 = new Label();
            label4 = new Label();
            txtAdminPassword = new TextBox();
            pictureBox2 = new PictureBox();
            btnLogin = new Button();
            btnBack = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnClose).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(66, 95);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(322, 288);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 27;
            pictureBox1.TabStop = false;
            // 
            // btnClose
            // 
            btnClose.Image = (Image)resources.GetObject("btnClose.Image");
            btnClose.Location = new Point(775, 3);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(37, 33);
            btnClose.SizeMode = PictureBoxSizeMode.Zoom;
            btnClose.TabIndex = 37;
            btnClose.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Sitka Small", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.DarkSlateGray;
            label5.Location = new Point(257, 30);
            label5.Name = "label5";
            label5.Size = new Size(283, 43);
            label5.TabIndex = 28;
            label5.Text = "Barnatorja BeEm";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Small", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.DarkSlateGray;
            label1.Location = new Point(239, 413);
            label1.Name = "label1";
            label1.Size = new Size(301, 28);
            label1.TabIndex = 31;
            label1.Text = "Punuar nga Besa dhe Emona";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Sitka Small", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.DarkSlateGray;
            label4.Location = new Point(599, 202);
            label4.Name = "label4";
            label4.Size = new Size(181, 28);
            label4.TabIndex = 32;
            label4.Text = "Admin Password";
            // 
            // txtAdminPassword
            // 
            txtAdminPassword.Location = new Point(599, 242);
            txtAdminPassword.Name = "txtAdminPassword";
            txtAdminPassword.Size = new Size(188, 23);
            txtAdminPassword.TabIndex = 33;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(599, 67);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(152, 116);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 34;
            pictureBox2.TabStop = false;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = SystemColors.InactiveCaption;
            btnLogin.Font = new Font("Sitka Small", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogin.Location = new Point(599, 356);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(89, 43);
            btnLogin.TabIndex = 35;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            // 
            // btnBack
            // 
            btnBack.BackColor = SystemColors.InactiveCaption;
            btnBack.Font = new Font("Sitka Small", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnBack.Location = new Point(698, 356);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(89, 43);
            btnBack.TabIndex = 36;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            // 
            // Admin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(816, 489);
            Controls.Add(btnClose);
            Controls.Add(btnBack);
            Controls.Add(btnLogin);
            Controls.Add(pictureBox2);
            Controls.Add(txtAdminPassword);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(label5);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Admin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin";
            Load += Admin_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnClose).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox btnClose;
        private Label label5;
        private TextBox textBox1;
        private Label label2;
        private Label label1;
        private Label label4;
        private TextBox txtAdminPassword;
        private PictureBox pictureBox2;
        private Button btnLogin;
        private Button btnBack;
    }
}
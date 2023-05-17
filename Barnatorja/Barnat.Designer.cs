namespace Barnatorja
{
    partial class Barnat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Barnat));
            txtRate = new TextBox();
            txtQuantity = new TextBox();
            txtManufacturerId = new ComboBox();
            txtMedicineType = new ComboBox();
            label13 = new Label();
            label11 = new Label();
            DVGMedicines = new DataGridView();
            label10 = new Label();
            txtMedicineName = new TextBox();
            btnSave = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label2 = new Label();
            label3 = new Label();
            panel2 = new Panel();
            txtManufacturerName = new TextBox();
            panel1 = new Panel();
            pictureBox8 = new PictureBox();
            btnLogout = new Button();
            GoSelling = new PictureBox();
            btnSelling = new Button();
            GoSellers = new PictureBox();
            btnSellers = new Button();
            GoMedicines = new PictureBox();
            btnMedicines = new Button();
            GoManufacturer = new PictureBox();
            btnManufacturer = new Button();
            GoCustomers = new PictureBox();
            btnCustomers = new Button();
            GoDashboard = new PictureBox();
            btnDashboard = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            btnClose = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)DVGMedicines).BeginInit();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)GoSelling).BeginInit();
            ((System.ComponentModel.ISupportInitialize)GoSellers).BeginInit();
            ((System.ComponentModel.ISupportInitialize)GoMedicines).BeginInit();
            ((System.ComponentModel.ISupportInitialize)GoManufacturer).BeginInit();
            ((System.ComponentModel.ISupportInitialize)GoCustomers).BeginInit();
            ((System.ComponentModel.ISupportInitialize)GoDashboard).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnClose).BeginInit();
            SuspendLayout();
            // 
            // txtRate
            // 
            txtRate.Location = new Point(465, 83);
            txtRate.Name = "txtRate";
            txtRate.Size = new Size(80, 23);
            txtRate.TabIndex = 32;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(381, 83);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(78, 23);
            txtQuantity.TabIndex = 30;
            // 
            // txtManufacturerId
            // 
            txtManufacturerId.FormattingEnabled = true;
            txtManufacturerId.Location = new Point(551, 83);
            txtManufacturerId.Name = "txtManufacturerId";
            txtManufacturerId.Size = new Size(200, 23);
            txtManufacturerId.TabIndex = 29;
            // 
            // txtMedicineType
            // 
            txtMedicineType.FormattingEnabled = true;
            txtMedicineType.Location = new Point(206, 83);
            txtMedicineType.Name = "txtMedicineType";
            txtMedicineType.Size = new Size(169, 23);
            txtMedicineType.TabIndex = 26;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.White;
            label13.Font = new Font("Sitka Small", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label13.ForeColor = Color.DarkSlateGray;
            label13.Location = new Point(465, 47);
            label13.Name = "label13";
            label13.Size = new Size(46, 23);
            label13.TabIndex = 25;
            label13.Text = "Rate";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.White;
            label11.Font = new Font("Sitka Small", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = Color.DarkSlateGray;
            label11.Location = new Point(381, 47);
            label11.Name = "label11";
            label11.Size = new Size(52, 23);
            label11.TabIndex = 23;
            label11.Text = "Sasia";
            // 
            // DVGMedicines
            // 
            DVGMedicines.BackgroundColor = Color.White;
            DVGMedicines.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DVGMedicines.Location = new Point(15, 275);
            DVGMedicines.Name = "DVGMedicines";
            DVGMedicines.RowTemplate.Height = 25;
            DVGMedicines.Size = new Size(963, 337);
            DVGMedicines.TabIndex = 22;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.White;
            label10.Font = new Font("Sitka Small", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = Color.DarkSlateGray;
            label10.Location = new Point(381, 240);
            label10.Name = "label10";
            label10.Size = new Size(139, 23);
            label10.TabIndex = 21;
            label10.Text = "Lista e  Barnave";
            label10.Click += label10_Click;
            // 
            // txtMedicineName
            // 
            txtMedicineName.Location = new Point(15, 83);
            txtMedicineName.Name = "txtMedicineName";
            txtMedicineName.Size = new Size(185, 23);
            txtMedicineName.TabIndex = 16;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.Cyan;
            btnSave.FlatStyle = FlatStyle.Popup;
            btnSave.Font = new Font("Sitka Small", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnSave.ForeColor = Color.DarkSlateGray;
            btnSave.Location = new Point(278, 184);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(122, 36);
            btnSave.TabIndex = 15;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.Cyan;
            btnUpdate.FlatStyle = FlatStyle.Popup;
            btnUpdate.Font = new Font("Sitka Small", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdate.ForeColor = Color.DarkSlateGray;
            btnUpdate.Location = new Point(426, 184);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(122, 36);
            btnUpdate.TabIndex = 14;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Cyan;
            btnDelete.FlatStyle = FlatStyle.Popup;
            btnDelete.Font = new Font("Sitka Small", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnDelete.ForeColor = Color.DarkSlateGray;
            btnDelete.Location = new Point(570, 184);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(122, 36);
            btnDelete.TabIndex = 13;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.White;
            label8.Font = new Font("Sitka Small", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.DarkSlateGray;
            label8.Location = new Point(757, 47);
            label8.Name = "label8";
            label8.Size = new Size(155, 23);
            label8.TabIndex = 8;
            label8.Text = "Emri i Kompanise";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.White;
            label7.Font = new Font("Sitka Small", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.DarkSlateGray;
            label7.Location = new Point(15, 47);
            label7.Name = "label7";
            label7.Size = new Size(121, 23);
            label7.TabIndex = 7;
            label7.Text = "Emri i Barnes";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.White;
            label6.Font = new Font("Sitka Small", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.DarkSlateGray;
            label6.Location = new Point(206, 47);
            label6.Name = "label6";
            label6.Size = new Size(119, 23);
            label6.TabIndex = 6;
            label6.Text = "Lloji i Barnes";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.White;
            label5.Font = new Font("Sitka Small", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.DarkSlateGray;
            label5.Location = new Point(551, 47);
            label5.Name = "label5";
            label5.Size = new Size(115, 23);
            label5.TabIndex = 5;
            label5.Text = "Kompania ID";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Font = new Font("Sitka Small", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.DarkSlateGray;
            label4.Location = new Point(15, 11);
            label4.Name = "label4";
            label4.Size = new Size(153, 23);
            label4.TabIndex = 4;
            label4.Text = "Detajet e Barnave";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sitka Small", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.DarkSlateGray;
            label2.Location = new Point(471, 3);
            label2.Name = "label2";
            label2.Size = new Size(283, 43);
            label2.TabIndex = 31;
            label2.Text = "Barnatorja BeEm";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sitka Small", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.DarkSlateGray;
            label3.Location = new Point(543, 46);
            label3.Name = "label3";
            label3.Size = new Size(105, 23);
            label3.TabIndex = 32;
            label3.Text = "Versioni 1.0";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(txtRate);
            panel2.Controls.Add(txtManufacturerName);
            panel2.Controls.Add(txtQuantity);
            panel2.Controls.Add(txtManufacturerId);
            panel2.Controls.Add(txtMedicineType);
            panel2.Controls.Add(label13);
            panel2.Controls.Add(label11);
            panel2.Controls.Add(DVGMedicines);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(txtMedicineName);
            panel2.Controls.Add(btnSave);
            panel2.Controls.Add(btnUpdate);
            panel2.Controls.Add(btnDelete);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Location = new Point(265, 87);
            panel2.Name = "panel2";
            panel2.Size = new Size(993, 630);
            panel2.TabIndex = 30;
            // 
            // txtManufacturerName
            // 
            txtManufacturerName.Location = new Point(757, 83);
            txtManufacturerName.Name = "txtManufacturerName";
            txtManufacturerName.Size = new Size(205, 23);
            txtManufacturerName.TabIndex = 31;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(pictureBox8);
            panel1.Controls.Add(btnLogout);
            panel1.Controls.Add(GoSelling);
            panel1.Controls.Add(btnSelling);
            panel1.Controls.Add(GoSellers);
            panel1.Controls.Add(btnSellers);
            panel1.Controls.Add(GoMedicines);
            panel1.Controls.Add(btnMedicines);
            panel1.Controls.Add(GoManufacturer);
            panel1.Controls.Add(btnManufacturer);
            panel1.Controls.Add(GoCustomers);
            panel1.Controls.Add(btnCustomers);
            panel1.Controls.Add(GoDashboard);
            panel1.Controls.Add(btnDashboard);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(253, 729);
            panel1.TabIndex = 33;
            // 
            // pictureBox8
            // 
            pictureBox8.Image = (Image)resources.GetObject("pictureBox8.Image");
            pictureBox8.Location = new Point(19, 683);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(41, 34);
            pictureBox8.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox8.TabIndex = 22;
            pictureBox8.TabStop = false;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.LightCyan;
            btnLogout.FlatStyle = FlatStyle.Popup;
            btnLogout.Font = new Font("Sitka Small", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogout.ForeColor = Color.DarkSlateGray;
            btnLogout.Location = new Point(66, 686);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(177, 31);
            btnLogout.TabIndex = 21;
            btnLogout.Text = "Dil";
            btnLogout.UseVisualStyleBackColor = false;
            // 
            // GoSelling
            // 
            GoSelling.Image = (Image)resources.GetObject("GoSelling.Image");
            GoSelling.Location = new Point(12, 485);
            GoSelling.Name = "GoSelling";
            GoSelling.Size = new Size(48, 37);
            GoSelling.SizeMode = PictureBoxSizeMode.StretchImage;
            GoSelling.TabIndex = 20;
            GoSelling.TabStop = false;
            // 
            // btnSelling
            // 
            btnSelling.BackColor = Color.LightCyan;
            btnSelling.FlatStyle = FlatStyle.Popup;
            btnSelling.Font = new Font("Sitka Small", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnSelling.ForeColor = Color.DarkSlateGray;
            btnSelling.Location = new Point(66, 486);
            btnSelling.Name = "btnSelling";
            btnSelling.Size = new Size(177, 36);
            btnSelling.TabIndex = 19;
            btnSelling.Text = "Shitjet";
            btnSelling.UseVisualStyleBackColor = false;
            // 
            // GoSellers
            // 
            GoSellers.Image = (Image)resources.GetObject("GoSellers.Image");
            GoSellers.Location = new Point(12, 430);
            GoSellers.Name = "GoSellers";
            GoSellers.Size = new Size(48, 36);
            GoSellers.SizeMode = PictureBoxSizeMode.StretchImage;
            GoSellers.TabIndex = 18;
            GoSellers.TabStop = false;
            // 
            // btnSellers
            // 
            btnSellers.BackColor = Color.LightCyan;
            btnSellers.FlatStyle = FlatStyle.Popup;
            btnSellers.Font = new Font("Sitka Small", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnSellers.ForeColor = Color.DarkSlateGray;
            btnSellers.Location = new Point(66, 430);
            btnSellers.Name = "btnSellers";
            btnSellers.Size = new Size(177, 36);
            btnSellers.TabIndex = 17;
            btnSellers.Text = "Shitesi";
            btnSellers.UseVisualStyleBackColor = false;
            // 
            // GoMedicines
            // 
            GoMedicines.Image = (Image)resources.GetObject("GoMedicines.Image");
            GoMedicines.Location = new Point(12, 319);
            GoMedicines.Name = "GoMedicines";
            GoMedicines.Size = new Size(48, 36);
            GoMedicines.SizeMode = PictureBoxSizeMode.StretchImage;
            GoMedicines.TabIndex = 16;
            GoMedicines.TabStop = false;
            // 
            // btnMedicines
            // 
            btnMedicines.BackColor = Color.Cyan;
            btnMedicines.FlatStyle = FlatStyle.Popup;
            btnMedicines.Font = new Font("Sitka Small", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnMedicines.ForeColor = Color.DarkSlateGray;
            btnMedicines.Location = new Point(66, 319);
            btnMedicines.Name = "btnMedicines";
            btnMedicines.Size = new Size(177, 36);
            btnMedicines.TabIndex = 15;
            btnMedicines.Text = "Barnat";
            btnMedicines.UseVisualStyleBackColor = false;
            // 
            // GoManufacturer
            // 
            GoManufacturer.Image = (Image)resources.GetObject("GoManufacturer.Image");
            GoManufacturer.Location = new Point(12, 263);
            GoManufacturer.Name = "GoManufacturer";
            GoManufacturer.Size = new Size(48, 36);
            GoManufacturer.SizeMode = PictureBoxSizeMode.StretchImage;
            GoManufacturer.TabIndex = 14;
            GoManufacturer.TabStop = false;
            // 
            // btnManufacturer
            // 
            btnManufacturer.BackColor = Color.LightCyan;
            btnManufacturer.FlatStyle = FlatStyle.Popup;
            btnManufacturer.Font = new Font("Sitka Small", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnManufacturer.ForeColor = Color.DarkSlateGray;
            btnManufacturer.Location = new Point(66, 263);
            btnManufacturer.Name = "btnManufacturer";
            btnManufacturer.Size = new Size(177, 36);
            btnManufacturer.TabIndex = 13;
            btnManufacturer.Text = "Kompanite";
            btnManufacturer.UseVisualStyleBackColor = false;
            // 
            // GoCustomers
            // 
            GoCustomers.Image = (Image)resources.GetObject("GoCustomers.Image");
            GoCustomers.Location = new Point(12, 375);
            GoCustomers.Name = "GoCustomers";
            GoCustomers.Size = new Size(48, 36);
            GoCustomers.SizeMode = PictureBoxSizeMode.StretchImage;
            GoCustomers.TabIndex = 12;
            GoCustomers.TabStop = false;
            // 
            // btnCustomers
            // 
            btnCustomers.BackColor = Color.LightCyan;
            btnCustomers.FlatStyle = FlatStyle.Popup;
            btnCustomers.Font = new Font("Sitka Small", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnCustomers.ForeColor = Color.DarkSlateGray;
            btnCustomers.Location = new Point(66, 375);
            btnCustomers.Name = "btnCustomers";
            btnCustomers.Size = new Size(177, 36);
            btnCustomers.TabIndex = 11;
            btnCustomers.Text = "Klienti";
            btnCustomers.UseVisualStyleBackColor = false;
            // 
            // GoDashboard
            // 
            GoDashboard.Image = (Image)resources.GetObject("GoDashboard.Image");
            GoDashboard.Location = new Point(12, 207);
            GoDashboard.Name = "GoDashboard";
            GoDashboard.Size = new Size(48, 36);
            GoDashboard.SizeMode = PictureBoxSizeMode.StretchImage;
            GoDashboard.TabIndex = 10;
            GoDashboard.TabStop = false;
            // 
            // btnDashboard
            // 
            btnDashboard.BackColor = Color.LightCyan;
            btnDashboard.BackgroundImageLayout = ImageLayout.None;
            btnDashboard.FlatStyle = FlatStyle.Popup;
            btnDashboard.Font = new Font("Sitka Small", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnDashboard.ForeColor = Color.DarkSlateGray;
            btnDashboard.Location = new Point(66, 207);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(177, 36);
            btnDashboard.TabIndex = 9;
            btnDashboard.Text = "Dashboard";
            btnDashboard.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Small", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.DarkSlateGray;
            label1.Location = new Point(95, 29);
            label1.Name = "label1";
            label1.Size = new Size(148, 23);
            label1.TabIndex = 3;
            label1.Text = "Barnatorja BeEm";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(86, 72);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // btnClose
            // 
            btnClose.Image = (Image)resources.GetObject("btnClose.Image");
            btnClose.Location = new Point(1217, 3);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(41, 35);
            btnClose.SizeMode = PictureBoxSizeMode.Zoom;
            btnClose.TabIndex = 34;
            btnClose.TabStop = false;
            // 
            // Barnat
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1264, 729);
            Controls.Add(btnClose);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Barnat";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Barnat";
            ((System.ComponentModel.ISupportInitialize)DVGMedicines).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)GoSelling).EndInit();
            ((System.ComponentModel.ISupportInitialize)GoSellers).EndInit();
            ((System.ComponentModel.ISupportInitialize)GoMedicines).EndInit();
            ((System.ComponentModel.ISupportInitialize)GoManufacturer).EndInit();
            ((System.ComponentModel.ISupportInitialize)GoCustomers).EndInit();
            ((System.ComponentModel.ISupportInitialize)GoDashboard).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnClose).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtRate;
        private TextBox txtQuantity;
        private ComboBox txtManufacturerId;
        private ComboBox txtMedicineType;
        private Label label13;
        private Label label11;
        private DataGridView DVGMedicines;
        private Label label10;
        private TextBox txtMedicineName;
        private Button btnSave;
        private Button btnUpdate;
        private Button btnDelete;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label2;
        private Label label3;
        private Panel panel2;
        private TextBox txtManufacturerName;
        private Panel panel1;
        private PictureBox pictureBox8;
        private Button btnLogout;
        private PictureBox GoSelling;
        private Button btnSelling;
        private PictureBox GoSellers;
        private Button btnSellers;
        private PictureBox GoMedicines;
        private Button btnMedicines;
        private PictureBox GoManufacturer;
        private Button btnManufacturer;
        private PictureBox GoCustomers;
        private Button btnCustomers;
        private PictureBox GoDashboard;
        private Button btnDashboard;
        private Label label1;
        private PictureBox pictureBox1;
        private PictureBox btnClose;
    }
}
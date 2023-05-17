namespace Barnatorja
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Percentage = new Label();
            ProgressBar1 = new ProgressBar();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            btnClose = new PictureBox();
            Timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnClose).BeginInit();
            SuspendLayout();
            // 
            // Percentage
            // 
            Percentage.AutoSize = true;
            Percentage.ForeColor = Color.DarkSlateGray;
            Percentage.Location = new Point(665, 465);
            Percentage.Name = "Percentage";
            Percentage.Size = new Size(17, 15);
            Percentage.TabIndex = 11;
            Percentage.Text = "%";
            // 
            // ProgressBar1
            // 
            ProgressBar1.Dock = DockStyle.Bottom;
            ProgressBar1.Location = new Point(0, 557);
            ProgressBar1.Name = "ProgressBar1";
            ProgressBar1.Size = new Size(913, 10);
            ProgressBar1.TabIndex = 10;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(732, 406);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(123, 74);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sitka Small", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.DarkSlateGray;
            label2.Location = new Point(208, 455);
            label2.Name = "label2";
            label2.Size = new Size(463, 28);
            label2.TabIndex = 8;
            label2.Text = "Aplikacioni duke u hapur.. ju lutem pritni... ";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(233, 103);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(438, 341);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Small", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.DarkSlateGray;
            label1.Location = new Point(293, 41);
            label1.Name = "label1";
            label1.Size = new Size(283, 43);
            label1.TabIndex = 6;
            label1.Text = "Barnatorja BeEm";
            // 
            // btnClose
            // 
            btnClose.Image = (Image)resources.GetObject("btnClose.Image");
            btnClose.Location = new Point(875, 3);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(38, 33);
            btnClose.SizeMode = PictureBoxSizeMode.Zoom;
            btnClose.TabIndex = 12;
            btnClose.TabStop = false;
            btnClose.UseWaitCursor = true;
            btnClose.Click += pictureBox3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(913, 567);
            Controls.Add(btnClose);
            Controls.Add(Percentage);
            Controls.Add(ProgressBar1);
            Controls.Add(pictureBox2);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnClose).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Percentage;
        private ProgressBar ProgressBar1;
        private PictureBox pictureBox2;
        private Label label2;
        private PictureBox pictureBox1;
        private Label label1;
        private PictureBox btnClose;
        private System.Windows.Forms.Timer Timer1;
    }
}
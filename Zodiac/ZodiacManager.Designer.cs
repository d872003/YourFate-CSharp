namespace Zodiac
{
    partial class ZodiacManager
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
            lblHeader = new Label();
            picImg = new PictureBox();
            btnShowImg = new Button();
            pnlImage = new Panel();
            btnCheckZodiac = new Button();
            btnQuit = new Button();
            lblDay = new Label();
            lblMonth = new Label();
            lblYourZodiac = new Label();
            txtDay = new TextBox();
            txtMonth = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)picImg).BeginInit();
            pnlImage.SuspendLayout();
            SuspendLayout();
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.BackColor = Color.Indigo;
            lblHeader.BorderStyle = BorderStyle.Fixed3D;
            lblHeader.Font = new Font("Segoe Script", 52F, FontStyle.Bold, GraphicsUnit.Point);
            lblHeader.Location = new Point(71, 52);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(358, 118);
            lblHeader.TabIndex = 0;
            lblHeader.Text = "ZODIAC\r\n";
            lblHeader.Click += label1_Click;
            // 
            // picImg
            // 
            picImg.BackColor = Color.Black;
            picImg.Location = new Point(12, 9);
            picImg.Name = "picImg";
            picImg.Size = new Size(611, 608);
            picImg.SizeMode = PictureBoxSizeMode.StretchImage;
            picImg.TabIndex = 1;
            picImg.TabStop = false;
            picImg.Click += pictureBox1_Click;
            // 
            // btnShowImg
            // 
            btnShowImg.FlatStyle = FlatStyle.Flat;
            btnShowImg.Location = new Point(186, 456);
            btnShowImg.Name = "btnShowImg";
            btnShowImg.Size = new Size(112, 42);
            btnShowImg.TabIndex = 3;
            btnShowImg.Text = "Show Image";
            btnShowImg.UseVisualStyleBackColor = true;
            btnShowImg.Click += button1_Click;
            // 
            // pnlImage
            // 
            pnlImage.AutoScroll = true;
            pnlImage.BackColor = Color.DarkSlateBlue;
            pnlImage.Controls.Add(picImg);
            pnlImage.Location = new Point(548, 188);
            pnlImage.Name = "pnlImage";
            pnlImage.Size = new Size(634, 628);
            pnlImage.TabIndex = 3;
            // 
            // btnCheckZodiac
            // 
            btnCheckZodiac.FlatStyle = FlatStyle.Flat;
            btnCheckZodiac.Location = new Point(36, 456);
            btnCheckZodiac.Name = "btnCheckZodiac";
            btnCheckZodiac.Size = new Size(112, 42);
            btnCheckZodiac.TabIndex = 2;
            btnCheckZodiac.Text = "Check Zodiac";
            btnCheckZodiac.UseVisualStyleBackColor = true;
            btnCheckZodiac.Click += button1_Click_1;
            // 
            // btnQuit
            // 
            btnQuit.FlatStyle = FlatStyle.Flat;
            btnQuit.Location = new Point(1046, 52);
            btnQuit.Name = "btnQuit";
            btnQuit.Size = new Size(125, 65);
            btnQuit.TabIndex = 4;
            btnQuit.Text = "Quit";
            btnQuit.UseVisualStyleBackColor = true;
            btnQuit.Click += btnQuit_Click;
            // 
            // lblDay
            // 
            lblDay.AutoSize = true;
            lblDay.BackColor = Color.Indigo;
            lblDay.BorderStyle = BorderStyle.Fixed3D;
            lblDay.Font = new Font("Segoe Script", 16F, FontStyle.Bold, GraphicsUnit.Point);
            lblDay.Location = new Point(36, 296);
            lblDay.Name = "lblDay";
            lblDay.Size = new Size(194, 39);
            lblDay.TabIndex = 7;
            lblDay.Text = "Your Birth Day";
            lblDay.Click += lblDay_Click;
            // 
            // lblMonth
            // 
            lblMonth.AutoSize = true;
            lblMonth.BackColor = Color.Indigo;
            lblMonth.BorderStyle = BorderStyle.Fixed3D;
            lblMonth.Font = new Font("Segoe Script", 16F, FontStyle.Bold, GraphicsUnit.Point);
            lblMonth.Location = new Point(36, 368);
            lblMonth.Name = "lblMonth";
            lblMonth.Size = new Size(224, 39);
            lblMonth.TabIndex = 8;
            lblMonth.Text = "Your Birth Month";
            lblMonth.Click += label1_Click_1;
            // 
            // lblYourZodiac
            // 
            lblYourZodiac.AutoSize = true;
            lblYourZodiac.BackColor = Color.Indigo;
            lblYourZodiac.BorderStyle = BorderStyle.Fixed3D;
            lblYourZodiac.Cursor = Cursors.IBeam;
            lblYourZodiac.FlatStyle = FlatStyle.Flat;
            lblYourZodiac.Font = new Font("Segoe Script", 28F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblYourZodiac.Location = new Point(36, 543);
            lblYourZodiac.Name = "lblYourZodiac";
            lblYourZodiac.Size = new Size(410, 65);
            lblYourZodiac.TabIndex = 9;
            lblYourZodiac.Text = "Your Zodiac Sign :";
            lblYourZodiac.TextAlign = ContentAlignment.MiddleCenter;
            lblYourZodiac.Click += label1_Click_2;
            // 
            // txtDay
            // 
            txtDay.BackColor = Color.Indigo;
            txtDay.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            txtDay.ForeColor = Color.Fuchsia;
            txtDay.Location = new Point(307, 297);
            txtDay.Name = "txtDay";
            txtDay.Size = new Size(184, 36);
            txtDay.TabIndex = 0;
            txtDay.Text = "1";
            txtDay.TextAlign = HorizontalAlignment.Center;
            txtDay.TextChanged += txtDay_TextChanged;
            // 
            // txtMonth
            // 
            txtMonth.BackColor = Color.Indigo;
            txtMonth.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            txtMonth.ForeColor = Color.Fuchsia;
            txtMonth.Location = new Point(307, 369);
            txtMonth.Name = "txtMonth";
            txtMonth.Size = new Size(184, 36);
            txtMonth.TabIndex = 1;
            txtMonth.Text = "1";
            txtMonth.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Indigo;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Mongolian Baiti", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(36, 778);
            label1.Name = "label1";
            label1.Size = new Size(144, 22);
            label1.TabIndex = 10;
            label1.Text = "© 2024 QuocDat";
            label1.Click += label1_Click_3;
            // 
            // ZodiacManager
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Indigo;
            BackgroundImage = Properties.Resources.wp7051696_space_8k_wallpapers;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1208, 837);
            Controls.Add(label1);
            Controls.Add(txtMonth);
            Controls.Add(txtDay);
            Controls.Add(lblYourZodiac);
            Controls.Add(lblMonth);
            Controls.Add(lblDay);
            Controls.Add(btnQuit);
            Controls.Add(btnCheckZodiac);
            Controls.Add(pnlImage);
            Controls.Add(btnShowImg);
            Controls.Add(lblHeader);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ForeColor = Color.FromArgb(255, 192, 255);
            Name = "ZodiacManager";
            Text = "Zodiac";
            Load += ZodiacManager_Load;
            ((System.ComponentModel.ISupportInitialize)picImg).EndInit();
            pnlImage.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblHeader;
        private PictureBox picImg;
        private Button btnShowImg;
        private Panel pnlImage;
        private Button btnCheckZodiac;
        private Button btnQuit;
        private Label lblDay;
        private Label lblMonth;
        private Label lblYourZodiac;
        private TextBox txtDay;
        private TextBox txtMonth;
        private Label label1;
    }
}

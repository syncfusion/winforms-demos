namespace EssentialXlsIOSample
{
	partial class StockReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StockReport));
            this.ImageChDialog = new System.Windows.Forms.OpenFileDialog();
            this.FolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.btnCreateReport = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.StockList = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.StartDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.isCornersRound = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.EndDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.bacgrimage = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.viewInputTemplate = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.reportdir = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbExcel2013 = new System.Windows.Forms.RadioButton();
            this.rdbExcel2010 = new System.Windows.Forms.RadioButton();
            this.rdbExcek2007 = new System.Windows.Forms.RadioButton();
            this.rdbExcel97 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ImageChDialog
            // 
            this.ImageChDialog.FileName = "openFileDialog1";
            // 
            // btnCreateReport
            // 
            this.btnCreateReport.Location = new System.Drawing.Point(376, 437);
            this.btnCreateReport.Name = "btnCreateReport";
            this.btnCreateReport.Size = new System.Drawing.Size(100, 28);
            this.btnCreateReport.TabIndex = 6;
            this.btnCreateReport.Text = "Create report";
            this.btnCreateReport.UseVisualStyleBackColor = true;
            this.btnCreateReport.Click += new System.EventHandler(this.btnCreateReport_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(482, 78);
            this.pictureBox1.TabIndex = 61;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 495);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(482, 18);
            this.pictureBox2.TabIndex = 66;
            this.pictureBox2.TabStop = false;
            // 
            // label10
            // 
            this.label10.Dock = System.Windows.Forms.DockStyle.Top;
            this.label10.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(0, 78);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(482, 103);
            this.label10.TabIndex = 71;
            this.label10.Text = resources.GetString("label10.Text");
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(21, 214);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 14);
            this.label1.TabIndex = 7;
            this.label1.Text = "Select one or more stocks: ";
            // 
            // StockList
            // 
            this.StockList.FormattingEnabled = true;
            this.StockList.Items.AddRange(new object[] {
            "AAPL",
            "ADBE",
            "AMD",
            "AMZN",
            "BF.B",
            "BRCM",
            "CSCO",
            "DELL",
            "EBAY",
            "GOOG",
            "IBM",
            "INTC",
            "JDSU",
            "JNPR",
            "MSFT",
            "ORCL",
            "QCOM",
            "SYMC",
            "YHOO"});
            this.StockList.Location = new System.Drawing.Point(24, 248);
            this.StockList.Name = "StockList";
            this.StockList.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.StockList.Size = new System.Drawing.Size(181, 160);
            this.StockList.Sorted = true;
            this.StockList.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(21, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(184, 14);
            this.label4.TabIndex = 10;
            this.label4.Text = "To select more than one hold Ctrl key";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label6.Image = ((System.Drawing.Image)(resources.GetObject("label6.Image")));
            this.label6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label6.Location = new System.Drawing.Point(21, 180);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 24);
            this.label6.TabIndex = 67;
            this.label6.Text = "Stocks";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // StartDateTimePicker
            // 
            this.StartDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartDateTimePicker.Location = new System.Drawing.Point(261, 230);
            this.StartDateTimePicker.MaxDate = new System.DateTime(2008, 1, 29, 0, 0, 0, 0);
            this.StartDateTimePicker.MinDate = new System.DateTime(2007, 12, 31, 0, 0, 0, 0);
            this.StartDateTimePicker.Name = "StartDateTimePicker";
            this.StartDateTimePicker.Size = new System.Drawing.Size(199, 20);
            this.StartDateTimePicker.TabIndex = 3;
            this.StartDateTimePicker.Value = new System.DateTime(2008, 1, 1, 0, 0, 0, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label2.Location = new System.Drawing.Point(260, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 14);
            this.label2.TabIndex = 5;
            this.label2.Text = "Start Data";
            // 
            // isCornersRound
            // 
            this.isCornersRound.AutoSize = true;
            this.isCornersRound.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.isCornersRound.Location = new System.Drawing.Point(263, 370);
            this.isCornersRound.Name = "isCornersRound";
            this.isCornersRound.Size = new System.Drawing.Size(165, 18);
            this.isCornersRound.TabIndex = 0;
            this.isCornersRound.Text = "Curved borders for the chart";
            this.isCornersRound.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label3.Location = new System.Drawing.Point(259, 257);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 14);
            this.label3.TabIndex = 6;
            this.label3.Text = "End Data";
            // 
            // EndDateTimePicker
            // 
            this.EndDateTimePicker.Location = new System.Drawing.Point(261, 274);
            this.EndDateTimePicker.MaxDate = new System.DateTime(2008, 1, 29, 0, 0, 0, 0);
            this.EndDateTimePicker.MinDate = new System.DateTime(2007, 12, 31, 0, 0, 0, 0);
            this.EndDateTimePicker.Name = "EndDateTimePicker";
            this.EndDateTimePicker.Size = new System.Drawing.Size(199, 20);
            this.EndDateTimePicker.TabIndex = 4;
            this.EndDateTimePicker.Value = new System.DateTime(2008, 1, 29, 0, 0, 0, 0);
            // 
            // bacgrimage
            // 
            this.bacgrimage.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.bacgrimage.Location = new System.Drawing.Point(440, 338);
            this.bacgrimage.Name = "bacgrimage";
            this.bacgrimage.Size = new System.Drawing.Size(20, 20);
            this.bacgrimage.TabIndex = 1;
            this.bacgrimage.Text = "...";
            this.bacgrimage.UseVisualStyleBackColor = true;
            this.bacgrimage.Click += new System.EventHandler(this.bacgrimage_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label8.Location = new System.Drawing.Point(259, 342);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(149, 14);
            this.label8.TabIndex = 69;
            this.label8.Text = "Select the BackGround Image";
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(164)))), ((int)(((byte)(190)))));
            this.label11.Location = new System.Drawing.Point(21, 203);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(185, 1);
            this.label11.TabIndex = 73;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label7.Image = ((System.Drawing.Image)(resources.GetObject("label7.Image")));
            this.label7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label7.Location = new System.Drawing.Point(260, 178);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 24);
            this.label7.TabIndex = 68;
            this.label7.Text = "TimeLine";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(164)))), ((int)(((byte)(190)))));
            this.label14.Location = new System.Drawing.Point(260, 203);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(200, 1);
            this.label14.TabIndex = 72;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(164)))), ((int)(((byte)(190)))));
            this.label5.Location = new System.Drawing.Point(263, 330);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(200, 1);
            this.label5.TabIndex = 75;
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label12.Image = ((System.Drawing.Image)(resources.GetObject("label12.Image")));
            this.label12.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label12.Location = new System.Drawing.Point(260, 305);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(106, 24);
            this.label12.TabIndex = 74;
            this.label12.Text = "Look And Feel";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // viewInputTemplate
            // 
            this.viewInputTemplate.Location = new System.Drawing.Point(261, 438);
            this.viewInputTemplate.Name = "viewInputTemplate";
            this.viewInputTemplate.Size = new System.Drawing.Size(100, 28);
            this.viewInputTemplate.TabIndex = 76;
            this.viewInputTemplate.Text = "Input Template";
            this.viewInputTemplate.UseVisualStyleBackColor = true;
            this.viewInputTemplate.Click += new System.EventHandler(this.viewInputTemplate_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label9.Location = new System.Drawing.Point(260, 394);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(137, 14);
            this.label9.TabIndex = 78;
            this.label9.Text = "Select the Report Directory";
            // 
            // reportdir
            // 
            this.reportdir.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.reportdir.Location = new System.Drawing.Point(440, 388);
            this.reportdir.Name = "reportdir";
            this.reportdir.Size = new System.Drawing.Size(20, 20);
            this.reportdir.TabIndex = 77;
            this.reportdir.Text = "...";
            this.reportdir.UseVisualStyleBackColor = true;
            this.reportdir.Click += new System.EventHandler(this.reportdir_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbExcel2013);
            this.groupBox1.Controls.Add(this.rdbExcel2010);
            this.groupBox1.Controls.Add(this.rdbExcek2007);
            this.groupBox1.Controls.Add(this.rdbExcel97);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(24, 417);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(182, 72);
            this.groupBox1.TabIndex = 79;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Save As";
            // 
            // rdbExcel2013
            // 
            this.rdbExcel2013.AutoSize = true;
            this.rdbExcel2013.Checked = true;
            this.rdbExcel2013.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbExcel2013.Location = new System.Drawing.Point(80, 46);
            this.rdbExcel2013.Name = "rdbExcel2013";
            this.rdbExcel2013.Size = new System.Drawing.Size(78, 17);
            this.rdbExcel2013.TabIndex = 3;
            this.rdbExcel2013.TabStop = true;
            this.rdbExcel2013.Text = "Excel 2013";
            this.rdbExcel2013.UseVisualStyleBackColor = true;
            // 
            // rdbExcel2010
            // 
            this.rdbExcel2010.AutoSize = true;
            this.rdbExcel2010.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbExcel2010.Location = new System.Drawing.Point(0, 46);
            this.rdbExcel2010.Name = "rdbExcel2010";
            this.rdbExcel2010.Size = new System.Drawing.Size(78, 17);
            this.rdbExcel2010.TabIndex = 2;
            this.rdbExcel2010.Text = "Excel 2010";
            this.rdbExcel2010.UseVisualStyleBackColor = true;
            // 
            // rdbExcek2007
            // 
            this.rdbExcek2007.AutoSize = true;
            this.rdbExcek2007.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbExcek2007.Location = new System.Drawing.Point(80, 13);
            this.rdbExcek2007.Name = "rdbExcek2007";
            this.rdbExcek2007.Size = new System.Drawing.Size(78, 17);
            this.rdbExcek2007.TabIndex = 1;
            this.rdbExcek2007.Text = "Excel 2007";
            this.rdbExcek2007.UseVisualStyleBackColor = true;
            // 
            // rdbExcel97
            // 
            this.rdbExcel97.AutoSize = true;
            this.rdbExcel97.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbExcel97.Location = new System.Drawing.Point(0, 13);
            this.rdbExcel97.Name = "rdbExcel97";
            this.rdbExcel97.Size = new System.Drawing.Size(78, 17);
            this.rdbExcel97.TabIndex = 0;
            this.rdbExcel97.Text = "Excel 2003";
            this.rdbExcel97.UseVisualStyleBackColor = true;
            // 
            // StockReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(239)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(482, 513);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.reportdir);
            this.Controls.Add(this.viewInputTemplate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.StockList);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.bacgrimage);
            this.Controls.Add(this.EndDateTimePicker);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.isCornersRound);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.StartDateTimePicker);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCreateReport);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "StockReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stock Portfolio";
            this.Load += new System.EventHandler(this.StockReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.OpenFileDialog ImageChDialog;
        private System.Windows.Forms.FolderBrowserDialog FolderBrowserDialog;
        private System.Windows.Forms.Button btnCreateReport;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox StockList;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker StartDateTimePicker;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox isCornersRound;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker EndDateTimePicker;
        private System.Windows.Forms.Button bacgrimage;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button viewInputTemplate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button reportdir;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbExcel2013;
        private System.Windows.Forms.RadioButton rdbExcel2010;
        private System.Windows.Forms.RadioButton rdbExcek2007;
        private System.Windows.Forms.RadioButton rdbExcel97;
	}
}


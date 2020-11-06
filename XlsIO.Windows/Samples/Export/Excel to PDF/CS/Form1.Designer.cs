#region Copyright Syncfusion Inc. 2001-2020.
// Copyright Syncfusion Inc. 2001-2020. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
namespace ExceltoPDF
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label24 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.button3 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.excelToPdfConvertbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.onePageRadioBtn = new System.Windows.Forms.RadioButton();
            this.allColumnRadioBtn = new System.Windows.Forms.RadioButton();
            this.allRowsRadioBtn = new System.Windows.Forms.RadioButton();
            this.noScaleRadioBtn = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.checkfontStream = new System.Windows.Forms.CheckBox();
            this.checkfontName = new System.Windows.Forms.CheckBox();
            this.Input = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label24
            // 
            this.label24.Image = ((System.Drawing.Image)(resources.GetObject("label24.Image")));
            this.label24.Location = new System.Drawing.Point(180, 543);
            this.label24.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(30, 28);
            this.label24.TabIndex = 94;
            this.toolTip1.SetToolTip(this.label24, "Browse for a word document to convert it to Pdf");
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button3.Location = new System.Drawing.Point(522, 570);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(32, 32);
            this.button3.TabIndex = 92;
            this.button3.Text = ". . .";
            this.button3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.browseExcelFileBtnClick);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(9, 571);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(498, 26);
            this.textBox1.TabIndex = 91;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label9.Location = new System.Drawing.Point(4, 546);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(162, 20);
            this.label9.TabIndex = 90;
            this.label9.Text = "Excel Document";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(566, 71);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 89;
            this.pictureBox1.TabStop = false;
            // 
            // excelToPdfConvertbtn
            // 
            this.excelToPdfConvertbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.excelToPdfConvertbtn.BackColor = System.Drawing.Color.Transparent;
            this.excelToPdfConvertbtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.excelToPdfConvertbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.excelToPdfConvertbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.excelToPdfConvertbtn.Image = ((System.Drawing.Image)(resources.GetObject("excelToPdfConvertbtn.Image")));
            this.excelToPdfConvertbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.excelToPdfConvertbtn.Location = new System.Drawing.Point(347, 613);
            this.excelToPdfConvertbtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.excelToPdfConvertbtn.Name = "excelToPdfConvertbtn";
            this.excelToPdfConvertbtn.Size = new System.Drawing.Size(201, 40);
            this.excelToPdfConvertbtn.TabIndex = 96;
            this.excelToPdfConvertbtn.Text = "Excel to PDF";
            this.excelToPdfConvertbtn.UseVisualStyleBackColor = false;
            this.excelToPdfConvertbtn.Click += new System.EventHandler(this.excelToPdfConvertBtnClick);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label1.Location = new System.Drawing.Point(3, 155);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(562, 94);
            this.label1.TabIndex = 97;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.onePageRadioBtn);
            this.groupBox1.Controls.Add(this.allColumnRadioBtn);
            this.groupBox1.Controls.Add(this.allRowsRadioBtn);
            this.groupBox1.Controls.Add(this.noScaleRadioBtn);
            this.groupBox1.Location = new System.Drawing.Point(9, 255);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(544, 125);
            this.groupBox1.TabIndex = 98;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pdf Page Setup Options";
            // 
            // onePageRadioBtn
            // 
            this.onePageRadioBtn.AutoSize = true;
            this.onePageRadioBtn.Location = new System.Drawing.Point(278, 77);
            this.onePageRadioBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.onePageRadioBtn.Name = "onePageRadioBtn";
            this.onePageRadioBtn.Size = new System.Drawing.Size(199, 24);
            this.onePageRadioBtn.TabIndex = 3;
            this.onePageRadioBtn.Text = "Fit Sheet On One Page";
            this.onePageRadioBtn.UseVisualStyleBackColor = true;
            // 
            // allColumnRadioBtn
            // 
            this.allColumnRadioBtn.AutoSize = true;
            this.allColumnRadioBtn.Checked = true;
            this.allColumnRadioBtn.Location = new System.Drawing.Point(23, 77);
            this.allColumnRadioBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.allColumnRadioBtn.Name = "allColumnRadioBtn";
            this.allColumnRadioBtn.Size = new System.Drawing.Size(239, 24);
            this.allColumnRadioBtn.TabIndex = 2;
            this.allColumnRadioBtn.TabStop = true;
            this.allColumnRadioBtn.Text = "Fit All Columns On One Page";
            this.allColumnRadioBtn.UseVisualStyleBackColor = true;
            // 
            // allRowsRadioBtn
            // 
            this.allRowsRadioBtn.AutoSize = true;
            this.allRowsRadioBtn.Location = new System.Drawing.Point(278, 38);
            this.allRowsRadioBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.allRowsRadioBtn.Name = "allRowsRadioBtn";
            this.allRowsRadioBtn.Size = new System.Drawing.Size(217, 24);
            this.allRowsRadioBtn.TabIndex = 1;
            this.allRowsRadioBtn.Text = "Fit All Rows On One Page";
            this.allRowsRadioBtn.UseVisualStyleBackColor = true;
            // 
            // noScaleRadioBtn
            // 
            this.noScaleRadioBtn.AutoSize = true;
            this.noScaleRadioBtn.Location = new System.Drawing.Point(23, 38);
            this.noScaleRadioBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.noScaleRadioBtn.Name = "noScaleRadioBtn";
            this.noScaleRadioBtn.Size = new System.Drawing.Size(110, 24);
            this.noScaleRadioBtn.TabIndex = 0;
            this.noScaleRadioBtn.Text = "No Scaling";
            this.noScaleRadioBtn.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.checkfontStream);
            this.groupBox2.Controls.Add(this.checkfontName);
            this.groupBox2.Location = new System.Drawing.Point(9, 390);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(544, 153);
            this.groupBox2.TabIndex = 99;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Substitute Fonts";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(456, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Missing fonts in the device will be substituted from embedded resource.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(348, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Missing fonts in the device will be substituted to Calibri";
            // 
            // checkfontStream
            // 
            this.checkfontStream.AutoSize = true;
            this.checkfontStream.Location = new System.Drawing.Point(25, 90);
            this.checkfontStream.Name = "checkfontStream";
            this.checkfontStream.Size = new System.Drawing.Size(124, 24);
            this.checkfontStream.TabIndex = 1;
            this.checkfontStream.Text = "Font Stream";
            this.checkfontStream.UseVisualStyleBackColor = true;
            this.checkfontStream.CheckedChanged += new System.EventHandler(this.checkfontStream_CheckedChanged);
            // 
            // checkfontName
            // 
            this.checkfontName.AutoSize = true;
            this.checkfontName.Location = new System.Drawing.Point(25, 27);
            this.checkfontName.Name = "checkfontName";
            this.checkfontName.Size = new System.Drawing.Size(114, 24);
            this.checkfontName.TabIndex = 0;
            this.checkfontName.Text = "Font Name";
            this.checkfontName.UseVisualStyleBackColor = true;
            this.checkfontName.CheckedChanged += new System.EventHandler(this.checkfontName_CheckedChanged);
            // 
            // Input
            // 
            this.Input.Location = new System.Drawing.Point(8, 613);
            this.Input.Name = "Input";
            this.Input.Size = new System.Drawing.Size(202, 40);
            this.Input.TabIndex = 100;
            this.Input.Text = "Input Template";
            this.Input.UseVisualStyleBackColor = true;
            this.Input.Click += new System.EventHandler(this.Input_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(566, 663);
            this.Controls.Add(this.Input);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.excelToPdfConvertbtn);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Excel to PDF";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button excelToPdfConvertbtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton onePageRadioBtn;
        private System.Windows.Forms.RadioButton allColumnRadioBtn;
        private System.Windows.Forms.RadioButton allRowsRadioBtn;
        private System.Windows.Forms.RadioButton noScaleRadioBtn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkfontStream;
        private System.Windows.Forms.CheckBox checkfontName;
        private System.Windows.Forms.Button Input;
    }
}


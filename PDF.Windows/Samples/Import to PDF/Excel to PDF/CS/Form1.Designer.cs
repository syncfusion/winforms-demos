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
            this.excelToPdfConvertbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.onePageRadioBtn = new System.Windows.Forms.RadioButton();
            this.allColumnRadioBtn = new System.Windows.Forms.RadioButton();
            this.allRowsRadioBtn = new System.Windows.Forms.RadioButton();
            this.noScaleRadioBtn = new System.Windows.Forms.RadioButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label24
            // 
            this.label24.Image = ((System.Drawing.Image)(resources.GetObject("label24.Image")));
            this.label24.Location = new System.Drawing.Point(120, 245);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(20, 18);
            this.label24.TabIndex = 94;
            this.toolTip1.SetToolTip(this.label24, "Browse for a word document to convert it to Pdf");
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button3.Location = new System.Drawing.Point(348, 265);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(21, 21);
            this.button3.TabIndex = 92;
            this.button3.Text = ". . .";
            this.button3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.browseExcelFileBtnClick);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 266);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(333, 20);
            this.textBox1.TabIndex = 91;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label9.Location = new System.Drawing.Point(3, 250);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(111, 13);
            this.label9.TabIndex = 90;
            this.label9.Text = "Excel Document";
            // 
            // excelToPdfConvertbtn
            // 
            this.excelToPdfConvertbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.excelToPdfConvertbtn.BackColor = System.Drawing.Color.Transparent;
            this.excelToPdfConvertbtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.excelToPdfConvertbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.excelToPdfConvertbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
           // this.excelToPdfConvertbtn.Image = ((System.Drawing.Image)(resources.GetObject("excelToPdfConvertbtn.Image")));
            this.excelToPdfConvertbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.excelToPdfConvertbtn.Location = new System.Drawing.Point(261, 292);
            this.excelToPdfConvertbtn.Name = "excelToPdfConvertbtn";
            this.excelToPdfConvertbtn.Size = new System.Drawing.Size(96, 23);
            this.excelToPdfConvertbtn.TabIndex = 96;
            this.excelToPdfConvertbtn.Text = "Excel to PDF";
            this.excelToPdfConvertbtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.excelToPdfConvertbtn.UseVisualStyleBackColor = false;
            this.excelToPdfConvertbtn.Click += new System.EventHandler(this.excelToPdfConvertBtnClick);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(3, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(375, 61);
            this.label1.TabIndex = 97;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.onePageRadioBtn);
            this.groupBox1.Controls.Add(this.allColumnRadioBtn);
            this.groupBox1.Controls.Add(this.allRowsRadioBtn);
            this.groupBox1.Controls.Add(this.noScaleRadioBtn);
            this.groupBox1.Location = new System.Drawing.Point(6, 161);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(363, 81);
            this.groupBox1.TabIndex = 98;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pdf Page Setup Options";
            // 
            // onePageRadioBtn
            // 
            this.onePageRadioBtn.AutoSize = true;
            this.onePageRadioBtn.Location = new System.Drawing.Point(185, 49);
            this.onePageRadioBtn.Name = "onePageRadioBtn";
            this.onePageRadioBtn.Size = new System.Drawing.Size(135, 17);
            this.onePageRadioBtn.TabIndex = 3;
            this.onePageRadioBtn.Text = "Fit Sheet On One Page";
            this.onePageRadioBtn.UseVisualStyleBackColor = true;
            // 
            // allColumnRadioBtn
            // 
            this.allColumnRadioBtn.AutoSize = true;
            this.allColumnRadioBtn.Location = new System.Drawing.Point(23, 49);
            this.allColumnRadioBtn.Name = "allColumnRadioBtn";
            this.allColumnRadioBtn.Size = new System.Drawing.Size(161, 17);
            this.allColumnRadioBtn.TabIndex = 2;
            this.allColumnRadioBtn.Text = "Fit All Columns On One Page";
            this.allColumnRadioBtn.UseVisualStyleBackColor = true;
            // 
            // allRowsRadioBtn
            // 
            this.allRowsRadioBtn.AutoSize = true;
            this.allRowsRadioBtn.Location = new System.Drawing.Point(185, 26);
            this.allRowsRadioBtn.Name = "allRowsRadioBtn";
            this.allRowsRadioBtn.Size = new System.Drawing.Size(148, 17);
            this.allRowsRadioBtn.TabIndex = 1;
            this.allRowsRadioBtn.Text = "Fit All Rows On One Page";
            this.allRowsRadioBtn.UseVisualStyleBackColor = true;
            // 
            // noScaleRadioBtn
            // 
            this.noScaleRadioBtn.AutoSize = true;
            this.noScaleRadioBtn.Checked = true;
            this.noScaleRadioBtn.Location = new System.Drawing.Point(23, 26);
            this.noScaleRadioBtn.Name = "noScaleRadioBtn";
            this.noScaleRadioBtn.Size = new System.Drawing.Size(77, 17);
            this.noScaleRadioBtn.TabIndex = 0;
            this.noScaleRadioBtn.TabStop = true;
            this.noScaleRadioBtn.Text = "No Scaling";
            this.noScaleRadioBtn.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox2.Image = System.Drawing.Image.FromFile(GetFullTemplatePath("pdf_header.png", true));
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(381, 93);
            this.pictureBox2.TabIndex = 99;
            this.pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(381, 327);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.excelToPdfConvertbtn);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label9);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Excel to PDF";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
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
        private System.Windows.Forms.Button excelToPdfConvertbtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton onePageRadioBtn;
        private System.Windows.Forms.RadioButton allColumnRadioBtn;
        private System.Windows.Forms.RadioButton allRowsRadioBtn;
        private System.Windows.Forms.RadioButton noScaleRadioBtn;
        private System.Windows.Forms.PictureBox pictureBox2;

    }
}


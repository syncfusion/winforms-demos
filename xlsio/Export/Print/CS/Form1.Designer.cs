namespace PrintExcel
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
            this.PrintExcelbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.onePageRadioBtn = new System.Windows.Forms.RadioButton();
            this.allColumnRadioBtn = new System.Windows.Forms.RadioButton();
            this.allRowsRadioBtn = new System.Windows.Forms.RadioButton();
            this.noScaleRadioBtn = new System.Windows.Forms.RadioButton();
            this.printWithConverterAndPrinterBtn = new System.Windows.Forms.RadioButton();
            this.printWithPrinterBtn = new System.Windows.Forms.RadioButton();
            this.printWithConverterBtn = new System.Windows.Forms.RadioButton();
            this.defaultPrintBtn = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
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
            this.label24.Location = new System.Drawing.Point(175, 248);
            this.label24.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(30, 28);
            this.label24.TabIndex = 94;
            this.toolTip1.SetToolTip(this.label24, "Browse for a word document to convert it to Pdf");
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button3.Location = new System.Drawing.Point(519, 278);
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
            this.textBox1.Location = new System.Drawing.Point(6, 282);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(498, 26);
            this.textBox1.TabIndex = 91;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label9.Location = new System.Drawing.Point(3, 256);
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
            this.pictureBox1.Size = new System.Drawing.Size(564, 71);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 89;
            this.pictureBox1.TabStop = false;
            // 
            // PrintExcelbtn
            // 
            this.PrintExcelbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PrintExcelbtn.BackColor = System.Drawing.Color.Transparent;
            this.PrintExcelbtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.PrintExcelbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.PrintExcelbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.PrintExcelbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.PrintExcelbtn.Location = new System.Drawing.Point(390, 616);
            this.PrintExcelbtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PrintExcelbtn.Name = "PrintExcelbtn";
            this.PrintExcelbtn.Size = new System.Drawing.Size(160, 34);
            this.PrintExcelbtn.TabIndex = 96;
            this.PrintExcelbtn.Text = "Print";
            this.PrintExcelbtn.UseVisualStyleBackColor = false;
            this.PrintExcelbtn.Click += new System.EventHandler(this.printExcelBtnClick);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label1.Location = new System.Drawing.Point(1, 147);
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
            this.groupBox1.Location = new System.Drawing.Point(6, 494);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(544, 112);
            this.groupBox1.TabIndex = 99;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Converter Settings";
            // 
            // onePageRadioBtn
            // 
            this.onePageRadioBtn.AutoSize = true;
            this.onePageRadioBtn.Location = new System.Drawing.Point(278, 75);
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
            this.allColumnRadioBtn.Location = new System.Drawing.Point(34, 75);
            this.allColumnRadioBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.allColumnRadioBtn.Name = "allColumnRadioBtn";
            this.allColumnRadioBtn.Size = new System.Drawing.Size(239, 24);
            this.allColumnRadioBtn.TabIndex = 2;
            this.allColumnRadioBtn.Text = "Fit All Columns On One Page";
            this.allColumnRadioBtn.UseVisualStyleBackColor = true;
            // 
            // allRowsRadioBtn
            // 
            this.allRowsRadioBtn.AutoSize = true;
            this.allRowsRadioBtn.Location = new System.Drawing.Point(278, 40);
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
            this.noScaleRadioBtn.Checked = true;
            this.noScaleRadioBtn.Location = new System.Drawing.Point(34, 40);
            this.noScaleRadioBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.noScaleRadioBtn.Name = "noScaleRadioBtn";
            this.noScaleRadioBtn.Size = new System.Drawing.Size(110, 24);
            this.noScaleRadioBtn.TabIndex = 0;
            this.noScaleRadioBtn.TabStop = true;
            this.noScaleRadioBtn.Text = "No Scaling";
            this.noScaleRadioBtn.UseVisualStyleBackColor = true;
            // 
            // printWithConverterAndPrinterBtn
            // 
            this.printWithConverterAndPrinterBtn.AutoSize = true;
            this.printWithConverterAndPrinterBtn.Location = new System.Drawing.Point(35, 126);
            this.printWithConverterAndPrinterBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.printWithConverterAndPrinterBtn.Name = "printWithConverterAndPrinterBtn";
            this.printWithConverterAndPrinterBtn.Size = new System.Drawing.Size(315, 24);
            this.printWithConverterAndPrinterBtn.TabIndex = 0;
            this.printWithConverterAndPrinterBtn.Text = "Print with Converter and Printer Settings";
            this.printWithConverterAndPrinterBtn.UseVisualStyleBackColor = true;
            this.printWithConverterAndPrinterBtn.CheckedChanged += new System.EventHandler(this.option_SelectedIndexChanged);
            // 
            // printWithPrinterBtn
            // 
            this.printWithPrinterBtn.AutoSize = true;
            this.printWithPrinterBtn.Location = new System.Drawing.Point(35, 92);
            this.printWithPrinterBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.printWithPrinterBtn.Name = "printWithPrinterBtn";
            this.printWithPrinterBtn.Size = new System.Drawing.Size(211, 24);
            this.printWithPrinterBtn.TabIndex = 1;
            this.printWithPrinterBtn.Text = "Print with Printer Settings";
            this.printWithPrinterBtn.UseVisualStyleBackColor = true;
            this.printWithPrinterBtn.CheckedChanged += new System.EventHandler(this.option_SelectedIndexChanged);
            // 
            // printWithConverterBtn
            // 
            this.printWithConverterBtn.AutoSize = true;
            this.printWithConverterBtn.Location = new System.Drawing.Point(35, 58);
            this.printWithConverterBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.printWithConverterBtn.Name = "printWithConverterBtn";
            this.printWithConverterBtn.Size = new System.Drawing.Size(234, 24);
            this.printWithConverterBtn.TabIndex = 2;
            this.printWithConverterBtn.Text = "Print with Converter Settings";
            this.printWithConverterBtn.UseVisualStyleBackColor = true;
            this.printWithConverterBtn.CheckedChanged += new System.EventHandler(this.option_SelectedIndexChanged);
            // 
            // defaultPrintBtn
            // 
            this.defaultPrintBtn.AutoSize = true;
            this.defaultPrintBtn.Checked = true;
            this.defaultPrintBtn.Location = new System.Drawing.Point(35, 24);
            this.defaultPrintBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.defaultPrintBtn.Name = "defaultPrintBtn";
            this.defaultPrintBtn.Size = new System.Drawing.Size(122, 24);
            this.defaultPrintBtn.TabIndex = 3;
            this.defaultPrintBtn.TabStop = true;
            this.defaultPrintBtn.Text = "Default Print";
            this.defaultPrintBtn.UseVisualStyleBackColor = true;
            this.defaultPrintBtn.CheckedChanged += new System.EventHandler(this.option_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(5, 616);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 34);
            this.button1.TabIndex = 100;
            this.button1.Text = "Input Template";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.inputTemplate_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.defaultPrintBtn);
            this.groupBox2.Controls.Add(this.printWithConverterBtn);
            this.groupBox2.Controls.Add(this.printWithPrinterBtn);
            this.groupBox2.Controls.Add(this.printWithConverterAndPrinterBtn);
            this.groupBox2.Location = new System.Drawing.Point(5, 323);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(547, 163);
            this.groupBox2.TabIndex = 102;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Print Options";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(564, 656);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PrintExcelbtn);
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
            this.Text = "Print Excel";
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
        private System.Windows.Forms.Button PrintExcelbtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton onePageRadioBtn;
        private System.Windows.Forms.RadioButton allColumnRadioBtn;
        private System.Windows.Forms.RadioButton allRowsRadioBtn;
        private System.Windows.Forms.RadioButton noScaleRadioBtn;
        private System.Windows.Forms.RadioButton printWithConverterAndPrinterBtn;
        private System.Windows.Forms.RadioButton printWithPrinterBtn;
        private System.Windows.Forms.RadioButton printWithConverterBtn;
        private System.Windows.Forms.RadioButton defaultPrintBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}


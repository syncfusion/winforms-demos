#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
namespace ExceltoPDF
{
    partial class Form1
    {
        #region Fields
        private System.Windows.Forms.Button btnInput;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label fileName;
        #endregion        

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btnBrowse = new System.Windows.Forms.Button();
            btnConvert = new System.Windows.Forms.Button();
            textBox1 = new System.Windows.Forms.TextBox();
            label = new System.Windows.Forms.Label();
            pictureBox = new System.Windows.Forms.PictureBox();
            btnInput = new System.Windows.Forms.Button();
            label9 = new System.Windows.Forms.Label();
            openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            fileName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            SuspendLayout();
            // 
            // btnBrowse
            // 
            btnBrowse.Location = new System.Drawing.Point(3, 152);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new System.Drawing.Size(81, 28);
            btnBrowse.TabIndex = 0;
            btnBrowse.Text = "Browse...";
            btnBrowse.UseVisualStyleBackColor = true;
            btnBrowse.Click += btnBrowse_Click;
            // 
            // btnConvert
            // 
            btnConvert.Location = new System.Drawing.Point(144, 193);
            btnConvert.Name = "btnConvert";
            btnConvert.Size = new System.Drawing.Size(124, 30);
            btnConvert.TabIndex = 2;
            btnConvert.Text = "Convert to PDF";
            btnConvert.UseVisualStyleBackColor = true;
            btnConvert.Click += btnConvert_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new System.Drawing.Point(100, 100);
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(10, 23);
            textBox1.TabIndex = 91;
            // 
            // label
            // 
            label.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 161);
            label.ForeColor = System.Drawing.SystemColors.ControlText;
            label.Location = new System.Drawing.Point(0, 86);
            label.Name = "label";
            label.Size = new System.Drawing.Size(373, 57);
            label.TabIndex = 75;
            label.Text = "Click the \"Browse\" button to select an Excel document and click the \"Convert To PDF\" button view the converted PDF document. Click the \"Input Template \" button to view the input Excel document.";
            // 
            // pictureBox
            // 
            pictureBox.Dock = System.Windows.Forms.DockStyle.Top;
            pictureBox.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
            pictureBox.Location = new System.Drawing.Point(0, 0);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new System.Drawing.Size(380, 71);
            pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            pictureBox.TabIndex = 74;
            pictureBox.TabStop = false;
            // 
            // btnInput
            // 
            btnInput.Location = new System.Drawing.Point(3, 193);
            btnInput.Name = "btnInput";
            btnInput.Size = new System.Drawing.Size(112, 30);
            btnInput.TabIndex = 77;
            btnInput.Text = "Input Template";
            btnInput.UseVisualStyleBackColor = true;
            btnInput.Click += btnInput_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 161);
            label9.Location = new System.Drawing.Point(10, 100);
            label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(100, 20);
            label9.TabIndex = 90;
            label9.Text = "Excel Document";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // fileName
            // 
            fileName.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 161);
            fileName.ForeColor = System.Drawing.SystemColors.ControlText;
            fileName.Location = new System.Drawing.Point(89, 153);
            fileName.Name = "fileName";
            fileName.Size = new System.Drawing.Size(149, 27);
            fileName.TabIndex = 79;
            fileName.Text = "ExcelToPDF.xlsx";
            fileName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ExceltoPDFUA
            // 
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            BackColor = System.Drawing.Color.White;
            ClientSize = new System.Drawing.Size(380, 233);
            Controls.Add(fileName);
            Controls.Add(btnInput);
            Controls.Add(label);
            Controls.Add(pictureBox);
            Controls.Add(btnBrowse);
            Controls.Add(btnConvert);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "ExceltoPDFUA";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "ExcelToPDF/UA";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion

        #region Dispose
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

        #endregion
    }
}


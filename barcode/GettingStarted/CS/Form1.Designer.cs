#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
namespace BarcodeSampleDemo_2010
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
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.errorNotify = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textToEncode = new System.Windows.Forms.TextBox();
            this.barcodeTypeList = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.barCodeTip = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.barcodeControl = new Syncfusion.Windows.Forms.Barcode.SfBarcode();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(11, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 22);
            this.label1.TabIndex = 34;
            this.label1.Text = "Text to Encode";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label5.Location = new System.Drawing.Point(12, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 22);
            this.label5.TabIndex = 33;
            this.label5.Text = "Symbology";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // errorNotify
            // 
            this.errorNotify.AutoSize = true;
            this.errorNotify.ForeColor = System.Drawing.Color.Red;
            this.errorNotify.Location = new System.Drawing.Point(2, 340);
            this.errorNotify.Name = "errorNotify";
            this.errorNotify.Size = new System.Drawing.Size(201, 13);
            this.errorNotify.TabIndex = 38;
            this.errorNotify.Text = " * Invalid characters found in entered text";
            this.errorNotify.Visible = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(13, 309);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 28);
            this.button1.TabIndex = 0;
            this.button1.Text = "UPDATE";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textToEncode
            // 
            this.textToEncode.Location = new System.Drawing.Point(13, 107);
            this.textToEncode.Name = "textToEncode";
            this.textToEncode.Size = new System.Drawing.Size(230, 20);
            this.textToEncode.TabIndex = 0;
            this.textToEncode.Text = "Syncfusion";
            this.textToEncode.Click += new System.EventHandler(this.textToEncode_MouseClick);
            // 
            // barcodeTypeList
            // 
            this.barcodeTypeList.FormattingEnabled = true;
            this.barcodeTypeList.Location = new System.Drawing.Point(15, 47);
            this.barcodeTypeList.Name = "barcodeTypeList";
            this.barcodeTypeList.Size = new System.Drawing.Size(230, 21);
            this.barcodeTypeList.TabIndex = 2;
            this.barcodeTypeList.SelectedIndexChanged += new System.EventHandler(this.barcodeTypeList_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Location = new System.Drawing.Point(11, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 22);
            this.label3.TabIndex = 40;
            this.label3.Text = "Allowed Characters";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.barCodeTip);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.barcodeTypeList);
            this.panel1.Controls.Add(this.textToEncode);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.errorNotify);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(262, 370);
            this.panel1.TabIndex = 44;
            // 
            // barCodeTip
            // 
            this.barCodeTip.BackColor = System.Drawing.SystemColors.Window;           
            this.barCodeTip.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.barCodeTip.ForeColor = System.Drawing.SystemColors.WindowText;
            this.barCodeTip.Location = new System.Drawing.Point(15, 164);
            this.barCodeTip.Name = "barCodeTip";
            this.barCodeTip.Size = new System.Drawing.Size(227, 124);

            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Location = new System.Drawing.Point(-5, -1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(554, 10);
            this.label2.TabIndex = 45;
            // 
            // barcodeControl
            // 
            this.barcodeControl.BackColor = System.Drawing.Color.White;
            this.barcodeControl.DarkBarColor = System.Drawing.Color.Black;
            this.barcodeControl.DisplayText = true;
            this.barcodeControl.LightBarColor = System.Drawing.Color.White;
            this.barcodeControl.Location = new System.Drawing.Point(311, 120);
            this.barcodeControl.Name = "barcodeControl";
            this.barcodeControl.Size = new System.Drawing.Size(196, 144);
            this.barcodeControl.Symbology = Syncfusion.Windows.Forms.Barcode.BarcodeSymbolType.QRBarcode;
            this.barcodeControl.SymbologySettings = null;
            this.barcodeControl.TabIndex = 43;
            this.barcodeControl.TextAlignment = Syncfusion.Windows.Forms.Barcode.BarcodeTextAlignment.Center;
            this.barcodeControl.TextColor = System.Drawing.Color.Black;
            this.barcodeControl.TextGapHeight = 0F;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(545, 370);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.barcodeControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Barcode";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Syncfusion.Windows.Forms.Barcode.SfBarcode barcodeControl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label errorNotify;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textToEncode;
        private System.Windows.Forms.ComboBox barcodeTypeList;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label barCodeTip;
    }
}


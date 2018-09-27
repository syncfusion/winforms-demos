#region Copyright Syncfusion Inc. 2001 - 2017
// Copyright Syncfusion Inc. 2001 - 2017. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
namespace EncryptDocument_2005
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
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.txtEncryptSource = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEnOpen = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button3 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.btnDecryptSource = new Syncfusion.Windows.Forms.ButtonAdv();
            this.txtDecryptSource = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDeOpen = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.wordDocxRadioBtn = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
            this.wordDocRadioBtn = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wordDocxRadioBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wordDocRadioBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(0, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(363, 51);
            this.label2.TabIndex = 78;
            this.label2.Text = "Click the button to view the generated Word document. Please note that Microsoft Word Viewer or Microsoft Word is required to view the resultant Word document.";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(372, 82);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 77;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218)))));
            this.button1.BeforeTouchSize = new System.Drawing.Size(108, 23);
            this.button1.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.Dashed;
            this.button1.ComboEditBackColor = System.Drawing.Color.Silver;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.IsBackStageButton = false;
            this.button1.KeepFocusRectangle = false;
            this.button1.Location = new System.Drawing.Point(234, 95);
            this.button1.Name = "button1";
            this.button1.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Managed;
            this.button1.Size = new System.Drawing.Size(108, 23);
            this.button1.TabIndex = 76;
            this.button1.Text = "Encrypt";
            this.button1.UseVisualStyle = true;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(354, 178);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(20, 16);
            this.label9.TabIndex = 84;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.txtEncryptSource);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.txtEnOpen);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(12, 197);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(348, 124);
            this.groupBox1.TabIndex = 85;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Encrypt Document";
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BeforeTouchSize = new System.Drawing.Size(24, 20);
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button2.IsBackStageButton = false;
            this.button2.Location = new System.Drawing.Point(318, 29);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(24, 20);
            this.button2.TabIndex = 0;
            this.button2.Text = "...";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtEncryptSource
            // 
            this.txtEncryptSource.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEncryptSource.Location = new System.Drawing.Point(123, 29);
            this.txtEncryptSource.Name = "txtEncryptSource";
            this.txtEncryptSource.Size = new System.Drawing.Size(172, 20);
            this.txtEncryptSource.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(6, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Source Document";
            // 
            // txtEnOpen
            // 
            this.txtEnOpen.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEnOpen.Location = new System.Drawing.Point(123, 60);
            this.txtEnOpen.Name = "txtEnOpen";
            this.txtEnOpen.PasswordChar = '*';
            this.txtEnOpen.Size = new System.Drawing.Size(219, 20);
            this.txtEnOpen.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(6, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Password To Protect";
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.MidnightBlue;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label8.Location = new System.Drawing.Point(29, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(118, 1);
            this.label8.TabIndex = 2;
            this.label8.Text = "label8";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.btnDecryptSource);
            this.groupBox2.Controls.Add(this.txtDecryptSource);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtDeOpen);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(12, 342);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(348, 122);
            this.groupBox2.TabIndex = 86;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Decrypt Document";
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218)))));
            this.button3.BeforeTouchSize = new System.Drawing.Size(108, 23);
            this.button3.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.Dashed;
            this.button3.ComboEditBackColor = System.Drawing.Color.Silver;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.IsBackStageButton = false;
            this.button3.KeepFocusRectangle = false;
            this.button3.Location = new System.Drawing.Point(234, 93);
            this.button3.Name = "button3";
            this.button3.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Managed;
            this.button3.Size = new System.Drawing.Size(108, 23);
            this.button3.TabIndex = 77;
            this.button3.Text = "Decrypt";
            this.button3.UseVisualStyle = true;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnDecryptSource
            // 
            this.btnDecryptSource.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDecryptSource.BackColor = System.Drawing.Color.Transparent;
            this.btnDecryptSource.BeforeTouchSize = new System.Drawing.Size(24, 20);
            this.btnDecryptSource.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDecryptSource.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnDecryptSource.IsBackStageButton = false;
            this.btnDecryptSource.Location = new System.Drawing.Point(318, 29);
            this.btnDecryptSource.Name = "btnDecryptSource";
            this.btnDecryptSource.Size = new System.Drawing.Size(24, 20);
            this.btnDecryptSource.TabIndex = 6;
            this.btnDecryptSource.Text = "...";
            this.btnDecryptSource.UseVisualStyleBackColor = false;
            this.btnDecryptSource.Click += new System.EventHandler(this.btnDecryptSource_Click);
            // 
            // txtDecryptSource
            // 
            this.txtDecryptSource.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDecryptSource.Location = new System.Drawing.Point(123, 29);
            this.txtDecryptSource.Name = "txtDecryptSource";
            this.txtDecryptSource.Size = new System.Drawing.Size(172, 20);
            this.txtDecryptSource.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(6, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Source Document";
            // 
            // txtDeOpen
            // 
            this.txtDeOpen.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDeOpen.Location = new System.Drawing.Point(123, 60);
            this.txtDeOpen.Name = "txtDeOpen";
            this.txtDeOpen.PasswordChar = '*';
            this.txtDeOpen.Size = new System.Drawing.Size(219, 20);
            this.txtDeOpen.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(6, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Password To Open";
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.MidnightBlue;
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label11.Location = new System.Drawing.Point(29, 13);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(118, 1);
            this.label11.TabIndex = 2;
            this.label11.Text = "label11";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog1";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.wordDocxRadioBtn);
            this.groupBox3.Controls.Add(this.wordDocRadioBtn);
            this.groupBox3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(36, 139);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(280, 42);
            this.groupBox3.TabIndex = 101;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Save As";
            // 
            // worddocxRadioBtn
            // 
            this.wordDocxRadioBtn.BeforeTouchSize = new System.Drawing.Size(55, 20);
            this.wordDocxRadioBtn.Border3DStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.wordDocxRadioBtn.Checked = true;
            this.wordDocxRadioBtn.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wordDocxRadioBtn.GradientEnd = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.wordDocxRadioBtn.GradientStart = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.wordDocxRadioBtn.Location = new System.Drawing.Point(188, 20);
            this.wordDocxRadioBtn.MetroColor = System.Drawing.Color.Empty;
            this.wordDocxRadioBtn.Name = "wordDocxRadioBtn";
            this.wordDocxRadioBtn.Size = new System.Drawing.Size(55, 20);
            this.wordDocxRadioBtn.TabIndex = 103;
            this.wordDocxRadioBtn.Text = "DOCX";
            this.wordDocxRadioBtn.ThemesEnabled = true;
            // 
            // worddocRadioBtn
            // 
            this.wordDocRadioBtn.BeforeTouchSize = new System.Drawing.Size(47, 20);
            this.wordDocRadioBtn.Border3DStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.wordDocRadioBtn.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.wordDocRadioBtn.GradientEnd = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.wordDocRadioBtn.GradientStart = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.wordDocRadioBtn.Location = new System.Drawing.Point(42, 20);
            this.wordDocRadioBtn.MetroColor = System.Drawing.Color.Empty;
            this.wordDocRadioBtn.Name = "wordDocRadioBtn";
            this.wordDocRadioBtn.Size = new System.Drawing.Size(47, 20);
            this.wordDocRadioBtn.TabIndex = 44;
            this.wordDocRadioBtn.Text = "DOC";
            this.wordDocRadioBtn.ThemesEnabled = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218)))));
            this.ClientSize = new System.Drawing.Size(372, 473);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.DropShadow = true;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Encrypt and Decrypt";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.wordDocxRadioBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wordDocRadioBtn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Syncfusion.Windows.Forms.ButtonAdv button1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox1;
        private Syncfusion.Windows.Forms.ButtonAdv button2;
        private System.Windows.Forms.TextBox txtEncryptSource;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEnOpen;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox2;
        private Syncfusion.Windows.Forms.ButtonAdv button3;
        private Syncfusion.Windows.Forms.ButtonAdv btnDecryptSource;
        private System.Windows.Forms.TextBox txtDecryptSource;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDeOpen;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.GroupBox groupBox3;
        private Syncfusion.Windows.Forms.Tools.RadioButtonAdv wordDocxRadioBtn;
        private Syncfusion.Windows.Forms.Tools.RadioButtonAdv wordDocRadioBtn;
    }
}


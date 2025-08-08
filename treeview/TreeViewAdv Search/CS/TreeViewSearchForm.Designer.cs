#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Syncfusion.Windows.Forms;
using Syncfusion.Windows.Forms.Tools;
namespace TreeViewAdvSearchDemo
{
    partial class TreeViewSearchForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.replaceTextbox = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.findTextBox = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.comboBox3 = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.label5 = new System.Windows.Forms.Label();
            this.button5 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.SearchRangeCombo = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.label4 = new System.Windows.Forms.Label();
            this.button4 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.button3 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.button2 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.button1 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.SearchOptionCombo = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.replaceTextbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.findTextBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SearchRangeCombo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SearchOptionCombo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.replaceTextbox);
            this.panel1.Controls.Add(this.findTextBox);
            this.panel1.Controls.Add(this.comboBox3);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.SearchRangeCombo);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.SearchOptionCombo);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(771, 307);
            this.panel1.TabIndex = 0;
            // 
            // replaceTextbox
            // 
            this.replaceTextbox.BeforeTouchSize = new System.Drawing.Size(423, 21);
            this.replaceTextbox.Location = new System.Drawing.Point(183, 67);
            this.replaceTextbox.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.replaceTextbox.Name = "replaceTextbox";
            this.replaceTextbox.Size = new System.Drawing.Size(423, 21);
            this.replaceTextbox.TabIndex = 32;
            // 
            // findTextBox
            // 
            this.findTextBox.BeforeTouchSize = new System.Drawing.Size(423, 21);
            this.findTextBox.Location = new System.Drawing.Point(183, 27);
            this.findTextBox.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.findTextBox.Name = "findTextBox";
            this.findTextBox.Size = new System.Drawing.Size(423, 21);
            this.findTextBox.TabIndex = 31;
            // 
            // comboBox3
            // 
            this.comboBox3.BackColor = System.Drawing.Color.White;
            this.comboBox3.BeforeTouchSize = new System.Drawing.Size(423, 23);
            this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox3.Location = new System.Drawing.Point(183, 191);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(423, 23);
            this.comboBox3.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.comboBox3.TabIndex = 30;
            this.comboBox3.ThemeName = "Metro";
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(51, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 15);
            this.label5.TabIndex = 29;
            this.label5.Text = "Search Navigation";
            // 
            // button5
            // 
            this.button5.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218)))));
            this.button5.BeforeTouchSize = new System.Drawing.Size(87, 27);
            this.button5.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.IsBackStageButton = false;
            this.button5.Location = new System.Drawing.Point(632, 252);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(87, 27);
            this.button5.TabIndex = 28;
            this.button5.Text = "&Done";
            this.button5.ThemeName = "Metro";
            this.button5.UseVisualStyle = true;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // SearchRangeCombo
            // 
            this.SearchRangeCombo.BackColor = System.Drawing.Color.White;
            this.SearchRangeCombo.BeforeTouchSize = new System.Drawing.Size(423, 23);
            this.SearchRangeCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SearchRangeCombo.Location = new System.Drawing.Point(183, 149);
            this.SearchRangeCombo.Name = "SearchRangeCombo";
            this.SearchRangeCombo.Size = new System.Drawing.Size(423, 23);
            this.SearchRangeCombo.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.SearchRangeCombo.TabIndex = 27;
            this.SearchRangeCombo.ThemeName = "Metro";
            this.SearchRangeCombo.SelectedIndexChanged += new System.EventHandler(this.SearchRangeCombo_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 15);
            this.label4.TabIndex = 26;
            this.label4.Text = "Search Range";
            // 
            // button4
            // 
            this.button4.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218)))));
            this.button4.BeforeTouchSize = new System.Drawing.Size(87, 27);
            this.button4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.IsBackStageButton = false;
            this.button4.Location = new System.Drawing.Point(519, 252);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(87, 27);
            this.button4.TabIndex = 25;
            this.button4.Text = "&Replace All";
            this.button4.ThemeName = "Metro";
            this.button4.UseVisualStyle = true;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218)))));
            this.button3.BeforeTouchSize = new System.Drawing.Size(87, 27);
            this.button3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.IsBackStageButton = false;
            this.button3.Location = new System.Drawing.Point(411, 252);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(87, 27);
            this.button3.TabIndex = 24;
            this.button3.Text = "&Replace";
            this.button3.ThemeName = "Metro";
            this.button3.UseVisualStyle = true;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218)))));
            this.button2.BeforeTouchSize = new System.Drawing.Size(87, 27);
            this.button2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.IsBackStageButton = false;
            this.button2.Location = new System.Drawing.Point(298, 252);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 27);
            this.button2.TabIndex = 23;
            this.button2.Text = "&Find All";
            this.button2.ThemeName = "Metro";
            this.button2.UseVisualStyle = true;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218)))));
            this.button1.BeforeTouchSize = new System.Drawing.Size(87, 27);
            this.button1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.IsBackStageButton = false;
            this.button1.Location = new System.Drawing.Point(183, 252);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 27);
            this.button1.TabIndex = 22;
            this.button1.Text = "&Find Next";
            this.button1.ThemeName = "Metro";
            this.button1.UseVisualStyle = true;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SearchOptionCombo
            // 
            this.SearchOptionCombo.BackColor = System.Drawing.Color.White;
            this.SearchOptionCombo.BeforeTouchSize = new System.Drawing.Size(423, 23);
            this.SearchOptionCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SearchOptionCombo.Location = new System.Drawing.Point(183, 107);
            this.SearchOptionCombo.Name = "SearchOptionCombo";
            this.SearchOptionCombo.Size = new System.Drawing.Size(423, 23);
            this.SearchOptionCombo.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.SearchOptionCombo.TabIndex = 21;
            this.SearchOptionCombo.ThemeName = "Metro";
            this.SearchOptionCombo.SelectedIndexChanged += new System.EventHandler(this.SearchOptionCombo_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 15);
            this.label3.TabIndex = 20;
            this.label3.Text = "Search Option";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 15);
            this.label2.TabIndex = 19;
            this.label2.Text = "Replace With";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 15);
            this.label1.TabIndex = 18;
            this.label1.Text = "Find What";
            // 
            // TreeViewSearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 331);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximumSize = new System.Drawing.Size(807, 367);
            this.MinimumSize = new System.Drawing.Size(807, 367);
            this.Name = "TreeViewSearchForm";
            this.Padding = new System.Windows.Forms.Padding(12);
            this.Text = "Search Window";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.replaceTextbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.findTextBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SearchRangeCombo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SearchOptionCombo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private TextBoxExt replaceTextbox;
        private TextBoxExt findTextBox;
        private ComboBoxAdv comboBox3;
        private System.Windows.Forms.Label label5;
        private ButtonAdv button5;
        private ComboBoxAdv SearchRangeCombo;
        private System.Windows.Forms.Label label4;
        private ButtonAdv button4;
        private ButtonAdv button3;
        private ButtonAdv button2;
        private ButtonAdv button1;
        private ComboBoxAdv SearchOptionCombo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
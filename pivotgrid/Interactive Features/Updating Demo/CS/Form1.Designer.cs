#region Copyright Syncfusion Inc. 2001 - 2018
// Copyright Syncfusion Inc. 2001 - 2018. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion

using System.ComponentModel;
using System.Windows.Forms;
using Syncfusion.Windows.Forms;
using Syncfusion.Windows.Forms.PivotAnalysis;
using Syncfusion.Windows.Forms.Tools;

namespace UpdatingDemo
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        #region "Dispose"
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBoxAdv1 = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBoxAdv2 = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.button3 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.button2 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.button1 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.checkBoxAdv1 = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.pivotGridControl1 = new Syncfusion.Windows.Forms.PivotAnalysis.PivotGridControl(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxAdv1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxAdv2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxAdv1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.comboBoxAdv1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.checkBoxAdv2);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.checkBoxAdv1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(3, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(0);
            this.groupBox1.Size = new System.Drawing.Size(242, 543);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Options";
            // 
            // comboBoxAdv1
            // 
            this.comboBoxAdv1.BeforeTouchSize = new System.Drawing.Size(187, 23);
            this.comboBoxAdv1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAdv1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxAdv1.ForeColor = System.Drawing.Color.Black;
            this.comboBoxAdv1.Items.AddRange(new object[] {
            "1",
            "300",
            "500",
            "1000",
            "2000"});
            this.comboBoxAdv1.Location = new System.Drawing.Point(18, 138);
            this.comboBoxAdv1.Margin = new System.Windows.Forms.Padding(0);
            this.comboBoxAdv1.Name = "comboBoxAdv1";
            this.comboBoxAdv1.Size = new System.Drawing.Size(187, 23);
            this.comboBoxAdv1.TabIndex = 13;
            this.comboBoxAdv1.Text = "1";
            this.comboBoxAdv1.SelectedValueChanged += new System.EventHandler(this.comboBoxAdv1_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(15, 111);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 15);
            this.label1.TabIndex = 12;
            this.label1.Text = "Throttle Rate (in milliseconds)";
            // 
            // checkBoxAdv2
            // 
            this.checkBoxAdv2.BeforeTouchSize = new System.Drawing.Size(183, 34);
            this.checkBoxAdv2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxAdv2.ForeColor = System.Drawing.Color.Black;
            this.checkBoxAdv2.ImageCheckBoxSize = new System.Drawing.Size(20, 20);
            this.checkBoxAdv2.Location = new System.Drawing.Point(12, 64);
            this.checkBoxAdv2.Margin = new System.Windows.Forms.Padding(0);
            this.checkBoxAdv2.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.checkBoxAdv2.Name = "checkBoxAdv2";
            this.checkBoxAdv2.Size = new System.Drawing.Size(183, 34);
            this.checkBoxAdv2.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.checkBoxAdv2.TabIndex = 4;
            this.checkBoxAdv2.Text = "Perform Updates";
            this.checkBoxAdv2.ThemeName = "Metro";
            this.checkBoxAdv2.CheckStateChanged += new System.EventHandler(this.checkBoxAdv2_CheckStateChanged);
            // 
            // button3
            // 
            this.button3.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(152)))), ((int)(((byte)(218)))));
            this.button3.BeforeTouchSize = new System.Drawing.Size(142, 37);
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(38, 305);
            this.button3.Margin = new System.Windows.Forms.Padding(0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(142, 37);
            this.button3.TabIndex = 11;
            this.button3.Text = "Add at Bottom";
            this.button3.ThemeName = "Metro";
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(152)))), ((int)(((byte)(218)))));
            this.button2.BeforeTouchSize = new System.Drawing.Size(142, 37);
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(38, 246);
            this.button2.Margin = new System.Windows.Forms.Padding(0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(142, 37);
            this.button2.TabIndex = 10;
            this.button2.Text = "Add at Middle";
            this.button2.ThemeName = "Metro";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(152)))), ((int)(((byte)(218)))));
            this.button1.BeforeTouchSize = new System.Drawing.Size(142, 37);
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(38, 190);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 37);
            this.button1.TabIndex = 9;
            this.button1.Text = "Add at Top";
            this.button1.ThemeName = "Metro";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkBoxAdv1
            // 
            this.checkBoxAdv1.BeforeTouchSize = new System.Drawing.Size(255, 34);
            this.checkBoxAdv1.Checked = true;
            this.checkBoxAdv1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxAdv1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxAdv1.ForeColor = System.Drawing.Color.Black;
            this.checkBoxAdv1.ImageCheckBoxSize = new System.Drawing.Size(20, 20);
            this.checkBoxAdv1.Location = new System.Drawing.Point(12, 30);
            this.checkBoxAdv1.Margin = new System.Windows.Forms.Padding(0);
            this.checkBoxAdv1.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.checkBoxAdv1.Name = "checkBoxAdv1";
            this.checkBoxAdv1.Size = new System.Drawing.Size(255, 34);
            this.checkBoxAdv1.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.checkBoxAdv1.TabIndex = 3;
            this.checkBoxAdv1.Text = "Enable Updating";
            this.checkBoxAdv1.ThemeName = "Metro";
            this.checkBoxAdv1.CheckStateChanged += new System.EventHandler(this.checkBoxAdv1_CheckStateChanged);
            // 
            // pivotGridControl1
            // 
            this.pivotGridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pivotGridControl1.EditManager = null;
            this.pivotGridControl1.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro;
            this.pivotGridControl1.Location = new System.Drawing.Point(0, 8);
            this.pivotGridControl1.Margin = new System.Windows.Forms.Padding(0);
            this.pivotGridControl1.Name = "pivotGridControl1";
            this.pivotGridControl1.Size = new System.Drawing.Size(814, 534);
            this.pivotGridControl1.TabIndex = 0;
            this.pivotGridControl1.Text = "pivotGridControl1";
            this.pivotGridControl1.ThemeName = "Metro";
            this.pivotGridControl1.UpdateManager = null;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(825, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(247, 542);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pivotGridControl1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(825, 542);
            this.panel2.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.CaptionAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.CaptionBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.CaptionBarHeight = 50;
            this.CaptionButtonColor = System.Drawing.Color.White;
            this.CaptionButtonHoverColor = System.Drawing.Color.White;
            this.CaptionFont = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CaptionForeColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1072, 542);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(0);
            this.MetroColor = System.Drawing.Color.Transparent;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Updating";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxAdv1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxAdv2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxAdv1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private PivotGridControl pivotGridControl1;
        private GroupBox groupBox1;
        private CheckBoxAdv checkBoxAdv1;
        private CheckBoxAdv checkBoxAdv2;
        private ComboBoxAdv comboBoxAdv1;
        private Label label1;
        private ButtonAdv button3;
        private ButtonAdv button2;
        private ButtonAdv button1;
        private Panel panel1;
        private Panel panel2;
    }
}
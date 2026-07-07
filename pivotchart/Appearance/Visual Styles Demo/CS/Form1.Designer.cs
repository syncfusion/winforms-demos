#region Copyright Syncfusion Inc. 2001 - 2018.
// Copyright Syncfusion Inc. 2001 - 2018. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion

using System.Windows.Forms;
using Syncfusion.Windows.Forms.Tools;
using Syncfusion.Windows.Forms;

namespace VisualStylesDemo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonAdv2 = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
            this.radioButtonAdv1 = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
            this.radioButtonAdv5 = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
            this.radioButtonAdv4 = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
            this.radioButtonAdv3 = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
            this.pivotChart1 = new Syncfusion.Windows.Forms.PivotChart.PivotChart();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radioButtonAdv2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioButtonAdv1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioButtonAdv5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioButtonAdv4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioButtonAdv3)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.radioButtonAdv2);
            this.groupBox1.Controls.Add(this.radioButtonAdv1);
            this.groupBox1.Controls.Add(this.radioButtonAdv5);
            this.groupBox1.Controls.Add(this.radioButtonAdv4);
            this.groupBox1.Controls.Add(this.radioButtonAdv3);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(225, 521);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Options";
            // 
            // radioButtonAdv2
            // 
            this.radioButtonAdv2.BeforeTouchSize = new System.Drawing.Size(203, 45);
            this.radioButtonAdv2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonAdv2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.radioButtonAdv2.ImageCheckBoxSize = new System.Drawing.Size(20, 20);
            this.radioButtonAdv2.Location = new System.Drawing.Point(15, 61);
            this.radioButtonAdv2.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.radioButtonAdv2.Name = "radioButtonAdv2";
            this.radioButtonAdv2.Size = new System.Drawing.Size(203, 45);
            this.radioButtonAdv2.Style = Syncfusion.Windows.Forms.Tools.RadioButtonAdvStyle.Metro;
            this.radioButtonAdv2.TabIndex = 6;
            this.radioButtonAdv2.TabStop = false;
            this.radioButtonAdv2.Tag = "Office 2016 White";
            this.radioButtonAdv2.Text = "Office 2016 White";
            this.radioButtonAdv2.ThemeName = "Metro";
            this.radioButtonAdv2.CheckChanged += new System.EventHandler(this.VisualStyle_CheckChanged);
            // 
            // radioButtonAdv1
            // 
            this.radioButtonAdv1.BeforeTouchSize = new System.Drawing.Size(203, 45);
            this.radioButtonAdv1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonAdv1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.radioButtonAdv1.ImageCheckBoxSize = new System.Drawing.Size(20, 20);
            this.radioButtonAdv1.Location = new System.Drawing.Point(15, 26);
            this.radioButtonAdv1.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.radioButtonAdv1.Name = "radioButtonAdv1";
            this.radioButtonAdv1.Size = new System.Drawing.Size(203, 45);
            this.radioButtonAdv1.Style = Syncfusion.Windows.Forms.Tools.RadioButtonAdvStyle.Metro;
            this.radioButtonAdv1.TabIndex = 5;
            this.radioButtonAdv1.TabStop = false;
            this.radioButtonAdv1.Tag = "Office 2016 Black";
            this.radioButtonAdv1.Text = "Office 2016 Black";
            this.radioButtonAdv1.ThemeName = "Metro";
            this.radioButtonAdv1.CheckChanged += new System.EventHandler(this.VisualStyle_CheckChanged);
            // 
            // radioButtonAdv5
            // 
            this.radioButtonAdv5.BeforeTouchSize = new System.Drawing.Size(203, 45);
            this.radioButtonAdv5.Checked = true;
            this.radioButtonAdv5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonAdv5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.radioButtonAdv5.ImageCheckBoxSize = new System.Drawing.Size(20, 20);
            this.radioButtonAdv5.Location = new System.Drawing.Point(15, 181);
            this.radioButtonAdv5.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.radioButtonAdv5.Name = "radioButtonAdv5";
            this.radioButtonAdv5.Size = new System.Drawing.Size(203, 45);
            this.radioButtonAdv5.Style = Syncfusion.Windows.Forms.Tools.RadioButtonAdvStyle.Metro;
            this.radioButtonAdv5.TabIndex = 3;
            this.radioButtonAdv5.Tag = "Metro";
            this.radioButtonAdv5.Text = "Metro";
            this.radioButtonAdv5.ThemeName = "Metro";
            this.radioButtonAdv5.CheckChanged += new System.EventHandler(this.VisualStyle_CheckChanged);
            // 
            // radioButtonAdv4
            // 
            this.radioButtonAdv4.BeforeTouchSize = new System.Drawing.Size(203, 45);
            this.radioButtonAdv4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonAdv4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.radioButtonAdv4.ImageCheckBoxSize = new System.Drawing.Size(20, 20);
            this.radioButtonAdv4.Location = new System.Drawing.Point(15, 141);
            this.radioButtonAdv4.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.radioButtonAdv4.Name = "radioButtonAdv4";
            this.radioButtonAdv4.Size = new System.Drawing.Size(203, 45);
            this.radioButtonAdv4.Style = Syncfusion.Windows.Forms.Tools.RadioButtonAdvStyle.Metro;
            this.radioButtonAdv4.TabIndex = 2;
            this.radioButtonAdv4.TabStop = false;
            this.radioButtonAdv4.Tag = "Office 2016 Colorful";
            this.radioButtonAdv4.Text = "Office 2016 Colorful";
            this.radioButtonAdv4.ThemeName = "Metro";
            this.radioButtonAdv4.CheckChanged += new System.EventHandler(this.VisualStyle_CheckChanged);
            // 
            // radioButtonAdv3
            // 
            this.radioButtonAdv3.BeforeTouchSize = new System.Drawing.Size(203, 45);
            this.radioButtonAdv3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonAdv3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.radioButtonAdv3.ImageCheckBoxSize = new System.Drawing.Size(20, 20);
            this.radioButtonAdv3.Location = new System.Drawing.Point(15, 100);
            this.radioButtonAdv3.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.radioButtonAdv3.Name = "radioButtonAdv3";
            this.radioButtonAdv3.Size = new System.Drawing.Size(203, 45);
            this.radioButtonAdv3.Style = Syncfusion.Windows.Forms.Tools.RadioButtonAdvStyle.Metro;
            this.radioButtonAdv3.TabIndex = 1;
            this.radioButtonAdv3.TabStop = false;
            this.radioButtonAdv3.Tag = "Office 2016 Dark Gray";
            this.radioButtonAdv3.Text = "Office 2016 Dark Gray";
            this.radioButtonAdv3.ThemeName = "Metro";
            this.radioButtonAdv3.CheckChanged += new System.EventHandler(this.VisualStyle_CheckChanged);
            // 
            // pivotChart1
            // 
            this.pivotChart1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pivotChart1.ChartTypes = Syncfusion.Windows.Forms.PivotChart.PivotChartTypes.Column;
            this.pivotChart1.CustomPalette = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(165)))), ((int)(((byte)(165))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(114)))), ((int)(((byte)(196))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(173)))), ((int)(((byte)(71)))))};
            this.pivotChart1.DeferLayoutUpdate = false;
            this.pivotChart1.Location = new System.Drawing.Point(0, 8);
            this.pivotChart1.Margin = new System.Windows.Forms.Padding(2);
            this.pivotChart1.MinimumSize = new System.Drawing.Size(200, 162);
            this.pivotChart1.Name = "pivotChart1";
            this.pivotChart1.ShowPivotTableFieldList = false;
            this.pivotChart1.Size = new System.Drawing.Size(828, 513);
            this.pivotChart1.TabIndex = 1;
            this.pivotChart1.Text = "pivotChart1";
            this.pivotChart1.UpdateManager = null;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(837, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(225, 521);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pivotChart1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(837, 521);
            this.panel2.TabIndex = 4;
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
            this.ClientSize = new System.Drawing.Size(1062, 521);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(0);
            this.MetroColor = System.Drawing.Color.Transparent;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Visual Styles";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radioButtonAdv2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioButtonAdv1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioButtonAdv5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioButtonAdv4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioButtonAdv3)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private GroupBox groupBox1;
        private RadioButtonAdv radioButtonAdv5;
        private RadioButtonAdv radioButtonAdv4;
        private RadioButtonAdv radioButtonAdv3;
        private RadioButtonAdv radioButtonAdv2;
        private RadioButtonAdv radioButtonAdv1;
        private Syncfusion.Windows.Forms.PivotChart.PivotChart pivotChart1;
        private Panel panel1;
        private Panel panel2;
    }
}
#region Copyright Syncfusion Inc. 2001 - 2018
// Copyright Syncfusion Inc. 2001 - 2018. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion

using System.ComponentModel;
using System.Windows.Forms;
using Syncfusion.Windows.Forms.PivotAnalysis;
using Syncfusion.Windows.Forms.Tools;
using Syncfusion.Windows.Forms;

namespace VisualStylesDemo
{
    partial class Form1
    {
        #region API Definition

        private PivotGridControl pivotGridControl1;
        private GroupBox groupBox1;
        private RadioButtonAdv Office2010Silver;
        private RadioButtonAdv Office2010Black;
        private RadioButtonAdv Office2010Blue;
        private RadioButtonAdv Metro;

        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        #endregion

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
            this.pivotGridControl1 = new Syncfusion.Windows.Forms.PivotAnalysis.PivotGridControl(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonAdv4 = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
            this.radioButtonAdv1 = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
            this.radioButtonAdv2 = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
            this.radioButtonAdv3 = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
            this.Metro = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
            this.Office2010Silver = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
            this.Office2010Black = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
            this.Office2010Blue = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radioButtonAdv4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioButtonAdv1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioButtonAdv2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioButtonAdv3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Metro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Office2010Silver)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Office2010Black)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Office2010Blue)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pivotGridControl1
            // 
            this.pivotGridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pivotGridControl1.EditManager = null;
            this.pivotGridControl1.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro;
            this.pivotGridControl1.Location = new System.Drawing.Point(0, 8);
            this.pivotGridControl1.Name = "pivotGridControl1";
            this.pivotGridControl1.Size = new System.Drawing.Size(834, 550);
            this.pivotGridControl1.TabIndex = 0;
            this.pivotGridControl1.Text = "pivotGridControl1";
            this.pivotGridControl1.ThemeName = "Metro";
            this.pivotGridControl1.UpdateManager = null;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.radioButtonAdv4);
            this.groupBox1.Controls.Add(this.radioButtonAdv1);
            this.groupBox1.Controls.Add(this.radioButtonAdv2);
            this.groupBox1.Controls.Add(this.radioButtonAdv3);
            this.groupBox1.Controls.Add(this.Metro);
            this.groupBox1.Controls.Add(this.Office2010Silver);
            this.groupBox1.Controls.Add(this.Office2010Black);
            this.groupBox1.Controls.Add(this.Office2010Blue);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(3, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(0);
            this.groupBox1.Size = new System.Drawing.Size(238, 558);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Options";
            // 
            // radioButtonAdv4
            // 
            this.radioButtonAdv4.BeforeTouchSize = new System.Drawing.Size(206, 40);
            this.radioButtonAdv4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonAdv4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.radioButtonAdv4.ImageCheckBoxSize = new System.Drawing.Size(20, 20);
            this.radioButtonAdv4.Location = new System.Drawing.Point(16, 138);
            this.radioButtonAdv4.Margin = new System.Windows.Forms.Padding(0);
            this.radioButtonAdv4.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.radioButtonAdv4.Name = "radioButtonAdv4";
            this.radioButtonAdv4.Size = new System.Drawing.Size(206, 40);
            this.radioButtonAdv4.Style = Syncfusion.Windows.Forms.Tools.RadioButtonAdvStyle.Metro;
            this.radioButtonAdv4.TabIndex = 11;
            this.radioButtonAdv4.TabStop = false;
            this.radioButtonAdv4.Tag = "Office2016Black";
            this.radioButtonAdv4.Text = "Office 2016 Black";
            this.radioButtonAdv4.ThemeName = "Metro";
            this.radioButtonAdv4.CheckChanged += new System.EventHandler(this.VisualStyle_CheckChanged);
            // 
            // radioButtonAdv1
            // 
            this.radioButtonAdv1.BeforeTouchSize = new System.Drawing.Size(330, 40);
            this.radioButtonAdv1.DrawFocusRectangle = false;
            this.radioButtonAdv1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonAdv1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.radioButtonAdv1.ImageCheckBoxSize = new System.Drawing.Size(20, 20);
            this.radioButtonAdv1.Location = new System.Drawing.Point(15, 258);
            this.radioButtonAdv1.Margin = new System.Windows.Forms.Padding(0);
            this.radioButtonAdv1.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.radioButtonAdv1.Name = "radioButtonAdv1";
            this.radioButtonAdv1.Size = new System.Drawing.Size(330, 40);
            this.radioButtonAdv1.Style = Syncfusion.Windows.Forms.Tools.RadioButtonAdvStyle.Metro;
            this.radioButtonAdv1.TabIndex = 10;
            this.radioButtonAdv1.TabStop = false;
            this.radioButtonAdv1.Tag = "Office2016DarkGray";
            this.radioButtonAdv1.Text = "Office 2016 Dark Gray";
            this.radioButtonAdv1.ThemeName = "Metro";
            this.radioButtonAdv1.CheckChanged += new System.EventHandler(this.VisualStyle_CheckChanged);
            // 
            // radioButtonAdv2
            // 
            this.radioButtonAdv2.BeforeTouchSize = new System.Drawing.Size(330, 40);
            this.radioButtonAdv2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonAdv2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.radioButtonAdv2.ImageCheckBoxSize = new System.Drawing.Size(20, 20);
            this.radioButtonAdv2.Location = new System.Drawing.Point(16, 218);
            this.radioButtonAdv2.Margin = new System.Windows.Forms.Padding(0);
            this.radioButtonAdv2.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.radioButtonAdv2.Name = "radioButtonAdv2";
            this.radioButtonAdv2.Size = new System.Drawing.Size(330, 40);
            this.radioButtonAdv2.Style = Syncfusion.Windows.Forms.Tools.RadioButtonAdvStyle.Metro;
            this.radioButtonAdv2.TabIndex = 9;
            this.radioButtonAdv2.TabStop = false;
            this.radioButtonAdv2.Tag = "Office2016Colorful";
            this.radioButtonAdv2.Text = "Office 2016 Colorful";
            this.radioButtonAdv2.ThemeName = "Metro";
            this.radioButtonAdv2.CheckChanged += new System.EventHandler(this.VisualStyle_CheckChanged);
            // 
            // radioButtonAdv3
            // 
            this.radioButtonAdv3.BeforeTouchSize = new System.Drawing.Size(206, 40);
            this.radioButtonAdv3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonAdv3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.radioButtonAdv3.ImageCheckBoxSize = new System.Drawing.Size(20, 20);
            this.radioButtonAdv3.Location = new System.Drawing.Point(16, 178);
            this.radioButtonAdv3.Margin = new System.Windows.Forms.Padding(0);
            this.radioButtonAdv3.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.radioButtonAdv3.Name = "radioButtonAdv3";
            this.radioButtonAdv3.Size = new System.Drawing.Size(206, 40);
            this.radioButtonAdv3.Style = Syncfusion.Windows.Forms.Tools.RadioButtonAdvStyle.Metro;
            this.radioButtonAdv3.TabIndex = 8;
            this.radioButtonAdv3.TabStop = false;
            this.radioButtonAdv3.Tag = "Office2016White";
            this.radioButtonAdv3.Text = "Office 2016 White";
            this.radioButtonAdv3.ThemeName = "Metro";
            this.radioButtonAdv3.CheckChanged += new System.EventHandler(this.VisualStyle_CheckChanged);
            // 
            // Metro
            // 
            this.Metro.BeforeTouchSize = new System.Drawing.Size(206, 40);
            this.Metro.Checked = true;
            this.Metro.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Metro.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Metro.ImageCheckBoxSize = new System.Drawing.Size(20, 20);
            this.Metro.Location = new System.Drawing.Point(16, 298);
            this.Metro.Margin = new System.Windows.Forms.Padding(0);
            this.Metro.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.Metro.Name = "Metro";
            this.Metro.Size = new System.Drawing.Size(206, 40);
            this.Metro.Style = Syncfusion.Windows.Forms.Tools.RadioButtonAdvStyle.Metro;
            this.Metro.TabIndex = 7;
            this.Metro.Tag = "Metro";
            this.Metro.Text = "Metro";
            this.Metro.ThemeName = "Metro";
            this.Metro.CheckChanged += new System.EventHandler(this.VisualStyle_CheckChanged);
            // 
            // Office2010Silver
            // 
            this.Office2010Silver.BeforeTouchSize = new System.Drawing.Size(206, 40);
            this.Office2010Silver.DrawFocusRectangle = false;
            this.Office2010Silver.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Office2010Silver.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Office2010Silver.ImageCheckBoxSize = new System.Drawing.Size(20, 20);
            this.Office2010Silver.Location = new System.Drawing.Point(16, 98);
            this.Office2010Silver.Margin = new System.Windows.Forms.Padding(0);
            this.Office2010Silver.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.Office2010Silver.Name = "Office2010Silver";
            this.Office2010Silver.Size = new System.Drawing.Size(206, 40);
            this.Office2010Silver.Style = Syncfusion.Windows.Forms.Tools.RadioButtonAdvStyle.Metro;
            this.Office2010Silver.TabIndex = 6;
            this.Office2010Silver.Tag = "Office2010Silver";
            this.Office2010Silver.Text = "Office 2010 Silver";
            this.Office2010Silver.ThemeName = "Metro";
            this.Office2010Silver.CheckChanged += new System.EventHandler(this.VisualStyle_CheckChanged);
            // 
            // Office2010Black
            // 
            this.Office2010Black.BeforeTouchSize = new System.Drawing.Size(206, 40);
            this.Office2010Black.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Office2010Black.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Office2010Black.ImageCheckBoxSize = new System.Drawing.Size(20, 20);
            this.Office2010Black.Location = new System.Drawing.Point(16, 58);
            this.Office2010Black.Margin = new System.Windows.Forms.Padding(0);
            this.Office2010Black.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.Office2010Black.Name = "Office2010Black";
            this.Office2010Black.Size = new System.Drawing.Size(206, 40);
            this.Office2010Black.Style = Syncfusion.Windows.Forms.Tools.RadioButtonAdvStyle.Metro;
            this.Office2010Black.TabIndex = 5;
            this.Office2010Black.Tag = "Office2010Black";
            this.Office2010Black.Text = "Office 2010 Black";
            this.Office2010Black.ThemeName = "Metro";
            this.Office2010Black.CheckChanged += new System.EventHandler(this.VisualStyle_CheckChanged);
            // 
            // Office2010Blue
            // 
            this.Office2010Blue.BeforeTouchSize = new System.Drawing.Size(207, 40);
            this.Office2010Blue.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Office2010Blue.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Office2010Blue.ImageCheckBoxSize = new System.Drawing.Size(20, 20);
            this.Office2010Blue.Location = new System.Drawing.Point(15, 18);
            this.Office2010Blue.Margin = new System.Windows.Forms.Padding(0);
            this.Office2010Blue.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.Office2010Blue.Name = "Office2010Blue";
            this.Office2010Blue.Size = new System.Drawing.Size(207, 40);
            this.Office2010Blue.Style = Syncfusion.Windows.Forms.Tools.RadioButtonAdvStyle.Metro;
            this.Office2010Blue.TabIndex = 4;
            this.Office2010Blue.Tag = "Office2010Blue";
            this.Office2010Blue.Text = "Office 2010 Blue";
            this.Office2010Blue.ThemeName = "Metro";
            this.Office2010Blue.CheckChanged += new System.EventHandler(this.VisualStyle_CheckChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(840, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(243, 558);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pivotGridControl1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(840, 558);
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
            this.ClientSize = new System.Drawing.Size(1083, 558);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(0);
            this.MetroColor = System.Drawing.Color.Transparent;
            this.MinimumSize = new System.Drawing.Size(1095, 614);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Visual Styles";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radioButtonAdv4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioButtonAdv1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioButtonAdv2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioButtonAdv3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Metro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Office2010Silver)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Office2010Black)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Office2010Blue)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private RadioButtonAdv radioButtonAdv4;
        private RadioButtonAdv radioButtonAdv1;
        private RadioButtonAdv radioButtonAdv2;
        private RadioButtonAdv radioButtonAdv3;
        private Panel panel1;
        private Panel panel2;
    }
}
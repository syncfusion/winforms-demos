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
using Syncfusion.Windows.Forms;

namespace RowPivotsOnlyDemo
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBox5 = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.animationPanel = new System.Windows.Forms.Panel();
            this.headerLabel1 = new System.Windows.Forms.Label();
            this.contextLabel1 = new System.Windows.Forms.Label();
            this.checkBox4 = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.checkBox3 = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.checkBox2 = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.checkBox1 = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.pivotGridControl1 = new Syncfusion.Windows.Forms.PivotAnalysis.PivotGridControl(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox5)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.animationPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.checkBox5);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.checkBox4);
            this.groupBox1.Controls.Add(this.checkBox3);
            this.groupBox1.Controls.Add(this.checkBox2);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(6, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(0);
            this.groupBox1.Size = new System.Drawing.Size(308, 569);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Options";
            // 
            // checkBox5
            // 
            this.checkBox5.BeforeTouchSize = new System.Drawing.Size(230, 40);
            this.checkBox5.Checked = true;
            this.checkBox5.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox5.ForeColor = System.Drawing.Color.Black;
            this.checkBox5.ImageCheckBoxSize = new System.Drawing.Size(20, 20);
            this.checkBox5.Location = new System.Drawing.Point(15, 193);
            this.checkBox5.Margin = new System.Windows.Forms.Padding(0);
            this.checkBox5.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(230, 40);
            this.checkBox5.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.checkBox5.TabIndex = 6;
            this.checkBox5.Tag = "Pivot Value Chooser";
            this.checkBox5.Text = "Show Pivot Value Chooser";
            this.checkBox5.ThemeName = "Metro";
            this.checkBox5.CheckedChanged += new System.EventHandler(this.checkBox5_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.animationPanel);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(15, 244);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(0);
            this.groupBox2.Size = new System.Drawing.Size(284, 287);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Description";
            // 
            // animationPanel
            // 
            this.animationPanel.Controls.Add(this.headerLabel1);
            this.animationPanel.Controls.Add(this.contextLabel1);
            this.animationPanel.Location = new System.Drawing.Point(8, 30);
            this.animationPanel.Margin = new System.Windows.Forms.Padding(0);
            this.animationPanel.Name = "animationPanel";
            this.animationPanel.Size = new System.Drawing.Size(272, 247);
            this.animationPanel.TabIndex = 0;
            // 
            // headerLabel1
            // 
            this.headerLabel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.headerLabel1.AutoSize = true;
            this.headerLabel1.Location = new System.Drawing.Point(30, 28);
            this.headerLabel1.Name = "headerLabel1";
            this.headerLabel1.Size = new System.Drawing.Size(145, 19);
            this.headerLabel1.TabIndex = 10;
            this.headerLabel1.Text = "RowPivotsOnly Mode";
            // 
            // contextLabel1
            // 
            this.contextLabel1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contextLabel1.Location = new System.Drawing.Point(8, 132);
            this.contextLabel1.Margin = new System.Windows.Forms.Padding(0);
            this.contextLabel1.Name = "contextLabel1";
            this.contextLabel1.Size = new System.Drawing.Size(253, 103);
            this.contextLabel1.TabIndex = 9;
            this.contextLabel1.Text = "RowPivotsOnly Mode will show the display of the PivotGrid in much emphasized Grid" +
    "d\'s Structure.\r\n";
            // 
            // checkBox4
            // 
            this.checkBox4.BeforeTouchSize = new System.Drawing.Size(230, 40);
            this.checkBox4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox4.ImageCheckBoxSize = new System.Drawing.Size(20, 20);
            this.checkBox4.Location = new System.Drawing.Point(15, 153);
            this.checkBox4.Margin = new System.Windows.Forms.Padding(0);
            this.checkBox4.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(230, 40);
            this.checkBox4.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.checkBox4.TabIndex = 5;
            this.checkBox4.Tag = "Pivot Schema Designer";
            this.checkBox4.Text = "Show Pivot Schema Designer";
            this.checkBox4.ThemeName = "Metro";
            this.checkBox4.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // checkBox3
            // 
            this.checkBox3.BeforeTouchSize = new System.Drawing.Size(230, 40);
            this.checkBox3.Checked = true;
            this.checkBox3.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox3.ImageCheckBoxSize = new System.Drawing.Size(20, 20);
            this.checkBox3.Location = new System.Drawing.Point(15, 113);
            this.checkBox3.Margin = new System.Windows.Forms.Padding(0);
            this.checkBox3.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(230, 40);
            this.checkBox3.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.checkBox3.TabIndex = 4;
            this.checkBox3.Tag = "Drag and Drop";
            this.checkBox3.Text = "Allow Drag and Drop";
            this.checkBox3.ThemeName = "Metro";
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.BeforeTouchSize = new System.Drawing.Size(230, 40);
            this.checkBox2.Checked = true;
            this.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox2.ImageCheckBoxSize = new System.Drawing.Size(20, 20);
            this.checkBox2.Location = new System.Drawing.Point(15, 73);
            this.checkBox2.Margin = new System.Windows.Forms.Padding(0);
            this.checkBox2.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(230, 40);
            this.checkBox2.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.checkBox2.TabIndex = 3;
            this.checkBox2.Tag = "Filtering";
            this.checkBox2.Text = "Allow Filtering";
            this.checkBox2.ThemeName = "Metro";
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.BeforeTouchSize = new System.Drawing.Size(230, 40);
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.ImageCheckBoxSize = new System.Drawing.Size(20, 20);
            this.checkBox1.Location = new System.Drawing.Point(15, 33);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(0);
            this.checkBox1.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(230, 40);
            this.checkBox1.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Tag = "Sorting";
            this.checkBox1.Text = "Allow Sorting";
            this.checkBox1.ThemeName = "Metro";
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged_1);
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
            this.pivotGridControl1.Size = new System.Drawing.Size(683, 560);
            this.pivotGridControl1.TabIndex = 0;
            this.pivotGridControl1.Text = "pivotGridControl1";
            this.pivotGridControl1.ThemeName = "Metro";
            this.pivotGridControl1.UpdateManager = null;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(694, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(314, 569);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pivotGridControl1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(694, 569);
            this.panel2.TabIndex = 3;
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
            this.ClientSize = new System.Drawing.Size(1008, 569);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(0);
            this.MetroColor = System.Drawing.Color.Transparent;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Row Pivots Only";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.checkBox5)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.animationPanel.ResumeLayout(false);
            this.animationPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private PivotGridControl pivotGridControl1;
        private GroupBox groupBox1;
        private Syncfusion.Windows.Forms.Tools.CheckBoxAdv checkBox1;
        private Syncfusion.Windows.Forms.Tools.CheckBoxAdv checkBox2;
        private Syncfusion.Windows.Forms.Tools.CheckBoxAdv checkBox3;
        private Syncfusion.Windows.Forms.Tools.CheckBoxAdv checkBox4;
        private Syncfusion.Windows.Forms.Tools.CheckBoxAdv checkBox5;
        private GroupBox groupBox2;
        private Panel animationPanel;
        private Label contextLabel1;
        private Label headerLabel1;
        private Panel panel1;
        private Panel panel2;
    }
}
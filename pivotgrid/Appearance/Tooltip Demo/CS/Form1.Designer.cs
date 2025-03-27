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

namespace ToolTipDemo
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
            this.chkValue = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.chkRowHeader = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.chkColHeader = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.chkSummary = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.chkSumHeader = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.chkEnable = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.pivotGridControl1 = new Syncfusion.Windows.Forms.PivotAnalysis.PivotGridControl(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkRowHeader)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkColHeader)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkSummary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkSumHeader)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkEnable)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.chkValue);
            this.groupBox1.Controls.Add(this.chkRowHeader);
            this.groupBox1.Controls.Add(this.chkColHeader);
            this.groupBox1.Controls.Add(this.chkSummary);
            this.groupBox1.Controls.Add(this.chkSumHeader);
            this.groupBox1.Controls.Add(this.chkEnable);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(3, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(0);
            this.groupBox1.Size = new System.Drawing.Size(262, 497);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Options";
            // 
            // chkValue
            // 
            this.chkValue.BeforeTouchSize = new System.Drawing.Size(236, 40);
            this.chkValue.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkValue.ForeColor = System.Drawing.Color.Black;
            this.chkValue.ImageCheckBoxSize = new System.Drawing.Size(20, 20);
            this.chkValue.Location = new System.Drawing.Point(15, 190);
            this.chkValue.Margin = new System.Windows.Forms.Padding(0);
            this.chkValue.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.chkValue.Name = "chkValue";
            this.chkValue.Size = new System.Drawing.Size(236, 40);
            this.chkValue.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.chkValue.TabIndex = 6;
            this.chkValue.Text = "Enable Value Cell ToolTip";
            this.chkValue.ThemeName = "Metro";
            // 
            // chkRowHeader
            // 
            this.chkRowHeader.BeforeTouchSize = new System.Drawing.Size(221, 40);
            this.chkRowHeader.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkRowHeader.ForeColor = System.Drawing.Color.Black;
            this.chkRowHeader.ImageCheckBoxSize = new System.Drawing.Size(20, 20);
            this.chkRowHeader.Location = new System.Drawing.Point(15, 110);
            this.chkRowHeader.Margin = new System.Windows.Forms.Padding(0);
            this.chkRowHeader.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.chkRowHeader.Name = "chkRowHeader";
            this.chkRowHeader.Size = new System.Drawing.Size(221, 40);
            this.chkRowHeader.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.chkRowHeader.TabIndex = 4;
            this.chkRowHeader.Text = "Enable Row Header Cell ToolTip";
            this.chkRowHeader.ThemeName = "Metro";
            // 
            // chkColHeader
            // 
            this.chkColHeader.BeforeTouchSize = new System.Drawing.Size(221, 40);
            this.chkColHeader.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkColHeader.ForeColor = System.Drawing.Color.Black;
            this.chkColHeader.ImageCheckBoxSize = new System.Drawing.Size(20, 20);
            this.chkColHeader.Location = new System.Drawing.Point(15, 70);
            this.chkColHeader.Margin = new System.Windows.Forms.Padding(0);
            this.chkColHeader.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.chkColHeader.Name = "chkColHeader";
            this.chkColHeader.Size = new System.Drawing.Size(221, 40);
            this.chkColHeader.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.chkColHeader.TabIndex = 3;
            this.chkColHeader.Text = "Enable Column Header Cell ToolTip";
            this.chkColHeader.ThemeName = "Metro";
            // 
            // chkSummary
            // 
            this.chkSummary.BeforeTouchSize = new System.Drawing.Size(236, 40);
            this.chkSummary.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSummary.ForeColor = System.Drawing.Color.Black;
            this.chkSummary.ImageCheckBoxSize = new System.Drawing.Size(20, 20);
            this.chkSummary.Location = new System.Drawing.Point(15, 230);
            this.chkSummary.Margin = new System.Windows.Forms.Padding(0);
            this.chkSummary.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.chkSummary.Name = "chkSummary";
            this.chkSummary.Size = new System.Drawing.Size(236, 40);
            this.chkSummary.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.chkSummary.TabIndex = 7;
            this.chkSummary.Text = "Enable Summary Cell ToolTip";
            this.chkSummary.ThemeName = "Metro";
            // 
            // chkSumHeader
            // 
            this.chkSumHeader.BeforeTouchSize = new System.Drawing.Size(236, 40);
            this.chkSumHeader.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSumHeader.ForeColor = System.Drawing.Color.Black;
            this.chkSumHeader.ImageCheckBoxSize = new System.Drawing.Size(20, 20);
            this.chkSumHeader.Location = new System.Drawing.Point(15, 150);
            this.chkSumHeader.Margin = new System.Windows.Forms.Padding(0);
            this.chkSumHeader.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.chkSumHeader.Name = "chkSumHeader";
            this.chkSumHeader.Size = new System.Drawing.Size(236, 40);
            this.chkSumHeader.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.chkSumHeader.TabIndex = 5;
            this.chkSumHeader.Text = "Enable Summary Header Cell ToolTip";
            this.chkSumHeader.ThemeName = "Metro";
            // 
            // chkEnable
            // 
            this.chkEnable.BeforeTouchSize = new System.Drawing.Size(221, 40);
            this.chkEnable.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkEnable.ForeColor = System.Drawing.Color.Black;
            this.chkEnable.ImageCheckBoxSize = new System.Drawing.Size(20, 20);
            this.chkEnable.Location = new System.Drawing.Point(15, 30);
            this.chkEnable.Margin = new System.Windows.Forms.Padding(0);
            this.chkEnable.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.chkEnable.Name = "chkEnable";
            this.chkEnable.Size = new System.Drawing.Size(221, 40);
            this.chkEnable.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.chkEnable.TabIndex = 2;
            this.chkEnable.Text = "Show ToolTip";
            this.chkEnable.ThemeName = "Metro";
            this.chkEnable.CheckStateChanged += new System.EventHandler(this.chkEnable_CheckStateChanged);
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
            this.pivotGridControl1.Size = new System.Drawing.Size(690, 489);
            this.pivotGridControl1.TabIndex = 0;
            this.pivotGridControl1.Text = "pivotGridControl1";
            this.pivotGridControl1.ThemeName = "Metro";
            this.pivotGridControl1.UpdateManager = null;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(701, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(270, 497);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pivotGridControl1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(701, 497);
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
            this.ClientSize = new System.Drawing.Size(971, 497);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(0);
            this.MetroColor = System.Drawing.Color.Transparent;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ToolTip";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chkValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkRowHeader)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkColHeader)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkSummary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkSumHeader)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkEnable)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private PivotGridControl pivotGridControl1;
        private GroupBox groupBox1;
        private CheckBoxAdv chkValue;
        private CheckBoxAdv chkRowHeader;
        private CheckBoxAdv chkColHeader;
        private CheckBoxAdv chkSummary;
        private CheckBoxAdv chkSumHeader;
        private CheckBoxAdv chkEnable;
        private Panel panel1;
        private Panel panel2;
    }
}
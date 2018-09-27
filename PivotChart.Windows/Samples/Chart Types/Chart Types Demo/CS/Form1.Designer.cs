#region Copyright Syncfusion Inc. 2001 - 2018.
// Copyright Syncfusion Inc. 2001 - 2018. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion

using System.Windows.Forms;
using Syncfusion.Windows.Forms.Tools;
using Syncfusion.Windows.Forms.PivotChart;

namespace ChartTypesDemo
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
            this.pivotChart1 = new Syncfusion.Windows.Forms.PivotChart.PivotChart();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.StepArea = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
            this.StepLine = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
            this.StackingColumn100 = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
            this.StackingArea100 = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
            this.StackingColumn = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
            this.StackingArea = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
            this.SplineArea = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
            this.Area = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
            this.Column = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
            this.Spline = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
            this.Line = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StepArea)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StepLine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StackingColumn100)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StackingArea100)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StackingColumn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StackingArea)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SplineArea)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Area)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Column)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Spline)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Line)).BeginInit();
            this.SuspendLayout();
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
            this.pivotChart1.Location = new System.Drawing.Point(0, 8);
            this.pivotChart1.Margin = new System.Windows.Forms.Padding(0);
            this.pivotChart1.MinimumSize = new System.Drawing.Size(300, 250);
            this.pivotChart1.Name = "pivotChart1";
            this.pivotChart1.Size = new System.Drawing.Size(1232, 859);
            this.pivotChart1.TabIndex = 0;
            this.pivotChart1.Text = "pivotChart1";
            this.pivotChart1.UpdateManager = null;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.StepArea);
            this.groupBox1.Controls.Add(this.StepLine);
            this.groupBox1.Controls.Add(this.StackingColumn100);
            this.groupBox1.Controls.Add(this.StackingArea100);
            this.groupBox1.Controls.Add(this.StackingColumn);
            this.groupBox1.Controls.Add(this.StackingArea);
            this.groupBox1.Controls.Add(this.SplineArea);
            this.groupBox1.Controls.Add(this.Area);
            this.groupBox1.Controls.Add(this.Column);
            this.groupBox1.Controls.Add(this.Spline);
            this.groupBox1.Controls.Add(this.Line);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(1245, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(0);
            this.groupBox1.Size = new System.Drawing.Size(355, 850);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Options";
            // 
            // StepArea
            // 
            this.StepArea.BeforeTouchSize = new System.Drawing.Size(330, 40);
            this.StepArea.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StepArea.ForeColor = System.Drawing.SystemColors.ControlText;
            this.StepArea.ImageCheckBoxSize = new System.Drawing.Size(20, 20);
            this.StepArea.Location = new System.Drawing.Point(15, 480);
            this.StepArea.Margin = new System.Windows.Forms.Padding(0);
            this.StepArea.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.StepArea.Name = "StepArea";
            this.StepArea.Size = new System.Drawing.Size(330, 40);
            this.StepArea.Style = Syncfusion.Windows.Forms.Tools.RadioButtonAdvStyle.Metro;
            this.StepArea.TabIndex = 8;
            this.StepArea.TabStop = false;
            this.StepArea.Tag = "StepArea";
            this.StepArea.Text = "Step Area";
            this.StepArea.ThemesEnabled = false;
            this.StepArea.CheckChanged += new System.EventHandler(this.ChartType_CheckChanged);
            // 
            // StepLine
            // 
            this.StepLine.BeforeTouchSize = new System.Drawing.Size(330, 40);
            this.StepLine.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StepLine.ForeColor = System.Drawing.SystemColors.ControlText;
            this.StepLine.ImageCheckBoxSize = new System.Drawing.Size(20, 20);
            this.StepLine.Location = new System.Drawing.Point(15, 360);
            this.StepLine.Margin = new System.Windows.Forms.Padding(0);
            this.StepLine.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.StepLine.Name = "StepLine";
            this.StepLine.Size = new System.Drawing.Size(330, 40);
            this.StepLine.Style = Syncfusion.Windows.Forms.Tools.RadioButtonAdvStyle.Metro;
            this.StepLine.TabIndex = 6;
            this.StepLine.TabStop = false;
            this.StepLine.Tag = "StepLine";
            this.StepLine.Text = "Step Line";
            this.StepLine.ThemesEnabled = false;
            this.StepLine.CheckChanged += new System.EventHandler(this.ChartType_CheckChanged);
            // 
            // StackingColumn100
            // 
            this.StackingColumn100.BeforeTouchSize = new System.Drawing.Size(330, 40);
            this.StackingColumn100.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StackingColumn100.ForeColor = System.Drawing.SystemColors.ControlText;
            this.StackingColumn100.ImageCheckBoxSize = new System.Drawing.Size(20, 20);
            this.StackingColumn100.Location = new System.Drawing.Point(15, 180);
            this.StackingColumn100.Margin = new System.Windows.Forms.Padding(0);
            this.StackingColumn100.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.StackingColumn100.Name = "StackingColumn100";
            this.StackingColumn100.Size = new System.Drawing.Size(330, 40);
            this.StackingColumn100.Style = Syncfusion.Windows.Forms.Tools.RadioButtonAdvStyle.Metro;
            this.StackingColumn100.TabIndex = 3;
            this.StackingColumn100.TabStop = false;
            this.StackingColumn100.Tag = "StackingColumn100";
            this.StackingColumn100.Text = "Stacking Column 100";
            this.StackingColumn100.ThemesEnabled = false;
            this.StackingColumn100.CheckChanged += new System.EventHandler(this.ChartType_CheckChanged);
            // 
            // StackingArea100
            // 
            this.StackingArea100.BeforeTouchSize = new System.Drawing.Size(330, 40);
            this.StackingArea100.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StackingArea100.ForeColor = System.Drawing.SystemColors.ControlText;
            this.StackingArea100.ImageCheckBoxSize = new System.Drawing.Size(20, 20);
            this.StackingArea100.Location = new System.Drawing.Point(15, 660);
            this.StackingArea100.Margin = new System.Windows.Forms.Padding(0);
            this.StackingArea100.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.StackingArea100.Name = "StackingArea100";
            this.StackingArea100.Size = new System.Drawing.Size(330, 40);
            this.StackingArea100.Style = Syncfusion.Windows.Forms.Tools.RadioButtonAdvStyle.Metro;
            this.StackingArea100.TabIndex = 11;
            this.StackingArea100.TabStop = false;
            this.StackingArea100.Tag = "StackingArea100";
            this.StackingArea100.Text = "Stacking Area 100";
            this.StackingArea100.ThemesEnabled = false;
            this.StackingArea100.CheckChanged += new System.EventHandler(this.ChartType_CheckChanged);
            // 
            // StackingColumn
            // 
            this.StackingColumn.BeforeTouchSize = new System.Drawing.Size(330, 40);
            this.StackingColumn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StackingColumn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.StackingColumn.ImageCheckBoxSize = new System.Drawing.Size(20, 20);
            this.StackingColumn.Location = new System.Drawing.Point(15, 120);
            this.StackingColumn.Margin = new System.Windows.Forms.Padding(0);
            this.StackingColumn.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.StackingColumn.Name = "StackingColumn";
            this.StackingColumn.Size = new System.Drawing.Size(330, 40);
            this.StackingColumn.Style = Syncfusion.Windows.Forms.Tools.RadioButtonAdvStyle.Metro;
            this.StackingColumn.TabIndex = 2;
            this.StackingColumn.TabStop = false;
            this.StackingColumn.Tag = "StackingColumn";
            this.StackingColumn.Text = "Stacking Column";
            this.StackingColumn.ThemesEnabled = false;
            this.StackingColumn.CheckChanged += new System.EventHandler(this.ChartType_CheckChanged);
            // 
            // StackingArea
            // 
            this.StackingArea.BeforeTouchSize = new System.Drawing.Size(330, 40);
            this.StackingArea.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StackingArea.ForeColor = System.Drawing.SystemColors.ControlText;
            this.StackingArea.ImageCheckBoxSize = new System.Drawing.Size(20, 20);
            this.StackingArea.Location = new System.Drawing.Point(15, 600);
            this.StackingArea.Margin = new System.Windows.Forms.Padding(0);
            this.StackingArea.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.StackingArea.Name = "StackingArea";
            this.StackingArea.Size = new System.Drawing.Size(330, 40);
            this.StackingArea.Style = Syncfusion.Windows.Forms.Tools.RadioButtonAdvStyle.Metro;
            this.StackingArea.TabIndex = 10;
            this.StackingArea.TabStop = false;
            this.StackingArea.Tag = "StackingArea";
            this.StackingArea.Text = "Stacking Area";
            this.StackingArea.ThemesEnabled = false;
            this.StackingArea.CheckChanged += new System.EventHandler(this.ChartType_CheckChanged);
            // 
            // SplineArea
            // 
            this.SplineArea.BeforeTouchSize = new System.Drawing.Size(330, 40);
            this.SplineArea.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SplineArea.ForeColor = System.Drawing.SystemColors.ControlText;
            this.SplineArea.ImageCheckBoxSize = new System.Drawing.Size(20, 20);
            this.SplineArea.Location = new System.Drawing.Point(15, 540);
            this.SplineArea.Margin = new System.Windows.Forms.Padding(0);
            this.SplineArea.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.SplineArea.Name = "SplineArea";
            this.SplineArea.Size = new System.Drawing.Size(330, 40);
            this.SplineArea.Style = Syncfusion.Windows.Forms.Tools.RadioButtonAdvStyle.Metro;
            this.SplineArea.TabIndex = 9;
            this.SplineArea.TabStop = false;
            this.SplineArea.Tag = "SplineArea";
            this.SplineArea.Text = "Spline Area";
            this.SplineArea.ThemesEnabled = false;
            this.SplineArea.CheckChanged += new System.EventHandler(this.ChartType_CheckChanged);
            // 
            // Area
            // 
            this.Area.BeforeTouchSize = new System.Drawing.Size(330, 40);
            this.Area.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Area.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Area.ImageCheckBoxSize = new System.Drawing.Size(20, 20);
            this.Area.Location = new System.Drawing.Point(14, 420);
            this.Area.Margin = new System.Windows.Forms.Padding(0);
            this.Area.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.Area.Name = "Area";
            this.Area.Size = new System.Drawing.Size(330, 40);
            this.Area.Style = Syncfusion.Windows.Forms.Tools.RadioButtonAdvStyle.Metro;
            this.Area.TabIndex = 7;
            this.Area.TabStop = false;
            this.Area.Tag = "Area";
            this.Area.Text = "Area";
            this.Area.ThemesEnabled = false;
            this.Area.CheckChanged += new System.EventHandler(this.ChartType_CheckChanged);
            // 
            // Column
            // 
            this.Column.BeforeTouchSize = new System.Drawing.Size(330, 40);
            this.Column.Checked = true;
            this.Column.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Column.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Column.ImageCheckBoxSize = new System.Drawing.Size(20, 20);
            this.Column.Location = new System.Drawing.Point(15, 60);
            this.Column.Margin = new System.Windows.Forms.Padding(0);
            this.Column.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.Column.Name = "Column";
            this.Column.Size = new System.Drawing.Size(330, 40);
            this.Column.Style = Syncfusion.Windows.Forms.Tools.RadioButtonAdvStyle.Metro;
            this.Column.TabIndex = 1;
            this.Column.Tag = "Column";
            this.Column.Text = "Column";
            this.Column.ThemesEnabled = false;
            this.Column.CheckChanged += new System.EventHandler(this.ChartType_CheckChanged);
            // 
            // Spline
            // 
            this.Spline.BeforeTouchSize = new System.Drawing.Size(330, 40);
            this.Spline.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Spline.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Spline.ImageCheckBoxSize = new System.Drawing.Size(20, 20);
            this.Spline.Location = new System.Drawing.Point(15, 300);
            this.Spline.Margin = new System.Windows.Forms.Padding(0);
            this.Spline.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.Spline.Name = "Spline";
            this.Spline.Size = new System.Drawing.Size(330, 40);
            this.Spline.Style = Syncfusion.Windows.Forms.Tools.RadioButtonAdvStyle.Metro;
            this.Spline.TabIndex = 5;
            this.Spline.TabStop = false;
            this.Spline.Tag = "Spline";
            this.Spline.Text = "Spline";
            this.Spline.ThemesEnabled = false;
            this.Spline.CheckChanged += new System.EventHandler(this.ChartType_CheckChanged);
            // 
            // Line
            // 
            this.Line.BeforeTouchSize = new System.Drawing.Size(330, 40);
            this.Line.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Line.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Line.ImageCheckBoxSize = new System.Drawing.Size(20, 20);
            this.Line.Location = new System.Drawing.Point(15, 240);
            this.Line.Margin = new System.Windows.Forms.Padding(0);
            this.Line.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.Line.Name = "Line";
            this.Line.Size = new System.Drawing.Size(330, 40);
            this.Line.Style = Syncfusion.Windows.Forms.Tools.RadioButtonAdvStyle.Metro;
            this.Line.TabIndex = 4;
            this.Line.TabStop = false;
            this.Line.Tag = "Line";
            this.Line.Text = "Line";
            this.Line.ThemesEnabled = false;
            this.Line.CheckChanged += new System.EventHandler(this.ChartType_CheckChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.CaptionAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.CaptionBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.CaptionBarHeight = 50;
            this.CaptionButtonColor = System.Drawing.Color.White;
            this.CaptionButtonHoverColor = System.Drawing.Color.White;
            this.CaptionFont = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CaptionForeColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1600, 850);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pivotChart1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(0);
            this.MinimumSize = new System.Drawing.Size(1600, 900);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chart Types";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.StepArea)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StepLine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StackingColumn100)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StackingArea100)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StackingColumn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StackingArea)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SplineArea)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Area)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Column)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Spline)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Line)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PivotChart pivotChart1;
        private GroupBox groupBox1;
        private RadioButtonAdv StepArea;
        private RadioButtonAdv StepLine;
        private RadioButtonAdv StackingColumn100;
        private RadioButtonAdv StackingArea100;
        private RadioButtonAdv StackingColumn;
        private RadioButtonAdv StackingArea;
        private RadioButtonAdv SplineArea;
        private RadioButtonAdv Area;
        private RadioButtonAdv Column;
        private RadioButtonAdv Spline;
        private RadioButtonAdv Line;
    }
}
#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Syncfusion.Windows.Forms.Chart;
using System.Drawing;

namespace ChartMultiLevelLabel_2005
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private Syncfusion.Windows.Forms.Chart.ChartControl chartControl1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;

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
            this.chartControl1 = new Syncfusion.Windows.Forms.Chart.ChartControl();
            this.label5 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // chartControl1
            // 
            this.chartControl1.BackInterior = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(209)))), ((int)(((byte)(226))))), System.Drawing.Color.White);
            this.chartControl1.BorderAppearance.SkinStyle = Syncfusion.Windows.Forms.Chart.ChartBorderSkinStyle.Raised;
            this.chartControl1.ChartArea.CursorLocation = new System.Drawing.Point(0, 0);
            this.chartControl1.ChartArea.CursorReDraw = false;
            this.chartControl1.ChartArea.Watermark.TextColor = System.Drawing.SystemColors.ControlText;
            this.chartControl1.ChartArea.XAxesLayoutMode = Syncfusion.Windows.Forms.Chart.ChartAxesLayoutMode.SideBySide;
            this.chartControl1.ChartArea.YAxesLayoutMode = Syncfusion.Windows.Forms.Chart.ChartAxesLayoutMode.SideBySide;
            this.chartControl1.ChartAreaMargins = new Syncfusion.Windows.Forms.Chart.ChartMargins(10, 10, 20, 10);
            this.chartControl1.ChartInterior = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(209)))), ((int)(((byte)(226))))), System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(232)))), ((int)(((byte)(243))))));
            this.chartControl1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chartControl1.IsWindowLess = false;
            // 
            // 
            // 

            this.chartControl1.Localize = null;
            this.chartControl1.Location = new System.Drawing.Point(14, 11);
            this.chartControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chartControl1.Name = "chartControl1";
            this.chartControl1.PrimaryXAxis.Title = "Months";
            this.chartControl1.PrimaryYAxis.Range = new MinMaxInfo(0, 40, 5);
            this.chartControl1.PrimaryYAxis.Title = "Temperature in Celsius";
            this.chartControl1.Size = new System.Drawing.Size(1050, 869);
            this.chartControl1.TabIndex = 0;
            // 
            // 
            //      
            this.chartControl1.Title.Name = "Def_title";
            this.chartControl1.Title.Text = "Temperature of London in 2015";
            this.chartControl1.Titles.Add(this.chartControl1.Title);
            this.chartControl1.ZoomOutIncrement = 1.5D;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label5.Location = new System.Drawing.Point(51, 46);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(185, 40);
            this.label5.TabIndex = 74;
            this.label5.Text = "Properties";
            // 
            // panel5
            // 
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.AutoScroll = true;
            this.panel5.AutoScrollMargin = new System.Drawing.Size(0, 20);
            this.panel5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Controls.Add(this.comboBox1);
            this.panel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel5.Location = new System.Drawing.Point(1062, 11);
            this.panel5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(376, 869);
            this.panel5.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label1.Location = new System.Drawing.Point(63, 129);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 32);
            this.label1.TabIndex = 36;
            this.label1.Text = "BorderStyle";
            // 
            // comboBox1
            // 
            this.comboBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.comboBox1.Items.AddRange(new object[] {
            "Brace",
            "LeftBorder",
            "Rectangle",
            "RightBorder",
            "WithoutBorder",
            "WithoutTopAndBottomBorder",
            "WithoutTopBorder"});
            this.comboBox1.Location = new System.Drawing.Point(58, 192);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(246, 40);
            this.comboBox1.SelectedIndex = 2;
            this.comboBox1.TabIndex = 38;
            this.comboBox1.SelectedIndexChanged += ComboBox1_SelectedIndexChanged;
            //
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1432, 894);
            this.Controls.Add(this.chartControl1);
            this.Controls.Add(this.panel5);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(1021, 924);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Multi-level Labels";
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        private void ComboBox1_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            foreach (ChartAxisGroupingLabel groupingLabel in chartControl1.PrimaryYAxis.GroupingLabels)
            {
                foreach (ChartAxisGroupingLabel groupingLabel1 in chartControl1.PrimaryXAxis.GroupingLabels)
                {
                    if (comboBox1.SelectedIndex == 0)
                    {
                        groupingLabel.BorderStyle = ChartAxisGroupingLabelBorderStyle.Brace;
                        groupingLabel1.BorderStyle = ChartAxisGroupingLabelBorderStyle.Brace;
                    }
                    else if (comboBox1.SelectedIndex == 1)
                    {
                        groupingLabel.BorderStyle = ChartAxisGroupingLabelBorderStyle.LeftBorder;
                        groupingLabel1.BorderStyle = ChartAxisGroupingLabelBorderStyle.LeftBorder;
                    }
                    else if (comboBox1.SelectedIndex == 2)
                    {
                        groupingLabel.BorderStyle = ChartAxisGroupingLabelBorderStyle.Rectangle;
                        groupingLabel1.BorderStyle = ChartAxisGroupingLabelBorderStyle.Rectangle;
                    }
                    else if (comboBox1.SelectedIndex == 3)
                    {
                        groupingLabel.BorderStyle = ChartAxisGroupingLabelBorderStyle.RightBorder;
                        groupingLabel1.BorderStyle = ChartAxisGroupingLabelBorderStyle.RightBorder;
                    }
                    else if (comboBox1.SelectedIndex == 4)
                    {
                        groupingLabel.BorderStyle = ChartAxisGroupingLabelBorderStyle.WithoutBorder;
                        groupingLabel1.BorderStyle = ChartAxisGroupingLabelBorderStyle.WithoutBorder;
                    }
                    else if (comboBox1.SelectedIndex == 5)
                    {
                        groupingLabel.BorderStyle = ChartAxisGroupingLabelBorderStyle.WithoutTopAndBottomBorder;
                        groupingLabel1.BorderStyle = ChartAxisGroupingLabelBorderStyle.WithoutTopAndBottomBorder;
                    }
                    else
                    {
                        groupingLabel.BorderStyle = ChartAxisGroupingLabelBorderStyle.WithoutTopBorder;
                        groupingLabel1.BorderStyle = ChartAxisGroupingLabelBorderStyle.WithoutTopBorder;
                    }
                }
            }          
            this.chartControl1.Refresh();
        }
        #endregion       
    }
}


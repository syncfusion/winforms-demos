#region Copyright Syncfusion Inc. 2001-2023.
// Copyright Syncfusion Inc. 2001-2023. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Syncfusion.Windows.Forms.PivotAnalysis;
using System.Drawing;
using System.Windows.Forms;

namespace PivotChartTypes_Demo
{
    partial class FieldList
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
            this.chart = new System.Windows.Forms.Panel();
            this.grid = new System.Windows.Forms.Panel();
            this.pivotGrid1 = new Syncfusion.Windows.Forms.PivotAnalysis.PivotGridControl(this.components);
            this.grid.SuspendLayout();
            this.SuspendLayout();
            // 
            // chart
            // 
            this.chart.Dock = System.Windows.Forms.DockStyle.Top;
            this.chart.Location = new System.Drawing.Point(2, 2);
            this.chart.Name = "chart";
            this.chart.Size = new System.Drawing.Size(1796, 645);
            this.chart.TabIndex = 0;
            // 
            // grid
            // 
            this.grid.Controls.Add(this.pivotGrid1);
            this.grid.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grid.Location = new System.Drawing.Point(2, 653);
            this.grid.Name = "grid";
            this.grid.Size = new System.Drawing.Size(1796, 390);
            this.grid.TabIndex = 1;
            // 
            // pivotGrid1
            // 
            this.pivotGrid1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pivotGrid1.EditManager = null;
            this.pivotGrid1.Location = new System.Drawing.Point(0, 6);
            this.pivotGrid1.Name = "pivotGrid1";
            this.pivotGrid1.Size = new System.Drawing.Size(1796, 384);
            this.pivotGrid1.TabIndex = 0;
            this.pivotGrid1.Text = "pivotGridControl1";
            this.pivotGrid1.UpdateManager = null;
            // 
            // FieldList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1800, 1045);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.chart);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FieldList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Style.InactiveShadowOpacity = ((byte)(0));
            this.Style.ShadowOpacity = ((byte)(0));
            this.Style.TitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(130)))), ((int)(((byte)(195)))));
            this.Style.TitleBar.CloseButtonForeColor = System.Drawing.Color.White;
            this.Style.TitleBar.CloseButtonHoverForeColor = System.Drawing.Color.LightGray;
            this.Style.TitleBar.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.Style.TitleBar.ForeColor = System.Drawing.Color.White;
            this.Style.TitleBar.MaximizeButtonForeColor = System.Drawing.Color.White;
            this.Style.TitleBar.MaximizeButtonHoverForeColor = System.Drawing.Color.Black;
            this.Style.TitleBar.MinimizeButtonForeColor = System.Drawing.Color.White;
            this.Style.TitleBar.MinimizeButtonHoverForeColor = System.Drawing.Color.Black;
            this.Style.TitleBar.TextHorizontalAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.Text = "Pivot Customization";
            this.grid.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel chart;
        private Panel grid;
        private PivotGridControl pivotGrid1;
    }
}
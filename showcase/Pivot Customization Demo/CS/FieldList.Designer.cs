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
            this.pivotGrid1 = new Syncfusion.Windows.Forms.PivotAnalysis.PivotGridControl(this.components);
            this.Entire = new System.Windows.Forms.Panel();
            this.Chartandgrid = new System.Windows.Forms.Panel();
            this.chart = new System.Windows.Forms.Panel();
            this.grid = new System.Windows.Forms.Panel();
            this.Entire.SuspendLayout();
            this.Chartandgrid.SuspendLayout();
            this.SuspendLayout();
            // 
            // pivotGrid1
            // 
            this.pivotGrid1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pivotGrid1.EditManager = null;
            this.pivotGrid1.Location = new System.Drawing.Point(0, 0);
            this.pivotGrid1.Name = "pivotGrid1";
            this.pivotGrid1.Size = new System.Drawing.Size(0, 0);
            this.pivotGrid1.TabIndex = 0;
            this.pivotGrid1.UpdateManager = null;
            // 
            // Entire
            // 
            this.Entire.Controls.Add(this.Chartandgrid);
            this.Entire.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Entire.Location = new System.Drawing.Point(3, 3);
            this.Entire.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Entire.Name = "Entire";
            this.Entire.Size = new System.Drawing.Size(1794, 1039);
            this.Entire.TabIndex = 0;
            // 
            // Chartandgrid
            // 
            this.Chartandgrid.Controls.Add(this.chart);
            this.Chartandgrid.Controls.Add(this.grid);
            this.Chartandgrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Chartandgrid.Location = new System.Drawing.Point(0, 0);
            this.Chartandgrid.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Chartandgrid.Name = "Chartandgrid";
            this.Chartandgrid.Size = new System.Drawing.Size(1794, 1039);
            this.Chartandgrid.TabIndex = 1;
            // 
            // chart
            // 
            this.chart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chart.Location = new System.Drawing.Point(0, 0);
            this.chart.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chart.Name = "chart";
            this.chart.Size = new System.Drawing.Size(1794, 590);
            this.chart.TabIndex = 1;
            // 
            // grid
            // 
            this.grid.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grid.Location = new System.Drawing.Point(0, 590);
            this.grid.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grid.Name = "grid";
            this.grid.Size = new System.Drawing.Size(1794, 449);
            this.grid.TabIndex = 0;
            // 
            // FieldList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1800, 1045);
            this.Controls.Add(this.Entire);
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
            this.Entire.ResumeLayout(false);
            this.Chartandgrid.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Entire;
        private System.Windows.Forms.Panel Chartandgrid;
        private System.Windows.Forms.Panel chart;
        private System.Windows.Forms.Panel grid;
    }
}
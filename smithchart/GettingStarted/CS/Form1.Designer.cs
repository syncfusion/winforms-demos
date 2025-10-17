#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Syncfusion.Windows.Forms;

namespace GettingStarted
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
            Syncfusion.WinForms.SmithChart.AxisStyle axisStyle1 = new Syncfusion.WinForms.SmithChart.AxisStyle();
            Syncfusion.WinForms.SmithChart.LegendStyle legendStyle1 = new Syncfusion.WinForms.SmithChart.LegendStyle();
            Syncfusion.WinForms.SmithChart.AxisStyle axisStyle2 = new Syncfusion.WinForms.SmithChart.AxisStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.sfSmithChart1 = new Syncfusion.WinForms.SmithChart.SfSmithChart();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.sfSmithChart1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1088, 563);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // sfSmithChart1
            // 
            this.sfSmithChart1.AccessibleName = "SfSmithChart";
            this.sfSmithChart1.BackColor = System.Drawing.Color.White;
            this.sfSmithChart1.ColorModel.CustomColors = null;
            this.sfSmithChart1.ColorModel.Palette = Syncfusion.WinForms.SmithChart.ChartColorPalette.Metro;
            this.sfSmithChart1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sfSmithChart1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.sfSmithChart1.HorizontalAxis.Style.AxisLineDashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.sfSmithChart1.HorizontalAxis.Style.AxisLineWidth = 1F;
            this.sfSmithChart1.HorizontalAxis.Style.LabelFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sfSmithChart1.HorizontalAxis.Style.MajorGridlinesDashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.sfSmithChart1.HorizontalAxis.Style.MajorGridlinesWidth = 1F;
            this.sfSmithChart1.HorizontalAxis.Style.MinorGridlinesDashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.sfSmithChart1.HorizontalAxis.Style.MinorGridlinesWidth = 0.5F;
            this.sfSmithChart1.Legend.Alignment = System.Drawing.StringAlignment.Center;
            this.sfSmithChart1.Legend.Height = 0;
            this.sfSmithChart1.Legend.OffsetX = 0;
            this.sfSmithChart1.Legend.OffsetY = 0;
            this.sfSmithChart1.Legend.Style.LabelFont = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sfSmithChart1.Legend.Width = 0;
            this.sfSmithChart1.Legend.WrapItems = false;
            this.sfSmithChart1.Location = new System.Drawing.Point(3, 3);
            this.sfSmithChart1.Name = "sfSmithChart1";
            this.sfSmithChart1.RadialAxis.Style.AxisLineDashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.sfSmithChart1.RadialAxis.Style.AxisLineWidth = 1F;
            this.sfSmithChart1.RadialAxis.Style.LabelFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sfSmithChart1.RadialAxis.Style.MajorGridlinesDashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.sfSmithChart1.RadialAxis.Style.MajorGridlinesWidth = 1F;
            this.sfSmithChart1.RadialAxis.Style.MinorGridlinesDashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.sfSmithChart1.RadialAxis.Style.MinorGridlinesWidth = 0.5F;
            this.sfSmithChart1.Radius = 0.95F;
            this.sfSmithChart1.Size = new System.Drawing.Size(864, 557);
            this.sfSmithChart1.Style.BackColor = System.Drawing.Color.White;
            this.sfSmithChart1.Style.ChartAreaBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.sfSmithChart1.Style.ChartAreaBorderColor = System.Drawing.Color.White;
            this.sfSmithChart1.Style.ChartAreaBorderWidth = 0;
            this.sfSmithChart1.Style.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            axisStyle1.AxisLineDashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            axisStyle1.AxisLineWidth = 1F;
            axisStyle1.LabelFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            axisStyle1.MajorGridlinesDashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            axisStyle1.MajorGridlinesWidth = 1F;
            axisStyle1.MinorGridlinesDashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            axisStyle1.MinorGridlinesWidth = 0.5F;
            this.sfSmithChart1.Style.HorizontalAxisStyle = axisStyle1;
            legendStyle1.LabelFont = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sfSmithChart1.Style.LegendStyle = legendStyle1;
            axisStyle2.AxisLineDashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            axisStyle2.AxisLineWidth = 1F;
            axisStyle2.LabelFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            axisStyle2.MajorGridlinesDashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            axisStyle2.MajorGridlinesWidth = 1F;
            axisStyle2.MinorGridlinesDashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            axisStyle2.MinorGridlinesWidth = 0.5F;
            this.sfSmithChart1.Style.RadialAxisStyle = axisStyle2;
            this.sfSmithChart1.TabIndex = 0;
            this.sfSmithChart1.TooltipOptions.BackColor = System.Drawing.Color.Empty;
            this.sfSmithChart1.TooltipOptions.BorderColor = System.Drawing.Color.Empty;
            this.sfSmithChart1.TooltipOptions.BorderWidth = 1;
            this.sfSmithChart1.TooltipOptions.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.sfSmithChart1.TooltipOptions.ForeColor = System.Drawing.Color.Empty;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(873, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(212, 557);
            this.panel1.TabIndex = 1;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Impedance",
            "Admittance"});
            this.comboBox1.Location = new System.Drawing.Point(27, 145);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.Text = "Impedance";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.RenderType);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Rendering Mode";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Properties";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1088, 563);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MinimumSize = new System.Drawing.Size(1100, 490);
            this.Name = "Form1";
            this.Text = "Getting Started";
            this.CaptionBarHeight = (int)DpiAware.LogicalToDeviceUnits(this.CaptionBarHeight);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Syncfusion.WinForms.SmithChart.SfSmithChart sfSmithChart1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}


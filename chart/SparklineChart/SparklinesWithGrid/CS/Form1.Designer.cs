#region Copyright Syncfusion Inc. 2001 - 2011
// Copyright Syncfusion Inc. 2001 - 2011. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Syncfusion.Windows.Forms;

namespace SparklinesWithGrid_2008
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
            Syncfusion.Windows.Forms.Grid.GridBaseStyle gridBaseStyle1 = new Syncfusion.Windows.Forms.Grid.GridBaseStyle();
            Syncfusion.Windows.Forms.Grid.GridBaseStyle gridBaseStyle2 = new Syncfusion.Windows.Forms.Grid.GridBaseStyle();
            Syncfusion.Windows.Forms.Grid.GridBaseStyle gridBaseStyle3 = new Syncfusion.Windows.Forms.Grid.GridBaseStyle();
            Syncfusion.Windows.Forms.Grid.GridBaseStyle gridBaseStyle4 = new Syncfusion.Windows.Forms.Grid.GridBaseStyle();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo1 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo2 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo3 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnRandomData = new System.Windows.Forms.Button();
            this.gridControl1 = new Syncfusion.Windows.Forms.Grid.GridControl();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRandomData
            // 
            this.btnRandomData.BackColor = System.Drawing.Color.Gray;
            this.btnRandomData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRandomData.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRandomData.ForeColor = System.Drawing.Color.White;
            this.btnRandomData.Location = new System.Drawing.Point(42, 59);
            this.btnRandomData.Name = "btnRandomData";
            this.btnRandomData.Size = new System.Drawing.Size(179, 32);
            this.btnRandomData.TabIndex = 1;
            this.btnRandomData.Text = "GRID RANDOM DATA";
            this.btnRandomData.UseVisualStyleBackColor = false;
            this.btnRandomData.Click += new System.EventHandler(this.btnRandomData_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.AllowIncreaseSmallChange = false;
            this.gridControl1.AlphaBlendSelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(94)))), ((int)(((byte)(171)))), ((int)(((byte)(222)))));
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            gridBaseStyle1.Name = "Header";
            gridBaseStyle1.StyleInfo.Borders.Bottom = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None);
            gridBaseStyle1.StyleInfo.Borders.Left = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None);
            gridBaseStyle1.StyleInfo.Borders.Right = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None);
            gridBaseStyle1.StyleInfo.Borders.Top = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None);
            gridBaseStyle1.StyleInfo.CellType = "Header";
            gridBaseStyle1.StyleInfo.Font.Bold = true;
            gridBaseStyle1.StyleInfo.Interior = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(199)))), ((int)(((byte)(184))))), System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(234)))), ((int)(((byte)(216))))));
            gridBaseStyle1.StyleInfo.VerticalAlignment = Syncfusion.Windows.Forms.Grid.GridVerticalAlignment.Middle;
            gridBaseStyle2.Name = "Standard";
            gridBaseStyle2.StyleInfo.Font.Facename = "Tahoma";
            gridBaseStyle2.StyleInfo.Interior = new Syncfusion.Drawing.BrushInfo(System.Drawing.SystemColors.Window);
            gridBaseStyle3.Name = "Column Header";
            gridBaseStyle3.StyleInfo.BaseStyle = "Header";
            gridBaseStyle3.StyleInfo.HorizontalAlignment = Syncfusion.Windows.Forms.Grid.GridHorizontalAlignment.Center;
            gridBaseStyle4.Name = "Row Header";
            gridBaseStyle4.StyleInfo.BaseStyle = "Header";
            gridBaseStyle4.StyleInfo.HorizontalAlignment = Syncfusion.Windows.Forms.Grid.GridHorizontalAlignment.Left;
            gridBaseStyle4.StyleInfo.Interior = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Horizontal, System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(199)))), ((int)(((byte)(184))))), System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(234)))), ((int)(((byte)(216))))));
            this.gridControl1.BaseStylesMap.AddRange(new Syncfusion.Windows.Forms.Grid.GridBaseStyle[] {
            gridBaseStyle1,
            gridBaseStyle2,
            gridBaseStyle3,
            gridBaseStyle4});
            this.gridControl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gridControl1.ColWidthEntries.AddRange(new Syncfusion.Windows.Forms.Grid.GridColWidth[] {
            new Syncfusion.Windows.Forms.Grid.GridColWidth(0, (int)DpiAware.LogicalToDeviceUnits(30.0f)),
            new Syncfusion.Windows.Forms.Grid.GridColWidth(10, (int)DpiAware.LogicalToDeviceUnits(80.0f))});
            this.gridControl1.DefaultColWidth = (int)DpiAware.LogicalToDeviceUnits(66.0f);
            this.gridControl1.DefaultGridBorderStyle = Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid;
            this.gridControl1.DefaultRowHeight = (int)DpiAware.LogicalToDeviceUnits(20.0f); 
            this.gridControl1.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.gridControl1.ForeColor = System.Drawing.Color.MidnightBlue;
            gridCellInfo1.Col = -1;
            gridCellInfo1.Row = -1;
            gridCellInfo1.StyleInfo.Font.Bold = false;
            gridCellInfo1.StyleInfo.Font.Facename = "Segoe UI";
            gridCellInfo1.StyleInfo.Font.Italic = false;
            gridCellInfo1.StyleInfo.Font.Size = 9.75F;
            gridCellInfo1.StyleInfo.Font.Strikeout = false;
            gridCellInfo1.StyleInfo.Font.Underline = false;
            gridCellInfo1.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point;
            gridCellInfo2.Col = -1;
            gridCellInfo2.Row = -1;
            gridCellInfo2.StyleInfo.Font.Bold = false;
            gridCellInfo2.StyleInfo.Font.Facename = "Segoe UI";
            gridCellInfo2.StyleInfo.Font.Italic = false;
            gridCellInfo2.StyleInfo.Font.Size = 9.75F;
            gridCellInfo2.StyleInfo.Font.Strikeout = false;
            gridCellInfo2.StyleInfo.Font.Underline = false;
            gridCellInfo2.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point;
            gridCellInfo3.Col = -1;
            gridCellInfo3.Row = -1;
            gridCellInfo3.StyleInfo.Font.Bold = false;
            gridCellInfo3.StyleInfo.Font.Facename = "Segoe UI";
            gridCellInfo3.StyleInfo.Font.Italic = false;
            gridCellInfo3.StyleInfo.Font.Size = 9.75F;
            gridCellInfo3.StyleInfo.Font.Strikeout = false;
            gridCellInfo3.StyleInfo.Font.Underline = false;
            gridCellInfo3.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point;
            gridCellInfo3.StyleInfo.TextColor = System.Drawing.Color.MidnightBlue;
            this.gridControl1.GridCells.AddRange(new Syncfusion.Windows.Forms.Grid.GridCellInfo[] {
            gridCellInfo1,
            gridCellInfo2,
            gridCellInfo3});
            this.gridControl1.GridOfficeScrollBars = Syncfusion.Windows.Forms.OfficeScrollBars.Metro;
            this.gridControl1.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro;
            this.gridControl1.Location = new System.Drawing.Point(-2, 1);
            this.gridControl1.MetroScrollBars = true;
            this.gridControl1.MinimumSize = new System.Drawing.Size(100, 100);
            this.gridControl1.MinResizeRowSize = 10;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Properties.BackgroundColor = System.Drawing.Color.Transparent;
            this.gridControl1.Properties.ForceImmediateRepaint = false;
            this.gridControl1.Properties.GridLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.gridControl1.Properties.MarkColHeader = false;
            this.gridControl1.Properties.MarkRowHeader = false;
            this.gridControl1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.gridControl1.RowHeightEntries.AddRange(new Syncfusion.Windows.Forms.Grid.GridRowHeight[] {
            new Syncfusion.Windows.Forms.Grid.GridRowHeight(0, (int)DpiAware.LogicalToDeviceUnits(52.0f)),
            new Syncfusion.Windows.Forms.Grid.GridRowHeight(1, (int)DpiAware.LogicalToDeviceUnits(54.0f)),
            new Syncfusion.Windows.Forms.Grid.GridRowHeight(2, (int)DpiAware.LogicalToDeviceUnits(54.0f)),
            new Syncfusion.Windows.Forms.Grid.GridRowHeight(3, (int)DpiAware.LogicalToDeviceUnits(54.0f)),
            new Syncfusion.Windows.Forms.Grid.GridRowHeight(4, (int)DpiAware.LogicalToDeviceUnits(54.0f)),
            new Syncfusion.Windows.Forms.Grid.GridRowHeight(5, (int)DpiAware.LogicalToDeviceUnits(54.0f)),
            new Syncfusion.Windows.Forms.Grid.GridRowHeight(6, (int)DpiAware.LogicalToDeviceUnits(54.0f)),
            new Syncfusion.Windows.Forms.Grid.GridRowHeight(7, (int)DpiAware.LogicalToDeviceUnits(54.0f)),
            new Syncfusion.Windows.Forms.Grid.GridRowHeight(8, (int)DpiAware.LogicalToDeviceUnits(53.0f)),
            new Syncfusion.Windows.Forms.Grid.GridRowHeight(9, (int)DpiAware.LogicalToDeviceUnits(53.0f)),
            new Syncfusion.Windows.Forms.Grid.GridRowHeight(10, (int)DpiAware.LogicalToDeviceUnits(53.0f))});
            this.gridControl1.ScrollFrozen = false;
            this.gridControl1.SerializeCellsBehavior = Syncfusion.Windows.Forms.Grid.GridSerializeCellsBehavior.SerializeIntoCode;
            this.gridControl1.Size = new System.Drawing.Size(706, 585);
            this.gridControl1.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.gridControl1.SmartSizeBox = false;
            this.gridControl1.SmoothMouseWheelScrolling = false;
            this.gridControl1.TabIndex = 2;
            this.gridControl1.ThemesEnabled = true;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.btnRandomData);
            this.panel1.Location = new System.Drawing.Point(704, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(260, 585);
            this.panel1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 584);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gridControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(845, 466);
            this.Name = "Form1";
            this.Text = "Sparkline with Grid";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRandomData;
        private Syncfusion.Windows.Forms.Grid.GridControl gridControl1;
        private System.Windows.Forms.Panel panel1;
    }
}


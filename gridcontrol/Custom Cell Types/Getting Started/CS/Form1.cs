#region Copyright Syncfusion Inc. 2001 - 2015
//
//  Copyright Syncfusion Inc. 2001 - 2015. All rights reserved.
//
//  Use of this code is subject to the terms of our license.
//  A copy of the current license can be obtained at any time by e-mailing
//  licensing@syncfusion.com. Any infringement will be prosecuted under
//  applicable laws. 
//
#endregion

using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using Syncfusion.Windows.Forms.Grid;
using Syncfusion.Windows.Forms;
using DemoCommon.Grid;

namespace GridLinkLabel
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : GridDemoForm
    {
        #region "API Definition"

        private Syncfusion.Windows.Forms.Grid.GridControl gridControl1;
		private System.Windows.Forms.Panel panel1;
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.Container components = null;

        #endregion

        #region "Constructor"

        public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
            if(DpiAware.GetCurrentDpi() > 96)
            {
                this.CaptionBarHeight = (int)DpiAware.LogicalToDeviceUnits(this.CaptionBarHeight);
            }
            #region Custom Cells
            gridControl1.DefaultRowHeight = (int)DpiAware.LogicalToDeviceUnits(22.0f);
            gridControl1.ExcelLikeCurrentCell = true;
			gridControl1.ExcelLikeSelectionFrame = true;
            gridControl1.ControllerOptions = GridControllerOptions.All;
            gridControl1.HScrollBehavior = GridScrollbarMode.Disabled;
            gridControl1.CoveredRanges.Add(GridRangeInfo.Cells(1, 1, 2, gridControl1.ColCount));
            gridControl1[1, 1].Text = "Derived Cell Controls";
            gridControl1[1, 1].Font.Bold = true;
            gridControl1[1, 1].Font.Size = 12;
            gridControl1[1, 1].TextColor = Color.Black;
            gridControl1[1, 1].CellType = GridCellTypeName.Static;
            gridControl1[1, 1].VerticalAlignment = GridVerticalAlignment.Middle;
            gridControl1[1, 1].HorizontalAlignment = GridHorizontalAlignment.Center;
			gridControl1.CellModels.Add("LinkLabelCell", new LinkLabelCellModel(gridControl1.Model));

			int rowIndex = 4;		    
			gridControl1[rowIndex, 4].Text = "Syncfusion, Inc.";
			gridControl1[rowIndex, 4].Font.Bold = true;
			gridControl1[rowIndex, 4].Tag = "http://www.syncfusion.com";
            gridControl1[rowIndex, 4].HorizontalAlignment = GridHorizontalAlignment.Center;
            gridControl1[rowIndex, 4].CellType = "LinkLabelCell";

			rowIndex++;
			gridControl1[rowIndex, 4].CellType = "LinkLabelCell";
			gridControl1[rowIndex, 4].Text = "Windows Forms FAQ";
			gridControl1[rowIndex, 4].Font.Bold = true;
            gridControl1[rowIndex, 4].Tag = "http://www.syncfusion.com/support/forums/grid-windows";
			gridControl1[rowIndex, 4].HorizontalAlignment = GridHorizontalAlignment.Center;

			rowIndex++;
			gridControl1[rowIndex, 4].CellType = "LinkLabelCell";
			gridControl1[rowIndex, 4].Text = "Microsoft Windows Forms";
			gridControl1[rowIndex, 4].Font.Bold = true;
			gridControl1[rowIndex, 4].Tag = "http://windowsforms.net/";
			gridControl1[rowIndex, 4].HorizontalAlignment = GridHorizontalAlignment.Center;
			
			rowIndex++;
			gridControl1[rowIndex, 4].CellType = "LinkLabelCell";
			gridControl1[rowIndex, 4].Text = "MSDN";
			gridControl1[rowIndex, 4].Font.Bold = true;
			gridControl1[rowIndex, 4].Tag = "http://msdn.microsoft.com";
			gridControl1[rowIndex, 4].HorizontalAlignment = GridHorizontalAlignment.Center;

			rowIndex++;
			gridControl1[rowIndex, 4].CellType = "LinkLabelCell";
			gridControl1[rowIndex, 4].Text = "Yahoo";
			gridControl1[rowIndex, 4].Font.Bold = true;
			gridControl1[rowIndex, 4].Tag = "http://www.yahoo.com";
			gridControl1[rowIndex, 4].HorizontalAlignment = GridHorizontalAlignment.Center;

			rowIndex++;
			gridControl1[rowIndex, 4].CellType = "LinkLabelCell";
			gridControl1[rowIndex, 4].Text = "Google";
			gridControl1[rowIndex, 4].Font.Bold = true;
			gridControl1[rowIndex, 4].Tag = "http://www.google.com/";
			gridControl1[rowIndex, 4].HorizontalAlignment = GridHorizontalAlignment.Center;

			gridControl1.ColWidths.ResizeToFit(GridRangeInfo.Col(4));
			gridControl1.ColStyles[4].TextColor = Color.Blue;
  
			this.gridControl1.DefaultColWidth = (int)DpiAware.LogicalToDeviceUnits(70.0f);			
			this.gridControl1.DefaultGridBorderStyle = GridBorderStyle.Solid;
            gridControl1.AllowProportionalColumnSizing = true;
            this.gridControl1.Model.Options.DisplayEmptyRows = true;
            this.gridControl1.RowHeights[0] = 30;

            #endregion
            this.gridControl1.ColWidths[0] = (int)DpiAware.LogicalToDeviceUnits(30);

        }

        #endregion

        #region FormHandlers

        /// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            Syncfusion.Windows.Forms.Grid.GridBaseStyle gridBaseStyle9 = new Syncfusion.Windows.Forms.Grid.GridBaseStyle();
            Syncfusion.Windows.Forms.Grid.GridBaseStyle gridBaseStyle10 = new Syncfusion.Windows.Forms.Grid.GridBaseStyle();
            Syncfusion.Windows.Forms.Grid.GridBaseStyle gridBaseStyle11 = new Syncfusion.Windows.Forms.Grid.GridBaseStyle();
            Syncfusion.Windows.Forms.Grid.GridBaseStyle gridBaseStyle12 = new Syncfusion.Windows.Forms.Grid.GridBaseStyle();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo4 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            this.gridControl1 = new Syncfusion.Windows.Forms.Grid.GridControl();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DpiAware = true;
            this.gridControl1.AlphaBlendSelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(94)))), ((int)(((byte)(171)))), ((int)(((byte)(222)))));
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            gridBaseStyle9.Name = "Header";
            gridBaseStyle9.StyleInfo.Borders.Bottom = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None);
            gridBaseStyle9.StyleInfo.Borders.Left = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None);
            gridBaseStyle9.StyleInfo.Borders.Right = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None);
            gridBaseStyle9.StyleInfo.Borders.Top = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None);
            gridBaseStyle9.StyleInfo.CellType = "Header";
            gridBaseStyle9.StyleInfo.Font.Bold = true;
            gridBaseStyle9.StyleInfo.Interior = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(199)))), ((int)(((byte)(184))))), System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(234)))), ((int)(((byte)(216))))));
            gridBaseStyle9.StyleInfo.VerticalAlignment = Syncfusion.Windows.Forms.Grid.GridVerticalAlignment.Middle;
            gridBaseStyle10.Name = "Standard";
            gridBaseStyle10.StyleInfo.Font.Facename = "Tahoma";
            gridBaseStyle10.StyleInfo.Interior = new Syncfusion.Drawing.BrushInfo(System.Drawing.SystemColors.Window);
            gridBaseStyle11.Name = "Column Header";
            gridBaseStyle11.StyleInfo.BaseStyle = "Header";
            gridBaseStyle11.StyleInfo.HorizontalAlignment = Syncfusion.Windows.Forms.Grid.GridHorizontalAlignment.Center;
            gridBaseStyle12.Name = "Row Header";
            gridBaseStyle12.StyleInfo.BaseStyle = "Header";
            gridBaseStyle12.StyleInfo.HorizontalAlignment = Syncfusion.Windows.Forms.Grid.GridHorizontalAlignment.Left;
            gridBaseStyle12.StyleInfo.Interior = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Horizontal, System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(199)))), ((int)(((byte)(184))))), System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(234)))), ((int)(((byte)(216))))));
            this.gridControl1.BaseStylesMap.AddRange(new Syncfusion.Windows.Forms.Grid.GridBaseStyle[] {
            gridBaseStyle9,
            gridBaseStyle10,
            gridBaseStyle11,
            gridBaseStyle12});
            this.gridControl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gridControl1.ColCount = 7;
            this.gridControl1.ColWidthEntries.AddRange(new Syncfusion.Windows.Forms.Grid.GridColWidth[] {
            new Syncfusion.Windows.Forms.Grid.GridColWidth(0, 35)});
            this.gridControl1.DefaultGridBorderStyle = Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid;
            this.gridControl1.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.gridControl1.ForeColor = System.Drawing.Color.MidnightBlue;
            gridCellInfo4.Col = -1;
            gridCellInfo4.Row = -1;
            gridCellInfo4.StyleInfo.Borders.Bottom = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234))))), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin);
            gridCellInfo4.StyleInfo.Borders.Right = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234))))), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin);
            gridCellInfo4.StyleInfo.Font.Bold = false;
            gridCellInfo4.StyleInfo.Font.Facename = "Segoe UI";
            gridCellInfo4.StyleInfo.Font.Italic = false;
            gridCellInfo4.StyleInfo.Font.Size = 8.5F;
            gridCellInfo4.StyleInfo.Font.Strikeout = false;
            gridCellInfo4.StyleInfo.Font.Underline = false;
            gridCellInfo4.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point;
            gridCellInfo4.StyleInfo.Interior = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.White);
            gridCellInfo4.StyleInfo.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gridControl1.GridCells.AddRange(new Syncfusion.Windows.Forms.Grid.GridCellInfo[] {
            gridCellInfo4});
            this.gridControl1.GridOfficeScrollBars = Syncfusion.Windows.Forms.OfficeScrollBars.Metro;
            this.gridControl1.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro;
            this.gridControl1.DefaultRowHeight = (int)DpiAware.LogicalToDeviceUnits(20.0f);
            this.gridControl1.DefaultColWidth = (int)DpiAware.LogicalToDeviceUnits(70.0f);
            this.gridControl1.Location = new System.Drawing.Point(10, 12);
            this.gridControl1.MetroScrollBars = true;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Properties.BackgroundColor = System.Drawing.Color.White;
            this.gridControl1.Properties.ForceImmediateRepaint = false;
            this.gridControl1.Properties.GridLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.gridControl1.Properties.MarkColHeader = false;
            this.gridControl1.Properties.MarkRowHeader = false;
            this.gridControl1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.gridControl1.RowCount = 20;
            this.gridControl1.RowHeightEntries.AddRange(new Syncfusion.Windows.Forms.Grid.GridRowHeight[] {
            new Syncfusion.Windows.Forms.Grid.GridRowHeight(0, 21)});
            this.gridControl1.SerializeCellsBehavior = Syncfusion.Windows.Forms.Grid.GridSerializeCellsBehavior.SerializeIntoCode;
            this.gridControl1.Size = new System.Drawing.Size(996, 629);
            this.gridControl1.SmartSizeBox = false;
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ThemesEnabled = true;
            this.gridControl1.DpiAware = true;
            this.gridControl1.VerticalThumbTrack = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.gridControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1012, 653);
            this.panel1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 653);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(430, 300);
            this.Name = "Form1";
            this.Text = "Getting Started";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		public static void Main()
        {
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense(Syncfusion.Licensing.DemoCommon.FindLicenseKey());
# if SyncfusionFramework1_1 || SyncfusionFramework2_0  
			Application.EnableVisualStyles();
# endif
			Application.Run(new Form1());
        }

        #endregion

        #region EventHandlers

        /// <summary>
        /// Load the form for set the BasestyleMap for font
        /// </summary>

        private void Form1_Load(object sender, System.EventArgs e)
		{
			gridControl1.Model.BaseStylesMap["Header"].StyleInfo.Font.Bold = true;
        }
        #endregion
    }
}

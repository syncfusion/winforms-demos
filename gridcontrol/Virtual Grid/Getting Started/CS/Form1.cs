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

namespace VirtualGridTutorial
{
	using System;
	using System.Drawing;
	using System.Collections;
	using System.ComponentModel;
	using System.Windows.Forms;
	using Syncfusion.Windows.Forms.Grid;
	using System.Data;
    using Syncfusion.Windows.Forms;
    using DemoCommon.Grid;

	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : GridDemoForm
    {
        #region API Definition
        private Syncfusion.Windows.Forms.Grid.GridControl gridControl1;
		private ExternalData _extData;
		private System.Windows.Forms.Panel panel1;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;
        #endregion

        #region Constructor
        public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

            if (DpiAware.GetCurrentDpi() > 96)
            {
                this.CaptionBarHeight = (int)DpiAware.LogicalToDeviceUnits(this.CaptionBarHeight);
            }
            SampleCustomization();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
        }
        #endregion           

		#region Designer Stuffs
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            Syncfusion.Windows.Forms.Grid.GridBaseStyle gridBaseStyle5 = new Syncfusion.Windows.Forms.Grid.GridBaseStyle();
            Syncfusion.Windows.Forms.Grid.GridBaseStyle gridBaseStyle6 = new Syncfusion.Windows.Forms.Grid.GridBaseStyle();
            Syncfusion.Windows.Forms.Grid.GridBaseStyle gridBaseStyle7 = new Syncfusion.Windows.Forms.Grid.GridBaseStyle();
            Syncfusion.Windows.Forms.Grid.GridBaseStyle gridBaseStyle8 = new Syncfusion.Windows.Forms.Grid.GridBaseStyle();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo3 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            this.gridControl1 = new Syncfusion.Windows.Forms.Grid.GridControl();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DpiAware = true;
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            gridBaseStyle5.Name = "Header";
            gridBaseStyle5.StyleInfo.Borders.Bottom = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None);
            gridBaseStyle5.StyleInfo.Borders.Left = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None);
            gridBaseStyle5.StyleInfo.Borders.Right = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None);
            gridBaseStyle5.StyleInfo.Borders.Top = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None);
            gridBaseStyle5.StyleInfo.CellType = "Header";
            gridBaseStyle5.StyleInfo.Font.Bold = true;
            gridBaseStyle5.StyleInfo.Interior = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(199)))), ((int)(((byte)(184))))), System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(234)))), ((int)(((byte)(216))))));
            gridBaseStyle5.StyleInfo.VerticalAlignment = Syncfusion.Windows.Forms.Grid.GridVerticalAlignment.Middle;
            gridBaseStyle6.Name = "Standard";
            gridBaseStyle6.StyleInfo.Font.Facename = "Segoe UI";
            gridBaseStyle6.StyleInfo.Interior = new Syncfusion.Drawing.BrushInfo(System.Drawing.SystemColors.Window);
            gridBaseStyle7.Name = "Column Header";
            gridBaseStyle7.StyleInfo.BaseStyle = "Header";
            gridBaseStyle7.StyleInfo.HorizontalAlignment = Syncfusion.Windows.Forms.Grid.GridHorizontalAlignment.Center;
            gridBaseStyle8.Name = "Row Header";
            gridBaseStyle8.StyleInfo.BaseStyle = "Header";
            gridBaseStyle8.StyleInfo.HorizontalAlignment = Syncfusion.Windows.Forms.Grid.GridHorizontalAlignment.Left;
            gridBaseStyle8.StyleInfo.Interior = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Horizontal, System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(199)))), ((int)(((byte)(184))))), System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(234)))), ((int)(((byte)(216))))));
            this.gridControl1.BaseStylesMap.AddRange(new Syncfusion.Windows.Forms.Grid.GridBaseStyle[] {
            gridBaseStyle5,
            gridBaseStyle6,
            gridBaseStyle7,
            gridBaseStyle8});
            this.gridControl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gridControl1.ColWidthEntries.AddRange(new Syncfusion.Windows.Forms.Grid.GridColWidth[] {
            new Syncfusion.Windows.Forms.Grid.GridColWidth(0, 35)});
            this.gridControl1.DefaultGridBorderStyle = Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid;
             this.gridControl1.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.gridControl1.ForeColor = System.Drawing.Color.MidnightBlue;
            gridCellInfo3.Col = -1;
            gridCellInfo3.Row = -1;
            gridCellInfo3.StyleInfo.Borders.Bottom = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234))))), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin);
            gridCellInfo3.StyleInfo.Borders.Right = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234))))), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin);
            gridCellInfo3.StyleInfo.Font.Bold = false;
            gridCellInfo3.StyleInfo.Font.Facename = "Segoe UI";
            gridCellInfo3.StyleInfo.Font.Italic = false;
            gridCellInfo3.StyleInfo.Font.Size = 8.5F;
            gridCellInfo3.StyleInfo.Font.Strikeout = false;
            gridCellInfo3.StyleInfo.Font.Underline = false;
            gridCellInfo3.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point;
            gridCellInfo3.StyleInfo.Interior = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.White);
            gridCellInfo3.StyleInfo.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gridControl1.GridCells.AddRange(new Syncfusion.Windows.Forms.Grid.GridCellInfo[] {
            gridCellInfo3});
            this.gridControl1.GridOfficeScrollBars = Syncfusion.Windows.Forms.OfficeScrollBars.Metro;
            this.gridControl1.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro;
            this.gridControl1.DefaultRowHeight = (int)DpiAware.LogicalToDeviceUnits(20.0f);
            this.gridControl1.DefaultColWidth = (int)DpiAware.LogicalToDeviceUnits(70.0f);
            this.gridControl1.HorizontalThumbTrack = true;
            this.gridControl1.Location = new System.Drawing.Point(24, 12);
            this.gridControl1.MetroScrollBars = true;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Properties.BackgroundColor = System.Drawing.Color.White;
            this.gridControl1.Properties.GridLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.gridControl1.Properties.MarkColHeader = false;
            this.gridControl1.Properties.MarkRowHeader = false;
            this.gridControl1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.gridControl1.RowHeightEntries.AddRange(new Syncfusion.Windows.Forms.Grid.GridRowHeight[] {
            new Syncfusion.Windows.Forms.Grid.GridRowHeight(0, 21)});
            this.gridControl1.SerializeCellsBehavior = Syncfusion.Windows.Forms.Grid.GridSerializeCellsBehavior.SerializeIntoCode;
            this.gridControl1.Size = new System.Drawing.Size(746, 375);
            this.gridControl1.SmartSizeBox = false;
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ThemesEnabled = true;
            this.gridControl1.VerticalThumbTrack = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(792, 414);
            this.panel1.TabIndex = 1;
            // 
            // Form1
            //             
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 414);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.panel1);           
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Getting Started ";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            this.ResumeLayout(false);

		}
        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }
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
        
        #region Sample Customization
        /// <summary>
        /// Sample customization for Virual grid. 
        /// </summary>
        private void SampleCustomization()
        {
            //create a new external data source with 100 rows & 20 columns
            this._extData = new ExternalData(100, 20);

            //prepare the grid for virtual data
            gridControl1.ResetVolatileData();

            //hook up the events needed for virtual grid
            //While only the QueryCellInfo is absolutely required,
            //it would be unusual not to handle at least one of the row or column count events
            gridControl1.QueryCellInfo += new GridQueryCellInfoEventHandler(GridQueryCellInfo);
            gridControl1.QueryRowCount += new GridRowColCountEventHandler(GridQueryRowCount);
            gridControl1.QueryColCount += new GridRowColCountEventHandler(GridQueryColCount);

            //if you want to edit your data in the grid, you need to 
            //handle saving data back to the data source...
            gridControl1.SaveCellInfo += new GridSaveCellInfoEventHandler(GridSaveCellInfo);

            #region Optional Handler Hooks
            //other events that you can use to provide virtual data
            //these events are optional depending upon the functionality you want
            gridControl1.QueryRowHeight += new GridRowColSizeEventHandler(GridQueryRowHeight);
            gridControl1.QueryColWidth += new GridRowColSizeEventHandler(GridQueryColWidth);
            gridControl1.QueryCoveredRange += new GridQueryCoveredRangeEventHandler(GridQueryCoveredRange);
            #endregion
        }
        #endregion

        #region Event Handlers
        private void Form1_Load(object sender, System.EventArgs e)
		{			
			this.gridControl1.DefaultGridBorderStyle = GridBorderStyle.Solid;			
		}	
		
		#region SaveCellInfo handler - needed if you are editing
		//save the changes back to the datasource
		void GridSaveCellInfo(object sender, GridSaveCellInfoEventArgs e)
		{
			try
			{
				//move the changes back to the external data object
				if( e.ColIndex > 0 && e.RowIndex > 0)
				{
				//either of the next two lines will work without setting CellValueType
				//	this._extData[e.RowIndex - 1, e.ColIndex - 1] = (int) GridCellValueConvert.ChangeType( e.Style.CellValue, typeof(int), null) ;
					this._extData[e.RowIndex - 1, e.ColIndex - 1] = int.Parse(e.Style.CellValue.ToString());

				// can be used if CellValueType is set in GridQueryCellInfo
				//	this._extData[e.RowIndex - 1, e.ColIndex - 1] = (int)e.Style.CellValue;
				}
			}
			catch{}

			//refresh this row so change is displayed
			//this.gridControl1.Refresh();
			e.Handled = true;
		}
		#endregion

		#region Required Handlers
		//provide the row count from the datasource
		void GridQueryRowCount(object sender, GridRowColCountEventArgs e) 
		{
			e.Count = this._extData.RowCount;
			e.Handled = true;
		}


		//provide the column count from the datasource
		void GridQueryColCount(object sender, GridRowColCountEventArgs e) 
		{
			e.Count = this._extData.ColCount;
			e.Handled = true;
		}


		//provide the data from the datasource
		void GridQueryCellInfo(object sender, GridQueryCellInfoEventArgs e) 
		{
			if (e.RowIndex > 0 && e.ColIndex > 0)
			{
				e.Style.CellValue = this._extData[e.RowIndex - 1, e.ColIndex - 1];

				//setting the CellValueType property allows you to cast the CellValue
				//as opposed to converting it...
				//		e.Style.CellValueType = typeof(int);//commented

				if(this._extData[e.RowIndex - 1, e.ColIndex - 1] % 3 == 0)
					e.Style.BackColor = Color.FromArgb( 0xff, 0xbf, 0x34 );				
				e.Handled = true;
			}
		}

		#endregion

		#region Optional Handlers
		//provide the row heights on demand - optional...
		void GridQueryRowHeight(object sender, GridRowColSizeEventArgs e)
		{
			if( e.Index % 2 == 0)
			{
				e.Size = (int)DpiAware.LogicalToDeviceUnits(20.0f);
				e.Handled = true;
			}
		}


		//provide the col widths on demand - optional...
		void GridQueryColWidth(object sender, GridRowColSizeEventArgs e)
		{
			if( e.Index % 3 == 0)
			{
				e.Size = 40;
				e.Handled = true;
			}
		}


		//provide covered range on demand - optional...
		void GridQueryCoveredRange(object sender, GridQueryCoveredRangeEventArgs e) 
		{
			//cover odd rows, columns 1 through 3
			if (e.RowIndex % 2 == 1 && e.ColIndex >= 1 && e.ColIndex <= 3)
			{
				e.Range = GridRangeInfo.Cells(e.RowIndex, 1, e.RowIndex, 3);
				e.Handled = true;
			}

			//cover column 6 with odd-even row pairs
			if (e.RowIndex > 0 && e.ColIndex == 6)
			{
				int row = (e.RowIndex-1) /2 * 2 + 1;
				int col = e.ColIndex;
				e.Range = GridRangeInfo.Cells(row, col, row+1, col);
				e.Handled = true;
			}
		}

		#endregion
        #endregion

    }
}

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

namespace GridControlSort
{
	using System;
	using System.Drawing;
	using System.Collections;
	using System.ComponentModel;
	using System.Windows.Forms;
	using System.Data;
	using System.IO;
	using System.Runtime.Serialization;
	using System.Runtime.Serialization.Formatters.Binary;

	using Syncfusion.Windows.Forms.Grid;
	using Syncfusion.Windows.Forms;
    using DemoCommon.Grid;

	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : GridDemoForm
    {
        #region "API Definition"

        private Syncfusion.Windows.Forms.Grid.GridControl gridControl1;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

        #endregion

        #region "Constructor"
        /// <summary>
        /// Form constructor
        /// </summary>
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
			this.GridSettings();
        }

        #endregion

        #region "Grid Settings"
        /// <summary>
        /// Grid Settings for better look and feel
        /// </summary>
        private void GridSettings()
        {
            this.gridControl1.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro;
            this.gridControl1.GridOfficeScrollBars = OfficeScrollBars.Metro;
            this.gridControl1.Properties.GridLineColor = Color.FromArgb(208, 215, 229);
            this.gridControl1.DefaultGridBorderStyle = Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid;
            gridControl1.ControllerOptions &= ~(GridControllerOptions.OleDataSource | GridControllerOptions.OleDropTarget);
            gridControl1.BaseStylesMap["Header"].StyleInfo.Enabled = false;
            //Used to set default row height
            this.gridControl1.DefaultRowHeight = (int)DpiAware.LogicalToDeviceUnits(22.0f);
            this.gridControl1.Model.Options.DisplayEmptyColumns = true;
            this.gridControl1.Model.Options.DisplayEmptyRows = true;
        }
        #endregion

        #region "Designer Stuffs"

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
            this.gridControl1 = new Syncfusion.Windows.Forms.Grid.GridControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
			this.gridControl1.DpiAware = true;
			this.gridControl1.AllowDrop = true;
			this.gridControl1.Dock = DockStyle.Fill;
            this.gridControl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gridControl1.HorizontalThumbTrack = true;
            this.gridControl1.Location = new System.Drawing.Point(12, 12);
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RowCount = 100;
            this.gridControl1.Size = new System.Drawing.Size(862, 629);
            this.gridControl1.SmartSizeBox = false;
            this.gridControl1.TabIndex = 0;
            this.gridControl1.Text = "gridControl1";
            this.gridControl1.ThemesEnabled = true;
            this.gridControl1.VerticalThumbTrack = true;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(888, 653);
            this.Controls.Add(this.gridControl1);
            this.MinimumSize = new System.Drawing.Size(500, 400);
            this.Name = "Form1";
            this.Text = "Sorting ";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
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

        #region "Event Handler"

        private void Form1_Load(object sender, System.EventArgs e)
        {
            PopulateTheGrid();

            //turn off column selections - not absolutely needed but does simplify things
            this.gridControl1.AllowSelection = GridSelectionFlags.Any & ~GridSelectionFlags.Column;

            //add a sort header to the CellModels... (in 1.0, only available by default in GridDataBoundGrid)
            this.gridControl1.CellModels.Add("ColumnHeaderCell", new GridSortColumnHeaderCellModel(this.gridControl1.Model));

            //catch the click
            this.gridControl1.CellClick += new GridCellClickEventHandler(HandleAClick);
        }
        private void HandleAClick(object sender, GridCellClickEventArgs e)
        {
            if (e.MouseEventArgs.Button == MouseButtons.Left
                    && e.RowIndex == 0 && e.ColIndex > 0)
            {
                SortCol(e.ColIndex);
            }

        }
#endregion

        #region "Helper Methods"

        private void PopulateTheGrid()
		{
			Random r = new Random();
			this.gridControl1.CommandStack.Enabled = false;
			this.gridControl1.BeginUpdate();
			for (int row = 1; row <= this.gridControl1.RowCount; ++row)
			{
				for(int col = 1; col <= this.gridControl1.ColCount; ++col)
				{
					if(col == 2) //datetime col
					{
						DateTime dt = new DateTime(r.Next(50) + 1960, r.Next(11) + 1, r.Next(27) + 1);
						this.gridControl1[row, col].CellValue = dt;
					}
					else if (col == 4 || col == 5) //formula col and text col
					{
						if(col == 5)
							this.gridControl1[row, col].CellValue = RandomString(r);
					}
					else if (col == 6) //float
					{
						this.gridControl1[row, col].CellValue = ((r.Next(2) == 0) ? 1 : - 1) * ((float) r.Next(100000))/ 200;
					}
					else if(col == 3) //int count col
						this.gridControl1[row, col].CellValue = row;
					else //int
						this.gridControl1[row, col].CellValue = ((r.Next(2) == 0) ? 1 : - 1) * r.Next(1000);
				}
			}

			this.gridControl1.DefaultColWidth = (int)DpiAware.LogicalToDeviceUnits(50.0f);
			//this.gridControl1.TableStyle.HorizontalAlignment = GridHorizontalAlignment.Center;

			//column 2 is a date column
			this.gridControl1.ColStyles[2].CellValueType = typeof(DateTime);
			this.gridControl1.ColStyles[2].Format = "dd MMM yyyy";
			this.gridControl1.ColWidths[2] = (int)DpiAware.LogicalToDeviceUnits(100.0f); 
			this.gridControl1[0, 2].Text = "Date";

			//column 4 is formula col which used relative notation (row = 0)
			//to enter the formulas as a simgle string as the default value
			//in the column
			this.gridControl1.ColWidths[4] = (int)DpiAware.LogicalToDeviceUnits(100.0f);
			this.gridControl1[0, 4].Text = "FormulaCell";
			this.gridControl1.ColStyles[4].CellType = "FormulaCell";
			this.gridControl1.ColStyles[4].Text = "= A0 + C0"; //row = 0 means use current row
			
			//col 6 is a text column
			this.gridControl1.ColWidths[5] = (int)DpiAware.LogicalToDeviceUnits(100.0f);
			this.gridControl1[0, 5].Text = "Text";

			//column 6 is a float column
			this.gridControl1.ColStyles[6].CellValueType = typeof(float);
			this.gridControl1.ColStyles[6].Format = "####.##";
			this.gridControl1.ColWidths[6] = (int)DpiAware.LogicalToDeviceUnits(100.0f);
			this.gridControl1[0, 6].Text = "floats";

			//force the entire column to be computed, not just the visible cells
			//so if sort is done on formula column, all cells will have been computed.
			GridFormulaEngine engine = ((GridFormulaCellModel)this.gridControl1.CellModels["FormulaCell"]).Engine;
			engine.RecalculateRange(GridRangeInfo.Col(4), true, true);

			this.gridControl1.ColStyles[1].BackColor = Color.White;
			this.gridControl1.ColStyles[2].BackColor = Color.FromArgb( 237, 240, 246 );
			this.gridControl1.ColStyles[3].BackColor = Color.FromArgb( 218, 229, 245 );
			this.gridControl1.ColStyles[4].BackColor = Color.FromArgb( 218, 229, 245 );
			this.gridControl1.ColStyles[5].BackColor = Color.FromArgb( 102, 110, 152 );
			this.gridControl1.ColStyles[5].TextColor = Color.White;			
			this.gridControl1.ColStyles[6].BackColor = Color.FromArgb( 252, 172, 38 );
			this.gridControl1.ColStyles[7].BackColor = Color.FromArgb( 255, 153, 51 );
			this.gridControl1.ColStyles[8].BackColor =  Color.FromArgb( 238, 122, 3 );
			this.gridControl1.ColStyles[9].BackColor =  Color.FromArgb( 238, 122, 3 );
			this.gridControl1.ColStyles[10].BackColor =  Color.FromArgb( 0xde, 0x64, 0x13 );
			this.gridControl1.ColStyles[10].TextColor = Color.White;
            
			this.gridControl1.DefaultRowHeight = (int)DpiAware.LogicalToDeviceUnits(18.0f);
			this.gridControl1.DefaultColWidth = (int)DpiAware.LogicalToDeviceUnits(70.0f);
			this.gridControl1.Properties.GridLineColor = System.Drawing.Color.Silver;
			this.gridControl1.DefaultGridBorderStyle = GridBorderStyle.Solid;	
			
			this.gridControl1.EndUpdate();
			this.gridControl1.Refresh();
		}

		
        public void SortCol(int col)
        {
            if (this.gridControl1.CurrentCell.IsEditing)
                this.gridControl1.CurrentCell.EndEdit();

            GridStyleInfo style = new GridStyleInfo();
            style.Tag = "";

            //turn off the old sort arrow
            for (int col1 = 1; col1 <= this.gridControl1.ColCount; ++col1)
                if (col1 != col && this.gridControl1[0, col1].CellType == "ColumnHeaderCell")
                {
                    this.gridControl1[0, col1].CellType = "Header";
                    break;
                }

            //turn on new sort arrow
            this.gridControl1[0, col].CellType = "ColumnHeaderCell";

            ListSortDirection dir = ListSortDirection.Ascending;
            if (this.gridControl1[0, col].HasTag)
            {
                if ((ListSortDirection)this.gridControl1[0, col].Tag == ListSortDirection.Ascending)
                    dir = ListSortDirection.Descending;
            }

            this.gridControl1[0, col].Tag = dir;
            if (col == 4) //formulacell
            {
                //need to use custom comparer to get at the 
                //formula computed value instead of the formul itself.
                this.gridControl1.Data.SortByColumn(col, dir, new FormulaComparer());
            }
            else
            {
                this.gridControl1.Data.SortByColumn(col, dir);
            }
            GridFormulaEngine engine = ((GridFormulaCellModel)this.gridControl1.CellModels["FormulaCell"]).Engine;
            engine.RecalculateRange(GridRangeInfo.Col(4), true, true);
            this.gridControl1.Refresh();
        }

        private string RandomString(Random r)
        {
            int len = r.Next(12) + 1;
            System.Text.StringBuilder sb = new System.Text.StringBuilder(len);

            for (int i = 0; i < len; ++i)
                sb.Append((char)(r.Next(26) + 65));

            return sb.ToString();

        }

        #endregion
    }

	#region "Custom Comparer Class for formula cells"

	//custom comparer to sort on formula value and not the formula.
	public class FormulaComparer : IComparer
	{
		#region Implementation of IComparer
		public int Compare(object x, object y)
		{
			int c = 0;

			if(x == null && y == null)
			{
				//c = 0;
			}
			else if(x == null)
			{
				c = -1;
			}
			else if(y == null)
			{
				c = 1;
			}
			else
			{
				//the idea is to get at the FormulaTag object in the GridStyleInfoStore passed in
				//and use the FormulaTag.Text property to compare two cells.
				GridStyleInfo xStyle = new GridStyleInfo((GridStyleInfoStore) x);
				GridStyleInfo yStyle = new GridStyleInfo((GridStyleInfoStore) y);
				string xs = (xStyle.FormulaTag != null) ? xStyle.FormulaTag.Text : "";
				string ys = (yStyle.FormulaTag != null) ? yStyle.FormulaTag.Text : "";
				double xd = 0;
				double yd = 0;
				double.TryParse(xs, System.Globalization.NumberStyles.Any, null, out xd);
				double.TryParse(ys, System.Globalization.NumberStyles.Any, null, out yd);
				c = xd.CompareTo(yd);
			}
			return c;
		}
		#endregion
	}
	
	#endregion
	
}

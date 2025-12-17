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
using System.Threading;

using Syncfusion.Windows.Forms.Grid;
using Syncfusion.Styles;
using Syncfusion.Drawing;
using Syncfusion.ComponentModel;
using Syncfusion.Windows.Forms;
using DemoCommon.Grid;

namespace RefreshGrid
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : GridDemoForm
	{
        #region "API Definitions"
        /// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;
		private PerformanceGrid grid;
		private Model model;
		private System.Windows.Forms.Timer timer;
		private bool transpose = false;

		bool useGDI;
		bool usePrepareViewStyleInfo;
		bool showHeaders;
		bool drawBorder;
		int iterationsPerUpdate;
		int timerInterval;
		int sleep;
		bool useDoubleBuffer;
		private System.Windows.Forms.StatusBar statusBar1;
		private System.Windows.Forms.StatusBarPanel refreshCountPanel;
		private System.Windows.Forms.StatusBarPanel tickCountPanel;
		private System.Windows.Forms.StatusBarPanel averageTicksPanel;
		bool optimizeDrawBackground;
		int insertRemoveInterval;
        int clientHeight;
        #endregion

        #region "Constructor"
        public Form1()
        {
            #region private members
            // adjust behavior of performance sanoke with the following properties
			useGDI = true;
			usePrepareViewStyleInfo = false;
			showHeaders = true;
			drawBorder = true;
			useDoubleBuffer = false;
			optimizeDrawBackground = true; 
			iterationsPerUpdate = 3;
			insertRemoveInterval = 1;
			timerInterval = 20;
			sleep = 0;
			
			useDoubleBuffer |= !useGDI;
            #endregion

            //
			// Required for Windows Form Designer support
			//
			InitializeComponent();
			if(DpiAware.GetCurrentDpi() > 96)
			{
				this.CaptionBarHeight = (int)DpiAware.LogicalToDeviceUnits(this.CaptionBarHeight);
			}
            try
            {
                System.Drawing.Icon ico = new System.Drawing.Icon(GetIconFile(@"Common\Images\Grid\Icon\sficon.ico"));
                this.Icon = ico;
            }
            catch { }
            this.MetroColor = System.Drawing.Color.Transparent;

            #region Grid Control's properties
            this.grid = new PerformanceGrid();
			this.grid.Model.UseGridNonVirtualDataCache = true;
			this.grid.UseGDI = useGDI;
			this.grid.UseDoubleBuffer = useDoubleBuffer;
			this.grid.OptimizeDrawBackground = optimizeDrawBackground;
			this.grid.OptimizeInsertRemoveCells = true;
			GridStyleInfo.Default.Trimming = StringTrimming.None; // Default is StringTrimming.Char which forces
			// GridGDIPaint.DrawText to use NativeMethods.DrawText instead of NativeMethods.ExtTextOut

			// PrepareViewStyleInfo lets you modify a temporary copy of style objects, and change
			// appearance without saving changes to volatile data cache. However, this is a bit
			// slower than modifying contents directly.
			this.grid.SupportsPrepareViewStyleInfo = usePrepareViewStyleInfo;
            
            this.grid.Model[0, 0].Text = " ";

			if (usePrepareViewStyleInfo)
				grid.PrepareViewStyleInfo += new GridPrepareViewStyleInfoEventHandler(grid_PrepareViewStyleInfo);

			if (drawBorder)
			{
				// Use solid line - faster than dotted line
				grid.Model.TableStyle.Borders.Bottom = new GridBorder(GridBorderStyle.Solid, SystemColors.Control, GridBorderWeight.Thin);
				grid.Model.TableStyle.Borders.Right = new GridBorder(GridBorderStyle.Solid, SystemColors.Control, GridBorderWeight.Thin);
			}
			else
				// No border at all is of course faster.
				grid.Model.TableStyle.Borders.All = GridBorder.Empty;//new GridBorder(GridBorderStyle.Dotted, SystemColors.ControlLight, GridBorderWeight.Thin);//GridBorder.Empty;

			if (!showHeaders)
			{
				grid.Model.HideRows[0] = true;
				grid.Model.HideCols[0] = true;
			}

			highlightColumn = -3;
			#endregion

			#region Generic properties
			this.grid.DpiAware = true;
            this.grid.Anchor = AnchorStyles.Top|AnchorStyles.Bottom|AnchorStyles.Left|AnchorStyles.Right;
			Size clientSize = this.ClientSize;
			clientSize.Height -= statusBar1.Height;
            this.grid.Location = new Point(this.Location.X + 10, this.Location.Y + 10);
            clientHeight = 14 * this.grid.DefaultRowHeight;
            this.grid.Size = new Size(this.Size.Width - 30, clientHeight);
            this.Size = new Size(this.Size.Width, this.grid.Size.Height + this.statusBar1.Height+75);
			this.grid.HScrollPixel = true;
			this.grid.VScrollPixel = true;
			this.grid.HorizontalThumbTrack = true;
			this.grid.VerticalThumbTrack = true;
			this.grid.TableStyle.Enabled = false;
			grid.Model.Options.NumberedRowHeaders = false;
			grid.Model.Options.NumberedColHeaders = false;
			this.Controls.Add(this.grid);
            this.model = new Model(10, 10);
            GridStyleInfo style = grid.BaseStylesMap["Header"].StyleInfo;
            style.TextColor = Color.MidnightBlue;
            style.Font.Facename = "Verdana";
            style.Borders.All = new GridBorder(GridBorderStyle.Solid, Color.LightGray, GridBorderWeight.Thin);

			SynchronizeModel();
            this.grid.ThemesEnabled = true;
            this.grid.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro;
            grid.Refresh();

            #endregion

            #region Timer

            this.timer = new System.Windows.Forms.Timer();
			this.timer.Interval = timerInterval;
			this.timer.Tick += new EventHandler(this.OnUpdate);
			this.timer.Start();

            #endregion

        }
        #endregion


        #region HelperMethods
        int total = 0;
		int count = 0;
		int valueCounter = 0;
		int highlightColumn = 0;
		int countInBatch = 0;

        void SynchronizeModel()
		{
			grid.Model.RowCount = this.model.Rows;  
			grid.Model.ColCount = this.model.Cols;  
			for (int col = 0; col < model.Cols; col++)
			{
				Color backColor = SystemColors.Window;
				if (Math.Abs(col - this.highlightColumn) < 2)
					backColor = Color.Red;
				BrushInfo interior = new BrushInfo(backColor);

				for (int row = 0; row < model.Rows; row++)
				{
					if(this.transpose)
					{
						grid.Model[row+1, col+1].CellValue = valueCounter + model[row, col];
					}
					else
					{
						grid.Model[row+1, col+1].CellValue = valueCounter + model[col, row];
					}
					grid.Model[row+1, col+1].Interior = interior;
				}
			}
			valueCounter = valueCounter+1;
			if (valueCounter > 10000)
				Application.Exit();
        }
        #endregion

        #region Event Handlers
        int updateCount = 0;

		private void OnUpdate(object sender, EventArgs args)
		{
			bool allocateIro = true;
			updateCount++;
			int t = Environment.TickCount;
			int n;
			
			// Changing cells 
			for (n = 0; n < iterationsPerUpdate; n++)
			{
				highlightColumn = (highlightColumn+1) % (grid.Model.ColCount+1);
				this.transpose = !this.transpose;
				SynchronizeModel(); 
				this.grid.InvalidateRange(grid.ViewLayout.VisibleCellsRange);
				this.grid.Update();
				count++;
				countInBatch++;
				if (sleep > 0)
					Thread.Sleep(sleep);
			}

			if (insertRemoveInterval > 0 && updateCount % insertRemoveInterval == 0)
			{
				int rows = grid.Model.RowCount / 3;
	
				// Inserting a row
				for (n = 0; n < rows; n++)
				{
					if (allocateIro)
					{
						GridModelInsertRangeOptions iro = new GridModelInsertRangeOptions();
						iro.Data = new GridStyleInfoStoreTable(1, grid.Model.ColCount+1);
						iro.RowColSizes = new int[] { grid.Model.Rows.DefaultSize };
						iro.RowColHide = new bool[] { false };
						for (int c = 1; c <= grid.Model.ColCount; c++)
						{
							iro.Data[0, c] = new GridStyleInfoStore();
							iro.Data[0, c].SetValue(GridStyleInfoStore.CellValueProperty, n+1);
						}
						grid.Model.Rows.InsertRange(1, 1, iro);
					}
					else
					{
						// Not much performance diff between GridModelInsertRangeOptions and modifying values directly,
						grid.BeginUpdate(Syncfusion.Windows.Forms.BeginUpdateOptions.InvalidateAndScroll);
						grid.Model.Rows.InsertRange(1, 1);
						for (int c = 1; c <= grid.Model.ColCount; c++)
							grid.Model[1, c].CellValue = n+1;
						grid.EndUpdate(true);
					}
					count++;
					countInBatch++;
					this.grid.Update();
					if (sleep > 0)
						Thread.Sleep(sleep);
				}

				int cols = grid.Model.ColCount / 3;
	
				// Inserting columns
				for (n = 0; n < cols; n++)
				{
					if (allocateIro)
					{
						GridModelInsertRangeOptions iro = new GridModelInsertRangeOptions();
						iro.Data = new GridStyleInfoStoreTable(grid.Model.RowCount+1, 1);
						iro.RowColSizes = new int[] { grid.Model.Cols.DefaultSize };
						iro.RowColHide = new bool[] { false };
						for (int r = 1; r <= grid.Model.RowCount; r++)
						{
							iro.Data[r, 0] = new GridStyleInfoStore();
							iro.Data[r, 0].SetValue(GridStyleInfoStore.CellValueProperty, n+1);
						}
						grid.Model.Cols.InsertRange(1, 1, iro);
					}
					else
					{
						// Not much performance diff between GridModelInsertRangeOptions and modifying values directly,
						grid.BeginUpdate(Syncfusion.Windows.Forms.BeginUpdateOptions.InvalidateAndScroll);
						grid.Model.Cols.InsertRange(1, 1);
						for (int r = 1; r <= grid.Model.RowCount; r++)
							grid.Model[r, 1].CellValue = n+1;
						grid.EndUpdate(true);
					}
					this.grid.Update();
					if (sleep > 0)
						Thread.Sleep(sleep);
					count++;
					countInBatch++;
				}

				// Removing columns
				for (n = 0; n < cols; n++)
				{
					grid.Model.Cols.RemoveRange(1, 1);
					this.grid.Update();
					if (sleep > 0)
						Thread.Sleep(sleep);
					count++;
					countInBatch++;
				}

				
				// Removing a row
				for (n = 0; n < rows; n++)
				{
					grid.Model.Rows.RemoveRange(1, 1);
					this.grid.Update();
					if (sleep > 0)
						Thread.Sleep(sleep);
					count++;
					countInBatch++;
				}



			}

			int ticks = Environment.TickCount-t;
			total += ticks;

			if (updateCount % 5 == 0)
			{
				float avg = (total*1.0f/countInBatch-sleep);
				this.refreshCountPanel.Text = "Refresh Count = " + count.ToString();				
				this.averageTicksPanel.Text = "Average Ticks = " + avg.ToString();

				
				if (Math.Abs((int) avg + 10 - this.timer.Interval) > 25)
					this.timer.Interval = Math.Max((int) avg + 10, this.timerInterval);

				total = 0;
				countInBatch = 0;
			}
		}

        private void grid_PrepareViewStyleInfo(object sender, GridPrepareViewStyleInfoEventArgs e)
        {
            // Highlight columns
            if (Math.Abs(e.ColIndex - this.highlightColumn) < 2 && e.ColIndex != e.RowIndex)
                e.Style.BackColor = Color.Red;
        }
        #endregion

        #region "Desginer Stuffs"

        #region "Dispose"
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
        #endregion

        #region Windows Form Designer generated code
        /// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.statusBar1 = new System.Windows.Forms.StatusBar();
            this.refreshCountPanel = new System.Windows.Forms.StatusBarPanel();
            this.tickCountPanel = new System.Windows.Forms.StatusBarPanel();
            this.averageTicksPanel = new System.Windows.Forms.StatusBarPanel();
            ((System.ComponentModel.ISupportInitialize)(this.refreshCountPanel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tickCountPanel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.averageTicksPanel)).BeginInit();
            this.SuspendLayout();
            // 
            // statusBar1
            // 
            this.statusBar1.Location = new System.Drawing.Point(0, 634);
            this.statusBar1.Name = "statusBar1";
            this.statusBar1.Panels.AddRange(new System.Windows.Forms.StatusBarPanel[] {
            this.refreshCountPanel,
            this.tickCountPanel,
            this.averageTicksPanel});
            this.statusBar1.ShowPanels = true;
            this.statusBar1.Size = new System.Drawing.Size(1012, 22);
            this.statusBar1.TabIndex = 0;
            // 
            // refreshCountPanel
            // 
            this.refreshCountPanel.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Spring;
            this.refreshCountPanel.Name = "refreshCountPanel";
            this.refreshCountPanel.Width = 331;
            // 
            // tickCountPanel
            // 
            this.tickCountPanel.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.tickCountPanel.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Spring;
            this.tickCountPanel.Name = "tickCountPanel";
            this.tickCountPanel.Width = 331;
            // 
            // averageTicksPanel
            // 
            this.averageTicksPanel.Alignment = System.Windows.Forms.HorizontalAlignment.Right;
            this.averageTicksPanel.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Spring;
            this.averageTicksPanel.Name = "averageTicksPanel";
            this.averageTicksPanel.Text = "statusBarPanel1";
            this.averageTicksPanel.Width = 331;
			// 
			// Form1
			// 
			this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.BorderThickness = 2;
            this.CaptionAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.CaptionFont = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CaptionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.ClientSize = new System.Drawing.Size(1012, 656);
            this.Controls.Add(this.statusBar1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.MinimumSize = new System.Drawing.Size(500, 400);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Refresh Grid ";
            ((System.ComponentModel.ISupportInitialize)(this.refreshCountPanel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tickCountPanel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.averageTicksPanel)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
        {
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense(DemoCommon.FindLicenseKey());
# if SyncfusionFramework1_1 || SyncfusionFramework2_0  
			Application.EnableVisualStyles();
# endif
			Application.Run(new Form1());
		}

        #region "GetIconFile"
        private string GetIconFile(string bitmapName)
        {
            for (int n = 0; n < 10; n++)
            {
                if (System.IO.File.Exists(bitmapName))
                    return bitmapName;

                bitmapName = @"..\" + bitmapName;
            }

            return bitmapName;
        }
        #endregion

        #endregion
    }

    /// <summary>
    /// Represents a class that is used to find the licensing file for Syncfusion controls.
    /// </summary>
    public class DemoCommon
    {

        /// <summary>
        /// Finds the license key from the Common folder.
        /// </summary>
        /// <returns>Returns the license key.</returns>
        public static string FindLicenseKey()
        {
            string licenseKeyFile = "..\\Common\\SyncfusionLicense.txt";
            for (int n = 0; n < 20; n++)
            {
                if (!System.IO.File.Exists(licenseKeyFile))
                {
                    licenseKeyFile = @"..\" + licenseKeyFile;
                    continue;
                }
                return System.IO.File.ReadAllText(licenseKeyFile);
            }
            return string.Empty;
        }
    }
}

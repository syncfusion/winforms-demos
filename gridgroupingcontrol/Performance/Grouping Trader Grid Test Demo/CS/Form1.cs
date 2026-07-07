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
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using System.Data;
using Syncfusion.Windows.Forms.Grid;
using Syncfusion.Windows.Forms.Grid.Grouping;
using Syncfusion.Grouping;
using Syncfusion.Windows.Forms;
using DemoCommon.Grid;

namespace TraderGridTest
{

	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : GridDemoForm
    {
        #region API Definition
        private IContainer components;
		internal Timer timer;
		private DataTable table;
		private GridGroupingControl gridGroupingControl1;
		private System.Random rand;
		private int m_numUpdatesPerTick = 10;
		DataSet ds;

		private int toggleInsertRemove = 10;// toggle between inserting and removing after n inserts/n removals.
		private int insertRemoveModulus = 5; // frequency of insert / remove : every n timer ticks
		int initialRowCount = 100;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label1;
		private Syncfusion.Windows.Forms.Tools.CheckBoxAdv checkBoxFilter;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt textBoxFilter;
        private Syncfusion.Windows.Forms.Tools.CheckBoxAdv checkBoxGrouping;
		private Syncfusion.Windows.Forms.ButtonAdv buttonApplyFilter;
		private System.Windows.Forms.Label labelTimerInterval;
		private System.Windows.Forms.TrackBar trackBarTimer;
        private Syncfusion.Windows.Forms.Tools.CheckBoxAdv checkBoxSorting;
        private Syncfusion.Windows.Forms.Tools.CheckBoxAdv checkBoxColor;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TrackBar trackBarBlinkFrequency;
		private System.Windows.Forms.Label labelBlinkTime;
        private Panel panel2;
        private Panel panel3;
        private PropertyGrid propertyGrid1;
        int icount = 0;
        int timerCount = 0;
        int ti = 0;
        bool shouldInsert = false;
        bool waitKey = false;
        bool skipTimer = false;
		// Alter this integer to change the type of test
		int insertRemoveCount = 2;                      // use 1 if you want to check out inserting and removing rows
        Color[] colors = new Color[] {
										 
										 Color.FromArgb( 0x85, 0xbf, 0x75 ),
										 
										 Color.FromArgb( 0xb4, 0xe7, 0xf2 ),
										 Color.FromArgb( 0xff, 0xbf, 0x34 ),
										 Color.FromArgb( 0x82, 0x2e, 0x1b ),
										 Color.FromArgb( 0x3a, 0x86, 0x7e ),
		};		
        #endregion

        #region Constructor
        public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();		       		

			// Setup the grid
			gridGroupingControl1 = new GridGroupingControl();
			gridGroupingControl1.VerticalThumbTrack = true;
			gridGroupingControl1.HorizontalThumbTrack = true;
			gridGroupingControl1.TableOptions.VerticalPixelScroll = true;			
            gridGroupingControl1.Dock = DockStyle.Fill;
            
            
			this.panel2.Controls.Add(gridGroupingControl1);
			this.gridGroupingControl1.TableControl.DpiAware = true;
            gridGroupingControl1.TableOptions.ListBoxSelectionMode = SelectionMode.MultiExtended;

			OptimizeGrid();
            
			gridGroupingControl1.AllowSwapDataViewWithDataTableList = false; // we want to use "InsertAt" logice with .NET 2.0 ...

			// Setup datatable with random data
			InitializeDataTable();
			gridGroupingControl1.DataSource = table;

			// Highlight up and downticks
			gridGroupingControl1.BlinkTime = 700;  // in ms
			for (int i = 1; i <= 20; i++)
				gridGroupingControl1.TableDescriptor.Columns[i.ToString()].AllowBlink = true;

			gridGroupingControl1.Engine.AddBaseStylesForBlinking();

			
			gridGroupingControl1.BaseStyles[GridEngine.BlinkIncreased].StyleInfo.TextColor = Color.White;

			
			gridGroupingControl1.BaseStyles[GridEngine.BlinkReduced].StyleInfo.TextColor = Color.White;

			gridGroupingControl1.Engine.BaseStyles.Add("CustomStyle");
			
			gridGroupingControl1.BaseStyles["CustomStyle"].StyleInfo.TextColor = Color.Black;
			gridGroupingControl1.BaseStyles["CustomStyle"].StyleInfo.BackColor = Color.White;

			this.gridGroupingControl1.TableControlPrepareViewStyleInfo += new GridTableControlPrepareViewStyleInfoEventHandler(gridGroupingControl1_TableControlPrepareViewStyleInfo);

			gridGroupingControl1.TableDescriptor.Columns[0].MaxLength = 8;
			gridGroupingControl1.TableDescriptor.Columns[5].MaxLength = 6;
			gridGroupingControl1.TableDescriptor.Columns[9].MaxLength = 5;
			gridGroupingControl1.TableDescriptor.Columns[14].MaxLength = 6;
			gridGroupingControl1.TableDescriptor.Columns["1"].MaxLength = 8;

			// Sort by column "1"
			gridGroupingControl1.TableDescriptor.SortedColumns.Add("1");

			//Optional: Filter records
			//gridGroupingControl1.TableDescriptor.RecordFilters.Add("[2] > 88");

			Console.WriteLine(gridGroupingControl1.TableDescriptor.Columns["1"].MaxLength);

			this.textBoxFilter.Text = "[2] > 88";
            this.gridGroupingControl1.PropertyChanged += new DescriptorPropertyChangedEventHandler(gridGroupingControl1_PropertyChanged);
			this.gridGroupingControl1.ShowGroupDropArea = true;

          

			// Timer
			SetupTimer();
            this.gridGroupingControl1.TableOptions.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Office2007Blue;
            this.gridGroupingControl1.TableOptions.GridLineBorder = new Syncfusion.Windows.Forms.Grid.GridBorder(GridBorderStyle.Solid, Color.FromArgb(208, 215, 229), GridBorderWeight.Thin);
            this.gridGroupingControl1.TopLevelGroupOptions.ShowAddNewRecordBeforeDetails = false;
            this.gridGroupingControl1.TopLevelGroupOptions.ShowCaption = false;
            gridGroupingControl1.Appearance.AnyCell.Font.Facename = "Segoe UI";            
            this.BackColor = Color.White;
            this.propertyGrid1.BackColor=Color.White;            
		}
        #endregion        

        #region Grid Optimization
        /// <summary>
        /// Optimizing the grid for better performance
        /// </summary>
        private void OptimizeGrid()
		{
			// Optimize memory footprint, drawing and ListChanged performance

			// Use less memory for internal binary tree structures
			gridGroupingControl1.CounterLogic = EngineCounters.YAmount;
			gridGroupingControl1.AllowedOptimizations = EngineOptimizations.DisableCounters | EngineOptimizations.RecordsAsDisplayElements;

			// Affected settings by UseDefaultsForFasterDrawing are: InvalidateAllWhenListChanged, 
			// TableOptions.ColumnsMaxLengthStrategy, TableOptions.GridLineBorder, 
			// TableOptions.DrawTextWithGdiInterop, TableOptions.VerticalPixelScroll,
			// Appearance.AnyRecordFieldCell.WrapText and Appearance.AnyRecordFieldCell.Trimming.
			gridGroupingControl1.UseDefaultsForFasterDrawing = true;

			// Instruct grouping control not to access datasource through
			// CurrencyManager API and instead access list diretly. When set to
			// false you wil however loose support for built-in CurrencyManager 
			// synchronization, so only do this if you don't need CurrencyManager synchronization.
			gridGroupingControl1.BindToCurrencyManager = false;

			// Update display with changes, optionally use ScrollWindow for insert and removing rows.
			//gridGroupingControl1.UpdateDisplayFrequency = 0;  // only manual updates (when you call grid.Update)
			gridGroupingControl1.UpdateDisplayFrequency = 1;  // immediate update after each ListChanged.
			//gridGroupingControl1.UpdateDisplayFrequency = 100;  // update every 100 ms.
			gridGroupingControl1.InsertRemoveBehavior = GridListChangedInsertRemoveBehavior.ScrollWithImmediateUpdate;  // Scrollwindow will cause immediate update.
			gridGroupingControl1.SortPositionChangedBehavior = GridListChangedInsertRemoveBehavior.ScrollWithImmediateUpdate;  // Scrollwindow will cause immediate update.

			// Don't forget this property. If it is true then InsertRemoveBehavior and SortPositionChangedBehavior
			// properties would have no effect at all. Its default value is false if UseDefaultsForFasterDrawing = true
			// has been set, but setting it explictly makes sure this is false.
			gridGroupingControl1.InvalidateAllWhenListChanged = false;
            gridGroupingControl1.TableControl.EnableDoubleBufferSurface();
		}
        #endregion

        #region Timer
        /// <summary>
        /// Setting the timer for Real time update
        /// </summary>
        private void SetupTimer()
		{
			timer = new Timer();
			timer.Tick += new EventHandler(timer_Tick);
			timer.Interval = 100;
			timer.Start();

			this.UpdateDialog();

			this.gridGroupingControl1.Focus();
		}
        #endregion

        #region DataTable
        /// <summary>
        /// Populating the data to grid
        /// </summary>
        void InitializeDataTable()
		{
            ds = new DataSet();
			table = new DataTable("RandomData");
			table.Columns.Add("Product", typeof(string));
			table.Columns.Add("1", typeof(System.Double));
			table.Columns.Add("2", typeof(System.Double));
			table.Columns.Add("3", typeof(System.Double));
			table.Columns.Add("4", typeof(System.Double));
			table.Columns.Add("5", typeof(System.Double));
			table.Columns.Add("6", typeof(System.Double));
			table.Columns.Add("7", typeof(System.Double));
			table.Columns.Add("8", typeof(System.Double));
			table.Columns.Add("9", typeof(System.Double));
			table.Columns.Add("10", typeof(System.Double));
			table.Columns.Add("11", typeof(System.Double));
			table.Columns.Add("12", typeof(System.Double));
			table.Columns.Add("13", typeof(System.Double));
			table.Columns.Add("14", typeof(System.Double));
			table.Columns.Add("15", typeof(System.Double));
			table.Columns.Add("16", typeof(System.Double));
			table.Columns.Add("17", typeof(System.Double));
			table.Columns.Add("18", typeof(System.Double));
			table.Columns.Add("19", typeof(System.Double));
			table.Columns.Add("20", typeof(System.Double));
            table.Columns.Add("21", typeof(System.Double));
            table.Columns.Add("22", typeof(System.Double));
            table.Columns.Add("23", typeof(System.Double));
            table.Columns.Add("24", typeof(System.Double));
            table.Columns.Add("25", typeof(System.Double));
            table.Columns.Add("26", typeof(System.Double));
            ds.Tables.Add(table);

			rand = new Random(0);

			for (int i = 0; i < initialRowCount; i++)
			{
				int next = rand.Next(100);
				table.Rows.Add(new object[]{"P" + i.ToString("00000"), next+1,next+2,
											   next+3,next+4,next+5,next+6,
											   next+7,next+8,next+9,next+10,
											   next+11,next+12,next+13,next+14,
											   next+15,next+16,next+17,
											   next+18,next+19,next+20,next+21,next+22,next+23,next+24,next+25,next+26});
			}

		}
        #endregion

        #region Events
        void gridGroupingControl1_TableControlPrepareViewStyleInfo(object sender, GridTableControlPrepareViewStyleInfoEventArgs e)
        {
            GridTableCellStyleInfo style = (GridTableCellStyleInfo)e.Inner.Style;
            BlinkState bs = gridGroupingControl1.GetBlinkState(style.TableCellIdentity);

            if (bs != BlinkState.None)
            {
                if (bs == BlinkState.NewRecord)
                {
                    e.Inner.Style.BaseStyle = "CustomStyle";

                }
            }
        }
        void gridGroupingControl1_QueryCellStyleInfo(object sender, GridTableCellStyleInfoEventArgs e)
		{
			GridTableCellStyleInfo style = (GridTableCellStyleInfo)e.Style;
			if (e.TableCellIdentity.TableCellType == GridTableCellType.RecordFieldCell
				|| e.TableCellIdentity.TableCellType == GridTableCellType.AlternateRecordFieldCell)
			{
				

				if (e.TableCellIdentity.Column.FieldDescriptor.FieldPropertyType == typeof(string))
					return;

				
			{
				// Get the value from column "1" and color all cells in record based
				// on this value.
				Record r = e.Style.TableCellIdentity.DisplayElement.GetRecord();
				object value = r.GetValue("1");
				int v = Convert.ToInt32(value) % colors.Length;
				e.Style.BackColor = colors[v];
			}

			}
		}
        private void timer_Tick(object sender, EventArgs e)
        {
            if (skipTimer)
                return;

            timerCount++;

            try
            {
                for (int i = 0; i < m_numUpdatesPerTick; i++)
                {
                    //  Application.DoEvents();

                    int recNum = rand.Next(table.Rows.Count - 1);
                    int rowNum = recNum + 1;
                    int col = rand.Next(16) + 1;
                    int colNum = col + 1;
                    DataRow drow = table.Rows[recNum];
                    if (!(drow[col] is DBNull))
                        drow[col] = (int)(Convert.ToDouble(drow[col]) * (rand.Next(50) / 100.0f + 0.8));// rand.Next(100);

                }


                // Insert or remove a row
                if (insertRemoveCount == 0)
                    return;

                if (toggleInsertRemove > 0 && (timerCount % insertRemoveModulus) == 0)
                {
                    icount = ++icount % (toggleInsertRemove * 2);
                    shouldInsert = icount < toggleInsertRemove;

                    if (shouldInsert)
                    {
                        for (int ri = 0; ri < insertRemoveCount; ri++)
                        {
                            int recNum = 5;// rand.Next(table.Rows.Count - 1);

                            int next = rand.Next(100);
                            object[] row = new object[]{"H"+ti.ToString("00000"),next+1,next+2,
														   next+3,next+4,next+5,next+6,
														   next+7,next+8,next+9,next+10,
														   next+11,next+12,next+13,next+14,
														   next+15,next+16,next+17,
														   next+18,next+19,next+20};
                            ti++;
                            DataRow drow = table.NewRow();
                            drow.ItemArray = row;
                            table.Rows.InsertAt(drow, recNum);
                            //table.Rows.Add(drow);

                        }
                    }
                    else
                    {
                        for (int ri = 0; ri < insertRemoveCount; ri++)
                        {
                            int recNum = 5; //rand.Next(m_set.Count - 1);
                            int rowNum = recNum + 1;

                            // Underlying data structure (this could be a datatable or whatever structure
                            // you use behind a virtual grid).

                            if (table.Rows.Count > 10)
                                table.Rows.RemoveAt(recNum);
                        }
                    }
                }

            }
            finally
            {
            }
        }
        private void trackBarTimer_Scroll(object sender, System.EventArgs e)
        {
            if (this.trackBarTimer.Value == 0)
            {
                timer.Enabled = false;
                this.labelTimerInterval.Text = String.Format("Timer disabled.");
            }
            else
            {
                timer.Interval = 1000 / (this.trackBarTimer.Value * trackBarTimer.Value);
                timer.Enabled = true;
                this.labelTimerInterval.Text = String.Format("Every {0} milliseconds.", timer.Interval);
            }
        }
        #endregion       

        #region Designer Stuffs
        /// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonApplyFilter = new Syncfusion.Windows.Forms.ButtonAdv();
            this.checkBoxGrouping = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.textBoxFilter = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.checkBoxFilter = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.labelTimerInterval = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.trackBarTimer = new System.Windows.Forms.TrackBar();
            this.checkBoxSorting = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.checkBoxColor = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.label4 = new System.Windows.Forms.Label();
            this.trackBarBlinkFrequency = new System.Windows.Forms.TrackBar();
            this.labelBlinkTime = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.propertyGrid1 = new System.Windows.Forms.PropertyGrid();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxGrouping)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxFilter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxFilter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTimer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxSorting)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBlinkFrequency)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.buttonApplyFilter);
            this.panel1.Controls.Add(this.checkBoxGrouping);
            this.panel1.Controls.Add(this.textBoxFilter);
            this.panel1.Controls.Add(this.checkBoxFilter);
            this.panel1.Controls.Add(this.labelTimerInterval);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.trackBarTimer);
            this.panel1.Controls.Add(this.checkBoxSorting);
            this.panel1.Controls.Add(this.checkBoxColor);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.trackBarBlinkFrequency);
            this.panel1.Controls.Add(this.labelBlinkTime);
            this.panel1.Location = new System.Drawing.Point(34, 514);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(938, 110);
            this.panel1.TabIndex = 0;
            // 
            // buttonApplyFilter
            // 
            this.buttonApplyFilter.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.buttonApplyFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.buttonApplyFilter.BeforeTouchSize = new System.Drawing.Size(80, 24);
            this.buttonApplyFilter.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.RaisedInner;
            this.buttonApplyFilter.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonApplyFilter.ForeColor = System.Drawing.Color.White;
            this.buttonApplyFilter.IsBackStageButton = false;
            this.buttonApplyFilter.Location = new System.Drawing.Point(524, 35);
            this.buttonApplyFilter.Name = "buttonApplyFilter";
            this.buttonApplyFilter.Size = new System.Drawing.Size(80, 24);
            this.buttonApplyFilter.TabIndex = 8;
            this.buttonApplyFilter.Text = "Apply";
            this.buttonApplyFilter.UseVisualStyle = true;
            this.buttonApplyFilter.Click += new System.EventHandler(this.buttonApplyFilter_Click);
            // 
            // checkBoxGrouping
            // 
            this.checkBoxGrouping.BeforeTouchSize = new System.Drawing.Size(150, 21);
            this.checkBoxGrouping.Border3DStyle = System.Windows.Forms.Border3DStyle.Flat;
            this.checkBoxGrouping.DrawFocusRectangle = false;
            this.checkBoxGrouping.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxGrouping.ForeColor = System.Drawing.Color.DimGray;
            this.checkBoxGrouping.Location = new System.Drawing.Point(418, 65);
            this.checkBoxGrouping.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.checkBoxGrouping.Name = "checkBoxGrouping";
            this.checkBoxGrouping.Size = new System.Drawing.Size(115, 24);
            this.checkBoxGrouping.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.checkBoxGrouping.TabIndex = 7;
            this.checkBoxGrouping.Text = "Enable Grouping";
            this.checkBoxGrouping.ThemesEnabled = false;
            this.checkBoxGrouping.CheckStateChanged += new System.EventHandler(this.checkBoxGrouping_CheckedChanged);
            // 
            // textBoxFilter
            // 
            this.textBoxFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFilter.BeforeTouchSize = new System.Drawing.Size(393, 22);
            this.textBoxFilter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxFilter.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxFilter.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFilter.ForeColor = System.Drawing.Color.DimGray;
            this.textBoxFilter.Location = new System.Drawing.Point(524, 8);
            this.textBoxFilter.Metrocolor = System.Drawing.Color.Empty;
            this.textBoxFilter.Name = "textBoxFilter";
            this.textBoxFilter.Size = new System.Drawing.Size(393, 22);
            this.textBoxFilter.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.textBoxFilter.TabIndex = 6;
            this.textBoxFilter.Text = "textBox1";
            // 
            // checkBoxFilter
            // 
            this.checkBoxFilter.BeforeTouchSize = new System.Drawing.Size(150, 21);
            this.checkBoxFilter.DrawFocusRectangle = false;
            this.checkBoxFilter.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxFilter.ForeColor = System.Drawing.Color.DimGray;
            this.checkBoxFilter.Location = new System.Drawing.Point(418, 8);
            this.checkBoxFilter.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.checkBoxFilter.Name = "checkBoxFilter";
            this.checkBoxFilter.Size = new System.Drawing.Size(100, 24);
            this.checkBoxFilter.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.checkBoxFilter.TabIndex = 5;
            this.checkBoxFilter.Text = "Enable Filter";
            this.checkBoxFilter.ThemesEnabled = false;
            this.checkBoxFilter.CheckStateChanged += new System.EventHandler(this.checkBoxFilter_CheckedChanged);
            // 
            // labelTimerInterval
            // 
            this.labelTimerInterval.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTimerInterval.ForeColor = System.Drawing.Color.DimGray;
            this.labelTimerInterval.Location = new System.Drawing.Point(322, 8);
            this.labelTimerInterval.Name = "labelTimerInterval";
            this.labelTimerInterval.Size = new System.Drawing.Size(112, 40);
            this.labelTimerInterval.TabIndex = 4;
            this.labelTimerInterval.Text = "label2";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(8, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 28);
            this.label1.TabIndex = 3;
            this.label1.Text = "Timer Frequency";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // trackBarTimer
            // 
            this.trackBarTimer.Location = new System.Drawing.Point(124, 8);
            this.trackBarTimer.Name = "trackBarTimer";
            this.trackBarTimer.Size = new System.Drawing.Size(184, 45);
            this.trackBarTimer.TabIndex = 2;
            this.trackBarTimer.Scroll += new System.EventHandler(this.trackBarTimer_Scroll);
            // 
            // checkBoxSorting
            // 
            this.checkBoxSorting.BeforeTouchSize = new System.Drawing.Size(150, 21);
            this.checkBoxSorting.DrawFocusRectangle = false;
            this.checkBoxSorting.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxSorting.ForeColor = System.Drawing.Color.DimGray;
            this.checkBoxSorting.Location = new System.Drawing.Point(536, 65);
            this.checkBoxSorting.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.checkBoxSorting.Name = "checkBoxSorting";
            this.checkBoxSorting.Size = new System.Drawing.Size(107, 24);
            this.checkBoxSorting.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.checkBoxSorting.TabIndex = 7;
            this.checkBoxSorting.Text = "Enable Sorting";
            this.checkBoxSorting.ThemesEnabled = false;
            this.checkBoxSorting.CheckStateChanged += new System.EventHandler(this.checkBoxSorting_CheckedChanged);
            // 
            // checkBoxColor
            // 
            this.checkBoxColor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxColor.BeforeTouchSize = new System.Drawing.Size(292, 24);
            this.checkBoxColor.DrawFocusRectangle = false;
            this.checkBoxColor.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxColor.ForeColor = System.Drawing.Color.DimGray;
            this.checkBoxColor.Location = new System.Drawing.Point(643, 65);
            this.checkBoxColor.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.checkBoxColor.Name = "checkBoxColor";
            this.checkBoxColor.Size = new System.Drawing.Size(292, 24);
            this.checkBoxColor.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.checkBoxColor.TabIndex = 7;
            this.checkBoxColor.Text = "Enable Coloring";
            this.checkBoxColor.ThemesEnabled = false;
            this.checkBoxColor.CheckStateChanged += new System.EventHandler(this.checkBoxColor_CheckedChanged);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(8, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 31);
            this.label4.TabIndex = 3;
            this.label4.Text = "Blink Frequency";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // trackBarBlinkFrequency
            // 
            this.trackBarBlinkFrequency.Location = new System.Drawing.Point(124, 63);
            this.trackBarBlinkFrequency.Maximum = 20;
            this.trackBarBlinkFrequency.Name = "trackBarBlinkFrequency";
            this.trackBarBlinkFrequency.Size = new System.Drawing.Size(184, 45);
            this.trackBarBlinkFrequency.SmallChange = 2;
            this.trackBarBlinkFrequency.TabIndex = 2;
            this.trackBarBlinkFrequency.TickFrequency = 2;
            this.trackBarBlinkFrequency.Scroll += new System.EventHandler(this.trackBarBlinkFrequency_Scroll);
            // 
            // labelBlinkTime
            // 
            this.labelBlinkTime.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBlinkTime.ForeColor = System.Drawing.Color.DimGray;
            this.labelBlinkTime.Location = new System.Drawing.Point(321, 62);
            this.labelBlinkTime.Name = "labelBlinkTime";
            this.labelBlinkTime.Size = new System.Drawing.Size(91, 40);
            this.labelBlinkTime.TabIndex = 4;
            this.labelBlinkTime.Text = "Disabled.";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(34, 13);
            this.panel2.MinimumSize = new System.Drawing.Size(400, 250);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(676, 478);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.propertyGrid1);
            this.panel3.Location = new System.Drawing.Point(729, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(243, 479);
            this.panel3.TabIndex = 0;
            // 
            // propertyGrid1
            // 
            this.propertyGrid1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.propertyGrid1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.propertyGrid1.HelpBackColor = System.Drawing.Color.White;
            this.propertyGrid1.LineColor = System.Drawing.Color.White;
            this.propertyGrid1.Location = new System.Drawing.Point(0, 3);
            this.propertyGrid1.Name = "propertyGrid1";
            this.propertyGrid1.Size = new System.Drawing.Size(243, 476);
            this.propertyGrid1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1012, 656);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(850, 490);
            this.Name = "Form1";
            this.Text = "Grouping Trader Grid Test";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxGrouping)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxFilter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxFilter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTimer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxSorting)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBlinkFrequency)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

		}
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense(Syncfusion.Licensing.DemoCommon.FindLicenseKey());
            Application.Run(new Form1());
        }
        #region Dispose
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
        #endregion
        #region OnLoad
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            // Timer
            SetupTimer();
            this.DropShadow = true;
            this.gridGroupingControl1.GridVisualStyles = GridVisualStyles.Metro;
            this.gridGroupingControl1.GridOfficeScrollBars = OfficeScrollBars.Metro;
            this.propertyGrid1.SelectedObject = this.gridGroupingControl1;
        }
        #endregion
		#endregion		

        #region Wait for Key
        void WaitForKey()
        {
            skipTimer = true;
            timer.Tick -= new EventHandler(timer_Tick);
            timer.Enabled = false;
            Application.DoEvents();
            if (Control.ModifierKeys == Keys.Shift)
                waitKey = true;

            if (waitKey)
            {
                while (Control.ModifierKeys == Keys.None)
                {
                    System.Threading.Thread.Sleep(5);
                    Application.DoEvents();
                }
            }
            if (!Visible)
                Application.Exit();
            timer.Tick += new EventHandler(timer_Tick);
            timer.Enabled = true;
            skipTimer = false;
        }
        #endregion  
  
     	#region Update dialog controls with changes to grid
		private void gridGroupingControl1_PropertyChanged(object sender, DescriptorPropertyChangedEventArgs e)
		{
			UpdateDialog();
		}

		private void UpdateDialog()
		{
			if (isUIChanged)
				return;

			try
			{
				isPropertyChanged = true;

				GridTableDescriptor td = this.gridGroupingControl1.TableDescriptor;

				this.checkBoxFilter.Checked = td.RecordFilters.Count > 0;
				if (td.RecordFilters.Count > 0)
					this.textBoxFilter.Text  = td.RecordFilters[0].Expression;

				this.checkBoxGrouping.Checked = td.GroupedColumns.Count > 0;
				this.checkBoxSorting.Checked = td.SortedColumns.Count > 0;

				this.trackBarBlinkFrequency.Value = this.gridGroupingControl1.BlinkTime/100;
				if (this.gridGroupingControl1.BlinkTime == 0)
					this.labelBlinkTime.Text = String.Format("Disabled.");
				else
					this.labelBlinkTime.Text = String.Format("{0} milliseconds.", gridGroupingControl1.BlinkTime);

                if (timer != null)
                {
                    if (timer.Enabled)
                        trackBarTimer.Value = (int)Math.Sqrt(1000 / timer.Interval);
                    else
                        trackBarTimer.Value = 0;

                    trackBarTimer.TickFrequency = 1;
                    this.labelTimerInterval.Text = String.Format("Every {0} milliseconds.", timer.Interval);
                }
			}
			catch (Exception ex)
			{
				Trace.WriteLine(ex.ToString());
			}
			finally
			{
				isPropertyChanged = false;
			}
		}

		bool isUIChanged = false;
		bool isPropertyChanged = false;
		#endregion

		#region Filter
		private void checkBoxFilter_CheckedChanged(object sender, System.EventArgs e)
		{
			ApplyFilter();
		}

		private void buttonApplyFilter_Click(object sender, System.EventArgs e)
		{
			if (!checkBoxFilter.Checked)
				checkBoxFilter.Checked = true;
			else
				ApplyFilter();
		}

		private void ApplyFilter()
		{
			if (isPropertyChanged)
				return;

			isUIChanged = true;

			GridTableDescriptor td = this.gridGroupingControl1.TableDescriptor;
			try
			{
				if (this.checkBoxFilter.Checked)
				{
					td.RecordFilters.Clear();
					td.RecordFilters.Add(this.textBoxFilter.Text);
                }
				else
				{
					td.RecordFilters.Clear();
                }
                this.gridGroupingControl1.Refresh();
			}
			catch (Exception ex)
			{
				Trace.WriteLine(ex.ToString());
			}
			finally
			{
				isUIChanged = false;
			}
		}
		#endregion

		#region Grouping
		private void checkBoxGrouping_CheckedChanged(object sender, System.EventArgs e)
		{
			if (isPropertyChanged)
				return;

			isUIChanged = true;

			GridTableDescriptor td = this.gridGroupingControl1.TableDescriptor;
			try
			{
				if (this.checkBoxGrouping.Checked)
				{
					td.GroupedColumns.Clear();
					td.GroupedColumns.Add("1");
					this.gridGroupingControl1.Table.ExpandAllGroups();
                }
				else
				{
					td.GroupedColumns.Clear();
				}
				this.gridGroupingControl1.Refresh();
			}
			catch (Exception ex)
			{
				Trace.WriteLine(ex.ToString());
			}
			finally
			{
				isUIChanged = false;
			}
		}
		#endregion

		#region Blink Frequency
		private void trackBarBlinkFrequency_Scroll(object sender, System.EventArgs e)
		{
			if (isPropertyChanged)
				return;

			isUIChanged = true;

			GridTableDescriptor td = this.gridGroupingControl1.TableDescriptor;
			try
			{
				this.gridGroupingControl1.BlinkTime = this.trackBarBlinkFrequency.Value*100;
				if (this.gridGroupingControl1.BlinkTime == 0)
					this.labelBlinkTime.Text = String.Format("Disabled.");
				else
					this.labelBlinkTime.Text = String.Format("{0} milliseconds.", gridGroupingControl1.BlinkTime);
				this.gridGroupingControl1.Refresh();
			}
			catch (Exception ex)
			{
				Trace.WriteLine(ex.ToString());
			}
			finally
			{
				isUIChanged = false;
			}
		}
		#endregion

		#region Sorting
		private void checkBoxSorting_CheckedChanged(object sender, System.EventArgs e)
		{
			if (isPropertyChanged)
				return;

			isUIChanged = true;

			GridTableDescriptor td = this.gridGroupingControl1.TableDescriptor;
			try
			{
				if (this.checkBoxSorting.Checked)
				{
					td.SortedColumns.Clear();
					td.SortedColumns.Add("1");
					td.SortedColumns.Add("2");
                }
				else
				{
					td.SortedColumns.Clear();
                }
				this.gridGroupingControl1.Refresh();
			}
			catch (Exception ex)
			{
				Trace.WriteLine(ex.ToString());
			}
			finally
			{
				isUIChanged = false;
			}

		}
		#endregion

		#region Coloring
        /// <summary>
        /// Coloring the grid cells when data is updated
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">EventsArgs</param>
		private void checkBoxColor_CheckedChanged(object sender, System.EventArgs e)
		{
			isUIChanged = true;

			GridTableDescriptor td = this.gridGroupingControl1.TableDescriptor;
			try
			{
				if (this.checkBoxColor.Checked)
				{
					// Callback for dynamically coloring cells
					gridGroupingControl1.QueryCellStyleInfo += new GridTableCellStyleInfoEventHandler(gridGroupingControl1_QueryCellStyleInfo);

					// The color of these cells depends on value of cell "1". If engines ListChanged handler
					// detects a change to column "1" it should also automatically repaint the dependant columns
					for (int i = 2; i <= 20; i++)
						gridGroupingControl1.TableDescriptor.Fields[i.ToString()].ReferencedFields = "1";

				}
				else
				{
					gridGroupingControl1.QueryCellStyleInfo -= new GridTableCellStyleInfoEventHandler(gridGroupingControl1_QueryCellStyleInfo);
					gridGroupingControl1.TableDescriptor.Fields.LoadDefault();
                }
				this.gridGroupingControl1.Refresh();
			}
			catch (Exception ex)
			{
				Trace.WriteLine(ex.ToString());
			}
			finally
			{
				isUIChanged = false;
			}
		}
		#endregion        
    }
}


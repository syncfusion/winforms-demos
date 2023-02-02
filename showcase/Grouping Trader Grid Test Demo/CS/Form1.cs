#region Copyright Syncfusion Inc. 2001 - 2023
//
//  Copyright Syncfusion Inc. 2001 - 2023. All rights reserved.
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
using Syncfusion.Windows.Forms.Tools;
using Syncfusion.Windows.Forms.Chart;
using Syncfusion.Drawing;
using Syncfusion.WinForms.Controls;

namespace TraderGridTest
{

	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : SfForm
    {
        #region "API Definition"

        private IContainer components;
		internal System.Windows.Forms.Timer timer;
		private DataTable table;
		private GridGroupingControl gridGroupingControl1;
		private System.Random rand;
		private int m_numUpdatesPerTick = 10;
		DataSet ds;

		private int toggleInsertRemove = 10;// toggle between inserting and removing after n inserts/n removals.
		private int insertRemoveModulus = 5; // frequency of insert / remove : every n timer ticks
        int initialRowCount = 100;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt textBoxFilter;
        private Syncfusion.Windows.Forms.ButtonAdv buttonApplyFilter;
        private TrackBarEx trackBarTimer;
        private TrackBarEx trackBarBlinkFrequency;
        private Panel gridPanel;
        private Panel panel3;
        private Label labelBlinkTime;
        private Label label4;
        private Label labelTimerInterval;
        private Label label1;
        private Panel panel6;
        private Panel sliderPanel;
        private CheckBoxAdv checkBoxFilter;
        private CheckBoxAdv checkBoxGrouping;
        private CheckBoxAdv checkBoxSorting;
        private CheckBoxAdv checkBoxColor;
        private Panel panel1;
        private Label label7;
        private Panel panel5;
        private Panel panel4;
        private Label label5;
        private Label label3;
        private Panel panel8;
        private Label label6;
        private Label label8;
        private Label label2;
        private Label label9;
        private Panel panel10;
        private Label label13;
        private Label label11;
        private Label label10;
        private Panel panel11;
        private Panel panel13;
        private Panel panel12;

        // use 1 if you want to check out inserting and removing rows
		int insertRemoveCount = 2;  

        #endregion

        #region "Constructor"

        public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			// Form settings
            try
            {
                this.ShowIcon = true;
                System.Drawing.Icon ico = new System.Drawing.Icon(GetIconFile(@"common\Images\Grid\Icon\sfgrid.ico"));
                this.Icon = ico;
            }
            catch { }

            this.SetupGrid();
            this.OptimizeGrid();
            
            // we want to use "InsertAt" logice with .NET 2.0 ...
            gridGroupingControl1.AllowSwapDataViewWithDataTableList = false; 

            // Setup datatable with random data
            this.InitializeDataTable();

            this.gridGroupingControl1.DataSource = table;

            this.GridSettings();

            this.ChartSettings();
           
        }

        #endregion

        #region "Loading option"
        Rectangle screenBounds = new Rectangle();
        int grap = 1;
        void Form1_Load(object sender, EventArgs e)
        {
            this.MinimumSize = new Size(this.ClientRectangle.Width-200,this.ClientRectangle.Height);
            this.MaximumSize = this.Size;
            this.WindowState = FormWindowState.Maximized;
            this.gridGroupingControl1.TableControlDrawCell += new GridTableControlDrawCellEventHandler(gridGroupingControl1_TableControlDrawCell);
        }

        #endregion

        #region "GridSettings"

        private void SetupGrid()
        {
            // Setup the grid
            this.gridGroupingControl1 = new GridGroupingControl();
            this.gridGroupingControl1.VerticalThumbTrack = true;
            this.gridGroupingControl1.HorizontalThumbTrack = true;
            this.gridGroupingControl1.TableOptions.VerticalPixelScroll = true;
            this.gridGroupingControl1.Anchor = AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Bottom;
            this.gridGroupingControl1.Location = new Point(15, 15);
            this.gridGroupingControl1.Width = this.gridPanel.Width - 30;
            this.gridGroupingControl1.Height = this.gridPanel.Height - 30;
            this.gridPanel.Controls.Add(gridGroupingControl1);

            this.gridGroupingControl1.TableOptions.ListBoxSelectionMode = SelectionMode.MultiExtended;
        }

        private void GridSettings()
        {
            // Highlight up and downticks
            this.gridGroupingControl1.BlinkTime = 700;  // in ms
            for (int i = 1; i <= 20; i++)
                this.gridGroupingControl1.TableDescriptor.Columns[i.ToString()].AllowBlink = true;

            this.gridGroupingControl1.Engine.AddBaseStylesForBlinking();
            this.gridGroupingControl1.BaseStyles[GridEngine.BlinkIncreased].StyleInfo.TextColor = Color.White;
            this.gridGroupingControl1.BaseStyles[GridEngine.BlinkIncreased].StyleInfo.BackColor = Color.FromArgb(18, 113, 57);

            this.gridGroupingControl1.BaseStyles[GridEngine.BlinkReduced].StyleInfo.TextColor = Color.White;
            this.gridGroupingControl1.BaseStyles[GridEngine.BlinkReduced].StyleInfo.BackColor = Color.FromArgb(24, 91, 113);

            this.gridGroupingControl1.Engine.BaseStyles.Add("CustomStyle");
            this.gridGroupingControl1.BaseStyles["CustomStyle"].StyleInfo.TextColor = Color.White;
            this.gridGroupingControl1.BaseStyles["CustomStyle"].StyleInfo.BackColor = Color.Gray;

            this.gridGroupingControl1.TableControlPrepareViewStyleInfo += new GridTableControlPrepareViewStyleInfoEventHandler(gridGroupingControl1_TableControlPrepareViewStyleInfo);

            this.gridGroupingControl1.TableDescriptor.Columns[0].MaxLength = 8;
            this.gridGroupingControl1.TableDescriptor.Columns[5].MaxLength = 6;
            this.gridGroupingControl1.TableDescriptor.Columns[9].MaxLength = 5;
            this.gridGroupingControl1.TableDescriptor.Columns[14].MaxLength = 6;
            this.gridGroupingControl1.TableDescriptor.Columns["1"].MaxLength = 8;

            // Sort by column "1"
            this.gridGroupingControl1.TableDescriptor.SortedColumns.Add("1");

            //Optional: Filter records
            this.textBoxFilter.Text = "[2] > 88";
            this.gridGroupingControl1.PropertyChanged += new DescriptorPropertyChangedEventHandler(gridGroupingControl1_PropertyChanged);
            this.gridGroupingControl1.ShowGroupDropArea = true;
            
            // Timer
            SetupTimer();
            this.gridGroupingControl1.TopLevelGroupOptions.ShowAddNewRecordBeforeDetails = false;
            this.gridGroupingControl1.TopLevelGroupOptions.ShowCaption = false;
            this.gridGroupingControl1.Appearance.AnyCell.BackColor = Color.FromArgb(27, 27, 27);
            this.gridGroupingControl1.Appearance.AnyCell.TextColor = Color.White;
            this.gridGroupingControl1.Appearance.AnyCell.Borders.Right = new GridBorder(GridBorderStyle.Solid, Color.FromArgb(60, 60, 60));
            this.gridGroupingControl1.Appearance.AnyCell.Borders.Bottom = new GridBorder(GridBorderStyle.Solid, Color.FromArgb(60, 60, 60));
            this.gridGroupingControl1.Appearance.AnyCell.VerticalAlignment = GridVerticalAlignment.Middle;
            this.gridGroupingControl1.Appearance.AnyCell.HorizontalAlignment = GridHorizontalAlignment.Center;
            this.gridGroupingControl1.TableControl.PersistAppearanceSettings = true;

            this.gridGroupingControl1.TableControl.MetroColorTable.ThumbNormal = Color.FromArgb(64, 64, 64);
            this.gridGroupingControl1.TableControl.MetroColorTable.ScrollerBackground = Color.FromArgb(27, 27, 27);

            GridMetroColors metro = new GridMetroColors();
            metro.GroupDropAreaColor.BackColor = Color.FromArgb(27, 27, 27);
            metro.HeaderColor.NormalColor = Color.FromArgb(35, 35, 35);
            metro.HeaderColor.HoverColor = Color.FromArgb(64, 64, 64);
            metro.HeaderTextColor.NormalTextColor = Color.FromArgb(196, 196, 196);
            metro.HeaderTextColor.HoverTextColor = Color.White;
            metro.HeaderBottomBorderColor = Color.Gray;
            this.gridGroupingControl1.SetMetroStyle(metro);

            this.gridGroupingControl1.TableOptions.GridLineBorder = new GridBorder(GridBorderStyle.Solid, Color.Red, GridBorderWeight.Thin);
            this.gridGroupingControl1.DefaultGridBorderStyle = GridBorderStyle.Solid;
        }

        private void ChartSettings()
        {
            chartControl1 = new ChartControl();
            chartControl1.Location = new Point(10, 10);
            chartControl1.Height = this.panel3.Height - 20;
            chartControl1.Width = this.panel3.Width - 20;
            chartControl1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
            chartControl1.PrimaryXAxis.GridLineType.ForeColor = Color.Transparent;
            chartControl1.PrimaryXAxis.GridLineType.ForeColor = Color.Transparent;

            this.chartControl1.CustomPalette = new Color[] { Color.FromArgb(12, 128, 64), Color.FromArgb(237,31,36), Color.FromArgb(243,236,25), Color.FromArgb(126,40,126), Color.FromArgb(56,83,164),
             Color.Cyan,Color.BlueViolet,Color.Brown ,Color.Chocolate,Color.RoyalBlue};

            this.charthelp.ViewType = ViewType.ActualView;
            this.chartControl1.Palette = ChartColorPalette.Custom;
            this.chartControl1.PrimaryYAxis.TitleFont = new Font("Segoe UI", 12f, FontStyle.Regular);
            this.chartControl1.PrimaryYAxis.TitleColor = Color.FromArgb(205, 205, 205);
            this.chartControl1.PrimaryXAxis.TitleFont = new Font("Segoe UI", 12f, FontStyle.Regular);
            this.chartControl1.PrimaryXAxis.TitleColor = Color.FromArgb(205, 205, 205);
            this.chartControl1.ColumnWidthMode = ChartColumnWidthMode.RelativeWidthMode;
            this.charthelp.RealTimeUpdate = true;
            this.chartControl1.PrimaryYAxis.RangeType = ChartAxisRangeType.Set;
            this.chartControl1.PrimaryYAxis.Range = new MinMaxInfo(1, 100, 10);
            this.chartControl1.PrimaryXAxis.RangeType = ChartAxisRangeType.Set;
            this.chartControl1.PrimaryXAxis.Range = new MinMaxInfo(0, 6, 1);
            this.panel3.Controls.Add(chartControl1);
            this.trackBarTimer.ValueChanged += new EventHandler(trackBarTimer_ValueChanged);
            this.trackBarBlinkFrequency.ValueChanged += new EventHandler(trackBarBlinkFrequency_ValueChanged);
            this.chartControl1.AddRandomSeries = false;
            this.chartControl1.Legend.ShowSymbol = true;
            this.chartControl1.Indexed = true;
            this.chartControl1.Legend.Visible = true;
            this.chartControl1.SpacingBetweenSeries = 30;
            this.chartControl1.ColumnDrawMode = ChartColumnDrawMode.PlaneMode;
            this.chartControl1.ShowLegend = false;
            this.chartControl1.Legend.Spacing = 3;
            this.chartControl1.ChartArea.BackInterior = new BrushInfo(GradientStyle.Vertical, Color.Transparent, Color.Transparent);
            this.chartControl1.ChartInterior = new BrushInfo(GradientStyle.Vertical, Color.Transparent, Color.Transparent);
            this.chartControl1.ChartArea.PrimaryXAxis.HidePartialLabels = true;
            this.chartControl1.ElementsSpacing = 5;
            this.chartControl1.PrimaryXAxis.LabelIntersectAction = ChartLabelIntersectAction.Rotate;
            this.chartControl1.PrimaryXAxis.TickLabelsDrawingMode = ChartAxisTickLabelDrawingMode.UserMode;
            this.chartControl1.PrimaryXAxis.GridLineType.ForeColor = Color.Transparent;
            this.chartControl1.PrimaryYAxis.GridLineType.ForeColor = Color.Transparent;
            this.chartControl1.Text = "Product category";
            this.chartControl1.Font = new Font("segoe ui", 22f, FontStyle.Regular);
            this.chartControl1.ForeColor = Color.FromArgb(205, 204, 204);
            this.chartControl1.BorderAppearance.FrameThickness = new ChartThickness(2f);
            this.gridGroupingControl1.Table.DefaultColumnHeaderRowHeight = 40;
            this.gridGroupingControl1.TableDescriptor.Appearance.AnyCell.Font = new GridFontInfo(new Font("segoe ui", 10f, FontStyle.Regular));
            this.gridGroupingControl1.TableDescriptor.Appearance.AnyCell.TextColor = Color.FromArgb(196, 196, 196);
            this.gridGroupingControl1.TableModel.QueryColWidth += new GridRowColSizeEventHandler(TableModel_QueryColWidth);
            this.gridGroupingControl1.TableControlCellClick += new GridTableControlCellClickEventHandler(gridGroupingControl1_TableControlCellClick);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Load += new EventHandler(Form1_Load);
            this.trackBarBlinkFrequency.BackColor = Color.FromArgb(27, 27, 27);
            this.trackBarTimer.BackColor = Color.FromArgb(27, 27, 27);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.RowHeightOnScaling();
            screenBounds = Screen.PrimaryScreen.Bounds;
            try
            {
                if (isHigherResol)
                {
                    Point locX = this.PointToScreen(this.gridPanel.Location);
                    this.gridPanel.Size = new Size(screenBounds.Width - this.panel4.Width - locX.X * 2, this.gridPanel.Height);
                    int width = this.gridPanel.Width + this.gridPanel.Location.X + 10;
                    int height = this.gridPanel.Height + this.gridPanel.Location.Y + 10;
                    this.panel1.Location = new Point(width, this.panel1.Location.Y);
                    this.panel4.Location = new Point(10, this.panel4.Location.Y);
                    this.panel6.Location = new Point(width, this.panel6.Location.Y);
                    if (captionLabel1 != null)
                    {
                        captionLabel1.Font = new System.Drawing.Font("Segoe UI", 16F);
                        captionLabel1.Size = new Size(400, 40);
                        captionLabel1.Location = new Point(captionLabel1.Location.X + 20, captionLabel1.Location.Y);
                        captionLabel1.Location = new System.Drawing.Point(41, 50);
                    }
                    else
                    {
                        this.Text = "Trader Grid";
                    }
                }
                if (grap == 96)
                {
                    this.gridPanel.Size = new Size(screenBounds.Width * 80 / 100, screenBounds.Height * 75 / 100);
                    int width = this.gridPanel.Width + this.gridPanel.Location.X + 10;
                    int height = this.gridPanel.Height + this.gridPanel.Location.Y + 10;
                    this.panel1.Location = new Point(width, this.panel1.Location.Y);
                    this.panel4.Location = new Point(width, this.panel4.Location.Y);
                    this.panel6.Location = new Point(width, this.panel6.Location.Y);
                    int ht = this.gridPanel.Height - this.panel1.Height - this.panel4.Height - 20;
                    this.panel6.Size = new Size(this.panel6.Width, ht);
                }
            }
            catch
            {
            }
        }

        #endregion

        #region "Events and Methods"

        private bool isHigherResol = false;
        void gridGroupingControl1_TableControlDrawCell(object sender, GridTableControlDrawCellEventArgs e)
        {
            if (e.Inner.Style.CellType == "RowHeaderCell")
            {
                e.Inner.Style.Borders.All = new GridBorder(GridBorderStyle.None);
                e.Inner.Style.Borders.Right = new GridBorder(GridBorderStyle.Solid, Color.FromArgb(60, 60, 60), GridBorderWeight.Medium);
            }
            if (e.Inner.Style.CellType == "ColumnHeaderCell")
            {
                e.Inner.Style.Borders.All = new GridBorder(GridBorderStyle.None, Color.Empty, GridBorderWeight.Medium);
                e.Inner.Style.Borders.Bottom = new GridBorder(GridBorderStyle.Solid, Color.FromArgb(60,60,60), GridBorderWeight.Medium);
                e.Inner.Style.Borders.Right = new GridBorder(GridBorderStyle.Solid, Color.FromArgb(60, 60, 60), GridBorderWeight.Medium);

            }
        }
        void gridGroupingControl1_TableControlCellClick(object sender, GridTableControlCellClickEventArgs e)
        {
            GridTableCellStyleInfo style = e.TableControl.GetTableViewStyleInfo(e.Inner.RowIndex, e.Inner.ColIndex);
            string type = style.TableCellIdentity.TableCellType.ToString();
        }


        void TableModel_QueryColWidth(object sender, GridRowColSizeEventArgs e)
        {
            if (e.Index == 1)
            {
                e.Size = 100;
                e.Handled = true;
            }
            if (e.Index > 2)
            {
                e.Size = 60;
                e.Handled = true;
            }
        }
        void trackBarBlinkFrequency_ValueChanged(object sender, EventArgs e)
        {
            this.trackBarBlinkFrequency.Refresh();
        }

        void trackBarTimer_ValueChanged(object sender, EventArgs e)
        {
            this.trackBarTimer.Refresh();
        }
        Syncfusion.GridHelperClasses.GroupingChartHelper charthelp = new Syncfusion.GridHelperClasses.GroupingChartHelper();
        ChartControl chartControl1;

        void gridGroupingControl1_QueryCellStyleInfo(object sender, GridTableCellStyleInfoEventArgs e)
        {
            GridTableCellStyleInfo style = (GridTableCellStyleInfo)e.Style;
            if (e.TableCellIdentity.TableCellType == GridTableCellType.RecordFieldCell
                || e.TableCellIdentity.TableCellType == GridTableCellType.AlternateRecordFieldCell)
            {
                if (e.TableCellIdentity.Column.FieldDescriptor.FieldPropertyType == typeof(string))
                    return;
                // Get the value from column "1" and color all cells in record based
                // on this value.
                Record r = e.Style.TableCellIdentity.DisplayElement.GetRecord();
                object value = r.GetValue("1");
                int v = Convert.ToInt32(value) % colors.Length;
                e.Style.BackColor = colors[v];
            }
        }

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

        /// <summary>
        /// When DPI is greater than 100 then the DefaultRowHeight will be set based on the font size.
        /// </summary>
        internal void RowHeightOnScaling()
        {
            if (this.gridGroupingControl1.TableModel.ActiveGridView != null)
                using (Graphics graph = this.gridGroupingControl1.TableModel.ActiveGridView.CreateGraphics())
                {
                    this.grap = (int)graph.DpiY;
                    if (graph.DpiY > 100)
                    {
                        isHigherResol = true;
                    }
                }
        }

        #endregion

        #region "Optimization"
        /// <summary>
        /// Grid optimization techniques.
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
		}

        #endregion

        #region "DataSet"
        /// <summary>
        /// dataset customization
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
											   next+18,next+19,next+20});
			}

		}
        #endregion
        
        #region "Desginer Stuffs"

        #region "Icon"

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

        #region "Dispose"

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

		#region Windows Form Designer generated code

        Syncfusion.Windows.Forms.CaptionLabel captionLabel1;
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            this.panel6 = new System.Windows.Forms.Panel();
            this.checkBoxFilter = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.textBoxFilter = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.checkBoxColor = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.checkBoxSorting = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.buttonApplyFilter = new Syncfusion.Windows.Forms.ButtonAdv();
            this.checkBoxGrouping = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.labelBlinkTime = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.trackBarBlinkFrequency = new Syncfusion.Windows.Forms.Tools.TrackBarEx(0, 20);
            this.sliderPanel = new System.Windows.Forms.Panel();
            this.labelTimerInterval = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.trackBarTimer = new Syncfusion.Windows.Forms.Tools.TrackBarEx(0, 10);
            this.gridPanel = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel13 = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxFilter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxFilter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxSorting)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxGrouping)).BeginInit();
            this.sliderPanel.SuspendLayout();
            this.gridPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel13.SuspendLayout();
            this.panel12.SuspendLayout();
            this.panel10.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.panel6.Controls.Add(this.checkBoxFilter);
            this.panel6.Controls.Add(this.textBoxFilter);
            this.panel6.Controls.Add(this.checkBoxColor);
            this.panel6.Controls.Add(this.checkBoxSorting);
            this.panel6.Controls.Add(this.buttonApplyFilter);
            this.panel6.Controls.Add(this.checkBoxGrouping);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(446, 0);
            this.panel6.TabIndex = 15;
            // 
            // checkBoxFilter
            // 
            this.checkBoxFilter.BeforeTouchSize = new System.Drawing.Size(174, 36);
            this.checkBoxFilter.DrawFocusRectangle = false;
            this.checkBoxFilter.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.checkBoxFilter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.checkBoxFilter.ImageCheckBoxSize = new System.Drawing.Size(16, 16);
            this.checkBoxFilter.Location = new System.Drawing.Point(246, 31);
            this.checkBoxFilter.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.checkBoxFilter.Name = "checkBoxFilter";
            this.checkBoxFilter.Size = new System.Drawing.Size(174, 36);
            this.checkBoxFilter.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.checkBoxFilter.TabIndex = 5;
            this.checkBoxFilter.Text = "Enable Filter";
            this.checkBoxFilter.ThemesEnabled = false;
            this.checkBoxFilter.CheckStateChanged += new System.EventHandler(this.checkBoxFilter_CheckedChanged);
            // 
            // textBoxFilter
            // 
            this.textBoxFilter.BackColor = System.Drawing.Color.White;
            this.textBoxFilter.BeforeTouchSize = new System.Drawing.Size(155, 29);
            this.textBoxFilter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.textBoxFilter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxFilter.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxFilter.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFilter.ForeColor = System.Drawing.Color.Black;
            this.textBoxFilter.Location = new System.Drawing.Point(249, 122);
            this.textBoxFilter.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.textBoxFilter.Name = "textBoxFilter";
            this.textBoxFilter.Size = new System.Drawing.Size(155, 29);
            this.textBoxFilter.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Metro;
            this.textBoxFilter.TabIndex = 6;
            this.textBoxFilter.Text = "textBox1";
            // 
            // checkBoxColor
            // 
            this.checkBoxColor.BeforeTouchSize = new System.Drawing.Size(203, 36);
            this.checkBoxColor.DrawFocusRectangle = false;
            this.checkBoxColor.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.checkBoxColor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.checkBoxColor.ImageCheckBoxSize = new System.Drawing.Size(16, 16);
            this.checkBoxColor.Location = new System.Drawing.Point(14, 213);
            this.checkBoxColor.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.checkBoxColor.Name = "checkBoxColor";
            this.checkBoxColor.Size = new System.Drawing.Size(203, 36);
            this.checkBoxColor.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.checkBoxColor.TabIndex = 7;
            this.checkBoxColor.Text = "Enable Coloring";
            this.checkBoxColor.ThemesEnabled = false;
            this.checkBoxColor.CheckStateChanged += new System.EventHandler(this.checkBoxColor_CheckedChanged);
            // 
            // checkBoxSorting
            // 
            this.checkBoxSorting.BeforeTouchSize = new System.Drawing.Size(177, 36);
            this.checkBoxSorting.DrawFocusRectangle = false;
            this.checkBoxSorting.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.checkBoxSorting.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.checkBoxSorting.ImageCheckBoxSize = new System.Drawing.Size(16, 16);
            this.checkBoxSorting.Location = new System.Drawing.Point(14, 31);
            this.checkBoxSorting.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.checkBoxSorting.Name = "checkBoxSorting";
            this.checkBoxSorting.Size = new System.Drawing.Size(177, 36);
            this.checkBoxSorting.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.checkBoxSorting.TabIndex = 7;
            this.checkBoxSorting.Text = "Enable Sorting";
            this.checkBoxSorting.ThemesEnabled = false;
            this.checkBoxSorting.CheckStateChanged += new System.EventHandler(this.checkBoxSorting_CheckedChanged);
            // 
            // buttonApplyFilter
            // 
            this.buttonApplyFilter.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.buttonApplyFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(91)))), ((int)(((byte)(113)))));
            this.buttonApplyFilter.BeforeTouchSize = new System.Drawing.Size(155, 36);
            this.buttonApplyFilter.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.RaisedInner;
            this.buttonApplyFilter.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.buttonApplyFilter.ForeColor = System.Drawing.Color.White;
            this.buttonApplyFilter.IsBackStageButton = false;
            this.buttonApplyFilter.Location = new System.Drawing.Point(249, 213);
            this.buttonApplyFilter.Name = "buttonApplyFilter";
            this.buttonApplyFilter.Size = new System.Drawing.Size(155, 36);
            this.buttonApplyFilter.TabIndex = 8;
            this.buttonApplyFilter.Text = "Apply";
            this.buttonApplyFilter.UseVisualStyle = true;
            this.buttonApplyFilter.Click += new System.EventHandler(this.buttonApplyFilter_Click);
            // 
            // checkBoxGrouping
            // 
            this.checkBoxGrouping.BeforeTouchSize = new System.Drawing.Size(203, 36);
            this.checkBoxGrouping.DrawFocusRectangle = false;
            this.checkBoxGrouping.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.checkBoxGrouping.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.checkBoxGrouping.ImageCheckBoxSize = new System.Drawing.Size(16, 16);
            this.checkBoxGrouping.Location = new System.Drawing.Point(14, 119);
            this.checkBoxGrouping.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.checkBoxGrouping.Name = "checkBoxGrouping";
            this.checkBoxGrouping.Size = new System.Drawing.Size(203, 36);
            this.checkBoxGrouping.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.checkBoxGrouping.TabIndex = 7;
            this.checkBoxGrouping.Text = "Enable Grouping";
            this.checkBoxGrouping.ThemesEnabled = false;
            this.checkBoxGrouping.CheckStateChanged += new System.EventHandler(this.checkBoxGrouping_CheckedChanged);
            // 
            // labelBlinkTime
            // 
            this.labelBlinkTime.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBlinkTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.labelBlinkTime.Location = new System.Drawing.Point(250, 177);
            this.labelBlinkTime.Name = "labelBlinkTime";
            this.labelBlinkTime.Size = new System.Drawing.Size(151, 28);
            this.labelBlinkTime.TabIndex = 15;
            this.labelBlinkTime.Text = "Disabled.";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.label4.Location = new System.Drawing.Point(19, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(258, 39);
            this.label4.TabIndex = 13;
            this.label4.Text = "Blink Frequency (Milli Secs)";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // trackBarBlinkFrequency
            // 
            this.trackBarBlinkFrequency.BackColor = System.Drawing.Color.White;
            this.trackBarBlinkFrequency.BeforeTouchSize = new System.Drawing.Size(372, 20);
            this.trackBarBlinkFrequency.ChannelHeight = 8;
            this.trackBarBlinkFrequency.Location = new System.Drawing.Point(32, 98);
            this.trackBarBlinkFrequency.Name = "trackBarBlinkFrequency";
            this.trackBarBlinkFrequency.Size = new System.Drawing.Size(372, 20);
            this.trackBarBlinkFrequency.SliderSize = new System.Drawing.Size(15, 20);
            this.trackBarBlinkFrequency.SmallChange = 2;
            this.trackBarBlinkFrequency.Style = Syncfusion.Windows.Forms.Tools.TrackBarEx.Theme.Metro;
            this.trackBarBlinkFrequency.TabIndex = 2;
            this.trackBarBlinkFrequency.TimerInterval = 2;
            this.trackBarBlinkFrequency.Value = 5;
            this.trackBarBlinkFrequency.Scroll += new System.EventHandler(this.trackBarBlinkFrequency_Scroll);
            // 
            // sliderPanel
            // 
            this.sliderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.sliderPanel.Controls.Add(this.labelTimerInterval);
            this.sliderPanel.Controls.Add(this.label1);
            this.sliderPanel.Controls.Add(this.trackBarTimer);
            this.sliderPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sliderPanel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.sliderPanel.Location = new System.Drawing.Point(0, 0);
            this.sliderPanel.Name = "sliderPanel";
            this.sliderPanel.Size = new System.Drawing.Size(446, 249);
            this.sliderPanel.TabIndex = 1;
            // 
            // labelTimerInterval
            // 
            this.labelTimerInterval.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTimerInterval.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.labelTimerInterval.Location = new System.Drawing.Point(250, 174);
            this.labelTimerInterval.Name = "labelTimerInterval";
            this.labelTimerInterval.Size = new System.Drawing.Size(151, 34);
            this.labelTimerInterval.TabIndex = 16;
            this.labelTimerInterval.Text = "label2";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.label1.Location = new System.Drawing.Point(19, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 43);
            this.label1.TabIndex = 14;
            this.label1.Text = "Timer Frequency (Milli Secs)";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // trackBarTimer
            // 
            this.trackBarTimer.BackColor = System.Drawing.Color.White;
            this.trackBarTimer.BeforeTouchSize = new System.Drawing.Size(372, 20);
            this.trackBarTimer.ChannelHeight = 8;
            this.trackBarTimer.Location = new System.Drawing.Point(32, 97);
            this.trackBarTimer.Name = "trackBarTimer";
            this.trackBarTimer.Size = new System.Drawing.Size(372, 20);
            this.trackBarTimer.SliderSize = new System.Drawing.Size(15, 20);
            this.trackBarTimer.Style = Syncfusion.Windows.Forms.Tools.TrackBarEx.Theme.Metro;
            this.trackBarTimer.TabIndex = 2;
            this.trackBarTimer.TimerInterval = 100;
            this.trackBarTimer.TrackBarGradientEnd = System.Drawing.Color.Yellow;
            this.trackBarTimer.Transparent = true;
            this.trackBarTimer.Value = 5;
            this.trackBarTimer.Scroll += new System.EventHandler(this.trackBarTimer_Scroll);
            // 
            // gridPanel
            // 
            this.gridPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.gridPanel.Controls.Add(this.panel3);
            this.gridPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridPanel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridPanel.Location = new System.Drawing.Point(0, 19);
            this.gridPanel.Name = "gridPanel";
            this.gridPanel.Size = new System.Drawing.Size(1108, 144);
            this.gridPanel.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.panel3.Location = new System.Drawing.Point(579, 741);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(491, 0);
            this.panel3.TabIndex = 0;
            this.panel3.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.panel1.Controls.Add(this.labelBlinkTime);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.trackBarBlinkFrequency);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(503, 237);
            this.panel1.TabIndex = 16;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.panel4);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.panel8);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(2, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1685, 223);
            this.panel5.TabIndex = 17;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.gridPanel);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(58, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1108, 223);
            this.panel4.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.label9.Dock = System.Windows.Forms.DockStyle.Top;
            this.label9.Location = new System.Drawing.Point(0, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(1108, 19);
            this.label9.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.label7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label7.Location = new System.Drawing.Point(0, 163);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(1108, 60);
            this.label7.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.label5.Dock = System.Windows.Forms.DockStyle.Right;
            this.label5.Location = new System.Drawing.Point(1166, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 223);
            this.label5.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.label3.Dock = System.Windows.Forms.DockStyle.Left;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 223);
            this.label3.TabIndex = 18;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.panel11);
            this.panel8.Controls.Add(this.panel10);
            this.panel8.Controls.Add(this.label10);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel8.Location = new System.Drawing.Point(1182, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(503, 223);
            this.panel8.TabIndex = 19;
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.panel13);
            this.panel11.Controls.Add(this.panel12);
            this.panel11.Controls.Add(this.label6);
            this.panel11.Controls.Add(this.label11);
            this.panel11.Controls.Add(this.label2);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel11.Location = new System.Drawing.Point(0, 256);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(503, 0);
            this.panel11.TabIndex = 23;
            // 
            // panel13
            // 
            this.panel13.Controls.Add(this.panel6);
            this.panel13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel13.Location = new System.Drawing.Point(0, 289);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(446, 0);
            this.panel13.TabIndex = 24;
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.sliderPanel);
            this.panel12.Controls.Add(this.label8);
            this.panel12.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel12.Location = new System.Drawing.Point(0, 21);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(446, 268);
            this.panel12.TabIndex = 23;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.label8.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label8.Location = new System.Drawing.Point(0, 249);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(446, 19);
            this.label8.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.label6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label6.Location = new System.Drawing.Point(0, -60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(446, 60);
            this.label6.TabIndex = 18;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.label11.Dock = System.Windows.Forms.DockStyle.Right;
            this.label11.Location = new System.Drawing.Point(446, 21);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 0);
            this.label11.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(503, 21);
            this.label2.TabIndex = 17;
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.label13);
            this.panel10.Controls.Add(this.panel1);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel10.Location = new System.Drawing.Point(0, 19);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(503, 237);
            this.panel10.TabIndex = 22;
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.label13.Dock = System.Windows.Forms.DockStyle.Right;
            this.label13.Location = new System.Drawing.Point(446, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(57, 237);
            this.label13.TabIndex = 22;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.label10.Dock = System.Windows.Forms.DockStyle.Top;
            this.label10.Location = new System.Drawing.Point(0, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(503, 19);
            this.label10.TabIndex = 21;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScaleBaseSize = new System.Drawing.Size(23, 64);
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(1689, 227);
            this.Controls.Add(this.panel5);
            this.Font = new System.Drawing.Font("Segoe UI", 24F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.Style.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Style.InactiveShadowOpacity = ((byte)(0));
            this.Style.ShadowOpacity = ((byte)(0));
            this.Style.TitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.Style.TitleBar.CloseButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Style.TitleBar.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.Style.TitleBar.ForeColor = System.Drawing.Color.White;
            this.Style.TitleBar.Height = 65;
            this.Style.TitleBar.MaximizeButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Style.TitleBar.MinimizeButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Text = "Trader Grid";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxFilter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxFilter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxSorting)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxGrouping)).EndInit();
            this.sliderPanel.ResumeLayout(false);
            this.sliderPanel.PerformLayout();
            this.gridPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.panel13.ResumeLayout(false);
            this.panel12.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		#endregion

        #region "Main"

        /// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense(DemoCommon.FindLicenseKey());
            Application.EnableVisualStyles();
			Application.Run(new Form1());
		}

        #endregion

        #endregion

        #region "Timer Updates Customization"

        int icount = 0;
		int timerCount = 0;
		int ti = 0;
		bool shouldInsert = false;
        bool waitKey = false;

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

        private void SetupTimer()
        {
            timer = new System.Windows.Forms.Timer();
            timer.Tick += new EventHandler(timer_Tick);
            timer.Interval = 100;
            timer.Start();

            this.UpdateDialog();
            this.gridGroupingControl1.Focus();
        }


        bool skipTimer = false;

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
						drow[col] = (int) (Convert.ToDouble(drow[col]) * (rand.Next(50) / 100.0f + 0.8));					
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
		Color[] colors = new Color[] {									 
										 Color.FromArgb( 0x85, 0xbf, 0x75 ),										 
										 Color.FromArgb( 0xb4, 0xe7, 0xf2 ),
										 Color.FromArgb( 0xff, 0xbf, 0x34 ),
										 Color.FromArgb( 0x82, 0x2e, 0x1b ),
										 Color.FromArgb( 0x3a, 0x86, 0x7e ),
		};

		private void trackBarTimer_Scroll(object sender, System.EventArgs e)
		{
			if (this.trackBarTimer.Value == 0)
			{
				timer.Enabled = false;
				this.labelTimerInterval.Text = String.Format("Timer disabled");
			}
			else
			{
				timer.Interval = 1000/(this.trackBarTimer.Value*trackBarTimer.Value);
				timer.Enabled = true;
				this.labelTimerInterval.Text = String.Format("{0} milliseconds", timer.Interval);
			}
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
					this.labelBlinkTime.Text = String.Format("Disabled");
				else
					this.labelBlinkTime.Text = String.Format("{0} milliseconds", gridGroupingControl1.BlinkTime);

                if (timer != null)
                {
                    if (timer.Enabled)
                        trackBarTimer.Value = (int)Math.Sqrt(1000 / timer.Interval);
                    else
                        trackBarTimer.Value = 0;

                    trackBarTimer.TimerInterval = 1;
                    this.labelTimerInterval.Text = String.Format("{0} milliseconds", timer.Interval);
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

		#region BlinkFrequency
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
					this.labelBlinkTime.Text = String.Format("{0} milliseconds", gridGroupingControl1.BlinkTime);
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

        #region "Load"

        protected override void OnLoad(EventArgs e)
        {          
            base.OnLoad(e);

            // Timer
            SetupTimer();
           // this.DropShadow = true;
            this.gridGroupingControl1.GridVisualStyles = GridVisualStyles.Metro;
            this.gridGroupingControl1.GridOfficeScrollBars = OfficeScrollBars.Metro;
        }

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


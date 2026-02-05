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
using System.Globalization;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using Syncfusion.Windows.Forms.Grid;
using DemoCommon.Grid;
using Syncfusion.Windows.Forms;

namespace RetirementSimulation
{
    /// <summary>
    /// Summary description for Form1.
    /// </summary>
    public class Form1 : GridDemoForm
    {
        #region "API Definition"
        private Syncfusion.Windows.Forms.TabBarSplitterControl tabBarSplitterControl1;
        private Syncfusion.Windows.Forms.TabBarPage tabBarPage1;
        private Syncfusion.Windows.Forms.TabBarPage tabBarPage2;
        private Syncfusion.Windows.Forms.Grid.GridControl gridDisplay;
        private Syncfusion.Windows.Forms.Grid.GridControl gridCalculations;
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.Container components = null;
        GridFormulaEngine engine;
        private Hashtable helperList = null;
        #endregion

        #region "Constructor"

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
            //
            // TODO: Add any constructor code after InitializeComponent call
            //

            engine = ((GridFormulaCellModel)this.gridCalculations.CellModels["FormulaCell"]).Engine;

            this.GridSettings();
        }

        #endregion

        #region "Grid Settings"
        /// <summary>
        /// Grid Settings for better look and feel
        /// </summary>
        private void GridSettings()
        {
            //Used to set default row height
            this.gridCalculations.DefaultRowHeight = (int)DpiAware.LogicalToDeviceUnits(22.0f);

            this.gridCalculations.Model.Options.DisplayEmptyColumns = true;
            this.gridCalculations.Model.Options.DisplayEmptyRows = true;


            //Used to set default row height
            this.gridDisplay.DefaultRowHeight = (int)DpiAware.LogicalToDeviceUnits(22.0f);

            this.gridDisplay.Model.Options.DisplayEmptyColumns = true;
            this.gridDisplay.Model.Options.DisplayEmptyRows = true;
        }
        #endregion

        #region "Designer Stuffs"
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

        #region Windows Form Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabBarSplitterControl1 = new Syncfusion.Windows.Forms.TabBarSplitterControl();
            this.tabBarPage1 = new Syncfusion.Windows.Forms.TabBarPage();
            this.gridDisplay = new Syncfusion.Windows.Forms.Grid.GridControl();
            this.tabBarPage2 = new Syncfusion.Windows.Forms.TabBarPage();
            this.gridCalculations = new Syncfusion.Windows.Forms.Grid.GridControl();
            this.tabBarSplitterControl1.SuspendLayout();
            this.tabBarPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridDisplay)).BeginInit();
            this.tabBarPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCalculations)).BeginInit();
            this.SuspendLayout();
            // 
            // tabBarSplitterControl1
            // 
            this.tabBarSplitterControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tabBarSplitterControl1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tabBarSplitterControl1.Controls.Add(this.tabBarPage1);
            this.tabBarSplitterControl1.Controls.Add(this.tabBarPage2);
            this.tabBarSplitterControl1.EnabledColor = System.Drawing.SystemColors.WindowText;
            this.tabBarSplitterControl1.Location = new System.Drawing.Point(12, 13);
            this.tabBarSplitterControl1.Name = "tabBarSplitterControl1";
            this.tabBarSplitterControl1.Size = new System.Drawing.Size(675, 391);
            this.tabBarSplitterControl1.SplitBars = ((Syncfusion.Windows.Forms.DynamicSplitBars)((Syncfusion.Windows.Forms.DynamicSplitBars.SplitRows | Syncfusion.Windows.Forms.DynamicSplitBars.SplitColumns)));
            this.tabBarSplitterControl1.Style = Syncfusion.Windows.Forms.TabBarSplitterStyle.Metro;
            this.tabBarSplitterControl1.TabFolderDelta = 11;
            this.tabBarSplitterControl1.TabIndex = 0;
            this.tabBarSplitterControl1.Text = "tabBarSplitterControl1";
            this.tabBarSplitterControl1.ThemesEnabled = true;
            this.tabBarSplitterControl1.ScrollButtons = Syncfusion.Windows.Forms.DisplayArrowButtons.None;
            // 
            // tabBarPage1
            // 
            this.tabBarPage1.Controls.Add(this.gridDisplay);
            this.tabBarPage1.Location = new System.Drawing.Point(0, 0);
            this.tabBarPage1.Name = "tabBarPage1";
            this.tabBarPage1.SplitBars = ((Syncfusion.Windows.Forms.DynamicSplitBars)((Syncfusion.Windows.Forms.DynamicSplitBars.SplitRows | Syncfusion.Windows.Forms.DynamicSplitBars.SplitColumns)));
            this.tabBarPage1.TabBackColor = System.Drawing.SystemColors.Control;
            this.tabBarPage1.Text = "Display";
            this.tabBarPage1.ThemesEnabled = true;
            // 
            // gridDisplay
            // 
            this.gridDisplay.DpiAware = true;
            this.gridDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gridDisplay.ColCount = 15;
           
            this.gridDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridDisplay.FillSplitterPane = true;
            this.gridDisplay.Location = new System.Drawing.Point(0, 0);
            this.gridDisplay.Name = "gridDisplay";
            this.gridDisplay.Properties.ColHeaders = false;
            this.gridDisplay.Properties.DisplayHorzLines = false;
            this.gridDisplay.Properties.DisplayVertLines = false;
            this.gridDisplay.Properties.MarkColHeader = false;
            this.gridDisplay.Properties.MarkRowHeader = false;
            this.gridDisplay.Properties.RowHeaders = false;
            this.gridDisplay.RowCount = 30;
            //this.gridDisplay.Size = new System.Drawing.Size(658, 374);
            this.gridDisplay.SmartSizeBox = false;
            this.gridDisplay.Text = "gridControl1";
            this.gridDisplay.ThemesEnabled = true;
            // 
            // tabBarPage2
            // 
            this.tabBarPage2.Controls.Add(this.gridCalculations);
            this.tabBarPage2.Location = new System.Drawing.Point(0, 0);
            this.tabBarPage2.Name = "tabBarPage2";
            this.tabBarPage2.SplitBars = ((Syncfusion.Windows.Forms.DynamicSplitBars)((Syncfusion.Windows.Forms.DynamicSplitBars.SplitRows | Syncfusion.Windows.Forms.DynamicSplitBars.SplitColumns)));
            this.tabBarPage2.TabBackColor = System.Drawing.SystemColors.Control;
            this.tabBarPage2.Text = "Calculations";
            this.tabBarPage2.ThemesEnabled = true;
            // 
            // gridCalculations
            //
            this.gridCalculations.DpiAware = true;
            this.gridCalculations.ColCount = 15;
            this.gridCalculations.FillSplitterPane = true;
            this.gridCalculations.Location = new System.Drawing.Point(0, 0);
            this.gridCalculations.Name = "gridCalculations";
            this.gridCalculations.RowCount = 50;
            this.gridCalculations.Size = new System.Drawing.Size(656, 372);
            this.gridCalculations.SmartSizeBox = false;
            this.gridCalculations.Text = "gridControl2";
            this.gridCalculations.DpiAware = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 416);
            this.Controls.Add(this.tabBarSplitterControl1);
            this.DropShadow = false;
            this.MinimumSize = new Size(500, 400);
            this.Name = "Form1";
            this.Text = "Retirement Simulation Demo";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabBarSplitterControl1.ResumeLayout(false);
            this.tabBarPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridDisplay)).EndInit();
            this.tabBarPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridCalculations)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense(Syncfusion.Licensing.DemoCommon.FindLicenseKey());
            Application.Run(new Form1());
        }

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

        #region Event Handler
        private void Form1_Load(object sender, System.EventArgs e)
        {
            //helper class to mark headers/row on a the calculation sheet
            GridMarkHeadersHelper helper = new GridMarkHeadersHelper(this.gridCalculations);
            helper.RegisterGridForContextMenu(this.gridDisplay);

            this.helperList = new Hashtable();
            this.helperList.Add(this.gridCalculations, helper);

            //register grids for multisheeted use
            int sheetFamilyID = GridFormulaEngine.CreateSheetFamilyID();
            GridFormulaEngine.RegisterGridAsSheet("Display", this.gridDisplay.Model, sheetFamilyID);
            GridFormulaEngine.RegisterGridAsSheet("Calc", this.gridCalculations.Model, sheetFamilyID);

            SetUpDisplaySheet();

            SetUpCalcSheet();

            SetUpNamedRanges();

            //setup copying formulas
            GridFormulaEngine engine = ((GridFormulaCellModel)this.gridCalculations.CellModels["FormulaCell"]).Engine;
            engine.FormulaCopyFlags |= GridFormulaCopyFlags.ClipBoardFormula;

            //make sure calc grid has current cell
            this.tabBarPage2.ActiveControl = this.gridCalculations;
            this.gridCalculations.CurrentCell.MoveTo(1, 1);

            //bring up form on grid in first tab
            this.tabBarSplitterControl1.ActivePage = this.tabBarPage1;
            this.tabBarPage1.ActiveControl = this.gridDisplay;
            this.gridDisplay.CurrentCell.MoveTo(5, 5);
            this.gridDisplay.Refresh();
            //subscribe to TabBar events to handle splitters generating new grids
            this.tabBarSplitterControl1.PaneCreated += new Syncfusion.Windows.Forms.SplitterPaneEventHandler(tabBar_PaneCreated);
            this.tabBarSplitterControl1.PaneClosing += new Syncfusion.Windows.Forms.SplitterPaneEventHandler(tabBar_PaneClosing);

            this.gridCalculations.Properties.GridLineColor = System.Drawing.Color.Silver;
            this.gridCalculations.DefaultGridBorderStyle = GridBorderStyle.Solid;
            this.gridCalculations.ThemesEnabled = true;
            this.Text = "Retirement Simulation Demo";
            this.gridCalculations.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro;
            this.gridDisplay.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro;
            this.gridDisplay.DefaultRowHeight = (int)DpiAware.LogicalToDeviceUnits(25.0f);
            this.gridCalculations.DefaultColWidth = (int)DpiAware.LogicalToDeviceUnits(70.0f);
            this.gridCalculations.DefaultGridBorderStyle = GridBorderStyle.Solid;
            this.gridCalculations.ThemesEnabled = true;
            this.gridCalculations.MarkColHeader = true;
            this.gridCalculations.MarkRowHeader = true;
            this.gridCalculations.AlphaBlendSelectionColor = Color.Orange;
            this.gridCalculations.Properties.GridLineColor = Color.FromArgb(208, 215, 229);

            this.gridDisplay.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.tabBarSplitterControl1.ThemesEnabled = true;
            this.gridDisplay.PrepareViewStyleInfo += new GridPrepareViewStyleInfoEventHandler(gridDisplay_PrepareViewStyleInfo);

            this.tabBarSplitterControl1.ActivePageChanged += new ControlEventHandler(tabBarSplitterControl1_ActivePageChanged);
            this.tabBarSplitterControl1.ShowVerticalScrollBar = false;
        }

        void tabBarSplitterControl1_ActivePageChanged(object sender, ControlEventArgs e)
        {
            if (this.tabBarSplitterControl1.ActivePageIndex == 0)
            {
                this.tabBarSplitterControl1.ShowVerticalScrollBar = false;
            }
            else
            {
                this.tabBarSplitterControl1.ShowVerticalScrollBar = true;
            }
        }

        void gridDisplay_PrepareViewStyleInfo(object sender, GridPrepareViewStyleInfoEventArgs e)
        {
            e.Style.Borders.All = GridBorder.Empty;
        }
        private void tabBar_PaneCreated(object sender, Syncfusion.Windows.Forms.SplitterPaneEventArgs e)
        {
            GridControl grid = e.Control as GridControl;
            GridMarkHeadersHelper helper = new GridMarkHeadersHelper(grid);
            helperList.Add(grid, helper);
        }

        private void tabBar_PaneClosing(object sender, Syncfusion.Windows.Forms.SplitterPaneEventArgs e)
        {
            GridControl grid = e.Control as GridControl;
            GridMarkHeadersHelper helper = this.helperList[grid] as GridMarkHeadersHelper;
            if (helper != null)
            {
                this.helperList.Remove(grid);
                helper.Dispose();
                helper = null;
            }
        }
        #endregion

        #region DisplaySheet

        private void SetUpNamedRanges()
        {
            //just so we can list the ranges (in order) at the end of the method
            ArrayList tempList = new ArrayList();


            string col = "Display!B";

            int row = 6;
            engine.AddNamedRange("InitialYear", string.Format("{0}{1}", col, row));
            tempList.Add("InitialYear");
            row += 1;
            engine.AddNamedRange("InitialAgeSpouse1", string.Format("{0}{1}", col, row));
            tempList.Add("InitialAgeSpouse1");
            row += 1;
            engine.AddNamedRange("InitialAgeSpouse2", string.Format("{0}{1}", col, row));
            tempList.Add("InitialAgeSpouse2");
            row += 1;
            engine.AddNamedRange("InitialSavingsBalance", string.Format("{0}{1}", col, row));
            tempList.Add("InitialSavingsBalance");
            row += 1;
            engine.AddNamedRange("ReturnPercentage1", string.Format("{0}{1}", col, row));
            tempList.Add("ReturnPercentage1");
            row += 1;
            engine.AddNamedRange("ReturnVolatility1", string.Format("{0}{1}", col, row));
            tempList.Add("ReturnVolatility1");
            row += 1;
            engine.AddNamedRange("ReturnPercentage2", string.Format("{0}{1}", col, row));
            tempList.Add("ReturnPercentage2");
            row += 1;
            engine.AddNamedRange("ReturnVolatility2", string.Format("{0}{1}", col, row));
            tempList.Add("ReturnVolatility2");
            row += 1;
            engine.AddNamedRange("IncomeCOLA", string.Format("{0}{1}", col, row));
            tempList.Add("IncomeCOLA");
            row += 1;
            engine.AddNamedRange("ExpenseCOLA", string.Format("{0}{1}", col, row));
            tempList.Add("ExpenseCOLA");
            row += 1;
            engine.AddNamedRange("SSAgeSpouse1", string.Format("{0}{1}", col, row));
            tempList.Add("SSAgeSpouse1");
            row += 1;
            engine.AddNamedRange("SSAgeSpouse2", string.Format("{0}{1}", col, row));
            tempList.Add("SSAgeSpouse2");
            row += 1;
            engine.AddNamedRange("SSInitialAmountSpouse1", string.Format("{0}{1}", col, row));
            tempList.Add("SSInitialAmountSpouse1");
            row += 1;
            engine.AddNamedRange("SSInitialPercentageSpouse2", string.Format("{0}{1}", col, row));
            tempList.Add("SSInitialPercentageSpouse2");
            row += 1;
            engine.AddNamedRange("Spouse1Dies", string.Format("{0}{1}", col, row));
            tempList.Add("Spouse1Dies");
            row += 1;
            engine.AddNamedRange("Spouse1Retires", string.Format("{0}{1}", col, row));
            tempList.Add("Spouse1Retires");
            row += 1;
            engine.AddNamedRange("InitialAnnualDraw", string.Format("{0}{1}", col, row));
            tempList.Add("InitialAnnualDraw");
            row += 1;
            engine.AddNamedRange("RandomBehavior", string.Format("{0}{1}", col, row));
            tempList.Add("RandomBehavior");

            //the trigger cell used in simulation run
            engine.AddNamedRange("TriggerCell", string.Format("Display!C11", col, row));


            //just display named values
            //row = 2;
            //foreach(string key in tempList)
            //{
            //    this.gridCalculations[row, 1].Text = key;
            //    this.gridCalculations[row, 2].Text = string.Format("= {0}", engine.NamedRanges[key.ToUpper()]);
            //    row++;
            //}


        }

        private void SetUpDisplaySheet()
        {
            int row = 2;
            int col = 1;

            //some general settings
            this.gridDisplay.ColWidths[col] = (int)DpiAware.LogicalToDeviceUnits(220);
            this.gridDisplay.TableStyle.Enabled = false;
            this.gridDisplay.TableStyle.Font.Facename = "Arial";
            this.gridDisplay.EnterKeyBehavior = GridDirectionType.Down;

            #region inputs
            //main title
            this.gridDisplay.CoveredRanges.Add(GridRangeInfo.Cells(row, col, row, col + 4));
            GridStyleInfo style = this.gridDisplay[row, col];
            style.Text = "Retirement Calculator";
            style.Font.Size = 14f;
            style.Font.Bold = true;
            style.HorizontalAlignment = GridHorizontalAlignment.Center;
            this.gridDisplay.RowHeights[row] = (int)DpiAware.LogicalToDeviceUnits(25.0f);

            //inputs
            row += 1;
            this.gridDisplay.RowHeights[row] = (int)DpiAware.LogicalToDeviceUnits(10);
            row += 1;
            //this.gridDisplay.CoveredRanges.Add(GridRangeInfo.Cells(row, col, row, col + 1));
            style = this.gridDisplay[row, col];
            style.Text = "Inputs";
            style.Font.Size = 10f;
            //style.Font.Bold = true;
            style.Font.Underline = true;
            style.HorizontalAlignment = GridHorizontalAlignment.Right;

            //results
            //this.gridDisplay.CoveredRanges.Add(GridRangeInfo.Cells(row, col + 3, row, col + 4));
            style = this.gridDisplay[row, col + 2];
            style.Text = "Results";
            style.Font.Size = 10f;
            //style.Font.Bold = true;
            style.Font.Underline = true;
            style.HorizontalAlignment = GridHorizontalAlignment.Right;

            //Initial Year
            row += 1;
            this.gridDisplay.RowHeights[row] = (int)DpiAware.LogicalToDeviceUnits(5.0f);
            row += 1;
            style = this.gridDisplay[row, col];
            style.Text = "Initial Year:";
            style.HorizontalAlignment = GridHorizontalAlignment.Right;

            style = this.gridDisplay[row, col + 1];
            style.Text = "2004";
            style.Font.Bold = true;
            style.Enabled = true;
            style.HorizontalAlignment = GridHorizontalAlignment.Left;

            //Initial Age spouse1
            row += 1;
            style = this.gridDisplay[row, col];
            style.Text = "Initial Age spouse1:";
            style.HorizontalAlignment = GridHorizontalAlignment.Right;

            style = this.gridDisplay[row, col + 1];
            style.Text = "56";
            style.Font.Bold = true;
            style.Enabled = true;
            style.HorizontalAlignment = GridHorizontalAlignment.Left;

            //Initial Age spouse2
            row += 1;
            style = this.gridDisplay[row, col];
            style.Text = "Initial Age spouse2:";
            style.HorizontalAlignment = GridHorizontalAlignment.Right;

            style = this.gridDisplay[row, col + 1];
            style.Text = "46";
            style.Font.Bold = true;
            style.Enabled = true;
            style.HorizontalAlignment = GridHorizontalAlignment.Left;

            //Initial savings balance
            row += 1;
            style = this.gridDisplay[row, col];
            style.Text = "Initial savings balance:";
            style.HorizontalAlignment = GridHorizontalAlignment.Right;

            style = this.gridDisplay[row, col + 1];
            style.CellValueType = typeof(double);
            style.Text = "400000";
            style.Format = "#,##0.00";
            style.Font.Bold = true;
            style.Enabled = true;
            style.HorizontalAlignment = GridHorizontalAlignment.Left;

            //return percentage1
            row += 1;
            style = this.gridDisplay[row, col];
            style.Text = "return percentage1:";
            style.HorizontalAlignment = GridHorizontalAlignment.Right;

            style = this.gridDisplay[row, col + 1];
            style.CellValueType = typeof(double);
            style.Text = "8";
            style.Format = "#,##0.00";
            style.Font.Bold = true;
            style.Enabled = true;
            style.HorizontalAlignment = GridHorizontalAlignment.Left;

            //return volatility1
            row += 1;
            style = this.gridDisplay[row, col];
            style.Text = "return volatility1:";
            style.HorizontalAlignment = GridHorizontalAlignment.Right;

            style = this.gridDisplay[row, col + 1];
            style.CellValueType = typeof(double);
            style.Text = "10";
            style.Format = "#,##0.00";
            style.Font.Bold = true;
            style.Enabled = true;
            style.HorizontalAlignment = GridHorizontalAlignment.Left;

            //return percentage2
            row += 1;
            style = this.gridDisplay[row, col];
            style.Text = "return percentage2:";
            style.HorizontalAlignment = GridHorizontalAlignment.Right;

            style = this.gridDisplay[row, col + 1];
            style.CellValueType = typeof(double);
            style.Text = "4";
            style.Format = "#,##0.00";
            style.Font.Bold = true;
            style.Enabled = true;
            style.HorizontalAlignment = GridHorizontalAlignment.Left;

            //return volatility2
            row += 1;
            style = this.gridDisplay[row, col];
            style.Text = "return volatility2:";
            style.HorizontalAlignment = GridHorizontalAlignment.Right;

            style = this.gridDisplay[row, col + 1];
            style.CellValueType = typeof(double);
            style.Text = "3";
            style.Format = "#,##0.00";
            style.Font.Bold = true;
            style.Enabled = true;
            style.HorizontalAlignment = GridHorizontalAlignment.Left;

            //income COLA
            row += 1;
            style = this.gridDisplay[row, col];
            style.Text = "income COLA:";
            style.HorizontalAlignment = GridHorizontalAlignment.Right;

            style = this.gridDisplay[row, col + 1];
            style.CellValueType = typeof(double);
            style.Text = "3";
            style.Format = "#,##0.00";
            style.Font.Bold = true;
            style.Enabled = true;
            style.HorizontalAlignment = GridHorizontalAlignment.Left;

            //expense COLA
            row += 1;
            style = this.gridDisplay[row, col];
            style.Text = "expense COLA:";
            style.HorizontalAlignment = GridHorizontalAlignment.Right;

            style = this.gridDisplay[row, col + 1];
            style.CellValueType = typeof(double);
            style.Text = "3";
            style.Format = "#,##0.00";
            style.Font.Bold = true;
            style.Enabled = true;
            style.HorizontalAlignment = GridHorizontalAlignment.Left;

            //SS age spouse1
            row += 1;
            style = this.gridDisplay[row, col];
            style.Text = "SS age spouse1:";
            style.HorizontalAlignment = GridHorizontalAlignment.Right;

            style = this.gridDisplay[row, col + 1];
            style.Text = "63";
            style.Font.Bold = true;
            style.Enabled = true;
            style.HorizontalAlignment = GridHorizontalAlignment.Left;

            //SS age spouse2
            row += 1;
            style = this.gridDisplay[row, col];
            style.Text = "SS age spouse2:";
            style.HorizontalAlignment = GridHorizontalAlignment.Right;

            style = this.gridDisplay[row, col + 1];
            style.Text = "63";
            style.Font.Bold = true;
            style.Enabled = true;
            style.HorizontalAlignment = GridHorizontalAlignment.Left;

            //SS initial amount (per month) spouse1
            row += 1;
            style = this.gridDisplay[row, col];
            style.Text = "SS initial amount (per month) spouse1:";
            style.HorizontalAlignment = GridHorizontalAlignment.Right;

            style = this.gridDisplay[row, col + 1];
            style.CellValueType = typeof(double);
            style.Text = "1300";
            style.Format = "#,##0.00";
            style.Font.Bold = true;
            style.Enabled = true;
            style.HorizontalAlignment = GridHorizontalAlignment.Left;

            //SS initial amount (% of spouse1) spouse2
            row += 1;
            style = this.gridDisplay[row, col];
            style.Text = "SS initial amount (% of spouse1) spouse2:";
            style.HorizontalAlignment = GridHorizontalAlignment.Right;

            style = this.gridDisplay[row, col + 1];
            style.CellValueType = typeof(double);
            style.Text = "75";
            style.Format = "#,##0.00";
            style.Font.Bold = true;
            style.Enabled = true;
            style.HorizontalAlignment = GridHorizontalAlignment.Left;

            //SS spouse1 dies
            row += 1;
            style = this.gridDisplay[row, col];
            style.Text = "spouse1 dies:";
            style.HorizontalAlignment = GridHorizontalAlignment.Right;

            style = this.gridDisplay[row, col + 1];
            style.Text = "71";
            style.Font.Bold = true;
            style.Enabled = true;
            style.HorizontalAlignment = GridHorizontalAlignment.Left;

            //SS spouse1 retires
            row += 1;
            style = this.gridDisplay[row, col];
            style.Text = "spouse1 retires:";
            style.HorizontalAlignment = GridHorizontalAlignment.Right;

            style = this.gridDisplay[row, col + 1];
            style.Text = "60";
            style.Font.Bold = true;
            style.Enabled = true;
            style.HorizontalAlignment = GridHorizontalAlignment.Left;

            //Initial Annual Draw
            row += 1;
            style = this.gridDisplay[row, col];
            style.Text = "initial Annual Draw:";
            style.HorizontalAlignment = GridHorizontalAlignment.Right;

            style = this.gridDisplay[row, col + 1];
            style.CellValueType = typeof(double);
            style.Text = "50000";
            style.Format = "#,##0.00";
            style.Font.Bold = true;
            style.Enabled = true;
            style.HorizontalAlignment = GridHorizontalAlignment.Left;

            //Random Behavior
            row += 1;
            style = this.gridDisplay[row, col];
            style.Text = "random behavior:";
            style.HorizontalAlignment = GridHorizontalAlignment.Right;

            style = this.gridDisplay[row, col + 1];
            style.CellValueType = typeof(int);
            style.CellValue = 1;
            style.Format = "0";
            style.Font.Bold = true;
            style.Enabled = true;
            style.HorizontalAlignment = GridHorizontalAlignment.Left;

            #endregion

            //set up results

            //Initial Year
            row = 6;
            col = 3;

            this.gridDisplay.ColWidths[col] = (int)DpiAware.LogicalToDeviceUnits(120);
            style = this.gridDisplay[row, col];
            style.Text = "Go Broke year:";
            style.HorizontalAlignment = GridHorizontalAlignment.Right;

            style = this.gridDisplay[row, col + 1];
            style.Text = "=Calc!A2";
            style.CellType = "FormulaCell";
            style.Font.Bold = true;
            style.Enabled = true;
            style.HorizontalAlignment = GridHorizontalAlignment.Left;

            row += 1;
            style = this.gridDisplay[row, col];
            style.Text = "Spouse1 Age:";
            style.HorizontalAlignment = GridHorizontalAlignment.Right;

            style = this.gridDisplay[row, col + 1];
            style.Text = "=Calc!A3";
            style.CellType = "FormulaCell";
            style.Font.Bold = true;
            style.Enabled = true;
            style.HorizontalAlignment = GridHorizontalAlignment.Left;

            row += 1;
            style = this.gridDisplay[row, col];
            style.Text = "Spouse2 Age:";
            style.HorizontalAlignment = GridHorizontalAlignment.Right;

            style = this.gridDisplay[row, col + 1];
            style.Text = "=Calc!A4";
            style.CellType = "FormulaCell";
            style.Font.Bold = true;
            style.Enabled = true;
            style.HorizontalAlignment = GridHorizontalAlignment.Left;

            row += 3;
            this.gridDisplay.CoveredRanges.Add(GridRangeInfo.Cells(row, col, row, col + 1));
            style = this.gridDisplay[row, col];
            style.Enabled = true;
            style.BorderMargins.Left = 30;
            style.BorderMargins.Right = 20;
            style.CellType = "PushButton";
            style.Description = "Probabilities";
            this.gridDisplay.PushButtonClick += new GridCellPushButtonClickEventHandler(gridDisplay_PushButtonClick);

            row += 1;
            row10 = row;
            style = this.gridDisplay[row, col];
            style.Text = ">= 10 years:";
            style.Enabled = false;
            style.HorizontalAlignment = GridHorizontalAlignment.Right;

            style = this.gridDisplay[row, col + 1];
            style.Text = "";
            style.Font.Bold = true;
            style.HorizontalAlignment = GridHorizontalAlignment.Left;

            row += 1;
            style = this.gridDisplay[row, col];
            style.Text = ">= 20 years:";
            style.Enabled = false;
            style.HorizontalAlignment = GridHorizontalAlignment.Right;

            style = this.gridDisplay[row, col + 1];
            style.Text = "";
            style.Font.Bold = true;
            style.HorizontalAlignment = GridHorizontalAlignment.Left;

            row += 1;
            style = this.gridDisplay[row, col];
            style.Text = ">= 30 years:";
            style.Enabled = false;
            style.HorizontalAlignment = GridHorizontalAlignment.Right;

            style = this.gridDisplay[row, col + 1];
            style.Text = "";
            style.Font.Bold = true;
            style.HorizontalAlignment = GridHorizontalAlignment.Left;

            row += 1;
            style = this.gridDisplay[row, col];
            style.Text = ">= 40 years:";
            style.Enabled = false;
            style.HorizontalAlignment = GridHorizontalAlignment.Right;

            style = this.gridDisplay[row, col + 1];
            style.Text = "";
            style.Font.Bold = true;
            style.HorizontalAlignment = GridHorizontalAlignment.Left;

            style = this.gridDisplay[row, col + 1];
            style.Text = "";
            style.CellType = "FormulaCell";
            style.Font.Bold = true;
            //	style.Enabled = true;
            style.HorizontalAlignment = GridHorizontalAlignment.Left;

        }

        int row10;
        private void gridDisplay_PushButtonClick(object sender, GridCellPushButtonClickEventArgs e)
        {
            int numTrials = 100;

            int count10 = 0;
            int count20 = 0;
            int count30 = 0;
            int count40 = 0;

            int col = 4;
            int currentAge = int.Parse(this.gridDisplay[7, 2].Text);
            int retireAge = int.Parse(this.gridDisplay[21, 2].Text);
            int row = 2 + retireAge - currentAge;

            double d;
            string s;

            this.gridDisplay.ConfirmChanges();

            GridProgressBarInfo progressBarEx1 = SetProgressBar(row10 + 4, col - 1);

            DateTime start = DateTime.Now;
            this.Cursor = Cursors.WaitCursor;
            for (int i = 0; i < numTrials; ++i)
            {
                this.gridDisplay[e.RowIndex, e.ColIndex].CellValue = 0;
                s = this.gridCalculations[row + 10, col].FormattedText;
                if (double.TryParse(s, NumberStyles.Any, null, out d) && d > 0)
                    count10 += 1;
                s = this.gridCalculations[row + 20, col].FormattedText;
                if (double.TryParse(s, NumberStyles.Any, null, out d) && d > 0)
                    count20 += 1;
                s = this.gridCalculations[row + 30, col].FormattedText;
                if (double.TryParse(s, NumberStyles.Any, null, out d) && d > 0)
                    count30 += 1;
                s = this.gridCalculations[row + 40, col].FormattedText;
                if (double.TryParse(s, NumberStyles.Any, null, out d) && d > 0)
                    count40 += 1;
                //System.Threading.Thread.Sleep(0);
                if (i % 10 == 0)
                    progressBarEx1.ProgressValue = i;
                Application.DoEvents();
            }
            this.Cursor = Cursors.Default;


            this.gridDisplay[row10, col].Text = string.Format("{0:P2}", ((float)count10) / numTrials);
            this.gridDisplay[row10 + 1, col].Text = string.Format("{0:P2}", ((float)count20) / numTrials);
            this.gridDisplay[row10 + 2, col].Text = string.Format("{0:P2}", ((float)count30) / numTrials);
            this.gridDisplay[row10 + 3, col].Text = string.Format("{0:P2}", ((float)count40) / numTrials);

            this.gridDisplay[row10 + 4, col - 1].CellType = "Static";
            this.gridDisplay[row10 + 4, col - 1].Font.Bold = true;

            this.gridDisplay[row10 + 4, col - 1].Text = string.Format("{0} runs in {1}", numTrials, DateTime.Now - start);
        }


        private GridProgressBarInfo SetProgressBar(int row, int col)
        {
            GridStyleInfo style1 = this.gridDisplay[row, col];

            this.gridDisplay.CoveredRanges.Add(GridRangeInfo.Cells(row, col, row, col + 1));
            style1.BorderMargins.Left = 30;
            style1.BorderMargins.Right = 20;

            GridProgressBarInfo progressBarEx1 = style1.ProgressBar;
            progressBarEx1.BeginUpdate();
            progressBarEx1.ProgressValue = 0;

            style1.CellType = "ProgressBar";
            style1.Themed = false;
            //style1.CellAppearance = GridCellAppearance.Raised;

            progressBarEx1.BackGradientEndColor = System.Drawing.SystemColors.ControlLightLight;
            progressBarEx1.BackGradientStartColor = System.Drawing.SystemColors.ControlDark;
            progressBarEx1.BackgroundStyle = Syncfusion.Windows.Forms.Tools.ProgressBarBackgroundStyles.VerticalGradient;
            progressBarEx1.BackMultipleColors = new System.Drawing.Color[] {
																			   System.Drawing.SystemColors.ControlDark,
																			  System.Drawing.SystemColors.ControlLightLight,
																			  System.Drawing.SystemColors.Control};

            progressBarEx1.ProgressStyle = Syncfusion.Windows.Forms.Tools.ProgressBarStyles.Tube;
            progressBarEx1.SegmentWidth = 10;
            progressBarEx1.StretchImage = false;
            progressBarEx1.StretchMultGrad = false;
            progressBarEx1.TextShadow = false;
            progressBarEx1.TubeEndColor = System.Drawing.SystemColors.Control;
            progressBarEx1.TubeStartColor = Color.Blue;//System.Drawing.SystemColors.ControlDark;
            progressBarEx1.EndUpdate();
            return progressBarEx1;
        }

        #endregion

        #region CalculationSheet

        private void SetUpCalcSheet()
        {
            //
            int row = 1;
            int col = 3;

            string colWithdrawal = GridRangeInfo.GetAlphaLabel(col);
            string colBalance = GridRangeInfo.GetAlphaLabel(col + 1);
            string colInvRate = GridRangeInfo.GetAlphaLabel(col + 2);
            string colYear = GridRangeInfo.GetAlphaLabel(col + 3);
            string colAge1 = GridRangeInfo.GetAlphaLabel(col + 4);
            string colAge2 = GridRangeInfo.GetAlphaLabel(col + 5);
            string colSS1 = GridRangeInfo.GetAlphaLabel(col + 6);
            string colSS2 = GridRangeInfo.GetAlphaLabel(col + 7);
            string colBroke = GridRangeInfo.GetAlphaLabel(col + 8);
            string colRand = GridRangeInfo.GetAlphaLabel(col + 9);



            //row 1
            this.gridCalculations[row, col].Text = "Withdrawal Jan 1";
            this.gridCalculations[row, col + 1].Text = "Balance Jan 2";
            this.gridCalculations[row, col + 2].Text = "Inv Return Rate";
            this.gridCalculations[row, col + 3].Text = "Year";
            this.gridCalculations[row, col + 4].Text = "Age spouse 1";
            this.gridCalculations[row, col + 5].Text = "Age spouse 2";
            this.gridCalculations[row, col + 6].Text = "SS spouse 1";
            this.gridCalculations[row, col + 7].Text = "SS spouse 2";
            this.gridCalculations[row, col + 8].Text = "Broke Year";
            this.gridCalculations[row, col + 9].Text = "Random #";


            //row 2
            row += 1;
            this.gridCalculations[row, col].Text = "0.00"; //assumes spouse1 is not retired at the start
            this.gridCalculations[row, col + 1].Text = "= InitialSavingsBalance";
            this.gridCalculations[row, col + 2].Text = string.Format("= (100+ReturnPercentage1+(1-2*{2}{1})*ReturnVolatility1)/100 * ({0}{1} < Spouse1Retires ) + (100+ReturnPercentage2+(1-2*{2}{1})*ReturnVolatility2)/100 * ({0}{1} >= Spouse1Retires ) ", colAge1, row, colRand);
            this.gridCalculations[row, col + 3].Text = "= InitialYear";
            this.gridCalculations[row, col + 4].Text = "= InitialAgeSpouse1";
            this.gridCalculations[row, col + 5].Text = "= InitialAgeSpouse2";
            this.gridCalculations[row, col + 6].Text = "0.00";
            this.gridCalculations[row, col + 7].Text = "0.00";
            this.gridCalculations[row, col + 8].Text = "0.00";
            this.gridCalculations[row, col + 9].Text = "= TriggerCell + (1-RandomBehavior)/2"; //always zero but used to trigger new random run

            this.SetUpNamedRanges();
            for (int i = row + 1; i < this.gridCalculations.RowCount; ++i)
            {
                if (engine.NamedRanges.ContainsKey("EXPENSECOLA"))
                    this.gridCalculations[i, col].Text = string.Format("= (100+(1-2*{4}{1})+ExpenseCOLA)/100 * {0}{1} + ({2}{3}=Spouse1Retires) * InitialAnnualDraw", colWithdrawal, i - 1, colAge1, i, colRand);
                if (engine.NamedRanges.ContainsKey("SPOUSE1DIES"))
                    this.gridCalculations[i, col + 1].Text = string.Format("=  {0}{1} * {2}{1}  - {3}{4} + ({5}{1} < Spouse1Dies) *  {6}{1} + {7}{1}", colBalance, i - 1, colInvRate, colWithdrawal, i, colAge1, colSS1, colSS2);
                if (engine.NamedRanges.ContainsKey("RETURNPERCENTAGE1"))
                    this.gridCalculations[i, col + 2].Text = string.Format("= (100+ReturnPercentage1+(1-2*{2}{1})*ReturnVolatility1)/100 * ({0}{1} < Spouse1Retires ) + (100+ReturnPercentage2+(1-2*{2}{1})*ReturnVolatility2)/100 * ({0}{1} >= Spouse1Retires ) ", colAge1, i, colRand);
                this.gridCalculations[i, col + 3].Text = string.Format("= {0}{1} + 1", colYear, i - 1);
                this.gridCalculations[i, col + 4].Text = string.Format("= {0}{1} + 1", colAge1, i - 1);
                this.gridCalculations[i, col + 5].Text = string.Format("= {0}{1} + 1", colAge2, i - 1);
                if (engine.NamedRanges.ContainsKey("INCOMECOLA"))
                    this.gridCalculations[i, col + 6].Text = string.Format("= (100+IncomeCOLA+(1-2*{3}{1}))/100 * {0}{1} + ({2}{1}=SSAgeSpouse1) * 12 * SSInitialAmountSpouse1", colSS1, i - 1, colAge1, colRand);
                this.gridCalculations[i, col + 7].Text = string.Format("= (100+IncomeCOLA+(1-2*{5}{1}))/100 * {0}{4} + ({2}{1}=SSAgeSpouse2) * SSInitialPercentageSpouse2/100 * {3}{1}", colSS2, i, colAge2, colSS1, i - 1, colRand);
                this.gridCalculations[i, col + 8].Text = string.Format("= ({0}{1}<0) * ({0}{2}>=0) * {3}{1}", colBalance, i, i - 1, colYear);
                if (engine.NamedRanges.ContainsKey("RANDOMBEHAVIOR"))
                    this.gridCalculations[i, col + 9].Text = string.Format("= RandomBehavior * Rand() + ${0}${1}", colRand, 2); //make setting row 2 trigger new Rand's
                //this.gridCalculations[i, 1].Text = string.Format("= d{0}-d{1}", i, i - 1); 
            }


            //make all cells potential formula cells
            this.gridCalculations.TableStyle.CellType = "FormulaCell";
            this.gridCalculations.TableStyle.Format = "#,##0.00";

            //years & age
            this.gridCalculations.ColStyles[col + 3].Format = "F0";
            this.gridCalculations.ColStyles[col + 4].Format = "F0";
            this.gridCalculations.ColStyles[col + 5].Format = "F0";

            //some answers
            this.gridCalculations[2, 1].Text = string.Format("= Max({0}2:{0}{1})", colBroke, this.gridCalculations.RowCount - 1);
            this.gridCalculations[3, 1].Text = string.Format("= SumIf({2}2:{2}{1}, \">0\", {0}2:{0}{1})", colAge1, this.gridCalculations.RowCount - 1, colBroke);
            this.gridCalculations[4, 1].Text = "= Max(0, A3 - InitialAgeSpouse1 + InitialAgeSpouse2)";

        }

        #endregion
    }
}

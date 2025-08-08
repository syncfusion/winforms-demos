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

namespace CrossSheetReference
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
        private GridAwareTextBox gridAwareTextBox1;
        private Syncfusion.Windows.Forms.Tools.CheckBoxAdv showFormula;
        private System.Windows.Forms.Label label1;
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
            if (DpiAware.GetCurrentDpi() > 96)
            {
                this.CaptionBarHeight = (int)DpiAware.LogicalToDeviceUnits(this.CaptionBarHeight);
            }
            this.GridSettings();
        }
        #endregion

        #region "GridSettings"
        /// <summary>
        /// Grid Settings for better look and feel
        /// </summary>
        private void GridSettings()
        {
            //Used to set default row height
            this.gridDisplay.DefaultRowHeight = (int)DpiAware.LogicalToDeviceUnits(22.0f);
            //Used to set selection mode in grid

            gridDisplay.ThemesEnabled = true;
            gridCalculations.ThemesEnabled = true;
            gridCalculations.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro;
            gridDisplay.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro;
            this.gridDisplay.BorderStyle = BorderStyle.FixedSingle;
            this.gridCalculations.BorderStyle = BorderStyle.FixedSingle;
            this.gridCalculations.Model.ColWidths.ResizeToFit(GridRangeInfo.Table());

            this.gridDisplay.Model.Options.DisplayEmptyColumns = true;
            this.gridDisplay.Model.Options.DisplayEmptyRows = true;

            //Settings to give Excel like Flat Look to the grid
            this.gridDisplay.Model.Options.DefaultGridBorderStyle = GridBorderStyle.Solid;
            this.gridCalculations.Model.Options.DefaultGridBorderStyle = GridBorderStyle.Solid;
            this.MetroColor = System.Drawing.Color.Transparent;

            //tab key navigation set as false to move the next control
            this.gridDisplay.WantTabKey = false;

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
            Syncfusion.Windows.Forms.Grid.GridRangeStyle gridRangeStyle1 = new Syncfusion.Windows.Forms.Grid.GridRangeStyle();
            Syncfusion.Windows.Forms.Grid.GridRangeStyle gridRangeStyle2 = new Syncfusion.Windows.Forms.Grid.GridRangeStyle();
            Syncfusion.Windows.Forms.Grid.GridRangeStyle gridRangeStyle3 = new Syncfusion.Windows.Forms.Grid.GridRangeStyle();
            Syncfusion.Windows.Forms.Grid.GridRangeStyle gridRangeStyle4 = new Syncfusion.Windows.Forms.Grid.GridRangeStyle();
            Syncfusion.Windows.Forms.Grid.GridRangeStyle gridRangeStyle5 = new Syncfusion.Windows.Forms.Grid.GridRangeStyle();
            Syncfusion.Windows.Forms.Grid.GridRangeStyle gridRangeStyle6 = new Syncfusion.Windows.Forms.Grid.GridRangeStyle();
            Syncfusion.Windows.Forms.Grid.GridRangeStyle gridRangeStyle7 = new Syncfusion.Windows.Forms.Grid.GridRangeStyle();
            Syncfusion.Windows.Forms.Grid.GridRangeStyle gridRangeStyle8 = new Syncfusion.Windows.Forms.Grid.GridRangeStyle();
            Syncfusion.Windows.Forms.Grid.GridRangeStyle gridRangeStyle9 = new Syncfusion.Windows.Forms.Grid.GridRangeStyle();
            Syncfusion.Windows.Forms.Grid.GridRangeStyle gridRangeStyle10 = new Syncfusion.Windows.Forms.Grid.GridRangeStyle();
            Syncfusion.Windows.Forms.Grid.GridRangeStyle gridRangeStyle11 = new Syncfusion.Windows.Forms.Grid.GridRangeStyle();
            Syncfusion.Windows.Forms.Grid.GridRangeStyle gridRangeStyle12 = new Syncfusion.Windows.Forms.Grid.GridRangeStyle();
            Syncfusion.Windows.Forms.Grid.GridRangeStyle gridRangeStyle13 = new Syncfusion.Windows.Forms.Grid.GridRangeStyle();
            Syncfusion.Windows.Forms.Grid.GridRangeStyle gridRangeStyle14 = new Syncfusion.Windows.Forms.Grid.GridRangeStyle();
            Syncfusion.Windows.Forms.Grid.GridRangeStyle gridRangeStyle15 = new Syncfusion.Windows.Forms.Grid.GridRangeStyle();
            Syncfusion.Windows.Forms.Grid.GridRangeStyle gridRangeStyle16 = new Syncfusion.Windows.Forms.Grid.GridRangeStyle();
            Syncfusion.Windows.Forms.Grid.GridRangeStyle gridRangeStyle17 = new Syncfusion.Windows.Forms.Grid.GridRangeStyle();
            Syncfusion.Windows.Forms.Grid.GridRangeStyle gridRangeStyle18 = new Syncfusion.Windows.Forms.Grid.GridRangeStyle();
            Syncfusion.Windows.Forms.Grid.GridRangeStyle gridRangeStyle19 = new Syncfusion.Windows.Forms.Grid.GridRangeStyle();
            Syncfusion.Windows.Forms.Grid.GridRangeStyle gridRangeStyle20 = new Syncfusion.Windows.Forms.Grid.GridRangeStyle();
            Syncfusion.Windows.Forms.Grid.GridRangeStyle gridRangeStyle21 = new Syncfusion.Windows.Forms.Grid.GridRangeStyle();
            Syncfusion.Windows.Forms.Grid.GridRangeStyle gridRangeStyle22 = new Syncfusion.Windows.Forms.Grid.GridRangeStyle();
            Syncfusion.Windows.Forms.Grid.GridRangeStyle gridRangeStyle23 = new Syncfusion.Windows.Forms.Grid.GridRangeStyle();
            Syncfusion.Windows.Forms.Grid.GridRangeStyle gridRangeStyle24 = new Syncfusion.Windows.Forms.Grid.GridRangeStyle();
            Syncfusion.Windows.Forms.Grid.GridRangeStyle gridRangeStyle25 = new Syncfusion.Windows.Forms.Grid.GridRangeStyle();
            Syncfusion.Windows.Forms.Grid.GridRangeStyle gridRangeStyle26 = new Syncfusion.Windows.Forms.Grid.GridRangeStyle();
            Syncfusion.Windows.Forms.Grid.GridRangeStyle gridRangeStyle27 = new Syncfusion.Windows.Forms.Grid.GridRangeStyle();
            Syncfusion.Windows.Forms.Grid.GridRangeStyle gridRangeStyle28 = new Syncfusion.Windows.Forms.Grid.GridRangeStyle();
            Syncfusion.Windows.Forms.Grid.GridRangeStyle gridRangeStyle29 = new Syncfusion.Windows.Forms.Grid.GridRangeStyle();
            Syncfusion.Windows.Forms.Grid.GridRangeStyle gridRangeStyle30 = new Syncfusion.Windows.Forms.Grid.GridRangeStyle();
            Syncfusion.Windows.Forms.Grid.GridRangeStyle gridRangeStyle31 = new Syncfusion.Windows.Forms.Grid.GridRangeStyle();
            Syncfusion.Windows.Forms.Grid.GridRangeStyle gridRangeStyle32 = new Syncfusion.Windows.Forms.Grid.GridRangeStyle();
            Syncfusion.Windows.Forms.Grid.GridRangeStyle gridRangeStyle33 = new Syncfusion.Windows.Forms.Grid.GridRangeStyle();
            Syncfusion.Windows.Forms.Grid.GridRangeStyle gridRangeStyle34 = new Syncfusion.Windows.Forms.Grid.GridRangeStyle();
            Syncfusion.Windows.Forms.Grid.GridRangeStyle gridRangeStyle35 = new Syncfusion.Windows.Forms.Grid.GridRangeStyle();
            Syncfusion.Windows.Forms.Grid.GridRangeStyle gridRangeStyle36 = new Syncfusion.Windows.Forms.Grid.GridRangeStyle();
            Syncfusion.Windows.Forms.Grid.GridRangeStyle gridRangeStyle37 = new Syncfusion.Windows.Forms.Grid.GridRangeStyle();
            Syncfusion.Windows.Forms.Grid.GridRangeStyle gridRangeStyle38 = new Syncfusion.Windows.Forms.Grid.GridRangeStyle();
            Syncfusion.Windows.Forms.Grid.GridRangeStyle gridRangeStyle39 = new Syncfusion.Windows.Forms.Grid.GridRangeStyle();
            Syncfusion.Windows.Forms.Grid.GridRangeStyle gridRangeStyle40 = new Syncfusion.Windows.Forms.Grid.GridRangeStyle();
            Syncfusion.Windows.Forms.Grid.GridRangeStyle gridRangeStyle41 = new Syncfusion.Windows.Forms.Grid.GridRangeStyle();
            Syncfusion.Windows.Forms.Grid.GridRangeStyle gridRangeStyle42 = new Syncfusion.Windows.Forms.Grid.GridRangeStyle();
            Syncfusion.Windows.Forms.Grid.GridRangeStyle gridRangeStyle43 = new Syncfusion.Windows.Forms.Grid.GridRangeStyle();
            Syncfusion.Windows.Forms.Grid.GridRangeStyle gridRangeStyle44 = new Syncfusion.Windows.Forms.Grid.GridRangeStyle();
            Syncfusion.Windows.Forms.Grid.GridRangeStyle gridRangeStyle45 = new Syncfusion.Windows.Forms.Grid.GridRangeStyle();
            Syncfusion.Windows.Forms.Grid.GridRangeStyle gridRangeStyle46 = new Syncfusion.Windows.Forms.Grid.GridRangeStyle();
            Syncfusion.Windows.Forms.Grid.GridRangeStyle gridRangeStyle47 = new Syncfusion.Windows.Forms.Grid.GridRangeStyle();
            Syncfusion.Windows.Forms.Grid.GridRangeStyle gridRangeStyle48 = new Syncfusion.Windows.Forms.Grid.GridRangeStyle();
            Syncfusion.Windows.Forms.Grid.GridRangeStyle gridRangeStyle49 = new Syncfusion.Windows.Forms.Grid.GridRangeStyle();
            Syncfusion.Windows.Forms.Grid.GridRangeStyle gridRangeStyle50 = new Syncfusion.Windows.Forms.Grid.GridRangeStyle();
            Syncfusion.Windows.Forms.Grid.GridRangeStyle gridRangeStyle51 = new Syncfusion.Windows.Forms.Grid.GridRangeStyle();
            Syncfusion.Windows.Forms.Grid.GridRangeStyle gridRangeStyle52 = new Syncfusion.Windows.Forms.Grid.GridRangeStyle();
            Syncfusion.Windows.Forms.Grid.GridRangeStyle gridRangeStyle53 = new Syncfusion.Windows.Forms.Grid.GridRangeStyle();
            Syncfusion.Windows.Forms.Grid.GridRangeStyle gridRangeStyle54 = new Syncfusion.Windows.Forms.Grid.GridRangeStyle();
            Syncfusion.Windows.Forms.Grid.GridRangeStyle gridRangeStyle55 = new Syncfusion.Windows.Forms.Grid.GridRangeStyle();
            Syncfusion.Windows.Forms.Grid.GridRangeStyle gridRangeStyle56 = new Syncfusion.Windows.Forms.Grid.GridRangeStyle();
            Syncfusion.Windows.Forms.Grid.GridRangeStyle gridRangeStyle57 = new Syncfusion.Windows.Forms.Grid.GridRangeStyle();
            Syncfusion.Windows.Forms.Grid.GridRangeStyle gridRangeStyle58 = new Syncfusion.Windows.Forms.Grid.GridRangeStyle();
            Syncfusion.Windows.Forms.Grid.GridRangeStyle gridRangeStyle59 = new Syncfusion.Windows.Forms.Grid.GridRangeStyle();
            Syncfusion.Windows.Forms.Grid.GridRangeStyle gridRangeStyle60 = new Syncfusion.Windows.Forms.Grid.GridRangeStyle();
            Syncfusion.Windows.Forms.Grid.GridRangeStyle gridRangeStyle61 = new Syncfusion.Windows.Forms.Grid.GridRangeStyle();
            Syncfusion.Windows.Forms.Grid.GridRangeStyle gridRangeStyle62 = new Syncfusion.Windows.Forms.Grid.GridRangeStyle();
            Syncfusion.Windows.Forms.Grid.GridRangeStyle gridRangeStyle63 = new Syncfusion.Windows.Forms.Grid.GridRangeStyle();
            Syncfusion.Windows.Forms.Grid.GridRangeStyle gridRangeStyle64 = new Syncfusion.Windows.Forms.Grid.GridRangeStyle();
            Syncfusion.Windows.Forms.Grid.GridRangeStyle gridRangeStyle65 = new Syncfusion.Windows.Forms.Grid.GridRangeStyle();
            Syncfusion.Windows.Forms.Grid.GridRangeStyle gridRangeStyle66 = new Syncfusion.Windows.Forms.Grid.GridRangeStyle();
            Syncfusion.Windows.Forms.Grid.GridRangeStyle gridRangeStyle67 = new Syncfusion.Windows.Forms.Grid.GridRangeStyle();
            Syncfusion.Windows.Forms.Grid.GridRangeStyle gridRangeStyle68 = new Syncfusion.Windows.Forms.Grid.GridRangeStyle();
            Syncfusion.Windows.Forms.Grid.GridRangeStyle gridRangeStyle69 = new Syncfusion.Windows.Forms.Grid.GridRangeStyle();
            Syncfusion.Windows.Forms.Grid.GridRangeStyle gridRangeStyle70 = new Syncfusion.Windows.Forms.Grid.GridRangeStyle();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo1 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo2 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo3 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo4 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo5 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo6 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo7 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo8 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo9 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo10 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo11 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo12 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo13 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo14 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo15 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo16 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo17 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo18 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo19 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo20 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo21 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo22 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo23 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo24 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo25 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo26 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo27 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo28 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo29 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo30 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo31 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo32 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo33 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo34 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo35 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo36 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo37 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo38 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo39 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo40 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo41 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo42 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo43 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo44 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo45 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo46 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo47 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo48 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo49 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            this.tabBarSplitterControl1 = new Syncfusion.Windows.Forms.TabBarSplitterControl();
            this.tabBarPage1 = new Syncfusion.Windows.Forms.TabBarPage();
            this.gridDisplay = new Syncfusion.Windows.Forms.Grid.GridControl();
            this.tabBarPage2 = new Syncfusion.Windows.Forms.TabBarPage();
            this.gridCalculations = new Syncfusion.Windows.Forms.Grid.GridControl();
            this.gridAwareTextBox1 = new Syncfusion.Windows.Forms.Grid.GridAwareTextBox();
            this.showFormula = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.label1 = new System.Windows.Forms.Label();
            this.tabBarSplitterControl1.SuspendLayout();
            this.tabBarPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridDisplay)).BeginInit();
            this.tabBarPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCalculations)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.showFormula)).BeginInit();
            this.SuspendLayout();
            // 
            // tabBarSplitterControl1
            // 
            this.tabBarSplitterControl1.ActivePageBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(157)))), ((int)(((byte)(217)))));
            this.tabBarSplitterControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tabBarSplitterControl1.BackColor = System.Drawing.Color.White;
            this.tabBarSplitterControl1.BeforeTouchSize = new System.Drawing.Size(864, 487);
            this.tabBarSplitterControl1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tabBarSplitterControl1.Controls.Add(this.tabBarPage1);
            this.tabBarSplitterControl1.Controls.Add(this.tabBarPage2);
            this.tabBarSplitterControl1.EnabledColor = System.Drawing.SystemColors.WindowText;
            this.tabBarSplitterControl1.GridOfficeScrollBars = Syncfusion.Windows.Forms.OfficeScrollBars.Metro;
            this.tabBarSplitterControl1.Location = new System.Drawing.Point(12, 48);
            this.tabBarSplitterControl1.Name = "tabBarSplitterControl1";
            this.tabBarSplitterControl1.Size = new System.Drawing.Size(864, 487);
            this.tabBarSplitterControl1.SizeFactor = 1D;
            this.tabBarSplitterControl1.SplitBars = Syncfusion.Windows.Forms.DynamicSplitBars.None;
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
            this.tabBarPage1.SplitBars = Syncfusion.Windows.Forms.DynamicSplitBars.None;
            this.tabBarPage1.TabBackColor = System.Drawing.SystemColors.Control;
            this.tabBarPage1.TabBarColor = System.Drawing.Color.Empty;
            this.tabBarPage1.TabMaxWidth = (int)DpiAware.LogicalToDeviceUnits(100.0f);
            this.tabBarPage1.Text = "Display";
            this.tabBarPage1.ThemesEnabled = true;
            // 
            // gridDisplay
            // 
            this.gridDisplay.DpiAware = true;
            this.gridDisplay.AllowSelection = ((Syncfusion.Windows.Forms.Grid.GridSelectionFlags)(((((Syncfusion.Windows.Forms.Grid.GridSelectionFlags.Table | Syncfusion.Windows.Forms.Grid.GridSelectionFlags.Cell)
                        | Syncfusion.Windows.Forms.Grid.GridSelectionFlags.Shift)
                        | Syncfusion.Windows.Forms.Grid.GridSelectionFlags.Keyboard)
                        | Syncfusion.Windows.Forms.Grid.GridSelectionFlags.AlphaBlend)));
            this.gridDisplay.AlphaBlendSelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(94)))), ((int)(((byte)(171)))), ((int)(((byte)(222)))));
            this.gridDisplay.BackColor = System.Drawing.Color.White;
            this.gridDisplay.ColWidthEntries.AddRange(new Syncfusion.Windows.Forms.Grid.GridColWidth[] {
            new Syncfusion.Windows.Forms.Grid.GridColWidth(0, 35),
            new Syncfusion.Windows.Forms.Grid.GridColWidth(1, 199),
            new Syncfusion.Windows.Forms.Grid.GridColWidth(2, 82),
            new Syncfusion.Windows.Forms.Grid.GridColWidth(3, 135)});
            this.gridDisplay.CoveredRanges.AddRange(new Syncfusion.Windows.Forms.Grid.GridRangeInfo[] {
            Syncfusion.Windows.Forms.Grid.GridRangeInfo.Cells(3, 1, 3, 4)});
            this.gridDisplay.DefaultGridBorderStyle = Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid;
            this.gridDisplay.FillSplitterPane = true;
            this.gridDisplay.FloatCellsMode = Syncfusion.Windows.Forms.Grid.GridFloatCellsMode.OnDemandCalculation;
            this.gridDisplay.Font = new System.Drawing.Font("Arial", 9.75F);
            this.gridDisplay.ForeColor = System.Drawing.Color.MidnightBlue;
            this.gridDisplay.GridOfficeScrollBars = Syncfusion.Windows.Forms.OfficeScrollBars.Metro;
            this.gridDisplay.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro;
            this.gridDisplay.DefaultRowHeight = (int)DpiAware.LogicalToDeviceUnits(20.0f);
            this.gridDisplay.DefaultColWidth = (int)DpiAware.LogicalToDeviceUnits(70.0f);
            this.gridDisplay.Location = new System.Drawing.Point(0, 0);
            this.gridDisplay.MetroScrollBars = true;
            this.gridDisplay.Name = "gridDisplay";
            this.gridDisplay.Properties.ForceImmediateRepaint = false;
            this.gridDisplay.Properties.GridLineColor = System.Drawing.Color.LightGray;
            this.gridDisplay.Properties.MarkColHeader = false;
            this.gridDisplay.Properties.MarkRowHeader = false;
            gridRangeStyle1.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table();
            gridRangeStyle1.StyleInfo.Font.Bold = false;
            gridRangeStyle1.StyleInfo.Font.Facename = "Arial";
            gridRangeStyle1.StyleInfo.Font.Italic = false;
            gridRangeStyle1.StyleInfo.Font.Size = 9.75F;
            gridRangeStyle1.StyleInfo.Font.Strikeout = false;
            gridRangeStyle1.StyleInfo.Font.Underline = false;
            gridRangeStyle1.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point;
            gridRangeStyle2.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table();
            gridRangeStyle2.StyleInfo.Font.Bold = false;
            gridRangeStyle2.StyleInfo.Font.Facename = "Arial";
            gridRangeStyle2.StyleInfo.Font.Italic = false;
            gridRangeStyle2.StyleInfo.Font.Size = 9.75F;
            gridRangeStyle2.StyleInfo.Font.Strikeout = false;
            gridRangeStyle2.StyleInfo.Font.Underline = false;
            gridRangeStyle2.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point;
            gridRangeStyle3.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table();
            gridRangeStyle3.StyleInfo.Font.Bold = false;
            gridRangeStyle3.StyleInfo.Font.Facename = "Arial";
            gridRangeStyle3.StyleInfo.Font.Italic = false;
            gridRangeStyle3.StyleInfo.Font.Size = 9.75F;
            gridRangeStyle3.StyleInfo.Font.Strikeout = false;
            gridRangeStyle3.StyleInfo.Font.Underline = false;
            gridRangeStyle3.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point;
            gridRangeStyle4.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table();
            gridRangeStyle4.StyleInfo.Font.Bold = false;
            gridRangeStyle4.StyleInfo.Font.Facename = "Arial";
            gridRangeStyle4.StyleInfo.Font.Italic = false;
            gridRangeStyle4.StyleInfo.Font.Size = 9.75F;
            gridRangeStyle4.StyleInfo.Font.Strikeout = false;
            gridRangeStyle4.StyleInfo.Font.Underline = false;
            gridRangeStyle4.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point;
            gridRangeStyle5.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table();
            gridRangeStyle5.StyleInfo.Font.Bold = false;
            gridRangeStyle5.StyleInfo.Font.Facename = "Arial";
            gridRangeStyle5.StyleInfo.Font.Italic = false;
            gridRangeStyle5.StyleInfo.Font.Size = 9.75F;
            gridRangeStyle5.StyleInfo.Font.Strikeout = false;
            gridRangeStyle5.StyleInfo.Font.Underline = false;
            gridRangeStyle5.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point;
            gridRangeStyle6.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table();
            gridRangeStyle6.StyleInfo.Font.Bold = false;
            gridRangeStyle6.StyleInfo.Font.Facename = "Arial";
            gridRangeStyle6.StyleInfo.Font.Italic = false;
            gridRangeStyle6.StyleInfo.Font.Size = 9.75F;
            gridRangeStyle6.StyleInfo.Font.Strikeout = false;
            gridRangeStyle6.StyleInfo.Font.Underline = false;
            gridRangeStyle6.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point;
            gridRangeStyle7.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table();
            gridRangeStyle7.StyleInfo.Font.Bold = false;
            gridRangeStyle7.StyleInfo.Font.Facename = "Arial";
            gridRangeStyle7.StyleInfo.Font.Italic = false;
            gridRangeStyle7.StyleInfo.Font.Size = 9.75F;
            gridRangeStyle7.StyleInfo.Font.Strikeout = false;
            gridRangeStyle7.StyleInfo.Font.Underline = false;
            gridRangeStyle7.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point;
            gridRangeStyle8.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table();
            gridRangeStyle8.StyleInfo.Font.Bold = false;
            gridRangeStyle8.StyleInfo.Font.Facename = "Arial";
            gridRangeStyle8.StyleInfo.Font.Italic = false;
            gridRangeStyle8.StyleInfo.Font.Size = 9.75F;
            gridRangeStyle8.StyleInfo.Font.Strikeout = false;
            gridRangeStyle8.StyleInfo.Font.Underline = false;
            gridRangeStyle8.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point;
            gridRangeStyle9.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table();
            gridRangeStyle9.StyleInfo.Font.Bold = false;
            gridRangeStyle9.StyleInfo.Font.Facename = "Arial";
            gridRangeStyle9.StyleInfo.Font.Italic = false;
            gridRangeStyle9.StyleInfo.Font.Size = 9.75F;
            gridRangeStyle9.StyleInfo.Font.Strikeout = false;
            gridRangeStyle9.StyleInfo.Font.Underline = false;
            gridRangeStyle9.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point;
            gridRangeStyle10.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table();
            gridRangeStyle10.StyleInfo.Font.Bold = false;
            gridRangeStyle10.StyleInfo.Font.Facename = "Arial";
            gridRangeStyle10.StyleInfo.Font.Italic = false;
            gridRangeStyle10.StyleInfo.Font.Size = 9.75F;
            gridRangeStyle10.StyleInfo.Font.Strikeout = false;
            gridRangeStyle10.StyleInfo.Font.Underline = false;
            gridRangeStyle10.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point;
            gridRangeStyle11.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table();
            gridRangeStyle11.StyleInfo.Font.Bold = false;
            gridRangeStyle11.StyleInfo.Font.Facename = "Arial";
            gridRangeStyle11.StyleInfo.Font.Italic = false;
            gridRangeStyle11.StyleInfo.Font.Size = 9.75F;
            gridRangeStyle11.StyleInfo.Font.Strikeout = false;
            gridRangeStyle11.StyleInfo.Font.Underline = false;
            gridRangeStyle11.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point;
            gridRangeStyle12.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table();
            gridRangeStyle12.StyleInfo.Font.Bold = false;
            gridRangeStyle12.StyleInfo.Font.Facename = "Arial";
            gridRangeStyle12.StyleInfo.Font.Italic = false;
            gridRangeStyle12.StyleInfo.Font.Size = 9.75F;
            gridRangeStyle12.StyleInfo.Font.Strikeout = false;
            gridRangeStyle12.StyleInfo.Font.Underline = false;
            gridRangeStyle12.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point;
            gridRangeStyle13.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table();
            gridRangeStyle13.StyleInfo.Font.Bold = false;
            gridRangeStyle13.StyleInfo.Font.Facename = "Arial";
            gridRangeStyle13.StyleInfo.Font.Italic = false;
            gridRangeStyle13.StyleInfo.Font.Size = 9.75F;
            gridRangeStyle13.StyleInfo.Font.Strikeout = false;
            gridRangeStyle13.StyleInfo.Font.Underline = false;
            gridRangeStyle13.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point;
            gridRangeStyle14.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table();
            gridRangeStyle14.StyleInfo.Font.Bold = false;
            gridRangeStyle14.StyleInfo.Font.Facename = "Verdana";
            gridRangeStyle14.StyleInfo.Font.Italic = false;
            gridRangeStyle14.StyleInfo.Font.Size = 9.75F;
            gridRangeStyle14.StyleInfo.Font.Strikeout = false;
            gridRangeStyle14.StyleInfo.Font.Underline = false;
            gridRangeStyle14.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point;
            gridRangeStyle15.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table();
            gridRangeStyle15.StyleInfo.Font.Bold = false;
            gridRangeStyle15.StyleInfo.Font.Facename = "Arial";
            gridRangeStyle15.StyleInfo.Font.Italic = false;
            gridRangeStyle15.StyleInfo.Font.Size = 9.75F;
            gridRangeStyle15.StyleInfo.Font.Strikeout = false;
            gridRangeStyle15.StyleInfo.Font.Underline = false;
            gridRangeStyle15.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point;
            gridRangeStyle16.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table();
            gridRangeStyle16.StyleInfo.Font.Bold = false;
            gridRangeStyle16.StyleInfo.Font.Facename = "Arial";
            gridRangeStyle16.StyleInfo.Font.Italic = false;
            gridRangeStyle16.StyleInfo.Font.Size = 9.75F;
            gridRangeStyle16.StyleInfo.Font.Strikeout = false;
            gridRangeStyle16.StyleInfo.Font.Underline = false;
            gridRangeStyle16.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point;
            gridRangeStyle17.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Col(1);
            gridRangeStyle17.StyleInfo.HorizontalAlignment = Syncfusion.Windows.Forms.Grid.GridHorizontalAlignment.Right;
            gridRangeStyle17.StyleInfo.Text = "";
            gridRangeStyle18.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Col(2);
            gridRangeStyle18.StyleInfo.Font.Bold = true;
            gridRangeStyle19.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Col(3);
            gridRangeStyle19.StyleInfo.HorizontalAlignment = Syncfusion.Windows.Forms.Grid.GridHorizontalAlignment.Right;
            gridRangeStyle20.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Col(4);
            gridRangeStyle20.StyleInfo.Font.Bold = true;
            gridRangeStyle21.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Cell(3, 1);
            gridRangeStyle21.StyleInfo.Font.Bold = true;
            gridRangeStyle21.StyleInfo.HorizontalAlignment = Syncfusion.Windows.Forms.Grid.GridHorizontalAlignment.Center;
            gridRangeStyle21.StyleInfo.Text = "Payroll";
            gridRangeStyle21.StyleInfo.TextColor = System.Drawing.Color.DodgerBlue;
            gridRangeStyle22.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Cell(3, 2);
            gridRangeStyle22.StyleInfo.Font.Bold = true;
            gridRangeStyle22.StyleInfo.HorizontalAlignment = Syncfusion.Windows.Forms.Grid.GridHorizontalAlignment.Center;
            gridRangeStyle22.StyleInfo.Text = "";
            gridRangeStyle22.StyleInfo.TextColor = System.Drawing.Color.DodgerBlue;
            gridRangeStyle23.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Cells(3, 3, 3, 4);
            gridRangeStyle23.StyleInfo.TextColor = System.Drawing.Color.DodgerBlue;
            gridRangeStyle24.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Cell(4, 0);
            gridRangeStyle24.StyleInfo.Text = "4";
            gridRangeStyle25.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Cells(4, 1, 4, 4);
            gridRangeStyle25.StyleInfo.Borders.Top = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Standard, System.Drawing.SystemColors.WindowFrame);
            gridRangeStyle26.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Cell(5, 0);
            gridRangeStyle26.StyleInfo.Text = "5";
            gridRangeStyle27.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Cells(5, 1, 5, 2);
            gridRangeStyle27.StyleInfo.Borders.Top = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Standard, System.Drawing.SystemColors.WindowFrame);
            gridRangeStyle27.StyleInfo.Text = "";
            gridRangeStyle28.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Cells(5, 3, 5, 4);
            gridRangeStyle28.StyleInfo.Borders.Top = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Standard, System.Drawing.SystemColors.WindowFrame);
            gridRangeStyle29.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Cell(6, 0);
            gridRangeStyle29.StyleInfo.Text = "6";
            gridRangeStyle30.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Cell(6, 1);
            gridRangeStyle30.StyleInfo.Borders.Top = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Standard, System.Drawing.SystemColors.WindowFrame);
            gridRangeStyle30.StyleInfo.Text = "Name:";
            gridRangeStyle31.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Cells(6, 2, 9, 2);
            gridRangeStyle31.StyleInfo.Borders.Top = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Standard, System.Drawing.SystemColors.WindowFrame);
            gridRangeStyle31.StyleInfo.Text = "";
            gridRangeStyle32.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Cell(6, 3);
            gridRangeStyle32.StyleInfo.Borders.Top = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Standard, System.Drawing.SystemColors.WindowFrame);
            gridRangeStyle32.StyleInfo.Text = "DA:";
            gridRangeStyle33.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Cells(6, 4, 20, 4);
            gridRangeStyle33.StyleInfo.Borders.Top = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Standard, System.Drawing.SystemColors.WindowFrame);
            gridRangeStyle34.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Cell(7, 0);
            gridRangeStyle34.StyleInfo.Text = "7";
            gridRangeStyle35.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Cell(7, 1);
            gridRangeStyle35.StyleInfo.Borders.Top = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Standard, System.Drawing.SystemColors.WindowFrame);
            gridRangeStyle35.StyleInfo.Text = "Qualification:";
            gridRangeStyle36.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Cell(7, 3);
            gridRangeStyle36.StyleInfo.Borders.Top = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Standard, System.Drawing.SystemColors.WindowFrame);
            gridRangeStyle36.StyleInfo.Text = "Gross Pay:";
            gridRangeStyle37.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Cell(8, 0);
            gridRangeStyle37.StyleInfo.Text = "8";
            gridRangeStyle38.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Cell(8, 1);
            gridRangeStyle38.StyleInfo.Borders.Top = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Standard, System.Drawing.SystemColors.WindowFrame);
            gridRangeStyle38.StyleInfo.Text = "Experience:";
            gridRangeStyle39.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Cell(8, 3);
            gridRangeStyle39.StyleInfo.Borders.Top = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Standard, System.Drawing.SystemColors.WindowFrame);
            gridRangeStyle39.StyleInfo.Text = "PF:";
            gridRangeStyle40.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Cell(9, 0);
            gridRangeStyle40.StyleInfo.Text = "9";
            gridRangeStyle41.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Cell(9, 1);
            gridRangeStyle41.StyleInfo.Borders.Top = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Standard, System.Drawing.SystemColors.WindowFrame);
            gridRangeStyle41.StyleInfo.Text = "Basic Pay:";
            gridRangeStyle42.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Cell(9, 3);
            gridRangeStyle42.StyleInfo.Borders.Top = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Standard, System.Drawing.SystemColors.WindowFrame);
            gridRangeStyle42.StyleInfo.Text = "Net Pay:";
            gridRangeStyle43.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Cell(10, 0);
            gridRangeStyle43.StyleInfo.Text = "10";
            gridRangeStyle44.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Cells(10, 1, 10, 2);
            gridRangeStyle44.StyleInfo.Borders.Top = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Standard, System.Drawing.SystemColors.WindowFrame);
            gridRangeStyle45.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Cell(10, 3);
            gridRangeStyle45.StyleInfo.Borders.Top = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Standard, System.Drawing.SystemColors.WindowFrame);
            gridRangeStyle45.StyleInfo.Text = "Annual Income:";
            gridRangeStyle46.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Cell(11, 0);
            gridRangeStyle46.StyleInfo.Text = "11";
            gridRangeStyle47.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Cell(11, 1);
            gridRangeStyle47.StyleInfo.Borders.Top = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Standard, System.Drawing.SystemColors.WindowFrame);
            gridRangeStyle47.StyleInfo.Font.Underline = true;
            gridRangeStyle47.StyleInfo.Text = "LIC Policy Details";
            gridRangeStyle48.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Cells(11, 2, 11, 4);
            gridRangeStyle48.StyleInfo.Borders.Top = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Standard, System.Drawing.SystemColors.WindowFrame);
            gridRangeStyle49.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Cell(12, 0);
            gridRangeStyle49.StyleInfo.Text = "12";
            gridRangeStyle50.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Cell(12, 1);
            gridRangeStyle50.StyleInfo.Borders.Top = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Standard, System.Drawing.SystemColors.WindowFrame);
            gridRangeStyle50.StyleInfo.Text = "Policy No:";
            gridRangeStyle51.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Cells(12, 2, 14, 2);
            gridRangeStyle51.StyleInfo.Borders.Top = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Standard, System.Drawing.SystemColors.WindowFrame);
            gridRangeStyle51.StyleInfo.Text = "";
            gridRangeStyle52.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Cells(12, 3, 20, 4);
            gridRangeStyle52.StyleInfo.Borders.Top = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Standard, System.Drawing.SystemColors.WindowFrame);
            gridRangeStyle53.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Cell(13, 0);
            gridRangeStyle53.StyleInfo.Text = "13";
            gridRangeStyle54.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Cell(13, 1);
            gridRangeStyle54.StyleInfo.Borders.Top = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Standard, System.Drawing.SystemColors.WindowFrame);
            gridRangeStyle54.StyleInfo.Text = "Policy Type:";
            gridRangeStyle55.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Cell(14, 0);
            gridRangeStyle55.StyleInfo.Text = "14";
            gridRangeStyle56.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Cell(14, 1);
            gridRangeStyle56.StyleInfo.Borders.Top = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Standard, System.Drawing.SystemColors.WindowFrame);
            gridRangeStyle56.StyleInfo.Text = "Premium:";
            gridRangeStyle57.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Cell(15, 0);
            gridRangeStyle57.StyleInfo.Text = "15";
            gridRangeStyle58.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Cells(15, 1, 15, 4);
            gridRangeStyle58.StyleInfo.Borders.Top = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Standard, System.Drawing.SystemColors.WindowFrame);
            gridRangeStyle59.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Cell(16, 0);
            gridRangeStyle59.StyleInfo.Text = "16";
            gridRangeStyle60.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Cell(16, 1);
            gridRangeStyle60.StyleInfo.Borders.Top = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Standard, System.Drawing.SystemColors.WindowFrame);
            gridRangeStyle60.StyleInfo.Font.Underline = true;
            gridRangeStyle60.StyleInfo.HorizontalAlignment = Syncfusion.Windows.Forms.Grid.GridHorizontalAlignment.Right;
            gridRangeStyle60.StyleInfo.Text = "Personal Loan Details";
            gridRangeStyle61.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Cells(16, 2, 16, 4);
            gridRangeStyle61.StyleInfo.Borders.Top = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Standard, System.Drawing.SystemColors.WindowFrame);
            gridRangeStyle62.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Cell(17, 0);
            gridRangeStyle62.StyleInfo.Text = "17";
            gridRangeStyle63.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Cell(17, 1);
            gridRangeStyle63.StyleInfo.Borders.Top = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Standard, System.Drawing.SystemColors.WindowFrame);
            gridRangeStyle63.StyleInfo.Text = "Loan No:";
            gridRangeStyle64.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Cells(17, 2, 19, 2);
            gridRangeStyle64.StyleInfo.Borders.Top = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Standard, System.Drawing.SystemColors.WindowFrame);
            gridRangeStyle64.StyleInfo.Text = "";
            gridRangeStyle65.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Cell(18, 0);
            gridRangeStyle65.StyleInfo.Text = "18";
            gridRangeStyle66.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Cell(18, 1);
            gridRangeStyle66.StyleInfo.Borders.Top = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Standard, System.Drawing.SystemColors.WindowFrame);
            gridRangeStyle66.StyleInfo.Text = "Loan Amount:";
            gridRangeStyle67.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Cell(19, 0);
            gridRangeStyle67.StyleInfo.Text = "19";
            gridRangeStyle68.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Cell(19, 1);
            gridRangeStyle68.StyleInfo.Borders.Top = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Standard, System.Drawing.SystemColors.WindowFrame);
            gridRangeStyle68.StyleInfo.Text = "Monthly Due:";
            gridRangeStyle69.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Cell(20, 0);
            gridRangeStyle69.StyleInfo.Text = "20";
            gridRangeStyle70.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Cells(20, 1, 20, 4);
            gridRangeStyle70.StyleInfo.Borders.Top = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Standard, System.Drawing.SystemColors.WindowFrame);
            this.gridDisplay.RangeStyles.AddRange(new Syncfusion.Windows.Forms.Grid.GridRangeStyle[] {
            gridRangeStyle1,
            gridRangeStyle2,
            gridRangeStyle3,
            gridRangeStyle4,
            gridRangeStyle5,
            gridRangeStyle6,
            gridRangeStyle7,
            gridRangeStyle8,
            gridRangeStyle9,
            gridRangeStyle10,
            gridRangeStyle11,
            gridRangeStyle12,
            gridRangeStyle13,
            gridRangeStyle14,
            gridRangeStyle15,
            gridRangeStyle16,
            gridRangeStyle17,
            gridRangeStyle18,
            gridRangeStyle19,
            gridRangeStyle20,
            gridRangeStyle21,
            gridRangeStyle22,
            gridRangeStyle23,
            gridRangeStyle24,
            gridRangeStyle25,
            gridRangeStyle26,
            gridRangeStyle27,
            gridRangeStyle28,
            gridRangeStyle29,
            gridRangeStyle30,
            gridRangeStyle31,
            gridRangeStyle32,
            gridRangeStyle33,
            gridRangeStyle34,
            gridRangeStyle35,
            gridRangeStyle36,
            gridRangeStyle37,
            gridRangeStyle38,
            gridRangeStyle39,
            gridRangeStyle40,
            gridRangeStyle41,
            gridRangeStyle42,
            gridRangeStyle43,
            gridRangeStyle44,
            gridRangeStyle45,
            gridRangeStyle46,
            gridRangeStyle47,
            gridRangeStyle48,
            gridRangeStyle49,
            gridRangeStyle50,
            gridRangeStyle51,
            gridRangeStyle52,
            gridRangeStyle53,
            gridRangeStyle54,
            gridRangeStyle55,
            gridRangeStyle56,
            gridRangeStyle57,
            gridRangeStyle58,
            gridRangeStyle59,
            gridRangeStyle60,
            gridRangeStyle61,
            gridRangeStyle62,
            gridRangeStyle63,
            gridRangeStyle64,
            gridRangeStyle65,
            gridRangeStyle66,
            gridRangeStyle67,
            gridRangeStyle68,
            gridRangeStyle69,
            gridRangeStyle70});
            this.gridDisplay.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.gridDisplay.RowCount = 20;
            this.gridDisplay.RowHeightEntries.AddRange(new Syncfusion.Windows.Forms.Grid.GridRowHeight[] {
            new Syncfusion.Windows.Forms.Grid.GridRowHeight(0, 21)});
            this.gridDisplay.SerializeCellsBehavior = Syncfusion.Windows.Forms.Grid.GridSerializeCellsBehavior.SerializeAsRangeStylesIntoCode;
            this.gridDisplay.Size = new System.Drawing.Size(847, 470);
            this.gridDisplay.SmartSizeBox = false;
            this.gridDisplay.ThemesEnabled = true;
            // 
            // tabBarPage2
            // 
            this.tabBarPage2.Controls.Add(this.gridCalculations);
            this.tabBarPage2.Location = new System.Drawing.Point(0, 0);
            this.tabBarPage2.Name = "tabBarPage2";
            this.tabBarPage2.SplitBars = ((Syncfusion.Windows.Forms.DynamicSplitBars)((Syncfusion.Windows.Forms.DynamicSplitBars.SplitRows | Syncfusion.Windows.Forms.DynamicSplitBars.SplitColumns)));
            this.tabBarPage2.TabBackColor = System.Drawing.SystemColors.Control;
            this.tabBarPage2.TabBarColor = System.Drawing.Color.Empty;
            this.tabBarPage2.TabMaxWidth = (int)DpiAware.LogicalToDeviceUnits(100.0f);
            this.tabBarPage2.Text = "Calculations";
            this.tabBarPage2.ThemesEnabled = true;
            // 
            // gridCalculations
            // 
            this.gridCalculations.DpiAware = true;
            this.gridCalculations.AllowSelection = ((Syncfusion.Windows.Forms.Grid.GridSelectionFlags)(((((Syncfusion.Windows.Forms.Grid.GridSelectionFlags.Table | Syncfusion.Windows.Forms.Grid.GridSelectionFlags.Cell)
                        | Syncfusion.Windows.Forms.Grid.GridSelectionFlags.Shift)
                        | Syncfusion.Windows.Forms.Grid.GridSelectionFlags.Keyboard)
                        | Syncfusion.Windows.Forms.Grid.GridSelectionFlags.AlphaBlend)));
            this.gridCalculations.AlphaBlendSelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(94)))), ((int)(((byte)(171)))), ((int)(((byte)(222)))));
            this.gridCalculations.BackColor = System.Drawing.Color.White;
            this.gridCalculations.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gridCalculations.ColWidthEntries.AddRange(new Syncfusion.Windows.Forms.Grid.GridColWidth[] {
            new Syncfusion.Windows.Forms.Grid.GridColWidth(0, 35),
            new Syncfusion.Windows.Forms.Grid.GridColWidth(2, 139),
            new Syncfusion.Windows.Forms.Grid.GridColWidth(3, 79),
            new Syncfusion.Windows.Forms.Grid.GridColWidth(4, 70)});
            this.gridCalculations.DefaultGridBorderStyle = Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid;
            this.gridCalculations.FillSplitterPane = true;
            this.gridCalculations.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.gridCalculations.ForeColor = System.Drawing.Color.MidnightBlue;
            gridCellInfo1.Col = -1;
            gridCellInfo1.Row = -1;
            gridCellInfo1.StyleInfo.Font.Bold = false;
            gridCellInfo1.StyleInfo.Font.Facename = "Verdana";
            gridCellInfo1.StyleInfo.Font.Italic = false;
            gridCellInfo1.StyleInfo.Font.Size = 8.25F;
            gridCellInfo1.StyleInfo.Font.Strikeout = false;
            gridCellInfo1.StyleInfo.Font.Underline = false;
            gridCellInfo1.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point;
            gridCellInfo2.Col = -1;
            gridCellInfo2.Row = -1;
            gridCellInfo2.StyleInfo.Font.Bold = false;
            gridCellInfo2.StyleInfo.Font.Facename = "Verdana";
            gridCellInfo2.StyleInfo.Font.Italic = false;
            gridCellInfo2.StyleInfo.Font.Size = 8.25F;
            gridCellInfo2.StyleInfo.Font.Strikeout = false;
            gridCellInfo2.StyleInfo.Font.Underline = false;
            gridCellInfo2.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point;
            gridCellInfo3.Col = -1;
            gridCellInfo3.Row = -1;
            gridCellInfo3.StyleInfo.Font.Bold = false;
            gridCellInfo3.StyleInfo.Font.Facename = "Verdana";
            gridCellInfo3.StyleInfo.Font.Italic = false;
            gridCellInfo3.StyleInfo.Font.Size = 8.25F;
            gridCellInfo3.StyleInfo.Font.Strikeout = false;
            gridCellInfo3.StyleInfo.Font.Underline = false;
            gridCellInfo3.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point;
            gridCellInfo4.Col = -1;
            gridCellInfo4.Row = -1;
            gridCellInfo4.StyleInfo.Font.Bold = false;
            gridCellInfo4.StyleInfo.Font.Facename = "Verdana";
            gridCellInfo4.StyleInfo.Font.Italic = false;
            gridCellInfo4.StyleInfo.Font.Size = 8.25F;
            gridCellInfo4.StyleInfo.Font.Strikeout = false;
            gridCellInfo4.StyleInfo.Font.Underline = false;
            gridCellInfo4.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point;
            gridCellInfo5.Col = -1;
            gridCellInfo5.Row = -1;
            gridCellInfo5.StyleInfo.Font.Bold = false;
            gridCellInfo5.StyleInfo.Font.Facename = "Verdana";
            gridCellInfo5.StyleInfo.Font.Italic = false;
            gridCellInfo5.StyleInfo.Font.Size = 8.25F;
            gridCellInfo5.StyleInfo.Font.Strikeout = false;
            gridCellInfo5.StyleInfo.Font.Underline = false;
            gridCellInfo5.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point;
            gridCellInfo6.Col = -1;
            gridCellInfo6.Row = -1;
            gridCellInfo6.StyleInfo.Font.Bold = false;
            gridCellInfo6.StyleInfo.Font.Facename = "Verdana";
            gridCellInfo6.StyleInfo.Font.Italic = false;
            gridCellInfo6.StyleInfo.Font.Size = 8.25F;
            gridCellInfo6.StyleInfo.Font.Strikeout = false;
            gridCellInfo6.StyleInfo.Font.Underline = false;
            gridCellInfo6.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point;
            gridCellInfo7.Col = -1;
            gridCellInfo7.Row = -1;
            gridCellInfo7.StyleInfo.Font.Bold = false;
            gridCellInfo7.StyleInfo.Font.Facename = "Verdana";
            gridCellInfo7.StyleInfo.Font.Italic = false;
            gridCellInfo7.StyleInfo.Font.Size = 8.25F;
            gridCellInfo7.StyleInfo.Font.Strikeout = false;
            gridCellInfo7.StyleInfo.Font.Underline = false;
            gridCellInfo7.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point;
            gridCellInfo8.Col = -1;
            gridCellInfo8.Row = -1;
            gridCellInfo8.StyleInfo.Font.Bold = false;
            gridCellInfo8.StyleInfo.Font.Facename = "Verdana";
            gridCellInfo8.StyleInfo.Font.Italic = false;
            gridCellInfo8.StyleInfo.Font.Size = 8.25F;
            gridCellInfo8.StyleInfo.Font.Strikeout = false;
            gridCellInfo8.StyleInfo.Font.Underline = false;
            gridCellInfo8.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point;
            gridCellInfo9.Col = 1;
            gridCellInfo9.Row = 3;
            gridCellInfo10.Col = 2;
            gridCellInfo10.Row = 3;
            gridCellInfo10.StyleInfo.Font.Bold = true;
            gridCellInfo10.StyleInfo.Text = "LIC Policy Details";
            gridCellInfo11.Col = 3;
            gridCellInfo11.Row = 3;
            gridCellInfo12.Col = 4;
            gridCellInfo12.Row = 3;
            gridCellInfo13.Col = 5;
            gridCellInfo13.Row = 3;
            gridCellInfo14.Col = 0;
            gridCellInfo14.Row = 4;
            gridCellInfo14.StyleInfo.Text = "4";
            gridCellInfo15.Col = 1;
            gridCellInfo15.Row = 4;
            gridCellInfo16.Col = 2;
            gridCellInfo16.Row = 4;
            gridCellInfo16.StyleInfo.HorizontalAlignment = Syncfusion.Windows.Forms.Grid.GridHorizontalAlignment.Center;
            gridCellInfo16.StyleInfo.Text = "Policy No";
            gridCellInfo17.Col = 3;
            gridCellInfo17.Row = 4;
            gridCellInfo17.StyleInfo.HorizontalAlignment = Syncfusion.Windows.Forms.Grid.GridHorizontalAlignment.Center;
            gridCellInfo17.StyleInfo.Text = "Policy Type";
            gridCellInfo18.Col = 4;
            gridCellInfo18.Row = 4;
            gridCellInfo18.StyleInfo.HorizontalAlignment = Syncfusion.Windows.Forms.Grid.GridHorizontalAlignment.Center;
            gridCellInfo18.StyleInfo.Text = "Premium";
            gridCellInfo19.Col = 5;
            gridCellInfo19.Row = 4;
            gridCellInfo19.StyleInfo.Text = "Deductions";
            gridCellInfo20.Col = 0;
            gridCellInfo20.Row = 5;
            gridCellInfo20.StyleInfo.Text = "5";
            gridCellInfo21.Col = 1;
            gridCellInfo21.Row = 5;
            gridCellInfo22.Col = 2;
            gridCellInfo22.Row = 5;
            gridCellInfo22.StyleInfo.HorizontalAlignment = Syncfusion.Windows.Forms.Grid.GridHorizontalAlignment.Center;
            gridCellInfo23.Col = 3;
            gridCellInfo23.Row = 5;
            gridCellInfo23.StyleInfo.HorizontalAlignment = Syncfusion.Windows.Forms.Grid.GridHorizontalAlignment.Center;
            gridCellInfo24.Col = 4;
            gridCellInfo24.Row = 5;
            gridCellInfo24.StyleInfo.HorizontalAlignment = Syncfusion.Windows.Forms.Grid.GridHorizontalAlignment.Center;
            gridCellInfo25.Col = 5;
            gridCellInfo25.Row = 5;
            gridCellInfo25.StyleInfo.HorizontalAlignment = Syncfusion.Windows.Forms.Grid.GridHorizontalAlignment.Center;
            gridCellInfo26.Col = 0;
            gridCellInfo26.Row = 6;
            gridCellInfo26.StyleInfo.Text = "6";
            gridCellInfo27.Col = 1;
            gridCellInfo27.Row = 6;
            gridCellInfo28.Col = 2;
            gridCellInfo28.Row = 6;
            gridCellInfo29.Col = 3;
            gridCellInfo29.Row = 6;
            gridCellInfo30.Col = 4;
            gridCellInfo30.Row = 6;
            gridCellInfo31.Col = 5;
            gridCellInfo31.Row = 6;
            gridCellInfo32.Col = 0;
            gridCellInfo32.Row = 7;
            gridCellInfo32.StyleInfo.Text = "7";
            gridCellInfo33.Col = 1;
            gridCellInfo33.Row = 7;
            gridCellInfo34.Col = 2;
            gridCellInfo34.Row = 7;
            gridCellInfo34.StyleInfo.Font.Bold = true;
            gridCellInfo34.StyleInfo.Text = "Personal Loan Details";
            gridCellInfo35.Col = 3;
            gridCellInfo35.Row = 7;
            gridCellInfo36.Col = 4;
            gridCellInfo36.Row = 7;
            gridCellInfo37.Col = 5;
            gridCellInfo37.Row = 7;
            gridCellInfo38.Col = 0;
            gridCellInfo38.Row = 8;
            gridCellInfo38.StyleInfo.Text = "8";
            gridCellInfo39.Col = 1;
            gridCellInfo39.Row = 8;
            gridCellInfo40.Col = 2;
            gridCellInfo40.Row = 8;
            gridCellInfo40.StyleInfo.HorizontalAlignment = Syncfusion.Windows.Forms.Grid.GridHorizontalAlignment.Center;
            gridCellInfo40.StyleInfo.Text = "Loan No";
            gridCellInfo41.Col = 3;
            gridCellInfo41.Row = 8;
            gridCellInfo41.StyleInfo.HorizontalAlignment = Syncfusion.Windows.Forms.Grid.GridHorizontalAlignment.Center;
            gridCellInfo41.StyleInfo.Text = "Loan Amount";
            gridCellInfo42.Col = 4;
            gridCellInfo42.Row = 8;
            gridCellInfo42.StyleInfo.HorizontalAlignment = Syncfusion.Windows.Forms.Grid.GridHorizontalAlignment.Center;
            gridCellInfo42.StyleInfo.Text = "Monthly Due";
            gridCellInfo43.Col = 5;
            gridCellInfo43.Row = 8;
            gridCellInfo43.StyleInfo.Text = "Deductions";
            gridCellInfo44.Col = 0;
            gridCellInfo44.Row = 9;
            gridCellInfo44.StyleInfo.Text = "9";
            gridCellInfo45.Col = 1;
            gridCellInfo45.Row = 9;
            gridCellInfo46.Col = 2;
            gridCellInfo46.Row = 9;
            gridCellInfo46.StyleInfo.HorizontalAlignment = Syncfusion.Windows.Forms.Grid.GridHorizontalAlignment.Center;
            gridCellInfo46.StyleInfo.Text = "";
            gridCellInfo47.Col = 3;
            gridCellInfo47.Row = 9;
            gridCellInfo47.StyleInfo.HorizontalAlignment = Syncfusion.Windows.Forms.Grid.GridHorizontalAlignment.Center;
            gridCellInfo48.Col = 4;
            gridCellInfo48.Row = 9;
            gridCellInfo48.StyleInfo.HorizontalAlignment = Syncfusion.Windows.Forms.Grid.GridHorizontalAlignment.Center;
            gridCellInfo49.Col = 5;
            gridCellInfo49.Row = 9;
            gridCellInfo49.StyleInfo.HorizontalAlignment = Syncfusion.Windows.Forms.Grid.GridHorizontalAlignment.Center;
            this.gridCalculations.GridCells.AddRange(new Syncfusion.Windows.Forms.Grid.GridCellInfo[] {
            gridCellInfo1,
            gridCellInfo2,
            gridCellInfo3,
            gridCellInfo4,
            gridCellInfo5,
            gridCellInfo6,
            gridCellInfo7,
            gridCellInfo8,
            gridCellInfo9,
            gridCellInfo10,
            gridCellInfo11,
            gridCellInfo12,
            gridCellInfo13,
            gridCellInfo14,
            gridCellInfo15,
            gridCellInfo16,
            gridCellInfo17,
            gridCellInfo18,
            gridCellInfo19,
            gridCellInfo20,
            gridCellInfo21,
            gridCellInfo22,
            gridCellInfo23,
            gridCellInfo24,
            gridCellInfo25,
            gridCellInfo26,
            gridCellInfo27,
            gridCellInfo28,
            gridCellInfo29,
            gridCellInfo30,
            gridCellInfo31,
            gridCellInfo32,
            gridCellInfo33,
            gridCellInfo34,
            gridCellInfo35,
            gridCellInfo36,
            gridCellInfo37,
            gridCellInfo38,
            gridCellInfo39,
            gridCellInfo40,
            gridCellInfo41,
            gridCellInfo42,
            gridCellInfo43,
            gridCellInfo44,
            gridCellInfo45,
            gridCellInfo46,
            gridCellInfo47,
            gridCellInfo48,
            gridCellInfo49});
            this.gridCalculations.GridOfficeScrollBars = Syncfusion.Windows.Forms.OfficeScrollBars.Metro;
            this.gridCalculations.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro;
            this.gridCalculations.DefaultRowHeight = (int)DpiAware.LogicalToDeviceUnits(20.0f);
            this.gridCalculations.Location = new System.Drawing.Point(0, 0);
            this.gridCalculations.MetroScrollBars = true;
            this.gridCalculations.Name = "gridCalculations";
            this.gridCalculations.Properties.ForceImmediateRepaint = false;
            this.gridCalculations.Properties.GridLineColor = System.Drawing.Color.LightGray;
            this.gridCalculations.Properties.MarkColHeader = false;
            this.gridCalculations.Properties.MarkRowHeader = false;
            this.gridCalculations.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.gridCalculations.RowCount = 20;
            this.gridCalculations.RowHeightEntries.AddRange(new Syncfusion.Windows.Forms.Grid.GridRowHeight[] {
            new Syncfusion.Windows.Forms.Grid.GridRowHeight(0, 21),
            new Syncfusion.Windows.Forms.Grid.GridRowHeight(1, 18)});
            this.gridCalculations.SerializeCellsBehavior = Syncfusion.Windows.Forms.Grid.GridSerializeCellsBehavior.SerializeIntoCode;
            this.gridCalculations.Size = new System.Drawing.Size(739, 312);
            this.gridCalculations.SmartSizeBox = false;
            this.gridCalculations.ThemesEnabled = true;
            // 
            // gridAwareTextBox1
            // 
            this.gridAwareTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gridAwareTextBox1.AutoSuggestFormula = false;
            this.gridAwareTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gridAwareTextBox1.DisabledBackColor = System.Drawing.SystemColors.Window;
            this.gridAwareTextBox1.EnabledBackColor = System.Drawing.SystemColors.Window;
            this.gridAwareTextBox1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridAwareTextBox1.Location = new System.Drawing.Point(88, 15);
            this.gridAwareTextBox1.Name = "gridAwareTextBox1";
            this.gridAwareTextBox1.Size = new System.Drawing.Size(672, 27);
            this.gridAwareTextBox1.TabIndex = 1;
            // 
            // showFormula
            // 
            this.showFormula.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.showFormula.BeforeTouchSize = new System.Drawing.Size(110, 25);
            this.showFormula.DrawFocusRectangle = false;
            this.showFormula.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showFormula.Location = new System.Drawing.Point(766, 15);
            this.showFormula.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.showFormula.Name = "showFormula";
            this.showFormula.Size = new System.Drawing.Size(110, 25);
            this.showFormula.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.showFormula.TabIndex = 2;
            this.showFormula.Text = "Show Formula";
            this.showFormula.ThemesEnabled = false;
            this.showFormula.CheckStateChanged += new System.EventHandler(this.showFormula_CheckedChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Formula Bar";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 543);
            this.Controls.Add(this.gridAwareTextBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.showFormula);
            this.Controls.Add(this.tabBarSplitterControl1);
            this.MinimumSize = new System.Drawing.Size(800, 400);
            this.Name = "Form1";
            this.Text = "Cross-Reference";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabBarSplitterControl1.ResumeLayout(false);
            this.tabBarPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridDisplay)).EndInit();
            this.tabBarPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridCalculations)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.showFormula)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        #endregion

        #region Event Handlers
        GridFormulaEngine engine;
        private void Form1_Load(object sender, System.EventArgs e)
        {
            //Registering grid as sheet for cross-reference
            int sheetFamilyID = GridFormulaEngine.CreateSheetFamilyID();
            GridFormulaEngine.RegisterGridAsSheet("Display", this.gridDisplay.Model, sheetFamilyID);
            GridFormulaEngine.RegisterGridAsSheet("Calculate", this.gridCalculations.Model, sheetFamilyID);
            SetUpDisplaySheet();
            SetUpCalcSheet();

            //setup copying formulas
            engine = ((GridFormulaCellModel)this.gridCalculations.CellModels["FormulaCell"]).Engine;
            engine.FormulaCopyFlags |= GridFormulaCopyFlags.ClipBoardFormula;

            //Subscribe to the necessary events
            this.gridDisplay.CurrentCellStartEditing += new CancelEventHandler(gridDisplay_CurrentCellStartEditing);
            this.gridDisplay.CellDoubleClick += new GridCellClickEventHandler(gridDisplay_CellDoubleClick);
            this.gridCalculations.CurrentCellStartEditing += new CancelEventHandler(gridCalculations_CurrentCellStartEditing);
            this.gridCalculations.CellDoubleClick += new GridCellClickEventHandler(gridCalculations_CellDoubleClick);
            this.gridDisplay.DrawCellDisplayText += new GridDrawCellDisplayTextEventHandler(gridDisplay_DrawCellDisplayText);
            this.gridCalculations.DrawCellDisplayText += new GridDrawCellDisplayTextEventHandler(gridCalculations_DrawCellDisplayText);
        }

        void gridCalculations_CellDoubleClick(object sender, GridCellClickEventArgs e)
        {
            editingLocked = false;
            this.gridCalculations.CurrentCell.BeginEdit(true);
            editingLocked = true;
        }

        void gridDisplay_CellDoubleClick(object sender, GridCellClickEventArgs e)
        {
            editingLocked = false;
            this.gridDisplay.CurrentCell.BeginEdit(true);
            editingLocked = true;
        }

        void gridCalculations_CurrentCellStartEditing(object sender, CancelEventArgs e)
        {
            e.Cancel = editingLocked;
        }

        void gridDisplay_CurrentCellStartEditing(object sender, CancelEventArgs e)
        {
            e.Cancel = editingLocked;
        }

        #region DisplaySheet

        private void SetUpDisplaySheet()
        {

            //General Settings
            int row = 6;
            int col = 4;

            this.gridDisplay[row, col].CellType = GridCellTypeName.FormulaCell;
            this.gridDisplay[row, col].Text = "=B9*0.81";

            this.gridDisplay[++row, col].CellType = GridCellTypeName.FormulaCell;
            this.gridDisplay[row, col].Text = "=B9+D6";

            this.gridDisplay[++row, col].CellType = GridCellTypeName.FormulaCell;
            this.gridDisplay[row, col].Text = "=D7*0.10";

            this.gridDisplay[++row, col].CellType = GridCellTypeName.FormulaCell;
            this.gridDisplay[row, col].Text = "=D7-D8";

            this.gridDisplay[++row, col].CellType = GridCellTypeName.FormulaCell;
            this.gridDisplay[row, col].Text = "=D9*12";

            row = 6;
            col = 2;
            //General Details
            this.gridDisplay[row, col].Text = "Nancy";
            this.gridDisplay[++row, col].Text = "M.F.A";
            this.gridDisplay[++row, col].Text = "4 years";
            this.gridDisplay[++row, col].Text = "8,000.00";

            //Policy Details
            row += 3;
            this.gridDisplay[row, col].Text = "1234";
            this.gridDisplay[++row, col].Text = "Quarterly";
            this.gridDisplay[++row, col].Text = "2,000.00";

            //Loan Details
            row += 3;
            this.gridDisplay[row, col].Text = "5678";
            this.gridDisplay[++row, col].Text = "1,00,000.00";
            this.gridDisplay[++row, col].Text = "1,500.00";


            this.gridAwareTextBox1.WireGrid(this.gridDisplay);


        }


        #endregion

        #region CalculationSheet

        private void SetUpCalcSheet()
        {
            int row = 5;
            int col = 2;

            this.gridCalculations[row, col].CellType = GridCellTypeName.FormulaCell;
            this.gridCalculations[row, col].Text = "=Display!B12";

            this.gridCalculations[row, col + 1].CellType = GridCellTypeName.FormulaCell;
            this.gridCalculations[row, col + 1].Text = "=Display!B13";

            this.gridCalculations[row, col + 2].CellType = GridCellTypeName.FormulaCell;
            this.gridCalculations[row, col + 2].Text = "=Display!B14";

            this.gridCalculations[row, col + 3].CellType = GridCellTypeName.FormulaCell;
            this.gridCalculations[row, col + 3].Text = "=D5*4";

            row += 4;
            this.gridCalculations[row, col].CellType = GridCellTypeName.FormulaCell;
            this.gridCalculations[row, col].Text = "=Display!B17";

            this.gridCalculations[row, col + 1].CellType = GridCellTypeName.FormulaCell;
            this.gridCalculations[row, col + 1].Text = "=Display!B18";

            this.gridCalculations[row, col + 2].CellType = GridCellTypeName.FormulaCell;
            this.gridCalculations[row, col + 2].Text = "=Display!B19";

            this.gridCalculations[row, col + 3].CellType = GridCellTypeName.FormulaCell;
            this.gridCalculations[row, col + 3].Text = "=D9*12";

            this.gridCalculations.TableStyle.Format = "#,##0";

            this.gridAwareTextBox1.WireGrid(this.gridCalculations);
        }


        #endregion

        private void tabBarSplitterControl1_PaneCreated(object sender, Syncfusion.Windows.Forms.SplitterPaneEventArgs e)
        {
            GridControl grid = e.Control as GridControl;
            this.gridAwareTextBox1.WireGrid(grid);
        }

        private void tabBarSplitterControl1_PaneClosing(object sender, Syncfusion.Windows.Forms.SplitterPaneEventArgs e)
        {
            GridControl grid = e.Control as GridControl;
            this.gridAwareTextBox1.UnwireGrid(grid);
        }

        private bool editingLocked = true;
        bool flag = false;

        private void showFormula_CheckedChanged(object sender, EventArgs e)
        {
            if (showFormula.Checked)
            {
                //Display the formulas in Formula Cells
                flag = true;
                this.gridDisplay.RefreshRange(GridRangeInfo.Cells(6, 4, 10, 4));
                this.gridCalculations.RefreshRange(GridRangeInfo.Row(5));
                this.gridCalculations.RefreshRange(GridRangeInfo.Row(9));
            }
            else
            {
                //Show the computed results in Formula Cells
                flag = false;
                this.gridDisplay.RefreshRange(GridRangeInfo.Cells(6, 4, 10, 4));
                this.gridCalculations.RefreshRange(GridRangeInfo.Row(5));
                this.gridCalculations.RefreshRange(GridRangeInfo.Row(9));
            }
        }

        private void gridDisplay_DrawCellDisplayText(object sender, GridDrawCellDisplayTextEventArgs e)
        {
            if (e.Style.CellType == "FormulaCell" && flag)
            {
                e.DisplayText = e.Style.Text;
            }
        }
        private void gridCalculations_DrawCellDisplayText(object sender, GridDrawCellDisplayTextEventArgs e)
        {
            if (e.Style.CellType == "FormulaCell" && flag)
            {
                e.DisplayText = e.Style.Text;
            }
        }
        #endregion
    }
}

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

namespace NamedRangesForFormulas
{
    /// <summary>
    /// Summary description for Form1.
    /// </summary>
    public class Form1 : GridDemoForm
    {
        #region "API Definition"

        private Syncfusion.Windows.Forms.TabBarSplitterControl tabBarSplitterControl1;
        private Syncfusion.Windows.Forms.TabBarPage CashFlow;
        private Syncfusion.Windows.Forms.TabBarPage Expenses;
        private Syncfusion.Windows.Forms.TabBarPage Income;
        private Syncfusion.Windows.Forms.Grid.GridControl gridExpenses;
        private Syncfusion.Windows.Forms.Grid.GridControl gridIncome;
        private Syncfusion.Windows.Forms.Grid.GridControl gridCashFlow;
        private System.Windows.Forms.ContextMenu contextMenu1;
        private System.Windows.Forms.MenuItem menuItem1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
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

            //
            // TODO: Add any constructor code after InitializeComponent call
            //
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
            this.gridCashFlow.DefaultRowHeight = (int)DpiAware.LogicalToDeviceUnits(22.0f);

            this.gridCashFlow.Model.Options.DisplayEmptyColumns = true;
            this.gridCashFlow.Model.Options.DisplayEmptyRows = true;

            //Used to set default row height
            this.gridExpenses.DefaultRowHeight = (int)DpiAware.LogicalToDeviceUnits(22.0f);

            this.gridExpenses.Model.Options.DisplayEmptyColumns = true;
            this.gridExpenses.Model.Options.DisplayEmptyRows = true;

            //Used to set default row height
            this.gridIncome.DefaultRowHeight = (int)DpiAware.LogicalToDeviceUnits(22.0f);

            this.gridIncome.Model.Options.DisplayEmptyColumns = true;
            this.gridIncome.Model.Options.DisplayEmptyRows = true;

            
        }
        #endregion

        #region Form Handlers
       
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
            this.tabBarSplitterControl1 = new Syncfusion.Windows.Forms.TabBarSplitterControl();
            this.CashFlow = new Syncfusion.Windows.Forms.TabBarPage();
            this.gridCashFlow = new Syncfusion.Windows.Forms.Grid.GridControl();
            this.contextMenu1 = new System.Windows.Forms.ContextMenu();
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.Expenses = new Syncfusion.Windows.Forms.TabBarPage();
            this.gridExpenses = new Syncfusion.Windows.Forms.Grid.GridControl();
            this.Income = new Syncfusion.Windows.Forms.TabBarPage();
            this.gridIncome = new Syncfusion.Windows.Forms.Grid.GridControl();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabBarSplitterControl1.SuspendLayout();
            this.CashFlow.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCashFlow)).BeginInit();
            this.Expenses.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridExpenses)).BeginInit();
            this.Income.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridIncome)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabBarSplitterControl1
            // 
            this.tabBarSplitterControl1.ActivePageBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(157)))), ((int)(((byte)(217)))));
            this.tabBarSplitterControl1.ActivePageIndex = 2;
            this.tabBarSplitterControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tabBarSplitterControl1.BeforeTouchSize = new System.Drawing.Size(732, 321);
            this.tabBarSplitterControl1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tabBarSplitterControl1.Controls.Add(this.CashFlow);
            this.tabBarSplitterControl1.Controls.Add(this.Expenses);
            this.tabBarSplitterControl1.Controls.Add(this.Income);
            this.tabBarSplitterControl1.EnabledColor = System.Drawing.SystemColors.WindowText;
            this.tabBarSplitterControl1.Location = new System.Drawing.Point(25, 42);
            this.tabBarSplitterControl1.Name = "tabBarSplitterControl1";
            this.tabBarSplitterControl1.ScrollButtons = Syncfusion.Windows.Forms.DisplayArrowButtons.None;
            this.tabBarSplitterControl1.Size = new System.Drawing.Size(732, 321);
            this.tabBarSplitterControl1.SplitBars = ((Syncfusion.Windows.Forms.DynamicSplitBars)((Syncfusion.Windows.Forms.DynamicSplitBars.SplitRows | Syncfusion.Windows.Forms.DynamicSplitBars.SplitColumns)));
            this.tabBarSplitterControl1.Style = Syncfusion.Windows.Forms.TabBarSplitterStyle.Metro;
            this.tabBarSplitterControl1.TabFolderDelta = 11;
            this.tabBarSplitterControl1.TabIndex = 0;
            this.tabBarSplitterControl1.Text = "tabBarSplitterControl1";
            this.tabBarSplitterControl1.ThemesEnabled = true;
            this.tabBarSplitterControl1.ScrollButtons = Syncfusion.Windows.Forms.DisplayArrowButtons.None;
            // 
            // CashFlow
            // 
            this.CashFlow.Controls.Add(this.gridCashFlow);
            this.CashFlow.Location = new System.Drawing.Point(0, 0);
            this.CashFlow.Name = "CashFlow";
            this.CashFlow.SplitBars = ((Syncfusion.Windows.Forms.DynamicSplitBars)((Syncfusion.Windows.Forms.DynamicSplitBars.SplitRows | Syncfusion.Windows.Forms.DynamicSplitBars.SplitColumns)));
            this.CashFlow.TabBackColor = System.Drawing.SystemColors.Control;
            this.CashFlow.TabBarColor = System.Drawing.Color.Empty;
            this.CashFlow.TabMaxWidth = (int)DpiAware.LogicalToDeviceUnits(100.0f);
            this.CashFlow.Text = "CashFlow";
            this.CashFlow.ThemesEnabled = true;
            // 
            // gridCashFlow
            // 
            this.gridCashFlow.DpiAware = true;
            this.gridCashFlow.AlphaBlendSelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(94)))), ((int)(((byte)(171)))), ((int)(((byte)(222)))));
            this.gridCashFlow.Dock = DockStyle.Fill;
            this.gridCashFlow.ContextMenu = this.contextMenu1;
            this.gridCashFlow.DefaultGridBorderStyle = Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid;
            this.gridCashFlow.FillSplitterPane = true;
            this.gridCashFlow.Font = new System.Drawing.Font("Segoe UI", 9F);
            gridCellInfo1.Col = -1;
            gridCellInfo1.Row = -1;
            gridCellInfo1.StyleInfo.Font.Bold = false;
            gridCellInfo1.StyleInfo.Font.Facename = "Segoe UI";
            gridCellInfo1.StyleInfo.Font.Italic = false;
            gridCellInfo1.StyleInfo.Font.Size = 9F;
            gridCellInfo1.StyleInfo.Font.Strikeout = false;
            gridCellInfo1.StyleInfo.Font.Underline = false;
            gridCellInfo1.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point;
            gridCellInfo2.Col = -1;
            gridCellInfo2.Row = -1;
            gridCellInfo2.StyleInfo.Font.Bold = false;
            gridCellInfo2.StyleInfo.Font.Facename = "Segoe UI";
            gridCellInfo2.StyleInfo.Font.Italic = false;
            gridCellInfo2.StyleInfo.Font.Size = 9F;
            gridCellInfo2.StyleInfo.Font.Strikeout = false;
            gridCellInfo2.StyleInfo.Font.Underline = false;
            gridCellInfo2.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point;
            gridCellInfo3.Col = -1;
            gridCellInfo3.Row = -1;
            gridCellInfo3.StyleInfo.Font.Bold = false;
            gridCellInfo3.StyleInfo.Font.Facename = "Segoe UI";
            gridCellInfo3.StyleInfo.Font.Italic = false;
            gridCellInfo3.StyleInfo.Font.Size = 8.25F;
            gridCellInfo3.StyleInfo.Font.Strikeout = false;
            gridCellInfo3.StyleInfo.Font.Underline = false;
            gridCellInfo3.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point;
            gridCellInfo4.Col = -1;
            gridCellInfo4.Row = -1;
            gridCellInfo4.StyleInfo.Borders.Bottom = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234))))), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin);
            gridCellInfo4.StyleInfo.Borders.Right = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234))))), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin);
            gridCellInfo4.StyleInfo.Font.Facename = "Segoe UI";
            gridCellInfo4.StyleInfo.Interior = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.White);
            gridCellInfo4.StyleInfo.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gridCashFlow.GridCells.AddRange(new Syncfusion.Windows.Forms.Grid.GridCellInfo[] {
            gridCellInfo1,
            gridCellInfo2,
            gridCellInfo3,
            gridCellInfo4});
            this.gridCashFlow.GridOfficeScrollBars = Syncfusion.Windows.Forms.OfficeScrollBars.Metro;
            this.gridCashFlow.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro;
            this.gridCashFlow.DefaultRowHeight = (int)DpiAware.LogicalToDeviceUnits(20.0f);
            this.gridCashFlow.Location = new System.Drawing.Point(0, 0);
            this.gridCashFlow.MetroScrollBars = true;
            this.gridCashFlow.Name = "gridCashFlow";
            this.gridCashFlow.Properties.ForceImmediateRepaint = false;
            this.gridCashFlow.Properties.GridLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.gridCashFlow.Properties.MarkColHeader = false;
            this.gridCashFlow.Properties.MarkRowHeader = false;
            this.gridCashFlow.RowHeightEntries.AddRange(new Syncfusion.Windows.Forms.Grid.GridRowHeight[] {
            new Syncfusion.Windows.Forms.Grid.GridRowHeight(0, 29)});
            this.gridCashFlow.SmartSizeBox = false;
            this.gridCashFlow.Text = "gridControl1";
            this.gridCashFlow.ThemesEnabled = true;
            // 
            // contextMenu1
            // 
            this.contextMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem1});
            // 
            // menuItem1
            // 
            this.menuItem1.Index = 0;
            this.menuItem1.Text = "Edit Inputs";
            this.menuItem1.Click += new System.EventHandler(this.menuItem1_Click);
            // 
            // Expenses
            // 
            this.Expenses.Controls.Add(this.gridExpenses);
            this.Expenses.Location = new System.Drawing.Point(0, 0);
            this.Expenses.Name = "Expenses";
            this.Expenses.SplitBars = ((Syncfusion.Windows.Forms.DynamicSplitBars)((Syncfusion.Windows.Forms.DynamicSplitBars.SplitRows | Syncfusion.Windows.Forms.DynamicSplitBars.SplitColumns)));
            this.Expenses.TabBackColor = System.Drawing.SystemColors.Control;
            this.Expenses.TabBarColor = System.Drawing.Color.Empty;
            this.Expenses.TabMaxWidth = (int)DpiAware.LogicalToDeviceUnits(100.0f);
            this.Expenses.Text = "Expenses";
            this.Expenses.ThemesEnabled = true;
            // 
            // gridExpenses
            // 
            this.gridExpenses.AlphaBlendSelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(94)))), ((int)(((byte)(171)))), ((int)(((byte)(222)))));
            this.gridExpenses.Dock = DockStyle.Fill;
            this.gridExpenses.ContextMenu = this.contextMenu1;
            this.gridExpenses.DefaultGridBorderStyle = Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid;
            this.gridExpenses.DefaultRowHeight = (int)DpiAware.LogicalToDeviceUnits(20.0f);
            this.gridExpenses.FillSplitterPane = true;
            this.gridExpenses.Font = new System.Drawing.Font("Segoe UI", 9F);
            gridCellInfo5.Col = -1;
            gridCellInfo5.Row = -1;
            gridCellInfo5.StyleInfo.Font.Bold = false;
            gridCellInfo5.StyleInfo.Font.Facename = "Segoe UI";
            gridCellInfo5.StyleInfo.Font.Italic = false;
            gridCellInfo5.StyleInfo.Font.Size = 9F;
            gridCellInfo5.StyleInfo.Font.Strikeout = false;
            gridCellInfo5.StyleInfo.Font.Underline = false;
            gridCellInfo5.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point;
            gridCellInfo6.Col = -1;
            gridCellInfo6.Row = -1;
            gridCellInfo6.StyleInfo.Font.Bold = false;
            gridCellInfo6.StyleInfo.Font.Facename = "Segoe UI";
            gridCellInfo6.StyleInfo.Font.Italic = false;
            gridCellInfo6.StyleInfo.Font.Size = 9F;
            gridCellInfo6.StyleInfo.Font.Strikeout = false;
            gridCellInfo6.StyleInfo.Font.Underline = false;
            gridCellInfo6.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point;
            gridCellInfo7.Col = -1;
            gridCellInfo7.Row = -1;
            gridCellInfo7.StyleInfo.Font.Bold = false;
            gridCellInfo7.StyleInfo.Font.Facename = "Segoe UI";
            gridCellInfo7.StyleInfo.Font.Italic = false;
            gridCellInfo7.StyleInfo.Font.Size = 8.25F;
            gridCellInfo7.StyleInfo.Font.Strikeout = false;
            gridCellInfo7.StyleInfo.Font.Underline = false;
            gridCellInfo7.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point;
            gridCellInfo8.Col = -1;
            gridCellInfo8.Row = -1;
            gridCellInfo8.StyleInfo.Borders.Bottom = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234))))), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin);
            gridCellInfo8.StyleInfo.Borders.Right = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234))))), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin);
            gridCellInfo8.StyleInfo.Font.Facename = "Segoe UI";
            gridCellInfo8.StyleInfo.Interior = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.White);
            gridCellInfo8.StyleInfo.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gridExpenses.GridCells.AddRange(new Syncfusion.Windows.Forms.Grid.GridCellInfo[] {
            gridCellInfo5,
            gridCellInfo6,
            gridCellInfo7,
            gridCellInfo8});
            this.gridExpenses.GridOfficeScrollBars = Syncfusion.Windows.Forms.OfficeScrollBars.Metro;
            this.gridExpenses.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro;
            this.gridExpenses.Location = new System.Drawing.Point(0, 0);
            this.gridExpenses.MetroScrollBars = true;
            this.gridExpenses.Name = "gridExpenses";
            this.gridExpenses.Properties.ForceImmediateRepaint = false;
            this.gridExpenses.Properties.GridLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.gridExpenses.Properties.MarkColHeader = false;
            this.gridExpenses.Properties.MarkRowHeader = false;
            this.gridExpenses.RowHeightEntries.AddRange(new Syncfusion.Windows.Forms.Grid.GridRowHeight[] {
            new Syncfusion.Windows.Forms.Grid.GridRowHeight(0, 29)});
            this.gridExpenses.SmartSizeBox = false;
            this.gridExpenses.Text = "gridControl2";
            this.gridExpenses.ThemesEnabled = true;
            this.gridExpenses.DpiAware = true;
            // 
            // Income
            // 
            this.Income.ContextMenu = this.contextMenu1;
            this.Income.Controls.Add(this.gridIncome);
            this.Income.Location = new System.Drawing.Point(0, 0);
            this.Income.Name = "Income";
            this.Income.SplitBars = ((Syncfusion.Windows.Forms.DynamicSplitBars)((Syncfusion.Windows.Forms.DynamicSplitBars.SplitRows | Syncfusion.Windows.Forms.DynamicSplitBars.SplitColumns)));
            this.Income.TabBackColor = System.Drawing.SystemColors.Control;
            this.Income.TabBarColor = System.Drawing.Color.Empty;
            this.Income.TabMaxWidth = (int)DpiAware.LogicalToDeviceUnits(100.0f);
            this.Income.Text = "Income";
            this.Income.ThemesEnabled = true;
            // 
            // gridIncome
            // 
            this.gridIncome.AlphaBlendSelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(94)))), ((int)(((byte)(171)))), ((int)(((byte)(222)))));
            this.gridIncome.Dock = DockStyle.Fill;
            this.gridIncome.DefaultGridBorderStyle = Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid;
            this.gridIncome.DefaultRowHeight = (int)DpiAware.LogicalToDeviceUnits(20.0f);
            this.gridIncome.FillSplitterPane = true;
            this.gridIncome.Font = new System.Drawing.Font("Segoe UI", 9F);
            gridCellInfo9.Col = -1;
            gridCellInfo9.Row = -1;
            gridCellInfo9.StyleInfo.Font.Bold = false;
            gridCellInfo9.StyleInfo.Font.Facename = "Segoe UI";
            gridCellInfo9.StyleInfo.Font.Italic = false;
            gridCellInfo9.StyleInfo.Font.Size = 9F;
            gridCellInfo9.StyleInfo.Font.Strikeout = false;
            gridCellInfo9.StyleInfo.Font.Underline = false;
            gridCellInfo9.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point;
            gridCellInfo10.Col = -1;
            gridCellInfo10.Row = -1;
            gridCellInfo10.StyleInfo.Borders.Bottom = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234))))), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin);
            gridCellInfo10.StyleInfo.Borders.Right = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234))))), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin);
            gridCellInfo10.StyleInfo.Font.Facename = "Segoe UI";
            gridCellInfo10.StyleInfo.Interior = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.White);
            gridCellInfo10.StyleInfo.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gridIncome.GridCells.AddRange(new Syncfusion.Windows.Forms.Grid.GridCellInfo[] {
            gridCellInfo9,
            gridCellInfo10});
            this.gridIncome.GridOfficeScrollBars = Syncfusion.Windows.Forms.OfficeScrollBars.Metro;
            this.gridIncome.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro;
            this.gridIncome.Location = new System.Drawing.Point(0, 0);
            this.gridIncome.MetroScrollBars = true;
            this.gridIncome.Name = "gridIncome";
            this.gridIncome.Properties.ForceImmediateRepaint = false;
            this.gridIncome.Properties.GridLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.gridIncome.Properties.MarkColHeader = false;
            this.gridIncome.Properties.MarkRowHeader = false;
            this.gridIncome.RowHeightEntries.AddRange(new Syncfusion.Windows.Forms.Grid.GridRowHeight[] {
            new Syncfusion.Windows.Forms.Grid.GridRowHeight(0, 29)});
            this.gridIncome.SmartSizeBox = false;
            this.gridIncome.Text = "gridControl3";
            this.gridIncome.ThemesEnabled = true;
            this.gridIncome.DpiAware = true;
            // 
            // label1
            // 
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Right-Click Any Cell To Edit the Input";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(24, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(734, 370);
            this.panel1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 414);
            this.Controls.Add(this.tabBarSplitterControl1);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(500, 400);
            this.Name = "Form1";
            this.Text = "Named Range";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabBarSplitterControl1.ResumeLayout(false);
            this.CashFlow.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridCashFlow)).EndInit();
            this.Expenses.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridExpenses)).EndInit();
            this.Income.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridIncome)).EndInit();
            this.panel1.ResumeLayout(false);
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
# if SyncfusionFramework1_1 || SyncfusionFramework2_0
            Application.EnableVisualStyles();
# endif
            Application.Run(new Form1());
        }
        #endregion

        #region Event Handler
        GridFormulaEngine engine;
        private void Form1_Load(object sender, System.EventArgs e)
        {
            //register grids for multisheeted use
            int sheetFamilyID = GridFormulaEngine.CreateSheetFamilyID();
            GridFormulaEngine.RegisterGridAsSheet("CashFlow", this.gridCashFlow.Model, sheetFamilyID);
            GridFormulaEngine.RegisterGridAsSheet("Expenses", this.gridExpenses.Model, sheetFamilyID);
            GridFormulaEngine.RegisterGridAsSheet("Income", this.gridIncome.Model, sheetFamilyID);

            //make all cells potential formula cells
            //and set some other table wide styles
            this.gridExpenses.TableStyle.CellType = "FormulaCell";
            this.gridIncome.TableStyle.CellType = "FormulaCell";
            this.gridCashFlow.TableStyle.CellType = "FormulaCell";

            this.gridExpenses.TableStyle.HorizontalAlignment = GridHorizontalAlignment.Right;
            this.gridIncome.TableStyle.HorizontalAlignment = GridHorizontalAlignment.Right;
            this.gridCashFlow.TableStyle.HorizontalAlignment = GridHorizontalAlignment.Right;

            this.gridExpenses.TableStyle.Format = "F2";
            this.gridIncome.TableStyle.Format = "F2";
            this.gridCashFlow.TableStyle.Format = "F2";

            //do not activate unless double click
            GridFormulaCellRenderer.ForceEditWhenActivated = false;
            this.gridExpenses.ActivateCurrentCellBehavior = GridCellActivateAction.DblClickOnCell;
            this.gridIncome.ActivateCurrentCellBehavior = GridCellActivateAction.DblClickOnCell;
            this.gridCashFlow.ActivateCurrentCellBehavior = GridCellActivateAction.DblClickOnCell;

            //get a reference to the GridFormulaEngine object
            //the same object is used for all registered sheets, so it doe not matter which grid we use
            this.engine = ((GridFormulaCellModel)gridCashFlow.Model.CellModels["FormulaCell"]).Engine;

            this.gridExpenses.RowCount = 30;

            //set up expenses grid & add values to NamedRanges
            SetValueAndFormulaFor("Mortgage", "800", 2, this.gridExpenses);
            SetValueAndFormulaFor("Insurance", "200", 3, this.gridExpenses);
            SetValueAndFormulaFor("Car", "300", 4, this.gridExpenses);
            SetValueAndFormulaFor("Food", "200", 5, this.gridExpenses);
            SetValueAndFormulaFor("Groceries", "200", 6, this.gridExpenses);
            SetValueAndFormulaFor("Clothing", "100", 7, this.gridExpenses);
            this.gridExpenses[8, 2].Text = "Total";
            this.gridExpenses[8, 2].Font.Bold = true;

            GridStyleInfo style = this.gridExpenses[8, 3];
            style.Font.Bold = true;
            style.Text = "=Sum(C2:C7)";


            //set up income grid
            this.gridIncome.RowCount = 30;
            SetValueAndFormulaFor("Investments", "150", 2, this.gridIncome);
            SetValueAndFormulaFor("Salary1", "1300", 3, this.gridIncome);
            SetValueAndFormulaFor("Salary2", "1200", 4, this.gridIncome);
            this.gridIncome[8, 2].Text = "Total";
            this.gridIncome[8, 2].Font.Bold = true;

            this.engine.AdjustNameRangesForSize();

            style = this.gridIncome[8, 3];
            style.Font.Bold = true;
            style.Text = "=Sum(C2:C7)";

            //set up CashFlow grid
            this.gridCashFlow.RowCount = 30;
            this.gridCashFlow[2, 2].Text = "Income";
            this.gridCashFlow[3, 2].Text = "Expenses";
            this.gridCashFlow[2, 3].Text = "=Income!C8";
            this.gridCashFlow[3, 3].Text = "=Expenses!C8";
            this.gridCashFlow[5, 2].Text = "Flow";
            this.gridCashFlow[5, 2].Font.Bold = true;

            style = this.gridCashFlow[5, 3];
            style.Font.Bold = true;
            style.Text = "=Sum(C2-C3)";

            //force everything to be recalculated so namedrange dependencies are fully known
            this.engine.RecalculateRange(GridRangeInfo.Table(), this.gridIncome.Model, true, true);
            this.engine.RecalculateRange(GridRangeInfo.Table(), this.gridExpenses.Model, true, true);


            //set the active tab
            this.tabBarSplitterControl1.ActivePage = this.tabBarSplitterControl1.TabBarPages[0];

            //To customize the dialog that appears when you edit NamedRanges using
            //GridFormulaNamedRangesEditHelper.ShowNamedRangesDialog, use this event
            GridFormulaNamedRangesEditHelper.ShowingNamedRangesDialog += new ControlEventHandler(helper_ShowingNamedRangesDialog);

            this.gridCashFlow.DefaultRowHeight = (int)DpiAware.LogicalToDeviceUnits(18.0f);
            this.gridCashFlow.DefaultColWidth = (int)DpiAware.LogicalToDeviceUnits(70.0f);
            this.gridCashFlow.Properties.GridLineColor = System.Drawing.Color.Silver;
            this.gridCashFlow.DefaultGridBorderStyle = GridBorderStyle.Solid;

            this.gridExpenses.DefaultRowHeight = (int)DpiAware.LogicalToDeviceUnits(18.0f);
            this.gridExpenses.DefaultColWidth = (int)DpiAware.LogicalToDeviceUnits(70.0f);
            this.gridExpenses.Properties.GridLineColor = System.Drawing.Color.Silver;
            this.gridExpenses.DefaultGridBorderStyle = GridBorderStyle.Solid;

            this.gridIncome.DefaultRowHeight = (int)DpiAware.LogicalToDeviceUnits(18.0f);
            this.gridIncome.DefaultColWidth = (int)DpiAware.LogicalToDeviceUnits(70.0f);
            this.gridIncome.Properties.GridLineColor = System.Drawing.Color.Silver;
            this.gridIncome.DefaultGridBorderStyle = GridBorderStyle.Solid;

        }

        //helper method to set named ranges and enter formulas in cells
        private void SetValueAndFormulaFor(string name, string val, int row, GridControl grid)
        {
            grid[row, 2].Text = name;
            name.Replace(" ", "");//no blanks in NamedRanges.Name
            this.engine.AddNamedRange(name, val);
            grid[row, 3].Text = "= " + name;
        }

        //event handler to change the title of editing dialog
        private void helper_ShowingNamedRangesDialog(object sender, ControlEventArgs e)
        {
            Form f = e.Control as Form;
            if (f != null)
            {
                //set the title for the dialog
                f.Text = "CashFlow Inputs";
                f.HelpButton = false;
            }
        }

        //menu handler for the Context menu
        private void menuItem1_Click(object sender, System.EventArgs e)
        {
            GridFormulaNamedRangesEditHelper.ShowNamedRangesDialog(this.engine);
        }
        #endregion
    }
}

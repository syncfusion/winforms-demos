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
using System.IO;
using System.Text.RegularExpressions;


using Syncfusion.XlsIO;
using Syncfusion.Windows.Forms;
using Syncfusion.GridExcelConverter;
using Syncfusion.Windows.Forms.Grid;
using Syncfusion.GridHelperClasses;


namespace ExcelLikeUI
{
    /// <summary>
    /// Summary description for Form1.
    /// </summary>
    public class WorkBook : Office2007Form
    {
        #region Private Variables
        public Syncfusion.Windows.Forms.TabBarSplitterControl tabBarSplitterControl;
        public Syncfusion.Windows.Forms.Grid.GridAwareTextBox gridAwareTextBox1;
        public Syncfusion.Windows.Forms.Grid.GridAwareTextBox gridAwareTextBox2;
        private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem parentBarItem;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem insertRowBarItem;
        private Syncfusion.Windows.Forms.Tools.ContextMenuStripEx gridCMStrip;
        private ToolStripMenuItem cutToolStripMenuItem;
        private ToolStripMenuItem copyToolStripMenuItem;
        private ToolStripMenuItem pasteToolStripMenuItem;
        private ToolStripMenuItem deleteToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem hyperlinkToolStripMenuItem;
        private System.ComponentModel.IContainer components = null;
        LayoutSupportHelper layoutHelper;
        internal GridControl _grid = null;
        Form1 form;
        #endregion

        #region Constructor
        public WorkBook(Form1 frm)
        {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();
            this.MyInit();
            form = frm;
        }
        #endregion

        #region Override Methods
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
            if (this._grid != null)
            {
                this._grid.CurrentCellMoved -= _grid_CurrentCellMoved;
                this._grid.SelectionChanged -= _grid_SelectionChanged;
                this._grid.VisibleChanged -= new EventHandler(_grid_VisibleChanged);
            }
            if (tabBarSplitterControl != null)
            {
                this.tabBarSplitterControl.TabBarPageAdding -= new TabBarPageAddingHandler(tabBarSplitterControl_TabBarPageAdding); this._grid.PrepareViewStyleInfo += _grid_PrepareViewStyleInfo;
                this.tabBarSplitterControl.ActivePageChanged -= new ControlEventHandler(tabBarSplitterControl_ActivePageChanged);
            }
            base.Dispose(disposing);
        }
        #endregion

        #region Windows Form Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WorkBook));
            this.tabBarSplitterControl = new Syncfusion.Windows.Forms.TabBarSplitterControl();
            this.gridAwareTextBox1 = new Syncfusion.Windows.Forms.Grid.GridAwareTextBox();
            this.gridAwareTextBox2 = new Syncfusion.Windows.Forms.Grid.GridAwareTextBox();
            this.parentBarItem = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.insertRowBarItem = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.gridCMStrip = new Syncfusion.Windows.Forms.Tools.ContextMenuStripEx();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.hyperlinkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabBarSplitterControl.SuspendLayout();
            this.gridCMStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabBarSplitterControl
            // 
            this.tabBarSplitterControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(232)))), ((int)(((byte)(249)))));
            this.tabBarSplitterControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabBarSplitterControl.Controls.Add(this.gridAwareTextBox1);
            this.tabBarSplitterControl.Controls.Add(this.gridAwareTextBox2);
            this.tabBarSplitterControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabBarSplitterControl.EnabledColor = System.Drawing.SystemColors.WindowText;
            this.tabBarSplitterControl.Location = new System.Drawing.Point(0, 0);
            this.tabBarSplitterControl.Name = "tabBarSplitterControl";
            this.tabBarSplitterControl.Office2007ScrollBars = true;
            this.tabBarSplitterControl.Size = new System.Drawing.Size(776, 502);
            this.tabBarSplitterControl.SplitBars = ((Syncfusion.Windows.Forms.DynamicSplitBars)((Syncfusion.Windows.Forms.DynamicSplitBars.SplitRows | Syncfusion.Windows.Forms.DynamicSplitBars.SplitColumns)));
            this.tabBarSplitterControl.Style = Syncfusion.Windows.Forms.TabBarSplitterStyle.Office2007;
            this.tabBarSplitterControl.TabFolderDelta = 11;
            this.tabBarSplitterControl.TabIndex = 0;
            this.tabBarSplitterControl.Text = "tabBarSplitterControl1";
            this.tabBarSplitterControl.ActivePageChanging += new System.Windows.Forms.ControlEventHandler(this.tabBarSplitterControl_ActivePageChanging);
            this.tabBarSplitterControl.PaneCreated += new Syncfusion.Windows.Forms.SplitterPaneEventHandler(this.tabBarSplitterControl_PaneCreated);
            // 
            // gridAwareTextBox1
            // 
            this.gridAwareTextBox1.DisabledBackColor = System.Drawing.SystemColors.Window;
            this.gridAwareTextBox1.EnabledBackColor = System.Drawing.SystemColors.Window;
            this.gridAwareTextBox1.Location = new System.Drawing.Point(-100, -100);
            this.gridAwareTextBox1.Name = "gridAwareTextBox1";
            this.gridAwareTextBox1.Size = new System.Drawing.Size(100, 20);
            this.gridAwareTextBox1.TabIndex = 1;
            this.gridAwareTextBox1.BorderStyle = BorderStyle.FixedSingle;
            // 
            // gridAwareTextBox2
            // 
            this.gridAwareTextBox2.DisabledBackColor = System.Drawing.SystemColors.Window;
            this.gridAwareTextBox2.EnabledBackColor = System.Drawing.SystemColors.Window;
            this.gridAwareTextBox2.Location = new System.Drawing.Point(-100, -100);
            this.gridAwareTextBox2.Name = "gridAwareTextBox2";
            this.gridAwareTextBox2.Size = new System.Drawing.Size(100, 20);
            this.gridAwareTextBox2.TabIndex = 2;
            this.gridAwareTextBox2.BorderStyle = BorderStyle.FixedSingle;
            // 
            // parentBarItem
            // 
            this.parentBarItem.BarName = "parentBarItem";
            this.parentBarItem.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.insertRowBarItem});
            this.parentBarItem.MetroColor = System.Drawing.Color.LightSkyBlue;
            this.parentBarItem.ShowToolTipInPopUp = false;
            this.parentBarItem.SizeToFit = true;
            // 
            // insertRowBarItem
            // 
            this.insertRowBarItem.BarName = "insertRowBarItem";
            this.insertRowBarItem.ID = "insertRowBarItem";
            this.insertRowBarItem.ShowToolTipInPopUp = false;
            this.insertRowBarItem.SizeToFit = true;
            this.insertRowBarItem.Text = "Insert Row";
            // 
            // gridCMStrip
            // 
            this.gridCMStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cutToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.toolStripSeparator1,
            this.hyperlinkToolStripMenuItem});
            this.gridCMStrip.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218)))));
            this.gridCMStrip.Name = "gridCMStrip";
            this.gridCMStrip.Size = new System.Drawing.Size(126, 120);
            this.gridCMStrip.Style = Syncfusion.Windows.Forms.Tools.ContextMenuStripEx.ContextMenuStyle.Default;
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.cutToolStripMenuItem.Text = "Cut";
            this.cutToolStripMenuItem.Click += new System.EventHandler(this.cutMenuItem_Click);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.copyToolStripMenuItem.Text = "Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyMenuItem_Click);
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.pasteToolStripMenuItem.Text = "Paste";
            this.pasteToolStripMenuItem.Click += new System.EventHandler(this.pasteMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteMenuItem_Click_1);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(122, 6);
            // 
            // hyperlinkToolStripMenuItem
            // 
            this.hyperlinkToolStripMenuItem.Name = "hyperlinkToolStripMenuItem";
            this.hyperlinkToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.hyperlinkToolStripMenuItem.Text = "Hyperlink";
            this.hyperlinkToolStripMenuItem.Click += new System.EventHandler(this.HyperLinkMenuItem_Click);
            // 
            // WorkBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 502);
            this.Controls.Add(this.tabBarSplitterControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.ControlBox = false;
            this.Name = "WorkBook";
            this.Text = "Form2";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Activated += new System.EventHandler(this.WorkBook_Activated);
            this.Deactivate += new System.EventHandler(this.WorkBook_Deactivate);
            this.tabBarSplitterControl.ResumeLayout(false);
            this.tabBarSplitterControl.PerformLayout();
            this.gridCMStrip.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        internal ArrayList HiddenSheets = new ArrayList();

        //Add the sheet 
        int i = 0;
        private void MyInit()
        {
            # region Initial Settings
            this.tabBarSplitterControl.SuspendLayout();
            this.SuspendLayout();
            this.tabBarSplitterControl.TabBarPageAdding += new TabBarPageAddingHandler(tabBarSplitterControl_TabBarPageAdding);
            TabBarPage tabBarPage = new TabBarPage();
            tabBarPage.TabBackColor = Color.FromArgb(219, 232, 249);
            GridControl _grid;
            GridModel model = new GridModel();
            SampleGrid.SetupGridModel(model);
            _grid = new SampleGrid(model);
            // 
            // _grid
            // 
            _grid.ContextMenuStrip = gridCMStrip;
            _grid.Location = new System.Drawing.Point(0, 0);
            _grid.Name = string.Format("gridControl{0}", i + 1);
            _grid.SmartSizeBox = false;
            _grid.Text = string.Format("gridControl{0}", i + 1);

            // 
            // tabBarPage
            // 
            _grid.PersistAppearanceSettings = false;
            _grid.ThemesEnabled = false;
            _grid.GridVisualStyles = GridVisualStyles.Metro;
            model.Options.GridVisualStyles = GridVisualStyles.Metro;
            GridMetroColors grid = new GridMetroColors();
            grid.HeaderColor.NormalColor = Color.Red;
            _grid.SetMetroStyle(grid);
            tabBarPage.Controls.Add(_grid);
            tabBarPage.Location = new System.Drawing.Point(0, 0);
            tabBarPage.Name = string.Format("tabBarPage{0}", i + 1);
            tabBarPage.SplitBars = Syncfusion.Windows.Forms.DynamicSplitBars.Both;
            tabBarPage.Text = string.Format("Sheet{0}", i + 1);
            //tabBarPage.ThemesEnabled = true;
            this.tabBarSplitterControl.TabBarPages.Add(tabBarPage);

            this._grid.Model.Properties.MarkColHeader = true;
            this._grid.Model.Properties.MarkRowHeader = true;

            this._grid.CurrentCellMoved += _grid_CurrentCellMoved;
            this._grid.SelectionChanged += _grid_SelectionChanged;
            this._grid.PrepareViewStyleInfo += _grid_PrepareViewStyleInfo;
            i++;
            this._grid.TableStyle.WrapText = false;
            this.tabBarSplitterControl.ResumeLayout(true);
            this.ResumeLayout(true);
            #endregion
        }

        #endregion

        #region Create New Sheet

        /// <summary>
        /// Add a new worksheet for the SpreadsheetControl
        /// </summary>
        public void AddNewWorkheet()
        {
            TabBarPage tabBarPage = new TabBarPage();
            tabBarPage.TabBackColor = Color.FromArgb(219, 232, 249);
            GridControl _grid;
            GridModel model = new GridModel();
            SampleGrid.SetupGridModel(model);
            _grid = new SampleGrid(model);

            // 
            // _grid
            // 
            _grid.MarkColHeader = true;
            _grid.MarkRowHeader = true;
            _grid.ContextMenuStrip = gridCMStrip;
            _grid.Location = new System.Drawing.Point(0, 0);
            _grid.Name = string.Format("gridControl{0}", i + 1);
            _grid.SmartSizeBox = false;
            _grid.Text = string.Format("gridControl{0}", i + 1);
            _grid.ThemesEnabled = true;

            this.tabBarSplitterControl.ActivePageChanged += new ControlEventHandler(tabBarSplitterControl_ActivePageChanged);
            // 
            // tabBarPage
            // 
            tabBarPage.Controls.Add(_grid);
            tabBarPage.Location = new System.Drawing.Point(0, 0);
            tabBarPage.Name = string.Format("tabBarPage{0}", i + 1);
            tabBarPage.SplitBars = Syncfusion.Windows.Forms.DynamicSplitBars.Both;
            tabBarPage.ForeColor = Color.Green;
            tabBarPage.Text = string.Format("Sheet{0}", i + 1);
            this.tabBarSplitterControl.TabBarPages.Add(tabBarPage);
            i++;
        }
        #endregion
        
        #region Methods
        internal void Paste()
        {
            this._grid.Focus();
            this._grid.Model.CutPaste.Paste();
        }

        internal void Cut()
        {
            this._grid.Focus();
            this._grid.Model.CutPaste.Cut();
        }

        internal void Copy()
        {
            this._grid.Focus();
            this._grid.Model.CutPaste.Copy();
        }

        internal void FontNameChanged(string fontName)
        {
            GridStyleInfo style = new GridStyleInfo();
            style.Font.Facename = fontName;
            if (this._grid.Selections.Ranges.Count != 0)
                this._grid.ChangeCells(this._grid.Selections.Ranges.ActiveRange, style);
            else
                this._grid.ChangeCells(GridRangeInfo.Cell(this._grid.CurrentCell.RowIndex, this._grid.CurrentCell.ColIndex), style);
        }

        internal void FontSizeChanged(string fontSize)
        {
            GridStyleInfo style = new GridStyleInfo();
            style.Font.Size = Convert.ToInt64(fontSize);
            if (this._grid.Selections.Ranges.Count != 0)
                this._grid.ChangeCells(this._grid.Selections.Ranges.ActiveRange, style);
            else
                this._grid.ChangeCells(GridRangeInfo.Cell(this._grid.CurrentCell.RowIndex, this._grid.CurrentCell.ColIndex), style);
        }

        internal float FontSizeIncrease()
        {
            GridStyleInfo style = new GridStyleInfo();
            style.Font.Size = this._grid[this._grid.CurrentCell.RowIndex, this._grid.CurrentCell.ColIndex].Font.Size;
            style.Font.Size += 2;
            if (this._grid.Selections.Ranges.Count != 0)
            {
                this._grid.ChangeCells(this._grid.Selections.Ranges.ActiveRange, style);
            }
            else
            {
                this._grid.ChangeCells(GridRangeInfo.Cell(this._grid.CurrentCell.RowIndex, this._grid.CurrentCell.ColIndex), style);
            }
            return this._grid[this._grid.CurrentCell.RowIndex, this._grid.CurrentCell.ColIndex].Font.Size;
        }

        internal float FontSizeDecrease()
        {
            if (this._grid[this._grid.CurrentCell.RowIndex, this._grid.CurrentCell.ColIndex].Font.Size > 2)
            {
                GridStyleInfo style = new GridStyleInfo();
                style.Font.Size = this._grid[this._grid.CurrentCell.RowIndex, this._grid.CurrentCell.ColIndex].Font.Size;
                style.Font.Size -= 2;
                if (this._grid.Selections.Ranges.Count != 0)
                {
                    this._grid.ChangeCells(this._grid.Selections.Ranges.ActiveRange, style);
                }
                else
                {
                    this._grid.ChangeCells(GridRangeInfo.Cell(this._grid.CurrentCell.RowIndex, this._grid.CurrentCell.ColIndex), style);
                }
            }
            return this._grid[this._grid.CurrentCell.RowIndex, this._grid.CurrentCell.ColIndex].Font.Size;
        }

        internal void UnderLine(bool underLine)
        {
            GridStyleInfo style = new GridStyleInfo();
            if (underLine)
                style.Font.Underline = true;
            else
                style.Font.Underline = false;
            if (this._grid.Selections.Ranges.Count != 0)
                this._grid.ChangeCells(this._grid.Selections.Ranges.ActiveRange, style);
            else
                this._grid.ChangeCells(GridRangeInfo.Cell(this._grid.CurrentCell.RowIndex, this._grid.CurrentCell.ColIndex), style);
        }

        internal void Italic(bool italic)
        {
            GridStyleInfo style = new GridStyleInfo();
            if (italic)
                style.Font.Italic = true;
            else
                style.Font.Italic = false;
            if (this._grid.Selections.Ranges.Count != 0)
                this._grid.ChangeCells(this._grid.Selections.Ranges.ActiveRange, style);
            else
                this._grid.ChangeCells(GridRangeInfo.Cell(this._grid.CurrentCell.RowIndex, this._grid.CurrentCell.ColIndex), style);
        }

        internal void Bold(bool bold)
        {
            GridStyleInfo style = new GridStyleInfo();
            if (bold)
                style.Font.Bold = true;
            else
                style.Font.Bold = false;

            if (this._grid.Selections.Ranges.Count != 0)
                this._grid.ChangeCells(this._grid.Selections.Ranges.ActiveRange, style);
            else
                this._grid.ChangeCells(GridRangeInfo.Cell(this._grid.CurrentCell.RowIndex, this._grid.CurrentCell.ColIndex), style);
        }

        internal void TopBorder()
        {
            GridStyleInfo style = new GridStyleInfo();
            style.Borders.Top = new GridBorder(GridBorderStyle.Solid);

            if (this._grid.Selections.Ranges.Count != 0)
                this._grid.ChangeCells(GridRangeInfo.Cells(
                    this._grid.Selections.Ranges.ActiveRange.Top,
                    this._grid.Selections.Ranges.ActiveRange.Left,
                    this._grid.Selections.Ranges.ActiveRange.Top,
                    this._grid.Selections.Ranges.ActiveRange.Right),
                    style);
            else
                this._grid.ChangeCells(GridRangeInfo.Cell(this._grid.CurrentCell.RowIndex, this._grid.CurrentCell.ColIndex), style);
        }

        internal void BottomBorder()
        {
            GridStyleInfo style = new GridStyleInfo();
            style.Borders.Bottom = new GridBorder(GridBorderStyle.Solid);

            if (this._grid.Selections.Ranges.Count != 0)
                this._grid.ChangeCells(GridRangeInfo.Cells(
                    this._grid.Selections.Ranges.ActiveRange.Bottom,
                    this._grid.Selections.Ranges.ActiveRange.Left,
                    this._grid.Selections.Ranges.ActiveRange.Bottom,
                    this._grid.Selections.Ranges.ActiveRange.Right),
                    style);
            else
                this._grid.ChangeCells(GridRangeInfo.Cell(this._grid.CurrentCell.RowIndex, this._grid.CurrentCell.ColIndex), style);
        }

        internal void NoBorder()
        {
            GridStyleInfo style = new GridStyleInfo();
            style.Borders.All = new GridBorder(GridBorderStyle.Standard);

            if (this._grid.Selections.Ranges.Count != 0)
                this._grid.ChangeCells(this._grid.Selections.Ranges.ActiveRange, style);
            else
                this._grid.ChangeCells(GridRangeInfo.Cell(this._grid.CurrentCell.RowIndex, this._grid.CurrentCell.ColIndex), style);
        }

        internal void LeftBorder()
        {
            GridStyleInfo style = new GridStyleInfo();
            style.Borders.Left = new GridBorder(GridBorderStyle.Solid);

            if (this._grid.Selections.Ranges.Count != 0)
                this._grid.ChangeCells(GridRangeInfo.Cells(
                    this._grid.Selections.Ranges.ActiveRange.Top,
                    this._grid.Selections.Ranges.ActiveRange.Left,
                    this._grid.Selections.Ranges.ActiveRange.Bottom,
                    this._grid.Selections.Ranges.ActiveRange.Left),
                    style);
            else
                this._grid.ChangeCells(GridRangeInfo.Cell(this._grid.CurrentCell.RowIndex, this._grid.CurrentCell.ColIndex), style);
        }

        internal void RightBorder()
        {
            GridStyleInfo style = new GridStyleInfo();
            style.Borders.Right = new GridBorder(GridBorderStyle.Solid);

            if (this._grid.Selections.Ranges.Count != 0)
                this._grid.ChangeCells(GridRangeInfo.Cells(
                    this._grid.Selections.Ranges.ActiveRange.Top,
                    this._grid.Selections.Ranges.ActiveRange.Right,
                    this._grid.Selections.Ranges.ActiveRange.Bottom,
                    this._grid.Selections.Ranges.ActiveRange.Right),
                    style);
            else
                this._grid.ChangeCells(GridRangeInfo.Cell(this._grid.CurrentCell.RowIndex, this._grid.CurrentCell.ColIndex), style);
        }

        internal void WrapText(bool wrapText)
        {
            GridStyleInfo style = new GridStyleInfo();
            if (wrapText)
                style.WrapText = true;
            else
                style.WrapText = false;

            if (this._grid.Selections.Ranges.Count != 0)
                this._grid.ChangeCells(this._grid.Selections.Ranges.ActiveRange, style);
            else
                this._grid.ChangeCells(GridRangeInfo.Cell(this._grid.CurrentCell.RowIndex, this._grid.CurrentCell.ColIndex), style);
        }

        internal void MergeCells(bool merge)
        {
            if (merge)
            {
                if (this._grid.Selections.Ranges.Count != 0)
                    this._grid.CoveredRanges.Add(this._grid.Selections.Ranges.ActiveRange);
                else
                    this._grid.CoveredRanges.Add(GridRangeInfo.Cell(this._grid.CurrentCell.RowIndex, this._grid.CurrentCell.ColIndex));
                this._grid.CurrentCell.MoveTo(this._grid.CurrentCell.RowIndex, this._grid.CurrentCell.ColIndex);
            }
            else
            {
                foreach (GridRangeInfo range in _grid.Model.CoveredRanges.Ranges)
                {
                    if (range.Top == _grid.CurrentCell.RowIndex && range.Left == _grid.CurrentCell.ColIndex)
                    {
                        this._grid.CoveredRanges.Remove(range);
                        break;
                    }
                }
            }
        }

        internal void TopAlign(bool topAlign)
        {
            GridStyleInfo style = new GridStyleInfo();
            style.VerticalAlignment = GridVerticalAlignment.Top;
            if (this._grid.Selections.Ranges.Count != 0)
                this._grid.ChangeCells(this._grid.Selections.Ranges.ActiveRange, style);
            else
                this._grid.ChangeCells(GridRangeInfo.Cell(this._grid.CurrentCell.RowIndex, this._grid.CurrentCell.ColIndex), style);
        }

        internal void MiddleAlign(bool middleAlign)
        {
            GridStyleInfo style = new GridStyleInfo();
            if (middleAlign)
                style.VerticalAlignment = GridVerticalAlignment.Middle;
            else

                style.VerticalAlignment = GridVerticalAlignment.Top;
            if (this._grid.Selections.Ranges.Count != 0)
                this._grid.ChangeCells(this._grid.Selections.Ranges.ActiveRange, style);
            else
                this._grid.ChangeCells(GridRangeInfo.Cell(this._grid.CurrentCell.RowIndex, this._grid.CurrentCell.ColIndex), style);
        }

        internal void BottomAlign(bool bottomAlign)
        {
            GridStyleInfo style = new GridStyleInfo();
            if (bottomAlign)
                style.VerticalAlignment = GridVerticalAlignment.Bottom;
            else
                style.VerticalAlignment = GridVerticalAlignment.Top;
            if (this._grid.Selections.Ranges.Count != 0)
                this._grid.ChangeCells(this._grid.Selections.Ranges.ActiveRange, style);
            else
                this._grid.ChangeCells(GridRangeInfo.Cell(this._grid.CurrentCell.RowIndex, this._grid.CurrentCell.ColIndex), style);
        }

        internal void LeftAlign(bool leftAlign)
        {
            GridStyleInfo style = new GridStyleInfo();
            style.HorizontalAlignment = GridHorizontalAlignment.Left;
            if (this._grid.Selections.Ranges.Count != 0)
                this._grid.ChangeCells(this._grid.Selections.Ranges.ActiveRange, style);
            else
                this._grid.ChangeCells(GridRangeInfo.Cell(this._grid.CurrentCell.RowIndex, this._grid.CurrentCell.ColIndex), style);
        }

        internal void RightAlign(bool rightAlign)
        {
            GridStyleInfo style = new GridStyleInfo();
            if (rightAlign)
                style.HorizontalAlignment = GridHorizontalAlignment.Right;
            else
                style.HorizontalAlignment = GridHorizontalAlignment.Left;
            if (this._grid.Selections.Ranges.Count != 0)
                this._grid.ChangeCells(this._grid.Selections.Ranges.ActiveRange, style);
            else
                this._grid.ChangeCells(GridRangeInfo.Cell(this._grid.CurrentCell.RowIndex, this._grid.CurrentCell.ColIndex), style);
        }

        internal void CenterAlign(bool centerAlign)
        {
            GridStyleInfo style = new GridStyleInfo();
            if (centerAlign)
                style.HorizontalAlignment = GridHorizontalAlignment.Center;
            else
                style.HorizontalAlignment = GridHorizontalAlignment.Left;
            if (this._grid.Selections.Ranges.Count != 0)
                this._grid.ChangeCells(this._grid.Selections.Ranges.ActiveRange, style);
            else
                this._grid.ChangeCells(GridRangeInfo.Cell(this._grid.CurrentCell.RowIndex, this._grid.CurrentCell.ColIndex), style);
        }

        internal void PageLayout(bool pageLayout)
        {
            if (layoutHelper != null)
                layoutHelper.ShowLayoutLines = pageLayout;
        }

        internal void ShowLines(bool showLines)
        {
            if (showLines)
            {
                _grid.DisplayHorizontalLines = true;
                _grid.DisplayVerticalLines = true;
            }
            else
            {
                _grid.DisplayHorizontalLines = false;
                _grid.DisplayVerticalLines = false;
            }
        }

        internal void ShowRowHeader(bool showHeader)
        {
            if (showHeader)
            {
                _grid.ShowRowHeaders = true;
                _grid.ShowColumnHeaders = true;
            }
            else
            {
                _grid.ShowRowHeaders = false;
                _grid.ShowColumnHeaders = false;
            }
        }

        internal void Freeze(bool freeze)
        {
            if (freeze)
            {
                this._grid.Cols.FrozenCount = this._grid.CurrentCell.ColIndex - 1;
                this._grid.Rows.FrozenCount = this._grid.CurrentCell.RowIndex - 1;
            }
            else
            {
                this._grid.Cols.FrozenCount = 0;
                this._grid.Rows.FrozenCount = 0;
            }
        }

        internal void TextColorChanged(Color color)
        {
            GridStyleInfo style = new GridStyleInfo();
            style.TextColor = color;
            if (this._grid.Selections.Ranges.Count != 0)
                this._grid.ChangeCells(this._grid.Selections.Ranges.ActiveRange, style);
            else
                this._grid.ChangeCells(GridRangeInfo.Cell(this._grid.CurrentCell.RowIndex, this._grid.CurrentCell.ColIndex), style);

        }

        internal void BackColorChanged(Color color)
        {
            GridStyleInfo style = new GridStyleInfo();
            style.BackColor = color;
            if (this._grid.Selections.Ranges.Count != 0)
                this._grid.ChangeCells(this._grid.Selections.Ranges.ActiveRange, style);
            else
                this._grid.ChangeCells(GridRangeInfo.Cell(this._grid.CurrentCell.RowIndex, this._grid.CurrentCell.ColIndex), style);

        }

        internal void RejectChanges()
        {
            this._grid.CurrentCell.Renderer.ControlText = "";
        }

        internal void AcceptChanges()
        {
            this._grid.CurrentCell.EndEdit();
        }

        //Register grids
        internal void RegisterGrid()
        {
            foreach (TabBarPage page in this.tabBarSplitterControl.TabBarPages)
            {
                GridControl grid = null;
                foreach (Control control in page.Controls)
                    if (control is GridControl)
                    {
                        grid = control as GridControl;
                        break;
                    }
                if (grid != null)
                {
                    GridFormulaEngine.RegisterGridAsSheet(page.Text, grid.Model, 1);
                    grid.Model.Refresh();
                }
            }
            foreach (TabBarPage page in this.HiddenSheets)
            {
                GridControl grid = null;
                foreach (Control control in page.Controls)
                    if (control is GridControl)
                    {
                        grid = control as GridControl;
                        break;
                    }
                if (grid != null)
                {
                    GridFormulaEngine.RegisterGridAsSheet(page.Text, grid.Model, 1);
                    grid.Model.Refresh();
                }
            }
        }

        internal void InvalidateFormulaCell()
        {
            GridRangeInfo range = new GridRangeInfo();
            range = this._grid.RectangleToRangeInfo(this._grid.Bounds);
            for (int r = range.Top; r < range.Bottom; r++)
                for (int c = range.Left; c < range.Right; c++)
                    if (this._grid[r, c].HasFormulaTag)
                        this._grid[r, c].FormulaTag = null;
        }
        #endregion

        # region Menu Handlers
        private void insertSheetMenuItem_Click(object sender, System.EventArgs e)
        {
            TabBarPage tabBarPage = new TabBarPage();
            tabBarPage.TabBackColor = Color.FromArgb(219, 232, 249);
            GridControl _grid = new GridControl();
            int indx = this.tabBarSplitterControl.TabBarPages.IndexOf(this.tabBarSplitterControl.ActivePage);
            int oIndx = this.tabBarSplitterControl.TabBarPages.Count + 1;

            GridModel model = new GridModel();
            SampleGrid.SetupGridModel(model);
            _grid = new SampleGrid(model);
            // 
            // _grid
            // 
            _grid.ContextMenuStrip = gridCMStrip;
            _grid.Location = new System.Drawing.Point(0, 0);
            _grid.Name = string.Format("gridControl{0}", oIndx);
            _grid.SmartSizeBox = false;
            _grid.Text = string.Format("gridControl{0}", oIndx);
            _grid.ThemesEnabled = false;

            // 
            // tabBarPage
            // 
            tabBarPage.Controls.Add(_grid);
            tabBarPage.Location = new System.Drawing.Point(0, 0);
            tabBarPage.Name = string.Format("tabBarPage{0}", oIndx);
            tabBarPage.SplitBars = Syncfusion.Windows.Forms.DynamicSplitBars.Both;
            tabBarPage.Text = string.Format("Sheet{0}", oIndx);
            tabBarPage.ThemesEnabled = true;
            _grid.ThemesEnabled = false;
            GridFormulaEngine.RegisterGridAsSheet(string.Format("Sheet{0}", oIndx), _grid.Model, 1);

            this.tabBarSplitterControl.TabBarPages.Add(tabBarPage);
        }

        private void deleteSheetMenuItem_Click(object sender, System.EventArgs e)
        {
            if (this.tabBarSplitterControl.TabBarPages.Count > 1)
            {
                TabBarPage page = this.tabBarSplitterControl.ActivePage;
                this.tabBarSplitterControl.ActivateNextPage(true);
                this.tabBarSplitterControl.TabBarPages.Remove(page);
            }
        }

        private void HyperLinkMenuItem_Click(object sender, System.EventArgs e)
        {
            GridCurrentCell cc = this._grid.CurrentCell;
            GridStyleInfo style = this._grid.Model[cc.RowIndex, cc.ColIndex];
            if (style.CellType == "LinkLabel")
                style.CellType = "FormulaCell";
            else
            {
                style.CellType = "LinkLabel";
                style.Tag = style.Text;
            }
        }

        private void cutMenuItem_Click(object sender, System.EventArgs e)
        {
            this._grid.Model.CutPaste.Cut();
        }

        private void copyMenuItem_Click(object sender, System.EventArgs e)
        {
            this._grid.Model.CutPaste.Copy();
        }

        private void pasteMenuItem_Click(object sender, System.EventArgs e)
        {
            this._grid.Model.CutPaste.Paste();
        }

        private void deleteMenuItem_Click_1(object sender, System.EventArgs e)
        {
            this._grid.Model.Clear(true);
        }
        # endregion

        #region Events

        void _grid_CurrentCellActivated(object sender, EventArgs e)
        {
            form.UpdateFontStyles(_grid);
        }
        
        void _grid_CurrentCellMoved(object sender, GridCurrentCellMovedEventArgs e)
        {
            GridCurrentCell cc = this._grid.CurrentCell;
            this._grid.RefreshRange(GridRangeInfo.Cell(0, cc.MoveFromColIndex));
            this._grid.RefreshRange(GridRangeInfo.Cell(0, cc.MoveToColIndex));
            this._grid.RefreshRange(GridRangeInfo.Cell(cc.MoveFromRowIndex, 0));
            this._grid.RefreshRange(GridRangeInfo.Cell(cc.MoveToRowIndex, 0));
        }

        void _grid_PrepareViewStyleInfo(object sender, GridPrepareViewStyleInfoEventArgs e)
        {
            GridControl grid = (GridControl)sender;
            GridCurrentCell cc = grid.CurrentCell;
            if (grid.Selections.Ranges.Count != 0)
            {
                for (int i = 0; i < grid.Selections.Ranges.Count; i++)
                {
                    GridRangeInfo gri = grid.Selections.Ranges[i];
                    if ((e.ColIndex >= gri.Left && e.ColIndex <= gri.Right && e.RowIndex == 0) ||
                            (e.RowIndex >= gri.Top && e.RowIndex <= gri.Bottom && e.ColIndex == 0))
                    {
                        e.Style.BackColor = Color.LightBlue;
                        break;
                    }
                }
            }
            else if (cc != null)
            {
                if ((e.ColIndex == cc.ColIndex && e.RowIndex == 0) || (e.RowIndex == cc.RowIndex && e.ColIndex == 0))
                {
                    e.Style.BackColor = Color.LightBlue;
                }
            }
        }

        void _grid_SelectionChanged(object sender, GridSelectionChangedEventArgs e)
        {
            if (sender is GridControl)
            {
                GridControl grid = (GridControl)sender;
                grid.RefreshRange(GridRangeInfo.Row(0));
                grid.RefreshRange(GridRangeInfo.Col(0));
            }
        }
        
        void tabBarSplitterControl_TabBarPageAdding(object sender, TabBarPageAddingEventArgs arg)
        {
            arg.Cancel = true;
            AddNewWorkheet();
        }

        private void tabBarSplitterControl_ActivePageChanging(object sender, System.Windows.Forms.ControlEventArgs e)
        {
            if (e.Control != null)
                foreach (Control control in e.Control.Controls)
                {
                    if (control is GridControl)
                    {
                        this._grid = control as GridControl;
                        break;
                    }
                }
            if (this._grid != null)
            {
                this.gridAwareTextBox1.WireGrid(this._grid);
                this.gridAwareTextBox2.WireGrid(this._grid);
                layoutHelper = new LayoutSupportHelper(this._grid);
                this._grid.VisibleChanged += new EventHandler(_grid_VisibleChanged);
            }
        }
        
        private void tabBarSplitterControl_PaneCreated(object sender, Syncfusion.Windows.Forms.SplitterPaneEventArgs e)
        {
            this._grid = (GridControl)e.Control;
            _grid.ContextMenuStrip = gridCMStrip;
            this.gridAwareTextBox1.WireGrid(this._grid);
            this.gridAwareTextBox2.WireGrid(this._grid);
            this._grid.VisibleChanged += new EventHandler(_grid_VisibleChanged);
        }
        
        private void WorkBook_Activated(object sender, System.EventArgs e)
        {
            (this.MdiParent as Form1).workBook = this;
            (this.MdiParent as Form1).gridAwareTextBoxItem1.WireGridAwareTextBox(this.gridAwareTextBox1, this._grid, true);
            (this.MdiParent as Form1).gridAwareTextBoxItem2.WireGridAwareTextBox(this.gridAwareTextBox2, this._grid, false);
            this.RegisterGrid();
        }

        private void WorkBook_Deactivate(object sender, System.EventArgs e)
        {
            (this.MdiParent as Form1).workBook = null;
        }

        private void _grid_VisibleChanged(object sender, EventArgs e)
        {
            this.InvalidateFormulaCell();
        }

        private void tabBarSplitterControl_ActivePageChanged(object sender, ControlEventArgs e)
        {
            //Change the Formula Bar Text to reflect the current selection in the active page
            TabBarPage page = this.tabBarSplitterControl.ActivePage;
            if (page != null)
            {
                GridControl grid = null;

                if (page.Controls.Count > 1 && page.Controls[1] is GridControl)
                    grid = page.Controls[1] as GridControl;
                GridCurrentCell cc = grid.CurrentCell;
                this.gridAwareTextBox2.Text = grid[cc.RowIndex, cc.ColIndex].Text;
                grid.CurrentCellActivated += _grid_CurrentCellActivated;
            }
        }
        #endregion
    }
}
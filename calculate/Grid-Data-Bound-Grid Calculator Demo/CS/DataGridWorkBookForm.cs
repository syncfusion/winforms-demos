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
using Syncfusion.Calculate;
using Syncfusion.Windows.Forms.Grid;
using DemoCommon.Grid;
using Syncfusion.Windows.Forms;

namespace GridDataBoundGridCalculator
{
	/// <summary>
	/// Summary description for GridDataBoundGridWorkBook.
	/// </summary>
	public class GridDataBoundGridWorkBookForm : GridDemoForm
	{
		private GridDataBoundGridCalculator.CalcGridDataBoundGrid gridDataBoundGrid1;
		private GridDataBoundGridCalculator.CalcGridDataBoundGrid gridDataBoundGrid2;
		private GridDataBoundGridCalculator.CalcGridDataBoundGrid gridDataBoundGrid3;
		private GridDataBoundGridCalculator.CalcGridDataBoundGrid gridDataBoundGrid4;
		private GridDataBoundGridCalculator.CalcGridDataBoundGrid gridDataBoundGrid5;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.Label label1;
		private Syncfusion.Windows.Forms.TabBarSplitterControl tabBarSplitterControl1;
		private Syncfusion.Windows.Forms.TabBarPage tabBarPage1;
		private Syncfusion.Windows.Forms.TabBarPage tabBarPage2;
		private Syncfusion.Windows.Forms.TabBarPage tabBarPage3;
		private Syncfusion.Windows.Forms.TabBarPage tabBarPage4;
		private Syncfusion.Windows.Forms.TabBarPage tabBarPage5;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public GridDataBoundGridWorkBookForm()
		{
			//
			// Required for Windows Form Designer support.
			//
			InitializeComponent();
            if (DpiAware.GetCurrentDpi() > 96)
            {
                this.CaptionBarHeight = (int)DpiAware.LogicalToDeviceUnits(this.CaptionBarHeight);
            }
            //
            // TODO: Add any constructor code after InitializeComponent call
            //
        }

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support; do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            Syncfusion.Windows.Forms.Grid.GridBaseStyle gridBaseStyle1 = new Syncfusion.Windows.Forms.Grid.GridBaseStyle();
            Syncfusion.Windows.Forms.Grid.GridBaseStyle gridBaseStyle2 = new Syncfusion.Windows.Forms.Grid.GridBaseStyle();
            Syncfusion.Windows.Forms.Grid.GridBaseStyle gridBaseStyle3 = new Syncfusion.Windows.Forms.Grid.GridBaseStyle();
            Syncfusion.Windows.Forms.Grid.GridBaseStyle gridBaseStyle4 = new Syncfusion.Windows.Forms.Grid.GridBaseStyle();
            Syncfusion.Windows.Forms.Grid.GridBaseStyle gridBaseStyle5 = new Syncfusion.Windows.Forms.Grid.GridBaseStyle();
            Syncfusion.Windows.Forms.Grid.GridBaseStyle gridBaseStyle6 = new Syncfusion.Windows.Forms.Grid.GridBaseStyle();
            Syncfusion.Windows.Forms.Grid.GridBaseStyle gridBaseStyle7 = new Syncfusion.Windows.Forms.Grid.GridBaseStyle();
            Syncfusion.Windows.Forms.Grid.GridBaseStyle gridBaseStyle8 = new Syncfusion.Windows.Forms.Grid.GridBaseStyle();
            Syncfusion.Windows.Forms.Grid.GridBaseStyle gridBaseStyle9 = new Syncfusion.Windows.Forms.Grid.GridBaseStyle();
            Syncfusion.Windows.Forms.Grid.GridBaseStyle gridBaseStyle10 = new Syncfusion.Windows.Forms.Grid.GridBaseStyle();
            Syncfusion.Windows.Forms.Grid.GridBaseStyle gridBaseStyle11 = new Syncfusion.Windows.Forms.Grid.GridBaseStyle();
            Syncfusion.Windows.Forms.Grid.GridBaseStyle gridBaseStyle12 = new Syncfusion.Windows.Forms.Grid.GridBaseStyle();
            Syncfusion.Windows.Forms.Grid.GridBaseStyle gridBaseStyle13 = new Syncfusion.Windows.Forms.Grid.GridBaseStyle();
            Syncfusion.Windows.Forms.Grid.GridBaseStyle gridBaseStyle14 = new Syncfusion.Windows.Forms.Grid.GridBaseStyle();
            Syncfusion.Windows.Forms.Grid.GridBaseStyle gridBaseStyle15 = new Syncfusion.Windows.Forms.Grid.GridBaseStyle();
            Syncfusion.Windows.Forms.Grid.GridBaseStyle gridBaseStyle16 = new Syncfusion.Windows.Forms.Grid.GridBaseStyle();
            Syncfusion.Windows.Forms.Grid.GridBaseStyle gridBaseStyle17 = new Syncfusion.Windows.Forms.Grid.GridBaseStyle();
            Syncfusion.Windows.Forms.Grid.GridBaseStyle gridBaseStyle18 = new Syncfusion.Windows.Forms.Grid.GridBaseStyle();
            Syncfusion.Windows.Forms.Grid.GridBaseStyle gridBaseStyle19 = new Syncfusion.Windows.Forms.Grid.GridBaseStyle();
            Syncfusion.Windows.Forms.Grid.GridBaseStyle gridBaseStyle20 = new Syncfusion.Windows.Forms.Grid.GridBaseStyle();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabBarSplitterControl1 = new Syncfusion.Windows.Forms.TabBarSplitterControl();
            this.tabBarPage1 = new Syncfusion.Windows.Forms.TabBarPage();
            this.gridDataBoundGrid1 = new GridDataBoundGridCalculator.CalcGridDataBoundGrid();
            this.tabBarPage2 = new Syncfusion.Windows.Forms.TabBarPage();
            this.gridDataBoundGrid2 = new GridDataBoundGridCalculator.CalcGridDataBoundGrid();
            this.tabBarPage3 = new Syncfusion.Windows.Forms.TabBarPage();
            this.gridDataBoundGrid3 = new GridDataBoundGridCalculator.CalcGridDataBoundGrid();
            this.tabBarPage4 = new Syncfusion.Windows.Forms.TabBarPage();
            this.gridDataBoundGrid4 = new GridDataBoundGridCalculator.CalcGridDataBoundGrid();
            this.tabBarPage5 = new Syncfusion.Windows.Forms.TabBarPage();
            this.gridDataBoundGrid5 = new GridDataBoundGridCalculator.CalcGridDataBoundGrid();
            this.tabBarSplitterControl1.SuspendLayout();
            this.tabBarPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridDataBoundGrid1)).BeginInit();
            this.tabBarPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridDataBoundGrid2)).BeginInit();
            this.tabBarPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridDataBoundGrid3)).BeginInit();
            this.tabBarPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridDataBoundGrid4)).BeginInit();
            this.tabBarPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridDataBoundGrid5)).BeginInit();
            this.SuspendLayout();
            // 
            // checkBox1
            // 
            this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.checkBox1.Location = new System.Drawing.Point(34, 32);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(128, 16);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.Text = "Show Formulas";
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Location = new System.Drawing.Point(320, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(312, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Enter a formula like   = Sum(GDBG2!B2:GDBG2!B5)   into a cell.";
            // 
            // tabBarSplitterControl1
            // 
            this.tabBarSplitterControl1.ActivePageBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(157)))), ((int)(((byte)(217)))));
            this.tabBarSplitterControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tabBarSplitterControl1.BeforeTouchSize = new System.Drawing.Size(592, 360);
            this.tabBarSplitterControl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabBarSplitterControl1.Controls.Add(this.tabBarPage1);
            this.tabBarSplitterControl1.Controls.Add(this.tabBarPage2);
            this.tabBarSplitterControl1.Controls.Add(this.tabBarPage3);
            this.tabBarSplitterControl1.Controls.Add(this.tabBarPage4);
            this.tabBarSplitterControl1.Controls.Add(this.tabBarPage5);
            this.tabBarSplitterControl1.EnabledColor = System.Drawing.SystemColors.WindowText;
            this.tabBarSplitterControl1.Location = new System.Drawing.Point(32, 64);
            this.tabBarSplitterControl1.Name = "tabBarSplitterControl1";
            this.tabBarSplitterControl1.Office2007ScrollBars = true;
            this.tabBarSplitterControl1.Size = new System.Drawing.Size(592, 360);
            this.tabBarSplitterControl1.SplitBars = Syncfusion.Windows.Forms.DynamicSplitBars.None;
            this.tabBarSplitterControl1.Style = Syncfusion.Windows.Forms.TabBarSplitterStyle.Office2007;
            this.tabBarSplitterControl1.TabFolderDelta = 11;
            this.tabBarSplitterControl1.TabIndex = 5;
            this.tabBarSplitterControl1.Text = "tabBarSplitterControl1";
            // 
            // tabBarPage1
            // 
            this.tabBarPage1.Controls.Add(this.gridDataBoundGrid1);
            this.tabBarPage1.Location = new System.Drawing.Point(0, 0);
            this.tabBarPage1.Name = "tabBarPage1";
            this.tabBarPage1.SplitBars = Syncfusion.Windows.Forms.DynamicSplitBars.None;
            this.tabBarPage1.TabBackColor = System.Drawing.SystemColors.Control;
            this.tabBarPage1.TabBarColor = System.Drawing.Color.Empty;
            this.tabBarPage1.TabMaxWidth = 100;
            this.tabBarPage1.Text = "GDBG1";
            this.tabBarPage1.ThemesEnabled = false;
            // 
            // gridDataBoundGrid1
            // 
            this.gridDataBoundGrid1.DpiAware = true;
            this.gridDataBoundGrid1.ActivateCurrentCellBehavior = Syncfusion.Windows.Forms.Grid.GridCellActivateAction.DblClickOnCell;
            this.gridDataBoundGrid1.AllowDragSelectedCols = true;
            this.gridDataBoundGrid1.AlphaBlendSelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(94)))), ((int)(((byte)(171)))), ((int)(((byte)(222)))));
            gridBaseStyle1.Name = "Column Header";
            gridBaseStyle1.StyleInfo.BaseStyle = "Header";
            gridBaseStyle1.StyleInfo.CellType = "ColumnHeaderCell";
            gridBaseStyle1.StyleInfo.Enabled = false;
            gridBaseStyle1.StyleInfo.Font.Bold = true;
            gridBaseStyle1.StyleInfo.HorizontalAlignment = Syncfusion.Windows.Forms.Grid.GridHorizontalAlignment.Center;
            gridBaseStyle2.Name = "Header";
            gridBaseStyle2.StyleInfo.Borders.Bottom = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None);
            gridBaseStyle2.StyleInfo.Borders.Left = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None);
            gridBaseStyle2.StyleInfo.Borders.Right = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None);
            gridBaseStyle2.StyleInfo.Borders.Top = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None);
            gridBaseStyle2.StyleInfo.CellType = "Header";
            gridBaseStyle2.StyleInfo.Font.Bold = true;
            gridBaseStyle2.StyleInfo.Interior = new Syncfusion.Drawing.BrushInfo(System.Drawing.SystemColors.Control);
            gridBaseStyle2.StyleInfo.VerticalAlignment = Syncfusion.Windows.Forms.Grid.GridVerticalAlignment.Middle;
            gridBaseStyle3.Name = "Standard";
            gridBaseStyle3.StyleInfo.CheckBoxOptions.CheckedValue = "True";
            gridBaseStyle3.StyleInfo.CheckBoxOptions.UncheckedValue = "False";
            gridBaseStyle3.StyleInfo.Interior = new Syncfusion.Drawing.BrushInfo(System.Drawing.SystemColors.Window);
            gridBaseStyle4.Name = "Row Header";
            gridBaseStyle4.StyleInfo.BaseStyle = "Header";
            gridBaseStyle4.StyleInfo.CellType = "RowHeaderCell";
            gridBaseStyle4.StyleInfo.Enabled = true;
            gridBaseStyle4.StyleInfo.HorizontalAlignment = Syncfusion.Windows.Forms.Grid.GridHorizontalAlignment.Left;
            this.gridDataBoundGrid1.BaseStylesMap.AddRange(new Syncfusion.Windows.Forms.Grid.GridBaseStyle[] {
            gridBaseStyle1,
            gridBaseStyle2,
            gridBaseStyle3,
            gridBaseStyle4});
            this.gridDataBoundGrid1.DataMember = "";
            this.gridDataBoundGrid1.FillSplitterPane = true;
            this.gridDataBoundGrid1.GridOfficeScrollBars = Syncfusion.Windows.Forms.OfficeScrollBars.Metro;
            this.gridDataBoundGrid1.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro;
            this.gridDataBoundGrid1.DefaultRowHeight = (int)DpiAware.LogicalToDeviceUnits(20.0f);
            this.gridDataBoundGrid1.Location = new System.Drawing.Point(0, 0);
            this.gridDataBoundGrid1.MetroScrollBars = true;
            this.gridDataBoundGrid1.Name = "gridDataBoundGrid1";
            this.gridDataBoundGrid1.Properties.ForceImmediateRepaint = false;
            this.gridDataBoundGrid1.Properties.GridLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.gridDataBoundGrid1.Properties.MarkColHeader = false;
            this.gridDataBoundGrid1.Properties.MarkRowHeader = false;
            this.gridDataBoundGrid1.ShowCurrentCellBorderBehavior = Syncfusion.Windows.Forms.Grid.GridShowCurrentCellBorder.GrayWhenLostFocus;
            this.gridDataBoundGrid1.Size = new System.Drawing.Size(573, 341);
            this.gridDataBoundGrid1.SmartSizeBox = false;
            this.gridDataBoundGrid1.SortBehavior = Syncfusion.Windows.Forms.Grid.GridSortBehavior.None;
            // 
            // tabBarPage2
            // 
            this.tabBarPage2.Controls.Add(this.gridDataBoundGrid2);
            this.tabBarPage2.Location = new System.Drawing.Point(0, 0);
            this.tabBarPage2.Name = "tabBarPage2";
            this.tabBarPage2.SplitBars = ((Syncfusion.Windows.Forms.DynamicSplitBars)((Syncfusion.Windows.Forms.DynamicSplitBars.SplitRows | Syncfusion.Windows.Forms.DynamicSplitBars.SplitColumns)));
            this.tabBarPage2.TabBackColor = System.Drawing.SystemColors.Control;
            this.tabBarPage2.TabBarColor = System.Drawing.Color.Empty;
            this.tabBarPage2.TabMaxWidth = 100;
            this.tabBarPage2.Text = "GDBG2";
            this.tabBarPage2.ThemesEnabled = false;
            // 
            // gridDataBoundGrid2
            // 
            this.gridDataBoundGrid2.DpiAware = true;
            this.gridDataBoundGrid2.ActivateCurrentCellBehavior = Syncfusion.Windows.Forms.Grid.GridCellActivateAction.DblClickOnCell;
            this.gridDataBoundGrid2.AllowDragSelectedCols = true;
            gridBaseStyle5.Name = "Column Header";
            gridBaseStyle5.StyleInfo.BaseStyle = "Header";
            gridBaseStyle5.StyleInfo.CellType = "ColumnHeaderCell";
            gridBaseStyle5.StyleInfo.Enabled = false;
            gridBaseStyle5.StyleInfo.Font.Bold = false;
            gridBaseStyle5.StyleInfo.HorizontalAlignment = Syncfusion.Windows.Forms.Grid.GridHorizontalAlignment.Center;
            gridBaseStyle6.Name = "Header";
            gridBaseStyle6.StyleInfo.Borders.Bottom = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None);
            gridBaseStyle6.StyleInfo.Borders.Left = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None);
            gridBaseStyle6.StyleInfo.Borders.Right = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None);
            gridBaseStyle6.StyleInfo.Borders.Top = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None);
            gridBaseStyle6.StyleInfo.CellType = "Header";
            gridBaseStyle6.StyleInfo.Font.Bold = true;
            gridBaseStyle6.StyleInfo.Interior = new Syncfusion.Drawing.BrushInfo(System.Drawing.SystemColors.Control);
            gridBaseStyle6.StyleInfo.VerticalAlignment = Syncfusion.Windows.Forms.Grid.GridVerticalAlignment.Middle;
            gridBaseStyle7.Name = "Standard";
            gridBaseStyle7.StyleInfo.CheckBoxOptions.CheckedValue = "True";
            gridBaseStyle7.StyleInfo.CheckBoxOptions.UncheckedValue = "False";
            gridBaseStyle7.StyleInfo.Interior = new Syncfusion.Drawing.BrushInfo(System.Drawing.SystemColors.Window);
            gridBaseStyle8.Name = "Row Header";
            gridBaseStyle8.StyleInfo.BaseStyle = "Header";
            gridBaseStyle8.StyleInfo.CellType = "RowHeaderCell";
            gridBaseStyle8.StyleInfo.Enabled = true;
            gridBaseStyle8.StyleInfo.HorizontalAlignment = Syncfusion.Windows.Forms.Grid.GridHorizontalAlignment.Left;
            this.gridDataBoundGrid2.BaseStylesMap.AddRange(new Syncfusion.Windows.Forms.Grid.GridBaseStyle[] {
            gridBaseStyle5,
            gridBaseStyle6,
            gridBaseStyle7,
            gridBaseStyle8});
            this.gridDataBoundGrid2.DataMember = "";
            this.gridDataBoundGrid2.FillSplitterPane = true;
            this.gridDataBoundGrid2.Location = new System.Drawing.Point(136, 112);
            this.gridDataBoundGrid2.Name = "gridDataBoundGrid2";
            this.gridDataBoundGrid2.ShowCurrentCellBorderBehavior = Syncfusion.Windows.Forms.Grid.GridShowCurrentCellBorder.GrayWhenLostFocus;
            this.gridDataBoundGrid2.Size = new System.Drawing.Size(130, 80);
            this.gridDataBoundGrid2.SmartSizeBox = false;
            this.gridDataBoundGrid2.SortBehavior = Syncfusion.Windows.Forms.Grid.GridSortBehavior.None;
            // 
            // tabBarPage3
            // 
            this.tabBarPage3.Controls.Add(this.gridDataBoundGrid3);
            this.tabBarPage3.Location = new System.Drawing.Point(0, 0);
            this.tabBarPage3.Name = "tabBarPage3";
            this.tabBarPage3.SplitBars = ((Syncfusion.Windows.Forms.DynamicSplitBars)((Syncfusion.Windows.Forms.DynamicSplitBars.SplitRows | Syncfusion.Windows.Forms.DynamicSplitBars.SplitColumns)));
            this.tabBarPage3.TabBackColor = System.Drawing.SystemColors.Control;
            this.tabBarPage3.TabBarColor = System.Drawing.Color.Empty;
            this.tabBarPage3.TabMaxWidth = 100;
            this.tabBarPage3.Text = "GDBG3";
            this.tabBarPage3.ThemesEnabled = false;
            // 
            // gridDataBoundGrid3
            // 
            this.gridDataBoundGrid3.DpiAware = true;
            this.gridDataBoundGrid3.ActivateCurrentCellBehavior = Syncfusion.Windows.Forms.Grid.GridCellActivateAction.DblClickOnCell;
            this.gridDataBoundGrid3.AllowDragSelectedCols = true;
            gridBaseStyle9.Name = "Column Header";
            gridBaseStyle9.StyleInfo.BaseStyle = "Header";
            gridBaseStyle9.StyleInfo.CellType = "ColumnHeaderCell";
            gridBaseStyle9.StyleInfo.Enabled = false;
            gridBaseStyle9.StyleInfo.Font.Bold = false;
            gridBaseStyle9.StyleInfo.HorizontalAlignment = Syncfusion.Windows.Forms.Grid.GridHorizontalAlignment.Center;
            gridBaseStyle10.Name = "Header";
            gridBaseStyle10.StyleInfo.Borders.Bottom = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None);
            gridBaseStyle10.StyleInfo.Borders.Left = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None);
            gridBaseStyle10.StyleInfo.Borders.Right = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None);
            gridBaseStyle10.StyleInfo.Borders.Top = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None);
            gridBaseStyle10.StyleInfo.CellType = "Header";
            gridBaseStyle10.StyleInfo.Font.Bold = true;
            gridBaseStyle10.StyleInfo.Interior = new Syncfusion.Drawing.BrushInfo(System.Drawing.SystemColors.Control);
            gridBaseStyle10.StyleInfo.VerticalAlignment = Syncfusion.Windows.Forms.Grid.GridVerticalAlignment.Middle;
            gridBaseStyle11.Name = "Standard";
            gridBaseStyle11.StyleInfo.CheckBoxOptions.CheckedValue = "True";
            gridBaseStyle11.StyleInfo.CheckBoxOptions.UncheckedValue = "False";
            gridBaseStyle11.StyleInfo.Interior = new Syncfusion.Drawing.BrushInfo(System.Drawing.SystemColors.Window);
            gridBaseStyle12.Name = "Row Header";
            gridBaseStyle12.StyleInfo.BaseStyle = "Header";
            gridBaseStyle12.StyleInfo.CellType = "RowHeaderCell";
            gridBaseStyle12.StyleInfo.Enabled = true;
            gridBaseStyle12.StyleInfo.HorizontalAlignment = Syncfusion.Windows.Forms.Grid.GridHorizontalAlignment.Left;
            this.gridDataBoundGrid3.BaseStylesMap.AddRange(new Syncfusion.Windows.Forms.Grid.GridBaseStyle[] {
            gridBaseStyle9,
            gridBaseStyle10,
            gridBaseStyle11,
            gridBaseStyle12});
            this.gridDataBoundGrid3.DataMember = "";
            this.gridDataBoundGrid3.FillSplitterPane = true;
            this.gridDataBoundGrid3.Location = new System.Drawing.Point(136, 136);
            this.gridDataBoundGrid3.Name = "gridDataBoundGrid3";
            this.gridDataBoundGrid3.ShowCurrentCellBorderBehavior = Syncfusion.Windows.Forms.Grid.GridShowCurrentCellBorder.GrayWhenLostFocus;
            this.gridDataBoundGrid3.Size = new System.Drawing.Size(130, 80);
            this.gridDataBoundGrid3.SmartSizeBox = false;
            this.gridDataBoundGrid3.SortBehavior = Syncfusion.Windows.Forms.Grid.GridSortBehavior.None;
            // 
            // tabBarPage4
            // 
            this.tabBarPage4.Controls.Add(this.gridDataBoundGrid4);
            this.tabBarPage4.Location = new System.Drawing.Point(0, 0);
            this.tabBarPage4.Name = "tabBarPage4";
            this.tabBarPage4.SplitBars = ((Syncfusion.Windows.Forms.DynamicSplitBars)((Syncfusion.Windows.Forms.DynamicSplitBars.SplitRows | Syncfusion.Windows.Forms.DynamicSplitBars.SplitColumns)));
            this.tabBarPage4.TabBackColor = System.Drawing.SystemColors.Control;
            this.tabBarPage4.TabBarColor = System.Drawing.Color.Empty;
            this.tabBarPage4.TabMaxWidth = 100;
            this.tabBarPage4.Text = "GDBG4";
            this.tabBarPage4.ThemesEnabled = false;
            // 
            // gridDataBoundGrid4
            // 
            this.gridDataBoundGrid4.DpiAware = true;
            this.gridDataBoundGrid4.ActivateCurrentCellBehavior = Syncfusion.Windows.Forms.Grid.GridCellActivateAction.DblClickOnCell;
            this.gridDataBoundGrid4.AllowDragSelectedCols = true;
            gridBaseStyle13.Name = "Column Header";
            gridBaseStyle13.StyleInfo.BaseStyle = "Header";
            gridBaseStyle13.StyleInfo.CellType = "ColumnHeaderCell";
            gridBaseStyle13.StyleInfo.Enabled = false;
            gridBaseStyle13.StyleInfo.Font.Bold = false;
            gridBaseStyle13.StyleInfo.HorizontalAlignment = Syncfusion.Windows.Forms.Grid.GridHorizontalAlignment.Center;
            gridBaseStyle14.Name = "Header";
            gridBaseStyle14.StyleInfo.Borders.Bottom = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None);
            gridBaseStyle14.StyleInfo.Borders.Left = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None);
            gridBaseStyle14.StyleInfo.Borders.Right = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None);
            gridBaseStyle14.StyleInfo.Borders.Top = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None);
            gridBaseStyle14.StyleInfo.CellType = "Header";
            gridBaseStyle14.StyleInfo.Font.Bold = true;
            gridBaseStyle14.StyleInfo.Interior = new Syncfusion.Drawing.BrushInfo(System.Drawing.SystemColors.Control);
            gridBaseStyle14.StyleInfo.VerticalAlignment = Syncfusion.Windows.Forms.Grid.GridVerticalAlignment.Middle;
            gridBaseStyle15.Name = "Standard";
            gridBaseStyle15.StyleInfo.CheckBoxOptions.CheckedValue = "True";
            gridBaseStyle15.StyleInfo.CheckBoxOptions.UncheckedValue = "False";
            gridBaseStyle15.StyleInfo.Interior = new Syncfusion.Drawing.BrushInfo(System.Drawing.SystemColors.Window);
            gridBaseStyle16.Name = "Row Header";
            gridBaseStyle16.StyleInfo.BaseStyle = "Header";
            gridBaseStyle16.StyleInfo.CellType = "RowHeaderCell";
            gridBaseStyle16.StyleInfo.Enabled = true;
            gridBaseStyle16.StyleInfo.HorizontalAlignment = Syncfusion.Windows.Forms.Grid.GridHorizontalAlignment.Left;
            this.gridDataBoundGrid4.BaseStylesMap.AddRange(new Syncfusion.Windows.Forms.Grid.GridBaseStyle[] {
            gridBaseStyle13,
            gridBaseStyle14,
            gridBaseStyle15,
            gridBaseStyle16});
            this.gridDataBoundGrid4.DataMember = "";
            this.gridDataBoundGrid4.FillSplitterPane = true;
            this.gridDataBoundGrid4.Location = new System.Drawing.Point(112, 112);
            this.gridDataBoundGrid4.Name = "gridDataBoundGrid4";
            this.gridDataBoundGrid4.ShowCurrentCellBorderBehavior = Syncfusion.Windows.Forms.Grid.GridShowCurrentCellBorder.GrayWhenLostFocus;
            this.gridDataBoundGrid4.Size = new System.Drawing.Size(130, 80);
            this.gridDataBoundGrid4.SmartSizeBox = false;
            this.gridDataBoundGrid4.SortBehavior = Syncfusion.Windows.Forms.Grid.GridSortBehavior.None;
            // 
            // tabBarPage5
            // 
            this.tabBarPage5.Controls.Add(this.gridDataBoundGrid5);
            this.tabBarPage5.Location = new System.Drawing.Point(0, 0);
            this.tabBarPage5.Name = "tabBarPage5";
            this.tabBarPage5.SplitBars = ((Syncfusion.Windows.Forms.DynamicSplitBars)((Syncfusion.Windows.Forms.DynamicSplitBars.SplitRows | Syncfusion.Windows.Forms.DynamicSplitBars.SplitColumns)));
            this.tabBarPage5.TabBackColor = System.Drawing.SystemColors.Control;
            this.tabBarPage5.TabBarColor = System.Drawing.Color.Empty;
            this.tabBarPage5.TabMaxWidth = 100;
            this.tabBarPage5.Text = "GDBG5";
            this.tabBarPage5.ThemesEnabled = false;
            // 
            // gridDataBoundGrid5
            // 
            this.gridDataBoundGrid5.DpiAware = true;
            this.gridDataBoundGrid5.ActivateCurrentCellBehavior = Syncfusion.Windows.Forms.Grid.GridCellActivateAction.DblClickOnCell;
            this.gridDataBoundGrid5.AllowDragSelectedCols = true;
            gridBaseStyle17.Name = "Column Header";
            gridBaseStyle17.StyleInfo.BaseStyle = "Header";
            gridBaseStyle17.StyleInfo.CellType = "ColumnHeaderCell";
            gridBaseStyle17.StyleInfo.Enabled = false;
            gridBaseStyle17.StyleInfo.Font.Bold = false;
            gridBaseStyle17.StyleInfo.HorizontalAlignment = Syncfusion.Windows.Forms.Grid.GridHorizontalAlignment.Center;
            gridBaseStyle18.Name = "Header";
            gridBaseStyle18.StyleInfo.Borders.Bottom = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None);
            gridBaseStyle18.StyleInfo.Borders.Left = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None);
            gridBaseStyle18.StyleInfo.Borders.Right = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None);
            gridBaseStyle18.StyleInfo.Borders.Top = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None);
            gridBaseStyle18.StyleInfo.CellType = "Header";
            gridBaseStyle18.StyleInfo.Font.Bold = true;
            gridBaseStyle18.StyleInfo.Interior = new Syncfusion.Drawing.BrushInfo(System.Drawing.SystemColors.Control);
            gridBaseStyle18.StyleInfo.VerticalAlignment = Syncfusion.Windows.Forms.Grid.GridVerticalAlignment.Middle;
            gridBaseStyle19.Name = "Standard";
            gridBaseStyle19.StyleInfo.CheckBoxOptions.CheckedValue = "True";
            gridBaseStyle19.StyleInfo.CheckBoxOptions.UncheckedValue = "False";
            gridBaseStyle19.StyleInfo.Interior = new Syncfusion.Drawing.BrushInfo(System.Drawing.SystemColors.Window);
            gridBaseStyle20.Name = "Row Header";
            gridBaseStyle20.StyleInfo.BaseStyle = "Header";
            gridBaseStyle20.StyleInfo.CellType = "RowHeaderCell";
            gridBaseStyle20.StyleInfo.Enabled = true;
            gridBaseStyle20.StyleInfo.HorizontalAlignment = Syncfusion.Windows.Forms.Grid.GridHorizontalAlignment.Left;
            this.gridDataBoundGrid5.BaseStylesMap.AddRange(new Syncfusion.Windows.Forms.Grid.GridBaseStyle[] {
            gridBaseStyle17,
            gridBaseStyle18,
            gridBaseStyle19,
            gridBaseStyle20});
            this.gridDataBoundGrid5.DataMember = "";
            this.gridDataBoundGrid5.FillSplitterPane = true;
            this.gridDataBoundGrid5.Location = new System.Drawing.Point(144, 96);
            this.gridDataBoundGrid5.Name = "gridDataBoundGrid5";
            this.gridDataBoundGrid5.ShowCurrentCellBorderBehavior = Syncfusion.Windows.Forms.Grid.GridShowCurrentCellBorder.GrayWhenLostFocus;
            this.gridDataBoundGrid5.Size = new System.Drawing.Size(130, 80);
            this.gridDataBoundGrid5.SmartSizeBox = false;
            this.gridDataBoundGrid5.SortBehavior = Syncfusion.Windows.Forms.Grid.GridSortBehavior.None;
            // 
            // GridDataBoundGridWorkBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 454);
            this.Controls.Add(this.tabBarSplitterControl1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBox1);
            this.MinimumSize = new System.Drawing.Size(600, 500);
            this.Name = "GridDataBoundGridWorkBookForm";
            this.Text = "Grid-Data-Bound-Grid Calculator ";
            this.Load += new System.EventHandler(this.gridDataBoundGridWorkBookForm_Load);
            this.tabBarSplitterControl1.ResumeLayout(false);
            this.tabBarPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridDataBoundGrid1)).EndInit();
            this.tabBarPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridDataBoundGrid2)).EndInit();
            this.tabBarPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridDataBoundGrid3)).EndInit();
            this.tabBarPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridDataBoundGrid4)).EndInit();
            this.tabBarPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridDataBoundGrid5)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion


		Syncfusion.Calculate.CalcEngine engine;

		private void gridDataBoundGridWorkBookForm_Load(object sender, System.EventArgs e)
		{
			this.gridDataBoundGrid1.DataSource = GetARandomTable();
			this.gridDataBoundGrid2.DataSource = GetARandomTable();
			this.gridDataBoundGrid3.DataSource = GetARandomTable();
			this.gridDataBoundGrid4.DataSource = GetARandomTable();
			this.gridDataBoundGrid5.DataSource = GetARandomTable();


            this.gridDataBoundGrid1.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro;
            this.gridDataBoundGrid1.Properties.BackgroundColor = System.Drawing.Color.FromArgb(((System.Byte)(227)), ((System.Byte)(239)), ((System.Byte)(255)));
            this.gridDataBoundGrid1.Properties.GridLineColor = System.Drawing.Color.FromArgb(((System.Byte)(208)), ((System.Byte)(215)), ((System.Byte)(229)));
            this.gridDataBoundGrid1.Model.Options.DefaultGridBorderStyle = GridBorderStyle.Solid;
            this.gridDataBoundGrid1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.gridDataBoundGrid1.ThemesEnabled = true;
            this.gridDataBoundGrid1.Model.RowCount = 45;
            this.gridDataBoundGrid1.Font = new System.Drawing.Font("Segoe UI", 8.5F);

            this.gridDataBoundGrid2.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro ;
            this.gridDataBoundGrid2.Properties.BackgroundColor = System.Drawing.Color.FromArgb(((System.Byte)(227)), ((System.Byte)(239)), ((System.Byte)(255)));
            this.gridDataBoundGrid2.Properties.GridLineColor = System.Drawing.Color.FromArgb(((System.Byte)(208)), ((System.Byte)(215)), ((System.Byte)(229)));
            this.gridDataBoundGrid2.Model.Options.DefaultGridBorderStyle = GridBorderStyle.Solid;
            this.gridDataBoundGrid2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.gridDataBoundGrid2.ThemesEnabled = true;
            this.gridDataBoundGrid2.Model.RowCount = 45;
            this.gridDataBoundGrid2.AllowProportionalColumnSizing = true;
            this.gridDataBoundGrid2.Font = new System.Drawing.Font("Segoe UI", 8.5F);

            this.gridDataBoundGrid3.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro;
            this.gridDataBoundGrid3.Properties.BackgroundColor = System.Drawing.Color.FromArgb(((System.Byte)(227)), ((System.Byte)(239)), ((System.Byte)(255)));
            this.gridDataBoundGrid3.Properties.GridLineColor = System.Drawing.Color.FromArgb(((System.Byte)(208)), ((System.Byte)(215)), ((System.Byte)(229)));
            this.gridDataBoundGrid3.Model.Options.DefaultGridBorderStyle = GridBorderStyle.Solid;
            this.gridDataBoundGrid3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.gridDataBoundGrid3.ThemesEnabled = true;
            this.gridDataBoundGrid3.AllowProportionalColumnSizing = true;
            this.gridDataBoundGrid3.Font = new System.Drawing.Font("Segoe UI", 8.5F);

            this.gridDataBoundGrid4.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro;
            this.gridDataBoundGrid4.Properties.BackgroundColor = System.Drawing.Color.FromArgb(((System.Byte)(227)), ((System.Byte)(239)), ((System.Byte)(255)));
            this.gridDataBoundGrid4.Properties.GridLineColor = System.Drawing.Color.FromArgb(((System.Byte)(208)), ((System.Byte)(215)), ((System.Byte)(229)));
            this.gridDataBoundGrid4.Model.Options.DefaultGridBorderStyle = GridBorderStyle.Solid;
            this.gridDataBoundGrid4.ForeColor = System.Drawing.Color.MidnightBlue;
            this.gridDataBoundGrid4.ThemesEnabled = true;
            this.gridDataBoundGrid4.Model.RowCount = 25;
            this.gridDataBoundGrid4.AllowProportionalColumnSizing = true;
            this.gridDataBoundGrid4.Font = new System.Drawing.Font("Segoe UI", 8.5F);

            this.gridDataBoundGrid5.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro;
            this.gridDataBoundGrid5.Properties.BackgroundColor = System.Drawing.Color.FromArgb(((System.Byte)(227)), ((System.Byte)(239)), ((System.Byte)(255)));
            this.gridDataBoundGrid5.Properties.GridLineColor = System.Drawing.Color.FromArgb(((System.Byte)(208)), ((System.Byte)(215)), ((System.Byte)(229)));
            this.gridDataBoundGrid5.Model.Options.DefaultGridBorderStyle = GridBorderStyle.Solid;
            this.gridDataBoundGrid5.ForeColor = System.Drawing.Color.MidnightBlue;
            this.gridDataBoundGrid5.ThemesEnabled = true;
            this.gridDataBoundGrid5.Model.RowCount = 45;
            this.gridDataBoundGrid5.AllowProportionalColumnSizing = true;
            this.gridDataBoundGrid5.Font = new System.Drawing.Font("Segoe UI", 8.5F);

			if(engine == null)
			{
				//Create the engine:
				engine = new Syncfusion.Calculate.CalcEngine(this.gridDataBoundGrid1);
				//Track dependencies required for auto calculations:
				engine.UseDependencies = true;
			
				//Register multiple ICalcData objects for cross sheet references:
				int sheetfamilyID = Syncfusion.Calculate.CalcEngine.CreateSheetFamilyID();
				engine.RegisterGridAsSheet("GDBG1", this.gridDataBoundGrid1, sheetfamilyID);
				engine.RegisterGridAsSheet("GDBG2", this.gridDataBoundGrid2, sheetfamilyID);
				engine.RegisterGridAsSheet("GDBG3", this.gridDataBoundGrid3, sheetfamilyID);
				engine.RegisterGridAsSheet("GDBG4", this.gridDataBoundGrid4, sheetfamilyID);
				engine.RegisterGridAsSheet("GDBG5", this.gridDataBoundGrid5, sheetfamilyID);
			}
		}

		#region Create DataTables

		Random r = new Random();
		int tableCount = 0;
		private DataTable GetARandomTable()
		{
			DataTable dt = new DataTable(string.Format("Table{0}", tableCount));

			int nRows = r.Next(100) + 5;
			int nCols = r.Next(20) + 5;

			for(int i = 0; i < nCols; ++i)
				dt.Columns.Add(new DataColumn(RangeInfo.GetAlphaLabel(i+1)));

			tableCount++;

			for(int i = 0; i < nRows; ++i)
			{
				DataRow dr = dt.NewRow();
				for(int j = 0; j < nCols; ++j)
				{
					if(j == 0)
						dr[j] = i + 1;
					else
						dr[j] = r.Next(1000);
				}
				dt.Rows.Add(dr);
			}
			dt.DefaultView.AllowNew = false;
			return dt;
		}

		#endregion

		#region  CheckBox handler code

		private void checkBox1_CheckedChanged(object sender, System.EventArgs e)
		{
			this.Cursor = Cursors.WaitCursor;
			ShowFormulas(this.checkBox1.Checked, this.gridDataBoundGrid1);
			ShowFormulas(this.checkBox1.Checked, this.gridDataBoundGrid2);
			ShowFormulas(this.checkBox1.Checked, this.gridDataBoundGrid3);
			ShowFormulas(this.checkBox1.Checked, this.gridDataBoundGrid4);
			ShowFormulas(this.checkBox1.Checked, this.gridDataBoundGrid5);
			this.Cursor = Cursors.Default;
		}

		private void ShowFormulas(bool show, CalcGridDataBoundGrid grid)
		{
			DataTable dt = grid.DataSource as DataTable;

			engine.IgnoreValueChanged = true;
				
			if(show)
			{
				for(int row = 0; row < dt.Rows.Count; ++row)
				{
					for(int col = 0; col < dt.Columns.Count; ++col)
					{
						//All calls into CalcEngine are 1-based:
						string s = this.engine.GetFormulaRowCol(grid, row+1, col+1);
						if(s.Length > 0)
						{
							//No calculation as ValueChanged is not raised.
							grid[row + 1, col + 1].Text = s;
						}
					}
				}
			}
			else
			{
				for(int row = 0; row < dt.Rows.Count; ++row)
				{
					for(int col = 0; col < dt.Columns.Count; ++col)
					{
						//All calls into CalcEngine are 1-based:
						string s = this.engine.GetFormulaRowCol(grid, row+1, col+1);
						if(s.Length > 0)
						{
							//Get the value:
							Syncfusion.Calculate.GridSheetFamilyItem family = Syncfusion.Calculate.CalcEngine.GetSheetFamilyItem(grid);
							string cell = (family.ParentObjectToToken == null) ? "" : family.ParentObjectToToken[grid].ToString();
			
							cell += RangeInfo.GetAlphaLabel(col+1) + (row+1).ToString(); 
							s = this.engine.GetValueFromParentObject(cell);
							grid[row + 1, col + 1].Text = s;
							
						}
					}
					this.gridDataBoundGrid1.Binder.EndEdit();
				}
			}
			engine.IgnoreValueChanged = false;
		
		}
		#endregion
	}
}

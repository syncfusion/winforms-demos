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
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Syncfusion.Windows.Forms.Grid;
using Syncfusion.Drawing;
using Syncfusion.Windows.Forms;
using DemoCommon.Grid;

namespace GridStyle
{
    /// <summary>
    /// Summary description for Form1.
    /// </summary>
    public partial class Form1 : GridDemoForm
    {
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
            this.gridControl1.DpiAware = true;
            this.gridControl2.DpiAware = true;
            if (DpiAware.GetCurrentDpi() > 96)
            {
                this.CaptionBarHeight = (int)DpiAware.LogicalToDeviceUnits(this.CaptionBarHeight);
            }
            InitializeGrid();
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
            this.gridControl1.DefaultRowHeight = (int)DpiAware.LogicalToDeviceUnits(22.0f);
            //Used to set selection mode in grid

            this.gridControl1.Model.Options.DisplayEmptyColumns = true;
            this.gridControl1.Model.Options.DisplayEmptyRows = true;
            
            //tab key navigation set as false to move the next control
            this.gridControl1.WantTabKey = false;
            this.gridControl2.WantTabKey = false;
        }

        #endregion

        #region "Grid Initialization"

        private void InitializeGrid()
        {
            #region CellStyleGridControl

            gridControl1.Model.Options.FloatCellsMode = GridFloatCellsMode.OnDemandCalculation;

            GridFontInfo boldFont = new GridFontInfo();
            boldFont.Bold = true;
            boldFont.Size = 11;
            boldFont.Underline = true;

            int rowIndex = 2;
            int colIndex = 1;

            gridControl1.Rows.DefaultSize += 2;
            int boldfontRowHeight = gridControl1.Rows.DefaultSize + 6;

            gridControl1.Model.Options.ControllerOptions = GridControllerOptions.All;
            gridControl1.Model.Options.DataObjectConsumerOptions = GridDataObjectConsumerOptions.All;

            GridStyleInfo standard = gridControl1.BaseStylesMap["Standard"].StyleInfo;
            GridStyleInfo header = gridControl1.BaseStylesMap["Header"].StyleInfo;
            GridStyleInfo rowHeader = gridControl1.BaseStylesMap["Row Header"].StyleInfo;
            GridStyleInfo colHeader = gridControl1.BaseStylesMap["Column Header"].StyleInfo;

            header.Interior = new BrushInfo(SystemColors.Control);
            rowHeader.Interior = new BrushInfo(SystemColors.Control);

            standard.Font.Facename = "Arial"; //"Helvetica";
            header.Enabled = false;

            gridControl1.Model.Options.FloatCellsMode = GridFloatCellsMode.OnDemandCalculation;

            gridControl1.CoveredRanges.Add(GridRangeInfo.Cells(rowIndex, 1, rowIndex, 2));
            gridControl1[rowIndex, 1].Text = "Interior";
            gridControl1[rowIndex, 1].Font = boldFont;

            boldfontRowHeight = gridControl1.RowHeights[rowIndex];
            rowIndex++;

            colIndex = 1;
            foreach (Color color in new Color[] {
													Color.Black,
													Color.Red,
													Color.Blue,
													Color.Green,
													Color.Yellow,
													Color.DimGray})
            {
                gridControl1[rowIndex, colIndex].Interior = new BrushInfo(color);
                colIndex++;
            }
            rowIndex++;
            colIndex = 1;
            foreach (PatternStyle pattern in new PatternStyle[] {
																	PatternStyle.LightVertical,
																	PatternStyle.DarkDownwardDiagonal,
																	PatternStyle.DashedHorizontal,
																	PatternStyle.DottedDiamond,
																	PatternStyle.SmallCheckerBoard,
																	PatternStyle.SmallGrid})
            {
                gridControl1[rowIndex, colIndex].Interior = new BrushInfo(pattern, Color.Black, Color.White);
                colIndex++;
            }
            rowIndex++;
            colIndex = 1;
            foreach (GradientStyle pattern in new GradientStyle[] 
			{
				GradientStyle.BackwardDiagonal,
				GradientStyle.ForwardDiagonal,
				GradientStyle.PathEllipse,
				GradientStyle.PathRectangle,
				GradientStyle.Vertical,
				GradientStyle.Horizontal})
            {
                gridControl1[rowIndex, colIndex].Interior = new BrushInfo(pattern, Color.FromArgb(0xde, 0x64, 0x13), Color.Black); //Color.Yellow, Color.Blue);
                gridControl1[rowIndex, colIndex].CellAppearance = GridCellAppearance.Raised;
                gridControl1[rowIndex + 1, colIndex].Interior = new BrushInfo(pattern, Color.FromArgb(0x82, 0x2e, 0x1b), Color.White); //Color.Red, Color.White);
                gridControl1[rowIndex + 1, colIndex].CellAppearance = GridCellAppearance.Sunken;
                colIndex++;
            }

            rowIndex++;
            rowIndex++;
            rowIndex++;
            colIndex = 1;

            gridControl1.CoveredRanges.Add(GridRangeInfo.Cells(rowIndex, 1, rowIndex, 2));
            gridControl1[rowIndex, 1].Text = "Font";
            gridControl1[rowIndex, 1].Font = boldFont;
            gridControl1.RowHeights[rowIndex] = boldfontRowHeight;
            rowIndex++;

            foreach (int size in new int[]{
											6,
											7,
											8,
											10,
											12,
											14})
            {
                gridControl1[rowIndex, colIndex].Font.Size = size;
                gridControl1[rowIndex, colIndex].Text = size.ToString();
                colIndex++;
            }
            gridControl1.RowHeights.ResizeToFit(GridRangeInfo.Row(rowIndex));

            rowIndex++;
            colIndex = 1;
            foreach (FontStyle fontStyle in new FontStyle[]
			{
				FontStyle.Bold,
				FontStyle.Italic,
				FontStyle.Regular,
				FontStyle.Strikeout,
				FontStyle.Underline,
				FontStyle.Bold|FontStyle.Italic|FontStyle.Regular})
            {
                gridControl1[rowIndex, colIndex].Font.FontStyle = fontStyle;
                gridControl1[rowIndex, colIndex].Text = System.Enum.Format(typeof(FontStyle), fontStyle, "G");
                colIndex++;
            }

            rowIndex++;
            rowIndex++;
            colIndex = 1;

            gridControl1.CoveredRanges.Add(GridRangeInfo.Cells(rowIndex, 1, rowIndex, 2));
            gridControl1[rowIndex, 1].Text = "TextColor";
            gridControl1[rowIndex, 1].Font = boldFont;
            gridControl1.RowHeights[rowIndex] = boldfontRowHeight;
            rowIndex++;

            colIndex = 1;
            foreach (Color color in new Color[] {
													Color.Black,
													Color.Red,
													Color.Blue,
													Color.Green,
													Color.Yellow,
													Color.DimGray})
            {
                gridControl1[rowIndex, colIndex].TextColor = color;
                gridControl1[rowIndex, colIndex].Text = ColorConvert.ColorToString(color, true);
                colIndex++;
            }

            rowIndex++;
            rowIndex++;

            gridControl1.CoveredRanges.Add(GridRangeInfo.Cells(rowIndex, 1, rowIndex, 2));
            gridControl1[rowIndex, 1].Text = "Borders";
            gridControl1[rowIndex, 1].Font = boldFont;
            gridControl1.RowHeights[rowIndex] = boldfontRowHeight;
            rowIndex++;
            colIndex = 1;

            foreach (GridBorder border in new GridBorder[] {
															   new GridBorder(GridBorderStyle.Solid, Color.Black),
															   new GridBorder(GridBorderStyle.Dotted, Color.Red),
															   new GridBorder(GridBorderStyle.DashDot, Color.Black),
															   new GridBorder(GridBorderStyle.DashDotDot, Color.Red),
															   new GridBorder(GridBorderStyle.Dashed, Color.Black, GridBorderWeight.Medium),
															   new GridBorder(GridBorderStyle.Dotted, Color.Red, GridBorderWeight.Medium)})
            {
                gridControl1[rowIndex, colIndex].Borders.Bottom = border;
                gridControl1[rowIndex, colIndex].Borders.Right = border;
                gridControl1[rowIndex, colIndex].Text = border.ToString();
                colIndex++;
            }

            rowIndex++;
            colIndex = 1;
            foreach (GridBorder border in new GridBorder[] {
															   new GridBorder(GridBorderStyle.Dashed, Color.Black, GridBorderWeight.Thick),
															   new GridBorder(GridBorderStyle.Dotted, Color.Red, GridBorderWeight.Thick),
															   new GridBorder(GridBorderStyle.DashDot, Color.Black, GridBorderWeight.Medium),
															   new GridBorder(GridBorderStyle.DashDotDot, Color.Red, GridBorderWeight.Medium),
															   new GridBorder(GridBorderStyle.Solid, Color.Black, GridBorderWeight.Thick),
															   new GridBorder(GridBorderStyle.Solid, Color.Red, GridBorderWeight.Medium)})
            {
                gridControl1[rowIndex, colIndex].Borders.Bottom = border;
                gridControl1[rowIndex, colIndex].Borders.Right = border;
                gridControl1[rowIndex, colIndex].Text = border.ToString();
                colIndex++;
            }

            rowIndex++;
            rowIndex++;
            colIndex = 1;

            gridControl1.CoveredRanges.Add(GridRangeInfo.Cells(rowIndex, 1, rowIndex, 2));
            gridControl1[rowIndex, 1].Text = "Orientation";
            gridControl1[rowIndex, 1].Font = boldFont;
            gridControl1.RowHeights[rowIndex] = boldfontRowHeight;
            rowIndex++;

            foreach (int orientation in new int[]
			{
				0,
				45,
				60,
				90,
				180,
				-90})
            {
                GridStyleInfo style1 = gridControl1[rowIndex, colIndex];
                // style1 is a direct reference to gridControl1[rowIndex, colIndex]; 
                // changes will be propagated back to GridData
                style1.HorizontalAlignment = GridHorizontalAlignment.Center;
                style1.VerticalAlignment = GridVerticalAlignment.Middle;
                GridFontInfo font = style1.Font;
                font.Orientation = orientation;
                font.Bold = true;
                style1.Text = "Angle = " + font.Orientation.ToString();
                colIndex++;
            }

            gridControl1.RowHeights.ResizeToFit(GridRangeInfo.Row(rowIndex));

            rowIndex++;
            rowIndex++;
            colIndex = 1;

            gridControl1.CurrentCell.MoveTo(2, 2);

            this.gridControl1.DefaultRowHeight = (int)DpiAware.LogicalToDeviceUnits(18.0f);
            this.gridControl1.DefaultColWidth = (int)DpiAware.LogicalToDeviceUnits(70.0f);

            this.gridControl1.DefaultGridBorderStyle = GridBorderStyle.Solid;	
            #endregion

            #region StyleObject Grid
            //change the header's BackColor
            gridControl2.BaseStylesMap["Header"].StyleInfo.BackColor = Color.FromArgb(238, 240, 246);
            gridControl2.BaseStylesMap["Row Header"].StyleInfo.BackColor = Color.FromArgb(238, 240, 246);

            //add a new basestyle
            gridBaseStyle1 = new GridBaseStyle("BackColorTest", false);
            gridControl2.BaseStylesMap["BackColorTest"].StyleInfo.BackColor = Color.SkyBlue;


            #endregion

        }

        #endregion

        #region "EventHandlers"

        private void ApplySettings(object sender, EventArgs e)
        {
            ApplyCheck(gridControl2.BaseStylesMap["Standard"].StyleInfo, StandardCheck, StandardColor);
            ApplyCheck(gridControl2.TableStyle, TableCheck, TableColor);
            ApplyCheck(gridControl2.RowStyles[3], Row3Check, Row3Color);
            ApplyCheck(gridControl2.ColStyles[2], Column2Check, Column2Color);
            ApplyCheck(gridControl2[3, 2], Cell32Check, Cell32Color);

            ApplyBaseCheck(gridControl2.BaseStylesMap["BackColorTest"].StyleInfo, BaseStyleCheck, BaseStyleColor);
        }

        private void ApplyCheck(GridStyleInfo style, CheckBox check, ColorPickerButton _color)
        {
            _color.BackColor = _color.SelectedColor;
            if (check.Checked)
            {
                style.BackColor = _color.SelectedColor;
            }
            else
            {
                style.ResetInterior();
            }
        }

        private void ApplyBaseCheck(GridStyleInfo style, CheckBox check, ColorPickerButton _color)
        {
            _color.BackColor = _color.SelectedColor;
            GridStyleInfo style1 = new GridStyleInfo();
            if (check.Checked)
            {
                style.BackColor = _color.SelectedColor;
                style1.BaseStyle = "BackColorTest";
                gridControl2.ChangeCells(GridRangeInfo.Cells(2, 1, 4, 4), style1);

            }
            else
            {
                style1.ResetBaseStyle();
                gridControl2.ChangeCells(GridRangeInfo.Cells(2, 1, 4, 4), style1);

            }
        }
        #endregion

    }
}
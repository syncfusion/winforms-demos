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
using Syncfusion.Windows.Forms;
using Syncfusion.Windows.Forms.Grid;
using Syncfusion.GridHelperClasses;
using DemoCommon.Grid;

namespace EditorCellDemo
{
    public partial class Form1 : GridDemoForm
    {
        #region "Constructor"

        public Form1()
        {
            InitializeComponent();
            if(DpiAware.GetCurrentDpi() > 96)
            {
                this.CaptionBarHeight = (int)DpiAware.LogicalToDeviceUnits(this.CaptionBarHeight);
            }
            InitializeGrid();
            this.gridControl1.ColWidths[0] = (int)DpiAware.LogicalToDeviceUnits(30);
        }

        #endregion

        #region "Grid Intialization"

        private void InitializeGrid()
        {
            #region "Style declaration"

            GridStyleInfo headerstyle = new GridStyleInfo();
            headerstyle.Font.Size = 12;
            headerstyle.Font.Bold = true;
            headerstyle.VerticalAlignment = GridVerticalAlignment.Middle;
            headerstyle.HorizontalAlignment = GridHorizontalAlignment.Center;
            headerstyle.CellType = GridCellTypeName.Static;

            GridStyleInfo subheaderstyle = new GridStyleInfo();
            subheaderstyle.Font.Bold = true;
            subheaderstyle.VerticalAlignment = GridVerticalAlignment.Middle;
            subheaderstyle.HorizontalAlignment = GridHorizontalAlignment.Center;
            subheaderstyle.CellType = GridCellTypeName.Static;

            GridStyleInfo valuestyle = new GridStyleInfo();
            valuestyle.BackColor = SystemColors.Menu;
            valuestyle.TextColor = Color.Black;
            valuestyle.VerticalAlignment = GridVerticalAlignment.Middle;
            valuestyle.HorizontalAlignment = GridHorizontalAlignment.Center;

            gridControl1.TableStyle.FloatCell = true;
            gridControl1.FloatCellsMode = GridFloatCellsMode.BeforeDisplayCalculation;
            gridControl1.DefaultRowHeight = (int)DpiAware.LogicalToDeviceUnits(22.0f);
            #endregion

            gridControl1.BeginUpdate();

            int rowIndex = 1, colIndex = 4;

            #region "IntegerTextBox"
            gridControl1.CoveredRanges.Add(GridRangeInfo.Cells(rowIndex, 1, rowIndex + 1, gridControl1.ColCount));
            gridControl1[rowIndex, 1] = headerstyle;
            gridControl1[rowIndex, 1].Text = "Integer TextBox Cell";

            rowIndex += 3;
            RegisterCellModel.GridCellType(this.gridControl1, CustomCellTypes.IntegerTextBox);
            this.gridControl1[rowIndex, colIndex - 2].Text = ".CellType = CustomCellTypes.IntegerTextBox";
            this.gridControl1[rowIndex, colIndex - 2].HorizontalAlignment = GridHorizontalAlignment.Center;


            this.gridControl1[rowIndex, colIndex + 2] = valuestyle;
            this.gridControl1[rowIndex, colIndex + 2].CellType = CustomCellTypes.IntegerTextBox.ToString();
            this.gridControl1[rowIndex, colIndex + 2].CellValue = 56789;

            this.gridControl1[rowIndex, colIndex + 3] = valuestyle;
            this.gridControl1[rowIndex, colIndex + 3].CellType = CustomCellTypes.IntegerTextBox.ToString();
            this.gridControl1[rowIndex, colIndex + 3].CellValue = 34210;

            rowIndex++;
            this.gridControl1[rowIndex, colIndex + 2] = valuestyle;
            this.gridControl1[rowIndex, colIndex + 2].CellType = CustomCellTypes.IntegerTextBox.ToString();
            this.gridControl1[rowIndex, colIndex + 2].CellValue = 1234;

            this.gridControl1[rowIndex, colIndex + 3] = valuestyle;
            this.gridControl1[rowIndex, colIndex + 3].CellType = CustomCellTypes.IntegerTextBox.ToString();
            this.gridControl1[rowIndex, colIndex + 3].CellValue = 54321;

            #endregion

            #region "DoubleTextBox"
            rowIndex++;
            rowIndex++;
            gridControl1.CoveredRanges.Add(GridRangeInfo.Cells(rowIndex, 1, rowIndex + 1, gridControl1.ColCount));
            gridControl1[rowIndex, 1] = headerstyle;
            gridControl1[rowIndex, 1].Text = "Double TextBox Cell";

            rowIndex += 3;
            RegisterCellModel.GridCellType(this.gridControl1, CustomCellTypes.DoubleTextBox);
            this.gridControl1[rowIndex, colIndex - 2].Text = ".CellType = CustomCellTypes.DoubleTextBox";
            this.gridControl1[rowIndex, colIndex - 2].HorizontalAlignment = GridHorizontalAlignment.Center;


            this.gridControl1[rowIndex, colIndex + 2] = valuestyle;
            this.gridControl1[rowIndex, colIndex + 2].CellType = CustomCellTypes.DoubleTextBox.ToString();
            this.gridControl1[rowIndex, colIndex + 2].CellValue = 123456;

            this.gridControl1[rowIndex, colIndex + 3] = valuestyle;
            this.gridControl1[rowIndex, colIndex + 3].CellType = CustomCellTypes.DoubleTextBox.ToString();
            this.gridControl1[rowIndex, colIndex + 3].CellValue = 876543;

            rowIndex++;
            this.gridControl1[rowIndex, colIndex + 2] = valuestyle;
            this.gridControl1[rowIndex, colIndex + 2].CellType = CustomCellTypes.DoubleTextBox.ToString();
            this.gridControl1[rowIndex, colIndex + 2].CellValue = 13579;

            this.gridControl1[rowIndex, colIndex + 3] = valuestyle;
            this.gridControl1[rowIndex, colIndex + 3].CellType = CustomCellTypes.DoubleTextBox.ToString();
            this.gridControl1[rowIndex, colIndex + 3].CellValue = 975324;

            #endregion

            #region "Percentage TextBox"
            rowIndex++;
            rowIndex++;
            gridControl1.CoveredRanges.Add(GridRangeInfo.Cells(rowIndex, 1, rowIndex + 1, gridControl1.ColCount));
            gridControl1[rowIndex, 1] = headerstyle;
            gridControl1[rowIndex, 1].Text = "Percentage TextBox Cell";

            rowIndex += 3;
            RegisterCellModel.GridCellType(this.gridControl1, CustomCellTypes.PercentTextBox);
            this.gridControl1[rowIndex, colIndex - 2].Text = ".CellType = CustomCellTypes.DoubleTextBox";
            this.gridControl1[rowIndex, colIndex - 2].HorizontalAlignment = GridHorizontalAlignment.Center;


            this.gridControl1[rowIndex, colIndex + 2] = valuestyle;
            this.gridControl1[rowIndex, colIndex + 2].CellType = CustomCellTypes.PercentTextBox.ToString();
            this.gridControl1[rowIndex, colIndex + 2].CellValue = 54;

            this.gridControl1[rowIndex, colIndex + 3] = valuestyle;
            this.gridControl1[rowIndex, colIndex + 3].CellType = CustomCellTypes.PercentTextBox.ToString();
            this.gridControl1[rowIndex, colIndex + 3].CellValue = 65;

            rowIndex++;
            this.gridControl1[rowIndex, colIndex + 2] = valuestyle;
            this.gridControl1[rowIndex, colIndex + 2].CellType = CustomCellTypes.PercentTextBox.ToString();
            this.gridControl1[rowIndex, colIndex + 2].CellValue = 84;

            this.gridControl1[rowIndex, colIndex + 3] = valuestyle;
            this.gridControl1[rowIndex, colIndex + 3].CellType = CustomCellTypes.PercentTextBox.ToString();
            this.gridControl1[rowIndex, colIndex + 3].CellValue = 92;

            #endregion

            #region "EnhancedNumericUpdown"
            rowIndex++;
            rowIndex++;
            gridControl1.CoveredRanges.Add(GridRangeInfo.Cells(rowIndex, 1, rowIndex + 1, gridControl1.ColCount));
            gridControl1[rowIndex, 1] = headerstyle;
            gridControl1[rowIndex, 1].Text = "Enhanced Numeric Up-Down Cell";

            RegisterCellModel.GridCellType(gridControl1, CustomCellTypes.FNumericUpDown);
            rowIndex++;
            rowIndex++;
            gridControl1.CoveredRanges.Add(GridRangeInfo.Cells(rowIndex, 1, rowIndex, gridControl1.ColCount));
            gridControl1[rowIndex, 1] = subheaderstyle;
            gridControl1[rowIndex, 1].Text = "Allow Decimal Increment and Decrement(step by 0.2,0.01,0.001)";

            #region #1
            rowIndex++; rowIndex++;
            gridControl1.Model.RowHeights[rowIndex] = (int)DpiAware.LogicalToDeviceUnits(20.0f);
            GridStyleInfo style = gridControl1[rowIndex, colIndex - 1];
            style.CellType = "FNumericUpDown";
            style.Text = "0.5";
            FloatNumericUpDownStyleProperties sp = new FloatNumericUpDownStyleProperties(style);
            sp.StyleInfo.BackColor = SystemColors.Window;
            sp.FloatNumericUpDownProperties.Maximum = 15.0;
            sp.FloatNumericUpDownProperties.Minimum = 0.0;
            sp.FloatNumericUpDownProperties.StartValue = 0.5;
            sp.FloatNumericUpDownProperties.Step = 0.2;
            sp.FloatNumericUpDownProperties.WrapValue = true;
            sp.FloatNumericUpDownProperties.DecimalPlaces = 1;

            style = gridControl1[rowIndex, colIndex + 1];
            style.CellType = "FNumericUpDown";
            style.Text = "10.10";
            sp = new FloatNumericUpDownStyleProperties(style);
            sp.StyleInfo.BackColor = SystemColors.Window;
            sp.FloatNumericUpDownProperties.Maximum = 12.50;
            sp.FloatNumericUpDownProperties.Minimum = 0.0;
            sp.FloatNumericUpDownProperties.StartValue = 10.10;
            sp.FloatNumericUpDownProperties.Step = 0.01;
            sp.FloatNumericUpDownProperties.WrapValue = true;
            sp.FloatNumericUpDownProperties.DecimalPlaces = 2;


            style = gridControl1[rowIndex, colIndex + 3];
            style.CellType = "FNumericUpDown";
            style.Text = "15.000";
            sp = new FloatNumericUpDownStyleProperties(style);
            sp.StyleInfo.BackColor = SystemColors.Window;
            sp.FloatNumericUpDownProperties.Maximum = 15.225;
            sp.FloatNumericUpDownProperties.Minimum = 0.0;
            sp.FloatNumericUpDownProperties.StartValue = 15.000;
            sp.FloatNumericUpDownProperties.Step = 0.001;
            sp.FloatNumericUpDownProperties.WrapValue = true;
            sp.FloatNumericUpDownProperties.DecimalPlaces = 3;
            sp.FloatNumericUpDownProperties.Orientation = FloatNumericUpDownProperties.OrientationType.Vertical;
            sp.FloatNumericUpDownProperties.InterceptArrowkeys = false;
            sp.FloatNumericUpDownProperties.ThousandsSeparator = false;
            #endregion

            #region #2
            rowIndex++;
            rowIndex++;
            gridControl1.CoveredRanges.Add(GridRangeInfo.Cells(rowIndex, 1, rowIndex, gridControl1.ColCount));
            gridControl1[rowIndex, 1] = subheaderstyle;
            gridControl1[rowIndex, 1].Text = "Option to decrease number beyond Zero(Negative numbers allowed)";

            rowIndex++;
            rowIndex++;
            gridControl1.Model.RowHeights[rowIndex] = (int)DpiAware.LogicalToDeviceUnits(20.0f);
            style = this.gridControl1[rowIndex, colIndex - 1];
            style.CellType = "FNumericUpDown";
            style.Text = "-4";
            sp = new FloatNumericUpDownStyleProperties(style);
            #endregion

            #region #3
            rowIndex++;
            rowIndex++;
            gridControl1.CoveredRanges.Add(GridRangeInfo.Cells(rowIndex, 1, rowIndex, gridControl1.ColCount));
            gridControl1[rowIndex, 1] = subheaderstyle;
            gridControl1[rowIndex, 1].Text = "Use Up/Down arrow keys from Keyboard to increment/decrement the numeric value";

            rowIndex++;
            rowIndex++;
            gridControl1.Model.RowHeights[rowIndex] = (int)DpiAware.LogicalToDeviceUnits(20.0f);
            style = this.gridControl1[rowIndex, colIndex - 1];
            style.CellType = "FNumericUpDown";
            style.Text = "100000";
            sp = new FloatNumericUpDownStyleProperties(style);
            sp.StyleInfo.BackColor = SystemColors.Window;
            sp.FloatNumericUpDownProperties.Maximum = 10000000000;
            sp.FloatNumericUpDownProperties.Minimum = 1;
            sp.FloatNumericUpDownProperties.StartValue = 100000;
            sp.FloatNumericUpDownProperties.Step = 100;
            sp.FloatNumericUpDownProperties.WrapValue = true;
            sp.FloatNumericUpDownProperties.DecimalPlaces = 0;
            sp.FloatNumericUpDownProperties.Orientation = FloatNumericUpDownProperties.OrientationType.Vertical;
            sp.FloatNumericUpDownProperties.InterceptArrowkeys = true;
            sp.FloatNumericUpDownProperties.ThousandsSeparator = false;
            #endregion

            #region #4

            rowIndex++;
            rowIndex++;
            gridControl1.CoveredRanges.Add(GridRangeInfo.Cells(rowIndex, 1, rowIndex, gridControl1.ColCount));
            gridControl1[rowIndex, 1] = subheaderstyle;
            gridControl1[rowIndex, 1].Text = "Setting the Orientation property";

            rowIndex++;
            rowIndex++;
            gridControl1.Model.RowHeights[rowIndex] = (int)DpiAware.LogicalToDeviceUnits(20.0f);
            style = this.gridControl1[rowIndex, colIndex - 1];
            style.CellType = "FNumericUpDown";
            style.Text = "5.5";
            sp = new FloatNumericUpDownStyleProperties(style);
            sp.StyleInfo.BackColor = SystemColors.Window;
            sp.FloatNumericUpDownProperties.Maximum = 15.5;
            sp.FloatNumericUpDownProperties.Minimum = 0.5;
            sp.FloatNumericUpDownProperties.StartValue = .5;
            sp.FloatNumericUpDownProperties.Step = .5;
            sp.FloatNumericUpDownProperties.WrapValue = true;
            sp.FloatNumericUpDownProperties.DecimalPlaces = 1;
            sp.FloatNumericUpDownProperties.Orientation = FloatNumericUpDownProperties.OrientationType.Horizontal;
            sp.FloatNumericUpDownProperties.InterceptArrowkeys = true;
            sp.FloatNumericUpDownProperties.ThousandsSeparator = false;

            style = this.gridControl1[rowIndex, colIndex + 1];
            style.CellType = "FNumericUpDown";
            style.Text = "10.0";
            sp = new FloatNumericUpDownStyleProperties(style);
            sp.StyleInfo.BackColor = SystemColors.Window;
            sp.FloatNumericUpDownProperties.Maximum = 15.5;
            sp.FloatNumericUpDownProperties.Minimum = 0.5;
            sp.FloatNumericUpDownProperties.Step = .5;
            sp.FloatNumericUpDownProperties.DecimalPlaces = 1;
            sp.FloatNumericUpDownProperties.Orientation = FloatNumericUpDownProperties.OrientationType.Vertical;
            #endregion

            #endregion
            this.gridControl1.Model.Options.DisplayEmptyColumns = true;
            gridControl1.EndUpdate(true);
            gridControl1.Refresh();
        }

        #endregion
    }
}
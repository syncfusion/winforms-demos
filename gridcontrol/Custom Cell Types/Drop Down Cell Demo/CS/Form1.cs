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
using Syncfusion.Windows.Forms.Tools;
using Syncfusion.Windows.Forms;
using DemoCommon.Grid;

namespace DropDownCellDemo
{
    public partial class Form1 : GridDemoForm
    {
        #region "Constructor"

        public Form1()
        {
            InitializeComponent();
            if (DpiAware.GetCurrentDpi() > 96)
            {
                this.CaptionBarHeight = (int)DpiAware.LogicalToDeviceUnits(this.CaptionBarHeight);
            }
            InitializeGrid();
        }

        #endregion

        #region Icon Handlers
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

        #region "Intialize the Grid"

        private void InitializeGrid()
        {
            #region "Style declaration"
            //header Style
            this.gridControl1.DefaultRowHeight = (int)DpiAware.LogicalToDeviceUnits(22.0f);
            GridStyleInfo headerstyle = new GridStyleInfo();
            headerstyle.Font.Size = 12;
            headerstyle.Font.Bold = true;
            headerstyle.VerticalAlignment = GridVerticalAlignment.Middle;
            headerstyle.HorizontalAlignment = GridHorizontalAlignment.Center;
            headerstyle.CellType = GridCellTypeName.Static;
            //Subheader Style
            GridStyleInfo subheaderstyle = new GridStyleInfo();
            subheaderstyle.Font.Bold = true;
            subheaderstyle.VerticalAlignment = GridVerticalAlignment.Middle;
            subheaderstyle.HorizontalAlignment = GridHorizontalAlignment.Center;
            subheaderstyle.CellType = GridCellTypeName.Static;
            //Value Style
            GridStyleInfo valuestyle = new GridStyleInfo();
            valuestyle.BackColor = SystemColors.Menu;
            valuestyle.TextColor = Color.Black;
            valuestyle.VerticalAlignment = GridVerticalAlignment.Middle;
            valuestyle.HorizontalAlignment = GridHorizontalAlignment.Center;

            gridControl1.FloatCellsMode = GridFloatCellsMode.BeforeDisplayCalculation;

            #endregion

            #region "Date Time Picker Cells"

            int rowIndex = 1, colIndex = 4;
            gridControl1.AllowProportionalColumnSizing = true;
            gridControl1.CoveredRanges.Add(GridRangeInfo.Cells(rowIndex, 1, rowIndex + 1, gridControl1.ColCount));
            gridControl1[rowIndex, 1] = headerstyle;
            gridControl1[rowIndex, 1].Text = "Date Time Picker Cells";
            rowIndex += 3;
            gridControl1.CoveredRanges.Add(GridRangeInfo.Cells(rowIndex, 3, rowIndex, 5));
            this.gridControl1[rowIndex, colIndex - 1].Text = "Date Picker : (MM/dd/yyyy hh:mm)";
            this.gridControl1[rowIndex, colIndex - 1].TextColor = Color.Black;
            colIndex++; colIndex++;
            gridControl1.CoveredRanges.Add(GridRangeInfo.Cells(rowIndex, colIndex, rowIndex, colIndex + 1));
            this.gridControl1.CellModels.Add("DateTimePicker", new DateTimeCellModel(this.gridControl1.Model));
            this.gridControl1[rowIndex, colIndex].CellType = "DateTimePicker";
            this.gridControl1[rowIndex, colIndex].CellValueType = typeof(DateTime);
            this.gridControl1[rowIndex, colIndex].CellValue = DateTime.Now;
            this.gridControl1[rowIndex, colIndex].Format = "MM/dd/yyyy hh:mm";

            rowIndex++; rowIndex++; colIndex -= 2;
            gridControl1.CoveredRanges.Add(GridRangeInfo.Cells(rowIndex, 3, rowIndex, 5));
            this.gridControl1[rowIndex, colIndex - 1].Text = "Time Picker cell : (hh:mm:ss tt)";
            this.gridControl1[rowIndex, colIndex - 1].TextColor = Color.Black;
            colIndex++; colIndex++;
            gridControl1.CoveredRanges.Add(GridRangeInfo.Cells(rowIndex, colIndex, rowIndex, colIndex + 1));
            this.gridControl1[rowIndex, colIndex].CellType = "DateTimePicker";
            this.gridControl1[rowIndex, colIndex].CellValueType = typeof(DateTime);
            this.gridControl1[rowIndex, colIndex].CellValue = DateTime.Now;
            this.gridControl1[rowIndex, colIndex].Format = "hh:mm:ss tt";
            
            #endregion

            #region "DropDownGrid cells"

            GridControl GridA = new GridControl();
            GridA.RowCount = 10;
            GridA.ColCount = 5;
            GridA.ThemesEnabled = true;
            GridA.CausesValidation = false;
            GridA[1, 1].Text = "Grid A";

            GridA.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Office2007Blue;
            GridA.Properties.BackgroundColor = System.Drawing.Color.FromArgb(((System.Byte)(227)), ((System.Byte)(239)), ((System.Byte)(255)));
            GridA.Properties.GridLineColor = System.Drawing.Color.FromArgb(((System.Byte)(208)), ((System.Byte)(215)), ((System.Byte)(229)));
            GridA.DefaultGridBorderStyle = GridBorderStyle.Solid;
            GridA.ForeColor = System.Drawing.Color.MidnightBlue;
            GridA.Font = new System.Drawing.Font("Verdana", 8.5F);


            GridControl GridB = new GridControl();
            GridB.RowCount = 6;
            GridB.ColCount = 6;
            GridB.CausesValidation = false;
            GridB.ThemesEnabled = true;
            GridB[1, 1].Text = "Grid B";

            GridB.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro;
            DropDownGridCellModel aModel = new DropDownGridCellModel(this.gridControl1.Model);
            aModel.EmbeddedGrid = GridA;
            DropDownGridCellModel bModel = new DropDownGridCellModel(this.gridControl1.Model);
            bModel.EmbeddedGrid = GridB;
            gridControl1.CellModels.Add("GridADropCell", aModel);
            gridControl1.CellModels.Add("GridBDropCell", bModel);

            rowIndex += 3; colIndex -= 3;
            gridControl1.CoveredRanges.Add(GridRangeInfo.Cells(rowIndex, 1, rowIndex + 1, gridControl1.ColCount));
            gridControl1[rowIndex, 1] = headerstyle;
            gridControl1[rowIndex, 1].Text = "DropDown Grid Cells";
            rowIndex += 3;
            gridControl1.CoveredRanges.Add(GridRangeInfo.Cells(rowIndex, colIndex, rowIndex, colIndex + 1));
            this.gridControl1[rowIndex, colIndex].Text = "Grid A";
            this.gridControl1[rowIndex, colIndex].CellType = "GridADropCell";
            gridControl1.CoveredRanges.Add(GridRangeInfo.Cells(rowIndex, colIndex + 3, rowIndex, colIndex + 4));
            this.gridControl1[rowIndex, colIndex + 3].Text = "Grid B";
            this.gridControl1[rowIndex, colIndex + 3].CellType = "GridBDropCell";
            
            #endregion

            #region "DropDown Form and User Control"

            rowIndex += 3; colIndex -= 2;
            gridControl1.CoveredRanges.Add(GridRangeInfo.Cells(rowIndex, 1, rowIndex + 1, gridControl1.ColCount));
            gridControl1[rowIndex, 1] = headerstyle;
            gridControl1[rowIndex, 1].Text = "DropDown Form and User Control";
            rowIndex++; rowIndex++;

            this.gridControl1.CellModels.Add("DropDownForm", new DropDownFormCellModel(this.gridControl1.Model, new DropDownForm()));
            this.gridControl1.CellModels.Add("DropDownUserControl", new DropDownUserCellModel(this.gridControl1.Model, new DropDownUser()));

            ////DropDownForm...
            rowIndex++; colIndex = 3;
            gridControl1.CoveredRanges.Add(GridRangeInfo.Cells(rowIndex, 3, rowIndex , 4));
            gridControl1.CoveredRanges.Add(GridRangeInfo.Cells(rowIndex, 5, rowIndex, 7));
            gridControl1[rowIndex, colIndex].Text = "DropDownForm";
            gridControl1[rowIndex, colIndex].TextColor = Color.Black;
            this.gridControl1[rowIndex, colIndex + 2].CellType = "DropDownForm";
            this.gridControl1[rowIndex, colIndex + 2].Text = "choice1,choice3";

            ////DropDownForm...
            rowIndex++; rowIndex++;
            gridControl1.CoveredRanges.Add(GridRangeInfo.Cells(rowIndex, 3, rowIndex, 4));
            gridControl1.CoveredRanges.Add(GridRangeInfo.Cells(rowIndex, 5, rowIndex, 7));
            gridControl1[rowIndex, colIndex].Text = "DropDownUserControl";
            gridControl1[rowIndex, colIndex].TextColor = Color.Black;
            this.gridControl1[rowIndex, colIndex + 2].CellType = "DropDownUserControl";
            this.gridControl1[rowIndex, colIndex + 2].Text = "choice1,choice3";

            #endregion

            #region "DropDOwnCalculator Cell"

            rowIndex += 3; 
            gridControl1.CoveredRanges.Add(GridRangeInfo.Cells(rowIndex, 1, rowIndex + 1, gridControl1.ColCount));
            gridControl1[rowIndex, 1] = headerstyle;
            gridControl1[rowIndex, 1].Text = "DropDown Calculator TextBox";
            rowIndex++; rowIndex++;

#if HELPERCLASS
            RegisterCellModel.GridCellType(gridControl1, CustomCellTypes.CalculatorTextBox);
#else
            this.gridControl1.CellModels.Add("CalculatorTextBox", new DropDownCalculatorTextBoxCellModel(this.gridControl1.Model));
#endif

            rowIndex++;
            gridControl1.CoveredRanges.Add(GridRangeInfo.Cells(rowIndex, 4, rowIndex, 6));
            CalculatorControl c1 = new CalculatorControl();
            c1.BorderStyle = Border3DStyle.Flat;
            c1.ButtonStyle = Syncfusion.Windows.Forms.ButtonAppearance.Office2007;
            c1.UseVisualStyle = true;

            GridStyleInfo style = gridControl1[rowIndex, 4];
            style.CellType = "CalculatorTextBox";
            style.Control = c1;
            style.Text = "Calculator TextBox";

            this.gridControl1.Model.EnableGridListControlInComboBox = false;
            #endregion
        }

        #endregion
    }
}
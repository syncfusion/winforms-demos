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
using System.Collections.Specialized;
using Syncfusion.Windows.Forms;
using DemoCommon.Grid;

namespace WindowsApplication1
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
            this.gridControl1.ColWidths[3] = (int)DpiAware.LogicalToDeviceUnits(70);
            this.gridControl1.ColWidths[5] = (int)DpiAware.LogicalToDeviceUnits(70);
            this.gridControl1.ColWidths[7] = (int)DpiAware.LogicalToDeviceUnits(70);
            this.gridControl1.RowHeights[10]= (int)DpiAware.LogicalToDeviceUnits(50);

            this.gridControl1.Model.Options.DisplayEmptyColumns = true;
            this.gridControl1.Model.Options.DisplayEmptyRows = true;
        }

        #endregion

        #region "Grid Initialization"
        /// <summary>
        /// initialize the Grid with properties.
        /// </summary>
        private void InitializeGrid()
        {
            this.gridControl1.BeginUpdate();

            #region PushButtons
            gridControl1.CoveredRanges.Add(GridRangeInfo.Cells(1, 1, 2, gridControl1.ColCount));
            gridControl1[1, 1].Text = "Push Buttons";
            gridControl1[1, 1].Font.Size = 14;
            gridControl1[1, 1].Font.Bold = true;
            gridControl1[1, 1].VerticalAlignment = GridVerticalAlignment.Middle;
            gridControl1[1, 1].HorizontalAlignment = GridHorizontalAlignment.Center;
            gridControl1[1, 1].CellType = "Static";
            gridControl1.CoveredRanges.Add(GridRangeInfo.Cells(3, 1, 3, gridControl1.ColCount));
            gridControl1[3, 1].Text = "PushButton Cells - supports Flat, Raised and Sunken styles";
            gridControl1[3, 1].VerticalAlignment = GridVerticalAlignment.Middle;
            gridControl1[3, 1].HorizontalAlignment = GridHorizontalAlignment.Center;
            gridControl1[3, 1].CellType = "Static";

            int rowIndex = 5, colIndex = 3;
            gridControl1[rowIndex, colIndex].Description = "Flat";
            gridControl1[rowIndex, colIndex].CellType = GridCellTypeName.PushButton;
            gridControl1[rowIndex, colIndex].Font.Size = 8;
            gridControl1[rowIndex, colIndex + 2].Description = "Raised";
            gridControl1[rowIndex, colIndex + 2].CellType = GridCellTypeName.PushButton;
            gridControl1[rowIndex, colIndex + 2].Font.Size = 8;
            gridControl1[rowIndex, colIndex + 2].CellAppearance = GridCellAppearance.Raised;
            gridControl1[rowIndex, colIndex + 4].Description = "Sunken";
            gridControl1[rowIndex, colIndex + 4].CellType = GridCellTypeName.PushButton;
            gridControl1[rowIndex, colIndex + 4].Font.Size = 8;
            gridControl1[rowIndex, colIndex + 4].CellAppearance = GridCellAppearance.Sunken;
            #endregion

            #region RadioButtons
            gridControl1.CoveredRanges.Add(GridRangeInfo.Cells(8, 1, 9, gridControl1.ColCount));
            gridControl1[8, 1].Text = "Radio Buttons";
            gridControl1[8, 1].Font.Size = 14;
            gridControl1[8, 1].Font.Bold = true;
            gridControl1[8, 1].VerticalAlignment = GridVerticalAlignment.Middle;
            gridControl1[8, 1].HorizontalAlignment = GridHorizontalAlignment.Center;
            gridControl1[8, 1].CellType = "Static";
            gridControl1.CoveredRanges.Add(GridRangeInfo.Cells(10, 1, 10, gridControl1.ColCount));
            gridControl1[10, 1].Text = "RadioButton cell type enables multiple radio buttons in a cell and their behavior is grouped";
            gridControl1[10, 1].VerticalAlignment = GridVerticalAlignment.Middle;
            gridControl1[10, 1].HorizontalAlignment = GridHorizontalAlignment.Center;
            gridControl1[10, 1].CellType = "Static";
            StringCollection sc = new StringCollection();
            sc.AddRange(new String[]{	"Button 0", 
										"Disabled/disabled", 
										"Button 2", 
										"Button 3"});
            gridControl1.CoveredRanges.Add(GridRangeInfo.Cells(12, 1, 12, gridControl1.ColCount));
            rowIndex = 12;
            this.gridControl1[rowIndex, 1].ChoiceList = sc;
            this.gridControl1[rowIndex, 1].CellType = "RadioButton";
            this.gridControl1[rowIndex, 1].Font.Bold = true;
            this.gridControl1[rowIndex, 1].CellValue = 0;//selected button
            this.gridControl1[rowIndex, 1].TextAlign = GridTextAlign.Left;//where descriptions are
            this.gridControl1[rowIndex, 1].TextMargins.Left = 5;
            this.gridControl1[rowIndex, 1].TextMargins.Right = 5;
            #endregion

            #region CheckBoxes
            gridControl1.CoveredRanges.Add(GridRangeInfo.Cells(15, 1, 16, gridControl1.ColCount));
            gridControl1[15, 1].Text = "CheckBoxes";
            gridControl1[15, 1].Font.Size = 14;
            gridControl1[15, 1].Font.Bold = true;
            gridControl1[15, 1].VerticalAlignment = GridVerticalAlignment.Middle;
            gridControl1[15, 1].HorizontalAlignment = GridHorizontalAlignment.Center;
            gridControl1[15, 1].CellType = "Static";
            gridControl1.CoveredRanges.Add(GridRangeInfo.Cells(17, 1, 17, gridControl1.ColCount));
            gridControl1[17, 1].Text = "Checkbox Cells - supports triState/disabled states";
            gridControl1[17, 1].VerticalAlignment = GridVerticalAlignment.Middle;
            gridControl1[17, 1].HorizontalAlignment = GridHorizontalAlignment.Center;
            gridControl1[17, 1].CellType = "Static";

            rowIndex = 19;
            gridControl1.TableStyle.CheckBoxOptions = new GridCheckBoxCellInfo("True", "False", "", false);
            gridControl1[rowIndex, colIndex].CellValue = false;
            gridControl1[rowIndex, colIndex].Description = "Click Me";
            gridControl1[rowIndex, colIndex].CellType = "CheckBox";
            gridControl1[rowIndex, colIndex].TriState = false;
            gridControl1[rowIndex, colIndex + 2].CellValue = true;
            gridControl1[rowIndex, colIndex + 2].CellType = "CheckBox";
            gridControl1[rowIndex, colIndex + 2].TriState = true;
            gridControl1[rowIndex, colIndex + 2].Description = "TriState";
            gridControl1[rowIndex, colIndex + 2].VerticalAlignment = GridVerticalAlignment.Middle;
            gridControl1[rowIndex, colIndex + 4].Text = "True";
            gridControl1[rowIndex, colIndex + 4].CellType = "CheckBox";
            gridControl1[rowIndex, colIndex + 4].TriState = false;
            gridControl1[rowIndex, colIndex + 4].Description = "Disabled";
            gridControl1[rowIndex, colIndex + 4].Enabled = false;
            gridControl1[rowIndex, colIndex + 4].VerticalAlignment = GridVerticalAlignment.Bottom;
            #endregion

            this.gridControl1.EndUpdate();
            this.gridControl1.Refresh();
            //this.gridControl1.ColWidths.ResizeToFit(GridRangeInfo.Cols(1, 9), GridResizeToFitOptions.IncludeCellsWithinCoveredRange);
        }

        
        #endregion

        #region "EventHandlers"
        private void checkBoxAdv1_CheckStateChanged(object sender, EventArgs e)
        {
            if (this.gridControl1.GridVisualStyles == GridVisualStyles.Metro)
            {
                this.gridControl1.GridVisualStyles = GridVisualStyles.Office2007Blue;
                this.gridControl1.Office2007ScrollBarsColorScheme = Office2007ColorScheme.Blue;
                this.gridControl1.DefaultRowHeight = (int)DpiAware.LogicalToDeviceUnits(22.0f);
            }
            else
            {
                this.gridControl1.GridVisualStyles = GridVisualStyles.Metro;
                this.gridControl1.DefaultRowHeight = (int)DpiAware.LogicalToDeviceUnits(22.0f);
            }
                
            this.gridControl1.Refresh();
        }
        #endregion
    }
}
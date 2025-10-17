#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using System.Text;
using Syncfusion.Windows.Forms.Grid;
using Syncfusion.Windows.Forms;
using Syncfusion.GridConverter;
using Syncfusion.XlsIO;
using System.Drawing;
using System.ComponentModel;
using Syncfusion.GridHelperClasses;
using Syncfusion.GridExcelConverter;

namespace Virtual_Import
{
    /// <summary>
    /// This helper class provides the support to import the Excel sheets styles to grid.
    /// </summary>
    public class ImportingHelper
    {

        #region Private Variables
        public GridModel[] gridModelCollection;
        TabBarSplitterControl tabBarSplitterControl;
        IWorkbook workbook;
        public GridExcelConverterControl excelConverter;        
        #endregion

        #region Constructor
        public ImportingHelper()
        {
            excelConverter = new GridExcelConverterControl();            
        }        
        #endregion

        #region QueryCellInfo
        public void Model_QueryCellInfo(object sender, Syncfusion.Windows.Forms.Grid.GridQueryCellInfoEventArgs e)
        {
            if (e.RowIndex <= 0 || e.ColIndex <= 0)
            {
                if (e.ColIndex == 0)
                    e.Style.HorizontalAlignment = GridHorizontalAlignment.Center;
                return;
            }

            GridModel gridModel = sender as GridModel;
            int index = this.tabBarSplitterControl.ActivePageIndex;
            IWorksheet sheet = workbook.Worksheets[index];

            if (!e.Style.IsChanged && e.Style.IsEmpty)
            {
                if (sheet != null)
                {
                    IRange range = sheet.Range;
                    if (e.RowIndex >= range.Row && e.ColIndex >= range.Column)
                    {
                        IRange rangeToConvert = sheet.Range[e.RowIndex, e.ColIndex];
                        //Used to set the styles of the Excel cell to grid. 
                        excelConverter.ConvertExcelStyleToVirtualGridStyle(e.Style, sheet, rangeToConvert);
                    }
                }
            }
        }
        #endregion

        #region Loading worksheets
        /// <summary>
        /// Used to load the all worksheets and assign those sheets in grid models.
        /// </summary>
        /// <param name="Workbook">Exel work book that needs to be imported.</param>
        public void LoadWorkbook(TabBarSplitterControl formTabBarSplitterControl, IWorkbook Workbook)
        {
            tabBarSplitterControl = formTabBarSplitterControl;
            formTabBarSplitterControl.TabBarPages.Clear();            
            workbook = Workbook;
            GridExcelConverterControl extensions = new GridExcelConverterControl();
            gridModelCollection = extensions.ExcelToVirtualGrid(Workbook);

            for (int i = 0; i < Workbook.Worksheets.Count; i++)
            {
                GridControl grid = new GridControl();
                
                //Used to calculate the formula values.
                Workbook.Worksheets[i].EnableSheetCalculations();

                #region Adding Tab pages
                TabBarPage tab = new TabBarPage();
                tab.Text = Workbook.Worksheets[i].Name;
                tab.Controls.Add(grid);                
                if (Workbook.Worksheets[i].Visibility != WorksheetVisibility.Visible)
                {
                    tab.Visible = false;
                }
                #endregion

                #region GridModel settings
                grid.Model = gridModelCollection[i];
                #endregion               
                
                #region Grid customization
                grid.ThemesEnabled = true;
                grid.DpiAware = true;
                GridMetroColors colors = new GridMetroColors();
                colors.HeaderBottomBorderColor = Color.FromArgb(208, 208, 208);
                colors.HeaderBottomBorderWeight = GridBottomBorderWeight.Thin;
                grid.SetMetroStyle(colors);
                grid.FloatCellsMode = GridFloatCellsMode.OnDemandCalculation;
                grid.ExcelLikeAlignment = true;
                grid.Model.Options.ExcelLikeCurrentCell = true;
                grid.Model.Options.ExcelLikeSelectionFrame = true;
                grid.Model.Options.EnterKeyBehavior = GridDirectionType.Down;
                grid.ActivateCurrentCellBehavior = GridCellActivateAction.DblClickOnCell;                             
                grid.Model.Options.WrapCell = false;
                grid.Model.CommandStack.Enabled = true;
                grid.Properties.ForceImmediateRepaint = true;
                grid.Model.ColWidths[0] = (int)DpiAware.LogicalToDeviceUnits(35.0f);
                grid.SmoothMouseWheelScrolling = true;
                RegisterCellModel.GridCellType(grid, CustomCellTypes.LinkLabelCell);                
                #endregion

                formTabBarSplitterControl.TabBarPages.Add(tab);
            }           

            formTabBarSplitterControl.ActivePageIndex = 0;

            foreach (GridModel gridModel in gridModelCollection)
            {
                gridModel.QueryCellInfo += new GridQueryCellInfoEventHandler(Model_QueryCellInfo);
                gridModel.SaveCellInfo += new GridSaveCellInfoEventHandler(gridModel_SaveCellInfo);                
            }
        }          
       #endregion

        #region Commit changes to Excel
        /// <summary>
        /// This event is used to save the changes made in grid to Excel sheet.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void gridModel_SaveCellInfo(object sender, GridSaveCellInfoEventArgs e)
        {
            int index = this.tabBarSplitterControl.ActivePageIndex;
            IWorksheet Worksheet = workbook.Worksheets[index];
            //Used to save the changes made in grid to Excel sheet which is currently in view. 
            excelConverter.SaveCellInfoToExcelsheet(Worksheet, sender as GridModel, e.Style);
        }
        #endregion

        #region UnHookingEvents
        /// <summary>
        /// Used to unhook the QueryCellInfo event for all grids imported in TabBarSplitterControl.
        /// </summary>
        public void UnHookingEvents()
        {
            foreach (GridModel gridModel in gridModelCollection)
            {
                gridModel.QueryCellInfo -= new GridQueryCellInfoEventHandler(Model_QueryCellInfo);
                gridModel.SaveCellInfo -= new GridSaveCellInfoEventHandler(gridModel_SaveCellInfo);
            } 
        }
        #endregion               

    }    
}

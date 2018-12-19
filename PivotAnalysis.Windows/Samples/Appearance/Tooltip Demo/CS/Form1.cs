#region Copyright Syncfusion Inc. 2001 - 2018
// Copyright Syncfusion Inc. 2001 - 2018. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion

using System;
using Syncfusion.PivotAnalysis.Base;
using Syncfusion.Windows.Forms;
using Syncfusion.Windows.Forms.Grid;

namespace ToolTipDemo
{
    public partial class Form1 : MetroForm
    {
        #region Fields

        bool allowTooltip;

        #endregion

        #region Constructor

        public Form1()
        {
            InitializeComponent();
            InitializePivotGrid();
        }

        #endregion

        #region Pivot Grid Settings

        /// <summary>
        /// The Grid settings can be customized
        /// </summary>
        private void InitializePivotGrid()
        {
            // Adding ItemSource to the Control
            pivotGridControl1.ItemSource = ProductSalesData.GetSalesData();

            // Adding PivotRows to the Control
            pivotGridControl1.PivotRows.Add(new PivotItem { FieldMappingName = "Product", TotalHeader = "Total" });

            pivotGridControl1.PivotRows.Add(new PivotItem { FieldMappingName = "Date", TotalHeader = "Total" });

            // Adding PivotColumns to the Control
            pivotGridControl1.PivotColumns.Add(new PivotItem { FieldMappingName = "Country", TotalHeader = "Total" });

            // Adding PivotCalculations to the Control
            pivotGridControl1.PivotCalculations.Add(new PivotComputationInfo { FieldName = "Amount", Format = "$ #,##0.00", SummaryType = SummaryType.DoubleTotalSum });

            pivotGridControl1.PivotCalculations.Add(new PivotComputationInfo { FieldName = "Quantity", Format = "#,##0" });

            pivotGridControl1.TableModel.QueryCellInfo += TableModel_QueryCellInfo;
            chkEnable.Checked = true;

            //tab key navigation set as false to move the next control
            pivotGridControl1.TableControl.WantTabKey = false;
        }

        #endregion

        #region Event Handlers

        //The cell style settings can be customized
        void TableModel_QueryCellInfo(object sender, GridQueryCellInfoEventArgs e)
        {
            if (allowTooltip && e.RowIndex > 0 && e.ColIndex > 0 && e.RowIndex <= pivotGridControl1.PivotEngine.RowCount)
            {
                string tooltip = string.Empty;
                PivotCellInfo cellinfo = pivotGridControl1.PivotEngine[e.RowIndex - 1, e.ColIndex - 1];
                if ((!chkColHeader.Checked && (cellinfo.CellType == (PivotCellType.ColumnHeaderCell | PivotCellType.ExpanderCell)
                    || cellinfo.CellType == (PivotCellType.ColumnHeaderCell | PivotCellType.HeaderCell)
                    || cellinfo.CellType == (PivotCellType.ColumnHeaderCell | PivotCellType.CalculationHeaderCell)))
                    || (!chkRowHeader.Checked && (cellinfo.CellType == (PivotCellType.RowHeaderCell | PivotCellType.ExpanderCell)
                    || cellinfo.CellType == (PivotCellType.RowHeaderCell | PivotCellType.HeaderCell)))
                    || (!chkSummary.Checked && (cellinfo.CellType == (PivotCellType.GrandTotalCell | PivotCellType.ValueCell)
                    || cellinfo.CellType == (PivotCellType.GrandTotalCell | PivotCellType.ValueCell | PivotCellType.TotalCell)
                    || cellinfo.CellType == (PivotCellType.TotalCell | PivotCellType.ValueCell)))
                    || (!chkValue.Checked && cellinfo.CellType == PivotCellType.ValueCell)
                    || (!chkSumHeader.Checked && (cellinfo.CellType == (PivotCellType.GrandTotalCell | PivotCellType.RowHeaderCell)
                    || cellinfo.CellType == (PivotCellType.GrandTotalCell | PivotCellType.ColumnHeaderCell)
                    || cellinfo.CellType == (PivotCellType.GrandTotalCell | PivotCellType.ColumnHeaderCell | PivotCellType.HeaderCell)
                    || cellinfo.CellType == (PivotCellType.GrandTotalCell | PivotCellType.RowHeaderCell | PivotCellType.HeaderCell)
                    || cellinfo.CellType == (PivotCellType.TotalCell | PivotCellType.RowHeaderCell)
                    || cellinfo.CellType == (PivotCellType.TotalCell | PivotCellType.ColumnHeaderCell))))
                {
                    tooltip = string.Empty;
                    return;
                }
                tooltip = "Value\t: " + (string.IsNullOrEmpty(e.Style.Text) ? "(No Value)" : e.Style.Text.ToString());

                PivotCellInfo colParent = pivotGridControl1.PivotEngine[0, e.ColIndex - 1].ParentCell;
                PivotCellInfo rowParent = pivotGridControl1.PivotEngine[e.RowIndex - 1, 0].ParentCell;
                if (colParent != null)
                {
                    tooltip += "\nColumn\t: " + colParent.Value;
                }
                else
                {
                    if (pivotGridControl1.PivotEngine[0, e.ColIndex - 1].Value != null && pivotGridControl1.PivotEngine[0, e.ColIndex - 1].Value.ToString() != null)
                        tooltip += "\nColumn\t: " + pivotGridControl1.PivotEngine[0, e.ColIndex - 1].Value;
                    else if (pivotGridControl1.PivotEngine[0, e.ColIndex - 1].Value == null && e.ColIndex > 1)
                        tooltip += "\nColumn\t: " + pivotGridControl1.PivotEngine[0, e.ColIndex - 2].Value;
                }
                object subRow = pivotGridControl1.PivotEngine[e.RowIndex - 1, 1].Value;
                if (rowParent != null)
                {
                    tooltip += "\nRow\t: " + rowParent.Value + " - " + subRow;
                }
                else
                    tooltip += "\nRow\t: " + (pivotGridControl1.PivotEngine[e.RowIndex - 1, 0].Value != null ? pivotGridControl1.PivotEngine[e.RowIndex - 1, 0].Value : pivotGridControl1.PivotEngine[e.RowIndex - 1, 0].UniqueText) + " - " + subRow;
                if (e.Style.Tag != null)
                {
                    string valueHeader = cellinfo.CellType.ToString().Contains("ColumnHeaderCell") ? "Column : " : (cellinfo.CellType.ToString().Contains("RowHeaderCell") ? "Row : " : "Value : ");
                    tooltip = valueHeader + e.Style.Text;
                }                
                e.Style.CellTipText = tooltip;
            }
        }

        private void chkEnable_CheckStateChanged(object sender, EventArgs e)
        {
            allowTooltip = chkEnable.Checked;
            chkColHeader.Checked = chkRowHeader.Checked = chkSumHeader.Checked = chkValue.Checked = chkSummary.Checked = allowTooltip;
            chkColHeader.Enabled = chkRowHeader.Enabled = chkSumHeader.Enabled = chkValue.Enabled = chkSummary.Enabled = allowTooltip;
            pivotGridControl1.Refresh();
            pivotGridControl1.TableControl.RefreshRange(GridRangeInfo.Table());
        }

        #endregion
    }
}
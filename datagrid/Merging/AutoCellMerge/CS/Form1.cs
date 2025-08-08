#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Syncfusion.Data;
using Syncfusion.WinForms.DataGrid;
using Syncfusion.WinForms.DataGrid.Enums;
using Syncfusion.WinForms.DataGrid.Events;

namespace AutoCellMerging
{
    public partial class Form1 : Form
    {
        #region Fields

        /// <summary>
        /// Holds the PropertyAccessProvider to git the cell value.
        /// </summary>
        IPropertyAccessProvider propertyAccessProvider = null;

        #endregion

        #region Constructor
        /// <summary>
        /// Initializes the new instance of the Form1 class.
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            this.sfDataGrid1.ShowGroupDropArea = true;
            this.sfDataGrid1.DataSource = new OrderInfoCollection().OrdersListDetails;
            propertyAccessProvider = sfDataGrid1.View.GetPropertyAccessProvider();
            this.sfDataGrid1.SelectionMode = GridSelectionMode.None;
            this.sfDataGrid1.QueryCoveredRange += sfDataGrid1_QueryCoveredRange;
        }

        #endregion

        #region Sample Customization

        /// <summary>
        /// Occurs while calculating the merged cells.
        /// </summary>
        /// <param name="sender">The object of the sender.</param>
        /// <param name="e">An <see cref="QueryCoveredCellsEventArgs"/> that contains event data.</param>
        void sfDataGrid1_QueryCoveredRange(object sender, QueryCoveredRangeEventArgs e)
        {
            var range = GetRange(e.GridColumn, e.RowIndex, e.ColumnIndex, e.Record);

            if (range == null)
                return;

            e.Range = range;
            e.Handled = true;
        }

        /// <summary>
        /// Gets the covered cells range for the given row and column index.
        /// </summary>
        /// <param name="column">The GridColumn.</param>
        /// <param name="rowIndex">Row index of the cell.</param>
        /// <param name="columnIndex">Column index of the cell.</param>
        /// <param name="rowData">The row data of the record.</param>
        /// <returns>Returns the range of the covered cells.</returns>
        private CoveredCellInfo GetRange(GridColumn column, int rowIndex, int columnIndex, object rowData)
        {
            var range = new CoveredCellInfo(columnIndex, columnIndex, rowIndex, rowIndex);
            object data = propertyAccessProvider.GetFormattedValue(rowData, column.MappingName);

            GridColumn leftColumn = null;
            GridColumn rightColumn = null;

            // total rows count.
            int recordsCount = this.sfDataGrid1.GroupColumnDescriptions.Count != 0 ? (this.sfDataGrid1.View.TopLevelGroup.DisplayElements.Count + this.sfDataGrid1.TableSummaryRows.Count + this.sfDataGrid1.UnboundRows.Count + (this.sfDataGrid1.AddNewRowPosition == RowPosition.Top ? +1 : 0)) : (this.sfDataGrid1.View.Records.Count + this.sfDataGrid1.TableSummaryRows.Count + this.sfDataGrid1.UnboundRows.Count + (this.sfDataGrid1.AddNewRowPosition == RowPosition.Top ? +1 : 0));
            recordsCount += this.sfDataGrid1.TableControl.GetHeaderIndex();

            // Merge Horizontally
            // compare right column               
            for (int i = sfDataGrid1.Columns.IndexOf(column); i < this.sfDataGrid1.Columns.Count - 1; i++)
            {
                var compareData = propertyAccessProvider.GetFormattedValue(rowData, sfDataGrid1.Columns[i + 1].MappingName);

                if (compareData == null)
                    break;

                if (!compareData.Equals(data))
                    break;
                rightColumn = sfDataGrid1.Columns[i + 1];
            }

            // compare left column.
            for (int i = sfDataGrid1.Columns.IndexOf(column); i > 0; i--)
            {
                var compareData = propertyAccessProvider.GetFormattedValue(rowData, sfDataGrid1.Columns[i - 1].MappingName);

                if (compareData == null)
                    break;

                if (!compareData.Equals(data))
                    break;
                leftColumn = sfDataGrid1.Columns[i - 1];
            }

            if (leftColumn != null || rightColumn != null)
            {
                // set left index
                if (leftColumn != null)
                {
                    var leftColumnIndex = this.sfDataGrid1.TableControl.ResolveToScrollColumnIndex(this.sfDataGrid1.Columns.IndexOf(leftColumn));
                    range = new CoveredCellInfo(leftColumnIndex, range.Right, range.Top, range.Bottom);
                }

                // set right index
                if (rightColumn != null)
                {
                    var rightColumIndex = this.sfDataGrid1.TableControl.ResolveToScrollColumnIndex(this.sfDataGrid1.Columns.IndexOf(rightColumn));
                    range = new CoveredCellInfo(range.Left, rightColumIndex, range.Top, range.Bottom);
                }
                return range;
            }

            // Merge Vertically from the row index.
            int previousRowIndex = -1;
            int nextRowIndex = -1;

            // Get previous row data.                
            var startIndex = sfDataGrid1.TableControl.ResolveStartIndexBasedOnPosition();
            for (int i = rowIndex - 1; i >= startIndex; i--)
            {
                var previousData = this.sfDataGrid1.GetRecordEntryAtRowIndex(i);
                if (previousData == null || !previousData.IsRecords)
                    break;

                var compareData = propertyAccessProvider.GetFormattedValue((previousData as RecordEntry).Data, column.MappingName);

                if (compareData == null)
                    break;

                if (!compareData.Equals(data))
                    break;
                previousRowIndex = i;
            }

            // get next row data.
            for (int i = rowIndex + 1; i < recordsCount + 1; i++)
            {
                var nextData = this.sfDataGrid1.GetRecordEntryAtRowIndex(i);
                if (nextData == null || !nextData.IsRecords)
                    break;

                var compareData = propertyAccessProvider.GetFormattedValue((nextData as RecordEntry).Data, column.MappingName);

                if (compareData == null)
                    break;

                if (!compareData.Equals(data))
                    break;
                nextRowIndex = i;
            }

            if (previousRowIndex != -1 || nextRowIndex != -1)
            {
                if (previousRowIndex != -1)
                    range = new CoveredCellInfo(range.Left, range.Right, previousRowIndex, range.Bottom);

                if (nextRowIndex != -1)
                    range = new CoveredCellInfo(range.Left, range.Right, range.Top, nextRowIndex);
                return range;
            }

            return null;
        }

        #endregion
    }
}

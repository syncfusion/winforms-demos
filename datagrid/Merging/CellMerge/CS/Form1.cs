#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Syncfusion.Data;
using Syncfusion.WinForms.DataGrid;
using Syncfusion.WinForms.DataGrid.Enums;
using Syncfusion.WinForms.DataGrid.Events;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CellMerging
{
    public partial class Form1 : Form
    {
        #region Field

        /// <summary>
        /// Holds the PropertyAccessProvider to git the cell value.
        /// </summary>
        IPropertyAccessProvider propertyAccessProvider = null;
        #endregion

        #region Constructor
        /// <summary>
        /// Initializes the new instance of the SfDataGrid.
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            sfDataGrid1.SelectionMode = GridSelectionMode.None;
            sfDataGrid1.DataSource = new OrderInfoCollection().OrdersListDetails;
            propertyAccessProvider = sfDataGrid1.View.GetPropertyAccessProvider();
            sfDataGrid1.AllowResizingColumns = true;
            sfDataGrid1.AutoExpandGroups = true;
            sfDataGrid1.GroupColumnDescriptions.Add(new GroupColumnDescription() { ColumnName = "CustomerID" });
            sfDataGrid1.AutoSizeColumnsMode = AutoSizeColumnsMode.Fill;
            sfDataGrid1.QueryCoveredRange += sfDataGrid1_QueryCoveredRange;
            sfDataGrid1.DrawCell += sfDataGrid1_DrawCell;
            sfDataGrid1.TableControl.Scroll += TableControl_Scroll;
        }
        #endregion

        #region SampleCustomization

        /// <summary>
        /// Occurs while drawing the cell in SfDataGrid.
        /// </summary>
        /// <param name="sender">The object of the sender.</param>
        /// <param name="e">An <see cref="DrawCellEventArgs"/> that contains event data.</param>
        void sfDataGrid1_DrawCell(object sender, Syncfusion.WinForms.DataGrid.Events.DrawCellEventArgs e)
        {
            if (e.DataRow.RowType == RowType.DefaultRow && e.Column.MappingName == "CustomerID")
            {
                //Draws the image for the cell based on the cell value.
                var bounds = this.sfDataGrid1.TableControl.GetCellRectangle(e.RowIndex, e.ColumnIndex, true);
#if NETCORE
                e.Graphics.DrawImage(Image.FromFile("../../../Images/" + e.DisplayText + ".png"), bounds);
#else
                e.Graphics.DrawImage(Image.FromFile(@"..\..\Images\" + e.DisplayText + ".png"), bounds);
#endif

                //Draws the border for the cell.
                Pen borderPen = new Pen(Brushes.LightGray);
                e.Graphics.DrawLine(borderPen, bounds.Right, bounds.Top, bounds.Right, bounds.Bottom);
                e.Graphics.DrawLine(borderPen, bounds.Left, bounds.Bottom, bounds.Right, bounds.Bottom);
                e.Handled = true;
            }
        }

        /// <summary>
        /// Occurs while calculating the merged cells.
        /// </summary>
        /// <param name="sender">The object of the sender.</param>
        /// <param name="e">An <see cref="QueryCoveredRangeEventArgs"/> that contains event data.</param>
        void sfDataGrid1_QueryCoveredRange(object sender, QueryCoveredRangeEventArgs e)
        {
            if (!e.GridColumn.MappingName.Equals("CustomerID"))
                return;

            //Get the range for merging the cells.
            var range = GetRange(sfDataGrid1.Columns["CustomerID"], e.RowIndex, e.ColumnIndex, e.Record);
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

        /// <summary>
        /// Occurs while scrolling the table control.
        /// </summary>
        /// <param name="sender">The object of the sender.</param>
        /// <param name="e">An <see cref="ScrollEventArgs"/> that contains event data.</param>
        void TableControl_Scroll(object sender, ScrollEventArgs e)
        {
            if (e.Type == ScrollEventType.ThumbTrack)
                sfDataGrid1.TableControl.Invalidate();
        }

        #endregion
    }
}

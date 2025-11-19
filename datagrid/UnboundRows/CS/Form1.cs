#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System.Windows.Forms;
using Syncfusion.WinForms.DataGrid.Styles;
using Syncfusion.WinForms.DataGrid;
using System.Drawing;
using System.Collections.Generic;
using Syncfusion.Data;
using System;
using Syncfusion.WinForms.DataGrid.Enums;
using Syncfusion.WinForms.DataGrid.Events;
using Syncfusion.Windows.Forms;

namespace UnboundRows
{
    /// <summary>
    /// Summary description for Form1.
    /// </summary>
    public partial class Form1 : Form
    {
        #region Fields

        // totalSales used to store sumamry of each column.
        Dictionary<string, double> totalSales;

        // totalSelectedSales used to store selected rows.
        Dictionary<string, double> totalSelectedSales;

        // percentSales used to store percentage of selected Rows summary.
        Dictionary<string, double> percentSales;

        ProductSalesCollection data = new ProductSalesCollection();

        #endregion

        #region Constructor
        public Form1()
        {
            InitializeComponent();
            sfDataGrid.EnableDataVirtualization = true;
            sfDataGrid.AutoSizeColumnsMode = AutoSizeColumnsMode.Fill;
            sfDataGrid.DataSource = data.SalesInfo;
            sfDataGrid.AllowEditing = true;

            totalSales = new Dictionary<string, double>();
            totalSelectedSales = new Dictionary<string, double>();
            percentSales = new Dictionary<string, double>();

            this.sfDataGrid.QueryRowHeight += SfDataGrid_QueryRowHeight;
            this.sfDataGrid.QueryUnboundRowInfo += SfDataGrid_QueryUnboundRow;
            this.sfDataGrid.SelectionChanged += SfDataGrid_SelectionChanged;
            this.sfDataGrid.CurrentCellEndEdit += sfDataGrid_CurrentCellEndEdit;
            this.sfDataGrid.SelectedItems.CollectionChanged += SelectedItems_CollectionChanged;
            GridSettings();
        }
        #endregion

        #region GridSettings
        /// <summary>
        /// Grid Settings for better Look and Feel.
        /// </summary>
        private void GridSettings()
        {
            sfDataGrid.UnboundRows.Add(new GridUnboundRow() { Position = VerticalPosition.Top, ShowBelowSummary = false });
            sfDataGrid.UnboundRows.Add(new GridUnboundRow());
            sfDataGrid.UnboundRows.Add(new GridUnboundRow());
            sfDataGrid.UnboundRows.Add(new GridUnboundRow());
            sfDataGrid.UnboundRows.Add(new GridUnboundRow());

            // Updates the totals with edited values.
            foreach (GridColumn column1 in this.sfDataGrid.Columns)
                totalSales[column1.MappingName] = GetSummaryValue(column1.MappingName);

            // populate the percentSales by default value fro january column alone.
            foreach (GridColumn column1 in this.sfDataGrid.Columns)
                percentSales[column1.MappingName] = !column1.MappingName.Equals("ProductName") ? 2.25 : 0;

            this.sfDataGrid.SelectedItems.Add(data.SalesInfo[3]);
            this.sfDataGrid.SelectedItems.Add(data.SalesInfo[4]);
            this.sfDataGrid.SelectedItems.Add(data.SalesInfo[5]);
        }

        /// <summary>
        /// Occurs when selected items changed in the SfDataGrid.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="System.Collections.Specialized.NotifyCollectionChangedEventArgs"/> contains the event data.</param>
        void SelectedItems_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            foreach (GridColumn column in this.sfDataGrid.Columns)
                totalSelectedSales[column.MappingName] = GetSummaryValue(column.MappingName, false);

            // Refresh the Unbound rows.
            this.sfDataGrid.InValidateUnboundRow(this.sfDataGrid.UnboundRows[2]);
            this.sfDataGrid.InValidateUnboundRow(this.sfDataGrid.UnboundRows[3]);
            this.sfDataGrid.InValidateUnboundRow(this.sfDataGrid.UnboundRows[4]);
            this.sfDataGrid.TableControl.Invalidate();
        }

        /// <summary>
        /// Occurs when selection changed in SfDataGrid.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">A <see cref="GridSelectionChangedEventArgs"/> contains event data.</param>
        void SfDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // Populate selected rows summary values.
            foreach (GridColumn column in this.sfDataGrid.Columns)
                totalSelectedSales[column.MappingName] = GetSummaryValue(column.MappingName, false);

            // Refresh the Unbound rows.
            this.sfDataGrid.InValidateUnboundRow(this.sfDataGrid.UnboundRows[0]);
            this.sfDataGrid.InValidateUnboundRow(this.sfDataGrid.UnboundRows[2]);
            this.sfDataGrid.InValidateUnboundRow(this.sfDataGrid.UnboundRows[3]);
            this.sfDataGrid.InValidateUnboundRow(this.sfDataGrid.UnboundRows[4]);
            this.sfDataGrid.TableControl.Invalidate();
        }

        /// <summary>
        /// Occurs when current cell end edit called in SfDataGrid.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">Th <see cref="GridCurrentCellEndEditEventArgs"/> contains event data.</param>
        void sfDataGrid_CurrentCellEndEdit(object sender, CurrentCellEndEditEventArgs e)
        {
            // Updates the totals with edited values.
            foreach (GridColumn column in this.sfDataGrid.Columns)
                totalSales[column.MappingName] = GetSummaryValue(column.MappingName);

            foreach (GridColumn column in this.sfDataGrid.Columns)
                totalSelectedSales[column.MappingName] = GetSummaryValue(column.MappingName, false);

            // Refresh the Unbound rows.
            this.sfDataGrid.InValidateUnboundRow(this.sfDataGrid.UnboundRows[2]);
            this.sfDataGrid.InValidateUnboundRow(this.sfDataGrid.UnboundRows[3]);
            this.sfDataGrid.InValidateUnboundRow(this.sfDataGrid.UnboundRows[4]);

            // Refresh unboudnRow after complete editing.
            this.sfDataGrid.TableControl.Invalidate();
        }

        /// <summary>
        /// Calculates summary value based on column names.
        /// </summary>
        /// <param name="column">The column name.</param>
        /// <param name="totalSummary">The boolean value.</param>
        /// <returns>Returns the calculated summary value.</returns>
        private double GetSummaryValue(string column, bool totalSummary = true)
        {
            double summary = 0.0;
            var view = this.sfDataGrid.View;
            if (this.sfDataGrid.SelectedItems.Count != 0 && !totalSummary)
            {
                foreach (var data in this.sfDataGrid.SelectedItems)
                {
                    if (column.Equals("January"))
                        summary += (data as ProductSalesDetails).January;
                    else if (column.Equals("February"))
                        summary += (data as ProductSalesDetails).February;
                    else if (column.Equals("March"))
                        summary += (data as ProductSalesDetails).March;
                    else if (column.Equals("April"))
                        summary += (data as ProductSalesDetails).April;
                    else if (column.Equals("May"))
                        summary += (data as ProductSalesDetails).May;
                    else if (column.Equals("June"))
                        summary += (data as ProductSalesDetails).June;
                }
            }
            else if (totalSummary)
            {
                foreach (var data in view.Records)
                {
                    if (column.Equals("January"))
                        summary += ((data as RecordEntry).Data as ProductSalesDetails).January;
                    else if (column.Equals("February"))
                        summary += ((data as RecordEntry).Data as ProductSalesDetails).February;
                    else if (column.Equals("March"))
                        summary += ((data as RecordEntry).Data as ProductSalesDetails).March;
                    else if (column.Equals("April"))
                        summary += ((data as RecordEntry).Data as ProductSalesDetails).April;
                    else if (column.Equals("May"))
                        summary += ((data as RecordEntry).Data as ProductSalesDetails).May;
                    else if (column.Equals("June"))
                        summary += ((data as RecordEntry).Data as ProductSalesDetails).May;
                }
            }

            return summary;
        }

        /// <summary>
        /// Which is used to customize the unbound rows. 
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="GridUnboundRowEventsArgs"/> contains event data.</param>
        void SfDataGrid_QueryUnboundRow(object sender, QueryUnboundRowInfoArgs e)
        {
            if (!(totalSales.ContainsKey(e.Column.MappingName)))
                return;

            if (e.UnboundAction == UnboundActions.QueryData)
            {
                if (e.RowColumnIndex.RowIndex == 1)
                {
                    if (e.RowColumnIndex.ColumnIndex == 0)
                    {
                        e.Value = "Total Sales By Month";
                    }
                    else
                    {
                        e.Value = totalSales[e.Column.MappingName];
                    }
                }
                else if (e.UnboundRow.UnboundRowIndex == 0 && e.UnboundRow.Position == VerticalPosition.Bottom && e.UnboundRow.ShowBelowSummary == true)
                {
                    if (e.RowColumnIndex.ColumnIndex == 0)
                    {
                        e.Value = "Percent of Selected Rows Summary";
                    }
                    else
                    {
                        e.Value = string.Format("{0}%", percentSales[e.Column.MappingName]);
                    }
                }
                else if (e.UnboundRow.UnboundRowIndex == 1 && e.UnboundRow.Position == VerticalPosition.Bottom && e.UnboundRow.ShowBelowSummary == true)
                {
                    if (e.RowColumnIndex.ColumnIndex == 0)
                    {
                        e.Value = "Percent of Selected Rows";
                    }
                    else
                    {
                        if (!(totalSelectedSales.ContainsKey(e.Column.MappingName)))
                            return;

                        e.Value = string.Format("{0:C}", (totalSelectedSales[e.Column.MappingName] * (percentSales[e.Column.MappingName] / 100)));
                    }
                }
                else if (e.UnboundRow.UnboundRowIndex == 2 && e.UnboundRow.Position == VerticalPosition.Bottom && e.UnboundRow.ShowBelowSummary == true)
                {
                    if (e.RowColumnIndex.ColumnIndex == 0)
                    {
                        e.Value = "Summary of Selected Rows";
                    }
                    else
                    {
                        if (!(totalSelectedSales.ContainsKey(e.Column.MappingName)))
                            return;

                        e.Value = string.Format("{0:C}", totalSelectedSales[e.Column.MappingName]);
                    }
                }

                else if (e.UnboundRow.UnboundRowIndex == 3 && e.UnboundRow.Position == VerticalPosition.Bottom && e.UnboundRow.ShowBelowSummary == true)
                {
                    int count = this.sfDataGrid.SelectedItems.Count;
                    if (e.RowColumnIndex.ColumnIndex == 0)
                    {
                        e.Value = "Average of Selected Rows";
                    }
                    else
                    {
                        if (!(totalSelectedSales.ContainsKey(e.Column.MappingName)))
                            return;

                        e.Value = (totalSelectedSales[e.Column.MappingName] / count);
                        e.Value = double.IsNaN((double)e.Value) ? 0.0 : e.Value;
                        e.Value = string.Format("{0:C}", e.Value);
                    }
                }

                e.Handled = true;
            }
            else if (e.UnboundAction == UnboundActions.CommitData)
            {
                if (e.Value.ToString().Equals(string.Empty))
                    return;
                double data;
                foreach (char character in e.Value.ToString().ToCharArray())
                    if (char.IsLetter(character))
                        return;

                if (e.Value.ToString().Contains("$"))
                    data = Convert.ToDouble(e.Value.ToString().Substring(1, e.Value.ToString().Length - 1));
                else if (e.Value.ToString().Contains("%"))
                {
                    data = Convert.ToDouble(e.Value.ToString().Replace("%", ""));
                }
                else
                    data = Convert.ToDouble(e.Value);

                var value = Convert.ToDouble(data);
                percentSales[e.Column.MappingName] = value;
            }
        }

        /// <summary>
        /// Which is used to customize the row height.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="QueryRowHeightEventArgs"/> contains the event data.</param>
        void SfDataGrid_QueryRowHeight(object sender, QueryRowHeightEventArgs e)
        {
            if (e.RowIndex == 0)
            {
                e.Height = (int)DpiAware.LogicalToDeviceUnits(30.0f);
                e.Handled = true;
            }
            // Which customize the height of UnboundRow.
            else if (this.sfDataGrid.IsUnboundRow(e.RowIndex))
            {
                e.Height = (int)DpiAware.LogicalToDeviceUnits(50.0f);
                e.Handled = true;
            }
            else
            {
                e.Height = (int)DpiAware.LogicalToDeviceUnits(35.0f);
                e.Handled = true;
            }
        }

        #endregion
    }
}

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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoRowHeight
{
    public partial class Form1 : Form
    {
        #region Fields

        /// <summary>
        /// To get the auto fit row height.
        /// </summary>
        int height;

        /// <summary>
        /// Specifies the auto fit row height calculation options for the data grid.
        /// </summary>
        RowAutoFitOptions gridRowResizingOptions = new RowAutoFitOptions();

        /// <summary>
        /// Specifies the collection of columns that needs to be excluded from the auto height calculation.
        /// </summary>
        List<string> excludeColumns = new List<string>();

        #endregion

        public Form1()
        {
            InitializeComponent();
            OrderInfoCollection collection = new OrderInfoCollection();
            sfDataGrid1.DataSource = collection.GetListOrdersDetails(1000);
            GridSettings();
        }

        private void GridSettings()
        {
            sfDataGrid1.AllowResizingColumns = true;
            sfDataGrid1.TableSummaryRows.Add(new GridTableSummaryRow()
            {
                Name = "tableSumamry",
                ShowSummaryInRow = true,
                Position = VerticalPosition.Bottom,
                Title = "Total Records : {OrderID}",
                SummaryColumns = new System.Collections.ObjectModel.ObservableCollection<ISummaryColumn>()
                {
                    new GridSummaryColumn()
                    {
                        Name = "OrderID",
                        MappingName = "OrderID",
                        SummaryType = Syncfusion.Data.SummaryType.CountAggregate,
                        Format = "{Count:d}"
                    }
                }
            });

            // Add the excluded columns for calculating the auto row height.
            foreach (var column in this.sfDataGrid1.Columns)
            {
                if (!column.MappingName.Equals("OrderDate") && !column.MappingName.Equals("ProductName"))
                    excludeColumns.Add(column.MappingName);
            }

            (sfDataGrid1.Columns["ProductName"] as GridTextColumn).AllowTextWrapping = true;
            (sfDataGrid1.Columns["Designation"] as GridTextColumn).AllowTextWrapping = true;
            sfDataGrid1.QueryRowHeight += sfDataGrid1_QueryRowHeight;
            gridRowResizingOptions.ExcludeColumns = excludeColumns;
        }

        /// <summary>
        /// Occurs while setting the row heights.
        /// </summary>
        /// <param name="sender">The object of the sender.</param>
        /// <param name="e">An <see cref="Syncfusion.WinForms.DataGrid.QueryRowHeightEventArgs"/> that contains event data.</param>
        void sfDataGrid1_QueryRowHeight(object sender, QueryRowHeightEventArgs e)
        {
            if (this.sfDataGrid1.TableControl.IsTableSummaryIndex(e.RowIndex))
            {
                e.Height = 40;
                e.Handled = true;
            }
            else if (this.sfDataGrid1.AutoSizeController.GetAutoRowHeight(e.RowIndex, gridRowResizingOptions, out height))
            {
                if (height > this.sfDataGrid1.RowHeight)
                {
                    e.Height = height;
                    e.Handled = true;
                }
            }
        }
    }
}

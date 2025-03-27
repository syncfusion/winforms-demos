#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
# region Directives

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Syncfusion.Windows.Forms.Grid.Grouping;
using Syncfusion.Grouping;
using Syncfusion.Windows.Forms.Grid;
using Syncfusion.Windows.Forms;

#endregion

namespace LinqGroupBy
{
    class CustomerQuery : SampleQuery
    {
        # region Method

        # region Override Method

        public override void InitializeGrid(GridGroupingControl grid, NorthwindwithImage db)
        {
            var customerQuery = from customer in db.Customers
                                select customer;

            var customerTotals = customerQuery.Count();

            PassThroughGroupingResult customerQueryResults = new PassThroughGroupingResult(
                    "Customer",
                    customerQuery,
                    typeof(Customers),
                    customerTotals
                    );

            grid.UseLazyUniformChildListRelation = true;
            grid.DataSource = customerQueryResults;
            grid.TableDescriptor.Columns["CompanyName"].HeaderText = "Company Name";
            grid.TableDescriptor.Columns["CustomerID"].HeaderText = "Customer ID";
            grid.TableDescriptor.Columns["ContactName"].HeaderText = "Contact Name";
            grid.TableDescriptor.Columns["ContactTitle"].HeaderText = "Contact Title";

            grid.TableModel.Options.DefaultGridBorderStyle = GridBorderStyle.Solid;
            grid.Table.TableOptions.RecordRowHeight = (int)DpiAware.LogicalToDeviceUnits(22.0f);
            grid.Table.TableOptions.ColumnHeaderRowHeight = (int)DpiAware.LogicalToDeviceUnits(26.0f);
            grid.Table.TableOptions.CaptionRowHeight = (int)DpiAware.LogicalToDeviceUnits(22.0f);

            // Clear out otherwise autopopulated UniformChildList relations
            // for Orders and CustomerCustomerDemos.
            //grid.TableDescriptor.Relations[1].ChildTableDescriptor.GroupedColumns.Add("Shipper_CompanyName");
            //grid.TableDescriptor.Relations[1].ChildTableDescriptor.GroupedColumns.Add("Employee_LastName");

            // Question: When consumer of customerQuery accesses nested lists such as Orders
            // will Linq fire a separate select statement or will they already
            // be in memory?

            grid.TableOptions.ColumnsMaxLengthStrategy = GridColumnsMaxLengthStrategy.FirstNRecords;

        }

        #endregion

        #endregion
    }
}

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
using System.Collections;
using System.Text.RegularExpressions;

#endregion

namespace LinqGroupBy
{
    class CustomerOrdersDetails : SampleQuery
    {
        # region Variable Declaration

        NorthwindwithImage db;

        #endregion

        # region Method

        # region Override Method

        public override void InitializeGrid(GridGroupingControl grid, NorthwindwithImage db)
        {
            this.db = db;

            var customerQuery = from customer in db.Customers
                                select customer;

            var customerTotals = customerQuery.Count();

            grid.TableOptions.ColumnsMaxLengthStrategy = GridColumnsMaxLengthStrategy.FirstNRecords;

            // Pass in a sample query for determing optimal column widths.
            // Use this together with GridColumnsMaxLengthStrategy.FirstNRecords
            IEnumerable customerSamples = customerQuery.Take(10);
            IEnumerable ordersSamples = (from p in db.Orders select p).Take(10);
            IEnumerable orderDetailSamples = (from p in db.OrderDetails select p).Take(10);

            PassThroughGroupingResult customerQueryResults = new PassThroughGroupingResult(
                    "Customer",
                    customerQuery,
                    typeof(Customers),
                    customerTotals,
                    customerSamples
                    );

            PassThroughGroupingResult orderResults = new PassThroughGroupingResult(
                    "Orders",
                    new NestedQueryResultsDelegate(this.GetOrdersForCustomer),
                    typeof(Orders),
                    ordersSamples
                    );

            PassThroughGroupingResult orderDetailResults = new PassThroughGroupingResult(
                    "OrderDetails",
                    new NestedQueryResultsDelegate(this.GetOrderDetailForOrder),
                    typeof(OrderDetails),
                    orderDetailSamples
                    );

            grid.SourceListSet.Add("Customer", customerQueryResults);
            grid.SourceListSet.Add("Orders", orderResults);
            grid.SourceListSet.Add("OrderDetail", orderDetailResults);
           
            grid.DataSource = customerQueryResults;
            grid.TableDescriptor.Columns["CustomerID"].HeaderText = "Customer ID";
            grid.TableDescriptor.Columns["CompanyName"].HeaderText = "Company Name";
            grid.TableDescriptor.Columns["ContactName"].HeaderText = "Contact Name";
            grid.TableDescriptor.Columns["ContactTitle"].HeaderText = "Contact Title";

            foreach (GridTableDescriptor td in grid.Engine.EnumerateTableDescriptor())
            {
                if (td.Name == "Orders")
                {
                    td.Columns["OrderID"].HeaderText = "Order ID";
                    td.Columns["ShipName"].HeaderText = "ShipName";
                    td.Columns["ShipAddress"].HeaderText = "Ship Address";
                    td.Columns["EmployeeID"].HeaderText = "Employee ID";
                    td.Columns["OrderDate"].HeaderText = "Order Date";
                    td.Columns["RequiredDate"].HeaderText = "Required Date";
                    td.Columns["ShippedDate"].HeaderText = "Shipped Date";
                    td.Columns["ShipCity"].HeaderText = "Ship City";
                    td.Columns["ShipCountry"].HeaderText = "Ship Country";
                    td.Columns["ShipRegion"].HeaderText = "Ship Region";
                    td.Columns["ShipPostalCode"].HeaderText = "Ship Postal Code";

                }
            }

            // Clear out otherwise autopopulated UniformChildList relations
            // for Orders and CustomerCustomerDemos.
            grid.TableDescriptor.Relations.Clear();

            GridRelationDescriptor orders = new GridRelationDescriptor("Orders");
            orders.RelationKeys.Add("CustomerID", "CustomerID");
            orders.ChildTableName = "Orders";
            orders.RelationKind = RelationKind.RelatedMasterDetails;
            orders.ChildTableDescriptor.Relations.Clear();
            grid.TableDescriptor.Relations.Add(orders);
            GridTableDescriptor tabd1 = grid.GetTableDescriptor("Orders");
            if (tabd1.Name == "Orders")
            {
                tabd1.Columns["OrderID"].HeaderText = "Order ID";
                tabd1.Columns["ShipName"].HeaderText = "ShipName";
                tabd1.Columns["ShipAddress"].HeaderText = "Ship Address";
                tabd1.Columns["EmployeeID"].HeaderText = "Employee ID";
                tabd1.Columns["OrderDate"].HeaderText = "Order Date";
                tabd1.Columns["RequiredDate"].HeaderText = "Required Date";
                tabd1.Columns["ShippedDate"].HeaderText = "Shipped Date";
                tabd1.Columns["ShipCity"].HeaderText = "Ship City";
                tabd1.Columns["ShipCountry"].HeaderText = "Ship Country";
                tabd1.Columns["ShipRegion"].HeaderText = "Ship Region";
                tabd1.Columns["ShipPostalCode"].HeaderText = "Ship Postal Code";

            }


            GridRelationDescriptor orderDetail = new GridRelationDescriptor("OrderDetail");
            orderDetail.RelationKeys.Add("OrderID", "OrderID");
            orderDetail.ChildTableName = "OrderDetail";
            orderDetail.RelationKind = RelationKind.RelatedMasterDetails;
            orderDetail.ChildTableDescriptor.Relations.Clear();
            GridSummaryColumnDescriptor prizeAvgSummary = new GridSummaryColumnDescriptor(
                "PrizeAvgSummary", 
                SummaryType.Custom,
                "UnitPrice",
                "{PrizeAvg:#.##}"
                );
            orderDetail.ChildTableDescriptor.SummaryRows.Add(
                new GridSummaryRowDescriptor("Row 1", prizeAvgSummary)
                );
            orderDetail.ChildTableDescriptor.TopLevelGroupOptions.CaptionText = 
                "{TableName}: {RecordCount} Items, Average UnitPrice is {Row 1.PrizeAvgSummary}";
            orders.ChildTableDescriptor.Relations.Add(orderDetail);

            GridTableDescriptor tabd = grid.GetTableDescriptor("OrderDetail");

            if (tabd.Name == "Orders")
            {
                tabd.Columns["ProductID"].HeaderText = "Product ID";
                tabd.Columns["UnitPrice"].HeaderText = "Heater text";

            }


        }

        #endregion

        # region Public Method

        public IEnumerable GetOrdersForCustomer(object[] keys, out object totals)
        {
            var orderQuery =
                from p in db.Orders
                where p.CustomerID.Equals(keys[0])
                select p
                ;

            totals = orderQuery.Count();

            return orderQuery;
        }

        public IEnumerable GetOrderDetailForOrder(object[] keys, out object totals)
        {
            var orderDetailQuery =
                from p in db.OrderDetails
                where p.OrderID.Equals(keys[0])
                select p;

            totals = (from p in db.OrderDetails
                where p.OrderID.Equals(keys[0])
                group p by 0 into g
                select new
                {
                    Count = g.Count(),
                    PrizeAvg = g.Average(p => p.UnitPrice),
                    Details = g
                }).Single();

            return orderDetailQuery;
        }

        #endregion

        #endregion
    }
}

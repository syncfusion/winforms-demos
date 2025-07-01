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

# endregion

namespace LinqGroupBy
{
    class CustomerOrders : SampleQuery
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
            
            PassThroughGroupingResult customerQueryResults = new PassThroughGroupingResult(
                    "Customer",
                    customerQuery,
                    typeof(Customers),
                    customerTotals,
                    customerSamples,
                    new UpdateHelper()
                    );

            PassThroughGroupingResult orderResults = new PassThroughGroupingResult(
                    "Orders",
                    new NestedQueryResultsDelegate(this.GetOrdersForCustomer),
                    typeof(Orders),
                    ordersSamples
                    );

            grid.SourceListSet.Add("Customer", customerQueryResults);
            grid.SourceListSet.Add("Orders", orderResults);
            
            grid.DataSource = customerQueryResults;

            // Clear out otherwise autopopulated UniformChildList relations
            // for Orders and CustomerCustomerDemos.
            grid.TableDescriptor.Relations.Clear();

            GridRelationDescriptor orders = new GridRelationDescriptor("Orders");
            orders.RelationKeys.Add("CustomerID", "CustomerID");
            orders.ChildTableName = "Orders";
            orders.RelationKind = RelationKind.RelatedMasterDetails;
            orders.ChildTableDescriptor.Relations.Clear();
            grid.TableDescriptor.Columns["CustomerID"].HeaderText = "Customer ID";
            grid.TableDescriptor.Columns["CompanyName"].HeaderText = "Company Name";
            grid.TableDescriptor.Columns["ContactName"].HeaderText = "Contact Name";
            grid.TableDescriptor.Columns["ContactTitle"].HeaderText = "Contact Title";
            grid.TableDescriptor.Columns["PostalCode"].HeaderText = "Postal Code";

            grid.TableDescriptor.Relations.Add(orders);
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
            // Question: When consumer of customerQuery accesses nested lists such as Orders
            // will Linq fire a separate select statement or will they already
            // be in memory?
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

        #endregion
        #endregion

        public class UpdateHelper : IRecordUpdateHelper
        {
            #region IRecordUpdateHelper Members

            public bool CanSaveRecord(object item)
            {
                return true;
            }

            public void SaveRecord(object item, Table table)
            {

            }

            public void AddRecord(object item, Table table)
            {
                Console.WriteLine(table.CurrentRecord);
            }

            public bool DeleteRecord(object item, Table table)
            {
                return false;
            }

            #endregion
        }

    }
}

#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
# region Directives

using System.Collections;
using System.Linq;
using Syncfusion.Windows.Forms.Grid.Grouping;
using Syncfusion.Grouping;

#endregion

namespace LinqGroupBy
{
    class CustomerGroupByCountry : SampleQuery
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
                                group customer by customer.Country into g
                                select new
                                {
                                    Key = g.Key,
                                    Count = g.Count(),
                                   
                                };

            var customerTotals = db.Customers.Count();

            grid.TableOptions.ColumnsMaxLengthStrategy = GridColumnsMaxLengthStrategy.FirstNRecords;

            // Pass in a sample query for determing optimal column widths.
            // Use this together with GridColumnsMaxLengthStrategy.FirstNRecords
            IEnumerable customerSamples = (from c in db.Customers select c).Take(10);

            PassThroughGroupingResult customerQueryResults = new PassThroughGroupingResult(
                    "Customer",
                    customerQuery,
                    typeof(Customers),
                    customerTotals,
                    new QueryGroupsDetailsDelegate(GetDetailsForCountry),
                    customerSamples,
                    "Country"
                    );

            grid.DataSource = customerQueryResults;

            // Clear out otherwise autopopulated UniformChildList relations
            // for Orders and CustomerCustomerDemos.
            grid.TableDescriptor.Relations.Clear();
        }

        #endregion

        # region Public Method

        public IEnumerable GetDetailsForCountry(Group group)
        {
            // If group is nested, you also need to filter with CategoryKeys from g.ParentGroup!
            string country = (string) PassThroughGroupingResult.GetValue(group.PassThroughItem, "Key");

            // TODO: If country is null find a way to query for it more efficiently ...
            if (country == null)
            {
                return
                    from p in db.Customers
                    where !(p.Country != null)
                    select p;
            }

            var query =
                from p in db.Customers
                where p.Country == country
                select p
                ;

            return query;
        }

        #endregion

        #endregion
    }
}

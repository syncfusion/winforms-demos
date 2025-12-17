#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
# region Directives

using System.Linq;
using Syncfusion.Grouping;
using Syncfusion.Windows.Forms.Grid.Grouping;
using System.Collections;

#endregion

namespace LinqGroupBy
{
    class ProductsGroupedBySupplier : SampleQuery
    {
        # region Variable Declaration

        NorthwindwithImage db;

        #endregion

        # region Method

        # region Override Method

        public override void InitializeGrid(GridGroupingControl grid, NorthwindwithImage db)
        {
            this.db = db;
            
            var productQuery = from p in db.Products
                               group p by p.SupplierID into g
                               select new
                               {
                                   Caption = g.Key.Value,
                                   Key = g.Key,
                                   Count = g.Count(),
                                   PrizeAvg = g.Average(p => p.UnitPrice),
                                   //Details = g
                               };

            // How to calculate aggregates for the whole query with? 
            // C# (see also ms-help://MS.VSCC.v90/MS.MSDNQTR.v90.en/dv_linq/html/36d97c83-5de5-457d-971d-10a69365e7c4.htm)
            // It just says "not applicable" ?.? 
            // So as a workaround group by a constant and this will return one single group.
            var productTotalsQuery = from p in db.Products
                                     group p by 0 into g
                                     select new
                                     {
                                         Count = g.Count(),
                                         PrizeAvg = g.Average(p => p.UnitPrice),
                                     };
            object productTotals = productTotalsQuery.Single();

            // Pass in a sample query for determing optimal column widths.
            // Use this together with GridColumnsMaxLengthStrategy.FirstNRecords
            var productSampleQuery = from p in db.Products
                                     select p;

            grid.TableOptions.ColumnsMaxLengthStrategy = GridColumnsMaxLengthStrategy.FirstNRecords;


            PassThroughGroupingResult productQueryResults = new PassThroughGroupingResult(
                    "Product",
                    productQuery,
                    typeof(Products),
                    productTotals,
                    new QueryGroupsDetailsDelegate(GetDetailsForSupplier),
                    productSampleQuery.Take(10),
                    "Supplier"
                    );

            // Summary that is retrieved from query
            GridSummaryColumnDescriptor prizeAvgSummary = new GridSummaryColumnDescriptor(
                "PrizeAvgSummary",
                SummaryType.Custom,
                "UnitPrice",
                "{PrizeAvg:#.##}"
                );

            // Summary that is calculated by grid engine internal from populated records (but this one
            // has limitation ... see comments below)
            GridSummaryColumnDescriptor unitsInStockSummary = new GridSummaryColumnDescriptor(
               "UnitsSummary",
               SummaryType.Int32Aggregate,
               "UnitsInStock",
               "{Sum}"
               );


            // Note: UnitsSummary will only work for the group with the records. The parent groups
            // or TopLevelGroup that has no populated records will not be able to calculate the UnitsSummary since
            // no records are populated at the time the "Supplier" group is expanded.

            grid.TableDescriptor.SummaryRows.Add(
                new GridSummaryRowDescriptor("Row 1", new GridSummaryColumnDescriptor[] { 
                    prizeAvgSummary, 
                    unitsInStockSummary }
                    )
                );
         
            grid.TableDescriptor.TopLevelGroupOptions.CaptionText =
                "{TableName}: {RecordCount} Items, Average UnitPrice is {Row 1.PrizeAvgSummary}";


            grid.DataSource = productQueryResults;

            grid.TableDescriptor.Columns["ProductID"].HeaderText = "Product ID";
            grid.TableDescriptor.Columns["ProductName"].HeaderText = "Product Name";
            grid.TableDescriptor.Columns["SupplierID"].HeaderText = "SupplierID";
            grid.TableDescriptor.Columns["CategoryID"].HeaderText = "Category ID";
            grid.TableDescriptor.Columns["QuantityPerUnit"].HeaderText = "Quantity Per Unit";
            grid.TableDescriptor.Columns["UnitPrice"].HeaderText = "Unit Price";
            grid.TableDescriptor.Columns["UnitsInStock"].HeaderText = "Units In Stock";
            grid.TableDescriptor.Columns["UnitsOnOrder"].HeaderText = "Unit On Order";
            grid.TableDescriptor.Columns["ReorderLevel"].HeaderText = "Re0rder Level";
            grid.TableDescriptor.Columns["UnitPrice"].HeaderText = "Unit Price";

            // Clear out otherwise autopopulated UniformChildList relations
            grid.TableDescriptor.Relations.Clear();
        }

        #endregion

        # region Public Method

        public IEnumerable GetDetailsForSupplier(Group group)
        {
            // If group is nested, you also need to filter with CategoryKeys from g.ParentGroup!
            int supplierID = (int) PassThroughGroupingResult.GetValue(group.PassThroughItem, "Key");

            var query =
                from p in db.Products
                where p.SupplierID == supplierID
                select p
                ;

            return query;
        }

        #endregion

        #endregion
    }

}

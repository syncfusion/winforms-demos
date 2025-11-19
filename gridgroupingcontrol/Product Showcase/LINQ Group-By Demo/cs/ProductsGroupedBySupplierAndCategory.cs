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
    class ProductsGroupedBySupplierAndCategory : SampleQuery
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
                                  
                               };

            // I can't figure out how to calculate aggregates for the whole query with
            // C# (see also ms-help://MS.VSCC.v90/MS.MSDNQTR.v90.en/dv_linq/html/36d97c83-5de5-457d-971d-10a69365e7c4.htm)
            // It just says "not applicable" ?.? 
            // So as a workaround I group by a constant and this will return me one single group.
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
                    new QueryGroupsDetailsDelegate(GetDetailsForGroup),
                    productSampleQuery.Take(10), 
                    "SupplierID", "CategoryID"
                    );


            grid.DataSource = productQueryResults;

            // Clear out otherwise autopopulated UniformChildList relations
            grid.TableDescriptor.Relations.Clear();

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
            // that have no populated records will not be able to calculate the UnitsSummary since
            // no records are populated at the time the "Supplier" group is expanded.

            grid.TableDescriptor.Columns["SupplierID"].GroupByOptions.ShowSummaries = false;
            grid.TableDescriptor.Columns["SupplierID"].GroupByOptions.CaptionText = "Supplier: {Category} - {RecordCount} Items";

            grid.TableDescriptor.Columns["CategoryID"].GroupByOptions.CaptionText = "Category: {Category} - {RecordCount} Items";
                
            grid.TableDescriptor.TopLevelGroupOptions.ShowSummaries = false;
            grid.TableDescriptor.Columns["QuantityPerUnit"].HeaderText = "Quantity Per Unit";
            grid.TableDescriptor.Columns["UnitPrice"].HeaderText = "Unit Price";
            grid.TableDescriptor.Columns["UnitsInStock"].HeaderText = "Units In Stock";
            grid.TableDescriptor.Columns["ReorderLevel"].HeaderText = "Re0rder Level";
            grid.TableDescriptor.Columns["UnitPrice"].HeaderText = "Unit Price";
            grid.TableDescriptor.Columns["SupplierID"].HeaderText = "Supplier ID";
            grid.TableDescriptor.Columns["CategoryID"].HeaderText = "Category ID";
            grid.TableDescriptor.Columns["ProductID"].HeaderText = "Product ID";
            grid.TableDescriptor.Columns["ProductName"].HeaderText = "Product Name";



            grid.TableDescriptor.SummaryRows.Add(
                new GridSummaryRowDescriptor("Row 1", new GridSummaryColumnDescriptor[] { 
                    prizeAvgSummary, 
                    unitsInStockSummary }
                    )
                );
         
            grid.TableDescriptor.TopLevelGroupOptions.CaptionText =
                "{TableName}: {RecordCount} Items, Average UnitPrice is {Row 1.PrizeAvgSummary}";

        }

        #endregion

        # region Public Method

        public IEnumerable GetDetailsForGroup(Group group)
        {
            switch (group.GroupLevel)
            {
                case 0:
                  
                    {
                        // If group is nested, you also need to filter with CategoryKeys from g.ParentGroup!
                        int supplierID = (int) PassThroughGroupingResult.GetValue(group.PassThroughItem, "Key");

                        var query =
                            from p in db.Products
                            where p.SupplierID == supplierID
                            group p by p.CategoryID into g
                            select new
                            {
                                Caption = g.Key.Value,
                                Key = g.Key,
                                Count = g.Count(),
                                PrizeAvg = g.Average(p => p.UnitPrice),
                              
                            }

                            ;

                        return query;
                    }

                case 1:
                   
                    {
                        // If group is nested, you also need to filter with CategoryKeys from g.ParentGroup!
                        int supplierID = (int) PassThroughGroupingResult.GetValue(group.ParentGroup.PassThroughItem, "Key");
                        int categoryID = (int) PassThroughGroupingResult.GetValue(group.PassThroughItem, "Key");

                        var query =
                            from p in db.Products
                            where p.SupplierID == supplierID 
                                && p.CategoryID == categoryID
                            select p
                            ;

                        return query;
                    }
            }

            return null;

        }

        #endregion

        #endregion
    }
}

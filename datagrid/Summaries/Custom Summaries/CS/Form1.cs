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
using System.Windows.Forms;

namespace CustomSummarries
{
    public partial class Form1 : Form
    {
        #region Constructor
        public Form1()
        {
            InitializeComponent();
            SalesInfoCollection collection = new SalesInfoCollection();
            sfDataGrid.DataSource = collection.YearlySalesDetails;
            GridSettings();
        }

        #endregion

        #region Grid Settings

        /// <summary>
        /// Grid Settings for better Look and Feel.
        /// </summary>
        private void GridSettings()
        {
            this.sfDataGrid.GroupColumnDescriptions.Add(new GroupColumnDescription() { ColumnName = "Year" });

            //Added the TableSummaryRow.
            this.sfDataGrid.TableSummaryRows.Add(new GridTableSummaryRow()
            {
                Name = "tableSumamryTrue",
                ShowSummaryInRow = true,
                Title = "Average :  {TotalAverage}     Total Sales : {TotalSales}",
                SummaryColumns = new System.Collections.ObjectModel.ObservableCollection<Syncfusion.Data.ISummaryColumn>()
                {
                    new GridSummaryColumn()
                    {
                        Name = "TotalAverage",
                        CustomAggregate=new CustomAggregate(),
                        SummaryType=SummaryType.DoubleAggregate,
                        Format="{Average:c}",
                        MappingName="Total"
                    },
                    new GridSummaryColumn()
                    {
                        Name = "TotalSales",
                        CustomAggregate=new CustomAggregate(),
                        SummaryType=SummaryType.DoubleAggregate,
                        Format="{Sum:c}",
                        MappingName="Total"
                    },
                }
            });

            this.sfDataGrid.TableSummaryRows.Add(new GridTableSummaryRow()
            {
                Name = "tableSumamryTrue",
                Title = "Statistic Median : {TotalSales}      Total Distinct Year : {TotalYear}",
                ShowSummaryInRow = true,
                SummaryColumns = new System.Collections.ObjectModel.ObservableCollection<Syncfusion.Data.ISummaryColumn>()
                {
                    new GridSummaryColumn()
                    {
                        Name = "TotalSales",
                        CustomAggregate=new CustomAggregate(),
                        SummaryType=SummaryType.Custom,
                        Format="{Median}",
                        MappingName="Total"
                    },
                    new GridSummaryColumn()
                    {
                         Name = "TotalYear",
                        CustomAggregate=new CustomAggregate(),
                        SummaryType=SummaryType.DoubleAggregate,
                        Format="{Count}",
                        MappingName="Year"
                    }
                }
            });

            //Added the GroupSummaryRows.
            this.sfDataGrid.GroupSummaryRows.Add(new GridSummaryRow()
            {
                Name = "groupSumamryFasle",
                ShowSummaryInRow = false,
                SummaryColumns = new System.Collections.ObjectModel.ObservableCollection<Syncfusion.Data.ISummaryColumn>()
                {
                    new GridSummaryColumn()
                    {
                        Name = "TotalSales",
                        CustomAggregate=new CustomAggregate(),
                        SummaryType=SummaryType.DoubleAggregate,
                        Format="Avg : ${Average:#.00}",
                        MappingName="Total"
                    },                    
                }
            });

            //Added the CaptionSummaryRow.           
            sfDataGrid.CaptionSummaryRow = new GridSummaryRow()
            {
                Name = "captionSummary",
                Title = "Standard Deviation for Total Sales : {TotalYear}",
                ShowSummaryInRow = true,
                SummaryColumns = new System.Collections.ObjectModel.ObservableCollection<Syncfusion.Data.ISummaryColumn>()
                {
                    new GridSummaryColumn()
                    {
                        Name = "TotalYear",
                        CustomAggregate=new CustomAggregate(),
                        SummaryType=SummaryType.Custom,
                        Format="{StdDev}",
                        MappingName="Year"
                    },
                }
            };
        }

        #endregion
    }
}

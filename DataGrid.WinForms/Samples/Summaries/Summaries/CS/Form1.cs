using Syncfusion.WinForms.DataGrid;
using Syncfusion.WinForms.DataGrid.Styles;
using System.Windows.Forms;
using Syncfusion.WinForms.DataGrid.Enums;
using Syncfusion.WinForms.DataGrid.Events;


namespace Summaries
{
    public partial class Form1 : Form
    {
        #region Constructor
        public Form1()
        {
            InitializeComponent();
            SalesInfoCollection sales = new SalesInfoCollection();
            sfDataGrid.DataSource = sales.YearlySalesDetails;
            this.sfDataGrid.DrawCell += SfDataGrid_DrawCell;
            GridSettings();
        }

        #endregion

        #region Grid Settings

        /// <summary>
        /// Grid Settings for better Look and Feel.
        /// </summary>
        private void GridSettings()
        {
            Syncfusion.WinForms.DataGrid.GroupColumnDescription groupColumnDescription1 = new Syncfusion.WinForms.DataGrid.GroupColumnDescription();
            groupColumnDescription1.ColumnName = "Name";
            this.sfDataGrid.GroupColumnDescriptions.Add(groupColumnDescription1);
            this.sfDataGrid.ExpandAllGroup();
            this.sfDataGrid.GroupCaptionTextFormat = "Sales details in {ColumnName} : {Key}";
            this.sfDataGrid.LiveDataUpdateMode = Syncfusion.Data.LiveDataUpdateMode.AllowDataShaping;

            //Add the TableSummary ShowInSumamryRow false.
            this.sfDataGrid.TableSummaryRows.Add(new GridTableSummaryRow()
            {
                Name = "tableSumamryFalse",
                ShowSummaryInRow = false,
                Position = VerticalPosition.Top,
                SummaryColumns = new System.Collections.ObjectModel.ObservableCollection<Syncfusion.Data.ISummaryColumn>()
                {
                    new GridSummaryColumn()
                    {
                        Name = "TQ1",
                        SummaryType = Syncfusion.Data.SummaryType.DoubleAggregate,
                        Format="{Sum:c}",
                        MappingName="Q1",
                    },
                    new GridSummaryColumn()
                    {
                        Name = "TQ2",
                        SummaryType = Syncfusion.Data.SummaryType.DoubleAggregate,
                        Format="{Sum:c}",
                        MappingName="Q2",
                    },
                    new GridSummaryColumn()
                    {
                        Name = "TQ3",
                        SummaryType = Syncfusion.Data.SummaryType.DoubleAggregate,
                        Format="{Sum:c}",
                        MappingName="Q3",
                    },
                    new GridSummaryColumn()
                    {
                        Name = "TQ4",
                        SummaryType = Syncfusion.Data.SummaryType.DoubleAggregate,
                        Format="{Sum:c}",
                        MappingName="Q4",
                    },
                    new GridSummaryColumn()
                    {
                        Name = "TQ4",
                        SummaryType = Syncfusion.Data.SummaryType.DoubleAggregate,
                        Format="{Sum:c}",
                        MappingName="Total",
                    }
                }
            });

            //Add the TableSummary ShowInSumamryRow true.
            this.sfDataGrid.TableSummaryRows.Add(new GridTableSummaryRow()
            {
                Name = "tableSumamryTrue",
                ShowSummaryInRow = true,
                Title = "Total Sales : {TotalSales}",
                SummaryColumns = new System.Collections.ObjectModel.ObservableCollection<Syncfusion.Data.ISummaryColumn>()
                {
                    new GridSummaryColumn()
                    {
                        Name = "TotalSales",
                        SummaryType = Syncfusion.Data.SummaryType.DoubleAggregate,
                        Format="{Sum:c}",
                        MappingName="Total",
                    },
                }
            });

            //Add the GroupSummary ShowInSumamryRow false.
            this.sfDataGrid.GroupSummaryRows.Add(new GridSummaryRow()
            {
                Name = "groupSumamryFasle",
                ShowSummaryInRow = false,
                SummaryColumns = new System.Collections.ObjectModel.ObservableCollection<Syncfusion.Data.ISummaryColumn>()
                {
                    new GridSummaryColumn()
                    {
                        Name = "SQ1",
                        SummaryType = Syncfusion.Data.SummaryType.DoubleAggregate,
                        Format="{Sum:c}",
                        MappingName="Q1",
                    },
                    new GridSummaryColumn()
                    {
                        Name = "SQ2",
                        SummaryType = Syncfusion.Data.SummaryType.DoubleAggregate,
                        Format="{Sum:c}",
                        MappingName="Q2",
                    },
                    new GridSummaryColumn()
                    {
                        Name = "SQ3",
                        SummaryType = Syncfusion.Data.SummaryType.DoubleAggregate,
                        Format="{Sum:c}",
                        MappingName="Q3",
                    },
                    new GridSummaryColumn()
                    {
                        Name = "SQ4",
                        SummaryType = Syncfusion.Data.SummaryType.DoubleAggregate,
                        Format="{Sum:c}",
                        MappingName="Q4",
                    },
                     new GridSummaryColumn()
                    {
                        Name = "SQ4",
                        SummaryType = Syncfusion.Data.SummaryType.DoubleAggregate,
                        Format="{Sum:c}",
                        MappingName="Total",
                    }
                }
            });

            //Add the GroupSummary ShowInSumamryRow true.
            this.sfDataGrid.GroupSummaryRows.Add(new GridSummaryRow()
            {
                Name = "groupSumamryTrue",
                ShowSummaryInRow = true,
                Title = "Total Sales in Year for {ProductCount} Products : {YearSales}",
                SummaryColumns = new System.Collections.ObjectModel.ObservableCollection<Syncfusion.Data.ISummaryColumn>()
                {
                    new GridSummaryColumn()
                    {
                        Name = "YearSales",
                        SummaryType = Syncfusion.Data.SummaryType.DoubleAggregate,
                        Format="{Sum:c}",
                        MappingName="Total",
                    },
                    new GridSummaryColumn()
                    {
                        Name = "ProductCount",
                        SummaryType = Syncfusion.Data.SummaryType.CountAggregate,
                        Format="{Count:d}",
                        MappingName="Name",
                    },
                }
            });
        }

        #endregion

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SfDataGrid_DrawCell(object sender, DrawCellEventArgs e)
        {
            if ((e.DataRow as DataRowBase).RowType == RowType.SummaryRow || (e.DataRow as DataRowBase).RowType == RowType.TableSummaryRow)
                e.Style.HorizontalAlignment = HorizontalAlignment.Right;
        }
    }
}

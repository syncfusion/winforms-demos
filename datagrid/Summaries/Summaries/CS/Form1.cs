#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Syncfusion.WinForms.DataGrid;
using Syncfusion.WinForms.DataGrid.Styles;
using System.Windows.Forms;
using Syncfusion.WinForms.DataGrid.Enums;
using Syncfusion.WinForms.DataGrid.Events;
using Syncfusion.Windows.Forms;

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
            this.calculationUnitComboBox.SelectedIndex = 0;
        }

        #endregion

        /// <summary>
        /// Occurs when the SummaryCalculationUnit is selected.
        /// </summary>
        /// <param name="sender">The sender that contains the ComboBox.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> that contains the event data.</param>
        private void OnCalculationUnitComboBoxSelectedIndexChanged(object sender, System.EventArgs e)
        {
            string selectedValue = this.calculationUnitComboBox.GetItemText(this.calculationUnitComboBox.SelectedItem);
            switch (selectedValue)
            {
                case "All Rows":
                    this.sfDataGrid.SummaryCalculationUnit = Syncfusion.Data.SummaryCalculationUnit.AllRows;
                    break;

                case "Selected Rows":
                    this.sfDataGrid.SummaryCalculationUnit = Syncfusion.Data.SummaryCalculationUnit.SelectedRows;
                    break;

                case "Mixed":
                    this.sfDataGrid.SummaryCalculationUnit = Syncfusion.Data.SummaryCalculationUnit.Mixed;
                    break;
            }
        }

        #region Grid Settings

        /// <summary>
        /// Grid Settings for better Look and Feel.
        /// </summary>
        private void GridSettings()
        {
            Syncfusion.WinForms.DataGrid.GroupColumnDescription groupColumnDescription1 = new Syncfusion.WinForms.DataGrid.GroupColumnDescription();
            groupColumnDescription1.ColumnName = "Year";
            this.sfDataGrid.GroupColumnDescriptions.Add(groupColumnDescription1);
            this.sfDataGrid.ExpandAllGroup();
            this.sfDataGrid.Columns["Name"].Width = (int)DpiAware.LogicalToDeviceUnits(171.0f);
            this.sfDataGrid.LiveDataUpdateMode = Syncfusion.Data.LiveDataUpdateMode.AllowDataShaping;
            this.sfDataGrid.Style.TableSummaryRowStyle.TextMargins = new Padding(3, 0, 3, 0);
            this.sfDataGrid.Style.GroupSummaryRowStyle.TextMargins = new Padding(3, 0, 3, 0);
            this.sfDataGrid.Style.CaptionSummaryRowStyle.TextMargins = new Padding(3, 0, 3, 0);
            //Add the Summary with title support in TableSummaryRow.
            this.sfDataGrid.TableSummaryRows.Add(new GridTableSummaryRow()
            {
                Name = "tableSumamryFalse",
                ShowSummaryInRow = false,
                Title="Total Sales :",
                TitleColumnCount=1,
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
                        Name = "TQ5",
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

            //Add the Summary with title support in CaptionSummaryRow.
            this.sfDataGrid.CaptionSummaryRow = new GridSummaryRow()
            {
                Name = "groupSumamryFasle",
                ShowSummaryInRow = false,
                Title="Sales details in {ColumnName} : {Key}", 
                TitleColumnCount=1,
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
                        Name = "SQ5",
                        SummaryType = Syncfusion.Data.SummaryType.DoubleAggregate,
                        Format="{Sum:c}",
                        MappingName="Total",
                    }
                }
            };

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
            DataRowBase dataRow = e.DataRow as DataRowBase;
            if (dataRow.RowType == RowType.SummaryRow || dataRow.RowType == RowType.TableSummaryRow)
                e.Style.HorizontalAlignment = HorizontalAlignment.Right;            
        }
    }
}

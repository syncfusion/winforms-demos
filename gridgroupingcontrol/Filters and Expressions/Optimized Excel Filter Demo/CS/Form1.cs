#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Syncfusion.GridHelperClasses;
using Syncfusion.Windows.Forms;
using Syncfusion.Windows.Forms.Grid.Grouping;
using Syncfusion.Windows.Forms.Grid;
using DemoCommon.Grid;

namespace Optimized_Excel_Filter
{
    public partial class Form1 : GridDemoForm
    {
        #region "Constructor"

        public Form1()
        {
            InitializeComponent();
            if (DpiAware.GetCurrentDpi() > 96)
            {
                this.CaptionBarHeight = (int)DpiAware.LogicalToDeviceUnits(this.CaptionBarHeight);
            }
            GridSettings();
            SampleCusomization();
        }

        #endregion

        #region "Grid Settings"

        /// <summary>
        /// Required Method for Grid Settings
        /// </summary>
        void GridSettings()
        {
            #region "Assigning DataSource"
            int count = 1000;
            DataTable childTable;
            DataTable parentTable = ProductSales.GetSalesData(count, out childTable);
            DataSet dset = new DataSet();
            dset.Tables.AddRange(new DataTable[] { parentTable, childTable });
            dset.Relations.Add(new DataRelation("ParentToChild", parentTable.Columns["id"], childTable.Columns["parentID"]));
            this.gridGroupingControl1.DataSource = parentTable;
            #endregion

            this.gridGroupingControl1.TableControl.DpiAware = true;
			this.gridGroupingControl1.GridVisualStyles = GridVisualStyles.Office2007Blue;

            this.gridGroupingControl1.ChildGroupOptions.ShowAddNewRecordBeforeDetails = false;
            this.gridGroupingControl1.ChildGroupOptions.ShowCaption = false;

            this.gridGroupingControl1.NestedTableGroupOptions.ShowAddNewRecordBeforeDetails = false;
            this.gridGroupingControl1.NestedTableGroupOptions.ShowCaption = false;

            this.gridGroupingControl1.TopLevelGroupOptions.ShowAddNewRecordBeforeDetails = false;
            this.gridGroupingControl1.TopLevelGroupOptions.ShowCaption = false;

            this.gridGroupingControl1.TableDescriptor.Columns["Quantity"].Appearance.AnyRecordFieldCell.Format = "0.0";
            this.gridGroupingControl1.TableDescriptor.Columns["Date"].Appearance.AnyRecordFieldCell.Format = "dd/MM/yyyy";
            this.gridGroupingControl1.TableDescriptor.VisibleColumns.Remove("Country");
            this.gridGroupingControl1.TableDescriptor.VisibleColumns.Remove("Amount");
            this.gridGroupingControl1.GridVisualStyles = GridVisualStyles.Metro;
            this.propertyGrid1.BackColor = Color.White;
            this.propertyGrid1.SelectedObject = this.gridGroupingControl1; this.gridGroupingControl1.ShowNavigationBar = true;
            this.gridGroupingControl1.AllowProportionalColumnSizing = true;
            this.gridGroupingControl1.TableOptions.ListBoxSelectionMode = SelectionMode.MultiExtended;
            this.gridGroupingControl1.QueryCellStyleInfo += new GridTableCellStyleInfoEventHandler(gridGroupingControl1_QueryCellStyleInfo);      

            //Navigate to other control using tabkey navigation
            this.gridGroupingControl1.WantTabKey = false;
        }

        #endregion

        #region "Sample Customizations"

        #region Declaring GridExcelFilter
        GridExcelFilter filter = new GridExcelFilter();
        #endregion

        /// <summary>
        /// Required Method for sample level customization.
        /// </summary>
        void SampleCusomization()
        {
            // Showing Filter Bar for Top Level Group Option
            this.gridGroupingControl1.TopLevelGroupOptions.ShowFilterBar = true;
            // Showing Filter Bar for Nested Level Group Option
            this.gridGroupingControl1.NestedTableGroupOptions.ShowFilterBar = true;
            // Showing Filter Bar for Child Level Group Option
            this.gridGroupingControl1.ChildGroupOptions.ShowFilterBar = true;

            // Allowing Filter Bar for all columns in the Parent Table.
            foreach (GridColumnDescriptor col in this.gridGroupingControl1.TableDescriptor.Columns)
            {
                col.AllowFilter = true;
            }

            // Allowing Filter Bar for all columns in the Child Table.
            GridTableDescriptor td = this.gridGroupingControl1.TableDescriptor.Relations["ParentToChild"].ChildTableDescriptor;
            foreach (GridColumnDescriptor col in td.Columns)
            {
                col.AllowFilter = true;
            }

            filter.AllowResize = true;
            filter.EnableDateFilter = true;
            filter.AllowSearch = false;
            filter.EnableNumberFilter = true;

            // Enable Optimized Filter in GridGRoupingControl.
            this.gridGroupingControl1.OptimizeFilterPerformance = true;
            
            // Wire the Grid to the Optimized Office 207 FIlter.
            filter.WireGrid(gridGroupingControl1);
        }
        
        #region "Events"

        void gridGroupingControl1_QueryCellStyleInfo(object sender, GridTableCellStyleInfoEventArgs e)
        {
            if (e.TableCellIdentity.TableCellType != GridTableCellType.AnyIndentCell && e.TableCellIdentity.DisplayElement.IsRecord())
            {
                if (e.TableCellIdentity.ColIndex > 4)
                {
                    if (e.TableCellIdentity.DisplayElement.GetRecord().Id == 7)
                    {
                        e.Style.BackColor = ColorTranslator.FromHtml("#00B0F0");
                        e.Style.TextColor = Color.DarkOliveGreen;
                    }
                    if (e.TableCellIdentity.DisplayElement.GetRecord().Id == 8)
                    {
                        e.Style.BackColor = Color.Red;
                        e.Style.TextColor = Color.Yellow;
                    }
                    if (e.TableCellIdentity.DisplayElement.GetRecord().Id == 9)
                    {
                        e.Style.BackColor = Color.Orange;
                        e.Style.TextColor = Color.Brown;
                    }
                    if (e.TableCellIdentity.DisplayElement.GetRecord().Id == 10)
                    {
                        e.Style.BackColor = Color.Yellow;
                        e.Style.TextColor = Color.Brown;
                    }
                    if (e.TableCellIdentity.DisplayElement.GetRecord().Id == 11)
                    {
                        e.Style.BackColor = ColorTranslator.FromHtml("#92D050");
                        e.Style.TextColor = ColorTranslator.FromHtml("#00B050");
                    }
                    if (e.TableCellIdentity.DisplayElement.GetRecord().Id == 12)
                    {
                        e.Style.BackColor = Color.LightGreen;
                        e.Style.BackColor = ColorTranslator.FromHtml("#92D050");
                        //e.Style.TextColor = Color.Brown;
                    }
                    if (e.TableCellIdentity.DisplayElement.GetRecord().Id == 13)
                    {
                        e.Style.BackColor = Color.Gold;
                        // e.Style.TextColor = Color.Red;
                    }
                    if (e.TableCellIdentity.DisplayElement.GetRecord().Id == 14)
                    {
                        e.Style.BackColor = Color.DarkSeaGreen;
                        // e.Style.TextColor = Color.Red;
                        //e.Style.BackColor = Color.Brown;
                        //e.Style.TextColor = ColorTranslator.FromHtml("#00B050");
                    }
                    if (e.TableCellIdentity.DisplayElement.GetRecord().Id == 15)
                    {
                        e.Style.BackColor = Color.Blue;
                        //e.Style.TextColor = Color.BurlyWood;
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            filter.ClearFilters(this.gridGroupingControl1);
        }

        #endregion

        #endregion
    }

    #region Sample Data

    public abstract class ProductSales
    {
        public abstract string Product { get; set; }

        public abstract string Date { get; set; }

        public abstract string Country { get; set; }

        public abstract string State { get; set; }

        public abstract int Quantity { get; set; }

        public abstract double Amount { get; set; }

        public abstract int id { get; set; }



        public static DataTable GetSalesData(int numberOfRecords, out DataTable childTable)
        {


            #region implementation

            /// Geography
            string[] countries = new string[] { "Australia", "Canada", "France", "Germany", "United Kingdom", "United States" };
            string[] ausStates = new string[] { "New South Wales", "Queensland", "South Australia", "Tasmania", "Victoria" };
            string[] canadaStates = new string[] { "Alberta", "British Columbia", "Brunswick", "Manitoba", "Ontario", "Quebec" };
            string[] franceStates = new string[] { "Charente Maritime", "Essonne", "Garonne (Haute)", "Gers", };
            string[] germanyStates = new string[] { "Bayern", "Brandenburg", "Hamburg", "Hessen", "Nordrhein Westfalen", "Saarland" };
            string[] ukStates = new string[] { "England" };
            string[] ussStates = new string[] { "New York", "North Carolina", "Alabama", "California", "Colorado", "New Mexico", "South Carolina" };

            /// Time
            string[] dates = new string[] { "FY 2005", "FY 2006", "FY 2007", "FY 2008", "FY 2009" };

            /// Products
            string[] products = new string[] { "Bike", "Car" };

            childTable = new DataTable("Child");
            childTable.Columns.Add("ID");
            childTable.Columns.Add("Field2");
            childTable.Columns.Add("Field3");
            childTable.Columns.Add("parentID");

            DataTable dt = new DataTable("Parent");
            dt.Columns.Add("ID");
            dt.Columns.Add("Date", typeof(DateTime));
            dt.Columns.Add("Product");
            dt.Columns.Add("Country");
            dt.Columns.Add("State");
            dt.Columns.Add("Amount", typeof(int));
            dt.Columns.Add("Quantity", typeof(double));

            Random r = new Random(123345345);

            dt.BeginLoadData();

            for (int i = 0; i < numberOfRecords; i++)
            {
                DataRow dr = dt.NewRow();
                dr["id"] = i;
                dr["Country"] = countries[r.Next(1, countries.GetLength(0))];
                dr["Quantity"] = r.Next(1, 12);

                dr["Amount"] = (30000 * (double)dr["Quantity"]);
                dr["Date"] = DateTime.Now.AddDays(r.Next(0, 40)).ToShortDateString();
                dr["Product"] = products[r.Next(r.Next(products.GetLength(0) + 1))];
                switch (dr["Country"].ToString())
                {
                    case "Australia":
                        {
                            dr["State"] = ausStates[r.Next(ausStates.GetLength(0))];
                            break;
                        }
                    case "Canada":
                        {
                            dr["State"] = canadaStates[r.Next(canadaStates.GetLength(0))];
                            break;
                        }
                    case "France":
                        {
                            dr["State"] = franceStates[r.Next(franceStates.GetLength(0))];
                            break;
                        }
                    case "Germany":
                        {
                            dr["State"] = germanyStates[r.Next(germanyStates.GetLength(0))];
                            break;
                        }
                    case "United Kingdom":
                        {
                            dr["State"] = ukStates[r.Next(ukStates.GetLength(0))];
                            break;
                        }
                    case "United States":
                        {
                            dr["State"] = ussStates[r.Next(ussStates.GetLength(0))];
                            break;
                        }

                }
               
                dt.Rows.Add(dr);

                int rows = r.Next(10);

                for (int k = 0; k < rows; ++k)
                {
                    DataRow dr1 = childTable.NewRow();
                    dr1[0] = k;
                    dr1[1] = string.Format("F2_{0}", r.Next(3));
                    dr1[2] = string.Format("F3_{0}", 100 + r.Next(3));
                    dr1[3] = i;
                    childTable.Rows.Add(dr1);
                }

            }
            dt.EndLoadData();
            #endregion

            return dt;
        }


        public override string ToString()
        {
            return string.Format("{0}-{1}-{2}", this.Country, this.State, this.Product);
        }

        public class ProductSalesCollection : List<ProductSales>
        {
        }
    }



    #endregion
}
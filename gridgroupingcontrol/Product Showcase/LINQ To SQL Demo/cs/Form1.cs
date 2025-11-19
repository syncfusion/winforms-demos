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
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using Syncfusion.Grouping;
using Syncfusion.Windows.Forms.Grid.Grouping;
using Syncfusion.Windows.Forms;
using System.Data.Linq;
using System.Data.SqlClient;
using LINQToSQLCE;
using Syncfusion.Windows.Forms.Grid;
using DemoCommon.Grid;
using System.Text.RegularExpressions;

#endregion

namespace LINQToSQL
{
    public partial class Form1 : GridDemoForm
    {
        #region Constructor

        public Form1()
        {
            InitializeComponent();
			if (DpiAware.GetCurrentDpi() > 96)
            {
                this.CaptionBarHeight = (int)DpiAware.LogicalToDeviceUnits(this.CaptionBarHeight);
            }
            this.gridGroupingControl1.DataSource = bindingSource1;
            this.comboBoxAdv1.DataSource = CreateTable();
            this.comboBoxAdv1.DisplayMember = "BindingType";
            this.comboBoxAdv1.ValueMember = "Id";
            this.comboBoxAdv1.SelectedIndex = 0;
            this.propertyGrid1.SelectedObject = this.gridGroupingControl1;
            this.SetStyle(ControlStyles.UserPaint, true);
        }

        private void Form1_Load(object sender, EventArgs e)
        {            
            GridIntializationSettings();
            String[] header = {"Product Id","Product Name","Supplier ID","Category ID","Quantity Per Unit","Unit Price","Units In Stock","Units On Order","Reorder Level","Discontinue"};
            for (int i=0;i<=9;i++)
                this.gridGroupingControl1.TableDescriptor.Columns[i].HeaderText = header[i];
        }
        #endregion

        #region Grid Settings
        /// <summary>
        /// Grid settings for better look and feel
        /// </summary>
        private void GridIntializationSettings()
        {
            this.gridGroupingControl1.BeginUpdate();
            this.gridGroupingControl1.TableControl.DpiAware = true;
            this.gridGroupingControl1.TableModel.Options.DefaultGridBorderStyle = GridBorderStyle.Solid;
            //Used to set the Row Height of the grid
            this.gridGroupingControl1.Table.TableOptions.RecordRowHeight = (int)DpiAware.LogicalToDeviceUnits(22.0f);
            //Used to set the Header Row Height of the grid
            this.gridGroupingControl1.Table.TableOptions.ColumnHeaderRowHeight = (int)DpiAware.LogicalToDeviceUnits(25.0f);
            //Used to set the Caption Row Height of the grid
            this.gridGroupingControl1.Table.TableOptions.CaptionRowHeight = (int)DpiAware.LogicalToDeviceUnits(22.0f);
            this.gridGroupingControl1.TableDescriptor.Appearance.AnyHeaderCell.Font.Bold = true;
            this.gridGroupingControl1.EndUpdate(true);

            //Navigate the tabkey to other control
            this.gridGroupingControl1.WantTabKey = false;

            foreach (GridColumnDescriptor col in this.gridGroupingControl1.TableDescriptor.Columns)
            {
                Regex rex = new Regex(@"\p{Lu}");
                int index = rex.Match(col.MappingName.Substring(1)).Index;
                string name = "";
                while (index > 0)
                {
                    name += col.MappingName.Substring(0, index + 1) + " ";
                    string secondName = col.MappingName.Substring(index + 1);
                    index = rex.Match(secondName.Substring(1)).Index;
                    while (index > 0)
                    {
                        name += secondName.Substring(0, index + 1) + " ";
                        index = rex.Match(col.MappingName.Substring(name.Replace(" ", "").Length).Substring(1)).Index;
                    }
                }
                name += col.MappingName.Substring(name.Replace(" ", "").Length);
                col.HeaderText = name;
            }
        }

        private void comboBoxAdv1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (this.comboBoxAdv1.SelectedIndex)
            {
                case 0:
                    //ListItemReference
                    SetDataSource("ListItemReference");
                    this.gridGroupingControl1.TableDescriptor.Appearance.AnyHeaderCell.Font.Bold = true;
                    foreach (GridTableDescriptor td in this.gridGroupingControl1.Engine.EnumerateTableDescriptor())
                    {
                        if (td.Name == "OrderDetails")
                        {
                            td.Columns["OrderID"].HeaderText = "Order ID";
                            td.Columns["ProductID"].HeaderText = "Product ID";
                            td.Columns["UnitPrice"].HeaderText = "Unit Price";
                            //td.Columns["CustomerID"].HeaderText = "Customer ID";
                            //td.Columns["EmployeeID"].HeaderText = "Employee ID";
                            //td.Columns["OrderDate"].HeaderText = "Order Date";
                            //td.Columns["RequiredDate"].HeaderText = "Required Date";
                            //td.Columns["ShippedDate"].HeaderText = "Shiped Date";
                            //td.Columns["ShipName"].HeaderText = "Ship Name";
                            //td.Columns["ShipAddress"].HeaderText = "Ship Address";
                            //td.Columns["ShipCity"].HeaderText = "Ship City";
                            //td.Columns["ShipRegion"].HeaderText = "Ship Region";
                            //td.Columns["ShipPostalCode"].HeaderText = "Ship PostalCode";
                            //td.Columns["ShipCountry"].HeaderText = "Ship Country";
                        }
                    }
                    break;
                case 1:
                    //MasterDetail/UniformChildList
                    //MasterDetail_CustomerOrders
                    SetDataSource("MasterDetail_CustomerOrders");
                    this.gridGroupingControl1.TableDescriptor.Appearance.AnyHeaderCell.Font.Bold = true;
                    foreach (GridTableDescriptor td in this.gridGroupingControl1.Engine.EnumerateTableDescriptor())
                    {
                        if (td.Name == "Customers")
                        {
                            td.Columns["CompanyName"].HeaderText = "Company Name";
                            td.Columns["ContactName"].HeaderText = "Contact Name";
                            td.Columns["CustomerID"].HeaderText = "Customer ID";
                            td.Columns["ContactTitle"].HeaderText = "Contact Title";
                        }
                        if (td.Name == "CustomerCustomerDemo")
                        {
                            td.Columns["CustomerID"].HeaderText = "Customer ID";
                            td.Columns["CustomerTypeID"].HeaderText = "Customer Type ID";
                       
                        }
                        if (td.Name == "Orders")
                        {
                            td.Columns["CustomerID"].HeaderText = "Customer ID";
                            td.Columns["EmployeeID"].HeaderText = "Employee ID";
                            td.Columns["OrderDate"].HeaderText = "Order Date";
                            td.Columns["RequiredDate"].HeaderText = "Required Date";
                            td.Columns["ShippedDate"].HeaderText = "Shiped Date";
                            td.Columns["ShipName"].HeaderText = "Ship Name";
                            td.Columns["ShipAddress"].HeaderText = "Ship Address";
                            td.Columns["ShipCity"].HeaderText = "Ship City";
                            td.Columns["ShipRegion"].HeaderText = "Ship Region";
                            td.Columns["ShipPostalCode"].HeaderText = "Ship PostalCode";
                            td.Columns["ShipCountry"].HeaderText = "Ship Country";
                        }
                        if (td.Name == "OrderDetails")
                        {
                            td.Columns["OrderID"].HeaderText = "Order ID";
                            td.Columns["ProductID"].HeaderText = "Product ID";
                            td.Columns["UnitPrice"].HeaderText = "Unit Price";
                        }

                    }

                    break;
                case 2:
                    //ManyToMany
                    SetDataSource("ManyToMany");
                    this.gridGroupingControl1.TableDescriptor.Appearance.AnyHeaderCell.Font.Bold = true;
                    foreach (GridTableDescriptor td in this.gridGroupingControl1.Engine.EnumerateTableDescriptor())
                    {
                        if (td.Name == "TerritoryRegion")
                        {
                            td.Columns["TerritoryID"].HeaderText = "Territory ID";
                            td.Columns["TerritoryDescription"].HeaderText = "Territory Description";
                            td.Columns["RegionID"].HeaderText = "Region ID";
                            td.Columns["RegionDescription"].HeaderText = "Region Description";
                        }
                    }

                    break;
            }
        }

        private static void ShowErrorMessage(SqlException ex)
        {
            if (ex.Number == 11001)
                MessageBox.Show("Host server is down or internet connection is lost.", "Error: Unable To Locate Host", MessageBoxButtons.OK, MessageBoxIcon.Error);
            if (ex.Number == 208)
                MessageBox.Show("Queried table is invalid.", "Error: Unable To Locate Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            if (ex.Number == 156 || ex.Number == 102)
                MessageBox.Show("Check query syntax and try again.", "Error: Invalid Command", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private static string FindFile(string fileName)
        {
            // Check both in parent folder and Parent\Data folders.
            string dataFileName = fileName;
            for (int n = 0; n < 12; n++)
            {
                if (System.IO.File.Exists(fileName))
                {
                    return new FileInfo(fileName).FullName;
                }
                if (System.IO.File.Exists(dataFileName))
                {
                    return new FileInfo(dataFileName).FullName;
                }
                fileName = @"..\" + fileName;
                dataFileName = @"..\" + dataFileName;
            }

            return fileName;
        }
        #endregion

        #region DataTable
        private DataTable CreateTable()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("BindingType");
            dt.Columns.Add("Id");
            dt.Rows.Add("ListItemReference", 0);
            dt.Rows.Add("MasterDetail/UniformChildList (CustomerOrders)", 1);
            dt.Rows.Add("ManyToMany (EmployeeDetails)", 2);
            return dt;
        }
        #endregion       

        #region SQL Datasource
        /// <summary>
        /// Setting the SQL datasource to the grid
        /// </summary>
        /// <param name="queryType"></param>
        private void SetDataSource(string queryType)
        {
            IQueryable query;

            try
            {

                query = SetDataSource(queryType, new LINQToSQLCE.NorthwindGrid("Data Source=" + FindFile("NorthwindGrid.sdf")));

                this.gridGroupingControl1.UseLazyUniformChildListRelation = true;
                Cursor.Current = Cursors.WaitCursor;
                this.gridGroupingControl1.SuspendLayout();
                this.gridGroupingControl1.ResetTableDescriptor();
                this.gridGroupingControl1.TableDescriptor.ResetRelations();
                gridGroupingControl1.BeginUpdate();
                bindingSource1.DataSource = query;
                this.gridGroupingControl1.TableDescriptor.EnableOneTimePopulate();
                gridGroupingControl1.EndUpdate(true);
                this.gridGroupingControl1.ResumeLayout(true);
                Cursor.Current = Cursors.Default;
            }
            catch (SqlException ex)
            {
                ShowErrorMessage(ex);
                this.Close();
            }

        }
        #endregion        

        #region Compact SQL Server file
        //If SQL Express Server not installed then go for Compact SQL Server file.
        private IQueryable SetDataSource(string queryType, LINQToSQLCE.NorthwindGrid db)
        {
            // db.Connection.ConnectionString = "Data Source=" + FindFile("NorthwindGrid.sdf");

            IQueryable query;
            switch (queryType)
            {
                case "ListItemReference":
                    query = from p in db.Products
                            orderby p.ProductName ascending
                            select p;
                    break;

                case "MasterDetail_CustomerOrders":
                    query = from cust in db.Customers
                            orderby cust.CompanyName
                            select cust;
                    break;
                case "ManyToMany":
                    query = from emp in db.Employees
                            select new EmployeeInfo
                            {
                                ID = emp.EmployeeID,
                                Name = emp.FirstName + " " + emp.LastName,
                                Title = emp.Title,
                                Address = emp.Address,
                                TerritoryRegion = (from terri in db.Territories
                                                   join empterri in db.EmployeeTerritories
                                                     on terri.TerritoryID equals empterri.TerritoryID
                                                   where empterri.EmployeeID == emp.EmployeeID
                                                   select new TerritoryRegion
                                                   {
                                                       TerritoryID = terri.TerritoryID,
                                                       TerritoryDescription = terri.TerritoryDescription,
                                                       RegionID = terri.Region.RegionID,
                                                       RegionDescription = terri.Region.RegionDescription
                                                   }).ToList()
                            };

                    break;
                default:
                    //Using Extension Methods and Lambda Expression.
                    query = db.Customers.OrderBy(cust => cust.CustomerID);
                    break;
            }

            return query;
        }
        #endregion
    }
}

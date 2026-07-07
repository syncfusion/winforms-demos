#region Copyright Syncfusion Inc. 2001 - 2015
//
//  Copyright Syncfusion Inc. 2001 - 2015. All rights reserved.
//
//  Use of this code is subject to the terms of our license.
//  A copy of the current license can be obtained at any time by e-mailing
//  licensing@syncfusion.com. Any infringement will be prosecuted under
//  applicable laws. 
//
#endregion

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Text;
using System.Windows.Forms;
using Syncfusion.Windows.Forms.Grid;
using Syncfusion.Windows.Forms.Grid.Grouping;
using Syncfusion.Grouping;
using Syncfusion.Drawing;
using System.Data.SqlClient;
using System.Data.SqlServerCe;
using System.IO;
using Syncfusion.Windows.Forms;
using DemoCommon.Grid;

namespace CellRanges
{
    public partial class Form1 : GridDemoForm
    {
        #region "API Definition "

        string Customers_ContactName = "Customers_ContactName";
        string Employees_Photo = "Employees_Photo";
        public readonly static string connString = @"Data Source=" + FindFile("NorthwindwithImage.sdf");

        #endregion

        #region "Constructor"

        public Form1()
        {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();
			if (DpiAware.GetCurrentDpi() > 96)
            {
                this.CaptionBarHeight = (int)DpiAware.LogicalToDeviceUnits(this.CaptionBarHeight);
			}

            #region "Data Source"

            String commandstring1 = "select * from Orders";
            String commandstring2 = "select * from Employees";
            String commandstring3 = "select * from Customers";

            SqlCeDataAdapter da1 = new SqlCeDataAdapter(commandstring1, connString);
            SqlCeDataAdapter da2 = new SqlCeDataAdapter(commandstring2, connString);
            SqlCeDataAdapter da3 = new SqlCeDataAdapter(commandstring3, connString);
            try
            {
                da2.Fill(dataSet11, "Employees");
                da3.Fill(dataSet11, "Customers");
                da1.Fill(dataSet11, "Orders");
            }
            catch (SqlException ex)
            {
                ShowErrorMessage(ex);
            }

            #endregion

            this.GridSettings();
            this.gridGroupingControl1.IntelliMousePanning = true;

        }

        #endregion

        #region "Sample Grid Settings"

        /// <summary>
        /// GridGrouping control getting started customization.
        /// </summary>
        private void GridSettings()
        {
            //used to set multiextended selection mode in gridgrouping control. 
            this.gridGroupingControl1.TableOptions.ListBoxSelectionMode = SelectionMode.MultiExtended;
			this.gridGroupingControl1.TableControl.DpiAware = true;

            //used to set GridCaptionRowHeight.
            this.gridGroupingControl1.Table.DefaultCaptionRowHeight = (int)DpiAware.LogicalToDeviceUnits(25.0f);
            this.gridGroupingControl1.Table.DefaultColumnHeaderRowHeight = (int)DpiAware.LogicalToDeviceUnits(30.0f);
            this.gridGroupingControl1.Table.DefaultRecordRowHeight = (int)DpiAware.LogicalToDeviceUnits(22.0f);
            this.MetroColor = System.Drawing.Color.Transparent;

            this.gridGroupingControl1.TableOptions.AllowDropDownCell = false;
            this.gridGroupingControl1.TableDescriptor.GroupedColumns.Add(Customers_ContactName);
            this.gridGroupingControl1.TableDescriptor.Columns[Customers_ContactName].HeaderText = "Employee";
            this.gridGroupingControl1.TableDescriptor.VisibleColumns.Remove(Customers_ContactName);
            this.gridGroupingControl1.TableDescriptor.Columns[Customers_ContactName].GroupByOptions.ShowGroupIndentAsCoveredRange = true;
            this.gridGroupingControl1.TableControl.PrepareViewStyleInfo += new Syncfusion.Windows.Forms.Grid.GridPrepareViewStyleInfoEventHandler(TableControl_PrepareViewStyleInfo);
            this.gridGroupingControl1.TableDescriptor.VisibleColumns.Move(gridGroupingControl1.TableDescriptor.VisibleColumns.IndexOf(Employees_Photo), 0);
            this.gridGroupingControl1.TableModel.QueryCoveredRange += new GridQueryCoveredRangeEventHandler(TableModel_QueryCoveredRange);
            this.gridGroupingControl1.TableControlCellDrawn += new GridTableControlDrawCellEventHandler(gridGroupingControl1_TableControlCellDrawn);
            this.gridGroupingControl1.GridVisualStyles = GridVisualStyles.Metro;
            this.gridGroupingControl1.TableDescriptor.Columns["OrderDate"].HeaderText = "Order_Date";
            this.gridGroupingControl1.TableDescriptor.Columns["RequiredDate"].HeaderText = "Required_Date";
            this.gridGroupingControl1.TableDescriptor.Columns["ShippedDate"].HeaderText = "Shipped_Date";
            this.gridGroupingControl1.TableDescriptor.Columns["ShipCity"].HeaderText = "Ship_City";
            this.gridGroupingControl1.TableDescriptor.Columns["ShipName"].HeaderText = "Ship_Name";
            this.gridGroupingControl1.TableDescriptor.Columns["ShipAddress"].HeaderText = "Ship_Address";
            this.gridGroupingControl1.TableDescriptor.Columns["ShipRegion"].HeaderText = "Ship_Region";
            this.gridGroupingControl1.TableDescriptor.Columns["ShipCountry"].HeaderText = "Ship_Country";
            this.gridGroupingControl1.Table.ExpandAllGroups();

            //Navigate to other control using tabkey navigation
            this.gridGroupingControl1.WantTabKey = false;
        }

        #endregion

        #region "Sample Customized"


        #region "Employees_Photo Column Covered Range"

        /// <summary>
        /// Helper routine for drawing picture in covered range of column Employees_Photo.
        /// </summary>
        void TableModel_QueryCoveredRange(object sender, GridQueryCoveredRangeEventArgs e)
        {
            GridTableModel model = (GridTableModel)sender;
            GridTable table = model.Table;

            if (e.RowIndex < table.DisplayElements.Count)
            {
                // Get the element displayed at the row
                Element el = table.DisplayElements[e.RowIndex];

                // Check if element is a record (could also be a column header or group caption ...)
                if (Element.IsRecord(el) && el.ParentGroup != null)
                {
                    GridTableCellStyleInfo style = model[e.RowIndex, e.ColIndex];
                    GridTableCellStyleInfoIdentity id = style.TableCellIdentity;
                    // The cell identity contains column information. We check if the column is Employees_Photo
                    if (id.Column != null && id.Column.MappingName == Employees_Photo)
                    {
                        Group group = el.ParentGroup;

                        // Grouped by Customers_ContactName - Do not cover cells if not grouped by Employee ...
                        if (group != null && group.CategoryColumns.Count > 0 && group.CategoryColumns[0].Name == Customers_ContactName)
                        {
                            int tablePos = table.DisplayElements.IndexOf(group);
                            int firstRow = tablePos + 1;
                            int lastRow = tablePos + group.GetVisibleCount() - 1;
                            e.Range = GridRangeInfo.Cells(firstRow, e.ColIndex, lastRow, e.ColIndex);
                            gridGroupingControl1.TableModel.CoveredRanges.Add(e.Range);
                            e.Handled = true;
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Helper routine for drawing picture in covered range of column Employees_Photo.
        /// </summary>
        void gridGroupingControl1_TableControlCellDrawn(object sender, GridTableControlDrawCellEventArgs e)
        {
            GridTableCellStyleInfo style = (GridTableCellStyleInfo)e.Inner.Style;
            GridTableCellStyleInfoIdentity id = style.TableCellIdentity;

            // Employees_Photo column
            if (id.Column != null && id.Column.MappingName == Employees_Photo)
            {
                Group group = id.DisplayElement.ParentGroup;

                // Grouped by Customers_ContactName
                if (group != null && group.CategoryColumns.Count > 0 && group.CategoryColumns[0].Name == Customers_ContactName)
                {
                    if (group.Records.Count > 0)
                    {
                        Record r = group.Records[0];

                        object value = r.GetValue(id.Column.FieldDescriptor);

                        // Should be byte[] (image stream ...)
                        byte[] byteStream = value as byte[];

                        if (byteStream != null)
                        {
                            Graphics graphics = e.Inner.Graphics;
                            Image image = GridImageUtil.ConvertToImage(byteStream);
                            Rectangle bounds = e.Inner.Bounds;
                            bounds = GridMargins.RemoveMargins(bounds, style.TextMargins.ToMargins());
                            bounds = GridMargins.RemoveMargins(bounds, style.BorderMargins.ToMargins());
                            style.ImageSizeMode = GridImageSizeMode.CenterImage;
                            GridImageUtil.DrawImage(image, bounds, graphics, bounds, style, false);
                            e.Inner.Cancel = true; // signals you did your own drawing.
                        }
                    }
                }
            }
        }

        #endregion

        #region "Rotated EmployeeName in Indent column"

        void TableControl_PrepareViewStyleInfo(object sender, Syncfusion.Windows.Forms.Grid.GridPrepareViewStyleInfoEventArgs e)
        {
            GridTableCellStyleInfo style = (GridTableCellStyleInfo)e.Style;
            GridTableCellStyleInfoIdentity id = style.TableCellIdentity;
            // Cell identity contains information about the cell (element, column etc.)

            // Check if this is a indent cell
            if (id.TableCellType == GridTableCellType.GroupIndentCell)
            {
                Group group = id.DisplayElement.ParentGroup;

                // Check if this is the indent of a Categories_CategoryName group.
                if (group != null && group.CategoryColumns.Count > 0 && group.CategoryColumns[0].Name == Customers_ContactName)
                {
                    // And if the group is not empty ...
                    if (group.Records.Count > 0)
                    {
                        // Get the category name from the first record
                        Record r = group.Records[0];
                        object value = r.GetValue(Customers_ContactName);

                        // Should be a string
                        string empName = value as string;

                        // Assign the name to the CellValue of the Indent cell and also adjust the font, color and other style settings.
                        if (empName != null)
                        {
                            style.Interior = new BrushInfo(GradientStyle.Vertical, Color.FromArgb(219, 226, 242), Color.FromArgb(255, 187, 111));
                            style.CellValue = empName;
                            style.CellType = "Static";
                            style.HorizontalAlignment = GridHorizontalAlignment.Center;
                            style.VerticalAlignment = GridVerticalAlignment.Middle;
                            style.Trimming = StringTrimming.EllipsisCharacter;
                            style.Font.Bold = true;
                            style.Font.Italic = true;
                            style.Font.Orientation = 270;
                        }
                    }
                }
            }
            if (e.Style.CellType.ToString() == "Image")
                e.Style.ImageSizeMode = GridImageSizeMode.CenterImage;
        }
        #endregion

        #endregion

        #region "Designers Stuff"

        #region "FindFile"

        /// <summary>
        /// Find the data file in specified location
        /// </summary>
        private static string FindFile(string fileName)
        {
            // Check both in parent folder and Parent\Data folders.
            string dataFileName = @"Common\Data\" + fileName;
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

        /// <summary>
        /// Display the error message
        /// </summary>
        private static void ShowErrorMessage(SqlException ex)
        {
            if (ex.Number == 11001)
                MessageBox.Show("Host server is down or internet connection is lost.", "Error: Unable To Locate Host", MessageBoxButtons.OK, MessageBoxIcon.Error);
            if (ex.Number == 208)
                MessageBox.Show("Queried table is invalid.", "Error: Unable To Locate Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            if (ex.Number == 156 || ex.Number == 102)
                MessageBox.Show("Check query syntax and try again.", "Error: Invalid Command", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        #endregion
    }
}
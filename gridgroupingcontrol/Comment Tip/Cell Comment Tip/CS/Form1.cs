#region Copyright Syncfusion Inc. 2001 - 2016
//
//  Copyright Syncfusion Inc. 2001 - 2016. All rights reserved.
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
using System.Text;
using System.Windows.Forms;
using Syncfusion.Windows.Forms;
using System.Data.SqlServerCe;
using System.Data.SqlClient;
using System.IO;
using System.Collections;
using DemoCommon.Grid;
using Syncfusion.Windows.Forms.Grid;

namespace CellCommentTip
{
    /// <summary>
    /// Summary description for Form1.
    /// </summary>
    public partial class Form1 : GridDemoForm
    {
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
            this.GridSettings();

        }

        #endregion

        #region "Sample Grid Settings"

        /// <summary>
        /// GridGrouping control getting started customization.
        /// </summary>
        private void GridSettings()
        {
            #region Data Source
            DataSet ds = new DataSet();
            String commandstring = "select * from Employees";
            String connection = @"Data Source=" + FindFile("NorthwindwithImage.sdf");
            SqlCeDataAdapter da = new SqlCeDataAdapter(commandstring, connection);
            try
            {
                da.Fill(ds, "Employees");
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            this.gridGroupingControl1.DataSource = ds.Tables["Employees"];

            // Set visible columns 
            this.gridGroupingControl1.TableDescriptor.VisibleColumns.Clear();
            this.gridGroupingControl1.TableDescriptor.VisibleColumns.Add("EmployeeID");
            this.gridGroupingControl1.TableDescriptor.VisibleColumns.Add("FirstName");
            this.gridGroupingControl1.TableDescriptor.VisibleColumns.Add("Title");
            this.gridGroupingControl1.TableDescriptor.VisibleColumns.Add("Address");
            this.gridGroupingControl1.TableDescriptor.VisibleColumns.Add("City");
            this.gridGroupingControl1.TableDescriptor.VisibleColumns.Add("PostalCode");
            this.gridGroupingControl1.TableDescriptor.VisibleColumns.Add("Country");
            this.gridGroupingControl1.TableDescriptor.Columns["EmployeeID"].HeaderText = "Employee ID";
            this.gridGroupingControl1.TableDescriptor.Columns["FirstName"].HeaderText = "Employee Name";
            this.gridGroupingControl1.TableDescriptor.Columns["PostalCode"].HeaderText = "Postal Code";
            #endregion

            this.gridGroupingControl1.TableControl.DpiAware = true;
			this.gridGroupingControl1.TableOptions.ListBoxSelectionMode = SelectionMode.One;
            this.gridGroupingControl1.GridVisualStyles = GridVisualStyles.Metro;
            this.gridGroupingControl1.Table.DefaultColumnHeaderRowHeight = (int)DpiAware.LogicalToDeviceUnits(35.0f);
            this.gridGroupingControl1.Table.DefaultRecordRowHeight = (int)DpiAware.LogicalToDeviceUnits(50.0f);
            this.gridGroupingControl1.TopLevelGroupOptions.ShowCaption = false;
            this.MetroColor = System.Drawing.Color.Transparent;
            this.gridGroupingControl1.AllowProportionalColumnSizing = true;           
        }

        #endregion

        #region "QueryCellStyleInfo Event"
        void gridGroupingControl1_QueryCellStyleInfo(object sender, Syncfusion.Windows.Forms.Grid.Grouping.GridTableCellStyleInfoEventArgs e)
        {
            if (e.Style.TableCellIdentity.Column != null && e.Style.TableCellIdentity.Column.Name == "FirstName"
                && e.TableCellIdentity.DisplayElement != null && e.TableCellIdentity.DisplayElement.Kind == Syncfusion.Grouping.DisplayElementKind.Record)
            {
                //Set the comment text, comment image and fore color.
                {
                    e.Style.CommentTip.CommentText = e.Style.Text;
                    e.Style.CommentTip.CommentImage = Image.FromFile(@"../../Images/" + e.Style.Text + ".png");
                    e.Style.CommentTip.ForeColor = Color.White;
                }
            }
        }
        #endregion

        #region "FindFile Utility"

        /// <summary>
        /// Finds a file of the given name in the current directory or sibling "Data" directory.
        /// If file is not found, the parent folder is checked until the file is found. This method
        /// is used by our samples when they load data from a separate "Data" folder.
        /// </summary>
        /// <param name="dataDirName">The name of the "Data" folder.</param>
        /// <param name="fileName">The filename to be searched.</param>
        /// <returns>The full path of the file that was found; an empty string is returned if file is not found.</returns>
        private static string FindFile(string fileName)
        {
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
    }
}
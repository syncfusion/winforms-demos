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
using System.Text;
using System.Windows.Forms;
using Syncfusion.Windows.Forms;
using System.Data.EntityClient;
using System.Data.Common;
using Syncfusion.Windows.Forms.Grid.Grouping;
using System.Linq;
using System.IO;
using System.Data.SqlClient;
using Syncfusion.Grouping;
using DemoCommon.Grid;
using Syncfusion.Windows.Forms.Grid;
using System.Text.RegularExpressions;

namespace Entity_Framework
{
    /// <summary>
    /// Summary description for Form1.
    /// </summary>
    public partial class Form1 : GridDemoForm
    {
        #region "API Definitions"

        private NorthwindGridEntities db;
        static string str = "Data Source=" + FindFile("NorthwindwithImage.sdf");
        public readonly static string conString = str;

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
            this.SampleCustomization();
            this.GridSettings();
        }
        
        #endregion

        #region "sample Customization"
        /// <summary>
        /// Illustrates binding a datasource to theGridGroupingControlthrough an Entity Data Model.
        /// </summary>
        private void SampleCustomization()
        {
            try
            {
                //Create a connection object for entity connection.
                EntityConnection con = new EntityConnection("name=NorthwindGridEntities");
                con.StoreConnection.ConnectionString = conString;
                db = new NorthwindGridEntities(con);
                this.gridGroupingControl1.DataSource = GetAllOrders().ToList<Customers>();
                this.gridGroupingControl1.TableDescriptor.Relations.Clear();
                this.gridGroupingControl1.Engine.SourceListSet.Add("Customers", GetAllCustomers().ToList<Customers>());
				this.gridGroupingControl1.TableControl.DpiAware = true;
                //Creating Relation by using Relation descriptor.
                GridRelationDescriptor relation = new GridRelationDescriptor();
                relation.Name = "Customer";
                relation.ChildTableName = "Customers";  // SourceListSet name for lookup
                relation.RelationKind = RelationKind.RelatedMasterDetails;
                relation.RelationKeys.Add("CustomerID", "CustomerID");
                //Add relation to parent table.
                this.gridGroupingControl1.TableDescriptor.Relations.Add(relation);
                this.gridGroupingControl1.Table.DefaultRecordRowHeight = (int)DpiAware.LogicalToDeviceUnits(22.0f);;
            }
            catch (SqlException)
            {
                this.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show("Error in Connection. " + err.Message);
                Application.Exit();
            }
        }

        #endregion

        #region "Sample Grid Settings"

        /// <summary>
        /// GridGrouping control getting started customization.
        /// </summary>
        private void GridSettings()
        {
            //setting propertygrid object value.
            this.propertyGrid1.SelectedObject = this.gridGroupingControl1;


            //used to set multiextended selection mode in gridgrouping control. 
            this.gridGroupingControl1.TableOptions.ListBoxSelectionMode = SelectionMode.MultiExtended;

            //used to set GridCaptionRowHeight.
            this.gridGroupingControl1.Table.DefaultCaptionRowHeight = 25;
            this.gridGroupingControl1.Table.DefaultColumnHeaderRowHeight = 30;
            this.gridGroupingControl1.Table.DefaultRecordRowHeight = 22;
            this.gridGroupingControl1.GridOfficeScrollBars = Syncfusion.Windows.Forms.OfficeScrollBars.Metro;
            this.gridGroupingControl1.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro;

            //Navigate to other control using tabkey navigation
            this.gridGroupingControl1.WantTabKey = false;

            #region HeaderText

            SetHeaderText(this.gridGroupingControl1.TableDescriptor.Columns);
            SetHeaderText(this.gridGroupingControl1.TableDescriptor.Relations[0].ChildTableDescriptor.Columns);

            #endregion
        }

        private void SetHeaderText(GridColumnDescriptorCollection columns)
        {
            foreach (GridColumnDescriptor col in columns)
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
        #endregion

        #region "DataBase"

        /// <summary>
        /// Get the customer table from NorthWind database.
        /// </summary>
        /// <returns>Customers details.</returns>
        private IQueryable<Customers> GetAllCustomers()
        {
            var customers = from c in db.Customers
                            select c;
            return customers;
        }

        /// <summary>
        /// Get the customer table from NorthWind database.
        /// </summary>
        /// <returns>Customers details.</returns>
        private IQueryable<Customers> GetAllOrders()
        {
            var order = from o in db.Customers
                        orderby o.CustomerID ascending
                        select o;
            return order;
        }

        #region Find
        /// <summary>
        /// Get the path of image file.
        /// </summary>
        /// <param name="bitmapName">ImageFile name.</param>
        /// <returns>ImageFile location.</returns>
        private static string FindFile(string fileName)
        {
            // Check both in parent folder and Parent\Data folders.
            //string dataFileName = @"Windows\Common\Data\" + fileName;
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
        /// Create a method for exit in file menuitem.
        /// </summary>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #endregion
    }  

}
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
using System.Linq;
using System.Windows.Forms;

using Syncfusion.Grouping;
using Syncfusion.Windows.Forms.Grid.Grouping;
using System.Data.SqlClient;
using System.IO;
using Syncfusion.Windows.Forms;
using System.Data;
using System.Drawing;
using Syncfusion.Windows.Forms.Grid;
using DemoCommon.Grid;
using System.Text.RegularExpressions;
#endregion

namespace LinqGroupBy
{
    public partial class Form1 : GridDemoForm
    {
        #region API Definition

        private NorthwindwithImage db;
        public readonly static string conString = "Data Source=" + FindFile("NorthwindwithImage.sdf");

        #endregion

        #region Constructor
        public Form1()
        {

            InitializeComponent();
			if (DpiAware.GetCurrentDpi() > 96)
            {
                this.CaptionBarHeight = (int)DpiAware.LogicalToDeviceUnits(this.CaptionBarHeight);
            }
            GridIntializationSettings();
            this.comboBoxAdv1.SelectedIndex = 0;
            this.comboBoxAdv1.SelectedIndexChanged += new EventHandler(comboBoxAdv1_SelectedIndexChanged);
            this.propertyGrid1.SelectedObject = this.gridGroupingControl1;
        }
        protected override void OnLoad(EventArgs e)
        {
            try
            {
                db = new NorthwindwithImage(conString);

                SampleQuery sq = new LinqGroupBy.CustomerQuery();
                sq.InitializeGrid(gridGroupingControl1, db);

                base.OnLoad(e);
            }
            catch (SqlException ex)
            {
                ShowErrorMessage(ex);
                this.Close();
            }
        }
        #endregion

        #region Grid Settings
        /// <summary>
        /// Grid Setting sfor better look and feel
        /// </summary>     
        private void GridIntializationSettings()
        {
			this.gridGroupingControl1.TableControl.DpiAware = true;
            this.gridGroupingControl1.BeginUpdate();
            this.gridGroupingControl1.TableModel.Options.DefaultGridBorderStyle = GridBorderStyle.Solid;
            this.gridGroupingControl1.Table.TableOptions.RecordRowHeight = (int)DpiAware.LogicalToDeviceUnits(22.0f);
            this.gridGroupingControl1.Table.TableOptions.ColumnHeaderRowHeight = (int)DpiAware.LogicalToDeviceUnits(22.0f);
            this.gridGroupingControl1.Table.TableOptions.CaptionRowHeight = (int)DpiAware.LogicalToDeviceUnits(22.0f);
            this.gridGroupingControl1.EndUpdate(true);

            //Navigate the tab key to move the next control
            this.gridGroupingControl1.WantTabKey = false;
         //   this.gridGroupingControl1.TableDescriptor.Columns["CompanyName"].HeaderText = "Company Name";
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

        #region Reset Grid
        //Used for resetting grid
        private void ResetGrid(SampleQuery sq)
        { //setting GridGroupiungControl data source as null
            gridGroupingControl1.DataSource = null;
            ////Reinitializeing the GridGroupingControl
            sq.InitializeGrid(gridGroupingControl1, db);
            this.gridGroupingControl1.GridVisualStyles = GridVisualStyles.Metro;
        }
        #endregion

        #region Events

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DemoCommon.AboutForm abtform = new DemoCommon.AboutForm(AppDomain.CurrentDomain.GetAssemblies());
            abtform.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        void comboBoxAdv1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (this.comboBoxAdv1.SelectedIndex)
            {
                case 0: ResetGrid(new CustomerQuery());
                    break;
                case 1: ResetGrid(new CustomerOrders());
                    break;
                case 2: ResetGrid(new CustomerOrdersDetails());
                    break;
                case 3: ResetGrid(new CustomerOrdersGroupedByShippers());
                    break;
                case 4: ResetGrid(new ProductsGroupedBySupplier());
                    break;
                case 5: ResetGrid(new ProductsGroupedBySupplierAndCategory());
                    break;
            }
        }

        #endregion                       

        #region Exception Handling for SQL
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

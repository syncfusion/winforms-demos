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

# region Directives
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Syncfusion.Windows.Forms.Grid;
using Syncfusion.Windows.Forms.Grid.Grouping;
using Syncfusion.Grouping;
using Syncfusion.Windows.Forms;
using DemoCommon.Grid;
#endregion

namespace FindReplace
{
    /// <summary>
    /// Summary description for Form1.
    /// </summary>
    public partial class Form1 : GridDemoForm
    {
        #region Constructor

        /// <summary>
        ///  Form Constructor.
        /// </summary>
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
            GridSettings();
        }

        #endregion
        
        #region GridSetings
        /// <summary>
        /// Required Grid Settings method
        /// </summary>
        void GridSettings()
        {
            this.gridGroupingControl1.DataSource = GetADataTable();
            this.gridGroupingControl1.AllowProportionalColumnSizing = true;
			this.gridGroupingControl1.TableControl.DpiAware = true;
            this.gridGroupingControl1.TableOptions.ListBoxSelectionMode = SelectionMode.MultiExtended;
        }
        #endregion

        #region Sample Customization

        #region EventHandlers

        // Displays the Find and Replace Dialog box.
        void gridGroupingControl1_TableControlCurrentCellKeyDown(object sender, GridTableControlKeyEventArgs e)
        {

            if (e.Inner.Control)
            {
                if (e.Inner.KeyCode == Keys.F || e.Inner.KeyCode == Keys.H)
                {
                    GridFindReplaceDialog f = new GridFindReplaceDialog(this.gridGroupingControl1, "Metro");
                    f.ShowDialog();
                }
            }
        }
        #endregion

        #region DataTable

        // Gets the Data Source
        private DataTable GetADataTable()
        {

            DataTable dt = new DataTable("MyTable");

            int nCols = 20;
            int nRows = 25;

            for (int i = 0; i < nCols; i++)
                dt.Columns.Add(new DataColumn(string.Format("Col{0}", i)));

            Random rand = new Random();

            for (int i = 0; i < nRows; ++i)
            {
                DataRow dr = dt.NewRow();
                for (int j = 0; j < nCols; j++)
                    dr[j] = rand.Next(100);
                dt.Rows.Add(dr);
            }
            return dt;
        }
        #endregion

        #endregion

    }
}
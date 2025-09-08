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

using DemoCommon.Grid;
using Syncfusion.Windows.Forms;
using Syncfusion.Windows.Forms.Grid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CellCommentTip
{
    public partial class Form1 : GridDemoForm
    {
        #region Private Variables
        DataTable dataTable;
        Random random = new Random();
        #endregion

        #region Constructor
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

        #region Sample Grid Settings
        /// <summary>
        /// Setting the appearance of the GridControl.
        /// </summary>
        private void GridSettings()
        {
            this.LoadData();
            this.gridControl1.RowCount = dataTable.Rows.Count - 1;
            this.gridControl1.ColCount = dataTable.Columns.Count - 1;
            this.gridControl1.ColWidths[0] = (int)DpiAware.LogicalToDeviceUnits(100.0f); ;
            this.gridControl1.DefaultRowHeight = (int)DpiAware.LogicalToDeviceUnits(35.0f);
            this.gridControl1.DefaultColWidth = (int)DpiAware.LogicalToDeviceUnits(100.0f);
            this.gridControl1.QueryCellInfo += gridControl1_QueryCellInfo;    
        }
        #endregion

        #region QueryCellInfo Event

        void gridControl1_QueryCellInfo(object sender, GridQueryCellInfoEventArgs e)
        {
            e.Style.Font.Facename = "Segoe UI";
            e.Style.Font.Size = 10f;

            if (e.RowIndex == 0 && e.ColIndex > 0)
                e.Style.CellValue = dataTable.Columns[e.ColIndex].ColumnName;

            else if (e.RowIndex > 0 && e.ColIndex >= 0)
            {
                e.Style.CellValue = dataTable.Rows[e.RowIndex][e.ColIndex];

                if (e.ColIndex > 0)
                {
                    string comment = " " + dataTable.Rows[e.RowIndex][0].ToString() + ": \n Population rate in " + dataTable.Columns[e.ColIndex] + " is " + e.Style.CellValue.ToString();
                    e.Style.CommentTip.CommentText = comment;
                    e.Style.CommentTip.CommentWindowSize = new Size(100, 50);

                    if (e.ColIndex % 2 == 0)
                        e.Style.CommentTip.CommentIndicatorColor = Color.Green;
                }
            }

            if (e.ColIndex == 0 && e.RowIndex == 0)
            {
                e.Style.CellValue = dataTable.Columns[0].ColumnName;
            }
        }
        #endregion

        #region DataSource
        public void LoadData()
        {
            dataTable = new DataTable();
            dataTable.Columns.Add(new DataColumn("Country"));
            dataTable.Columns.Add(new DataColumn("2005"));
            dataTable.Columns.Add(new DataColumn("2006"));
            dataTable.Columns.Add(new DataColumn("2007"));
            dataTable.Columns.Add(new DataColumn("2008"));
            dataTable.Columns.Add(new DataColumn("2009"));
            dataTable.Columns.Add(new DataColumn("2010"));
            dataTable.Columns.Add(new DataColumn("2011"));
            random = new Random();

            DataRow row = dataTable.NewRow();
            row["Country"] = "USA";
            LoadCellValues(row);
            dataTable.Rows.Add(row);

            row = dataTable.NewRow();
            row["Country"] = "India";
            LoadCellValues(row);
            dataTable.Rows.Add(row);

            row = dataTable.NewRow();
            row["Country"] = "China";
            LoadCellValues(row);
            dataTable.Rows.Add(row);

            row = dataTable.NewRow();
            row["Country"] = "Japan";
            LoadCellValues(row);
            dataTable.Rows.Add(row);

            row = dataTable.NewRow();
            row["Country"] = "Russia";
            LoadCellValues(row);
            dataTable.Rows.Add(row);

            row = dataTable.NewRow();
            row["Country"] = "Canada";
            LoadCellValues(row);
            dataTable.Rows.Add(row);

            row = dataTable.NewRow();
            row["Country"] = "Germany";
            LoadCellValues(row);
            dataTable.Rows.Add(row);

            row = dataTable.NewRow();
            row["Country"] = "Iran";
            LoadCellValues(row);
            dataTable.Rows.Add(row);

            row = dataTable.NewRow();
            row["Country"] = "Thailand";
            LoadCellValues(row);
            dataTable.Rows.Add(row);

            row = dataTable.NewRow();
            row["Country"] = "Bangladesh";
            LoadCellValues(row);
            dataTable.Rows.Add(row);

            row = dataTable.NewRow();
            row["Country"] = "Nigeria";
            LoadCellValues(row);
            dataTable.Rows.Add(row);

            row = dataTable.NewRow();
            row["Country"] = "Mexico";
            LoadCellValues(row);
            dataTable.Rows.Add(row);

            row = dataTable.NewRow();
            row["Country"] = "Egypt";
            LoadCellValues(row);
            dataTable.Rows.Add(row);

            row = dataTable.NewRow();
            row["Country"] = "France";
            LoadCellValues(row);
            dataTable.Rows.Add(row);
        }

        public void LoadCellValues(DataRow dataRow)
        {
            for (int row = 1; row <= 7; row++)
            {
                dataRow[row] = ((double)random.Next(2, 18)).ToString() + "%";
            }
        }

        #endregion
    }
}

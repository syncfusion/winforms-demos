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
using System.Collections;
using System.Collections.Specialized;
using System.IO;
using System.Data.SqlServerCe;
using System.Data.SqlClient;
using Syncfusion.Windows.Forms.Grid;
using MarkHeaderDemo;
using DemoCommon.Grid;

namespace MarkHeaderDemo
{
    public partial class Form1 : GridDemoForm
    {
        #region Constructor
        public Form1()
        {
            
            Random r = new Random();
            InitializeComponent();
            if (DpiAware.GetCurrentDpi() > 96)
            {
                this.CaptionBarHeight = (int)DpiAware.LogicalToDeviceUnits(this.CaptionBarHeight);
            }
            this.GridSettings();
            this.SampleCustomization();
        }
        #endregion

        #region "Sample Grid Settings"

        /// <summary>
        /// Setting Grid control Properties
        /// </summary>
        private void GridSettings()
        {
            String commandstring1 = "select * from Customers";
            DataSet1 ds = new DataSet1();
            this.gridControl1.ColCount = 10;
            SqlCeDataAdapter da1 = new SqlCeDataAdapter(commandstring1, connString);
            try
            {
                da1.Fill(ds, "Customers");
            }
            catch (SqlException ex)
            {
                ShowErrorMessage(ex);
            }
            for (int i = 1; i <= this.gridControl1.RowCount; ++i)
            {
                for (int j = 1; j <= this.gridControl1.ColCount; ++j)
                {
                    this.gridControl1[i, j].CellValue = ds.Tables["Customers"].Rows[i][j - 1].ToString();
                }
            }
            for (int j = 1; j <= this.gridControl1.ColCount; ++j)
            {
                this.gridControl1[0, j].Text = ds.Tables["Customers"].Columns[j - 1].Caption;
            }
            this.gridControl1.Model.ColWidths.ResizeToFitOptimized(GridRangeInfo.Table(), GridResizeToFitOptions.NoShrinkSize);
            this.gridControl1.Refresh();
            GridMetroColors colors = new GridMetroColors();
            colors.HeaderColor.PressedColor = Color.LightGray;
            this.gridControl1.SetMetroStyle(colors);
            this.gridControl1.DefaultRowHeight = (int)DpiAware.LogicalToDeviceUnits(22.0f);

            //tab key navigation set as false to move the next control
            this.gridControl1.WantTabKey = false;
        }

        #endregion

        #region "Sample Customizations"

        /// <summary>
        /// MarkHeader sample Customizations 
        /// </summary>
        private void SampleCustomization()
        {
            this.comboBox1.Text = "Both";
            this.gridControl1.MarkColHeader = true;
            this.gridControl1.MarkRowHeader = true;
            this.comboBox2.Text = "Metro";
            this.comboBox1.SelectedIndexChanged += new EventHandler(comboBox1_SelectedIndexChanged);
            this.comboBox2.SelectedIndexChanged += new EventHandler(comboBox2_SelectedIndexChanged);
        }

        #region Event Handlers
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox2.Text)
            {
                case "Metro":
                    this.gridControl1.GridVisualStyles = GridVisualStyles.Metro;
                    break;
                case "Office2010Blue":
                    this.gridControl1.GridVisualStyles = GridVisualStyles.Office2010Blue;
                    this.gridControl1.GridOfficeScrollBars = OfficeScrollBars.Office2010;
                    this.gridControl1.Office2010ScrollBarsColorScheme = Office2010ColorScheme.Blue;
                    break;
                case "Office2010Black":
                    this.gridControl1.GridVisualStyles = GridVisualStyles.Office2010Black;
                    this.gridControl1.GridOfficeScrollBars = OfficeScrollBars.Office2010;
                    this.gridControl1.Office2010ScrollBarsColorScheme = Office2010ColorScheme.Black;
                    break;
                case "Office2010Silver":
                    this.gridControl1.GridVisualStyles = GridVisualStyles.Office2010Silver;
                    this.gridControl1.GridOfficeScrollBars = OfficeScrollBars.Office2010;
                    this.gridControl1.Office2010ScrollBarsColorScheme = Office2010ColorScheme.Silver;
                    break;
            }
        }

        #region ComboBox SelectedItemChanged
        
        /// <summary>
        /// Used to set the marker for row and col header
        /// </summary>
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.Text)
            {
                case "Both":
                    this.gridControl1.MarkColHeader = true;
                    this.gridControl1.MarkRowHeader = true;
                    break;
                case "Row Header":
                    this.gridControl1.MarkColHeader = false;
                    this.gridControl1.MarkRowHeader = true;
                    break;
                case "Column Header":
                    this.gridControl1.MarkColHeader = true;
                    this.gridControl1.MarkRowHeader = false;
                    break;
            }

        }
        #endregion

        #endregion

        #endregion

        #region "DataSource"
        public readonly static string connString = @"Data Source=" + FindFile("NorthwindwithImage.sdf");

        #region FindFile
        /// <summary>
        /// Find the file to set the Datasource
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

        #region ShowErrorMessage
        /// <summary>
        /// Display Error Message when Finding the database. 
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

        #endregion
    }
}

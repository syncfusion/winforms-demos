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
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Syncfusion.Windows.Forms;
using System.Collections;
using System.Collections.Specialized;
using DemoCommon.Grid;
using Syncfusion.Windows.Forms.Grid;

namespace SkinManagerDemo
{
    /// <summary>
    /// Summary description for Form1.
    /// </summary>
    public partial class Form1 : GridDemoForm
    {
        #region "Constructor"

        public Form1()
        {
            Random r = new Random();
            //
            // Required for Windows Form Designer support
            //           
            InitializeComponent();
            if (DpiAware.GetCurrentDpi() > 96)
            {
                this.CaptionBarHeight = (int)DpiAware.LogicalToDeviceUnits(this.CaptionBarHeight);
            }
            this.Load += Form1_Load;
            #region DataSource
            //
            // Creating DataSource 
            //   
            #region DataTable

            DataTable dt = new DataTable();
            dt.Columns.Add("EmployeeName", Type.GetType("System.String"));
            dt.Columns.Add("OrderID", Type.GetType("System.Int32"));
            dt.Columns.Add("Amount", Type.GetType("System.Decimal"));
            dt.Columns.Add("Cost", Type.GetType("System.Decimal"));
            dt.Columns.Add("Date", Type.GetType("System.String"));
            dt.Rows.Add(new object[] { "Sam", 1, 25.00, 13.00, "01/10/2007" });
            dt.Rows.Add(new object[] { "Sam", 2, 512.00, 1.00, "02/10/2007" });
            dt.Rows.Add(new object[] { "Sam", 3, 512.00, 1.00, "03/10/2007" });
            dt.Rows.Add(new object[] { "Tom", 4, 50.00, 1.00, "04/10/2007" });
            dt.Rows.Add(new object[] { "Tom", 5, 3.00, 7.00, "03/10/2007" });
            dt.Rows.Add(new object[] { "Tom", 6, 78.75, 12.00, "02/10/2007" });
            dt.Rows.Add(new object[] { "Sue", 7, 11.00, 7.00, "01/10/2007" });
            dt.Rows.Add(new object[] { "Sue", 8, 2.50, 66.20, "02/10/2007" });
            dt.Rows.Add(new object[] { "Sue", 9, 2.50, 22.00, "03/10/2007" });
            dt.Rows.Add(new object[] { "Jack", 10, 6.00, 23.00, "02/10/2007" });
            dt.Rows.Add(new object[] { "Jack", 11, 117.00, 199.00, "04/10/2007" });
            dt.Rows.Add(new object[] { "Jack", 12, 13.00, 2.60, "01/10/2007" });
            dt.Rows.Add(new object[] { "Jack", 13, 11.40, 99.80, "03/10/2007" });
            dt.Rows.Add(new object[] { "Phill", 14, 37.00, 2.10, "02/10/2007" });
            dt.Rows.Add(new object[] { "Phill", 15, 65.20, 99.30, "04/10/2007" });
            dt.Rows.Add(new object[] { "Phill", 16, 34.10, 27.00, "02/10/2007" });
            dt.Rows.Add(new object[] { "Phill", 17, 17.00, 959.00, "04/10/2007" });
            #endregion

            #region GridListControl
            this.gridListControl1.DataSource = dt;
            this.gridListControl1.DisplayMember = "EmployeeName";
            this.gridListControl1.ValueMember = "EmployeeName";
            this.gridListControl1.MultiColumn = true;
            this.gridListControl1.ShowColumnHeader = true;

            #endregion

            #region GridControl
            for (int i = 1; i <= this.gridControl1.RowCount; ++i)
            {
                for (int j = 1; j <= this.gridControl1.ColCount; ++j)
                {
                    this.gridControl1[i, j].CellValue = r.Next(1000);
                }
            }
            this.gridControl1.Refresh();

            #endregion



            #endregion

            this.GridSettings();

            #region InitialSettings
            this.comboBox1.Text = "Parent Container";
            this.comboBox2.Text = "Office2010Blue";
            try
            {
                SkinManager.SetVisualStyle(this, comboBox2.Text);
            }
            catch { }

            #endregion
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.gridListControl1.Grid.ColWidths.ResizeToFitOptimized(GridRangeInfo.Table(), GridResizeToFitOptions.IncludeHeaders);
        }

        #endregion

        #region "Grid Settings"

        /// <summary>
        /// Grid Settings for better look and feel
        /// </summary>
        private void GridSettings()
        {
            
            //Used to set default row height
            this.gridControl1.DefaultRowHeight = 22;
            //Used to set selection mode in grid

            this.gridControl1.Model.Options.DisplayEmptyColumns = true;
            this.gridControl1.Model.Options.DisplayEmptyRows = true;
        }

        #endregion

        #region USState Class

        public class USState
        {

        #region "API Definition"

            private string myShortName;
            private string myLongName;
            private int _imageIndex;

            #endregion

        #region "Constructor"
            /// <summary>
            /// Constructor for USState class
            /// </summary>
            
            public USState(string strLongName, string strShortName, int _imageIndex)
            {
                this.myShortName = strShortName;
                this.myLongName = strLongName;
                this._imageIndex = _imageIndex;
            }

            #region "Properties"

            public string ShortName
            {
                get { return myShortName; }
            }

            public string LongName
            {
                get { return myLongName; }
            }

            public int ImageIndex
            {
                get { return _imageIndex; }
                set { _imageIndex = value; }
            }

            public override string ToString()
            {
                return this.ShortName + " - " + this.LongName;
            }

            #endregion
        }
            #endregion

        #region "Event Hanlders"

        Control ctrl = null;

        // Setting the styles to the grid using the ComboBox selection
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Parent Container")
                ctrl = this.parent;
            else if (comboBox1.Text == "GridControl")
                ctrl = this.grid;
            else if (comboBox1.Text == "GridListControl")
                ctrl = this.gridList;
            else
                ctrl = this;
            try
            {
                SkinManager.SetVisualStyle(ctrl, comboBox2.Text);
            }
            catch { }
        }

        //Setting the styles to the grid using the ComboBox selection
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "ParentContainer")
                ctrl = this.parent;
            else if (comboBox1.Text == "GridControl")
                ctrl = this.grid;
            else if (comboBox1.Text == "GridListControl")
                ctrl = this.gridList;
            else
                ctrl = this;
            try
            {
                SkinManager.SetVisualStyle(ctrl, comboBox2.Text);
            }
            catch { }
        }

        #endregion

        #endregion
    }
}

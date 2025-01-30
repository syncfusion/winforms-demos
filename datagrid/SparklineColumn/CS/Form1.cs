#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using SparklineColumn;
using SparklineColumn;
using Syncfusion.Windows.Forms.Chart;
using Syncfusion.WinForms.DataGrid;
using System;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace SparklineColumn
{
    public partial class Form1 : Form
    {
        #region Constructor
        /// <summary>
        /// Initializes a new instance for Form1.
        /// </summary>
        public Form1()
        {
            InitializeComponent();

            this.sfDataGrid1.AutoGenerateColumns = false;
            sfDataGrid1.DataSource = GetDataTable();
            this.sfDataGrid1.CellRenderers.Add("Sparkline", new GridSparklineCellRenderer(new Syncfusion.Windows.Forms.Chart.SparkLine(), this.sfDataGrid1));

            NumberFormatInfo numberFormat = Application.CurrentCulture.NumberFormat.Clone() as NumberFormatInfo;
            numberFormat.CurrencyDecimalDigits = 0;
            numberFormat.CurrencyGroupSizes = new int[] { };
            numberFormat = Application.CurrentCulture.NumberFormat.Clone() as NumberFormatInfo;
            numberFormat.NumberDecimalDigits = 0;
            numberFormat.NumberGroupSizes = new int[] { };

            this.sfDataGrid1.Columns.Add(new GridTextColumn { AllowEditing = true, MappingName = "Geography", HeaderText = "Geography" });
            this.sfDataGrid1.Columns.Add(new GridNumericColumn { AllowEditing = true, MappingName = "Value", HeaderText = "Value", NumberFormatInfo = numberFormat });
            this.sfDataGrid1.Columns.Add(new GridNumericColumn { AllowEditing = true, MappingName = "Tons", HeaderText = "Tons", NumberFormatInfo = numberFormat });
            this.sfDataGrid1.Columns.Add(new GridNumericColumn { AllowEditing = true, MappingName = "Ton-miles", HeaderText = "Ton-miles", NumberFormatInfo = numberFormat });
            this.sfDataGrid1.Columns.Add(new GridNumericColumn { AllowEditing = true, MappingName = "Average miles", HeaderText = "Average miles", NumberFormatInfo = numberFormat });
            this.sfDataGrid1.Columns.Add(new GridSparklineColumn() { MappingName = "Sparkline", HeaderText = "Analysis Report", Width = 150, AllowFiltering = false });

            StackedHeaderRow stackedHeaderRow1 = new StackedHeaderRow();
            stackedHeaderRow1.StackedColumns.Add(new StackedColumn() { ChildColumns = "Geography,Value,Tons,Ton-miles,Average miles,Sparkline", HeaderText = "WHOLESALE TRADE" });
            this.sfDataGrid1.StackedHeaderRows.Add(stackedHeaderRow1);

            //Initialize CustomSelectionController.
            this.sfDataGrid1.SelectionController = new CustomSelectionController(this.sfDataGrid1);
        }
                
        public DataTable GetDataTable()
        {
            DataTable employeeCollection = new DataTable();

            employeeCollection.Columns.Add("Geography", typeof(string));
            employeeCollection.Columns[0].ColumnName = "Geography";
            employeeCollection.Columns.Add("Value", typeof(int));
            employeeCollection.Columns["Value"].ColumnName = "Value";
            employeeCollection.Columns.Add("Tons", typeof(int));
            employeeCollection.Columns["Tons"].ColumnName = "Tons";
            employeeCollection.Columns.Add("Ton-miles", typeof(int));
            employeeCollection.Columns["Ton-miles"].ColumnName = "Ton-miles";
            employeeCollection.Columns.Add("Average miles", typeof(int));
            employeeCollection.Columns["Average miles"].ColumnName = "Average miles";
            employeeCollection.Columns.Add("Sparkline", typeof(double[]));
            employeeCollection.Columns["Sparkline"].ColumnName = "Sparkline";

            Random r = new Random(1);

            employeeCollection.Rows.Add("United States", 216817, 7305, 6398, 1169, new double[] { r.Next(1, 7), r.Next(-12, -6), r.Next(1, 12), r.Next(-25, -5), r.Next(7, 13), r.Next(-10, -7) });
            employeeCollection.Rows.Add("Alabama", 2077, 109, 92, 864, new double[] { r.Next(15, 20), r.Next(-13, -1), r.Next(1, 6), r.Next(-12, -10), r.Next(6, 10), r.Next(-20, -10) });
            employeeCollection.Rows.Add("Alaska", 45, -2334, 123, 1224, new double[] { r.Next(7, 9), r.Next(-13, -1), r.Next(10, 26), r.Next(-18, -16), r.Next(1, 4), r.Next(-2, -1) });
            employeeCollection.Rows.Add("Arizona", 88, 34, 52, 1616, new double[] { r.Next(9, 11), r.Next(-5, -1), r.Next(2, 5), r.Next(-2, -1), r.Next(5, 10), r.Next(-17, -10) });
            employeeCollection.Rows.Add("Arkansas", 12, 455, 33, 1234, new double[] { r.Next(10, 20), r.Next(-20, -10), r.Next(10, 25), r.Next(-20, -10), r.Next(10, 20), r.Next(-20, -10) });
            employeeCollection.Rows.Add("California", 26205, 1142, -1239, 1759, new double[] { r.Next(1, 4), r.Next(-5, -1), r.Next(10, 25), r.Next(-22, -10), r.Next(7, 10), r.Next(-8, -1) });
            employeeCollection.Rows.Add("Colorado", 1978, -56, 78, 1298, new double[] { r.Next(15, 20), r.Next(-13, -1), r.Next(1, 6), r.Next(-12, -10), r.Next(6, 10), r.Next(-20, -10) });
            employeeCollection.Rows.Add("Connecticut", 2639, -67, 45, 1150, new double[] { r.Next(10, 20), r.Next(-10, -1), r.Next(6, 25), r.Next(-18, -8), r.Next(10, 12), r.Next(-12, -10) });
            employeeCollection.Rows.Add("Delaware", 33, 222, 1666, 2343, new double[] { r.Next(1, 7), r.Next(-12, -6), r.Next(1, 12), r.Next(-25, -5), r.Next(7, 13), r.Next(-10, -7) });
            employeeCollection.Rows.Add("District of Columbia", -44, 344, 211, 1125, new double[] { r.Next(10, 20), r.Next(-20, -10), r.Next(10, 25), r.Next(-20, -10), r.Next(10, 20), r.Next(-20, -10) });
            employeeCollection.Rows.Add("Florida", 13983, 87, 102, 1261, new double[] { r.Next(7, 9), r.Next(-13, -1), r.Next(10, 26), r.Next(-18, -16), r.Next(1, 4), r.Next(-2, -1) });
            employeeCollection.Rows.Add("Georgia", 4273, 439, 257, 953, new double[] { r.Next(10, 20), r.Next(-10, -1), r.Next(6, 25), r.Next(-18, -8), r.Next(10, 12), r.Next(-12, -10) });
            employeeCollection.Rows.Add("United States", -4740065, 3605531, 767100, -430, new double[] { r.Next(15, 20), r.Next(-13, -1), r.Next(1, 6), r.Next(-12, -10), r.Next(6, 10), r.Next(-20, -10) });
            employeeCollection.Rows.Add("Alabama", 56928, 85990, 7274, 209, new double[] { r.Next(1, 4), r.Next(-5, -1), r.Next(10, 25), r.Next(-22, -10), r.Next(7, 10), r.Next(-8, -1) });
            employeeCollection.Rows.Add("Alaska", 6980, 8117, -1662, 165, new double[] { r.Next(9, 11), r.Next(-5, -1), r.Next(2, 5), r.Next(-2, -1), r.Next(5, 10), r.Next(-17, -10) });
            employeeCollection.Rows.Add("Arizona", -186188, 137209, -23287, 11322, new double[] { r.Next(10, 20), r.Next(-10, -1), r.Next(6, 25), r.Next(-18, -8), r.Next(10, 12), r.Next(-12, -10) });
            employeeCollection.Rows.Add("Arkansas", 64891, 35286, 4716, 424, new double[] { r.Next(1, 4), r.Next(-5, -1), r.Next(10, 25), r.Next(-22, -10), r.Next(7, 10), r.Next(-8, -1) });
            employeeCollection.Rows.Add("California", 32849, -35842, 8219, -284, new double[] { r.Next(7, 9), r.Next(-13, -1), r.Next(10, 26), r.Next(-18, -16), r.Next(1, 4), r.Next(-2, -1) });
            employeeCollection.Rows.Add("Colorado", 712428, 333121, -75089, 838, new double[] { r.Next(9, 11), r.Next(-5, -1), r.Next(2, 5), r.Next(-2, -1), r.Next(5, 10), r.Next(-17, -10) });
            employeeCollection.Rows.Add("Connecticut", 66463, -36268, 9612, 354, new double[] { r.Next(15, 20), r.Next(-13, -1), r.Next(1, 6), r.Next(-12, -10), r.Next(6, 10), r.Next(-20, -10) });
            employeeCollection.Rows.Add("Delaware", -64026, 39098, 6466, 317, new double[] { r.Next(1, 7), r.Next(-12, -6), r.Next(1, 12), r.Next(-25, -5), r.Next(7, 13), r.Next(-10, -7) });
            employeeCollection.Rows.Add("District of Columbia", 6911, 8261, 812, 166, new double[] { r.Next(9, 11), r.Next(-5, -1), r.Next(2, 5), r.Next(-2, -1), r.Next(5, 10), r.Next(-17, -10) });
            employeeCollection.Rows.Add("Florida", 2290, -1000, 27, 40, new double[] { r.Next(1, 4), r.Next(-5, -1), r.Next(10, 25), r.Next(-22, -10), r.Next(7, 10), r.Next(-8, -1) });
            employeeCollection.Rows.Add("Georgia", -241776, 190134, 30778, 302, new double[] { r.Next(7, 9), r.Next(-13, -1), r.Next(10, 26), r.Next(-18, -16), r.Next(1, 4), r.Next(-2, -1) });

            return employeeCollection;
        }        

        #endregion            
    }
}

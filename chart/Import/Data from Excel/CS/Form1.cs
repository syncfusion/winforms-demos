#region Copyright Syncfusion Inc. 2001 - 2005
//
//  Copyright Syncfusion Inc. 2001 - 2005. All rights reserved.
//
//  Use of this code is subject to the terms of our license.
//  A copy of the current license can be obtained at any time by e-mailing
//  licensing@syncfusion.com. Any infringement will be prosecuted under
//  applicable laws. 
//
#endregion

using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Xml;
using System.Data.OleDb;

using Syncfusion.Windows.Forms;
using Syncfusion.Drawing;
using Syncfusion.Windows.Forms.Chart;

namespace ChartImportData
{
	public class Form1 : Syncfusion.Windows.Forms.MetroForm
    {
        #region Private Members
        private Syncfusion.Windows.Forms.Chart.ChartControl chartControl1;
		private DateTime lastTime = DateTime.Now;
		private string tableName = "Products";
        private ChartDataBindModel model;
		private System.ComponentModel.Container components = null;
        #endregion

        #region Form's Constructor, Main And Dispose
        public Form1()
		{
            BorderColor = Color.FromArgb(0xFF, 0xCD, 0xCD, 0xCD);
            BorderThickness = 3;
            CaptionBarHeight = (int)DpiAware.LogicalToDeviceUnits(75.0f);
            CaptionBarColor = Color.FromArgb(0xFF, 0x1B, 0xA1, 0xE2);
            CaptionFont = new Font("Segoe UI", 22.0f);
            CaptionForeColor = Color.White;
            CaptionAlign = HorizontalAlignment.Left;
            ShowIcon = false;
            CaptionButtonColor = Color.White;
            CaptionButtonHoverColor = Color.White;
			InitializeComponent();
        }
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense(DemoCommon.FindLicenseKey());
            Application.Run(new Form1());
        }
		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
        }
        #endregion

        #region Windows Form Designer generated code
        /// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.chartControl1 = new Syncfusion.Windows.Forms.Chart.ChartControl();
            this.SuspendLayout();
            // 
            // chartControl1
            // 
            this.chartControl1.BackInterior = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.White, System.Drawing.Color.White);
            this.chartControl1.BorderAppearance.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(113)))), ((int)(((byte)(173)))));
            this.chartControl1.BorderAppearance.SkinStyle = Syncfusion.Windows.Forms.Chart.ChartBorderSkinStyle.Pinned;
            this.chartControl1.ChartArea.CursorLocation = new System.Drawing.Point(0, 0);
            this.chartControl1.ChartArea.CursorReDraw = false;
            this.chartControl1.ChartArea.XAxesLayoutMode = Syncfusion.Windows.Forms.Chart.ChartAxesLayoutMode.SideBySide;
            this.chartControl1.ChartArea.YAxesLayoutMode = Syncfusion.Windows.Forms.Chart.ChartAxesLayoutMode.SideBySide;
            this.chartControl1.ChartAreaMargins = new Syncfusion.Windows.Forms.Chart.ChartMargins(5, 10, 5, 10);
            this.chartControl1.ChartInterior = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(209)))), ((int)(((byte)(226))))), System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(232)))), ((int)(((byte)(243))))));
            this.chartControl1.DataSourceName = "";
            this.chartControl1.IsWindowLess = false;
            // 
            // 
            // 
            this.chartControl1.Legend.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.chartControl1.Legend.Location = new System.Drawing.Point(88, 453);
            this.chartControl1.Legend.Orientation = Syncfusion.Windows.Forms.Chart.ChartOrientation.Horizontal;
            this.chartControl1.Legend.Position = Syncfusion.Windows.Forms.Chart.ChartDock.Bottom;
            this.chartControl1.Localize = null;
            this.chartControl1.Location = new System.Drawing.Point(7, 7);
            this.chartControl1.Name = "chartControl1";
            this.chartControl1.PrimaryXAxis.Crossing = double.NaN;
            this.chartControl1.PrimaryXAxis.Margin = true;
            this.chartControl1.PrimaryXAxis.SmartDateZoomMonthLevelLabelFormat = "m";
            this.chartControl1.PrimaryYAxis.Crossing = double.NaN;
            this.chartControl1.PrimaryYAxis.Margin = true;
            this.chartControl1.PrimaryYAxis.RangePaddingType = Syncfusion.Windows.Forms.Chart.ChartAxisRangePaddingType.None;
            this.chartControl1.PrimaryYAxis.SmartDateZoomMonthLevelLabelFormat = "m";
            this.chartControl1.Series3D = true;
            this.chartControl1.Size = new System.Drawing.Size(939, 565);
            this.chartControl1.Style3D = true;
            this.chartControl1.TabIndex = 1;
            this.chartControl1.Text = "Essential Chart";
            // 
            // 
            // 
            this.chartControl1.Title.Name = "Def_title";
            this.chartControl1.Title.Text = "Essential Chart";
            this.chartControl1.Titles.Add(this.chartControl1.Title);
            this.chartControl1.ZoomOutIncrement = 1.5D;
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(958, 584);
            this.Controls.Add(this.chartControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(611, 478);
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "From Excel";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

		}
		#endregion

        #region Form Load
        private void Form1_Load(object sender, System.EventArgs e)
		{
            InitializeChartExcelData();
            ChartAppearance.ApplyChartStyles(this.chartControl1);
            this.chartControl1.Dock = DockStyle.Fill;


        }
        #endregion

        #region Helper Methods

        #region InitializeChartExcelData
        /// <summary>
		/// Initializes chart data from Excel Sheet.
		/// </summary>
		protected void InitializeChartExcelData()
		{
			string fileName = WinFormsUtils.FindFile(@"..\..\..\..\..\..\Common\Data\Chart","ChartData.xls");

			//The Oledbconnection.
			OleDbConnection excelConn;
#if NETCORE
            excelConn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source="+fileName+ ";Extended Properties=\"Excel 12.0;HDR=Yes;\"");
#else
            excelConn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source="+fileName+ ";Extended Properties=\"Excel 8.0;HDR=Yes;\"");
#endif
			
			excelConn.Open();

			//Query for retriving the data from the excel sheet.
			string query = "Select * From [Sheet1$A1:B11]";

			OleDbCommand excelCommand = new OleDbCommand(query,excelConn);

			OleDbDataReader excelReader = excelCommand.ExecuteReader(CommandBehavior.CloseConnection);

			//Load the contents to a dataset.
			DataSet excelDataSet = ConvertToDataSet(excelReader,"ExcelTable");

			

			this.chartControl1.Indexed = true;

			//Initializes new chart series.
            ChartSeries series = new ChartSeries();
            series.Name = tableName;
            series.Type = ChartSeriesType.Column;
			model = new ChartDataBindModel(excelDataSet,"ExcelTable");
			model.XName = "X Value";
			model.YNames = new string[]{"Y Value"};

			series.SeriesModel = model;

            //Specifies the column width mode for the Column Type chart.
            this.chartControl1.ColumnWidthMode = ChartColumnWidthMode.FixedWidthMode;

			//Adds the series to the ChartSeriesCollection.
			this.chartControl1.Series.Add(series);

			//Close the connection.
			excelReader.Close();
            excelConn.Close();
            this.chartControl1.Text = "Chart Data From Excel";

        }
        #endregion

        #region ConvertToDataSet
        /// <summary>
		/// Converts DataReader to DataSet.
		/// </summary>
		/// <param name="myReader"></param>
		/// <param name="tableName"></param>
		/// <returns></returns>
		protected DataSet ConvertToDataSet(OleDbDataReader dataReader,string tableName)
		{
			DataSet dataSet = new DataSet();
			do
			{
				// Create new data table

				DataTable schemaTable = dataReader.GetSchemaTable();
				DataTable dataTable = new DataTable(tableName);

				if ( schemaTable != null )
				{
					// A query returning records was executed

					for ( int i = 0; i < schemaTable.Rows.Count; i++ )
					{
						DataRow dataRow = schemaTable.Rows[ i ];
						// Create a column name that is unique in the data table
						string columnName = ( string )dataRow[ "ColumnName" ]; //+ "<C" + i + "/>";
						// Add the column definition to the data table
						DataColumn column = new DataColumn( columnName, ( Type )dataRow[ "DataType" ] );
						dataTable.Columns.Add( column );
					}

					//Add the data table to the dataset.
					dataSet.Tables.Add( dataTable );

					// Fill the data table.
					while ( dataReader.Read() )
					{
						DataRow dataRow = dataTable.NewRow();

						for ( int i = 0; i < dataReader.FieldCount; i++ )
							dataRow[ i ] = dataReader.GetValue( i );

						dataTable.Rows.Add( dataRow );
					}
				}
				else
				{
					// No records were returned.

					DataColumn column = new DataColumn("RowsAffected");
					dataTable.Columns.Add(column);
					dataSet.Tables.Add( dataTable );
					DataRow dataRow = dataTable.NewRow();
					dataRow[0] = dataReader.RecordsAffected;
					dataTable.Rows.Add( dataRow );
				}
			}
			while ( dataReader.NextResult() );
			return dataSet;
        }
        #endregion
       
        #endregion

    }
    /// <summary>
    /// Represents a class that is used to find the licensing file for Syncfusion controls.
    /// </summary>
    internal class DemoCommon
    {

        /// <summary>
        /// Finds the license key from the Common folder.
        /// </summary>
        /// <returns>Returns the license key.</returns>
        public static string FindLicenseKey()
        {
            string licenseKeyFile = "..\\Common\\SyncfusionLicense.txt";
            for (int n = 0; n < 20; n++)
            {
                if (!System.IO.File.Exists(licenseKeyFile))
                {
                    licenseKeyFile = @"..\" + licenseKeyFile;
                    continue;
                }
                return System.IO.File.ReadAllText(licenseKeyFile);
            }
            return string.Empty;
        }
    }
}
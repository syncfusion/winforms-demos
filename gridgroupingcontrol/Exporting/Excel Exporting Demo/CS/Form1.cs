#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DemoCommon.Grid;
using System.IO;
using System.Data.SqlServerCe;
using Syncfusion.GroupingGridExcelConverter;
using Syncfusion.Windows.Forms.Grid.Grouping;
using Syncfusion.Drawing;
using Syncfusion.Grouping;
using Syncfusion.XlsIO;
using Syncfusion.Windows.Forms;

namespace Excel_Exporting_Demo
{
    public partial class Form1 : GridDemoForm
    {
        #region Private Variables
        DataSet dataSet1;
        GridGroupingExcelConverterControl excelConverter = new GridGroupingExcelConverterControl();
        ExcelExportingOptions exportingOptions = new ExcelExportingOptions();       
        #endregion

        #region Constructor
        public Form1()
        {
            InitializeComponent();
            if (DpiAware.GetCurrentDpi() > 96)
            {
                this.CaptionBarHeight = (int)DpiAware.LogicalToDeviceUnits(this.CaptionBarHeight);
            }
            this.GridSettings();
        }
        #endregion

        #region Grid settings
        private void GridSettings()
        {
            dataSet1 = new DataSet();

            ReadXml(dataSet1, @"Data\Expand.xml");

            dataSet1.Tables[1].TableName = "Products";
            dataSet1.Tables[2].TableName = "OrderDetails";
            dataSet1.Tables[3].TableName = "Suppliers";

            dataSet1.Relations.Add(
                dataSet1.Tables[0].Columns["CategoryID"],
                dataSet1.Tables[1].Columns["CategoryID"]);
            dataSet1.Relations[0].RelationName = "Category_Products";

            dataSet1.Relations.Add(
                dataSet1.Tables[1].Columns["ProductID"],
                dataSet1.Tables[2].Columns["ProductID"]);
            dataSet1.Relations[1].RelationName = "Products_OrderDetails";

            this.gridGroupingControl1.DataSource = dataSet1.Tables[0];          


            this.gridGroupingControl1.TableControl.DpiAware = true;
			this.gridGroupingControl1.ThemesEnabled = true;
            this.gridGroupingControl1.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro;
            this.gridGroupingControl1.ShowGroupDropArea = true;
            this.gridGroupingControl1.TableDescriptor.Appearance.AnyCell.Font.Facename = "Segoe UI";
            this.gridGroupingControl1.TableDescriptor.Appearance.AnyCell.Font.Size = 10f;            

            #region Summaries
            GridTableDescriptor categoriesTableDescriptor = (GridTableDescriptor)this.gridGroupingControl1.Engine.TableDescriptor;
                   
            //Creating a new SummaryColumnDescriptor.
            GridSummaryColumnDescriptor countCat = new GridSummaryColumnDescriptor();
            //Setting it's properties.
            countCat.SummaryType = SummaryType.Count;
            
            //Initializing it to the Column it is associated with.
            countCat.DataMember = "CategoryID";

            //Adding the SummaryColumnDescriptor to the SummaryRowDescriptor.
            GridSummaryRowDescriptor categoriesSummaryRow = new GridSummaryRowDescriptor();
            categoriesSummaryRow.SummaryColumns.Add(countCat);
            //Adding the SummaryRowDescriptor to the  TableDesriptor.
            categoriesTableDescriptor.SummaryRows.Add(categoriesSummaryRow);
            #endregion

            // expand a specific record, search for groups etc.
            Table categoriesTable = this.gridGroupingControl1.Engine.Table;
            Table productsTable = categoriesTable.RelatedTables["Products"];
           
            this.gridGroupingControl1.ShowGroupDropArea = true;

            this.gridGroupingControl1.Table.Records[0].IsExpanded = true;
            categoriesTable.Records[0].IsExpanded = true;

            //Navigate to other control using tabkey navigation
            this.gridGroupingControl1.WantTabKey = false;

            #region Setting Header Text
            this.gridGroupingControl1.TableDescriptor.Columns["CategoryID"].HeaderText = "Category ID";
            this.gridGroupingControl1.TableDescriptor.Columns["CategoryName"].HeaderText = "Category Name";

            GridTableDescriptor childTableDescriptor = this.gridGroupingControl1.GetTableDescriptor("Products");
            childTableDescriptor.Columns["ProductID"].HeaderText = "Product ID";
            childTableDescriptor.Columns["ProductName"].HeaderText = "Product Name";
            childTableDescriptor.Columns["UnitsInStock"].HeaderText = "Units In Stock";
            childTableDescriptor.Columns["ReorderLevel"].HeaderText = "Reorder Level";
            childTableDescriptor.Columns["QuantityPerUnit"].HeaderText = "Quantity Per Unit";
            childTableDescriptor.Columns["UnitPrice"].HeaderText = "Unit Price";
            childTableDescriptor.Columns["UnitsOnOrder"].HeaderText = "Unit on Order";

            GridTableDescriptor nestedTableDescriptor = this.gridGroupingControl1.GetTableDescriptor("OrderDetails");
            nestedTableDescriptor.Columns["OrderID"].HeaderText = "Order ID";
            nestedTableDescriptor.Columns["UnitPrice"].HeaderText = "Unit price";
            
            #endregion
        }
        #endregion     

        #region Sample customization
        private void exportToExcelBtn_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Files(*.Xls)|*.Xls|Files(*.Xlsx)|*Xlsx";
            saveFileDialog.AddExtension = true;
            saveFileDialog.DefaultExt = ".Xlsx";
            saveFileDialog.FileName = "Untitled";
            if (saveFileDialog.ShowDialog() == DialogResult.OK && saveFileDialog.CheckPathExists)
            {                   

                excelConverter.ExportStyle = this.exportStyle.Checked;
                excelConverter.ExportBorders = this.exportBorders.Checked;
                excelConverter.ApplyExcelFilter = this.applyExcelFilter.Checked;
                excelConverter.CanExportColumnWidth = this.canExportColumnWidth.Checked;
                excelConverter.CanExportRowHeight = this.canExportRowHeight.Checked;
                excelConverter.AllowGroupOutlining = this.allowGroupOutlining.Checked;
                excelConverter.AllowNestedTableOutling = this.allowNestedTableOutlining.Checked;

                //This property is used to export the GGc with optimized manner. If you enable this property, the grid will be exported without creating the styles. 
                //The data will be taken from Table.Records and number format will be set as column wise.
                excelConverter.EnableOptimization = this.enableOptimization.Checked;

                excelConverter.ExportNestedTableCaption = this.exportNestedTableCaption.Checked;
                excelConverter.ShowGridLines = this.showGridLines.Checked;               
               
                exportingOptions.ExportGroupSummary = this.exportGroupSummary.Checked;
                exportingOptions.ExportTableSummary = this.exportTableSummary.Checked;

                if (this.customizeStylesInEvent.Checked)
                         excelConverter.QueryExportRowRange += new GridGroupingExcelConverterControl.QueryExportRowRangeEventHandler(excelConverter_QueryExportRowRange);          
                else
                    excelConverter.QueryExportRowRange -= new GridGroupingExcelConverterControl.QueryExportRowRangeEventHandler(excelConverter_QueryExportRowRange);          
   
                excelConverter.ExportToExcel(this.gridGroupingControl1, saveFileDialog.FileName, exportingOptions);

                if (MessageBox.Show("Do you wish to open the xls file now?", "Export to Excel", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    System.Diagnostics.Process proc = new System.Diagnostics.Process();
                    proc.StartInfo.FileName = saveFileDialog.FileName;
                    proc.Start();
                }
            }
        }
        
        #endregion

        #region Event Customization

        void excelConverter_QueryExportRowRange(object sender, QueryExportRowRangeEventArgs e)
        {

            GridTableDescriptor tableDescriptor = (GridTableDescriptor)e.Element.ParentTableDescriptor;
            int excelRowIndex = e.ExcelRange.Row;
            if (e.Element.Kind == DisplayElementKind.ColumnHeader)
            {
                for (int columnIndex = 0; columnIndex < tableDescriptor.VisibleColumns.Count; columnIndex++)
                {
                    IRange range = e.ExcelRange[excelRowIndex, e.ExcelRange.Column + columnIndex];
                    range.CellStyle.ColorIndex = Syncfusion.XlsIO.ExcelKnownColors.Light_blue;
                    range.CellStyle.Font.RGBColor = Color.DarkRed;
                    range.CellStyle.Font.FontName = "Segoe UI";
                    range.CellStyle.Font.Size = 10;
                    range.CellStyle.Font.Bold = true;
                    range.CellStyle.HorizontalAlignment = ExcelHAlign.HAlignCenter;
                }
            }
            else if (e.Element.Kind == DisplayElementKind.Caption)
            {
                IRange range = e.ExcelRange;
                range.CellStyle.ColorIndex = Syncfusion.XlsIO.ExcelKnownColors.Grey_40_percent;
                range.CellStyle.Font.RGBColor = Color.White;
                range.CellStyle.Font.FontName = "Segoe UI";
                range.CellStyle.Font.Size = 10;
                range.CellStyle.Font.Bold = true;
            }
            else if (e.Element.Kind == DisplayElementKind.Summary)
            {
                for (int columnIndex = 0; columnIndex < tableDescriptor.VisibleColumns.Count; columnIndex++)
                {
                    IRange range = e.ExcelRange[excelRowIndex, e.ExcelRange.Column + columnIndex];
                    range.CellStyle.ColorIndex = Syncfusion.XlsIO.ExcelKnownColors.Grey_25_percent;
                    range.CellStyle.Font.RGBColor = Color.White;
                    range.CellStyle.Font.FontName = "Segoe UI";
                    range.CellStyle.Font.Size = 10;
                    range.CellStyle.Font.Bold = true;
                }
            }
        }

        #endregion

        #region Reading xml file

        void ReadXml(DataSet ds, string xmlFileName)
        {
            for (int n = 0; n < 10; n++)
            {
                if (File.Exists(xmlFileName))
                {
                    ds.ReadXml(xmlFileName);
                    break;
                }
                xmlFileName = @"..\" + xmlFileName;
            }
        }

        #endregion        
    }
}

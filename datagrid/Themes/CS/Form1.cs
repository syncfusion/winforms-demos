#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Syncfusion.Data;
using Syncfusion.WinForms.Controls;
using Syncfusion.WinForms.Core.Utils;
using Syncfusion.WinForms.DataGrid;
using Syncfusion.WinForms.DataGrid.Enums;
using Syncfusion.WinForms.Input.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Themes
{
    public partial class Form1 : SfForm
    {
        SfDataGrid firstLevelSourceDataGrid;
        public Form1()
        {
            InitializeComponent();
            SampleCustomization();
            
            try
            {
                Bitmap bmp = new Bitmap(Image.FromFile(@"../../Icon/sficon.ico"));
                this.Icon = Icon.FromHandle(bmp.GetHicon());
            }
            catch (Exception ex)
            { }
        }

        /// <summary>
        /// Sets the sample customization settings.
        /// </summary>
        private void SampleCustomization()
        {
            #region SfDataGrid settings
            sfDataGrid1.ThemeName = "Office2016Colorful";
            sfDataGrid1.ShowRowHeader = true;
            sfDataGrid1.AllowFiltering = true;
            this.sfDataGrid1.AllowGrouping = true;
            this.sfDataGrid1.ShowGroupDropArea = true;
            this.sfDataGrid1.AutoGenerateColumns = false;
            this.sfDataGrid1.AutoSizeColumnsMode = AutoSizeColumnsMode.Fill;

            OrderInfoRepository orderInfo = new OrderInfoRepository();
            this.sfDataGrid1.DataSource = orderInfo.GetOrdersDetails(30);
            this.sfDataGrid1.Columns.Add(new GridNumericColumn() { MappingName = "OrderID", HeaderText = "Order ID", Width = 130, NumberFormatInfo = new System.Globalization.NumberFormatInfo { NumberGroupSeparator = "", NumberDecimalDigits = 0 } });
            this.sfDataGrid1.Columns.Add(new GridTextColumn() { MappingName = "CustomerID", HeaderText = "Customer ID" });
            this.sfDataGrid1.Columns.Add(new GridTextColumn() { MappingName = "ShipCity", HeaderText = "Ship City" });
            this.sfDataGrid1.Columns.Add(new GridTextColumn() { MappingName = "ShipCity", HeaderText = "Ship Country" });
            this.sfDataGrid1.Columns.Add(new GridDateTimeColumn() { MappingName = "ShippingDate", HeaderText = "Shipping Date" });
            this.sfDataGrid1.Columns.Add(new GridNumericColumn() { MappingName = "Freight", HeaderText = "Freight", FormatMode = FormatMode.Currency });
            this.sfDataGrid1.Columns.Add(new GridCheckBoxColumn() { MappingName = "IsClosed", HeaderText = "Is Closed", CheckBoxSize = new Size((int)DpiAware.LogicalToDeviceUnits(14.0f), (int)DpiAware.LogicalToDeviceUnits(14.0f)) });
            sfDataGrid1.AllowResizingColumns = true;
            #endregion

            #region themComboBox settings
            List<ThemeTypes> theme = new List<ThemeTypes>();
            theme.Add(new ThemeTypes() { ThemeName = "Office2016Black", Value = 1 });
            theme.Add(new ThemeTypes() { ThemeName = "Office2016White", Value = 2 });
            theme.Add(new ThemeTypes() { ThemeName = "Office2016DarkGray", Value = 3 });
            theme.Add(new ThemeTypes() { ThemeName = "Office2016Colorful", Value = 4 });
            theme.Add(new ThemeTypes() { ThemeName = "Office2019Colorful", Value = 5 });
            theme.Add(new ThemeTypes() { ThemeName = "HighContrastBlack", Value = 6 });
            comboBox1.DataSource = theme;
            comboBox1.DisplayMember = "ThemeName";
            comboBox1.ValueMember = "ThemeName";
            comboBox1.SelectedValueChanged += comboBox1_SelectedValueChanged;
            comboBox1.SelectedValue = "Office2016Colorful";
            #endregion
            
            this.checkBox1.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Office2016Colorful;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;

            #region TableSummaryRow

            GridTableSummaryRow tableSummaryRow1 = new GridTableSummaryRow();
            tableSummaryRow1.Name = "TableSummary";
            tableSummaryRow1.ShowSummaryInRow = true;
            tableSummaryRow1.Title = " Total Count: {OrderID}";
            tableSummaryRow1.Position = VerticalPosition.Bottom;

            GridSummaryColumn summaryColumn1 = new GridSummaryColumn();
            summaryColumn1.Name = "OrderID";
            summaryColumn1.SummaryType = SummaryType.DoubleAggregate;
            summaryColumn1.Format = "{Count}";
            summaryColumn1.MappingName = "OrderID";
            tableSummaryRow1.SummaryColumns.Add(summaryColumn1);
            this.sfDataGrid1.TableSummaryRows.Add(tableSummaryRow1);           

            #endregion

            #region GroupSummaryRow

            // Creates the GridSummaryRow.
            GridSummaryRow groupSummaryRow1 = new GridSummaryRow();
            groupSummaryRow1.Name = "GroupSummary";
            groupSummaryRow1.ShowSummaryInRow = false;
            groupSummaryRow1.Title = "Total  $: { OrderID }";

            // Creates the GridSummaryColumn.
            GridSummaryColumn summaryColumn3 = new GridSummaryColumn();
            summaryColumn3.Name = "OrderID";
            summaryColumn3.SummaryType = SummaryType.DoubleAggregate;
            summaryColumn3.Format = "Total : {Sum:c}";
            summaryColumn3.MappingName = "OrderID";

            // Adds the GridSummaryColumn in SummaryColumns collection.
            groupSummaryRow1.SummaryColumns.Add(summaryColumn3);

            // Adds the summary row in the GroupSummaryRows collection.
            this.sfDataGrid1.GroupSummaryRows.Add(groupSummaryRow1);


            #endregion

            #region Relation Creation
            GridViewDefinition viewDefinition = new GridViewDefinition();
            viewDefinition.RelationalColumn = "OrderDetails";
            firstLevelSourceDataGrid = new SfDataGrid();
            firstLevelSourceDataGrid.Columns.Add(new GridNumericColumn() { MappingName = "OrderID", HeaderText = "Order ID", NumberFormatInfo = new System.Globalization.NumberFormatInfo { NumberGroupSeparator = "", NumberDecimalDigits = 0 } });
            firstLevelSourceDataGrid.Columns.Add(new GridDateTimeColumn() { MappingName = "OrderDate", HeaderText = "Order Date" });
            firstLevelSourceDataGrid.Columns.Add(new GridTextColumn() { MappingName = "CustomerID", HeaderText = "Customer ID" });
            firstLevelSourceDataGrid.Columns.Add(new GridTextColumn() { MappingName = "CustomerCity", HeaderText = "Customer City" });
            firstLevelSourceDataGrid.Columns.Add(new GridNumericColumn() { MappingName = "ProductID", HeaderText = "Product ID", FormatMode = FormatMode.Numeric });
            firstLevelSourceDataGrid.Columns.Add(new GridNumericColumn() { MappingName = "UnitPrice", HeaderText = "Unit Price", FormatMode = FormatMode.Currency });
            firstLevelSourceDataGrid.Columns.Add(new GridNumericColumn() { MappingName = "Quantity", HeaderText = "Quantity", FormatMode = FormatMode.Numeric });
            firstLevelSourceDataGrid.Columns.Add(new GridNumericColumn() { MappingName = "Discount", HeaderText = "Discount", FormatMode = FormatMode.Percent });
            StackedHeaderRow stackedHeaderRow = new StackedHeaderRow();
            stackedHeaderRow.StackedColumns.Add(new StackedColumn() { ChildColumns = "OrderID,OrderDate", HeaderText = "Order Details" });
            stackedHeaderRow.StackedColumns.Add(new StackedColumn() { ChildColumns = "CustomerID,CustomerCity", HeaderText = "Customer Details" });
            stackedHeaderRow.StackedColumns.Add(new StackedColumn() { ChildColumns = "ProductID,UnitPrice,Quantity,Discount", HeaderText = "Product Details" });
            firstLevelSourceDataGrid.AllowResizingColumns = true;
            firstLevelSourceDataGrid.AutoSizeColumnsMode = AutoSizeColumnsMode.Fill;
            viewDefinition.DataGrid = firstLevelSourceDataGrid;
            this.sfDataGrid1.DetailsViewDefinitions.Add(viewDefinition);
            #endregion

            this.sfDataGrid1.HideEmptyGridViewDefinition = true;
        }

        #region events
        void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            this.sfDataGrid1.ShowRowHeader = checkBox1.Checked;
            if (firstLevelSourceDataGrid != null)
                firstLevelSourceDataGrid.ShowRowHeader = checkBox1.Checked;
        }

        void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {

            if (comboBox1.SelectedValue.ToString() == "Office2016Black")
            {
                this.sfDataGrid1.ThemeName = "Office2016Black";
                this.Style.TitleBar.BackColor = Color.FromArgb(38, 38, 38);
                this.Style.TitleBar.CloseButtonForeColor = ColorTranslator.FromHtml("#f0f0f0");
                this.Style.TitleBar.MaximizeButtonForeColor = ColorTranslator.FromHtml("#f0f0f0");
                this.Style.TitleBar.CloseButtonHoverBackColor = ColorTranslator.FromHtml("#d4d4d4");
                this.Style.TitleBar.MinimizeButtonForeColor = ColorTranslator.FromHtml("#f0f0f0");
                this.Style.TitleBar.MinimizeButtonHoverBackColor = ColorTranslator.FromHtml("#d4d4d4");
                this.BackColor = ColorTranslator.FromHtml("#444444");
                this.Style.TitleBar.ForeColor = ColorTranslator.FromHtml("#d3d3d3");
                this.label1.BackColor = ColorTranslator.FromHtml("#444444");
                this.label1.ForeColor = ColorTranslator.FromHtml("#d3d3d3");
                this.comboBox1.ThemeName = "Office2016Black";
                this.checkBox1.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Office2016Black;
                this.checkBox1.BackColor = ColorTranslator.FromHtml("#444444");
            }
            else if (comboBox1.SelectedValue.ToString() == "Office2016DarkGray")
            {
                this.sfDataGrid1.ThemeName = "Office2016DarkGray";
                this.BackColor = ColorTranslator.FromHtml("#d4d4d4");
                this.Style.TitleBar.CloseButtonForeColor = ColorTranslator.FromHtml("#f0f0f0");
                this.Style.TitleBar.MaximizeButtonForeColor = ColorTranslator.FromHtml("#f0f0f0");
                this.Style.TitleBar.CloseButtonHoverBackColor = ColorTranslator.FromHtml("#d4d4d4");
                this.Style.TitleBar.MinimizeButtonForeColor = ColorTranslator.FromHtml("#f0f0f0");
                this.Style.TitleBar.MinimizeButtonHoverBackColor = ColorTranslator.FromHtml("#d4d4d4");
                this.Style.TitleBar.BackColor = Color.FromArgb(102, 102, 102);
                this.Style.TitleBar.ForeColor = Color.FromArgb(240, 240, 240);
                this.label1.BackColor = ColorTranslator.FromHtml("#d4d4d4");
                this.label1.ForeColor = ColorTranslator.FromHtml("#262626");
                this.comboBox1.ThemeName = "Office2016DarkGray";
                this.checkBox1.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Office2016DarkGray;
                this.checkBox1.BackColor = ColorTranslator.FromHtml("#d4d4d4");
                this.checkBox1.ForeColor = Color.FromArgb(38, 38, 38);
            }
            else if (comboBox1.SelectedValue.ToString() == "Office2016Colorful")
            {
                this.sfDataGrid1.ThemeName = "Office2016Colorful";
                this.BackColor = ColorTranslator.FromHtml("#FFFFFF");
                this.Style.TitleBar.BackColor = Color.FromArgb(242, 242, 242);
                this.Style.TitleBar.CloseButtonForeColor = Color.FromArgb(51, 51, 51);
                this.Style.TitleBar.MaximizeButtonForeColor = Color.FromArgb(51, 51, 51);
                this.Style.TitleBar.MinimizeButtonForeColor = Color.FromArgb(51, 51, 51);
                this.Style.TitleBar.CloseButtonHoverBackColor = this.Style.TitleBar.MinimizeButtonHoverBackColor;
                this.Style.TitleBar.CloseButtonHoverForeColor = this.Style.TitleBar.MinimizeButtonHoverForeColor;
                this.Style.TitleBar.ForeColor = ColorTranslator.FromHtml("#444444");
                this.label1.BackColor = ColorTranslator.FromHtml("#FFFFFF");
                this.label1.ForeColor = ColorTranslator.FromHtml("#444444");
                this.comboBox1.ThemeName = "Office2016Colorful";
                this.checkBox1.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Office2016Colorful;
                this.checkBox1.BackColor = ColorTranslator.FromHtml("#FFFFFF");
            }
            else if (comboBox1.SelectedValue.ToString() == "Office2016White")
            {
                this.sfDataGrid1.ThemeName = "Office2016White";
                this.BackColor = ColorTranslator.FromHtml("#FFFFFF");
                this.Style.TitleBar.BackColor = Color.FromArgb(242, 242, 242);
                this.Style.TitleBar.CloseButtonForeColor = Color.FromArgb(51, 51, 51);
                this.Style.TitleBar.MaximizeButtonForeColor = Color.FromArgb(51, 51, 51);
                this.Style.TitleBar.MinimizeButtonForeColor = Color.FromArgb(51, 51, 51);
                this.Style.TitleBar.CloseButtonHoverBackColor = this.Style.TitleBar.MinimizeButtonHoverBackColor;
                this.Style.TitleBar.CloseButtonHoverForeColor = this.Style.TitleBar.MinimizeButtonHoverForeColor;
                this.Style.TitleBar.ForeColor = ColorTranslator.FromHtml("#444444");
                this.label1.BackColor = ColorTranslator.FromHtml("#FFFFFF");
                this.label1.ForeColor = ColorTranslator.FromHtml("#444444");
                this.comboBox1.ThemeName = "Office2016White";
                this.checkBox1.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Office2016White;
                this.checkBox1.BackColor = ColorTranslator.FromHtml("#FFFFFF");
            }
            else if (comboBox1.SelectedValue.ToString() == "Office2019Colorful")
            {
                this.sfDataGrid1.ThemeName = "Office2019Colorful";
                this.BackColor = ColorTranslator.FromHtml("#F6F6F6");
                this.Style.TitleBar.BackColor = Color.FromArgb(242, 242, 242);
                this.Style.TitleBar.CloseButtonForeColor = Color.FromArgb(51, 51, 51);
                this.Style.TitleBar.MaximizeButtonForeColor = Color.FromArgb(51, 51, 51);
                this.Style.TitleBar.MinimizeButtonForeColor = Color.FromArgb(51, 51, 51);
                this.Style.TitleBar.CloseButtonHoverBackColor = this.Style.TitleBar.MinimizeButtonHoverBackColor;
                this.Style.TitleBar.CloseButtonHoverForeColor = this.Style.TitleBar.MinimizeButtonHoverForeColor;
                this.Style.TitleBar.ForeColor = ColorTranslator.FromHtml("#3b3b3b");
                this.label1.BackColor = ColorTranslator.FromHtml("#F6F6F6");
                this.label1.ForeColor = ColorTranslator.FromHtml("#3b3b3b");
                this.comboBox1.ThemeName = "Office2019Colorful";
                this.checkBox1.ThemeName = "Office2019Colorful";
            }
            if (comboBox1.SelectedValue.ToString() == "HighContrastBlack")
            {
                this.sfDataGrid1.ThemeName = "HighContrastBlack";
                this.Style.TitleBar.BackColor = ColorTranslator.FromHtml("#000000");
                this.Style.TitleBar.CloseButtonForeColor = ColorTranslator.FromHtml("#f0f0f0");
                this.Style.TitleBar.MaximizeButtonForeColor = ColorTranslator.FromHtml("#f0f0f0");
                this.Style.TitleBar.CloseButtonHoverBackColor = ColorTranslator.FromHtml("#d4d4d4");
                this.Style.TitleBar.MinimizeButtonForeColor = ColorTranslator.FromHtml("#f0f0f0");
                this.Style.TitleBar.MinimizeButtonHoverBackColor = ColorTranslator.FromHtml("#d4d4d4");
                this.BackColor = ColorTranslator.FromHtml("#000000");
                this.Style.TitleBar.ForeColor = ColorTranslator.FromHtml("#d3d3d3");
                this.label1.BackColor = ColorTranslator.FromHtml("#000000");
                this.label1.ForeColor = ColorTranslator.FromHtml("#d3d3d3");
                this.comboBox1.ThemeName = "HighContrastBlack";
                this.checkBox1.ThemeName = "HighContrastBlack";
            }
        }

        #endregion
    }

    #region ThemeData
    public class ThemeTypes
    {
        public string ThemeName { get; set; }
        public int Value { get; set; }
    }
    #endregion
}

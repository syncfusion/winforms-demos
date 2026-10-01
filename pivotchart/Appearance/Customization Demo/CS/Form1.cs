#region Copyright Syncfusion Inc. 2001 - 2018.
// Copyright Syncfusion Inc. 2001 - 2018. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion

using System;
using System.Drawing;
using Syncfusion.Windows.Forms;
using Syncfusion.PivotAnalysis.Base;
using System.Drawing.Drawing2D;
using Syncfusion.Windows.Forms.Tools;

namespace CustomizationDemo
{
    public partial class Form1 : MetroForm
    {
        #region Constructor

        public Form1()
        {
            InitializeComponent();
            this.InitializePivotChart();

            this.LoadColorComboBoxes(this.comboBox1);
            this.LoadColorComboBoxes(this.comboBox3);
            this.LoadColorComboBoxes(this.comboBox4);
            this.LoadColorComboBoxes(this.comboBox6);
            this.LoadDashStylesComboBoxes(this.comboBox2);
            this.LoadDashStylesComboBoxes(this.comboBox5);

            this.comboBox1.SelectedItem = "LightGray";
            this.comboBox2.SelectedItem = DashStyle.Solid;
            this.comboBox3.SelectedItem = "Transparent";
            this.comboBox4.SelectedItem = "LightBlue";
            this.comboBox5.SelectedItem = DashStyle.Solid;
            this.comboBox6.SelectedItem = "Azure";
        }

        #endregion

        #region PivotChart Settings

        private void InitializePivotChart()
        {
            // Adding ItemSource to the Control
            this.pivotChart1.ItemSource = ProductSalesData.GetSalesData();

            // Adding PivotAxis to the Control
            this.pivotChart1.PivotAxis.Add(new PivotItem { FieldMappingName = "Product", TotalHeader = "Total" });
            this.pivotChart1.PivotAxis.Add(new PivotItem { FieldMappingName = "Date", TotalHeader = "Total" });

            // Adding PivotLegend to the Control
            this.pivotChart1.PivotLegend.Add(new PivotItem { FieldMappingName = "Country", TotalHeader = "Total" });

            // Adding PivotCalculations to the Control
            this.pivotChart1.PivotCalculations.Add(new PivotComputationInfo { FieldName = "Quantity", Format = "#,##0" });
            this.pivotChart1.PrimaryXAxis.InterlacedGrid = this.checkBox1.Checked;
            this.pivotChart1.PrimaryYAxis.InterlacedGrid = this.checkBox2.Checked;
        }

        #endregion

        #region Helper Methods

        /// <summary>
        /// Load the combobox items.
        /// </summary>
        private void LoadDashStylesComboBoxes(ComboBoxAdv combo)
        {
            combo.Items.Add(DashStyle.Dash);
            combo.Items.Add(DashStyle.DashDot);
            combo.Items.Add(DashStyle.DashDotDot);
            combo.Items.Add(DashStyle.Dot);
            combo.Items.Add(DashStyle.Solid);
            combo.SelectedValueChanged += new EventHandler(combo_SelectedValueChanged1);
        }

        /// <summary>
        /// used to load the combo box color items.
        /// </summary>
        /// <param name="combo"></param>
        private void LoadColorComboBoxes(ComboBoxAdv combo)
        {
            foreach (System.Reflection.PropertyInfo prop in typeof(Color).GetProperties())
            {
                if (prop.PropertyType.FullName == "System.Drawing.Color")
                    combo.Items.Add(prop.Name);
            }
            combo.SelectedValueChanged += new EventHandler(combo_SelectedValueChanged);
        }

        #endregion

        #region Event Handlers

        /// <summary>
        /// used to change the dashstyle of the pivotchart.
        /// </summary>
        void combo_SelectedValueChanged1(object sender, EventArgs e)
        {
            ComboBoxAdv combo = sender as ComboBoxAdv;
            Syncfusion.Windows.Forms.PivotChart.PivotChartAxisStyles.PivotChartAxis axis;
            axis = (combo == this.comboBox2) ? this.pivotChart1.PrimaryXAxis : this.pivotChart1.PrimaryYAxis;

            if (combo.SelectedItem.ToString() == DashStyle.Dash.ToString())
            {
                axis.GridLineType.DashStyle = DashStyle.Dash;
            }
            else if (combo.SelectedItem.ToString() == DashStyle.DashDot.ToString())
            {
                axis.GridLineType.DashStyle = DashStyle.DashDot;
            }
            else if (combo.SelectedItem.ToString() == DashStyle.DashDotDot.ToString())
            {
                axis.GridLineType.DashStyle = DashStyle.DashDotDot;
            }
            else if (combo.SelectedItem.ToString() == DashStyle.Dot.ToString())
            {
                axis.GridLineType.DashStyle = DashStyle.Dot;
            }
            else if (combo.SelectedItem.ToString() == DashStyle.Solid.ToString())
            {
                axis.GridLineType.DashStyle = DashStyle.Solid;
            }
        }

        /// <summary>
        ///  Selected Axis style changes customization.
        /// </summary>
        void combo_SelectedValueChanged(object sender, EventArgs e)
        {
            ComboBoxAdv combo = sender as ComboBoxAdv;
            Color color = Color.FromName(combo.SelectedItem.ToString());
            if (combo == this.comboBox1)
            {
                this.pivotChart1.PrimaryXAxis.GridLineType.ForeColor = color;
            }
            else if (combo == this.comboBox3)
            {
                this.pivotChart1.PrimaryXAxis.InterlacedGridInterior = new Syncfusion.Drawing.BrushInfo(color);
            }
            else if (combo == this.comboBox4)
            {
                this.pivotChart1.PrimaryYAxis.GridLineType.ForeColor = color;
            }
            else if (combo == this.comboBox6)
            {
                this.pivotChart1.PrimaryYAxis.InterlacedGridInterior = new Syncfusion.Drawing.BrushInfo(color);
            }
        }

        /// <summary>
        /// used to change the interlaced grid settings of primary x-axis.
        /// </summary>
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            this.pivotChart1.PrimaryXAxis.InterlacedGrid = this.checkBox1.Checked;
            this.comboBox3.Enabled = this.checkBox1.Checked;
        }

        /// <summary>
        /// used to change the interlaced grid settings of primary y-axis.
        /// </summary>
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            this.pivotChart1.PrimaryYAxis.InterlacedGrid = this.checkBox2.Checked;
            this.comboBox6.Enabled = this.checkBox2.Checked;
        }

        #endregion        
    }
}
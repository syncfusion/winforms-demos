#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Syncfusion.PivotAnalysis.Base;
using Syncfusion.Windows.Forms;
using Syncfusion.Windows.Forms.PivotAnalysis;
using System;
using System.Windows.Forms;
using Syncfusion.Windows.Forms.PivotAnalysis.Serialization;
using ValueType = Syncfusion.Windows.Forms.PivotAnalysis.ValueType;

namespace SerializationDemo
{
    public partial class Form1 : MetroForm
    {
        #region private fields

        SerializationOptions serailizationOptions = new SerializationOptions();
        DeserializationOptions deserailizationOptions = new DeserializationOptions();

        #endregion

        #region Constructor

        public Form1()
        {
            InitializeComponent();
            this.InitializeGrid();
        }

        #endregion

        #region Grid Settings

        private void InitializeGrid()
        {
            pivotGridControl1.GridVisualStyles = GridVisualStyles.Metro;
            pivotGridControl1.ItemSource = ProductSalesData.GetSalesData();

            //used to add PivotRows.
            pivotGridControl1.PivotRows.Add(new PivotItem { FieldMappingName = "Product", TotalHeader = "Total" });
            pivotGridControl1.PivotRows.Add(new PivotItem { FieldMappingName = "Date", TotalHeader = "Total" });

            //used to add PivotColumns.
            pivotGridControl1.PivotColumns.Add(new PivotItem { FieldMappingName = "Country", TotalHeader = "Total" });
            pivotGridControl1.PivotColumns.Add(new PivotItem { FieldMappingName = "State", TotalHeader = "Total" });

            //used to add PivotCalculations.
            pivotGridControl1.PivotCalculations.Add(new PivotComputationInfo { FieldName = "Amount", Format = "C", SummaryType = SummaryType.DoubleTotalSum });
            pivotGridControl1.PivotCalculations.Add(new PivotComputationInfo { FieldName = "Quantity", Format = "#,##0" });

            pivotGridControl1.ShowGroupBar = true;
            pivotGridControl1.AllowFiltering = true;
            pivotGridControl1.AllowSorting = true;
            this.AddConditionalFormats();
        }

        private void ResetGrid()
        {
            pivotGridControl1.TableControl.ConditionalFormats.Clear();
            pivotGridControl1.TableControl.ResetPivotData();

            pivotGridControl1.ItemSource = ProductSalesData.GetSalesData();

            //used to add PivotRows.
            pivotGridControl1.PivotRows.Add(new PivotItem { FieldMappingName = "Product", TotalHeader = "Total" });
            pivotGridControl1.PivotRows.Add(new PivotItem { FieldMappingName = "Date", TotalHeader = "Total" });

            //used to add PivotColumns.
            pivotGridControl1.PivotColumns.Add(new PivotItem { FieldMappingName = "Country", TotalHeader = "Total" });
            pivotGridControl1.PivotColumns.Add(new PivotItem { FieldMappingName = "State", TotalHeader = "Total" });

            //used to add PivotCalculations.
            pivotGridControl1.PivotCalculations.Add(new PivotComputationInfo { FieldName = "Amount", Format = "C", SummaryType = SummaryType.DoubleTotalSum });
            pivotGridControl1.PivotCalculations.Add(new PivotComputationInfo { FieldName = "Quantity", Format = "#,##0" });

            pivotGridControl1.ShowGroupBar = true;
            pivotGridControl1.AllowFiltering = true;
            pivotGridControl1.AllowSorting = true;

            this.AddConditionalFormats();
        }

        #endregion

        #region Event Handlers

        private void buttonAdv1_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfv = new SaveFileDialog();
            sfv.FileName = "Sample";
            sfv.DefaultExt = ".xml";
            sfv.Filter = "(*.xml)|*.xml";
            if (sfv.ShowDialog() == DialogResult.OK)
            {
                this.pivotGridControl1.Serialize(sfv.FileName, serialization());
            }
        }

        private void buttonAdv2_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.DefaultExt = ".xml";
            ofd.Filter = "(*.xml)|*.xml";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                this.pivotGridControl1.Deserialize(ofd.FileName, deserialization());
            }
        }

        private void buttonAdv3_Click(object sender, EventArgs e)
        {
            ResetGrid();
        }

        #endregion

        #region Helper Methods

        private void AddConditionalFormats()
        {
            NewRuleConditionalFormat newRule1 = new NewRuleConditionalFormat();
            newRule1.RuleType = RuleType.FormatAllCellsBasedOnTheirValues;
            newRule1.FormatStyle = FormatStyle.IconSets;
            newRule1.SummaryElement = "Quantity";
            newRule1.Image = BitMapImageName.ThreeTriangle;
            newRule1.ValueType1 = ValueType.Number;
            newRule1.ValueType2 = ValueType.Number;
            newRule1.ValueType3 = ValueType.Number;
            newRule1.ValueType4 = ValueType.Number;
            PivotGridNewRuleConditionalFormat newRuleFormat1 = new PivotGridNewRuleConditionalFormat();
            newRuleFormat1.NewRuleCollections.Add(newRule1);
            this.pivotGridControl1.TableControl.NewRuleConditionalFormat.Add(newRuleFormat1);
            this.pivotGridControl1.TableControl.Refresh(true);
        }

        private SerializationOptions serialization()
        {
            serailizationOptions.SerializeFiltering = this.seriailize_filtering.Checked;
            serailizationOptions.SerializeSorting = this.seriailize_sorting.Checked;
            serailizationOptions.SerializeGrouping = this.seriailize_grouping.Checked;
            serailizationOptions.SerializeConditionalFormats = this.seriailize_condformats.Checked;
            serailizationOptions.SerializePivotRows = this.seriailize_pivotrows.Checked;
            serailizationOptions.SerializePivotColumns = this.seriailize_pivotcolumns.Checked;
            serailizationOptions.SerializePivotCalculations = this.seriailize_pivotcalculations.Checked;
            serailizationOptions.SerializeExpandCollapseState = this.seriailize_expandcollapsestate.Checked;
            return serailizationOptions;
        }

        private DeserializationOptions deserialization()
        {
            deserailizationOptions.DeserializeFiltering = this.deseriailize_filtering.Checked;
            deserailizationOptions.DeserializeGrouping = this.deseriailize_grouping.Checked;
            deserailizationOptions.DeserializeSorting = this.deseriailize_sorting.Checked;
            deserailizationOptions.DeserializeConditionalFormats = this.deseriailize_condformats.Checked;
            deserailizationOptions.DeserailizePivotRows = this.deseriailize_pivotrows.Checked;
            deserailizationOptions.DeserializePivotColumns = this.deseriailize_pivotcolumns.Checked;
            deserailizationOptions.DeserializePivotCalculations = this.deseriailize_pivotcalculations.Checked;
            deserailizationOptions.DeserializeExpandCollapseState = this.deseriailize_expandcollapsestate.Checked;
            return deserailizationOptions;
        }

        #endregion
    }
}
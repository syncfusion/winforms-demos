#region Copyright Syncfusion Inc. 2001 - 2018
// Copyright Syncfusion Inc. 2001 - 2018. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion

using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Syncfusion.PivotAnalysis.Base;
using Syncfusion.Windows.Forms;
using Syncfusion.Windows.Forms.Grid;
using Syncfusion.Windows.Forms.PivotAnalysis;
using ValueType = Syncfusion.Windows.Forms.PivotAnalysis.ValueType;

namespace ConditionalFormating
{
    public partial class Form1 : MetroForm
    {
        #region Fields

        bool load = true;

        #endregion

        #region Constructor

        public Form1()
        {
            InitializeComponent();

            settings();
            InitializePivotGrid();
        }

        #endregion

        #region "Image Loading Methods"
        //Get and Load the images
#if NET9_0_OR_GREATER
        private Image GetImage(string path)
        {
            System.Reflection.Assembly asm = System.Reflection.Assembly.GetExecutingAssembly();
            if (asm != null && !string.IsNullOrEmpty(path))
                return Image.FromStream(asm.GetManifestResourceStream(path));
            return null;
        }

        private void LoadImages(ImageList imageList, string folder, int count)
        {
            for (int i = 1; i <= count; i++)
            {
                string imagePath = ($"ConditionalFormating.Images.{folder}.Image_{i}.png");
                imageList.Images.Add(GetImage(imagePath));
            }
        }
#endif
        #endregion


        #region Pivot Grid Settings

        /// <summary>
        /// Grid Settings for better look and feel
        /// </summary>
        private void InitializePivotGrid()
        {
            Load += Form1_Load;
            grdRuleType.Grid.SupportsPrepareViewStyleInfo = false;
            grdRuleType.Grid.DefaultGridBorderStyle = GridBorderStyle.Solid;
            grdDropDown.Grid.Click += Grid_Click;
            grdRuleType.Grid.Click += Grid1_Click;
            CommonCombobox();

            //tab key navigation set as false to move the next control
            pivotGridControl1.TableControl.WantTabKey = false;
        }

        #endregion

        #region Grid List - Data Table

        /// <summary>
        /// Generate a Data Table for DataSource
        /// </summary>
        private DataTable CreateTable()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Id");
            dt.Columns.Add("Name");

            dt.Rows.Add(0, "3-Triangle");
            dt.Rows.Add(1, "3-TrafficLightsUnrimmed");
            dt.Rows.Add(2, "3-TrafficLightsrimmed");
            dt.Rows.Add(3, "3-SymbolsUnCircled");
            dt.Rows.Add(4, "3-Symbols");
            dt.Rows.Add(5, "3-Stars");
            dt.Rows.Add(6, "3-Signs");
            dt.Rows.Add(7, "RedToBlack");
            dt.Rows.Add(8, "4-Rating");
            dt.Rows.Add(9, "4-ArrowsGray");
            dt.Rows.Add(10, "4-TrafficLight");
            dt.Rows.Add(11, "4-ArrowsColored");
            dt.Rows.Add(12, "5-ArrowsColored");
            dt.Rows.Add(13, "5-ArrowsGray");
            dt.Rows.Add(14, "5-Boxes");
            dt.Rows.Add(15, "5-Quarters");
            dt.Rows.Add(16, "5-Ratings");
            return dt;
        }

        #endregion        

        #region Pivot Grid Settings

        /// <summary>
        /// Add the Rows and Columns for pivotGrid
        /// </summary>
        private void settings()
        {
            pivotGridControl1.TableModel.BeginUpdate();
            // Adding ItemSource to the Control
            pivotGridControl1.ItemSource = ProductSalesData.GetSalesData();

            // Adding PivotRows to the Control
            pivotGridControl1.PivotRows.Add(new PivotItem { FieldMappingName = "Product", TotalHeader = "Total" });

            pivotGridControl1.PivotRows.Add(new PivotItem { FieldMappingName = "Date", TotalHeader = "Total" });

            // Adding PivotColumns to the Control
            pivotGridControl1.PivotColumns.Add(new PivotItem { FieldMappingName = "Country", TotalHeader = "Total" });

            pivotGridControl1.PivotColumns.Add(new PivotItem { FieldMappingName = "State", TotalHeader = "Total" });

            // Adding PivotCalculations to the Control
            pivotGridControl1.PivotCalculations.Add(new PivotComputationInfo { FieldName = "Amount", Format = "$ #,##0.00", SummaryType = SummaryType.DoubleTotalSum });

            pivotGridControl1.PivotCalculations.Add(new PivotComputationInfo { FieldName = "Quantity", Format = "#,##0" });
            pivotGridControl1.TableModel.EndUpdate(true);
        }
        #endregion

        #region Conditional Formatting Customization

        #region Bitmap Image

        /// <summary>
        /// Set the BitmapImage
        /// </summary>
        private BitMapImageName SetImageName(string str)
        {
            switch (str)
            {
                case "3-TrafficLightsUnrimmed":
                    return BitMapImageName.ThreeTrafficLightsUnrimmed;
                case "3-TrafficLightsrimmed":
                    return BitMapImageName.ThreeTrafficLightsRimmed;
                case "3-SymbolsUnCircled":
                    return BitMapImageName.ThreeSymbolsUnCircled;
                case "3-Symbols":
                    return BitMapImageName.ThreeSymbols;
                case "3-Stars":
                    return BitMapImageName.ThreeStars;
                case "3-Signs":
                    return BitMapImageName.ThreeSigns;
                case "RedToBlack":
                    return BitMapImageName.RedToBlack;
                case "4-Rating":
                    return BitMapImageName.FourRating;
                case "4-ArrowsGray":
                    return BitMapImageName.FourArrowsGray;
                case "4-TrafficLight":
                    return BitMapImageName.FourTrafficLight;
                case "4-ArrowsColored":
                    return BitMapImageName.FourArrowsColored;
                case "5-ArrowsColored":
                    return BitMapImageName.FiveArrowsColored;
                case "5-ArrowsGray":
                    return BitMapImageName.FiveArrowsGray;
                case "5-Boxes":
                    return BitMapImageName.FiveBoxes;
                case "5-Quarters":
                    return BitMapImageName.FiveQuarters;
                case "5-Ratings":
                    return BitMapImageName.FiveRatings;
                default:
                    return BitMapImageName.ThreeTriangle;
            }
        }

        #endregion

        /// <summary>
        /// Set the Default value based on the getting Values
        /// </summary>
        private void SetDefaultValue(string type)
        {
            switch (type)
            {
                case "Three":
                    txtValue1.Text = "10";
                    txtValue2.Text = "20";

                    txtValue3.Enabled = false;
                    txtValue3.Text = string.Empty;
                    txtValue4.Enabled = false;
                    txtValue4.Text = string.Empty;

                    cboValueType3.Enabled = false;
                    cboValueType3.SelectedIndex = -1;
                    cboValueType4.Enabled = false;
                    cboValueType4.SelectedIndex = -1;
                    break;
                case "Four":
                    txtValue1.Text = "10";
                    txtValue2.Text = "20";
                    txtValue3.Text = "30";

                    txtValue3.Enabled = true;
                    cboValueType3.Enabled = true;
                    cboValueType3.SelectedIndex = 1;

                    txtValue4.Enabled = false;
                    txtValue4.Text = string.Empty;

                    cboValueType4.Enabled = false;
                    cboValueType4.SelectedIndex = -1;
                    break;
                case "Five":
                    txtValue1.Text = "10";
                    txtValue2.Text = "17";
                    txtValue3.Text = "25";
                    txtValue4.Text = "30";

                    txtValue3.Enabled = true;
                    txtValue4.Enabled = true;

                    cboValueType3.Enabled = true;
                    cboValueType3.SelectedIndex = 1;

                    cboValueType4.Enabled = true;
                    cboValueType4.SelectedIndex = 1;
                    break;
            }
        }

        /// <summary>
        /// Select the Image
        /// </summary>
        /// <param name="val"></param>
        private void imageSelection(int val)
        {
            if (!load)
                cboRule1ImageName.TextBox.Text = grdDropDown.SelectedItem.ToString();
            load = false;
            if (val <= 7)
                SetDefaultValue("Three");
            if (val <= 12 && val > 7)
                SetDefaultValue("Four");
            if (val > 12)
                SetDefaultValue("Five");
        }

        /// <summary>
        /// Set the Format based on getting value
        /// </summary>>
        private RuleType SetRuleType(string str)
        {
            switch (str)
            {
                case "Format all value cells based on certain criteria":
                    return RuleType.FormatOnlyCellsThatContain;
                case "Format top or bottom ranked value cells":
                    return RuleType.FormatTopOrBottomRankedValues;
                case "Format only value cells containing above or below average":
                    return RuleType.FormatOnlyValuesThatAreAboveOrBelowAverage;
                case "Format only unique or duplicate value cells":
                    return RuleType.FormatOnlyUniqueOrDuplicateValues;
                default:
                    return RuleType.FormatAllCellsBasedOnTheirValues;
            }
        }

        /// <summary>
        /// Set the predicate type
        /// </summary>
        private PredicateType SetPredicateType(string predicate)
        {
            switch (predicate)
            {
                case "Or":
                    return PredicateType.Or;
                default:
                    return PredicateType.And;
            }
        }

        /// <summary>
        /// set the format value based on Rank type
        /// </summary>
        private FormateValuesRankType SetFormateValuesRankType(string FormateRankType)
        {
            switch (FormateRankType)
            {
                case "Bottom":
                    return FormateValuesRankType.Bottom;
                default:
                    return FormateValuesRankType.Top;
            }
        }

        /// <summary>
        /// Set the ConditionalType
        /// </summary>
        private PivotGridDataConditionType SetConditionalType(string conditional)
        {
            switch (conditional)
            {
                case "NotEquals":
                    return PivotGridDataConditionType.NotEquals;
                case "LessThan":
                    return PivotGridDataConditionType.LessThan;
                case "LessThanOrEqual":
                    return PivotGridDataConditionType.LessThanOrEqual;
                case "GreaterThan":
                    return PivotGridDataConditionType.GreaterThan;
                case "GreaterThanOrEqual":
                    return PivotGridDataConditionType.GreaterThanOrEqual;
                case "Between":
                    return PivotGridDataConditionType.Between;
                default:
                    return PivotGridDataConditionType.Equals;
            }
        }

        /// <summary>
        /// Set the Format to Selected Average Value Type
        /// </summary>
        private FormateSelectedAverageValueType SetFormateSelectedAverageValueType(string FormateSelectedAverageValue)
        {
            switch (FormateSelectedAverageValue)
            {
                case "Above":
                    return FormateSelectedAverageValueType.Above;
                case "Below":
                    return FormateSelectedAverageValueType.Below;
                case "EqualOrBelow":
                    return FormateSelectedAverageValueType.EqualOrBelow;
                default:
                    return FormateSelectedAverageValueType.EqualOrAbove;
            }
        }

        /// <summary>
        /// Set the format for all type
        /// </summary>
        private FormatAllType SetFormatAllType(string FormatType)
        {
            switch (FormatType)
            {
                case "Duplicate":
                    return FormatAllType.Duplicate;
                default:
                    return FormatAllType.Unique;
            }
        }

        #endregion

        #region Event Handlers

        /// <summary>
        /// Load the Combo box based RowIndex
        /// </summary>
        void Grid1_Click(object sender, EventArgs e)
        {
            switch (grdRuleType.Grid.CurrentCell.RowIndex)
            {
                case 1:
                    loadRule1Combobox();
                    break;
                case 2:
                    loadRule2Combobox();
                    break;
                case 3:
                    loadRule3Combobox();
                    break;
                case 4:
                    loadRule4Combobox();
                    break;
                case 5:
                    loadRule5Combobox();
                    break;
            }
        }

        /// <summary>
        /// Make the image selection based on row index
        /// </summary>
        void Grid_Click(object sender, EventArgs e)
        {
            GridCurrentCell cc = grdDropDown.Grid.CurrentCell;
            if (grdDropDown.SelectedIndex != -1)
                imageSelection(cc.RowIndex);
            else
                cboRule1ImageName.TextBox.Text = String.Empty;
            cboRule1ImageName.PopupContainer.HidePopup(PopupCloseType.Done);
        }

        /// <summary>
        /// Load the form for Setting the Grid
        /// </summary>
        void Form1_Load(object sender, EventArgs e)
        {
            grdDropDown.BeginUpdate();
            grdDropDown.DataSource = CreateTable();
            grdDropDown.DisplayMember = "Name";
            grdDropDown.ValueMember = "Id";
            grdDropDown.SelectionMode = SelectionMode.One;
            grdDropDown.ShowColumnHeader = false;
            grdDropDown.FillLastColumn = true;
            grdDropDown.BorderStyle = BorderStyle.FixedSingle;
            grdDropDown.ThemesEnabled = false;
            grdDropDown.Grid.VerticalThumbTrack = true;

            grdDropDown.Grid.DrawCellDisplayText += Grid_DrawCellDisplayText;
            grdDropDown.EndUpdate();
            grdDropDown.Grid.QueryCellInfo += Grid_QueryCellInfo;

            DataTable dtRuleType = new DataTable();
            dtRuleType.Columns.Add("RuleType");
            dtRuleType.Rows.Add("Format all value cells based on their value range");
            dtRuleType.Rows.Add("Format all value cells based on certain criteria");
            dtRuleType.Rows.Add("Format top or bottom ranked value cells");
            dtRuleType.Rows.Add("Format only value cells containing above or below average");
            dtRuleType.Rows.Add("Format only unique or duplicate value cells");

            grdRuleType.DataSource = dtRuleType;
            grdRuleType.DisplayMember = "RuleType";
            grdRuleType.SelectionMode = SelectionMode.One;
            grdRuleType.ShowColumnHeader = false;
            grdRuleType.FillLastColumn = true;
            grdRuleType.BorderStyle = BorderStyle.FixedSingle;
            grdRuleType.ThemesEnabled = false;
            grdRuleType.Grid.VerticalThumbTrack = true;

            // default selection
            grdRuleType.Grid.Model.Selections.Add(GridRangeInfo.Cell(1, 1));
            loadRule1Combobox();
            imageSelection(5);

            cboRule2SummaryElement.SelectedIndex = 0;
            cboRule1ImageName.TextBox.Text = "3-Triangle";

            ApplyConditionalFormat();
        }

        /// <summary>
        /// Set the Background image based on the index
        /// </summary>
        void Grid_QueryCellInfo(object sender, GridQueryCellInfoEventArgs e)
        {
            if (e.RowIndex == 1)
                e.Style.BackgroundImage = imageList1.Images[0];
            else if (e.RowIndex == 2)
                e.Style.BackgroundImage = imageList1.Images[1];
            else if (e.RowIndex == 3)
                e.Style.BackgroundImage = imageList1.Images[2];
            else if (e.RowIndex == 4)
                e.Style.BackgroundImage = imageList1.Images[3];
            else if (e.RowIndex == 5)
                e.Style.BackgroundImage = imageList1.Images[4];
            else if (e.RowIndex == 6)
                e.Style.BackgroundImage = imageList1.Images[5];
            else if (e.RowIndex == 7)
                e.Style.BackgroundImage = imageList1.Images[6];
            else if (e.RowIndex == 8)
                e.Style.BackgroundImage = imageList1.Images[7];
            else if (e.RowIndex == 9)
                e.Style.BackgroundImage = imageList1.Images[8];
            else if (e.RowIndex == 10)
                e.Style.BackgroundImage = imageList1.Images[9];
            else if (e.RowIndex == 11)
                e.Style.BackgroundImage = imageList1.Images[10];
            else if (e.RowIndex == 12)
                e.Style.BackgroundImage = imageList1.Images[11];
            else if (e.RowIndex == 13)
                e.Style.BackgroundImage = imageList1.Images[12];
            else if (e.RowIndex == 14)
                e.Style.BackgroundImage = imageList1.Images[13];
            else if (e.RowIndex == 15)
                e.Style.BackgroundImage = imageList1.Images[14];
            else if (e.RowIndex == 16)
                e.Style.BackgroundImage = imageList1.Images[15];

            e.Style.BackgroundImageMode = GridBackgroundImageMode.Normal;

        }

        /// <summary>
        /// Set the Display text
        /// </summary>
        void Grid_DrawCellDisplayText(object sender, GridDrawCellDisplayTextEventArgs e)
        {
            e.DisplayText = string.Empty;
        }

        /// <summary>
        /// Set the  value to SelectedIndex for All the combobox1
        /// </summary>
        private void loadRule1Combobox()
        {
            cboRule2predicateType.SelectedIndex = -1;
            cboRule2ConditionType.SelectedIndex = -1;
            cboRule2SummaryElement.SelectedIndex = -1;
            cboRule3FormatRankType.SelectedIndex = -1;
            cboRule3SummaryElement.SelectedIndex = -1;
            cboRule4FormatValueType.SelectedIndex = -1;
            cboRule4SummaryElement.SelectedIndex = -1;
            cboRule5FormatAllType.SelectedIndex = -1;
            cboRule5SummaryElement.SelectedIndex = -1;
            cboRule1FormatStyle.SelectedIndex = 0;
            cboRule1SummaryElement.SelectedIndex = 0;

            pnlRule5.Visible = false;
            pnlRule4.Visible = false;
            pnlRule3.Visible = false;
            pnlRule2.Visible = false;
            pnlRule2Value.Visible = false;
            pnlRule1.Visible = true;
            pnlRule1Value.Visible = true;
        }

        /// <summary>
        /// Set the  value to SelectedIndex for All the combobox2
        /// </summary>
        private void loadRule2Combobox()
        {
            cboRule1FormatStyle.SelectedIndex = -1;
            cboRule1SummaryElement.SelectedIndex = -1;
            cboRule4FormatValueType.SelectedIndex = -1;
            cboRule4SummaryElement.SelectedIndex = -1;
            cboRule5FormatAllType.SelectedIndex = -1;
            cboRule5SummaryElement.SelectedIndex = -1;
            cboRule3FormatRankType.SelectedIndex = -1;
            cboRule3SummaryElement.SelectedIndex = -1;
            cboRule2predicateType.SelectedIndex = 0;
            cboRule2ConditionType.SelectedIndex = 0;
            cboRule2SummaryElement.SelectedIndex = 0;

            pnlRule5.Visible = false;
            pnlRule4.Visible = false;
            pnlRule3.Visible = false;
            pnlRule2.Visible = true;
            pnlRule2Value.Visible = true;
            pnlRule1.Visible = false;
            pnlRule1Value.Visible = false;
        }

        /// <summary>
        /// Set the  value to SelectedIndex for All the combobox3
        /// </summary>
        private void loadRule3Combobox()
        {
            cboRule1FormatStyle.SelectedIndex = -1;
            cboRule1SummaryElement.SelectedIndex = -1;
            cboRule2predicateType.SelectedIndex = -1;
            cboRule2ConditionType.SelectedIndex = -1;
            cboRule2SummaryElement.SelectedIndex = -1;
            cboRule4FormatValueType.SelectedIndex = -1;
            cboRule4SummaryElement.SelectedIndex = -1;
            cboRule5FormatAllType.SelectedIndex = -1;
            cboRule5SummaryElement.SelectedIndex = -1;
            cboRule3FormatRankType.SelectedIndex = 0;
            cboRule3SummaryElement.SelectedIndex = 0;

            pnlRule5.Visible = false;
            pnlRule4.Visible = false;
            pnlRule3.Visible = true;
            pnlRule2.Visible = false;
            pnlRule2Value.Visible = false;
            pnlRule1.Visible = false;
            pnlRule1Value.Visible = false;
        }

        /// <summary>
        /// Set the  value to SelectedIndex for All the combobox5
        /// </summary>
        private void loadRule5Combobox()
        {
            cboRule1FormatStyle.SelectedIndex = -1;
            cboRule1SummaryElement.SelectedIndex = -1;
            cboRule2predicateType.SelectedIndex = -1;
            cboRule2ConditionType.SelectedIndex = -1;
            cboRule2SummaryElement.SelectedIndex = -1;
            cboRule3FormatRankType.SelectedIndex = -1;
            cboRule3SummaryElement.SelectedIndex = -1;
            cboRule4FormatValueType.SelectedIndex = -1;
            cboRule4SummaryElement.SelectedIndex = -1;
            cboRule5FormatAllType.SelectedIndex = 0;
            cboRule5SummaryElement.SelectedIndex = 0;

            pnlRule5.Visible = true;
            pnlRule4.Visible = false;
            pnlRule3.Visible = false;
            pnlRule2.Visible = false;
            pnlRule2Value.Visible = false;
            pnlRule1.Visible = false;
            pnlRule1Value.Visible = false;
        }

        /// <summary>
        /// Set the value to SelectedIndex for All the combobox4
        /// </summary>
        private void loadRule4Combobox()
        {
            cboRule4FormatValueType.SelectedIndex = 0;
            cboRule4SummaryElement.SelectedIndex = 0;
            cboRule1FormatStyle.SelectedIndex = -1;
            cboRule1SummaryElement.SelectedIndex = -1;
            cboRule2predicateType.SelectedIndex = -1;
            cboRule2ConditionType.SelectedIndex = -1;
            cboRule2SummaryElement.SelectedIndex = -1;
            cboRule5FormatAllType.SelectedIndex = -1;
            cboRule5SummaryElement.SelectedIndex = -1;
            cboRule3FormatRankType.SelectedIndex = -1;
            cboRule3SummaryElement.SelectedIndex = -1;


            pnlRule5.Visible = false;
            pnlRule4.Visible = true;
            pnlRule3.Visible = false;
            pnlRule2.Visible = false;
            pnlRule2Value.Visible = false;
            pnlRule1.Visible = false;
            pnlRule1Value.Visible = false;
        }

        /// <summary>
        /// Initialize the combo box index value
        /// </summary>
        private void CommonCombobox()
        {
            cboValueType1.SelectedIndex = 1;
            cboValueType2.SelectedIndex = 1;
            cboValueType3.SelectedIndex = 1;
            cboValueType4.SelectedIndex = 1;
        }

        private void ApplyConditionalFormat()
        {
            bool isNeedColor = false;
            NewRuleConditionalFormat newRule1 = new NewRuleConditionalFormat();
            string RuleType = grdRuleType.Text;
            newRule1.RuleType = SetRuleType(RuleType);
            double number;
            switch (RuleType)
            {
                case "Format all value cells based on certain criteria":
                    ConditionalFormat form = new ConditionalFormat();
                    form.ConditionType = SetConditionalType(cboRule2ConditionType.SelectedItem.ToString());
                    form.PredicateType = SetPredicateType(cboRule2ConditionType.SelectedItem.ToString());
                    if (!string.IsNullOrEmpty(txtRule2StartValue.Text)
                        && double.TryParse(txtRule2StartValue.Text, out number))
                        form.StartValue = Convert.ToDouble(txtRule2StartValue.Text);
                    if (!string.IsNullOrEmpty(txtRule2EndValue.Text)
                        && double.TryParse(txtRule2EndValue.Text, out number))
                        form.EndValue = Convert.ToDouble(txtRule2EndValue.Text);
                    newRule1.Conditions.Add(form);
                    newRule1.SummaryElement = cboRule2SummaryElement.SelectedItem.ToString();
                    isNeedColor = true;
                    break;
                case "Format top or bottom ranked value cells":
                    newRule1.FormateValuesRankType = SetFormateValuesRankType(cboRule3FormatRankType.SelectedItem.ToString());
                    if (!string.IsNullOrEmpty(txtRule3RankValue.Text)
                        && double.TryParse(txtRule3RankValue.Text, out number))
                        newRule1.RankValue = Convert.ToInt32(Convert.ToDouble(txtRule3RankValue.Text));
                    if (cboRule3SummaryElement.SelectedItem != null)
                        newRule1.SummaryElement = cboRule3SummaryElement.SelectedItem.ToString();
                    isNeedColor = true;
                    break;
                case "Format only value cells containing above or below average":
                    newRule1.FormateSelectedAverageValueType = SetFormateSelectedAverageValueType(cboRule4FormatValueType.SelectedItem.ToString());
                    if (cboRule4SummaryElement.SelectedItem != null)
                        newRule1.SummaryElement = cboRule4SummaryElement.SelectedItem.ToString();
                    isNeedColor = true;
                    break;
                case "Format only unique or duplicate value cells":
                    newRule1.FormatAllType = SetFormatAllType(cboRule5FormatAllType.SelectedItem.ToString());
                    if (cboRule5SummaryElement.SelectedItem != null)
                        newRule1.SummaryElement = cboRule5SummaryElement.SelectedItem.ToString().Trim();
                    isNeedColor = true;
                    break;
                default:
                    if (cboRule1FormatStyle.SelectedIndex == 0)
                        newRule1.FormatStyle = FormatStyle.IconSets;
                    if (cboRule1SummaryElement.SelectedItem != null)
                        newRule1.SummaryElement = cboRule1SummaryElement.SelectedItem.ToString();
                    newRule1.Image = SetImageName(cboRule1ImageName.Text);
                    if (cboValueType1.Enabled)
                    {
                        newRule1.ValueType1 = cboValueType1.SelectedIndex == 0 ? ValueType.Percent : ValueType.Number;
                        newRule1.Value1 = double.Parse(txtValue1.Text);
                    }
                    if (cboValueType2.Enabled)
                    {
                        newRule1.ValueType2 = cboValueType2.SelectedIndex == 0 ? ValueType.Percent : ValueType.Number;
                        newRule1.Value2 = double.Parse(txtValue2.Text);
                    }
                    if (cboValueType3.Enabled)
                    {
                        newRule1.ValueType3 = cboValueType3.SelectedIndex == 0 ? ValueType.Percent : ValueType.Number;
                        newRule1.Value3 = double.Parse(txtValue3.Text);
                    }
                    if (cboValueType4.Enabled)
                    {
                        newRule1.ValueType4 = cboValueType4.SelectedIndex == 0 ? ValueType.Percent : ValueType.Number;
                        newRule1.Value4 = double.Parse(txtValue4.Text);
                    }
                    break;
            }
            PivotGridNewRuleConditionalFormat newRuleFormat1 = new PivotGridNewRuleConditionalFormat();
            newRuleFormat1.NewRuleCollections.Add(newRule1);
            if (isNeedColor)
            {
                newRuleFormat1.PivotCellStyle.BackColor = Color.Red;
                newRuleFormat1.PivotCellStyle.TextColor = Color.White;
            }
            pivotGridControl1.TableControl.NewRuleConditionalFormat.Add(newRuleFormat1);
            pivotGridControl1.TableControl.Refresh(true);
        }

        /// <summary>
        /// Set the values for all the cell
        /// </summary>
        private void buttonAdv1_Click(object sender, EventArgs e)
        {
            pivotGridControl1.TableControl.NewRuleConditionalFormat.Clear();
            ApplyConditionalFormat();
        }

        /// <summary>
        /// Clear the conditional format and refresh the table control
        /// </summary>
        private void buttonAdv2_Click(object sender, EventArgs e)
        {
            pivotGridControl1.TableControl.NewRuleConditionalFormat.Clear();
            pivotGridControl1.TableControl.Refresh(true);
        }

        private void cboRule2ConditionType_SelectedValueChanged(object sender, EventArgs e)
        {
            txtRule2EndValue.Enabled = cboRule2ConditionType.SelectedIndex == 6;
        }

        #endregion
    }
}
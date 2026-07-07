#region Copyright Syncfusion Inc. 2001 - 2018
// Copyright Syncfusion Inc. 2001 - 2018. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion

using System;
using System.Drawing;
using System.Windows.Forms;
using Syncfusion.PivotAnalysis.Base;
using Syncfusion.Windows.Forms;
using Syncfusion.Windows.Forms.Tools;

namespace RowPivotsOnlyDemo
{
    public partial class Form1 : MetroForm
    {
        #region Fields

        private SolidBrush leftRectBrush = new SolidBrush(ColorTranslator.FromHtml("#1BA1E2"));
        private int colorBrushNo;

        #endregion

        #region Constructor

        public Form1()
        {
            InitializeComponent();
            InitializePivotGrid();
        }

        #endregion

        #region Pivot Grid Settings

        /// <summary>
        /// Add the Calculations and Rows for pivot Grid
        /// </summary>
        private void InitializePivotGrid()
        {
            // Adding ItemSource to the Control
            pivotGridControl1.ItemSource = ProductSalesData.GetSalesData();

            pivotGridControl1.RowPivotsOnly = true;

            // Adding PivotRows to the Control
            pivotGridControl1.PivotRows.Add(new PivotItem { FieldMappingName = "Product", TotalHeader = "Total" });
            pivotGridControl1.PivotRows.Add(new PivotItem { FieldMappingName = "State", TotalHeader = "Total" });
            pivotGridControl1.PivotRows.Add(new PivotItem { FieldMappingName = "Date", TotalHeader = "Total" });

            // Adding PivotCalculations to the Control
            pivotGridControl1.PivotCalculations.Add(new PivotComputationInfo { FieldName = "Country" });
            pivotGridControl1.PivotCalculations.Add(new PivotComputationInfo { FieldName = "Amount", Format = "$ ##0.00", SummaryType = SummaryType.DoubleTotalSum });
            pivotGridControl1.PivotCalculations.Add(new PivotComputationInfo { FieldName = "Quantity", Format = @",##0", AllowSort = true });
            pivotGridControl1.PivotCalculations.Add(new PivotComputationInfo { FieldName = "UnitPrice", Format = "$ ##0.00", FieldHeader = "Unit Price" });
            pivotGridControl1.PivotCalculations.Add(new PivotComputationInfo { FieldName = "TotalPrice", Format = "$ ##0.00", FieldHeader = "Total Price" });
            pivotGridControl1.TableControl.DefaultColWidth = 100;
            RowPivotsOnlyApperance();

            //tab key navigation set as false to move the next control
            pivotGridControl1.TableControl.WantTabKey = false;
            pivotGridControl1.TabStop = false;

            pivotGridControl1.AllowRowPivotDrag = checkBox3.Checked;
            pivotGridControl1.ShowPivotTableFieldList = checkBox4.Checked;
            pivotGridControl1.ShowPivotValueChooser = checkBox5.Checked;
        }

        #endregion

        #region Helper Methods

        /// <summary>
        /// Set the appearance for options.
        /// </summary>
        private void RowPivotsOnlyApperance()
        {
            for (int i = 0; i < groupBox1.Controls.Count; i++)
            {
                if (groupBox1.Controls[i] is CheckBoxAdv)
                {
                    CheckBoxAdv checkBox = groupBox1.Controls[i] as CheckBoxAdv;
                    checkBox.MouseEnter += CheckBox_MouseEnter;
                }
            }
            animationPanel.Paint += AnimationPanel_Paint;
        }

        /// <summary>
        /// Animate the text
        /// </summary>
        private void AnimateText()
        {
            for (int x = 0; x < 120; x += 3)
            {
                this.contextLabel1.Location = new Point(this.animationPanel.Location.X - 2 + x, this.animationPanel.Location.Y + 58);
            }
            for (int x = 0; x < 120; x += 3)
            {
                this.contextLabel1.Location = new Point(120 - x, this.animationPanel.Location.Y + 58);
            }
        }

        #endregion

        #region Events Handlers

        /// <summary>
        /// Animate the pivot panel
        /// </summary>
        void AnimationPanel_Paint(object sender, PaintEventArgs e)
        {
            Point loc = animationPanel.Location;
            Pen rectPen = new Pen(Color.LightGray);
            Rectangle rect = new Rectangle(loc.X, loc.Y, 195, 40);
            e.Graphics.DrawRectangle(rectPen, rect);

            Rectangle leftRectBorder = new Rectangle(loc.X, loc.Y, 5, 40);
            e.Graphics.FillRectangle(leftRectBrush, leftRectBorder);

            e.Graphics.FillEllipse(colorBrushNo == 1 ? leftRectBrush : new SolidBrush(Color.LightGray), loc.X + 40, loc.Y + 220, 8, 8);
            e.Graphics.FillEllipse(colorBrushNo == 2 ? leftRectBrush : new SolidBrush(Color.LightGray), loc.X + 50, loc.Y + 220, 8, 8);
            e.Graphics.FillEllipse(colorBrushNo == 3 ? leftRectBrush : new SolidBrush(Color.LightGray), loc.X + 60, loc.Y + 220, 8, 8);
            e.Graphics.FillEllipse(colorBrushNo == 4 ? leftRectBrush : new SolidBrush(Color.LightGray), loc.X + 70, loc.Y + 220, 8, 8);
            e.Graphics.FillEllipse(colorBrushNo == 5 ? leftRectBrush : new SolidBrush(Color.LightGray), loc.X + 80, loc.Y + 220, 8, 8);
        }

        /// <summary>
        /// Animate the pivot when Mouse Enter
        /// </summary>
        void CheckBox_MouseEnter(object sender, EventArgs e)
        {
            AnimateText();
            headerLabel1.Text = ((CheckBoxAdv)sender).Tag.ToString();
            if ((CheckBoxAdv)sender == checkBox1)
            {
                colorBrushNo = 1;
                leftRectBrush.Color = ColorTranslator.FromHtml("#5CBB00");
                contextLabel1.ForeColor = Color.Black;
                contextLabel1.Text = @"Sorting support can be enabled or disabled in RowPivotsOnly mode by using the AllowSort property";
            }
            else if ((CheckBoxAdv)sender == checkBox2)
            {
                colorBrushNo = 2;
                leftRectBrush.Color = ColorTranslator.FromHtml("#00A4E5");
                contextLabel1.ForeColor = Color.Black;
                contextLabel1.Text = @"Filtering support can be enabled or disabled in the PivotCalculation columns of the PivotGrid by using the AllowFilter property";
            }
            else if ((CheckBoxAdv)sender == checkBox3)
            {
                colorBrushNo = 3;
                leftRectBrush.Color = ColorTranslator.FromHtml("#FF4815");
                contextLabel1.ForeColor = Color.Black;
                contextLabel1.Text = @"The PivotCalculation headers has been supported with drag drop operation in RowPivotsOnly mode";
            }
            else if ((CheckBoxAdv)sender == checkBox4)
            {
                colorBrushNo = 4;
                leftRectBrush.Color = ColorTranslator.FromHtml("#FFB800");
                contextLabel1.ForeColor = Color.Black;
                contextLabel1.Text = @"PivotSchemaDesginer has been customized as per the RowPivotsOnly mode, i.e: PivotColumns and ReportFilter field will not be customizable";
            }
            else if ((CheckBoxAdv)sender == checkBox5)
            {
                colorBrushNo = 5;
                leftRectBrush.Color = ColorTranslator.FromHtml("#6BD4E7");
                contextLabel1.ForeColor = Color.Black;
                contextLabel1.Text = @"PivotValueChooser will display the PivotCalculation columns in a popup, where the necessary columns can be made shown/hidden";
            }
            animationPanel.Refresh();
        }

        // To handle the sorting for pivot grid 
        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            pivotGridControl1.AllowSorting = checkBox1.Checked;
        }

        // To handle the filtering for pivot grid
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            pivotGridControl1.TableControl.AllowRowPivotFiltering = checkBox2.Checked;
            pivotGridControl1.TableControl.Refresh();
        }

        // To handle the pivot drag and drop
        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            pivotGridControl1.AllowRowPivotDrag = checkBox3.Checked;
        }

        // To handle the pivot table field list display
        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            pivotGridControl1.ShowPivotTableFieldList = checkBox4.Checked;
        }

        // To handle the pivot vale chooser
        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            pivotGridControl1.ShowPivotValueChooser = checkBox5.Checked;
        }

        #endregion
    }
}
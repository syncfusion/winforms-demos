#region Copyright Syncfusion Inc. 2001 - 2018
// Copyright Syncfusion Inc. 2001 - 2018. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion

using System;
using Syncfusion.PivotAnalysis.Base;
using Syncfusion.Windows.Forms.Grid;
using Syncfusion.Windows.Forms;
using Syncfusion.Windows.Forms.PivotAnalysis;

namespace CellSelectionDemo
{
    public partial class Form1 : MetroForm
    {
        #region Constructor

        public Form1()
        {
            InitializeComponent();
            this.InitializePivotGrid();
        }

        #endregion

        #region Pivot Grid Settings

        /// <summary>
        /// Grid Settings for better look and feel
        /// </summary>
        private void InitializePivotGrid()
        {
            // Adding ItemSource to the Control
            this.pivotGridControl1.ItemSource = ProductSalesData.GetSalesData();

            // Adding PivotRows to the Control
            this.pivotGridControl1.PivotRows.Add(new PivotItem { FieldMappingName = "Product", TotalHeader = "Total" });

            this.pivotGridControl1.PivotRows.Add(new PivotItem { FieldMappingName = "Date", TotalHeader = "Total" });

            // Adding PivotColumns to the Control
            this.pivotGridControl1.PivotColumns.Add(new PivotItem { FieldMappingName = "Country", TotalHeader = "Total" });

            this.pivotGridControl1.PivotColumns.Add(new PivotItem { FieldMappingName = "State", TotalHeader = "Total" });

            // Adding PivotCalculations to the Control
            this.pivotGridControl1.PivotCalculations.Add(new PivotComputationInfo { FieldName = "Amount", Format = "$ #,##0.00", SummaryType = SummaryType.DoubleTotalSum });

            this.pivotGridControl1.PivotCalculations.Add(new PivotComputationInfo { FieldName = "Quantity", Format = "#,##0" });

            this.pivotGridControl1.TableControl.SelectionChanged += TableControl_SelectionChanged;

            //tab key navigation set as false to move the next control
            this.pivotGridControl1.TableControl.WantTabKey = false;
            this.pivotGridControl1.TableModel.Options.AllowSelection = GridSelectionFlags.Any;
        }

        #endregion

        #region Event Handlers

        /// <summary>
        /// Occurs when cell selection gets changed.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="Syncfusion.Windows.Forms.Grid.GridSelectionChangingEventArgs"/> that contains the event data.</param>
        private void TableControl_SelectionChanged(object sender, PivotGridSelectionChangedEventArgs e)
        {
            if (listBox1.Items.Count > 0)
                listBox1.Items.Clear();
            if (e.SelectedItems != null)
            {
                for (int i = 0; i < e.SelectedItems.Count; i++)
                {
                    listBox1.Items.Add(e.SelectedItems[i].ToString());
                }
            }
        }

        /// <summary>
        /// Set the selection like a Excel
        /// </summary>
        private void checkBox2_CheckStateChanged(object sender, EventArgs e)
        {
            this.pivotGridControl1.TableModel.Options.ExcelLikeSelectionFrame = checkBox2.Checked;
            if (checkBox2.Checked)
            {
                checkBox1.Checked = true;
            }
            else if (!checkBox1.Checked)
            {
                this.pivotGridControl1.TableModel.Selections.Clear();
            }
        }

        /// <summary>
        /// Handling the Grid Selection
        /// </summary>
        private void checkBox1_CheckStateChanged(object sender, EventArgs e)
        {
            checkBox2.Enabled = checkBox1.Checked;
            if (checkBox1.Checked)
                this.pivotGridControl1.TableModel.Options.AllowSelection = GridSelectionFlags.Any;
            else
            {
                this.pivotGridControl1.TableModel.Options.AllowSelection = GridSelectionFlags.None;
                this.pivotGridControl1.TableModel.Selections.Clear();
            }
        }

        #endregion
    }
}
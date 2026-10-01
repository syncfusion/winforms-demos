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
using System.Text;
using System.Windows.Forms;

using Syncfusion.Windows.Forms.Grid;
using Syncfusion.Windows.Forms;
using Syncfusion.GridHelperClasses;
using DemoCommon.Grid;

namespace GridFindReplace
{
    public partial class Form1 : GridDemoForm
    {
        #region API Definition
        GridFindReplaceDialogSink frDialog;
        GridFindReplaceEventArgs frEvents;
        GridFindTextOptions options;
        GridHighlightSearchText highlighttext = new GridHighlightSearchText();
        object locInfo;
        #endregion

        #region Constructor
        public Form1()
        {
            InitializeComponent();
            if (DpiAware.GetCurrentDpi() > 96)
            {
                this.CaptionBarHeight = (int)DpiAware.LogicalToDeviceUnits(this.CaptionBarHeight);
            }
            SampleCustomization();
            this.gridControl1.TableStyle.WrapText = false;
            this.colorPickerButton3.ColorSelected += new EventHandler(colorPickerButton3_ColorSelected);
            this.checkBox1.CheckStateChanged += new EventHandler(checkBox1_CheckStateChanged);
            colorPickerButton3.Enabled = false;
        }
        #endregion

        #region Sample Customization
        /// <summary>
        /// Sample customization for implementing the Find and Replace dialog
        /// </summary>
        private void SampleCustomization()
        {
            EnableControls(false);
            this.gridControl1.ColCount = 20;
            //Populate the grid control
            Random r = new Random();
            for (int i = 1; i <= gridControl1.RowCount; i++)
                for (int j = 1; j <= gridControl1.ColCount; j++)
                    gridControl1[i, j].Text = r.Next(100, 150).ToString();

            //Setup FindReplace dialog
            frDialog = new GridFindReplaceDialogSink(gridControl1);

            //Initial Settings
            options = GridFindTextOptions.None;
            cmbOptions.SelectedIndex = 2;
            this.gridControl1.ForceCurrentCellMoveTo = true;
            this.gridControl1.ThemesEnabled = true;
            this.gridControl1.CurrentCell.MoveTo(1, 1);

            //tab key navigation set as false to move the next control
            this.gridControl1.WantTabKey = false;
        }
        #endregion

        #region Event Handlers
        void checkBox1_CheckStateChanged(object sender, EventArgs e)
        {
            if (checkBox1.CheckState == CheckState.Checked)
            {
                chkMatchCase.Enabled = false;
                chkMatchWholeCell.Enabled = false;
                chkSearchUp.Enabled = false;
                cmbOptions.Enabled = false;
                colorPickerButton3.Enabled = true;
            }
            else
            {
                chkMatchCase.Enabled = true;
                chkMatchWholeCell.Enabled = true;
                chkSearchUp.Enabled = true;
                cmbOptions.Enabled = true;
                colorPickerButton3.Enabled = false;
            }
        }

        void colorPickerButton3_ColorSelected(object sender, EventArgs e)
        {
            highlighttext.HighlightColor = colorPickerButton3.SelectedColor;
            this.gridControl1.Refresh();
        }

        //FindNext
        private void btnFindNext_Click(object sender, EventArgs e)
        {
            gridControl1.Selections.Clear();

            if (cmbSearch.Text != "")
            {
                AddToSearchedList(cmbSearch.Text);

                SetOptions();
                locInfo = GridRangeInfo.Table();
                clearHighlight();
                frEvents = new GridFindReplaceEventArgs(cmbSearch.Text, "", options, locInfo);
                frDialog.Find(frEvents);

            }
            this.gridControl1.Refresh();
        }

        //FindAll - Loops through the cells in the grid and highlights all the values 
        //that match with the given search string.
        private void btnFindAll_Click(object sender, EventArgs e)
        {
            if (cmbSearch.Text != null)
            {
                AddToSearchedList(cmbSearch.Text);

                SetOptions();
                locInfo = GridRangeInfo.Table();
                GridRangeInfo selRange = GridRangeInfo.Empty;
                int rowIndex, colIndex;
                if ((options & GridFindTextOptions.SelectionOnly) != GridFindTextOptions.None)
                    selRange = gridControl1.Selections.Ranges.ActiveRange;

                else if ((options & GridFindTextOptions.ColumnOnly) != GridFindTextOptions.None)
                    selRange = GridRangeInfo.Col(gridControl1.CurrentCell.ColIndex);

                else if ((options & GridFindTextOptions.WholeTable) != GridFindTextOptions.None)
                    selRange = GridRangeInfo.Cells(1, 1, gridControl1.RowCount, gridControl1.ColCount);

                clearHighlight();

                int startTop = selRange.Top;
                int startLeft = selRange.Left;

                do
                {
                    GridStyleInfo style = gridControl1[startTop, startLeft];
                    GridCellRendererBase renderer = gridControl1.CellRenderers[style.CellType];
                    if (renderer.FindText(cmbSearch.Text, startTop, startLeft, options, true))
                    {
                        gridControl1.CurrentCell.GetCurrentCell(out rowIndex, out colIndex);
                        gridControl1[rowIndex, colIndex].BackColor = Color.Orange;
                    }
                } while (GridFindReplaceDialogSink.GetNextCell(selRange, ref startTop, ref startLeft, false, chkSearchUp.Checked));
            }
            this.highlighttext.HighlightText = "";
            this.gridControl1.Refresh();
            this.checkBox1.CheckState = CheckState.Unchecked;
        }

        //Replace
        private void btnReplace_Click(object sender, EventArgs e)
        {
            if (cmbSearch.Text != "" && cmbReplace.Text != "")
            {
                AddToSearchedList(cmbSearch.Text);
                SetOptions();
                locInfo = GridRangeInfo.Table();
                frEvents = new GridFindReplaceEventArgs(cmbSearch.Text, cmbReplace.Text, options, locInfo);
                frDialog.Replace(frEvents);
            }
        }

        //ReplaceAll
        private void btnReplaceAll_Click(object sender, EventArgs e)
        {
            if (cmbSearch.Text != "" && cmbReplace.Text != "")
            {
                AddToSearchedList(cmbSearch.Text);
                SetOptions();
                locInfo = GridRangeInfo.Table();
                frEvents = new GridFindReplaceEventArgs(cmbSearch.Text, cmbReplace.Text, options, locInfo);
                frDialog.ReplaceAll(frEvents);
                clearHighlight();
            }
            else
                MessageBox.Show("Search/Replace value is missing");
        }

        private void cmbSearch_TextChanged(object sender, EventArgs e)
        {
            if (cmbSearch.Text != "")
            {
                EnableControls(true);
                if (checkBox1.CheckState == CheckState.Checked)
                {
                    this.highlighttext.HighlightText = cmbSearch.Text;
                    this.colorPickerButton3.SelectedAsBackcolor = true;
                    this.gridControl1.Refresh();
                }
            }
            else
            {
                EnableControls(false);
                this.highlighttext.HighlightText = "";
                this.colorPickerButton3.BackColor = Color.Empty;
                this.gridControl1.Refresh();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.CheckState == CheckState.Checked)
            {
                highlighttext.WireGrid(this.gridControl1);
                highlighttext.HighlightText = cmbSearch.Text;
                highlighttext.HighlightColor = Color.Yellow;
                colorPickerButton3.SelectedColor = highlighttext.HighlightColor;
                this.gridControl1.Refresh();
            }
            else
            {
                highlighttext.HighlightText = "";
                colorPickerButton3.SelectedColor = Color.White;
                this.gridControl1.Refresh();
            }
        }
        #endregion

        #region Helper methods

        //Setup the search options.
        private void SetOptions()
        {
            options = GridFindTextOptions.None;
            if (chkMatchCase.Checked)
                options = GridFindTextOptions.MatchCase;
            if (chkMatchWholeCell.Checked)
                options |= GridFindTextOptions.MatchWholeCell;
            if (chkSearchUp.Checked)
                options |= GridFindTextOptions.SearchUp;

            switch (cmbOptions.SelectedIndex)
            {
                case 0: options |= GridFindTextOptions.ColumnOnly; break;
                case 1: options |= GridFindTextOptions.SelectionOnly; break;
                case 2: options |= GridFindTextOptions.WholeTable; break;
            }
        }

        private void EnableControls(bool enable)
        {
            this.cmbReplace.Enabled = enable;
            btnFindNext.Enabled = enable;
            btnFindAll.Enabled = enable;
            btnReplace.Enabled = enable;
            btnReplaceAll.Enabled = enable;
            chkMatchCase.Enabled = enable;
            chkMatchWholeCell.Enabled = enable;
            chkSearchUp.Enabled = enable;
            lblReplaceWith.Enabled = enable;
            cmbOptions.Enabled = enable;
            checkBox1.Enabled = enable;
        }

        //Set the backcolor of the cells being highlighted to their original color.
        private void clearHighlight()
        {
            for (int i = 1; i <= gridControl1.RowCount; i++)
                for (int j = 1; j <= gridControl1.ColCount; j++)
                    gridControl1[i, j].BackColor = SystemColors.Window;
        }

        //Keep track of the search strings being entered.
        private void AddToSearchedList(string txt)
        {
            if (!cmbSearch.Items.Contains(txt))
                cmbSearch.Items.Insert(0, txt);
        }
        #endregion

    }
}
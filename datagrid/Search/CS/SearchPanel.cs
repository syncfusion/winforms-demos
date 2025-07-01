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
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Syncfusion.WinForms.DataGrid;
using Syncfusion.WinForms.DataGrid.Enums;

namespace Search
{
    public partial class SearchPanel : UserControl
    {
        private SfDataGrid sfDataGrid;
        public SearchPanel(SfDataGrid sfDataGrid)
        {
            InitializeComponent();
            this.sfDataGrid = sfDataGrid;
            cmbSearchType.DataSource = Enum.GetValues(typeof(SearchType));
            WireEvents();
        }

        private void WireEvents()
        {
            txtSearchText.TextChanged += txtSearchText_TextChanged;
            btnNext.Click += btnNext_Click;
            btnPrevious.Click += btnPrevious_Click;
            chkApplyFilter.CheckedChanged += chkApplyFilter_CheckedChanged;
            chkMatchCase.CheckedChanged += chkMatchCase_CheckedChanged;
            chkSearchColumn.CheckedChanged += chkSearchColumn_CheckedChanged;
            chkHighlightSearchText.CheckedChanged += chkHighlightSearchText_CheckedChanged;
            cmbSearchType.SelectedValueChanged += cmbSearchType_SelectedValueChanged;
        }

        void chkMatchCase_CheckedChanged(object sender, EventArgs e)
        {
            sfDataGrid.SearchController.AllowCaseSensitiveSearch = chkMatchCase.Checked;
            sfDataGrid.TableControl.Invalidate();
        }

        void chkApplyFilter_CheckedChanged(object sender, EventArgs e)
        {
            sfDataGrid.SearchController.AllowFiltering = chkApplyFilter.Checked;
            sfDataGrid.TableControl.Invalidate();
        }

        void btnPrevious_Click(object sender, EventArgs e)
        {
            sfDataGrid.SearchController.FindPrevious(txtSearchText.Text);
        }

        void btnNext_Click(object sender, EventArgs e)
        {
            sfDataGrid.SearchController.FindNext(txtSearchText.Text);
        }

        void txtSearchText_TextChanged(object sender, EventArgs e)
        {
            sfDataGrid.SearchController.Search(txtSearchText.Text);
        }

        private void chkSearchColumn_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSearchColumn.Checked)
                sfDataGrid.SearchController.SearchColumns.Add("ProductName");
            else
                sfDataGrid.SearchController.SearchColumns.Clear();
            sfDataGrid.TableControl.Invalidate();
        }

        private void chkHighlightSearchText_CheckedChanged(object sender, EventArgs e)
        {
            sfDataGrid.SearchController.AllowHighlightSearchText = chkHighlightSearchText.Checked;
            sfDataGrid.TableControl.Invalidate();
        }

        void cmbSearchType_SelectedValueChanged(object sender, EventArgs e)
        {
            sfDataGrid.SearchController.SearchType = (SearchType)cmbSearchType.SelectedValue;
            sfDataGrid.TableControl.Invalidate();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }
    }
}

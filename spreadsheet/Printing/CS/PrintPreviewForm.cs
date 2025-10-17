#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Syncfusion.Windows.Forms;
using Syncfusion.Windows.Forms.PdfViewer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PrintingDemo
{
    public partial class PrintPreviewForm : MetroForm
    {
        public PrintPreviewForm()
        {
            InitializeComponent();
            if (DpiAware.GetCurrentDpi() > 96)
            {
                this.CaptionBarHeight = (int)DpiAware.LogicalToDeviceUnits(this.CaptionBarHeight);
            }
        }
        private Timer pageTimer = new Timer();
        void PrintPreviewForm_Load(object sender, System.EventArgs e)
        {
            pdfDocumentView1.CurrentPageChanged+=new PdfDocumentView.CurrentPageChangedEventHandler(pdfDocumentView1_CurrentPageChanged);
            LoadDocumentToPdfViewer();
        }

        private void pdfDocumentView1_CurrentPageChanged(object sender, EventArgs args)
        {
            int pageIndex = (sender as PdfDocumentView).CurrentPageIndex;
            this.txtCurrentPageIndex.Text = pageIndex.ToString();
            EnablePagination();
        }

       void pageTimer_Tick(object sender, EventArgs e)
        {
            if (pdfDocumentView1.PageCount > 1)
            {
                this.btnGoToNextPage.Enabled = true;
                this.btnGoToLastPage.Enabled = true;
                pageTimer.Stop();
            }
        }
       
        /// <summary>
        /// Assigning page index.
        /// </summary>
        void docViewer_CurrentPageChanged(object sender, EventArgs args)
        {
            int pageIndex = (sender as PdfDocumentView).CurrentPageIndex;
            this.txtCurrentPageIndex.Text = pageIndex.ToString();
            EnablePagination();
        }

        /// <summary>
        /// Enable or disable paginate buttons.
        /// </summary>
        private void EnablePagination()
        {
            int pageIndex = pdfDocumentView1.CurrentPageIndex;
            this.btnGoToNextPage.Enabled = pdfDocumentView1.CanGoToNextPage;
            this.btnGoToLastPage.Enabled = pdfDocumentView1.CanGoToLastPage;
            this.btnGoToPreviousPage.Enabled = pdfDocumentView1.CanGoToPreviousPage;
            this.btnGoToFirstPage.Enabled = pdfDocumentView1.CanGoToFirstPage;
        }
        #region Event handler

        /// <summary>
        /// On currentPageIndex Keydown
        /// </summary>
        void txtCurrentPageIndex_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                int index;
                if (!string.IsNullOrEmpty(txtCurrentPageIndex.Text))
                {
                    int.TryParse(txtCurrentPageIndex.Text, out index);
                    pdfDocumentView1.GoToPageAtIndex(index);
                }
                txtCurrentPageIndex.Text = pdfDocumentView1.CurrentPageIndex.ToString();
            }
        }

        /// <summary>
        /// On CurrentPageIndex Click
        /// </summary>
        void txtCurrentPageIndex_Click(object sender, System.EventArgs e)
        {
            txtCurrentPageIndex.SelectAll();
        }

        /// <summary>
        /// Handles next page navigation.
        /// </summary>
        private void btnGoToNextPage_Click(object sender, EventArgs e)
        {
            if (pdfDocumentView1.CanGoToNextPage)
                pdfDocumentView1.GoToNextPage();
        }

        /// <summary>
        /// Handles previous page navigation.
        /// </summary>
        private void btnGoToPreviousPage_Click(object sender, EventArgs e)
        {
            if (pdfDocumentView1.CanGoToPreviousPage)
                pdfDocumentView1.GoToPreviousPage();
        }

        /// <summary>
        /// Handles last page navigation.
        /// </summary>
        private void btnGoToLastPage_Click(object sender, EventArgs e)
        {
            if (pdfDocumentView1.CanGoToLastPage)
                pdfDocumentView1.GoToLastPage();
        }

        /// <summary>
        /// Handles first page navigation.
        /// </summary>
        private void btnGoToFirstPage_Click(object sender, EventArgs e)
        {
            if (pdfDocumentView1.CanGoToFirstPage)
                pdfDocumentView1.GoToFirstPage();
        }

        /// <summary>
        /// Handles zoom.
        /// </summary>
        private void cmbCurrentZoomLevel_SelectedIndexChanged(object sender, EventArgs e)
        {
            int ZoomLevel = Convert.ToInt32(cmbCurrentZoomLevel.SelectedItem.ToString().Replace("%", ""));
            pdfDocumentView1.ZoomTo(ZoomLevel);
        }

        /// <summary>
        /// Handles zoom in.
        /// </summary>
        private void btnZoomIn_Click(object sender, EventArgs e)
        {
            if (cmbCurrentZoomLevel.SelectedIndex != 0)
                cmbCurrentZoomLevel.SelectedIndex = cmbCurrentZoomLevel.SelectedIndex - 1;
        }

        /// <summary>
        /// Handles zoom out.
        /// </summary>
        private void btnZoomOut_Click(object sender, EventArgs e)
        {
            if (cmbCurrentZoomLevel.SelectedIndex != cmbCurrentZoomLevel.Items.Count - 1)
                cmbCurrentZoomLevel.SelectedIndex = cmbCurrentZoomLevel.SelectedIndex + 1;
        }

        /// <summary>
        /// Prints the document.
        /// </summary>
        private void btnPrint_Click(object sender, EventArgs e)
        {
            PrintDialog dialog = new PrintDialog();

            int pageCount = pdfDocumentView1.PageCount;
            dialog.AllowPrintToFile = true;
            dialog.AllowSomePages = true;
            dialog.PrinterSettings.FromPage = 1;
            dialog.PrinterSettings.ToPage = pageCount;
            dialog.PrinterSettings.MaximumPage = pageCount;
            dialog.PrinterSettings.MinimumPage = 1;

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                dialog.Document = pdfDocumentView1.PrintDocument;
                dialog.Document.Print();
            }
        }

      /// <summary>
        /// Handles the fit page
        /// </summary>
        private void FitPage_Click(object sender, EventArgs e)
        {
            pdfDocumentView1.ZoomTo(ZoomMode.FitPage);
            cmbCurrentZoomLevel.Text = pdfDocumentView1.ZoomPercentage.ToString() + "%";
        }

        /// <summary>
        /// Handles the fit width
        /// </summary>
        private void FitWidth_Click(object sender, EventArgs e)
        {
            pdfDocumentView1.ZoomTo(ZoomMode.FitWidth);
            cmbCurrentZoomLevel.Text = pdfDocumentView1.ZoomPercentage.ToString() + "%";
        }
        #endregion
    }
}

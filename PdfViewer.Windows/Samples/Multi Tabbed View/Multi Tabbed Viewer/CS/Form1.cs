using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Syncfusion.Windows.Forms;
using Syncfusion.PdfViewer.Windows;
using Syncfusion.Windows.Forms.PdfViewer;

namespace TabbedViewer_2008
{
    public partial class Form1 : MetroForm
    {
        #region Private Members
        private bool isDisposeCalled=false;
        private Timer pageTimer;
        private PdfDocumentView docViewer;
        #endregion

        #region Constructor
       
        public Form1()
        {
            InitializeComponent();

            // Position and size of the form.
            Rectangle rect = System.Windows.Forms.Screen.PrimaryScreen.Bounds;
            this.MinimumSize = new Size(rect.Width * 2 / 3, rect.Height * (3 / 2));
            this.Location = new Point(rect.Width / 6, 0);
            this.MetroColor = Color.Transparent;
        }
        #endregion

        #region Events
        private void Form1_Load(object sender, EventArgs e)
        {
            docViewer = new PdfDocumentView();
            pageTimer = new Timer();
            //Load all the pdf documents into the tab control
            ActivateControl();
            LoadDocument(pdfDocumentView3, GetFullTemplatePath("EmpReport.pdf"));
            LoadDocument(pdfDocumentView2, GetFullTemplatePath("Invoice.pdf"));
            LoadDocument(pdfDocumentView1, GetFullTemplatePath("SyncfusionBrochure.pdf"));

        }
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
                    docViewer.GoToPageAtIndex(index);
                }
                txtCurrentPageIndex.Text = docViewer.CurrentPageIndex.ToString();
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
        /// On tab control changed.
        /// </summary>
        private void tabControlAdv1_Click(object sender, EventArgs e)
        {
            ActivateControl();
            EnablePagination();
        }

        /// <summary>
        /// Open a new document in the new tab.
        /// </summary>
        void toolStripButton1_Click(object sender, System.EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Pdf Files (.pdf)|*.pdf";
            dialog.ShowDialog();
            if (!string.IsNullOrEmpty(dialog.FileName))
            {
                //Adding a new tab and pdf document viewer control
                string[] separator = { "\\", @"\" };
                string[] FileName = dialog.FileName.Split(separator, StringSplitOptions.RemoveEmptyEntries);
                tabControlAdv1.TabPages.Add(new Syncfusion.Windows.Forms.Tools.TabPageAdv(FileName[FileName.Length - 1].ToString()));
                PdfDocumentView pdfDocViewer = new PdfDocumentView();
                pdfDocViewer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
                pdfDocViewer.Dock = System.Windows.Forms.DockStyle.Fill;
                pdfDocViewer.Location = new System.Drawing.Point(0, 0);
                pdfDocViewer.Name = "pdfDocumentView" + (tabControlAdv1.TabPages.Count);
                pdfDocViewer.Size = new System.Drawing.Size(626, 633);
                pdfDocViewer.Text = "pdfDocumentView" + (tabControlAdv1.TabPages.Count);
                //Loads the document into the pdf document viewer
                LoadDocument(pdfDocViewer, dialog.FileName);
                tabControlAdv1.TabPages[tabControlAdv1.TabPages.Count - 1].Controls.Add(pdfDocViewer);
                tabControlAdv1.SelectedIndex = tabControlAdv1.TabPages.Count - 1;
                tabControlAdv1.SelectedTab.Text = FileName[FileName.Length - 1].ToString();
                ActivateControl();
                EnablePagination();
            }
        }

        /// <summary>
        /// Handles next page navigation.
        /// </summary>
        private void btnGoToNextPage_Click(object sender, EventArgs e)
        {
            if (docViewer.CanGoToNextPage)
                docViewer.GoToNextPage();
        }

        /// <summary>
        /// Handles previous page navigation.
        /// </summary>
        private void btnGoToPreviousPage_Click(object sender, EventArgs e)
        {
            if (docViewer.CanGoToPreviousPage)
                docViewer.GoToPreviousPage();
        }

        /// <summary>
        /// Handles last page navigation.
        /// </summary>
        private void btnGoToLastPage_Click(object sender, EventArgs e)
        {
            if (docViewer.CanGoToLastPage)
                docViewer.GoToLastPage();
        }

        /// <summary>
        /// Handles first page navigation.
        /// </summary>
        private void btnGoToFirstPage_Click(object sender, EventArgs e)
        {
            if (docViewer.CanGoToFirstPage)
                docViewer.GoToFirstPage();
        }

        /// <summary>
        /// Handles zoom.
        /// </summary>
        private void cmbCurrentZoomLevel_SelectedIndexChanged(object sender, EventArgs e)
        {
            int ZoomLevel = Convert.ToInt32(cmbCurrentZoomLevel.SelectedItem.ToString().Replace("%", ""));
            docViewer.ZoomTo(ZoomLevel);
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

            int pageCount = docViewer.PageCount;
            dialog.AllowPrintToFile = true;
            dialog.AllowSomePages = true;
            dialog.PrinterSettings.FromPage = 1;
            dialog.PrinterSettings.ToPage = pageCount;
            dialog.PrinterSettings.MaximumPage = pageCount;
            dialog.PrinterSettings.MinimumPage = 1;

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                dialog.Document = docViewer.PrintDocument;
                dialog.Document.Print();
            }
        }

        /// <summary>
        /// On tab closed, reorder the document viewer control
        /// </summary>
        private void tabControlAdv1_ControlRemoved(object sender, ControlEventArgs e)
        {
            if (!isDisposeCalled)
            {
                if (tabControlAdv1.SelectedIndex > -1)
                {
                    for (int i = tabControlAdv1.SelectedIndex; i < tabControlAdv1.TabPages.Count; i++)
                    {
                        Control[] pdfControl = tabControlAdv1.TabPages[i].Controls.Find("pdfDocumentView" + (i + 2), true);
                        if (pdfControl.Length > 0 && pdfControl[0] is PdfDocumentView)
                        {
                            PdfDocumentView viewer = pdfControl[0] as PdfDocumentView;
                            viewer.Name = "pdfDocumentView" + (i + 1);
                        }
                    }
                    ActivateControl();
                    EnablePagination();
                }
                else
                {
                    Reset();
                }
            }
            isDisposeCalled = false;
        }

        /// <summary>
        /// Handles the fit page
        /// </summary>
        private void FitPage_Click(object sender, EventArgs e)
        {
            docViewer.ZoomTo(ZoomMode.FitPage);
            cmbCurrentZoomLevel.Text = docViewer.ZoomPercentage.ToString() + "%";
        }

        /// <summary>
        /// Handles the fit width
        /// </summary>
        private void FitWidth_Click(object sender, EventArgs e)
        {
            docViewer.ZoomTo(ZoomMode.FitWidth);
            cmbCurrentZoomLevel.Text = docViewer.ZoomPercentage.ToString() + "%";
        }
        #endregion

        #region Helper methods

        /// <summary>
        /// Load a PDF document.
        /// </summary>
        private void LoadDocument(PdfDocumentView viewer, string fileName)
        {
		    viewer.Load(fileName);
            lblTotalPageCount.Text = viewer.PageCount.ToString();
            EnablePagination();            
            pageTimer.Tick += pageTimer_Tick;
            pageTimer.Start();
        }

        void pageTimer_Tick(object sender, EventArgs e)
        {
            if (docViewer.PageCount > 1)
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
            this.btnGoToNextPage.Enabled = docViewer.CanGoToNextPage;
            this.btnGoToLastPage.Enabled = docViewer.CanGoToLastPage;
            this.btnGoToPreviousPage.Enabled = docViewer.CanGoToPreviousPage;
            this.btnGoToFirstPage.Enabled = docViewer.CanGoToFirstPage;
        }

         /// <summary>
        /// Gets the full path of the PDF template or image.
        /// </summary>
        /// <param name="fileName">Name of the file</param>
        /// <param name="image">True if image</param>
        /// <returns>Path of the file</returns>
        private string GetFullTemplatePath(string fileName)
        {
            string fullPath = @"..\..\..\..\..\..\..\Common\Data\PDF\";

            return string.Format(@"{0}{1}", fullPath, fileName);
        }

        /// <summary>
        /// Activates the current tab control
        /// </summary>
        private void ActivateControl()
        {
            //Find a pdf document viewer in the selected tab page.
            Control[] pdfControl = tabControlAdv1.SelectedTab.Controls.Find("pdfDocumentView" + (tabControlAdv1.SelectedIndex + 1), true);
            if (pdfControl.Length > 0 && pdfControl[0] is PdfDocumentView)
                docViewer = pdfControl[0] as PdfDocumentView;
            //Adding event handler for current page index
            docViewer.CurrentPageChanged += new PdfDocumentView.CurrentPageChangedEventHandler(docViewer_CurrentPageChanged);
            this.txtCurrentPageIndex.Text = docViewer.CurrentPageIndex.ToString();
            this.lblTotalPageCount.Text = docViewer.PageCount.ToString();
            this.cmbCurrentZoomLevel.Text = docViewer.ZoomPercentage.ToString() + "%";
            docViewer.Focus();
        }

        /// <summary>
        /// Reset all the fields
        /// </summary>
        private void Reset()
        {
            btnGoToFirstPage.Enabled = false;
            btnGoToLastPage.Enabled = false;
            btnGoToNextPage.Enabled = false;
            btnGoToPreviousPage.Enabled = false;
            txtCurrentPageIndex.Text = "0";
            lblTotalPageCount.Text = "0";
        }

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            isDisposeCalled = true;
            if (pageTimer.Enabled)
                pageTimer.Stop();
            docViewer.Dispose();
            pdfDocumentView1.Dispose();
            pdfDocumentView2.Dispose();
            pdfDocumentView3.Dispose();
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        #endregion        
    }
}
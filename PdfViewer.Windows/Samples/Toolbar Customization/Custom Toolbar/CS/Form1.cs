#region Copyright Syncfusion Inc. 2001 - 2011
// Copyright Syncfusion Inc. 2001 - 2011. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Syncfusion.Windows.Forms;

namespace ToolbarCustomization_2005
{
    public partial class Form1 : MetroForm
    {
        #region Private members
        private Timer timer;
        #endregion

        # region Constructor
        public Form1()
        {
            InitializeComponent();

            // Layout controls.
            Rectangle rect = System.Windows.Forms.Screen.PrimaryScreen.Bounds;
            this.MinimumSize = new Size(rect.Width * 2 / 3, rect.Height * (3 / 2));
            this.Location = new Point(rect.Width / 6, 0);

            this.DefaultToolbar.Height = 24;
            this.MetroColor = Color.Transparent;
        }
        # endregion

        #region Events
        /// <summary>
        /// Loads PDF into PdfViewerControl.
        /// </summary>
        private void Form1_Load(object sender, EventArgs e)
        {
            timer = new Timer();
            timer.Tick += timer_Tick;
            timer.Enabled = true;
            LoadDocument(GetFullTemplatePath("TextFormatting.pdf"));
        }

        /// <summary>
        /// Toggles between default and custom toolbar.
        /// </summary>
        private void DefaultToolbar_Click(object sender, EventArgs e)
        {
            if (DefaultToolbar.Checked)
            {
                pdfViewerControl1.ShowToolBar = true;
                CustomPanel.Visible = false;
            }
            else
            {
                pdfViewerControl1.ShowToolBar = false;
                CustomPanel.Visible = true;
                SetPageNumber();
            }
        }

        /// <summary>
        /// Handles open button in the custom toolbar.
        /// </summary>
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Pdf Files (.pdf)|*.pdf";
            dialog.ShowDialog();
            if (!string.IsNullOrEmpty(dialog.FileName))
                LoadDocument(dialog.FileName);
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            pdfViewerControl1.GoToPageAtIndex(1);
            SetPageNumber();
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            pdfViewerControl1.GoToPageAtIndex(pdfViewerControl1.PageCount);
            SetPageNumber();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (pdfViewerControl1.CurrentPageIndex != 1)
            {
                pdfViewerControl1.GoToPageAtIndex(pdfViewerControl1.CurrentPageIndex - 1);
            }

            SetPageNumber();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (pdfViewerControl1.CurrentPageIndex != pdfViewerControl1.PageCount)
            {
                pdfViewerControl1.GoToPageAtIndex(pdfViewerControl1.CurrentPageIndex + 1);
            }

            SetPageNumber();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            SetPageNumber();
        }

		/// <summary>
        /// Handles Keydown event of PageNumber Textbox
        /// </summary>
        private void txtPageNumber_KeyDown(object sender, KeyEventArgs e)
        {
            timer.Stop();
            int pageNumber=1;
            if (txtPageNumber.Text != "")
            {
                pageNumber = Convert.ToInt16(txtPageNumber.Text);
            }
            if(e.KeyCode==Keys.Enter)
            {
                pdfViewerControl1.GoToPageAtIndex(pageNumber);
                timer.Start();
            }
        }

        #endregion

        #region Helper methods
        /// <summary>
        /// Loads PDF into PdfViewerControl.
        /// </summary>
        private void LoadDocument(string fileName)
        {
		    pdfViewerControl1.Load(fileName);
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

        void SetPageNumber()
        {
            txtPageNumber.Text = pdfViewerControl1.CurrentPageIndex.ToString();
        }

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (timer.Enabled)
                timer.Stop();
            pdfViewerControl1.Dispose();
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        #endregion
    }
}
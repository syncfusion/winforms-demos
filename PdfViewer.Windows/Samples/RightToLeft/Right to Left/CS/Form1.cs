#region Copyright Syncfusion Inc. 2001-2019.
// Copyright Syncfusion Inc. 2001-2019. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Threading;
using System.Windows.Forms;
using Syncfusion.Windows.Forms;
using Syncfusion.Windows.Forms.PdfViewer;

namespace PDFViewerRTL
{
    public partial class Form1 : MetroForm
    {
        PdfViewerControl pdfDocumentView;

        public Form1()
        {
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("ar-AE");
            InitializeComponent();

            pdfDocumentView = new PdfViewerControl();
            pdfDocumentView.RightToLeft = RightToLeft.Yes;
            pdfDocumentView.Dock = DockStyle.Fill;
            pdfDocumentView.Size = new System.Drawing.Size(1000, 600);
            pdfDocumentView.Location = new System.Drawing.Point(40, 40);
            this.Controls.Add(pdfDocumentView);
            this.WindowState = FormWindowState.Maximized;
            this.KeyPreview = true;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadDocument(GetFullTemplatePath("RTLText.pdf"));
        }

        #region Helper methods
        /// <summary>
        /// Loads PDF into PdfViewerControl.
        /// </summary>
        private void LoadDocument(string fileName)
        {
            pdfDocumentView.Load(fileName);
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

        #endregion
    }
}

#region Copyright Syncfusion Inc. 2001-2022.
// Copyright Syncfusion Inc. 2001-2022. All rights reserved.
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
using System.IO;

using Syncfusion.Pdf;
using Syncfusion.Windows.Forms;
using Syncfusion.Pdf.Graphics;
using System.Threading;
using Syncfusion.Pdf.Parsing;

namespace FindPDFCorruption
{
    public partial class Form1 : MetroForm
    {
        # region Fields        
        # endregion

        # region Constructor
        public Form1()
        {         
            InitializeComponent();
            this.pictureBox1.Image = System.Drawing.Image.FromFile(GetFullTemplatePath("pdf_header.png", true));
			this.Icon = System.Drawing.Icon.ExtractAssociatedIcon(GetFullTemplatePath("syncfusion.ico", true));

        }
        # endregion

        # region Events
        private void button1_Click(object sender, EventArgs e)
        {
            //Create a new instance for the PDF analyzer.
            PdfDocumentAnalyzer analyzer = new PdfDocumentAnalyzer(GetFullTemplatePath("CorruptedDocument.pdf",false));

            //Get the syntax errors.
            SyntaxAnalyzerResult result = analyzer.AnalyzeSyntax();

            //Check whether the document is corrupted or not.
            if (result.IsCorrupted)
            {
                StringBuilder builder = new StringBuilder();
                builder.AppendLine("The PDF document is corrupted.");
                int count = 1;
                foreach (PdfException exception in result.Errors)
                {
                    builder.AppendLine(count++.ToString() + ": " + exception.Message);
                }
                MessageBox.Show(builder.ToString(), "Result");
            }
            else
                MessageBox.Show("No syntax issues found", "Result");
			this.Close();
        }
        #endregion

        # region Helpher methods      
        
        /// <summary>
        /// Gets the full path of the PDF template or image.
        /// </summary>
        /// <param name="fileName">Name of the file</param>
        /// <param name="image">True if image</param>
        /// <returns>Path of the file</returns>
        private string GetFullTemplatePath(string fileName, bool image)
        {
#if NETCORE
            string fullPath = @"..\..\..\..\..\..\..\Common\";
#else
            string fullPath = @"..\..\..\..\..\..\Common\";
#endif
            string folder = image ? "Images" : "Data";

            return string.Format(@"{0}{1}\PDF\{2}", fullPath, folder, fileName);
        }        

        #endregion

       
    }
}

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

namespace CompressExistingPDF
{
    public partial class Form1 : MetroForm
    {
        # region Fields        
        # endregion

        # region Constructor
        public Form1()
        {         
            InitializeComponent();
            this.openFileDialog1.Filter = "PDF files (*.pdf)|*.pdf";
            this.pictureBox1.Image = System.Drawing.Image.FromFile(GetFullTemplatePath("pdf_header.png", true));
			this.Icon = System.Drawing.Icon.ExtractAssociatedIcon(GetFullTemplatePath("syncfusion.ico", true));
            this.MinimizeBox = true;
            for (int i = 1; i <= 100; i++)
                this.imageQuality.Items.Add(i);
            this.imageQuality.SelectedIndex = 49;
            this.optimizeFont.Checked = true;
            this.compressPageContents.Checked = true;
            this.removeMetadata.Checked = true;
            this.compressImage.Checked = true;
#if !NETCORE
            this.Height =600;
#else
            this.Height = 730;
#endif

            textBox1.Tag = GetFullTemplatePath("jQuery_Succinctly.pdf",false);

            textBox1.Text = "jQuery_Succinctly.Pdf";            
        }
#endregion

#region Events
        private void button1_Click(object sender, EventArgs e)
        {
#if !NETCORE
            this.Height =600;
#else
            this.Height = 730;
#endif
            if (textBox1.Text != null && textBox1.Text != string.Empty)
            {
                string ex = Path.GetExtension(textBox1.Tag.ToString());

                if (ex == ".pdf" || ex == ".PDF")
                {
                    byte[] inputFile = File.ReadAllBytes(textBox1.Tag.ToString());

                    //Load a existing PDF document
                    PdfLoadedDocument ldoc = new PdfLoadedDocument(inputFile);

                    //Create a new PDF compression options
                    PdfCompressionOptions options = new PdfCompressionOptions();

                    if (compressImage.Checked)
                    {
                        //Compress image.
                        options.CompressImages = true;
                        options.ImageQuality = int.Parse((imageQuality.SelectedIndex + 1).ToString());
                    }
                    else
                        options.CompressImages = false;

                    //Compress the font data
                    if (optimizeFont.Checked)
                        options.OptimizeFont = true;
                    else
                        options.OptimizeFont = false;

                    //Compress the page contents
                    if (compressPageContents.Checked)
                        options.OptimizePageContents = true;
                    else
                        options.OptimizePageContents = false;

                    //Remove the metadata information.
                    if (removeMetadata.Checked)
                        options.RemoveMetadata = true;
                    else
                        options.RemoveMetadata = false;

                    //Set the options to loaded PDF document
                    ldoc.CompressionOptions = options;

                    //Save the document 
                    MemoryStream ms = new MemoryStream();
                    ldoc.Save(ms);

                    this.ods.Text = (inputFile.Length / 1024).ToString() + " KB";
                    this.cds.Text = (ms.Length / 1024).ToString() + " KB ";
#if !NETCORE
                    this.Height =735;
#else
                    this.Height =900;
#endif

                    if (MessageBox.Show("Do you want to view the PDF file?", "PDF File Created",
                MessageBoxButtons.YesNo, MessageBoxIcon.Information)
                == DialogResult.Yes)
                    {
                        File.WriteAllBytes("Sample.pdf", ms.ToArray());
                        ms.Dispose();
                        //Launching the PDF file using the default Application.[Acrobat Reader]
#if NETCORE
                System.Diagnostics.Process process = new System.Diagnostics.Process();
                process.StartInfo = new System.Diagnostics.ProcessStartInfo("Sample.pdf")
                {
                    UseShellExecute = true
                };
                process.Start();
#else
                        System.Diagnostics.Process.Start("Sample.pdf");
#endif
                        this.Close();
                    }
                    else
                    {
                        ms.Dispose();
                        // Exit
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Please select the valid PDF file.");
                }
            }
            else
            {
                MessageBox.Show("Please select the valid PDF file.");
            }
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

        private void button2_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = openFileDialog1.SafeFileName;
                textBox1.Tag = openFileDialog1.FileName;
                this.Height = 440;
                this.ods.Text = this.cds.Text = "";             
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (compressImage.Checked)
                this.imageQuality.Enabled = true;
            else
                this.imageQuality.Enabled = false;
        }
    }
}

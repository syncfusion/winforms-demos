using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

using Syncfusion.XPS;
using Syncfusion.Pdf;
using Syncfusion.Windows.Forms;

namespace XPStoPDF_2005
{
    public partial class Form1 : MetroForm
    {
        public Form1()
        {
            InitializeComponent();
			this.Icon = System.Drawing.Icon.ExtractAssociatedIcon(GetFullTemplatePath("syncfusion.ico", true));
            this.MinimizeBox = true;
        }


        private void btnXPS2PDF_Click(object sender, EventArgs e)
        {
            if ((string)this.textBox1.Tag != String.Empty)
            {
                // Initialize XPS converter.
                XPSToPdfConverter converter = new XPSToPdfConverter();
               
                // Convert XPS document into PDF document.
                PdfDocument document = converter.Convert((string)textBox1.Tag);
                
                // Save & close the pdf file.
                document.Save("Sample.pdf");
                document.Close(true);

                //Message box confirmation to view the created document.
                if (MessageBox.Show("Do you want to view the PDF file?", "File has been created", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    try
                    {
                        System.Diagnostics.Process.Start(@"Sample.pdf");
                        //Exit
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.ToString());
                    }
                }
                else
                    this.Close();
            }
            else
            {
                MessageBox.Show("Browse a XPS document and click the button to convert as a PDF.");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.textBox1.Text = "XPStoPDF.xps";
            this.textBox1.Tag = Application.StartupPath + @"..\..\..\..\..\..\..\..\Common\Data\PDF\XPStoPDF.xps";
        }

        private void browse_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = Application.StartupPath + @"..\..\..\..\..\..\..\..\Common\Data\PDF\";
            openFileDialog1.FileName = "";
            openFileDialog1.Filter = "Xps files (*.XPS)|*.xps";
            DialogResult result = openFileDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                this.textBox1.Text = openFileDialog1.SafeFileName;
                this.textBox1.Tag = openFileDialog1.FileName;
            }
        }
		 /// <summary>
        /// Gets the full path of the PDF template or image.
        /// </summary>
        /// <param name="fileName">Name of the file</param>
        /// <param name="image">True if image</param>
        /// <returns>Path of the file</returns>
        private string GetFullTemplatePath(string fileName, bool image)
        {
            string fullPath = @"..\..\..\..\..\..\..\Common\";
            string folder = image ? "Images" : "Data";

            return string.Format(@"{0}{1}\PDF\{2}", fullPath, folder, fileName);
        }
    }	
}
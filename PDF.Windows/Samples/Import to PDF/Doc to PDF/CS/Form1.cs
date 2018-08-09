using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Syncfusion.DocIO.DLS;
using Syncfusion.DocToPDFConverter;
using Syncfusion.Pdf;
using Syncfusion.Windows.Forms;
#if !SyncfusionFrameWork3_5
using Syncfusion.OfficeChart;
using Syncfusion.OfficeChartToImageConverter;
#endif

namespace Doc_to_PDF
{
    public partial class Form1 : MetroForm
    {
        public Form1()
        {
            InitializeComponent();
			this.pictureBox1.Image = System.Drawing.Image.FromFile(GetFullTemplatePath("pdf_header.png", true));
			this.Icon = System.Drawing.Icon.ExtractAssociatedIcon(GetFullTemplatePath("syncfusion.ico", true));
            this.MinimizeBox = true;
        }


        private void button3_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = Application.StartupPath + @"..\..\..\..\..\..\..\..\Common\Data\PDF\";
            openFileDialog1.FileName = "";
            openFileDialog1.Filter = "Doc files (*.DOC)|*.doc";
            DialogResult result = openFileDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                this.textBox1.Text = openFileDialog1.SafeFileName;
                this.textBox1.Tag = openFileDialog1.FileName;
            }
        }

        private void btnconvert_Click_1(object sender, EventArgs e)
        {
            if ((string)this.textBox1.Tag != String.Empty)
            {
                WordDocument wordDoc = new WordDocument((string)textBox1.Tag);
#if !SyncfusionFrameWork3_5
                //Initialize chart to image converter for converting charts in word to pdf conversion
                wordDoc.ChartToImageConverter = new ChartToImageConverter();
                wordDoc.ChartToImageConverter.ScalingMode = Syncfusion.OfficeChart.ScalingMode.Normal;
#endif
                DocToPDFConverter converter = new DocToPDFConverter();
                //Convert word document into PDF document
                PdfDocument pdfDoc = converter.ConvertToPDF(wordDoc);
                //Save the pdf file
                pdfDoc.Save("DoctoPDF.pdf");

                //Message box confirmation to view the created document.
                if (MessageBox.Show("Do you want to view the PDF file?", "File has been created", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    try
                    {
                        System.Diagnostics.Process.Start(@"DoctoPDF.pdf");
                        //Exit
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.ToString());
                    }
                }
            }
            else
            {
                MessageBox.Show("Browse a word document and click the button to convert as a PDF.");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.textBox1.Text = "DocToPDF.doc";
            this.textBox1.Tag = Application.StartupPath +@"..\..\..\..\..\..\..\..\Common\Data\PDF\DocToPDF.doc";
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
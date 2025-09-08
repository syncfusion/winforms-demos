#region Copyright Syncfusion Inc. 2001 - 2018
//
//  Copyright Syncfusion Inc. 2001 - 2018. All rights reserved.
//
//  Use of this code is subject to the terms of our license.
//  A copy of the current license can be obtained at any time by e-mailing
//  licensing@syncfusion.com. Any infringement will be prosecuted under
//  applicable laws. 
//
#endregion
using System;
using System.Windows.Forms;
using Syncfusion.DocIO.DLS;
using Syncfusion.DocToPDFConverter;
using Syncfusion.Pdf;
#if !(SyncfusionFramework3_5 || SyncfusionFramework2_0)
using Syncfusion.OfficeChart;
using Syncfusion.OfficeChartToImageConverter;
#endif
using Syncfusion.Windows.Forms;
using Syncfusion.Licensing;
using System.Reflection;
using System.Text;
using System.IO;

namespace Doc_to_PDF
{
    public partial class Form1 : MetroForm
    {
        public Form1()
        {		
            InitializeComponent();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = Application.StartupPath + @"..\..\..\..\..\..\..\common\Data\DocIO\";
            openFileDialog1.FileName = "";
            DialogResult result = openFileDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                this.textBox1.Text = openFileDialog1.SafeFileName;
                this.textBox1.Tag = openFileDialog1.FileName;
            }
        }

        private void btnconvert_Click_1(object sender, EventArgs e)
        {
            if (this.textBox1.Text != String.Empty)
            {
                WordDocument wordDoc = new WordDocument((string)textBox1.Tag, Syncfusion.DocIO.FormatType.Automatic);
#if !(SyncfusionFramework3_5 || SyncfusionFramework2_0)
                //Initialize chart to image converter for converting charts in word to pdf conversion
                wordDoc.ChartToImageConverter = new ChartToImageConverter();
                wordDoc.ChartToImageConverter.ScalingMode = Syncfusion.OfficeChart.ScalingMode.Normal;
#endif
                DocToPDFConverter converter = new DocToPDFConverter();

                //Enable Direct PDF rendering mode for faster conversion.
                converter.Settings.EnableFastRendering = checkBox1.Checked;
                converter.Settings.EmbedCompleteFonts = checkBox2.Checked;
                converter.Settings.EmbedFonts = checkBox3.Checked;
                converter.Settings.AutoTag = checkBox4.Checked;
                converter.Settings.PreserveFormFields = checkBox5.Checked;
                converter.Settings.ExportBookmarks = checkBox6.Checked
                                                     ? Syncfusion.DocIO.ExportBookmarkType.Headings
                                                     : Syncfusion.DocIO.ExportBookmarkType.Bookmarks;

                if(checkBox7.Checked)
                {
                    wordDoc.RevisionOptions.ShowMarkup = RevisionType.Deletions | RevisionType.Formatting | RevisionType.Insertions;
                    // Set revision bars color as Black.
                    wordDoc.RevisionOptions.RevisionBarsColor = RevisionColor.Black;
                    // Set revised properties (Formatting) color as Blue.
                    wordDoc.RevisionOptions.RevisedPropertiesColor = RevisionColor.Blue;
                    // Set deleted text (Deletions) color as Yellow.
                    wordDoc.RevisionOptions.DeletedTextColor = RevisionColor.Yellow;
                    // Set inserted text (Insertions) color as Pink.
                    wordDoc.RevisionOptions.InsertedTextColor = RevisionColor.Pink;
                }

                if (checkBox8.Checked)
                {
                    //Sets ShowInBalloons to render a document comments in converted PDF document.
                    wordDoc.RevisionOptions.CommentDisplayMode = CommentDisplayMode.ShowInBalloons;
                    //Sets the color to be used for Comment Balloon
                    wordDoc.RevisionOptions.CommentColor = RevisionColor.Blue;
                }
                //Convert word document into PDF document
                PdfDocument pdfDoc = converter.ConvertToPDF(wordDoc);
                //Save the pdf file
                pdfDoc.Save("DoctoPDF.pdf");
                //Message box confirmation to view the created document.
                if (MessageBoxAdv.Show("Do you want to view the generated PDF?", " Document has been created", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    try
                    {
#if NETCORE
                        System.Diagnostics.Process process = new System.Diagnostics.Process();
                        process.StartInfo = new System.Diagnostics.ProcessStartInfo("DoctoPDF.pdf") { UseShellExecute = true };
                        process.Start();
#else                       
                        System.Diagnostics.Process.Start("DoctoPDF.pdf");
#endif
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
                MessageBoxAdv.Show("Browse a word document and click the button to convert as a PDF.");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.textBox1.Text = "DocToPDF.docx";
            this.textBox1.Tag = Application.StartupPath + @"..\..\..\..\..\..\..\common\Data\DocIO\DocToPDF.docx";
        }
    }
}
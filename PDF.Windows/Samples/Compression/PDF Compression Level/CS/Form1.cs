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


namespace PDF_Compression
{
    public partial class Form1 : MetroForm
    {
        # region Fields
        private PointF point;
        private PdfPage page;
        private SizeF size;
        private PdfLayoutFormat format;
        private int quality;
        # endregion

        # region Constructor
        public Form1()
        {
            InitializeComponent();
			this.pictureBox1.Image = System.Drawing.Image.FromFile(GetFullTemplatePath("pdf_header.png", true));
			this.Icon = System.Drawing.Icon.ExtractAssociatedIcon(GetFullTemplatePath("syncfusion.ico", true));
            this.MinimizeBox = true;
            this.textBox1.Text = string.Empty;
            this.comboBox1.SelectedIndex = 5;
            this.comboBox2.SelectedIndex = 2;            
        }
        # endregion

        # region Events
        private void button1_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            quality = GetTargetQuality(this.comboBox2.SelectedItem.ToString());

            // Create a new instance of PdfDocument class.
            PdfDocument document = new PdfDocument();
            document.PageSettings.Margins.All = 0;
            document.Compression = (PdfCompressionLevel)Enum.Parse(typeof(PdfCompressionLevel), this.comboBox1.SelectedItem.ToString(), true);

            # region Text and Image content

            // Add a new page to the document.
            page = document.Pages.Add();

            // Get page size
            size = page.GetClientSize();

            format = new PdfLayoutFormat();
            format.Layout = PdfLayoutType.Paginate;

            PdfBitmap image = PdfImage.FromFile(GetFullTemplatePath("page1.png", true)) as PdfBitmap;
            image.Quality = quality;
            page.Graphics.DrawImage(image, PointF.Empty, new SizeF(size.Width, image.PhysicalDimension.Height));

            float yPos = image.PhysicalDimension.Height + 100;
            float xPos = size.Width / 4;

            PdfFont headerFont = new PdfTrueTypeFont(new Font("Arial", 18.16f), true);
            PdfFont bodyFont = new PdfTrueTypeFont(new Font("Arial", 10f), true);
            PdfTextElement elem = new PdfTextElement("Essential Studio Enterprise Edition");
            elem.Font = headerFont;
            PdfLayoutResult result = elem.Draw(page, new PointF(xPos, yPos), size.Width / 2, format);
            yPos = result.Bounds.Bottom + 10;
            
            elem = new PdfTextElement("If you need it all, and want to do it all, then Essential Studio Enterprise Edition is all you could want. This comprehensive suite of components and controls is comprised of all the user interface, business intelligence, and reporting tools and libraries that we offer. It’s the one package you need to develop across every platform—WinRT, Mobile MVC, ASP.NET, ASP.NET MVC, WPF, Silverlight, Windows Phone, and Windows Forms.");
            elem.Font = bodyFont;
            elem.Brush = PdfBrushes.Gray;
            elem.StringFormat = new PdfStringFormat();
            elem.StringFormat.LineSpacing = 5;
            result = elem.Draw(page, new PointF(xPos, yPos), size.Width / 2, format);
            yPos = result.Bounds.Bottom + 25;
            
            elem = new PdfTextElement("Essential Studio for ASP.NET");
            elem.Font = headerFont;
            result = elem.Draw(page, new PointF(xPos, yPos), size.Width / 2, format);
            yPos = result.Bounds.Bottom + 10;

            elem = new PdfTextElement("Essential Studio for ASP.NET contains 66 unique controls, everything you need to build line-of-business web applications—including grids, charts, gauges, menus, calendars, editors, and much more. It also comes with high-performance libraries that enable your applications to read and write Excel, Word, and PDF documents.");
            elem.Font = bodyFont;
            elem.Brush = PdfBrushes.Gray;
            elem.StringFormat = new PdfStringFormat();
            elem.StringFormat.LineSpacing = 5;
            result = elem.Draw(page, new PointF(xPos, yPos), size.Width / 2, format);
            yPos = result.Bounds.Bottom + 25;

            elem = new PdfTextElement("Essential Studio for ASP.NET MVC");
            elem.Font = headerFont;
            result = elem.Draw(page, new PointF(xPos, yPos), size.Width / 2, format);
            yPos = result.Bounds.Bottom + 10;

            elem = new PdfTextElement("Our very first natively written MVC control suite contains 50 unique controls essential for assembling enterprise-grade web applications—including grids, charts, gauges, menus, calendars, editors, and much more. It comes with high-performance libraries that enable your applications to read and write Excel, Word, and PDF documents. You will also find several one-of-a-kind MVC controls like OlapClient, PDF Viewer, and Report Viewer.");
            elem.Font = bodyFont;
            elem.Brush = PdfBrushes.Gray;
            elem.StringFormat = new PdfStringFormat();
            elem.StringFormat.LineSpacing = 5;
            result = elem.Draw(page, new PointF(xPos, yPos), size.Width / 2, format);

            page = document.Pages.Add();
            PdfBitmap tiff1 = PdfImage.FromFile(GetFullTemplatePath("page2.tif", true)) as PdfBitmap;
            tiff1.Quality = quality;
            tiff1.Encoding = EncodingType.JBIG2;
            page.Graphics.DrawImage(tiff1, PointF.Empty);

            page = document.Pages.Add();
            PdfBitmap tiff2 = PdfImage.FromFile(GetFullTemplatePath("page3.tif", true)) as PdfBitmap;
            tiff2.Quality = quality;
            tiff2.Encoding = EncodingType.JBIG2;
            page.Graphics.DrawImage(tiff2, PointF.Empty);

            # endregion

            # region Footer
            PdfBitmap fooImage = PdfImage.FromFile(GetFullTemplatePath("footer.png", true)) as PdfBitmap;
            fooImage.Quality = quality;
            PdfPageTemplateElement footer = new PdfPageTemplateElement(page.Graphics.ClientSize.Width, fooImage.PhysicalDimension.Height);
            footer.Graphics.DrawImage(fooImage, new PointF(0, 0));
            document.Template.Bottom = footer;
            # endregion

            // Save and close the document.
            document.Save("Sample.pdf");
            document.Close(true);

            StreamReader reader = new StreamReader("Sample.pdf");

            // Update the text box.
            this.textBox1.Text += "Original Filesize: 256611 bytes" + Environment.NewLine;
            this.textBox1.Text += "Generated Filesize: " + reader.BaseStream.Length.ToString() + " bytes" + Environment.NewLine;
            this.textBox1.Text += "Done!";

            reader.Close();
            reader.Dispose();

            //Message box confirmation to view the created PDF document.
            if (MessageBox.Show("Do you want to view the PDF file?", "PDF File Created",
                MessageBoxButtons.YesNo, MessageBoxIcon.Information)
                == DialogResult.Yes)
            {
                //Launching the PDF file using the default Application.[Acrobat Reader]
                System.Diagnostics.Process.Start("Sample.pdf");
                this.Close();
            }
            else
            {
                // Exit
                this.Close();
            }
        }
        #endregion

        # region Helpher methods

        
        /// <summary>
        /// Parse the image compression level to get the quality.
        /// </summary>
        private int GetTargetQuality(string p)
        {
            int quality = 100;

            switch (p)
            {
                case "Minimum":
                    quality = 20;
                    break;

                case "Low":
                    quality = 40;
                    break;

                case "Medium":
                    quality = 60;
                    break;

                case "High":
                    quality = 80;
                    break;

                case "Maximum":
                default:
                    quality = 100;
                    break;
            }

            return quality;
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

        # endregion
    }
}
#region Copyright Syncfusion Inc. 2001-2016.
// Copyright Syncfusion Inc. 2001-2016. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Syncfusion.Presentation;
using Syncfusion.Presentation.Drawing;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using Syncfusion.Windows.Forms;
using Syncfusion.OfficeChart;
using Syncfusion.PresentationToPdfConverter;
using Syncfusion.Licensing;
using System.Reflection;

using Syncfusion.Pdf;
#if !NOCHARTTOIMAGE
using Syncfusion.OfficeChartToImageConverter;
#endif
namespace CreatePresentation
{
    public partial class Form1 : MetroForm
    {
        #region Private Members
        private System.Windows.Forms.Button btnCreatePresn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private RadioButton rbtnCreatePresentation;
        private RadioButton rbtnPresentationToPdf;

         /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        #endregion

        # region Constructor
        public Form1()
        {
            //
            // Required for Windows Form Designer support
            //            
            InitializeComponent();
            this.rbtnCreatePresentation.Checked = true;
            this.MinimizeBox = true;
            Application.EnableVisualStyles();
        }
        /// <summary>
        /// Helper method to find a syncfusion license key from the Common folder
        /// </summary>
        /// <param name="fileName">File name of the syncfusion license key</param>
        /// <returns></returns>
        public static string FindLicenseKey()
        {
            string licenseKeyFile = "..\\Common\\SyncfusionLicense.txt";
            for (int n = 0; n < 20; n++)
            {
                if (!System.IO.File.Exists(licenseKeyFile))
                {
                    licenseKeyFile = @"..\" + licenseKeyFile;
                    continue;
                }
                return File.ReadAllText(licenseKeyFile);
            }
            return string.Empty;
        }
        #endregion
        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnCreatePresn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rbtnCreatePresentation = new System.Windows.Forms.RadioButton();
            this.rbtnPresentationToPdf = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCreatePresn
            // 
            this.btnCreatePresn.Location = new System.Drawing.Point(236, 218);
            this.btnCreatePresn.Name = "btnCreatePresn";
            this.btnCreatePresn.Size = new System.Drawing.Size(122, 27);
            this.btnCreatePresn.TabIndex = 0;
            this.btnCreatePresn.Text = "Generate Document";
            this.btnCreatePresn.UseVisualStyleBackColor = true;
            this.btnCreatePresn.Click += new System.EventHandler(this.btnCreatePresn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(381, 97);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(386, 42);
            this.label1.TabIndex = 27;
            this.label1.Text = "Click the button to view the document generated by Essential Presentation.\r\nPle" +
                "ase note that Microsoft PowerPoint viewer or Adobe Reader is required \r\n" +
                "to view the resultant Presentation or PDF respectively.";
            // 
            // rbtnCreatePresentation
            // 
            this.rbtnCreatePresentation.AutoSize = true;
            this.rbtnCreatePresentation.Location = new System.Drawing.Point(34, 176);
            this.rbtnCreatePresentation.Name = "rbtnCreatePresentation";
            this.rbtnCreatePresentation.Size = new System.Drawing.Size(118, 17);
            this.rbtnCreatePresentation.TabIndex = 28;
            this.rbtnCreatePresentation.TabStop = true;
            this.rbtnCreatePresentation.Text = "Create Presentation";
            this.rbtnCreatePresentation.UseVisualStyleBackColor = true;
            // 
            // rbtnPresentationToPdf
            // 
            this.rbtnPresentationToPdf.AutoSize = true;
            this.rbtnPresentationToPdf.Location = new System.Drawing.Point(212, 176);
            this.rbtnPresentationToPdf.Name = "rbtnPresentationToPdf";
            this.rbtnPresentationToPdf.Size = new System.Drawing.Size(119, 17);
            this.rbtnPresentationToPdf.TabIndex = 29;
            this.rbtnPresentationToPdf.TabStop = true;
            this.rbtnPresentationToPdf.Text = "Presentation To PDF";
            this.rbtnPresentationToPdf.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 257);
            this.Controls.Add(this.rbtnPresentationToPdf);
            this.Controls.Add(this.rbtnCreatePresentation);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnCreatePresn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Notes";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        [STAThread]
        static void Main()
        {
            SyncfusionLicenseProvider.RegisterLicense(FindLicenseKey());
            Application.Run(new Form1());
        }


        private void btnCreatePresn_Click(object sender, EventArgs e)
        {
            string input = @"..\..\..\..\..\..\..\Common\Data\Presentation\Images.pptx";
            IPresentation presentation = Presentation.Open(input);
            CreateSlide1(presentation);
            CreateSlide2(presentation);

            if (rbtnCreatePresentation.Checked)
            {
                //Saves the presentation
                presentation.Save("NotesSample.pptx");

                if (MessageBox.Show("Do you want to view the generated Presentation?", "Presentation Created",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    System.Diagnostics.Process.Start("NotesSample.pptx");
                }
            }
            else if (rbtnPresentationToPdf.Checked)
            {
#if !NOCHARTTOIMAGE
                presentation.ChartToImageConverter = new ChartToImageConverter();
#endif
                PresentationToPdfConverterSettings settings = new PresentationToPdfConverterSettings();
                //Select the notes pages option to convert the notes content to pdf.
                settings.PublishOptions = PublishOptions.NotesPages;
                PdfDocument pdfDocument = PresentationToPdfConverter.Convert(presentation, settings);
                pdfDocument.Save("NotesSample.pdf");
                if (MessageBox.Show("Do you want to view the generated PDF document?", "PDF Created",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    System.Diagnostics.Process.Start("NotesSample.pdf");
                    this.Close();
                }
            }
        }

		
        # region Slide1
        private void CreateSlide1(IPresentation presentation)
        {
            ISlide slide1 = presentation.Slides[0];
            IShape shape1 = (IShape)slide1.Shapes[0];
            shape1.Left = 1.27 * 72;
            shape1.Top = 0.56 * 72;
            shape1.Width = 9.55 * 72;
            shape1.Height = 5.4 * 72;

            ITextBody textFrame = shape1.TextBody;
            IParagraphs paragraphs = textFrame.Paragraphs;
            paragraphs.Add();
            IParagraph paragraph = paragraphs[0];
            paragraph.HorizontalAlignment = HorizontalAlignmentType.Left;
            ITextParts textParts = paragraph.TextParts;
            textParts.Add();
            ITextPart textPart = textParts[0];
            textPart.Text = "Essential Presentation ";
            textPart.Font.CapsType = TextCapsType.All;
            textPart.Font.FontName = "Calibri Light (Headings)";
            textPart.Font.FontSize = 80;
            textPart.Font.Color = ColorObject.Black;

            //Adding Notes
            INotesSlide notesSlide = slide1.AddNotesSlide();
            ITextPart notesTextPart = notesSlide.NotesTextBody.Paragraphs[0].TextParts.Add();
            notesTextPart.Text = "The slide represents the title content of the presentation";

            IPresentationChart chart = notesSlide.Shapes.AddChart(1.24 * 72, 5.71 * 72, 5 * 72, 3.33 * 72);


            //Specifies the chart title

            chart.ChartTitle = "Sales Analysis";

            //Sets chart data - Row1

            chart.ChartData.SetValue(1, 2, "Jan");

            chart.ChartData.SetValue(1, 3, "Feb");

            chart.ChartData.SetValue(1, 4, "March");

            //Sets chart data - Row2

            chart.ChartData.SetValue(2, 1, 2010);

            chart.ChartData.SetValue(2, 2, 60);

            chart.ChartData.SetValue(2, 3, 70);

            chart.ChartData.SetValue(2, 4, 80);

            //Sets chart data - Row3

            chart.ChartData.SetValue(3, 1, 2011);

            chart.ChartData.SetValue(3, 2, 80);

            chart.ChartData.SetValue(3, 3, 70);

            chart.ChartData.SetValue(3, 4, 60);

            //Sets chart data - Row4

            chart.ChartData.SetValue(4, 1, 2012);

            chart.ChartData.SetValue(4, 2, 60);

            chart.ChartData.SetValue(4, 3, 70);

            chart.ChartData.SetValue(4, 4, 80);

            //Creates a new chart series with the name

            IOfficeChartSerie serieJan = chart.Series.Add("Jan");

            //Sets the data range of chart serie – start row, start column, end row, end column

            serieJan.Values = chart.ChartData[2, 2, 4, 2];

            //Creates a new chart series with the name

            IOfficeChartSerie serieFeb = chart.Series.Add("Feb");

            //Sets the data range of chart serie – start row, start column, end row, end column

            serieFeb.Values = chart.ChartData[2, 3, 4, 3];

            //Creates a new chart series with the name

            IOfficeChartSerie serieMarch = chart.Series.Add("March");

            //Sets the data range of chart series – start row, start column, end row, end column

            serieMarch.Values = chart.ChartData[2, 4, 4, 4];

            //Sets the data range of the category axis

            chart.PrimaryCategoryAxis.CategoryLabels = chart.ChartData[2, 1, 4, 1];

            //Specifies the chart type

            chart.ChartType = OfficeChartType.Column_Clustered;

            chart.ChartTitle = "Chart inside Notes section";
        }
        #endregion

        # region Slide2
        private void CreateSlide2(IPresentation presentation)
        {
            ISlide slide2 = presentation.Slides.Add(SlideLayoutType.ContentWithCaption);
            slide2.Background.Fill.FillType = FillType.Solid;
            slide2.Background.Fill.SolidFill.Color = ColorObject.White;


            slide2.Shapes.RemoveAt(1);
            slide2.Shapes.RemoveAt(1);

            //Adds picture in the shape
            Stream imageStream = File.Open(@"..\..\..\..\..\..\..\Common\Images\Presentation\tablet.jpg", FileMode.Open);
            IPicture picture1 = slide2.Shapes.AddPicture(imageStream, 5.18 * 72, 1.15 * 72, 7.3 * 72, 5.31 * 72);
            imageStream.Close();

            //Adding Notes
            INotesSlide notesSlide = slide2.AddNotesSlide();
            ITextPart notesTextPart = notesSlide.NotesTextBody.Paragraphs[0].TextParts.Add();
            notesTextPart.Text = "The slide represents the picture content for the presentation";

            IShape shape = notesSlide.Shapes.AddShape(AutoShapeType.RoundedRectangle, 1.66 * 72, 6.32 * 72, 4.32 * 72, 2.66 * 72) as IShape;
            shape.LineFormat.Fill.SolidFill.Color = ColorObject.Black;

            shape.Fill.SolidFill.Color = ColorObject.White;
            // Adds a new paragraph with the text in the left hand side textbox.

            IParagraph paragraph = shape.TextBody.AddParagraph("Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.");

            //Sets the list type as Numbered

            paragraph.ListFormat.Type = ListType.Bulleted;

            //Sets the numbered style (list numbering) as Arabic number following by period.

            paragraph.ListFormat.NumberStyle = NumberedListStyle.ArabicPeriod;

            //Sets the starting value as 1

            paragraph.ListFormat.StartValue = 1;

            //Sets the list level as 1

            paragraph.IndentLevelNumber = 1;

            // Sets the hanging value

            paragraph.FirstLineIndent = -20;

            // Sets the bullet character size. Here, 100 means 100% of its text. Possible values can range from 25 to 400.

            paragraph.ListFormat.Size = 100;

            // Adds another paragraph with the text in the left hand side textbox.

            paragraph = shape.TextBody.AddParagraph("Ut enim ad ");

            //Sets the list type as bulleted

            paragraph.ListFormat.Type = ListType.Bulleted;

            //Sets the numbered style (list numbering) as Arabic number following by period.

            paragraph.ListFormat.NumberStyle = NumberedListStyle.ArabicPeriod;

            //Sets the list level as 1

            paragraph.IndentLevelNumber = 1;

            // Sets the hanging value

            paragraph.FirstLineIndent = -20;

            // Sets the bullet character size. Here, 100 means 100% of its text. Possible values can range from 25 to 400.

            paragraph.ListFormat.Size = 100;

            // Adds another paragraph with the text in the left hand side textbox.

            paragraph = shape.TextBody.AddParagraph("Duis aute irure dolor.");

            //Sets the list type as bulleted

            paragraph.ListFormat.Type = ListType.Bulleted;


            //Sets the list level as 1

            paragraph.IndentLevelNumber = 1;

            // Sets the hanging value

            paragraph.FirstLineIndent = -20;

            // Sets the bullet character size. Here, 100 means 100% of its text. Possible values can range from 25 to 400.

            paragraph.ListFormat.Size = 100;
        }
        # endregion

    }
}

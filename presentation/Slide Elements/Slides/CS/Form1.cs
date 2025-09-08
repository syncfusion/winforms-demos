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
using System.Diagnostics;
using System.Text;
using System.IO;
using System.Windows.Forms;
using Syncfusion.Presentation;
using Syncfusion.Drawing;
using Syncfusion.Windows.Forms;
using Syncfusion.Licensing;
using System.Reflection;

namespace Slides
{
    public partial class Form1 : MetroForm 
    {
        #region Private Members
        private System.Windows.Forms.Button btnCreatePresn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;

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
            string licenseKeyFile = "..\\common\\SyncfusionLicense.txt";
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCreatePresn
            // 
            this.btnCreatePresn.Location = new System.Drawing.Point(258, 142);
            this.btnCreatePresn.Name = "btnCreatePresn";
            this.btnCreatePresn.Size = new System.Drawing.Size(123, 27);
            this.btnCreatePresn.TabIndex = 0;
            this.btnCreatePresn.Text = "Create Presentation";
            this.btnCreatePresn.UseVisualStyleBackColor = true;
            this.btnCreatePresn.Click += new System.EventHandler(this.btnCreatePresn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(381, 88);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(370, 42);
            this.label1.TabIndex = 2;
            this.label1.Text = "Click the button to view a presentation generated by Essential Presentation.\r\nPle" +
    "ase note that Microsoft PowerPoint viewer is required to view the resultant \r\nPresentation." +
    "\r\n";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 195);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnCreatePresn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Slides";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            SyncfusionLicenseProvider.RegisterLicense(FindLicenseKey());
            Application.Run(new Form1());
        }

    #endregion

        #region event
        private void btnCreatePresn_Click(object sender, EventArgs e)
        {
            string input = @"..\..\..\..\..\..\common\Data\Presentation\Slides.pptx";
#if NETCore
            input = @"..\..\..\..\..\..\..\common\Data\Presentation\Slides.pptx";
#endif
            IPresentation presentation = Presentation.Open(input);
            //New Instance of PowerPoint is Created.[Equivalent to launching MS PowerPoint with no slides].

            //Method call to create slides
            CreateSlide1(presentation);
            CreateSlide2(presentation);
            CreateSlide3(presentation);
            CreateSlide4(presentation);

            //Saves the presentation
            presentation.Save("SlidesSample.pptx");
            if (MessageBox.Show("Do you want to view the generated Presentation?", "Presentation Created",
              MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
#if !NETCore
                System.Diagnostics.Process.Start("SlidesSample.pptx");
#else
                System.Diagnostics.Process process = new System.Diagnostics.Process();
                process.StartInfo = new System.Diagnostics.ProcessStartInfo("SlidesSample.pptx")
                {
                    UseShellExecute = true
                };
                process.Start();
#endif
                this.Close();
            }
        }

        #endregion

        # region Slide1
        private void CreateSlide1(IPresentation presentation)
        {
            ISlide slide1 = presentation.Slides[0];
            IShape shape1 = slide1.Shapes[0] as IShape;
            shape1.Left = 1.5 * 72;
            shape1.Top = 1.94 * 72;
            shape1.Width = 10.32 * 72;
            shape1.Height = 2 * 72;
          
            ITextBody textFrame1 = shape1.TextBody;
            IParagraphs paragraphs1 = textFrame1.Paragraphs;
            IParagraph paragraph1 = paragraphs1.Add();
            ITextPart textPart1 = paragraph1.AddTextPart();
            paragraphs1[0].IndentLevelNumber = 0;
            textPart1.Text = "ESSENTIAL PRESENTATION";
            textPart1.Font.FontName = "HelveticaNeue LT 65 Medium";
            textPart1.Font.FontSize = 48;
            textPart1.Font.Bold = true;
            slide1.Shapes.RemoveAt(1);

        }
        #endregion

        # region Slide2
        private void CreateSlide2(IPresentation presentation)
        {
            ISlide slide2 = presentation.Slides.Add(SlideLayoutType.SectionHeader);
            IShape shape1 = slide2.Shapes[0] as IShape;
            shape1.Left = 0.77 * 72;
            shape1.Top = 0.32 * 72;
            shape1.Width = 7.96 * 72;
            shape1.Height = 0.99 * 72;

            ITextBody textFrame1 = shape1.TextBody;

            //Instance to hold paragraphs in textframe
            IParagraphs paragraphs1 = textFrame1.Paragraphs;
            IParagraph paragraph1 = paragraphs1.Add();
            ITextPart textpart1 = paragraph1.AddTextPart();
            paragraphs1[0].HorizontalAlignment = HorizontalAlignmentType.Left;
            textpart1.Text = "Slide with simple text";
            textpart1.Font.FontName = "Helvetica CE 35 Thin";
            textpart1.Font.FontSize = 40;

            IShape shape2 = slide2.Shapes[1] as IShape;
            shape2.Left = 1.21 * 72;
            shape2.Top = 1.66 * 72;
            shape2.Width = 10.08 * 72;
            shape2.Height = 4.93 * 72;

            ITextBody textFrame2 = shape2.TextBody;

            //Instance to hold paragraphs in textframe
            IParagraphs paragraphs2 = textFrame2.Paragraphs;
            IParagraph paragraph2 = paragraphs2.Add();
            paragraph2.HorizontalAlignment = HorizontalAlignmentType.Left;
            ITextPart textpart2 = paragraph2.AddTextPart();
            textpart2.Text = "Lorem ipsum dolor sit amet, lacus amet amet ultricies. Quisque mi venenatis morbi libero, orci dis, mi ut et class porta, massa ligula magna enim, aliquam orci vestibulum tempus.";
            textpart2.Font.FontName = "Calibri (Body)";
            textpart2.Font.FontSize = 15;
            textpart2.Font.Color = ColorObject.Black;

            //Instance to hold paragraphs in textframe
            IParagraph paragraph3 = paragraphs2.Add();
            paragraph3.HorizontalAlignment = HorizontalAlignmentType.Left;
            textpart1 = paragraph3.AddTextPart();
            textpart1.Text = "Turpis facilisis vitae consequat, cum a a, turpis dui consequat massa in dolor per, felis non amet.";
            textpart1.Font.FontName = "Calibri (Body)";
            textpart1.Font.FontSize = 15;
            textpart1.Font.Color = ColorObject.Black;

            //Instance to hold paragraphs in textframe
            IParagraph paragraph4 = paragraphs2.Add();
            paragraph4.HorizontalAlignment = HorizontalAlignmentType.Left;
            textpart1 = paragraph4.AddTextPart();
            textpart1.Text = "Auctor eleifend in omnis elit vestibulum, donec non elementum tellus est mauris, id aliquam, at lacus, arcu pretium proin lacus dolor et. Eu tortor, vel ultrices amet dignissim mauris vehicula.";
            textpart1.Font.FontName = "Calibri (Body)";
            textpart1.Font.FontSize = 15;
            textpart1.Font.Color = ColorObject.Black;

            //Instance to hold paragraphs in textframe
            IParagraph paragraph5 = paragraphs2.Add();
            paragraph5.HorizontalAlignment = HorizontalAlignmentType.Left;
            textpart1 = paragraph5.AddTextPart();
            textpart1.Text = "Vestibulum duis integer diam mi libero felis, sollicitudin id dictum etiam blandit lacus, ac condimentum magna dictumst interdum et,";
            textpart1.Font.FontName = "Calibri (Body)";
            textpart1.Font.FontSize = 15;
            textpart1.Font.Color = ColorObject.Black;

            //Instance to hold paragraphs in textframe
            IParagraph paragraph6 = paragraphs2.Add();
            paragraph6.HorizontalAlignment = HorizontalAlignmentType.Left;
            ITextPart textpart3 = paragraph6.AddTextPart();
            textpart1.Text = "nam commodo mi habitasse enim fringilla nunc, amet aliquam sapien per tortor luctus. Conubia voluptates at nunc, congue lectus, malesuada nulla.";
            textpart1.Font.Color = ColorObject.White;
            textpart1.Font.FontName = "Calibri (Body)";
            textpart1.Font.FontSize = 15;
            textpart1.Font.Color = ColorObject.Black;

            //Instance to hold paragraphs in textframe
            IParagraph paragraph7 = paragraphs2.Add();
            paragraph7.HorizontalAlignment = HorizontalAlignmentType.Left;
            textpart1 = paragraph7.AddTextPart();
            textpart1.Text = "Rutrum quo morbi, feugiat sed mi turpis, ac cursus integer ornare dolor. Purus dui in et tincidunt, sed eros pede adipiscing tellus, est suscipit nulla,";
            textpart1.Font.FontName = "Calibri (Body)";
            textpart1.Font.FontSize = 15;
            textpart1.Font.Color = ColorObject.Black;

            //Instance to hold paragraphs in textframe
            IParagraph paragraph8 = paragraphs2.Add();
            paragraph8.HorizontalAlignment = HorizontalAlignmentType.Left;
            textpart1 = paragraph8.AddTextPart();
            textpart1.Text = "Auctor eleifend in omnis elit vestibulum, donec non elementum tellus est mauris, id aliquam, at lacus, arcu pretium proin lacus dolor et. Eu tortor, vel ultrices amet dignissim mauris vehicula.";
            textpart1.Font.FontName = "Calibri (Body)";
            textpart1.Font.FontSize = 15;
            textpart1.Font.Color = ColorObject.Black;

            //Instance to hold paragraphs in textframe
            IParagraph paragraph9 = paragraphs2.Add();
            paragraph9.HorizontalAlignment = HorizontalAlignmentType.Left;
            textpart1 = paragraph9.AddTextPart();
            textpart1.Text = "arcu nec fringilla vel aliquam, mollis lorem rerum hac vestibulum ante nullam. Volutpat a lectus, lorem pulvinar quis. Lobortis vehicula in imperdiet orci urna.";
            textpart1.Font.FontName = "Calibri (Body)";
            textpart1.Font.Color = ColorObject.Black;
            textpart1.Font.FontSize = 15;
        }
        # endregion

        # region Slide3
        private void CreateSlide3(IPresentation presentation)
        {
            ISlide slide2 = presentation.Slides.Add(SlideLayoutType.TwoContent);
            IShape shape1 = slide2.Shapes[0] as IShape;
            shape1.Left = 0.36 * 72;
            shape1.Top = 0.51 * 72;
            shape1.Width = 11.32 * 72;
            shape1.Height = 1.06 * 72;

            //Adds textframe in shape
            ITextBody textFrame1 = shape1.TextBody;

            //Instance to hold paragraphs in textframe
            IParagraphs paragraphs1 = textFrame1.Paragraphs;
            paragraphs1.Add();
            IParagraph paragraph1 = paragraphs1[0];
            ITextPart textpart1 = paragraph1.AddTextPart();
            paragraph1.HorizontalAlignment = HorizontalAlignmentType.Left;

            //Assigns value to textpart
            textpart1.Text = "Slide with Image";
            textpart1.Font.FontName = "Helvetica CE 35 Thin";

            //Adds shape in slide
            IShape shape2 = slide2.Shapes[1] as IShape;
            shape2.Left = 8.03 * 72;
            shape2.Top = 1.96 * 72;
            shape2.Width = 4.39 * 72;
            shape2.Height = 4.53 * 72;
            ITextBody textFrame2 = shape2.TextBody;

            //Instance to hold paragraphs in textframe
            IParagraphs paragraphs2 = textFrame2.Paragraphs;
            IParagraph paragraph2 = paragraphs2.Add();
            ITextPart textpart2 = paragraph2.AddTextPart();
            paragraph1.HorizontalAlignment = HorizontalAlignmentType.Left;

            textpart2.Text = "Lorem ipsum dolor sit amet, lacus amet amet ultricies. Quisque mi venenatis morbi libero, orci dis, mi ut et class porta, massa ligula magna enim, aliquam orci vestibulum tempus.";
            textpart2.Font.FontName = "Helvetica CE 35 Thin";
            textpart2.Font.FontSize = 16;

            IParagraph paragraph3 = paragraphs2.Add();
            textpart2 = paragraph3.AddTextPart();
            paragraph3.HorizontalAlignment = HorizontalAlignmentType.Left;

            textpart2.Text = "Turpis facilisis vitae consequat, cum a a, turpis dui consequat massa in dolor per, felis non amet.";
            textpart2.Font.FontName = "Helvetica CE 35 Thin";
            textpart2.Font.FontSize = 16;


            IParagraph paragraph4 = paragraphs2.Add();
            textpart2 = paragraph4.AddTextPart();
            paragraph4.HorizontalAlignment = HorizontalAlignmentType.Left;

            textpart2.Text = "Auctor eleifend in omnis elit vestibulum, donec non elementum tellus est mauris, id aliquam, at lacus, arcu pretium proin lacus dolor et. Eu tortor, vel ultrices amet dignissim mauris vehicula.";
            textpart2.Font.FontName = "Helvetica CE 35 Thin";
            textpart2.Font.FontSize = 16;
    
            IShape shape3 = (IShape)slide2.Shapes[2];
            slide2.Shapes.RemoveAt(2);

            //Adds picture in the shape
#if !NETCore
            Stream imageStream = File.Open(@"..\..\..\..\..\..\common\Images\Presentation\tablet.jpg", FileMode.Open);
#else
            Stream imageStream = File.Open(@"..\..\..\..\..\..\..\common\Images\Presentation\tablet.jpg", FileMode.Open);
#endif
            IPicture picture1 = slide2.Shapes.AddPicture(imageStream, 0.81 * 72, 1.96 * 72, 6.63 * 72, 4.43 * 72);
            imageStream.Close();
           
        }
        # endregion

        # region Slide4
        private void CreateSlide4(IPresentation presentation)
        {
            ISlide slide4 = presentation.Slides.Add(SlideLayoutType.TwoContent);
            IShape shape1 = slide4.Shapes[0] as IShape;
            shape1.Left = 0.51 * 72;
            shape1.Top = 0.34 * 72;
            shape1.Width = 11.32 * 72;
            shape1.Height = 1.06 * 72;

            ITextBody textFrame1 = shape1.TextBody;

            //Instance to hold paragraphs in textframe
            IParagraphs paragraphs1 = textFrame1.Paragraphs;
            paragraphs1.Add();
            IParagraph paragraph1 = paragraphs1[0];
            ITextPart textpart1 = paragraph1.AddTextPart();
            paragraph1.HorizontalAlignment = HorizontalAlignmentType.Left;

            //Assigns value to textpart
            textpart1.Text = "Slide with Table";
            textpart1.Font.FontName = "Helvetica CE 35 Thin";

            IShape shape2 = slide4.Shapes[1] as IShape;
            slide4.Shapes.Remove(shape2);

            ITable table = (ITable)slide4.Shapes.AddTable(6,6, 0.81 * 72, 2.14 * 72, 11.43 * 72, 3.8 * 72);
            table.Rows[0].Height = 0.85 * 72;
            table.Rows[1].Height = 0.42 * 72;
            table.Rows[2].Height = 0.85* 72;
            table.Rows[3].Height = 0.85 * 72;
            table.Rows[4].Height = 0.85 * 72;
            table.Rows[5].Height = 0.85 * 72;
            table.HasBandedRows = true;
            table.HasHeaderRow=true;
            table.HasBandedColumns = false;
            table.BuiltInStyle = BuiltInTableStyle.MediumStyle2Accent1;

            ICell cell1 = table.Rows[0].Cells[0];
            ITextBody textFrame2 = cell1.TextBody;
            IParagraph paragraph2 = textFrame2.Paragraphs.Add();
            paragraph2.HorizontalAlignment = HorizontalAlignmentType.Center;
            ITextPart textPart2 = paragraph2.AddTextPart();
            textPart2.Text = "ID";

            ICell cell2 = table.Rows[0].Cells[1];
            ITextBody textFrame3 = cell2.TextBody;
            IParagraph paragraph3 = textFrame3.Paragraphs.Add();
            paragraph3.HorizontalAlignment = HorizontalAlignmentType.Center;
            ITextPart textPart3 = paragraph3.AddTextPart();
            textPart3.Text = "Company Name";

            ICell cell3 = table.Rows[0].Cells[2];
            ITextBody textFrame4 = cell3.TextBody;
            IParagraph paragraph4 = textFrame4.Paragraphs.Add();
            paragraph4.HorizontalAlignment = HorizontalAlignmentType.Center;
            ITextPart textPart4 = paragraph4.AddTextPart();
            textPart4.Text = "Contact Name";

            ICell cell4 = table.Rows[0].Cells[3];
            ITextBody textFrame5 = cell4.TextBody;
            IParagraph paragraph5 = textFrame5.Paragraphs.Add();
            paragraph5.HorizontalAlignment = HorizontalAlignmentType.Center;
            ITextPart textPart5 = paragraph5.AddTextPart();
            textPart5.Text = "Address";

            ICell cell5 = table.Rows[0].Cells[4];
            ITextBody textFrame6 = cell5.TextBody;
            IParagraph paragraph6 = textFrame6.Paragraphs.Add();
            paragraph6.HorizontalAlignment = HorizontalAlignmentType.Center;
            ITextPart textPart6 = paragraph6.AddTextPart();
            textPart6.Text = "City";

            ICell cell6 = table.Rows[0].Cells[5];
            ITextBody textFrame7 = cell6.TextBody;
            IParagraph paragraph7 = textFrame7.Paragraphs.Add();
            paragraph7.HorizontalAlignment = HorizontalAlignmentType.Center;
            ITextPart textPart7 = paragraph7.AddTextPart();
            textPart7.Text = "Country";

             cell1 = table.Rows[1].Cells[0];
             textFrame1 = cell1.TextBody;
             paragraph1 = textFrame1.Paragraphs.Add();
             paragraph1.HorizontalAlignment = HorizontalAlignmentType.Center;
             textpart1= paragraph1.AddTextPart();
             textpart1.Text = "1";

            cell1 = table.Rows[1].Cells[1];
            textFrame1 = cell1.TextBody;
            paragraph1 = textFrame1.Paragraphs.Add();
            paragraph1.HorizontalAlignment = HorizontalAlignmentType.Center;
            textpart1 = paragraph1.AddTextPart();
            textpart1.Text = "New Orleans Cajun Delights";

            cell1 = table.Rows[1].Cells[2];
            textFrame1 = cell1.TextBody;
            paragraph1 = textFrame1.Paragraphs.Add();
            paragraph1.HorizontalAlignment = HorizontalAlignmentType.Center;
            textpart1 = paragraph1.AddTextPart();
            textpart1.Text = "Shelley Burke";

            cell1 = table.Rows[1].Cells[3];
            textFrame1 = cell1.TextBody;
            paragraph1 = textFrame1.Paragraphs.Add();
            paragraph1.HorizontalAlignment = HorizontalAlignmentType.Center;
            textpart1 = paragraph1.AddTextPart();
            textpart1.Text = "P.O. Box 78934";

            cell1 = table.Rows[1].Cells[4];
            textFrame1 = cell1.TextBody;
            paragraph1 = textFrame1.Paragraphs.Add();
            paragraph1.HorizontalAlignment = HorizontalAlignmentType.Center;
            textpart1 = paragraph1.AddTextPart();
            textpart1.Text = "New Orleans";

            cell1 = table.Rows[1].Cells[5];
            textFrame1 = cell1.TextBody;
            paragraph1 = textFrame1.Paragraphs.Add();
            paragraph1.HorizontalAlignment = HorizontalAlignmentType.Center;
            textpart1 = paragraph1.AddTextPart();
            textpart1.Text = "USA";

            cell1 = table.Rows[2].Cells[0];
            textFrame1 = cell1.TextBody;
            paragraph1 = textFrame1.Paragraphs.Add();
            paragraph1.HorizontalAlignment = HorizontalAlignmentType.Center;
            textpart1 = paragraph1.AddTextPart();
            textpart1.Text = "2";

            cell1 = table.Rows[2].Cells[1];
            textFrame1 = cell1.TextBody;
            paragraph1 = textFrame1.Paragraphs.Add();
            paragraph1.HorizontalAlignment = HorizontalAlignmentType.Center;
            textpart1 = paragraph1.AddTextPart();
            textpart1.Text = "Cooperativa de Quesos 'Las Cabras";

            cell1 = table.Rows[2].Cells[2];
            textFrame1 = cell1.TextBody;
            paragraph1 = textFrame1.Paragraphs.Add();
            paragraph1.HorizontalAlignment = HorizontalAlignmentType.Center;
            textpart1 = paragraph1.AddTextPart();
            textpart1.Text = "Antonio del Valle Saavedra";

            cell1 = table.Rows[2].Cells[3];
            textFrame1 = cell1.TextBody;
            paragraph1 = textFrame1.Paragraphs.Add();
            paragraph1.HorizontalAlignment = HorizontalAlignmentType.Center;
            textpart1 = paragraph1.AddTextPart();
            textpart1.Text = "Calle del Rosal 4";

            cell1 = table.Rows[2].Cells[4];
            textFrame1 = cell1.TextBody;
            paragraph1 = textFrame1.Paragraphs.Add();
            paragraph1.HorizontalAlignment = HorizontalAlignmentType.Center;
            textpart1 = paragraph1.AddTextPart();
            textpart1.Text = "Oviedo";

            cell1 = table.Rows[2].Cells[5];
            textFrame1 = cell1.TextBody;
            paragraph1 = textFrame1.Paragraphs.Add();
            paragraph1.HorizontalAlignment = HorizontalAlignmentType.Center;
            textpart1 = paragraph1.AddTextPart();
            textpart1.Text = "Spain";

            cell1 = table.Rows[3].Cells[0];
            textFrame1 = cell1.TextBody;
            paragraph1 = textFrame1.Paragraphs.Add();
            paragraph1.HorizontalAlignment = HorizontalAlignmentType.Center;
            textpart1 = paragraph1.AddTextPart();
            textpart1.Text = "3";

            cell1 = table.Rows[3].Cells[1];
            textFrame1 = cell1.TextBody;
            paragraph1 = textFrame1.Paragraphs.Add();
            paragraph1.HorizontalAlignment = HorizontalAlignmentType.Center;
            textpart1 = paragraph1.AddTextPart();
            textpart1.Text = "Mayumi";

            cell1 = table.Rows[3].Cells[2];
            textFrame1 = cell1.TextBody;
            paragraph1 = textFrame1.Paragraphs.Add();
            paragraph1.HorizontalAlignment = HorizontalAlignmentType.Center;
            textpart1 = paragraph1.AddTextPart();
            textpart1.Text = "Mayumi Ohno";

            cell1 = table.Rows[3].Cells[3];
            textFrame1 = cell1.TextBody;
            paragraph1 = textFrame1.Paragraphs.Add();
            paragraph1.HorizontalAlignment = HorizontalAlignmentType.Center;
            textpart1 = paragraph1.AddTextPart();
            textpart1.Text = "92 Setsuko Chuo-ku";

            cell1 = table.Rows[3].Cells[4];
            textFrame1 = cell1.TextBody;
            paragraph1 = textFrame1.Paragraphs.Add();
            paragraph1.HorizontalAlignment = HorizontalAlignmentType.Center;
            textpart1 = paragraph1.AddTextPart();
            textpart1.Text = "Osaka";

            cell1 = table.Rows[3].Cells[5];
            textFrame1 = cell1.TextBody;
            paragraph1 = textFrame1.Paragraphs.Add();
            paragraph1.HorizontalAlignment = HorizontalAlignmentType.Center;
            textpart1 = paragraph1.AddTextPart();
            textpart1.Text = "Japan";

            cell1 = table.Rows[4].Cells[0];
            textFrame1 = cell1.TextBody;
            paragraph1 = textFrame1.Paragraphs.Add();
            paragraph1.HorizontalAlignment = HorizontalAlignmentType.Center;
            textpart1 = paragraph1.AddTextPart();
            textpart1.Text = "4";

            cell1 = table.Rows[4].Cells[1];
            textFrame1 = cell1.TextBody;
            paragraph1 = textFrame1.Paragraphs.Add();
            paragraph1.HorizontalAlignment = HorizontalAlignmentType.Center;
            textpart1 = paragraph1.AddTextPart();
            textpart1.Text = "Pavlova, Ltd.";

            cell1 = table.Rows[4].Cells[2];
            textFrame1 = cell1.TextBody;
            paragraph1 = textFrame1.Paragraphs.Add();
            paragraph1.HorizontalAlignment = HorizontalAlignmentType.Center;
            textpart1 = paragraph1.AddTextPart();
            textpart1.Text = "Ian Devling";

            cell1 = table.Rows[4].Cells[3];
            textFrame1 = cell1.TextBody;
            paragraph1 = textFrame1.Paragraphs.Add();
            paragraph1.HorizontalAlignment = HorizontalAlignmentType.Center;
            textpart1 = paragraph1.AddTextPart();
            textpart1.Text = "74 Rose St. Moonie Ponds";

            cell1 = table.Rows[4].Cells[4];
            textFrame1 = cell1.TextBody;
            paragraph1 = textFrame1.Paragraphs.Add();
            paragraph1.HorizontalAlignment = HorizontalAlignmentType.Center;
            textpart1 = paragraph1.AddTextPart();
            textpart1.Text = "Melbourne";

            cell1 = table.Rows[4].Cells[5];
            textFrame1 = cell1.TextBody;
            paragraph1 = textFrame1.Paragraphs.Add();
            paragraph1.HorizontalAlignment = HorizontalAlignmentType.Center;
            textpart1 = paragraph1.AddTextPart();
            textpart1.Text = "Australia";

            cell1 = table.Rows[5].Cells[0];
            textFrame1 = cell1.TextBody;
            paragraph1 = textFrame1.Paragraphs.Add();
            paragraph1.HorizontalAlignment = HorizontalAlignmentType.Center;
            textpart1 = paragraph1.AddTextPart();
            textpart1.Text = "5";

            cell1 = table.Rows[5].Cells[1];
            textFrame1 = cell1.TextBody;
            paragraph1 = textFrame1.Paragraphs.Add();
            paragraph1.HorizontalAlignment = HorizontalAlignmentType.Center;
            textpart1 = paragraph1.AddTextPart();
            textpart1.Text = "Specialty Biscuits, Ltd.";

            cell1 = table.Rows[5].Cells[2];
            textFrame1 = cell1.TextBody;
            paragraph1 = textFrame1.Paragraphs.Add();
            paragraph1.HorizontalAlignment = HorizontalAlignmentType.Center;
            textpart1 = paragraph1.AddTextPart();
            textpart1.Text = "Peter Wilson";

            cell1 = table.Rows[5].Cells[3];
            textFrame1 = cell1.TextBody;
            paragraph1 = textFrame1.Paragraphs.Add();
            paragraph1.HorizontalAlignment = HorizontalAlignmentType.Center;
            textpart1 = paragraph1.AddTextPart();
            textpart1.Text = "29 King's Way";

            cell1 = table.Rows[5].Cells[4];
            textFrame1 = cell1.TextBody;
            paragraph1 = textFrame1.Paragraphs.Add();
            paragraph1.HorizontalAlignment = HorizontalAlignmentType.Center;
            textpart1 = paragraph1.AddTextPart();
            textpart1.Text = "Manchester";

            cell1 = table.Rows[5].Cells[5];
            textFrame1 = cell1.TextBody;
            paragraph1 = textFrame1.Paragraphs.Add();
            paragraph1.HorizontalAlignment = HorizontalAlignmentType.Center;
            textpart1 = paragraph1.AddTextPart();
            textpart1.Text = "UK";

            slide4.Shapes.RemoveAt(1);

        }
        #endregion




    }
}

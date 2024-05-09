#region Copyright Syncfusion Inc. 2001-2024.
// Copyright Syncfusion Inc. 2001-2024. All rights reserved.
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

namespace Images
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
            this.btnCreatePresn.Location = new System.Drawing.Point(268, 152);
            this.btnCreatePresn.Name = "btnCreatePresn";
            this.btnCreatePresn.Size = new System.Drawing.Size(113, 27);
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
            this.pictureBox1.Size = new System.Drawing.Size(381, 97);
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
            this.label1.Location = new System.Drawing.Point(0, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(370, 42);
            this.label1.TabIndex = 27;
            this.label1.Text = "Click the button to view a presentation generated by Essential Presentation.\r\nPle" +
    "ase note that Microsoft PowerPoint viewer is required to view the resultant\r\nPresentation.\r" +
    "\n";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 202);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnCreatePresn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Images";
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

        #endregion

        private void btnCreatePresn_Click(object sender, EventArgs e)
        {

            IPresentation pptxDoc = Presentation.Create();
            //New Instance of PowerPoint is Created.[Equivalent to launching MS PowerPoint with no slides].

            //Add a blank slide to Presentation.
            ISlide firstSlide = pptxDoc.Slides.Add(SlideLayoutType.Blank);

            //Add a title text box to the slide.
            IShape titleShape = firstSlide.Shapes.AddTextBox(55, 23, 853, 72);
            //Set vertical alignment to the text body.
            titleShape.TextBody.VerticalAlignment = VerticalAlignmentType.Bottom;
            //Add a title paragraph.
            IParagraph titleParagraph = titleShape.TextBody.AddParagraph();
            //Set the alignment properties for the paragraph.
            titleParagraph.HorizontalAlignment = HorizontalAlignmentType.Center;
            //Add a text part.
            ITextPart titleTextPart = titleParagraph.AddTextPart("Adventure Works Cycles");
            //Set the font properties for the text part.
            titleTextPart.Font.FontSize = 36;

            //Add a content text box to the slide.
            IShape textbox = firstSlide.Shapes.AddTextBox(66, 132, 543, 350);
            //Add the first paragraph.
            IParagraph paragraph1 = textbox.TextBody.AddParagraph();
            //Set bulleted list type.
            paragraph1.ListFormat.Type = ListType.Bulleted;
            //Set paragraph properties.
            paragraph1.LeftIndent = 22;
            paragraph1.FirstLineIndent = -22;
            paragraph1.LineSpacing = 38;
            paragraph1.SpaceBefore = 10;
            //Add a new text part.
            paragraph1.AddTextPart("Adventure Works Cycles, the fictitious company on which the Adventure Works sample databases are based, is a large, multinational manufacturing company.");

            //Add the second paragraph.
            IParagraph paragraph2 = textbox.TextBody.AddParagraph();
            //Set bulleted list type.
            paragraph2.ListFormat.Type = ListType.Bulleted;
            //Set paragraph properties.
            paragraph2.LeftIndent = 22;
            paragraph2.FirstLineIndent = -22;
            paragraph2.LineSpacing = 38;
            paragraph2.SpaceBefore = 10;
            //Add a new text part.
            paragraph2.AddTextPart("The company manufactures and sells metal and composite bicycles to North American, European, and Asian commercial markets. While its base operation is located in Bothell, Washington, with 290 employees, several regional sales teams are located throughout their market base.");

            //Create an instance for the image as a stream.
#if !NETCore
            Stream imageStream = File.Open(@"..\..\..\..\..\..\common\Images\Presentation\CycleLogo.jpg", FileMode.Open);
#else
            Stream imageStream = File.Open(@"..\..\..\..\..\..\..\common\Images\Presentation\CycleLogo.jpg", FileMode.Open);
#endif
            //Add a picture to the shape collection.
            IPicture picture = firstSlide.Shapes.AddPicture(imageStream, 610, 246, 328, 123);
            //Add alternate text to the picture.
            picture.Description = "Adventure Works Cycles Logo";
            //Apply bounding box size and position.
            picture.Crop.ContainerWidth = 328f;
            picture.Crop.ContainerHeight = 123f;
            picture.Crop.ContainerLeft = 609f;
            picture.Crop.ContainerTop = 246f;
            //Apply cropping size and offsets.
            picture.Crop.Width = 370f;
            picture.Crop.Height = 151f;
            picture.Crop.OffsetX = -4.32f;
            picture.Crop.OffsetY = 1.44f;

            //Add a title-only slide to Presentation.
            ISlide secondSlide = pptxDoc.Slides.Add(SlideLayoutType.TitleOnly);
            //Retrieve the first shape of the slide.
            IShape titleShape2 = secondSlide.Shapes[0] as IShape;
            //Add a title paragraph.
            IParagraph titleParagraph2 = titleShape2.TextBody.AddParagraph();
            //Set the alignment properties for the paragraph.
            titleParagraph2.HorizontalAlignment = HorizontalAlignmentType.Center;
            //Add a text part.
            ITextPart titleTextPart2 = titleParagraph2.AddTextPart("About Adventure Works Cycles");
            //Set the font properties for the text part.
            titleTextPart2.Font.FontName = "Calibri";
            titleTextPart2.Font.FontSize = 40;

            //Get an SVG image as a stream.
#if !NETCore
            Stream svgImageStream = File.Open(@"..\..\..\..\..\..\common\Images\Presentation\About.svg", FileMode.Open);
#else
            Stream svgImageStream = File.Open(@"..\..\..\..\..\..\..\common\Images\Presentation\About.svg", FileMode.Open);
#endif
            //Get a fallback image as a stream.
#if !NETCore
            Stream fallbackImageStream = File.Open(@"..\..\..\..\..\..\common\Images\Presentation\About.png", FileMode.Open);
#else
            Stream fallbackImageStream = File.Open(@"..\..\..\..\..\..\..\common\Images\Presentation\About.png", FileMode.Open);
#endif
            //Add the SVG picture to a slide by specifying its size and position.
            IPicture svgPicture = secondSlide.Pictures.AddPicture(svgImageStream, fallbackImageStream, 172, 155, 643, 256);
            //Add alternate text to the picture.
            svgPicture.Description = "About Adventure Works Cycles";

            //Saves the presentation
            pptxDoc.Save("ImageSample.pptx");

            //Close the image streams.
            imageStream.Close();
            svgImageStream.Close();
            fallbackImageStream.Close();

            if (MessageBox.Show("Do you want to view the generated Presentation?", "Presentation Created",
                MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
#if !NETCore
                System.Diagnostics.Process.Start("ImageSample.pptx");
#else
                System.Diagnostics.Process process = new System.Diagnostics.Process();
                process.StartInfo = new System.Diagnostics.ProcessStartInfo("ImageSample.pptx")
                {
                    UseShellExecute = true
                };
                process.Start();
#endif
                this.Close();
            }
        }

    }
}

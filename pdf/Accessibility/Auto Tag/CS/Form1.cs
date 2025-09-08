#region Copyright Syncfusion Inc. 2001 - 2017
//
//  Copyright Syncfusion Inc. 2001 - 2017. All rights reserved.
//
//  Use of this code is subject to the terms of our license.
//  A copy of the current license can be obtained at any time by e-mailing
//  licensing@syncfusion.com. Re-distribution in any form is strictly
//  prohibited. Any infringement will be prosecuted under applicable laws. 
//
#endregion

using System;
using System.Drawing;
using System.Windows.Forms;
using Syncfusion.Pdf;
using Syncfusion.Windows.Forms;
using Syncfusion.Pdf.Graphics;
using Syncfusion.Pdf.Interactive;
using Syncfusion.Licensing;

namespace EssentialPDFSamples
{
    /// <summary>
    /// Summary description for Form1.
    /// </summary>
    public class Form1 : MetroForm
    {
        # region Private Members
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private Label label2;
        private RadioButton radioButton3;

        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.Container components = null;
        # endregion

        # region Constructor
        public Form1()
        {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();
            this.MinimizeBox = true;
            Application.EnableVisualStyles();			

            //
            // TODO: Add any constructor code after InitializeComponent call
            //
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(494, 225);
            this.button1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 37);
            this.button1.TabIndex = 0;
            this.button1.Text = "PDF";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(0, 155);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(660, 129);
            this.label1.TabIndex = 1;
            this.label1.Text = "Click the button to view an PDF document generated by Essential PDF.  Please note" +
    " that Adobe Reader or its equivalent is required to view the resultant document." +
    "";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
                      this.pictureBox1.Image = System.Drawing.Image.FromFile(GetFullTemplatePath("pdf_header.png", true));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            this.pictureBox1.Size = new System.Drawing.Size(373, 89);
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(4, 242);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(89, 20);
            this.radioButton1.TabIndex = 25;
            this.radioButton1.TabStop = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Text = "PDF/UA-1";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(110, 242);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(89, 20);
            this.radioButton2.TabIndex = 26;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "PDF/UA-2";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1, 205);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 16);
            this.label2.TabIndex = 27;
            this.label2.Text = "Accessibility Level";
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(215, 242);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(137, 20);
            this.radioButton3.TabIndex = 28;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Well Tagged PDF";
            this.radioButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;

            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(658, 294);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
              this.Icon = System.Drawing.Icon.ExtractAssociatedIcon(GetFullTemplatePath("syncfusion.ico", true));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Autotag Document";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);           

        }
        #endregion

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
			SyncfusionLicenseProvider.RegisterLicense(DemoCommon.FindLicenseKey());
            Application.Run(new Form1());
        }
        #endregion

        # region Events
        private void button1_Click(object sender, System.EventArgs e)
        {
            #region content string
            string toc = "\r\n What can I do with C#? ..................................................................................................................................... 3 \r\n \r\n What is .NET? .................................................................................................................................................... 3 \r\n \r\n Writing, Running, and Deploying a C# Program .............................................................................................. 3 \r\n \r\n Starting a New Program..................................................................................................................................... 3";
            string Csharp = "Welcome to C# Succinctly. True to the Succinctly series concept, this book is very focused on a single topic: the C# programming language. I might briefly mention some technologies that you can write with C# or explain how a feature fits into those technologies, but the whole of this book is about helping you become familiar with C# syntax. \r\n \r\n In this chapter, Ill start with some introductory information and then jump straight into a simple C# program.";
            string whatToD0 = "C# is a general purpose, object-oriented, component-based programming language. As a general purpose language, you have a number of ways to apply C# to accomplish many different tasks. You can build web applications with ASP.NET, desktop applications with Windows Presentation Foundation (WPF), or build mobile applications for Windows Phone. Other applications include code that runs in the cloud via Windows Azure, and iOS, Android, and Windows Phone support with the Xamarin platform. There might be times when you need a different language, like C or C++, to communicate with hardware or real-time systems. However, from a general programming perspective, you can do a lot with C#.";
            string dotnet = "The runtime is more formally named the Common Language Runtime (CLR). Programming languages that target the CLR compile to an Intermediate Language (IL). The CLR itself is a virtual machine that runs IL and provides many services such as memory management, garbage collection, exception management, security, and more.\r\n \r\n The Framework Class Library (FCL) is a set of reusable code that provides both general services and technology-specific platforms. The general services include essential types such as collections, cryptography, networking, and more. In addition to general classes, the FCL includes technology-specific platforms like ASP.NET, WPF, web services, and more. The value the FCL offers is to have common components available for reuse, saving time and money without needing to write that code yourself. \r\n \r\n There is a huge ecosystem of open-source and commercial software that relies on and supports .NET. If you visit CodePlex, GitHub, or any other open-source code repository site, you will see a multitude of projects written in C#. Commercial offerings include tools and services that help you build code, manage systems, and offer applications. Syncfusion is part of this ecosystem, offering reusable components for many of the .NET technologies I have mentioned.";
            string prog = "The previous section described plenty of great things you can do with C#, but most of them are so detailed that they require their own book. To stay focused on the C# programming language, the code in this book will be for the console application. A console application runs on the command line, which you will learn about in this section. You can write your code with any editor, but this book uses Visual Studio.";

            #endregion

            //Create a new PDF document.
             PdfDocument document = new PdfDocument();
            if (radioButton3 != null && radioButton3.Checked)
            {
                document = new PdfDocument(PdfConformanceLevel.Pdf_A4);
                document.FileStructure.Version = PdfVersion.Version2_0;

            }

            else if (radioButton2 != null && radioButton2.Checked)
            {
                document.FileStructure.Version = PdfVersion.Version2_0;
            }
            //Auto Tag the document 
            document.AutoTag = true;
            document.DocumentInformation.Title = "AutoTag";
            #region page1
            //Add a page to the document.

            PdfPage page1 = document.Pages.Add();

            //Load the image from the disk.

            PdfBitmap image = new PdfBitmap(GetFullTemplatePath("Autotag.jpg", true));

            //Draw the image

            page1.Graphics.DrawImage(image, 0, 0, page1.GetClientSize().Width, page1.GetClientSize().Height - 20);

            #endregion

            #region page2
            PdfPage page2 = document.Pages.Add();

            PdfFont fontnormal = new PdfTrueTypeFont(new Font("Arial", 9, FontStyle.Regular), true);
            PdfFont fontTitle = new PdfTrueTypeFont(new Font("Arial", 22, FontStyle.Bold),  true);
            PdfFont fontHead = new PdfTrueTypeFont(new Font("Arial", 10, FontStyle.Bold), true);
            PdfFont fontHead2 = new PdfTrueTypeFont(new Font("Arial", 18, FontStyle.Bold),true);

            page2.Graphics.DrawString("Table of Contents", fontTitle, PdfBrushes.Black, new PointF(300, 0));
            page2.Graphics.DrawLine(new PdfPen(PdfBrushes.Black, 0.5f), new PointF(0, 40), new PointF(page2.GetClientSize().Width, 40));

            page2.Graphics.DrawString("Chapter 1 Introducing C# and .NET .............................................................................................................. 3 \r\n ", fontHead, PdfBrushes.Black, new PointF(0, 60));
            page2.Graphics.DrawString(toc, fontnormal, PdfBrushes.Black, new PointF(0, 80));

            #endregion

            #region page3

            PdfPage page3 = document.Pages.Add();

            page3.Graphics.DrawString("C# Succinctly", new PdfTrueTypeFont(new Font("Arial", 32, FontStyle.Bold),true), PdfBrushes.Black, new PointF(160, 0));

            page3.Graphics.DrawLine(PdfPens.Black, new PointF(0, 40), new PointF(page3.GetClientSize().Width, 40));

            page3.Graphics.DrawString("Chapter 1 Introducing C# and .NET", fontTitle, PdfBrushes.Black, new PointF(160, 60));


            PdfTextElement element1 = new PdfTextElement(Csharp, fontnormal);
            element1.Brush = new PdfSolidBrush(Color.Black);
            element1.Draw(page3, new RectangleF(0, 100, page3.GetClientSize().Width, 80));

            page3.Graphics.DrawString("What can I do with C#?", fontHead2, PdfBrushes.Black, new PointF(0, 180));
            PdfTextElement element2 = new PdfTextElement(whatToD0, fontnormal);
            element2.Brush = new PdfSolidBrush(Color.Black);
            element2.Draw(page3, new RectangleF(0, 210, page3.GetClientSize().Width, 80));


            page3.Graphics.DrawString("What is .Net", fontHead2, PdfBrushes.Black, new PointF(0, 300));
            PdfTextElement element3 = new PdfTextElement(dotnet, fontnormal);
            element3.Brush = new PdfSolidBrush(Color.Black);
            element3.Draw(page3, new RectangleF(0, 330, page3.GetClientSize().Width, 180));


            page3.Graphics.DrawString("Writing, Running, and Deploying a C# Program", fontHead2, PdfBrushes.Black, new PointF(0, 520));
            PdfTextElement element4 = new PdfTextElement(prog, fontnormal);
            element4.Brush = new PdfSolidBrush(Color.Black);
            element4.Draw(page3, new RectangleF(0, 550, page3.GetClientSize().Width, 60));

            PdfBitmap img = new PdfBitmap(GetFullTemplatePath("autotagsmall.jpg", true));
            page3.Graphics.DrawImage(img, new PointF(0, 630));
            page3.Graphics.DrawString("Note: The code samples in this book can be downloaded at", fontnormal, PdfBrushes.DarkBlue, new PointF(20, 630));
            page3.Graphics.DrawString("https://bitbucket.org/syncfusiontech/c-succinctly", fontnormal, PdfBrushes.Blue, new PointF(20, 640));
            SizeF linkSize = fontnormal.MeasureString("https://bitbucket.org/syncfusiontech/c-succinctly");
            RectangleF rectangle = new RectangleF(20, 640, linkSize.Width, linkSize.Height);

            //Creates a new Uri Annotation

            PdfUriAnnotation uriAnnotation = new PdfUriAnnotation(rectangle, "https://bitbucket.org/syncfusiontech/c-succinctly");
            // uriAnnotation.Border = new  PdfAnnotationBorder()
            uriAnnotation.Color = new PdfColor(255, 255, 255);
            //Adds alternative description for annotation
            uriAnnotation.Text = "annotation";
            //Adds this annotation to a new page
            page3.Annotations.Add(uriAnnotation);


            #endregion
           

            //Save the document and dispose it.
            document.Save("Sample.pdf");
            document.Close(true);

            //Message box confirmation to view the created PDF document.
            if (MessageBox.Show("Do you want to view the PDF file?", "PDF File Created",
                MessageBoxButtons.YesNo, MessageBoxIcon.Information)
                == DialogResult.Yes)
            {
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
                // Exit
                this.Close();
            }
        }

      
        #endregion
        #region Helper Methods
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
    /// <summary>
    /// Represents a class that is used to find the licensing file for Syncfusion controls.
    /// </summary>
    public class DemoCommon
    {

        /// <summary>
        /// Finds the license key from the Common folder.
        /// </summary>
        /// <returns>Returns the license key.</returns>
        public static string FindLicenseKey()
        {

            string licenseKeyFile = "Common\\SyncfusionLicense.txt";
            for (int n = 0; n < 20; n++)
            {
                if (!System.IO.File.Exists(licenseKeyFile))
                {
                    licenseKeyFile = @"..\" + licenseKeyFile;
                    continue;
                }
                return System.IO.File.ReadAllText(licenseKeyFile);
            }
            return string.Empty;
        }
    }
}

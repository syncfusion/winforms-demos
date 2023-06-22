#region Copyright Syncfusion Inc. 2001-2023.
// Copyright Syncfusion Inc. 2001-2023. All rights reserved.
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
using Syncfusion.Licensing;
using System.Reflection;

namespace CreatePresentation
{
    public partial class Form1 : MetroForm
    {
        #region Private Members
        private System.Windows.Forms.Button btnCreatePresn;
        private System.Windows.Forms.Button btnOpenEmbeddedFile;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private Label label2;

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
            this.btnOpenEmbeddedFile = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCreatePresn
            // 
            this.btnCreatePresn.Location = new System.Drawing.Point(268, 153);
            this.btnCreatePresn.Name = "btnCreatePresn";
            this.btnCreatePresn.Size = new System.Drawing.Size(113, 27);
            this.btnCreatePresn.TabIndex = 0;
            this.btnCreatePresn.Text = "Create Presentation";
            this.btnCreatePresn.UseVisualStyleBackColor = true;
            this.btnCreatePresn.Click += new System.EventHandler(this.btnCreatePresn_Click);
            // 
            // btnOpenEmbeddedFile
            // 
            this.btnOpenEmbeddedFile.Location = new System.Drawing.Point(262, 254);
            this.btnOpenEmbeddedFile.Name = "btnOpenEmbeddedFile";
            this.btnOpenEmbeddedFile.Size = new System.Drawing.Size(119, 27);
            this.btnOpenEmbeddedFile.TabIndex = 0;
            this.btnOpenEmbeddedFile.Text = "Open Embedded File";
            this.btnOpenEmbeddedFile.UseVisualStyleBackColor = true;
            this.btnOpenEmbeddedFile.Click += new System.EventHandler(this.btnOpenEmbeddedFile_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
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
            this.label1.Size = new System.Drawing.Size(386, 42);
            this.label1.TabIndex = 27;
            this.label1.Text = "Click the button to view a presentation generated by Essential Presentation.\r\nPle" +
    "ase note that Microsoft PowerPoint viewer is required to view the resultant \r\nPr" +
    "esentation.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(386, 42);
            this.label2.TabIndex = 28;
            this.label2.Text = "Click the button to view a embedded OLE document opened by Essential \r\n" +
          "Presentation. Please note that Microsoft Word is required to view the \r\n" +
          "embedded Docx document.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 310);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnCreatePresn);
            this.Controls.Add(this.btnOpenEmbeddedFile);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OLE Object";
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
            //New Instance of PowerPoint is Created.[Equivalent to launching MS PowerPoint with no slides].
            IPresentation presentation = Presentation.Create();
            //Add slide with titleonly layout to presentation
            ISlide slide = presentation.Slides.Add(SlideLayoutType.TitleOnly);
            //Get the title placeholder
            IShape titleShape = slide.Shapes[0] as IShape;
            //Set size and position of the title shape
            titleShape.Left = 0.65 * 72;
            titleShape.Top = 0.24 * 72;
            titleShape.Width = 11.5 * 72;
            titleShape.Height = 1.45 * 72;

            //Add title content
            titleShape.TextBody.AddParagraph("Ole Object");
            //Set the title content as bold
            titleShape.TextBody.Paragraphs[0].Font.Bold = true;
            //Set the horizontal alignment as center
            titleShape.TextBody.Paragraphs[0].HorizontalAlignment = HorizontalAlignmentType.Left;
            //Add text box of specific size and position
            IShape heading = slide.Shapes.AddTextBox(0.84 * 72, 1.65 * 72, 2.23 * 72, 0.51 * 72);
            //Add paragraph to text box
            heading.TextBody.AddParagraph("MS Word Object");
            //Set the text content as italic
            heading.TextBody.Paragraphs[0].Font.Italic = true;
            //Set the text content as bold
            heading.TextBody.Paragraphs[0].Font.Bold = true;
            //Set the font size
            heading.TextBody.Paragraphs[0].Font.FontSize = 18;

#if !NETCore
            string mswordPath = @"..\..\..\..\..\..\common\Data\Presentation\OleTemplate.docx";
            string imagePath = @"..\..\..\..\..\..\common\Images\Presentation\OlePicture.png";
#else
            string mswordPath = @"..\..\..\..\..\..\..\common\Data\Presentation\OleTemplate.docx";
            string imagePath = @"..\..\..\..\..\..\..\common\Images\Presentation\OlePicture.png";
#endif
            //Get the excel file as stream
            Stream wordStream = File.Open(mswordPath, FileMode.Open);
            
            //Image to be displayed, This can be any image
            Stream imageStream = File.Open(imagePath, FileMode.Open);
            //Add ole object to the slide
            IOleObject oleObject = slide.Shapes.AddOleObject(imageStream, "Word.Document.12", wordStream);
            //Set size and position of the ole object
            oleObject.Left = 4.53 * 72;
            oleObject.Top = 0.79 * 72;
            oleObject.Width = 4.26 * 72;
            oleObject.Height = 5.92 * 72;
            //Set DisplayAsIcon as true, to open the embedded document in separate (default) application.
            oleObject.DisplayAsIcon = true;
            //Save the presentation
            presentation.Save("InsertOLEObject.pptx");
            //Close the presentation
            presentation.Close();

            if (MessageBox.Show("Do you want to view the generated Presentation?", "Presentation Created",
                MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
#if !NETCore
                System.Diagnostics.Process.Start("InsertOLEObject.pptx");
#else
                System.Diagnostics.Process process = new System.Diagnostics.Process();
                process.StartInfo = new System.Diagnostics.ProcessStartInfo("InsertOLEObject.pptx")
                {
                    UseShellExecute = true
                };
                process.Start();
#endif
                this.Close();
            }
        }

        private void btnOpenEmbeddedFile_Click(object sender, EventArgs e)
        {
#if !NETCore
            string filePath = @"..\..\..\..\..\..\common\Data\Presentation\EmbeddedOleObject.pptx";
#else
            string filePath = @"..\..\..\..\..\..\..\common\Data\Presentation\EmbeddedOleObject.pptx";
#endif
            IPresentation pptxDoc = Presentation.Open(filePath);
            //Gets the first slide of the Presentation
            ISlide slide = pptxDoc.Slides[0];
            //Gets the Ole Object of the slide
            IOleObject oleObject = slide.Shapes[2] as IOleObject;
            //Gets the file data of embedded Ole Object.
            byte[] array = oleObject.ObjectData;
            //Gets the file name of embedded Ole Object.
            string outputFile = oleObject.FileName;

            //Save the extracted Ole data into file system.
            MemoryStream memoryStream = new MemoryStream(array);
            FileStream fileStream = File.Create(outputFile);
            memoryStream.CopyTo(fileStream);
            memoryStream.Dispose();
            fileStream.Dispose();
            //Close the presentation
            pptxDoc.Close();

            if (MessageBox.Show("Do you want to view the extracted Embedded file?", "Extracted Embedded OLE File",
                MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
#if !NETCore
                System.Diagnostics.Process.Start(outputFile);
#else
                System.Diagnostics.Process process = new System.Diagnostics.Process();
                process.StartInfo = new System.Diagnostics.ProcessStartInfo(outputFile)
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

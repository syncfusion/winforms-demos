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
using Syncfusion.PresentationToPdfConverter;
using Syncfusion.Pdf;
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
        private RadioButton radioButton1;
        private RadioButton radioButton2;

        
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
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCreatePresn
            // 
            this.btnCreatePresn.Location = new System.Drawing.Point(254, 153);
            this.btnCreatePresn.Name = "btnCreatePresn";
            this.btnCreatePresn.Size = new System.Drawing.Size(127, 26);
            this.btnCreatePresn.TabIndex = 0;
            this.btnCreatePresn.Text = "Customize SmartArt";
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
            this.label1.Size = new System.Drawing.Size(362, 42);
            this.label1.TabIndex = 27;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(6, 162);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(141, 17);
            this.radioButton1.TabIndex = 28;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "PowerPoint Presentation";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(168, 162);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(65, 17);
            this.radioButton2.TabIndex = 29;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "PDF File";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 180);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnCreatePresn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customizing Appearance";
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
            try
            {
                string input = @"..\..\..\..\..\..\..\Common\Data\Presentation\SmartArts.pptx";
                IPresentation presentation = Presentation.Open(input);
                //New Instance of PowerPoint is Created.[Equivalent to launching MS PowerPoint with no slides].

                //Method call to edit slides
                CreateSlide1(presentation);
                CreateSlide2(presentation);
                CreateSlide3(presentation);
                if (this.radioButton1.Checked)
                {
                    //Saves the presentation as pptx format.
                    presentation.Save("SmartArtSample.pptx");

                    if (MessageBox.Show("Do you want to view the generated PowerPoint Presentation?", "PowerPoint Presentation Created",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {

                        System.Diagnostics.Process.Start("SmartArtSample.pptx");
                        this.Close();
                    }
                }
                else if (this.radioButton2.Checked)
                {
                    //To set each slide in a pdf page.
                    PresentationToPdfConverterSettings settings = new PresentationToPdfConverterSettings();

                    settings.ShowHiddenSlides = true;

                    //Instance to create pdf document from presentation
                    PdfDocument doc = PresentationToPdfConverter.Convert(presentation, settings);

                    //Saves the pdf document
                    doc.Save("Sample.pdf");
                    if (MessageBox.Show("Do you want to view the PDF document?", "Pdf docuemnt created",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        System.Diagnostics.Process.Start("Sample.pdf");

                    }
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show("This file could not be converted , please contact Syncfusion Direct-Trac system at http://www.syncfusion.com/support/default.aspx for any queries. ", "OOPS..Sorry!",
                        MessageBoxButtons.OK);

            }
        }
        # region Slide1
        private void CreateSlide1(IPresentation presentation)
        {
            ISlide slide1 = presentation.Slides[0];
            ISmartArt smartArt = slide1.Shapes[0] as ISmartArt;
            smartArt.Background.FillType = FillType.Solid;
            smartArt.Background.SolidFill.Color = ColorObject.Wheat;
            smartArt.Background.SolidFill.Transparency = 100;
            smartArt.Nodes[0].Shapes[0].Fill.FillType = FillType.Solid;
            smartArt.Nodes[0].Shapes[0].Fill.SolidFill.Color = ColorObject.CornflowerBlue;
            smartArt.Nodes[1].Shapes[0].Fill.FillType = FillType.Solid;
            smartArt.Nodes[1].Shapes[0].Fill.SolidFill.Color = ColorObject.CornflowerBlue;
            smartArt.Nodes[2].Shapes[0].Fill.FillType = FillType.Solid;
            smartArt.Nodes[2].Shapes[0].Fill.SolidFill.Color = ColorObject.CornflowerBlue;

        }
          #endregion

        # region Slide2
        private void CreateSlide2(IPresentation presentation)
        {
            ISlide slide2 = presentation.Slides[1];
            ISmartArt smartArt = slide2.Shapes[0] as ISmartArt;
            smartArt.Background.FillType = FillType.Solid;
            smartArt.Background.SolidFill.Color = ColorObject.Wheat;
            smartArt.Background.SolidFill.Transparency = 100;
            smartArt.Nodes[0].Shapes[0].Fill.FillType = FillType.Solid;
            smartArt.Nodes[0].Shapes[0].Fill.SolidFill.Color = ColorObject.CornflowerBlue;
            smartArt.Nodes[0].Shapes[0].LineFormat.Weight = 5;
            smartArt.Nodes[1].Shapes[0].Fill.FillType = FillType.Solid;
            smartArt.Nodes[1].Shapes[0].Fill.SolidFill.Color = ColorObject.CornflowerBlue;
            smartArt.Nodes[1].Shapes[0].LineFormat.Weight = 5;
            smartArt.Nodes[2].Shapes[0].Fill.FillType = FillType.Solid;
            smartArt.Nodes[2].Shapes[0].Fill.SolidFill.Color = ColorObject.CornflowerBlue;
            smartArt.Nodes[2].Shapes[0].LineFormat.Weight = 5;
            smartArt.Nodes[3].Shapes[0].Fill.FillType = FillType.Solid;
            smartArt.Nodes[3].Shapes[0].Fill.SolidFill.Color = ColorObject.CornflowerBlue;
            smartArt.Nodes[3].Shapes[0].LineFormat.Weight = 5;
            smartArt.Nodes[4].Shapes[0].Fill.FillType = FillType.Solid;
            smartArt.Nodes[4].Shapes[0].Fill.SolidFill.Color = ColorObject.CornflowerBlue;
            smartArt.Nodes[4].Shapes[0].LineFormat.Weight = 5;
            

        }

        #endregion

        # region Slide3
        private void CreateSlide3(IPresentation presentation)
        {
            ISlide slide2 = presentation.Slides[2];
            ISmartArt smartArt = slide2.Shapes[1] as ISmartArt;
            smartArt.Background.FillType = FillType.Solid;
            smartArt.Background.SolidFill.Color = ColorObject.Wheat;
            smartArt.Background.SolidFill.Transparency = 100;
            smartArt.Nodes[0].ChildNodes[0].Shapes[0].Fill.FillType = FillType.Solid;
            smartArt.Nodes[0].ChildNodes[0].Shapes[0].Fill.SolidFill.Color = ColorObject.CornflowerBlue;
            smartArt.Nodes[0].ChildNodes[0].Shapes[0].LineFormat.Weight = 5;
            smartArt.Nodes[0].ChildNodes[1].Shapes[0].Fill.FillType = FillType.Solid;
            smartArt.Nodes[0].ChildNodes[1].Shapes[0].Fill.SolidFill.Color = ColorObject.CornflowerBlue;
            smartArt.Nodes[0].ChildNodes[1].Shapes[0].LineFormat.Weight = 5;
            smartArt.Nodes[1].ChildNodes[0].Shapes[0].Fill.FillType = FillType.Solid;
            smartArt.Nodes[1].ChildNodes[0].Shapes[0].Fill.SolidFill.Color = ColorObject.CornflowerBlue;
            smartArt.Nodes[1].ChildNodes[0].Shapes[0].LineFormat.Weight = 5;
            smartArt.Nodes[1].ChildNodes[1].Shapes[0].Fill.FillType = FillType.Solid;
            smartArt.Nodes[1].ChildNodes[1].Shapes[0].Fill.SolidFill.Color = ColorObject.CornflowerBlue;
            smartArt.Nodes[1].ChildNodes[1].Shapes[0].LineFormat.Weight = 5;
            smartArt.Nodes[1].ChildNodes[2].Shapes[0].Fill.FillType = FillType.Solid;
            smartArt.Nodes[1].ChildNodes[2].Shapes[0].Fill.SolidFill.Color = ColorObject.CornflowerBlue;
            smartArt.Nodes[1].ChildNodes[2].Shapes[0].LineFormat.Weight = 5;


        }

        #endregion

    }
}

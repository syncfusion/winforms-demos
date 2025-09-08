#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Syncfusion.Presentation;
using System;
using System.Windows.Forms;
using System.IO;
using Syncfusion.Windows.Forms;
using Syncfusion.Licensing;
using System.Reflection;

namespace PPTXToPdf
{
    public partial class Form1 :  MetroForm 
    {
        #region Private Members
        private System.Windows.Forms.Button btnPresentationToPdf;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
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
            //
            // TODO: Add any constructor code after InitializeComponent call
            //
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
            this.btnPresentationToPdf = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPresentationToPdf
            // 
            this.btnPresentationToPdf.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPresentationToPdf.Location = new System.Drawing.Point(235, 185);
            this.btnPresentationToPdf.Name = "btnPresentationToPdf";
            this.btnPresentationToPdf.Size = new System.Drawing.Size(142, 32);
            this.btnPresentationToPdf.TabIndex = 0;
            this.btnPresentationToPdf.Text = "Manipulate SmartArt";
            this.btnPresentationToPdf.UseVisualStyleBackColor = true;
            this.btnPresentationToPdf.Click += new System.EventHandler(this.btnPresentationToPdf_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(392, 97);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(362, 42);
            this.label1.TabIndex = 4;
            this.label1.Text = "Click the button to view a SmartArt in Presentation generated by Essential\r\nPresenta" +
    "tion.This sample illustrates how to add new node to the SmartArt\nnode collection";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 242);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnPresentationToPdf);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manipulating SmartArt";
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

        #region Events

        private void btnPresentationToPdf_Click(object sender, EventArgs e)
        {
            try
            {
                string input = @"..\..\..\..\..\..\common\Data\Presentation\SmartArtNode.pptx";
#if NETCore
                input = @"..\..\..\..\..\..\..\common\Data\Presentation\SmartArtNode.pptx";
#endif
                //Opens the specified presentation
                IPresentation presentation = Presentation.Open(input);

                //Adds node to the main node collection.
                AddNodeInMainNodes(presentation);
                //Adds node to the child node collection.
                AddNodeInChildNodes(presentation);
                presentation.Save("SmartArtResave.pptx");
                if (MessageBox.Show("Do you want to view re-saved Presentation?", "Presentation created",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
#if !NETCore
                    System.Diagnostics.Process.Start("SmartArtResave.pptx");
#else
                    System.Diagnostics.Process process = new System.Diagnostics.Process();
                    process.StartInfo = new System.Diagnostics.ProcessStartInfo("SmartArtResave.pptx")
                    {
                        UseShellExecute = true
                    };
                    process.Start();
#endif
                    this.Close();
                }
            }
            catch(Exception exp)
            {
                MessageBox.Show("This file could not be created , please contact Syncfusion Direct-Trac system at http://www.syncfusion.com/support/default.aspx for any queries. ", "OOPS..Sorry!",
                        MessageBoxButtons.OK);
                this.Close();
            }
        }

        #endregion
        # region Slide1
        private void AddNodeInMainNodes(IPresentation presentation)
        {
            ISlide slide1 = presentation.Slides[0];
            ISmartArt smartArt = slide1.Shapes[0] as ISmartArt;
            //New node adds to the node collection.
            ISmartArtNode newNode = smartArt.Nodes.Add();
            //Text content to the newly added node.
            newNode.TextBody.AddParagraph("Marketing");

        }
        #endregion

        # region Slide2
        private void AddNodeInChildNodes(IPresentation presentation)
        {
            ISlide slide2 = presentation.Slides[2];
            ISmartArt smartArt = slide2.Shapes[1] as ISmartArt;
            // Gets first node from the node collection using index value.
            ISmartArtNode firstNode = smartArt.Nodes[0];
            //Adds new child node to the first node's child node collection.
            ISmartArtNode childNode = firstNode.ChildNodes.Add();
            //Gives the text content to the newly added child node.
            childNode.TextBody.AddParagraph("Make Simple");


        }

        #endregion
    }
}

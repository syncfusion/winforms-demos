#region Copyright Syncfusion Inc. 2001-2018.
// Copyright Syncfusion Inc. 2001-2018. All rights reserved.
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
namespace Transition
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCreatePresn
            // 
            this.btnCreatePresn.Location = new System.Drawing.Point(460, 261);
            this.btnCreatePresn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCreatePresn.Name = "btnCreatePresn";
            this.btnCreatePresn.Size = new System.Drawing.Size(170, 38);
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
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(630, 149);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 167);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(618, 57);
            this.label1.TabIndex = 27;
            this.label1.Text = "Click the button to view the created PowerPoint file with slide transition effects "+
"\r\ngenerated by Essential Presentation. Please note that Microsoft PowerPoint viewer  "+
"\r\nis required to view the resultant document.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 331);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnCreatePresn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Slide Transition";
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
            string input = @"..\..\..\..\..\..\..\Common\Data\Presentation\Transition.pptx";
            IPresentation presentation = Presentation.Open(input);
            //New Instance of PowerPoint is Created.

            //Method call to create slides
            CreateTransition(presentation);

            //Saves the presentation
            presentation.Save("Transition.pptx");

            if (MessageBox.Show("Do you want to view the generated Presentation?", "Presentation Created",
                MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {

                System.Diagnostics.Process.Start("Transition.pptx");
                this.Close();
            }
        }
        # region Slide1
        private void CreateTransition(IPresentation presentation)
        {
            //Get the first slide from the presentation
            ISlide slide1 = presentation.Slides[0];

            // Add the 'Wheel' transition effect to the first slide
            slide1.SlideTransition.TransitionEffect = Syncfusion.Presentation.SlideTransition.TransitionEffect.Wheel;

            // Get the second slide from the presentation
            ISlide slide2 = presentation.Slides[1];

            // Add the 'Checkerboard' transition effect to the second slide
            slide2.SlideTransition.TransitionEffect = Syncfusion.Presentation.SlideTransition.TransitionEffect.Checkerboard;

            // Add the subtype to the transition effect
            slide2.SlideTransition.TransitionEffectOption = Syncfusion.Presentation.SlideTransition.TransitionEffectOption.Across;

            // Apply the value to transition mouse on click parameter
            slide2.SlideTransition.TriggerOnClick = true;

            // Get the third slide from the presentation
            ISlide slide3 = presentation.Slides[2];

            // Add the 'Orbit' transition effect for slide
            slide3.SlideTransition.TransitionEffect = Syncfusion.Presentation.SlideTransition.TransitionEffect.Orbit;

            // Add the speed for transition
            slide3.SlideTransition.Speed = Syncfusion.Presentation.SlideTransition.TransitionSpeed.Fast;

            // Get the fourth slide from the presentation
            ISlide slide4 = presentation.Slides[3];

            // Add the 'Uncover' transition effect to the slide
            slide4.SlideTransition.TransitionEffect = Syncfusion.Presentation.SlideTransition.TransitionEffect.Uncover;

            // Apply the value to advance on time for slide
            slide4.SlideTransition.TriggerOnTimeDelay = true;

            // Assign the advance on time value
            slide4.SlideTransition.TimeDelay = 5;

            // Get the fifth slide from the presentation
            ISlide slide5 = presentation.Slides[4];

            // Add the 'PageCurlDouble' transition effect to the slide
            slide5.SlideTransition.TransitionEffect = Syncfusion.Presentation.SlideTransition.TransitionEffect.PageCurlDouble;

            // Add the duration value for the transition effect
            slide5.SlideTransition.Duration = 5;
        }
        #endregion       
    }
}

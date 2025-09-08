#region Copyright Syncfusion Inc. 2001 - 2011
//
//  Copyright Syncfusion Inc. 2001 - 2011. All rights reserved.
//
//  Use of this code is subject to the terms of our license.
//  A copy of the current license can be obtained at any time by e-mailing
//  licensing@syncfusion.com. Re-distribution in any form is strictly
//  prohibited. Any infringement will be prosecuted under applicable laws. 
//
#endregion

using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using Syncfusion.Pdf;
using Syncfusion.Windows.Forms;
using Syncfusion.Pdf.Graphics;
using Syncfusion.Windows.Forms.PdfViewer;
using Syncfusion.Licensing;
using System.Reflection;
using System.IO;
using System.Text;

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
        private GroupBox groupBox1;
        private RadioButton rangeBtn;
        private RadioButton allpageBtn;
        private Label label2;
        private Label label3;
        private NumericUpDown toPage;
        private NumericUpDown fromPage;
        private PdfViewerControl viewer;
        
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
            Application.EnableVisualStyles();
            this.MinimizeBox = true;
            viewer = new PdfViewerControl();
            viewer.Load(GetFullTemplatePath("EmpDetails.pdf"));
            fromPage.Maximum = viewer.PageCount;
            toPage.Maximum = viewer.PageCount;
			this.MetroColor = Color.Transparent;
            //
            // TODO: Add any constructor code after InitializeComponent call
            //
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.toPage = new System.Windows.Forms.NumericUpDown();
            this.fromPage = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rangeBtn = new System.Windows.Forms.RadioButton();
            this.allpageBtn = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.toPage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fromPage)).BeginInit();
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
            this.button1.Location = new System.Drawing.Point(278, 257);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 24);
            this.button1.TabIndex = 0;
            this.button1.Text = "Export";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(3, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(373, 62);
            this.label1.TabIndex = 1;
            this.label1.Text = "Essential Pdf Viewer supports exporting of PDF pages as raster image. Click the b" +
                "utton to Export all or selected pages in PNG format.";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = System.Drawing.Image.FromFile(GetFullTemplatePath("pdf_header.png", true));
            this.pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(375, 89);
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.toPage);
            this.groupBox1.Controls.Add(this.fromPage);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.rangeBtn);
            this.groupBox1.Controls.Add(this.allpageBtn);
            this.groupBox1.Location = new System.Drawing.Point(47, 171);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(224, 115);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Page Range";
            // 
            // toPage
            // 
            this.toPage.Enabled = false;
            this.toPage.Location = new System.Drawing.Point(146, 90);
            this.toPage.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.toPage.Name = "toPage";
            this.toPage.Size = new System.Drawing.Size(63, 40);
            this.toPage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.toPage.TabIndex = 32;
            this.toPage.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // fromPage
            // 
            this.fromPage.Enabled = false;
            this.fromPage.Location = new System.Drawing.Point(51, 89);
            this.fromPage.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.fromPage.Name = "fromPage";
            this.fromPage.Size = new System.Drawing.Size(63, 40);
            this.fromPage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fromPage.TabIndex = 31;
            this.fromPage.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(120, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "To";
            this.label3.Enabled = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "From";
            this.label2.Enabled = false;
            // 
            // rangeBtn
            // 
            this.rangeBtn.AutoSize = true;
            this.rangeBtn.Location = new System.Drawing.Point(18, 60);
            this.rangeBtn.Name = "rangeBtn";
            this.rangeBtn.Size = new System.Drawing.Size(58, 17);
            this.rangeBtn.TabIndex = 27;
            this.rangeBtn.TabStop = true;
            this.rangeBtn.Text = "Pages:";
            this.rangeBtn.UseVisualStyleBackColor = true;
            this.rangeBtn.CheckedChanged += new System.EventHandler(this.rangeBtn_CheckedChanged);
            // 
            // allpageBtn
            // 
            this.allpageBtn.AutoSize = true;
            this.allpageBtn.Checked = true;
            this.allpageBtn.Location = new System.Drawing.Point(18, 28);
            this.allpageBtn.Name = "allpageBtn";
            this.allpageBtn.Size = new System.Drawing.Size(69, 17);
            this.allpageBtn.TabIndex = 26;
            this.allpageBtn.TabStop = true;
            this.allpageBtn.Text = "All Pages";
            this.allpageBtn.UseVisualStyleBackColor = true;
            this.allpageBtn.Click += rangeBtn_CheckedChanged;
            // 
            // Form1
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(375, 298);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Export As Image";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.toPage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fromPage)).EndInit();
            this.ResumeLayout(false);

        }

        void rangeBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (rangeBtn.Checked)
            {
                fromPage.Enabled = true;
                toPage.Enabled = true;
                label2.Enabled = true;
                label3.Enabled = true;
            }
            else
            {
                fromPage.Enabled = false;
                toPage.Enabled = false;
                label2.Enabled = false;
                label3.Enabled = false;
            }
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

        /// <summary>
        /// Finds the license key from the Common folder.
        /// </summary>
        /// <returns>Returns the license key.</returns>
        public static string FindLicenseKey()
        {
#if NETCORE
            string licenseKeyFile = "..\\..\\Common\\SyncfusionLicense.txt";
#else
            string licenseKeyFile = "..\\Common\\SyncfusionLicense.txt";
#endif
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

        # region Events
        private void button1_Click(object sender, System.EventArgs e)
        {
            Bitmap[] images;

            if (allpageBtn.Checked)
            {
                images = this.viewer.ExportAsImage(0, viewer.PageCount - 1);
            }
            else
            {
                images = this.viewer.ExportAsImage((int)fromPage.Value - 1, (int)toPage.Value - 1);
            }
#if NETCORE
            string output = @"..\..\..\Output\Image";

            System.IO.Directory.CreateDirectory(@"..\..\..\Output\");
#else
			string output = @"..\..\Output\Image";

            System.IO.Directory.CreateDirectory(@"..\..\Output\");
#endif
            

            foreach (Bitmap image in images)
                image.Save(output + Guid.NewGuid().ToString() + ".png", ImageFormat.Png);

            if (images.Length > 0)
            {
                //Message box confirmation to view the created PDF document.
                if (MessageBox.Show("Do you want to view the exported image files?", "Image Exported",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Information)
                    == DialogResult.Yes)
                {
#if NETCORE
                System.Diagnostics.Process process = new System.Diagnostics.Process();
                process.StartInfo = new System.Diagnostics.ProcessStartInfo(@"..\..\..\Output\")
                {
                    UseShellExecute = true
                };
                process.Start();
#else
                System.Diagnostics.Process.Start(@"..\..\Output\");
#endif

                    this.Close();
                }
                else
                {
                    // Exit
                    this.Close();
                }
            }
        }

        # endregion

        # region Helper Methods
        /// <summary>
        /// Gets the full path of the PDF template or image.
        /// </summary>
        /// <param name="fileName">Name of the file</param>
        /// <param name="image">True if image</param>
        /// <returns>Path of the file</returns>
        private string GetFullTemplatePath(string fileName)
        {
#if NETCORE
            string fullPath = @"..\..\..\..\..\..\..\Common\Data\PDF\";
#else
			string fullPath = @"..\..\..\..\..\..\Common\Data\PDF\";
#endif

            return string.Format(@"{0}{1}", fullPath, fileName);
        }
			
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
            string folder = image ? @"Images\PDF" : "Data";

            return string.Format(@"{0}{1}\{2}", fullPath, folder, fileName);
        }

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            viewer.Dispose();
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }
        #endregion
      
    }
}
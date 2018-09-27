#region Copyright Syncfusion Inc. 2001 - 2005
//
//  Copyright Syncfusion Inc. 2001 - 2005. All rights reserved.
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
using Syncfusion.Pdf.Parsing;
using Syncfusion.Licensing;

namespace EssentialPDFSamples
{
    /// <summary>
    /// Summary description for Form1.
    /// </summary>
    public class Form1 : MetroForm
    {
        private System.Windows.Forms.Button btnSplit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtSplitDoc;
        private Button btnBrowse;
        private Label label5;
        private NumericUpDown nudSplitPage;
        PdfLoadedDocument ldoc;
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.Container components = null;

        #region Form Constructor
        public Form1()
        {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();
            this.MinimizeBox = true;

            txtSplitDoc.Tag = @"..\..\..\..\..\..\..\Common\Data\PDF\Essential_Studio.pdf";
            txtSplitDoc.Text = "Essential_Studio.pdf";
			ldoc = new PdfLoadedDocument(txtSplitDoc.Tag.ToString());
            // To load a existing document which has to be split            
            nudSplitPage.Maximum = ldoc.Pages.Count;

            txtSplitDoc.Validating += new CancelEventHandler(txtSplitDoc_Validating);
            nudSplitPage.Validating += new CancelEventHandler(nudSplitPage_Validating);

            //
            // TODO: Add any constructor code after InitializeComponent call
            //
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
            this.btnSplit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSplitDoc = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.nudSplitPage = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSplitPage)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSplit
            // 
            this.btnSplit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSplit.BackColor = System.Drawing.Color.Transparent;
            this.btnSplit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnSplit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnSplit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnSplit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSplit.Location = new System.Drawing.Point(284, 246);
            this.btnSplit.Name = "btnSplit";
            this.btnSplit.Size = new System.Drawing.Size(77, 23);
            this.btnSplit.TabIndex = 0;
            this.btnSplit.Text = "Split PDF";
            this.btnSplit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSplit.UseVisualStyleBackColor = false;
            this.btnSplit.Click += new System.EventHandler(this.btnSplitPDF_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(0, 182);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(375, 55);
            this.label1.TabIndex = 1;
            this.label1.Text = "Click the button to view an PDF document generated by Essential PDF.  Please note" +
                " that Adobe Reader or its equivalent is required to view the resultant document." +
                "";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = System.Drawing.Image.FromFile(GetFullTemplatePath("pdf_header.png", true));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(373, 89);
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(12, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 14);
            this.label2.TabIndex = 25;
            this.label2.Text = "Split Document Settings";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(164)))), ((int)(((byte)(190)))));
            this.label3.Location = new System.Drawing.Point(18, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(328, 1);
            this.label3.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 14);
            this.label4.TabIndex = 27;
            this.label4.Text = "Document to split up:";
            // 
            // txtSplitDoc
            // 
            this.txtSplitDoc.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSplitDoc.Location = new System.Drawing.Point(131, 122);
            this.txtSplitDoc.Name = "txtSplitDoc";
            this.txtSplitDoc.Size = new System.Drawing.Size(147, 20);
            this.txtSplitDoc.TabIndex = 28;
            // 
            // btnBrowse
            // 
            this.btnBrowse.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnBrowse.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowse.Location = new System.Drawing.Point(287, 120);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(59, 23);
            this.btnBrowse.TabIndex = 29;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(18, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 14);
            this.label5.TabIndex = 30;
            this.label5.Text = "Page to Split-at:";
            // 
            // nudSplitPage
            // 
            this.nudSplitPage.BackColor = System.Drawing.SystemColors.Window;
            this.nudSplitPage.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudSplitPage.Location = new System.Drawing.Point(131, 150);
            this.nudSplitPage.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudSplitPage.Name = "nudSplitPage";
            this.nudSplitPage.Size = new System.Drawing.Size(95, 20);
            this.nudSplitPage.TabIndex = 31;
            this.nudSplitPage.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(373, 290);
            this.Controls.Add(this.nudSplitPage);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.txtSplitDoc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSplit);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = System.Drawing.Icon.ExtractAssociatedIcon(GetFullTemplatePath("syncfusion.ico", true));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Split Documents";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSplitPage)).EndInit();
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
			SyncfusionLicenseProvider.RegisterLicense(DemoCommon.FindLicenseKey());
			Application.EnableVisualStyles();
            Application.Run(new Form1());
        }

        #region Events
        void txtSplitDoc_Validating(object sender, CancelEventArgs e)
        {
            nudSplitPage.Maximum = ldoc.Pages.Count;
        }

        void nudSplitPage_Validating(object sender, CancelEventArgs e)
        {
            if ((int)nudSplitPage.Value >= ldoc.Pages.Count)
            {
                MessageBox.Show("Invalid page number");
            }
        }

        private void btnSplitPDF_Click(object sender, System.EventArgs e)
        {

            //Create two pdf documents
            PdfDocument doc1 = new PdfDocument();
            PdfDocument doc2 = new PdfDocument();

            //Split the source document into two based on the split-at page value.
            int splitAtPage = (int)nudSplitPage.Value;
            for (int i = 0; i < splitAtPage; i++)
                doc1.ImportPage(ldoc, i);

            for (int j = splitAtPage; j < ldoc.Pages.Count; j++)
                doc2.ImportPage(ldoc, j);

            //Save pdf document1
            doc1.Save("Document1.pdf");

            //Save pdf document2
            doc2.Save("Document2.pdf");


            //Message box confirmation to view the created PDF document.
            if (MessageBox.Show("Do you want to view the PDF file?", "PDF File Created",
                MessageBoxButtons.YesNo, MessageBoxIcon.Information)
                == DialogResult.Yes)
            {
                //Launching the PDF file using the default Application.[Acrobat Reader]
                System.Diagnostics.Process.Start("Document1.pdf");
                System.Diagnostics.Process.Start("Document2.pdf");
                this.Close();
            }
            else
            {
                // Exit
                this.Close();
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "PDF Documents (*.pdf)|*.PDF";

            if (file.ShowDialog() == DialogResult.OK)
			{
                txtSplitDoc.Text = file.SafeFileName;
                txtSplitDoc.Tag = file.FileName;
				ldoc = new PdfLoadedDocument(txtSplitDoc.Tag.ToString());
				nudSplitPage.Maximum = ldoc.Pages.Count;
			}
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
            string licenseKeyFile = "..\\Common\\SyncfusionLicense.txt";
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

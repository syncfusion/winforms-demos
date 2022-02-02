#region Copyright Syncfusion Inc. 2001-2022
//
//  Copyright Syncfusion Inc. 2001-2022. All rights reserved.
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
using Syncfusion.Pdf.Security;
using Syncfusion.Pdf.Interactive;
using Syncfusion.Licensing;
using System.IO;


namespace EssentialPDFSamples
{
    /// <summary>
    /// Summary description for Form1.
    /// </summary>
    public class Form1 : MetroForm
    {
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Label label2;
        private Label label3;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private RadioButton rdButton256Bit;
        private RadioButton rdButton128Bit;
        private RadioButton rdButton40Bit;
        private GroupBox groupBox3;
        private RadioButton rdButtonAES;
        private RadioButton rdButtonRC4;
        private RadioButton rdButton256BitRevision6;
        private GroupBox groupBox4;
        private ComboBox cmbEncrypt;

        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.Container components = null;

        public Form1()
        {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();
            this.MinimizeBox = true;
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdButton256BitRevision6 = new System.Windows.Forms.RadioButton();
            this.rdButton256Bit = new System.Windows.Forms.RadioButton();
            this.rdButton128Bit = new System.Windows.Forms.RadioButton();
            this.rdButton40Bit = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rdButtonAES = new System.Windows.Forms.RadioButton();
            this.rdButtonRC4 = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cmbEncrypt = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
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
            this.button1.Location = new System.Drawing.Point(297, 351);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "PDF";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(0, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(380, 56);
            this.label1.TabIndex = 1;
            this.label1.Text = "Click the button to view an PDF document generated by Essential PDF.  Please note" +
    " that Adobe Reader or its equivalent is required to view the resultant document." +
    "";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = System.Drawing.Image.FromFile(GetFullTemplatePath("pdf_header.png", true));
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(384, 89);
            this.pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Owner password : syncfusion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "User password   : password";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 319);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(204, 56);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Encryption Password";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdButton256BitRevision6);
            this.groupBox2.Controls.Add(this.rdButton256Bit);
            this.groupBox2.Controls.Add(this.rdButton128Bit);
            this.groupBox2.Controls.Add(this.rdButton40Bit);
            this.groupBox2.Location = new System.Drawing.Point(12, 155);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(204, 67);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Key Size";
            // 
            // rdButton256BitRevision6
            // 
            this.rdButton256BitRevision6.AutoSize = true;
            this.rdButton256BitRevision6.Location = new System.Drawing.Point(6, 43);
            this.rdButton256BitRevision6.Name = "rdButton256BitRevision6";
            this.rdButton256BitRevision6.Size = new System.Drawing.Size(111, 17);
            this.rdButton256BitRevision6.TabIndex = 3;
            this.rdButton256BitRevision6.TabStop = true;
            this.rdButton256BitRevision6.Text = "256 Bit Revision 6";
            this.rdButton256BitRevision6.UseVisualStyleBackColor = true;
            this.rdButton256BitRevision6.CheckedChanged += new System.EventHandler(this.rdButton256BitRevision6_CheckedChanged);
            // 
            // rdButton256Bit
            // 
            this.rdButton256Bit.AutoSize = true;
            this.rdButton256Bit.Location = new System.Drawing.Point(142, 43);
            this.rdButton256Bit.Name = "rdButton256Bit";
            this.rdButton256Bit.Size = new System.Drawing.Size(55, 17);
            this.rdButton256Bit.TabIndex = 2;
            this.rdButton256Bit.TabStop = true;
            this.rdButton256Bit.Text = "256Bit";
            this.rdButton256Bit.UseVisualStyleBackColor = true;
            this.rdButton256Bit.CheckedChanged += new System.EventHandler(this.rdButton256Bit_CheckedChanged);
            // 
            // rdButton128Bit
            // 
            this.rdButton128Bit.AutoSize = true;
            this.rdButton128Bit.Checked = true;
            this.rdButton128Bit.Location = new System.Drawing.Point(142, 19);
            this.rdButton128Bit.Name = "rdButton128Bit";
            this.rdButton128Bit.Size = new System.Drawing.Size(58, 17);
            this.rdButton128Bit.TabIndex = 1;
            this.rdButton128Bit.TabStop = true;
            this.rdButton128Bit.Text = "128 Bit";
            this.rdButton128Bit.UseVisualStyleBackColor = true;
            this.rdButton128Bit.CheckedChanged += new System.EventHandler(this.rdButton128Bit_CheckedChanged);
            // 
            // rdButton40Bit
            // 
            this.rdButton40Bit.AutoSize = true;
            this.rdButton40Bit.Location = new System.Drawing.Point(6, 20);
            this.rdButton40Bit.Name = "rdButton40Bit";
            this.rdButton40Bit.Size = new System.Drawing.Size(52, 17);
            this.rdButton40Bit.TabIndex = 0;
            this.rdButton40Bit.TabStop = true;
            this.rdButton40Bit.Text = "40 Bit";
            this.rdButton40Bit.UseVisualStyleBackColor = true;
            this.rdButton40Bit.CheckedChanged += new System.EventHandler(this.rdButton40Bit_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rdButtonAES);
            this.groupBox3.Controls.Add(this.rdButtonRC4);
            this.groupBox3.Location = new System.Drawing.Point(234, 155);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(130, 67);
            this.groupBox3.TabIndex = 29;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Encryption Algorithm";
            // 
            // rdButtonAES
            // 
            this.rdButtonAES.AutoSize = true;
            this.rdButtonAES.Checked = true;
            this.rdButtonAES.Location = new System.Drawing.Point(78, 31);
            this.rdButtonAES.Name = "rdButtonAES";
            this.rdButtonAES.Size = new System.Drawing.Size(46, 17);
            this.rdButtonAES.TabIndex = 1;
            this.rdButtonAES.TabStop = true;
            this.rdButtonAES.Text = "AES";
            this.rdButtonAES.UseVisualStyleBackColor = true;
            this.rdButtonAES.CheckedChanged += new System.EventHandler(this.rdButtonAES_CheckedChanged);
            // 
            // rdButtonRC4
            // 
            this.rdButtonRC4.AutoSize = true;
            this.rdButtonRC4.Location = new System.Drawing.Point(6, 31);
            this.rdButtonRC4.Name = "rdButtonRC4";
            this.rdButtonRC4.Size = new System.Drawing.Size(46, 17);
            this.rdButtonRC4.TabIndex = 0;
            this.rdButtonRC4.TabStop = true;
            this.rdButtonRC4.Text = "RC4";
            this.rdButtonRC4.UseVisualStyleBackColor = true;
            this.rdButtonRC4.CheckedChanged += new System.EventHandler(this.rdButtonRC4_CheckedChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cmbEncrypt);
            this.groupBox4.Location = new System.Drawing.Point(12, 233);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(204, 56);
            this.groupBox4.TabIndex = 31;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Encryption Options ";
            // 
            // cmbEncrypt
            // 
            this.cmbEncrypt.FormattingEnabled = true;
            this.cmbEncrypt.Items.AddRange(new object[] {
            "Encrypt all contents",
            "Encrypt all contents except metadata",
            "Encrypt only attachments"});
            this.cmbEncrypt.Location = new System.Drawing.Point(2, 19);
            this.cmbEncrypt.Name = "cmbEncrypt";
            this.cmbEncrypt.Size = new System.Drawing.Size(200, 21);
            this.cmbEncrypt.SelectedIndex = 0;
            this.cmbEncrypt.TabIndex = 0;
            // 
            // Form1
            // 
            //this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(384, 390);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = System.Drawing.Icon.ExtractAssociatedIcon(GetFullTemplatePath("syncfusion.ico", true));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Encryption";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
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
            Application.EnableVisualStyles();
            Application.Run(new Form1());
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            PdfDocument document = new PdfDocument();
            PdfPage page = document.Pages.Add();
            PdfGraphics graphics = page.Graphics;

            PdfStandardFont font = new PdfStandardFont(PdfFontFamily.TimesRoman, 20f, PdfFontStyle.Bold);
            PdfBrush brush = PdfBrushes.Black;
            PdfForm form = document.Form;

            //Document security
            PdfSecurity security = document.Security;

            //Specify key size and encryption algorithm
            if (rdButton40Bit.Checked)
            {
                //use 40 bits key in RC4 mode
                security.KeySize = PdfEncryptionKeySize.Key40Bit;
            }
            else if (rdButton128Bit.Checked && rdButtonRC4.Checked)
            {
                //use 128 bits key in RC4 mode
                security.KeySize = PdfEncryptionKeySize.Key128Bit;
                security.Algorithm = PdfEncryptionAlgorithm.RC4;
            }
            else if (rdButton128Bit.Checked && rdButtonAES.Checked)
            {
                //use 128 bits key in AES mode
                security.KeySize = PdfEncryptionKeySize.Key128Bit;
                security.Algorithm = PdfEncryptionAlgorithm.AES;
            }
            else if (rdButton256Bit.Checked)
            {
                //use 256 bits key in AES mode
                security.KeySize = PdfEncryptionKeySize.Key256Bit;
                security.Algorithm = PdfEncryptionAlgorithm.AES;
            }
			else if(rdButton256BitRevision6.Checked)
			{
			    security.KeySize = PdfEncryptionKeySize.Key256BitRevision6;
                security.Algorithm = PdfEncryptionAlgorithm.AES;
			}
            if (cmbEncrypt.SelectedIndex == 0 || !cmbEncrypt.Enabled)
                security.EncryptionOptions = PdfEncryptionOptions.EncryptAllContents;
            else if (cmbEncrypt.SelectedIndex == 1)
                security.EncryptionOptions = PdfEncryptionOptions.EncryptAllContentsExceptMetadata;
            else if (cmbEncrypt.SelectedIndex == 2)
            {
                security.EncryptionOptions = PdfEncryptionOptions.EncryptOnlyAttachments;
                //Read the file
                FileStream file = new FileStream(GetFullTemplatePath("Products.xml", false), FileMode.Open, FileAccess.Read, FileShare.ReadWrite);

                //Creates an attachment
                PdfAttachment attachment = new PdfAttachment("Products.xml", file);

                attachment.ModificationDate = DateTime.Now;

                attachment.Description = "About Syncfusion";

                attachment.MimeType = "application/txt";

                //Adds the attachment to the document
                document.Attachments.Add(attachment);
            }

            security.OwnerPassword = "syncfusion";
            security.Permissions = PdfPermissionsFlags.Print | PdfPermissionsFlags.FullQualityPrint;
            security.UserPassword = "password";

            string text = "Security options:\n\n" + String.Format("KeySize: {0}\n\nEncryption Algorithm: {4}\n\nOwner Password: {1}\n\nPermissions: {2}\n\n" +
                "UserPassword: {3}", security.KeySize, security.OwnerPassword, security.Permissions, security.UserPassword, security.Algorithm);
            if (rdButton256BitRevision6.Checked)
            {          
                text += String.Format("\n\nRevision: {0}", "Revision6");
            }
            else if (rdButton256Bit.Checked)
            {
                text += String.Format("\n\nRevision: {0}", "Revision5");
            }

               graphics.DrawString("Document is Encrypted with following settings", font, brush, PointF.Empty);
               font = new PdfStandardFont(PdfFontFamily.TimesRoman, 16f, PdfFontStyle.Bold); 
            graphics.DrawString(text, font, brush, new PointF(0,40));

            document.Save("Sample.pdf");

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

        private void rdButton40Bit_CheckedChanged(object sender, EventArgs e)
        {
            if (rdButton40Bit.Checked)
            {
                rdButtonRC4.Enabled = true;
                rdButtonRC4.Checked = true;
                rdButtonAES.Enabled = false;
                cmbEncrypt.Enabled = false;
            }
        }

        private void rdButton128Bit_CheckedChanged(object sender, EventArgs e)
        {
            rdButtonRC4.Enabled = true;
            rdButtonAES.Enabled = true;
            cmbEncrypt.Enabled = !rdButtonRC4.Checked;
        }

        private void rdButton256Bit_CheckedChanged(object sender, EventArgs e)
        {
            rdButtonAES.Enabled = true;
            rdButtonAES.Checked = true;
            rdButtonRC4.Enabled = false;
            cmbEncrypt.Enabled = true;
        }

        private void rdButton256BitRevision6_CheckedChanged(object sender, EventArgs e)
        {
            rdButtonAES.Enabled = true;
            rdButtonAES.Checked = true;
            rdButtonRC4.Enabled = false;
            cmbEncrypt.Enabled = true;
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
            string folder = image ? "Images" : "Data";

            return string.Format(@"{0}{1}\PDF\{2}", fullPath, folder, fileName);
        }

        private void rdButtonAES_CheckedChanged(object sender, EventArgs e)
        {
            cmbEncrypt.Enabled = rdButtonAES.Checked;
        }

        private void rdButtonRC4_CheckedChanged(object sender, EventArgs e)
        {
            cmbEncrypt.Enabled = rdButton40Bit.Checked;
        }
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

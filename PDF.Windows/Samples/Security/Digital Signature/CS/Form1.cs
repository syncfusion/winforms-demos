#region Copyright Syncfusion Inc. 2001 - 2008
//
//  Copyright Syncfusion Inc. 2001 - 2008. All rights reserved.
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
using Syncfusion.Pdf.Security;
using Syncfusion.Pdf.Graphics;
using Syncfusion.Pdf.Parsing;
using Syncfusion.Licensing;

namespace EssentialPDFSamples
{
    /// <summary>
    /// Summary description for Form1.
    /// </summary>
    public class Form1 : MetroForm
    {
        # region Private Members
        PdfLoadedDocument doc;
        PdfSignature signature;
        PdfBitmap bmp;
        PdfGraphics g;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private RadioButton rdbStandardSign;
        private RadioButton rdbAuthorSign;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button2;
        private Label label5;
        private TextBox inputBox;
        private Button button3;
        private TextBox certTextBox;
        private Label label10;
        private TextBox passwordBox;
        private Label label6;
        private Label label7;
        private Label label13;
        private TextBox Locationtext;
        private Label label12;
        private TextBox Contacttext;
        private Label label11;
        private TextBox Reasontext;
        private Label label8;
        private Button button4;
        private Label label9;
        private Label label14;
        private TextBox DebugBox;
        private Label label15;
        private ToolTip toolTip1;
        private IContainer components;
        # endregion

        # region Constructor and Main
        public Form1()
        {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();
            this.MinimizeBox = true;
            this.toolTip1.SetToolTip(label15, "For the PDF.pfx certificate in\nthe Application folder 'syncfusion' is\nthe password.");
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.rdbStandardSign = new System.Windows.Forms.RadioButton();
            this.rdbAuthorSign = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.inputBox = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.certTextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.Locationtext = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.Contacttext = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.Reasontext = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.DebugBox = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
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
           //
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(423, 185);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 26);
            this.button1.TabIndex = 0;
            this.button1.Text = "PDF";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(0, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(525, 57);
            this.label1.TabIndex = 1;
            this.label1.Text = "Click the button to view an PDF document generated by Essential PDF.  Please note" +
                " that Adobe Reader or its equivalent is required to view the resultant document." +
                "";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = System.Drawing.Image.FromFile(GetFullTemplatePath("pdf_header.png", true));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(523, 90);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // rdbStandardSign
            // 
            this.rdbStandardSign.AutoSize = true;
            this.rdbStandardSign.Checked = true;
            this.rdbStandardSign.Location = new System.Drawing.Point(99, 185);
            this.rdbStandardSign.Name = "rdbStandardSign";
            this.rdbStandardSign.Size = new System.Drawing.Size(71, 17);
            this.rdbStandardSign.TabIndex = 25;
            this.rdbStandardSign.TabStop = true;
            this.rdbStandardSign.Text = "Standard ";
            this.rdbStandardSign.UseVisualStyleBackColor = true;
            // 
            // rdbAuthorSign
            // 
            this.rdbAuthorSign.AutoSize = true;
            this.rdbAuthorSign.Location = new System.Drawing.Point(176, 185);
            this.rdbAuthorSign.Name = "rdbAuthorSign";
            this.rdbAuthorSign.Size = new System.Drawing.Size(56, 17);
            this.rdbAuthorSign.TabIndex = 26;
            this.rdbAuthorSign.TabStop = true;
            this.rdbAuthorSign.Text = "Author";
            this.rdbAuthorSign.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(5, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 24);
            this.label2.TabIndex = 73;
            this.label2.Text = "Sign Existing Pdf Document";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label3.Image = ((System.Drawing.Image)(resources.GetObject("label3.Image")));
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Location = new System.Drawing.Point(5, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 24);
            this.label3.TabIndex = 74;
            this.label3.Text = "Sign New Pdf Document";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 75;
            this.label4.Text = "Signature Type";
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button2.Location = new System.Drawing.Point(267, 237);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(20, 20);
            this.button2.TabIndex = 76;
            this.button2.Text = "...";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 244);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 77;
            this.label5.Text = "Source";
            // 
            // inputBox
            // 
            this.inputBox.Location = new System.Drawing.Point(52, 241);
            this.inputBox.Name = "inputBox";
            this.inputBox.Size = new System.Drawing.Size(201, 20);
            this.inputBox.TabIndex = 78;
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button3.Location = new System.Drawing.Point(229, 290);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(20, 20);
            this.button3.TabIndex = 80;
            this.button3.Text = "...";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // certTextBox
            // 
            this.certTextBox.Location = new System.Drawing.Point(61, 290);
            this.certTextBox.Name = "certTextBox";
            this.certTextBox.Size = new System.Drawing.Size(162, 20);
            this.certTextBox.TabIndex = 79;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 316);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 13);
            this.label10.TabIndex = 81;
            this.label10.Text = "Password";
            // 
            // passwordBox
            // 
            this.passwordBox.Location = new System.Drawing.Point(61, 316);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.PasswordChar = '*';
            this.passwordBox.Size = new System.Drawing.Size(162, 20);
            this.passwordBox.TabIndex = 83;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 290);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 82;
            this.label6.Text = "Certificate";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label7.Location = new System.Drawing.Point(6, 268);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 13);
            this.label7.TabIndex = 84;
            this.label7.Text = "Certificate";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(264, 342);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(48, 13);
            this.label13.TabIndex = 90;
            this.label13.Text = "Location";
            // 
            // Locationtext
            // 
            this.Locationtext.Location = new System.Drawing.Point(313, 342);
            this.Locationtext.Name = "Locationtext";
            this.Locationtext.Size = new System.Drawing.Size(202, 20);
            this.Locationtext.TabIndex = 89;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(264, 316);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(44, 13);
            this.label12.TabIndex = 88;
            this.label12.Text = "Contact";
            // 
            // Contacttext
            // 
            this.Contacttext.Location = new System.Drawing.Point(313, 316);
            this.Contacttext.Name = "Contacttext";
            this.Contacttext.Size = new System.Drawing.Size(202, 20);
            this.Contacttext.TabIndex = 87;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(264, 290);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 13);
            this.label11.TabIndex = 86;
            this.label11.Text = "Reason";
            // 
            // Reasontext
            // 
            this.Reasontext.Location = new System.Drawing.Point(313, 290);
            this.Reasontext.Name = "Reasontext";
            this.Reasontext.Size = new System.Drawing.Size(202, 20);
            this.Reasontext.TabIndex = 85;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label8.Location = new System.Drawing.Point(264, 271);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 13);
            this.label8.TabIndex = 91;
            this.label8.Text = "Signature";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button4.Location = new System.Drawing.Point(423, 373);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(77, 27);
            this.button4.TabIndex = 93;
            this.button4.Text = "PDF";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(129)))), ((int)(((byte)(164)))));
            this.label9.Location = new System.Drawing.Point(170, 165);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(345, 1);
            this.label9.TabIndex = 94;
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(129)))), ((int)(((byte)(164)))));
            this.label14.Location = new System.Drawing.Point(191, 227);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(325, 1);
            this.label14.TabIndex = 95;
            // 
            // DebugBox
            // 
            this.DebugBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DebugBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DebugBox.Location = new System.Drawing.Point(0, 422);
            this.DebugBox.Multiline = true;
            this.DebugBox.Name = "DebugBox";
            this.DebugBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DebugBox.Size = new System.Drawing.Size(523, 88);
            this.DebugBox.TabIndex = 96;
            // 
            // label15
            // 
            this.label15.Image = ((System.Drawing.Image)(resources.GetObject("label15.Image")));
            this.label15.Location = new System.Drawing.Point(229, 319);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(20, 20);
            this.label15.TabIndex = 97;
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(523, 510);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.DebugBox);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.Locationtext);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.Contacttext);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.Reasontext);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.certTextBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.inputBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.rdbAuthorSign);
            this.Controls.Add(this.rdbStandardSign);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = System.Drawing.Icon.ExtractAssociatedIcon(GetFullTemplatePath("syncfusion.ico", true));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Digital Signature";
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
			SyncfusionLicenseProvider.RegisterLicense(DemoCommon.FindLicenseKey());
            Application.EnableVisualStyles();
            Application.Run(new Form1());
        }

        # endregion

        # region Events
        /// <summary>
        /// Creates new PDF document and signs it
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, System.EventArgs e)
        {
            DebugBox.Clear();
            PdfDocument doc = new PdfDocument();
            PdfPage page = doc.Pages.Add();
            PdfSolidBrush brush = new PdfSolidBrush(Color.Black);
            PdfPen pen = new PdfPen(brush, 0.2f);
            PdfFont font = new PdfStandardFont(PdfFontFamily.Courier, 12, PdfFontStyle.Regular);

            debug("PdfDocument created ...");

            try
            {
                PdfCertificate pdfCert = new PdfCertificate(@"..\..\..\..\..\..\..\Common\Data\PDF\PDF.pfx", "syncfusion");
                signature = new PdfSignature(page, pdfCert, "Signature");
                bmp = new PdfBitmap(@"..\..\..\..\..\..\..\Common\Images\PDF\syncfusion_logo.gif");

                signature.Bounds = new RectangleF(new PointF(5, 5), bmp.PhysicalDimension);
                signature.ContactInfo = "johndoe@owned.us";
                signature.LocationInfo = "Honolulu, Hawaii";
                signature.Reason = "I am author of this document.";

                if (rdbAuthorSign.Checked)
                    signature.Certificated = true;
                else
                    signature.Certificated = false;
                g = signature.Appearence.Normal.Graphics;

            }
            catch (System.ArgumentNullException)
            {
                g = signature.Appearence.Normal.Graphics;

                MessageBox.Show("Warning Certificate not found \"Cannot sign This Document\"", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //Draw the Text at specified location.
                g.DrawString("Warning this document is not signed", font, brush, new PointF(0, 20));
                g.DrawString("Create a self signed Digital ID to sign this document", font, brush, new PointF(20, 40));
                g.DrawLine(pen, new PointF(0, 100), new PointF(page.GetClientSize().Width, 200));
                g.DrawLine(pen, new PointF(0, 200), new PointF(page.GetClientSize().Width, 100));

            }
            string validto = "Valid To: " + signature.Certificate.ValidTo.ToString();
            string validfrom = "Valid From: " + signature.Certificate.ValidFrom.ToString();

            g.DrawImage(bmp, 0, 0);

            doc.Pages[0].Graphics.DrawString(validfrom, font, pen, brush, 0, 90);
            doc.Pages[0].Graphics.DrawString(validto, font, pen, brush, 0, 110);

            doc.Pages[0].Graphics.DrawString(" Protected Document. Digitally signed Document.", font, pen, brush, 0, 130);
            doc.Pages[0].Graphics.DrawString("* To validate Signature click on the signature on this page \n * To check Document Status \n click document status icon on the bottom left of the acrobat reader.", font, pen, brush, 0, 150);

            debug("PdfDocument signed ...");

            // Save the PDF file.
            doc.Save("Sample.pdf");
            debug("PdfDocument saved ...");

            doc.Close();

            //Message box confirmation to view the created PDF document.
            if (MessageBox.Show("Do you want to view the PDF file?", "PDF File Created",
                MessageBoxButtons.YesNo, MessageBoxIcon.Information)
                == DialogResult.Yes)
            {
                //Launching the PDF file using the default Application.[Acrobat Reader]
                System.Diagnostics.Process.Start("Sample.pdf");
                this.Close();
            }
            else
            {
                // Exit
                this.Close();
            }
        }

        /// <summary>
        /// Browse source Pdf to sign
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.OpenFileDialog openFile;
            openFile = new System.Windows.Forms.OpenFileDialog();

            openFile.Filter = "PDF files *.pdf|*.pdf";
            openFile.Title = "Select a file";
            if (openFile.ShowDialog() != DialogResult.OK)
                return;

            inputBox.Text = openFile.SafeFileName;
            inputBox.Tag = openFile.FileName;

            doc = new PdfLoadedDocument(inputBox.Tag.ToString());
        }

        /// <summary>
        /// Browse for certificate
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.OpenFileDialog openFile;
            openFile = new System.Windows.Forms.OpenFileDialog();
            openFile.InitialDirectory = Application.StartupPath + @"\..\..\..\..\Data";
            openFile.Filter = "Certificate files *.pfx|*.pfx";
            openFile.Title = "Select a file";
            if (openFile.ShowDialog() != DialogResult.OK)
                return;

            certTextBox.Text = openFile.SafeFileName;
            certTextBox.Tag = openFile.FileName;
        }

        private void debug(string txt)
        {
            DebugBox.AppendText(txt + System.Environment.NewLine);
        }

        /// <summary>
        /// Signs the existing document
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button4_Click(object sender, EventArgs e)
        {
            if (this.inputBox.Text == String.Empty || this.certTextBox.Text == String.Empty || !this.inputBox.Text.EndsWith(".pdf") || !this.certTextBox.Text.EndsWith(".pfx"))
                MessageBox.Show("Please select a PDF document to sign, along with certificate and the password !!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                DebugBox.Clear();

                PdfBitmap bmp = new PdfBitmap(Application.StartupPath + @"\..\..\..\..\..\..\..\Common\Images\PDF\PDFDemo.jpg");
                debug("Started ...");

                debug("Checking certificate ...");

                PdfPageBase page = doc.Pages[0];
                PdfCertificate pdfCert;
                try
                {
                    pdfCert = new PdfCertificate(certTextBox.Tag.ToString(), passwordBox.Text);
                }
                catch (Exception ex)
                {
                    debug("Error : please make sure you entered a valid certificate file and password");
                    debug("Exception : " + ex.ToString());
                    return;
                }
                debug("Creating new MetaData ... ");
                PdfSignature signature = new PdfSignature(doc, page, pdfCert, "Signature");

                signature.Bounds = new RectangleF(new PointF(5, 5), bmp.PhysicalDimension);
                signature.ContactInfo = Contacttext.Text;
                signature.LocationInfo = Locationtext.Text;
                signature.Reason = Reasontext.Text;
                string validto = "Valid To: " + signature.Certificate.ValidTo.ToString();
                string validfrom = "Valid From: " + signature.Certificate.ValidFrom.ToString();

                doc.Save("SignedPdfSample.pdf");

                debug("Signing document ... ");

                debug("Done");

                doc.Close();

                //Message box confirmation to view the created PDF document.
                if (MessageBox.Show("Do you want to view the PDF file?", "PDF File Created",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Information)
                    == DialogResult.Yes)
                {
                    //Launching the PDF file using the default Application.[Acrobat Reader]
                    System.Diagnostics.Process.Start("SignedPdfSample.pdf");
                    this.Close();
                }
                else
                {
                    // Exit
                    this.Close();
                }
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
        # endregion
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

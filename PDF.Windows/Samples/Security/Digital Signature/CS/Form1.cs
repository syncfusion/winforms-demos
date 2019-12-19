#region Copyright Syncfusion Inc. 2001 - 2019
//
//  Copyright Syncfusion Inc. 2001 - 2019. All rights reserved.
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
        private Label label16;
        private Label label17;
        private GroupBox groupBox1;
        private RadioButton rdbCAdES;
        private RadioButton radioButton1;
        private Label label18;
        private Label label19;
        private RadioButton rdbSHA1;
        private RadioButton rdbSHA256;
        private RadioButton rdbSHA384;
        private RadioButton rdbSHA512;
        private RadioButton rdbRIPEMD160;
        private GroupBox groupBox2;
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
            this.toolTip1.SetToolTip(label15, "For the PDF.pfx certificate in\nthe Application folder 'password123' is\nthe password.");
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
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbCAdES = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.rdbSHA1 = new System.Windows.Forms.RadioButton();
            this.rdbSHA256 = new System.Windows.Forms.RadioButton();
            this.rdbSHA384 = new System.Windows.Forms.RadioButton();
            this.rdbSHA512 = new System.Windows.Forms.RadioButton();
            this.rdbRIPEMD160 = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            this.button1.Location = new System.Drawing.Point(440, 291);
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
            this.rdbStandardSign.Location = new System.Drawing.Point(138, 294);
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
            this.rdbAuthorSign.Location = new System.Drawing.Point(210, 294);
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
            this.label2.Location = new System.Drawing.Point(4, 324);
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
            this.label3.Location = new System.Drawing.Point(4, 265);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 24);
            this.label3.TabIndex = 74;
            this.label3.Text = "Sign New Pdf Document";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 298);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 75;
            this.label4.Text = "Signature Type";
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button2.Location = new System.Drawing.Point(273, 350);
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
            this.label5.Location = new System.Drawing.Point(9, 357);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 77;
            this.label5.Text = "Source";
            // 
            // inputBox
            // 
            this.inputBox.Location = new System.Drawing.Point(58, 354);
            this.inputBox.Name = "inputBox";
            this.inputBox.Size = new System.Drawing.Size(201, 20);
            this.inputBox.TabIndex = 78;
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button3.Location = new System.Drawing.Point(235, 403);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(20, 20);
            this.button3.TabIndex = 80;
            this.button3.Text = "...";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // certTextBox
            // 
            this.certTextBox.Location = new System.Drawing.Point(67, 403);
            this.certTextBox.Name = "certTextBox";
            this.certTextBox.Size = new System.Drawing.Size(162, 20);
            this.certTextBox.TabIndex = 79;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 429);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 13);
            this.label10.TabIndex = 81;
            this.label10.Text = "Password";
            // 
            // passwordBox
            // 
            this.passwordBox.Location = new System.Drawing.Point(67, 429);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.PasswordChar = '*';
            this.passwordBox.Size = new System.Drawing.Size(162, 20);
            this.passwordBox.TabIndex = 83;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 403);
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
            this.label7.Location = new System.Drawing.Point(9,381);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 13);
            this.label7.TabIndex = 84;
            this.label7.Text = "Certificate";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(268, 455);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(48, 13);
            this.label13.TabIndex = 90;
            this.label13.Text = "Location";
            // 
            // Locationtext
            // 
            this.Locationtext.Location = new System.Drawing.Point(319, 455);
            this.Locationtext.Name = "Locationtext";
            this.Locationtext.Size = new System.Drawing.Size(202, 20);
            this.Locationtext.TabIndex = 89;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(268, 429);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(44, 13);
            this.label12.TabIndex = 88;
            this.label12.Text = "Contact";
            // 
            // Contacttext
            // 
            this.Contacttext.Location = new System.Drawing.Point(319, 429);
            this.Contacttext.Name = "Contacttext";
            this.Contacttext.Size = new System.Drawing.Size(202, 20);
            this.Contacttext.TabIndex = 87;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(268, 403);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 13);
            this.label11.TabIndex = 86;
            this.label11.Text = "Reason";
            // 
            // Reasontext
            // 
            this.Reasontext.Location = new System.Drawing.Point(319, 403);
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
            this.label8.Location = new System.Drawing.Point(270, 384);
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
            this.button4.Location = new System.Drawing.Point(440, 486);
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
            this.label9.Location = new System.Drawing.Point(136, 168);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(345, 1);
            this.label9.TabIndex = 94;
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(129)))), ((int)(((byte)(164)))));
            this.label14.Location = new System.Drawing.Point(197, 337);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(325, 1);
            this.label14.TabIndex = 95;
            // 
            // DebugBox
            // 
            this.DebugBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DebugBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DebugBox.Location = new System.Drawing.Point(0, 524);
            this.DebugBox.Multiline = true;
            this.DebugBox.Name = "DebugBox";
            this.DebugBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DebugBox.Size = new System.Drawing.Size(549, 87);
            this.DebugBox.TabIndex = 96;
            // 
            // label15
            // 
            this.label15.Image = ((System.Drawing.Image)(resources.GetObject("label15.Image")));
            this.label15.Location = new System.Drawing.Point(235, 432);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(20, 20);
            this.label15.TabIndex = 97;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(9, 195);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(118, 13);
            this.label16.TabIndex = 98;
            this.label16.Text = "Cryptographic Standard";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(9, 230);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(83, 13);
            this.label17.TabIndex = 99;
            this.label17.Text = "Digest Algorithm";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox1.Controls.Add(this.rdbCAdES);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(140, 182);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(186, 35);
            this.groupBox1.TabIndex = 100;
            this.groupBox1.TabStop = false;
            // 
            // rdbCAdES
            // 
            this.rdbCAdES.AutoSize = true;
            this.rdbCAdES.Location = new System.Drawing.Point(66, 10);
            this.rdbCAdES.Name = "rdbCAdES";
            this.rdbCAdES.Size = new System.Drawing.Size(59, 17);
            this.rdbCAdES.TabIndex = 1;
            this.rdbCAdES.Text = "CAdES";
            this.rdbCAdES.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(9, 11);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(48, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "CMS";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // label18
            // 
            this.label18.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label18.Image = ((System.Drawing.Image)(resources.GetObject("label3.Image")));
            this.label18.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label18.Location = new System.Drawing.Point(4, 155);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(130, 24);
            this.label18.TabIndex = 102;
            this.label18.Text = "Signature Settings";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label19
            // 
            this.label19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(129)))), ((int)(((byte)(164)))));
            this.label19.Location = new System.Drawing.Point(162, 278);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(345, 1);
            this.label19.TabIndex = 103;
            // 
            // rdbSHA1
            // 
            this.rdbSHA1.AutoSize = true;
            this.rdbSHA1.Location = new System.Drawing.Point(9, 10);
            this.rdbSHA1.Name = "rdbSHA1";
            this.rdbSHA1.Size = new System.Drawing.Size(53, 17);
            this.rdbSHA1.TabIndex = 0;
            this.rdbSHA1.Text = "SHA1";
            this.rdbSHA1.UseVisualStyleBackColor = true;
            // 
            // rdbSHA256
            // 
            this.rdbSHA256.AutoSize = true;
            this.rdbSHA256.Checked = true;
            this.rdbSHA256.Location = new System.Drawing.Point(65, 11);
            this.rdbSHA256.Name = "rdbSHA256";
            this.rdbSHA256.Size = new System.Drawing.Size(65, 17);
            this.rdbSHA256.TabIndex = 1;
            this.rdbSHA256.TabStop = true;
            this.rdbSHA256.Text = "SHA256";
            this.rdbSHA256.UseVisualStyleBackColor = true;
            // 
            // rdbSHA384
            // 
            this.rdbSHA384.AutoSize = true;
            this.rdbSHA384.Location = new System.Drawing.Point(139, 10);
            this.rdbSHA384.Name = "rdbSHA384";
            this.rdbSHA384.Size = new System.Drawing.Size(65, 17);
            this.rdbSHA384.TabIndex = 2;
            this.rdbSHA384.Text = "SHA384";
            this.rdbSHA384.UseVisualStyleBackColor = true;
            // 
            // rdbSHA512
            // 
            this.rdbSHA512.AutoSize = true;
            this.rdbSHA512.BackColor = System.Drawing.Color.Transparent;
            this.rdbSHA512.Location = new System.Drawing.Point(210, 11);
            this.rdbSHA512.Name = "rdbSHA512";
            this.rdbSHA512.Size = new System.Drawing.Size(65, 17);
            this.rdbSHA512.TabIndex = 3;
            this.rdbSHA512.Text = "SHA512";
            this.rdbSHA512.UseVisualStyleBackColor = false;
            // 
            // rdbRIPEMD160
            // 
            this.rdbRIPEMD160.AutoSize = true;
            this.rdbRIPEMD160.Location = new System.Drawing.Point(275, 11);
            this.rdbRIPEMD160.Name = "rdbRIPEMD160";
            this.rdbRIPEMD160.Size = new System.Drawing.Size(85, 17);
            this.rdbRIPEMD160.TabIndex = 4;
            this.rdbRIPEMD160.Text = "RIPEMD160";
            this.rdbRIPEMD160.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdbRIPEMD160);
            this.groupBox2.Controls.Add(this.rdbSHA512);
            this.groupBox2.Controls.Add(this.rdbSHA384);
            this.groupBox2.Controls.Add(this.rdbSHA256);
            this.groupBox2.Controls.Add(this.rdbSHA1);
            this.groupBox2.Location = new System.Drawing.Point(140, 218);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(365,35);
            this.groupBox2.TabIndex = 100;
            this.groupBox2.TabStop = false;
            // 
            // Form1
            // 
            //this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(523, 611);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
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
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Icon = System.Drawing.Icon.ExtractAssociatedIcon(GetFullTemplatePath("syncfusion.ico", true));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Digital Signature";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
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
#if NETCORE
                PdfCertificate pdfCert = new PdfCertificate(@"..\..\..\..\..\..\..\..\Common\Data\PDF\PDF.pfx", "password123");
#else
                PdfCertificate pdfCert = new PdfCertificate(@"..\..\..\..\..\..\..\Common\Data\PDF\PDF.pfx", "password123");
#endif
                signature = new PdfSignature(page, pdfCert, "Signature");
#if NETCORE
                bmp = new PdfBitmap(@"..\..\..\..\..\..\..\..\Common\Images\PDF\syncfusion_logo.gif");
#else
                bmp = new PdfBitmap(@"..\..\..\..\..\..\..\Common\Images\PDF\syncfusion_logo.gif");
#endif

                signature.Bounds = new RectangleF(new PointF(5, 5), bmp.PhysicalDimension);
                signature.ContactInfo = "johndoe@owned.us";
                signature.LocationInfo = "Honolulu, Hawaii";
                signature.Reason = "I am author of this document.";
                UpdateSetting(signature);
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

        private void UpdateSetting(PdfSignature signature)
        {
            if (rdbCAdES.Checked)
                signature.Settings.CryptographicStandard = CryptographicStandard.CADES;
            else
                signature.Settings.CryptographicStandard = CryptographicStandard.CMS;

            if (rdbRIPEMD160.Checked)
                signature.Settings.DigestAlgorithm = DigestAlgorithm.RIPEMD160;
            else if (rdbSHA1.Checked)
                signature.Settings.DigestAlgorithm = DigestAlgorithm.SHA1;
            else if (rdbSHA384.Checked)
                signature.Settings.DigestAlgorithm = DigestAlgorithm.SHA384;
            else if (rdbSHA512.Checked)
                signature.Settings.DigestAlgorithm = DigestAlgorithm.SHA512;
            else
                signature.Settings.DigestAlgorithm = DigestAlgorithm.SHA256;
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

#if NETCORE
                PdfBitmap bmp = new PdfBitmap(Application.StartupPath + @"\..\..\..\..\..\..\..\..\Common\Images\PDF\PDFDemo.jpg");
#else
                PdfBitmap bmp = new PdfBitmap(Application.StartupPath + @"\..\..\..\..\..\..\..\Common\Images\PDF\PDFDemo.jpg");
#endif
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
                UpdateSetting(signature);
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
#if NETCORE
                System.Diagnostics.Process process = new System.Diagnostics.Process();
                process.StartInfo = new System.Diagnostics.ProcessStartInfo("SignedPdfSample.pdf")
                {
                    UseShellExecute = true
                };
                process.Start();
#else
                    System.Diagnostics.Process.Start("SignedPdfSample.pdf");
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
		
		      /// <summary>
        /// Gets the full path of the PDF template or image.
        /// </summary>
        /// <param name="fileName">Name of the file</param>
        /// <param name="image">True if image</param>
        /// <returns>Path of the file</returns>
        private string GetFullTemplatePath(string fileName, bool image)
        {
#if NETCORE
            string fullPath = @"..\..\..\..\..\..\..\..\Common\";
#else
            string fullPath = @"..\..\..\..\..\..\..\Common\";
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
#if NETCORE
            string licenseKeyFile = @"..\\..\\Common\\SyncfusionLicense.txt";
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
                return System.IO.File.ReadAllText(licenseKeyFile);
            }
            return string.Empty;
        }
    }
}

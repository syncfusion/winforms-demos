#region Copyright Syncfusion Inc. 2001 - 2007
//
//  Copyright Syncfusion Inc. 2001 - 2007. All rights reserved.
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
using Syncfusion.HtmlConverter;
using Syncfusion.Pdf.Graphics;
using Syncfusion.Pdf.HtmlToPdf;
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
        private OpenFileDialog dlgOpen;
        private CheckBox chkFooter;
        private CheckBox chkHeader;
        private NumericUpDown nudMargin;
        private Label pageMargins;
        private GroupBox groupBox4;
        private RadioButton rdoLandscape;
        private RadioButton rdoPortrait;
        private Label label4;
        private ComboBox comboBox1;
        private GroupBox groupBox5;
        private RadioButton rdoWidth;
        private RadioButton rdoHeight;
        private Label label5;
        private Label label6;
        private GroupBox groupBox2;
        private RadioButton rdbBitmap;
        private RadioButton rdbMetafile;
        private TextBox txtUrl;
        private Button button2;
        private Label label2;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private GroupBox groupBox1;
        private CheckBox chkJavaScript;
        private GroupBox groupBox3;
        private CheckBox chkPDFA1;
        private CheckBox chk_TextBreak;
        private RadioButton rBtnPageBreak;
        private RadioButton rBtnImageBreak;
        private CheckBox chkHyperlink;
        private PictureBox pictureBox3;
        private CheckBox chkTag;

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
            this.comboBox1.SelectedIndex = 0;
            this.txtUrl.LostFocus += txtUrl_LostFocus;
            dlgOpen.Filter = "HTML Files|*.html;*.htm";
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
            this.dlgOpen = new System.Windows.Forms.OpenFileDialog();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.rdoLandscape = new System.Windows.Forms.RadioButton();
            this.rdoPortrait = new System.Windows.Forms.RadioButton();
            this.nudMargin = new System.Windows.Forms.NumericUpDown();
            this.pageMargins = new System.Windows.Forms.Label();
            this.chkFooter = new System.Windows.Forms.CheckBox();
            this.chkHeader = new System.Windows.Forms.CheckBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.rdoWidth = new System.Windows.Forms.RadioButton();
            this.rdoHeight = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdbBitmap = new System.Windows.Forms.RadioButton();
            this.rdbMetafile = new System.Windows.Forms.RadioButton();
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkTag = new System.Windows.Forms.CheckBox();
            this.chkHyperlink = new System.Windows.Forms.CheckBox();
            this.rBtnPageBreak = new System.Windows.Forms.RadioButton();
            this.rBtnImageBreak = new System.Windows.Forms.RadioButton();
            this.chk_TextBreak = new System.Windows.Forms.CheckBox();
            this.chkJavaScript = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chkPDFA1 = new System.Windows.Forms.CheckBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMargin)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            //this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(285, 551);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
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
            this.label1.Location = new System.Drawing.Point(2, 508);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(356, 43);
            this.label1.TabIndex = 1;
            this.label1.Text = "Click the button to view an PDF document generated by Essential PDF.  Please note" +
                " that Adobe Reader or its equivalent is required to view the resultant document." +
                "";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.comboBox1);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.rdoLandscape);
            this.groupBox4.Controls.Add(this.rdoPortrait);
            this.groupBox4.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox4.Location = new System.Drawing.Point(21, 458);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(337, 43);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Orientation";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "RotateAngle0",
            "RotateAngle180",
            "RotateAngle270",
            "RotateAngle90"});
            this.comboBox1.Location = new System.Drawing.Point(223, 18);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(108, 21);
            this.comboBox1.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label4.Location = new System.Drawing.Point(173, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Rotation";
            // 
            // rdoLandscape
            // 
            this.rdoLandscape.AutoSize = true;
            this.rdoLandscape.Location = new System.Drawing.Point(89, 21);
            this.rdoLandscape.Name = "rdoLandscape";
            this.rdoLandscape.Size = new System.Drawing.Size(78, 17);
            this.rdoLandscape.TabIndex = 1;
            this.rdoLandscape.TabStop = true;
            this.rdoLandscape.Text = "Landscape";
            this.rdoLandscape.UseVisualStyleBackColor = true;
            // 
            // rdoPortrait
            // 
            this.rdoPortrait.AutoSize = true;
            this.rdoPortrait.Checked = true;
            this.rdoPortrait.Location = new System.Drawing.Point(16, 21);
            this.rdoPortrait.Name = "rdoPortrait";
            this.rdoPortrait.Size = new System.Drawing.Size(58, 17);
            this.rdoPortrait.TabIndex = 0;
            this.rdoPortrait.TabStop = true;
            this.rdoPortrait.Text = "Portrait";
            this.rdoPortrait.UseVisualStyleBackColor = true;
            // 
            // nudMargin
            // 
            this.nudMargin.Location = new System.Drawing.Point(92, 427);
            this.nudMargin.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nudMargin.Name = "nudMargin";
            this.nudMargin.Size = new System.Drawing.Size(63, 20);
            this.nudMargin.TabIndex = 3;
            // 
            // pageMargins
            // 
            this.pageMargins.AutoSize = true;
            this.pageMargins.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.pageMargins.Location = new System.Drawing.Point(22, 429);
            this.pageMargins.Name = "pageMargins";
            this.pageMargins.Size = new System.Drawing.Size(72, 13);
            this.pageMargins.TabIndex = 2;
            this.pageMargins.Text = "Page Margins";
            // 
            // chkFooter
            // 
            this.chkFooter.AutoSize = true;
            this.chkFooter.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.chkFooter.Location = new System.Drawing.Point(260, 429);
            this.chkFooter.Name = "chkFooter";
            this.chkFooter.Size = new System.Drawing.Size(92, 18);
            this.chkFooter.TabIndex = 1;
            this.chkFooter.Text = "Show Footer";
            this.chkFooter.UseVisualStyleBackColor = true;
            // 
            // chkHeader
            // 
            this.chkHeader.AutoSize = true;
            this.chkHeader.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.chkHeader.Location = new System.Drawing.Point(165, 429);
            this.chkHeader.Name = "chkHeader";
            this.chkHeader.Size = new System.Drawing.Size(97, 18);
            this.chkHeader.TabIndex = 17;
            this.chkHeader.Text = "Show Header";
            this.chkHeader.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.rdoWidth);
            this.groupBox5.Controls.Add(this.rdoHeight);
            this.groupBox5.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox5.Location = new System.Drawing.Point(23, 375);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(337, 39);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Aspect Ratio";
            // 
            // rdoWidth
            // 
            this.rdoWidth.AutoSize = true;
            this.rdoWidth.Checked = true;
            this.rdoWidth.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.rdoWidth.Location = new System.Drawing.Point(16, 15);
            this.rdoWidth.Name = "rdoWidth";
            this.rdoWidth.Size = new System.Drawing.Size(87, 18);
            this.rdoWidth.TabIndex = 6;
            this.rdoWidth.TabStop = true;
            this.rdoWidth.Text = "Keep Width";
            this.rdoWidth.UseVisualStyleBackColor = true;
            // 
            // rdoHeight
            // 
            this.rdoHeight.AutoSize = true;
            this.rdoHeight.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.rdoHeight.Location = new System.Drawing.Point(178, 15);
            this.rdoHeight.Name = "rdoHeight";
            this.rdoHeight.Size = new System.Drawing.Size(90, 18);
            this.rdoHeight.TabIndex = 7;
            this.rdoHeight.Text = "Keep Height";
            this.rdoHeight.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label5.Image = ((System.Drawing.Image)(resources.GetObject("label5.Image")));
            this.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label5.Location = new System.Drawing.Point(2, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(406, 19);
            this.label5.TabIndex = 27;
            this.label5.Text = "       URL of the HTML page that needs to be converted to PDF:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(164)))), ((int)(((byte)(190)))));
            this.label6.Location = new System.Drawing.Point(26, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(365, 1);
            this.label6.TabIndex = 28;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdbBitmap);
            this.groupBox2.Controls.Add(this.rdbMetafile);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox2.Location = new System.Drawing.Point(21, 192);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(165, 39);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Convert to:";
            // 
            // rdbBitmap
            // 
            this.rdbBitmap.AutoSize = true;
            this.rdbBitmap.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.rdbBitmap.Location = new System.Drawing.Point(95, 17);
            this.rdbBitmap.Name = "rdbBitmap";
            this.rdbBitmap.Size = new System.Drawing.Size(63, 18);
            this.rdbBitmap.TabIndex = 4;
            this.rdbBitmap.TabStop = true;
            this.rdbBitmap.Text = "Bitmap";
            this.rdbBitmap.UseVisualStyleBackColor = true;
            this.rdbBitmap.CheckedChanged += new System.EventHandler(this.rdbBitmap_CheckedChanged);
            // 
            // rdbMetafile
            // 
            this.rdbMetafile.AutoSize = true;
            this.rdbMetafile.Checked = true;
            this.rdbMetafile.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.rdbMetafile.Location = new System.Drawing.Point(16, 17);
            this.rdbMetafile.Name = "rdbMetafile";
            this.rdbMetafile.Size = new System.Drawing.Size(68, 18);
            this.rdbMetafile.TabIndex = 3;
            this.rdbMetafile.TabStop = true;
            this.rdbMetafile.Text = "Metafile";
            this.rdbMetafile.UseVisualStyleBackColor = true;
            this.rdbMetafile.CheckedChanged += new System.EventHandler(this.rdbMetafile_CheckedChanged);
            // 
            // txtUrl
            // 
            this.txtUrl.Location = new System.Drawing.Point(51, 121);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(273, 20);
            this.txtUrl.TabIndex = 1;
            this.txtUrl.Text = "http://www.google.com";
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button2.Location = new System.Drawing.Point(327, 119);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(31, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "...";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label2.Location = new System.Drawing.Point(24, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "URL";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label7.Image = ((System.Drawing.Image)(resources.GetObject("label7.Image")));
            this.label7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label7.Location = new System.Drawing.Point(2, 337);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 19);
            this.label7.TabIndex = 29;
            this.label7.Text = "      Page Settings";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(164)))), ((int)(((byte)(190)))));
            this.label8.Location = new System.Drawing.Point(23, 371);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(365, 1);
            this.label8.TabIndex = 30;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(164)))), ((int)(((byte)(190)))));
            this.label9.Location = new System.Drawing.Point(23, 175);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(365, 1);
            this.label9.TabIndex = 73;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label10.Image = ((System.Drawing.Image)(resources.GetObject("label10.Image")));
            this.label10.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label10.Location = new System.Drawing.Point(2, 154);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(127, 14);
            this.label10.TabIndex = 72;
            this.label10.Text = "      Converter Options";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkTag);
            this.groupBox1.Controls.Add(this.chkHyperlink);
            this.groupBox1.Controls.Add(this.rBtnPageBreak);
            this.groupBox1.Controls.Add(this.rBtnImageBreak);
            this.groupBox1.Controls.Add(this.chk_TextBreak);
            this.groupBox1.Controls.Add(this.chkJavaScript);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox1.Location = new System.Drawing.Point(23, 256);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(337, 61);
            this.groupBox1.TabIndex = 74;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Options (MSHTML specific)";
            // 
            // chkTag
            // 
            this.chkTag.AutoSize = true;
            this.chkTag.Location = new System.Drawing.Point(244, 38);
            this.chkTag.Name = "chkTag";
            this.chkTag.Size = new System.Drawing.Size(87, 17);
            this.chkTag.TabIndex = 78;
            this.chkTag.Text = "Tagged PDF";
            this.chkTag.UseVisualStyleBackColor = true;
            this.chkTag.CheckedChanged += new System.EventHandler(this.chkTag_CheckedChanged);
            // 
            // chkHyperlink
            // 
            this.chkHyperlink.AutoSize = true;
            this.chkHyperlink.Checked = true;
            this.chkHyperlink.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkHyperlink.Location = new System.Drawing.Point(214, 17);
            this.chkHyperlink.Name = "chkHyperlink";
            this.chkHyperlink.Size = new System.Drawing.Size(111, 17);
            this.chkHyperlink.TabIndex = 77;
            this.chkHyperlink.Text = "Enable Hyperlinks";
            this.chkHyperlink.UseVisualStyleBackColor = true;
            // 
            // rBtnPageBreak
            // 
            this.rBtnPageBreak.AutoSize = true;
            this.rBtnPageBreak.Location = new System.Drawing.Point(119, 38);
            this.rBtnPageBreak.Name = "rBtnPageBreak";
            this.rBtnPageBreak.Size = new System.Drawing.Size(120, 17);
            this.rBtnPageBreak.TabIndex = 6;
            this.rBtnPageBreak.TabStop = true;
            this.rBtnPageBreak.Text = "Activate PageBreak";
            this.rBtnPageBreak.UseVisualStyleBackColor = true;
            // 
            // rBtnImageBreak
            // 
            this.rBtnImageBreak.AutoSize = true;
            this.rBtnImageBreak.Checked = true;
            this.rBtnImageBreak.Location = new System.Drawing.Point(12, 38);
            this.rBtnImageBreak.Name = "rBtnImageBreak";
            this.rBtnImageBreak.Size = new System.Drawing.Size(82, 17);
            this.rBtnImageBreak.TabIndex = 5;
            this.rBtnImageBreak.TabStop = true;
            this.rBtnImageBreak.Text = "Split Images";
            this.rBtnImageBreak.UseVisualStyleBackColor = true;
            // 
            // chk_TextBreak
            // 
            this.chk_TextBreak.AutoSize = true;
            this.chk_TextBreak.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.chk_TextBreak.Location = new System.Drawing.Point(121, 16);
            this.chk_TextBreak.Name = "chk_TextBreak";
            this.chk_TextBreak.Size = new System.Drawing.Size(101, 18);
            this.chk_TextBreak.TabIndex = 4;
            this.chk_TextBreak.Text = "Split TextLines";
            this.chk_TextBreak.UseVisualStyleBackColor = true;
            // 
            // chkJavaScript
            // 
            this.chkJavaScript.AutoSize = true;
            this.chkJavaScript.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.chkJavaScript.Location = new System.Drawing.Point(12, 16);
            this.chkJavaScript.Name = "chkJavaScript";
            this.chkJavaScript.Size = new System.Drawing.Size(118, 18);
            this.chkJavaScript.TabIndex = 1;
            this.chkJavaScript.Text = "Enable JavaScript";
            this.chkJavaScript.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.chkPDFA1);
            this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox3.Location = new System.Drawing.Point(199, 192);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(161, 39);
            this.groupBox3.TabIndex = 76;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Document Standard:";
            // 
            // chkPDFA1
            // 
            this.chkPDFA1.AutoSize = true;
            this.chkPDFA1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.chkPDFA1.Location = new System.Drawing.Point(17, 17);
            this.chkPDFA1.Name = "chkPDFA1";
            this.chkPDFA1.Size = new System.Drawing.Size(84, 18);
            this.chkPDFA1.TabIndex = 2;
            this.chkPDFA1.Text = " PDF/A1-B";
            this.chkPDFA1.UseVisualStyleBackColor = true;
            this.chkPDFA1.CheckedChanged += new System.EventHandler(this.chkPDFA1_CheckedChanged);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox3.Image = System.Drawing.Image.FromFile(GetFullTemplatePath("pdf_header.png", true));
            this.pictureBox3.Location = new System.Drawing.Point(0, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(372, 89);
            this.pictureBox3.TabIndex = 77;
            this.pictureBox3.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(372, 585);
            this.Controls.Add(this.txtUrl);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.chkFooter);
            this.Controls.Add(this.chkHeader);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.nudMargin);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.pageMargins);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = System.Drawing.Icon.ExtractAssociatedIcon(GetFullTemplatePath("syncfusion.ico", true));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HTML to PDF";
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMargin)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
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
        private void button1_Click(object sender, System.EventArgs e)
        {
            if (this.rBtnPageBreak.Checked && rdbBitmap.Checked)
            {
                MessageBox.Show("PageBreak option work only with Metafile ImageType. Page-break will not be recognized if we try convert it to Bitmap.\n\nPlease select Metafile ImageType.");
                return;
            }

            PdfDocument document;

            // Create a new instance of PdfDocument class.
            if (chkPDFA1.Checked)
            {
                // Set conformance.
                document = new PdfDocument(PdfConformanceLevel.Pdf_A1B);
            }
            else
                document = new PdfDocument();

            //Set page margins.
            document.PageSettings.SetMargins((float)this.nudMargin.Value);

            //Set page orientation.
            if (rdoPortrait.Checked)
                document.PageSettings.Orientation = PdfPageOrientation.Portrait;
            else
                document.PageSettings.Orientation = PdfPageOrientation.Landscape;

            //Set rotation.
            document.PageSettings.Rotate = (PdfPageRotateAngle)Enum.Parse(typeof(PdfPageRotateAngle), this.comboBox1.SelectedItem.ToString());

            PdfPage page = null;
            SizeF pageSize = SizeF.Empty;
            PdfUnitConvertor convertor = new PdfUnitConvertor();
            float width = -1;
            float height = -1;
            AspectRatio dimension = AspectRatio.None;

            if (!chkTag.Checked)
            {
                page = document.Pages.Add();

                pageSize = page.GetClientSize();

                //Calculates the height and width of the pdf image.
                if (rdoHeight.Checked)
                {
                    dimension = AspectRatio.KeepHeight;
                    height = convertor.ConvertToPixels(page.GetClientSize().Height, PdfGraphicsUnit.Point);
                }
                else if (rdoWidth.Checked)
                {
                    dimension = AspectRatio.KeepWidth;
                    width = convertor.ConvertToPixels(page.GetClientSize().Width, PdfGraphicsUnit.Point);
                }
            }
            else
            {
                width = convertor.ConvertToPixels(document.PageSettings.Width, PdfGraphicsUnit.Point);
                height = convertor.ConvertToPixels(document.PageSettings.Height, PdfGraphicsUnit.Point);
            }

            //Adding Header
            if (chkHeader.Checked)
                this.AddHeader(document, "Syncfusion Essential PDF", " ");

            //Adding Footer
            if (chkFooter.Checked)
                this.AddFooter(document, "@Copyright 2011");

            // Layout format for Metafile.
            PdfMetafileLayoutFormat metafileFormat = new PdfMetafileLayoutFormat();
            metafileFormat.Break = PdfLayoutBreakType.FitPage;
            metafileFormat.Layout = PdfLayoutType.Paginate;
            metafileFormat.SplitTextLines = this.chk_TextBreak.Checked;
            metafileFormat.SplitImages = this.rBtnImageBreak.Checked;

            // Layout format for Bitmap.
            PdfLayoutFormat bitmapFormat = new PdfLayoutFormat();
            bitmapFormat.Break = PdfLayoutBreakType.FitPage;
            bitmapFormat.Layout = PdfLayoutType.Paginate;

                // Create a new instance of HtmlConverter class.
                using (HtmlConverter html = new HtmlConverter())
                {
                    // Turn on JavaScript execution.
                    html.EnableJavaScript = this.chkJavaScript.Checked;

                    // Enable auto detect page break.
                    html.AutoDetectPageBreak = this.rBtnPageBreak.Checked;

                    // Enable hyperlinks in the document.
                    html.EnableHyperlinks = this.chkHyperlink.Checked;

                    // Convert to metafile.
                    if (rdbMetafile.Checked && !chkTag.Checked)
                    {
                        using (HtmlToPdfResult result = html.Convert(txtUrl.Text, ImageType.Metafile, (int)width, (int)height, dimension))
                        {
                            if (result.RenderedImage == null)
                                return;

                            // Draw metafile in PdfPage.
                            result.Render(page, metafileFormat);
                        }
                    }
                    // Convert to Bitmap.
                    else if (rdbBitmap.Checked)
                    {
                        using (Image img = html.ConvertToImage(txtUrl.Text, ImageType.Bitmap, (int)width, (int)height, dimension))
                        {
                            if (img == null)
                                return;

                            PdfImage image = new PdfBitmap(img);

                            // Draw bitmap in PdfPage.
                            if (img.Size.Width > pageSize.Width)
                                image.Draw(page, new RectangleF(0, 0, img.Width, -1), bitmapFormat);
                            else
                                image.Draw(page, new RectangleF(0, 0, pageSize.Width, -1), bitmapFormat);
                        }
                    }
                    else if (chkTag.Checked)
                    {
                        // Convert to Tagged PDF.
                        html.ConvertToTaggedPDF(document, txtUrl.Text);
                    }
                }

            // Save and close the document.
            document.Save("Sample.pdf");
            document.Close(true);

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
        /// Gets the HTML file path.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            if (dlgOpen.ShowDialog() == DialogResult.OK)
            {
                dlgOpen.Filter = "html files |*.html";
                txtUrl.Text = dlgOpen.FileName;

            }
        }

        /// <summary>
        /// Handles Bitmap and Pagebreak options.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rdbBitmap_CheckedChanged(object sender, EventArgs e)
        {
            this.rBtnPageBreak.Enabled = !this.rdbBitmap.Checked;
            this.rBtnPageBreak.Checked = false;
        }

        /// <summary>
        /// Resets the converter options for metafile and bitmap formats.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rdbMetafile_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbMetafile.Checked)
            {
                this.chk_TextBreak.Enabled = true;
                this.rBtnImageBreak.Enabled = true;
                this.rBtnPageBreak.Enabled = true;
                this.chkHyperlink.Enabled = true;
                this.chkPDFA1.Enabled = true;
                this.chkHyperlink.Checked = true;
                this.rBtnImageBreak.Checked = true;
                this.groupBox3.Enabled = true;
                this.chkTag.Enabled = true;
            }
            else
            {
                this.chk_TextBreak.Enabled = false;
                this.rBtnImageBreak.Enabled = false;
                this.chk_TextBreak.Checked = false;
                this.rBtnImageBreak.Checked = false;
                this.rBtnPageBreak.Enabled = false;
                this.rBtnPageBreak.Checked = false;
                this.chkHyperlink.Enabled = false;
                this.chkHyperlink.Checked = false;
                this.chkPDFA1.Enabled = false;
                this.chkPDFA1.Checked = false;
                this.groupBox3.Enabled = false;
                this.chkTag.Checked = false;
                this.chkTag.Enabled = false;
            }
        }

        /// <summary>
        /// Handles JavaScript option for PDF documents with conformance.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chkPDFA1_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPDFA1.Checked)
            {
                chkJavaScript.Visible = false;
            }
            else
            {
                chkJavaScript.Visible = true;
            }
        }

        private void engine_CheckedChanged(object sender, EventArgs e)
        {
            EventArgs args = new EventArgs();
            this.rdbBitmap.Enabled = true;
            this.groupBox3.Enabled = true;
            this.groupBox1.Enabled = true;
            this.nudMargin.Enabled = true;
            this.chkHeader.Enabled = true;
            this.chkFooter.Enabled = true;
            this.pageMargins.Enabled = true;
            if (rdbMetafile.Checked)
                rdbMetafile_CheckedChanged(this, args);
            else if (rdbBitmap.Checked)
                rdbBitmap_CheckedChanged(this, args);
        }

        private void chkTag_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTag.Checked)
                chkHyperlink.Enabled = false;
            else
                chkHyperlink.Enabled = true;
        }
        # endregion

        # region Helper Methods
        /// <summary>
        /// Draws header to the document.
        /// </summary>
        private void AddHeader(PdfDocument doc, string title, string description)
        {
            RectangleF rect = new RectangleF(0, 0, doc.PageSettings.Width, 50);
            //Create a new instance of PdfPageTemplateElement class.
            PdfPageTemplateElement header = new PdfPageTemplateElement(rect);
            PdfGraphics g = header.Graphics;

            //Draw the image in the Header.
            SizeF imageSize = new SizeF(110f, 35f);
            //Locating the logo on the right corner.
            PointF imageLocation = new PointF(doc.PageSettings.Width - imageSize.Width - 20, 5);
            PdfImage img = new PdfBitmap(GetFullTemplatePath("logo.png", true));
            g.DrawImage(img, imageLocation, imageSize);

            //Draw title.
            PdfFont font = new PdfTrueTypeFont(new Font("Helvetica", 16, FontStyle.Bold), true);
            PdfSolidBrush brush = new PdfSolidBrush(Color.FromArgb(44, 71, 120));
            PdfStringFormat format = new PdfStringFormat(PdfTextAlignment.Center, PdfVerticalAlignment.Middle);
            g.DrawString(title, font, brush, new RectangleF(PointF.Empty, header.Size), format);

            //Draw description
            brush = new PdfSolidBrush(Color.Gray);
            font = new PdfTrueTypeFont(new Font("Helvetica", 6, FontStyle.Bold), true);
            format = new PdfStringFormat(PdfTextAlignment.Left, PdfVerticalAlignment.Bottom);
            g.DrawString(description, font, brush, new RectangleF(0, 0, header.Width, header.Height - 8), format);

            //Draw some lines in the header
            PdfPen pen = new PdfPen(Color.DarkBlue, 0.7f);
            g.DrawLine(pen, 0, 0, header.Width, 0);
            pen = new PdfPen(Color.DarkBlue, 2f);
            g.DrawLine(pen, 0, 03, header.Width + 3, 03);
            pen = new PdfPen(Color.DarkBlue, 2f);
            g.DrawLine(pen, 0, header.Height - 3, header.Width, header.Height - 3);
            g.DrawLine(pen, 0, header.Height, header.Width, header.Height);

            //Add header template at the top.
            doc.Template.Top = header;
        }

        /// <summary>
        /// Draws footer to the document.
        /// </summary>
        private void AddFooter(PdfDocument doc, string footerText)
        {
            RectangleF rect = new RectangleF(0, 0, doc.PageSettings.Width, 50);
            //Create a new instance of PdfPageTemplateElement class.
            PdfPageTemplateElement footer = new PdfPageTemplateElement(rect);
            PdfGraphics g = footer.Graphics;

            // Draw footer text.
            PdfSolidBrush brush = new PdfSolidBrush(Color.Gray);
            PdfFont font = new PdfTrueTypeFont(new Font("Helvetica", 6, FontStyle.Bold), true);
            PdfStringFormat format = new PdfStringFormat(PdfTextAlignment.Center, PdfVerticalAlignment.Middle);
            g.DrawString(footerText, font, brush, new RectangleF(0, 18, footer.Width, footer.Height), format);

            //Create page number field
            PdfPageNumberField pageNumber = new PdfPageNumberField(font, brush);

            //Create page count field
            PdfPageCountField count = new PdfPageCountField(font, brush);

            PdfCompositeField compositeField = new PdfCompositeField(font, brush, "Page {0} of {1}", pageNumber, count);
            compositeField.Bounds = footer.Bounds;
            compositeField.Draw(g, new PointF(470, 40));

            //Add the footer template at the bottom
            doc.Template.Bottom = footer;
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

        private void txtUrl_LostFocus(object sender, EventArgs e)
        {
            Uri uri = null;
            if (!Uri.TryCreate(txtUrl.Text, UriKind.Absolute, out uri) || null == uri)
            {
                MessageBox.Show("Please enter a valid URL", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (uri.IsFile)
                {
                    if (!uri.Segments[uri.Segments.Length - 1].Contains(".htm"))
                    {
                        MessageBox.Show("Please select a valid HTML file", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
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
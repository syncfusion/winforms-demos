#region Copyright Syncfusion Inc. 2001 - 2017
//
//  Copyright Syncfusion Inc. 2001 - 2017. All rights reserved.
//
//  Use of this code is subject to the terms of our license.
//  A copy of the current license can be obtained at any time by e-mailing
//  licensing@syncfusion.com. Any infringement will be prosecuted under
//  applicable laws. 
//
#endregion

using System;
using System.Drawing;
using System.ComponentModel;
using System.Windows.Forms;
using Syncfusion.DocIO;
using Syncfusion.DocIO.DLS;
using Syncfusion.Windows.Forms;
using Syncfusion.Windows.Forms.Tools;
using Syncfusion.DocToPDFConverter;
using Syncfusion.Pdf;
using Syncfusion.Licensing;
using System.Reflection;
using System.Text;
using System.IO;

namespace EssentialDocIOSamples
{
    public class Form1 : MetroForm
    {
        #region Private Members

        private ToolTip toolTip1;
        private ButtonAdv button1;
        private Label label2;
        private PictureBox pictureBox3;
        private ButtonAdv button2;
        private GroupBox groupBox1;
        private RadioButtonAdv wordDocxRadioBtn;
        private RadioButtonAdv wordDocRadioBtn;
        private RadioButtonAdv pdfRadioBtn;
        private IContainer components;
        #endregion

        #region Constructor, Main and Dispose
        /// <summary>
        /// Constructor
        /// </summary>
        public Form1()
        {
            //
            // Required for Windows Form Designer support
            //			
            InitializeComponent();
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
            int levelsToCheck = 12;
            string filePath = @"Common\SyncfusionLicense.txt";

            string rootPath = System.IO.Path.GetDirectoryName(Assembly.GetEntryAssembly().CodeBase.Replace(@"file:///", ""));

            for (int n = 0; n < levelsToCheck; n++)
            {
                string fileDataPath = System.IO.Path.Combine(rootPath, filePath);
                if (System.IO.File.Exists(fileDataPath))
                    return File.ReadAllText(fileDataPath, Encoding.UTF8);
                DirectoryInfo rootDirectory = Directory.GetParent(rootPath);
                if (rootDirectory == null)
                    break;
                rootPath = rootDirectory.FullName;
            }
            return string.Empty;
        }		
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
		    SyncfusionLicenseProvider.RegisterLicense(FindLicenseKey());
            Application.EnableVisualStyles();
            Application.Run(new Form1());
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
        #endregion

        #region Windows Form Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.button1 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.button2 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.wordDocxRadioBtn = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
            this.wordDocRadioBtn = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
            this.pdfRadioBtn = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wordDocxRadioBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wordDocRadioBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pdfRadioBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218)))));
            this.button1.BeforeTouchSize = new System.Drawing.Size(108, 23);
            this.button1.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.Dashed;
            this.button1.ComboEditBackColor = System.Drawing.Color.Silver;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.IsBackStageButton = false;
            this.button1.KeepFocusRectangle = false;
            this.button1.Location = new System.Drawing.Point(245, 155);
            this.button1.Name = "button1";
            this.button1.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Managed;
            this.button1.Size = new System.Drawing.Size(108, 23);
            this.button1.TabIndex = 68;
            this.button1.Text = "Built- in Styles";
            this.button1.UseVisualStyle = true;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(0, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(366, 66);
            this.label2.TabIndex = 80;
            this.label2.Text = "Click the button to view the generated Word document or PDF. Please note that Microsoft Word Viewer or Microsoft Word is required to view the resultant Word document and PDF viewer is required to view the resultant PDF.";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(0, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(365, 83);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 78;
            this.pictureBox3.TabStop = false;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218)))));
            this.button2.BeforeTouchSize = new System.Drawing.Size(108, 23);
            this.button2.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.Dashed;
            this.button2.ComboEditBackColor = System.Drawing.Color.Silver;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.IsBackStageButton = false;
            this.button2.KeepFocusRectangle = false;
            this.button2.Location = new System.Drawing.Point(245, 184);
            this.button2.Name = "button2";
            this.button2.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Managed;
            this.button2.Size = new System.Drawing.Size(108, 23);
            this.button2.TabIndex = 82;
            this.button2.Text = "Custom Styles";
            this.button2.UseVisualStyle = true;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.wordDocxRadioBtn);
            this.groupBox1.Controls.Add(this.wordDocRadioBtn);
            this.groupBox1.Controls.Add(this.pdfRadioBtn);
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 155);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(209, 50);
            this.groupBox1.TabIndex = 101;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Save As";
            // 
            // worddocxRadioBtn
            // 
            this.wordDocxRadioBtn.BeforeTouchSize = new System.Drawing.Size(53, 20);
            this.wordDocxRadioBtn.Border3DStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.wordDocxRadioBtn.Checked = true;
            this.wordDocxRadioBtn.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wordDocxRadioBtn.GradientEnd = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.wordDocxRadioBtn.GradientStart = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.wordDocxRadioBtn.Location = new System.Drawing.Point(79, 20);
            this.wordDocxRadioBtn.MetroColor = System.Drawing.Color.Empty;
            this.wordDocxRadioBtn.Name = "wordDocxRadioBtn";
            this.wordDocxRadioBtn.Size = new System.Drawing.Size(53, 20);
            this.wordDocxRadioBtn.TabIndex = 103;
            this.wordDocxRadioBtn.Text = "DOCX";
            this.wordDocxRadioBtn.ThemesEnabled = true;
            // 
            // worddocRadioBtn
            // 
            this.wordDocRadioBtn.BeforeTouchSize = new System.Drawing.Size(46, 20);
            this.wordDocRadioBtn.Border3DStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.wordDocRadioBtn.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.wordDocRadioBtn.GradientEnd = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.wordDocRadioBtn.GradientStart = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.wordDocRadioBtn.Location = new System.Drawing.Point(6, 20);
            this.wordDocRadioBtn.MetroColor = System.Drawing.Color.Empty;
            this.wordDocRadioBtn.Name = "wordDocRadioBtn";
            this.wordDocRadioBtn.Size = new System.Drawing.Size(46, 20);
            this.wordDocRadioBtn.TabIndex = 44;
            this.wordDocRadioBtn.Text = "DOC";
            this.wordDocRadioBtn.ThemesEnabled = true;
            // 
            // pdfRadioBtn
            // 
            this.pdfRadioBtn.BeforeTouchSize = new System.Drawing.Size(48, 20);
            this.pdfRadioBtn.Border3DStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.pdfRadioBtn.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.pdfRadioBtn.GradientEnd = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.pdfRadioBtn.GradientStart = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.pdfRadioBtn.Location = new System.Drawing.Point(161, 20);
            this.pdfRadioBtn.MetroColor = System.Drawing.Color.Empty;
            this.pdfRadioBtn.Name = "pdfRadioBtn";
            this.pdfRadioBtn.Size = new System.Drawing.Size(48, 20);
            this.pdfRadioBtn.TabIndex = 45;
            this.pdfRadioBtn.Text = "PDF";
            this.pdfRadioBtn.ThemesEnabled = true;
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 15);
            this.BackColor = System.Drawing.Color.White;
            this.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218)))));
            this.ClientSize = new System.Drawing.Size(365, 219);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.button1);
            this.DropShadow = true;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Styles";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.wordDocxRadioBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wordDocRadioBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pdfRadioBtn)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion

        #region Button_Click Event
        /// <summary>
        /// Creates word document with built - in styles
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, System.EventArgs e)
        {
            try
            {
                WordDocument document = new WordDocument();
                WSection section = document.AddSection() as WSection;
                WParagraph para = section.AddParagraph() as WParagraph;
                section.AddColumn(100, 100);
                section.AddColumn(100, 100);
                section.MakeColumnsEqual();

                #region Built-in styles
                # region List Style

                //List
                para.AppendText("This para is written with style List").CharacterFormat.UnderlineStyle = UnderlineStyle.Double;
                para = section.AddParagraph() as WParagraph;
                para.ApplyStyle(BuiltinStyle.List);
                para.AppendText("Google Chrome\n");
                para.AppendText("Mozilla Firefox\n");
                para.AppendText("Internet Explorer");

                //List5 style
                para = section.AddParagraph() as WParagraph;
                para.AppendText("\nThis para is written with style List5").CharacterFormat.UnderlineStyle = UnderlineStyle.Double;
                para = section.AddParagraph() as WParagraph;
                para.ApplyStyle(BuiltinStyle.List5);
                para.AppendText("Google Chrome\n");
                para.AppendText("Mozilla Firefox\n");
                para.AppendText("Internet Explorer");

                # endregion

                # region ListNumber Style

                //List Number style
                para = section.AddParagraph() as WParagraph;
                para.AppendText("\nThis para is written with style ListNumber").CharacterFormat.UnderlineStyle = UnderlineStyle.Double;
                para = section.AddParagraph() as WParagraph;
                para.ApplyStyle(BuiltinStyle.ListNumber);
                para.AppendText("Google Chrome\n");
                para.AppendText("Mozilla Firefox\n");
                para.AppendText("Internet Explorer");

                //List Number5 style
                para = section.AddParagraph() as WParagraph;
                para.AppendText("\nThis para is written with style ListNumber5").CharacterFormat.UnderlineStyle = UnderlineStyle.Double;
                para = section.AddParagraph() as WParagraph;
                para.ApplyStyle(BuiltinStyle.ListNumber5);
                para.AppendText("Google Chrome\n");
                para.AppendText("Mozilla Firefox\n");
                para.AppendText("Internet Explorer");

                # endregion

                # region TOA Heading Style

                //TOA Heading
                para = section.AddParagraph() as WParagraph;
                para.ParagraphFormat.AfterSpacing = 10;
                para.AppendText("\nThis para is written with style TOA Heading").CharacterFormat.UnderlineStyle = UnderlineStyle.Double;
                para = section.AddParagraph() as WParagraph;
                para.ApplyStyle(BuiltinStyle.ToaHeading);
                para.AppendText("Google Chrome\n");
                para.AppendText("Mozilla Firefox\n");
                para.AppendText("Internet Explorer");

                # endregion

                section.BreakCode = SectionBreakCode.NewColumn;

                # region ListBullet Style
                //ListBullet
                para = section.AddParagraph() as WParagraph;
                para.AppendText("\nThis para is written with style ListBullet").CharacterFormat.UnderlineStyle = UnderlineStyle.Double;
                para = section.AddParagraph() as WParagraph;
                para.ApplyStyle(BuiltinStyle.ListBullet);
                para.AppendText("Google Chrome\n");
                para.AppendText("Mozilla Firefox\n");
                para.AppendText("Internet Explorer");

                //ListBullet5
                para = section.AddParagraph() as WParagraph;
                para.AppendText("\nThis para is written with style ListBullet5").CharacterFormat.UnderlineStyle = UnderlineStyle.Double;
                para = section.AddParagraph() as WParagraph;
                para.ApplyStyle(BuiltinStyle.ListBullet5);
                para.AppendText("Google Chrome\n");
                para.AppendText("Mozilla Firefox\n");
                para.AppendText("Internet Explorer");

                # endregion

                # region List Continue Style

                //ListContinue
                para = section.AddParagraph() as WParagraph;
                para.AppendText("\nThis para is written with style ListContinue").CharacterFormat.UnderlineStyle = UnderlineStyle.Double;
                para = section.AddParagraph() as WParagraph;
                para.ApplyStyle(BuiltinStyle.ListContinue);
                para.AppendText("Google Chrome\n");
                para.AppendText("Mozilla Firefox\n");
                para.AppendText("Internet Explorer");

                //ListContinue5
                para = section.AddParagraph() as WParagraph;
                para.AppendText("\nThis para is written with style ListContinue5").CharacterFormat.UnderlineStyle = UnderlineStyle.Double;
                para = section.AddParagraph() as WParagraph;
                para.ApplyStyle(BuiltinStyle.ListContinue5);
                para.AppendText("Google Chrome\n");
                para.AppendText("Mozilla Firefox\n");
                para.AppendText("Internet Explorer");

                # endregion

                # region HTMLSample Style

                //HtmlSample
                para = section.AddParagraph() as WParagraph;
                para.AppendText("\nThis para is written with style HtmlSample").CharacterFormat.UnderlineStyle = UnderlineStyle.Double;
                para = section.AddParagraph() as WParagraph;
                para.ApplyStyle(BuiltinStyle.HtmlSample);
                para.AppendText("Google Chrome\n");
                para.AppendText("Mozilla Firefox\n");
                para.AppendText("Internet Explorer");

                # endregion

                section = document.AddSection() as WSection;
                section.BreakCode = SectionBreakCode.NoBreak;

                # region Document Map Style

                //Document Map
                para = section.AddParagraph() as WParagraph;
                para.AppendText("This para is written with style DocumentMap\n").CharacterFormat.UnderlineStyle = UnderlineStyle.Double;
                para = section.AddParagraph() as WParagraph;
                para.ApplyStyle(BuiltinStyle.DocumentMap);
                para.AppendText("Google Chrome\n").CharacterFormat.TextColor = System.Drawing.Color.White;
                para.AppendText("Mozilla Firefox\n").CharacterFormat.TextColor = System.Drawing.Color.White;
                para.AppendText("Internet Explorer").CharacterFormat.TextColor = System.Drawing.Color.White;

                #endregion

                # region Heading Styles
                //Heading Styles
                para = section.AddParagraph() as WParagraph;
                para.ApplyStyle(BuiltinStyle.Heading1);
                para.AppendText("Hello World. This para is written with style " + para.StyleName.ToString());

                para = section.AddParagraph() as WParagraph;
                para.ApplyStyle(BuiltinStyle.Heading2);
                para.AppendText("Hello World. This para is written with style " + para.StyleName.ToString());

                para = section.AddParagraph() as WParagraph;
                para.ApplyStyle(BuiltinStyle.Heading3);
                para.AppendText("Hello World. This para is written with style " + para.StyleName.ToString());

                para = section.AddParagraph() as WParagraph;
                para.ApplyStyle(BuiltinStyle.Heading4);
                para.AppendText("Hello World. This para is written with style " + para.StyleName.ToString());

                para = section.AddParagraph() as WParagraph;
                para.ApplyStyle(BuiltinStyle.Heading5);
                para.AppendText("Hello World. This para is written with style " + para.StyleName.ToString());

                para = section.AddParagraph() as WParagraph;
                para.ApplyStyle(BuiltinStyle.Heading6);
                para.AppendText("Hello World. This para is written with style " + para.StyleName.ToString());

                para = section.AddParagraph() as WParagraph;
                para.ApplyStyle(BuiltinStyle.Heading7);
                para.AppendText("Hello World. This para is written with style " + para.StyleName.ToString());

                para = section.AddParagraph() as WParagraph;
                para.ApplyStyle(BuiltinStyle.Heading8);
                para.AppendText("Hello World. This para is written with style " + para.StyleName.ToString());

                para = section.AddParagraph() as WParagraph;
                para.ApplyStyle(BuiltinStyle.Heading9);
                para.AppendText("Hello World. This para is written with style " + para.StyleName.ToString());

                # endregion

                # region MessageHeaderStyle

                //MessageHeader
                para = section.AddParagraph() as WParagraph;
                para = section.AddParagraph() as WParagraph;
                para.AppendText("This para is written with style MessageHeader\n").CharacterFormat.UnderlineStyle = UnderlineStyle.Double;
                para = section.AddParagraph() as WParagraph;
                para.ApplyStyle(BuiltinStyle.MessageHeader);
                para.AppendText("Google Chrome\n");
                para.AppendText("Mozilla Firefox\n");
                para.AppendText("Internet Explorer");

                # endregion

                #endregion Built-in styles

                # region Save Document

                //Save as doc format
                if (wordDocRadioBtn.Checked)
                {
                    //Saving the document to disk.
                    document.Save("Sample.doc");

                    //Message box confirmation to view the created document.
                    if (MessageBoxAdv.Show("Do you want to view the generated Word document?", "Document has been created", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        //Launching the MS Word file using the default Application.[MS Word Or Free WordViewer]
                        System.Diagnostics.Process.Start("Sample.doc");
                        //Exit
                        this.Close();
                    }
                }
                //Save as docx format
                else if (wordDocxRadioBtn.Checked)
                {
                    //Saving the document as .docx
                    document.Save("Sample.docx", FormatType.Docx);
                    //Message box confirmation to view the created document.
                    if (MessageBoxAdv.Show("Do you want to view the generated Word document?", "Document has been created", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        try
                        {
                            //Launching the MS Word file using the default Application.[MS Word Or Free WordViewer]
                            System.Diagnostics.Process.Start("Sample.docx");
                            //Exit
                            this.Close();
                        }
                        catch (Win32Exception ex)
                        {
                            MessageBoxAdv.Show("Microsoft Word Viewer or Microsoft Word is not installed in this system");
                            Console.WriteLine(ex.ToString());
                        }
                    }
                }
                //Save as pdf format
                else if (pdfRadioBtn.Checked)
                {
                    DocToPDFConverter converter = new DocToPDFConverter();
                    //Convert word document into PDF document
                    PdfDocument pdfDoc = converter.ConvertToPDF(document);
                    //Save the pdf file
                    pdfDoc.Save("Sample.pdf");
                    //Message box confirmation to view the created document.
                    if (MessageBoxAdv.Show("Do you want to view the generated PDF?", " Document has been created", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        try
                        {
                            System.Diagnostics.Process.Start("Sample.pdf");
                            //Exit
                            this.Close();
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.ToString());
                        }
                    }
                }
                else
                {
                    // Exit
                    this.Close();
                }
                # endregion
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }
        #endregion

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                #region Custom styles
                WordDocument document = new WordDocument();
                IWParagraphStyle style = null;
                // Adding a new section to the document.
                WSection section = document.AddSection() as WSection;
                //Set Margin of the section
                section.PageSetup.Margins.All = 72;
                IWParagraph par = document.LastSection.AddParagraph();
                WTextRange range = par.AppendText("Using CustomStyles") as WTextRange;
                range.CharacterFormat.TextBackgroundColor = System.Drawing.Color.Blue;
                range.CharacterFormat.FontSize = 18f;
                document.LastParagraph.ParagraphFormat.HorizontalAlignment = Syncfusion.DocIO.DLS.HorizontalAlignment.Center;

                // Create Paragraph styles
                style = document.AddParagraphStyle("MyStyle_Normal");
                style.CharacterFormat.FontName = "Bitstream Vera Serif";
                style.CharacterFormat.FontSize = 10f;
                style.ParagraphFormat.HorizontalAlignment = Syncfusion.DocIO.DLS.HorizontalAlignment.Justify;
                style.CharacterFormat.TextColor = Color.FromArgb(0, 21, 84);

                style = document.AddParagraphStyle("MyStyle_Low");
                style.CharacterFormat.FontName = "Times New Roman";
                style.CharacterFormat.FontSize = 16f;
                style.CharacterFormat.Bold = true;

                style = document.AddParagraphStyle("MyStyle_Medium");
                style.CharacterFormat.FontName = "Monotype Corsiva";
                style.CharacterFormat.FontSize = 18f;
                style.CharacterFormat.Bold = true;
                style.CharacterFormat.TextColor = Color.FromArgb(51, 66, 125);

                style = document.AddParagraphStyle("Mystyle_High");
                style.CharacterFormat.FontName = "Bitstream Vera Serif";
                style.CharacterFormat.FontSize = 20f;
                style.CharacterFormat.Bold = true;
                style.CharacterFormat.TextColor = Color.FromArgb(242, 151, 50);

                IWParagraph paragraph = null;
                for (int i = 0; i < document.Styles.Count; i++)
                {
                    //Skip to apply the document default styles and also paragraph style. 
                    if (document.Styles[i].Name == "Normal" || document.Styles[i].Name == "Default Paragraph Font"
                       || document.Styles[i].StyleType != StyleType.ParagraphStyle)
                        continue;
                    // Getting styles from Document.
                    style = (IWParagraphStyle)document.Styles[i];
                    // Adding a new paragraph
                    section.AddParagraph();
                    paragraph = section.AddParagraph();
                    // Applying styles to the current paragraph.
                    paragraph.ApplyStyle(style.Name);
                    // Writing Text with the current style and formatting.
                    paragraph.AppendText("Northwind Database with [" + style.Name + "] Style");
                    // Adding a new paragraph
                    section.AddParagraph();
                    paragraph = section.AddParagraph();
                    // Applying another style to the current paragraph.
                    paragraph.ApplyStyle("MyStyle_Normal");
                    // Writing text with current style.
                    paragraph.AppendText("The Northwind sample database (Northwind.mdb) is included with all versions of Access. It provides data you can experiment with and database objects that demonstrate features you might want to implement in your own databases. Using Northwind, you can become familiar with how a relational database is structured and how the database objects work together to help you enter, store, manipulate, and print your data. ");
                }
                #endregion Custom styles

                # region Save Document

                //Save as doc format
                if (wordDocRadioBtn.Checked)
                {
                    //Saving the document to disk.
                    document.Save("Sample.doc");

                    //Message box confirmation to view the created document.
                    if (MessageBoxAdv.Show("Do you want to view the generated Word document?", "Document has been created", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        //Launching the MS Word file using the default Application.[MS Word Or Free WordViewer]
                        System.Diagnostics.Process.Start("Sample.doc");
                        //Exit
                        this.Close();
                    }
                }
                //Save as docx format
                else if (wordDocxRadioBtn.Checked)
                {
                    //Saving the document as .docx
                    document.Save("Sample.docx", FormatType.Docx);
                    //Message box confirmation to view the created document.
                    if (MessageBoxAdv.Show("Do you want to view the generated Word document?", "Document has been created", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        try
                        {
                            //Launching the MS Word file using the default Application.[MS Word Or Free WordViewer]
                            System.Diagnostics.Process.Start("Sample.docx");
                            //Exit
                            this.Close();
                        }
                        catch (Win32Exception ex)
                        {
                            MessageBoxAdv.Show("Microsoft Word Viewer or Microsoft Word is not installed in this system");
                            Console.WriteLine(ex.ToString());
                        }
                    }
                }
                //Save as pdf format
                else if (pdfRadioBtn.Checked)
                {
                    DocToPDFConverter converter = new DocToPDFConverter();
                    //Convert word document into PDF document
                    PdfDocument pdfDoc = converter.ConvertToPDF(document);
                    //Save the pdf file
                    pdfDoc.Save("Sample.pdf");
                    //Message box confirmation to view the created document.
                    if (MessageBoxAdv.Show("Do you want to view the generated PDF?", " Document has been created", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        try
                        {
                            System.Diagnostics.Process.Start("Sample.pdf");
                            //Exit
                            this.Close();
                        }
                        catch (Exception ex)
                        {
						    MessageBoxAdv.Show("PDF Viewer is not installed in this system");
                            Console.WriteLine(ex.ToString());
                        }
                    }
                }
                else
                {
                    // Exit
                    this.Close();
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
            # endregion
        }

    }
}
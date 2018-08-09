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
    /// <summary>
    /// Summary description for Form1.
    /// </summary>
    public class Form1 : MetroForm
    {
        private ButtonAdv button1;
        private Label label2;
        private ToolTip toolTip1;
        private PictureBox pictureBox1;
        private IContainer components;
        string[] products = { "Mango", "Orange", "Grape", "Banana", "Apple", "Green Apple", "Water Melon", "Pine apple", "Guava" };
        string[] forms = { "Delicious", "Frequent Item" };
        IWSection section1;
        IWParagraph paragraph = null;
        private GroupBox groupBox1;
        private RadioButtonAdv wordDocxRadioBtn;
        private RadioButtonAdv wordDocRadioBtn;
        private RadioButtonAdv pdfRadioBtn;
        IWTextRange textRange = null;
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
            this.button1 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.label2 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.wordDocxRadioBtn = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
            this.wordDocRadioBtn = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
            this.pdfRadioBtn = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.button1.ComboEditBackColor = System.Drawing.Color.Silver;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.IsBackStageButton = false;
            this.button1.KeepFocusRectangle = false;
            this.button1.Location = new System.Drawing.Point(245, 165);
            this.button1.Name = "button1";
            this.button1.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Managed;
            this.button1.Size = new System.Drawing.Size(108, 23);
            this.button1.TabIndex = 26;
            this.button1.Text = "Generate";
            this.button1.UseVisualStyle = true;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(0, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(363, 62);
            this.label2.TabIndex = 73;
            this.label2.Text = "Click the button to view the generated Word document or PDF. Please note that Microsoft Word Viewer or Microsoft Word is required to view the resultant Word document and PDF viewer is required to view the resultant PDF.";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(365, 82);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 70;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.wordDocxRadioBtn);
            this.groupBox1.Controls.Add(this.wordDocRadioBtn);
            this.groupBox1.Controls.Add(this.pdfRadioBtn);
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 150);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(209, 41);
            this.groupBox1.TabIndex = 101;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Save As";
            // 
            // worddocxRadioBtn
            // 
            this.wordDocxRadioBtn.BeforeTouchSize = new System.Drawing.Size(52, 20);
            this.wordDocxRadioBtn.Border3DStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.wordDocxRadioBtn.Checked = true;
            this.wordDocxRadioBtn.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wordDocxRadioBtn.GradientEnd = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.wordDocxRadioBtn.GradientStart = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.wordDocxRadioBtn.Location = new System.Drawing.Point(83, 18);
            this.wordDocxRadioBtn.MetroColor = System.Drawing.Color.Empty;
            this.wordDocxRadioBtn.Name = "wordDocxRadioBtn";
            this.wordDocxRadioBtn.Size = new System.Drawing.Size(52, 20);
            this.wordDocxRadioBtn.TabIndex = 103;
            this.wordDocxRadioBtn.Text = "DOCX";
            this.wordDocxRadioBtn.ThemesEnabled = true;
            // 
            // worddocRadioBtn
            // 
            this.wordDocRadioBtn.BeforeTouchSize = new System.Drawing.Size(48, 20);
            this.wordDocRadioBtn.Border3DStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.wordDocRadioBtn.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.wordDocRadioBtn.GradientEnd = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.wordDocRadioBtn.GradientStart = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.wordDocRadioBtn.Location = new System.Drawing.Point(6, 18);
            this.wordDocRadioBtn.MetroColor = System.Drawing.Color.Empty;
            this.wordDocRadioBtn.Name = "wordDocRadioBtn";
            this.wordDocRadioBtn.Size = new System.Drawing.Size(48, 20);
            this.wordDocRadioBtn.TabIndex = 44;
            this.wordDocRadioBtn.Text = "DOC";
            this.wordDocRadioBtn.ThemesEnabled = true;
            // 
            // pdfRadioBtn
            // 
            this.pdfRadioBtn.BeforeTouchSize = new System.Drawing.Size(45, 20);
            this.pdfRadioBtn.Border3DStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.pdfRadioBtn.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.pdfRadioBtn.GradientEnd = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.pdfRadioBtn.GradientStart = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.pdfRadioBtn.Location = new System.Drawing.Point(164, 18);
            this.pdfRadioBtn.MetroColor = System.Drawing.Color.Empty;
            this.pdfRadioBtn.Name = "pdfRadioBtn";
            this.pdfRadioBtn.Size = new System.Drawing.Size(45, 20);
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
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.DropShadow = true;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Format Text";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.wordDocxRadioBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wordDocRadioBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pdfRadioBtn)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion

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

        private void button1_Click(object sender, System.EventArgs e)
        {
            try
            {
                //Random number generator.
                Random r = new Random();

                // List of FontNames.
                string[] fontNames = { "Arial", "Times New Roman", "Monotype Corsiva", " Book Antiqua ", "Bitstream Vera Sans", "Comic Sans MS", "Microsoft Sans Serif", "Batang" };

                // Create a new document.
                WordDocument document = new WordDocument();

                // Adding new section to the document.
                IWSection section = document.AddSection();
                // Set Margin for the document
                section.PageSetup.Margins.All = 72;
                // Adding new paragraph to the section.
                IWParagraph paragraph = section.AddParagraph();

                paragraph.AppendText("This sample demonstrates various text and paragraph formatting support.");
                section.AddParagraph();
                section.AddParagraph();

                section = document.AddSection();
                section.BreakCode = SectionBreakCode.NoBreak;
                //Adding two columns to the section.
                section.AddColumn(250, 20);
                section.AddColumn(250, 20);

                #region Text Formatting
                //Create a TextRange
                IWTextRange text = null;

                // Writing Text with different Formatting styles.
                for (int i = 8, j = 0, k = 0; i <= 20; i++, j++, k++)
                {
                    if (j >= fontNames.Length) j = 0;
                    paragraph = section.AddParagraph();
                    text = paragraph.AppendText("This is " + "[" + fontNames[j] + "] Font");
                    text.CharacterFormat.FontName = fontNames[j];
                    text.CharacterFormat.UnderlineStyle = (UnderlineStyle)k;
                    text.CharacterFormat.FontSize = i;
                    text.CharacterFormat.TextColor = Color.FromArgb(r.Next(0, 255), r.Next(0, 255), r.Next(0, 255));
                }

                // More formatting options.
                section.AddParagraph();
                paragraph.ParagraphFormat.ColumnBreakAfter = true;
                paragraph = section.AddParagraph();
                text = paragraph.AppendText("More formatting Options List...");
                text.CharacterFormat.FontName = fontNames[2];
                text.CharacterFormat.FontSize = 18;

                section.AddParagraph();
                paragraph = section.AddParagraph();
                paragraph.AppendText("AllCaps \n\n").CharacterFormat.AllCaps = true;
                paragraph.AppendText("Bold \n\n").CharacterFormat.Bold = true;
                paragraph.AppendText("DoubleStrike \n\n").CharacterFormat.DoubleStrike = true;
                paragraph.AppendText("Emboss \n\n").CharacterFormat.Emboss = true;
                paragraph.AppendText("Engrave \n\n").CharacterFormat.Engrave = true;
                paragraph.AppendText("Italic \n\n").CharacterFormat.Italic = true;
                paragraph.AppendText("Shadow \n\n").CharacterFormat.Shadow = true;
                paragraph.AppendText("SmallCaps \n\n").CharacterFormat.SmallCaps = true;
                paragraph.AppendText("Strikeout \n\n").CharacterFormat.Strikeout = true;
                paragraph.AppendText("Some Text");
                paragraph.AppendText("SubScript \n\n").CharacterFormat.SubSuperScript = SubSuperScript.SubScript;
                paragraph.AppendText("Some Text");
                paragraph.AppendText("SuperScript \n\n").CharacterFormat.SubSuperScript = SubSuperScript.SuperScript;
                paragraph.AppendText("TextBackgroundColor \n\n").CharacterFormat.TextBackgroundColor = Color.LightBlue;

                #endregion

                #region Paragraph formattings

                section = document.AddSection();
                section.BreakCode = SectionBreakCode.NewPage;
                paragraph = section.AddParagraph();
                paragraph.AppendText("Following paragraphs illustrates various paragraph formattings");

                paragraph = section.AddParagraph();
                paragraph.AppendText("This paragraph demonstrates several paragraph formats. It will be used to illustrate Space Before, Space After, and Line Spacing. Space Before tells Microsoft Word how much space to leave before the paragraph. Space After tells Microsoft Word how much space to leave after the paragraph. Line Spacing sets the space between lines within a paragraph.It also explains about first line indentation,backcolor and paragraph border.");
                paragraph.ParagraphFormat.BeforeSpacing = 20f;
                paragraph.ParagraphFormat.AfterSpacing = 30f;
                paragraph.ParagraphFormat.BackColor = Color.LightGray;
                paragraph.ParagraphFormat.Borders.BorderType = Syncfusion.DocIO.DLS.BorderStyle.Single;
                paragraph.ParagraphFormat.FirstLineIndent = 20f;
                paragraph.ParagraphFormat.LineSpacing = 20f;

                paragraph = section.AddParagraph();
                paragraph.AppendText("This is a sample paragraph. It is used to illustrate alignment. Left-justified text is aligned on the left. Right-justified text is aligned with on the right. Centered text is centered between the left and right margins. You can use Center to center your titles. Justified text is flush on both sides.");
                paragraph.ParagraphFormat.LineSpacing = 20f;
                paragraph.ParagraphFormat.HorizontalAlignment = Syncfusion.DocIO.DLS.HorizontalAlignment.Right;
                paragraph.ParagraphFormat.LineSpacingRule = LineSpacingRule.Exactly;

                section.AddParagraph();

                //Adding new paragraph to the section.
                paragraph = section.AddParagraph();
                paragraph.ParagraphFormat.Keep = true;
                paragraph.AppendText("KEEP TOGETHER ").CharacterFormat.Bold = true;
                paragraph.AppendText("This is a sample paragraph. It is used to illustrate Keep together of MsWord. You can control where Microsoft Word positions automatic page breaks (page break: The point at which one page ends and another begins. Microsoft Word inserts an 'automatic' (or soft) page break for you, or you can force a page break at a specific location by inserting a 'manual' (or hard) page break.) by setting pagination options.It keeps the lines in a paragraph together when there is page break ").CharacterFormat.FontSize = 12f;
                for (int i = 0; i < 10; i++)
                {
                    paragraph.AppendText("Text Body_Text Body_Text Body_Text Body_Text Body_Text Body_Text Body").CharacterFormat.FontSize = 12f;
                    paragraph.ParagraphFormat.LineSpacing = 20f;
                }
                paragraph.AppendText(" KEEP TOGETHER END").CharacterFormat.Bold = true;

                #endregion

                #region Bullets and Numbering
                // Adding a new section to the document.
                section = document.AddSection();
                //Set Margin of the document
                section.PageSetup.Margins.Top = 20;
                section.PageSetup.Margins.Bottom = 20;
                section.PageSetup.Margins.Left = 50;
                section.PageSetup.Margins.Right = 20;
                // Adding a new paragraph to the document.
                paragraph = section.AddParagraph();
                // Writing text to the current paragraph.
                paragraph.AppendText("This document demonstrates the Bullets and Numbering functionality. Here fruits are taken as an example to demonstrate the lists. \n\n\n\n");

                //Add a new section
                section1 = document.AddSection();
                //Adding two columns to the section.
                section1.Columns.Add(new Column(document));
                section1.Columns.Add(new Column(document));
                //Set the columns to be of equal width.
                section1.MakeColumnsEqual();

                // Set section break code as NoBreak. 
                section1.BreakCode = SectionBreakCode.NoBreak;

                // Set formatting.
                ProductDetailsInBullets();

                // Set Formatting.
                ProductDetailsInNumbers();
                #endregion  Bullets and Numbering

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
        }
        #region ProductDetailsInBullets
        private void ProductDetailsInBullets()
        {
            // Adding a new paragraph to the document.
            section1.AddParagraph();
            paragraph = section1.AddParagraph();

            // Writing text to the document with formatting.
            textRange = paragraph.AppendText("List of Fruits.");
            paragraph.ListFormat.ApplyDefBulletStyle();
            textRange.CharacterFormat.FontName = "Monotype Corsiva";
            textRange.CharacterFormat.FontSize = 15;

            // Writing Product details to the document with the specified list type.
            section1.AddParagraph();
            foreach (string s in products)
            {
                section1.AddParagraph();
                paragraph = section1.AddParagraph();
                paragraph.AppendText(s);
                paragraph.ListFormat.ContinueListNumbering();
                paragraph.ListFormat.ListLevelNumber = 1;

                section1.AddParagraph();
                foreach (string s1 in forms)
                {
                    if (String.Equals(s, "Plums"))
                    {
                        paragraph = section1.AddParagraph();
                        paragraph.AppendText(s1);
                        paragraph.ListFormat.ContinueListNumbering();
                        paragraph.ListFormat.ListLevelNumber = 2;
                        break;
                    }
                    else
                    {
                        paragraph = section1.AddParagraph();
                        paragraph.AppendText(s1);
                        paragraph.ListFormat.ContinueListNumbering();
                        paragraph.ListFormat.ListLevelNumber = 2;
                    }
                }
            }
        }
        #endregion

        #region ProductDetailsInNumbers
        private void ProductDetailsInNumbers()
        {
            // Adding a new paragraph to the document.
            section1.AddParagraph();
            paragraph = section1.AddParagraph();

            // Writing text to the document with formatting.
            textRange = paragraph.AppendText("List of Fruits.");
            paragraph.ListFormat.ApplyDefNumberedStyle();
            textRange.CharacterFormat.FontName = "Monotype Corsiva";
            textRange.CharacterFormat.FontSize = 15;

            // Writing Product details to the document with the specified list type.
            section1.AddParagraph();
            foreach (string s in products)
            {
                section1.AddParagraph();
                paragraph = section1.AddParagraph();
                paragraph.AppendText(s);
                paragraph.ListFormat.ContinueListNumbering();

                paragraph.ListFormat.ListLevelNumber = 1;
                section1.AddParagraph();
                foreach (string s1 in forms)
                {
                    if (String.Equals(s, "Plums"))
                    {
                        paragraph = section1.AddParagraph();
                        paragraph.AppendText(s1);
                        paragraph.ListFormat.ContinueListNumbering();
                        paragraph.ListFormat.ListLevelNumber = 2;
                        break;
                    }
                    else
                    {
                        paragraph = section1.AddParagraph();
                        paragraph.AppendText(s1);
                        paragraph.ListFormat.ContinueListNumbering();
                        paragraph.ListFormat.ListLevelNumber = 2;
                    }
                }
            }
        }
        #endregion


    }
}

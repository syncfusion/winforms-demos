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

using Syncfusion.DocIO.DLS;
using Syncfusion.DocIO;
using Syncfusion.Windows.Forms;
using Syncfusion.Windows.Forms.Tools;
using Syncfusion.Licensing;
using System.Reflection;
using System.Text;
using System.IO;

namespace EssentialDocIOSamples
{
    public class Form1 : MetroForm
    {
        #region Private Members

        private ButtonAdv button1;
        private Label label2;
        private PictureBox pictureBox1;
        private ToolTip toolTip1;
        private GroupBox groupBox1;
        private RadioButtonAdv wordDocxRadioBtn;
        private RadioButtonAdv wordDocRadioBtn;
        private IContainer components;

        #endregion

        #region Constructor, Main and Dispose
        public Form1()
        {
            //
            // Required for Windows Form Designer support
            //			
            InitializeComponent();
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
            this.button1 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.wordDocxRadioBtn = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
            this.wordDocRadioBtn = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wordDocxRadioBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wordDocRadioBtn)).BeginInit();
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
            this.button1.Location = new System.Drawing.Point(245, 160);
            this.button1.Name = "button1";
            this.button1.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Managed;
            this.button1.Size = new System.Drawing.Size(108, 23);
            this.button1.TabIndex = 68;
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
            this.label2.Size = new System.Drawing.Size(365, 57);
            this.label2.TabIndex = 74;
            this.label2.Text = "Click the button to view the generated Word document. Please note that Microsoft Word Viewer or Microsoft Word is required to view the resultant Word document.";
            this.label2.Click += new System.EventHandler(this.label2_Click);
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
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 145);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(209, 43);
            this.groupBox1.TabIndex = 101;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Save As";
            // 
            // worddocxRadioBtn
            // 
            this.wordDocxRadioBtn.BeforeTouchSize = new System.Drawing.Size(55, 20);
            this.wordDocxRadioBtn.Border3DStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.wordDocxRadioBtn.Checked = true;
            this.wordDocxRadioBtn.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wordDocxRadioBtn.GradientEnd = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.wordDocxRadioBtn.GradientStart = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.wordDocxRadioBtn.Location = new System.Drawing.Point(132, 18);
            this.wordDocxRadioBtn.MetroColor = System.Drawing.Color.Empty;
            this.wordDocxRadioBtn.Name = "wordDocxRadioBtn";
            this.wordDocxRadioBtn.Size = new System.Drawing.Size(55, 20);
            this.wordDocxRadioBtn.TabIndex = 103;
            this.wordDocxRadioBtn.Text = "DOCX";
            this.wordDocxRadioBtn.ThemesEnabled = true;
            // 
            // worddocRadioBtn
            // 
            this.wordDocRadioBtn.BeforeTouchSize = new System.Drawing.Size(47, 20);
            this.wordDocRadioBtn.Border3DStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.wordDocRadioBtn.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.wordDocRadioBtn.GradientEnd = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.wordDocRadioBtn.GradientStart = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.wordDocRadioBtn.Location = new System.Drawing.Point(24, 18);
            this.wordDocRadioBtn.MetroColor = System.Drawing.Color.Empty;
            this.wordDocRadioBtn.Name = "wordDocRadioBtn";
            this.wordDocRadioBtn.Size = new System.Drawing.Size(47, 20);
            this.wordDocRadioBtn.TabIndex = 44;
            this.wordDocRadioBtn.Text = "DOC";
            this.wordDocRadioBtn.ThemesEnabled = true;
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
            this.Text = "Footnotes and Endnotes";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.wordDocxRadioBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wordDocRadioBtn)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion

        #region Button Click

        private void button1_Click(object sender, System.EventArgs e)
        {
            try
            {
                //A new document is created.
                WordDocument document = new WordDocument();

                //Create footnotes at the bottom of the page
                CreateFootNote(document);

                //Create endnotes at the end of the section
                CreateEndNote(document);

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
        #endregion

        #region Helper Methods
        #region CreateFootNote

        void CreateFootNote(WordDocument document)
        {
            //Add a new section to the document.
            IWSection section = document.AddSection();
            // Set Margin of the document
            section.PageSetup.Margins.All = 72;
            //Adding a new paragraph to the section.
            IWParagraph paragraph = section.AddParagraph();

            IWTextRange textRange = paragraph.AppendText("\t\t\t\t\tDemo for Footnote");
            textRange.CharacterFormat.TextColor = Color.Black;
            textRange.CharacterFormat.Bold = true;
            textRange.CharacterFormat.FontSize = 20;

            section.AddParagraph();
            section.AddParagraph();
            paragraph = section.AddParagraph();
            WFootnote footnote = new WFootnote(document);
            footnote = paragraph.AppendFootnote(FootnoteType.Footnote);
            footnote.MarkerCharacterFormat.SubSuperScript = SubSuperScript.SuperScript;

            //Insert Text into the paragraph
            paragraph.AppendText("Google").CharacterFormat.Bold = true;
            paragraph = section.AddParagraph();
            paragraph.ParagraphFormat.HorizontalAlignment = Syncfusion.DocIO.DLS.HorizontalAlignment.Center;
            paragraph.AppendPicture(Image.FromFile(@"..\..\..\..\..\..\..\Common\images\DocIO\google.png"));

            paragraph = footnote.TextBody.AddParagraph();
            paragraph.AppendText(" Google is the most famous search engines in the Word ");

            //Adding a new paragraph to the section.
            paragraph = section.AddParagraph();

            paragraph = section.AddParagraph();
            footnote = paragraph.AppendFootnote(FootnoteType.Footnote);
            footnote.MarkerCharacterFormat.SubSuperScript = SubSuperScript.SuperScript;


            //Insert Text into the paragraph
            paragraph.AppendText("Yahoo").CharacterFormat.Bold = true;
            paragraph = section.AddParagraph();
            paragraph.ParagraphFormat.HorizontalAlignment = Syncfusion.DocIO.DLS.HorizontalAlignment.Center;
            paragraph.AppendPicture(Image.FromFile(@"..\..\..\..\..\..\..\Common\images\DocIO\yahoo.gif"));

            paragraph = footnote.TextBody.AddParagraph();
            paragraph.AppendText(" Yahoo experience makes it easier to discover the news and information that you care about most. ");

            //Adding a new paragraph to the section.
            paragraph = section.AddParagraph();

            paragraph = section.AddParagraph();
            footnote = paragraph.AppendFootnote(FootnoteType.Footnote);
            footnote.MarkerCharacterFormat.SubSuperScript = SubSuperScript.SuperScript;


            //Insert Text into the paragraph
            paragraph.AppendText("Northwind Traders").CharacterFormat.Bold = true;
            paragraph = section.AddParagraph();
            paragraph.ParagraphFormat.HorizontalAlignment = Syncfusion.DocIO.DLS.HorizontalAlignment.Center;
            paragraph.AppendPicture(Image.FromFile(@"..\..\..\..\..\..\..\Common\images\DocIO\Northwind_logo.png"));
            paragraph = footnote.TextBody.AddParagraph();
            paragraph.AppendText(" The Northwind sample database (Northwind.mdb) is included with all versions of Access. It provides data you can experiment with and database objects that demonstrate features you might want to implement in your own databases. ");

            //Setting number format for Footnote
            document.FootnoteNumberFormat = FootEndNoteNumberFormat.Arabic;

            //Setting Footnote position
            document.FootnotePosition = FootnotePosition.PrintAtBottomOfPage;

        }
        #endregion

        #region CreateEndNote

        void CreateEndNote(WordDocument document)
        {
            //Add a new section to the document.
            IWSection section = document.AddSection();

            //Adding a new paragraph to the section.
            IWParagraph paragraph = section.AddParagraph();

            IWTextRange textRange = paragraph.AppendText("\t\t\t\t\tDemo for Endnote");
            textRange.CharacterFormat.TextColor = Color.Black;
            textRange.CharacterFormat.Bold = true;
            textRange.CharacterFormat.FontSize = 20;

            section.AddParagraph();
            section.AddParagraph();
            paragraph = section.AddParagraph();
            WFootnote footnote = new WFootnote(document);
            footnote = paragraph.AppendFootnote(FootnoteType.Endnote);
            footnote.MarkerCharacterFormat.SubSuperScript = SubSuperScript.SuperScript;

            //Insert Text into the paragraph
            paragraph.AppendText("Google").CharacterFormat.Bold = true;
            paragraph = section.AddParagraph();
            paragraph.ParagraphFormat.HorizontalAlignment = Syncfusion.DocIO.DLS.HorizontalAlignment.Center;
            paragraph.AppendPicture(Image.FromFile(@"..\..\..\..\..\..\..\Common\images\DocIO\google.png"));

            paragraph = footnote.TextBody.AddParagraph();
            paragraph.AppendText(" Google is the most famous search engines in the Word ");

            section = document.AddSection();
            section.BreakCode = SectionBreakCode.NoBreak;
            //Adding a new paragraph to the section.
            paragraph = section.AddParagraph();

            paragraph = section.AddParagraph();
            footnote = paragraph.AppendFootnote(FootnoteType.Endnote);
            footnote.MarkerCharacterFormat.SubSuperScript = SubSuperScript.SuperScript;


            //Insert Text into the paragraph
            paragraph.AppendText("Yahoo").CharacterFormat.Bold = true;
            paragraph = section.AddParagraph();
            paragraph.ParagraphFormat.HorizontalAlignment = Syncfusion.DocIO.DLS.HorizontalAlignment.Center;
            paragraph.AppendPicture(Image.FromFile(@"..\..\..\..\..\..\..\Common\images\DocIO\yahoo.gif"));

            paragraph = footnote.TextBody.AddParagraph();
            paragraph.AppendText(" Yahoo experience makes it easier to discover the news and information that you care about most. ");

            section = document.AddSection();
            section.BreakCode = SectionBreakCode.NoBreak;
            //Adding a new paragraph to the section.
            paragraph = section.AddParagraph();

            paragraph = section.AddParagraph();
            footnote = paragraph.AppendFootnote(FootnoteType.Endnote);
            footnote.MarkerCharacterFormat.SubSuperScript = SubSuperScript.SuperScript;

            //Insert Text into the paragraph
            paragraph.AppendText("Northwind Traders").CharacterFormat.Bold = true;
            paragraph = section.AddParagraph();
            paragraph.ParagraphFormat.HorizontalAlignment = Syncfusion.DocIO.DLS.HorizontalAlignment.Center;
            paragraph.AppendPicture(Image.FromFile(@"..\..\..\..\..\..\..\Common\images\DocIO\Northwind_logo.png"));
            paragraph = footnote.TextBody.AddParagraph();
            paragraph.AppendText(" The Northwind sample database (Northwind.mdb) is included with all versions of Access. It provides data you can experiment with and database objects that demonstrate features you might want to implement in your own databases ");

            //Set the number format for the Endnote.
            document.EndnoteNumberFormat = Syncfusion.DocIO.FootEndNoteNumberFormat.LowerCaseRoman;
            document.RestartIndexForEndnote = Syncfusion.DocIO.EndnoteRestartIndex.DoNotRestart;
            //Set the Endnote position.
            document.EndnotePosition = Syncfusion.DocIO.EndnotePosition.DisplayEndOfSection;
        }
        #endregion

        private void label2_Click(object sender, EventArgs e)
        {

        }
        #endregion

    }
}

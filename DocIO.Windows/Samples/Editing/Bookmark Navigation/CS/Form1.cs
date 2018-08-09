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
        private PictureBox pictureBox1;
        private Label label2;
        private ToolTip toolTip1;
        private GroupBox groupBox1;
        private RadioButtonAdv wordDocxRadioBtn;
        private RadioButtonAdv wordDocRadioBtn;
        private RadioButtonAdv pdfRadioBtn;
        private IContainer components;

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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
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
            this.button1.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.Dashed;
            this.button1.ComboEditBackColor = System.Drawing.Color.Silver;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.IsBackStageButton = false;
            this.button1.KeepFocusRectangle = false;
            this.button1.Location = new System.Drawing.Point(236, 168);
            this.button1.Name = "button1";
            this.button1.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Managed;
            this.button1.Size = new System.Drawing.Size(108, 23);
            this.button1.TabIndex = 26;
            this.button1.Text = "Generate";
            this.button1.UseVisualStyle = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(365, 82);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(0, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(363, 57);
            this.label2.TabIndex = 70;
            this.label2.Text = "Click the button to view the generated Word document or PDF. Please note that Microsoft Word Viewer or Microsoft Word is required to view the resultant Word document and PDF viewer is required to view the resultant PDF.";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.wordDocxRadioBtn);
            this.groupBox1.Controls.Add(this.wordDocRadioBtn);
            this.groupBox1.Controls.Add(this.pdfRadioBtn);
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 154);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(209, 43);
            this.groupBox1.TabIndex = 101;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Save As";
            // 
            // worddocxRadioBtn
            // 
            this.wordDocxRadioBtn.BeforeTouchSize = new System.Drawing.Size(54, 20);
            this.wordDocxRadioBtn.Border3DStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.wordDocxRadioBtn.Checked = true;
            this.wordDocxRadioBtn.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wordDocxRadioBtn.GradientEnd = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.wordDocxRadioBtn.GradientStart = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.wordDocxRadioBtn.Location = new System.Drawing.Point(83, 17);
            this.wordDocxRadioBtn.MetroColor = System.Drawing.Color.Empty;
            this.wordDocxRadioBtn.Name = "wordDocxRadioBtn";
            this.wordDocxRadioBtn.Size = new System.Drawing.Size(54, 20);
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
            this.pdfRadioBtn.BeforeTouchSize = new System.Drawing.Size(44, 20);
            this.pdfRadioBtn.Border3DStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.pdfRadioBtn.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.pdfRadioBtn.GradientEnd = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.pdfRadioBtn.GradientStart = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.pdfRadioBtn.Location = new System.Drawing.Point(165, 18);
            this.pdfRadioBtn.MetroColor = System.Drawing.Color.Empty;
            this.pdfRadioBtn.Name = "pdfRadioBtn";
            this.pdfRadioBtn.Size = new System.Drawing.Size(44, 20);
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
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.DropShadow = true;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bookmark Navigation";
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
                string dataPath = @"..\..\..\..\..\..\..\Common\Data\DocIO\";
                // Creating a new document.
                WordDocument document = new WordDocument();
                //Adds section with one empty paragraph to the Word document
                document.EnsureMinimal();
                //sets the page margins
                document.LastSection.PageSetup.Margins.All = 72f;
                //Appends bookmark to the paragraph
                document.LastParagraph.AppendBookmarkStart("NorthwindDatabase");
                document.LastParagraph.AppendText("Northwind database with normalization concept");
                document.LastParagraph.AppendBookmarkEnd("NorthwindDatabase");
                // Open an existing template document with single section to get Northwind.information
                WordDocument nwdInformation = new WordDocument(dataPath + "Bookmark_Template.doc");
                // Open an existing template document with multiple section to get Northwind data.
                WordDocument templateDocument = new WordDocument(dataPath + "BkmkDocumentPart_Template.doc");
                // Creating a bookmark navigator. Which help us to navigate through the 
                // bookmarks in the template document.
                BookmarksNavigator bk = new BookmarksNavigator(templateDocument);
                // Move to the NorthWind bookmark in template document
                bk.MoveToBookmark("NorthWind");
                //Gets the bookmark content as WordDocumentPart
                WordDocumentPart documentPart = bk.GetContent();
                // Creating a bookmark navigator. Which help us to navigate through the 
                // bookmarks in the Northwind information document.
                bk = new BookmarksNavigator(nwdInformation);
                // Move to the information bookmark 
                bk.MoveToBookmark("Information");
                // Get the content of information bookmark.
                TextBodyPart bodyPart = bk.GetBookmarkContent();
                // Creating a bookmark navigator. Which help us to navigate through the 
                // bookmarks in the destination document.
                bk = new BookmarksNavigator(document);
                // Move to the NorthWind database in the destination document
                bk.MoveToBookmark("NorthwindDatabase");
                //Replace the bookmark content using word document parts
                bk.ReplaceContent(documentPart);
                // Move to the Northwind_Information in the destination document
                bk.MoveToBookmark("Northwind_Information");
                // Replacing content of Northwind_Information bookmark.
                bk.ReplaceBookmarkContent(bodyPart);
                // Move to the text bookmark
                bk.MoveToBookmark("Text");
                //Deletes the bookmark content
                bk.DeleteBookmarkContent(true);
                // Inserting text inside the bookmark. This will preserve the source formatting
                bk.InsertText("Northwind Database contains the following table:");
                #region tableinsertion
                WTable tbl = new WTable(document);
                tbl.TableFormat.Borders.BorderType = Syncfusion.DocIO.DLS.BorderStyle.None;
                tbl.TableFormat.IsAutoResized = true;
                tbl.ResetCells(8, 2);
                IWParagraph paragraph;
                tbl.Rows[0].IsHeader = true;
                paragraph = tbl[0, 0].AddParagraph();
                paragraph.AppendText("Suppliers");
                paragraph.BreakCharacterFormat.FontName = "Calibri";
                paragraph.BreakCharacterFormat.FontSize = 10;

                paragraph = tbl[0, 1].AddParagraph();
                paragraph.AppendText("1");
                paragraph.BreakCharacterFormat.FontName = "Calibri";
                paragraph.BreakCharacterFormat.FontSize = 10;

                paragraph = tbl[1, 0].AddParagraph();
                paragraph.AppendText("Customers");
                paragraph.BreakCharacterFormat.FontName = "Calibri";
                paragraph.BreakCharacterFormat.FontSize = 10;

                paragraph = tbl[1, 1].AddParagraph();
                paragraph.AppendText("1");
                paragraph.BreakCharacterFormat.FontName = "Calibri";
                paragraph.BreakCharacterFormat.FontSize = 10;

                paragraph = tbl[2, 0].AddParagraph();
                paragraph.AppendText("Employees");
                paragraph.BreakCharacterFormat.FontName = "Calibri";
                paragraph.BreakCharacterFormat.FontSize = 10;

                paragraph = tbl[2, 1].AddParagraph();
                paragraph.AppendText("3");
                paragraph.BreakCharacterFormat.FontName = "Calibri";
                paragraph.BreakCharacterFormat.FontSize = 10;

                paragraph = tbl[3, 0].AddParagraph();
                paragraph.AppendText("Products");
                paragraph.BreakCharacterFormat.FontName = "Calibri";
                paragraph.BreakCharacterFormat.FontSize = 10;

                paragraph = tbl[3, 1].AddParagraph();
                paragraph.AppendText("1");
                paragraph.BreakCharacterFormat.FontName = "Calibri";
                paragraph.BreakCharacterFormat.FontSize = 10;

                paragraph = tbl[4, 0].AddParagraph();
                paragraph.AppendText("Inventory");
                paragraph.BreakCharacterFormat.FontName = "Calibri";
                paragraph.BreakCharacterFormat.FontSize = 10;

                paragraph = tbl[4, 1].AddParagraph();
                paragraph.AppendText("2");
                paragraph.BreakCharacterFormat.FontName = "Calibri";
                paragraph.BreakCharacterFormat.FontSize = 10;

                paragraph = tbl[5, 0].AddParagraph();
                paragraph.AppendText("Shippers");
                paragraph.BreakCharacterFormat.FontName = "Calibri";
                paragraph.BreakCharacterFormat.FontSize = 10;

                paragraph = tbl[5, 1].AddParagraph();
                paragraph.AppendText("1");
                paragraph.BreakCharacterFormat.FontName = "Calibri";
                paragraph.BreakCharacterFormat.FontSize = 10;

                paragraph = tbl[6, 0].AddParagraph();
                paragraph.AppendText("PO Transactions");
                paragraph.BreakCharacterFormat.FontName = "Calibri";
                paragraph.BreakCharacterFormat.FontSize = 10;

                paragraph = tbl[6, 1].AddParagraph();
                paragraph.AppendText("3");
                paragraph.BreakCharacterFormat.FontName = "Calibri";
                paragraph.BreakCharacterFormat.FontSize = 10;

                paragraph = tbl[7, 0].AddParagraph();
                paragraph.AppendText("Sales Transactions");
                paragraph.BreakCharacterFormat.FontName = "Calibri";
                paragraph.BreakCharacterFormat.FontSize = 10;

                paragraph = tbl[7, 1].AddParagraph();
                paragraph.AppendText("7");
                paragraph.BreakCharacterFormat.FontName = "Calibri";
                paragraph.BreakCharacterFormat.FontSize = 10;


                bk.InsertTable(tbl);
                #endregion
                //Move to image bookmark
                bk.MoveToBookmark("Image");
                //Deletes the bookmark content
                bk.DeleteBookmarkContent(true);
                // Inserting image to the bookmark.
                IWPicture pic = bk.InsertParagraphItem(ParagraphItemType.Picture) as WPicture;
                pic.LoadImage(System.Drawing.Image.FromFile(@"..\..\..\..\..\..\..\Common\images\DocIO\Northwind.png"));
                pic.WidthScale = 50f;  // It reduces the image size because it doesnot fit 
                pic.HeightScale = 75f; // in document page.
                bodyPart.Close();
                documentPart.Close();
                #region save document
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
                #endregion
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
    }
}

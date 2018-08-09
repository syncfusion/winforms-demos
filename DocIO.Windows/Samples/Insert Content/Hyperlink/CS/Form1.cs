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
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;
using Syncfusion.DocIO;
using Syncfusion.DocIO.DLS;
using Syncfusion.Windows.Forms;
using System.Collections;
using System.IO;
using Syncfusion.DocToPDFConverter;
using Syncfusion.Pdf;
using Syncfusion.Licensing;
using System.Reflection;
using System.Text;

namespace Hyperlinks
{
    public partial class Form1 : MetroForm
    {
        #region Fields
        string path;
        WordDocument document;
        string[] file;
        private ArrayList _WebLinks, _EmailLinks, _FileLinks, _Bookmarks;
        #endregion

        #region Form Load and Constructor
        /// <summary>
        /// Form Constructor
        /// </summary>
        public Form1()
        {		
            InitializeComponent();

            this._WebLinks = new ArrayList();
            this._EmailLinks = new ArrayList();
            this._FileLinks = new ArrayList();
            this._Bookmarks = new ArrayList();

            file = System.Environment.CurrentDirectory.Split(':');
            path = file[0];
            //m_outPath = System.Environment.CurrentDirectory + "\\..\\..\\Output\\";
        }
        /// <summary>
        /// Form Load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            InsertHyperlink();
            this.FindHyperLinks();
            this.webRadioButton.Checked = true;
        }
        #endregion

        # region Helper Methods

        # region InsertHyperlink

        /// <summary>
        /// This methods creates hyperlinks and insert them in the document.
        /// </summary>
        private void InsertHyperlink()
        {
            WordDocument document = new WordDocument();
            IWSection section = document.AddSection();
            IWParagraph para = section.AddParagraph();

            para.AppendText("Inserting Hyperlink");
            para.ApplyStyle(BuiltinStyle.Title);

            section.AddParagraph();

            # region Web Hyperlink
            para = section.AddParagraph();
            para.AppendText("Web Hyperlinks");
            para.ApplyStyle(BuiltinStyle.Heading3);
            para = section.AddParagraph();
            para.AppendText("Hyperlinks to web pages creates a link to a web page, email address or to a program. \nSample Links:");

            para = section.AddParagraph();
            IWField field = para.AppendField("Syncfusion", Syncfusion.DocIO.FieldType.FieldHyperlink);
            para.ApplyStyle(BuiltinStyle.Hyperlink);
            Hyperlink hyperLink = new Hyperlink(field as WField);
            hyperLink.Type = HyperlinkType.WebLink;
            hyperLink.Uri = "http://www.syncfusion.com";

            para = section.AddParagraph();
            para.ApplyStyle(BuiltinStyle.Hyperlink);
            field = para.AppendField("Google", Syncfusion.DocIO.FieldType.FieldHyperlink);
            hyperLink = new Hyperlink(field as WField);
            hyperLink.Type = HyperlinkType.WebLink;
            hyperLink.Uri = "http://www.google.com";

            para = section.AddParagraph();
            para.ApplyStyle(BuiltinStyle.Hyperlink);
            field = para.AppendField("MSN", Syncfusion.DocIO.FieldType.FieldHyperlink);
            hyperLink = new Hyperlink(field as WField);
            hyperLink.Type = HyperlinkType.WebLink;
            hyperLink.Uri = "http://www.msn.com";

            para = section.AddParagraph();
            # endregion

            # region Email Hyperlinks
            para = section.AddParagraph();
            para.AppendText("E-mail Hyperlinks");
            para.ApplyStyle(BuiltinStyle.Heading3);
            para = section.AddParagraph();
            para.AppendText("Hyperlinks that links to e-mail.");

            para = section.AddParagraph();
            para.ApplyStyle(BuiltinStyle.Hyperlink);
            field = para.AppendField("John", Syncfusion.DocIO.FieldType.FieldHyperlink);
            hyperLink = new Hyperlink(field as WField);
            hyperLink.Type = HyperlinkType.EMailLink;
            hyperLink.Uri = "mailto:john@gmail.com";

            para = section.AddParagraph();
            para.ApplyStyle(BuiltinStyle.Hyperlink);
            field = para.AppendField("Eric", Syncfusion.DocIO.FieldType.FieldHyperlink);
            hyperLink = new Hyperlink(field as WField);
            hyperLink.Type = HyperlinkType.EMailLink;
            hyperLink.Uri = "mailto:eric@yahoo.com";

            para = section.AddParagraph();
            para.ApplyStyle(BuiltinStyle.Hyperlink);
            field = para.AppendField("David", Syncfusion.DocIO.FieldType.FieldHyperlink);
            hyperLink = new Hyperlink(field as WField);
            hyperLink.Type = HyperlinkType.EMailLink;
            hyperLink.Uri = "mailto:david@hotmail.com";

            # endregion

            #region Image HyperLink
            para = section.AddParagraph();
            para = section.AddParagraph();
            para.AppendText("Image Hyperlink");
            para.ApplyStyle(BuiltinStyle.Heading3);
            para = section.AddParagraph();
            para.AppendText("Hyperlinks to image creates link to a web page, email address or to a program.");

            para = section.AddParagraph();
            WPicture mImage1 = new WPicture(document);
            mImage1.LoadImage(Image.FromFile(Application.StartupPath + @"\..\..\..\..\..\..\..\Common\Images\DocIO\syncfusion_logo.gif"));
            field = para.AppendField("Hyperlink", Syncfusion.DocIO.FieldType.FieldHyperlink);
            hyperLink = new Hyperlink(field as WField);
            hyperLink.Type = HyperlinkType.WebLink;
            hyperLink.Uri = "http://www.syncfusion.com";
            hyperLink.PictureToDisplay = mImage1;

            para = section.AddParagraph();
            WPicture mImage2 = new WPicture(document);
            mImage2.LoadImage(Image.FromFile(Application.StartupPath + @"\..\..\..\..\..\..\..\Common\Images\DocIO\google.png"));
            field = para.AppendField("Hyperlink", Syncfusion.DocIO.FieldType.FieldHyperlink);
            hyperLink = new Hyperlink(field as WField);
            hyperLink.Type = HyperlinkType.WebLink;
            hyperLink.Uri = "http://www.google.com";
            hyperLink.PictureToDisplay = mImage2;

            para = section.AddParagraph();
            WPicture mImage3 = new WPicture(document);
            mImage3.LoadImage(Image.FromFile(Application.StartupPath + @"\..\..\..\..\..\..\..\Common\Images\DocIO\yahoo.gif"));
            field = para.AppendField("Hyperlink", Syncfusion.DocIO.FieldType.FieldHyperlink);
            hyperLink = new Hyperlink(field as WField);
            hyperLink.Type = HyperlinkType.WebLink;
            hyperLink.Uri = "http://www.yahoo.com";
            hyperLink.PictureToDisplay = mImage3;
            para = section.AddParagraph();
            #endregion

            # region File Hyperlinks
            para = section.AddParagraph();
            para = section.AddParagraph();
            para.AppendText("File Hyperlinks");
            para.ApplyStyle(BuiltinStyle.Heading3);
            para = section.AddParagraph();
            para.AppendText("Hyperlinks to files creates links to other files, an image and so on.");

            para = section.AddParagraph();
            para.ApplyStyle(BuiltinStyle.Hyperlink);
            field = para.AppendField("File 1", Syncfusion.DocIO.FieldType.FieldHyperlink);
            hyperLink = new Hyperlink(field as WField);
            hyperLink.Type = HyperlinkType.FileLink;
            //hyperLink.TextToDisplay = "File 1";
            hyperLink.FilePath = Application.StartupPath + @"\..\..\..\..\..\..\..\Common\Images\DocIO\DocIO.gif";

            para = section.AddParagraph();
            para.ApplyStyle(BuiltinStyle.Hyperlink);
            field = para.AppendField("File 2", Syncfusion.DocIO.FieldType.FieldHyperlink);
            hyperLink = new Hyperlink(field as WField);
            hyperLink.Type = HyperlinkType.FileLink;
            hyperLink.FilePath = Application.StartupPath + @"\..\..\..\..\..\..\..\Common\Images\DocIO\XlsIO.gif";

            para = section.AddParagraph();
            para.ApplyStyle(BuiltinStyle.Hyperlink);
            field = para.AppendField("File 3", Syncfusion.DocIO.FieldType.FieldHyperlink);
            hyperLink = new Hyperlink(field as WField);
            hyperLink.Type = HyperlinkType.FileLink;
            hyperLink.FilePath = Application.StartupPath + @"\..\..\..\..\..\..\..\Common\Images\DocIO\pdf.gif"; ;

            # endregion

            # region BookMarks

            # region Creating BookMarks
            section = document.AddSection();
            section.BreakCode = SectionBreakCode.NewPage;

            para = section.AddParagraph();
            para.AppendBookmarkStart("Introduction");
            para.AppendText("What is Hyperlink?").CharacterFormat.Bold = true;
            para.AppendBookmarkEnd("Introduction");
            para.AppendText("\nA hyperlink is a reference or navigation element in a document to another section of the same document or to another document that may be on or part of a (different) domain.");

            para = section.AddParagraph();
            para = section.AddParagraph();
            para.AppendBookmarkStart("Insert");
            para.AppendText("How to create a Hyperlink?").CharacterFormat.Bold = true;
            para.AppendBookmarkEnd("Insert");
            para.AppendText("\nSyncfusion.DocIO.DLS.IWField field = para.AppendField(\"Syncfusion\", Syncfusion.DocIO.FieldType.FieldHyperlink);\n");
            para.AppendText("para.ApplyStyle(Syncfusion.DocIO.DLS.BuiltinStyle.Hyperlink);\n");
            para.AppendText("Syncfusion.DocIO.DLS.Hyperlink hyperLink = new Hyperlink(field as WField);\n");
            para.AppendText("hyperLink.Type = Syncfusion.DocIO.DLS.HyperlinkType.WebLink;\n");
            para.AppendText("hyperLink.Uri = \"http://www.syncfusion.com\";\n");

            para = section.AddParagraph();
            para.AppendBookmarkStart("Edit");
            para.AppendText("How to edit Hyperlink?").CharacterFormat.Bold = true;
            para.AppendBookmarkEnd("Edit");
            para.AppendText("\nSyncfusion.DocIO.DLS.Hyperlink hlink = new Hyperlink(item as WField);\n");
            para.AppendText("if(hlink.Type = Syncfusion.DocIO.DLS.HyperlinkType.WebLink)\n");
            para.AppendText("{\n");
            para.AppendText("if (hlink.TextToDisplay == \"Syncfusion\")\n");
            para.AppendText("{\n");
            para.AppendText("hlink.TextToDisplay = \"Syncfusion Support\";\n");
            para.AppendText("hlink.Uri = \"http://www.syncfusion.com/support/default.aspx\";\n");
            para.AppendText("}\n");
            para.AppendText("}\n");

            # endregion

            # region Creating BookMark Hyperlinks

            section = document.Sections[0];

            para = section.AddParagraph();
            para = section.AddParagraph();
            para.AppendText("Bookmark Hyperlinks");
            para.ApplyStyle(BuiltinStyle.Heading3);
            para = section.AddParagraph();
            para.AppendText("A bookmark is a location or selected text on a document that was marked. One can create a hyperlink to a bookmark.");

            para = section.AddParagraph();
            para.ApplyStyle(BuiltinStyle.Hyperlink);
            field = para.AppendField("What is Hyperlink?", Syncfusion.DocIO.FieldType.FieldHyperlink);
            hyperLink = new Hyperlink(field as WField);
            hyperLink.Type = HyperlinkType.Bookmark;
            hyperLink.BookmarkName = "Introduction";

            para = section.AddParagraph();
            para.ApplyStyle(BuiltinStyle.Hyperlink);
            field = para.AppendField("How to create a Hyperlink?", Syncfusion.DocIO.FieldType.FieldHyperlink);
            hyperLink = new Hyperlink(field as WField);
            hyperLink.Type = HyperlinkType.Bookmark;
            hyperLink.BookmarkName = "Insert";

            para = section.AddParagraph();
            para.ApplyStyle(BuiltinStyle.Hyperlink);
            field = para.AppendField("How to edit Hyperlink?", Syncfusion.DocIO.FieldType.FieldHyperlink);
            hyperLink = new Hyperlink(field as WField);
            hyperLink.Type = HyperlinkType.Bookmark;
            hyperLink.BookmarkName = "Edit";
            # endregion

            # endregion

            document.Save(Application.StartupPath + "\\Template.doc", FormatType.Doc);
        }

        # endregion

        # region FindHyperlinks
        /// <summary>
        /// Find hyperlinks in the loaded document and updates the underlying database.
        /// </summary>
        private void FindHyperLinks()
        {
            document = new WordDocument(Application.StartupPath + "\\Template.doc");
            foreach (Entity ent in document.ChildEntities)
            {
                if (ent is WSection)
                {
                    WSection section = ent as WSection;
                    foreach (WParagraph paragraph in section.Body.Paragraphs)
                    {
                        foreach (ParagraphItem item in paragraph.Items)
                        {
                            if (item is WField && (item as WField).FieldType == Syncfusion.DocIO.FieldType.FieldHyperlink)
                            {
                                Hyperlink hlink = new Hyperlink(item as WField);
                                switch (hlink.Type)
                                {
                                    case HyperlinkType.WebLink:
                                        if (hlink.PictureToDisplay == null)
                                            this._WebLinks.Add(hlink);
                                        break;
                                    case HyperlinkType.EMailLink:
                                        this._EmailLinks.Add(hlink);
                                        break;
                                    case HyperlinkType.FileLink:
                                        this._FileLinks.Add(hlink);
                                        break;
                                    case HyperlinkType.Bookmark:
                                        this._Bookmarks.Add(hlink);

                                        break;
                                    default:
                                        break;
                                }
                            }
                        }
                    }
                }
            }
        }



        # endregion

        # region Update
        /// <summary>
        /// Updates the database with the edited texts.
        /// </summary>
        /// <param name="list"></param>
        /// <param name="dataMember"></param>
        private void UpdateListBindings(ArrayList list, string dataMember)
        {
            // Bind the ListBox with the appropraite list
            this.detailsListBox.DataSource = list;
            if (this.bkRadioButton.Checked)
                this.detailsListBox.DisplayMember = "BookmarkName";
            else
                this.detailsListBox.DisplayMember = "TextToDisplay";

            this.textBox2.DataBindings.Clear();
            this.textBox1.DataBindings.Clear();

            // Bind the TextBox with the "current" element in the bound list (which would automatically change when the list's selection changes)
            this.textBox2.DataBindings.Add("Text", list, dataMember);
        }

        # endregion

        # endregion

        # region Events

        /// <summary>
        /// Saves the edited hyperlink.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void createBtn_Click(object sender, EventArgs e)
        {
            try
            {
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

        /// <summary>
        /// Updates the web hyperlinks
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void webRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (webRadioButton.Checked)
            {
                this.textBox1.ReadOnly = false;
                this.browseButton.Enabled = false;
                this.label4.Text = this.webRadioButton.Text + " Text";
                this.label3.Text = "Uri";
            }
            this.UpdateListBindings(this._WebLinks, "Uri");
            this.textBox1.DataBindings.Add("Text", this._WebLinks, "TextToDisplay");
        }

        /// <summary>
        /// Updates the mail hyperlinks
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mailRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (mailRadioButton.Checked)
            {
                this.textBox1.ReadOnly = false;
                this.browseButton.Enabled = false;
                this.label4.Text = this.mailRadioButton.Text + " Text";
                this.label3.Text = "Uri";
            }
            this.UpdateListBindings(this._EmailLinks, "Uri");
            this.textBox1.DataBindings.Add("Text", this._EmailLinks, "TextToDisplay");
        }

        /// <summary>
        /// Updates the file hyperlinks
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void fileRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (fileRadioButton.Checked)
            {
                this.textBox1.ReadOnly = false;
                this.browseButton.Enabled = true;
                this.label4.Text = this.fileRadioButton.Text + " Text";
                this.label3.Text = "File Path";
            }
            this.UpdateListBindings(this._FileLinks, "FilePath");
            this.textBox1.DataBindings.Add("Text", this._FileLinks, "TextToDisplay");
        }

        /// <summary>
        /// Updates the bookmark hyperlinks.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bkRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (bkRadioButton.Checked)
            {
                this.textBox1.ReadOnly = true;
                this.browseButton.Enabled = false;
                this.label4.Text = this.bkRadioButton.Text + " Name";
                this.label3.Text = "Bookmark Text";
            }
            this.UpdateListBindings(this._Bookmarks, "TextToDisplay");
            this.textBox1.DataBindings.Add("Text", this._Bookmarks, "BookmarkName");
        }

        /// <summary>
        /// The file browser used to upload in the File Hyperlink.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void browseButton_Click(object sender, EventArgs e)
        {
            this.openFileDialog1.Filter = "All files (*.*)|*.*";
            DialogResult result = this.openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                this.textBox2.Text = Path.GetFullPath(this.openFileDialog1.FileName);
                this.textBox2.Focus();
            }
        }
        /// <summary>
        /// The source template document.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void templateBtn_Click(object sender, EventArgs e)
        {
            Process.Start(Application.StartupPath + "\\Template.doc");
        }
        # endregion
    }
}
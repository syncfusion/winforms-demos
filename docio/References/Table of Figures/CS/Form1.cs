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
using System.Data;
using System.IO;
using System.Diagnostics;

using Syncfusion.DocIO;
using Syncfusion.DocIO.DLS;
using Syncfusion.Windows.Forms;
using Syncfusion.Windows.Forms.Tools;
using Syncfusion.DocToPDFConverter;
using Syncfusion.Pdf;
using Syncfusion.Licensing;
using System.Reflection;
using System.Text;
using System.Collections.Generic;

namespace EssentialDocIOSamples
{

    public class Form1 : MetroForm
    {
        #region Private Members

        private ToolTip toolTip1;
        private ButtonAdv button1;
        private PictureBox pictureBox1;
        private Label label2;
        private ButtonAdv templateBtn;
        private GroupBox groupBox1;
        private RadioButtonAdv wordDocxRadioBtn;
        private RadioButtonAdv wordDocRadioBtn;
        private RadioButtonAdv pdfRadioBtn;
        private CheckBox UnlinkCheckBox;
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
            string filePath = @"common\SyncfusionLicense.txt";

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
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.UnlinkCheckBox = new System.Windows.Forms.CheckBox();
            this.button1 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.templateBtn = new Syncfusion.Windows.Forms.ButtonAdv();
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
            // UnlinkCheckBox
            // 
            this.UnlinkCheckBox.AutoSize = true;
            this.UnlinkCheckBox.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.UnlinkCheckBox.Location = new System.Drawing.Point(19, 161);
            this.UnlinkCheckBox.Name = "UnlinkCheckBox";
            this.UnlinkCheckBox.Size = new System.Drawing.Size(97, 17);
            this.UnlinkCheckBox.TabIndex = 103;
            this.UnlinkCheckBox.Text = "Exclude caption\'s label and number in table of figures";
            this.toolTip1.SetToolTip(this.UnlinkCheckBox, "Exclude caption\'s label and number in table of figures");
            this.UnlinkCheckBox.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218)))));
            this.button1.BeforeTouchSize = new System.Drawing.Size(118, 27);
            this.button1.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.Dashed;
            this.button1.ComboEditBackColor = System.Drawing.Color.Silver;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.KeepFocusRectangle = false;
            this.button1.Location = new System.Drawing.Point(297, 227);
            this.button1.Name = "button1";
            this.button1.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Managed;
            this.button1.Size = new System.Drawing.Size(118, 27);
            this.button1.TabIndex = 62;
            this.button1.TabStop = false;
            this.button1.Text = "Generate";
            this.button1.ThemeName = "Metro";
            this.button1.UseVisualStyle = true;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(427, 101);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 60;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(0, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(427, 70);
            this.label2.TabIndex = 68;
            this.label2.Text = "Click the button to view the generated Word document or PDF. Please note that a Word-compatible viewer is required to open and view the Word document and a PDF viewer is required to view the resultant PDF.";
            // 
            // templateBtn
            // 
            this.templateBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.templateBtn.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.templateBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218)))));
            this.templateBtn.BeforeTouchSize = new System.Drawing.Size(118, 27);
            this.templateBtn.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.Dashed;
            this.templateBtn.ComboEditBackColor = System.Drawing.Color.Silver;
            this.templateBtn.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.templateBtn.ForeColor = System.Drawing.Color.White;
            this.templateBtn.KeepFocusRectangle = false;
            this.templateBtn.Location = new System.Drawing.Point(297, 194);
            this.templateBtn.Name = "templateBtn";
            this.templateBtn.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Managed;
            this.templateBtn.Size = new System.Drawing.Size(118, 27);
            this.templateBtn.TabIndex = 101;
            this.templateBtn.Text = "View Template";
            this.templateBtn.ThemeName = "Metro";
            this.templateBtn.UseVisualStyle = true;
            this.templateBtn.UseVisualStyleBackColor = false;
            this.templateBtn.Click += new System.EventHandler(this.templateBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.wordDocxRadioBtn);
            this.groupBox1.Controls.Add(this.wordDocRadioBtn);
            this.groupBox1.Controls.Add(this.pdfRadioBtn);
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(19, 194);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(269, 55);
            this.groupBox1.TabIndex = 102;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Save As";
            // 
            // wordDocxRadioBtn
            // 
            this.wordDocxRadioBtn.BeforeTouchSize = new System.Drawing.Size(89, 29);
            this.wordDocxRadioBtn.Border3DStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.wordDocxRadioBtn.Checked = true;
            this.wordDocxRadioBtn.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wordDocxRadioBtn.GradientEnd = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.wordDocxRadioBtn.GradientStart = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.wordDocxRadioBtn.ImageCheckBoxSize = new System.Drawing.Size(16, 16);
            this.wordDocxRadioBtn.Location = new System.Drawing.Point(91, 20);
            this.wordDocxRadioBtn.MetroColor = System.Drawing.Color.Empty;
            this.wordDocxRadioBtn.Name = "wordDocxRadioBtn";
            this.wordDocxRadioBtn.Size = new System.Drawing.Size(89, 29);
            this.wordDocxRadioBtn.TabIndex = 103;
            this.wordDocxRadioBtn.Text = "DOCX";
            this.wordDocxRadioBtn.ThemesEnabled = true;
            // 
            // wordDocRadioBtn
            // 
            this.wordDocRadioBtn.BeforeTouchSize = new System.Drawing.Size(79, 29);
            this.wordDocRadioBtn.Border3DStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.wordDocRadioBtn.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.wordDocRadioBtn.GradientEnd = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.wordDocRadioBtn.GradientStart = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.wordDocRadioBtn.ImageCheckBoxSize = new System.Drawing.Size(16, 16);
            this.wordDocRadioBtn.Location = new System.Drawing.Point(6, 20);
            this.wordDocRadioBtn.MetroColor = System.Drawing.Color.Empty;
            this.wordDocRadioBtn.Name = "wordDocRadioBtn";
            this.wordDocRadioBtn.Size = new System.Drawing.Size(79, 29);
            this.wordDocRadioBtn.TabIndex = 44;
            this.wordDocRadioBtn.Text = "DOC";
            this.wordDocRadioBtn.ThemesEnabled = true;
            // 
            // pdfRadioBtn
            // 
            this.pdfRadioBtn.BeforeTouchSize = new System.Drawing.Size(70, 29);
            this.pdfRadioBtn.Border3DStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.pdfRadioBtn.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.pdfRadioBtn.GradientEnd = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.pdfRadioBtn.GradientStart = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.pdfRadioBtn.ImageCheckBoxSize = new System.Drawing.Size(16, 16);
            this.pdfRadioBtn.Location = new System.Drawing.Point(186, 20);
            this.pdfRadioBtn.MetroColor = System.Drawing.Color.Empty;
            this.pdfRadioBtn.Name = "pdfRadioBtn";
            this.pdfRadioBtn.Size = new System.Drawing.Size(70, 29);
            this.pdfRadioBtn.TabIndex = 45;
            this.pdfRadioBtn.Text = "PDF";
            this.pdfRadioBtn.ThemesEnabled = true;
            // 
            // Form1
            // 
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218)))));
            this.ClientSize = new System.Drawing.Size(427, 268);
            this.Controls.Add(this.UnlinkCheckBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.templateBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.DropShadow = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Table of Figures";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.wordDocxRadioBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wordDocRadioBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pdfRadioBtn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        #region Button_Click Event
        private void button1_Click(object sender, System.EventArgs e)
        {
            try
            {
                //Get Template document and database path.
				string dataPath = Application.StartupPath + @"..\..\..\..\..\..\..\common\Data\DocIO\";			

                //Loads the template document.
                WordDocument document = new WordDocument(Path.Combine(dataPath, @"TableOfFiguresInput.docx"));

                #region Add Table of Figures
                //Create a new paragraph.
                WParagraph paragraph = new WParagraph(document);
                paragraph.AppendText("List of Figures");
                //Apply Heading1 style for paragraph.
                paragraph.ApplyStyle(BuiltinStyle.Heading1);
                //Insert the paragraph. 
                document.LastSection.Body.ChildEntities.Insert(0, paragraph);

                //Create new paragraph and append TOC.
                paragraph = new WParagraph(document);
                TableOfContent tableOfContent = paragraph.AppendTOC(1, 3);
                //Disable a flag to exclude heading style paragraphs in TOC entries.
                tableOfContent.UseHeadingStyles = false;
                //Set the name of SEQ field identifier for table of figures.
                tableOfContent.TableOfFiguresLabel = "Figure";
                if (UnlinkCheckBox.Checked)
                    //Disable the flag, to exclude caption's label and number in TOC entries.
                    tableOfContent.IncludeCaptionLabelsAndNumbers = false;

                //Insert the paragraph to the text body.
                document.LastSection.Body.ChildEntities.Insert(1, paragraph);
                #endregion

                #region Add caption for pictures
                //Find all pictures from the document.
                List<Entity> pictures = document.FindAllItemsByProperty(EntityType.Picture, null, null);
                // Iterate each picture and add caption.
                foreach (WPicture picture in pictures)
                {
                    //Set alternate text as caption for picture.
                    WParagraph captionPara = picture.AddCaption("Figure", CaptionNumberingFormat.Number, CaptionPosition.AfterImage) as WParagraph;
                    captionPara.AppendText(" " + picture.AlternativeText);
                    //Apply formatting to the caption.
                    captionPara.ApplyStyle(BuiltinStyle.Caption);
                    captionPara.ParagraphFormat.BeforeSpacing = 8;
                    captionPara.ParagraphFormat.HorizontalAlignment = Syncfusion.DocIO.DLS.HorizontalAlignment.Center;
                }
                #endregion


                #region Add Table of Tables
                // Create a new paragraph.
                paragraph = new WParagraph(document);
                paragraph.AppendText("List of Tables");
                // Apply Heading1 style for paragraph.
                paragraph.ApplyStyle(BuiltinStyle.Heading1);
                // Insert the paragraph.
                document.LastSection.Body.ChildEntities.Insert(2, paragraph);

                //Create a new paragraph and append TOC.
                paragraph = new WParagraph(document);
                tableOfContent = paragraph.AppendTOC(1, 3);
                //Disable a flag to exclude heading style paragraphs in TOC entries.
                tableOfContent.UseHeadingStyles = false;
                //Set the name of SEQ field identifier for table of tables.
                tableOfContent.TableOfFiguresLabel = "Table";
                if (UnlinkCheckBox.Checked)
                    //Disable the flag, to exclude caption's label and number in TOC entries.
                    tableOfContent.IncludeCaptionLabelsAndNumbers = false;
                // Insert the paragraph to the text body.
                document.LastSection.Body.ChildEntities.Insert(3, paragraph);
                #endregion

                #region Add caption for tables
                // Find all tables from the document.
                List<Entity> tables = document.FindAllItemsByProperty(EntityType.Table, null, null);
                //Iterate each table and add caption.
                foreach (WTable table in tables)
                {
                    //Gets the table index.
                    int tableIndex = table.OwnerTextBody.ChildEntities.IndexOf(table);
                    //Create a new paragraph and appends the sequence field to use as a caption.
                    WParagraph captionPara = new WParagraph(document);
                    captionPara.AppendText("Table ");
                    captionPara.AppendField("Table", Syncfusion.DocIO.FieldType.FieldSequence);
                    //Set alternate text as caption for table.
                    captionPara.AppendText(" " + table.Description);
                    // Apply formatting to the paragraph.
                    captionPara.ApplyStyle(BuiltinStyle.Caption);
                    captionPara.ParagraphFormat.BeforeSpacing = 8;
                    captionPara.ParagraphFormat.HorizontalAlignment = Syncfusion.DocIO.DLS.HorizontalAlignment.Center;
                    //Insert the paragraph next to the table.
                    table.OwnerTextBody.ChildEntities.Insert(tableIndex + 1, captionPara);
                }
                #endregion

                #region Update
                //Update all document fields to update SEQ fields.
                document.UpdateDocumentFields();
                //Update the table of contents.
                document.UpdateTableOfContents();
                #endregion

                //Save as doc format.
                if (wordDocRadioBtn.Checked)
                {
                    //Saving the document to disk.
                    document.Save("TableOfFigures.doc");

                    //Message box confirmation to view the created document.
                    if (MessageBoxAdv.Show("Do you want to view the generated Word document?", "Document has been created", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        //Launching the MS Word file using the default Application.[MS Word Or Free WordViewer]
#if NETCORE
                        System.Diagnostics.Process process = new System.Diagnostics.Process();
                        process.StartInfo = new System.Diagnostics.ProcessStartInfo("TableOfFigures.doc") { UseShellExecute = true };
                        process.Start();
#else                       
                        System.Diagnostics.Process.Start("TableOfFigures.doc");
#endif
                        //Exit
                        this.Close();
                    }
                }
                //Save as docx format.
                else if (wordDocxRadioBtn.Checked)
                {
                    //Saving the document as .docx
                    document.Save("TableOfFigures.docx", FormatType.Docx);
                    //Message box confirmation to view the created document.
                    if (MessageBoxAdv.Show("Do you want to view the generated Word document?", "Document has been created", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        try
                        {
                            //Launching the MS Word file using the default Application.[MS Word Or Free WordViewer]
#if NETCORE
                            System.Diagnostics.Process process = new System.Diagnostics.Process();
                            process.StartInfo = new System.Diagnostics.ProcessStartInfo("TableOfFigures.docx") { UseShellExecute = true };
                            process.Start();
#else                       
                            System.Diagnostics.Process.Start("TableOfFigures.docx");
#endif
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
                //Save as pdf format.
                else if (pdfRadioBtn.Checked)
                {
                    DocToPDFConverter converter = new DocToPDFConverter();
                    //Convert word document into PDF document
                    PdfDocument pdfDoc = converter.ConvertToPDF(document);
                    //Save the pdf file
                    pdfDoc.Save("TableOfFigures.pdf");
                    //Message box confirmation to view the created document.
                    if (MessageBoxAdv.Show("Do you want to view the generated PDF?", " Document has been created", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        try
                        {
#if NETCORE
                            System.Diagnostics.Process process = new System.Diagnostics.Process();
                            process.StartInfo = new System.Diagnostics.ProcessStartInfo("TableOfFigures.pdf") { UseShellExecute = true };
                            process.Start();
#else                       
                            System.Diagnostics.Process.Start("TableOfFigures.pdf");
#endif
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
        #endregion
      
        /// <summary>
        /// The source template document.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void templateBtn_Click(object sender, EventArgs e)
        {
#if NETCORE
			System.Diagnostics.Process process = new System.Diagnostics.Process();
			process.StartInfo = new System.Diagnostics.ProcessStartInfo(Application.StartupPath + @"..\..\..\..\..\..\..\common\Data\DocIO\TableOfFiguresInput.docx") { UseShellExecute = true };
			process.Start();
#else                       
			Process.Start(Application.StartupPath + @"\..\..\..\..\..\..\common\Data\DocIO\TableOfFiguresInput.docx");
#endif
        }

    }

}


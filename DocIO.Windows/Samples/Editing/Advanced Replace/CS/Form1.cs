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
using System.IO;
using System.Text.RegularExpressions;

using Syncfusion.DocIO;
using Syncfusion.DocIO.DLS;
using Syncfusion.Windows.Forms;
using Syncfusion.Windows.Forms.Tools;
using Syncfusion.DocToPDFConverter;
using Syncfusion.Pdf;
using Syncfusion.Licensing;
using System.Reflection;
using System.Text;

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
        private RadioButtonAdv radioButton1;
        private RadioButtonAdv radioButton2;
        private GroupBox groupBox1;
        private RadioButton wordDocxRadioBtn;
        private RadioButton pdfRadioBtn;
        private RadioButton wordDocRadioBtn;
        private GroupBox groupBox2;
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
            this.label2 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.radioButton1 = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
            this.radioButton2 = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.wordDocxRadioBtn = new System.Windows.Forms.RadioButton();
            this.pdfRadioBtn = new System.Windows.Forms.RadioButton();
            this.wordDocRadioBtn = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioButton2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            this.button1.Location = new System.Drawing.Point(252, 219);
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
            this.label2.Size = new System.Drawing.Size(372, 58);
            this.label2.TabIndex = 74;
            this.label2.Text = "Click the button to view the generated Word document or PDF. Please note that Microsoft Word Viewer or Microsoft Word is required to view the resultant Word document and PDF viewer is required to view the resultant PDF.";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(372, 82);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 70;
            this.pictureBox1.TabStop = false;
            // 
            // radioButton1
            // 
            this.radioButton1.BeforeTouchSize = new System.Drawing.Size(152, 20);
            this.radioButton1.Border3DStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.radioButton1.Checked = true;
            this.radioButton1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.GradientEnd = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.radioButton1.GradientStart = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.radioButton1.Location = new System.Drawing.Point(6, 16);
            this.radioButton1.MetroColor = System.Drawing.Color.Empty;
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(152, 20);
            this.radioButton1.TabIndex = 76;
            this.radioButton1.Text = "Replace With Formatting";
            this.radioButton1.ThemesEnabled = true;
            // 
            // radioButton2
            // 
            this.radioButton2.BeforeTouchSize = new System.Drawing.Size(117, 20);
            this.radioButton2.Border3DStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.radioButton2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.GradientEnd = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.radioButton2.GradientStart = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.radioButton2.Location = new System.Drawing.Point(176, 16);
            this.radioButton2.MetroColor = System.Drawing.Color.Empty;
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(117, 20);
            this.radioButton2.TabIndex = 77;
            this.radioButton2.TabStop = false;
            this.radioButton2.Text = "Advanced Replace";
            this.radioButton2.ThemesEnabled = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.wordDocxRadioBtn);
            this.groupBox1.Controls.Add(this.pdfRadioBtn);
            this.groupBox1.Controls.Add(this.wordDocRadioBtn);
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 205);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(216, 42);
            this.groupBox1.TabIndex = 78;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Save As";
            // 
            // worddocxRadioBtn
            // 
            this.wordDocxRadioBtn.AutoSize = true;
            this.wordDocxRadioBtn.Checked = true;
            this.wordDocxRadioBtn.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wordDocxRadioBtn.Location = new System.Drawing.Point(84, 20);
            this.wordDocxRadioBtn.Name = "wordDocxRadioBtn";
            this.wordDocxRadioBtn.Size = new System.Drawing.Size(60, 17);
            this.wordDocxRadioBtn.TabIndex = 3;
            this.wordDocxRadioBtn.TabStop = true;
            this.wordDocxRadioBtn.Text = "DOCX";
            this.wordDocxRadioBtn.UseVisualStyleBackColor = true;
            // 
            // pdfRadioBtn
            // 
            this.pdfRadioBtn.AutoSize = true;
            this.pdfRadioBtn.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pdfRadioBtn.Location = new System.Drawing.Point(169, 20);
            this.pdfRadioBtn.Name = "pdfRadioBtn";
            this.pdfRadioBtn.Size = new System.Drawing.Size(47, 17);
            this.pdfRadioBtn.TabIndex = 1;
            this.pdfRadioBtn.TabStop = true;
            this.pdfRadioBtn.Text = "PDF";
            this.pdfRadioBtn.UseVisualStyleBackColor = true;
            // 
            // worddocRadioBtn
            // 
            this.wordDocRadioBtn.AutoSize = true;
            this.wordDocRadioBtn.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wordDocRadioBtn.Location = new System.Drawing.Point(6, 20);
            this.wordDocRadioBtn.Name = "wordDocRadioBtn";
            this.wordDocRadioBtn.Size = new System.Drawing.Size(52, 17);
            this.wordDocRadioBtn.TabIndex = 0;
            this.wordDocRadioBtn.TabStop = true;
            this.wordDocRadioBtn.Text = "DOC";
            this.wordDocRadioBtn.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton1);
            this.groupBox2.Controls.Add(this.radioButton2);
            this.groupBox2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 146);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(318, 44);
            this.groupBox2.TabIndex = 79;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Select Option";
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 15);
            this.BackColor = System.Drawing.Color.White;
            this.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218)))));
            this.ClientSize = new System.Drawing.Size(372, 265);
            this.Controls.Add(this.groupBox2);
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
            this.Text = "Advanced Replace";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioButton2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
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
                if (radioButton1.Checked)
                {
                    // Get Template files path.
                    string dataPath = Application.StartupPath + @"..\..\..\..\..\..\..\..\Common\Data\DocIO\";

                    // Creating new documents.
                    WordDocument docSource1 = new WordDocument();
                    WordDocument docSource2 = new WordDocument();
                    WordDocument docMaster = new WordDocument();

                    // Load Templates.
                    docSource1.Open(Path.Combine(dataPath, "TemplateSource1.doc"), FormatType.Doc);
                    docSource2.Open(Path.Combine(dataPath, "TemplateSource2.doc"), FormatType.Doc);
                    docMaster.Open(Path.Combine(dataPath, "TemplateMaster.doc"), FormatType.Doc);

                    // Search for a string and store in TextSelection
                    //The TextSelection copies a text segment with formatting.
                    TextSelection selection1 = docSource1.Find("PlaceHolder text is replaced with this formatted animated text", false, false);

                    // Search for a string and store in TextSelection
                    TextSelection selection2 = docSource2.Find(new Regex("This is the second Sentence"));

                    // Replacing the placeholder inside Master Template with matches found while
                    //search the two template documents. 
                    docMaster.Replace(new Regex("PlaceHolder1"), selection1);
                    docMaster.Replace(new Regex("PlaceHolder2"), selection2);

                    //Save as doc format
                    if (wordDocRadioBtn.Checked)
                    {
                        //Saving the document to disk.
                        docMaster.Save("Sample.doc");

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
                        docMaster.Save("Sample.docx", FormatType.Docx);
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
                        PdfDocument pdfDoc = converter.ConvertToPDF(docMaster);
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

                }
                else
                {
                    //Load template document
                    WordDocument doc = new WordDocument(@"..\..\..\..\..\..\..\Common\Data\DocIO\original.doc");

                    //Load the document to be replaced 
                    WordDocument replaceDoc = new WordDocument(@"..\..\..\..\..\..\..\Common\Data\DocIO\Replace.doc");

                    //Set Margin of the section
                    doc.LastSection.PageSetup.Margins.All = 72;
                    //Select a table and add it to TextBodyPart
                    TextBodyPart replacePart = new TextBodyPart(replaceDoc);
                    replacePart.BodyItems.Add(replaceDoc.Sections[0].Body.Tables[0] as WTable);

                    //Replace Text with table
                    doc.Replace("INSERT TABLE", replacePart, true, true);

                    //Select text and image
                    replacePart = new TextBodyPart(replaceDoc);
                    TextBodySelection textSel = new TextBodySelection(replaceDoc.LastSection.Body, 0, replaceDoc.LastSection.Paragraphs.Count, 0, 1);
                    replacePart.Copy(textSel);

                    //Replace Text with image and text.
                    doc.Replace("INSERT PARAGRAPH ITEMS", replacePart, false, true);

                    //Save as doc format
                    if (wordDocRadioBtn.Checked)
                    {
                        //Saving the document to disk.
                        doc.Save("Sample.doc");

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
                        doc.Save("Sample.docx", FormatType.Docx);
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
                        PdfDocument pdfDoc = converter.ConvertToPDF(doc);
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
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

    }
}

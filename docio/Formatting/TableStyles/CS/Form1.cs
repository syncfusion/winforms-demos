#region Copyright Syncfusion Inc. 2001 - 2024
//
//  Copyright Syncfusion Inc. 2001 - 2024. All rights reserved.
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
using Syncfusion.DocIO;
using Syncfusion.DocIO.DLS;
using Syncfusion.Windows.Forms;
using Syncfusion.Windows.Forms.Tools;
using System.Data.OleDb;
using Syncfusion.DocToPDFConverter;
using Syncfusion.Pdf;
using Syncfusion.Licensing;
using System.Reflection;
using System.Text;
using System.IO;
using BorderStyle = Syncfusion.DocIO.DLS.BorderStyle;
using System.Collections.Generic;
using System.Xml;

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
        private RadioButtonAdv pdfRadioBtn;
        private IContainer components;
        string fileName, dataBase;
        #endregion

        private RadioButtonAdv wordDocxRadioBtn;

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
            //Launching the MS Word file using the default Application.[MS Word Or Free WordViewer]
#if NETCORE
            fileName = System.Environment.CurrentDirectory + @"\..\..\..\..\..\..\..\common\Data\DocIO\";
            dataBase = System.Environment.CurrentDirectory + @"\..\..\..\..\..\..\..\common\Data\Northwind.mdb";
#else                       
            fileName = System.Environment.CurrentDirectory + @"\..\..\..\..\..\..\common\Data\DocIO\";
            dataBase = System.Environment.CurrentDirectory + @"\..\..\..\..\..\..\common\Data\Northwind.mdb";
#endif
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
            this.pdfRadioBtn = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wordDocxRadioBtn)).BeginInit();
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
            this.button1.UseVisualStyleBackColor = false;
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
            this.pictureBox3.Size = new System.Drawing.Size(366, 83);
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
            this.wordDocxRadioBtn.BeforeTouchSize = new System.Drawing.Size(55, 20);
            this.wordDocxRadioBtn.Border3DStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.wordDocxRadioBtn.Checked = true;
            this.wordDocxRadioBtn.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wordDocxRadioBtn.GradientEnd = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.wordDocxRadioBtn.GradientStart = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.wordDocxRadioBtn.Location = new System.Drawing.Point(31, 16);
            this.wordDocxRadioBtn.MetroColor = System.Drawing.Color.Empty;
            this.wordDocxRadioBtn.Name = "wordDocxRadioBtn";
            this.wordDocxRadioBtn.Size = new System.Drawing.Size(55, 20);
            this.wordDocxRadioBtn.TabIndex = 105;
            this.wordDocxRadioBtn.Text = "DOCX";
            this.wordDocxRadioBtn.ThemesEnabled = true;
            // 
            // pdfRadioBtn
            // 
            this.pdfRadioBtn.BeforeTouchSize = new System.Drawing.Size(46, 20);
            this.pdfRadioBtn.Border3DStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.pdfRadioBtn.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.pdfRadioBtn.GradientEnd = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.pdfRadioBtn.GradientStart = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.pdfRadioBtn.Location = new System.Drawing.Point(151, 16);
            this.pdfRadioBtn.MetroColor = System.Drawing.Color.Empty;
            this.pdfRadioBtn.Name = "pdfRadioBtn";
            this.pdfRadioBtn.Size = new System.Drawing.Size(46, 20);
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
            this.ClientSize = new System.Drawing.Size(366, 226);
            this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.button1);
            this.DropShadow = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Table Styles";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.wordDocxRadioBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pdfRadioBtn)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion

        #region Button_Click Event
        /// <summary>
        /// Creates word document with built - in table styles
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, System.EventArgs e)
        {
            try
            {
                // Open the template document.
                WordDocument document = new WordDocument(fileName + "TemplateTableStyle.doc");

                //Create MailMergeDataTable
                MailMergeDataTable mailMergeDataTable = GetMailMergeDataTable();

                // Execute Mail Merge with groups. 
                document.MailMerge.ExecuteGroup(mailMergeDataTable);

                #region Built-in table styles
                //Get table to apply style.
                WTable table = (WTable)document.LastSection.Tables[0];

                //Apply built-in table style to the table.
                table.ApplyStyle(BuiltinTableStyle.MediumShading1Accent5);
                #endregion

                # region Save Document

                //Save as docx format
                if (wordDocxRadioBtn.Checked)
                {
                    //Saving the document as .docx
                    document.Save("Sample.docx", FormatType.Docx);
                    //Message box confirmation to view the created document.
                    if (MessageBoxAdv.Show("Do you want to view the generated Word document?", "Document has been created", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        try
                        {
                            //Launching the MS Word file using the default Application.[MS Word Or Free WordViewer]
#if NETCORE
                            System.Diagnostics.Process process = new System.Diagnostics.Process();
                            process.StartInfo = new System.Diagnostics.ProcessStartInfo("Sample.docx") { UseShellExecute = true };
                            process.Start();
#else                       
                            System.Diagnostics.Process.Start("Sample.docx");
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
                       
#if NETCORE
                            System.Diagnostics.Process process = new System.Diagnostics.Process();
                            process.StartInfo = new System.Diagnostics.ProcessStartInfo("Sample.pdf") { UseShellExecute = true };
                            process.Start();
#else                       
                            System.Diagnostics.Process.Start("Sample.pdf");
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
                // Open the template document.
                WordDocument document = new WordDocument(fileName + "TemplateTableStyle.doc");

                //Create MailMergeDataTable
                MailMergeDataTable mailMergeDataTable = GetMailMergeDataTable();

                // Execute Mail Merge with groups. 
                document.MailMerge.ExecuteGroup(mailMergeDataTable);

                #region Custom table styles
                //Get table to apply style
                WTable table = (WTable)document.LastSection.Tables[0];
                //Apply custom table style to the table
                #region Apply Table style
                WTableStyle tableStyle = document.AddTableStyle("Tablestyle") as WTableStyle;
                System.Drawing.Color borderColor = System.Drawing.Color.WhiteSmoke;
                System.Drawing.Color firstRowBackColor = System.Drawing.Color.Blue;
                System.Drawing.Color backColor = System.Drawing.Color.WhiteSmoke;
                ConditionalFormattingStyle firstRowStyle, lastRowStyle, firstColumnStyle, lastColumnStyle, oddColumnBandingStyle, oddRowBandingStyle, evenRowBandingStyle;

                #region Table Properties
                tableStyle.TableProperties.RowStripe = 1;
                tableStyle.TableProperties.ColumnStripe = 1;
                tableStyle.TableProperties.LeftIndent = 0;

                tableStyle.TableProperties.Paddings.Top = 0;
                tableStyle.TableProperties.Paddings.Bottom = 0;
                tableStyle.TableProperties.Paddings.Left = 5.4f;
                tableStyle.TableProperties.Paddings.Right = 5.4f;

                tableStyle.TableProperties.Borders.Top.BorderType = BorderStyle.Single;
                tableStyle.TableProperties.Borders.Top.LineWidth = 1f;
                tableStyle.TableProperties.Borders.Top.Color = System.Drawing.Color.AliceBlue;
                tableStyle.TableProperties.Borders.Top.Space = 0;

                tableStyle.TableProperties.Borders.Bottom.BorderType = BorderStyle.Single;
                tableStyle.TableProperties.Borders.Bottom.LineWidth = 1f;
                tableStyle.TableProperties.Borders.Bottom.Color = borderColor;
                tableStyle.TableProperties.Borders.Bottom.Space = 0;

                tableStyle.TableProperties.Borders.Left.BorderType = BorderStyle.Single;
                tableStyle.TableProperties.Borders.Left.LineWidth = 1f;
                tableStyle.TableProperties.Borders.Left.Color = borderColor;
                tableStyle.TableProperties.Borders.Left.Space = 0;

                tableStyle.TableProperties.Borders.Right.BorderType = BorderStyle.Single;
                tableStyle.TableProperties.Borders.Right.LineWidth = 1f;
                tableStyle.TableProperties.Borders.Right.Color = borderColor;
                tableStyle.TableProperties.Borders.Right.Space = 0;

                tableStyle.TableProperties.Borders.Horizontal.BorderType = BorderStyle.Single;
                tableStyle.TableProperties.Borders.Horizontal.LineWidth = 1f;
                tableStyle.TableProperties.Borders.Horizontal.Color = borderColor;
                tableStyle.TableProperties.Borders.Horizontal.Space = 0;
                #endregion

                #region Conditional Formatting Properties
                #region First Row Conditional Formatting Style
                firstRowStyle = tableStyle.ConditionalFormattingStyles.Add(ConditionalFormattingType.FirstRow);

                #region Character format
                firstRowStyle.CharacterFormat.Bold = true;
                firstRowStyle.CharacterFormat.BoldBidi = true;
                firstRowStyle.CharacterFormat.TextColor = System.Drawing.Color.FromArgb(255, 255, 255, 255);
                #endregion

                #region Table Cell Properties
                firstRowStyle.CellProperties.Borders.Top.BorderType = BorderStyle.Single;
                firstRowStyle.CellProperties.Borders.Top.LineWidth = 1f;
                firstRowStyle.CellProperties.Borders.Top.Color = borderColor;
                firstRowStyle.CellProperties.Borders.Top.Space = 0;

                firstRowStyle.CellProperties.Borders.Bottom.BorderType = BorderStyle.Single;
                firstRowStyle.CellProperties.Borders.Bottom.LineWidth = 1f;
                firstRowStyle.CellProperties.Borders.Bottom.Color = borderColor;
                firstRowStyle.CellProperties.Borders.Bottom.Space = 0;

                firstRowStyle.CellProperties.Borders.Left.BorderType = BorderStyle.Single;
                firstRowStyle.CellProperties.Borders.Left.LineWidth = 1f;
                firstRowStyle.CellProperties.Borders.Left.Color = borderColor;
                firstRowStyle.CellProperties.Borders.Left.Space = 0;

                firstRowStyle.CellProperties.Borders.Right.BorderType = BorderStyle.Single;
                firstRowStyle.CellProperties.Borders.Right.LineWidth = 1f;
                firstRowStyle.CellProperties.Borders.Right.Color = borderColor;
                firstRowStyle.CellProperties.Borders.Right.Space = 0;

                firstRowStyle.CellProperties.Borders.Horizontal.BorderType = BorderStyle.Cleared;

                firstRowStyle.CellProperties.Borders.Vertical.BorderType = BorderStyle.Cleared;

                firstRowStyle.CellProperties.BackColor = firstRowBackColor;
                firstRowStyle.CellProperties.ForeColor = System.Drawing.Color.FromArgb(0, 255, 255, 255);
                firstRowStyle.CellProperties.TextureStyle = TextureStyle.TextureNone;
                #endregion
                #endregion

                #region Last Row Conditional Formatting Style
                lastRowStyle = tableStyle.ConditionalFormattingStyles.Add(ConditionalFormattingType.LastRow);

                #region Character format
                lastRowStyle.CharacterFormat.Bold = true;
                lastRowStyle.CharacterFormat.BoldBidi = true;
                #endregion

                #region Table Cell Properties
                lastRowStyle.CellProperties.Borders.Top.BorderType = BorderStyle.Double;
                lastRowStyle.CellProperties.Borders.Top.LineWidth = .75f;
                lastRowStyle.CellProperties.Borders.Top.Color = borderColor;
                lastRowStyle.CellProperties.Borders.Top.Space = 0;

                lastRowStyle.CellProperties.Borders.Bottom.BorderType = BorderStyle.Single;
                lastRowStyle.CellProperties.Borders.Bottom.LineWidth = 1f;
                lastRowStyle.CellProperties.Borders.Bottom.Color = borderColor;
                lastRowStyle.CellProperties.Borders.Bottom.Space = 0;

                lastRowStyle.CellProperties.Borders.Left.BorderType = BorderStyle.Single;
                lastRowStyle.CellProperties.Borders.Left.LineWidth = 1f;
                lastRowStyle.CellProperties.Borders.Left.Color = borderColor;
                lastRowStyle.CellProperties.Borders.Left.Space = 0;

                lastRowStyle.CellProperties.Borders.Right.BorderType = BorderStyle.Single;
                lastRowStyle.CellProperties.Borders.Right.LineWidth = 1f;
                lastRowStyle.CellProperties.Borders.Right.Color = borderColor;
                lastRowStyle.CellProperties.Borders.Right.Space = 0;

                lastRowStyle.CellProperties.Borders.Horizontal.BorderType = BorderStyle.Cleared;

                lastRowStyle.CellProperties.Borders.Vertical.BorderType = BorderStyle.Cleared;
                #endregion
                #endregion

                #region First Column Conditional Formatting Style
                firstColumnStyle = tableStyle.ConditionalFormattingStyles.Add(ConditionalFormattingType.FirstColumn);
                #region Character format
                firstColumnStyle.CharacterFormat.Bold = true;
                firstColumnStyle.CharacterFormat.BoldBidi = true;
                #endregion
                #endregion

                #region Last Column Conditional Formatting Style
                lastColumnStyle = tableStyle.ConditionalFormattingStyles.Add(ConditionalFormattingType.LastColumn);
                #region Character format
                lastColumnStyle.CharacterFormat.Bold = true;
                lastColumnStyle.CharacterFormat.BoldBidi = true;
                #endregion
                #endregion

                #region Odd Column Banding Conditional Formatting Style
                oddColumnBandingStyle = tableStyle.ConditionalFormattingStyles.Add(ConditionalFormattingType.OddColumnBanding);
                #region Table Cell Properties
                oddColumnBandingStyle.CellProperties.BackColor = backColor;
                oddColumnBandingStyle.CellProperties.ForeColor = System.Drawing.Color.FromArgb(0, 255, 255, 255);
                oddColumnBandingStyle.CellProperties.TextureStyle = TextureStyle.TextureNone;
                #endregion
                #endregion

                #region Odd Row Banding Conditional Formatting Style
                oddRowBandingStyle = tableStyle.ConditionalFormattingStyles.Add(ConditionalFormattingType.OddRowBanding);
                #region Table Cell Properties
                oddRowBandingStyle.CellProperties.Borders.Horizontal.BorderType = BorderStyle.Cleared;

                oddRowBandingStyle.CellProperties.Borders.Vertical.BorderType = BorderStyle.Cleared;

                oddRowBandingStyle.CellProperties.BackColor = backColor;
                oddRowBandingStyle.CellProperties.ForeColor = System.Drawing.Color.FromArgb(0, 255, 255, 255);
                oddRowBandingStyle.CellProperties.TextureStyle = TextureStyle.TextureNone;
                #endregion
                #endregion

                #region Even Row Banding Conditional Formatting Style
                evenRowBandingStyle = tableStyle.ConditionalFormattingStyles.Add(ConditionalFormattingType.EvenRowBanding);
                #region Table Cell Properties
                evenRowBandingStyle.CellProperties.Borders.Horizontal.BorderType = BorderStyle.Cleared;
                evenRowBandingStyle.CellProperties.Borders.Vertical.BorderType = BorderStyle.Cleared;
                #endregion
                #endregion
                #endregion
                #endregion
                table.ApplyStyle("Tablestyle");
                #endregion

                #region Save Document

                //Save as docx format
                if (wordDocxRadioBtn.Checked)
                {
                    //Saving the document as .docx
                    document.Save("Sample.docx", FormatType.Docx);
                    //Message box confirmation to view the created document.
                    if (MessageBoxAdv.Show("Do you want to view the generated Word document?", "Document has been created", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        try
                        {
                            //Launching the MS Word file using the default Application.[MS Word Or Free WordViewer]
#if NETCORE
                            System.Diagnostics.Process process = new System.Diagnostics.Process();
                            process.StartInfo = new System.Diagnostics.ProcessStartInfo("Sample.docx") { UseShellExecute = true };
                            process.Start();
#else                       
                            System.Diagnostics.Process.Start("Sample.docx");
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
#if NETCORE
                            System.Diagnostics.Process process = new System.Diagnostics.Process();
                            process.StartInfo = new System.Diagnostics.ProcessStartInfo("Sample.pdf") { UseShellExecute = true };
                            process.Start();
#else                       
                            System.Diagnostics.Process.Start("Sample.pdf");
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
                # endregion
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
		}
        #region Helper Methods
        /// <summary>
        /// Gets the mail merge data table.
        /// </summary>
        /// <returns></returns>
        /// <exception cref="System.Exception">reader</exception>
        /// <exception cref="XmlException">Unexpected xml tag  + reader.LocalName</exception>
        private MailMergeDataTable GetMailMergeDataTable()
        {
            List<Suppliers> suppliers = new List<Suppliers>();
            FileStream fs = new FileStream(fileName + "Suppliers.xml", FileMode.Open, FileAccess.Read);
            XmlReader reader = XmlReader.Create(fs);
            if (reader == null)
                throw new Exception("reader");
            while (reader.NodeType != XmlNodeType.Element)
                reader.Read();
            if (reader.LocalName != "SuppliersList")
                throw new XmlException("Unexpected xml tag " + reader.LocalName);
            reader.Read();
            while (reader.NodeType == XmlNodeType.Whitespace)
                reader.Read();
            while (reader.LocalName != "SuppliersList")
            {
                if (reader.NodeType == XmlNodeType.Element)
                {
                    switch (reader.LocalName)
                    {
                        case "Suppliers":
                            suppliers.Add(GetSupplier(reader));
                            break;
                    }
                }
                else
                {
                    reader.Read();
                    if ((reader.LocalName == "SuppliersList") && reader.NodeType == XmlNodeType.EndElement)
                        break;
                }
            }
            MailMergeDataTable dataTable = new MailMergeDataTable("Suppliers", suppliers);
            reader.Close();
            fs.Dispose();
            return dataTable;
        }
        /// <summary>
        /// Gets the suppliers.
        /// </summary>
        /// <param name="reader">The reader.</param>
        /// <returns></returns>
        /// <exception cref="System.Exception">reader</exception>
        /// <exception cref="XmlException">Unexpected xml tag  + reader.LocalName</exception>
        private Suppliers GetSupplier(XmlReader reader)
        {
            if (reader == null)
                throw new Exception("reader");
            while (reader.NodeType != XmlNodeType.Element)
                reader.Read();
            if (reader.LocalName != "Suppliers")
                throw new XmlException("Unexpected xml tag " + reader.LocalName);
            reader.Read();
            while (reader.NodeType == XmlNodeType.Whitespace)
                reader.Read();
            Suppliers supplier = new Suppliers();
            while (reader.LocalName != "Suppliers")
            {
                if (reader.NodeType == XmlNodeType.Element)
                {
                    switch (reader.LocalName)
                    {
                        case "SupplierID":
                            supplier.SupplierID = reader.ReadElementContentAsString();
                            break;
                        case "CompanyName":
                            supplier.CompanyName = reader.ReadElementContentAsString();
                            break;
                        case "ContactName":
                            supplier.ContactName = reader.ReadElementContentAsString();
                            break;
                        case "ContactTitle":
                            supplier.ContactTitle = reader.ReadElementContentAsString();
                            break;
                        case "Region":
                            supplier.Region = reader.ReadElementContentAsString();
                            break;
                        case "PostalCode":
                            supplier.PostalCode = reader.ReadElementContentAsString();
                            break;
                        case "Phone":
                            supplier.Phone = reader.ReadElementContentAsString();
                            break;
                        case "Fax":
                            supplier.Fax = reader.ReadElementContentAsString();
                            break;
                        case "HomePage":
                            supplier.HomePage = reader.ReadElementContentAsString();
                            break;
                        case "Address":
                            supplier.Address = reader.ReadElementContentAsString();
                            break;
                        case "City":
                            supplier.City = reader.ReadElementContentAsString();
                            break;
                        case "Country":
                            supplier.Country = reader.ReadElementContentAsString();
                            break;
                        default:
                            reader.Skip();
                            break;
                    }
                }
                else
                {
                    reader.Read();
                    if ((reader.LocalName == "Suppliers") && reader.NodeType == XmlNodeType.EndElement)
                        break;
                }
            }
            return supplier;
        }
        #endregion
    }
    #region Helper Class
    public class Suppliers
    {
        #region Fields
        private string m_id;
        private string m_companyName;
        private string m_contactName;
        private string m_address;
        private string m_city;
        private string m_country;
        private string m_contactTitle;
        private string m_region;
        private string m_postalCode;
        private string m_phone;
        private string m_fax;
        private string m_homePage;
        #endregion
        #region Properties
        public string SupplierID
        {
            get { return m_id; }
            set { m_id = value; }
        }
        public string CompanyName
        {
            get { return m_companyName; }
            set { m_companyName = value; }
        }
        public string ContactName
        {
            get { return m_contactName; }
            set { m_contactName = value; }
        }
        public string ContactTitle
        {
            get { return m_contactTitle; }
            set { m_contactTitle = value; }
        }
        public string Region
        {
            get { return m_region; }
            set { m_region = value; }
        }
        public string PostalCode
        {
            get { return m_postalCode; }
            set { m_postalCode = value; }
        }
        public string Phone
        {
            get { return m_phone; }
            set { m_phone = value; }
        }
        public string Fax
        {
            get { return m_fax; }
            set { m_fax = value; }
        }
        public string HomePage
        {
            get { return m_homePage; }
            set { m_homePage = value; }
        }
        public string Address
        {
            get { return m_address; }
            set { m_address = value; }
        }
        public string City
        {
            get { return m_city; }
            set { m_city = value; }
        }
        public string Country
        {
            get { return m_country; }
            set { m_country = value; }
        }
        #endregion
        #region Constructor
        public Suppliers(string id, string companyName, string contantName, string address, string city, string country)
        {
            m_id = id;
            m_companyName = companyName;
            m_contactName = contantName;
            m_address = address;
            m_city = city;
            m_country = country;
        }
        public Suppliers()
        { }
        #endregion
    }
    #endregion
}
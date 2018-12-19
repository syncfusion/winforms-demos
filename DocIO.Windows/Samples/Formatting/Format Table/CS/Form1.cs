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

        private ButtonAdv button1;
        private ToolTip toolTip1;
        private Label label2;
        private PictureBox pictureBox1;
        private GroupBox groupBox1;
        private RadioButtonAdv wordDocxRadioBtn;
        private RadioButtonAdv wordDocRadioBtn;
        private RadioButtonAdv pdfRadioBtn;
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
            this.button1.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.Dashed;
            this.button1.ComboEditBackColor = System.Drawing.Color.Silver;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.IsBackStageButton = false;
            this.button1.KeepFocusRectangle = false;
            this.button1.Location = new System.Drawing.Point(245, 163);
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
            this.label2.Size = new System.Drawing.Size(363, 60);
            this.label2.TabIndex = 72;
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
            this.groupBox1.Location = new System.Drawing.Point(12, 148);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(209, 41);
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
            this.wordDocxRadioBtn.Location = new System.Drawing.Point(82, 18);
            this.wordDocxRadioBtn.MetroColor = System.Drawing.Color.Empty;
            this.wordDocxRadioBtn.Name = "wordDocxRadioBtn";
            this.wordDocxRadioBtn.Size = new System.Drawing.Size(53, 20);
            this.wordDocxRadioBtn.TabIndex = 103;
            this.wordDocxRadioBtn.Text = "DOCX";
            this.wordDocxRadioBtn.ThemesEnabled = true;
            // 
            // worddocRadioBtn
            // 
            this.wordDocRadioBtn.BeforeTouchSize = new System.Drawing.Size(49, 20);
            this.wordDocRadioBtn.Border3DStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.wordDocRadioBtn.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.wordDocRadioBtn.GradientEnd = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.wordDocRadioBtn.GradientStart = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.wordDocRadioBtn.Location = new System.Drawing.Point(6, 18);
            this.wordDocRadioBtn.MetroColor = System.Drawing.Color.Empty;
            this.wordDocRadioBtn.Name = "wordDocRadioBtn";
            this.wordDocRadioBtn.Size = new System.Drawing.Size(49, 20);
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
            this.pdfRadioBtn.Location = new System.Drawing.Point(161, 18);
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
            this.Text = "Format Table";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.wordDocxRadioBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wordDocRadioBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pdfRadioBtn)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion

        #region Button Click
        private void button1_Click(object sender, System.EventArgs e)
        {
            try
            {
                // Create a new document.
                WordDocument document = new WordDocument();

                // Adding a new section to the document.
                IWSection section = document.AddSection();
                section.PageSetup.DifferentFirstPage = true;
                IWTextRange textRange;
                IWParagraph paragraph = section.AddParagraph();

                // --------------------------------------------
                // Table in page header 
                // --------------------------------------------


                IWParagraph hParagraph = new WParagraph(document);
                hParagraph.AppendText("Header text\r\n").CharacterFormat.FontSize = 14;

                section.HeadersFooters.FirstPageHeader.Paragraphs.Add(hParagraph);


                IWTable hTable = document.LastSection.HeadersFooters.FirstPageHeader.AddTable();

                hTable.TableFormat.Borders.BorderType = Syncfusion.DocIO.DLS.BorderStyle.Single;
                hTable.TableFormat.Paddings.All = 5.4f;
                hTable.ResetCells(2, 2);

                hTable[0, 0].AddParagraph().AppendText("1");
                hTable[0, 1].AddParagraph().AppendText("2");
                hTable[1, 0].AddParagraph().AppendText("3");
                hTable[1, 1].AddParagraph().AppendText("4");


                // --------------------------------------------
                // Tiny table
                // --------------------------------------------

                paragraph = section.AddParagraph();

                paragraph.AppendText("Tiny table\r\n").CharacterFormat.FontSize = 14;
                paragraph = section.AddParagraph();
                WTextBody textBody = section.Body;
                IWTable table = textBody.AddTable();
                table.ResetCells(2, 2);

                table.TableFormat.Borders.BorderType = Syncfusion.DocIO.DLS.BorderStyle.Single;
                table.TableFormat.Paddings.All = 5.4f;
                WTableRow row_0 = table.Rows[0];
                row_0.Cells[0].AddParagraph().AppendText("A");
                row_0.Cells[0].AddParagraph().AppendText("AA");
                row_0.Cells[0].AddParagraph().AppendText("AAA");

                WTableRow row_1 = table.Rows[1];
                row_1.Cells[1].AddParagraph().AppendText("B");
                row_1.Cells[1].AddParagraph().AppendText("BB\r\nBBB");
                row_1.Cells[1].AddParagraph().AppendText("BBB");

                textBody.AddParagraph().AppendText("Text after table...").CharacterFormat.FontSize = 14;

                // --------------------------------------------
                // Table with different formatting 
                // --------------------------------------------

                section.AddParagraph();
                paragraph = section.AddParagraph();
                paragraph.AppendText("Table with different formatting\r\n").CharacterFormat.FontSize = 14;
                paragraph = section.AddParagraph();
                textBody = section.Body;
                table = textBody.AddTable();
                table.ResetCells(3, 3);

                /* ------- First Row -------- */

                WTableRow row0 = table.Rows[0];

                paragraph = (IWParagraph)row0.Cells[0].AddParagraph();
                textRange = paragraph.AppendText("1");
                paragraph.ParagraphFormat.HorizontalAlignment = Syncfusion.DocIO.DLS.HorizontalAlignment.Left;
                textRange.CharacterFormat.FontName = "Arial";
                textRange.CharacterFormat.Bold = true;
                textRange.CharacterFormat.FontSize = 14f;
                row0.Cells[0].CellFormat.Borders.LineWidth = 2f;
                row0.Cells[0].CellFormat.Borders.Color = Color.Magenta;

                paragraph = (IWParagraph)row0.Cells[1].AddParagraph();
                textRange = paragraph.AppendText("2");
                paragraph.ParagraphFormat.HorizontalAlignment = Syncfusion.DocIO.DLS.HorizontalAlignment.Right;
                textRange.CharacterFormat.Emboss = true;
                textRange.CharacterFormat.FontSize = 15f;
                row0.Cells[1].CellFormat.Borders.LineWidth = 1.3f;
                row0.Cells[1].CellFormat.Borders.BorderType = Syncfusion.DocIO.DLS.BorderStyle.DoubleWave;

                paragraph = (IWParagraph)row0.Cells[2].AddParagraph();
                textRange = paragraph.AppendText("3");
                paragraph.ParagraphFormat.HorizontalAlignment = Syncfusion.DocIO.DLS.HorizontalAlignment.Left;
                textRange.CharacterFormat.Engrave = true;
                textRange.CharacterFormat.FontSize = 15f;
                row0.Cells[2].CellFormat.Borders.BorderType = Syncfusion.DocIO.DLS.BorderStyle.Emboss3D;

                /* ------- Second Row -------- */

                WTableRow row1 = table.Rows[1];

                paragraph = (IWParagraph)row1.Cells[0].AddParagraph();
                textRange = paragraph.AppendText("4");
                paragraph.ParagraphFormat.HorizontalAlignment = Syncfusion.DocIO.DLS.HorizontalAlignment.Center;
                textRange.CharacterFormat.SmallCaps = true;
                textRange.CharacterFormat.FontName = "Comic Sans MS";
                textRange.CharacterFormat.FontSize = 16;
                row1.Cells[0].CellFormat.Borders.LineWidth = 2f;
                row1.Cells[0].CellFormat.Borders.BorderType = Syncfusion.DocIO.DLS.BorderStyle.DashDotStroker;

                paragraph = (IWParagraph)row1.Cells[1].AddParagraph();
                textRange = paragraph.AppendText("5");
                paragraph.ParagraphFormat.HorizontalAlignment = Syncfusion.DocIO.DLS.HorizontalAlignment.Center;
                textRange.CharacterFormat.FontName = "Times New Roman";
                textRange.CharacterFormat.Shadow = true;
                textRange.CharacterFormat.TextBackgroundColor = Color.Orange;
                textRange.CharacterFormat.FontSize = 15f;
                row1.Cells[1].CellFormat.Borders.LineWidth = 2f;
                row1.Cells[1].CellFormat.Borders.Color = Color.Brown;

                paragraph = (IWParagraph)row1.Cells[2].AddParagraph();
                textRange = paragraph.AppendText("6");
                paragraph.ParagraphFormat.HorizontalAlignment = Syncfusion.DocIO.DLS.HorizontalAlignment.Center;
                textRange.CharacterFormat.Bold = true;
                textRange.CharacterFormat.FontSize = 14f;
                row1.Cells[2].CellFormat.BackColor = Color.FromArgb(51, 51, 101);
                row1.Cells[2].CellFormat.VerticalAlignment = Syncfusion.DocIO.DLS.VerticalAlignment.Middle;

                /* ------- Third Row -------- */

                WTableRow row2 = table.Rows[2];

                paragraph = (IWParagraph)row2.Cells[0].AddParagraph();
                textRange = paragraph.AppendText("7");
                paragraph.ParagraphFormat.HorizontalAlignment = Syncfusion.DocIO.DLS.HorizontalAlignment.Right;
                textRange.CharacterFormat.FontSize = 13f;
                row2.Cells[0].CellFormat.Borders.LineWidth = 1.5f;
                row2.Cells[0].CellFormat.Borders.BorderType = Syncfusion.DocIO.DLS.BorderStyle.DashLargeGap;

                paragraph = (IWParagraph)row2.Cells[1].AddParagraph();
                textRange = paragraph.AppendText("8");
                textRange.CharacterFormat.TextColor = Color.Blue;
                textRange.CharacterFormat.FontSize = 16f;
                row2.Cells[1].CellFormat.Borders.LineWidth = 3f;
                row2.Cells[1].CellFormat.Borders.BorderType = Syncfusion.DocIO.DLS.BorderStyle.Wave;

                paragraph = (IWParagraph)row2.Cells[2].AddParagraph();
                textRange = paragraph.AppendText("9");
                paragraph.ParagraphFormat.HorizontalAlignment = Syncfusion.DocIO.DLS.HorizontalAlignment.Right;
                row2.Cells[2].CellFormat.Borders.LineWidth = 2f;
                row2.Cells[2].CellFormat.Borders.Color = Color.Cyan;
                row2.Cells[2].CellFormat.Borders.Shadow = true;
                row2.Cells[2].CellFormat.Borders.Space = 20;

                // --------------------------------------------
                // Table Cell Merging.
                // --------------------------------------------

                section.AddParagraph();
                paragraph = section.AddParagraph();
                paragraph.AppendText("Table Cell Merging...").CharacterFormat.FontSize = 14;
                section.AddParagraph();
                paragraph = section.AddParagraph();
                textBody = section.Body;

                // Adding a new Table to the textbody.
                table = textBody.AddTable();
                table.TableFormat.Borders.BorderType = Syncfusion.DocIO.DLS.BorderStyle.Single;
                table.TableFormat.Paddings.All = 5.4f;

                RowFormat format = new RowFormat();
                format.Paddings.All = 5;
                format.Borders.BorderType = Syncfusion.DocIO.DLS.BorderStyle.Dot;
                format.Borders.LineWidth = 2;

                // Inserting rows to the table.
                table.ResetCells(6, 6, format, 80);

                // Table formatting with cell merging.
                table.Rows[0].Cells[0].CellFormat.HorizontalMerge = CellMerge.Start;
                table.Rows[0].Cells[1].CellFormat.HorizontalMerge = CellMerge.Continue;
                table.Rows[0].Cells[0].CellFormat.VerticalAlignment = Syncfusion.DocIO.DLS.VerticalAlignment.Middle;
                table.Rows[0].Cells[0].CellFormat.BackColor = Color.FromArgb(218, 230, 246);
                IWParagraph par = table.Rows[0].Cells[0].AddParagraph();
                par.ParagraphFormat.HorizontalAlignment = Syncfusion.DocIO.DLS.HorizontalAlignment.Center;
                par.AppendText("Horizontal Merge").CharacterFormat.Bold = true;


                table.Rows[2].Cells[3].CellFormat.VerticalMerge = CellMerge.Start;
                table.Rows[3].Cells[3].CellFormat.VerticalMerge = CellMerge.Continue;

                table.Rows[2].Cells[3].CellFormat.VerticalAlignment = Syncfusion.DocIO.DLS.VerticalAlignment.Middle;
                par = table.Rows[2].Cells[3].AddParagraph();
                table.Rows[2].Cells[3].CellFormat.BackColor = Color.FromArgb(252, 172, 85);
                par.ParagraphFormat.HorizontalAlignment = Syncfusion.DocIO.DLS.HorizontalAlignment.Center;
                par.AppendText("Vertical Merge").CharacterFormat.Bold = true;

                #region Table Cell Spacing.
                // --------------------------------------------
                // Table Cell Spacing.
                // --------------------------------------------

                section.AddParagraph();
                paragraph = section.AddParagraph();
                paragraph.AppendText("Table Cell spacing...").CharacterFormat.FontSize = 14;

                section.AddParagraph();
                paragraph = section.AddParagraph();
                textBody = section.Body;

                // Adding a new Table to the textbody.
                table = textBody.AddTable();

                format = new RowFormat();

                format.Paddings.All = 5;
                format.CellSpacing = 2;
                format.Borders.BorderType = Syncfusion.DocIO.DLS.BorderStyle.DotDash;
                format.IsBreakAcrossPages = true;
                table.ResetCells(25, 5, format, 90);
                IWTextRange text;
                table.Rows[0].IsHeader = true;

                for (int i = 0; i < table.Rows[0].Cells.Count; i++)
                {
                    paragraph = table[0, i].AddParagraph() as WParagraph;
                    paragraph.ParagraphFormat.HorizontalAlignment = Syncfusion.DocIO.DLS.HorizontalAlignment.Center;
                    text = paragraph.AppendText(string.Format("Header {0}", i + 1));
                    text.CharacterFormat.Font = new Font("Bitstream Vera Serif", 10);
                    text.CharacterFormat.Bold = true;
                    text.CharacterFormat.TextColor = Color.FromArgb(0, 21, 84);
                    table[0, i].CellFormat.BackColor = Color.FromArgb(203, 211, 226);
                }

                for (int i = 1; i < table.Rows.Count; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        paragraph = table[i, j].AddParagraph() as WParagraph;
                        paragraph.ParagraphFormat.HorizontalAlignment = Syncfusion.DocIO.DLS.HorizontalAlignment.Center;

                        text = paragraph.AppendText(string.Format("Cell {0} , {1}", i, j + 1));
                        text.CharacterFormat.TextColor = Color.FromArgb(242, 151, 50);
                        text.CharacterFormat.Bold = true;
                        if (i % 2 != 1)
                            table[i, j].CellFormat.BackColor = Color.FromArgb(231, 235, 245);
                        else
                            table[i, j].CellFormat.BackColor = Color.FromArgb(246, 249, 255);

                    }

                }
                #endregion Table Cell Spacing.

                #region Nested Table
                // --------------------------------------------
                // Nested Table.
                // --------------------------------------------

                section.AddParagraph();
                paragraph = section.AddParagraph();
                paragraph.ParagraphFormat.PageBreakBefore = true;
                paragraph.AppendText("Nested Table...").CharacterFormat.FontSize = 14;

                section.AddParagraph();
                paragraph = section.AddParagraph();
                textBody = section.Body;

                // Adding a new Table to the textbody.
                table = textBody.AddTable();

                format = new RowFormat();
                format.Paddings.All = 5;
                format.CellSpacing = 2.5f;
                format.Borders.BorderType = Syncfusion.DocIO.DLS.BorderStyle.DotDash;
                table.ResetCells(5, 3, format, 100);


                for (int i = 0; i < table.Rows[0].Cells.Count; i++)
                {
                    paragraph = table[0, i].AddParagraph() as WParagraph;
                    paragraph.ParagraphFormat.HorizontalAlignment = Syncfusion.DocIO.DLS.HorizontalAlignment.Center;
                    text = paragraph.AppendText(string.Format("Header {0}", i + 1));
                    text.CharacterFormat.Font = new Font("Bitstream Vera Serif", 10);
                    text.CharacterFormat.Bold = true;
                    text.CharacterFormat.TextColor = Color.FromArgb(0, 21, 84);
                    table[0, i].CellFormat.BackColor = Color.FromArgb(242, 151, 50);
                }
                table[0, 2].Width = 200;
                for (int i = 1; i < table.Rows.Count; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        paragraph = table[i, j].AddParagraph() as WParagraph;
                        paragraph.ParagraphFormat.HorizontalAlignment = Syncfusion.DocIO.DLS.HorizontalAlignment.Center;

                        if ((i == 2) && (j == 2))
                        {
                            text = paragraph.AppendText("Nested Table");
                        }

                        else
                        {
                            text = paragraph.AppendText(string.Format("Cell {0} , {1}", i, j + 1));
                        }

                        if ((j == 2))
                            table[i, j].Width = 200;

                        text.CharacterFormat.TextColor = Color.FromArgb(242, 151, 50);
                        text.CharacterFormat.Bold = true;

                    }

                }

                // Adding a nested Table.
                IWTable nestTable = table[2, 2].AddTable();

                format = new RowFormat();

                format.Borders.BorderType = Syncfusion.DocIO.DLS.BorderStyle.DotDash;
                format.HorizontalAlignment = RowAlignment.Center;
                nestTable.ResetCells(3, 3, format, 45);

                for (int i = 0; i < nestTable.Rows.Count; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        paragraph = nestTable[i, j].AddParagraph() as WParagraph;
                        paragraph.ParagraphFormat.HorizontalAlignment = Syncfusion.DocIO.DLS.HorizontalAlignment.Center;

                        nestTable[i, j].CellFormat.BackColor = Color.FromArgb(231, 235, 245);
                        text = paragraph.AppendText(string.Format("Cell {0} , {1}", i, j + 1));
                        text.CharacterFormat.TextColor = Color.Black;
                        text.CharacterFormat.Bold = true;
                    }
                }
                #endregion Nested Table

                #region Table with Images
                string dataPath = Application.StartupPath + @"\..\..\..\..\..\..\..\Common\images\DocIO\";

                //Add a new section to the document.
                section = document.AddSection();
                //Add paragraph to the section.
                paragraph = section.AddParagraph();
                //Writing text.
                textRange = paragraph.AppendText("Table with Images");
                textRange.CharacterFormat.FontSize = 13f;
                textRange.CharacterFormat.TextColor = Color.DarkBlue;
                textRange.CharacterFormat.Bold = true;

                //Add paragraph to the section.
                section.AddParagraph();
                paragraph = section.AddParagraph();

                text = null;

                //Adding a new Table to the paragraph.
                table = section.Body.AddTable();
                table.ResetCells(1, 3);

                //Adding rows to the table.
                WTableRow row = table.Rows[0];
                //Set heading row height
                row.Height = 25f;
                //set heading values to the Table.
                for (int i = 0; i < 3; i++)
                {
                    //Add paragraph for writing Text to the cells.
                    paragraph = (IWParagraph)row.Cells[i].AddParagraph();
                    //Set Horizontal Alignment as Center.
                    paragraph.ParagraphFormat.HorizontalAlignment = Syncfusion.DocIO.DLS.HorizontalAlignment.Center;
                    //Writing Row Heading
                    switch (i)
                    {
                        case 0: text = paragraph.AppendText("SNO");
                            row.Cells[i].Width = 50f; break;
                        case 1: text = paragraph.AppendText("Drinks"); break;
                        case 2: text = paragraph.AppendText("Showcase Image"); row.Cells[i].Width = 200f; break;
                    }
                    //Set row Heading formatting
                    text.CharacterFormat.Bold = true;
                    text.CharacterFormat.FontName = "Cambria";
                    text.CharacterFormat.FontSize = 11f;
                    text.CharacterFormat.TextColor = Color.White;

                    //Set row cells formatting
                    row.Cells[i].CellFormat.VerticalAlignment = Syncfusion.DocIO.DLS.VerticalAlignment.Middle;
                    row.Cells[i].CellFormat.BackColor = Color.FromArgb(157, 161, 190);

                    row.Cells[i].CellFormat.Borders.BorderType = Syncfusion.DocIO.DLS.BorderStyle.Single;
                }

                int sno = 1;
                //Writing Sno, Product name and Product Images to the Table.

                row1 = table.AddRow(false);

                //Writing SNO to the table with formatting text.
                paragraph = (IWParagraph)row1.Cells[0].AddParagraph();
                paragraph.ParagraphFormat.HorizontalAlignment = Syncfusion.DocIO.DLS.HorizontalAlignment.Center;
                text = paragraph.AppendText(sno.ToString());
                text.CharacterFormat.Bold = true;
                text.CharacterFormat.FontSize = 10f;
                row1.Cells[0].CellFormat.VerticalAlignment = Syncfusion.DocIO.DLS.VerticalAlignment.Middle;
                row1.Cells[0].CellFormat.Borders.BorderType = Syncfusion.DocIO.DLS.BorderStyle.Single;
                row1.Cells[0].CellFormat.BackColor = Color.FromArgb(217, 223, 239);
                //Writing Product Name to the table with Formatting.
                paragraph = (IWParagraph)row1.Cells[1].AddParagraph();
                paragraph.ParagraphFormat.HorizontalAlignment = Syncfusion.DocIO.DLS.HorizontalAlignment.Center;
                text = paragraph.AppendText("Apple Juice");
                text.CharacterFormat.Bold = true;
                text.CharacterFormat.FontSize = 10f;
                text.CharacterFormat.TextColor = Color.FromArgb(50, 65, 124);
                row1.Cells[1].CellFormat.VerticalAlignment = Syncfusion.DocIO.DLS.VerticalAlignment.Middle;
                row1.Cells[1].CellFormat.Borders.BorderType = Syncfusion.DocIO.DLS.BorderStyle.Single;
                row1.Cells[1].CellFormat.BackColor = Color.FromArgb(217, 223, 239);

                //Writing Product Images to the Table.
                paragraph = (IWParagraph)row1.Cells[2].AddParagraph();
                paragraph.AppendPicture(Image.FromFile(dataPath + "Apple Juice.png"));
                paragraph.ParagraphFormat.HorizontalAlignment = Syncfusion.DocIO.DLS.HorizontalAlignment.Center;
                row1.Cells[2].CellFormat.VerticalAlignment = Syncfusion.DocIO.DLS.VerticalAlignment.Middle;
                row1.Cells[2].CellFormat.Borders.BorderType = Syncfusion.DocIO.DLS.BorderStyle.Single;
                row1.Cells[2].CellFormat.BackColor = Color.FromArgb(217, 223, 239);
                sno++;
                row1 = table.AddRow(false);

                //Writing SNO to the table with formatting text.
                paragraph = (IWParagraph)row1.Cells[0].AddParagraph();
                paragraph.ParagraphFormat.HorizontalAlignment = Syncfusion.DocIO.DLS.HorizontalAlignment.Center;
                text = paragraph.AppendText(sno.ToString());
                text.CharacterFormat.Bold = true;
                text.CharacterFormat.FontSize = 10f;
                row1.Cells[0].CellFormat.VerticalAlignment = Syncfusion.DocIO.DLS.VerticalAlignment.Middle;
                row1.Cells[0].CellFormat.Borders.BorderType = Syncfusion.DocIO.DLS.BorderStyle.Single;
                row1.Cells[0].CellFormat.BackColor = Color.FromArgb(217, 223, 239);
                //Writing Product Name to the table with Formatting.
                paragraph = (IWParagraph)row1.Cells[1].AddParagraph();
                paragraph.ParagraphFormat.HorizontalAlignment = Syncfusion.DocIO.DLS.HorizontalAlignment.Center;
                text = paragraph.AppendText("Grape Juice");
                text.CharacterFormat.Bold = true;
                text.CharacterFormat.FontSize = 10f;
                text.CharacterFormat.TextColor = Color.FromArgb(50, 65, 124);
                row1.Cells[1].CellFormat.VerticalAlignment = Syncfusion.DocIO.DLS.VerticalAlignment.Middle;
                row1.Cells[1].CellFormat.Borders.BorderType = Syncfusion.DocIO.DLS.BorderStyle.Single;
                row1.Cells[1].CellFormat.BackColor = Color.FromArgb(217, 223, 239);

                //Writing Product Images to the Table.
                paragraph = (IWParagraph)row1.Cells[2].AddParagraph();
                paragraph.AppendPicture(Image.FromFile(dataPath + "Grape Juice.png"));
                paragraph.ParagraphFormat.HorizontalAlignment = Syncfusion.DocIO.DLS.HorizontalAlignment.Center;
                row1.Cells[2].CellFormat.VerticalAlignment = Syncfusion.DocIO.DLS.VerticalAlignment.Middle;
                row1.Cells[2].CellFormat.Borders.BorderType = Syncfusion.DocIO.DLS.BorderStyle.Single;
                row1.Cells[2].CellFormat.BackColor = Color.FromArgb(217, 223, 239);
                sno++;
                row1 = table.AddRow(false);

                //Writing SNO to the table with formatting text.
                paragraph = (IWParagraph)row1.Cells[0].AddParagraph();
                paragraph.ParagraphFormat.HorizontalAlignment = Syncfusion.DocIO.DLS.HorizontalAlignment.Center;
                text = paragraph.AppendText(sno.ToString());
                text.CharacterFormat.Bold = true;
                text.CharacterFormat.FontSize = 10f;
                row1.Cells[0].CellFormat.VerticalAlignment = Syncfusion.DocIO.DLS.VerticalAlignment.Middle;
                row1.Cells[0].CellFormat.Borders.BorderType = Syncfusion.DocIO.DLS.BorderStyle.Single;
                row1.Cells[0].CellFormat.BackColor = Color.FromArgb(217, 223, 239);
                //Writing Product Name to the table with Formatting.
                paragraph = (IWParagraph)row1.Cells[1].AddParagraph();
                paragraph.ParagraphFormat.HorizontalAlignment = Syncfusion.DocIO.DLS.HorizontalAlignment.Center;
                text = paragraph.AppendText("Hot Soup");
                text.CharacterFormat.Bold = true;
                text.CharacterFormat.FontSize = 10f;
                text.CharacterFormat.TextColor = Color.FromArgb(50, 65, 124);
                row1.Cells[1].CellFormat.VerticalAlignment = Syncfusion.DocIO.DLS.VerticalAlignment.Middle;
                row1.Cells[1].CellFormat.Borders.BorderType = Syncfusion.DocIO.DLS.BorderStyle.Single;
                row1.Cells[1].CellFormat.BackColor = Color.FromArgb(217, 223, 239);

                //Writing Product Images to the Table.
                paragraph = (IWParagraph)row1.Cells[2].AddParagraph();
                paragraph.AppendPicture(Image.FromFile(dataPath + "Hot Soup.png"));
                paragraph.ParagraphFormat.HorizontalAlignment = Syncfusion.DocIO.DLS.HorizontalAlignment.Center;
                row1.Cells[2].CellFormat.VerticalAlignment = Syncfusion.DocIO.DLS.VerticalAlignment.Middle;
                row1.Cells[2].CellFormat.Borders.BorderType = Syncfusion.DocIO.DLS.BorderStyle.Single;
                row1.Cells[2].CellFormat.BackColor = Color.FromArgb(217, 223, 239);
                sno++;
                #endregion Table with Images
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
        #endregion
    }
}

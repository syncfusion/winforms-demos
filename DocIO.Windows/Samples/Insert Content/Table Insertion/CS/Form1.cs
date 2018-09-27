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
using System.Data;

using Syncfusion.DocIO;
using Syncfusion.DocIO.DLS;
using Syncfusion.Windows.Forms;
using Syncfusion.Windows.Forms.Tools;
using System.Data.SqlServerCe;
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
        #region Private Members

        private ToolTip toolTip1;
        private Label label2;
        private ButtonAdv button1;
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
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new Syncfusion.Windows.Forms.ButtonAdv();
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
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(0, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(363, 58);
            this.label2.TabIndex = 73;
            this.label2.Text = "Click the button to view the generated Word document or PDF. Please note that Microsoft Word Viewer or Microsoft Word is required to view the resultant Word document and PDF viewer is required to view the resultant PDF.";
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
            this.button1.Location = new System.Drawing.Point(245, 173);
            this.button1.Name = "button1";
            this.button1.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Managed;
            this.button1.Size = new System.Drawing.Size(108, 23);
            this.button1.TabIndex = 71;
            this.button1.Text = "Generate";
            this.button1.UseVisualStyle = true;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
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
            this.groupBox1.Location = new System.Drawing.Point(12, 156);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(209, 45);
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
            this.wordDocxRadioBtn.Location = new System.Drawing.Point(80, 20);
            this.wordDocxRadioBtn.MetroColor = System.Drawing.Color.Empty;
            this.wordDocxRadioBtn.Name = "wordDocxRadioBtn";
            this.wordDocxRadioBtn.Size = new System.Drawing.Size(53, 20);
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
            this.wordDocRadioBtn.Location = new System.Drawing.Point(6, 20);
            this.wordDocRadioBtn.MetroColor = System.Drawing.Color.Empty;
            this.wordDocRadioBtn.Name = "wordDocRadioBtn";
            this.wordDocRadioBtn.Size = new System.Drawing.Size(47, 20);
            this.wordDocRadioBtn.TabIndex = 44;
            this.wordDocRadioBtn.Text = "DOC";
            this.wordDocRadioBtn.ThemesEnabled = true;
            // 
            // pdfRadioBtn
            // 
            this.pdfRadioBtn.BeforeTouchSize = new System.Drawing.Size(43, 20);
            this.pdfRadioBtn.Border3DStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.pdfRadioBtn.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.pdfRadioBtn.GradientEnd = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.pdfRadioBtn.GradientStart = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.pdfRadioBtn.Location = new System.Drawing.Point(166, 20);
            this.pdfRadioBtn.MetroColor = System.Drawing.Color.Empty;
            this.pdfRadioBtn.Name = "pdfRadioBtn";
            this.pdfRadioBtn.Size = new System.Drawing.Size(43, 20);
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
            this.Text = "Table Insertion";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.wordDocxRadioBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wordDocRadioBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pdfRadioBtn)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion

        #region Button_Click Event
        private void button1_Click_1(object sender, System.EventArgs e)
        {
            // Get Template document and database path.
            string dataPath = Application.StartupPath + @"..\..\..\..\..\..\..\..\Common\Data\";

            try
            {

                //SDF the database and get the NorthWind
                AppDomain.CurrentDomain.SetData("SQLServerCompactEditionUnderWebHosting", true);
                DataTable table = new DataTable();
                SqlCeConnection conn = new SqlCeConnection();
                if (conn.ServerVersion.StartsWith("3.5"))
					 conn.ConnectionString = "Data Source = " + dataPath + "NorthwindIO_3.5.sdf";
				else
					 conn.ConnectionString = "Data Source = " + dataPath + "NorthwindIO.sdf";
                conn.Open();
                SqlCeDataAdapter adapter = new SqlCeDataAdapter("Select CustomerID,CompanyName,ContactName,Address,Country,Phone from Customers", conn);
                adapter.Fill(table);
                adapter.Dispose();
                conn.Close();

                // Creating a new document.
                WordDocument document = new WordDocument();
                // Adding a new section to the document.
                IWSection section = document.AddSection();
               
                IWParagraph paragraph = section.AddParagraph();
                paragraph.ParagraphFormat.BeforeSpacing = 20f;
                //Format the heading.
                IWTextRange text = paragraph.AppendText("Northwind Report");
                text.CharacterFormat.Bold = true;
                text.CharacterFormat.FontName = "Cambria";
                text.CharacterFormat.FontSize = 14.0f;
                text.CharacterFormat.TextColor = Color.DarkBlue;
                paragraph.ParagraphFormat.HorizontalAlignment = Syncfusion.DocIO.DLS.HorizontalAlignment.Center;

                paragraph = section.AddParagraph();
                paragraph.ParagraphFormat.BeforeSpacing = 18f;

                //Create a new table
                WTextBody textBody = section.Body;
                IWTable docTable = textBody.AddTable();

                //Set the format for rows
                RowFormat format = new RowFormat();
                format.Borders.BorderType = Syncfusion.DocIO.DLS.BorderStyle.Single;
                format.Borders.LineWidth = 1.0F;
                format.Borders.Color = Color.Black;

                //Initialize number of rows and cloumns.
                docTable.ResetCells(table.Rows.Count + 1, table.Columns.Count, format, 84);

                //Repeat the header.
                docTable.Rows[0].IsHeader = true;

                string colName;

                //Format the header rows
                for (int c = 0; c <= table.Columns.Count - 1; c++)
                {

                    string[] Cols = table.Columns[c].ColumnName.Split('|');
                    colName = Cols[Cols.Length - 1];
                    IWTextRange theadertext = docTable.Rows[0].Cells[c].AddParagraph().AppendText(colName);
                    theadertext.CharacterFormat.FontSize = 12f;
                    theadertext.CharacterFormat.Bold = true;
                    theadertext.CharacterFormat.TextColor = Color.White;
                    docTable.Rows[0].Cells[c].CellFormat.BackColor = Color.FromArgb(33, 67, 126);
                    docTable.Rows[0].Cells[c].CellFormat.Borders.Color = Color.Black;
                    docTable.Rows[0].Cells[c].CellFormat.Borders.BorderType = Syncfusion.DocIO.DLS.BorderStyle.Single;
                    docTable.Rows[0].Cells[c].CellFormat.Borders.LineWidth = 1.0f;

                    docTable.Rows[0].Cells[c].CellFormat.VerticalAlignment = Syncfusion.DocIO.DLS.VerticalAlignment.Middle;

                }

                //Format the table body rows
                for (int r = 0; r <= table.Rows.Count - 1; r++)
                {
                    for (int c = 0; c <= table.Columns.Count - 1; c++)
                    {
                        string Value = table.Rows[r][c].ToString();
                        IWTextRange theadertext = docTable.Rows[r + 1].Cells[c].AddParagraph().AppendText(Value);
                        theadertext.CharacterFormat.FontSize = 10;

                        docTable.Rows[r + 1].Cells[c].CellFormat.BackColor = ((r & 1) == 0) ? Color.FromArgb(237, 240, 246) : Color.FromArgb(192, 201, 219);

                        docTable.Rows[r + 1].Cells[c].CellFormat.Borders.Color = Color.Black;
                        docTable.Rows[r + 1].Cells[c].CellFormat.Borders.BorderType = Syncfusion.DocIO.DLS.BorderStyle.Single;
                        docTable.Rows[r + 1].Cells[c].CellFormat.Borders.LineWidth = 0.5f;
                        docTable.Rows[r + 1].Cells[c].CellFormat.VerticalAlignment =Syncfusion.DocIO.DLS.VerticalAlignment.Middle;
                    }
                }

                // Add a footer paragraph text to the document.
                WParagraph footerPar = new WParagraph(document);
                // Add text.
                footerPar.AppendText("Copyright Syncfusion Inc. 2001 - 2017");
                // Add page and Number of pages field to the document.
                footerPar.AppendText("			Page ");
                footerPar.AppendField("Page", Syncfusion.DocIO.FieldType.FieldPage);

                section.HeadersFooters.Footer.Paragraphs.Add(footerPar);

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
                // Shows the Message box with Exception message, if an exception throws.
                MessageBoxAdv.Show(Ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
            }
        }
        #endregion

    }
}

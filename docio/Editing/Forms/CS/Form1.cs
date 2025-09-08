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
        private ButtonAdv btnFill;
        private PictureBox pictureBox1;
        private ToolTip toolTip1;
        private Label label2;
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
            this.btnFill = new Syncfusion.Windows.Forms.ButtonAdv();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label2 = new System.Windows.Forms.Label();
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
            this.button1.Location = new System.Drawing.Point(245, 152);
            this.button1.Name = "button1";
            this.button1.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Managed;
            this.button1.Size = new System.Drawing.Size(108, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Create Form";
            this.button1.UseVisualStyle = true;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnFill
            // 
            this.btnFill.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFill.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.btnFill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218)))));
            this.btnFill.BeforeTouchSize = new System.Drawing.Size(108, 23);
            this.btnFill.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.Dashed;
            this.btnFill.ComboEditBackColor = System.Drawing.Color.Silver;
            this.btnFill.Enabled = false;
            this.btnFill.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFill.ForeColor = System.Drawing.Color.White;
            this.btnFill.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFill.IsBackStageButton = false;
            this.btnFill.KeepFocusRectangle = false;
            this.btnFill.Location = new System.Drawing.Point(245, 184);
            this.btnFill.Name = "btnFill";
            this.btnFill.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Managed;
            this.btnFill.Size = new System.Drawing.Size(108, 23);
            this.btnFill.TabIndex = 2;
            this.btnFill.Text = "Fill Form";
            this.btnFill.UseVisualStyle = true;
            this.btnFill.UseVisualStyleBackColor = false;
            this.btnFill.Click += new System.EventHandler(this.btnFill_Click);
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
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(0, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(363, 64);
            this.label2.TabIndex = 74;
            this.label2.Text = "Click the button to view the generated Word document or PDF. Please note that Microsoft Word Viewer or Microsoft Word is required to view the resultant Word document and PDF viewer is required to view the resultant PDF.";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.wordDocxRadioBtn);
            this.groupBox1.Controls.Add(this.wordDocRadioBtn);
            this.groupBox1.Controls.Add(this.pdfRadioBtn);
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 152);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(209, 44);
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
            this.wordDocxRadioBtn.Location = new System.Drawing.Point(83, 18);
            this.wordDocxRadioBtn.MetroColor = System.Drawing.Color.Empty;
            this.wordDocxRadioBtn.Name = "wordDocxRadioBtn";
            this.wordDocxRadioBtn.Size = new System.Drawing.Size(54, 20);
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
            this.wordDocRadioBtn.Location = new System.Drawing.Point(6, 18);
            this.wordDocRadioBtn.MetroColor = System.Drawing.Color.Empty;
            this.wordDocRadioBtn.Name = "wordDocRadioBtn";
            this.wordDocRadioBtn.Size = new System.Drawing.Size(46, 20);
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
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218)))));
            this.ClientSize = new System.Drawing.Size(365, 219);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnFill);
            this.DropShadow = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Forms";
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
            Application.Run(new Form1());
        }

        #region Create Form fields
        private void button1_Click(object sender, System.EventArgs e)
        {
            try
            {
                // Create a new document.
                WordDocument document = new WordDocument();

                // Adding a new section to the document.
                IWSection section = document.AddSection();

                // Adding a new paragraph to the section.
                IWParagraph paragraph = section.AddParagraph();


                #region Document formatting
                //Set background color.
                document.Background.Gradient.Color1 = Color.FromArgb(232, 232, 232);
                document.Background.Gradient.Color2 = Color.FromArgb(255, 255, 255);
                document.Background.Type = BackgroundType.Gradient;
                document.Background.Gradient.ShadingStyle = GradientShadingStyle.Horizontal;
                document.Background.Gradient.ShadingVariant = GradientShadingVariant.ShadingDown;

                section.PageSetup.Margins.All = 72f;
                section.PageSetup.PageSize = new SizeF(612, 792);

                #endregion

                #region Title Section
                IWTable table = section.Body.AddTable();
                table.ResetCells(1, 2);

                WTableRow row = table.Rows[0];
                row.Height = 25f;

                IWParagraph cellPara = row.Cells[0].AddParagraph();
#if NETCORE
                Image img = Image.FromFile(@"..\..\..\..\..\..\..\common\images\DocIO\Image.jpg");
#else
                Image img = Image.FromFile(@"..\..\..\..\..\..\common\images\DocIO\Image.jpg");
#endif                
                IWPicture pic = cellPara.AppendPicture(img);
                pic.Height = 80;
                pic.Width = 180;

                cellPara = row.Cells[1].AddParagraph();
                row.Cells[1].CellFormat.VerticalAlignment = Syncfusion.DocIO.DLS.VerticalAlignment.Middle;
                row.Cells[1].CellFormat.BackColor = Color.FromArgb(173, 215, 255);
                IWTextRange txt = cellPara.AppendText("Job Application Form");
                cellPara.ParagraphFormat.HorizontalAlignment = Syncfusion.DocIO.DLS.HorizontalAlignment.Center;
                txt.CharacterFormat.Bold = true;
                txt.CharacterFormat.FontName = "Arial";
                txt.CharacterFormat.FontSize = 18f;

                row.Cells[0].Width = 200;
                row.Cells[1].Width = 300;
                row.Cells[1].CellFormat.Borders.BorderType = Syncfusion.DocIO.DLS.BorderStyle.Hairline;
                #endregion

                section.AddParagraph();

                #region General Information
                table = section.Body.AddTable();
                table.TableFormat.Paddings.All = 5.4f;
                table.ResetCells(2, 1);
                row = table.Rows[0];
                row.Height = 20;
                row.Cells[0].Width = 500;
                cellPara = row.Cells[0].AddParagraph();
                row.Cells[0].CellFormat.Borders.BorderType = Syncfusion.DocIO.DLS.BorderStyle.Thick;
                row.Cells[0].CellFormat.Borders.Color = Color.FromArgb(155, 205, 255);
                row.Cells[0].CellFormat.BackColor = Color.FromArgb(198, 227, 255);
                row.Cells[0].CellFormat.VerticalAlignment = Syncfusion.DocIO.DLS.VerticalAlignment.Middle;
                txt = cellPara.AppendText(" General Information");
                txt.CharacterFormat.FontName = "Arial";
                txt.CharacterFormat.Bold = true;
                txt.CharacterFormat.FontSize = 11f;

                row = table.Rows[1];
                cellPara = row.Cells[0].AddParagraph();
                row.Cells[0].Width = 500;
                row.Cells[0].CellFormat.Borders.BorderType = Syncfusion.DocIO.DLS.BorderStyle.Hairline;
                row.Cells[0].CellFormat.Borders.Color = Color.FromArgb(155, 205, 255);
                row.Cells[0].CellFormat.BackColor = Color.FromArgb(222, 239, 255);

                txt = cellPara.AppendText("\n Full Name:\t\t\t\t");
                txt.CharacterFormat.FontName = "Arial";
                txt.CharacterFormat.FontSize = 11f;
                WTextFormField txtField = cellPara.AppendTextFormField(null);
                txtField.TextRange.CharacterFormat.TextColor = Color.MidnightBlue;
                txtField.TextRange.CharacterFormat.FontName = "Arial";
                txtField.TextRange.CharacterFormat.FontSize = 11f;

                txt = cellPara.AppendText("\n\n Birth Date:\t\t\t\t");
                txt.CharacterFormat.FontName = "Arial";
                txt.CharacterFormat.FontSize = 11f;
                txtField = cellPara.AppendTextFormField("BirthDayField", DateTime.Now.ToString("M/d/yyyy"));
                txtField.StringFormat = "M/d/yyyy";
                txtField.Type = TextFormFieldType.DateText;
                txtField.TextRange.CharacterFormat.TextColor = Color.MidnightBlue;
                txtField.TextRange.CharacterFormat.FontName = "Arial";
                txtField.TextRange.CharacterFormat.FontSize = 11f;
                txtField.CharacterFormat.TextColor = Color.MidnightBlue;
                txtField.CharacterFormat.FontName = "Arial";
                txtField.CharacterFormat.FontSize = 11f;

                txt = cellPara.AppendText("\n\n Address:\t\t\t\t");
                txt.CharacterFormat.FontName = "Arial";
                txt.CharacterFormat.FontSize = 11f;
                txtField = cellPara.AppendTextFormField(null);
                txtField.Type = TextFormFieldType.RegularText;
                txtField.TextRange.CharacterFormat.TextColor = Color.MidnightBlue;
                txtField.TextRange.CharacterFormat.FontName = "Arial";
                txtField.TextRange.CharacterFormat.FontSize = 11f;

                txt = cellPara.AppendText("\n\n Phone:\t\t\t\t");
                txt.CharacterFormat.FontName = "Arial";
                txt.CharacterFormat.FontSize = 11f;
                txtField = cellPara.AppendTextFormField(null);
                txtField.TextRange.CharacterFormat.TextColor = Color.MidnightBlue;
                txtField.TextRange.CharacterFormat.FontName = "Arial";
                txtField.TextRange.CharacterFormat.FontSize = 11f;

                txt = cellPara.AppendText("\n\n Email:\t\t\t\t\t");
                txt.CharacterFormat.FontName = "Arial";
                txt.CharacterFormat.FontSize = 11f;
                txtField = cellPara.AppendTextFormField(null);
                txtField.TextRange.CharacterFormat.TextColor = Color.MidnightBlue;
                txtField.TextRange.CharacterFormat.FontName = "Arial";
                txtField.TextRange.CharacterFormat.FontSize = 11f;
                cellPara.AppendText("\n");
                #endregion

                section.AddParagraph();

                #region Educational Qualification
                table = section.Body.AddTable();
                table.TableFormat.Paddings.All = 5.4f;
                table.ResetCells(2, 1);
                row = table.Rows[0];
                row.Height = 20;
                row.Cells[0].Width = 500;
                cellPara = row.Cells[0].AddParagraph();
                row.Cells[0].CellFormat.Borders.BorderType = Syncfusion.DocIO.DLS.BorderStyle.Thick;
                row.Cells[0].CellFormat.Borders.Color = Color.FromArgb(155, 205, 255);
                row.Cells[0].CellFormat.BackColor = Color.FromArgb(198, 227, 255);
                row.Cells[0].CellFormat.VerticalAlignment = Syncfusion.DocIO.DLS.VerticalAlignment.Middle;
                txt = cellPara.AppendText(" Educational Qualification");
                txt.CharacterFormat.FontName = "Arial";
                txt.CharacterFormat.Bold = true;
                txt.CharacterFormat.FontSize = 11f;

                row = table.Rows[1];
                cellPara = row.Cells[0].AddParagraph();
                row.Cells[0].Width = 500;
                row.Cells[0].CellFormat.Borders.BorderType = Syncfusion.DocIO.DLS.BorderStyle.Hairline;
                row.Cells[0].CellFormat.Borders.Color = Color.FromArgb(155, 205, 255);
                row.Cells[0].CellFormat.BackColor = Color.FromArgb(222, 239, 255);

                txt = cellPara.AppendText("\n Type:\t\t\t\t\t");
                txt.CharacterFormat.FontName = "Arial";
                txt.CharacterFormat.FontSize = 11f;
                WDropDownFormField dropField = cellPara.AppendDropDownFormField();
                dropField.DropDownItems.Add("Higher");
                dropField.DropDownItems.Add("Vocational");
                dropField.DropDownItems.Add("Universal");
                dropField.CharacterFormat.TextColor = Color.MidnightBlue;
                dropField.CharacterFormat.FontName = "Arial";
                dropField.CharacterFormat.FontSize = 11f;

                txt = cellPara.AppendText("\n\n Institution:\t\t\t\t");
                txt.CharacterFormat.FontName = "Arial";
                txt.CharacterFormat.FontSize = 11f;
                txtField = cellPara.AppendTextFormField(null);
                txtField.TextRange.CharacterFormat.TextColor = Color.MidnightBlue;
                txtField.TextRange.CharacterFormat.FontName = "Arial";
                txtField.CharacterFormat.FontSize = 11f;

                txt = cellPara.AppendText("\n\n Programming Languages:");
                txt.CharacterFormat.FontName = "Arial";
                txt.CharacterFormat.FontSize = 11f;
                txt = cellPara.AppendText("\n\n\t C#:\t\t\t\t");
                txt.CharacterFormat.FontName = "Arial";
                txt.CharacterFormat.FontSize = 9f;
                dropField = cellPara.AppendDropDownFormField();
                dropField.DropDownItems.Add("Perfect");
                dropField.DropDownItems.Add("Good");
                dropField.DropDownItems.Add("Excellent");
                dropField.CharacterFormat.TextColor = Color.MidnightBlue;
                dropField.CharacterFormat.FontName = "Arial";
                dropField.CharacterFormat.FontSize = 11f;

                txt = cellPara.AppendText("\n\n\t VB:\t\t\t\t");
                txt.CharacterFormat.FontName = "Arial";
                txt.CharacterFormat.FontSize = 9f;
                dropField = cellPara.AppendDropDownFormField();
                dropField.DropDownItems.Add("Perfect");
                dropField.DropDownItems.Add("Good");
                dropField.DropDownItems.Add("Excellent");
                dropField.CharacterFormat.TextColor = Color.MidnightBlue;
                dropField.CharacterFormat.FontName = "Arial";
                dropField.CharacterFormat.FontSize = 11f;
                #endregion

                btnFill.Enabled = true;

                //Protect document
                document.ProtectionType = ProtectionType.AllowOnlyFormFields;
                document.Save("Sample.doc", FormatType.Doc);
                //Save as doc format
                if (wordDocRadioBtn.Checked)
                {
                    //Saving the document to disk.
                    document.Save("Sample.doc");

                    //Message box confirmation to view the created document.
                    if (MessageBoxAdv.Show("Do you want to view the generated Word document?", "Document has been created", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        //Launching the MS Word file using the default Application.[MS Word Or Free WordViewer]
#if NETCORE
                        System.Diagnostics.Process process = new System.Diagnostics.Process();
                        process.StartInfo = new System.Diagnostics.ProcessStartInfo("Sample.doc") { UseShellExecute = true };
                        process.Start();
#else                       
                        System.Diagnostics.Process.Start("Sample.doc");
#endif
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
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }
        #endregion

        #region Fill form fields
        private void btnFill_Click(object sender, EventArgs e)
        {
            try
            {
                // Create a new document.
                WordDocument document = new WordDocument("Sample.doc");
                IWSection sec = document.LastSection;
                WTextFormField textFF;
                WDropDownFormField dropFF;

                //Access the text field
                textFF = sec.Body.FormFields[0] as WTextFormField;

                //Fill value for the textfield
                textFF.TextRange.Text = "John";

                //Access the form field with feild name
                textFF = sec.Body.FormFields["BirthDayField"] as WTextFormField;
                textFF.TextRange.Text = "5.13.1980";

                textFF = sec.Body.FormFields[2] as WTextFormField;
                textFF.TextRange.Text = "221b Baker Street";

                textFF = sec.Body.FormFields[3] as WTextFormField;
                textFF.TextRange.Text = "(206)555-3412";

                textFF = sec.Body.FormFields[4] as WTextFormField;
                textFF.TextRange.Text = "John@company.com";

                dropFF = sec.Body.FormFields[5] as WDropDownFormField;

                //Set the value
                dropFF.DropDownSelectedIndex = 1;

                textFF = sec.Body.FormFields[6] as WTextFormField;
                textFF.TextRange.Text = "Michigan University";

                dropFF = sec.Body.FormFields[7] as WDropDownFormField;
                dropFF.DropDownSelectedIndex = 1;

                dropFF = sec.Body.FormFields[8] as WDropDownFormField;
                dropFF.DropDownSelectedIndex = 2;

                //Allow only to fill the form.
                document.ProtectionType = ProtectionType.AllowOnlyFormFields;

                //Save as doc format
                if (wordDocRadioBtn.Checked)
                {
                    //Saving the document to disk.
                    document.Save("Sample.doc");

                    //Message box confirmation to view the created document.
                    if (MessageBoxAdv.Show("Do you want to view the generated Word document?", "Document has been created", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        //Launching the MS Word file using the default Application.[MS Word Or Free WordViewer]
#if NETCORE
                        System.Diagnostics.Process process = new System.Diagnostics.Process();
                        process.StartInfo = new System.Diagnostics.ProcessStartInfo("Sample.doc") { UseShellExecute = true };
                        process.Start();
#else                       
                        System.Diagnostics.Process.Start("Sample.doc");
#endif
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
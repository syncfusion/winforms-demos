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

        private ToolTip toolTip1;
        private ButtonAdv buttonAdv1;
        private PictureBox pictureBox1;
        private Label label2;
        private GroupBox groupBox1;
        private RadioButtonAdv wordDocxRadioBtn;
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
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.buttonAdv1 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.wordDocxRadioBtn = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
            this.pdfRadioBtn = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wordDocxRadioBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pdfRadioBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAdv1
            // 
            this.buttonAdv1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAdv1.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.buttonAdv1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218)))));
            this.buttonAdv1.BeforeTouchSize = new System.Drawing.Size(108, 23);
            this.buttonAdv1.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.Dashed;
            this.buttonAdv1.ComboEditBackColor = System.Drawing.Color.Silver;
            this.buttonAdv1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdv1.ForeColor = System.Drawing.Color.White;
            this.buttonAdv1.IsBackStageButton = false;
            this.buttonAdv1.KeepFocusRectangle = false;
            this.buttonAdv1.Location = new System.Drawing.Point(245, 164);
            this.buttonAdv1.Name = "buttonAdv1";
            this.buttonAdv1.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Managed;
            this.buttonAdv1.Size = new System.Drawing.Size(108, 23);
            this.buttonAdv1.TabIndex = 62;
            this.buttonAdv1.Text = "Generate";
            this.buttonAdv1.UseVisualStyle = true;
            this.buttonAdv1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(365, 82);
            this.pictureBox1.TabIndex = 60;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(0, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(363, 61);
            this.label2.TabIndex = 68;
            this.label2.Text = "Click the button to view the generated Word document or PDF. Please note that Microsoft Word Viewer or Microsoft Word is required to view the resultant Word document and PDF viewer is required to view the resultant PDF.";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.wordDocxRadioBtn);
            this.groupBox1.Controls.Add(this.pdfRadioBtn);
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 149);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(209, 44);
            this.groupBox1.TabIndex = 103;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Save As";
            // 
            // worddocxRadioBtn
            // 
            this.wordDocxRadioBtn.BeforeTouchSize = new System.Drawing.Size(56, 20);
            this.wordDocxRadioBtn.Border3DStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.wordDocxRadioBtn.Checked = true;
            this.wordDocxRadioBtn.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wordDocxRadioBtn.GradientEnd = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.wordDocxRadioBtn.GradientStart = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.wordDocxRadioBtn.Location = new System.Drawing.Point(29, 18);
            this.wordDocxRadioBtn.MetroColor = System.Drawing.Color.Empty;
            this.wordDocxRadioBtn.Name = "wordDocxRadioBtn";
            this.wordDocxRadioBtn.Size = new System.Drawing.Size(56, 20);
            this.wordDocxRadioBtn.TabIndex = 103;
            this.wordDocxRadioBtn.Text = "DOCX";
            this.wordDocxRadioBtn.ThemesEnabled = true;
            // 
            // pdfRadioBtn
            // 
            this.pdfRadioBtn.BeforeTouchSize = new System.Drawing.Size(45, 20);
            this.pdfRadioBtn.Border3DStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.pdfRadioBtn.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.pdfRadioBtn.GradientEnd = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.pdfRadioBtn.GradientStart = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.pdfRadioBtn.Location = new System.Drawing.Point(137, 18);
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
            this.ClientSize = new System.Drawing.Size(365, 235);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonAdv1);
            this.Controls.Add(this.pictureBox1);
            this.DropShadow = true;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AutoShapes";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.wordDocxRadioBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pdfRadioBtn)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion

        #region Button_Click Event
        private void button1_Click(object sender, System.EventArgs e)
        {
            try
            {
                //Initialize Word document
                WordDocument doc = new WordDocument();
                //Ensure Minimum
                doc.EnsureMinimal();
                //Append AutoShape
                Shape shape = doc.LastParagraph.AppendShape(AutoShapeType.RoundedRectangle, 130, 45);
                //Set horizontal alignment
                shape.HorizontalAlignment = ShapeHorizontalAlignment.Center;
                //Set horizontal origin
                shape.HorizontalOrigin = HorizontalOrigin.Page;
                //Set vertical origin
                shape.VerticalOrigin = VerticalOrigin.Page;
                //Set vertical position
                shape.VerticalPosition = 50;
                //Set AllowOverlap to true for overlapping shapes
                shape.WrapFormat.AllowOverlap = true;
                //Set Fill Color
                shape.FillFormat.Color = Color.Blue;
                //Set Content vertical alignment
                shape.TextFrame.TextVerticalAlignment = Syncfusion.DocIO.DLS.VerticalAlignment.Middle;
                //Add Texbody contents to Shape
                IWParagraph para = shape.TextBody.AddParagraph();
                para.ParagraphFormat.HorizontalAlignment = Syncfusion.DocIO.DLS.HorizontalAlignment.Center;
                IWTextRange textRange = para.AppendText("Requirement");
                textRange.CharacterFormat.Bold = true;
                textRange.CharacterFormat.TextColor = Color.White;
                textRange.CharacterFormat.FontSize = 12;
                textRange.CharacterFormat.FontName = "Verdana";

                shape = doc.LastParagraph.AppendShape(AutoShapeType.DownArrow, 45, 45);
                shape.HorizontalAlignment = ShapeHorizontalAlignment.Center;
                shape.HorizontalOrigin = HorizontalOrigin.Page;
                shape.VerticalOrigin = VerticalOrigin.Page;
                shape.VerticalPosition = 95;
                shape.WrapFormat.AllowOverlap = true;

                shape = doc.LastParagraph.AppendShape(AutoShapeType.RoundedRectangle, 130, 45);
                shape.HorizontalAlignment = ShapeHorizontalAlignment.Center;
                shape.HorizontalOrigin = HorizontalOrigin.Page;
                shape.VerticalOrigin = VerticalOrigin.Page;
                shape.VerticalPosition = 140;
                shape.WrapFormat.AllowOverlap = true;
                shape.FillFormat.Color = Color.Orange;
                shape.TextFrame.TextVerticalAlignment = Syncfusion.DocIO.DLS.VerticalAlignment.Middle;
                para = shape.TextBody.AddParagraph();
                para.ParagraphFormat.HorizontalAlignment = Syncfusion.DocIO.DLS.HorizontalAlignment.Center;
                textRange = para.AppendText("Design");
                textRange.CharacterFormat.Bold = true;
                textRange.CharacterFormat.TextColor = Color.White;
                textRange.CharacterFormat.FontSize = 12;
                textRange.CharacterFormat.FontName = "Verdana";

                shape = doc.LastParagraph.AppendShape(AutoShapeType.DownArrow, 45, 45);
                shape.HorizontalAlignment = ShapeHorizontalAlignment.Center;
                shape.HorizontalOrigin = HorizontalOrigin.Page;
                shape.VerticalOrigin = VerticalOrigin.Page;
                shape.VerticalPosition = 185;
                shape.WrapFormat.AllowOverlap = true;

                shape = doc.LastParagraph.AppendShape(AutoShapeType.RoundedRectangle, 130, 45);
                shape.HorizontalAlignment = ShapeHorizontalAlignment.Center;
                shape.HorizontalOrigin = HorizontalOrigin.Page;
                shape.VerticalOrigin = VerticalOrigin.Page;
                shape.VerticalPosition = 230;
                shape.WrapFormat.AllowOverlap = true;
                shape.FillFormat.Color = Color.Blue;
                shape.TextFrame.TextVerticalAlignment = Syncfusion.DocIO.DLS.VerticalAlignment.Middle;
                para = shape.TextBody.AddParagraph();
                para.ParagraphFormat.HorizontalAlignment = Syncfusion.DocIO.DLS.HorizontalAlignment.Center;
                textRange = para.AppendText("Execution");
                textRange.CharacterFormat.Bold = true;
                textRange.CharacterFormat.TextColor = Color.White;
                textRange.CharacterFormat.FontSize = 12;
                textRange.CharacterFormat.FontName = "Verdana";

                shape = doc.LastParagraph.AppendShape(AutoShapeType.DownArrow, 45, 45);
                shape.HorizontalAlignment = ShapeHorizontalAlignment.Center;
                shape.HorizontalOrigin = HorizontalOrigin.Page;
                shape.VerticalOrigin = VerticalOrigin.Page;
                shape.VerticalPosition = 275;
                shape.WrapFormat.AllowOverlap = true;

                shape = doc.LastParagraph.AppendShape(AutoShapeType.RoundedRectangle, 130, 45);
                shape.HorizontalAlignment = ShapeHorizontalAlignment.Center;
                shape.HorizontalOrigin = HorizontalOrigin.Page;
                shape.VerticalOrigin = VerticalOrigin.Page;
                shape.VerticalPosition = 320;
                shape.WrapFormat.AllowOverlap = true;
                shape.FillFormat.Color = Color.Violet;
                shape.TextFrame.TextVerticalAlignment = Syncfusion.DocIO.DLS.VerticalAlignment.Middle;
                para = shape.TextBody.AddParagraph();
                para.ParagraphFormat.HorizontalAlignment = Syncfusion.DocIO.DLS.HorizontalAlignment.Center;
                textRange = para.AppendText("Testing");
                textRange.CharacterFormat.Bold = true;
                textRange.CharacterFormat.TextColor = Color.White;
                textRange.CharacterFormat.FontSize = 12;
                textRange.CharacterFormat.FontName = "Verdana";

                shape = doc.LastParagraph.AppendShape(AutoShapeType.DownArrow, 45, 45);
                shape.HorizontalAlignment = ShapeHorizontalAlignment.Center;
                shape.HorizontalOrigin = HorizontalOrigin.Page;
                shape.VerticalOrigin = VerticalOrigin.Page;
                shape.VerticalPosition = 365;
                shape.WrapFormat.AllowOverlap = true;

                shape = doc.LastParagraph.AppendShape(AutoShapeType.RoundedRectangle, 130, 45);
                shape.HorizontalAlignment = ShapeHorizontalAlignment.Center;
                shape.HorizontalOrigin = HorizontalOrigin.Page;
                shape.VerticalOrigin = VerticalOrigin.Page;
                shape.VerticalPosition = 410;
                shape.WrapFormat.AllowOverlap = true;
                shape.FillFormat.Color = Color.PaleVioletRed;
                shape.TextFrame.TextVerticalAlignment = Syncfusion.DocIO.DLS.VerticalAlignment.Middle;
                para = shape.TextBody.AddParagraph();
                para.ParagraphFormat.HorizontalAlignment = Syncfusion.DocIO.DLS.HorizontalAlignment.Center;
                textRange = para.AppendText("Release");
                textRange.CharacterFormat.Bold = true;
                textRange.CharacterFormat.TextColor = Color.White;
                textRange.CharacterFormat.FontSize = 12;
                textRange.CharacterFormat.FontName = "Verdana";

                //Save as docx format
                if (wordDocxRadioBtn.Checked)
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
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }
        #endregion

    }
}


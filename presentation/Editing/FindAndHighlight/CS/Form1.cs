#region Copyright Syncfusion Inc. 2001-2024.
// Copyright Syncfusion Inc. 2001-2024. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Syncfusion.Presentation;
using System;
using System.Windows.Forms;
using System.IO;
using Syncfusion.Windows.Forms;
using Syncfusion.Licensing;
using System.Reflection;
using System.Text;
using Syncfusion.PresentationToPdfConverter;
using Syncfusion.Pdf;
using Syncfusion.Windows.Forms.Tools;
#if !SyncfusionFramework2_0 && !SyncfusionFramework3_5
using Syncfusion.OfficeChartToImageConverter;
#endif
namespace FindAndHighlight
{
    public class Form1 : MetroForm
    {
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBoxMatchCase;
        private System.Windows.Forms.CheckBox checkBoxMatchWord;
        private System.Windows.Forms.CheckBox checkBoxFirstOccurrence;
        private System.Windows.Forms.TextBox textBoxHighlight;
        private GroupBox groupBox1;
		private GroupBox groupBox2;
        private ButtonAdv buttonHighlight;
        private PictureBox pictureBox1;
        private ToolTip toolTip1;
        private GroupBox groupBox3;
        private Label label4;
        private RadioButtonAdv rbtnCreatePresentation;
        private RadioButtonAdv rbtnPresentationToPdf;
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
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
            this.label1 = new System.Windows.Forms.Label();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.checkBoxMatchCase = new System.Windows.Forms.CheckBox();
            this.checkBoxMatchWord = new System.Windows.Forms.CheckBox();
            this.checkBoxFirstOccurrence = new System.Windows.Forms.CheckBox();
            this.textBoxHighlight = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonHighlight = new Syncfusion.Windows.Forms.ButtonAdv();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.components = new System.ComponentModel.Container();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rbtnCreatePresentation = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
            this.rbtnPresentationToPdf = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rbtnCreatePresentation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbtnPresentationToPdf)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(2, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "Text to Highlight:";
            // 
            // textBoxHighlight
            // 
            this.textBoxHighlight.Enabled = true;
            this.textBoxHighlight.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxHighlight.Location = new System.Drawing.Point(92, 146);
            this.textBoxHighlight.Name = "textBoxHighlight";
            this.textBoxHighlight.Size = new System.Drawing.Size(224, 21);
            this.textBoxHighlight.TabIndex = 1;

            // 
            // checkBoxMatchCase
            // 
            this.checkBoxMatchCase.Enabled = true;
            this.checkBoxMatchCase.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.checkBoxMatchCase.Location = new System.Drawing.Point(6, 18);
            this.checkBoxMatchCase.Name = "checkBoxMatchCase";
            this.checkBoxMatchCase.Size = new System.Drawing.Size(104, 20);
            this.checkBoxMatchCase.TabIndex = 7;
            this.checkBoxMatchCase.Text = "Match &case";
            this.checkBoxMatchCase.CheckedChanged += new System.EventHandler(this.checkBoxMatchCase_CheckedChanged);
            // 
            // checkBoxMatchWord
            // 
            this.checkBoxMatchWord.Enabled = true;
            this.checkBoxMatchWord.Checked = true;
            this.checkBoxMatchWord.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.checkBoxMatchWord.Location = new System.Drawing.Point(110, 18);
            this.checkBoxMatchWord.Name = "checkBoxMatchWord";
            this.checkBoxMatchWord.Size = new System.Drawing.Size(117, 22);
            this.checkBoxMatchWord.TabIndex = 8;
            this.checkBoxMatchWord.Text = "Match &whole word";
            this.checkBoxMatchWord.CheckedChanged += new System.EventHandler(this.checkBoxMatchWord_CheckedChanged);
            // 
            // checkBoxFirstOccurrence
            // 
            this.checkBoxFirstOccurrence.Enabled = true;
            this.checkBoxFirstOccurrence.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.checkBoxFirstOccurrence.Location = new System.Drawing.Point(235, 18);
            this.checkBoxFirstOccurrence.Name = "checkBoxFirstOccurrence";
            this.checkBoxFirstOccurrence.Size = new System.Drawing.Size(117, 30);
            this.checkBoxFirstOccurrence.TabIndex = 8;
            this.checkBoxFirstOccurrence.Text = "Highlight only the first occurrence";
            this.checkBoxFirstOccurrence.CheckedChanged += new System.EventHandler(this.checkBoxFirstOccurrence_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBoxMatchWord);
            this.groupBox1.Controls.Add(this.checkBoxMatchCase);
            this.groupBox1.Controls.Add(this.checkBoxFirstOccurrence);
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(5, 200);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(400, 70);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search Options";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rbtnCreatePresentation);
            this.groupBox3.Controls.Add(this.rbtnPresentationToPdf);
            this.groupBox3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(5, 280);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(150, 48);
            this.groupBox3.TabIndex = 103;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Save As";
            // 
            // rbtnCreatePresentation
            // 
            this.rbtnCreatePresentation.BeforeTouchSize = new System.Drawing.Size(58, 20);
            this.rbtnCreatePresentation.Border3DStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.rbtnCreatePresentation.Checked = true;
            this.rbtnCreatePresentation.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnCreatePresentation.GradientEnd = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.rbtnCreatePresentation.GradientStart = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.rbtnCreatePresentation.Location = new System.Drawing.Point(6, 20);
            this.rbtnCreatePresentation.MetroColor = System.Drawing.Color.Empty;
            this.rbtnCreatePresentation.Name = "rbtnCreatePresentation";
            this.rbtnCreatePresentation.Size = new System.Drawing.Size(58, 20);
            this.rbtnCreatePresentation.TabIndex = 103;
            this.rbtnCreatePresentation.Text = "PPTX";
            this.rbtnCreatePresentation.ThemesEnabled = true;
            // 
            // rbtnPresentationToPdf
            // 
            this.rbtnPresentationToPdf.BeforeTouchSize = new System.Drawing.Size(48, 20);
            this.rbtnPresentationToPdf.Border3DStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.rbtnPresentationToPdf.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.rbtnPresentationToPdf.GradientEnd = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.rbtnPresentationToPdf.GradientStart = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.rbtnPresentationToPdf.Location = new System.Drawing.Point(82, 20);
            this.rbtnPresentationToPdf.MetroColor = System.Drawing.Color.Empty;
            this.rbtnPresentationToPdf.Name = "rbtnPresentationToPdf";
            this.rbtnPresentationToPdf.Size = new System.Drawing.Size(48, 20);
            this.rbtnPresentationToPdf.TabIndex = 45;
            this.rbtnPresentationToPdf.Text = "PDF";
            this.rbtnPresentationToPdf.ThemesEnabled = true;
            // 
            // buttonHighlight
            // 
            this.buttonHighlight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonHighlight.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.buttonHighlight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218)))));
            this.buttonHighlight.BeforeTouchSize = new System.Drawing.Size(108, 23);
            this.buttonHighlight.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.Dashed;
            this.buttonHighlight.ComboEditBackColor = System.Drawing.Color.Silver;
            this.buttonHighlight.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHighlight.ForeColor = System.Drawing.Color.White;
            this.buttonHighlight.IsBackStageButton = false;
            this.buttonHighlight.KeepFocusRectangle = false;
            this.buttonHighlight.Location = new System.Drawing.Point(270, 295);
            this.buttonHighlight.Name = "buttonHighlight";
            this.buttonHighlight.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Managed;
            this.buttonHighlight.Size = new System.Drawing.Size(110, 23);
            this.buttonHighlight.TabIndex = 14;
            this.buttonHighlight.Text = "Highlight";
            this.buttonHighlight.UseVisualStyle = true;
            this.buttonHighlight.UseVisualStyleBackColor = false;
            this.buttonHighlight.Click += new System.EventHandler(this.buttonHighlight_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-2, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(409, 82);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;

            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(0, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(401, 58);
            this.label4.TabIndex = 74;
            this.label4.Text = "Click the button to view the generated PowerPoint document or PDF file. Please note that a Microsoft PowerPoint viewer is required to view the resultant presentation document and a PDF viewer is required to view the resultant PDF.";
            // 
            // Form1
            // 
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218)))));
            this.CaptionFont = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.ClientSize = new System.Drawing.Size(405, 350);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonHighlight);
            this.Controls.Add(this.textBoxHighlight);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.DropShadow = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Find and Highlight";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rbtnCreatePresentation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbtnPresentationToPdf)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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

        bool matchCase, wholeWord, highlightFirstOccurrence;

        private void Form1_Load(object sender, System.EventArgs e)
        {
            // Initialize variables.
            matchCase = false;
            wholeWord = true;
            highlightFirstOccurrence = false;
            textBoxHighlight.Text = "product";

        }
        private void buttonHighlight_Click(object sender, System.EventArgs e)
        {
            if (textBoxHighlight.Text.Trim() == "")
            {
                MessageBoxAdv.Show("Please fill the find and hightlight text in the appropriate textbox.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            string input = "";
#if !NETCore
            input = Path.GetFullPath(@"..\..\..\..\..\..\common\Data\Presentation\FindAndHighlightInput.pptx");
#else
            input = Path.GetFullPath(@"..\..\..\..\..\..\..\common\Data\Presentation\FindAndHighlightInput.pptx");
#endif

            using (IPresentation presentation = Presentation.Open(input))
            {
                //Highlight only the first occurrence of the text
                if (highlightFirstOccurrence)
                {
                    //Finds the first occurrence of a particular text
                    ITextSelection textSelection = presentation.Find(textBoxHighlight.Text, matchCase, wholeWord);
                    if (textSelection != null)
                    {
                        //Gets the found text containing text parts
                        foreach (ITextPart textPart in textSelection.GetTextParts())
                        {
                            //Sets highlight color
                            textPart.Font.HighlightColor = ColorObject.Yellow;
                        }
                    }
                }
                else
                {
                    //Finds all the occurrences of a particular text
                    ITextSelection[] textSelections = presentation.FindAll(textBoxHighlight.Text, matchCase, wholeWord);
                    if (textSelections != null)
                    {
                        foreach (ITextSelection textSelection in textSelections)
                        {
                            //Gets the found text containing text parts
                            foreach (ITextPart textPart in textSelection.GetTextParts())
                            {
                                //Sets highlight color
                                textPart.Font.HighlightColor = ColorObject.Yellow;
                            }
                        }
                    }
                }
                if (rbtnCreatePresentation.Checked)
                {

                    //Saves the presentation
                    presentation.Save("FindAndHightlight.pptx");

                    if (MessageBox.Show("Do you want to view the generated Presentation?", "Presentation Created",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
#if !NETCore
                        System.Diagnostics.Process.Start("FindAndHightlight.pptx");
#else
                    System.Diagnostics.Process process = new System.Diagnostics.Process();
				    process.StartInfo = new System.Diagnostics.ProcessStartInfo("FindAndHightlight.pptx")
                    {
                        UseShellExecute = true
                    };
                    process.Start();
#endif
                    }
                }
                else if (rbtnPresentationToPdf.Checked)
                {
#if !NOCHARTTOIMAGE
                    presentation.ChartToImageConverter = new ChartToImageConverter();
#endif
                    PresentationToPdfConverterSettings settings = new PresentationToPdfConverterSettings();
                    using (PdfDocument pdfDocument = PresentationToPdfConverter.Convert(presentation, settings))
                    pdfDocument.Save("FindAndHightlight.pdf");
                    if (MessageBox.Show("Do you want to view the generated PDF document?", "PDF Created",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
#if !NETCore
                        System.Diagnostics.Process.Start("FindAndHightlight.pdf");
#else
                    System.Diagnostics.Process process = new System.Diagnostics.Process();
                    process.StartInfo = new System.Diagnostics.ProcessStartInfo("FindAndHightlight.pdf")
                    {
                        UseShellExecute = true
                    };
                    process.Start();
#endif
                        this.Close();
                    }
                }
            }

        }
        private void checkBoxMatchCase_CheckedChanged(object sender, System.EventArgs e)
        {
            if (checkBoxMatchCase.Checked)
                matchCase = true;
            else
                matchCase = false;
        }
        private void checkBoxMatchWord_CheckedChanged(object sender, System.EventArgs e)
        {
            if (checkBoxMatchWord.Checked)
                wholeWord = true;
            else
                wholeWord = false;
        }
        private void checkBoxFirstOccurrence_CheckedChanged(object sender, System.EventArgs e)
        {
            if (checkBoxFirstOccurrence.Checked)
                highlightFirstOccurrence = true;
            else
                highlightFirstOccurrence = false;
        }

    }
}

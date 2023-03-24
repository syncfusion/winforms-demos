#region Copyright Syncfusion Inc. 2001-2023.
// Copyright Syncfusion Inc. 2001-2023. All rights reserved.
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
#if !SyncfusionFramework2_0 && !SyncfusionFramework3_5
using Syncfusion.OfficeChartToImageConverter;
#endif
namespace FindAndReplace
{
    public class Form1 : MetroForm
    {
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxFileName;
        private System.Windows.Forms.TextBox textBoxFind;
        private System.Windows.Forms.TextBox textBoxReplace;
        private System.Windows.Forms.CheckBox checkBoxMatchCase;
        private System.Windows.Forms.CheckBox checkBoxMatchWord;
        private System.Windows.Forms.CheckBox checkBoxFirstOccurrence;
        private GroupBox groupBox1;
        private ButtonAdv button1;
        private ButtonAdv buttonReplace;
        private PictureBox pictureBox1;
        private ToolTip toolTip1;
        private GroupBox groupBox2;
        private Label label4;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxFileName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxFind = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxReplace = new System.Windows.Forms.TextBox();
            this.checkBoxMatchCase = new System.Windows.Forms.CheckBox();
            this.checkBoxMatchWord = new System.Windows.Forms.CheckBox();
            this.checkBoxFirstOccurrence = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.buttonReplace = new Syncfusion.Windows.Forms.ButtonAdv();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.components = new System.ComponentModel.Container();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.label1.Location = new System.Drawing.Point(2, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "&Look in          :  ";
            // 
            // textBoxFileName
            // 
            this.textBoxFileName.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFileName.Location = new System.Drawing.Point(92, 146);
            this.textBoxFileName.Name = "textBoxFileName";
            this.textBoxFileName.Size = new System.Drawing.Size(224, 21);
            this.textBoxFileName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(2, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Fi&nd what      :";
            // 
            // textBoxFind
            // 
            this.textBoxFind.Enabled = true;
            this.textBoxFind.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFind.Location = new System.Drawing.Point(92, 175);
            this.textBoxFind.Name = "textBoxFind";
            this.textBoxFind.Size = new System.Drawing.Size(224, 21);
            this.textBoxFind.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.label3.Location = new System.Drawing.Point(2, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Re&place with  : ";
            // 
            // textBoxReplace
            // 
            this.textBoxReplace.Enabled = true;
            this.textBoxReplace.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxReplace.Location = new System.Drawing.Point(92, 204);
            this.textBoxReplace.Name = "textBoxReplace";
            this.textBoxReplace.Size = new System.Drawing.Size(224, 21);
            this.textBoxReplace.TabIndex = 6;
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
            this.checkBoxFirstOccurrence.Size = new System.Drawing.Size(117, 22);
            this.checkBoxFirstOccurrence.TabIndex = 8;
            this.checkBoxFirstOccurrence.Text = "Replace only the first occurrence";
            this.checkBoxFirstOccurrence.CheckedChanged += new System.EventHandler(this.checkBoxFirstOccurrence_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBoxMatchWord);
            this.groupBox1.Controls.Add(this.checkBoxMatchCase);
            this.groupBox1.Controls.Add(this.checkBoxFirstOccurrence);
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(5, 267);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(400, 70);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search Options";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218)))));
            this.button1.BeforeTouchSize = new System.Drawing.Size(55, 24);
            this.button1.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.Dashed;
            this.button1.ComboEditBackColor = System.Drawing.Color.Silver;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.IsBackStageButton = false;
            this.button1.KeepFocusRectangle = false;
            this.button1.Location = new System.Drawing.Point(338, 146);
            this.button1.Name = "button1";
            this.button1.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Managed;
            this.button1.Size = new System.Drawing.Size(55, 24);
            this.button1.TabIndex = 13;
            this.button1.Text = "Browse";
            this.button1.UseVisualStyle = true;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.buttonBrowse_Click);
            // 
            // buttonReplace
            // 
            this.buttonReplace.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonReplace.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.buttonReplace.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218)))));
            this.buttonReplace.BeforeTouchSize = new System.Drawing.Size(108, 23);
            this.buttonReplace.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.Dashed;
            this.buttonReplace.ComboEditBackColor = System.Drawing.Color.Silver;
            this.buttonReplace.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReplace.ForeColor = System.Drawing.Color.White;
            this.buttonReplace.IsBackStageButton = false;
            this.buttonReplace.KeepFocusRectangle = false;
            this.buttonReplace.Location = new System.Drawing.Point(285, 349);
            this.buttonReplace.Name = "buttonReplace";
            this.buttonReplace.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Managed;
            this.buttonReplace.Size = new System.Drawing.Size(108, 23);
            this.buttonReplace.TabIndex = 14;
            this.buttonReplace.Text = "Replace";
            this.buttonReplace.UseVisualStyle = true;
            this.buttonReplace.UseVisualStyleBackColor = false;
            this.buttonReplace.Click += new System.EventHandler(this.buttonReplace_Click);
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
            this.label4.Text = "Click the button to view a PowerPoint presentation generated by .NET PowerPoint library. Please note that Microsoft PowerPoint viewer or its equivalent is required to view the resultant document.";
            // 
            // Form1
            // 
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218)))));
            this.CaptionFont = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.ClientSize = new System.Drawing.Size(405, 393);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonReplace);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxReplace);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxFind);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxFileName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.DropShadow = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Find and Replace";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
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

        bool matchCase, wholeWord, replaceFirstOccurrence;
        private string pptxFileName;

        private void Form1_Load(object sender, System.EventArgs e)
        {
            // Initialize variables.
            matchCase = false;
            wholeWord = false;
            replaceFirstOccurrence = false;
            textBoxFileName.Text = "Input Template.pptx";
            textBoxFind.Text = "product";
            textBoxReplace.Text = "Service";
#if !NETCore
            pptxFileName = Path.GetFullPath(@"..\..\..\..\..\..\common\Data\Presentation\Input Template.pptx");
#else
            pptxFileName= Path.GetFullPath(@"..\..\..\..\..\..\..\common\Data\Presentation\Input Template.pptx");
#endif

        }
        private void buttonBrowse_Click(object sender, System.EventArgs e)
        {
            // Create a openfile dialog box to open an existing word document.
            OpenFileDialog file = new OpenFileDialog();

            // set the file filter type as document.

#if !NETCore
            file.InitialDirectory = Path.GetFullPath(@"..\..\..\..\..\..\common\Data\Presentation\");
#else
            file.InitialDirectory = Path.GetFullPath(@"..\..\..\..\..\..\..\common\Data\Presentation\");
#endif
            file.Filter = "PowerPoint Presentations|*.pptx";

            // Show the open file dialog box.
            if (file.ShowDialog() == DialogResult.OK)
            {
                pptxFileName = file.FileName;
                textBoxFileName.Text = Path.GetFileName(pptxFileName);

                // Make controls enable state.
                textBoxFileName.Enabled = false;
                textBoxFind.Enabled = true;
                textBoxReplace.Enabled = true;
                checkBoxMatchCase.Enabled = true;
                checkBoxMatchWord.Enabled = true;
                checkBoxFirstOccurrence.Enabled = true;
                buttonReplace.Enabled = true;
            }
            
        }
        private void buttonReplace_Click(object sender, System.EventArgs e)
        {
            // Checking whether the find and replacement text boxes are filled.
            if (textBoxFileName.Text.Trim() == "")
            {
                MessageBoxAdv.Show("Browse a file to perform find and replace functionality", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (textBoxFind.Text.Trim() == "" && textBoxReplace.Text.Trim() == "")
            {
                MessageBoxAdv.Show("Please fill the find and replacement text in appropriate textboxes...", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (textBoxFind.Text.Trim() == "")
            {
                MessageBoxAdv.Show("Please fill the find text in the appropriate textbox.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (textBoxReplace.Text.Trim() == "")
            {
                MessageBoxAdv.Show("Please fill the replace text in the appropriate textbox.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }


            using (IPresentation presentation = Presentation.Open(pptxFileName))
            {
                //Replaces only the first occurrence of the text
                if (replaceFirstOccurrence)
                {
                    //Finds the first occurrence of a particular text
                    ITextSelection textSelection = presentation.Find(textBoxFind.Text, matchCase, wholeWord);
                    if (textSelection != null)
                    {
                        //Gets the found text as single text part
                        ITextPart textPart = textSelection.GetAsOneTextPart();
                        //Replace the text
                        textPart.Text = textBoxReplace.Text;
                    }
                }
                else
                {
                    //Finds all the occurrences of a particular text
                    ITextSelection[] textSelections = presentation.FindAll(textBoxFind.Text, matchCase, wholeWord);
                    if(textSelections != null)
                    {
                        foreach (ITextSelection textSelection in textSelections)
                        {
                            //Gets the found text as single text part
                            ITextPart textPart = textSelection.GetAsOneTextPart();
                            //Replace the text
                            textPart.Text = textBoxReplace.Text;
                        }
                    }
                }
                //Saves the presentation
                presentation.Save("FindAndReplace.pptx");
            }

            if (MessageBox.Show("Do you want to view the generated Presentation?", "Presentation Created",
                MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
#if !NETCore
                System.Diagnostics.Process.Start("FindAndReplace.pptx");
#else
                System.Diagnostics.Process process = new System.Diagnostics.Process();
                process.StartInfo = new System.Diagnostics.ProcessStartInfo("FindAndReplace.pptx")
                {
                    UseShellExecute = true
                };
                process.Start();
#endif
                this.Close();
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
                replaceFirstOccurrence = true;
            else
                replaceFirstOccurrence = false;
        }

    }
}

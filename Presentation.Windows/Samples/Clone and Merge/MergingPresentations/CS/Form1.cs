using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Text;
using System.IO;
using System.Windows.Forms;
using Syncfusion.Presentation;
using Syncfusion.Windows.Forms;
using Syncfusion.Licensing;
using System.Reflection;

namespace HelloWorld
{
    public partial class Form1 : MetroForm 
    {
        #region Private Members

        private System.Windows.Forms.Button btnGenerateDocument;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox txtFile;
        private TextBox txtFile1;
        private Button btnBrowse1;
        private Label label2;
        private Label label3;
        private RadioButton radioDestination;
        private RadioButton radioSource;

        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        #endregion

        # region Constructor
        public Form1()
        {
            //
            // Required for Windows Form Designer support
            //            
            InitializeComponent();
            this.MinimizeBox = true;
            Application.EnableVisualStyles();
            this.txtFile.Text = "Essential Presentation.pptx";
            this.txtFile.Tag = @"..\..\..\..\..\..\..\Common\Data\Presentation\Essential Presentation.pptx";
            this.txtFile1.Text = "MergeContent.pptx";
            this.txtFile1.Tag = @"..\..\..\..\..\..\..\Common\Data\Presentation\MergeContent.pptx";
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
            string licenseKeyFile = "..\\Common\\SyncfusionLicense.txt";
            for (int n = 0; n < 20; n++)
            {
                if (!System.IO.File.Exists(licenseKeyFile))
                {
                    licenseKeyFile = @"..\" + licenseKeyFile;
                    continue;
                }
                return File.ReadAllText(licenseKeyFile);
            }
            return string.Empty;
        }
        #endregion

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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGenerateDocument = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.txtFile = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.txtFile1 = new System.Windows.Forms.TextBox();
            this.btnBrowse1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.radioDestination = new System.Windows.Forms.RadioButton();
            this.radioSource = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(0, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(381, 97);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(366, 42);
            this.label1.TabIndex = 27;
            this.label1.Text = "Click the button to view a merged PowerPoint Presentation generated by \r\nEssential Pr" +
    "esentation. Please note that MS PowerPoint viewer is required \r\nto view the resu" +
    "ltant Presentation.\r\n";
            // 
            // btnGenerateDocument
            // 
            this.btnGenerateDocument.Location = new System.Drawing.Point(251, 297);
            this.btnGenerateDocument.Name = "btnGenerateDocument";
            this.btnGenerateDocument.Size = new System.Drawing.Size(118, 26);
            this.btnGenerateDocument.TabIndex = 29;
            this.btnGenerateDocument.Text = "Merge Presentations";
            this.btnGenerateDocument.UseVisualStyleBackColor = true;
            this.btnGenerateDocument.Click += new System.EventHandler(this.btnGenerateDocument_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // txtFile
            // 
            this.txtFile.Location = new System.Drawing.Point(15, 183);
            this.txtFile.Name = "txtFile";
            this.txtFile.Size = new System.Drawing.Size(306, 20);
            this.txtFile.TabIndex = 30;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(336, 181);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(33, 23);
            this.btnBrowse.TabIndex = 31;
            this.btnBrowse.Text = ". . .";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // txtFile1
            // 
            this.txtFile1.Location = new System.Drawing.Point(17, 235);
            this.txtFile1.Name = "txtFile1";
            this.txtFile1.Size = new System.Drawing.Size(304, 20);
            this.txtFile1.TabIndex = 32;
            // 
            // btnBrowse1
            // 
            this.btnBrowse1.Location = new System.Drawing.Point(336, 233);
            this.btnBrowse1.Name = "btnBrowse1";
            this.btnBrowse1.Size = new System.Drawing.Size(33, 23);
            this.btnBrowse1.TabIndex = 33;
            this.btnBrowse1.Text = ". . .";
            this.btnBrowse1.UseVisualStyleBackColor = true;
            this.btnBrowse1.Click += new System.EventHandler(this.btnBrowse1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 34;
            this.label2.Text = "Source";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 35;
            this.label3.Text = "Destination";
            // 
            // radioDestination
            // 
            this.radioDestination.AutoSize = true;
            this.radioDestination.Checked = true;
            this.radioDestination.Location = new System.Drawing.Point(17, 271);
            this.radioDestination.Name = "radioDestination";
            this.radioDestination.Size = new System.Drawing.Size(136, 17);
            this.radioDestination.TabIndex = 36;
            this.radioDestination.TabStop = true;
            this.radioDestination.Text = "Use Destination Theme";
            this.radioDestination.UseVisualStyleBackColor = true;
            // 
            // radioSource
            // 
            this.radioSource.AutoSize = true;
            this.radioSource.Location = new System.Drawing.Point(182, 271);
            this.radioSource.Name = "radioSource";
            this.radioSource.Size = new System.Drawing.Size(139, 17);
            this.radioSource.TabIndex = 37;
            this.radioSource.Text = "Keep Source Formatting";
            this.radioSource.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 322);
            this.Controls.Add(this.radioSource);
            this.Controls.Add(this.radioDestination);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnBrowse1);
            this.Controls.Add(this.txtFile1);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.txtFile);
            this.Controls.Add(this.btnGenerateDocument);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Merging Presentations";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
            Application.Run(new Form1());
        }
        #region events

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "";
            openFileDialog1.InitialDirectory = Path.GetFullPath(@"..\..\..\..\..\..\..\Common\Data\Presentation\");
            openFileDialog1.Filter = "PowerPoint Presentations|*.pptx";
            DialogResult result = openFileDialog1.ShowDialog();

            //Get the selected file name and display in a TextBox
            if (result == DialogResult.OK)
            {
                this.txtFile.Text = openFileDialog1.SafeFileName;
                this.txtFile.Tag = openFileDialog1.FileName;
            }
        }

        private void btnBrowse1_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "";
            openFileDialog1.InitialDirectory = Path.GetFullPath(@"..\..\..\..\..\..\..\Common\Data\Presentation\");
            openFileDialog1.Filter = "PowerPoint Presentations|*.pptx";
            DialogResult result = openFileDialog1.ShowDialog();

            //Get the selected file name and display in a TextBox
            if (result == DialogResult.OK)
            {
                this.txtFile1.Text = openFileDialog1.SafeFileName;
                this.txtFile1.Tag = openFileDialog1.FileName;
            }
        }

        private void btnGenerateDocument_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.radioDestination.Checked == true)
                {
                    //Opens source presentation
                    IPresentation sourcePresentation = Presentation.Open(txtFile1.Tag.ToString());

                    //Opens destination presentation
                    IPresentation destinationPresentation = Presentation.Open(txtFile.Tag.ToString());

                    ISlides slides = sourcePresentation.Slides;

                    foreach (ISlide slide in slides)
                    {
                        //Cloning the slides from source to destination
                        destinationPresentation.Slides.Add(slide.Clone(), PasteOptions.UseDestinationTheme, sourcePresentation);
                    }

                    //Closing the Source presentation
                    sourcePresentation.Close();

                    //Saving the Destination presentaiton.
                    destinationPresentation.Save("MergedUsingDestination.pptx");

                    //Closing the destination presentation
                    destinationPresentation.Close();
                    if (MessageBox.Show("Do you want to view the merged PowerPoint Presentation?", "Finished Merging",
                              MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        System.Diagnostics.Process.Start("MergedUsingDestination.pptx");
                       
                    }              

                }
                else
                {
                    //Opens source presentation
                    IPresentation sourcePresentation = Presentation.Open(txtFile1.Tag.ToString());

                    //Opens destination presentation
                    IPresentation destinationPresentation = Presentation.Open(txtFile.Tag.ToString());

                    ISlides slides = sourcePresentation.Slides;

                    foreach (ISlide slide in slides)
                    {
                        //Cloning the slides from source to destination
                        destinationPresentation.Slides.Add(slide.Clone(), PasteOptions.SourceFormatting, sourcePresentation);
                    }

                    //Closing the Source presentation
                    sourcePresentation.Close();

                    //Saving the Destination presentaiton.
                    destinationPresentation.Save("MergedUsingSource.pptx");

                    destinationPresentation.Close();
                    if (MessageBox.Show("Do you want to view the merged PowerPoint Presentation?", "Finished Merging",
                              MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        System.Diagnostics.Process.Start("MergedUsingSource.pptx");
                       
                    }              

                }
            }
            catch (Exception exp)
            {
                MessageBox.Show("This file could not be merged , please contact Syncfusion Direct-Trac system at http://www.syncfusion.com/support/default.aspx for any queries. ", "OOPS..Sorry!",
                        MessageBoxButtons.OK);
                this.Close();
            }
        }
        #endregion
    }
}
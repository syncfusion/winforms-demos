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
        private RadioButton radioDestination;
        private RadioButton radioSource;
        private TextBox destTextBox;
        private Button destButton;

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
            this.txtFile.Text = "Template.pptx";
            this.txtFile.Tag = @"..\..\..\..\..\..\..\Common\Data\Presentation\Template.pptx";
            this.destTextBox.Text = "Essential Presentation.pptx";
            this.destTextBox.Tag = @"..\..\..\..\..\..\..\Common\Data\Presentation\Essential Presentation.pptx";

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
            this.btnGenerateDocument = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.txtFile = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.radioDestination = new System.Windows.Forms.RadioButton();
            this.radioSource = new System.Windows.Forms.RadioButton();
            this.destTextBox = new System.Windows.Forms.TextBox();
            this.destButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGenerateDocument
            // 
            this.btnGenerateDocument.Location = new System.Drawing.Point(239, 271);
            this.btnGenerateDocument.Name = "btnGenerateDocument";
            this.btnGenerateDocument.Size = new System.Drawing.Size(154, 26);
            this.btnGenerateDocument.TabIndex = 0;
            this.btnGenerateDocument.Text = "Generate Presentation";
            this.btnGenerateDocument.UseVisualStyleBackColor = true;
            this.btnGenerateDocument.Click += new System.EventHandler(this.btnGenerateDocument_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(2, 12);
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
            this.label1.Location = new System.Drawing.Point(-1, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(382, 42);
            this.label1.TabIndex = 27;
            this.label1.Text = "Click the button to view a PowerPoint file generated by Essential Presentation.\r\n" +
    "Please note that MS PowerPoint viewer is required to view the resultant\r\nPresent" +
    "ation.";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // txtFile
            // 
            this.txtFile.Location = new System.Drawing.Point(6, 163);
            this.txtFile.Name = "txtFile";
            this.txtFile.Size = new System.Drawing.Size(286, 20);
            this.txtFile.TabIndex = 30;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(308, 161);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(85, 23);
            this.btnBrowse.TabIndex = 31;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // radioDestination
            // 
            this.radioDestination.AutoSize = true;
            this.radioDestination.Checked = true;
            this.radioDestination.Location = new System.Drawing.Point(6, 245);
            this.radioDestination.Name = "radioDestination";
            this.radioDestination.Size = new System.Drawing.Size(136, 17);
            this.radioDestination.TabIndex = 32;
            this.radioDestination.TabStop = true;
            this.radioDestination.Text = "Use Destination Theme";
            this.radioDestination.UseVisualStyleBackColor = true;
            // 
            // radioSource
            // 
            this.radioSource.AutoSize = true;
            this.radioSource.Location = new System.Drawing.Point(153, 245);
            this.radioSource.Name = "radioSource";
            this.radioSource.Size = new System.Drawing.Size(139, 17);
            this.radioSource.TabIndex = 33;
            this.radioSource.Text = "Keep Source Formatting";
            this.radioSource.UseVisualStyleBackColor = true;
            // 
            // destTextBox
            // 
            this.destTextBox.Location = new System.Drawing.Point(6, 204);
            this.destTextBox.Name = "destTextBox";
            this.destTextBox.Size = new System.Drawing.Size(286, 20);
            this.destTextBox.TabIndex = 34;
            // 
            // destButton
            // 
            this.destButton.Location = new System.Drawing.Point(309, 203);
            this.destButton.Name = "destButton";
            this.destButton.Size = new System.Drawing.Size(84, 23);
            this.destButton.TabIndex = 35;
            this.destButton.Text = "Browse";
            this.destButton.UseVisualStyleBackColor = true;
            this.destButton.Click += new System.EventHandler(this.destButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 298);
            this.Controls.Add(this.destButton);
            this.Controls.Add(this.destTextBox);
            this.Controls.Add(this.radioSource);
            this.Controls.Add(this.radioDestination);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.txtFile);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnGenerateDocument);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cloning Slide";
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

        private void destButton_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "";
            openFileDialog1.InitialDirectory = Path.GetFullPath(@"..\..\..\..\..\..\..\Common\Data\Presentation\");
            openFileDialog1.Filter = "PowerPoint Presentations|*.pptx";
            DialogResult result = openFileDialog1.ShowDialog();

            //Get the selected file name and display in a TextBox
            if (result == DialogResult.OK)
            {
                this.destTextBox.Text = openFileDialog1.SafeFileName;
                this.destTextBox.Tag = openFileDialog1.FileName;
            }
        }

        private void btnGenerateDocument_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtFile.Text))
                {
                    MessageBox.Show("Please browse the files to generate document", "Input missing", MessageBoxButtons.OK);
                }
                else
                {
                    if (this.radioDestination.Checked == true)
                    {
                        // Creates instance for presentation
                        IPresentation sourcePresentation = Presentation.Open(txtFile.Tag.ToString());

                        //Clones the first slide of the presentation.
                        ISlide slide = sourcePresentation.Slides[0].Clone();

                        IPresentation destinationPresentation = Presentation.Open(destTextBox.Tag.ToString());

                        //Adding the cloned slide to the destination presentation by using Destination option.
                        destinationPresentation.Slides.Add(slide, PasteOptions.UseDestinationTheme, sourcePresentation);

                        //Closing the Source presentation
                        sourcePresentation.Close();

                        //Saving the Destination presentaiton.
                        destinationPresentation.Save("ClonedUsingDestination.pptx");

                        destinationPresentation.Close();
                        if (MessageBox.Show("First slide is cloned and added as last slide to the presentation,Do you want to view the resultant Presentation?", "Finished Cloning",
                                  MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                        {
                            System.Diagnostics.Process.Start("ClonedUsingDestination.pptx");

                        }
                    }
                    else
                    {
                        // Creates instance for presentation
                        IPresentation sourcePresentation = Presentation.Open(txtFile.Tag.ToString());

                        //Clones the first slide of the presentation
                        ISlide slide = sourcePresentation.Slides[0].Clone();

                        IPresentation destinationPresentation = Presentation.Open(destTextBox.Tag.ToString());

                        //Adding the cloned slide to the destination presentation by using Destination option.
                        destinationPresentation.Slides.Add(slide, PasteOptions.SourceFormatting, sourcePresentation);

                        //Closing the Source presentation
                        sourcePresentation.Close();

                        //Saving the Destination presentaiton.
                        destinationPresentation.Save("ClonedUsingSource.pptx");

                        destinationPresentation.Close();

                        if (MessageBox.Show("First slide is cloned and added as last slide to the presentation,Do you want to view the resultant Presentation?", "Finished Cloning",
                                  MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                        {
                            System.Diagnostics.Process.Start("ClonedUsingSource.pptx");

                        }
                    }
                }
            }
            catch (IOException)
            {
                MessageBox.Show("Please close the generated presentation", "File is open", MessageBoxButtons.OK);
            }
            catch (Exception)
            {
                MessageBox.Show("This file could not be cloned , please contact Syncfusion Direct-Trac system at http://www.syncfusion.com/support/default.aspx for any queries. ", "OOPS..Sorry!",
                        MessageBoxButtons.OK);
                this.Close();
            }
        }
        #endregion
    }
}


      
       
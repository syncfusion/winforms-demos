using Syncfusion.Presentation;
using Syncfusion.PresentationToPdfConverter;
using Syncfusion.Pdf;
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
namespace PPTXToPdf
{
    public partial class Form1 :  MetroForm 
    {
        #region Private Members
        private System.Windows.Forms.Button btnPresentationToPdf;
        private System.Windows.Forms.TextBox txtFile;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;

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
            this.txtFile.Text = "Syncfusion Presentation.pptx";
            this.txtFile.Tag = @"..\..\..\..\..\..\..\Common\Data\Presentation\Syncfusion Presentation.pptx";
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
            this.btnPresentationToPdf = new System.Windows.Forms.Button();
            this.txtFile = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPresentationToPdf
            // 
            this.btnPresentationToPdf.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPresentationToPdf.Location = new System.Drawing.Point(275, 194);
            this.btnPresentationToPdf.Name = "btnPresentationToPdf";
            this.btnPresentationToPdf.Size = new System.Drawing.Size(118, 23);
            this.btnPresentationToPdf.TabIndex = 0;
            this.btnPresentationToPdf.Text = "Presentation to PDF";
            this.btnPresentationToPdf.UseVisualStyleBackColor = true;
            this.btnPresentationToPdf.Click += new System.EventHandler(this.btnPresentationToPdf_Click);
            // 
            // txtFile
            // 
            this.txtFile.Location = new System.Drawing.Point(7, 164);
            this.txtFile.Name = "txtFile";
            this.txtFile.Size = new System.Drawing.Size(342, 20);
            this.txtFile.TabIndex = 1;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowse.Location = new System.Drawing.Point(362, 163);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(30, 23);
            this.btnBrowse.TabIndex = 2;
            this.btnBrowse.Text = "...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(392, 97);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(379, 42);
            this.label1.TabIndex = 4;
            this.label1.Text = "Click the button to view a PDF document generated by Essential Presentation.\r\nThi" +
    "s sample illustrates the conversion of a Microsoft  PowerPoint \r\nPresentation in" +
    "to a PDF format.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 220);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.txtFile);
            this.Controls.Add(this.btnPresentationToPdf);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Presentation To PDF";
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
        #endregion

        #region Events

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
        private void btnPresentationToPdf_Click(object sender, EventArgs e)
        {
            try
            {
                //Opens the specified presentation
                IPresentation presentation = Presentation.Open(txtFile.Tag.ToString());

                //To set each slide in a pdf page.
                PresentationToPdfConverterSettings settings = new PresentationToPdfConverterSettings();

                settings.ShowHiddenSlides = true;

                //Instance to create pdf document from presentation
#if !SyncfusionFramework2_0 && !SyncfusionFramework3_5
                presentation.ChartToImageConverter = new ChartToImageConverter();
                presentation.ChartToImageConverter.ScalingMode = Syncfusion.OfficeChart.ScalingMode.Best;
#endif
                PdfDocument doc = PresentationToPdfConverter.Convert(presentation, settings);

                //Saves the pdf document
                doc.Save("Sample.pdf");
                if (MessageBox.Show("Do you want to view the PDF document?", "Pdf document created",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    System.Diagnostics.Process.Start("Sample.pdf");
                    this.Close();
                }
            }
            catch(Exception exp)
            {
                MessageBox.Show("This file could not be converted , please contact Syncfusion Direct-Trac system at http://www.syncfusion.com/support/default.aspx for any queries. ", "OOPS..Sorry!",
                        MessageBoxButtons.OK);
                this.Close();
            }
        }

        #endregion

    }
}

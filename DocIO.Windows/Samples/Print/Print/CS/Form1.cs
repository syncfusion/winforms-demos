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
using Syncfusion.Windows.Forms;
using System.Drawing.Printing;
#if !(SyncfusionFramework3_5 || SyncfusionFramework2_0)
using Syncfusion.OfficeChart;
using Syncfusion.OfficeChartToImageConverter;
#endif
using Syncfusion.Licensing;
using System.Reflection;
using System.Text;
using System.IO;

namespace EssentialDocIOSamples
{

    public class Form1 : MetroForm
    {
        //Create a Image Instance
        System.Drawing.Image[] images = null;

        // Load the Document
        WordDocument wordDoc = null;

        //Image Start Index
        int startPageIndex = 0;

        // Image End Index
        int endPageIndex = 0;

        //Input File path 
        String filePath;

        #region Private Members
        private readonly BackgroundWorker worker = new BackgroundWorker();
        private System.Windows.Forms.OpenFileDialog openFileDialog;     
        private Syncfusion.Windows.Forms.ButtonAdv browseButton;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Label browseLabel;
        private System.Windows.Forms.PictureBox pictureBox;
        private Syncfusion.Windows.Forms.ButtonAdv printButton;
        private System.Windows.Forms.Label descriptionLabel;
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
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.browseButton = new Syncfusion.Windows.Forms.ButtonAdv();
            this.textBox = new System.Windows.Forms.TextBox();
            this.browseLabel = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.printButton = new Syncfusion.Windows.Forms.ButtonAdv();
            this.descriptionLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // browseButton
            // 
            this.browseButton.BeforeTouchSize = new System.Drawing.Size(21, 22);
            this.browseButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.browseButton.IsBackStageButton = false;
            this.browseButton.Location = new System.Drawing.Point(332, 157);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(21, 22);
            this.browseButton.TabIndex = 92;
            this.browseButton.Text = ". . .";
            this.browseButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.browseButton.UseVisualStyleBackColor = true;
            this.browseButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(6, 157);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(307, 22);
            this.textBox.TabIndex = 91;
            // 
            // browseLabel
            // 
            this.browseLabel.AutoSize = true;
            this.browseLabel.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.browseLabel.Location = new System.Drawing.Point(3, 135);
            this.browseLabel.Name = "browseLabel";
            this.browseLabel.Size = new System.Drawing.Size(181, 13);
            this.browseLabel.TabIndex = 90;
            this.browseLabel.Text = "Browse a Word Document :";
            // 
            // pictureBox
            // 
            this.pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox.Image")));
            this.pictureBox.Location = new System.Drawing.Point(0, 0);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(365, 82);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 89;
            this.pictureBox.TabStop = false;
            // 
            // printButton
            // 
            this.printButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.printButton.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.printButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218)))));
            this.printButton.BeforeTouchSize = new System.Drawing.Size(108, 23);
            this.printButton.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.Dashed;
            this.printButton.ComboEditBackColor = System.Drawing.Color.Silver;
            this.printButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printButton.ForeColor = System.Drawing.Color.White;
            this.printButton.IsBackStageButton = false;
            this.printButton.KeepFocusRectangle = false;
            this.printButton.Location = new System.Drawing.Point(245, 190);
            this.printButton.Name = "printButton";
            this.printButton.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Managed;
            this.printButton.Size = new System.Drawing.Size(108, 23);
            this.printButton.TabIndex = 13;
            this.printButton.Text = "Print";
            this.printButton.UseVisualStyle = true;
            this.printButton.UseVisualStyleBackColor = false;
            this.printButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.descriptionLabel.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.descriptionLabel.Location = new System.Drawing.Point(0, 85);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(363, 51);
            this.descriptionLabel.TabIndex = 97;
            this.descriptionLabel.Text = "Click the below button to print the word document.In this,Essential DocIO render " +
    "the word document contents page by page as images and print the rendered image u" +
    "sing PrintDialog.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218)))));
            this.ClientSize = new System.Drawing.Size(365, 225);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.printButton);
            this.Controls.Add(this.browseButton);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.browseLabel);
            this.Controls.Add(this.pictureBox);
            this.DropShadow = true;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Print";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        #region Print
        /// <summary>s
        /// Print the word document
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, System.EventArgs e)
        {
            //Loading Image for Progress
            this.descriptionLabel.Image = Image.FromFile(Application.StartupPath + @"..\..\..\..\..\..\..\..\Common\Data\DocIO\Animation.gif");
            //DoWork for NonUITasks
            worker.DoWork += worker_DoWork;
            //DoWork for UITasks
            worker.RunWorkerCompleted += worker_RunWorkerCompleted;
            //Run the Worker
            worker.RunWorkerAsync();
        }
        #endregion

        #region Browse a Word document
        /// <summary>
        /// Browse the word document to print
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            openFileDialog.InitialDirectory = Application.StartupPath;
            openFileDialog.FileName = "";
            openFileDialog.Filter = "Word Document(*.doc *.docx *.rtf)|*.doc;*.docx;*.rtf";
            DialogResult result = openFileDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                this.textBox.Text = openFileDialog.SafeFileName;
                this.textBox.Tag = openFileDialog.FileName;
                filePath = (string)this.textBox.Tag;
            }
        }
        #endregion

        # region FormLoad
        /// <summary>
        /// Load the default input document
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            this.textBox.Text = "DocToImage.docx";
            this.textBox.Tag = Application.StartupPath + @"..\..\..\..\..\..\..\..\Common\Data\DocIO\DocToImage.docx";
            filePath = (string)this.textBox.Tag;
        }
        #endregion

        #region PrintPage
        /// <summary>
        /// The PrintPage event is called for each page to be printed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected virtual void OnPrintPage(object sender, PrintPageEventArgs e)
        {
            //Current page width
            int currentPageWidth = images[startPageIndex].Width;
            //Current page height
            int currentPageHeight = images[startPageIndex].Height;
            //Visible clip bounds width
            int visibleClipBoundsWidth = (int)e.Graphics.VisibleClipBounds.Width;
            //Visible clip bounds height
            int visibleClipBoundsHeight = (int)e.Graphics.VisibleClipBounds.Height;
            //Check if the page layout is landscape or portrait
            if (currentPageWidth > currentPageHeight)
            {
                //Translate the Position 
                e.Graphics.TranslateTransform(0, visibleClipBoundsHeight);
                //Rotates the object at 270 degrees
                e.Graphics.RotateTransform(270.0f);
                //Draw the current page
                e.Graphics.DrawImage(images[startPageIndex], new System.Drawing.Rectangle(0, 0, currentPageWidth, currentPageHeight));
            }
            else
            {
                //Draw the current page
                e.Graphics.DrawImage(images[startPageIndex], new System.Drawing.Rectangle(0, 0, visibleClipBoundsWidth, visibleClipBoundsHeight));
            }
            //Dispose the current page
            images[startPageIndex].Dispose();
            //Increment the start page index 
            startPageIndex++;
            //check if the start page index is lesser than end page index
            if (startPageIndex < endPageIndex)
                e.HasMorePages = true;//if the document contain more than one pages
            else
                startPageIndex = 0;
        }
        # endregion

        #region UITasks
        /// <summary>
        /// Run
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (this.textBox.Text != String.Empty)
            {
                #region PrintSettings
                //Create a PrintDialog
                System.Windows.Forms.PrintDialog printDialog = new System.Windows.Forms.PrintDialog();
                // dialog.PrinterSetting
                printDialog.Document = new PrintDocument();
                //Set all Possible print ranges as true
                printDialog.AllowCurrentPage = true;
                //printDialog.AllowSelection = true;
                printDialog.AllowSomePages = true;
                //Set the start and end page index
                printDialog.PrinterSettings.FromPage = 1;
                printDialog.PrinterSettings.ToPage = images.Length;

                #endregion

                # region Print
                //Open the Show dialog box for print dialog
                if (printDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    //Check if the Page Range exceeds the End page
                    if (printDialog.PrinterSettings.FromPage > 0 && printDialog.PrinterSettings.ToPage <= images.Length)
                    {
                        //Set the start page of the document to print
                        startPageIndex = printDialog.PrinterSettings.FromPage - 1;
                        //Set the end page of the document to Print
                        endPageIndex = printDialog.PrinterSettings.ToPage;
                        //Retrieve the Page need to be rendered
                        printDialog.Document.PrintPage += new PrintPageEventHandler(OnPrintPage);
                        //Print the document
                        printDialog.Document.Print();
                    }
                    else
                    {
                        //If the Page range exceeds the 12
                        if (MessageBoxAdv.Show("The page range is invalid" + Environment.NewLine + "Enter numbers between 1 and " + images.Length.ToString(), "Print Error", MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.Yes)
                        {
                        }
                    }
                    //Dispose the print dialog
                    printDialog.Dispose();
                    //Exit
                    this.Close();
                }
                #endregion
            }
            else
            {
                MessageBoxAdv.Show("Browse a word document and click the button to Print the Word document.");
            }
        }
        #endregion

        # region NonUITasks
        /// <summary>
        /// Performin Non UI Tasks
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void worker_DoWork(object sender, DoWorkEventArgs e)
        {
            //Open the Word document
            wordDoc = new WordDocument(filePath);
#if !(SyncfusionFramework3_5 || SyncfusionFramework2_0)
            //Initialize chart to image converter for converting charts in Word to Image conversion
            wordDoc.ChartToImageConverter = new ChartToImageConverter();
            wordDoc.ChartToImageConverter.ScalingMode = Syncfusion.OfficeChart.ScalingMode.Normal;
#endif
            //convert the document to Image
            images = wordDoc.RenderAsImages(ImageType.Metafile);
            endPageIndex = images.Length;
            //Close the Word Document         
            wordDoc.Close();
            //sets the label Image to null
            this.descriptionLabel.Image = null;
        }
        #endregion
    }
}

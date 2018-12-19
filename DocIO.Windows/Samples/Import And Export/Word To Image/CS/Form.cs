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
using System.Drawing.Imaging;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.IO;
using System.Diagnostics;

using Syncfusion.DocIO;
using Syncfusion.DocIO.DLS;
using Syncfusion.OfficeChart;
using Syncfusion.OfficeChartToImageConverter;
using Syncfusion.Windows.Forms;
using Syncfusion.Windows.Forms.Tools;
using Syncfusion.Licensing;
using System.Reflection;
using System.Text;

namespace EssentialDocIOSamples
{

    public class Form1 : MetroForm
    {
        #region Private Members

        private ToolTip toolTip1;
        private ButtonAdv button1;
        private PictureBox pictureBox1;
        private Label label2;
        private GroupBox groupBox1;
        private RadioButtonAdv emfRadioBtn;
        private RadioButtonAdv pngRadioBtn;
        private RadioButtonAdv jpegRadioBtn;
        private RadioButtonAdv bmpRadioBtn;
        private ButtonAdv button3;
        private TextBox textBox1;
        private Label label9;
        private OpenFileDialog openFileDialog1;
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
            this.button1 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bmpRadioBtn = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
            this.emfRadioBtn = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
            this.pngRadioBtn = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
            this.jpegRadioBtn = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
            this.button3 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bmpRadioBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emfRadioBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pngRadioBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jpegRadioBtn)).BeginInit();
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
            this.button1.Location = new System.Drawing.Point(263, 257);
            this.button1.Name = "button1";
            this.button1.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Managed;
            this.button1.Size = new System.Drawing.Size(108, 23);
            this.button1.TabIndex = 62;
            this.button1.Text = "Convert to Image";
            this.button1.UseVisualStyle = true;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(375, 82);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 60;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(0, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(363, 51);
            this.label2.TabIndex = 68;
            this.label2.Text = "Clicking the button below will result in a Image being converted from word docume" +
    "nt using Essential DocIO.";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bmpRadioBtn);
            this.groupBox1.Controls.Add(this.emfRadioBtn);
            this.groupBox1.Controls.Add(this.pngRadioBtn);
            this.groupBox1.Controls.Add(this.jpegRadioBtn);
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(5, 184);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(366, 53);
            this.groupBox1.TabIndex = 100;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Convert To";
            // 
            // bmpRadioBtn
            // 
            this.bmpRadioBtn.BeforeTouchSize = new System.Drawing.Size(49, 20);
            this.bmpRadioBtn.Border3DStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.bmpRadioBtn.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.bmpRadioBtn.GradientEnd = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.bmpRadioBtn.GradientStart = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.bmpRadioBtn.Location = new System.Drawing.Point(181, 25);
            this.bmpRadioBtn.MetroColor = System.Drawing.Color.Empty;
            this.bmpRadioBtn.Name = "bmpRadioBtn";
            this.bmpRadioBtn.Size = new System.Drawing.Size(49, 20);
            this.bmpRadioBtn.TabIndex = 103;
            this.bmpRadioBtn.TabStop = false;
            this.bmpRadioBtn.Text = "BMP";
            this.bmpRadioBtn.ThemesEnabled = true;
            // 
            // emfRadioBtn
            // 
            this.emfRadioBtn.BeforeTouchSize = new System.Drawing.Size(47, 20);
            this.emfRadioBtn.Border3DStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.emfRadioBtn.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emfRadioBtn.GradientEnd = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.emfRadioBtn.GradientStart = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.emfRadioBtn.Location = new System.Drawing.Point(271, 25);
            this.emfRadioBtn.MetroColor = System.Drawing.Color.Empty;
            this.emfRadioBtn.Name = "emfRadioBtn";
            this.emfRadioBtn.Size = new System.Drawing.Size(47, 20);
            this.emfRadioBtn.TabIndex = 46;
            this.emfRadioBtn.TabStop = false;
            this.emfRadioBtn.Text = "EMF";
            this.emfRadioBtn.ThemesEnabled = true;
            // 
            // pngRadioBtn
            // 
            this.pngRadioBtn.BeforeTouchSize = new System.Drawing.Size(55, 20);
            this.pngRadioBtn.Border3DStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.pngRadioBtn.Checked = true;
            this.pngRadioBtn.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.pngRadioBtn.GradientEnd = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.pngRadioBtn.GradientStart = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.pngRadioBtn.Location = new System.Drawing.Point(13, 25);
            this.pngRadioBtn.MetroColor = System.Drawing.Color.Empty;
            this.pngRadioBtn.Name = "pngRadioBtn";
            this.pngRadioBtn.Size = new System.Drawing.Size(55, 20);
            this.pngRadioBtn.TabIndex = 44;
            this.pngRadioBtn.Text = "PNG";
            this.pngRadioBtn.ThemesEnabled = true;
            // 
            // jpegRadioBtn
            // 
            this.jpegRadioBtn.BeforeTouchSize = new System.Drawing.Size(52, 19);
            this.jpegRadioBtn.Border3DStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.jpegRadioBtn.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.jpegRadioBtn.GradientEnd = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.jpegRadioBtn.GradientStart = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.jpegRadioBtn.Location = new System.Drawing.Point(94, 25);
            this.jpegRadioBtn.MetroColor = System.Drawing.Color.Empty;
            this.jpegRadioBtn.Name = "jpegRadioBtn";
            this.jpegRadioBtn.Size = new System.Drawing.Size(52, 19);
            this.jpegRadioBtn.TabIndex = 45;
            this.jpegRadioBtn.Text = "JPEG";
            this.jpegRadioBtn.ThemesEnabled = true;
            // 
            // button3
            // 
            this.button3.BeforeTouchSize = new System.Drawing.Size(21, 25);
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button3.IsBackStageButton = false;
            this.button3.Location = new System.Drawing.Point(350, 147);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(21, 25);
            this.button3.TabIndex = 103;
            this.button3.Text = ". . .";
            this.button3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(5, 149);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(333, 22);
            this.textBox1.TabIndex = 102;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label9.Location = new System.Drawing.Point(2, 127);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(110, 13);
            this.label9.TabIndex = 101;
            this.label9.Text = "Word Document";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 15);
            this.BackColor = System.Drawing.Color.White;
            this.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218)))));
            this.ClientSize = new System.Drawing.Size(375, 292);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.DropShadow = true;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Word to Image";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bmpRadioBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emfRadioBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pngRadioBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jpegRadioBtn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        #region Button_Click Event
        private void button1_Click(object sender, System.EventArgs e)
        {
            try
            {
                if (this.textBox1.Text != String.Empty)
                {
                    // Load the Document
                    WordDocument wordDoc = new WordDocument((string)textBox1.Tag, Syncfusion.DocIO.FormatType.Automatic);
                    //Initialize chart to image converter for converting charts in word to pdf conversion
                    wordDoc.ChartToImageConverter = new ChartToImageConverter();
                    wordDoc.ChartToImageConverter.ScalingMode = Syncfusion.OfficeChart.ScalingMode.Normal;
                    // Convert Word Document into image
                    Image[] image = wordDoc.RenderAsImages(ImageType.Metafile);
                    int pageNumber = 0;
                    //Save as Bitmap image
                    if (bmpRadioBtn.Checked)
                    {
                        for (int i = 0; i < image.Length; i++)
                        {
                            image[i].Save(@"WordToImage_" + ++pageNumber + ".bmp", ImageFormat.Bmp);
                        }
                        if (MessageBoxAdv.Show("Do you want to view the Image file?", "File has been created", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                        {
                            try
                            {
                                System.Diagnostics.Process.Start(@"WordToImage_1.bmp");
                                //Exit
                                this.Close();
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine(ex.ToString());
                            }
                        }
                    }
                    //Save as PNG image
                    else if (pngRadioBtn.Checked)
                    {
                        for (int i = 0; i < image.Length; i++)
                        {
                            image[i].Save(@"WordToImage_" + ++pageNumber + ".png", ImageFormat.Png);
                        }
                        if (MessageBoxAdv.Show("Do you want to view the Image file?", "File has been created", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                        {
                            try
                            {
                                System.Diagnostics.Process.Start(@"WordToImage_1.png");
                                //Exit
                                this.Close();
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine(ex.ToString());
                            }
                        }
                    }
                    //Save as JPEG image
                    else if (jpegRadioBtn.Checked)
                    {
                        for (int i = 0; i < image.Length; i++)
                        {
                            image[i].Save(@"WordToImage_" + ++pageNumber + ".jpeg", ImageFormat.Jpeg);
                        }
                        if (MessageBoxAdv.Show("Do you want to view the Image file?", "File has been created", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                        {
                            try
                            {
                                System.Diagnostics.Process.Start(@"WordToImage_1.jpeg");
                                //Exit
                                this.Close();
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine(ex.ToString());
                            }
                        }
                    }
                    //Save as EMF image
                    else if (emfRadioBtn.Checked)
                    {
                        for (int i = 0; i < image.Length; i++)
                        {
                            MemoryStream stream = (MemoryStream)wordDoc.RenderAsImages(i, ImageFormat.Emf);
                            using (FileStream fstream = new FileStream(@"WordToImage_" + ++pageNumber + ".emf", FileMode.OpenOrCreate))
                            {
                                stream.WriteTo(fstream);
                            }
                        }
                        if (MessageBoxAdv.Show("Do you want to view the Image file?", "File has been created", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                        {
                            try
                            {
                                System.Diagnostics.Process.Start(@"WordToImage_1.emf");
                                //Exit
                                this.Close();
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine(ex.ToString());
                            }
                        }
                    }
                }
                else
                {
                    MessageBoxAdv.Show("Browse a word document and click the button to convert as a Image.");
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }
        #endregion

        private void button3_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = Application.StartupPath + @"..\..\..\..\..\..\..\..\Common\Data\DocIO\";
            openFileDialog1.FileName = "";
            openFileDialog1.Filter = "Word Document(*.doc *.docx *.rtf)|*.doc;*.docx;*.rtf";
            DialogResult result = openFileDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                this.textBox1.Text = openFileDialog1.SafeFileName;
                this.textBox1.Tag = openFileDialog1.FileName;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.textBox1.Text = "DocToImage.docx";
            this.textBox1.Tag = Application.StartupPath + @"..\..\..\..\..\..\..\..\Common\Data\DocIO\DocToImage.docx";
        }
    }
}


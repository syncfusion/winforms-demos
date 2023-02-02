#region Copyright Syncfusion Inc. 2001-2023.
// Copyright Syncfusion Inc. 2001-2023. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Windows.Forms;
using Syncfusion.Presentation;
using Syncfusion.PresentationToPdfConverter;
using Syncfusion.Pdf;
using Syncfusion.Windows.Forms;
using Syncfusion.OfficeChartToImageConverter;
using Syncfusion.Licensing;
using System.Reflection;
using System.Text;
using Syncfusion.WinForms.Controls;
using System.Diagnostics;

namespace PowerPointViewer
{

    public partial class Form1 : SfForm
    {
        [STAThread]
        static void Main()
        {
			SyncfusionLicenseProvider.RegisterLicense(FindLicenseKey());
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        private int position = -1;
        private List<Image> images = new List<Image>();
        private PrintDialog pDialog = new PrintDialog();
        private bool onLoad = true;
        private bool minimised;
        private int _lastPainted;
        private IPresentation presentation = null;
        private float imageWidth;
        private float imageHeight;
        private List<Image> slideImages = new List<Image>();
        private BackgroundWorker displayBackgroundWorker = new BackgroundWorker();
        private string filePath = "Data/NewCharts.pptx";
        private BackgroundWorker pdfBackgroundWorker = new BackgroundWorker();
        private int loadingIndicatorX;
        private int loadingIndicatorY;
        private int printFromPage;
        private int printToPage;
        private SplashScreen splashScreen = new SplashScreen();

        public Form1()
        {
            InitializeComponent();
            this.Opacity = 0.0f;
            this.ShowInTaskbar = false;
            splashScreen.Show();
            this.BackColor = Color.FromArgb(244, 244, 244);
            this.flowLayoutPanel1.FlowDirection = FlowDirection.LeftToRight;
            this.splitter1.BackColor = Color.Gainsboro;
            this.flowLayoutPanel1.AutoScroll = true;
            loadingIndicatorX = (this.centerSlidePictureBox.Width / 2) - (loadingIndicatorPictureBox.Width / 2);
            loadingIndicatorY = (this.centerSlidePictureBox.Height / 2) - (loadingIndicatorPictureBox.Height / 2);
            SetLoadingIndicator();
            displayBackgroundWorker.DoWork += BackgroundWorker_DoWork;
            displayBackgroundWorker.RunWorkerCompleted += BackgroundWorker_RunWorkerCompleted;
            pdfBackgroundWorker.DoWork += PdfBackgroundWorker_DoWork;
            pdfBackgroundWorker.RunWorkerCompleted += PdfBackgroundWorker_RunWorkerCompleted;
            this.previousIconPictureBox.Enabled = false;
            this.previousIconPictureBox.Image = Properties.Resources.Navigation_Prev__Disabled;
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

        public bool IsOnLoad
        {
            get
            {
                return onLoad;
            }
            set
            {
                onLoad = value;
            }
        }

        public bool OnMinimized
        {
            get
            {
                return minimised;
            }
            set
            {
                minimised = value;
            }
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            ConvertSlideToImage();
            this.flowLayoutPanel1.Focus();
            this.flowLayoutPanel1.PreviewKeyDown += new PreviewKeyDownEventHandler(flowLayoutPanel1_PreviewKeyDown);
        }

        private void flowLayoutPanel1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Up || e.KeyCode == Keys.Left)
                {
                    this.Previous_Click(sender, e);
                }
                if (e.KeyCode == Keys.Down || e.KeyCode == Keys.Right)
                {
                    this.Next_Click(sender, e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void SetLastPaintedPosition(int position)
        {
            _lastPainted = position;
        }

        public int GetLastPaintedPosition()
        {
            return _lastPainted;
        }

        private void BackgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            UpdateDiaplay();
            loadingIndicatorPictureBox.Visible = false;
            this.Opacity = 100.0f;
            this.ShowInTaskbar = true;
            this.splashScreen.Close();
        }

        private void BackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            GetImagesFromPresentation();
        }

        private void SetLoadingIndicator()
        {
            loadingIndicatorPictureBox.Location = new Point((loadingIndicatorX), (int)(loadingIndicatorY));
        }

        private void GetImagesFromPresentation()
        {
            presentation.ChartToImageConverter = new ChartToImageConverter();
            presentation.ChartToImageConverter.ScalingMode = Syncfusion.OfficeChart.ScalingMode.Best;
            foreach (ISlide slide in presentation.Slides)
            {
                //Converts slide to image
                Image image = Image.FromStream(slide.ConvertToImage(Syncfusion.Drawing.ImageFormat.Emf));

                Image.GetThumbnailImageAbort myCallback =
                                         new Image.GetThumbnailImageAbort(ThumbnailCallback);
                images.Add(image);
                Image newImage = image.GetThumbnailImage(170, 100, myCallback, System.IntPtr.Zero);

                slideImages.Add(newImage);
            }
        }

        private void UpdateDiaplay()
        {
            int slideNumber = 1;
            foreach (Image newImage in slideImages)
            {
                //Instantiating pictureBox object for each slide in presentation.
                SlideThumbnail slideThumbnail = new SlideThumbnail(this);
                slideThumbnail.PictureBoxImage = newImage;
                slideThumbnail.Number = slideNumber.ToString();
                slideThumbnail.Margin = new Padding(0, 16, 0, 0);
                if (this.flowLayoutPanel1.Controls.Count == 0)
                {
                    slideThumbnail.Margin = new Padding(0, 10, 0, 0);
                }
                slideThumbnail.Controls[0].MouseClick += new MouseEventHandler(slideThumbnail.SlideThumbnail_MouseClick);
                slideThumbnail.Controls[0].Paint += new System.Windows.Forms.PaintEventHandler(slideThumbnail.pictureBox_Paint);
                this.flowLayoutPanel1.Controls.Add(slideThumbnail);
                slideNumber++;
            }

            lblpageDisplay.Text = 1 + "/" + images.Count;
            this.centerSlidePictureBox.Image = images[0];
            if (images.Count >= 6)
                this.splitter1.Visible = false;
            this.centerSlidePictureBox.Visible = true;
            if (this.flowLayoutPanel1.Controls.Count == 1)
            {
                this.NextIconPictureBox.Enabled = false;
                this.NextIconPictureBox.Image = Properties.Resources.Navigation_Next__Disabled;
                this.previousIconPictureBox.Enabled = false;
                this.previousIconPictureBox.Image = Properties.Resources.Navigation_Prev__Disabled;
            }
            else
            {
                this.NextIconPictureBox.Enabled = true;
                this.NextIconPictureBox.Image = Properties.Resources.ppt__for;
            }
        }

        private void ConvertSlideToImage()
        {
            if (!displayBackgroundWorker.IsBusy)
            {
                loadingIndicatorPictureBox.Visible = true;
                try
                {
                    presentation = Presentation.Open(filePath);
                }
                catch (Exception exception)
                {
                    DialogResult messageBoxResult = MessageBox.Show("This file could not be loaded due to" + exception.Message, "Error", MessageBoxButtons.OKCancel);
                }
                this.openFileDialog1.FileName = filePath;
                this.Text = Path.GetFileName(openFileDialog1.FileName);
                displayBackgroundWorker.RunWorkerAsync();
            }
        }

        public bool ThumbnailCallback()
        {
            return false;
        }

        public void ClickAction(Object sender)
        {
            if (sender as PictureBox != null)
            {
                this.previousIconPictureBox.Image = Properties.Resources.ppt__back;
                this.NextIconPictureBox.Image = Properties.Resources.ppt__for;

                SlideThumbnail slideThumbnail = (sender as PictureBox).Parent as SlideThumbnail;
                position = (sender as PictureBox).Parent.TabIndex;
                centerSlidePictureBox.Image = images[position];
                slideThumbnail.Controls[0].Refresh();
                lblpageDisplay.Text = (position + 1) + "/" + images.Count;

                if (position == 0)
                {
                    this.previousIconPictureBox.Enabled = false;
                    this.previousIconPictureBox.Image = Properties.Resources.Navigation_Prev__Disabled;
                }
                else
                {
                    this.previousIconPictureBox.Enabled = true;
                    this.previousIconPictureBox.Image = Properties.Resources.ppt__back;
                }

                if (position == images.Count - 1)
                {
                    this.NextIconPictureBox.Enabled = false;
                    this.NextIconPictureBox.Image = Properties.Resources.Navigation_Next__Disabled;
                }
                else
                {
                    this.NextIconPictureBox.Enabled = true;
                    this.NextIconPictureBox.Image = Properties.Resources.ppt__for;
                }
            }
        }

        internal void HightLightControl(int position)
        {
            foreach (Control control in this.flowLayoutPanel1.Controls)
            {
                Graphics gr = control.CreateGraphics();
                if (control.Controls.Count > 0)
                {
                    Control picBox = control.Controls[0];

                    if (control.TabIndex == position)
                    {
                        gr.DrawRectangle(new Pen(Color.FromArgb(210, 71, 38), 4), new Rectangle((picBox as PictureBox).Location.X - 2, (picBox as PictureBox).Location.Y - 2, (picBox as PictureBox).Size.Width + 4, (picBox as PictureBox).Size.Height + 4));
                    }
                    else
                    {
                        Color color = this.flowLayoutPanel1.BackColor;
                        gr.DrawRectangle(new Pen(new SolidBrush(color), 4), new Rectangle((picBox as PictureBox).Location.X - 2, (picBox as PictureBox).Location.Y - 2, (picBox as PictureBox).Size.Width + 4, (picBox as PictureBox).Size.Height + 4));
                    }
                }
            }
        }

        public void RePaint(int position)
        {
            this.flowLayoutPanel1.Controls[position].Controls[0].Refresh();
        }

        private void Previous_Click(object sender, EventArgs e)
        {
            if (position == 0 || position < 0)
                centerSlidePictureBox.Image = centerSlidePictureBox.Image;
            else
            {
                position = position - 1;
                centerSlidePictureBox.Image = images[position];
                lblpageDisplay.Text = (position + 1) + "/" + images.Count;
            }
            onLoad = false; minimised = false;
            if (position >= 0)
            {
                this.flowLayoutPanel1.Controls[position].Controls[0].Refresh();
                int value = this.flowLayoutPanel1.VerticalScroll.Value;
                if (this.flowLayoutPanel1.Controls[position].Location.Y < 4 * 116)
                {
                    this.flowLayoutPanel1.VerticalScroll.Value = position * 100;
                    this.flowLayoutPanel1.PerformLayout();
                }
            }
            if (position == 0)
            {
                this.previousIconPictureBox.Enabled = false;
                this.previousIconPictureBox.Image = Properties.Resources.Navigation_Prev__Disabled;
            }
            this.NextIconPictureBox.Enabled = true;
            this.NextIconPictureBox.Image = Properties.Resources.ppt__for;
        }

        private void Next_Click(object sender, EventArgs e)
        {
            this.previousIconPictureBox.Enabled = true;
            this.previousIconPictureBox.Image = Properties.Resources.ppt__back;

            if (position == this.flowLayoutPanel1.Controls.Count - 1)
                centerSlidePictureBox.Image = centerSlidePictureBox.Image;
            else if (position == -1)
            {
                position = position + 2;
                centerSlidePictureBox.Image = images[position];
            }
            else
            {
                position = position + 1;
                centerSlidePictureBox.Image = images[position];
            }
            onLoad = false; minimised = false;
            this.flowLayoutPanel1.Controls[position].Controls[0].Refresh();
            lblpageDisplay.Text = (position + 1) + "/" + images.Count;
            int value = this.flowLayoutPanel1.VerticalScroll.Value;
            if (this.flowLayoutPanel1.Controls[position].Location.Y > 4 * 116)
            {
                this.flowLayoutPanel1.VerticalScroll.Value = position * 116;
                this.flowLayoutPanel1.PerformLayout();
            }

            if (position == images.Count - 1)
            {
                this.NextIconPictureBox.Enabled = false;
                this.NextIconPictureBox.Image = Properties.Resources.Navigation_Next__Disabled;
            }
        }

        private void NextIconPictureBox_MouseLeave(object sender, System.EventArgs e)
        {
            if (position != images.Count - 1)
                this.NextIconPictureBox.Image = Properties.Resources.ppt__for;
        }

        private void PreviousIconPictureBox_MouseLeave(object sender, System.EventArgs e)
        {
            if (position != 0)
                this.previousIconPictureBox.Image = Properties.Resources.ppt__back;
        }

        private void Minimize_Click(object sender, EventArgs e)
        {
            minimised = true;
            this.WindowState = FormWindowState.Minimized;
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Folder_Click(object sender, EventArgs e)
        {
            if (!displayBackgroundWorker.IsBusy)
            {
                Image centerSlideImage = this.centerSlidePictureBox.Image;
                this.centerSlidePictureBox.Image = null;
                this.openIconPictureBox.Image = Properties.Resources.ppt__open_copy;
                openFileDialog1.InitialDirectory = Path.GetFullPath(@"..\..\Data\");
                openFileDialog1.FileName = "";
                openFileDialog1.Filter = "PowerPoint Presentations|*.pptx";
                DialogResult result = openFileDialog1.ShowDialog();
                if (result == DialogResult.OK)
                {
                    onLoad = true; minimised = false;
                    this.flowLayoutPanel1.Controls.Clear();
                    images.Clear();
                    slideImages.Clear();
                    this.splitter1.Visible = true;
                    filePath = openFileDialog1.FileName;
                    ConvertSlideToImage();
                    position = 0;
                }
                else
                {
                    openFileDialog1.FileName = filePath;
                    this.centerSlidePictureBox.Image = centerSlideImage;
                }
                this.openIconPictureBox.Image = Properties.Resources.ppt__open;
            }
        }

        private void Print_Click(object sender, EventArgs e)
        {
            printFromPage = 1;
            printToPage = images.Count;
            System.Windows.Forms.PrintDialog printDialog = new System.Windows.Forms.PrintDialog();
            printDialog.AllowSomePages = true;
            printDialog.PrinterSettings.FromPage = 1;
            printDialog.PrinterSettings.ToPage = images.Count;
            PrintDocument printDoc = new PrintDocument();
            printDoc.PrintPage += new PrintPageEventHandler(OnPrintPage);
            if (printDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                printFromPage = printDialog.PrinterSettings.FromPage;
                printToPage = printDialog.PrinterSettings.ToPage;
                printDoc.Print();
            }
            this.printIconPictureBox.Image = Properties.Resources.ppt__Print;
        }

        private void OnPrintPage(object sender, PrintPageEventArgs args)
        {
            using (System.Drawing.Image image = images[printFromPage - 1].Clone() as System.Drawing.Image)
            {
                System.Drawing.Graphics g = args.Graphics;
                Syncfusion.Pdf.Graphics.PdfUnitConvertor convertor = new Syncfusion.Pdf.Graphics.PdfUnitConvertor();
                imageWidth = convertor.ConvertFromPixels(image.Width, Syncfusion.Pdf.Graphics.PdfGraphicsUnit.Point);
                imageHeight = convertor.ConvertFromPixels(image.Height, Syncfusion.Pdf.Graphics.PdfGraphicsUnit.Point);
                int graphicsHeight = (int)convertor.ConvertFromPixels(args.Graphics.VisibleClipBounds.Height, Syncfusion.Pdf.Graphics.PdfGraphicsUnit.Point);
                int graphicsWidth = (int)convertor.ConvertFromPixels(args.Graphics.VisibleClipBounds.Width, Syncfusion.Pdf.Graphics.PdfGraphicsUnit.Point);
                float printDocumentHeight = convertor.ConvertFromPixels(args.PageSettings.PaperSize.Height, Syncfusion.Pdf.Graphics.PdfGraphicsUnit.Point) / 2;
                g.DrawImage(image, 1, printDocumentHeight - (imageHeight / 2), imageWidth, imageHeight);
            }

            printFromPage++;

            if (printFromPage <= printToPage)
            {

                args.HasMorePages = true;
            }
            else
            {
                args.HasMorePages = false;
            }
        }

        private void PdfBackgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.pdfConvertIconPictureBox.Image = Properties.Resources.ppt_pdf;
            this.loadingIndicatorPictureBox.Visible = false;
            SetLoadingIndicator();
        }

        private void PdfBackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            PresentationToPdfConverterSettings settings = new PresentationToPdfConverterSettings();
            settings.ShowHiddenSlides = true;
            IPresentation presentation = Presentation.Open(openFileDialog1.FileName);
            presentation.ChartToImageConverter = new ChartToImageConverter();
            presentation.ChartToImageConverter.ScalingMode = Syncfusion.OfficeChart.ScalingMode.Best;
            PdfDocument doc = PresentationToPdfConverter.Convert(presentation, settings);
            doc.Save(@"Output/Sample.pdf");
            DialogResult messageBoxResult = MessageBox.Show("Do you want to view the generated pdf file ?", "File Creation", MessageBoxButtons.YesNo);
            if (messageBoxResult == DialogResult.Yes)
            {
#if !NETCORE
                System.Diagnostics.Process.Start(Path.GetFullPath(@"Output/Sample.pdf"));
#else
                ProcessStartInfo psi = new ProcessStartInfo
                {
                    FileName = "cmd",
                    WindowStyle = ProcessWindowStyle.Hidden,
                    UseShellExecute = false,
                    CreateNoWindow = true,
                    Arguments = "/c start Output/Sample.pdf"
                };
                Process.Start(psi);
#endif
            }
        }

        private void pdfConvertIconPictureBox_Click(object sender, EventArgs e)
        {
            if (!pdfBackgroundWorker.IsBusy)
            {
                this.loadingIndicatorPictureBox.Visible = true;
                this.loadingIndicatorPictureBox.Parent = this.centerSlidePictureBox;
                int loadingIndicatorX = (this.centerSlidePictureBox.Width / 2) - (loadingIndicatorPictureBox.Width / 2);
                int loadingIndicatorY = (this.centerSlidePictureBox.Height / 2) - (loadingIndicatorPictureBox.Height / 2);
                loadingIndicatorPictureBox.Location = new Point((loadingIndicatorX), (int)(loadingIndicatorY));
                loadingIndicatorPictureBox.Anchor = AnchorStyles.Top;
                this.pdfConvertIconPictureBox.Image = Properties.Resources.ppt_pdf_copy;
                pdfBackgroundWorker.RunWorkerAsync();
            }
        }
    }
}

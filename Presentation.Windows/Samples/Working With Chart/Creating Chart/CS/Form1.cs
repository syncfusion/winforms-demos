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
using Syncfusion.Drawing;
using Syncfusion.Windows.Forms;
using Syncfusion.OfficeChart;
using Syncfusion.Licensing;
using System.Reflection;

namespace Images
{
    public partial class Form1 : MetroForm
    {
        #region Private Members
        private System.Windows.Forms.Button btnCreatePresn;
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
            this.btnCreatePresn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCreatePresn
            // 
            this.btnCreatePresn.Location = new System.Drawing.Point(272, 152);
            this.btnCreatePresn.Name = "btnCreatePresn";
            this.btnCreatePresn.Size = new System.Drawing.Size(93, 22);
            this.btnCreatePresn.TabIndex = 0;
            this.btnCreatePresn.Text = "Create Chart";
            this.btnCreatePresn.UseVisualStyleBackColor = true;
            this.btnCreatePresn.Click += new System.EventHandler(this.btnCreatePresn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
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
            this.label1.Location = new System.Drawing.Point(3, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(362, 28);
            this.label1.TabIndex = 27;
            this.label1.Text = "Click the button to view a created Chart in generated Presentation.This"
                + "\r\nsample demonstrates how to add a chart into Presentation.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 180);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnCreatePresn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chart Creation";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        [STAThread]
        static void Main()
        {
            SyncfusionLicenseProvider.RegisterLicense(FindLicenseKey());
            Application.Run(new Form1());
        }

        #endregion

        private void btnCreatePresn_Click(object sender, EventArgs e)
        {
            try
            {
                using (IPresentation presentation = Presentation.Create())
                {
                    ISlide slide = presentation.Slides.Add(SlideLayoutType.TitleOnly);
                    IParagraph paragraph = ((IShape)slide.Shapes[0]).TextBody.Paragraphs.Add();
                    //Apply center alignment to the paragraph
                    paragraph.HorizontalAlignment = HorizontalAlignmentType.Center;
                    //Add slide title
                    ITextPart textPart = paragraph.AddTextPart("Northwind Management Report");
                    textPart.Font.Color = ColorObject.FromArgb(46, 116, 181);                    
                    //Get chart data from xml file
                    DataSet dataSet = new DataSet();
                    dataSet.ReadXml(@"..\..\..\..\..\..\..\Common\Data\Presentation\Products.xml");
                    //Add a new chart to the presentation slide
                    IPresentationChart chart = slide.Charts.AddChart(44.64, 133.2, 870.48, 380.16);
                    //Set chart type
                    chart.ChartType = OfficeChartType.Pie;
                    //Set chart title
                    chart.ChartTitle = "Best Selling Products";
                    //Set chart properties font name and size
                    chart.ChartTitleArea.FontName = "Calibri (Body)";
                    chart.ChartTitleArea.Size = 14;
                    for (int i = 0; i < dataSet.Tables[0].Rows.Count; i++)
                    {
                        chart.ChartData.SetValue(i + 2, 1, dataSet.Tables[0].Rows[i].ItemArray[1]);
                        chart.ChartData.SetValue(i + 2, 2, dataSet.Tables[0].Rows[i].ItemArray[2]);
                    }
                    //Create a new chart series with the name “Sales”
                    AddSeriesForChart(chart);
                    //Setting the font size of the legend.
                    chart.Legend.TextArea.Size = 14;
                    //Setting background color
                    chart.ChartArea.Fill.ForeColor = System.Drawing.Color.FromArgb(242, 242, 242);
                    chart.PlotArea.Fill.ForeColor = System.Drawing.Color.FromArgb(242, 242, 242);
                    chart.ChartArea.Border.LinePattern = OfficeChartLinePattern.None;
                    chart.PrimaryCategoryAxis.CategoryLabels = chart.ChartData[2, 1, 11, 1];
                    //Saves the presentation instance to the stream.
                    presentation.Save("ChartCreationSample.pptx");

                    if (MessageBox.Show("Do you want to view the created PowerPoint presentation?", "PowerPoint presentation Created",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {

                        System.Diagnostics.Process.Start("ChartCreationSample.pptx");
                        this.Close();

                    }
                }

            }
            catch (Exception exp)
            {
                MessageBox.Show("This file could not be created , please contact Syncfusion Direct-Trac system at http://www.syncfusion.com/support/default.aspx for any queries. ", "OOPS..Sorry!",
                        MessageBoxButtons.OK);

            }
        }

        #region Helper Methods
        
        /// <summary>
        /// Adds the series for the chart.
        /// </summary>
        /// <param name="chart">Represents the chart instance from the presentation.</param>
        private void AddSeriesForChart(IPresentationChart chart)
        {
            //Add a series for the chart.
            IOfficeChartSerie series = chart.Series.Add("Sales");
            series.Values = chart.ChartData[2, 2, 11, 2];
            //Setting data label
            series.DataPoints.DefaultDataPoint.DataLabels.IsValue = true;
            series.DataPoints.DefaultDataPoint.DataLabels.Position = OfficeDataLabelPosition.Outside;
            series.DataPoints.DefaultDataPoint.DataLabels.Size = 14;
        }

        #endregion HelperMethods
    }

    #region Helper class
    /// <summary>
    /// Specifies the Product details
    /// </summary>
    public class ProductDetails
    {
        #region fields

        private int m_serialNo;
        private string m_productName;
        private decimal m_sum;

        #endregion

        #region properties

        /// <summary>
        /// Gets or sets the serial number of the product.
        /// </summary>
        public int SNO
        {
            get { return m_serialNo; }
            set { m_serialNo = value; }
        }

        /// <summary>
        /// Gets or sets the name of the product.
        /// </summary>
        public string ProductName
        {
            get { return m_productName; }
            set { m_productName = value; }
        }

        /// <summary>
        /// Gets or sets the sum value of the product.
        /// </summary>
        public decimal Sum
        {
            get { return m_sum; }
            set { m_sum = value; }
        }

        #endregion

        #region Constructor

        /// <summary>
        /// Constructor for the ProductDetails to create a new instance.
        /// </summary>
        /// <param name="serialNumber">Represents the serial number of the product.</param>
        /// <param name="productName">Represents the product name.</param>
        /// <param name="sum">Represents the sum value of the product.</param>
        public ProductDetails(int serialNumber, string productName, decimal sum)
        {
            SNO = serialNumber;
            ProductName = productName;
            Sum = Math.Round(sum, 3);
        }

        #endregion
    }
    #endregion
}


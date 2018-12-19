#region Copyright Syncfusion Inc. 2001 - 2009
//
//  Copyright Syncfusion Inc. 2001 - 2009. All rights reserved.
//
//  Use of this code is subject to the terms of our license.
//  A copy of the current license can be obtained at any time by e-mailing
//  licensing@syncfusion.com. Re-distribution in any form is strictly
//  prohibited. Any infringement will be prosecuted under applicable laws. 
//
#endregion

using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlServerCe;
using Syncfusion.Licensing;
using Syncfusion.Pdf;
using Syncfusion.Windows.Forms;
using Syncfusion.Pdf.Graphics;
using Syncfusion.Pdf.Grid;

namespace EssentialPDFSamples
{
    /// <summary>
    /// Summary description for Form1.
    /// </summary>
    public class Form1 : MetroForm
    {
        # region Private methods
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private ListBox lstCustomerId;
        private Label label2;
        private GroupBox groupBox1;
        string y, shipName, address, shipCity, shipCountry, shippedDate;
        Double x, total = 0, ftotal = 0, freight;
        int k = 0;
        private string DEF_DB_COMMAND2 = "select OrderID from SyncOrders Order By OrderID";
        
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.Container components = null;
        # endregion

        # region Constructor
        public Form1()
        {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();
            this.MinimizeBox = true;
            //
            // TODO: Add any constructor code after InitializeComponent call
            //
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lstCustomerId = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            //this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(241, 81);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Generate Invoice";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(1, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(374, 65);
            this.label1.TabIndex = 1;
            this.label1.Text = "Click the button to view an PDF document generated by Essential PDF.  Please note" +
                " that Adobe Reader or its equivalent is required to view the resultant document." +
                "";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
             this.pictureBox1.Image = System.Drawing.Image.FromFile(GetFullTemplatePath("pdf_header.png", true));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(375, 89);
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // lstCustomerId
            // 
            this.lstCustomerId.FormattingEnabled = true;
            this.lstCustomerId.Location = new System.Drawing.Point(9, 41);
            this.lstCustomerId.Name = "lstCustomerId";
            this.lstCustomerId.Size = new System.Drawing.Size(221, 95);
            this.lstCustomerId.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Select an ID from the list";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lstCustomerId);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(5, 160);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(367, 138);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Invoice";
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(375, 317);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
               this.Icon = System.Drawing.Icon.ExtractAssociatedIcon(GetFullTemplatePath("syncfusion.ico", true));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Invoice";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }
        #endregion

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
			SyncfusionLicenseProvider.RegisterLicense(DemoCommon.FindLicenseKey());
            Application.EnableVisualStyles();
            Application.Run(new Form1());
        }
        # endregion

        # region Events
        private void button1_Click(object sender, System.EventArgs e)
        {
            try
            {
                // Generate Invoice for the selected ID.
                GeneratePDF((int)lstCustomerId.SelectedItem);

                //Message box confirmation to view the created PDF document.
                if (MessageBox.Show("Do you want to view the PDF file?", "PDF File Created",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Information)
                    == DialogResult.Yes)
                {
                    //Launching the PDF file using the default Application.[Acrobat Reader]
                    System.Diagnostics.Process.Start("Sample.pdf");
                    this.Close();
                }
                else
                {
                    // Exit
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        /// <summary>
        /// Updates the list box with the order id.
        /// </summary>
        private void Form1_Load(object sender, EventArgs e)
        {
            //Create dataset with the "Customers" table from Northwind database
            DataSet dataSet = GetNorthwindDataSet(DEF_DB_COMMAND2);

            //Create datatable
            DataTable dt = dataSet.Tables[0];

            // Add Customer ID to the list box.
            foreach (DataRow row in dt.Rows)
                lstCustomerId.Items.Add(row["OrderID"]);
            lstCustomerId.SelectedIndex = 0;
        }
        # endregion

        # region Helpher Methods
        /// <summary>
        /// Creates PDF document.
        /// </summary>
        private void GeneratePDF(int id)
        {
            PdfDocument document = new PdfDocument();
            document.PageSettings.Orientation = PdfPageOrientation.Landscape;
            document.PageSettings.Margins.All = 50;
            PdfPage page = document.Pages.Add();
            PdfGraphics g = page.Graphics;
            PdfTextElement element = new PdfTextElement("Northwind Traders\n67, rue des Cinquante Otages,\nElgin,\nUnites States.");
            element.Font = new PdfStandardFont(PdfFontFamily.TimesRoman, 12);
            element.Brush = new PdfSolidBrush(new PdfColor(89, 89, 93));
            PdfLayoutResult result = element.Draw(page, new RectangleF(0, 0, page.Graphics.ClientSize.Width / 2, 200));

            PdfImage img = PdfImage.FromFile(GetFullTemplatePath("logo.jpg", true));
            page.Graphics.DrawImage(img, new RectangleF(g.ClientSize.Width - 200, result.Bounds.Y, 190, 45));
            PdfFont subHeadingFont = new PdfStandardFont(PdfFontFamily.TimesRoman, 14);
            g.DrawRectangle(new PdfSolidBrush(new PdfColor(126, 151, 173)), new RectangleF(0, result.Bounds.Bottom + 40, g.ClientSize.Width, 30));
            element = new PdfTextElement("INVOICE " + id.ToString(), subHeadingFont);
            element.Brush = PdfBrushes.White;
            result = element.Draw(page, new PointF(10, result.Bounds.Bottom + 48));
            string currentDate = "DATE " + DateTime.Now.ToString("MM/dd/yyyy");
            SizeF textSize = subHeadingFont.MeasureString(currentDate);
            g.DrawString(currentDate, subHeadingFont, element.Brush, new PointF(g.ClientSize.Width - textSize.Width - 10, result.Bounds.Y));

            element = new PdfTextElement("BILL TO ", new PdfStandardFont(PdfFontFamily.TimesRoman, 10));
            element.Brush = new PdfSolidBrush(new PdfColor(126, 155, 203));
            result = element.Draw(page, new PointF(10, result.Bounds.Bottom + 25));

            g.DrawLine(new PdfPen(new PdfColor(126, 151, 173), 0.70f), new PointF(0, result.Bounds.Bottom + 3), new PointF(g.ClientSize.Width, result.Bounds.Bottom + 3));

            //Get the product table details
            DataTable shipTable = GetShipDetails(id);
            //Get the order details
            GetProductTable(shipTable);

            element = new PdfTextElement(shipName, new PdfStandardFont(PdfFontFamily.TimesRoman, 10));
            element.Brush = new PdfSolidBrush(new PdfColor(89, 89, 93));
            result = element.Draw(page, new RectangleF(10, result.Bounds.Bottom + 5, g.ClientSize.Width / 2, 100));

            element = new PdfTextElement(string.Format("{0}, {1}, {2}", address, shipCity, shipCountry), new PdfStandardFont(PdfFontFamily.TimesRoman, 10));
            element.Brush = new PdfSolidBrush(new PdfColor(89, 89, 93));
            result = element.Draw(page, new RectangleF(10, result.Bounds.Bottom + 3, g.ClientSize.Width / 2, 100));

            PdfGrid grid = new PdfGrid();
            grid.DataSource = GetProductDetails(id);
            PdfGridCellStyle cellStyle = new PdfGridCellStyle();
            cellStyle.Borders.All = PdfPens.White;
            PdfGridRow header = grid.Headers[0];

            PdfGridCellStyle headerStyle = new PdfGridCellStyle();
            headerStyle.Borders.All = new PdfPen(new PdfColor(126, 151, 173));
            headerStyle.BackgroundBrush = new PdfSolidBrush(new PdfColor(126, 151, 173));
            headerStyle.TextBrush = PdfBrushes.White;
            headerStyle.Font = new PdfStandardFont(PdfFontFamily.TimesRoman, 14f, PdfFontStyle.Regular);

            for (int i = 0; i < header.Cells.Count; i++)
            {
                if (i == 0 || i==1)
                    header.Cells[i].StringFormat = new PdfStringFormat(PdfTextAlignment.Left, PdfVerticalAlignment.Middle);
                else
                    header.Cells[i].StringFormat = new PdfStringFormat(PdfTextAlignment.Right, PdfVerticalAlignment.Middle);
            }

            header.ApplyStyle(headerStyle);
            cellStyle.Borders.Bottom = new PdfPen(new PdfColor(217, 217, 217), 0.70f);
            cellStyle.Font = new PdfStandardFont(PdfFontFamily.TimesRoman, 12f);
            cellStyle.TextBrush = new PdfSolidBrush(new PdfColor(131, 130, 136));
            foreach (PdfGridRow row in grid.Rows)
            {
                row.ApplyStyle(cellStyle);
                for (int i = 0; i < row.Cells.Count; i++)
                {
                    PdfGridCell cell = row.Cells[i];
                    if (i == 1)
                        cell.StringFormat = new PdfStringFormat(PdfTextAlignment.Left, PdfVerticalAlignment.Middle);
                    else if (i == 0)
                        cell.StringFormat = new PdfStringFormat(PdfTextAlignment.Center, PdfVerticalAlignment.Middle);
                    else
                        cell.StringFormat = new PdfStringFormat(PdfTextAlignment.Right, PdfVerticalAlignment.Middle);

                    if (i > 2)
                    {
                        float val = float.MinValue;
                        float.TryParse(cell.Value.ToString(), out val);
                        cell.Value = val.ToString("C");
                    }
                }
            }

            grid.Columns[0].Width = 100;
            grid.Columns[1].Width = 200;

            PdfGridLayoutFormat layoutFormat = new PdfGridLayoutFormat();
            layoutFormat.Layout = PdfLayoutType.Paginate;

            PdfGridLayoutResult gridResult = grid.Draw(page, new RectangleF(new PointF(0, result.Bounds.Bottom + 40), new SizeF(g.ClientSize.Width, g.ClientSize.Height - 100)), layoutFormat);
            float pos = 0.0f;
            for (int i = 0; i < grid.Columns.Count - 1; i++)
                pos += grid.Columns[i].Width;

            PdfFont font = new PdfStandardFont(PdfFontFamily.TimesRoman, 14f);

            gridResult.Page.Graphics.DrawString("Total Due", font, new PdfSolidBrush(new PdfColor(126, 151, 173)), new RectangleF(new PointF(pos, gridResult.Bounds.Bottom + 20), new SizeF(grid.Columns[3].Width - pos, 20)), new PdfStringFormat(PdfTextAlignment.Right));
            gridResult.Page.Graphics.DrawString("Thank you for your business!", new PdfStandardFont(PdfFontFamily.TimesRoman, 12), new PdfSolidBrush(new PdfColor(89, 89, 93)), new PointF(pos - 55, gridResult.Bounds.Bottom + 60));
            pos += grid.Columns[4].Width;
            gridResult.Page.Graphics.DrawString(total.ToString("C"), font, new PdfSolidBrush(new PdfColor(131, 130, 136)), new RectangleF(new PointF(pos, gridResult.Bounds.Bottom + 20), new SizeF(grid.Columns[4].Width - pos, 20)), new PdfStringFormat(PdfTextAlignment.Right));

            //Save and close the document.
            document.Save("Sample.pdf");
            document.Close(true);
        }

        /// <summary>
        /// Returns order details.
        /// </summary>
        private void GetProductTable(DataTable dataTable)
        {
            DataRow dr;
            int rows = dataTable.Rows.Count;
            for (int i = 0; i < rows; i++)
            {
                dr = dataTable.Rows[i];
                shipName = dr["ShipName"].ToString();
                freight = System.Convert.ToDouble(dr["Freight"].ToString());
                address = dr["ShipAddress"].ToString();
                shippedDate = dr["ShippedDate"].ToString();
                shipCity = dr["ShipCity"].ToString();
                shipCountry = dr["ShipCountry"].ToString();
            }
        }

        /// <summary>
        /// Returns the product details for the selected order id.
        /// </summary>
        private DataTable GetProductDetails(int id)
        {
            DEF_DB_COMMAND2 = "select ProductID,ProductName,Quantity,UnitPrice,Discount from SyncOrderDetails where OrderID=" + id;

            //Create dataset with the "Customers" table from Northwind database
            DataSet dataSet = GetNorthwindDataSet(DEF_DB_COMMAND2);

            //Create datatable
            DataTable prodDT = dataSet.Tables[0];

            //Add new column
            prodDT.Columns.Add(new DataColumn("Price", typeof(String)));

            DEF_DB_COMMAND2 = "select Quantity,UnitPrice from SyncOrderDetails where OrderID=" + id;

            //Create dataset with the "Customers" table from Northwind database
            DataSet dataSet1 = GetNorthwindDataSet(DEF_DB_COMMAND2);

            //Create datatable
            DataTable dt = dataSet1.Tables[0];

            DataRow dr;
            int rows = dt.Rows.Count;
            for (int i = 0; i < rows; i++)
            {
                dr = dt.Rows[i];
                x = System.Convert.ToDouble(dr["Quantity"].ToString()) * System.Convert.ToDouble(dr["UnitPrice"].ToString());
                dr = prodDT.Rows[k];
                y = x.ToString();
                dr["Price"] = y.ToString();
                k++;

                total = total + x;
            }
            return prodDT;
        }
       
        /// <summary>
        /// Returns data from Orders Table.
        /// </summary>
        private DataTable GetShipDetails(int TestOrderId)
        {
            DEF_DB_COMMAND2 = String.Format("SELECT ShipName,ShipAddress,Freight,ShippedDate,ShipCity,ShipCountry from Orders where OrderID={0}", TestOrderId);

            //Create dataset with the "Customers" table from Northwind database
            DataSet dataSet = GetNorthwindDataSet(DEF_DB_COMMAND2);

            //Create datatable
            DataTable dt = dataSet.Tables[0];

            return dt;
        }

        /// <summary>
        /// Returns the dataset requested in connection string.
        /// </summary>
        private DataSet GetNorthwindDataSet(string selectCommand)
        {
            DataSet dataSet = new DataSet();
            try
            {
                AppDomain.CurrentDomain.SetData("SQLServerCompactEditionUnderWebHosting", true);
                SqlCeConnection connection = new SqlCeConnection();
                if (connection.ServerVersion.StartsWith("3.5"))
                    connection.ConnectionString = "Data Source = " + GetFullTemplatePath("NorthwindIO_3.5.sdf", false);
                else
                    connection.ConnectionString = "Data Source = " + GetFullTemplatePath("NorthwindIO.sdf", false);
                connection.Open();
                SqlCeDataAdapter adapter = new SqlCeDataAdapter(DEF_DB_COMMAND2, connection);
                adapter.Fill(dataSet);
            }
            catch (Exception)
            {
                MessageBox.Show("Cannot load DataSet!", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }

            return dataSet;
        }

        /// <summary>
        /// Gets the full path of the PDF template or image.
        /// </summary>
        /// <param name="fileName">Name of the file</param>
        /// <param name="image">True if image</param>
        /// <returns>Path of the file</returns>
        private string GetFullTemplatePath(string fileName, bool image)
        {
            string fullPath = @"..\..\..\..\..\..\..\Common\";
            string folder = image ? @"Images\PDF" : "Data";

            return string.Format(@"{0}{1}\{2}", fullPath, folder, fileName);
        }
        # endregion
    }
	/// <summary>
    /// Represents a class that is used to find the licensing file for Syncfusion controls.
    /// </summary>
    public class DemoCommon
    {

        /// <summary>
        /// Finds the license key from the Common folder.
        /// </summary>
        /// <returns>Returns the license key.</returns>
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
                return System.IO.File.ReadAllText(licenseKeyFile);
            }
            return string.Empty;
        }
    }
}
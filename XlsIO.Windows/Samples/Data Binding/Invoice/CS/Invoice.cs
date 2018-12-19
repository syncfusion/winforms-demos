#region Copyright Syncfusion Inc. 2001 - 2014
//
//  Copyright Syncfusion Inc. 2001 - 2014. All rights reserved.
//
//  Use of this code is subject to the terms of our license.
//  A copy of the current license can be obtained at any time by e-mailing
//  licensing@syncfusion.com. Any infringement will be prosecuted under
//  applicable laws. 
//
#endregion

using System;
using System.Windows.Forms;
using System.Data;
using Syncfusion.XlsIO;
using System.Data.SqlServerCe;
using Syncfusion.Windows.Forms;
using Syncfusion.Licensing;
using System.IO;
namespace EssentialXlsIOSamples
{
    /// <summary>
    /// Summary description for Invoice.
    /// </summary>
    public class Invoice : MetroForm
    {
        #region Constants
        private const string DEFAULTPATH = @"..\..\..\..\..\..\..\Common\Data\XlsIO\{0}";
        #endregion

        #region Fields
        private System.Windows.Forms.Label label2;
        string shipName, address, shipCity, shipCountry;
        Double freight;
        string shippedDate;
        private string fileName;
        private System.Windows.Forms.ListBox listBoxCustomer;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCreate;
        private PictureBox pictureBox1;
        private Label label1;
        public readonly static string connString = @"Data Source=..\..\..\..\..\..\..\Common\Data\NorthwindIO.sdf";
        public readonly static string connString_35 = @"Data Source=..\..\..\..\..\..\..\Common\Data\NorthwindIO_3.5.sdf";
        private GroupBox groupBox2;
        private RadioButton excel2010RadioBtn;
        private RadioButton excel2007RadioBtn;
        private RadioButton excel2003RadioBtn;
        private RadioButton excel2013RadioBtn;

        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.Container components = null;
        #endregion

        #region Initialize
        public Invoice()
        {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();
            this.excel2013RadioBtn.Checked = true;
            //
            // TODO: Add any constructor code after InitializeComponent call
            //
        }
        #endregion

        #region Form Load
        private void Form1_Load(object sender, System.EventArgs e)
        {
            SqlCeConnection con = new SqlCeConnection();
            SqlCeDataAdapter dataAdapter = null;
            if(con.ServerVersion.StartsWith("3.5"))
              dataAdapter   = new SqlCeDataAdapter("Select OrderID from Orders Order By OrderID", connString_35);
            else
              dataAdapter = new SqlCeDataAdapter("Select OrderID from Orders Order By OrderID", connString);
            DataSet orderDS = new DataSet();
            dataAdapter.Fill(orderDS);
            // Add Customer ID to the list box.
            foreach (DataRow row in orderDS.Tables[0].Rows)
                listBoxCustomer.Items.Add(row["OrderID"]);
        }
        #endregion

        #region Create SpreadSheet for Selected Id
        private void btnCreate_Click(object sender, System.EventArgs e)
        {
            try
            {

                #region Generate Invoice for the selected ID.
                GenerateXls((int)listBoxCustomer.SelectedItem);
                #endregion

                #region View the Workbook
                //Message box confirmation to view the created xls document.
                if (MessageBox.Show("Do you want to view the Output file?", "Excel File Created",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Information)
                    == DialogResult.Yes)
                {
                    //Launching the PDF file using the default Application.[Acrobat Reader]
                    System.Diagnostics.Process.Start(fileName);
                    this.Close();
                }
                else
                {
                    // Exit
                    this.Close();
                }
                #endregion
            }
            catch (Exception)
            {
                // Shows the Message box with Exception message, if an exception is thrown.
                MessageBox.Show("Please Select the Customer ID From ListBox", "Report", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void GenerateXls(int id)
        {
            #region Initialize Workbook
            //New instance of XlsIO is created.[Equivalent to launching MS Excel with no workbooks open].
            //The instantiation process consists of two steps.

            //Step 1 : Instantiate the spreadsheet creation engine.
            ExcelEngine excelEngine = new ExcelEngine();

            //Step 2 : Instantiate the excel application object.
            IApplication application = excelEngine.Excel;
            IWorkbook workbook;

            string inputPath;
            if (this.excel2003RadioBtn.Checked)
            {
                //Indicates the Path of the Input File
                inputPath = GetFullTemplatePath("Invoice.xls");
                workbook = application.Workbooks.Open(inputPath);
            }
            else
            {//Indicates the Path of the Input File
                inputPath = GetFullTemplatePath("Invoice.xlsx");
                workbook = application.Workbooks.Open(inputPath, ExcelOpenType.Automatic);
            }

            IWorksheet worksheet = workbook.Worksheets[0];
            #endregion

            #region Insert data
            worksheet.Range["A5"].Text = "One Portals Way";
            worksheet.Range["A6"].Text = "Twin Points WA 98156";
            worksheet.Range["A7"].Text = "Phone: 1-206-555-1417 ";
            worksheet.Range["A8"].Text = "Fax: 1-206-555-5938";

            worksheet.Range["D5"].Text = "INVOICE NO:";
            worksheet.Range["D6"].Text = "DATE:";
            worksheet.Range["D7"].Text = "CUSTOMER ID  :";
            worksheet.Range["E6"].Formula = "TODAY()";

            worksheet.Range["E5"].Number = id;

            //Set values for Ship To.
            GetShipDetails(id);
            worksheet.Range["E7"].Text = shipName;
            worksheet.Range["E10"].Text = shipName;
            worksheet.Range["E11"].Text = address;
            worksheet.Range["E12"].Text = shipCity;
            worksheet.Range["E13"].Text = shipCountry;

            //Set values for Bill To.
            worksheet.Range["B10"].Text = shipName;
            worksheet.Range["B11"].Text = address;
            worksheet.Range["B12"].Text = shipCity;
            worksheet.Range["B13"].Text = shipCountry;

            //Calculates sub total
            worksheet.Range["E27"].Formula = "SUM(E20:E26)";

            //Set the number format
            worksheet.Range["E20:E29"].NumberFormat = "$#,##0.00";
            worksheet.Range["E28"].Value = freight.ToString();

            //Calculates final total
            worksheet.Range["E29"].Formula = "E27+E28";

            //Import the data tables.
            worksheet.ImportDataTable(GetOrder(id), false, 17, 1);
            worksheet.ImportDataTable(GetProductDetails(id), false, 20, 1);

            //Calculates price from discount and unit price.
            for (int i = 20; i <= 26; i++)
            {
                if (worksheet.Range["A" + i.ToString()].Value == "")
                {
                    break;
                }
                else
                {
                    worksheet.Range["E" + i.ToString()].Formula = "(B" + i.ToString() + "*C" + i.ToString() + ")- (D" + i.ToString() + "/100)";
                }
            }
            #endregion

            #region Save the Workbook
            //Set the Workbook version as Excel 97to2003
            if (this.excel2003RadioBtn.Checked)
            {
                workbook.Version = ExcelVersion.Excel97to2003;
                fileName = "InvoiceOutput.xls";
            }
            //Set the Workbook version as Excel 2007
            else if (this.excel2007RadioBtn.Checked)
            {
                workbook.Version = ExcelVersion.Excel2007;
                fileName = "InvoiceOutput.xlsx";
            }
            //Set the Workbook version as Excel 2010
            else if (this.excel2010RadioBtn.Checked)
            {
                workbook.Version = ExcelVersion.Excel2010;
                fileName = "InvoiceOutput.xlsx";
            }
            //Set the Workbook version as Excel 2010
            else if (this.excel2013RadioBtn.Checked)
            {
                workbook.Version = ExcelVersion.Excel2013;
                fileName = "InvoiceOutput.xlsx";
            }
            //Save the workbook to disk.
            workbook.SaveAs(fileName);
            #endregion

            #region Workbook Close and Dispose
            //Close the workbook.
            workbook.Close();

            //No exception will be thrown if there are unsaved workbooks.
            excelEngine.ThrowNotSavedOnDestroy = false;
            excelEngine.Dispose();
            #endregion

        }

        #endregion

        #region HelperMethods
        /// <summary>
        /// return the product details for given id.
        /// </summary>
        /// <param name="id">Customer id</param>
        /// <returns>product details</returns>
        private DataTable GetProductDetails(int id)
        {
            SqlCeConnection con = new SqlCeConnection();
            SqlCeDataAdapter dataAdapter = null;
            if(con.ServerVersion.StartsWith("3.5"))
               dataAdapter = new SqlCeDataAdapter("Select ProductID,Quantity,UnitPrice,Discount from SyncOrderDetails where OrderID=" + id, connString_35);
            else
                dataAdapter = new SqlCeDataAdapter("Select ProductID,Quantity,UnitPrice,Discount from SyncOrderDetails where OrderID=" + id, connString);
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet);

            DataTable prodDataTable = new DataTable();
            prodDataTable = dataSet.Tables[0];
            return prodDataTable;
        }
        /// <summary>
        /// Ship details for given id
        /// </summary>
        /// <param name="id">Customer id</param>
        private void GetShipDetails(int id)
        {
            SqlCeConnection con = new SqlCeConnection();
            SqlCeDataAdapter dataAdapter = null;
            if(con.ServerVersion.StartsWith("3.5"))
              dataAdapter = new SqlCeDataAdapter("Select ShipName,ShipAddress,Freight,ShippedDate,ShipCity,ShipCountry from Orders where OrderID=" + id, connString_35);
            else
                dataAdapter = new SqlCeDataAdapter("Select ShipName,ShipAddress,Freight,ShippedDate,ShipCity,ShipCountry from Orders where OrderID=" + id, connString);
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet);

            DataTable dataTable = new DataTable();
            dataTable = dataSet.Tables[0];
            DataRow dataRow;
            int rows = dataTable.Rows.Count;
            for (int i = 0; i < rows; i++)
            {
                dataRow = dataTable.Rows[i];
                shipName = dataRow["ShipName"].ToString();
                freight = System.Convert.ToDouble(dataRow["Freight"].ToString());
                address = dataRow["ShipAddress"].ToString();
                shippedDate = dataRow["ShippedDate"].ToString();
                shipCity = dataRow["ShipCity"].ToString();
                shipCountry = dataRow["ShipCountry"].ToString();
            }
        }
        /// <summary>
        /// return order details for given id
        /// </summary>
        /// <param name="id">Customer id</param>
        /// <returns>order details</returns>
        private DataTable GetOrder(int id)
        {
            DataTable dataTable = new DataTable();
             SqlCeConnection con = new SqlCeConnection();
            SqlCeDataAdapter dataAdapter = null;
            if(con.ServerVersion.StartsWith("3.5"))
             dataAdapter = new SqlCeDataAdapter("Select Salesperson,ShipName,ShipCountry,CustomerID,OrderDate,RequiredDate from SyncOrders where OrderID=" + id, connString_35);
            else
                dataAdapter = new SqlCeDataAdapter("Select Salesperson,ShipName,ShipCountry,CustomerID,OrderDate,RequiredDate from SyncOrders where OrderID=" + id, connString);
            
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet);
            dataTable = dataSet.Tables[0];

            return dataTable;
        }


        /// <summary>
        /// Get the file path of input file and return the same
        /// </summary>
        /// <param name="inputPath">Input file</param>
        /// <returns>path of the input file</returns>
        private string GetFullTemplatePath(string inputFile)
        {
            return string.Format(DEFAULTPATH, inputFile);
        }
        #endregion

        #region Windows Form Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Invoice));
            this.listBoxCustomer = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.excel2013RadioBtn = new System.Windows.Forms.RadioButton();
            this.excel2010RadioBtn = new System.Windows.Forms.RadioButton();
            this.excel2007RadioBtn = new System.Windows.Forms.RadioButton();
            this.excel2003RadioBtn = new System.Windows.Forms.RadioButton();
            this.btnCreate = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxCustomer
            // 
            this.listBoxCustomer.Location = new System.Drawing.Point(347, 26);
            this.listBoxCustomer.Name = "listBoxCustomer";
            this.listBoxCustomer.Size = new System.Drawing.Size(116, 95);
            this.listBoxCustomer.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(263, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Select Customer ID from the list box";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.btnCreate);
            this.groupBox1.Controls.Add(this.listBoxCustomer);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(3, 157);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(472, 129);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Invoice";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.excel2013RadioBtn);
            this.groupBox2.Controls.Add(this.excel2010RadioBtn);
            this.groupBox2.Controls.Add(this.excel2007RadioBtn);
            this.groupBox2.Controls.Add(this.excel2003RadioBtn);
            this.groupBox2.Location = new System.Drawing.Point(9, 53);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(329, 37);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Save As";
            // 
            // excel2013RadioBtn
            // 
            this.excel2013RadioBtn.AutoSize = true;
            this.excel2013RadioBtn.Location = new System.Drawing.Point(245, 13);
            this.excel2013RadioBtn.Name = "excel2013RadioBtn";
            this.excel2013RadioBtn.Size = new System.Drawing.Size(78, 17);
            this.excel2013RadioBtn.TabIndex = 3;
            this.excel2013RadioBtn.Text = "Excel 2013";
            this.excel2013RadioBtn.UseVisualStyleBackColor = true;
            // 
            // excel2010RadioBtn
            // 
            this.excel2010RadioBtn.AutoSize = true;
            this.excel2010RadioBtn.Location = new System.Drawing.Point(164, 13);
            this.excel2010RadioBtn.Name = "excel2010RadioBtn";
            this.excel2010RadioBtn.Size = new System.Drawing.Size(78, 17);
            this.excel2010RadioBtn.TabIndex = 2;
            this.excel2010RadioBtn.Text = "Excel 2010";
            this.excel2010RadioBtn.UseVisualStyleBackColor = true;
            // 
            // excel2007RadioBtn
            // 
            this.excel2007RadioBtn.AutoSize = true;
            this.excel2007RadioBtn.Location = new System.Drawing.Point(85, 13);
            this.excel2007RadioBtn.Name = "excel2007RadioBtn";
            this.excel2007RadioBtn.Size = new System.Drawing.Size(78, 17);
            this.excel2007RadioBtn.TabIndex = 1;
            this.excel2007RadioBtn.Text = "Excel 2007";
            this.excel2007RadioBtn.UseVisualStyleBackColor = true;
            // 
            // excel2003RadioBtn
            // 
            this.excel2003RadioBtn.AutoSize = true;
            this.excel2003RadioBtn.Checked = true;
            this.excel2003RadioBtn.Location = new System.Drawing.Point(6, 13);
            this.excel2003RadioBtn.Name = "excel2003RadioBtn";
            this.excel2003RadioBtn.Size = new System.Drawing.Size(78, 17);
            this.excel2003RadioBtn.TabIndex = 0;
            this.excel2003RadioBtn.TabStop = true;
            this.excel2003RadioBtn.Text = "Excel 2003";
            this.excel2003RadioBtn.UseVisualStyleBackColor = true;
            // 
            // btnCreate
            // 
            this.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCreate.Location = new System.Drawing.Point(248, 96);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(90, 25);
            this.btnCreate.TabIndex = 0;
            this.btnCreate.Text = "Create";
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(639, 71);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 63;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(0, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(475, 48);
            this.label1.TabIndex = 71;
            this.label1.Text = "Click the button to view an Excel spreadsheet generated by Essential XlsIO. Pleas" +
                "e note that MS Excel Viewer or MS Excel is required to view the resultant docume" +
                "nt.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Invoice
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(478, 288);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Invoice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Invoice";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        #region Dispose
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

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
			SyncfusionLicenseProvider.RegisterLicense(DemoCommon.FindLicenseKey());
            Application.Run(new Invoice());
        }
        #endregion
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
                return File.ReadAllText(licenseKeyFile);
            }
            return string.Empty;
        }
    }
}
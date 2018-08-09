#region Copyright Syncfusion Inc. 2001 - 2007
//
//  Copyright Syncfusion Inc. 2001 - 2007. All rights reserved.
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
using System.Data.OleDb;
using System.IO;
using Syncfusion.Windows.Forms;
using Syncfusion.Licensing;
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
        private string fileName;
        private System.Windows.Forms.ListBox listBoxCustomer;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCreate;
        private PictureBox pictureBox1;
        private Label label1;
        
        
        private GroupBox groupBox2;
        private RadioButton excel2010RadioBtn;
        private RadioButton excel2007RadioBtn;
        private RadioButton excel2013RadioBtn;
        private CheckBox refresh;

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
            string path=Path.GetFullPath(@"..\..\..\..\..\..\..\Common\Data\Northwind.mdb");
            OleDbConnection connection = new OleDbConnection();
            connection.ConnectionString = "Provider=Microsoft.JET.OLEDB.4.0;Password=\"\";User ID=Admin;Data Source="+ path;
            connection.Open();
            OleDbCommand query = new OleDbCommand("select country from customers", connection);
            OleDbDataAdapter adapter = new OleDbDataAdapter(query);
            DataSet Country = new DataSet();
            adapter.Fill(Country);
            // Add Country to the list box.
            foreach (DataRow row in Country.Tables[0].Rows)
            {
                if (!listBoxCustomer.Items.Contains(row["country"]))
                {
                listBoxCustomer.Items.Add(row["country"]);
                }
            }
            connection.Close();
            connection.Dispose();
            query.Dispose();
            adapter.Dispose();
            Country.Dispose();
        }
        #endregion

        #region Create SpreadSheet for Selected Id
        private void btnCreate_Click(object sender, System.EventArgs e)
        {
            try
            {

                #region Generate Invoice for the selected ID.
                GenerateXls(listBoxCustomer.SelectedItems);
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                // Shows the Message box with Exception message, if an exception is thrown.
                MessageBox.Show("Please Select the Country From ListBox", "Report", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void GenerateXls(ListBox.SelectedObjectCollection selctedcountry)
        {
            #region Initialize Workbook
            //New instance of XlsIO is created.[Equivalent to launching MS Excel with no workbooks open].

            //Step 1 : Instantiate the spreadsheet creation engine.
            ExcelEngine excelEngine = new ExcelEngine();
            //Step 2 : Instantiate the excel application object.
            IApplication application = excelEngine.Excel;
            //Create the workbook with default sheet
            IWorkbook workbook = application.Workbooks.Create();
            //Get the 1st sheet from the workbook
            IWorksheet sheet = workbook.Worksheets[0];
            string path=Path.GetFullPath(@"..\..\..\..\..\..\..\Common\Data\Northwind.mdb");
            //connection string for DataSource
            string ConnectionString = "OLEDB;Provider=Microsoft.JET.OLEDB.4.0;Password=\"\";User ID=Admin;Data Source=" + path;
            //query for the datasource
            string query; string countries = string.Empty;
            if (selctedcountry.Count>0)
            {
                countries = "'"+selctedcountry[0].ToString()+"'";
                for (int i = 0; i < selctedcountry.Count; i++)
                {                    
                    countries = countries + "," + "'"+selctedcountry[i]+"'";
                }                
                query = "select * from Customers where country in(" + countries + ");";
            }
            else
                query = "select * from Customers";
            //Add the connection to workbook
            IConnection Connection = workbook.Connections.Add("Connection1", "Sample connection with MsAccess", ConnectionString, query, ExcelCommandType.Sql);
            //Add the QueryTable to sheet object
            sheet.ListObjects.AddEx(ExcelListObjectSourceType.SrcQuery, Connection, sheet.Range["A1"]);
            #endregion

            #region Refresh the Connection
            //Refresh the Connection for include the data            
            if (refresh.Checked)
            {
                try
                {

                    sheet.ListObjects[0].Refresh();
                    sheet.UsedRange.AutofitColumns();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            #endregion

            #region Save the Workbook
            //Set the Workbook version as excel 2007
             if (this.excel2007RadioBtn.Checked)
            {
                workbook.Version = ExcelVersion.Excel2007;
                fileName = "ExternalConnection.xlsx";
            }
            //Set the Workbook version as Excel 2010
            else if (this.excel2010RadioBtn.Checked)
            {
                workbook.Version = ExcelVersion.Excel2010;
                fileName = "ExternalConnection.xlsx";
            }
            //Set the Workbook version as Excel 2010
            else if (this.excel2013RadioBtn.Checked)
            {
                workbook.Version = ExcelVersion.Excel2013;
                fileName = "ExternalConnection.xlsx";
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
            this.refresh = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.excel2013RadioBtn = new System.Windows.Forms.RadioButton();
            this.excel2010RadioBtn = new System.Windows.Forms.RadioButton();
            this.excel2007RadioBtn = new System.Windows.Forms.RadioButton();
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
            this.listBoxCustomer.Location = new System.Drawing.Point(9, 38);
            this.listBoxCustomer.Name = "listBoxCustomer";
            this.listBoxCustomer.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBoxCustomer.Size = new System.Drawing.Size(127, 95);
            this.listBoxCustomer.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(321, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "select countries from the list box (optional)";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.refresh);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.btnCreate);
            this.groupBox1.Controls.Add(this.listBoxCustomer);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(3, 157);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(426, 139);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "External Connection";
            // 
            // refresh
            // 
            this.refresh.AutoSize = true;
            this.refresh.Location = new System.Drawing.Point(152, 98);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(63, 17);
            this.refresh.TabIndex = 5;
            this.refresh.Text = "Refresh";
            this.refresh.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.excel2013RadioBtn);
            this.groupBox2.Controls.Add(this.excel2010RadioBtn);
            this.groupBox2.Controls.Add(this.excel2007RadioBtn);
            this.groupBox2.Location = new System.Drawing.Point(152, 38);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(253, 37);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Save As";
            // 
            // excel2013RadioBtn
            // 
            this.excel2013RadioBtn.AutoSize = true;
            this.excel2013RadioBtn.Location = new System.Drawing.Point(168, 14);
            this.excel2013RadioBtn.Name = "excel2013RadioBtn";
            this.excel2013RadioBtn.Size = new System.Drawing.Size(78, 17);
            this.excel2013RadioBtn.TabIndex = 3;
            this.excel2013RadioBtn.Text = "Excel 2013";
            this.excel2013RadioBtn.UseVisualStyleBackColor = true;
            // 
            // excel2010RadioBtn
            // 
            this.excel2010RadioBtn.AutoSize = true;
            this.excel2010RadioBtn.Location = new System.Drawing.Point(90, 14);
            this.excel2010RadioBtn.Name = "excel2010RadioBtn";
            this.excel2010RadioBtn.Size = new System.Drawing.Size(78, 17);
            this.excel2010RadioBtn.TabIndex = 2;
            this.excel2010RadioBtn.Text = "Excel 2010";
            this.excel2010RadioBtn.UseVisualStyleBackColor = true;
            // 
            // excel2007RadioBtn
            // 
            this.excel2007RadioBtn.AutoSize = true;
            this.excel2007RadioBtn.Location = new System.Drawing.Point(6, 14);
            this.excel2007RadioBtn.Name = "excel2007RadioBtn";
            this.excel2007RadioBtn.Size = new System.Drawing.Size(78, 17);
            this.excel2007RadioBtn.TabIndex = 1;
            this.excel2007RadioBtn.Text = "Excel 2007";
            this.excel2007RadioBtn.UseVisualStyleBackColor = true;
            // 
            // btnCreate
            // 
            this.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCreate.Location = new System.Drawing.Point(315, 98);
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
            this.label1.Location = new System.Drawing.Point(0, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(433, 48);
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
            this.ClientSize = new System.Drawing.Size(431, 296);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Invoice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "External Connection";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
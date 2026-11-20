using Syncfusion.WinForms.DataGrid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DetailsViewDataTableBinding
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.sfDataGrid1.DataSource = GetDataTable();
            this.Load += Form1_Load;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.sfDataGrid1.ExpandAllDetailsView();
        }

        /// <summary>
        /// Gets the data table.
        /// </summary>
        /// <returns></returns>
        public DataTable GetDataTable()
        {
            DataSet ds = new DataSet();

            string fileName = FindFile("Northwind.mdf");
            string connectionString = string.Format(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={0};Integrated Security=True;Connect Timeout=30", fileName);
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Suppliers", con);
                sda.Fill(ds, "Suppliers");
            }

            using (SqlConnection con1 = new SqlConnection(connectionString))
            {
                con1.Open();
                SqlDataAdapter sda1 = new SqlDataAdapter("SELECT * FROM Products", con1);
                sda1.Fill(ds, "Products");
            }

            ds.Relations.Add(new DataRelation("Supplier_Product", ds.Tables[0].Columns["Supplier ID"], ds.Tables[1].Columns["Supplier ID"]));

            if (ds.Tables.Count > 0)
                return ds.Tables[0];
            else
                return null;
        }

        /// <summary>
        /// Finds the datasource file.
        /// </summary>
        /// <param name="fileName">Name of the file</param>
        /// <returns>Location string.</returns>
        private static string FindFile(string fileName)
        {
            // Check both in parent folder and Parent\Data folders.
            string dataFileName = @"Common\Data\" + fileName;
            for (int n = 0; n < 12; n++)
            {
                if (System.IO.File.Exists(fileName))
                {
                    return new FileInfo(fileName).FullName;
                }
                if (System.IO.File.Exists(dataFileName))
                {
                    return new FileInfo(dataFileName).FullName;
                }
                fileName = @"..\" + fileName;
                dataFileName = @"..\" + dataFileName;
            }

            return fileName;
        }
    }
}

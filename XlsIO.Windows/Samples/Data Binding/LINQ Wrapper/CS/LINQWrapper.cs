using System;
using System.Linq;
using System.Windows.Forms;
using Syncfusion.XlsIO;
using Syncfusion.Windows.Forms;

namespace EssentialXlsIOSample
{
    public partial class LINQWrapper : MetroForm
    {
        #region Initailize
        public LINQWrapper()
        {
            InitializeComponent();
            this.cmbName.SelectedIndex = 0;
        }
        #endregion

        #region Using LINQWrapper
        private void btnQueryData_Click(object sender, EventArgs e)
        {
            #region Workbook Initialize
            ExcelEngine excelEngine = new ExcelEngine();
            IApplication application = excelEngine.Excel;
            IWorkbook workbook = application.Workbooks.Open(@"../../template.xls");
            IWorksheet worksheet = workbook.Worksheets[0];
            #endregion

            #region Using LINQ Query to retrieve data
            
            //Define the Name for Ranges
            IName name = worksheet.Names.Add("FirstName");
            name.RefersToRange = worksheet["B5:B12"];

            string result = string.Empty;
            string foundDetails = string.Empty;
            
            //Option to get range by Name
            var matchingRanges = from IRange s in worksheet["FirstName"]
                                 where s.Text == cmbName.SelectedItem.ToString()
                                 select s;

            foreach (var range in matchingRanges)
            {
                result = range.Text + " Found at:" + range.Address + "\r\nCell Color:" + range.CellStyle.Color;
                foundDetails = range.Text;
            }
            #endregion

            #region Save the Workbook
            workbook.SaveAs("LINQWrapper.xls");
            workbook.Close();
            txtResult.Text = result + "\r\nSheet name is renamed as " + worksheet.Name;
            #endregion

            #region Opening Existing Workbook
            //Use XlsIO to write the queried data
            workbook = application.Workbooks.Open("LINQWrapper.xls");

            workbook.Worksheets[0].Range["C17"].Text = foundDetails + " is found";
            #endregion

            #region Workbook Save and Dispose
            workbook.Save();
            workbook.Close();
            excelEngine.Dispose();
            #endregion

            #region View the Workbook
            //Message box confirmation to view the created spreadsheet.
            if (MessageBox.Show("Do you want to view the workbook?", "Workbook has been created",
                MessageBoxButtons.YesNo, MessageBoxIcon.Information)
                == DialogResult.Yes)
            {
                //Launching the Excel file using the default Application.[MS Excel Or Free ExcelViewer]
                System.Diagnostics.Process.Start("LINQWrapper.xls");
                //Exit
                this.Close();
            }
            else
            {
                // Exit
                this.Close();
            }
            #endregion
        }
        #endregion
    }
}

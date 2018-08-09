using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Syncfusion.XlsIO;
using Syncfusion.Windows.Forms;

namespace EssentailXlsIOSamples
{
    public partial class OleObject : MetroForm
    {
        #region Constants
        private const string DEFAULTIMAGEPATH = @"..\..\..\..\..\..\..\Common\Images\XlsIO\{0}";
        private const string DEFAULTFILEPATH = @"..\..\..\..\..\..\..\Common\Data\XlsIO\{0}";
        #endregion

        #region Initialize
        public OleObject()
        {
            InitializeComponent();
            this.rdbExcel2013.Checked = true;
        }
        #endregion

        #region Using OleObject
        private void btnCreate_Click(object sender, EventArgs e)
        {
            #region Initialize Workbook
            //New instance of XlsIO is created.[Equivalent to launching MS Excel with no workbooks open].
            //The instantiation process consists of two steps.

            //Step 1 : Instantiate the spreadsheet creation engine.
            ExcelEngine excelEngine = new ExcelEngine();
            //Step 2 : Instantiate the excel application object.
            IApplication application = excelEngine.Excel;

            if (this.rdbExcel2007.Checked)
                application.DefaultVersion = ExcelVersion.Excel2007;
            else if (this.rdbExcel2010.Checked)
                application.DefaultVersion = ExcelVersion.Excel2010;
            else
                application.DefaultVersion = ExcelVersion.Excel2013;

            //A new workbook is created.[Equivalent to creating a new workbook in MS Excel]
            //The new workbook will have 3 worksheets
            IWorkbook workbook = application.Workbooks.Create(3);
            //The first worksheet object in the worksheets collection is accessed.
            IWorksheet worksheet = workbook.Worksheets[0];
            #endregion

            #region Get the Path of the Input File
            //Get the Path of the Header Image
            string headerImagePath = GetFullImagePath("header.gif");
            //Get the Path of the PDF file
            string pdfFilePath = GetFullTemplatePath("FaxOrderForm.pdf");
            //Get the path of the PDF Icon
            string pdfIconPath = GetFullImagePath("pdfIcon.jpg");
            //Get the Path of Work file
            string wordFilePath = GetFullTemplatePath("FaxOrderForm.doc");
            //Get the Path of Work Icon
            string wordIconPath = GetFullImagePath("wordIcon.jpg");
            #endregion

            #region Add OleObject into Worksheet
            worksheet.IsGridLinesVisible = false;
            worksheet.Pictures.AddPicture(2, 5, headerImagePath);

            worksheet["E5:M6"].Merge();
            worksheet[5, 5].Text = "Syncfusion accept fax orders from customers worldwide. You can also order online through our secure web server.";
            worksheet[5, 5].WrapText = true;
            //Add Oleobject for PDF file
            worksheet[8, 6].Text = "PDF Order Form";

            IOleObject oleObject1 = worksheet.OleObjects.Add(pdfFilePath, System.Drawing.Image.FromFile(pdfIconPath), OleLinkType.Embed);
            oleObject1.Location = worksheet[8, 11];
            oleObject1.Size = new Size(100, 100);
            //Add OleObject for Word file
            worksheet[17, 6].Text = "Word Order Form";

            IOleObject oleObject2 = worksheet.OleObjects.Add(wordFilePath, System.Drawing.Image.FromFile(wordIconPath), OleLinkType.Embed);
            oleObject2.Location = worksheet[17, 11];
            oleObject2.Size = new Size(100, 100);

            worksheet[25, 5].Text = "Download the order form, print it out and fill in the required information.";
            #endregion

            #region Workbook Save
            if (this.rdbExcel2007.Checked)
                workbook.SaveAs("OleObjectSample.xlsx");
            else if(this.rdbExcel2010.Checked)
                workbook.SaveAs("OleObjectSample.xlsx");
            else
                workbook.SaveAs("OleObjectSample.xlsx");
            #endregion

            #region Workbook Close and Dispose
            //Close the Workbook
            workbook.Close();
            //Dispose the ExcelEngine
            excelEngine.Dispose();
            #endregion

            #region View the Workbook
            //Message box confirmation to view the created spreadsheet.
            if (MessageBox.Show("Do you want to view the workbook?", "Workbook has been created",
                MessageBoxButtons.YesNo, MessageBoxIcon.Information)
                == DialogResult.Yes)
            {
                try
                {
                    //Launching the Excel file using the default Application.[MS Excel Or Free ExcelViewer]
                    System.Diagnostics.Process.Start("OleObjectSample.xlsx");
                    //Exit
                    this.Close();
                }
                catch (Win32Exception)
                {
                    MessageBox.Show("MS Excel is not installed in this system");
                }
            }
            else
            {
                // Exit
                this.Close();
            }
            #endregion
        }
        #endregion

        #region HelperMethods
        /// <summary>
        /// Get the path of the passed inputfile and return the same
        /// </summary>
        /// <param name="inputPath">Input file</param>
        /// <returns> Path of the input file</returns>
        private string GetFullTemplatePath(string inputFile)
        {
            return string.Format(DEFAULTFILEPATH, inputFile);
        }

        /// <summary>
        /// Get the path of the passed Image file and return the same
        /// </summary>
        /// <param name="inputPath">Input file</param>
        /// <returns> Path of the input file</returns>
        private string GetFullImagePath(string inputFile)
        {
            return string.Format(DEFAULTIMAGEPATH, inputFile);
        }
        #endregion
    }
}
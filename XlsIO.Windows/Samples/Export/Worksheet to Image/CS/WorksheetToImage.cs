using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Syncfusion.XlsIO;
using System.Drawing.Imaging;
using System.Diagnostics;
using Syncfusion.Windows.Forms;
 
 namespace EssentialXlsIOSample
{
    public partial class WorksheetToImage : MetroForm
    {
        #region Constants
        private const string DEFAULTPATH = @"..\..\..\..\..\..\..\Common\Data\XlsIO\{0}";
        #endregion

        #region Initialize
        public WorksheetToImage()
        {
            InitializeComponent();
        }
        #endregion

        #region Image Convert Method
        private void btnConvert_Click(object sender, EventArgs e)
        {
            string fileName;

            #region Initialize Workbook
            // New instance of XlsIO is created.[Equivalent to launching MS Excel with no workbooks open].
            // The instantiation process consists of two steps.

            // Step 1 : Instantiate the spreadsheet creation engine.
            ExcelEngine excelEngine = new ExcelEngine();

            // Step 2 : Instantiate the excel application object.
            IApplication application = excelEngine.Excel;
            application.DefaultVersion = ExcelVersion.Excel2007;

            string inputPath = GetFullTemplatePath("WorkSheetToImage.xlsx");
            // An existing workbook is opened.
            IWorkbook workbook = application.Workbooks.Open(inputPath);
            // The first worksheet object in the worksheets collection is accessed.
            IWorksheet worksheet = workbook.Worksheets["Pivot Table"];

            #endregion

            #region Convert Sheet and Save as Image
            worksheet.UsedRangeIncludesFormatting = false;
            int lastRow = worksheet.UsedRange.LastRow + 1;
            int lastColumn = worksheet.UsedRange.LastColumn + 1;

            // Save the image.
            if (rdbBitmap.Checked)
            {
                // Convert the worksheet to image
                Image img = worksheet.ConvertToImage(1, 1, lastRow, lastColumn, ImageType.Bitmap, null);
                fileName = "BitmapImg.png";
                img.Save(fileName, ImageFormat.Png);
            }
            else
            {
                // Convert the worksheet to image
                Image img = worksheet.ConvertToImage(1, 1, lastRow, lastColumn, ImageType.Metafile, null);
                fileName = "Metafile.emf";
                img.Save(fileName, ImageFormat.Emf);
            }
            #endregion

            #region Workbook close and Dispose
            //Close the workbook.
            workbook.Close();
            excelEngine.Dispose();
            #endregion

            #region View the Workbook
            //Message box confirmation to view the created spreadsheet.
            if (MessageBox.Show("Do you want to view the image?", "Conversion Successful !!!",
                MessageBoxButtons.YesNo, MessageBoxIcon.Information)
                == DialogResult.Yes)
            {
                // Launch the image
                Process.Start(fileName);
                this.Close();
            }
            else
                this.Close();
            #endregion
        }

        #endregion

        #region HelperMethods
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

        #region View the Input File
        private void viewInputTemplate_Click(object sender, EventArgs e)
        {
            //Get the path of the input file
            string inputPath = GetFullTemplatePath("WorkSheetToImage.xlsx");
            //Launching the Excel file using the default Application.[MS Excel Or Free ExcelViewer]
            System.Diagnostics.Process.Start(inputPath);
        }
        #endregion
    }
}
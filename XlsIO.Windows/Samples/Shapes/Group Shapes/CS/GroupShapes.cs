#region Copyright Syncfusion Inc. 2001 - 2009
//
//  Copyright Syncfusion Inc. 2001 - 2009. All rights reserved.
//
//  Use of this code is subject to the terms of our license.
//  A copy of the current license can be obtained at any time by e-mailing
//  licensing@syncfusion.com. Any infringement will be prosecuted under
//  applicable laws. 
//
#endregion

using System;
using System.Windows.Forms;
using Syncfusion.XlsIO;
using Syncfusion.Windows.Forms;

namespace EssentialXlsIOSamples
{
    public partial class GroupShapes : MetroForm
    {
        #region Constants
        private const string DEFAULTPATH = @"..\..\..\..\..\..\..\Common\Data\XlsIO\{0}";
        #endregion

        #region Initialize
        public GroupShapes()
        {
            InitializeComponent();
        }
        #endregion

        #region Create Group Shape or Ungroup the existing shapes
        private void btnConvert_Click(object sender, EventArgs e)
        {            
            #region Workbook Initialization
            //New instance of XlsIO is created.[Equivalent to launching MS Excel with no workbooks open].
            //The instantiation process consists of two steps.

            //Step 1 : Instantiate the spreadsheet creation engine.
            ExcelEngine excelEngine = new ExcelEngine();
            //Step 2 : Instantiate the excel application object.
            IApplication application = excelEngine.Excel;

            //Get the path of the Input file
            string inputPath = GetFullTemplatePath("GroupShapes.xlsx");
            
            // Existing workbook is opened
            IWorkbook workbook = application.Workbooks.Open(inputPath);

            IWorksheet worksheet;

            #endregion

            #region Group Shape

            string fileName = "";

            if (rdbGroup.Checked)
            {
                // The first worksheet object in the worksheets collection is accessed.
                worksheet = workbook.Worksheets[0];
                IShapes shapes = worksheet.Shapes;

                IShape[] groupItems;
                for (int i = 0; i < shapes.Count; i++)
                {
                    if (shapes[i].Name == "Development" || shapes[i].Name == "Production" || shapes[i].Name == "Sales")
                    {
                        groupItems = new IShape[] { shapes[i], shapes[i + 1], shapes[i + 2], shapes[i + 3], shapes[i + 4], shapes[i + 5] };
                        shapes.Group(groupItems);
                        i = -1;
                    }
                }

                groupItems = new IShape[] { shapes[0], shapes[1], shapes[2], shapes[3], shapes[4], shapes[5], shapes[6] };
                shapes.Group(groupItems);

                fileName = "Group.xlsx";
                workbook.SaveAs(fileName);
            }
            else if (rdbUngroupAll.Checked)
            {
                // The second worksheet object in the worksheets collection is accessed.
                worksheet = workbook.Worksheets[1];
                IShapes shapes = worksheet.Shapes;
                shapes.Ungroup(shapes[0] as IGroupShape, true);
                worksheet.Activate();
                fileName = "Ungroup.xlsx";
                workbook.SaveAs(fileName);
            }
            else if (rdbUngroup.Checked)
            {
                // The second worksheet object in the worksheets collection is accessed.
                worksheet = workbook.Worksheets[1];
                IShapes shapes = worksheet.Shapes;
                shapes.Ungroup(shapes[0] as IGroupShape);
                worksheet.Activate();
                fileName = "Ungroup.xlsx";
                workbook.SaveAs(fileName);
            }
            #endregion

            #region Workbook Close and Dispose
            //Close the workbook and excelEngine
            workbook.Close();
            excelEngine.Dispose();
            #endregion

            #region View the Workbook
            //Message box confirmation to view the created spreadsheet.
            if (MessageBox.Show("Do you want to view the workbook?", "Workbook has been saved",
                MessageBoxButtons.YesNo, MessageBoxIcon.Information)
                == DialogResult.Yes)
            {
                //Launching the HTMl file using the default Application.[MS Excel Or Free ExcelViewer]
                System.Diagnostics.Process.Start(fileName);
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

        #region HelperMethods
        /// <summary>
        /// Get the file path of input file and return the same
        /// </summary>
        /// <param name="inputPath">Input file</param>
        /// <returns>File path of the Input file</returns>
        private string GetFullTemplatePath(string inputFile)
        {
            return string.Format(DEFAULTPATH, inputFile);
        }
        #endregion       

        #region View the Input file
        private void viewInputTemplate_Click(object sender, EventArgs e)
        {
            //Get the path of the input file
            string inputPath = GetFullTemplatePath("GroupShapes.xlsx");
            //Launching the Excel file using the default Application.[MS Excel Or Free ExcelViewer]
            System.Diagnostics.Process.Start(inputPath);
        }
        #endregion
    }
}
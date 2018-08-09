using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Syncfusion.XlsIO;
using Syncfusion.Windows.Forms;

namespace EssentialXlsIOSamples
{
    public partial class FormControls : MetroForm
    {
        #region Constants
        private const string DEFAULTPATH = @"..\..\..\..\..\..\..\Common\Images\XlsIO\{0}";
        #endregion

        #region Fields
        private string fileName;
        private Color color1;
        private string[] onlinePayments;
        #endregion 

        #region Initialize
        public FormControls()
        {
            InitializeComponent();
            this.rdbExcel2013.Checked = true;
            onlinePayments = new string[] { "Credit Card", "Net Banking" };
        }
        #endregion

        #region Form Controls
        private void btnCreate_Click(object sender, EventArgs e)
        {
            #region Workbook Initialize
            // New instance of XlsIO is created.[Equivalent to launching MS Excel with no workbooks open].
            // The instantiation process consists of two steps.

            // Step 1 : Instantiate the spreadsheet creation engine.
            ExcelEngine excelEngine = new ExcelEngine();
            // Step 2 : Instantiate the excel application object.
            IApplication application = excelEngine.Excel;

            // Check if user opts for Excel 2007
            if (this.rdbExcel2007.Checked)
            {
                application.DefaultVersion = ExcelVersion.Excel2007;
                color1 = Color.FromArgb(255, 255, 230);
            }
            // Check if user opts for Excel 2010
            else if (this.rdbExcel2010.Checked)
            {
                application.DefaultVersion = ExcelVersion.Excel2010;
                color1 = Color.FromArgb(255, 255, 230);
            }
            // Check if user opts for Excel 2013
            else if (this.rdbExcel2013.Checked)
            {
                application.DefaultVersion = ExcelVersion.Excel2013;
                color1 = Color.FromArgb(255, 255, 230);
            }
            else
                color1 = Color.FromArgb(255, 255, 204);

            // A new workbook is created.[Equivalent to creating a new workbook in MS Excel]
            // Workbook created with two worksheets
            IWorkbook workbook = application.Workbooks.Create(2);
            // The first worksheet object in the worksheets collection is accessed.
            // (0 based index)
            IWorksheet worksheet2 = workbook.Worksheets[1];
            //Assigning the array content to cells
            // by passing row and column position 
            for (int i = 0; i < onlinePayments.Length; i++)
                worksheet2.SetValue(i + 1, 1, onlinePayments[i]);

            // The first worksheet object in the worksheets collection is accessed.
            IWorksheet worksheet = workbook.Worksheets[0];
            #endregion

            #region Add Picture
            //Get the path of the input file
            string inputPath = GetTemplatePath("contact_sales.gif");
            worksheet.Pictures.AddPicture(2, 3, inputPath );
            #endregion

            worksheet[4, 3].Text = "Phone";
            worksheet[4, 3].CellStyle.Font.Bold = true;
            worksheet[5, 3].Text = "Toll Free";
            worksheet[5, 5].Text = "1-888-9DOTNET";
            worksheet[6, 5].Text = "1-888-936-8638";
            worksheet[7, 5].Text = "1-919-481-1974";
            worksheet[8, 3].Text = "Fax";
            worksheet[8, 5].Text = "1-919-573-0306";
            worksheet[9, 3].Text = "Email";
            worksheet[10, 3].Text = "Sales";
           

            #region Add Hyperlink
            //Creating the hyperlink in the 10th column and 
            //5th row of the worksheet 
            IHyperLink link = worksheet.HyperLinks.Add(worksheet[10, 5]);
            link.Type = ExcelHyperLinkType.Url;
            link.Address = "mailto:sales@syncfusion.com";
            #endregion

            worksheet[12, 3].Text = "Please fill out all required fields.";
            worksheet[14, 5].Text = "First Name*";
            worksheet[14, 5].CellStyle.Font.Bold = true;
            worksheet[14, 8].Text = "Last Name*";
            worksheet[14, 8].CellStyle.Font.Bold = true;

            #region Add TextBoxes
            //Create textbox for respective field
            //textbox to get First Name
            ITextBoxShape textBoxShape = worksheet.TextBoxes.AddTextBox(15, 5, 23, 190);
            textBoxShape.Fill.FillType = ExcelFillType.SolidColor;
            textBoxShape.Fill.ForeColor = color1;

            //textbox to get Last Name
            textBoxShape = worksheet.TextBoxes.AddTextBox(15, 8, 23, 195);
            textBoxShape.Fill.FillType = ExcelFillType.SolidColor;
            textBoxShape.Fill.ForeColor = color1;

            worksheet[17, 3].Text = "Company*";
            textBoxShape = worksheet.TextBoxes.AddTextBox(17, 5, 23, 385);
            textBoxShape.Fill.FillType = ExcelFillType.SolidColor;
            textBoxShape.Fill.ForeColor = color1;

            worksheet[19, 3].Text = "Phone*";
            textBoxShape = worksheet.TextBoxes.AddTextBox(19, 5, 23, 385);
            textBoxShape.Fill.FillType = ExcelFillType.SolidColor;
            textBoxShape.Fill.ForeColor = color1;

            worksheet[21, 3].Text = "Email*";
            textBoxShape = worksheet.TextBoxes.AddTextBox(21, 5, 23, 385);
            textBoxShape.Fill.FillType = ExcelFillType.SolidColor;
            textBoxShape.Fill.ForeColor = color1;

            worksheet[23, 3].Text = "Website";
            textBoxShape = worksheet.TextBoxes.AddTextBox(23, 5, 23, 385);
            #endregion

            #region Add CheckBoxes
            ICheckBoxShape chkBoxProducts = worksheet.CheckBoxes.AddCheckBox(25, 5, 20, 75);
            
            worksheet[25, 3].Text = "Multiple products?";

            worksheet[27, 3, 28, 3].Merge();
            worksheet[27, 3].Text = "Product(s)*";
            worksheet[27, 3].MergeArea.CellStyle.VerticalAlignment = ExcelVAlign.VAlignCenter;
            // Create a checkbox for each product
            ICheckBoxShape chkBoxProduct;
            chkBoxProduct = worksheet.CheckBoxes.AddCheckBox(27, 5, 20, 75);
            chkBoxProduct.Text = "Studio";
            chkBoxProduct = worksheet.CheckBoxes.AddCheckBox(27, 6, 20, 75);
            chkBoxProduct.Text = "Calculate";
            chkBoxProduct.IsSizeWithCell = true;
            chkBoxProduct = worksheet.CheckBoxes.AddCheckBox(27, 7, 20, 75);
            chkBoxProduct.Text = "Chart";
            chkBoxProduct = worksheet.CheckBoxes.AddCheckBox(27, 8, 20, 75);
            chkBoxProduct.Text = "Diagram";
            chkBoxProduct.IsSizeWithCell = true;
            chkBoxProduct = worksheet.CheckBoxes.AddCheckBox(27, 9, 20, 75);
            chkBoxProduct.Text = "Edit";
            chkBoxProduct = worksheet.CheckBoxes.AddCheckBox(27, 10, 20, 75);
            chkBoxProduct.Text = "XlsIO";
            chkBoxProduct = worksheet.CheckBoxes.AddCheckBox(28, 5, 20, 75);
            chkBoxProduct.Text = "Grid";
            chkBoxProduct = worksheet.CheckBoxes.AddCheckBox(28, 6, 20, 75);
            chkBoxProduct.Text = "Grouping";
            chkBoxProduct = worksheet.CheckBoxes.AddCheckBox(28, 7, 20, 75);
            chkBoxProduct.Text = "HTMLUI";
            chkBoxProduct = worksheet.CheckBoxes.AddCheckBox(28, 8, 20, 75);
            chkBoxProduct.Text = "PDF";
            chkBoxProduct = worksheet.CheckBoxes.AddCheckBox(28, 9, 20, 75);
            chkBoxProduct.Text = "Tools";
            chkBoxProduct = worksheet.CheckBoxes.AddCheckBox(28, 10, 20, 75);
            chkBoxProduct.Text = "DocIO";
            chkBoxProducts.CheckState = ExcelCheckState.Mixed;
            #endregion

            //generate the link to linked cell property and formula
            GenerateFormula(excelEngine);

            worksheet[30, 3].Text = "Selected Products Count";
            //counts the selected product
            worksheet[30, 5].Formula = "Sum(AA2:AA13)";
            //align the cell content
            worksheet[30, 5].CellStyle.HorizontalAlignment = ExcelHAlign.HAlignLeft;

            #region Add TextBox
            //create the textbox for additional information
            worksheet[35, 3].Text = "Additional Information";
            textBoxShape = worksheet.TextBoxes.AddTextBox(32, 5, 150, 385);
            #endregion


            if (!rdbExcel97.Checked)
            {
                worksheet[43, 3].Text = "Online Payment";

                #region Add Combobox
                // Create combobox
                IComboBoxShape comboBox1 = worksheet.ComboBoxes.AddComboBox(43, 5, 20, 100);

                // Assign range to display in dropdown list
                comboBox1.ListFillRange = worksheet2["A1:A2"];

                // select 1st item from the list
                comboBox1.SelectedIndex = 1;
                #endregion

                #region Add OptionButton
                worksheet[46, 3].Text = "Card Type";
                IOptionButtonShape optionButton1 = worksheet.OptionButtons.AddOptionButton(46, 5);
                optionButton1.Text = "American Express";
                optionButton1.CheckState = ExcelCheckState.Checked;

                optionButton1 = worksheet.OptionButtons.AddOptionButton(46, 7);
                optionButton1.Text = "Master Card";

                optionButton1 = worksheet.OptionButtons.AddOptionButton(46, 9);
                optionButton1.Text = "Visa";
                #endregion
            }

            #region Column Alignment
            //column alignment
            worksheet.Columns[0].AutofitColumns();
            worksheet.Columns[3].ColumnWidth = 12;
            worksheet.Columns[4].ColumnWidth = 10;
            worksheet.Columns[5].ColumnWidth = 10;
            #endregion

            worksheet.IsGridLinesVisible = false;

            #region Workbook Save 
            // Assign the filename depends upon the version
            if ((this.rdbExcel2007.Checked) || (this.rdbExcel2010.Checked) || (this.rdbExcel2013.Checked))
                fileName = "FormControl.xlsx";
            else
                fileName = "FormControl.xls";

            // Save the file
            workbook.SaveAs(fileName);
            #endregion

            #region Workbook Close and Dispose
            //closes the workbook
            workbook.Close();
            excelEngine.Dispose();
            #endregion

            #region View the Workbook
            // Message box confirmation to view the created document.
            if (MessageBox.Show("Do you want to view the workbook?", "Workbook has been created",
            MessageBoxButtons.YesNo, MessageBoxIcon.Information)
            == DialogResult.Yes)
            {
                try
                {
                    //Launching the Excel file using the default Application.[MS Excel Or Free ExcelViewer]
                    System.Diagnostics.Process.Start(fileName);

                    //Exit
                    this.Close();
                }
                catch (Win32Exception ex)
                {
                    MessageBox.Show("Excel 2007 is not installed in this system");
                    Console.WriteLine(ex.ToString());
                }
            }
            else
                this.Close();
            #endregion
        }
        #endregion

        #region Helper Methods
        /// <summary>
        /// Generates the formula and linkedcell 
        /// </summary>
        /// <param name="excelEngine">excel application engine</param>
        private void GenerateFormula(ExcelEngine excelEngine)
        {
            //gets the address of the 1st worksheet
            IWorksheet worksheet = excelEngine.Excel.Workbooks[0].Worksheets[0];
            ICheckBoxes checkBoxes = worksheet.CheckBoxes;
            string formula;
            // loop through each checkbox and assing the link
            for (int i = 1; i < checkBoxes.Count; i++)
            {
                // range for linkedcell
                IRange range = worksheet["Z" + (i + 1)];
                checkBoxes[i].LinkedCell = range;
                //formula to check whether the checkbox checked
                formula = "IF(" + range.AddressLocal + ",1,0)";
                worksheet["AA" + (i + 1)].Formula = formula;
            }
        }

        /// <summary>
        /// Get the file path of input file and return the same
        /// </summary>
        /// <param name="inputPath">Input file</param>
        /// <returns>path of the input file</returns>
        private string GetTemplatePath(string inputFile)
        {
            return string.Format(DEFAULTPATH, inputFile);
        }
        #endregion
      
    }
}
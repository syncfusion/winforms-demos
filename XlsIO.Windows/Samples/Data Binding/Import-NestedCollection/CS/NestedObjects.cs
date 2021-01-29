#region Copyright Syncfusion Inc. 2001 - 2021
//
//  Copyright Syncfusion Inc. 2001 - 2021. All rights reserved.
//
//  Use of this code is subject to the terms of our license.
//  A copy of the current license can be obtained at any time by e-mailing
//  licensing@syncfusion.com. Any infringement will be prosecuted under
//  applicable laws. 
//
#endregion

using System;
using System.Diagnostics;
using System.IO;
using System.Drawing;
using Syncfusion.XlsIO;
using Syncfusion.Licensing;
using System.Windows.Forms;
using System.ComponentModel;
using Syncfusion.Windows.Forms;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace ImportNestedCollection
{
    public partial class NestedObjects : MetroForm
    {
        public NestedObjects()
        {
            InitializeComponent();
            this.layoutOptions.SelectedIndex = 0;
            this.groupOptionGrpBox.Enabled = false;
            this.expandRadioBtn.Checked = true;
            this.levelTxtBox.Text = "1";
        }

        private void createExcelBtn_Click(object sender, EventArgs e)
        {
            ExcelEngine excelEngine = new ExcelEngine();
            IApplication application = excelEngine.Excel;
            application.DefaultVersion = ExcelVersion.Excel2016;
            IWorkbook workbook = excelEngine.Excel.Workbooks.Create(1);
            IWorksheet worksheet = workbook.Worksheets[0];

            IList<Brand> list = GetVehicleDetails();

            ExcelImportDataOptions importDataOptions = new ExcelImportDataOptions();
            importDataOptions.FirstRow = 4;

            if (layoutOptions.SelectedIndex == 0)
                importDataOptions.NestedDataLayoutOptions = ExcelNestedDataLayoutOptions.Default;
            else if (layoutOptions.SelectedIndex == 1)
                importDataOptions.NestedDataLayoutOptions = ExcelNestedDataLayoutOptions.Merge;
            else if (layoutOptions.SelectedIndex == 2)
                importDataOptions.NestedDataLayoutOptions = ExcelNestedDataLayoutOptions.Repeat;

            if (groupChkBox.Checked)
            {
                if (expandRadioBtn.Checked)
                {
                    importDataOptions.NestedDataGroupOptions = ExcelNestedDataGroupOptions.Expand;
                }
                else if (collapseRadioBtn.Checked)
                {
                    importDataOptions.NestedDataGroupOptions = ExcelNestedDataGroupOptions.Collapse;
                    if (levelTxtBox.Text != string.Empty)
                    {
                        importDataOptions.CollapseLevel = int.Parse(levelTxtBox.Text);
                    }
                }
            }

            worksheet.ImportData(list, importDataOptions);
            string fileName = @"ImportData.xlsx";

            #region Define Styles
            IStyle pageHeader = workbook.Styles.Add("PageHeaderStyle");
            IStyle tableHeader = workbook.Styles.Add("TableHeaderStyle");

            pageHeader.Font.FontName = "Calibri";
            pageHeader.Font.Size = 16;
            pageHeader.Font.Bold = true;
            pageHeader.Color = System.Drawing.Color.FromArgb(0, 146, 208, 80);
            pageHeader.HorizontalAlignment = ExcelHAlign.HAlignCenter;
            pageHeader.VerticalAlignment = ExcelVAlign.VAlignCenter;

            tableHeader.Font.Bold = true;
            tableHeader.Font.FontName = "Calibri";
            tableHeader.Color = System.Drawing.Color.FromArgb(0, 146, 208, 80);

            #endregion

            #region Apply Styles
            // Apply style for header
            worksheet["A1:C2"].Merge();
            worksheet["A1"].Text = "Automobile Brands in the US";
            worksheet["A1"].CellStyle = pageHeader;

            worksheet["A4:C4"].CellStyle = tableHeader;

            worksheet["A1:C1"].CellStyle.Font.Bold = true;
            worksheet.UsedRange.AutofitColumns();

            #endregion

            workbook.SaveAs(fileName);
            workbook.Close();
            excelEngine.Dispose();

            //Message box confirmation to view the created document.
            if (MessageBox.Show("Do you want to view the Excel file?", "File has been created", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                try
                {
#if NETCORE
                    System.Diagnostics.Process process = new System.Diagnostics.Process();
                    process.StartInfo = new System.Diagnostics.ProcessStartInfo(fileName)
                    {
                        UseShellExecute = true
                    };
                    process.Start();
#else
                    Process.Start(fileName);
#endif
                    //Exit
                    this.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
            }
        }

        #region Helper Methods
        private IList<Brand> GetVehicleDetails()
        {
            XmlSerializer deserializer = new XmlSerializer(typeof(BrandObjects));
#if NETCORE
            TextReader textReader = new StreamReader(@"..\..\..\..\..\..\..\..\Common\Data\XlsIO\ExportData.xml");
#else
            TextReader textReader = new StreamReader(@"..\..\..\..\..\..\..\Common\Data\XlsIO\ExportData.xml");
#endif
            BrandObjects brands = (BrandObjects)deserializer.Deserialize(textReader);

            List<Brand> list = new List<Brand>();
            string brandName = brands.BrandObject[0].BrandName;
            string vehicleType = brands.BrandObject[0].VahicleType;
            string modelName = brands.BrandObject[0].ModelName;
            Brand brand = new Brand(brandName);
            brand.VehicleTypes = new List<VehicleType>();

            VehicleType vehicle = new VehicleType(vehicleType);
            vehicle.Models = new List<Model>();
            Model model = new Model(modelName);

            brand.VehicleTypes.Add(vehicle);
            list.Add(brand);

            foreach (BrandObject brandObj in brands.BrandObject)
            {
                if (brandName == brandObj.BrandName)
                {
                    if (vehicleType == brandObj.VahicleType)
                    {
                        vehicle.Models.Add(new Model(brandObj.ModelName));
                        continue;
                    }
                    else
                    {
                        vehicle = new VehicleType(brandObj.VahicleType);
                        vehicle.Models = new List<Model>();
                        vehicle.Models.Add(new Model(brandObj.ModelName));
                        brand.VehicleTypes.Add(vehicle);
                        vehicleType = brandObj.VahicleType;
                    }
                    continue;
                }
                else
                {
                    brand = new Brand(brandObj.BrandName);
                    vehicle = new VehicleType(brandObj.VahicleType);
                    vehicle.Models = new List<Model>();
                    vehicle.Models.Add(new Model(brandObj.ModelName));
                    brand.VehicleTypes = new List<VehicleType>();
                    brand.VehicleTypes.Add(vehicle);
                    vehicleType = brandObj.VahicleType;
                    list.Add(brand);
                    brandName = brandObj.BrandName;
                }
            }
            textReader.Close();
            return list;
        }

        #endregion

        #region Initialize
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            SyncfusionLicenseProvider.RegisterLicense(DemoCommon.FindLicenseKey());
            Application.EnableVisualStyles();
            Application.Run(new NestedObjects());
        }
        #endregion

        private void GroupOptions(object sender, EventArgs e)
        {
            this.groupOptionGrpBox.Enabled = this.groupChkBox.Checked;
        }

        private void ExpandCollapse(object sender, EventArgs e)
        {
            this.levelTxtBox.Enabled = this.collapseRadioBtn.Checked;
        }

        private void levelTxtBox_TextChanged(object sender, EventArgs e)
        {
            int level = 0;
            if (!(int.TryParse(levelTxtBox.Text, out level) && level > 0 && level < 9))
            {
                MessageBox.Show("Please enter the level from 1 to 8");
            }
        }
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
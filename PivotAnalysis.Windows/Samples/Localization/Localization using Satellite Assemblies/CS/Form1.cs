#region Copyright Syncfusion Inc. 2001 - 2018
// Copyright Syncfusion Inc. 2001 - 2018. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion

using System;
using System.Globalization;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using Syncfusion.PivotAnalysis.Base;
using Syncfusion.Windows.Forms;

namespace LocalizationDemo
{
    public partial class Form1 : MetroForm
    {
        #region Fields

        [DllImport("user32.dll", CharSet = CharSet.Auto, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        internal static extern bool LockWindowUpdate(IntPtr hWndLock);

        #endregion

        #region Constructor

        public Form1()
        {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("de-DE");
            InitializeComponent();
            InitializePivotGrid();           
        }

        #endregion

        #region Grid Settings

        /// <summary>
        /// Grid Settings for better look and feel
        /// </summary>
        private void InitializePivotGrid()
        {
            LocalizationProvider.Provider = new Localizer();

            pivotGridControl1.ItemSource = ProductSalesData.GetSalesData();

            pivotGridControl1.PivotRows.Add(new PivotItem { FieldMappingName = "Product", FieldHeader = "Menge", TotalHeader = "Total" });

            pivotGridControl1.PivotRows.Add(new PivotItem { FieldMappingName = "Date", TotalHeader = "Total" });

            pivotGridControl1.PivotColumns.Add(new PivotItem { FieldMappingName = "Country", FieldHeader = "land", TotalHeader = "Total" });

            pivotGridControl1.PivotColumns.Add(new PivotItem { FieldMappingName = "State", TotalHeader = "Total" });

            pivotGridControl1.PivotCalculations.Add(new PivotComputationInfo { FieldName = "Amount", FieldHeader = "Menge", Format = "C", SummaryType = SummaryType.DoubleTotalSum });

            pivotGridControl1.PivotCalculations.Add(new PivotComputationInfo { FieldName = "Quantity", FieldHeader = "Quantitie", Format = "#,##0" });

            pivotGridControl1.PivotCalculations.Add(new PivotComputationInfo { FieldName = "UnitPrice", FieldHeader = "Einzelpreis" });

            pivotGridControl1.PivotCalculations.Add(new PivotComputationInfo { FieldName = "TotalPrice", FieldHeader = "Gesamtpreis" });
            pivotGridControl1.GridVisualStyles = GridVisualStyles.Metro;
            pivotGridControl1.ShowPivotTableFieldList = true;

            //tab key navigation set as false to move the next control
            pivotGridControl1.TableControl.WantTabKey = false;
            pivotGridControl1.TableControl.PivotTableFieldList.WantTabKey = false;
            pivotGridControl1.TableControl.GridColumnList.WantTabKey = false;
            pivotGridControl1.TableControl.GridFilterList.WantTabKey = false;
            pivotGridControl1.TableControl.GridRowList.WantTabKey = false;
            pivotGridControl1.TableControl.GridValueList.WantTabKey = false;
            pivotGridControl1.PivotSchemaDesigner.TabStop = false;
            pivotGridControl1.TabStop = false;

            string targetPath = Application.StartupPath + "\\" + "de-DE";
            string sourceFile = Path.GetFullPath("..\\..\\de-DE\\Syncfusion.PivotAnalysis.Windows.resources.dll");
            if (!Directory.Exists(targetPath))
            {
                Directory.CreateDirectory(targetPath);
                File.Copy(sourceFile, targetPath + "\\Syncfusion.PivotAnalysis.Windows.resources.dll");

                sourceFile = Path.GetFullPath("..\\..\\de-DE\\run.bat");
                File.Copy(sourceFile, targetPath + "\\run.bat");
            }
            LocalizationProvider.Provider = new Localizer();
            Localizer loc = new Localizer();
            LocalizationProvider.Provider = loc;
        }

        #endregion

        #region Event Handlers

        /// <summary>
        /// Handling the PivoGrig RightTOLeft
        /// </summary>
        private void checkBoxAdv2_CheckStateChanged(object sender, EventArgs e)
        {
            LockWindowUpdate(Handle);
            pivotGridControl1.RightToLeft = checkBoxAdv1.Checked ? RightToLeft.Yes : RightToLeft.No;
            LockWindowUpdate(IntPtr.Zero);
            pivotGridControl1.TableControl.Refresh();
            pivotGridControl1.PivotSchemaDesigner.Refresh();
            pivotGridControl1.Refresh();
        }

        #endregion
    }
}
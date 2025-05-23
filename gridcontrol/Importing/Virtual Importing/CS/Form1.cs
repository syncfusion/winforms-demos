#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DemoCommon.Grid;
using Syncfusion.XlsIO;
using Syncfusion.Windows.Forms;
using Syncfusion.Windows.Forms.Grid;
using Syncfusion.GridConverter;
using System.IO;
using Syncfusion.GridHelperClasses;
using Virtual_Import;
using Syncfusion.GroupingGridExcelConverter;
using Syncfusion.GridExcelConverter;

namespace Virtual_Import
{
    public partial class Form1 : GridDemoForm
    {

        #region Private Variables
        ExcelEngine excelEngine = new ExcelEngine();
        IWorkbook workbook;
        GridModel[] gridModelCollection;
        ImportingHelper importingHelper;
        #endregion

        #region Constructor
        public Form1()
        {
            InitializeComponent();
            if (DpiAware.GetCurrentDpi() > 96)
            {
                this.CaptionBarHeight = (int)DpiAware.LogicalToDeviceUnits(this.CaptionBarHeight);
            }
            excelEngine = new ExcelEngine();
            importingHelper = new ImportingHelper();
#if !NETCORE
            FileStream fileStream = new FileStream(@"..\..\Data\Sample.xlsx", FileMode.Open);
#else
             FileStream fileStream = new FileStream(@"..\..\..\Data\Sample.xlsx", FileMode.Open);
#endif
            if (fileStream != null)
            {
                workbook = excelEngine.Excel.Workbooks.Open(fileStream, ExcelOpenType.Automatic);
                importingHelper.LoadWorkbook(this.tabBarSplitterControl1, workbook);
                gridModelCollection = importingHelper.gridModelCollection;
            }

            //Used to focus formula cell when it is edit mode
            GridFormulaCellRenderer.ForceEditWhenActivated = false;
        }
        #endregion

        #region Import Excel sheet
        private void importButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Files(*.xls)|*.xls|Files(*.xlsx)|*xlsx";
            openFileDialog.DefaultExt = ".xls";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                importingHelper.UnHookingEvents();

                workbook.Close();

                FileStream fileStream = new FileStream(openFileDialog.FileName, FileMode.Open);
                if (fileStream != null)
                {
                    workbook = excelEngine.Excel.Workbooks.Open(fileStream, ExcelOpenType.Automatic);
                    importingHelper.excelConverter.ImportBorders = this.importBordersCheckBox.Checked;
                    importingHelper.excelConverter.ImportStyles = this.importStylesCheckBox.Checked;
                    importingHelper.LoadWorkbook(this.tabBarSplitterControl1, workbook);
                    gridModelCollection = importingHelper.gridModelCollection;
                }
            }
        }
        #endregion

        #region Saving Excel sheet
        private void saveBtn_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.DefaultExt = "xlsx";
            sfd.FileName = "Untitled";
            sfd.Filter = "Excel 97 to 2003 File(*.xls)|*.xls|Excel 2007 to 2013 File(*.xlsx)|*.xlsx";
            sfd.FilterIndex = 2;
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                using (Stream stream = sfd.OpenFile())
                {
                    if (sfd.FilterIndex == 1)
                    {
                        if (workbook.Version == ExcelVersion.Excel97to2003)
                            workbook.SaveAs(stream);
                        else
                        {
                            workbook.Version = ExcelVersion.Excel97to2003;
                            workbook.SaveAs(stream);
                        }
                    }
                    else if (sfd.FilterIndex == 2)
                    {
                        if (workbook.Version == ExcelVersion.Excel2007 || workbook.Version == ExcelVersion.Excel2010)
                            workbook.SaveAs(stream);
                        else
                        {
                            workbook.Version = ExcelVersion.Excel2013;
                            workbook.SaveAs(stream);
                        }
                    }
                }
            }
        }
        #endregion

        #region Dispose
        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        #endregion

    }    
}

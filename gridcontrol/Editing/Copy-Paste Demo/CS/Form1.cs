#region Copyright Syncfusion Inc. 2001 - 2015
//
//  Copyright Syncfusion Inc. 2001 - 2015. All rights reserved.
//
//  Use of this code is subject to the terms of our license.
//  A copy of the current license can be obtained at any time by e-mailing
//  licensing@syncfusion.com. Any infringement will be prosecuted under
//  applicable laws. 
//
#endregion

using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using Syncfusion.Windows.Forms.Grid;
using Syncfusion.Windows.Forms;
using Syncfusion.XlsIO;
using Syncfusion.GridExcelConverter;
using DemoCommon.Grid;

namespace ExcelGrid_CopyPaste
{
    /// <summary>
    /// Summary description for Form1.
    /// </summary>
    public class Form1 : GridDemoForm
    {
        #region API Definition
        private Syncfusion.Windows.Forms.Grid.GridControl gridControl1;
        private Syncfusion.Windows.Forms.ButtonAdv btnClear;
        private IContainer components;
        #endregion

        #region Constructor
        public Form1()
        {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();
            if (DpiAware.GetCurrentDpi() > 96)
            {
                this.CaptionBarHeight = (int)DpiAware.LogicalToDeviceUnits(this.CaptionBarHeight);
            }
            GridSettings();
            this.gridControl1.ColWidths[0] = (int)DpiAware.LogicalToDeviceUnits(40);
        }
        #endregion

        #region GridSettings
        /// <summary>
        /// Grid settings for better look and feel and loading the data. 
        /// </summary>
        private void GridSettings()
        {
            GridStyleInfo style1 = new GridStyleInfo();
            style1.BackColor = Color.FromArgb(0x85, 0xbf, 0x75);
            style1.Font.Underline = true;
            style1.Font.Bold = true;

            GridStyleInfo style2 = new GridStyleInfo();
            style2.BackColor = Color.FromArgb(0xde, 0x64, 0x13);
            style2.TextColor = SystemColors.Info;

            GridStyleInfo style3 = new GridStyleInfo();
            style3.BackColor = Color.FromArgb(0xb4, 0xe7, 0xf2);
            style3.TextColor = Color.MidnightBlue;
            style3.Borders.All = new GridBorder(GridBorderStyle.Solid, Color.DarkRed, GridBorderWeight.Medium);

            GridStyleInfo style4 = new GridStyleInfo();
            style4.BackColor = Color.FromArgb(0xff, 0xbf, 0x34);
            style4.Font.Bold = true;

            GridStyleInfo style5 = new GridStyleInfo();
            style5.BackColor = Color.FromArgb(0x82, 0x2e, 0x1b);
            style5.TextColor = Color.White;

            GridStyleInfo style6 = new GridStyleInfo();
            style6.BackColor = Color.FromArgb(0x3a, 0x86, 0x7e);
            style6.TextColor = Color.White;
            style6.Borders.All = new GridBorder(GridBorderStyle.Solid, Color.Red, GridBorderWeight.Medium);


            GridStyleInfo[] styles = new GridStyleInfo[] { style1, style2, style3, style4, style5, style6 };
            this.gridControl1.ColCount = 100;
            this.gridControl1.RowCount = 1000;

            //tab key navigation set as false to move the next control
            this.gridControl1.WantTabKey = false;

            #region Grid's Data
            Random rnd = new Random();

            for (int c = 1; c <= this.gridControl1.ColCount; c++)
            {
                for (int r = 1; r <= this.gridControl1.RowCount; r++)
                {
                    int v = rnd.Next(100);
                    if (v > 80)
                    {
                        GridStyleInfo style = new GridStyleInfo();
                        style.Font.Size = 10f;
                        style = styles[v % styles.Length];
                        style.CellValue = v;
                        this.gridControl1[r, c].ModifyStyle(style, Syncfusion.Styles.StyleModifyType.Override);
                    }
                }
            }

            this.gridControl1.ClipboardCopy += new GridCutPasteEventHandler(gridControl1_ClipboardCopy);
            this.gridControl1.ClipboardCanPaste += new GridCutPasteEventHandler(gridControl1_ClipboardCanPaste);
            this.gridControl1.GridVisualStyles = GridVisualStyles.Metro;
            #endregion
        }
        #endregion

        #region Event Handlers
        /// <summary>
        /// Customization for Pasting the data to grid
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void gridControl1_ClipboardCanPaste(object sender, GridCutPasteEventArgs e)
        {
            IDataObject dataObject = Clipboard.GetDataObject();
            if (dataObject != null)
            {
                if (dataObject.GetDataPresent("Biff", true))
                {

                    ExcelEngine xlEngine = new ExcelEngine();
                    IApplication app = xlEngine.Excel;
                    IWorkbooks workBook = app.Workbooks;
                    workBook.PasteWorkbook();
                    IWorkbook book = workBook[0];
                    IWorksheet worksheet = book.Worksheets[0];

                    IRange ur = worksheet.UsedRange;

                    IRange[] ranges = ur.Cells;//worksheet.UsedCells;
                    System.Text.StringBuilder str = new System.Text.StringBuilder();



                    int lastCol = ranges[0].Column, lastRow = ranges[0].Row;
                    int rc = ur.LastRow - ur.Row + 1;
                    int cc = ur.LastColumn - ur.Column + 1;

                    GridExcelConverterControl converter = new GridExcelConverterControl();
                    GridModel model = new GridModel();

                    model.ColCount = cc;
                    model.RowCount = rc;
                    ur.MoveTo(worksheet.Range[1, 1, rc, cc]);
                    ranges = worksheet.Range[1, 1, rc, cc].Cells;
                    foreach (IRange cell in ranges)
                        converter.ConvertExcelRangeToGrid(cell, model);

                    GridData data = new GridData();
                    data.InsertRows(1, rc);
                    data.InsertCols(1, cc);

                    for (int i = 1; i <= model.Data.RowCount; i++)
                        for (int j = 1; j <= model.ColCount; j++)
                            if (model.Data[i, j] != null)
                                data[i - 1, j - 1] = model.Data[i, j].Clone() as GridStyleInfoStore;

                    //Clipboard.Clear();
                    DataObject newDataObject = new DataObject(data);
                    Clipboard.SetDataObject(newDataObject, true);
                    xlEngine.ThrowNotSavedOnDestroy = false;
                    xlEngine.Dispose();

                }
            }

        }

        /// <summary>
        /// Customization for copying the data from grid
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void gridControl1_ClipboardCopy(object sender, GridCutPasteEventArgs e)
        {
            e.Handled = true;
            this.CopyStylesAsBiffToClipBoard(e.RangeList);
            this.gridControl1.Model.CutPaste.CopyCellsToClipboard(e.RangeList, true);
        }

        /// <summary>
        /// Customization for copying the styles.
        /// </summary>
        /// <param name="rangelist">Range List</param>
        private void CopyStylesAsBiffToClipBoard(GridRangeInfoList rangelist)
        {
            GridExcelConverterControl gecc = new GridExcelConverterControl();
            ExcelEngine engine = CreateEngine();
            IWorkbook book = engine.Excel.Workbooks.Create(1);
            IWorksheet sheet = book.Worksheets[0];

            foreach (GridRangeInfo range in rangelist)
            {
                range.ExpandRange(1, 1, this.gridControl1.RowCount, this.gridControl1.ColCount);

                for (int iRow = range.Top; iRow <= range.Bottom; iRow++)
                {
                    for (int iColumn = range.Left; iColumn <= range.Right; iColumn++)
                    {
                        GridStyleInfo gridCell = this.gridControl1[iRow, iColumn];
                        if (gridCell.IsEmpty) continue;
                        gecc.GridCellToExcel(this.gridControl1.Model, iRow, iColumn, sheet.Range[iRow, iColumn]);
                    }
                }
            }

            book.CopyToClipboard();
            book.Close();
            engine.Dispose();
        }

        private void btnClear_Click(object sender, System.EventArgs e)
        {
            this.gridControl1.ClearCells(GridRangeInfo.Table(), true);
            this.gridControl1.ResetColWidthEntries();
            this.gridControl1.ResetRowHeightEntries();
        }

        protected ExcelEngine CreateEngine()
        {
            ExcelEngine engine = new ExcelEngine();
            engine.ThrowNotSavedOnDestroy = false;
            return engine;
        }
        #endregion

        #region Form handlers
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

        #region Windows Form Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Syncfusion.Windows.Forms.Grid.GridRangeStyle gridRangeStyle1 = new Syncfusion.Windows.Forms.Grid.GridRangeStyle();
            Syncfusion.Windows.Forms.Grid.GridRangeStyle gridRangeStyle2 = new Syncfusion.Windows.Forms.Grid.GridRangeStyle();
            Syncfusion.Windows.Forms.Grid.GridRangeStyle gridRangeStyle3 = new Syncfusion.Windows.Forms.Grid.GridRangeStyle();
            this.gridControl1 = new Syncfusion.Windows.Forms.Grid.GridControl();
            this.btnClear = new Syncfusion.Windows.Forms.ButtonAdv();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DpiAware = true;
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gridControl1.DefaultGridBorderStyle = Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid;
            this.gridControl1.ExcelLikeCurrentCell = true;
            this.gridControl1.ExcelLikeSelectionFrame = true;
            this.gridControl1.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.gridControl1.GridOfficeScrollBars = Syncfusion.Windows.Forms.OfficeScrollBars.Metro;
            this.gridControl1.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro;
            this.gridControl1.DefaultRowHeight = (int)DpiAware.LogicalToDeviceUnits(20.0f);
            this.gridControl1.Location = new System.Drawing.Point(12, 5);
            this.gridControl1.MetroScrollBars = true;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Properties.GridLineColor = System.Drawing.Color.Silver;
            this.gridControl1.Properties.MarkColHeader = false;
            this.gridControl1.Properties.MarkRowHeader = false;
            gridRangeStyle1.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table();
            gridRangeStyle1.StyleInfo.Font.Bold = false;
            gridRangeStyle1.StyleInfo.Font.Facename = "Segoe UI";
            gridRangeStyle1.StyleInfo.Font.Italic = false;
            gridRangeStyle1.StyleInfo.Font.Size = 8.25F;
            gridRangeStyle1.StyleInfo.Font.Strikeout = false;
            gridRangeStyle1.StyleInfo.Font.Underline = false;
            gridRangeStyle1.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point;
            gridRangeStyle2.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table();
            gridRangeStyle2.StyleInfo.Font.Bold = false;
            gridRangeStyle2.StyleInfo.Font.Facename = "Segoe UI";
            gridRangeStyle2.StyleInfo.Font.Italic = false;
            gridRangeStyle2.StyleInfo.Font.Size = 8.25F;
            gridRangeStyle2.StyleInfo.Font.Strikeout = false;
            gridRangeStyle2.StyleInfo.Font.Underline = false;
            gridRangeStyle2.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point;
            gridRangeStyle3.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table();
            gridRangeStyle3.StyleInfo.Borders.Bottom = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234))))), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin);
            gridRangeStyle3.StyleInfo.Borders.Right = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234))))), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin);
            gridRangeStyle3.StyleInfo.Font.Facename = "Segoe UI";
            gridRangeStyle3.StyleInfo.Interior = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.White);
            gridRangeStyle3.StyleInfo.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gridControl1.RangeStyles.AddRange(new Syncfusion.Windows.Forms.Grid.GridRangeStyle[] {
            gridRangeStyle1,
            gridRangeStyle2,
            gridRangeStyle3});
            this.gridControl1.SerializeCellsBehavior = Syncfusion.Windows.Forms.Grid.GridSerializeCellsBehavior.SerializeAsRangeStylesIntoCode;
            this.gridControl1.Size = new System.Drawing.Size(690, 361);
            this.gridControl1.SmartSizeBox = false;
            this.gridControl1.TabIndex = 0;
            this.gridControl1.Text = "gridControl1";
            this.gridControl1.ThemesEnabled = true;
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.btnClear.FlatStyle = FlatStyle.Flat;
            this.btnClear.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.RaisedInner;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(710, 133);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(104, 30);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "Clear Grid";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Form1
            //             
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 378);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.gridControl1);           
            this.MinimumSize = new System.Drawing.Size(580, 400);
            this.Name = "Form1";            
            this.Text = "Copy Paste";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense(Syncfusion.Licensing.DemoCommon.FindLicenseKey());
            Application.Run(new Form1());
        }

        private string GetIconFile(string bitmapName)
        {
            for (int n = 0; n < 10; n++)
            {
                if (System.IO.File.Exists(bitmapName))
                    return bitmapName;

                bitmapName = @"..\" + bitmapName;
            }

            return bitmapName;
        }
        #endregion
    }
}

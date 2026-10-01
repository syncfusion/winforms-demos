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
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Syncfusion.Windows.Forms.Grid;
using Syncfusion.Windows.Forms.Tools;
using Syncfusion.Windows.Forms.Chart;
using Syncfusion.Drawing;
using Syncfusion.GridHelperClasses;
using System.Reflection;
using System.IO;
using Syncfusion.Diagnostics;
using Syncfusion.Windows.Forms;
using DemoCommon.Grid;

namespace ContentCellDemo
{
    public partial class Form1 : GridDemoForm
    {
        #region "Constructor"

        public Form1()
        {
            InitializeComponent();
            if(DpiAware.GetCurrentDpi() > 96)
            {
                this.CaptionBarHeight = (int)DpiAware.LogicalToDeviceUnits(this.CaptionBarHeight);
            }
            InitializeGrid();
            this.gridControl1.ColWidths[0] = (int)DpiAware.LogicalToDeviceUnits(25);
        }

        #endregion

        #region "Image Handlers"

        private Image GetImage(string bitmapName)
        {
            Image bitmap = null;
            try
            {
                Assembly ass = typeof(Form1).Assembly;
                string name = ass.GetName().Name;
                Stream stream = ass.GetManifestResourceStream(name + "." + bitmapName);
                bitmap = Image.FromStream(stream);
            }
            catch (Exception ex)
            {
                TraceUtil.TraceExceptionCatched(ex);
            }

            return bitmap;
        }
        #endregion

        #region "Grid Intialization"

        private void InitializeGrid()
        {
            #region "Style declaration"
            //headerstyle
            this.gridControl1.DefaultRowHeight = (int)DpiAware.LogicalToDeviceUnits(22.0f);
            GridStyleInfo headerstyle = new GridStyleInfo();
            headerstyle.Font.Size = 12;
            headerstyle.Font.Bold = true;
            headerstyle.TextColor = Color.Black;
            headerstyle.VerticalAlignment = GridVerticalAlignment.Middle;
            headerstyle.HorizontalAlignment = GridHorizontalAlignment.Center;
            headerstyle.CellType = GridCellTypeName.Static;
            //subheaderstyle
            GridStyleInfo subheaderstyle = new GridStyleInfo();
            subheaderstyle.Font.Bold = true;
            subheaderstyle.VerticalAlignment = GridVerticalAlignment.Middle;
            subheaderstyle.HorizontalAlignment = GridHorizontalAlignment.Center;
            subheaderstyle.CellType = GridCellTypeName.Static;
            
            GridStyleInfo valuestyle = new GridStyleInfo();
            valuestyle.BackColor = SystemColors.Menu;
            valuestyle.TextColor = Color.Black;
            valuestyle.VerticalAlignment = GridVerticalAlignment.Middle;
            valuestyle.HorizontalAlignment = GridHorizontalAlignment.Center;

            gridControl1.FloatCellsMode = GridFloatCellsMode.BeforeDisplayCalculation;

            int rowIndex = 1, colIndex = 2;

            #endregion

            #region "Chart in Cell"

            this.InitializeData();
            this.gridControl1.CellModels.Add("ChartCell", new GridChartCellModel(this.gridControl1.Model));
            gridControl1.CoveredRanges.Add(GridRangeInfo.Cells(rowIndex, 1, rowIndex + 1, gridControl1.ColCount));
            gridControl1[rowIndex, 1] = headerstyle;
            gridControl1[rowIndex, 1].Text = "ChartControl in GridCells";

            #region "ChartData"

            this.gridControl1.CoveredRanges.Add(GridRangeInfo.Cells(4, 4, 4, 8));
            style = this.gridControl1[4, 4];
            style.Text = "Chart Data";
            style.Font.Bold = true;
            style.Font.Facename = "Times New Roman";
            style.Font.Size = 12.75F;
            style.HorizontalAlignment = GridHorizontalAlignment.Center;
            this.gridControl1.RowHeights[4] = (int)DpiAware.LogicalToDeviceUnits(21.0f);

            GridRangeStyle rstyle = new GridRangeStyle();
            rstyle.Range = GridRangeInfo.Cell(5, 4);
            rstyle.StyleInfo.BaseStyle = "Header";
            rstyle.StyleInfo.CellType = "Header";
            rstyle.StyleInfo.Font.Bold = true;
            rstyle.StyleInfo.Font.Facename = "Verdana";
            rstyle.StyleInfo.Themed = true;
            this.gridControl1.RangeStyles.Add(rstyle);

            GridRangeStyle rstyle2 = new GridRangeStyle();
            rstyle2.Range = GridRangeInfo.Cells(5, 5, 5, 8);
            rstyle2.StyleInfo.BaseStyle = "Column Header";
            rstyle2.StyleInfo.CellType = "Header";
            rstyle2.StyleInfo.Font.Bold = true;
            rstyle2.StyleInfo.Font.Facename = "Verdana";
            rstyle2.StyleInfo.Themed = true;
            this.gridControl1.RangeStyles.Add(rstyle2);
            this.gridControl1[5, 5].Text = "Team1";
            this.gridControl1[5, 6].Text = "Team2";
            this.gridControl1[5, 7].Text = "Team3";
            this.gridControl1[5, 8].Text = "Team4";

            GridRangeStyle rstyle3 = new GridRangeStyle();
            rstyle3.Range = GridRangeInfo.Cells(6, 4, 8, 4);
            rstyle3.StyleInfo.BaseStyle = "Row Header";
            rstyle3.StyleInfo.CellType = "Header";
            rstyle3.StyleInfo.Font.Bold = true;
            rstyle3.StyleInfo.Font.Facename = "Verdana";
            rstyle3.StyleInfo.Themed = true;
            this.gridControl1.RangeStyles.Add(rstyle3);
            this.gridControl1[6, 4].Text = "Data1";
            this.gridControl1[7, 4].Text = "Data2";
            this.gridControl1[8, 4].Text = "Data3";

            #endregion

            #region "ChartControl"

            //Define the Range where the chart should be displayed (8,2,26,8) 27, 2, 28, 8));
            this.gridControl1.CoveredRanges.Add(GridRangeInfo.Cells(10, 4, 28, 10));
            this.gridControl1.CoveredRanges.Add(GridRangeInfo.Cells(29, 4, 30, 10));
            style = this.gridControl1[29, 4];
            style.Text = "Interactive Chart Cell - Try Changing the ChartData";
            style.Font.Size = 12;
            style.Font.Bold = true;
            style.Font.Facename = "Arial";
            style.HorizontalAlignment = GridHorizontalAlignment.Center;

            style = this.gridControl1[10,4];
            style.CellType = "ChartCell";
            csp = new ChartStyleProperties(style);
            csp.ChartType = ChartSeriesType.Column;
            csp.TitleText = "Chart Cell";
            csp.Series3D = false;
            csp.TitleAlignment = StringAlignment.Center;

            cm = (GridChartCellModel)this.gridControl1.CellModels["ChartCell"];
            ////Pass the CellValueRange and ChartAreaRange to cell model.
            cm.CellValueRangeInfo = GridRangeInfo.Cells(6, 5, 8, 8);
            cm.ChartAreaRangeInfo = GridRangeInfo.Cells(8, 2, 26, 9);

            #endregion

            #endregion

            #region "Grid in Cell"

            rowIndex = 32; colIndex = 4;
            gridControl1.CoveredRanges.Add(GridRangeInfo.Cells(rowIndex, 1, rowIndex + 1, gridControl1.ColCount));
            gridControl1[rowIndex, 1] = headerstyle;
            gridControl1[rowIndex, 1].Text = "GridInCells";
            rowIndex += 3;

#if HELPERCLASS
            RegisterCellModel.GridCellType(gridControl1, CustomCellTypes.GridinCell);
#else
            gridControl1.CellModels.Add("GridinCell", new GridInCellModel(gridControl1.Model));
#endif

            GridControl grid;
            this.gridControl1[rowIndex, colIndex].CellType = "GridinCell";
            this.gridControl1.CoveredRanges.Add(GridRangeInfo.Cells(rowIndex, colIndex, rowIndex + 4, 10));
            grid = new ContentCellDemo.CellEmbeddedGrid(this.gridControl1);
            grid.DpiAware = true;
            grid.RowCount = 20;
            grid.ColCount = 20;
            grid[1, 1].Text = "this is a 20x20 grid";
            grid.ThemesEnabled = true;
            grid.Office2007ScrollBars = true;
            this.gridControl1[rowIndex, colIndex].Control = grid;
            this.gridControl1.Controls.Add(grid);

            this.gridControl1.DefaultRowHeight = (int)DpiAware.LogicalToDeviceUnits(18.0f);
            this.gridControl1.DefaultColWidth = (int)DpiAware.LogicalToDeviceUnits(75.0f);
            grid.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Office2007Blue;
            this.gridControl1.Model.Options.DisplayEmptyColumns = true;
            #endregion

            #region "XHTML Cell"

            rowIndex = 42;
            gridControl1.CoveredRanges.Add(GridRangeInfo.Cells(rowIndex, 1, rowIndex + 1, gridControl1.ColCount));
            gridControl1[rowIndex, 1] = headerstyle;
            gridControl1[rowIndex, 1].Text = "XHTML Cells";
            rowIndex += 3;
            RegisterCellModel.GridCellType(gridControl1, CustomCellTypes.XhtmlCell);
            string xhtml1 = "<body style=\"font-family:Arial; line-height:1em\"> ";
            xhtml1 += "<h1 style=\"text-align:center; color:#EE7A03 \">XhtmlCells</h1>";  //#008888
            xhtml1 += "<p/>";
            xhtml1 += "<p>XhtmlCells use the RichTextBoxSupportsXHTML control from GotDotNet user samples to display XHTML formatted text inside a cell.</p>";
            xhtml1 += "</body>";

            gridControl1[rowIndex, colIndex].CellType = "XhtmlCell";
            gridControl1[rowIndex, colIndex].Text = xhtml1;
            gridControl1.RowHeights[rowIndex] = (int)DpiAware.LogicalToDeviceUnits(50.0f);
            gridControl1.CoveredRanges.Add(GridRangeInfo.Cells(rowIndex, colIndex, rowIndex + 10, colIndex+6));
            rowIndex += 10;
            rowIndex++;
            rowIndex++;

            #endregion

            #region "Calendar Cells"

            RegisterCellModel.GridCellType(gridControl1, CustomCellTypes.Calendar);
            rowIndex = 57;
            gridControl1.CoveredRanges.Add(GridRangeInfo.Cells(rowIndex, 1, rowIndex + 1, gridControl1.ColCount));
            gridControl1[rowIndex, 1] = headerstyle;
            gridControl1[rowIndex, 1].Text = "Calendar Cells";
            rowIndex += 3;

            gridControl1.CoveredRanges.Add(GridRangeInfo.Cells(rowIndex, 4, rowIndex + 8, 6));
            style = gridControl1[rowIndex, 4];
            style.CellType = "Calendar";
            style.Control = new MonthCalendar(); 

            gridControl1.CoveredRanges.Add(GridRangeInfo.Cells(rowIndex, 8, rowIndex +8 , 10));
            style = gridControl1[rowIndex, 8];
            style.CellType = "Calendar";
            style.Control = new MonthCalendar(); 

            #endregion

            #region "PictureBoxCells"
            rowIndex = 71;
            gridControl1.CoveredRanges.Add(GridRangeInfo.Cells(rowIndex, 1, rowIndex + 1, gridControl1.ColCount));
            gridControl1[rowIndex, 1] = headerstyle;
            gridControl1[rowIndex, 1].Text = "PictureBox Cells";
            rowIndex += 3;

            RegisterCellModel.GridCellType(gridControl1, CustomCellTypes.PictureBox);

            Syncfusion.GridHelperClasses.PictureBoxStyleProperties tsp = new Syncfusion.GridHelperClasses.PictureBoxStyleProperties(new GridStyleInfo(gridControl1.TableStyle));
            tsp.SizeMode = PictureBoxSizeMode.StretchImage;
            Syncfusion.GridHelperClasses.PictureBoxStyleProperties sp;
            gridControl1.CoveredRanges.Add(GridRangeInfo.Cells(rowIndex, 4, rowIndex + 6, 6));
            style = gridControl1[rowIndex , 4];
            style.CellType = "PictureBox";
            sp = new Syncfusion.GridHelperClasses.PictureBoxStyleProperties(style);
            sp.Image = GetImage("car1.jpg");
            sp.SizeMode = PictureBoxSizeMode.StretchImage;
            gridControl1.CoveredRanges.Add(GridRangeInfo.Cells(rowIndex, 8, rowIndex + 6, 10));
            style = gridControl1[rowIndex, 8];
            style.CellType = "PictureBox";
            sp = new Syncfusion.GridHelperClasses.PictureBoxStyleProperties(style);
            sp.Image = GetImage("car2.jpg");
            sp.SizeMode = PictureBoxSizeMode.StretchImage;

            #endregion
            this.gridControl1.CurrentCellEditingComplete += new EventHandler(gridControl1_CurrentCellEditingComplete);
        }

        void gridControl1_CurrentCellEditingComplete(object sender, EventArgs e)
        {
            this.gridControl1.Refresh();
        }
        #endregion

        #region "API Definition"

        GridChartCellModel cm;
        GridStyleInfo style;
        ChartStyleProperties csp;

        #endregion

        #region "ChartData"

        /// <summary>
        /// Intializing the Data
        /// </summary>
        private void InitializeData()
        {
            Random random = new Random();
            for (int i = 6; i <= 8; i++)
                for (int j = 5; j <= 8; j++)
                {
                    double value = random.Next(10, 60);
                    style = this.gridControl1[i, j];
                    style.CellValue = value;
                    style.Font.Facename = "Tahoma";
                    style.Font.Size = 9f;
                    style.CellValueType = typeof(double);
                }
        }
        #endregion   
    }
}
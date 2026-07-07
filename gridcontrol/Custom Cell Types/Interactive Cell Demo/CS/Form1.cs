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
using Syncfusion.Windows.Forms;
using Syncfusion.GridHelperClasses;
using System.IO;
using DemoCommon.Grid;

namespace InteractiveCellDemo
{
    public partial class Form1 : GridDemoForm
    {
        #region "Constructor"

        public Form1()
        {
            InitializeComponent();
            this.gridControl1.DpiAware = true;
            if (DpiAware.GetCurrentDpi() > 96)
            {
                this.CaptionBarHeight = (int)DpiAware.LogicalToDeviceUnits(this.CaptionBarHeight);
            }
            InitializeGrid();
            this.gridControl1.ColWidths.ResizeToFit(GridRangeInfo.Table(), GridResizeToFitOptions.IncludeCellsWithinCoveredRange);
            this.gridControl1.ColWidths[0] = (int)DpiAware.LogicalToDeviceUnits(25);
        }

        #endregion

        #region "Icon Handlers
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

#if HELPERCLASS
		Syncfusion.GridHelperClasses.ButtonEditStyleProperties bsp;
#else
        ButtonEditStyleProperties bsp;
#endif

        private void InitializeGrid()
        {

            #region "Style declaration"
            //headerStyle
            this.gridControl1.DefaultRowHeight = (int)DpiAware.LogicalToDeviceUnits(22.0f);
            GridStyleInfo headerstyle = new GridStyleInfo();
            headerstyle.Font.Size = 12;
            headerstyle.Font.Bold = true;
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
            #endregion

            gridControl1.BeginUpdate();

            #region "CellButton"

            int rowIndex = 1, colIndex = 5;
            gridControl1.CoveredRanges.Add(GridRangeInfo.Cells(rowIndex, 1, rowIndex + 1, gridControl1.ColCount));
            gridControl1[rowIndex, 1] = headerstyle;
            gridControl1[rowIndex, 1].Text = "Cell Buttons";
            gridControl1.CellModels.Add("DragButton", new DragButtonCellModel(gridControl1.Model));
            rowIndex = 4;
            gridControl1[rowIndex, 2].Text = "Press and Drag Button";
            gridControl1[rowIndex, 2].Font.Bold = true;
            gridControl1[rowIndex, 4].CellType = "DragButton";
            gridControl1.CoveredRanges.Add(GridRangeInfo.Cells(rowIndex, 2, rowIndex, 3));

            gridControl1.CellModels.Add("EllipsisText", new EllipsisCellModel(gridControl1.Model));
            gridControl1[rowIndex, 8].Text = "Browse Me";
            gridControl1[rowIndex, 8].Font.Bold = true;
            gridControl1[rowIndex, 8].CellType = "EllipsisText";
            //gridControl1.ColWidths.ResizeToFit(GridRangeInfo.Cells(3, 6, 10, 6));



            gridControl1.Model.CellModels.Add("MultipleButton", new MultipleButtonGridCell.MultipleButtonCellModel(gridControl1.Model));
            rowIndex = 6;
            gridControl1[rowIndex, 2].Text = "MultiButtonCell";
            gridControl1[rowIndex, 2].Font.Bold = true;
            //gridControl1.ColWidths.ResizeToFit(GridRangeInfo.Cells(6, 2, 8, 2));
            gridControl1.CoveredRanges.Add(GridRangeInfo.Cells(6, 4, 6, 5));
            gridControl1.QueryCellInfo += new GridQueryCellInfoEventHandler(gridControl1_QueryCellInfo);
            #endregion

            #region "OleContainerCell"

            colIndex = 2;
            RegisterCellModel.GridCellType(this.gridControl1, CustomCellTypes.OleContainerCell);
            rowIndex += 3;
            gridControl1.CoveredRanges.Add(GridRangeInfo.Cells(rowIndex, 1, rowIndex + 1, gridControl1.ColCount));
            gridControl1.CellModels.Add("LinkLabelCell", new LinkLabelCellModel(gridControl1.Model));
            gridControl1[rowIndex, 1] = headerstyle;
            gridControl1[rowIndex, 1].Text = "OLEContainer Cell";

            rowIndex += 2;
            gridControl1.CoveredRanges.Add(GridRangeInfo.Cells(rowIndex, 1, rowIndex + 1, gridControl1.ColCount));
            gridControl1[rowIndex, 1] = subheaderstyle;
            gridControl1[rowIndex, 1].Text = "Click the image to open the file with its default file handler";

            rowIndex += 3;
            gridControl1.CoveredRanges.Add(GridRangeInfo.Cells(rowIndex, colIndex, rowIndex + 2, colIndex));
            gridControl1[rowIndex, colIndex].CellType = CustomCellTypes.OleContainerCell.ToString();
            gridControl1[rowIndex, colIndex].Description = GetIconFile(@"Data\DocIO\SalesInvoiceDemo.doc");

            colIndex = 4;
            gridControl1.CoveredRanges.Add(GridRangeInfo.Cells(rowIndex, colIndex, rowIndex + 2, colIndex));
            gridControl1[rowIndex, colIndex].CellType = CustomCellTypes.OleContainerCell.ToString();
            gridControl1[rowIndex, colIndex].Description = GetIconFile(@"Data\XlsIO\BudgetPlanner.xls");

            colIndex = 6;
            gridControl1.CoveredRanges.Add(GridRangeInfo.Cells(rowIndex, colIndex, rowIndex + 2, colIndex));
            gridControl1[rowIndex, colIndex].CellType = CustomCellTypes.OleContainerCell.ToString();
            gridControl1[rowIndex, colIndex].Description = GetIconFile(@"Data\PDF\CaseStudy.pdf");

            colIndex = 2;
            rowIndex += 4;
            gridControl1.CoveredRanges.Add(GridRangeInfo.Cells(rowIndex, colIndex, rowIndex + 2, colIndex));
            gridControl1[rowIndex, colIndex].CellType = CustomCellTypes.OleContainerCell.ToString();
            gridControl1[rowIndex, colIndex].Description = GetIconFile(@"Data\DocIO\Arabic.txt");

            colIndex = 4;
            gridControl1.CoveredRanges.Add(GridRangeInfo.Cells(rowIndex, colIndex, rowIndex + 2, colIndex));
            gridControl1[rowIndex, colIndex].CellType = CustomCellTypes.OleContainerCell.ToString();
            gridControl1[rowIndex, colIndex].Description = GetIconFile(@"Common\Images\Grid\CustomBorder\back3.jpg");

            colIndex = 6;
            gridControl1.CoveredRanges.Add(GridRangeInfo.Cells(rowIndex, colIndex, rowIndex + 2, colIndex));
            gridControl1[rowIndex, colIndex].CellType = CustomCellTypes.OleContainerCell.ToString();
            gridControl1[rowIndex, colIndex].Description = @"http://www.syncfusion.com/";

            gridControl1[13, 8] = subheaderstyle;
            gridControl1[13, 8].Text = "Preview";
            gridControl1[13, 8].BackColor = Color.LightGray;

            gridControl1.CoveredRanges.Add(GridRangeInfo.Cells(14, 8, 16, 8));

            gridControl1[17, 8].CellType = GridCellTypeName.PushButton;
            gridControl1[17, 8].Description = "Select a file for preview";
            this.gridControl1.Model.ColWidths[8] = (int)DpiAware.LogicalToDeviceUnits(127);
            rowIndex++;

            colIndex = 5;


            #endregion

            #region "SliderCells"
            rowIndex += 3;
            gridControl1.CoveredRanges.Add(GridRangeInfo.Cells(rowIndex, 1, rowIndex + 1, gridControl1.ColCount));
            gridControl1[rowIndex, 1] = headerstyle;
            gridControl1[rowIndex, 1].Text = "Slider Cells";

            gridControl1.CellModels.Add("Slider", new SliderCellModel(gridControl1.Model));
            rowIndex += 3;

            SliderStyleProperties tsp = new SliderStyleProperties(new GridStyleInfo(gridControl1.TableStyle));
            tsp.Orientation = Orientation.Horizontal;

            GridStyleInfo style;
            SliderStyleProperties sp;

            gridControl1.CoveredRanges.Add(GridRangeInfo.Cells(rowIndex, 3, rowIndex + 1, 4));
            style = gridControl1[rowIndex, 3];
            sp = new SliderStyleProperties(style);
            style.CellType = "Slider";
            sp.Maximum = 60;
            sp.Minimum = 0;
            sp.TickFrequency = 8;
            sp.LargeChange = 16;
            sp.SmallChange = 4;
            sp.Orientation = Orientation.Horizontal;

            gridControl1.CoveredRanges.Add(GridRangeInfo.Cells(rowIndex, 5, rowIndex + 1, 5));
            style = gridControl1[rowIndex, 5];
            sp = new SliderStyleProperties(style);
            style.CellType = "Slider";
            sp.Maximum = 40;
            sp.Minimum = 0;
            sp.TickFrequency = 8;
            sp.LargeChange = 16;
            sp.SmallChange = 4;
            sp.Orientation = Orientation.Horizontal;

            gridControl1.CoveredRanges.Add(GridRangeInfo.Cells(rowIndex, 6, rowIndex + 7, 6));
            style = gridControl1[rowIndex, 6];
            sp = new SliderStyleProperties(style);
            style.CellType = "Slider";
            sp.Maximum = 40;
            sp.Minimum = 0;
            sp.TickFrequency = 8;
            sp.LargeChange = 16;
            sp.SmallChange = 4;
            sp.Orientation = Orientation.Vertical;
            gridControl1.EndUpdate(true);
            #endregion

            #region "ButtonEdit Cells"
            rowIndex = 31;

#if HELPERCLASS
            // Added from the source of Syncfusion.GridHelperClasses
            RegisterCellModel.GridCellType(gridControl1, CustomCellTypes.ButtonEdit);
#else
            this.gridControl1.CellModels.Add("ButtonEdit", new ButtonEditCellModel(this.gridControl1.Model));
#endif
            gridControl1.CoveredRanges.Add(GridRangeInfo.Cells(rowIndex, 1, rowIndex + 1, gridControl1.ColCount));
            gridControl1[rowIndex, 1] = headerstyle;
            gridControl1[rowIndex, 1].Text = "Button Edit Cells";
            rowIndex++; rowIndex++;
            gridControl1.CoveredRanges.Add(GridRangeInfo.Cells(rowIndex, 1, rowIndex, gridControl1.ColCount));
            gridControl1[rowIndex, 1] = subheaderstyle;
            gridControl1[rowIndex, 1].Text = "ButtonEdit displaying common images and getting from file";
            rowIndex++; rowIndex++;
            gridControl1[rowIndex, 2].FloatCell = true;
            gridControl1[rowIndex, 2].Text = "Common Images";
            gridControl1[rowIndex, 2].TextColor = Color.Black;
            gridControl1[rowIndex, 4].CellType = "ButtonEdit";

#if HELPERCLASS
			bsp = new Syncfusion.GridHelperClasses.ButtonEditStyleProperties(this.gridControl1[rowIndex, 4]);
            bsp.ButtonEditInfo.ButtonEditType = Syncfusion.GridHelperClasses.ButtonType.Check;
#else
            bsp = new ButtonEditStyleProperties(gridControl1[rowIndex, 4]);
            bsp.ButtonEditInfo.ButtonEditType = ButtonType.Check;
#endif

            gridControl1[rowIndex, 5].CellType = "ButtonEdit";

#if HELPERCLASS
			bsp = new Syncfusion.GridHelperClasses.ButtonEditStyleProperties(gridControl1[rowIndex, 5]);
            bsp.ButtonEditInfo.ButtonEditType = ButtonType.Down;
#else
            bsp = new ButtonEditStyleProperties(gridControl1[rowIndex, 5]);
            bsp.ButtonEditInfo.ButtonEditType = ButtonType.Down;
#endif
            gridControl1[rowIndex, 6].CellType = "ButtonEdit";

#if HELPERCLASS
			bsp = new Syncfusion.GridHelperClasses.ButtonEditStyleProperties(gridControl1[rowIndex, 6]);
            bsp.ButtonEditInfo.ButtonEditType = ButtonType.Undo;
#else
            bsp = new ButtonEditStyleProperties(gridControl1[rowIndex, 6]);
            bsp.ButtonEditInfo.ButtonEditType = ButtonType.Undo;
#endif
            rowIndex++; rowIndex++;
            gridControl1[rowIndex, 2].FloatCell = true;
            gridControl1[rowIndex, 2].Text = "From File";
            gridControl1[rowIndex, 2].TextColor = Color.Black;
            gridControl1[rowIndex, 4].CellType = "ButtonEdit";

#if HELPERCLASS
			bsp = new Syncfusion.GridHelperClasses.ButtonEditStyleProperties(gridControl1[rowIndex, 4]);
            bsp.ButtonEditInfo.ButtonEditType = ButtonType.Image;
#else
            bsp = new ButtonEditStyleProperties(gridControl1[rowIndex, 4]);
            bsp.ButtonEditInfo.ButtonEditType = ButtonType.Image;
#endif
#if NETCORE
            Image bmp = Image.FromFile(@"..//..//..//delete.png");
#else
            Image bmp = Image.FromFile(@"..//..//delete.png");
#endif
            bsp.ButtonEditInfo.Image = bmp;

            gridControl1[rowIndex, 5].CellType = "ButtonEdit";
#if HELPERCLASS
			bsp = new Syncfusion.GridHelperClasses.ButtonEditStyleProperties(gridControl1[rowIndex, 5]);
            bsp.ButtonEditInfo.ButtonEditType = ButtonType.Image;
#else
            bsp = new ButtonEditStyleProperties(gridControl1[rowIndex, 5]);
            bsp.ButtonEditInfo.ButtonEditType = ButtonType.Image;
#endif
#if NETCORE
            bmp = Image.FromFile(@"..//..//..//about.png");
#else
            bmp = Image.FromFile(@"..//..//about.png");
#endif
            bsp.ButtonEditInfo.Image = bmp;
            gridControl1[rowIndex, 6].CellType = "ButtonEdit";
#if HELPERCLASS
			bsp = new Syncfusion.GridHelperClasses.ButtonEditStyleProperties(gridControl1[rowIndex, 6]);
            bsp.ButtonEditInfo.ButtonEditType = ButtonType.Image;
#else
            bsp = new ButtonEditStyleProperties(gridControl1[rowIndex, 6]);
            bsp.ButtonEditInfo.ButtonEditType = ButtonType.Image;
#endif
#if NETCORE
            bmp = Image.FromFile(@"..//..//..//disk_blue.png");
#else
            bmp = Image.FromFile(@"..//..//disk_blue.png");
#endif
            bsp.ButtonEditInfo.Image = bmp;


            rowIndex++; rowIndex++;
            gridControl1.CoveredRanges.Add(GridRangeInfo.Cells(rowIndex, 1, rowIndex, gridControl1.ColCount));
            gridControl1[rowIndex, 1] = subheaderstyle;
            gridControl1[rowIndex, 1].Text = "ButtonEdit cell with formatting options like textcolor, alignment, borders..";
            rowIndex++; rowIndex++;
            gridControl1[rowIndex, 2].FloatCell = true;
            gridControl1[rowIndex, 2].Text = "With Colors";
            gridControl1[rowIndex, 2].TextColor = Color.Black;

            gridControl1[rowIndex, 4].CellType = "ButtonEdit";
#if HELPERCLASS
			bsp = new Syncfusion.GridHelperClasses.ButtonEditStyleProperties(gridControl1[rowIndex, 4]);
            bsp.ButtonEditInfo.ButtonEditType = ButtonType.None;
#else
            bsp = new ButtonEditStyleProperties(gridControl1[rowIndex, 4]);
            bsp.ButtonEditInfo.ButtonEditType = ButtonType.None;
#endif
            bsp.ButtonEditInfo.ForceBackColor = true;
            bsp.ButtonEditInfo.BackColor = Color.LightGreen;

            gridControl1[rowIndex, 5].CellType = "ButtonEdit";
#if HELPERCLASS
			bsp = new Syncfusion.GridHelperClasses.ButtonEditStyleProperties(gridControl1[rowIndex, 5]);
            bsp.ButtonEditInfo.ButtonEditType = ButtonType.None;
#else
            bsp = new ButtonEditStyleProperties(gridControl1[rowIndex, 5]);
            bsp.ButtonEditInfo.ButtonEditType = ButtonType.None;
#endif
            bsp.ButtonEditInfo.ForceBackColor = true;
            bsp.ButtonEditInfo.BackColor = Color.LightPink;

            gridControl1[rowIndex, 6].CellType = "ButtonEdit";
#if HELPERCLASS
			bsp = new Syncfusion.GridHelperClasses.ButtonEditStyleProperties(gridControl1[rowIndex, 6]);
            bsp.ButtonEditInfo.ButtonEditType = ButtonType.None;
#else
            bsp = new ButtonEditStyleProperties(gridControl1[rowIndex, 6]);
            bsp.ButtonEditInfo.ButtonEditType = ButtonType.None;
#endif
            bsp.ButtonEditInfo.ForceBackColor = true;
            bsp.ButtonEditInfo.BackColor = Color.LightSkyBlue;

            rowIndex++; rowIndex++;
            gridControl1[rowIndex, 2].FloatCell = true;
            gridControl1[rowIndex, 2].Text = "Text Alignment";
            gridControl1[rowIndex, 2].TextColor = Color.Black;

            gridControl1[rowIndex, 4].CellType = "ButtonEdit";
#if HELPERCLASS
			bsp = new Syncfusion.GridHelperClasses.ButtonEditStyleProperties(gridControl1[rowIndex, 4]);
            bsp.ButtonEditInfo.ButtonEditType = ButtonType.None;
#else
            bsp = new ButtonEditStyleProperties(gridControl1[rowIndex, 4]);
            bsp.ButtonEditInfo.ButtonEditType = ButtonType.None;
#endif
            bsp.ButtonEditInfo.Width = (int)DpiAware.LogicalToDeviceUnits(50);
            bsp.ButtonEditInfo.Text = "Sync";
            bsp.ButtonEditInfo.HorizontalAlignment = GridHorizontalAlignment.Right;
            bsp.ButtonEditInfo.VerticalAlignment = GridVerticalAlignment.Top;

            gridControl1[rowIndex, 5].CellType = "ButtonEdit";
#if HELPERCLASS
			bsp = new Syncfusion.GridHelperClasses.ButtonEditStyleProperties(gridControl1[rowIndex, 5]);
            bsp.ButtonEditInfo.ButtonEditType = ButtonType.None;
#else
            bsp = new ButtonEditStyleProperties(gridControl1[rowIndex, 5]);
            bsp.ButtonEditInfo.ButtonEditType = ButtonType.None;
#endif
            bsp.ButtonEditInfo.Width = (int)DpiAware.LogicalToDeviceUnits(50);
            bsp.ButtonEditInfo.Text = "Sync";
            bsp.ButtonEditInfo.HorizontalAlignment = GridHorizontalAlignment.Left;
            bsp.ButtonEditInfo.VerticalAlignment = GridVerticalAlignment.Bottom;

            gridControl1[rowIndex, 6].CellType = "ButtonEdit";
#if HELPERCLASS
			bsp = new Syncfusion.GridHelperClasses.ButtonEditStyleProperties(gridControl1[rowIndex, 6]);
            bsp.ButtonEditInfo.ButtonEditType = ButtonType.None;
#else
            bsp = new ButtonEditStyleProperties(gridControl1[rowIndex, 6]);
            bsp.ButtonEditInfo.ButtonEditType = ButtonType.None;
#endif
            bsp.ButtonEditInfo.Width = (int)DpiAware.LogicalToDeviceUnits(50);
            bsp.ButtonEditInfo.Text = "Sync";
            bsp.ButtonEditInfo.HorizontalAlignment = GridHorizontalAlignment.Center;
            bsp.ButtonEditInfo.VerticalAlignment = GridVerticalAlignment.Middle;

            rowIndex++; rowIndex++;
            gridControl1[rowIndex, 2].FloatCell = true;
            gridControl1[rowIndex, 2].Text = "Button Alignment with Left & Right";
            gridControl1[rowIndex, 2].TextColor = Color.Black;

            gridControl1.Model.RowHeights[rowIndex] = (int)DpiAware.LogicalToDeviceUnits(20);

            gridControl1[rowIndex, 5].CellType = "ButtonEdit";
#if HELPERCLASS
			bsp = new Syncfusion.GridHelperClasses.ButtonEditStyleProperties(gridControl1[rowIndex, 5]);
            bsp.ButtonEditInfo.ButtonEditType = ButtonType.Leftend;
#else
            bsp = new ButtonEditStyleProperties(gridControl1[rowIndex, 5]);
            bsp.ButtonEditInfo.ButtonEditType = ButtonType.Leftend;
#endif
            bsp.ButtonEditInfo.IsLeft = true;

            gridControl1[rowIndex, 6].CellType = "ButtonEdit";
#if HELPERCLASS
			bsp = new Syncfusion.GridHelperClasses.ButtonEditStyleProperties(gridControl1[rowIndex, 6]);
            bsp.ButtonEditInfo.ButtonEditType = ButtonType.Rightend;
#else
            bsp = new ButtonEditStyleProperties(gridControl1[rowIndex, 6]);
            bsp.ButtonEditInfo.ButtonEditType = ButtonType.Rightend;
#endif
            bsp.ButtonEditInfo.IsLeft = false;

            rowIndex++; rowIndex++;
            gridControl1[rowIndex, 2].FloatCell = true;
            gridControl1[rowIndex, 2].Text = "Border around button";
            gridControl1[rowIndex, 2].TextColor = Color.Black;

            gridControl1[rowIndex, 5].CellType = "ButtonEdit";
#if HELPERCLASS
			bsp = new Syncfusion.GridHelperClasses.ButtonEditStyleProperties(gridControl1[rowIndex, 5]);
#else
            bsp = new ButtonEditStyleProperties(gridControl1[rowIndex, 5]);
#endif
            bsp.ButtonEditInfo.Width = (int)DpiAware.LogicalToDeviceUnits(30);

#if HELPERCLASS
            ((Syncfusion.GridHelperClasses.ButtonEditCellModel)this.gridControl1.CellModels["ButtonEdit"]).GridDrawButtonFace += new Syncfusion.GridHelperClasses.ButtonEditCellModel.GridDrawButtonFaceEventHandler(Form1_GridDrawButtonFace);
#else
            ((ButtonEditCellModel)this.gridControl1.CellModels["ButtonEdit"]).GridDrawButtonFace += new ButtonEditCellModel.GridDrawButtonFaceEventHandler(Form1_GridDrawButtonFace);
#endif
#endregion

#region "LinkLabel"

            rowIndex += 3;
            gridControl1.CoveredRanges.Add(GridRangeInfo.Cells(rowIndex, 1, rowIndex + 1, gridControl1.ColCount));
            //gridControl1.CellModels.Add("LinkLabelCell", new LinkLabelCellModel(gridControl1.Model));
            gridControl1[rowIndex, 1] = headerstyle;
            gridControl1[rowIndex, 1].Text = "Link Label Cells";

            rowIndex += 3;
            gridControl1[rowIndex, colIndex].CellType = "LinkLabelCell";
            gridControl1[rowIndex, colIndex].Text = "Syncfusion, Inc.";
            gridControl1[rowIndex, colIndex].Font.Bold = true;
            gridControl1[rowIndex, colIndex].Tag = "http://www.syncfusion.com";
            gridControl1[rowIndex, colIndex].HorizontalAlignment = GridHorizontalAlignment.Center;

            rowIndex++; rowIndex++;
            gridControl1[rowIndex, colIndex].CellType = "LinkLabelCell";
            gridControl1[rowIndex, colIndex].Text = "Windows Forms FAQ";
            gridControl1[rowIndex, colIndex].Font.Bold = true;
            gridControl1[rowIndex, colIndex].Tag = "http://www.syncfusion.com/support/forums/grid-windows";
            gridControl1[rowIndex, colIndex].HorizontalAlignment = GridHorizontalAlignment.Center;

            rowIndex++; rowIndex++;
            gridControl1[rowIndex, colIndex].CellType = "LinkLabelCell";
            gridControl1[rowIndex, colIndex].Text = "Microsoft Windows Forms";
            gridControl1[rowIndex, colIndex].Font.Bold = true;
            gridControl1[rowIndex, colIndex].Tag = "http://windowsforms.net/";
            gridControl1[rowIndex, colIndex].HorizontalAlignment = GridHorizontalAlignment.Center;

            rowIndex++; rowIndex++;
            gridControl1[rowIndex, colIndex].CellType = "LinkLabelCell";
            gridControl1[rowIndex, colIndex].Text = "MSDN";
            gridControl1[rowIndex, colIndex].Font.Bold = true;
            gridControl1[rowIndex, colIndex].Tag = "http://msdn.microsoft.com";
            gridControl1[rowIndex, colIndex].HorizontalAlignment = GridHorizontalAlignment.Center;

            //gridControl1.ColWidths.ResizeToFit(GridRangeInfo.Cells(9, 5, 17, 5));
#endregion

            this.gridControl1.Model.Options.DisplayEmptyColumns = true;
            this.gridControl1.Model.Options.DisplayEmptyRows = true;
            gridControl1.EndUpdate(true);
            gridControl1.Refresh();
        }

#region "Events"

        /// <summary>
        /// Set the CellType based on specified index
        /// </summary>
        void gridControl1_QueryCellInfo(object sender, GridQueryCellInfoEventArgs e)
        {
            if (e.ColIndex == 4 && e.RowIndex == 6)
            {
                e.Style.CellType = "MultipleButton";
                e.Style.Description = "Click";
            }
        }

        /// <summary>
        /// Used to draw border lines around the button
        /// </summary>
        void Form1_GridDrawButtonFace(object sender, GridDrawButtonFaceEventArgs e)
        {
            if (e.RowIndex == 47 && e.ColIndex == 5)
            {
                Brush br = new SolidBrush(Color.SaddleBrown);
                Pen pn = new Pen(Color.SaddleBrown, 2);

                // Draw border around the button
                e.Graphics.DrawLine(pn, new Point(e.Button.Bounds.X + 2, e.Button.Bounds.Y + 2), new Point(e.Button.Bounds.X + e.Button.Bounds.Width - 2, e.Button.Bounds.Y + 2));
                e.Graphics.DrawLine(pn, new Point(e.Button.Bounds.X + 2, e.Button.Bounds.Y + 2), new Point(e.Button.Bounds.X + 2, e.Button.Bounds.Y + e.Button.Bounds.Height - 2));
                e.Graphics.DrawLine(pn, new Point(e.Button.Bounds.X + 2, e.Button.Bounds.Y + e.Button.Bounds.Height - 2), new Point(e.Button.Bounds.X + e.Button.Bounds.Width - 2, e.Button.Bounds.Y + e.Button.Bounds.Height - 2));
                e.Graphics.DrawLine(pn, new Point(e.Button.Bounds.X + e.Button.Bounds.Width - 2, e.Button.Bounds.Y + 2), new Point(e.Button.Bounds.X + e.Button.Bounds.Width - 2, e.Button.Bounds.Y + e.Button.Bounds.Height - 2));

                e.Handled = true;
            }
        }

        /// <summary>
        /// Display the folder browser dialog.
        /// </summary>
        private void gridControl1_CellButtonClicked(object sender, GridCellButtonClickedEventArgs e)
        {
            GridRangeInfo rg = GridRangeInfo.Cell(e.RowIndex, e.ColIndex);
            if (e.ColIndex == 7)
                MessageBox.Show("Clicked button at " + rg.ToString());
            if (e.ColIndex == 8)
            {
                DialogResult result = openFileDialog1.ShowDialog();
                if (result == DialogResult.OK)
                {
                    string file = openFileDialog1.FileName;
                    try
                    {
                        setFile(file);
                    }
                    catch (IOException)
                    {
                    }
                }
            }
            if (e.ColIndex == 6)
            {
                DialogResult result = openFileDialog1.ShowDialog();
                if (result == DialogResult.OK)
                {
                    string file = openFileDialog1.FileName;
                    try
                    {
                        MessageBox.Show("File is selected");
                    }
                    catch (IOException)
                    {
                    }
                }
            }
            if (e.ColIndex == 4 && e.RowIndex == 6)
            {
                MessageBox.Show("Clicked Button: " + e.Button.Text + "\nRow Index: " + e.RowIndex + "\nColumn Index: " + e.ColIndex, "Click Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// Set the file for grid control for specified cell
        /// </summary>
        private void setFile(string address)
        {
            int rowIndex = 14, colIndex = 8;
            this.gridControl1[rowIndex, colIndex].CellType = CustomCellTypes.OleContainerCell.ToString();
            this.gridControl1[rowIndex, colIndex].Description = address;
        }

#endregion
    }
}
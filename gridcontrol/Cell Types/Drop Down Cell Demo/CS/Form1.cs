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
using System.Collections.Specialized;
using System.Collections;
using DemoCommon.Grid;

namespace DropDownCellDemo
{
    /// <summary>
    /// Summary description for Form1.
    /// </summary>
    public partial class Form1 : GridDemoForm
    {
        #region "API Definition"

        internal DataSet1 dataSet11;
        string rtf2;

        #endregion

        #region "Constructor"

        public Form1()
        {
            //
            // Required for Windows Form Designer support
            //
            dataSet11 = new DataSet1();
            InitializeComponent();
            if (DpiAware.GetCurrentDpi() > 96)
            {
                this.CaptionBarHeight = (int)DpiAware.LogicalToDeviceUnits(this.CaptionBarHeight);
            }
            // read the data from a local XML file
            ReadXml(this.dataSet11, @"Common\Data\GDBDdata.XML");

            InitializeGrid();

            this.GridSettings();
        }

        #endregion

        #region "Grid Settings"
        /// <summary>
        /// Grid Settings for better look and feel
        /// </summary>
        private void GridSettings()
        {
            //Used to set default row height
            this.gridControl1.DefaultRowHeight = (int)DpiAware.LogicalToDeviceUnits(22.0f);
            this.gridControl1.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro;
            this.gridControl1.Model.Options.DisplayEmptyColumns = true;
            this.gridControl1.Model.Options.DisplayEmptyRows = true;
        }
        #endregion

        #region "XML handlers"
        //hunt the folder tree for the data\*.xml file..
        void ReadXml(DataSet ds, string xmlFileName)
        {
            if (ds == null)
                return;

            for (int n = 0; n < 10; n++)
            {
                if (System.IO.File.Exists(xmlFileName))
                {
                    ds.ReadXml(xmlFileName);
                    break;
                }
                xmlFileName = @"..\" + xmlFileName;
            }
        }

        #endregion

        #region "Grid Initialization"

        private void InitializeGrid()
        {
            this.gridControl1.BeginUpdate();

            #region Cell Styles
            gridControl1.TableStyle.FloatCell = true;
            gridControl1.FloatCellsMode = GridFloatCellsMode.BeforeDisplayCalculation;
            gridControl1.ColWidths[3] = (int)DpiAware.LogicalToDeviceUnits(90);
          
            gridControl1.CoveredRanges.Add(GridRangeInfo.Cells(1, 1, 2, gridControl1.ColCount));
            gridControl1[1, 1].CellValue = "DropDown Cells";
            gridControl1[1, 1].Font.Size = 14;
            gridControl1[1, 1].Font.Bold = true;
            gridControl1[1, 1].VerticalAlignment = GridVerticalAlignment.Middle;
            gridControl1[1, 1].HorizontalAlignment = GridHorizontalAlignment.Center;
            gridControl1[1, 1].CellType = "Static";
            this.gridControl1.CheckBoxClick += new GridCellClickEventHandler(gridControl1_CheckBoxClick);
            #endregion

            #region DataSources
            //
            // Creating DataSource
            //
            StringCollection items = new StringCollection();
            items.Add("One");
            items.Add("Two");
            items.Add("Three");
            items.Add("Four");
            items.Add("Five");
            items.Add("Six");
            items.Add("Seven");
            items.Add("Eight");
            items.Add("Nine");
            items.Add("Ten");
            ImageList imageList = new ImageList();
            imageList.Images.Add(SystemIcons.Warning.ToBitmap());
            imageList.Images.Add(SystemIcons.Application.ToBitmap());
            imageList.Images.Add(SystemIcons.Asterisk.ToBitmap());
            imageList.Images.Add(SystemIcons.Error.ToBitmap());
            imageList.Images.Add(SystemIcons.Information.ToBitmap());
            imageList.Images.Add(SystemIcons.Question.ToBitmap());
            this.gridControl1.TableStyle.ImageList = imageList;

            ArrayList icons = new ArrayList();
            icons.Add(new IconDesc("Warning", "WA", 0));
            icons.Add(new IconDesc("Application", "AP", 1));
            icons.Add(new IconDesc("Asterisk", "AS", 2));
            icons.Add(new IconDesc("Error", "ER", 3));
            icons.Add(new IconDesc("Information", "INF", 4));
            icons.Add(new IconDesc("Question", "QUE", 5));

            #endregion

            #region ComboBox Cells
            this.gridControl1.Model.EnableGridListControlInComboBox = false;
            int rowIndex = 4;
            gridControl1.CoveredRanges.Add(GridRangeInfo.Cells(rowIndex, 1, rowIndex, gridControl1.ColCount));
            gridControl1[rowIndex, 1].CellType = GridCellTypeName.CheckBox;
            gridControl1[rowIndex, 1].Description = "ComboBox with AutoComplete in Editmode";
            gridControl1[rowIndex, 1].Font.Bold = true;
            AddChoices(ref rowIndex, "ComboBox", items, null, "", "");
            for (int i = 5; i <= 8; i++)
            {
                this.gridControl1.HideRows[i] = true;
            }

            // ComboBox using ChoiceList
            rowIndex = 10;
            gridControl1.CoveredRanges.Add(GridRangeInfo.Cells(rowIndex - 1, 1, rowIndex - 1, gridControl1.ColCount));
            gridControl1.CoveredRanges.Add(GridRangeInfo.Cells(rowIndex, 1, rowIndex, gridControl1.ColCount));
            gridControl1[rowIndex, 1].CellType = GridCellTypeName.CheckBox;
            gridControl1[rowIndex, 1].Description = "ComboBox using ChoiceList";
            gridControl1[rowIndex, 1].Font.Bold = true;
            gridControl1.RowHeights.ResizeToFit(GridRangeInfo.Row(rowIndex), GridResizeToFitOptions.ResizeCoveredCells);
            AddEntries(ref rowIndex, "ComboBox", items, null, "", "");
            for (int i = 11; i <= 19; i++)
            {
                this.gridControl1.HideRows[i] = true;
            }

             //ComboBox using Datasource";
            rowIndex = 21;
            gridControl1.CoveredRanges.Add(GridRangeInfo.Cells(rowIndex - 1, 1, rowIndex - 1, gridControl1.ColCount));
            gridControl1.CoveredRanges.Add(GridRangeInfo.Cells(rowIndex, 1, rowIndex, gridControl1.ColCount));
            gridControl1[rowIndex, 1].CellType = GridCellTypeName.CheckBox;
            gridControl1[rowIndex, 1].Description = "ComboBox using Datasource, DisplayMember = CompanyName";
            gridControl1[rowIndex, 1].Font.Bold = true;
            gridControl1.RowHeights.ResizeToFit(GridRangeInfo.Row(rowIndex), GridResizeToFitOptions.ResizeCoveredCells);
            AddEntries(ref rowIndex, "ComboBox", null, dataSet11.Customers, "CustomerID", "CompanyName");
            for (int i = 22; i <= 30; i++)
            {
                this.gridControl1.HideRows[i] = true;
            }

            rowIndex = 32;
            gridControl1.CoveredRanges.Add(GridRangeInfo.Cells(rowIndex - 1, 1, rowIndex - 1, gridControl1.ColCount));
            gridControl1.CoveredRanges.Add(GridRangeInfo.Cells(rowIndex, 1, rowIndex, gridControl1.ColCount));
            gridControl1[rowIndex, 1].CellType = GridCellTypeName.CheckBox;
            gridControl1[rowIndex, 1].Description = "ComboBox using Datasource, ValueMember = empty ";
            gridControl1[rowIndex, 1].Font.Bold = true;
            gridControl1.RowHeights.ResizeToFit(GridRangeInfo.Row(rowIndex), GridResizeToFitOptions.ResizeCoveredCells);
            AddEntries(ref rowIndex, "ComboBox", null, dataSet11.Customers, "", "CompanyName");
            for (int i = 33; i <= 41; i++)
            {
                this.gridControl1.HideRows[i] = true;
            }

            rowIndex = 3;
            gridControl1.CoveredRanges.Add(GridRangeInfo.Cells(rowIndex, 1, rowIndex, gridControl1.ColCount));
            gridControl1[rowIndex, 1].CellType = GridCellTypeName.Static;
            gridControl1[rowIndex, 1].Text = "ComboBox Cells :    Following Categories illustrates the features supported by a ComboBox cell";
            gridControl1[rowIndex, 1].TextColor = Color.Black;
            gridControl1[rowIndex, 1].Font.Bold = true;

            #endregion

            #region GridListControl Cells
            rowIndex = 46;
            gridControl1.CoveredRanges.Add(GridRangeInfo.Cells(rowIndex - 1, 1, rowIndex - 1, gridControl1.ColCount));
            gridControl1.CoveredRanges.Add(GridRangeInfo.Cells(rowIndex, 1, rowIndex, gridControl1.ColCount));
            gridControl1[rowIndex, 1].CellType = GridCellTypeName.CheckBox;
            gridControl1[rowIndex, 1].Description = "GridListControl using Datasource, DisplayMember = CompanyName";
            gridControl1[rowIndex, 1].Font.Bold = true;
            gridControl1.RowHeights.ResizeToFit(GridRangeInfo.Row(rowIndex), GridResizeToFitOptions.ResizeCoveredCells);
            AddEntries(ref rowIndex, "GridListControl", null, dataSet11.Customers, "CustomerID", "CompanyName");
            for (int i = 47; i <= 55; i++)
            {
                this.gridControl1.HideRows[i] = true;
            }

            rowIndex = 57;
            gridControl1.CoveredRanges.Add(GridRangeInfo.Cells(rowIndex - 1, 1, rowIndex - 1, gridControl1.ColCount));
            gridControl1.CoveredRanges.Add(GridRangeInfo.Cells(rowIndex, 1, rowIndex, gridControl1.ColCount));
            gridControl1[rowIndex, 1].CellType = GridCellTypeName.CheckBox;
            gridControl1[rowIndex, 1].Description = "GridListControl using Datasource, ValueMember = empty";
            gridControl1[rowIndex, 1].Font.Bold = true;
            gridControl1.RowHeights.ResizeToFit(GridRangeInfo.Row(rowIndex), GridResizeToFitOptions.ResizeCoveredCells);
            AddEntries(ref rowIndex, "GridListControl", null, dataSet11.Customers, "", "CompanyName");
            for (int i = 58; i <= 66; i++)
            {
                this.gridControl1.HideRows[i] = true;
            }

            
            rowIndex = 68;
            gridControl1.CoveredRanges.Add(GridRangeInfo.Cells(rowIndex - 1, 1, rowIndex - 1, gridControl1.ColCount));
            gridControl1.CoveredRanges.Add(GridRangeInfo.Cells(rowIndex, 1, rowIndex, gridControl1.ColCount));
            gridControl1[rowIndex, 1].CellType = GridCellTypeName.CheckBox;
            gridControl1[rowIndex, 1].Description = "GridListControl showing ArrayList with Icons";
            gridControl1[rowIndex, 1].Font.Bold = true;
            gridControl1.RowHeights.ResizeToFit(GridRangeInfo.Row(rowIndex), GridResizeToFitOptions.ResizeCoveredCells);
            AddEntries(ref rowIndex, "GridListControl", null, icons, "", "LongName");
            for (int i = 69; i <= 77; i++)
            {
                this.gridControl1.HideRows[i] = true;
            }

            rowIndex = 43;
            gridControl1.CoveredRanges.Add(GridRangeInfo.Cells(rowIndex - 1, 1, rowIndex - 1, gridControl1.ColCount));
            gridControl1.CoveredRanges.Add(GridRangeInfo.Cells(rowIndex, 1, rowIndex, gridControl1.ColCount));
            gridControl1[rowIndex, 1].CellType = GridCellTypeName.Static;
            gridControl1[rowIndex, 1].Text = "GridListControl Cells :    Following Categories illustrates the features supported by a GridListControl cell";
            gridControl1[rowIndex, 1].TextColor = Color.Black;
            gridControl1[rowIndex, 1].Font.Bold = true;
            rowIndex++;
            gridControl1.CoveredRanges.Add(GridRangeInfo.Cells(rowIndex, 1, rowIndex, gridControl1.ColCount));
            gridControl1[rowIndex, 1].Text = "GridListControl using ChoiceList : Not Supported";
            gridControl1[rowIndex, 1].Font.Bold = true;


            #endregion

            #region MonthCalendar Cells
            rowIndex = 79;
            gridControl1.CoveredRanges.Add(GridRangeInfo.Cells(rowIndex - 1, 1, rowIndex - 1, gridControl1.ColCount));
            gridControl1.CoveredRanges.Add(GridRangeInfo.Cells(rowIndex, 1, rowIndex, 4));
            gridControl1[rowIndex, 1].Text = "DropDown Calendar Cells";
            gridControl1[rowIndex, 1].TextColor = Color.Black;
            gridControl1[rowIndex, 1].Font.Bold = true;
            rowIndex++;
            gridControl1[rowIndex, 1].CellType = "MonthCalendar";
            gridControl1[rowIndex, 1].CellValue = DateTime.Now;
            gridControl1[rowIndex, 1].Font.Size = 8;
            gridControl1[rowIndex, 3].CellType = "MonthCalendar";
            gridControl1[rowIndex, 3].CellValue = DateTime.Now;
            gridControl1[rowIndex, 3].Font.Size = 8;
            gridControl1.RowHeights[rowIndex] = gridControl1.DefaultRowHeight - 2;

            #endregion

            #region Coloredit Cells
            rowIndex = 79;
            gridControl1.CoveredRanges.Add(GridRangeInfo.Cells(rowIndex, 5, rowIndex, gridControl1.ColCount));
            gridControl1[rowIndex, 5].Text = "DropDown ColorEdit Cells";
            gridControl1[rowIndex, 5].TextColor = Color.Black;
            gridControl1[rowIndex, 5].Font.Bold = true;
            rowIndex++;
            gridControl1[rowIndex, 5].CellType = GridCellTypeName.ColorEdit;
            gridControl1[rowIndex, 5].TextColor = Color.Black;
            gridControl1[rowIndex, 5].Font.Size = 8;
            gridControl1[rowIndex, 7].CellType = GridCellTypeName.ColorEdit;
            gridControl1[rowIndex, 7].TextColor = Color.Black;
            gridControl1[rowIndex, 7].Font.Size = 8;
            gridControl1.RowHeights[rowIndex] = gridControl1.DefaultRowHeight - 2;
            #endregion

            #region RichTextCells
            rowIndex = 82;
            gridControl1.CoveredRanges.Add(GridRangeInfo.Cells(rowIndex - 1, 1, rowIndex - 1, gridControl1.ColCount));
            gridControl1.CoveredRanges.Add(GridRangeInfo.Cells(rowIndex, 1, rowIndex, gridControl1.ColCount));
            gridControl1[rowIndex, 1].CellType = GridCellTypeName.CheckBox;
            gridControl1[rowIndex, 1].Description = "Rich Text Cells :    Check this to view a drop-down menu which displays formatting helpers to modify the text";
            gridControl1[rowIndex, 1].TextColor = Color.Black;
            gridControl1[rowIndex, 1].Font.Bold = true;
            rowIndex = 83;
            rtf2 =
                @"{\rtf1\ansi" +
                // font table
                @"{\fonttbl" +
                @"\f0\froman Times New Roman; " +
                @"\f1\fdecor Courier New; " +
                @"\f2\fswiss Arial;} " +
                @"\deff0 " +
                // color table
                @"{\colortbl" +
                @"\red250\green177\blue146; " +
                @"\red229\green 118\blue145; " +
                @"\red101\green121\blue219; " +
                @"\red240\green224\blue255;} " +
                // first line
                @"\highlight2\cb1\qc\cf0\f0\fs20 12 point, Times New Roman, " +
                @"red, centered\plain\par" +
                // second line
                @"\highlight0\ql\cf3\f1\fs28 14 point, Courier New, blue, " +
                @"left aligned\plain\par" +
                // third line
                @"\highlight1\qr\cf0\f2\fs36 18 point, Arial, black, " +
                @"right aligned\plain\par" +
                // fourth line
                @"\qc Default font and color, \b Bold\plain , \ul Underline\plain , \i Italic \plain\par" +
                // closing bracket
                @"}"
                ;
            gridControl1[rowIndex, 1].CellType = "RichText";
            gridControl1[rowIndex, 1].Text = rtf2;
            gridControl1.RowHeights[rowIndex] = 150;
            gridControl1.CoveredRanges.Add(GridRangeInfo.Cells(rowIndex, 1, rowIndex, 5));
            this.gridControl1.HideRows[rowIndex] = true;
            #endregion

            this.gridControl1.EndUpdate(true);
        }

        #endregion
       
        #region "EventHandlers"
        void gridControl1_CheckBoxClick(object sender, GridCellClickEventArgs e)
        {
            this.gridControl1.BeginUpdate();

            switch(e.RowIndex)
            {
                case 4:
                    for (int i = 5; i <= 8; i++)
                    {
                        this.gridControl1.HideRows[i] = !this.gridControl1.HideRows[i];
                    }
                    break;
                case 10:
                    for (int i = 11; i <= 19; i++)
                    {
                        this.gridControl1.HideRows[i] = !this.gridControl1.HideRows[i];
                    }
                    break;
                case 21:
                    for (int i = 22; i <= 30; i++)
                    {
                        this.gridControl1.HideRows[i] = !this.gridControl1.HideRows[i];
                    }
                    break;
                case 32:
                    for (int i = 33; i <= 41; i++)
                    {
                        this.gridControl1.HideRows[i] = !this.gridControl1.HideRows[i];
                    }
                    break;
                case 46:
                    for (int i = 47; i <= 55; i++)
                    {
                        this.gridControl1.HideRows[i] = !this.gridControl1.HideRows[i];
                    }
                    break;
                case 57:
                    for (int i = 58; i <= 66; i++)
                    {
                        this.gridControl1.HideRows[i] = !this.gridControl1.HideRows[i];
                    }
                    break;
                case 68:
                    for (int i = 69; i <= 77; i++)
                    {
                        this.gridControl1.HideRows[i] = !this.gridControl1.HideRows[i];
                    }
                    break;
                case 82:
                    this.gridControl1.HideRows[e.RowIndex + 1] = !this.gridControl1.HideRows[e.RowIndex + 1];
                    break;
            }
           
            this.gridControl1.EndUpdate(true);
            this.gridControl1.Refresh();
        }

        #endregion

        #region "HelperMethods"

        //setting options for each cell.
        void AddChoices(ref int rowIndex, string cellType, StringCollection items, object dataSource, string valueMember, string displayMember)
        {
            gridControl1.DiscardReadOnly = true;

            rowIndex++;
            gridControl1[rowIndex, 1].Text = "AutoComplete ";
            gridControl1[rowIndex, 3].CellType = cellType;
            gridControl1[rowIndex, 3].DropDownStyle = GridDropDownStyle.Editable;
            gridControl1[rowIndex, 3].AutoCompleteInEditMode = GridComboSelectionOptions.AutoComplete;
            gridControl1[rowIndex, 3].ChoiceList = items;
            if (dataSource != null)
            {
                gridControl1[rowIndex, 3].DataSource = dataSource;
                gridControl1[rowIndex, 3].DisplayMember = displayMember;
                gridControl1[rowIndex, 3].ValueMember = valueMember;
            }

            rowIndex++;
            gridControl1[rowIndex, 1].Text = "AutoSuggest ";
            gridControl1[rowIndex, 3].CellType = cellType;
            gridControl1[rowIndex, 3].DropDownStyle = GridDropDownStyle.Editable;
            gridControl1[rowIndex, 3].AutoCompleteInEditMode = GridComboSelectionOptions.AutoSuggest;
            gridControl1[rowIndex, 3].ChoiceList = items;
            if (dataSource != null)
            {
                gridControl1[rowIndex, 3].DataSource = dataSource;
                gridControl1[rowIndex, 3].DisplayMember = displayMember;
                gridControl1[rowIndex, 3].ValueMember = valueMember;
            }

            rowIndex++;
            gridControl1[rowIndex, 1].Text = "Both ";
            gridControl1[rowIndex, 3].CellType = cellType;
            gridControl1[rowIndex, 3].DropDownStyle = GridDropDownStyle.Editable;
            gridControl1[rowIndex, 3].AutoCompleteInEditMode = GridComboSelectionOptions.Both;
            gridControl1[rowIndex, 3].ChoiceList = items;
            if (dataSource != null)
            {
                gridControl1[rowIndex, 3].DataSource = dataSource;
                gridControl1[rowIndex, 3].DisplayMember = displayMember;
                gridControl1[rowIndex, 3].ValueMember = valueMember;
            }

            rowIndex++;
            gridControl1[rowIndex, 1].Text = "None ";
            gridControl1[rowIndex, 3].CellType = cellType;
            gridControl1[rowIndex, 3].DropDownStyle = GridDropDownStyle.Editable;
            gridControl1[rowIndex, 3].AutoCompleteInEditMode = GridComboSelectionOptions.None;
            gridControl1[rowIndex, 3].ChoiceList = items;
            if (dataSource != null)
            {
                gridControl1[rowIndex, 3].DataSource = dataSource;
                gridControl1[rowIndex, 3].DisplayMember = displayMember;
                gridControl1[rowIndex, 3].ValueMember = valueMember;
            }
            rowIndex++;
        }
        // adding cell values
        void AddEntries(ref int rowIndex, string cellType, StringCollection items, object dataSource, string valueMember, string displayMember)
        {
            gridControl1.DiscardReadOnly = true;

            rowIndex++;
            gridControl1[rowIndex, 1].Text = "Editable ";
            gridControl1[rowIndex, 3].CellType = cellType;
            gridControl1[rowIndex, 3].ChoiceList = items;
            if (dataSource != null)
            {
                gridControl1[rowIndex, 3].DataSource = dataSource;
                gridControl1[rowIndex, 3].DisplayMember = displayMember;
                gridControl1[rowIndex, 3].ValueMember = valueMember;
            }
            gridControl1[rowIndex, 3].DropDownStyle = GridDropDownStyle.Editable;

            rowIndex++;
            gridControl1[rowIndex, 1].Text = "AutoComplete ";
            gridControl1[rowIndex, 3].CellType = cellType;
            gridControl1[rowIndex, 3].ChoiceList = items;
            gridControl1[rowIndex, 3].DropDownStyle = GridDropDownStyle.AutoComplete;
            if (dataSource != null)
            {
                gridControl1[rowIndex, 3].DataSource = dataSource;
                gridControl1[rowIndex, 3].DisplayMember = displayMember;
                gridControl1[rowIndex, 3].ValueMember = valueMember;
            }

            rowIndex++;
            gridControl1[rowIndex, 1].Text = "Exclusive ";
            gridControl1[rowIndex, 3].CellType = cellType;
            gridControl1[rowIndex, 3].ChoiceList = items;
            gridControl1[rowIndex, 3].DropDownStyle = GridDropDownStyle.Exclusive;
            if (dataSource != null)
            {
                gridControl1[rowIndex, 3].DataSource = dataSource;
                gridControl1[rowIndex, 3].DisplayMember = displayMember;
                gridControl1[rowIndex, 3].ValueMember = valueMember;
            }

            rowIndex++;
            gridControl1[rowIndex, 1].Text = "Not clickable";
            gridControl1[rowIndex, 3].CellType = cellType;
            gridControl1[rowIndex, 3].ChoiceList = items;
            gridControl1[rowIndex, 3].DropDownStyle = GridDropDownStyle.Editable;
            gridControl1[rowIndex, 3].Clickable = false;
            if (dataSource != null)
            {
                gridControl1[rowIndex, 3].DataSource = dataSource;
                gridControl1[rowIndex, 3].DisplayMember = displayMember;
                gridControl1[rowIndex, 3].ValueMember = valueMember;
            }

            rowIndex++;
            gridControl1[rowIndex, 1].Text = "Disabled";
            gridControl1[rowIndex, 3].CellType = cellType;
            gridControl1[rowIndex, 3].ChoiceList = items;
            gridControl1[rowIndex, 3].DropDownStyle = GridDropDownStyle.Editable;
            gridControl1[rowIndex, 3].Enabled = false;
            if (dataSource != null)
            {
                gridControl1[rowIndex, 3].DataSource = dataSource;
                gridControl1[rowIndex, 3].DisplayMember = displayMember;
                gridControl1[rowIndex, 3].ValueMember = valueMember;
            }

            rowIndex++;
            gridControl1[rowIndex, 1].Text = "Hide Buttons";
            gridControl1[rowIndex, 3].CellType = cellType;
            gridControl1[rowIndex, 3].ChoiceList = items;
            gridControl1[rowIndex, 3].DropDownStyle = GridDropDownStyle.Editable;
            gridControl1[rowIndex, 3].ShowButtons = GridShowButtons.Hide;
            if (dataSource != null)
            {
                gridControl1[rowIndex, 3].DataSource = dataSource;
                gridControl1[rowIndex, 3].DisplayMember = displayMember;
                gridControl1[rowIndex, 3].ValueMember = valueMember;
            }

            rowIndex++;
            gridControl1[rowIndex, 1].Text = "Buttons when editing";
            gridControl1[rowIndex, 3].CellType = cellType;
            gridControl1[rowIndex, 3].ChoiceList = items;
            gridControl1[rowIndex, 3].DropDownStyle = GridDropDownStyle.Editable;
            gridControl1[rowIndex, 3].ShowButtons = GridShowButtons.ShowCurrentCellEditing;
            if (dataSource != null)
            {
                gridControl1[rowIndex, 3].DataSource = dataSource;
                gridControl1[rowIndex, 3].DisplayMember = displayMember;
                gridControl1[rowIndex, 3].ValueMember = valueMember;
            }

            rowIndex++;
            gridControl1[rowIndex, 1].Text = "Read-only";
            gridControl1[rowIndex, 3].CellType = cellType;
            gridControl1[rowIndex, 3].ChoiceList = items;
            gridControl1[rowIndex, 3].DropDownStyle = GridDropDownStyle.Editable;
            if (dataSource != null)
            {
                gridControl1[rowIndex, 3].DataSource = dataSource;
                gridControl1[rowIndex, 3].DisplayMember = displayMember;
                gridControl1[rowIndex, 3].ValueMember = valueMember;
            }
            gridControl1[rowIndex, 3].ReadOnly = true;

            rowIndex++;
            gridControl1[rowIndex, 1].Text = "Empty";
            gridControl1[rowIndex, 3].CellType = cellType;
            gridControl1[rowIndex, 3].DropDownStyle = GridDropDownStyle.Editable;

            rowIndex++;

            gridControl1.DiscardReadOnly = false;
        }
        #endregion
    }

    #region "IconClass"
    [Serializable]
    public class IconDesc
    {
        #region "API Definition"

        private string myShortName;
        private string myLongName;
        private int _imageIndex;

        #endregion

        #region "Consructor"

        public IconDesc(string strLongName, string strShortName, int _imageIndex)
        {
            this.myShortName = strShortName;
            this.myLongName = strLongName;
            this._imageIndex = _imageIndex;
        }

        #endregion

        #region "Properties"
        public string ShortName
        {
            get
            {
                return myShortName;
            }
        }

        public string LongName
        {

            get
            {
                return myLongName;
            }
        }

        public int ImageIndex
        {
            get
            {
                return _imageIndex;
            }
            set
            {
                _imageIndex = value;
            }
        }


        public override string ToString()
        {
            return this.ShortName + " - " + this.LongName;
        }
        #endregion
    }
    #endregion
}

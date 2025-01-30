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
using System.Collections.Specialized;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Text;

using Syncfusion.Windows.Forms;
using Syncfusion.Windows.Forms.Grid;
using Syncfusion.Diagnostics;

namespace GridSample
{
	/// <summary>
	/// Summary description for MainForm.
	/// </summary>
	public class MainForm
	{
		Syncfusion.Windows.Forms.Grid.GridControl gridControl1;
		Syncfusion.Windows.Forms.SplitterControl splitterControl1;
		DataSet1 dataSet11;
		Form1 form;

		public MainForm(Form1 form)
		{
			this.form = form;
			this.gridControl1 = form.gridControl1;
			this.splitterControl1 = form.splitterControl1;
			this.dataSet11 = form.dataSet11;
			InitializeForm();
		}

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		public static void Main()
        {
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense(Syncfusion.Licensing.DemoCommon.FindLicenseKey());			
# if SyncfusionFramework1_1 || SyncfusionFramework2_0  
			Application.EnableVisualStyles();
# endif		
			Form1 form = new Form1();
			MainForm main = new MainForm(form);
			Application.Run(form);
		}

		void InitializeForm()
		{
            form.Text = "Grid Control Event Logger";

			gridControl1.BeginUpdate();
			gridControl1.TableStyle.FloatCell = true;
			gridControl1.FloatCellsMode = GridFloatCellsMode.OnDemandCalculation;
			//gridControl1.FloatingCells.DelayFloatCells(GridRangeInfo.Table());
			gridControl1.ColWidths[3] *= 2;

			int rowIndex = 2;

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

            rowIndex = 1;
            gridControl1[rowIndex, 1].Text = "CellTypes";
            rowIndex++;
            gridControl1[rowIndex, 2].CellType = GridCellTypeName.CheckBox;
            gridControl1[rowIndex, 1].CellType = "Static";
            gridControl1[rowIndex, 1].BaseStyle = "Heading 2";
            gridControl1[rowIndex, 1].Text = "CheckBox";
            gridControl1.RowHeights.ResizeToFit(GridRangeInfo.Row(rowIndex), GridResizeToFitOptions.ResizeCoveredCells);

            rowIndex++;
            gridControl1[rowIndex, 2].CellType = GridCellTypeName.ColorEdit;
            gridControl1[rowIndex, 1].CellType = "Static";
            gridControl1[rowIndex, 1].BaseStyle = "Heading 2";
            gridControl1[rowIndex, 1].Text = "ColorEdit";
            gridControl1.RowHeights.ResizeToFit(GridRangeInfo.Row(rowIndex), GridResizeToFitOptions.ResizeCoveredCells);

            rowIndex++;
            gridControl1[rowIndex, 2].CellType = GridCellTypeName.ComboBox;
            gridControl1[rowIndex, 1].CellType = "Static";
            gridControl1[rowIndex, 1].BaseStyle = "Heading 2";
            gridControl1[rowIndex, 1].Text = "ComboBox";
            gridControl1[rowIndex, 2].DataSource = items;
            gridControl1.RowHeights.ResizeToFit(GridRangeInfo.Row(rowIndex), GridResizeToFitOptions.ResizeCoveredCells);

            rowIndex++;
            Syncfusion.Windows.Forms.Tools.ButtonEdit be = new Syncfusion.Windows.Forms.Tools.ButtonEdit();
            gridControl1[rowIndex, 2].CellType = GridCellTypeName.Control;
            be.TabStop = false;
            gridControl1[rowIndex, 2].Control = be;
            gridControl1[rowIndex, 1].CellType = "Static";
            gridControl1[rowIndex, 1].BaseStyle = "Heading 2";
            gridControl1[rowIndex, 1].Text = "Control";
            gridControl1.RowHeights.ResizeToFit(GridRangeInfo.Row(rowIndex), GridResizeToFitOptions.ResizeCoveredCells);

            rowIndex++;
            gridControl1[rowIndex, 2].CellType = GridCellTypeName.Currency;
            gridControl1[rowIndex, 2].CellValue = "5.0";
            gridControl1[rowIndex, 1].CellType = "Static";
            gridControl1[rowIndex, 1].BaseStyle = "Heading 2";
            gridControl1[rowIndex, 1].Text = "Currency";
            gridControl1.RowHeights.ResizeToFit(GridRangeInfo.Row(rowIndex), GridResizeToFitOptions.ResizeCoveredCells);

            rowIndex++;
            gridControl1[rowIndex, 2].CellType = GridCellTypeName.DropDownGrid;
            gridControl1[rowIndex, 1].CellType = "Static";
            gridControl1[rowIndex, 1].BaseStyle = "Heading 2";
            gridControl1[rowIndex, 1].Text = "DropDownGrid";
            gridControl1.RowHeights.ResizeToFit(GridRangeInfo.Row(rowIndex), GridResizeToFitOptions.ResizeCoveredCells);

            rowIndex++;
            gridControl1[rowIndex, 2].CellType = "Static";
            gridControl1[rowIndex, 2].CellValue = 5;
            gridControl1[rowIndex, 3].CellType = "Static";
            gridControl1[rowIndex, 3].CellValue = 10;
            gridControl1[rowIndex, 4].CellType = GridCellTypeName.FormulaCell;
            string str = "= B" + rowIndex.ToString() + " + C" + rowIndex.ToString();
            gridControl1[rowIndex, 4].CellValue = str;
            gridControl1[rowIndex, 1].Text = "Formula Cell";
            gridControl1[rowIndex, 1].BaseStyle = "Heading 2";
            gridControl1.RowHeights.ResizeToFit(GridRangeInfo.Row(rowIndex), GridResizeToFitOptions.ResizeCoveredCells);

            rowIndex++;
            gridControl1[rowIndex, 2].CellType = GridCellTypeName.GridListControl;
            gridControl1[rowIndex, 2].DataSource = dataSet11.Customers;
            gridControl1[rowIndex, 1].CellType = "Static";
            gridControl1[rowIndex, 1].Text = "GridListControl";
            gridControl1[rowIndex, 2].ValueMember = "CustomerID";
            gridControl1[rowIndex, 2].DisplayMember = "CustomerID";
            gridControl1[rowIndex, 1].BaseStyle = "Heading 2";
            gridControl1.RowHeights.ResizeToFit(GridRangeInfo.Row(rowIndex), GridResizeToFitOptions.ResizeCoveredCells);

            rowIndex++;
            gridControl1[rowIndex, 2].CellType = GridCellTypeName.Image;
            gridControl1[rowIndex, 2].ImageList = imageList;
            gridControl1[rowIndex, 2].ImageIndex = 0;
            gridControl1[rowIndex, 1].Text = "Image";
            gridControl1[rowIndex, 1].BaseStyle = "Heading 2";
            gridControl1.RowHeights.ResizeToFit(GridRangeInfo.Row(rowIndex), GridResizeToFitOptions.ResizeCoveredCells);

            rowIndex++;
            gridControl1[rowIndex, 2].CellType = GridCellTypeName.MaskEdit;
            gridControl1[rowIndex, 1].CellType = "Static";
            gridControl1[rowIndex, 1].BaseStyle = "Heading 2";
            gridControl1[rowIndex, 1].Text = "MaskEdit";
            gridControl1[rowIndex, 2].MaskEdit.Mask = "(99)-(99)-(9999)";
            gridControl1[rowIndex, 2].Text = "12345678";
            gridControl1.RowHeights.ResizeToFit(GridRangeInfo.Row(rowIndex), GridResizeToFitOptions.ResizeCoveredCells);

            rowIndex++;
            gridControl1[rowIndex, 2].CellType = GridCellTypeName.MonthCalendar;
            gridControl1[rowIndex, 1].CellType = "Static";
            gridControl1[rowIndex, 1].BaseStyle = "Heading 2";
            gridControl1[rowIndex, 1].Text = "MonthCalendar";
            gridControl1.RowHeights.ResizeToFit(GridRangeInfo.Row(rowIndex), GridResizeToFitOptions.ResizeCoveredCells);

            rowIndex++;
            gridControl1[rowIndex, 2].CellType = GridCellTypeName.NumericUpDown;
            gridControl1[rowIndex, 1].CellType = "Static";
            gridControl1[rowIndex, 1].BaseStyle = "Heading 2";
            gridControl1[rowIndex, 1].Text = "NumericUpDown";
            gridControl1.RowHeights.ResizeToFit(GridRangeInfo.Row(rowIndex), GridResizeToFitOptions.ResizeCoveredCells);

            rowIndex++;
            gridControl1[rowIndex, 2].CellType = GridCellTypeName.OriginalTextBox;
            gridControl1[rowIndex, 1].CellType = "Static";
            gridControl1[rowIndex, 1].BaseStyle = "Heading 2";
            gridControl1[rowIndex, 1].Text = "OriginalTextBox";
            gridControl1.RowHeights.ResizeToFit(GridRangeInfo.Row(rowIndex), GridResizeToFitOptions.ResizeCoveredCells);

            rowIndex++;
            gridControl1[rowIndex, 2].CellType = GridCellTypeName.ProgressBar;
            gridControl1[rowIndex, 1].CellType = "Static";
            gridControl1[rowIndex, 1].BaseStyle = "Heading 2";
            gridControl1[rowIndex, 1].Text = "ProgressBar";
            gridControl1.RowHeights.ResizeToFit(GridRangeInfo.Row(rowIndex), GridResizeToFitOptions.ResizeCoveredCells);

 
            rowIndex++;
            gridControl1[rowIndex, 2].CellType = GridCellTypeName.PushButton;
            gridControl1[rowIndex, 2].Description = "PushButton";
            gridControl1[rowIndex, 1].CellType = "Static";
            gridControl1[rowIndex, 1].BaseStyle = "Heading 2";
            gridControl1[rowIndex, 1].Text = "PushButton";
            gridControl1.RowHeights.ResizeToFit(GridRangeInfo.Row(rowIndex), GridResizeToFitOptions.ResizeCoveredCells);

            rowIndex++;
            StringCollection sc = new StringCollection();
            sc.AddRange(new String[] { "radio 0", "radio 1"});
            gridControl1[rowIndex, 2].ChoiceList=sc;
            gridControl1[rowIndex, 2].CellType = GridCellTypeName.RadioButton;
            gridControl1[rowIndex, 2].CellValue = 1;
            gridControl1[rowIndex, 1].BaseStyle = "Heading 2";
            gridControl1[rowIndex, 1].CellType = "Static";
            gridControl1[rowIndex, 1].Text = "RadioButton";
            gridControl1.RowHeights.ResizeToFit(GridRangeInfo.Row(rowIndex), GridResizeToFitOptions.ResizeCoveredCells);

            rowIndex++;
            gridControl1[rowIndex, 2].CellType = GridCellTypeName.RichText;
            string rtf =
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
            gridControl1[rowIndex, 2].Text = rtf;
            gridControl1.CoveredRanges.Add(GridRangeInfo.Cells(rowIndex, 2, rowIndex, 4));
            gridControl1[rowIndex, 1].CellType = "Static";
            gridControl1[rowIndex, 1].BaseStyle = "Heading 2";
            gridControl1[rowIndex, 1].Text = "RichText";
            gridControl1.RowHeights.ResizeToFit(GridRangeInfo.Row(rowIndex), GridResizeToFitOptions.ResizeCoveredCells);

            gridControl1.ActivateCurrentCellBehavior = GridCellActivateAction.None;
            gridControl1.EndUpdate(true);

			gridControl1.ForceCurrentCellMoveTo = true;
			gridControl1.CurrentCell.MoveTo(4, 3);
			form.ShowPropertyGridItem("Data", "ValueMember");

            gridControl1.RowHeights[1] = 30;
            gridControl1.PrepareViewStyleInfo += new GridPrepareViewStyleInfoEventHandler(gridControl1_PrepareViewStyleInfo);
            gridControl1.CurrentCellCloseDropDown += new PopupClosedEventHandler(gridControl1_CurrentCellCloseDropDown);
		}

        void gridControl1_CurrentCellCloseDropDown(object sender, PopupClosedEventArgs e)
        {
            GridCurrentCell gcc = this.gridControl1.CurrentCell;
            if (gridControl1[gcc.RowIndex, gcc.ColIndex].CellType == "DropDownGrid")
            {
                gridControl1.Refresh();
            }
        }

        void gridControl1_PrepareViewStyleInfo(object sender, GridPrepareViewStyleInfoEventArgs e)
        {
            if (e.RowIndex == 1 && e.ColIndex == 1)
            {
                e.Style.TextColor = Color.Black;//Color.FromArgb( 0xde, 0x64, 0x13 );
                e.Style.Font.Facename = "Segoe UI";
                e.Style.Font.Size = 12;
                e.Style.Font.Bold = true;
            }
            else if (e.RowIndex > 1 && e.ColIndex == 1)
            {
                e.Style.TextColor = Color.Orange;//Color.FromArgb( 0xde, 0x64, 0x13 );
                e.Style.Font.Facename = "Segoe UI";
                e.Style.Font.Size = 10;
                e.Style.Font.Bold = true;
            }
        }			

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
			gridControl1[rowIndex, 1].Text = "Autocomplete " ;
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
			gridControl1[rowIndex, 1].Text = "Exclusive " ;
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
			gridControl1[rowIndex, 1].Text = "Readonly";
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

	}

	
	[Serializable]
	public class IconDesc
	{
		private string myShortName ;
		private string myLongName ;
		private int _imageIndex;
   
		public  IconDesc(string strLongName, string strShortName, int _imageIndex)
		{
			this.myShortName = strShortName;
			this.myLongName = strLongName;
			this._imageIndex = _imageIndex;
		}

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
				return myLongName ;
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
	}
}

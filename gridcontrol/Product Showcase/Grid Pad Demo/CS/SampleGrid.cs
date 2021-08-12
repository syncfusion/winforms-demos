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
using System.Collections;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;

using Syncfusion.ComponentModel;
using Syncfusion.Drawing;
using Syncfusion.Styles;
using Syncfusion.Windows.Forms;
using Syncfusion.Windows.Forms.Grid;
using System.Runtime.Serialization;

namespace Syncfusion.Samples.GridPad 
{

	/// <summary>
	/// SampleGridModel for Workbook/Worksheet support (see MenuAction.NewWorkbookFile)
	/// </summary>
	[Serializable]
	public class SampleGridModel : GridModel, ICreateControl
	{
        public SampleGridModel(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {

        }
        public SampleGridModel()
            : base()
        {

        }

		public override Control CreateControl()
		{
			GridControlBase grid = new SampleGrid(this);
			grid.FillSplitterPane = true;            
			return grid;
		}
	}

    /// <summary>
    ///    A derived grid component class.
    /// </summary>
    public class SampleGrid : GridControl
    {
		public SampleGrid()
			: this(null)
		{
		}

		public SampleGrid(GridModel model)
			: base(model)
		{
			this.FillSplitterPane = true;
			this.DpiAware = true;
			// transparent
			bool alphablending = false;
			if (alphablending)
			{
				this.SupportsTransparentBackColor = true;
                this.BackColor = Color.White;
				
				Type type = typeof(Bitmap);
				System.IO.Stream stream = GetType().Module.Assembly.GetManifestResourceStream(ApplicationMain.manifestNamespace + "logo_800_edf0f7.jpg");
				Bitmap bm = new Bitmap(stream);
				this.BackgroundImage = bm;
			}
			else
			{
				this.BackColor = Color.White;
				this.ForeColor = SystemColors.WindowText;
			}
			this.VerticalThumbTrack = false;
			this.VerticalScrollTips = true;
			this.HorizontalThumbTrack = true;
			this.HorizontalScrollTips = true;
			this.ThemesEnabled = true;
            this.GridVisualStyles = GridVisualStyles.Metro;
            this.Properties.GridLineColor = Color.FromArgb(208, 215, 229);
            this.TableStyle.TextColor = Color.MidnightBlue;
            this.TableStyle.Font.Facename = "Verdana";
            this.DefaultGridBorderStyle = GridBorderStyle.Solid;
		}

		// Find and replace dialog

		GridFindReplaceDialogSink findReplaceDialogSink;

		public GridFindReplaceDialogSink GridFindReplaceDialogSink
		{
			get
			{
				if (findReplaceDialogSink == null)
				{
					findReplaceDialogSink = new GridFindReplaceDialogSink(this);
				}
				return findReplaceDialogSink;
			}
		}

		protected override void OnCurrentCellActivated(EventArgs e)
		{
			GridFindReplaceDialog.ResetFindLocation();
			base.OnCurrentCellActivated(e);
		}

		protected override void OnControlGotFocus()
		{
			GridFindReplaceDialog.SetActiveSinkIfVisible(GridFindReplaceDialogSink);
			base.OnControlGotFocus();
		}



		public override void Initialize()
		{
			base.Initialize();
			this.TopRowIndex = InternalGetHeaderRows()+1;
			this.LeftColIndex = InternalGetHeaderCols()+1;
			this.AllowDrop = true;
		}

		/// <summary>
		/// This event handler demonstrates how to handle the QueryNextCurrentCellPosition
		/// event in order to skip not only disabled cells but also skip readonly cells.
		/// </summary>
		/// <param name="e">Event data.</param>
		protected override void OnQueryNextCurrentCellPosition(GridQueryNextCurrentCellPositionEventArgs e)
		{
			// just set this flag true if you want to try out this event handler.
			bool flag = false;
			if (flag)
			{
				int rowIndex = e.RowIndex;
				int colIndex = e.ColIndex;
				e.Handled = true;
				bool enabledCellFound = true;
				while (enabledCellFound)
				{
					enabledCellFound = CurrentCell.QueryNextEnabledCell(e.Direction, ref rowIndex, ref colIndex);
					if (enabledCellFound)
					{
						if (!this[rowIndex, colIndex].ReadOnly)
							break;

						switch (e.Direction)
						{
							case GridDirectionType.Left: colIndex--; break;
							case GridDirectionType.Right: colIndex++; break;
							case GridDirectionType.Up: rowIndex--; break;
							case GridDirectionType.Down: rowIndex++; break;
							default:
								enabledCellFound = false;
								break;
						}
					}
				}

				if (enabledCellFound)
				{
					e.RowIndex = rowIndex;
					e.ColIndex = colIndex;
				}
				e.Result = enabledCellFound;
			}
			base.OnQueryNextCurrentCellPosition (e);
		}

    
		public static void SetupGridModel(GridModel model)
		{
			GridFactoryProvider.Init(new GridCellModelFactory());
			model.Options.AlphaBlendSelectionColor = Color.FromArgb(64, SystemColors.Highlight);
			model.Options.AllowSelection = GridSelectionFlags.Any; 

			//model.BaseStylesMap.RegisterStandardStyles();
			model.CommandStack.Enabled = true;
			model.QueryCellModel += new GridQueryCellModelEventHandler(ModelQueryCellModel);
			model.OperationFeedbackListener = new DelayedStatusDialog(model);

			model.BeginInit();
			model.RowCount = 1000;
			model.ColCount = 100;
			model.Rows.DefaultSize = 19;
			model.Cols.DefaultSize = 65;
			model.RowHeights[0] = 21;
			model.ColWidths[0] = 35;
			model.ColWidths[3] = 85;
			model.Options.ControllerOptions = GridControllerOptions.All;
			model.Options.DataObjectConsumerOptions = GridDataObjectConsumerOptions.All;


			GridStyleInfo standard = model.BaseStylesMap["Standard"].StyleInfo;
			GridStyleInfo header = model.BaseStylesMap["Header"].StyleInfo;
			GridStyleInfo rowHeader = model.BaseStylesMap["Row Header"].StyleInfo;
			GridStyleInfo colHeader = model.BaseStylesMap["Column Header"].StyleInfo;
			model.Properties.GridLineColor = Color.FromArgb(65, 57, 73, 122);

			GridFontInfo boldFont = new GridFontInfo();
			boldFont.Bold = true;
			boldFont.Size = 11;
			boldFont.Facename = "Helvetica";

			standard.TextColor = Color.FromArgb(0, 21, 84);
            
			GridStyleInfo boldFontStyle = new GridStyleInfo();
			boldFontStyle.TextColor =  Color.FromArgb(238, 122, 3);
			boldFontStyle.Font = boldFont;

			header.Interior = new BrushInfo(GradientStyle.Vertical, Color.FromArgb(65, 238, 234, 216), Color.FromArgb(65, 203, 199, 184));
			rowHeader.Interior = new BrushInfo(GradientStyle.Horizontal, Color.FromArgb(65, 238, 234, 216), Color.FromArgb(65, 203, 199, 184));

			bool showImageList = false;
			if (showImageList)
			{
				ImageList imageList = new ImageList();
				imageList.Images.Add(SystemIcons.Warning.ToBitmap());
				imageList.Images.Add(SystemIcons.Application.ToBitmap());
				imageList.Images.Add(SystemIcons.Asterisk.ToBitmap());
				imageList.Images.Add(SystemIcons.Error.ToBitmap());
				imageList.Images.Add(SystemIcons.Exclamation.ToBitmap());
				imageList.Images.Add(SystemIcons.Hand.ToBitmap());
				imageList.Images.Add(SystemIcons.Information.ToBitmap());
				imageList.Images.Add(SystemIcons.Question.ToBitmap());
				standard.ImageList = imageList;
			}

			ArrayList USStates = new ArrayList()   ;
			USStates.Add(new USState("Alabama", "AL", 0));
			USStates.Add(new USState("Washington", "WA", 1))  ; 
			USStates.Add(new USState("West Virginia", "WV", 2));
			USStates.Add(new USState("Wisconsin", "WI", 3)) ;
			USStates.Add(new USState("Wyoming", "WY", 4));
			USStates.Add(new USState("XAlabama", "AAL", 5));
			USStates.Add(new USState("XWashington", "AWA", 6))  ; 
			USStates.Add(new USState("XWest Virginia", "AWV", 1));
			USStates.Add(new USState("XWisconsin", "AWI", 2)) ;
			USStates.Add(new USState("XWyoming", "AWY", 3));
			USStates.Add(new USState("QAlabama", "BAL", 4));
			USStates.Add(new USState("QWashington", "BWA", 5))  ; 
			USStates.Add(new USState("QWest Virginia", "BWV", 6));
			USStates.Add(new USState("QWisconsin", "BWI", 0)) ;
			USStates.Add(new USState("QWyoming", "BWY", 1));

			standard.DataSource = USStates ;
			standard.DisplayMember = "LongName"     ;
			standard.ValueMember = "ShortName" ;

			Type type = typeof(Bitmap);
			System.IO.Stream stream = typeof(SampleGrid).Module.Assembly.GetManifestResourceStream(ApplicationMain.manifestNamespace + "logo_105_65.bmp");
			Bitmap bm = new Bitmap(stream);
			ImageList logoList = new ImageList();
			logoList.Images.Add(bm);
			logoList.ImageSize = bm.Size;
			logoList.ColorDepth = ColorDepth.Depth32Bit;

			int rowIndex = 2;
			int colIndex = 1;

			int boldfontRowHeight = 0;


			model.Options.FloatCellsMode = GridFloatCellsMode.OnDemandCalculation;


			model.CoveredRanges.Add(GridRangeInfo.Cells(2, 2, 4, 4));

			model[2, 2].Text = "Grid Demo";
			model[2, 2].Font.Bold = true;
			model[2, 2].Font.Size = 16;
			model[2, 2].HorizontalAlignment = GridHorizontalAlignment.Center;
			model[2, 2].VerticalAlignment = GridVerticalAlignment.Middle;
			model[2, 2].CellType = "Static";
			model[2, 2].Borders.All = new GridBorder(GridBorderStyle.Solid, Color.FromArgb(65, 238, 122, 3)); 
			model[2, 2].Interior = new BrushInfo(GradientStyle.PathEllipse, Color.FromArgb(65, 57, 73, 122), Color.FromArgb(65, 237, 240, 247));
			rowIndex += 5;

			model.CoveredRanges.Add(GridRangeInfo.Cells(rowIndex, 1, rowIndex, 2));
			model[rowIndex, 1].Text = "Interior";
			model.ChangeCells(GridRangeInfo.Cell(rowIndex, 1), boldFontStyle);
			model.RowHeights.ResizeToFit(GridRangeInfo.Cell(rowIndex, 1), GridResizeToFitOptions.ResizeCoveredCells|GridResizeToFitOptions.NoShrinkSize);
			boldfontRowHeight = model.RowHeights[rowIndex];
			rowIndex++;

			colIndex = 1;
			foreach (int index in new int[] {
												1,
												2,
												3,
												4,
												5,
												6,
			})
			{
				model[rowIndex, colIndex].ImageIndex = index;
				colIndex++;
			}
			rowIndex++;


			colIndex = 1;
			foreach (Color color1 in new Color[] {
													Color.FromArgb( 65, 0, 0, 51 ),
													Color.FromArgb( 65, 252, 172, 38 ),
													Color.FromArgb( 65, 33, 67, 126 ),
													Color.FromArgb( 65, 102, 110, 152 ),
													Color.FromArgb( 65, 204, 212, 230 ),
													Color.FromArgb(65, 237, 240, 247),
			})
			{
				model[rowIndex, colIndex].Interior = new BrushInfo(color1);
				colIndex++;
			}

			rowIndex++;
			colIndex = 1;
			foreach (PatternStyle pattern in new PatternStyle[] 
			{
				PatternStyle.Percent05,
				PatternStyle.Percent20,
				PatternStyle.Percent50,
				PatternStyle.Percent75,
				PatternStyle.DarkDownwardDiagonal,
				PatternStyle.LightDownwardDiagonal
			})
			{
				model[rowIndex, colIndex].Interior = new BrushInfo(pattern, Color.FromArgb(65, 237, 240, 247), Color.FromArgb(65, 57, 73, 122));
				colIndex++;
			}

			rowIndex++;
			colIndex = 1;
			foreach (GradientStyle gradient in new GradientStyle[] 
			{
				GradientStyle.BackwardDiagonal,
				GradientStyle.ForwardDiagonal,
				GradientStyle.PathEllipse,
				GradientStyle.PathRectangle,
				GradientStyle.Vertical,
				GradientStyle.Horizontal,
			})
			{
				model[rowIndex, colIndex].Interior = new BrushInfo(gradient, Color.FromArgb(65, 57, 73, 122), Color.FromArgb(65, 237, 240, 247));
				model[rowIndex+1, colIndex].Interior = new BrushInfo(gradient, Color.FromArgb(65, 237, 240, 247), Color.FromArgb(65, 51, 51, 102));
				colIndex++;
			}

			rowIndex++;
			rowIndex++;
			rowIndex++;
			colIndex = 1;

			model.CoveredRanges.Add(GridRangeInfo.Cells(rowIndex, 1, rowIndex, 2));
			model[rowIndex, 1].Text = "Font";
			model.ChangeCells(GridRangeInfo.Cell(rowIndex, 1), boldFontStyle);
			model.RowHeights[rowIndex] = boldfontRowHeight;
			rowIndex++;

			foreach (int size in new int[]
			{
				6,
				7,
				8,
				10,
				12,
				14
			})
			{
				model[rowIndex, colIndex].Font.Size = size;
				model[rowIndex, colIndex].Text = size.ToString();
				colIndex++;
			}
			model.RowHeights.ResizeToFit(GridRangeInfo.Row(rowIndex), GridResizeToFitOptions.ResizeCoveredCells|GridResizeToFitOptions.NoShrinkSize);

			rowIndex++;
			colIndex = 1;
			foreach (FontStyle fontStyle in new FontStyle[]
			{
				FontStyle.Bold,
				FontStyle.Italic,
				FontStyle.Regular,
				FontStyle.Strikeout,
				FontStyle.Underline,
				FontStyle.Bold|FontStyle.Italic|FontStyle.Regular,
			})
			{
				model[rowIndex, colIndex].Font.FontStyle = fontStyle;
				model[rowIndex, colIndex].Text = Enum.Format(typeof(FontStyle), fontStyle, "G");
				colIndex++;
			}

			rowIndex++;
			rowIndex++;
			colIndex = 1;

			model.CoveredRanges.Add(GridRangeInfo.Cells(rowIndex, 1, rowIndex, 2));
			model[rowIndex, 1].Text = "TextColor";
			model.ChangeCells(GridRangeInfo.Cell(rowIndex, 1), boldFontStyle);
			model.RowHeights[rowIndex] = boldfontRowHeight;
			rowIndex++;

			colIndex = 1;
			foreach (Color color2 in new Color[] {
													Color.Black,
													Color.Red,
													Color.Blue,
													Color.Green,
													Color.Yellow,
													Color.DimGray
												})
			{
				model[rowIndex, colIndex].TextColor = color2;
				model[rowIndex, colIndex].Text = ColorConvert.ColorToString(color2, true);
				colIndex++;
			}

			rowIndex++;
			rowIndex++;

			colIndex = 1;

			model.CoveredRanges.Add(GridRangeInfo.Cells(rowIndex, 1, rowIndex, 2));
			model[rowIndex, 1].Text = "Number Formats";
			model.ChangeCells(GridRangeInfo.Cell(rowIndex, 1), boldFontStyle);
			model.RowHeights[rowIndex] = boldfontRowHeight;
			rowIndex++;

			colIndex = 1;
			foreach (string format2 in new string[] 
				{
			
					"0.00",
					"C",
					"0.00;(0.00)",
					"###0.##%",
					"#0.#E+00",
					"10:##,##0.#"
				})
			{
				model[rowIndex, colIndex].Format = format2;
				model[rowIndex, colIndex].CellValue = Math.PI;
				model[rowIndex, colIndex].CellValueType = typeof(double);
				colIndex++;
			}

			rowIndex++;
			rowIndex++;

			colIndex = 1;

			model.CoveredRanges.Add(GridRangeInfo.Cells(rowIndex, 1, rowIndex, 2));
			model[rowIndex, 1].Text = "DateTime Formats";
			model.ChangeCells(GridRangeInfo.Cell(rowIndex, 1), boldFontStyle);
			model.RowHeights[rowIndex] = boldfontRowHeight;
			rowIndex++;

			colIndex = 1;
			foreach (string format in new string[] 
				{
			
					"d",
					"D",
					"f",
					"dddd, dd MMMM yyyy",
					"t",
					"s"
				})
			{
				model[rowIndex, colIndex].Format = format;
				model[rowIndex, colIndex].CellValue = DateTime.Now;
				model[rowIndex, colIndex].CellValueType = typeof(DateTime);
				colIndex++;
			}

			rowIndex++;
			rowIndex++;
            
			model.CoveredRanges.Add(GridRangeInfo.Cells(rowIndex, 1, rowIndex, 2));
			model[rowIndex, 1].Text = "Validation";
			model.ChangeCells(GridRangeInfo.Cell(rowIndex, 1), boldFontStyle);
			model.RowHeights[rowIndex] = boldfontRowHeight;
			rowIndex++;

			model[rowIndex, 1].Text = "Positive numbers";
			model.RowStyles[rowIndex].ValidateValue.NumberRequired = true;
			model.RowStyles[rowIndex].ValidateValue.Minimum = 0;
			model.RowStyles[rowIndex].ValidateValue.Maximum = float.NaN;
			model.RowStyles[rowIndex].ValidateValue.ErrorMessage = "Please enter a number greater than 0!";
			rowIndex++;

			model[rowIndex, 1].Text = "Validation (1-100 valid range)";
			model.RowStyles[rowIndex].ValidateValue = new GridCellValidateValueInfo(true, 1, 100, "Please enter a number between 1 and 100!");
			rowIndex++;
			rowIndex++;

			model.CoveredRanges.Add(GridRangeInfo.Cells(rowIndex, 1, rowIndex, 2));
			model[rowIndex, 1].Text = "Cell Types";
			model.ChangeCells(GridRangeInfo.Cell(rowIndex, 1), boldFontStyle);
			model.RowHeights[rowIndex] = boldfontRowHeight;
			rowIndex++;

			colIndex = 1;

			model.TableStyle.CheckBoxOptions = new GridCheckBoxCellInfo("True", "False", "", false);
			model[rowIndex, 1].Text = "CheckBox";
			model[rowIndex, 3].CellType = "CheckBox";
			model[rowIndex, 3].TriState = false;
			model[rowIndex, 3].Text = "True";
			model[rowIndex, 3].VerticalAlignment = GridVerticalAlignment.Middle;
			model[rowIndex, 3].Description = "Enabled";
			model[rowIndex, 4].CellType = "CheckBox";
			model[rowIndex, 4].Text = "False";
			model[rowIndex, 4].Enabled = false;
			model[rowIndex, 4].Description = "Disabled";
			model[rowIndex, 4].VerticalAlignment = GridVerticalAlignment.Middle;
			model[rowIndex, 5].CellType = "CheckBox";
			model[rowIndex, 5].TriState = true;
			model[rowIndex, 5].Description = "TriState";
			model[rowIndex, 5].VerticalAlignment = GridVerticalAlignment.Middle;
			rowIndex++;

			rowIndex++;
			rowIndex++;

			model[rowIndex, 1].Text = "DragButton";
			model[rowIndex, 3].Text = "Drag";
			model[rowIndex, 3].CellType = "DragButton";
			rowIndex++;

			model.TableStyle.NumericUpDown = new GridNumericUpDownCellInfo(0, 25, 1, 1, true);
			model[rowIndex, 1].Text = "NumericUpDown";
			// Wrapping, Range 0-1000
			model[rowIndex, 3].CellType = "NumericUpDown";
			model[rowIndex, 3].NumericUpDown = new GridNumericUpDownCellInfo(0, 1000, 0, 1, true);
			// Disabled
			model[rowIndex, 4].CellType = "NumericUpDown";
			model[rowIndex, 4].Enabled = false;
			model[rowIndex, 4].Text = "5";
			// No wrapping, Range 1-20
			model[rowIndex, 5].CellType = "NumericUpDown";
			model[rowIndex, 5].NumericUpDown = new GridNumericUpDownCellInfo(1, 20, 1, 1, false);
			rowIndex++;

			model[rowIndex, 1].Text = "PushButton";
			model[rowIndex, 3].CellType = "PushButton";
			model[rowIndex, 3].Description = "Enabled";
			model[rowIndex, 4].CellType = "PushButton";
			model[rowIndex, 4].Enabled = false;
			model[rowIndex, 4].Clickable = false;
			model[rowIndex, 4].Description = "Disabled";
			rowIndex++;

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

			model[rowIndex, 1].Text = "ComboBox (Edit)";

			model[rowIndex, 3].CellType = "ComboBox";
			model[rowIndex, 3].ChoiceList = items;
			// Disabled
			model[rowIndex, 4].CellType = "ComboBox";
			model[rowIndex, 4].ChoiceList = items;
			model[rowIndex, 4].Enabled = false;
			model[rowIndex, 4].CellValue = items[5];
			rowIndex++;

			model[rowIndex, 1].Text = "ComboBox (List)";

			model[rowIndex, 3].CellType = "ComboBox";
			model[rowIndex, 3].ChoiceList = items;
			model[rowIndex, 3].ExclusiveChoiceList = true;  // tell combobox to behave like CBS_DROPDOWNSTYLE
			// Disabled
			model[rowIndex, 4].CellType = "ComboBox";
			model[rowIndex, 4].ChoiceList = items;
			model[rowIndex, 4].Enabled = false;
			model[rowIndex, 4].ExclusiveChoiceList = true;  // tell combobox to behave like CBS_DROPDOWNSTYLE
			model[rowIndex, 4].CellValue = items[5];
			rowIndex++;
			rowIndex++;

			model[rowIndex, 1].Text = "GridListControl (Edit)";
			model[rowIndex, 3].CellType = "GridListControl";
			model[rowIndex, 3].DataSource = USStates;

			// Disabled
			model[rowIndex, 4].CellType = "GridListControl";
			model[rowIndex, 4].DataSource = USStates;
			rowIndex++;

			model[rowIndex, 1].Text = "GridListControl (List)";

			model[rowIndex, 3].CellType = "GridListControl";
			model[rowIndex, 3].DataSource = USStates ;
			model[rowIndex, 3].ExclusiveChoiceList = true;  // tell combobox to behave like CBS_DROPDOWNSTYLE
			rowIndex++;
			rowIndex++;

            
			model.CoveredRanges.Add(GridRangeInfo.Cells(rowIndex, 1, rowIndex, 2));
			model[rowIndex, 1].Text = "DropDown Cells";
			model.ChangeCells(GridRangeInfo.Cell(rowIndex, 1), boldFontStyle);
			model.RowHeights[rowIndex] = boldfontRowHeight;
			rowIndex++;

			//
			model[rowIndex, 1].Text = "Generic DropDown";
			model[rowIndex, 3].CellType = "DropDown";
			rowIndex++;

			model[rowIndex, 1].Text = "MonthCalendar";
			model[rowIndex, 3].CellType = "MonthCalendar";
			rowIndex++;

			model[rowIndex, 1].Text = "ColorEdit";
			model[rowIndex, 3].CellType = "ColorEdit";
			rowIndex++;

			model[rowIndex, 1].Text = "DropDownGrid";
			model[rowIndex, 3].CellType = "DropDownGrid";
			rowIndex++;
			rowIndex++;

			colIndex = 1;

			model.CoveredRanges.Add(GridRangeInfo.Cells(rowIndex, 1, rowIndex, 2));
			model[rowIndex, 1].Text = "Borders";
			model.ChangeCells(GridRangeInfo.Cell(rowIndex, 1), boldFontStyle);
			model.RowHeights[rowIndex] = boldfontRowHeight;
			rowIndex++;

			foreach (GridBorder border2 in new GridBorder[] {
															   new GridBorder(GridBorderStyle.Solid, Color.FromArgb(57, 73, 122)),
															   new GridBorder(GridBorderStyle.Dotted, Color.FromArgb(238, 122, 3)),
															   new GridBorder(GridBorderStyle.DashDot, Color.FromArgb(57, 73, 122)),
															   new GridBorder(GridBorderStyle.DashDotDot, Color.FromArgb(238, 122, 3)),
															   new GridBorder(GridBorderStyle.Dashed, Color.FromArgb(57, 73, 122), GridBorderWeight.Medium),
															   new GridBorder(GridBorderStyle.Dotted, Color.FromArgb(238, 122, 3), GridBorderWeight.Medium),
			})
			{
				model[rowIndex, colIndex].Borders.Bottom = border2;
				model[rowIndex, colIndex].Borders.Right = border2;
				model[rowIndex, colIndex].Text = border2.ToString();
				colIndex++;
			}

			rowIndex++;
			colIndex = 1;
			foreach (GridBorder border in new GridBorder[] {
															   new GridBorder(GridBorderStyle.Dashed, Color.FromArgb(57, 73, 122), GridBorderWeight.Thick),
															   new GridBorder(GridBorderStyle.Dotted, Color.FromArgb(238, 122, 3), GridBorderWeight.Thick),
															   new GridBorder(GridBorderStyle.DashDot, Color.FromArgb(57, 73, 122), GridBorderWeight.Medium),
															   new GridBorder(GridBorderStyle.DashDotDot, Color.FromArgb(238, 122, 3), GridBorderWeight.Medium),
															   new GridBorder(GridBorderStyle.Solid, Color.FromArgb(57, 73, 122), GridBorderWeight.Thick),
															   new GridBorder(GridBorderStyle.Solid, Color.FromArgb(238, 122, 3), GridBorderWeight.Medium),
			})
			{
				model[rowIndex, colIndex].Borders.Bottom = border;
				model[rowIndex, colIndex].Borders.Right = border;
				model[rowIndex, colIndex].Text = border.ToString();
				colIndex++;
			}

			rowIndex++;
			rowIndex++;
			colIndex = 1;

			model.CoveredRanges.Add(GridRangeInfo.Cells(rowIndex, 1, rowIndex, 2));
			model[rowIndex, 1].Text = "Orientation";
			model[rowIndex, 1].ModifyStyle(boldFontStyle, StyleModifyType.Override);
			model.RowHeights[rowIndex] = boldfontRowHeight;
			rowIndex++;

			foreach (int orientation in new int[]
			{
				0,
				45,
				60,
				90,
				180,
				-90
			})
			{
				GridStyleInfo style1 = model[rowIndex, colIndex];
				// style1 is a direct reference to model[rowIndex, colIndex]; 
				// changes will be propagated back to GridData
				style1.HorizontalAlignment = GridHorizontalAlignment.Center;
				style1.VerticalAlignment = GridVerticalAlignment.Middle;
				GridFontInfo font = style1.Font;
				font.Orientation = orientation;
				font.Bold = true;
				style1.Text = "Angle = " + font.Orientation.ToString();
				colIndex++;
			}

			rowIndex++;
			rowIndex++;
			colIndex = 1;

			model.CoveredRanges.Add(GridRangeInfo.Cells(rowIndex, 1, rowIndex, 2));
			model[rowIndex, 1].Text = "Enabled";
			model[rowIndex, 1].ModifyStyle(boldFontStyle, StyleModifyType.Override);
			model.RowHeights[rowIndex] = boldfontRowHeight;
			rowIndex++;

			foreach (bool enabled1 in new bool[]
			{
				true,
				false,
				true,
				false,
				false,
				true,
			})
			{
				model[rowIndex, colIndex].Text = enabled1?"YES":"NO";
				model[rowIndex, colIndex].Interior = new BrushInfo((Color) (enabled1?Color.FromArgb(65,57, 73, 122):Color.FromArgb(65,238, 122, 3)));
				model[rowIndex, colIndex].Enabled = enabled1;
				colIndex++;
			}

			colIndex = 1;
			rowIndex++;

			foreach (bool enabled2 in new bool[]
			{
				true,
				true,
				false,
				false,
				false,
				true,
			})
			{
				model[rowIndex, colIndex].Text = enabled2?"YES":"NO";
				model[rowIndex, colIndex].Interior = new BrushInfo((Color) (enabled2?Color.FromArgb(65,57, 73, 122):Color.FromArgb(65,238, 122, 3)));
				model[rowIndex, colIndex].Enabled = enabled2;
				colIndex++;
			}
            
			rowIndex++;
			rowIndex++;
			colIndex = 1;

			model.CoveredRanges.Add(GridRangeInfo.Cells(rowIndex, 1, rowIndex, 2));
			model[rowIndex, 1].Text = "AutoSize";
			model[rowIndex, 1].ModifyStyle(boldFontStyle, StyleModifyType.Override);
			model.RowHeights[rowIndex] = boldfontRowHeight;
			rowIndex++;

			model.RowStyles[rowIndex].AutoSize = true;
			model.RowStyles[rowIndex].Text = "Row height will increase while you type text";
			model.RowStyles[rowIndex].Interior = new BrushInfo(Color.Beige);

			rowIndex++;
			rowIndex++;
			colIndex = 1;

			model.CoveredRanges.Add(GridRangeInfo.Cells(rowIndex, 1, rowIndex, 2));
			model[rowIndex, 1].Text = "Read Only";
			model[rowIndex, 1].ModifyStyle(boldFontStyle, StyleModifyType.Override);
			model.RowHeights[rowIndex] = boldfontRowHeight;
			rowIndex++;

			model.RowStyles[rowIndex].ReadOnly = true;
			model.RowStyles[rowIndex].Interior = new BrushInfo(Color.LightGray);
			model.RowStyles[rowIndex].Text = "ReadOnly";
			rowIndex++;
			rowIndex++;


			model.Options.ExcelLikeCurrentCell = false;
			model.Options.ExcelLikeSelectionFrame = false;
			model.Options.ActivateCurrentCellBehavior = GridCellActivateAction.ClickOnCell;
			model.Properties.MarkColHeader = true;
			model.Properties.MarkRowHeader = true;

			model.RowHeights.ResizeToFit(GridRangeInfo.Cells(2, 1, rowIndex, 3), GridResizeToFitOptions.ResizeCoveredCells|GridResizeToFitOptions.NoShrinkSize);
			model.EndInit();
		}

		static void ModelQueryCellModel(object sender, GridQueryCellModelEventArgs e)
		{
			if (e.CellModel == null)
			{
				IGridCellModelFactory pGridCellObjectFactory = GridFactoryProvider.CellModelFactory;
			
				if (pGridCellObjectFactory != null)
					e.CellModel = pGridCellObjectFactory.CreateCellModel(e.CellType, (GridModel) sender);
			}
		}

		protected override void OnKeyDown(KeyEventArgs e)
		{
			bool runTests = false;
			if (runTests)
			{
				if (e.KeyData == Keys.T)
				{
					// Let's run some style tests.
					GridStyleInfo style = new GridStyleInfo();
					MessageBox.Show(style.ToString("d"), "Empty Style");

					MessageBox.Show(GridStyleInfo.Default.ToString(), "GridStyleInfo.Default.ToString()");

					MessageBox.Show(Model.TableStyle.ToString(), "TableStyle.ToString()");
					MessageBox.Show(Model.TableStyle.ToString("d"), "TableStyle.ToString(\"d\")");

					MessageBox.Show(Model[1, 1].ToString(), "Model[1, 1].ToString()");
					MessageBox.Show(Model[1, 1].ToString("d"), "Model[1, 1].ToString(\"d\")");

					MessageBox.Show(Model.RowStyles[1].ToString(), "RowStyles[1].ToString()");
					MessageBox.Show(Model.RowStyles[1].ToString("d"), "RowStyles[1].ToString(\"d\")");

					string t = Model.TableStyle.ToString();
					GridStyleInfo parseStyle = new GridStyleInfo();
					parseStyle.ParseString(t);
					MessageBox.Show(parseStyle.ToString(), "parseStyle.ToString()");
				}

				if (e.KeyData == Keys.F1)
				{
					// TODO: hangs when you change base style in property grid.
					StyleInfoForm form = new StyleInfoForm(Model.ColStyles[1]);
					form.ShowDialog();
					Refresh();
				}

				if (e.KeyData == Keys.F3)
				{
					CurrentCell.MoveTo(5,4, GridSetCurrentCellOptions.SetFocus);
					return;
				}

				if (e.KeyData == Keys.F4)
				{
					// TODO: hangs when you change base style in property grid.
					StyleInfoForm form = new StyleInfoForm(Model[0,0]);
					form.ShowDialog();
					Refresh();
				}

				if (e.KeyData == Keys.F5)
				{
					Model.Selections.Clear();
				}

				if (e.KeyData == Keys.F6)
				{
					Model.Selections.Add(GridRangeInfo.Cells(2, 2, 10, 4));
				}
#if !NETCORE
                if (e.KeyData == Keys.M)
				{
                    // TODO: Show Default value for base style in property grid
                    GridBaseStyleCollectionEditor ce = new GridBaseStyleCollectionEditor(typeof(GridBaseStylesMap));
                    WindowsFormsEditorServiceContainer esc = new WindowsFormsEditorServiceContainer(null);
                    PropertyDescriptor pd = TypeDescriptor.GetProperties(Model)["GridBaseStylesMap"];
                    TypeDescriptorContext tdc = new TypeDescriptorContext(Model, pd);
                    tdc.ServiceProvider = esc;
                    object v = ce.EditValue(tdc, esc, Model.BaseStylesMap.Clone());
                    if (esc.DialogResult == DialogResult.OK)
                    {
                        Model.BaseStylesMap = (GridBaseStylesMap)v;
                    }
                }
#endif
			}

			base.OnKeyDown(e);
		}


		// Sample code for inserting a work sheet.

		protected override void OnCellDoubleClick(GridCellClickEventArgs e)
		{
			WorkbookForm form = FindForm() as WorkbookForm;

			if (form != null)
			{
				WorkbookModel workbook = form.WorkbookView.Workbook;

				GridModel sheet3 = new SampleGridModel();
				SampleGrid.SetupGridModel(sheet3);
 
				WorksheetModel workSheetModel = new WorksheetModel(workbook, "Sheet 3", sheet3);
				workbook.Worksheets.Add(workSheetModel);

				form.WorkbookView.ActivePage = form.WorkbookView.TabBarPages[workbook.Worksheets.Count-1];
			}

			base.OnCellDoubleClick (e);
		}

	}

	[Serializable]
	public class USState
	{
		private string myShortName ;
		private string myLongName ;
		private int _imageIndex;
   
		public  USState(string strLongName, string strShortName, int _imageIndex)
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

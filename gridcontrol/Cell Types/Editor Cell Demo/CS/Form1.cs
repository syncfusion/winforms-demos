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

namespace EditorCellDemo
{
	using System;
	using System.Drawing;
	using System.Collections;
	using System.Collections.Specialized;
	using System.ComponentModel;
	using System.Windows.Forms;
	using System.Data;
	using Syncfusion.Drawing;
	using Syncfusion.Windows.Forms.Grid;
    using System.Reflection;
    using System.IO;
    using Syncfusion.Diagnostics;
    using Syncfusion.Windows.Forms;
    using Syncfusion.Styles;
    using Syncfusion.Windows.Forms.Tools;
    using DemoCommon.Grid;

	public class Form1 : GridDemoForm
    {
        #region "API Definition"

        private GridControl gridControl1;
        private PropertyGrid propertyGrid1;
        private GroupBox groupBox1;
        private Label label1;
        private CheckBoxAdv checkBoxAdv1;
        private IContainer components;

        #endregion

        #region "Constructor"

        public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
            this.GridSettings();
            InitializeGrid();
            if (DpiAware.GetCurrentDpi() > 96)
            {
                this.CaptionBarHeight = (int)DpiAware.LogicalToDeviceUnits(this.CaptionBarHeight);
            }
            this.propertyGrid1.SelectedObject = gridControl1;
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
            //Used to set selection mode in grid
            this.gridControl1.Model.Options.DisplayEmptyColumns = true;
            this.gridControl1.Model.Options.DisplayEmptyRows = true;
        }
        #endregion

        #region "Initialization Grid"

        private void InitializeGrid()
        {

          #region Style prerequistes
            GridStyleInfo standard = gridControl1.BaseStylesMap["Standard"].StyleInfo;
            standard.Font.Bold = false;
            standard.Font.Facename = "Verdana"; //"Verdana";
            standard.Font.Size = 10;
            standard.TextColor = Color.FromArgb(240, 0, 21, 84);
            gridControl1.Font = new System.Drawing.Font("Verdana", 8.5F);


            // grab some images...
            ImageList imageList = new ImageList();
            imageList.Images.Add(SystemIcons.Warning.ToBitmap());
            imageList.Images.Add(SystemIcons.Application.ToBitmap());
            imageList.Images.Add(SystemIcons.Asterisk.ToBitmap());
            imageList.Images.Add(SystemIcons.Error.ToBitmap());
            imageList.Images.Add(SystemIcons.Exclamation.ToBitmap());
            imageList.Images.Add(SystemIcons.Hand.ToBitmap());
            imageList.Images.Add(SystemIcons.Information.ToBitmap());
            imageList.Images.Add(SystemIcons.Question.ToBitmap());
            //standard.ImageList = imageList;

            Icon icon = new Icon(GetType().Module.Assembly.GetManifestResourceStream("EditorCellDemo.gridform.ico"));
            imageList.Images.Add(icon.ToBitmap());

            icon = new Icon(GetType().Module.Assembly.GetManifestResourceStream("EditorCellDemo.toolsform.ico"));
            imageList.Images.Add(icon.ToBitmap());
            standard.ImageList = imageList;

            #endregion

          #region Codes to apply celltypes in Grid
            this.gridControl1.BeginUpdate();
            gridControl1.TableStyle.FloatCell = true;
            gridControl1.FloatCellsMode = GridFloatCellsMode.BeforeDisplayCalculation;

            #region Style declaration
            GridStyleInfo headerstyle = new GridStyleInfo();
            headerstyle.Font.Size = 12;
            headerstyle.Font.Bold = true;
            headerstyle.VerticalAlignment = GridVerticalAlignment.Middle;
            headerstyle.HorizontalAlignment = GridHorizontalAlignment.Center;
            headerstyle.CellType = GridCellTypeName.Static;

            GridStyleInfo subheaderstyle = new GridStyleInfo();
            subheaderstyle.Font.Bold = true;
            subheaderstyle.VerticalAlignment = GridVerticalAlignment.Middle;
            subheaderstyle.HorizontalAlignment = GridHorizontalAlignment.Center;
            subheaderstyle.CellType = GridCellTypeName.Static;
            subheaderstyle.TextColor = Color.Gray;

            gridControl1.Model.ColWidths[4] = 90;
            gridControl1.Model.ColWidths[6] = 100;
            #endregion

            #region TextBox Cells
            gridControl1.CoveredRanges.Add(GridRangeInfo.Cells(1, 1, 2, gridControl1.ColCount));
            gridControl1[1, 1] = headerstyle;
            gridControl1[1, 1].Text = "TextBox Cells";

            int rowIndex = 3, colIndex = 4;
            gridControl1.CoveredRanges.Add(GridRangeInfo.Cells(rowIndex, 1, rowIndex, gridControl1.ColCount));
            gridControl1[rowIndex, 1] = subheaderstyle;
            gridControl1[rowIndex, 1].Text = "TextBox Cells - represents the default textbox control in a cell as used for in - place editing";
            rowIndex++;
            gridControl1[rowIndex, colIndex].Text = "TextBox";
            gridControl1[rowIndex, colIndex].CellType = GridCellTypeName.TextBox;
            gridControl1[rowIndex, colIndex + 2].Text = "TextBox/Image";
            gridControl1[rowIndex, colIndex + 2].CellType = GridCellTypeName.TextBox;
            gridControl1[rowIndex, colIndex + 2].ImageIndex = 9;
            gridControl1.Model.ColWidths.ResizeToFit(GridRangeInfo.Col(colIndex + 2));
            #endregion

            #region MaskEditCells
            rowIndex += 2;
            gridControl1.CoveredRanges.Add(GridRangeInfo.Cells(rowIndex, 1, rowIndex + 1, gridControl1.ColCount));
            gridControl1[rowIndex, 1] = headerstyle;
            gridControl1[rowIndex, 1].Text = "MaskEdit Cells";
            rowIndex++;
            rowIndex++;
            gridControl1.CoveredRanges.Add(GridRangeInfo.Cells(rowIndex, 1, rowIndex, gridControl1.ColCount));
            gridControl1[rowIndex, 1] = subheaderstyle;
            gridControl1[rowIndex, 1].Text = "MaskEdit Cells - allow to mask any cell that permits valid inputs & also control the inputs values";
            
            rowIndex++;
            rowIndex++;
            gridControl1[rowIndex, colIndex].Text = "Date Format";
            gridControl1[rowIndex, colIndex + 2].CellType = GridCellTypeName.MaskEdit;
            gridControl1[rowIndex, colIndex + 2].MaskEdit.Mask = "99-99-99";
            gridControl1[rowIndex, colIndex + 2].FloatCell = true;

            rowIndex++;
            rowIndex++;
            gridControl1[rowIndex, colIndex].Text = "First Name";
            GridStyleInfo style1 = gridControl1[rowIndex, colIndex + 2];
            GridMaskEditInfo maskedEditStyle1 = style1.MaskEdit;

            rowIndex++;
            rowIndex++;
            gridControl1[rowIndex, colIndex].Text = "Last Name";
            GridStyleInfo style2 = gridControl1[rowIndex, colIndex + 2];
            GridMaskEditInfo maskedEditStyle2 = style2.MaskEdit;

            rowIndex++;
            rowIndex++;
            gridControl1[rowIndex, colIndex].Text = "Telephone";
            GridStyleInfo style3 = gridControl1[rowIndex, colIndex + 2];
            GridMaskEditInfo maskedEditStyle3 = style3.MaskEdit;

            rowIndex++;
            rowIndex++;
            gridControl1[rowIndex, colIndex].Text = "Social Security";
            GridStyleInfo style4 = gridControl1[rowIndex, colIndex + 2];
            GridMaskEditInfo maskedEditStyle4 = style4.MaskEdit;

            #region MaskEditBoxes
            // 
            // maskedEditBox1
            // 
            style1.CellType = "MaskEdit";
            maskedEditStyle1.AllowPrompt = false;
            maskedEditStyle1.ClipMode = Syncfusion.Windows.Forms.Tools.ClipModes.ExcludeLiterals;
            style1.CultureInfo = new System.Globalization.CultureInfo("en-US");
            maskedEditStyle1.DateSeparator = '-';
            maskedEditStyle1.Mask = ">C<CCCCCCCCCCCC";
            style1.MaxLength = 13;
            style1.AutoSize = true;
            maskedEditStyle1.SpecialCultureValue = Syncfusion.Windows.Forms.Tools.SpecialCultureValues.None;
            maskedEditStyle1.UseLocaleDefault = false;
            maskedEditStyle1.UseUserOverride = true;

            // 
            // maskedEditBox2
            // 
            style2.CellType = "MaskEdit";
            maskedEditStyle2.AllowPrompt = false;
            maskedEditStyle2.ClipMode = Syncfusion.Windows.Forms.Tools.ClipModes.IncludeLiterals;
            style2.CultureInfo = new System.Globalization.CultureInfo("en-US");
            maskedEditStyle2.DateSeparator = '-';
            maskedEditStyle2.Mask = "CCCCCCCCCCCCC";
            style2.MaxLength = 13;
            maskedEditStyle2.SpecialCultureValue = Syncfusion.Windows.Forms.Tools.SpecialCultureValues.None;
            style2.Text = "_____________";
            maskedEditStyle2.UseLocaleDefault = false;
            maskedEditStyle2.UseUserOverride = true;
            // 
            // maskedEditBox3
            // 
            style3.CellType = "MaskEdit";
            maskedEditStyle3.AllowPrompt = false;
            maskedEditStyle3.ClipMode = Syncfusion.Windows.Forms.Tools.ClipModes.IncludeLiterals;
            style3.CultureInfo = new System.Globalization.CultureInfo("en-US");
            maskedEditStyle3.DateSeparator = '-';
            maskedEditStyle3.Mask = "(999) 999 - 9999";
            style3.MaxLength = 16;
            maskedEditStyle3.SpecialCultureValue = Syncfusion.Windows.Forms.Tools.SpecialCultureValues.None;
            style3.Text = "(___) ___ - ____";
            maskedEditStyle3.UseLocaleDefault = false;
            maskedEditStyle3.UseUserOverride = true;
            // 
            // maskedEditBox4
            // 
            style4.CellType = "MaskEdit";
            maskedEditStyle4.AllowPrompt = false;
            maskedEditStyle4.ClipMode = Syncfusion.Windows.Forms.Tools.ClipModes.IncludeLiterals;
            style4.CultureInfo = new System.Globalization.CultureInfo("en-US");
            maskedEditStyle4.DateSeparator = '-';
            maskedEditStyle4.Mask = "999-99-9999";
            style4.MaxLength = 11;
            maskedEditStyle4.SpecialCultureValue = Syncfusion.Windows.Forms.Tools.SpecialCultureValues.None;
            style4.Text = "___-__-____";
            maskedEditStyle4.UseLocaleDefault = false;
            maskedEditStyle4.UseUserOverride = true;
            #endregion
            #endregion

            #region NumericUpDown
            rowIndex++;
            rowIndex++;
            gridControl1.CoveredRanges.Add(GridRangeInfo.Cells(rowIndex, 1, rowIndex + 1, gridControl1.ColCount));
            gridControl1[rowIndex, 1] = headerstyle;
            gridControl1[rowIndex, 1].Text = "NumericUpDown Cells";

            rowIndex += 3;
            // Wrapping, Range 0-20
            gridControl1[rowIndex, colIndex].Text = "With wrapping";
            gridControl1[rowIndex, colIndex + 2].CellType = GridCellTypeName.NumericUpDown;
            gridControl1[rowIndex, colIndex + 2].Text = "5";
            gridControl1[rowIndex, colIndex + 2].HorizontalAlignment = GridHorizontalAlignment.Right;
            gridControl1[rowIndex, colIndex + 2].NumericUpDown = new GridNumericUpDownCellInfo(0, 20, 5, 1, true);

            rowIndex++;
            rowIndex++;
            gridControl1[rowIndex, colIndex].Text = "Without wrapping";
            gridControl1[rowIndex, colIndex + 2].CellType = GridCellTypeName.NumericUpDown;
            gridControl1[rowIndex, colIndex + 2].Text = "5";
            gridControl1[rowIndex, colIndex + 2].NumericUpDown = new GridNumericUpDownCellInfo(1, 20, 1, 1, false);
            gridControl1[rowIndex, colIndex + 2].HorizontalAlignment = GridHorizontalAlignment.Right;
            #endregion

            #region Currency Cells
            rowIndex++;
            rowIndex++;
            gridControl1.CoveredRanges.Add(GridRangeInfo.Cells(rowIndex, 1, rowIndex + 1, gridControl1.ColCount));
            gridControl1[rowIndex, 1] = headerstyle;
            gridControl1[rowIndex, 1].Text = "Currency Cells";

            rowIndex++;
            rowIndex++;
            gridControl1.CoveredRanges.Add(GridRangeInfo.Cells(rowIndex, 1, rowIndex, gridControl1.ColCount));
            gridControl1[rowIndex, 1] = subheaderstyle;
            gridControl1[rowIndex, 1].Text = "Supports setting patterns to display (+), (-) numbers, grouping digits & decimal separators";

            #region CurrentStyle Settings
            GridStyleInfo currencyStyle = new GridStyleInfo();
            currencyStyle.CellType = GridCellTypeName.Currency;
            currencyStyle.CurrencyEdit.ClipMode = CurrencyClipModes.ExcludeFormatting;
            // Set formatting properties
            currencyStyle.CurrencyEdit.NullString = "";
            currencyStyle.CurrencyEdit.CurrencyDecimalDigits = 2;
            currencyStyle.CurrencyEdit.CurrencyDecimalSeparator = ".";
            currencyStyle.CurrencyEdit.CurrencyGroupSeparator = ",";
            currencyStyle.CurrencyEdit.CurrencyGroupSizes = new int[] { 3 };
            currencyStyle.CurrencyEdit.CurrencyNumberDigits = 27;
            currencyStyle.CurrencyEdit.CurrencyPositivePattern = 0;
            //currencyStyle.CurrencyEdit.CurrencySymbol = (row % 2 == 0) ? "$ " : "DM ";
            currencyStyle.TextColor = System.Drawing.Color.Black;
            currencyStyle.CurrencyEdit.NegativeColor = System.Drawing.Color.Red;
            currencyStyle.CurrencyEdit.NegativeSign = "-";
            currencyStyle.CurrencyEdit.PositiveColor = System.Drawing.Color.Black;
            currencyStyle.FloatCell = true;
            #endregion

            rowIndex++;
            rowIndex++;
            gridControl1[rowIndex, colIndex - 2] = currencyStyle;
            gridControl1[rowIndex, colIndex - 2].CellValue = 2;
            gridControl1[rowIndex, colIndex - 2].CurrencyEdit.CurrencyNegativePattern = 1;
            gridControl1[rowIndex, colIndex - 2].CurrencyEdit.CurrencySymbol = "$ ";

            gridControl1[rowIndex, colIndex] = currencyStyle;
            gridControl1[rowIndex, colIndex].CellValue = 4;
            gridControl1[rowIndex, colIndex].CurrencyEdit.CurrencyNegativePattern = 2;
            gridControl1[rowIndex, colIndex].CurrencyEdit.CurrencySymbol = "DM";

            gridControl1[rowIndex, colIndex + 2] = currencyStyle;
            gridControl1[rowIndex, colIndex + 2].CellValue = -6;
            gridControl1[rowIndex, colIndex + 2].CurrencyEdit.CurrencyNegativePattern = 1;
            gridControl1[rowIndex, colIndex + 2].CurrencyEdit.CurrencySymbol = "$ ";

            gridControl1[rowIndex, colIndex + 4] = currencyStyle;
            gridControl1[rowIndex, colIndex + 4].CellValue = -8;
            gridControl1[rowIndex, colIndex + 4].CurrencyEdit.CurrencyNegativePattern = 2;
            gridControl1[rowIndex, colIndex + 4].CurrencyEdit.CurrencySymbol = "DM ";

            #endregion

            #region Password cells

            rowIndex++;
            rowIndex++;
            gridControl1.CoveredRanges.Add(GridRangeInfo.Cells(rowIndex, 1, rowIndex + 1, gridControl1.ColCount));
            gridControl1[rowIndex, 1] = headerstyle;
            gridControl1[rowIndex, 1].Text = "Password Cells";

             rowIndex++;
            rowIndex++;
            gridControl1.CoveredRanges.Add(GridRangeInfo.Cells(rowIndex, 1, rowIndex, gridControl1.ColCount));
            gridControl1[rowIndex, 1] = subheaderstyle;
            gridControl1[rowIndex, 1].Text = "Allows you to type a password, but only masking character like \" * \", will be displayed ";


            GridStyleInfo passwdStyle = new GridStyleInfo();
            for (int row = 37; row <= 45; row++)
            {
                passwdStyle = gridControl1[row, 2];
                passwdStyle.PasswordChar = '*';
                passwdStyle.CellType = GridCellTypeName.OriginalTextBox;
                passwdStyle.Text = new string((char)(65 + row), row);

                passwdStyle = gridControl1[row, 3];
                passwdStyle.CharacterCasing = CharacterCasing.Lower;
                passwdStyle.Text = new string((char)(65 + row), row);

                passwdStyle = gridControl1[row, 4];
                passwdStyle.CharacterCasing = CharacterCasing.Upper;
                passwdStyle.Text = new string((char)(65 + row), row);
            }
            #endregion

            gridControl1.CheckBoxClick += new GridCellClickEventHandler(gridControl1_CheckBoxClick);
            gridControl1.Model.ColWidths.ResizeToFit(GridRangeInfo.Cols(1,11));
            gridControl1.Model.ColWidths[0] = (int)DpiAware.LogicalToDeviceUnits(35);
            this.gridControl1.EndUpdate(true);
            #endregion
        }

        #region "Events"
        private void checkBoxAdv1_CheckStateChanged(object sender, EventArgs e)
        {
            if (checkBoxAdv1.Checked)
            {
                this.gridControl1.BrowseOnly = true;
                this.propertyGrid1.Enabled = false;
            }
            else
            {
                this.gridControl1.BrowseOnly = false;
                this.propertyGrid1.Enabled = true;
            }
        }
        #endregion

        #endregion

        #region "Helper Methods"

        void gridControl1_CheckBoxClick(object sender, GridCellClickEventArgs e)
        {
            if (e.RowIndex == 21)
            {
                for (int i = 23; i <= 36; i++)
                {
                    gridControl1.HideRows[i] = !gridControl1.HideRows[i];
                }
            }
            if (e.RowIndex == 36)
            {
                Animate(!(gridControl1[e.RowIndex, e.ColIndex].Text == "True"));
            }
        }

        Timer timer = new Timer();

        void Animate(bool enabled)
        {
            if (enabled)
            {
                timer.Tick += new EventHandler(timer_Tick);
                timer.Interval = 10;
                timer.Enabled = true;
                timer.Start();
            }
            else
            {
                timer.Tick -= new EventHandler(timer_Tick);
                timer.Stop();
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            gridControl1.BeginUpdate(BeginUpdateOptions.Invalidate);
            for (int rowIndex = 24; rowIndex < 36; rowIndex += 2)
            {
                GridStyleInfo style = gridControl1[rowIndex, 2];
                GridProgressBarInfo progressBarEx = style.ProgressBar;
                int pvalue = (progressBarEx.ProgressValue + rowIndex) % 100;
                progressBarEx.ProgressValue = pvalue;
            }

            GridStyleInfo stylev = gridControl1[26, 8];
            GridProgressBarInfo progressBarExv = stylev.ProgressBar;
            int pvaluev = (progressBarExv.ProgressValue + 3) % 100;
            progressBarExv.ProgressValue = pvaluev;

            gridControl1.EndUpdate(true);
            Application.DoEvents();
        }

        #endregion

        #region "Designer Stuffs"

        //Get image from bitmap file.
        private Bitmap GetBitmap(string bitmapName)
        {
            Bitmap bitmap = null;

            try
            {
                Assembly ass = typeof(Form1).Assembly;
                string name = ass.GetName().Name;
                Stream stream = ass.GetManifestResourceStream(name + ".Resources." + bitmapName);
                bitmap = new Bitmap(stream);
            }
            catch (Exception ex)
            {
                TraceUtil.TraceExceptionCatched(ex);
            }

            return bitmap;
        }
		
		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}


        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense(Syncfusion.Licensing.DemoCommon.FindLicenseKey());
			Application.EnableVisualStyles();
            Application.Run(new Form1());
        }
      

        #region Windows Form Designer generated code
        /// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo4 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo5 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo6 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            this.gridControl1 = new Syncfusion.Windows.Forms.Grid.GridControl();
            this.components = new Container();
            this.propertyGrid1 = new System.Windows.Forms.PropertyGrid();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBoxAdv1 = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxAdv1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DpiAware = true;
            this.gridControl1.AlphaBlendSelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(94)))), ((int)(((byte)(171)))), ((int)(((byte)(222)))));
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gridControl1.ColCount = 9;
            this.gridControl1.DefaultGridBorderStyle = Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid;
             this.gridControl1.Font = new System.Drawing.Font("Segoe UI", 9F);
            gridCellInfo4.Col = -1;
            gridCellInfo4.Row = -1;
            gridCellInfo4.StyleInfo.Font.Bold = false;
            gridCellInfo4.StyleInfo.Font.Facename = "Segoe UI";
            gridCellInfo4.StyleInfo.Font.Italic = false;
            gridCellInfo4.StyleInfo.Font.Size = 8.25F;
            gridCellInfo4.StyleInfo.Font.Strikeout = false;
            gridCellInfo4.StyleInfo.Font.Underline = false;
            gridCellInfo4.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point;
            gridCellInfo5.Col = -1;
            gridCellInfo5.Row = -1;
            gridCellInfo5.StyleInfo.Font.Bold = false;
            gridCellInfo5.StyleInfo.Font.Facename = "Segoe UI";
            gridCellInfo5.StyleInfo.Font.Italic = false;
            gridCellInfo5.StyleInfo.Font.Size = 8.25F;
            gridCellInfo5.StyleInfo.Font.Strikeout = false;
            gridCellInfo5.StyleInfo.Font.Underline = false;
            gridCellInfo5.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point;
            gridCellInfo6.Col = -1;
            gridCellInfo6.Row = -1;
            gridCellInfo6.StyleInfo.Borders.Bottom = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234))))), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin);
            gridCellInfo6.StyleInfo.Borders.Right = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234))))), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin);
            gridCellInfo6.StyleInfo.Font.Facename = "Segoe UI";
            gridCellInfo6.StyleInfo.Interior = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.White);
            gridCellInfo6.StyleInfo.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gridControl1.GridCells.AddRange(new Syncfusion.Windows.Forms.Grid.GridCellInfo[] {
            gridCellInfo4,
            gridCellInfo5,
            gridCellInfo6});
            //this.gridControl1.GridOfficeScrollBars = Syncfusion.Windows.Forms.OfficeScrollBars.Metro;
            //this.gridControl1.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro;
            this.gridControl1.DefaultRowHeight = (int)DpiAware.LogicalToDeviceUnits(20.0f);
            this.gridControl1.DefaultColWidth = (int)DpiAware.LogicalToDeviceUnits(70.0f);
            this.gridControl1.HorizontalThumbTrack = true;
            this.gridControl1.Location = new System.Drawing.Point(12, 12);
            //this.gridControl1.MetroScrollBars = true;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Properties.ForceImmediateRepaint = false;
            this.gridControl1.Properties.GridLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.gridControl1.Properties.MarkColHeader = false;
            this.gridControl1.Properties.MarkRowHeader = false;
            this.gridControl1.RowCount = 45;
            this.gridControl1.RowHeightEntries.AddRange(new Syncfusion.Windows.Forms.Grid.GridRowHeight[] {
            new Syncfusion.Windows.Forms.Grid.GridRowHeight(0, 29)});
            this.gridControl1.Size = new System.Drawing.Size(640, 504);
            this.gridControl1.SmartSizeBox = false;
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ThemesEnabled = true;
            this.gridControl1.VerticalThumbTrack = true;
            this.gridControl1.SelectionChanged += new Syncfusion.Windows.Forms.Grid.GridSelectionChangedEventHandler(this.gridControl1_SelectionChanged);
            this.gridControl1.CurrentCellMoved += new Syncfusion.Windows.Forms.Grid.GridCurrentCellMovedEventHandler(this.gridControl1_CurrentCellMoved);
            // 
            // propertyGrid1
            // 
            this.propertyGrid1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.propertyGrid1.BackColor = System.Drawing.Color.White;
            this.propertyGrid1.CommandsBackColor = System.Drawing.Color.White;
            this.propertyGrid1.CommandsLinkColor = System.Drawing.Color.White;
            this.propertyGrid1.HelpBackColor = System.Drawing.Color.White;
            this.propertyGrid1.LineColor = System.Drawing.SystemColors.Window;
            this.propertyGrid1.Location = new System.Drawing.Point(672, 137);
            this.propertyGrid1.Name = "propertyGrid1";
            this.propertyGrid1.Size = new System.Drawing.Size(223, 379);
            this.propertyGrid1.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.checkBoxAdv1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(672, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(223, 114);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "BrowseOnly";
            // 
            // checkBoxAdv1
            // 
            this.checkBoxAdv1.BeforeTouchSize = new System.Drawing.Size(150, 21);
            this.checkBoxAdv1.DrawFocusRectangle = false;
            this.checkBoxAdv1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxAdv1.Location = new System.Drawing.Point(51, 70);
            this.checkBoxAdv1.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.checkBoxAdv1.Name = "checkBoxAdv1";
            this.checkBoxAdv1.Size = new System.Drawing.Size(106, 29);
            this.checkBoxAdv1.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.checkBoxAdv1.TabIndex = 4;
            this.checkBoxAdv1.Text = "Browse only";
            this.checkBoxAdv1.ThemesEnabled = false;
            this.checkBoxAdv1.CheckStateChanged += new System.EventHandler(this.checkBoxAdv1_CheckStateChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 33);
            this.label1.TabIndex = 3;
            this.label1.Text = "Click the CheckBox to enable the GridControl as read mode(un editable)";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 525);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.propertyGrid1);
            this.Controls.Add(this.gridControl1);
            this.MinimumSize = new System.Drawing.Size(500, 400);
            this.Name = "Form1";
            this.Text = "Editor Cell";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxAdv1)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

        #endregion

        #region "PropertyGrid Handlers"
        private GridRangeInfo range = GridRangeInfo.Empty;
        private GridStyleInfo style = null;
        private GridControlBase grid = null;
        bool refreshPropertyGridNextIdle = false;
        Timer refreshTimer = null;

        private void DelayRefreshPropertyGrid(GridRangeInfo range, int interval)
        {
            if (refreshTimer != null)
            {
                refreshPropertyGridNextIdle = false;
                refreshTimer.Stop();
            }
            else
            {
                refreshTimer = new Timer();
                refreshTimer.Interval = interval;
                refreshTimer.Tick += new EventHandler(DelayedRefreshPropertyGrid);
            }
            refreshTimer.Start();
            refreshPropertyGridNextIdle = true;
            this.range = range;
        }

        void DelayedRefreshPropertyGrid(object sender, EventArgs e)
        {
            TraceUtil.TraceCurrentMethodInfo();
            Timer t = sender as Timer;
            t.Dispose();
            this.refreshTimer = null;

            if (refreshPropertyGridNextIdle)
                RefreshPropertyGrid();
        }

        public void RefreshPropertyGrid()
        {
            {
                refreshPropertyGridNextIdle = false;
                if (style != null)
                {
                    style.Changed -= new StyleChangedEventHandler(GridStyleInfoChanged);
                }

                grid = this.gridControl1;
                style = grid.Model.GetCombinedStyle(range);
                if (style != null)
                {
                    propertyGrid1.SelectedObject = style;
                    style.Changed += new StyleChangedEventHandler(GridStyleInfoChanged);
                }
                else
                    range = GridRangeInfo.Empty;
            }
        }

        public void ShowPropertyGridItem(string category, string label)
        {
            RefreshPropertyGrid();
            GridItem gi = propertyGrid1.SelectedGridItem;
            while (gi != null && gi.GridItemType != GridItemType.Root)
                gi = gi.Parent;

            if (gi != null)
            {
                // Categories
                GridItemCollection categories = gi.GridItems;
                GridItem sliderCategory = categories[category];
                if (sliderCategory != null)
                {
                    GridItemCollection items = sliderCategory.GridItems;
                    GridItem item;
                    if (label == "")
                        item = items[Math.Min(10, items.Count - 1)];
                    else
                        item = items[label];
                    item.Select();
                    if (item.Expandable)
                    {
                        propertyGrid1.ExpandAllGridItems();
                        items = item.GridItems;
                        items[Math.Min(10, items.Count - 1)].Select();
                    }
                }
            }
            RefreshPropertyGrid();
        }
        void GridStyleInfoChanged(object sender, StyleChangedEventArgs e)
        {
            if (!refreshPropertyGridNextIdle && !range.IsEmpty && grid != null && style != null)
            {
                grid.Model.ChangeCells(range, style, StyleModifyType.Changes);
            }
        }
        private void gridControl1_CurrentCellMoved(object sender, GridCurrentCellMovedEventArgs e)
        {
            grid = (GridControlBase)sender;
            DelayRefreshPropertyGrid(GridRangeInfo.Cell(grid.CurrentCell.RowIndex, grid.CurrentCell.ColIndex), 50);
        }

        private void gridControl1_SelectionChanged(object sender, GridSelectionChangedEventArgs e)
        {
            DelayRefreshPropertyGrid(e.Range, 200);
        }
        #endregion
    }


}

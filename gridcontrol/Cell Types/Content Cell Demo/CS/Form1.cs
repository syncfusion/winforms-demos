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

namespace ContentCellDemo
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
    using DemoCommon.Grid;

    public class Form1 : GridDemoForm
    {
        #region "API Definitions"

        private GridControl gridControl1;

        #endregion

        #region "Constructor"
        /// <summary>
        /// Form constructor
        /// </summary>
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
            this.GridSettings();
            InitializeGrid();
        }

        #endregion

        #region "GridSettings"
        /// <summary>
        /// Grid Settings for better look and feel
        /// </summary>
        private void GridSettings()
        {
            //Used to set the Column Header Height
            this.gridControl1.Model.RowHeights[0] = (int)DpiAware.LogicalToDeviceUnits(29);
            this.gridControl1.Model.ColWidths[0] = (int)DpiAware.LogicalToDeviceUnits(35);
            //Used to set selection mode in grid

            this.gridControl1.Model.Options.DisplayEmptyColumns = true;
            this.gridControl1.Model.Options.DisplayEmptyRows = true;
        }
        #endregion

        #region "Initializing grid"

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

            Icon icon = new Icon(GetType().Module.Assembly.GetManifestResourceStream("ContentCellDemo.gridform.ico"));
            imageList.Images.Add(icon.ToBitmap());

            icon = new Icon(GetType().Module.Assembly.GetManifestResourceStream("ContentCellDemo.toolsform.ico"));
            imageList.Images.Add(icon.ToBitmap());

            //imageList.Images.Add(Image.FromFile(@"..\..\Resources\Car1.jpg"));
            //imageList.Images.Add(Image.FromFile(@"..\..\Resources\car2.jpg"));
            //imageList.Images.Add(Image.FromFile(@"..\..\Resources\camera.ico"));
            #endregion

            #region Codes to apply celltypes in Grid
            this.gridControl1.BeginUpdate();

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

            gridControl1.Model.ColWidths[4] = 90;
            gridControl1.Model.ColWidths[6] = 100;
            if (DpiAware.GetCurrentDpi() > 96)
            {
                gridControl1.Model.ColWidths[4] = (int)DpiAware.LogicalToDeviceUnits(90.0f); ;
                gridControl1.Model.ColWidths[6] = (int)DpiAware.LogicalToDeviceUnits(100.0f); ;
            }
            #endregion

            #region Static Cells
            gridControl1.CoveredRanges.Add(GridRangeInfo.Cells(1, 1, 2, gridControl1.ColCount));
            gridControl1[1, 1] = headerstyle;
            gridControl1[1, 1].Text = "Static Cells";

            int rowIndex = 3, colIndex = 4;
            gridControl1.CoveredRanges.Add(GridRangeInfo.Cells(rowIndex, 1, rowIndex, gridControl1.ColCount));
            gridControl1[rowIndex, 1] = subheaderstyle;
            gridControl1[rowIndex, 1].Text = "Static Cells - cannot be edited which represented as a read-only cell";
            rowIndex++;
            gridControl1[rowIndex, colIndex].Text = "Static cell";
            gridControl1[rowIndex, colIndex].CellType = GridCellTypeName.Static;
            gridControl1[rowIndex, colIndex + 2].Text = "Static cell";
            gridControl1[rowIndex, colIndex + 2].CellType = GridCellTypeName.Static;
            gridControl1[rowIndex, colIndex + 2].ImageIndex = 8;
            #endregion

            #region ImageCells with PictureBox
            rowIndex = 7;
            gridControl1.CoveredRanges.Add(GridRangeInfo.Cells(rowIndex, 1, rowIndex + 1, gridControl1.ColCount));
            gridControl1[rowIndex, 1] = headerstyle;
            gridControl1[rowIndex, 1].Text = "Image Cells";

            rowIndex = 10;
            gridControl1[rowIndex, colIndex].CellType = GridCellTypeName.Image;
            gridControl1[rowIndex, colIndex].ImageList = imageList;
            gridControl1[rowIndex, colIndex].ImageIndex = 2;

            gridControl1[rowIndex, colIndex + 1].CellType = GridCellTypeName.Image;
            gridControl1[rowIndex, colIndex + 1].ImageList = imageList;
            gridControl1[rowIndex, colIndex + 1].ImageIndex = 4;

            //gridControl1[rowIndex, colIndex + 2].CellType = GridCellTypeName.Image;
            //gridControl1[rowIndex, colIndex + 2].ImageList = imageList;
            //gridControl1[rowIndex, colIndex + 2].ImageIndex = 8;

            rowIndex++;
            rowIndex++;
            gridControl1[rowIndex, colIndex].CellType = GridCellTypeName.Image;
            gridControl1[rowIndex, colIndex].ImageList = imageList;
            gridControl1[rowIndex, colIndex].ImageIndex = 5;

            gridControl1[rowIndex, colIndex + 1].CellType = GridCellTypeName.Image;
            gridControl1[rowIndex, colIndex + 1].ImageList = imageList;
            gridControl1[rowIndex, colIndex + 1].ImageIndex = 7;

            //gridControl1[rowIndex, colIndex + 2].CellType = GridCellTypeName.Image;
            //gridControl1[rowIndex, colIndex + 2].ImageList = imageList;
            //gridControl1[rowIndex, colIndex + 2].ImageIndex = 10;
            #region ApplyImages
            //            GridStyleInfo style;
            //            style = gridControl1[9, 2];
            //            style.CellType = "PictureBox";
            //#if HELPERCLASS
            //            sp = new Syncfusion.GridHelperClasses.PictureBoxStyleProperties(style);
            //#else
            //            sp = new PictureBoxStyleProperties(style);
            //#endif
            //            sp.Image = Image.FromFile(@"..\..\Resources\Car1.jpg");
            //            sp.SizeMode = PictureBoxSizeMode.StretchImage;

            //            style = gridControl1[9, 6];
            //            style.CellType = "PictureBox";


            //#if HELPERCLASS
            //            sp = new Syncfusion.GridHelperClasses.PictureBoxStyleProperties(style);
            //#else
            //            sp = new PictureBoxStyleProperties(style);
            //#endif
            //            sp.Image = Image.FromFile(@"..\..\Resources\car2.jpg");
            //            sp.SizeMode = PictureBoxSizeMode.StretchImage;

            #endregion

            #endregion

            #region HeaderCells
            rowIndex = 14;
            gridControl1.CoveredRanges.Add(GridRangeInfo.Cells(rowIndex, 1, 15, gridControl1.ColCount));
            gridControl1[rowIndex, 1] = headerstyle;
            gridControl1[rowIndex, 1].Text = "Header Cells";

            rowIndex = 16;
            gridControl1.CoveredRanges.Add(GridRangeInfo.Cells(rowIndex, 1, rowIndex, gridControl1.ColCount));
            gridControl1[rowIndex, 1] = subheaderstyle;
            gridControl1[rowIndex, 1].Text = "Header Cells - Used as Column Header and RowHeader cells";
            rowIndex++;
            rowIndex++;
            gridControl1[rowIndex, colIndex].Text = "Header Text";
            gridControl1[rowIndex, colIndex].CellType = GridCellTypeName.Header;
            gridControl1[rowIndex, colIndex + 2].Text = "Header Text";
            gridControl1[rowIndex, colIndex + 2].CellType = GridCellTypeName.Header;
            #endregion

            #region ProgressBar Cells

            rowIndex = 21;
            gridControl1.CoveredRanges.Add(GridRangeInfo.Cells(rowIndex, 1, rowIndex + 1, gridControl1.ColCount));
            gridControl1[rowIndex, 1] = subheaderstyle;
            gridControl1[rowIndex, 1].Font.Size = 10;
            gridControl1[rowIndex, 1].CellType = GridCellTypeName.CheckBox;
            gridControl1[rowIndex, 1].Description = "ProgressBar Cells";


            rowIndex = 24;
            GridStyleInfo style1 = gridControl1[rowIndex, 2];
            GridProgressBarInfo progressBarEx1 = style1.ProgressBar;
            style1.CellType = "ProgressBar";
            style1.Themed = false;
            style1.BackColor = System.Drawing.SystemColors.Control;
            style1.CellAppearance = GridCellAppearance.Raised;

            progressBarEx1.BackGradientEndColor = System.Drawing.SystemColors.ControlLightLight;
            progressBarEx1.BackGradientStartColor = System.Drawing.SystemColors.ControlDark;
            progressBarEx1.BackgroundStyle = Syncfusion.Windows.Forms.Tools.ProgressBarBackgroundStyles.VerticalGradient;
            progressBarEx1.BackMultipleColors = new System.Drawing.Color[] {
																				System.Drawing.SystemColors.ControlDark,
																				System.Drawing.SystemColors.ControlLightLight,
																				System.Drawing.SystemColors.Control};
            progressBarEx1.BackSegments = false;
            progressBarEx1.BackTubeEndColor = System.Drawing.SystemColors.ControlLightLight;
            progressBarEx1.BackTubeStartColor = System.Drawing.SystemColors.ControlDark;
            //progressBarEx1.Border3DStyle = System.Windows.Forms.Border3DStyle.RaisedOuter;
            //progressBarEx1.BorderColor = System.Drawing.Color.Black;
            progressBarEx1.FontColor = System.Drawing.SystemColors.HighlightText;
            progressBarEx1.ForeColor = System.Drawing.Color.MediumBlue;
            progressBarEx1.ForegroundImage = null;
            progressBarEx1.GradientEndColor = System.Drawing.Color.Lime;
            progressBarEx1.GradientStartColor = System.Drawing.Color.Red;
            progressBarEx1.MultipleColors = new System.Drawing.Color[] {
																			System.Drawing.Color.DarkRed,
																			System.Drawing.Color.Red,
																			System.Drawing.Color.Black};
            progressBarEx1.ProgressStyle = Syncfusion.Windows.Forms.Tools.ProgressBarStyles.Tube;
            progressBarEx1.SegmentWidth = 20;
            progressBarEx1.StretchImage = false;
            progressBarEx1.StretchMultGrad = false;
            progressBarEx1.TextShadow = false;
            progressBarEx1.TubeEndColor = System.Drawing.SystemColors.Control;
            progressBarEx1.TubeStartColor = System.Drawing.SystemColors.ControlDark;
            progressBarEx1.ProgressValue = 79;

            gridControl1.RowHeights[rowIndex] = 23;
            gridControl1.CoveredRanges.Add(GridRangeInfo.Cells(rowIndex, 2, rowIndex, 6));


            int rowIndex1 = rowIndex;
            int colIndex1 = 2;
            gridControl1.ColWidths[8] = 23;


            // Vertical
            rowIndex += 2;

            GridStyleInfo stylev3 = gridControl1[rowIndex, 8];
            GridProgressBarInfo progressBarExv3 = stylev3.ProgressBar;
            stylev3.CellType = "ProgressBar";
            stylev3.Themed = false;

            progressBarExv3.ProgressOrientation = Orientation.Vertical;
            progressBarExv3.BackGradientEndColor = System.Drawing.Color.White;
            progressBarExv3.BackGradientStartColor = System.Drawing.Color.LightGray;
            progressBarExv3.BackgroundStyle = Syncfusion.Windows.Forms.Tools.ProgressBarBackgroundStyles.System;
            progressBarExv3.BackSegments = false;
            progressBarExv3.BackTubeEndColor = System.Drawing.Color.White;
            progressBarExv3.BackTubeStartColor = System.Drawing.Color.LightGray;
            progressBarExv3.FontColor = System.Drawing.Color.White;
            progressBarExv3.ForegroundImage = null;
            progressBarExv3.GradientEndColor = System.Drawing.Color.Lime;
            progressBarExv3.GradientStartColor = System.Drawing.Color.Red;
            progressBarExv3.MultipleColors = new System.Drawing.Color[0];
            progressBarExv3.ProgressStyle = Syncfusion.Windows.Forms.Tools.ProgressBarStyles.System;
            progressBarExv3.SegmentWidth = 12;
            progressBarExv3.TubeEndColor = System.Drawing.Color.Black;
            progressBarExv3.TubeStartColor = System.Drawing.Color.Red;
            progressBarExv3.ProgressValue = 75;

            gridControl1.RowHeights[rowIndex] = 23;
            gridControl1.CoveredRanges.Add(GridRangeInfo.Cells(rowIndex, 8, rowIndex + 8, 8));




            // Horizontal
            GridStyleInfo style3 = gridControl1[rowIndex, colIndex1];
            GridProgressBarInfo progressBarEx3 = style3.ProgressBar;
            style3.CellType = "ProgressBar";
            style3.Themed = false;

            progressBarEx3.BackGradientEndColor = System.Drawing.Color.RosyBrown;
            progressBarEx3.BackGradientStartColor = System.Drawing.Color.DarkRed;
            progressBarEx3.BackgroundStyle = Syncfusion.Windows.Forms.Tools.ProgressBarBackgroundStyles.VerticalGradient;
            progressBarEx3.BackMultipleColors = new System.Drawing.Color[0];
            progressBarEx3.BackSegments = false;
            progressBarEx3.BackTubeEndColor = System.Drawing.SystemColors.Control;
            progressBarEx3.BackTubeStartColor = System.Drawing.Color.LightGray;
            progressBarEx3.FontColor = System.Drawing.Color.Lime;
            progressBarEx3.ForegroundImage = null;
            progressBarEx3.GradientEndColor = System.Drawing.Color.Lime;
            progressBarEx3.GradientStartColor = System.Drawing.Color.Red;
            progressBarEx3.MultipleColors = new System.Drawing.Color[] {
																			System.Drawing.SystemColors.ControlDarkDark,
																			System.Drawing.SystemColors.ControlLight,
																			System.Drawing.SystemColors.ControlDark,
																			System.Drawing.SystemColors.Control};
            progressBarEx3.ProgressStyle = Syncfusion.Windows.Forms.Tools.ProgressBarStyles.Tube;
            progressBarEx3.TextVisible = false;
            progressBarEx3.TubeEndColor = System.Drawing.Color.Black;
            progressBarEx3.TubeStartColor = System.Drawing.Color.Red;
            progressBarEx3.ProgressValue = 75;

            gridControl1.RowHeights[rowIndex] = 23;
            gridControl1.CoveredRanges.Add(GridRangeInfo.Cells(rowIndex, 2, rowIndex, 6));



            // Horizontal
            rowIndex += 2;

            GridStyleInfo style4 = gridControl1[rowIndex, colIndex1];
            GridProgressBarInfo progressBarEx4 = style4.ProgressBar;
            style4.CellType = "ProgressBar";
            style4.Themed = false;

            // 
            // progressBarEx4
            // 
            progressBarEx4.BackGradientEndColor = System.Drawing.Color.White;
            progressBarEx4.BackGradientStartColor = System.Drawing.Color.LightGray;
            progressBarEx4.ForegroundImage = GetBitmap("Coffee Bean.bmp");
            progressBarEx4.BackgroundStyle = Syncfusion.Windows.Forms.Tools.ProgressBarBackgroundStyles.Image;
            progressBarEx4.BackMultipleColors = new System.Drawing.Color[0];
            progressBarEx4.BackSegments = false;
            progressBarEx4.BackTubeEndColor = System.Drawing.Color.White;
            progressBarEx4.BackTubeStartColor = System.Drawing.Color.LightGray;
            progressBarEx4.FontColor = System.Drawing.SystemColors.Control;
            progressBarEx4.BackgroundImage = GetBitmap("Soap-Bubbles.jpg"); ;
            progressBarEx4.GradientEndColor = System.Drawing.Color.Lime;
            progressBarEx4.GradientStartColor = System.Drawing.Color.Red;
            progressBarEx4.MultipleColors = new System.Drawing.Color[0];
            progressBarEx4.ProgressStyle = Syncfusion.Windows.Forms.Tools.ProgressBarStyles.Image;
            progressBarEx4.SegmentWidth = 12;
            progressBarEx4.StretchImage = false;
            progressBarEx4.TubeEndColor = System.Drawing.Color.Black;
            progressBarEx4.TubeStartColor = System.Drawing.Color.Red;
            progressBarEx4.ProgressValue = 75;

            gridControl1.RowHeights[rowIndex] = 23;
            gridControl1.CoveredRanges.Add(GridRangeInfo.Cells(rowIndex, 2, rowIndex, 6));


            // Horizontal
            rowIndex += 2;

            GridStyleInfo style7 = gridControl1[rowIndex, colIndex1];
            GridProgressBarInfo progressBarEx7 = style7.ProgressBar;
            style7.CellType = "ProgressBar";
            style7.Themed = false;

            // 
            // progressBarEx7
            // 
            progressBarEx7.BackGradientEndColor = System.Drawing.SystemColors.ControlLightLight;
            progressBarEx7.BackGradientStartColor = System.Drawing.SystemColors.ControlDark;
            progressBarEx7.BackgroundStyle = Syncfusion.Windows.Forms.Tools.ProgressBarBackgroundStyles.VerticalGradient;
            progressBarEx7.BackMultipleColors = new System.Drawing.Color[0];
            progressBarEx7.BackSegments = false;
            progressBarEx7.BackTubeEndColor = System.Drawing.Color.Silver;
            progressBarEx7.BackTubeStartColor = System.Drawing.Color.White;
            progressBarEx7.FontColor = System.Drawing.Color.White;
            progressBarEx7.ForegroundImage = null;
            progressBarEx7.GradientEndColor = System.Drawing.Color.Lime;
            progressBarEx7.GradientStartColor = System.Drawing.Color.Red;
            progressBarEx7.MultipleColors = new System.Drawing.Color[] {
																			System.Drawing.SystemColors.ControlDarkDark,
																			System.Drawing.SystemColors.ControlLightLight,
																			System.Drawing.SystemColors.ActiveCaption};
            progressBarEx7.ProgressStyle = Syncfusion.Windows.Forms.Tools.ProgressBarStyles.Tube;
            progressBarEx7.SegmentWidth = 8;
            progressBarEx7.StretchImage = false;
            progressBarEx7.TextVisible = false;
            progressBarEx7.TubeEndColor = System.Drawing.Color.Honeydew;
            progressBarEx7.TubeStartColor = System.Drawing.Color.Green;
            progressBarEx7.ProgressValue = 75;

            gridControl1.RowHeights[rowIndex] = 23;
            gridControl1.CoveredRanges.Add(GridRangeInfo.Cells(rowIndex, 2, rowIndex, 6));



            // Horizontal
            rowIndex += 2;

            GridStyleInfo style9 = gridControl1[rowIndex, colIndex1];
            GridProgressBarInfo progressBarEx9 = style9.ProgressBar;
            style9.CellType = "ProgressBar";
            style9.Themed = false;

            // 
            // progressBarEx9
            // 
            progressBarEx9.BackGradientEndColor = System.Drawing.Color.White;
            progressBarEx9.BackGradientStartColor = System.Drawing.Color.LightGray;
            progressBarEx9.BackgroundStyle = Syncfusion.Windows.Forms.Tools.ProgressBarBackgroundStyles.Tube;
            progressBarEx9.BackMultipleColors = new System.Drawing.Color[0];
            progressBarEx9.BackSegments = false;
            progressBarEx9.BackTubeEndColor = System.Drawing.Color.White;
            progressBarEx9.BackTubeStartColor = System.Drawing.Color.LightGray;
            progressBarEx9.ForegroundImage = null;
            progressBarEx9.GradientEndColor = System.Drawing.Color.Yellow;
            progressBarEx9.GradientStartColor = System.Drawing.Color.Red;
            progressBarEx9.MultipleColors = new System.Drawing.Color[0];
            progressBarEx9.ProgressStyle = Syncfusion.Windows.Forms.Tools.ProgressBarStyles.Gradient;
            progressBarEx9.SegmentWidth = 12;
            progressBarEx9.TubeEndColor = System.Drawing.Color.Black;
            progressBarEx9.TubeStartColor = System.Drawing.Color.Red;
            progressBarEx9.ProgressValue = 75;

            gridControl1.RowHeights[rowIndex] = 23;
            gridControl1.CoveredRanges.Add(GridRangeInfo.Cells(rowIndex, 2, rowIndex, 6));


            // Horizontal
            rowIndex += 2;

            GridStyleInfo style14 = gridControl1[rowIndex, colIndex1];
            GridProgressBarInfo progressBarEx14 = style14.ProgressBar;
            style14.CellType = "ProgressBar";
            style14.Themed = true;

            // 
            // progressBarEx14
            // 
            progressBarEx14.BackGradientEndColor = System.Drawing.Color.White;
            progressBarEx14.BackGradientStartColor = System.Drawing.Color.LightGray;
            progressBarEx14.BackgroundStyle = Syncfusion.Windows.Forms.Tools.ProgressBarBackgroundStyles.System;
            progressBarEx14.BackSegments = false;
            progressBarEx14.BackTubeEndColor = System.Drawing.Color.White;
            progressBarEx14.BackTubeStartColor = System.Drawing.Color.LightGray;
            progressBarEx14.FontColor = System.Drawing.Color.White;
            progressBarEx14.ForegroundImage = null;
            progressBarEx14.GradientEndColor = System.Drawing.Color.FromArgb(255, 187, 111);
            progressBarEx14.GradientStartColor = System.Drawing.Color.FromArgb(0, 21, 84);
            progressBarEx14.MultipleColors = new System.Drawing.Color[0];
            progressBarEx14.ProgressStyle = Syncfusion.Windows.Forms.Tools.ProgressBarStyles.WaitingGradient;
            progressBarEx14.SegmentWidth = 12;
            progressBarEx14.TubeEndColor = System.Drawing.Color.Black;
            progressBarEx14.TubeStartColor = System.Drawing.Color.Red;
            progressBarEx14.ProgressValue = 75;

            gridControl1.RowHeights[rowIndex] = 23;
            gridControl1.CoveredRanges.Add(GridRangeInfo.Cells(rowIndex, 2, rowIndex, 6));

            rowIndex += 2;
            GridStyleInfo styleCheckBox = gridControl1[rowIndex, colIndex1];
            styleCheckBox.CellType = "CheckBox";
            styleCheckBox.Description = "Animate";
            styleCheckBox.Themed = true;
            styleCheckBox.CellValue = "False";
            styleCheckBox.CheckBoxOptions.UncheckedValue = "False";
            styleCheckBox.CheckBoxOptions.CheckedValue = "True";
            styleCheckBox.FloatCell = true;
            //gridControl1.CurrentCellChanged += new EventHandler(gridControl1_CurrentCellChanged);
            gridControl1.CheckBoxClick += new GridCellClickEventHandler(gridControl1_CheckBoxClick);
            for (int i = 23; i <= 36; i++)
            {
                gridControl1.HideRows[i] = true;
            }
            #endregion

            this.gridControl1.EndUpdate(true);

            #endregion
        }

        #endregion

        #region "Helper Methods"

        //Hiding rows by using CheckBoxClick       
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

        #region ""Form handlers"

        #region "Get image"
        //Gets the bit map image
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
        #endregion

        #region "Dispose"
        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        #endregion

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
            Application.Run(new Form1());
        }
        #endregion

        #region Windows Form Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Syncfusion.Windows.Forms.Grid.GridBaseStyle gridBaseStyle1 = new Syncfusion.Windows.Forms.Grid.GridBaseStyle();
            Syncfusion.Windows.Forms.Grid.GridBaseStyle gridBaseStyle2 = new Syncfusion.Windows.Forms.Grid.GridBaseStyle();
            Syncfusion.Windows.Forms.Grid.GridBaseStyle gridBaseStyle3 = new Syncfusion.Windows.Forms.Grid.GridBaseStyle();
            Syncfusion.Windows.Forms.Grid.GridBaseStyle gridBaseStyle4 = new Syncfusion.Windows.Forms.Grid.GridBaseStyle();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo1 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo2 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo3 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            this.gridControl1 = new Syncfusion.Windows.Forms.Grid.GridControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            //this.gridControl1.AlphaBlendSelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(94)))), ((int)(((byte)(171)))), ((int)(((byte)(222)))));
            //this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            //            | System.Windows.Forms.AnchorStyles.Left)
            //            | System.Windows.Forms.AnchorStyles.Right)));
            gridBaseStyle1.Name = "Header";
            gridBaseStyle1.StyleInfo.Borders.Bottom = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None);
            gridBaseStyle1.StyleInfo.Borders.Left = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None);
            gridBaseStyle1.StyleInfo.Borders.Right = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None);
            gridBaseStyle1.StyleInfo.Borders.Top = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None);
            gridBaseStyle1.StyleInfo.CellType = "Header";
            gridBaseStyle1.StyleInfo.Font.Bold = true;
            gridBaseStyle1.StyleInfo.Interior = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(199)))), ((int)(((byte)(184))))), System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(234)))), ((int)(((byte)(216))))));
            gridBaseStyle1.StyleInfo.VerticalAlignment = Syncfusion.Windows.Forms.Grid.GridVerticalAlignment.Middle;
            gridBaseStyle2.Name = "Standard";
            gridBaseStyle2.StyleInfo.Font.Facename = "Tahoma";
            gridBaseStyle2.StyleInfo.Interior = new Syncfusion.Drawing.BrushInfo(System.Drawing.SystemColors.Window);
            gridBaseStyle3.Name = "Column Header";
            gridBaseStyle3.StyleInfo.BaseStyle = "Header";
            gridBaseStyle3.StyleInfo.HorizontalAlignment = Syncfusion.Windows.Forms.Grid.GridHorizontalAlignment.Center;
            gridBaseStyle4.Name = "Row Header";
            gridBaseStyle4.StyleInfo.BaseStyle = "Header";
            gridBaseStyle4.StyleInfo.HorizontalAlignment = Syncfusion.Windows.Forms.Grid.GridHorizontalAlignment.Left;
            gridBaseStyle4.StyleInfo.Interior = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Horizontal, System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(199)))), ((int)(((byte)(184))))), System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(234)))), ((int)(((byte)(216))))));
            this.gridControl1.BaseStylesMap.AddRange(new Syncfusion.Windows.Forms.Grid.GridBaseStyle[] {
            gridBaseStyle1,
            gridBaseStyle2,
            gridBaseStyle3,
            gridBaseStyle4});
            this.gridControl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gridControl1.ColCount = 9;
            this.gridControl1.ColWidthEntries.AddRange(new Syncfusion.Windows.Forms.Grid.GridColWidth[] {
            new Syncfusion.Windows.Forms.Grid.GridColWidth(0, 35)});
            this.gridControl1.DefaultGridBorderStyle = Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid;
            this.gridControl1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gridControl1.ForeColor = System.Drawing.Color.MidnightBlue;
            gridCellInfo1.Col = -1;
            gridCellInfo1.Row = -1;
            gridCellInfo1.StyleInfo.Font.Bold = false;
            gridCellInfo1.StyleInfo.Font.Facename = "Segoe UI";
            gridCellInfo1.StyleInfo.Font.Italic = false;
            gridCellInfo1.StyleInfo.Font.Size = 9F;
            gridCellInfo1.StyleInfo.Font.Strikeout = false;
            gridCellInfo1.StyleInfo.Font.Underline = false;
            gridCellInfo1.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point;
            gridCellInfo2.Col = -1;
            gridCellInfo2.Row = -1;
            gridCellInfo2.StyleInfo.Font.Bold = false;
            gridCellInfo2.StyleInfo.Font.Facename = "Segoe UI";
            gridCellInfo2.StyleInfo.Font.Italic = false;
            gridCellInfo2.StyleInfo.Font.Size = 9F;
            gridCellInfo2.StyleInfo.Font.Strikeout = false;
            gridCellInfo2.StyleInfo.Font.Underline = false;
            gridCellInfo2.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point;
            gridCellInfo3.Col = -1;
            gridCellInfo3.Row = -1;
            gridCellInfo3.StyleInfo.Borders.Bottom = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234))))), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin);
            gridCellInfo3.StyleInfo.Borders.Right = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234))))), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin);
            gridCellInfo3.StyleInfo.Font.Bold = false;
            gridCellInfo3.StyleInfo.Font.Facename = "Segoe UI";
            gridCellInfo3.StyleInfo.Font.Italic = false;
            gridCellInfo3.StyleInfo.Font.Size = 9F;
            gridCellInfo3.StyleInfo.Font.Strikeout = false;
            gridCellInfo3.StyleInfo.Font.Underline = false;
            gridCellInfo3.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point;
            gridCellInfo3.StyleInfo.Interior = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.White);
            gridCellInfo3.StyleInfo.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gridControl1.GridCells.AddRange(new Syncfusion.Windows.Forms.Grid.GridCellInfo[] {
            gridCellInfo1,
            gridCellInfo2,
            gridCellInfo3});
            //this.gridControl1.GridOfficeScrollBars = Syncfusion.Windows.Forms.OfficeScrollBars.Metro;
            //this.gridControl1.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro;
            this.gridControl1.DefaultRowHeight = (int)DpiAware.LogicalToDeviceUnits(20.0f);
            this.gridControl1.DefaultColWidth = (int)DpiAware.LogicalToDeviceUnits(70.0f);
            this.gridControl1.HorizontalThumbTrack = true;
            this.gridControl1.Location = new System.Drawing.Point(12, 12);
            //this.gridControl1.MetroScrollBars = true;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Properties.BackgroundColor = System.Drawing.Color.White;
            this.gridControl1.Properties.FixedLinesColor = System.Drawing.Color.White;
            this.gridControl1.Properties.ForceImmediateRepaint = false;
            this.gridControl1.Properties.GridLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.gridControl1.Properties.MarkColHeader = false;
            this.gridControl1.Properties.MarkRowHeader = false;
            this.gridControl1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.gridControl1.RowCount = 42;
            this.gridControl1.RowHeightEntries.AddRange(new Syncfusion.Windows.Forms.Grid.GridRowHeight[] {
            new Syncfusion.Windows.Forms.Grid.GridRowHeight(0, 21)});
            this.gridControl1.SerializeCellsBehavior = Syncfusion.Windows.Forms.Grid.GridSerializeCellsBehavior.SerializeIntoCode;
            this.gridControl1.Size = new System.Drawing.Size(766, 519);
            this.gridControl1.SmartSizeBox = false;
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ThemesEnabled = true;
            this.gridControl1.DpiAware = true;
            this.gridControl1.VerticalThumbTrack = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 543);
            this.Controls.Add(this.gridControl1);
            this.MinimumSize = new System.Drawing.Size(600, 500);
            this.Name = "Form1";
            this.Text = "Content Cell ";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion

        #endregion

    }


}

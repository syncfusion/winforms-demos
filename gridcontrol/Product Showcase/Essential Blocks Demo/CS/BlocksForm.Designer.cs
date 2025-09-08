#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
namespace EssentialBlocks
{
    partial class BlocksForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Syncfusion.Windows.Forms.Grid.GridBaseStyle gridBaseStyle1 = new Syncfusion.Windows.Forms.Grid.GridBaseStyle();
            Syncfusion.Windows.Forms.Grid.GridBaseStyle gridBaseStyle2 = new Syncfusion.Windows.Forms.Grid.GridBaseStyle();
            Syncfusion.Windows.Forms.Grid.GridBaseStyle gridBaseStyle3 = new Syncfusion.Windows.Forms.Grid.GridBaseStyle();
            Syncfusion.Windows.Forms.Grid.GridBaseStyle gridBaseStyle4 = new Syncfusion.Windows.Forms.Grid.GridBaseStyle();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo1 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridBaseStyle gridBaseStyle5 = new Syncfusion.Windows.Forms.Grid.GridBaseStyle();
            Syncfusion.Windows.Forms.Grid.GridBaseStyle gridBaseStyle6 = new Syncfusion.Windows.Forms.Grid.GridBaseStyle();
            Syncfusion.Windows.Forms.Grid.GridBaseStyle gridBaseStyle7 = new Syncfusion.Windows.Forms.Grid.GridBaseStyle();
            Syncfusion.Windows.Forms.Grid.GridBaseStyle gridBaseStyle8 = new Syncfusion.Windows.Forms.Grid.GridBaseStyle();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo2 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BlocksForm));
            this._mainFrameBarManager = new Syncfusion.Windows.Forms.Tools.XPMenus.MainFrameBarManager(this);
            this.mainBar = new Syncfusion.Windows.Forms.Tools.XPMenus.Bar(this._mainFrameBarManager, "Main Menu");
            this.fileParentBarItem = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.newGameBarItem = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.showNextPieceItem = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.pauseBarItem = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.exitBarItem = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.helpParentBarItem = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.howToPlayBarItem = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.aboutBarItem = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.gridBoard = new Syncfusion.Windows.Forms.Grid.GridControl();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.gridControl1 = new Syncfusion.Windows.Forms.Grid.GridControl();
            this.statusBarAdv1 = new Syncfusion.Windows.Forms.Tools.StatusBarAdv();
            this.progressBarAdv1 = new Syncfusion.Windows.Forms.Tools.ProgressBarAdv();
            this.label1 = new System.Windows.Forms.Label();
            this.nextPiecePanel = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.progressBarWaiting = new Syncfusion.Windows.Forms.Tools.ProgressBarAdv();
            ((System.ComponentModel.ISupportInitialize)(this._mainFrameBarManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridBoard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarAdv1)).BeginInit();
            this.statusBarAdv1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.progressBarAdv1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nextPiecePanel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.progressBarWaiting)).BeginInit();
            this.SuspendLayout();
            // 
            // _mainFrameBarManager
            // 
            this._mainFrameBarManager.BarPositionInfo = ((System.IO.MemoryStream)(resources.GetObject("_mainFrameBarManager.BarPositionInfo")));
            this._mainFrameBarManager.Bars.Add(this.mainBar);
            this._mainFrameBarManager.Categories.Add("File");
            this._mainFrameBarManager.Categories.Add("Game Control");
            this._mainFrameBarManager.Categories.Add("Help");
            this._mainFrameBarManager.CurrentBaseFormType = "Syncfusion.Windows.Forms.Office2007Form";
            this._mainFrameBarManager.EnableMenuMerge = true;
            this._mainFrameBarManager.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._mainFrameBarManager.Form = this;
            this._mainFrameBarManager.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.fileParentBarItem,
            this.exitBarItem,
            this.newGameBarItem,
            this.pauseBarItem,
            this.helpParentBarItem,
            this.aboutBarItem,
            this.howToPlayBarItem,
            this.showNextPieceItem});
            this._mainFrameBarManager.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(201)))), ((int)(((byte)(232)))));
            this._mainFrameBarManager.Office2007Theme = Syncfusion.Windows.Forms.Office2007Theme.Black;
            this._mainFrameBarManager.ResetCustomization = false;
            this._mainFrameBarManager.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007Outlook;
            this._mainFrameBarManager.UseBackwardCompatiblity = false;
            // 
            // mainBar
            // 
            this.mainBar.BarName = "Main Menu";
            this.mainBar.BarStyle = ((Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle)(((Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.AllowQuickCustomizing | Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.IsMainMenu) 
            | Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.Visible)));
            this.mainBar.Caption = "Main Menu";
            this.mainBar.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.fileParentBarItem,
            this.helpParentBarItem});
            this.mainBar.Manager = this._mainFrameBarManager;
            // 
            // fileParentBarItem
            // 
            this.fileParentBarItem.BarName = "fileParentBarItem";
            this.fileParentBarItem.CategoryIndex = 0;
            this.fileParentBarItem.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileParentBarItem.ID = "&File";
            this.fileParentBarItem.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.newGameBarItem,
            this.showNextPieceItem,
            this.pauseBarItem,
            this.exitBarItem});
            this.fileParentBarItem.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(201)))), ((int)(((byte)(232)))));
            this.fileParentBarItem.SeparatorIndices.AddRange(new int[] {
            3});
            this.fileParentBarItem.ShowToolTipInPopUp = false;
            this.fileParentBarItem.SizeToFit = true;
            this.fileParentBarItem.Text = "&File";
            this.fileParentBarItem.WrapLength = 20;
            // 
            // newGameBarItem
            // 
            this.newGameBarItem.BarName = "newGameBarItem";
            this.newGameBarItem.CategoryIndex = 0;
            this.newGameBarItem.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newGameBarItem.ID = "&New Game";
            this.newGameBarItem.ShowToolTipInPopUp = false;
            this.newGameBarItem.SizeToFit = true;
            this.newGameBarItem.Text = "&New Game";
            this.newGameBarItem.Click += new System.EventHandler(this.newGameBarItem_Click);
            // 
            // showNextPieceItem
            // 
            this.showNextPieceItem.BarName = "showNextPieceItem";
            this.showNextPieceItem.CategoryIndex = 0;
            this.showNextPieceItem.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showNextPieceItem.ID = "Show Next Piece";
            this.showNextPieceItem.ShowToolTipInPopUp = false;
            this.showNextPieceItem.SizeToFit = true;
            this.showNextPieceItem.Text = "Show Next Piece";
            this.showNextPieceItem.Click += new System.EventHandler(this.showNextPieceItem_Click);
            // 
            // pauseBarItem
            // 
            this.pauseBarItem.BarName = "pauseBarItem";
            this.pauseBarItem.CategoryIndex = 1;
            this.pauseBarItem.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pauseBarItem.ID = "&Pause Game";
            this.pauseBarItem.ShowToolTipInPopUp = false;
            this.pauseBarItem.SizeToFit = true;
            this.pauseBarItem.Text = "&Pause Game";
            this.pauseBarItem.Click += new System.EventHandler(this.pauseBarItem_Click);
            // 
            // exitBarItem
            // 
            this.exitBarItem.BarName = "exitBarItem";
            this.exitBarItem.CategoryIndex = 0;
            this.exitBarItem.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBarItem.ID = "E&xit";
            this.exitBarItem.ShowToolTipInPopUp = false;
            this.exitBarItem.SizeToFit = true;
            this.exitBarItem.Text = "E&xit";
            this.exitBarItem.Click += new System.EventHandler(this.exitBarItem_Click);
            // 
            // helpParentBarItem
            // 
            this.helpParentBarItem.BarName = "helpParentBarItem";
            this.helpParentBarItem.CategoryIndex = 2;
            this.helpParentBarItem.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpParentBarItem.ID = "&Help";
            this.helpParentBarItem.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.howToPlayBarItem,
            this.aboutBarItem});
            this.helpParentBarItem.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(201)))), ((int)(((byte)(232)))));
            this.helpParentBarItem.ShowToolTipInPopUp = false;
            this.helpParentBarItem.SizeToFit = true;
            this.helpParentBarItem.Text = "&Help";
            this.helpParentBarItem.WrapLength = 20;
            // 
            // howToPlayBarItem
            // 
            this.howToPlayBarItem.BarName = "howToPlayBarItem";
            this.howToPlayBarItem.CategoryIndex = 2;
            this.howToPlayBarItem.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.howToPlayBarItem.ID = "How to &Play";
            this.howToPlayBarItem.Shortcut = System.Windows.Forms.Shortcut.F1;
            this.howToPlayBarItem.ShowToolTipInPopUp = false;
            this.howToPlayBarItem.SizeToFit = true;
            this.howToPlayBarItem.Text = "How to &Play";
            this.howToPlayBarItem.Click += new System.EventHandler(this.howToPlayBarItem_Click);
            // 
            // aboutBarItem
            // 
            this.aboutBarItem.BarName = "aboutBarItem";
            this.aboutBarItem.CategoryIndex = 2;
            this.aboutBarItem.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aboutBarItem.ID = "&About";
            this.aboutBarItem.ShowToolTipInPopUp = false;
            this.aboutBarItem.SizeToFit = true;
            this.aboutBarItem.Text = "&About";
            this.aboutBarItem.Click += new System.EventHandler(this.aboutBarItem_Click);
            // 
            // gridBoard
            // 
            gridBaseStyle1.Name = "Header";
            gridBaseStyle1.StyleInfo.Borders.Bottom = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None);
            gridBaseStyle1.StyleInfo.Borders.Left = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None);
            gridBaseStyle1.StyleInfo.Borders.Right = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None);
            gridBaseStyle1.StyleInfo.Borders.Top = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None);
            gridBaseStyle1.StyleInfo.CellType = "Static";
            gridBaseStyle1.StyleInfo.Font.Bold = true;
            gridBaseStyle1.StyleInfo.Interior = new Syncfusion.Drawing.BrushInfo(System.Drawing.SystemColors.Control);
            gridBaseStyle1.StyleInfo.VerticalAlignment = Syncfusion.Windows.Forms.Grid.GridVerticalAlignment.Middle;
            gridBaseStyle2.Name = "Standard";
            gridBaseStyle2.StyleInfo.Font.Facename = "Tahoma";
            gridBaseStyle2.StyleInfo.Interior = new Syncfusion.Drawing.BrushInfo(System.Drawing.SystemColors.Window);
            gridBaseStyle3.Name = "Column Header";
            gridBaseStyle3.StyleInfo.BaseStyle = "Header";
            gridBaseStyle3.StyleInfo.CellType = "Static";
            gridBaseStyle3.StyleInfo.HorizontalAlignment = Syncfusion.Windows.Forms.Grid.GridHorizontalAlignment.Center;
            gridBaseStyle3.StyleInfo.Interior = new Syncfusion.Drawing.BrushInfo(System.Drawing.SystemColors.Control);
            gridBaseStyle4.Name = "Row Header";
            gridBaseStyle4.StyleInfo.BaseStyle = "Header";
            gridBaseStyle4.StyleInfo.CellType = "Static";
            gridBaseStyle4.StyleInfo.HorizontalAlignment = Syncfusion.Windows.Forms.Grid.GridHorizontalAlignment.Left;
            gridBaseStyle4.StyleInfo.Interior = new Syncfusion.Drawing.BrushInfo(System.Drawing.SystemColors.Control);
            this.gridBoard.BaseStylesMap.AddRange(new Syncfusion.Windows.Forms.Grid.GridBaseStyle[] {
            gridBaseStyle1,
            gridBaseStyle2,
            gridBaseStyle3,
            gridBaseStyle4});
            this.gridBoard.ColCount = 8;
            this.gridBoard.ColWidthEntries.AddRange(new Syncfusion.Windows.Forms.Grid.GridColWidth[] {
            new Syncfusion.Windows.Forms.Grid.GridColWidth(0, 35),
            new Syncfusion.Windows.Forms.Grid.GridColWidth(1, 32),
            new Syncfusion.Windows.Forms.Grid.GridColWidth(2, 31),
            new Syncfusion.Windows.Forms.Grid.GridColWidth(3, 31),
            new Syncfusion.Windows.Forms.Grid.GridColWidth(4, 31),
            new Syncfusion.Windows.Forms.Grid.GridColWidth(5, 30),
            new Syncfusion.Windows.Forms.Grid.GridColWidth(6, 31),
            new Syncfusion.Windows.Forms.Grid.GridColWidth(7, 28),
            new Syncfusion.Windows.Forms.Grid.GridColWidth(8, 31)});
            this.gridBoard.DefaultGridBorderStyle = Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid;
            this.gridBoard.ForeColor = System.Drawing.SystemColors.ControlText;
            gridCellInfo1.Col = -1;
            gridCellInfo1.Row = -1;
            this.gridBoard.GridCells.AddRange(new Syncfusion.Windows.Forms.Grid.GridCellInfo[] {
            gridCellInfo1});
            this.gridBoard.Location = new System.Drawing.Point(15, 34);
            this.gridBoard.Name = "gridBoard";
            this.gridBoard.Properties.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gridBoard.Properties.ColHeaders = false;
            this.gridBoard.Properties.ForceImmediateRepaint = false;
            this.gridBoard.Properties.GridLineColor = System.Drawing.SystemColors.Control;
            this.gridBoard.Properties.MarkColHeader = false;
            this.gridBoard.Properties.MarkRowHeader = false;
            this.gridBoard.Properties.RowHeaders = false;
            this.gridBoard.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.gridBoard.RowCount = 20;
            this.gridBoard.RowHeightEntries.AddRange(new Syncfusion.Windows.Forms.Grid.GridRowHeight[] {
            new Syncfusion.Windows.Forms.Grid.GridRowHeight(0, 21),
            new Syncfusion.Windows.Forms.Grid.GridRowHeight(18, 19)});
            this.gridBoard.SerializeCellsBehavior = Syncfusion.Windows.Forms.Grid.GridSerializeCellsBehavior.SerializeIntoCode;
            this.gridBoard.Size = new System.Drawing.Size(282, 365);
            this.gridBoard.SmartSizeBox = false;
            this.gridBoard.TabIndex = 4;
            this.gridBoard.QueryCellInfo += new Syncfusion.Windows.Forms.Grid.GridQueryCellInfoEventHandler(this.gridBoard_QueryCellInfo);
            // 
            // gameTimer
            // 
            this.gameTimer.Interval = 500;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // gridControl1
            // 
            gridBaseStyle5.Name = "Header";
            gridBaseStyle5.StyleInfo.Borders.Bottom = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None);
            gridBaseStyle5.StyleInfo.Borders.Left = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None);
            gridBaseStyle5.StyleInfo.Borders.Right = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None);
            gridBaseStyle5.StyleInfo.Borders.Top = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None);
            gridBaseStyle5.StyleInfo.CellType = "Static";
            gridBaseStyle5.StyleInfo.Font.Bold = true;
            gridBaseStyle5.StyleInfo.Interior = new Syncfusion.Drawing.BrushInfo(System.Drawing.SystemColors.Control);
            gridBaseStyle5.StyleInfo.VerticalAlignment = Syncfusion.Windows.Forms.Grid.GridVerticalAlignment.Middle;
            gridBaseStyle6.Name = "Standard";
            gridBaseStyle6.StyleInfo.Font.Facename = "Tahoma";
            gridBaseStyle6.StyleInfo.Interior = new Syncfusion.Drawing.BrushInfo(System.Drawing.SystemColors.Window);
            gridBaseStyle7.Name = "Column Header";
            gridBaseStyle7.StyleInfo.BaseStyle = "Header";
            gridBaseStyle7.StyleInfo.CellType = "Static";
            gridBaseStyle7.StyleInfo.HorizontalAlignment = Syncfusion.Windows.Forms.Grid.GridHorizontalAlignment.Center;
            gridBaseStyle7.StyleInfo.Interior = new Syncfusion.Drawing.BrushInfo(System.Drawing.SystemColors.Control);
            gridBaseStyle8.Name = "Row Header";
            gridBaseStyle8.StyleInfo.BaseStyle = "Header";
            gridBaseStyle8.StyleInfo.CellType = "Static";
            gridBaseStyle8.StyleInfo.HorizontalAlignment = Syncfusion.Windows.Forms.Grid.GridHorizontalAlignment.Left;
            gridBaseStyle8.StyleInfo.Interior = new Syncfusion.Drawing.BrushInfo(System.Drawing.SystemColors.Control);
            this.gridControl1.BaseStylesMap.AddRange(new Syncfusion.Windows.Forms.Grid.GridBaseStyle[] {
            gridBaseStyle5,
            gridBaseStyle6,
            gridBaseStyle7,
            gridBaseStyle8});
            this.gridControl1.ColCount = 5;
            this.gridControl1.ColWidthEntries.AddRange(new Syncfusion.Windows.Forms.Grid.GridColWidth[] {
            new Syncfusion.Windows.Forms.Grid.GridColWidth(0, 35),
            new Syncfusion.Windows.Forms.Grid.GridColWidth(1, 31),
            new Syncfusion.Windows.Forms.Grid.GridColWidth(2, 28),
            new Syncfusion.Windows.Forms.Grid.GridColWidth(3, 28),
            new Syncfusion.Windows.Forms.Grid.GridColWidth(4, 28),
            new Syncfusion.Windows.Forms.Grid.GridColWidth(5, 28)});
            this.gridControl1.ForeColor = System.Drawing.SystemColors.ControlText;
            gridCellInfo2.Col = -1;
            gridCellInfo2.Row = -1;
            this.gridControl1.GridCells.AddRange(new Syncfusion.Windows.Forms.Grid.GridCellInfo[] {
            gridCellInfo2});
            this.gridControl1.Location = new System.Drawing.Point(250, 249);
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.gridControl1.RowCount = 5;
            this.gridControl1.RowHeightEntries.AddRange(new Syncfusion.Windows.Forms.Grid.GridRowHeight[] {
            new Syncfusion.Windows.Forms.Grid.GridRowHeight(0, 21)});
            this.gridControl1.Size = new System.Drawing.Size(180, 146);
            this.gridControl1.SmartSizeBox = false;
            // 
            // statusBarAdv1
            // 
            this.statusBarAdv1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.statusBarAdv1.BeforeTouchSize = new System.Drawing.Size(277, 22);
            this.statusBarAdv1.Border3DStyle = System.Windows.Forms.Border3DStyle.Flat;
            this.statusBarAdv1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.statusBarAdv1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.statusBarAdv1.Controls.Add(this.progressBarAdv1);
            this.statusBarAdv1.Controls.Add(this.label1);
            this.statusBarAdv1.CustomLayoutBounds = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.statusBarAdv1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.statusBarAdv1.Location = new System.Drawing.Point(0, 398);
            this.statusBarAdv1.Name = "statusBarAdv1";
            this.statusBarAdv1.Padding = new System.Windows.Forms.Padding(3);
            this.statusBarAdv1.Size = new System.Drawing.Size(277, 22);
            this.statusBarAdv1.SizingGrip = false;
            this.statusBarAdv1.Spacing = new System.Drawing.Size(2, 2);
            this.statusBarAdv1.TabIndex = 5;
            // 
            // progressBarAdv1
            // 
            this.progressBarAdv1.BackColor = System.Drawing.Color.White;
            this.progressBarAdv1.BackGradientEndColor = System.Drawing.Color.White;
            this.progressBarAdv1.BackGradientStartColor = System.Drawing.Color.LightGray;
            this.progressBarAdv1.BackMultipleColors = new System.Drawing.Color[0];
            this.progressBarAdv1.BackSegments = false;
            this.progressBarAdv1.BackTubeEndColor = System.Drawing.Color.White;
            this.progressBarAdv1.BackTubeStartColor = System.Drawing.Color.LightGray;
            this.progressBarAdv1.Border3DStyle = System.Windows.Forms.Border3DStyle.SunkenInner;
            this.progressBarAdv1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.progressBarAdv1.CustomText = null;
            this.progressBarAdv1.CustomWaitingRender = false;
            this.progressBarAdv1.FontColor = System.Drawing.Color.White;
            this.progressBarAdv1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(163)))), ((int)(((byte)(51)))));
            this.progressBarAdv1.ForegroundImage = null;
            this.progressBarAdv1.GradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(165)))), ((int)(((byte)(106)))));
            this.progressBarAdv1.GradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(74)))), ((int)(((byte)(7)))));
            this.progressBarAdv1.Location = new System.Drawing.Point(0, 2);
            this.progressBarAdv1.Maximum = 13;
            this.progressBarAdv1.MultipleColors = new System.Drawing.Color[0];
            this.progressBarAdv1.Name = "progressBarAdv1";
            this.progressBarAdv1.ProgressStyle = Syncfusion.Windows.Forms.Tools.ProgressBarStyles.Tube;
            this.progressBarAdv1.SegmentWidth = 13;
            this.progressBarAdv1.Size = new System.Drawing.Size(195, 16);
            this.progressBarAdv1.TabIndex = 1;
            this.progressBarAdv1.Text = "progressBarAdv1";
            this.progressBarAdv1.TextVisible = false;
            this.progressBarAdv1.ThemesEnabled = false;
            this.progressBarAdv1.TubeEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(165)))), ((int)(((byte)(106)))));
            this.progressBarAdv1.TubeStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(74)))), ((int)(((byte)(7)))));
            this.progressBarAdv1.Value = 1;
            this.progressBarAdv1.WaitingGradientWidth = 400;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(197, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Score: 0000";
            // 
            // nextPiecePanel
            // 
            this.nextPiecePanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(165)))), ((int)(((byte)(106)))));
            this.nextPiecePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nextPiecePanel.Location = new System.Drawing.Point(277, 64);
            this.nextPiecePanel.Name = "nextPiecePanel";
            this.nextPiecePanel.Size = new System.Drawing.Size(128, 87);
            this.nextPiecePanel.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(275, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 14);
            this.label2.TabIndex = 7;
            this.label2.Text = "Next Piece";
            // 
            // progressBarWaiting
            // 
            this.progressBarWaiting.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.progressBarWaiting.BackGradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.progressBarWaiting.BackGradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.progressBarWaiting.BackMultipleColors = new System.Drawing.Color[0];
            this.progressBarWaiting.BackSegments = false;
            this.progressBarWaiting.BackTubeEndColor = System.Drawing.Color.White;
            this.progressBarWaiting.BackTubeStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.progressBarWaiting.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.progressBarWaiting.CustomText = null;
            this.progressBarWaiting.CustomWaitingRender = false;
            this.progressBarWaiting.FontColor = System.Drawing.Color.White;
            this.progressBarWaiting.ForegroundImage = null;
            this.progressBarWaiting.ForeSegments = false;
            this.progressBarWaiting.GradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(74)))), ((int)(((byte)(7)))));
            this.progressBarWaiting.GradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(165)))), ((int)(((byte)(106)))));
            this.progressBarWaiting.Location = new System.Drawing.Point(277, 52);
            this.progressBarWaiting.MultipleColors = new System.Drawing.Color[] {
        System.Drawing.Color.Thistle,
        System.Drawing.Color.Blue};
            this.progressBarWaiting.Name = "progressBarWaiting";
            this.progressBarWaiting.ProgressStyle = Syncfusion.Windows.Forms.Tools.ProgressBarStyles.WaitingGradient;
            this.progressBarWaiting.SegmentWidth = 12;
            this.progressBarWaiting.Size = new System.Drawing.Size(130, 3);
            this.progressBarWaiting.TabIndex = 8;
            this.progressBarWaiting.TextStyle = Syncfusion.Windows.Forms.Tools.ProgressBarTextStyles.Custom;
            this.progressBarWaiting.ThemesEnabled = false;
            this.progressBarWaiting.TubeEndColor = System.Drawing.Color.Black;
            this.progressBarWaiting.TubeStartColor = System.Drawing.Color.Red;
            this.progressBarWaiting.Value = 100;
            this.progressBarWaiting.WaitingGradientEnabled = true;
            this.progressBarWaiting.WaitingGradientInterval = 25;
            this.progressBarWaiting.WaitingGradientWidth = 600;
            // 
            // BlocksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CaptionFont = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CaptionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.ClientSize = new System.Drawing.Size(277, 420);
            this.ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Black;
            this.Controls.Add(this.progressBarWaiting);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nextPiecePanel);
            this.Controls.Add(this.gridBoard);
            this.Controls.Add(this.statusBarAdv1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BlocksForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Essential Blocks Demo";
            ((System.ComponentModel.ISupportInitialize)(this._mainFrameBarManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridBoard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarAdv1)).EndInit();
            this.statusBarAdv1.ResumeLayout(false);
            this.statusBarAdv1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.progressBarAdv1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nextPiecePanel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.progressBarWaiting)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Syncfusion.Windows.Forms.Tools.XPMenus.MainFrameBarManager _mainFrameBarManager;
        private Syncfusion.Windows.Forms.Tools.XPMenus.Bar mainBar;
        private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem fileParentBarItem;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem exitBarItem;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem newGameBarItem;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem pauseBarItem;
        private Syncfusion.Windows.Forms.Grid.GridControl gridBoard;
        private System.Windows.Forms.Timer gameTimer;
        private Syncfusion.Windows.Forms.Grid.GridControl gridControl1;
        private Syncfusion.Windows.Forms.Tools.StatusBarAdv statusBarAdv1;
        private System.Windows.Forms.Label label1;
        private Syncfusion.Windows.Forms.Tools.ProgressBarAdv progressBarAdv1;
        private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem helpParentBarItem;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem aboutBarItem;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem howToPlayBarItem;
        private Syncfusion.Windows.Forms.Tools.GradientPanel nextPiecePanel;
        private System.Windows.Forms.Label label2;
        private Syncfusion.Windows.Forms.Tools.ProgressBarAdv progressBarWaiting;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem showNextPieceItem;
    }
}


#region Copyright Syncfusion Inc. 2001 - 2019
// Copyright Syncfusion Inc. 2001 - 2019. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System.Drawing;
using System.Windows.Forms;
namespace RibbonControlMerging
{
    partial class Form1
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

        //Get and Load the images
#if NET9_0_OR_GREATER
        private static Image GetImage(string path)
        {
            System.Reflection.Assembly asm = System.Reflection.Assembly.GetExecutingAssembly();
            if (asm != null && !string.IsNullOrEmpty(path))
                return Image.FromStream(asm.GetManifestResourceStream(path));
            return null;
        }

        private void LoadImages(ImageList imageList, string folder, int count)
        {
            for (int i = 1; i <= count; i++)
            {
                string imagePath = ($"RibbonMerging.Images.{folder}.Image_{i}.png");
                imageList.Images.Add(GetImage(imagePath));
            }
        }
#endif

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Syncfusion.Windows.Forms.Tools.Office2013ColorTable office2013ColorTable1 = new Syncfusion.Windows.Forms.Tools.Office2013ColorTable();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ribbonControlAdv1 = new Syncfusion.Windows.Forms.Tools.RibbonControlAdv();
            this.backStageView1 = new Syncfusion.Windows.Forms.BackStageView(this.components);
            this.backStage1 = new Syncfusion.Windows.Forms.BackStage();
            this.backStageTab2 = new Syncfusion.Windows.Forms.BackStageTab();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.backStageButton2 = new Syncfusion.Windows.Forms.BackStageButton();
            this.backStageButton3 = new Syncfusion.Windows.Forms.BackStageButton();
            this.backStageButton1 = new Syncfusion.Windows.Forms.BackStageButton();
            this.toolStripTabItem1 = new Syncfusion.Windows.Forms.Tools.ToolStripTabItem();
            this.clipboardToolStripExt = new Syncfusion.Windows.Forms.Tools.ToolStripEx();
            this.toolStripDropDownBtnPaste = new System.Windows.Forms.ToolStripDropDownButton();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteSpecialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteAsHyperlinkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripPanelItem1 = new Syncfusion.Windows.Forms.Tools.ToolStripPanelItem();
            this.toolStripBtnCut = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnCopy = new System.Windows.Forms.ToolStripButton();
            this.fontToolStripExt = new Syncfusion.Windows.Forms.Tools.ToolStripEx();
            this.toolStripPanelItem2 = new Syncfusion.Windows.Forms.Tools.ToolStripPanelItem();
            this.toolStripFontfaceComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripFontSizeComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.growfontToolStripBtn = new System.Windows.Forms.ToolStripButton();
            this.shrinkfontToolStripBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripPanelItem4 = new Syncfusion.Windows.Forms.Tools.ToolStripPanelItem();
            this.boldToolstripBtn = new System.Windows.Forms.ToolStripButton();
            this.italicToolStripBtn = new System.Windows.Forms.ToolStripButton();
            this.underlineToolStripSplitBtn = new System.Windows.Forms.ToolStripSplitButton();
            this.moreUnderlinesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.underlineColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.automaticToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moreColorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.BottomBorderBtn = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.FillColorsBtn = new System.Windows.Forms.ToolStripDropDownButton();
            this.FontColorBtn = new System.Windows.Forms.ToolStripDropDownButton();
            this.AlignmentToolStripEx = new Syncfusion.Windows.Forms.Tools.ToolStripEx();
            this.toolStripPanelItem7 = new Syncfusion.Windows.Forms.Tools.ToolStripPanelItem();
            this.toolStripPanelItem8 = new Syncfusion.Windows.Forms.Tools.ToolStripPanelItem();
            this.TopAlignBtn = new System.Windows.Forms.ToolStripButton();
            this.MiddleAlignBtn = new System.Windows.Forms.ToolStripButton();
            this.BottomAlignBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.IncreaseIndentBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripPanelItem9 = new Syncfusion.Windows.Forms.Tools.ToolStripPanelItem();
            this.AlignLeftBtn = new System.Windows.Forms.ToolStripButton();
            this.CenterBtn = new System.Windows.Forms.ToolStripButton();
            this.AlignRightBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.DecreaseIndentBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripPanelItem12 = new Syncfusion.Windows.Forms.Tools.ToolStripPanelItem();
            this.WrapTextBtn = new System.Windows.Forms.ToolStripButton();
            this.MergeCenterBtn = new System.Windows.Forms.ToolStripDropDownButton();
            this.MergeAndCenter = new System.Windows.Forms.ToolStripMenuItem();
            this.MergeAcrossBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.MergeCellsBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.UnmergeCellsBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.CellsToolStripEx = new Syncfusion.Windows.Forms.Tools.ToolStripEx();
            this.InsertCellBtn = new System.Windows.Forms.ToolStripDropDownButton();
            this.DeleteCellBtn = new System.Windows.Forms.ToolStripDropDownButton();
            this.FormatBtn = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripTabItem2 = new Syncfusion.Windows.Forms.Tools.ToolStripTabItem();
            this.toolStripEx12 = new Syncfusion.Windows.Forms.Tools.ToolStripEx();
            this.toolStripButton18 = new System.Windows.Forms.ToolStripButton();
            this.toolStripEx11 = new Syncfusion.Windows.Forms.Tools.ToolStripEx();
            this.toolStripButton16 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton17 = new System.Windows.Forms.ToolStripButton();
            this.toolStripEx10 = new Syncfusion.Windows.Forms.Tools.ToolStripEx();
            this.toolStripButton15 = new System.Windows.Forms.ToolStripButton();
            this.toolStripEx9 = new Syncfusion.Windows.Forms.Tools.ToolStripEx();
            this.toolStripButton14 = new System.Windows.Forms.ToolStripButton();
            this.toolStripTabItem3 = new Syncfusion.Windows.Forms.Tools.ToolStripTabItem();
            this.themesToolStripExt = new Syncfusion.Windows.Forms.Tools.ToolStripEx();
            this.toolStripButton28 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton29 = new System.Windows.Forms.ToolStripButton();
            this.toolStripEx7 = new Syncfusion.Windows.Forms.Tools.ToolStripEx();
            this.toolStripButton30 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton31 = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.statusStripEx1 = new Syncfusion.Windows.Forms.Tools.StatusStripEx();
            this.statusStripLabel1 = new Syncfusion.Windows.Forms.Tools.StatusStripLabel();
            this.trackBarItem1 = new Syncfusion.Windows.Forms.Tools.TrackBarItem();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.gridControl1 = new Syncfusion.Windows.Forms.Grid.GridControl();
            this.tabBarSplitterControl2 = new Syncfusion.Windows.Forms.TabBarSplitterControl();
            this.tabBarPage1 = new Syncfusion.Windows.Forms.TabBarPage();
            this.splashPanel1 = new Syncfusion.Windows.Forms.Tools.SplashPanel();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.superAccelerator1 = ((Syncfusion.Windows.Forms.Tools.SuperAccelerator)(new Syncfusion.Windows.Forms.Tools.SuperAccelerator(this)));
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControlAdv1)).BeginInit();
            this.ribbonControlAdv1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.backStage1)).BeginInit();
            this.backStage1.SuspendLayout();
            this.backStageTab2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.toolStripTabItem1.Panel.SuspendLayout();
            this.clipboardToolStripExt.SuspendLayout();
            this.fontToolStripExt.SuspendLayout();
            this.AlignmentToolStripEx.SuspendLayout();
            this.CellsToolStripEx.SuspendLayout();
            this.toolStripTabItem2.Panel.SuspendLayout();
            this.toolStripEx12.SuspendLayout();
            this.toolStripEx11.SuspendLayout();
            this.toolStripEx10.SuspendLayout();
            this.toolStripEx9.SuspendLayout();
            this.toolStripTabItem3.Panel.SuspendLayout();
            this.themesToolStripExt.SuspendLayout();
            this.toolStripEx7.SuspendLayout();
            this.statusStripEx1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            this.tabBarSplitterControl2.SuspendLayout();
            this.tabBarPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ribbonControlAdv1
            // 
            this.ribbonControlAdv1.AutoLayoutToolStrip = true;
            this.ribbonControlAdv1.BackStageView = this.backStageView1;
            this.ribbonControlAdv1.CaptionFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ribbonControlAdv1.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.ribbonControlAdv1.Header.AddMainItem(toolStripTabItem1);
            this.ribbonControlAdv1.Header.AddMainItem(toolStripTabItem2);
            this.ribbonControlAdv1.Header.AddMainItem(toolStripTabItem3);
            this.ribbonControlAdv1.Location = new System.Drawing.Point(1, 1);
            this.ribbonControlAdv1.MenuButtonFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ribbonControlAdv1.MenuButtonText = "文件";
            this.ribbonControlAdv1.MenuButtonWidth = 56;
            this.ribbonControlAdv1.MenuColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(114)))), ((int)(((byte)(198)))));
            this.ribbonControlAdv1.Name = "ribbonControlAdv1";
            office2013ColorTable1.BackStageCaptionColor = System.Drawing.Color.White;
            office2013ColorTable1.ButtonBackgroundPressed = System.Drawing.Color.Empty;
            office2013ColorTable1.ButtonBackgroundSelected = System.Drawing.Color.Empty;
            office2013ColorTable1.CaptionBackColor = System.Drawing.Color.White;
            office2013ColorTable1.CaptionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            office2013ColorTable1.CheckedTabColor = System.Drawing.Color.White;
            office2013ColorTable1.CheckedTabForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(115)))), ((int)(((byte)(70)))));
            office2013ColorTable1.CloseButtonColor = System.Drawing.Color.Empty;
            office2013ColorTable1.ContextMenuBackColor = System.Drawing.Color.Empty;
            office2013ColorTable1.ContextMenuItemSelected = System.Drawing.Color.Empty;
            office2013ColorTable1.HeaderColor = System.Drawing.Color.White;
            office2013ColorTable1.HoverTabForeColor = System.Drawing.Color.Empty;
            office2013ColorTable1.LauncherBackColorSelected = System.Drawing.Color.Empty;
            office2013ColorTable1.LauncherColorNormal = System.Drawing.Color.Empty;
            office2013ColorTable1.LauncherColorSelected = System.Drawing.Color.Empty;
            office2013ColorTable1.MaximizeButtonColor = System.Drawing.Color.Empty;
            office2013ColorTable1.MinimizeButtonColor = System.Drawing.Color.Empty;
            office2013ColorTable1.PanelBackColor = System.Drawing.Color.White;
            office2013ColorTable1.RestoreButtonColor = System.Drawing.Color.Empty;
            office2013ColorTable1.RibbonPanelBorderColor = System.Drawing.Color.Empty;
            office2013ColorTable1.SelectedTabBorderColor = System.Drawing.Color.White;
            office2013ColorTable1.SelectedTabColor = System.Drawing.Color.White;
            office2013ColorTable1.SplitButtonBackgroundPressed = System.Drawing.Color.Empty;
            office2013ColorTable1.SplitButtonBackgroundSelected = System.Drawing.Color.Empty;
            office2013ColorTable1.SystemButtonBackground = System.Drawing.Color.Empty;
            office2013ColorTable1.TabBackColor = System.Drawing.Color.White;
            office2013ColorTable1.TabForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(2)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            office2013ColorTable1.TitleColor = System.Drawing.Color.Empty;
            office2013ColorTable1.ToolStripBackColor = System.Drawing.Color.White;
            office2013ColorTable1.ToolStripBorderColor = System.Drawing.Color.White;
            office2013ColorTable1.ToolStripItemForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            office2013ColorTable1.ToolStripSpliterColor = System.Drawing.Color.LightGray;
            office2013ColorTable1.UpDownButtonBackColor = System.Drawing.Color.Empty;
            this.ribbonControlAdv1.Office2013ColorTable = office2013ColorTable1;
            this.ribbonControlAdv1.OfficeColorScheme = Syncfusion.Windows.Forms.Tools.ToolStripEx.ColorScheme.Managed;
            // 
            // ribbonControlAdv1.OfficeMenu
            // 
            this.ribbonControlAdv1.OfficeMenu.AuxPanel.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripSeparator1,
            this.toolStripButton5});
            this.ribbonControlAdv1.OfficeMenu.MainPanel.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton2,
            this.toolStripButton3,
            this.toolStripButton4});
            this.ribbonControlAdv1.OfficeMenu.Name = "OfficeMenu";
            this.ribbonControlAdv1.OfficeMenu.Size = new System.Drawing.Size(197, 162);
            this.ribbonControlAdv1.QuickPanelImageLayout = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ribbonControlAdv1.QuickPanelVisible = false;
            this.ribbonControlAdv1.RibbonHeaderImage = Syncfusion.Windows.Forms.Tools.RibbonHeaderImage.None;
            this.ribbonControlAdv1.RibbonStyle = Syncfusion.Windows.Forms.Tools.RibbonStyle.Office2013;
            this.ribbonControlAdv1.SelectedTab = this.toolStripTabItem1;
            this.ribbonControlAdv1.ShowRibbonDisplayOptionButton = true;
            this.ribbonControlAdv1.Size = new System.Drawing.Size(991, 159);
            this.ribbonControlAdv1.SystemText.QuickAccessDialogDropDownName = "Start menu";
            //this.ribbonControlAdv1.SystemText.RenameDisplayLabelText = "&Display Name:";
            this.ribbonControlAdv1.TabIndex = 0;
            this.ribbonControlAdv1.Text = "ribbonControlAdv1";
            // 
            // backStageView1
            // 
            this.backStageView1.BackStage = this.backStage1;
            this.backStageView1.HostControl = null;
            this.backStageView1.HostForm = this;
            // 
            // backStage1
            // 
            this.backStage1.AllowDrop = true;
            this.backStage1.BeforeTouchSize = new System.Drawing.Size(987, 495);
            this.backStage1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.backStage1.ChildItemSize = new System.Drawing.Size(80, 140);
            this.backStage1.CloseButtonForeColor = System.Drawing.Color.Empty;
            this.backStage1.CloseButtonHoverForeColor = System.Drawing.Color.Empty;
            this.backStage1.CloseButtonPressedForeColor = System.Drawing.Color.Empty;
            this.backStage1.Controls.Add(this.backStageTab2);
            this.backStage1.Controls.Add(this.backStageButton2);
            this.backStage1.Controls.Add(this.backStageButton3);
            this.backStage1.Controls.Add(this.backStageButton1);
            this.backStage1.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.backStage1.ItemSize = new System.Drawing.Size(138, 40);
            this.backStage1.Location = new System.Drawing.Point(0, 0);
            this.backStage1.Name = "backStage1";
            this.backStage1.OfficeColorScheme = Syncfusion.Windows.Forms.Tools.ToolStripEx.ColorScheme.Managed;
            this.backStage1.Size = new System.Drawing.Size(987, 495);
            this.backStage1.TabIndex = 7;
            this.backStage1.Visible = false;
            // 
            // backStageTab2
            // 
            this.backStageTab2.Accelerator = "";
            this.backStageTab2.BackColor = System.Drawing.Color.White;
            this.backStageTab2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.backStageTab2.Controls.Add(this.panel3);
            this.backStageTab2.Controls.Add(this.label2);
            this.backStageTab2.Image = null;
            this.backStageTab2.ImageSize = new System.Drawing.Size(16, 16);
            this.backStageTab2.Location = new System.Drawing.Point(137, 0);
            this.backStageTab2.Name = "backStageTab2";
            this.backStageTab2.Position = new System.Drawing.Point(11, 51);
            this.backStageTab2.ShowCloseButton = true;
            this.backStageTab2.Size = new System.Drawing.Size(850, 495);
            this.backStageTab2.TabIndex = 4;
            this.backStageTab2.Text = "新";
            this.backStageTab2.ThemesEnabled = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Location = new System.Drawing.Point(81, 79);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(248, 218);
            this.panel3.TabIndex = 5;
            this.panel3.MouseEnter += new System.EventHandler(this.panel3_MouseEnter);
            this.panel3.MouseLeave += new System.EventHandler(this.panel3_MouseLeave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(69, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Blank workbook";
            this.label3.MouseEnter += new System.EventHandler(this.panel3_MouseEnter);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(21, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(204, 153);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseEnter += new System.EventHandler(this.panel3_MouseEnter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(76, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 30);
            this.label2.TabIndex = 2;
            this.label2.Text = "New";
            // 
            // backStageButton2
            // 
            this.backStageButton2.Accelerator = "";
            this.backStageButton2.BackColor = System.Drawing.Color.Transparent;
            this.backStageButton2.BeforeTouchSize = new System.Drawing.Size(75, 23);
            this.backStageButton2.IsBackStageButton = false;
            this.backStageButton2.Location = new System.Drawing.Point(10, 51);
            this.backStageButton2.Name = "backStageButton2";
            this.backStageButton2.Size = new System.Drawing.Size(110, 25);
            this.backStageButton2.TabIndex = 8;
            this.backStageButton2.Text = "打开";
            // 
            // backStageButton3
            // 
            this.backStageButton3.Accelerator = "";
            this.backStageButton3.BackColor = System.Drawing.Color.Transparent;
            this.backStageButton3.BeforeTouchSize = new System.Drawing.Size(75, 23);
            this.backStageButton3.IsBackStageButton = false;
            this.backStageButton3.Location = new System.Drawing.Point(10, 76);
            this.backStageButton3.Name = "backStageButton3";
            this.backStageButton3.Size = new System.Drawing.Size(110, 25);
            this.backStageButton3.TabIndex = 9;
            this.backStageButton3.Text = "保存";
            // 
            // backStageButton1
            // 
            this.backStageButton1.Accelerator = "";
            this.backStageButton1.BackColor = System.Drawing.Color.Transparent;
            this.backStageButton1.BeforeTouchSize = new System.Drawing.Size(75, 23);
            this.backStageButton1.IsBackStageButton = false;
            this.backStageButton1.Location = new System.Drawing.Point(10, 101);
            this.backStageButton1.Name = "backStageButton1";
            this.backStageButton1.Size = new System.Drawing.Size(110, 25);
            this.backStageButton1.TabIndex = 7;
            this.backStageButton1.Text = "出口";
            // 
            // toolStripTabItem1
            // 
            this.superAccelerator1.SetAccelerator(this.toolStripTabItem1, "H");
            this.toolStripTabItem1.Name = "toolStripTabItem1";
            this.toolStripTabItem1.Padding = new System.Windows.Forms.Padding(15, 1, 3, 1);
            // 
            // ribbonControlAdv1.ribbonPanel1
            // 
            this.toolStripTabItem1.Panel.Controls.Add(this.clipboardToolStripExt);
            this.toolStripTabItem1.Panel.Controls.Add(this.fontToolStripExt);
            this.toolStripTabItem1.Panel.Controls.Add(this.AlignmentToolStripEx);
            this.toolStripTabItem1.Panel.Controls.Add(this.CellsToolStripEx);
            this.toolStripTabItem1.Panel.Name = "ribbonPanel1";
            this.toolStripTabItem1.Panel.ScrollPosition = 0;
            this.toolStripTabItem1.Panel.TabIndex = 2;
            this.toolStripTabItem1.Panel.Text = "啊不额从";
            this.toolStripTabItem1.Position = 0;
            this.toolStripTabItem1.Size = new System.Drawing.Size(76, 25);
            this.toolStripTabItem1.Text = "啊不额从";
            // 
            // clipboardToolStripExt
            // 
            this.clipboardToolStripExt.CollapsedDropDownButtonText = "Clipboard";
            this.clipboardToolStripExt.DefaultDropDownDirection = System.Windows.Forms.ToolStripDropDownDirection.BelowRight;
            this.clipboardToolStripExt.Dock = System.Windows.Forms.DockStyle.None;
            this.clipboardToolStripExt.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.clipboardToolStripExt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.clipboardToolStripExt.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.clipboardToolStripExt.Image = ((System.Drawing.Image)(resources.GetObject("clipboardToolStripExt.Image")));
            this.clipboardToolStripExt.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownBtnPaste,
            this.toolStripPanelItem1});
            this.clipboardToolStripExt.LauncherStyle = Syncfusion.Windows.Forms.Tools.LauncherStyle.Office2007;
            this.clipboardToolStripExt.Location = new System.Drawing.Point(0, 1);
            this.clipboardToolStripExt.Name = "clipboardToolStripExt";
            this.clipboardToolStripExt.Office12Mode = false;
            this.clipboardToolStripExt.Size = new System.Drawing.Size(149, 91);
            this.clipboardToolStripExt.TabIndex = 15;
            this.clipboardToolStripExt.Text = "剪贴板";
            // 
            // toolStripDropDownBtnPaste
            // 
            this.toolStripDropDownBtnPaste.AutoToolTip = false;
            this.toolStripDropDownBtnPaste.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pasteToolStripMenuItem,
            this.pasteSpecialToolStripMenuItem,
            this.pasteAsHyperlinkToolStripMenuItem});
            this.toolStripDropDownBtnPaste.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.toolStripDropDownBtnPaste.Image = global::RibbonMerging.Properties.Resources.Paste32;
            this.toolStripDropDownBtnPaste.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownBtnPaste.Margin = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.toolStripDropDownBtnPaste.Name = "toolStripDropDownBtnPaste";
            this.toolStripDropDownBtnPaste.ShowDropDownArrow = false;
            this.toolStripDropDownBtnPaste.Size = new System.Drawing.Size(60, 76);
            this.toolStripDropDownBtnPaste.Text = "啊不额从";
            this.toolStripDropDownBtnPaste.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolStripDropDownBtnPaste.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripDropDownBtnPaste.ToolTipText = "啊不额从";
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("pasteToolStripMenuItem.Image")));
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.pasteToolStripMenuItem.Text = "啊不额从";
            this.pasteToolStripMenuItem.ToolTipText = "啊不额从";
            // 
            // pasteSpecialToolStripMenuItem
            // 
            this.pasteSpecialToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("pasteSpecialToolStripMenuItem.Image")));
            this.pasteSpecialToolStripMenuItem.Name = "pasteSpecialToolStripMenuItem";
            this.pasteSpecialToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.pasteSpecialToolStripMenuItem.Text = "啊不额从";
            this.pasteSpecialToolStripMenuItem.ToolTipText = "啊不额从";
            // 
            // pasteAsHyperlinkToolStripMenuItem
            // 
            this.pasteAsHyperlinkToolStripMenuItem.Enabled = false;
            this.pasteAsHyperlinkToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("pasteAsHyperlinkToolStripMenuItem.Image")));
            this.pasteAsHyperlinkToolStripMenuItem.Name = "pasteAsHyperlinkToolStripMenuItem";
            this.pasteAsHyperlinkToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.pasteAsHyperlinkToolStripMenuItem.Text = "啊不额从";
            this.pasteAsHyperlinkToolStripMenuItem.ToolTipText = "啊不额从";
            // 
            // toolStripPanelItem1
            // 
            this.toolStripPanelItem1.CausesValidation = false;
            this.toolStripPanelItem1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripPanelItem1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.toolStripPanelItem1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripBtnCut,
            this.toolStripBtnCopy});
            this.toolStripPanelItem1.Name = "toolStripPanelItem1";
            this.toolStripPanelItem1.Size = new System.Drawing.Size(80, 77);
            this.toolStripPanelItem1.Text = "toolStripPanelItem1";
            this.toolStripPanelItem1.Transparent = true;
            // 
            // toolStripBtnCut
            // 
            this.superAccelerator1.SetAccelerator(this.toolStripBtnCut, "X");
            this.toolStripBtnCut.AutoToolTip = false;
            this.toolStripBtnCut.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripBtnCut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.toolStripBtnCut.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnCut.Image")));
            this.toolStripBtnCut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnCut.Margin = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.toolStripBtnCut.Name = "toolStripBtnCut";
            this.toolStripBtnCut.Size = new System.Drawing.Size(76, 24);
            this.toolStripBtnCut.Text = "啊不额从";
            this.toolStripBtnCut.ToolTipText = "啊不额从";
            // 
            // toolStripBtnCopy
            // 
            this.superAccelerator1.SetAccelerator(this.toolStripBtnCopy, "C");
            this.toolStripBtnCopy.AutoToolTip = false;
            this.toolStripBtnCopy.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripBtnCopy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.toolStripBtnCopy.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnCopy.Image")));
            this.toolStripBtnCopy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnCopy.Margin = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.toolStripBtnCopy.Name = "toolStripBtnCopy";
            this.toolStripBtnCopy.Size = new System.Drawing.Size(76, 24);
            this.toolStripBtnCopy.Text = "啊不额从";
            this.toolStripBtnCopy.ToolTipText = "啊不额从";
            // 
            // fontToolStripExt
            // 
            this.fontToolStripExt.AutoSize = true;
            this.fontToolStripExt.CollapsedDropDownButtonText = "Font";
            this.fontToolStripExt.DefaultDropDownDirection = System.Windows.Forms.ToolStripDropDownDirection.BelowRight;
            this.fontToolStripExt.Dock = System.Windows.Forms.DockStyle.None;
            this.fontToolStripExt.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.fontToolStripExt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.fontToolStripExt.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.fontToolStripExt.GroupedButtons = true;
            this.fontToolStripExt.Image = ((System.Drawing.Image)(resources.GetObject("fontToolStripExt.Image")));
            this.fontToolStripExt.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripPanelItem2,
            this.toolStripPanelItem4});
            this.fontToolStripExt.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.fontToolStripExt.Location = new System.Drawing.Point(151, 1);
            this.fontToolStripExt.Name = "fontToolStripExt";
            this.fontToolStripExt.Office12Mode = false;
            this.fontToolStripExt.Padding = new System.Windows.Forms.Padding(0, 10, 1, 0);
            this.fontToolStripExt.Size = new System.Drawing.Size(304, 91);
            this.fontToolStripExt.TabIndex = 14;
            this.fontToolStripExt.Text = "剪贴板";
            // 
            // toolStripPanelItem2
            // 
            this.toolStripPanelItem2.CausesValidation = false;
            this.toolStripPanelItem2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripPanelItem2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.toolStripPanelItem2.GroupedButtons = true;
            this.toolStripPanelItem2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripFontfaceComboBox,
            this.toolStripFontSizeComboBox,
            this.growfontToolStripBtn,
            this.shrinkfontToolStripBtn});
            this.toolStripPanelItem2.Name = "toolStripPanelItem2";
            this.toolStripPanelItem2.RowCount = 1;
            this.toolStripPanelItem2.Size = new System.Drawing.Size(200, 28);
            this.toolStripPanelItem2.Text = "toolStripPanelItem2";
            this.toolStripPanelItem2.Transparent = true;
            // 
            // toolStripFontfaceComboBox
            // 
            this.superAccelerator1.SetAccelerator(this.toolStripFontfaceComboBox, "FF");
            this.toolStripFontfaceComboBox.DropDownHeight = 120;
            this.toolStripFontfaceComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toolStripFontfaceComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.toolStripFontfaceComboBox.IntegralHeight = false;
            this.toolStripFontfaceComboBox.Items.AddRange(new object[] {
            "Segoe UI",
            "Times New Roman",
            "Arial",
            "Calibri",
            "Arial Black"});
            this.toolStripFontfaceComboBox.Margin = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.toolStripFontfaceComboBox.Name = "toolStripFontfaceComboBox";
            this.toolStripFontfaceComboBox.Size = new System.Drawing.Size(121, 23);
            // 
            // toolStripFontSizeComboBox
            // 
            this.superAccelerator1.SetAccelerator(this.toolStripFontSizeComboBox, "FS");
            this.toolStripFontSizeComboBox.AutoSize = false;
            this.toolStripFontSizeComboBox.DropDownHeight = 120;
            this.toolStripFontSizeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toolStripFontSizeComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.toolStripFontSizeComboBox.IntegralHeight = false;
            this.toolStripFontSizeComboBox.Items.AddRange(new object[] {
            "8",
            "9",
            "10",
            "11",
            "12",
            "14",
            "16",
            "18",
            "20",
            "22",
            "24",
            "26",
            "28",
            "36",
            "48",
            "72"});
            this.toolStripFontSizeComboBox.Margin = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.toolStripFontSizeComboBox.Name = "toolStripFontSizeComboBox";
            this.toolStripFontSizeComboBox.Size = new System.Drawing.Size(75, 23);
            // 
            // growfontToolStripBtn
            // 
            this.superAccelerator1.SetAccelerator(this.growfontToolStripBtn, "FG");
            this.growfontToolStripBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.growfontToolStripBtn.Image = ((System.Drawing.Image)(resources.GetObject("growfontToolStripBtn.Image")));
       
            this.growfontToolStripBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.growfontToolStripBtn.Margin = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.growfontToolStripBtn.Name = "growfontToolStripBtn";
            this.growfontToolStripBtn.Size = new System.Drawing.Size(23, 20);
            this.growfontToolStripBtn.Text = "水平";
            // 
            // shrinkfontToolStripBtn
            // 
            this.superAccelerator1.SetAccelerator(this.shrinkfontToolStripBtn, "FK");
            this.shrinkfontToolStripBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.shrinkfontToolStripBtn.Image = ((System.Drawing.Image)(resources.GetObject("shrinkfontToolStripBtn.Image")));
     
            this.shrinkfontToolStripBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.shrinkfontToolStripBtn.Margin = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.shrinkfontToolStripBtn.Name = "shrinkfontToolStripBtn";
            this.shrinkfontToolStripBtn.Size = new System.Drawing.Size(23, 20);
            this.shrinkfontToolStripBtn.Text = "水平";
            // 
            // toolStripPanelItem4
            // 
            this.toolStripPanelItem4.CausesValidation = false;
            this.toolStripPanelItem4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripPanelItem4.ForeColor = System.Drawing.Color.MidnightBlue;
            this.toolStripPanelItem4.GroupedButtons = true;
            this.toolStripPanelItem4.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.boldToolstripBtn,
            this.italicToolStripBtn,
            this.underlineToolStripSplitBtn,
            this.toolStripSeparator5,
            this.BottomBorderBtn,
            this.toolStripSeparator6,
            this.FillColorsBtn,
            this.FontColorBtn});
            this.toolStripPanelItem4.Name = "toolStripPanelItem4";
            this.toolStripPanelItem4.Padding = new System.Windows.Forms.Padding(2, 5, 2, 2);
            this.toolStripPanelItem4.RowCount = 1;
            this.toolStripPanelItem4.Size = new System.Drawing.Size(259, 32);
            this.toolStripPanelItem4.Text = "toolStripPanelItem4";
            this.toolStripPanelItem4.Transparent = true;
            // 
            // boldToolstripBtn
            // 
            this.superAccelerator1.SetAccelerator(this.boldToolstripBtn, "1");
            this.boldToolstripBtn.AutoToolTip = false;
            this.boldToolstripBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.boldToolstripBtn.Image = ((System.Drawing.Image)(resources.GetObject("boldToolstripBtn.Image")));
          
            this.boldToolstripBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.boldToolstripBtn.Margin = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.boldToolstripBtn.Name = "boldToolstripBtn";
            this.boldToolstripBtn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.boldToolstripBtn.Size = new System.Drawing.Size(30, 20);
            this.boldToolstripBtn.Text = "boldToolstripBtn";
            // 
            // italicToolStripBtn
            // 
            this.superAccelerator1.SetAccelerator(this.italicToolStripBtn, "2");
            this.italicToolStripBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.italicToolStripBtn.Image = ((System.Drawing.Image)(resources.GetObject("italicToolStripBtn.Image")));
         
            this.italicToolStripBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.italicToolStripBtn.Margin = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.italicToolStripBtn.Name = "italicToolStripBtn";
            this.italicToolStripBtn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.italicToolStripBtn.Size = new System.Drawing.Size(30, 20);
            this.italicToolStripBtn.Text = "italicToolStripBtn";
            // 
            // underlineToolStripSplitBtn
            // 
            this.superAccelerator1.SetAccelerator(this.underlineToolStripSplitBtn, "3");
            this.underlineToolStripSplitBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.underlineToolStripSplitBtn.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.moreUnderlinesToolStripMenuItem,
            this.underlineColorToolStripMenuItem});
            this.underlineToolStripSplitBtn.Image = ((System.Drawing.Image)(resources.GetObject("underlineToolStripSplitBtn.Image")));
           
            this.underlineToolStripSplitBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.underlineToolStripSplitBtn.Margin = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.underlineToolStripSplitBtn.Name = "underlineToolStripSplitBtn";
            this.underlineToolStripSplitBtn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.underlineToolStripSplitBtn.Size = new System.Drawing.Size(42, 20);
            this.underlineToolStripSplitBtn.Text = "underlineToolStripSplitBtn";
            // 
            // moreUnderlinesToolStripMenuItem
            // 
            this.moreUnderlinesToolStripMenuItem.Name = "moreUnderlinesToolStripMenuItem";
            this.moreUnderlinesToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.moreUnderlinesToolStripMenuItem.Text = "&More Underlines...";
            // 
            // underlineColorToolStripMenuItem
            // 
            this.underlineColorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.automaticToolStripMenuItem,
            this.moreColorsToolStripMenuItem});
            this.underlineColorToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("underlineColorToolStripMenuItem.Image")));
            this.underlineColorToolStripMenuItem.Name = "underlineColorToolStripMenuItem";
            this.underlineColorToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.underlineColorToolStripMenuItem.Text = "&Underline Color";
            // 
            // automaticToolStripMenuItem
            // 
            this.automaticToolStripMenuItem.Name = "automaticToolStripMenuItem";
            this.automaticToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.automaticToolStripMenuItem.Text = "&Automatic";
            // 
            // moreColorsToolStripMenuItem
            // 
            this.moreColorsToolStripMenuItem.Name = "moreColorsToolStripMenuItem";
            this.moreColorsToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.moreColorsToolStripMenuItem.Text = "&More Colors...";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Margin = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 23);
            // 
            // BottomBorderBtn
            // 
            this.superAccelerator1.SetAccelerator(this.BottomBorderBtn, "D");
            this.BottomBorderBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BottomBorderBtn.Image = ((System.Drawing.Image)(resources.GetObject("BottomBorderBtn.Image")));
            this.BottomBorderBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BottomBorderBtn.Margin = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.BottomBorderBtn.Name = "BottomBorderBtn";
            this.BottomBorderBtn.Padding = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.BottomBorderBtn.Size = new System.Drawing.Size(59, 20);
            this.BottomBorderBtn.Text = "Bottom Border";
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Margin = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 23);
            // 
            // FillColorsBtn
            // 
            this.superAccelerator1.SetAccelerator(this.FillColorsBtn, "H");
            this.FillColorsBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.FillColorsBtn.Image = ((System.Drawing.Image)(resources.GetObject("FillColorsBtn.Image")));
            this.FillColorsBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.FillColorsBtn.Margin = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.FillColorsBtn.Name = "FillColorsBtn";
            this.FillColorsBtn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.FillColorsBtn.Size = new System.Drawing.Size(39, 20);
            this.FillColorsBtn.Text = "Fill Colors";
            // 
            // FontColorBtn
            // 
            this.superAccelerator1.SetAccelerator(this.FontColorBtn, "FC");
            this.FontColorBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.FontColorBtn.Image = ((System.Drawing.Image)(resources.GetObject("FontColorBtn.Image")));

            this.FontColorBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.FontColorBtn.Margin = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.FontColorBtn.Name = "FontColorBtn";
            this.FontColorBtn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.FontColorBtn.Size = new System.Drawing.Size(43, 24);
            this.FontColorBtn.Text = "Font Color";
            // 
            // AlignmentToolStripEx
            // 
            this.AlignmentToolStripEx.CollapsedDropDownButtonText = "Paragraph";
            this.AlignmentToolStripEx.DefaultDropDownDirection = System.Windows.Forms.ToolStripDropDownDirection.BelowRight;
            this.AlignmentToolStripEx.Dock = System.Windows.Forms.DockStyle.None;
            this.AlignmentToolStripEx.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.AlignmentToolStripEx.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.AlignmentToolStripEx.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.AlignmentToolStripEx.GroupedButtons = true;
            this.AlignmentToolStripEx.Image = ((System.Drawing.Image)(resources.GetObject("AlignmentToolStripEx.Image")));
            this.AlignmentToolStripEx.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripPanelItem7,
            this.toolStripSeparator4,
            this.toolStripPanelItem12});
            this.AlignmentToolStripEx.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.AlignmentToolStripEx.Location = new System.Drawing.Point(457, 1);
            this.AlignmentToolStripEx.Name = "AlignmentToolStripEx";
            this.AlignmentToolStripEx.Office12Mode = false;
            this.AlignmentToolStripEx.Padding = new System.Windows.Forms.Padding(0, 10, 1, 0);
            this.AlignmentToolStripEx.Size = new System.Drawing.Size(220, 91);
            this.AlignmentToolStripEx.TabIndex = 16;
            this.AlignmentToolStripEx.Text = "对准";
            // 
            // toolStripPanelItem7
            // 
            this.toolStripPanelItem7.CausesValidation = false;
            this.toolStripPanelItem7.ForeColor = System.Drawing.Color.MidnightBlue;
            this.toolStripPanelItem7.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripPanelItem8,
            this.toolStripPanelItem9});
            this.toolStripPanelItem7.Name = "toolStripPanelItem7";
            this.toolStripPanelItem7.Size = new System.Drawing.Size(106, 62);
            this.toolStripPanelItem7.Text = "toolStripPanelItem7";
            this.toolStripPanelItem7.Transparent = true;
            // 
            // toolStripPanelItem8
            // 
            this.toolStripPanelItem8.CausesValidation = false;
            this.toolStripPanelItem8.ForeColor = System.Drawing.Color.MidnightBlue;
            this.toolStripPanelItem8.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TopAlignBtn,
            this.MiddleAlignBtn,
            this.BottomAlignBtn,
            this.toolStripSeparator2,
            this.IncreaseIndentBtn});
            this.toolStripPanelItem8.Margin = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.toolStripPanelItem8.Name = "toolStripPanelItem8";
            this.toolStripPanelItem8.RowCount = 1;
            this.toolStripPanelItem8.Size = new System.Drawing.Size(102, 28);
            this.toolStripPanelItem8.Text = "toolStripPanelItem8";
            this.toolStripPanelItem8.Transparent = true;
            // 
            // TopAlignBtn
            // 
            this.superAccelerator1.SetAccelerator(this.TopAlignBtn, "AT");
            this.TopAlignBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TopAlignBtn.Image = ((System.Drawing.Image)(resources.GetObject("TopAlignBtn.Image")));
         
            this.TopAlignBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TopAlignBtn.Margin = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.TopAlignBtn.Name = "TopAlignBtn";
            this.TopAlignBtn.Size = new System.Drawing.Size(23, 20);
            this.TopAlignBtn.Text = "顶部对齐";
            // 
            // MiddleAlignBtn
            // 
            this.superAccelerator1.SetAccelerator(this.MiddleAlignBtn, "AM");
            this.MiddleAlignBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.MiddleAlignBtn.Image = ((System.Drawing.Image)(resources.GetObject("MiddleAlignBtn.Image")));
       
            this.MiddleAlignBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.MiddleAlignBtn.Margin = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.MiddleAlignBtn.Name = "MiddleAlignBtn";
            this.MiddleAlignBtn.Size = new System.Drawing.Size(23, 20);
            this.MiddleAlignBtn.Text = "中间对齐";
            // 
            // BottomAlignBtn
            // 
            this.superAccelerator1.SetAccelerator(this.BottomAlignBtn, "AB");
            this.BottomAlignBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BottomAlignBtn.Image = ((System.Drawing.Image)(resources.GetObject("BottomAlignBtn.Image")));
          
            this.BottomAlignBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BottomAlignBtn.Margin = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.BottomAlignBtn.Name = "BottomAlignBtn";
            this.BottomAlignBtn.Size = new System.Drawing.Size(23, 20);
            this.BottomAlignBtn.Text = "底部对齐";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Margin = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(4, 24);
            // 
            // IncreaseIndentBtn
            // 
            this.superAccelerator1.SetAccelerator(this.IncreaseIndentBtn, "II");
            this.IncreaseIndentBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.IncreaseIndentBtn.Image = ((System.Drawing.Image)(resources.GetObject("IncreaseIndentBtn.Image")));
            this.IncreaseIndentBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.IncreaseIndentBtn.Margin = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.IncreaseIndentBtn.Name = "IncreaseIndentBtn";
            this.IncreaseIndentBtn.Size = new System.Drawing.Size(23, 24);
            this.IncreaseIndentBtn.Text = "增加缩进";
            // 
            // toolStripPanelItem9
            // 
            this.toolStripPanelItem9.CausesValidation = false;
            this.toolStripPanelItem9.ForeColor = System.Drawing.Color.MidnightBlue;
            this.toolStripPanelItem9.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AlignLeftBtn,
            this.CenterBtn,
            this.AlignRightBtn,
            this.toolStripSeparator3,
            this.DecreaseIndentBtn});
            this.toolStripPanelItem9.Margin = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.toolStripPanelItem9.Name = "toolStripPanelItem9";
            this.toolStripPanelItem9.RowCount = 1;
            this.toolStripPanelItem9.Size = new System.Drawing.Size(102, 28);
            this.toolStripPanelItem9.Text = "toolStripPanelItem9";
            this.toolStripPanelItem9.Transparent = true;
            // 
            // AlignLeftBtn
            // 
            this.superAccelerator1.SetAccelerator(this.AlignLeftBtn, "AL");
            this.AlignLeftBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.AlignLeftBtn.Image = ((System.Drawing.Image)(resources.GetObject("AlignLeftBtn.Image")));

            this.AlignLeftBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AlignLeftBtn.Margin = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.AlignLeftBtn.Name = "AlignLeftBtn";
            this.AlignLeftBtn.Size = new System.Drawing.Size(23, 20);
            this.AlignLeftBtn.Text = "左对齐";
            // 
            // CenterBtn
            // 
            this.superAccelerator1.SetAccelerator(this.CenterBtn, "AC");
            this.CenterBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.CenterBtn.Image = ((System.Drawing.Image)(resources.GetObject("CenterBtn.Image")));
            this.CenterBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CenterBtn.Margin = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.CenterBtn.Name = "CenterBtn";
            this.CenterBtn.Size = new System.Drawing.Size(23, 24);
            this.CenterBtn.Text = "中央";
            // 
            // AlignRightBtn
            // 
            this.superAccelerator1.SetAccelerator(this.AlignRightBtn, "AR");
            this.AlignRightBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.AlignRightBtn.Image = ((System.Drawing.Image)(resources.GetObject("AlignRightBtn.Image")));
            this.AlignRightBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AlignRightBtn.Margin = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.AlignRightBtn.Name = "AlignRightBtn";
            this.AlignRightBtn.Size = new System.Drawing.Size(23, 24);
            this.AlignRightBtn.Text = "右对齐";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Margin = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(4, 24);
            // 
            // DecreaseIndentBtn
            // 
            this.superAccelerator1.SetAccelerator(this.DecreaseIndentBtn, "ID");
            this.DecreaseIndentBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.DecreaseIndentBtn.Image = ((System.Drawing.Image)(resources.GetObject("DecreaseIndentBtn.Image")));
            this.DecreaseIndentBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DecreaseIndentBtn.Margin = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.DecreaseIndentBtn.Name = "DecreaseIndentBtn";
            this.DecreaseIndentBtn.Size = new System.Drawing.Size(23, 24);
            this.DecreaseIndentBtn.Text = "减少缩进";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.AutoSize = false;
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 55);
            // 
            // toolStripPanelItem12
            // 
            this.toolStripPanelItem12.CausesValidation = false;
            this.toolStripPanelItem12.ForeColor = System.Drawing.Color.MidnightBlue;
            this.toolStripPanelItem12.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.WrapTextBtn,
            this.MergeCenterBtn});
            this.toolStripPanelItem12.Name = "toolStripPanelItem12";
            this.toolStripPanelItem12.Size = new System.Drawing.Size(99, 45);
            this.toolStripPanelItem12.Text = "toolStripPanelItem12";
            this.toolStripPanelItem12.Transparent = true;
            // 
            // WrapTextBtn
            // 
            this.superAccelerator1.SetAccelerator(this.WrapTextBtn, "W");
            this.WrapTextBtn.Image = ((System.Drawing.Image)(resources.GetObject("WrapTextBtn.Image")));
        
            this.WrapTextBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.WrapTextBtn.Margin = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.WrapTextBtn.Name = "WrapTextBtn";
            this.WrapTextBtn.Size = new System.Drawing.Size(77, 20);
            this.WrapTextBtn.Text = "自动换行";
            this.WrapTextBtn.ForeColor = Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            // 
            // MergeCenterBtn
            // 
            this.superAccelerator1.SetAccelerator(this.MergeCenterBtn, "M");
            this.MergeCenterBtn.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MergeAndCenter,
            this.MergeAcrossBtn,
            this.MergeCellsBtn,
            this.UnmergeCellsBtn});
            this.MergeCenterBtn.Image = ((System.Drawing.Image)(resources.GetObject("MergeCenterBtn.Image")));
         
            this.MergeCenterBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.MergeCenterBtn.Margin = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.MergeCenterBtn.Name = "MergeCenterBtn";
            this.MergeCenterBtn.Size = new System.Drawing.Size(95, 19);
            this.MergeCenterBtn.Text = "合并及居中";
            this.MergeCenterBtn.ForeColor = Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            // 
            // MergeAndCenter
            // 
            this.MergeAndCenter.Image = ((System.Drawing.Image)(resources.GetObject("MergeAndCenter.Image")));

            this.MergeAndCenter.Name = "MergeAndCenter";
            this.MergeAndCenter.Size = new System.Drawing.Size(159, 22);
            this.MergeAndCenter.Text = "合并及居中";
            // 
            // MergeAcrossBtn
            // 
            this.MergeAcrossBtn.Image = ((System.Drawing.Image)(resources.GetObject("MergeAcrossBtn.Image")));

            this.MergeAcrossBtn.Name = "MergeAcrossBtn";
            this.MergeAcrossBtn.Size = new System.Drawing.Size(159, 22);
            this.MergeAcrossBtn.Text = "合并不同";
            // 
            // MergeCellsBtn
            // 
            this.MergeCellsBtn.Image = ((System.Drawing.Image)(resources.GetObject("MergeCellsBtn.Image")));

            this.MergeCellsBtn.Name = "MergeCellsBtn";
            this.MergeCellsBtn.Size = new System.Drawing.Size(159, 22);
            this.MergeCellsBtn.Text = "合并单元格";
            // 
            // UnmergeCellsBtn
            // 
            this.UnmergeCellsBtn.Image = ((System.Drawing.Image)(resources.GetObject("UnmergeCellsBtn.Image")));
        
            this.UnmergeCellsBtn.Name = "UnmergeCellsBtn";
            this.UnmergeCellsBtn.Size = new System.Drawing.Size(159, 22);
            this.UnmergeCellsBtn.Text = "取消合并单元格";
            // 
            // CellsToolStripEx
            // 
            this.CellsToolStripEx.CollapsedDropDownButtonText = "Styles";
            this.CellsToolStripEx.DefaultDropDownDirection = System.Windows.Forms.ToolStripDropDownDirection.BelowRight;
            this.CellsToolStripEx.Dock = System.Windows.Forms.DockStyle.None;
            this.CellsToolStripEx.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.CellsToolStripEx.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.CellsToolStripEx.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.CellsToolStripEx.Image = ((System.Drawing.Image)(resources.GetObject("CellsToolStripEx.Image")));
            this.CellsToolStripEx.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.InsertCellBtn,
            this.DeleteCellBtn,
            this.FormatBtn});
            this.CellsToolStripEx.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.CellsToolStripEx.Location = new System.Drawing.Point(679, 1);
            this.CellsToolStripEx.Name = "CellsToolStripEx";
            this.CellsToolStripEx.Office12Mode = false;
            this.CellsToolStripEx.Size = new System.Drawing.Size(141, 91);
            this.CellsToolStripEx.TabIndex = 17;
            this.CellsToolStripEx.Text = "细胞";
            // 
            // InsertCellBtn
            // 
            this.superAccelerator1.SetAccelerator(this.InsertCellBtn, "IS");
            this.InsertCellBtn.Image = ((System.Drawing.Image)(resources.GetObject("InsertCellBtn.Image")));
            this.InsertCellBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.InsertCellBtn.Name = "InsertCellBtn";
            this.InsertCellBtn.Size = new System.Drawing.Size(45, 74);
            this.InsertCellBtn.Text = "插\r\n细胞";
            this.InsertCellBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.InsertCellBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // DeleteCellBtn
            // 
            this.superAccelerator1.SetAccelerator(this.DeleteCellBtn, "RE");
            this.DeleteCellBtn.Image = ((System.Drawing.Image)(resources.GetObject("DeleteCellBtn.Image")));
            this.DeleteCellBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DeleteCellBtn.Name = "DeleteCellBtn";
            this.DeleteCellBtn.Size = new System.Drawing.Size(45, 74);
            this.DeleteCellBtn.Text = "删除\r\n细胞";
            this.DeleteCellBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.DeleteCellBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // FormatBtn
            // 
            this.superAccelerator1.SetAccelerator(this.FormatBtn, "FR");
            this.FormatBtn.Image = ((System.Drawing.Image)(resources.GetObject("FormatBtn.Image")));
            this.FormatBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.FormatBtn.Name = "FormatBtn";
            this.FormatBtn.Size = new System.Drawing.Size(44, 74);
            this.FormatBtn.Text = "格式";
            this.FormatBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.FormatBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripTabItem2
            // 
            this.superAccelerator1.SetAccelerator(this.toolStripTabItem2, "D");
            this.toolStripTabItem2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripTabItem2.Name = "toolStripTabItem2";
            // 
            // ribbonControlAdv1.ribbonPanel2
            // 
            this.toolStripTabItem2.Panel.Controls.Add(this.toolStripEx12);
            this.toolStripTabItem2.Panel.Controls.Add(this.toolStripEx11);
            this.toolStripTabItem2.Panel.Controls.Add(this.toolStripEx10);
            this.toolStripTabItem2.Panel.Controls.Add(this.toolStripEx9);
            this.toolStripTabItem2.Panel.Name = "ribbonPanel2";
            this.toolStripTabItem2.Panel.ScrollPosition = 0;
            this.toolStripTabItem2.Panel.TabIndex = 3;
            this.toolStripTabItem2.Panel.Text = "啊不额从";
            this.toolStripTabItem2.Position = 1;
            this.toolStripTabItem2.Size = new System.Drawing.Size(76, 25);
            this.toolStripTabItem2.Tag = "2";
            this.toolStripTabItem2.Text = "啊不额从";
            // 
            // toolStripEx12
            // 
            this.toolStripEx12.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStripEx12.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.toolStripEx12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.toolStripEx12.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripEx12.Image = null;
            this.toolStripEx12.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton18});
            this.toolStripEx12.Location = new System.Drawing.Point(0, 1);
            this.toolStripEx12.Name = "toolStripEx12";
            this.toolStripEx12.Office12Mode = false;
            this.toolStripEx12.Size = new System.Drawing.Size(55, 91);
            this.toolStripEx12.TabIndex = 11;
            this.toolStripEx12.Text = "链接";
            // 
            // toolStripButton18
            // 
            this.superAccelerator1.SetAccelerator(this.toolStripButton18, "HL");
            this.toolStripButton18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.toolStripButton18.Image = global::RibbonMerging.Properties.Resources.Hyperlink;
            this.toolStripButton18.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton18.Name = "toolStripButton18";
            this.toolStripButton18.Size = new System.Drawing.Size(48, 74);
            this.toolStripButton18.Text = "超链接";
            this.toolStripButton18.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolStripButton18.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripEx11
            // 
            this.toolStripEx11.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStripEx11.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.toolStripEx11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.toolStripEx11.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripEx11.Image = null;
            this.toolStripEx11.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton16,
            this.toolStripButton17});
            this.toolStripEx11.Location = new System.Drawing.Point(57, 1);
            this.toolStripEx11.Name = "toolStripEx11";
            this.toolStripEx11.Office12Mode = false;
            this.toolStripEx11.Size = new System.Drawing.Size(111, 91);
            this.toolStripEx11.TabIndex = 10;
            this.toolStripEx11.Text = "大纲";
            // 
            // toolStripButton16
            // 
            this.superAccelerator1.SetAccelerator(this.toolStripButton16, "GP");
            this.toolStripButton16.AutoSize = false;
            this.toolStripButton16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.toolStripButton16.Image = global::RibbonMerging.Properties.Resources.Group;
            this.toolStripButton16.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton16.Name = "toolStripButton16";
            this.toolStripButton16.Size = new System.Drawing.Size(44, 74);
            this.toolStripButton16.Text = "新集团";
            this.toolStripButton16.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolStripButton16.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripButton17
            // 
            this.superAccelerator1.SetAccelerator(this.toolStripButton17, "UG");
            this.toolStripButton17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.toolStripButton17.Image = global::RibbonMerging.Properties.Resources.UnGroup;
            this.toolStripButton17.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton17.Name = "toolStripButton17";
            this.toolStripButton17.Size = new System.Drawing.Size(60, 74);
            this.toolStripButton17.Text = "取消组合";
            this.toolStripButton17.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolStripButton17.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripEx10
            // 
            this.toolStripEx10.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStripEx10.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.toolStripEx10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.toolStripEx10.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripEx10.Image = null;
            this.toolStripEx10.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton15});
            this.toolStripEx10.Location = new System.Drawing.Point(170, 1);
            this.toolStripEx10.Name = "toolStripEx10";
            this.toolStripEx10.Office12Mode = false;
            this.toolStripEx10.Size = new System.Drawing.Size(66, 91);
            this.toolStripEx10.TabIndex = 9;
            this.toolStripEx10.Text = "数据";
            // 
            // toolStripButton15
            // 
            this.superAccelerator1.SetAccelerator(this.toolStripButton15, "DT");
            this.toolStripButton15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.toolStripButton15.Image = global::RibbonMerging.Properties.Resources.DataValidation;
            this.toolStripButton15.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton15.Name = "toolStripButton15";
            this.toolStripButton15.Size = new System.Drawing.Size(59, 74);
            this.toolStripButton15.Text = "数据瓦利";
            this.toolStripButton15.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolStripButton15.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripEx9
            // 
            this.toolStripEx9.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStripEx9.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.toolStripEx9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.toolStripEx9.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripEx9.Image = null;
            this.toolStripEx9.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton14});
            this.toolStripEx9.Location = new System.Drawing.Point(238, 1);
            this.toolStripEx9.Name = "toolStripEx9";
            this.toolStripEx9.Office12Mode = false;
            this.toolStripEx9.Size = new System.Drawing.Size(78, 91);
            this.toolStripEx9.TabIndex = 8;
            this.toolStripEx9.Text = "公式";
            // 
            // toolStripButton14
            // 
            this.superAccelerator1.SetAccelerator(this.toolStripButton14, "NC");
            this.toolStripButton14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.toolStripButton14.Image = global::RibbonMerging.Properties.Resources.NameManager;
            this.toolStripButton14.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton14.Name = "toolStripButton14";
            this.toolStripButton14.Size = new System.Drawing.Size(71, 74);
            this.toolStripButton14.Text = "名称管理器";
            this.toolStripButton14.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolStripButton14.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripTabItem3
            // 
            this.superAccelerator1.SetAccelerator(this.toolStripTabItem3, "V");
            this.toolStripTabItem3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripTabItem3.Name = "toolStripTabItem3";
            // 
            // ribbonControlAdv1.ribbonPanel3
            // 
            this.toolStripTabItem3.Panel.Controls.Add(this.themesToolStripExt);
            this.toolStripTabItem3.Panel.Controls.Add(this.toolStripEx7);
            this.toolStripTabItem3.Panel.Name = "ribbonPanel3";
            this.toolStripTabItem3.Panel.ScrollPosition = 0;
            this.toolStripTabItem3.Panel.TabIndex = 4;
            this.toolStripTabItem3.Panel.Text = "视图";
            this.toolStripTabItem3.Position = 2;
            this.toolStripTabItem3.Size = new System.Drawing.Size(53, 25);
            this.toolStripTabItem3.Tag = "3";
            this.toolStripTabItem3.Text = "视图";
            // 
            // themesToolStripExt
            // 
            this.themesToolStripExt.DefaultDropDownDirection = System.Windows.Forms.ToolStripDropDownDirection.BelowRight;
            this.themesToolStripExt.Dock = System.Windows.Forms.DockStyle.None;
            this.themesToolStripExt.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.themesToolStripExt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.themesToolStripExt.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.themesToolStripExt.Image = ((System.Drawing.Image)(resources.GetObject("themesToolStripExt.Image")));
            this.themesToolStripExt.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton28,
            this.toolStripButton29});
            this.themesToolStripExt.Location = new System.Drawing.Point(0, 1);
            this.themesToolStripExt.Name = "themesToolStripExt";
            this.themesToolStripExt.Office12Mode = false;
            this.themesToolStripExt.ShowLauncher = false;
            this.themesToolStripExt.Size = new System.Drawing.Size(92, 91);
            this.themesToolStripExt.TabIndex = 5;
            this.themesToolStripExt.Text = "注释";
            // 
            // toolStripButton28
            // 
            this.superAccelerator1.SetAccelerator(this.toolStripButton28, "NC");
            this.toolStripButton28.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.toolStripButton28.Image = global::RibbonMerging.Properties.Resources.NewComment;
            this.toolStripButton28.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton28.Name = "toolStripButton28";
            this.toolStripButton28.Size = new System.Drawing.Size(49, 75);
            this.toolStripButton28.Text = "新评论";
            this.toolStripButton28.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolStripButton28.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripButton29
            // 
            this.superAccelerator1.SetAccelerator(this.toolStripButton29, "DE");
            this.toolStripButton29.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButton29.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.toolStripButton29.Image = global::RibbonMerging.Properties.Resources.Delete;
            this.toolStripButton29.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton29.Name = "toolStripButton29";
            this.toolStripButton29.Size = new System.Drawing.Size(37, 74);
            this.toolStripButton29.Text = "删除";
            this.toolStripButton29.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripEx7
            // 
            this.toolStripEx7.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStripEx7.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.toolStripEx7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.toolStripEx7.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripEx7.Image = null;
            this.toolStripEx7.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton30,
            this.toolStripButton31});
            this.toolStripEx7.Location = new System.Drawing.Point(94, 1);
            this.toolStripEx7.Name = "toolStripEx7";
            this.toolStripEx7.Office12Mode = false;
            this.toolStripEx7.Size = new System.Drawing.Size(151, 91);
            this.toolStripEx7.TabIndex = 4;
            this.toolStripEx7.Text = "床单";
            // 
            // toolStripButton30
            // 
            this.superAccelerator1.SetAccelerator(this.toolStripButton30, "PS");
            this.toolStripButton30.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButton30.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.toolStripButton30.Image = global::RibbonMerging.Properties.Resources.ProtectSheet;
            this.toolStripButton30.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton30.Name = "toolStripButton30";
            this.toolStripButton30.Size = new System.Drawing.Size(72, 74);
            this.toolStripButton30.Text = "保护工作表";
            this.toolStripButton30.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolStripButton30.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripButton31
            // 
            this.superAccelerator1.SetAccelerator(this.toolStripButton31, "PW");
            this.toolStripButton31.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButton31.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.toolStripButton31.Image = global::RibbonMerging.Properties.Resources.ProtectWorkbook;
            this.toolStripButton31.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton31.Name = "toolStripButton31";
            this.toolStripButton31.Size = new System.Drawing.Size(72, 74);
            this.toolStripButton31.Text = "保护工作簿";
            this.toolStripButton31.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolStripButton31.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(114, 13);
            this.toolStripLabel1.Text = "Recent Documents";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(98, 2);
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(114, 17);
            this.toolStripButton5.Text = "Document1.doc";
            this.toolStripButton5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
         
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Padding = new System.Windows.Forms.Padding(4);
            this.toolStripButton2.Size = new System.Drawing.Size(69, 36);
            this.toolStripButton2.Text = "New";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
           
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Padding = new System.Windows.Forms.Padding(4);
            this.toolStripButton3.Size = new System.Drawing.Size(69, 36);
            this.toolStripButton3.Text = "Open";
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
           
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Padding = new System.Windows.Forms.Padding(4);
            this.toolStripButton4.Size = new System.Drawing.Size(69, 36);
            this.toolStripButton4.Text = "Save";
            // 
            // statusStripEx1
            // 
            this.statusStripEx1.BackColor = System.Drawing.Color.White;
            this.statusStripEx1.BeforeTouchSize = new System.Drawing.Size(987, 27);
            this.statusStripEx1.Dock = Syncfusion.Windows.Forms.Tools.DockStyleEx.Fill;
            this.statusStripEx1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusStripLabel1,
            this.trackBarItem1,
            this.toolStripStatusLabel1});
            this.statusStripEx1.Location = new System.Drawing.Point(0, 0);
            this.statusStripEx1.MetroColor = System.Drawing.Color.Empty;
            this.statusStripEx1.Name = "statusStripEx1";
            this.statusStripEx1.Size = new System.Drawing.Size(987, 27);
            this.statusStripEx1.TabIndex = 2;
            this.statusStripEx1.Text = "statusStripEx1";
            // 
            // statusStripLabel1
            // 
            this.statusStripLabel1.Margin = new System.Windows.Forms.Padding(0, 4, 0, 2);
            this.statusStripLabel1.Name = "statusStripLabel1";
            this.statusStripLabel1.Size = new System.Drawing.Size(199, 15);
            this.statusStripLabel1.Text = "请点击“新建文件”创建一个子窗口";
            // 
            // trackBarItem1
            // 
            this.trackBarItem1.Maximum = 10;
            this.trackBarItem1.Name = "trackBarItem1";
            this.trackBarItem1.Size = new System.Drawing.Size(250, 20);
            this.trackBarItem1.Text = "trackBarItem1";
            this.trackBarItem1.Value = 5;
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.ForeColor = System.Drawing.Color.White;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(35, 15);
            this.toolStripStatusLabel1.Text = "100%";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.statusStripEx1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(1, 519);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(987, 27);
            this.panel2.TabIndex = 9;
            // 
            // imageList1
            // 
#if NET9_0_OR_GREATER
            LoadImages(this.imageList1, "ImageList1", 4);
#else
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
#endif
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "save as.png");
            this.imageList1.Images.SetKeyName(1, "Save32.png");
            this.imageList1.Images.SetKeyName(2, "Icon-01.png");
            this.imageList1.Images.SetKeyName(3, "Icon-11.png");
            // 
            // gridControl1
            // 
            this.gridControl1.AlphaBlendSelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(94)))), ((int)(((byte)(171)))), ((int)(((byte)(222)))));
            this.gridControl1.ColCount = 100;
            this.gridControl1.DefaultGridBorderStyle = Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid;
            this.gridControl1.DefaultRowHeight = 20;
            this.gridControl1.FillSplitterPane = true;
            this.gridControl1.GridOfficeScrollBars = Syncfusion.Windows.Forms.OfficeScrollBars.Metro;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MetroScrollBars = true;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Properties.ForceImmediateRepaint = false;
            this.gridControl1.Properties.GridLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.gridControl1.Properties.MarkColHeader = false;
            this.gridControl1.Properties.MarkRowHeader = false;
            this.gridControl1.RowCount = 100;
            this.gridControl1.RowHeightEntries.AddRange(new Syncfusion.Windows.Forms.Grid.GridRowHeight[] {
            new Syncfusion.Windows.Forms.Grid.GridRowHeight(0, 29)});
            this.gridControl1.SerializeCellsBehavior = Syncfusion.Windows.Forms.Grid.GridSerializeCellsBehavior.SerializeAsRangeStylesIntoCode;
            this.gridControl1.ShowCurrentCellBorderBehavior = Syncfusion.Windows.Forms.Grid.GridShowCurrentCellBorder.AlwaysVisible;
            this.gridControl1.Size = new System.Drawing.Size(962, 335);
            this.gridControl1.SmartSizeBox = false;
            this.gridControl1.Text = "gridControl1";
            this.gridControl1.UseRightToLeftCompatibleTextBox = true;
            // 
            // tabBarSplitterControl2
            // 
            this.tabBarSplitterControl2.ActivePageBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(157)))), ((int)(((byte)(217)))));
            this.tabBarSplitterControl2.BeforeTouchSize = new System.Drawing.Size(987, 360);
            this.tabBarSplitterControl2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tabBarSplitterControl2.Controls.Add(this.tabBarPage1);
            this.tabBarSplitterControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabBarSplitterControl2.EnabledColor = System.Drawing.SystemColors.WindowText;
            this.tabBarSplitterControl2.EnableOffice2013Style = true;
            this.tabBarSplitterControl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabBarSplitterControl2.Location = new System.Drawing.Point(1, 159);
            this.tabBarSplitterControl2.Name = "tabBarSplitterControl2";
            this.tabBarSplitterControl2.ScrollButtons = Syncfusion.Windows.Forms.DisplayArrowButtons.Single;
            this.tabBarSplitterControl2.Size = new System.Drawing.Size(987, 360);
            this.tabBarSplitterControl2.SizeFactor = 1.5D;
            this.tabBarSplitterControl2.SplitBars = ((Syncfusion.Windows.Forms.DynamicSplitBars)((Syncfusion.Windows.Forms.DynamicSplitBars.SplitRows | Syncfusion.Windows.Forms.DynamicSplitBars.SplitColumns)));
            this.tabBarSplitterControl2.Style = Syncfusion.Windows.Forms.TabBarSplitterStyle.Metro;
            this.tabBarSplitterControl2.TabFolderDelta = 11;
            this.tabBarSplitterControl2.TabIndex = 13;
            this.tabBarSplitterControl2.Text = "tabBarSplitterControl2";
            this.tabBarSplitterControl2.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.tabBarSplitterControl1_ControlAdded);
            // 
            // tabBarPage1
            // 
            this.tabBarPage1.Controls.Add(this.gridControl1);
            this.tabBarPage1.Controls.Add(this.splashPanel1);
            this.tabBarPage1.Location = new System.Drawing.Point(0, 0);
            this.tabBarPage1.Name = "tabBarPage1";
            this.tabBarPage1.SplitBars = ((Syncfusion.Windows.Forms.DynamicSplitBars)((Syncfusion.Windows.Forms.DynamicSplitBars.SplitRows | Syncfusion.Windows.Forms.DynamicSplitBars.SplitColumns)));
            this.tabBarPage1.TabBackColor = System.Drawing.SystemColors.Control;
            this.tabBarPage1.TabBarColor = System.Drawing.Color.Empty;
            this.tabBarPage1.TabMaxWidth = 100;
            this.tabBarPage1.Text = "片1";
            this.tabBarPage1.ThemesEnabled = false;
            // 
            // splashPanel1
            // 
            this.splashPanel1.AnimationDirection = Syncfusion.Windows.Forms.Tools.AnimationDirection.Default;
            this.splashPanel1.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.SystemColors.Highlight, System.Drawing.SystemColors.HighlightText);
            this.splashPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("splashPanel1.BackgroundImage")));
            this.splashPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.splashPanel1.BeforeTouchSize = new System.Drawing.Size(430, 230);
            this.splashPanel1.BorderType = Syncfusion.Windows.Forms.Tools.SplashBorderType.None;
            this.splashPanel1.DiscreetLocation = new System.Drawing.Point(0, 0);
            this.splashPanel1.Location = new System.Drawing.Point(460, 586);
            this.splashPanel1.MarqueeDirection = Syncfusion.Windows.Forms.Tools.SplashPanelMarqueeDirection.LeftToRight;
            this.splashPanel1.MarqueePosition = Syncfusion.Windows.Forms.Tools.MarqueePosition.BottomLeft;
            this.splashPanel1.Name = "splashPanel1";
            this.splashPanel1.Size = new System.Drawing.Size(430, 230);
            this.splashPanel1.TabIndex = 8;
            this.splashPanel1.Text = "splashPanel1";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 547);
            this.Controls.Add(this.backStage1);
            this.Controls.Add(this.tabBarSplitterControl2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.ribbonControlAdv1);
            this.HelpButton = true;
            this.HelpButtonImage = ((System.Drawing.Image)(resources.GetObject("$this.HelpButtonImage")));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(1, 0, 1, 1);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "啊呃啊 阿别从";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControlAdv1)).EndInit();
            this.ribbonControlAdv1.ResumeLayout(false);
            this.ribbonControlAdv1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.backStage1)).EndInit();
            this.backStage1.ResumeLayout(false);
            this.backStageTab2.ResumeLayout(false);
            this.backStageTab2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.toolStripTabItem1.Panel.ResumeLayout(false);
            this.toolStripTabItem1.Panel.PerformLayout();
            this.clipboardToolStripExt.ResumeLayout(false);
            this.clipboardToolStripExt.PerformLayout();
            this.fontToolStripExt.ResumeLayout(false);
            this.fontToolStripExt.PerformLayout();
            this.AlignmentToolStripEx.ResumeLayout(false);
            this.AlignmentToolStripEx.PerformLayout();
            this.CellsToolStripEx.ResumeLayout(false);
            this.CellsToolStripEx.PerformLayout();
            this.toolStripTabItem2.Panel.ResumeLayout(false);
            this.toolStripTabItem2.Panel.PerformLayout();
            this.toolStripEx12.ResumeLayout(false);
            this.toolStripEx12.PerformLayout();
            this.toolStripEx11.ResumeLayout(false);
            this.toolStripEx11.PerformLayout();
            this.toolStripEx10.ResumeLayout(false);
            this.toolStripEx10.PerformLayout();
            this.toolStripEx9.ResumeLayout(false);
            this.toolStripEx9.PerformLayout();
            this.toolStripTabItem3.Panel.ResumeLayout(false);
            this.toolStripTabItem3.Panel.PerformLayout();
            this.themesToolStripExt.ResumeLayout(false);
            this.themesToolStripExt.PerformLayout();
            this.toolStripEx7.ResumeLayout(false);
            this.toolStripEx7.PerformLayout();
            this.statusStripEx1.ResumeLayout(false);
            this.statusStripEx1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            this.tabBarSplitterControl2.ResumeLayout(false);
            this.tabBarPage1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Syncfusion.Windows.Forms.Tools.RibbonControlAdv ribbonControlAdv1;
        private Syncfusion.Windows.Forms.Tools.ToolStripTabItem toolStripTabItem1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private Syncfusion.Windows.Forms.Tools.StatusStripEx statusStripEx1;
        private Syncfusion.Windows.Forms.Tools.StatusStripLabel statusStripLabel1;
        private Syncfusion.Windows.Forms.Tools.ToolStripEx clipboardToolStripExt;
        private Syncfusion.Windows.Forms.Tools.ToolStripPanelItem toolStripPanelItem15;
        private System.Windows.Forms.ToolStripButton toolStripBtnPaste;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownBtnPaste;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteSpecialToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteAsHyperlinkToolStripMenuItem;
        private Syncfusion.Windows.Forms.Tools.ToolStripPanelItem toolStripPanelItem1;
        private System.Windows.Forms.ToolStripButton toolStripBtnCut;
        private System.Windows.Forms.ToolStripButton toolStripBtnCopy;
        private Syncfusion.Windows.Forms.Tools.ToolStripEx fontToolStripExt;
        private Syncfusion.Windows.Forms.Tools.ToolStripPanelItem toolStripPanelItem2;
        private System.Windows.Forms.ToolStripComboBox toolStripFontfaceComboBox;
        private System.Windows.Forms.ToolStripComboBox toolStripFontSizeComboBox;
        private System.Windows.Forms.ToolStripButton growfontToolStripBtn;
        private System.Windows.Forms.ToolStripButton shrinkfontToolStripBtn;
        private Syncfusion.Windows.Forms.BackStageView backStageView1;
        private Syncfusion.Windows.Forms.BackStage backStage1;
        private Syncfusion.Windows.Forms.BackStageTab backStageTab2;
        private Syncfusion.Windows.Forms.BackStageButton backStageButton1;
        private System.Windows.Forms.Panel panel2;
        private Syncfusion.Windows.Forms.Tools.TrackBarItem trackBarItem1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ImageList imageList1;
        private Syncfusion.Windows.Forms.Tools.ToolStripTabItem toolStripTabItem2;
        private Syncfusion.Windows.Forms.Tools.ToolStripEx toolStripEx12;
        private System.Windows.Forms.ToolStripButton toolStripButton18;
        private Syncfusion.Windows.Forms.Tools.ToolStripEx toolStripEx11;
        private System.Windows.Forms.ToolStripButton toolStripButton16;
        private System.Windows.Forms.ToolStripButton toolStripButton17;
        private Syncfusion.Windows.Forms.Tools.ToolStripEx toolStripEx10;
        private System.Windows.Forms.ToolStripButton toolStripButton15;
        private Syncfusion.Windows.Forms.Tools.ToolStripEx toolStripEx9;
        private System.Windows.Forms.ToolStripButton toolStripButton14;
        private Syncfusion.Windows.Forms.Tools.ToolStripTabItem toolStripTabItem3;
        private Syncfusion.Windows.Forms.Tools.ToolStripEx themesToolStripExt;
        private System.Windows.Forms.ToolStripButton toolStripButton28;
        private System.Windows.Forms.ToolStripButton toolStripButton29;
        private Syncfusion.Windows.Forms.Tools.ToolStripEx toolStripEx7;
        private System.Windows.Forms.ToolStripButton toolStripButton30;
        private System.Windows.Forms.ToolStripButton toolStripButton31;
        private Syncfusion.Windows.Forms.Grid.GridControl gridControl1;
        private Syncfusion.Windows.Forms.TabBarSplitterControl tabBarSplitterControl2;
        private Syncfusion.Windows.Forms.TabBarPage tabBarPage1;
        private Syncfusion.Windows.Forms.Tools.ToolStripEx CellsToolStripEx;
        private System.Windows.Forms.ToolStripDropDownButton InsertCellBtn;
        private System.Windows.Forms.ToolStripDropDownButton DeleteCellBtn;
        private System.Windows.Forms.ToolStripDropDownButton FormatBtn;
        private Syncfusion.Windows.Forms.Tools.ToolStripEx AlignmentToolStripEx;
        private Syncfusion.Windows.Forms.Tools.ToolStripPanelItem toolStripPanelItem7;
        private Syncfusion.Windows.Forms.Tools.ToolStripPanelItem toolStripPanelItem8;
        private System.Windows.Forms.ToolStripButton TopAlignBtn;
        private System.Windows.Forms.ToolStripButton MiddleAlignBtn;
        private System.Windows.Forms.ToolStripButton BottomAlignBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton IncreaseIndentBtn;
        private Syncfusion.Windows.Forms.Tools.ToolStripPanelItem toolStripPanelItem9;
        private System.Windows.Forms.ToolStripButton AlignLeftBtn;
        private System.Windows.Forms.ToolStripButton CenterBtn;
        private System.Windows.Forms.ToolStripButton AlignRightBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton DecreaseIndentBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private Syncfusion.Windows.Forms.Tools.ToolStripPanelItem toolStripPanelItem12;
        private System.Windows.Forms.ToolStripButton WrapTextBtn;
        private System.Windows.Forms.ToolStripDropDownButton MergeCenterBtn;
        private System.Windows.Forms.ToolStripMenuItem MergeAndCenter;
        private System.Windows.Forms.ToolStripMenuItem MergeAcrossBtn;
        private System.Windows.Forms.ToolStripMenuItem MergeCellsBtn;
        private System.Windows.Forms.ToolStripMenuItem UnmergeCellsBtn;
        private Syncfusion.Windows.Forms.Tools.ToolStripPanelItem toolStripPanelItem4;
        private System.Windows.Forms.ToolStripButton boldToolstripBtn;
        private System.Windows.Forms.ToolStripButton italicToolStripBtn;
        private System.Windows.Forms.ToolStripSplitButton underlineToolStripSplitBtn;
        private System.Windows.Forms.ToolStripMenuItem moreUnderlinesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem underlineColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem automaticToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem moreColorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripDropDownButton BottomBorderBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripDropDownButton FillColorsBtn;
        private System.Windows.Forms.ToolStripDropDownButton FontColorBtn;
        private Syncfusion.Windows.Forms.BackStageButton backStageButton2;
        private Syncfusion.Windows.Forms.BackStageButton backStageButton3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private Syncfusion.Windows.Forms.Tools.SuperAccelerator superAccelerator1;
        private Syncfusion.Windows.Forms.Tools.SplashPanel splashPanel1;
    }
}


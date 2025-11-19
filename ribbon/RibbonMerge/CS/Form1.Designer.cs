#region Copyright Syncfusion Inc. 2001 - 2014
// Copyright Syncfusion Inc. 2001 - 2014. All rights reserved.
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Syncfusion.Windows.Forms.Tools.ToolTipInfo toolTipInfo1 = new Syncfusion.Windows.Forms.Tools.ToolTipInfo();
            Syncfusion.Windows.Forms.Tools.ToolTipInfo toolTipInfo2 = new Syncfusion.Windows.Forms.Tools.ToolTipInfo();
            Syncfusion.Windows.Forms.Tools.ToolTipInfo toolTipInfo3 = new Syncfusion.Windows.Forms.Tools.ToolTipInfo();
            Syncfusion.Windows.Forms.Tools.ToolTipInfo toolTipInfo4 = new Syncfusion.Windows.Forms.Tools.ToolTipInfo();
            Syncfusion.Windows.Forms.Tools.ToolTipInfo toolTipInfo5 = new Syncfusion.Windows.Forms.Tools.ToolTipInfo();
            Syncfusion.Windows.Forms.Tools.ToolTipInfo toolTipInfo6 = new Syncfusion.Windows.Forms.Tools.ToolTipInfo();
            Syncfusion.Windows.Forms.Tools.ToolTipInfo toolTipInfo7 = new Syncfusion.Windows.Forms.Tools.ToolTipInfo();
            Syncfusion.Windows.Forms.Tools.ToolTipInfo toolTipInfo8 = new Syncfusion.Windows.Forms.Tools.ToolTipInfo();
            Syncfusion.Windows.Forms.Tools.ToolTipInfo toolTipInfo9 = new Syncfusion.Windows.Forms.Tools.ToolTipInfo();
            Syncfusion.Windows.Forms.Tools.ToolTipInfo toolTipInfo10 = new Syncfusion.Windows.Forms.Tools.ToolTipInfo();
            Syncfusion.Windows.Forms.Tools.ToolTipInfo toolTipInfo11 = new Syncfusion.Windows.Forms.Tools.ToolTipInfo();
            Syncfusion.Windows.Forms.Tools.ToolTipInfo toolTipInfo12 = new Syncfusion.Windows.Forms.Tools.ToolTipInfo();
            Syncfusion.Windows.Forms.Tools.ToolTipInfo toolTipInfo13 = new Syncfusion.Windows.Forms.Tools.ToolTipInfo();
            Syncfusion.Windows.Forms.Tools.ToolTipInfo toolTipInfo14 = new Syncfusion.Windows.Forms.Tools.ToolTipInfo();
            Syncfusion.Windows.Forms.Tools.ToolTipInfo toolTipInfo15 = new Syncfusion.Windows.Forms.Tools.ToolTipInfo();
            Syncfusion.Windows.Forms.Tools.ToolTipInfo toolTipInfo16 = new Syncfusion.Windows.Forms.Tools.ToolTipInfo();
            Syncfusion.Windows.Forms.Tools.ToolTipInfo toolTipInfo17 = new Syncfusion.Windows.Forms.Tools.ToolTipInfo();
            Syncfusion.Windows.Forms.Tools.ToolTipInfo toolTipInfo18 = new Syncfusion.Windows.Forms.Tools.ToolTipInfo();
            Syncfusion.Windows.Forms.Tools.ToolTipInfo toolTipInfo19 = new Syncfusion.Windows.Forms.Tools.ToolTipInfo();
            Syncfusion.Windows.Forms.Tools.ToolTipInfo toolTipInfo20 = new Syncfusion.Windows.Forms.Tools.ToolTipInfo();
            Syncfusion.Windows.Forms.Tools.ToolTipInfo toolTipInfo21 = new Syncfusion.Windows.Forms.Tools.ToolTipInfo();
            Syncfusion.Windows.Forms.Tools.ToolTipInfo toolTipInfo22 = new Syncfusion.Windows.Forms.Tools.ToolTipInfo();
            Syncfusion.Windows.Forms.Tools.ToolTipInfo toolTipInfo23 = new Syncfusion.Windows.Forms.Tools.ToolTipInfo();
            Syncfusion.Windows.Forms.Tools.ToolTipInfo toolTipInfo24 = new Syncfusion.Windows.Forms.Tools.ToolTipInfo();
            Syncfusion.Windows.Forms.Tools.ToolTipInfo toolTipInfo25 = new Syncfusion.Windows.Forms.Tools.ToolTipInfo();
            Syncfusion.Windows.Forms.Tools.ToolTipInfo toolTipInfo26 = new Syncfusion.Windows.Forms.Tools.ToolTipInfo();
            this.ribbonControlAdv1 = new Syncfusion.Windows.Forms.Tools.RibbonControlAdv();
            this.backStageView1 = new Syncfusion.Windows.Forms.BackStageView(this.components);
            this.backStage1 = new Syncfusion.Windows.Forms.BackStage();
            this.backStageTab2 = new Syncfusion.Windows.Forms.BackStageTab();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.backStageButton2 = new Syncfusion.Windows.Forms.BackStageButton();
            this.backStageButton3 = new Syncfusion.Windows.Forms.BackStageButton();
            this.backStageButton1 = new Syncfusion.Windows.Forms.BackStageButton();
            this.toolStripTabItem1 = new Syncfusion.Windows.Forms.Tools.ToolStripTabItem();
            this.clipboardToolStripExt = new Syncfusion.Windows.Forms.Tools.ToolStripEx();
            this.toolStripBtnPaste = new System.Windows.Forms.ToolStripButton();
            this.toolStripPanelItem1 = new Syncfusion.Windows.Forms.Tools.ToolStripPanelItem();
            this.toolStripBtnCut = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnCopy = new System.Windows.Forms.ToolStripButton();
            this.fontToolStripExt = new Syncfusion.Windows.Forms.Tools.ToolStripEx();
            this.toolStripPanelItem2 = new Syncfusion.Windows.Forms.Tools.ToolStripPanelItem();
            this.toolStripFontfaceComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripFontSizeComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripPanelItem3 = new Syncfusion.Windows.Forms.Tools.ToolStripPanelItem();
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
            this.toolStripEx5 = new Syncfusion.Windows.Forms.Tools.ToolStripEx();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.superAccelerator1 = new Syncfusion.Windows.Forms.Tools.SuperAccelerator(this);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.superToolTip1 = new Syncfusion.Windows.Forms.Tools.SuperToolTip(this);
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControlAdv1)).BeginInit();
            this.ribbonControlAdv1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.backStage1)).BeginInit();
            this.backStage1.SuspendLayout();
            this.backStageTab2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.toolStripTabItem1.Panel.SuspendLayout();
            this.clipboardToolStripExt.SuspendLayout();
            this.fontToolStripExt.SuspendLayout();
            this.AlignmentToolStripEx.SuspendLayout();
            this.CellsToolStripEx.SuspendLayout();
            this.toolStripEx5.SuspendLayout();
            this.statusStripEx1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ribbonControlAdv1
            // 
            this.ribbonControlAdv1.AutoLayoutToolStrip = true;
            this.ribbonControlAdv1.BackStageView = this.backStageView1;
            this.ribbonControlAdv1.CaptionFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ribbonControlAdv1.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.ribbonControlAdv1.Header.AddMainItem(toolStripTabItem1);
            this.ribbonControlAdv1.Location = new System.Drawing.Point(1, 1);
            this.ribbonControlAdv1.MenuButtonFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ribbonControlAdv1.MenuButtonText = "File";
            this.ribbonControlAdv1.MenuButtonWidth = 56;
            this.ribbonControlAdv1.MenuColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(114)))), ((int)(((byte)(198)))));
            this.ribbonControlAdv1.Name = "ribbonControlAdv1";
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
            this.ribbonControlAdv1.RibbonHeaderImage = Syncfusion.Windows.Forms.Tools.RibbonHeaderImage.None;
            this.ribbonControlAdv1.RibbonStyle = Syncfusion.Windows.Forms.Tools.RibbonStyle.Office2013;
            this.ribbonControlAdv1.SelectedTab = this.toolStripTabItem1;
            this.ribbonControlAdv1.ShowRibbonDisplayOptionButton = true;
            this.ribbonControlAdv1.Size = new System.Drawing.Size(919, 159);
            this.ribbonControlAdv1.SystemText.QuickAccessDialogDropDownName = "Start menu";
            this.ribbonControlAdv1.SystemText.RenameDisplayLabelText = "&Display Name:";
            this.ribbonControlAdv1.TabIndex = 0;
            this.ribbonControlAdv1.Text = "ribbonControlAdv1";
            this.ribbonControlAdv1.ThemeName = "Office2013";
            // 
            // backStageView1
            // 
            this.backStageView1.BackStage = this.backStage1;
            this.backStageView1.HostControl = null;
            this.backStageView1.HostForm = this;
            // 
            // backStage1
            // 
            this.backStage1.ActiveTabForeColor = System.Drawing.Color.Empty;
            this.backStage1.AllowDrop = true;
            this.backStage1.BackStagePanelWidth = 138;
            this.backStage1.BeforeTouchSize = new System.Drawing.Size(919, 493);
            this.backStage1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.backStage1.ChildItemSize = new System.Drawing.Size(80, 140);
            this.backStage1.CloseButtonForeColor = System.Drawing.Color.Empty;
            this.backStage1.CloseButtonHoverForeColor = System.Drawing.Color.Empty;
            this.backStage1.CloseButtonPressedForeColor = System.Drawing.Color.Empty;
            this.backStage1.CloseTabOnMiddleClick = false;
            this.backStage1.Controls.Add(this.backStageTab2);
            this.backStage1.Controls.Add(this.backStageButton2);
            this.backStage1.Controls.Add(this.backStageButton3);
            this.backStage1.Controls.Add(this.backStageButton1);
            this.backStage1.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.backStage1.InActiveTabForeColor = System.Drawing.Color.Empty;
            this.backStage1.ItemSize = new System.Drawing.Size(138, 40);
            this.backStage1.Location = new System.Drawing.Point(0, 0);
            this.backStage1.Name = "backStage1";
            this.backStage1.OfficeColorScheme = Syncfusion.Windows.Forms.Tools.ToolStripEx.ColorScheme.Managed;
            this.backStage1.SeparatorColor = System.Drawing.SystemColors.ControlDark;
            this.backStage1.ShowSeparator = false;
            this.backStage1.Size = new System.Drawing.Size(919, 493);
            this.backStage1.TabIndex = 7;
            this.backStage1.ThemeName = "BackStage2013Renderer";
            this.backStage1.Visible = false;
            // 
            // backStageTab2
            // 
            this.backStageTab2.Accelerator = "";
            this.backStageTab2.BackColor = System.Drawing.Color.White;
            this.backStageTab2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.backStageTab2.Controls.Add(this.pictureBox1);
            this.backStageTab2.Controls.Add(this.label3);
            this.backStageTab2.Controls.Add(this.label2);
            this.backStageTab2.Image = null;
            this.backStageTab2.ImageSize = new System.Drawing.Size(16, 16);
            this.backStageTab2.Location = new System.Drawing.Point(137, 0);
            this.backStageTab2.Name = "backStageTab2";
            this.backStageTab2.Position = new System.Drawing.Point(11, 51);
            this.backStageTab2.ShowCloseButton = true;
            this.backStageTab2.Size = new System.Drawing.Size(782, 493);
            this.backStageTab2.TabIndex = 4;
            this.backStageTab2.Text = "New";
            this.backStageTab2.ThemesEnabled = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(86, 108);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(204, 153);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseEnter += new System.EventHandler(this.panel3_MouseEnter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(129, 268);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Blank workbook";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(70, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "New";
            // 
            // backStageButton2
            // 
            this.backStageButton2.Accelerator = "";
            this.backStageButton2.BackColor = System.Drawing.Color.Transparent;
            this.backStageButton2.Location = new System.Drawing.Point(10, 51);
            this.backStageButton2.Name = "backStageButton2";
            this.backStageButton2.Size = new System.Drawing.Size(110, 25);
            this.backStageButton2.TabIndex = 8;
            this.backStageButton2.Text = "Open";
            // 
            // backStageButton3
            // 
            this.backStageButton3.Accelerator = "";
            this.backStageButton3.BackColor = System.Drawing.Color.Transparent;
            this.backStageButton3.Location = new System.Drawing.Point(10, 76);
            this.backStageButton3.Name = "backStageButton3";
            this.backStageButton3.Size = new System.Drawing.Size(110, 25);
            this.backStageButton3.TabIndex = 9;
            this.backStageButton3.Text = "SaveAs";
            // 
            // backStageButton1
            // 
            this.backStageButton1.Accelerator = "";
            this.backStageButton1.BackColor = System.Drawing.Color.Transparent;
            this.backStageButton1.Location = new System.Drawing.Point(10, 101);
            this.backStageButton1.Name = "backStageButton1";
            this.backStageButton1.Size = new System.Drawing.Size(110, 25);
            this.backStageButton1.TabIndex = 7;
            this.backStageButton1.Text = "Exit";
            // 
            // toolStripTabItem1
            // 
            this.toolStripTabItem1.Name = "toolStripTabItem1";
            this.toolStripTabItem1.Padding = new System.Windows.Forms.Padding(15, 1, 3, 1);
            // 
            // ribbonControlAdv1.ribbonPanel1
            // 
            this.toolStripTabItem1.Panel.Controls.Add(this.clipboardToolStripExt);
            this.toolStripTabItem1.Panel.Controls.Add(this.fontToolStripExt);
            this.toolStripTabItem1.Panel.Controls.Add(this.AlignmentToolStripEx);
            this.toolStripTabItem1.Panel.Controls.Add(this.CellsToolStripEx);
            this.toolStripTabItem1.Panel.Controls.Add(this.toolStripEx5);
            this.toolStripTabItem1.Panel.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.toolStripTabItem1.Panel.Name = "ribbonPanel1";
            this.toolStripTabItem1.Panel.Padding = new System.Windows.Forms.Padding(0, 1, 26, 0);
            this.toolStripTabItem1.Panel.ScrollPosition = 0;
            this.toolStripTabItem1.Panel.TabIndex = 2;
            this.toolStripTabItem1.Panel.Text = "HOME";
            this.toolStripTabItem1.Position = 0;
            this.toolStripTabItem1.Size = new System.Drawing.Size(60, 25);
            this.toolStripTabItem1.Text = "HOME";
            // 
            // clipboardToolStripExt
            // 
            this.superAccelerator1.SetCollapsedDropDownAccelerator(this.clipboardToolStripExt, null);
            this.clipboardToolStripExt.CollapsedDropDownButtonText = "Clipboard";
            this.clipboardToolStripExt.DefaultDropDownDirection = System.Windows.Forms.ToolStripDropDownDirection.BelowRight;
            this.clipboardToolStripExt.Dock = System.Windows.Forms.DockStyle.None;
            this.clipboardToolStripExt.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.clipboardToolStripExt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.clipboardToolStripExt.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.clipboardToolStripExt.Image = ((System.Drawing.Image)(resources.GetObject("clipboardToolStripExt.Image")));
            this.clipboardToolStripExt.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripBtnPaste,
            this.toolStripPanelItem1});
            this.clipboardToolStripExt.LauncherStyle = Syncfusion.Windows.Forms.Tools.LauncherStyle.Office2007;
            this.clipboardToolStripExt.Location = new System.Drawing.Point(0, 1);
            this.clipboardToolStripExt.Name = "clipboardToolStripExt";
            this.clipboardToolStripExt.Office12Mode = false;
            this.clipboardToolStripExt.Size = new System.Drawing.Size(104, 100);
            this.clipboardToolStripExt.TabIndex = 15;
            this.clipboardToolStripExt.Text = "Clipboard";
            // 
            // toolStripBtnPaste
            // 
            this.toolStripBtnPaste.AutoToolTip = false;
            this.toolStripBtnPaste.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripBtnPaste.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.toolStripBtnPaste.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnPaste.Image")));
            this.toolStripBtnPaste.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnPaste.Name = "toolStripBtnPaste";
            this.toolStripBtnPaste.Size = new System.Drawing.Size(38, 83);
            this.toolStripBtnPaste.Text = "Paste";
            this.toolStripBtnPaste.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolStripBtnPaste.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            toolTipInfo1.BackColor = System.Drawing.Color.White;
            toolTipInfo1.Body.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            toolTipInfo1.Body.Size = new System.Drawing.Size(20, 20);
            toolTipInfo1.Body.Text = "\r\nAdd content on the Clipboard to your document.\r\n";
            toolTipInfo1.Footer.Size = new System.Drawing.Size(20, 20);
            toolTipInfo1.Header.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            toolTipInfo1.Header.Size = new System.Drawing.Size(20, 20);
            toolTipInfo1.Header.Text = "Paste(Ctrl + V)";
            this.superToolTip1.SetToolTip(this.toolStripBtnPaste, toolTipInfo1);
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
            this.toolStripPanelItem1.Size = new System.Drawing.Size(57, 86);
            this.toolStripPanelItem1.Text = "toolStripPanelItem1";
            this.toolStripPanelItem1.Transparent = true;
            // 
            // toolStripBtnCut
            // 
            this.toolStripBtnCut.AutoToolTip = false;
            this.toolStripBtnCut.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripBtnCut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.toolStripBtnCut.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnCut.Image")));
            this.toolStripBtnCut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnCut.Margin = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.toolStripBtnCut.Name = "toolStripBtnCut";
            this.toolStripBtnCut.Size = new System.Drawing.Size(45, 24);
            this.toolStripBtnCut.Text = "Cut";
            toolTipInfo2.BackColor = System.Drawing.Color.White;
            toolTipInfo2.Body.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            toolTipInfo2.Body.Size = new System.Drawing.Size(20, 20);
            toolTipInfo2.Body.Text = "\r\nRemove the selection and put it on the clipboard. So that you can use it somewh" +
    "ere else.\r\n";
            toolTipInfo2.Footer.Size = new System.Drawing.Size(20, 20);
            toolTipInfo2.Header.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            toolTipInfo2.Header.Size = new System.Drawing.Size(20, 20);
            toolTipInfo2.Header.Text = "Cut(Ctrl + X)";
            this.superToolTip1.SetToolTip(this.toolStripBtnCut, toolTipInfo2);
            // 
            // toolStripBtnCopy
            // 
            this.toolStripBtnCopy.AutoToolTip = false;
            this.toolStripBtnCopy.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripBtnCopy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.toolStripBtnCopy.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnCopy.Image")));
            this.toolStripBtnCopy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnCopy.Margin = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.toolStripBtnCopy.Name = "toolStripBtnCopy";
            this.toolStripBtnCopy.Size = new System.Drawing.Size(53, 24);
            this.toolStripBtnCopy.Text = "Copy";
            toolTipInfo3.BackColor = System.Drawing.Color.White;
            toolTipInfo3.Body.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            toolTipInfo3.Body.Size = new System.Drawing.Size(20, 20);
            toolTipInfo3.Body.Text = "\r\nPut an area of selection on to the clipboard so that you can place somewhere el" +
    "se on it.\r\n\r\n";
            toolTipInfo3.Footer.Size = new System.Drawing.Size(20, 20);
            toolTipInfo3.Header.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            toolTipInfo3.Header.Size = new System.Drawing.Size(20, 20);
            toolTipInfo3.Header.Text = "Copy (Ctrl + C)";
            this.superToolTip1.SetToolTip(this.toolStripBtnCopy, toolTipInfo3);
            // 
            // fontToolStripExt
            // 
            this.fontToolStripExt.AutoSize = false;
            this.superAccelerator1.SetCollapsedDropDownAccelerator(this.fontToolStripExt, null);
            this.fontToolStripExt.CollapsedDropDownButtonText = "Font";
            this.fontToolStripExt.DefaultDropDownDirection = System.Windows.Forms.ToolStripDropDownDirection.BelowRight;
            this.fontToolStripExt.Dock = System.Windows.Forms.DockStyle.None;
            this.fontToolStripExt.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.fontToolStripExt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.fontToolStripExt.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.fontToolStripExt.GroupedButtons = true;
            this.fontToolStripExt.Image = ((System.Drawing.Image)(resources.GetObject("fontToolStripExt.Image")));
            this.fontToolStripExt.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.fontToolStripExt.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripPanelItem2,
            this.toolStripPanelItem3,
            this.toolStripPanelItem4});
            this.fontToolStripExt.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.fontToolStripExt.Location = new System.Drawing.Point(106, 1);
            this.fontToolStripExt.Name = "fontToolStripExt";
            this.fontToolStripExt.Office12Mode = false;
            this.fontToolStripExt.Padding = new System.Windows.Forms.Padding(0, 5, 1, 0);
            this.fontToolStripExt.Size = new System.Drawing.Size(268, 100);
            this.fontToolStripExt.TabIndex = 14;
            this.fontToolStripExt.Text = "Font";
            // 
            // toolStripPanelItem2
            // 
            this.toolStripPanelItem2.CausesValidation = false;
            this.toolStripPanelItem2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripPanelItem2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.toolStripPanelItem2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripFontfaceComboBox,
            this.toolStripFontSizeComboBox});
            this.toolStripPanelItem2.Name = "toolStripPanelItem2";
            this.toolStripPanelItem2.RowCount = 1;
            this.toolStripPanelItem2.Size = new System.Drawing.Size(200, 28);
            this.toolStripPanelItem2.Text = "toolStripPanelItem2";
            this.toolStripPanelItem2.Transparent = true;
            // 
            // toolStripFontfaceComboBox
            // 
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
            toolTipInfo4.BackColor = System.Drawing.Color.White;
            toolTipInfo4.Body.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            toolTipInfo4.Body.Size = new System.Drawing.Size(20, 20);
            toolTipInfo4.Body.Text = "\r\nPick a new font for your text.\r\n";
            toolTipInfo4.Footer.Size = new System.Drawing.Size(20, 20);
            toolTipInfo4.Header.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            toolTipInfo4.Header.Size = new System.Drawing.Size(20, 20);
            toolTipInfo4.Header.Text = "Font (Ctrl + Shift + F)\r\n";
            this.superToolTip1.SetToolTip(this.toolStripFontfaceComboBox, toolTipInfo4);
            // 
            // toolStripFontSizeComboBox
            // 
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
            toolTipInfo5.BackColor = System.Drawing.Color.White;
            toolTipInfo5.Body.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            toolTipInfo5.Body.Size = new System.Drawing.Size(20, 20);
            toolTipInfo5.Body.Text = "\r\nChange the size of your text.\r\n";
            toolTipInfo5.Footer.Size = new System.Drawing.Size(20, 20);
            toolTipInfo5.Header.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            toolTipInfo5.Header.Size = new System.Drawing.Size(20, 20);
            toolTipInfo5.Header.Text = "Font Size (Ctrl + Shift + P)\r\n";
            this.superToolTip1.SetToolTip(this.toolStripFontSizeComboBox, toolTipInfo5);
            // 
            // toolStripPanelItem3
            // 
            this.toolStripPanelItem3.CausesValidation = false;
            this.toolStripPanelItem3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripPanelItem3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.toolStripPanelItem3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.growfontToolStripBtn,
            this.shrinkfontToolStripBtn});
            this.toolStripPanelItem3.Name = "toolStripPanelItem3";
            this.toolStripPanelItem3.RowCount = 1;
            this.toolStripPanelItem3.Size = new System.Drawing.Size(50, 25);
            this.toolStripPanelItem3.Text = "toolStripPanelItem3";
            this.toolStripPanelItem3.Transparent = true;
            // 
            // growfontToolStripBtn
            // 
            this.growfontToolStripBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.growfontToolStripBtn.Image = ((System.Drawing.Image)(resources.GetObject("growfontToolStripBtn.Image")));
            this.growfontToolStripBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.growfontToolStripBtn.Margin = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.growfontToolStripBtn.Name = "growfontToolStripBtn";
            this.growfontToolStripBtn.Size = new System.Drawing.Size(23, 20);
            this.growfontToolStripBtn.Text = "growfontToolStripBtn";
            toolTipInfo6.BackColor = System.Drawing.Color.White;
            toolTipInfo6.Body.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            toolTipInfo6.Body.Size = new System.Drawing.Size(20, 20);
            toolTipInfo6.Body.Text = "\r\nIncrease your font size a bit bigger.\r\n";
            toolTipInfo6.Footer.Size = new System.Drawing.Size(20, 20);
            toolTipInfo6.Header.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            toolTipInfo6.Header.Size = new System.Drawing.Size(20, 20);
            toolTipInfo6.Header.Text = "Increase Font Size (Ctrl + Shift + >)\r\n";
            this.superToolTip1.SetToolTip(this.growfontToolStripBtn, toolTipInfo6);
            // 
            // shrinkfontToolStripBtn
            // 
            this.shrinkfontToolStripBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.shrinkfontToolStripBtn.Image = ((System.Drawing.Image)(resources.GetObject("shrinkfontToolStripBtn.Image")));
            this.shrinkfontToolStripBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.shrinkfontToolStripBtn.Margin = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.shrinkfontToolStripBtn.Name = "shrinkfontToolStripBtn";
            this.shrinkfontToolStripBtn.Size = new System.Drawing.Size(23, 20);
            this.shrinkfontToolStripBtn.Text = "shrinkfontToolStripBtn";
            toolTipInfo7.BackColor = System.Drawing.Color.White;
            toolTipInfo7.Body.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            toolTipInfo7.Body.Size = new System.Drawing.Size(20, 20);
            toolTipInfo7.Body.Text = "\r\nMake your text a bit smaller.\r\n\r\n";
            toolTipInfo7.Footer.Size = new System.Drawing.Size(20, 20);
            toolTipInfo7.Header.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            toolTipInfo7.Header.Size = new System.Drawing.Size(20, 20);
            toolTipInfo7.Header.Text = "Decrease Font Size (Ctrl + Shift + <)\r\n";
            this.superToolTip1.SetToolTip(this.shrinkfontToolStripBtn, toolTipInfo7);
            // 
            // toolStripPanelItem4
            // 
            this.toolStripPanelItem4.CausesValidation = false;
            this.toolStripPanelItem4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripPanelItem4.ForeColor = System.Drawing.Color.MidnightBlue;
            this.toolStripPanelItem4.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.boldToolstripBtn,
            this.italicToolStripBtn,
            this.underlineToolStripSplitBtn,
            this.toolStripSeparator5,
            this.BottomBorderBtn,
            this.toolStripSeparator6,
            this.FillColorsBtn,
            this.FontColorBtn});
            this.toolStripPanelItem4.Margin = new System.Windows.Forms.Padding(1, 4, 1, 0);
            this.toolStripPanelItem4.Name = "toolStripPanelItem4";
            this.toolStripPanelItem4.Padding = new System.Windows.Forms.Padding(2, 4, 2, 2);
            this.toolStripPanelItem4.RowCount = 1;
            this.toolStripPanelItem4.Size = new System.Drawing.Size(255, 30);
            this.toolStripPanelItem4.Text = "toolStripPanelItem4";
            this.toolStripPanelItem4.Transparent = true;
            // 
            // boldToolstripBtn
            // 
            this.boldToolstripBtn.AutoToolTip = false;
            this.boldToolstripBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.boldToolstripBtn.Image = ((System.Drawing.Image)(resources.GetObject("boldToolstripBtn.Image")));
            this.boldToolstripBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.boldToolstripBtn.Margin = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.boldToolstripBtn.Name = "boldToolstripBtn";
            this.boldToolstripBtn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.boldToolstripBtn.Size = new System.Drawing.Size(30, 20);
            this.boldToolstripBtn.Text = "boldToolstripBtn";
            toolTipInfo8.BackColor = System.Drawing.Color.White;
            toolTipInfo8.Body.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            toolTipInfo8.Body.Size = new System.Drawing.Size(20, 20);
            toolTipInfo8.Body.Text = "\r\nMake your Text Bold.\r\n";
            toolTipInfo8.Footer.Size = new System.Drawing.Size(20, 20);
            toolTipInfo8.Header.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            toolTipInfo8.Header.Size = new System.Drawing.Size(20, 20);
            toolTipInfo8.Header.Text = "Bold (Ctrl + B)\r\n";
            this.superToolTip1.SetToolTip(this.boldToolstripBtn, toolTipInfo8);
            // 
            // italicToolStripBtn
            // 
            this.italicToolStripBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.italicToolStripBtn.Image = ((System.Drawing.Image)(resources.GetObject("italicToolStripBtn.Image")));
            this.italicToolStripBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.italicToolStripBtn.Margin = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.italicToolStripBtn.Name = "italicToolStripBtn";
            this.italicToolStripBtn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.italicToolStripBtn.Size = new System.Drawing.Size(30, 20);
            this.italicToolStripBtn.Text = "italicToolStripBtn";
            toolTipInfo9.BackColor = System.Drawing.Color.White;
            toolTipInfo9.Body.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            toolTipInfo9.Body.Size = new System.Drawing.Size(20, 20);
            toolTipInfo9.Body.Text = "\r\nItalicize your Text.\r\n";
            toolTipInfo9.Footer.Size = new System.Drawing.Size(20, 20);
            toolTipInfo9.Header.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            toolTipInfo9.Header.Size = new System.Drawing.Size(20, 20);
            toolTipInfo9.Header.Text = "Italic (Ctrl + I)\r\n";
            this.superToolTip1.SetToolTip(this.italicToolStripBtn, toolTipInfo9);
            // 
            // underlineToolStripSplitBtn
            // 
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
            toolTipInfo10.BackColor = System.Drawing.Color.White;
            toolTipInfo10.Body.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            toolTipInfo10.Body.Size = new System.Drawing.Size(20, 20);
            toolTipInfo10.Body.Text = "\r\nUnderline your Text.\r\n";
            toolTipInfo10.Footer.Size = new System.Drawing.Size(20, 20);
            toolTipInfo10.Header.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            toolTipInfo10.Header.Size = new System.Drawing.Size(20, 20);
            toolTipInfo10.Header.Text = "Underline (Ctrl + U)";
            this.superToolTip1.SetToolTip(this.underlineToolStripSplitBtn, toolTipInfo10);
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
            this.BottomBorderBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BottomBorderBtn.Image = ((System.Drawing.Image)(resources.GetObject("BottomBorderBtn.Image")));
            this.BottomBorderBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BottomBorderBtn.Margin = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.BottomBorderBtn.Name = "BottomBorderBtn";
            this.BottomBorderBtn.Padding = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.BottomBorderBtn.Size = new System.Drawing.Size(59, 20);
            this.BottomBorderBtn.Text = "Bottom Border";
            toolTipInfo11.BackColor = System.Drawing.Color.White;
            toolTipInfo11.Body.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            toolTipInfo11.Body.Size = new System.Drawing.Size(20, 20);
            toolTipInfo11.Body.Text = "\r\nAdd or remove borders from your selection.\r\n\r\nTo Change the look of the borders" +
    ", check out the options on the Table Tools design tab or use borders and shading" +
    " dialog box.";
            toolTipInfo11.Footer.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            toolTipInfo11.Footer.Image = global::RibbonMerging.Properties.Resources.help;
            toolTipInfo11.Footer.Size = new System.Drawing.Size(20, 20);
            toolTipInfo11.Footer.Text = "Tell Me more\r\n";
            toolTipInfo11.Footer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            toolTipInfo11.Header.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            toolTipInfo11.Header.Size = new System.Drawing.Size(20, 20);
            toolTipInfo11.Header.Text = "Borders\r\n";
            this.superToolTip1.SetToolTip(this.BottomBorderBtn, toolTipInfo11);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Margin = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 23);
            // 
            // FillColorsBtn
            // 
            this.FillColorsBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.FillColorsBtn.Image = ((System.Drawing.Image)(resources.GetObject("FillColorsBtn.Image")));
            this.FillColorsBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.FillColorsBtn.Margin = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.FillColorsBtn.Name = "FillColorsBtn";
            this.FillColorsBtn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.FillColorsBtn.Size = new System.Drawing.Size(39, 20);
            this.FillColorsBtn.Text = "Fill Colors";
            toolTipInfo12.BackColor = System.Drawing.Color.White;
            toolTipInfo12.Body.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            toolTipInfo12.Body.Size = new System.Drawing.Size(20, 20);
            toolTipInfo12.Body.Text = "\r\nChange the color behind the selected text, paragraph or table cell.\r\n\r\nThis is " +
    "especially useful when you want information to jump off the page.\r\n";
            toolTipInfo12.Body.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            toolTipInfo12.Footer.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            toolTipInfo12.Footer.Image = global::RibbonMerging.Properties.Resources.help;
            toolTipInfo12.Footer.Size = new System.Drawing.Size(20, 20);
            toolTipInfo12.Footer.Text = "Tell me more.\r\n";
            toolTipInfo12.Footer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            toolTipInfo12.Header.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            toolTipInfo12.Header.Size = new System.Drawing.Size(20, 20);
            toolTipInfo12.Header.Text = "Shading";
            this.superToolTip1.SetToolTip(this.FillColorsBtn, toolTipInfo12);
            // 
            // FontColorBtn
            // 
            this.FontColorBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.FontColorBtn.Image = ((System.Drawing.Image)(resources.GetObject("FontColorBtn.Image")));
            this.FontColorBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.FontColorBtn.Margin = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.FontColorBtn.Name = "FontColorBtn";
            this.FontColorBtn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.FontColorBtn.Size = new System.Drawing.Size(39, 20);
            this.FontColorBtn.Text = "Font Color";
            toolTipInfo13.BackColor = System.Drawing.Color.White;
            toolTipInfo13.Body.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            toolTipInfo13.Body.Size = new System.Drawing.Size(20, 20);
            toolTipInfo13.Body.Text = "\r\nChange the color of your text.\r\n";
            toolTipInfo13.Footer.Size = new System.Drawing.Size(20, 20);
            toolTipInfo13.Header.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            toolTipInfo13.Header.Size = new System.Drawing.Size(20, 20);
            toolTipInfo13.Header.Text = "Font Color\r\n";
            this.superToolTip1.SetToolTip(this.FontColorBtn, toolTipInfo13);
            // 
            // AlignmentToolStripEx
            // 
            this.superAccelerator1.SetCollapsedDropDownAccelerator(this.AlignmentToolStripEx, null);
            this.AlignmentToolStripEx.CollapsedDropDownButtonText = "Paragraph";
            this.AlignmentToolStripEx.DefaultDropDownDirection = System.Windows.Forms.ToolStripDropDownDirection.BelowRight;
            this.AlignmentToolStripEx.Dock = System.Windows.Forms.DockStyle.None;
            this.AlignmentToolStripEx.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.AlignmentToolStripEx.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.AlignmentToolStripEx.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.AlignmentToolStripEx.GroupedButtons = true;
            this.AlignmentToolStripEx.Image = ((System.Drawing.Image)(resources.GetObject("AlignmentToolStripEx.Image")));
            this.AlignmentToolStripEx.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.AlignmentToolStripEx.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripPanelItem7,
            this.toolStripSeparator4,
            this.toolStripPanelItem12});
            this.AlignmentToolStripEx.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.AlignmentToolStripEx.Location = new System.Drawing.Point(376, 1);
            this.AlignmentToolStripEx.Name = "AlignmentToolStripEx";
            this.AlignmentToolStripEx.Office12Mode = false;
            this.AlignmentToolStripEx.Size = new System.Drawing.Size(236, 100);
            this.AlignmentToolStripEx.TabIndex = 13;
            this.AlignmentToolStripEx.Text = "Alignment";
            // 
            // toolStripPanelItem7
            // 
            this.toolStripPanelItem7.CausesValidation = false;
            this.toolStripPanelItem7.ForeColor = System.Drawing.Color.MidnightBlue;
            this.toolStripPanelItem7.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripPanelItem8,
            this.toolStripPanelItem9});
            this.toolStripPanelItem7.Name = "toolStripPanelItem7";
            this.toolStripPanelItem7.Size = new System.Drawing.Size(106, 65);
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
            this.TopAlignBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TopAlignBtn.Image = ((System.Drawing.Image)(resources.GetObject("TopAlignBtn.Image")));
            this.TopAlignBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TopAlignBtn.Margin = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.TopAlignBtn.Name = "TopAlignBtn";
            this.TopAlignBtn.Size = new System.Drawing.Size(23, 24);
            this.TopAlignBtn.Text = "Top Align";
            toolTipInfo14.BackColor = System.Drawing.Color.White;
            toolTipInfo14.Body.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            toolTipInfo14.Body.Size = new System.Drawing.Size(20, 20);
            toolTipInfo14.Body.Text = "\r\nAlign the content in the top of the page\r\n";
            toolTipInfo14.Footer.Size = new System.Drawing.Size(20, 20);
            toolTipInfo14.Header.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            toolTipInfo14.Header.Size = new System.Drawing.Size(20, 20);
            toolTipInfo14.Header.Text = "Top Align";
            this.superToolTip1.SetToolTip(this.TopAlignBtn, toolTipInfo14);
            // 
            // MiddleAlignBtn
            // 
            this.MiddleAlignBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.MiddleAlignBtn.Image = ((System.Drawing.Image)(resources.GetObject("MiddleAlignBtn.Image")));
            this.MiddleAlignBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.MiddleAlignBtn.Margin = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.MiddleAlignBtn.Name = "MiddleAlignBtn";
            this.MiddleAlignBtn.Size = new System.Drawing.Size(23, 24);
            this.MiddleAlignBtn.Text = "Middle Align";
            toolTipInfo15.BackColor = System.Drawing.Color.White;
            toolTipInfo15.Body.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            toolTipInfo15.Body.Size = new System.Drawing.Size(20, 20);
            toolTipInfo15.Body.Text = "\r\nAlign the content in the center of the page.\r\n";
            toolTipInfo15.Footer.Size = new System.Drawing.Size(20, 20);
            toolTipInfo15.Header.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            toolTipInfo15.Header.Size = new System.Drawing.Size(20, 20);
            toolTipInfo15.Header.Text = "Align Middle";
            this.superToolTip1.SetToolTip(this.MiddleAlignBtn, toolTipInfo15);
            // 
            // BottomAlignBtn
            // 
            this.BottomAlignBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BottomAlignBtn.Image = ((System.Drawing.Image)(resources.GetObject("BottomAlignBtn.Image")));
            this.BottomAlignBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BottomAlignBtn.Margin = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.BottomAlignBtn.Name = "BottomAlignBtn";
            this.BottomAlignBtn.Size = new System.Drawing.Size(23, 24);
            this.BottomAlignBtn.Text = "Bottm Align";
            toolTipInfo16.BackColor = System.Drawing.Color.White;
            toolTipInfo16.Body.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            toolTipInfo16.Body.Size = new System.Drawing.Size(20, 20);
            toolTipInfo16.Body.Text = "\r\nAlign content to the bottom of the page.\r\n";
            toolTipInfo16.Footer.Size = new System.Drawing.Size(20, 20);
            toolTipInfo16.Header.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            toolTipInfo16.Header.Size = new System.Drawing.Size(20, 20);
            toolTipInfo16.Header.Text = "Align Bottom";
            this.superToolTip1.SetToolTip(this.BottomAlignBtn, toolTipInfo16);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Margin = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(4, 24);
            // 
            // IncreaseIndentBtn
            // 
            this.IncreaseIndentBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.IncreaseIndentBtn.Image = ((System.Drawing.Image)(resources.GetObject("IncreaseIndentBtn.Image")));
            this.IncreaseIndentBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.IncreaseIndentBtn.Margin = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.IncreaseIndentBtn.Name = "IncreaseIndentBtn";
            this.IncreaseIndentBtn.Size = new System.Drawing.Size(23, 24);
            this.IncreaseIndentBtn.Text = "Increase Indent";
            toolTipInfo17.BackColor = System.Drawing.Color.White;
            toolTipInfo17.Body.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            toolTipInfo17.Body.Size = new System.Drawing.Size(20, 20);
            toolTipInfo17.Body.Text = "\r\nMove your paragraph farther away from the margin.";
            toolTipInfo17.Footer.Size = new System.Drawing.Size(20, 20);
            toolTipInfo17.Header.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            toolTipInfo17.Header.Size = new System.Drawing.Size(20, 20);
            toolTipInfo17.Header.Text = "Increase Indent\r\n";
            this.superToolTip1.SetToolTip(this.IncreaseIndentBtn, toolTipInfo17);
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
            this.toolStripPanelItem9.Margin = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.toolStripPanelItem9.Name = "toolStripPanelItem9";
            this.toolStripPanelItem9.RowCount = 1;
            this.toolStripPanelItem9.Size = new System.Drawing.Size(102, 28);
            this.toolStripPanelItem9.Text = "toolStripPanelItem9";
            this.toolStripPanelItem9.Transparent = true;
            // 
            // AlignLeftBtn
            // 
            this.AlignLeftBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.AlignLeftBtn.Image = ((System.Drawing.Image)(resources.GetObject("AlignLeftBtn.Image")));
            this.AlignLeftBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AlignLeftBtn.Margin = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.AlignLeftBtn.Name = "AlignLeftBtn";
            this.AlignLeftBtn.Size = new System.Drawing.Size(23, 24);
            this.AlignLeftBtn.Text = "Align Left";
            toolTipInfo18.BackColor = System.Drawing.Color.White;
            toolTipInfo18.Body.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            toolTipInfo18.Body.Size = new System.Drawing.Size(20, 20);
            toolTipInfo18.Body.Text = "\r\nAlign your content with left margin.\r\n\r\nLeft alignment is commonly used for bod" +
    "y text and makes the document easier to read.\r\n";
            toolTipInfo18.Footer.Size = new System.Drawing.Size(20, 20);
            toolTipInfo18.Header.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            toolTipInfo18.Header.Size = new System.Drawing.Size(20, 20);
            toolTipInfo18.Header.Text = "Align Left (Ctrl + L)\r\n";
            this.superToolTip1.SetToolTip(this.AlignLeftBtn, toolTipInfo18);
            // 
            // CenterBtn
            // 
            this.CenterBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.CenterBtn.Image = ((System.Drawing.Image)(resources.GetObject("CenterBtn.Image")));
            this.CenterBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CenterBtn.Margin = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.CenterBtn.Name = "CenterBtn";
            this.CenterBtn.Size = new System.Drawing.Size(23, 24);
            this.CenterBtn.Text = "Center";
            toolTipInfo19.BackColor = System.Drawing.Color.White;
            toolTipInfo19.Body.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            toolTipInfo19.Body.Size = new System.Drawing.Size(20, 20);
            toolTipInfo19.Body.Text = "\r\nCenter your content on the page.\r\n\r\nCenter alignment gives the docuement a form" +
    "al appearance and is often used for cover pages,quotes and sometimes headings.\r\n" +
    "";
            toolTipInfo19.Footer.Size = new System.Drawing.Size(20, 20);
            toolTipInfo19.Header.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            toolTipInfo19.Header.Size = new System.Drawing.Size(20, 20);
            toolTipInfo19.Header.Text = "Center (Ctrl + E)\r\n";
            this.superToolTip1.SetToolTip(this.CenterBtn, toolTipInfo19);
            // 
            // AlignRightBtn
            // 
            this.AlignRightBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.AlignRightBtn.Image = ((System.Drawing.Image)(resources.GetObject("AlignRightBtn.Image")));
            this.AlignRightBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AlignRightBtn.Margin = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.AlignRightBtn.Name = "AlignRightBtn";
            this.AlignRightBtn.Size = new System.Drawing.Size(23, 24);
            this.AlignRightBtn.Text = "AlignRightBtn";
            toolTipInfo20.BackColor = System.Drawing.Color.White;
            toolTipInfo20.Body.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            toolTipInfo20.Body.Size = new System.Drawing.Size(20, 20);
            toolTipInfo20.Body.Text = "\r\nAlign content with the right margin.\r\n\r\nRight alignment is used for small secti" +
    "ons of contents, such as text in header or footer.\r\n";
            toolTipInfo20.Footer.Size = new System.Drawing.Size(20, 20);
            toolTipInfo20.Header.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            toolTipInfo20.Header.Size = new System.Drawing.Size(20, 20);
            toolTipInfo20.Header.Text = "Align Right(Ctrl + R)\r\n";
            this.superToolTip1.SetToolTip(this.AlignRightBtn, toolTipInfo20);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Margin = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(4, 24);
            // 
            // DecreaseIndentBtn
            // 
            this.DecreaseIndentBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.DecreaseIndentBtn.Image = ((System.Drawing.Image)(resources.GetObject("DecreaseIndentBtn.Image")));
            this.DecreaseIndentBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DecreaseIndentBtn.Margin = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.DecreaseIndentBtn.Name = "DecreaseIndentBtn";
            this.DecreaseIndentBtn.Size = new System.Drawing.Size(23, 24);
            this.DecreaseIndentBtn.Text = "Decrease Indent";
            toolTipInfo21.BackColor = System.Drawing.Color.White;
            toolTipInfo21.Body.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            toolTipInfo21.Body.Size = new System.Drawing.Size(20, 20);
            toolTipInfo21.Body.Text = "\r\nMove your paragraph closer to the margin.\r\n";
            toolTipInfo21.Footer.Size = new System.Drawing.Size(20, 20);
            toolTipInfo21.Header.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            toolTipInfo21.Header.Size = new System.Drawing.Size(20, 20);
            toolTipInfo21.Header.Text = "Decrease Indent\r\n";
            this.superToolTip1.SetToolTip(this.DecreaseIndentBtn, toolTipInfo21);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.AutoSize = false;
            this.toolStripSeparator4.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 70);
            // 
            // toolStripPanelItem12
            // 
            this.toolStripPanelItem12.CausesValidation = false;
            this.toolStripPanelItem12.ForeColor = System.Drawing.Color.MidnightBlue;
            this.toolStripPanelItem12.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.WrapTextBtn,
            this.MergeCenterBtn});
            this.toolStripPanelItem12.Margin = new System.Windows.Forms.Padding(1, 4, 1, 0);
            this.toolStripPanelItem12.Name = "toolStripPanelItem12";
            this.toolStripPanelItem12.Padding = new System.Windows.Forms.Padding(2, 2, 2, 9);
            this.toolStripPanelItem12.RowCount = 2;
            this.toolStripPanelItem12.Size = new System.Drawing.Size(115, 53);
            this.toolStripPanelItem12.Text = "toolStripPanelItem12";
            this.toolStripPanelItem12.Transparent = true;
            // 
            // WrapTextBtn
            // 
            this.WrapTextBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.WrapTextBtn.Image = ((System.Drawing.Image)(resources.GetObject("WrapTextBtn.Image")));
            this.WrapTextBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.WrapTextBtn.Margin = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.WrapTextBtn.Name = "WrapTextBtn";
            this.WrapTextBtn.Size = new System.Drawing.Size(79, 20);
            this.WrapTextBtn.Text = "Wrap Text";
            toolTipInfo22.BackColor = System.Drawing.Color.White;
            toolTipInfo22.Body.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            toolTipInfo22.Body.Size = new System.Drawing.Size(20, 20);
            toolTipInfo22.Body.Text = "\r\nWrap Extra-long text into multiple lines, so you can see all of it.";
            toolTipInfo22.Footer.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            toolTipInfo22.Footer.Image = global::RibbonMerging.Properties.Resources.help;
            toolTipInfo22.Footer.Size = new System.Drawing.Size(20, 20);
            toolTipInfo22.Footer.Text = "Tell me more";
            toolTipInfo22.Footer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            toolTipInfo22.Header.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            toolTipInfo22.Header.Size = new System.Drawing.Size(20, 20);
            toolTipInfo22.Header.Text = "Wrap-Text";
            this.superToolTip1.SetToolTip(this.WrapTextBtn, toolTipInfo22);
            // 
            // MergeCenterBtn
            // 
            this.MergeCenterBtn.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MergeAndCenter,
            this.MergeAcrossBtn,
            this.MergeCellsBtn,
            this.UnmergeCellsBtn});
            this.MergeCenterBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.MergeCenterBtn.Image = ((System.Drawing.Image)(resources.GetObject("MergeCenterBtn.Image")));
            this.MergeCenterBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.MergeCenterBtn.Margin = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.MergeCenterBtn.Name = "MergeCenterBtn";
            this.MergeCenterBtn.Size = new System.Drawing.Size(111, 20);
            this.MergeCenterBtn.Text = "Merge & Center";
            toolTipInfo23.BackColor = System.Drawing.Color.White;
            toolTipInfo23.Body.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            toolTipInfo23.Body.Size = new System.Drawing.Size(20, 20);
            toolTipInfo23.Body.Text = "\r\nCombine and center the content of the selected cells in a new larger cell.\r\n\r\nT" +
    "his is a great way to create a label that spans multiple columns.";
            toolTipInfo23.Footer.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            toolTipInfo23.Footer.Image = global::RibbonMerging.Properties.Resources.help;
            toolTipInfo23.Footer.Size = new System.Drawing.Size(20, 20);
            toolTipInfo23.Footer.Text = "Tell Me more";
            toolTipInfo23.Footer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            toolTipInfo23.Header.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            toolTipInfo23.Header.Size = new System.Drawing.Size(20, 20);
            toolTipInfo23.Header.Text = "Merge & Center";
            this.superToolTip1.SetToolTip(this.MergeCenterBtn, toolTipInfo23);
            // 
            // MergeAndCenter
            // 
            this.MergeAndCenter.Image = ((System.Drawing.Image)(resources.GetObject("MergeAndCenter.Image")));
            this.MergeAndCenter.Name = "MergeAndCenter";
            this.MergeAndCenter.Size = new System.Drawing.Size(151, 22);
            this.MergeAndCenter.Text = "Merge & &Center";
            // 
            // MergeAcrossBtn
            // 
            this.MergeAcrossBtn.Image = ((System.Drawing.Image)(resources.GetObject("MergeAcrossBtn.Image")));
            this.MergeAcrossBtn.Name = "MergeAcrossBtn";
            this.MergeAcrossBtn.Size = new System.Drawing.Size(151, 22);
            this.MergeAcrossBtn.Text = "Merge &Across";
            // 
            // MergeCellsBtn
            // 
            this.MergeCellsBtn.Image = ((System.Drawing.Image)(resources.GetObject("MergeCellsBtn.Image")));
            this.MergeCellsBtn.Name = "MergeCellsBtn";
            this.MergeCellsBtn.Size = new System.Drawing.Size(151, 22);
            this.MergeCellsBtn.Text = "&Merge Cells";
            // 
            // UnmergeCellsBtn
            // 
            this.UnmergeCellsBtn.Image = ((System.Drawing.Image)(resources.GetObject("UnmergeCellsBtn.Image")));
            this.UnmergeCellsBtn.Name = "UnmergeCellsBtn";
            this.UnmergeCellsBtn.Size = new System.Drawing.Size(151, 22);
            this.UnmergeCellsBtn.Text = "&Unmerge Cells";
            // 
            // CellsToolStripEx
            // 
            this.superAccelerator1.SetCollapsedDropDownAccelerator(this.CellsToolStripEx, null);
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
            this.CellsToolStripEx.Location = new System.Drawing.Point(614, 1);
            this.CellsToolStripEx.Name = "CellsToolStripEx";
            this.CellsToolStripEx.Office12Mode = false;
            this.CellsToolStripEx.Padding = new System.Windows.Forms.Padding(0, 2, 1, 0);
            this.CellsToolStripEx.Size = new System.Drawing.Size(168, 100);
            this.CellsToolStripEx.TabIndex = 12;
            this.CellsToolStripEx.Text = "Cells";
            // 
            // InsertCellBtn
            // 
            this.InsertCellBtn.Image = ((System.Drawing.Image)(resources.GetObject("InsertCellBtn.Image")));
            this.InsertCellBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.InsertCellBtn.Name = "InsertCellBtn";
            this.InsertCellBtn.Size = new System.Drawing.Size(49, 81);
            this.InsertCellBtn.Text = "Insert\r\nCell";
            this.InsertCellBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.InsertCellBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            toolTipInfo24.BackColor = System.Drawing.Color.White;
            toolTipInfo24.Body.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            toolTipInfo24.Body.Size = new System.Drawing.Size(20, 20);
            toolTipInfo24.Body.Text = "\r\nAdd new cells, rows ,columns or sheets to your workbook";
            toolTipInfo24.Footer.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            toolTipInfo24.Footer.Image = global::RibbonMerging.Properties.Resources.help;
            toolTipInfo24.Footer.Size = new System.Drawing.Size(20, 20);
            toolTipInfo24.Footer.Text = "Tell Me more";
            toolTipInfo24.Footer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            toolTipInfo24.Header.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            toolTipInfo24.Header.Size = new System.Drawing.Size(20, 20);
            toolTipInfo24.Header.Text = "Insert Cells";
            this.superToolTip1.SetToolTip(this.InsertCellBtn, toolTipInfo24);
            // 
            // DeleteCellBtn
            // 
            this.DeleteCellBtn.Image = ((System.Drawing.Image)(resources.GetObject("DeleteCellBtn.Image")));
            this.DeleteCellBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DeleteCellBtn.Name = "DeleteCellBtn";
            this.DeleteCellBtn.Size = new System.Drawing.Size(56, 81);
            this.DeleteCellBtn.Text = "Delete \r\nCell";
            this.DeleteCellBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.DeleteCellBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            toolTipInfo25.BackColor = System.Drawing.Color.White;
            toolTipInfo25.Body.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            toolTipInfo25.Body.Size = new System.Drawing.Size(20, 20);
            toolTipInfo25.Body.Text = "\r\nDelete cell, rows, columns or sheets from your workbook.\r\n\r\nFYI: To delete mult" +
    "iple rows or columns at a time, select multiple rows and columns from sheet, and" +
    " click delete.";
            toolTipInfo25.Footer.Size = new System.Drawing.Size(20, 20);
            toolTipInfo25.Header.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            toolTipInfo25.Header.Size = new System.Drawing.Size(20, 20);
            toolTipInfo25.Header.Text = "Delete Cells";
            this.superToolTip1.SetToolTip(this.DeleteCellBtn, toolTipInfo25);
            // 
            // FormatBtn
            // 
            this.FormatBtn.Image = ((System.Drawing.Image)(resources.GetObject("FormatBtn.Image")));
            this.FormatBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.FormatBtn.Name = "FormatBtn";
            this.FormatBtn.Size = new System.Drawing.Size(56, 81);
            this.FormatBtn.Text = "Format";
            this.FormatBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.FormatBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            toolTipInfo26.BackColor = System.Drawing.Color.White;
            toolTipInfo26.Body.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            toolTipInfo26.Body.Size = new System.Drawing.Size(20, 20);
            toolTipInfo26.Body.Text = "\r\nChange the row height or column width, organize sheets, protect or hide cells.";
            toolTipInfo26.Footer.Size = new System.Drawing.Size(20, 20);
            toolTipInfo26.Header.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            toolTipInfo26.Header.Size = new System.Drawing.Size(20, 20);
            toolTipInfo26.Header.Text = "Format Cells";
            this.superToolTip1.SetToolTip(this.FormatBtn, toolTipInfo26);
            // 
            // toolStripEx5
            // 
            this.superAccelerator1.SetCollapsedDropDownAccelerator(this.toolStripEx5, null);
            this.toolStripEx5.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStripEx5.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.toolStripEx5.ForeColor = System.Drawing.Color.MidnightBlue;
            this.toolStripEx5.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripEx5.Image = null;
            this.toolStripEx5.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1});
            this.toolStripEx5.Location = new System.Drawing.Point(784, 1);
            this.toolStripEx5.Name = "toolStripEx5";
            this.toolStripEx5.Office12Mode = false;
            this.toolStripEx5.Size = new System.Drawing.Size(85, 100);
            this.toolStripEx5.TabIndex = 16;
            this.toolStripEx5.Text = "Close";
            this.toolStripEx5.Visible = false;
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.toolStripButton1.Image = global::RibbonMerging.Properties.Resources.close;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(78, 97);
            this.toolStripButton1.Text = "Close \r\nMergeSheets";
            this.toolStripButton1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
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
            this.statusStripEx1.BeforeTouchSize = new System.Drawing.Size(919, 27);
            this.statusStripEx1.Dock = Syncfusion.Windows.Forms.Tools.DockStyleEx.Fill;
            this.statusStripEx1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStripEx1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusStripLabel1,
            this.trackBarItem1,
            this.toolStripStatusLabel1});
            this.statusStripEx1.Location = new System.Drawing.Point(0, 0);
            this.statusStripEx1.MetroColor = System.Drawing.Color.Empty;
            this.statusStripEx1.Name = "statusStripEx1";
            this.statusStripEx1.Size = new System.Drawing.Size(919, 27);
            this.statusStripEx1.TabIndex = 2;
            this.statusStripEx1.Text = "statusStripEx1";
            // 
            // statusStripLabel1
            // 
            this.statusStripLabel1.Margin = new System.Windows.Forms.Padding(0, 4, 0, 2);
            this.statusStripLabel1.Name = "statusStripLabel1";
            this.statusStripLabel1.Size = new System.Drawing.Size(39, 15);
            this.statusStripLabel1.Text = "Ready";
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
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(35, 15);
            this.toolStripStatusLabel1.Text = "100%";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(237, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(416, 39);
            this.label1.TabIndex = 4;
            this.label1.Text = "Click here to Merge Sheet";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(1, 159);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(919, 385);
            this.panel1.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.statusStripEx1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(1, 517);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(919, 27);
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
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // superToolTip1
            // 
            this.superToolTip1.MaxWidth = 200;
            this.superToolTip1.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218)))));
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(1, 218);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(245, 216);
            this.panel3.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 545);
            this.Controls.Add(this.backStage1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.ribbonControlAdv1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.HelpButton = true;
            this.HelpButtonImage = ((System.Drawing.Image)(resources.GetObject("$this.HelpButtonImage")));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(1, 0, 1, 1);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ribbon Merging Demo";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControlAdv1)).EndInit();
            this.ribbonControlAdv1.ResumeLayout(false);
            this.ribbonControlAdv1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.backStage1)).EndInit();
            this.backStage1.ResumeLayout(false);
            this.backStageTab2.ResumeLayout(false);
            this.backStageTab2.PerformLayout();
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
            this.toolStripEx5.ResumeLayout(false);
            this.toolStripEx5.PerformLayout();
            this.statusStripEx1.ResumeLayout(false);
            this.statusStripEx1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private Syncfusion.Windows.Forms.Tools.ToolStripEx clipboardToolStripExt;
        private System.Windows.Forms.ToolStripButton toolStripBtnPaste;
        private Syncfusion.Windows.Forms.Tools.ToolStripPanelItem toolStripPanelItem1;
        private System.Windows.Forms.ToolStripButton toolStripBtnCut;
        private System.Windows.Forms.ToolStripButton toolStripBtnCopy;
        private Syncfusion.Windows.Forms.Tools.ToolStripEx fontToolStripExt;
        private Syncfusion.Windows.Forms.Tools.ToolStripPanelItem toolStripPanelItem2;
        private System.Windows.Forms.ToolStripComboBox toolStripFontfaceComboBox;
        private System.Windows.Forms.ToolStripComboBox toolStripFontSizeComboBox;
        private Syncfusion.Windows.Forms.Tools.ToolStripPanelItem toolStripPanelItem3;
        private System.Windows.Forms.ToolStripButton growfontToolStripBtn;
        private System.Windows.Forms.ToolStripButton shrinkfontToolStripBtn;
        private Syncfusion.Windows.Forms.Tools.ToolStripPanelItem toolStripPanelItem4;
        private System.Windows.Forms.ToolStripButton boldToolstripBtn;
        private System.Windows.Forms.ToolStripButton italicToolStripBtn;
        private System.Windows.Forms.ToolStripSplitButton underlineToolStripSplitBtn;
        private System.Windows.Forms.ToolStripMenuItem moreUnderlinesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem underlineColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem automaticToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem moreColorsToolStripMenuItem;
        private Syncfusion.Windows.Forms.Tools.ToolStripEx AlignmentToolStripEx;
        private Syncfusion.Windows.Forms.Tools.ToolStripEx CellsToolStripEx;
        private Syncfusion.Windows.Forms.BackStageView backStageView1;
        private Syncfusion.Windows.Forms.BackStage backStage1;
        private Syncfusion.Windows.Forms.BackStageButton backStageButton1;
        private System.Windows.Forms.Panel panel2;
        private Syncfusion.Windows.Forms.Tools.TrackBarItem trackBarItem1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ImageList imageList1;
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
        private System.Windows.Forms.ToolStripDropDownButton DeleteCellBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripDropDownButton BottomBorderBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripDropDownButton FillColorsBtn;
        private System.Windows.Forms.ToolStripDropDownButton InsertCellBtn;
        private System.Windows.Forms.ToolStripDropDownButton FormatBtn;
        private Syncfusion.Windows.Forms.Tools.SuperAccelerator superAccelerator1;
        private System.Windows.Forms.ToolStripDropDownButton FontColorBtn;
        private Syncfusion.Windows.Forms.BackStageTab backStageTab2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private Syncfusion.Windows.Forms.BackStageButton backStageButton2;
        private Syncfusion.Windows.Forms.BackStageButton backStageButton3;
        private Syncfusion.Windows.Forms.Tools.SuperToolTip superToolTip1;
        public Syncfusion.Windows.Forms.Tools.ToolStripEx toolStripEx5;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.Panel panel3;
    }
}


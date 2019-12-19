#region Copyright Syncfusion Inc. 2001-2019.
// Copyright Syncfusion Inc. 2001-2019. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Drawing;
using System.Drawing.Design;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.ComponentModel;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;
using System.Resources;
using System.Drawing.Printing;
using System.Text.RegularExpressions;
using System.IO;
using System.Runtime.Serialization.Formatters.Soap;
using Syncfusion.Windows.Forms.Diagram;
using Syncfusion.SVG.IO;
using Syncfusion.Windows.Forms.Diagram.Controls;
using Syncfusion.Windows.Forms.Tools;
using Syncfusion.Runtime.Serialization;
using Syncfusion.Windows.Forms.Tools.XPMenus;

namespace Syncfusion.Windows.Forms.Diagram.Samples.DiagramTool
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing ) {
            if ( disposing && ( components != null ) )
            {
                // components.Dispose( );
                this.dockingManager.Dispose();
                this.propertyEditor.Dispose();
                this.symbolPaletteGroupBar.Dispose();
                this.overviewControl1.Dispose();
                this.m_documentExplorer.Dispose();
                this.openPaletteDialog.Dispose();
                this.savePaletteDialog.Dispose();
                this.openDiagramDialog.Dispose();
                this.saveDiagramDialog.Dispose();
                this.smallImageList.Dispose();
                this.openImageDialog.Dispose();
                this.mainFrameBarManager.Dispose();
                this.mainMenuBar.Dispose();
                this.parentBarItemFile.Dispose();
                this.biFileNew.Dispose();
                this.biFileOpen.Dispose();
                this.biFileSave.Dispose();
                this.biFileSaveAs.Dispose();
                this.biAddPalette.Dispose();
                this.biSavePalette.Dispose();
                this.biPageSetup.Dispose();
                this.biPrintPreview.Dispose();
                this.biFilePrint.Dispose();
                this.biFileExit.Dispose();
                this.parentBarItemEdit.Dispose();
                this.barItemEditUndo.Dispose();
                this.barItemEditRedo.Dispose();
                this.barItemEditSelectAll.Dispose();
                this.barItemEditDelete.Dispose();
                this.barItemEditCut.Dispose();
                this.barItemEditCopy.Dispose();
                this.barItemEditPaste.Dispose();
                this.parentBarItemFormat.Dispose();
                this.barItemFillStyle.Dispose();
                this.barItemShadowStyle.Dispose();
                this.parentBarItemView.Dispose();
                this.barShowRulers.Dispose();
                this.barItemViewSymbolPalette.Dispose();
                this.barItemViewProperties.Dispose();
                this.barItemPanZoom.Dispose();
                this.barItemDocumentExplorer.Dispose();
                this.barItemHeaderFooter.Dispose();
                this.barItemPageBorders.Dispose();
                this.parentBarItemActions.Dispose();
                this.parentBarItemAlign.Dispose();
                this.barItemAlignLeft.Dispose();
                this.barItemAlignCenter.Dispose();
                this.barItemAlignRight.Dispose();
                this.barItemAlignTop.Dispose();
                this.barItemAlignMiddle.Dispose();
                this.barItemAlignBottom.Dispose();
                this.parentBarItemFlip.Dispose();
                this.barItemFlipHorizontally.Dispose();
                this.barItemFlipVertically.Dispose();
                this.barItemFlipBoth.Dispose();
                this.parentBarItemToolsGrouping.Dispose();
                this.barItemGroupingGroup.Dispose();
                this.barItemGroupingUnGroup.Dispose();
                this.parentBarItemToolsOrder.Dispose();
                this.barItemOrderFront.Dispose();
                this.barItemOrderForward.Dispose();
                this.barItemOrderBackward.Dispose();
                this.barItemOrderBack.Dispose();
                this.parentBarItemRotate.Dispose();
                this.barItemRotateClock.Dispose();
                this.barItemRotateConter.Dispose();
                this.parentBarItemResize.Dispose();
                this.barItemResizeWidth.Dispose();
                this.barItemResizeHeight.Dispose();
                this.barItemResizeSize.Dispose();
                this.barItemResizeAcross.Dispose();
                this.barItemResizeDown.Dispose();
                this.barItemLayout.Dispose();
                this.parentBarItemWindow.Dispose();
                this.biTabbedMDI.Dispose();
                this.parentBarItemHelp.Dispose();
                this.barItemAbout.Dispose();
                this.standardToolbar.Dispose();
                this.parentBarItemPopUp.Dispose();
                this.parentBarItemNode.Dispose();
                //this.biRemovePalette.Dispose();
            }
            base.Dispose( disposing );
        }

        #region Windows Form Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent( ) {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            Syncfusion.Windows.Forms.Tools.CaptionButtonsCollection ccbpropertyEditor = new Syncfusion.Windows.Forms.Tools.CaptionButtonsCollection();
            Syncfusion.Windows.Forms.Tools.CaptionButtonsCollection ccbsymbolPaletteGroupBar = new Syncfusion.Windows.Forms.Tools.CaptionButtonsCollection();
            Syncfusion.Windows.Forms.Tools.CaptionButtonsCollection ccboverviewControl1 = new Syncfusion.Windows.Forms.Tools.CaptionButtonsCollection();
            Syncfusion.Windows.Forms.Tools.CaptionButtonsCollection ccbm_documentExplorer = new Syncfusion.Windows.Forms.Tools.CaptionButtonsCollection();
            Syncfusion.Windows.Forms.Tools.CaptionButtonsCollection ccbpnlAssSymbols = new Syncfusion.Windows.Forms.Tools.CaptionButtonsCollection();
            this.dockingManager = new Syncfusion.Windows.Forms.Tools.DockingManager(this.components);
            this.propertyEditor = new Syncfusion.Windows.Forms.Diagram.Controls.PropertyEditor(this.components);
            this.symbolPaletteGroupBar = new Syncfusion.Windows.Forms.Diagram.Controls.PaletteGroupBar(this.components);
            this.overviewControl1 = new Syncfusion.Windows.Forms.Diagram.Controls.OverviewControl(this.components);
            this.m_documentExplorer = new Syncfusion.Windows.Forms.Diagram.Controls.DocumentExplorer();
            this.pnlAssSymbols = new System.Windows.Forms.Panel();
            this.btnRemoveAss = new Syncfusion.Windows.Forms.ButtonAdv();
            this.chkListAssSymbols = new System.Windows.Forms.CheckedListBox();
            this.openPaletteDialog = new System.Windows.Forms.OpenFileDialog();
            this.savePaletteDialog = new System.Windows.Forms.SaveFileDialog();
            this.openDiagramDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveDiagramDialog = new System.Windows.Forms.SaveFileDialog();
            this.smallImageList = new System.Windows.Forms.ImageList(this.components);
            this.openImageDialog = new System.Windows.Forms.OpenFileDialog();
            this.mainFrameBarManager = new Syncfusion.Windows.Forms.Tools.XPMenus.MainFrameBarManager(this);
            this.mainMenuBar = new Syncfusion.Windows.Forms.Tools.XPMenus.Bar(this.mainFrameBarManager, "MainMenu");
            this.parentBarItemFile = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.biFileNew = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.biFileOpen = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.biFileSave = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.biFileSaveAs = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.biAddPalette = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.biSavePalette = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.biPageSetup = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.biPrintPreview = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.biFilePrint = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.biFileExit = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.parentBarItemEdit = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.barItemEditUndo = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItemEditRedo = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItemEditSelectAll = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItemEditDelete = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItemEditCut = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItemEditCopy = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItemEditPaste = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.parentBarItemFormat = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.barItemFillStyle = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItemShadowStyle = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.parentBarItemView = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.barShowRulers = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItemViewSymbolPalette = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItemViewAssSymbols = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItemViewProperties = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItemPanZoom = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItemDocumentExplorer = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItemHeaderFooter = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItemPageBorders = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.parentBarItemActions = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.parentBarItemAlign = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.barItemAlignLeft = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItemAlignCenter = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItemAlignRight = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItemAlignTop = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItemAlignMiddle = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItemAlignBottom = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.parentBarItemFlip = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.barItemFlipHorizontally = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItemFlipVertically = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItemFlipBoth = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.parentBarItemToolsGrouping = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.barItemGroupingGroup = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItemGroupingUnGroup = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.parentBarItemToolsOrder = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.barItemOrderFront = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItemOrderForward = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItemOrderBackward = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItemOrderBack = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.parentBarItemRotate = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.barItemRotateClock = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItemRotateConter = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.parentBarItemResize = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.barItemResizeWidth = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItemResizeHeight = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItemResizeSize = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItemResizeAcross = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItemResizeDown = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItemLayout = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.parentBarItemWindow = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.biTabbedMDI = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.parentBarItemHelp = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.barItemAbout = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.standardToolbar = new Syncfusion.Windows.Forms.Tools.XPMenus.Bar(this.mainFrameBarManager, "Standard");
            this.parentBarItemPopUp = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.parentBarItemNode = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            ((System.ComponentModel.ISupportInitialize)(this.dockingManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.symbolPaletteGroupBar)).BeginInit();
            this.pnlAssSymbols.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainFrameBarManager)).BeginInit();
            this.SuspendLayout();
            // 
            // dockingManager
            // 
            this.dockingManager.ActiveCaptionFont = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            this.dockingManager.DockLayoutStream = ((System.IO.MemoryStream)(resources.GetObject("dockingManager.DockLayoutStream")));
            this.dockingManager.HostControl = this;
            this.dockingManager.InActiveCaptionFont = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            this.dockingManager.MaximizeButtonEnabled = true;
            this.dockingManager.MenuButtonEnabled = false;
            this.dockingManager.PersistState = true;
            this.dockingManager.ThemesEnabled = true;
            this.dockingManager.VisualStyle = Syncfusion.Windows.Forms.VisualStyle.Office2007;
            this.dockingManager.DockVisibilityChanged += new Syncfusion.Windows.Forms.Tools.DockVisibilityChangedEventHandler(this.dockingManager_DockVisibilityChanged);
            this.dockingManager.CaptionButtons.Add(new Syncfusion.Windows.Forms.Tools.CaptionButton(Syncfusion.Windows.Forms.Tools.CaptionButtonType.Close, "CloseButton", -1, System.Drawing.Color.Transparent, ""));
            this.dockingManager.CaptionButtons.Add(new Syncfusion.Windows.Forms.Tools.CaptionButton(Syncfusion.Windows.Forms.Tools.CaptionButtonType.Pin, "PinButton", -1, System.Drawing.Color.Transparent, ""));
            this.dockingManager.CaptionButtons.Add(new Syncfusion.Windows.Forms.Tools.CaptionButton(Syncfusion.Windows.Forms.Tools.CaptionButtonType.Menu, "MenuButton", -1, System.Drawing.Color.Transparent, ""));
            this.dockingManager.CaptionButtons.Add(new Syncfusion.Windows.Forms.Tools.CaptionButton(Syncfusion.Windows.Forms.Tools.CaptionButtonType.Maximize, "MaximizeButton", -1, System.Drawing.Color.Transparent, ""));
            this.dockingManager.SetDockLabel(this.propertyEditor, "Properties");
            this.dockingManager.SetEnableDocking(this.propertyEditor, true);
            ccbpropertyEditor.MergeWith(this.dockingManager.CaptionButtons, false);
            this.dockingManager.SetCustomCaptionButtons(this.propertyEditor, ccbpropertyEditor);
            this.dockingManager.SetDockLabel(this.symbolPaletteGroupBar, "Symbol Palettes");
            this.dockingManager.SetEnableDocking(this.symbolPaletteGroupBar, true);
            this.dockingManager.SetFreezeResize(this.symbolPaletteGroupBar, true);
            ccbsymbolPaletteGroupBar.MergeWith(this.dockingManager.CaptionButtons, false);
            this.dockingManager.SetCustomCaptionButtons(this.symbolPaletteGroupBar, ccbsymbolPaletteGroupBar);
            this.dockingManager.SetDockLabel(this.overviewControl1, "Pan & Zoom");
            this.dockingManager.SetEnableDocking(this.overviewControl1, true);
            ccboverviewControl1.MergeWith(this.dockingManager.CaptionButtons, false);
            this.dockingManager.SetCustomCaptionButtons(this.overviewControl1, ccboverviewControl1);
            this.dockingManager.SetDockLabel(this.m_documentExplorer, "Document Explorer");
            this.dockingManager.SetEnableDocking(this.m_documentExplorer, true);
            this.dockingManager.SetHiddenOnLoad(this.m_documentExplorer, true);
            this.dockingManager.SetFreezeResize(this.m_documentExplorer, true);
            ccbm_documentExplorer.MergeWith(this.dockingManager.CaptionButtons, false);
            this.dockingManager.SetCustomCaptionButtons(this.m_documentExplorer, ccbm_documentExplorer);
            this.dockingManager.SetDockLabel(this.pnlAssSymbols, "Associated Symbol Palettes");
            this.dockingManager.SetEnableDocking(this.pnlAssSymbols, true);
            ccbpnlAssSymbols.MergeWith(this.dockingManager.CaptionButtons, false);
            this.dockingManager.SetCustomCaptionButtons(this.pnlAssSymbols, ccbpnlAssSymbols);
            // 
            // propertyEditor
            // 
            this.propertyEditor.Diagram = null;
            this.propertyEditor.Location = new System.Drawing.Point(3, 26);
            this.propertyEditor.Name = "propertyEditor";
            this.propertyEditor.ShowCombo = true;
            this.propertyEditor.Size = new System.Drawing.Size(197, 345);
            this.propertyEditor.TabIndex = 11;
            // 
            // symbolPaletteGroupBar
            // 
            this.symbolPaletteGroupBar.AllowDrop = true;
            this.symbolPaletteGroupBar.BeforeTouchSize = new System.Drawing.Size(265, 204);
            this.symbolPaletteGroupBar.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.symbolPaletteGroupBar.CollapseImage = ((System.Drawing.Image)(resources.GetObject("symbolPaletteGroupBar.CollapseImage")));
            this.symbolPaletteGroupBar.Diagram = null;
            this.symbolPaletteGroupBar.EditMode = false;
            this.symbolPaletteGroupBar.ExpandButtonToolTip = null;
            this.symbolPaletteGroupBar.ExpandImage = ((System.Drawing.Image)(resources.GetObject("symbolPaletteGroupBar.ExpandImage")));
            this.symbolPaletteGroupBar.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Bold);
            this.symbolPaletteGroupBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(77)))), ((int)(((byte)(140)))));
            this.symbolPaletteGroupBar.GroupBarDropDownToolTip = null;
            this.symbolPaletteGroupBar.IndexOnVisibleItems = true;
            this.symbolPaletteGroupBar.Location = new System.Drawing.Point(3, 26);
            this.symbolPaletteGroupBar.MinimizeButtonToolTip = null;
            this.symbolPaletteGroupBar.Name = "symbolPaletteGroupBar";
            this.symbolPaletteGroupBar.NavigationPaneTooltip = null;
            this.symbolPaletteGroupBar.PopupClientSize = new System.Drawing.Size(0, 0);
            this.symbolPaletteGroupBar.Size = new System.Drawing.Size(265, 204);
            this.symbolPaletteGroupBar.TabIndex = 9;
            this.symbolPaletteGroupBar.Text = "paletteGroupBar1";
            this.symbolPaletteGroupBar.TextAlign = Syncfusion.Windows.Forms.Tools.TextAlignment.Left;
            this.symbolPaletteGroupBar.VisualStyle = Syncfusion.Windows.Forms.VisualStyle.Office2003;
            // 
            // overviewControl1
            // 
            this.overviewControl1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.overviewControl1.Diagram = null;
            this.overviewControl1.ForeColor = System.Drawing.Color.Red;
            this.overviewControl1.Location = new System.Drawing.Point(3, 26);
            this.overviewControl1.Name = "overviewControl1";
            this.overviewControl1.Size = new System.Drawing.Size(197, 152);
            this.overviewControl1.TabIndex = 11;
            // 
            // m_documentExplorer
            // 
            this.m_documentExplorer.ImageIndex = 0;
            this.m_documentExplorer.Location = new System.Drawing.Point(3, 26);
            this.m_documentExplorer.Name = "m_documentExplorer";
            this.m_documentExplorer.SelectedImageIndex = 0;
            this.m_documentExplorer.Size = new System.Drawing.Size(265, 139);
            this.m_documentExplorer.TabIndex = 0;
            // 
            // pnlAssSymbols
            // 
            this.pnlAssSymbols.Controls.Add(this.btnRemoveAss);
            this.pnlAssSymbols.Controls.Add(this.chkListAssSymbols);
            this.pnlAssSymbols.Location = new System.Drawing.Point(3, 26);
            this.pnlAssSymbols.Name = "pnlAssSymbols";
            this.pnlAssSymbols.Size = new System.Drawing.Size(269, 121);
            this.pnlAssSymbols.TabIndex = 20;
            // 
            // btnRemoveAss
            // 
            this.btnRemoveAss.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2007;
            this.btnRemoveAss.BeforeTouchSize = new System.Drawing.Size(269, 26);
            this.btnRemoveAss.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnRemoveAss.Enabled = false;
            this.btnRemoveAss.IsBackStageButton = false;
            this.btnRemoveAss.Location = new System.Drawing.Point(0, 95);
            this.btnRemoveAss.Name = "btnRemoveAss";
            this.btnRemoveAss.Size = new System.Drawing.Size(269, 26);
            this.btnRemoveAss.TabIndex = 18;
            this.btnRemoveAss.Text = "Remove Association";
            this.btnRemoveAss.UseVisualStyle = true;
            this.btnRemoveAss.Click += new System.EventHandler(this.btnRemoveAss_Click);
            // 
            // chkListAssSymbols
            // 
            this.chkListAssSymbols.CheckOnClick = true;
            this.chkListAssSymbols.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkListAssSymbols.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkListAssSymbols.FormattingEnabled = true;
            this.chkListAssSymbols.Location = new System.Drawing.Point(0, 0);
            this.chkListAssSymbols.Name = "chkListAssSymbols";
            this.chkListAssSymbols.Size = new System.Drawing.Size(269, 121);
            this.chkListAssSymbols.TabIndex = 17;
            this.chkListAssSymbols.SelectedIndexChanged += new System.EventHandler(this.chkListAssSymbols_SelectedIndexChanged);
            // 
            // openPaletteDialog
            // 
            this.openPaletteDialog.DefaultExt = "edp";
            this.openPaletteDialog.Filter = "Essential Diagram Palettes|*.edp|Visio Stencils|*.vss; *.vsx|Visio Drawings(Shape" +
                "s only)|*.vsd; *.vdx|All files|*.*";
            this.openPaletteDialog.Title = "Add SymbolPalette";
            // 
            // savePaletteDialog
            // 
            this.savePaletteDialog.DefaultExt = "edp";
            this.savePaletteDialog.Filter = "Essential Diagram Palettes|*.edp|All files|*.*";
            this.savePaletteDialog.Title = "Save SymbolPalette";
            // 
            // openDiagramDialog
            // 
            this.openDiagramDialog.Filter = "Diagram Files|*.edd|All files|*.*";
            this.openDiagramDialog.Title = "Open Diagram";
            // 
            // saveDiagramDialog
            // 
            this.saveDiagramDialog.FileName = "doc1";
            this.saveDiagramDialog.Filter = "Diagram files|*.edd|EMF file|*.emf|GIF file|*.gif|PNG file|*.png|BMP file|*.bmp|J" +
                "PEG file|*.jpeg,*.jpg|TIFF file|*.tiff|SVG file|*.svg|All files|*.*";
            // 
            // smallImageList
            // 
            this.smallImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("smallImageList.ImageStream")));
            this.smallImageList.TransparentColor = System.Drawing.Color.Fuchsia;
            this.smallImageList.Images.SetKeyName(0, "");
            this.smallImageList.Images.SetKeyName(1, "");
            this.smallImageList.Images.SetKeyName(2, "");
            this.smallImageList.Images.SetKeyName(3, "");
            this.smallImageList.Images.SetKeyName(4, "");
            this.smallImageList.Images.SetKeyName(5, "");
            this.smallImageList.Images.SetKeyName(6, "");
            this.smallImageList.Images.SetKeyName(7, "");
            this.smallImageList.Images.SetKeyName(8, "");
            this.smallImageList.Images.SetKeyName(9, "");
            this.smallImageList.Images.SetKeyName(10, "");
            this.smallImageList.Images.SetKeyName(11, "");
            this.smallImageList.Images.SetKeyName(12, "");
            this.smallImageList.Images.SetKeyName(13, "");
            this.smallImageList.Images.SetKeyName(14, "");
            this.smallImageList.Images.SetKeyName(15, "");
            this.smallImageList.Images.SetKeyName(16, "");
            this.smallImageList.Images.SetKeyName(17, "");
            this.smallImageList.Images.SetKeyName(18, "");
            this.smallImageList.Images.SetKeyName(19, "");
            this.smallImageList.Images.SetKeyName(20, "");
            this.smallImageList.Images.SetKeyName(21, "");
            this.smallImageList.Images.SetKeyName(22, "");
            this.smallImageList.Images.SetKeyName(23, "");
            this.smallImageList.Images.SetKeyName(24, "");
            this.smallImageList.Images.SetKeyName(25, "");
            this.smallImageList.Images.SetKeyName(26, "");
            this.smallImageList.Images.SetKeyName(27, "");
            this.smallImageList.Images.SetKeyName(28, "");
            this.smallImageList.Images.SetKeyName(29, "");
            this.smallImageList.Images.SetKeyName(30, "");
            this.smallImageList.Images.SetKeyName(31, "");
            this.smallImageList.Images.SetKeyName(32, "");
            this.smallImageList.Images.SetKeyName(33, "");
            // 
            // openImageDialog
            // 
            this.openImageDialog.Filter = "Windows Bitmaps|*.bmp|Enhanced Metafiles|*.emf|All files|*.*";
            this.openImageDialog.Title = "Insert Image";
            // 
            // mainFrameBarManager
            // 
            this.mainFrameBarManager.BarPositionInfo = ((System.IO.MemoryStream)(resources.GetObject("mainFrameBarManager.BarPositionInfo")));
            this.mainFrameBarManager.Bars.Add(this.mainMenuBar);
            this.mainFrameBarManager.Bars.Add(this.standardToolbar);
            this.mainFrameBarManager.Categories.Add("Popups");
            this.mainFrameBarManager.Categories.Add("File");
            this.mainFrameBarManager.Categories.Add("Window");
            this.mainFrameBarManager.Categories.Add("Edit");
            this.mainFrameBarManager.Categories.Add("View");
            this.mainFrameBarManager.Categories.Add("Help");
            this.mainFrameBarManager.Categories.Add("Dialogs");
            this.mainFrameBarManager.Categories.Add("Actions");
            this.mainFrameBarManager.Categories.Add("Align");
            this.mainFrameBarManager.Categories.Add("Flip");
            this.mainFrameBarManager.Categories.Add("Grouping");
            this.mainFrameBarManager.Categories.Add("Order");
            this.mainFrameBarManager.Categories.Add("Rotate");
            this.mainFrameBarManager.Categories.Add("Resize");
            this.mainFrameBarManager.Categories.Add("Format");
            this.mainFrameBarManager.CurrentBaseFormType = "Syncfusion.Windows.Forms.Office2007Form";
            this.mainFrameBarManager.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mainFrameBarManager.Form = this;
            this.mainFrameBarManager.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.barItemViewSymbolPalette,
            this.barItemViewAssSymbols,
            this.parentBarItemFile,
            this.barItemViewProperties,
            this.barItemPanZoom,
            this.parentBarItemAlign,
            this.barItemDocumentExplorer,
            this.barShowRulers,
            this.parentBarItemRotate,
            this.barItemHeaderFooter,
            this.barItemPageBorders,
            this.parentBarItemFlip,
            this.parentBarItemResize,
            this.biFileNew,
            this.parentBarItemEdit,
            this.parentBarItemPopUp,
            this.parentBarItemView,
            this.parentBarItemWindow,
            this.parentBarItemHelp,
            this.parentBarItemActions,
            this.biFileOpen,
            this.parentBarItemToolsGrouping,
            this.parentBarItemToolsOrder,
            this.biFileSave,
            this.biFileSaveAs,
            this.biPageSetup,
            this.biPrintPreview,
            this.biFilePrint,
            this.biAddPalette,
            this.biSavePalette,
            this.biFileExit,
            this.biTabbedMDI,
            this.barItemEditCut,
            this.barItemEditCopy,
            this.barItemEditPaste,
            this.barItemEditUndo,
            this.barItemEditRedo,
            this.barItemAbout,
            this.barItemEditSelectAll,
            this.barItemAlignBottom,
            this.barItemAlignCenter,
            this.barItemAlignLeft,
            this.barItemAlignMiddle,
            this.barItemAlignRight,
            this.barItemAlignTop,
            this.barItemEditDelete,
            this.barItemFlipBoth,
            this.barItemFlipHorizontally,
            this.barItemFlipVertically,
            this.barItemGroupingGroup,
            this.barItemGroupingUnGroup,
            this.barItemOrderBack,
            this.barItemOrderBackward,
            this.barItemOrderForward,
            this.barItemOrderFront,
            this.barItemResizeAcross,
            this.barItemResizeDown,
            this.barItemResizeHeight,
            this.barItemResizeSize,
            this.barItemResizeWidth,
            this.barItemRotateClock,
            this.barItemRotateConter,
            this.barItemLayout,
            this.parentBarItemFormat,
            this.barItemFillStyle,
            this.barItemShadowStyle});
            this.mainFrameBarManager.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(201)))), ((int)(((byte)(232)))));
            this.mainFrameBarManager.ResetCustomization = false;
            this.mainFrameBarManager.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007;
            // 
            // mainMenuBar
            // 
            this.mainMenuBar.BarName = "MainMenu";
            this.mainMenuBar.BarStyle = ((Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle)(((Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.IsMainMenu | Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.RotateWhenVertical)
                        | Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.Visible)));
            this.mainMenuBar.Caption = "MainMenu";
            this.mainMenuBar.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.parentBarItemFile,
            this.parentBarItemEdit,
            this.parentBarItemView,
            this.parentBarItemActions,
            this.parentBarItemWindow,
            this.parentBarItemHelp});
            this.mainMenuBar.Manager = this.mainFrameBarManager;
            // 
            // parentBarItemFile
            // 
            this.parentBarItemFile.BarName = "parentBarItemFile";
            this.parentBarItemFile.CategoryIndex = 0;
            this.parentBarItemFile.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.parentBarItemFile.ID = "File";
            this.parentBarItemFile.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.biFileNew,
            this.biFileOpen,
            this.biFileSave,
            this.biFileSaveAs,
            this.biAddPalette,
            this.biSavePalette,
            this.biPageSetup,
            this.biPrintPreview,
            this.biFilePrint,
            this.biFileExit});
            this.parentBarItemFile.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(201)))), ((int)(((byte)(232)))));
            this.parentBarItemFile.SeparatorIndices.AddRange(new int[] {
            4,
            6,
            9});
            this.parentBarItemFile.ShowToolTipInPopUp = false;
            this.parentBarItemFile.SizeToFit = true;
            this.parentBarItemFile.Text = "&File";
            this.parentBarItemFile.WrapLength = 20;
            // 
            // biFileNew
            // 
            this.biFileNew.BarName = "biFileNew";
            this.biFileNew.CategoryIndex = 1;
            this.biFileNew.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.biFileNew.ID = "New";
            this.biFileNew.ImageIndex = 0;
            this.biFileNew.ImageList = this.smallImageList;
            this.biFileNew.Shortcut = System.Windows.Forms.Shortcut.CtrlN;
            this.biFileNew.ShowToolTipInPopUp = false;
            this.biFileNew.SizeToFit = true;
            this.biFileNew.Text = "&New";
            this.biFileNew.Click += new System.EventHandler(this.biFileNew_Click);
            // 
            // biFileOpen
            // 
            this.biFileOpen.BarName = "biFileOpen";
            this.biFileOpen.CategoryIndex = 1;
            this.biFileOpen.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.biFileOpen.ID = "Open";
            this.biFileOpen.ImageIndex = 1;
            this.biFileOpen.ImageList = this.smallImageList;
            this.biFileOpen.Shortcut = System.Windows.Forms.Shortcut.CtrlO;
            this.biFileOpen.ShowToolTipInPopUp = false;
            this.biFileOpen.SizeToFit = true;
            this.biFileOpen.Text = "&Open";
            this.biFileOpen.Click += new System.EventHandler(this.biFileOpen_Click);
            // 
            // biFileSave
            // 
            this.biFileSave.BarName = "biFileSave";
            this.biFileSave.CategoryIndex = 1;
            this.biFileSave.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.biFileSave.ID = "Save";
            this.biFileSave.ImageIndex = 2;
            this.biFileSave.ImageList = this.smallImageList;
            this.biFileSave.Shortcut = System.Windows.Forms.Shortcut.CtrlS;
            this.biFileSave.ShowToolTipInPopUp = false;
            this.biFileSave.SizeToFit = true;
            this.biFileSave.Text = "&Save";
            this.biFileSave.Click += new System.EventHandler(this.biFileSave_Click);
            // 
            // biFileSaveAs
            // 
            this.biFileSaveAs.BarName = "biFileSaveAs";
            this.biFileSaveAs.CategoryIndex = 1;
            this.biFileSaveAs.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.biFileSaveAs.ID = "Save As...";
            this.biFileSaveAs.ShowToolTipInPopUp = false;
            this.biFileSaveAs.SizeToFit = true;
            this.biFileSaveAs.Text = "Save As...";
            this.biFileSaveAs.Click += new System.EventHandler(this.biFileSaveAs_Click);
            // 
            // biAddPalette
            // 
            this.biAddPalette.BarName = "biAddPalette";
            this.biAddPalette.CategoryIndex = 1;
            this.biAddPalette.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.biAddPalette.ID = "Add SymbolPalette";
            this.biAddPalette.ShowToolTipInPopUp = false;
            this.biAddPalette.SizeToFit = true;
            this.biAddPalette.Text = "Add SymbolPalette...";
            this.biAddPalette.Click += new System.EventHandler(this.biFileAddPalette_Click);
            // 
            // biSavePalette
            // 
            this.biSavePalette.BarName = "biSavePalette";
            this.biSavePalette.CategoryIndex = 1;
            this.biSavePalette.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.biSavePalette.ID = "Save SymbolPalette";
            this.biSavePalette.ShowToolTipInPopUp = false;
            this.biSavePalette.SizeToFit = true;
            this.biSavePalette.Text = "Save Active SymbolPalette";
            this.biSavePalette.Click += new System.EventHandler(this.biSavePalette_Click);
            // 
            // biPageSetup
            // 
            this.biPageSetup.BarName = "biPageSetup";
            this.biPageSetup.CategoryIndex = 1;
            this.biPageSetup.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.biPageSetup.ID = "Page Setup";
            this.biPageSetup.ImageIndex = 5;
            this.biPageSetup.ImageList = this.smallImageList;
            this.biPageSetup.ShowToolTipInPopUp = false;
            this.biPageSetup.SizeToFit = true;
            this.biPageSetup.Text = "Page Setup";
            this.biPageSetup.Click += new System.EventHandler(this.biPageSetup_Click);
            // 
            // biPrintPreview
            // 
            this.biPrintPreview.BarName = "biPrintPreview";
            this.biPrintPreview.CategoryIndex = 1;
            this.biPrintPreview.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.biPrintPreview.ID = "Print Preview";
            this.biPrintPreview.ImageIndex = 3;
            this.biPrintPreview.ImageList = this.smallImageList;
            this.biPrintPreview.ShowToolTipInPopUp = false;
            this.biPrintPreview.SizeToFit = true;
            this.biPrintPreview.Text = "Print Preview";
            this.biPrintPreview.Tooltip = "Print Preview";
            this.biPrintPreview.Click += new System.EventHandler(this.biPrintPreview_Click);
            // 
            // biFilePrint
            // 
            this.biFilePrint.BarName = "biFilePrint";
            this.biFilePrint.CategoryIndex = 1;
            this.biFilePrint.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.biFilePrint.ID = "Print";
            this.biFilePrint.ImageIndex = 6;
            this.biFilePrint.ImageList = this.smallImageList;
            this.biFilePrint.ShowToolTipInPopUp = false;
            this.biFilePrint.SizeToFit = true;
            this.biFilePrint.Text = "Print";
            this.biFilePrint.Click += new System.EventHandler(this.biFilePrint_Click);
            // 
            // biFileExit
            // 
            this.biFileExit.BarName = "biFileExit";
            this.biFileExit.CategoryIndex = 1;
            this.biFileExit.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.biFileExit.ID = "Exit";
            this.biFileExit.ShowToolTipInPopUp = false;
            this.biFileExit.SizeToFit = true;
            this.biFileExit.Text = "Exit";
            this.biFileExit.Click += new System.EventHandler(this.biFileExit_Click);
            // 
            // parentBarItemEdit
            // 
            this.parentBarItemEdit.BarName = "parentBarItemEdit";
            this.parentBarItemEdit.CategoryIndex = 0;
            this.parentBarItemEdit.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.parentBarItemEdit.ID = "Edit";
            this.parentBarItemEdit.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.barItemEditUndo,
            this.barItemEditRedo,
            this.barItemEditSelectAll,
            this.barItemEditDelete,
            this.barItemEditCut,
            this.barItemEditCopy,
            this.barItemEditPaste,
            this.parentBarItemFormat});
            this.parentBarItemEdit.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(201)))), ((int)(((byte)(232)))));
            this.parentBarItemEdit.SeparatorIndices.AddRange(new int[] {
            2,
            4});
            this.parentBarItemEdit.ShowToolTipInPopUp = false;
            this.parentBarItemEdit.SizeToFit = true;
            this.parentBarItemEdit.Text = "&Edit";
            this.parentBarItemEdit.WrapLength = 20;
            // 
            // barItemEditUndo
            // 
            this.barItemEditUndo.BarName = "barItemEditUndo";
            this.barItemEditUndo.CategoryIndex = 3;
            this.barItemEditUndo.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.barItemEditUndo.ID = "Undo";
            this.barItemEditUndo.ImageIndex = 10;
            this.barItemEditUndo.ImageList = this.smallImageList;
            this.barItemEditUndo.Shortcut = System.Windows.Forms.Shortcut.CtrlZ;
            this.barItemEditUndo.ShowToolTipInPopUp = false;
            this.barItemEditUndo.SizeToFit = true;
            this.barItemEditUndo.Text = "&Undo";
            this.barItemEditUndo.Click += new System.EventHandler(this.barItemEditUndo_Click);
            // 
            // barItemEditRedo
            // 
            this.barItemEditRedo.BarName = "barItemEditRedo";
            this.barItemEditRedo.CategoryIndex = 3;
            this.barItemEditRedo.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.barItemEditRedo.ID = "EditRedo";
            this.barItemEditRedo.ImageIndex = 11;
            this.barItemEditRedo.ImageList = this.smallImageList;
            this.barItemEditRedo.Shortcut = System.Windows.Forms.Shortcut.CtrlY;
            this.barItemEditRedo.ShowToolTipInPopUp = false;
            this.barItemEditRedo.SizeToFit = true;
            this.barItemEditRedo.Text = "&Redo";
            this.barItemEditRedo.Click += new System.EventHandler(this.barItemEditRedo_Click);
            // 
            // barItemEditSelectAll
            // 
            this.barItemEditSelectAll.BarName = "barItemEditSelectAll";
            this.barItemEditSelectAll.CategoryIndex = 3;
            this.barItemEditSelectAll.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.barItemEditSelectAll.ID = "&Select All";
            this.barItemEditSelectAll.Shortcut = System.Windows.Forms.Shortcut.CtrlA;
            this.barItemEditSelectAll.ShowToolTipInPopUp = false;
            this.barItemEditSelectAll.SizeToFit = true;
            this.barItemEditSelectAll.Text = "Select &All";
            this.barItemEditSelectAll.Click += new System.EventHandler(this.barItemEditSelectAll_Click);
            // 
            // barItemEditDelete
            // 
            this.barItemEditDelete.BarName = "barItemEditDelete";
            this.barItemEditDelete.CategoryIndex = 3;
            this.barItemEditDelete.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.barItemEditDelete.ID = "Delete";
            this.barItemEditDelete.ImageIndex = 12;
            this.barItemEditDelete.ImageList = this.smallImageList;
            this.barItemEditDelete.ShowToolTipInPopUp = false;
            this.barItemEditDelete.SizeToFit = true;
            this.barItemEditDelete.Text = "&Delete";
            this.barItemEditDelete.Click += new System.EventHandler(this.barItemEditDelete_Click);
            // 
            // barItemEditCut
            // 
            this.barItemEditCut.BarName = "barItemEditCut";
            this.barItemEditCut.CategoryIndex = 3;
            this.barItemEditCut.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.barItemEditCut.ID = "Cut";
            this.barItemEditCut.ImageIndex = 8;
            this.barItemEditCut.ImageList = this.smallImageList;
            this.barItemEditCut.Shortcut = System.Windows.Forms.Shortcut.CtrlX;
            this.barItemEditCut.ShowToolTipInPopUp = false;
            this.barItemEditCut.SizeToFit = true;
            this.barItemEditCut.Text = "C&ut";
            this.barItemEditCut.Click += new System.EventHandler(this.barItemEditCut_Click);
            // 
            // barItemEditCopy
            // 
            this.barItemEditCopy.BarName = "barItemEditCopy";
            this.barItemEditCopy.CategoryIndex = 3;
            this.barItemEditCopy.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.barItemEditCopy.ID = "Copy";
            this.barItemEditCopy.ImageIndex = 7;
            this.barItemEditCopy.ImageList = this.smallImageList;
            this.barItemEditCopy.Shortcut = System.Windows.Forms.Shortcut.CtrlC;
            this.barItemEditCopy.ShowToolTipInPopUp = false;
            this.barItemEditCopy.SizeToFit = true;
            this.barItemEditCopy.Text = "&Copy";
            this.barItemEditCopy.Click += new System.EventHandler(this.barItemEditCopy_Click);
            // 
            // barItemEditPaste
            // 
            this.barItemEditPaste.BarName = "barItemEditPaste";
            this.barItemEditPaste.CategoryIndex = 3;
            this.barItemEditPaste.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.barItemEditPaste.ID = "Paste";
            this.barItemEditPaste.ImageIndex = 9;
            this.barItemEditPaste.ImageList = this.smallImageList;
            this.barItemEditPaste.Shortcut = System.Windows.Forms.Shortcut.CtrlV;
            this.barItemEditPaste.ShowToolTipInPopUp = false;
            this.barItemEditPaste.SizeToFit = true;
            this.barItemEditPaste.Text = "&Paste";
            this.barItemEditPaste.Click += new System.EventHandler(this.barItemEditPaste_Click);
            // 
            // parentBarItemFormat
            // 
            this.parentBarItemFormat.BarName = "parentBarItemFormat";
            this.parentBarItemFormat.CategoryIndex = 0;
            this.parentBarItemFormat.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.parentBarItemFormat.ID = "Format";
            this.parentBarItemFormat.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.barItemFillStyle,
            this.barItemShadowStyle});
            this.parentBarItemFormat.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(201)))), ((int)(((byte)(232)))));
            this.parentBarItemFormat.ShowToolTipInPopUp = false;
            this.parentBarItemFormat.SizeToFit = true;
            this.parentBarItemFormat.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007;
            this.parentBarItemFormat.Text = "&Format";
            this.parentBarItemFormat.WrapLength = 20;
            // 
            // barItemFillStyle
            // 
            this.barItemFillStyle.BarName = "barItemFillStyle";
            this.barItemFillStyle.CategoryIndex = 14;
            this.barItemFillStyle.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.barItemFillStyle.ID = "Fill";
            this.barItemFillStyle.ShowToolTipInPopUp = false;
            this.barItemFillStyle.SizeToFit = true;
            this.barItemFillStyle.Text = "&Fill...";
            this.barItemFillStyle.Click += new System.EventHandler(this.fillBarItem_Click);
            // 
            // barItemShadowStyle
            // 
            this.barItemShadowStyle.BarName = "barItemShadowStyle";
            this.barItemShadowStyle.CategoryIndex = 14;
            this.barItemShadowStyle.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.barItemShadowStyle.ID = "Shadow";
            this.barItemShadowStyle.ShowToolTipInPopUp = false;
            this.barItemShadowStyle.SizeToFit = true;
            this.barItemShadowStyle.Text = "&Shadow...";
            this.barItemShadowStyle.Click += new System.EventHandler(this.shadowBarItem_Click);
            // 
            // parentBarItemView
            // 
            this.parentBarItemView.BarName = "parentBarItemView";
            this.parentBarItemView.CategoryIndex = 0;
            this.parentBarItemView.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.parentBarItemView.ID = "View";
            this.parentBarItemView.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.barShowRulers,
            this.barItemViewSymbolPalette,
            this.barItemViewAssSymbols,
            this.barItemViewProperties,
            this.barItemPanZoom,
            this.barItemDocumentExplorer,
            this.barItemHeaderFooter,
            this.barItemPageBorders});
            this.parentBarItemView.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(201)))), ((int)(((byte)(232)))));
            this.parentBarItemView.SeparatorIndices.AddRange(new int[] {
            3});
            this.parentBarItemView.ShowToolTipInPopUp = false;
            this.parentBarItemView.SizeToFit = true;
            this.parentBarItemView.Text = "&View";
            this.parentBarItemView.WrapLength = 20;
            // 
            // barShowRulers
            // 
            this.barShowRulers.BarName = "barShowRulers";
            this.barShowRulers.CategoryIndex = 4;
            this.barShowRulers.Checked = true;
            this.barShowRulers.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.barShowRulers.ID = "Rulers";
            this.barShowRulers.ShowToolTipInPopUp = false;
            this.barShowRulers.SizeToFit = true;
            this.barShowRulers.Text = "Rulers";
            this.barShowRulers.Click += new System.EventHandler(this.barShowRulers_Click);
            // 
            // barItemViewSymbolPalette
            // 
            this.barItemViewSymbolPalette.BarName = "barItemViewSymbolPalette";
            this.barItemViewSymbolPalette.CategoryIndex = 4;
            this.barItemViewSymbolPalette.Checked = true;
            this.barItemViewSymbolPalette.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.barItemViewSymbolPalette.ID = "Symbol SymbolPalette";
            this.barItemViewSymbolPalette.ShowToolTipInPopUp = false;
            this.barItemViewSymbolPalette.SizeToFit = true;
            this.barItemViewSymbolPalette.Text = "Symbol Palette";
            this.barItemViewSymbolPalette.Click += new System.EventHandler(this.barItemViewSymbolPalette_Click);
            // 
            // barItemViewAssSymbols
            // 
            this.barItemViewAssSymbols.BarName = "barItemViewAssSymbols";
            this.barItemViewAssSymbols.CategoryIndex = 4;
            this.barItemViewAssSymbols.Checked = true;
            this.barItemViewAssSymbols.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.barItemViewAssSymbols.ID = "Associated SymbolPalttes List";
            this.barItemViewAssSymbols.ShowToolTipInPopUp = false;
            this.barItemViewAssSymbols.SizeToFit = true;
            this.barItemViewAssSymbols.Text = "Associated SymbolPalttes List";
            this.barItemViewAssSymbols.Click += new System.EventHandler(this.barItemViewAssSymbols_Click);
            // 
            // barItemViewProperties
            // 
            this.barItemViewProperties.BarName = "barItemViewProperties";
            this.barItemViewProperties.CategoryIndex = 4;
            this.barItemViewProperties.Checked = true;
            this.barItemViewProperties.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.barItemViewProperties.ID = "Properties";
            this.barItemViewProperties.ShowToolTipInPopUp = false;
            this.barItemViewProperties.SizeToFit = true;
            this.barItemViewProperties.Text = "Properties";
            this.barItemViewProperties.Click += new System.EventHandler(this.barItemViewProperties_Click);
            // 
            // barItemPanZoom
            // 
            this.barItemPanZoom.BarName = "barItemPanZoom";
            this.barItemPanZoom.CategoryIndex = 4;
            this.barItemPanZoom.Checked = true;
            this.barItemPanZoom.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.barItemPanZoom.ID = "panZoomWindow";
            this.barItemPanZoom.ShowToolTipInPopUp = false;
            this.barItemPanZoom.SizeToFit = true;
            this.barItemPanZoom.Text = "Pan & Zoom Window";
            this.barItemPanZoom.Tooltip = "Pan & Zoom Window";
            this.barItemPanZoom.Click += new System.EventHandler(this.barItemPanZoom_Click);
            // 
            // barItemDocumentExplorer
            // 
            this.barItemDocumentExplorer.BarName = "barItemDocumentExplorer";
            this.barItemDocumentExplorer.CategoryIndex = 4;
            this.barItemDocumentExplorer.Checked = true;
            this.barItemDocumentExplorer.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.barItemDocumentExplorer.ID = "DocumentExplorer";
            this.barItemDocumentExplorer.ShowToolTipInPopUp = false;
            this.barItemDocumentExplorer.SizeToFit = true;
            this.barItemDocumentExplorer.Text = "Document Explorer";
            this.barItemDocumentExplorer.Tooltip = "Document Explorer";
            this.barItemDocumentExplorer.Click += new System.EventHandler(this.barItemDocumentExplorer_Click);
            // 
            // barItemHeaderFooter
            // 
            this.barItemHeaderFooter.BarName = "barItemHeaderFooter";
            this.barItemHeaderFooter.CategoryIndex = 4;
            this.barItemHeaderFooter.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.barItemHeaderFooter.ID = "Header Footer";
            this.barItemHeaderFooter.ShowToolTipInPopUp = false;
            this.barItemHeaderFooter.SizeToFit = true;
            this.barItemHeaderFooter.Text = "Header Footer...";
            this.barItemHeaderFooter.Click += new System.EventHandler(this.barItemHeaderFooter_Click);
            // 
            // barItemPageBorders
            // 
            this.barItemPageBorders.BarName = "barItemPageBorders";
            this.barItemPageBorders.CategoryIndex = 4;
            this.barItemPageBorders.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.barItemPageBorders.ID = "Page Borders";
            this.barItemPageBorders.ShowToolTipInPopUp = false;
            this.barItemPageBorders.SizeToFit = true;
            this.barItemPageBorders.Text = "Page Borders...";
            this.barItemPageBorders.Click += new System.EventHandler(this.barItemPageBorders_Click);
            // 
            // parentBarItemActions
            // 
            this.parentBarItemActions.BarName = "parentBarItemActions";
            this.parentBarItemActions.CategoryIndex = 0;
            this.parentBarItemActions.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.parentBarItemActions.ID = "Actions";
            this.parentBarItemActions.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.parentBarItemAlign,
            this.parentBarItemFlip,
            this.parentBarItemToolsGrouping,
            this.parentBarItemToolsOrder,
            this.parentBarItemRotate,
            this.parentBarItemResize,
            this.barItemLayout});
            this.parentBarItemActions.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(201)))), ((int)(((byte)(232)))));
            this.parentBarItemActions.ShowToolTipInPopUp = false;
            this.parentBarItemActions.SizeToFit = true;
            this.parentBarItemActions.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007;
            this.parentBarItemActions.Text = "&Actions";
            this.parentBarItemActions.WrapLength = 20;
            // 
            // parentBarItemAlign
            // 
            this.parentBarItemAlign.BarName = "parentBarItemAlign";
            this.parentBarItemAlign.CategoryIndex = 0;
            this.parentBarItemAlign.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.parentBarItemAlign.ID = "Align";
            this.parentBarItemAlign.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.barItemAlignLeft,
            this.barItemAlignCenter,
            this.barItemAlignRight,
            this.barItemAlignTop,
            this.barItemAlignMiddle,
            this.barItemAlignBottom});
            this.parentBarItemAlign.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(201)))), ((int)(((byte)(232)))));
            this.parentBarItemAlign.ShowToolTipInPopUp = false;
            this.parentBarItemAlign.SizeToFit = true;
            this.parentBarItemAlign.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007;
            this.parentBarItemAlign.Text = "&Align";
            this.parentBarItemAlign.WrapLength = 20;
            // 
            // barItemAlignLeft
            // 
            this.barItemAlignLeft.BarName = "barItemAlignLeft";
            this.barItemAlignLeft.CategoryIndex = 8;
            this.barItemAlignLeft.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.barItemAlignLeft.ID = "AlignLeft";
            this.barItemAlignLeft.ImageIndex = 15;
            this.barItemAlignLeft.ImageList = this.smallImageList;
            this.barItemAlignLeft.ShowToolTipInPopUp = false;
            this.barItemAlignLeft.SizeToFit = true;
            this.barItemAlignLeft.Text = "Align Left";
            this.barItemAlignLeft.Click += new System.EventHandler(this.barItemAlign_Click);
            // 
            // barItemAlignCenter
            // 
            this.barItemAlignCenter.BarName = "barItemAlignCenter";
            this.barItemAlignCenter.CategoryIndex = 8;
            this.barItemAlignCenter.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.barItemAlignCenter.ID = "AlignCenter";
            this.barItemAlignCenter.ImageIndex = 14;
            this.barItemAlignCenter.ImageList = this.smallImageList;
            this.barItemAlignCenter.ShowToolTipInPopUp = false;
            this.barItemAlignCenter.SizeToFit = true;
            this.barItemAlignCenter.Text = "Align Center";
            this.barItemAlignCenter.Click += new System.EventHandler(this.barItemAlign_Click);
            // 
            // barItemAlignRight
            // 
            this.barItemAlignRight.BarName = "barItemAlignRight";
            this.barItemAlignRight.CategoryIndex = 8;
            this.barItemAlignRight.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.barItemAlignRight.ID = "AlignRight";
            this.barItemAlignRight.ImageIndex = 17;
            this.barItemAlignRight.ImageList = this.smallImageList;
            this.barItemAlignRight.ShowToolTipInPopUp = false;
            this.barItemAlignRight.SizeToFit = true;
            this.barItemAlignRight.Text = "Align Right";
            this.barItemAlignRight.Click += new System.EventHandler(this.barItemAlign_Click);
            // 
            // barItemAlignTop
            // 
            this.barItemAlignTop.BarName = "barItemAlignTop";
            this.barItemAlignTop.CategoryIndex = 8;
            this.barItemAlignTop.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.barItemAlignTop.ID = "AlignTop";
            this.barItemAlignTop.ImageIndex = 18;
            this.barItemAlignTop.ImageList = this.smallImageList;
            this.barItemAlignTop.ShowToolTipInPopUp = false;
            this.barItemAlignTop.SizeToFit = true;
            this.barItemAlignTop.Text = "Align Top";
            this.barItemAlignTop.Click += new System.EventHandler(this.barItemAlign_Click);
            // 
            // barItemAlignMiddle
            // 
            this.barItemAlignMiddle.BarName = "barItemAlignMiddle";
            this.barItemAlignMiddle.CategoryIndex = 8;
            this.barItemAlignMiddle.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.barItemAlignMiddle.ID = "AlignMiddle";
            this.barItemAlignMiddle.ImageIndex = 16;
            this.barItemAlignMiddle.ImageList = this.smallImageList;
            this.barItemAlignMiddle.ShowToolTipInPopUp = false;
            this.barItemAlignMiddle.SizeToFit = true;
            this.barItemAlignMiddle.Text = "Align Middle";
            this.barItemAlignMiddle.Click += new System.EventHandler(this.barItemAlign_Click);
            // 
            // barItemAlignBottom
            // 
            this.barItemAlignBottom.BarName = "barItemAlignBottom";
            this.barItemAlignBottom.CategoryIndex = 8;
            this.barItemAlignBottom.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.barItemAlignBottom.ID = "AlignBottom";
            this.barItemAlignBottom.ImageIndex = 13;
            this.barItemAlignBottom.ImageList = this.smallImageList;
            this.barItemAlignBottom.ShowToolTipInPopUp = false;
            this.barItemAlignBottom.SizeToFit = true;
            this.barItemAlignBottom.Text = "Align Bottom";
            this.barItemAlignBottom.Click += new System.EventHandler(this.barItemAlign_Click);
            // 
            // parentBarItemFlip
            // 
            this.parentBarItemFlip.BarName = "parentBarItemFlip";
            this.parentBarItemFlip.CategoryIndex = 0;
            this.parentBarItemFlip.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.parentBarItemFlip.ID = "Flip";
            this.parentBarItemFlip.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.barItemFlipHorizontally,
            this.barItemFlipVertically,
            this.barItemFlipBoth});
            this.parentBarItemFlip.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(201)))), ((int)(((byte)(232)))));
            this.parentBarItemFlip.ShowToolTipInPopUp = false;
            this.parentBarItemFlip.SizeToFit = true;
            this.parentBarItemFlip.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007;
            this.parentBarItemFlip.Text = "&Flip";
            this.parentBarItemFlip.WrapLength = 20;
            // 
            // barItemFlipHorizontally
            // 
            this.barItemFlipHorizontally.BarName = "barItemFlipHorizontally";
            this.barItemFlipHorizontally.CategoryIndex = 9;
            this.barItemFlipHorizontally.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.barItemFlipHorizontally.ID = "FlipHorizontally";
            this.barItemFlipHorizontally.ImageIndex = 20;
            this.barItemFlipHorizontally.ImageList = this.smallImageList;
            this.barItemFlipHorizontally.ShowToolTipInPopUp = false;
            this.barItemFlipHorizontally.SizeToFit = true;
            this.barItemFlipHorizontally.Text = "Flip Horizontally";
            this.barItemFlipHorizontally.Click += new System.EventHandler(this.barItemFlip_Click);
            // 
            // barItemFlipVertically
            // 
            this.barItemFlipVertically.BarName = "barItemFlipVertically";
            this.barItemFlipVertically.CategoryIndex = 9;
            this.barItemFlipVertically.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.barItemFlipVertically.ID = "FlipVertically";
            this.barItemFlipVertically.ImageIndex = 19;
            this.barItemFlipVertically.ImageList = this.smallImageList;
            this.barItemFlipVertically.ShowToolTipInPopUp = false;
            this.barItemFlipVertically.SizeToFit = true;
            this.barItemFlipVertically.Text = "Flip Vertically";
            this.barItemFlipVertically.Click += new System.EventHandler(this.barItemFlip_Click);
            // 
            // barItemFlipBoth
            // 
            this.barItemFlipBoth.BarName = "barItemFlipBoth";
            this.barItemFlipBoth.CategoryIndex = 9;
            this.barItemFlipBoth.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.barItemFlipBoth.ID = "FlipBoth";
            this.barItemFlipBoth.ShowToolTipInPopUp = false;
            this.barItemFlipBoth.SizeToFit = true;
            this.barItemFlipBoth.Text = "Flip Both";
            this.barItemFlipBoth.Click += new System.EventHandler(this.barItemFlip_Click);
            // 
            // parentBarItemToolsGrouping
            // 
            this.parentBarItemToolsGrouping.BarName = "parentBarItemToolsGrouping";
            this.parentBarItemToolsGrouping.CategoryIndex = 0;
            this.parentBarItemToolsGrouping.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.parentBarItemToolsGrouping.ID = "Grouping";
            this.parentBarItemToolsGrouping.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.barItemGroupingGroup,
            this.barItemGroupingUnGroup});
            this.parentBarItemToolsGrouping.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(201)))), ((int)(((byte)(232)))));
            this.parentBarItemToolsGrouping.ShowToolTipInPopUp = false;
            this.parentBarItemToolsGrouping.SizeToFit = true;
            this.parentBarItemToolsGrouping.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007;
            this.parentBarItemToolsGrouping.Text = "&Grouping";
            this.parentBarItemToolsGrouping.WrapLength = 20;
            // 
            // barItemGroupingGroup
            // 
            this.barItemGroupingGroup.BarName = "barItemGroupingGroup";
            this.barItemGroupingGroup.CategoryIndex = 10;
            this.barItemGroupingGroup.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.barItemGroupingGroup.ID = "Group";
            this.barItemGroupingGroup.ImageIndex = 21;
            this.barItemGroupingGroup.ImageList = this.smallImageList;
            this.barItemGroupingGroup.ShowToolTipInPopUp = false;
            this.barItemGroupingGroup.SizeToFit = true;
            this.barItemGroupingGroup.Text = "Group";
            this.barItemGroupingGroup.Click += new System.EventHandler(this.barItemGroupingGroup_Click);
            // 
            // barItemGroupingUnGroup
            // 
            this.barItemGroupingUnGroup.BarName = "barItemGroupingUnGroup";
            this.barItemGroupingUnGroup.CategoryIndex = 10;
            this.barItemGroupingUnGroup.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.barItemGroupingUnGroup.ID = "UnGroup";
            this.barItemGroupingUnGroup.ImageIndex = 22;
            this.barItemGroupingUnGroup.ImageList = this.smallImageList;
            this.barItemGroupingUnGroup.ShowToolTipInPopUp = false;
            this.barItemGroupingUnGroup.SizeToFit = true;
            this.barItemGroupingUnGroup.Text = "UnGroup";
            this.barItemGroupingUnGroup.Click += new System.EventHandler(this.barItemGroupingGroup_Click);
            // 
            // parentBarItemToolsOrder
            // 
            this.parentBarItemToolsOrder.BarName = "parentBarItemToolsOrder";
            this.parentBarItemToolsOrder.CategoryIndex = 0;
            this.parentBarItemToolsOrder.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.parentBarItemToolsOrder.ID = "Order";
            this.parentBarItemToolsOrder.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.barItemOrderFront,
            this.barItemOrderForward,
            this.barItemOrderBackward,
            this.barItemOrderBack});
            this.parentBarItemToolsOrder.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(201)))), ((int)(((byte)(232)))));
            this.parentBarItemToolsOrder.ShowToolTipInPopUp = false;
            this.parentBarItemToolsOrder.SizeToFit = true;
            this.parentBarItemToolsOrder.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007;
            this.parentBarItemToolsOrder.Text = "&Order";
            this.parentBarItemToolsOrder.WrapLength = 20;
            // 
            // barItemOrderFront
            // 
            this.barItemOrderFront.BarName = "barItemOrderFront";
            this.barItemOrderFront.CategoryIndex = 11;
            this.barItemOrderFront.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.barItemOrderFront.ID = "Bring to Front";
            this.barItemOrderFront.ImageIndex = 26;
            this.barItemOrderFront.ImageList = this.smallImageList;
            this.barItemOrderFront.ShowToolTipInPopUp = false;
            this.barItemOrderFront.SizeToFit = true;
            this.barItemOrderFront.Text = "Bring to Front";
            this.barItemOrderFront.Click += new System.EventHandler(this.barItemOrder_Click);
            // 
            // barItemOrderForward
            // 
            this.barItemOrderForward.BarName = "barItemOrderForward";
            this.barItemOrderForward.CategoryIndex = 11;
            this.barItemOrderForward.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.barItemOrderForward.ID = "Bring Forward";
            this.barItemOrderForward.ImageIndex = 25;
            this.barItemOrderForward.ImageList = this.smallImageList;
            this.barItemOrderForward.ShowToolTipInPopUp = false;
            this.barItemOrderForward.SizeToFit = true;
            this.barItemOrderForward.Text = "Bring Forward";
            this.barItemOrderForward.Click += new System.EventHandler(this.barItemOrder_Click);
            // 
            // barItemOrderBackward
            // 
            this.barItemOrderBackward.BarName = "barItemOrderBackward";
            this.barItemOrderBackward.CategoryIndex = 11;
            this.barItemOrderBackward.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.barItemOrderBackward.ID = "Send Backward";
            this.barItemOrderBackward.ImageIndex = 27;
            this.barItemOrderBackward.ImageList = this.smallImageList;
            this.barItemOrderBackward.ShowToolTipInPopUp = false;
            this.barItemOrderBackward.SizeToFit = true;
            this.barItemOrderBackward.Text = "Send Backward";
            this.barItemOrderBackward.Click += new System.EventHandler(this.barItemOrder_Click);
            // 
            // barItemOrderBack
            // 
            this.barItemOrderBack.BarName = "barItemOrderBack";
            this.barItemOrderBack.CategoryIndex = 11;
            this.barItemOrderBack.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.barItemOrderBack.ID = "Send to Back";
            this.barItemOrderBack.ImageIndex = 28;
            this.barItemOrderBack.ImageList = this.smallImageList;
            this.barItemOrderBack.ShowToolTipInPopUp = false;
            this.barItemOrderBack.SizeToFit = true;
            this.barItemOrderBack.Text = "Send to Back";
            this.barItemOrderBack.Click += new System.EventHandler(this.barItemOrder_Click);
            // 
            // parentBarItemRotate
            // 
            this.parentBarItemRotate.BarName = "parentBarItemRotate";
            this.parentBarItemRotate.CategoryIndex = 0;
            this.parentBarItemRotate.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.parentBarItemRotate.ID = "Rotate";
            this.parentBarItemRotate.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.barItemRotateClock,
            this.barItemRotateConter});
            this.parentBarItemRotate.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(201)))), ((int)(((byte)(232)))));
            this.parentBarItemRotate.ShowToolTipInPopUp = false;
            this.parentBarItemRotate.SizeToFit = true;
            this.parentBarItemRotate.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007;
            this.parentBarItemRotate.Text = "&Rotate";
            this.parentBarItemRotate.WrapLength = 20;
            // 
            // barItemRotateClock
            // 
            this.barItemRotateClock.BarName = "barItemRotateClock";
            this.barItemRotateClock.CategoryIndex = 12;
            this.barItemRotateClock.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.barItemRotateClock.ID = "RotateClock";
            this.barItemRotateClock.ImageIndex = 24;
            this.barItemRotateClock.ImageList = this.smallImageList;
            this.barItemRotateClock.ShowToolTipInPopUp = false;
            this.barItemRotateClock.SizeToFit = true;
            this.barItemRotateClock.Text = "Rotate 90 clockwise";
            this.barItemRotateClock.Click += new System.EventHandler(this.barItemRotate_Click);
            // 
            // barItemRotateConter
            // 
            this.barItemRotateConter.BarName = "barItemRotateConter";
            this.barItemRotateConter.CategoryIndex = 12;
            this.barItemRotateConter.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.barItemRotateConter.ID = "RotateConter";
            this.barItemRotateConter.ImageIndex = 23;
            this.barItemRotateConter.ImageList = this.smallImageList;
            this.barItemRotateConter.ShowToolTipInPopUp = false;
            this.barItemRotateConter.SizeToFit = true;
            this.barItemRotateConter.Text = "Rotate 90 conter-clockwise";
            this.barItemRotateConter.Click += new System.EventHandler(this.barItemRotate_Click);
            // 
            // parentBarItemResize
            // 
            this.parentBarItemResize.BarName = "parentBarItemResize";
            this.parentBarItemResize.CategoryIndex = 0;
            this.parentBarItemResize.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.parentBarItemResize.ID = "Resize";
            this.parentBarItemResize.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.barItemResizeWidth,
            this.barItemResizeHeight,
            this.barItemResizeSize,
            this.barItemResizeAcross,
            this.barItemResizeDown});
            this.parentBarItemResize.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(201)))), ((int)(((byte)(232)))));
            this.parentBarItemResize.SeparatorIndices.AddRange(new int[] {
            3});
            this.parentBarItemResize.ShowToolTipInPopUp = false;
            this.parentBarItemResize.SizeToFit = true;
            this.parentBarItemResize.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007;
            this.parentBarItemResize.Text = "R&esize";
            this.parentBarItemResize.WrapLength = 20;
            // 
            // barItemResizeWidth
            // 
            this.barItemResizeWidth.BarName = "barItemResizeWidth";
            this.barItemResizeWidth.CategoryIndex = 13;
            this.barItemResizeWidth.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.barItemResizeWidth.ID = "SameWidth";
            this.barItemResizeWidth.ImageIndex = 31;
            this.barItemResizeWidth.ImageList = this.smallImageList;
            this.barItemResizeWidth.ShowToolTipInPopUp = false;
            this.barItemResizeWidth.SizeToFit = true;
            this.barItemResizeWidth.Text = "Same Width";
            this.barItemResizeWidth.Click += new System.EventHandler(this.barItemResize_Click);
            // 
            // barItemResizeHeight
            // 
            this.barItemResizeHeight.BarName = "barItemResizeHeight";
            this.barItemResizeHeight.CategoryIndex = 13;
            this.barItemResizeHeight.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.barItemResizeHeight.ID = "SameHeight";
            this.barItemResizeHeight.ImageIndex = 29;
            this.barItemResizeHeight.ImageList = this.smallImageList;
            this.barItemResizeHeight.ShowToolTipInPopUp = false;
            this.barItemResizeHeight.SizeToFit = true;
            this.barItemResizeHeight.Text = "Same Height";
            this.barItemResizeHeight.Click += new System.EventHandler(this.barItemResize_Click);
            // 
            // barItemResizeSize
            // 
            this.barItemResizeSize.BarName = "barItemResizeSize";
            this.barItemResizeSize.CategoryIndex = 13;
            this.barItemResizeSize.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.barItemResizeSize.ID = "SameSize";
            this.barItemResizeSize.ImageIndex = 30;
            this.barItemResizeSize.ImageList = this.smallImageList;
            this.barItemResizeSize.ShowToolTipInPopUp = false;
            this.barItemResizeSize.SizeToFit = true;
            this.barItemResizeSize.Text = "Same Size";
            this.barItemResizeSize.Click += new System.EventHandler(this.barItemResize_Click);
            // 
            // barItemResizeAcross
            // 
            this.barItemResizeAcross.BarName = "barItemResizeAcross";
            this.barItemResizeAcross.CategoryIndex = 13;
            this.barItemResizeAcross.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.barItemResizeAcross.ID = "SpaceAcross";
            this.barItemResizeAcross.ImageIndex = 32;
            this.barItemResizeAcross.ImageList = this.smallImageList;
            this.barItemResizeAcross.ShowToolTipInPopUp = false;
            this.barItemResizeAcross.SizeToFit = true;
            this.barItemResizeAcross.Text = "Space Across";
            this.barItemResizeAcross.Click += new System.EventHandler(this.barItemResize_Click);
            // 
            // barItemResizeDown
            // 
            this.barItemResizeDown.BarName = "barItemResizeDown";
            this.barItemResizeDown.CategoryIndex = 13;
            this.barItemResizeDown.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.barItemResizeDown.ID = "SpaceDown";
            this.barItemResizeDown.ImageIndex = 33;
            this.barItemResizeDown.ImageList = this.smallImageList;
            this.barItemResizeDown.ShowToolTipInPopUp = false;
            this.barItemResizeDown.SizeToFit = true;
            this.barItemResizeDown.Text = "Space Down";
            this.barItemResizeDown.Click += new System.EventHandler(this.barItemResize_Click);
            // 
            // barItemLayout
            // 
            this.barItemLayout.BarName = "barItemLayout";
            this.barItemLayout.CategoryIndex = 0;
            this.barItemLayout.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.barItemLayout.ID = "Layout nodes";
            this.barItemLayout.ShowToolTipInPopUp = false;
            this.barItemLayout.SizeToFit = true;
            this.barItemLayout.Text = "Layout nodes...";
            this.barItemLayout.Click += new System.EventHandler(this.barItemLayout_Click);
            // 
            // parentBarItemWindow
            // 
            this.parentBarItemWindow.BarName = "parentBarItemWindow";
            this.parentBarItemWindow.CategoryIndex = 0;
            this.parentBarItemWindow.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.parentBarItemWindow.ID = "Window";
            this.parentBarItemWindow.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.biTabbedMDI});
            this.parentBarItemWindow.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(201)))), ((int)(((byte)(232)))));
            this.parentBarItemWindow.ShowToolTipInPopUp = false;
            this.parentBarItemWindow.SizeToFit = true;
            this.parentBarItemWindow.Text = "&Window";
            this.parentBarItemWindow.WrapLength = 20;
            // 
            // biTabbedMDI
            // 
            this.biTabbedMDI.BarName = "biTabbedMDI";
            this.biTabbedMDI.CategoryIndex = 2;
            this.biTabbedMDI.Checked = true;
            this.biTabbedMDI.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.biTabbedMDI.ID = "Tabbed MDI";
            this.biTabbedMDI.ShowToolTipInPopUp = false;
            this.biTabbedMDI.SizeToFit = true;
            this.biTabbedMDI.Text = "Tabbed MDI";
            this.biTabbedMDI.Click += new System.EventHandler(this.biTabbedMDI_Click);
            // 
            // parentBarItemHelp
            // 
            this.parentBarItemHelp.BarName = "parentBarItemHelp";
            this.parentBarItemHelp.CategoryIndex = 0;
            this.parentBarItemHelp.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.parentBarItemHelp.ID = "Help";
            this.parentBarItemHelp.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.barItemAbout});
            this.parentBarItemHelp.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(201)))), ((int)(((byte)(232)))));
            this.parentBarItemHelp.ShowToolTipInPopUp = false;
            this.parentBarItemHelp.SizeToFit = true;
            this.parentBarItemHelp.Text = "&Help";
            this.parentBarItemHelp.WrapLength = 20;
            // 
            // barItemAbout
            // 
            this.barItemAbout.BarName = "barItemAbout";
            this.barItemAbout.CategoryIndex = 5;
            this.barItemAbout.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.barItemAbout.ID = "About";
            this.barItemAbout.ShowToolTipInPopUp = false;
            this.barItemAbout.SizeToFit = true;
            this.barItemAbout.Text = "About...";
            this.barItemAbout.Click += new System.EventHandler(this.barItemAbout_Click);
            // 
            // standardToolbar
            // 
            this.standardToolbar.BarName = "Standard";
            this.standardToolbar.BarStyle = ((Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle)((((Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.AllowQuickCustomizing | Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.RotateWhenVertical)
                        | Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.Visible)
                        | Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.DrawDragBorder)));
            this.standardToolbar.Caption = "Standard";
            this.standardToolbar.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.biFileNew,
            this.biFileOpen,
            this.biFileSave,
            this.biPrintPreview,
            this.biFilePrint});
            this.standardToolbar.Manager = this.mainFrameBarManager;
            // 
            // parentBarItemPopUp
            // 
            this.parentBarItemPopUp.BarName = "parentBarItemPopUp";
            this.parentBarItemPopUp.CategoryIndex = 0;
            this.parentBarItemPopUp.Customizable = false;
            this.parentBarItemPopUp.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.parentBarItemPopUp.ID = "PopUpMenu";
            this.parentBarItemPopUp.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.barItemEditCut,
            this.barItemEditCopy,
            this.barItemEditPaste,
            this.barItemEditDelete,
            this.parentBarItemActions,
            this.parentBarItemFormat});
            this.parentBarItemPopUp.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(201)))), ((int)(((byte)(232)))));
            this.parentBarItemPopUp.SeparatorIndices.AddRange(new int[] {
            3,
            4});
            this.parentBarItemPopUp.ShowTooltip = false;
            this.parentBarItemPopUp.ShowToolTipInPopUp = false;
            this.parentBarItemPopUp.SizeToFit = true;
            this.parentBarItemPopUp.Text = "PopUpMenu";
            this.parentBarItemPopUp.UsePartialMenus = false;
            this.parentBarItemPopUp.Visible = false;
            this.parentBarItemPopUp.WrapLength = 20;
            // 
            // parentBarItemNode
            // 
            this.parentBarItemNode.BarName = "parentBarItemNode";
            this.parentBarItemNode.CategoryIndex = 0;
            this.parentBarItemNode.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.parentBarItemNode.ID = "NodeMenu";
            this.parentBarItemNode.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.barItemEditCut,
            this.barItemEditCopy,
            this.barItemEditPaste,
            this.parentBarItemActions});
            this.parentBarItemNode.MetroColor = System.Drawing.Color.LightSkyBlue;
            this.parentBarItemNode.SeparatorIndices.AddRange(new int[] {
            3});
            this.parentBarItemNode.ShowToolTipInPopUp = false;
            this.parentBarItemNode.SizeToFit = true;
            this.parentBarItemNode.Text = "NodeMenu";
            this.parentBarItemNode.Visible = false;
            this.parentBarItemNode.WrapLength = 20;
            // 
            // MainForm
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(792, 623);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Diagram Builder";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MdiChildActivate += new System.EventHandler(this.MainForm_MdiChildActivate);
            ((System.ComponentModel.ISupportInitialize)(this.dockingManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.symbolPaletteGroupBar)).EndInit();
            this.pnlAssSymbols.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mainFrameBarManager)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion

        private Tools.DockingManager dockingManager;
        private Tools.TabbedMDIManager tabbedMDIManager;
        private OpenFileDialog openPaletteDialog;
        private OpenFileDialog openDiagramDialog;
        private SaveFileDialog saveDiagramDialog;
        private SaveFileDialog savePaletteDialog;
        private OpenFileDialog openImageDialog;
        private PaletteGroupBar symbolPaletteGroupBar;
        private Tools.XPMenus.MainFrameBarManager mainFrameBarManager;
        private Tools.XPMenus.Bar mainMenuBar;
        private Tools.XPMenus.BarItem biFileNew;
        private Tools.XPMenus.BarItem biFileOpen;
        private Tools.XPMenus.BarItem biFileSave;
        private Tools.XPMenus.BarItem biFileSaveAs;
        private Tools.XPMenus.BarItem biAddPalette;
        private Tools.XPMenus.BarItem biSavePalette;
        private Tools.XPMenus.BarItem biFileExit;
        private Tools.XPMenus.BarItem barShowRulers;
        private Tools.XPMenus.BarItem biTabbedMDI;
        private Tools.XPMenus.BarItem barItemEditCut;
        private Tools.XPMenus.BarItem barItemEditCopy;
        private Tools.XPMenus.BarItem barItemEditPaste;
        private Tools.XPMenus.BarItem barItemEditUndo;
        private Tools.XPMenus.BarItem barItemEditRedo;
        private Tools.XPMenus.BarItem barItemEditDelete;
        private Tools.XPMenus.BarItem barItemAbout;
        private PropertyEditor propertyEditor;
        private Tools.XPMenus.Bar standardToolbar;
        private Tools.XPMenus.BarItem biFilePrint;
        private Tools.XPMenus.BarItem biPageSetup;
        private Tools.XPMenus.BarItem barItemViewSymbolPalette;
        private Tools.XPMenus.BarItem barItemViewProperties;
        private Tools.XPMenus.BarItem barItemEditSelectAll;
        private Tools.XPMenus.ParentBarItem parentBarItemEdit;
        private Tools.XPMenus.ParentBarItem parentBarItemFile;
        private Tools.XPMenus.ParentBarItem parentBarItemView;
        private Tools.XPMenus.ParentBarItem parentBarItemWindow;
        private Tools.XPMenus.ParentBarItem parentBarItemHelp;
        private ImageList smallImageList;
        private DocumentExplorer m_documentExplorer;
        private Tools.XPMenus.BarItem barItemDocumentExplorer;
        private ResourceManager resStringMgr;
        private Tools.XPMenus.BarItem biPrintPreview;
        private Tools.XPMenus.BarItem barItemPanZoom;
        private OverviewControl overviewControl1;
        private Tools.XPMenus.BarItem barItemHeaderFooter;
        private Tools.XPMenus.BarItem barItemPageBorders;
        private Tools.XPMenus.ParentBarItem parentBarItemToolsGrouping;
        private Tools.XPMenus.ParentBarItem parentBarItemToolsOrder;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItemAlignLeft;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItemAlignCenter;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItemAlignRight;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItemAlignTop;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItemAlignMiddle;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItemAlignBottom;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItemFlipHorizontally;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItemFlipVertically;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItemFlipBoth;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItemGroupingGroup;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItemGroupingUnGroup;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItemOrderFront;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItemOrderForward;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItemOrderBackward;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItemOrderBack;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItemRotateClock;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItemRotateConter;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItemResizeWidth;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItemResizeHeight;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItemResizeSize;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItemResizeAcross;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItemResizeDown;
        private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem parentBarItemActions;
        private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem parentBarItemAlign;
        private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem parentBarItemFlip;
        private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem parentBarItemRotate;
        private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem parentBarItemResize;
        private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem parentBarItemNode;
        private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem parentBarItemPopUp;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItemLayout;
        private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem parentBarItemFormat;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItemFillStyle;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItemShadowStyle;
        private CheckedListBox chkListAssSymbols;
        private Panel pnlAssSymbols;
        private ButtonAdv btnRemoveAss;
        private BarItem barItemViewAssSymbols;
    }
}


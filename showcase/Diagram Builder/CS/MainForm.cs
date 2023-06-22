#region Copyright Syncfusion Inc. 2001 - 2023
//
//  Copyright Syncfusion Inc. 2001 - 2023. All rights reserved.
//
//  Use of this code is subject to the terms of our license.
//  A copy of the current license can be obtained at any time by e-mailing
//  licensing@syncfusion.com. Any infringement will be prosecuted under
//  applicable laws. 
//
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
#if !NETCORE
using System.Runtime.Serialization.Formatters.Soap;
#endif
using Syncfusion.Windows.Forms.Diagram;
using Syncfusion.SVG.IO;
using Syncfusion.Windows.Forms.Diagram.Controls;
using Syncfusion.Windows.Forms.Tools;
using Syncfusion.Runtime.Serialization;
using Syncfusion.Windows.Forms.Tools.XPMenus;
using Syncfusion.Licensing;

namespace Syncfusion.Windows.Forms.Diagram.Samples.DiagramTool
{
    /// <summary>
    /// MainForm for the Essential Diagram Builder.
    /// </summary>
    public class MainForm : Office2007Form
    {
        #region Fields
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
        private IContainer components;
        #endregion
        private BarItem biRemovePalette;

        #region Constructors
        string _initialFileLoc = "";
        public MainForm( string fileLocation )
            : this( ) {
            _initialFileLoc = fileLocation;
        }

        public MainForm( ) {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent( );
            this.dockingManager.Office2007Theme = Syncfusion.Windows.Forms.Office2007Theme.Managed;
            symbolPaletteGroupBar.VisualStyle = VisualStyle.Office2003;
            //
            // Initialize tabbed MDI manager
            //
            tabbedMDIManager = new Tools.TabbedMDIManager( );
            tabbedMDIManager.AttachToMdiContainer( this );

            tabbedMDIManager.TabControlAdded += new Syncfusion.Windows.Forms.Tools.TabbedMDITabControlEventHandler( tabbedMDIManager_TabControlAdded );

            // Create resource manager for strings
            this.resStringMgr = new ResourceManager( "Syncfusion.Windows.Forms.Diagram.Samples.DiagramTool.Strings", typeof( MainForm ).Assembly );

            this.Closing += new CancelEventHandler( MainForm_Closing );

            // Wire up OnIdle processing
            Application.Idle += new EventHandler( this.OnIdle );

            #region PropertyEditor Color Settings
            this.propertyEditor.PropertyGrid.BackColor = System.Drawing.Color.FromArgb( ( ( System.Byte )( 227 ) ), ( ( System.Byte )( 239 ) ), ( ( System.Byte )( 255 ) ) );
            this.propertyEditor.PropertyGrid.CommandsBackColor = System.Drawing.Color.FromArgb( ( ( System.Byte )( 227 ) ), ( ( System.Byte )( 239 ) ), ( ( System.Byte )( 255 ) ) );
            this.propertyEditor.PropertyGrid.CommandsForeColor = System.Drawing.Color.MidnightBlue;
            this.propertyEditor.PropertyGrid.Font = new System.Drawing.Font( "Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( System.Byte )( 0 ) ) );
            this.propertyEditor.PropertyGrid.HelpBackColor = System.Drawing.Color.FromArgb( ( ( System.Byte )( 227 ) ), ( ( System.Byte )( 239 ) ), ( ( System.Byte )( 255 ) ) );
            this.propertyEditor.PropertyGrid.HelpForeColor = System.Drawing.Color.MidnightBlue;
            this.propertyEditor.PropertyGrid.LineColor = System.Drawing.Color.FromArgb( ( ( System.Byte )( 185 ) ), ( ( System.Byte )( 216 ) ), ( ( System.Byte )( 255 ) ) );
            this.propertyEditor.PropertyGrid.ViewBackColor = System.Drawing.Color.FromArgb( ( ( System.Byte )( 227 ) ), ( ( System.Byte )( 239 ) ), ( ( System.Byte )( 255 ) ) );
            this.propertyEditor.PropertyGrid.ViewForeColor = System.Drawing.Color.MidnightBlue;
            #endregion
        }

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose( bool disposing ) {
            if ( disposing )
            {
                if ( components != null )
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
            }
            base.Dispose( disposing );
        }

        #endregion

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
            this.dockingManager = new Syncfusion.Windows.Forms.Tools.DockingManager(this.components);
            this.propertyEditor = new Syncfusion.Windows.Forms.Diagram.Controls.PropertyEditor(this.components);
            this.symbolPaletteGroupBar = new Syncfusion.Windows.Forms.Diagram.Controls.PaletteGroupBar(this.components);
            this.overviewControl1 = new Syncfusion.Windows.Forms.Diagram.Controls.OverviewControl(this.components);
            this.m_documentExplorer = new Syncfusion.Windows.Forms.Diagram.Controls.DocumentExplorer();
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
            this.biRemovePalette = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            ((System.ComponentModel.ISupportInitialize)(this.dockingManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.symbolPaletteGroupBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainFrameBarManager)).BeginInit();
            this.SuspendLayout();
            // 
            // dockingManager
            // 
            this.dockingManager.ActiveCaptionFont = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
#if !NETCORE
            this.dockingManager.DockLayoutStream = ((System.IO.MemoryStream)(resources.GetObject("dockingManager.DockLayoutStream")));
#endif
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
            ccbsymbolPaletteGroupBar.MergeWith(this.dockingManager.CaptionButtons, false);
            this.dockingManager.SetCustomCaptionButtons(this.symbolPaletteGroupBar, ccbsymbolPaletteGroupBar);
            this.dockingManager.SetDockLabel(this.overviewControl1, "Pan & Zoom");
            this.dockingManager.SetEnableDocking(this.overviewControl1, true);
            ccboverviewControl1.MergeWith(this.dockingManager.CaptionButtons, false);
            this.dockingManager.SetCustomCaptionButtons(this.overviewControl1, ccboverviewControl1);
            this.dockingManager.SetDockLabel(this.m_documentExplorer, "Document Explorer");
            this.dockingManager.SetEnableDocking(this.m_documentExplorer, true);
            this.dockingManager.SetHiddenOnLoad(this.m_documentExplorer, true);
            ccbm_documentExplorer.MergeWith(this.dockingManager.CaptionButtons, false);
            this.dockingManager.SetCustomCaptionButtons(this.m_documentExplorer, ccbm_documentExplorer);
            // 
            // propertyEditor
            // 
            this.propertyEditor.Diagram = null;
            this.propertyEditor.Location = new System.Drawing.Point(3, 23);
            this.propertyEditor.Name = "propertyEditor";
            this.propertyEditor.ShowCombo = true;
            this.propertyEditor.Size = new System.Drawing.Size(197, 320);
            this.propertyEditor.TabIndex = 11;
            // 
            // symbolPaletteGroupBar
            // 
            this.symbolPaletteGroupBar.AllowDrop = true;
            this.symbolPaletteGroupBar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.symbolPaletteGroupBar.EditMode = false;
            this.symbolPaletteGroupBar.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Bold);
            this.symbolPaletteGroupBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(77)))), ((int)(((byte)(140)))));
            this.symbolPaletteGroupBar.Location = new System.Drawing.Point(3, 23);
            this.symbolPaletteGroupBar.Name = "symbolPaletteGroupBar";
            this.symbolPaletteGroupBar.PopupClientSize = new System.Drawing.Size(0, 0);
            this.symbolPaletteGroupBar.Size = new System.Drawing.Size(250, 228);
            this.symbolPaletteGroupBar.TabIndex = 9;
            this.symbolPaletteGroupBar.Text = "paletteGroupBar1";
            this.symbolPaletteGroupBar.TextAlign = Syncfusion.Windows.Forms.Tools.TextAlignment.Left;
            this.symbolPaletteGroupBar.VisualStyle = Syncfusion.Windows.Forms.VisualStyle.Office2007;
            // 
            // overviewControl1
            // 
            this.overviewControl1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.overviewControl1.Diagram = null;
            this.overviewControl1.ForeColor = System.Drawing.Color.Red;
            this.overviewControl1.Location = new System.Drawing.Point(3, 23);
            this.overviewControl1.Name = "overviewControl1";
            this.overviewControl1.Size = new System.Drawing.Size(197, 140);
            this.overviewControl1.TabIndex = 11;
            // 
            // m_documentExplorer
            // 
            this.m_documentExplorer.ImageIndex = 0;
            this.m_documentExplorer.Location = new System.Drawing.Point(3, 23);
            this.m_documentExplorer.Name = "m_documentExplorer";
            this.m_documentExplorer.SelectedImageIndex = 0;
            this.m_documentExplorer.Size = new System.Drawing.Size(250, 232);
            this.m_documentExplorer.TabIndex = 0;
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
#if !NETCORE
            this.mainFrameBarManager.BarPositionInfo = ((System.IO.MemoryStream)(resources.GetObject("mainFrameBarManager.BarPositionInfo")));
#endif
            this.mainFrameBarManager.Bars.Add(this.mainMenuBar);
            this.mainFrameBarManager.Bars.Add(this.standardToolbar);
            this.mainFrameBarManager.Categories.Add("Popups");
            this.mainFrameBarManager.Categories.Add("File");
            this.mainFrameBarManager.Categories.Add("Window");
            this.mainFrameBarManager.Categories.Add("Edit");
            this.mainFrameBarManager.Categories.Add("Help");
            this.mainFrameBarManager.Categories.Add("View");
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
            this.biFileNew,
            this.parentBarItemFile,
            this.biFileOpen,
            this.parentBarItemAlign,
            this.biFileSave,
            this.parentBarItemRotate,
            this.biFileSaveAs,
            this.parentBarItemFlip,
            this.biPageSetup,
            this.parentBarItemResize,
            this.biPrintPreview,
            this.biFilePrint,
            this.parentBarItemEdit,
            this.biAddPalette,
            this.parentBarItemPopUp,
            this.biRemovePalette,
            this.parentBarItemView,
            this.biSavePalette,
            this.parentBarItemWindow,
            this.biFileExit,
            this.parentBarItemHelp,
            this.parentBarItemActions,
            this.parentBarItemToolsGrouping,
            this.parentBarItemToolsOrder,
            this.biTabbedMDI,
            this.barItemEditCut,
            this.barItemEditCopy,
            this.barItemEditPaste,
            this.barItemEditUndo,
            this.barItemEditRedo,
            this.barItemAbout,
            this.barItemViewSymbolPalette,
            this.barItemViewProperties,
            this.barItemEditSelectAll,
            this.barItemPanZoom,
            this.barItemDocumentExplorer,
            this.barShowRulers,
            this.barItemHeaderFooter,
            this.barItemPageBorders,
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
            this.parentBarItemFile.CategoryIndex = 0;
            this.parentBarItemFile.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.parentBarItemFile.ID = "File";
            this.parentBarItemFile.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.biFileNew,
            this.biFileOpen,
            this.biFileSave,
            this.biFileSaveAs,
            this.biAddPalette,
            this.biRemovePalette,
            this.biSavePalette,
            this.biPageSetup,
            this.biPrintPreview,
            this.biFilePrint,
            this.biFileExit});
            this.parentBarItemFile.SeparatorIndices.AddRange(new int[] {
            4,
            7,
            10});
            this.parentBarItemFile.Text = "&File";
            // 
            // biFileNew
            // 
            this.biFileNew.CategoryIndex = 1;
            this.biFileNew.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.biFileNew.ID = "New";
            this.biFileNew.ImageIndex = 0;
            this.biFileNew.ImageList = this.smallImageList;
            this.biFileNew.Shortcut = System.Windows.Forms.Shortcut.CtrlN;
            this.biFileNew.Text = "&New";
            this.biFileNew.Click += new System.EventHandler(this.biFileNew_Click);
            // 
            // biFileOpen
            // 
            this.biFileOpen.CategoryIndex = 1;
            this.biFileOpen.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.biFileOpen.ID = "Open";
            this.biFileOpen.ImageIndex = 1;
            this.biFileOpen.ImageList = this.smallImageList;
            this.biFileOpen.Shortcut = System.Windows.Forms.Shortcut.CtrlO;
            this.biFileOpen.Text = "&Open";
            this.biFileOpen.Click += new System.EventHandler(this.biFileOpen_Click);
            // 
            // biFileSave
            // 
            this.biFileSave.CategoryIndex = 1;
            this.biFileSave.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.biFileSave.ID = "Save";
            this.biFileSave.ImageIndex = 2;
            this.biFileSave.ImageList = this.smallImageList;
            this.biFileSave.Shortcut = System.Windows.Forms.Shortcut.CtrlS;
            this.biFileSave.Text = "&Save";
            this.biFileSave.Click += new System.EventHandler(this.biFileSave_Click);
            // 
            // biFileSaveAs
            // 
            this.biFileSaveAs.CategoryIndex = 1;
            this.biFileSaveAs.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.biFileSaveAs.ID = "Save As...";
            this.biFileSaveAs.Text = "Save As...";
            this.biFileSaveAs.Click += new System.EventHandler(this.biFileSaveAs_Click);
            // 
            // biAddPalette
            // 
            this.biAddPalette.CategoryIndex = 1;
            this.biAddPalette.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.biAddPalette.ID = "Add SymbolPalette";
            this.biAddPalette.Text = "Add Symbol Palette";
            this.biAddPalette.Click += new System.EventHandler(this.biFileAddPalette_Click);
            // 
            // biSavePalette
            // 
            this.biSavePalette.CategoryIndex = 1;
            this.biSavePalette.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.biSavePalette.ID = "Save SymbolPalette";
            this.biSavePalette.Text = "Save Active Symbol Palette";
            this.biSavePalette.Click += new System.EventHandler(this.biSavePalette_Click);
            // 
            // biPageSetup
            // 
            this.biPageSetup.CategoryIndex = 1;
            this.biPageSetup.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.biPageSetup.ID = "Page Setup";
            this.biPageSetup.ImageIndex = 5;
            this.biPageSetup.ImageList = this.smallImageList;
            this.biPageSetup.Text = "Page Setup";
            this.biPageSetup.Click += new System.EventHandler(this.biPageSetup_Click);
            // 
            // biPrintPreview
            // 
            this.biPrintPreview.CategoryIndex = 1;
            this.biPrintPreview.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.biPrintPreview.ID = "Print Preview";
            this.biPrintPreview.ImageIndex = 3;
            this.biPrintPreview.ImageList = this.smallImageList;
            this.biPrintPreview.Text = "Print Preview";
            this.biPrintPreview.Tooltip = "Print Preview";
            this.biPrintPreview.Click += new System.EventHandler(this.biPrintPreview_Click);
            // 
            // biFilePrint
            // 
            this.biFilePrint.CategoryIndex = 1;
            this.biFilePrint.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.biFilePrint.ID = "Print";
            this.biFilePrint.ImageIndex = 6;
            this.biFilePrint.ImageList = this.smallImageList;
            this.biFilePrint.Text = "Print";
            this.biFilePrint.Click += new System.EventHandler(this.biFilePrint_Click);
            // 
            // biFileExit
            // 
            this.biFileExit.CategoryIndex = 1;
            this.biFileExit.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.biFileExit.ID = "Exit";
            this.biFileExit.Text = "Exit";
            this.biFileExit.Click += new System.EventHandler(this.biFileExit_Click);
            // 
            // parentBarItemEdit
            // 
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
            this.parentBarItemEdit.SeparatorIndices.AddRange(new int[] {
            2,
            4});
            this.parentBarItemEdit.Text = "&Edit";
            // 
            // barItemEditUndo
            // 
            this.barItemEditUndo.CategoryIndex = 3;
            this.barItemEditUndo.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.barItemEditUndo.ID = "Undo";
            this.barItemEditUndo.ImageIndex = 10;
            this.barItemEditUndo.ImageList = this.smallImageList;
            this.barItemEditUndo.Shortcut = System.Windows.Forms.Shortcut.CtrlZ;
            this.barItemEditUndo.Text = "&Undo";
            this.barItemEditUndo.Click += new System.EventHandler(this.barItemEditUndo_Click);
            // 
            // barItemEditRedo
            // 
            this.barItemEditRedo.CategoryIndex = 3;
            this.barItemEditRedo.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.barItemEditRedo.ID = "EditRedo";
            this.barItemEditRedo.ImageIndex = 11;
            this.barItemEditRedo.ImageList = this.smallImageList;
            this.barItemEditRedo.Shortcut = System.Windows.Forms.Shortcut.CtrlY;
            this.barItemEditRedo.Text = "&Redo";
            this.barItemEditRedo.Click += new System.EventHandler(this.barItemEditRedo_Click);
            // 
            // barItemEditSelectAll
            // 
            this.barItemEditSelectAll.CategoryIndex = 3;
            this.barItemEditSelectAll.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.barItemEditSelectAll.ID = "&Select All";
            this.barItemEditSelectAll.Shortcut = System.Windows.Forms.Shortcut.CtrlA;
            this.barItemEditSelectAll.Text = "Select &All";
            this.barItemEditSelectAll.Click += new System.EventHandler(this.barItemEditSelectAll_Click);
            // 
            // barItemEditDelete
            // 
            this.barItemEditDelete.CategoryIndex = 3;
            this.barItemEditDelete.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.barItemEditDelete.ID = "Delete";
            this.barItemEditDelete.ImageIndex = 12;
            this.barItemEditDelete.ImageList = this.smallImageList;
            this.barItemEditDelete.Text = "&Delete";
            this.barItemEditDelete.Click += new System.EventHandler(this.barItemEditDelete_Click);
            // 
            // barItemEditCut
            // 
            this.barItemEditCut.CategoryIndex = 3;
            this.barItemEditCut.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.barItemEditCut.ID = "Cut";
            this.barItemEditCut.ImageIndex = 8;
            this.barItemEditCut.ImageList = this.smallImageList;
            this.barItemEditCut.Shortcut = System.Windows.Forms.Shortcut.CtrlX;
            this.barItemEditCut.Text = "C&ut";
            this.barItemEditCut.Click += new System.EventHandler(this.barItemEditCut_Click);
            // 
            // barItemEditCopy
            // 
            this.barItemEditCopy.CategoryIndex = 3;
            this.barItemEditCopy.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.barItemEditCopy.ID = "Copy";
            this.barItemEditCopy.ImageIndex = 7;
            this.barItemEditCopy.ImageList = this.smallImageList;
            this.barItemEditCopy.Shortcut = System.Windows.Forms.Shortcut.CtrlC;
            this.barItemEditCopy.Text = "&Copy";
            this.barItemEditCopy.Click += new System.EventHandler(this.barItemEditCopy_Click);
            // 
            // barItemEditPaste
            // 
            this.barItemEditPaste.CategoryIndex = 3;
            this.barItemEditPaste.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.barItemEditPaste.ID = "Paste";
            this.barItemEditPaste.ImageIndex = 9;
            this.barItemEditPaste.ImageList = this.smallImageList;
            this.barItemEditPaste.Shortcut = System.Windows.Forms.Shortcut.CtrlV;
            this.barItemEditPaste.Text = "&Paste";
            this.barItemEditPaste.Click += new System.EventHandler(this.barItemEditPaste_Click);
            // 
            // parentBarItemFormat
            // 
            this.parentBarItemFormat.CategoryIndex = 0;
            this.parentBarItemFormat.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.parentBarItemFormat.ID = "Format";
            this.parentBarItemFormat.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.barItemFillStyle,
            this.barItemShadowStyle});
            this.parentBarItemFormat.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007;
            this.parentBarItemFormat.Text = "&Format";
            // 
            // barItemFillStyle
            // 
            this.barItemFillStyle.CategoryIndex = 14;
            this.barItemFillStyle.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.barItemFillStyle.ID = "Fill";
            this.barItemFillStyle.Text = "&Fill...";
            this.barItemFillStyle.Click += new System.EventHandler(this.fillBarItem_Click);
            // 
            // barItemShadowStyle
            // 
            this.barItemShadowStyle.CategoryIndex = 14;
            this.barItemShadowStyle.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.barItemShadowStyle.ID = "Shadow";
            this.barItemShadowStyle.Text = "&Shadow...";
            this.barItemShadowStyle.Click += new System.EventHandler(this.shadowBarItem_Click);
            // 
            // parentBarItemView
            // 
            this.parentBarItemView.CategoryIndex = 0;
            this.parentBarItemView.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.parentBarItemView.ID = "View";
            this.parentBarItemView.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.barShowRulers,
            this.barItemViewSymbolPalette,
            this.barItemViewProperties,
            this.barItemPanZoom,
            this.barItemDocumentExplorer,
            this.barItemHeaderFooter,
            this.barItemPageBorders});
            this.parentBarItemView.SeparatorIndices.AddRange(new int[] {
            3});
            this.parentBarItemView.Text = "&View";
            // 
            // barShowRulers
            // 
            this.barShowRulers.CategoryIndex = 5;
            this.barShowRulers.Checked = true;
            this.barShowRulers.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.barShowRulers.ID = "Rulers";
            this.barShowRulers.Text = "Rulers";
            this.barShowRulers.Click += new System.EventHandler(this.barShowRulers_Click);
            // 
            // barItemViewSymbolPalette
            // 
            this.barItemViewSymbolPalette.CategoryIndex = 5;
            this.barItemViewSymbolPalette.Checked = true;
            this.barItemViewSymbolPalette.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.barItemViewSymbolPalette.ID = "Symbol SymbolPalette";
            this.barItemViewSymbolPalette.Text = "Symbol Palette";
            this.barItemViewSymbolPalette.Click += new System.EventHandler(this.barItemViewSymbolPalette_Click);
            // 
            // barItemViewProperties
            // 
            this.barItemViewProperties.CategoryIndex = 5;
            this.barItemViewProperties.Checked = true;
            this.barItemViewProperties.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.barItemViewProperties.ID = "Properties";
            this.barItemViewProperties.Text = "Properties";
            this.barItemViewProperties.Click += new System.EventHandler(this.barItemViewProperties_Click);
            // 
            // barItemPanZoom
            // 
            this.barItemPanZoom.CategoryIndex = 5;
            this.barItemPanZoom.Checked = true;
            this.barItemPanZoom.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.barItemPanZoom.ID = "panZoomWindow";
            this.barItemPanZoom.Text = "Pan & Zoom Window";
            this.barItemPanZoom.Tooltip = "Pan & Zoom Window";
            this.barItemPanZoom.Click += new System.EventHandler(this.barItemPanZoom_Click);
            // 
            // barItemDocumentExplorer
            // 
            this.barItemDocumentExplorer.CategoryIndex = 5;
            this.barItemDocumentExplorer.Checked = true;
            this.barItemDocumentExplorer.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.barItemDocumentExplorer.ID = "DocumentExplorer";
            this.barItemDocumentExplorer.Text = "Document Explorer";
            this.barItemDocumentExplorer.Tooltip = "Document Explorer";
            this.barItemDocumentExplorer.Click += new System.EventHandler(this.barItemDocumentExplorer_Click);
            // 
            // barItemHeaderFooter
            // 
            this.barItemHeaderFooter.CategoryIndex = 5;
            this.barItemHeaderFooter.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.barItemHeaderFooter.ID = "Header Footer";
            this.barItemHeaderFooter.Text = "Header Footer...";
            this.barItemHeaderFooter.Click += new System.EventHandler(this.barItemHeaderFooter_Click);
            // 
            // barItemPageBorders
            // 
            this.barItemPageBorders.CategoryIndex = 5;
            this.barItemPageBorders.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.barItemPageBorders.ID = "Page Borders";
            this.barItemPageBorders.Text = "Page Borders...";
            this.barItemPageBorders.Click += new System.EventHandler(this.barItemPageBorders_Click);
            // 
            // parentBarItemActions
            // 
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
            this.parentBarItemActions.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007;
            this.parentBarItemActions.Text = "&Actions";
            // 
            // parentBarItemAlign
            // 
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
            this.parentBarItemAlign.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007;
            this.parentBarItemAlign.Text = "&Align";
            // 
            // barItemAlignLeft
            // 
            this.barItemAlignLeft.CategoryIndex = 8;
            this.barItemAlignLeft.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.barItemAlignLeft.ID = "AlignLeft";
            this.barItemAlignLeft.ImageIndex = 15;
            this.barItemAlignLeft.ImageList = this.smallImageList;
            this.barItemAlignLeft.Text = "Align Left";
            this.barItemAlignLeft.Click += new System.EventHandler(this.barItemAlign_Click);
            // 
            // barItemAlignCenter
            // 
            this.barItemAlignCenter.CategoryIndex = 8;
            this.barItemAlignCenter.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.barItemAlignCenter.ID = "AlignCenter";
            this.barItemAlignCenter.ImageIndex = 14;
            this.barItemAlignCenter.ImageList = this.smallImageList;
            this.barItemAlignCenter.Text = "Align Center";
            this.barItemAlignCenter.Click += new System.EventHandler(this.barItemAlign_Click);
            // 
            // barItemAlignRight
            // 
            this.barItemAlignRight.CategoryIndex = 8;
            this.barItemAlignRight.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.barItemAlignRight.ID = "AlignRight";
            this.barItemAlignRight.ImageIndex = 17;
            this.barItemAlignRight.ImageList = this.smallImageList;
            this.barItemAlignRight.Text = "Align Right";
            this.barItemAlignRight.Click += new System.EventHandler(this.barItemAlign_Click);
            // 
            // barItemAlignTop
            // 
            this.barItemAlignTop.CategoryIndex = 8;
            this.barItemAlignTop.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.barItemAlignTop.ID = "AlignTop";
            this.barItemAlignTop.ImageIndex = 18;
            this.barItemAlignTop.ImageList = this.smallImageList;
            this.barItemAlignTop.Text = "Align Top";
            this.barItemAlignTop.Click += new System.EventHandler(this.barItemAlign_Click);
            // 
            // barItemAlignMiddle
            // 
            this.barItemAlignMiddle.CategoryIndex = 8;
            this.barItemAlignMiddle.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.barItemAlignMiddle.ID = "AlignMiddle";
            this.barItemAlignMiddle.ImageIndex = 16;
            this.barItemAlignMiddle.ImageList = this.smallImageList;
            this.barItemAlignMiddle.Text = "Align Middle";
            this.barItemAlignMiddle.Click += new System.EventHandler(this.barItemAlign_Click);
            // 
            // barItemAlignBottom
            // 
            this.barItemAlignBottom.CategoryIndex = 8;
            this.barItemAlignBottom.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.barItemAlignBottom.ID = "AlignBottom";
            this.barItemAlignBottom.ImageIndex = 13;
            this.barItemAlignBottom.ImageList = this.smallImageList;
            this.barItemAlignBottom.Text = "Align Bottom";
            this.barItemAlignBottom.Click += new System.EventHandler(this.barItemAlign_Click);
            // 
            // parentBarItemFlip
            // 
            this.parentBarItemFlip.CategoryIndex = 0;
            this.parentBarItemFlip.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.parentBarItemFlip.ID = "Flip";
            this.parentBarItemFlip.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.barItemFlipHorizontally,
            this.barItemFlipVertically,
            this.barItemFlipBoth});
            this.parentBarItemFlip.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007;
            this.parentBarItemFlip.Text = "&Flip";
            // 
            // barItemFlipHorizontally
            // 
            this.barItemFlipHorizontally.CategoryIndex = 9;
            this.barItemFlipHorizontally.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.barItemFlipHorizontally.ID = "FlipHorizontally";
            this.barItemFlipHorizontally.ImageIndex = 20;
            this.barItemFlipHorizontally.ImageList = this.smallImageList;
            this.barItemFlipHorizontally.Text = "Flip Horizontally";
            this.barItemFlipHorizontally.Click += new System.EventHandler(this.barItemFlip_Click);
            // 
            // barItemFlipVertically
            // 
            this.barItemFlipVertically.CategoryIndex = 9;
            this.barItemFlipVertically.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.barItemFlipVertically.ID = "FlipVertically";
            this.barItemFlipVertically.ImageIndex = 19;
            this.barItemFlipVertically.ImageList = this.smallImageList;
            this.barItemFlipVertically.Text = "Flip Vertically";
            this.barItemFlipVertically.Click += new System.EventHandler(this.barItemFlip_Click);
            // 
            // barItemFlipBoth
            // 
            this.barItemFlipBoth.CategoryIndex = 9;
            this.barItemFlipBoth.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.barItemFlipBoth.ID = "FlipBoth";
            this.barItemFlipBoth.Text = "Flip Both";
            this.barItemFlipBoth.Click += new System.EventHandler(this.barItemFlip_Click);
            // 
            // parentBarItemToolsGrouping
            // 
            this.parentBarItemToolsGrouping.CategoryIndex = 0;
            this.parentBarItemToolsGrouping.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.parentBarItemToolsGrouping.ID = "Grouping";
            this.parentBarItemToolsGrouping.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.barItemGroupingGroup,
            this.barItemGroupingUnGroup});
            this.parentBarItemToolsGrouping.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007;
            this.parentBarItemToolsGrouping.Text = "&Grouping";
            // 
            // barItemGroupingGroup
            // 
            this.barItemGroupingGroup.CategoryIndex = 10;
            this.barItemGroupingGroup.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.barItemGroupingGroup.ID = "Group";
            this.barItemGroupingGroup.ImageIndex = 21;
            this.barItemGroupingGroup.ImageList = this.smallImageList;
            this.barItemGroupingGroup.Text = "Group";
            this.barItemGroupingGroup.Click += new System.EventHandler(this.barItemGroupingGroup_Click);
            // 
            // barItemGroupingUnGroup
            // 
            this.barItemGroupingUnGroup.CategoryIndex = 10;
            this.barItemGroupingUnGroup.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.barItemGroupingUnGroup.ID = "UnGroup";
            this.barItemGroupingUnGroup.ImageIndex = 22;
            this.barItemGroupingUnGroup.ImageList = this.smallImageList;
            this.barItemGroupingUnGroup.Text = "UnGroup";
            this.barItemGroupingUnGroup.Click += new System.EventHandler(this.barItemGroupingGroup_Click);
            // 
            // parentBarItemToolsOrder
            // 
            this.parentBarItemToolsOrder.CategoryIndex = 0;
            this.parentBarItemToolsOrder.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.parentBarItemToolsOrder.ID = "Order";
            this.parentBarItemToolsOrder.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.barItemOrderFront,
            this.barItemOrderForward,
            this.barItemOrderBackward,
            this.barItemOrderBack});
            this.parentBarItemToolsOrder.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007;
            this.parentBarItemToolsOrder.Text = "&Order";
            // 
            // barItemOrderFront
            // 
            this.barItemOrderFront.CategoryIndex = 11;
            this.barItemOrderFront.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.barItemOrderFront.ID = "Bring to Front";
            this.barItemOrderFront.ImageIndex = 26;
            this.barItemOrderFront.ImageList = this.smallImageList;
            this.barItemOrderFront.Text = "Bring to Front";
            this.barItemOrderFront.Click += new System.EventHandler(this.barItemOrder_Click);
            // 
            // barItemOrderForward
            // 
            this.barItemOrderForward.CategoryIndex = 11;
            this.barItemOrderForward.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.barItemOrderForward.ID = "Bring Forward";
            this.barItemOrderForward.ImageIndex = 25;
            this.barItemOrderForward.ImageList = this.smallImageList;
            this.barItemOrderForward.Text = "Bring Forward";
            this.barItemOrderForward.Click += new System.EventHandler(this.barItemOrder_Click);
            // 
            // barItemOrderBackward
            // 
            this.barItemOrderBackward.CategoryIndex = 11;
            this.barItemOrderBackward.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.barItemOrderBackward.ID = "Send Backward";
            this.barItemOrderBackward.ImageIndex = 27;
            this.barItemOrderBackward.ImageList = this.smallImageList;
            this.barItemOrderBackward.Text = "Send Backward";
            this.barItemOrderBackward.Click += new System.EventHandler(this.barItemOrder_Click);
            // 
            // barItemOrderBack
            // 
            this.barItemOrderBack.CategoryIndex = 11;
            this.barItemOrderBack.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.barItemOrderBack.ID = "Send to Back";
            this.barItemOrderBack.ImageIndex = 28;
            this.barItemOrderBack.ImageList = this.smallImageList;
            this.barItemOrderBack.Text = "Send to Back";
            this.barItemOrderBack.Click += new System.EventHandler(this.barItemOrder_Click);
            // 
            // parentBarItemRotate
            // 
            this.parentBarItemRotate.CategoryIndex = 0;
            this.parentBarItemRotate.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.parentBarItemRotate.ID = "Rotate";
            this.parentBarItemRotate.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.barItemRotateClock,
            this.barItemRotateConter});
            this.parentBarItemRotate.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007;
            this.parentBarItemRotate.Text = "&Rotate";
            // 
            // barItemRotateClock
            // 
            this.barItemRotateClock.CategoryIndex = 12;
            this.barItemRotateClock.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.barItemRotateClock.ID = "RotateClock";
            this.barItemRotateClock.ImageIndex = 24;
            this.barItemRotateClock.ImageList = this.smallImageList;
            this.barItemRotateClock.Text = "Rotate 90 clockwise";
            this.barItemRotateClock.Click += new System.EventHandler(this.barItemRotate_Click);
            // 
            // barItemRotateConter
            // 
            this.barItemRotateConter.CategoryIndex = 12;
            this.barItemRotateConter.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.barItemRotateConter.ID = "RotateConter";
            this.barItemRotateConter.ImageIndex = 23;
            this.barItemRotateConter.ImageList = this.smallImageList;
            this.barItemRotateConter.Text = "Rotate 90 conter-clockwise";
            this.barItemRotateConter.Click += new System.EventHandler(this.barItemRotate_Click);
            // 
            // parentBarItemResize
            // 
            this.parentBarItemResize.CategoryIndex = 0;
            this.parentBarItemResize.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.parentBarItemResize.ID = "Resize";
            this.parentBarItemResize.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.barItemResizeWidth,
            this.barItemResizeHeight,
            this.barItemResizeSize,
            this.barItemResizeAcross,
            this.barItemResizeDown});
            this.parentBarItemResize.SeparatorIndices.AddRange(new int[] {
            3});
            this.parentBarItemResize.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007;
            this.parentBarItemResize.Text = "R&esize";
            // 
            // barItemResizeWidth
            // 
            this.barItemResizeWidth.CategoryIndex = 13;
            this.barItemResizeWidth.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.barItemResizeWidth.ID = "SameWidth";
            this.barItemResizeWidth.ImageIndex = 31;
            this.barItemResizeWidth.ImageList = this.smallImageList;
            this.barItemResizeWidth.Text = "Same Width";
            this.barItemResizeWidth.Click += new System.EventHandler(this.barItemResize_Click);
            // 
            // barItemResizeHeight
            // 
            this.barItemResizeHeight.CategoryIndex = 13;
            this.barItemResizeHeight.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.barItemResizeHeight.ID = "SameHeight";
            this.barItemResizeHeight.ImageIndex = 29;
            this.barItemResizeHeight.ImageList = this.smallImageList;
            this.barItemResizeHeight.Text = "Same Height";
            this.barItemResizeHeight.Click += new System.EventHandler(this.barItemResize_Click);
            // 
            // barItemResizeSize
            // 
            this.barItemResizeSize.CategoryIndex = 13;
            this.barItemResizeSize.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.barItemResizeSize.ID = "SameSize";
            this.barItemResizeSize.ImageIndex = 30;
            this.barItemResizeSize.ImageList = this.smallImageList;
            this.barItemResizeSize.Text = "Same Size";
            this.barItemResizeSize.Click += new System.EventHandler(this.barItemResize_Click);
            // 
            // barItemResizeAcross
            // 
            this.barItemResizeAcross.CategoryIndex = 13;
            this.barItemResizeAcross.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.barItemResizeAcross.ID = "SpaceAcross";
            this.barItemResizeAcross.ImageIndex = 32;
            this.barItemResizeAcross.ImageList = this.smallImageList;
            this.barItemResizeAcross.Text = "Space Across";
            this.barItemResizeAcross.Click += new System.EventHandler(this.barItemResize_Click);
            // 
            // barItemResizeDown
            // 
            this.barItemResizeDown.CategoryIndex = 13;
            this.barItemResizeDown.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.barItemResizeDown.ID = "SpaceDown";
            this.barItemResizeDown.ImageIndex = 33;
            this.barItemResizeDown.ImageList = this.smallImageList;
            this.barItemResizeDown.Text = "Space Down";
            this.barItemResizeDown.Click += new System.EventHandler(this.barItemResize_Click);
            // 
            // barItemLayout
            // 
            this.barItemLayout.CategoryIndex = 0;
            this.barItemLayout.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.barItemLayout.ID = "Layout nodes";
            this.barItemLayout.Text = "Layout nodes";
            this.barItemLayout.Click += new System.EventHandler(this.barItemLayout_Click);
            // 
            // parentBarItemWindow
            // 
            this.parentBarItemWindow.CategoryIndex = 0;
            this.parentBarItemWindow.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.parentBarItemWindow.ID = "Window";
            this.parentBarItemWindow.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.biTabbedMDI});
            this.parentBarItemWindow.Text = "&Window";
            // 
            // biTabbedMDI
            // 
            this.biTabbedMDI.CategoryIndex = 2;
            this.biTabbedMDI.Checked = true;
            this.biTabbedMDI.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.biTabbedMDI.ID = "Tabbed MDI";
            this.biTabbedMDI.Text = "Tabbed MDI";
            this.biTabbedMDI.Click += new System.EventHandler(this.biTabbedMDI_Click);
            // 
            // parentBarItemHelp
            // 
            this.parentBarItemHelp.CategoryIndex = 0;
            this.parentBarItemHelp.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.parentBarItemHelp.ID = "Help";
            this.parentBarItemHelp.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.barItemAbout});
            this.parentBarItemHelp.Text = "&Help";
            // 
            // barItemAbout
            // 
            this.barItemAbout.CategoryIndex = 4;
            this.barItemAbout.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.barItemAbout.ID = "About";
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
            this.parentBarItemPopUp.SeparatorIndices.AddRange(new int[] {
            3,
            4});
            this.parentBarItemPopUp.ShowTooltip = false;
            this.parentBarItemPopUp.Text = "PopUpMenu";
            this.parentBarItemPopUp.UsePartialMenus = false;
            this.parentBarItemPopUp.Visible = false;
            // 
            // parentBarItemNode
            // 
            this.parentBarItemNode.CategoryIndex = 0;
            this.parentBarItemNode.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.parentBarItemNode.ID = "NodeMenu";
            this.parentBarItemNode.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.barItemEditCut,
            this.barItemEditCopy,
            this.barItemEditPaste,
            this.parentBarItemActions});
            this.parentBarItemNode.SeparatorIndices.AddRange(new int[] {
            3});
            this.parentBarItemNode.Text = "NodeMenu";
            this.parentBarItemNode.Visible = false;
            // 
            // biRemovePalette
            // 
            this.biRemovePalette.CategoryIndex = 1;
            this.biRemovePalette.ID = "biRemovePalette";
            this.biRemovePalette.Text = "Remove Active Symbol Palette";
            this.biRemovePalette.Click += new System.EventHandler(this.biRemovePalette_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 566);
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
            ((System.ComponentModel.ISupportInitialize)(this.mainFrameBarManager)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion

        internal string FindFile( string fileName ) {
            // Check both in parent folder and Parent\Data folders.
            string dataFileName = @"Data\" + fileName;
            for ( int n = 0 ; n < 12 ; n++ )
            {
                if ( System.IO.File.Exists( fileName ) )
                {
                    return fileName;
                }
                if ( System.IO.File.Exists( dataFileName ) )
                {
                    return dataFileName;
                }
                fileName = @"..\" + fileName;
                dataFileName = @"..\" + dataFileName;
            }

            return fileName;
        }

        #region MainForm Event Handlers
        private void MainForm_Load( object sender, EventArgs e ) {
            this.barItemViewProperties.Checked = true;
            this.barItemViewSymbolPalette.Checked = true;


            //Load Palettes
            string[] symbolPalettes = new string[] { 
                "FloorPlan Shapes.edp",
                "Basic Shapes.edp",
                "ElectricalSymbols.edp",
                "Flowchart Symbols.edp",
                "NetworkSymbols.edp"
                
            };
            foreach ( string symbolpalette in symbolPalettes )
            {
                string filepath = FindFile( symbolpalette );
                if ( File.Exists( filepath ) )
                {
                    this.symbolPaletteGroupBar.LoadPalette( filepath );
                }
            }
           

            // New diagram
            DiagramForm docForm = new DiagramForm( this );
            docForm.Closing += new CancelEventHandler( DiagramForm_Closing );

            // Subscribe for DocumentExplorer selection change
            m_documentExplorer.AfterSelect += new TreeViewEventHandler( m_documentExplorer_AfterSelect );

            // Load Diagram file.
            if ( _initialFileLoc == "" )
            {
                docForm.Diagram.LoadBinary(FindFile("FloorPlan.edd"));
                docForm.FileName = "Floor Plan";
            }
            else
            {
                docForm.Diagram.LoadBinary( _initialFileLoc );
                string fileName = _initialFileLoc.Substring( 0, _initialFileLoc.IndexOf( "." ) );
                docForm.FileName = fileName;
            }
            // Attach created diagram to DocumentExplorer
            if ( docForm.Diagram.Model != null )
                m_documentExplorer.AttachModel( docForm.Diagram.Model );

            docForm.Show( );

            foreach ( GroupBarItem item in symbolPaletteGroupBar.GroupBarItems )
            {
                if ( item.Client is PaletteGroupView )
                {
                    PaletteGroupView view = item.Client as PaletteGroupView;
                    view.FlowView = true;
                    view.ShowToolTips = true;
                    view.ShowFlowViewItemText = true;
                    view.SelectedItemColor = Color.FromArgb( 255, 219, 118 );
                    view.HighlightItemColor = Color.FromArgb( 255, 227, 149 );
                    view.SelectingItemColor = Color.FromArgb( 255, 238, 184 );
                    view.SelectedHighlightItemColor = Color.FromArgb( 255, 218, 115 );
                    view.FlowViewItemTextLength = (int)DpiAware.LogicalToDeviceUnits(60);
                    //view.BackgroundImage = Image.FromFile(@"..\..\..\..\..\..\..\..\..\Common\images\Diagram\background_2.jpg");
                    view.FlatLook = true;
                }
            }

            // Load the save bar state
            if ( File.Exists( @"..\..\persist.xml" ) )
            {
                AppStateSerializer serializer = new AppStateSerializer( SerializeMode.XMLFile, @"..\..\persist" );
                this.mainFrameBarManager.LoadBarState( serializer );
            }
           
        }
        private void MainForm_MdiChildActivate( object sender, EventArgs e ) {
            DiagramForm diagramForm = this.ActiveMdiChild as DiagramForm;
            if ( diagramForm != null )
            {
                if ( this.dockingManager.GetDockVisibility( propertyEditor ) )
                {
                    this.propertyEditor.Diagram = diagramForm.Diagram;
                }

                // Subscribe for DocumentSink events
                if ( diagramForm.Diagram.Model != null )
                {
                    Model document = diagramForm.Diagram.Model;
                }

                // If the OverviewControl is visible then change the OverviewControl.Model and OverviewControl.View 
                // properties to reference the new diagram's Model and View
                if ( this.dockingManager.GetDockVisibility( overviewControl1 ) )
                {
                    this.overviewControl1.Diagram = diagramForm.Diagram;
                }

                //attach active diagram to palette groupbar
                this.symbolPaletteGroupBar.Diagram = diagramForm.Diagram;
            }
        }
        #endregion

        #region Properties

        private Controls.Diagram ActiveDiagram {
            get {
                Controls.Diagram diagram = null;

                if ( this.ActiveMdiChild != null )
                {
                    DiagramForm diagramForm = this.ActiveMdiChild as DiagramForm;
                    if ( diagramForm != null )
                    {
                        diagram = diagramForm.Diagram;
                    }
                }

                return diagram;
            }
        }

        private DiagramForm ActiveDiagramForm {
            get {
                DiagramForm diagramForm = null;

                if ( this.ActiveMdiChild != null )
                {
                    diagramForm = this.ActiveMdiChild as DiagramForm;
                }

                return diagramForm;
            }
        }

        public PropertyEditor PropertyEditor {
            get {
                return this.propertyEditor;
            }
        }

        #endregion

        #region File Menu Event Handlers
        private void biSavePalette_Click( object sender, EventArgs e ) {
            // Open symbol palette and add it to the symbol palette group bar
            if ( savePaletteDialog.ShowDialog( this ) == DialogResult.OK )
            {
                SymbolPalette symbolPalette = symbolPaletteGroupBar.CurrentSymbolPalette;
                string strSavePath = savePaletteDialog.FileName;

                if ( symbolPalette != null )
                {
                    FileStream fStream = new FileStream( strSavePath, FileMode.OpenOrCreate, FileAccess.Write );
                    BinaryFormatter formatter = new BinaryFormatter( );

                    formatter.Serialize( fStream, symbolPalette );
                    fStream.Close( );
                }
            }
        }
        private void biFileAddPalette_Click( object sender, EventArgs e ) {
            // Open symbol palette and add it to the symbol palette group bar
            if ( openPaletteDialog.ShowDialog( this ) == DialogResult.OK )
            {
                SymbolPalette curSymbolPalette = new SymbolPalette();                

                string strFileName = openPaletteDialog.FileName;

                RegexOptions options = RegexOptions.IgnoreCase | RegexOptions.RightToLeft;
                Match match = Regex.Match( strFileName, ".vss|.vsx|.vsd|.vdx", options );

                if ( match.Success )
                {
                    VisioStencilConverter converter = new VisioStencilConverter( strFileName, this );
                    converter.ShowProgressDialog = true;
                    curSymbolPalette = converter.Convert( );
                    if ( curSymbolPalette != null )
                        symbolPaletteGroupBar.AddPalette( curSymbolPalette );
                }
                else
                {
                    curSymbolPalette = curSymbolPalette.FromFile(strFileName);
                    symbolPaletteGroupBar.AddPalette(curSymbolPalette);
                }
            }
        }

        private void biRemovePalette_Click(object sender, EventArgs e)
        {
            if (symbolPaletteGroupBar.GroupBarItems.Count != 0)
            {
                int selectedIndex = symbolPaletteGroupBar.SelectedItem;
                symbolPaletteGroupBar.GroupBarItems.RemoveAt(selectedIndex);
            }
        }

        private void biFileNew_Click( object sender, EventArgs e ) 
        {
            // New diagram
            DiagramForm docForm = new DiagramForm( this );
            docForm.Closing += new CancelEventHandler( DiagramForm_Closing );
            // Attach just created diagram
            m_documentExplorer.AttachModel( docForm.Diagram.Model );
            docForm.Diagram.View.Grid.GridStyle = GridStyle.Line;
            docForm.Diagram.View.Grid.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            docForm.Diagram.View.Grid.Color = Color.LightGray;
            docForm.Diagram.View.Grid.VerticalSpacing = 15;
            docForm.Diagram.View.Grid.HorizontalSpacing = 15;
            docForm.Diagram.Model.BackgroundStyle.GradientCenter = 0.5f;
            docForm.Diagram.View.HandleColor = Color.AliceBlue;
            docForm.Diagram.View.HandleOutlineColor = Color.SkyBlue;
            docForm.Diagram.Model.RenderingStyle.SmoothingMode = SmoothingMode.HighQuality;
            docForm.Diagram.View.SelectionList.Clear();
            docForm.Show( );
        }

        private void biFileOpen_Click( object sender, EventArgs e ) {
            // Open diagram
            if ( this.openDiagramDialog.ShowDialog( this ) == DialogResult.OK )
            {
                DiagramForm docForm = new DiagramForm( this );
                docForm.OpenFile( this.openDiagramDialog.FileName );

                if ( docForm.Diagram.Model != null )
                {
                    m_documentExplorer.AttachModel( docForm.Diagram.Model );
                }

                docForm.Closing += new CancelEventHandler( DiagramForm_Closing );
                docForm.Show( );
            }
        }

        private void biFileSave_Click( object sender, EventArgs e ) {
            // Save diagram
            DiagramForm docForm = this.ActiveDiagramForm;
            if ( docForm != null )
            {
                if ( !docForm.HasFileName )
                {
                    if ( this.saveDiagramDialog.ShowDialog( this ) == DialogResult.OK )
                    {
                        docForm.SaveAsFile( this.saveDiagramDialog.FileName );
                    }
                }
                else
                {
                    docForm.SaveFile( );
                }
            }
        }

        private void biFileSaveAs_Click( object sender, EventArgs e ) {
            // Save diagram
            DiagramForm docForm = this.ActiveDiagramForm;
            if ( docForm != null )
            {
                if ( docForm.HasFileName )
                {
                    this.saveDiagramDialog.FileName = docForm.FileName;
                }
                if ( this.saveDiagramDialog.ShowDialog( this ) == DialogResult.OK )
                {
                    string strFileName = this.saveDiagramDialog.FileName;
                    // search for file extension
                    RegexOptions options = RegexOptions.IgnoreCase;
                    Match match = Regex.Match( strFileName, "([^.]*)$", options );
                    if ( match.Success )
                    {
                        Image imgDiagram;

                        switch ( match.Value.ToLower( ) )
                        {
                            case "svg":
                                ToSvg tosvg = new ToSvg( );
                                // Get Diagram Nodes Bounding Rectangle.
                                RectangleF rectBounding = this.ActiveDiagramForm.Diagram.Model.GetBoundingRect( );
                                Graphics gfx = tosvg.GetRealGraphics( new Size( ( int )rectBounding.Width, ( int )rectBounding.Height ) );
                                this.ActiveDiagram.ExportDiagramToGraphics( gfx );
                                tosvg.Save( strFileName );

                                break;
                            case "emf":
                                //Save Diagram to created image.
								using (Bitmap bmp = new Bitmap( 1, 1 ))
								using (Graphics gfxBmp = Graphics.FromImage( bmp ))
								{
									IntPtr hdc = gfxBmp.GetHdc();

									using (Metafile metafile = new Metafile( strFileName, hdc ))
									using (Graphics gfxMetafile = Graphics.FromImage( metafile ))
									{
										this.ActiveDiagram.ExportDiagramToGraphics( gfxMetafile );
									}

									gfxBmp.ReleaseHdc( hdc );
								}
                                break;
                            case "png":
                                //Save Diagram to created image.
                                imgDiagram = this.ActiveDiagram.ExportDiagramAsImage( false );

                                // Save image as metafile.
                                imgDiagram.Save( strFileName, ImageFormat.Png );
                                break;
                            case "jpg":
                            case "jpeg":
                                //Save Diagram to created image.
                                imgDiagram = this.ActiveDiagram.ExportDiagramAsImage( false );

                                // Save image as metafile.
                                imgDiagram.Save( strFileName, ImageFormat.Jpeg );
                                break;
                            case "tiff":
                                //Save Diagram to created image.
                                imgDiagram = this.ActiveDiagram.ExportDiagramAsImage( false );

                                // Save image as metafile.
                                imgDiagram.Save( strFileName, ImageFormat.Tiff );
                                break;
                            case "gif":
                                //Save Diagram to created image.
                                imgDiagram = this.ActiveDiagram.ExportDiagramAsImage( false );

                                // Save image as metafile.
                                imgDiagram.Save( strFileName, ImageFormat.Gif );
                                break;
                            case "bmp":
                                //Save Diagram to created image.
                                imgDiagram = this.ActiveDiagram.ExportDiagramAsImage( false );

                                // Save image as metafile.
                                imgDiagram.Save( strFileName, ImageFormat.Bmp );
                                break;

                            default:
                                docForm.SaveAsFile( this.saveDiagramDialog.FileName );
                                break;
                        }
                    }
                }
            }
        }

        private void biPrintPreview_Click( object sender, EventArgs e ) {
            this.PrintPreview( );
        }

        private void biFilePrint_Click( object sender, EventArgs e ) {
            this.Print( );
        }
        private void biPageSetup_Click( object sender, EventArgs e ) {
            this.PageSetup( );
        }
        private void biFileExit_Click( object sender, EventArgs e ) {
            Application.Exit( );
        }
        private void barItemHeaderFooter_Click( object sender, EventArgs e ) {
            HeaderFooterSetup( );
        }
        private void barItemPageBorders_Click( object sender, EventArgs e ) {
            PageBordersSetup( );
        }
        #endregion

        #region Edit Menu Event Handlers

        private void barItemEditCut_Click( object sender, EventArgs e ) {
            if ( this.ActiveMdiChild != null )
            {
                DiagramForm diagramForm = this.ActiveMdiChild as DiagramForm;
                if ( diagramForm != null )
                {
                    diagramForm.Diagram.Controller.Cut( );
                }
            }
        }
        private void barItemEditCopy_Click( object sender, EventArgs e ) {
            if ( this.ActiveMdiChild != null )
            {
                DiagramForm diagramForm = this.ActiveMdiChild as DiagramForm;
                if ( diagramForm != null )
                {
                    diagramForm.Diagram.Controller.Copy( );
                }
            }
        }
        private void barItemEditPaste_Click( object sender, EventArgs e ) {
            if ( this.ActiveMdiChild != null )
            {
                DiagramForm diagramForm = this.ActiveMdiChild as DiagramForm;
                if ( diagramForm != null )
                {
                    diagramForm.Diagram.Controller.Paste( );
                }
            }
        }
        private void barItemEditUndo_Click( object sender, EventArgs e ) {
            if ( this.ActiveMdiChild != null )
            {
                DiagramForm diagramForm = this.ActiveMdiChild as DiagramForm;
                if ( diagramForm != null )
                {
                    diagramForm.Diagram.Model.HistoryManager.Undo( );
                    propertyEditor.PropertyGrid.Refresh( );
                }
            }
        }
        private void barItemEditRedo_Click( object sender, EventArgs e ) {
            if ( this.ActiveMdiChild != null )
            {
                DiagramForm diagramForm = this.ActiveMdiChild as DiagramForm;
                if ( diagramForm != null )
                {
                    diagramForm.Diagram.Model.HistoryManager.Redo( );
                    propertyEditor.PropertyGrid.Refresh( );
                }
            }
        }
        private void barItemEditSelectAll_Click( object sender, EventArgs e ) {
            if ( this.ActiveMdiChild != null )
            {
                DiagramForm diagramForm = this.ActiveMdiChild as DiagramForm;
                if ( diagramForm != null )
                {
                    diagramForm.Diagram.Controller.SelectAll( );
                }
            }
        }
        #endregion

        #region View Menu Event Handlers
        public void barShowRulers_Click( object sender, EventArgs e ) {
            if ( ActiveDiagram != null )
            {
                barShowRulers.Checked = !barShowRulers.Checked;
                this.ActiveDiagram.ShowRulers = barShowRulers.Checked;
            }
        }
        private void barItemViewSymbolPalette_Click( object sender, EventArgs e ) {
            if ( this.barItemViewSymbolPalette.Checked )
            {
                this.dockingManager.SetDockVisibility( this.symbolPaletteGroupBar, false );
                this.barItemViewSymbolPalette.Checked = false;
            }
            else
            {
                this.dockingManager.SetDockVisibility( this.symbolPaletteGroupBar, true );
                this.barItemViewSymbolPalette.Checked = true;
            }
        }

        private void barItemViewProperties_Click( object sender, EventArgs e ) {
            if ( this.barItemViewProperties.Checked )
            {
                this.dockingManager.SetDockVisibility( this.propertyEditor, false );
            }
            else
            {
                this.dockingManager.SetDockVisibility( this.propertyEditor, true );
            }
        }

        private void barItemPanZoom_Click( object sender, EventArgs e ) {
            if ( barItemPanZoom.Checked )
            {
                dockingManager.SetDockVisibility( overviewControl1, false );
            }
            else
            {
                if ( this.ActiveDiagram != null )
                {
                    dockingManager.SetDockVisibility( overviewControl1, true );
                }
            }
        }
        private void barItemDocumentExplorer_Click( object sender, EventArgs e ) {
            if ( barItemDocumentExplorer.Checked )
            {
                // Hide the document explorer control
                dockingManager.SetDockVisibility( m_documentExplorer, false );
                barItemDocumentExplorer.Checked = false;
            }
            else
            {
                // Initialize the OverviewControl with the active diagram's Model & View and display the control
                if ( ( this.ActiveDiagram != null ) && ( !this.dockingManager.GetDockVisibility( m_documentExplorer ) ) )
                {
                    dockingManager.SetDockVisibility( m_documentExplorer, true );
                    dockingManager.SetControlSize( m_documentExplorer, new Size( 201, 492 ) );
                }

                barItemDocumentExplorer.Checked = true;
            }
        }
        private void HeaderFooterSetup( ) {
            Controls.Diagram activeDiagram = this.ActiveDiagram;
            if ( activeDiagram != null && activeDiagram.Model != null )
            {
                HeaderFooterDialog dlgHF = new HeaderFooterDialog( );
                dlgHF.Header = activeDiagram.Model.HeaderFooterData.Header;
                dlgHF.Footer = activeDiagram.Model.HeaderFooterData.Footer;
                dlgHF.MeasurementUnits = activeDiagram.Model.MeasurementUnits;
                if ( dlgHF.ShowDialog( ) == DialogResult.OK )
                {
                    activeDiagram.Model.HeaderFooterData.Header = dlgHF.Header;
                    activeDiagram.Model.HeaderFooterData.Footer = dlgHF.Footer;
                }
            }
        }

        private void PageBordersSetup( ) {
            Controls.Diagram activeDiagram = this.ActiveDiagram;
            if ( activeDiagram != null && activeDiagram.Model != null )
            {
                PageBorderDialog borderDialog = new PageBorderDialog( );
                borderDialog.PageBorderStyle = activeDiagram.View.PageBorderStyle;
                if ( borderDialog.ShowDialog( ) == DialogResult.OK )
                {
                    activeDiagram.View.PageBorderStyle = borderDialog.PageBorderStyle;
                    activeDiagram.View.RefreshPageSettings( );
                    activeDiagram.UpdateView( );
                }
            }
        }


        #endregion

        #region Window Menu Event Handlers

        private void biTabbedMDI_Click( object sender, EventArgs e ) {
            // Toggle tabbed MDI mode
            Tools.XPMenus.BarItem barItem = sender as Tools.XPMenus.BarItem;
            if ( barItem != null )
            {
                if ( barItem.Checked )
                {
                    tabbedMDIManager.DetachFromMdiContainer( this, true );
                    barItem.Checked = false;
                }
                else
                {
                    tabbedMDIManager.AttachToMdiContainer( this );
                    barItem.Checked = true;
                }
            }
        }

        #endregion

        #region Help Menu Event Handlers

        private void barItemAbout_Click( object sender, EventArgs e )
        {
            AboutForm aboutDlg = new AboutForm(AppDomain.CurrentDomain.GetAssemblies());
            aboutDlg.ShowDialog(this);
        }

        #endregion

        #region Docking

        private void dockingManager_DockVisibilityChanged( object sender, Tools.DockVisibilityChangedEventArgs e ) {
            if ( e.Control == this.propertyEditor )
            {
                bool check = this.dockingManager.GetDockVisibility( propertyEditor );
                if ( check )
                {
                    propertyEditor.Diagram = this.ActiveDiagram;
                    this.barItemViewProperties.Checked = true;
                }
                else
                {
                    propertyEditor.Diagram = null;
                    this.barItemViewProperties.Checked = false;
                }
            }
            else if ( e.Control == this.symbolPaletteGroupBar )
            {
                this.barItemViewSymbolPalette.Checked = this.dockingManager.GetDockVisibility( symbolPaletteGroupBar );
            }
            else if ( e.Control == this.overviewControl1 )
            {
                bool check = this.dockingManager.GetDockVisibility( overviewControl1 );
                if ( check )
                {
                    overviewControl1.Diagram = this.ActiveDiagram;
                    this.barItemViewProperties.Checked = true;
                }
                else
                {
                    overviewControl1.DetachDiagram( );
                    this.barItemPanZoom.Checked = false;
                }
            }
            else if ( e.Control == m_documentExplorer )
                barItemDocumentExplorer.Checked = this.dockingManager.GetDockVisibility( m_documentExplorer );
        }

        #endregion

        #region UI Updating

        private void OnIdle( object sender, EventArgs evtArgs ) {
            Controls.Diagram activeDiagram = this.ActiveDiagram;

            string editUndoText = this.resStringMgr.GetString( "EditUndoText" );
            string editRedoText = this.resStringMgr.GetString( "EditRedoText" );
            this.barItemPanZoom.Checked = dockingManager.GetDockVisibility( overviewControl1 );
            this.barItemDocumentExplorer.Checked = dockingManager.GetDockVisibility( m_documentExplorer );
            this.barItemViewProperties.Checked = dockingManager.GetDockVisibility( propertyEditor );
            this.barItemViewSymbolPalette.Checked = dockingManager.GetDockVisibility( symbolPaletteGroupBar );

            if ( activeDiagram != null && activeDiagram.Model != null )
            {
                this.biFileSave.Enabled = true;
                this.biFileSaveAs.Enabled = true;
                this.barItemEditCopy.Enabled = activeDiagram.CanCopy;
                this.barItemEditCut.Enabled = activeDiagram.CanCut;
                 if (this.WindowState != FormWindowState.Minimized)
                    this.barItemEditPaste.Enabled = activeDiagram.CanPaste;
                this.barItemEditUndo.Enabled = activeDiagram.Model.HistoryManager.CanUndo;
                this.barItemEditRedo.Enabled = activeDiagram.Model.HistoryManager.CanRedo;
                this.barItemEditDelete.Enabled = ( this.ActiveDiagram.Controller.SelectionList.Count > 0 );
                this.barShowRulers.Enabled = true;
                this.barShowRulers.Checked = this.ActiveDiagram.ShowRulers;
                this.barItemEditSelectAll.Enabled = true;
                this.biFilePrint.Enabled = true;
                this.biPageSetup.Enabled = true;
                barItemAlignLeft.Enabled = ( this.ActiveDiagram.Controller.SelectionList.Count >= 2 );
                barItemAlignCenter.Enabled = ( this.ActiveDiagram.Controller.SelectionList.Count >= 2 );
                barItemAlignRight.Enabled = ( this.ActiveDiagram.Controller.SelectionList.Count >= 2 );
                barItemAlignTop.Enabled = ( this.ActiveDiagram.Controller.SelectionList.Count >= 2 );
                barItemAlignMiddle.Enabled = ( this.ActiveDiagram.Controller.SelectionList.Count >= 2 );
                barItemAlignBottom.Enabled = ( this.ActiveDiagram.Controller.SelectionList.Count >= 2 );
                barItemFlipHorizontally.Enabled = ( this.ActiveDiagram.Controller.SelectionList.Count > 0 );
                barItemFlipVertically.Enabled = ( this.ActiveDiagram.Controller.SelectionList.Count > 0 );
                barItemFlipBoth.Enabled = ( this.ActiveDiagram.Controller.SelectionList.Count > 0 );
                barItemGroupingGroup.Enabled = ( this.ActiveDiagram.Controller.SelectionList.Count > 1 );
                barItemGroupingUnGroup.Enabled = true;
                barItemOrderFront.Enabled = ( this.ActiveDiagram.Controller.SelectionList.Count > 0 );
                barItemOrderForward.Enabled = ( this.ActiveDiagram.Controller.SelectionList.Count > 0 );
                barItemOrderBackward.Enabled = ( this.ActiveDiagram.Controller.SelectionList.Count > 0 );
                barItemOrderBack.Enabled = ( this.ActiveDiagram.Controller.SelectionList.Count > 0 );
                barItemRotateClock.Enabled = ( this.ActiveDiagram.Controller.SelectionList.Count > 0 );
                barItemRotateConter.Enabled = ( this.ActiveDiagram.Controller.SelectionList.Count > 0 );
                barItemResizeWidth.Enabled = ( this.ActiveDiagram.Controller.SelectionList.Count > 1 );
                barItemResizeHeight.Enabled = ( this.ActiveDiagram.Controller.SelectionList.Count > 1 );
                barItemResizeSize.Enabled = ( this.ActiveDiagram.Controller.SelectionList.Count > 1 );
                barItemResizeAcross.Enabled = ( this.ActiveDiagram.Controller.SelectionList.Count > 1 );
                barItemResizeDown.Enabled = ( this.ActiveDiagram.Controller.SelectionList.Count > 1 );
                if ( this.ActiveDiagram.Controller.SelectionList.Count > 0 )
                {
                    Node node = this.ActiveDiagram.Controller.SelectionList[0];
                    barItemFillStyle.Enabled = ( TypeDescriptor.GetProperties( node, false )["FillStyle"] != null );
                    barItemShadowStyle.Enabled = ( TypeDescriptor.GetProperties( node, false )["ShadowStyle"] != null );
                }

                string[] strDescriptions;
                int nDescWanted = 1;
                int nDescReturned = activeDiagram.Model.HistoryManager.GetUndoDescriptions( nDescWanted, out strDescriptions );

                if ( nDescReturned == nDescWanted )
                    editUndoText = editUndoText + " " + strDescriptions[0];

                // clear strDecsriptions.
                nDescReturned = activeDiagram.Model.HistoryManager.GetRedoDescriptions( nDescWanted, out strDescriptions );
                if ( nDescReturned == nDescWanted )
                    editRedoText = editRedoText + " " + strDescriptions[0];
            }
            else
            {
                this.biFileSave.Enabled = false;
                this.biFileSaveAs.Enabled = false;
                this.barItemEditCopy.Enabled = false;
                this.barItemEditCut.Enabled = false;
                this.barItemEditPaste.Enabled = false;
                this.barItemEditUndo.Enabled = false;
                this.barItemEditRedo.Enabled = false;
                this.barItemEditSelectAll.Enabled = false;
                this.biFilePrint.Enabled = false;
                this.biPageSetup.Enabled = false;
                this.barItemEditDelete.Enabled = false;
                this.barShowRulers.Enabled = false;

                barItemAlignLeft.Enabled = false;
                barItemAlignCenter.Enabled = false;
                barItemAlignRight.Enabled = false;
                barItemAlignTop.Enabled = false;
                barItemAlignMiddle.Enabled = false;
                barItemAlignBottom.Enabled = false;
                barItemFlipHorizontally.Enabled = false;
                barItemFlipVertically.Enabled = false;
                barItemFlipBoth.Enabled = false;
                barItemGroupingGroup.Enabled = false;
                barItemGroupingUnGroup.Enabled = false;
                barItemOrderFront.Enabled = false;
                barItemOrderForward.Enabled = false;
                barItemOrderBackward.Enabled = false;
                barItemOrderBack.Enabled = false;
                barItemRotateClock.Enabled = false;
                barItemRotateConter.Enabled = false;
                barItemResizeWidth.Enabled = false;
                barItemResizeHeight.Enabled = false;
                barItemResizeSize.Enabled = false;
                barItemResizeAcross.Enabled = false;
                barItemResizeDown.Enabled = false;
                barItemFillStyle.Enabled = false;
                barItemShadowStyle.Enabled = false;
            }

            this.barItemEditUndo.Text = editUndoText;
            this.barItemEditRedo.Text = editRedoText;
        }

        #endregion

        #region Printing

        private void PageSetup( ) {
            Controls.Diagram activeDiagram = this.ActiveDiagram;

			if (activeDiagram == null || activeDiagram.Model == null)
				return;

			using (PageSetupDialog dlgPageSetup = new PageSetupDialog( activeDiagram.View ))
			{
				if (dlgPageSetup.ShowDialog() == DialogResult.OK)
                {
                    activeDiagram.UpdateView( );
                }
            }
        }

        private void Print( ) {
            //			TextNode txtnode = new TextNode( "Hello World" );
            //			txtnode.SizeToText( new SizeF( 500,50 ) );

            //			InsertNodesCmd inscmd = new InsertNodesCmd();
            //			inscmd.Location = new PointF( 50,50 );
            //			inscmd.Nodes.Add( txtnode );
            //			this.ActiveDiagram.Controller.ExecuteCommand( inscmd );

            //			GroupCmd grpcmd = new GroupCmd();
            //			grpcmd.Nodes.Add( txtnode );
            //			this.ActiveDiagram.Controller.ExecuteCommand( grpcmd );

            Controls.Diagram activeDiagram = this.ActiveDiagram;
            if ( activeDiagram != null )
            {
                PrintDocument printDoc = activeDiagram.CreatePrintDocument( );
                PrintDialog printDlg = new PrintDialog( );
                printDlg.Document = printDoc;

                printDlg.AllowSomePages = true;

                if ( printDlg.ShowDialog( this ) == DialogResult.OK )
                {
                    printDoc.PrinterSettings = printDlg.PrinterSettings;
                    printDoc.Print( );
                }
            }
        }

        private void PrintPreview( ) {
            Controls.Diagram activeDiagram = this.ActiveDiagram;

            if ( activeDiagram != null )
            {
                PrintDocument printDoc = activeDiagram.CreatePrintDocument( );
                PrintPreviewDialog printPreviewDlg = new PrintPreviewDialog( );
                printPreviewDlg.StartPosition = FormStartPosition.CenterScreen;

                printDoc.PrinterSettings.FromPage = 0;
                printDoc.PrinterSettings.ToPage = 0;
                printDoc.PrinterSettings.PrintRange = PrintRange.AllPages;

                printPreviewDlg.Document = printDoc;
                printPreviewDlg.ShowDialog( this );
            }
        }

        #endregion

        #region MDI Window Management

        private void DiagramForm_Closing( object sender, CancelEventArgs e ) {
            DiagramForm docForm = sender as DiagramForm;
            if ( docForm != null && docForm.Diagram.Model != null )
            {
                if ( docForm.Diagram.Model.Modified )
                {
                    DialogResult res = MessageBox.Show( this, "The diagram has been modified. Save changes?", "Save changes", MessageBoxButtons.YesNoCancel );
                    if ( res == DialogResult.Yes )
                    {
                        if ( docForm.HasFileName )
                        {
                            this.saveDiagramDialog.FileName = docForm.FileName;
                        }
                        if ( this.saveDiagramDialog.ShowDialog( this ) == DialogResult.OK )
                        {
                            docForm.SaveAsFile( this.saveDiagramDialog.FileName );
                        }
                        else
                        {
                            e.Cancel = true;
                        }
                    }
                    else if ( res == DialogResult.Cancel )
                    {
                        e.Cancel = true;
                    }
                }

                if ( !e.Cancel )
                {
                    m_documentExplorer.DetachModel(docForm.Diagram.Model);
                    this.overviewControl1.DetachDiagram( );
                }
            }
        }

        #endregion

        #region Actions
        private void m_documentExplorer_AfterSelect( object sender, TreeViewEventArgs e ) {
            // Update diagram's selection list depending on TreeNode Tag
            if ( e.Node.Tag is Model )
            {
                foreach ( Form frm in this.MdiChildren )
                {
                    DiagramForm frmDgm = frm as DiagramForm;

                    if ( frmDgm != null )
                    {
                        if ( frmDgm.Diagram != null && frmDgm.Diagram.Model != null
                            && frmDgm.Diagram.Model.Equals( e.Node.Tag ) )
                        {
                            frmDgm.BringToFront( );
                            break;
                        }
                    }
                }
            }
            else if ( e.Node.Tag is Node )
            {
                Node nodeTemp = e.Node.Tag as Node;

                if ( nodeTemp != null )
                {
                    if ( nodeTemp.Visible && nodeTemp.Root.Equals( this.ActiveDiagram.Model ) )
                    {
                        ActiveDiagram.View.SelectionList.Clear( );
                        ActiveDiagram.View.SelectionList.Add( e.Node.Tag as Node );
                    }
                    else
                    {
                        propertyEditor.PropertyGrid.SelectedObject = nodeTemp;
                    }
                }
            }
        }

        private void barItemEditDelete_Click( object sender, EventArgs e ) {
            if ( this.ActiveMdiChild != null )
            {
                DiagramForm diagramForm = this.ActiveMdiChild as DiagramForm;
                if ( diagramForm != null )
                {
                    diagramForm.Diagram.Controller.Delete( );
                }
            }
        }

        private void barItemAlign_Click( object sender, EventArgs e ) {
            switch ( ( ( Tools.XPMenus.BarItem )sender ).ID )
            {
                case "AlignLeft":
                    this.ActiveDiagram.AlignLeft( );
                    break;
                case "AlignCenter":
                    this.ActiveDiagram.AlignCenter( );
                    break;
                case "AlignBottom":
                    this.ActiveDiagram.AlignBottom( );
                    break;
                case "AlignMiddle":
                    this.ActiveDiagram.AlignMiddle( );
                    break;
                case "AlignTop":
                    this.ActiveDiagram.AlignTop( );
                    break;
                case "AlignRight":
                    this.ActiveDiagram.AlignRight( );
                    break;
                default:
                    break;
            }

        }

        private void barItemFlip_Click( object sender, EventArgs e ) {
            switch ( ( ( Tools.XPMenus.BarItem )sender ).ID.ToLower( ) )
            {
                case "fliphorizontally":
                    this.ActiveDiagram.FlipHorizontal( );
                    break;
                case "flipvertically":
                    this.ActiveDiagram.FlipVertical( );
                    break;
                case "flipboth":
                    this.ActiveDiagram.FlipHorizontal( );
                    this.ActiveDiagram.FlipVertical( );
                    break;
                default:
                    break;
            }

        }

        private void barItemGroupingGroup_Click( object sender, EventArgs e ) {
            switch ( ( ( Tools.XPMenus.BarItem )sender ).ID.ToLower( ) )
            {
                case "group":
                    this.ActiveDiagram.Controller.Group( );
                    break;
                case "ungroup":
                    this.ActiveDiagram.Controller.UnGroup( );
                    break;
                default:
                    break;
            }
        }

        private void barItemOrder_Click( object sender, EventArgs e ) {
            switch ( ( ( Tools.XPMenus.BarItem )sender ).ID.ToLower( ) )
            {
                case "bring to front":
                    this.ActiveDiagram.Controller.BringToFront( );
                    break;
                case "bring forward":
                    this.ActiveDiagram.Controller.BringForward( );
                    break;
                case "send backward":
                    this.ActiveDiagram.Controller.SendBackward( );
                    break;
                case "send to back":
                    this.ActiveDiagram.Controller.SendToBack( );
                    break;
                default:
                    break;
            }

        }

        private void barItemRotate_Click( object sender, EventArgs e ) {
            switch ( ( ( Tools.XPMenus.BarItem )sender ).ID.ToLower( ) )
            {
                case "rotateclock":
                    this.ActiveDiagram.Rotate( 90 );
                    break;
                case "rotateconter":
                    this.ActiveDiagram.Rotate( -90 );
                    break;
                default:
                    break;
            }

        }

        private void barItemResize_Click( object sender, EventArgs e ) {
            switch ( ( ( Tools.XPMenus.BarItem )sender ).ID.ToLower( ) )
            {
                case "spaceacross":
                    this.ActiveDiagram.SpaceAcross( );
                    break;
                case "spacedown":
                    this.ActiveDiagram.SpaceDown( );
                    break;
                case "samesize":
                    this.ActiveDiagram.SameSize( );
                    break;
                case "sameheight":
                    this.ActiveDiagram.SameHeight( );
                    break;
                case "samewidth":
                    this.ActiveDiagram.SameWidth( );
                    break;
                default:
                    break;
            }
        }

        private void barItemLayout_Click( object sender, EventArgs e ) {
            LayoutDialog dialog = new LayoutDialog( this.ActiveDiagram );
            dialog.Show( );
        }
        #endregion

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main( string[] args ) {
            SyncfusionLicenseProvider.RegisterLicense(DemoCommon.FindLicenseKey());
            Application.ThreadException += new System.Threading.ThreadExceptionEventHandler( DefaultExceptionHandler.Singleton.OnThreadException );
            if ( args.Length > 0 )
            {
                if ( File.Exists( args[0] ) )
                    Application.Run( new MainForm( args[0] ) );
                else
                {
                    Console.WriteLine( "File doesnot exists" );
                    Console.WriteLine( "----------------------" );
                    Console.WriteLine( "Running in default mode" );
                    Application.Run( new MainForm( ) );
                }
            }
            else
                Application.Run( new MainForm( ) );
            Application.ThreadException -= new System.Threading.ThreadExceptionEventHandler( DefaultExceptionHandler.Singleton.OnThreadException );
        }


        internal Tools.XPMenus.ParentBarItem GetPopupParentBar( ) {
            return this.parentBarItemPopUp;
        }

        private void shadowBarItem_Click( object sender, System.EventArgs e ) {
            ShadowStyleDialog ssd = new ShadowStyleDialog( );
            ShadowStyle fs = null;
            foreach ( Node n in this.ActiveDiagram.Controller.SelectionList )
            {
                fs = ( ShadowStyle )TypeDescriptor.GetProperties( n, false )["ShadowStyle"].GetValue( n );
                if ( fs != null )
                {
                    break;
                }
            }
            if ( fs != null )
            {
                ssd.ShadowStyle.Color = fs.Color;
                ssd.ShadowStyle.ForeColor = fs.ForeColor;
                ssd.ShadowStyle.ColorAlphaFactor = fs.ColorAlphaFactor;
                ssd.ShadowStyle.ForeColorAlphaFactor = fs.ForeColorAlphaFactor;
                ssd.ShadowStyle.PathBrushStyle = fs.PathBrushStyle;
                ssd.ShadowStyle.OffsetX = fs.OffsetX;
                ssd.ShadowStyle.OffsetY = fs.OffsetY;
                ssd.ShadowStyle.Visible = fs.Visible;
                if ( DialogResult.OK == ssd.ShowDialog( ) )
                {
                    foreach ( Node n in this.ActiveDiagram.Controller.SelectionList )
                    {
                        fs = ( ShadowStyle )TypeDescriptor.GetProperties( n, false )["ShadowStyle"].GetValue( n );
                        if ( fs != null )
                        {
                            fs.Color = ssd.ShadowStyle.Color;
                            fs.ForeColor = ssd.ShadowStyle.ForeColor;
                            fs.ColorAlphaFactor = ssd.ShadowStyle.ColorAlphaFactor;
                            fs.ForeColorAlphaFactor = ssd.ShadowStyle.ForeColorAlphaFactor;
                            fs.PathBrushStyle = ssd.ShadowStyle.PathBrushStyle;
                            fs.OffsetX = ssd.ShadowStyle.OffsetX;
                            fs.OffsetY = ssd.ShadowStyle.OffsetY;
                            fs.Visible = ssd.ShadowStyle.Visible;
                        }
                    }
                }
            }
        }

        private void fillBarItem_Click( object sender, System.EventArgs e ) {
            FillStyleDialog fsd = new FillStyleDialog( );
            Node node;
            FillStyle fs = null;
            foreach ( Node n in this.ActiveDiagram.Controller.SelectionList )
            {
                fs = ( FillStyle )TypeDescriptor.GetProperties( n, false )["FillStyle"].GetValue( n );
                if ( fs != null )
                {
                    node = n;
                    break;
                }
            }

            if ( fs != null )
            {
                fsd.FillStyle.Color = fs.Color;
                fsd.FillStyle.ForeColor = fs.ForeColor;
                fsd.FillStyle.ColorAlphaFactor = fs.ColorAlphaFactor;
                fsd.FillStyle.ForeColorAlphaFactor = fs.ForeColorAlphaFactor;
                fsd.FillStyle.Type = fs.Type;
                fsd.FillStyle.GradientAngle = fs.GradientAngle;
                fsd.FillStyle.GradientCenter = fs.GradientCenter;
                fsd.FillStyle.PathBrushStyle = fs.PathBrushStyle;
                fsd.FillStyle.HatchBrushStyle = fs.HatchBrushStyle;
                fsd.FillStyle.Texture = fs.Texture;
                fsd.FillStyle.TextureWrapMode = fs.TextureWrapMode;
                if ( DialogResult.OK == fsd.ShowDialog( ) )
                {
                    foreach ( Node n in this.ActiveDiagram.Controller.SelectionList )
                    {
                        fs = ( FillStyle )TypeDescriptor.GetProperties( n, false )["FillStyle"].GetValue( n );
                        if ( fs != null )
                        {
                            fs.Color = fsd.FillStyle.Color;
                            fs.ForeColor = fsd.FillStyle.ForeColor;
                            fs.ColorAlphaFactor = fsd.FillStyle.ColorAlphaFactor;
                            fs.ForeColorAlphaFactor = fsd.FillStyle.ForeColorAlphaFactor;
                            fs.Type = fsd.FillStyle.Type;
                            fs.GradientAngle = fsd.FillStyle.GradientAngle;
                            fs.GradientCenter = fsd.FillStyle.GradientCenter;
                            fs.PathBrushStyle = fsd.FillStyle.PathBrushStyle;
                            fs.HatchBrushStyle = fsd.FillStyle.HatchBrushStyle;
                            fs.Texture = fsd.FillStyle.Texture;
                            fs.TextureWrapMode = fsd.FillStyle.TextureWrapMode;
                        }
                    }
                }
            }
        }

        private void tabbedMDIManager_TabControlAdded( object sender, Syncfusion.Windows.Forms.Tools.TabbedMDITabControlEventArgs args ) {
            args.TabControl.TabStyle = typeof( TabRendererOffice2007 );
            tabbedMDIManager.ContextMenuItem.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007;
        }

        private void MainForm_Closing( object sender, CancelEventArgs e ) {
            // Save Menu Bars State
            AppStateSerializer serializer = new AppStateSerializer( SerializeMode.XMLFile, @"..\..\persist" );
            this.mainFrameBarManager.SaveBarState( serializer );
            serializer.PersistNow( );
        }        
    }

    /// <summary>
    /// Represents a class that is used to find the licensing file for Syncfusion controls.
    /// </summary>
    public class DemoCommon
    {
        /// <summary>
        /// Finds the license key from the Common folder.
        /// </summary>
        /// <returns>Returns the license key.</returns>
        public static string FindLicenseKey()
        {
            string licenseKeyFile = "..\\Common\\SyncfusionLicense.txt";
            for (int n = 0; n < 20; n++)
            {
                if (!System.IO.File.Exists(licenseKeyFile))
                {
                    licenseKeyFile = @"..\" + licenseKeyFile;
                    continue;
                }
                return System.IO.File.ReadAllText(licenseKeyFile);
            }
            return string.Empty;
        }
    }
}

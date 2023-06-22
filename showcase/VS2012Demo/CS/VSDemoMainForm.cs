#region Copyright Syncfusion Inc. 2001-2023.
// Copyright Syncfusion Inc. 2001-2023. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Drawing;
using System.Collections;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

using Syncfusion.Runtime.Serialization;
using Syncfusion.Windows.Forms;
using Syncfusion.Windows.Forms.Tools;
using Syncfusion.Windows.Forms.Tools.XPMenus;
using DemoCommon;
using Syncfusion.WinForms.Controls;

namespace VSDemo
{
    /// <summary>
    /// Summary description for VSDemoMainForm.
    /// </summary>
    public class VSDemoMainForm : SfForm
    {

        #region private members

        private TabbedMDIManager tabbedMDIManager;
        private WatchWindowView watchWindow;


        private Syncfusion.Windows.Forms.Tools.DockingManager dockingManager1;
        private Syncfusion.Windows.Forms.Tools.XPMenus.MainFrameBarManager mainFrameBarManager1;
        private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem fileParentBarItem;
        private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem parentBarItem1;
        private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem parentBarItem2;
        private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem parentBarItem3;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem1;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem2;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem3;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem4;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem5;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem6;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem7;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem8;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem9;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem10;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem11;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem12;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem13;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem15;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem16;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem17;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem18;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem27;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem28;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem29;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem30;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem31;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem32;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem33;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem34;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem35;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem36;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem37;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem38;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem39;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem40;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem41;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem42;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem43;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem44;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem45;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem46;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem47;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem48;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem49;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem50;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem51;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem52;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem53;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem54;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem55;
        private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem parentBarItem4;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem56;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem57;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem58;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem59;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem60;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem61;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem62;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem63;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem64;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem65;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem66;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem67;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem68;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem69;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem70;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem71;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem72;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem73;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem74;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem75;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem76;
        private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem parentBarItem6;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem77;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem78;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem79;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem80;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem81;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem82;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem83;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem84;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem85;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem86;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem88;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem89;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem90;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem91;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem92;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem97;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem98;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem95;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem96;
        private Syncfusion.Windows.Forms.Tools.XPMenus.Bar mainMenuBar;
        private Syncfusion.Windows.Forms.Tools.XPMenus.Bar mainToolBar;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem openFileBarItem;
        private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem parentBarItem10;
        private Syncfusion.Windows.Forms.Tools.XPMenus.ListBarItem recentFileListBarItem;
        private VSDemo.ErrorlistView errorlistView1;
        private VSDemo.OutputWindowView outputWindowView1;
        private VSDemo.FindResultsView findResultsView1;
        private VSDemo.ToolBoxView toolBoxView1;
        private VSDemo.ClassView classView1;
        private VSDemo.SolutionExplorerView solutionExplorerView1;
        private VSDemo.PropertiesView propertiesView1;
        private System.Windows.Forms.ImageList dockingImageList;
        internal System.Windows.Forms.ImageList imageList1;
        private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem windowParentBarItem;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem14;
        private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem parentBarItem9;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem19;
        private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem debugWindowsParentBarItem;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem20;
        private System.Windows.Forms.ImageList imageList2;
        private VSDemo.ObjectBrowserView objectBrowserView1;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem21;
        private Syncfusion.Windows.Forms.Tools.XPMenus.ComboBoxBarItem comboBoxBarItem1;
        private Syncfusion.Windows.Forms.Tools.XPMenus.ComboBoxBarItem comboBoxBarItem2;
        private Syncfusion.Windows.Forms.Tools.XPMenus.Bar bar2;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem22;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem23;
        private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem parentBarItem7;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem24;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem25;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem26;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem87;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem93;
        private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem Office2007ParentBarItem;
        private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem Office2016ParentBarItem;
        private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem VisualStylesParentBarItem;
        private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem projectParentBarItem;
        private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem debugParentBarItem;
        public CodeEditorBase codeEditorForm = null;
        private System.ComponentModel.IContainer components;
        private SplashPanel splashPanel1;
        private BarItem barItem94;
        private BarItem barItem2016White;
        private BarItem barItem2016Black;
        private BarItem barItem2016DrakGray;
        private BarItem barItem2016Colorful;
        private SkinManager skinManager1;
        private SplashControl splashControl1;

        #endregion

        #region Constructor

        public VSDemoMainForm()
        {
            //
            // Required for Windows Form Designer support
            //
			
            InitializeComponent();
           this.splashControl1.ShowDialogSplash(this);
            
             this.tabbedMDIManager = new TabbedMDIManager();
            this.tabbedMDIManager.AttachToMdiContainer(this);
            this.tabbedMDIManager.CloseOnMiddleButtonClick = true;
            this.tabbedMDIManager.TabStyle = typeof(TabRendererMetro);
            this.tabbedMDIManager.TabControlAdded += new TabbedMDITabControlEventHandler(tabbedMDIManager_TabControlAdded);
            this.tabbedMDIManager.UseIconsInTabs = false;
            this.tabbedMDIManager.ContextMenuItem.BeforePopup += new CancelEventHandler(ContextMenuItem_BeforePopup);
            this.tabbedMDIManager.BeforeDropDownPopup += new DropDownPopupEventHandler(tabbedMDIManager_BeforeDropDownPopup);
            this.tabbedMDIManager.DropDownButtonVisible = true;
            this.tabbedMDIManager.CloseButtonVisible = true;
            this.tabbedMDIManager.ShowCloseButton = true;
            this.tabbedMDIManager.ShowCloseButtonForActiveTabOnly = true; 
            this.dockingManager1.MetroColor = Color.FromArgb(0, 122, 204);

            UpdateLayout();
        }

        #endregion

        private void UpdateLayout()
        {
            dockingManager1.DockControl(outputWindowView1, this, DockingStyle.Bottom, 30);
            dockingManager1.DockControl(errorlistView1, outputWindowView1, DockingStyle.Tabbed, 30);
            dockingManager1.DockControl(findResultsView1, outputWindowView1, DockingStyle.Tabbed, 30);
            dockingManager1.DockControl(toolBoxView1, this, DockingStyle.Left, 281);
            dockingManager1.DockControl(propertiesView1, this, DockingStyle.Right, 254);
            dockingManager1.DockControl(solutionExplorerView1, propertiesView1, DockingStyle.Tabbed, 30);
            dockingManager1.SetAutoHideMode(outputWindowView1, true);
            dockingManager1.SetAutoHideMode(classView1, true);
            dockingManager1.SetAutoHideMode(objectBrowserView1, true);
        }
        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VSDemoMainForm));
            Syncfusion.Windows.Forms.Tools.CaptionButtonsCollection ccberrorlistView1 = new Syncfusion.Windows.Forms.Tools.CaptionButtonsCollection();
            Syncfusion.Windows.Forms.Tools.CaptionButtonsCollection ccboutputWindowView1 = new Syncfusion.Windows.Forms.Tools.CaptionButtonsCollection();
            Syncfusion.Windows.Forms.Tools.CaptionButtonsCollection ccbfindResultsView1 = new Syncfusion.Windows.Forms.Tools.CaptionButtonsCollection();
            Syncfusion.Windows.Forms.Tools.CaptionButtonsCollection ccbclassView1 = new Syncfusion.Windows.Forms.Tools.CaptionButtonsCollection();
            Syncfusion.Windows.Forms.Tools.CaptionButtonsCollection ccbobjectBrowserView1 = new Syncfusion.Windows.Forms.Tools.CaptionButtonsCollection();
            Syncfusion.Windows.Forms.Tools.CaptionButtonsCollection ccbsolutionExplorerView1 = new Syncfusion.Windows.Forms.Tools.CaptionButtonsCollection();
            Syncfusion.Windows.Forms.Tools.CaptionButtonsCollection ccbpropertiesView1 = new Syncfusion.Windows.Forms.Tools.CaptionButtonsCollection();
            Syncfusion.Windows.Forms.Tools.CaptionButtonsCollection ccbtoolBoxView1 = new Syncfusion.Windows.Forms.Tools.CaptionButtonsCollection();
            this.dockingManager1 = new Syncfusion.Windows.Forms.Tools.DockingManager(this.components);
            this.errorlistView1 = new VSDemo.ErrorlistView();
            this.outputWindowView1 = new VSDemo.OutputWindowView();
            this.findResultsView1 = new VSDemo.FindResultsView();
            this.classView1 = new VSDemo.ClassView();
            this.objectBrowserView1 = new VSDemo.ObjectBrowserView();
            this.solutionExplorerView1 = new VSDemo.SolutionExplorerView();
            this.propertiesView1 = new VSDemo.PropertiesView();
            this.toolBoxView1 = new VSDemo.ToolBoxView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.mainFrameBarManager1 = new Syncfusion.Windows.Forms.Tools.XPMenus.MainFrameBarManager(this);
            this.mainMenuBar = new Syncfusion.Windows.Forms.Tools.XPMenus.Bar(this.mainFrameBarManager1, "MainMenu");
            this.fileParentBarItem = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.parentBarItem1 = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.barItem9 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.dockingImageList = new System.Windows.Forms.ImageList(this.components);
            this.barItem10 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem11 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.parentBarItem2 = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.barItem12 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem13 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.openFileBarItem = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.parentBarItem3 = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.barItem15 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem16 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem17 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem18 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem1 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem2 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem35 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem36 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem3 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem4 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem5 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem6 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem7 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.parentBarItem10 = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.recentFileListBarItem = new Syncfusion.Windows.Forms.Tools.XPMenus.ListBarItem();
            this.barItem8 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.parentBarItem4 = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.barItem43 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem44 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem45 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem46 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem21 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem47 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem48 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem49 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem50 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem51 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.barItem52 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem20 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem53 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem54 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem19 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem55 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.projectParentBarItem = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.barItem56 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem57 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem58 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem59 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem60 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem61 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem62 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem63 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem64 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem65 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem66 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem67 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem68 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.parentBarItem6 = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.barItem69 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem70 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem71 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem72 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem73 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem74 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem75 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem76 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.debugParentBarItem = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.debugWindowsParentBarItem = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.barItem83 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem84 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem85 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem77 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem78 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem79 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem80 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem81 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem82 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.parentBarItem7 = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.barItem22 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem23 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.windowParentBarItem = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.barItem86 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem88 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem89 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem90 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem91 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem92 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.parentBarItem9 = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.barItem14 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.VisualStylesParentBarItem = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.barItem24 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem25 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.Office2007ParentBarItem = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.barItem26 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem87 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem93 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.Office2016ParentBarItem = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.barItem2016Black = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem2016White = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem2016Colorful = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem2016DrakGray = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem94 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.mainToolBar = new Syncfusion.Windows.Forms.Tools.XPMenus.Bar(this.mainFrameBarManager1, "File");
            this.bar2 = new Syncfusion.Windows.Forms.Tools.XPMenus.Bar(this.mainFrameBarManager1, "Debug");
            this.comboBoxBarItem1 = new Syncfusion.Windows.Forms.Tools.XPMenus.ComboBoxBarItem();
            this.comboBoxBarItem2 = new Syncfusion.Windows.Forms.Tools.XPMenus.ComboBoxBarItem();
            this.barItem27 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem28 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem29 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem30 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem31 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem32 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem33 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem34 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem37 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem38 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem39 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem40 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem41 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem42 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.splashControl1 = new Syncfusion.Windows.Forms.Tools.SplashControl();
            this.splashPanel1 = new Syncfusion.Windows.Forms.Tools.SplashPanel();
            this.skinManager1 = new Syncfusion.Windows.Forms.SkinManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dockingManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainFrameBarManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxBarItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxBarItem2)).BeginInit();
            this.SuspendLayout();
            // 
            // dockingManager1
            // 
            this.dockingManager1.ActiveCaptionFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            this.dockingManager1.AutoHideActiveControl = true;
            this.dockingManager1.AutoHideInterval = 350;
            this.dockingManager1.BorderColor = System.Drawing.Color.Transparent;
#if NETCORE && NET50
            this.dockingManager1.DockLayoutStream = ((System.IO.MemoryStream)(resources.GetObject("dockingManager1.DockLayoutStream")));
#endif
            this.dockingManager1.DragProviderStyle = Syncfusion.Windows.Forms.Tools.DragProviderStyle.VS2012;
            this.dockingManager1.HostControl = this;
            this.dockingManager1.InActiveCaptionFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            this.dockingManager1.MetroButtonColor = System.Drawing.Color.White;
            this.dockingManager1.MetroCaptionColor = System.Drawing.Color.White;
            this.dockingManager1.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218)))));
            this.dockingManager1.PersistState = true;
            this.dockingManager1.ReduceFlickeringInRtl = false;
            this.dockingManager1.VisualStyle = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.dockingManager1.DockControlActivated += new Syncfusion.Windows.Forms.Tools.DockActivationChangedEventHandler(this.dockingManager1_DockControlActivated);
            this.dockingManager1.DockVisibilityChanged += new Syncfusion.Windows.Forms.Tools.DockVisibilityChangedEventHandler(this.dockingManager1_DockVisibilityChanged);
            this.dockingManager1.DockStateChanged += new Syncfusion.Windows.Forms.Tools.DockStateChangeEventHandler(this.dockingManager1_DockStateChanged);
            this.dockingManager1.NewDockStateEndLoad += new System.EventHandler(this.dockingManager1_NewDockStateEndLoad);
            this.dockingManager1.CaptionButtons.Add(new Syncfusion.Windows.Forms.Tools.CaptionButton(Syncfusion.Windows.Forms.Tools.CaptionButtonType.Close, "CloseButton"));
            this.dockingManager1.CaptionButtons.Add(new Syncfusion.Windows.Forms.Tools.CaptionButton(Syncfusion.Windows.Forms.Tools.CaptionButtonType.Pin, "PinButton"));
            this.dockingManager1.CaptionButtons.Add(new Syncfusion.Windows.Forms.Tools.CaptionButton(Syncfusion.Windows.Forms.Tools.CaptionButtonType.Menu, "MenuButton"));
            this.dockingManager1.CaptionButtons.Add(new Syncfusion.Windows.Forms.Tools.CaptionButton(Syncfusion.Windows.Forms.Tools.CaptionButtonType.Maximize, "MaximizeButton"));
            this.dockingManager1.SetDockLabel(this.errorlistView1, "Error List");
            this.dockingManager1.SetEnableDocking(this.errorlistView1, true);
            ccberrorlistView1.MergeWith(this.dockingManager1.CaptionButtons, false);
            this.dockingManager1.SetCustomCaptionButtons(this.errorlistView1, ccberrorlistView1);
            this.dockingManager1.SetDockLabel(this.outputWindowView1, "Output Window");
            this.dockingManager1.SetEnableDocking(this.outputWindowView1, true);
            ccboutputWindowView1.MergeWith(this.dockingManager1.CaptionButtons, false);
            this.dockingManager1.SetCustomCaptionButtons(this.outputWindowView1, ccboutputWindowView1);
            this.dockingManager1.SetDockLabel(this.findResultsView1, "Find Results");
            this.dockingManager1.SetEnableDocking(this.findResultsView1, true);
            ccbfindResultsView1.MergeWith(this.dockingManager1.CaptionButtons, false);
            this.dockingManager1.SetCustomCaptionButtons(this.findResultsView1, ccbfindResultsView1);
            this.dockingManager1.SetDockLabel(this.classView1, "Class View");
            this.dockingManager1.SetEnableDocking(this.classView1, true);
            ccbclassView1.MergeWith(this.dockingManager1.CaptionButtons, false);
            this.dockingManager1.SetCustomCaptionButtons(this.classView1, ccbclassView1);
            this.dockingManager1.SetDockLabel(this.objectBrowserView1, "Object Browser");
            this.dockingManager1.SetEnableDocking(this.objectBrowserView1, true);
            ccbobjectBrowserView1.MergeWith(this.dockingManager1.CaptionButtons, false);
            this.dockingManager1.SetCustomCaptionButtons(this.objectBrowserView1, ccbobjectBrowserView1);
            this.dockingManager1.SetDockLabel(this.solutionExplorerView1, "Solution Explorer");
            this.dockingManager1.SetEnableDocking(this.solutionExplorerView1, true);
            ccbsolutionExplorerView1.MergeWith(this.dockingManager1.CaptionButtons, false);
            this.dockingManager1.SetCustomCaptionButtons(this.solutionExplorerView1, ccbsolutionExplorerView1);
            this.dockingManager1.SetDockLabel(this.propertiesView1, "Properties");
            this.dockingManager1.SetEnableDocking(this.propertiesView1, true);
            ccbpropertiesView1.MergeWith(this.dockingManager1.CaptionButtons, false);
            this.dockingManager1.SetCustomCaptionButtons(this.propertiesView1, ccbpropertiesView1);
            this.dockingManager1.SetDockLabel(this.toolBoxView1, "ToolBox");
            this.dockingManager1.SetEnableDocking(this.toolBoxView1, true);
            ccbtoolBoxView1.MergeWith(this.dockingManager1.CaptionButtons, false);
            this.dockingManager1.SetCustomCaptionButtons(this.toolBoxView1, ccbtoolBoxView1);
            // 
            // errorlistView1
            // 
            this.errorlistView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorlistView1.Location = new System.Drawing.Point(1, 24);
            this.errorlistView1.Name = "errorlistView1";
            this.errorlistView1.Size = new System.Drawing.Size(1014, 113);
            this.errorlistView1.TabIndex = 5;
            // 
            // outputWindowView1
            // 
            this.outputWindowView1.Location = new System.Drawing.Point(1, 24);
            this.outputWindowView1.Name = "outputWindowView1";
            this.outputWindowView1.Size = new System.Drawing.Size(1014, 113);
            this.outputWindowView1.TabIndex = 7;
            // 
            // findResultsView1
            // 
            this.findResultsView1.Location = new System.Drawing.Point(1, 24);
            this.findResultsView1.Name = "findResultsView1";
            this.findResultsView1.Size = new System.Drawing.Size(1014, 113);
            this.findResultsView1.TabIndex = 8;
            // 
            // classView1
            // 
            this.classView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.classView1.Location = new System.Drawing.Point(1, 24);
            this.classView1.Name = "classView1";
            this.classView1.Size = new System.Drawing.Size(182, 199);
            this.classView1.TabIndex = 11;
            // 
            // objectBrowserView1
            // 
            this.objectBrowserView1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.objectBrowserView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.objectBrowserView1.Location = new System.Drawing.Point(1, 24);
            this.objectBrowserView1.Name = "objectBrowserView1";
            this.objectBrowserView1.Size = new System.Drawing.Size(182, 199);
            this.objectBrowserView1.TabIndex = 24;
            // 
            // solutionExplorerView1
            // 
            this.solutionExplorerView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.solutionExplorerView1.Location = new System.Drawing.Point(1, 24);
            this.solutionExplorerView1.Name = "solutionExplorerView1";
            this.solutionExplorerView1.Size = new System.Drawing.Size(182, 200);
            this.solutionExplorerView1.TabIndex = 13;
            // 
            // propertiesView1
            // 
            this.propertiesView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.propertiesView1.Location = new System.Drawing.Point(1, 24);
            this.propertiesView1.Name = "propertiesView1";
            this.propertiesView1.Size = new System.Drawing.Size(182, 200);
            this.propertiesView1.TabIndex = 14;
            // 
            // toolBoxView1
            // 
            this.toolBoxView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            this.toolBoxView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolBoxView1.Location = new System.Drawing.Point(1, 24);
            this.toolBoxView1.Name = "toolBoxView1";
            this.toolBoxView1.Size = new System.Drawing.Size(194, 478);
            this.toolBoxView1.TabIndex = 9;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Window-New.png");
            this.imageList1.Images.SetKeyName(1, "");
            this.imageList1.Images.SetKeyName(2, "02.png");
            this.imageList1.Images.SetKeyName(3, "");
            this.imageList1.Images.SetKeyName(4, "");
            this.imageList1.Images.SetKeyName(5, "01.png");
            this.imageList1.Images.SetKeyName(6, "");
            this.imageList1.Images.SetKeyName(7, "");
            this.imageList1.Images.SetKeyName(8, "");
            this.imageList1.Images.SetKeyName(9, "");
            this.imageList1.Images.SetKeyName(10, "");
            this.imageList1.Images.SetKeyName(11, "");
            this.imageList1.Images.SetKeyName(12, "Cut.png");
            this.imageList1.Images.SetKeyName(13, "");
            this.imageList1.Images.SetKeyName(14, "");
            this.imageList1.Images.SetKeyName(15, "");
            this.imageList1.Images.SetKeyName(16, "");
            this.imageList1.Images.SetKeyName(17, "FindAll.png");
            this.imageList1.Images.SetKeyName(18, "Play.png");
            this.imageList1.Images.SetKeyName(19, "");
            this.imageList1.Images.SetKeyName(20, "");
            this.imageList1.Images.SetKeyName(21, "");
            this.imageList1.Images.SetKeyName(22, "");
            this.imageList1.Images.SetKeyName(23, "");
            this.imageList1.Images.SetKeyName(24, "");
            this.imageList1.Images.SetKeyName(25, "");
            this.imageList1.Images.SetKeyName(26, "");
            this.imageList1.Images.SetKeyName(27, "Properties.png");
            this.imageList1.Images.SetKeyName(28, "Redo.png");
            this.imageList1.Images.SetKeyName(29, "05.png");
            this.imageList1.Images.SetKeyName(30, "04.png");
            this.imageList1.Images.SetKeyName(31, "06.png");
            this.imageList1.Images.SetKeyName(32, "Undo.png");
            this.imageList1.Images.SetKeyName(33, "Tools.png");
            this.imageList1.Images.SetKeyName(34, "");
            this.imageList1.Images.SetKeyName(35, "");
            this.imageList1.Images.SetKeyName(36, "");
            this.imageList1.Images.SetKeyName(37, "");
            this.imageList1.Images.SetKeyName(38, "");
            this.imageList1.Images.SetKeyName(39, "");
            this.imageList1.Images.SetKeyName(40, "");
            this.imageList1.Images.SetKeyName(41, "");
            this.imageList1.Images.SetKeyName(42, "");
            this.imageList1.Images.SetKeyName(43, "");
            this.imageList1.Images.SetKeyName(44, "");
            this.imageList1.Images.SetKeyName(45, "");
            this.imageList1.Images.SetKeyName(46, "03.png");
            this.imageList1.Images.SetKeyName(47, "AddToWatch.png");
            this.imageList1.Images.SetKeyName(48, "Cut.png");
            this.imageList1.Images.SetKeyName(49, "");
            this.imageList1.Images.SetKeyName(50, "");
            this.imageList1.Images.SetKeyName(51, "");
            this.imageList1.Images.SetKeyName(52, "");
            this.imageList1.Images.SetKeyName(53, "");
            this.imageList1.Images.SetKeyName(54, "");
            this.imageList1.Images.SetKeyName(55, "");
            this.imageList1.Images.SetKeyName(56, "AddItem.png");
            this.imageList1.Images.SetKeyName(57, "");
            this.imageList1.Images.SetKeyName(58, "");
            this.imageList1.Images.SetKeyName(59, "");
            this.imageList1.Images.SetKeyName(60, "");
            this.imageList1.Images.SetKeyName(61, "");
            this.imageList1.Images.SetKeyName(62, "07.png");
            this.imageList1.Images.SetKeyName(63, "New Search Folder.png");
            this.imageList1.Images.SetKeyName(64, "");
            this.imageList1.Images.SetKeyName(65, "");
            this.imageList1.Images.SetKeyName(66, "");
            this.imageList1.Images.SetKeyName(67, "");
            this.imageList1.Images.SetKeyName(68, "");
            this.imageList1.Images.SetKeyName(69, "");
            this.imageList1.Images.SetKeyName(70, "");
            this.imageList1.Images.SetKeyName(71, "");
            this.imageList1.Images.SetKeyName(72, "");
            this.imageList1.Images.SetKeyName(73, "");
            this.imageList1.Images.SetKeyName(74, "");
            this.imageList1.Images.SetKeyName(75, "");
            this.imageList1.Images.SetKeyName(76, "");
            this.imageList1.Images.SetKeyName(77, "");
            this.imageList1.Images.SetKeyName(78, "");
            this.imageList1.Images.SetKeyName(79, "");
            this.imageList1.Images.SetKeyName(80, "Play.png");
            this.imageList1.Images.SetKeyName(81, "");
            this.imageList1.Images.SetKeyName(82, "");
            this.imageList1.Images.SetKeyName(83, "");
            this.imageList1.Images.SetKeyName(84, "");
            this.imageList1.Images.SetKeyName(85, "");
            this.imageList1.Images.SetKeyName(86, "");
            this.imageList1.Images.SetKeyName(87, "");
            this.imageList1.Images.SetKeyName(88, "");
            this.imageList1.Images.SetKeyName(89, "");
            this.imageList1.Images.SetKeyName(90, "News View.png");
            this.imageList1.Images.SetKeyName(91, "");
            this.imageList1.Images.SetKeyName(92, "panels_new3_close.ico");
            this.imageList1.Images.SetKeyName(93, "Next.png");
            this.imageList1.Images.SetKeyName(94, "1.png");
            this.imageList1.Images.SetKeyName(95, "2.png");
            this.imageList1.Images.SetKeyName(96, "3-corrected.png");
            this.imageList1.Images.SetKeyName(97, "4.png");
            this.imageList1.Images.SetKeyName(98, "5.png");
            this.imageList1.Images.SetKeyName(99, "6.png");
            this.imageList1.Images.SetKeyName(100, "11.png");
            this.imageList1.Images.SetKeyName(101, "12.png");
            this.imageList1.Images.SetKeyName(102, "bookmark.png");
            this.imageList1.Images.SetKeyName(103, "bookmark_left.png");
            this.imageList1.Images.SetKeyName(104, "bookmark_right.png");
            this.imageList1.Images.SetKeyName(105, "combo icon.png");
            this.imageList1.Images.SetKeyName(106, "connect.png");
            this.imageList1.Images.SetKeyName(107, "down.png");
            this.imageList1.Images.SetKeyName(108, "left undo.png");
            this.imageList1.Images.SetKeyName(109, "m1.png");
            this.imageList1.Images.SetKeyName(110, "msg  unread.png");
            this.imageList1.Images.SetKeyName(111, "msg.png");
            this.imageList1.Images.SetKeyName(112, "right undo.png");
            this.imageList1.Images.SetKeyName(113, "run.png");
            this.imageList1.Images.SetKeyName(114, "sub.png");
            this.imageList1.Images.SetKeyName(115, "unmark.png");
            // 
            // mainFrameBarManager1
            // 
#if NETCORE && NET50
            this.mainFrameBarManager1.BarPositionInfo = ((System.IO.MemoryStream)(resources.GetObject("mainFrameBarManager1.BarPositionInfo")));
#endif
            this.mainFrameBarManager1.Bars.Add(this.mainMenuBar);
            this.mainFrameBarManager1.Bars.Add(this.mainToolBar);
            this.mainFrameBarManager1.Bars.Add(this.bar2);
            this.mainFrameBarManager1.Categories.Add("File");
            this.mainFrameBarManager1.Categories.Add("FileNew");
            this.mainFrameBarManager1.Categories.Add("FileOpen");
            this.mainFrameBarManager1.Categories.Add("FileAdd");
            this.mainFrameBarManager1.Categories.Add("View");
            this.mainFrameBarManager1.Categories.Add("Project");
            this.mainFrameBarManager1.Categories.Add("Build");
            this.mainFrameBarManager1.Categories.Add("Debug");
            this.mainFrameBarManager1.Categories.Add("Debug Windows");
            this.mainFrameBarManager1.Categories.Add("Window");
            this.mainFrameBarManager1.Categories.Add("Help");
            this.mainFrameBarManager1.Categories.Add("Data");
            this.mainFrameBarManager1.Categories.Add("Styles");
            this.mainFrameBarManager1.CurrentBaseFormType = "Syncfusion.Windows.Forms.MetroForm";
            this.mainFrameBarManager1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainFrameBarManager1.Form = this;
            this.mainFrameBarManager1.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.barItem24,
            this.barItem25,
            this.VisualStylesParentBarItem,
            this.Office2007ParentBarItem,
            this.Office2016ParentBarItem,
            this.debugWindowsParentBarItem,
            this.barItem26,
            this.barItem87,
            this.barItem93,
            this.barItem43,
            this.barItem78,
            this.fileParentBarItem,
            this.barItem77,
            this.barItem44,
            this.barItem79,
            this.parentBarItem1,
            this.barItem80,
            this.barItem45,
            this.barItem81,
            this.parentBarItem2,
            this.barItem82,
            this.barItem46,
            this.debugParentBarItem,
            this.parentBarItem3,
            this.comboBoxBarItem1,
            this.barItem47,
            this.barItem1,
            this.barItem48,
            this.barItem2,
            this.barItem49,
            this.barItem3,
            this.barItem50,
            this.barItem4,
            this.barItem51,
            this.barItem5,
            this.barItem52,
            this.barItem6,
            this.barItem53,
            this.barItem7,
            this.barItem54,
            this.barItem8,
            this.barItem55,
            this.barItem9,
            this.parentBarItem4,
            this.barItem10,
            this.barItem19,
            this.barItem11,
            this.barItem20,
            this.barItem12,
            this.barItem21,
            this.barItem13,
            this.openFileBarItem,
            this.barItem15,
            this.barItem16,
            this.barItem17,
            this.barItem18,
            this.barItem56,
            this.barItem57,
            this.barItem58,
            this.barItem59,
            this.barItem60,
            this.barItem61,
            this.barItem62,
            this.barItem63,
            this.barItem64,
            this.barItem65,
            this.barItem66,
            this.barItem67,
            this.barItem68,
            this.projectParentBarItem,
            this.barItem69,
            this.barItem70,
            this.barItem71,
            this.barItem72,
            this.barItem73,
            this.barItem74,
            this.barItem75,
            this.barItem76,
            this.parentBarItem6,
            this.barItem83,
            this.barItem84,
            this.barItem85,
            this.barItem86,
            this.barItem88,
            this.barItem89,
            this.barItem90,
            this.barItem91,
            this.barItem92,
            this.windowParentBarItem,
            this.parentBarItem10,
            this.recentFileListBarItem,
            this.barItem14,
            this.parentBarItem9,
            this.comboBoxBarItem2,
            this.barItem22,
            this.barItem23,
            this.parentBarItem7,
            this.barItem35,
            this.barItem36,
            this.barItem94,
            this.barItem2016DrakGray,
            this.barItem2016Colorful,
            this.barItem2016White,
            this.barItem2016Black});
            this.mainFrameBarManager1.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(110)))), ((int)(((byte)(218)))));
            this.mainFrameBarManager1.ResetCustomization = false;
            this.mainFrameBarManager1.ShowHighlightRectangle = false;
            this.mainFrameBarManager1.Style = Syncfusion.Windows.Forms.VisualStyle.Default;
            this.mainFrameBarManager1.UpdateUIMFCStyle = true;
            // 
            // mainMenuBar
            // 
            this.mainMenuBar.BarName = "MainMenu";
            this.mainMenuBar.BarStyle = ((Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle)(((((Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.AllowQuickCustomizing | Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.IsMainMenu) 
            | Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.RotateWhenVertical) 
            | Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.Visible) 
            | Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.UseWholeRow)));
            this.mainMenuBar.Caption = "MainMenu";
            this.mainMenuBar.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.fileParentBarItem,
            this.parentBarItem4,
            this.projectParentBarItem,
            this.parentBarItem6,
            this.debugParentBarItem,
            this.parentBarItem7,
            this.windowParentBarItem,
            this.parentBarItem9,
            this.VisualStylesParentBarItem});
            this.mainMenuBar.Manager = this.mainFrameBarManager1;
            // 
            // fileParentBarItem
            // 
            this.fileParentBarItem.BarName = "fileParentBarItem";
            this.fileParentBarItem.CategoryIndex = 0;
            this.fileParentBarItem.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileParentBarItem.ID = "&File";
            this.fileParentBarItem.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.parentBarItem1,
            this.parentBarItem2,
            this.parentBarItem3,
            this.barItem1,
            this.barItem2,
            this.barItem35,
            this.barItem36,
            this.barItem3,
            this.barItem4,
            this.barItem5,
            this.barItem6,
            this.barItem7,
            this.parentBarItem10,
            this.barItem8});
            this.fileParentBarItem.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(110)))), ((int)(((byte)(218)))));
            this.fileParentBarItem.OverlapCheckBoxImageBounds = true;
            this.fileParentBarItem.SeparatorIndices.AddRange(new int[] {
            3,
            5,
            7,
            8,
            10,
            11});
            this.fileParentBarItem.ShowToolTipInPopUp = false;
            this.fileParentBarItem.SizeToFit = true;
            this.fileParentBarItem.Style = Syncfusion.Windows.Forms.VisualStyle.Default;
            this.fileParentBarItem.Text = "&FILE";
            // 
            // parentBarItem1
            // 
            this.parentBarItem1.BarName = "parentBarItem1";
            this.parentBarItem1.CategoryIndex = 0;
            this.parentBarItem1.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parentBarItem1.ID = "New";
            this.parentBarItem1.ImageIndex = 96;
            this.parentBarItem1.ImageList = this.imageList1;
            this.parentBarItem1.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.barItem9,
            this.barItem10,
            this.barItem11});
            this.parentBarItem1.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(110)))), ((int)(((byte)(218)))));
            this.parentBarItem1.OverlapCheckBoxImageBounds = true;
            this.parentBarItem1.ShowToolTipInPopUp = false;
            this.parentBarItem1.SizeToFit = true;
            this.parentBarItem1.Style = Syncfusion.Windows.Forms.VisualStyle.Default;
            this.parentBarItem1.Text = "&New";
            // 
            // barItem9
            // 
            this.barItem9.BarName = "barItem9";
            this.barItem9.CategoryIndex = 1;
            this.barItem9.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem9.ID = "Project";
            this.barItem9.ImageIndex = 61;
            this.barItem9.ImageList = this.dockingImageList;
            this.barItem9.Shortcut = System.Windows.Forms.Shortcut.CtrlShiftN;
            this.barItem9.ShowToolTipInPopUp = false;
            this.barItem9.SizeToFit = true;
            this.barItem9.Text = "Project";
            // 
            // dockingImageList
            // 
            this.dockingImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("dockingImageList.ImageStream")));
            this.dockingImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.dockingImageList.Images.SetKeyName(0, "");
            this.dockingImageList.Images.SetKeyName(1, "");
            this.dockingImageList.Images.SetKeyName(2, "");
            this.dockingImageList.Images.SetKeyName(3, "");
            this.dockingImageList.Images.SetKeyName(4, "");
            this.dockingImageList.Images.SetKeyName(5, "");
            this.dockingImageList.Images.SetKeyName(6, "Refresh.png");
            this.dockingImageList.Images.SetKeyName(7, "");
            this.dockingImageList.Images.SetKeyName(8, "");
            this.dockingImageList.Images.SetKeyName(9, "");
            this.dockingImageList.Images.SetKeyName(10, "");
            this.dockingImageList.Images.SetKeyName(11, "");
            this.dockingImageList.Images.SetKeyName(12, "");
            this.dockingImageList.Images.SetKeyName(13, "");
            this.dockingImageList.Images.SetKeyName(14, "");
            this.dockingImageList.Images.SetKeyName(15, "");
            this.dockingImageList.Images.SetKeyName(16, "");
            this.dockingImageList.Images.SetKeyName(17, "");
            this.dockingImageList.Images.SetKeyName(18, "");
            this.dockingImageList.Images.SetKeyName(19, "");
            this.dockingImageList.Images.SetKeyName(20, "");
            this.dockingImageList.Images.SetKeyName(21, "");
            this.dockingImageList.Images.SetKeyName(22, "");
            this.dockingImageList.Images.SetKeyName(23, "");
            this.dockingImageList.Images.SetKeyName(24, "");
            this.dockingImageList.Images.SetKeyName(25, "");
            this.dockingImageList.Images.SetKeyName(26, "");
            this.dockingImageList.Images.SetKeyName(27, "");
            this.dockingImageList.Images.SetKeyName(28, "Winamp.png");
            this.dockingImageList.Images.SetKeyName(29, "");
            this.dockingImageList.Images.SetKeyName(30, "");
            this.dockingImageList.Images.SetKeyName(31, "");
            this.dockingImageList.Images.SetKeyName(32, "");
            this.dockingImageList.Images.SetKeyName(33, "");
            this.dockingImageList.Images.SetKeyName(34, "");
            this.dockingImageList.Images.SetKeyName(35, "");
            this.dockingImageList.Images.SetKeyName(36, "");
            this.dockingImageList.Images.SetKeyName(37, "");
            this.dockingImageList.Images.SetKeyName(38, "");
            this.dockingImageList.Images.SetKeyName(39, "");
            this.dockingImageList.Images.SetKeyName(40, "");
            this.dockingImageList.Images.SetKeyName(41, "");
            this.dockingImageList.Images.SetKeyName(42, "");
            this.dockingImageList.Images.SetKeyName(43, "");
            this.dockingImageList.Images.SetKeyName(44, "");
            this.dockingImageList.Images.SetKeyName(45, "");
            this.dockingImageList.Images.SetKeyName(46, "");
            this.dockingImageList.Images.SetKeyName(47, "");
            this.dockingImageList.Images.SetKeyName(48, "");
            this.dockingImageList.Images.SetKeyName(49, "");
            this.dockingImageList.Images.SetKeyName(50, "");
            this.dockingImageList.Images.SetKeyName(51, "");
            this.dockingImageList.Images.SetKeyName(52, "");
            this.dockingImageList.Images.SetKeyName(53, "");
            this.dockingImageList.Images.SetKeyName(54, "");
            this.dockingImageList.Images.SetKeyName(55, "");
            this.dockingImageList.Images.SetKeyName(56, "");
            this.dockingImageList.Images.SetKeyName(57, "");
            this.dockingImageList.Images.SetKeyName(58, "");
            this.dockingImageList.Images.SetKeyName(59, "");
            this.dockingImageList.Images.SetKeyName(60, "");
            this.dockingImageList.Images.SetKeyName(61, "");
            this.dockingImageList.Images.SetKeyName(62, "");
            this.dockingImageList.Images.SetKeyName(63, "");
            this.dockingImageList.Images.SetKeyName(64, "");
            this.dockingImageList.Images.SetKeyName(65, "");
            this.dockingImageList.Images.SetKeyName(66, "");
            this.dockingImageList.Images.SetKeyName(67, "");
            this.dockingImageList.Images.SetKeyName(68, "");
            this.dockingImageList.Images.SetKeyName(69, "");
            this.dockingImageList.Images.SetKeyName(70, "");
            this.dockingImageList.Images.SetKeyName(71, "");
            this.dockingImageList.Images.SetKeyName(72, "");
            this.dockingImageList.Images.SetKeyName(73, "");
            this.dockingImageList.Images.SetKeyName(74, "");
            this.dockingImageList.Images.SetKeyName(75, "");
            this.dockingImageList.Images.SetKeyName(76, "");
            this.dockingImageList.Images.SetKeyName(77, "");
            this.dockingImageList.Images.SetKeyName(78, "");
            // 
            // barItem10
            // 
            this.barItem10.BarName = "barItem10";
            this.barItem10.CategoryIndex = 1;
            this.barItem10.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem10.ID = "Website";
            this.barItem10.ShowToolTipInPopUp = false;
            this.barItem10.SizeToFit = true;
            this.barItem10.Text = "Website";
            // 
            // barItem11
            // 
            this.barItem11.BarName = "barItem11";
            this.barItem11.CategoryIndex = 1;
            this.barItem11.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem11.ID = "File_New";
            this.barItem11.ImageIndex = 63;
            this.barItem11.ImageList = this.dockingImageList;
            this.barItem11.Shortcut = System.Windows.Forms.Shortcut.CtrlN;
            this.barItem11.ShowToolTipInPopUp = false;
            this.barItem11.SizeToFit = true;
            this.barItem11.Text = "File";
            this.barItem11.Click += new System.EventHandler(this.OnBarItemClick);
            // 
            // parentBarItem2
            // 
            this.parentBarItem2.BarName = "parentBarItem2";
            this.parentBarItem2.CategoryIndex = 0;
            this.parentBarItem2.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parentBarItem2.ID = "Open";
            this.parentBarItem2.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.barItem12,
            this.barItem13,
            this.openFileBarItem});
            this.parentBarItem2.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(110)))), ((int)(((byte)(218)))));
            this.parentBarItem2.OverlapCheckBoxImageBounds = true;
            this.parentBarItem2.ShowToolTipInPopUp = false;
            this.parentBarItem2.SizeToFit = true;
            this.parentBarItem2.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007;
            this.parentBarItem2.Text = "&Open";
            // 
            // barItem12
            // 
            this.barItem12.BarName = "barItem12";
            this.barItem12.CategoryIndex = 2;
            this.barItem12.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem12.ID = "Project/Solution";
            this.barItem12.ImageIndex = 61;
            this.barItem12.ImageList = this.dockingImageList;
            this.barItem12.Shortcut = System.Windows.Forms.Shortcut.CtrlShiftO;
            this.barItem12.ShowToolTipInPopUp = false;
            this.barItem12.SizeToFit = true;
            this.barItem12.Text = "Project/Solution";
            // 
            // barItem13
            // 
            this.barItem13.BarName = "barItem13";
            this.barItem13.CategoryIndex = 2;
            this.barItem13.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem13.ID = "Website_1";
            this.barItem13.ShowToolTipInPopUp = false;
            this.barItem13.SizeToFit = true;
            this.barItem13.Text = "Website";
            // 
            // openFileBarItem
            // 
            this.openFileBarItem.BarName = "openFileBarItem";
            this.openFileBarItem.CategoryIndex = 2;
            this.openFileBarItem.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openFileBarItem.ID = "File_Open";
            this.openFileBarItem.ImageIndex = 97;
            this.openFileBarItem.ImageList = this.imageList1;
            this.openFileBarItem.Shortcut = System.Windows.Forms.Shortcut.CtrlO;
            this.openFileBarItem.ShowToolTipInPopUp = false;
            this.openFileBarItem.SizeToFit = true;
            this.openFileBarItem.Text = "File";
            this.openFileBarItem.Click += new System.EventHandler(this.OnBarItemClick);
            // 
            // parentBarItem3
            // 
            this.parentBarItem3.BarName = "parentBarItem3";
            this.parentBarItem3.CategoryIndex = 0;
            this.parentBarItem3.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parentBarItem3.ID = "Add";
            this.parentBarItem3.ImageIndex = 56;
            this.parentBarItem3.ImageList = this.imageList1;
            this.parentBarItem3.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.barItem15,
            this.barItem16,
            this.barItem17,
            this.barItem18});
            this.parentBarItem3.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(110)))), ((int)(((byte)(218)))));
            this.parentBarItem3.OverlapCheckBoxImageBounds = true;
            this.parentBarItem3.ShowToolTipInPopUp = false;
            this.parentBarItem3.SizeToFit = true;
            this.parentBarItem3.Style = Syncfusion.Windows.Forms.VisualStyle.Default;
            this.parentBarItem3.Text = "&Add";
            // 
            // barItem15
            // 
            this.barItem15.BarName = "barItem15";
            this.barItem15.CategoryIndex = 3;
            this.barItem15.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem15.ID = "New Project";
            this.barItem15.ShowToolTipInPopUp = false;
            this.barItem15.SizeToFit = true;
            this.barItem15.Text = "New Project";
            // 
            // barItem16
            // 
            this.barItem16.BarName = "barItem16";
            this.barItem16.CategoryIndex = 3;
            this.barItem16.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem16.ID = "New Website";
            this.barItem16.ShowToolTipInPopUp = false;
            this.barItem16.SizeToFit = true;
            this.barItem16.Text = "New Website";
            // 
            // barItem17
            // 
            this.barItem17.BarName = "barItem17";
            this.barItem17.CategoryIndex = 3;
            this.barItem17.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem17.ID = "Existing Project";
            this.barItem17.ShowToolTipInPopUp = false;
            this.barItem17.SizeToFit = true;
            this.barItem17.Text = "Existing Project";
            // 
            // barItem18
            // 
            this.barItem18.BarName = "barItem18";
            this.barItem18.CategoryIndex = 3;
            this.barItem18.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem18.ID = "Existing Website";
            this.barItem18.ShowToolTipInPopUp = false;
            this.barItem18.SizeToFit = true;
            this.barItem18.Text = "Existing Website";
            // 
            // barItem1
            // 
            this.barItem1.BarName = "barItem1";
            this.barItem1.CategoryIndex = 0;
            this.barItem1.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem1.ID = "Close";
            this.barItem1.ShowToolTipInPopUp = false;
            this.barItem1.SizeToFit = true;
            this.barItem1.Text = "&Close";
            this.barItem1.Click += new System.EventHandler(this.OnBarItemClick);
            // 
            // barItem2
            // 
            this.barItem2.BarName = "barItem2";
            this.barItem2.CategoryIndex = 0;
            this.barItem2.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem2.ID = "Close Solution";
            this.barItem2.ShowToolTipInPopUp = false;
            this.barItem2.SizeToFit = true;
            this.barItem2.Text = "C&lose Solution";
            // 
            // barItem35
            // 
            this.barItem35.BarName = "barItem35";
            this.barItem35.CategoryIndex = 5;
            this.barItem35.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem35.ID = "Previous Bookmark";
            this.barItem35.ImageIndex = 95;
            this.barItem35.ImageList = this.imageList1;
            this.barItem35.ShowToolTipInPopUp = false;
            this.barItem35.SizeToFit = true;
            this.barItem35.Text = "Previous Bookmark";
            // 
            // barItem36
            // 
            this.barItem36.BarName = "barItem36";
            this.barItem36.CategoryIndex = 5;
            this.barItem36.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem36.ID = "Next Bookmark";
            this.barItem36.ImageIndex = 94;
            this.barItem36.ImageList = this.imageList1;
            this.barItem36.ShowToolTipInPopUp = false;
            this.barItem36.SizeToFit = true;
            this.barItem36.Text = "Next Bookmark";
            // 
            // barItem3
            // 
            this.barItem3.BarName = "barItem3";
            this.barItem3.CategoryIndex = 0;
            this.barItem3.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem3.ID = "Save";
            this.barItem3.ImageIndex = 98;
            this.barItem3.ImageList = this.imageList1;
            this.barItem3.ShowToolTipInPopUp = false;
            this.barItem3.SizeToFit = true;
            this.barItem3.Text = "&Save";
            // 
            // barItem4
            // 
            this.barItem4.BarName = "barItem4";
            this.barItem4.CategoryIndex = 0;
            this.barItem4.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem4.ID = "Save All";
            this.barItem4.ImageIndex = 99;
            this.barItem4.ImageList = this.imageList1;
            this.barItem4.Shortcut = System.Windows.Forms.Shortcut.CtrlShiftS;
            this.barItem4.ShowToolTipInPopUp = false;
            this.barItem4.SizeToFit = true;
            this.barItem4.Text = "Save &All";
            // 
            // barItem5
            // 
            this.barItem5.BarName = "barItem5";
            this.barItem5.CategoryIndex = 0;
            this.barItem5.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem5.ID = "Export Template";
            this.barItem5.ShowToolTipInPopUp = false;
            this.barItem5.SizeToFit = true;
            this.barItem5.Text = "&Export Template";
            // 
            // barItem6
            // 
            this.barItem6.BarName = "barItem6";
            this.barItem6.CategoryIndex = 0;
            this.barItem6.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem6.ID = "Page Setup";
            this.barItem6.ImageIndex = 38;
            this.barItem6.ImageList = this.imageList1;
            this.barItem6.ShowToolTipInPopUp = false;
            this.barItem6.SizeToFit = true;
            this.barItem6.Text = "Page &Setup";
            // 
            // barItem7
            // 
            this.barItem7.BarName = "barItem7";
            this.barItem7.CategoryIndex = 0;
            this.barItem7.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem7.ID = "Print";
            this.barItem7.ImageIndex = 39;
            this.barItem7.ImageList = this.imageList1;
            this.barItem7.Shortcut = System.Windows.Forms.Shortcut.CtrlP;
            this.barItem7.ShowToolTipInPopUp = false;
            this.barItem7.SizeToFit = true;
            this.barItem7.Text = "P&rint";
            // 
            // parentBarItem10
            // 
            this.parentBarItem10.BarName = "parentBarItem10";
            this.parentBarItem10.CategoryIndex = 0;
            this.parentBarItem10.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parentBarItem10.ID = "Recent Files";
            this.parentBarItem10.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.recentFileListBarItem});
            this.parentBarItem10.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(110)))), ((int)(((byte)(218)))));
            this.parentBarItem10.OverlapCheckBoxImageBounds = true;
            this.parentBarItem10.ShowToolTipInPopUp = false;
            this.parentBarItem10.SizeToFit = true;
            this.parentBarItem10.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007;
            this.parentBarItem10.Text = "Recent Files";
            // 
            // recentFileListBarItem
            // 
            this.recentFileListBarItem.BarName = "recentFileListBarItem";
            this.recentFileListBarItem.CategoryIndex = 0;
            this.recentFileListBarItem.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recentFileListBarItem.ID = "RecentFileList";
            this.recentFileListBarItem.ShowToolTipInPopUp = false;
            this.recentFileListBarItem.SizeToFit = true;
            this.recentFileListBarItem.Text = "RecentFileList";
            this.recentFileListBarItem.Click += new System.EventHandler(this.OnBarItemClick);
            // 
            // barItem8
            // 
            this.barItem8.BarName = "barItem8";
            this.barItem8.CategoryIndex = 0;
            this.barItem8.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem8.ID = "Exit";
            this.barItem8.Shortcut = System.Windows.Forms.Shortcut.CtrlX;
            this.barItem8.ShowToolTipInPopUp = false;
            this.barItem8.SizeToFit = true;
            this.barItem8.Text = "&Exit";
            this.barItem8.Click += new System.EventHandler(this.OnBarItemClick);
            // 
            // parentBarItem4
            // 
            this.parentBarItem4.BarName = "parentBarItem4";
            this.parentBarItem4.CategoryIndex = 4;
            this.parentBarItem4.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parentBarItem4.ID = "View";
            this.parentBarItem4.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.barItem43,
            this.barItem44,
            this.barItem45,
            this.barItem46,
            this.barItem21,
            this.barItem47,
            this.barItem48,
            this.barItem49,
            this.barItem50,
            this.barItem51,
            this.barItem52,
            this.barItem20,
            this.barItem53,
            this.barItem54,
            this.barItem19,
            this.barItem55});
            this.parentBarItem4.MergeOrder = 2;
            this.parentBarItem4.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(110)))), ((int)(((byte)(218)))));
            this.parentBarItem4.OverlapCheckBoxImageBounds = true;
            this.parentBarItem4.SeparatorIndices.AddRange(new int[] {
            4,
            8,
            15});
            this.parentBarItem4.ShowToolTipInPopUp = false;
            this.parentBarItem4.SizeToFit = true;
            this.parentBarItem4.Style = Syncfusion.Windows.Forms.VisualStyle.Default;
            this.parentBarItem4.Text = "&VIEW";
            // 
            // barItem43
            // 
            this.barItem43.BarName = "barItem43";
            this.barItem43.CategoryIndex = 4;
            this.barItem43.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem43.ID = "Code";
            this.barItem43.ShowToolTipInPopUp = false;
            this.barItem43.SizeToFit = true;
            this.barItem43.Text = "Code";
            // 
            // barItem44
            // 
            this.barItem44.BarName = "barItem44";
            this.barItem44.CategoryIndex = 4;
            this.barItem44.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem44.ID = "Designer";
            this.barItem44.ShowToolTipInPopUp = false;
            this.barItem44.SizeToFit = true;
            this.barItem44.Text = "Designer";
            // 
            // barItem45
            // 
            this.barItem45.BarName = "barItem45";
            this.barItem45.CategoryIndex = 4;
            this.barItem45.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem45.ID = "Open_1";
            this.barItem45.ShowToolTipInPopUp = false;
            this.barItem45.SizeToFit = true;
            this.barItem45.Text = "Open";
            // 
            // barItem46
            // 
            this.barItem46.BarName = "barItem46";
            this.barItem46.CategoryIndex = 4;
            this.barItem46.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem46.ID = "Open With";
            this.barItem46.ShowToolTipInPopUp = false;
            this.barItem46.SizeToFit = true;
            this.barItem46.Text = "Open With";
            // 
            // barItem21
            // 
            this.barItem21.BarName = "barItem21";
            this.barItem21.CategoryIndex = 4;
            this.barItem21.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem21.ID = "Bookmark Window";
            this.barItem21.ImageIndex = 60;
            this.barItem21.ImageList = this.imageList1;
            this.barItem21.ShowToolTipInPopUp = false;
            this.barItem21.SizeToFit = true;
            this.barItem21.Text = "Bookmark Window";
            // 
            // barItem47
            // 
            this.barItem47.BarName = "barItem47";
            this.barItem47.CategoryIndex = 4;
            this.barItem47.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem47.ID = "Server Explorer";
            this.barItem47.ImageIndex = 58;
            this.barItem47.ImageList = this.imageList1;
            this.barItem47.ShowToolTipInPopUp = false;
            this.barItem47.SizeToFit = true;
            this.barItem47.Text = "Server Explorer";
            // 
            // barItem48
            // 
            this.barItem48.BarName = "barItem48";
            this.barItem48.CategoryIndex = 4;
            this.barItem48.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem48.ID = "SolutionExplorer";
            this.barItem48.ImageIndex = 108;
            this.barItem48.ImageList = this.imageList1;
            this.barItem48.ShowToolTipInPopUp = false;
            this.barItem48.SizeToFit = true;
            this.barItem48.Text = "Undo";
            this.barItem48.Click += new System.EventHandler(this.OnBarItemClick);
            // 
            // barItem49
            // 
            this.barItem49.BarName = "barItem49";
            this.barItem49.CategoryIndex = 4;
            this.barItem49.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem49.ID = "ClassView";
            this.barItem49.ImageIndex = 112;
            this.barItem49.ImageList = this.imageList1;
            this.barItem49.ShowToolTipInPopUp = false;
            this.barItem49.SizeToFit = true;
            this.barItem49.Text = "Redo";
            this.barItem49.Click += new System.EventHandler(this.OnBarItemClick);
            // 
            // barItem50
            // 
            this.barItem50.BarName = "barItem50";
            this.barItem50.CategoryIndex = 4;
            this.barItem50.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem50.ID = "ObjectBrowser";
            this.barItem50.ImageIndex = 61;
            this.barItem50.ImageList = this.imageList1;
            this.barItem50.ShowToolTipInPopUp = false;
            this.barItem50.SizeToFit = true;
            this.barItem50.Text = "Object Browser";
            this.barItem50.Click += new System.EventHandler(this.OnBarItemClick);
            // 
            // barItem51
            // 
            this.barItem51.BarName = "barItem51";
            this.barItem51.CategoryIndex = 4;
            this.barItem51.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem51.ID = "ErrorList";
            this.barItem51.ImageIndex = 0;
            this.barItem51.ImageList = this.imageList2;
            this.barItem51.ShowToolTipInPopUp = false;
            this.barItem51.SizeToFit = true;
            this.barItem51.Text = "Error List";
            this.barItem51.Click += new System.EventHandler(this.OnBarItemClick);
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "Wrong.png");
            this.imageList2.Images.SetKeyName(1, "");
            this.imageList2.Images.SetKeyName(2, "");
            // 
            // barItem52
            // 
            this.barItem52.BarName = "barItem52";
            this.barItem52.CategoryIndex = 4;
            this.barItem52.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem52.ID = "OutputWindow";
            this.barItem52.ImageIndex = 33;
            this.barItem52.ImageList = this.dockingImageList;
            this.barItem52.ShowToolTipInPopUp = false;
            this.barItem52.SizeToFit = true;
            this.barItem52.Text = "Output Window";
            this.barItem52.Click += new System.EventHandler(this.OnBarItemClick);
            // 
            // barItem20
            // 
            this.barItem20.BarName = "barItem20";
            this.barItem20.CategoryIndex = 4;
            this.barItem20.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem20.ID = "FindResults";
            this.barItem20.ImageIndex = 17;
            this.barItem20.ImageList = this.imageList1;
            this.barItem20.ShowToolTipInPopUp = false;
            this.barItem20.SizeToFit = true;
            this.barItem20.Text = "Find Results Window";
            this.barItem20.Click += new System.EventHandler(this.OnBarItemClick);
            // 
            // barItem53
            // 
            this.barItem53.BarName = "barItem53";
            this.barItem53.CategoryIndex = 4;
            this.barItem53.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem53.ID = "PropertiesWindow";
            this.barItem53.ImageIndex = 27;
            this.barItem53.ImageList = this.imageList1;
            this.barItem53.ShowToolTipInPopUp = false;
            this.barItem53.SizeToFit = true;
            this.barItem53.Text = "Properties Window";
            this.barItem53.Click += new System.EventHandler(this.OnBarItemClick);
            // 
            // barItem54
            // 
            this.barItem54.BarName = "barItem54";
            this.barItem54.CategoryIndex = 4;
            this.barItem54.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem54.ID = "ToolBox";
            this.barItem54.ImageIndex = 33;
            this.barItem54.ImageList = this.imageList1;
            this.barItem54.ShowToolTipInPopUp = false;
            this.barItem54.SizeToFit = true;
            this.barItem54.Text = "ToolBox";
            this.barItem54.Click += new System.EventHandler(this.OnBarItemClick);
            // 
            // barItem19
            // 
            this.barItem19.BarName = "barItem19";
            this.barItem19.CategoryIndex = 4;
            this.barItem19.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem19.ID = "WatchList";
            this.barItem19.ImageIndex = 47;
            this.barItem19.ImageList = this.imageList1;
            this.barItem19.ShowToolTipInPopUp = false;
            this.barItem19.SizeToFit = true;
            this.barItem19.Text = "Add Watch List";
            this.barItem19.Click += new System.EventHandler(this.OnBarItemClick);
            // 
            // barItem55
            // 
            this.barItem55.BarName = "barItem55";
            this.barItem55.CategoryIndex = 4;
            this.barItem55.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem55.ID = "FullScreen";
            this.barItem55.ImageIndex = 49;
            this.barItem55.ImageList = this.imageList1;
            this.barItem55.ShowToolTipInPopUp = false;
            this.barItem55.SizeToFit = true;
            this.barItem55.Text = "FullScreen";
            // 
            // projectParentBarItem
            // 
            this.projectParentBarItem.BarName = "projectParentBarItem";
            this.projectParentBarItem.CategoryIndex = 5;
            this.projectParentBarItem.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.projectParentBarItem.ID = "Project_1";
            this.projectParentBarItem.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.barItem56,
            this.barItem57,
            this.barItem58,
            this.barItem59,
            this.barItem60,
            this.barItem61,
            this.barItem62,
            this.barItem63,
            this.barItem64,
            this.barItem65,
            this.barItem66,
            this.barItem67,
            this.barItem68});
            this.projectParentBarItem.MergeOrder = 4;
            this.projectParentBarItem.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(110)))), ((int)(((byte)(218)))));
            this.projectParentBarItem.OverlapCheckBoxImageBounds = true;
            this.projectParentBarItem.SeparatorIndices.AddRange(new int[] {
            5,
            8,
            11});
            this.projectParentBarItem.ShowToolTipInPopUp = false;
            this.projectParentBarItem.SizeToFit = true;
            this.projectParentBarItem.Style = Syncfusion.Windows.Forms.VisualStyle.Default;
            this.projectParentBarItem.Text = "&PROJECT";
            // 
            // barItem56
            // 
            this.barItem56.BarName = "barItem56";
            this.barItem56.CategoryIndex = 5;
            this.barItem56.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem56.ID = "Add Windows Form";
            this.barItem56.ImageIndex = 69;
            this.barItem56.ImageList = this.imageList1;
            this.barItem56.ShowToolTipInPopUp = false;
            this.barItem56.SizeToFit = true;
            this.barItem56.Text = "Add Windows Form";
            // 
            // barItem57
            // 
            this.barItem57.BarName = "barItem57";
            this.barItem57.CategoryIndex = 5;
            this.barItem57.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem57.ID = "Add UserControl";
            this.barItem57.ImageIndex = 68;
            this.barItem57.ImageList = this.imageList1;
            this.barItem57.ShowToolTipInPopUp = false;
            this.barItem57.SizeToFit = true;
            this.barItem57.Text = "Add UserControl";
            // 
            // barItem58
            // 
            this.barItem58.BarName = "barItem58";
            this.barItem58.CategoryIndex = 5;
            this.barItem58.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem58.ID = "Add Componenet";
            this.barItem58.ImageIndex = 65;
            this.barItem58.ImageList = this.imageList1;
            this.barItem58.ShowToolTipInPopUp = false;
            this.barItem58.SizeToFit = true;
            this.barItem58.Text = "Add Component";
            // 
            // barItem59
            // 
            this.barItem59.BarName = "barItem59";
            this.barItem59.CategoryIndex = 5;
            this.barItem59.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem59.ID = "Add Class";
            this.barItem59.ImageIndex = 64;
            this.barItem59.ImageList = this.imageList1;
            this.barItem59.ShowToolTipInPopUp = false;
            this.barItem59.SizeToFit = true;
            this.barItem59.Text = "Add Class";
            // 
            // barItem60
            // 
            this.barItem60.BarName = "barItem60";
            this.barItem60.CategoryIndex = 5;
            this.barItem60.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem60.ID = "Add New Item";
            this.barItem60.ImageIndex = 67;
            this.barItem60.ImageList = this.imageList1;
            this.barItem60.ShowToolTipInPopUp = false;
            this.barItem60.SizeToFit = true;
            this.barItem60.Text = "Add New Item";
            // 
            // barItem61
            // 
            this.barItem61.BarName = "barItem61";
            this.barItem61.CategoryIndex = 5;
            this.barItem61.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem61.ID = "Add Existing Item";
            this.barItem61.ImageIndex = 66;
            this.barItem61.ImageList = this.imageList1;
            this.barItem61.ShowToolTipInPopUp = false;
            this.barItem61.SizeToFit = true;
            this.barItem61.Text = "Add Existing Item";
            // 
            // barItem62
            // 
            this.barItem62.BarName = "barItem62";
            this.barItem62.CategoryIndex = 5;
            this.barItem62.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem62.ID = "Exclude from Project";
            this.barItem62.ShowToolTipInPopUp = false;
            this.barItem62.SizeToFit = true;
            this.barItem62.Text = "Exclude from Project";
            // 
            // barItem63
            // 
            this.barItem63.BarName = "barItem63";
            this.barItem63.CategoryIndex = 5;
            this.barItem63.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem63.ID = "Show All Files";
            this.barItem63.ImageIndex = 70;
            this.barItem63.ImageList = this.imageList1;
            this.barItem63.ShowToolTipInPopUp = false;
            this.barItem63.SizeToFit = true;
            this.barItem63.Text = "Show All Files";
            // 
            // barItem64
            // 
            this.barItem64.BarName = "barItem64";
            this.barItem64.CategoryIndex = 5;
            this.barItem64.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem64.ID = "Add Reference";
            this.barItem64.ShowToolTipInPopUp = false;
            this.barItem64.SizeToFit = true;
            this.barItem64.Text = "Add Reference";
            // 
            // barItem65
            // 
            this.barItem65.BarName = "barItem65";
            this.barItem65.CategoryIndex = 5;
            this.barItem65.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem65.ID = "Add WebReference";
            this.barItem65.ShowToolTipInPopUp = false;
            this.barItem65.SizeToFit = true;
            this.barItem65.Text = "Add WebReference";
            // 
            // barItem66
            // 
            this.barItem66.BarName = "barItem66";
            this.barItem66.CategoryIndex = 5;
            this.barItem66.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem66.ID = "Set as Startup Project";
            this.barItem66.ShowToolTipInPopUp = false;
            this.barItem66.SizeToFit = true;
            this.barItem66.Text = "Set as Startup Project";
            // 
            // barItem67
            // 
            this.barItem67.BarName = "barItem67";
            this.barItem67.CategoryIndex = 5;
            this.barItem67.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem67.ID = "Project Dependencies";
            this.barItem67.ShowToolTipInPopUp = false;
            this.barItem67.SizeToFit = true;
            this.barItem67.Text = "Project Dependencies";
            // 
            // barItem68
            // 
            this.barItem68.BarName = "barItem68";
            this.barItem68.CategoryIndex = 5;
            this.barItem68.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem68.ID = "Project Build Order";
            this.barItem68.ShowToolTipInPopUp = false;
            this.barItem68.SizeToFit = true;
            this.barItem68.Text = "Project Build Order";
            // 
            // parentBarItem6
            // 
            this.parentBarItem6.BarName = "parentBarItem6";
            this.parentBarItem6.CategoryIndex = 6;
            this.parentBarItem6.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parentBarItem6.ID = "&Build";
            this.parentBarItem6.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.barItem69,
            this.barItem70,
            this.barItem71,
            this.barItem72,
            this.barItem73,
            this.barItem74,
            this.barItem75,
            this.barItem76});
            this.parentBarItem6.MergeOrder = 5;
            this.parentBarItem6.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(110)))), ((int)(((byte)(218)))));
            this.parentBarItem6.OverlapCheckBoxImageBounds = true;
            this.parentBarItem6.SeparatorIndices.AddRange(new int[] {
            3,
            6});
            this.parentBarItem6.ShowToolTipInPopUp = false;
            this.parentBarItem6.SizeToFit = true;
            this.parentBarItem6.Style = Syncfusion.Windows.Forms.VisualStyle.Default;
            this.parentBarItem6.Text = "&BUILD";
            // 
            // barItem69
            // 
            this.barItem69.BarName = "barItem69";
            this.barItem69.CategoryIndex = 6;
            this.barItem69.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem69.ID = "Build Solution";
            this.barItem69.ImageIndex = 72;
            this.barItem69.ImageList = this.imageList1;
            this.barItem69.ShowToolTipInPopUp = false;
            this.barItem69.SizeToFit = true;
            this.barItem69.Text = "Build Solution";
            // 
            // barItem70
            // 
            this.barItem70.BarName = "barItem70";
            this.barItem70.CategoryIndex = 6;
            this.barItem70.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem70.ID = "Rebuild Solution";
            this.barItem70.ShowToolTipInPopUp = false;
            this.barItem70.SizeToFit = true;
            this.barItem70.Text = "Rebuild Solution";
            // 
            // barItem71
            // 
            this.barItem71.BarName = "barItem71";
            this.barItem71.CategoryIndex = 6;
            this.barItem71.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem71.ID = "Clean Solution";
            this.barItem71.ShowToolTipInPopUp = false;
            this.barItem71.SizeToFit = true;
            this.barItem71.Text = "Clean Solution";
            // 
            // barItem72
            // 
            this.barItem72.BarName = "barItem72";
            this.barItem72.CategoryIndex = 6;
            this.barItem72.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem72.ID = "Build Project";
            this.barItem72.ImageIndex = 73;
            this.barItem72.ImageList = this.imageList1;
            this.barItem72.ShowToolTipInPopUp = false;
            this.barItem72.SizeToFit = true;
            this.barItem72.Text = "Build Project";
            // 
            // barItem73
            // 
            this.barItem73.BarName = "barItem73";
            this.barItem73.CategoryIndex = 6;
            this.barItem73.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem73.ID = "Rebuild Project";
            this.barItem73.ShowToolTipInPopUp = false;
            this.barItem73.SizeToFit = true;
            this.barItem73.Text = "Rebuild Project";
            // 
            // barItem74
            // 
            this.barItem74.BarName = "barItem74";
            this.barItem74.CategoryIndex = 6;
            this.barItem74.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem74.ID = "Clean Project";
            this.barItem74.ShowToolTipInPopUp = false;
            this.barItem74.SizeToFit = true;
            this.barItem74.Text = "Clean Project";
            // 
            // barItem75
            // 
            this.barItem75.BarName = "barItem75";
            this.barItem75.CategoryIndex = 6;
            this.barItem75.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem75.ID = "Batch Build";
            this.barItem75.ShowToolTipInPopUp = false;
            this.barItem75.SizeToFit = true;
            this.barItem75.Text = "Batch Build";
            // 
            // barItem76
            // 
            this.barItem76.BarName = "barItem76";
            this.barItem76.CategoryIndex = 6;
            this.barItem76.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem76.ID = "Configuration Manager";
            this.barItem76.ShowToolTipInPopUp = false;
            this.barItem76.SizeToFit = true;
            this.barItem76.Text = "Configuration Manager";
            // 
            // debugParentBarItem
            // 
            this.debugParentBarItem.BarName = "debugParentBarItem";
            this.debugParentBarItem.CategoryIndex = 7;
            this.debugParentBarItem.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.debugParentBarItem.ID = "Debug";
            this.debugParentBarItem.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.debugWindowsParentBarItem,
            this.barItem77,
            this.barItem78,
            this.barItem79,
            this.barItem80,
            this.barItem81,
            this.barItem82});
            this.debugParentBarItem.MergeOrder = 6;
            this.debugParentBarItem.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(110)))), ((int)(((byte)(218)))));
            this.debugParentBarItem.OverlapCheckBoxImageBounds = true;
            this.debugParentBarItem.SeparatorIndices.AddRange(new int[] {
            1,
            5});
            this.debugParentBarItem.ShowToolTipInPopUp = false;
            this.debugParentBarItem.SizeToFit = true;
            this.debugParentBarItem.Style = Syncfusion.Windows.Forms.VisualStyle.Default;
            this.debugParentBarItem.Text = "&DEBUG";
            // 
            // debugWindowsParentBarItem
            // 
            this.debugWindowsParentBarItem.BarName = "debugWindowsParentBarItem";
            this.debugWindowsParentBarItem.CategoryIndex = 7;
            this.debugWindowsParentBarItem.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.debugWindowsParentBarItem.ID = "Windows";
            this.debugWindowsParentBarItem.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.barItem83,
            this.barItem84,
            this.barItem85});
            this.debugWindowsParentBarItem.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(110)))), ((int)(((byte)(218)))));
            this.debugWindowsParentBarItem.OverlapCheckBoxImageBounds = true;
            this.debugWindowsParentBarItem.ShowToolTipInPopUp = false;
            this.debugWindowsParentBarItem.SizeToFit = true;
            this.debugWindowsParentBarItem.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007;
            this.debugWindowsParentBarItem.Text = "Windows";
            // 
            // barItem83
            // 
            this.barItem83.BarName = "barItem83";
            this.barItem83.CategoryIndex = 8;
            this.barItem83.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem83.ID = "Break Points";
            this.barItem83.ImageIndex = 75;
            this.barItem83.ImageList = this.imageList1;
            this.barItem83.ShowToolTipInPopUp = false;
            this.barItem83.SizeToFit = true;
            this.barItem83.Text = "Break Points";
            // 
            // barItem84
            // 
            this.barItem84.BarName = "barItem84";
            this.barItem84.CategoryIndex = 8;
            this.barItem84.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem84.ID = "Output";
            this.barItem84.ImageIndex = 79;
            this.barItem84.ImageList = this.imageList1;
            this.barItem84.ShowToolTipInPopUp = false;
            this.barItem84.SizeToFit = true;
            this.barItem84.Text = "Output";
            // 
            // barItem85
            // 
            this.barItem85.BarName = "barItem85";
            this.barItem85.CategoryIndex = 8;
            this.barItem85.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem85.ID = "Immediate";
            this.barItem85.ImageIndex = 78;
            this.barItem85.ImageList = this.imageList1;
            this.barItem85.ShowToolTipInPopUp = false;
            this.barItem85.SizeToFit = true;
            this.barItem85.Text = "Immediate";
            // 
            // barItem77
            // 
            this.barItem77.BarName = "barItem77";
            this.barItem77.CategoryIndex = 7;
            this.barItem77.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem77.ID = "Start Debugging";
            this.barItem77.ImageIndex = 113;
            this.barItem77.ImageList = this.imageList1;
            this.barItem77.PaintStyle = Syncfusion.Windows.Forms.Tools.XPMenus.PaintStyle.ImageAndText;
            this.barItem77.ShowToolTipInPopUp = false;
            this.barItem77.SizeToFit = true;
            this.barItem77.Text = "Start";
            // 
            // barItem78
            // 
            this.barItem78.BarName = "barItem78";
            this.barItem78.CategoryIndex = 7;
            this.barItem78.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem78.ID = "Start without Debugging";
            this.barItem78.ImageIndex = 81;
            this.barItem78.ImageList = this.imageList1;
            this.barItem78.ShowToolTipInPopUp = false;
            this.barItem78.SizeToFit = true;
            this.barItem78.Text = "Start without Debugging";
            // 
            // barItem79
            // 
            this.barItem79.BarName = "barItem79";
            this.barItem79.CategoryIndex = 7;
            this.barItem79.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem79.ID = "Attach to Process";
            this.barItem79.ImageIndex = 74;
            this.barItem79.ImageList = this.imageList1;
            this.barItem79.ShowToolTipInPopUp = false;
            this.barItem79.SizeToFit = true;
            this.barItem79.Text = "Attach to Process";
            // 
            // barItem80
            // 
            this.barItem80.BarName = "barItem80";
            this.barItem80.CategoryIndex = 7;
            this.barItem80.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem80.ID = "Exceptions";
            this.barItem80.ShowToolTipInPopUp = false;
            this.barItem80.SizeToFit = true;
            this.barItem80.Text = "Exceptions";
            // 
            // barItem81
            // 
            this.barItem81.BarName = "barItem81";
            this.barItem81.CategoryIndex = 7;
            this.barItem81.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem81.ID = "Step Into";
            this.barItem81.ImageIndex = 82;
            this.barItem81.ImageList = this.imageList1;
            this.barItem81.ShowToolTipInPopUp = false;
            this.barItem81.SizeToFit = true;
            this.barItem81.Text = "Step Into";
            // 
            // barItem82
            // 
            this.barItem82.BarName = "barItem82";
            this.barItem82.CategoryIndex = 7;
            this.barItem82.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem82.ID = "Step Over";
            this.barItem82.ImageIndex = 83;
            this.barItem82.ImageList = this.imageList1;
            this.barItem82.ShowToolTipInPopUp = false;
            this.barItem82.SizeToFit = true;
            this.barItem82.Text = "Step Over";
            // 
            // parentBarItem7
            // 
            this.parentBarItem7.BarName = "parentBarItem7";
            this.parentBarItem7.CategoryIndex = 11;
            this.parentBarItem7.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parentBarItem7.ID = "Data";
            this.parentBarItem7.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.barItem22,
            this.barItem23});
            this.parentBarItem7.MergeOrder = 6;
            this.parentBarItem7.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(110)))), ((int)(((byte)(218)))));
            this.parentBarItem7.OverlapCheckBoxImageBounds = true;
            this.parentBarItem7.ShowToolTipInPopUp = false;
            this.parentBarItem7.SizeToFit = true;
            this.parentBarItem7.Style = Syncfusion.Windows.Forms.VisualStyle.Default;
            this.parentBarItem7.Text = "&DATA";
            // 
            // barItem22
            // 
            this.barItem22.BarName = "barItem22";
            this.barItem22.CategoryIndex = 11;
            this.barItem22.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem22.ID = "Show Data Sources";
            this.barItem22.ImageIndex = 91;
            this.barItem22.ImageList = this.imageList1;
            this.barItem22.ShowToolTipInPopUp = false;
            this.barItem22.SizeToFit = true;
            this.barItem22.Text = "Show Data Sources";
            // 
            // barItem23
            // 
            this.barItem23.BarName = "barItem23";
            this.barItem23.CategoryIndex = 11;
            this.barItem23.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem23.ID = "Add New DataSource";
            this.barItem23.ImageIndex = 89;
            this.barItem23.ImageList = this.imageList1;
            this.barItem23.ShowToolTipInPopUp = false;
            this.barItem23.SizeToFit = true;
            this.barItem23.Text = "Add New DataSource";
            // 
            // windowParentBarItem
            // 
            this.windowParentBarItem.BarName = "windowParentBarItem";
            this.windowParentBarItem.CategoryIndex = 9;
            this.windowParentBarItem.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.windowParentBarItem.ID = "Windows_1";
            this.windowParentBarItem.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.barItem86,
            this.barItem88,
            this.barItem89,
            this.barItem90,
            this.barItem91,
            this.barItem92});
            this.windowParentBarItem.MergeOrder = 8;
            this.windowParentBarItem.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(110)))), ((int)(((byte)(218)))));
            this.windowParentBarItem.OverlapCheckBoxImageBounds = true;
            this.windowParentBarItem.SeparatorIndices.AddRange(new int[] {
            1,
            5});
            this.windowParentBarItem.ShowToolTipInPopUp = false;
            this.windowParentBarItem.SizeToFit = true;
            this.windowParentBarItem.Style = Syncfusion.Windows.Forms.VisualStyle.Default;
            this.windowParentBarItem.Text = "&WINDOWS";
            // 
            // barItem86
            // 
            this.barItem86.BarName = "barItem86";
            this.barItem86.CategoryIndex = 9;
            this.barItem86.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem86.ID = "Cascade";
            this.barItem86.ImageIndex = 50;
            this.barItem86.ImageList = this.imageList1;
            this.barItem86.ShowToolTipInPopUp = false;
            this.barItem86.SizeToFit = true;
            this.barItem86.Text = "Cascade";
            this.barItem86.Click += new System.EventHandler(this.OnBarItemClick);
            // 
            // barItem88
            // 
            this.barItem88.BarName = "barItem88";
            this.barItem88.CategoryIndex = 9;
            this.barItem88.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem88.ID = "NewHorizontalTabGroup";
            this.barItem88.ShowToolTipInPopUp = false;
            this.barItem88.SizeToFit = true;
            this.barItem88.Text = "New Horizontal TabGroup";
            this.barItem88.Click += new System.EventHandler(this.OnBarItemClick);
            // 
            // barItem89
            // 
            this.barItem89.BarName = "barItem89";
            this.barItem89.CategoryIndex = 9;
            this.barItem89.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem89.ID = "NewVerticalTabGroup";
            this.barItem89.ShowToolTipInPopUp = false;
            this.barItem89.SizeToFit = true;
            this.barItem89.Text = "New Vertical TabGroup";
            this.barItem89.Click += new System.EventHandler(this.OnBarItemClick);
            // 
            // barItem90
            // 
            this.barItem90.BarName = "barItem90";
            this.barItem90.CategoryIndex = 9;
            this.barItem90.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem90.ID = "Tile Horizontal";
            this.barItem90.ImageIndex = 53;
            this.barItem90.ImageList = this.imageList1;
            this.barItem90.ShowToolTipInPopUp = false;
            this.barItem90.SizeToFit = true;
            this.barItem90.Text = "Tile Horizontal";
            this.barItem90.Click += new System.EventHandler(this.OnBarItemClick);
            // 
            // barItem91
            // 
            this.barItem91.BarName = "barItem91";
            this.barItem91.CategoryIndex = 9;
            this.barItem91.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem91.ID = "TileVertical";
            this.barItem91.ImageIndex = 88;
            this.barItem91.ImageList = this.imageList1;
            this.barItem91.ShowToolTipInPopUp = false;
            this.barItem91.SizeToFit = true;
            this.barItem91.Text = "Tile Vertical";
            this.barItem91.Click += new System.EventHandler(this.OnBarItemClick);
            // 
            // barItem92
            // 
            this.barItem92.BarName = "barItem92";
            this.barItem92.CategoryIndex = 9;
            this.barItem92.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem92.ID = "CloseAllWindows";
            this.barItem92.ImageIndex = 84;
            this.barItem92.ImageList = this.imageList1;
            this.barItem92.ShowToolTipInPopUp = false;
            this.barItem92.SizeToFit = true;
            this.barItem92.Text = "Close All Windows";
            this.barItem92.Click += new System.EventHandler(this.OnBarItemClick);
            // 
            // parentBarItem9
            // 
            this.parentBarItem9.BarName = "parentBarItem9";
            this.parentBarItem9.CategoryIndex = 10;
            this.parentBarItem9.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parentBarItem9.ID = "Help";
            this.parentBarItem9.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.barItem14});
            this.parentBarItem9.MergeOrder = 9;
            this.parentBarItem9.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(110)))), ((int)(((byte)(218)))));
            this.parentBarItem9.OverlapCheckBoxImageBounds = true;
            this.parentBarItem9.ShowToolTipInPopUp = false;
            this.parentBarItem9.SizeToFit = true;
            this.parentBarItem9.Style = Syncfusion.Windows.Forms.VisualStyle.Default;
            this.parentBarItem9.Text = "&HELP";
            // 
            // barItem14
            // 
            this.barItem14.BarName = "barItem14";
            this.barItem14.CategoryIndex = 10;
            this.barItem14.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem14.ID = "About Syncfusion";
            this.barItem14.ImageIndex = 45;
            this.barItem14.ImageList = this.imageList1;
            this.barItem14.ShowToolTipInPopUp = false;
            this.barItem14.SizeToFit = true;
            this.barItem14.Text = "About Syncfusion";
            this.barItem14.Click += new System.EventHandler(this.barItem14_Click);
            // 
            // VisualStylesParentBarItem
            // 
            this.VisualStylesParentBarItem.BarName = "VisualStylesParentBarItem";
            this.VisualStylesParentBarItem.CategoryIndex = 12;
            this.VisualStylesParentBarItem.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VisualStylesParentBarItem.ID = "Styles";
            this.VisualStylesParentBarItem.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.barItem24,
            this.barItem25,
            this.Office2007ParentBarItem,
            this.Office2016ParentBarItem,
            this.barItem94});
            this.VisualStylesParentBarItem.MergeOrder = 10;
            this.VisualStylesParentBarItem.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(110)))), ((int)(((byte)(218)))));
            this.VisualStylesParentBarItem.OverlapCheckBoxImageBounds = true;
            this.VisualStylesParentBarItem.ShowToolTipInPopUp = false;
            this.VisualStylesParentBarItem.SizeToFit = true;
            this.VisualStylesParentBarItem.Style = Syncfusion.Windows.Forms.VisualStyle.Default;
            this.VisualStylesParentBarItem.Text = "&VISUAL STYLE";
            // 
            // barItem24
            // 
            this.barItem24.BarName = "barItem24";
            this.barItem24.CategoryIndex = 12;
            this.barItem24.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem24.ID = "Default";
            this.barItem24.ShowToolTipInPopUp = false;
            this.barItem24.SizeToFit = true;
            this.barItem24.Text = "Default";
            this.barItem24.Click += new System.EventHandler(this.OnBarItemClick);
            // 
            // barItem25
            // 
            this.barItem25.BarName = "barItem25";
            this.barItem25.CategoryIndex = 12;
            this.barItem25.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem25.ID = "Office2003";
            this.barItem25.ShowToolTipInPopUp = false;
            this.barItem25.SizeToFit = true;
            this.barItem25.Text = "Office 2003";
            this.barItem25.Click += new System.EventHandler(this.OnBarItemClick);
            // 
            // Office2007ParentBarItem
            // 
            this.Office2007ParentBarItem.BarName = "Office2007ParentBarItem";
            this.Office2007ParentBarItem.CategoryIndex = 12;
            this.Office2007ParentBarItem.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Office2007ParentBarItem.ID = "Office2007Theme";
            this.Office2007ParentBarItem.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.barItem26,
            this.barItem87,
            this.barItem93});
            this.Office2007ParentBarItem.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(110)))), ((int)(((byte)(218)))));
            this.Office2007ParentBarItem.OverlapCheckBoxImageBounds = true;
            this.Office2007ParentBarItem.ShowToolTipInPopUp = false;
            this.Office2007ParentBarItem.SizeToFit = true;
            this.Office2007ParentBarItem.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007;
            this.Office2007ParentBarItem.Text = "Office2007Theme";
            // 
            // barItem26
            // 
            this.barItem26.BarName = "barItem26";
            this.barItem26.CategoryIndex = 12;
            this.barItem26.Checked = true;
            this.barItem26.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem26.ID = "Blue";
            this.barItem26.ShowToolTipInPopUp = false;
            this.barItem26.SizeToFit = true;
            this.barItem26.Text = "Blue";
            this.barItem26.Click += new System.EventHandler(this.OnOfficeThemeSelected);
            // 
            // barItem87
            // 
            this.barItem87.BarName = "barItem87";
            this.barItem87.CategoryIndex = 12;
            this.barItem87.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem87.ID = "Black";
            this.barItem87.ShowToolTipInPopUp = false;
            this.barItem87.SizeToFit = true;
            this.barItem87.Text = "Black";
            this.barItem87.Click += new System.EventHandler(this.OnOfficeThemeSelected);
            // 
            // barItem93
            // 
            this.barItem93.BarName = "barItem93";
            this.barItem93.CategoryIndex = 12;
            this.barItem93.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem93.ID = "Silver";
            this.barItem93.ShowToolTipInPopUp = false;
            this.barItem93.SizeToFit = true;
            this.barItem93.Text = "Silver";
            this.barItem93.Click += new System.EventHandler(this.OnOfficeThemeSelected);
            // 
            // Office2016ParentBarItem
            // 
            this.Office2016ParentBarItem.BarName = "Office2016ParentBarItem";
            this.Office2016ParentBarItem.CategoryIndex = 12;
            this.Office2016ParentBarItem.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Office2016ParentBarItem.ID = "Office2016Theme";
            this.Office2016ParentBarItem.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.barItem2016Black,
            this.barItem2016White,
            this.barItem2016Colorful,
            this.barItem2016DrakGray});
            this.Office2016ParentBarItem.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(110)))), ((int)(((byte)(218)))));
            this.Office2016ParentBarItem.ShowToolTipInPopUp = false;
            this.Office2016ParentBarItem.SizeToFit = true;
            this.Office2016ParentBarItem.Style = Syncfusion.Windows.Forms.VisualStyle.Office2016White;
            this.Office2016ParentBarItem.Text = "Office2016Theme";
            this.Office2016ParentBarItem.WrapLength = 20;
            // 
            // barItem2016Black
            // 
            this.barItem2016Black.BarName = "barItem2016Black";
            this.barItem2016Black.CategoryIndex = 12;
            this.barItem2016Black.Checked = true;
            this.barItem2016Black.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem2016Black.ID = "Office2016Black";
            this.barItem2016Black.ShowToolTipInPopUp = false;
            this.barItem2016Black.SizeToFit = true;
            this.barItem2016Black.Text = "Office2016Black";
            this.barItem2016Black.Click += new System.EventHandler(this.OnOffice2016ThemeSelected);
            // 
            // barItem2016White
            // 
            this.barItem2016White.BarName = "barItem2016White";
            this.barItem2016White.CategoryIndex = 12;
            this.barItem2016White.Checked = true;
            this.barItem2016White.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem2016White.ID = "Office2016White";
            this.barItem2016White.ShowToolTipInPopUp = false;
            this.barItem2016White.SizeToFit = true;
            this.barItem2016White.Text = "Office2016White";
            this.barItem2016White.Click += new System.EventHandler(this.OnOffice2016ThemeSelected);
            // 
            // barItem2016Colorful
            // 
            this.barItem2016Colorful.BarName = "barItem2016Colorful";
            this.barItem2016Colorful.CategoryIndex = 12;
            this.barItem2016Colorful.Checked = true;
            this.barItem2016Colorful.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem2016Colorful.ID = "Office2016Colorful";
            this.barItem2016Colorful.ShowToolTipInPopUp = false;
            this.barItem2016Colorful.SizeToFit = true;
            this.barItem2016Colorful.Text = "Office2016Colorful";
            this.barItem2016Colorful.Click += new System.EventHandler(this.OnOffice2016ThemeSelected);
            // 
            // barItem2016DrakGray
            // 
            this.barItem2016DrakGray.BarName = "barItem2016DrakGray";
            this.barItem2016DrakGray.CategoryIndex = 12;
            this.barItem2016DrakGray.Checked = true;
            this.barItem2016DrakGray.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem2016DrakGray.ID = "Office2016DrakGray";
            this.barItem2016DrakGray.ShowToolTipInPopUp = false;
            this.barItem2016DrakGray.SizeToFit = true;
            this.barItem2016DrakGray.Text = "Office2016DrakGray";
            this.barItem2016DrakGray.Click += new System.EventHandler(this.OnOffice2016ThemeSelected);
            // 
            // barItem94
            // 
            this.barItem94.BarName = "barItem94";
            this.barItem94.CategoryIndex = 12;
            this.barItem94.ID = "Metro";
            this.barItem94.ShowToolTipInPopUp = false;
            this.barItem94.SizeToFit = true;
            this.barItem94.Text = "Metro";
            this.barItem94.Click += new System.EventHandler(this.barItem94_Click);
            this.barItem94.Checked = true;
            // 
            // mainToolBar
            // 
            this.mainToolBar.BarName = "File";
            this.mainToolBar.BarStyle = ((Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle)((((Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.AllowQuickCustomizing | Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.RotateWhenVertical) 
            | Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.Visible) 
            | Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.DrawDragBorder)));
            this.mainToolBar.Caption = "MainToolBar";
            this.mainToolBar.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.barItem35,
            this.barItem36,
            this.parentBarItem1,
            this.openFileBarItem,
            this.barItem3,
            this.barItem4});
            this.mainToolBar.Manager = this.mainFrameBarManager1;
            // 
            // bar2
            // 
            this.bar2.BarName = "Debug";
            this.bar2.BarStyle = ((Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle)((((Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.AllowQuickCustomizing | Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.RotateWhenVertical) 
            | Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.Visible) 
            | Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.DrawDragBorder)));
            this.bar2.Caption = "DebugToolBar";
            this.bar2.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.barItem48,
            this.barItem49,
            this.barItem77,
            this.comboBoxBarItem1});
            this.bar2.Manager = this.mainFrameBarManager1;
            this.bar2.MenuItemMergeOrder = 5;
            this.bar2.SeparatorIndices.AddRange(new int[] {
            8});
            this.bar2.DrawBackground += new System.Windows.Forms.PaintEventHandler(this.bar2_DrawBackground);
            // 
            // comboBoxBarItem1
            // 
            this.comboBoxBarItem1.BarName = "comboBoxBarItem1";
            this.comboBoxBarItem1.CategoryIndex = 7;
            this.comboBoxBarItem1.ChoiceList.AddRange(new string[] {
            "Debug",
            "Release",
            "Configuration Manager.."});
            this.comboBoxBarItem1.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxBarItem1.ID = "debugCombo";
            this.comboBoxBarItem1.ImageIndex = 107;
            this.comboBoxBarItem1.ImageList = this.imageList1;
            this.comboBoxBarItem1.MinWidth = 70;
            this.comboBoxBarItem1.PaintStyle = Syncfusion.Windows.Forms.Tools.XPMenus.PaintStyle.ImageAndText;
            this.comboBoxBarItem1.ShowToolTipInPopUp = false;
            this.comboBoxBarItem1.SizeToFit = true;
            this.comboBoxBarItem1.TextBoxValue = "Debug";
            // 
            // comboBoxBarItem2
            // 
            this.comboBoxBarItem2.BarName = "comboBoxBarItem2";
            this.comboBoxBarItem2.CategoryIndex = 7;
            this.comboBoxBarItem2.ChoiceList.AddRange(new string[] {
            "AnyCPU",
            "Configuration Manager.."});
            this.comboBoxBarItem2.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxBarItem2.ID = "_1";
            this.comboBoxBarItem2.MinWidth = 100;
            this.comboBoxBarItem2.ShowToolTipInPopUp = false;
            this.comboBoxBarItem2.SizeToFit = true;
            this.comboBoxBarItem2.TextBoxValue = "AnyCPU";
            // 
            // barItem27
            // 
            this.barItem27.BarName = "barItem27";
            this.barItem27.CategoryIndex = 4;
            this.barItem27.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem27.ID = "Quick Find";
            this.barItem27.Shortcut = System.Windows.Forms.Shortcut.CtrlF;
            this.barItem27.ShowToolTipInPopUp = false;
            this.barItem27.SizeToFit = true;
            this.barItem27.Text = "Quick Find";
            // 
            // barItem28
            // 
            this.barItem28.BarName = "barItem28";
            this.barItem28.CategoryIndex = 4;
            this.barItem28.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem28.ID = "Quick Replace";
            this.barItem28.Shortcut = System.Windows.Forms.Shortcut.CtrlH;
            this.barItem28.ShowToolTipInPopUp = false;
            this.barItem28.SizeToFit = true;
            this.barItem28.Text = "Quick Replace";
            // 
            // barItem29
            // 
            this.barItem29.BarName = "barItem29";
            this.barItem29.CategoryIndex = 4;
            this.barItem29.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem29.ID = "Find in Files";
            this.barItem29.Shortcut = System.Windows.Forms.Shortcut.CtrlShiftF;
            this.barItem29.ShowToolTipInPopUp = false;
            this.barItem29.SizeToFit = true;
            this.barItem29.Text = "Find in Files";
            // 
            // barItem30
            // 
            this.barItem30.BarName = "barItem30";
            this.barItem30.CategoryIndex = 4;
            this.barItem30.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem30.ID = "Replace in Files";
            this.barItem30.Shortcut = System.Windows.Forms.Shortcut.CtrlShiftH;
            this.barItem30.ShowToolTipInPopUp = false;
            this.barItem30.SizeToFit = true;
            this.barItem30.Text = "Replace in Files";
            // 
            // barItem31
            // 
            this.barItem31.BarName = "barItem31";
            this.barItem31.CategoryIndex = 4;
            this.barItem31.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem31.ID = "Find Symbol";
            this.barItem31.Shortcut = System.Windows.Forms.Shortcut.AltF12;
            this.barItem31.ShowToolTipInPopUp = false;
            this.barItem31.SizeToFit = true;
            this.barItem31.Text = "Find Symbol";
            // 
            // barItem32
            // 
            this.barItem32.BarName = "barItem32";
            this.barItem32.CategoryIndex = 5;
            this.barItem32.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem32.ID = "Toggle Bookmark";
            this.barItem32.ShowToolTipInPopUp = false;
            this.barItem32.SizeToFit = true;
            this.barItem32.Text = "Toggle Bookmark";
            // 
            // barItem33
            // 
            this.barItem33.BarName = "barItem33";
            this.barItem33.CategoryIndex = 5;
            this.barItem33.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem33.ID = "Enable Bookmark";
            this.barItem33.ShowToolTipInPopUp = false;
            this.barItem33.SizeToFit = true;
            this.barItem33.Text = "Enable All Bookmarks";
            // 
            // barItem34
            // 
            this.barItem34.BarName = "barItem34";
            this.barItem34.CategoryIndex = 5;
            this.barItem34.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem34.ID = "Enable Bookmark_1";
            this.barItem34.ShowToolTipInPopUp = false;
            this.barItem34.SizeToFit = true;
            this.barItem34.Text = "Enable Bookmark";
            // 
            // barItem37
            // 
            this.barItem37.BarName = "barItem37";
            this.barItem37.CategoryIndex = 5;
            this.barItem37.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem37.ID = "Clear Bookmarks";
            this.barItem37.ShowToolTipInPopUp = false;
            this.barItem37.SizeToFit = true;
            this.barItem37.Text = "Clear Bookmarks";
            // 
            // barItem38
            // 
            this.barItem38.BarName = "barItem38";
            this.barItem38.CategoryIndex = 5;
            this.barItem38.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem38.ID = "Previous Bookmark in Folder";
            this.barItem38.ShowToolTipInPopUp = false;
            this.barItem38.SizeToFit = true;
            this.barItem38.Text = "Previous Bookmark in Folder";
            // 
            // barItem39
            // 
            this.barItem39.BarName = "barItem39";
            this.barItem39.CategoryIndex = 5;
            this.barItem39.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem39.ID = "Next Bookmark in Folder";
            this.barItem39.ShowToolTipInPopUp = false;
            this.barItem39.SizeToFit = true;
            this.barItem39.Text = "Next Bookmark in Folder";
            // 
            // barItem40
            // 
            this.barItem40.BarName = "barItem40";
            this.barItem40.CategoryIndex = 5;
            this.barItem40.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem40.ID = "Previous Bookmark in Document";
            this.barItem40.ShowToolTipInPopUp = false;
            this.barItem40.SizeToFit = true;
            this.barItem40.Text = "Previous Bookmark in Document";
            // 
            // barItem41
            // 
            this.barItem41.BarName = "barItem41";
            this.barItem41.CategoryIndex = 5;
            this.barItem41.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem41.ID = "Next Bookmark in Document";
            this.barItem41.ShowToolTipInPopUp = false;
            this.barItem41.SizeToFit = true;
            this.barItem41.Text = "Next Bookmark in Document";
            // 
            // barItem42
            // 
            this.barItem42.BarName = "barItem42";
            this.barItem42.CategoryIndex = 5;
            this.barItem42.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem42.ID = "Clear Bookmarks in Document";
            this.barItem42.ShowToolTipInPopUp = false;
            this.barItem42.SizeToFit = true;
            this.barItem42.Text = "Clear Bookmarks in Document";
            // 
            // splashControl1
            // 
            this.splashControl1.AutoMode = false;
            this.splashControl1.CustomSplashPanel = this.splashPanel1;
            this.splashControl1.HideHostForm = true;
            this.splashControl1.HostForm = this;
            this.splashControl1.UseCustomSplashPanel = true;
            // 
            // splashPanel1
            // 
            this.splashPanel1.AnimationDirection = Syncfusion.Windows.Forms.Tools.AnimationDirection.Default;
            this.splashPanel1.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.None, System.Drawing.Color.White, System.Drawing.SystemColors.HighlightText);
            this.splashPanel1.BackgroundImage = global::VSDemo.Properties.Resources.vs_title;
            this.splashPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.splashPanel1.BeforeTouchSize = new System.Drawing.Size(430, 230);
            this.splashPanel1.BorderType = Syncfusion.Windows.Forms.Tools.SplashBorderType.None;
            this.splashPanel1.DiscreetLocation = new System.Drawing.Point(0, 0);
            this.splashPanel1.Location = new System.Drawing.Point(218, 320);
            this.splashPanel1.MarqueeDirection = Syncfusion.Windows.Forms.Tools.SplashPanelMarqueeDirection.LeftToRight;
            this.splashPanel1.MarqueePosition = Syncfusion.Windows.Forms.Tools.MarqueePosition.BottomLeft;
            this.splashPanel1.Name = "splashPanel1";
            this.splashPanel1.Size = new System.Drawing.Size(430, 230);
            this.splashPanel1.TabIndex = 25;
            this.splashPanel1.Text = "splashPanel1";
            // 
            // skinManager1
            // 
            this.skinManager1.Controls = this;
            this.skinManager1.VisualTheme = Syncfusion.Windows.Forms.VisualTheme.Managed;
            // 
            // VSDemoMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 15);
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.WindowState = FormWindowState.Maximized;
            this.ClientSize = new System.Drawing.Size(1016, 734);
            this.Controls.Add(this.splashPanel1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            string imagepath = "..\\..\\Resources\\";
#if NETCORE || NET50
            imagepath = "..\\..\\..\\Resources\\";
#endif
            Bitmap img = new Bitmap(Image.FromFile(imagepath + "vsicon.ico"));
            this.Icon = Icon.FromHandle(img.GetHicon());
            this.IconSize = new Size(22, 22);
            this.IsMdiContainer = true;
            this.Name = "VSDemoMainForm";
            this.Style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.Style.InactiveShadowOpacity = ((byte)(0));
            this.Style.ShadowOpacity = ((byte)(0));
            this.Style.TitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.Style.TitleBar.CloseButtonForeColor = System.Drawing.Color.Black;
            this.Style.TitleBar.CloseButtonHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.Style.TitleBar.MaximizeButtonForeColor = System.Drawing.Color.Black;
            this.Style.TitleBar.MaximizeButtonHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.Style.TitleBar.MinimizeButtonForeColor = System.Drawing.Color.Black;
            this.Style.TitleBar.MinimizeButtonHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.Text = "Visual Studio Demo";
            this.Load += new System.EventHandler(this.VSDemoMainForm_Load);
            this.Closing += new System.ComponentModel.CancelEventHandler(this.VSDemoMainForm_Closing);
            ((System.ComponentModel.ISupportInitialize)(this.dockingManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainFrameBarManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxBarItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxBarItem2)).EndInit();
            this.ResumeLayout(false);

        }

        void bar2_DrawBackground(object sender, PaintEventArgs e)
        {
            using (SolidBrush brush = new SolidBrush(Color.FromArgb(239,239,242)))
            {
                e.Graphics.FillRectangle(brush, e.ClipRectangle);
            }
        }
        #endregion

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense(Syncfusion.Licensing.DemoCommon.FindLicenseKey());
            SfSkinManager.LoadAssembly(typeof(Office2016Theme).Assembly);
            Application.EnableVisualStyles();
            Application.Run(new VSDemoMainForm());            
        }


        #region BarItem Click Events

        /// <summary>
        /// Bar Item click event functions
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnBarItemClick(object sender, EventArgs e)
        {
            BarItem item = sender as BarItem;
            switch (item.ID)
            {
                case "File_New":
                    new NewFileDialog(this).ShowDialog();
                    break;
                case "File_Open":
                    openFileDialog();
                    break;
                case "CloseAllWindows":
                    closeWindows();
                    break;
                case "Close":
                    if (this.ActiveMdiChild != null)
                        this.ActiveMdiChild.Close();
                    break;
                case "NewHorizontalTabGroup":
                    if (this.tabbedMDIManager.CanCreateNewHorizontalGroup())
                        this.tabbedMDIManager.CreateNewHorizontalGroup();
                    else
                        MessageBox.Show("Reset window layout and then Click to create the Horizontal Group");
                    break;
                case "NewVerticalTabGroup":
                    if (this.tabbedMDIManager.CanCreateNewVerticalGroup())
                        this.tabbedMDIManager.CreateNewVerticalGroup();
                    else
                        MessageBox.Show("Reset window layout and then Click to create the Vertical Group");
                    break;
                case "TileVertical":
                    this.LayoutMdi(MdiLayout.TileVertical);
                    break;
                case "TileHorizontal":
                    this.LayoutMdi(MdiLayout.TileHorizontal);
                    break;
                case "Cascade":
                    this.LayoutMdi(MdiLayout.Cascade);
                    break;
                case "RecentFileList":
                    ListBarItemClickedEventArgs args = e as ListBarItemClickedEventArgs;
                    if (recentFileListBarItem.ChildCaptions[args.IndexClicked] != "")
                    {
                        openFileInCodeEditor(recentFileListBarItem.ChildCaptions[args.IndexClicked]);
                    }
                    break;
                case "Exit":
                    this.Close();
                    break;
                case "WatchList":
                    createWatchWindow();
                    break;
                case "SolutionExplorer":
                    this.dockingManager1.ActivateControl(this.solutionExplorerView1);
                    if (!this.dockingManager1.GetDockVisibility(this.solutionExplorerView1))
                        this.dockingManager1.SetDockVisibility(this.solutionExplorerView1, true);
                    break;
                case "PropertiesWindow":
                    this.dockingManager1.ActivateControl(this.propertiesView1);
                    if (!this.dockingManager1.GetDockVisibility(this.propertiesView1))
                        this.dockingManager1.SetDockVisibility(this.propertiesView1, true);
                    break;
                case "ClassView":
                    this.dockingManager1.ActivateControl(this.classView1);
                    if (!this.dockingManager1.GetDockVisibility(this.classView1))
                        this.dockingManager1.SetDockVisibility(this.classView1, true);
                    break;
                case "ErrorList":
                    this.dockingManager1.ActivateControl(this.errorlistView1);
                    if (!this.dockingManager1.GetDockVisibility(this.errorlistView1))
                        this.dockingManager1.SetDockVisibility(this.errorlistView1, true);
                    break;
                case "OutputWindow":
                    this.dockingManager1.ActivateControl(this.outputWindowView1);
                    if (!this.dockingManager1.GetDockVisibility(this.outputWindowView1))
                        this.dockingManager1.SetDockVisibility(this.outputWindowView1, true);
                    break;
                case "FindResults":
                    this.dockingManager1.ActivateControl(this.findResultsView1);
                    if (!this.dockingManager1.GetDockVisibility(this.findResultsView1))
                        this.dockingManager1.SetDockVisibility(this.findResultsView1, true);
                    break;
                case "ToolBox":
                    this.dockingManager1.ActivateControl(this.toolBoxView1);
                    if (!this.dockingManager1.GetDockVisibility(this.toolBoxView1))
                        this.dockingManager1.SetDockVisibility(this.toolBoxView1, true);
                    break;
                case "ObjectBrowser":
                    this.dockingManager1.ActivateControl(this.objectBrowserView1);
                    if (!this.dockingManager1.GetDockVisibility(this.objectBrowserView1))
                        this.dockingManager1.SetDockVisibility(this.objectBrowserView1, true);
                    break;
                case "Default":
                    ChangeTheme(item, VisualStyle.Default);
                    break;
                case "Office2003":
                    ChangeTheme(item, VisualStyle.Office2003);
                    break;
            }
        }

        private void closeWindows()
        {
            this.tabbedMDIManager.DetachFromMdiContainer(this, true);
            foreach (Form f in this.MdiChildren)
            {
                f.Close();
            }
            this.tabbedMDIManager.AttachToMdiContainer(this);
        }

        int listIndex = 1;
        private void createWatchWindow()
        {
            this.dockingManager1.LockDockPanelsUpdate();
            watchWindow = new WatchWindowView();
            watchWindow.Name = String.Format("Watch List{0}", listIndex++);
            this.dockingManager1.DockControl(watchWindow, this.errorlistView1, DockingStyle.Tabbed, watchWindow.Height);
            this.dockingManager1.ActivateControl(watchWindow);
            this.dockingManager1.UnlockDockPanelsUpdate();
            foreach (BarItem i in this.debugWindowsParentBarItem.Items)
                i.Checked = false;
            addToParentBarList(watchWindow.Name, this.debugWindowsParentBarItem, new EventHandler(OnDebugWindowClick));
        }

        private void OnDebugWindowClick(object sender, EventArgs e)
        {
            foreach (BarItem i in this.debugWindowsParentBarItem.Items)
                i.Checked = false;
            BarItem item = sender as BarItem;
            item.Checked = true;
            this.dockingManager1.ActivateControl(GetDockControl(item.Text));
        }

        private Control GetDockControl(string name)
        {
            foreach (Control c in this.dockingManager1.ControlsArray)
                if (c.Name == name)
                    return c;
            return null;
        }

        #endregion

        #region Openfile functions
        /// <summary>
        /// Opens a file dialog to show a list of files and then loads it in the CodeEditor
        /// </summary>
        private void openFileDialog()
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "C# Files (*.cs)|*.cs|VB Files (*.vb)|*.vb|All files|*";
            DialogResult dr = ofd.ShowDialog();
            if (dr == DialogResult.OK)
            {
                string filepath = ofd.FileName;
                openFileInCodeEditor(filepath);
            }
        }

        /// <summary>
        /// Helper function opens the file in CodeEditor form
        /// </summary>
        /// <param name="filepath"></param>
        public void openFileInCodeEditor(string filepath)
        {
            string filename = null;
            if (filepath != null)
                filename = filepath.Substring(filepath.LastIndexOf("\\") + 1);
            if (!CheckFormPresentInChildWindow(filename))
            {
                ShowCodeEditor(filepath, filename);
                addToRecentList(filepath);
                addToParentBarList(filename, this.windowParentBarItem, new EventHandler(OnWindowBarItemClick));
            }
        }

        private void addToParentBarList(string barItemText, ParentBarItem parentBarItem)
        {
            foreach (BarItem i in this.windowParentBarItem.Items)
                i.Checked = false;
            BarItem item = new BarItem(barItemText);
            item.Checked = true;
            item.ID = "myWindow" + barItemText;
            item.MergeOrder = 0;
            parentBarItem.Items.Add(item);
            this.mainFrameBarManager1.Items.Add(item);
        }

        private void addToParentBarList(string barItemText, ParentBarItem parentBarItem, EventHandler eventhandler)
        {
            foreach (BarItem i in this.windowParentBarItem.Items)
                i.Checked = false;
            BarItem item = new BarItem(barItemText, eventhandler);
            item.Checked = true;
            item.ID = "myWindow" + barItemText;
            item.MergeOrder = 0;
            parentBarItem.Items.Add(item);
            this.mainFrameBarManager1.Items.Add(item);
        }

        public bool CheckFormPresentInChildWindow(string filename)
        {
            bool result = false;
            foreach (Form f in this.MdiChildren)
            {
                if (f.Text == filename)
                {
                    f.Activate();
                    result = true;
                    break;
                }
            }
            return result;
        }

        private void ActivateChildForm(string filename)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.Text == filename)
                {
                    f.Activate();
                    break;
                }
            }
        }

        public Form CheckFormInChildWindow(string filename)
        {
            Form result = null;
            foreach (Form f in this.MdiChildren)
            {
                if (f.Text == filename)
                {
                    f.Activate();
                    result = f;
                    break;
                }
            }
            return result;
        }

        private void ShowCodeEditor(string filepath, string fileName)
        {
            if (fileName.EndsWith(".cs"))
            {
                codeEditorForm = new CodeEditorBase(VSDemo.CodeType.CS, filepath);
                codeEditorForm.MdiParent = this;
                codeEditorForm.Name = fileName;
                codeEditorForm.Text = fileName;
                codeEditorForm.Tag = (object)filepath;
                codeEditorForm.Show();
            }
            else if (fileName.EndsWith(".vb"))
            {
                codeEditorForm = new CodeEditorBase(VSDemo.CodeType.VB, filepath);
                codeEditorForm.MdiParent = this;
                codeEditorForm.Name = fileName;
                codeEditorForm.Text = fileName;
                codeEditorForm.Tag = (object)filepath;
                codeEditorForm.Show();
            }
            else
                MessageBox.Show("Format not supported");
        }

        private void addToRecentList(string filePath)
        {
            if (this.recentFileListBarItem.ChildCaptions.IndexOf(filePath) == -1)
            {
                if (this.recentFileListBarItem.ChildCaptions.Count <= 10)
                    this.recentFileListBarItem.ChildCaptions.Add(filePath);
                else
                {
                    this.recentFileListBarItem.ChildCaptions.RemoveAt(10);
                    StringCollection collection = this.recentFileListBarItem.ChildCaptions;
                    this.recentFileListBarItem.ChildCaptions.Clear();
                    foreach (string s in collection)
                        this.recentFileListBarItem.ChildCaptions.Add(s);
                }
            }
        }

        private void OnWindowBarItemClick(object sender, EventArgs e)
        {
            BarItem item = sender as BarItem;
            ActivateChildForm(item.Text);
            foreach (BarItem i in this.windowParentBarItem.Items)
            {
                i.Checked = false;
            }
            item.Checked = true;
        }


        #endregion

        #region Form Events

        /// <summary>
        /// Occurs when the Form loads
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void VSDemoMainForm_Load(object sender, System.EventArgs e)
        {
            this.mainFrameBarManager1.LockHostedFormForMDIChanges = true;
            this.mainFrameBarManager1.RegisterMdiChildTypes(new Type[]
                                                    {
                                                        typeof(CodeEditorBase)
                                                    });
            loadFromSerializer();
#if NETCORE
            if (System.IO.File.Exists(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + @"..\..\..\..\AssemblyInfo.cs"))
                openFileInCodeEditor(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + @"..\..\..\..\AssemblyInfo.cs");
#else
             if (System.IO.File.Exists(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + @"..\..\..\AssemblyInfo.cs"))
                openFileInCodeEditor(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + @"..\..\..\AssemblyInfo.cs");
#endif

            this.MdiChildActivate += new EventHandler(OnMdiChildActivate);
            //this.mainFrameBarManager1.GetBarControl(this.mainFrameBarManager1.GetMergedEquivalent(this.mainToolBar, this.mainToolBar)).RowIndex = 0;
            //this.mainFrameBarManager1.GetBarControl(this.mainFrameBarManager1.GetMergedEquivalent(this.bar2, this.bar2)).RowIndex = 0;

            //this.mainFrameBarManager1.GetBarControl(this.mainFrameBarManager1.GetMergedEquivalent(codeEditorForm.bar2, codeEditorForm.bar2)).RowIndex = 1;
            //this.mainFrameBarManager1.GetBarControl(this.mainFrameBarManager1.GetMergedEquivalent(codeEditorForm.bar4, codeEditorForm.bar4)).RowIndex = 1;

            this.dockingManager1.CaptionButtons["CloseButton"].ImageIndex = 92;
            ApplyThemeToChildBarManager(VisualStyle.Default, Office2007Theme.Blue);
            ChangeTheme(this.barItem94, VisualStyle.Metro);
        }

        /// <summary>
        /// Occurs when the MdiChild is activated
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnMdiChildActivate(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null)
            {
                this.ActiveMdiChild.Activate();
                foreach (BarItem i in this.windowParentBarItem.Items)
                {
                    if (i.Text == this.ActiveMdiChild.Text)
                        i.Checked = true;
                    else
                        i.Checked = false;
                }
            }
        }

        /// <summary>
        /// Occurs when the MainForm is closing
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void VSDemoMainForm_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            this.MdiChildActivate -= new EventHandler(OnMdiChildActivate);
            this.tabbedMDIManager.DetachFromMdiContainer(this, false);
            foreach (Form f in this.MdiChildren)
                f.Close();
            serializeRecentlyViewedList();
            this.dockingManager1.SaveDockState();
        }

        private void serializeRecentlyViewedList()
        {
            AppStateSerializer serializer = AppStateSerializer.GetSingleton();
            serializer.SerializeObject("filelist", this.recentFileListBarItem.ChildCaptions, true);
        }
        #endregion

        #region TabbedMDI Events
        /// <summary>
        /// Occurs when a new Form is added to the TabbedMDIManager instance
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        TabControlAdv tabControl = null;
        private void tabbedMDIManager_TabControlAdded(object sender, TabbedMDITabControlEventArgs args)
        {
            tabControl = args.TabControl;
            tabControl.TabPrimitivesHost.Visible = true;
            tabControl.TabGap = 7;
        }

        void tabbedMDIManager_BeforeDropDownPopup(object sender, DropDownPopupEventArgs e)
        {
            switch (theme)
            {
                case "VS2005":
                    e.ParentBarItem.Style = VisualStyle.VS2005;
                    break;
                case "Office2003":
                    e.ParentBarItem.Style = VisualStyle.Office2003;
                    break;
                case "Office2007":
                    e.ParentBarItem.Style = VisualStyle.Office2007;
                    break;
            }
        }

        void ContextMenuItem_BeforePopup(object sender, CancelEventArgs e)
        {
            switch (theme)
            {
                case "VS2005":
                    this.tabbedMDIManager.ContextMenuItem.Style = Syncfusion.Windows.Forms.VisualStyle.VS2005;
                    break;
                case "Office2003":
                    this.tabbedMDIManager.ContextMenuItem.Style = Syncfusion.Windows.Forms.VisualStyle.Office2003;
                    break;
                case "Office2007":
                    this.tabbedMDIManager.ContextMenuItem.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007;
                    break;
            }
        }
        #endregion

        #region Recently used files

        /// <summary>
        /// Loads the save state of the recent file list from the serialized object
        /// </summary>
        private void loadFromSerializer()
        {
            AppStateSerializer serializer = AppStateSerializer.GetSingleton();
            object fileList = serializer.DeserializeObject("filelist");
            if (fileList != null)
            {
                System.Collections.Specialized.StringCollection collection = fileList as System.Collections.Specialized.StringCollection;
                this.recentFileListBarItem.ChildCaptions.Clear();
                foreach (string s in collection)
                    if (System.IO.File.Exists(s))
                        this.recentFileListBarItem.ChildCaptions.Add(s);
            }
        }

        #endregion

        #region About form

        private void barItem14_Click(object sender, System.EventArgs e)
        {
            DemoCommon.AboutForm aboutForm = new DemoCommon.AboutForm(AppDomain.CurrentDomain.GetAssemblies());
            aboutForm.ShowDialog();
        }

        #endregion

        #region Docking Events

        /// <summary>
        /// Occurs when the dock state of the control is changed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="arg"></param>
        private void dockingManager1_DockStateChanged(object sender, Syncfusion.Windows.Forms.Tools.DockStateChangeEventArgs arg)
        {
            SetHotTrackFalse();
        }

        /// <summary>
        /// Occurs when the docked control is activated
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="arg"></param>
        private void dockingManager1_DockControlActivated(object sender, Syncfusion.Windows.Forms.Tools.DockActivationChangedEventArgs arg)
        {
            if (arg.Control.Name.StartsWith("Watch List"))
            {
                foreach (BarItem i in this.debugWindowsParentBarItem.Items)
                {
                    if (i.Text == arg.Control.Name)
                        i.Checked = true;
                    else
                        i.Checked = false;
                }
            }
        }

        /// <summary>
        /// Occurs when the docking visibility is changed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="arg"></param>
        private void dockingManager1_DockVisibilityChanged(object sender, Syncfusion.Windows.Forms.Tools.DockVisibilityChangedEventArgs arg)
        {
            if (arg.Control.Name.StartsWith("Watch List"))
            {
                foreach (BarItem i in this.debugWindowsParentBarItem.Items)
                {
                    if (i.Text == arg.Control.Name)
                    {
                        this.debugWindowsParentBarItem.Items.Remove(i);
                        break;
                    }
                    else
                        i.Checked = false;
                }
            }
        }

        /// <summary>
        /// Sets the HotTracking of docked windows to false
        /// </summary>
        private void SetHotTrackFalse()
        {
            foreach (Control ctrl in this.dockingManager1.ControlsArray)
            {
                Syncfusion.Windows.Forms.Tools.DockHost dhost = ctrl.Parent as Syncfusion.Windows.Forms.Tools.DockHost;
                if (dhost != null)
                {
                    Syncfusion.Windows.Forms.Tools.DockHostController dhc = dhost.InternalController as
                        Syncfusion.Windows.Forms.Tools.DockHostController;

                    if (dhc.ParentController is Syncfusion.Windows.Forms.Tools.DockTabController)
                    {
                        Syncfusion.Windows.Forms.Tools.DockTabControl docktab = (dhc.ParentController as
                            Syncfusion.Windows.Forms.Tools.DockTabController).TabControl;
                        docktab.HotTrack = false;
                    }
                }
            }
        }

        /// <summary>
        /// Occurs when the DockState load is finished
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dockingManager1_NewDockStateEndLoad(object sender, System.EventArgs e)
        {
            SetHotTrackFalse();
        }

        #endregion

        #region ThemeEffects
        string theme = "Office2007";
        private void ChangeTheme(BarItem item, VisualStyle type)
        {
            foreach (BarItem i in this.VisualStylesParentBarItem.Items)
            {
                if (i.ID == item.ID)
                    i.Checked = true;
                else
                    i.Checked = false;
            }
            foreach (BarItem i in this.Office2007ParentBarItem.Items)
                i.Checked = false;

            switch (type)
            {
                case VisualStyle.Default:
                    this.toolBoxView1.gBToolBox.VisualStyle = Syncfusion.Windows.Forms.VisualStyle.Default;
                    this.toolBoxView1.gvcSyncfusion.BackColor = Color.FromArgb(218, 216, 221);
                    this.toolBoxView1.gvcComponents.BackColor = Color.FromArgb(218, 216, 221);
                    this.toolBoxView1.gvcWindowsForms.BackColor = Color.FromArgb(218, 216, 221);
                    this.toolBoxView1.gvcGeneral.BackColor = Color.FromArgb(218, 216, 221);

                    this.dockingManager1.VisualStyle = VisualStyle.Default;
                    this.errorlistView1.errorlistToolBar.Style = VisualStyle.Default;
                    this.errorlistView1.errorlistToolBar.BackgroundColor = new Syncfusion.Drawing.BrushInfo();

                    this.solutionExplorerView1.solutionExplorerToolBar.Style = VisualStyle.Default;
                    this.solutionExplorerView1.solutionExplorerToolBar.BackgroundColor = new Syncfusion.Drawing.BrushInfo();
                    this.codeEditorForm.editControl1.ContextMenuEnabled = false;
                    this.codeEditorForm.EditorContextMenuStripEx.Style = ContextMenuStripEx.ContextMenuStyle.Default;
                    this.codeEditorForm.editControl1.ContextMenuStrip = this.codeEditorForm.EditorContextMenuStripEx;
                    this.classView1.classViewToolBar.Style = VisualStyle.Default;
                    this.classView1.classViewToolBar.BackgroundColor = new Syncfusion.Drawing.BrushInfo();

                    this.objectBrowserView1.objectBrowserToolBar.Style = VisualStyle.Default;
                    this.objectBrowserView1.objectBrowserToolBar.BackgroundColor = new Syncfusion.Drawing.BrushInfo();

                    this.propertiesView1.propertiesToolBar.Style = VisualStyle.Metro;
                    this.propertiesView1.propertiesToolBar.BackgroundColor = new Syncfusion.Drawing.BrushInfo();

                    this.mainFrameBarManager1.Style = VisualStyle.Default;
                    this.projectParentBarItem.Style = VisualStyle.Default;
                    this.debugParentBarItem.Style = VisualStyle.Default;
                    this.tabbedMDIManager.TabStyle = typeof(TabRendererMetro);
                    ApplyThemeToChildBarManager(VisualStyle.Default);
                    SetColorToViewItems(SystemColors.Control, Color.Black);
                    theme = "Default";
                    break;
                case VisualStyle.Office2003:
                    this.toolBoxView1.gBToolBox.VisualStyle = Syncfusion.Windows.Forms.VisualStyle.Office2003;
                    this.toolBoxView1.gvcSyncfusion.BackColor = Color.FromArgb(218, 216, 221);
                    this.toolBoxView1.gvcComponents.BackColor = Color.FromArgb(218, 216, 221);
                    this.toolBoxView1.gvcWindowsForms.BackColor = Color.FromArgb(218, 216, 221);
                    this.toolBoxView1.gvcGeneral.BackColor = Color.FromArgb(218, 216, 221);
                    this.codeEditorForm.editControl1.ContextMenuEnabled = true;
                    this.codeEditorForm.editControl1.ContextMenuStrip = null;
                    this.dockingManager1.VisualStyle = type;
                    this.errorlistView1.errorlistToolBar.Style = type;
                    this.errorlistView1.errorlistToolBar.BackgroundColor = new Syncfusion.Drawing.BrushInfo();

                    this.solutionExplorerView1.solutionExplorerToolBar.Style = type;
                    this.solutionExplorerView1.solutionExplorerToolBar.BackgroundColor = new Syncfusion.Drawing.BrushInfo();

                    this.classView1.classViewToolBar.Style = type;
                    this.classView1.classViewToolBar.BackgroundColor = new Syncfusion.Drawing.BrushInfo();

                    this.objectBrowserView1.objectBrowserToolBar.Style = type;
                    this.objectBrowserView1.objectBrowserToolBar.BackgroundColor = new Syncfusion.Drawing.BrushInfo();

                    this.propertiesView1.propertiesToolBar.Style = type;
                    this.propertiesView1.propertiesToolBar.BackgroundColor = new Syncfusion.Drawing.BrushInfo();

                    this.mainFrameBarManager1.Style = type;
                    this.projectParentBarItem.Style = type;
                    this.debugParentBarItem.Style = type;
                    this.tabbedMDIManager.TabStyle = typeof(TabRendererWhidbey);
                    ApplyThemeToChildBarManager(VisualStyle.Office2003);
                    theme = "Office2003";
                    SetColorToViewItems(SystemColors.Control, Color.Black);
                    break;
                case VisualStyle.Metro:
                    this.toolBoxView1.gBToolBox.VisualStyle = Syncfusion.Windows.Forms.VisualStyle.Metro;
                    this.toolBoxView1.gvcSyncfusion.BackColor = Color.FromArgb(218, 216, 221);
                    this.toolBoxView1.gvcComponents.BackColor = Color.FromArgb(218, 216, 221);
                    this.toolBoxView1.gvcWindowsForms.BackColor = Color.FromArgb(218, 216, 221);
                    this.toolBoxView1.gvcGeneral.BackColor = Color.FromArgb(218, 216, 221);
                    this.codeEditorForm.editControl1.ContextMenuEnabled = false;
                    this.codeEditorForm.editControl1.ContextMenuStrip = this.codeEditorForm.EditorContextMenuStripEx;
                    this.codeEditorForm.EditorContextMenuStripEx.Style = ContextMenuStripEx.ContextMenuStyle.Metro;
                    this.codeEditorForm.EditorContextMenuStripEx.Renderer = new ContextMenuRenderer();
                    this.dockingManager1.VisualStyle = type;
                    this.errorlistView1.errorlistToolBar.Style = type;
                    this.errorlistView1.errorlistToolBar.BackgroundColor = new Syncfusion.Drawing.BrushInfo();

                    this.solutionExplorerView1.solutionExplorerToolBar.Style = type;
                    this.solutionExplorerView1.solutionExplorerToolBar.BackgroundColor = new Syncfusion.Drawing.BrushInfo();

                    this.classView1.classViewToolBar.Style = type;
                    this.classView1.classViewToolBar.BackgroundColor = new Syncfusion.Drawing.BrushInfo();

                    this.objectBrowserView1.objectBrowserToolBar.Style = type;
                    this.objectBrowserView1.objectBrowserToolBar.BackgroundColor = new Syncfusion.Drawing.BrushInfo();

                    this.propertiesView1.propertiesToolBar.Style = type;
                    this.propertiesView1.propertiesToolBar.BackgroundColor = new Syncfusion.Drawing.BrushInfo();

                    this.mainFrameBarManager1.Style = type;
                    this.projectParentBarItem.Style = type;
                    this.debugParentBarItem.Style = type;
                    this.tabbedMDIManager.TabStyle = typeof(TabRendererMetro);
                    break;
            }
        }

        private void OnOfficeThemeSelected(object sender, System.EventArgs e)
        {
            BarItem item = sender as BarItem;
            this.Office2007ParentBarItem.Checked = true;
            this.toolBoxView1.gBToolBox.VisualStyle = VisualStyle.Office2007;
            this.dockingManager1.VisualStyle = VisualStyle.Office2007;
            this.errorlistView1.errorlistToolBar.Style = VisualStyle.Office2007;
            this.solutionExplorerView1.solutionExplorerToolBar.Style = VisualStyle.Office2007;
            this.classView1.classViewToolBar.Style = VisualStyle.Office2007;
            this.objectBrowserView1.objectBrowserToolBar.Style = VisualStyle.Office2007;
            this.propertiesView1.propertiesToolBar.Style = VisualStyle.Office2007;
            this.mainFrameBarManager1.Style = VisualStyle.Office2007;
            this.projectParentBarItem.Style = VisualStyle.Office2007;
            this.debugParentBarItem.Style = VisualStyle.Office2007;
            //this.tabbedMDIManager.TabStyle = typeof(TabRendererDockingWhidbey);
            switch (item.ID)
            {
                case "Blue":
                    ApplyOffice2007Theme(Syncfusion.Windows.Forms.Office2007Theme.Blue, 220, 235, 254, Color.MidnightBlue);
                    tabbedMDIManager.TabStyle = typeof(TabRendererOffice2007);
                    foreach (TabHost tabhost in tabbedMDIManager.TabGroupHosts)
                        tabhost.MDITabPanel.Office2007ColorScheme = Office2007Theme.Blue;
                    break;
                case "Black":
                    ApplyOffice2007Theme(Syncfusion.Windows.Forms.Office2007Theme.Black, 166, 172, 181, Color.White);
                    tabbedMDIManager.TabStyle = typeof(TabRendererOffice2007);
                    foreach (TabHost tabhost in tabbedMDIManager.TabGroupHosts)
                        tabhost.MDITabPanel.Office2007ColorScheme = Office2007Theme.Black;
                    break;
                case "Silver":
                    ApplyOffice2007Theme(Syncfusion.Windows.Forms.Office2007Theme.Silver, 209, 211, 225, Color.Black);
                    tabbedMDIManager.TabStyle = typeof(TabRendererOffice2007);
                    foreach (TabHost tabhost in tabbedMDIManager.TabGroupHosts)
                        tabhost.MDITabPanel.Office2007ColorScheme = Office2007Theme.Silver;
                    break;
                case "Office2016Black":
                    this.skinManager1.VisualTheme = Syncfusion.Windows.Forms.VisualTheme.Office2016Black;
                    this.mainFrameBarManager1.Style = VisualStyle.Office2016Black;
                    this.toolBoxView1.gBToolBox.VisualStyle = VisualStyle.Office2016Black;
                    this.propertiesView1.propertiesToolBar.Style = VisualStyle.Office2016Black;
                    ApplyOffice2007Theme(Office2007Theme.Black, 166, 172, 181, Color.White);
                    break;
                case "Office2016White":
                    this.skinManager1.VisualTheme = Syncfusion.Windows.Forms.VisualTheme.Office2016White;
                    this.mainFrameBarManager1.Style = VisualStyle.Office2016White;
                    this.propertiesView1.propertiesToolBar.Style = VisualStyle.Office2016White;
                    this.toolBoxView1.gBToolBox.VisualStyle = VisualStyle.Office2016White;
                    break;
                case "Office2016DrakGray":
                    this.skinManager1.VisualTheme = Syncfusion.Windows.Forms.VisualTheme.Office2016DarkGray;
                    this.mainFrameBarManager1.Style = VisualStyle.Office2016DarkGray;
                    this.propertiesView1.propertiesToolBar.Style = VisualStyle.Office2016DarkGray;
                    this.toolBoxView1.gBToolBox.VisualStyle = VisualStyle.Office2016DarkGray;
                    ApplyOffice2007Theme(Syncfusion.Windows.Forms.Office2007Theme.Managed, 166, 172, 181, Color.White);
                    break;
                case "Office2016Colorful":
                    this.skinManager1.VisualTheme = Syncfusion.Windows.Forms.VisualTheme.Office2016Colorful;
                    this.mainFrameBarManager1.Style = VisualStyle.Office2016Colorful;
                    this.propertiesView1.propertiesToolBar.Style = VisualStyle.Office2016Colorful;
                    this.toolBoxView1.gBToolBox.VisualStyle = VisualStyle.Office2016Colorful;
                    break;
            }
            foreach (BarItem i in this.Office2007ParentBarItem.Items)
            {
                if (i.ID == item.ID)
                    i.Checked = true;
                else
                    i.Checked = false;
            }

            foreach (BarItem i in this.VisualStylesParentBarItem.Items)
                i.Checked = false;
            theme = "Office2007";
        }

        private void OnOffice2016ThemeSelected(object sender, System.EventArgs e)
        {
            BarItem item = sender as BarItem;
            this.Office2016ParentBarItem.Checked = true;
            switch (item.ID)
            {
                case "Office2016Black":
                    this.skinManager1.VisualTheme = Syncfusion.Windows.Forms.VisualTheme.Office2016Black;
                    this.mainFrameBarManager1.Style = VisualStyle.Office2016Black;
                    this.toolBoxView1.gBToolBox.VisualStyle = VisualStyle.Office2016Black;
                    this.propertiesView1.propertiesToolBar.Style = VisualStyle.Office2016Black;
                    ApplyOffice2007Theme(Office2007Theme.Black, 166, 172, 181, Color.White);
                    break;
                case "Office2016White":
                    this.skinManager1.VisualTheme = Syncfusion.Windows.Forms.VisualTheme.Office2016White;
                    this.mainFrameBarManager1.Style = VisualStyle.Office2016White;
                    this.propertiesView1.propertiesToolBar.Style = VisualStyle.Office2016White;
                    this.toolBoxView1.gBToolBox.VisualStyle = VisualStyle.Office2016White;
                    break;
                case "Office2016DrakGray":
                    this.skinManager1.VisualTheme = Syncfusion.Windows.Forms.VisualTheme.Office2016DarkGray;
                    this.mainFrameBarManager1.Style = VisualStyle.Office2016DarkGray;
                    this.propertiesView1.propertiesToolBar.Style = VisualStyle.Office2016DarkGray;
                    this.toolBoxView1.gBToolBox.VisualStyle = VisualStyle.Office2016DarkGray;
                    ApplyOffice2007Theme(Syncfusion.Windows.Forms.Office2007Theme.Managed, 166, 172, 181, Color.White);
                    break;
                case "Office2016Colorful":
                    this.skinManager1.VisualTheme = Syncfusion.Windows.Forms.VisualTheme.Office2016Colorful;
                    this.mainFrameBarManager1.Style = VisualStyle.Office2016Colorful;
                    this.propertiesView1.propertiesToolBar.Style = VisualStyle.Office2016Colorful;
                    this.toolBoxView1.gBToolBox.VisualStyle = VisualStyle.Office2016Colorful;
                    break;
            }
            foreach (BarItem i in this.Office2016ParentBarItem.Items)
            {
                if (i.ID == item.ID)
                    i.Checked = true;
                else
                    i.Checked = false;
            }

            foreach (BarItem i in this.VisualStylesParentBarItem.Items)
                i.Checked = false;
            theme = "Office2016";
        }
        private void ApplyOffice2007Theme(Syncfusion.Windows.Forms.Office2007Theme theme, int r, int g, int b, Color forecolor)
        {
            this.mainFrameBarManager1.Office2007Theme = theme;
            this.projectParentBarItem.Office2007Theme = theme;
            this.dockingManager1.Office2007Theme = theme;
            this.debugParentBarItem.Office2007Theme = theme;
            this.errorlistView1.errorlistToolBar.Style = VisualStyle.Office2007;
            this.errorlistView1.errorlistToolBar.Office2007Theme = theme;
            this.solutionExplorerView1.solutionExplorerToolBar.Office2007Theme = theme;
            this.classView1.classViewToolBar.Office2007Theme = theme;
            this.objectBrowserView1.objectBrowserToolBar.Office2007Theme = theme;
            this.propertiesView1.propertiesToolBar.Office2007Theme = theme;
            this.toolBoxView1.gBToolBox.Office2007Theme = theme;
            SetColorToViewItems(Color.FromArgb(r, g, b), forecolor);
            ApplyThemeToChildBarManager(VisualStyle.Office2007, theme);
        }
        Color tempForeColor;
        private void SetColorToViewItems(Color backColor, Color forecolor)
        {
            tempForeColor = forecolor;
            this.toolBoxView1.gvcSyncfusion.BackColor = backColor;
            this.toolBoxView1.gvcSyncfusion.ForeColor = forecolor;
            this.toolBoxView1.gvcComponents.BackColor = backColor;
            this.toolBoxView1.gvcComponents.ForeColor = forecolor;
            this.toolBoxView1.gvcWindowsForms.BackColor = backColor;
            this.toolBoxView1.gvcWindowsForms.ForeColor = forecolor;
            this.toolBoxView1.gvcGeneral.BackColor = backColor;
            this.toolBoxView1.gvcGeneral.ForeColor = forecolor;
        }


        private void ApplyThemeToChildBarManager(VisualStyle style)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f is CodeEditorBase)
                {
                    CodeEditorBase childCodeForm = (CodeEditorBase)f;
                    childCodeForm.EditParentBarItem.Style = style;
                    childCodeForm.FormatParentBarItem.Style = style;
                    childCodeForm.editControl1.MenuFill += new EventHandler(editControl1_MenuFill);
                }
            }
        }

        private void ApplyThemeToChildBarManager(VisualStyle style, Syncfusion.Windows.Forms.Office2007Theme theme)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f is CodeEditorBase)
                {
                    CodeEditorBase childCodeForm = (CodeEditorBase)f;
                    childCodeForm.EditParentBarItem.Style = style;
                    childCodeForm.EditParentBarItem.Office2007Theme = theme;
                    childCodeForm.FormatParentBarItem.Style = style;
                    childCodeForm.FormatParentBarItem.Office2007Theme = theme;
                    childCodeForm.editControl1.MenuFill += new EventHandler(editControl1_MenuFill);
                }
            }
        }

        void editControl1_MenuFill(object sender, EventArgs e)
        {
            Syncfusion.Windows.Forms.Edit.Implementation.ContextMenuManager cm = (Syncfusion.Windows.Forms.Edit.Implementation.ContextMenuManager)sender;
            switch (theme)
            {
                case "VS2005":
                    cm.ContextMenuProvider.SetVisualStyle(VisualStyle.VS2005);
                    break;
                case "Office2003":
                    cm.ContextMenuProvider.SetVisualStyle(VisualStyle.Office2003);
                    break;
                case "Office2007":
                    cm.ContextMenuProvider.SetVisualStyle(VisualStyle.Office2007);
                    break;
            }
        }
        #endregion

        private void barItem94_Click(object sender, EventArgs e)
        {
            BarItem item = sender as BarItem;
            ChangeTheme(item, VisualStyle.Metro);
        }

    
    }
}


#region Copyright Syncfusion Inc. 2001 - 2019
// Copyright Syncfusion Inc. 2001 - 2019. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion

using Syncfusion.Windows.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Syncfusion.Windows.Forms.Tools;
using Syncfusion.Windows.Forms.Tools.XPMenus;

namespace Localization
{
    public partial class Form1 : MetroForm
    {
        public Form1()
        {
            LocalizationProvider.Provider = new Localization();
            InitializeComponent();
            try
            {
                System.Drawing.Icon ico = new System.Drawing.Icon(GetIconFile(@"..\\..\\\VS.ico"));
                this.Icon = ico;
            }
            catch { }
            this.ShowIcon = true;
            this.BorderThickness = 12;
            this.BorderColor = ColorTranslator.FromHtml("#d6dbe9");
            this.MetroColor = ColorTranslator.FromHtml("#d6dbe9");
            this.editControl1.ApplyConfiguration("C#");
#if NETCORE
            this.editControl1.LoadFile(Path.GetDirectoryName(Application.ExecutablePath) + @"\..\..\..\Form1.cs");
#else
              this.editControl1.LoadFile(Path.GetDirectoryName(Application.ExecutablePath) + @"\..\..\Form1.cs");
#endif
            this.dockingManager1.SetAsMDIChild(this.dockingClientPanel1, true);
            this.dockingManager1.DragProviderStyle = DragProviderStyle.VS2010;
            this.bar1.DrawBackground += bar1_DrawBackground;
            this.treeViewAdv1.FullRowSelect = true;
            this.treeViewAdv1.MouseMove += new MouseEventHandler(treeViewAdv1_MouseMove);
            this.treeViewAdv1.MouseLeave += new EventHandler(treeViewAdv1_MouseLeave);

            this.dockingManager1.SetAutoHideOnLoad(this.panel3, true);
            this.comboBoxBarItem1.ListBox = new ListBox();
            this.comboBoxBarItem1.ListBox.Items.AddRange(new string[] { "调试", "发布", "配置管理器" });
            this.comboBoxBarItem1.TextBoxValue = "调试";
            this.AddTreeNode();
            this.AddMainFrameBarManagerItem();            
            this.AddItemsUnderFile();
            this.AddItemsUnderEdit();
            this.AddItemsUnderView();
            this.AddItemsUnderProject();
            this.AddItemsUnderBuild();
            this.AddItemsUnderDebug();
            this.AddItemsUnderTeam();
            this.AddItemsUnderFormat();
            this.AddItemsUnderTools();
            this.AddItemsUnderTest();
            this.AddItemsUnderAnalyze();
            this.AddItemsUnderWindows();
            this.AddItemsUnderHelp();
            this.Load += Form1_Load;
            this.comboBoxBarItem1.SizeToFit = true;
            this.comboBoxBarItem1.MinWidth = 75;
            this.comboBoxBarItem1.ListBox.ItemHeight = 50;
            this.comboBoxBarItem1.ListBox.ItemHeight = 100;
#if NETCORE
            UpdateLayout();
#endif
            this.bar1.BarStyle = ((Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle)(((((Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.AllowQuickCustomizing | Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.IsMainMenu)
                       | Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.RotateWhenVertical)
                       | Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.Visible)
                       | Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.UseWholeRow)));
        }

        /// <summary>
        /// Update the Dock Layout
        /// </summary>
        private void UpdateLayout()
        {
            this.dockingManager1.DockControl(this.panel3, this, DockingStyle.Bottom, 30);
            this.dockingManager1.DockControl(this.panel2, this.panel3, DockingStyle.Tabbed, 30);
            this.dockingManager1.DockControl(this.panel4, this.panel3, DockingStyle.Tabbed, 30);
            this.dockingManager1.DockControl(this.panel1, this, DockingStyle.Left, 281);
            this.dockingManager1.DockControl(this.panel5, this, DockingStyle.Right, 254);
            this.dockingManager1.SetAutoHideMode(this.panel3, true);
        }
        /// <summary>
        /// To Apply Color customization
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            this.treeViewAdv1.ItemHeight = 25;
            this.treeViewAdv1.SelectedNode = this.treeViewAdv1.Nodes[0].Nodes[0];
            this.treeViewAdv1.Font = new Font("Automatic", 8.5F);
            this.dockingManager1.ActiveCaptionFont = new Font("Automatic", 8.5F);
            this.dockingManager1.VisualStyle = VisualStyle.Metro;
            UpdateAutohideColor();
            UpdateColors();
        }

        #region Items under FilebarItem

        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem parentBarItem1;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem parentBarItem2;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem addToSourceCotrol;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem saveAll;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem Exit;

        public void AddItemsUnderFile()
        {
            // 
            // parentBarItem1
            // 
            this.parentBarItem1 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.parentBarItem1.BarName = "parentBarItem1";
            this.parentBarItem1.CategoryIndex = 0;
            this.parentBarItem1.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parentBarItem1.ID = "New";
            this.parentBarItem1.ImageIndex = 96;
            this.parentBarItem1.ImageList = this.imageList1;

            this.parentBarItem1.ShowToolTipInPopUp = false;
            this.parentBarItem1.SizeToFit = true;
            this.parentBarItem1.Text = "新";
            this.parentBarItem1.ImageList = this.imageList3;
            this.parentBarItem1.ImageIndex = 96;
            // 
            // parentBarItem2
            // 
            this.parentBarItem2 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.parentBarItem2.BarName = "parentBarItem2";
            this.parentBarItem2.CategoryIndex = 0;
            this.parentBarItem2.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parentBarItem2.ID = "New";
            this.parentBarItem2.ImageIndex = 96;
            this.parentBarItem2.ImageList = this.imageList1;
            this.parentBarItem2.ShowToolTipInPopUp = false;
            this.parentBarItem2.SizeToFit = true;
            this.parentBarItem2.Text = "打开";

            // 
            // addToSourceCotrol
            // 
            this.addToSourceCotrol = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.addToSourceCotrol.BarName = "addToSourceCotrol";
            this.addToSourceCotrol.CategoryIndex = 1;
            this.addToSourceCotrol.ID = "";
            this.addToSourceCotrol.ShowToolTipInPopUp = false;
            this.addToSourceCotrol.SizeToFit = true;
            this.addToSourceCotrol.Text = "添加到源代码控制";
            this.addToSourceCotrol.ImageList = this.imageList3;
            this.addToSourceCotrol.ImageIndex = 56;
            ///
            /// Save All
            ///
            this.saveAll = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.saveAll.BarName = "SaveAll";
            this.saveAll.CategoryIndex = 1;
            this.saveAll.ID = "";
            this.saveAll.ShowToolTipInPopUp = false;
            this.saveAll.SizeToFit = true;
            this.saveAll.Text = "保存全部";
            this.saveAll.ImageList = this.imageList2;
            this.saveAll.ImageIndex = 5;

            ///
            /// Exit 
            ///
            this.Exit = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.Exit.BarName = "Exit";
            this.Exit.CategoryIndex = 1;
            this.Exit.ID = "";
            this.Exit.ShowToolTipInPopUp = false;
            this.Exit.SizeToFit = true;
            this.Exit.Text = "出口";
            this.Exit.Click += new EventHandler(Exit_Click);

            this.mainFrameBarManager1.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {          
            this.parentBarItem1,
            this.parentBarItem2,
            this.addToSourceCotrol,
            this.saveAll,
            this.Exit});

            this.barItem1.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[]{
                this.parentBarItem1,
                this.parentBarItem2,
            this.addToSourceCotrol,
            this.saveAll,
            this.Exit});

            this.barItem1.MetroBackColor = ColorTranslator.FromHtml("#eaf0ff");
            this.barItem1.MetroColor = Color.Red;
        }

        void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        #region Color Customization
        /// <summary>
        /// Method to Customize Autohide tab
        /// </summary>
        void UpdateAutohideColor()
        {
            if (this.dockingManager1.ControlsArray != null)
            {
                DockHost dockHost = this.dockingManager1.ControlsArray[0].Parent as DockHost;

                DockHostController dockHostController = dockHost.InternalController as DockHostController;

                MainFormController mainFormController = dockHostController.ParentController.ToplevelController as MainFormController;

                AHTabControl ahTabCtrlLeft = mainFormController.GetAHTabControl(DockingStyle.Left);

                ahTabCtrlLeft.TabPanelBackColor = ColorTranslator.FromHtml("#293955");
                AHTabControl ahTabCtrlBottom = mainFormController.GetAHTabControl(DockingStyle.Bottom);

                ahTabCtrlBottom.TabPanelBackColor = ColorTranslator.FromHtml("#293955");

                AHTabControl ahTabCtrlRight = mainFormController.GetAHTabControl(DockingStyle.Right);

                ahTabCtrlRight.TabPanelBackColor = ColorTranslator.FromHtml("#293955");

                AHTabControl ahTabCtrlTop = mainFormController.GetAHTabControl(DockingStyle.Top);

                ahTabCtrlTop.TabPanelBackColor = ColorTranslator.FromHtml("#293955");
            }
        }
        /// <summary>
        /// Method to update Color for Controls
        /// </summary>
        public void UpdateColors()
        {

            this.tabControlAdv1.TabStyle = typeof(TabRendererMetro);
            this.editControl1.Font = new System.Drawing.Font("Consolas", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dockingManager1.VisualStyle = VisualStyle.Metro;
            this.dockingManager1.MetroCaptionColor = (ColorTranslator.FromHtml("#000000"));
            this.dockingManager1.MetroButtonColor = (ColorTranslator.FromHtml("#000000"));
            this.dockingManager1.ActiveCaptionBackground = new Syncfusion.Drawing.BrushInfo(ColorTranslator.FromHtml("#fff29d"));
            this.dockingManager1.InActiveCaptionBackground = new Syncfusion.Drawing.BrushInfo(ColorTranslator.FromHtml("#4d6082"));
            this.dockingManager1.AutoHideEnabled = true;
            this.treeViewAdv1.FullRowSelect = true;
            this.tabControlAdv1.ActiveTabColor = ColorTranslator.FromHtml("#fff29d");
            this.tabControlAdv1.ActiveTabForeColor = ColorTranslator.FromHtml("#000000");
            this.tabControlAdv1.TabPanelBackColor = ColorTranslator.FromHtml("#293955");
            this.tabControlAdv1.ActiveTabFont = new System.Drawing.Font("Arial", 8.7F);
            this.tabControlAdv1.CloseButtonForeColor = ColorTranslator.FromHtml("#000000");
            this.dockingManager1.MetroSplitterBackColor = ColorTranslator.FromHtml("#293955");
            this.dockingManager1.AutoHideTabForeColor = Color.Black;
            this.dockingManager1.MetroColor = ColorTranslator.FromHtml("#fff29d");
            this.treeViewAdv1.BorderStyle = BorderStyle.None;
            this.dockingManager1.InActiveCaptionButtonForeColor = Color.White;
            this.panel1.BorderStyle = BorderStyle.None;
            this.mainFrameBarManager1.MetroColor = ColorTranslator.FromHtml("#fff29d");
            this.dockingManager1.ActiveDockTabBackColor = Color.White;
            this.dockingManager1.DockTabBackColor = ColorTranslator.FromHtml("#4d6082");
            this.dockingManager1.ActiveDockTabForeColor = Color.Black;
            this.dockingManager1.DockTabForeColor = Color.White;
            this.dockingManager1.DockTabSeparatorColor = Color.Transparent;
            this.dockingManager1.DockTabPanelBackColor = ColorTranslator.FromHtml("#2a3a56");
            this.treeViewAdv1.Office2016ScrollBars = true;
            this.treeViewAdv1.GridOfficeScrollBars = OfficeScrollBars.Office2016;
            this.treeViewAdv1.Office2016ScrollBarsColorScheme = ScrollBarOffice2016ColorScheme.Colorful;
            this.treeViewAdv1.Office2016ColorfulColorTable.ScrollerBackground = ColorTranslator.FromHtml("#e8e8ec");
            this.treeViewAdv1.Office2016ColorfulColorTable.ThumbNormal = ColorTranslator.FromHtml("#c2c3c9");
            this.treeViewAdv1.Office2016ColorfulColorTable.ThumbPushed = ColorTranslator.FromHtml("#5b5b5b");
            this.treeViewAdv1.Office2016ColorfulColorTable.ArrowNormal = ColorTranslator.FromHtml("#868999");
            this.treeViewAdv1.Office2016ColorfulColorTable.ArrowPushed = ColorTranslator.FromHtml("#1c97ea");
            this.treeViewAdv1.Office2016ColorfulColorTable.ArrowNormalBackGround = ColorTranslator.FromHtml("#e8e8ec");
            this.treeViewAdv1.Office2016ColorfulColorTable.ArrowNormalBackGround = ColorTranslator.FromHtml("#e8e8ec");
            this.treeViewAdv1.Office2016ColorfulColorTable.ArrowNormalBorderColor = ColorTranslator.FromHtml("#e8e8ec");
            this.treeViewAdv1.Office2016ColorfulColorTable.ArrowCheckedBorderColor = ColorTranslator.FromHtml("#e8e8ec");

        }
        #endregion

        #region Items under EditbarItem

        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem undo;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem redo;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem cut;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem copy;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem pasteSpecial;

        public void AddItemsUnderEdit()
        {
            // 
            // undo
            // 
            this.undo = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.undo.BarName = "Undo";
            this.undo.CategoryIndex = 1;
            this.undo.ID = "Undo";
            this.undo.ShowToolTipInPopUp = false;
            this.undo.SizeToFit = true;
            this.undo.Text = "解开";
            this.undo.ImageList = this.imageList2;
            this.undo.ImageIndex = 6;
            // 
            // redo
            // 
            this.redo = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.redo.BarName = "Redo";
            this.redo.CategoryIndex = 1;
            this.redo.ID = "Redo";
            this.redo.ShowToolTipInPopUp = false;
            this.redo.SizeToFit = true;
            this.redo.Text = "重做";
            this.redo.ImageList = this.imageList2;
            this.redo.ImageIndex = 7;
            // 
            // Cut
            // 
            this.cut = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.cut.BarName = "addToSourceCotrol";
            this.cut.CategoryIndex = 1;
            this.cut.ID = "";
            this.cut.ShowToolTipInPopUp = false;
            this.cut.SizeToFit = true;
            this.cut.Text = "切";
            this.cut.ImageList = this.imageList4;
            this.cut.ImageIndex = 39;

            ///
            /// Copy
            ///
            this.copy = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.copy.BarName = "SaveAll";
            this.copy.CategoryIndex = 1;
            this.copy.ID = "";
            this.copy.ShowToolTipInPopUp = false;
            this.copy.SizeToFit = true;
            this.copy.Text = "复制";
            this.copy.ImageList = this.imageList4;
            this.copy.ImageIndex = 35;
            ///
            /// Paste 
            ///
            this.pasteSpecial = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.pasteSpecial.BarName = "Exit";
            this.pasteSpecial.CategoryIndex = 1;
            this.pasteSpecial.ID = "";
            this.pasteSpecial.ShowToolTipInPopUp = false;
            this.pasteSpecial.SizeToFit = true;
            this.pasteSpecial.Text = "特殊粘贴";
            this.pasteSpecial.ImageList = this.imageList4;
            this.pasteSpecial.ImageIndex = 25;

            this.mainFrameBarManager1.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {          
            this.undo,
            this.redo,
            this.cut,
            this.copy,
            this.pasteSpecial});

            this.barItem2.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[]{
                this.undo,
            this.redo,
            this.cut,
            this.copy,
            this.pasteSpecial}); ;

            this.barItem2.MetroBackColor = ColorTranslator.FromHtml("#eaf0ff");
        }

        #endregion

        #region Items under View barItem

        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem Code;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem Designer;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem Open;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem SolutionExplorer;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem TeamExplorer;

        public void AddItemsUnderView()
        {
            // 
            // Code
            // 
            this.Code = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.Code.BarName = "Undo";
            this.Code.CategoryIndex = 1;
            this.Code.ID = "Undo";
            this.Code.ShowToolTipInPopUp = false;
            this.Code.SizeToFit = true;
            this.Code.Text = "码";

            // 
            // Designer
            // 
            this.Designer = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.Designer.BarName = "Redo";
            this.Designer.CategoryIndex = 1;
            this.Designer.ID = "Redo";
            this.Designer.ShowToolTipInPopUp = false;
            this.Designer.SizeToFit = true;
            this.Designer.Text = "设计师";

            // 
            // Open
            // 
            this.Open = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.Open.BarName = "addToSourceCotrol";
            this.Open.CategoryIndex = 1;
            this.Open.ID = "";
            this.Open.ShowToolTipInPopUp = false;
            this.Open.SizeToFit = true;
            this.Open.Text = "打开";
            this.Open.ImageList = this.imageList2;
            this.Open.ImageIndex = 3;

            ///
            /// SolutionExplorer
            ///
            this.SolutionExplorer = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.SolutionExplorer.BarName = "SolutionExplorer";
            this.SolutionExplorer.CategoryIndex = 1;
            this.SolutionExplorer.ID = "";
            this.SolutionExplorer.ShowToolTipInPopUp = false;
            this.SolutionExplorer.SizeToFit = true;
            this.SolutionExplorer.Text = "解决方案资源管理器";
            this.SolutionExplorer.ImageIndex = 60;
            this.SolutionExplorer.ImageList = this.imageList3;

            ///
            /// Team Explorer 
            ///
            this.TeamExplorer = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.TeamExplorer.BarName = "TeamExplorer";
            this.TeamExplorer.CategoryIndex = 1;
            this.TeamExplorer.ID = "";
            this.TeamExplorer.ShowToolTipInPopUp = false;
            this.TeamExplorer.SizeToFit = true;
            this.TeamExplorer.Text = "团队资源管理器";
            this.TeamExplorer.ImageIndex = 58;
            this.TeamExplorer.ImageList = this.imageList3;

            this.mainFrameBarManager1.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {          
            this.Code,
            this.Designer,
            this.Open,
            this.SolutionExplorer,
            this.TeamExplorer});

            this.viewItem.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[]{
             this.Code,
            this.Designer,
            this.Open,
            this.SolutionExplorer,
            this.TeamExplorer}); ;

            this.viewItem.MetroBackColor = ColorTranslator.FromHtml("#eaf0ff");
        }

        #endregion

        #region Items under Project barItem

        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem WindowsForms;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem UserControl;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem Component;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem addclass;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem newDataSource;

        public void AddItemsUnderProject()
        {
            // 
            // WindowsForms
            // 
            this.WindowsForms = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.WindowsForms.BarName = "WindowsForms";
            this.WindowsForms.CategoryIndex = 1;
            this.WindowsForms.ID = "WindowsForms";
            this.WindowsForms.ShowToolTipInPopUp = false;
            this.WindowsForms.SizeToFit = true;
            this.WindowsForms.Text = "添加表格...";
            this.WindowsForms.ImageIndex = 69;
            this.WindowsForms.ImageList = this.imageList3;
            // 
            // UserControl
            // 
            this.UserControl = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.UserControl.BarName = "Redo";
            this.UserControl.CategoryIndex = 1;
            this.UserControl.ID = "Redo";
            this.UserControl.ShowToolTipInPopUp = false;
            this.UserControl.SizeToFit = true;
            this.UserControl.Text = "添加用户控件...";
            this.UserControl.ImageIndex = 68;
            this.UserControl.ImageList = this.imageList3;

            // 
            // Component
            // 
            this.Component = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.Component.BarName = "addToSourceCotrol";
            this.Component.CategoryIndex = 1;
            this.Component.ID = "";
            this.Component.ShowToolTipInPopUp = false;
            this.Component.SizeToFit = true;
            this.Component.Text = "添加组件...";
            this.Component.ImageIndex = 65;
            this.Component.ImageList = this.imageList3;
            ///
            /// addclass
            ///
            this.addclass = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.addclass.BarName = "addclass";
            this.addclass.CategoryIndex = 1;
            this.addclass.ID = "";
            this.addclass.ShowToolTipInPopUp = false;
            this.addclass.SizeToFit = true;
            this.addclass.Text = "添加类...";
            this.addclass.ImageIndex = 64;
            this.addclass.ImageList = this.imageList3;

            ///
            /// newDataSource
            ///
            this.newDataSource = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.newDataSource.BarName = "TeamExplorer";
            this.newDataSource.CategoryIndex = 1;
            this.newDataSource.ID = "";
            this.newDataSource.ShowToolTipInPopUp = false;
            this.newDataSource.SizeToFit = true;
            this.newDataSource.Text = "添加数据源...";


            this.mainFrameBarManager1.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {          
            this.WindowsForms,
            this.UserControl,
            this.Component,
            this.addclass,
            this.newDataSource});

            this.projectItem.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[]{
            this.WindowsForms,
            this.UserControl,
            this.Component,
            this.addclass,
            this.newDataSource}); ;

            this.projectItem.MetroBackColor = ColorTranslator.FromHtml("#eaf0ff");
        }

        #endregion

        #region Items under Build barItem

        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem build;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem rebuild;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem clean;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem batchbuild;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem configManager;

        public void AddItemsUnderBuild()
        {
            // 
            // build
            // 
            this.build = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.build.BarName = "build";
            this.build.CategoryIndex = 1;
            this.build.ID = "build";
            this.build.ShowToolTipInPopUp = false;
            this.build.SizeToFit = true;
            this.build.Text = "构建解决方案";
            this.build.ImageIndex = 72;
            this.build.ImageList = this.imageList3;
            // 
            // rebuild
            // 
            this.rebuild = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.rebuild.BarName = "rebuild";
            this.rebuild.CategoryIndex = 1;
            this.rebuild.ID = "rebuild";
            this.rebuild.ShowToolTipInPopUp = false;
            this.rebuild.SizeToFit = true;
            this.rebuild.Text = "重新生成解决方案";

            // 
            // Clean
            // 
            this.clean = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.clean.BarName = "clean";
            this.clean.CategoryIndex = 1;
            this.clean.ID = "";
            this.clean.ShowToolTipInPopUp = false;
            this.clean.SizeToFit = true;
            this.clean.Text = "清理解决方案";

            ///
            /// batchbuild
            ///
            this.batchbuild = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.batchbuild.BarName = "batchbuild";
            this.batchbuild.CategoryIndex = 1;
            this.batchbuild.ID = "";
            this.batchbuild.ShowToolTipInPopUp = false;
            this.batchbuild.SizeToFit = true;
            this.batchbuild.Text = "批量构建...";
            this.batchbuild.ImageIndex = 72;
            this.batchbuild.ImageList = this.imageList3;

            ///
            /// configManager
            ///
            this.configManager = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.configManager.BarName = "configManager";
            this.configManager.CategoryIndex = 1;
            this.configManager.ID = "configManager";
            this.configManager.ShowToolTipInPopUp = false;
            this.configManager.SizeToFit = true;
            this.configManager.Text = "配置管理";

            this.mainFrameBarManager1.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {          
            this.build,
            this.rebuild,
            this.clean,
            this.batchbuild,
            this.configManager});

            this.buildItem.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[]{
            this.build,
            this.rebuild,
            this.clean,
            this.batchbuild,
            this.configManager}); ;

            this.buildItem.MetroBackColor = ColorTranslator.FromHtml("#eaf0ff");
        }

        #endregion

        #region Items under Debug barItem

        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem startdebug;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem WoDebug;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem attachtoprocess;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem othertarget;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem breakonclr;

        public void AddItemsUnderDebug()
        {
            // 
            // startdebug
            // 
            this.startdebug = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.startdebug.BarName = "Undo";
            this.startdebug.CategoryIndex = 1;
            this.startdebug.ID = "Undo";
            this.startdebug.ShowToolTipInPopUp = false;
            this.startdebug.SizeToFit = true;
            this.startdebug.Text = "开始调试";
            this.startdebug.ImageIndex = 113;
            this.startdebug.ImageList = this.imageList3;
            // 
            // WoDebug
            // 
            this.WoDebug = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.WoDebug.BarName = "Redo";
            this.WoDebug.CategoryIndex = 1;
            this.WoDebug.ID = "Redo";
            this.WoDebug.ShowToolTipInPopUp = false;
            this.WoDebug.SizeToFit = true;
            this.WoDebug.Text = "不开始调试";
            this.WoDebug.ImageIndex = 81;
            this.WoDebug.ImageList = this.imageList3;
            // 
            // attachtoprocess
            // 
            this.attachtoprocess = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.attachtoprocess.BarName = "addToSourceCotrol";
            this.attachtoprocess.CategoryIndex = 1;
            this.attachtoprocess.ID = "";
            this.attachtoprocess.ShowToolTipInPopUp = false;
            this.attachtoprocess.SizeToFit = true;
            this.attachtoprocess.Text = "附加到进程...";
            this.attachtoprocess.ImageIndex = 74;
            this.attachtoprocess.ImageList = this.imageList3;

            ///
            /// othertarget
            ///
            this.othertarget = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.othertarget.BarName = "othertarget";
            this.othertarget.CategoryIndex = 1;
            this.othertarget.ID = "";
            this.othertarget.ShowToolTipInPopUp = false;
            this.othertarget.SizeToFit = true;
            this.othertarget.Text = "其他调试";

            ///
            /// breakonclr
            ///
            this.breakonclr = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.breakonclr.BarName = "breakonclr";
            this.breakonclr.CategoryIndex = 1;
            this.breakonclr.ID = "";
            this.breakonclr.ShowToolTipInPopUp = false;
            this.breakonclr.SizeToFit = true;
            this.breakonclr.Text = "打破例外";

            this.mainFrameBarManager1.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {          
            this.startdebug,
            this.WoDebug,
            this.attachtoprocess,
            this.othertarget,
            this.breakonclr});

            this.debugItem.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[]{
            this.startdebug,
            this.WoDebug,
            this.attachtoprocess,
            this.othertarget,
            this.breakonclr}); ;

            this.debugItem.MetroBackColor = ColorTranslator.FromHtml("#eaf0ff");
        }

        #endregion

        #region Items under Team barItem

        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem connectTeam;

        public void AddItemsUnderTeam()
        {
            // 
            // connectTeam
            // 
            this.connectTeam = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.connectTeam.BarName = "connectTeam";
            this.connectTeam.CategoryIndex = 1;
            this.connectTeam.ID = "connectTeam";
            this.connectTeam.ShowToolTipInPopUp = false;
            this.connectTeam.SizeToFit = true;
            this.connectTeam.Text = "连接到服务器团队...";
            this.connectTeam.ImageIndex = 91;
            this.connectTeam.ImageList = this.imageList3;

            this.mainFrameBarManager1.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {          
            this.connectTeam});

            this.teamItem.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[]{
            this.connectTeam}); ;

            this.teamItem.MetroBackColor = ColorTranslator.FromHtml("#eaf0ff");

            this.teamItem.Text = "球队";
        }

        #endregion

        #region Items under Format barItem

        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem align;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem samesize;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem hzlSpacing;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem verticalspacing;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem lckControls;

        public void AddItemsUnderFormat()
        {
            // 
            // align
            // 
            this.align = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.align.BarName = "align";
            this.align.CategoryIndex = 1;
            this.align.ID = "align";
            this.align.ShowToolTipInPopUp = false;
            this.align.SizeToFit = true;
            this.align.Text = "对齐";

            // 
            // samesize
            // 
            this.samesize = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.samesize.BarName = "samesize";
            this.samesize.CategoryIndex = 1;
            this.samesize.ID = "samesize";
            this.samesize.ShowToolTipInPopUp = false;
            this.samesize.SizeToFit = true;
            this.samesize.Text = "使大小相同";

            // 
            // hzlSpacing
            // 
            this.hzlSpacing = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.hzlSpacing.BarName = "hzlSpacing";
            this.hzlSpacing.CategoryIndex = 1;
            this.hzlSpacing.ID = "hzlSpacing";
            this.hzlSpacing.ShowToolTipInPopUp = false;
            this.hzlSpacing.SizeToFit = true;
            this.hzlSpacing.Text = "水平间距";

            ///
            /// verticalspacing
            ///
            this.verticalspacing = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.verticalspacing.BarName = "verticalspacing";
            this.verticalspacing.CategoryIndex = 1;
            this.verticalspacing.ID = "verticalspacing";
            this.verticalspacing.ShowToolTipInPopUp = false;
            this.verticalspacing.SizeToFit = true;
            this.verticalspacing.Text = "垂直间距";

            ///
            /// lckControls
            ///
            this.lckControls = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.lckControls.BarName = "lckControls";
            this.lckControls.CategoryIndex = 1;
            this.lckControls.ID = "lckControls";
            this.lckControls.ShowToolTipInPopUp = false;
            this.lckControls.SizeToFit = true;
            this.lckControls.Text = "锁控制";

            this.mainFrameBarManager1.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {          
            this.align,
            this.samesize,
            this.hzlSpacing,
            this.verticalspacing,
            this.lckControls});

            this.formatItem.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[]{
            this.align,
            this.samesize,
            this.hzlSpacing,
            this.verticalspacing,
            this.lckControls}); ;

            this.formatItem.MetroBackColor = ColorTranslator.FromHtml("#eaf0ff");
        }

        #endregion

        #region Items under Tools barItem

        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem WinPhone;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem attachprocess;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem conectDB;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem connectserver;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem addsharept;

        public void AddItemsUnderTools()
        {
            // 
            // WinPhone
            // 
            this.WinPhone = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.WinPhone.BarName = "Undo";
            this.WinPhone.CategoryIndex = 1;
            this.WinPhone.ID = "Undo";
            this.WinPhone.ShowToolTipInPopUp = false;
            this.WinPhone.SizeToFit = true;
            this.WinPhone.Text = "视窗 8.1";

            // 
            // attachprocess
            // 
            this.attachprocess = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.attachprocess.BarName = "attachprocess";
            this.attachprocess.CategoryIndex = 1;
            this.attachprocess.ID = "attachprocess";
            this.attachprocess.ShowToolTipInPopUp = false;
            this.attachprocess.SizeToFit = true;
            this.attachprocess.Text = "附加到进程";

            // 
            // conectDB
            // 
            this.conectDB = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.conectDB.BarName = "conectDB";
            this.conectDB.CategoryIndex = 1;
            this.conectDB.ID = "";
            this.conectDB.ShowToolTipInPopUp = false;
            this.conectDB.SizeToFit = true;
            this.conectDB.Text = "连接到数据库...";

            ///
            /// connectserver
            ///
            this.connectserver = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.connectserver.BarName = "connectserver";
            this.connectserver.CategoryIndex = 1;
            this.connectserver.ID = "";
            this.connectserver.ShowToolTipInPopUp = false;
            this.connectserver.SizeToFit = true;
            this.connectserver.Text = "连接到服务器...";

            ///
            /// addsharept
            ///
            this.addsharept = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.addsharept.BarName = "addsharept";
            this.addsharept.CategoryIndex = 1;
            this.addsharept.ID = "";
            this.addsharept.ShowToolTipInPopUp = false;
            this.addsharept.SizeToFit = true;
            this.addsharept.Text = "添加共享点...";

            this.mainFrameBarManager1.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {          
            this.WinPhone,
            this.attachprocess,
            this.conectDB,
            this.connectserver,
            this.addsharept});

            this.toolsItem.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[]{
            this.WinPhone,
            this.attachprocess,
            this.conectDB,
            this.connectserver,
            this.addsharept}); ;

            this.toolsItem.MetroBackColor = ColorTranslator.FromHtml("#eaf0ff");
        }

        #endregion

        #region Items under Test barItem

        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem run;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem debug;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem playlist;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem setting;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem profiletest;

        public void AddItemsUnderTest()
        {
            // 
            // run
            // 
            this.run = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.run.BarName = "Undo";
            this.run.CategoryIndex = 1;
            this.run.ID = "Undo";
            this.run.ShowToolTipInPopUp = false;
            this.run.SizeToFit = true;
            this.run.Text = "跑";

            // 
            // debug
            // 
            this.debug = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.debug.BarName = "Redo";
            this.debug.CategoryIndex = 1;
            this.debug.ID = "Redo";
            this.debug.ShowToolTipInPopUp = false;
            this.debug.SizeToFit = true;
            this.debug.Text = "调试";

            // 
            // playlist
            // 
            this.playlist = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.playlist.BarName = "addToSourceCotrol";
            this.playlist.CategoryIndex = 1;
            this.playlist.ID = "";
            this.playlist.ShowToolTipInPopUp = false;
            this.playlist.SizeToFit = true;
            this.playlist.Text = "播放列表";

            ///
            /// setting
            ///
            this.setting = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.setting.BarName = "setting";
            this.setting.CategoryIndex = 1;
            this.setting.ID = "";
            this.setting.ShowToolTipInPopUp = false;
            this.setting.SizeToFit = true;
            this.setting.Text = "设置";

            ///
            /// Profiletest
            ///
            this.profiletest = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.profiletest.BarName = "TeamExplorer";
            this.profiletest.CategoryIndex = 1;
            this.profiletest.ID = "";
            this.profiletest.ShowToolTipInPopUp = false;
            this.profiletest.SizeToFit = true;
            this.profiletest.Text = "简介测试";
            this.profiletest.Enabled = false;

            this.mainFrameBarManager1.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {          
            this.run,
            this.debug,
            this.playlist,
            this.setting,
            this.profiletest});

            this.testItem.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[]{
            this.run,
            this.debug,
            this.playlist,
            this.setting,
            this.profiletest}); ;

            this.teamItem.MetroBackColor = ColorTranslator.FromHtml("#eaf0ff");
        }

        #endregion

        #region Items under Analyze barItem

        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem performance;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem profiler;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem codeMatrices;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem codeMatricessolution;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem analyzesolution;

        public void AddItemsUnderAnalyze()
        {
            // 
            // performance
            // 
            this.performance = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.performance.BarName = "Performance";
            this.performance.CategoryIndex = 1;
            this.performance.ID = "Performance";
            this.performance.ShowToolTipInPopUp = false;
            this.performance.SizeToFit = true;
            this.performance.Text = "性能";

            // 
            // profiler
            // 
            this.profiler = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.profiler.BarName = "profiler";
            this.profiler.CategoryIndex = 1;
            this.profiler.ID = "profiler";
            this.profiler.ShowToolTipInPopUp = false;
            this.profiler.SizeToFit = true;
            this.profiler.Text = "探查";

            // 
            // codeMatrices
            // 
            this.codeMatrices = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.codeMatrices.BarName = "codemetricesolution";
            this.codeMatrices.CategoryIndex = 1;
            this.codeMatrices.ID = "";
            this.codeMatrices.ShowToolTipInPopUp = false;
            this.codeMatrices.SizeToFit = true;
            this.codeMatrices.Text = "码矩阵";

            ///
            /// codeMatricessolution
            ///
            this.codeMatricessolution = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.codeMatricessolution.BarName = "codemetrice";
            this.codeMatricessolution.CategoryIndex = 1;
            this.codeMatricessolution.ID = "";
            this.codeMatricessolution.ShowToolTipInPopUp = false;
            this.codeMatricessolution.SizeToFit = true;
            this.codeMatricessolution.Text = "解";

            ///
            /// analyzesolution
            ///
            this.analyzesolution = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.analyzesolution.BarName = "analyze";
            this.analyzesolution.CategoryIndex = 1;
            this.analyzesolution.ID = "";
            this.analyzesolution.ShowToolTipInPopUp = false;
            this.analyzesolution.SizeToFit = true;
            this.analyzesolution.Text = "分析解决方案";

            this.mainFrameBarManager1.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {          
            this.performance,
            this.profiler,
            this.codeMatrices,
            this.codeMatricessolution,
            this.analyzesolution});

            this.analyzeItem.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[]{
            this.performance,
            this.profiler,
            this.codeMatrices,
            this.codeMatricessolution,
            this.analyzesolution}); ;

            this.analyzeItem.MetroBackColor = ColorTranslator.FromHtml("#eaf0ff");
            this.analyzeItem.MetroColor = ColorTranslator.FromHtml("#fdf4bf");
        }

        #endregion

        #region Items under Windows barItem

        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem newwindow;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem split;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem floating;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem dock;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem autohide;

        public void AddItemsUnderWindows()
        {
            // 
            // newwindow
            // 
            this.newwindow = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.newwindow.BarName = "New Window";
            this.newwindow.CategoryIndex = 1;
            this.newwindow.ID = "newwindow";
            this.newwindow.ShowToolTipInPopUp = false;
            this.newwindow.SizeToFit = true;
            this.newwindow.Text = "级联";
            this.newwindow.ImageIndex = 50;
            this.newwindow.ImageList = this.imageList3;
            // 
            // split
            // 
            this.split = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.split.BarName = "Split";
            this.split.CategoryIndex = 1;
            this.split.ID = "Redo";
            this.split.ShowToolTipInPopUp = false;
            this.split.SizeToFit = true;
            this.split.Text = "新的水平制表";
            this.split.ImageIndex = 53;
            this.split.ImageList = this.imageList3;
            // 
            // floating
            // 
            this.floating = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.floating.BarName = "Float";
            this.floating.CategoryIndex = 1;
            this.floating.ID = "";
            this.floating.ShowToolTipInPopUp = false;
            this.floating.SizeToFit = true;
            this.floating.Text = "新的垂直选项卡";
            this.floating.ImageIndex = 88;
            this.floating.ImageList = this.imageList3;

            ///
            /// dock
            ///
            this.dock = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.dock.BarName = "Dock";
            this.dock.CategoryIndex = 1;
            this.dock.ID = "";
            this.dock.ShowToolTipInPopUp = false;
            this.dock.SizeToFit = true;
            this.dock.Text = "关闭所有窗口";
            this.dock.ImageIndex = 84;
            this.dock.ImageList = this.imageList3;
            ///
            /// autohide
            ///
            this.autohide = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.autohide.BarName = "TeamExplorer";
            this.autohide.CategoryIndex = 1;
            this.autohide.ID = "";
            this.autohide.ShowToolTipInPopUp = false;
            this.autohide.SizeToFit = true;
            this.autohide.Text = "自动隐藏";

            this.mainFrameBarManager1.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {          
            this.newwindow,
            this.split,
            this.floating,
            this.dock,
            this.autohide});

            this.barItem4.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[]{
             this.newwindow,
            this.split,
            this.floating,
            this.dock,
            this.autohide}); ;

            this.barItem4.MetroBackColor = ColorTranslator.FromHtml("#eaf0ff");
        }

        #endregion

        #region Items under Help barItem

        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem viewhelp;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem addandremove;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem customerfeedback;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem registerproduct;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem techsupport;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem about;

        public void AddItemsUnderHelp()
        {
            // 
            // viewhelp
            // 
            this.viewhelp = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.viewhelp.BarName = "viewhelp";
            this.viewhelp.CategoryIndex = 1;
            this.viewhelp.ID = "viewhelp";
            this.viewhelp.ShowToolTipInPopUp = false;
            this.viewhelp.SizeToFit = true;
            this.viewhelp.Text = "View Help                                     Ctrl+F1";

            // 
            // addandremove
            // 
            this.addandremove = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.addandremove.BarName = "Redo";
            this.addandremove.CategoryIndex = 1;
            this.addandremove.ID = "Redo";
            this.addandremove.ShowToolTipInPopUp = false;
            this.addandremove.SizeToFit = true;
            this.addandremove.Text = "Add and Remove Help Content    Ctrl+Alt+F1";

            // 
            // customerfeedback
            // 
            this.customerfeedback = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.customerfeedback.BarName = "addToSourceCotrol";
            this.customerfeedback.CategoryIndex = 1;
            this.customerfeedback.ID = "";
            this.customerfeedback.ShowToolTipInPopUp = false;
            this.customerfeedback.SizeToFit = true;
            this.customerfeedback.Text = "Customer Feedback options...";

            ///
            /// registerproduct
            ///
            this.registerproduct = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.registerproduct.BarName = "registerproduct";
            this.registerproduct.CategoryIndex = 1;
            this.registerproduct.ID = "";
            this.registerproduct.ShowToolTipInPopUp = false;
            this.registerproduct.SizeToFit = true;
            this.registerproduct.Text = "Register Products";

            ///
            /// techsupport
            ///
            this.techsupport = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.techsupport.BarName = "TeamExplorer";
            this.techsupport.CategoryIndex = 1;
            this.techsupport.ID = "";
            this.techsupport.ShowToolTipInPopUp = false;
            this.techsupport.SizeToFit = true;
            this.techsupport.Text = "Technical Support";

            ///
            /// About
            ///
            this.about = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.about.BarName = "TeamExplorer";
            this.about.CategoryIndex = 1;
            this.about.ID = "";
            this.about.ShowToolTipInPopUp = false;
            this.about.SizeToFit = true;
            this.about.Text = "关于";
            this.about.ImageIndex = 45;
            this.about.ImageList = this.imageList3;

            this.mainFrameBarManager1.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {          
            this.viewhelp,
            this.addandremove,
            this.customerfeedback,
            this.registerproduct,
            this.techsupport,
            this.about});

            this.barItem5.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[]{            
            this.about}); ;

            this.barItem5.MetroBackColor = ColorTranslator.FromHtml("#eaf0ff");
        }

        #endregion

        void treeViewAdv1_MouseMove(object sender, MouseEventArgs e)
        {
            if ((sender as TreeViewAdv) == this.treeViewAdv1)
            {
                for (int i = 0; i < this.treeViewAdv1.Nodes.Count; i++)
                {
                    //this.treeViewAdv1.Nodes[i].Background = new Syncfusion.Drawing.BrushInfo(Color.FromArgb(0, 255, 255, 255));
                    foreach (TreeNodeAdv item in this.treeViewAdv1.Nodes[i].Nodes)
                    {
                        item.Background = new Syncfusion.Drawing.BrushInfo(Color.FromArgb(0, 255, 255, 255));
                    }
                }
                if (this.treeViewAdv1.GetNodeAtPoint(new Point(e.X, e.Y)) != null)
                {
                    TreeNodeAdv node = this.treeViewAdv1.GetNodeAtPoint(new Point(e.X, e.Y));
                    if (!this.treeViewAdv1.Nodes.Contains(node))
                        node.Background = new Syncfusion.Drawing.BrushInfo(ColorTranslator.FromHtml("#fdf4bf"));
                }
            }
        }

        void treeViewAdv1_MouseLeave(object sender, EventArgs e)
        {
            if ((sender as TreeViewAdv) == this.treeViewAdv1)
            {
                //this.treeViewAdv1.Nodes[0].Background = new Syncfusion.Drawing.BrushInfo(Color.FromArgb(0, 255, 255, 255));
                for (int i = 0; i < this.treeViewAdv1.Nodes.Count; i++)
                {
                    foreach (TreeNodeAdv item in this.treeViewAdv1.Nodes[i].Nodes)
                    {
                        item.Background = new Syncfusion.Drawing.BrushInfo(Color.White);

                        foreach (TreeNodeAdv node in item.Nodes)
                        {
                            node.Background = new Syncfusion.Drawing.BrushInfo(Color.White);
                        }
                    }
                }

            }
        }

        private string GetIconFile(string bitmapName)
        {
            for (int n = 0; n < 10; n++)
            {
                if (System.IO.File.Exists(bitmapName))
                    return bitmapName;

                bitmapName = @"..\" + bitmapName;
            }

            return bitmapName;
        }

        private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem viewItem;
        private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem projectItem;
        private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem buildItem;
        private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem debugItem;
        private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem teamItem;
        private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem toolsItem;
        private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem formatItem;
        private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem testItem;
        private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem analyzeItem;
        private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem windowItem;  

        public void AddTreeNode()
        {
            Syncfusion.Windows.Forms.Tools.TreeNodeAdv treeNodeAdv25 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdv();
            Syncfusion.Windows.Forms.Tools.TreeNodeAdv treeNodeAdv26 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdv();
            Syncfusion.Windows.Forms.Tools.TreeNodeAdv treeNodeAdv27 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdv();
            Syncfusion.Windows.Forms.Tools.TreeNodeAdv treeNodeAdv28 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdv();
            Syncfusion.Windows.Forms.Tools.TreeNodeAdv treeNodeAdv29 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdv();
            Syncfusion.Windows.Forms.Tools.TreeNodeAdv treeNodeAdv30 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdv();
            Syncfusion.Windows.Forms.Tools.TreeNodeAdv treeNodeAdv31 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdv();
            Syncfusion.Windows.Forms.Tools.TreeNodeAdv GradientLabel = new Syncfusion.Windows.Forms.Tools.TreeNodeAdv();
            Syncfusion.Windows.Forms.Tools.TreeNodeAdv FontComboBox = new Syncfusion.Windows.Forms.Tools.TreeNodeAdv();
            Syncfusion.Windows.Forms.Tools.TreeNodeAdv FontListBox = new Syncfusion.Windows.Forms.Tools.TreeNodeAdv();
            Syncfusion.Windows.Forms.Tools.TreeNodeAdv MulticolumnColumnTreeView = new Syncfusion.Windows.Forms.Tools.TreeNodeAdv();
            Syncfusion.Windows.Forms.Tools.TreeNodeAdv MainFrameBarManager = new Syncfusion.Windows.Forms.Tools.TreeNodeAdv();
            Syncfusion.Windows.Forms.Tools.TreeNodeAdv NumbericTextBox = new Syncfusion.Windows.Forms.Tools.TreeNodeAdv();
            Syncfusion.Windows.Forms.Tools.TreeNodeAdv RadioButtonAdv = new Syncfusion.Windows.Forms.Tools.TreeNodeAdv();
            Syncfusion.Windows.Forms.Tools.TreeNodeAdv RatingControl = new Syncfusion.Windows.Forms.Tools.TreeNodeAdv();
            Syncfusion.Windows.Forms.Tools.TreeNodeAdv RibbonControlAdv = new Syncfusion.Windows.Forms.Tools.TreeNodeAdv();
            Syncfusion.Windows.Forms.Tools.TreeNodeAdv RibbonPanelMergeContainer = new Syncfusion.Windows.Forms.Tools.TreeNodeAdv();
            Syncfusion.Windows.Forms.Tools.TreeNodeAdv SplashControl = new Syncfusion.Windows.Forms.Tools.TreeNodeAdv();
            Syncfusion.Windows.Forms.Tools.TreeNodeAdv StatusBarAdv = new Syncfusion.Windows.Forms.Tools.TreeNodeAdv();
            Syncfusion.Windows.Forms.Tools.TreeNodeAdv TreeViewAdv = new Syncfusion.Windows.Forms.Tools.TreeNodeAdv();
            Syncfusion.Windows.Forms.Tools.TreeNodeAdv ToolStripEx = new Syncfusion.Windows.Forms.Tools.TreeNodeAdv();
            Syncfusion.Windows.Forms.Tools.TreeNodeAdv TabbedMDIManager = new Syncfusion.Windows.Forms.Tools.TreeNodeAdv();
            Syncfusion.Windows.Forms.Tools.TreeNodeAdv TabbedGroupedMDIManager = new Syncfusion.Windows.Forms.Tools.TreeNodeAdv();
            Syncfusion.Windows.Forms.Tools.TreeNodeAdv WizardControl = new Syncfusion.Windows.Forms.Tools.TreeNodeAdv();
            Syncfusion.Windows.Forms.Tools.TreeNodeAdv XpTaskBar = new Syncfusion.Windows.Forms.Tools.TreeNodeAdv();
            Syncfusion.Windows.Forms.Tools.TreeNodeAdv XpToolBar = new Syncfusion.Windows.Forms.Tools.TreeNodeAdv();
            Syncfusion.Windows.Forms.Tools.TreeNodeAdv treeNodeAdv32 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdv();
            Syncfusion.Windows.Forms.Tools.TreeNodeAdv treeNodeAdv33 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdv();
            Syncfusion.Windows.Forms.Tools.TreeNodeAdv treeNodeAdv34 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdv();
            Syncfusion.Windows.Forms.Tools.TreeNodeAdv treeNodeAdv35 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdv();
            Syncfusion.Windows.Forms.Tools.TreeNodeAdv treeNodeAdv36 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdv();
            this.viewItem = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.projectItem = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.buildItem = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.debugItem = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.teamItem = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.formatItem = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.testItem = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.toolsItem = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.analyzeItem = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.windowItem = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();

            treeNodeAdv25.Background = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.Transparent);
            treeNodeAdv25.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv25.EnsureDefaultOptionedChild = true;
            treeNodeAdv25.LeftImageIndices = new int[] { 5 };
            treeNodeAdv25.MultiLine = true;
            treeNodeAdv25.PlusMinusSize = new System.Drawing.Size(9, 9);
            treeNodeAdv25.ShowLine = true;
            treeNodeAdv25.Text = "  编辑控制";
            treeNodeAdv26.Background = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.Transparent);
            treeNodeAdv26.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv26.EnsureDefaultOptionedChild = true;
            treeNodeAdv26.LeftImageIndices = new int[] { 6 };
            treeNodeAdv26.MultiLine = true;
            treeNodeAdv26.PlusMinusSize = new System.Drawing.Size(9, 9);
            treeNodeAdv26.ShowLine = true;
            treeNodeAdv26.Text = "  径向量表";
            treeNodeAdv27.Background = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.Transparent);
            treeNodeAdv27.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv27.EnsureDefaultOptionedChild = true;
            treeNodeAdv27.LeftImageIndices = new int[] { 7 };
            treeNodeAdv27.MultiLine = true;
            treeNodeAdv27.PlusMinusSize = new System.Drawing.Size(9, 9);
            treeNodeAdv27.ShowLine = true;
            treeNodeAdv27.Text = "  径向量表";
            treeNodeAdv28.Background = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.Transparent);
            treeNodeAdv28.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv28.EnsureDefaultOptionedChild = true;
            treeNodeAdv28.LeftImageIndices = new int[] { 22 };
            treeNodeAdv28.MultiLine = true;
            treeNodeAdv28.PlusMinusSize = new System.Drawing.Size(9, 9);
            treeNodeAdv28.ShowLine = true;
            treeNodeAdv28.Text = "  数字仪表";
            treeNodeAdv29.Background = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.Transparent);
            treeNodeAdv29.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv29.EnsureDefaultOptionedChild = true;
            treeNodeAdv29.LeftImageIndices = new int[] { 28 };
            treeNodeAdv29.MultiLine = true;
            treeNodeAdv29.PlusMinusSize = new System.Drawing.Size(9, 9);
            treeNodeAdv29.ShowLine = true;
            treeNodeAdv29.Text = "  线性测量仪";
            treeNodeAdv30.Background = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.Transparent);
            treeNodeAdv30.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv30.EnsureDefaultOptionedChild = true;
            treeNodeAdv30.LeftImageIndices = new int[] { 27 };
            treeNodeAdv30.MultiLine = true;
            treeNodeAdv30.PlusMinusSize = new System.Drawing.Size(9, 9);
            treeNodeAdv30.ShowLine = true;
            treeNodeAdv30.Text = "  控件";

            treeNodeAdv31.Background = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.Transparent);
            treeNodeAdv31.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv31.EnsureDefaultOptionedChild = true;
            treeNodeAdv31.LeftImageIndices = new int[] { 26 };
            treeNodeAdv31.MultiLine = true;
            treeNodeAdv31.PlusMinusSize = new System.Drawing.Size(9, 9);
            treeNodeAdv31.ShowLine = true;
            treeNodeAdv31.Text = "  网格控制";

            GradientLabel.Background = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.Transparent);
            GradientLabel.ChildStyle.EnsureDefaultOptionedChild = true;
            GradientLabel.EnsureDefaultOptionedChild = true;
            GradientLabel.LeftImageIndices = new int[] { 3 };
            GradientLabel.MultiLine = true;
            GradientLabel.PlusMinusSize = new System.Drawing.Size(9, 9);
            GradientLabel.ShowLine = true;
            GradientLabel.Text = "  渐变标签";

            MulticolumnColumnTreeView.Background = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.Transparent);
            MulticolumnColumnTreeView.ChildStyle.EnsureDefaultOptionedChild = true;
            MulticolumnColumnTreeView.EnsureDefaultOptionedChild = true;
            MulticolumnColumnTreeView.LeftImageIndices = new int[] { 29 };
            MulticolumnColumnTreeView.MultiLine = true;
            MulticolumnColumnTreeView.PlusMinusSize = new System.Drawing.Size(9, 9);
            MulticolumnColumnTreeView.ShowLine = true;
            MulticolumnColumnTreeView.Text = "  多列柱树视图";

            MainFrameBarManager.Background = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.Transparent);
            MainFrameBarManager.ChildStyle.EnsureDefaultOptionedChild = true;
            MainFrameBarManager.EnsureDefaultOptionedChild = true;
            MainFrameBarManager.LeftImageIndices = new int[] { 7 };
            MainFrameBarManager.MultiLine = true;
            MainFrameBarManager.PlusMinusSize = new System.Drawing.Size(9, 9);
            MainFrameBarManager.ShowLine = true;
            MainFrameBarManager.Text = "  主框架酒吧经理";

            NumbericTextBox.Background = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.Transparent);
            NumbericTextBox.ChildStyle.EnsureDefaultOptionedChild = true;
            NumbericTextBox.EnsureDefaultOptionedChild = true;
            NumbericTextBox.LeftImageIndices = new int[] { 30 };
            NumbericTextBox.MultiLine = true;
            NumbericTextBox.PlusMinusSize = new System.Drawing.Size(9, 9);
            NumbericTextBox.ShowLine = true;
            NumbericTextBox.Text = "  数字文本框";

            RatingControl.Background = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.Transparent);
            RatingControl.ChildStyle.EnsureDefaultOptionedChild = true;
            RatingControl.EnsureDefaultOptionedChild = true;
            RatingControl.LeftImageIndices = new int[] { 32 };
            RatingControl.MultiLine = true;
            RatingControl.PlusMinusSize = new System.Drawing.Size(9, 9);
            RatingControl.ShowLine = true;
            RatingControl.Text = "  评级控制";

            RibbonControlAdv.Background = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.Transparent);
            RibbonControlAdv.ChildStyle.EnsureDefaultOptionedChild = true;
            RibbonControlAdv.EnsureDefaultOptionedChild = true;
            RibbonControlAdv.LeftImageIndices = new int[] { 33 };
            RibbonControlAdv.MultiLine = true;
            RibbonControlAdv.PlusMinusSize = new System.Drawing.Size(9, 9);
            RibbonControlAdv.ShowLine = true;
            RibbonControlAdv.Text = "  色带控制";

            RibbonPanelMergeContainer.Background = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.Transparent);
            RibbonPanelMergeContainer.ChildStyle.EnsureDefaultOptionedChild = true;
            RibbonPanelMergeContainer.EnsureDefaultOptionedChild = true;
            RibbonPanelMergeContainer.LeftImageIndices = new int[] { 13 };
            RibbonPanelMergeContainer.MultiLine = true;
            RibbonPanelMergeContainer.PlusMinusSize = new System.Drawing.Size(9, 9);
            RibbonPanelMergeContainer.ShowLine = true;
            RibbonPanelMergeContainer.Text = "  数字文本框";

            SplashControl.Background = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.Transparent);
            SplashControl.ChildStyle.EnsureDefaultOptionedChild = true;
            SplashControl.EnsureDefaultOptionedChild = true;
            SplashControl.LeftImageIndices = new int[] { 34 };
            SplashControl.MultiLine = true;
            SplashControl.PlusMinusSize = new System.Drawing.Size(9, 9);
            SplashControl.ShowLine = true;
            SplashControl.Text = "  飞溅控制";

            StatusBarAdv.Background = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.Transparent);
            StatusBarAdv.ChildStyle.EnsureDefaultOptionedChild = true;
            StatusBarAdv.EnsureDefaultOptionedChild = true;
            StatusBarAdv.LeftImageIndices = new int[] { 35 };
            StatusBarAdv.MultiLine = true;
            StatusBarAdv.PlusMinusSize = new System.Drawing.Size(9, 9);
            StatusBarAdv.ShowLine = true;
            StatusBarAdv.Text = "  状态栏高级";

            TreeViewAdv.Background = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.Transparent);
            TreeViewAdv.ChildStyle.EnsureDefaultOptionedChild = true;
            TreeViewAdv.EnsureDefaultOptionedChild = true;
            TreeViewAdv.LeftImageIndices = new int[] { 36 };
            TreeViewAdv.MultiLine = true;
            TreeViewAdv.PlusMinusSize = new System.Drawing.Size(9, 9);
            TreeViewAdv.ShowLine = true;
            TreeViewAdv.Text = "  树视图";

            XpToolBar.Background = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.Transparent);
            XpToolBar.ChildStyle.EnsureDefaultOptionedChild = true;
            XpToolBar.EnsureDefaultOptionedChild = true;
            XpToolBar.LeftImageIndices = new int[] { 39 };
            XpToolBar.MultiLine = true;
            XpToolBar.PlusMinusSize = new System.Drawing.Size(9, 9);
            XpToolBar.ShowLine = true;
            XpToolBar.Text = "  任务栏栏";

            XpTaskBar.Background = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.Transparent);
            XpTaskBar.ChildStyle.EnsureDefaultOptionedChild = true;
            XpTaskBar.EnsureDefaultOptionedChild = true;
            XpTaskBar.LeftImageIndices = new int[] { 38 };
            XpTaskBar.MultiLine = true;
            XpTaskBar.PlusMinusSize = new System.Drawing.Size(9, 9);
            XpTaskBar.ShowLine = true;
            XpTaskBar.Text = "  任务栏";

            ToolStripEx.Background = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.Transparent);
            ToolStripEx.ChildStyle.EnsureDefaultOptionedChild = true;
            ToolStripEx.EnsureDefaultOptionedChild = true;
            ToolStripEx.LeftImageIndices = new int[] { 5 };
            ToolStripEx.MultiLine = true;
            ToolStripEx.PlusMinusSize = new System.Drawing.Size(9, 9);
            ToolStripEx.ShowLine = true;
            ToolStripEx.Text = "  工具条";


            WizardControl.Background = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.Transparent);
            WizardControl.ChildStyle.EnsureDefaultOptionedChild = true;
            WizardControl.EnsureDefaultOptionedChild = true;
            WizardControl.LeftImageIndices = new int[] { 37 };
            WizardControl.MultiLine = true;
            WizardControl.PlusMinusSize = new System.Drawing.Size(9, 9);
            WizardControl.ShowLine = true;
            WizardControl.Text = "  向导控制";

            TabbedGroupedMDIManager.Background = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.Transparent);
            TabbedGroupedMDIManager.ChildStyle.EnsureDefaultOptionedChild = true;
            TabbedGroupedMDIManager.EnsureDefaultOptionedChild = true;
            TabbedGroupedMDIManager.LeftImageIndices = new int[] { 4 };
            TabbedGroupedMDIManager.MultiLine = true;
            TabbedGroupedMDIManager.PlusMinusSize = new System.Drawing.Size(9, 9);
            TabbedGroupedMDIManager.ShowLine = true;
            TabbedGroupedMDIManager.Text = "  标签分组的管理器";

            RadioButtonAdv.Background = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.Transparent);
            RadioButtonAdv.ChildStyle.EnsureDefaultOptionedChild = true;
            RadioButtonAdv.EnsureDefaultOptionedChild = true;
            RadioButtonAdv.LeftImageIndices = new int[] { 3 };
            RadioButtonAdv.MultiLine = true;
            RadioButtonAdv.PlusMinusSize = new System.Drawing.Size(9, 9);
            RadioButtonAdv.ShowLine = true;
            RadioButtonAdv.Text = "  单选按钮";

            FontComboBox.Background = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.Transparent);
            FontComboBox.ChildStyle.EnsureDefaultOptionedChild = true;
            FontComboBox.EnsureDefaultOptionedChild = true;
            FontComboBox.LeftImageIndices = new int[] { 24 };
            FontComboBox.MultiLine = true;
            FontComboBox.PlusMinusSize = new System.Drawing.Size(9, 9);
            FontComboBox.ShowLine = true;
            FontComboBox.Text = "  字体组合框";

            FontListBox.Background = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.Transparent);
            FontListBox.ChildStyle.EnsureDefaultOptionedChild = true;
            FontListBox.EnsureDefaultOptionedChild = true;
            FontListBox.LeftImageIndices = new int[] { 25 };
            FontListBox.MultiLine = true;
            FontListBox.PlusMinusSize = new System.Drawing.Size(9, 9);
            FontListBox.ShowLine = true;
            FontListBox.Text = "  字体列表框";

            treeNodeAdv32.Background = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.Transparent);
            treeNodeAdv32.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv32.EnsureDefaultOptionedChild = true;
            treeNodeAdv32.LeftImageIndices = new int[] { 5 };
            treeNodeAdv32.MultiLine = true;
            treeNodeAdv32.PlusMinusSize = new System.Drawing.Size(9, 9);
            treeNodeAdv32.ShowLine = true;
            treeNodeAdv32.Text = "  编辑控制";
            treeNodeAdv33.Background = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.Transparent);
            treeNodeAdv33.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv33.EnsureDefaultOptionedChild = true;
            treeNodeAdv33.LeftImageIndices = new int[] { 31 };
            treeNodeAdv33.MultiLine = true;
            treeNodeAdv33.PlusMinusSize = new System.Drawing.Size(9, 9);
            treeNodeAdv33.ShowLine = true;
            treeNodeAdv33.Text = "  径向量表";
            treeNodeAdv34.Background = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.Transparent);
            treeNodeAdv34.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv34.EnsureDefaultOptionedChild = true;
            treeNodeAdv34.LeftImageIndices = new int[] { 22 };
            treeNodeAdv34.MultiLine = true;
            treeNodeAdv34.PlusMinusSize = new System.Drawing.Size(9, 9);
            treeNodeAdv34.ShowLine = true;
            treeNodeAdv34.Text = "  线性测量仪";
            treeNodeAdv35.Background = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.Transparent);
            treeNodeAdv35.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv35.EnsureDefaultOptionedChild = true;
            treeNodeAdv35.LeftImageIndices = new int[] { 28 };
            treeNodeAdv35.MultiLine = true;
            treeNodeAdv35.PlusMinusSize = new System.Drawing.Size(9, 9);
            treeNodeAdv35.ShowLine = true;
            treeNodeAdv35.Text = "  线性测量仪";
            treeNodeAdv36.Background = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.Transparent);
            treeNodeAdv36.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv36.EnsureDefaultOptionedChild = true;
            treeNodeAdv36.LeftImageIndices = new int[] { 1 };
            treeNodeAdv36.MultiLine = true;
            treeNodeAdv36.PlusMinusSize = new System.Drawing.Size(9, 9);
            treeNodeAdv36.ShowLine = true;
            treeNodeAdv36.Text = "  针对";

            this.treeViewAdv1.Nodes[1].Nodes.AddRange(new Syncfusion.Windows.Forms.Tools.TreeNodeAdv[] {
            });
            // 
            // viewItem
            // 
            this.viewItem.BarName = "viewItem";
            this.viewItem.CategoryIndex = 0;
            this.viewItem.ID = "View";
            this.viewItem.ShowToolTipInPopUp = false;
            this.viewItem.SizeToFit = true;
            this.viewItem.Text = "视图";
            // 
            // buildItem
            // 
            this.buildItem.BarName = "buildItem";
            this.buildItem.CategoryIndex = 0;
            this.buildItem.ID = "BUILD";
            this.buildItem.ShowToolTipInPopUp = false;
            this.buildItem.SizeToFit = true;
            this.buildItem.Text = "建立";
            // 
            // debugItem
            // 
            this.debugItem.BarName = "debugItem";
            this.debugItem.CategoryIndex = 0;
            this.debugItem.ID = "DEBUG";
            this.debugItem.ShowToolTipInPopUp = false;
            this.debugItem.SizeToFit = true;
            this.debugItem.Text = "&调试";
            // 
            // teamItem
            // 
            this.teamItem.BarName = "debugItem";
            this.teamItem.CategoryIndex = 0;
            this.teamItem.ID = "DEBUG";
            this.teamItem.ShowToolTipInPopUp = false;
            this.teamItem.SizeToFit = true;
            this.teamItem.Text = "&调试";
            // 
            // ToolsItem
            // 
            this.toolsItem.BarName = "toolsItem";
            this.toolsItem.CategoryIndex = 0;
            this.toolsItem.ID = "Tools";
            this.toolsItem.ShowToolTipInPopUp = false;
            this.toolsItem.SizeToFit = true;
            this.toolsItem.Text = "工具";
            // 
            // TestItem
            // 
            this.testItem.BarName = "testItem";
            this.testItem.CategoryIndex = 0;
            this.testItem.ID = "TEST";
            this.testItem.ShowToolTipInPopUp = false;
            this.testItem.SizeToFit = true;
            this.testItem.Text = "测试";
            // 
            // FormatItem
            // 
            this.formatItem.BarName = "formatItem";
            this.formatItem.CategoryIndex = 0;
            this.formatItem.ID = "formatItemfbar1";
            this.formatItem.ShowToolTipInPopUp = false;
            this.formatItem.SizeToFit = true;
            this.formatItem.Text = "测试";
            // 
            // AnalyzeItem
            // 
            this.analyzeItem.BarName = "analyzeItem";
            this.analyzeItem.CategoryIndex = 0;
            this.analyzeItem.ID = "Analyze";
            this.analyzeItem.ShowToolTipInPopUp = false;
            this.analyzeItem.SizeToFit = true;
            this.analyzeItem.Text = "分析";
            
            // 
            // projectItem
            // 
            this.projectItem.BarName = "projectItem";
            this.projectItem.CategoryIndex = 0;
            this.projectItem.ID = "PROJECT";
            this.projectItem.ShowToolTipInPopUp = false;
            this.projectItem.SizeToFit = true;
            this.projectItem.Text = "项目";
            this.treeViewAdv1.Nodes[1].Nodes.AddRange(new Syncfusion.Windows.Forms.Tools.TreeNodeAdv[] {
            treeNodeAdv34,
            treeNodeAdv32,
            FontComboBox,
            FontListBox,
            GradientLabel,
            treeNodeAdv31,
            treeNodeAdv36,
            treeNodeAdv35,
            MulticolumnColumnTreeView,
            MainFrameBarManager,
            NumbericTextBox,
            RadioButtonAdv,
            RatingControl,
            RibbonControlAdv,
            RibbonPanelMergeContainer,
            SplashControl,
            StatusBarAdv,
            TreeViewAdv,
            ToolStripEx,
            TabbedGroupedMDIManager,
            WizardControl,
            XpTaskBar,
            XpToolBar,
            });

            this.mainFrameBarManager1.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {          
            this.viewItem,
            this.projectItem,
            this.buildItem,
            this.debugItem,
            this.teamItem,
            
            this.formatItem,
            this.toolsItem,
            this.testItem,
            this.analyzeItem,            
            this.windowItem
            });

            this.bar1.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
          
            this.viewItem,             
            this.projectItem,
            this.buildItem,
            this.debugItem,            
            this.teamItem,
            this.formatItem,
            this.toolsItem,            
            this.testItem,
            this.analyzeItem,
            this.barItem4,
            this.barItem5});
        }

        private Syncfusion.Windows.Forms.Tools.XPMenus.DropDownBarItem dropDownBarItem1;
        private Syncfusion.Windows.Forms.Tools.XPMenus.DropDownBarItem dropDownBarItem2;
        private Syncfusion.Windows.Forms.Tools.XPMenus.DropDownBarItem dropDownBarItem3;
        private Syncfusion.Windows.Forms.Tools.XPMenus.DropDownBarItem dropDownBarItem4;

        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem nxtButton;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem redoButton;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem simulate;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem findFile;

        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem displayInfo;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem toggleSuggestion;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem commentline;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem uncommentline;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem toggleBookMark;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem previousbookMark;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem nextBookMark;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem removeAllBookMark;

        private Syncfusion.Windows.Forms.Tools.XPMenus.ComboBoxBarItem comboBoxBarItem2;

        private Syncfusion.Windows.Forms.Tools.XPMenus.Bar bar3;

        public void AddMainFrameBarManagerItem()
        {
            // 
            // dropDownBarItem1
            // 
            this.dropDownBarItem1 = new Syncfusion.Windows.Forms.Tools.XPMenus.DropDownBarItem();
            this.dropDownBarItem1.BarName = "BackButton";
            this.dropDownBarItem1.CategoryIndex = 0;
            this.dropDownBarItem1.ID = "BackButton";
            this.dropDownBarItem1.ImageList = this.imageList2;
            this.dropDownBarItem1.ImageIndex = 0;
            this.dropDownBarItem1.ShowToolTipInPopUp = false;
            this.dropDownBarItem1.SizeToFit = true;
            this.dropDownBarItem1.Text = "落后";
            this.dropDownBarItem1.Enabled = false;

            // 
            // nxtButton
            // 
            this.nxtButton = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.nxtButton.BarName = "Next";
            this.nxtButton.CategoryIndex = 1;
            this.nxtButton.ID = "";
            this.nxtButton.ImageList = this.imageList2;
            this.nxtButton.ImageIndex = 1;
            this.nxtButton.ShowToolTipInPopUp = false;
            this.nxtButton.SizeToFit = true;
            this.nxtButton.Text = "前锋";

            // 
            // dropDownBarItem2
            // 
            this.dropDownBarItem2 = new Syncfusion.Windows.Forms.Tools.XPMenus.DropDownBarItem();
            this.dropDownBarItem2.BarName = "newProject";
            this.dropDownBarItem2.CategoryIndex = 0;
            this.dropDownBarItem2.ID = "NewProject";
            this.dropDownBarItem2.ImageList = this.imageList2;
            this.dropDownBarItem2.ImageIndex = 2;
            this.dropDownBarItem2.ShowToolTipInPopUp = false;
            this.dropDownBarItem2.SizeToFit = true;
            this.dropDownBarItem2.Text = "新项目";

            //Open
            this.barItem7.ImageList = this.imageList2;
            this.barItem7.ImageIndex = 3;
            this.barItem7.Text = "打开文件";
            //Save
            this.barItem8.ImageList = this.imageList2;
            this.barItem8.ImageIndex = 4;
            this.barItem8.Text = "保存";
            //Save All
            this.barItem9.ImageList = this.imageList2;
            this.barItem9.ImageIndex = 5;
            this.barItem9.Text = "保存全部";
            //Undo
            // 
            // dropDownBarItem3
            // 
            this.dropDownBarItem3 = new Syncfusion.Windows.Forms.Tools.XPMenus.DropDownBarItem();
            this.dropDownBarItem3.BarName = "Undo";
            this.dropDownBarItem3.CategoryIndex = 0;
            this.dropDownBarItem3.ID = "UndoItem";
            this.dropDownBarItem3.ImageList = this.imageList2;
            this.dropDownBarItem3.ImageIndex = 6;
            this.dropDownBarItem3.ShowToolTipInPopUp = false;
            this.dropDownBarItem3.SizeToFit = true;
            this.dropDownBarItem3.Text = "解开";
            // 
            // redoButton
            // 
            this.redoButton = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.redoButton.BarName = "Redo";
            this.redoButton.CategoryIndex = 1;
            this.redoButton.ID = "";
            this.redoButton.ImageList = this.imageList2;
            this.redoButton.ImageIndex = 7;
            this.redoButton.ShowToolTipInPopUp = false;
            this.redoButton.SizeToFit = true;
            this.redoButton.Text = "重做";
            //Start
            this.barItem10.ImageList = this.imageList2;
            this.barItem10.ImageIndex = 8;
            this.barItem10.PaintStyle = Syncfusion.Windows.Forms.Tools.XPMenus.PaintStyle.ImageAndText;
            //Browser Link

            // 
            // dropDownBarItem2
            // 
            this.dropDownBarItem4 = new Syncfusion.Windows.Forms.Tools.XPMenus.DropDownBarItem();
            this.dropDownBarItem4.BarName = "BackButton";
            this.dropDownBarItem4.CategoryIndex = 0;
            this.dropDownBarItem4.ID = "FirstItem";
            this.dropDownBarItem4.ImageList = this.imageList2;
            this.dropDownBarItem4.ImageIndex = 9;
            this.dropDownBarItem4.ShowToolTipInPopUp = false;
            this.dropDownBarItem4.SizeToFit = true;
            this.dropDownBarItem4.Text = "浏览链接";
            //ComboBoxBarItem2
            this.comboBoxBarItem2 = new Syncfusion.Windows.Forms.Tools.XPMenus.ComboBoxBarItem();
            this.comboBoxBarItem2.ListBox = new ListBox();
            this.comboBoxBarItem2.ListBox.Items.AddRange(new string[] { "任何中央", "配置管理器" });
            this.comboBoxBarItem2.TextBoxValue = "任何中央";
            this.comboBoxBarItem2.BarName = "comboBoxBarItem1";
            this.comboBoxBarItem2.CategoryIndex = 1;
            this.comboBoxBarItem2.ID = "Debug";
            this.comboBoxBarItem2.ShowToolTipInPopUp = false;
            this.comboBoxBarItem2.SizeToFit = true;
            this.comboBoxBarItem2.MinWidth = 100;
            // 
            // Simulate button
            // 
            this.simulate = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.simulate.BarName = "Simulation";
            this.simulate.CategoryIndex = 1;
            this.simulate.ID = "";
            this.simulate.ImageList = this.imageList2;
            this.simulate.ImageIndex = 10;
            this.simulate.ShowToolTipInPopUp = false;
            this.simulate.SizeToFit = true;
            this.simulate.Text = "模拟";
            // 
            // Find Files
            // 
            this.findFile = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.findFile.BarName = "Find";
            this.findFile.CategoryIndex = 11;
            this.findFile.ID = "";
            this.findFile.ImageList = this.imageList2;
            this.findFile.ImageIndex = 11;
            this.findFile.ShowToolTipInPopUp = false;
            this.findFile.SizeToFit = true;
            this.findFile.Text = "在文件中查找)";

            // DisplayQuickInfo
            // 
            this.displayInfo = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.displayInfo.BarName = "DisplayInfo";
            this.displayInfo.CategoryIndex = 1;
            this.displayInfo.ID = "";
            this.displayInfo.ImageList = this.imageList2;
            this.displayInfo.ImageIndex = 12;
            this.displayInfo.ShowToolTipInPopUp = false;
            this.displayInfo.SizeToFit = true;
            this.displayInfo.Text = "显示器快速";
            // Toggle Suggestions
            // 
            this.toggleSuggestion = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.toggleSuggestion.BarName = "ToggleSuggestion";
            this.toggleSuggestion.CategoryIndex = 1;
            this.toggleSuggestion.ID = "";
            this.toggleSuggestion.ImageList = this.imageList2;
            this.toggleSuggestion.ImageIndex = 13;
            this.toggleSuggestion.ShowToolTipInPopUp = false;
            this.toggleSuggestion.SizeToFit = true;
            this.toggleSuggestion.Text = "解开";

            // commentLine
            // 
            this.commentline = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.commentline.BarName = "Next";
            this.commentline.CategoryIndex = 1;
            this.commentline.ID = "";
            this.commentline.ImageList = this.imageList2;
            this.commentline.ImageIndex = 14;
            this.commentline.ShowToolTipInPopUp = false;
            this.commentline.SizeToFit = true;
            this.commentline.Text = "评论";
            // uncommentline
            // 
            this.uncommentline = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.uncommentline.BarName = "Uncommentline";
            this.uncommentline.CategoryIndex = 1;
            this.uncommentline.ID = "";
            this.uncommentline.ImageList = this.imageList2;
            this.uncommentline.ImageIndex = 15;
            this.uncommentline.ShowToolTipInPopUp = false;
            this.uncommentline.SizeToFit = true;
            this.uncommentline.Text = "注释";
            // BookMark
            // 
            this.toggleBookMark = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.toggleBookMark.BarName = "toggleBookMark";
            this.toggleBookMark.CategoryIndex = 1;
            this.toggleBookMark.ID = "";
            this.toggleBookMark.ImageList = this.imageList2;
            this.toggleBookMark.ImageIndex = 16;
            this.toggleBookMark.ShowToolTipInPopUp = false;
            this.toggleBookMark.SizeToFit = true;
            this.toggleBookMark.Text = "切换书签";

            // PreviousBookMark
            // 
            this.previousbookMark = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.previousbookMark.BarName = "PreviousBookMark";
            this.previousbookMark.CategoryIndex = 1;
            this.previousbookMark.ID = "";
            this.previousbookMark.ImageList = this.imageList2;
            this.previousbookMark.ImageIndex = 17;
            this.previousbookMark.ShowToolTipInPopUp = false;
            this.previousbookMark.SizeToFit = true;
            this.previousbookMark.Text = "以前";

            // nxtBookMark
            // 
            this.nextBookMark = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.nextBookMark.BarName = "NextBookMark";
            this.nextBookMark.CategoryIndex = 1;
            this.nextBookMark.ID = "";
            this.nextBookMark.ImageList = this.imageList2;
            this.nextBookMark.ImageIndex = 18;
            this.nextBookMark.ShowToolTipInPopUp = false;
            this.nextBookMark.SizeToFit = true;
            this.nextBookMark.Text = "下一个";

            // removeBookMarl
            // 
            this.removeAllBookMark = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.removeAllBookMark.BarName = "RemoveBookMark";
            this.removeAllBookMark.CategoryIndex = 1;
            this.removeAllBookMark.ID = "";
            this.removeAllBookMark.ImageList = this.imageList2;
            this.removeAllBookMark.ImageIndex = 19;
            this.removeAllBookMark.ShowToolTipInPopUp = false;
            this.removeAllBookMark.SizeToFit = true;
            this.removeAllBookMark.Text = "去掉";

            this.mainFrameBarManager1.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.dropDownBarItem1,
            this.nxtButton,
            this.dropDownBarItem2,
            this.barItem7,
            this.barItem8,
            this.barItem9,
            this.dropDownBarItem3,
            this.redoButton,
            this.barItem10,
            this.comboBoxBarItem1,
            this.dropDownBarItem4,
            this.comboBoxBarItem2,
            this.simulate});

            this.bar2 = new Syncfusion.Windows.Forms.Tools.XPMenus.Bar(this.mainFrameBarManager1, "Icons");
            this.mainFrameBarManager1.Bars.Add(this.bar2);

            // 
            // bar2
            // 
            this.bar2.BarName = "Icons";
            this.bar2.Caption = "图标";
            this.bar2.Manager = this.mainFrameBarManager1;
            this.bar2.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.dropDownBarItem1,
            this.nxtButton,
            this.dropDownBarItem2,
            this.barItem7,
            this.barItem8,
            this.barItem9,
            this.dropDownBarItem3,
            this.redoButton,
            this.barItem10,
            this.dropDownBarItem4,
            this.comboBoxBarItem1,
            this.comboBoxBarItem2,
            this.simulate,
            this.findFile
            });


            // 
            // bar3
            // 
            this.bar3 = new Syncfusion.Windows.Forms.Tools.XPMenus.Bar(this.mainFrameBarManager1, "文本编辑器");
            this.bar3.BarName = "文本编辑器";
            this.bar3.Caption = "文本编辑器";
            this.bar3.Manager = this.mainFrameBarManager1;
            this.mainFrameBarManager1.Bars.Add(this.bar3);
            this.bar3.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.displayInfo,
            this.toggleSuggestion,
            this.commentline,
            this.uncommentline,
            this.toggleBookMark,
            this.nextBookMark,
            this.previousbookMark,
            this.removeAllBookMark
            });
            this.bar2.SeparatorIndices.AddRange(new int[] {
            2,6,8,12,13});
            this.bar3.SeparatorIndices.AddRange(new int[] {
            2,4});
        }

        void bar1_DrawBackground(object sender, PaintEventArgs e)
        {
            e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(219, 223, 249)), e.ClipRectangle);
        }
    }
    class Localization : ILocalizationProvider
    {
        public string GetLocalizedString(System.Globalization.CultureInfo culture, string stringname, object obj)
        {

            switch (stringname)
            {

                case ToolsResourceIdentifiers.DockableMenuItemText: return "可停靠";
                case ToolsResourceIdentifiers.AutoHideMenuItemText: return "自动隐藏";
                case ToolsResourceIdentifiers.FloatingMenuItemText: return "漂浮的";
                case ToolsResourceIdentifiers.MDIChildMenuItemText: return "MDI 子";
                case ToolsResourceIdentifiers.HideMenuItemText: return "隐藏";
                case ToolsResourceIdentifiers.MenuItemDockToLeft: return "剩下";
                case ToolsResourceIdentifiers.MenuItemDockToRight: return "对";
                case ToolsResourceIdentifiers.MenuItemDockToTop: return "最佳";
                case ToolsResourceIdentifiers.MenuItemDockToBottom: return "底部";
                case ToolsResourceIdentifiers.MenuItemDockTo: return "码头";
                case ToolsResourceIdentifiers.AddOrRemoveButtons: return "添加或删除按钮";
                case ToolsResourceIdentifiers.CustomizeMenu: return "自定义菜单";
                case ToolsResourceIdentifiers.ResetToolBarMenu: return "重置工具栏";
                case ToolsResourceIdentifiers.SuccesfulResetMessageBoxTitle: return "工具栏复位成功";
                case ToolsResourceIdentifiers.SuccesfulToolbarResetMessage: return "工具栏 将显示 下次 下次 打开应用程序";
                case ToolsResourceIdentifiers.BarCustomizationDialogClose: return "关";
                case ToolsResourceIdentifiers.BarCustomizationDialogOther: return "其他";
                case ToolsResourceIdentifiers.BarCustomizationDialogLargeIcons: return "大图标";
                case ToolsResourceIdentifiers.BarCustomizationDialogDelete: return "删除";
                case ToolsResourceIdentifiers.BarCustomizationDialogNew: return "新";
                case ToolsResourceIdentifiers.BarCustomizationDialogResetCustomization: return "复位定制";
                case ToolsResourceIdentifiers.BarCustomizationDialogTabToolbars: return "工具栏";
                case ToolsResourceIdentifiers.BarCustomizationDialogTabOptions: return "选项";
                case ToolsResourceIdentifiers.BarCustomizationDialogTabCommands: return "命令";
                case ToolsResourceIdentifiers.BarCustomizationDialogPersonalizedMenus: return "个性化的菜单和工具栏";
                case ToolsResourceIdentifiers.BarCustomizationDialogToolbars: return "工具栏";
                case ToolsResourceIdentifiers.BarCustomizationDialogResetPartialMenus: return "重置我的使用率数据";
                case ToolsResourceIdentifiers.BarCustomizationDialogExpandAfterDelay: return "显示完整的菜单在短暂延迟后";
                case ToolsResourceIdentifiers.BarCustomizationDialogCategories: return "类别";
                case ToolsResourceIdentifiers.BarCustomizationDialogButtonReset: return "复位";
                case ToolsResourceIdentifiers.BarCustomizationDialogAlwaysFullMenu: return "总是显示完整的菜单";
                case ToolsResourceIdentifiers.BarCustomizationDialogCommands: return "命令";
                case ToolsResourceIdentifiers.CustomMenu: return "自定义菜单";
                case ToolsResourceIdentifiers.BarCustomizationDialogCaption: return "定制";

                default: return string.Empty;    
            }
        }
    }
}

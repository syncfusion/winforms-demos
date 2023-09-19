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
using System.ComponentModel;
using System.Windows.Forms;

using Syncfusion.Windows.Forms.Tools;
using Syncfusion.Windows.Forms.Tools.XPMenus;
using Syncfusion.Windows.Forms;

namespace VSDemo
{
    public enum CodeType
    {
        CS,
        VB
    }




    /// <summary>Fs
    /// Summary description for CodeEditorBase.
    /// </summary>
    public class CodeEditorBase : MetroForm
    {
        internal Syncfusion.Windows.Forms.Tools.XPMenus.ChildFrameBarManager childMenuBar;
        private System.Windows.Forms.ImageList largeImageList;
        private System.Windows.Forms.ImageList imageList1;
        private Syncfusion.Windows.Forms.Tools.XPMenus.Bar childToolBar1;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem1;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem2;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem3;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem4;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem5;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem6;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem7;
        private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem parentBarItem1;
        internal Syncfusion.Windows.Forms.Tools.XPMenus.Bar bar2;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem8;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem9;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem10;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem11;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem12;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem13;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem14;
        private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem parentBarItem2;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem15;
        private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem parentBarItem3;
        private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem parentBarItem4;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem16;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem17;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem18;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem19;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem20;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem21;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem24;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem25;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem26;
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
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.Panel panel1;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv comboBoxAdv1;
        private System.Windows.Forms.Splitter splitter1;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv comboBoxAdv2;
        private Syncfusion.Windows.Forms.Tools.XPMenus.ComboBoxBarItem comboBoxBarItem1;
        internal Syncfusion.Windows.Forms.Tools.XPMenus.Bar bar4;
        private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem parentBarItem6;
        private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem parentBarItem7;
        private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem parentBarItem8;
        private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem parentBarItem9;
        private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem parentBarItem10;
        private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem parentBarItem11;
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
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem56;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem57;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem58;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem59;
        internal Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem EditParentBarItem;
        internal Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem FormatParentBarItem;
        protected ScrollersFrame scrollersFrame1;
        internal Syncfusion.Windows.Forms.Edit.EditControl editControl1;
        public ContextMenuStripEx EditorContextMenuStripEx;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem toolStripMenuItem9;
        private ToolStripMenuItem toolStripMenuItem10;
        private ToolStripSeparator toolStripSeparator30;
        private ToolStripMenuItem removeUnusedUsingToolStripMenuItem;
        private ToolStripMenuItem sortUsingToolStripMenuItem;
        private ToolStripMenuItem runTestsToolStripMenuItem;
        private ToolStripMenuItem debugTestsToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem cutToolStripMenuItem;
        private ToolStripMenuItem copyToolStripMenuItem;
        private ToolStripMenuItem pasteToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem outLiningsToolStripMenuItem;
        private ToolStripMenuItem tonggleToolStripMenuItem;
        private ToolStripMenuItem toggleAllOutliningToolStripMenuItem;
        private ToolStripMenuItem stopToolStripMenuItem;
        private ToolStripMenuItem stopHidingCurrentToolStripMenuItem;
        private System.ComponentModel.IContainer components;


        public CodeEditorBase()
        {
            InitializeComponent();
            this.EditorContextMenuStripEx.Style = ContextMenuStripEx.ContextMenuStyle.Metro;
            this.EditorContextMenuStripEx.Renderer = new ContextMenuRenderer();
            this.editControl1.ScrollVisualStyle = Syncfusion.Windows.Forms.ScrollBarCustomDrawStyles.Metro;
        }

        public CodeEditorBase(CodeType type, string fileName)
        {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();
            if (this.CreateGraphics().DpiX == 96)
            {
                this.comboBoxAdv1.Dock = DockStyle.Left;
                this.comboBoxAdv2.Dock = DockStyle.Fill;
            }
            switch (type)
            {
                case CodeType.CS:
                    this.editControl1.ApplyConfiguration(Syncfusion.Windows.Forms.Edit.Enums.KnownLanguages.CSharp);
                    break;
                case CodeType.VB:
                    this.editControl1.ApplyConfiguration(Syncfusion.Windows.Forms.Edit.Enums.KnownLanguages.VBNET);
                    break;
            }
            this.editControl1.LoadFile(fileName);
            this.editControl1.ParsingMode = Syncfusion.Windows.Forms.Edit.Enums.TextParsingMode.PartialParsingNoFallback;
            foreach (BarItem i in this.childMenuBar.Items)
                i.CustomTextFont = new Font("Microsoft Sans Serif", 8.25f);
            this.comboBoxAdv1.Dock = DockStyle.Left;
            this.comboBoxAdv2.Dock = DockStyle.Fill;
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CodeEditorBase));
            Syncfusion.Windows.Forms.Edit.Implementation.Config.Config config1 = new Syncfusion.Windows.Forms.Edit.Implementation.Config.Config();
            this.childMenuBar = new Syncfusion.Windows.Forms.Tools.XPMenus.ChildFrameBarManager(this);
            this.childToolBar1 = new Syncfusion.Windows.Forms.Tools.XPMenus.Bar(this.childMenuBar, "childMenu");
            this.EditParentBarItem = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.barItem8 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.barItem9 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem10 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem11 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem12 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem13 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem14 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.parentBarItem2 = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.barItem16 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem17 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem18 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem19 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem15 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.parentBarItem4 = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.barItem30 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem31 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem32 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem33 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem34 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem35 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem36 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem37 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.parentBarItem3 = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.barItem20 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem21 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem24 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem25 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem26 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem27 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem28 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem29 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.FormatParentBarItem = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.parentBarItem6 = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.barItem54 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.barItem55 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem56 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem57 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem59 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem58 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.parentBarItem7 = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.barItem50 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem51 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem52 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem53 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.parentBarItem8 = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.barItem46 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem47 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem48 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem49 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.parentBarItem9 = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.barItem42 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem43 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem44 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem45 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.parentBarItem10 = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.barItem40 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem41 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.parentBarItem11 = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.barItem38 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem39 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.bar2 = new Syncfusion.Windows.Forms.Tools.XPMenus.Bar(this.childMenuBar, "Edit");
            this.bar4 = new Syncfusion.Windows.Forms.Tools.XPMenus.Bar(this.childMenuBar, "Format");
            this.comboBoxBarItem1 = new Syncfusion.Windows.Forms.Tools.XPMenus.ComboBoxBarItem();
            this.parentBarItem1 = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.barItem1 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem2 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem3 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem4 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem5 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem6 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem7 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.largeImageList = new System.Windows.Forms.ImageList(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBoxAdv2 = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.comboBoxAdv1 = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.editControl1 = new Syncfusion.Windows.Forms.Edit.EditControl();
            this.EditorContextMenuStripEx = new Syncfusion.Windows.Forms.Tools.ContextMenuStripEx();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem9 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem10 = new System.Windows.Forms.ToolStripMenuItem();
            this.removeUnusedUsingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sortUsingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator30 = new System.Windows.Forms.ToolStripSeparator();
            this.runTestsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.debugTestsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.outLiningsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tonggleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toggleAllOutliningToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopHidingCurrentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scrollersFrame1 = new Syncfusion.Windows.Forms.ScrollersFrame(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.childMenuBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxBarItem1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxAdv2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxAdv1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.editControl1)).BeginInit();
            this.EditorContextMenuStripEx.SuspendLayout();
            this.SuspendLayout();
            // 
            // childMenuBar
            // 
#if NETCORE && NET50
            this.childMenuBar.BarPositionInfo = ((System.IO.MemoryStream)(resources.GetObject("childMenuBar.BarPositionInfo")));
#endif
            this.childMenuBar.Bars.Add(this.childToolBar1);
            this.childMenuBar.Bars.Add(this.bar2);
            this.childMenuBar.Bars.Add(this.bar4);
            this.childMenuBar.Categories.Add("Edit");
            this.childMenuBar.Categories.Add("EditFind");
            this.childMenuBar.Categories.Add("Edit Bookmark");
            this.childMenuBar.Categories.Add("EditAdvanced");
            this.childMenuBar.Categories.Add("Format");
            this.childMenuBar.Categories.Add("FormatAlign");
            this.childMenuBar.Categories.Add("FormatMakeSameSize");
            this.childMenuBar.Categories.Add("FormatHorzSpacing");
            this.childMenuBar.Categories.Add("FormatVertSpacing");
            this.childMenuBar.Categories.Add("FormatCenterInForm");
            this.childMenuBar.Categories.Add("FormatOrder");
            this.childMenuBar.CurrentBaseFormType = "Syncfusion.Windows.Forms.MetroForm";
            this.childMenuBar.Form = this;
            this.childMenuBar.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.barItem46,
            this.barItem54,
            this.barItem47,
            this.barItem8,
            this.barItem48,
            this.barItem55,
            this.barItem49,
            this.barItem9,
            this.barItem56,
            this.barItem10,
            this.barItem57,
            this.barItem11,
            this.barItem59,
            this.barItem12,
            this.barItem58,
            this.barItem13,
            this.barItem14,
            this.parentBarItem2,
            this.barItem15,
            this.parentBarItem3,
            this.parentBarItem4,
            this.EditParentBarItem,
            this.barItem16,
            this.barItem17,
            this.barItem18,
            this.barItem19,
            this.barItem20,
            this.barItem21,
            this.barItem24,
            this.barItem25,
            this.barItem26,
            this.barItem27,
            this.barItem28,
            this.barItem29,
            this.barItem30,
            this.barItem31,
            this.barItem32,
            this.barItem33,
            this.barItem34,
            this.barItem35,
            this.barItem36,
            this.barItem37,
            this.comboBoxBarItem1,
            this.parentBarItem6,
            this.parentBarItem7,
            this.parentBarItem8,
            this.parentBarItem9,
            this.parentBarItem10,
            this.parentBarItem11,
            this.FormatParentBarItem,
            this.barItem38,
            this.barItem39,
            this.barItem40,
            this.barItem41,
            this.barItem42,
            this.barItem43,
            this.barItem44,
            this.barItem45,
            this.barItem50,
            this.barItem51,
            this.barItem52,
            this.barItem53});
            this.childMenuBar.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.childMenuBar.ShowHighlightRectangle = false;
            // 
            // childToolBar1
            // 
            this.childToolBar1.BarName = "childMenu";
            this.childToolBar1.BarStyle = ((Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle)((((Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.AllowQuickCustomizing | Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.IsMainMenu)
                        | Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.Visible)
                        | Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.DrawDragBorder)));
            this.childToolBar1.Caption = "childMenu";
            this.childToolBar1.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.EditParentBarItem,
            this.FormatParentBarItem});
            this.childToolBar1.Manager = this.childMenuBar;
            // 
            // EditParentBarItem
            // 
            this.EditParentBarItem.BarName = "EditParentBarItem";
            this.EditParentBarItem.CategoryIndex = 0;
            this.EditParentBarItem.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditParentBarItem.ID = "Edit";
            this.EditParentBarItem.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.barItem8,
            this.barItem9,
            this.barItem10,
            this.barItem11,
            this.barItem12,
            this.barItem13,
            this.barItem14,
            this.parentBarItem2,
            this.barItem15,
            this.parentBarItem4,
            this.parentBarItem3});
            this.EditParentBarItem.MergeOrder = 1;
            this.EditParentBarItem.MetroColor = System.Drawing.Color.LightSkyBlue;
            this.EditParentBarItem.SeparatorIndices.AddRange(new int[] {
            2,
            7,
            9,
            10});
            this.EditParentBarItem.ShowToolTipInPopUp = false;
            this.EditParentBarItem.SizeToFit = true;
            this.EditParentBarItem.Style = Syncfusion.Windows.Forms.VisualStyle.Default;
            this.EditParentBarItem.Text = "&EDIT";
            // 
            // barItem8
            // 
            this.barItem8.BarName = "barItem8";
            this.barItem8.CategoryIndex = 0;
            this.barItem8.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem8.ID = "Undo";
            this.barItem8.ImageIndex = 34;
            this.barItem8.ImageList = this.imageList2;
            this.barItem8.ShowToolTipInPopUp = false;
            this.barItem8.SizeToFit = true;
            this.barItem8.Text = "File Search";
            this.barItem8.Click += new System.EventHandler(this.OnBarItemClick);
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "");
            this.imageList2.Images.SetKeyName(1, "13.png");
            this.imageList2.Images.SetKeyName(2, "Next.png");
            this.imageList2.Images.SetKeyName(3, "");
            this.imageList2.Images.SetKeyName(4, "15.png");
            this.imageList2.Images.SetKeyName(5, "Before.png");
            this.imageList2.Images.SetKeyName(6, "");
            this.imageList2.Images.SetKeyName(7, "14.png");
            this.imageList2.Images.SetKeyName(8, "16.png");
            this.imageList2.Images.SetKeyName(9, "");
            this.imageList2.Images.SetKeyName(10, "11.png");
            this.imageList2.Images.SetKeyName(11, "Copy.png");
            this.imageList2.Images.SetKeyName(12, "");
            this.imageList2.Images.SetKeyName(13, "");
            this.imageList2.Images.SetKeyName(14, "");
            this.imageList2.Images.SetKeyName(15, "");
            this.imageList2.Images.SetKeyName(16, "");
            this.imageList2.Images.SetKeyName(17, "");
            this.imageList2.Images.SetKeyName(18, "10.png");
            this.imageList2.Images.SetKeyName(19, "PreviousBookMark.png");
            this.imageList2.Images.SetKeyName(20, "NextBookMark.png");
            this.imageList2.Images.SetKeyName(21, "");
            this.imageList2.Images.SetKeyName(22, "");
            this.imageList2.Images.SetKeyName(23, "");
            this.imageList2.Images.SetKeyName(24, "10.png");
            this.imageList2.Images.SetKeyName(25, "Paste.png");
            this.imageList2.Images.SetKeyName(26, "");
            this.imageList2.Images.SetKeyName(27, "09.png");
            this.imageList2.Images.SetKeyName(28, "");
            this.imageList2.Images.SetKeyName(29, "");
            this.imageList2.Images.SetKeyName(30, "");
            this.imageList2.Images.SetKeyName(31, "");
            this.imageList2.Images.SetKeyName(32, "");
            this.imageList2.Images.SetKeyName(33, "12.png");
            this.imageList2.Images.SetKeyName(34, "08.png");
            this.imageList2.Images.SetKeyName(35, "Copy.png");
            this.imageList2.Images.SetKeyName(36, "");
            this.imageList2.Images.SetKeyName(37, "10.png");
            this.imageList2.Images.SetKeyName(38, "10.png");
            this.imageList2.Images.SetKeyName(39, "Cut.png");
            // 
            // barItem9
            // 
            this.barItem9.BarName = "barItem9";
            this.barItem9.CategoryIndex = 0;
            this.barItem9.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem9.ID = "Redo";
            this.barItem9.ImageIndex = 27;
            this.barItem9.ImageList = this.imageList2;
            this.barItem9.ShowToolTipInPopUp = false;
            this.barItem9.SizeToFit = true;
            this.barItem9.Text = "Solution Explorer";
            this.barItem9.Click += new System.EventHandler(this.OnBarItemClick);
            // 
            // barItem10
            // 
            this.barItem10.BarName = "barItem10";
            this.barItem10.CategoryIndex = 0;
            this.barItem10.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem10.ID = "Cut";
            this.barItem10.ImageIndex = 39;
            this.barItem10.ImageList = this.imageList2;
            this.barItem10.ShowToolTipInPopUp = false;
            this.barItem10.SizeToFit = true;
            this.barItem10.Text = "Cut";
            this.barItem10.Click += new System.EventHandler(this.OnBarItemClick);
            // 
            // barItem11
            // 
            this.barItem11.BarName = "barItem11";
            this.barItem11.CategoryIndex = 0;
            this.barItem11.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem11.ID = "Copy";
            this.barItem11.ImageIndex = 35;
            this.barItem11.ImageList = this.imageList2;
            this.barItem11.ShowToolTipInPopUp = false;
            this.barItem11.SizeToFit = true;
            this.barItem11.Text = "Copy";
            this.barItem11.Click += new System.EventHandler(this.OnBarItemClick);
            // 
            // barItem12
            // 
            this.barItem12.BarName = "barItem12";
            this.barItem12.CategoryIndex = 0;
            this.barItem12.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem12.ID = "Paste";
            this.barItem12.ImageIndex = 25;
            this.barItem12.ImageList = this.imageList2;
            this.barItem12.ShowToolTipInPopUp = false;
            this.barItem12.SizeToFit = true;
            this.barItem12.Text = "Paste";
            this.barItem12.Click += new System.EventHandler(this.OnBarItemClick);
            // 
            // barItem13
            // 
            this.barItem13.BarName = "barItem13";
            this.barItem13.CategoryIndex = 0;
            this.barItem13.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem13.ID = "Delete";
            this.barItem13.ShowToolTipInPopUp = false;
            this.barItem13.SizeToFit = true;
            this.barItem13.Text = "Delete";
            // 
            // barItem14
            // 
            this.barItem14.BarName = "barItem14";
            this.barItem14.CategoryIndex = 0;
            this.barItem14.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem14.ID = "Select All";
            this.barItem14.ShowToolTipInPopUp = false;
            this.barItem14.SizeToFit = true;
            this.barItem14.Text = "Select All";
            this.barItem14.Click += new System.EventHandler(this.OnBarItemClick);
            // 
            // parentBarItem2
            // 
            this.parentBarItem2.BarName = "parentBarItem2";
            this.parentBarItem2.CategoryIndex = 0;
            this.parentBarItem2.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parentBarItem2.ID = "Find and Replace";
            this.parentBarItem2.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.barItem16,
            this.barItem17,
            this.barItem18,
            this.barItem19});
            this.parentBarItem2.MetroColor = System.Drawing.Color.LightSkyBlue;
            this.parentBarItem2.ShowToolTipInPopUp = false;
            this.parentBarItem2.SizeToFit = true;
            this.parentBarItem2.Style = Syncfusion.Windows.Forms.VisualStyle.OfficeXP;
            this.parentBarItem2.Text = "Find and Replace";
            // 
            // barItem16
            // 
            this.barItem16.BarName = "barItem16";
            this.barItem16.CategoryIndex = 1;
            this.barItem16.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem16.ID = "Quick Find";
            this.barItem16.ImageIndex = 16;
            this.barItem16.ImageList = this.imageList2;
            this.barItem16.Shortcut = System.Windows.Forms.Shortcut.CtrlF;
            this.barItem16.ShowToolTipInPopUp = false;
            this.barItem16.SizeToFit = true;
            this.barItem16.Text = "Quick Find";
            // 
            // barItem17
            // 
            this.barItem17.BarName = "barItem17";
            this.barItem17.CategoryIndex = 1;
            this.barItem17.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem17.ID = "Quick Replace";
            this.barItem17.Shortcut = System.Windows.Forms.Shortcut.CtrlH;
            this.barItem17.ShowToolTipInPopUp = false;
            this.barItem17.SizeToFit = true;
            this.barItem17.Text = "Quick Replace";
            // 
            // barItem18
            // 
            this.barItem18.BarName = "barItem18";
            this.barItem18.CategoryIndex = 1;
            this.barItem18.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem18.ID = "Find";
            this.barItem18.ImageIndex = 40;
            this.barItem18.ImageList = this.imageList2;
            this.barItem18.Shortcut = System.Windows.Forms.Shortcut.CtrlShiftF;
            this.barItem18.ShowToolTipInPopUp = false;
            this.barItem18.SizeToFit = true;
            this.barItem18.Text = "Find in Files";
            this.barItem18.Click += new System.EventHandler(this.OnBarItemClick);
            // 
            // barItem19
            // 
            this.barItem19.BarName = "barItem19";
            this.barItem19.CategoryIndex = 1;
            this.barItem19.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem19.ID = "Replace";
            this.barItem19.Shortcut = System.Windows.Forms.Shortcut.CtrlShiftH;
            this.barItem19.ShowToolTipInPopUp = false;
            this.barItem19.SizeToFit = true;
            this.barItem19.Text = "Replace in Files";
            this.barItem19.Click += new System.EventHandler(this.OnBarItemClick);
            // 
            // barItem15
            // 
            this.barItem15.BarName = "barItem15";
            this.barItem15.CategoryIndex = 0;
            this.barItem15.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem15.ID = "Goto";
            this.barItem15.ShowToolTipInPopUp = false;
            this.barItem15.SizeToFit = true;
            this.barItem15.Text = "Goto";
            // 
            // parentBarItem4
            // 
            this.parentBarItem4.BarName = "parentBarItem4";
            this.parentBarItem4.CategoryIndex = 0;
            this.parentBarItem4.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parentBarItem4.ID = "Advanced";
            this.parentBarItem4.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.barItem30,
            this.barItem31,
            this.barItem32,
            this.barItem33,
            this.barItem34,
            this.barItem35,
            this.barItem36,
            this.barItem37});
            this.parentBarItem4.MetroColor = System.Drawing.Color.LightSkyBlue;
            this.parentBarItem4.SeparatorIndices.AddRange(new int[] {
            2,
            4});
            this.parentBarItem4.ShowToolTipInPopUp = false;
            this.parentBarItem4.SizeToFit = true;
            this.parentBarItem4.Style = Syncfusion.Windows.Forms.VisualStyle.OfficeXP;
            this.parentBarItem4.Text = "Advanced";
            // 
            // barItem30
            // 
            this.barItem30.BarName = "barItem30";
            this.barItem30.CategoryIndex = 3;
            this.barItem30.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem30.ID = "Format Document";
            this.barItem30.ShowToolTipInPopUp = false;
            this.barItem30.SizeToFit = true;
            this.barItem30.Text = "Format Document";
            // 
            // barItem31
            // 
            this.barItem31.BarName = "barItem31";
            this.barItem31.CategoryIndex = 3;
            this.barItem31.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem31.ID = "Format Selection";
            this.barItem31.ShowToolTipInPopUp = false;
            this.barItem31.SizeToFit = true;
            this.barItem31.Text = "Format Selection";
            // 
            // barItem32
            // 
            this.barItem32.BarName = "barItem32";
            this.barItem32.CategoryIndex = 3;
            this.barItem32.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem32.ID = "Make Uppercase";
            this.barItem32.ShowToolTipInPopUp = false;
            this.barItem32.SizeToFit = true;
            this.barItem32.Text = "Make Uppercase";
            // 
            // barItem33
            // 
            this.barItem33.BarName = "barItem33";
            this.barItem33.CategoryIndex = 3;
            this.barItem33.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem33.ID = "Make Lowercase";
            this.barItem33.ShowToolTipInPopUp = false;
            this.barItem33.SizeToFit = true;
            this.barItem33.Text = "Make Lowercase";
            // 
            // barItem34
            // 
            this.barItem34.BarName = "barItem34";
            this.barItem34.CategoryIndex = 3;
            this.barItem34.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem34.ID = "Comment";
            this.barItem34.ImageIndex = 10;
            this.barItem34.ImageList = this.imageList2;
            this.barItem34.ShowToolTipInPopUp = false;
            this.barItem34.SizeToFit = true;
            this.barItem34.Text = "Comment Selection";
            this.barItem34.Click += new System.EventHandler(this.OnBarItemClick);
            // 
            // barItem35
            // 
            this.barItem35.BarName = "barItem35";
            this.barItem35.CategoryIndex = 3;
            this.barItem35.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem35.ID = "Uncomment";
            this.barItem35.ImageIndex = 33;
            this.barItem35.ImageList = this.imageList2;
            this.barItem35.ShowToolTipInPopUp = false;
            this.barItem35.SizeToFit = true;
            this.barItem35.Text = "Uncomment Selection";
            this.barItem35.Click += new System.EventHandler(this.OnBarItemClick);
            // 
            // barItem36
            // 
            this.barItem36.BarName = "barItem36";
            this.barItem36.CategoryIndex = 3;
            this.barItem36.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem36.ID = "Indent";
            this.barItem36.ImageIndex = 37;
            this.barItem36.ImageList = this.imageList2;
            this.barItem36.ShowToolTipInPopUp = false;
            this.barItem36.SizeToFit = true;
            this.barItem36.Text = "Increase Line Indent";
            this.barItem36.Click += new System.EventHandler(this.OnBarItemClick);
            // 
            // barItem37
            // 
            this.barItem37.BarName = "barItem37";
            this.barItem37.CategoryIndex = 3;
            this.barItem37.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem37.ID = "Outdent";
            this.barItem37.ImageIndex = 38;
            this.barItem37.ImageList = this.imageList2;
            this.barItem37.ShowToolTipInPopUp = false;
            this.barItem37.SizeToFit = true;
            this.barItem37.Text = "Decrease Line Indent";
            this.barItem37.Click += new System.EventHandler(this.OnBarItemClick);
            // 
            // parentBarItem3
            // 
            this.parentBarItem3.BarName = "parentBarItem3";
            this.parentBarItem3.CategoryIndex = 0;
            this.parentBarItem3.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parentBarItem3.ID = "Bookmarks";
            this.parentBarItem3.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.barItem20,
            this.barItem21,
            this.barItem24,
            this.barItem25,
            this.barItem26,
            this.barItem27,
            this.barItem28,
            this.barItem29});
            this.parentBarItem3.MetroColor = System.Drawing.Color.LightSkyBlue;
            this.parentBarItem3.SeparatorIndices.AddRange(new int[] {
            3,
            5,
            7});
            this.parentBarItem3.ShowToolTipInPopUp = false;
            this.parentBarItem3.SizeToFit = true;
            this.parentBarItem3.Style = Syncfusion.Windows.Forms.VisualStyle.OfficeXP;
            this.parentBarItem3.Text = "Bookmarks";
            // 
            // barItem20
            // 
            this.barItem20.BarName = "barItem20";
            this.barItem20.CategoryIndex = 2;
            this.barItem20.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem20.ID = "ToggleBookmark";
            this.barItem20.ShowToolTipInPopUp = false;
            this.barItem20.SizeToFit = true;
            this.barItem20.Text = "Toggle Bookmark";
            this.barItem20.Click += new System.EventHandler(this.OnBarItemClick);
            // 
            // barItem21
            // 
            this.barItem21.BarName = "barItem21";
            this.barItem21.CategoryIndex = 2;
            this.barItem21.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem21.ID = "AddBookmark";
            this.barItem21.ImageIndex = 1;
            this.barItem21.ImageList = this.imageList2;
            this.barItem21.ShowToolTipInPopUp = false;
            this.barItem21.SizeToFit = true;
            this.barItem21.Text = "Enable Bookmark";
            this.barItem21.Click += new System.EventHandler(this.OnBarItemClick);
            // 
            // barItem24
            // 
            this.barItem24.BarName = "barItem24";
            this.barItem24.CategoryIndex = 2;
            this.barItem24.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem24.ID = "ClearBookmark";
            this.barItem24.ImageIndex = 8;
            this.barItem24.ImageList = this.imageList2;
            this.barItem24.ShowToolTipInPopUp = false;
            this.barItem24.SizeToFit = true;
            this.barItem24.Text = "Clear Bookmarks";
            this.barItem24.Click += new System.EventHandler(this.OnBarItemClick);
            // 
            // barItem25
            // 
            this.barItem25.BarName = "barItem25";
            this.barItem25.CategoryIndex = 2;
            this.barItem25.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem25.ID = "Previous Bookmark in Folder";
            this.barItem25.ImageIndex = 7;
            this.barItem25.ImageList = this.imageList2;
            this.barItem25.ShowToolTipInPopUp = false;
            this.barItem25.SizeToFit = true;
            this.barItem25.Text = "Previous Bookmark in Folder";
            // 
            // barItem26
            // 
            this.barItem26.BarName = "barItem26";
            this.barItem26.CategoryIndex = 2;
            this.barItem26.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem26.ID = "Next Bookmark in Folder";
            this.barItem26.ImageIndex = 4;
            this.barItem26.ImageList = this.imageList2;
            this.barItem26.ShowToolTipInPopUp = false;
            this.barItem26.SizeToFit = true;
            this.barItem26.Text = "Next Bookmark in Folder";
            // 
            // barItem27
            // 
            this.barItem27.BarName = "barItem27";
            this.barItem27.CategoryIndex = 2;
            this.barItem27.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem27.ID = "Previous Bookmark in Document";
            this.barItem27.ImageIndex = 19;
            this.barItem27.ImageList = this.imageList2;
            this.barItem27.ShowToolTipInPopUp = false;
            this.barItem27.SizeToFit = true;
            this.barItem27.Text = "Previous Bookmark in Document";
            // 
            // barItem28
            // 
            this.barItem28.BarName = "barItem28";
            this.barItem28.CategoryIndex = 2;
            this.barItem28.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem28.ID = "Next Bookmark in Document";
            this.barItem28.ImageIndex = 20;
            this.barItem28.ImageList = this.imageList2;
            this.barItem28.ShowToolTipInPopUp = false;
            this.barItem28.SizeToFit = true;
            this.barItem28.Text = "Next Bookmark in Document";
            // 
            // barItem29
            // 
            this.barItem29.BarName = "barItem29";
            this.barItem29.CategoryIndex = 2;
            this.barItem29.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem29.ID = "ClearAllBookmarks";
            this.barItem29.ShowToolTipInPopUp = false;
            this.barItem29.SizeToFit = true;
            this.barItem29.Text = "Clear All Bookmarks";
            // 
            // FormatParentBarItem
            // 
            this.FormatParentBarItem.BarName = "FormatParentBarItem";
            this.FormatParentBarItem.CategoryIndex = 4;
            this.FormatParentBarItem.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormatParentBarItem.ID = "Format";
            this.FormatParentBarItem.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.parentBarItem6,
            this.parentBarItem7,
            this.parentBarItem8,
            this.parentBarItem9,
            this.parentBarItem10,
            this.parentBarItem11});
            this.FormatParentBarItem.MergeOrder = 7;
            this.FormatParentBarItem.MetroColor = System.Drawing.Color.LightSkyBlue;
            this.FormatParentBarItem.ShowToolTipInPopUp = false;
            this.FormatParentBarItem.SizeToFit = true;
            this.FormatParentBarItem.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.FormatParentBarItem.Text = "F&ORMAT";
            // 
            // parentBarItem6
            // 
            this.parentBarItem6.BarName = "parentBarItem6";
            this.parentBarItem6.CategoryIndex = 4;
            this.parentBarItem6.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parentBarItem6.ID = "Align";
            this.parentBarItem6.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.barItem54,
            this.barItem55,
            this.barItem56,
            this.barItem57,
            this.barItem59,
            this.barItem58});
            this.parentBarItem6.MetroColor = System.Drawing.Color.LightSkyBlue;
            this.parentBarItem6.SeparatorIndices.AddRange(new int[] {
            3});
            this.parentBarItem6.ShowToolTipInPopUp = false;
            this.parentBarItem6.SizeToFit = true;
            this.parentBarItem6.Style = Syncfusion.Windows.Forms.VisualStyle.Office2003;
            this.parentBarItem6.Text = "Align";
            // 
            // barItem54
            // 
            this.barItem54.BarName = "barItem54";
            this.barItem54.CategoryIndex = 5;
            this.barItem54.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem54.ID = "Left";
            this.barItem54.ImageIndex = 15;
            this.barItem54.ImageList = this.imageList1;
            this.barItem54.ShowToolTipInPopUp = false;
            this.barItem54.SizeToFit = true;
            this.barItem54.Text = "Left";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Cut.png");
            this.imageList1.Images.SetKeyName(1, "");
            this.imageList1.Images.SetKeyName(2, "");
            this.imageList1.Images.SetKeyName(3, "");
            this.imageList1.Images.SetKeyName(4, "");
            this.imageList1.Images.SetKeyName(5, "");
            this.imageList1.Images.SetKeyName(6, "");
            this.imageList1.Images.SetKeyName(7, "");
            this.imageList1.Images.SetKeyName(8, "");
            this.imageList1.Images.SetKeyName(9, "");
            this.imageList1.Images.SetKeyName(10, "");
            this.imageList1.Images.SetKeyName(11, "");
            this.imageList1.Images.SetKeyName(12, "");
            this.imageList1.Images.SetKeyName(13, "");
            this.imageList1.Images.SetKeyName(14, "");
            this.imageList1.Images.SetKeyName(15, "");
            this.imageList1.Images.SetKeyName(16, "");
            this.imageList1.Images.SetKeyName(17, "");
            this.imageList1.Images.SetKeyName(18, "");
            this.imageList1.Images.SetKeyName(19, "");
            this.imageList1.Images.SetKeyName(20, "");
            this.imageList1.Images.SetKeyName(21, "");
            this.imageList1.Images.SetKeyName(22, "");
            this.imageList1.Images.SetKeyName(23, "");
            this.imageList1.Images.SetKeyName(24, "");
            this.imageList1.Images.SetKeyName(25, "");
            this.imageList1.Images.SetKeyName(26, "");
            this.imageList1.Images.SetKeyName(27, "");
            this.imageList1.Images.SetKeyName(28, "");
            this.imageList1.Images.SetKeyName(29, "");
            this.imageList1.Images.SetKeyName(30, "");
            this.imageList1.Images.SetKeyName(31, "");
            this.imageList1.Images.SetKeyName(32, "");
            this.imageList1.Images.SetKeyName(33, "");
            this.imageList1.Images.SetKeyName(34, "");
            this.imageList1.Images.SetKeyName(35, "");
            this.imageList1.Images.SetKeyName(36, "");
            this.imageList1.Images.SetKeyName(37, "");
            // 
            // barItem55
            // 
            this.barItem55.BarName = "barItem55";
            this.barItem55.CategoryIndex = 5;
            this.barItem55.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem55.ID = "Center";
            this.barItem55.ImageIndex = 14;
            this.barItem55.ImageList = this.imageList1;
            this.barItem55.ShowToolTipInPopUp = false;
            this.barItem55.SizeToFit = true;
            this.barItem55.Text = "Center";
            // 
            // barItem56
            // 
            this.barItem56.BarName = "barItem56";
            this.barItem56.CategoryIndex = 5;
            this.barItem56.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem56.ID = "Right";
            this.barItem56.ImageIndex = 17;
            this.barItem56.ImageList = this.imageList1;
            this.barItem56.ShowToolTipInPopUp = false;
            this.barItem56.SizeToFit = true;
            this.barItem56.Text = "Right";
            // 
            // barItem57
            // 
            this.barItem57.BarName = "barItem57";
            this.barItem57.CategoryIndex = 5;
            this.barItem57.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem57.ID = "Top";
            this.barItem57.ImageIndex = 18;
            this.barItem57.ImageList = this.imageList1;
            this.barItem57.ShowToolTipInPopUp = false;
            this.barItem57.SizeToFit = true;
            this.barItem57.Text = "Top";
            // 
            // barItem59
            // 
            this.barItem59.BarName = "barItem59";
            this.barItem59.CategoryIndex = 5;
            this.barItem59.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem59.ID = "Middle";
            this.barItem59.ImageIndex = 16;
            this.barItem59.ImageList = this.imageList1;
            this.barItem59.ShowToolTipInPopUp = false;
            this.barItem59.SizeToFit = true;
            this.barItem59.Text = "Middle";
            // 
            // barItem58
            // 
            this.barItem58.BarName = "barItem58";
            this.barItem58.CategoryIndex = 5;
            this.barItem58.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem58.ID = "Bottom";
            this.barItem58.ImageIndex = 13;
            this.barItem58.ImageList = this.imageList1;
            this.barItem58.ShowToolTipInPopUp = false;
            this.barItem58.SizeToFit = true;
            this.barItem58.Text = "Bottom";
            // 
            // parentBarItem7
            // 
            this.parentBarItem7.BarName = "parentBarItem7";
            this.parentBarItem7.CategoryIndex = 4;
            this.parentBarItem7.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parentBarItem7.ID = "Make Same Size";
            this.parentBarItem7.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.barItem50,
            this.barItem51,
            this.barItem52,
            this.barItem53});
            this.parentBarItem7.MetroColor = System.Drawing.Color.LightSkyBlue;
            this.parentBarItem7.ShowToolTipInPopUp = false;
            this.parentBarItem7.SizeToFit = true;
            this.parentBarItem7.Style = Syncfusion.Windows.Forms.VisualStyle.Office2003;
            this.parentBarItem7.Text = "Make Same Size";
            // 
            // barItem50
            // 
            this.barItem50.BarName = "barItem50";
            this.barItem50.CategoryIndex = 6;
            this.barItem50.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem50.ID = "Width";
            this.barItem50.ImageIndex = 36;
            this.barItem50.ImageList = this.imageList1;
            this.barItem50.ShowToolTipInPopUp = false;
            this.barItem50.SizeToFit = true;
            this.barItem50.Text = "Width";
            // 
            // barItem51
            // 
            this.barItem51.BarName = "barItem51";
            this.barItem51.CategoryIndex = 6;
            this.barItem51.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem51.ID = "Height";
            this.barItem51.ImageIndex = 25;
            this.barItem51.ImageList = this.imageList1;
            this.barItem51.ShowToolTipInPopUp = false;
            this.barItem51.SizeToFit = true;
            this.barItem51.Text = "Height";
            // 
            // barItem52
            // 
            this.barItem52.BarName = "barItem52";
            this.barItem52.CategoryIndex = 6;
            this.barItem52.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem52.ID = "Both";
            this.barItem52.ImageIndex = 20;
            this.barItem52.ImageList = this.imageList1;
            this.barItem52.ShowToolTipInPopUp = false;
            this.barItem52.SizeToFit = true;
            this.barItem52.Text = "Both";
            // 
            // barItem53
            // 
            this.barItem53.BarName = "barItem53";
            this.barItem53.CategoryIndex = 6;
            this.barItem53.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem53.ID = "SizeToGrid";
            this.barItem53.ImageIndex = 29;
            this.barItem53.ImageList = this.imageList1;
            this.barItem53.ShowToolTipInPopUp = false;
            this.barItem53.SizeToFit = true;
            this.barItem53.Text = "SizeToGrid";
            // 
            // parentBarItem8
            // 
            this.parentBarItem8.BarName = "parentBarItem8";
            this.parentBarItem8.CategoryIndex = 4;
            this.parentBarItem8.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parentBarItem8.ID = "Horizontal Spacing";
            this.parentBarItem8.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.barItem46,
            this.barItem47,
            this.barItem48,
            this.barItem49});
            this.parentBarItem8.MetroColor = System.Drawing.Color.LightSkyBlue;
            this.parentBarItem8.ShowToolTipInPopUp = false;
            this.parentBarItem8.SizeToFit = true;
            this.parentBarItem8.Style = Syncfusion.Windows.Forms.VisualStyle.Office2003;
            this.parentBarItem8.Text = "Horizontal Spacing";
            // 
            // barItem46
            // 
            this.barItem46.BarName = "barItem46";
            this.barItem46.CategoryIndex = 7;
            this.barItem46.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem46.ID = "Make Equal_1";
            this.barItem46.ImageIndex = 16;
            this.barItem46.ImageList = this.imageList1;
            this.barItem46.ShowToolTipInPopUp = false;
            this.barItem46.SizeToFit = true;
            this.barItem46.Text = "Make Equal";
            // 
            // barItem47
            // 
            this.barItem47.BarName = "barItem47";
            this.barItem47.CategoryIndex = 7;
            this.barItem47.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem47.ID = "Increase_1";
            this.barItem47.ImageIndex = 23;
            this.barItem47.ImageList = this.imageList1;
            this.barItem47.ShowToolTipInPopUp = false;
            this.barItem47.SizeToFit = true;
            this.barItem47.Text = "Increase";
            // 
            // barItem48
            // 
            this.barItem48.BarName = "barItem48";
            this.barItem48.CategoryIndex = 7;
            this.barItem48.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem48.ID = "Decrease_1";
            this.barItem48.ImageIndex = 22;
            this.barItem48.ImageList = this.imageList1;
            this.barItem48.ShowToolTipInPopUp = false;
            this.barItem48.SizeToFit = true;
            this.barItem48.Text = "Decrease";
            // 
            // barItem49
            // 
            this.barItem49.BarName = "barItem49";
            this.barItem49.CategoryIndex = 7;
            this.barItem49.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem49.ID = "Remove_1";
            this.barItem49.ImageIndex = 24;
            this.barItem49.ImageList = this.imageList1;
            this.barItem49.ShowToolTipInPopUp = false;
            this.barItem49.SizeToFit = true;
            this.barItem49.Text = "Remove";
            // 
            // parentBarItem9
            // 
            this.parentBarItem9.BarName = "parentBarItem9";
            this.parentBarItem9.CategoryIndex = 4;
            this.parentBarItem9.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parentBarItem9.ID = "Vertical Spacing";
            this.parentBarItem9.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.barItem42,
            this.barItem43,
            this.barItem44,
            this.barItem45});
            this.parentBarItem9.MetroColor = System.Drawing.Color.LightSkyBlue;
            this.parentBarItem9.ShowToolTipInPopUp = false;
            this.parentBarItem9.SizeToFit = true;
            this.parentBarItem9.Style = Syncfusion.Windows.Forms.VisualStyle.Office2003;
            this.parentBarItem9.Text = "Vertical Spacing";
            // 
            // barItem42
            // 
            this.barItem42.BarName = "barItem42";
            this.barItem42.CategoryIndex = 8;
            this.barItem42.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem42.ID = "Make Equal";
            this.barItem42.ImageIndex = 32;
            this.barItem42.ImageList = this.imageList1;
            this.barItem42.ShowToolTipInPopUp = false;
            this.barItem42.SizeToFit = true;
            this.barItem42.Text = "Make Equal";
            // 
            // barItem43
            // 
            this.barItem43.BarName = "barItem43";
            this.barItem43.CategoryIndex = 8;
            this.barItem43.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem43.ID = "Increase";
            this.barItem43.ImageIndex = 37;
            this.barItem43.ImageList = this.imageList1;
            this.barItem43.ShowToolTipInPopUp = false;
            this.barItem43.SizeToFit = true;
            this.barItem43.Text = "Increase";
            // 
            // barItem44
            // 
            this.barItem44.BarName = "barItem44";
            this.barItem44.CategoryIndex = 8;
            this.barItem44.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem44.ID = "Decrease";
            this.barItem44.ImageIndex = 31;
            this.barItem44.ImageList = this.imageList1;
            this.barItem44.ShowToolTipInPopUp = false;
            this.barItem44.SizeToFit = true;
            this.barItem44.Text = "Decrease";
            // 
            // barItem45
            // 
            this.barItem45.BarName = "barItem45";
            this.barItem45.CategoryIndex = 8;
            this.barItem45.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem45.ID = "Remove";
            this.barItem45.ImageIndex = 34;
            this.barItem45.ImageList = this.imageList1;
            this.barItem45.ShowToolTipInPopUp = false;
            this.barItem45.SizeToFit = true;
            this.barItem45.Text = "Remove";
            // 
            // parentBarItem10
            // 
            this.parentBarItem10.BarName = "parentBarItem10";
            this.parentBarItem10.CategoryIndex = 4;
            this.parentBarItem10.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parentBarItem10.ID = "Center In Form";
            this.parentBarItem10.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.barItem40,
            this.barItem41});
            this.parentBarItem10.MetroColor = System.Drawing.Color.LightSkyBlue;
            this.parentBarItem10.ShowToolTipInPopUp = false;
            this.parentBarItem10.SizeToFit = true;
            this.parentBarItem10.Style = Syncfusion.Windows.Forms.VisualStyle.Office2003;
            this.parentBarItem10.Text = "Center In Form";
            // 
            // barItem40
            // 
            this.barItem40.BarName = "barItem40";
            this.barItem40.CategoryIndex = 9;
            this.barItem40.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem40.ID = "Horizontally";
            this.barItem40.ImageIndex = 26;
            this.barItem40.ImageList = this.imageList1;
            this.barItem40.ShowToolTipInPopUp = false;
            this.barItem40.SizeToFit = true;
            this.barItem40.Text = "Horizontally";
            // 
            // barItem41
            // 
            this.barItem41.BarName = "barItem41";
            this.barItem41.CategoryIndex = 9;
            this.barItem41.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem41.ID = "Vertically";
            this.barItem41.ImageIndex = 35;
            this.barItem41.ImageList = this.imageList1;
            this.barItem41.ShowToolTipInPopUp = false;
            this.barItem41.SizeToFit = true;
            this.barItem41.Text = "Vertically";
            // 
            // parentBarItem11
            // 
            this.parentBarItem11.BarName = "parentBarItem11";
            this.parentBarItem11.CategoryIndex = 4;
            this.parentBarItem11.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parentBarItem11.ID = "Order";
            this.parentBarItem11.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.barItem38,
            this.barItem39});
            this.parentBarItem11.MetroColor = System.Drawing.Color.LightSkyBlue;
            this.parentBarItem11.ShowToolTipInPopUp = false;
            this.parentBarItem11.SizeToFit = true;
            this.parentBarItem11.Style = Syncfusion.Windows.Forms.VisualStyle.Office2003;
            this.parentBarItem11.Text = "Order";
            // 
            // barItem38
            // 
            this.barItem38.BarName = "barItem38";
            this.barItem38.CategoryIndex = 10;
            this.barItem38.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem38.ID = "BringToFront";
            this.barItem38.ImageIndex = 21;
            this.barItem38.ImageList = this.imageList1;
            this.barItem38.ShowToolTipInPopUp = false;
            this.barItem38.SizeToFit = true;
            this.barItem38.Text = "BringToFront";
            // 
            // barItem39
            // 
            this.barItem39.BarName = "barItem39";
            this.barItem39.CategoryIndex = 10;
            this.barItem39.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem39.ID = "SendToBack";
            this.barItem39.ImageIndex = 28;
            this.barItem39.ImageList = this.imageList1;
            this.barItem39.ShowToolTipInPopUp = false;
            this.barItem39.SizeToFit = true;
            this.barItem39.Text = "SendToBack";
            // 
            // bar2
            // 
            this.bar2.BarName = "Edit";
            this.bar2.Caption = "ChildToolBar1";
            this.bar2.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.barItem8,
            this.barItem9,
            this.barItem36,
            this.barItem34,
            this.barItem35,
            this.barItem21,
            this.barItem25,
            this.barItem26,
            this.barItem24});
            this.bar2.Manager = this.childMenuBar;
            this.bar2.MenuItemMergeOrder = 1;
            this.bar2.SeparatorIndices.AddRange(new int[] {
            5,
            9});
            // 
            // bar4
            // 
            this.bar4.BarName = "Format";
            this.bar4.Caption = "ChildFormatBar";
            this.bar4.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.barItem54,
            this.barItem55,
            this.barItem56,
            this.barItem57,
            this.barItem59,
            this.barItem58,
            this.barItem50,
            this.barItem51,
            this.barItem52,
            this.barItem53,
            this.barItem47,
            this.barItem48,
            this.barItem49,
            this.barItem43,
            this.barItem44,
            this.barItem45,
            this.barItem40,
            this.barItem41,
            this.barItem38,
            this.barItem39});
            this.bar4.Manager = this.childMenuBar;
            this.bar4.MenuItemMergeOrder = 3;
            this.bar4.SeparatorIndices.AddRange(new int[] {
            6,
            10,
            13,
            16,
            18});
            // 
            // comboBoxBarItem1
            // 
            this.comboBoxBarItem1.BarName = "comboBoxBarItem1";
            this.comboBoxBarItem1.CategoryIndex = 1;
            this.comboBoxBarItem1.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxBarItem1.ID = "_1";
            this.comboBoxBarItem1.ShowToolTipInPopUp = false;
            this.comboBoxBarItem1.SizeToFit = true;
            // 
            // parentBarItem1
            // 
            this.parentBarItem1.BarName = "parentBarItem1";
            this.parentBarItem1.CategoryIndex = 0;
            this.parentBarItem1.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parentBarItem1.ID = "&Refactor";
            this.parentBarItem1.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.barItem1,
            this.barItem2,
            this.barItem3,
            this.barItem4,
            this.barItem5,
            this.barItem6,
            this.barItem7});
            this.parentBarItem1.MergeOrder = 3;
            this.parentBarItem1.MetroColor = System.Drawing.Color.LightSkyBlue;
            this.parentBarItem1.SeparatorIndices.AddRange(new int[] {
            1,
            4});
            this.parentBarItem1.ShowToolTipInPopUp = false;
            this.parentBarItem1.SizeToFit = true;
            this.parentBarItem1.Text = "&Refactor";
            // 
            // barItem1
            // 
            this.barItem1.BarName = "barItem1";
            this.barItem1.CategoryIndex = 0;
            this.barItem1.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem1.ID = "Rename";
            this.barItem1.ShowToolTipInPopUp = false;
            this.barItem1.SizeToFit = true;
            this.barItem1.Text = "Rename";
            // 
            // barItem2
            // 
            this.barItem2.BarName = "barItem2";
            this.barItem2.CategoryIndex = 0;
            this.barItem2.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem2.ID = "Extract Method";
            this.barItem2.ShowToolTipInPopUp = false;
            this.barItem2.SizeToFit = true;
            this.barItem2.Text = "Extract Method";
            // 
            // barItem3
            // 
            this.barItem3.BarName = "barItem3";
            this.barItem3.CategoryIndex = 0;
            this.barItem3.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem3.ID = "Encapsulate Field";
            this.barItem3.ShowToolTipInPopUp = false;
            this.barItem3.SizeToFit = true;
            this.barItem3.Text = "Encapsulate Field";
            // 
            // barItem4
            // 
            this.barItem4.BarName = "barItem4";
            this.barItem4.CategoryIndex = 0;
            this.barItem4.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem4.ID = "Extract Interface";
            this.barItem4.ShowToolTipInPopUp = false;
            this.barItem4.SizeToFit = true;
            this.barItem4.Text = "Extract Interface";
            // 
            // barItem5
            // 
            this.barItem5.BarName = "barItem5";
            this.barItem5.CategoryIndex = 0;
            this.barItem5.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem5.ID = "Promote Local Variable to Parameter";
            this.barItem5.ShowToolTipInPopUp = false;
            this.barItem5.SizeToFit = true;
            this.barItem5.Text = "Promote Local Variable to Parameter";
            // 
            // barItem6
            // 
            this.barItem6.BarName = "barItem6";
            this.barItem6.CategoryIndex = 0;
            this.barItem6.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem6.ID = "Remove Parameters";
            this.barItem6.ShowToolTipInPopUp = false;
            this.barItem6.SizeToFit = true;
            this.barItem6.Text = "Remove Parameters";
            // 
            // barItem7
            // 
            this.barItem7.BarName = "barItem7";
            this.barItem7.CategoryIndex = 0;
            this.barItem7.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem7.ID = "Reorder Parameters";
            this.barItem7.ShowToolTipInPopUp = false;
            this.barItem7.SizeToFit = true;
            this.barItem7.Text = "Reorder Parameters";
            // 
            // largeImageList
            // 
            this.largeImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("largeImageList.ImageStream")));
            this.largeImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.largeImageList.Images.SetKeyName(0, "Cut.png");
            this.largeImageList.Images.SetKeyName(1, "");
            this.largeImageList.Images.SetKeyName(2, "");
            this.largeImageList.Images.SetKeyName(3, "Undo.png");
            this.largeImageList.Images.SetKeyName(4, "Redo.png");
            this.largeImageList.Images.SetKeyName(5, "");
            this.largeImageList.Images.SetKeyName(6, "");
            this.largeImageList.Images.SetKeyName(7, "");
            this.largeImageList.Images.SetKeyName(8, "");
            this.largeImageList.Images.SetKeyName(9, "");
            this.largeImageList.Images.SetKeyName(10, "");
            this.largeImageList.Images.SetKeyName(11, "");
            this.largeImageList.Images.SetKeyName(12, "");
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.comboBoxAdv2);
            this.panel1.Controls.Add(this.splitter1);
            this.panel1.Controls.Add(this.comboBoxAdv1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 25);
            this.panel1.TabIndex = 4;
            // 
            // comboBoxAdv2
            // 
            this.comboBoxAdv2.BackColor = System.Drawing.Color.White;
            this.comboBoxAdv2.Dock = System.Windows.Forms.DockStyle.None;
            this.comboBoxAdv2.ImageList = this.imageList2;
            this.comboBoxAdv2.Location = new System.Drawing.Point(330, 0);
            this.comboBoxAdv2.Name = "comboBoxAdv2";
            this.comboBoxAdv2.ShowImageInTextBox = true;
            this.comboBoxAdv2.Size = new System.Drawing.Size(332, 21);
            this.comboBoxAdv2.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.comboBoxAdv2.TabIndex = 2;
            this.comboBoxAdv2.Text = "Main(String[] args)";
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(327, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(2, 20);
            this.splitter1.TabIndex = 1;
            this.splitter1.TabStop = false;
            // 
            // comboBoxAdv1
            // 
            this.comboBoxAdv1.BackColor = System.Drawing.Color.White;
            this.comboBoxAdv1.Dock = System.Windows.Forms.DockStyle.None;
            this.comboBoxAdv1.ImageList = this.imageList2;
            this.comboBoxAdv1.Location = new System.Drawing.Point(2, 0);
            this.comboBoxAdv1.Name = "comboBoxAdv1";
            this.comboBoxAdv1.ShowImageInTextBox = true;
            this.comboBoxAdv1.Size = new System.Drawing.Size(327, 21);
            this.comboBoxAdv1.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.comboBoxAdv1.TabIndex = 0;
            this.comboBoxAdv1.Text = "ConsoleApplication1.Program()";
            // 
            // editControl1
            // 
            this.editControl1.CodeSnipptSize = new System.Drawing.Size(100, 100);
            this.editControl1.Configurator = config1;
            this.editControl1.ContextMenuEnabled = false;
            this.editControl1.ContextMenuStrip = this.EditorContextMenuStripEx;
            this.editControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.editControl1.IndicatorMarginBackColor = System.Drawing.Color.Empty;
            this.editControl1.LineNumbersFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.editControl1.Location = new System.Drawing.Point(0, 20);
            this.editControl1.Name = "editControl1";
            this.editControl1.RenderRightToLeft = false;
            this.editControl1.ScrollPosition = new System.Drawing.Point(0, 0);
            this.editControl1.ScrollVisualStyle = Syncfusion.Windows.Forms.ScrollBarCustomDrawStyles.Metro;
            this.editControl1.ShowHorizontalSplitters = false;
            this.editControl1.ShowLineNumbers = false;
            this.editControl1.ShowVerticalSplitters = false;
            this.editControl1.Size = new System.Drawing.Size(776, 698);

            this.editControl1.StatusBarSettings.TextPanel.AutoSize = false;
            this.editControl1.TabIndex = 3;
            this.editControl1.Text = "";
            this.editControl1.UseXPStyleBorder = false;
            this.editControl1.VisualColumn = 1;
            // 
            // EditorContextMenuStripEx
            // 
            this.EditorContextMenuStripEx.BackColor = System.Drawing.Color.White;
            this.EditorContextMenuStripEx.DropShadowEnabled = false;
            this.EditorContextMenuStripEx.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem9,
            this.toolStripMenuItem10,
            this.toolStripSeparator30,
            this.runTestsToolStripMenuItem,
            this.debugTestsToolStripMenuItem,
            this.toolStripSeparator1,
            this.cutToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.toolStripSeparator2,
            this.outLiningsToolStripMenuItem});
            this.EditorContextMenuStripEx.MetroColor = System.Drawing.Color.Lavender;
            this.EditorContextMenuStripEx.Name = "EditorContextMenuStripEx";
            this.EditorContextMenuStripEx.Size = new System.Drawing.Size(155, 220);
            this.EditorContextMenuStripEx.Style = Syncfusion.Windows.Forms.Tools.ContextMenuStripEx.ContextMenuStyle.Metro;
            this.EditorContextMenuStripEx.Renderer = new ContextMenuRenderer();
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(154, 22);
            this.toolStripMenuItem1.Text = "&View Designer";
            // 
            // toolStripMenuItem9
            // 
            this.toolStripMenuItem9.Name = "toolStripMenuItem9";
            this.toolStripMenuItem9.Size = new System.Drawing.Size(154, 22);
            this.toolStripMenuItem9.Text = "&Refactor";
            this.toolStripMenuItem9.Click += new System.EventHandler(this.toolStripMenuItem9_Click);
            // 
            // toolStripMenuItem10
            // 
            this.toolStripMenuItem10.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.removeUnusedUsingToolStripMenuItem,
            this.sortUsingToolStripMenuItem});
            this.toolStripMenuItem10.Name = "toolStripMenuItem10";
            this.toolStripMenuItem10.Size = new System.Drawing.Size(154, 22);
            this.toolStripMenuItem10.Text = "&Organize Using";
            // 
            // removeUnusedUsingToolStripMenuItem
            // 
            this.removeUnusedUsingToolStripMenuItem.Name = "removeUnusedUsingToolStripMenuItem";
            this.removeUnusedUsingToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.removeUnusedUsingToolStripMenuItem.Text = "Remove Unused Usings";
            // 
            // sortUsingToolStripMenuItem
            // 
            this.sortUsingToolStripMenuItem.Name = "sortUsingToolStripMenuItem";
            this.sortUsingToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.sortUsingToolStripMenuItem.Text = "Sort Usings";
            // 
            // toolStripSeparator30
            // 
            this.toolStripSeparator30.Name = "toolStripSeparator30";
            this.toolStripSeparator30.Size = new System.Drawing.Size(151, 6);
            // 
            // runTestsToolStripMenuItem
            // 
            this.runTestsToolStripMenuItem.Name = "runTestsToolStripMenuItem";
            this.runTestsToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.runTestsToolStripMenuItem.Text = "Run Tests";
            // 
            // debugTestsToolStripMenuItem
            // 
            this.debugTestsToolStripMenuItem.Name = "debugTestsToolStripMenuItem";
            this.debugTestsToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.debugTestsToolStripMenuItem.Text = "Debug Tests";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(151, 6);
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.cutToolStripMenuItem.Text = "Cut";
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.copyToolStripMenuItem.Text = "Copy";
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.pasteToolStripMenuItem.Text = "Paste";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(151, 6);
            // 
            // outLiningsToolStripMenuItem
            // 
            this.outLiningsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tonggleToolStripMenuItem,
            this.toggleAllOutliningToolStripMenuItem,
            this.stopToolStripMenuItem,
            this.stopHidingCurrentToolStripMenuItem});
            this.outLiningsToolStripMenuItem.Name = "outLiningsToolStripMenuItem";
            this.outLiningsToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.outLiningsToolStripMenuItem.Text = "OutLinings";
            // 
            // tonggleToolStripMenuItem
            // 
            this.tonggleToolStripMenuItem.Name = "tonggleToolStripMenuItem";
            this.tonggleToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.tonggleToolStripMenuItem.Text = "Toggle Outlining Expansions";
            // 
            // toggleAllOutliningToolStripMenuItem
            // 
            this.toggleAllOutliningToolStripMenuItem.Name = "toggleAllOutliningToolStripMenuItem";
            this.toggleAllOutliningToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.toggleAllOutliningToolStripMenuItem.Text = "Toggle all Outlining";
            // 
            // stopToolStripMenuItem
            // 
            this.stopToolStripMenuItem.Name = "stopToolStripMenuItem";
            this.stopToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.stopToolStripMenuItem.Text = "Stop Outlining";
            // 
            // stopHidingCurrentToolStripMenuItem
            // 
            this.stopHidingCurrentToolStripMenuItem.Name = "stopHidingCurrentToolStripMenuItem";
            this.stopHidingCurrentToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.stopHidingCurrentToolStripMenuItem.Text = "Stop Hiding Current";
            // 
            // scrollersFrame1
            // 
            this.scrollersFrame1.AttachedTo = this.editControl1;
            this.scrollersFrame1.CustomRender = null;
            this.scrollersFrame1.MetroColorScheme = Syncfusion.Windows.Forms.MetroColorScheme.Managed;
            this.scrollersFrame1.SizeGripperVisibility = Syncfusion.Windows.Forms.SizeGripperVisibility.Auto;
            this.scrollersFrame1.VisualStyle = Syncfusion.Windows.Forms.ScrollBarCustomDrawStyles.Metro;
            // 
            // CodeEditorBase
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(776, 718);
            this.Controls.Add(this.editControl1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Name = "CodeEditorBase";
            this.Text = "CodeEditorBase";
            ((System.ComponentModel.ISupportInitialize)(this.childMenuBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxBarItem1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxAdv2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxAdv1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.editControl1)).EndInit();
            this.EditorContextMenuStripEx.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        #endregion

        #region BarItem Click Event
        private void OnBarItemClick(object sender, EventArgs e)
        {
            BarItem item = sender as BarItem;
            try
            {
                switch (item.ID)
                {
                    case "Undo":
                        this.editControl1.Undo();
                        break;
                    case "Redo":
                        this.editControl1.Redo();
                        break;
                    case "Cut":
                        this.editControl1.Cut();
                        break;
                    case "Copy":
                        this.editControl1.Copy();
                        break;
                    case "Paste":
                        this.editControl1.Paste();
                        break;
                    case "SelectAll":
                        this.editControl1.SelectAll();
                        break;
                    case "Find":
                        this.editControl1.ShowFindDialog();
                        break;
                    case "Replace":
                        this.editControl1.ShowReplaceDialog();
                        break;
                    case "Comment":
                        this.editControl1.CommentSelection();
                        break;
                    case "Uncomment":
                        this.editControl1.UncommentSelection();
                        break;
                    case "Indent":
                        this.editControl1.IndentSelection();
                        break;
                    case "Outdent":
                        this.editControl1.OutdentSelection();
                        break;
                    case "AddBookmark":
                        this.editControl1.BookmarkAdd(this.editControl1.CurrentLine);
                        break;
                    case "PrevBookmark":
                        this.editControl1.BookmarkPrevious();
                        break;
                    case "NextBookmark":
                        this.editControl1.BookmarkNext();
                        break;
                    case "RemoveBookmark":
                        this.editControl1.BookmarkRemove(this.editControl1.CurrentLine);
                        break;
                    case "ClearBookmark":
                        this.editControl1.BookmarkClear();
                        break;
                    case "ToggleBookmark":
                        this.editControl1.BookmarkToggle();
                        break;
                }
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);
            }
        }
        #endregion

        private void toolStripMenuItem9_Click(object sender, EventArgs e)
        {
        }

    }
    public class ContextMenuRenderer : ToolStripProfessionalRenderer
    {
        public ContextMenuRenderer()
        {

        }
        private Color menuBackColor = Color.White;
        public Color MenuColor
        {
            get
            {
                return menuBackColor;
            }
            set
            {
                menuBackColor = value;
            }
        }
        /// <summary>
        /// Is triggered when the margin for the image is rendered.
        /// </summary>
        /// <param name="e"></param>
        protected override void OnRenderImageMargin(ToolStripRenderEventArgs e)
        {
            Rectangle marginRect = e.AffectedBounds;
            using (SolidBrush backBrush = new SolidBrush(Color.White))
            {
                e.Graphics.FillRectangle(backBrush, marginRect);
            }
        }
        protected override void OnRenderItemBackground(ToolStripItemRenderEventArgs e)
        {
            base.OnRenderItemBackground(e);
        }
        protected override void OnRenderMenuItemBackground(ToolStripItemRenderEventArgs e)
        {
            using (SolidBrush backBrush = new SolidBrush(Color.LightSkyBlue))
            {
                if (e.Item.Selected)
                    e.Graphics.FillRectangle(backBrush, e.ToolStrip.Items[0].Bounds);
            }
        }
        /// <summary>
        /// Renders the image with different attributes
        /// </summary>
        /// <param name="e"></param>
        protected override void OnRenderItemImage(ToolStripItemImageRenderEventArgs e)
        {

            base.OnRenderItemImage(e);
        }
    }
}

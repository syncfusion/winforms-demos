#region Copyright Syncfusion Inc. 2001-2019.
// Copyright Syncfusion Inc. 2001-2019. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Syncfusion.Runtime.Serialization;
using Syncfusion.Windows.Forms;
using Syncfusion.Windows.Forms.Tools;
using System.IO;
using Syncfusion.Windows.Forms.Tools.XPMenus;
using System.Runtime.InteropServices;
using Syncfusion.WinForms.Controls;

namespace TabbedMDI_2005
{
    public partial class Form1 : SfForm
    {
        [DllImport("user32.dll")]
        static extern bool LockWindowUpdate(IntPtr hWndLock);
        private DemoCommon.AboutForm aboutForm = null;
        private bool tabWindowsOn = false;
        private int document1Count = 0;
        private Syncfusion.Windows.Forms.Tools.TabbedMDIManager tabbedMDIManager;

        public Form1()
        {
            InitializeComponent();
            this.MinimumSize = this.Size;
            try
            {
                System.Drawing.Icon ico = new System.Drawing.Icon(GetIconFile(@"common\Images\Grid\Icon\sfgrid1.ico"));
                this.Icon = ico;
            }
            catch { }

            //adding TabbedMDI Manager
            this.tabbedMDIManager = new Syncfusion.Windows.Forms.Tools.TabbedMDIManager();
            this.tabbedMDIManager.AttachedTo = this;
            this.tabbedMDIManager.DropDownButtonVisible = true;
            this.tabbedMDIManager.ImageSize = new System.Drawing.Size(16, 16);
            this.tabbedMDIManager.NeedUpdateHostedForm = false;
            this.tabbedMDIManager.TabStyle = typeof(Syncfusion.Windows.Forms.Tools.TabRendererOffice2016Colorful);
            this.tabbedMDIManager.BeforeDropDownPopup += new Syncfusion.Windows.Forms.Tools.DropDownPopupEventHandler(this.BeforePopup);
            this.tabbedMDIManager.TabControlAdded += new Syncfusion.Windows.Forms.Tools.TabbedMDITabControlEventHandler(this.tabbedMDIManager_TabControlAdded);
            // Trigger when right clicking on the tabs.
            this.tabbedMDIManager.ContextMenuItem.BeforePopup += new CancelEventHandler(ContextMenuItem_BeforePopup);
            this.propertyGrid1.SelectedObject = (object)this.tabbedMDIManager;
            this.FormClosing += new FormClosingEventHandler(Form1_FormClosing);
             
            this.NewDocClick(this, EventArgs.Empty);
            this.NewDocClick(this, EventArgs.Empty);
            this.NewDocClick(this, EventArgs.Empty);
            this.NewDocClick(this, EventArgs.Empty);

            // Turn on MDI Tabbed Documents mode.
            // Call this after loading the mdi children to restore their previous state.
            this.TabbedMDIOn = true;
            this.tabbedMDIManager.ContextMenuItem.Items.Add(this.closeAllContextMenuItem);
            this.tabbedMDIManager.ContextMenuItem.BeginGroupAt(closeAllContextMenuItem);
            this.tabbedMDIManager.ContextMenuItem.Items.Add(this.newDocumentContextMenuItem);
            this.tabbedMDIManager.ThemeName = "Office2019Colorful";

            if (File.Exists(@"..\..\persist.xml"))
            {
                AppStateSerializer serializer = new AppStateSerializer(SerializeMode.XMLFile, @"..\..\persist");
                this.tabbedMDIManager.LoadTabGroupStates(serializer);
                SendMessageToStatusBar("TabGroupStates loaded");
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

        void MainMenuBar_DrawBackground(object sender, PaintEventArgs e)
        {
            e.Graphics.FillRectangle(Brushes.White,e.ClipRectangle);
        }

        // Convenient way to toggle TabbedMDI mode.
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        internal bool TabbedMDIOn
        {
            get { return this.tabWindowsOn; }
            set
            {
                if (!(this.tabWindowsOn == value))
                {
                    this.tabWindowsOn = value;

                    if (this.tabWindowsOn)
                    {
                        this.tabbedMDIManager.AttachToMdiContainer(this);
                    }
                    else
                    {
                        this.tabbedMDIManager.DetachFromMdiContainer(this, false); // false to not invoke the Cascade mode after detaching.
                    }
                }
            }
        }

        internal TabbedMDIManager TabbedMDIManager
        {
            get { return this.tabbedMDIManager; }
        }

        private void SendMessageToStatusBar(string text)
        {
            this.statusBarAdvPanel1.Text = text;
        }

        TabControlAdv tabControl;
        // Triggered when a tabgroup host is created.
        private void tabbedMDIManager_TabControlAdded(object sender, Syncfusion.Windows.Forms.Tools.TabbedMDITabControlEventArgs args)
        {
            tabControl = args.TabControl;
            if (barItem18.Checked)
            {
                args.TabControl.Office2007ColorScheme = Office2007Theme.Blue;
            }
            else if (barItem19.Checked)
            {
                args.TabControl.Office2007ColorScheme = Office2007Theme.Black;
            }
            else if (barItem20.Checked)
            {
                args.TabControl.Office2007ColorScheme = Office2007Theme.Silver;
            }
        }

        //Add a document 
        private void AddDocument(Form doc)
        {
            doc.MdiParent = this;
            doc.Show();
            this.mdiListBarItem1.ChildCaptions.Add(doc.Name);
        }

        private void NewDocClick(object sender, EventArgs e)
        {
            this.checkBoxAdv4.Checked = true;
            this.tabbedMDIManager.ShowCloseButton = true;
            document1Count++;
            Document1 doc = new Document1("Document " + document1Count.ToString());
            AddDocument(doc);
            if(document1Count %2 ==0)
            this.tabbedMDIManager.ShowCloseButtonForForm(doc,true );
            // To set tooltip for the tabs
            this.tabbedMDIManager.SetTooltip(doc, "Tooltip for " + doc.Text);
        }

        private void UpdateTabPagesStyleforOffice2016Themes()
        {
            LockWindowUpdate(this.Handle);
            if (this.tabbedMDIManager != null && (this.tabbedMDIManager.TabStyle == typeof(TabRendererOffice2016Colorful) || this.tabbedMDIManager.TabStyle == typeof(TabRendererOffice2016White)))
            {
                if (this.tabbedMDIManager.MdiChildren != null)
                {
                    foreach (Form form in this.tabbedMDIManager.MdiChildren)
                    {
                        if (this.tabbedMDIManager.MdiChildren != null)
                        {
                            if (form != null && form.ActiveControl != null)
                            {
                                form.ActiveControl.BackColor = ColorTranslator.FromHtml("#ffffff");
                                form.ActiveControl.ForeColor = ColorTranslator.FromHtml("#262626");
                            }

                            if (form is Document1)
                            {
                                if (this.tabbedMDIManager.TabStyle == typeof(TabRendererOffice2016Colorful))
                                {
                                    (form as Document1).scrollersFrame1.VisualStyle = ScrollBarCustomDrawStyles.Office2016;
                                    (form as Document1).scrollersFrame1.Office2016ColorScheme = ScrollBarOffice2016ColorScheme.Colorful;
                                }
                                else
                                {
                                    (form as Document1).scrollersFrame1.VisualStyle = ScrollBarCustomDrawStyles.Office2016;
                                    (form as Document1).scrollersFrame1.Office2016ColorScheme = ScrollBarOffice2016ColorScheme.White;
                                }
                            }
                        }
                    }
                }

                //this.BorderColor = ColorTranslator.FromHtml("#c5c5c5");
                this.BackColor = ColorTranslator.FromHtml("#ffffff");
                this.ForeColor = ColorTranslator.FromHtml("#262626");
                this.statusBarAdv1.BackColor = ColorTranslator.FromHtml("#ffffff");
                this.statusBarAdv1.BorderColor = ColorTranslator.FromHtml("#c5c5c5");
                //this.propertyGrid1.BackColor = ColorTranslator.FromHtml("#ffffff");
                //this.propertyGrid1.ViewBackColor = ColorTranslator.FromHtml("#ffffff");
                //this.propertyGrid1.ViewForeColor = ColorTranslator.FromHtml("#262626");
                //this.propertyGrid1.ViewBorderColor = ColorTranslator.FromHtml("#c5c5c5");
                //this.propertyGrid1.HelpBackColor = ColorTranslator.FromHtml("#ffffff");
                //this.propertyGrid1.HelpForeColor = ColorTranslator.FromHtml("#262626");
                //this.propertyGrid1.HelpBorderColor = ColorTranslator.FromHtml("#c5c5c5");
                //this.propertyGrid1.LineColor = ColorTranslator.FromHtml("#c5c5c5");
                //this.propertyGrid1.CategoryForeColor = ColorTranslator.FromHtml("#262626");
                //this.propertyGrid1.CategorySplitterColor = ColorTranslator.FromHtml("#c5c5c5");
                //this.propertyGrid1.CommandsBorderColor = ColorTranslator.FromHtml("#c5c5c5");
                //this.propertyGrid1.CommandsActiveLinkColor = ColorTranslator.FromHtml("#ffffff");

                if (this.tabbedMDIManager.TabStyle == typeof(TabRendererOffice2016Colorful))
                {
                    this.mainFrameBarManager1.Style = Syncfusion.Windows.Forms.VisualStyle.Office2016Colorful;
                    this.parentBarItem1.Style = Syncfusion.Windows.Forms.VisualStyle.Office2016Colorful;
                    this.parentBarItem2.Style = Syncfusion.Windows.Forms.VisualStyle.Office2016Colorful;
                    this.StylesList.Style = Syncfusion.Windows.Forms.VisualStyle.Office2016Colorful;
                    this.parentBarItem4.Style = Syncfusion.Windows.Forms.VisualStyle.Office2016Colorful;
                    if (tabControlAdv1 != null)
                    {
                        this.tabControlAdv1.FixedSingleBorderColor = ColorTranslator.FromHtml("#c5c5c5");
                        this.tabControlAdv1.TabStyle = typeof(Syncfusion.Windows.Forms.Tools.TabRendererOffice2016Colorful);

                        foreach (TabPageAdv tabPage in this.tabControlAdv1.TabPages)
                        {
                            tabPage.BackColor = ColorTranslator.FromHtml("#ffffff");
                            tabPage.ForeColor = ColorTranslator.FromHtml("#262626");
                        }
                    }

                    //this.CaptionBarColor = ColorTranslator.FromHtml("#0173c7");
                    //this.CaptionForeColor = ColorTranslator.FromHtml("#ffffff");
                    //this.MetroColor = ColorTranslator.FromHtml("#0173c7");
                    this.comboBoxAdv1.Style = Syncfusion.Windows.Forms.VisualStyle.Office2016Colorful;
                    this.checkBoxAdv1.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Office2016Colorful;
                    this.checkBoxAdv2.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Office2016Colorful;
                    this.checkBoxAdv3.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Office2016Colorful;
                    this.checkBoxAdv4.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Office2016Colorful;
                    this.checkBoxAdv5.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Office2016Colorful;
                    this.checkBoxAdv6.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Office2016Colorful;
                    comboBoxAdv1.SelectedIndex = 6;
                }
                else
                {
                    this.mainFrameBarManager1.Style = Syncfusion.Windows.Forms.VisualStyle.Office2016White;
                    this.parentBarItem1.Style = Syncfusion.Windows.Forms.VisualStyle.Office2016White;
                    this.parentBarItem2.Style = Syncfusion.Windows.Forms.VisualStyle.Office2016White;
                    this.StylesList.Style = Syncfusion.Windows.Forms.VisualStyle.Office2016White;
                    this.parentBarItem4.Style = Syncfusion.Windows.Forms.VisualStyle.Office2016White;
                    if (tabControlAdv1 != null)
                    {
                        this.tabControlAdv1.FixedSingleBorderColor = ColorTranslator.FromHtml("#c5c5c5");
                        this.tabControlAdv1.TabStyle = typeof(Syncfusion.Windows.Forms.Tools.TabRendererOffice2016White);
                        foreach (TabPageAdv tabPage in this.tabControlAdv1.TabPages)
                        {
                            tabPage.BackColor = ColorTranslator.FromHtml("#ffffff");
                            tabPage.ForeColor = ColorTranslator.FromHtml("#262626");
                        }
                    }

                    //this.CaptionBarColor = ColorTranslator.FromHtml("#ffffff");
                    //this.CaptionForeColor = ColorTranslator.FromHtml("#262626");
                    //this.MetroColor = ColorTranslator.FromHtml("#ffffff");
                    this.comboBoxAdv1.Style = Syncfusion.Windows.Forms.VisualStyle.Office2016White;
                    this.checkBoxAdv1.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Office2016White;
                    this.checkBoxAdv2.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Office2016White;
                    this.checkBoxAdv3.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Office2016White;
                    this.checkBoxAdv4.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Office2016White;
                    this.checkBoxAdv5.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Office2016White;
                    this.checkBoxAdv6.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Office2016White;
                    comboBoxAdv1.SelectedIndex = 7;
                }
            }
            else if (this.tabbedMDIManager != null && this.tabbedMDIManager.TabStyle == typeof(TabRendererOffice2016DarkGray))
            {
                if (this.tabbedMDIManager.MdiChildren != null)
                {
                    foreach (Form form in this.tabbedMDIManager.MdiChildren)
                    {
                        if (form != null && form.ActiveControl != null)
                        {
                            form.ActiveControl.BackColor = ColorTranslator.FromHtml("#666666");
                            form.ActiveControl.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                        }

                        if (form is Document1)
                        {           
                            (form as Document1).scrollersFrame1.VisualStyle = ScrollBarCustomDrawStyles.Office2016;
                            (form as Document1).scrollersFrame1.Office2016ColorScheme = ScrollBarOffice2016ColorScheme.DarkGray;                         
                        }
                    }
                }

                //this.BorderColor = ColorTranslator.FromHtml("#444444");
                this.BackColor = ColorTranslator.FromHtml("#666666");
                this.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                //this.CaptionBarColor = ColorTranslator.FromHtml("#505050");
                //this.MetroColor = ColorTranslator.FromHtml("#505050");
                //this.CaptionForeColor = ColorTranslator.FromHtml("#f0f0f0");

                if (tabControlAdv1 != null)
                {
                    this.tabControlAdv1.FixedSingleBorderColor = ColorTranslator.FromHtml("#444444");
                    this.tabControlAdv1.TabStyle = typeof(Syncfusion.Windows.Forms.Tools.TabRendererOffice2016DarkGray);

                    foreach(TabPageAdv tabPage in this.tabControlAdv1.TabPages)
                    {
                        tabPage.BackColor = ColorTranslator.FromHtml("#666666");
                        tabPage.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                    }
                }
                
                this.statusBarAdv1.BackColor = ColorTranslator.FromHtml("#666666");
                this.statusBarAdv1.BorderColor = ColorTranslator.FromHtml("#444444");
                this.mainFrameBarManager1.Style = Syncfusion.Windows.Forms.VisualStyle.Office2016DarkGray;
                this.parentBarItem1.Style = Syncfusion.Windows.Forms.VisualStyle.Office2016DarkGray;
                this.parentBarItem2.Style = Syncfusion.Windows.Forms.VisualStyle.Office2016DarkGray;
                this.StylesList.Style = Syncfusion.Windows.Forms.VisualStyle.Office2016DarkGray;
                this.parentBarItem4.Style = Syncfusion.Windows.Forms.VisualStyle.Office2016DarkGray;
                this.comboBoxAdv1.Style = Syncfusion.Windows.Forms.VisualStyle.Office2016DarkGray;
                this.checkBoxAdv1.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Office2016DarkGray;
                this.checkBoxAdv2.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Office2016DarkGray;
                this.checkBoxAdv3.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Office2016DarkGray;
                this.checkBoxAdv4.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Office2016DarkGray;
                this.checkBoxAdv5.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Office2016DarkGray;
                this.checkBoxAdv6.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Office2016DarkGray;
                //this.propertyGrid1.BackColor = ColorTranslator.FromHtml("#666666");
                //this.propertyGrid1.ViewBackColor = ColorTranslator.FromHtml("#666666");
                //this.propertyGrid1.ViewForeColor = ColorTranslator.FromHtml("#f0f0f0");
                //this.propertyGrid1.ViewBorderColor = ColorTranslator.FromHtml("#444444");
                //this.propertyGrid1.HelpBackColor = ColorTranslator.FromHtml("#666666");
                //this.propertyGrid1.HelpForeColor = ColorTranslator.FromHtml("#f0f0f0");
                //this.propertyGrid1.HelpBorderColor = ColorTranslator.FromHtml("#444444");
                //this.propertyGrid1.LineColor = ColorTranslator.FromHtml("#444444");
                //this.propertyGrid1.CategoryForeColor = ColorTranslator.FromHtml("#f0f0f0");
                //this.propertyGrid1.CategorySplitterColor = ColorTranslator.FromHtml("#444444");
                //this.propertyGrid1.CommandsBorderColor = ColorTranslator.FromHtml("#444444");
                //this.propertyGrid1.CommandsActiveLinkColor = ColorTranslator.FromHtml("#666666");
                comboBoxAdv1.SelectedIndex = 8;
            }
            else if (this.tabbedMDIManager != null && this.tabbedMDIManager.TabStyle == typeof(TabRendererOffice2016Black))
            {
                if (this.tabbedMDIManager.MdiChildren != null)
                {
                    foreach (Form form in this.tabbedMDIManager.MdiChildren)
                    {
                        if (form != null && form.ActiveControl != null)
                        {
                            form.ActiveControl.BackColor = ColorTranslator.FromHtml("#262626");
                            form.ActiveControl.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                        }

                        if (form is Document1)
                        {
                            (form as Document1).scrollersFrame1.VisualStyle = ScrollBarCustomDrawStyles.Office2016;
                            (form as Document1).scrollersFrame1.Office2016ColorScheme = ScrollBarOffice2016ColorScheme.Black;
                        }
                    }
                }

                if (tabControlAdv1 != null)
                {
                    this.tabControlAdv1.FixedSingleBorderColor = ColorTranslator.FromHtml("#363636");
                    this.tabControlAdv1.TabStyle = typeof(Syncfusion.Windows.Forms.Tools.TabRendererOffice2016Black);
                    foreach (TabPageAdv tabPage in this.tabControlAdv1.TabPages)
                    {
                        tabPage.BackColor = ColorTranslator.FromHtml("#262626");
                        tabPage.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                    }
                }

                //this.BorderColor = ColorTranslator.FromHtml("#363636");
                this.BackColor = ColorTranslator.FromHtml("#262626");
               //this.MetroColor = ColorTranslator.FromHtml("#363636");
                this.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
               //this.CaptionBarColor = ColorTranslator.FromHtml("#363636");
                //this.CaptionForeColor = ColorTranslator.FromHtml("#f0f0f0");
                this.statusBarAdv1.BackColor = ColorTranslator.FromHtml("#262626");
                this.statusBarAdv1.BorderColor = ColorTranslator.FromHtml("#363636");
                this.mainFrameBarManager1.Style = Syncfusion.Windows.Forms.VisualStyle.Office2016Black;
                this.parentBarItem1.Style = Syncfusion.Windows.Forms.VisualStyle.Office2016Black;
                this.parentBarItem2.Style = Syncfusion.Windows.Forms.VisualStyle.Office2016Black;
                this.StylesList.Style = Syncfusion.Windows.Forms.VisualStyle.Office2016Black;
                this.parentBarItem4.Style = Syncfusion.Windows.Forms.VisualStyle.Office2016Black;
                this.comboBoxAdv1.Style = Syncfusion.Windows.Forms.VisualStyle.Office2016Black;
                this.checkBoxAdv1.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Office2016Black;
                this.checkBoxAdv2.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Office2016Black;
                this.checkBoxAdv3.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Office2016Black;
                this.checkBoxAdv4.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Office2016Black;
                this.checkBoxAdv5.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Office2016Black;
                this.checkBoxAdv6.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Office2016Black;
                //this.propertyGrid1.BackColor = ColorTranslator.FromHtml("#262626");
                //this.propertyGrid1.ViewBackColor = ColorTranslator.FromHtml("#262626");
                //this.propertyGrid1.ViewForeColor = ColorTranslator.FromHtml("#f0f0f0");
                //this.propertyGrid1.ViewBorderColor = ColorTranslator.FromHtml("#363636");
                //this.propertyGrid1.HelpBackColor = ColorTranslator.FromHtml("#262626");
                //this.propertyGrid1.HelpForeColor = ColorTranslator.FromHtml("#f0f0f0");
                //this.propertyGrid1.HelpBorderColor = ColorTranslator.FromHtml("#363636");
                //this.propertyGrid1.LineColor = ColorTranslator.FromHtml("#363636"); 
                //this.propertyGrid1.CategoryForeColor = ColorTranslator.FromHtml("#f0f0f0");
                //this.propertyGrid1.CategorySplitterColor = ColorTranslator.FromHtml("#363636");
                //this.propertyGrid1.CommandsBorderColor = ColorTranslator.FromHtml("#363636");
                //this.propertyGrid1.CommandsActiveLinkColor = ColorTranslator.FromHtml("#262626");
                comboBoxAdv1.SelectedIndex = 9;
            }
            else
            {
                if (this.tabbedMDIManager != null)
                {
                    if (this.tabbedMDIManager.MdiChildren != null)
                    {
                        foreach (Form form in this.tabbedMDIManager.MdiChildren)
                        {
                            if (form != null && form.ActiveControl != null)
                            {
                                form.ActiveControl.BackColor = System.Drawing.Color.White;
                                form.ActiveControl.ForeColor = System.Drawing.Color.MidnightBlue;
                            }

                            if (form is Document1)
                            {
                                (form as Document1).scrollersFrame1.VisualStyle = ScrollBarCustomDrawStyles.Metro;
                            }
                        }
                    }

                    //this.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
                    this.BackColor = System.Drawing.Color.White;
                    //this.MetroColor = System.Drawing.Color.White;
                    //this.CaptionBarColor = Color.White;
                    //this.CaptionForeColor = ColorTranslator.FromHtml("#343434");
                    this.statusBarAdv1.BackColor = System.Drawing.Color.White;
                    this.statusBarAdv1.BorderColor = System.Drawing.Color.LightGray;
                    this.mainFrameBarManager1.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
                    this.parentBarItem1.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
                    this.parentBarItem2.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
                    this.StylesList.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
                    this.parentBarItem4.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
                    this.comboBoxAdv1.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
                    this.checkBoxAdv1.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
                    this.checkBoxAdv2.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
                    this.checkBoxAdv3.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
                    this.checkBoxAdv4.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
                    this.checkBoxAdv5.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
                    this.checkBoxAdv6.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
                    //this.propertyGrid1.BackColor = Color.White;
                    //this.propertyGrid1.ViewBackColor = SystemColors.Window;
                    //this.propertyGrid1.ViewForeColor = SystemColors.WindowText;
                    //this.propertyGrid1.ViewBorderColor = SystemColors.ControlDark;
                    //this.propertyGrid1.HelpBackColor = Color.White;
                    //this.propertyGrid1.HelpForeColor = SystemColors.ControlText;
                    //this.propertyGrid1.HelpBorderColor = SystemColors.ControlDark;
                    //this.propertyGrid1.LineColor = SystemColors.InactiveBorder;
                    //this.propertyGrid1.CategoryForeColor = SystemColors.ControlText;
                    //this.propertyGrid1.CategorySplitterColor = SystemColors.Control;
                    //this.propertyGrid1.CommandsBorderColor = SystemColors.ControlDark;

                    comboBoxAdv1.SelectedIndex = 0;

                    if (tabControlAdv1 != null)
                    {
                        this.tabControlAdv1.FixedSingleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(178)))), ((int)(((byte)(227)))));
                        this.tabControlAdv1.TabStyle = typeof(Syncfusion.Windows.Forms.Tools.TabRendererMetro);
                        foreach (TabPageAdv tabPage in this.tabControlAdv1.TabPages)
                        {
                            tabPage.BackColor = Color.White;
                            tabPage.ForeColor = SystemColors.ControlText;
                        }
                    }
                }
            }
            LockWindowUpdate(IntPtr.Zero);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateTabPagesStyleforOffice2016Themes();
        }

        private void ToggleAlign(object sender, EventArgs e)
        {
            this.tabbedMDIManager.Horizontal = !this.tabbedMDIManager.Horizontal;
        }

        private void AppExit(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Parse(object sender, EventArgs e)
        {
            string children = String.Empty;
            foreach (Form form in this.tabbedMDIManager.MdiChildren)
            {
                children += form.Text + "\r\n";
            }
            MessageBox.Show(children);
        }

        private void Form1_MdiChildActivate(object sender, EventArgs e)
        {
            this.mainFrameBarManager1.MainMenuBar.DrawBackground += new PaintEventHandler(MainMenuBar_DrawBackground);
            if (this.ActiveMdiChild == null)
            {
                statusBarAdv1.Text = "";
            }
            else
            {
                statusBarAdv1.Text = this.ActiveMdiChild.Text;
            }
        }

        private void LoadState(object sender, EventArgs e)
        {
            AppStateSerializer serializer = new AppStateSerializer(SerializeMode.XMLFile, @"..\..\persist");
            this.tabbedMDIManager.LoadTabGroupStates(serializer);
            SendMessageToStatusBar("TabGroupStates loaded");
        }

        private void SaveState(object sender, EventArgs e)
        {
            AppStateSerializer serializer = new AppStateSerializer(SerializeMode.XMLFile, @"..\..\persist");
            this.tabbedMDIManager.SaveTabGroupStates(serializer);
            serializer.PersistNow();
            SendMessageToStatusBar("TabGroupStates saved");
        }

        private void CloseAll(object sender, EventArgs e)
        {
            foreach (Form f in this.tabbedMDIManager.MdiChildren)
            {
                if (this.ActiveMdiChild.Name != f.Name)
                    f.Close();
            }
        }

        private void ShowProperties(object sender, EventArgs e)
        {
            barItem7.Checked = !barItem7.Checked;

            tabControlAdv1.Visible = barItem7.Checked;
            splitter1.Visible = barItem7.Checked;
        }

        private void About(object sender, EventArgs e)
        {
            aboutForm = new DemoCommon.AboutForm(AppDomain.CurrentDomain.GetAssemblies());
            aboutForm.ShowDialog();
        }

        private void ContextMenuItem_BeforePopup(object sender, CancelEventArgs e)
        {
            switch (comboBoxAdv1.SelectedIndex)
            {
                case 0:
                    tabbedMDIManager.ContextMenuItem.Style = Syncfusion.Windows.Forms.VisualStyle.Default;
                    break;
                case 1:
                    tabbedMDIManager.ContextMenuItem.Style = Syncfusion.Windows.Forms.VisualStyle.Office2003;
                    break;
                case 2:
                    tabbedMDIManager.ContextMenuItem.Style = Syncfusion.Windows.Forms.VisualStyle.VS2005;
                    break;
                case 3:
                    tabbedMDIManager.ContextMenuItem.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007;
                    break;
                case 4:
                    tabbedMDIManager.ContextMenuItem.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007Outlook;
                    break;
                case 5:
                    tabbedMDIManager.ContextMenuItem.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
                    break;
            }
            //Disables the "Close All But this" barItem when the number of Tab Pages are equal to one.
            int i = 0;
            foreach (Form f in this.tabbedMDIManager.MdiChildren)
            {
                i = i + 1;
            }
            if (i < 2)
                this.closeAllContextMenuItem.Enabled = false;
            else
                this.closeAllContextMenuItem.Enabled = true;
        }

        // This event triggers before dropdown button shows its mdi list.
        private void BeforePopup(object sender, Syncfusion.Windows.Forms.Tools.DropDownPopupEventArgs e)
        {
            switch (comboBoxAdv1.SelectedIndex)
            {
                case 0:
                     e.ParentBarItem.Style = Syncfusion.Windows.Forms.VisualStyle.Default;
                     tabbedMDIManager.ContextMenuItem.Style = Syncfusion.Windows.Forms.VisualStyle.Default;
                    break;
                case 1:
                    e.ParentBarItem.Style = Syncfusion.Windows.Forms.VisualStyle.Office2003;
                    tabbedMDIManager.ContextMenuItem.Style = Syncfusion.Windows.Forms.VisualStyle.Office2003;
                    break;
                case 2:
                    e.ParentBarItem.Style = Syncfusion.Windows.Forms.VisualStyle.VS2005;
                    tabbedMDIManager.ContextMenuItem.Style = Syncfusion.Windows.Forms.VisualStyle.VS2005;
                    break;
                case 3:
                    e.ParentBarItem.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007;
                    tabbedMDIManager.ContextMenuItem.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007;
                    break;
                case 4:
                    e.ParentBarItem.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007Outlook;
                    tabbedMDIManager.ContextMenuItem.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007Outlook;
                    break;
                case 5:
                    e.ParentBarItem.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
                    tabbedMDIManager.ContextMenuItem.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
                    break;
                case 6:
                    e.ParentBarItem.Style = Syncfusion.Windows.Forms.VisualStyle.Office2016Colorful;
                    tabbedMDIManager.ContextMenuItem.Style = Syncfusion.Windows.Forms.VisualStyle.Office2016Colorful;
                    break;
                case 7:
                    e.ParentBarItem.Style = Syncfusion.Windows.Forms.VisualStyle.Office2016White;
                    tabbedMDIManager.ContextMenuItem.Style = Syncfusion.Windows.Forms.VisualStyle.Office2016White;
                    break;
                case 8:
                    e.ParentBarItem.Style = Syncfusion.Windows.Forms.VisualStyle.Office2016DarkGray;
                    tabbedMDIManager.ContextMenuItem.Style = Syncfusion.Windows.Forms.VisualStyle.Office2016DarkGray;
                    break;
                case 9:
                    e.ParentBarItem.Style = Syncfusion.Windows.Forms.VisualStyle.Office2016Black;
                    tabbedMDIManager.ContextMenuItem.Style = Syncfusion.Windows.Forms.VisualStyle.Office2016Black;
                    break;


            }
        }

        public void MenuCheckRemove(Syncfusion.Windows.Forms.Tools.XPMenus.BarItem Item)
        {
            foreach (BarItem barItem in this.StylesList.Items)
            {
                if (barItem != Item)
                {
                    ((BarItem)barItem).Checked = false;

                }
                else
                    ((BarItem)barItem).Checked = true;
            }
        }

        // Changing the tab style.
        private void TabStyles_Click(object sender, System.EventArgs e)
        {
            this.MenuCheckRemove((BarItem)sender);

            if (this.barItem8.Checked)
                this.tabbedMDIManager.TabStyle = typeof(Syncfusion.Windows.Forms.Tools.TabRenderer2D);
            else if (this.barItem9.Checked)
                this.tabbedMDIManager.TabStyle = typeof(Syncfusion.Windows.Forms.Tools.TabRenderer3D);
            else if (this.barItem10.Checked)
                this.tabbedMDIManager.TabStyle = typeof(Syncfusion.Windows.Forms.Tools.TabRendererWorkbookMode);
            else if (this.barItem11.Checked)
                this.tabbedMDIManager.TabStyle = typeof(Syncfusion.Windows.Forms.Tools.OneNoteStyleRenderer);
            else if (this.barItem12.Checked)
                this.tabbedMDIManager.TabStyle = typeof(Syncfusion.Windows.Forms.Tools.OneNoteStyleFlatTabsRenderer);
            else if (this.barItem13.Checked)
                this.tabbedMDIManager.TabStyle = typeof(Syncfusion.Windows.Forms.Tools.TabRendererOffice2003);
            else if (this.barItem14.Checked)
                this.tabbedMDIManager.TabStyle = typeof(Syncfusion.Windows.Forms.Tools.TabRendererWhidbey);
            else if (this.barItem15.Checked)
                this.tabbedMDIManager.TabStyle = typeof(Syncfusion.Windows.Forms.Tools.TabRendererDockingWhidbey);
            else if (this.barItem16.Checked)
                this.tabbedMDIManager.TabStyle = typeof(Syncfusion.Windows.Forms.Tools.TabRendererDockingWhidbeyBeta);
            else if (this.barItem17.Checked)
                this.tabbedMDIManager.TabStyle = typeof(Syncfusion.Windows.Forms.Tools.TabRendererIE7);

            // TabbedMDIManager does not have Office2007 Black and Silver them
            // Hence accessing the internal tabControlAdv and applying
            // 
            else if (this.barItem18.Checked)
            {
                this.tabbedMDIManager.TabStyle = typeof(Syncfusion.Windows.Forms.Tools.TabRendererOffice2007);

                foreach (TabHost tabhost in tabbedMDIManager.TabGroupHosts)
                    tabhost.MDITabPanel.Office2007ColorScheme = Office2007Theme.Blue;

            }
            else if (this.barItem19.Checked)
            {
                this.tabbedMDIManager.TabStyle = typeof(Syncfusion.Windows.Forms.Tools.TabRendererOffice2007);

                foreach (TabHost tabhost in tabbedMDIManager.TabGroupHosts)
                    tabhost.MDITabPanel.Office2007ColorScheme = Office2007Theme.Black;

            }
            else if (this.barItem20.Checked)
            {
                this.tabbedMDIManager.TabStyle = typeof(Syncfusion.Windows.Forms.Tools.TabRendererOffice2007);

                foreach (TabHost tabhost in tabbedMDIManager.TabGroupHosts)
                    tabhost.MDITabPanel.Office2007ColorScheme = Office2007Theme.Silver;
            }
            else if (this.barItem22.Checked)
                this.tabbedMDIManager.TabStyle = typeof(Syncfusion.Windows.Forms.Tools.TabRendererBlendLight);
            else if (this.barItem23.Checked)
                this.tabbedMDIManager.TabStyle = typeof(Syncfusion.Windows.Forms.Tools.TabRendererBlendDark);
            else if (this.barItem24.Checked)
            {
                this.tabbedMDIManager.TabStyle = typeof(Syncfusion.Windows.Forms.Tools.TabRendererOffice2016Colorful);
                this.tabControlAdv1.TabStyle = typeof(Syncfusion.Windows.Forms.Tools.TabRendererOffice2016Colorful);
            }
            else if (this.barItem25.Checked)
            {
                this.tabbedMDIManager.TabStyle = typeof(Syncfusion.Windows.Forms.Tools.TabRendererOffice2016White);
                this.tabControlAdv1.TabStyle = typeof(Syncfusion.Windows.Forms.Tools.TabRendererOffice2016White);
            }
            else if (this.barItem26.Checked)
            {
                this.tabbedMDIManager.TabStyle = typeof(Syncfusion.Windows.Forms.Tools.TabRendererOffice2016DarkGray);
                this.tabControlAdv1.TabStyle = typeof(Syncfusion.Windows.Forms.Tools.TabRendererOffice2016DarkGray);
            }
            else if (this.barItem27.Checked)
            {
                this.tabbedMDIManager.TabStyle = typeof(Syncfusion.Windows.Forms.Tools.TabRendererOffice2016Black);
                this.tabControlAdv1.TabStyle = typeof(Syncfusion.Windows.Forms.Tools.TabRendererOffice2016Black);
            }

            this.UpdateTabPagesStyleforOffice2016Themes();
               
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void checkBoxAdv6_CheckedChanged(object sender, EventArgs e)
        {
            //Show or Hide MDI List dropdown.
            this.tabbedMDIManager.DropDownButtonVisible = !this.tabbedMDIManager.DropDownButtonVisible;
            SendMessageToStatusBar("DropDownButtonVisible set to " + this.checkBoxAdv6.Checked.ToString());
        }

        private void checkBoxAdv1_CheckedChanged(object sender, EventArgs e)
        {
            // Show or hide the close button.
            this.tabbedMDIManager.CloseButtonVisible = !this.tabbedMDIManager.CloseButtonVisible;
            SendMessageToStatusBar("CloseButton Visible set to " + this.checkBoxAdv1.Checked.ToString());
        }

        private void checkBoxAdv2_CheckedChanged(object sender, EventArgs e)
        {
            // Close the child form when clicking the tab using the middle mouse button.
            this.tabbedMDIManager.CloseOnMiddleButtonClick = checkBoxAdv2.Checked;
            SendMessageToStatusBar("CloseOnMiddleButtonClick set to " + checkBoxAdv2.Checked.ToString());
        }

        private void checkBoxAdv4_CheckedChanged(object sender, EventArgs e)
        {
            // Show or Hide child form icons.
            this.tabbedMDIManager.UseIconsInTabs = !this.tabbedMDIManager.UseIconsInTabs;
            SendMessageToStatusBar("UseIconInTabs set to " + this.checkBoxAdv4.Checked.ToString());
        }

        private void checkBoxAdv3_CheckedChanged(object sender, EventArgs e)
        {
            // Show or Hide the tab panel.
            this.tabbedMDIManager.Visible = !this.tabbedMDIManager.Visible;
            SendMessageToStatusBar("TabbedMDIManager visibility set to " + this.checkBoxAdv3.Checked.ToString());
        }

        private void checkBoxAdv5_CheckedChanged(object sender, EventArgs e)
        {
            // Show or Hide close button for individual tabs.
            if (this.checkBoxAdv5.Checked)
            {
                this.tabbedMDIManager.ShowCloseButton = false;
                this.tabbedMDIManager.ShowCloseButton = !this.tabbedMDIManager.ShowCloseButton;
            }
            else
            {
                this.tabbedMDIManager.ShowCloseButton = false;
            }
            SendMessageToStatusBar("ShowCloseButton set to " + this.checkBoxAdv5.Checked.ToString());
        }

        void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.tabbedMDIManager.LockHostFormUpdate();
        }
    }
}
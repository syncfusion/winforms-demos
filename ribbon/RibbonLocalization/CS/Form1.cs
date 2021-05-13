#region Copyright Syncfusion Inc. 2001 - 2019
// Copyright Syncfusion Inc. 2001 - 2019. All rights reserved.
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
using Syncfusion.Windows.Forms.Tools;
using Syncfusion.Windows.Forms;

namespace RibbonControlMerging
{
    public partial class Form1 : RibbonForm
    {
        #region Form Constructor
        
        TabBarPage page = new TabBarPage();
        int sheetnumber = 2;
        public Form1()
        {
            LocalizationProvider.Provider = new localization();
            InitializeComponent();
            this.pictureBox1.Height += 5;
            this.ribbonControlAdv1.QuickPanelVisible = true;
            this.ribbonControlAdv1.MenuColor = ColorTranslator.FromHtml("#217346");
            this.statusStripEx1.BackColor = ColorTranslator.FromHtml("#217346");
            this.statusStripLabel1.ForeColor = Color.White;
            this.ribbonControlAdv1.MenuButtonText = "File";
            this.ribbonControlAdv1.UseDefaultHighlightColor = false;
            this.trackBarItem1.TrackBarExControl.Style = TrackBarEx.Theme.Metro;
            this.trackBarItem1.TrackBarExControl.BackColor = ColorTranslator.FromHtml("#217346");
            this.trackBarItem1.TrackBarExControl.ButtonSignColor = ColorTranslator.FromHtml("#09542b");
            this.trackBarItem1.TrackBarExControl.ForeColor = Color.White;
            this.trackBarItem1.TrackBarExControl.ShowButtons = true;
            this.backStageButton1.Click += new EventHandler(backStage1_Click);
            
            foreach (ToolStripTabItem items in this.ribbonControlAdv1.Header.MainItems)
            {
                foreach (ToolStripEx item in items.Panel.Controls)
                {
                    item.LauncherClick += new EventHandler(item_LauncherClick);
                }
            }
            this.ribbonControlAdv1.MenuButtonText = "文件";           
            this.page.Dock = DockStyle.Fill;
            this.WindowState = FormWindowState.Maximized;
            page.Text = "TabBarPage1";
           
            this.gridControl1.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.gridControl1.Dock = DockStyle.Fill;
            this.gridControl1.GridVisualStyles = GridVisualStyles.Metro;
           
            this.gridControl1.Dock = DockStyle.Fill;
            this.gridControl1.AlphaBlendSelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(94)))), ((int)(((byte)(171)))), ((int)(((byte)(222)))));
            this.gridControl1.ColCount = 100;
            this.gridControl1.DefaultGridBorderStyle = Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid;
            this.gridControl1.DefaultRowHeight = 20;
            this.gridControl1.GridOfficeScrollBars = Syncfusion.Windows.Forms.OfficeScrollBars.Metro;
            this.gridControl1.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro;
            this.gridControl1.Location = new System.Drawing.Point(189, 136);
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
            this.gridControl1.Size = new System.Drawing.Size(321, 189);
            this.gridControl1.SmartSizeBox = false;
            this.gridControl1.TabIndex = 2;
            this.gridControl1.Text = "gridControl1";
            this.gridControl1.ThemesEnabled = true;
            this.gridControl1.UseRightToLeftCompatibleTextBox = true;             
            GridMetroColors theme = new GridMetroColors();
            this.gridControl1.QueryCellInfo += new Syncfusion.Windows.Forms.Grid.GridQueryCellInfoEventHandler(gridControl1_QueryCellInfo);
            theme.HeaderBottomBorderWeight = GridBottomBorderWeight.Thick;
            theme.HeaderBottomBorderColor = ColorTranslator.FromHtml("#217346");
            theme.HeaderColor.HoverColor = ColorTranslator.FromHtml("#9fd5b7");
            theme.HeaderTextColor.NormalTextColor = Color.Black;
            this.gridControl1.SetMetroStyle(theme);
            this.tabBarSplitterControl2.ActivePageBorderColor = ColorTranslator.FromHtml("#217346");
            this.tabBarSplitterControl2.ShowAddNewTabBarPageOption = true;
            this.panel3.MouseDown += new MouseEventHandler(panel3_MouseDown);
            foreach (Control ctrl in this.panel3.Controls)
            {
                ctrl.MouseDown+=new MouseEventHandler(panel3_MouseDown);
            }
            this.ribbonControlAdv1.ShowRibbonDisplayOptionButton = true;
            this.ribbonControlAdv1.TouchMode = false;
            this.ribbonControlAdv1.SetRibbon2013OptionValues(ControlItems.AutoHide, "自动隐藏丝带", "隐藏功能区。点击顶部的应用程序来显示它。", new Font("Segoe UI", 12), this.Font);
            this.ribbonControlAdv1.SetRibbon2013OptionValues(ControlItems.RibbonMinimizePanel, "显示卡", "仅显示功能区选项卡。点击标签，显示命令", new Font("Segoe UI", 12), this.Font);
            this.ribbonControlAdv1.SetRibbon2013OptionValues(ControlItems.RibbonPanel, "显示标签和命令", "显示功能区选项卡和注释的所有时间", new Font("Segoe UI", 12), this.Font);
        }

        void gridControl1_QueryCellInfo(object sender, Syncfusion.Windows.Forms.Grid.GridQueryCellInfoEventArgs e)
        {
            if (e.RowIndex == 0 || e.ColIndex == 0)
            {
                e.Style.Font.Bold = false;
            }
        }

        void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            this.backStageView1.HideBackStage();
        }
        
       
        #endregion
        #region Form Icon
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
        #endregion
       
        #region Events
        private void Form1_Load(object sender, EventArgs e)
        {
            this.trackBarItem1.TrackBarExControl.ButtonSignColor = Color.White;
            this.HelpButton = false;
            this.superAccelerator1.BackColor = Color.Black;
            this.superAccelerator1.ForeColor = Color.White;
            this.superAccelerator1.SetMenuButtonAccelerator(this.ribbonControlAdv1, "F");
            this.superAccelerator1.SetAccelerator(this.backStageTab2, "N");
            this.superAccelerator1.SetAccelerator(this.backStageButton1, "E");
            this.superAccelerator1.SetAccelerator(this.backStageButton2, "O");
            this.superAccelerator1.SetAccelerator(this.backStageButton3, "S");
            this.superAccelerator1.Appearance = Syncfusion.Windows.Forms.Tools.Appearance.Advanced;
            this.ribbonControlAdv1.ShowQuickItemsDropDownButton = true;
            //To add items in the QAT
            ToolStripButton saveItem = new ToolStripButton(imageList1.Images[1]);
            QuickButtonReflectable quick = new QuickButtonReflectable(saveItem);
            this.ribbonControlAdv1.Header.AddQuickItem(quick);
            this.superAccelerator1.SetAccelerator(saveItem, "SA");
            this.gridControl1.Dock = DockStyle.Fill;
            gridControl1.RowStyles[0].Font.Bold = false;
            this.toolStripFontfaceComboBox.SelectedIndex = 0;
            this.toolStripFontSizeComboBox.SelectedIndex = 0;
            this.tabBarSplitterControl2.ShowAddNewTabBarPageOption = false;
            this.backStageButton2.Click += new EventHandler(backStageButton2_Click);
            this.backStageButton3.Click += new EventHandler(backStageButton3_Click);
        }

        void backStageButton3_Click(object sender, EventArgs e)
        {
            this.backStageView1.HideBackStage();
            this.saveFileDialog1.ShowDialog();
        }

        void backStageButton2_Click(object sender, EventArgs e)
        {
            this.backStageView1.HideBackStage();
            this.openFileDialog1.ShowDialog();
        }
        TouchStyleColorTable touch = new TouchStyleColorTable();
        /// <summary>
        /// Event will be triggered on Exit button click.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void backStage1_Click(object sender, EventArgs e)
        {
            this.Close();
        
        }
        /// <summary>
        /// Event will be triggered when control is added in tabBarSplitterControl1.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void tabBarSplitterControl1_ControlAdded(object sender, ControlEventArgs e)
        {
            if (e.Control is TabBarPage)
            {
                e.Control.Text = "片" + sheetnumber.ToString();
                sheetnumber++;
                Syncfusion.Windows.Forms.Grid.GridControl gridControl = new Syncfusion.Windows.Forms.Grid.GridControl();
                
                gridControl.Dock = DockStyle.Fill;
                gridControl.AlphaBlendSelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(94)))), ((int)(((byte)(171)))), ((int)(((byte)(222)))));
                gridControl.ColCount = 100;
                gridControl.DefaultGridBorderStyle = Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid;
                gridControl.DefaultRowHeight = 20;                
                gridControl.Location = new System.Drawing.Point(189, 136);                
                gridControl.Name = "gridControl1";
                gridControl.Properties.ForceImmediateRepaint = false;
                gridControl.Properties.GridLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
                gridControl.Properties.MarkColHeader = false;
                gridControl.Properties.MarkRowHeader = false;
                gridControl.RowCount = 100;
                gridControl.RowHeightEntries.AddRange(new Syncfusion.Windows.Forms.Grid.GridRowHeight[] {
            new Syncfusion.Windows.Forms.Grid.GridRowHeight(0, 29)});
                gridControl.SerializeCellsBehavior = Syncfusion.Windows.Forms.Grid.GridSerializeCellsBehavior.SerializeAsRangeStylesIntoCode;
                gridControl.Size = new System.Drawing.Size(321, 189);
                gridControl.SmartSizeBox = false;
                gridControl.TabIndex = 2;
                gridControl.Text = "gridControl1";
                gridControl.ThemesEnabled = true;
                GridMetroColors theme = new GridMetroColors();
                theme.HeaderBottomBorderWeight = GridBottomBorderWeight.Thick;
                theme.HeaderBottomBorderColor = ColorTranslator.FromHtml("#217346");
                theme.HeaderColor.HoverColor = ColorTranslator.FromHtml("#9fd5b7");
                theme.HeaderTextColor.NormalTextColor = Color.Black;
                gridControl.SetMetroStyle(theme);
                e.Control.Controls.Add(gridControl);
            }
        }

        /// <summary>
        /// This event raises when the launcher is clicked
        /// </summary>
        /// <param name="sender">Instance of the Object</param>
        /// <param name="e">Contains data for the source</param>
        void item_LauncherClick(object sender, EventArgs e)
        {
            MessageBox.Show("Launcher is clicked", "Launcher");
        }
        #endregion
        
        private void panel3_MouseEnter(object sender, EventArgs e)
        {
            this.panel3.BackColor = ColorTranslator.FromHtml("#d3f0e0");
            this.label3.BackColor = ColorTranslator.FromHtml("#d3f0e0");
        }

        private void panel3_MouseLeave(object sender, EventArgs e)
        {
            this.panel3.BackColor = Color.White;
            this.label3.BackColor = Color.White;
        }

    }

    #region Localization 
    class localization : ILocalizationProvider
    {

        public string GetLocalizedString(System.Globalization.CultureInfo culture, string stringname, object obj)
        {

            switch (stringname)
            {

                case ToolsResourceIdentifiers.CustomizeRibbonDialogButtonAdd:
                    return "啊錒别 ";
                case ToolsResourceIdentifiers.CustomizeRibbonDialogButtonRemove:
                    return "可用呢  ";
                case ToolsResourceIdentifiers.CustomizeRibbonDialogButtonCancel:
                    return "锕如如 ";
                case ToolsResourceIdentifiers.CustomizeRibbonDialogButtonOk:
                    return "别";
                case ToolsResourceIdentifiers.CustomizeRibbonDialogButtonReset:
                    return "地方把小";
                case ToolsResourceIdentifiers.CustomizeRibbonDialogLabel:
                    return "都非";
                case ToolsResourceIdentifiers.CustomizeRibbonDialogChooseCommands:
                    return "无后们 ";
                case ToolsResourceIdentifiers.CustomizeRibbonDialogMainTab:
                    return "无拍  ";
                case ToolsResourceIdentifiers.CustomizeRibbonDialogButtonNewGroup:
                    return "才了  ";
                case ToolsResourceIdentifiers.CustomizeRibbonDialogButtonNewTab:
                    return "来把 ";
                case ToolsResourceIdentifiers.CustomizeRibbonDialogButtonRename:
                    return "人额女";
                case ToolsResourceIdentifiers.CustomizeRibbonDialogCustomizationLabel:
                    return "才上 来锕把";
                case ToolsResourceIdentifiers.CustomizeRibbonDialogCaption:
                    return "才上 人额女";
                case ToolsResourceIdentifiers.CustomizeQuickAccessLabel:
                    return "才上 来锕把";
                case ToolsResourceIdentifiers.QuickAccessCustomizeMenu:
                    return "啊錒别";
                case ToolsResourceIdentifiers.QuickAccessAddItem:
                    return "啊錒别";

                case ToolsResourceIdentifiers.QuickAccessDialogButtonAdd:
                    return "啊錒别";
                case ToolsResourceIdentifiers.QuickAccessDialogButtonCancel:
                    return "锕如如";
                case ToolsResourceIdentifiers.QuickAccessDialogButtonOk:
                    return "别";
                case ToolsResourceIdentifiers.QuickAccessDialogButtonReset:
                    return "地方把小";
                case ToolsResourceIdentifiers.QuickAccessDialogButtonRemove:
                    return "可用呢";
                case ToolsResourceIdentifiers.QuickAccessMinimizeTheRibbon:
                    return "啊錒别 如额呢";
                case ToolsResourceIdentifiers.QuickAccessPlaceAboveRibbon:
                    return "錒为你 啊錒别 ";
                case ToolsResourceIdentifiers.QuickAccessPlaceBelowRibbon:
                    return "地方把小 无不的 ";
                case ToolsResourceIdentifiers.QuickAccessToolBarLabel:
                    return "地方把小 无不的 ";


                case ToolsResourceIdentifiers.CustomizeRibbonDialogRenameCancelButton:
                    return "锕如如";
                case ToolsResourceIdentifiers.CustomizeRibbonDialogRenameCaption:
                    return "如额你啊吗额";
                case ToolsResourceIdentifiers.CustomizeRibbonDialogRenameOkButton:
                    return "别";
                case ToolsResourceIdentifiers.CustomizeRibbonRenameDisplayLabel:
                    return "都三片来啊 了阿不";

                case ToolsResourceIdentifiers.CustomizationLabel:
                    return "都三片来啊 了阿不";
                case ToolsResourceIdentifiers.CustomizeMenu:
                    return "都三片来啊 了阿不";
                case ToolsResourceIdentifiers.QuickAccessDialogDropDownName:
                    return "都三片来啊 了阿不";
                case ToolsResourceIdentifiers.QuickAccessCustomizeCaption:
                    return "都三片来啊 ";
                case ToolsResourceIdentifiers.QuickAccessDialogCommands:
                    return "都三片来啊 ";
                case ToolsResourceIdentifiers.CustomizeRibbonDialogColumnHeader:
                    return "都三片来啊 ";

                case ToolsResourceIdentifiers.CustomMenu:
                    return "都三片来啊 ";
                case ToolsResourceIdentifiers.QuickAccessDialogCustomizeRibbon:
                    return "都三片来啊 ";                
                
                default:
                    return string.Empty;

            }
        }
    }
#endregion
}
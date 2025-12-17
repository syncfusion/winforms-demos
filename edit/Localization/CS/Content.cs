#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
#region namespace
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
using Syncfusion.WinForms.Controls;
using Syncfusion.WinForms.Core;
using Syncfusion.Windows.Forms.Edit.Enums;
using System.Drawing.Drawing2D;
using Syncfusion.Windows.Forms.Edit.Interfaces;
using Syncfusion.Windows.Forms.Edit;
using System.Diagnostics;
using Syncfusion.Windows.Forms.Edit.Dialogs;
#endregion

namespace VisualStudioDemo
{
    public partial class Form1 : SfForm
    {
        private string configPath = Path.GetDirectoryName(Application.ExecutablePath) + @"\..\..\config.xml";
        private string config = Path.GetDirectoryName(Application.ExecutablePath) + @"..\..\..\Test Files\Config.xml";
        private SplashPanel splashPanel1;
        private SplashControl splashControl1;
        private bool isMouseHover;
        public Form1() 
        {
            InitializeComponent();
            try
            {
                System.Drawing.Icon ico = new System.Drawing.Icon(GetIconFile(@"..\\..\\\VS.ico"));
                this.Icon = ico;
            }
            catch { }
            this.Load += new EventHandler(Form1_Load);
            this.AddTreeNode();
            this.AddMainFrameBarManagerItem();
            this.AddItemsUnderFile();
            this.AddItemsUnderEdit();
            this.AddItemsUnderView();
            this.AddItemsUnderWindow();
            this.AddItemsUnderOutput();
            this.AddItemsUnderHelp();
            this.Addsearch();
            this.AddOutlining();
            this.editControl1.SaveOnClose = false;
            this.ColorCustomization();
            this.BaritemCustomization();
            this.AddSplashPanel();
        }

        #region  Color Customization

        /// <summary>
        ///Color customization 
        /// </summary>
        public void ColorCustomization()
        {
            this.editControl1.ShowIndicatorMargin = true;
            this.editControl1.CurrentLineHighlightColor = ColorTranslator.FromHtml("#c6c6c6");
            this.treeViewAdv1.MetroColorTable.ScrollerBackground = ColorTranslator.FromHtml("#e8e8ec");
            this.treeViewAdv1.MetroColorTable.ThumbNormal = ColorTranslator.FromHtml("#c2c3c9");
            this.treeViewAdv1.MetroColorTable.ThumbPushed = ColorTranslator.FromHtml("#5b5b5b");
            this.treeViewAdv1.MetroColorTable.ArrowNormal = ColorTranslator.FromHtml("#868999");
            this.treeViewAdv1.MetroColorTable.ArrowPushed = ColorTranslator.FromHtml("#1c97ea");
            this.treeViewAdv1.MetroColor = ColorTranslator.FromHtml("#1c97ea");
            this.treeViewAdv2.Style = TreeStyle.Metro;
            this.editControl1.LineNumbersColor = ColorTranslator.FromHtml("#3399ff");
            this.editControl1.ShowContextTooltip = true;
            this.editControl1.ShowLineNumbers = true;
            this.editControl1.ShowContentDividers = true;
            this.editControl1.ShowOutliningCollapsers = true;
            this.editControl1.ShowHorizontalScroller = true;
            this.editControl1.ScrollVisualStyle = ScrollBarCustomDrawStyles.Metro;
            this.editControl1.KeyDown += Form1_KeyDown;
            this.editControl1.Configurator.Open(configPath);
            this.editControl1.ApplyConfiguration("C#");
            this.editControl1.LoadFile(Path.GetDirectoryName(Application.ExecutablePath) + @"\..\..\Form1.cs");
            this.editControl1.UpdateContextToolTip += EditControl1_UpdateContextToolTip1;
            this.editControl1.ContextChoiceBeforeOpen += new System.ComponentModel.CancelEventHandler(this.editControl1_ContextChoiceBeforeOpen);
            this.editControl1.ContextChoiceOpen += new Syncfusion.Windows.Forms.Edit.ContextChoiceEventHandler(this.editControl1_ContextChoiceOpen);
            this.editControl1.ContextChoiceClose += new Syncfusion.Windows.Forms.Edit.ContextChoiceCloseEventHandler(this.editControl1_ContextChoiceClose);
            this.editControl1.ContextPromptBeforeOpen += EditControl1_ContextChoiceBeforeOpen;
            this.editControl1.ContextPromptOpen += EditControl1_ContextPromptOpen;
            this.editControl1.ContextPromptClose += EditControl1_ContextPromptClose;
            this.editControl1.ContextChoiceItemSelected += new Syncfusion.Windows.Forms.Edit.ContextChoiceItemSelectedEventHandler(this.editControl1_ContextChoiceItemSelected);
            this.editControl1.ContextPromptSelectionChanged += new Syncfusion.Windows.Forms.Edit.ContextPromptSelectionChangedEventHandler(this.editControl1_ContextPromptSelectionChanged);
            this.editControl1.AutoCompleteSingleLexem = true;
            this.editControl1.ContextChoiceBackColor = Color.White;
            this.editControl1.ContextChoiceBorderColor = ColorTranslator.FromHtml("#e5c365");
            this.editControl1.ContextPromptBorderColor = ColorTranslator.FromHtml("#e5c365");
            this.editControl1.ContextTooltipBackgroundBrush = new Syncfusion.Drawing.BrushInfo(ColorTranslator.FromHtml("#e7e8ec"));
            this.editControl1.ContextTooltipBorderColor = ColorTranslator.FromHtml("#e7e8ec");
            this.editControl1.ContextChoiceForeColor = System.Drawing.SystemColors.InfoText;
            this.barItem1.MetroColor = ColorTranslator.FromHtml("#fdf4bf");
            this.barItem1.MetroBackColor = ColorTranslator.FromHtml("#eaf0ff");
            breakpointcolor = Color.Red;
            breakpointbordercolor = ColorTranslator.FromHtml("#f6f6f6");
            this.editControl1.ScrollVisualStyle = ScrollBarCustomDrawStyles.Metro;
            IBackgroundFormat format =
               editControl1.RegisterBackColorFormat(Color.Red, ColorTranslator.FromHtml("#99c9ef"));
            this.editControl1.SetSelectionBackColor(format);
            this.Font = new System.Drawing.Font("Automatic", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editControl1.Style = Syncfusion.Windows.Forms.Edit.EditControlStyle.Default;
            this.editControl1.ScrollVisualStyle = ScrollBarCustomDrawStyles.Office2016;
            this.Style.TitleBar.ForeColor = Color.Black;

        }
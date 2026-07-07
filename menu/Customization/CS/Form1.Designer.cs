#region Copyright Syncfusion Inc. 2001-2018.
// Copyright Syncfusion Inc. 2001-2018. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Syncfusion.WinForms.Controls;
using System.Collections.Generic;
using Syncfusion.WinForms.ListView.Enums;
using System.IO;
using Syncfusion.Windows.Forms.Edit.Enums;
using Syncfusion.Windows.Forms;
using Syncfusion.Windows.Forms.Tools;

namespace Customization
{
    partial class Form1 : SfForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Syncfusion.Windows.Forms.Edit.Implementation.Config.Config config1 = new Syncfusion.Windows.Forms.Edit.Implementation.Config.Config();
            this.barItem14 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem15 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem16 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.mainFrameBarManager1 = new Syncfusion.Windows.Forms.Tools.XPMenus.MainFrameBarManager(this);
            this.bar1 = new Syncfusion.Windows.Forms.Tools.XPMenus.Bar(this.mainFrameBarManager1, "File");
            this.barItem1 = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.barItem2 = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.bar2 = new Syncfusion.Windows.Forms.Tools.XPMenus.Bar(this.mainFrameBarManager1, "EditMenu");
            this.barItem17 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.barItem18 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem19 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.dropDownBarItem = new Syncfusion.Windows.Forms.Tools.XPMenus.DropDownBarItem();
            this.undoPopup = new Syncfusion.Windows.Forms.PopupControlContainer();
            this.undoLabel = new System.Windows.Forms.Label();
            this.undoList = new Syncfusion.Windows.Forms.FocuslessListBox();
            this.barItem21 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem22 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem23 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem24 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.staticBarItem = new Syncfusion.Windows.Forms.Tools.XPMenus.StaticBarItem();
            this.comboBoxBarItem = new Syncfusion.Windows.Forms.Tools.XPMenus.ComboBoxBarItem();
            this.TextBoxBarItem = new Syncfusion.Windows.Forms.Tools.XPMenus.TextBoxBarItem();
            this.barItem3 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem4 = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.barItem5 = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.barItem9 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem7 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem8 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem10 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.sfComboBox1 = new Syncfusion.WinForms.ListView.SfComboBox();
            this.basePanel = new System.Windows.Forms.Panel();
            this.editControlPanel = new System.Windows.Forms.Panel();
            this.editControl1 = new Syncfusion.Windows.Forms.Edit.EditControl();
            this.rightSidePanel = new System.Windows.Forms.Panel();
            this.barCB = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.customizeMenuCb = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.label1 = new System.Windows.Forms.Label();
            this.textImageCmb = new ComboBoxAdv();
            ((System.ComponentModel.ISupportInitialize)(this.mainFrameBarManager1)).BeginInit();
            this.undoPopup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxBarItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sfComboBox1)).BeginInit();
            this.basePanel.SuspendLayout();
            this.editControlPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.editControl1)).BeginInit();
            this.rightSidePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barCB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customizeMenuCb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textImageCmb)).BeginInit();
            this.SuspendLayout();
            // 
            // barItem14
            // 
            this.barItem14.BarName = "barItem14";
            this.barItem14.ShowToolTipInPopUp = false;
            this.barItem14.SizeToFit = true;
            // 
            // barItem15
            // 
            this.barItem15.BarName = "barItem15";
            this.barItem15.ShowToolTipInPopUp = false;
            this.barItem15.SizeToFit = true;
            // 
            // barItem16
            // 
            this.barItem16.BarName = "barItem16";
            this.barItem16.ID = "_3";
            this.barItem16.ShowToolTipInPopUp = false;
            this.barItem16.SizeToFit = true;
            // 
            // mainFrameBarManager1
            // 
#if !NETCORE
            this.mainFrameBarManager1.BarPositionInfo = ((System.IO.MemoryStream)(resources.GetObject("mainFrameBarManager1.BarPositionInfo")));
#endif
            this.mainFrameBarManager1.Bars.Add(this.bar1);
            this.mainFrameBarManager1.Bars.Add(this.bar2);
            this.mainFrameBarManager1.Categories.Add("File");
            this.mainFrameBarManager1.Categories.Add("Icons");
            this.mainFrameBarManager1.CurrentBaseFormType = "Syncfusion.WinForms.Controls.SfForm";
            this.mainFrameBarManager1.EnableMenuMerge = true;
            this.mainFrameBarManager1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.mainFrameBarManager1.Form = this;
            this.mainFrameBarManager1.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.barItem1,
            this.barItem2,
            this.barItem3,
            this.barItem4,
            this.barItem5,
            this.barItem9,
            this.barItem16,
            this.barItem17,
            this.barItem18,
            this.barItem19,
            this.dropDownBarItem,
            this.barItem21});
            this.mainFrameBarManager1.ResetCustomization = false;
            this.mainFrameBarManager1.UseBackwardCompatiblity = false;
            // 
            // bar1
            // 
            this.bar1.BarName = "File";
            this.bar1.Caption = "File";
            this.bar1.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.barItem1,
            this.barItem2});
            this.bar1.Manager = this.mainFrameBarManager1;
            // 
            // barItem1
            // 
            this.barItem1.BarName = "barItem1";
            this.barItem1.CategoryIndex = 0;
            this.barItem1.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.barItem1.ID = "&FILE";
            this.barItem1.SizeToFit = true;
            this.barItem1.Text = "&File";
            this.barItem1.WrapLength = 20;
            // 
            // barItem2
            // 
            this.barItem2.BarName = "barItem2";
            this.barItem2.CategoryIndex = 0;
            this.barItem2.ID = "EDIT";
            this.barItem2.SizeToFit = true;
            this.barItem2.Text = "&Edit";
            this.barItem2.WrapLength = 20;
            // 
            // bar2
            // 
            this.bar2.BarName = "EditMenu";
            this.bar2.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.barItem17,
            this.barItem18,
            this.barItem19,
            this.dropDownBarItem,
            this.barItem21,
            this.barItem22,
            this.barItem23,
            this.barItem24,
            this.staticBarItem,
            this.comboBoxBarItem,
            this.TextBoxBarItem});
            this.bar2.Manager = this.mainFrameBarManager1;
            this.bar2.SeparatorIndices.AddRange(new int[] {
            3,
            5,
            8});
            // 
            // barItem17
            // 
            this.barItem17.BarName = "barItem17";
            this.barItem17.ID = "Open File";
            this.barItem17.ImageIndex = 16;
            this.barItem17.ImageList = this.imageList1;
            this.barItem17.ShowToolTipInPopUp = false;
            this.barItem17.SizeToFit = true;
            this.barItem17.Text = "Open File";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Open-file.png");
            this.imageList1.Images.SetKeyName(1, "save.jpg");
            this.imageList1.Images.SetKeyName(2, "save-all.png");
            this.imageList1.Images.SetKeyName(3, "undo-6.png");
            this.imageList1.Images.SetKeyName(4, "REDO1.png");
            this.imageList1.Images.SetKeyName(5, "cut.png");
            this.imageList1.Images.SetKeyName(6, "copy.png");
            this.imageList1.Images.SetKeyName(7, "paste.png");
            this.imageList1.Images.SetKeyName(8, "open-512.png");
            this.imageList1.Images.SetKeyName(9, "save.jpg");
            this.imageList1.Images.SetKeyName(10, "save-as.png");
            this.imageList1.Images.SetKeyName(11, "copy1.jpg");
            this.imageList1.Images.SetKeyName(12, "paste1.jpg");
            this.imageList1.Images.SetKeyName(13, "copy2.png");
            this.imageList1.Images.SetKeyName(14, "paste2.jpg");
            this.imageList1.Images.SetKeyName(15, "Paste (1).png");
            this.imageList1.Images.SetKeyName(16, "Open32.png");
            this.imageList1.Images.SetKeyName(17, "Save32.png");
            this.imageList1.Images.SetKeyName(18, "SaveAs32.png");
            this.imageList1.Images.SetKeyName(19, "Undo.ico");
            this.imageList1.Images.SetKeyName(20, "Redo_Big.ico");
            this.imageList1.Images.SetKeyName(21, "Cut16.png");
            this.imageList1.Images.SetKeyName(22, "Copy16.png");
            this.imageList1.Images.SetKeyName(23, "Paste32.png");
            // 
            // barItem18
            // 
            this.barItem18.BarName = "barItem18";
            this.barItem18.ID = "Save File";
            this.barItem18.ImageIndex = 17;
            this.barItem18.ImageList = this.imageList1;
            this.barItem18.ShowToolTipInPopUp = false;
            this.barItem18.SizeToFit = true;
            this.barItem18.Text = "Save File";
            // 
            // barItem19
            // 
            this.barItem19.BarName = "barItem19";
            this.barItem19.ID = "SaveAs";
            this.barItem19.ImageIndex = 18;
            this.barItem19.ImageList = this.imageList1;
            this.barItem19.ShowToolTipInPopUp = false;
            this.barItem19.SizeToFit = true;
            this.barItem19.Text = "SaveAs";
            // 
            // dropDownBarItem
            // 
            this.dropDownBarItem.BarName = "dropDownBarItem";
            this.dropDownBarItem.ID = "Undo";
            this.dropDownBarItem.ImageIndex = 19;
            this.dropDownBarItem.ImageList = this.imageList1;
            this.dropDownBarItem.PopupControlContainer = this.undoPopup;
            this.dropDownBarItem.ShowToolTipInPopUp = false;
            this.dropDownBarItem.SizeToFit = true;
            this.dropDownBarItem.Text = "Undo";
            // 
            // undoPopup
            // 
            this.undoPopup.BackColor = System.Drawing.SystemColors.Window;
            this.undoPopup.Controls.Add(this.undoLabel);
            this.undoPopup.Controls.Add(this.undoList);
            this.undoPopup.Location = new System.Drawing.Point(24, 24);
            this.undoPopup.Name = "undoPopup";
            this.undoPopup.Padding = new System.Windows.Forms.Padding(1);
            this.undoPopup.Size = new System.Drawing.Size(96, 195);
            this.undoPopup.TabIndex = 6;
            this.undoPopup.Visible = false;
            // 
            // undoLabel
            // 
            this.undoLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.undoLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.undoLabel.Location = new System.Drawing.Point(1, 118);
            this.undoLabel.Name = "undoLabel";
            this.undoLabel.Size = new System.Drawing.Size(94, 76);
            this.undoLabel.TabIndex = 1;
            this.undoLabel.Text = "label1";
            this.undoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // undoList
            // 
            this.undoList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.undoList.CausesValidation = false;
            this.undoList.Dock = System.Windows.Forms.DockStyle.Top;
            this.undoList.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.undoList.Items.AddRange(new object[] {
            "One",
            "Two",
            "Three",
            "Four",
            "Five",
            "Six",
            "Seven",
            "Eight",
            "Nine",
            "Ten",
            "Eleven",
            "Twelve",
            "Thirteen"});
            this.undoList.Location = new System.Drawing.Point(1, 1);
            this.undoList.Name = "undoList";
            this.undoList.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.undoList.Size = new System.Drawing.Size(94, 117);
            this.undoList.TabIndex = 0;
            // 
            // barItem21
            // 
            this.barItem21.BarName = "barItem21";
            this.barItem21.ID = "Redo";
            this.barItem21.ImageIndex = 20;
            this.barItem21.ImageList = this.imageList1;
            this.barItem21.ShowToolTipInPopUp = false;
            this.barItem21.SizeToFit = true;
            this.barItem21.Text = "Redo";
            // 
            // barItem22
            // 
            this.barItem22.BarName = "barItem22";
            this.barItem22.ID = "cut";
            this.barItem22.ImageIndex = 21;
            this.barItem22.ImageList = this.imageList1;
            this.barItem22.ShowToolTipInPopUp = false;
            this.barItem22.SizeToFit = true;
            this.barItem22.Text = "Cut";
            // 
            // barItem23
            // 
            this.barItem23.BarName = "barItem23";
            this.barItem23.ID = "copy";
            this.barItem23.ImageIndex = 22;
            this.barItem23.ImageList = this.imageList1;
            this.barItem23.ShowToolTipInPopUp = false;
            this.barItem23.SizeToFit = true;
            this.barItem23.Text = "Copy";
            // 
            // barItem24
            // 
            this.barItem24.BarName = "barItem24";
            this.barItem24.ID = "paste";
            this.barItem24.ImageIndex = 23;
            this.barItem24.ImageList = this.imageList1;
            this.barItem24.ShowToolTipInPopUp = false;
            this.barItem24.SizeToFit = true;
            this.barItem24.Text = "Paste";
            // 
            // staticBarItem
            // 
            this.staticBarItem.BarName = "staticBarItem";
            this.staticBarItem.ID = "Launch";
            this.staticBarItem.ShowToolTipInPopUp = false;
            this.staticBarItem.SizeToFit = true;
            this.staticBarItem.Text = "Launch";
            // 
            // comboBoxBarItem
            // 
            this.comboBoxBarItem.BarName = "comboBoxBarItem";
            this.comboBoxBarItem.ChoiceList.AddRange(new string[] {
            "Debug",
            "Release",
            "Run"});
            this.comboBoxBarItem.ID = "Debug";
            this.comboBoxBarItem.MinWidth = 55;
            this.comboBoxBarItem.ShowToolTipInPopUp = false;
            this.comboBoxBarItem.SizeToFit = true;
            this.comboBoxBarItem.TextBoxValue = "Run";
            // 
            // TextBoxBarItem
            // 
            this.TextBoxBarItem.BarName = "TextBoxBarItem";
            this.TextBoxBarItem.ID = "TextBox";
            this.TextBoxBarItem.MinWidth = 55;
            this.TextBoxBarItem.ShowToolTipInPopUp = false;
            this.TextBoxBarItem.SizeToFit = true;
            this.TextBoxBarItem.TextBoxValue = "Search";
            this.TextBoxBarItem.Value = "Search";
            // 
            // barItem3
            // 
            this.barItem3.BarName = "barItem3";
            this.barItem3.ID = "_1";
            this.barItem3.ShowToolTipInPopUp = false;
            this.barItem3.SizeToFit = true;
            // 
            // barItem4
            // 
            this.barItem4.BarName = "barItem4";
            this.barItem4.CategoryIndex = 0;
            this.barItem4.ID = "WINDOW";
            this.barItem4.ShowToolTipInPopUp = false;
            this.barItem4.SizeToFit = true;
            this.barItem4.Text = "&Window";
            this.barItem4.WrapLength = 20;
            // 
            // barItem5
            // 
            this.barItem5.BarName = "barItem5";
            this.barItem5.ID = "_2";
            this.barItem5.ShowToolTipInPopUp = false;
            this.barItem5.SizeToFit = true;
            this.barItem5.WrapLength = 20;
            // 
            // barItem9
            // 
            this.barItem9.BarName = "barItem9";
            this.barItem9.CategoryIndex = 1;
            this.barItem9.ID = "Save All";
            this.barItem9.ShowToolTipInPopUp = false;
            this.barItem9.SizeToFit = true;
            this.barItem9.Text = "Save All";
            // 
            // barItem7
            // 
            this.barItem7.BarName = "barItem7";
            this.barItem7.CategoryIndex = 1;
            this.barItem7.ID = "Open";
            this.barItem7.ShowToolTipInPopUp = false;
            this.barItem7.SizeToFit = true;
            this.barItem7.Text = "Open";
            // 
            // barItem8
            // 
            this.barItem8.BarName = "barItem8";
            this.barItem8.CategoryIndex = 1;
            this.barItem8.ID = "Save";
            this.barItem8.ShowToolTipInPopUp = false;
            this.barItem8.SizeToFit = true;
            this.barItem8.Text = "Save";
            // 
            // barItem10
            // 
            this.barItem10.BarName = "barItem10";
            this.barItem10.ShowToolTipInPopUp = false;
            this.barItem10.SizeToFit = true;
            // 
            // sfComboBox1
            // 
            this.sfComboBox1.AllowDropDownResize = false;
            this.sfComboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.sfComboBox1.BackColor = System.Drawing.Color.White;
            this.sfComboBox1.DropDownStyle = Syncfusion.WinForms.ListView.Enums.DropDownStyle.DropDownList;
            this.sfComboBox1.Location = new System.Drawing.Point(707, 5);
            this.sfComboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.sfComboBox1.Name = "sfComboBox1";
            this.sfComboBox1.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.sfComboBox1.Size = new System.Drawing.Size(121, 19);
            this.sfComboBox1.Style.EditorStyle.BackColor = System.Drawing.Color.White;
            this.sfComboBox1.TabIndex = 21;
            this.sfComboBox1.Text = "CSharp";
            // 
            // basePanel
            // 
            this.basePanel.Controls.Add(this.editControlPanel);
            this.basePanel.Controls.Add(this.rightSidePanel);
            this.basePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.basePanel.Location = new System.Drawing.Point(0, 32);
            this.basePanel.Name = "basePanel";
            this.basePanel.Size = new System.Drawing.Size(855, 658);
            this.basePanel.TabIndex = 23;
            // 
            // editControlPanel
            // 
            this.editControlPanel.Controls.Add(this.editControl1);
            this.editControlPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.editControlPanel.Location = new System.Drawing.Point(0, 0);
            this.editControlPanel.Name = "editControlPanel";
            this.editControlPanel.Size = new System.Drawing.Size(555, 658);
            this.editControlPanel.TabIndex = 1;
            // 
            // editControl1
            // 
            this.editControl1.AllowZoom = false;
            this.editControl1.BackgroundColor = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255))))));
            this.editControl1.ChangedLinesMarkingLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(238)))), ((int)(((byte)(98)))));
            this.editControl1.CodeSnipptSize = new System.Drawing.Size(100, 100);
            this.editControl1.Configurator = config1;
            this.editControl1.ContextChoiceBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.editControl1.ContextChoiceBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(166)))), ((int)(((byte)(50)))));
            this.editControl1.ContextChoiceForeColor = System.Drawing.SystemColors.InfoText;
            this.editControl1.ContextPromptBackgroundBrush = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255))))));
            this.editControl1.ContextTooltipBackgroundBrush = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(232)))), ((int)(((byte)(236))))));
            this.editControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.editControl1.IndentationBlockBackgroundBrush = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(61)))), ((int)(((byte)(139))))));
            this.editControl1.IndentationBlockBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(128)))));
            this.editControl1.IndentBlockHighlightingColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.editControl1.IndentLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.editControl1.IndicatorMarginBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.editControl1.LineNumbersColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.editControl1.LineNumbersFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.editControl1.Location = new System.Drawing.Point(0, 0);
            this.editControl1.MarkChangedLines = true;
            this.editControl1.MarkerAreaWidth = 24;
            this.editControl1.Name = "editControl1";
            this.editControl1.RenderRightToLeft = false;
            this.editControl1.ScrollPosition = new System.Drawing.Point(0, 404);
            this.editControl1.SelectionMarginBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.editControl1.SelectionMarginForegroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.editControl1.SelectionTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(214)))), ((int)(((byte)(255)))));
            this.editControl1.ShowHorizontalSplitters = false;
            this.editControl1.ShowLineNumbers = false;
            this.editControl1.ShowOutliningCollapsers = false;
            this.editControl1.ShowSelectionMargin = false;
            this.editControl1.ShowVerticalSplitters = false;
            this.editControl1.Size = new System.Drawing.Size(555, 658);
            this.editControl1.StatusBarSettings.CoordsPanel.Width = 150;
            this.editControl1.StatusBarSettings.EncodingPanel.Width = 100;
            this.editControl1.StatusBarSettings.FileNamePanel.Width = 100;
            this.editControl1.StatusBarSettings.InsertPanel.Width = 33;
            this.editControl1.StatusBarSettings.StatusPanel.Width = 70;
            this.editControl1.StatusBarSettings.TextPanel.Width = 214;
            this.editControl1.TabIndex = 21;
            this.editControl1.VisualColumn = 1;
            this.editControl1.VScrollMode = Syncfusion.Windows.Forms.Edit.ScrollMode.Immediate;
            this.editControl1.ZoomFactor = 1F;
            // 
            // rightSidePanel
            // 
            this.rightSidePanel.BackColor = System.Drawing.Color.White;
            this.rightSidePanel.Controls.Add(this.barCB);
            this.rightSidePanel.Controls.Add(this.customizeMenuCb);
            this.rightSidePanel.Controls.Add(this.label1);
            this.rightSidePanel.Controls.Add(this.textImageCmb);
            this.rightSidePanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.rightSidePanel.Location = new System.Drawing.Point(555, 0);
            this.rightSidePanel.Name = "rightSidePanel";
            this.rightSidePanel.Size = new System.Drawing.Size(300, 658);
            this.rightSidePanel.TabIndex = 0;
            // 
            // barCB
            // 
            this.barCB.BeforeTouchSize = new System.Drawing.Size(253, 21);
            this.barCB.Checked = true;
            this.barCB.CheckState = System.Windows.Forms.CheckState.Checked;
            this.barCB.Location = new System.Drawing.Point(22, 168);
            this.barCB.Name = "barCB";
            this.barCB.Size = new System.Drawing.Size(253, 21);
            this.barCB.TabIndex = 5;
            this.barCB.Text = "Show Menu";
            this.barCB.ThemeName = "Office2019Colorful";
            // 
            // customizeMenuCb
            // 
            this.customizeMenuCb.BeforeTouchSize = new System.Drawing.Size(253, 21);
            this.customizeMenuCb.Checked = true;
            this.customizeMenuCb.CheckState = System.Windows.Forms.CheckState.Checked;
            this.customizeMenuCb.Location = new System.Drawing.Point(22, 115);
            this.customizeMenuCb.Name = "customizeMenuCb";
            this.customizeMenuCb.Size = new System.Drawing.Size(253, 21);
            this.customizeMenuCb.TabIndex = 4;
            this.customizeMenuCb.Text = "Show Customize Menu";
            this.customizeMenuCb.ThemeName = "Office2019Colorful";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Text Image Relation";
            // 
            // textImageCmb
            // 
            this.textImageCmb.DropDownStyle = ComboBoxStyle.DropDownList;
            this.textImageCmb.Location = new System.Drawing.Point(135, 52);
            this.textImageCmb.Name = "textImageCmb";
            this.textImageCmb.Size = new System.Drawing.Size(143, 28);
            this.textImageCmb.TabIndex = 0;
            this.textImageCmb.Text = "Default";
            this.textImageCmb.ThemeName = "Office2019Colorful";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(219)))), ((int)(((byte)(233)))));
            this.ClientSize = new System.Drawing.Size(855, 690);
            this.Controls.Add(this.basePanel);
            this.Controls.Add(this.sfComboBox1);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(0);
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(219)))), ((int)(((byte)(233)))));
            this.Text = "Customization";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SizeChanged += Form1_SizeChanged1;
            ((System.ComponentModel.ISupportInitialize)(this.mainFrameBarManager1)).EndInit();
            this.undoPopup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxBarItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sfComboBox1)).EndInit();
            this.basePanel.ResumeLayout(false);
            this.editControlPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.editControl1)).EndInit();
            this.rightSidePanel.ResumeLayout(false);
            this.rightSidePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barCB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customizeMenuCb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textImageCmb)).EndInit();
            this.ResumeLayout(false);

        }

#endregion

        private Syncfusion.Windows.Forms.Tools.XPMenus.Bar bar1;
        private Syncfusion.Windows.Forms.Tools.XPMenus.Bar bar2;
        private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem barItem1;
        private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem barItem2;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem3;
        private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem barItem4;
        private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem barItem5;
        public Syncfusion.Windows.Forms.Tools.XPMenus.MainFrameBarManager mainFrameBarManager1;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem7;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem8;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem9;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem10;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem14;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem15;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem16;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem17;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem18;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem19;
        private Syncfusion.Windows.Forms.Tools.XPMenus.DropDownBarItem dropDownBarItem;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem21;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem22;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem23;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem24;
        private Syncfusion.Windows.Forms.Tools.XPMenus.StaticBarItem staticBarItem;
        private Syncfusion.Windows.Forms.Tools.XPMenus.ComboBoxBarItem comboBoxBarItem;
        private Syncfusion.Windows.Forms.Tools.XPMenus.TextBoxBarItem TextBoxBarItem;
        private Syncfusion.Windows.Forms.PopupControlContainer undoPopup;
        private Syncfusion.Windows.Forms.FocuslessListBox undoList;
        private System.Windows.Forms.Label undoLabel;
        private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem viewItem;
        private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem debugItem;
        private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem Search;
        private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem teamItem;
        private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem formatItem;
        private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem toolsItem;
        private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem testItem;
        private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem analyzeItem;
        private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem windowItem;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem undo;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem redo;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem cut;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem copy;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem pasteSpecial;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem Delete;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem SelectAll;
        private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem FindandReplace;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem find;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem replace;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem Goto;
        private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem Advanced;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem WordWrap;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem IncreaseLineIndent;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem DecreaseLineIndent;
        private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem Bookmark;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem Tooglebookmark;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem Nextbookmark;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem Previousbookmark;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem Clearbookmark;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem parentBarItem1;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem parentBarItem2;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem Save;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem SaveAs;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem SaveAsHTML;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem SaveAsRTF;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem Print;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem PrintPriview;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem Exit;
        private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem Wrapping;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem Disable;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem Enable;
        private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem WrapType;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem Word;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem Character;
        private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem Splitter;
        private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem EditControlStyle;
        private Syncfusion.Windows.Forms.Tools.XPMenus.DropDownBarItem Background;
        private Syncfusion.Windows.Forms.PopupControlContainer popupControlContainer2;
        private Syncfusion.Windows.Forms.PopupControlContainer popupControlContainer3;
        private ColorPickerUIAdv colorPickerUIAdv1;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem VerticalSplitter;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem HorizontalSplitter;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem QuarantSplitter;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem ShowVertical;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem horizontalsplitter;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem Office2019Colorful;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem HighContrastBlack;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem RightToLefts;
        private List<int> linenumber;
        [DllImport("user32.dll")]
        static extern bool LockWindowUpdate(IntPtr hWndLock);

        private Syncfusion.WinForms.ListView.SfComboBox sfComboBox1;
        private ImageList imageList1;
        private Panel basePanel;
        private Panel editControlPanel;
        private Syncfusion.Windows.Forms.Edit.EditControl editControl1;
        private Panel rightSidePanel;
        private Label label1;
        private ComboBoxAdv textImageCmb;
        private CheckBoxAdv customizeMenuCb;
        private CheckBoxAdv barCB;
    }
}


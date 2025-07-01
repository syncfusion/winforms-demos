#region Copyright Syncfusion Inc. 2001 - 2014
//
//  Copyright Syncfusion Inc. 2001 - 2014. All rights reserved.
//
//  Use of this code is subject to the terms of our license.
//  A copy of the current license can be obtained at any time by e-mailing
//  licensing@syncfusion.com. Any infringement will be prosecuted under
//  applicable laws. 
//
#endregion

using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using Syncfusion.Windows.Forms;
using Syncfusion.Windows.Forms.Edit.Utils;
using Syncfusion.Windows.Forms.Tools;
using Syncfusion.Windows.Forms.Edit.Interfaces;
using System.Drawing.Drawing2D;
using Syncfusion.Licensing;
using System.IO;
using Syncfusion.WinForms.Controls;

namespace SelectionMarginDemo
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : SfForm
	{
        private Form2 inputDialog;
        private string inputString = string.Empty;
        private Syncfusion.Windows.Forms.Edit.EditControl editControl1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem nwToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem saveAsToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem closeToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem selectionMarginToolStripMenuItem;
        private ToolStripMenuItem backgroundColorToolStripMenuItem;
        private ToolStripMenuItem foregroundColorItem;
        private ToolStripMenuItem marginWidthToolStripMenuItem;
        private ToolStripMenuItem changedLineMarkingToolStripMenuItem;
        private ToolStripMenuItem enableItItem;
        private ToolStripMenuItem changedLineColorItem;
        private ToolStripMenuItem savedLinesColorItem;
        private ColorDialog colorDialog;
        private ToolStripComboBox ChangeMarginCombo;
        private ToolStripMenuItem strikeOptionsToolStripMenuItem;
        private ToolStripMenuItem strikeLineToolStripMenuItem;
        private ToolStripMenuItem strikeSelectionToolStripMenuItem;
        private ToolStripMenuItem strikeTextRangeToolStripMenuItem;
        private ToolStripMenuItem textHandlingToolStripMenuItem;
        private ToolStripMenuItem setTextToolStripMenuItem;
        private ToolStripMenuItem appendTextToolStripMenuItem;
        private ToolStripMenuItem insertTextToolStripMenuItem;
        private ToolStripMenuItem deleteAllToolStripMenuItem;
        private ToolStripMenuItem deleteSelectionToolStripMenuItem;
        private IContainer components = null;
        private Panel panel1;
        private ButtonAdv button2;
        private ButtonAdv button1;
        private GroupBox groupBox2;
        private RadioButtonAdv radioButton8;
        private RadioButtonAdv radioButton4;
        private RadioButtonAdv radioButton5;
        private RadioButtonAdv radioButton6;
        private Label label1;
        private ComboBoxAdv comboBox1;
        private GroupBox groupBox1;
        private RadioButtonAdv radioButton3;
        private RadioButtonAdv radioButton2;
        private RadioButtonAdv radioButton1;
        private RadioButtonAdv radioButton7;
        private Panel panel2;
        private Label label2;
        private bool accepted = false;

		public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
            try
            {
                System.Drawing.Icon ico = new System.Drawing.Icon(GetIconFile(GetIconFile(@"..\\..\\\logo.ico")));
                this.Icon = ico;
            }
            catch { }
			this.editControl1.SelectionMarginBackgroundColor = Color.LightBlue;
			this.editControl1.SelectionMarginForegroundColor = Color.Gray;
#if NETCORE
            this.editControl1.LoadFile("..\\..\\..\\Test Files\\Test.cs");
#else
            this.editControl1.LoadFile("..\\..\\Test Files\\Test.cs");
#endif
            this.editControl1.ApplyConfiguration("C#");
            this.editControl1.MarkChangedLines = false;
            this.ChangeMarginCombo.SelectedIndex = 0;
            inputDialog = new Form2();
            inputDialog.AcceptButton.Click += new EventHandler(AcceptButton_Clicked);
            inputDialog.CancelButton.Click += new EventHandler(CancelButton_Clicked);
            this.radioButton1.BackColor = ColorTranslator.FromHtml("#85BF75");
            this.radioButton2.BackColor = ColorTranslator.FromHtml("#B4E7F2");
            this.radioButton3.BackColor = ColorTranslator.FromHtml("#FFBF34");
            Customization();

        }
        private IBackgroundFormat RegisterFormat()
        {
            Color background = Color.Empty, foreground = Color.Empty;

            if (radioButton1.Checked)
                background = radioButton1.BackColor;
            else if (radioButton2.Checked)
                background = radioButton2.BackColor;
            else if (radioButton3.Checked)
                background = radioButton3.BackColor;

            if (radioButton6.Checked)
                foreground = radioButton6.BackColor;
            else if (radioButton5.Checked)
                foreground = radioButton5.BackColor;
            else if (radioButton4.Checked)
                foreground = radioButton4.BackColor;

            bool bUseHatchFille = comboBox1.SelectedIndex > 0;
            HatchStyle style = (bUseHatchFille)
                ? (HatchStyle)Enum.Parse(typeof(HatchStyle),
                comboBox1.SelectedItem.ToString())
                : HatchStyle.Min;

            IBackgroundFormat format =
                editControl1.RegisterBackColorFormat(background, foreground,
                style, bUseHatchFille);
            return format;
        }
        #region Customization
        public void Customization()
        {
            this.editControl1.Style = Syncfusion.Windows.Forms.Edit.EditControlStyle.Office2016White;
            this.Padding = new System.Windows.Forms.Padding(0);
        }
        #endregion

        private void AcceptButton_Clicked(object sender, EventArgs args)
        {
            this.inputString = this.inputDialog.InputString;
            this.accepted = true;
            this.inputDialog.Close();
        }

        private void CancelButton_Clicked(object sender, EventArgs args)
        {
            this.accepted = false;
            this.inputDialog.Close();
        }
		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            Syncfusion.Windows.Forms.Edit.Implementation.Config.Config config1 = new Syncfusion.Windows.Forms.Edit.Implementation.Config.Config();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.editControl1 = new Syncfusion.Windows.Forms.Edit.EditControl();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nwToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectionMarginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.foregroundColorItem = new System.Windows.Forms.ToolStripMenuItem();
            this.marginWidthToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ChangeMarginCombo = new System.Windows.Forms.ToolStripComboBox();
            this.changedLineMarkingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enableItItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changedLineColorItem = new System.Windows.Forms.ToolStripMenuItem();
            this.savedLinesColorItem = new System.Windows.Forms.ToolStripMenuItem();
            this.strikeOptionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.strikeLineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.strikeSelectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.strikeTextRangeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textHandlingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setTextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.appendTextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insertTextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteSelectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.button1 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton8 = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
            this.radioButton4 = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
            this.radioButton5 = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
            this.radioButton6 = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton3 = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
            this.radioButton2 = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
            this.radioButton1 = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
            this.radioButton7 = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.editControl1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radioButton8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioButton4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioButton5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioButton6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radioButton3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioButton2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioButton7)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // editControl1
            // 
            this.editControl1.AutoIndentMode = Syncfusion.Windows.Forms.Edit.Enums.AutoIndentMode.Smart;
            this.editControl1.BackColor = System.Drawing.SystemColors.Window;
            this.editControl1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.editControl1.CodeSnipptSize = new System.Drawing.Size(100, 100);
            this.editControl1.Configurator = config1;
            this.editControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.editControl1.IndicatorMarginBackColor = System.Drawing.Color.Empty;
            this.editControl1.LineNumbersFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.editControl1.Location = new System.Drawing.Point(0, 0);
            this.editControl1.Name = "editControl1";
            this.editControl1.RenderRightToLeft = false;
            this.editControl1.ScrollPosition = new System.Drawing.Point(0, 0);
            this.editControl1.ScrollVisualStyle = Syncfusion.Windows.Forms.ScrollBarCustomDrawStyles.Metro;
            this.editControl1.ShowHorizontalSplitters = false;
            this.editControl1.ShowIndicatorMargin = false;
            this.editControl1.ShowVerticalSplitters = false;
            this.editControl1.Size = new System.Drawing.Size(523, 430);

            this.editControl1.StatusBarSettings.TextPanel.AutoSize = false;
            this.editControl1.TabIndex = 0;
            this.editControl1.Text = "editControl1";
            this.editControl1.TransferFocusOnTab = true;
            this.editControl1.UseXPStyleBorder = true;
            this.editControl1.VisualColumn = 1;
            this.editControl1.WordWrap = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.selectionMarginToolStripMenuItem,
            this.changedLineMarkingToolStripMenuItem,
            this.strikeOptionsToolStripMenuItem,
            this.textHandlingToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(10, 10);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(691, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nwToolStripMenuItem,
            this.openToolStripMenuItem,
            this.toolStripSeparator1,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.toolStripSeparator2,
            this.closeToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // nwToolStripMenuItem
            // 
            this.nwToolStripMenuItem.Name = "nwToolStripMenuItem";
            this.nwToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.nwToolStripMenuItem.Text = "New";
            this.nwToolStripMenuItem.Click += new System.EventHandler(this.MainMenuClick);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.openToolStripMenuItem.Text = "Open...";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.MainMenuClick);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(120, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.MainMenuClick);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.saveAsToolStripMenuItem.Text = "Save As...";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.MainMenuClick);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(120, 6);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.MainMenuClick);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.MainMenuClick);
            // 
            // selectionMarginToolStripMenuItem
            // 
            this.selectionMarginToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backgroundColorToolStripMenuItem,
            this.foregroundColorItem,
            this.marginWidthToolStripMenuItem});
            this.selectionMarginToolStripMenuItem.Name = "selectionMarginToolStripMenuItem";
            this.selectionMarginToolStripMenuItem.Size = new System.Drawing.Size(108, 20);
            this.selectionMarginToolStripMenuItem.Text = "Selection Margin";
            // 
            // backgroundColorToolStripMenuItem
            // 
            this.backgroundColorToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.backgroundColorToolStripMenuItem.Name = "backgroundColorToolStripMenuItem";
            this.backgroundColorToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.backgroundColorToolStripMenuItem.Text = "Background Color...";
            this.backgroundColorToolStripMenuItem.Click += new System.EventHandler(this.SetBackgroundColor);
            // 
            // foregroundColorItem
            // 
            this.foregroundColorItem.Name = "foregroundColorItem";
            this.foregroundColorItem.Size = new System.Drawing.Size(179, 22);
            this.foregroundColorItem.Text = "Foreground Color...";
            this.foregroundColorItem.Click += new System.EventHandler(this.SetForegroundColor);
            // 
            // marginWidthToolStripMenuItem
            // 
            this.marginWidthToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ChangeMarginCombo});
            this.marginWidthToolStripMenuItem.Name = "marginWidthToolStripMenuItem";
            this.marginWidthToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.marginWidthToolStripMenuItem.Text = "Margin Width";
            // 
            // ChangeMarginCombo
            // 
            this.ChangeMarginCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ChangeMarginCombo.Items.AddRange(new object[] {
            "Default",
            "25",
            "50",
            "75",
            "100",
            "125"});
            this.ChangeMarginCombo.Name = "ChangeMarginCombo";
            this.ChangeMarginCombo.Size = new System.Drawing.Size(121, 23);
            this.ChangeMarginCombo.SelectedIndexChanged += new System.EventHandler(this.MarginWidthChanged);
            // 
            // changedLineMarkingToolStripMenuItem
            // 
            this.changedLineMarkingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.enableItItem,
            this.changedLineColorItem,
            this.savedLinesColorItem});
            this.changedLineMarkingToolStripMenuItem.Name = "changedLineMarkingToolStripMenuItem";
            this.changedLineMarkingToolStripMenuItem.Size = new System.Drawing.Size(139, 20);
            this.changedLineMarkingToolStripMenuItem.Text = "Changed Line Marking";
            // 
            // enableItItem
            // 
            this.enableItItem.Checked = true;
            this.enableItItem.CheckOnClick = true;
            this.enableItItem.CheckState = System.Windows.Forms.CheckState.Unchecked;
            this.enableItItem.Name = "enableItItem";
            this.enableItItem.Size = new System.Drawing.Size(188, 22);
            this.enableItItem.Text = "Enable it!";
            this.enableItItem.Click += new System.EventHandler(this.ChangedLineMarkingMenu_Click);
            // 
            // changedLineColorItem
            // 
            this.changedLineColorItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.changedLineColorItem.Name = "changedLineColorItem";
            this.changedLineColorItem.Size = new System.Drawing.Size(188, 22);
            this.changedLineColorItem.Text = "Changed lines color...";
            this.changedLineColorItem.Click += new System.EventHandler(this.ChangedLinesColor);
            // 
            // savedLinesColorItem
            // 
            this.savedLinesColorItem.Name = "savedLinesColorItem";
            this.savedLinesColorItem.Size = new System.Drawing.Size(188, 22);
            this.savedLinesColorItem.Text = "Saved lines color...";
            this.savedLinesColorItem.Click += new System.EventHandler(this.SavedLinesColor);
            // 
            // strikeOptionsToolStripMenuItem
            // 
            this.strikeOptionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.strikeLineToolStripMenuItem,
            this.strikeSelectionToolStripMenuItem,
            this.strikeTextRangeToolStripMenuItem});
            this.strikeOptionsToolStripMenuItem.Name = "strikeOptionsToolStripMenuItem";
            this.strikeOptionsToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.strikeOptionsToolStripMenuItem.Text = "Strike Options";
            // 
            // strikeLineToolStripMenuItem
            // 
            this.strikeLineToolStripMenuItem.Name = "strikeLineToolStripMenuItem";
            this.strikeLineToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.strikeLineToolStripMenuItem.Text = "StrikeLine";
            this.strikeLineToolStripMenuItem.Click += new System.EventHandler(this.strikeLineToolStripMenuItem_Click);
            // 
            // strikeSelectionToolStripMenuItem
            // 
            this.strikeSelectionToolStripMenuItem.Name = "strikeSelectionToolStripMenuItem";
            this.strikeSelectionToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.strikeSelectionToolStripMenuItem.Text = "StrikeSelection";
            this.strikeSelectionToolStripMenuItem.Click += new System.EventHandler(this.strikeSelectionToolStripMenuItem_Click);
            // 
            // strikeTextRangeToolStripMenuItem
            // 
            this.strikeTextRangeToolStripMenuItem.Name = "strikeTextRangeToolStripMenuItem";
            this.strikeTextRangeToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.strikeTextRangeToolStripMenuItem.Text = "StrikeTextRange";
            this.strikeTextRangeToolStripMenuItem.Click += new System.EventHandler(this.strikeTextRangeToolStripMenuItem_Click);
            // 
            // textHandlingToolStripMenuItem
            // 
            this.textHandlingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setTextToolStripMenuItem,
            this.appendTextToolStripMenuItem,
            this.insertTextToolStripMenuItem,
            this.deleteAllToolStripMenuItem,
            this.deleteSelectionToolStripMenuItem});
            this.textHandlingToolStripMenuItem.Name = "textHandlingToolStripMenuItem";
            this.textHandlingToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.textHandlingToolStripMenuItem.Text = "Text Handling";
            // 
            // setTextToolStripMenuItem
            // 
            this.setTextToolStripMenuItem.Name = "setTextToolStripMenuItem";
            this.setTextToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.setTextToolStripMenuItem.Text = "SetText";
            this.setTextToolStripMenuItem.Click += new System.EventHandler(this.setTextToolStripMenuItem_Click);
            // 
            // appendTextToolStripMenuItem
            // 
            this.appendTextToolStripMenuItem.Name = "appendTextToolStripMenuItem";
            this.appendTextToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.appendTextToolStripMenuItem.Text = "AppendText";
            this.appendTextToolStripMenuItem.Click += new System.EventHandler(this.appendTextToolStripMenuItem_Click);
            // 
            // insertTextToolStripMenuItem
            // 
            this.insertTextToolStripMenuItem.Name = "insertTextToolStripMenuItem";
            this.insertTextToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.insertTextToolStripMenuItem.Text = "InsertText";
            this.insertTextToolStripMenuItem.Click += new System.EventHandler(this.insertTextToolStripMenuItem_Click);
            // 
            // deleteAllToolStripMenuItem
            // 
            this.deleteAllToolStripMenuItem.Name = "deleteAllToolStripMenuItem";
            this.deleteAllToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.deleteAllToolStripMenuItem.Text = "DeleteAll";
            this.deleteAllToolStripMenuItem.Click += new System.EventHandler(this.deleteAllToolStripMenuItem_Click);
            // 
            // deleteSelectionToolStripMenuItem
            // 
            this.deleteSelectionToolStripMenuItem.Name = "deleteSelectionToolStripMenuItem";
            this.deleteSelectionToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.deleteSelectionToolStripMenuItem.Text = "DeleteSelection";
            this.deleteSelectionToolStripMenuItem.Click += new System.EventHandler(this.deleteSelectionToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(10, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(168, 430);
            this.panel1.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2016White;
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218)))));
            this.button2.Location = new System.Drawing.Point(16, 400);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(136, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Highlight Selection";
            this.button2.UseVisualStyle = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2016White;
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218)))));
            this.button1.Location = new System.Drawing.Point(16, 366);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Highlight Line";
            this.button1.UseVisualStyle = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton8);
            this.groupBox2.Controls.Add(this.radioButton4);
            this.groupBox2.Controls.Add(this.radioButton5);
            this.groupBox2.Controls.Add(this.radioButton6);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.groupBox2.Location = new System.Drawing.Point(16, 226);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(136, 128);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Border";
            // 
            // radioButton8
            // 
            this.radioButton8.Checked = true;
            this.radioButton8.DrawFocusRectangle = false;
            this.radioButton8.ForeColor = System.Drawing.SystemColors.Desktop;
            this.radioButton8.Location = new System.Drawing.Point(16, 96);
            this.radioButton8.MetroColor = System.Drawing.Color.Silver;
            this.radioButton8.Name = "radioButton8";
            this.radioButton8.Size = new System.Drawing.Size(104, 24);
            this.radioButton8.Style = Syncfusion.Windows.Forms.Tools.RadioButtonAdvStyle.Office2016White;
            this.radioButton8.TabIndex = 5;
            this.radioButton8.Text = "None";
            this.radioButton8.ThemesEnabled = false;
            // 
            // radioButton4
            // 
            this.radioButton4.BackColor = System.Drawing.Color.Chartreuse;
            this.radioButton4.DrawFocusRectangle = false;
            this.radioButton4.ForeColor = System.Drawing.SystemColors.Desktop;
            this.radioButton4.Location = new System.Drawing.Point(16, 72);
            this.radioButton4.MetroColor = System.Drawing.Color.Silver;
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(104, 24);
            this.radioButton4.Style = Syncfusion.Windows.Forms.Tools.RadioButtonAdvStyle.Office2016White;
            this.radioButton4.TabIndex = 2;
            this.radioButton4.Text = "Chartreuse";
            this.radioButton4.ThemesEnabled = false;
            this.radioButton4.BackColor = System.Drawing.Color.Chartreuse;

            // 
            // radioButton5
            // 
            this.radioButton5.BackColor = System.Drawing.Color.Crimson;
            this.radioButton5.DrawFocusRectangle = false;
            this.radioButton5.ForeColor = System.Drawing.SystemColors.Desktop;
            this.radioButton5.Location = new System.Drawing.Point(16, 48);
            this.radioButton5.MetroColor = System.Drawing.Color.Silver;
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(104, 24);
            this.radioButton5.Style = Syncfusion.Windows.Forms.Tools.RadioButtonAdvStyle.Office2016White;
            this.radioButton5.TabIndex = 1;
            this.radioButton5.Text = "Crimson";
            this.radioButton5.ThemesEnabled = false;
            this.radioButton5.BackColor = System.Drawing.Color.Crimson;

            // 
            // radioButton6
            // 
            this.radioButton6.BackColor = System.Drawing.Color.Magenta;
            this.radioButton6.DrawFocusRectangle = false;
            this.radioButton6.ForeColor = System.Drawing.SystemColors.Desktop;
            this.radioButton6.Location = new System.Drawing.Point(16, 24);
            this.radioButton6.MetroColor = System.Drawing.Color.Silver;
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(104, 24);
            this.radioButton6.Style = Syncfusion.Windows.Forms.Tools.RadioButtonAdvStyle.Office2016White;
            this.radioButton6.TabIndex = 0;
            this.radioButton6.Text = "Magenta";
            this.radioButton6.ThemesEnabled = false;
            this.radioButton6.BackColor = System.Drawing.Color.Magenta;

            // 
            // label1
            // 
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(16, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "HatchStyle:";
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.White;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Location = new System.Drawing.Point(10, 54);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(142, 21);
            this.comboBox1.Style = Syncfusion.Windows.Forms.VisualStyle.Office2016White;
            this.comboBox1.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.radioButton7);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.groupBox1.Location = new System.Drawing.Point(16, 88);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(136, 128);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Background";
            // 
            // radioButton3
            // 
            this.radioButton3.DrawFocusRectangle = false;
            this.radioButton3.ForeColor = System.Drawing.SystemColors.Desktop;
            this.radioButton3.Location = new System.Drawing.Point(16, 72);
            this.radioButton3.MetroColor = System.Drawing.Color.Silver;
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(104, 24);
            this.radioButton3.Style = Syncfusion.Windows.Forms.Tools.RadioButtonAdvStyle.Office2016White;
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = false;
            this.radioButton3.Text = "Orange";
            this.radioButton3.ThemesEnabled = false;
            // 
            // radioButton2
            // 
            this.radioButton2.DrawFocusRectangle = false;
            this.radioButton2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.radioButton2.Location = new System.Drawing.Point(16, 48);
            this.radioButton2.MetroColor = System.Drawing.Color.Silver;
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(104, 24);
            this.radioButton2.Style = Syncfusion.Windows.Forms.Tools.RadioButtonAdvStyle.Office2016White;
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = false;
            this.radioButton2.Text = "Dull Aqua";
            this.radioButton2.ThemesEnabled = false;
            // 
            // radioButton1
            // 
            this.radioButton1.Checked = true;
            this.radioButton1.DrawFocusRectangle = false;
            this.radioButton1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.radioButton1.Location = new System.Drawing.Point(16, 24);
            this.radioButton1.MetroColor = System.Drawing.Color.Silver;
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(104, 24);
            this.radioButton1.Style = Syncfusion.Windows.Forms.Tools.RadioButtonAdvStyle.Office2016White;
            this.radioButton1.TabIndex = 0;
            this.radioButton1.Text = "Light Olive";
            this.radioButton1.ThemesEnabled = false;
            // 
            // radioButton7
            // 
            this.radioButton7.DrawFocusRectangle = false;
            this.radioButton7.ForeColor = System.Drawing.SystemColors.Desktop;
            this.radioButton7.Location = new System.Drawing.Point(16, 96);
            this.radioButton7.MetroColor = System.Drawing.Color.Silver;
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.Size = new System.Drawing.Size(104, 24);
            this.radioButton7.Style = Syncfusion.Windows.Forms.Tools.RadioButtonAdvStyle.Office2016White;
            this.radioButton7.TabIndex = 4;
            this.radioButton7.Text = "None";
            this.radioButton7.ThemesEnabled = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.editControl1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(178, 34);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(523, 430);
            this.panel2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 27);
            this.label2.TabIndex = 7;
            this.label2.Text = "Text Highlighting";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 15);
            this.ClientSize = new System.Drawing.Size(711, 474);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(723, 511);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TextInteractions";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.editControl1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radioButton8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioButton4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioButton5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioButton6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radioButton3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioButton2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioButton7)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			SyncfusionLicenseProvider.RegisterLicense(DemoCommon.FindLicenseKey());
            Application.EnableVisualStyles();
			Application.Run(new Form1());
		}
		
		private void ChangedLineMarkingMenu_Click(object sender, System.EventArgs e)
		{
            this.editControl1.MarkChangedLines = enableItItem.Checked;
        }

        private void SetBackgroundColor(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                editControl1.SelectionMarginBackgroundColor = colorDialog.Color;
backgroundColorToolStripMenuItem.ForeColor = colorDialog.Color;
            }
        }

        private void SetForegroundColor(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                editControl1.SelectionMarginForegroundColor = colorDialog.Color;
                foregroundColorItem.ForeColor = colorDialog.Color;
            }
        }

        private void MarginWidthChanged(object sender, EventArgs e)
        {
            switch (ChangeMarginCombo.SelectedItem as string)
            {
                case "Default":
                    this.editControl1.SelectionMarginWidth = 5;
                    break;
                case "25":
                    this.editControl1.SelectionMarginWidth = 25;
                    break;
                case "50":
                    this.editControl1.SelectionMarginWidth = 50;
                    break;
                case "75":
                    this.editControl1.SelectionMarginWidth = 75;
                    break;
                case "100":
                    this.editControl1.SelectionMarginWidth = 100;
                    break;
                case "125":
                    this.editControl1.SelectionMarginWidth = 125;
                    break;
            }
        }

        private void ChangedLinesColor(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                editControl1.ChangedLinesMarkingLineColor = colorDialog.Color;
                changedLineColorItem.ForeColor = colorDialog.Color;
            }
        }

        private void SavedLinesColor(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                editControl1.SavedLinesMarkingLineColor = colorDialog.Color;
                savedLinesColorItem.ForeColor = colorDialog.Color;
            }
        }

        private void MainMenuClick(object sender, EventArgs e)
        {
            ToolStripMenuItem item = (ToolStripMenuItem)sender;
            switch (item.Text)
            {
                case "New":
                    editControl1.NewFile();
                    break;
                case "Open...":
                    editControl1.LoadFile();
                    break;
                case "Save":
                    editControl1.Save();
                    break;
                case "Save As...":
                    editControl1.SaveAs();
                    break;
                case "Close":
                    editControl1.Close();
                    break;
                case "Exit":
                    Close();
                    break;
            }
        }

        private void strikeLineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.editControl1.StrikeThrough(this.editControl1.CurrentLine, Color.IndianRed);
        }

        private void strikeSelectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Strike out the selected text
            if (this.editControl1.Selection != null)
                this.editControl1.StrikeThrough(this.editControl1.Selection.Top, this.editControl1.Selection.Bottom, Color.Navy);
            else
                MessageBox.Show("Please select some text to see the action","Select");
        }

        private void strikeTextRangeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int startLineNumber = 12;
            int endLineNumber = 25;

            // Creating the associated CoordinatePoints that indicate the text range
            CoordinatePoint startCoordinatePoint = this.editControl1.Parser.GetCoordinatePoint(startLineNumber, 1);
            CoordinatePoint endCoordinatePoint = this.editControl1.Parser.GetCoordinatePoint(endLineNumber, this.editControl1.GetLine(endLineNumber).LineLength);

            // Strike out the text in the specified text range
            this.editControl1.StrikeThrough(startCoordinatePoint, endCoordinatePoint, Color.Red);
        }

        private void setTextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.inputDialog.ShowDialog();

            if (this.accepted)
            {
                this.editControl1.Text = this.inputString;
            }
        }

        private void appendTextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.inputDialog.ShowDialog();

            if (this.accepted)
            {
                this.editControl1.AppendText(this.inputString);
            }
        }

        private void insertTextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.inputDialog.ShowDialog();

            if (this.accepted)
            {
                this.editControl1.InsertText(this.editControl1.CurrentLine, this.editControl1.CurrentColumn, this.inputString);
            }
        }

        private void deleteAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.editControl1.DeleteAll();
        }

        private void deleteSelectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (editControl1.Selection != null)
                this.editControl1.DeleteText(this.editControl1.Selection.Top, this.editControl1.Selection.Bottom);
            else
                MessageBox.Show("Please select the text to be deleted","Select");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IDynamicFormat[] temp = editControl1.GetLineBackColorFormats(editControl1.CurrentLine);

            IBackgroundFormat format = RegisterFormat();
            editControl1.SetLineBackColor(editControl1.CurrentLine, true, format);
            
            this.editControl1.ResetSelection();
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

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();

            comboBox1.Items.Add("Solid");

            foreach (string name in Enum.GetNames(typeof(HatchStyle)))
                comboBox1.Items.Add(name);

            comboBox1.SelectedText = "Percent05";
            comboBox1.SelectedIndex = 0;

            editControl1.Text += "\n";
            editControl1.CurrentLine = 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (editControl1.Selection != null)
            {
                IBackgroundFormat format = RegisterFormat();
                editControl1.SetSelectionBackColor(format);

                this.editControl1.ResetSelection();
            }
            else
                MessageBox.Show("Please select some text.", "Select");
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
                return File.ReadAllText(licenseKeyFile);
            }
            return string.Empty;
        }
    }

}

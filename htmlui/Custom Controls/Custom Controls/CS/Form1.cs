#region Copyright Syncfusion Inc. 2001 - 2019
//
//  Copyright Syncfusion Inc. 2001 - 2019. All rights reserved.
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
using System.IO;
using System.Reflection;
using Syncfusion.Licensing;

using Syncfusion.Windows.Forms.HTMLUI;
using Syncfusion.Windows.Forms.Tools;
using Syncfusion.Windows.Forms.Edit;

namespace Syncfusion.Windows.Forms.HTMLUI.Samples
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : MetroForm
	{
		Assembly _assembly;
		Stream _htmlStream;

        private Syncfusion.Windows.Forms.HTMLUI.HTMLUIControl htmluiControl1;
		private System.Windows.Forms.ImageList imageList1;
		private MonthCalendarAdv monthCalendar1;
		private System.Windows.Forms.DataGridView dataGrid1;
		private System.ComponentModel.IContainer components;
		private System.Windows.Forms.ToolTip toolTip1;
		private Syncfusion.Windows.Forms.Tools.CalculatorControl calculatorControl1;
		private Syncfusion.Windows.Forms.Tools.FontListBox fontListBox1;
		private System.Windows.Forms.Panel panel1;
		private ButtonAdv button1;
		private ButtonAdv button2;
		private int fileloaded = 0;
		static string filePath;
        private Tools.XPMenus.MainFrameBarManager mainFrameBarManager1;
        private Tools.XPMenus.Bar bar1;
        private Tools.XPMenus.ParentBarItem parentBarItem1;
        private Tools.XPMenus.BarItem barItem1;
        private Tools.XPMenus.ParentBarItem parentBarItem2;
        private Tools.XPMenus.BarItem barItem2;
        private GradientPanel gradientPanel1;
        private EditControl editControl1;
		private DataSet prodDs1;


        public Form1()
        {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();
            //
            // TODO: Add any constructor code after InitializeComponent call
            //

            try
            {
                System.Drawing.Icon ico = new System.Drawing.Icon(GetIconFile(@"common\Images\Grid\Icon\sfgrid.ico"));
                this.Icon = ico;
            }
            catch { }
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Syncfusion.Windows.Forms.MetroColorTable metroColorTable1 = new Syncfusion.Windows.Forms.MetroColorTable();
            this.htmluiControl1 = new Syncfusion.Windows.Forms.HTMLUI.HTMLUIControl();
            this.fontListBox1 = new Syncfusion.Windows.Forms.Tools.FontListBox();
            this.dataGrid1 = new System.Windows.Forms.DataGridView();
            this.monthCalendar1 = new Syncfusion.Windows.Forms.Tools.MonthCalendarAdv();
            this.calculatorControl1 = new Syncfusion.Windows.Forms.Tools.CalculatorControl();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.button1 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.mainFrameBarManager1 = new Syncfusion.Windows.Forms.Tools.XPMenus.MainFrameBarManager(this);
            this.bar1 = new Syncfusion.Windows.Forms.Tools.XPMenus.Bar(this.mainFrameBarManager1, "menu");
            this.parentBarItem1 = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.barItem1 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.parentBarItem2 = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.barItem2 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.gradientPanel1 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            ((System.ComponentModel.ISupportInitialize)(this.htmluiControl1)).BeginInit();
            this.htmluiControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.monthCalendar1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainFrameBarManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel1)).BeginInit();
            this.gradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // htmluiControl1
            // 
            this.htmluiControl1.AutoScroll = true;
            this.htmluiControl1.AutoScrollMinSize = new System.Drawing.Size(603, 301);
            this.htmluiControl1.BackColor = System.Drawing.Color.White;
            this.htmluiControl1.Controls.Add(this.fontListBox1);
            this.htmluiControl1.Controls.Add(this.dataGrid1);
            this.htmluiControl1.Controls.Add(this.monthCalendar1);
            this.htmluiControl1.DefaultFormat.BackgroundColor = System.Drawing.SystemColors.Control;
            this.htmluiControl1.DefaultFormat.ForeColor = System.Drawing.SystemColors.ControlText;
            this.htmluiControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.htmluiControl1.ForeColor = System.Drawing.Color.Black;
            this.htmluiControl1.Location = new System.Drawing.Point(0, 0);
            this.htmluiControl1.Name = "htmluiControl1";
            this.htmluiControl1.ShowTitle = false;
            this.htmluiControl1.Size = new System.Drawing.Size(637, 316);
            this.htmluiControl1.TabIndex = 0;
            this.htmluiControl1.Text = resources.GetString("htmluiControl1.Text");
            this.htmluiControl1.PreRenderDocument += new Syncfusion.Windows.Forms.HTMLUI.PreRenderDocumentEventHandler(this.htmluiControl1_PreRenderDocument);
            this.htmluiControl1.LoadFinished += new System.EventHandler(this.htmluiControl1_LoadFinished);
            // 
            // fontListBox1
            // 
            this.fontListBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fontListBox1.ItemHeight = 15;
            this.fontListBox1.Location = new System.Drawing.Point(248, 80);
            this.fontListBox1.MetroColor = System.Drawing.Color.Empty;
            this.fontListBox1.Name = "fontListBox1";
            metroColorTable1.ArrowChecked = System.Drawing.Color.Black;
            metroColorTable1.ArrowNormal = System.Drawing.Color.White;
            metroColorTable1.ArrowNormal = System.Drawing.Color.Gray;
            metroColorTable1.ArrowPushed = System.Drawing.Color.Black;
            metroColorTable1.ScrollerBackground = System.Drawing.Color.White;
            metroColorTable1.ThumbChecked = System.Drawing.Color.Black;
            metroColorTable1.ThumbNormal = System.Drawing.Color.White;
            metroColorTable1.ThumbNormal = System.Drawing.Color.Gray;
            metroColorTable1.ThumbPushed = System.Drawing.Color.Black;
            this.fontListBox1.ScrollMetroColorTable = metroColorTable1;
            this.fontListBox1.Size = new System.Drawing.Size(120, 92);
            this.fontListBox1.TabIndex = 4;
            this.fontListBox1.VisualStyle = Syncfusion.Windows.Forms.Tools.FontListBox.FontListBoxStyle.Metro;
            // 
            // dataGrid1
            // 
            this.dataGrid1.AccessibleName = "DataGrid";
            this.dataGrid1.AccessibleRole = System.Windows.Forms.AccessibleRole.Table;
            this.dataGrid1.DataMember = "";
            this.dataGrid1.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.dataGrid1.Location = new System.Drawing.Point(8, 176);
            this.dataGrid1.Name = "dataGrid1";
            this.dataGrid1.Size = new System.Drawing.Size(204, 144);
            this.dataGrid1.TabIndex = 2;
            this.toolTip1.SetToolTip(this.dataGrid1, "This is a DataGrid control inside HTMLUI");
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.monthCalendar1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.monthCalendar1.BottomHeight = 25;
            this.monthCalendar1.Culture = new System.Globalization.CultureInfo("");
            this.monthCalendar1.DayNamesColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.monthCalendar1.DayNamesFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.monthCalendar1.DaysFont = new System.Drawing.Font("Verdana", 8F);
            this.monthCalendar1.DaysHeaderInterior = new Syncfusion.Drawing.BrushInfo(System.Drawing.SystemColors.Window);
            this.monthCalendar1.GridLines = Syncfusion.Windows.Forms.Grid.GridBorderStyle.None;
            this.monthCalendar1.HeaderHeight = 34;
            this.monthCalendar1.HeaderStartColor = System.Drawing.Color.White;
            this.monthCalendar1.HighlightColor = System.Drawing.Color.Black;
            this.monthCalendar1.Iso8601CalenderFormat = false;
            this.monthCalendar1.Location = new System.Drawing.Point(56, 8);
            this.monthCalendar1.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.ScrollButtonSize = new System.Drawing.Size(24, 24);
            this.monthCalendar1.SelectedDates = new System.DateTime[] {
        new System.DateTime(2013, 12, 9, 0, 0, 0, 0),
        new System.DateTime(2013, 12, 9, 0, 0, 0, 0)};
            this.monthCalendar1.Size = new System.Drawing.Size(213, 183);
            this.monthCalendar1.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.monthCalendar1.TabIndex = 1;
            this.monthCalendar1.WeekFont = new System.Drawing.Font("Verdana", 8F);
            this.monthCalendar1.WeekInterior = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.PeachPuff, System.Drawing.Color.AntiqueWhite);
            // 
            // 
            // 
            this.monthCalendar1.NoneButton.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.monthCalendar1.NoneButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.monthCalendar1.NoneButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthCalendar1.NoneButton.ForeColor = System.Drawing.Color.White;
            this.monthCalendar1.NoneButton.IsBackStageButton = false;
            this.monthCalendar1.NoneButton.Location = new System.Drawing.Point(141, 0);
            this.monthCalendar1.NoneButton.Size = new System.Drawing.Size(72, 25);
            this.monthCalendar1.NoneButton.Text = "None";
            this.monthCalendar1.NoneButton.UseVisualStyle = true;
            // 
            // 
            // 
            this.monthCalendar1.TodayButton.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.monthCalendar1.TodayButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.monthCalendar1.TodayButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthCalendar1.TodayButton.ForeColor = System.Drawing.Color.White;
            this.monthCalendar1.TodayButton.IsBackStageButton = false;
            this.monthCalendar1.TodayButton.Location = new System.Drawing.Point(0, 0);
            this.monthCalendar1.TodayButton.Size = new System.Drawing.Size(141, 25);
            this.monthCalendar1.TodayButton.Text = "Today";
            this.monthCalendar1.TodayButton.UseVisualStyle = true;
            // 
            // calculatorControl1
            // 
            this.calculatorControl1.AccessibleDescription = "Calculator control";
            this.calculatorControl1.AccessibleName = "Calculator Control";
            this.calculatorControl1.BorderStyle = System.Windows.Forms.Border3DStyle.Flat;
            this.calculatorControl1.ButtonStyle = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.calculatorControl1.Culture = new System.Globalization.CultureInfo("en-US");
            this.calculatorControl1.DoubleValue = 0;
            this.calculatorControl1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.calculatorControl1.Location = new System.Drawing.Point(208, 0);
            this.calculatorControl1.MetroColor = System.Drawing.SystemColors.Control;
            this.calculatorControl1.Name = "calculatorControl1";
            this.calculatorControl1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.calculatorControl1.Size = new System.Drawing.Size(250, 300);
            this.calculatorControl1.TabIndex = 3;
            this.calculatorControl1.Text = "calculatorControl1";
            this.calculatorControl1.UseVisualStyle = true;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(10, 42);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(639, 48);
            this.panel1.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.IsBackStageButton = false;
            this.button2.Location = new System.Drawing.Point(378, 6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(138, 30);
            this.button2.TabIndex = 1;
            this.button2.Text = "Load Custom Page2";
            this.button2.UseVisualStyle = true;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.IsBackStageButton = false;
            this.button1.Location = new System.Drawing.Point(114, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 31);
            this.button1.TabIndex = 0;
            this.button1.Text = "Load Custom Page1";
            this.button1.UseVisualStyle = true;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // mainFrameBarManager1
            // 
#if !NETCORE
            this.mainFrameBarManager1.BarPositionInfo = ((System.IO.MemoryStream)(resources.GetObject("mainFrameBarManager1.BarPositionInfo")));
#endif
            this.mainFrameBarManager1.Bars.Add(this.bar1);
            this.mainFrameBarManager1.Categories.Add("File");
            this.mainFrameBarManager1.Categories.Add("View");
            this.mainFrameBarManager1.CurrentBaseFormType = "Syncfusion.Windows.Forms.MetroForm";
            this.mainFrameBarManager1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainFrameBarManager1.Form = this;
            this.mainFrameBarManager1.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.parentBarItem1,
            this.barItem1,
            this.parentBarItem2,
            this.barItem2});
            this.mainFrameBarManager1.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(110)))), ((int)(((byte)(218)))));
            this.mainFrameBarManager1.ResetCustomization = false;
            this.mainFrameBarManager1.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            // 
            // bar1
            // 
            this.bar1.BarName = "menu";
            this.bar1.Caption = "Menu";
            this.bar1.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.parentBarItem1,
            this.parentBarItem2});
            this.bar1.Manager = this.mainFrameBarManager1;
            // 
            // parentBarItem1
            // 
            this.parentBarItem1.BarName = "parentBarItem1";
            this.parentBarItem1.CategoryIndex = 0;
            this.parentBarItem1.ID = "File";
            this.parentBarItem1.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.barItem1});
            this.parentBarItem1.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(110)))), ((int)(((byte)(218)))));
            this.parentBarItem1.ShowToolTipInPopUp = false;
            this.parentBarItem1.SizeToFit = true;
            this.parentBarItem1.Text = "File";
            // 
            // barItem1
            // 
            this.barItem1.BarName = "barItem1";
            this.barItem1.CategoryIndex = 0;
            this.barItem1.ID = "Exit";
            this.barItem1.ShowToolTipInPopUp = false;
            this.barItem1.SizeToFit = true;
            this.barItem1.Text = "Exit";
            this.barItem1.Click += new System.EventHandler(this.menuItem3_Click);
            // 
            // parentBarItem2
            // 
            this.parentBarItem2.BarName = "parentBarItem2";
            this.parentBarItem2.CategoryIndex = 1;
            this.parentBarItem2.ID = "View";
            this.parentBarItem2.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.barItem2});
            this.parentBarItem2.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(110)))), ((int)(((byte)(218)))));
            this.parentBarItem2.ShowToolTipInPopUp = false;
            this.parentBarItem2.SizeToFit = true;
            this.parentBarItem2.Text = "View";
            // 
            // barItem2
            // 
            this.barItem2.BarName = "barItem2";
            this.barItem2.CategoryIndex = 1;
            this.barItem2.ID = "HTML";
            this.barItem2.ShowToolTipInPopUp = false;
            this.barItem2.SizeToFit = true;
            this.barItem2.Text = "HTML";
            this.barItem2.Click += new System.EventHandler(this.menuItem5_Click);
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gradientPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gradientPanel1.Controls.Add(this.htmluiControl1);
            this.gradientPanel1.Location = new System.Drawing.Point(10, 93);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(639, 318);
            this.gradientPanel1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.BackColor = System.Drawing.Color.White;
            this.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.ClientSize = new System.Drawing.Size(659, 415);
            this.Controls.Add(this.gradientPanel1);
            this.Controls.Add(this.panel1);
            this.DropShadow = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(671, 451);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Custom Controls";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.htmluiControl1)).EndInit();
            this.htmluiControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.monthCalendar1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mainFrameBarManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel1)).EndInit();
            this.gradientPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
            SyncfusionLicenseProvider.RegisterLicense(DemoCommon.FindLicenseKey());
            Application.Run(new Form1());
		}

		private void Form1_Load(object sender, System.EventArgs e)
		{
			this.fileloaded = 1;
			LoadHTMLResource();			
		}

		#region LOADUI
		private bool LoadHTMLResource()
		{
			bool success = false;

			try
			{
				_assembly = Assembly.GetExecutingAssembly();
				_htmlStream = (Stream)_assembly.GetManifestResourceStream("Syncfusion.Windows.Forms.HTMLUI.Samples.customcontrols.htm");
				if(_htmlStream != null)
				{
					this.htmluiControl1.LoadHTML(_htmlStream);
					success = true;
				}
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			return success;
		}
		#endregion

		#region MENU_HANDLING

		private void menuItem2_Click(object sender, System.EventArgs e)
		{
			
		}

		private void menuItem5_Click(object sender, System.EventArgs e)
		{
            Form form1 = new MetroForm();
            form1.Text = "HTML code";
            form1.ShowIcon = false;
            form1.StartPosition = FormStartPosition.CenterScreen;
            this.editControl1 = new EditControl();
            editControl1.ScrollVisualStyle = ScrollBarCustomDrawStyles.Metro;
            this.editControl1.Dock = DockStyle.Fill;
            this.editControl1.ShowLineNumbers = false;
            this.editControl1.ShowOutliningCollapsers = false;
            this.editControl1.SaveOnClose = false;
            this.editControl1.ReadOnly = true;
            this.editControl1.ShowVerticalSplitters = false;
            this.editControl1.ShowHorizontalSplitters = false;
            this.editControl1.ShowIndicatorMargin = false;
            this.editControl1.ShowVerticalScroller = false;
            editControl1.ApplyConfiguration(Edit.Enums.KnownLanguages.HTML);
            form1.Controls.Add(editControl1);
            form1.Size = new System.Drawing.Size(600, 500);
            this.editControl1.Text = this.htmluiControl1.Text;
            form1.ShowDialog();      
		}

		private void menuItem3_Click(object sender, System.EventArgs e)
		{
			Application.Exit();
		}
		#endregion

		private void htmluiControl1_PreRenderDocument(object sender, Syncfusion.Windows.Forms.HTMLUI.PreRenderDocumentArgs e)
		{
			Hashtable htmlelements = new Hashtable();
			htmlelements = e.Document.ElementsByUserID;

			if(this.fileloaded == 1)
			{
				BaseElement monthCalendarElement1 = htmlelements["monthCalendar1"] as BaseElement;
				new CustomControlBase( monthCalendarElement1, this.monthCalendar1  ); 


				BaseElement dataGridElement1 = htmlelements["dataGrid1"] as BaseElement;
				new CustomControlBase( dataGridElement1, this.dataGrid1  ); 
			}

			else
			{
				BaseElement calculatorElement1 = htmlelements["calc"] as BaseElement;
				new CustomControlBase( calculatorElement1, this.calculatorControl1);

				BaseElement fontListElement1 = htmlelements["font"] as BaseElement;
				new CustomControlBase( fontListElement1, this.fontListBox1);
			}
		}

		private void CreateDataSet()
		{
			string tableName = "Products";
			prodDs1 = new DataSet();
			prodDs1.Tables.Add(tableName);

			DataColumn ExpiresIn = prodDs1.Tables[tableName].Columns.Add("ExpiresIn", typeof( System.TimeSpan));		
			DataColumn Quantity = prodDs1.Tables[tableName].Columns.Add("Quantity", typeof(double));	
			DataColumn Value = prodDs1.Tables[tableName].Columns.Add("Value", typeof(double));	
		
			DataRow drEmpty = prodDs1.Tables[tableName].NewRow();

			prodDs1.Tables[tableName].Rows.Add(drEmpty);
			prodDs1.Tables[tableName].Rows[0]["ExpiresIn"] = new TimeSpan(0,8,0,0,0);
			prodDs1.Tables[tableName].Rows[0]["Quantity"] = 45;
			prodDs1.Tables[tableName].Rows[0]["Value"] = 2000;

			drEmpty = prodDs1.Tables[tableName].NewRow();

			prodDs1.Tables[tableName].Rows.Add(drEmpty);
			prodDs1.Tables[tableName].Rows[1]["ExpiresIn"] = new TimeSpan(0,9,0,0,0);
			prodDs1.Tables[tableName].Rows[1]["Quantity"] = 27;
			prodDs1.Tables[tableName].Rows[1]["Value"] = 3000;

			drEmpty = prodDs1.Tables[tableName].NewRow();

			prodDs1.Tables[tableName].Rows.Add(drEmpty);
			prodDs1.Tables[tableName].Rows[2]["ExpiresIn"] = new TimeSpan(0,10,0,0,0);
			prodDs1.Tables[tableName].Rows[2]["Quantity"] = 35;
			prodDs1.Tables[tableName].Rows[2]["Value"] = 4000;

			drEmpty = prodDs1.Tables[tableName].NewRow();
			prodDs1.Tables[tableName].Rows.Add(drEmpty);
			prodDs1.Tables[tableName].Rows[3]["ExpiresIn"] = new TimeSpan(0,11,0,0,0);
			prodDs1.Tables[tableName].Rows[3]["Quantity"] = 49;
			prodDs1.Tables[tableName].Rows[3]["Value"] = 5000;

			drEmpty = prodDs1.Tables[tableName].NewRow();
			prodDs1.Tables[tableName].Rows.Add(drEmpty);
			prodDs1.Tables[tableName].Rows[4]["ExpiresIn"] = new TimeSpan(0,12,0,0,0);
			prodDs1.Tables[tableName].Rows[4]["Quantity"] = 55;
			prodDs1.Tables[tableName].Rows[4]["Value"] = 6000;

			drEmpty = prodDs1.Tables[tableName].NewRow();
			prodDs1.Tables[tableName].Rows.Add(drEmpty);
			prodDs1.Tables[tableName].Rows[5]["ExpiresIn"] = new TimeSpan(0,13,0,0,0);
			prodDs1.Tables[tableName].Rows[5]["Quantity"] = 16;
			prodDs1.Tables[tableName].Rows[5]["Value"] = 7000;

			drEmpty = prodDs1.Tables[tableName].NewRow();
			prodDs1.Tables[tableName].Rows.Add(drEmpty);
			prodDs1.Tables[tableName].Rows[6]["ExpiresIn"] = new TimeSpan(0,14,0,0,0);
			prodDs1.Tables[tableName].Rows[6]["Quantity"] = 26;
			prodDs1.Tables[tableName].Rows[6]["Value"] = 300;


			drEmpty = prodDs1.Tables[tableName].NewRow();
			prodDs1.Tables[tableName].Rows.Add(drEmpty);
			prodDs1.Tables[tableName].Rows[7]["ExpiresIn"] = new TimeSpan(0,15,0,0,0);
			prodDs1.Tables[tableName].Rows[7]["Quantity"] = 46;
			prodDs1.Tables[tableName].Rows[7]["Value"] = 6700;


			drEmpty = prodDs1.Tables[tableName].NewRow();
			prodDs1.Tables[tableName].Rows.Add(drEmpty);
			prodDs1.Tables[tableName].Rows[8]["ExpiresIn"] = new TimeSpan(0,16,0,0,0);
			prodDs1.Tables[tableName].Rows[8]["Quantity"] = 36;
			prodDs1.Tables[tableName].Rows[8]["Value"] = 5600;


			drEmpty = prodDs1.Tables[tableName].NewRow();
			prodDs1.Tables[tableName].Rows.Add(drEmpty);
			prodDs1.Tables[tableName].Rows[9]["ExpiresIn"] = new TimeSpan(0,17,0,0,0);
			prodDs1.Tables[tableName].Rows[9]["Quantity"] = 22;
			prodDs1.Tables[tableName].Rows[9]["Value"] = 3800;


			drEmpty = prodDs1.Tables[tableName].NewRow();
			prodDs1.Tables[tableName].Rows.Add(drEmpty);
			prodDs1.Tables[tableName].Rows[10]["ExpiresIn"] = new TimeSpan(0,18,0,0,0);
			prodDs1.Tables[tableName].Rows[10]["Quantity"] = 42;
			prodDs1.Tables[tableName].Rows[10]["Value"] = 4500;


			drEmpty = prodDs1.Tables[tableName].NewRow();
			prodDs1.Tables[tableName].Rows.Add(drEmpty);
			prodDs1.Tables[tableName].Rows[11]["ExpiresIn"] = new TimeSpan(0,19,0,0,0);
			prodDs1.Tables[tableName].Rows[11]["Quantity"] = 52;
			prodDs1.Tables[tableName].Rows[11]["Value"] = 4350;

			this.dataGrid1.DataSource = this.prodDs1.Tables[0];
			
		}

		private void htmluiControl1_LoadFinished(object sender, System.EventArgs e)
		{
			CreateDataSet();
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			this.fileloaded = 1;
			LoadHTMLResource();	
		}

		private void LoadFromFile(string fileName)
		{
			string filePath = GetFilesLocation() + fileName;
			this.htmluiControl1.LoadHTML(filePath);
		}

		static string GetFilesLocation()
		{
			if(filePath != null)
				return filePath;

			string path;
			path = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase );
			int slashPos = path.LastIndexOf("\\",path.Length);
			slashPos = path.LastIndexOf("\\",slashPos-1);
			slashPos = path.LastIndexOf("\\",slashPos-1);
#if NETCORE
            slashPos = path.LastIndexOf("\\",slashPos-1);
#endif
            if(slashPos > 0)
				path = path.Substring(0,slashPos);
			path = path.Replace("file:\\", "");
			filePath = path + "\\files\\";
			return filePath;
		}

		private void button2_Click(object sender, System.EventArgs e)
		{
			this.fileloaded = 2;
			LoadFromFile("customcontrols2.htm");
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

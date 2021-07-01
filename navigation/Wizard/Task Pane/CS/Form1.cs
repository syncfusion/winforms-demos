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
using System.Drawing.Drawing2D;
using Syncfusion.Windows.Forms;
using Syncfusion.Licensing;
using System.IO;

namespace XPTaskPaneDemo
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : MetroForm
	{
		private Syncfusion.Windows.Forms.Tools.XPTaskPane xpTaskPane1;
		private System.Windows.Forms.Panel panel1;
		private Syncfusion.Windows.Forms.Tools.XPTaskPage xpTaskPage1;
		private System.Windows.Forms.Label label1;
		private Syncfusion.Windows.Forms.Tools.XPTaskPage xpTaskPage2;
		private Syncfusion.Windows.Forms.Tools.XPTaskPage xpTaskPage3;
		private Syncfusion.Windows.Forms.Tools.XPTaskPage xpTaskPage4;
		private System.Windows.Forms.LinkLabel linkLabel1;
		private System.Windows.Forms.LinkLabel linkLabel2;
		private System.Windows.Forms.LinkLabel linkLabel3;
		private System.Windows.Forms.LinkLabel linkLabel4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.LinkLabel linkLabel5;
		private System.Windows.Forms.LinkLabel linkLabel6;
		private System.Windows.Forms.LinkLabel linkLabel7;
		private System.Windows.Forms.LinkLabel linkLabel8;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.LinkLabel linkLabel9;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.LinkLabel linkLabel10;
		private System.Windows.Forms.LinkLabel linkLabel11;
		private System.Windows.Forms.LinkLabel linkLabel12;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.LinkLabel linkLabel15;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.LinkLabel linkLabel16;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.LinkLabel linkLabel17;
		private System.Windows.Forms.LinkLabel linkLabel18;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.ListView listView1;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.Label label4;
		private Syncfusion.Windows.Forms.Tools.RadioButtonAdv radioButton1;
		private Syncfusion.Windows.Forms.Tools.RadioButtonAdv radioButton2;
		private Syncfusion.Windows.Forms.Tools.RadioButtonAdv radioButton3;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.Label label19;
		private System.Windows.Forms.Label label20;
		private System.Windows.Forms.Label label21;
        private System.Windows.Forms.RichTextBox richTextBox1;
		private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem parentBarItem1;
		private Syncfusion.Windows.Forms.Tools.XPTaskBar xpTaskBar1;
		private Syncfusion.Windows.Forms.Tools.XPTaskBarBox xpTaskBarBox1;
		private Syncfusion.Windows.Forms.Tools.GradientPanel gradientPanel1;
		private System.Windows.Forms.ImageList imageList1;
		private System.ComponentModel.IContainer components;
		private System.Windows.Forms.LinkLabel linkLabel14;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.LinkLabel linkLabel13;
		private Syncfusion.Windows.Forms.Tools.TextBoxExt textBoxExt1;
		private Syncfusion.Windows.Forms.Tools.ComboBoxAdv comboBoxAdv1;
		private Syncfusion.Windows.Forms.ButtonAdv buttonAdv1;
		private Syncfusion.Windows.Forms.Tools.ComboBoxAdv comboBoxAdv2;
		private Syncfusion.Windows.Forms.ButtonAdv buttonAdv2;
		private Syncfusion.Windows.Forms.ButtonAdv buttonAdv3;
		private System.Windows.Forms.ListBox List;
		private System.Windows.Forms.Label label23;
		private System.Windows.Forms.Label label22;
		private System.Windows.Forms.Label label24;
		private System.Windows.Forms.Label label25;
		private System.Windows.Forms.Label label26;
		private System.Windows.Forms.Label label27;
		private System.Windows.Forms.Label label28;
		private System.Windows.Forms.Label label29;
		private System.Windows.Forms.Label label30;
		private System.Windows.Forms.Label label31;
		private System.Windows.Forms.Label label32;
		private System.Windows.Forms.Label label33;
		private Syncfusion.Windows.Forms.Tools.ComboBoxAdv comboBoxAdv3;
		private Syncfusion.Windows.Forms.ButtonAdv buttonAdv4;
		private Syncfusion.Windows.Forms.Tools.ComboBoxAdv comboBoxAdv4;
		private System.Windows.Forms.Label label34;
		private Syncfusion.Windows.Forms.ButtonAdv buttonAdv5;
		private Syncfusion.Windows.Forms.ButtonAdv buttonAdv6;
		private Syncfusion.Windows.Forms.Tools.TextBoxExt textBoxExt2;
		private Syncfusion.Windows.Forms.Tools.TextBoxExt textBoxExt3;
		private Syncfusion.Windows.Forms.ButtonAdv buttonAdv7;
		private Syncfusion.Windows.Forms.ButtonAdv buttonAdv8;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv comboBoxAdv5;
        private Syncfusion.Windows.Forms.Tools.XPMenus.MainFrameBarManager mainFrameBarManager1;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem viewTaskPaneToolStripMenuItem;
		private Syncfusion.Windows.Forms.Tools.WizardContainer wizardContainer1;
	
		public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
            this.xpTaskPage1.BackColor = Color.White;
            this.xpTaskPage2.BackColor = Color.White;
            this.xpTaskPage3.BackColor = Color.White;
            this.xpTaskPage4.BackColor = Color.White;
			#region Menu Colors
			MenuColors.DropDownBorderColor = Color.FromArgb(255,190,107);	
			MenuColors.MenuBGColor         = Color.FromArgb(247,247,247);
			MenuColors.MenuLeftStripColor  = Color.FromArgb(239,239,239);
			MenuColors.SelBorderColor	   = Color.FromArgb(255,190,107);
			MenuColors.SelColor			   = Color.FromArgb(255,231,165);
			MenuColors.CheckedSelColor	   = Color.Red;
			
			#endregion
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            int height = (int)(DpiAware.GetCurrentDpi() - 96) / 24;
            this.Size = new Size(this.Size.Width, this.Size.Height + height);
            this.MinimumSize = this.Size;
			// To select a page programatically
			this.xpTaskPane1.SelectedPage = this.xpTaskPage2;

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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "Clear Formatting"}, -1, System.Drawing.Color.Black, System.Drawing.SystemColors.Window, new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))));
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "Heading 1"}, -1, System.Drawing.Color.Black, System.Drawing.SystemColors.Window, new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0))));
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem(new string[] {
            "Heading 2"}, -1, System.Drawing.Color.Black, System.Drawing.SystemColors.Window, new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0))));
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem(new string[] {
            "Normal"}, -1, System.Drawing.Color.Black, System.Drawing.SystemColors.Window, new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))));
            this.xpTaskPane1 = new Syncfusion.Windows.Forms.Tools.XPTaskPane();
            this.wizardContainer1 = new Syncfusion.Windows.Forms.Tools.WizardContainer();
            this.xpTaskPage1 = new Syncfusion.Windows.Forms.Tools.XPTaskPage();
            this.xpTaskBar1 = new Syncfusion.Windows.Forms.Tools.XPTaskBar();
            this.xpTaskBarBox1 = new Syncfusion.Windows.Forms.Tools.XPTaskBarBox();
            this.gradientPanel1 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.linkLabel13 = new System.Windows.Forms.LinkLabel();
            this.linkLabel14 = new System.Windows.Forms.LinkLabel();
            this.label29 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.linkLabel9 = new System.Windows.Forms.LinkLabel();
            this.label6 = new System.Windows.Forms.Label();
            this.linkLabel8 = new System.Windows.Forms.LinkLabel();
            this.linkLabel7 = new System.Windows.Forms.LinkLabel();
            this.linkLabel6 = new System.Windows.Forms.LinkLabel();
            this.linkLabel5 = new System.Windows.Forms.LinkLabel();
            this.label5 = new System.Windows.Forms.Label();
            this.linkLabel4 = new System.Windows.Forms.LinkLabel();
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabel10 = new System.Windows.Forms.LinkLabel();
            this.linkLabel12 = new System.Windows.Forms.LinkLabel();
            this.linkLabel11 = new System.Windows.Forms.LinkLabel();
            this.label7 = new System.Windows.Forms.Label();
            this.xpTaskPage2 = new Syncfusion.Windows.Forms.Tools.XPTaskPage();
            this.textBoxExt2 = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.buttonAdv6 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.buttonAdv5 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.comboBoxAdv4 = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.comboBoxAdv3 = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.buttonAdv4 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.label31 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.linkLabel18 = new System.Windows.Forms.LinkLabel();
            this.linkLabel17 = new System.Windows.Forms.LinkLabel();
            this.label13 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.linkLabel15 = new System.Windows.Forms.LinkLabel();
            this.linkLabel16 = new System.Windows.Forms.LinkLabel();
            this.label9 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.xpTaskPage3 = new Syncfusion.Windows.Forms.Tools.XPTaskPage();
            this.comboBoxAdv5 = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.buttonAdv7 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.buttonAdv8 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.textBoxExt3 = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.label33 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.label15 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.xpTaskPage4 = new Syncfusion.Windows.Forms.Tools.XPTaskPage();
            this.label25 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.buttonAdv3 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.comboBoxAdv2 = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.buttonAdv2 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.textBoxExt1 = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.List = new System.Windows.Forms.ListBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.radioButton3 = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
            this.radioButton2 = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
            this.radioButton1 = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxAdv1 = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.buttonAdv1 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.panel1 = new System.Windows.Forms.Panel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.viewTaskPaneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.parentBarItem1 = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.mainFrameBarManager1 = new Syncfusion.Windows.Forms.Tools.XPMenus.MainFrameBarManager(this);
            ((System.ComponentModel.ISupportInitialize)(this.xpTaskPane1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpTaskPane1.Header)).BeginInit();
            this.xpTaskPane1.SuspendLayout();
            this.wizardContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xpTaskPage1)).BeginInit();
            this.xpTaskPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xpTaskBar1)).BeginInit();
            this.xpTaskBar1.SuspendLayout();
            this.xpTaskBarBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel1)).BeginInit();
            this.gradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xpTaskPage2)).BeginInit();
            this.xpTaskPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxExt2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxAdv4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxAdv3)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xpTaskPage3)).BeginInit();
            this.xpTaskPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxAdv5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxExt3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpTaskPage4)).BeginInit();
            this.xpTaskPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxAdv2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxExt1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioButton3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioButton2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxAdv1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainFrameBarManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // xpTaskPane1
            // 
            this.xpTaskPane1.BackColor = System.Drawing.Color.Silver;
            this.xpTaskPane1.Controls.Add(this.wizardContainer1);
            this.xpTaskPane1.Dock = System.Windows.Forms.DockStyle.Right;
            this.xpTaskPane1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // 
            // 
            this.xpTaskPane1.Header.BackColor = System.Drawing.Color.Silver;
            this.xpTaskPane1.Header.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.xpTaskPane1.Header.Controls.Add(this.xpTaskPane1.HeaderLabel);
            this.xpTaskPane1.Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.xpTaskPane1.Header.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xpTaskPane1.Header.Location = new System.Drawing.Point(0, 0);
            this.xpTaskPane1.Header.Name = "header";
            this.xpTaskPane1.Header.Size = new System.Drawing.Size(256, 22);
            this.xpTaskPane1.Header.TabIndex = 0;
            this.xpTaskPane1.Location = new System.Drawing.Point(394, 0);
            this.xpTaskPane1.MetroColor = System.Drawing.Color.Silver;
            this.xpTaskPane1.Name = "xpTaskPane1";
            this.xpTaskPane1.SelectedPage = this.xpTaskPage4;
            this.xpTaskPane1.Size = new System.Drawing.Size(256, 528);
            this.xpTaskPane1.TabIndex = 1;
            this.xpTaskPane1.TaskPages = new Syncfusion.Windows.Forms.Tools.XPTaskPage[] {
        this.xpTaskPage1,
        this.xpTaskPage2,
        this.xpTaskPage3,
        this.xpTaskPage4};
            this.xpTaskPane1.TaskPanePageContainer = this.wizardContainer1;
            this.xpTaskPane1.VerticalScroll = true;
            this.xpTaskPane1.VisualStyle = Syncfusion.Windows.Forms.VisualStyle.Metro;
            // 
            // wizardContainer1
            // 
            this.wizardContainer1.BackColor = System.Drawing.Color.White;
            this.wizardContainer1.Controls.Add(this.xpTaskPage1);
            this.wizardContainer1.Controls.Add(this.xpTaskPage2);
            this.wizardContainer1.Controls.Add(this.xpTaskPage3);
            this.wizardContainer1.Controls.Add(this.xpTaskPage4);
            this.wizardContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wizardContainer1.Location = new System.Drawing.Point(0, 22);
            this.wizardContainer1.Name = "wizardContainer1";
            this.wizardContainer1.Size = new System.Drawing.Size(256, 506);
            this.wizardContainer1.TabIndex = 0;
            // 
            // xpTaskPage1
            // 
            this.xpTaskPage1.BackColor = System.Drawing.Color.Silver;
            this.xpTaskPage1.BorderColor = System.Drawing.Color.Silver;
            this.xpTaskPage1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.xpTaskPage1.Controls.Add(this.xpTaskBar1);
            this.xpTaskPage1.Controls.Add(this.label29);
            this.xpTaskPage1.Controls.Add(this.label28);
            this.xpTaskPage1.Controls.Add(this.label27);
            this.xpTaskPage1.Controls.Add(this.label26);
            this.xpTaskPage1.Controls.Add(this.linkLabel9);
            this.xpTaskPage1.Controls.Add(this.label6);
            this.xpTaskPage1.Controls.Add(this.linkLabel8);
            this.xpTaskPage1.Controls.Add(this.linkLabel7);
            this.xpTaskPage1.Controls.Add(this.linkLabel6);
            this.xpTaskPage1.Controls.Add(this.linkLabel5);
            this.xpTaskPage1.Controls.Add(this.label5);
            this.xpTaskPage1.Controls.Add(this.linkLabel4);
            this.xpTaskPage1.Controls.Add(this.linkLabel3);
            this.xpTaskPage1.Controls.Add(this.linkLabel2);
            this.xpTaskPage1.Controls.Add(this.linkLabel1);
            this.xpTaskPage1.Controls.Add(this.label1);
            this.xpTaskPage1.Controls.Add(this.linkLabel10);
            this.xpTaskPage1.Controls.Add(this.linkLabel12);
            this.xpTaskPage1.Controls.Add(this.linkLabel11);
            this.xpTaskPage1.Controls.Add(this.label7);
            this.xpTaskPage1.LayoutName = "Card1";
            this.xpTaskPage1.Location = new System.Drawing.Point(0, 0);
            this.xpTaskPage1.Name = "xpTaskPage1";
            this.xpTaskPage1.NextPage = null;
            this.xpTaskPage1.PreviousPage = null;
            this.xpTaskPage1.Size = new System.Drawing.Size(256, 505);
            this.xpTaskPage1.TabIndex = 0;
            this.xpTaskPage1.Title = "New Document";
            // 
            // xpTaskBar1
            // 
            this.xpTaskBar1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.xpTaskBar1.BackColor = System.Drawing.Color.White;
            this.xpTaskBar1.BorderColor = System.Drawing.Color.Black;
            this.xpTaskBar1.Controls.Add(this.xpTaskBarBox1);
            this.xpTaskBar1.ForeColor = System.Drawing.Color.Black;
            this.xpTaskBar1.Location = new System.Drawing.Point(8, 379);
            this.xpTaskBar1.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218)))));
            this.xpTaskBar1.MinimumSize = new System.Drawing.Size(0, 0);
            this.xpTaskBar1.Name = "xpTaskBar1";
            this.xpTaskBar1.Size = new System.Drawing.Size(224, 120);
            this.xpTaskBar1.TabIndex = 17;
            // 
            // xpTaskBarBox1
            // 
            this.xpTaskBarBox1.BackColor = System.Drawing.Color.Transparent;
            this.xpTaskBarBox1.Controls.Add(this.gradientPanel1);
            this.xpTaskBarBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xpTaskBarBox1.HeaderBackColor = System.Drawing.Color.Transparent;
            this.xpTaskBarBox1.HeaderFont = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xpTaskBarBox1.HeaderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(73)))), ((int)(((byte)(148)))));
            this.xpTaskBarBox1.HeaderImageIndex = -1;
            this.xpTaskBarBox1.HitTaskBoxArea = false;
            this.xpTaskBarBox1.HotTrackColor = System.Drawing.Color.Empty;
            this.xpTaskBarBox1.ItemBackColor = System.Drawing.SystemColors.Window;
            this.xpTaskBarBox1.Location = new System.Drawing.Point(0, 0);
            this.xpTaskBarBox1.Name = "xpTaskBarBox1";
            this.xpTaskBarBox1.PreferredChildPanelHeight = 113;
            this.xpTaskBarBox1.ShowCollapseButton = false;
            this.xpTaskBarBox1.Size = new System.Drawing.Size(224, 142);
            this.xpTaskBarBox1.TabIndex = 0;
            this.xpTaskBarBox1.Text = "See Also";
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gradientPanel1.Controls.Add(this.checkBox1);
            this.gradientPanel1.Controls.Add(this.linkLabel13);
            this.gradientPanel1.Controls.Add(this.linkLabel14);
            this.gradientPanel1.Location = new System.Drawing.Point(2, 27);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(220, 113);
            this.gradientPanel1.TabIndex = 0;
            // 
            // checkBox1
            // 
            this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.checkBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(73)))), ((int)(((byte)(148)))));
            this.checkBox1.Location = new System.Drawing.Point(24, 64);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(120, 16);
            this.checkBox1.TabIndex = 20;
            this.checkBox1.Text = "Show at startup";
            // 
            // linkLabel13
            // 
            this.linkLabel13.Image = ((System.Drawing.Image)(resources.GetObject("linkLabel13.Image")));
            this.linkLabel13.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.linkLabel13.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(73)))), ((int)(((byte)(148)))));
            this.linkLabel13.Location = new System.Drawing.Point(16, 40);
            this.linkLabel13.Name = "linkLabel13";
            this.linkLabel13.Size = new System.Drawing.Size(128, 16);
            this.linkLabel13.TabIndex = 18;
            this.linkLabel13.TabStop = true;
            this.linkLabel13.Text = "Microsoft Word Help";
            this.linkLabel13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // linkLabel14
            // 
            this.linkLabel14.Image = ((System.Drawing.Image)(resources.GetObject("linkLabel14.Image")));
            this.linkLabel14.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.linkLabel14.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(73)))), ((int)(((byte)(148)))));
            this.linkLabel14.Location = new System.Drawing.Point(16, 16);
            this.linkLabel14.Name = "linkLabel14";
            this.linkLabel14.Size = new System.Drawing.Size(128, 16);
            this.linkLabel14.TabIndex = 19;
            this.linkLabel14.TabStop = true;
            this.linkLabel14.Text = "Add Network Place...";
            this.linkLabel14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label29
            // 
            this.label29.BackColor = System.Drawing.Color.White;
            this.label29.ForeColor = System.Drawing.Color.Black;
            this.label29.Location = new System.Drawing.Point(16, 288);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(216, 1);
            this.label29.TabIndex = 28;
            // 
            // label28
            // 
            this.label28.BackColor = System.Drawing.Color.White;
            this.label28.ForeColor = System.Drawing.Color.Black;
            this.label28.Location = new System.Drawing.Point(20, 240);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(216, 1);
            this.label28.TabIndex = 27;
            // 
            // label27
            // 
            this.label27.BackColor = System.Drawing.Color.White;
            this.label27.ForeColor = System.Drawing.Color.Black;
            this.label27.Location = new System.Drawing.Point(16, 144);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(216, 1);
            this.label27.TabIndex = 26;
            // 
            // label26
            // 
            this.label26.BackColor = System.Drawing.Color.White;
            this.label26.ForeColor = System.Drawing.Color.Black;
            this.label26.Location = new System.Drawing.Point(16, 32);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(216, 1);
            this.label26.TabIndex = 25;
            // 
            // linkLabel9
            // 
            this.linkLabel9.BackColor = System.Drawing.Color.White;
            this.linkLabel9.ForeColor = System.Drawing.Color.Black;
            this.linkLabel9.Image = ((System.Drawing.Image)(resources.GetObject("linkLabel9.Image")));
            this.linkLabel9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.linkLabel9.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(73)))), ((int)(((byte)(148)))));
            this.linkLabel9.Location = new System.Drawing.Point(24, 248);
            this.linkLabel9.Name = "linkLabel9";
            this.linkLabel9.Size = new System.Drawing.Size(120, 16);
            this.linkLabel9.TabIndex = 11;
            this.linkLabel9.TabStop = true;
            this.linkLabel9.Text = "Choose document";
            this.linkLabel9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(16, 224);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(168, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "New from existing document";
            // 
            // linkLabel8
            // 
            this.linkLabel8.BackColor = System.Drawing.Color.White;
            this.linkLabel8.ForeColor = System.Drawing.Color.Black;
            this.linkLabel8.Image = ((System.Drawing.Image)(resources.GetObject("linkLabel8.Image")));
            this.linkLabel8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.linkLabel8.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(73)))), ((int)(((byte)(148)))));
            this.linkLabel8.Location = new System.Drawing.Point(24, 152);
            this.linkLabel8.Name = "linkLabel8";
            this.linkLabel8.Size = new System.Drawing.Size(104, 16);
            this.linkLabel8.TabIndex = 9;
            this.linkLabel8.TabStop = true;
            this.linkLabel8.Text = "Blank Document";
            this.linkLabel8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // linkLabel7
            // 
            this.linkLabel7.BackColor = System.Drawing.Color.White;
            this.linkLabel7.ForeColor = System.Drawing.Color.Black;
            this.linkLabel7.Image = ((System.Drawing.Image)(resources.GetObject("linkLabel7.Image")));
            this.linkLabel7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.linkLabel7.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(73)))), ((int)(((byte)(148)))));
            this.linkLabel7.Location = new System.Drawing.Point(24, 176);
            this.linkLabel7.Name = "linkLabel7";
            this.linkLabel7.Size = new System.Drawing.Size(104, 16);
            this.linkLabel7.TabIndex = 8;
            this.linkLabel7.TabStop = true;
            this.linkLabel7.Text = "Blank Web Page";
            this.linkLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // linkLabel6
            // 
            this.linkLabel6.BackColor = System.Drawing.Color.White;
            this.linkLabel6.ForeColor = System.Drawing.Color.Black;
            this.linkLabel6.Image = ((System.Drawing.Image)(resources.GetObject("linkLabel6.Image")));
            this.linkLabel6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.linkLabel6.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(73)))), ((int)(((byte)(148)))));
            this.linkLabel6.Location = new System.Drawing.Point(24, 200);
            this.linkLabel6.Name = "linkLabel6";
            this.linkLabel6.Size = new System.Drawing.Size(136, 16);
            this.linkLabel6.TabIndex = 7;
            this.linkLabel6.TabStop = true;
            this.linkLabel6.Text = "Blank E-mail Message";
            this.linkLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // linkLabel5
            // 
            this.linkLabel5.BackColor = System.Drawing.Color.White;
            this.linkLabel5.ForeColor = System.Drawing.Color.Black;
            this.linkLabel5.Image = ((System.Drawing.Image)(resources.GetObject("linkLabel5.Image")));
            this.linkLabel5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.linkLabel5.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(73)))), ((int)(((byte)(148)))));
            this.linkLabel5.Location = new System.Drawing.Point(24, 104);
            this.linkLabel5.Name = "linkLabel5";
            this.linkLabel5.Size = new System.Drawing.Size(112, 16);
            this.linkLabel5.TabIndex = 6;
            this.linkLabel5.TabStop = true;
            this.linkLabel5.Text = "More documents...";
            this.linkLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(16, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "New";
            // 
            // linkLabel4
            // 
            this.linkLabel4.BackColor = System.Drawing.Color.White;
            this.linkLabel4.ForeColor = System.Drawing.Color.Black;
            this.linkLabel4.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(73)))), ((int)(((byte)(148)))));
            this.linkLabel4.Location = new System.Drawing.Point(24, 87);
            this.linkLabel4.Name = "linkLabel4";
            this.linkLabel4.Size = new System.Drawing.Size(72, 16);
            this.linkLabel4.TabIndex = 4;
            this.linkLabel4.TabStop = true;
            this.linkLabel4.Text = "Document 4";
            // 
            // linkLabel3
            // 
            this.linkLabel3.BackColor = System.Drawing.Color.White;
            this.linkLabel3.ForeColor = System.Drawing.Color.Black;
            this.linkLabel3.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(73)))), ((int)(((byte)(148)))));
            this.linkLabel3.Location = new System.Drawing.Point(24, 70);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new System.Drawing.Size(72, 16);
            this.linkLabel3.TabIndex = 3;
            this.linkLabel3.TabStop = true;
            this.linkLabel3.Text = "Document 3";
            // 
            // linkLabel2
            // 
            this.linkLabel2.BackColor = System.Drawing.Color.White;
            this.linkLabel2.ForeColor = System.Drawing.Color.Black;
            this.linkLabel2.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(73)))), ((int)(((byte)(148)))));
            this.linkLabel2.Location = new System.Drawing.Point(24, 53);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(72, 16);
            this.linkLabel2.TabIndex = 2;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Document 2";
            // 
            // linkLabel1
            // 
            this.linkLabel1.BackColor = System.Drawing.Color.White;
            this.linkLabel1.ForeColor = System.Drawing.Color.Black;
            this.linkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(73)))), ((int)(((byte)(148)))));
            this.linkLabel1.Location = new System.Drawing.Point(24, 36);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(72, 16);
            this.linkLabel1.TabIndex = 1;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Document 1";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(16, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Open a document                                              ";
            // 
            // linkLabel10
            // 
            this.linkLabel10.BackColor = System.Drawing.Color.White;
            this.linkLabel10.ForeColor = System.Drawing.Color.Black;
            this.linkLabel10.Image = ((System.Drawing.Image)(resources.GetObject("linkLabel10.Image")));
            this.linkLabel10.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.linkLabel10.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(73)))), ((int)(((byte)(148)))));
            this.linkLabel10.Location = new System.Drawing.Point(24, 296);
            this.linkLabel10.Name = "linkLabel10";
            this.linkLabel10.Size = new System.Drawing.Size(128, 16);
            this.linkLabel10.TabIndex = 13;
            this.linkLabel10.TabStop = true;
            this.linkLabel10.Text = "General Templates...";
            this.linkLabel10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // linkLabel12
            // 
            this.linkLabel12.BackColor = System.Drawing.Color.White;
            this.linkLabel12.ForeColor = System.Drawing.Color.Black;
            this.linkLabel12.Image = ((System.Drawing.Image)(resources.GetObject("linkLabel12.Image")));
            this.linkLabel12.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.linkLabel12.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(73)))), ((int)(((byte)(148)))));
            this.linkLabel12.Location = new System.Drawing.Point(24, 320);
            this.linkLabel12.Name = "linkLabel12";
            this.linkLabel12.Size = new System.Drawing.Size(168, 16);
            this.linkLabel12.TabIndex = 15;
            this.linkLabel12.TabStop = true;
            this.linkLabel12.Text = "Templates on my Web Sites...";
            this.linkLabel12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // linkLabel11
            // 
            this.linkLabel11.BackColor = System.Drawing.Color.White;
            this.linkLabel11.ForeColor = System.Drawing.Color.Black;
            this.linkLabel11.Image = ((System.Drawing.Image)(resources.GetObject("linkLabel11.Image")));
            this.linkLabel11.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.linkLabel11.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(73)))), ((int)(((byte)(148)))));
            this.linkLabel11.Location = new System.Drawing.Point(24, 344);
            this.linkLabel11.Name = "linkLabel11";
            this.linkLabel11.Size = new System.Drawing.Size(160, 16);
            this.linkLabel11.TabIndex = 14;
            this.linkLabel11.TabStop = true;
            this.linkLabel11.Text = "Templates on Microsoft.com";
            this.linkLabel11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(16, 272);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 16);
            this.label7.TabIndex = 12;
            this.label7.Text = "New from template";
            // 
            // xpTaskPage2
            // 
            this.xpTaskPage2.BackColor = System.Drawing.Color.Silver;
            this.xpTaskPage2.BorderColor = System.Drawing.Color.Silver;
            this.xpTaskPage2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.xpTaskPage2.Controls.Add(this.textBoxExt2);
            this.xpTaskPage2.Controls.Add(this.buttonAdv6);
            this.xpTaskPage2.Controls.Add(this.buttonAdv5);
            this.xpTaskPage2.Controls.Add(this.comboBoxAdv4);
            this.xpTaskPage2.Controls.Add(this.comboBoxAdv3);
            this.xpTaskPage2.Controls.Add(this.buttonAdv4);
            this.xpTaskPage2.Controls.Add(this.label31);
            this.xpTaskPage2.Controls.Add(this.label30);
            this.xpTaskPage2.Controls.Add(this.panel3);
            this.xpTaskPage2.Controls.Add(this.label11);
            this.xpTaskPage2.Controls.Add(this.label2);
            this.xpTaskPage2.Controls.Add(this.linkLabel15);
            this.xpTaskPage2.Controls.Add(this.linkLabel16);
            this.xpTaskPage2.Controls.Add(this.label9);
            this.xpTaskPage2.Controls.Add(this.label12);
            this.xpTaskPage2.Controls.Add(this.label8);
            this.xpTaskPage2.Controls.Add(this.label10);
            this.xpTaskPage2.LayoutName = "Card2";
            this.xpTaskPage2.Location = new System.Drawing.Point(0, 0);
            this.xpTaskPage2.Name = "xpTaskPage2";
            this.xpTaskPage2.NextPage = null;
            this.xpTaskPage2.PreviousPage = null;
            this.xpTaskPage2.Size = new System.Drawing.Size(256, 505);
            this.xpTaskPage2.TabIndex = 1;
            this.xpTaskPage2.Title = "Basic Search";
            // 
            // textBoxExt2
            // 
            this.textBoxExt2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxExt2.ForeColor = System.Drawing.Color.Black;
            this.textBoxExt2.Location = new System.Drawing.Point(24, 64);
            this.textBoxExt2.Metrocolor = System.Drawing.Color.Empty;
            this.textBoxExt2.Name = "textBoxExt2";
            this.textBoxExt2.OverflowIndicatorToolTipText = null;
            this.textBoxExt2.Size = new System.Drawing.Size(192, 20);
            this.textBoxExt2.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.textBoxExt2.TabIndex = 0;
            // 
            // buttonAdv6
            // 
            this.buttonAdv6.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.buttonAdv6.BackColor = System.Drawing.Color.Gray;
            this.buttonAdv6.ForeColor = System.Drawing.Color.White;
            this.buttonAdv6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAdv6.KeepFocusRectangle = false;
            this.buttonAdv6.Location = new System.Drawing.Point(128, 96);
            this.buttonAdv6.Name = "buttonAdv6";
            this.buttonAdv6.Size = new System.Drawing.Size(88, 23);
            this.buttonAdv6.TabIndex = 33;
            this.buttonAdv6.Text = "Restore";
            this.buttonAdv6.UseVisualStyle = true;
            // 
            // buttonAdv5
            // 
            this.buttonAdv5.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.buttonAdv5.BackColor = System.Drawing.Color.Gray;
            this.buttonAdv5.ForeColor = System.Drawing.Color.White;
            this.buttonAdv5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAdv5.KeepFocusRectangle = false;
            this.buttonAdv5.Location = new System.Drawing.Point(24, 96);
            this.buttonAdv5.Name = "buttonAdv5";
            this.buttonAdv5.Size = new System.Drawing.Size(72, 23);
            this.buttonAdv5.TabIndex = 32;
            this.buttonAdv5.Text = "Search";
            this.buttonAdv5.UseVisualStyle = true;
            // 
            // comboBoxAdv4
            // 
            this.comboBoxAdv4.BackColor = System.Drawing.Color.White;
            this.comboBoxAdv4.ForeColor = System.Drawing.Color.Black;
            this.comboBoxAdv4.Location = new System.Drawing.Point(24, 264);
            this.comboBoxAdv4.Name = "comboBoxAdv4";
            this.comboBoxAdv4.Size = new System.Drawing.Size(152, 21);
            this.comboBoxAdv4.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.comboBoxAdv4.TabIndex = 31;
            this.comboBoxAdv4.Text = "Selected locations";
            // 
            // comboBoxAdv3
            // 
            this.comboBoxAdv3.BackColor = System.Drawing.Color.White;
            this.comboBoxAdv3.ForeColor = System.Drawing.Color.Black;
            this.comboBoxAdv3.Location = new System.Drawing.Point(24, 216);
            this.comboBoxAdv3.Name = "comboBoxAdv3";
            this.comboBoxAdv3.Size = new System.Drawing.Size(152, 21);
            this.comboBoxAdv3.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.comboBoxAdv3.TabIndex = 30;
            this.comboBoxAdv3.Text = "Selected locations";
            // 
            // buttonAdv4
            // 
            this.buttonAdv4.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.buttonAdv4.BackColor = System.Drawing.Color.Gray;
            this.buttonAdv4.ForeColor = System.Drawing.Color.White;
            this.buttonAdv4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAdv4.KeepFocusRectangle = false;
            this.buttonAdv4.Location = new System.Drawing.Point(192, 216);
            this.buttonAdv4.Name = "buttonAdv4";
            this.buttonAdv4.Size = new System.Drawing.Size(32, 23);
            this.buttonAdv4.TabIndex = 29;
            this.buttonAdv4.Text = ">>";
            this.buttonAdv4.UseVisualStyle = true;
            // 
            // label31
            // 
            this.label31.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(166)))), ((int)(((byte)(231)))));
            this.label31.ForeColor = System.Drawing.Color.Black;
            this.label31.Location = new System.Drawing.Point(8, 176);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(216, 1);
            this.label31.TabIndex = 28;
            // 
            // label30
            // 
            this.label30.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(166)))), ((int)(((byte)(231)))));
            this.label30.ForeColor = System.Drawing.Color.Black;
            this.label30.Location = new System.Drawing.Point(8, 32);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(216, 1);
            this.label30.TabIndex = 27;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.linkLabel18);
            this.panel3.Controls.Add(this.linkLabel17);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.label34);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 433);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(256, 72);
            this.panel3.TabIndex = 14;
            // 
            // linkLabel18
            // 
            this.linkLabel18.ForeColor = System.Drawing.Color.Black;
            this.linkLabel18.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(73)))), ((int)(((byte)(148)))));
            this.linkLabel18.Location = new System.Drawing.Point(24, 48);
            this.linkLabel18.Name = "linkLabel18";
            this.linkLabel18.Size = new System.Drawing.Size(144, 23);
            this.linkLabel18.TabIndex = 4;
            this.linkLabel18.TabStop = true;
            this.linkLabel18.Text = "Find in this document";
            // 
            // linkLabel17
            // 
            this.linkLabel17.ForeColor = System.Drawing.Color.Black;
            this.linkLabel17.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(73)))), ((int)(((byte)(148)))));
            this.linkLabel17.Location = new System.Drawing.Point(24, 32);
            this.linkLabel17.Name = "linkLabel17";
            this.linkLabel17.Size = new System.Drawing.Size(100, 16);
            this.linkLabel17.TabIndex = 3;
            this.linkLabel17.TabStop = true;
            this.linkLabel17.Text = "Advanced Search";
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(16, 8);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(208, 16);
            this.label13.TabIndex = 2;
            this.label13.Text = "See also";
            // 
            // label34
            // 
            this.label34.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(166)))), ((int)(((byte)(231)))));
            this.label34.ForeColor = System.Drawing.Color.Black;
            this.label34.Location = new System.Drawing.Point(16, 24);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(216, 1);
            this.label34.TabIndex = 32;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(24, 240);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(100, 16);
            this.label11.TabIndex = 10;
            this.label11.Text = "Results should be:";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(8, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Search for:";
            // 
            // linkLabel15
            // 
            this.linkLabel15.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel15.ForeColor = System.Drawing.Color.Black;
            this.linkLabel15.Image = ((System.Drawing.Image)(resources.GetObject("linkLabel15.Image")));
            this.linkLabel15.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.linkLabel15.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(73)))), ((int)(((byte)(148)))));
            this.linkLabel15.Location = new System.Drawing.Point(24, 128);
            this.linkLabel15.Name = "linkLabel15";
            this.linkLabel15.Size = new System.Drawing.Size(96, 16);
            this.linkLabel15.TabIndex = 40;
            this.linkLabel15.TabStop = true;
            this.linkLabel15.Text = "Search Tips...";
            this.linkLabel15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // linkLabel16
            // 
            this.linkLabel16.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel16.ForeColor = System.Drawing.Color.Black;
            this.linkLabel16.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(73)))), ((int)(((byte)(148)))));
            this.linkLabel16.Location = new System.Drawing.Point(24, 320);
            this.linkLabel16.Name = "linkLabel16";
            this.linkLabel16.Size = new System.Drawing.Size(96, 16);
            this.linkLabel16.TabIndex = 13;
            this.linkLabel16.TabStop = true;
            this.linkLabel16.Text = "Search options...";
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(8, 160);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(136, 16);
            this.label9.TabIndex = 7;
            this.label9.Text = "Other Search Options:";
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(24, 296);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(192, 16);
            this.label12.TabIndex = 12;
            this.label12.Text = "Fast searching is currently disabled";
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(24, 40);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 16);
            this.label8.TabIndex = 2;
            this.label8.Text = "Search text:";
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(24, 192);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 16);
            this.label10.TabIndex = 8;
            this.label10.Text = "Search in:";
            // 
            // xpTaskPage3
            // 
            this.xpTaskPage3.BackColor = System.Drawing.Color.Silver;
            this.xpTaskPage3.BorderColor = System.Drawing.Color.Silver;
            this.xpTaskPage3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.xpTaskPage3.Controls.Add(this.comboBoxAdv5);
            this.xpTaskPage3.Controls.Add(this.buttonAdv7);
            this.xpTaskPage3.Controls.Add(this.buttonAdv8);
            this.xpTaskPage3.Controls.Add(this.textBoxExt3);
            this.xpTaskPage3.Controls.Add(this.label33);
            this.xpTaskPage3.Controls.Add(this.label32);
            this.xpTaskPage3.Controls.Add(this.label16);
            this.xpTaskPage3.Controls.Add(this.listView1);
            this.xpTaskPage3.Controls.Add(this.label15);
            this.xpTaskPage3.Controls.Add(this.label3);
            this.xpTaskPage3.LayoutName = "Card3";
            this.xpTaskPage3.Location = new System.Drawing.Point(0, 0);
            this.xpTaskPage3.Name = "xpTaskPage3";
            this.xpTaskPage3.NextPage = null;
            this.xpTaskPage3.PreviousPage = null;
            this.xpTaskPage3.Size = new System.Drawing.Size(256, 505);
            this.xpTaskPage3.TabIndex = 2;
            this.xpTaskPage3.Title = "Styles and Formatting";
            // 
            // comboBoxAdv5
            // 
            this.comboBoxAdv5.BackColor = System.Drawing.Color.White;
            this.comboBoxAdv5.ForeColor = System.Drawing.Color.Black;
            this.comboBoxAdv5.Location = new System.Drawing.Point(48, 464);
            this.comboBoxAdv5.Name = "comboBoxAdv5";
            this.comboBoxAdv5.Size = new System.Drawing.Size(184, 21);
            this.comboBoxAdv5.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.comboBoxAdv5.TabIndex = 36;
            this.comboBoxAdv5.Text = "Available Formatting";
            // 
            // buttonAdv7
            // 
            this.buttonAdv7.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.buttonAdv7.BackColor = System.Drawing.Color.Gray;
            this.buttonAdv7.ForeColor = System.Drawing.Color.White;
            this.buttonAdv7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAdv7.KeepFocusRectangle = false;
            this.buttonAdv7.Location = new System.Drawing.Point(120, 72);
            this.buttonAdv7.Name = "buttonAdv7";
            this.buttonAdv7.Size = new System.Drawing.Size(88, 23);
            this.buttonAdv7.TabIndex = 35;
            this.buttonAdv7.Text = "New Style";
            this.buttonAdv7.UseVisualStyle = true;
            // 
            // buttonAdv8
            // 
            this.buttonAdv8.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.buttonAdv8.BackColor = System.Drawing.Color.Gray;
            this.buttonAdv8.ForeColor = System.Drawing.Color.White;
            this.buttonAdv8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAdv8.KeepFocusRectangle = false;
            this.buttonAdv8.Location = new System.Drawing.Point(16, 72);
            this.buttonAdv8.Name = "buttonAdv8";
            this.buttonAdv8.Size = new System.Drawing.Size(72, 23);
            this.buttonAdv8.TabIndex = 34;
            this.buttonAdv8.Text = "Select All";
            this.buttonAdv8.UseVisualStyle = true;
            // 
            // textBoxExt3
            // 
            this.textBoxExt3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxExt3.ForeColor = System.Drawing.Color.Black;
            this.textBoxExt3.Location = new System.Drawing.Point(16, 40);
            this.textBoxExt3.Metrocolor = System.Drawing.Color.Empty;
            this.textBoxExt3.Name = "textBoxExt3";
            this.textBoxExt3.OverflowIndicatorToolTipText = null;
            this.textBoxExt3.Size = new System.Drawing.Size(200, 20);
            this.textBoxExt3.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.textBoxExt3.TabIndex = 29;
            this.textBoxExt3.Text = "Normal";
            // 
            // label33
            // 
            this.label33.BackColor = System.Drawing.Color.Black;
            this.label33.ForeColor = System.Drawing.Color.Black;
            this.label33.Location = new System.Drawing.Point(16, 128);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(216, 1);
            this.label33.TabIndex = 28;
            // 
            // label32
            // 
            this.label32.BackColor = System.Drawing.Color.Black;
            this.label32.Location = new System.Drawing.Point(8, 24);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(216, 1);
            this.label32.TabIndex = 27;
            // 
            // label16
            // 
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.ForeColor = System.Drawing.Color.Black;
            this.label16.Location = new System.Drawing.Point(6, 469);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(56, 16);
            this.label16.TabIndex = 8;
            this.label16.Text = "Show";
            // 
            // listView1
            // 
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.ForeColor = System.Drawing.Color.Black;
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4});
            this.listView1.Location = new System.Drawing.Point(16, 144);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(216, 312);
            this.listView1.TabIndex = 7;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.List;
            // 
            // label15
            // 
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(16, 112);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(160, 16);
            this.label15.TabIndex = 6;
            this.label15.Text = "Pick formatting to apply";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(8, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Formatting of selected text";
            // 
            // xpTaskPage4
            // 
            this.xpTaskPage4.BackColor = System.Drawing.Color.White;
            this.xpTaskPage4.BorderColor = System.Drawing.Color.Silver;
            this.xpTaskPage4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.xpTaskPage4.Controls.Add(this.label25);
            this.xpTaskPage4.Controls.Add(this.label24);
            this.xpTaskPage4.Controls.Add(this.label22);
            this.xpTaskPage4.Controls.Add(this.label23);
            this.xpTaskPage4.Controls.Add(this.buttonAdv3);
            this.xpTaskPage4.Controls.Add(this.comboBoxAdv2);
            this.xpTaskPage4.Controls.Add(this.buttonAdv2);
            this.xpTaskPage4.Controls.Add(this.textBoxExt1);
            this.xpTaskPage4.Controls.Add(this.label21);
            this.xpTaskPage4.Controls.Add(this.label20);
            this.xpTaskPage4.Controls.Add(this.List);
            this.xpTaskPage4.Controls.Add(this.label19);
            this.xpTaskPage4.Controls.Add(this.label18);
            this.xpTaskPage4.Controls.Add(this.label17);
            this.xpTaskPage4.Controls.Add(this.radioButton3);
            this.xpTaskPage4.Controls.Add(this.radioButton2);
            this.xpTaskPage4.Controls.Add(this.radioButton1);
            this.xpTaskPage4.Controls.Add(this.label4);
            this.xpTaskPage4.Controls.Add(this.comboBoxAdv1);
            this.xpTaskPage4.Controls.Add(this.buttonAdv1);
            this.xpTaskPage4.LayoutName = "Card4";
            this.xpTaskPage4.Location = new System.Drawing.Point(0, 0);
            this.xpTaskPage4.Name = "xpTaskPage4";
            this.xpTaskPage4.NextPage = null;
            this.xpTaskPage4.PreviousPage = null;
            this.xpTaskPage4.Size = new System.Drawing.Size(256, 505);
            this.xpTaskPage4.TabIndex = 3;
            this.xpTaskPage4.Title = "Translate";
            // 
            // label25
            // 
            this.label25.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(166)))), ((int)(((byte)(231)))));
            this.label25.ForeColor = System.Drawing.Color.Black;
            this.label25.Location = new System.Drawing.Point(24, 448);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(216, 1);
            this.label25.TabIndex = 27;
            // 
            // label24
            // 
            this.label24.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(166)))), ((int)(((byte)(231)))));
            this.label24.ForeColor = System.Drawing.Color.Black;
            this.label24.Location = new System.Drawing.Point(16, 200);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(216, 1);
            this.label24.TabIndex = 26;
            // 
            // label22
            // 
            this.label22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(166)))), ((int)(((byte)(231)))));
            this.label22.ForeColor = System.Drawing.Color.Black;
            this.label22.Location = new System.Drawing.Point(16, 128);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(216, 1);
            this.label22.TabIndex = 25;
            // 
            // label23
            // 
            this.label23.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(166)))), ((int)(((byte)(231)))));
            this.label23.ForeColor = System.Drawing.Color.Black;
            this.label23.Location = new System.Drawing.Point(16, 24);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(216, 1);
            this.label23.TabIndex = 24;
            // 
            // buttonAdv3
            // 
            this.buttonAdv3.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.buttonAdv3.BackColor = System.Drawing.Color.Gray;
            this.buttonAdv3.ForeColor = System.Drawing.Color.White;
            this.buttonAdv3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAdv3.KeepFocusRectangle = false;
            this.buttonAdv3.Location = new System.Drawing.Point(136, 376);
            this.buttonAdv3.Name = "buttonAdv3";
            this.buttonAdv3.Size = new System.Drawing.Size(96, 23);
            this.buttonAdv3.TabIndex = 22;
            this.buttonAdv3.Text = "Replace";
            this.buttonAdv3.UseVisualStyle = true;
            // 
            // comboBoxAdv2
            // 
            this.comboBoxAdv2.BackColor = System.Drawing.Color.White;
            this.comboBoxAdv2.ForeColor = System.Drawing.Color.Black;
            this.comboBoxAdv2.Location = new System.Drawing.Point(24, 456);
            this.comboBoxAdv2.Name = "comboBoxAdv2";
            this.comboBoxAdv2.Size = new System.Drawing.Size(160, 21);
            this.comboBoxAdv2.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.comboBoxAdv2.TabIndex = 21;
            // 
            // buttonAdv2
            // 
            this.buttonAdv2.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.buttonAdv2.BackColor = System.Drawing.Color.Gray;
            this.buttonAdv2.ForeColor = System.Drawing.Color.White;
            this.buttonAdv2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAdv2.KeepFocusRectangle = false;
            this.buttonAdv2.Location = new System.Drawing.Point(200, 456);
            this.buttonAdv2.Name = "buttonAdv2";
            this.buttonAdv2.Size = new System.Drawing.Size(32, 23);
            this.buttonAdv2.TabIndex = 20;
            this.buttonAdv2.Text = ">>";
            this.buttonAdv2.UseVisualStyle = true;
            // 
            // textBoxExt1
            // 
            this.textBoxExt1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxExt1.Enabled = false;
            this.textBoxExt1.ForeColor = System.Drawing.Color.Black;
            this.textBoxExt1.Location = new System.Drawing.Point(88, 32);
            this.textBoxExt1.Metrocolor = System.Drawing.Color.Empty;
            this.textBoxExt1.Name = "textBoxExt1";
            this.textBoxExt1.OverflowIndicatorToolTipText = null;
            this.textBoxExt1.Size = new System.Drawing.Size(144, 20);
            this.textBoxExt1.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.textBoxExt1.TabIndex = 19;
            // 
            // label21
            // 
            this.label21.BackColor = System.Drawing.Color.Transparent;
            this.label21.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.Black;
            this.label21.Location = new System.Drawing.Point(24, 432);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(136, 16);
            this.label21.TabIndex = 16;
            this.label21.Text = "Translate via Web";
            // 
            // label20
            // 
            this.label20.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label20.BackColor = System.Drawing.Color.Transparent;
            this.label20.ForeColor = System.Drawing.Color.Black;
            this.label20.Location = new System.Drawing.Point(16, 336);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(216, 32);
            this.label20.TabIndex = 14;
            this.label20.Text = "Select a word in the Results and click Replace to add it to your document";
            // 
            // List
            // 
            this.List.BackColor = System.Drawing.SystemColors.Window;
            this.List.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.List.ForeColor = System.Drawing.Color.Black;
            this.List.HorizontalScrollbar = true;
            this.List.Location = new System.Drawing.Point(16, 208);
            this.List.Name = "List";
            this.List.Size = new System.Drawing.Size(216, 106);
            this.List.TabIndex = 13;
            // 
            // label19
            // 
            this.label19.BackColor = System.Drawing.Color.White;
            this.label19.ForeColor = System.Drawing.Color.Black;
            this.label19.Location = new System.Drawing.Point(16, 184);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(100, 16);
            this.label19.TabIndex = 12;
            this.label19.Text = "Results";
            // 
            // label18
            // 
            this.label18.BackColor = System.Drawing.Color.White;
            this.label18.ForeColor = System.Drawing.Color.Black;
            this.label18.Location = new System.Drawing.Point(16, 136);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(100, 16);
            this.label18.TabIndex = 9;
            this.label18.Text = "Dictionary";
            // 
            // label17
            // 
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Black;
            this.label17.Location = new System.Drawing.Point(16, 112);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(128, 16);
            this.label17.TabIndex = 8;
            this.label17.Text = "Look up in dictionary";
            // 
            // radioButton3
            // 
            this.radioButton3.BackColor = System.Drawing.Color.White;
            this.radioButton3.DrawFocusRectangle = false;
            this.radioButton3.ForeColor = System.Drawing.Color.Black;
            this.radioButton3.Location = new System.Drawing.Point(24, 88);
            this.radioButton3.MetroColor = System.Drawing.Color.Silver;
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(112, 16);
            this.radioButton3.Style = Syncfusion.Windows.Forms.Tools.RadioButtonAdvStyle.Metro;
            this.radioButton3.TabIndex = 7;
            this.radioButton3.TabStop = false;
            this.radioButton3.Text = "Entire document";
            this.radioButton3.ThemesEnabled = false;
            // 
            // radioButton2
            // 
            this.radioButton2.BackColor = System.Drawing.Color.White;
            this.radioButton2.Checked = true;
            this.radioButton2.DrawFocusRectangle = false;
            this.radioButton2.ForeColor = System.Drawing.Color.Black;
            this.radioButton2.Location = new System.Drawing.Point(24, 62);
            this.radioButton2.MetroColor = System.Drawing.Color.Silver;
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(112, 16);
            this.radioButton2.Style = Syncfusion.Windows.Forms.Tools.RadioButtonAdvStyle.Metro;
            this.radioButton2.TabIndex = 6;
            this.radioButton2.Text = "Current selection";
            this.radioButton2.ThemesEnabled = false;
            this.radioButton2.CheckChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.BackColor = System.Drawing.Color.White;
            this.radioButton1.DrawFocusRectangle = false;
            this.radioButton1.ForeColor = System.Drawing.Color.Black;
            this.radioButton1.Location = new System.Drawing.Point(24, 32);
            this.radioButton1.MetroColor = System.Drawing.Color.Silver;
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(48, 16);
            this.radioButton1.Style = Syncfusion.Windows.Forms.Tools.RadioButtonAdvStyle.Metro;
            this.radioButton1.TabIndex = 4;
            this.radioButton1.Text = "Text:";
            this.radioButton1.ThemesEnabled = false;
            this.radioButton1.CheckChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(16, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Translate what?";
            // 
            // comboBoxAdv1
            // 
            this.comboBoxAdv1.BackColor = System.Drawing.Color.White;
            this.comboBoxAdv1.ForeColor = System.Drawing.Color.Black;
            this.comboBoxAdv1.Location = new System.Drawing.Point(16, 152);
            this.comboBoxAdv1.Name = "comboBoxAdv1";
            this.comboBoxAdv1.Size = new System.Drawing.Size(168, 21);
            this.comboBoxAdv1.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.comboBoxAdv1.TabIndex = 4;
            this.comboBoxAdv1.Text = "(no dictionaries available)";
            // 
            // buttonAdv1
            // 
            this.buttonAdv1.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.buttonAdv1.BackColor = System.Drawing.Color.White;
            this.buttonAdv1.ForeColor = System.Drawing.Color.White;
            this.buttonAdv1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAdv1.KeepFocusRectangle = false;
            this.buttonAdv1.Location = new System.Drawing.Point(200, 152);
            this.buttonAdv1.Name = "buttonAdv1";
            this.buttonAdv1.Size = new System.Drawing.Size(32, 23);
            this.buttonAdv1.TabIndex = 4;
            this.buttonAdv1.Text = ">>";
            this.buttonAdv1.UseVisualStyle = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(391, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(3, 528);
            this.panel1.TabIndex = 2;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.White;
            this.richTextBox1.ContextMenuStrip = this.contextMenuStrip1;
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.ForeColor = System.Drawing.Color.Black;
            this.richTextBox1.Location = new System.Drawing.Point(0, 0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(391, 528);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "XP TaskPane is a container control that can host a number of pages (XP TaskPage) " +
    "which the user can browse using a drop-down menu and the arrow buttons in task p" +
    "ane\'s header portion.";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewTaskPaneToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(150, 26);
            this.contextMenuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.contextMenuStrip1_ItemClicked);
            // 
            // viewTaskPaneToolStripMenuItem
            // 
            this.viewTaskPaneToolStripMenuItem.Name = "viewTaskPaneToolStripMenuItem";
            this.viewTaskPaneToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.viewTaskPaneToolStripMenuItem.Text = "ViewTaskPane";
            // 
            // parentBarItem1
            // 
            this.parentBarItem1.BarName = "parentBarItem1";
            this.parentBarItem1.ID = "BarItem";
            this.parentBarItem1.MetroColor = System.Drawing.Color.LightSkyBlue;
            this.parentBarItem1.ShowToolTipInPopUp = false;
            this.parentBarItem1.SizeToFit = true;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "");
            // 
            // mainFrameBarManager1
            // 
#if !NETCORE
            this.mainFrameBarManager1.BarPositionInfo = ((System.IO.MemoryStream)(resources.GetObject("mainFrameBarManager1.BarPositionInfo")));
#endif
            this.mainFrameBarManager1.CurrentBaseFormType = "Syncfusion.Windows.Forms.MetroForm";
            this.mainFrameBarManager1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainFrameBarManager1.Form = this;
            this.mainFrameBarManager1.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(110)))), ((int)(((byte)(218)))));
            this.mainFrameBarManager1.ResetCustomization = false;
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.CaptionAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ClientSize = new System.Drawing.Size(650, 528);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.xpTaskPane1);
            this.DropShadow = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IconAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.IconTextRelation = System.Windows.Forms.LeftRightAlignment.Left;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Task Pane Demo";
            ((System.ComponentModel.ISupportInitialize)(this.xpTaskPane1.Header)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpTaskPane1)).EndInit();
            this.xpTaskPane1.ResumeLayout(false);
            this.wizardContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.xpTaskPage1)).EndInit();
            this.xpTaskPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.xpTaskBar1)).EndInit();
            this.xpTaskBar1.ResumeLayout(false);
            this.xpTaskBarBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel1)).EndInit();
            this.gradientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.xpTaskPage2)).EndInit();
            this.xpTaskPage2.ResumeLayout(false);
            this.xpTaskPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxExt2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxAdv4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxAdv3)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.xpTaskPage3)).EndInit();
            this.xpTaskPage3.ResumeLayout(false);
            this.xpTaskPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxAdv5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxExt3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpTaskPage4)).EndInit();
            this.xpTaskPage4.ResumeLayout(false);
            this.xpTaskPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxAdv2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxExt1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioButton3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioButton2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxAdv1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mainFrameBarManager1)).EndInit();
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

		private void radioButton1_CheckedChanged(object sender, System.EventArgs e)
		{
			this.textBoxExt1.Enabled = this.radioButton1.Checked;
        }

        private void contextMenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem.Text == "ViewTaskPane")
                this.xpTaskPane1.Visible = !this.xpTaskPane1.Visible;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

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

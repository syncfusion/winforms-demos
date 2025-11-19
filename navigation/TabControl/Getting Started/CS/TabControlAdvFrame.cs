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
using System.Drawing.Drawing2D;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using Syncfusion.Windows.Forms.Tools;
using System.Resources;
using Syncfusion.Windows.Forms;
using System.Diagnostics;
using Syncfusion.Windows.Forms.Tools.Design;
using System.Runtime.InteropServices;


namespace xptabs
{
    using Syncfusion.Licensing;
    using TabControlAdv_2005;

    public class TabControlAdvFrame : MetroForm
    {
        #region Declaration
        private System.Windows.Forms.ImageList imageList;
        private Label label1;      
        private TabControlAdv FormTabControl;
        private TabPageAdv tab3;
        private TabPageAdv tab4;
        private TabPageAdv tab6;
        private Label label40;
        private TabControlAdv PrimitivesTabControl;
        private GradientPanel gradientPanel1;
        private Label label2;
        private TabControlAdv BehaviorTabControl;
        private TabPageAdv tabPageAdv3;
        private TabPageAdv tabPageAdv4;
        private TabPageAdv tabPageAdv5;
        private TabPageAdv tabPageAdv6;
        private TabPageAdv tabPageAdv7;
        private TabPageAdv tabPageAdv8;
        private Label label6;
        private CheckBoxAdv checkBox6;
        private CheckBoxAdv checkBox5;
        private CheckBoxAdv checkBox4;
        private CheckBoxAdv checkBox3;
        private CheckBoxAdv checkBox2;
        private CheckBoxAdv checkBox1;
        private ToolTip toolTip1;
        private CheckBoxAdv checkBox7;
        private CheckBoxAdv checkBox9;
        private CheckBoxAdv checkBox8;
        private CheckBoxAdv checkBox14;
        private CheckBoxAdv checkBox13;
        private CheckBoxAdv checkBox12;
        private CheckBoxAdv checkBox11;
        private CheckBoxAdv checkBox10;
        private CheckBoxAdv checkBox17;
        private Label label5;
        private Label label17;
        private Label label16;
        private Label label15;
        private Label label18;
        private ColorDialog colorDialog1;
        private ButtonEdit activeTabColorEdit;
        private ButtonEditChildButton buttonEditChildButton1;
        private ButtonEdit panelColorEdit;
        private ButtonEditChildButton buttonEditChildButton4;
        private ButtonEdit borderColorEdit;
        private ButtonEditChildButton buttonEditChildButton3;
        private ButtonEdit inactiveTabColorEdit;
        private ButtonEditChildButton buttonEditChildButton2;
        private Label label19;
        private CheckBoxAdv checkBox24;
        private CheckBoxAdv checkBox23;
        private CheckBoxAdv checkBox22;
        private CheckBoxAdv checkBox21;
        private CheckBoxAdv checkBox20;
        private CheckBoxAdv checkBox19;
        private CheckBoxAdv checkBox18;
        private ComboBoxAdv comboBox3;
        private ComboBoxAdv comboBox2;
        private Label label25;
        private ComboBoxAdv comboBox1;
        private Label label30;
        private Label label29;
        private Label label28;
        private NumericUpDownExt numericUpDown1;
        private TabPageAdv tabPageAdv1;
        private TabPageAdv tabPageAdv2;
        private TabPageAdv tabPageAdv9;
        private TabPageAdv tabPageAdv10;
        private TabPageAdv tabPageAdv11;
        private ContextMenuStripEx contextMenuStripEx1;
        private ToolStripMenuItem addTabToolStripMenuItem;
        private CheckBoxAdv contextMenuCheck;
        private Point tabPoint;
        private CheckBoxAdv checkBox16;
        private TabPageAdv tabPageAdv12;
        private TabPageAdv tabPageAdv13;
        private Label label35;
        private Label label34;
        private Label label26;
        private Label label10;
        private ListBox listBox1;
        private Label label27;
        private CheckBoxAdv checkBox15;
        private CheckBoxAdv checkBox25;
		private System.ComponentModel.IContainer components;

        private TabPageAdv Appearance, Behavior, Tab_Primitives, tabPage1;
        private Label label36;
        private CheckBoxAdv checkBox26;
        private GradientPanel gradientPanel2;
        private GradientPanel gradientPanel3;
        private GradientPanel gradientPanel4;
        private SuperToolTip superToolTip1;
        [DllImport("user32.dll")]
        static extern bool LockWindowUpdate(IntPtr hWndLock);

        #endregion-

        #region Form constructor, Main & Dispose
        public TabControlAdvFrame()
		{
			InitializeComponent();

            PopulateTabStyles();
            InitializeItems();
            this.MinimumSize = this.Size;
            try
            {
                System.Drawing.Icon ico = new System.Drawing.Icon(GetIconFile(@"common\Images\Grid\Icon\sfgrid.ico"));
                this.Icon = ico;
            }
            catch { }



            foreach (TabPageAdv tp in BehaviorTabControl.TabPages)
            {
                tp.Closing += new TabPageAdvClosingEventHandler(tp_Closing);
                tp.Closed += new EventHandler(tp_Closed);
            }
            this.Load += new EventHandler(TabControlAdvFrame_Load);
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

        void TabControlAdvFrame_Load(object sender, EventArgs e)
        {
            tab6.Image = Image.FromFile(@"../../../Data/appearance.gif");
            tab3.Image = Image.FromFile(@"../../../Data/behaviour.gif");
            tab4.Image = Image.FromFile(@"../../../Data/primitives.gif");
            UpdateTabPageStyleforOffice2016Themes();
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
       
        #endregion

        #region Windows Form Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TabControlAdvFrame));
            Syncfusion.Windows.Forms.Tools.ToolTipInfo toolTipInfo1 = new Syncfusion.Windows.Forms.Tools.ToolTipInfo();
            Syncfusion.Windows.Forms.Tools.ToolTipInfo toolTipInfo2 = new Syncfusion.Windows.Forms.Tools.ToolTipInfo();
            Syncfusion.Windows.Forms.Tools.ToolTipInfo toolTipInfo3 = new Syncfusion.Windows.Forms.Tools.ToolTipInfo();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.FormTabControl = new Syncfusion.Windows.Forms.Tools.TabControlAdv();
            this.contextMenuStripEx1 = new Syncfusion.Windows.Forms.Tools.ContextMenuStripEx();
            this.addTabToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tab6 = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.contextMenuCheck = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.checkBox16 = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.checkBox12 = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.checkBox13 = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.checkBox14 = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.checkBox26 = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.label36 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new Syncfusion.Windows.Forms.Tools.NumericUpDownExt();
            this.label25 = new System.Windows.Forms.Label();
            this.comboBox1 = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.label30 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.comboBox3 = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.comboBox2 = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.label19 = new System.Windows.Forms.Label();
            this.panelColorEdit = new Syncfusion.Windows.Forms.Tools.ButtonEdit();
            this.buttonEditChildButton4 = new Syncfusion.Windows.Forms.Tools.ButtonEditChildButton();
            this.borderColorEdit = new Syncfusion.Windows.Forms.Tools.ButtonEdit();
            this.buttonEditChildButton3 = new Syncfusion.Windows.Forms.Tools.ButtonEditChildButton();
            this.inactiveTabColorEdit = new Syncfusion.Windows.Forms.Tools.ButtonEdit();
            this.buttonEditChildButton2 = new Syncfusion.Windows.Forms.Tools.ButtonEditChildButton();
            this.activeTabColorEdit = new Syncfusion.Windows.Forms.Tools.ButtonEdit();
            this.buttonEditChildButton1 = new Syncfusion.Windows.Forms.Tools.ButtonEditChildButton();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.checkBox17 = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.checkBox11 = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.checkBox10 = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.label6 = new System.Windows.Forms.Label();
            this.tab3 = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.gradientPanel3 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            this.BehaviorTabControl = new Syncfusion.Windows.Forms.Tools.TabControlAdv();
            this.tabPageAdv5 = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.tabPageAdv12 = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.tabPageAdv13 = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.tabPageAdv1 = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.tabPageAdv11 = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.tabPageAdv2 = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.tabPageAdv9 = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.tabPageAdv10 = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.tabPageAdv6 = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.tabPageAdv8 = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.checkBox15 = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.checkBox25 = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.checkBox21 = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.label27 = new System.Windows.Forms.Label();
            this.checkBox24 = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.checkBox23 = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.checkBox22 = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.checkBox20 = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.label10 = new System.Windows.Forms.Label();
            this.checkBox19 = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.checkBox18 = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.tab4 = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.gradientPanel4 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            this.PrimitivesTabControl = new Syncfusion.Windows.Forms.Tools.TabControlAdv();
            this.tabPageAdv7 = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.label35 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.checkBox9 = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.checkBox8 = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.checkBox7 = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.checkBox6 = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.checkBox5 = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.checkBox4 = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.checkBox3 = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.checkBox2 = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.checkBox1 = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.tabPageAdv3 = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.tabPageAdv4 = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.gradientPanel1 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            this.label40 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.superToolTip1 = new Syncfusion.Windows.Forms.Tools.SuperToolTip(this);
            this.gradientPanel2 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            ((System.ComponentModel.ISupportInitialize)(this.FormTabControl)).BeginInit();
            this.FormTabControl.SuspendLayout();
            this.contextMenuStripEx1.SuspendLayout();
            this.tab6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contextMenuCheck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox26)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelColorEdit)).BeginInit();
            this.panelColorEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.borderColorEdit)).BeginInit();
            this.borderColorEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inactiveTabColorEdit)).BeginInit();
            this.inactiveTabColorEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.activeTabColorEdit)).BeginInit();
            this.activeTabColorEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox10)).BeginInit();
            this.tab3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel3)).BeginInit();
            this.gradientPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BehaviorTabControl)).BeginInit();
            this.BehaviorTabControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox25)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox24)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox23)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox22)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox20)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox19)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox18)).BeginInit();
            this.tab4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel4)).BeginInit();
            this.gradientPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PrimitivesTabControl)).BeginInit();
            this.PrimitivesTabControl.SuspendLayout();
            this.tabPageAdv7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel1)).BeginInit();
            this.gradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel2)).BeginInit();
            this.gradientPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "user_24.png");
            this.imageList.Images.SetKeyName(1, "clip_24.png");
            this.imageList.Images.SetKeyName(2, "sphere_24.png");
            this.imageList.Images.SetKeyName(3, "ellipse_24_hot.png");
            this.imageList.Images.SetKeyName(4, "mergedfield_icon_16.png");
            this.imageList.Images.SetKeyName(5, "group_icon_16.png");
            this.imageList.Images.SetKeyName(6, "primitives.gif");
            this.imageList.Images.SetKeyName(7, "apperance.gif");
            this.imageList.Images.SetKeyName(8, "behaviour.gif");
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(192, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "VS 2005 Style";
            // 
            // FormTabControl
            // 
            this.FormTabControl.AdjustTopGap = 10;
            this.FormTabControl.BeforeTouchSize = new System.Drawing.Size(966, 509);
            this.FormTabControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FormTabControl.ContextMenuStrip = this.contextMenuStripEx1;
            this.FormTabControl.Controls.Add(this.tab6);
            this.FormTabControl.Controls.Add(this.tab3);
            this.FormTabControl.Controls.Add(this.tab4);
            this.FormTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FormTabControl.FixedSingleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(178)))), ((int)(((byte)(227)))));
            this.FormTabControl.FocusOnTabClick = false;
            this.FormTabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormTabControl.HotTrack = true;
            this.FormTabControl.ImageList = this.imageList;
            this.FormTabControl.ImageOffset = 10;
            this.FormTabControl.LevelTextAndImage = true;
            this.FormTabControl.Location = new System.Drawing.Point(0, 0);
            this.FormTabControl.Name = "FormTabControl";
            this.FormTabControl.ShowSuperToolTips = true;
            this.FormTabControl.ShowToolTips = true;
            this.FormTabControl.Size = new System.Drawing.Size(966, 509);
            this.FormTabControl.TabIndex = 14;
            this.FormTabControl.TabStyle = typeof(Syncfusion.Windows.Forms.Tools.TabRendererOffice2016Colorful);
            this.FormTabControl.UserMoveTabs = true;
            this.FormTabControl.SelectedIndexChanged += new System.EventHandler(this.FormTabControl_SelectedIndexChanged);
            this.FormTabControl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormTabControl_MouseDown);
            // 
            // contextMenuStripEx1
            // 
            this.contextMenuStripEx1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addTabToolStripMenuItem});
            this.contextMenuStripEx1.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218)))));
            this.contextMenuStripEx1.Name = "contextMenuStripEx1";
            this.contextMenuStripEx1.Size = new System.Drawing.Size(120, 53);
            this.contextMenuStripEx1.Style = Syncfusion.Windows.Forms.Tools.ContextMenuStripEx.ContextMenuStyle.Default;
            this.contextMenuStripEx1.Text = "Options";
            this.contextMenuStripEx1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStripEx1_Opening);
            // 
            // addTabToolStripMenuItem
            // 
            this.addTabToolStripMenuItem.Name = "addTabToolStripMenuItem";
            this.addTabToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.addTabToolStripMenuItem.Text = "Add Tab";
            this.addTabToolStripMenuItem.Click += new System.EventHandler(this.addTabToolStripMenuItem_Click);
            // 
            // tab6
            // 
            this.tab6.BackColor = System.Drawing.Color.White;
            this.tab6.Controls.Add(this.contextMenuCheck);
            this.tab6.Controls.Add(this.checkBox16);
            this.tab6.Controls.Add(this.checkBox12);
            this.tab6.Controls.Add(this.checkBox13);
            this.tab6.Controls.Add(this.checkBox14);
            this.tab6.Controls.Add(this.checkBox26);
            this.tab6.Controls.Add(this.label36);
            this.tab6.Controls.Add(this.numericUpDown1);
            this.tab6.Controls.Add(this.label25);
            this.tab6.Controls.Add(this.comboBox1);
            this.tab6.Controls.Add(this.label30);
            this.tab6.Controls.Add(this.label29);
            this.tab6.Controls.Add(this.label28);
            this.tab6.Controls.Add(this.comboBox3);
            this.tab6.Controls.Add(this.comboBox2);
            this.tab6.Controls.Add(this.label19);
            this.tab6.Controls.Add(this.panelColorEdit);
            this.tab6.Controls.Add(this.borderColorEdit);
            this.tab6.Controls.Add(this.inactiveTabColorEdit);
            this.tab6.Controls.Add(this.activeTabColorEdit);
            this.tab6.Controls.Add(this.label17);
            this.tab6.Controls.Add(this.label16);
            this.tab6.Controls.Add(this.label18);
            this.tab6.Controls.Add(this.label15);
            this.tab6.Controls.Add(this.label5);
            this.tab6.Controls.Add(this.checkBox17);
            this.tab6.Controls.Add(this.checkBox11);
            this.tab6.Controls.Add(this.checkBox10);
            this.tab6.Controls.Add(this.label6);
            this.tab6.Image = null;
            this.tab6.ImageIndex = 0;
            this.tab6.ImageSize = new System.Drawing.Size(16, 16);
            this.tab6.Location = new System.Drawing.Point(1, 43);
            this.tab6.Name = "tab6";
            this.tab6.ShowCloseButton = true;
            this.tab6.Size = new System.Drawing.Size(964, 465);
            toolTipInfo1.Body.Size = new System.Drawing.Size(20, 20);
            toolTipInfo1.Footer.Size = new System.Drawing.Size(20, 20);
            toolTipInfo1.Header.Size = new System.Drawing.Size(20, 20);
            toolTipInfo1.Header.Text = "Appearance";
            this.tab6.SuperTooltip = toolTipInfo1;
            this.tab6.TabFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.tab6.TabIndex = 7;
            this.tab6.Text = "Appearance";
            this.tab6.ThemesEnabled = false;
            // 
            // contextMenuCheck
            // 
            this.contextMenuCheck.BeforeTouchSize = new System.Drawing.Size(150, 21);
            this.contextMenuCheck.DrawFocusRectangle = false;
            this.contextMenuCheck.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contextMenuCheck.Location = new System.Drawing.Point(57, 124);
            this.contextMenuCheck.MetroColor = System.Drawing.Color.Gray;
            this.contextMenuCheck.Name = "contextMenuCheck";
            this.contextMenuCheck.Size = new System.Drawing.Size(171, 17);
            this.contextMenuCheck.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.contextMenuCheck.TabIndex = 37;
            this.contextMenuCheck.Tag = "contextmenu";
            this.contextMenuCheck.Text = "Show Custom Context Menu";
            this.contextMenuCheck.ThemesEnabled = false;
            this.contextMenuCheck.CheckStateChanged += new System.EventHandler(this.contextMenuCheck_CheckStateChanged);
            this.contextMenuCheck.CheckedChanged += new System.EventHandler(this.Properties_CheckChanged);
            // 
            // checkBox16
            // 
            this.checkBox16.BeforeTouchSize = new System.Drawing.Size(150, 21);
            this.checkBox16.DrawFocusRectangle = false;
            this.checkBox16.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox16.Location = new System.Drawing.Point(701, 123);
            this.checkBox16.MetroColor = System.Drawing.Color.Gray;
            this.checkBox16.Name = "checkBox16";
            this.checkBox16.Size = new System.Drawing.Size(122, 17);
            this.checkBox16.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.checkBox16.TabIndex = 39;
            this.checkBox16.Tag = "persist";
            this.checkBox16.Text = "Persist Tab State";
            this.checkBox16.ThemesEnabled = false;
            this.checkBox16.CheckStateChanged += new System.EventHandler(this.checkBox16_CheckStateChanged);
            this.checkBox16.CheckedChanged += new System.EventHandler(this.Properties_CheckChanged);
            // 
            // checkBox12
            // 
            this.checkBox12.BeforeTouchSize = new System.Drawing.Size(150, 21);
            this.checkBox12.DrawFocusRectangle = false;
            this.checkBox12.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox12.Location = new System.Drawing.Point(377, 124);
            this.checkBox12.MetroColor = System.Drawing.Color.Gray;
            this.checkBox12.Name = "checkBox12";
            this.checkBox12.Size = new System.Drawing.Size(160, 18);
            this.checkBox12.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.checkBox12.TabIndex = 7;
            this.checkBox12.Tag = "rotatetext";
            this.checkBox12.Text = "Rotate Text When Vertical";
            this.checkBox12.ThemesEnabled = false;
            this.checkBox12.CheckStateChanged += new System.EventHandler(this.checkBox12_CheckStateChanged);
            this.checkBox12.CheckedChanged += new System.EventHandler(this.Properties_CheckChanged);
            // 
            // checkBox13
            // 
            this.checkBox13.BeforeTouchSize = new System.Drawing.Size(150, 21);
            this.checkBox13.Checked = true;
            this.checkBox13.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox13.DrawFocusRectangle = false;
            this.checkBox13.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox13.Location = new System.Drawing.Point(589, 124);
            this.checkBox13.MetroColor = System.Drawing.Color.Gray;
            this.checkBox13.Name = "checkBox13";
            this.checkBox13.Size = new System.Drawing.Size(87, 18);
            this.checkBox13.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.checkBox13.TabIndex = 8;
            this.checkBox13.Tag = "scrolls";
            this.checkBox13.Text = "Show Scroll";
            this.checkBox13.ThemesEnabled = false;
            this.checkBox13.CheckStateChanged += new System.EventHandler(this.checkBox13_CheckStateChanged);
            this.checkBox13.CheckedChanged += new System.EventHandler(this.Properties_CheckChanged);
            // 
            // checkBox14
            // 
            this.checkBox14.BeforeTouchSize = new System.Drawing.Size(150, 21);
            this.checkBox14.DrawFocusRectangle = false;
            this.checkBox14.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox14.Location = new System.Drawing.Point(247, 123);
            this.checkBox14.MetroColor = System.Drawing.Color.Gray;
            this.checkBox14.Name = "checkBox14";
            this.checkBox14.Size = new System.Drawing.Size(99, 18);
            this.checkBox14.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.checkBox14.TabIndex = 9;
            this.checkBox14.Tag = "themes";
            this.checkBox14.Text = "Enable Themes";
            this.checkBox14.ThemesEnabled = false;
            this.checkBox14.CheckStateChanged += new System.EventHandler(this.checkBox14_CheckStateChanged);
            this.checkBox14.CheckedChanged += new System.EventHandler(this.Properties_CheckChanged);
            // 
            // checkBox26
            // 
            this.checkBox26.BeforeTouchSize = new System.Drawing.Size(150, 21);
            this.checkBox26.DrawFocusRectangle = false;
            this.checkBox26.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox26.Location = new System.Drawing.Point(589, 200);
            this.checkBox26.MetroColor = System.Drawing.Color.Gray;
            this.checkBox26.Name = "checkBox26";
            this.checkBox26.Size = new System.Drawing.Size(177, 32);
            this.checkBox26.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.checkBox26.TabIndex = 44;
            this.checkBox26.Tag = "outsidebounds";
            this.checkBox26.Text = "Show Animated Tab Image";
            this.checkBox26.ThemesEnabled = false;
            this.checkBox26.WrapText = false;
            this.checkBox26.CheckedChanged += new System.EventHandler(this.checkBox26_CheckedChanged);
            // 
            // label36
            // 
            this.label36.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label36.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label36.Location = new System.Drawing.Point(54, 173);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(62, 24);
            this.label36.TabIndex = 42;
            this.label36.Text = "Image";
            this.label36.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.BackColor = System.Drawing.Color.White;
            this.numericUpDown1.BeforeTouchSize = new System.Drawing.Size(121, 22);
            this.numericUpDown1.BorderColor = System.Drawing.Color.Gray;
            this.numericUpDown1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDown1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.Location = new System.Drawing.Point(316, 407);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            35,
            0,
            0,
            0});
            this.numericUpDown1.MetroColor = System.Drawing.Color.Gray;
            this.numericUpDown1.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(121, 22);
            this.numericUpDown1.TabIndex = 36;
            this.numericUpDown1.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown1.VisualStyle = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(59, 407);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(52, 13);
            this.label25.TabIndex = 35;
            this.label25.Text = "Tab Style";
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.White;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.BeforeTouchSize = new System.Drawing.Size(120, 21);
            this.comboBox1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.IntegralHeight = false;
            this.comboBox1.Location = new System.Drawing.Point(116, 405);
            this.comboBox1.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(120, 21);
            this.comboBox1.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.comboBox1.TabIndex = 34;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.Location = new System.Drawing.Point(263, 410);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(49, 13);
            this.label30.TabIndex = 33;
            this.label30.Text = "Tab Gap";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.Location = new System.Drawing.Point(470, 409);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(69, 13);
            this.label29.TabIndex = 32;
            this.label29.Text = "Border Style";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.Location = new System.Drawing.Point(672, 409);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(81, 13);
            this.label28.TabIndex = 31;
            this.label28.Text = "Tab Alignment";
            // 
            // comboBox3
            // 
            this.comboBox3.BackColor = System.Drawing.Color.White;
            this.comboBox3.BeforeTouchSize = new System.Drawing.Size(103, 21);
            this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox3.Location = new System.Drawing.Point(543, 407);
            this.comboBox3.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(103, 21);
            this.comboBox3.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.comboBox3.TabIndex = 29;
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.BackColor = System.Drawing.Color.White;
            this.comboBox2.BeforeTouchSize = new System.Drawing.Size(85, 21);
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.Items.AddRange(new object[] {
            "Top",
            "Left",
            "Bottom",
            "Right"});
            this.comboBox2.ItemsImageIndexes.Add(new Syncfusion.Windows.Forms.Tools.ComboBoxAdv.ImageIndexItem(this.comboBox2, "Top"));
            this.comboBox2.ItemsImageIndexes.Add(new Syncfusion.Windows.Forms.Tools.ComboBoxAdv.ImageIndexItem(this.comboBox2, "Left"));
            this.comboBox2.ItemsImageIndexes.Add(new Syncfusion.Windows.Forms.Tools.ComboBoxAdv.ImageIndexItem(this.comboBox2, "Bottom"));
            this.comboBox2.ItemsImageIndexes.Add(new Syncfusion.Windows.Forms.Tools.ComboBoxAdv.ImageIndexItem(this.comboBox2, "Right"));
            this.comboBox2.Location = new System.Drawing.Point(756, 406);
            this.comboBox2.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(85, 21);
            this.comboBox2.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.comboBox2.TabIndex = 28;
            this.comboBox2.Text = "Top";
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label19
            // 
            this.label19.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label19.Location = new System.Drawing.Point(59, 372);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(63, 23);
            this.label19.TabIndex = 23;
            this.label19.Text = "Styles";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelColorEdit
            // 
            this.panelColorEdit.BackColor = System.Drawing.Color.White;
            this.panelColorEdit.BeforeTouchSize = new System.Drawing.Size(121, 23);
            this.panelColorEdit.Buttons.Add(this.buttonEditChildButton4);
            this.panelColorEdit.ButtonStyle = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.panelColorEdit.Controls.Add(this.buttonEditChildButton4);
            this.panelColorEdit.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelColorEdit.Location = new System.Drawing.Point(697, 312);
            this.panelColorEdit.MetroColor = System.Drawing.Color.Gray;
            this.panelColorEdit.Name = "panelColorEdit";
            this.panelColorEdit.ShowTextBox = false;
            this.panelColorEdit.Size = new System.Drawing.Size(121, 23);
            this.panelColorEdit.TabIndex = 21;
            this.panelColorEdit.UseVisualStyle = true;
            this.panelColorEdit.ButtonClicked += new Syncfusion.Windows.Forms.Tools.ButtonClickedEventHandler(this.panelColorEdit_ButtonClicked);
            // 
            // buttonEditChildButton4
            // 
            this.buttonEditChildButton4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.buttonEditChildButton4.BeforeTouchSize = new System.Drawing.Size(20, 19);
            this.buttonEditChildButton4.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.Flat;
            this.buttonEditChildButton4.ComboEditBackColor = System.Drawing.Color.White;
            this.buttonEditChildButton4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditChildButton4.ForeColor = System.Drawing.Color.White;
            this.buttonEditChildButton4.Image = null;
            this.buttonEditChildButton4.IsBackStageButton = false;
            this.buttonEditChildButton4.Name = "buttonEditChildButton4";
            this.buttonEditChildButton4.PreferredWidth = 20;
            this.buttonEditChildButton4.TabIndex = 1;
            this.buttonEditChildButton4.Text = "...";
            this.buttonEditChildButton4.UseVisualStyleBackColor = true;
            // 
            // borderColorEdit
            // 
            this.borderColorEdit.BeforeTouchSize = new System.Drawing.Size(121, 23);
            this.borderColorEdit.Buttons.Add(this.buttonEditChildButton3);
            this.borderColorEdit.ButtonStyle = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.borderColorEdit.Controls.Add(this.buttonEditChildButton3);
            this.borderColorEdit.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.borderColorEdit.Location = new System.Drawing.Point(502, 313);
            this.borderColorEdit.MetroColor = System.Drawing.Color.Gray;
            this.borderColorEdit.Name = "borderColorEdit";
            this.borderColorEdit.ShowTextBox = false;
            this.borderColorEdit.Size = new System.Drawing.Size(121, 23);
            this.borderColorEdit.TabIndex = 20;
            this.borderColorEdit.UseVisualStyle = true;
            this.borderColorEdit.ButtonClicked += new Syncfusion.Windows.Forms.Tools.ButtonClickedEventHandler(this.borderColorEdit_ButtonClicked);
            // 
            // buttonEditChildButton3
            // 
            this.buttonEditChildButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.buttonEditChildButton3.BeforeTouchSize = new System.Drawing.Size(20, 19);
            this.buttonEditChildButton3.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.Flat;
            this.buttonEditChildButton3.ComboEditBackColor = System.Drawing.SystemColors.Window;
            this.buttonEditChildButton3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditChildButton3.ForeColor = System.Drawing.Color.White;
            this.buttonEditChildButton3.Image = null;
            this.buttonEditChildButton3.IsBackStageButton = false;
            this.buttonEditChildButton3.Name = "buttonEditChildButton3";
            this.buttonEditChildButton3.PreferredWidth = 20;
            this.buttonEditChildButton3.TabIndex = 1;
            this.buttonEditChildButton3.Text = "...";
            this.buttonEditChildButton3.UseVisualStyleBackColor = true;
            // 
            // inactiveTabColorEdit
            // 
            this.inactiveTabColorEdit.BeforeTouchSize = new System.Drawing.Size(121, 23);
            this.inactiveTabColorEdit.Buttons.Add(this.buttonEditChildButton2);
            this.inactiveTabColorEdit.ButtonStyle = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.inactiveTabColorEdit.Controls.Add(this.buttonEditChildButton2);
            this.inactiveTabColorEdit.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inactiveTabColorEdit.Location = new System.Drawing.Point(277, 313);
            this.inactiveTabColorEdit.MetroColor = System.Drawing.Color.Gray;
            this.inactiveTabColorEdit.Name = "inactiveTabColorEdit";
            this.inactiveTabColorEdit.ShowTextBox = false;
            this.inactiveTabColorEdit.Size = new System.Drawing.Size(121, 23);
            this.inactiveTabColorEdit.TabIndex = 19;
            this.inactiveTabColorEdit.UseVisualStyle = true;
            this.inactiveTabColorEdit.ButtonClicked += new Syncfusion.Windows.Forms.Tools.ButtonClickedEventHandler(this.inactiveTabColorEdit_ButtonClicked);
            // 
            // buttonEditChildButton2
            // 
            this.buttonEditChildButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.buttonEditChildButton2.BeforeTouchSize = new System.Drawing.Size(20, 19);
            this.buttonEditChildButton2.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.Flat;
            this.buttonEditChildButton2.ComboEditBackColor = System.Drawing.SystemColors.Window;
            this.buttonEditChildButton2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditChildButton2.ForeColor = System.Drawing.Color.White;
            this.buttonEditChildButton2.Image = null;
            this.buttonEditChildButton2.IsBackStageButton = false;
            this.buttonEditChildButton2.Name = "buttonEditChildButton2";
            this.buttonEditChildButton2.PreferredWidth = 20;
            this.buttonEditChildButton2.TabIndex = 1;
            this.buttonEditChildButton2.Text = "...";
            this.buttonEditChildButton2.UseVisualStyleBackColor = true;
            // 
            // activeTabColorEdit
            // 
            this.activeTabColorEdit.BeforeTouchSize = new System.Drawing.Size(121, 23);
            this.activeTabColorEdit.Buttons.Add(this.buttonEditChildButton1);
            this.activeTabColorEdit.ButtonStyle = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.activeTabColorEdit.Controls.Add(this.buttonEditChildButton1);
            this.activeTabColorEdit.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.activeTabColorEdit.Location = new System.Drawing.Point(58, 312);
            this.activeTabColorEdit.MetroColor = System.Drawing.Color.Gray;
            this.activeTabColorEdit.Name = "activeTabColorEdit";
            this.activeTabColorEdit.ShowTextBox = false;
            this.activeTabColorEdit.Size = new System.Drawing.Size(121, 23);
            this.activeTabColorEdit.TabIndex = 18;
            this.activeTabColorEdit.UseVisualStyle = true;
            this.activeTabColorEdit.ButtonClicked += new Syncfusion.Windows.Forms.Tools.ButtonClickedEventHandler(this.buttonEdit1_ButtonClicked);
            // 
            // buttonEditChildButton1
            // 
            this.buttonEditChildButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.buttonEditChildButton1.BeforeTouchSize = new System.Drawing.Size(20, 19);
            this.buttonEditChildButton1.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.Flat;
            this.buttonEditChildButton1.ComboEditBackColor = System.Drawing.SystemColors.Window;
            this.buttonEditChildButton1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditChildButton1.ForeColor = System.Drawing.Color.White;
            this.buttonEditChildButton1.Image = null;
            this.buttonEditChildButton1.IsBackStageButton = false;
            this.buttonEditChildButton1.Name = "buttonEditChildButton1";
            this.buttonEditChildButton1.PreferredWidth = 20;
            this.buttonEditChildButton1.TabIndex = 1;
            this.buttonEditChildButton1.Text = "...";
            this.buttonEditChildButton1.UseVisualStyleBackColor = true;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(694, 295);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(114, 13);
            this.label17.TabIndex = 17;
            this.label17.Text = "Tab Panel Back Color";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(499, 295);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(73, 13);
            this.label16.TabIndex = 16;
            this.label16.Text = "Border Color";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(274, 296);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(98, 13);
            this.label18.TabIndex = 15;
            this.label18.Text = "Inactive Tab Color";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(55, 295);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(89, 13);
            this.label15.TabIndex = 15;
            this.label15.Text = "Active Tab Color";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label5.Location = new System.Drawing.Point(55, 262);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 24);
            this.label5.TabIndex = 14;
            this.label5.Text = "Color Options";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // checkBox17
            // 
            this.checkBox17.BeforeTouchSize = new System.Drawing.Size(150, 21);
            this.checkBox17.Checked = true;
            this.checkBox17.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox17.DrawFocusRectangle = false;
            this.checkBox17.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox17.Location = new System.Drawing.Point(57, 200);
            this.checkBox17.MetroColor = System.Drawing.Color.Gray;
            this.checkBox17.Name = "checkBox17";
            this.checkBox17.Size = new System.Drawing.Size(178, 30);
            this.checkBox17.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.checkBox17.TabIndex = 12;
            this.checkBox17.Tag = "outsidebounds";
            this.checkBox17.Text = "Image Outside Text Bounds";
            this.checkBox17.ThemesEnabled = false;
            this.checkBox17.WrapText = false;
            this.checkBox17.CheckedChanged += new System.EventHandler(this.Properties_CheckChanged);
            // 
            // checkBox11
            // 
            this.checkBox11.BeforeTouchSize = new System.Drawing.Size(150, 21);
            this.checkBox11.Checked = true;
            this.checkBox11.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox11.DrawFocusRectangle = false;
            this.checkBox11.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox11.Location = new System.Drawing.Point(247, 200);
            this.checkBox11.MetroColor = System.Drawing.Color.Gray;
            this.checkBox11.Name = "checkBox11";
            this.checkBox11.Size = new System.Drawing.Size(119, 32);
            this.checkBox11.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.checkBox11.TabIndex = 6;
            this.checkBox11.Tag = "imagealign";
            this.checkBox11.Text = "Image Left Align";
            this.checkBox11.ThemesEnabled = false;
            this.checkBox11.WrapText = false;
            this.checkBox11.CheckedChanged += new System.EventHandler(this.Properties_CheckChanged);
            // 
            // checkBox10
            // 
            this.checkBox10.BeforeTouchSize = new System.Drawing.Size(150, 21);
            this.checkBox10.DrawFocusRectangle = false;
            this.checkBox10.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox10.Location = new System.Drawing.Point(377, 200);
            this.checkBox10.MetroColor = System.Drawing.Color.Gray;
            this.checkBox10.Name = "checkBox10";
            this.checkBox10.Size = new System.Drawing.Size(171, 32);
            this.checkBox10.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.checkBox10.TabIndex = 5;
            this.checkBox10.Tag = "inactiveimage";
            this.checkBox10.Text = "Disable Inactive Page Image";
            this.checkBox10.ThemesEnabled = false;
            this.checkBox10.WrapText = false;
            this.checkBox10.CheckStateChanged += new System.EventHandler(this.checkBox10_CheckStateChanged);
            this.checkBox10.CheckedChanged += new System.EventHandler(this.Properties_CheckChanged);
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label6.Location = new System.Drawing.Point(55, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 24);
            this.label6.TabIndex = 4;
            this.label6.Text = "Properties";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tab3
            // 
            this.tab3.BackColor = System.Drawing.Color.White;
            this.tab3.Controls.Add(this.gradientPanel3);
            this.tab3.Controls.Add(this.checkBox15);
            this.tab3.Controls.Add(this.checkBox25);
            this.tab3.Controls.Add(this.checkBox21);
            this.tab3.Controls.Add(this.label27);
            this.tab3.Controls.Add(this.checkBox24);
            this.tab3.Controls.Add(this.listBox1);
            this.tab3.Controls.Add(this.checkBox23);
            this.tab3.Controls.Add(this.checkBox22);
            this.tab3.Controls.Add(this.checkBox20);
            this.tab3.Controls.Add(this.label10);
            this.tab3.Controls.Add(this.checkBox19);
            this.tab3.Controls.Add(this.checkBox18);
            this.tab3.Image = null;
            this.tab3.ImageIndex = 1;
            this.tab3.ImageSize = new System.Drawing.Size(16, 16);
            this.tab3.Location = new System.Drawing.Point(1, 43);
            this.tab3.Name = "tab3";
            this.tab3.ShowCloseButton = true;
            this.tab3.Size = new System.Drawing.Size(964, 465);
            toolTipInfo2.Body.Size = new System.Drawing.Size(20, 20);
            toolTipInfo2.Footer.Size = new System.Drawing.Size(20, 20);
            toolTipInfo2.Header.Size = new System.Drawing.Size(20, 20);
            toolTipInfo2.Header.Text = "Behavior Tab";
            this.tab3.SuperTooltip = toolTipInfo2;
            this.tab3.TabFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.tab3.TabIndex = 4;
            this.tab3.Text = "Behavior";
            this.tab3.ThemesEnabled = false;
            // 
            // gradientPanel3
            // 
            this.gradientPanel3.BorderColor = System.Drawing.Color.Silver;
            this.gradientPanel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gradientPanel3.Controls.Add(this.BehaviorTabControl);
            this.gradientPanel3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gradientPanel3.Location = new System.Drawing.Point(103, 57);
            this.gradientPanel3.Name = "gradientPanel3";
            this.gradientPanel3.Size = new System.Drawing.Size(721, 80);
            this.gradientPanel3.TabIndex = 49;
            // 
            // BehaviorTabControl
            // 
            this.BehaviorTabControl.ActiveTabColor = System.Drawing.Color.Gray;
            this.BehaviorTabControl.BackColor = System.Drawing.Color.White;
            this.BehaviorTabControl.BeforeTouchSize = new System.Drawing.Size(719, 78);
            this.BehaviorTabControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BehaviorTabControl.BorderVisible = true;
            this.BehaviorTabControl.BorderWidth = 1;
            this.BehaviorTabControl.Controls.Add(this.tabPageAdv5);
            this.BehaviorTabControl.Controls.Add(this.tabPageAdv12);
            this.BehaviorTabControl.Controls.Add(this.tabPageAdv13);
            this.BehaviorTabControl.Controls.Add(this.tabPageAdv1);
            this.BehaviorTabControl.Controls.Add(this.tabPageAdv11);
            this.BehaviorTabControl.Controls.Add(this.tabPageAdv2);
            this.BehaviorTabControl.Controls.Add(this.tabPageAdv9);
            this.BehaviorTabControl.Controls.Add(this.tabPageAdv10);
            this.BehaviorTabControl.Controls.Add(this.tabPageAdv6);
            this.BehaviorTabControl.Controls.Add(this.tabPageAdv8);
            this.BehaviorTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BehaviorTabControl.FocusOnTabClick = false;
            this.BehaviorTabControl.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BehaviorTabControl.HotTrack = true;
            this.BehaviorTabControl.InactiveTabColor = System.Drawing.Color.White;
            this.BehaviorTabControl.Location = new System.Drawing.Point(0, 0);
            this.BehaviorTabControl.Name = "BehaviorTabControl";
            this.BehaviorTabControl.ShowTabCloseButton = true;
            this.BehaviorTabControl.ShowToolTips = true;
            this.BehaviorTabControl.Size = new System.Drawing.Size(719, 78);
            this.BehaviorTabControl.TabIndex = 3;
            this.BehaviorTabControl.TabStyle = typeof(Syncfusion.Windows.Forms.Tools.TabRendererMetro);
            this.BehaviorTabControl.VSLikeScrollButton = true;
            this.BehaviorTabControl.SelectedIndexChanged += new System.EventHandler(this.BehaviorTabControl_SelectedIndexChanged);
            this.BehaviorTabControl.SelectedIndexChanging += new Syncfusion.Windows.Forms.Tools.SelectedIndexChangingEventHandler(this.BehaviorTabControl_SelectedIndexChanging);
            this.BehaviorTabControl.LabelEditTextChanged += new System.EventHandler(this.BehaviorTabControl_LabelEditTextChanged);
            this.BehaviorTabControl.LabelEditChanged += new System.EventHandler(this.BehaviorTabControl_LabelEditChanged);
            this.BehaviorTabControl.BeforeEdit += new Syncfusion.Windows.Forms.Tools.EditEventHandler(this.BehaviorTabControl_BeforeEdit);
            this.BehaviorTabControl.AfterEdit += new Syncfusion.Windows.Forms.Tools.EditEventHandler(this.BehaviorTabControl_AfterEdit);
            // 
            // tabPageAdv5
            // 
            this.tabPageAdv5.BackColor = System.Drawing.Color.White;
            this.tabPageAdv5.Image = null;
            this.tabPageAdv5.ImageSize = new System.Drawing.Size(16, 16);
            this.tabPageAdv5.Location = new System.Drawing.Point(1, 23);
            this.tabPageAdv5.Name = "tabPageAdv5";
            this.tabPageAdv5.ShowCloseButton = true;
            this.tabPageAdv5.Size = new System.Drawing.Size(717, 54);
            this.tabPageAdv5.TabIndex = 1;
            this.tabPageAdv5.Text = "Home Page";
            this.tabPageAdv5.ThemesEnabled = false;
            this.tabPageAdv5.ToolTipText = "Home Page";
            // 
            // tabPageAdv12
            // 
            this.tabPageAdv12.BackColor = System.Drawing.Color.White;
            this.tabPageAdv12.Image = null;
            this.tabPageAdv12.ImageSize = new System.Drawing.Size(16, 16);
            this.tabPageAdv12.Location = new System.Drawing.Point(1, 23);
            this.tabPageAdv12.Name = "tabPageAdv12";
            this.tabPageAdv12.ShowCloseButton = true;
            this.tabPageAdv12.Size = new System.Drawing.Size(717, 54);
            this.tabPageAdv12.TabIndex = 8;
            this.tabPageAdv12.Text = "Remote";
            this.tabPageAdv12.ThemesEnabled = false;
            this.tabPageAdv12.ToolTipText = "Remote";
            // 
            // tabPageAdv13
            // 
            this.tabPageAdv13.BackColor = System.Drawing.Color.White;
            this.tabPageAdv13.Image = null;
            this.tabPageAdv13.ImageSize = new System.Drawing.Size(16, 16);
            this.tabPageAdv13.Location = new System.Drawing.Point(1, 23);
            this.tabPageAdv13.Name = "tabPageAdv13";
            this.tabPageAdv13.ShowCloseButton = true;
            this.tabPageAdv13.Size = new System.Drawing.Size(717, 54);
            this.tabPageAdv13.TabIndex = 9;
            this.tabPageAdv13.Text = "Updates";
            this.tabPageAdv13.ThemesEnabled = false;
            this.tabPageAdv13.ToolTipText = "Updates";
            // 
            // tabPageAdv1
            // 
            this.tabPageAdv1.BackColor = System.Drawing.Color.White;
            this.tabPageAdv1.Image = null;
            this.tabPageAdv1.ImageSize = new System.Drawing.Size(16, 16);
            this.tabPageAdv1.Location = new System.Drawing.Point(1, 23);
            this.tabPageAdv1.Name = "tabPageAdv1";
            this.tabPageAdv1.ShowCloseButton = true;
            this.tabPageAdv1.Size = new System.Drawing.Size(717, 54);
            this.tabPageAdv1.TabIndex = 3;
            this.tabPageAdv1.Text = "Options";
            this.tabPageAdv1.ThemesEnabled = false;
            this.tabPageAdv1.ToolTipText = "Options";
            // 
            // tabPageAdv11
            // 
            this.tabPageAdv11.BackColor = System.Drawing.Color.White;
            this.tabPageAdv11.Image = null;
            this.tabPageAdv11.ImageSize = new System.Drawing.Size(16, 16);
            this.tabPageAdv11.Location = new System.Drawing.Point(1, 23);
            this.tabPageAdv11.Name = "tabPageAdv11";
            this.tabPageAdv11.ShowCloseButton = true;
            this.tabPageAdv11.Size = new System.Drawing.Size(717, 54);
            this.tabPageAdv11.TabIndex = 7;
            this.tabPageAdv11.Text = "More Options..";
            this.tabPageAdv11.ThemesEnabled = false;
            this.tabPageAdv11.ToolTipText = "More Options..";
            // 
            // tabPageAdv2
            // 
            this.tabPageAdv2.BackColor = System.Drawing.Color.White;
            this.tabPageAdv2.Image = null;
            this.tabPageAdv2.ImageSize = new System.Drawing.Size(16, 16);
            this.tabPageAdv2.Location = new System.Drawing.Point(1, 23);
            this.tabPageAdv2.Name = "tabPageAdv2";
            this.tabPageAdv2.ShowCloseButton = true;
            this.tabPageAdv2.Size = new System.Drawing.Size(717, 54);
            this.tabPageAdv2.TabIndex = 4;
            this.tabPageAdv2.Text = "Format Text";
            this.tabPageAdv2.ThemesEnabled = false;
            this.tabPageAdv2.ToolTipText = "Format Text";
            // 
            // tabPageAdv9
            // 
            this.tabPageAdv9.BackColor = System.Drawing.Color.White;
            this.tabPageAdv9.Image = null;
            this.tabPageAdv9.ImageSize = new System.Drawing.Size(16, 16);
            this.tabPageAdv9.Location = new System.Drawing.Point(1, 23);
            this.tabPageAdv9.Name = "tabPageAdv9";
            this.tabPageAdv9.ShowCloseButton = true;
            this.tabPageAdv9.Size = new System.Drawing.Size(717, 54);
            this.tabPageAdv9.TabIndex = 5;
            this.tabPageAdv9.Text = "Message";
            this.tabPageAdv9.ThemesEnabled = false;
            this.tabPageAdv9.ToolTipText = "Message";
            // 
            // tabPageAdv10
            // 
            this.tabPageAdv10.BackColor = System.Drawing.Color.White;
            this.tabPageAdv10.Image = null;
            this.tabPageAdv10.ImageSize = new System.Drawing.Size(16, 16);
            this.tabPageAdv10.Location = new System.Drawing.Point(1, 23);
            this.tabPageAdv10.Name = "tabPageAdv10";
            this.tabPageAdv10.ShowCloseButton = true;
            this.tabPageAdv10.Size = new System.Drawing.Size(717, 54);
            this.tabPageAdv10.TabIndex = 6;
            this.tabPageAdv10.Text = "Find and Replace";
            this.tabPageAdv10.ThemesEnabled = false;
            this.tabPageAdv10.ToolTipText = "Find and Replace";
            // 
            // tabPageAdv6
            // 
            this.tabPageAdv6.BackColor = System.Drawing.Color.White;
            this.tabPageAdv6.Image = null;
            this.tabPageAdv6.ImageSize = new System.Drawing.Size(16, 16);
            this.tabPageAdv6.Location = new System.Drawing.Point(1, 23);
            this.tabPageAdv6.Name = "tabPageAdv6";
            this.tabPageAdv6.ShowCloseButton = true;
            this.tabPageAdv6.Size = new System.Drawing.Size(717, 54);
            this.tabPageAdv6.TabIndex = 1;
            this.tabPageAdv6.Text = "Insert Item";
            this.tabPageAdv6.ThemesEnabled = false;
            this.tabPageAdv6.ToolTipText = "Insert Item";
            // 
            // tabPageAdv8
            // 
            this.tabPageAdv8.BackColor = System.Drawing.Color.White;
            this.tabPageAdv8.Image = null;
            this.tabPageAdv8.ImageSize = new System.Drawing.Size(16, 16);
            this.tabPageAdv8.Location = new System.Drawing.Point(1, 23);
            this.tabPageAdv8.Name = "tabPageAdv8";
            this.tabPageAdv8.ShowCloseButton = true;
            this.tabPageAdv8.Size = new System.Drawing.Size(717, 54);
            this.tabPageAdv8.TabIndex = 2;
            this.tabPageAdv8.Text = "View Tabs";
            this.tabPageAdv8.ThemesEnabled = false;
            this.tabPageAdv8.ToolTipText = "View Tabs";
            // 
            // checkBox15
            // 
            this.checkBox15.BeforeTouchSize = new System.Drawing.Size(150, 21);
            this.checkBox15.DrawFocusRectangle = false;
            this.checkBox15.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox15.Location = new System.Drawing.Point(602, 223);
            this.checkBox15.MetroColor = System.Drawing.Color.Gray;
            this.checkBox15.Name = "checkBox15";
            this.checkBox15.Size = new System.Drawing.Size(187, 32);
            this.checkBox15.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.checkBox15.TabIndex = 46;
            this.checkBox15.Tag = "outsidebounds";
            this.checkBox15.Text = "TabCloseButton for Active Tab";
            this.checkBox15.ThemesEnabled = false;
            this.checkBox15.WrapText = false;
            this.checkBox15.CheckedChanged += new System.EventHandler(this.checkBox15_CheckedChanged);
            // 
            // checkBox25
            // 
            this.checkBox25.BeforeTouchSize = new System.Drawing.Size(150, 21);
            this.checkBox25.Checked = true;
            this.checkBox25.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox25.DrawFocusRectangle = false;
            this.checkBox25.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox25.Location = new System.Drawing.Point(363, 184);
            this.checkBox25.MetroColor = System.Drawing.Color.Gray;
            this.checkBox25.Name = "checkBox25";
            this.checkBox25.Size = new System.Drawing.Size(153, 18);
            this.checkBox25.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.checkBox25.TabIndex = 48;
            this.checkBox25.Tag = "themes";
            this.checkBox25.Text = "Show Tab Close Button";
            this.checkBox25.ThemesEnabled = false;
            this.checkBox25.CheckedChanged += new System.EventHandler(this.checkBox25_CheckedChanged);
            // 
            // checkBox21
            // 
            this.checkBox21.BeforeTouchSize = new System.Drawing.Size(150, 21);
            this.checkBox21.Checked = true;
            this.checkBox21.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox21.DrawFocusRectangle = false;
            this.checkBox21.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox21.Location = new System.Drawing.Point(363, 223);
            this.checkBox21.MetroColor = System.Drawing.Color.Gray;
            this.checkBox21.Name = "checkBox21";
            this.checkBox21.Size = new System.Drawing.Size(200, 32);
            this.checkBox21.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.checkBox21.TabIndex = 13;
            this.checkBox21.Tag = "frontrow";
            this.checkBox21.Text = "Keep Selected Tab In Front Row";
            this.checkBox21.ThemesEnabled = false;
            this.checkBox21.WrapText = false;
            this.checkBox21.CheckedChanged += new System.EventHandler(this.Behavior_CheckChanged);
            // 
            // label27
            // 
            this.label27.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label27.Location = new System.Drawing.Point(51, 18);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(76, 24);
            this.label27.TabIndex = 34;
            this.label27.Text = "Behavior";
            this.label27.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // checkBox24
            // 
            this.checkBox24.BeforeTouchSize = new System.Drawing.Size(150, 21);
            this.checkBox24.DrawFocusRectangle = false;
            this.checkBox24.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox24.Location = new System.Drawing.Point(216, 229);
            this.checkBox24.MetroColor = System.Drawing.Color.Gray;
            this.checkBox24.Name = "checkBox24";
            this.checkBox24.Size = new System.Drawing.Size(103, 18);
            this.checkBox24.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.checkBox24.TabIndex = 16;
            this.checkBox24.Tag = "labeledit";
            this.checkBox24.Text = "Label Edit";
            this.checkBox24.ThemesEnabled = false;
            this.checkBox24.CheckedChanged += new System.EventHandler(this.Behavior_CheckChanged);
            // 
            // listBox1
            // 
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBox1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(103, 306);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(721, 80);
            this.listBox1.TabIndex = 32;
            // 
            // checkBox23
            // 
            this.checkBox23.BeforeTouchSize = new System.Drawing.Size(150, 21);
            this.checkBox23.DrawFocusRectangle = false;
            this.checkBox23.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox23.Location = new System.Drawing.Point(54, 229);
            this.checkBox23.MetroColor = System.Drawing.Color.Gray;
            this.checkBox23.Name = "checkBox23";
            this.checkBox23.Size = new System.Drawing.Size(78, 18);
            this.checkBox23.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.checkBox23.TabIndex = 15;
            this.checkBox23.Tag = "movetabs";
            this.checkBox23.Text = "Move Tabs";
            this.checkBox23.ThemesEnabled = false;
            this.checkBox23.CheckedChanged += new System.EventHandler(this.Behavior_CheckChanged);
            // 
            // checkBox22
            // 
            this.checkBox22.BeforeTouchSize = new System.Drawing.Size(150, 21);
            this.checkBox22.Checked = true;
            this.checkBox22.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox22.DrawFocusRectangle = false;
            this.checkBox22.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox22.Location = new System.Drawing.Point(602, 184);
            this.checkBox22.MetroColor = System.Drawing.Color.Gray;
            this.checkBox22.Name = "checkBox22";
            this.checkBox22.Size = new System.Drawing.Size(97, 18);
            this.checkBox22.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.checkBox22.TabIndex = 14;
            this.checkBox22.Tag = "tooltips";
            this.checkBox22.Text = "Show ToolTips";
            this.checkBox22.ThemesEnabled = false;
            this.checkBox22.CheckedChanged += new System.EventHandler(this.Behavior_CheckChanged);
            // 
            // checkBox20
            // 
            this.checkBox20.BeforeTouchSize = new System.Drawing.Size(150, 21);
            this.checkBox20.DrawFocusRectangle = false;
            this.checkBox20.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox20.Location = new System.Drawing.Point(756, 184);
            this.checkBox20.MetroColor = System.Drawing.Color.Gray;
            this.checkBox20.Name = "checkBox20";
            this.checkBox20.Size = new System.Drawing.Size(103, 18);
            this.checkBox20.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.checkBox20.TabIndex = 12;
            this.checkBox20.Tag = "multiline";
            this.checkBox20.Text = "Multiline";
            this.checkBox20.ThemesEnabled = false;
            this.checkBox20.CheckedChanged += new System.EventHandler(this.Behavior_CheckChanged);
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label10.Location = new System.Drawing.Point(51, 279);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 24);
            this.label10.TabIndex = 31;
            this.label10.Text = "Events";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // checkBox19
            // 
            this.checkBox19.BeforeTouchSize = new System.Drawing.Size(150, 21);
            this.checkBox19.Checked = true;
            this.checkBox19.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox19.DrawFocusRectangle = false;
            this.checkBox19.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox19.Location = new System.Drawing.Point(216, 184);
            this.checkBox19.MetroColor = System.Drawing.Color.Gray;
            this.checkBox19.Name = "checkBox19";
            this.checkBox19.Size = new System.Drawing.Size(72, 18);
            this.checkBox19.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.checkBox19.TabIndex = 11;
            this.checkBox19.Tag = "hottrack";
            this.checkBox19.Text = "Hot Track";
            this.checkBox19.ThemesEnabled = false;
            this.checkBox19.CheckedChanged += new System.EventHandler(this.Behavior_CheckChanged);
            // 
            // checkBox18
            // 
            this.checkBox18.BeforeTouchSize = new System.Drawing.Size(150, 21);
            this.checkBox18.DrawFocusRectangle = false;
            this.checkBox18.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox18.Location = new System.Drawing.Point(54, 184);
            this.checkBox18.MetroColor = System.Drawing.Color.Gray;
            this.checkBox18.Name = "checkBox18";
            this.checkBox18.Size = new System.Drawing.Size(91, 18);
            this.checkBox18.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.checkBox18.TabIndex = 10;
            this.checkBox18.Tag = "focus";
            this.checkBox18.Text = "Focus on Tab";
            this.checkBox18.ThemesEnabled = false;
            this.checkBox18.CheckedChanged += new System.EventHandler(this.Behavior_CheckChanged);
            // 
            // tab4
            // 
            this.tab4.BackColor = System.Drawing.Color.White;
            this.tab4.Controls.Add(this.gradientPanel4);
            this.tab4.Controls.Add(this.gradientPanel1);
            this.tab4.Image = null;
            this.tab4.ImageIndex = 2;
            this.tab4.ImageSize = new System.Drawing.Size(15, 15);
            this.tab4.Location = new System.Drawing.Point(1, 43);
            this.tab4.Name = "tab4";
            this.tab4.ShowCloseButton = true;
            this.tab4.Size = new System.Drawing.Size(964, 465);
            toolTipInfo3.Body.Size = new System.Drawing.Size(20, 20);
            toolTipInfo3.Footer.Size = new System.Drawing.Size(20, 20);
            toolTipInfo3.Header.Size = new System.Drawing.Size(20, 20);
            toolTipInfo3.Header.Text = "Tab Primitives";
            this.tab4.SuperTooltip = toolTipInfo3;
            this.tab4.TabFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.tab4.TabIndex = 6;
            this.tab4.Text = "Tab Primitives";
            this.tab4.ThemesEnabled = false;
            // 
            // gradientPanel4
            // 
            this.gradientPanel4.BorderColor = System.Drawing.Color.LightGray;
            this.gradientPanel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gradientPanel4.Controls.Add(this.PrimitivesTabControl);
            this.gradientPanel4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gradientPanel4.Location = new System.Drawing.Point(67, 191);
            this.gradientPanel4.Name = "gradientPanel4";
            this.gradientPanel4.Size = new System.Drawing.Size(769, 256);
            this.gradientPanel4.TabIndex = 3;
            // 
            // PrimitivesTabControl
            // 
            this.PrimitivesTabControl.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PrimitivesTabControl.BeforeTouchSize = new System.Drawing.Size(767, 254);
            this.PrimitivesTabControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PrimitivesTabControl.Controls.Add(this.tabPageAdv7);
            this.PrimitivesTabControl.Controls.Add(this.tabPageAdv3);
            this.PrimitivesTabControl.Controls.Add(this.tabPageAdv4);
            this.PrimitivesTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PrimitivesTabControl.FixedSingleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(157)))), ((int)(((byte)(161)))));
            this.PrimitivesTabControl.FocusOnTabClick = false;
            this.PrimitivesTabControl.InactiveTabColor = System.Drawing.Color.White;
            this.PrimitivesTabControl.Location = new System.Drawing.Point(0, 0);
            this.PrimitivesTabControl.Name = "PrimitivesTabControl";
            this.PrimitivesTabControl.ShowScroll = false;
            this.PrimitivesTabControl.ShowToolTips = true;
            this.PrimitivesTabControl.Size = new System.Drawing.Size(767, 254);
            this.PrimitivesTabControl.TabIndex = 0;
            this.PrimitivesTabControl.TabPanelBackColor = System.Drawing.Color.White;
            this.PrimitivesTabControl.TabPrimitivesHost.TabPrimitives.Add(new Syncfusion.Windows.Forms.Tools.TabPrimitive(Syncfusion.Windows.Forms.Tools.TabPrimitiveType.Custom, ((System.Drawing.Image)(resources.GetObject("PrimitivesTabControl.TabPrimitivesHost.TabPrimitives"))), System.Drawing.Color.Transparent, false, 1, "AddTab", "AddTab"));
            this.PrimitivesTabControl.TabPrimitivesHost.TabPrimitives.Add(new Syncfusion.Windows.Forms.Tools.TabPrimitive(Syncfusion.Windows.Forms.Tools.TabPrimitiveType.FirstTab, null, System.Drawing.Color.Transparent, true, 1, "TabPrimitive0", "FirstTab"));
            this.PrimitivesTabControl.TabPrimitivesHost.TabPrimitives.Add(new Syncfusion.Windows.Forms.Tools.TabPrimitive(Syncfusion.Windows.Forms.Tools.TabPrimitiveType.PreviousPage, null, System.Drawing.Color.Empty, true, 1, "TabPrimitive1", "PreviousPage"));
            this.PrimitivesTabControl.TabPrimitivesHost.TabPrimitives.Add(new Syncfusion.Windows.Forms.Tools.TabPrimitive(Syncfusion.Windows.Forms.Tools.TabPrimitiveType.PreviousTab, null, System.Drawing.Color.Empty, true, 1, "TabPrimitive2", "PreviousTab"));
            this.PrimitivesTabControl.TabPrimitivesHost.TabPrimitives.Add(new Syncfusion.Windows.Forms.Tools.TabPrimitive(Syncfusion.Windows.Forms.Tools.TabPrimitiveType.NextTab, null, System.Drawing.Color.Empty, true, 1, "TabPrimitive3", "NextTab"));
            this.PrimitivesTabControl.TabPrimitivesHost.TabPrimitives.Add(new Syncfusion.Windows.Forms.Tools.TabPrimitive(Syncfusion.Windows.Forms.Tools.TabPrimitiveType.NextPage, null, System.Drawing.Color.Empty, true, 1, "TabPrimitive4", "NextPage"));
            this.PrimitivesTabControl.TabPrimitivesHost.TabPrimitives.Add(new Syncfusion.Windows.Forms.Tools.TabPrimitive(Syncfusion.Windows.Forms.Tools.TabPrimitiveType.LastTab, null, System.Drawing.Color.Empty, true, 1, "TabPrimitive5", "LastTab"));
            this.PrimitivesTabControl.TabPrimitivesHost.TabPrimitives.Add(new Syncfusion.Windows.Forms.Tools.TabPrimitive(Syncfusion.Windows.Forms.Tools.TabPrimitiveType.DropDown, null, System.Drawing.Color.Empty, true, 1, "TabPrimitive6", "DropDown"));
            this.PrimitivesTabControl.TabPrimitivesHost.TabPrimitives.Add(new Syncfusion.Windows.Forms.Tools.TabPrimitive(Syncfusion.Windows.Forms.Tools.TabPrimitiveType.Close, null, System.Drawing.Color.Empty, true, 1, "TabPrimitive7", "Close"));
            this.PrimitivesTabControl.TabPrimitivesHost.Visible = true;
            this.PrimitivesTabControl.TabStyle = typeof(Syncfusion.Windows.Forms.Tools.TabRendererMetro);
            this.PrimitivesTabControl.TabPrimitiveClick += new Syncfusion.Windows.Forms.Tools.TabPrimitiveClick(this.PrimitivesTabControl_TabPrimitiveClick);
            // 
            // tabPageAdv7
            // 
            this.tabPageAdv7.BackColor = System.Drawing.Color.White;
            this.tabPageAdv7.Controls.Add(this.label35);
            this.tabPageAdv7.Controls.Add(this.label34);
            this.tabPageAdv7.Controls.Add(this.label26);
            this.tabPageAdv7.Controls.Add(this.checkBox9);
            this.tabPageAdv7.Controls.Add(this.checkBox8);
            this.tabPageAdv7.Controls.Add(this.checkBox7);
            this.tabPageAdv7.Controls.Add(this.checkBox6);
            this.tabPageAdv7.Controls.Add(this.checkBox5);
            this.tabPageAdv7.Controls.Add(this.checkBox4);
            this.tabPageAdv7.Controls.Add(this.checkBox3);
            this.tabPageAdv7.Controls.Add(this.checkBox2);
            this.tabPageAdv7.Controls.Add(this.checkBox1);
            this.tabPageAdv7.Image = null;
            this.tabPageAdv7.ImageSize = new System.Drawing.Size(16, 16);
            this.tabPageAdv7.Location = new System.Drawing.Point(1, 22);
            this.tabPageAdv7.Name = "tabPageAdv7";
            this.tabPageAdv7.ShowCloseButton = true;
            this.tabPageAdv7.Size = new System.Drawing.Size(765, 231);
            this.tabPageAdv7.TabFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.tabPageAdv7.TabIndex = 1;
            this.tabPageAdv7.Text = "Primitives Options";
            this.tabPageAdv7.ThemesEnabled = false;
            this.tabPageAdv7.Click += new System.EventHandler(this.tabPageAdv7_Click);
            // 
            // label35
            // 
            this.label35.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label35.ForeColor = System.Drawing.Color.Black;
            this.label35.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label35.Location = new System.Drawing.Point(32, 148);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(133, 24);
            this.label35.TabIndex = 17;
            this.label35.Text = "Custom Primitives";
            this.label35.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label34
            // 
            this.label34.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label34.ForeColor = System.Drawing.Color.Black;
            this.label34.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label34.Location = new System.Drawing.Point(34, 78);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(100, 24);
            this.label34.TabIndex = 16;
            this.label34.Text = "More Options";
            this.label34.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label26
            // 
            this.label26.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.ForeColor = System.Drawing.Color.Black;
            this.label26.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label26.Location = new System.Drawing.Point(34, 10);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(75, 24);
            this.label26.TabIndex = 15;
            this.label26.Text = "Visibility";
            this.label26.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // checkBox9
            // 
            this.checkBox9.BeforeTouchSize = new System.Drawing.Size(150, 21);
            this.checkBox9.Checked = true;
            this.checkBox9.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox9.DrawFocusRectangle = false;
            this.checkBox9.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox9.Location = new System.Drawing.Point(205, 112);
            this.checkBox9.MetroColor = System.Drawing.Color.Gray;
            this.checkBox9.Name = "checkBox9";
            this.checkBox9.Size = new System.Drawing.Size(118, 18);
            this.checkBox9.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.checkBox9.TabIndex = 12;
            this.checkBox9.Text = "Show Close button";
            this.checkBox9.ThemesEnabled = false;
            this.checkBox9.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // checkBox8
            // 
            this.checkBox8.BeforeTouchSize = new System.Drawing.Size(150, 21);
            this.checkBox8.Checked = true;
            this.checkBox8.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox8.DrawFocusRectangle = false;
            this.checkBox8.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox8.Location = new System.Drawing.Point(42, 112);
            this.checkBox8.MetroColor = System.Drawing.Color.Gray;
            this.checkBox8.Name = "checkBox8";
            this.checkBox8.Size = new System.Drawing.Size(121, 18);
            this.checkBox8.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.checkBox8.TabIndex = 12;
            this.checkBox8.Text = "Show DropDown";
            this.checkBox8.ThemesEnabled = false;
            this.checkBox8.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // checkBox7
            // 
            this.checkBox7.BeforeTouchSize = new System.Drawing.Size(150, 21);
            this.checkBox7.DrawFocusRectangle = false;
            this.checkBox7.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox7.Location = new System.Drawing.Point(43, 190);
            this.checkBox7.MetroColor = System.Drawing.Color.Gray;
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(150, 18);
            this.checkBox7.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.checkBox7.TabIndex = 9;
            this.checkBox7.Text = "Show Custom Primitive";
            this.checkBox7.ThemesEnabled = false;
            this.checkBox7.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // checkBox6
            // 
            this.checkBox6.BeforeTouchSize = new System.Drawing.Size(150, 21);
            this.checkBox6.Checked = true;
            this.checkBox6.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox6.DrawFocusRectangle = false;
            this.checkBox6.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox6.Location = new System.Drawing.Point(433, 44);
            this.checkBox6.MetroColor = System.Drawing.Color.Gray;
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(79, 18);
            this.checkBox6.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.checkBox6.TabIndex = 4;
            this.checkBox6.Text = "Next Tab";
            this.checkBox6.ThemesEnabled = false;
            this.checkBox6.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // checkBox5
            // 
            this.checkBox5.BeforeTouchSize = new System.Drawing.Size(150, 21);
            this.checkBox5.Checked = true;
            this.checkBox5.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox5.DrawFocusRectangle = false;
            this.checkBox5.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox5.Location = new System.Drawing.Point(40, 44);
            this.checkBox5.MetroColor = System.Drawing.Color.Gray;
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(78, 18);
            this.checkBox5.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.checkBox5.TabIndex = 5;
            this.checkBox5.Text = "First Tab";
            this.checkBox5.ThemesEnabled = false;
            this.checkBox5.CheckStateChanged += new System.EventHandler(this.checkBox5_CheckStateChanged);
            this.checkBox5.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // checkBox4
            // 
            this.checkBox4.BeforeTouchSize = new System.Drawing.Size(150, 21);
            this.checkBox4.Checked = true;
            this.checkBox4.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox4.DrawFocusRectangle = false;
            this.checkBox4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox4.Location = new System.Drawing.Point(551, 44);
            this.checkBox4.MetroColor = System.Drawing.Color.Gray;
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(95, 18);
            this.checkBox4.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.checkBox4.TabIndex = 6;
            this.checkBox4.Text = "Next Page";
            this.checkBox4.ThemesEnabled = false;
            this.checkBox4.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // checkBox3
            // 
            this.checkBox3.BeforeTouchSize = new System.Drawing.Size(150, 21);
            this.checkBox3.Checked = true;
            this.checkBox3.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox3.DrawFocusRectangle = false;
            this.checkBox3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox3.Location = new System.Drawing.Point(151, 44);
            this.checkBox3.MetroColor = System.Drawing.Color.Gray;
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(113, 18);
            this.checkBox3.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.checkBox3.TabIndex = 1;
            this.checkBox3.Text = "Previous Page";
            this.checkBox3.ThemesEnabled = false;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.BeforeTouchSize = new System.Drawing.Size(150, 21);
            this.checkBox2.Checked = true;
            this.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox2.DrawFocusRectangle = false;
            this.checkBox2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox2.Location = new System.Drawing.Point(679, 44);
            this.checkBox2.MetroColor = System.Drawing.Color.Gray;
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(78, 18);
            this.checkBox2.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.checkBox2.TabIndex = 2;
            this.checkBox2.Text = "Last Tab";
            this.checkBox2.ThemesEnabled = false;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.BeforeTouchSize = new System.Drawing.Size(150, 21);
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.DrawFocusRectangle = false;
            this.checkBox1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(294, 44);
            this.checkBox1.MetroColor = System.Drawing.Color.Gray;
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(99, 18);
            this.checkBox1.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.checkBox1.TabIndex = 3;
            this.checkBox1.Text = "Previous Tab";
            this.checkBox1.ThemesEnabled = false;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // tabPageAdv3
            // 
            this.tabPageAdv3.BackColor = System.Drawing.Color.White;
            this.tabPageAdv3.Image = null;
            this.tabPageAdv3.ImageSize = new System.Drawing.Size(16, 16);
            this.tabPageAdv3.Location = new System.Drawing.Point(1, 22);
            this.tabPageAdv3.Name = "tabPageAdv3";
            this.tabPageAdv3.ShowCloseButton = true;
            this.tabPageAdv3.Size = new System.Drawing.Size(765, 231);
            this.tabPageAdv3.TabIndex = 2;
            this.tabPageAdv3.Text = "TabPage 1";
            this.tabPageAdv3.ThemesEnabled = false;            
            // 
            // tabPageAdv4
            // 
            this.tabPageAdv4.BackColor = System.Drawing.Color.White;
            this.tabPageAdv4.Image = null;
            this.tabPageAdv4.ImageSize = new System.Drawing.Size(16, 16);
            this.tabPageAdv4.Location = new System.Drawing.Point(1, 22);
            this.tabPageAdv4.Name = "tabPageAdv4";
            this.tabPageAdv4.ShowCloseButton = true;
            this.tabPageAdv4.Size = new System.Drawing.Size(765, 231);
            this.tabPageAdv4.TabIndex = 3;
            this.tabPageAdv4.Text = "Tab Page 2";
            this.tabPageAdv4.ThemesEnabled = false;           
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.BorderColor = System.Drawing.Color.Silver;
            this.gradientPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gradientPanel1.Controls.Add(this.label40);
            this.gradientPanel1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gradientPanel1.Location = new System.Drawing.Point(67, 59);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(767, 86);
            this.gradientPanel1.TabIndex = 2;
            // 
            // label40
            // 
            this.label40.BackColor = System.Drawing.Color.Transparent;
            this.label40.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label40.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label40.Location = new System.Drawing.Point(0, 0);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(765, 84);
            this.label40.TabIndex = 1;
            this.label40.Text = resources.GetString("label40.Text");
            this.label40.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(164)))), ((int)(((byte)(190)))));
            this.label2.Location = new System.Drawing.Point(126, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(400, 1);
            this.label2.TabIndex = 0;
            // 
            // colorDialog1
            // 
            this.colorDialog1.Color = System.Drawing.SystemColors.Window;
            // 
            // gradientPanel2
            // 
            this.gradientPanel2.BorderColor = System.Drawing.Color.Silver;
            this.gradientPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gradientPanel2.Controls.Add(this.FormTabControl);
            this.gradientPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gradientPanel2.Location = new System.Drawing.Point(20, 20);
            this.gradientPanel2.Name = "gradientPanel2";
            this.gradientPanel2.Size = new System.Drawing.Size(968, 511);
            this.gradientPanel2.TabIndex = 15;
            // 
            // TabControlAdvFrame
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 15);
            this.BackColor = System.Drawing.Color.White;
            this.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.ClientSize = new System.Drawing.Size(1008, 551);
            this.Controls.Add(this.gradientPanel2);
            this.DropShadow = true;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(400, 200);
            this.Name = "TabControlAdvFrame";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TabControlAdv ";
            this.BorderThickness = 1;
            this.Load += new System.EventHandler(this.TabControlAdvFrame_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.FormTabControl)).EndInit();
            this.FormTabControl.ResumeLayout(false);
            this.contextMenuStripEx1.ResumeLayout(false);
            this.tab6.ResumeLayout(false);
            this.tab6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contextMenuCheck)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox26)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelColorEdit)).EndInit();
            this.panelColorEdit.ResumeLayout(false);
            this.panelColorEdit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.borderColorEdit)).EndInit();
            this.borderColorEdit.ResumeLayout(false);
            this.borderColorEdit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inactiveTabColorEdit)).EndInit();
            this.inactiveTabColorEdit.ResumeLayout(false);
            this.inactiveTabColorEdit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.activeTabColorEdit)).EndInit();
            this.activeTabColorEdit.ResumeLayout(false);
            this.activeTabColorEdit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox10)).EndInit();
            this.tab3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel3)).EndInit();
            this.gradientPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BehaviorTabControl)).EndInit();
            this.BehaviorTabControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.checkBox15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox25)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox24)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox23)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox22)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox20)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox19)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox18)).EndInit();
            this.tab4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel4)).EndInit();
            this.gradientPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PrimitivesTabControl)).EndInit();
            this.PrimitivesTabControl.ResumeLayout(false);
            this.tabPageAdv7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.checkBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel1)).EndInit();
            this.gradientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel2)).EndInit();
            this.gradientPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

		}
		#endregion

        #region TabControl Events
        void tp_Closing(object sender, TabPageAdvClosingEventArgs args)
        {
            if (MessageBox.Show("Are you sure want to close the " + args.TabPageAdv.Text + " tab?", "Closing tab...", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                tabPage1 = args.TabPageAdv;
                args.Cancel = false;
                EventsList("TabPage Closing: " + tabPage1.Text);
            }
            else
                args.Cancel = true;
        }

        void tp_Closed(object sender, EventArgs e)
        {
            EventsList("TabPage Closed: " + tabPage1.Text);
        }

        #endregion

        #region Helper Methods
        private void InitializeItems()
        {
            this.comboBox1.SelectedIndex = 19;
            this.comboBox2.SelectedIndex = 0;
            
            foreach(String str in Enum.GetNames(typeof(System.Windows.Forms.BorderStyle)))
                this.comboBox3.Items.Add(str);
            this.comboBox3.SelectedIndex = 1;

            for (int tabcount = 3; tabcount < 10; tabcount++)
            {
                TabPageAdv tabPage = new TabPageAdv("Tab Page " + tabcount.ToString());
                PrimitivesTabControl.TabPages.Add(tabPage);
            }

            Appearance = FormTabControl.TabPages[0];
            Behavior = FormTabControl.TabPages[1];
            Tab_Primitives = FormTabControl.TabPages[2];
        }

        private void PopulateTabStyles()
        {
            this.comboBox1.Items.Add("TabRenderer3D");
            this.comboBox1.Items.Add("TabRenderer2D");
            this.comboBox1.Items.Add("Workbook");
            this.comboBox1.Items.Add("OneNoteStyle");
            this.comboBox1.Items.Add("OneNoteStyleFlatTabs");
            this.comboBox1.Items.Add("Office2003");
            this.comboBox1.Items.Add("Whidbey");
            this.comboBox1.Items.Add("DockingWhidbey");
            this.comboBox1.Items.Add("DockingWhidbeyBeta");
            this.comboBox1.Items.Add("Office2007Blue");
            this.comboBox1.Items.Add("Office2007Black");
            this.comboBox1.Items.Add("Office2007Silver");
            this.comboBox1.Items.Add("Office2007Managed");
            this.comboBox1.Items.Add("InternetExplorer7");
            this.comboBox1.Items.Add("TabRendererVS2008");
            this.comboBox1.Items.Add("TabRendererBlendDark");
            this.comboBox1.Items.Add("TabRendererBlendLight");
            this.comboBox1.Items.Add("TabRendererVS2010");
            this.comboBox1.Items.Add("TabRendererMetro");
            this.comboBox1.Items.Add("TabRendererOffice2016Colorful");
            this.comboBox1.Items.Add("TabRendererOffice2016White");
            this.comboBox1.Items.Add("TabRendererOffice2016DarkGray");
            this.comboBox1.Items.Add("TabRendererOffice2016Black");
        } 
        #endregion
      
        #region Color Options
        private void buttonEdit1_ButtonClicked(object sender, ButtonClickedEventArgs args)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                activeTabColorEdit.BackColor = colorDialog1.Color;
                FormTabControl.ActiveTabColor = colorDialog1.Color;
            }
        }

        private void inactiveTabColorEdit_ButtonClicked(object sender, ButtonClickedEventArgs args)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                inactiveTabColorEdit.BackColor = colorDialog1.Color;
                FormTabControl.InactiveTabColor = colorDialog1.Color;
            }
        }

        private void borderColorEdit_ButtonClicked(object sender, ButtonClickedEventArgs args)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                borderColorEdit.BackColor = colorDialog1.Color;
                FormTabControl.FixedSingleBorderColor = colorDialog1.Color;
            }
        }

        private void panelColorEdit_ButtonClicked(object sender, ButtonClickedEventArgs args)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                panelColorEdit.BackColor = colorDialog1.Color;
                FormTabControl.TabPanelBackColor = colorDialog1.Color;
            }
        }

        #endregion

        #region Primitives
        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBoxAdv checkBox = (CheckBoxAdv)sender;

            switch (checkBox.Text)
            {
                case "First Tab":
                    this.PrimitivesTabControl.TabPrimitivesHost.TabPrimitives[1].Visible = this.checkBox5.Checked;
                    break;
                case "Previous Page":
                    this.PrimitivesTabControl.TabPrimitivesHost.TabPrimitives[2].Visible = this.checkBox3.Checked;
                    break;
                case "Previous Tab":
                    this.PrimitivesTabControl.TabPrimitivesHost.TabPrimitives[3].Visible = this.checkBox1.Checked;
                    break;
                case "Next Tab":
                    this.PrimitivesTabControl.TabPrimitivesHost.TabPrimitives[4].Visible = this.checkBox6.Checked;
                    break;
                case "Next Page":
                    this.PrimitivesTabControl.TabPrimitivesHost.TabPrimitives[5].Visible = this.checkBox4.Checked;
                    break;
                case "Last Tab":
                    this.PrimitivesTabControl.TabPrimitivesHost.TabPrimitives[6].Visible = this.checkBox2.Checked;
                    break;
                case "Show DropDown":
                    this.PrimitivesTabControl.TabPrimitivesHost.TabPrimitives[7].Visible = this.checkBox8.Checked;
                    break;
                case "Show Close button":
                    this.PrimitivesTabControl.TabPrimitivesHost.TabPrimitives[8].Visible = this.checkBox9.Checked;
                    break;
                case "Show Custom Primitive":
                    this.PrimitivesTabControl.TabPrimitivesHost.TabPrimitives[0].Visible = this.checkBox7.Checked;
                    break;
            }
        }

        private void PrimitivesTabControl_TabPrimitiveClick(object sender, TabPrimitiveClickEventArgs e)
        {
            if (e.TabPrimitive.Name == "AddTab")
            {
                TabPageAdv tabPage = new TabPageAdv("New Tab");
                PrimitivesTabControl.TabPages.Add(tabPage);
            }
        }
        #endregion

        #region Styles
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            numericUpDown1.Value = numericUpDown1.Minimum;
            switch (this.comboBox1.SelectedItem as string)
            {
                case "TabRenderer3D":
                    this.FormTabControl.TabStyle = typeof(TabRenderer3D);
                    this.FormTabControl.BackColor = Color.White;
                    Office2007Colors.ApplyManagedScheme(this, Office2007Theme.Blue);
                    break;
                case "TabRendererMetro":
                    this.FormTabControl.TabStyle = typeof(TabRendererMetro);
                    this.FormTabControl.BackColor = Color.White;
                    break;
                case "TabRenderer2D":
                    this.FormTabControl.TabStyle = typeof(TabRenderer2D);
                    this.FormTabControl.BackColor = Color.White;
                    Office2007Colors.ApplyManagedScheme(this, Office2007Theme.Blue);
                    break;
                case "Workbook":
                    this.FormTabControl.TabStyle = typeof(TabRendererWorkbookMode);
                    this.FormTabControl.BackColor = Color.White;
                    Office2007Colors.ApplyManagedScheme(this, Office2007Theme.Blue);
                    break;
                case "OneNoteStyle":
                    this.FormTabControl.TabStyle = typeof(OneNoteStyleRenderer);
                    this.FormTabControl.BackColor = Color.White;
                    Office2007Colors.ApplyManagedScheme(this, Office2007Theme.Blue);
                    break;
                case "OneNoteStyleFlatTabs":
                    this.FormTabControl.TabStyle = typeof(OneNoteStyleFlatTabsRenderer);
                    this.FormTabControl.BackColor = Color.White;
                    Office2007Colors.ApplyManagedScheme(this, Office2007Theme.Blue);
                    break;
                case "Office2003":
                    this.FormTabControl.TabStyle = typeof(TabRendererOffice2003);
                    this.FormTabControl.BackColor = Color.White;
                    Office2007Colors.ApplyManagedScheme(this, Office2007Theme.Blue);
                    break;
                case "Whidbey":
                    this.FormTabControl.TabStyle = typeof(TabRendererWhidbey);
                    this.FormTabControl.BackColor = Color.White;
                    Office2007Colors.ApplyManagedScheme(this, Office2007Theme.Blue);
                    break;
                case "DockingWhidbey":
                    this.FormTabControl.TabStyle = typeof(TabRendererDockingWhidbey);
                    this.FormTabControl.BackColor = Color.White;
                    Office2007Colors.ApplyManagedScheme(this, Office2007Theme.Blue);
                    break;
                case "DockingWhidbeyBeta":
                    this.FormTabControl.TabStyle = typeof(TabRendererDockingWhidbeyBeta);
                    this.FormTabControl.BackColor = Color.White;
                    Office2007Colors.ApplyManagedScheme(this, Office2007Theme.Blue);
                    break;
                case "Office2007Blue":
                    this.FormTabControl.TabStyle = typeof(TabRendererOffice2007);
                    this.FormTabControl.BackColor = Color.White;
                    this.FormTabControl.Office2007ColorScheme = Office2007Theme.Blue;
                    Office2007Colors.ApplyManagedScheme(this, Office2007Theme.Blue);
                    break;
                case "Office2007Black":
                    this.FormTabControl.TabStyle = typeof(TabRendererOffice2007);
                    this.FormTabControl.BackColor = Color.White;
                    this.FormTabControl.Office2007ColorScheme = Office2007Theme.Black;
                    Office2007Colors.ApplyManagedScheme(this, Office2007Theme.Black);
                    break;
                case "Office2007Silver":
                    this.FormTabControl.TabStyle = typeof(TabRendererOffice2007);
                    this.FormTabControl.BackColor = Color.White;
                    this.FormTabControl.Office2007ColorScheme = Office2007Theme.Silver;
                    Office2007Colors.ApplyManagedScheme(this, Office2007Theme.Silver);
                    break;
                case "Office2007Managed":
                    this.FormTabControl.TabStyle = typeof(TabRendererOffice2007);
                    this.FormTabControl.BackColor = Color.White;
                    this.FormTabControl.Office2007ColorScheme = Office2007Theme.Managed;
                    Office2007Colors.ApplyManagedColors(this, Color.Green);
                    break;

                case "InternetExplorer7":
                    this.FormTabControl.TabStyle = typeof(TabRendererIE7);
                    this.FormTabControl.BackColor = Color.White;
                    Office2007Colors.ApplyManagedScheme(this, Office2007Theme.Blue);
                    break;
                case "TabRendererVS2008":
                    this.FormTabControl.TabStyle = typeof(TabRendererVS2008);
                    this.FormTabControl.BackColor = Color.White;
                    Office2007Colors.ApplyManagedScheme(this, Office2007Theme.Blue);
                    break;
                case "TabRendererBlendDark":
                    this.FormTabControl.TabStyle = typeof(TabRendererBlendDark);
                    this.FormTabControl.BackColor = Color.White;
                    Office2007Colors.ApplyManagedScheme(this, Office2007Theme.Blue);
                    break;
                case "TabRendererBlendLight":
                    this.FormTabControl.TabStyle = typeof(TabRendererBlendLight);
                    this.FormTabControl.BackColor = Color.White;
                    Office2007Colors.ApplyManagedScheme(this, Office2007Theme.Blue);
                    break;
                case "TabRendererVS2010":
                    this.FormTabControl.TabStyle = typeof(TabRendererVS2010);
                    this.FormTabControl.BackColor = System.Drawing.SystemColors.Control;
                    Office2007Colors.ApplyManagedScheme(this, Office2007Theme.Silver);
                    break;
                case "TabRendererOffice2016Colorful":
                    this.FormTabControl.TabStyle = typeof(TabRendererOffice2016Colorful);
                    break;
                case "TabRendererOffice2016White":
                    this.FormTabControl.TabStyle = typeof(TabRendererOffice2016White);
                    break;
                case "TabRendererOffice2016DarkGray":
                    this.FormTabControl.TabStyle = typeof(TabRendererOffice2016DarkGray);
                    break;
                case "TabRendererOffice2016Black":
                    this.FormTabControl.TabStyle = typeof(TabRendererOffice2016Black);
                    break;
            }
            UpdateTabPageStyleforOffice2016Themes();
        }

        private void UpdateTabPageStyleforOffice2016Themes()
        {
            LockWindowUpdate(this.Handle);
            if (this.FormTabControl != null && this.FormTabControl.TabStyle == typeof(TabRendererOffice2016Black))
            {
                this.tab3.BackColor = ColorTranslator.FromHtml("#262626");
                this.tab3.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                this.tab4.BackColor = ColorTranslator.FromHtml("#262626");
                this.tab4.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                this.tab6.BackColor = ColorTranslator.FromHtml("#262626");
                this.tab6.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                this.BackColor = ColorTranslator.FromHtml("#262626");
                this.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                this.gradientPanel2.BorderColor = ColorTranslator.FromHtml("#363636");
                this.FormTabControl.FixedSingleBorderColor = ColorTranslator.FromHtml("#363636");
                this.CaptionBarColor = ColorTranslator.FromHtml("#363636");
                this.CaptionForeColor = ColorTranslator.FromHtml("#f0f0f0");
                this.gradientPanel4.BorderColor = ColorTranslator.FromHtml("#363636");
                this.gradientPanel1.BorderColor = ColorTranslator.FromHtml("#363636");
                this.gradientPanel3.BorderColor = ColorTranslator.FromHtml("#363636");
                this.label35.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                this.label34.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                this.label26.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                this.BorderColor = ColorTranslator.FromHtml("#363636");
                this.MetroColor = ColorTranslator.FromHtml("#363636");
                this.activeTabColorEdit.ButtonStyle = Syncfusion.Windows.Forms.ButtonAppearance.Office2016Black;
                this.inactiveTabColorEdit.ButtonStyle = Syncfusion.Windows.Forms.ButtonAppearance.Office2016Black;
                this.borderColorEdit.ButtonStyle = Syncfusion.Windows.Forms.ButtonAppearance.Office2016Black;
                this.panelColorEdit.ButtonStyle = Syncfusion.Windows.Forms.ButtonAppearance.Office2016Black;
                this.numericUpDown1.VisualStyle = Syncfusion.Windows.Forms.VisualStyle.Office2016Black;
                this.comboBox3.Style = Syncfusion.Windows.Forms.VisualStyle.Office2016Black;
                this.comboBox2.Style = Syncfusion.Windows.Forms.VisualStyle.Office2016Black;
                this.comboBox1.Style = Syncfusion.Windows.Forms.VisualStyle.Office2016Black;
                this.checkBox17.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Office2016Black;
                this.checkBox11.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Office2016Black;
                this.checkBox10.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Office2016Black;
                this.checkBox14.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Office2016Black;
                this.checkBox12.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Office2016Black;
                this.checkBox13.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Office2016Black;
                this.checkBox26.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Office2016Black;
                this.checkBox16.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Office2016Black;
                this.contextMenuCheck.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Office2016Black;
                this.checkBox15.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Office2016Black;
                this.checkBox18.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Office2016Black;
                this.checkBox19.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Office2016Black;
                this.checkBox20.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Office2016Black;
                this.checkBox21.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Office2016Black;
                this.checkBox22.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Office2016Black;
                this.checkBox23.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Office2016Black;
                this.checkBox24.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Office2016Black;
                this.checkBox25.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Office2016Black;
                this.checkBox1.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Office2016Black;
                this.checkBox2.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Office2016Black;
                this.checkBox3.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Office2016Black;
                this.checkBox4.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Office2016Black;
                this.checkBox5.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Office2016Black;
                this.checkBox6.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Office2016Black;
                this.checkBox7.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Office2016Black;
                this.checkBox8.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Office2016Black;
                this.checkBox9.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Office2016Black;

                if (this.BehaviorTabControl != null)
                {
                    this.BehaviorTabControl.TabStyle = typeof(Syncfusion.Windows.Forms.Tools.TabRendererOffice2016Black);
                    this.BehaviorTabControl.TabStyle = typeof(Syncfusion.Windows.Forms.Tools.TabRendererOffice2016Black);
                    this.BehaviorTabControl.FixedSingleBorderColor = ColorTranslator.FromHtml("#363636");
                    foreach (TabPageAdv tabpage in this.BehaviorTabControl.TabPages)
                    {
                        if (tabpage != null)
                        {
                            tabpage.BackColor = ColorTranslator.FromHtml("#262626");
                            tabpage.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                        }
                    }
                }

                if (this.PrimitivesTabControl != null)
                {
                    this.PrimitivesTabControl.TabStyle = typeof(Syncfusion.Windows.Forms.Tools.TabRendererOffice2016Black);
                    this.PrimitivesTabControl.FixedSingleBorderColor = ColorTranslator.FromHtml("#363636");
                    foreach (TabPageAdv tabpage in this.PrimitivesTabControl.TabPages)
                    {
                        if (tabpage != null)
                        {
                            tabpage.BackColor = ColorTranslator.FromHtml("#262626");
                            tabpage.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                        }
                    }
                }
            }
            else if (this.FormTabControl != null && this.FormTabControl.TabStyle == typeof(TabRendererOffice2016DarkGray))
            {
                this.tab3.BackColor = ColorTranslator.FromHtml("#666666");
                this.tab3.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                this.tab4.BackColor = ColorTranslator.FromHtml("#666666");
                this.tab4.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                this.tab6.BackColor = ColorTranslator.FromHtml("#666666");
                this.tab6.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                this.BackColor = ColorTranslator.FromHtml("#666666");
                this.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                this.gradientPanel2.BorderColor = ColorTranslator.FromHtml("#444444");
                this.FormTabControl.FixedSingleBorderColor = ColorTranslator.FromHtml("#444444");
                this.CaptionBarColor = ColorTranslator.FromHtml("#505050");
                this.MetroColor = ColorTranslator.FromHtml("#505050");
                this.CaptionForeColor = ColorTranslator.FromHtml("#f0f0f0");
                this.gradientPanel4.BorderColor = ColorTranslator.FromHtml("#444444");
                this.gradientPanel1.BorderColor = ColorTranslator.FromHtml("#444444");
                this.gradientPanel3.BorderColor = ColorTranslator.FromHtml("#444444");
                this.label35.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                this.label34.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                this.label26.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                this.BorderColor = ColorTranslator.FromHtml("#444444");
                this.activeTabColorEdit.ButtonStyle = Syncfusion.Windows.Forms.ButtonAppearance.Office2016DarkGray;
                this.inactiveTabColorEdit.ButtonStyle = Syncfusion.Windows.Forms.ButtonAppearance.Office2016DarkGray;
                this.borderColorEdit.ButtonStyle = Syncfusion.Windows.Forms.ButtonAppearance.Office2016DarkGray;
                this.panelColorEdit.ButtonStyle = Syncfusion.Windows.Forms.ButtonAppearance.Office2016DarkGray;
                this.numericUpDown1.VisualStyle = Syncfusion.Windows.Forms.VisualStyle.Office2016DarkGray;
                this.comboBox3.Style = Syncfusion.Windows.Forms.VisualStyle.Office2016DarkGray;
                this.comboBox2.Style = Syncfusion.Windows.Forms.VisualStyle.Office2016DarkGray;
                this.comboBox1.Style = Syncfusion.Windows.Forms.VisualStyle.Office2016DarkGray;
                this.checkBox17.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Office2016DarkGray;
                this.checkBox11.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Office2016DarkGray;
                this.checkBox10.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Office2016DarkGray;
                this.contextMenuCheck.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Office2016DarkGray;
                this.checkBox14.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Office2016DarkGray;
                this.checkBox12.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Office2016DarkGray;
                this.checkBox13.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Office2016DarkGray;
                this.checkBox16.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Office2016DarkGray;
                this.checkBox26.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Office2016DarkGray;
                this.checkBox15.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Office2016DarkGray;
                this.checkBox18.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Office2016DarkGray;
                this.checkBox19.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Office2016DarkGray;
                this.checkBox20.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Office2016DarkGray;
                this.checkBox21.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Office2016DarkGray;
                this.checkBox22.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Office2016DarkGray;
                this.checkBox23.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Office2016DarkGray;
                this.checkBox24.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Office2016DarkGray;
                this.checkBox25.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Office2016DarkGray;
                this.checkBox1.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Office2016DarkGray;
                this.checkBox2.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Office2016DarkGray;
                this.checkBox3.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Office2016DarkGray;
                this.checkBox4.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Office2016DarkGray;
                this.checkBox5.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Office2016DarkGray;
                this.checkBox6.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Office2016DarkGray;
                this.checkBox7.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Office2016DarkGray;
                this.checkBox8.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Office2016DarkGray;
                this.checkBox9.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Office2016DarkGray;

                if (this.BehaviorTabControl != null)
                {
                    this.BehaviorTabControl.TabStyle = typeof(Syncfusion.Windows.Forms.Tools.TabRendererOffice2016DarkGray);
                    this.BehaviorTabControl.TabStyle = typeof(TabRendererOffice2016DarkGray);
                    this.BehaviorTabControl.FixedSingleBorderColor = ColorTranslator.FromHtml("#444444");
                    foreach (TabPageAdv tabpage in this.BehaviorTabControl.TabPages)
                    {
                        if (tabpage != null)
                        {
                            tabpage.BackColor = ColorTranslator.FromHtml("#666666");
                            tabpage.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                        }
                    }
                }
                if (this.PrimitivesTabControl != null)
                {
                    this.PrimitivesTabControl.TabStyle = typeof(TabRendererOffice2016DarkGray);
                    this.PrimitivesTabControl.FixedSingleBorderColor = ColorTranslator.FromHtml("#444444");
                    foreach (TabPageAdv tabpage in this.PrimitivesTabControl.TabPages)
                    {
                        if (tabpage != null)
                        {
                            tabpage.BackColor = ColorTranslator.FromHtml("#666666");
                            tabpage.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                        }
                    }
                }
            }
            else if (this.FormTabControl != null && (this.FormTabControl.TabStyle == typeof(TabRendererOffice2016Colorful) || this.FormTabControl.TabStyle == typeof(TabRendererOffice2016White)))
            {
                this.tab3.BackColor = ColorTranslator.FromHtml("#ffffff");
                this.tab3.ForeColor = ColorTranslator.FromHtml("#262626");
                this.tab4.BackColor = ColorTranslator.FromHtml("#ffffff");
                this.tab4.ForeColor = ColorTranslator.FromHtml("#262626");
                this.tab6.BackColor = ColorTranslator.FromHtml("#ffffff");
                this.tab6.ForeColor = ColorTranslator.FromHtml("#262626");
                this.BackColor = ColorTranslator.FromHtml("#ffffff");
                this.ForeColor = ColorTranslator.FromHtml("#262626");
                this.gradientPanel2.BorderColor = ColorTranslator.FromHtml("#c5c5c5");
                this.FormTabControl.FixedSingleBorderColor = ColorTranslator.FromHtml("#c5c5c5");
                this.gradientPanel4.BorderColor = ColorTranslator.FromHtml("#c5c5c5");
                this.gradientPanel1.BorderColor = ColorTranslator.FromHtml("#c5c5c5");
                this.gradientPanel3.BorderColor = ColorTranslator.FromHtml("#c5c5c5");
                this.label35.ForeColor = ColorTranslator.FromHtml("#262626");
                this.label34.ForeColor = ColorTranslator.FromHtml("#262626");
                this.label26.ForeColor = ColorTranslator.FromHtml("#262626");
                this.BorderColor = ColorTranslator.FromHtml("#c5c5c5");

                if (this.FormTabControl.TabStyle == typeof(TabRendererOffice2016Colorful))
                {
                    this.activeTabColorEdit.ButtonStyle = Syncfusion.Windows.Forms.ButtonAppearance.Office2016Colorful;
                    this.inactiveTabColorEdit.ButtonStyle = Syncfusion.Windows.Forms.ButtonAppearance.Office2016Colorful;
                    this.borderColorEdit.ButtonStyle = Syncfusion.Windows.Forms.ButtonAppearance.Office2016Colorful;
                    this.panelColorEdit.ButtonStyle = Syncfusion.Windows.Forms.ButtonAppearance.Office2016Colorful;
                    this.numericUpDown1.VisualStyle = Syncfusion.Windows.Forms.VisualStyle.Office2016Colorful;
                    this.comboBox3.Style = Syncfusion.Windows.Forms.VisualStyle.Office2016Colorful;
                    this.comboBox2.Style = Syncfusion.Windows.Forms.VisualStyle.Office2016Colorful;
                    this.comboBox1.Style = Syncfusion.Windows.Forms.VisualStyle.Office2016Colorful;
                    this.checkBox17.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Office2016Colorful;
                    this.checkBox11.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Office2016Colorful;
                    this.checkBox10.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Office2016Colorful;
                    this.contextMenuCheck.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Office2016Colorful;
                    this.checkBox14.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Office2016Colorful;
                    this.checkBox12.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Office2016Colorful;
                    this.checkBox13.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Office2016Colorful;
                    this.checkBox16.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Office2016Colorful;
                    this.checkBox26.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Office2016Colorful;
                    this.checkBox15.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Office2016Colorful;
                    this.checkBox18.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Office2016Colorful;
                    this.checkBox19.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Office2016Colorful;
                    this.checkBox20.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Office2016Colorful;
                    this.checkBox21.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Office2016Colorful;
                    this.checkBox22.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Office2016Colorful;
                    this.checkBox23.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Office2016Colorful;
                    this.checkBox24.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Office2016Colorful;
                    this.checkBox25.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Office2016Colorful;
                    this.checkBox1.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Office2016Colorful;
                    this.checkBox2.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Office2016Colorful;
                    this.checkBox3.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Office2016Colorful;
                    this.checkBox4.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Office2016Colorful;
                    this.checkBox5.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Office2016Colorful;
                    this.checkBox6.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Office2016Colorful;
                    this.checkBox7.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Office2016Colorful;
                    this.checkBox8.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Office2016Colorful;
                    this.checkBox9.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Office2016Colorful;
                    this.CaptionBarColor = ColorTranslator.FromHtml("#0173c7");
                    this.CaptionForeColor = ColorTranslator.FromHtml("#ffffff");
                    this.MetroColor = ColorTranslator.FromHtml("#0173c7");

                    if (this.BehaviorTabControl != null)
                    {
                        this.BehaviorTabControl.TabStyle = typeof(Syncfusion.Windows.Forms.Tools.TabRendererOffice2016Colorful);
                        this.BehaviorTabControl.TabStyle = typeof(TabRendererOffice2016Colorful);
                        this.BehaviorTabControl.FixedSingleBorderColor = ColorTranslator.FromHtml("#c5c5c5");
                        foreach (TabPageAdv tabpage in this.BehaviorTabControl.TabPages)
                        {
                            if (tabpage != null)
                            {
                                tabpage.BackColor = ColorTranslator.FromHtml("#ffffff");
                                tabpage.ForeColor = ColorTranslator.FromHtml("#262626");
                            }
                        }
                    }
                    if (this.PrimitivesTabControl != null)
                    {
                        this.PrimitivesTabControl.TabStyle = typeof(TabRendererOffice2016Colorful);
                        this.PrimitivesTabControl.FixedSingleBorderColor = ColorTranslator.FromHtml("#c5c5c5");
                        foreach (TabPageAdv tabpage in this.PrimitivesTabControl.TabPages)
                        {
                            if (tabpage != null)
                            {
                                tabpage.BackColor = ColorTranslator.FromHtml("#ffffff");
                                tabpage.ForeColor = ColorTranslator.FromHtml("#262626");
                            }
                        }
                    }
                }
                else
                {
                    this.activeTabColorEdit.ButtonStyle = Syncfusion.Windows.Forms.ButtonAppearance.Office2016White;
                    this.inactiveTabColorEdit.ButtonStyle = Syncfusion.Windows.Forms.ButtonAppearance.Office2016White;
                    this.borderColorEdit.ButtonStyle = Syncfusion.Windows.Forms.ButtonAppearance.Office2016White;
                    this.panelColorEdit.ButtonStyle = Syncfusion.Windows.Forms.ButtonAppearance.Office2016White;
                    this.numericUpDown1.VisualStyle = Syncfusion.Windows.Forms.VisualStyle.Office2016White;
                    this.comboBox3.Style = Syncfusion.Windows.Forms.VisualStyle.Office2016White;
                    this.comboBox2.Style = Syncfusion.Windows.Forms.VisualStyle.Office2016White;
                    this.comboBox1.Style = Syncfusion.Windows.Forms.VisualStyle.Office2016White;
                    this.checkBox17.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Office2016White;
                    this.checkBox11.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Office2016White;
                    this.checkBox10.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Office2016White;
                    this.contextMenuCheck.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Office2016White;
                    this.checkBox14.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Office2016White;
                    this.checkBox12.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Office2016White;
                    this.checkBox13.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Office2016White;
                    this.checkBox16.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Office2016White;
                    this.checkBox26.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Office2016White;
                    this.checkBox15.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Office2016White;
                    this.checkBox18.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Office2016White;
                    this.checkBox19.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Office2016White;
                    this.checkBox20.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Office2016White;
                    this.checkBox21.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Office2016White;
                    this.checkBox22.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Office2016White;
                    this.checkBox23.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Office2016White;
                    this.checkBox24.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Office2016White;
                    this.checkBox25.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Office2016White;
                    this.checkBox1.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Office2016White;
                    this.checkBox2.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Office2016White;
                    this.checkBox3.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Office2016White;
                    this.checkBox4.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Office2016White;
                    this.checkBox5.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Office2016White;
                    this.checkBox6.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Office2016White;
                    this.checkBox7.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Office2016White;
                    this.checkBox8.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Office2016White;
                    this.checkBox9.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Office2016White;
                    this.CaptionBarColor = ColorTranslator.FromHtml("#ffffff");
                    this.CaptionForeColor = ColorTranslator.FromHtml("#262626");
                    this.MetroColor = ColorTranslator.FromHtml("#ffffff");

                    if (this.BehaviorTabControl != null)
                    {
                        this.BehaviorTabControl.TabStyle = typeof(Syncfusion.Windows.Forms.Tools.TabRendererOffice2016White);
                        this.BehaviorTabControl.TabStyle = typeof(TabRendererOffice2016White);
                        this.BehaviorTabControl.FixedSingleBorderColor = ColorTranslator.FromHtml("#c5c5c5");
                        foreach (TabPageAdv tabpage in this.BehaviorTabControl.TabPages)
                        {
                            if (tabpage != null)
                            {
                                tabpage.BackColor = ColorTranslator.FromHtml("#ffffff");
                                tabpage.ForeColor = ColorTranslator.FromHtml("#262626");
                            }
                        }
                    }
                    if (this.PrimitivesTabControl != null)
                    {
                        this.PrimitivesTabControl.TabStyle = typeof(TabRendererOffice2016White);
                        this.PrimitivesTabControl.FixedSingleBorderColor = ColorTranslator.FromHtml("#c5c5c5");
                        foreach (TabPageAdv tabpage in this.PrimitivesTabControl.TabPages)
                        {
                            if (tabpage != null)
                            {
                                tabpage.BackColor = ColorTranslator.FromHtml("#ffffff");
                                tabpage.ForeColor = ColorTranslator.FromHtml("#262626");
                            }
                        }
                    }
                }
            }
            else
            {
                this.tab3.BackColor = Color.White;
                this.tab3.ForeColor = Color.Black;
                this.tab4.BackColor = Color.White;
                this.tab4.ForeColor = Color.Black;
                this.tab6.BackColor = Color.White;
                this.tab6.ForeColor = Color.Black;
                this.BackColor = System.Drawing.Color.White;
                this.gradientPanel2.BorderColor = System.Drawing.Color.Silver;
                this.FormTabControl.FixedSingleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(178)))), ((int)(((byte)(227)))));
                this.CaptionBarColor = Color.White;
                this.MetroColor = ColorTranslator.FromHtml("#119EDA");
                this.CaptionForeColor = ColorTranslator.FromHtml("#343434");
                this.gradientPanel4.BorderColor = System.Drawing.Color.LightGray;
                this.gradientPanel1.BorderColor = System.Drawing.Color.Silver;
                this.gradientPanel3.BorderColor = System.Drawing.Color.Silver;
                this.label35.ForeColor = System.Drawing.Color.Black;
                this.label34.ForeColor = System.Drawing.Color.Black;
                this.label26.ForeColor = System.Drawing.Color.Black;
                this.activeTabColorEdit.ButtonStyle = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
                this.inactiveTabColorEdit.ButtonStyle = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
                this.borderColorEdit.ButtonStyle = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
                this.numericUpDown1.VisualStyle = Syncfusion.Windows.Forms.VisualStyle.Default;
                this.panelColorEdit.ButtonStyle = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
                this.comboBox3.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
                this.comboBox2.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
                this.comboBox1.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
                this.checkBox17.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
                this.checkBox11.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
                this.checkBox10.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
                this.contextMenuCheck.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
                this.checkBox14.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
                this.checkBox12.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
                this.checkBox13.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
                this.checkBox26.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
                this.checkBox16.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
                this.checkBox15.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
                this.checkBox18.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
                this.checkBox19.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
                this.checkBox20.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
                this.checkBox21.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
                this.checkBox22.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
                this.checkBox23.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
                this.checkBox24.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
                this.checkBox25.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
                this.checkBox1.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
                this.checkBox2.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
                this.checkBox3.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
                this.checkBox4.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
                this.checkBox5.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
                this.checkBox6.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
                this.checkBox7.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
                this.checkBox8.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
                this.checkBox9.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;

                this.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
                if (this.BehaviorTabControl != null)
                {
                    this.BehaviorTabControl.TabStyle = typeof(Syncfusion.Windows.Forms.Tools.TabRendererMetro);
                    this.BehaviorTabControl.FixedSingleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(157)))), ((int)(((byte)(161)))));
                    foreach (TabPageAdv tabpage in this.BehaviorTabControl.TabPages)
                    {
                        if (tabpage != null)
                        {
                            tabpage.BackColor = System.Drawing.Color.White;
                            tabpage.ForeColor = SystemColors.ControlText;
                        }
                    }
                }

                if (this.PrimitivesTabControl != null)
                {
                    this.PrimitivesTabControl.TabStyle = typeof(TabRendererMetro);
                    this.PrimitivesTabControl.FixedSingleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(157)))), ((int)(((byte)(161)))));
                    foreach (TabPageAdv tabpage in this.PrimitivesTabControl.TabPages)
                    {
                        if (tabpage != null)
                        {
                            tabpage.BackColor = System.Drawing.Color.White;
                            tabpage.ForeColor = SystemColors.ControlText;
                        }
                    }
                }
            }
            LockWindowUpdate(IntPtr.Zero);
        }

        private void Properties_CheckChanged(object sender, EventArgs e)
        {
            CheckBoxAdv checkBox = (CheckBoxAdv)sender;

            switch (checkBox.Tag as string)
            {
                case "themes":
                    FormTabControl.ThemesEnabled = checkBox14.Checked;
                    break;
                case "imagealign":
                    if (checkBox11.Checked)
                        FormTabControl.ImageAlignmentR = RelativeImageAlignment.LeftOfText;
                    else
                        FormTabControl.ImageAlignmentR = RelativeImageAlignment.RightOfText;
                    break;
                case "scrolls":
                    FormTabControl.ShowScroll = checkBox13.Checked;
                    break;
                case "outsidebounds":
                    if (checkBox17.Checked)
                    {
                        FormTabControl.ImageOffset = 10;
                    }
                    else
                    {
                        FormTabControl.ImageOffset = 0;
                    }
                    if (this.FormTabControl.Alignment == TabAlignment.Left || this.FormTabControl.Alignment == TabAlignment.Right)
                        FormTabControl.LevelTextAndImage = false;
                    else
                        FormTabControl.LevelTextAndImage = checkBox17.Checked;
                    break;
                case "inactiveimage":
                    FormTabControl.DisableInactivePageImage = checkBox10.Checked;
                    break;
                case "rotatetext":
                    FormTabControl.RotateTextWhenVertical = checkBox12.Checked;
                    break;
                case "persist":
                    FormTabControl.PersistTabState = checkBox16.Checked;
                    break;
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            FormTabControl.TabGap = (int)numericUpDown1.Value;
        }

        // Tab Alignment
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox2.SelectedIndex)
            {
                case 0:
                    FormTabControl.Alignment = TabAlignment.Top;
                    FormTabControl.LevelTextAndImage = true;
                    break;
                case 1:
                    FormTabControl.Alignment = TabAlignment.Left;
                    FormTabControl.LevelTextAndImage = false;
                    break;
                case 2:
                    FormTabControl.Alignment = TabAlignment.Bottom;
                    FormTabControl.LevelTextAndImage = true;
                    break;
                case 3:
                    FormTabControl.Alignment = TabAlignment.Right;
                    FormTabControl.LevelTextAndImage = false;
                    break;
            }
            checkBox17.Checked = FormTabControl.LevelTextAndImage;
        }


        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox3.SelectedIndex)
            {
                case 0:
                    FormTabControl.BorderStyle = BorderStyle.None;
                    break;
                case 1:
                    FormTabControl.BorderStyle = BorderStyle.FixedSingle;
                    break;
                case 2:
                    FormTabControl.BorderStyle = BorderStyle.Fixed3D;
                    break;
            }
        } 
        #endregion

        #region Custom ContextMenu
        private void contextMenuStripEx1_Opening(object sender, CancelEventArgs e)
        {
            if (FormTabControl.GetTabRect(FormTabControl.SelectedIndex).Contains(tabPoint)
                && contextMenuCheck.Checked)
            {

                if (this.FormTabControl.TabStyle == typeof(TabRendererOffice2016Colorful))
                {
                    contextMenuStripEx1.Style = ContextMenuStripEx.ContextMenuStyle.Office2016Colorful;
                }
                else if (this.FormTabControl.TabStyle == typeof(TabRendererOffice2016White))
                {
                    contextMenuStripEx1.Style = ContextMenuStripEx.ContextMenuStyle.Office2016White;
                }
                else if (this.FormTabControl.TabStyle == typeof(TabRendererOffice2016DarkGray))
                {
                    contextMenuStripEx1.Style = ContextMenuStripEx.ContextMenuStyle.Office2016DarkGray;
                }
                else if (this.FormTabControl.TabStyle == typeof(TabRendererOffice2016Black))
                {
                    contextMenuStripEx1.Style = ContextMenuStripEx.ContextMenuStyle.Office2016Black;
                }
                contextMenuStripEx1.Show();
                tabPoint = Point.Empty;
            }
            else
                e.Cancel = true;
        }

        private void FormTabControl_MouseDown(object sender, MouseEventArgs e)
        {
            if(contextMenuCheck.Checked)
                tabPoint = new Point(e.X, e.Y);
        }

        private void addTabToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TabPageAdv tabPage = new TabPageAdv("New Tab");
            tabPage.ImageIndex = 3;
            FormTabControl.TabPages.Add(tabPage);
        }  
        #endregion

        #region Behavior Tab
        private void Behavior_CheckChanged(object sender, EventArgs e)
        {
            CheckBoxAdv checkBox = (CheckBoxAdv)sender;
            switch (checkBox.Tag as string)
            {
                case "focus":
                    BehaviorTabControl.FocusOnTabClick = checkBox18.Checked;
                    break;
                case "hottrack":
                    BehaviorTabControl.HotTrack = checkBox19.Checked;
                    break;
                case "multiline":
                    BehaviorTabControl.Focus();
                    BehaviorTabControl.Multiline = checkBox20.Checked;
                    break;
                case "labeledit":
                    BehaviorTabControl.LabelEdit = checkBox24.Checked;
                    break;
                case "tooltips":
                    BehaviorTabControl.ShowToolTips = checkBox22.Checked;
                    break;
                case "movetabs":
                    BehaviorTabControl.UserMoveTabs = checkBox23.Checked;
                    break;
                case "frontrow":
                    BehaviorTabControl.KeepSelectedTabInFrontRow = checkBox21.Checked;
                    break;
            }
        } 
        #endregion

        #region Events
        private void BehaviorTabControl_SelectedIndexChanging(object sender, SelectedIndexChangingEventArgs args)
        {
            if (args.NewSelectedIndex >= 0)
            EventsList("Selected Index Changing: " + BehaviorTabControl.TabPages[args.NewSelectedIndex].Text);
            
        }

        private void BehaviorTabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (BehaviorTabControl.SelectedIndex >= 0)
            EventsList("Selected Index Changed: " + BehaviorTabControl.SelectedTab.Text);
        }

        private void BehaviorTabControl_BeforeEdit(object sender, EditEventArgs e)
        {
            EventsList("Before Edit: " + e.EditText);
        }

        private void BehaviorTabControl_AfterEdit(object sender, EditEventArgs e)
        {
            EventsList("After Edit: " + e.EditText);
        }

        private void BehaviorTabControl_LabelEditChanged(object sender, EventArgs e)
        {
            EventsList("Label Edit changed");
        }

        private void BehaviorTabControl_LabelEditTextChanged(object sender, EventArgs e)
        {
            EventsList("Label Edit Text changed");
        }

        private void EventsList(object item)
        {
            listBox1.Items.Add(item);
            listBox1.SetSelected(listBox1.Items.Count - 1, true);
            listBox1.SetSelected(listBox1.Items.Count - 1, false);
        }
        private void buttonEdit1_ButtonClicked_1(object sender, ButtonClickedEventArgs args)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                activeTabColorEdit.BackColor = colorDialog1.Color;

            }
        }
        #endregion

        #region Close Button
        private void checkBox25_CheckedChanged(object sender, EventArgs e)
        {
            BehaviorTabControl.ShowTabCloseButton = checkBox25.Checked;
        }

        private void checkBox15_CheckedChanged(object sender, EventArgs e)
        {
           //Shows close button for Active tab only
            BehaviorTabControl.ShowCloseButtonForActiveTabOnly = checkBox15.Checked;
        }
        #endregion

        private void checkBox26_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox26.Checked)
            {
                tab3.ImageIndex = -1;
                tab4.ImageIndex = -1;
                tab6.ImageIndex = -1;
               
                checkBox10.Enabled = false;
                checkBox17.Checked = false;
                FormTabControl.ItemSize = new Size(108, 33);
            }
            else
            {
                checkBox10.Enabled = true;
            tab3.ImageIndex=1;
            tab4.ImageIndex=2;
            tab6.ImageIndex = 0;
            }
        }

        private void TabControlAdvFrame_Load_1(object sender, EventArgs e)
        {

        }

        private void checkBox10_CheckStateChanged(object sender, EventArgs e)
        {

        }

        private void tabPageAdv7_Click(object sender, EventArgs e)
        {

        }

        private void checkBox16_CheckStateChanged(object sender, EventArgs e)
        {

        }

        private void contextMenuCheck_CheckStateChanged(object sender, EventArgs e)
        {

        }

        private void checkBox14_CheckStateChanged(object sender, EventArgs e)
        {

        }

        private void checkBox13_CheckStateChanged(object sender, EventArgs e)
        {

        }

        private void checkBox12_CheckStateChanged(object sender, EventArgs e)
        {

        }

        private void checkBox5_CheckStateChanged(object sender, EventArgs e)
        {

        }

        private void FormTabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (FormTabControl.SelectedIndex == 1 && BehaviorTabControl.TabCount > 1)
            {
                BehaviorTabControl.SelectedIndex = 1;
                BehaviorTabControl.SelectedIndex = 0;
            }
        }
     
        #region Creating TabControlAdv dynamically
        //		private void InitMyTabs()
//		{
//			this.tabControl1 = new TabControlAdv();
//			this.tabPage1 = new TabPageAdv();
//			this.tabPage2 = new TabPageAdv();
//			this.tabPage3 = new TabPageAdv();
// 
//			// Positions tabs on the left side of tabControl1.
//			// this.tabControl1.Alignment = System.Windows.Forms.TabAlignment.Left;
//       
//			// Sets the tabs to appear in 2D mode.
//			tabControl1.TabStyle = typeof(TabRenderer2D);
//
//			// Highlights TabPage.Text when the mouse passes over tabs.
//			this.tabControl1.HotTrack = true;
//
//			// Set the relative alignment between the images and text in a tab
//			this.tabControl1.ImageAlignmentR = RelativeImageAlignment.BelowText;
//
//			// Allows more than one row of tabs.
//			// this.tabControl1.Multiline = true;
//
//			// Creates a cushion of 22 pixels around TabPage.Text strings.
//			this.tabControl1.Padding = new System.Drawing.Point(22, 22);
//
//			// Makes the tab width definable. 
//			this.tabControl1.SizeMode = Syncfusion.Windows.Forms.Tools.TabSizeMode.Fixed;
//
//			// Sizes the tabs of tabControl1.
//			this.tabControl1.ItemSize = new Size(90, 64); // Make sure to take into account the padding values.
//
//			// To rotate text when aligned vertically.
//			this.tabControl1.RotateTextWhenVertical = true;
//
//			// Allows the user to move the tabs by simply dragging and dropping
//			this.tabControl1.UserMoveTabs = true;
//
//			// Draws the scroll buttons Visual Studio MDI Tabs like.
//			this.tabControl1.VSLikeScrollButton = true;
//
//			this.tabControl1.Controls.AddRange(new Control[] { this.tabPage1, this.tabPage2, this.tabPage3});
//			this.tabControl1.Location = new Point(16, 24);
//			this.tabControl1.SelectedIndex = 0;
//			this.tabControl1.Size = new Size(248, 232);
// 
//			this.tabPage1.Text = "Tab1";
//			this.tabPage2.Text = "Tab2";
//			this.tabPage3.Text = "Tab3";
//			this.Size = new Size(300,300);
//			this.Controls.AddRange(new Control[] { this.tabControl1});
//
//			// Selects tabPage1 using SelectedIndex.
//			this.tabControl1.SelectedIndex = 1;
//
//			// Shows ToolTipText when the mouse passes over tabs.
//			this.tabControl1.ShowToolTips = true;
//		}
#endregion
	}
}

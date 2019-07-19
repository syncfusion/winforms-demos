#region Copyright Syncfusion Inc. 2001-2017.
// Copyright Syncfusion Inc. 2001-2017. All rights reserved.
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
using System.Data;

using Syncfusion.Windows.Forms.Tools;
using Syncfusion.Windows.Forms;
using System.IO;
using Syncfusion.Licensing;

namespace ColorUIDemo
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : MetroForm
	{
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ImageList imageList1;
        private TextBoxExt textBox1;
        private Syncfusion.Windows.Forms.ColorUIControl colorUIControl1;
		private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv cmbSelectedColorGroup;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label14;
		private Syncfusion.Windows.Forms.Tools.TextBoxExt txtUsersTabName1;
		private Syncfusion.Windows.Forms.Tools.TextBoxExt txtSystemTabName1;
		private Syncfusion.Windows.Forms.Tools.TextBoxExt txtStandardTabName1;
		private Syncfusion.Windows.Forms.Tools.TextBoxExt txtCustomTabName1;
		private Syncfusion.Windows.Forms.Tools.ComboBoxAdv cmbSelectedColorGroup1;
        private Syncfusion.Windows.Forms.Tools.CheckBoxAdv chkUserColorsStretchOnResize;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv cmbOffice2007Theme;
        private Panel panel3;
        private SplitContainerAdv splitContainerAdv1;
        private Label label2;
        private ComboBoxAdv comboBoxAdv1;
        private Label label4;
        private System.ComponentModel.IContainer components;

		public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
            
            try
            {
                System.Drawing.Icon ico = new System.Drawing.Icon(GetIconFile(@"common\Images\Grid\Icon\sfgrid.ico"));
                this.Icon = ico;
            }
            catch { }
            this.comboBoxAdv1.SelectedIndex = 3;
            
            //
			// TODO: Add any constructor code after InitializeComponent call
			//
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
            Syncfusion.Windows.Forms.MetroColorTable metroColorTable2 = new Syncfusion.Windows.Forms.MetroColorTable();
            this.label1 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.textBox1 = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.panel3 = new System.Windows.Forms.Panel();
            this.splitContainerAdv1 = new Syncfusion.Windows.Forms.Tools.SplitContainerAdv();
            this.label2 = new System.Windows.Forms.Label();
            this.colorUIControl1 = new Syncfusion.Windows.Forms.ColorUIControl();
            this.panel2 = new System.Windows.Forms.Panel();
            this.comboBoxAdv1 = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.label4 = new System.Windows.Forms.Label();
            this.chkUserColorsStretchOnResize = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.txtUsersTabName1 = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.label14 = new System.Windows.Forms.Label();
            this.txtSystemTabName1 = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.txtStandardTabName1 = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.txtCustomTabName1 = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.cmbSelectedColorGroup1 = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbSelectedColorGroup = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.cmbOffice2007Theme = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerAdv1)).BeginInit();
            this.splitContainerAdv1.Panel1.SuspendLayout();
            this.splitContainerAdv1.Panel2.SuspendLayout();
            this.splitContainerAdv1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxAdv1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkUserColorsStretchOnResize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUsersTabName1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSystemTabName1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStandardTabName1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCustomTabName1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbSelectedColorGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbSelectedColorGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbOffice2007Theme)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.label1.ImageList = this.imageList1;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(2);
            this.label1.Size = new System.Drawing.Size(687, 57);
            this.label1.TabIndex = 0;
            this.label1.Text = resources.GetString("label1.Text");
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "");
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.textBox1.Location = new System.Drawing.Point(20, 421);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(687, 116);
            this.textBox1.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(20, 20);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(687, 57);
            this.panel3.TabIndex = 5;
            // 
            // splitContainerAdv1
            // 
            this.splitContainerAdv1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainerAdv1.BeforeTouchSize = 7;
            this.splitContainerAdv1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainerAdv1.Location = new System.Drawing.Point(20, 83);
            this.splitContainerAdv1.Name = "splitContainerAdv1";
            // 
            // splitContainerAdv1.Panel1
            // 
            this.splitContainerAdv1.Panel1.Controls.Add(this.label2);
            this.splitContainerAdv1.Panel1.Controls.Add(this.colorUIControl1);
            // 
            // splitContainerAdv1.Panel2
            // 
            this.splitContainerAdv1.Panel2.Controls.Add(this.panel2);
            this.splitContainerAdv1.Size = new System.Drawing.Size(687, 331);
            this.splitContainerAdv1.SplitterDistance = 348;
            this.splitContainerAdv1.TabIndex = 6;
            this.splitContainerAdv1.Text = "splitContainerAdv1";
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(3, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 33);
            this.label2.TabIndex = 24;
            this.label2.Text = "Sample";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // colorUIControl1
            // 
            this.colorUIControl1.BeforeTouchSize = new System.Drawing.Size(274, 243);
            this.colorUIControl1.ColorGroups = ((Syncfusion.Windows.Forms.ColorUIGroups)((((Syncfusion.Windows.Forms.ColorUIGroups.CustomColors | Syncfusion.Windows.Forms.ColorUIGroups.StandardColors) 
            | Syncfusion.Windows.Forms.ColorUIGroups.SystemColors) 
            | Syncfusion.Windows.Forms.ColorUIGroups.UserColors)));
            this.colorUIControl1.CustomColorsStretchOnResize = true;
            this.colorUIControl1.Flag = false;
            this.colorUIControl1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.colorUIControl1.Location = new System.Drawing.Point(32, 57);
            this.colorUIControl1.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218)))));
            this.colorUIControl1.MetroForeColor = System.Drawing.Color.White;
            this.colorUIControl1.Name = "colorUIControl1";
            metroColorTable2.ArrowChecked = System.Drawing.Color.Black;
            metroColorTable2.ArrowCheckedBorderColor = System.Drawing.Color.Empty;
            metroColorTable2.ArrowInActive = System.Drawing.Color.White;
            metroColorTable2.ArrowNormal = System.Drawing.Color.Gray;
            metroColorTable2.ArrowNormalBackGround = System.Drawing.Color.Empty;
            metroColorTable2.ArrowNormalBorderColor = System.Drawing.Color.Empty;
            metroColorTable2.ArrowPushed = System.Drawing.Color.Black;
            metroColorTable2.ArrowPushedBackGround = System.Drawing.Color.Empty;
            metroColorTable2.ArrowPushedBorderColor = System.Drawing.Color.Empty;
            metroColorTable2.ScrollerBackground = System.Drawing.Color.White;
            metroColorTable2.ThumbChecked = System.Drawing.Color.Black;
            metroColorTable2.ThumbCheckedBorderColor = System.Drawing.Color.Empty;
            metroColorTable2.ThumbInActive = System.Drawing.Color.White;
            metroColorTable2.ThumbNormal = System.Drawing.Color.Gray;
            metroColorTable2.ThumbNormalBorderColor = System.Drawing.Color.Empty;
            metroColorTable2.ThumbPushed = System.Drawing.Color.Black;
            metroColorTable2.ThumbPushedBorder = System.Drawing.Color.Empty;
            metroColorTable2.ThumbPushedBorderColor = System.Drawing.Color.Empty;
            this.colorUIControl1.ScrollMetroColorTable = metroColorTable2;
            this.colorUIControl1.SelectedColor = System.Drawing.SystemColors.ControlDarkDark;
            this.colorUIControl1.SelectedColorGroup = Syncfusion.Windows.Forms.ColorUISelectedGroup.CustomColors;
            this.colorUIControl1.ShowUserSelectionColors = true;
            this.colorUIControl1.Size = new System.Drawing.Size(274, 243);
            this.colorUIControl1.TabIndex = 0;
            this.colorUIControl1.Text = "colorUIControl1";
            this.colorUIControl1.VisualStyle = Syncfusion.Windows.Forms.ColorUIStyle.Metro;
            this.colorUIControl1.ColorSelected += new System.EventHandler(this.colorUIControl1_ColorSelected);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.comboBoxAdv1);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.chkUserColorsStretchOnResize);
            this.panel2.Controls.Add(this.txtUsersTabName1);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.txtSystemTabName1);
            this.panel2.Controls.Add(this.txtStandardTabName1);
            this.panel2.Controls.Add(this.txtCustomTabName1);
            this.panel2.Controls.Add(this.cmbSelectedColorGroup1);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(330, 329);
            this.panel2.TabIndex = 2;
            // 
            // comboBoxAdv1
            // 
            this.comboBoxAdv1.BackColor = System.Drawing.Color.White;
            this.comboBoxAdv1.BeforeTouchSize = new System.Drawing.Size(121, 21);
            this.comboBoxAdv1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAdv1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxAdv1.Items.AddRange(new object[] {
            "Default",
            "Office2010",
            "Metro",
            "Office2016Colorful",
            "Office2016DarkGray",
            "Office2016Black",
            "Office2016White"
            });
            this.comboBoxAdv1.Location = new System.Drawing.Point(176, 252);
            this.comboBoxAdv1.Name = "comboBoxAdv1";
            this.comboBoxAdv1.Size = new System.Drawing.Size(121, 21);
            this.comboBoxAdv1.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.comboBoxAdv1.TabIndex = 25;
            this.comboBoxAdv1.Text = "Default";
            this.comboBoxAdv1.SelectedIndexChanged += new System.EventHandler(this.comboBoxAdv1_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 252);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Visual Style";
            // 
            // chkUserColorsStretchOnResize
            // 
            this.chkUserColorsStretchOnResize.BeforeTouchSize = new System.Drawing.Size(150, 21);
            this.chkUserColorsStretchOnResize.DrawFocusRectangle = false;
            this.chkUserColorsStretchOnResize.Location = new System.Drawing.Point(69, 291);
            this.chkUserColorsStretchOnResize.MetroColor = System.Drawing.Color.Gray;
            this.chkUserColorsStretchOnResize.Name = "chkUserColorsStretchOnResize";
            this.chkUserColorsStretchOnResize.Size = new System.Drawing.Size(227, 24);
            this.chkUserColorsStretchOnResize.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.chkUserColorsStretchOnResize.TabIndex = 23;
            this.chkUserColorsStretchOnResize.Text = "User Color Stretch On Resize";
            this.chkUserColorsStretchOnResize.ThemesEnabled = false;
            this.chkUserColorsStretchOnResize.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // txtUsersTabName1
            // 
            this.txtUsersTabName1.BeforeTouchSize = new System.Drawing.Size(120, 22);
            this.txtUsersTabName1.BorderColor = System.Drawing.Color.Gray;
            this.txtUsersTabName1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsersTabName1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUsersTabName1.Location = new System.Drawing.Point(176, 188);
            this.txtUsersTabName1.Metrocolor = System.Drawing.Color.Gray;
            this.txtUsersTabName1.Name = "txtUsersTabName1";
            this.txtUsersTabName1.Size = new System.Drawing.Size(120, 22);
            this.txtUsersTabName1.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Metro;
            this.txtUsersTabName1.TabIndex = 22;
            this.txtUsersTabName1.Text = "User Colors";
            this.txtUsersTabName1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUsersTabName1_KeyDown);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(48, 188);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(87, 13);
            this.label14.TabIndex = 21;
            this.label14.Text = "Users Tab Name";
            // 
            // txtSystemTabName1
            // 
            this.txtSystemTabName1.BeforeTouchSize = new System.Drawing.Size(120, 22);
            this.txtSystemTabName1.BorderColor = System.Drawing.Color.Gray;
            this.txtSystemTabName1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSystemTabName1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSystemTabName1.Location = new System.Drawing.Point(176, 156);
            this.txtSystemTabName1.Metrocolor = System.Drawing.Color.Gray;
            this.txtSystemTabName1.Name = "txtSystemTabName1";
            this.txtSystemTabName1.Size = new System.Drawing.Size(120, 22);
            this.txtSystemTabName1.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Metro;
            this.txtSystemTabName1.TabIndex = 20;
            this.txtSystemTabName1.Text = "System";
            this.txtSystemTabName1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSystemTabName1_KeyDown);
            // 
            // txtStandardTabName1
            // 
            this.txtStandardTabName1.BeforeTouchSize = new System.Drawing.Size(120, 22);
            this.txtStandardTabName1.BorderColor = System.Drawing.Color.Gray;
            this.txtStandardTabName1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtStandardTabName1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtStandardTabName1.Location = new System.Drawing.Point(176, 124);
            this.txtStandardTabName1.Metrocolor = System.Drawing.Color.Gray;
            this.txtStandardTabName1.Name = "txtStandardTabName1";
            this.txtStandardTabName1.Size = new System.Drawing.Size(120, 22);
            this.txtStandardTabName1.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Metro;
            this.txtStandardTabName1.TabIndex = 19;
            this.txtStandardTabName1.Text = "Web";
            this.txtStandardTabName1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtStandardTabName1_KeyDown);
            // 
            // txtCustomTabName1
            // 
            this.txtCustomTabName1.BeforeTouchSize = new System.Drawing.Size(120, 22);
            this.txtCustomTabName1.BorderColor = System.Drawing.Color.Gray;
            this.txtCustomTabName1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCustomTabName1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCustomTabName1.Location = new System.Drawing.Point(176, 92);
            this.txtCustomTabName1.Metrocolor = System.Drawing.Color.Gray;
            this.txtCustomTabName1.Name = "txtCustomTabName1";
            this.txtCustomTabName1.Size = new System.Drawing.Size(120, 22);
            this.txtCustomTabName1.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Metro;
            this.txtCustomTabName1.TabIndex = 18;
            this.txtCustomTabName1.Text = "Palette";
            this.txtCustomTabName1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCustomTabName1_KeyDown);
            // 
            // cmbSelectedColorGroup1
            // 
            this.cmbSelectedColorGroup1.BackColor = System.Drawing.Color.White;
            this.cmbSelectedColorGroup1.BeforeTouchSize = new System.Drawing.Size(121, 21);
            this.cmbSelectedColorGroup1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSelectedColorGroup1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSelectedColorGroup1.Items.AddRange(new object[] {
            "None",
            "CustomColors",
            "StandardColors",
            "SystemColors",
            "UserColors"});
            this.cmbSelectedColorGroup1.Location = new System.Drawing.Point(176, 220);
            this.cmbSelectedColorGroup1.Name = "cmbSelectedColorGroup1";
            this.cmbSelectedColorGroup1.Size = new System.Drawing.Size(121, 21);
            this.cmbSelectedColorGroup1.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.cmbSelectedColorGroup1.TabIndex = 17;
            this.cmbSelectedColorGroup1.Text = "None";
            this.cmbSelectedColorGroup1.SelectedIndexChanged += new System.EventHandler(this.cmbSelectedColorGroup1_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(48, 220);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(117, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "Selected Color Group";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(48, 156);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(94, 13);
            this.label11.TabIndex = 15;
            this.label11.Text = "System Tab Name";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(48, 124);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(106, 13);
            this.label12.TabIndex = 14;
            this.label12.Text = "Standard Tab Name";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(48, 92);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(98, 13);
            this.label13.TabIndex = 13;
            this.label13.Text = "Custom Tab Name";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(3, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 32);
            this.label3.TabIndex = 0;
            this.label3.Text = "Essential Properties";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbSelectedColorGroup
            // 
            this.cmbSelectedColorGroup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(242)))), ((int)(((byte)(251)))));
            this.cmbSelectedColorGroup.BeforeTouchSize = new System.Drawing.Size(121, 21);
            this.cmbSelectedColorGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSelectedColorGroup.Location = new System.Drawing.Point(164, 251);
            this.cmbSelectedColorGroup.Name = "cmbSelectedColorGroup";
            this.cmbSelectedColorGroup.Size = new System.Drawing.Size(121, 21);
            this.cmbSelectedColorGroup.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007;
            this.cmbSelectedColorGroup.TabIndex = 9;
            // 
            // cmbOffice2007Theme
            // 
            this.cmbOffice2007Theme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(242)))), ((int)(((byte)(251)))));
            this.cmbOffice2007Theme.BeforeTouchSize = new System.Drawing.Size(98, 21);
            this.cmbOffice2007Theme.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOffice2007Theme.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbOffice2007Theme.Location = new System.Drawing.Point(164, 150);
            this.cmbOffice2007Theme.Name = "cmbOffice2007Theme";
            this.cmbOffice2007Theme.Size = new System.Drawing.Size(98, 21);
            this.cmbOffice2007Theme.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007;
            this.cmbOffice2007Theme.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 15);
            this.BackColor = System.Drawing.Color.White;
            this.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.ClientSize = new System.Drawing.Size(727, 557);
            this.Controls.Add(this.splitContainerAdv1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.textBox1);
            this.DropShadow = true;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(739, 593);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Color UI Controls";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel3.ResumeLayout(false);
            this.splitContainerAdv1.Panel1.ResumeLayout(false);
            this.splitContainerAdv1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerAdv1)).EndInit();
            this.splitContainerAdv1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxAdv1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkUserColorsStretchOnResize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUsersTabName1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSystemTabName1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStandardTabName1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCustomTabName1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbSelectedColorGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbSelectedColorGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbOffice2007Theme)).EndInit();
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
            Application.Run(new Form1());
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


        #region FormLoad

        Panel splitPanel1 = new Panel();

        Panel splitPanel2 = new Panel();
        private void Form1_Load(object sender, System.EventArgs e)
		{
			this.cmbSelectedColorGroup1.SelectedIndex=0;
            this.colorUIControl1.BringToFront();
            this.label2.BorderStyle = BorderStyle.None;
            this.label3.BorderStyle = BorderStyle.None;
            this.splitContainerAdv1.BorderStyle = BorderStyle.None;

            this.splitContainerAdv1.Panel1.Controls.Add(this.splitPanel1);

            this.splitPanel1.Dock = DockStyle.Fill;
            this.splitPanel1.BorderStyle = BorderStyle.None;

            
            this.splitContainerAdv1.BorderStyle = BorderStyle.None;

            this.panel2.BorderStyle = BorderStyle.None;
            this.panel2.Paint += Panel2_Paint;
            this.splitPanel1.Paint += SplitPanel1_Paint;
            //this.panel3.Paint += Panel3_Paint;
            this.label1.BorderStyle = BorderStyle.None;
            this.label1.Paint += Label1_Paint;
        }

        private void Label1_Paint(object sender, PaintEventArgs e)
        {
            if (this.colorUIControl1.VisualStyle == ColorUIStyle.Office2016DarkGray)
                ControlPaint.DrawBorder(e.Graphics, this.label1.DisplayRectangle, ColorTranslator.FromHtml("#444444"), ButtonBorderStyle.Solid);
            else if (this.colorUIControl1.VisualStyle == ColorUIStyle.Office2016Black)
                ControlPaint.DrawBorder(e.Graphics, this.label1.DisplayRectangle, ColorTranslator.FromHtml("#444444"), ButtonBorderStyle.Solid);
            else if (this.colorUIControl1.VisualStyle == ColorUIStyle.Office2016Colorful || this.colorUIControl1.VisualStyle == ColorUIStyle.Office2016White)
                ControlPaint.DrawBorder(e.Graphics, this.label1.DisplayRectangle, ColorTranslator.FromHtml("#c6c6c6"), ButtonBorderStyle.Solid);
            else
                ControlPaint.DrawBorder(e.Graphics, this.label1.ClientRectangle, Color.Gray, ButtonBorderStyle.Solid);
        }

        private void Panel3_Paint(object sender, PaintEventArgs e)
        {
            if (this.colorUIControl1.VisualStyle == ColorUIStyle.Office2016DarkGray)
                ControlPaint.DrawBorder(e.Graphics, this.panel3.DisplayRectangle, ColorTranslator.FromHtml("#444444"), ButtonBorderStyle.Solid);
            else if (this.colorUIControl1.VisualStyle == ColorUIStyle.Office2016Black)
                ControlPaint.DrawBorder(e.Graphics, this.panel3.DisplayRectangle, ColorTranslator.FromHtml("#444444"), ButtonBorderStyle.Solid);
            else if (this.colorUIControl1.VisualStyle == ColorUIStyle.Office2016Colorful || this.colorUIControl1.VisualStyle == ColorUIStyle.Office2016White)
                ControlPaint.DrawBorder(e.Graphics, this.panel3.DisplayRectangle, ColorTranslator.FromHtml("#c6c6c6"), ButtonBorderStyle.Solid);
            else
                ControlPaint.DrawBorder(e.Graphics, this.panel3.ClientRectangle, Color.Gray, ButtonBorderStyle.Solid);
        }

        private void SplitPanel1_Paint(object sender, PaintEventArgs e)
        {
            if (this.colorUIControl1.VisualStyle == ColorUIStyle.Office2016DarkGray)
                ControlPaint.DrawBorder(e.Graphics, this.splitPanel1.DisplayRectangle, ColorTranslator.FromHtml("#444444"), ButtonBorderStyle.Solid);
            else if (this.colorUIControl1.VisualStyle == ColorUIStyle.Office2016Black)
                ControlPaint.DrawBorder(e.Graphics, this.splitPanel1.DisplayRectangle, ColorTranslator.FromHtml("#444444"), ButtonBorderStyle.Solid);
            else if (this.colorUIControl1.VisualStyle == ColorUIStyle.Office2016Colorful || this.colorUIControl1.VisualStyle == ColorUIStyle.Office2016White)
                ControlPaint.DrawBorder(e.Graphics, this.splitPanel1.DisplayRectangle, ColorTranslator.FromHtml("#c6c6c6"), ButtonBorderStyle.Solid);
            else
                ControlPaint.DrawBorder(e.Graphics, this.splitPanel1.ClientRectangle, Color.Gray, ButtonBorderStyle.Solid);
        }

        private void Panel2_Paint(object sender, PaintEventArgs e)
        {
            if (this.colorUIControl1.VisualStyle == ColorUIStyle.Office2016DarkGray)
                ControlPaint.DrawBorder(e.Graphics, this.panel2.DisplayRectangle, ColorTranslator.FromHtml("#444444"), ButtonBorderStyle.Solid);
            else if (this.colorUIControl1.VisualStyle == ColorUIStyle.Office2016Black)
                ControlPaint.DrawBorder(e.Graphics, this.panel2.DisplayRectangle, ColorTranslator.FromHtml("#444444"), ButtonBorderStyle.Solid);
            else if (this.colorUIControl1.VisualStyle == ColorUIStyle.Office2016Colorful || this.colorUIControl1.VisualStyle == ColorUIStyle.Office2016White)
                ControlPaint.DrawBorder(e.Graphics, this.panel2.DisplayRectangle, ColorTranslator.FromHtml("#c6c6c6"), ButtonBorderStyle.Solid);
            else
                ControlPaint.DrawBorder(e.Graphics, this.panel2.ClientRectangle, Color.Gray, ButtonBorderStyle.Solid);

        }

        #endregion

        #region EventLog

        private void Addlog(string logText)
		{
			this.textBox1.Text += logText +"\r\n";
		}
		#endregion

		#region ColorUIControl Properties

		private void colorUIControl1_ColorSelected(object sender, System.EventArgs e)
		{
			this.splitContainerAdv1.Panel1.BackColor = this.colorUIControl1.SelectedColor;
			Addlog("ColorUIControl sets TabPage BackColor to "+this.colorUIControl1.SelectedColor.ToString());
		}

		private void cmbSelectedColorGroup1_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			switch(this.cmbSelectedColorGroup1.Text)
			{
				case "None":
					this.colorUIControl1.SelectedColorGroup = Syncfusion.Windows.Forms.ColorUISelectedGroup.None;
					break;
				case "CustomColors":
					this.colorUIControl1.SelectedColorGroup = Syncfusion.Windows.Forms.ColorUISelectedGroup.CustomColors;
					break;
				case "StandardColors":
					this.colorUIControl1.SelectedColorGroup = Syncfusion.Windows.Forms.ColorUISelectedGroup.StandardColors;
					break;
				case "SystemColors":
					this.colorUIControl1.SelectedColorGroup = Syncfusion.Windows.Forms.ColorUISelectedGroup.SystemColors;
					break;
				case "UserColors":
					this.colorUIControl1.SelectedColorGroup = Syncfusion.Windows.Forms.ColorUISelectedGroup.UserColors;
					break;
			}
			Addlog("ColorUIControl's Selected Color Group changed to "+this.cmbSelectedColorGroup1.Text);
		}

		private void txtCustomTabName1_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if(e.KeyCode == Keys.Enter)
			{
				this.colorUIControl1.CustomTabName = this.txtCustomTabName1.Text;
				Addlog("ColorUIControl's Custom Tab Name changed to "+this.txtCustomTabName1.Text);
			}
		}

		private void txtStandardTabName1_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if(e.KeyCode == Keys.Enter)
			{
				this.colorUIControl1.StandardTabName = this.txtStandardTabName1.Text;
				Addlog("ColorUIControl's Standard Tab Name changed to "+this.txtStandardTabName1.Text);
			}
		}

		private void txtSystemTabName1_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if(e.KeyCode == Keys.Enter)
			{
				this.colorUIControl1.SystemTabName = this.txtSystemTabName1.Text;
				Addlog("ColorUIControl's System Tab Name changed to "+this.txtSystemTabName1.Text);
			}
		}

		private void txtUsersTabName1_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if(e.KeyCode == Keys.Enter)
			{
				this.colorUIControl1.UserTabName = this.txtUsersTabName1.Text;
				Addlog("ColorUIControl's User Tab Name changed to "+this.txtUsersTabName1.Text);
			}
		}

		private void checkBox1_CheckedChanged(object sender, System.EventArgs e)
		{
			this.colorUIControl1.UserColorsStretchOnResize = this.chkUserColorsStretchOnResize.Checked;
		}

        #endregion

        private void comboBoxAdv1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (this.comboBoxAdv1.Text)
            {
                case "Default":
                    this.colorUIControl1.VisualStyle = ColorUIStyle.Default;
                    this.CaptionBarColor = Color.White;
                    this.MetroColor = Color.White;
                    this.CaptionForeColor = Color.Black;
                    this.CaptionButtonColor = Color.Black;
                    this.CaptionButtonHoverColor = Color.Black;
                    this.BackColor = Color.White;
                    this.ForeColor = Color.Black;
                    this.colorUIControl1.BorderStyle = BorderStyle.FixedSingle;
                    this.label1.BackColor = Color.White;
                    this.label1.ForeColor = Color.Black;
                    this.label2.ForeColor = Color.Black;
                    this.label3.ForeColor = Color.Black;
                    SkinManager.SetVisualStyle(this.panel2, VisualTheme.Office2016White);
                    this.textBox1.Style = TextBoxExt.theme.Office2016White;
                    break;
                case "Office2010":
                    this.colorUIControl1.VisualStyle = ColorUIStyle.Office2010;
                    this.CaptionBarColor = Color.White;
                    this.MetroColor = Color.White;
                    this.CaptionForeColor = Color.Black;
                    this.CaptionButtonColor = Color.Black;
                    this.CaptionButtonHoverColor = Color.Black;
                    this.BackColor = Color.White;
                    this.ForeColor = Color.Black;
                    this.colorUIControl1.BorderStyle = BorderStyle.FixedSingle;
                    this.label1.BackColor = Color.White;
                    this.label1.ForeColor = Color.Black;
                    this.label2.ForeColor = Color.Black;
                    this.label3.ForeColor = Color.Black;
                    SkinManager.SetVisualStyle(this.panel2, VisualTheme.Office2016White);
                    this.textBox1.Style = TextBoxExt.theme.Office2016White;
                    break;
                case "Office2016Colorful":
                    this.colorUIControl1.VisualStyle = ColorUIStyle.Office2016Colorful;
                    this.CaptionBarColor = ColorTranslator.FromHtml("#0173c7");
                    this.MetroColor = ColorTranslator.FromHtml("#0173c7");
                    this.CaptionForeColor = Color.White;
                    this.CaptionButtonColor = Color.White;
                    this.CaptionButtonHoverColor = Color.White;
                    this.BackColor = Color.White;
                    this.ForeColor = Color.Black;
                    this.colorUIControl1.BorderStyle = BorderStyle.FixedSingle;
                    this.label1.BackColor = Color.White;
                    this.label1.ForeColor = Color.Black;
                    this.label2.ForeColor = Color.Black;
                    this.label3.ForeColor = Color.Black;
                    SkinManager.SetVisualStyle(this.panel2, VisualTheme.Office2016Colorful);
                    this.textBox1.Style = TextBoxExt.theme.Office2016White;
                    break;
                case "Office2016White":
                    this.colorUIControl1.VisualStyle = ColorUIStyle.Office2016White;
                    this.CaptionBarColor = Color.White;
                    this.MetroColor = Color.White;
                    this.CaptionForeColor = Color.Black;
                    this.CaptionButtonColor = Color.Black;
                    this.CaptionButtonHoverColor = Color.Black;
                    this.BackColor = Color.White;
                    this.ForeColor = Color.Black;
                    this.colorUIControl1.BorderStyle = BorderStyle.FixedSingle;
                    this.label1.BackColor = Color.White;
                    this.label1.ForeColor = Color.Black;
                    this.label2.ForeColor = Color.Black;
                    this.label3.ForeColor = Color.Black;
                    SkinManager.SetVisualStyle(this.panel2, VisualTheme.Office2016White);
                    this.textBox1.Style = TextBoxExt.theme.Office2016White;
                    break;
                case "Office2016Black":
                    this.colorUIControl1.VisualStyle = ColorUIStyle.Office2016Black;
                    this.CaptionBarColor = ColorTranslator.FromHtml("#363636");
                    this.MetroColor = ColorTranslator.FromHtml("#363636");
                    this.BackColor = ColorTranslator.FromHtml("#262626");
                    this.ForeColor = Color.White;
                    this.CaptionForeColor = Color.White;
                    this.CaptionButtonColor = Color.White;
                    this.CaptionButtonHoverColor = Color.White;
                    this.colorUIControl1.BorderStyle = BorderStyle.FixedSingle;
                    this.label1.BackColor = ColorTranslator.FromHtml("#262626");
                    this.label1.ForeColor = ColorTranslator.FromHtml("#ffffff");
                    this.label2.ForeColor = Color.White;
                    this.label3.ForeColor = Color.White;
                    SkinManager.SetVisualStyle(this.panel2, VisualTheme.Office2016Black);
                    this.textBox1.Style = TextBoxExt.theme.Office2016Black;
                    break;
                case "Office2016DarkGray":
                    this.colorUIControl1.VisualStyle = ColorUIStyle.Office2016DarkGray;
                    this.CaptionBarColor = ColorTranslator.FromHtml("#505050");
                    this.MetroColor = ColorTranslator.FromHtml("#505050");
                    this.CaptionForeColor = Color.White;
                    this.CaptionButtonColor = Color.Black;
                    this.CaptionButtonHoverColor = Color.Black;
                    this.BackColor = ColorTranslator.FromHtml("#666666");
                    this.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                    this.colorUIControl1.BorderStyle = BorderStyle.FixedSingle;
                    this.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                    this.label1.BackColor = ColorTranslator.FromHtml("#666666");
                    this.label1.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                    this.label2.ForeColor = Color.White;
                    this.label3.ForeColor = Color.White;
                    SkinManager.SetVisualStyle(this.panel2, VisualTheme.Office2016DarkGray);
                    this.textBox1.Style = TextBoxExt.theme.Office2016DarkGray;
                    break;
                case "Metro":
                    this.colorUIControl1.VisualStyle = ColorUIStyle.Metro;
                    this.CaptionBarColor = Color.White;
                    this.MetroColor = Color.White;
                    this.CaptionForeColor = Color.Black;
                    this.CaptionButtonColor = Color.Black;
                    this.CaptionButtonHoverColor = Color.Black;
                    this.BackColor = Color.White;
                    this.textBox1.BackColor = ColorTranslator.FromHtml("#ffffff");

                    this.ForeColor = Color.Black;
                    this.colorUIControl1.BorderStyle = BorderStyle.FixedSingle;
                    this.label1.BackColor = Color.White;
                    this.label1.ForeColor = Color.Black;
                    this.label2.ForeColor = Color.Black;
                    this.label3.ForeColor = Color.Black;
                    this.textBox1.Style = TextBoxExt.theme.Office2016White;
                    break;
            }

            Addlog("ColorPickerUIAdv's style set to " + this.colorUIControl1.VisualStyle.ToString());
        }
    }
}

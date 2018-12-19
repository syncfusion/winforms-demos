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
using Syncfusion.Windows.Forms.Tools;
using Syncfusion.Licensing;



namespace Syncfusion.Licensing
{
	public class Form1 : MetroForm
	{
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ImageList imageList1;
		private System.Windows.Forms.Panel groupBox3;
		private Syncfusion.Windows.Forms.Tools.RadioButtonAdv radioButton2;
        private Syncfusion.Windows.Forms.Tools.RadioButtonAdv radioButton1;
		private System.Windows.Forms.Label label3;
        private Syncfusion.Windows.Forms.Tools.NumericUpDownExt numericUpDown1;
		private Syncfusion.Windows.Forms.Tools.FontComboBox fontComboBox2;
		private System.Windows.Forms.ImageList imageList2;
		private Syncfusion.Windows.Forms.Tools.TextBoxExt textBoxExt1;
		private System.Windows.Forms.Panel groupBox1;
		private Syncfusion.Windows.Forms.Tools.FontComboBox fontComboBox1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Panel groupBox2;
        private System.Windows.Forms.Label label5;
        private Syncfusion.Windows.Forms.BannerTextProvider bannerTextProvider1;
        private Syncfusion.Windows.Forms.Tools.ButtonEdit bannerClrEdit;
        private Syncfusion.Windows.Forms.Tools.ButtonEditChildButton buttonEditChildButton1;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt textBoxExt2;
        private ButtonAdv btnSetBanner;
        private ComboBoxAdv cmbMode;
        private TextBox txtBanner;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private ColorDialog colorDialog1;
        private ToolTip toolTip1;
        private SplitContainerAdv splitContainerAdv1;
        private Label label12;
        private Label label11;
        private ImageList imageList3;
        private Label label10;
        private FontListBox fontListBox1;
		private System.ComponentModel.IContainer components;

		public Form1()
		{
			InitializeComponent();
            cmbMode.SelectedIndex = 1;
            Application.Idle += new EventHandler(Application_Idle);
            try
            {
                System.Drawing.Icon ico = new System.Drawing.Icon(GetIconFile(@"common\Images\Grid\Icon\sfgrid.ico"));
                this.Icon = ico;
            }
            catch { }
            this.MinimumSize = this.Size;
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
            this.label1 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.groupBox3 = new System.Windows.Forms.Panel();
            this.textBoxExt1 = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.label4 = new System.Windows.Forms.Label();
            this.bannerClrEdit = new Syncfusion.Windows.Forms.Tools.ButtonEdit();
            this.buttonEditChildButton1 = new Syncfusion.Windows.Forms.Tools.ButtonEditChildButton();
            this.textBoxExt2 = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.fontComboBox1 = new Syncfusion.Windows.Forms.Tools.FontComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSetBanner = new Syncfusion.Windows.Forms.ButtonAdv();
            this.cmbMode = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.txtBanner = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.radioButton2 = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
            this.radioButton1 = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new Syncfusion.Windows.Forms.Tools.NumericUpDownExt();
            this.fontComboBox2 = new Syncfusion.Windows.Forms.Tools.FontComboBox();
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.groupBox1 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.imageList3 = new System.Windows.Forms.ImageList(this.components);
            this.label10 = new System.Windows.Forms.Label();
            this.fontListBox1 = new Syncfusion.Windows.Forms.Tools.FontListBox();
            this.groupBox2 = new System.Windows.Forms.Panel();
            this.bannerTextProvider1 = new Syncfusion.Windows.Forms.BannerTextProvider(this.components);
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.splitContainerAdv1 = new Syncfusion.Windows.Forms.Tools.SplitContainerAdv();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxExt1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bannerClrEdit)).BeginInit();
            this.bannerClrEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxExt2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbMode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioButton2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerAdv1)).BeginInit();
            this.splitContainerAdv1.Panel1.SuspendLayout();
            this.splitContainerAdv1.Panel2.SuspendLayout();
            this.splitContainerAdv1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.label1.ImageList = this.imageList1;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(665, 64);
            this.label1.TabIndex = 4;
            this.label1.Text = resources.GetString("label1.Text");
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "");
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.White;
            this.groupBox3.Controls.Add(this.textBoxExt1);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.bannerClrEdit);
            this.groupBox3.Controls.Add(this.fontComboBox1);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.btnSetBanner);
            this.groupBox3.Controls.Add(this.cmbMode);
            this.groupBox3.Controls.Add(this.txtBanner);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.radioButton2);
            this.groupBox3.Controls.Add(this.radioButton1);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.numericUpDown1);
            this.groupBox3.Controls.Add(this.fontComboBox2);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.Black;
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(333, 392);
            this.groupBox3.TabIndex = 10;
            // 
            // textBoxExt1
            // 
            this.textBoxExt1.BackColor = System.Drawing.Color.White;
            this.textBoxExt1.BeforeTouchSize = new System.Drawing.Size(62, 15);
            this.textBoxExt1.BorderColor = System.Drawing.Color.Gray;
            this.textBoxExt1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxExt1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxExt1.Location = new System.Drawing.Point(72, 365);
            this.textBoxExt1.Metrocolor = System.Drawing.Color.Gray;
            this.textBoxExt1.Name = "textBoxExt1";
            this.textBoxExt1.OverflowIndicatorToolTipText = null;
            this.textBoxExt1.Size = new System.Drawing.Size(204, 22);
            this.textBoxExt1.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Metro;
            this.textBoxExt1.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(32, 347);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Name of The Selected Font";
            // 
            // bannerClrEdit
            // 
            this.bannerClrEdit.BeforeTouchSize = new System.Drawing.Size(86, 23);
            this.bannerClrEdit.Buttons.Add(this.buttonEditChildButton1);
            this.bannerClrEdit.ButtonStyle = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.bannerClrEdit.Controls.Add(this.buttonEditChildButton1);
            this.bannerClrEdit.Controls.Add(this.textBoxExt2);
            this.bannerClrEdit.Location = new System.Drawing.Point(68, 222);
            this.bannerClrEdit.MetroColor = System.Drawing.Color.Gray;
            this.bannerClrEdit.Name = "bannerClrEdit";
            this.bannerClrEdit.Size = new System.Drawing.Size(86, 23);
            this.bannerClrEdit.TabIndex = 14;
            this.bannerClrEdit.TextBox = this.textBoxExt2;
            this.bannerClrEdit.UseVisualStyle = true;
            this.bannerClrEdit.ButtonClicked += new Syncfusion.Windows.Forms.Tools.ButtonClickedEventHandler(this.bannerClrEdit_ButtonClicked);
            // 
            // buttonEditChildButton1
            // 
            this.buttonEditChildButton1.BackColor = System.Drawing.Color.Gray;
            this.buttonEditChildButton1.BeforeTouchSize = new System.Drawing.Size(20, 19);
            this.buttonEditChildButton1.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.Flat;
            this.buttonEditChildButton1.ComboEditBackColor = System.Drawing.SystemColors.Window;
            this.buttonEditChildButton1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditChildButton1.ForeColor = System.Drawing.Color.White;
            this.buttonEditChildButton1.Image = null;
            this.buttonEditChildButton1.IsBackStageButton = false;
            this.buttonEditChildButton1.Name = "buttonEditChildButton1";
            this.buttonEditChildButton1.PreferredWidth = 20;
            this.buttonEditChildButton1.TabIndex = 1;
            this.buttonEditChildButton1.Text = "...";
            // 
            // textBoxExt2
            // 
            this.textBoxExt2.BeforeTouchSize = new System.Drawing.Size(62, 15);
            this.textBoxExt2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxExt2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxExt2.Location = new System.Drawing.Point(2, 4);
            this.textBoxExt2.Metrocolor = System.Drawing.Color.Empty;
            this.textBoxExt2.Name = "textBoxExt2";
            this.textBoxExt2.OverflowIndicatorToolTipText = null;
            this.textBoxExt2.Size = new System.Drawing.Size(62, 15);
            this.textBoxExt2.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.textBoxExt2.TabIndex = 0;
            // 
            // fontComboBox1
            // 
            this.fontComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fontComboBox1.Location = new System.Drawing.Point(68, 308);
            this.fontComboBox1.Name = "fontComboBox1";
            this.fontComboBox1.Office2007ColorTheme = Syncfusion.Windows.Forms.Office2007Theme.Silver;
            this.fontComboBox1.Size = new System.Drawing.Size(204, 23);
            this.fontComboBox1.TabIndex = 0;
            this.fontComboBox1.UseAutoComplete = true;
            this.fontComboBox1.VisualStyle = Syncfusion.Windows.Forms.Tools.ThemedComboBoxStyles.Office2007;
            this.fontComboBox1.SelectedIndexChanged += new System.EventHandler(this.fontComboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(32, 273);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(284, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "FontComboBox with all installed System Fonts";
            // 
            // btnSetBanner
            // 
            this.btnSetBanner.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.btnSetBanner.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218)))));
            this.btnSetBanner.BeforeTouchSize = new System.Drawing.Size(91, 23);
            this.btnSetBanner.ForeColor = System.Drawing.Color.White;
            this.btnSetBanner.IsBackStageButton = false;
            this.btnSetBanner.Location = new System.Drawing.Point(195, 222);
            this.btnSetBanner.Name = "btnSetBanner";
            this.btnSetBanner.Size = new System.Drawing.Size(91, 23);
            this.btnSetBanner.TabIndex = 13;
            this.btnSetBanner.Text = "Set Banner Text";
            this.btnSetBanner.UseVisualStyle = true;
            this.btnSetBanner.UseVisualStyleBackColor = true;
            this.btnSetBanner.Click += new System.EventHandler(this.btnSetBanner_Click);
            // 
            // cmbMode
            // 
            this.cmbMode.BackColor = System.Drawing.Color.White;
            this.cmbMode.BeforeTouchSize = new System.Drawing.Size(91, 21);
            this.cmbMode.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMode.Items.AddRange(new object[] {
            "EditMode",
            "FocusMode"});
            this.cmbMode.ItemsImageIndexes.Add(new Syncfusion.Windows.Forms.Tools.ComboBoxAdv.ImageIndexItem(this.cmbMode, "EditMode"));
            this.cmbMode.ItemsImageIndexes.Add(new Syncfusion.Windows.Forms.Tools.ComboBoxAdv.ImageIndexItem(this.cmbMode, "FocusMode"));
            this.cmbMode.Location = new System.Drawing.Point(195, 187);
            this.cmbMode.Name = "cmbMode";
            this.cmbMode.Size = new System.Drawing.Size(91, 21);
            this.cmbMode.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.cmbMode.TabIndex = 12;
            this.cmbMode.UseMetroColorsInActiveMode = true;
            // 
            // txtBanner
            // 
            this.txtBanner.Location = new System.Drawing.Point(68, 187);
            this.txtBanner.Name = "txtBanner";
            this.txtBanner.Size = new System.Drawing.Size(86, 22);
            this.txtBanner.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(32, 229);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "Color";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(160, 190);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Mode";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(31, 190);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Text";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(31, 164);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "BannerText Settings";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(31, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "FontComboBox ";
            // 
            // radioButton2
            // 
            this.radioButton2.BeforeTouchSize = new System.Drawing.Size(150, 21);
            this.radioButton2.DrawFocusRectangle = false;
            this.radioButton2.Location = new System.Drawing.Point(163, 116);
            this.radioButton2.MetroColor = System.Drawing.Color.Gray;
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(119, 25);
            this.radioButton2.Style = Syncfusion.Windows.Forms.Tools.RadioButtonAdvStyle.Metro;
            this.radioButton2.TabIndex = 5;
            this.radioButton2.TabStop = false;
            this.radioButton2.Text = "DropDownList";
            this.radioButton2.ThemesEnabled = false;
            this.radioButton2.CheckChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.BeforeTouchSize = new System.Drawing.Size(150, 21);
            this.radioButton1.Checked = true;
            this.radioButton1.DrawFocusRectangle = false;
            this.radioButton1.Location = new System.Drawing.Point(27, 116);
            this.radioButton1.MetroColor = System.Drawing.Color.Gray;
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(98, 25);
            this.radioButton1.Style = Syncfusion.Windows.Forms.Tools.RadioButtonAdvStyle.Metro;
            this.radioButton1.TabIndex = 4;
            this.radioButton1.Text = "DropDown";
            this.radioButton1.ThemesEnabled = false;
            this.radioButton1.CheckChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "No. of Items to Show:";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.BackColor = System.Drawing.Color.White;
            this.numericUpDown1.BeforeTouchSize = new System.Drawing.Size(56, 22);
            this.numericUpDown1.BorderColor = System.Drawing.Color.Silver;
            this.numericUpDown1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDown1.Location = new System.Drawing.Point(152, 72);
            this.numericUpDown1.MetroColor = System.Drawing.Color.Silver;
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(56, 22);
            this.numericUpDown1.TabIndex = 2;
            this.numericUpDown1.ThemedBorder = false;
            this.numericUpDown1.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDown1.VisualStyle = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // fontComboBox2
            // 
            this.fontComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fontComboBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fontComboBox2.Location = new System.Drawing.Point(28, 32);
            this.fontComboBox2.MaxDropDownItems = 25;
            this.fontComboBox2.Name = "fontComboBox2";
            this.fontComboBox2.Office2007ColorTheme = Syncfusion.Windows.Forms.Office2007Theme.Silver;
            this.fontComboBox2.Size = new System.Drawing.Size(248, 23);
            this.fontComboBox2.Sorted = true;
            this.fontComboBox2.TabIndex = 0;
            this.fontComboBox2.UseAutoComplete = true;
            this.fontComboBox2.VisualStyle = Syncfusion.Windows.Forms.Tools.ThemedComboBoxStyles.Office2007;
            this.fontComboBox2.SelectedIndexChanged += new System.EventHandler(this.fontComboBox2_SelectedIndexChanged);
            // 
            // imageList2
            // 
            this.imageList2.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList2.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.fontListBox1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(323, 392);
            this.groupBox1.TabIndex = 7;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(17, 221);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(119, 13);
            this.label12.TabIndex = 4;
            this.label12.Text = "Font of label changes";
            // 
            // label11
            // 
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ImageIndex = 0;
            this.label11.ImageList = this.imageList3;
            this.label11.Location = new System.Drawing.Point(31, 250);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(248, 89);
            this.label11.TabIndex = 3;
            this.label11.Text = "Traffic Signal";
            this.label11.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // imageList3
            // 
            this.imageList3.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList3.ImageStream")));
            this.imageList3.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList3.Images.SetKeyName(0, "");
            this.imageList3.Images.SetKeyName(1, "");
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(17, 10);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(262, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "FontListBox displays all fonts installed on system";
            // 
            // fontListBox1
            // 
            this.fontListBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fontListBox1.ItemHeight = 15;
            this.fontListBox1.Items.AddRange(new object[] {
            "Adobe Arabic",
            "Adobe Caslon Pro",
            "Adobe Caslon Pro Bold",
            "Adobe Devanagari",
            "Adobe Fan Heiti Std B",
            "Adobe Fangsong Std R",
            "Adobe Garamond Pro",
            "Adobe Garamond Pro Bold",
            "Adobe Gothic Std B",
            "Adobe Hebrew",
            "Adobe Heiti Std R",
            "Adobe Kaiti Std R",
            "Adobe Ming Std L",
            "Adobe Myungjo Std M",
            "Adobe Naskh Medium",
            "Adobe Song Std L",
            "Agency FB",
            "Aharoni",
            "Aldhabi",
            "Algerian",
            "Andalus",
            "Angsana New",
            "AngsanaUPC",
            "Aparajita",
            "AR BERKLEY",
            "AR BLANCA",
            "AR BONNIE",
            "AR CARTER",
            "AR CENA",
            "AR CHRISTY",
            "AR DARLING",
            "AR DECODE",
            "AR DELANEY",
            "AR DESTINE",
            "AR ESSENCE",
            "AR HERMANN",
            "AR JULIAN",
            "Arabic Typesetting",
            "Arial",
            "Arial Black",
            "Arial Narrow",
            "Arial Rounded MT Bold",
            "Arial Unicode MS",
            "Baskerville Old Face",
            "Batang",
            "BatangChe",
            "Bauhaus 93",
            "Bell MT",
            "Berlin Sans FB",
            "Berlin Sans FB Demi",
            "Bernard MT Condensed",
            "Birch Std",
            "Blackadder ITC",
            "Blackoak Std",
            "Bodoni MT",
            "Bodoni MT Black",
            "Bodoni MT Condensed",
            "Bodoni MT Poster Compressed",
            "Book Antiqua",
            "Bookman Old Style",
            "Bookshelf Symbol 7",
            "Bradley Hand ITC",
            "Britannic Bold",
            "Broadway",
            "Browallia New",
            "BrowalliaUPC",
            "Brush Script MT",
            "Brush Script Std",
            "Buxton Sketch",
            "Calibri",
            "Calibri Light",
            "Californian FB",
            "Calisto MT",
            "Cambria",
            "Cambria Math",
            "Candara",
            "Castellar",
            "Centaur",
            "Century",
            "Century Gothic",
            "Century Schoolbook",
            "Chaparral Pro",
            "Chaparral Pro Light",
            "Charlemagne Std",
            "Chiller",
            "Colonna MT",
            "Comic Sans MS",
            "Consolas",
            "Constantia",
            "Cooper Black",
            "Cooper Std Black",
            "Copperplate Gothic Bold",
            "Copperplate Gothic Light",
            "Corbel",
            "Cordia New",
            "CordiaUPC",
            "Courier New",
            "Curlz MT",
            "DaunPenh",
            "David",
            "DengXian",
            "DFKai-SB",
            "DilleniaUPC",
            "DokChampa",
            "Dotum",
            "DotumChe",
            "Ebrima",
            "Edwardian Script ITC",
            "Elephant",
            "Engravers MT",
            "Eras Bold ITC",
            "Eras Demi ITC",
            "Eras Light ITC",
            "Eras Medium ITC",
            "Estrangelo Edessa",
            "EucrosiaUPC",
            "Euphemia",
            "FangSong",
            "Felix Titling",
            "Footlight MT Light",
            "Forte",
            "Franklin Gothic Book",
            "Franklin Gothic Demi",
            "Franklin Gothic Demi Cond",
            "Franklin Gothic Heavy",
            "Franklin Gothic Medium",
            "Franklin Gothic Medium Cond",
            "FrankRuehl",
            "FreesiaUPC",
            "Freestyle Script",
            "French Script MT",
            "Gabriola",
            "Gadugi",
            "Garamond",
            "Gautami",
            "Georgia",
            "Giddyup Std",
            "Gigi",
            "Gill Sans MT",
            "Gill Sans MT Condensed",
            "Gill Sans MT Ext Condensed Bold",
            "Gill Sans Ultra Bold",
            "Gill Sans Ultra Bold Condensed",
            "Gisha",
            "Gloucester MT Extra Condensed",
            "Goudy Old Style",
            "Goudy Stout",
            "Gulim",
            "GulimChe",
            "Gungsuh",
            "GungsuhChe",
            "Haettenschweiler",
            "Harlow Solid Italic",
            "Harrington",
            "High Tower Text",
            "Hobo Std",
            "Impact",
            "Imprint MT Shadow",
            "Informal Roman",
            "IrisUPC",
            "Iskoola Pota",
            "JasmineUPC",
            "Javanese Text",
            "Jokerman",
            "Juice ITC",
            "KaiTi",
            "Kalinga",
            "Kartika",
            "Khmer UI",
            "KodchiangUPC",
            "Kokila",
            "Kozuka Gothic Pr6N B",
            "Kozuka Gothic Pr6N EL",
            "Kozuka Gothic Pr6N H",
            "Kozuka Gothic Pr6N L",
            "Kozuka Gothic Pr6N M",
            "Kozuka Gothic Pr6N R",
            "Kozuka Gothic Pro B",
            "Kozuka Gothic Pro EL",
            "Kozuka Gothic Pro H",
            "Kozuka Gothic Pro L",
            "Kozuka Gothic Pro M",
            "Kozuka Gothic Pro R",
            "Kozuka Mincho Pr6N B",
            "Kozuka Mincho Pr6N EL",
            "Kozuka Mincho Pr6N H",
            "Kozuka Mincho Pr6N L",
            "Kozuka Mincho Pr6N M",
            "Kozuka Mincho Pr6N R",
            "Kozuka Mincho Pro B",
            "Kozuka Mincho Pro EL",
            "Kozuka Mincho Pro H",
            "Kozuka Mincho Pro L",
            "Kozuka Mincho Pro M",
            "Kozuka Mincho Pro R",
            "Kristen ITC",
            "Kunstler Script",
            "Lao UI",
            "Latha",
            "Leelawadee",
            "Leelawadee UI",
            "Leelawadee UI Semilight",
            "Letter Gothic Std",
            "Levenim MT",
            "LilyUPC",
            "Lithos Pro Regular",
            "Lucida Bright",
            "Lucida Calligraphy",
            "Lucida Console",
            "Lucida Fax",
            "Lucida Handwriting",
            "Lucida Sans",
            "Lucida Sans Typewriter",
            "Lucida Sans Unicode",
            "Magneto",
            "Maiandra GD",
            "Malgun Gothic",
            "Mangal",
            "Marlett",
            "Matura MT Script Capitals",
            "Meiryo",
            "Meiryo UI",
            "Mesquite Std",
            "Microsoft Himalaya",
            "Microsoft JhengHei",
            "Microsoft JhengHei Light",
            "Microsoft JhengHei UI",
            "Microsoft JhengHei UI Light",
            "Microsoft MHei",
            "Microsoft NeoGothic",
            "Microsoft New Tai Lue",
            "Microsoft PhagsPa",
            "Microsoft Sans Serif",
            "Microsoft Tai Le",
            "Microsoft Uighur",
            "Microsoft YaHei",
            "Microsoft YaHei Light",
            "Microsoft YaHei UI",
            "Microsoft YaHei UI Light",
            "Microsoft Yi Baiti",
            "MingLiU",
            "MingLiU-ExtB",
            "MingLiU_HKSCS",
            "MingLiU_HKSCS-ExtB",
            "Minion Pro",
            "Minion Pro Cond",
            "Minion Pro Med",
            "Minion Pro SmBd",
            "Miriam",
            "Miriam Fixed",
            "Mistral",
            "Modern No. 20",
            "Mongolian Baiti",
            "Monotype Corsiva",
            "MoolBoran",
            "MS Gothic",
            "MS Mincho",
            "MS Outlook",
            "MS PGothic",
            "MS PMincho",
            "MS Reference Sans Serif",
            "MS Reference Specialty",
            "MS UI Gothic",
            "MT Extra",
            "MV Boli",
            "Myanmar Text",
            "Myriad Arabic",
            "Myriad Hebrew",
            "Myriad Pro",
            "Myriad Pro Cond",
            "Myriad Pro Light",
            "Narkisim",
            "Niagara Engraved",
            "Niagara Solid",
            "Nina",
            "Nirmala UI",
            "Nirmala UI Semilight",
            "NSimSun",
            "Nueva Std",
            "Nueva Std Cond",
            "Nyala",
            "OCR A Extended",
            "OCR A Std",
            "Old English Text MT",
            "Onyx",
            "Orator Std",
            "Palace Script MT",
            "Palatino Linotype",
            "Papyrus",
            "Parchment",
            "Perpetua",
            "Perpetua Titling MT",
            "Plantagenet Cherokee",
            "Playbill",
            "PMingLiU",
            "PMingLiU-ExtB",
            "Poor Richard",
            "Poplar Std",
            "Prestige Elite Std",
            "Pristina",
            "Raavi",
            "Rage Italic",
            "Ravie",
            "Rockwell",
            "Rockwell Condensed",
            "Rockwell Extra Bold",
            "Rod",
            "Rosewood Std Regular",
            "Sakkal Majalla",
            "Script MT Bold",
            "Segoe Marker",
            "Segoe Print",
            "Segoe Script",
            "Segoe UI",
            "Segoe UI Black",
            "Segoe UI Emoji",
            "Segoe UI Light",
            "Segoe UI Semibold",
            "Segoe UI Semilight",
            "Segoe UI Symbol",
            "Segoe WP",
            "Segoe WP Black",
            "Segoe WP Light",
            "Segoe WP Semibold",
            "Segoe WP SemiLight",
            "Shonar Bangla",
            "Showcard Gothic",
            "Shruti",
            "SimHei",
            "Simplified Arabic",
            "Simplified Arabic Fixed",
            "SimSun",
            "SimSun-ExtB",
            "Sitka Banner",
            "Sitka Display",
            "Sitka Heading",
            "Sitka Small",
            "Sitka Subheading",
            "Sitka Text",
            "SketchFlow Print",
            "Snap ITC",
            "Stencil",
            "Stencil Std",
            "Sylfaen",
            "Symbol",
            "Tahoma",
            "Tekton Pro",
            "Tekton Pro Cond",
            "Tekton Pro Ext",
            "Tempus Sans ITC",
            "Times New Roman",
            "Traditional Arabic",
            "Trajan Pro",
            "Trebuchet MS",
            "Tunga",
            "Tw Cen MT",
            "Tw Cen MT Condensed",
            "Tw Cen MT Condensed Extra Bold",
            "Urdu Typesetting",
            "Utsaah",
            "Vani",
            "Verdana",
            "Vijaya",
            "Viner Hand ITC",
            "Vivaldi",
            "Vladimir Script",
            "Vrinda",
            "Webdings",
            "Wide Latin",
            "Wingdings",
            "Wingdings 2",
            "Wingdings 3",
            "Yu Gothic",
            "Yu Gothic Light",
            "Yu Mincho",
            "Yu Mincho Demibold",
            "Yu Mincho Light"});
            this.fontListBox1.Location = new System.Drawing.Point(35, 41);
            this.fontListBox1.MetroColor = System.Drawing.Color.Empty;
            this.fontListBox1.Name = "fontListBox1";
            metroColorTable1.ArrowChecked = System.Drawing.Color.Black;
            metroColorTable1.ArrowInActive = System.Drawing.Color.White;
            metroColorTable1.ArrowNormal = System.Drawing.Color.Gray;
            metroColorTable1.ArrowNormalBackGround = System.Drawing.Color.Empty;
            metroColorTable1.ArrowPushed = System.Drawing.Color.Black;
            metroColorTable1.ArrowPushedBackGround = System.Drawing.Color.Empty;
            metroColorTable1.ScrollerBackground = System.Drawing.Color.White;
            metroColorTable1.ThumbChecked = System.Drawing.Color.Black;
            metroColorTable1.ThumbInActive = System.Drawing.Color.White;
            metroColorTable1.ThumbNormal = System.Drawing.Color.Gray;
            metroColorTable1.ThumbPushed = System.Drawing.Color.Black;
            metroColorTable1.ThumbPushedBorder = System.Drawing.Color.Empty;
            this.fontListBox1.ScrollMetroColorTable = metroColorTable1;
            this.fontListBox1.Size = new System.Drawing.Size(248, 152);
            this.fontListBox1.TabIndex = 1;
            this.fontListBox1.SelectedIndexChanged += new System.EventHandler(this.fontListBox1_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(10, 10);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(667, 66);
            this.groupBox2.TabIndex = 11;
            // 
            // splitContainerAdv1
            // 
            this.splitContainerAdv1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainerAdv1.BeforeTouchSize = 7;
            this.splitContainerAdv1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainerAdv1.IsSplitterFixed = true;
            this.splitContainerAdv1.Location = new System.Drawing.Point(10, 97);
            this.splitContainerAdv1.Name = "splitContainerAdv1";
            // 
            // splitContainerAdv1.Panel1
            // 
            this.splitContainerAdv1.Panel1.Controls.Add(this.groupBox3);
            // 
            // splitContainerAdv1.Panel2
            // 
            this.splitContainerAdv1.Panel2.Controls.Add(this.groupBox1);
            this.splitContainerAdv1.Size = new System.Drawing.Size(667, 394);
            this.splitContainerAdv1.SplitterDistance = 335;
            this.splitContainerAdv1.TabIndex = 12;
            this.splitContainerAdv1.Text = "splitContainerAdv1";
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 15);
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(687, 504);
            this.Controls.Add(this.splitContainerAdv1);
            this.Controls.Add(this.groupBox2);
            this.DropShadow = true;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FontListBox";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxExt1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bannerClrEdit)).EndInit();
            this.bannerClrEdit.ResumeLayout(false);
            this.bannerClrEdit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxExt2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbMode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioButton2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.splitContainerAdv1.Panel1.ResumeLayout(false);
            this.splitContainerAdv1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerAdv1)).EndInit();
            this.splitContainerAdv1.ResumeLayout(false);
            this.ResumeLayout(false);

		}
		#endregion

		[STAThread]
		static void Main() 
		{
            SyncfusionLicenseProvider.RegisterLicense(DemoCommon.FindLicenseKey());
            Application.Run(new Form1());
		}
	
		#region SelectedIndexChanged
		private void fontComboBox1_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			this.textBoxExt1.Text = this.fontComboBox1.SelectedItem.ToString ();
            this.label2.Font = new Font(this.fontComboBox1.SelectedItem.ToString(), this.label2.Font.Size, FontStyle.Regular);
			this.fontComboBox2.SelectedItem = this.fontComboBox1.SelectedItem;
		}

		private void fontComboBox2_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			this.textBoxExt1.Text = this.fontComboBox2.SelectedItem.ToString ();
            this.label2.Font = new Font(this.fontComboBox2.SelectedItem.ToString(), this.label2.Font.Size, FontStyle.Regular);
			this.fontComboBox1.SelectedItem = this.fontComboBox2.SelectedItem;
		}
		#endregion

		private void numericUpDown1_ValueChanged(object sender, System.EventArgs e)
		{
			this.fontComboBox2.MaxDropDownItems = (int)numericUpDown1.Value;
		}

		private void radioButton1_CheckedChanged(object sender, System.EventArgs e)
		{
			this.fontComboBox2.DropDownStyle = ComboBoxStyle.DropDown ;
            this.bannerTextProvider1.GetBannerText(this.fontComboBox2).Visible = true;
		}

		private void radioButton2_CheckedChanged(object sender, System.EventArgs e)
		{
			this.fontComboBox2.DropDownStyle = ComboBoxStyle.DropDownList ;
            this.bannerTextProvider1.GetBannerText(this.fontComboBox2).Visible = false;
		}

        void Application_Idle(object sender, EventArgs e)
        {
            if (txtBanner.Text == "")
                btnSetBanner.Enabled = false;
            else
                btnSetBanner.Enabled = true;
        }

        private void bannerClrEdit_ButtonClicked(object sender, Syncfusion.Windows.Forms.Tools.ButtonClickedEventArgs args)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
                bannerClrEdit.TextBox.BackColor = colorDialog1.Color;
        }

        private void btnSetBanner_Click(object sender, EventArgs e)
        {
            BannerTextMode mode = (BannerTextMode)Enum.Parse(typeof(BannerTextMode), cmbMode.SelectedItem.ToString());
            BannerTextInfo binfo = this.bannerTextProvider1.GetBannerText(this.fontComboBox2);
            binfo.Text = txtBanner.Text;
            binfo.Mode = mode;
            binfo.Color = bannerClrEdit.TextBox.BackColor;
            this.fontComboBox2.Refresh();
        }

        private void fontListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.label11.Font = new Font(this.fontListBox1.SelectedItem.ToString(), 11, FontStyle.Regular);
        }
	}
}

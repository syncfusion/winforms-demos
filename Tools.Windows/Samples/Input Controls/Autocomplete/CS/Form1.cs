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

namespace AutoCompleteDemo
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : MetroForm
    {
        private System.Windows.Forms.ImageList imageList1;
        public TextBoxExt textBox1;
		private Syncfusion.Windows.Forms.Tools.AutoComplete autoComplete1;
		private System.Windows.Forms.Label label3;
		private Syncfusion.Windows.Forms.Tools.ComboBoxAdv comboBoxAdv1;
        private System.Windows.Forms.ImageList imageList2;
		private Syncfusion.Windows.Forms.Tools.AutoComplete autoComplete2;
		internal System.Windows.Forms.Label label5;
        public TextBoxExt textBox4;
        private TextBoxExt textBox5;
		private System.Windows.Forms.ImageList imageList3;
		private Syncfusion.Windows.Forms.Tools.AutoCompleteDataColumnInfo autoCompleteDataColumnInfo1;
		private Syncfusion.Windows.Forms.Tools.AutoCompleteDataColumnInfo autoCompleteDataColumnInfo2;
        private Syncfusion.Windows.Forms.Tools.AutoCompleteDataColumnInfo autoCompleteDataColumnInfo3;
        private ComboBoxAdv comboBoxAdv2;
        private Label label6;
        private Label label2;
        private Label label10;
        private Label label4;
        private GradientPanel gradientPanel2;
        private Label label15;
        private GradientPanel gradientPanel1;
        private Label label40;
        private ToolTip toolTip1;
        internal Label label9;
        private TextBoxExt textBox6;
        private AutoLabel autoLabel1;
        private SplitContainerAdv splitContainerAdv1;
        private Label label1;
        private ComboBoxAdv comboBoxAdv3;
        private SkinManager skinManager1;
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
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.comboBoxAdv1 = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.autoComplete1 = new Syncfusion.Windows.Forms.Tools.AutoComplete(this.components);
            this.textBox5 = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.textBox4 = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.textBox6 = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.comboBoxAdv2 = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.label5 = new System.Windows.Forms.Label();
            this.autoCompleteDataColumnInfo1 = new Syncfusion.Windows.Forms.Tools.AutoCompleteDataColumnInfo("URL", 100, true);
            this.autoCompleteDataColumnInfo2 = new Syncfusion.Windows.Forms.Tools.AutoCompleteDataColumnInfo("Name", 100, true);
            this.autoCompleteDataColumnInfo3 = new Syncfusion.Windows.Forms.Tools.AutoCompleteDataColumnInfo("ImageIndex", 100, true);
            this.imageList3 = new System.Windows.Forms.ImageList(this.components);
            this.label10 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.gradientPanel1 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            this.label40 = new System.Windows.Forms.Label();
            this.gradientPanel2 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            this.label15 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.autoLabel1 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.label9 = new System.Windows.Forms.Label();
            this.splitContainerAdv1 = new Syncfusion.Windows.Forms.Tools.SplitContainerAdv();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxAdv3 = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.autoComplete2 = new Syncfusion.Windows.Forms.Tools.AutoComplete(this.components);
            this.skinManager1 = new Syncfusion.Windows.Forms.SkinManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxAdv1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.autoComplete1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxAdv2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel1)).BeginInit();
            this.gradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel2)).BeginInit();
            this.gradientPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerAdv1)).BeginInit();
            this.splitContainerAdv1.Panel1.SuspendLayout();
            this.splitContainerAdv1.Panel2.SuspendLayout();
            this.splitContainerAdv1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxAdv3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.autoComplete2)).BeginInit();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "");
            // 
            // comboBoxAdv1
            // 
            this.comboBoxAdv1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.comboBoxAdv1.BeforeTouchSize = new System.Drawing.Size(186, 27);
            this.comboBoxAdv1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAdv1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxAdv1.Items.AddRange(new object[] {
            "Disabled",
            "AutoSuggest",
            "AutoAppend",
            "Both"});
            this.comboBoxAdv1.Location = new System.Drawing.Point(241, 201);
            this.comboBoxAdv1.Name = "comboBoxAdv1";
            this.comboBoxAdv1.Office2007ColorTheme = Syncfusion.Windows.Forms.Office2007Theme.Black;
            this.comboBoxAdv1.Office2010ColorTheme = Syncfusion.Windows.Forms.Office2010Theme.Black;
            this.comboBoxAdv1.Size = new System.Drawing.Size(186, 27);
            this.comboBoxAdv1.Style = Syncfusion.Windows.Forms.VisualStyle.Office2016Colorful;
            this.comboBoxAdv1.TabIndex = 10;
            this.comboBoxAdv1.Text = "Disabled";
            this.comboBoxAdv1.SelectedIndexChanged += new System.EventHandler(this.comboBoxAdv1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(43, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 19);
            this.label3.TabIndex = 9;
            this.label3.Text = "Set AutoComplete Mode:";
            // 
            // textBox1
            // 
            this.autoComplete1.SetAutoComplete(this.textBox1, Syncfusion.Windows.Forms.Tools.AutoCompleteModes.AutoSuggest);
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.textBox1.BeforeTouchSize = new System.Drawing.Size(186, 26);
            this.textBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.textBox1.Location = new System.Drawing.Point(680, 196);
            this.textBox1.Metrocolor = System.Drawing.Color.Gray;
            this.textBox1.Name = "textBox1";
            this.textBox1.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Black;
            this.textBox1.Office2010ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Black;
            this.textBox1.Size = new System.Drawing.Size(259, 26);
            this.textBox1.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Office2016Colorful;
            this.textBox1.TabIndex = 6;
            // 
            // autoComplete1
            // 
            this.autoComplete1.AutoAddItem = true;
            this.autoComplete1.HeaderFont = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            this.autoComplete1.ItemFont = new System.Drawing.Font("Segoe UI", 8.25F);
            this.autoComplete1.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218)))));
            this.autoComplete1.ParentForm = this;
            this.autoComplete1.Style = Syncfusion.Windows.Forms.Tools.AutoCompleteStyle.Office2016Colorful;
            this.autoComplete1.AutoCompleteItemSelected += new Syncfusion.Windows.Forms.Tools.AutoCompleteItemEventHandler(this.autoComplete_AutoCompleteItemSelected);
            this.autoComplete1.AutoCompleteItemBrowsed += new Syncfusion.Windows.Forms.Tools.AutoCompleteItemEventHandler(this.autoComplete_AutoCompleteItemBrowsed);
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.textBox5.BeforeTouchSize = new System.Drawing.Size(186, 26);
            this.textBox5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox5.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.textBox5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.textBox5.Metrocolor = System.Drawing.Color.Gray;
            this.textBox5.Location = new System.Drawing.Point(0, 307);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Black;
            this.textBox5.Office2010ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Black;
            this.textBox5.Size = new System.Drawing.Size(1177, 123);
            this.textBox5.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Office2016Colorful;
            this.textBox5.TabIndex = 18;
            // 
            // textBox4
            // 
            this.autoComplete2.SetAutoComplete(this.textBox4, Syncfusion.Windows.Forms.Tools.AutoCompleteModes.MultiSuggestExtended);
            this.textBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.textBox4.BeforeTouchSize = new System.Drawing.Size(186, 26);
            this.textBox4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.textBox4.Location = new System.Drawing.Point(241, 204);
            this.textBox4.Metrocolor = System.Drawing.Color.Gray;
            this.textBox4.Name = "textBox4";
            this.textBox4.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Black;
            this.textBox4.Office2010ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Black;
            this.textBox4.Size = new System.Drawing.Size(654, 26);
            this.textBox4.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Office2016Colorful;
            this.textBox4.TabIndex = 17;
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.textBox6.BeforeTouchSize = new System.Drawing.Size(186, 26);
            this.textBox6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox6.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox6.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.textBox6.Location = new System.Drawing.Point(241, 244);
            this.textBox6.Metrocolor = System.Drawing.Color.Gray;
            this.textBox6.Name = "textBox6";
            this.textBox6.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Black;
            this.textBox6.Office2010ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Black;
            this.textBox6.Size = new System.Drawing.Size(186, 26);
            this.textBox6.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Office2016Colorful;
            this.textBox6.TabIndex = 35;
            this.textBox6.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "");
            this.imageList2.Images.SetKeyName(1, "");
            this.imageList2.Images.SetKeyName(2, "");
            this.imageList2.Images.SetKeyName(3, "");
            // 
            // comboBoxAdv2
            // 
            this.comboBoxAdv2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.comboBoxAdv2.BeforeTouchSize = new System.Drawing.Size(187, 27);
            this.comboBoxAdv2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAdv2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxAdv2.Items.AddRange(new object[] {
            "MultiSuggest",
            "MultiSuggestExtended"});
            this.comboBoxAdv2.Location = new System.Drawing.Point(241, 168);
            this.comboBoxAdv2.Name = "comboBoxAdv2";
            this.comboBoxAdv2.Office2007ColorTheme = Syncfusion.Windows.Forms.Office2007Theme.Black;
            this.comboBoxAdv2.Office2010ColorTheme = Syncfusion.Windows.Forms.Office2010Theme.Black;
            this.comboBoxAdv2.Size = new System.Drawing.Size(187, 27);
            this.comboBoxAdv2.Style = Syncfusion.Windows.Forms.VisualStyle.Office2016Colorful;
            this.comboBoxAdv2.TabIndex = 13;
            this.comboBoxAdv2.Text = "MultiSuggestExtended";
            this.comboBoxAdv2.SelectedIndexChanged += new System.EventHandler(this.comboBoxAdv2_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label5.Location = new System.Drawing.Point(606, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "TextBox";
            // 
            // imageList3
            // 
            this.imageList3.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList3.ImageStream")));
            this.imageList3.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList3.Images.SetKeyName(0, "");
            this.imageList3.Images.SetKeyName(1, "");
            this.imageList3.Images.SetKeyName(2, "");
            this.imageList3.Images.SetKeyName(3, "");

            // 
            // autoCompleteDataColumnInfo1
            // 
            this.autoCompleteDataColumnInfo1.ColumnHeaderText = "URL";
            this.autoCompleteDataColumnInfo1.ImageColumn = false;
            this.autoCompleteDataColumnInfo1.MatchingColumn = true;
            this.autoCompleteDataColumnInfo1.Visible = true;
            // 
            // autoCompleteDataColumnInfo2
            // 
            this.autoCompleteDataColumnInfo2.ColumnHeaderText = "Name";
            this.autoCompleteDataColumnInfo2.ImageColumn = false;
            this.autoCompleteDataColumnInfo2.MatchingColumn = false;
            this.autoCompleteDataColumnInfo2.Visible = true;
            // 
            // autoCompleteDataColumnInfo3
            // 
            this.autoCompleteDataColumnInfo3.ColumnHeaderText = "ImageIndex";
            this.autoCompleteDataColumnInfo3.ImageColumn = true;
            this.autoCompleteDataColumnInfo3.MatchingColumn = false;
            this.autoCompleteDataColumnInfo3.Visible = true;
            // 
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label10.Location = new System.Drawing.Point(6, 4);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(222, 30);
            this.label10.TabIndex = 13;
            this.label10.Text = "UnBounded DataSource";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(6, -1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(201, 30);
            this.label2.TabIndex = 20;
            this.label2.Text = "Bounded DataSource";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(39, 174);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(164, 19);
            this.label6.TabIndex = 21;
            this.label6.Text = "Set AutoComplete Mode:";
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gradientPanel1.BorderColor = System.Drawing.Color.Gray;
            this.gradientPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gradientPanel1.Controls.Add(this.label40);
            this.gradientPanel1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gradientPanel1.Location = new System.Drawing.Point(213, 34);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(846, 104);
            this.gradientPanel1.TabIndex = 26;
            // 
            // label40
            // 
            this.label40.BackColor = System.Drawing.Color.Transparent;
            this.label40.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label40.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label40.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label40.Location = new System.Drawing.Point(0, 0);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(844, 102);
            this.label40.TabIndex = 1;
            this.label40.Text = resources.GetString("label40.Text");
            this.label40.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gradientPanel2
            // 
            this.gradientPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gradientPanel2.BorderColor = System.Drawing.Color.Gray;
            this.gradientPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gradientPanel2.Controls.Add(this.label15);
            this.gradientPanel2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gradientPanel2.Location = new System.Drawing.Point(213, 23);
            this.gradientPanel2.Name = "gradientPanel2";
            this.gradientPanel2.Size = new System.Drawing.Size(845, 96);
            this.gradientPanel2.TabIndex = 27;
            // 
            // label15
            // 
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label15.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label15.Location = new System.Drawing.Point(0, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(843, 94);
            this.label15.TabIndex = 1;
            this.label15.Text = "The DataSource for this AutoComplete control is set to an XML Datasource. Enter h" +
    " to view the autocomplete. ";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label4.Location = new System.Drawing.Point(6, 267);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 31);
            this.label4.TabIndex = 28;
            this.label4.Text = "Event Log";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // autoLabel1
            // 
            this.autoLabel1.BackColor = System.Drawing.Color.Transparent;
            this.autoLabel1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoLabel1.Location = new System.Drawing.Point(43, 248);
            this.autoLabel1.Name = "autoLabel1";
            this.autoLabel1.Size = new System.Drawing.Size(163, 19);
            this.autoLabel1.TabIndex = 34;
            this.autoLabel1.Text = "Number Of Suggestions :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(39, 208);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 19);
            this.label9.TabIndex = 33;
            this.label9.Text = "TextBox";
            // 
            // splitContainerAdv1
            // 
            this.splitContainerAdv1.BeforeTouchSize = 1;
            this.splitContainerAdv1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainerAdv1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerAdv1.HotExpandLine = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.splitContainerAdv1.Location = new System.Drawing.Point(10, 10);
            this.splitContainerAdv1.Name = "splitContainerAdv1";
            this.splitContainerAdv1.Orientation = System.Windows.Forms.Orientation.Vertical;
            // 
            // splitContainerAdv1.Panel1
            // 
            this.splitContainerAdv1.Panel1.BackColor = System.Drawing.Color.Transparent;
            this.splitContainerAdv1.Panel1.BackgroundColor = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255))))));
            this.splitContainerAdv1.Panel1.Controls.Add(this.label1);
            this.splitContainerAdv1.Panel1.Controls.Add(this.comboBoxAdv3);
            this.splitContainerAdv1.Panel1.Controls.Add(this.label10);
            this.splitContainerAdv1.Panel1.Controls.Add(this.textBox6);
            this.splitContainerAdv1.Panel1.Controls.Add(this.label3);
            this.splitContainerAdv1.Panel1.Controls.Add(this.autoLabel1);
            this.splitContainerAdv1.Panel1.Controls.Add(this.comboBoxAdv1);
            this.splitContainerAdv1.Panel1.Controls.Add(this.textBox1);
            this.splitContainerAdv1.Panel1.Controls.Add(this.label5);
            this.splitContainerAdv1.Panel1.Controls.Add(this.gradientPanel1);
            // 
            // splitContainerAdv1.Panel2
            // 
            this.splitContainerAdv1.Panel2.BackColor = System.Drawing.Color.Transparent;
            this.splitContainerAdv1.Panel2.BackgroundColor = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255))))));
            this.splitContainerAdv1.Panel2.Controls.Add(this.label2);
            this.splitContainerAdv1.Panel2.Controls.Add(this.label9);
            this.splitContainerAdv1.Panel2.Controls.Add(this.textBox5);
            this.splitContainerAdv1.Panel2.Controls.Add(this.textBox4);
            this.splitContainerAdv1.Panel2.Controls.Add(this.comboBoxAdv2);
            this.splitContainerAdv1.Panel2.Controls.Add(this.label4);
            this.splitContainerAdv1.Panel2.Controls.Add(this.label6);
            this.splitContainerAdv1.Panel2.Controls.Add(this.gradientPanel2);
            this.splitContainerAdv1.Size = new System.Drawing.Size(1179, 724);
            this.splitContainerAdv1.SplitterDistance = 291;
            this.splitContainerAdv1.SplitterWidth = 1;
            this.splitContainerAdv1.Style = Syncfusion.Windows.Forms.Tools.Enums.Style.Office2016Colorful;
            this.splitContainerAdv1.TabIndex = 36;
            this.splitContainerAdv1.Text = "splitContainerAdv1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 19);
            this.label1.TabIndex = 36;
            this.label1.Text = "Visual Style";
            // 
            // comboBoxAdv3
            // 
            this.comboBoxAdv3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.comboBoxAdv3.BeforeTouchSize = new System.Drawing.Size(186, 27);
            this.comboBoxAdv3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAdv3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxAdv3.Items.AddRange(new object[] {
            "Office2016Colorful",
            "Office2016White",
            "Office2016Black",
            "Office2016DarkGray",
            "Metro",
            "Default"});
            this.comboBoxAdv3.Location = new System.Drawing.Point(241, 158);
            this.comboBoxAdv3.Name = "comboBoxAdv3";
            this.comboBoxAdv3.Office2007ColorTheme = Syncfusion.Windows.Forms.Office2007Theme.Black;
            this.comboBoxAdv3.Office2010ColorTheme = Syncfusion.Windows.Forms.Office2010Theme.Black;
            this.comboBoxAdv3.Size = new System.Drawing.Size(186, 27);
            this.comboBoxAdv3.Style = Syncfusion.Windows.Forms.VisualStyle.Office2016Colorful;
            this.comboBoxAdv3.TabIndex = 37;
            this.comboBoxAdv3.Text = "Metro";
            this.comboBoxAdv3.SelectedIndexChanged += new System.EventHandler(this.comboBoxAdv3_SelectedIndexChanged);
            // 
            // autoComplete2
            // 
            this.autoComplete2.AdjustHeightToItemCount = false;
            this.autoComplete2.Columns.Add(this.autoCompleteDataColumnInfo1);
            this.autoComplete2.Columns.Add(this.autoCompleteDataColumnInfo2);
            this.autoComplete2.Columns.Add(this.autoCompleteDataColumnInfo3);
            this.autoComplete2.HeaderFont = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            this.autoComplete2.ImageList = this.imageList3;
            this.autoComplete2.ItemFont = new System.Drawing.Font("Segoe UI", 8.25F);
            this.autoComplete2.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218)))));
            this.autoComplete2.ParentForm = this;
            this.autoComplete2.ShowColumnHeader = true;
            this.autoComplete2.Style = Syncfusion.Windows.Forms.Tools.AutoCompleteStyle.Office2016Colorful;
            this.autoComplete2.AutoCompleteItemSelected += new Syncfusion.Windows.Forms.Tools.AutoCompleteItemEventHandler(this.autoComplete_AutoCompleteItemSelected);
            this.autoComplete2.AutoCompleteItemBrowsed += new Syncfusion.Windows.Forms.Tools.AutoCompleteItemEventHandler(this.autoComplete_AutoCompleteItemBrowsed);
            // 
            // skinManager1
            // 
            this.skinManager1.Controls = this;
            this.skinManager1.VisualTheme = Syncfusion.Windows.Forms.VisualTheme.Office2016Colorful;
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(7, 19);
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1199, 744);
            this.Controls.Add(this.splitContainerAdv1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1211, 785);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Autocomplete Demo";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxAdv1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.autoComplete1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxAdv2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel1)).EndInit();
            this.gradientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel2)).EndInit();
            this.gradientPanel2.ResumeLayout(false);
            this.splitContainerAdv1.Panel1.ResumeLayout(false);
            this.splitContainerAdv1.Panel1.PerformLayout();
            this.splitContainerAdv1.Panel2.ResumeLayout(false);
            this.splitContainerAdv1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerAdv1)).EndInit();
            this.splitContainerAdv1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxAdv3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.autoComplete2)).EndInit();
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

        private void comboBoxAdv1_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			SetAutoCompleteMode(this.comboBoxAdv1.Text);
			AddLog("AutoCompleteMode set to "+this.comboBoxAdv1.Text);
		}
        private AutoCompleteDemo.Websites websites1;
		private void Form1_Load(object sender, System.EventArgs e)
		{
            this.websites1 = new AutoCompleteDemo.Websites();
            // 
            // websites1
            // 
            this.websites1.DataSetName = "Websites";
            this.websites1.EnforceConstraints = false;
            this.websites1.Locale = new System.Globalization.CultureInfo("en-US");
            this.autoComplete2.DataSource = this.websites1.Website;
			this.comboBoxAdv1.SelectedIndex = 3;
            this.comboBoxAdv2.SelectedIndex = 1;
            this.comboBoxAdv3.SelectedIndex = 0;

            string filename = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + @"\..\..\websites.xml";
            this.websites1.ReadXml(filename);

            if (this.autoComplete2.TableData.Rows.Count <= 0)
                this.autoComplete2.SetTableData();
            else
                this.autoComplete2.DataSource = null;
		}

       

		private void SetAutoCompleteMode(string mode)
		{
			if(mode !="")
			{
				switch(mode)
				{
					case "Disabled":
						this.autoComplete1.SetAutoComplete(this.textBox1,Syncfusion.Windows.Forms.Tools.AutoCompleteModes.Disabled);
						break;
					case "AutoSuggest":
						this.autoComplete1.SetAutoComplete(this.textBox1,Syncfusion.Windows.Forms.Tools.AutoCompleteModes.AutoSuggest);
						break;
					case "AutoAppend":
						this.autoComplete1.SetAutoComplete(this.textBox1,Syncfusion.Windows.Forms.Tools.AutoCompleteModes.AutoAppend);
						break;
					case "Both":
						this.autoComplete1.SetAutoComplete(this.textBox1,Syncfusion.Windows.Forms.Tools.AutoCompleteModes.Both);
						break;                 

				}
			}
		}


		private void AddLog(string message)
		{
			this.textBox5.Text += message +"\r\n";
		}

		private void autoComplete_AutoCompleteItemBrowsed(object sender, Syncfusion.Windows.Forms.Tools.AutoCompleteItemEventArgs args)
		{
			string itemText = args.ItemArray[0].ToString();
			string eventlogmessage = String.Format("Event: {0} Item: {1}", "AutoCompleteItemBrowsed", itemText);
			AddLog(eventlogmessage);
		}

		private void autoComplete_AutoCompleteItemSelected(object sender, Syncfusion.Windows.Forms.Tools.AutoCompleteItemEventArgs args)
		{
			string itemText = args.ItemArray[0].ToString();
			string eventlogmessage = String.Format("Event: {0} Item: {1}", "AutoCompleteItemSelected", itemText);
			AddLog(eventlogmessage);
		}

        private void comboBoxAdv2_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (this.comboBoxAdv2.Text)
            {
                case "MultiSuggest":
                    this.autoComplete2.SetAutoComplete(this.textBox4, Syncfusion.Windows.Forms.Tools.AutoCompleteModes.MultiSuggest);
                    
                    break;
                case "MultiSuggestExtended":
                    this.autoComplete2.SetAutoComplete(this.textBox4, Syncfusion.Windows.Forms.Tools.AutoCompleteModes.MultiSuggestExtended);
                    break;
            }
            AddLog("AutoCompleteMode set to " + this.comboBoxAdv2.Text);      
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.autoComplete1.MaxNumberofSuggestion = this.autoComplete2.MaxNumberofSuggestion = Convert.ToInt16(textBox6.Text);
            }
            catch (Exception) { }
        }

        private void comboBoxAdv3_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (this.comboBoxAdv3.SelectedItem.ToString())
            {
                case "Default":
                    {
                        this.autoComplete1.Style = AutoCompleteStyle.Default;
                        this.autoComplete2.Style = AutoCompleteStyle.Default;
                        this.textBox1.Style = TextBoxExt.theme.Default;
                        this.textBox4.Style = TextBoxExt.theme.Default;
                        this.textBox5.Style = TextBoxExt.theme.Default;
                        this.textBox6.Style = TextBoxExt.theme.Default;
                        this.splitContainerAdv1.Style = Syncfusion.Windows.Forms.Tools.Enums.Style.None;
                        this.GetColors(Color.White, Color.Black);
                        break;
                    }
                case "Metro":
                    {
                        //this.autoComplete1.Style = AutoCompleteStyle.Metro;
                        //this.autoComplete2.Style = AutoCompleteStyle.Metro;
                        //this.textBox1.Style = TextBoxExt.theme.Metro;
                        //this.textBox1.BackColor=Color.White;
                        //this.textBox4.BackColor=Color.White;
                        //this.textBox5.BackColor=Color.White;
                        //this.textBox6.BackColor = Color.White;
                        this.splitContainerAdv1.Style = Syncfusion.Windows.Forms.Tools.Enums.Style.Metro;
                        this.skinManager1.VisualTheme = VisualTheme.Metro;
                        this.textBox1.BackColor = Color.White;
                        this.textBox4.BackColor = Color.White;
                        this.textBox5.BackColor = Color.White;
                        this.textBox6.BackColor = Color.White;
                        this.GetColors(Color.White, Color.Black);
                        break;
                    }
                case "Office2016Colorful":
                    {
                        //this.autoComplete1.Style = AutoCompleteStyle.Office2016Colorful;
                        //this.autoComplete2.Style = AutoCompleteStyle.Office2016Colorful;
                        //this.textBox1.Style = TextBoxExt.theme.Office2016Colorful;
                        this.skinManager1.VisualTheme = VisualTheme.Office2016Colorful;
                        this.splitContainerAdv1.Style = Syncfusion.Windows.Forms.Tools.Enums.Style.Office2016Colorful;
                        this.GetColors(Color.White, Color.Black);
                        break;
                    }
                case "Office2016White":
                    {
                        //this.autoComplete1.Style = AutoCompleteStyle.Office2016White;
                        //this.autoComplete2.Style = AutoCompleteStyle.Office2016White;
                        //this.textBox1.Style = TextBoxExt.theme.Office2016White;
                        this.skinManager1.VisualTheme = VisualTheme.Office2016White;
                        this.splitContainerAdv1.Style = Syncfusion.Windows.Forms.Tools.Enums.Style.Office2016White;
                        this.GetColors(Color.White, Color.Black);
                        break;
                    }
                case "Office2016DarkGray":
                    {
                        this.autoComplete1.Style = AutoCompleteStyle.Office2016DarkGray;
                        this.autoComplete2.Style = AutoCompleteStyle.Office2016DarkGray;
                        this.textBox1.Style = TextBoxExt.theme.Office2016DarkGray;
                        this.skinManager1.VisualTheme = VisualTheme.Office2016DarkGray;
                        this.splitContainerAdv1.Style = Syncfusion.Windows.Forms.Tools.Enums.Style.Office2016DarkGray;
                        this.GetColors(Color.FromArgb(114, 114, 114), Color.LightGray);
                        break;
                    }
                case "Office2016Black":
                    {
                        //this.autoComplete1.Style = AutoCompleteStyle.Office2016Black;
                        //this.autoComplete2.Style = AutoCompleteStyle.Office2016Black;
                        //this.textBox1.Style = TextBoxExt.theme.Office2016Black;
                        this.skinManager1.VisualTheme = VisualTheme.Office2016Black;
                        this.splitContainerAdv1.Style = Syncfusion.Windows.Forms.Tools.Enums.Style.Office2016Black;
                        this.GetColors(Color.FromArgb(37, 37, 37), Color.White);
                        break;
                    }
            }
        }

        private void GetColors(Color backcolor, Color forecolor)
        {
            this.BackColor = backcolor;
            this.CaptionBarColor = backcolor;
            this.MetroColor = backcolor;
            this.splitContainerAdv1.Panel1.ForeColor = forecolor;
            this.splitContainerAdv1.Panel2.ForeColor = forecolor;
            this.ForeColor = forecolor;
            this.CaptionForeColor = forecolor;
            this.label15.BackColor = this.label40.BackColor = backcolor;
            this.label15.ForeColor = this.label40.ForeColor = forecolor;
        }
    }
}

using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

using Syncfusion.Windows.Forms.Tools;
using Syncfusion.Windows.Forms;
using Syncfusion.Licensing;
using System.IO;

namespace ColorUIDemo
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : MetroForm
	{
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ImageList imageList1;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt textBox1;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtCustomTabName;
        private Syncfusion.Windows.Forms.Tools.CheckBoxAdv chkSelectedAsBackColor;
        private Syncfusion.Windows.Forms.Tools.CheckBoxAdv chkSelectedAsText;
		private Syncfusion.Windows.Forms.Tools.ComboBoxAdv cmbSelectedColorGroup;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtStandardTabName;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtSystemTabName;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv cmbSelectedColorGroup1;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv cmbOffice2007Theme;
        private Panel panel3;
        private GradientPanel gradientPanel1;
        private ColorPickerButton colorPickerButton1;
        private Label label20;
        private SplitContainerAdv splitContainerAdv1;
        private ComboBoxAdv comboBoxAdv1;
        private Label label3;
        private GradientLabel gradientLabel1;
        private GradientLabel gradientLabel2;
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
            this.label1 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.textBox1 = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.chkSelectedAsText = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.txtSystemTabName = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.chkSelectedAsBackColor = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.txtStandardTabName = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.txtCustomTabName = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.cmbSelectedColorGroup = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbSelectedColorGroup1 = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.cmbOffice2007Theme = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.panel3 = new System.Windows.Forms.Panel();
            this.gradientPanel1 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            this.gradientLabel1 = new Syncfusion.Windows.Forms.Tools.GradientLabel();
            this.comboBoxAdv1 = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.label3 = new System.Windows.Forms.Label();
            this.colorPickerButton1 = new Syncfusion.Windows.Forms.ColorPickerButton();
            this.label20 = new System.Windows.Forms.Label();
            this.splitContainerAdv1 = new Syncfusion.Windows.Forms.Tools.SplitContainerAdv();
            this.gradientLabel2 = new Syncfusion.Windows.Forms.Tools.GradientLabel();
            ((System.ComponentModel.ISupportInitialize)(this.textBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkSelectedAsText)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSystemTabName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkSelectedAsBackColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStandardTabName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCustomTabName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbSelectedColorGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbSelectedColorGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbOffice2007Theme)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel1)).BeginInit();
            this.gradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxAdv1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerAdv1)).BeginInit();
            this.splitContainerAdv1.Panel1.SuspendLayout();
            this.splitContainerAdv1.Panel2.SuspendLayout();
            this.splitContainerAdv1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.label1.ImageList = this.imageList1;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(2);
            this.label1.Size = new System.Drawing.Size(1030, 81);
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
            this.textBox1.BeforeTouchSize = new System.Drawing.Size(1030, 147);
            this.textBox1.BorderColor = System.Drawing.Color.DimGray;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.textBox1.Location = new System.Drawing.Point(20, 616);
            this.textBox1.Metrocolor = System.Drawing.Color.DimGray;
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(1030, 147);
            this.textBox1.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Metro;
            this.textBox1.TabIndex = 2;
            this.textBox1.ThemesEnabled = false;
            // 
            // chkSelectedAsText
            // 
            this.chkSelectedAsText.BeforeTouchSize = new System.Drawing.Size(201, 41);
            this.chkSelectedAsText.DrawFocusRectangle = false;
            this.chkSelectedAsText.ImageCheckBoxSize = new System.Drawing.Size(20, 20);
            this.chkSelectedAsText.Location = new System.Drawing.Point(62, 319);
            this.chkSelectedAsText.MetroColor = System.Drawing.Color.Gray;
            this.chkSelectedAsText.Name = "chkSelectedAsText";
            this.chkSelectedAsText.Size = new System.Drawing.Size(201, 41);
            this.chkSelectedAsText.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.chkSelectedAsText.TabIndex = 7;
            this.chkSelectedAsText.Text = "Set the selected color \r\nname in the button";
            this.chkSelectedAsText.ThemesEnabled = false;
            this.chkSelectedAsText.CheckedChanged += new System.EventHandler(this.chkSelectedAsText_CheckedChanged);
            // 
            // txtSystemTabName
            // 
            this.txtSystemTabName.BeforeTouchSize = new System.Drawing.Size(1030, 147);
            this.txtSystemTabName.BorderColor = System.Drawing.Color.Gray;
            this.txtSystemTabName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSystemTabName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSystemTabName.Location = new System.Drawing.Point(227, 143);
            this.txtSystemTabName.Metrocolor = System.Drawing.Color.Gray;
            this.txtSystemTabName.Name = "txtSystemTabName";
            this.txtSystemTabName.Size = new System.Drawing.Size(168, 26);
            this.txtSystemTabName.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Metro;
            this.txtSystemTabName.TabIndex = 12;
            this.txtSystemTabName.Text = "System";
            this.txtSystemTabName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSystemTabName_KeyDown);
            // 
            // chkSelectedAsBackColor
            // 
            this.chkSelectedAsBackColor.BeforeTouchSize = new System.Drawing.Size(257, 22);
            this.chkSelectedAsBackColor.Checked = true;
            this.chkSelectedAsBackColor.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSelectedAsBackColor.DrawFocusRectangle = false;
            this.chkSelectedAsBackColor.ImageCheckBoxSize = new System.Drawing.Size(20, 20);
            this.chkSelectedAsBackColor.Location = new System.Drawing.Point(62, 292);
            this.chkSelectedAsBackColor.MetroColor = System.Drawing.Color.Gray;
            this.chkSelectedAsBackColor.Name = "chkSelectedAsBackColor";
            this.chkSelectedAsBackColor.Size = new System.Drawing.Size(257, 22);
            this.chkSelectedAsBackColor.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.chkSelectedAsBackColor.TabIndex = 6;
            this.chkSelectedAsBackColor.Text = "Set selected color as backcolor";
            this.chkSelectedAsBackColor.ThemesEnabled = false;
            this.chkSelectedAsBackColor.CheckedChanged += new System.EventHandler(this.chkSelectedAsBackColor_CheckedChanged);
            // 
            // txtStandardTabName
            // 
            this.txtStandardTabName.BeforeTouchSize = new System.Drawing.Size(1030, 147);
            this.txtStandardTabName.BorderColor = System.Drawing.Color.Gray;
            this.txtStandardTabName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtStandardTabName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtStandardTabName.Location = new System.Drawing.Point(227, 98);
            this.txtStandardTabName.Metrocolor = System.Drawing.Color.Gray;
            this.txtStandardTabName.Name = "txtStandardTabName";
            this.txtStandardTabName.Size = new System.Drawing.Size(168, 26);
            this.txtStandardTabName.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Metro;
            this.txtStandardTabName.TabIndex = 11;
            this.txtStandardTabName.Text = "Web";
            this.txtStandardTabName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtStandardTabName_KeyDown);
            // 
            // txtCustomTabName
            // 
            this.txtCustomTabName.BeforeTouchSize = new System.Drawing.Size(1030, 147);
            this.txtCustomTabName.BorderColor = System.Drawing.Color.Gray;
            this.txtCustomTabName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCustomTabName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCustomTabName.Location = new System.Drawing.Point(227, 56);
            this.txtCustomTabName.Metrocolor = System.Drawing.Color.Gray;
            this.txtCustomTabName.Name = "txtCustomTabName";
            this.txtCustomTabName.Size = new System.Drawing.Size(168, 26);
            this.txtCustomTabName.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Metro;
            this.txtCustomTabName.TabIndex = 10;
            this.txtCustomTabName.Text = "Palette";
            this.txtCustomTabName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCustomTabName_KeyDown);
            // 
            // cmbSelectedColorGroup
            // 
            this.cmbSelectedColorGroup.BackColor = System.Drawing.Color.White;
            this.cmbSelectedColorGroup.BeforeTouchSize = new System.Drawing.Size(169, 27);
            this.cmbSelectedColorGroup.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSelectedColorGroup.Items.AddRange(new object[] {
            "None",
            "CustomColors",
            "StandardColors",
            "SystemColors",
            "UserColors"});
            this.cmbSelectedColorGroup.Location = new System.Drawing.Point(227, 191);
            this.cmbSelectedColorGroup.Name = "cmbSelectedColorGroup";
            this.cmbSelectedColorGroup.Size = new System.Drawing.Size(169, 27);
            this.cmbSelectedColorGroup.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.cmbSelectedColorGroup.TabIndex = 9;
            this.cmbSelectedColorGroup.SelectedIndexChanged += new System.EventHandler(this.cmbSelectedColorGroup_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(59, 187);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(139, 19);
            this.label9.TabIndex = 8;
            this.label9.Text = "Selected Color Group";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(59, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 19);
            this.label6.TabIndex = 3;
            this.label6.Text = "Custom Tab Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(60, 96);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(128, 19);
            this.label7.TabIndex = 4;
            this.label7.Text = "Standard Tab Name";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(60, 143);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(117, 19);
            this.label8.TabIndex = 5;
            this.label8.Text = "System Tab Name";
            // 
            // cmbSelectedColorGroup1
            // 
            this.cmbSelectedColorGroup1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(242)))), ((int)(((byte)(251)))));
            this.cmbSelectedColorGroup1.BeforeTouchSize = new System.Drawing.Size(121, 24);
            this.cmbSelectedColorGroup1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSelectedColorGroup1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSelectedColorGroup1.Location = new System.Drawing.Point(168, 176);
            this.cmbSelectedColorGroup1.Name = "cmbSelectedColorGroup1";
            this.cmbSelectedColorGroup1.Size = new System.Drawing.Size(121, 24);
            this.cmbSelectedColorGroup1.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007;
            this.cmbSelectedColorGroup1.TabIndex = 17;
            // 
            // cmbOffice2007Theme
            // 
            this.cmbOffice2007Theme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(242)))), ((int)(((byte)(251)))));
            this.cmbOffice2007Theme.BeforeTouchSize = new System.Drawing.Size(98, 24);
            this.cmbOffice2007Theme.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOffice2007Theme.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbOffice2007Theme.Location = new System.Drawing.Point(164, 150);
            this.cmbOffice2007Theme.Name = "cmbOffice2007Theme";
            this.cmbOffice2007Theme.Size = new System.Drawing.Size(98, 24);
            this.cmbOffice2007Theme.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007;
            this.cmbOffice2007Theme.TabIndex = 7;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(20, 20);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1030, 81);
            this.panel3.TabIndex = 5;
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gradientPanel1.Controls.Add(this.gradientLabel1);
            this.gradientPanel1.Controls.Add(this.comboBoxAdv1);
            this.gradientPanel1.Controls.Add(this.label3);
            this.gradientPanel1.Controls.Add(this.chkSelectedAsText);
            this.gradientPanel1.Controls.Add(this.label6);
            this.gradientPanel1.Controls.Add(this.chkSelectedAsBackColor);
            this.gradientPanel1.Controls.Add(this.txtSystemTabName);
            this.gradientPanel1.Controls.Add(this.label8);
            this.gradientPanel1.Controls.Add(this.label7);
            this.gradientPanel1.Controls.Add(this.txtStandardTabName);
            this.gradientPanel1.Controls.Add(this.label9);
            this.gradientPanel1.Controls.Add(this.cmbSelectedColorGroup);
            this.gradientPanel1.Controls.Add(this.txtCustomTabName);
            this.gradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(489, 477);
            this.gradientPanel1.TabIndex = 6;
            // 
            // gradientLabel1
            // 
            this.gradientLabel1.BackgroundColor = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.Transparent);
            this.gradientLabel1.BeforeTouchSize = new System.Drawing.Size(489, 17);
            this.gradientLabel1.BorderAppearance = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gradientLabel1.BorderColor = System.Drawing.Color.Gray;
            this.gradientLabel1.BorderSides = System.Windows.Forms.Border3DSide.Bottom;
            this.gradientLabel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gradientLabel1.Location = new System.Drawing.Point(0, 0);
            this.gradientLabel1.Name = "gradientLabel1";
            this.gradientLabel1.Size = new System.Drawing.Size(507, 32);
            this.gradientLabel1.TabIndex = 14;
            this.gradientLabel1.Text = "Essential Properties";
            this.gradientLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBoxAdv1
            // 
            this.comboBoxAdv1.BackColor = System.Drawing.Color.White;
            this.comboBoxAdv1.BeforeTouchSize = new System.Drawing.Size(169, 27);
            this.comboBoxAdv1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAdv1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxAdv1.Items.AddRange(new object[] {
            "Default",
            "Office2010",
            "Metro",
            "Office2016Colorful",
            "Office2016White",
            "Office2016Black",
            "Office2016DarkGray"});
            this.comboBoxAdv1.Location = new System.Drawing.Point(227, 238);
            this.comboBoxAdv1.Name = "comboBoxAdv1";
            this.comboBoxAdv1.Size = new System.Drawing.Size(169, 27);
            this.comboBoxAdv1.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.comboBoxAdv1.TabIndex = 14;
            this.comboBoxAdv1.Text = "Default";
            this.comboBoxAdv1.SelectedIndexChanged += new System.EventHandler(this.comboBoxAdv1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 238);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 19);
            this.label3.TabIndex = 13;
            this.label3.Text = "Visual Style";
            // 
            // colorPickerButton1
            // 
            this.colorPickerButton1.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2016Colorful;
            this.colorPickerButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.colorPickerButton1.BeforeTouchSize = new System.Drawing.Size(225, 42);
            this.colorPickerButton1.ColorGroups = ((Syncfusion.Windows.Forms.ColorUIGroups)((((Syncfusion.Windows.Forms.ColorUIGroups.CustomColors | Syncfusion.Windows.Forms.ColorUIGroups.StandardColors) 
            | Syncfusion.Windows.Forms.ColorUIGroups.SystemColors) 
            | Syncfusion.Windows.Forms.ColorUIGroups.UserColors)));
            this.colorPickerButton1.ColorUISize = new System.Drawing.Size(208, 230);
            this.colorPickerButton1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.colorPickerButton1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colorPickerButton1.IsBackStageButton = false;
            this.colorPickerButton1.Location = new System.Drawing.Point(156, 176);
            this.colorPickerButton1.Name = "colorPickerButton1";
            this.colorPickerButton1.SelectedAsBackcolor = true;
            this.colorPickerButton1.SelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.colorPickerButton1.SelectedColorGroup = Syncfusion.Windows.Forms.ColorUISelectedGroup.StandardColors;
            this.colorPickerButton1.Size = new System.Drawing.Size(225, 42);
            this.colorPickerButton1.TabIndex = 0;
            this.colorPickerButton1.Text = "Color Picker Button";
            this.colorPickerButton1.UseVisualStyle = true;
            this.colorPickerButton1.UseVisualStyleBackColor = true;
            this.colorPickerButton1.ColorSelected += new System.EventHandler(this.colorPickerButton1_ColorSelected);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.Transparent;
            this.label20.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label20.Location = new System.Drawing.Point(138, 105);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(256, 17);
            this.label20.TabIndex = 3;
            this.label20.Text = "Click the button to show the color picker";
            // 
            // splitContainerAdv1
            // 
            this.splitContainerAdv1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainerAdv1.BeforeTouchSize = 7;
            this.splitContainerAdv1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainerAdv1.Location = new System.Drawing.Point(28, 113);
            this.splitContainerAdv1.Name = "splitContainerAdv1";
            // 
            // splitContainerAdv1.Panel1
            // 
            this.splitContainerAdv1.Panel1.Controls.Add(this.gradientLabel2);
            this.splitContainerAdv1.Panel1.Controls.Add(this.label20);
            this.splitContainerAdv1.Panel1.Controls.Add(this.colorPickerButton1);
            // 
            // splitContainerAdv1.Panel2
            // 
            this.splitContainerAdv1.Panel2.Controls.Add(this.gradientPanel1);
            this.splitContainerAdv1.Size = new System.Drawing.Size(1007, 479);
            this.splitContainerAdv1.SplitterDistance = 509;
            this.splitContainerAdv1.TabIndex = 7;
            this.splitContainerAdv1.Text = "splitContainerAdv1";
            // 
            // gradientLabel2
            // 
            this.gradientLabel2.BackgroundColor = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.Transparent);
            this.gradientLabel2.BeforeTouchSize = new System.Drawing.Size(507, 32);
            this.gradientLabel2.BorderAppearance = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gradientLabel2.BorderColor = System.Drawing.Color.Gray;
            this.gradientLabel2.BorderSides = System.Windows.Forms.Border3DSide.Bottom;
            this.gradientLabel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.gradientLabel2.Location = new System.Drawing.Point(0, 0);
            this.gradientLabel2.Name = "gradientLabel2";
            this.gradientLabel2.Size = new System.Drawing.Size(507, 32);
            this.gradientLabel2.TabIndex = 4;
            this.gradientLabel2.Text = "Sample";
            this.gradientLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(7, 19);
            this.BackColor = System.Drawing.Color.White;
            this.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.ClientSize = new System.Drawing.Size(1070, 783);
            this.Controls.Add(this.splitContainerAdv1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.textBox1);
            this.DropShadow = true;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MetroColor = System.Drawing.Color.White;
            this.MinimumSize = new System.Drawing.Size(947, 712);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ColorPickerButton";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.textBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkSelectedAsText)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSystemTabName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkSelectedAsBackColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStandardTabName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCustomTabName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbSelectedColorGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbSelectedColorGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbOffice2007Theme)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel1)).EndInit();
            this.gradientPanel1.ResumeLayout(false);
            this.gradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxAdv1)).EndInit();
            this.splitContainerAdv1.Panel1.ResumeLayout(false);
            this.splitContainerAdv1.Panel1.PerformLayout();
            this.splitContainerAdv1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerAdv1)).EndInit();
            this.splitContainerAdv1.ResumeLayout(false);
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

        private void Form1_Load(object sender, System.EventArgs e)
		{
			this.cmbSelectedColorGroup.SelectedIndex=0;
            this.comboBoxAdv1.SelectedIndex = 3;
            this.colorPickerButton1.BackColor = Color.FromArgb(22, 165, 220);
            this.colorPickerButton1.SelectedColor = Color.FromArgb(22, 165, 220);
		}

		#endregion

		#region EventLog

		private void Addlog(string logText)
		{
			this.textBox1.Text += logText +"\r\n";
		}
		#endregion

		#region ColorPickerButton Properties

		private void txtCustomTabName_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if(e.KeyCode == Keys.Enter)
			{
				this.colorPickerButton1.CustomTabName = this.txtCustomTabName.Text;
				Addlog("ColorPickerButton Custom Tab Name Changed to "+this.txtCustomTabName.Text);
			}
		}

		private void txtStandardTabName_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if(e.KeyCode == Keys.Enter)
			{
				this.colorPickerButton1.StandardTabName = this.txtStandardTabName.Text;
				Addlog("ColorPickerButton Standard Tab Name Changed to "+this.txtStandardTabName.Text);
			}
		}

		private void txtSystemTabName_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if(e.KeyCode == Keys.Enter)
			{
				this.colorPickerButton1.SystemTabName= this.txtSystemTabName.Text;
				Addlog("ColorPickerButton System Tab Name Changed to "+this.txtSystemTabName.Text);
			}
		}

		private void cmbSelectedColorGroup_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			switch(this.cmbSelectedColorGroup.Text)
			{
				case "None":
					this.colorPickerButton1.SelectedColorGroup = Syncfusion.Windows.Forms.ColorUISelectedGroup.None;
					break;
				case "CustomColors":
					this.colorPickerButton1.SelectedColorGroup = Syncfusion.Windows.Forms.ColorUISelectedGroup.CustomColors;
					break;
				case "StandardColors":
					this.colorPickerButton1.SelectedColorGroup = Syncfusion.Windows.Forms.ColorUISelectedGroup.StandardColors;
					break;
				case "SystemColors":
					this.colorPickerButton1.SelectedColorGroup = Syncfusion.Windows.Forms.ColorUISelectedGroup.SystemColors;
					break;
				case "UserColors":
					this.colorPickerButton1.SelectedColorGroup = Syncfusion.Windows.Forms.ColorUISelectedGroup.UserColors;
					break;
			}
			Addlog("ColorPickerButton's SelectedColorGroup changed to "+this.cmbSelectedColorGroup.Text);
		}

		private void chkSelectedAsBackColor_CheckedChanged(object sender, System.EventArgs e)
		{
            if (chkSelectedAsBackColor.Checked)
                this.colorPickerButton1.SelectedAsBackcolor = this.chkSelectedAsBackColor.Checked;
            else
                this.colorPickerButton1.BackColor = Color.FromArgb(22,165,220);
			Addlog("ColorPickerButton's \"SelectedAsBackcolor\" set to "+this.chkSelectedAsBackColor.Checked.ToString());
		}

		private void chkSelectedAsText_CheckedChanged(object sender, System.EventArgs e)
		{
			this.colorPickerButton1.SelectedAsText = this.chkSelectedAsText.Checked;
			Addlog("ColorPickerButton's \"SelectedAsText\" set to "+this.chkSelectedAsText.Checked.ToString());
		}

		private void colorPickerButton1_ColorSelected(object sender, System.EventArgs e)
		{
			this.splitContainerAdv1.Panel1.BackColor = this.colorPickerButton1.SelectedColor;
			Addlog("ColorPickerButton sets TabPage BackColor to "+this.colorPickerButton1.SelectedColor.ToString());
		}


        #endregion

        private void comboBoxAdv1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(this.comboBoxAdv1.SelectedItem.ToString().Equals("Default"))
            {
                this.comboBoxAdv1.Style = VisualStyle.Default;
                this.cmbSelectedColorGroup.Style = VisualStyle.Default;
                this.txtSystemTabName.Style = TextBoxExt.theme.Default;
                this.txtSystemTabName.BackColor = Color.White;
                this.txtSystemTabName.ForeColor = Color.Black;
                this.txtCustomTabName.Style = TextBoxExt.theme.Default;
                this.txtCustomTabName.BackColor = Color.White;
                this.txtCustomTabName.ForeColor = Color.Black;
                this.txtStandardTabName.Style = TextBoxExt.theme.Default;
                this.txtStandardTabName.BackColor = Color.White;
                this.txtStandardTabName.ForeColor = Color.Black;
                this.label3.ForeColor = Color.Black;
                this.label9.ForeColor = Color.Black;
                this.label7.ForeColor = Color.Black;
                this.label6.ForeColor = Color.Black;
                this.label1.ForeColor = Color.Black;
                this.label1.BackColor = Color.White;
                this.label20.ForeColor = Color.Black;
                this.gradientLabel2.ForeColor = Color.Black;
                this.gradientLabel1.ForeColor = Color.Black;
                this.label8.ForeColor = Color.Black;
                this.textBox1.BackColor = Color.White;
                this.chkSelectedAsBackColor.ForeColor = Color.Black;
                this.chkSelectedAsText.ForeColor = Color.Black;
                this.BackColor = Color.White;
                this.CaptionBarColor = this.MetroColor = Color.White;
                this.colorPickerButton1.Appearance = ButtonAppearance.Classic;
                this.CaptionForeColor = Color.Black;
                this.gradientLabel1.BorderColor = ColorTranslator.FromHtml("#767676");
                this.gradientLabel2.BorderColor = ColorTranslator.FromHtml("#767676");
            }
            else if(this.comboBoxAdv1.SelectedItem.ToString().Equals("Metro"))
            {
                this.comboBoxAdv1.Style = VisualStyle.Metro;
                this.cmbSelectedColorGroup.Style = VisualStyle.Metro;
                this.txtSystemTabName.Style = TextBoxExt.theme.Metro;
                this.txtSystemTabName.BackColor = Color.White;
                this.txtSystemTabName.ForeColor = Color.Black;
                this.txtCustomTabName.Style = TextBoxExt.theme.Metro;
                this.txtCustomTabName.BackColor = Color.White;
                this.txtCustomTabName.ForeColor = Color.Black;
                this.txtStandardTabName.Style = TextBoxExt.theme.Metro;
                this.txtStandardTabName.BackColor = Color.White;
                this.txtStandardTabName.ForeColor = Color.Black;
                this.label3.ForeColor = Color.Black;
                this.label9.ForeColor = Color.Black;
                this.label7.ForeColor = Color.Black;
                this.label6.ForeColor = Color.Black;
                this.label1.ForeColor = Color.Black;
                this.label20.ForeColor = Color.Black;
                this.gradientLabel2.ForeColor = Color.Black;
                this.gradientLabel1.ForeColor = Color.Black;
                this.label8.ForeColor = Color.Black;
                this.label1.BackColor = Color.White;
                this.textBox1.BackColor = Color.White;
                this.chkSelectedAsBackColor.ForeColor = Color.Black;
                this.chkSelectedAsText.ForeColor = Color.Black;
                this.BackColor = Color.White;
                this.CaptionBarColor = this.MetroColor = Color.White;
                this.colorPickerButton1.Appearance = ButtonAppearance.Metro;
                this.CaptionForeColor = Color.Black;
                this.gradientLabel1.BorderColor = ColorTranslator.FromHtml("#767676");
                this.gradientLabel2.BorderColor = ColorTranslator.FromHtml("#767676");
            }
            else if(this.comboBoxAdv1.SelectedItem.ToString().Equals("Office2010"))
            {
                this.comboBoxAdv1.Style = VisualStyle.Office2010;
                this.cmbSelectedColorGroup.Style = VisualStyle.Office2010;
                this.txtSystemTabName.Style = TextBoxExt.theme.Office2010;
                this.txtSystemTabName.BackColor = Color.White;
                this.txtSystemTabName.ForeColor = Color.Black;
                this.txtCustomTabName.Style = TextBoxExt.theme.Office2010;
                this.txtCustomTabName.BackColor = Color.White;
                this.txtCustomTabName.ForeColor = Color.Black;
                this.txtStandardTabName.Style = TextBoxExt.theme.Office2010;
                this.txtStandardTabName.BackColor = Color.White;
                this.txtStandardTabName.ForeColor = Color.Black;
                this.label3.ForeColor = Color.Black;
                this.label9.ForeColor = Color.Black;
                this.label7.ForeColor = Color.Black;
                this.label6.ForeColor = Color.Black;
                this.label1.ForeColor = Color.Black;
                this.label20.ForeColor = Color.Black;
                this.gradientLabel2.ForeColor = Color.Black;
                this.gradientLabel1.ForeColor = Color.Black;
                this.label8.ForeColor = Color.Black;
                this.label1.BackColor = Color.White;
                this.textBox1.BackColor = Color.White;
                this.chkSelectedAsBackColor.ForeColor = Color.Black;
                this.chkSelectedAsText.ForeColor = Color.Black;
                this.BackColor = Color.White;
                this.CaptionBarColor = this.MetroColor = Color.White;
                this.colorPickerButton1.Appearance = ButtonAppearance.Office2010;
                this.CaptionForeColor = Color.Black;
                this.gradientLabel1.BorderColor = ColorTranslator.FromHtml("#767676");
                this.gradientLabel2.BorderColor = ColorTranslator.FromHtml("#767676");
            }
            else if(this.comboBoxAdv1.SelectedItem.ToString().Equals("Office2016White"))
            {
                this.comboBoxAdv1.Style = VisualStyle.Office2016White;
                this.cmbSelectedColorGroup.Style = VisualStyle.Office2016White;
                this.colorPickerButton1.Appearance = ButtonAppearance.Office2016White;
                this.txtSystemTabName.Style = TextBoxExt.theme.Office2016White;
                this.txtCustomTabName.Style = TextBoxExt.theme.Office2016White;
                this.txtStandardTabName.Style = TextBoxExt.theme.Office2016White;
                this.label3.ForeColor = Color.Black;
                this.label9.ForeColor = Color.Black;
                this.label7.ForeColor = Color.Black;
                this.label6.ForeColor = Color.Black;
                this.label20.ForeColor = Color.Black;
                this.gradientLabel2.ForeColor = Color.Black;
                this.gradientLabel1.ForeColor = Color.Black;
                this.label1.ForeColor = Color.Black;
                this.label8.ForeColor = Color.Black;
                this.label1.BackColor = Color.White;
                this.textBox1.BackColor = Color.White;
                this.chkSelectedAsBackColor.ForeColor = Color.Black;
                this.chkSelectedAsText.ForeColor = Color.Black;
                this.BackColor = Color.White;
                this.CaptionBarColor = this.MetroColor = Color.White;
                this.CaptionForeColor = Color.Black;
                this.gradientLabel1.BorderColor = ColorTranslator.FromHtml("#767676");
                this.gradientLabel2.BorderColor = ColorTranslator.FromHtml("#767676");
            }
            else if(this.comboBoxAdv1.SelectedItem.ToString().Equals("Office2016Colorful"))
            {
                this.comboBoxAdv1.Style = VisualStyle.Office2016Colorful;
                this.cmbSelectedColorGroup.Style = VisualStyle.Office2016Colorful;
                this.txtSystemTabName.Style = TextBoxExt.theme.Office2016Colorful;
                this.txtCustomTabName.Style = TextBoxExt.theme.Office2016Colorful;
                this.txtStandardTabName.Style = TextBoxExt.theme.Office2016Colorful;
                this.label3.ForeColor = Color.Black;
                this.label9.ForeColor = Color.Black;
                this.label7.ForeColor = Color.Black;
                this.label6.ForeColor = Color.Black;
                this.label20.ForeColor = Color.Black;
                this.gradientLabel2.ForeColor = Color.Black;
                this.gradientLabel1.ForeColor = Color.Black;
                this.label1.ForeColor = Color.Black;
                this.label8.ForeColor = Color.Black;
                this.label1.BackColor = Color.White;
                this.textBox1.BackColor = Color.White;
                this.chkSelectedAsBackColor.ForeColor = Color.Black;
                this.chkSelectedAsText.ForeColor = Color.Black;
                this.BackColor = Color.White;
                this.CaptionBarColor = this.MetroColor = Color.White;
                this.colorPickerButton1.Appearance = ButtonAppearance.Office2016Colorful;
                this.CaptionForeColor = Color.Black;
                this.gradientLabel1.BorderColor = ColorTranslator.FromHtml("#767676");
                this.gradientLabel2.BorderColor = ColorTranslator.FromHtml("#767676");
            }
            else if(this.comboBoxAdv1.SelectedItem.ToString().Equals("Office2016Black"))
            {
                this.comboBoxAdv1.Style = VisualStyle.Office2016Black;
                this.cmbSelectedColorGroup.Style = VisualStyle.Office2016Black;
                this.txtSystemTabName.Style = TextBoxExt.theme.Office2016Black;
                this.txtCustomTabName.Style = TextBoxExt.theme.Office2016Black;
                this.txtStandardTabName.Style = TextBoxExt.theme.Office2016Black;
                this.label3.ForeColor = Color.White;
                this.label9.ForeColor = Color.White;
                this.label8.ForeColor = Color.White;
                this.label7.ForeColor = Color.White;
                this.label6.ForeColor = Color.White;
                this.label1.ForeColor = Color.White;
                this.label20.ForeColor = Color.White;
                this.gradientLabel2.ForeColor = Color.White;
                this.gradientLabel1.ForeColor = Color.White;
                this.textBox1.BackColor = Color.Black;
                this.BackColor = ColorTranslator.FromHtml("#262626");
                this.label1.BackColor = ColorTranslator.FromHtml("#262626");
                this.chkSelectedAsBackColor.ForeColor = Color.White;
                this.chkSelectedAsText.ForeColor = Color.White;
                this.CaptionBarColor = this.MetroColor = ColorTranslator.FromHtml("#262626");
                this.colorPickerButton1.Appearance = ButtonAppearance.Office2016Black;
                this.CaptionForeColor = Color.White;
                this.gradientLabel1.BorderColor = ColorTranslator.FromHtml("#535353");
                this.gradientLabel2.BorderColor = ColorTranslator.FromHtml("#535353");
                this.textBox1.BorderColor = ColorTranslator.FromHtml("#535353");
            }
            else if(this.comboBoxAdv1.SelectedItem.ToString().Equals("Office2016DarkGray"))
            {
                this.comboBoxAdv1.Style = VisualStyle.Office2016DarkGray;
                this.cmbSelectedColorGroup.Style = VisualStyle.Office2016DarkGray;
                this.txtSystemTabName.Style = TextBoxExt.theme.Office2016DarkGray;
                this.txtCustomTabName.Style = TextBoxExt.theme.Office2016DarkGray;
                this.txtStandardTabName.Style = TextBoxExt.theme.Office2016DarkGray;
                this.label3.ForeColor = Color.LightGray;
                this.label9.ForeColor = Color.LightGray;
                this.label7.ForeColor = Color.LightGray;
                this.label6.ForeColor = Color.LightGray;
                this.label20.ForeColor = Color.LightGray;
                this.gradientLabel2.ForeColor = Color.LightGray;
                this.gradientLabel1.ForeColor = Color.LightGray;
                this.label8.ForeColor = Color.LightGray;
                this.label1.ForeColor = Color.LightGray;
                this.textBox1.BackColor = Color.LightGray;
                this.BackColor = ColorTranslator.FromHtml("#7c7c7c");
                this.label1.BackColor = ColorTranslator.FromHtml("#7c7c7c");
                this.chkSelectedAsText.ForeColor = Color.LightGray; ;
                this.chkSelectedAsBackColor.ForeColor = Color.LightGray;
                this.CaptionBarColor = this.MetroColor = ColorTranslator.FromHtml("#666666");
                this.colorPickerButton1.Appearance = ButtonAppearance.Office2016DarkGray;
                this.CaptionForeColor = Color.LightGray;
                this.gradientLabel1.BorderColor = ColorTranslator.FromHtml("#666666");
                this.gradientLabel2.BorderColor = ColorTranslator.FromHtml("#666666");
                this.textBox1.BorderColor = ColorTranslator.FromHtml("#666666");


            }
        }
    }
}

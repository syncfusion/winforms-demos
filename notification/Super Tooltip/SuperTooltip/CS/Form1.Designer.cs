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

using Syncfusion.Windows.Forms.Tools;
namespace SuperToolTipDemo_2005
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose (bool disposing)
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
		private void InitializeComponent ( )
		{
            this.components = new System.ComponentModel.Container();
            Syncfusion.Windows.Forms.Tools.ToolTipInfo toolTipInfo8 = new Syncfusion.Windows.Forms.Tools.ToolTipInfo();
            Syncfusion.Windows.Forms.Tools.ToolTipInfo toolTipInfo9 = new Syncfusion.Windows.Forms.Tools.ToolTipInfo();
            Syncfusion.Windows.Forms.Tools.ToolTipInfo toolTipInfo10 = new Syncfusion.Windows.Forms.Tools.ToolTipInfo();
            Syncfusion.Windows.Forms.Tools.ToolTipInfo toolTipInfo11 = new Syncfusion.Windows.Forms.Tools.ToolTipInfo();
            Syncfusion.Windows.Forms.Tools.ToolTipInfo toolTipInfo7 = new Syncfusion.Windows.Forms.Tools.ToolTipInfo();
            Syncfusion.Windows.Forms.Tools.ToolTipInfo toolTipInfo12 = new Syncfusion.Windows.Forms.Tools.ToolTipInfo();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.superToolTip1 = new Syncfusion.Windows.Forms.Tools.SuperToolTip(this);
            this.gradientLabel1 = new Syncfusion.Windows.Forms.Tools.GradientLabel();
            this.gradientLabel2 = new Syncfusion.Windows.Forms.Tools.GradientLabel();
            this.gradientLabel3 = new Syncfusion.Windows.Forms.Tools.GradientLabel();
            this.checkBox1 = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.gradientLabel4 = new Syncfusion.Windows.Forms.Tools.GradientLabel();
            this.gradientLabel5 = new Syncfusion.Windows.Forms.Tools.GradientLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonAdv4 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.statusStripEx1 = new Syncfusion.Windows.Forms.Tools.StatusStripEx();
            this.statusStripLabel1 = new Syncfusion.Windows.Forms.Tools.StatusStripLabel();
            this.gradientLabel6 = new Syncfusion.Windows.Forms.Tools.GradientLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.textBox1 = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.textBox3 = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox1 = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.comboBoxAdv1 = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.colorPickerUIAdv1 = new Syncfusion.Windows.Forms.Tools.ColorPickerUIAdv();
            this.label6 = new Syncfusion.Windows.Forms.Tools.GradientLabel();
            this.label7 = new System.Windows.Forms.Label();
            this.splitContainerAdv1 = new Syncfusion.Windows.Forms.Tools.SplitContainerAdv();
            this.popupControlContainer1 = new Syncfusion.Windows.Forms.PopupControlContainer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.checkBox1)).BeginInit();
            this.statusStripEx1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBox3)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxAdv1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerAdv1)).BeginInit();
            this.splitContainerAdv1.Panel1.SuspendLayout();
            this.splitContainerAdv1.Panel2.SuspendLayout();
            this.splitContainerAdv1.SuspendLayout();
            this.popupControlContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // superToolTip1
            // 
            this.superToolTip1.InitialDelay = 1000;
            this.superToolTip1.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218)))));
            this.superToolTip1.ToolTipDuration = 5;
            this.superToolTip1.PopupToolTip += new Syncfusion.Windows.Forms.Tools.PopupToolTipHandler(this.superToolTip1_PopupToolTip);
            // 
            // gradientLabel1
            // 
            this.gradientLabel1.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(240)))), ((int)(((byte)(247))))), System.Drawing.Color.LightCyan);
            this.gradientLabel1.BeforeTouchSize = new System.Drawing.Size(181, 27);
            this.gradientLabel1.BorderSides = ((System.Windows.Forms.Border3DSide)((((System.Windows.Forms.Border3DSide.Left | System.Windows.Forms.Border3DSide.Top) 
            | System.Windows.Forms.Border3DSide.Right) 
            | System.Windows.Forms.Border3DSide.Bottom)));
            this.gradientLabel1.Location = new System.Drawing.Point(25, 29);
            this.gradientLabel1.Name = "gradientLabel1";
            this.gradientLabel1.Size = new System.Drawing.Size(181, 27);
            this.gradientLabel1.TabIndex = 30;
            this.gradientLabel1.Text = "Super ToolTip with Header Image";
            this.gradientLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            toolTipInfo8.Body.Size = new System.Drawing.Size(20, 20);
            toolTipInfo8.Body.Text = "Images can be added to the Super Tooltip Header. \r\nThe size of the Image can  be " +
    "changed using \r\nImage Scaling Size property";
            toolTipInfo8.Body.TextMargin = new System.Windows.Forms.Padding(3);
            toolTipInfo8.Footer.Size = new System.Drawing.Size(20, 20);
            toolTipInfo8.Footer.Text = "ToolTip\'s Image and Text can be aligned using \r\n  ImageAlign and TextAlign proper" +
    "ties.";
            toolTipInfo8.Footer.TextMargin = new System.Windows.Forms.Padding(3);
            toolTipInfo8.Header.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            toolTipInfo8.Header.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            toolTipInfo8.Header.Size = new System.Drawing.Size(20, 20);
            toolTipInfo8.Header.Text = "Super ToolTip with  Header Image";
            toolTipInfo8.Header.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            toolTipInfo8.Header.TextMargin = new System.Windows.Forms.Padding(3);
            this.superToolTip1.SetToolTip(this.gradientLabel1, toolTipInfo8);
            // 
            // gradientLabel2
            // 
            this.gradientLabel2.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(240)))), ((int)(((byte)(247))))), System.Drawing.Color.LightCyan);
            this.gradientLabel2.BeforeTouchSize = new System.Drawing.Size(181, 27);
            this.gradientLabel2.BorderSides = ((System.Windows.Forms.Border3DSide)((((System.Windows.Forms.Border3DSide.Left | System.Windows.Forms.Border3DSide.Top) 
            | System.Windows.Forms.Border3DSide.Right) 
            | System.Windows.Forms.Border3DSide.Bottom)));
            this.gradientLabel2.Location = new System.Drawing.Point(25, 108);
            this.gradientLabel2.Name = "gradientLabel2";
            this.gradientLabel2.Size = new System.Drawing.Size(181, 27);
            this.gradientLabel2.TabIndex = 31;
            this.gradientLabel2.Text = "Super ToolTip with Image in Body";
            this.gradientLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            toolTipInfo9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            toolTipInfo9.Body.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            toolTipInfo9.Body.Size = new System.Drawing.Size(20, 20);
            toolTipInfo9.Body.Text = "SuperTooltip can have Image and Text \r\nin body portion.";
            toolTipInfo9.Body.TextMargin = new System.Windows.Forms.Padding(3);
            toolTipInfo9.Footer.Size = new System.Drawing.Size(20, 20);
            toolTipInfo9.Footer.Text = "The margin of the ToolTip Text can be set using\r\nTextMargin.";
            toolTipInfo9.Footer.TextMargin = new System.Windows.Forms.Padding(3);
            toolTipInfo9.Header.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            toolTipInfo9.Header.Size = new System.Drawing.Size(20, 20);
            toolTipInfo9.Header.Text = "SuperToolTip Image in Body";
            toolTipInfo9.Header.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            toolTipInfo9.Header.TextMargin = new System.Windows.Forms.Padding(3);
            this.superToolTip1.SetToolTip(this.gradientLabel2, toolTipInfo9);
            // 
            // gradientLabel3
            // 
            this.gradientLabel3.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(240)))), ((int)(((byte)(247))))), System.Drawing.Color.LightCyan);
            this.gradientLabel3.BeforeTouchSize = new System.Drawing.Size(181, 27);
            this.gradientLabel3.BorderSides = ((System.Windows.Forms.Border3DSide)((((System.Windows.Forms.Border3DSide.Left | System.Windows.Forms.Border3DSide.Top) 
            | System.Windows.Forms.Border3DSide.Right) 
            | System.Windows.Forms.Border3DSide.Bottom)));
            this.gradientLabel3.Location = new System.Drawing.Point(25, 185);
            this.gradientLabel3.Name = "gradientLabel3";
            this.gradientLabel3.Size = new System.Drawing.Size(181, 27);
            this.gradientLabel3.TabIndex = 32;
            this.gradientLabel3.Text = "Super ToolTip with Footer Image";
            this.gradientLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            toolTipInfo10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(197)))), ((int)(((byte)(124)))));
            toolTipInfo10.Body.Size = new System.Drawing.Size(20, 20);
            toolTipInfo10.Body.Text = "SuperTooltip can have Image and Text in Footer.";
            toolTipInfo10.Body.TextMargin = new System.Windows.Forms.Padding(3);
            toolTipInfo10.BorderColor = System.Drawing.SystemColors.ControlDark;
            toolTipInfo10.Footer.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image2")));
            toolTipInfo10.Footer.Size = new System.Drawing.Size(20, 20);
            toolTipInfo10.Footer.Text = "The image can be positioned before or after the Text \r\nusing  the Text Image Rela" +
    "tion property.";
            toolTipInfo10.Footer.TextMargin = new System.Windows.Forms.Padding(3);
            toolTipInfo10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            toolTipInfo10.Header.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            toolTipInfo10.Header.Size = new System.Drawing.Size(20, 20);
            toolTipInfo10.Header.Text = "Super ToolTip with Footer Image";
            toolTipInfo10.Header.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            toolTipInfo10.Header.TextMargin = new System.Windows.Forms.Padding(3);
            this.superToolTip1.SetToolTip(this.gradientLabel3, toolTipInfo10);
            // 
            // checkBox1
            // 
            this.checkBox1.BeforeTouchSize = new System.Drawing.Size(150, 21);
            this.checkBox1.DrawFocusRectangle = false;
            this.checkBox1.ImageCheckBoxSize = new System.Drawing.Size(20, 20);
            this.checkBox1.Location = new System.Drawing.Point(10, 19);
            this.checkBox1.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(179, 31);
            this.checkBox1.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Super ToolTip with Right-To-Left support";
            this.checkBox1.ThemesEnabled = false;
            toolTipInfo11.Body.Size = new System.Drawing.Size(20, 20);
            toolTipInfo11.Body.Text = "SuperToolTip with RightToLeft support";
            toolTipInfo11.Body.TextMargin = new System.Windows.Forms.Padding(3);
            toolTipInfo11.Footer.Size = new System.Drawing.Size(20, 20);
            toolTipInfo11.Header.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            toolTipInfo11.Header.Size = new System.Drawing.Size(20, 20);
            toolTipInfo11.Header.Text = "RightToLeft";
            toolTipInfo11.Header.TextMargin = new System.Windows.Forms.Padding(3);
            this.superToolTip1.SetToolTip(this.checkBox1, toolTipInfo11);
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // gradientLabel4
            // 
            this.gradientLabel4.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(240)))), ((int)(((byte)(247))))), System.Drawing.Color.LightCyan);
            this.gradientLabel4.BeforeTouchSize = new System.Drawing.Size(198, 40);
            this.gradientLabel4.BorderSides = ((System.Windows.Forms.Border3DSide)((((System.Windows.Forms.Border3DSide.Left | System.Windows.Forms.Border3DSide.Top) 
            | System.Windows.Forms.Border3DSide.Right) 
            | System.Windows.Forms.Border3DSide.Bottom)));
            this.gradientLabel4.Location = new System.Drawing.Point(23, 301);
            this.gradientLabel4.Name = "gradientLabel4";
            this.gradientLabel4.Size = new System.Drawing.Size(198, 40);
            this.gradientLabel4.TabIndex = 41;
            this.gradientLabel4.Text = "Hover here to show the Tool Tip with HTML strings";
            this.gradientLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            toolTipInfo7.Body.RenderHtml = true;
            toolTipInfo7.Body.Size = new System.Drawing.Size(200, 20);
            toolTipInfo7.Body.Text = "<center><font face=\"Century Gothic\" size=\"10\" color=\"#FF0000\"><b>Body</b> in cent" +
    "er alignment</font></center>";
            toolTipInfo7.Footer.RenderHtml = true;
            toolTipInfo7.Footer.Size = new System.Drawing.Size(250, 20);
            toolTipInfo7.Footer.Text = "<center><font face=\"Courier New\" size=\"11\" color=\"#0000FF\"><u>Footer</u> in Blue " +
    "Underline</font></center>";
            toolTipInfo7.Header.RenderHtml = true;
            toolTipInfo7.Header.Size = new System.Drawing.Size(20, 20);
            toolTipInfo7.Header.Text = "<center><font style=\"font-size:12px;\" face=\"Verdana\"  color=\"#000000\"><i>Header</" +
    "i> In Italic</font></center>";
            this.superToolTip1.SetToolTip(this.gradientLabel4, toolTipInfo7);
            // 
            // gradientLabel5
            // 
            this.gradientLabel5.BackgroundColor = new Syncfusion.Drawing.BrushInfo();
            this.gradientLabel5.BeforeTouchSize = new System.Drawing.Size(175, 29);
            this.gradientLabel5.BorderSides = ((System.Windows.Forms.Border3DSide)((((System.Windows.Forms.Border3DSide.Left | System.Windows.Forms.Border3DSide.Top) 
            | System.Windows.Forms.Border3DSide.Right) 
            | System.Windows.Forms.Border3DSide.Bottom)));
            this.gradientLabel5.Location = new System.Drawing.Point(10, 31);
            this.gradientLabel5.Name = "gradientLabel5";
            this.gradientLabel5.Size = new System.Drawing.Size(175, 29);
            this.gradientLabel5.TabIndex = 40;
            this.gradientLabel5.Text = "ToolTip will be displaced above  the mouse pointer\r\n";
            this.gradientLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            toolTipInfo12.Body.Size = new System.Drawing.Size(20, 20);
            toolTipInfo12.Body.Text = "Super ToolTip can be added to any .NET control \r\nsuch as\r\n\r\n * MenuStrip\r\n * Tool" +
    "Strip\r\n * ToolStripEx\r\n * Grid\r\n * Chart\r\n * And on any Syncfusion controls\r\n\r\n";
            toolTipInfo12.Body.TextMargin = new System.Windows.Forms.Padding(3);
            toolTipInfo12.Footer.Size = new System.Drawing.Size(20, 20);
            toolTipInfo12.Footer.Text = "Show the SuperToolTip on any .NET control.";
            toolTipInfo12.Footer.TextMargin = new System.Windows.Forms.Padding(3);
            toolTipInfo12.Header.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            toolTipInfo12.Header.Size = new System.Drawing.Size(20, 20);
            toolTipInfo12.Header.Text = "SuperToolTip On Any .NET control";
            toolTipInfo12.Header.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            toolTipInfo12.Header.TextMargin = new System.Windows.Forms.Padding(3);
            this.superToolTip1.SetToolTip(this.gradientLabel5, toolTipInfo12);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 0;
            // 
            // buttonAdv4
            // 
            this.buttonAdv4.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.buttonAdv4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218)))));
            this.buttonAdv4.BeforeTouchSize = new System.Drawing.Size(180, 27);
            this.buttonAdv4.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.RaisedInner;
            this.buttonAdv4.ForeColor = System.Drawing.Color.White;
            this.buttonAdv4.Image = ((System.Drawing.Image)(resources.GetObject("buttonAdv4.Image")));
            this.buttonAdv4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonAdv4.IsBackStageButton = false;
            this.buttonAdv4.KeepFocusRectangle = false;
            this.buttonAdv4.Location = new System.Drawing.Point(10, 19);
            this.buttonAdv4.Name = "buttonAdv4";
            this.buttonAdv4.Size = new System.Drawing.Size(180, 27);
            this.buttonAdv4.TabIndex = 26;
            this.buttonAdv4.Text = "Select a color and hover";
            this.buttonAdv4.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.buttonAdv4.UseVisualStyle = true;
            this.buttonAdv4.Click += new System.EventHandler(this.buttonAdv4_Click);
            // 
            // statusStripEx1
            // 
            this.statusStripEx1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.statusStripEx1.BeforeTouchSize = new System.Drawing.Size(832, 23);
            this.statusStripEx1.Dock = Syncfusion.Windows.Forms.Tools.DockStyleEx.Bottom;
            this.statusStripEx1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStripEx1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusStripLabel1});
            this.statusStripEx1.Location = new System.Drawing.Point(30, 475);
            this.statusStripEx1.MetroColor = System.Drawing.Color.Empty;
            this.statusStripEx1.Name = "statusStripEx1";
            this.statusStripEx1.OfficeColorScheme = Syncfusion.Windows.Forms.Tools.ToolStripEx.ColorScheme.Black;
            this.statusStripEx1.Size = new System.Drawing.Size(832, 23);
            this.statusStripEx1.SizingGrip = false;
            this.statusStripEx1.TabIndex = 16;
            this.statusStripEx1.Text = "statusStripEx1";
            this.statusStripEx1.VisualStyle = Syncfusion.Windows.Forms.Tools.StatusStripExStyle.Office2016White;
            // 
            // statusStripLabel1
            // 
            this.statusStripLabel1.BackColor = System.Drawing.Color.Transparent;
            this.statusStripLabel1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.statusStripLabel1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.statusStripLabel1.Margin = new System.Windows.Forms.Padding(0, 4, 0, 2);
            this.statusStripLabel1.Name = "statusStripLabel1";
            this.statusStripLabel1.Size = new System.Drawing.Size(422, 17);
            this.statusStripLabel1.Text = " Hover mouse pointer over the Controls  to view the Super ToolTips";
            // 
            // gradientLabel6
            // 
            this.gradientLabel6.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(240)))), ((int)(((byte)(247))))), System.Drawing.Color.LightCyan);
            this.gradientLabel6.BeforeTouchSize = new System.Drawing.Size(79, 23);
            this.gradientLabel6.BorderSides = ((System.Windows.Forms.Border3DSide)((((System.Windows.Forms.Border3DSide.Left | System.Windows.Forms.Border3DSide.Top) 
            | System.Windows.Forms.Border3DSide.Right) 
            | System.Windows.Forms.Border3DSide.Bottom)));
            this.gradientLabel6.Location = new System.Drawing.Point(100, 261);
            this.gradientLabel6.Name = "gradientLabel6";
            this.gradientLabel6.Size = new System.Drawing.Size(79, 23);
            this.gradientLabel6.TabIndex = 36;
            this.gradientLabel6.Text = "Preview";
            this.gradientLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.gradientLabel6.MouseHover += new System.EventHandler(this.gradientLabel6_MouseHover);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(20, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 19);
            this.label3.TabIndex = 34;
            this.label3.Text = "Footer Text";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(20, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 19);
            this.label2.TabIndex = 34;
            this.label2.Text = "Body Text";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(19, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 19);
            this.label1.TabIndex = 34;
            this.label1.Text = "Header Text";
            // 
            // textBox2
            // 
            this.textBox2.BeforeTouchSize = new System.Drawing.Size(108, 26);
            this.textBox2.BorderColor = System.Drawing.Color.Gray;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox2.Location = new System.Drawing.Point(100, 175);
            this.textBox2.Metrocolor = System.Drawing.Color.Gray;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(108, 26);
            this.textBox2.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Metro;
            this.textBox2.TabIndex = 3;
            this.textBox2.ThemesEnabled = false;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.BeforeTouchSize = new System.Drawing.Size(108, 26);
            this.textBox1.BorderColor = System.Drawing.Color.Gray;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox1.Location = new System.Drawing.Point(100, 133);
            this.textBox1.Metrocolor = System.Drawing.Color.Gray;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(108, 26);
            this.textBox1.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Metro;
            this.textBox1.TabIndex = 1;
            this.textBox1.ThemesEnabled = false;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.BeforeTouchSize = new System.Drawing.Size(108, 26);
            this.textBox3.BorderColor = System.Drawing.Color.Gray;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox3.Location = new System.Drawing.Point(100, 222);
            this.textBox3.Metrocolor = System.Drawing.Color.Gray;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(108, 26);
            this.textBox3.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Metro;
            this.textBox3.TabIndex = 33;
            this.textBox3.ThemesEnabled = false;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.gradientLabel1);
            this.groupBox1.Controls.Add(this.gradientLabel2);
            this.groupBox1.Controls.Add(this.gradientLabel3);
            this.groupBox1.Location = new System.Drawing.Point(52, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(253, 259);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Image Support";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.buttonAdv4);
            this.groupBox2.Location = new System.Drawing.Point(337, 39);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(197, 69);
            this.groupBox2.TabIndex = 36;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Change Color";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.gradientLabel5);
            this.groupBox3.Location = new System.Drawing.Point(337, 224);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(195, 74);
            this.groupBox3.TabIndex = 37;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Custom Location";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Transparent;
            this.groupBox4.Controls.Add(this.checkBox1);
            this.groupBox4.Location = new System.Drawing.Point(337, 133);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(195, 71);
            this.groupBox4.TabIndex = 38;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Right To Left";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(20, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 27);
            this.label5.TabIndex = 39;
            this.label5.Text = "Style";
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.White;
            this.comboBox1.BeforeTouchSize = new System.Drawing.Size(121, 27);
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.Items.AddRange(new object[] {
            "Normal",
            "Balloon"});
            this.comboBox1.Location = new System.Drawing.Point(100, 54);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 27);
            this.comboBox1.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.comboBox1.TabIndex = 40;
            this.comboBox1.Text = "Normal";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBoxAdv1
            // 
            this.comboBoxAdv1.BackColor = System.Drawing.Color.White;
            this.comboBoxAdv1.BeforeTouchSize = new System.Drawing.Size(121, 27);
            this.comboBoxAdv1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAdv1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxAdv1.Items.AddRange(new object[] {
            "Default",
            "Metro",
            "Office2016Colorful",
            "Office2016White",
            "Office2016Black",
            "Office2016DarkGray"});
            this.comboBoxAdv1.Location = new System.Drawing.Point(100, 93);
            this.comboBoxAdv1.Name = "comboBoxAdv1";
            this.comboBoxAdv1.Size = new System.Drawing.Size(121, 27);
            this.comboBoxAdv1.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.comboBoxAdv1.TabIndex = 42;
            this.comboBoxAdv1.Text = "Default";
            this.comboBoxAdv1.SelectedIndexChanged += new System.EventHandler(this.comboBoxAdv1_SelectedIndexChanged);
            // 
            // colorPickerUIAdv1.RecentGroup
            // 
            this.colorPickerUIAdv1.RecentGroup.HeaderHeight = 19;
            this.colorPickerUIAdv1.RecentGroup.Name = "Recent Colors";
            this.colorPickerUIAdv1.RecentGroup.Visible = false;
            // 
            // colorPickerUIAdv1.StandardGroup
            // 
            this.colorPickerUIAdv1.StandardGroup.HeaderHeight = 19;
            this.colorPickerUIAdv1.StandardGroup.Name = "Standard Colors";
            // 
            // colorPickerUIAdv1.ThemeGroup
            // 
            this.colorPickerUIAdv1.ThemeGroup.HeaderHeight = 19;
            this.colorPickerUIAdv1.ThemeGroup.IsSubItemsVisible = true;
            this.colorPickerUIAdv1.ThemeGroup.Name = "Theme Colors";
            // 
            // colorPickerUIAdv1
            // 
            this.colorPickerUIAdv1.BeforeTouchSize = new System.Drawing.Size(13, 13);
            this.colorPickerUIAdv1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.colorPickerUIAdv1.ButtonsHeight = 27;
            this.colorPickerUIAdv1.ColorItemSize = new System.Drawing.Size(17, 17);
            this.colorPickerUIAdv1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.colorPickerUIAdv1.Location = new System.Drawing.Point(0, 0);
            this.colorPickerUIAdv1.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(110)))), ((int)(((byte)(218)))));
            this.colorPickerUIAdv1.MinimumSize = new System.Drawing.Size(136, 201);
            this.colorPickerUIAdv1.Name = "colorPickerUIAdv1";
            this.colorPickerUIAdv1.SelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(52)))), ((int)(((byte)(74)))));
            this.colorPickerUIAdv1.Size = new System.Drawing.Size(172, 205);
            this.colorPickerUIAdv1.Style = Syncfusion.Windows.Forms.Tools.ColorPickerUIAdv.visualstyle.Metro;
            this.colorPickerUIAdv1.TabIndex = 39;
            this.colorPickerUIAdv1.Text = "colorPickerUIAdv1";
            this.colorPickerUIAdv1.UseOffice2007Style = false;
            this.colorPickerUIAdv1.VerticalItemsSpacing = 2;
            this.colorPickerUIAdv1.Picked += new Syncfusion.Windows.Forms.Tools.ColorPickerUIAdv.ColorPickedEventHandler(this.colorPickerUIAdv1_Picked_1);
            // 
            // label6
            // 
            this.label6.BackgroundColor = new Syncfusion.Drawing.BrushInfo();
            this.label6.BeforeTouchSize = new System.Drawing.Size(832, 42);
            this.label6.BorderSides = ((System.Windows.Forms.Border3DSide)((((System.Windows.Forms.Border3DSide.Left | System.Windows.Forms.Border3DSide.Top) 
            | System.Windows.Forms.Border3DSide.Right) 
            | System.Windows.Forms.Border3DSide.Bottom)));
            this.label6.Dock = System.Windows.Forms.DockStyle.Top;
            this.label6.Location = new System.Drawing.Point(30, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(832, 42);
            this.label6.TabIndex = 43;
            this.label6.Text = "Using SuperToolTip users can set any background color for the ToolTip. They can a" +
    "lso set a border color for the Super ToolTip by using the BorderColor property.\r" +
    "\n";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(19, 93);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 19);
            this.label7.TabIndex = 43;
            this.label7.Text = "Visual Style";
            // 
            // splitContainerAdv1
            // 
            this.splitContainerAdv1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainerAdv1.BeforeTouchSize = 13;
            this.splitContainerAdv1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainerAdv1.IsSplitterFixed = true;
            this.splitContainerAdv1.Location = new System.Drawing.Point(30, 96);
            this.splitContainerAdv1.Name = "splitContainerAdv1";
            // 
            // splitContainerAdv1.Panel1
            // 
            this.splitContainerAdv1.Panel1.Controls.Add(this.groupBox1);
            this.splitContainerAdv1.Panel1.Controls.Add(this.groupBox2);
            this.splitContainerAdv1.Panel1.Controls.Add(this.groupBox3);
            this.splitContainerAdv1.Panel1.Controls.Add(this.groupBox4);
            this.splitContainerAdv1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainerAdv1_Panel1_Paint);
            // 
            // splitContainerAdv1.Panel2
            // 
            this.splitContainerAdv1.Panel2.Controls.Add(this.label7);
            this.splitContainerAdv1.Panel2.Controls.Add(this.comboBoxAdv1);
            this.splitContainerAdv1.Panel2.Controls.Add(this.gradientLabel4);
            this.splitContainerAdv1.Panel2.Controls.Add(this.gradientLabel6);
            this.splitContainerAdv1.Panel2.Controls.Add(this.label3);
            this.splitContainerAdv1.Panel2.Controls.Add(this.label1);
            this.splitContainerAdv1.Panel2.Controls.Add(this.comboBox1);
            this.splitContainerAdv1.Panel2.Controls.Add(this.label5);
            this.splitContainerAdv1.Panel2.Controls.Add(this.label2);
            this.splitContainerAdv1.Panel2.Controls.Add(this.textBox3);
            this.splitContainerAdv1.Panel2.Controls.Add(this.textBox1);
            this.splitContainerAdv1.Panel2.Controls.Add(this.textBox2);
            this.splitContainerAdv1.Size = new System.Drawing.Size(833, 374);
            this.splitContainerAdv1.SplitterDistance = 573;
            this.splitContainerAdv1.SplitterWidth = 13;
            this.splitContainerAdv1.TabIndex = 44;
            this.splitContainerAdv1.Text = "splitContainerAdv1";
            // 
            // popupControlContainer1
            // 
            this.popupControlContainer1.Controls.Add(this.colorPickerUIAdv1);
            this.popupControlContainer1.Location = new System.Drawing.Point(894, 493);
            this.popupControlContainer1.Name = "popupControlContainer1";
            this.popupControlContainer1.ParentControl = this.buttonAdv4;
            this.popupControlContainer1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.popupControlContainer1.Size = new System.Drawing.Size(172, 205);
            this.popupControlContainer1.TabIndex = 45;
            this.popupControlContainer1.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.ClientSize = new System.Drawing.Size(892, 528);
            this.Controls.Add(this.statusStripEx1);
            this.Controls.Add(this.popupControlContainer1);
            this.Controls.Add(this.splitContainerAdv1);
            this.Controls.Add(this.label6);
            this.DropShadow = true;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MetroColor = System.Drawing.Color.White;
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(30);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Super ToolTip ";
            ((System.ComponentModel.ISupportInitialize)(this.checkBox1)).EndInit();
            this.statusStripEx1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.textBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBox3)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.comboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxAdv1)).EndInit();
            this.splitContainerAdv1.Panel1.ResumeLayout(false);
            this.splitContainerAdv1.Panel2.ResumeLayout(false);
            this.splitContainerAdv1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerAdv1)).EndInit();
            this.splitContainerAdv1.ResumeLayout(false);
            this.popupControlContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

        private Syncfusion.Windows.Forms.Tools.SuperToolTip superToolTip1;
        private Syncfusion.Windows.Forms.Tools.StatusStripEx statusStripEx1;
        private TextBoxExt textBox1;
        private Syncfusion.Windows.Forms.ButtonAdv buttonAdv4;
        private Syncfusion.Windows.Forms.Tools.GradientLabel gradientLabel3;
        private Syncfusion.Windows.Forms.Tools.GradientLabel gradientLabel2;
        private Syncfusion.Windows.Forms.Tools.GradientLabel gradientLabel1;
        private Syncfusion.Windows.Forms.Tools.GradientLabel gradientLabel6;
        private TextBoxExt textBox2;
        private TextBoxExt textBox3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private Syncfusion.Windows.Forms.Tools.StatusStripLabel statusStripLabel1;
        private System.Windows.Forms.GroupBox groupBox4;
        private CheckBoxAdv checkBox1;
        private System.Windows.Forms.Label label4;
        private ComboBoxAdv comboBox1;
        private System.Windows.Forms.Label label5;
        private Syncfusion.Windows.Forms.Tools.GradientLabel gradientLabel4;
        private SplitContainerAdv splitContainerAdv1;
        private GradientLabel label6;
        private ColorPickerUIAdv colorPickerUIAdv1;
        private Syncfusion.Windows.Forms.PopupControlContainer popupControlContainer1;
        private System.Windows.Forms.Label label7;
        private ComboBoxAdv comboBoxAdv1;
        private GradientLabel gradientLabel5;
    }
}
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
using  System.ComponentModel.Design;
using Syncfusion.Windows.Forms.Tools;
using Syncfusion.Windows.Forms;
using Syncfusion.Licensing;
using System.IO;

namespace WizardControlTest
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : MetroForm
	{
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private Syncfusion.Windows.Forms.Tools.WizardControlPage wizardControlPage2;
		private Syncfusion.Windows.Forms.Tools.WizardControl wizardControl1;
		private Syncfusion.Windows.Forms.Tools.GradientPanel gradientPanel1;
		private Syncfusion.Windows.Forms.Tools.WizardContainer wizardContainer1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private Syncfusion.Windows.Forms.Tools.WizardControlPage wizardControlPage1;
		private System.Windows.Forms.PictureBox pictureBox3;
		private Syncfusion.Windows.Forms.Tools.WizardControlPage wizardControlPage3;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.ImageList imageList1;
		private Syncfusion.Windows.Forms.Tools.GradientPanel gradientPanel2;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.LinkLabel linkLabel1;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
        private TextBoxExt textBox1;
		private System.Windows.Forms.Label label11;
        private TextBoxExt textBox2;
		private System.Windows.Forms.Label label12;
		private NumericUpDownExt numericUpDown1;
		private System.Windows.Forms.Label label13;
		private TextBoxExt textBox3;
        private RadioButtonAdv radioButton1;
		private RadioButtonAdv radioButton2;
		private Syncfusion.Windows.Forms.Tools.WizardControlPage wizardControlPage4;
		private Syncfusion.Windows.Forms.Tools.WizardControlPage wizardControlPage5;
		private Syncfusion.Windows.Forms.Tools.ProgressBarAdv progressBarEx1;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Timer timer1;
		private Syncfusion.Windows.Forms.Tools.WizardControlPage wizardControlPage6;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.Label label18;
		private Syncfusion.Windows.Forms.Tools.DateTimePickerAdv dateTimePickerExt1;
		private System.Windows.Forms.Label label19;
		private TextBoxExt textBox4;
		private System.Windows.Forms.Label label20;
		private TextBoxExt textBox5;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.ComponentModel.IContainer components;
	
		public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
            this.MinimumSize = this.Size;
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.wizardControlPage2 = new Syncfusion.Windows.Forms.Tools.WizardControlPage(this.components);
            this.wizardControl1 = new Syncfusion.Windows.Forms.Tools.WizardControl();
            this.gradientPanel1 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.wizardContainer1 = new Syncfusion.Windows.Forms.Tools.WizardContainer();
            this.wizardControlPage1 = new Syncfusion.Windows.Forms.Tools.WizardControlPage(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.gradientPanel2 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.wizardControlPage3 = new Syncfusion.Windows.Forms.Tools.WizardControlPage(this.components);
            this.radioButton2 = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
            this.radioButton1 = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
            this.textBox3 = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.label13 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new Syncfusion.Windows.Forms.Tools.NumericUpDownExt();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox2 = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox1 = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.wizardControlPage4 = new Syncfusion.Windows.Forms.Tools.WizardControlPage(this.components);
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.progressBarEx1 = new Syncfusion.Windows.Forms.Tools.ProgressBarAdv();
            this.wizardControlPage6 = new Syncfusion.Windows.Forms.Tools.WizardControlPage(this.components);
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.wizardControlPage5 = new Syncfusion.Windows.Forms.Tools.WizardControlPage(this.components);
            this.textBox5 = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.label20 = new System.Windows.Forms.Label();
            this.textBox4 = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.label19 = new System.Windows.Forms.Label();
            this.dateTimePickerExt1 = new Syncfusion.Windows.Forms.Tools.DateTimePickerAdv();
            this.label18 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wizardControlPage2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wizardControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wizardControl1.GridBagLayout)).BeginInit();
            this.wizardControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel1)).BeginInit();
            this.gradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.wizardContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wizardControlPage1)).BeginInit();
            this.wizardControlPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel2)).BeginInit();
            this.gradientPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wizardControlPage3)).BeginInit();
            this.wizardControlPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radioButton2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wizardControlPage4)).BeginInit();
            this.wizardControlPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.progressBarEx1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wizardControlPage6)).BeginInit();
            this.wizardControlPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wizardControlPage5)).BeginInit();
            this.wizardControlPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTimePickerExt1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTimePickerExt1.Calendar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(736, 70);
            this.panel1.TabIndex = 12;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(665, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(61, 61);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(10, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Page Title";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(20, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(217, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "This is the description of the Wizard Page";
            // 
            // wizardControlPage2
            // 
            this.wizardControlPage2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.wizardControlPage2.Description = "This is the description of the Wizard Page";
            this.wizardControlPage2.FullPage = false;
            this.wizardControlPage2.LayoutName = "Card1";
            this.wizardControlPage2.Location = new System.Drawing.Point(0, 0);
            this.wizardControlPage2.Name = "wizardControlPage2";
            this.wizardControlPage2.NextPage = null;
            this.wizardControlPage2.PreviousPage = null;
            this.wizardControlPage2.Size = new System.Drawing.Size(584, 335);
            this.wizardControlPage2.TabIndex = 0;
            this.wizardControlPage2.Title = "Page Title";
            // 
            // wizardControl1
            // 
            // 
            // 
            // 
            this.wizardControl1.BackButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.wizardControl1.BackButton.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.wizardControl1.BackButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218)))));
            this.wizardControl1.BackButton.Enabled = false;
            this.wizardControl1.BackButton.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.wizardControl1.BackButton.Location = new System.Drawing.Point(392, 362);
            this.wizardControl1.BackButton.Name = "backButton";
            this.wizardControl1.BackButton.Text = "<< Back";
            this.wizardControl1.BackButton.UseVisualStyle = true;
            this.wizardControl1.BackButton.Visible = false;
            this.wizardControl1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.wizardControl1.Banner = null;
            this.wizardControl1.BannerPanel = this.gradientPanel1;
            this.wizardControl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            // 
            // 
            // 
            this.wizardControl1.CancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.wizardControl1.CancelButton.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.wizardControl1.CancelButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218)))));
            this.wizardControl1.CancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.wizardControl1.CancelButton.Location = new System.Drawing.Point(392, 362);
            this.wizardControl1.CancelButton.Name = "cancelButton";
            this.wizardControl1.CancelButton.Text = "Cancel";
            this.wizardControl1.CancelButton.UseVisualStyle = true;
            this.wizardControl1.CancelButton.Visible = false;
            this.wizardControl1.CancelButton.Click += new System.EventHandler(this.wizardControl1_CancelButton_Click);
            this.wizardControl1.Controls.Add(this.wizardContainer1);
            this.wizardControl1.Controls.Add(this.gradientPanel1);
            this.wizardControl1.Description = this.label4;
            this.wizardControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            // 
            // 
            // 
            this.wizardControl1.FinishButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.wizardControl1.FinishButton.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.wizardControl1.FinishButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218)))));
            this.wizardControl1.FinishButton.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.wizardControl1.FinishButton.Location = new System.Drawing.Point(470, 360);
            this.wizardControl1.FinishButton.Name = "finishButton";
            this.wizardControl1.FinishButton.Text = "Finish";
            this.wizardControl1.FinishButton.UseVisualStyle = true;
            // 
            // 
            // 
            this.wizardControl1.GridBagLayout.ContainerControl = this.wizardControl1;
            // 
            // 
            // 
            this.wizardControl1.HelpButton.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.wizardControl1.HelpButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218)))));
            this.wizardControl1.HelpButton.Enabled = false;
            this.wizardControl1.HelpButton.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.wizardControl1.HelpButton.Location = new System.Drawing.Point(472, 362);
            this.wizardControl1.HelpButton.Name = "helpButton";
            this.wizardControl1.HelpButton.Text = "Help";
            this.wizardControl1.HelpButton.UseVisualStyle = true;
            this.wizardControl1.HelpButton.Visible = false;
            this.wizardControl1.Location = new System.Drawing.Point(0, 0);
            this.wizardControl1.Name = "wizardControl1";
            // 
            // 
            // 
            this.wizardControl1.NextButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.wizardControl1.NextButton.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.wizardControl1.NextButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218)))));
            this.wizardControl1.NextButton.Enabled = false;
            this.wizardControl1.NextButton.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.wizardControl1.NextButton.Location = new System.Drawing.Point(392, 362);
            this.wizardControl1.NextButton.Name = "nextButton";
            this.wizardControl1.NextButton.Text = "Next >>";
            this.wizardControl1.NextButton.UseVisualStyle = true;
            this.wizardControl1.NextButton.Visible = false;
            this.wizardControl1.SelectedWizardPage = this.wizardControlPage1;
            this.wizardControl1.Size = new System.Drawing.Size(552, 390);
            this.wizardControl1.TabIndex = 0;
            this.wizardControl1.Title = this.label3;
            this.wizardControl1.WizardPageContainer = this.wizardContainer1;
            this.wizardControl1.WizardPages = new Syncfusion.Windows.Forms.Tools.WizardControlPage[] {
        this.wizardControlPage1,
        this.wizardControlPage3,
        this.wizardControlPage4,
        this.wizardControlPage5,
        this.wizardControlPage6};
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.ForwardDiagonal, System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(254)))), ((int)(((byte)(253))))), System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(240)))), ((int)(((byte)(220))))));
            this.gradientPanel1.Border3DStyle = System.Windows.Forms.Border3DStyle.Etched;
            this.gradientPanel1.BorderSides = System.Windows.Forms.Border3DSide.Bottom;
            this.gradientPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gradientPanel1.Controls.Add(this.label3);
            this.gradientPanel1.Controls.Add(this.label4);
            this.gradientPanel1.Controls.Add(this.pictureBox2);
            this.gradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(550, 70);
            this.gradientPanel1.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(66)))), ((int)(((byte)(125)))));
            this.label3.Location = new System.Drawing.Point(10, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(200, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "This is the title of the Wizard Page.";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(66)))), ((int)(((byte)(125)))));
            this.label4.Location = new System.Drawing.Point(20, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(210, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "This is the description of the Wizard Page.";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(480, 8);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(56, 48);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // wizardContainer1
            // 
            this.wizardContainer1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.wizardContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.wizardContainer1.Controls.Add(this.wizardControlPage1);
            this.wizardContainer1.Controls.Add(this.wizardControlPage3);
            this.wizardContainer1.Controls.Add(this.wizardControlPage4);
            this.wizardContainer1.Controls.Add(this.wizardControlPage5);
            this.wizardContainer1.Controls.Add(this.wizardControlPage6);
            this.wizardContainer1.Location = new System.Drawing.Point(0, 70);
            this.wizardContainer1.Name = "wizardContainer1";
            this.wizardContainer1.Size = new System.Drawing.Size(550, 277);
            this.wizardContainer1.TabIndex = 1;
            // 
            // wizardControlPage1
            // 
            this.wizardControlPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(237)))), ((int)(((byte)(246)))));
            this.wizardControlPage1.BackgroundColor = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(101)))), ((int)(((byte)(171))))));
            this.wizardControlPage1.BackVisible = false;
            this.wizardControlPage1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.wizardControlPage1.Controls.Add(this.label8);
            this.wizardControlPage1.Controls.Add(this.linkLabel1);
            this.wizardControlPage1.Controls.Add(this.label7);
            this.wizardControlPage1.Controls.Add(this.label6);
            this.wizardControlPage1.Controls.Add(this.gradientPanel2);
            this.wizardControlPage1.Controls.Add(this.label5);
            this.wizardControlPage1.Description = "This is the description of the Wizard Page";
            this.wizardControlPage1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wizardControlPage1.FullPage = true;
            this.wizardControlPage1.LayoutName = "Card1";
            this.wizardControlPage1.Location = new System.Drawing.Point(0, 0);
            this.wizardControlPage1.Name = "wizardControlPage1";
            this.wizardControlPage1.NextPage = null;
            this.wizardControlPage1.PreviousPage = null;
            this.wizardControlPage1.Size = new System.Drawing.Size(548, 275);
            this.wizardControlPage1.TabIndex = 0;
            this.wizardControlPage1.Title = "Page Title";
            this.wizardControlPage1.PageLoad += new System.EventHandler(this.wizardControlPage1_PageLoad);
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(200, 224);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(356, 16);
            this.label8.TabIndex = 6;
            this.label8.Text = "Wizard Control is available as part of Essential Tools.";
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.Blue;
            this.linkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel1.LinkColor = System.Drawing.Color.Red;
            this.linkLabel1.Location = new System.Drawing.Point(272, 248);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(200, 23);
            this.linkLabel1.TabIndex = 5;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "http://www.syncfusion.com";
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(208, 320);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(184, 23);
            this.label7.TabIndex = 4;
            this.label7.Text = "To continue, click Next";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(202, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(316, 56);
            this.label6.TabIndex = 3;
            this.label6.Text = "The Wizard control allows developers to make wizard applications quickly offering" +
    " easy control over pages and wizard buttons";
            // 
            // gradientPanel2
            // 
            this.gradientPanel2.BackColor = System.Drawing.Color.Transparent;
            this.gradientPanel2.Border3DStyle = System.Windows.Forms.Border3DStyle.RaisedOuter;
            this.gradientPanel2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gradientPanel2.Controls.Add(this.pictureBox3);
            this.gradientPanel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.gradientPanel2.Location = new System.Drawing.Point(0, 0);
            this.gradientPanel2.Name = "gradientPanel2";
            this.gradientPanel2.Size = new System.Drawing.Size(184, 275);
            this.gradientPanel2.TabIndex = 2;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(0, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(184, 275);
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.LightSalmon;
            this.label5.Location = new System.Drawing.Point(200, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(348, 64);
            this.label5.TabIndex = 1;
            this.label5.Text = "Welcome to the Wizard demo application";           
            // 
            // wizardControlPage3
            // 
            this.wizardControlPage3.BackColor = System.Drawing.Color.Transparent;
            this.wizardControlPage3.BackEnabled = false;
            this.wizardControlPage3.BackgroundColor = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(101)))), ((int)(((byte)(171))))));
            this.wizardControlPage3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.wizardControlPage3.Controls.Add(this.radioButton2);
            this.wizardControlPage3.Controls.Add(this.radioButton1);
            this.wizardControlPage3.Controls.Add(this.textBox3);
            this.wizardControlPage3.Controls.Add(this.label13);
            this.wizardControlPage3.Controls.Add(this.numericUpDown1);
            this.wizardControlPage3.Controls.Add(this.label12);
            this.wizardControlPage3.Controls.Add(this.textBox2);
            this.wizardControlPage3.Controls.Add(this.label11);
            this.wizardControlPage3.Controls.Add(this.textBox1);
            this.wizardControlPage3.Controls.Add(this.label10);
            this.wizardControlPage3.Controls.Add(this.label9);
            this.wizardControlPage3.Description = "This page shows the easy way of collecting informations from the user.";
            this.wizardControlPage3.FullPage = false;
            this.wizardControlPage3.LayoutName = "Card2";
            this.wizardControlPage3.Location = new System.Drawing.Point(0, 0);
            this.wizardControlPage3.Name = "wizardControlPage3";
            this.wizardControlPage3.NextPage = this.wizardControlPage4;
            this.wizardControlPage3.PreviousPage = null;
            this.wizardControlPage3.Size = new System.Drawing.Size(548, 275);
            this.wizardControlPage3.TabIndex = 1;
            this.wizardControlPage3.Title = "Page 1";
            this.wizardControlPage3.NextClick += new System.EventHandler(this.wizardControlPage3_NextClick);
            // 
            // radioButton2
            // 
            this.radioButton2.BackColor = System.Drawing.Color.Transparent;
            this.radioButton2.DrawFocusRectangle = false;
            this.radioButton2.ForeColor = System.Drawing.Color.White;
            this.radioButton2.Location = new System.Drawing.Point(104, 248);
            this.radioButton2.MetroColor = System.Drawing.Color.Gray;
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(184, 24);
            this.radioButton2.Style = Syncfusion.Windows.Forms.Tools.RadioButtonAdvStyle.Metro;
            this.radioButton2.TabIndex = 10;
            this.radioButton2.TabStop = false;
            this.radioButton2.Text = "Choose second execution path";
            this.radioButton2.ThemesEnabled = false;
            // 
            // radioButton1
            // 
            this.radioButton1.BackColor = System.Drawing.Color.Transparent;
            this.radioButton1.Checked = true;
            this.radioButton1.DrawFocusRectangle = false;
            this.radioButton1.ForeColor = System.Drawing.Color.White;
            this.radioButton1.Location = new System.Drawing.Point(104, 224);
            this.radioButton1.MetroColor = System.Drawing.Color.Gray;
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(184, 24);
            this.radioButton1.Style = Syncfusion.Windows.Forms.Tools.RadioButtonAdvStyle.Metro;
            this.radioButton1.TabIndex = 9;
            this.radioButton1.Text = "Choose the first execution path";
            this.radioButton1.ThemesEnabled = false;
            // 
            // textBox3
            // 
            this.textBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox3.BorderColor = System.Drawing.Color.Gray;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox3.Location = new System.Drawing.Point(104, 136);
            this.textBox3.Metrocolor = System.Drawing.Color.Gray;
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox3.Size = new System.Drawing.Size(372, 80);
            this.textBox3.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Metro;
            this.textBox3.TabIndex = 8;
            this.textBox3.Text = "Enter biographical data.";
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(24, 136);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(64, 23);
            this.label13.TabIndex = 7;
            this.label13.Text = "Biography:";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDown1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218)))));
            this.numericUpDown1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDown1.Location = new System.Drawing.Point(104, 104);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.numericUpDown1.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218)))));
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(44, 22);
            this.numericUpDown1.TabIndex = 6;
            this.numericUpDown1.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDown1.VisualStyle = Syncfusion.Windows.Forms.VisualStyle.Metro;
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(24, 104);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(32, 23);
            this.label12.TabIndex = 5;
            this.label12.Text = "Age:";
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.BorderColor = System.Drawing.Color.Gray;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Location = new System.Drawing.Point(104, 72);
            this.textBox2.Metrocolor = System.Drawing.Color.Gray;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(64, 22);
            this.textBox2.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Metro;
            this.textBox2.TabIndex = 4;
            this.textBox2.Text = "Doe";
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(24, 72);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 23);
            this.label11.TabIndex = 3;
            this.label11.Text = "Last Name :";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.BorderColor = System.Drawing.Color.Gray;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Location = new System.Drawing.Point(104, 40);
            this.textBox1.Metrocolor = System.Drawing.Color.Gray;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(64, 22);
            this.textBox1.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Metro;
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "John";
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(24, 40);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 23);
            this.label10.TabIndex = 1;
            this.label10.Text = "First Name:";
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(24, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(184, 23);
            this.label9.TabIndex = 0;
            this.label9.Text = "Please fill out the fields below:";
            // 
            // wizardControlPage4
            // 
            this.wizardControlPage4.BackEnabled = false;
            this.wizardControlPage4.BackgroundColor = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(101)))), ((int)(((byte)(171))))));
            this.wizardControlPage4.BackVisible = false;
            this.wizardControlPage4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.wizardControlPage4.Controls.Add(this.label15);
            this.wizardControlPage4.Controls.Add(this.label14);
            this.wizardControlPage4.Controls.Add(this.progressBarEx1);
            this.wizardControlPage4.Description = "This is the first execution path";
            this.wizardControlPage4.FullPage = false;
            this.wizardControlPage4.HelpEnabled = false;
            this.wizardControlPage4.HelpVisible = false;
            this.wizardControlPage4.LayoutName = "Card3";
            this.wizardControlPage4.Location = new System.Drawing.Point(0, 0);
            this.wizardControlPage4.Name = "wizardControlPage4";
            this.wizardControlPage4.NextPage = this.wizardControlPage6;
            this.wizardControlPage4.PreviousPage = this.wizardControlPage3;
            this.wizardControlPage4.Size = new System.Drawing.Size(548, 275);
            this.wizardControlPage4.TabIndex = 2;
            this.wizardControlPage4.Title = "First Execution path";
            this.wizardControlPage4.BackClick += new System.EventHandler(this.wizardControlPage4_BackClick);
            this.wizardControlPage4.PageLoad += new System.EventHandler(this.wizardControlPage4_PageLoad);
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(72, 256);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(348, 16);
            this.label15.TabIndex = 2;
            this.label15.Text = "The next button will get enabled after the progressbar reaches 100%";
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(80, 104);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(184, 16);
            this.label14.TabIndex = 1;
            this.label14.Text = "Processing information";
            // 
            // progressBarEx1
            // 
            this.progressBarEx1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBarEx1.BackGradientEndColor = System.Drawing.Color.White;
            this.progressBarEx1.BackGradientStartColor = System.Drawing.Color.LightGray;
            this.progressBarEx1.BackgroundStyle = Syncfusion.Windows.Forms.Tools.ProgressBarBackgroundStyles.Tube;
            this.progressBarEx1.BackMultipleColors = new System.Drawing.Color[0];
            this.progressBarEx1.BackSegments = false;
            this.progressBarEx1.BackTubeEndColor = System.Drawing.Color.White;
            this.progressBarEx1.BackTubeStartColor = System.Drawing.Color.LightGray;
            this.progressBarEx1.Border3DStyle = System.Windows.Forms.Border3DStyle.Etched;
            this.progressBarEx1.BorderColor = System.Drawing.Color.Black;
            this.progressBarEx1.CustomText = null;
            this.progressBarEx1.CustomWaitingRender = false;
            this.progressBarEx1.FontColor = System.Drawing.Color.White;
            this.progressBarEx1.ForegroundImage = null;
            this.progressBarEx1.GradientEndColor = System.Drawing.Color.Linen;
            this.progressBarEx1.GradientStartColor = System.Drawing.SystemColors.ControlLightLight;
            this.progressBarEx1.Location = new System.Drawing.Point(80, 120);
            this.progressBarEx1.MultipleColors = new System.Drawing.Color[0];
            this.progressBarEx1.Name = "progressBarEx1";
            this.progressBarEx1.ProgressStyle = Syncfusion.Windows.Forms.Tools.ProgressBarStyles.System;
            this.progressBarEx1.SegmentWidth = 12;
            this.progressBarEx1.Size = new System.Drawing.Size(364, 23);
            this.progressBarEx1.TabIndex = 0;
            this.progressBarEx1.Text = "progressBarEx1";
            this.progressBarEx1.ThemesEnabled = true;
            this.progressBarEx1.TubeEndColor = System.Drawing.Color.Transparent;
            this.progressBarEx1.TubeStartColor = System.Drawing.Color.Lime;
            this.progressBarEx1.WaitingGradientWidth = 400;
            // 
            // wizardControlPage6
            // 
            this.wizardControlPage6.BackEnabled = false;
            this.wizardControlPage6.BackgroundColor = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(101)))), ((int)(((byte)(171))))));
            this.wizardControlPage6.BackVisible = false;
            this.wizardControlPage6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.wizardControlPage6.CancelOverFinish = false;
            this.wizardControlPage6.CancelVisible = false;
            this.wizardControlPage6.Controls.Add(this.label17);
            this.wizardControlPage6.Controls.Add(this.label16);
            this.wizardControlPage6.Description = "This is the Wizard\'s final page";
            this.wizardControlPage6.FullPage = false;
            this.wizardControlPage6.HelpEnabled = false;
            this.wizardControlPage6.HelpVisible = false;
            this.wizardControlPage6.LayoutName = "Card5";
            this.wizardControlPage6.Location = new System.Drawing.Point(0, 0);
            this.wizardControlPage6.Name = "wizardControlPage6";
            this.wizardControlPage6.NextEnabled = false;
            this.wizardControlPage6.NextPage = null;
            this.wizardControlPage6.NextVisible = false;
            this.wizardControlPage6.PreviousPage = this.wizardControlPage4;
            this.wizardControlPage6.Size = new System.Drawing.Size(548, 275);
            this.wizardControlPage6.TabIndex = 4;
            this.wizardControlPage6.Title = "Finish Page";
            this.wizardControlPage6.FinishClick += new System.EventHandler(this.wizardControlPage6_FinishClick);
            // 
            // label17
            // 
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(64, 256);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(168, 18);
            this.label17.TabIndex = 1;
            this.label17.Text = "Click finish to close the wizard.";
            // 
            // label16
            // 
            this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(56, 64);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(428, 48);
            this.label16.TabIndex = 0;
            this.label16.Text = "Congratulations, you have sucessfully run our test wizard.";
            // 
            // wizardControlPage5
            // 
            this.wizardControlPage5.BackgroundColor = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(101)))), ((int)(((byte)(171))))));
            this.wizardControlPage5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.wizardControlPage5.CancelEnabled = false;
            this.wizardControlPage5.CancelVisible = false;
            this.wizardControlPage5.Controls.Add(this.textBox5);
            this.wizardControlPage5.Controls.Add(this.label20);
            this.wizardControlPage5.Controls.Add(this.textBox4);
            this.wizardControlPage5.Controls.Add(this.label19);
            this.wizardControlPage5.Controls.Add(this.dateTimePickerExt1);
            this.wizardControlPage5.Controls.Add(this.label18);
            this.wizardControlPage5.Description = "This is the second execution path";
            this.wizardControlPage5.FullPage = false;
            this.wizardControlPage5.LayoutName = "Card4";
            this.wizardControlPage5.Location = new System.Drawing.Point(0, 0);
            this.wizardControlPage5.Name = "wizardControlPage5";
            this.wizardControlPage5.NextPage = null;
            this.wizardControlPage5.PreviousPage = null;
            this.wizardControlPage5.Size = new System.Drawing.Size(548, 275);
            this.wizardControlPage5.TabIndex = 3;
            this.wizardControlPage5.Title = "Second Execution path";
            // 
            // textBox5
            // 
            this.textBox5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox5.BorderColor = System.Drawing.Color.Gray;
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox5.Location = new System.Drawing.Point(104, 88);
            this.textBox5.Metrocolor = System.Drawing.Color.Gray;
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox5.Size = new System.Drawing.Size(204, 160);
            this.textBox5.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Metro;
            this.textBox5.TabIndex = 5;
            // 
            // label20
            // 
            this.label20.BackColor = System.Drawing.Color.Transparent;
            this.label20.ForeColor = System.Drawing.Color.White;
            this.label20.Location = new System.Drawing.Point(8, 88);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(100, 23);
            this.label20.TabIndex = 4;
            this.label20.Text = "Studies and merits";
            // 
            // textBox4
            // 
            this.textBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox4.BorderColor = System.Drawing.Color.Gray;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox4.Location = new System.Drawing.Point(104, 56);
            this.textBox4.Metrocolor = System.Drawing.Color.Gray;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(204, 22);
            this.textBox4.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Metro;
            this.textBox4.TabIndex = 3;
            this.textBox4.Text = "New York";
            // 
            // label19
            // 
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.ForeColor = System.Drawing.Color.White;
            this.label19.Location = new System.Drawing.Point(48, 56);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(48, 16);
            this.label19.TabIndex = 2;
            this.label19.Text = "Location";
            // 
            // dateTimePickerExt1
            // 
            this.dateTimePickerExt1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerExt1.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.White, System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255))))));
            this.dateTimePickerExt1.Border3DStyle = System.Windows.Forms.Border3DStyle.Etched;
            this.dateTimePickerExt1.BorderColor = System.Drawing.Color.Empty;
            // 
            // 
            // 
            this.dateTimePickerExt1.Calendar.AllowMultipleSelection = false;
            this.dateTimePickerExt1.Calendar.BottomHeight = 18;
            this.dateTimePickerExt1.Calendar.Culture = new System.Globalization.CultureInfo("en-US");
            this.dateTimePickerExt1.Calendar.DaysFont = new System.Drawing.Font("Verdana", 8F);
            this.dateTimePickerExt1.Calendar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateTimePickerExt1.Calendar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerExt1.Calendar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.dateTimePickerExt1.Calendar.HeaderFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerExt1.Calendar.HeaderStartColor = System.Drawing.Color.WhiteSmoke;
            this.dateTimePickerExt1.Calendar.InactiveMonthColor = System.Drawing.Color.LightBlue;
            this.dateTimePickerExt1.Calendar.Location = new System.Drawing.Point(0, 0);
            this.dateTimePickerExt1.Calendar.MaxValue = new System.DateTime(9999, 12, 31, 23, 59, 59, 999);
            this.dateTimePickerExt1.Calendar.MinValue = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerExt1.Calendar.Name = "monthCalendar";
            this.dateTimePickerExt1.Calendar.SelectedDates = new System.DateTime[0];
            this.dateTimePickerExt1.Calendar.Size = new System.Drawing.Size(185, 174);
            this.dateTimePickerExt1.Calendar.SizeToFit = true;
            this.dateTimePickerExt1.Calendar.TabIndex = 0;
            this.dateTimePickerExt1.Calendar.WeekFont = new System.Drawing.Font("Verdana", 8F);
            this.dateTimePickerExt1.Calendar.WeekInterior = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.PeachPuff, System.Drawing.Color.AntiqueWhite);
            // 
            // 
            // 
            this.dateTimePickerExt1.Calendar.NoneButton.Location = new System.Drawing.Point(113, 0);
            this.dateTimePickerExt1.Calendar.NoneButton.Size = new System.Drawing.Size(72, 18);
            this.dateTimePickerExt1.Calendar.NoneButton.Text = "None";
            // 
            // 
            // 
            this.dateTimePickerExt1.Calendar.TodayButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerExt1.Calendar.TodayButton.Dock = System.Windows.Forms.DockStyle.None;
            this.dateTimePickerExt1.Calendar.TodayButton.Location = new System.Drawing.Point(0, 0);
            this.dateTimePickerExt1.Calendar.TodayButton.Size = new System.Drawing.Size(10, 18);
            this.dateTimePickerExt1.Calendar.TodayButton.Text = "Today";
            this.dateTimePickerExt1.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerExt1.CalendarSize = new System.Drawing.Size(189, 176);
            this.dateTimePickerExt1.CalendarTitleBackColor = System.Drawing.Color.WhiteSmoke;
            this.dateTimePickerExt1.CalendarTrailingForeColor = System.Drawing.Color.LightBlue;
            this.dateTimePickerExt1.Culture = new System.Globalization.CultureInfo("en-US");
            this.dateTimePickerExt1.DropDownImage = null;
            this.dateTimePickerExt1.FlatDropButton = true;
            this.dateTimePickerExt1.Location = new System.Drawing.Point(104, 28);
            this.dateTimePickerExt1.MaxValue = new System.DateTime(9999, 12, 31, 23, 59, 59, 999);
            this.dateTimePickerExt1.MinValue = new System.DateTime(((long)(0)));
            this.dateTimePickerExt1.Name = "dateTimePickerExt1";
            this.dateTimePickerExt1.ShowCheckBox = false;
            this.dateTimePickerExt1.Size = new System.Drawing.Size(204, 20);
            this.dateTimePickerExt1.TabIndex = 1;
            this.dateTimePickerExt1.Value = new System.DateTime(2003, 11, 17, 15, 48, 16, 633);
            // 
            // label18
            // 
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.ForeColor = System.Drawing.Color.White;
            this.label18.Location = new System.Drawing.Point(48, 32);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(56, 16);
            this.label18.TabIndex = 0;
            this.label18.Text = "Birth date";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.White;
            this.imageList1.Images.SetKeyName(0, "");
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 15);
            this.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.CaptionAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ClientSize = new System.Drawing.Size(552, 390);
            this.Controls.Add(this.wizardControl1);
            this.DropShadow = true;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IconAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.IconTextRelation = System.Windows.Forms.LeftRightAlignment.Left;
            this.MetroColor = System.Drawing.Color.White;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Wizard Control";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wizardControlPage2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wizardControl1.GridBagLayout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wizardControl1)).EndInit();
            this.wizardControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel1)).EndInit();
            this.gradientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.wizardContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.wizardControlPage1)).EndInit();
            this.wizardControlPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel2)).EndInit();
            this.gradientPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();           
            ((System.ComponentModel.ISupportInitialize)(this.wizardControlPage3)).EndInit();
            this.wizardControlPage3.ResumeLayout(false);
            this.wizardControlPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radioButton2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wizardControlPage4)).EndInit();
            this.wizardControlPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.progressBarEx1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wizardControlPage6)).EndInit();
            this.wizardControlPage6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.wizardControlPage5)).EndInit();
            this.wizardControlPage5.ResumeLayout(false);
            this.wizardControlPage5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTimePickerExt1.Calendar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTimePickerExt1)).EndInit();
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
			// To provide offset between the navigation controls
			this.wizardControl1.GridBagLayout.GetConstraintsRef(this.wizardControl1.BackButton).Insets = new Insets(0,0,5,0);
			this.wizardControl1.GridBagLayout.GetConstraintsRef(this.wizardControl1.CancelButton).Insets = new Insets(5,0,5,0);
			this.wizardControl1.GridBagLayout.GetConstraintsRef(this.wizardControl1.FinishButton).Insets = new Insets(0,5,0,5);

            foreach (Control ctrl in this.wizardControl1.Controls)
            {
                if (ctrl is ButtonAdv)
                {
                    ButtonAdv btn = (ButtonAdv)ctrl;
                    btn.FlatStyle = FlatStyle.Standard;
                    btn.UseVisualStyle = true;
                    btn.Appearance = ButtonAppearance.Metro;
                    btn.KeepFocusRectangle = false;
                }
            }
		}
			
		private void wizardControlPage1_PageLoad(object sender, System.EventArgs e)
		{
			this.wizardControl1.NextButton.TabIndex = 0;
		}

		private void wizardControlPage4_BackClick(object sender, System.EventArgs e)
		{
			this.timer1.Stop();
		}

		private void wizardControlPage3_NextClick(object sender, System.EventArgs e)
		{
			string text = " First ";
			if(this.radioButton2.Checked) text = " Second ";

			MessageBoxAdv.Show(this,"Hello "+this.textBox1.Text+" "+this.textBox2.Text+"! You have chosen the"+text+"execution path","Information",MessageBoxButtons.OK, MessageBoxIcon.Information);
			if(this.radioButton2.Checked)
			{
				this.wizardControlPage3.NextPage = wizardControlPage5;
				this.wizardControlPage6.PreviousPage = wizardControlPage5;
			}
			else 
			{
				wizardControlPage3.NextPage = wizardControlPage4;
				this.wizardControlPage6.PreviousPage = wizardControlPage4;
			}
		}

		private void wizardControl1_CancelButton_Click(object sender, System.EventArgs e)
		{
			this.progressBarEx1.Value = this.progressBarEx1.Value;
			this.timer1.Stop();
			if(MessageBoxAdv.Show(this, "Are you sure you want to cancel the wizard?","Confirm",MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
				Close();
			else
				this.timer1.Start();
		}

		private void wizardControlPage4_PageLoad(object sender, System.EventArgs e)
		{
			this.wizardControlPage4.NextEnabled = false;
			this.progressBarEx1.Value = 0;
			this.timer1.Enabled = true;
		}

		private void timer1_Tick(object sender, System.EventArgs e)
		{
			progressBarEx1.Value +=1;
			if(progressBarEx1.Value == 100)
			{
				this.wizardControlPage4.NextEnabled = true;
				this.wizardControl1.NextButton.Focus();
				this.timer1.Enabled = false;

				// You could automatically move to the next page by handling the fake click of Next buttton
				//this.wizardControl1.NextButton.PerformClick();
			}
		}


		private void wizardControlPage6_FinishClick(object sender, System.EventArgs e)
		{
			Close();
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

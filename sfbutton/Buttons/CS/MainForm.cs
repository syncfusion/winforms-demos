#region Copyright Syncfusion Inc. 2001 - 2017
//
//  Copyright Syncfusion Inc. 2001 - 2017. All rights reserved.
//
//  Use of this code is subject to the terms of our license.
//  A copy of the current license can be obtained at any time by e-mailing
//  licensing@syncfusion.com. Any infringement will be prosecuted under
//  applicable laws. 
//
#endregion

namespace ButtonEditDemo
{
    using System;
    using System.Drawing;
    using System.Collections;
    using System.ComponentModel;
    using System.Windows.Forms;
    using System.Data;
    using Syncfusion.Windows.Forms.Tools;
    using Syncfusion.Windows.Forms;
    using System.Drawing.Drawing2D;
    using DemoCommon.Grid;
    using Syncfusion.Licensing;
    using System.IO;

    /// <summary>
    /// Summary description for MainForm.
    /// </summary>
    public class MainForm : MetroForm
    {
		private System.Windows.Forms.ErrorProvider errorProvider1;

		private Hashtable hashLabelNames;
        public Color startcolor = Color.LightGreen;
        public Color endcolor = Color.Green;
		private Syncfusion.Windows.Forms.Tools.TabControlAdv tabControl1;
		private System.Windows.Forms.ImageList imageList1;
        private GradientPanel gradientPanel1;
        private ImageList imageList2;
        private ComboBoxAdv comboBoxAdv1;
        private TabPageAdv tabPageAdv1;
        private TextBoxExt textBoxExt2;
        private Panel panel1;
        private GroupBox groupBox8;
        private SplitButton splitButton8;
        private SplitButton splitButton7;
        private SplitButton splitButton6;
        private SplitButton splitButton5;
        private SplitButton splitButton4;
        private SplitButton splitButton3;
        private GradientPanel gradientPanel18;
        private GradientPanel gradientPanel20;
        private Label label9;
        private RadioButtonAdv radioButtonAdv17;
        private RadioButtonAdv radioButtonAdv6;
        private RadioButtonAdv radioButtonAdv4;
        private RadioButtonAdv radioButtonAdv3;
        private GradientPanel panel3;
        private Label label2;
        private RadioButtonAdv radioButton2;
        private RadioButtonAdv radioButton1;
        private GradientPanel panel4;
        private Label label3;
        private ButtonAdv buttonAdv3;
        private GradientPanel gradientPanel19;
        private SplitButton splitButton1;
        private GradientPanel panel6;
        private SplitButton splitButton2;
        private Label label6;
        private Label label1;
        private Label label4;
        private System.ComponentModel.IContainer components;

		public MainForm()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
#if NETCORE
            this.Icon = new System.Drawing.Icon(@"..\\..\\..\\\sficon.ico");
#else
            this.Icon = new System.Drawing.Icon(@"..\\..\\\sficon.ico");
#endif
            this.Resize += new EventHandler(MainForm_Resize);
            CustomRenderer renderer = new CustomRenderer();
            renderer.SplitButton = splitButton2;
            splitButton2.Renderer = renderer;
#if NETCORE
            Image img1 = Image.FromFile(@"../../../Search.png");
            Image img = Image.FromFile(@"../../../logo_16.ico");
            Image img2 = Image.FromFile(@"../../../logo_16.ico");
            Image img3 = Image.FromFile(@"../../../logo_16.ico");
            Image img7 = Image.FromFile(@"../../../logo_16.ico");
            Image img8 = Image.FromFile(@"../../../logo_16.ico");
            Image img6 = Image.FromFile(@"../../../logo_16.ico");
            Image img5 = Image.FromFile(@"../../../logo_16.ico");
            Image img4 = Image.FromFile(@"../../../logo_16.ico");


#else
            Image img1 = Image.FromFile(@"../../Search.png");
            Image img = Image.FromFile(@"../../logo_16.ico");
            Image img2 = Image.FromFile(@"../../logo_16.ico");
            Image img3 = Image.FromFile(@"../../logo_16.ico");
            Image img7 = Image.FromFile(@"../../logo_16.ico");
            Image img8 = Image.FromFile(@"../../logo_16.ico");
            Image img6 = Image.FromFile(@"../../logo_16.ico");
            Image img5 = Image.FromFile(@"../../logo_16.ico");
            Image img4 = Image.FromFile(@"../../logo_16.ico");


#endif
            this.splitButton1.DropDownItems.Add(new toolstripitem());
            this.splitButton1.DropDownItems.Add(new toolstripitem());
            this.splitButton1.DropDownItems.Add(new toolstripitem());
            this.splitButton1.DropDownItems[0].Text = "Find";
            this.splitButton1.DropDownItems[0].Image = img1;
            this.splitButton1.DropDownItems[1].Text = "Advanced Find";
            this.splitButton1.DropDownItems[1].Image = img1;
            this.splitButton1.DropDownItems[2].Text = "Go To";
            this.splitButton1.DropDownItems[2].Image = img1;
            this.splitButton2.DropDownItems.Add(new toolstripitem());
            this.splitButton2.DropDownItems.Add(new toolstripitem());
            this.splitButton2.DropDownItems.Add(new toolstripitem());
            this.splitButton2.DropDownItems[0].Image = img1;
            this.splitButton2.DropDownItems[0].Text = "Find";
            this.splitButton2.DropDownItems[1].Image = img1;
            this.splitButton2.DropDownItems[1].Text = "Advanced Find";
            this.splitButton2.DropDownItems[2].Image = img1;
            this.splitButton2.DropDownItems[2].Text = "Go To";
            this.splitButton3.DropDownItems.Add(new toolstripitem());
            this.splitButton3.DropDownItems.Add(new toolstripitem());
            this.splitButton3.DropDownItems.Add(new toolstripitem());
            this.splitButton3.DropDownItems[0].Image = img2;
            this.splitButton3.DropDownItems[0].Text = "Metro";
            this.splitButton3.DropDownItems[1].Image = img2;
            this.splitButton3.DropDownItems[1].Text = "Office2016ColorFul";
            this.splitButton3.DropDownItems[2].Image = img2;
            this.splitButton3.DropDownItems[2].Text = "Office2016White";
            this.splitButton4.DropDownItems.Add(new toolstripitem());
            this.splitButton4.DropDownItems.Add(new toolstripitem());
            this.splitButton4.DropDownItems.Add(new toolstripitem());
            this.splitButton4.DropDownItems[0].Image = img3;
            this.splitButton4.DropDownItems[0].Text = "Office2016Black";
            this.splitButton4.DropDownItems[1].Image = img3;
            this.splitButton4.DropDownItems[1].Text = "Office2016DarkGray";
            this.splitButton4.DropDownItems[2].Image = img3;
            this.splitButton4.DropDownItems[2].Text = "Office2016ColorFul";
            this.splitButton5.DropDownItems.Add(new toolstripitem());
            this.splitButton5.DropDownItems.Add(new toolstripitem());
            this.splitButton5.DropDownItems.Add(new toolstripitem());
            this.splitButton5.DropDownItems[0].Image = img3;
            this.splitButton5.DropDownItems[0].Text = "Office2016Black";
            this.splitButton5.DropDownItems[1].Image = img3;
            this.splitButton5.DropDownItems[1].Text = "Office2016DarkGray";
            this.splitButton5.DropDownItems[2].Image = img3;
            this.splitButton5.DropDownItems[2].Text = "Metro";
            this.splitButton6.DropDownItems.Add(new toolstripitem());
            this.splitButton6.DropDownItems.Add(new toolstripitem());
            this.splitButton6.DropDownItems.Add(new toolstripitem());
            this.splitButton6.DropDownItems[0].Image = img3;
            this.splitButton6.DropDownItems[0].Text = "Office2016Black";
            this.splitButton6.DropDownItems[1].Image = img3;
            this.splitButton6.DropDownItems[1].Text = "Office2016DarkGray";
            this.splitButton6.DropDownItems[2].Image = img3;
            this.splitButton6.DropDownItems[2].Text = "Office2016ColorFul";
            this.splitButton7.DropDownItems.Add(new toolstripitem());
            this.splitButton7.DropDownItems.Add(new toolstripitem());
            this.splitButton7.DropDownItems.Add(new toolstripitem());
            this.splitButton7.DropDownItems[0].Image = img3;
            this.splitButton7.DropDownItems[0].Text = "Metro";
            this.splitButton7.DropDownItems[1].Image = img3;
            this.splitButton7.DropDownItems[1].Text = "Office2016DarkGray";
            this.splitButton7.DropDownItems[2].Image = img3;
            this.splitButton7.DropDownItems[2].Text = "Office2016ColorFul";
            this.splitButton8.DropDownItems.Add(new toolstripitem());
            this.splitButton8.DropDownItems.Add(new toolstripitem());
            this.splitButton8.DropDownItems.Add(new toolstripitem());
            this.splitButton8.DropDownItems[0].Image = img3;
            this.splitButton8.DropDownItems[0].Text = "Metro";
            this.splitButton8.DropDownItems[1].Image = img3;
            this.splitButton8.DropDownItems[1].Text = "Office2016Black";
            this.splitButton8.DropDownItems[2].Image = img3;
            this.splitButton8.DropDownItems[2].Text = "Office2016ColorFul";
            //
            // TODO: Add any constructor code after InitializeComponent call
            //
            hashLabelNames = new Hashtable();
		}

        void MainForm_Resize(object sender, EventArgs e)
        {
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
            Syncfusion.Windows.Forms.Tools.MetroSplitButtonRenderer metroSplitButtonRenderer1 = new Syncfusion.Windows.Forms.Tools.MetroSplitButtonRenderer();
            Syncfusion.Windows.Forms.Tools.SplitButtonRenderer splitButtonRenderer1 = new Syncfusion.Windows.Forms.Tools.SplitButtonRenderer();
            Syncfusion.Windows.Forms.Tools.MetroSplitButtonRenderer metroSplitButtonRenderer2 = new Syncfusion.Windows.Forms.Tools.MetroSplitButtonRenderer();
            Syncfusion.Windows.Forms.Tools.MetroSplitButtonRenderer metroSplitButtonRenderer3 = new Syncfusion.Windows.Forms.Tools.MetroSplitButtonRenderer();
            Syncfusion.Windows.Forms.Tools.Office2016DarkGraySplitButtonRenderer office2016DarkGraySplitButtonRenderer1 = new Syncfusion.Windows.Forms.Tools.Office2016DarkGraySplitButtonRenderer();
            Syncfusion.Windows.Forms.Tools.Office2016BlackSplitButtonRenderer office2016BlackSplitButtonRenderer1 = new Syncfusion.Windows.Forms.Tools.Office2016BlackSplitButtonRenderer();
            Syncfusion.Windows.Forms.Tools.Office2016WhiteSplitButtonRenderer office2016WhiteSplitButtonRenderer1 = new Syncfusion.Windows.Forms.Tools.Office2016WhiteSplitButtonRenderer();
            Syncfusion.Windows.Forms.Tools.Office2016ColorfulSplitButtonRenderer office2016ColorfulSplitButtonRenderer1 = new Syncfusion.Windows.Forms.Tools.Office2016ColorfulSplitButtonRenderer();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.splitButton4 = new Syncfusion.Windows.Forms.Tools.SplitButton();
            this.splitButton3 = new Syncfusion.Windows.Forms.Tools.SplitButton();
            this.splitButton1 = new Syncfusion.Windows.Forms.Tools.SplitButton();
            this.splitButton2 = new Syncfusion.Windows.Forms.Tools.SplitButton();
            this.splitButton8 = new Syncfusion.Windows.Forms.Tools.SplitButton();
            this.splitButton7 = new Syncfusion.Windows.Forms.Tools.SplitButton();
            this.splitButton6 = new Syncfusion.Windows.Forms.Tools.SplitButton();
            this.splitButton5 = new Syncfusion.Windows.Forms.Tools.SplitButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.gradientPanel1 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            this.tabControl1 = new Syncfusion.Windows.Forms.Tools.TabControlAdv();
            this.tabPageAdv1 = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gradientPanel18 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            this.gradientPanel20 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            this.label9 = new System.Windows.Forms.Label();
            this.radioButtonAdv17 = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
            this.radioButtonAdv6 = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
            this.radioButtonAdv4 = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
            this.radioButtonAdv3 = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
            this.panel3 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.radioButton2 = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
            this.radioButton1 = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
            this.panel4 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonAdv3 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.gradientPanel19 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            this.panel6 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.textBoxExt2 = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.comboBoxAdv1 = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabControl1)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel18)).BeginInit();
            this.gradientPanel18.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel20)).BeginInit();
            this.gradientPanel20.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radioButtonAdv17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioButtonAdv6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioButtonAdv4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioButtonAdv3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel3)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radioButton2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel4)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel19)).BeginInit();
            this.gradientPanel19.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panel6)).BeginInit();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxExt2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxAdv1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitButton4
            // 
            this.splitButton4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitButton4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.splitButton4.BeforeTouchSize = new System.Drawing.Size(304, 43);
            this.splitButton4.DropDownIconColor = System.Drawing.Color.White;
            this.splitButton4.DropDownPosition = Syncfusion.Windows.Forms.Tools.Position.Bottom;
            this.splitButton4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.splitButton4.ForeColor = System.Drawing.Color.White;
            this.splitButton4.Location = new System.Drawing.Point(376, 42);
            this.splitButton4.MinimumSize = new System.Drawing.Size(75, 23);
            this.splitButton4.Name = "splitButton4";
            this.splitButton4.Renderer = metroSplitButtonRenderer1;
            this.splitButton4.ShowDropDownOnButtonClick = false;
            this.splitButton4.Size = new System.Drawing.Size(304, 43);
            this.splitButton4.Style = Syncfusion.Windows.Forms.Tools.SplitButtonVisualStyle.Metro;
            this.splitButton4.TabIndex = 1;
            this.splitButton4.Text = "Metro";
            this.splitButton4.ThemeName = "Metro";
            // 
            // splitButton3
            // 
            this.splitButton3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitButton3.BackColor = System.Drawing.SystemColors.Control;
            this.splitButton3.BeforeTouchSize = new System.Drawing.Size(304, 43);
            this.splitButton3.DropDownPosition = Syncfusion.Windows.Forms.Tools.Position.Bottom;
            this.splitButton3.ForeColor = System.Drawing.Color.Black;
            this.splitButton3.Location = new System.Drawing.Point(43, 42);
            this.splitButton3.MinimumSize = new System.Drawing.Size(75, 23);
            this.splitButton3.Name = "splitButton3";
            this.splitButton3.Renderer = splitButtonRenderer1;
            this.splitButton3.ShowDropDownOnButtonClick = false;
            this.splitButton3.Size = new System.Drawing.Size(304, 43);
            this.splitButton3.TabIndex = 0;
            this.splitButton3.Text = "Default";
            this.splitButton3.ThemeName = "Default";
            this.splitButton3.Click += new System.EventHandler(this.splitButton3_Click);
            // 
            // splitButton1
            // 
            this.splitButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.splitButton1.BeforeTouchSize = new System.Drawing.Size(238, 43);
            this.splitButton1.DropDownIconColor = System.Drawing.Color.White;
            this.splitButton1.DropDownPosition = Syncfusion.Windows.Forms.Tools.Position.Bottom;
            this.splitButton1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.splitButton1.ForeColor = System.Drawing.Color.White;
            this.splitButton1.Location = new System.Drawing.Point(19, 52);
            this.splitButton1.MinimumSize = new System.Drawing.Size(75, 23);
            this.splitButton1.Name = "splitButton1";
            this.splitButton1.Renderer = metroSplitButtonRenderer2;
            this.splitButton1.ShowDropDownOnButtonClick = false;
            this.splitButton1.Size = new System.Drawing.Size(238, 43);
            this.splitButton1.Style = Syncfusion.Windows.Forms.Tools.SplitButtonVisualStyle.Metro;
            this.splitButton1.TabIndex = 3;
            this.splitButton1.Text = "Find";
            // 
            // splitButton2
            // 
            this.splitButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.splitButton2.BeforeTouchSize = new System.Drawing.Size(155, 48);
            this.splitButton2.DropDownIconColor = System.Drawing.Color.White;
            this.splitButton2.DropDownPosition = Syncfusion.Windows.Forms.Tools.Position.Bottom;
            this.splitButton2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.splitButton2.ForeColor = System.Drawing.Color.White;
            this.splitButton2.Location = new System.Drawing.Point(30, 57);
            this.splitButton2.MinimumSize = new System.Drawing.Size(75, 23);
            this.splitButton2.Name = "splitButton2";
            this.splitButton2.Renderer = metroSplitButtonRenderer3;
            this.splitButton2.ShowDropDownOnButtonClick = false;
            this.splitButton2.Size = new System.Drawing.Size(155, 48);
            this.splitButton2.Style = Syncfusion.Windows.Forms.Tools.SplitButtonVisualStyle.Metro;
            this.splitButton2.TabIndex = 1;
            this.splitButton2.Text = "Find";
            // 
            // splitButton8
            // 
            this.splitButton8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitButton8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.splitButton8.BeforeTouchSize = new System.Drawing.Size(304, 43);
            this.splitButton8.DropDownIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.splitButton8.DropDownPosition = Syncfusion.Windows.Forms.Tools.Position.Bottom;
            this.splitButton8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.splitButton8.Location = new System.Drawing.Point(726, 105);
            this.splitButton8.MinimumSize = new System.Drawing.Size(75, 23);
            this.splitButton8.Name = "splitButton8";
            this.splitButton8.Renderer = office2016DarkGraySplitButtonRenderer1;
            this.splitButton8.ShowDropDownOnButtonClick = false;
            this.splitButton8.Size = new System.Drawing.Size(304, 43);
            this.splitButton8.Style = Syncfusion.Windows.Forms.Tools.SplitButtonVisualStyle.Office2016DarkGray;
            this.splitButton8.TabIndex = 5;
            this.splitButton8.Text = "Office2016DarkGray";
            this.splitButton8.ThemeName = "Office2016DarkGray";
            // 
            // splitButton7
            // 
            this.splitButton7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitButton7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.splitButton7.BeforeTouchSize = new System.Drawing.Size(304, 43);
            this.splitButton7.DropDownIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.splitButton7.DropDownPosition = Syncfusion.Windows.Forms.Tools.Position.Bottom;
            this.splitButton7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.splitButton7.Location = new System.Drawing.Point(377, 105);
            this.splitButton7.MinimumSize = new System.Drawing.Size(75, 23);
            this.splitButton7.Name = "splitButton7";
            this.splitButton7.Renderer = office2016BlackSplitButtonRenderer1;
            this.splitButton7.ShowDropDownOnButtonClick = false;
            this.splitButton7.Size = new System.Drawing.Size(304, 43);
            this.splitButton7.Style = Syncfusion.Windows.Forms.Tools.SplitButtonVisualStyle.Office2016Black;
            this.splitButton7.TabIndex = 4;
            this.splitButton7.Text = "Office2016Black";
            this.splitButton7.ThemeName = "Office2016Black";
            // 
            // splitButton6
            // 
            this.splitButton6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitButton6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.splitButton6.BeforeTouchSize = new System.Drawing.Size(304, 43);
            this.splitButton6.DropDownIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.splitButton6.DropDownPosition = Syncfusion.Windows.Forms.Tools.Position.Bottom;
            this.splitButton6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.splitButton6.Location = new System.Drawing.Point(43, 105);
            this.splitButton6.MinimumSize = new System.Drawing.Size(75, 23);
            this.splitButton6.Name = "splitButton6";
            this.splitButton6.Renderer = office2016WhiteSplitButtonRenderer1;
            this.splitButton6.ShowDropDownOnButtonClick = false;
            this.splitButton6.Size = new System.Drawing.Size(304, 43);
            this.splitButton6.Style = Syncfusion.Windows.Forms.Tools.SplitButtonVisualStyle.Office2016White;
            this.splitButton6.TabIndex = 3;
            this.splitButton6.Text = "Office2016White";
            this.splitButton6.ThemeName = "Office2016White";
            // 
            // splitButton5
            // 
            this.splitButton5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitButton5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.splitButton5.BeforeTouchSize = new System.Drawing.Size(304, 43);
            this.splitButton5.DropDownIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.splitButton5.DropDownPosition = Syncfusion.Windows.Forms.Tools.Position.Bottom;
            this.splitButton5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.splitButton5.Location = new System.Drawing.Point(726, 42);
            this.splitButton5.MinimumSize = new System.Drawing.Size(75, 23);
            this.splitButton5.Name = "splitButton5";
            this.splitButton5.Renderer = office2016ColorfulSplitButtonRenderer1;
            this.splitButton5.ShowDropDownOnButtonClick = false;
            this.splitButton5.Size = new System.Drawing.Size(304, 43);
            this.splitButton5.Style = Syncfusion.Windows.Forms.Tools.SplitButtonVisualStyle.Office2016Colorful;
            this.splitButton5.TabIndex = 2;
            this.splitButton5.Text = "Office2016Colorful";
            this.splitButton5.ThemeName = "Office2016Colorful";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider1.Icon")));
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "");
            this.imageList1.Images.SetKeyName(1, "");
            this.imageList1.Images.SetKeyName(2, "");
            this.imageList1.Images.SetKeyName(3, "");
            this.imageList1.Images.SetKeyName(4, "");
            this.imageList1.Images.SetKeyName(5, "");
            this.imageList1.Images.SetKeyName(6, "");
            this.imageList1.Images.SetKeyName(7, "");
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.BorderColor = System.Drawing.Color.Gray;
            this.gradientPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gradientPanel1.Location = new System.Drawing.Point(10, 10);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(1230, 693);
            this.gradientPanel1.TabIndex = 16;
            // 
            // tabControl1
            // 
            this.tabControl1.ActiveTabForeColor = System.Drawing.Color.Empty;
            this.tabControl1.AllowDrop = true;
            this.tabControl1.BeforeTouchSize = new System.Drawing.Size(1228, 691);
            this.tabControl1.CloseButtonForeColor = System.Drawing.Color.Empty;
            this.tabControl1.CloseButtonHoverForeColor = System.Drawing.Color.Empty;
            this.tabControl1.CloseButtonPressedForeColor = System.Drawing.Color.Empty;
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.InActiveTabForeColor = System.Drawing.Color.Empty;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SeparatorColor = System.Drawing.SystemColors.ControlDark;
            this.tabControl1.ShowSeparator = false;
            this.tabControl1.Size = new System.Drawing.Size(1228, 691);
            this.tabControl1.TabIndex = 15;
            this.tabControl1.TabPanelBackColor = System.Drawing.Color.White;
            this.tabControl1.TabStyle = typeof(Syncfusion.Windows.Forms.Tools.TabRendererMetro);
            // 
            // tabPageAdv1
            // 
            this.tabPageAdv1.Image = null;
            this.tabPageAdv1.ImageSize = new System.Drawing.Size(16, 16);
            this.tabPageAdv1.Location = new System.Drawing.Point(1, 32);
            this.tabPageAdv1.Name = "tabPageAdv1";
            this.tabPageAdv1.ShowCloseButton = true;
            this.tabPageAdv1.Size = new System.Drawing.Size(1225, 657);
            this.tabPageAdv1.TabFont = null;
            this.tabPageAdv1.TabIndex = 4;
            this.tabPageAdv1.Text = "SplitButtonAdv";
            this.tabPageAdv1.ThemesEnabled = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.groupBox8);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.gradientPanel18);
            this.panel1.Controls.Add(this.gradientPanel19);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1081, 603);
            this.panel1.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(238, 54);
            this.label4.TabIndex = 8;
            this.label4.Text = "SplitButton";
            // 
            // groupBox8
            // 
            this.groupBox8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox8.Controls.Add(this.splitButton8);
            this.groupBox8.Controls.Add(this.splitButton7);
            this.groupBox8.Controls.Add(this.splitButton6);
            this.groupBox8.Controls.Add(this.splitButton5);
            this.groupBox8.Controls.Add(this.splitButton4);
            this.groupBox8.Controls.Add(this.splitButton3);
            this.groupBox8.Location = new System.Drawing.Point(0, 395);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(1081, 171);
            this.groupBox8.TabIndex = 7;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Visual Style";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(54, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 32);
            this.label1.TabIndex = 6;
            // 
            // gradientPanel18
            // 
            this.gradientPanel18.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gradientPanel18.BackColor = System.Drawing.Color.White;
            this.gradientPanel18.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.ForwardDiagonal, System.Drawing.Color.White, System.Drawing.SystemColors.Window);
            this.gradientPanel18.Border3DStyle = System.Windows.Forms.Border3DStyle.RaisedInner;
            this.gradientPanel18.BorderColor = System.Drawing.Color.LightGray;
            this.gradientPanel18.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gradientPanel18.Controls.Add(this.gradientPanel20);
            this.gradientPanel18.Controls.Add(this.panel3);
            this.gradientPanel18.Controls.Add(this.panel4);
            this.gradientPanel18.Location = new System.Drawing.Point(367, 57);
            this.gradientPanel18.Name = "gradientPanel18";
            this.gradientPanel18.Size = new System.Drawing.Size(675, 314);
            this.gradientPanel18.TabIndex = 5;
            // 
            // gradientPanel20
            // 
            this.gradientPanel20.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gradientPanel20.BorderColor = System.Drawing.Color.Silver;
            this.gradientPanel20.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gradientPanel20.Controls.Add(this.label9);
            this.gradientPanel20.Controls.Add(this.radioButtonAdv17);
            this.gradientPanel20.Controls.Add(this.radioButtonAdv6);
            this.gradientPanel20.Controls.Add(this.radioButtonAdv4);
            this.gradientPanel20.Controls.Add(this.radioButtonAdv3);
            this.gradientPanel20.Location = new System.Drawing.Point(30, 188);
            this.gradientPanel20.Name = "gradientPanel20";
            this.gradientPanel20.Size = new System.Drawing.Size(572, 117);
            this.gradientPanel20.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(5, 10);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(230, 36);
            this.label9.TabIndex = 4;
            this.label9.Text = "DropDownPosition";
            // 
            // radioButtonAdv17
            // 
            this.radioButtonAdv17.BeforeTouchSize = new System.Drawing.Size(142, 39);
            this.radioButtonAdv17.DrawFocusRectangle = false;
            this.radioButtonAdv17.ForeColor = System.Drawing.SystemColors.ControlText;
            this.radioButtonAdv17.ImageCheckBoxSize = new System.Drawing.Size(20, 20);
            this.radioButtonAdv17.Location = new System.Drawing.Point(414, 57);
            this.radioButtonAdv17.MetroColor = System.Drawing.Color.Gray;
            this.radioButtonAdv17.Name = "radioButtonAdv17";
            this.radioButtonAdv17.Size = new System.Drawing.Size(142, 39);
            this.radioButtonAdv17.Style = Syncfusion.Windows.Forms.Tools.RadioButtonAdvStyle.Metro;
            this.radioButtonAdv17.TabIndex = 3;
            this.radioButtonAdv17.TabStop = false;
            this.radioButtonAdv17.Text = "Right";
            this.radioButtonAdv17.ThemesEnabled = false;
            this.radioButtonAdv17.Click += new System.EventHandler(this.radioButtonAdv17_CheckChanged);
            // 
            // radioButtonAdv6
            // 
            this.radioButtonAdv6.BeforeTouchSize = new System.Drawing.Size(113, 38);
            this.radioButtonAdv6.DrawFocusRectangle = false;
            this.radioButtonAdv6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.radioButtonAdv6.ImageCheckBoxSize = new System.Drawing.Size(20, 20);
            this.radioButtonAdv6.Location = new System.Drawing.Point(145, 57);
            this.radioButtonAdv6.MetroColor = System.Drawing.Color.Gray;
            this.radioButtonAdv6.Name = "radioButtonAdv6";
            this.radioButtonAdv6.Size = new System.Drawing.Size(113, 38);
            this.radioButtonAdv6.Style = Syncfusion.Windows.Forms.Tools.RadioButtonAdvStyle.Metro;
            this.radioButtonAdv6.TabIndex = 2;
            this.radioButtonAdv6.TabStop = false;
            this.radioButtonAdv6.Text = "Left";
            this.radioButtonAdv6.ThemesEnabled = false;
            this.radioButtonAdv6.Click += new System.EventHandler(this.radioButtonAdv6_CheckChanged);
            // 
            // radioButtonAdv4
            // 
            this.radioButtonAdv4.BeforeTouchSize = new System.Drawing.Size(144, 39);
            this.radioButtonAdv4.Checked = true;
            this.radioButtonAdv4.DrawFocusRectangle = false;
            this.radioButtonAdv4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.radioButtonAdv4.ImageCheckBoxSize = new System.Drawing.Size(20, 20);
            this.radioButtonAdv4.Location = new System.Drawing.Point(264, 56);
            this.radioButtonAdv4.MetroColor = System.Drawing.Color.Gray;
            this.radioButtonAdv4.Name = "radioButtonAdv4";
            this.radioButtonAdv4.Size = new System.Drawing.Size(144, 39);
            this.radioButtonAdv4.Style = Syncfusion.Windows.Forms.Tools.RadioButtonAdvStyle.Metro;
            this.radioButtonAdv4.TabIndex = 1;
            this.radioButtonAdv4.Text = "Bottom";
            this.radioButtonAdv4.ThemesEnabled = false;
            this.radioButtonAdv4.Click += new System.EventHandler(this.radioButtonAdv4_CheckChanged);
            // 
            // radioButtonAdv3
            // 
            this.radioButtonAdv3.BeforeTouchSize = new System.Drawing.Size(109, 38);
            this.radioButtonAdv3.DrawFocusRectangle = false;
            this.radioButtonAdv3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.radioButtonAdv3.ImageCheckBoxSize = new System.Drawing.Size(20, 20);
            this.radioButtonAdv3.Location = new System.Drawing.Point(30, 57);
            this.radioButtonAdv3.MetroColor = System.Drawing.Color.Gray;
            this.radioButtonAdv3.Name = "radioButtonAdv3";
            this.radioButtonAdv3.Size = new System.Drawing.Size(109, 38);
            this.radioButtonAdv3.Style = Syncfusion.Windows.Forms.Tools.RadioButtonAdvStyle.Metro;
            this.radioButtonAdv3.TabIndex = 0;
            this.radioButtonAdv3.TabStop = false;
            this.radioButtonAdv3.Text = "Top";
            this.radioButtonAdv3.ThemesEnabled = false;
            this.radioButtonAdv3.Click += new System.EventHandler(this.radioButtonAdv3_CheckChanged);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel3.BorderColor = System.Drawing.Color.LightGray;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.radioButton2);
            this.panel3.Controls.Add(this.radioButton1);
            this.panel3.Location = new System.Drawing.Point(30, 35);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(261, 130);
            this.panel3.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(3, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 36);
            this.label2.TabIndex = 2;
            this.label2.Text = "ButtonMode";
            // 
            // radioButton2
            // 
            this.radioButton2.BeforeTouchSize = new System.Drawing.Size(208, 36);
            this.radioButton2.DrawFocusRectangle = false;
            this.radioButton2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.radioButton2.ImageCheckBoxSize = new System.Drawing.Size(20, 20);
            this.radioButton2.Location = new System.Drawing.Point(27, 89);
            this.radioButton2.MetroColor = System.Drawing.Color.DarkGray;
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(208, 36);
            this.radioButton2.Style = Syncfusion.Windows.Forms.Tools.RadioButtonAdvStyle.Metro;
            this.radioButton2.TabIndex = 1;
            this.radioButton2.Text = "NormalMode";
            this.radioButton2.ThemesEnabled = false;
            // 
            // radioButton1
            // 
            this.radioButton1.BeforeTouchSize = new System.Drawing.Size(205, 40);
            this.radioButton1.DrawFocusRectangle = false;
            this.radioButton1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.radioButton1.ImageCheckBoxSize = new System.Drawing.Size(20, 20);
            this.radioButton1.Location = new System.Drawing.Point(30, 43);
            this.radioButton1.MetroColor = System.Drawing.Color.DarkGray;
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(205, 40);
            this.radioButton1.Style = Syncfusion.Windows.Forms.Tools.RadioButtonAdvStyle.Metro;
            this.radioButton1.TabIndex = 0;
            this.radioButton1.Text = "ToogleMode";
            this.radioButton1.ThemesEnabled = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel4.BorderColor = System.Drawing.Color.LightGray;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.buttonAdv3);
            this.panel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel4.Location = new System.Drawing.Point(348, 35);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(223, 130);
            this.panel4.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(5, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(198, 36);
            this.label3.TabIndex = 4;
            this.label3.Text = "DropDown Item";
            // 
            // buttonAdv3
            // 
            this.buttonAdv3.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.buttonAdv3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218)))));
            this.buttonAdv3.BeforeTouchSize = new System.Drawing.Size(146, 41);
            this.buttonAdv3.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.None;
            this.buttonAdv3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdv3.ForeColor = System.Drawing.Color.White;
            this.buttonAdv3.IsBackStageButton = false;
            this.buttonAdv3.Location = new System.Drawing.Point(48, 60);
            this.buttonAdv3.Name = "buttonAdv3";
            this.buttonAdv3.Size = new System.Drawing.Size(146, 41);
            this.buttonAdv3.TabIndex = 1;
            this.buttonAdv3.Text = "Remove Items";
            this.buttonAdv3.UseVisualStyle = true;
            this.buttonAdv3.UseVisualStyleBackColor = false;
            // 
            // gradientPanel19
            // 
            this.gradientPanel19.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gradientPanel19.BackColor = System.Drawing.Color.White;
            this.gradientPanel19.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.BackwardDiagonal, System.Drawing.Color.White, System.Drawing.SystemColors.Window);
            this.gradientPanel19.Border3DStyle = System.Windows.Forms.Border3DStyle.RaisedInner;
            this.gradientPanel19.BorderColor = System.Drawing.Color.Gray;
            this.gradientPanel19.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gradientPanel19.Controls.Add(this.splitButton1);
            this.gradientPanel19.Controls.Add(this.panel6);
            this.gradientPanel19.Location = new System.Drawing.Point(18, 57);
            this.gradientPanel19.Name = "gradientPanel19";
            this.gradientPanel19.Size = new System.Drawing.Size(316, 314);
            this.gradientPanel19.TabIndex = 6;
            this.gradientPanel19.Paint += new System.Windows.Forms.PaintEventHandler(this.gradientPanel19_Paint);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel6.BorderColor = System.Drawing.Color.LightGray;
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.splitButton2);
            this.panel6.Controls.Add(this.label6);
            this.panel6.Location = new System.Drawing.Point(19, 145);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(285, 153);
            this.panel6.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(27, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(150, 36);
            this.label6.TabIndex = 0;
            this.label6.Text = "Customized";
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "");
            // 
            // textBoxExt2
            // 
            this.textBoxExt2.BeforeTouchSize = new System.Drawing.Size(108, 24);
            this.textBoxExt2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxExt2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxExt2.Location = new System.Drawing.Point(2, 4);
            this.textBoxExt2.Metrocolor = System.Drawing.Color.Empty;
            this.textBoxExt2.Name = "textBoxExt2";
            this.textBoxExt2.OverflowIndicatorToolTipText = null;
            this.textBoxExt2.Size = new System.Drawing.Size(108, 24);
            this.textBoxExt2.TabIndex = 0;
            this.textBoxExt2.ThemeName = "Default";
            // 
            // comboBoxAdv1
            // 
            this.comboBoxAdv1.BackColor = System.Drawing.Color.White;
            this.comboBoxAdv1.BeforeTouchSize = new System.Drawing.Size(187, 38);
            this.comboBoxAdv1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAdv1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxAdv1.Location = new System.Drawing.Point(14, 60);
            this.comboBoxAdv1.Name = "comboBoxAdv1";
            this.comboBoxAdv1.Size = new System.Drawing.Size(187, 38);
            this.comboBoxAdv1.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.comboBoxAdv1.TabIndex = 2;
            this.comboBoxAdv1.SelectionChangeCommitted += new System.EventHandler(this.comboBoxAdv1_SelectedIndexChanged);
            // 
            // MainForm
            // 
            this.BackColor = System.Drawing.Color.White;
            this.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.CaptionAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.CaptionBarHeight = 30;
            this.ClientSize = new System.Drawing.Size(1120, 647);
            this.Controls.Add(this.panel1);
            this.DropShadow = true;
            this.Font = new System.Drawing.Font("Segoe UI", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MetroColor = System.Drawing.Color.White;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Text = "GettingStarted";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabControl1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel18)).EndInit();
            this.gradientPanel18.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel20)).EndInit();
            this.gradientPanel20.ResumeLayout(false);
            this.gradientPanel20.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radioButtonAdv17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioButtonAdv6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioButtonAdv4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioButtonAdv3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel3)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radioButton2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel4)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel19)).EndInit();
            this.gradientPanel19.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panel6)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxExt2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxAdv1)).EndInit();
            this.ResumeLayout(false);

		}
        #endregion

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            SyncfusionLicenseProvider.RegisterLicense(DemoCommon.FindLicenseKey());
            Application.Run(new MainForm());
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



        private void menuItem2_Click(object sender, System.EventArgs e)
		{
			Application.Exit();
		}

        #region buttonEdit1_ButtonClicked
		private void buttonEdit1_ButtonClicked(object sender, Syncfusion.Windows.Forms.Tools.ButtonClickedEventArgs args)
		{
			string item = args.ClickedButton.Name;
			string eventlogmessage = String.Format("Event: {0} Item: {1}\r\n", "ButtonClicked", item);
		}
		#endregion

		private void MainForm_Load(object sender, System.EventArgs e)
		{
            //this.StartPosition = FormStartPosition.CenterScreen;
            //if (WindowState == FormWindowState.Maximized)
            //{
            //    this.groupBox6.Location = new Point(400, 302);
            //    this.groupBox7.Location = new Point(400, 131);
            //    this.groupBox1.Location = new Point(475, 247);
            //    this.groupBox2.Location = new Point(475, 69);
            //    this.groupBox5.Location = new Point(475, 436);
            //    this.groupBox4.Location = new Point(381, 180);
            //    this.gradientPanel18.Location = new Point(585, 39);
            //    this.gradientPanel19.Location = new Point(217, 39);
            //}
            //else
            //{
            //    this.groupBox6.Location = new Point(43, 202);
            //    this.groupBox7.Location = new Point(43, 31);
            //    this.groupBox1.Location = new Point(175, 147);
            //    this.groupBox2.Location = new Point(175, 69);
            //    this.groupBox5.Location = new Point(175, 236);
            //    this.groupBox4.Location = new Point(81, 80);
            //    this.gradientPanel18.Location = new Point(285, 39);
            //    this.gradientPanel19.Location = new Point(27, 39);
            //}
        }


        private void radioButtonAdv3_CheckChanged(object sender, EventArgs e)
        {
            if (radioButtonAdv3.Checked)
            {
                this.splitButton1.DropDownPosition = Position.Top;
                this.splitButton2.DropDownPosition = Position.Top;
            }
        }

        private void radioButtonAdv6_CheckChanged(object sender, EventArgs e)
        {
            if (radioButtonAdv6.Checked)
            {
                this.splitButton1.DropDownPosition = Position.Left;
                this.splitButton2.DropDownPosition = Position.Left;
            }
        }

        private void radioButtonAdv4_CheckChanged(object sender, EventArgs e)
        {
            if (radioButtonAdv4.Checked)
            {
                this.splitButton1.DropDownPosition = Position.Bottom;
                this.splitButton2.DropDownPosition = Position.Bottom;
            }
        }

        private void radioButtonAdv17_CheckChanged(object sender, EventArgs e)
        {
            if (radioButtonAdv17.Checked)
            {
                this.splitButton1.DropDownPosition = Position.Right;
                this.splitButton2.DropDownPosition = Position.Right;
            }
        }

        private void comboBoxAdv1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.comboBoxAdv1.SelectedItem.ToString().Equals("Office2016White"))
            {
                this.splitButton1.Style = Syncfusion.Windows.Forms.Tools.SplitButtonVisualStyle.Office2016White;
            }
            if (this.comboBoxAdv1.SelectedItem.ToString().Equals("Office2016Black"))
            {
                this.splitButton1.Style = Syncfusion.Windows.Forms.Tools.SplitButtonVisualStyle.Office2016Black;
            }
            if (this.comboBoxAdv1.SelectedItem.ToString().Equals("Office2016DarkGray"))
            {
                this.splitButton1.Style = Syncfusion.Windows.Forms.Tools.SplitButtonVisualStyle.Office2016DarkGray;
            }
            if (this.comboBoxAdv1.SelectedItem.ToString().Equals("Office2016Colorful"))
            {
                this.splitButton1.Style = Syncfusion.Windows.Forms.Tools.SplitButtonVisualStyle.Office2016Colorful;
            }
            if (this.comboBoxAdv1.SelectedItem.ToString().Equals("Default"))
            {
                this.splitButton1.Style = Syncfusion.Windows.Forms.Tools.SplitButtonVisualStyle.Default;
            }
            if (this.comboBoxAdv1.SelectedItem.ToString().Equals("Metro"))
            {
                this.splitButton1.Style = Syncfusion.Windows.Forms.Tools.SplitButtonVisualStyle.Metro;

            }
        }

        private void splitButton3_Click(object sender, EventArgs e)
        {

        }

        private void splitButton2_Click(object sender, EventArgs e)
        {

        }

        private void gradientPanel19_Paint(object sender, PaintEventArgs e)
        {

        }
    }
    public class CustomRenderer : ISplitButtonRenderer
    {
        private SplitButton splitButton;

        #region ISplitButtonRenderer Members
       

        public void DrawText(PaintEventArgs e, string text, Font font, Color color, int totalwidth, int totalheight, int splitwidth)
        {

            SolidBrush brush = new SolidBrush(color);
            StringFormat format = new StringFormat();
            format.Trimming = StringTrimming.EllipsisCharacter;
            format.LineAlignment = StringAlignment.Center;
            format.Alignment = StringAlignment.Center;
            Rectangle textArea = new Rectangle(7, 1, totalwidth - splitwidth, totalheight);
            e.Graphics.DrawString(text, font, brush, textArea, format);

            Rectangle imageRect = new Rectangle(4, 11, 15, totalheight - 24);
#if NETCORE
            Image img = Image.FromFile(@"../../../logo_16.ico");
#else
            Image img = Image.FromFile(@"../../logo_16.ico");
#endif
            e.Graphics.DrawImage(img, imageRect);
            brush.Dispose();
        }

        public void DrawBorder(PaintEventArgs e, int width, int height, int splitwidth, Color outerColor, Color innerColor, Color arrowOuter, Color arrowInner, Color buttonInner)
        {
            // Can Customize the Border Color of the SplitButton 
            // Outer Color is Changed 
            MainForm frm = new MainForm();
            Color color1 = frm.startcolor;
            Color color2 = frm.endcolor;
            Brush linearGradientBrush = new LinearGradientBrush(
                          new Rectangle(0, 0, width, height), color1, color2, 90);
            e.Graphics.FillRectangle(linearGradientBrush, new Rectangle(0, 0, width, height));
            linearGradientBrush.Dispose();
            Pen outercolor = new Pen(Color.DarkGreen);
            Pen innercolor = new Pen(Color.LightGreen);
            Pen arrowinner = new Pen(Color.LightGreen);
            Pen arrowouter = new Pen(arrowOuter);
            Pen buttoninner = new Pen(buttonInner);

            e.Graphics.DrawLine(innercolor, new Point(1, 1), new Point(width - 2, 1));
            e.Graphics.DrawLine(innercolor, new Point(width - 2, 1), new Point(width - 2, height - 2));
            e.Graphics.DrawLine(innercolor, new Point(1, height - 2), new Point(width - 2, height - 2));
            e.Graphics.DrawLine(innercolor, new Point(1, 1), new Point(1, height - 2));

            e.Graphics.DrawLine(arrowouter, new Point(width - splitwidth, 0), new Point(width - splitwidth, height - 1));

            e.Graphics.DrawLine(buttoninner, new Point(width - splitwidth - 1, 2), new Point(width - splitwidth - 1, height - 3));

            e.Graphics.DrawRectangle(arrowinner, width - splitwidth + 1, 1, splitwidth - 3, height - 3);

            e.Graphics.DrawLine(outercolor, new Point(1, 0), new Point(width - 2, 0));
            e.Graphics.DrawLine(outercolor, new Point(width - 2, 0), new Point(width - 2, 1));
            e.Graphics.DrawLine(outercolor, new Point(width - 1, 1), new Point(width - 1, height - 2));
            e.Graphics.DrawLine(outercolor, new Point(width - 2, height - 2), new Point(width - 2, height - 1));
            e.Graphics.DrawLine(outercolor, new Point(1, height - 1), new Point(width - 2, height - 1));
            e.Graphics.DrawLine(outercolor, new Point(1, height - 1), new Point(1, height - 2));
            e.Graphics.DrawLine(outercolor, new Point(0, 1), new Point(0, height - 2));
            e.Graphics.DrawLine(outercolor, new Point(1, 0), new Point(1, 1));


            buttoninner.Dispose();
            innercolor.Dispose();
            arrowinner.Dispose();
            arrowinner.Dispose();
            outercolor.Dispose();

        }

        public void DrawArrow(int left, int top, int width, int height, PaintEventArgs e, Color ArrowColor)
        {
            //Customize arrow as image
#if NETCORE
            Image arrowImage = Image.FromFile(@"../../../arrow4.png");
#else
            Image arrowImage = Image.FromFile(@"../../arrow4.png");
#endif
            Rectangle imageRect = new Rectangle(left + 4, top + 14, width - 9, height - 28);
            e.Graphics.DrawImage(arrowImage, imageRect);

        }

        #endregion

        #region ISplitButtonRenderer Members

        public SplitButton SplitButton
        {
            get
            {
                return splitButton;
            }
            set
            {
                splitButton = value;
            }
        }

        #endregion
    }
}

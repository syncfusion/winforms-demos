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
using System.Drawing.Drawing2D;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Globalization;
using System.Resources;

using Syncfusion.Windows.Forms.Tools;
using Syncfusion.Windows.Forms;
using System.Reflection;
using System.IO;
using Syncfusion.Licensing;


namespace CalendarControlsDemo
{
	
	public class Form1 : MetroForm
    {
        #region Declaration

        private System.Windows.Forms.ImageList imageList1;
		private System.ComponentModel.IContainer components;
        DataSet m_dataSetTbg = null;
        private ToolTip toolTip1;
        private CheckBoxAdv checkBoxAdv10;
        private Label label15;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv comboBox9;
        private Label label16;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv comboBox10;
        private CheckBoxAdv checkBoxAdv11;
        private CheckBoxAdv checkBoxAdv13;
        private CheckBoxAdv checkBoxAdv14;
        private MonthCalendarAdv monthCalendarAdv2;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv comboBox11;
        private Label label20;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv comboBox12;
        private Label label22;
        private CheckBoxAdv checkBoxAdv16;
        private CheckBoxAdv checkBoxAdv15;
        private Label label42;
        private ButtonEdit buttonEdit1;
        private ButtonEditChildButton buttonEditChildButton2;
        private ColorDialog colorDialog1;
        private Label label13;
        private ButtonEdit buttonEdit2;
        private ButtonEditChildButton buttonEditChildButton1;
        private Label label24;
        private ButtonEdit buttonEdit3;
        private ButtonEditChildButton buttonEditChildButton3;
        private Label label25;
        private ButtonEdit buttonEdit4;
        private ButtonEditChildButton buttonEditChildButton4;
        private CheckBoxAdv checkBoxAdv12;
        private Label label27;
        private ButtonEdit buttonEdit6;
        private ButtonEditChildButton buttonEditChildButton6;
        private Label label26;
        private ButtonEdit buttonEdit5;
        private ButtonEditChildButton buttonEditChildButton5;
        private GradientPanel gradientPanel1;
        private Label label14;
        private GradientPanel gradientPanel8;
        private GradientPanel gradientPanel7;
        private GradientPanel gradientPanel6;
        private GroupBar groupBar1;
        private GroupBarItem groupBarItem1;
        private GroupBarItem groupBarItem2;
        private GroupBarItem groupBarItem3;
        private SplitContainerAdv splitContainerAdv1;
		DataTable table = null;
        #endregion

        #region Form Constructor and Dispose
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


            this.buttonEdit1.ShowTextBox = true;
            this.buttonEdit2.ShowTextBox = true;
            this.buttonEdit3.ShowTextBox = true;
            this.buttonEdit4.ShowTextBox = true;
            this.buttonEdit5.ShowTextBox = true;
            this.buttonEdit6.ShowTextBox = true;
            this.buttonEdit1.TextBox.KeyPress += new KeyPressEventHandler(TextBox_KeyPress);
            this.buttonEdit2.TextBox.KeyPress +=new KeyPressEventHandler(TextBox_KeyPress);
            this.buttonEdit3.TextBox.KeyPress+=new KeyPressEventHandler(TextBox_KeyPress);
            this.buttonEdit4.TextBox.KeyPress += new KeyPressEventHandler(TextBox_KeyPress);
            this.buttonEdit5.TextBox.KeyPress += new KeyPressEventHandler(TextBox_KeyPress);
            this.buttonEdit6.TextBox.KeyPress += new KeyPressEventHandler(TextBox_KeyPress);
            this.groupBar1.SelectedItem = 0;
        }

        void TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //define a string containing special characters
            string arr = "!@#$%^&*()+=-[]\\\';,./{}|\":<>?";
            for (int k = 0; k < arr.Length; k++)
            {
                if (e.KeyChar == arr[k])
                {
                    MessageBox.Show("special characters not allowed","Invalid");
                    e.Handled = true;
                    break;

                }
            }
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
        #endregion

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
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.monthCalendarAdv2 = new Syncfusion.Windows.Forms.Tools.MonthCalendarAdv();
            this.gradientPanel8 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            this.label13 = new System.Windows.Forms.Label();
            this.buttonEdit2 = new Syncfusion.Windows.Forms.Tools.ButtonEdit();
            this.buttonEditChildButton1 = new Syncfusion.Windows.Forms.Tools.ButtonEditChildButton();
            this.buttonEdit4 = new Syncfusion.Windows.Forms.Tools.ButtonEdit();
            this.buttonEditChildButton4 = new Syncfusion.Windows.Forms.Tools.ButtonEditChildButton();
            this.label25 = new System.Windows.Forms.Label();
            this.label42 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.buttonEdit1 = new Syncfusion.Windows.Forms.Tools.ButtonEdit();
            this.buttonEditChildButton2 = new Syncfusion.Windows.Forms.Tools.ButtonEditChildButton();
            this.buttonEdit6 = new Syncfusion.Windows.Forms.Tools.ButtonEdit();
            this.buttonEditChildButton6 = new Syncfusion.Windows.Forms.Tools.ButtonEditChildButton();
            this.buttonEdit3 = new Syncfusion.Windows.Forms.Tools.ButtonEdit();
            this.buttonEditChildButton3 = new Syncfusion.Windows.Forms.Tools.ButtonEditChildButton();
            this.label26 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.buttonEdit5 = new Syncfusion.Windows.Forms.Tools.ButtonEdit();
            this.buttonEditChildButton5 = new Syncfusion.Windows.Forms.Tools.ButtonEditChildButton();
            this.checkBoxAdv12 = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.gradientPanel7 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            this.label16 = new System.Windows.Forms.Label();
            this.checkBoxAdv11 = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.comboBox10 = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.comboBox9 = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.label15 = new System.Windows.Forms.Label();
            this.checkBoxAdv15 = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.checkBoxAdv16 = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.gradientPanel6 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            this.label20 = new System.Windows.Forms.Label();
            this.checkBoxAdv14 = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.checkBoxAdv13 = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.checkBoxAdv10 = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.label22 = new System.Windows.Forms.Label();
            this.comboBox12 = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.comboBox11 = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.gradientPanel1 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            this.label14 = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.groupBar1 = new Syncfusion.Windows.Forms.Tools.GroupBar();
            this.groupBarItem1 = new Syncfusion.Windows.Forms.Tools.GroupBarItem();
            this.groupBarItem2 = new Syncfusion.Windows.Forms.Tools.GroupBarItem();
            this.groupBarItem3 = new Syncfusion.Windows.Forms.Tools.GroupBarItem();
            this.splitContainerAdv1 = new Syncfusion.Windows.Forms.Tools.SplitContainerAdv();
            ((System.ComponentModel.ISupportInitialize)(this.monthCalendarAdv2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel8)).BeginInit();
            this.gradientPanel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonEdit2)).BeginInit();
            this.buttonEdit2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonEdit4)).BeginInit();
            this.buttonEdit4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonEdit1)).BeginInit();
            this.buttonEdit1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonEdit6)).BeginInit();
            this.buttonEdit6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonEdit3)).BeginInit();
            this.buttonEdit3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonEdit5)).BeginInit();
            this.buttonEdit5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxAdv12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel7)).BeginInit();
            this.gradientPanel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxAdv11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxAdv15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxAdv16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel6)).BeginInit();
            this.gradientPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxAdv14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxAdv13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxAdv10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBox12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel1)).BeginInit();
            this.gradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupBar1)).BeginInit();
            this.groupBar1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerAdv1)).BeginInit();
            this.splitContainerAdv1.Panel1.SuspendLayout();
            this.splitContainerAdv1.Panel2.SuspendLayout();
            this.splitContainerAdv1.SuspendLayout();
            this.SuspendLayout();
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
            this.imageList1.Images.SetKeyName(8, "");
            this.imageList1.Images.SetKeyName(9, "");
            this.imageList1.Images.SetKeyName(10, "");
            this.imageList1.Images.SetKeyName(11, "");
            // 
            // monthCalendarAdv2
            // 
            this.monthCalendarAdv2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.monthCalendarAdv2.BackColor = System.Drawing.Color.White;
            this.monthCalendarAdv2.Border3DStyle = System.Windows.Forms.Border3DStyle.Flat;
            this.monthCalendarAdv2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.monthCalendarAdv2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.monthCalendarAdv2.BottomHeight = 25;
            this.monthCalendarAdv2.Culture = new System.Globalization.CultureInfo("");
            this.monthCalendarAdv2.DayNamesColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.monthCalendarAdv2.DayNamesFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.monthCalendarAdv2.DaysColor = System.Drawing.Color.Black;
            this.monthCalendarAdv2.DaysFont = new System.Drawing.Font("Verdana", 8F);
            this.monthCalendarAdv2.DaysHeaderInterior = new Syncfusion.Drawing.BrushInfo(System.Drawing.SystemColors.Window);
            this.monthCalendarAdv2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthCalendarAdv2.GridLines = Syncfusion.Windows.Forms.Grid.GridBorderStyle.None;
            this.monthCalendarAdv2.HeaderHeight = 34;
            this.monthCalendarAdv2.HeaderStartColor = System.Drawing.Color.White;
            this.monthCalendarAdv2.HighlightColor = System.Drawing.Color.Black;
            this.monthCalendarAdv2.Iso8601CalenderFormat = false;
            this.monthCalendarAdv2.Location = new System.Drawing.Point(32, 94);
            this.monthCalendarAdv2.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.monthCalendarAdv2.Name = "monthCalendarAdv2";
            this.monthCalendarAdv2.ScrollButtonSize = new System.Drawing.Size(24, 24);
            this.monthCalendarAdv2.Size = new System.Drawing.Size(213, 183);
            this.monthCalendarAdv2.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.monthCalendarAdv2.TabIndex = 0;
            this.monthCalendarAdv2.WeekFont = new System.Drawing.Font("Verdana", 8F);
            this.monthCalendarAdv2.WeekInterior = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.PeachPuff, System.Drawing.Color.AntiqueWhite);
            this.monthCalendarAdv2.WeekTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            // 
            // 
            // 
            this.monthCalendarAdv2.NoneButton.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.monthCalendarAdv2.NoneButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.monthCalendarAdv2.NoneButton.BeforeTouchSize = new System.Drawing.Size(18, 19);
            this.monthCalendarAdv2.NoneButton.ForeColor = System.Drawing.Color.White;
            this.monthCalendarAdv2.NoneButton.IsBackStageButton = false;
            this.monthCalendarAdv2.NoneButton.Location = new System.Drawing.Point(141, 0);
            this.monthCalendarAdv2.NoneButton.Size = new System.Drawing.Size(72, 25);
            this.monthCalendarAdv2.NoneButton.Text = "None";
            this.monthCalendarAdv2.NoneButton.UseVisualStyle = true;
            // 
            // 
            // 
            this.monthCalendarAdv2.TodayButton.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.monthCalendarAdv2.TodayButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.monthCalendarAdv2.TodayButton.BeforeTouchSize = new System.Drawing.Size(18, 19);
            this.monthCalendarAdv2.TodayButton.ForeColor = System.Drawing.Color.White;
            this.monthCalendarAdv2.TodayButton.IsBackStageButton = false;
            this.monthCalendarAdv2.TodayButton.Location = new System.Drawing.Point(0, 0);
            this.monthCalendarAdv2.TodayButton.Size = new System.Drawing.Size(141, 25);
            this.monthCalendarAdv2.TodayButton.Text = "Today";
            this.monthCalendarAdv2.TodayButton.UseVisualStyle = true;
            // 
            // gradientPanel8
            // 
            this.gradientPanel8.BackColor = System.Drawing.Color.White;
            this.gradientPanel8.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(199)))), ((int)(((byte)(235)))));
            this.gradientPanel8.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gradientPanel8.Controls.Add(this.label13);
            this.gradientPanel8.Controls.Add(this.buttonEdit2);
            this.gradientPanel8.Controls.Add(this.buttonEdit4);
            this.gradientPanel8.Controls.Add(this.label25);
            this.gradientPanel8.Controls.Add(this.label42);
            this.gradientPanel8.Controls.Add(this.label27);
            this.gradientPanel8.Controls.Add(this.buttonEdit1);
            this.gradientPanel8.Controls.Add(this.buttonEdit6);
            this.gradientPanel8.Controls.Add(this.buttonEdit3);
            this.gradientPanel8.Controls.Add(this.label26);
            this.gradientPanel8.Controls.Add(this.label24);
            this.gradientPanel8.Controls.Add(this.buttonEdit5);
            this.gradientPanel8.Controls.Add(this.checkBoxAdv12);
            this.gradientPanel8.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gradientPanel8.ForeColor = System.Drawing.Color.Black;
            this.gradientPanel8.Location = new System.Drawing.Point(0, 66);
            this.gradientPanel8.Name = "gradientPanel8";
            this.gradientPanel8.Size = new System.Drawing.Size(256, 322);
            this.gradientPanel8.TabIndex = 193;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(7, 26);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(62, 13);
            this.label13.TabIndex = 175;
            this.label13.Text = "Back Color";
            // 
            // buttonEdit2
            // 
            this.buttonEdit2.BackColor = System.Drawing.Color.White;
            this.buttonEdit2.BeforeTouchSize = new System.Drawing.Size(102, 23);
            this.buttonEdit2.Buttons.Add(this.buttonEditChildButton1);
            this.buttonEdit2.ButtonStyle = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.buttonEdit2.Controls.Add(this.buttonEditChildButton1);
            this.buttonEdit2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEdit2.Location = new System.Drawing.Point(140, 19);
            this.buttonEdit2.MetroColor = System.Drawing.Color.Silver;
            this.buttonEdit2.Name = "buttonEdit2";
            this.buttonEdit2.ShowTextBox = false;
            this.buttonEdit2.Size = new System.Drawing.Size(102, 23);
            this.buttonEdit2.TabIndex = 176;
            this.buttonEdit2.UseVisualStyle = true;
            this.buttonEdit2.ButtonClicked += new Syncfusion.Windows.Forms.Tools.ButtonClickedEventHandler(this.buttonEdit2_ButtonClicked);
            // 
            // buttonEditChildButton1
            // 
            this.buttonEditChildButton1.BackColor = System.Drawing.Color.Silver;
            this.buttonEditChildButton1.BeforeTouchSize = new System.Drawing.Size(18, 19);
            this.buttonEditChildButton1.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.Flat;
            this.buttonEditChildButton1.ComboEditBackColor = System.Drawing.Color.White;
            this.buttonEditChildButton1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditChildButton1.ForeColor = System.Drawing.Color.White;
            this.buttonEditChildButton1.Image = null;
            this.buttonEditChildButton1.IsBackStageButton = false;
            this.buttonEditChildButton1.Name = "buttonEditChildButton1";
            this.buttonEditChildButton1.PreferredWidth = 18;
            this.buttonEditChildButton1.TabIndex = 1;
            this.buttonEditChildButton1.Text = "...";
            // 
            // buttonEdit4
            // 
            this.buttonEdit4.BackColor = System.Drawing.Color.White;
            this.buttonEdit4.BeforeTouchSize = new System.Drawing.Size(102, 23);
            this.buttonEdit4.Buttons.Add(this.buttonEditChildButton4);
            this.buttonEdit4.ButtonStyle = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.buttonEdit4.Controls.Add(this.buttonEditChildButton4);
            this.buttonEdit4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEdit4.Location = new System.Drawing.Point(142, 65);
            this.buttonEdit4.MetroColor = System.Drawing.Color.Silver;
            this.buttonEdit4.Name = "buttonEdit4";
            this.buttonEdit4.ShowTextBox = false;
            this.buttonEdit4.Size = new System.Drawing.Size(102, 23);
            this.buttonEdit4.TabIndex = 180;
            this.buttonEdit4.UseVisualStyle = true;
            this.buttonEdit4.ButtonClicked += new Syncfusion.Windows.Forms.Tools.ButtonClickedEventHandler(this.buttonEdit4_ButtonClicked);
            // 
            // buttonEditChildButton4
            // 
            this.buttonEditChildButton4.BackColor = System.Drawing.Color.Silver;
            this.buttonEditChildButton4.BeforeTouchSize = new System.Drawing.Size(18, 19);
            this.buttonEditChildButton4.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.Flat;
            this.buttonEditChildButton4.ComboEditBackColor = System.Drawing.Color.White;
            this.buttonEditChildButton4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditChildButton4.ForeColor = System.Drawing.Color.White;
            this.buttonEditChildButton4.Image = null;
            this.buttonEditChildButton4.IsBackStageButton = false;
            this.buttonEditChildButton4.Name = "buttonEditChildButton4";
            this.buttonEditChildButton4.PreferredWidth = 18;
            this.buttonEditChildButton4.TabIndex = 1;
            this.buttonEditChildButton4.Text = "...";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.BackColor = System.Drawing.Color.Transparent;
            this.label25.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(7, 72);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(84, 13);
            this.label25.TabIndex = 179;
            this.label25.Text = "Grid BackColor";
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.BackColor = System.Drawing.Color.Transparent;
            this.label42.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label42.Location = new System.Drawing.Point(7, 115);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(89, 13);
            this.label42.TabIndex = 173;
            this.label42.Text = "Day Name Color";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.BackColor = System.Drawing.Color.Transparent;
            this.label27.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(7, 242);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(98, 13);
            this.label27.TabIndex = 184;
            this.label27.Text = "Header End Color";
            // 
            // buttonEdit1
            // 
            this.buttonEdit1.BackColor = System.Drawing.Color.White;
            this.buttonEdit1.BeforeTouchSize = new System.Drawing.Size(102, 23);
            this.buttonEdit1.Buttons.Add(this.buttonEditChildButton2);
            this.buttonEdit1.ButtonStyle = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.buttonEdit1.Controls.Add(this.buttonEditChildButton2);
            this.buttonEdit1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEdit1.Location = new System.Drawing.Point(142, 110);
            this.buttonEdit1.MetroColor = System.Drawing.Color.Silver;
            this.buttonEdit1.Name = "buttonEdit1";
            this.buttonEdit1.ShowTextBox = false;
            this.buttonEdit1.Size = new System.Drawing.Size(102, 23);
            this.buttonEdit1.TabIndex = 174;
            this.buttonEdit1.UseVisualStyle = true;
            this.buttonEdit1.ButtonClicked += new Syncfusion.Windows.Forms.Tools.ButtonClickedEventHandler(this.buttonEdit1_ButtonClicked);
        
            // 
            // buttonEditChildButton2
            // 
            this.buttonEditChildButton2.BackColor = System.Drawing.Color.Silver;
            this.buttonEditChildButton2.BeforeTouchSize = new System.Drawing.Size(18, 19);
            this.buttonEditChildButton2.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.Flat;
            this.buttonEditChildButton2.ComboEditBackColor = System.Drawing.Color.White;
            this.buttonEditChildButton2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditChildButton2.ForeColor = System.Drawing.Color.White;
            this.buttonEditChildButton2.Image = null;
            this.buttonEditChildButton2.IsBackStageButton = false;
            this.buttonEditChildButton2.Name = "buttonEditChildButton2";
            this.buttonEditChildButton2.PreferredWidth = 18;
            this.buttonEditChildButton2.TabIndex = 1;
            this.buttonEditChildButton2.Text = "...";
            // 
            // buttonEdit6
            // 
            this.buttonEdit6.BackColor = System.Drawing.Color.White;
            this.buttonEdit6.BeforeTouchSize = new System.Drawing.Size(102, 23);
            this.buttonEdit6.Buttons.Add(this.buttonEditChildButton6);
            this.buttonEdit6.ButtonStyle = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.buttonEdit6.Controls.Add(this.buttonEditChildButton6);
            this.buttonEdit6.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEdit6.Location = new System.Drawing.Point(142, 236);
            this.buttonEdit6.MetroColor = System.Drawing.Color.Silver;
            this.buttonEdit6.Name = "buttonEdit6";
            this.buttonEdit6.ShowTextBox = false;
            this.buttonEdit6.Size = new System.Drawing.Size(102, 23);
            this.buttonEdit6.TabIndex = 185;
            this.buttonEdit6.UseVisualStyle = true;
            this.buttonEdit6.ButtonClicked += new Syncfusion.Windows.Forms.Tools.ButtonClickedEventHandler(this.buttonEdit6_ButtonClicked);
            // 
            // buttonEditChildButton6
            // 
            this.buttonEditChildButton6.BackColor = System.Drawing.Color.Silver;
            this.buttonEditChildButton6.BeforeTouchSize = new System.Drawing.Size(18, 19);
            this.buttonEditChildButton6.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.Flat;
            this.buttonEditChildButton6.ComboEditBackColor = System.Drawing.Color.White;
            this.buttonEditChildButton6.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditChildButton6.ForeColor = System.Drawing.Color.White;
            this.buttonEditChildButton6.Image = null;
            this.buttonEditChildButton6.IsBackStageButton = false;
            this.buttonEditChildButton6.Name = "buttonEditChildButton6";
            this.buttonEditChildButton6.PreferredWidth = 18;
            this.buttonEditChildButton6.TabIndex = 1;
            this.buttonEditChildButton6.Text = "...";
            // 
            // buttonEdit3
            // 
            this.buttonEdit3.BackColor = System.Drawing.Color.White;
            this.buttonEdit3.BeforeTouchSize = new System.Drawing.Size(102, 23);
            this.buttonEdit3.Buttons.Add(this.buttonEditChildButton3);
            this.buttonEdit3.ButtonStyle = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.buttonEdit3.Controls.Add(this.buttonEditChildButton3);
            this.buttonEdit3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEdit3.Location = new System.Drawing.Point(142, 153);
            this.buttonEdit3.MetroColor = System.Drawing.Color.Silver;
            this.buttonEdit3.Name = "buttonEdit3";
            this.buttonEdit3.ShowTextBox = false;
            this.buttonEdit3.Size = new System.Drawing.Size(102, 23);
            this.buttonEdit3.TabIndex = 178;
            this.buttonEdit3.UseVisualStyle = true;
            this.buttonEdit3.ButtonClicked += new Syncfusion.Windows.Forms.Tools.ButtonClickedEventHandler(this.buttonEdit3_ButtonClicked);
            // 
            // buttonEditChildButton3
            // 
            this.buttonEditChildButton3.BackColor = System.Drawing.Color.Silver;
            this.buttonEditChildButton3.BeforeTouchSize = new System.Drawing.Size(18, 19);
            this.buttonEditChildButton3.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.Flat;
            this.buttonEditChildButton3.ComboEditBackColor = System.Drawing.Color.White;
            this.buttonEditChildButton3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditChildButton3.ForeColor = System.Drawing.Color.White;
            this.buttonEditChildButton3.Image = null;
            this.buttonEditChildButton3.IsBackStageButton = false;
            this.buttonEditChildButton3.Name = "buttonEditChildButton3";
            this.buttonEditChildButton3.PreferredWidth = 18;
            this.buttonEditChildButton3.TabIndex = 1;
            this.buttonEditChildButton3.Text = "...";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.BackColor = System.Drawing.Color.Transparent;
            this.label26.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(7, 203);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(102, 13);
            this.label26.TabIndex = 182;
            this.label26.Text = "Header Start Color";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.BackColor = System.Drawing.Color.Transparent;
            this.label24.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(7, 160);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(57, 13);
            this.label24.TabIndex = 177;
            this.label24.Text = "Day Color";
            // 
            // buttonEdit5
            // 
            this.buttonEdit5.BackColor = System.Drawing.Color.White;
            this.buttonEdit5.BeforeTouchSize = new System.Drawing.Size(102, 23);
            this.buttonEdit5.Buttons.Add(this.buttonEditChildButton5);
            this.buttonEdit5.ButtonStyle = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.buttonEdit5.Controls.Add(this.buttonEditChildButton5);
            this.buttonEdit5.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEdit5.Location = new System.Drawing.Point(142, 197);
            this.buttonEdit5.MetroColor = System.Drawing.Color.Silver;
            this.buttonEdit5.Name = "buttonEdit5";
            this.buttonEdit5.ShowTextBox = false;
            this.buttonEdit5.Size = new System.Drawing.Size(102, 23);
            this.buttonEdit5.TabIndex = 183;
            this.buttonEdit5.UseVisualStyle = true;
            this.buttonEdit5.ButtonClicked += new Syncfusion.Windows.Forms.Tools.ButtonClickedEventHandler(this.buttonEdit5_ButtonClicked);
            // 
            // buttonEditChildButton5
            // 
            this.buttonEditChildButton5.BackColor = System.Drawing.Color.Silver;
            this.buttonEditChildButton5.BeforeTouchSize = new System.Drawing.Size(18, 19);
            this.buttonEditChildButton5.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.Flat;
            this.buttonEditChildButton5.ComboEditBackColor = System.Drawing.Color.White;
            this.buttonEditChildButton5.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditChildButton5.ForeColor = System.Drawing.Color.White;
            this.buttonEditChildButton5.Image = null;
            this.buttonEditChildButton5.IsBackStageButton = false;
            this.buttonEditChildButton5.Name = "buttonEditChildButton5";
            this.buttonEditChildButton5.PreferredWidth = 18;
            this.buttonEditChildButton5.TabIndex = 1;
            this.buttonEditChildButton5.Text = "...";
            // 
            // checkBoxAdv12
            // 
            this.checkBoxAdv12.BeforeTouchSize = new System.Drawing.Size(150, 21);
            this.checkBoxAdv12.DrawFocusRectangle = false;
            this.checkBoxAdv12.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxAdv12.Location = new System.Drawing.Point(11, 283);
            this.checkBoxAdv12.MetroColor = System.Drawing.Color.Gray;
            this.checkBoxAdv12.Name = "checkBoxAdv12";
            this.checkBoxAdv12.Size = new System.Drawing.Size(191, 27);
            this.checkBoxAdv12.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.checkBoxAdv12.TabIndex = 181;
            this.checkBoxAdv12.Text = "HeaderVerticalGradient";
            this.checkBoxAdv12.ThemesEnabled = true;
            this.checkBoxAdv12.CheckStateChanged += new System.EventHandler(this.checkBoxAdv12_CheckStateChanged);
            // 
            // gradientPanel7
            // 
            this.gradientPanel7.BackColor = System.Drawing.Color.White;
            this.gradientPanel7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(199)))), ((int)(((byte)(235)))));
            this.gradientPanel7.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gradientPanel7.Controls.Add(this.label16);
            this.gradientPanel7.Controls.Add(this.checkBoxAdv11);
            this.gradientPanel7.Controls.Add(this.comboBox10);
            this.gradientPanel7.Controls.Add(this.comboBox9);
            this.gradientPanel7.Controls.Add(this.label15);
            this.gradientPanel7.Controls.Add(this.checkBoxAdv15);
            this.gradientPanel7.Controls.Add(this.checkBoxAdv16);
            this.gradientPanel7.ForeColor = System.Drawing.Color.Black;
            this.gradientPanel7.Location = new System.Drawing.Point(0, 44);
            this.gradientPanel7.Name = "gradientPanel7";
            this.gradientPanel7.Size = new System.Drawing.Size(256, 0);
            this.gradientPanel7.TabIndex = 191;
            // 
            // label16
            // 
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(9, 47);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(114, 20);
            this.label16.TabIndex = 156;
            this.label16.Text = "Visual Styles";
            // 
            // checkBoxAdv11
            // 
            this.checkBoxAdv11.BeforeTouchSize = new System.Drawing.Size(150, 21);
            this.checkBoxAdv11.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxAdv11.Location = new System.Drawing.Point(9, 171);
            this.checkBoxAdv11.MetroColor = System.Drawing.Color.Empty;
            this.checkBoxAdv11.Name = "checkBoxAdv11";
            this.checkBoxAdv11.Size = new System.Drawing.Size(162, 21);
            this.checkBoxAdv11.TabIndex = 154;
            this.checkBoxAdv11.Text = "ThemesEnabled";
            this.checkBoxAdv11.ThemesEnabled = true;
            this.checkBoxAdv11.CheckStateChanged += new System.EventHandler(this.checkBoxAdv11_CheckStateChanged);
            // 
            // comboBox10
            // 
            this.comboBox10.BackColor = System.Drawing.Color.White;
            this.comboBox10.BeforeTouchSize = new System.Drawing.Size(124, 21);
            this.comboBox10.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox10.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox10.Location = new System.Drawing.Point(129, 47);
            this.comboBox10.Name = "comboBox10";
            this.comboBox10.Size = new System.Drawing.Size(124, 21);
            this.comboBox10.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.comboBox10.TabIndex = 155;
            this.comboBox10.SelectedIndexChanged += new System.EventHandler(this.comboBox10_SelectedIndexChanged);
            // 
            // comboBox9
            // 
            this.comboBox9.BackColor = System.Drawing.Color.White;
            this.comboBox9.BeforeTouchSize = new System.Drawing.Size(105, 21);
            this.comboBox9.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox9.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox9.Items.AddRange(new object[] {
            "Blue",
            "Silver",
            "Black"});
            this.comboBox9.ItemsImageIndexes.Add(new Syncfusion.Windows.Forms.Tools.ComboBoxAdv.ImageIndexItem(this.comboBox9, "Blue"));
            this.comboBox9.ItemsImageIndexes.Add(new Syncfusion.Windows.Forms.Tools.ComboBoxAdv.ImageIndexItem(this.comboBox9, "Silver"));
            this.comboBox9.ItemsImageIndexes.Add(new Syncfusion.Windows.Forms.Tools.ComboBoxAdv.ImageIndexItem(this.comboBox9, "Black"));
            this.comboBox9.Location = new System.Drawing.Point(129, 96);
            this.comboBox9.Name = "comboBox9";
            this.comboBox9.Size = new System.Drawing.Size(105, 21);
            this.comboBox9.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.comboBox9.TabIndex = 157;
            this.comboBox9.Text = "Blue";
            this.comboBox9.SelectedIndexChanged += new System.EventHandler(this.comboBox9_SelectedIndexChanged);
            // 
            // label15
            // 
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(9, 96);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(96, 39);
            this.label15.TabIndex = 158;
            this.label15.Text = "Office2007 Color Scheme";
            this.label15.Enabled = false;
            // 
            // checkBoxAdv15
            // 
            this.checkBoxAdv15.BeforeTouchSize = new System.Drawing.Size(150, 21);
            this.checkBoxAdv15.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxAdv15.Location = new System.Drawing.Point(9, 205);
            this.checkBoxAdv15.MetroColor = System.Drawing.Color.Empty;
            this.checkBoxAdv15.Name = "checkBoxAdv15";
            this.checkBoxAdv15.Size = new System.Drawing.Size(202, 27);
            this.checkBoxAdv15.TabIndex = 171;
            this.checkBoxAdv15.Text = "LeftScrollButtonImage";
            this.checkBoxAdv15.ThemesEnabled = true;
            this.checkBoxAdv15.CheckStateChanged += new System.EventHandler(this.checkBoxAdv15_CheckStateChanged);
            // 
            // checkBoxAdv16
            // 
            this.checkBoxAdv16.BeforeTouchSize = new System.Drawing.Size(150, 21);
            this.checkBoxAdv16.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxAdv16.Location = new System.Drawing.Point(9, 238);
            this.checkBoxAdv16.MetroColor = System.Drawing.Color.Empty;
            this.checkBoxAdv16.Name = "checkBoxAdv16";
            this.checkBoxAdv16.Size = new System.Drawing.Size(204, 28);
            this.checkBoxAdv16.TabIndex = 172;
            this.checkBoxAdv16.Text = "RightScrollButtonImage";
            this.checkBoxAdv16.ThemesEnabled = true;
            this.checkBoxAdv16.CheckStateChanged += new System.EventHandler(this.checkBoxAdv16_CheckStateChanged);
            // 
            // gradientPanel6
            // 
            this.gradientPanel6.BackColor = System.Drawing.Color.White;
            this.gradientPanel6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(199)))), ((int)(((byte)(235)))));
            this.gradientPanel6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gradientPanel6.Controls.Add(this.label20);
            this.gradientPanel6.Controls.Add(this.checkBoxAdv14);
            this.gradientPanel6.Controls.Add(this.checkBoxAdv13);
            this.gradientPanel6.Controls.Add(this.checkBoxAdv10);
            this.gradientPanel6.Controls.Add(this.label22);
            this.gradientPanel6.Controls.Add(this.comboBox12);
            this.gradientPanel6.Controls.Add(this.comboBox11);
            this.gradientPanel6.ForeColor = System.Drawing.Color.Black;
            this.gradientPanel6.Location = new System.Drawing.Point(0, 22);
            this.gradientPanel6.Name = "gradientPanel6";
            this.gradientPanel6.Size = new System.Drawing.Size(256, 0);
            this.gradientPanel6.TabIndex = 189;
            // 
            // label20
            // 
            this.label20.BackColor = System.Drawing.Color.Transparent;
            this.label20.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.Black;
            this.label20.Location = new System.Drawing.Point(12, 33);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(124, 20);
            this.label20.TabIndex = 164;
            this.label20.Text = "Culture Settings";
            // 
            // checkBoxAdv14
            // 
            this.checkBoxAdv14.BeforeTouchSize = new System.Drawing.Size(150, 21);
            this.checkBoxAdv14.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxAdv14.ForeColor = System.Drawing.Color.Black;
            this.checkBoxAdv14.Location = new System.Drawing.Point(10, 217);
            this.checkBoxAdv14.MetroColor = System.Drawing.Color.Empty;
            this.checkBoxAdv14.Name = "checkBoxAdv14";
            this.checkBoxAdv14.Size = new System.Drawing.Size(217, 28);
            this.checkBoxAdv14.TabIndex = 149;
            this.checkBoxAdv14.Text = "MouseDragMultiSelect";
            this.checkBoxAdv14.ThemesEnabled = true;
            this.checkBoxAdv14.CheckStateChanged += new System.EventHandler(this.checkBoxAdv14_CheckStateChanged);
            // 
            // checkBoxAdv13
            // 
            this.checkBoxAdv13.BeforeTouchSize = new System.Drawing.Size(150, 21);
            this.checkBoxAdv13.Checked = true;
            this.checkBoxAdv13.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxAdv13.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxAdv13.ForeColor = System.Drawing.Color.Black;
            this.checkBoxAdv13.Location = new System.Drawing.Point(10, 183);
            this.checkBoxAdv13.MetroColor = System.Drawing.Color.Empty;
            this.checkBoxAdv13.Name = "checkBoxAdv13";
            this.checkBoxAdv13.Size = new System.Drawing.Size(242, 28);
            this.checkBoxAdv13.TabIndex = 150;
            this.checkBoxAdv13.Text = "Allow Multiple Selection";
            this.checkBoxAdv13.ThemesEnabled = true;
            this.checkBoxAdv13.CheckStateChanged += new System.EventHandler(this.checkBoxAdv13_CheckStateChanged);
            // 
            // checkBoxAdv10
            // 
            this.checkBoxAdv10.BeforeTouchSize = new System.Drawing.Size(150, 21);
            this.checkBoxAdv10.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxAdv10.ForeColor = System.Drawing.Color.Black;
            this.checkBoxAdv10.Location = new System.Drawing.Point(10, 149);
            this.checkBoxAdv10.MetroColor = System.Drawing.Color.Empty;
            this.checkBoxAdv10.Name = "checkBoxAdv10";
            this.checkBoxAdv10.Size = new System.Drawing.Size(199, 21);
            this.checkBoxAdv10.TabIndex = 161;
            this.checkBoxAdv10.Text = "ShowWeekNumbers";
            this.checkBoxAdv10.ThemesEnabled = true;
            this.checkBoxAdv10.CheckStateChanged += new System.EventHandler(this.checkBoxAdv10_CheckStateChanged);
            // 
            // label22
            // 
            this.label22.BackColor = System.Drawing.Color.Transparent;
            this.label22.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.Black;
            this.label22.Location = new System.Drawing.Point(8, 79);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(126, 20);
            this.label22.TabIndex = 166;
            this.label22.Text = "FirstDayOfWeek";
            // 
            // comboBox12
            // 
            this.comboBox12.BackColor = System.Drawing.Color.White;
            this.comboBox12.BeforeTouchSize = new System.Drawing.Size(93, 21);
            this.comboBox12.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox12.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox12.ForeColor = System.Drawing.Color.Black;
            this.comboBox12.Location = new System.Drawing.Point(152, 76);
            this.comboBox12.Name = "comboBox12";
            this.comboBox12.Size = new System.Drawing.Size(93, 21);
            this.comboBox12.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.comboBox12.TabIndex = 165;
            this.comboBox12.SelectedIndexChanged += new System.EventHandler(this.comboBox12_SelectedIndexChanged);
            // 
            // comboBox11
            // 
            this.comboBox11.BackColor = System.Drawing.Color.White;
            this.comboBox11.BeforeTouchSize = new System.Drawing.Size(93, 21);
            this.comboBox11.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox11.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox11.ForeColor = System.Drawing.Color.Black;
            this.comboBox11.Location = new System.Drawing.Point(152, 33);
            this.comboBox11.Name = "comboBox11";
            this.comboBox11.Size = new System.Drawing.Size(93, 21);
            this.comboBox11.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.comboBox11.TabIndex = 163;
            this.comboBox11.SelectedIndexChanged += new System.EventHandler(this.comboBox11_SelectedIndexChanged);
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.BackColor = System.Drawing.Color.White;
            this.gradientPanel1.BorderColor = System.Drawing.Color.Silver;
            this.gradientPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gradientPanel1.Controls.Add(this.label14);
            this.gradientPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gradientPanel1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gradientPanel1.Location = new System.Drawing.Point(20, 20);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(597, 80);
            this.gradientPanel1.TabIndex = 188;
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label14.Location = new System.Drawing.Point(0, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(595, 78);
            this.label14.TabIndex = 1;
            this.label14.Text = "MonthCalendarAdv is an advanced calendar control that can display a full month of" +
                " the year.";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBar1
            // 
            this.groupBar1.AllowDrop = true;
            this.groupBar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.groupBar1.BeforeTouchSize = new System.Drawing.Size(256, 388);
            this.groupBar1.BorderColor = System.Drawing.Color.White;
            this.groupBar1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.groupBar1.CollapseImage = ((System.Drawing.Image)(resources.GetObject("groupBar1.CollapseImage")));
            this.groupBar1.Controls.Add(this.gradientPanel8);
            this.groupBar1.Controls.Add(this.gradientPanel7);
            this.groupBar1.Controls.Add(this.gradientPanel6);
            this.groupBar1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBar1.ExpandButtonToolTip = null;
            this.groupBar1.ExpandImage = ((System.Drawing.Image)(resources.GetObject("groupBar1.ExpandImage")));
            this.groupBar1.FlatLook = true;
            this.groupBar1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBar1.ForeColor = System.Drawing.Color.White;
            this.groupBar1.GroupBarDropDownToolTip = null;
            this.groupBar1.GroupBarItems.AddRange(new Syncfusion.Windows.Forms.Tools.GroupBarItem[] {
            this.groupBarItem1,
            this.groupBarItem2,
            this.groupBarItem3});
            this.groupBar1.IndexOnVisibleItems = true;
            this.groupBar1.Location = new System.Drawing.Point(0, 0);
            this.groupBar1.MinimizeButtonToolTip = null;
            this.groupBar1.Name = "groupBar1";
            this.groupBar1.NavigationPaneTooltip = null;
            this.groupBar1.PopupClientSize = new System.Drawing.Size(0, 0);
            this.groupBar1.SelectedItem = 2;
            this.groupBar1.Size = new System.Drawing.Size(256, 388);
            this.groupBar1.Splittercolor = System.Drawing.SystemColors.ControlDark;
            this.groupBar1.TabIndex = 153;
            this.groupBar1.Text = "groupBar1";
            this.groupBar1.VisualStyle = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.groupBar1.GroupBarItemSelected += new System.EventHandler(this.groupBar1_GroupBarItemSelected);
            // 
            // groupBarItem1
            // 
            this.groupBarItem1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.groupBarItem1.Client = this.gradientPanel6;
            this.groupBarItem1.Text = "Behavior";
            // 
            // groupBarItem2
            // 
            this.groupBarItem2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.groupBarItem2.Client = this.gradientPanel7;
            this.groupBarItem2.Text = "Appearance";
            // 
            // groupBarItem3
            // 
            this.groupBarItem3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.groupBarItem3.Client = this.gradientPanel8;
            this.groupBarItem3.Text = "Color Settings";
            // 
            // splitContainerAdv1
            // 
            this.splitContainerAdv1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainerAdv1.BeforeTouchSize = 7;
            this.splitContainerAdv1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainerAdv1.IsSplitterFixed = true;
            this.splitContainerAdv1.Location = new System.Drawing.Point(23, 121);
            this.splitContainerAdv1.Name = "splitContainerAdv1";
            // 
            // splitContainerAdv1.Panel1
            // 
            this.splitContainerAdv1.Panel1.Controls.Add(this.groupBar1);
            // 
            // splitContainerAdv1.Panel2
            // 
            this.splitContainerAdv1.Panel2.Controls.Add(this.monthCalendarAdv2);
            this.splitContainerAdv1.Panel2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.splitContainerAdv1.Size = new System.Drawing.Size(591, 390);
            this.splitContainerAdv1.SplitterDistance = 258;
            this.splitContainerAdv1.TabIndex = 189;
            this.splitContainerAdv1.Text = "splitContainerAdv1";
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 15);
            this.BackColor = System.Drawing.Color.White;
            this.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.ClientSize = new System.Drawing.Size(637, 534);
            this.Controls.Add(this.splitContainerAdv1);
            this.Controls.Add(this.gradientPanel1);
            this.DropShadow = true;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(649, 566);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Month Calendar Demo";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.monthCalendarAdv2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel8)).EndInit();
            this.gradientPanel8.ResumeLayout(false);
            this.gradientPanel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonEdit2)).EndInit();
            this.buttonEdit2.ResumeLayout(false);
            this.buttonEdit2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonEdit4)).EndInit();
            this.buttonEdit4.ResumeLayout(false);
            this.buttonEdit4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonEdit1)).EndInit();
            this.buttonEdit1.ResumeLayout(false);
            this.buttonEdit1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonEdit6)).EndInit();
            this.buttonEdit6.ResumeLayout(false);
            this.buttonEdit6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonEdit3)).EndInit();
            this.buttonEdit3.ResumeLayout(false);
            this.buttonEdit3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonEdit5)).EndInit();
            this.buttonEdit5.ResumeLayout(false);
            this.buttonEdit5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxAdv12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel7)).EndInit();
            this.gradientPanel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxAdv11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxAdv15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxAdv16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel6)).EndInit();
            this.gradientPanel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxAdv14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxAdv13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxAdv10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBox12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel1)).EndInit();
            this.gradientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupBar1)).EndInit();
            this.groupBar1.ResumeLayout(false);
            this.splitContainerAdv1.Panel1.ResumeLayout(false);
            this.splitContainerAdv1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerAdv1)).EndInit();
            this.splitContainerAdv1.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		#endregion

        #region Main
        /// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
            SyncfusionLicenseProvider.RegisterLicense(DemoCommon.FindLicenseKey());
            Application.Run(new Form1());
        }
        #endregion

        #region FormLoad
        Image leftButtonImg;
        Image rightButtonImg;
        private void Form1_Load(object sender, EventArgs e)
        {
            Assembly assem = this.GetType().Assembly;
            Stream imgStr1 = assem.GetManifestResourceStream("CalendarControls.arrow_left_blue.png");
            Stream imgStr2 = assem.GetManifestResourceStream("CalendarControls.arrow_right_blue.png");
           leftButtonImg = Image.FromStream(imgStr1);
           rightButtonImg = Image.FromStream(imgStr2);

            // Load all Specific Cultures to the Combo Box
            foreach (CultureInfo info in CultureInfo.GetCultures(CultureTypes.SpecificCultures))
            {
                comboBox11.Items.Add(info.Name);
            }
           
            this.comboBox9.SelectedIndex = 0;
            this.comboBox11.SelectedText = "en-US";
           
          
            // Populate Combo Box with VisualStyle
            string[] str = Enum.GetNames(typeof(VisualStyle));
            comboBox10.Items.AddRange(str);
            comboBox10.SelectedIndex = 9;
            // Populate Week Days
            string[] str1 = Enum.GetNames(typeof(Day));
            comboBox12.Items.AddRange(str1);

            comboBox12.SelectedIndex = 0;
           
            #region DataBinding
            m_dataSetTbg = new DataSet();
            table = m_dataSetTbg.Tables.Add("tbgstrg");
            table.Columns.Add("Date", typeof(DateTime));
            table.Columns[0].AllowDBNull = true;
            table.Rows.Add(new object[] { DateTime.Now - TimeSpan.FromDays(60) });
            table.Rows.Add(new object[] { DateTime.Now });
            table.Rows.Add(new object[] { DBNull.Value });
#endregion
        }
        #endregion
        #region Visual Styles
        private void comboBox10_SelectedIndexChanged(object sender, EventArgs e)
        {
             switch (this.comboBox10.SelectedItem.ToString())
            {

                case "Default":
                    {
                        this.monthCalendarAdv2.Style = VisualStyle.Default;
                        this.comboBox9.Enabled = false;
                        this.label15.Enabled = false;
                        break;
                    }


                case "Office2016White":
                    {
                        this.monthCalendarAdv2.Style = VisualStyle.Office2016White;
                        this.comboBox9.Enabled = false;
                        this.label15.Enabled = false;
                        break;
                    }
                case "Office2016Colorful":
                    {
                        this.monthCalendarAdv2.Style = VisualStyle.Office2016Colorful;
                        this.comboBox9.Enabled = false;
                        this.label15.Enabled = false;
                        break;
                    }
                case "Office2016Black":
                    {
                        this.monthCalendarAdv2.Style = VisualStyle.Office2016Black;
                        this.comboBox9.Enabled = false;
                        this.label15.Enabled = false;
                        break;
                    }
                case "Office2016DarkGray":
                    {
                        this.monthCalendarAdv2.Style = VisualStyle.Office2016DarkGray;
                        this.comboBox9.Enabled = false;
                        this.label15.Enabled = false;
                        break;
                    }
                case "OfficeXP":
                    {
                         this.monthCalendarAdv2.Style = VisualStyle.OfficeXP;
                        this.comboBox9.Enabled = false;
                        this.label15.Enabled = false;
                        break;
                    }
               
                case "Office2003":
                    {    
                        this.monthCalendarAdv2.Style = VisualStyle.Office2003;
                        this.comboBox9.Enabled = false;
                        this.label15.Enabled = false;
                        break;
                    }
                case "VS2005":
                    {
                  this.monthCalendarAdv2.Style = VisualStyle.VS2005;
                        this.comboBox9.Enabled = false;
                        this.label15.Enabled = false;
                        break;
                    }
                case "Office2007":
                    {
                     this.monthCalendarAdv2.Style = VisualStyle.Office2007;
                        this.comboBox9.Enabled = true;
                        this.label15.Enabled = true;
                        break;
                    }
                case "Office2007Outlook":
                    {
                       this.monthCalendarAdv2.Style = VisualStyle.Office2007Outlook;
                       this.monthCalendarAdv2.TodayButton.BackColor = SystemColors.Control;
                       this.monthCalendarAdv2.NoneButton.BackColor = SystemColors.Control;
                        this.comboBox9.Enabled = false;
                        this.label15.Enabled = false;
                        break;
                    }
                case "Metro":
                    {
                        this.monthCalendarAdv2.Style = VisualStyle.Metro;
                        this.comboBox9.Enabled = false;
                        this.label15.Enabled = false;
                        break;
                    }
                case "VS2010":
                    {
                        this.monthCalendarAdv2.Style = VisualStyle.VS2010;
                        this.comboBox9.Enabled = false;
                        this.label15.Enabled = false;
                        break;
                    }
                case "Office2010":
                    {
                        this.monthCalendarAdv2.Style = VisualStyle.Office2010;
                        this.comboBox9.Enabled = true;
                        this.label15.Enabled = true;
                        break;
                    }
            }
        }
        #endregion

        #region Color Scheme
        private void comboBox9_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.comboBox9.SelectedItem.ToString() == "Blue")
            {
                this.monthCalendarAdv2.Office2007Theme = Office2007Theme.Blue;
                this.monthCalendarAdv2.Office2010Theme = Office2010Theme.Blue;

            }
            else if (this.comboBox9.SelectedItem.ToString() == "Silver")
            {
                this.monthCalendarAdv2.Office2007Theme = Office2007Theme.Silver;
                this.monthCalendarAdv2.Office2010Theme = Office2010Theme.Silver;

            }
            else
            {
                this.monthCalendarAdv2.Office2007Theme = Office2007Theme.Black;
                this.monthCalendarAdv2.Office2010Theme = Office2010Theme.Black;

            }
        }
        #endregion
               
        #region Themes
        private void checkBoxAdv11_CheckStateChanged(object sender, EventArgs e)
        {
            this.monthCalendarAdv2.ThemedBorder = checkBoxAdv11.Checked;
            this.monthCalendarAdv2.ThemedEnabledGrid = checkBoxAdv11.Checked;
            this.monthCalendarAdv2.ThemedEnabledScrollButtons = checkBoxAdv11.Checked;
        }


        #endregion

        #region Select option
        private void checkBoxAdv13_CheckStateChanged(object sender, EventArgs e)
        {
            this.monthCalendarAdv2.AllowMultipleSelection = this.checkBoxAdv13.Checked;
        }

        private void checkBoxAdv14_CheckStateChanged(object sender, EventArgs e)
        {
            this.monthCalendarAdv2.MouseDragMultiselect = this.checkBoxAdv14.Checked;
        }
        #endregion


        #region Culture settings
        private void comboBox11_SelectedIndexChanged(object sender, EventArgs e)
        {
            string culture = comboBox11.SelectedItem.ToString();            
            System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(culture);
            this.monthCalendarAdv2.Culture = new System.Globalization.CultureInfo(culture);

        }
        #endregion

        #region FirstDayOfWeek
        private void comboBox12_SelectedIndexChanged(object sender, EventArgs e)
        {
             switch (this.comboBox12.SelectedItem.ToString())
            {

                case "Default":
                    {
                        this.monthCalendarAdv2.FirstDayOfWeek = Day.Default;
                        
                        break;
                    }
                 case "Friday":
                    {
                        this.monthCalendarAdv2.FirstDayOfWeek = Day.Friday;
                        
                        break;
                    }
                 case "Monday":
                    {
                        this.monthCalendarAdv2.FirstDayOfWeek = Day.Monday;
                        
                        break;
                    }
                 case "Saturday":
                    {
                        this.monthCalendarAdv2.FirstDayOfWeek = Day.Saturday;
                        
                        break;
                    }
                 case "Sunday":
                    {
                        this.monthCalendarAdv2.FirstDayOfWeek = Day.Sunday;
                        
                        break;
                    }
                 case "Thursday":
                    {
                        this.monthCalendarAdv2.FirstDayOfWeek = Day.Thursday;
                        
                        break;
                    }
                 case "Tuesday":
                    {
                        this.monthCalendarAdv2.FirstDayOfWeek = Day.Tuesday;
                        
                        break;
                    }
                 case "Wednesday":
                    {
                        this.monthCalendarAdv2.FirstDayOfWeek = Day.Wednesday;
                        
                        break;
                    }
             }
        }
#endregion

        #region Show Week numbers
        private void checkBoxAdv10_CheckStateChanged(object sender, EventArgs e)
        {
            this.monthCalendarAdv2.ShowWeekNumbers = checkBoxAdv10.Checked;
        }
        #endregion

        #region LeftButton Image
        private void checkBoxAdv15_CheckStateChanged(object sender, EventArgs e)
        {
            if (this.checkBoxAdv15.Checked)
            {
               this.monthCalendarAdv2.LeftScrollButtonImage = leftButtonImg;
            }
            else
            {
                this.monthCalendarAdv2.LeftScrollButtonImage = null;
            }
        }
#endregion
        
        #region Rightutton Image
        private void checkBoxAdv16_CheckStateChanged(object sender, EventArgs e)
        {
            if (this.checkBoxAdv16.Checked)
            {
                this.monthCalendarAdv2.RightScrollButtonImage = rightButtonImg;
            }
            else
            {
                this.monthCalendarAdv2.RightScrollButtonImage  = null;
            }
        }
#endregion

        #region ColorSettings

        private void buttonEdit1_ButtonClicked(object sender, ButtonClickedEventArgs args)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                this.buttonEdit1.TextBox.BackColor = colorDialog1.Color;
                this.monthCalendarAdv2.DayNamesColor = colorDialog1.Color;
            }
            
        }
      

        private void buttonEdit2_ButtonClicked(object sender, ButtonClickedEventArgs args)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK && monthCalendarAdv2.Style != VisualStyle.Metro)
            {
                this.buttonEdit2.TextBox.BackColor = colorDialog1.Color;
                this.monthCalendarAdv2.BackColor = colorDialog1.Color;
            }
        }

        private void buttonEdit3_ButtonClicked(object sender, ButtonClickedEventArgs args)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                this.buttonEdit3.TextBox.BackColor = colorDialog1.Color;
                this.monthCalendarAdv2.DaysColor = colorDialog1.Color;
            }
        }

        private void buttonEdit4_ButtonClicked(object sender, ButtonClickedEventArgs args)
        {
            
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                this.buttonEdit4.TextBox.BackColor = colorDialog1.Color;
                this.monthCalendarAdv2.GridBackColor = colorDialog1.Color;
            }
        }

        private void checkBoxAdv12_CheckStateChanged(object sender, EventArgs e)
        {
            this.monthCalendarAdv2.HeaderVerticalGradient = this.checkBoxAdv12.Checked;
            this.monthCalendarAdv2.HeadGradient = this.checkBoxAdv12.Checked;
        }

        private void buttonEdit5_ButtonClicked(object sender, ButtonClickedEventArgs args)
        {
            
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                this.buttonEdit5.TextBox.BackColor = colorDialog1.Color;
                this.monthCalendarAdv2.HeaderEndColor = colorDialog1.Color;
            }
        }

        private void buttonEdit6_ButtonClicked(object sender, ButtonClickedEventArgs args)
        {
            
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                this.buttonEdit6.TextBox.BackColor = colorDialog1.Color;
                this.monthCalendarAdv2.HeaderStartColor = colorDialog1.Color;
            }
        }
        #endregion

        private void groupBar1_GroupBarItemSelected(object sender, EventArgs e)
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

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
using System.Diagnostics;
using System.Runtime.InteropServices;

using Syncfusion.Windows.Forms.Edit;
using Syncfusion.Windows.Forms.Edit.Dialogs;
using Syncfusion.Windows.Forms.Edit.Implementation.Config;
using Syncfusion.Windows.Forms.Edit.Interfaces;
using Syncfusion.Windows.Forms.Edit.Implementation.IO;
using Syncfusion.Windows.Forms.Edit.Implementation.Formatting;
using Syncfusion.Windows.Forms.Edit.Implementation.Parser;
using Syncfusion.IO;
using Syncfusion.Licensing;

using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Serialization;
using Syncfusion.Windows.Forms.Edit.Implementation;
using Syncfusion.Windows.Forms.Edit.Enums;
using Syncfusion.Windows.Forms;
using Syncfusion.Windows.Forms.Tools.XPMenus;
using Syncfusion.WinForms.Controls;

namespace SyntaxColoringDemo
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : SfForm
    {
        private Syncfusion.Windows.Forms.Edit.EditControl editControl1;
        private IContainer components = null;
        private Syncfusion.Windows.Forms.Tools.XPMenus.MainFrameBarManager mainFrameBarManager1;
        private Syncfusion.Windows.Forms.Tools.XPMenus.Bar bar1;
        private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem parentBarItem1;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem1;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem2;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem3;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem4;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem5;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem6;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem8;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem9;
        private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem parentBarItem2;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem10;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem11;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem12;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem13;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem14;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem15;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem16;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem17;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem18;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem19;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem20;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem21;
        private BarItem barItem7;
#if NETCORE
        private string BasePath = Path.GetDirectoryName(Application.ExecutablePath) + @"..\..\..\..\Test Files\";
#else
        private string BasePath = Path.GetDirectoryName(Application.ExecutablePath) + @"\..\..\Test Files\";
#endif

        public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
            try
            {
                System.Drawing.Icon ico = new System.Drawing.Icon(GetIconFile(GetIconFile(@"..\\..\\\logo.ico")));
                this.Icon = ico;
            }
            catch { }
            this.AutoScaleMode = AutoScaleMode.Font;
			this.editControl1.ShowOutliningCollapsers = true;           
			this.editControl1.LoadFile(BasePath + "\\CSharpSource.cs");
            Customization();

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
            Syncfusion.Windows.Forms.Edit.Implementation.Config.Config config1 = new Syncfusion.Windows.Forms.Edit.Implementation.Config.Config();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.editControl1 = new Syncfusion.Windows.Forms.Edit.EditControl();
            this.mainFrameBarManager1 = new Syncfusion.Windows.Forms.Tools.XPMenus.MainFrameBarManager(this);
            this.bar1 = new Syncfusion.Windows.Forms.Tools.XPMenus.Bar(this.mainFrameBarManager1, "Menu");
            this.parentBarItem1 = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.barItem1 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem2 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem3 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem4 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem5 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem6 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem8 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem9 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.parentBarItem2 = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.barItem10 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem11 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem12 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem13 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem14 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem15 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem16 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem17 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem18 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem19 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem20 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem21 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem7 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            ((System.ComponentModel.ISupportInitialize)(this.editControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainFrameBarManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // editControl1
            // 
            this.editControl1.BackColor = System.Drawing.SystemColors.Window;
            this.editControl1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.editControl1.CodeSnipptSize = new System.Drawing.Size(100, 100);
            this.editControl1.Configurator = config1;
            this.editControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.editControl1.IndicatorMarginBackColor = System.Drawing.Color.Empty;
            this.editControl1.LineNumbersFont = new System.Drawing.Font("Segoe UI", 8.25F);
            this.editControl1.Location = new System.Drawing.Point(10, 39);
            this.editControl1.Name = "editControl1";
            this.editControl1.RenderRightToLeft = false;
            this.editControl1.ScrollPosition = new System.Drawing.Point(0, 0);
            this.editControl1.ScrollVisualStyle = Syncfusion.Windows.Forms.ScrollBarCustomDrawStyles.Metro;
            this.editControl1.ShowHorizontalSplitters = false;
            this.editControl1.ShowIndicatorMargin = false;
            this.editControl1.ShowOutliningCollapsers = false;
            this.editControl1.ShowVerticalSplitters = false;
            this.editControl1.Size = new System.Drawing.Size(518, 374);

            this.editControl1.StatusBarSettings.TextPanel.AutoSize = false;
            this.editControl1.TabIndex = 0;
            this.editControl1.Text = "";
            this.editControl1.TransferFocusOnTab = true;
            this.editControl1.UseXPStyleBorder = true;
            this.editControl1.VisualColumn = 1;
            this.editControl1.MenuFill += new System.EventHandler(this.editControl1_MenuFill);
            // 
            // mainFrameBarManager1
            // 
#if !NETCORE
            this.mainFrameBarManager1.BarPositionInfo = ((System.IO.MemoryStream)(resources.GetObject("mainFrameBarManager1.BarPositionInfo")));
#endif
            this.mainFrameBarManager1.Bars.Add(this.bar1);
            this.mainFrameBarManager1.Categories.Add("File");
            this.mainFrameBarManager1.Categories.Add("Configuration");
            this.mainFrameBarManager1.Categories.Add("CodeSamples");
            this.mainFrameBarManager1.CurrentBaseFormType = "Syncfusion.Windows.Forms.MetroForm";
            this.mainFrameBarManager1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainFrameBarManager1.Form = this;
            this.mainFrameBarManager1.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.parentBarItem1,
            this.barItem1,
            this.barItem2,
            this.barItem3,
            this.barItem4,
            this.barItem5,
            this.barItem6,
            this.barItem8,
            this.barItem9,
            this.parentBarItem2,
            this.barItem10,
            this.barItem11,
            this.barItem12,
            this.barItem13,
            this.barItem14,
            this.barItem15,
            this.barItem16,
            this.barItem17,
            this.barItem18,
            this.barItem19,
            this.barItem20,
            this.barItem21,
            this.barItem7});
            this.mainFrameBarManager1.MetroColor = System.Drawing.Color.DeepSkyBlue;
            this.mainFrameBarManager1.ResetCustomization = false;
            this.mainFrameBarManager1.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            // 
            // bar1
            // 
            this.bar1.BarName = "Menu";
            this.bar1.Caption = "Menu";
            this.bar1.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.parentBarItem1,
            this.parentBarItem2});
            this.bar1.Manager = this.mainFrameBarManager1;
            // 
            // parentBarItem1
            // 
            this.parentBarItem1.BarName = "parentBarItem1";
            this.parentBarItem1.CategoryIndex = 0;
            this.parentBarItem1.ID = "&File";
            this.parentBarItem1.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.barItem1,
            this.barItem2,
            this.barItem3,
            this.barItem4,
            this.barItem5,
            this.barItem6});
            this.parentBarItem1.MetroColor = System.Drawing.Color.DeepSkyBlue;
            this.parentBarItem1.ShowToolTipInPopUp = false;
            this.parentBarItem1.SizeToFit = true;
            this.parentBarItem1.Text = "&File";
            // 
            // barItem1
            // 
            this.barItem1.BarName = "barItem1";
            this.barItem1.CategoryIndex = 0;
            this.barItem1.ID = "&New";
            this.barItem1.ShowToolTipInPopUp = false;
            this.barItem1.SizeToFit = true;
            this.barItem1.Text = "&New";
            this.barItem1.Click += new System.EventHandler(this.FileMenuClick);
            // 
            // barItem2
            // 
            this.barItem2.BarName = "barItem2";
            this.barItem2.CategoryIndex = 0;
            this.barItem2.ID = "&Open";
            this.barItem2.ShowToolTipInPopUp = false;
            this.barItem2.SizeToFit = true;
            this.barItem2.Text = "&Open";
            this.barItem2.Click += new System.EventHandler(this.FileMenuClick);
            // 
            // barItem3
            // 
            this.barItem3.BarName = "barItem3";
            this.barItem3.CategoryIndex = 0;
            this.barItem3.ID = "&Save";
            this.barItem3.ShowToolTipInPopUp = false;
            this.barItem3.SizeToFit = true;
            this.barItem3.Text = "&Save";
            this.barItem3.Click += new System.EventHandler(this.FileMenuClick);
            // 
            // barItem4
            // 
            this.barItem4.BarName = "barItem4";
            this.barItem4.CategoryIndex = 0;
            this.barItem4.ID = "Save&As";
            this.barItem4.ShowToolTipInPopUp = false;
            this.barItem4.SizeToFit = true;
            this.barItem4.Text = "Save&As";
            this.barItem4.Click += new System.EventHandler(this.FileMenuClick);
            // 
            // barItem5
            // 
            this.barItem5.BarName = "barItem5";
            this.barItem5.CategoryIndex = 0;
            this.barItem5.ID = "&Close";
            this.barItem5.ShowToolTipInPopUp = false;
            this.barItem5.SizeToFit = true;
            this.barItem5.Text = "&Close";
            this.barItem5.Click += new System.EventHandler(this.FileMenuClick);
            // 
            // barItem6
            // 
            this.barItem6.BarName = "barItem6";
            this.barItem6.CategoryIndex = 0;
            this.barItem6.ID = "&Exit";
            this.barItem6.ShowToolTipInPopUp = false;
            this.barItem6.SizeToFit = true;
            this.barItem6.Text = "&Exit";
            this.barItem6.Click += new System.EventHandler(this.FileMenuClick);
            // 
            // barItem8
            // 
            this.barItem8.BarName = "barItem8";
            this.barItem8.CategoryIndex = 1;
            this.barItem8.ID = "Launch Configuration Editor";
            this.barItem8.ShowToolTipInPopUp = false;
            this.barItem8.SizeToFit = true;
            this.barItem8.Visible = false;
            this.barItem8.Text = "Launch Configuration Editor";
            // 
            // barItem9
            // 
            this.barItem9.BarName = "barItem9";
            this.barItem9.CategoryIndex = 1;
            this.barItem9.ID = "Launch Configuration Display Utility";
            this.barItem9.ShowToolTipInPopUp = false;
            this.barItem9.SizeToFit = true;
            this.barItem9.Text = "Launch Configuration Display Utility";
            this.barItem9.Click += new System.EventHandler(this.ConfigurationMenuClick);
            // 
            // parentBarItem2
            // 
            this.parentBarItem2.BarName = "parentBarItem2";
            this.parentBarItem2.CategoryIndex = 2;
            this.parentBarItem2.ID = "Code &Samples";
            this.parentBarItem2.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.barItem7,
            this.barItem10,
            this.barItem11,
            this.barItem12,
            this.barItem13,
            this.barItem14,
            this.barItem15,
            this.barItem16,
            this.barItem17,
            this.barItem18,
            this.barItem19,
            this.barItem20,
            this.barItem21,
            });
            this.parentBarItem2.MetroColor = System.Drawing.Color.DeepSkyBlue;
            this.parentBarItem2.ShowToolTipInPopUp = false;
            this.parentBarItem2.SizeToFit = true;
            this.parentBarItem2.Text = "Code &Samples";
            // 
            // barItem10
            // 
            this.barItem10.BarName = "barItem10";
            this.barItem10.CategoryIndex = 2;
            this.barItem10.ID = "CSharp";
            this.barItem10.ShowToolTipInPopUp = false;
            this.barItem10.SizeToFit = true;
            this.barItem10.Text = "CSharp";
            this.barItem10.Click += new System.EventHandler(this.CodeSamplesMenuClick);
            this.barItem10.Checked = true;
            // 
            // barItem11
            // 
            this.barItem11.BarName = "barItem11";
            this.barItem11.CategoryIndex = 2;
            this.barItem11.ID = "HTML";
            this.barItem11.ShowToolTipInPopUp = false;
            this.barItem11.SizeToFit = true;
            this.barItem11.Text = "HTML";
            this.barItem11.Click += new System.EventHandler(this.CodeSamplesMenuClick);
            // 
            // barItem12
            // 
            this.barItem12.BarName = "barItem12";
            this.barItem12.CategoryIndex = 2;
            this.barItem12.ID = "XML";
            this.barItem12.ShowToolTipInPopUp = false;
            this.barItem12.SizeToFit = true;
            this.barItem12.Text = "XML";
            this.barItem12.Click += new System.EventHandler(this.CodeSamplesMenuClick);
            // 
            // barItem13
            // 
            this.barItem13.BarName = "barItem13";
            this.barItem13.CategoryIndex = 2;
            this.barItem13.ID = "Pascal";
            this.barItem13.ShowToolTipInPopUp = false;
            this.barItem13.SizeToFit = true;
            this.barItem13.Text = "Pascal";
            this.barItem13.Click += new System.EventHandler(this.CodeSamplesMenuClick);
            // 
            // barItem14
            // 
            this.barItem14.BarName = "barItem14";
            this.barItem14.CategoryIndex = 2;
            this.barItem14.ID = "HTML with embedded JScript";
            this.barItem14.ShowToolTipInPopUp = false;
            this.barItem14.SizeToFit = true;
            this.barItem14.Text = "HTML with embedded JScript";
            this.barItem14.Click += new System.EventHandler(this.CodeSamplesMenuClick);
            // 
            // barItem15
            // 
            this.barItem15.BarName = "barItem15";
            this.barItem15.CategoryIndex = 2;
            this.barItem15.ID = "HTML embedded with VBScript";
            this.barItem15.ShowToolTipInPopUp = false;
            this.barItem15.SizeToFit = true;
            this.barItem15.Text = "HTML embedded with VBScript";
            this.barItem15.Click += new System.EventHandler(this.CodeSamplesMenuClick);
            // 
            // barItem16
            // 
            this.barItem16.BarName = "barItem16";
            this.barItem16.CategoryIndex = 2;
            this.barItem16.ID = "Delphi";
            this.barItem16.ShowToolTipInPopUp = false;
            this.barItem16.SizeToFit = true;
            this.barItem16.Text = "Delphi";
            this.barItem16.Click += new System.EventHandler(this.CodeSamplesMenuClick);
            // 
            // barItem17
            // 
            this.barItem17.BarName = "barItem17";
            this.barItem17.CategoryIndex = 2;
            this.barItem17.ID = "VB.NET";
            this.barItem17.ShowToolTipInPopUp = false;
            this.barItem17.SizeToFit = true;
            this.barItem17.Text = "VB.NET";
            this.barItem17.Click += new System.EventHandler(this.CodeSamplesMenuClick);
            // 
            // barItem18
            // 
            this.barItem18.BarName = "barItem18";
            this.barItem18.CategoryIndex = 2;
            this.barItem18.ID = "SQL";
            this.barItem18.ShowToolTipInPopUp = false;
            this.barItem18.SizeToFit = true;
            this.barItem18.Text = "SQL";
            this.barItem18.Click += new System.EventHandler(this.CodeSamplesMenuClick);
            // 
            // barItem19
            // 
            this.barItem19.BarName = "barItem19";
            this.barItem19.CategoryIndex = 2;
            this.barItem19.ID = "Java";
            this.barItem19.ShowToolTipInPopUp = false;
            this.barItem19.SizeToFit = true;
            this.barItem19.Text = "Java";
            this.barItem19.Click += new System.EventHandler(this.CodeSamplesMenuClick);
            // 
            // barItem20
            // 
            this.barItem20.BarName = "barItem20";
            this.barItem20.CategoryIndex = 2;
            this.barItem20.ID = "VBScript";
            this.barItem20.ShowToolTipInPopUp = false;
            this.barItem20.SizeToFit = true;
            this.barItem20.Text = "VBScript";
            this.barItem20.Click += new System.EventHandler(this.CodeSamplesMenuClick);
            // 
            // barItem21
            // 
            this.barItem21.BarName = "barItem21";
            this.barItem21.CategoryIndex = 2;
            this.barItem21.ID = "JScript";
            this.barItem21.ShowToolTipInPopUp = false;
            this.barItem21.SizeToFit = true;
            this.barItem21.Text = "JScript";
            this.barItem21.Click += new System.EventHandler(this.CodeSamplesMenuClick);
            // 
            // barItem7
            // 
            this.barItem7.BarName = "barItem7";
            this.barItem7.CategoryIndex = 2;
            this.barItem7.ID = "PowerShell";
            this.barItem7.ShowToolTipInPopUp = false;
            this.barItem7.SizeToFit = true;
            this.barItem7.Text = "PowerShell";
            this.barItem7.Click += new System.EventHandler(this.CodeSamplesMenuClick);
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 15);
            this.ClientSize = new System.Drawing.Size(538, 423);
            this.Controls.Add(this.editControl1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(550, 460);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Syntax Coloring";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.editControl1)).EndInit();
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
Application.EnableVisualStyles();
			Application.Run(new Form1());
		}

		private void CodeSamplesMenuClick(object sender, System.EventArgs e)
		{
            this.barItem10.Checked = false;
            this.barItem11.Checked = false;
            this.barItem12.Checked = false;
            this.barItem13.Checked = false;
            this.barItem14.Checked = false;
            this.barItem15.Checked = false;
            this.barItem16.Checked = false;
            this.barItem17.Checked = false;
            this.barItem18.Checked = false;
            this.barItem19.Checked = false;
            this.barItem20.Checked = false;
            this.barItem21.Checked = false;
            this.barItem7.Checked = false;
            BarItem mi = sender as BarItem;
            mi.Checked = true;
            this.editControl1.ShowCollapse = true;
			switch (mi.Text)
			{
				case "CSharp" :
					this.editControl1.LoadFile(BasePath + "\\CSharpSource.cs");
					break;
				case "HTML" :
					this.editControl1.LoadFile(BasePath + "\\HTMLSource.html");
					break;
				case "XML" :
					this.editControl1.LoadFile(BasePath + "\\XMLSource.xml");
					break;
				case "Pascal" :
                    this.editControl1.LoadFile(BasePath + "\\PascalSource.pas");
					break;
				case "HTML with embedded JScript" :
					this.editControl1.LoadFile(BasePath + "\\HTML_JScript.html");
					break;
				case "Delphi" :
					this.editControl1.LoadFile(BasePath + "\\DelphiSource.pas");
					break;
				case "VB.NET" :
					this.editControl1.LoadFile(BasePath + "\\VBSource.vb");
					break;
				case "SQL" :
					this.editControl1.LoadFile(BasePath + "\\SQLSource.sql");
					break;
				case "HTML with embedded VBScript" :
					this.editControl1.LoadFile(BasePath + "\\HTML_VBScript.html");
					break;
				case "Java" :
					this.editControl1.LoadFile(BasePath + "\\JavaSource.Java");
					break;
				case "VBScript" :
					this.editControl1.LoadFile(BasePath + "\\VBScriptSource.vbs");
					this.editControl1.ApplyConfiguration(KnownLanguages.VBScript);
					break;
				case "JScript" :
					this.editControl1.LoadFile(BasePath + "\\JScriptSource.js");
					this.editControl1.ApplyConfiguration(KnownLanguages.JScript);
					break;
                case "PowerShell":
                    //this.editControl1 = false;
                    this.editControl1.LoadFile(BasePath + "\\Powershell.ps1");
                    this.editControl1.ApplyConfiguration(KnownLanguages.PowerShell);
                    break;
			}
		}

        #region Customization
        public void Customization()
        {
            this.mainFrameBarManager1.Style = VisualStyle.Office2016White;
            this.editControl1.Style = Syncfusion.Windows.Forms.Edit.EditControlStyle.Office2016White;
            this.Padding = new System.Windows.Forms.Padding(0);
        }
        #endregion

        private void ConfigurationMenuClick(object sender, System.EventArgs e)
		{
			BarItem mi = sender as BarItem;

			Form2 configForm = new Form2();
			configForm.ShowDialog();
		}

		private void FileMenuClick(object sender, System.EventArgs e)
		{
            BarItem mi = sender as BarItem;

			switch (mi.Text)
			{
				case "&New" :
					this.editControl1.NewFile();
					break;
				case "&Open" :
					this.editControl1.LoadFile();
					break;
				case "&Save" :
					this.editControl1.Save();
					break;
				case "Save&As" :
					this.editControl1.SaveAs();
					break;
				case "&Close" :
					this.editControl1.Close();
					break;
				case "&Exit" :
					this.Close();
					break;
			}
		}

		private void editControl1_MenuFill(object sender, System.EventArgs e)
		{
			ContextMenuManager contextMenu = (ContextMenuManager) sender;
                        
			// Add a separator
			contextMenu.AddSeparator();

			// Add custom custom context menu items and their Click eventhandlers
			contextMenu.AddMenuItem("Launch Configuration Editor", new EventHandler(ConfigurationEditorLaunch));
			contextMenu.AddMenuItem("Launch Configuration Display Utility", new EventHandler(ConfigurationDisplayLaunch));
		}

		private void ConfigurationEditorLaunch (object sender, System.EventArgs e)
        {

        }

		private void ConfigurationDisplayLaunch (object sender, System.EventArgs e)
		{
			Form2 configForm = new Form2();
			configForm.ShowDialog();
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

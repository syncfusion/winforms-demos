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
using System.IO;
using System.Reflection;

using Syncfusion.Windows.Forms.HTMLUI;
using Syncfusion.Windows.Forms.Edit;
using Syncfusion.Windows.Forms.Tools;
using Syncfusion.Licensing;

namespace Syncfusion.Windows.Forms.HTMLUI.Samples
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : MetroForm
	{
		Assembly _assembly;
		Stream _htmlStream;

		static private int [,] GameEndIndexes = new int[,]
		{
			{0,1,2},
			{3,4,5},
			{6,7,8},
			{0,3,6},
			{1,4,7},
			{2,5,8},
			{0,4,8},
			{2,4,6}
		};

		Hashtable htmlelements = new Hashtable();
		BaseElement ttt1;
		BaseElement ttt2;
		BaseElement ttt3;
		BaseElement ttt4;
		BaseElement ttt5;
		BaseElement ttt6;
		BaseElement ttt7;
		BaseElement ttt8;
		BaseElement ttt9;
		private BaseElement [] _elementArray; 


		private bool gameOver = false;

        private Syncfusion.Windows.Forms.HTMLUI.HTMLUIControl htmluiControl1;
		private System.Windows.Forms.ImageList imageList1;
        private Tools.XPMenus.MainFrameBarManager mainFrameBarManager1;
        private Tools.XPMenus.Bar bar1;
        private Tools.XPMenus.ParentBarItem parentBarItem1;
        private Tools.XPMenus.BarItem barItem1;
        private Tools.XPMenus.BarItem barItem2;
        private Tools.XPMenus.ParentBarItem parentBarItem2;
        private Tools.XPMenus.BarItem barItem3;
        private Tools.GradientPanel gradientPanel1;
		private System.ComponentModel.IContainer components;
        private EditControl editControl1;
      
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

        #region Function
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
        #endregion
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

        //Get and Load the images
#if NET9_0_OR_GREATER
        private static Image GetImage(string path)
        {
            System.Reflection.Assembly asm = System.Reflection.Assembly.GetExecutingAssembly();
            if (asm != null && !string.IsNullOrEmpty(path))
                return Image.FromStream(asm.GetManifestResourceStream(path));
            return null;
        }
#endif

        #region Windows Form Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.htmluiControl1 = new Syncfusion.Windows.Forms.HTMLUI.HTMLUIControl();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.mainFrameBarManager1 = new Syncfusion.Windows.Forms.Tools.XPMenus.MainFrameBarManager(this);
            this.bar1 = new Syncfusion.Windows.Forms.Tools.XPMenus.Bar(this.mainFrameBarManager1, "HTMLUITicTac");
            this.parentBarItem1 = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.barItem1 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem2 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.parentBarItem2 = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.barItem3 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.gradientPanel1 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            ((System.ComponentModel.ISupportInitialize)(this.htmluiControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainFrameBarManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel1)).BeginInit();
            this.gradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // htmluiControl1
            // 
            this.htmluiControl1.AutoScroll = true;
            this.htmluiControl1.AutoScrollMinSize = new System.Drawing.Size(602, 365);
            this.htmluiControl1.BackColor = System.Drawing.Color.White;
            this.htmluiControl1.DefaultFormat.BackgroundColor = System.Drawing.SystemColors.Control;
            this.htmluiControl1.DefaultFormat.ForeColor = System.Drawing.SystemColors.ControlText;
            this.htmluiControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.htmluiControl1.Location = new System.Drawing.Point(0, 0);
            this.htmluiControl1.Name = "htmluiControl1";
            this.htmluiControl1.ShowTitle = false;
            this.htmluiControl1.Size = new System.Drawing.Size(619, 380);
            this.htmluiControl1.TabIndex = 0;
            this.htmluiControl1.Text = resources.GetString("htmluiControl1.Text");
            this.htmluiControl1.LoadFinished += new System.EventHandler(this.htmluiControl1_LoadFinished);
            // 
            // imageList1
            // 
#if NET9_0_OR_GREATER
            this.imageList1.Images.Add(GetImage("Syncfusion.Windows.Forms.HTMLUI.Samples.Images.ImageList1.Image_1.png"));
            this.imageList1.Images.Add(GetImage("Syncfusion.Windows.Forms.HTMLUI.Samples.Images.ImageList1.Image_2.png"));
#else
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
#endif
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "");
            this.imageList1.Images.SetKeyName(1, "");
            // 
            // mainFrameBarManager1
            // 
#if !NETCORE
            this.mainFrameBarManager1.BarPositionInfo = ((System.IO.MemoryStream)(resources.GetObject("mainFrameBarManager1.BarPositionInfo")));
#endif
            this.mainFrameBarManager1.Bars.Add(this.bar1);
            this.mainFrameBarManager1.Categories.Add("Game");
            this.mainFrameBarManager1.Categories.Add("View");
            this.mainFrameBarManager1.CurrentBaseFormType = "Syncfusion.Windows.Forms.MetroForm";
            this.mainFrameBarManager1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainFrameBarManager1.Form = this;
            this.mainFrameBarManager1.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.parentBarItem1,
            this.barItem1,
            this.barItem2,
            this.parentBarItem2,
            this.barItem3});
            this.mainFrameBarManager1.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(110)))), ((int)(((byte)(218)))));
            this.mainFrameBarManager1.ResetCustomization = false;
            this.mainFrameBarManager1.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            // 
            // bar1
            // 
            this.bar1.BarName = "HTMLUITicTac";
            this.bar1.Caption = "HTMLUITicTac";
            this.bar1.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.parentBarItem1,
            this.parentBarItem2});
            this.bar1.Manager = this.mainFrameBarManager1;
            // 
            // parentBarItem1
            // 
            this.parentBarItem1.BarName = "parentBarItem1";
            this.parentBarItem1.CategoryIndex = 0;
            this.parentBarItem1.ID = "Game";
            this.parentBarItem1.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.barItem1,
            this.barItem2});
            this.parentBarItem1.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(110)))), ((int)(((byte)(218)))));
            this.parentBarItem1.ShowToolTipInPopUp = false;
            this.parentBarItem1.SizeToFit = true;
            this.parentBarItem1.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.parentBarItem1.Text = "Game";
            // 
            // barItem1
            // 
            this.barItem1.BarName = "barItem1";
            this.barItem1.CategoryIndex = 0;
            this.barItem1.ID = "Reset";
            this.barItem1.ShowToolTipInPopUp = false;
            this.barItem1.SizeToFit = true;
            this.barItem1.Text = "Reset";
            this.barItem1.Click += new System.EventHandler(this.menuItem2_Click);
            // 
            // barItem2
            // 
            this.barItem2.BarName = "barItem2";
            this.barItem2.CategoryIndex = 0;
            this.barItem2.ID = "Exit";
            this.barItem2.ShowToolTipInPopUp = false;
            this.barItem2.SizeToFit = true;
            this.barItem2.Text = "Exit";
            this.barItem2.Click += new System.EventHandler(this.menuItem3_Click);
            // 
            // parentBarItem2
            // 
            this.parentBarItem2.BarName = "parentBarItem2";
            this.parentBarItem2.CategoryIndex = 1;
            this.parentBarItem2.ID = "View";
            this.parentBarItem2.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.barItem3});
            this.parentBarItem2.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(110)))), ((int)(((byte)(218)))));
            this.parentBarItem2.ShowToolTipInPopUp = false;
            this.parentBarItem2.SizeToFit = true;
            this.parentBarItem2.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.parentBarItem2.Text = "View";
            // 
            // barItem3
            // 
            this.barItem3.BarName = "barItem3";
            this.barItem3.CategoryIndex = 1;
            this.barItem3.ID = "HTML";
            this.barItem3.ShowToolTipInPopUp = false;
            this.barItem3.SizeToFit = true;
            this.barItem3.Text = "HTML";
            this.barItem3.Click += new System.EventHandler(this.menuItem5_Click);
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gradientPanel1.Controls.Add(this.htmluiControl1);
            this.gradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gradientPanel1.Location = new System.Drawing.Point(10, 39);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(621, 382);
            this.gradientPanel1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.ClientSize = new System.Drawing.Size(641, 431);
            this.Controls.Add(this.gradientPanel1);
            this.DropShadow = true;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IconAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.IconTextRelation = System.Windows.Forms.LeftRightAlignment.Left;
            this.MetroColor = System.Drawing.Color.White;
            this.MinimumSize = new System.Drawing.Size(653, 467);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tic Tac Toe";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.htmluiControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainFrameBarManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel1)).EndInit();
            this.gradientPanel1.ResumeLayout(false);
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
			LoadHTMLResource();			
		}

		#region LOADUI
		private bool LoadHTMLResource()
		{
			bool success = false;

			try
			{
				_assembly = Assembly.GetExecutingAssembly();
				_htmlStream = (Stream)_assembly.GetManifestResourceStream("Syncfusion.Windows.Forms.HTMLUI.Samples.dialog.htm");
				if(_htmlStream != null)
				{
					this.htmluiControl1.LoadHTML(_htmlStream);
					success = true;
				}
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			return success;
		}
		#endregion

		#region UI_EVENTS
		private void htmluiControl1_LoadFinished(object sender, System.EventArgs e)
		{
			WireElements();
		}

		private void WireElements()
		{
			try
			{
				htmlelements = this.htmluiControl1.Document.GetElementsByUserIdHash();

				this.ttt1 = htmlelements["ttt1"] as BaseElement;
				this.ttt2 = htmlelements["ttt2"] as BaseElement;
				this.ttt3 = htmlelements["ttt3"] as BaseElement;
				this.ttt4 = htmlelements["ttt4"] as BaseElement;
				this.ttt5 = htmlelements["ttt5"] as BaseElement;
				this.ttt6 = htmlelements["ttt6"] as BaseElement;
				this.ttt7 = htmlelements["ttt7"] as BaseElement;
				this.ttt8 = htmlelements["ttt8"] as BaseElement;
				this.ttt9 = htmlelements["ttt9"] as BaseElement;

				this.ttt1.Click += new EventHandler( ttt1_Click );
				this.ttt2.Click += new EventHandler( ttt2_Click );
				this.ttt3.Click += new EventHandler( ttt3_Click );
				this.ttt4.Click += new EventHandler( ttt4_Click );
				this.ttt5.Click += new EventHandler( ttt5_Click );
				this.ttt6.Click += new EventHandler( ttt6_Click );
				this.ttt7.Click += new EventHandler( ttt7_Click );
				this.ttt8.Click += new EventHandler( ttt8_Click );
				this.ttt9.Click += new EventHandler( ttt9_Click );

				_elementArray = new BaseElement[9] {ttt1, ttt2,ttt3, ttt4, ttt5, ttt6, ttt7, ttt8, ttt9};

			}
			catch(Exception ex)
			{
				Console.WriteLine(ex.ToString());
			}
		}

		private void ttt1_Click( object sender, EventArgs e )
		{
			HandleElementClick(this.ttt1);

		}

		private void ttt2_Click( object sender, EventArgs e )
		{
			HandleElementClick(this.ttt2);

		}

		private void ttt3_Click( object sender, EventArgs e )
		{
			HandleElementClick(this.ttt3);

		}

		private void ttt4_Click( object sender, EventArgs e )
		{
			HandleElementClick(this.ttt4);

		}

		private void ttt5_Click( object sender, EventArgs e )
		{
			HandleElementClick(this.ttt5);

		}

		private void ttt6_Click( object sender, EventArgs e )
		{
			HandleElementClick(this.ttt6);

		}

		private void ttt7_Click( object sender, EventArgs e )
		{
			HandleElementClick(this.ttt7);
		}

		private void ttt8_Click( object sender, EventArgs e )
		{
			HandleElementClick(this.ttt8);
		}

		private void ttt9_Click( object sender, EventArgs e )
		{
			HandleElementClick(this.ttt9);
		}

		#endregion

		#region TIC_TAC_TOE

		bool lastWasX = false;
		private string GetXorO()
		{
			string ret = "X";
			if(lastWasX == true)
				ret = "O";
			lastWasX = !lastWasX;
			return ret;
		}

		private void HandleElementClick(BaseElement target)
		{
			if(target.InnerHTML == "" && this.gameOver == false)
			{
				target.InnerHTML = this.GetXorO();
			}
			this.ApplyGameRules();

		}

		private void ResetGame()
		{
			for(int i =0; i < 9; i++)
			{
				this._elementArray[i].InnerHTML ="";
				this._elementArray[i].Attributes["class"].Value = "tttDisplay";
			}

			this.lastWasX = false;
			this.gameOver = false;
		}

		public bool ApplyGameRules()
		{
			int gameEndCombinations = GameEndIndexes.Length/3;
			for(int i = 0; i < gameEndCombinations; i++)
			{
				BaseElement element1 = _elementArray[GameEndIndexes[i,0]];
				BaseElement element2 = _elementArray[GameEndIndexes[i,1]];
				BaseElement element3 = _elementArray[GameEndIndexes[i,2]];

				if(element1.InnerHTML != "" && element2.InnerHTML != "" && element3.InnerHTML != "" )
				{
					if(element1.InnerHTML == element2.InnerHTML && element1.InnerHTML == element3.InnerHTML )
					{
						element1.Attributes["class"].Value = "tttWinDisplay";
						element2.Attributes["class"].Value = "tttWinDisplay";
						element3.Attributes["class"].Value = "tttWinDisplay";
						gameOver = true;
						break;
					}
				}
			}  
			return false;
		}

		#endregion

		#region MENU_HANDLING

		private void menuItem2_Click(object sender, System.EventArgs e)
		{
			this.ResetGame();
		}

		private void menuItem5_Click(object sender, System.EventArgs e)
		{
            Form form1 = new MetroForm();
            form1.Text = "HTML code";
            form1.ShowIcon = false;
            form1.StartPosition = FormStartPosition.CenterScreen;
            this.editControl1 = new EditControl();
            editControl1.ScrollVisualStyle = ScrollBarCustomDrawStyles.Metro;
            this.editControl1.Dock = DockStyle.Fill;
            this.editControl1.ShowLineNumbers = false;
            this.editControl1.ShowOutliningCollapsers = false;
            this.editControl1.SaveOnClose = false;
            this.editControl1.ReadOnly = true;
            this.editControl1.ShowVerticalSplitters = false;
            this.editControl1.ShowHorizontalSplitters = false;
            this.editControl1.ShowIndicatorMargin = false;
            editControl1.ApplyConfiguration(Edit.Enums.KnownLanguages.HTML);
            form1.Controls.Add(editControl1);          
            form1.Size = new System.Drawing.Size(600, 500);
            this.editControl1.Text = this.htmluiControl1.Text;
            form1.ShowDialog();            
		}

		private void menuItem3_Click(object sender, System.EventArgs e)
		{
			Application.Exit();
		}
		#endregion
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

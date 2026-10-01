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
using System.IO;
using System.Text;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace Syncfusion.Windows.Forms.HTMLUI.Samples
{
	/// <summary>
	/// Summary description for Form2.
	/// </summary>
	public class editForm : MetroForm
	{
		private System.Windows.Forms.RichTextBox richTextBox1;
        string text = "";
        private IContainer components;
		private System.Windows.Forms.Panel panel1;
        private ButtonAdv button1;
		private System.Windows.Forms.OpenFileDialog opnFileDlg;
        private Tools.XPMenus.MainFrameBarManager mainFrameBarManager1;
        private Tools.XPMenus.Bar bar1;
        private Tools.XPMenus.ParentBarItem parentBarItem2;
        private Tools.XPMenus.BarItem barItem1;
        private Tools.XPMenus.BarItem barItem2;
        private Tools.XPMenus.ParentBarItem parentBarItem1;
        private Tools.XPMenus.BarItem barItem3;
        private Tools.XPMenus.BarItem barItem4;
        private ScrollersFrame scrollersFrame1;
        private ButtonAdv button2;

		#region Properties
		public string newHtml
		{
			get
			{
				return richTextBox1.Text;
			}
		}
		#endregion

		public editForm(string text)
		{
			//
			// Required for Windows Form Designer support
			//
			this.text = text;
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
				if(components != null)
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
            Syncfusion.Windows.Forms.MetroColorTable metroColorTable1 = new Syncfusion.Windows.Forms.MetroColorTable();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(editForm));
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.button2 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.opnFileDlg = new System.Windows.Forms.OpenFileDialog();
            this.mainFrameBarManager1 = new Syncfusion.Windows.Forms.Tools.XPMenus.MainFrameBarManager(this);
            this.bar1 = new Syncfusion.Windows.Forms.Tools.XPMenus.Bar(this.mainFrameBarManager1, "HTMLUIEditor");
            this.parentBarItem2 = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.barItem1 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem2 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.parentBarItem1 = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.barItem4 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem3 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.scrollersFrame1 = new Syncfusion.Windows.Forms.ScrollersFrame(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainFrameBarManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(5, 43);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(376, 223);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(10, 273);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(368, 48);
            this.panel1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218)))));
            this.button1.BeforeTouchSize = new System.Drawing.Size(64, 24);
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.IsBackStageButton = false;
            this.button1.Location = new System.Drawing.Point(64, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(64, 24);
            this.button1.TabIndex = 0;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218)))));
            this.button2.BeforeTouchSize = new System.Drawing.Size(64, 24);
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.IsBackStageButton = false;
            this.button2.Location = new System.Drawing.Point(216, 8);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(64, 24);
            this.button2.TabIndex = 1;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // mainFrameBarManager1
            // 
#if !NETCORE
            this.mainFrameBarManager1.BarPositionInfo = ((System.IO.MemoryStream)(resources.GetObject("mainFrameBarManager1.BarPositionInfo")));
#endif
            this.mainFrameBarManager1.Bars.Add(this.bar1);
            this.mainFrameBarManager1.Categories.Add("File");
            this.mainFrameBarManager1.Categories.Add("Edit");
            this.mainFrameBarManager1.CurrentBaseFormType = "Syncfusion.Windows.Forms.MetroForm";
            this.mainFrameBarManager1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainFrameBarManager1.Form = this;
            this.mainFrameBarManager1.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.parentBarItem2,
            this.barItem1,
            this.barItem2,
            this.parentBarItem1,
            this.barItem3,
            this.barItem4});
            this.mainFrameBarManager1.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(110)))), ((int)(((byte)(218)))));
            this.mainFrameBarManager1.ResetCustomization = false;
            this.mainFrameBarManager1.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            // 
            // bar1
            // 
            this.bar1.BarName = "HTMLUIEditor";
            this.bar1.Caption = "HTMLUIEditor";
            this.bar1.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.parentBarItem2,
            this.parentBarItem1});
            this.bar1.Manager = this.mainFrameBarManager1;
            // 
            // parentBarItem2
            // 
            this.parentBarItem2.BarName = "parentBarItem2";
            this.parentBarItem2.CategoryIndex = 0;
            this.parentBarItem2.ID = "File";
            this.parentBarItem2.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.barItem1,
            this.barItem2});
            this.parentBarItem2.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(110)))), ((int)(((byte)(218)))));
            this.parentBarItem2.ShowToolTipInPopUp = false;
            this.parentBarItem2.SizeToFit = true;
            this.parentBarItem2.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.parentBarItem2.Text = "File";
            this.parentBarItem2.WrapLength = 20;
            // 
            // barItem1
            // 
            this.barItem1.BarName = "barItem1";
            this.barItem1.CategoryIndex = 0;
            this.barItem1.ID = "Open New File";
            this.barItem1.ShowToolTipInPopUp = false;
            this.barItem1.SizeToFit = true;
            this.barItem1.Text = "Open New File";
            this.barItem1.Click += new System.EventHandler(this.menuItem2_Click);
            // 
            // barItem2
            // 
            this.barItem2.BarName = "barItem2";
            this.barItem2.CategoryIndex = 0;
            this.barItem2.ID = "Exit Edit Form";
            this.barItem2.ShowToolTipInPopUp = false;
            this.barItem2.SizeToFit = true;
            this.barItem2.Text = "Exit Edit Form";
            this.barItem2.Click += new System.EventHandler(this.menuItem3_Click);
            // 
            // parentBarItem1
            // 
            this.parentBarItem1.BarName = "parentBarItem1";
            this.parentBarItem1.CategoryIndex = 1;
            this.parentBarItem1.ID = "Edit";
            this.parentBarItem1.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.barItem4,
            this.barItem3});
            this.parentBarItem1.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(110)))), ((int)(((byte)(218)))));
            this.parentBarItem1.ShowToolTipInPopUp = false;
            this.parentBarItem1.SizeToFit = true;
            this.parentBarItem1.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.parentBarItem1.Text = "Edit";
            this.parentBarItem1.WrapLength = 20;
            // 
            // barItem4
            // 
            this.barItem4.BarName = "barItem4";
            this.barItem4.CategoryIndex = 1;
            this.barItem4.ID = "Select All";
            this.barItem4.ShowToolTipInPopUp = false;
            this.barItem4.SizeToFit = true;
            this.barItem4.Text = "Select All";
            this.barItem4.Click += new System.EventHandler(this.menuItem5_Click);
            // 
            // barItem3
            // 
            this.barItem3.BarName = "barItem3";
            this.barItem3.CategoryIndex = 1;
            this.barItem3.ID = "Clear All";
            this.barItem3.ShowToolTipInPopUp = false;
            this.barItem3.SizeToFit = true;
            this.barItem3.Text = "Clear All";
            this.barItem3.Click += new System.EventHandler(this.menuItem6_Click);
            // 
            // scrollersFrame1
            // 
            this.scrollersFrame1.AttachedTo = this.richTextBox1;
            this.scrollersFrame1.CustomRender = null;
            this.scrollersFrame1.MetroColorScheme = Syncfusion.Windows.Forms.MetroColorScheme.Managed;
            metroColorTable1.ArrowChecked = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(149)))), ((int)(((byte)(152)))));
            metroColorTable1.ArrowNormal = System.Drawing.Color.White;
            metroColorTable1.ArrowNormal = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(198)))), ((int)(((byte)(198)))));
            metroColorTable1.ArrowPushed = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(89)))), ((int)(((byte)(90)))));
            metroColorTable1.ScrollerBackground = System.Drawing.Color.White;
            metroColorTable1.ThumbChecked = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(149)))), ((int)(((byte)(152)))));
            metroColorTable1.ThumbNormal = System.Drawing.Color.White;
            metroColorTable1.ThumbNormal = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(198)))), ((int)(((byte)(198)))));
            metroColorTable1.ThumbPushed = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(89)))), ((int)(((byte)(90)))));
            this.scrollersFrame1.ScrollMetroColorTable = metroColorTable1;
            this.scrollersFrame1.SizeGripperVisibility = Syncfusion.Windows.Forms.SizeGripperVisibility.Auto;
            this.scrollersFrame1.VisualStyle = Syncfusion.Windows.Forms.ScrollBarCustomDrawStyles.Metro;
            // 
            // editForm
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.ClientSize = new System.Drawing.Size(388, 331);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.richTextBox1);
            this.DropShadow = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.Name = "editForm";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editor";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mainFrameBarManager1)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

		#region ClassEvents
		private void Form2_Load(object sender, System.EventArgs e)
		{
			this.AddTextToTxtBox(text);
		}

		private void menuItem3_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void menuItem6_Click(object sender, System.EventArgs e)
		{
			ClearText();
		}

		private void menuItem5_Click(object sender, System.EventArgs e)
		{
			SelectAllText();
		}

		private void menuItem2_Click(object sender, System.EventArgs e)
		{
			this.opnFileDlg.InitialDirectory = @"C:\";
			this.opnFileDlg.Filter = "htm files|*.htm|html files|*.html|Text files|*.txt";
			if(this.opnFileDlg.ShowDialog() == DialogResult.OK)
			{
				string text = ReadFile(this.opnFileDlg.FileName);
				this.richTextBox1.Text = text;
			}
		}
		#endregion

		#region ClassMethods
		private void ClearText()
		{
			this.richTextBox1.Text = "";
			this.richTextBox1.Text.Trim();
		}

		private void SelectAllText()
		{
			this.richTextBox1.SelectAll();
		}

		private void AddTextToTxtBox(string str)
		{
			this.richTextBox1.Text = str;
		}

		private string ReadFile(string fileName)
		{
			TextReader textReader = new StreamReader(this.opnFileDlg.FileName);
			StringBuilder stb=new StringBuilder();
			string str = textReader.ReadLine();
			while(str != null)
			{
				Console.WriteLine(str);
				stb.Append(str+"\n");
				str = textReader.ReadLine();
			}
			string textInFile = stb.ToString();
			textReader.Close();
			return textInFile;
		}
		#endregion

	}
}

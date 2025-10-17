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
using Syncfusion.Windows.Forms.Tools;
using Syncfusion.Windows.Forms.Tools.XPMenus;
using Syncfusion.Windows.Forms;
using Syncfusion.WinForms.Controls;

namespace MDIMerge
{
    /// <summary>
    /// Summary description for ImageEditorForm.
    /// </summary>
    public class ImageEditorForm : SfForm
    {
        #region Variables

        private System.Windows.Forms.PictureBox pictureBox1;
		private Syncfusion.Windows.Forms.Tools.XPMenus.ChildFrameBarManager childFrameBarManager1;
		private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem horzFilpItem;
		private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem vertFlipItem;
		private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem rotate90Item;
		private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem parentBarItem1;
		private string sourceFile;
		private Image sourceImage;
		private static int instanceCount = 0;
		private Syncfusion.Windows.Forms.PopupControlContainer popupControlContainer1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.Button button7;
		private System.Windows.Forms.Button button8;
		private System.Windows.Forms.Button button9;
		private Syncfusion.Windows.Forms.Tools.XPMenus.DropDownBarItem dropDownBarItem1;
		private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem parentBarItem2;
		private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem parentBarItem3;
		private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem autoSizeItem;
		private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem centerImageItem;
		private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem normalItem;
		private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem stretchItem;
		private System.Windows.Forms.Label dummyLabel;
		private System.Windows.Forms.ImageList imageList1;
		private System.Windows.Forms.ImageList largeImageList;
		private Syncfusion.Windows.Forms.Tools.XPMenus.PopupMenu popupMenu1;
		private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem contextMenuItem;
		private Syncfusion.Windows.Forms.Tools.XPMenus.Bar bar1;
		private Syncfusion.Windows.Forms.Tools.XPMenus.Bar bar2;
		private Syncfusion.Windows.Forms.Tools.XPMenus.PopupMenusManager popupMenusManager1;
		private Syncfusion.Windows.Forms.Tools.XPMenus.Bar bar3;
		private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem saveItem;
		private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem parentBarItem4;
		private System.ComponentModel.IContainer components;
        private BarItem lsmItem;
        private Button curSelection = null;

        #endregion 

        #region Constructor

        public ImageEditorForm()
		{
			InitializeComponent();
            try
            {
                System.Drawing.Icon ico = new System.Drawing.Icon(GetIconFile(@"common\Images\Grid\Icon\sfgrid.ico"));
                this.Icon = ico;
            }
            catch { }
		}

        #endregion

        #region Properties

        private Button CurrentSelection
        {
            get { return this.curSelection; }
            set
            {
                if (this.curSelection != value)
                {
                    if (this.curSelection != null)
                        this.curSelection.BringToFront();

                    this.curSelection = value;

                    if (this.curSelection != null)
                    {
                        this.dummyLabel.Location = this.curSelection.Location;
                        this.dummyLabel.BringToFront();
                    }
                    this.UpdatePictureBoxProps();
                }
            }
        }

        private int CurAlign
        {
            get { return (int)this.curSelection.Tag; }
        }

        #endregion

        #region Functions

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

		public ImageEditorForm(string sourceFile)
		{
			this.sourceFile = sourceFile;
			this.InitializeComponent();
			instanceCount++;
            this.Text = "Child Form1";
			this.InitFromSourceFile();
		}

		private void InitFromSourceFile()
		{
			if(this.sourceFile != String.Empty)
			{
				try
				{
					this.sourceImage = Image.FromFile(this.sourceFile, true);
					this.pictureBox1.Image = this.sourceImage;
				}
				catch(Exception e)
				{
					throw e;
				}
			}
		}

        #endregion

        #region Events

        private void ImageEditor_Load(object sender, System.EventArgs e)
        {
            this.button1.Tag = 1;
            this.button2.Tag = 2;
            this.button3.Tag = 3;
            this.button4.Tag = 4;
            this.button5.Tag = 5;
            this.button6.Tag = 6;
            this.button7.Tag = 7;
            this.button8.Tag = 8;
            this.button9.Tag = 9;
            this.normalItem.Tag = System.Enum.GetName(typeof(PictureBoxSizeMode), PictureBoxSizeMode.Normal);
            this.centerImageItem.Tag = System.Enum.GetName(typeof(PictureBoxSizeMode), PictureBoxSizeMode.CenterImage);
            this.stretchItem.Tag = System.Enum.GetName(typeof(PictureBoxSizeMode), PictureBoxSizeMode.StretchImage);
            this.autoSizeItem.Tag = System.Enum.GetName(typeof(PictureBoxSizeMode), PictureBoxSizeMode.AutoSize);
            this.curSelection = this.button1;
            this.SizeModeChanged(this.autoSizeItem, EventArgs.Empty);
            this.CurrentSelection = this.button5;
        }
        private void horzFilpItem_Click(object sender, System.EventArgs e)
        {
            this.sourceImage.RotateFlip(RotateFlipType.RotateNoneFlipX);
            this.pictureBox1.Invalidate();
            this.UpdatePictureBoxProps();
        }

        private void vertFlipItem_Click(object sender, System.EventArgs e)
        {
            this.sourceImage.RotateFlip(RotateFlipType.RotateNoneFlipY);
            this.pictureBox1.Invalidate();
            this.UpdatePictureBoxProps();
        }

        private void rotate90Item_Click(object sender, System.EventArgs e)
        {
            this.sourceImage.RotateFlip(RotateFlipType.Rotate90FlipNone);
            this.pictureBox1.Size = this.sourceImage.Size;
            this.pictureBox1.Invalidate();
            this.UpdatePictureBoxProps();
        }
        private void saveItem_Click(object sender, System.EventArgs e)
		{
			string filename="";
			SaveFileDialog savefDlg = new SaveFileDialog();
			savefDlg.Filter = "Image Files (*.bmp; *.gif; *.jpg)|*.bmp;*.gif;*.jpg|All Files (*.*)|*.*";
			if (savefDlg.ShowDialog() == DialogResult.OK)
			{
				filename = savefDlg.FileName;
				this.pictureBox1.Image.Save(filename);
				
			}
		}

		private void AlignSelected(object sender, System.EventArgs e)
		{
			this.popupControlContainer1.HidePopup(PopupCloseType.Done);
			this.autoSizeItem.PerformClick();
			this.CurrentSelection = sender as Button;
		}

		private void SizeModeChanged(object sender, System.EventArgs e)
		{
			try
			{
				BarItem barItem = sender as BarItem;
				this.pictureBox1.SizeMode = (PictureBoxSizeMode)System.Enum.Parse(
					typeof(PictureBoxSizeMode),
					barItem.Tag as string);
			}
			catch{}
			UpdatePictureBoxProps();
		}

		private void UpdatePictureBoxProps()
		{
			if(this.pictureBox1.SizeMode == PictureBoxSizeMode.AutoSize)
			{
				switch(this.CurAlign)
				{
					case 1: this.pictureBox1.Location = new Point(0, 0);
						this.pictureBox1.Anchor = AnchorStyles.None;
						break;
					case 2: this.pictureBox1.Location = new Point(this.ClientRectangle.Width/2 - this.pictureBox1.Width/2, 0);
						this.pictureBox1.Anchor = AnchorStyles.Right;
						break;
					case 3: this.pictureBox1.Location = new Point(this.ClientRectangle.Width - this.pictureBox1.Width, 0);
						this.pictureBox1.Anchor = AnchorStyles.Right;
						break;
					case 4: this.pictureBox1.Location = new Point(0, 
								this.ClientRectangle.Height/2 - this.pictureBox1.Height/2);
						this.pictureBox1.Anchor = AnchorStyles.Bottom;
						break;
					case 5: this.pictureBox1.Location = new Point(this.ClientRectangle.Width/2 - this.pictureBox1.Width/2, 
								this.ClientRectangle.Height/2 - this.pictureBox1.Height/2);
						this.pictureBox1.Anchor = AnchorStyles.Right | AnchorStyles.Bottom;
						break;
					case 6: this.pictureBox1.Location = new Point(this.ClientRectangle.Width-this.pictureBox1.Width, 
								this.ClientRectangle.Height/2 - this.pictureBox1.Height/2);
						this.pictureBox1.Anchor = AnchorStyles.Right | AnchorStyles.Bottom;
						break;
					case 7: this.pictureBox1.Location = new Point(0, this.ClientRectangle.Height - this.pictureBox1.Height);
						this.pictureBox1.Anchor = AnchorStyles.Bottom;
						break;
					case 8: this.pictureBox1.Location = new Point(this.ClientRectangle.Width/2 - this.pictureBox1.Width/2, this.ClientRectangle.Height - this.pictureBox1.Height);
						this.pictureBox1.Anchor = AnchorStyles.Right | AnchorStyles.Bottom;
						break;
					case 9: this.pictureBox1.Location = new Point(this.ClientRectangle.Width - this.pictureBox1.Width, this.ClientRectangle.Height - this.pictureBox1.Height);
						this.pictureBox1.Anchor = AnchorStyles.Right | AnchorStyles.Bottom;
						break;
				}
			}
			else
			{
				this.pictureBox1.Anchor = AnchorStyles.None;
				this.pictureBox1.Dock = DockStyle.Fill;
			}
		}

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

		private void ImageEditorForm_Resize(object sender, System.EventArgs e)
		{
			this.UpdatePictureBoxProps();
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImageEditorForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.childFrameBarManager1 = new Syncfusion.Windows.Forms.Tools.XPMenus.ChildFrameBarManager(this);
            this.bar1 = new Syncfusion.Windows.Forms.Tools.XPMenus.Bar(this.childFrameBarManager1, "MainMenu");
            this.parentBarItem4 = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.saveItem = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.parentBarItem1 = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.horzFilpItem = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.vertFlipItem = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.rotate90Item = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.parentBarItem3 = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.dropDownBarItem1 = new Syncfusion.Windows.Forms.Tools.XPMenus.DropDownBarItem();
            this.popupControlContainer1 = new Syncfusion.Windows.Forms.PopupControlContainer();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dummyLabel = new System.Windows.Forms.Label();
            this.parentBarItem2 = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.autoSizeItem = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.centerImageItem = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.normalItem = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.stretchItem = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.bar2 = new Syncfusion.Windows.Forms.Tools.XPMenus.Bar(this.childFrameBarManager1, "Image Edit");
            this.bar3 = new Syncfusion.Windows.Forms.Tools.XPMenus.Bar(this.childFrameBarManager1, "Standard");
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.contextMenuItem = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.largeImageList = new System.Windows.Forms.ImageList(this.components);
            this.popupMenu1 = new Syncfusion.Windows.Forms.Tools.XPMenus.PopupMenu(this.components);
            this.popupMenusManager1 = new Syncfusion.Windows.Forms.Tools.XPMenus.PopupMenusManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.childFrameBarManager1)).BeginInit();
            this.popupControlContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(562, 381);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.popupMenusManager1.SetXPContextMenu(this.pictureBox1, this.popupMenu1);
            // 
            // childFrameBarManager1
            // 
#if !NETCORE
            this.childFrameBarManager1.BarPositionInfo = ((System.IO.MemoryStream)(resources.GetObject("childFrameBarManager1.BarPositionInfo")));
#endif
            this.childFrameBarManager1.Bars.Add(this.bar1);
            this.childFrameBarManager1.Bars.Add(this.bar2);
            this.childFrameBarManager1.Bars.Add(this.bar3);
            this.childFrameBarManager1.Categories.Add("File");
            this.childFrameBarManager1.Categories.Add("Standard");
            this.childFrameBarManager1.Categories.Add("Edit");
            this.childFrameBarManager1.Categories.Add("Format");
            this.childFrameBarManager1.Categories.Add("StatusBar");
            this.childFrameBarManager1.Categories.Add("ContextMenu");
            this.childFrameBarManager1.CategoriesToIgnoreInCustDialog.AddRange(new int[] {
            6});
            this.childFrameBarManager1.CurrentBaseFormType = "Syncfusion.WinForms.Controls.SfForm";
            this.childFrameBarManager1.EnableMenuMerge = true;
            this.childFrameBarManager1.Form = this;
            this.childFrameBarManager1.FormName = "Image Editor";
            this.childFrameBarManager1.ImageList = this.imageList1;
            this.childFrameBarManager1.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.parentBarItem1,
            this.parentBarItem4,
            this.horzFilpItem,
            this.vertFlipItem,
            this.rotate90Item,
            this.parentBarItem3,
            this.contextMenuItem,
            this.dropDownBarItem1,
            this.parentBarItem2,
            this.autoSizeItem,
            this.centerImageItem,
            this.normalItem,
            this.stretchItem,
            this.saveItem});
            this.childFrameBarManager1.LargeImageList = this.largeImageList;
            this.childFrameBarManager1.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(201)))), ((int)(((byte)(232)))));
            this.childFrameBarManager1.ThemeName = "Office2019Colorful";
            this.childFrameBarManager1.UseBackwardCompatiblity = false;
            // 
            // bar1
            // 
            this.bar1.BarName = "MainMenu";
            this.bar1.BarStyle = ((Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle)((((Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.AllowQuickCustomizing | Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.IsMainMenu)
                        | Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.Visible)
                        | Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.DrawDragBorder)));
            this.bar1.Caption = "MainMenu";
            this.bar1.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.parentBarItem4,
            this.parentBarItem1,
            this.parentBarItem3});
            this.bar1.Manager = this.childFrameBarManager1;
            // 
            // parentBarItem4
            // 
            this.parentBarItem4.BarName = "parentBarItem4";
            this.parentBarItem4.CategoryIndex = 0;
            this.parentBarItem4.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parentBarItem4.ID = "&File";
            this.parentBarItem4.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.saveItem});
            this.parentBarItem4.MergeOrder = 1;
            this.parentBarItem4.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(201)))), ((int)(((byte)(232)))));
            this.parentBarItem4.ShowToolTipInPopUp = false;
            this.parentBarItem4.SizeToFit = true;
            this.parentBarItem4.Text = "&File";
            this.parentBarItem4.WrapLength = 20;
            // 
            // saveItem
            // 
            this.saveItem.BarName = "saveItem";
            this.saveItem.CategoryIndex = 1;
            this.saveItem.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveItem.ID = "&Save";
            this.saveItem.ImageIndex = 5;
            this.saveItem.MergeOrder = 2;
            this.saveItem.Shortcut = System.Windows.Forms.Shortcut.CtrlS;
            this.saveItem.ShowToolTipInPopUp = false;
            this.saveItem.SizeToFit = true;
            this.saveItem.Text = "&Save";
            this.saveItem.Tooltip = "Save Image (Ctrl + S)";
            this.saveItem.Click += new System.EventHandler(this.saveItem_Click);
            // 
            // parentBarItem1
            // 
            this.parentBarItem1.BarName = "parentBarItem1";
            this.parentBarItem1.CategoryIndex = 2;
            this.parentBarItem1.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parentBarItem1.ID = "&Edit";
            this.parentBarItem1.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.horzFilpItem,
            this.vertFlipItem,
            this.rotate90Item});
            this.parentBarItem1.MergeOrder = 2;
            this.parentBarItem1.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(201)))), ((int)(((byte)(232)))));
            this.parentBarItem1.ShowToolTipInPopUp = false;
            this.parentBarItem1.SizeToFit = true;
            this.parentBarItem1.Text = "&Edit";
            this.parentBarItem1.WrapLength = 20;
            // 
            // horzFilpItem
            // 
            this.horzFilpItem.CategoryIndex = 2;
            this.horzFilpItem.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.horzFilpItem.ID = "&Horizontal Flip";
            this.horzFilpItem.ImageIndex = 0;
            this.horzFilpItem.Text = "&Horizontal Flip";
            this.horzFilpItem.Click += new System.EventHandler(this.horzFilpItem_Click);
            // 
            // vertFlipItem
            // 
            this.vertFlipItem.CategoryIndex = 2;
            this.vertFlipItem.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vertFlipItem.ID = "&Vertical Flip";
            this.vertFlipItem.ImageIndex = 1;
            this.vertFlipItem.Text = "&Vertical Flip";
            this.vertFlipItem.Click += new System.EventHandler(this.vertFlipItem_Click);
            // 
            // rotate90Item
            // 
            this.rotate90Item.CategoryIndex = 2;
            this.rotate90Item.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rotate90Item.ID = "&Rotate by 90";
            this.rotate90Item.ImageIndex = 2;
            this.rotate90Item.Text = "&Rotate by 90";
            this.rotate90Item.Click += new System.EventHandler(this.rotate90Item_Click);
            // 
            // parentBarItem3
            // 
            this.parentBarItem3.BarName = "parentBarItem3";
            this.parentBarItem3.CategoryIndex = 3;
            this.parentBarItem3.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parentBarItem3.ID = "Forma&t";
            this.parentBarItem3.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.dropDownBarItem1,
            this.parentBarItem2});
            this.parentBarItem3.MergeOrder = 3;
            this.parentBarItem3.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(201)))), ((int)(((byte)(232)))));
            this.parentBarItem3.ShowToolTipInPopUp = false;
            this.parentBarItem3.SizeToFit = true;
            this.parentBarItem3.Text = "Forma&t";
            this.parentBarItem3.WrapLength = 20;
            // 
            // dropDownBarItem1
            // 
            this.dropDownBarItem1.BarName = "dropDownBarItem1";
            this.dropDownBarItem1.CategoryIndex = 3;
            this.dropDownBarItem1.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dropDownBarItem1.ID = "Alignment";
            this.dropDownBarItem1.ImageIndex = 3;
            this.dropDownBarItem1.PopupControlContainer = this.popupControlContainer1;
            this.dropDownBarItem1.ShowToolTipInPopUp = false;
            this.dropDownBarItem1.SizeToFit = true;
            this.dropDownBarItem1.Text = "Alignment";
            // 
            // popupControlContainer1
            // 
            this.popupControlContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.popupControlContainer1.Controls.Add(this.button9);
            this.popupControlContainer1.Controls.Add(this.button8);
            this.popupControlContainer1.Controls.Add(this.button7);
            this.popupControlContainer1.Controls.Add(this.button6);
            this.popupControlContainer1.Controls.Add(this.button5);
            this.popupControlContainer1.Controls.Add(this.button4);
            this.popupControlContainer1.Controls.Add(this.button3);
            this.popupControlContainer1.Controls.Add(this.button2);
            this.popupControlContainer1.Controls.Add(this.button1);
            this.popupControlContainer1.Controls.Add(this.dummyLabel);
            this.popupControlContainer1.Location = new System.Drawing.Point(264, 72);
            this.popupControlContainer1.Name = "popupControlContainer1";
            this.popupControlContainer1.Size = new System.Drawing.Size(128, 128);
            this.popupControlContainer1.TabIndex = 4;
            this.popupControlContainer1.Visible = false;
            // 
            // button9
            // 
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button9.Location = new System.Drawing.Point(88, 88);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(32, 32);
            this.button9.TabIndex = 8;
            this.button9.Click += new System.EventHandler(this.AlignSelected);
            // 
            // button8
            // 
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button8.Location = new System.Drawing.Point(48, 88);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(32, 32);
            this.button8.TabIndex = 7;
            this.button8.Click += new System.EventHandler(this.AlignSelected);
            // 
            // button7
            // 
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button7.Location = new System.Drawing.Point(8, 88);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(32, 32);
            this.button7.TabIndex = 6;
            this.button7.Click += new System.EventHandler(this.AlignSelected);
            // 
            // button6
            // 
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button6.Location = new System.Drawing.Point(88, 48);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(32, 32);
            this.button6.TabIndex = 5;
            this.button6.Click += new System.EventHandler(this.AlignSelected);
            // 
            // button5
            // 
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button5.Location = new System.Drawing.Point(48, 48);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(32, 32);
            this.button5.TabIndex = 4;
            this.button5.Click += new System.EventHandler(this.AlignSelected);
            // 
            // button4
            // 
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button4.Location = new System.Drawing.Point(8, 48);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(32, 32);
            this.button4.TabIndex = 3;
            this.button4.Click += new System.EventHandler(this.AlignSelected);
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button3.Location = new System.Drawing.Point(88, 8);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(32, 32);
            this.button3.TabIndex = 2;
            this.button3.Click += new System.EventHandler(this.AlignSelected);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button2.Location = new System.Drawing.Point(48, 8);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(32, 32);
            this.button2.TabIndex = 1;
            this.button2.Click += new System.EventHandler(this.AlignSelected);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1.Location = new System.Drawing.Point(8, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(32, 32);
            this.button1.TabIndex = 0;
            this.button1.Click += new System.EventHandler(this.AlignSelected);
            // 
            // dummyLabel
            // 
            this.dummyLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dummyLabel.Location = new System.Drawing.Point(8, 8);
            this.dummyLabel.Name = "dummyLabel";
            this.dummyLabel.Size = new System.Drawing.Size(32, 32);
            this.dummyLabel.TabIndex = 9;
            // 
            // parentBarItem2
            // 
            this.parentBarItem2.BarName = "parentBarItem2";
            this.parentBarItem2.CategoryIndex = 3;
            this.parentBarItem2.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parentBarItem2.ID = "SizeMode";
            this.parentBarItem2.ImageIndex = 4;
            this.parentBarItem2.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.autoSizeItem,
            this.centerImageItem,
            this.normalItem,
            this.stretchItem});
            this.parentBarItem2.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(201)))), ((int)(((byte)(232)))));
            this.parentBarItem2.ParentStyle = Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItemStyle.DropDown;
            this.parentBarItem2.ShowToolTipInPopUp = false;
            this.parentBarItem2.SizeToFit = true;
            this.parentBarItem2.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007;
            this.parentBarItem2.Text = "SizeMode";
            this.parentBarItem2.WrapLength = 20;
            // 
            // autoSizeItem
            // 
            this.autoSizeItem.BarName = "autoSizeItem";
            this.autoSizeItem.CategoryIndex = 3;
            this.autoSizeItem.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoSizeItem.ID = "Auto Size";
            this.autoSizeItem.ShowToolTipInPopUp = false;
            this.autoSizeItem.SizeToFit = true;
            this.autoSizeItem.Text = "Auto Size";
            this.autoSizeItem.Click += new System.EventHandler(this.SizeModeChanged);
            // 
            // centerImageItem
            // 
            this.centerImageItem.BarName = "centerImageItem";
            this.centerImageItem.CategoryIndex = 3;
            this.centerImageItem.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.centerImageItem.ID = "Center Image";
            this.centerImageItem.ShowToolTipInPopUp = false;
            this.centerImageItem.SizeToFit = true;
            this.centerImageItem.Text = "Center Image";
            this.centerImageItem.Click += new System.EventHandler(this.SizeModeChanged);
            // 
            // normalItem
            // 
            this.normalItem.BarName = "normalItem";
            this.normalItem.CategoryIndex = 3;
            this.normalItem.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.normalItem.ID = "Normal";
            this.normalItem.ShowToolTipInPopUp = false;
            this.normalItem.SizeToFit = true;
            this.normalItem.Text = "Normal";
            this.normalItem.Click += new System.EventHandler(this.SizeModeChanged);
            // 
            // stretchItem
            // 
            this.stretchItem.BarName = "stretchItem";
            this.stretchItem.CategoryIndex = 3;
            this.stretchItem.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stretchItem.ID = "Stretch Image";
            this.stretchItem.ShowToolTipInPopUp = false;
            this.stretchItem.SizeToFit = true;
            this.stretchItem.Text = "Stretch Image";
            this.stretchItem.Click += new System.EventHandler(this.SizeModeChanged);
            // 
            // bar2
            // 
            this.bar2.BarName = "Image Edit";
            this.bar2.Caption = "Image Edit";
            this.bar2.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.horzFilpItem,
            this.vertFlipItem,
            this.rotate90Item,
            this.dropDownBarItem1,
            this.parentBarItem2});
            this.bar2.Manager = this.childFrameBarManager1;
            this.bar2.SeparatorIndices.AddRange(new int[] {
            3});
            // 
            // bar3
            // 
            this.bar3.BarName = "Standard";
            this.bar3.Caption = "Standard";
            this.bar3.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.saveItem});
            this.bar3.Manager = this.childFrameBarManager1;
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
            // contextMenuItem
            // 
            this.contextMenuItem.BarName = "contextMenuItem";
            this.contextMenuItem.CategoryIndex = 5;
            this.contextMenuItem.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contextMenuItem.ID = "ContextMenu";
            this.contextMenuItem.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.parentBarItem1,
            this.parentBarItem3});
            this.contextMenuItem.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(201)))), ((int)(((byte)(232)))));
            this.contextMenuItem.ShowToolTipInPopUp = false;
            this.contextMenuItem.SizeToFit = true;
            this.contextMenuItem.Text = "ContextMenu";
            this.contextMenuItem.WrapLength = 20;
            // 
            // largeImageList
            // 
            this.largeImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("largeImageList.ImageStream")));
            this.largeImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.largeImageList.Images.SetKeyName(0, "");
            this.largeImageList.Images.SetKeyName(1, "");
            this.largeImageList.Images.SetKeyName(2, "");
            this.largeImageList.Images.SetKeyName(3, "");
            this.largeImageList.Images.SetKeyName(4, "");
            this.largeImageList.Images.SetKeyName(5, "");
            // 
            // popupMenu1
            // 
            this.popupMenu1.ParentBarItem = this.contextMenuItem;
            // 
            // ImageEditorForm
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
            this.ClientSize = new System.Drawing.Size(566, 385);
            this.Controls.Add(this.popupControlContainer1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ImageEditorForm";
            this.Text = "Image Editor";
            this.popupMenusManager1.SetXPContextMenu(this, this.popupMenu1);
            this.Load += new System.EventHandler(this.ImageEditor_Load);
            this.Resize += new System.EventHandler(this.ImageEditorForm_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.childFrameBarManager1)).EndInit();
            this.popupControlContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

	}
}

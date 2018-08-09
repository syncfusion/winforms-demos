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

using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Diagnostics;

using Syncfusion.Windows.Forms;
using Syncfusion.Windows.Forms.Tools;
using System.IO;
using Syncfusion.Drawing;
using Syncfusion.Licensing;

namespace TreeViewAdvDragDrop
{
	#region Class Form1 Description
	
	public class Form1 : MetroForm
	{
	
		#region Variable Declaration

        // Use the tracker only when you want to support dropping adjacent (above or below) to a node.
		// Otherwise simply listen to the DragOver and DragDrop events and provide/use the DropEffect.
		// When used this tracker will draw indicators above or below a node while dragging an item
		// over the node. The tracker need to be updated as shown below in the DragXXX events.
        private TreeViewAdvDragHighlightTracker treeViewDragHighlightTracker = null;
        private ColorDialog colorDialog1;
        private IContainer components;
        private ScrollersFrame scrollersFrame1;
        private GradientPanel gradientPanel1;
        private ImageList imageList1;
        private ColorDialog colorDialog2;
        private ImageList imageList2;
        private ComboBoxAdv comboBox2;
        private ComboBoxAdv comboBox1;
        private ImageList leftImageList;
        private ContextMenu contextMenu1;
        private MenuItem editItem;
        private MenuItem copyItem;
        private MenuItem cutItem;
        private ImageList rightImageList;
        private ImageList stateImageList;
        private TreeViewAdv treeViewAdv2;
        private PropertyGrid pgGrid;
        private System.Windows.Forms.ListViewItem listViewItem1;
		#endregion

		#region Form Constructor Initialization and Disposing
		
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
				if(treeViewDragHighlightTracker != null)
				{
					this.treeViewDragHighlightTracker = null;
				}
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
            Syncfusion.Windows.Forms.MetroColorTable metroColorTable1 = new Syncfusion.Windows.Forms.MetroColorTable();
            Syncfusion.Windows.Forms.MetroColorTable metroColorTable2 = new Syncfusion.Windows.Forms.MetroColorTable();
            Syncfusion.Windows.Forms.MetroColorTable metroColorTable3 = new Syncfusion.Windows.Forms.MetroColorTable();
            Syncfusion.Windows.Forms.MetroColorTable metroColorTable4 = new Syncfusion.Windows.Forms.MetroColorTable();
            Syncfusion.Windows.Forms.MetroColorTable metroColorTable5 = new Syncfusion.Windows.Forms.MetroColorTable();
            Syncfusion.Windows.Forms.Tools.TreeNodeAdvStyleInfo treeNodeAdvStyleInfo1 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdvStyleInfo();
            Syncfusion.Windows.Forms.Tools.TreeNodeAdv treeNodeAdv1 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdv();
            Syncfusion.Windows.Forms.Tools.TreeNodeAdv treeNodeAdv2 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdv();
            Syncfusion.Windows.Forms.Tools.TreeNodeAdv treeNodeAdv3 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdv();
            Syncfusion.Windows.Forms.Tools.TreeNodeAdv treeNodeAdv4 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdv();
            Syncfusion.Windows.Forms.Tools.TreeNodeAdv treeNodeAdv5 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdv();
            Syncfusion.Windows.Forms.Tools.TreeNodeAdv treeNodeAdv6 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdv();
            Syncfusion.Windows.Forms.Tools.TreeNodeAdv treeNodeAdv7 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdv();
            Syncfusion.Windows.Forms.Tools.TreeNodeAdv treeNodeAdv8 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdv();
            Syncfusion.Windows.Forms.Tools.TreeNodeAdv treeNodeAdv9 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdv();
            Syncfusion.Windows.Forms.Tools.TreeNodeAdv treeNodeAdv10 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdv();
            Syncfusion.Windows.Forms.Tools.TreeNodeAdv treeNodeAdv11 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdv();
            Syncfusion.Windows.Forms.Tools.TreeNodeAdv treeNodeAdv12 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdv();
            Syncfusion.Windows.Forms.Tools.TreeNodeAdv treeNodeAdv13 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdv();
            Syncfusion.Windows.Forms.Tools.TreeNodeAdv treeNodeAdv14 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdv();
            Syncfusion.Windows.Forms.Tools.TreeNodeAdv treeNodeAdv15 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdv();
            Syncfusion.Windows.Forms.Tools.TreeNodeAdv treeNodeAdv16 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdv();
            Syncfusion.Windows.Forms.Tools.TreeNodeAdv treeNodeAdv17 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdv();
            Syncfusion.Windows.Forms.Tools.TreeNodeAdv treeNodeAdv18 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdv();
            Syncfusion.Windows.Forms.Tools.TreeNodeAdv treeNodeAdv19 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdv();
            Syncfusion.Windows.Forms.Tools.TreeNodeAdv treeNodeAdv20 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdv();
            Syncfusion.Windows.Forms.Tools.TreeNodeAdv treeNodeAdv21 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdv();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.scrollersFrame1 = new Syncfusion.Windows.Forms.ScrollersFrame(this.components);
            this.pgGrid = new System.Windows.Forms.PropertyGrid();
            this.treeViewAdv2 = new Syncfusion.Windows.Forms.Tools.TreeViewAdv();
            this.contextMenu1 = new System.Windows.Forms.ContextMenu();
            this.editItem = new System.Windows.Forms.MenuItem();
            this.copyItem = new System.Windows.Forms.MenuItem();
            this.cutItem = new System.Windows.Forms.MenuItem();
            this.leftImageList = new System.Windows.Forms.ImageList(this.components);
            this.rightImageList = new System.Windows.Forms.ImageList(this.components);
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.comboBox2 = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.comboBox1 = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.gradientPanel1 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            this.colorDialog2 = new System.Windows.Forms.ColorDialog();
            this.stateImageList = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.treeViewAdv2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel1)).BeginInit();
            this.gradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // scrollersFrame1
            // 
            this.scrollersFrame1.AttachedTo = this.pgGrid;
            this.scrollersFrame1.CustomRender = null;
            this.scrollersFrame1.HorizontalSmallChange = 7;
            this.scrollersFrame1.MetroColorScheme = Syncfusion.Windows.Forms.MetroColorScheme.Managed;
            this.scrollersFrame1.MetroThumbSize = new System.Drawing.Size(0, 0);
            this.scrollersFrame1.Office2016ColorScheme = Syncfusion.Windows.Forms.ScrollBarOffice2016ColorScheme.Colorful;
            metroColorTable1.ArrowChecked = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(149)))), ((int)(((byte)(152)))));
            metroColorTable1.ArrowCheckedBorderColor = System.Drawing.Color.Empty;
            metroColorTable1.ArrowInActive = System.Drawing.Color.White;
            metroColorTable1.ArrowNormal = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(198)))), ((int)(((byte)(198)))));
            metroColorTable1.ArrowNormalBackGround = System.Drawing.Color.Empty;
            metroColorTable1.ArrowNormalBorderColor = System.Drawing.Color.Empty;
            metroColorTable1.ArrowPushed = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(89)))), ((int)(((byte)(90)))));
            metroColorTable1.ArrowPushedBackGround = System.Drawing.Color.Empty;
            metroColorTable1.ArrowPushedBorderColor = System.Drawing.Color.Empty;
            metroColorTable1.ScrollerBackground = System.Drawing.Color.White;
            metroColorTable1.ThumbChecked = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(149)))), ((int)(((byte)(152)))));
            metroColorTable1.ThumbCheckedBorderColor = System.Drawing.Color.Empty;
            metroColorTable1.ThumbInActive = System.Drawing.Color.White;
            metroColorTable1.ThumbNormal = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(198)))), ((int)(((byte)(198)))));
            metroColorTable1.ThumbNormalBorderColor = System.Drawing.Color.Empty;
            metroColorTable1.ThumbPushed = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(89)))), ((int)(((byte)(90)))));
            metroColorTable1.ThumbPushedBorder = System.Drawing.Color.Empty;
            metroColorTable1.ThumbPushedBorderColor = System.Drawing.Color.Empty;
            this.scrollersFrame1.ScrollMetroColorTable = metroColorTable1;
            metroColorTable2.ArrowChecked = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            metroColorTable2.ArrowCheckedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(94)))), ((int)(((byte)(94)))));
            metroColorTable2.ArrowInActive = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            metroColorTable2.ArrowNormal = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(178)))), ((int)(((byte)(178)))));
            metroColorTable2.ArrowNormalBackGround = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(94)))), ((int)(((byte)(94)))));
            metroColorTable2.ArrowNormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            metroColorTable2.ArrowPushed = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(211)))), ((int)(((byte)(211)))));
            metroColorTable2.ArrowPushedBackGround = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            metroColorTable2.ArrowPushedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(83)))), ((int)(((byte)(83)))));
            metroColorTable2.ScrollerBackground = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            metroColorTable2.ThumbChecked = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            metroColorTable2.ThumbCheckedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(94)))), ((int)(((byte)(94)))));
            metroColorTable2.ThumbInActive = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            metroColorTable2.ThumbNormal = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(94)))), ((int)(((byte)(94)))));
            metroColorTable2.ThumbNormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            metroColorTable2.ThumbPushed = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            metroColorTable2.ThumbPushedBorder = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(83)))), ((int)(((byte)(83)))));
            metroColorTable2.ThumbPushedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.scrollersFrame1.ScrollOffice2016BlackColorTable = metroColorTable2;
            metroColorTable3.ArrowChecked = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(114)))), ((int)(((byte)(114)))));
            metroColorTable3.ArrowCheckedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(94)))), ((int)(((byte)(94)))));
            metroColorTable3.ArrowInActive = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            metroColorTable3.ArrowNormal = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(114)))), ((int)(((byte)(114)))));
            metroColorTable3.ArrowNormalBackGround = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            metroColorTable3.ArrowNormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            metroColorTable3.ArrowPushed = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(114)))), ((int)(((byte)(114)))));
            metroColorTable3.ArrowPushedBackGround = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            metroColorTable3.ArrowPushedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            metroColorTable3.ScrollerBackground = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            metroColorTable3.ThumbChecked = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            metroColorTable3.ThumbCheckedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            metroColorTable3.ThumbInActive = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            metroColorTable3.ThumbNormal = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            metroColorTable3.ThumbNormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            metroColorTable3.ThumbPushed = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            metroColorTable3.ThumbPushedBorder = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            metroColorTable3.ThumbPushedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.scrollersFrame1.ScrollOffice2016ColorfulColorTable = metroColorTable3;
            metroColorTable4.ArrowChecked = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            metroColorTable4.ArrowCheckedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            metroColorTable4.ArrowInActive = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            metroColorTable4.ArrowNormal = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            metroColorTable4.ArrowNormalBackGround = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            metroColorTable4.ArrowNormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            metroColorTable4.ArrowPushed = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            metroColorTable4.ArrowPushedBackGround = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            metroColorTable4.ArrowPushedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            metroColorTable4.ScrollerBackground = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            metroColorTable4.ThumbChecked = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            metroColorTable4.ThumbCheckedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            metroColorTable4.ThumbInActive = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            metroColorTable4.ThumbNormal = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            metroColorTable4.ThumbNormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            metroColorTable4.ThumbPushed = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            metroColorTable4.ThumbPushedBorder = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            metroColorTable4.ThumbPushedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.scrollersFrame1.ScrollOffice2016DarkGrayColorTable = metroColorTable4;
            metroColorTable5.ArrowChecked = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(114)))), ((int)(((byte)(114)))));
            metroColorTable5.ArrowCheckedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(94)))), ((int)(((byte)(94)))));
            metroColorTable5.ArrowInActive = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            metroColorTable5.ArrowNormal = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(114)))), ((int)(((byte)(114)))));
            metroColorTable5.ArrowNormalBackGround = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            metroColorTable5.ArrowNormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            metroColorTable5.ArrowPushed = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(114)))), ((int)(((byte)(114)))));
            metroColorTable5.ArrowPushedBackGround = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            metroColorTable5.ArrowPushedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            metroColorTable5.ScrollerBackground = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            metroColorTable5.ThumbChecked = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            metroColorTable5.ThumbCheckedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            metroColorTable5.ThumbInActive = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            metroColorTable5.ThumbNormal = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            metroColorTable5.ThumbNormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            metroColorTable5.ThumbPushed = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            metroColorTable5.ThumbPushedBorder = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            metroColorTable5.ThumbPushedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.scrollersFrame1.ScrollOffice2016WhiteColorTable = metroColorTable5;
            this.scrollersFrame1.ShowMetroArrowButton = true;
            this.scrollersFrame1.SizeGripperVisibility = Syncfusion.Windows.Forms.SizeGripperVisibility.Auto;
            this.scrollersFrame1.VerticallSmallChange = 13;
            this.scrollersFrame1.VisualStyle = Syncfusion.Windows.Forms.ScrollBarCustomDrawStyles.Metro;
            // 
            // pgGrid
            // 
            this.pgGrid.BackColor = System.Drawing.Color.White;
            this.pgGrid.CategoryForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.pgGrid.Dock = System.Windows.Forms.DockStyle.Right;
            this.pgGrid.HelpBackColor = System.Drawing.Color.White;
            this.pgGrid.LineColor = System.Drawing.Color.Gainsboro;
            this.pgGrid.Location = new System.Drawing.Point(312, 0);
            this.pgGrid.Name = "pgGrid";
            this.pgGrid.SelectedObject = this.treeViewAdv2;
            this.pgGrid.Size = new System.Drawing.Size(239, 461);
            this.pgGrid.TabIndex = 5;
            this.pgGrid.Click += new System.EventHandler(this.pgGrid_Click);
            // 
            // treeViewAdv2
            // 
            this.treeViewAdv2.AllowDrop = true;
            this.treeViewAdv2.BackColor = System.Drawing.Color.White;
            treeNodeAdvStyleInfo1.EnsureDefaultOptionedChild = true;
            treeNodeAdvStyleInfo1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            treeNodeAdvStyleInfo1.NoChildrenImgIndex = -1;
            this.treeViewAdv2.BaseStylePairs.AddRange(new Syncfusion.Windows.Forms.Tools.StyleNamePair[] {
            new Syncfusion.Windows.Forms.Tools.StyleNamePair("Standard", treeNodeAdvStyleInfo1)});
            this.treeViewAdv2.BeforeTouchSize = new System.Drawing.Size(312, 461);
            this.treeViewAdv2.Border3DStyle = System.Windows.Forms.Border3DStyle.Flat;
            this.treeViewAdv2.BorderColor = System.Drawing.Color.Gainsboro;
            this.treeViewAdv2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.treeViewAdv2.ContextMenu = this.contextMenu1;
            this.treeViewAdv2.Dock = System.Windows.Forms.DockStyle.Fill;
            // 
            // 
            // 
            this.treeViewAdv2.HelpTextControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.treeViewAdv2.HelpTextControl.Location = new System.Drawing.Point(732, 0);
            this.treeViewAdv2.HelpTextControl.Name = "helpText";
            this.treeViewAdv2.HelpTextControl.Size = new System.Drawing.Size(49, 15);
            this.treeViewAdv2.HelpTextControl.TabIndex = 0;
            this.treeViewAdv2.HelpTextControl.Text = "help text";
            this.treeViewAdv2.InactiveSelectedNodeForeColor = System.Drawing.SystemColors.ControlText;
            this.treeViewAdv2.ItemHeight = 18;
            this.treeViewAdv2.LeftImageList = this.leftImageList;
            this.treeViewAdv2.Location = new System.Drawing.Point(0, 0);
            this.treeViewAdv2.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218)))));
            this.treeViewAdv2.MinimumSize = new System.Drawing.Size(300, 0);
            this.treeViewAdv2.Name = "treeViewAdv2";
            this.treeViewAdv2.NoChildrenImgIndex = -1;
            treeNodeAdv1.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv1.EnsureDefaultOptionedChild = true;
            treeNodeAdv1.Expanded = true;
            treeNodeAdv1.MultiLine = true;
            treeNodeAdv2.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv2.EnsureDefaultOptionedChild = true;
            treeNodeAdv2.MultiLine = true;
            treeNodeAdv2.Optioned = true;
            treeNodeAdv2.PlusMinusSize = new System.Drawing.Size(9, 9);
            treeNodeAdv2.ShowLine = true;
            treeNodeAdv2.ShowOptionButton = true;
            treeNodeAdv2.Text = "Single";
            treeNodeAdv3.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv3.EnsureDefaultOptionedChild = true;
            treeNodeAdv3.MultiLine = true;
            treeNodeAdv3.PlusMinusSize = new System.Drawing.Size(9, 9);
            treeNodeAdv3.ShowLine = true;
            treeNodeAdv3.ShowOptionButton = true;
            treeNodeAdv3.Text = "Married";
            treeNodeAdv4.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv4.EnsureDefaultOptionedChild = true;
            treeNodeAdv4.MultiLine = true;
            treeNodeAdv4.PlusMinusSize = new System.Drawing.Size(9, 9);
            treeNodeAdv4.ShowLine = true;
            treeNodeAdv4.ShowOptionButton = true;
            treeNodeAdv4.Text = "Married with children";
            treeNodeAdv1.Nodes.AddRange(new Syncfusion.Windows.Forms.Tools.TreeNodeAdv[] {
            treeNodeAdv2,
            treeNodeAdv3,
            treeNodeAdv4});
            treeNodeAdv1.PlusMinusSize = new System.Drawing.Size(9, 9);
            treeNodeAdv1.RightImageIndices = new int[] {
        2};
            treeNodeAdv1.ShowLine = true;
            treeNodeAdv1.Text = "Marital Status";
            treeNodeAdv5.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv5.EnsureDefaultOptionedChild = true;
            treeNodeAdv5.Expanded = true;
            treeNodeAdv5.InteractiveCheckBox = true;
            treeNodeAdv5.MultiLine = true;
            treeNodeAdv6.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv6.EnsureDefaultOptionedChild = true;
            treeNodeAdv6.MultiLine = true;
            treeNodeAdv6.Optioned = true;
            treeNodeAdv6.PlusMinusSize = new System.Drawing.Size(9, 9);
            treeNodeAdv6.ShowCheckBox = true;
            treeNodeAdv6.ShowLine = true;
            treeNodeAdv6.Text = "Hepatitis B";
            treeNodeAdv7.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv7.EnsureDefaultOptionedChild = true;
            treeNodeAdv7.MultiLine = true;
            treeNodeAdv7.PlusMinusSize = new System.Drawing.Size(9, 9);
            treeNodeAdv7.ShowCheckBox = true;
            treeNodeAdv7.ShowLine = true;
            treeNodeAdv7.Text = "Tetanus";
            treeNodeAdv8.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv8.EnsureDefaultOptionedChild = true;
            treeNodeAdv8.MultiLine = true;
            treeNodeAdv8.PlusMinusSize = new System.Drawing.Size(9, 9);
            treeNodeAdv8.ShowCheckBox = true;
            treeNodeAdv8.ShowLine = true;
            treeNodeAdv8.Text = "Polio ";
            treeNodeAdv9.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv9.EnsureDefaultOptionedChild = true;
            treeNodeAdv9.MultiLine = true;
            treeNodeAdv9.PlusMinusSize = new System.Drawing.Size(9, 9);
            treeNodeAdv9.ShowCheckBox = true;
            treeNodeAdv9.ShowLine = true;
            treeNodeAdv9.Text = "Measles";
            treeNodeAdv5.Nodes.AddRange(new Syncfusion.Windows.Forms.Tools.TreeNodeAdv[] {
            treeNodeAdv6,
            treeNodeAdv7,
            treeNodeAdv8,
            treeNodeAdv9});
            treeNodeAdv5.PlusMinusSize = new System.Drawing.Size(9, 9);
            treeNodeAdv5.RightImageIndices = new int[] {
        6};
            treeNodeAdv5.ShowCheckBox = true;
            treeNodeAdv5.ShowLine = true;
            treeNodeAdv5.Text = "Baby Vaccines";
            treeNodeAdv10.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv10.EnsureDefaultOptionedChild = true;
            treeNodeAdv10.Expanded = true;
            treeNodeAdv10.MultiLine = true;
            treeNodeAdv11.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv11.EnsureDefaultOptionedChild = true;
            treeNodeAdv11.LeftImageIndices = new int[] {
        0};
            treeNodeAdv11.MultiLine = true;
            treeNodeAdv11.Optioned = true;
            treeNodeAdv11.PlusMinusSize = new System.Drawing.Size(9, 9);
            treeNodeAdv11.ShowLine = true;
            treeNodeAdv11.Text = "Canada";
            treeNodeAdv12.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv12.EnsureDefaultOptionedChild = true;
            treeNodeAdv12.LeftImageIndices = new int[] {
        1};
            treeNodeAdv12.MultiLine = true;
            treeNodeAdv12.PlusMinusSize = new System.Drawing.Size(9, 9);
            treeNodeAdv12.ShowLine = true;
            treeNodeAdv12.Text = "France";
            treeNodeAdv13.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv13.EnsureDefaultOptionedChild = true;
            treeNodeAdv13.LeftImageIndices = new int[] {
        2};
            treeNodeAdv13.MultiLine = true;
            treeNodeAdv13.PlusMinusSize = new System.Drawing.Size(9, 9);
            treeNodeAdv13.ShowLine = true;
            treeNodeAdv13.Text = "Germany";
            treeNodeAdv14.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv14.EnsureDefaultOptionedChild = true;
            treeNodeAdv14.LeftImageIndices = new int[] {
        3};
            treeNodeAdv14.MultiLine = true;
            treeNodeAdv14.PlusMinusSize = new System.Drawing.Size(9, 9);
            treeNodeAdv14.ShowLine = true;
            treeNodeAdv14.Text = "UK";
            treeNodeAdv15.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv15.EnsureDefaultOptionedChild = true;
            treeNodeAdv15.LeftImageIndices = new int[] {
        4};
            treeNodeAdv15.MultiLine = true;
            treeNodeAdv15.PlusMinusSize = new System.Drawing.Size(9, 9);
            treeNodeAdv15.ShowLine = true;
            treeNodeAdv15.Text = "USA";
            treeNodeAdv10.Nodes.AddRange(new Syncfusion.Windows.Forms.Tools.TreeNodeAdv[] {
            treeNodeAdv11,
            treeNodeAdv12,
            treeNodeAdv13,
            treeNodeAdv14,
            treeNodeAdv15});
            treeNodeAdv10.PlusMinusSize = new System.Drawing.Size(9, 9);
            treeNodeAdv10.RightImageIndices = new int[] {
        7};
            treeNodeAdv10.ShowLine = true;
            treeNodeAdv10.Text = "Country Information";
            treeNodeAdv16.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv16.EnsureDefaultOptionedChild = true;
            treeNodeAdv16.Expanded = true;
            treeNodeAdv16.MultiLine = true;
            treeNodeAdv17.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv17.EnsureDefaultOptionedChild = true;
            treeNodeAdv17.MultiLine = true;
            treeNodeAdv17.Optioned = true;
            treeNodeAdv17.PlusMinusSize = new System.Drawing.Size(9, 9);
            treeNodeAdv17.RightImageIndices = new int[] {
        4,
        4,
        4,
        4};
            treeNodeAdv17.ShowLine = true;
            treeNodeAdv17.Text = "Finding Nemo";
            treeNodeAdv18.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv18.EnsureDefaultOptionedChild = true;
            treeNodeAdv18.MultiLine = true;
            treeNodeAdv18.PlusMinusSize = new System.Drawing.Size(9, 9);
            treeNodeAdv18.RightImageIndices = new int[] {
        4,
        4,
        4,
        4};
            treeNodeAdv18.ShowLine = true;
            treeNodeAdv18.Text = "Lord Of the Rings";
            treeNodeAdv19.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv19.EnsureDefaultOptionedChild = true;
            treeNodeAdv19.MultiLine = true;
            treeNodeAdv19.PlusMinusSize = new System.Drawing.Size(9, 9);
            treeNodeAdv19.RightImageIndices = new int[] {
        4,
        4};
            treeNodeAdv19.ShowLine = true;
            treeNodeAdv19.Text = "Matrix Reloaded";
            treeNodeAdv20.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv20.EnsureDefaultOptionedChild = true;
            treeNodeAdv20.MultiLine = true;
            treeNodeAdv20.PlusMinusSize = new System.Drawing.Size(9, 9);
            treeNodeAdv20.RightImageIndices = new int[] {
        4,
        4,
        4};
            treeNodeAdv20.ShowLine = true;
            treeNodeAdv20.Text = "T3";
            treeNodeAdv21.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv21.EnsureDefaultOptionedChild = true;
            treeNodeAdv21.MultiLine = true;
            treeNodeAdv21.PlusMinusSize = new System.Drawing.Size(9, 9);
            treeNodeAdv21.RightImageIndices = new int[] {
        4,
        4,
        4,
        4};
            treeNodeAdv21.ShowLine = true;
            treeNodeAdv21.Text = "Sea Biscuit";
            treeNodeAdv16.Nodes.AddRange(new Syncfusion.Windows.Forms.Tools.TreeNodeAdv[] {
            treeNodeAdv17,
            treeNodeAdv18,
            treeNodeAdv19,
            treeNodeAdv20,
            treeNodeAdv21});
            treeNodeAdv16.PlusMinusSize = new System.Drawing.Size(9, 9);
            treeNodeAdv16.RightImageIndices = new int[] {
        5};
            treeNodeAdv16.ShowLine = true;
            treeNodeAdv16.Text = "Top 2003 Movies";
            this.treeViewAdv2.Nodes.AddRange(new Syncfusion.Windows.Forms.Tools.TreeNodeAdv[] {
            treeNodeAdv1,
            treeNodeAdv5,
            treeNodeAdv10,
            treeNodeAdv16});
            this.treeViewAdv2.PathSeparator = "/";
            this.treeViewAdv2.RightImageList = this.rightImageList;
            this.treeViewAdv2.SelectedNodeBackground = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218))))));
            this.treeViewAdv2.SelectedNodeForeColor = System.Drawing.SystemColors.HighlightText;
            this.treeViewAdv2.ShowFocusRect = false;
            this.treeViewAdv2.Size = new System.Drawing.Size(312, 461);
            this.treeViewAdv2.Style = Syncfusion.Windows.Forms.Tools.TreeStyle.Metro;
            this.treeViewAdv2.TabIndex = 3;
            this.treeViewAdv2.Text = "treeViewAdv2";
            // 
            // 
            // 
            this.treeViewAdv2.ToolTipControl.BackColor = System.Drawing.SystemColors.Info;
            this.treeViewAdv2.ToolTipControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.treeViewAdv2.ToolTipControl.Location = new System.Drawing.Point(642, 0);
            this.treeViewAdv2.ToolTipControl.Name = "toolTip";
            this.treeViewAdv2.ToolTipControl.Size = new System.Drawing.Size(41, 15);
            this.treeViewAdv2.ToolTipControl.TabIndex = 1;
            this.treeViewAdv2.ToolTipControl.Text = "toolTip";
            this.treeViewAdv2.AfterCheck += new Syncfusion.Windows.Forms.Tools.TreeNodeAdvEventHandler(this.treeViewAdv2_AfterCheck);
            this.treeViewAdv2.NodeEditorValidating += new Syncfusion.Windows.Forms.Tools.TreeNodeAdvCancelableEditEventHandler(this.treeViewAdv2_NodeEditorValidating);
            this.treeViewAdv2.NodeEditorValidated += new Syncfusion.Windows.Forms.Tools.TreeNodeAdvEditEventHandler(this.treeViewAdv2_NodeEditorValidated);
            this.treeViewAdv2.BeforeEdit += new Syncfusion.Windows.Forms.Tools.TreeViewAdvBeforeEditEventHandler(this.treeViewAdv2_BeforeEdit);
            this.treeViewAdv2.Click += new System.EventHandler(this.treeViewAdv2_Click);
            this.treeViewAdv2.StyleChanged += new System.EventHandler(this.TreeViewAdv2_StyleChanged);
            // 
            // contextMenu1
            // 
            this.contextMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.editItem,
            this.copyItem,
            this.cutItem});
            // 
            // editItem
            // 
            this.editItem.Index = 0;
            this.editItem.Text = "&Edit";
            this.editItem.Click += new System.EventHandler(this.editItem_Click);
            // 
            // copyItem
            // 
            this.copyItem.Index = 1;
            this.copyItem.Text = "&Copy";
            this.copyItem.Click += new System.EventHandler(this.copyItem_Click);
            // 
            // cutItem
            // 
            this.cutItem.Index = 2;
            this.cutItem.Text = "Cu&t";
            this.cutItem.Click += new System.EventHandler(this.cutItem_Click);
            // 
            // leftImageList
            // 
            this.leftImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("leftImageList.ImageStream")));
            this.leftImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.leftImageList.Images.SetKeyName(0, "");
            this.leftImageList.Images.SetKeyName(1, "");
            this.leftImageList.Images.SetKeyName(2, "");
            this.leftImageList.Images.SetKeyName(3, "");
            this.leftImageList.Images.SetKeyName(4, "");
            // 
            // rightImageList
            // 
            this.rightImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("rightImageList.ImageStream")));
            this.rightImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.rightImageList.Images.SetKeyName(0, "");
            this.rightImageList.Images.SetKeyName(1, "");
            this.rightImageList.Images.SetKeyName(2, "smiley.ico");
            this.rightImageList.Images.SetKeyName(3, "");
            this.rightImageList.Images.SetKeyName(4, "");
            this.rightImageList.Images.SetKeyName(5, "");
            this.rightImageList.Images.SetKeyName(6, "");
            this.rightImageList.Images.SetKeyName(7, "");
            // 
            // imageList2
            // 
            this.imageList2.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList2.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList2.TransparentColor = System.Drawing.Color.White;
            // 
            // comboBox2
            // 
            this.comboBox2.BackColor = System.Drawing.Color.White;
            this.comboBox2.BeforeTouchSize = new System.Drawing.Size(216, 25);
            this.comboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.Location = new System.Drawing.Point(62, 136);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(216, 25);
            this.comboBox2.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.comboBox2.TabIndex = 12;
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.White;
            this.comboBox1.BeforeTouchSize = new System.Drawing.Size(216, 25);
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.Location = new System.Drawing.Point(62, 80);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(216, 25);
            this.comboBox1.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.comboBox1.TabIndex = 9;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "");
            this.imageList1.Images.SetKeyName(1, "");
            this.imageList1.Images.SetKeyName(2, "");
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.BorderColor = System.Drawing.Color.DarkGray;
            this.gradientPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gradientPanel1.Controls.Add(this.treeViewAdv2);
            this.gradientPanel1.Controls.Add(this.pgGrid);
            this.gradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gradientPanel1.Location = new System.Drawing.Point(10, 10);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(553, 463);
            this.gradientPanel1.TabIndex = 3;
            // 
            // stateImageList
            // 
            this.stateImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("stateImageList.ImageStream")));
            this.stateImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.stateImageList.Images.SetKeyName(0, "");
            this.stateImageList.Images.SetKeyName(1, "");
            this.stateImageList.Images.SetKeyName(2, "");
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 15);
            this.BorderColor = System.Drawing.Color.DarkGray;
            this.CaptionButtonColor = System.Drawing.Color.Black;
            this.CaptionForeColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(573,483);
            this.Controls.Add(this.gradientPanel1);
            this.DropShadow = true;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MetroColor = System.Drawing.Color.White;
            this.MinimumSize = new System.Drawing.Size(50, 300);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GettingStarted";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.treeViewAdv2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel1)).EndInit();
            this.gradientPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

		}

        void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.treeViewAdv2.EndEdit(true);
        }
		#endregion

		#region Main Function Definition
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

        #endregion

        #region DRAG_DROP_UTILS
        private bool IsContinentNode(TreeNodeAdv node)
		{
			if(node.Tag == null
				|| ("Continent").CompareTo(node.Tag.ToString()) != 0)
			{
				return false;
			}
			else
				return true;
		}
		#endregion DRAG_DROP_UTILS
        		
		#region SOURCE_DRAGDROP_LOGIC
		
		private void treeViewAdv_ItemDrag(object sender, System.Windows.Forms.ItemDragEventArgs e)
		{
			TreeViewAdv treeViewAdv = sender as TreeViewAdv;

			// The TreeViewAdv always provides an array of selected nodes.
			TreeNodeAdv[] nodes = e.Item as TreeNodeAdv[];

			// Let us get only the first selected node.
			TreeNodeAdv node = nodes[0];

			// Drag only "country" nodes (non-continent nodes)
			if(!IsContinentNode(node))
			{
				// Only allow move
				DragDropEffects result = treeViewAdv.DoDragDrop(node, DragDropEffects.Move);
			}
            listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] { "ItemDrag", e.Item.ToString() });
        
	
		}

		private void treeViewAdv_QueryContinueDrag(object sender, System.Windows.Forms.QueryContinueDragEventArgs e)
		{
			// Cancel draggin when Escape was pressed.
			if(e.EscapePressed)
			{
				e.Action = DragAction.Cancel;
			}
           	
		}
		#endregion SOURCE_DRAGDROP_LOGIC

					
		#region Delegate Defintion
		
		private void treeViewDragHighlightTracker_QueryDragInsertInfo(object sender, QueryDragInsertInfoEventArgs args)
		{
            args.DragInsertColor = highlighter;
    	}
		
		#endregion

        #region HighLighterColor
        Color highlighter = Color.Red;
        private void HighLighterColor_ButtonClicked(object sender, ButtonClickedEventArgs args)
        {
            colorDialog1.ShowDialog();
            highlighter = colorDialog1.Color;
        }
        #endregion

     
        private void Form1_Load(object sender, EventArgs e)
        {
            this.treeViewAdv2.Nodes[0].Expanded = true;
            this.pgGrid.SelectedGridItemChanged += PgGrid_SelectedGridItemChanged;
            this.pgGrid.PropertyValueChanged += PgGrid_PropertyValueChanged;
            this.treeViewAdv2.Style = TreeStyle.Office2016Colorful;
            //this.CaptionBarColor = ColorTranslator.FromHtml("#0173c7");
            //this.CaptionForeColor = Color.White;
            //this.CaptionButtonColor = Color.White;
            //this.MetroColor = ColorTranslator.FromHtml("#0173c7");
        }

        private void PgGrid_PropertyValueChanged(object s, PropertyValueChangedEventArgs e)
        {
            if(e.ChangedItem.Label == "Style")
            {
                if (this.treeViewAdv2.Style == TreeStyle.Office2016Black)
                {
                    this.CaptionBarColor = ColorTranslator.FromHtml("#252525");
                    this.MetroColor = ColorTranslator.FromHtml("#252525");
                    this.CaptionForeColor = Color.White;
                    this.CaptionButtonColor = Color.White;
                    this.CaptionButtonHoverColor = Color.White;
                    this.BackColor = ColorTranslator.FromHtml("#252525");
                    this.pgGrid.BackColor = ColorTranslator.FromHtml("#252525");
                    this.pgGrid.CategoryForeColor = Color.White;
                    this.pgGrid.ViewBackColor = ColorTranslator.FromHtml("#252525");
                    this.pgGrid.ViewForeColor = Color.White;
                    this.pgGrid.CommandsBackColor = ColorTranslator.FromHtml("#252525");
                    this.pgGrid.CommandsForeColor = Color.White;
#if !SyncfusionFramework2_0

                    this.pgGrid.CategorySplitterColor = Color.Black;
#endif
                    this.pgGrid.CommandsActiveLinkColor = Color.Red;
                    this.pgGrid.LineColor = ColorTranslator.FromHtml("#252525");
                    this.pgGrid.HelpBackColor = ColorTranslator.FromHtml("#252525");
                    this.pgGrid.HelpForeColor = Color.White;
#if !SyncfusionFramework2_0
                    this.pgGrid.HelpBorderColor = Color.DarkGray;
#endif
                    this.treeViewAdv2.BorderColor = ColorTranslator.FromHtml("#9c9c9c");
                    this.scrollersFrame1.VisualStyle = ScrollBarCustomDrawStyles.Office2016;
                    this.scrollersFrame1.Office2016ColorScheme = ScrollBarOffice2016ColorScheme.Black;
                }
                else if (this.treeViewAdv2.Style == TreeStyle.Office2016DarkGray)
                {
                    this.CaptionBarColor = ColorTranslator.FromHtml("#666666");
                    this.MetroColor = ColorTranslator.FromHtml("#666666");
                    this.CaptionForeColor = Color.White;
                    this.CaptionButtonColor = Color.White;
                    this.CaptionButtonHoverColor = Color.White;
                    this.BackColor = ColorTranslator.FromHtml("#666666");
                    this.pgGrid.BackColor = ColorTranslator.FromHtml("#666666");
                    this.pgGrid.CategoryForeColor = Color.White;
                    this.pgGrid.ViewBackColor = ColorTranslator.FromHtml("#666666");
                    this.pgGrid.ViewForeColor = Color.White;
                    this.pgGrid.CommandsBackColor = ColorTranslator.FromHtml("#666666");
                    this.pgGrid.CommandsForeColor = Color.White;
#if !SyncfusionFramework2_0
                    this.pgGrid.CategorySplitterColor = ColorTranslator.FromHtml("#666666");
#endif
                    this.pgGrid.CommandsActiveLinkColor = Color.Red;
                    this.pgGrid.LineColor = ColorTranslator.FromHtml("#969696");
                    this.pgGrid.HelpBackColor = ColorTranslator.FromHtml("#666666");
                    this.pgGrid.HelpForeColor = Color.White;
#if !SyncfusionFramework2_0
                    this.pgGrid.HelpBorderColor = Color.DarkGray;
#endif
                    this.treeViewAdv2.BorderColor = ColorTranslator.FromHtml("#969696");
                }
                else
                {
                    if (this.treeViewAdv2.Style == TreeStyle.Office2016Colorful)
                    {
                        this.MetroColor = Color.White;
                        this.CaptionBarColor = Color.White;
                        this.CaptionForeColor = Color.Black;
                        this.CaptionButtonColor = Color.Black;
                        this.CaptionButtonHoverColor = Color.Black;
                        this.treeViewAdv2.BorderColor = ColorTranslator.FromHtml("#dcdcdc");
                    }
                    if (this.treeViewAdv2.Style == TreeStyle.Office2016White)
                    {
                        this.CaptionBarColor = Color.White;
                        this.CaptionForeColor = Color.Black;
                        this.CaptionButtonColor = Color.Black;
                        this.CaptionButtonHoverColor = Color.Black;
                        this.MetroColor = Color.White;
                        this.treeViewAdv2.BorderColor = ColorTranslator.FromHtml("#dcdcdc");
                    }
                    else
                    {
                        this.CaptionBarColor = ColorTranslator.FromHtml("#ffffff");
                        this.CaptionForeColor = Color.Black;
                        this.CaptionButtonColor = Color.Black;
                        this.MetroColor = Color.White;
                        this.treeViewAdv2.BorderColor = ColorTranslator.FromHtml("#dcdcdc");
                    }

                    this.BackColor = ColorTranslator.FromHtml("#ffffff");
                    this.pgGrid.BackColor = ColorTranslator.FromHtml("#ffffff");
                    this.pgGrid.CategoryForeColor = Color.Black;
                    this.pgGrid.ViewBackColor = ColorTranslator.FromHtml("#ffffff");
                    this.pgGrid.ViewForeColor = Color.Black;
                    this.pgGrid.CommandsBackColor = ColorTranslator.FromHtml("#666666");
                    this.pgGrid.CommandsForeColor = Color.White;
#if !SyncfusionFramework2_0
                    this.pgGrid.CategorySplitterColor = ColorTranslator.FromHtml("#666666");
#endif
                    this.pgGrid.CommandsActiveLinkColor = Color.Red;
                    this.pgGrid.LineColor = ColorTranslator.FromHtml("#dcdcdc");
                    this.pgGrid.HelpBackColor = ColorTranslator.FromHtml("#ffffff");
                    this.pgGrid.HelpForeColor = Color.Black;
#if !SyncfusionFramework2_0
                    this.pgGrid.HelpBorderColor = Color.DarkGray;
#endif
                }
            }
        }

        private void PgGrid_SelectedGridItemChanged(object sender, SelectedGridItemChangedEventArgs e)
        {
            this.scrollersFrame1.VisualStyle = ScrollBarCustomDrawStyles.Office2016;
           
        }


        private void TreeViewAdv2_StyleChanged(object sender, EventArgs e)
        {
         
        }

        private void treeViewAdv2_BeforeExpand(object sender, TreeViewAdvCancelableNodeEventArgs e)
        {
            try
            {
                //Checking Whether the Node has been  expanded atleast once
                if (e.Node.ExpandedOnce) return;

                //Get the Path of the node and AddSeparatorAtEnd Property set to true
                string path = e.Node.GetPath("\\");

                //Get an Array of Directories from the current directory path
                ArrayList dirs = new ArrayList(Directory.GetDirectories(path));

                //Add the Directories as a node in TreeViewAdv
                for (int i = 0; i < dirs.Count; i++)
                {
                    string dir = (string)dirs[i];
                    int lastIndex = dir.LastIndexOf("\\") + 1;
                    TreeNodeAdv node = new TreeNodeAdv(dir.Substring(lastIndex));
                    e.Node.Nodes.Add(node);
                }
            }
            catch (Exception)
            {
            }
        }

        private void treeViewAdv3_BeforeExpand(object sender, TreeViewAdvCancelableNodeEventArgs e)
        {
            try
            {

                //Checking Whether the Node has been  expanded atleast once
                if (e.Node.ExpandedOnce) return;

                //Get the Path of the node and AddSeparatorAtEnd Property set to true
                string path = e.Node.GetPath("\\");

                //Get an Array of Directories from the current directory path
                ArrayList dirs = new ArrayList(Directory.GetDirectories(path));

                //Add the Directories as a node in TreeViewAdv
                for (int i = 0; i < dirs.Count; i++)
                {
                    string dir = (string)dirs[i];
                    int lastIndex = dir.LastIndexOf("\\") + 1;
                    TreeNodeAdv node = new TreeNodeAdv(dir.Substring(lastIndex));
                    // Make the node's Tag same as Text for demo purposes.
                    node.Tag = node.Text;
                    e.Node.Nodes.Add(node);
                }
            }
            catch (Exception)
            { }
        }
        BrushInfo br = new BrushInfo(GradientStyle.PathEllipse, Color.Beige, Color.Beige);

        private void treeViewAdv3_BeforeNodePaint(object sender, TreeNodeAdvPaintEventArgs e)
        {
            //Draw the BackGround color for the Selected node
            if (e.Selected)
            {

                BrushPaint.FillRectangle(e.Graphics, e.Bounds, br);
                e.ForeColor = SystemColors.WindowText;
            }
        }


        private void treeViewAdv2_AfterCheck(object sender, TreeNodeAdvEventArgs e)
        {
            // Update the Marital Status icon based on the current selection
            if (this.treeViewAdv2.Nodes[0].Nodes[0].Optioned)
                // If single selected
                this.treeViewAdv2.Root.Nodes[0].RightImageIndices[0] = 2;
            else
                // if married or with children
                this.treeViewAdv2.Root.Nodes[0].RightImageIndices[0] = 3;
            this.treeViewAdv2.Invalidate();
        }

        private void treeViewAdv2_BeforeEdit(object sender, TreeNodeAdvBeforeEditEventArgs e)
        {
            // Let us prevent editing the top-level nodes.
            if (e.Node.Parent == this.treeViewAdv2.Root)
            {
                e.Cancel = true;
                MessageBox.Show("Node editing canceled for top-level nodes in the BeforeEdit event handler.");
            }
        }

        private void treeViewAdv2_NodeEditorValidated(object sender, TreeNodeAdvEditEventArgs e)
        {
            // Typically, you might have to update the bound data source, if any, with the new Label.
           // e.Node.Text = e.Node.Text.ToUpper();
        }

        private void treeViewAdv2_NodeEditorValidating(object sender, TreeNodeAdvCancelableEditEventArgs e)
        {
            if (e.Label.Length > 0)
            {
                if (e.Label.IndexOfAny(new char[] { '@', '.', ',', '!' }) != -1)
                {
                    /* Cancel the label edit action, inform the user, and 
                        place the node in edit mode again. */
                    e.Cancel = true;
                    MessageBox.Show("Invalid tree node label.\n" +
                        "The invalid characters are: '@','.', ',', '!'",
                        "Node Label Edit");
                }
            }
            else
            {
                /* Cancel the label edit action, inform the user, and 
                    place the node in edit mode again. */
                e.Cancel = true;
                MessageBox.Show("Invalid tree node label.\nThe label cannot be blank",
                    "Node Label Edit");
                // To end editing mode, do this:
                // e.ContinueEditing = false;
            }
        }
#region CONTEXTMENU

        private TreeNodeAdv rightMouseDownNodeCached = null;
        private void editItem_Click(object sender, System.EventArgs e)
        {
            if (this.treeViewAdv2 != null)
                this.rightMouseDownNodeCached = this.treeViewAdv2.ActiveNode;
            if (this.rightMouseDownNodeCached != null)
                // You can also alternatively turn on F2 label editing for all nodes via 
                // the LabelEdit property of the tree.
                this.treeViewAdv2.BeginEdit(this.rightMouseDownNodeCached);
        }

        private void cutItem_Click(object sender, System.EventArgs e)
        {
            MessageBox.Show("Not Implemented. Only Edit menu is implemented.");
        }

        private void copyItem_Click(object sender, System.EventArgs e)
        {
            MessageBox.Show("Not Implemented. Only Edit menu is implemented.");
        }
#endregion CONTEXTMENU

#region Form Event Handler

        private void Form1_Closing(object sender, CancelEventArgs e)
        {
            // End editing before the form closes
            this.treeViewAdv2.EndEdit(true);
        }
        #endregion

        private void pgGrid_Click(object sender, EventArgs e)
        {

        }

        private void treeViewAdv2_Click(object sender, EventArgs e)
        {

        }
    }
#endregion
}


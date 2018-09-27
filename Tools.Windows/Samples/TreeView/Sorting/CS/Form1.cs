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
        private TreeViewAdv treeViewAdv3;
        private ImageList imageList2;
        private GradientPanel gradientPanel2;
        private ComboBoxAdv comboBox2;
        private Label label2;
        private Label label5;
        private ComboBoxAdv comboBox1;
        private ButtonAdv button1;
        private ImageList leftImageList;
        private ContextMenu contextMenu1;
        private MenuItem editItem;
        private MenuItem copyItem;
        private MenuItem cutItem;
        private ImageList rightImageList;
        private ImageList stateImageList;
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
            Syncfusion.Windows.Forms.Tools.TreeNodeAdv treeNodeAdv1 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdv();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.scrollersFrame1 = new Syncfusion.Windows.Forms.ScrollersFrame(this.components);
            this.treeViewAdv3 = new Syncfusion.Windows.Forms.Tools.TreeViewAdv();
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.gradientPanel2 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            this.comboBox2 = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox1 = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.button1 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.contextMenu1 = new System.Windows.Forms.ContextMenu();
            this.editItem = new System.Windows.Forms.MenuItem();
            this.copyItem = new System.Windows.Forms.MenuItem();
            this.cutItem = new System.Windows.Forms.MenuItem();
            this.leftImageList = new System.Windows.Forms.ImageList(this.components);
            this.rightImageList = new System.Windows.Forms.ImageList(this.components);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.gradientPanel1 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            this.colorDialog2 = new System.Windows.Forms.ColorDialog();
            this.stateImageList = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.treeViewAdv3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel2)).BeginInit();
            this.gradientPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel1)).BeginInit();
            this.gradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // scrollersFrame1
            // 
            this.scrollersFrame1.CustomRender = null;
            this.scrollersFrame1.HorizontalSmallChange = 7;
            this.scrollersFrame1.MetroColorScheme = Syncfusion.Windows.Forms.MetroColorScheme.Managed;
            this.scrollersFrame1.MetroThumbSize = new System.Drawing.Size(0, 0);
            metroColorTable1.ArrowChecked = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(149)))), ((int)(((byte)(152)))));
            metroColorTable1.ArrowInActive = System.Drawing.Color.White;
            metroColorTable1.ArrowNormal = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(198)))), ((int)(((byte)(198)))));
            metroColorTable1.ArrowNormalBackGround = System.Drawing.Color.Empty;
            metroColorTable1.ArrowPushed = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(89)))), ((int)(((byte)(90)))));
            metroColorTable1.ArrowPushedBackGround = System.Drawing.Color.Empty;
            metroColorTable1.ScrollerBackground = System.Drawing.Color.White;
            metroColorTable1.ThumbChecked = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(149)))), ((int)(((byte)(152)))));
            metroColorTable1.ThumbInActive = System.Drawing.Color.White;
            metroColorTable1.ThumbNormal = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(198)))), ((int)(((byte)(198)))));
            metroColorTable1.ThumbPushed = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(89)))), ((int)(((byte)(90)))));
            metroColorTable1.ThumbPushedBorder = System.Drawing.Color.Empty;
            this.scrollersFrame1.ScrollMetroColorTable = metroColorTable1;
            this.scrollersFrame1.ShowMetroArrowButton = true;
            this.scrollersFrame1.SizeGripperVisibility = Syncfusion.Windows.Forms.SizeGripperVisibility.Auto;
            this.scrollersFrame1.VerticallSmallChange = 13;
            this.scrollersFrame1.VisualStyle = Syncfusion.Windows.Forms.ScrollBarCustomDrawStyles.Metro;
            // 
            // treeViewAdv3
            // 
            this.treeViewAdv3.AddSeparatorAtEnd = true;
            this.treeViewAdv3.AllowDrop = true;
            this.treeViewAdv3.BackColor = System.Drawing.Color.White;
            this.treeViewAdv3.BeforeTouchSize = new System.Drawing.Size(279, 461);
            this.treeViewAdv3.Border3DStyle = System.Windows.Forms.Border3DStyle.Flat;
            this.treeViewAdv3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.treeViewAdv3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeViewAdv3.Font = new System.Drawing.Font("Verdana", 8F);
            // 
            // 
            // 
            this.treeViewAdv3.HelpTextControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.treeViewAdv3.HelpTextControl.Location = new System.Drawing.Point(732, 0);
            this.treeViewAdv3.HelpTextControl.Name = "helpText";
            this.treeViewAdv3.HelpTextControl.Size = new System.Drawing.Size(49, 15);
            this.treeViewAdv3.HelpTextControl.TabIndex = 0;
            this.treeViewAdv3.HelpTextControl.Text = "help text";
            this.treeViewAdv3.IgnoreThemeBackground = true;
            this.treeViewAdv3.InactiveSelectedNodeForeColor = System.Drawing.SystemColors.ControlText;
            this.treeViewAdv3.Indent = 20;
            this.treeViewAdv3.LineColor = System.Drawing.Color.Transparent;
            this.treeViewAdv3.LoadOnDemand = true;
            this.treeViewAdv3.Location = new System.Drawing.Point(299, 0);
            this.treeViewAdv3.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218)))));
            this.treeViewAdv3.Name = "treeViewAdv3";
            treeNodeAdv1.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv1.EnsureDefaultOptionedChild = true;
            treeNodeAdv1.MultiLine = true;
            treeNodeAdv1.PlusMinusSize = new System.Drawing.Size(9, 9);
            treeNodeAdv1.ShowLine = true;
            treeNodeAdv1.Text = "c:";
            this.treeViewAdv3.Nodes.AddRange(new Syncfusion.Windows.Forms.Tools.TreeNodeAdv[] {
            treeNodeAdv1});
            this.treeViewAdv3.PathSeparator = "/";
            this.treeViewAdv3.SelectedNodeBackground = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218))))));
            this.treeViewAdv3.SelectedNodeForeColor = System.Drawing.SystemColors.HighlightText;
            this.treeViewAdv3.ShowCheckBoxes = true;
            this.treeViewAdv3.ShowFocusRect = false;
            this.treeViewAdv3.ShowOptionButtons = true;
            this.treeViewAdv3.Size = new System.Drawing.Size(279, 461);
            this.treeViewAdv3.StateImageList = this.imageList2;
            this.treeViewAdv3.Style = Syncfusion.Windows.Forms.Tools.TreeStyle.Metro;
            this.treeViewAdv3.TabIndex = 5;
            this.treeViewAdv3.ThemesEnabled = false;
            // 
            // 
            // 
            this.treeViewAdv3.ToolTipControl.BackColor = System.Drawing.SystemColors.Info;
            this.treeViewAdv3.ToolTipControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.treeViewAdv3.ToolTipControl.Location = new System.Drawing.Point(642, 0);
            this.treeViewAdv3.ToolTipControl.Name = "toolTip";
            this.treeViewAdv3.ToolTipControl.Size = new System.Drawing.Size(41, 15);
            this.treeViewAdv3.ToolTipControl.TabIndex = 1;
            this.treeViewAdv3.ToolTipControl.Text = "toolTip";
            this.treeViewAdv3.BeforeExpand += new Syncfusion.Windows.Forms.Tools.TreeViewAdvCancelableNodeEventHandler(this.treeViewAdv3_BeforeExpand);
            this.treeViewAdv3.BeforeNodePaint += new Syncfusion.Windows.Forms.Tools.TreeNodeAdvPaintEventHandler(this.treeViewAdv3_BeforeNodePaint);
            // 
            // imageList2
            // 
            this.imageList2.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList2.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList2.TransparentColor = System.Drawing.Color.White;
            // 
            // gradientPanel2
            // 
            this.gradientPanel2.Border3DStyle = System.Windows.Forms.Border3DStyle.Etched;
            this.gradientPanel2.BorderSides = System.Windows.Forms.Border3DSide.Left;
            this.gradientPanel2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gradientPanel2.Controls.Add(this.comboBox2);
            this.gradientPanel2.Controls.Add(this.label2);
            this.gradientPanel2.Controls.Add(this.label5);
            this.gradientPanel2.Controls.Add(this.comboBox1);
            this.gradientPanel2.Controls.Add(this.button1);
            this.gradientPanel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.gradientPanel2.Location = new System.Drawing.Point(0, 0);
            this.gradientPanel2.Name = "gradientPanel2";
            this.gradientPanel2.Size = new System.Drawing.Size(299, 461);
            this.gradientPanel2.TabIndex = 6;
            // 
            // comboBox2
            // 
            this.comboBox2.BackColor = System.Drawing.Color.White;
            this.comboBox2.BeforeTouchSize = new System.Drawing.Size(216, 21);
            this.comboBox2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.Items.AddRange(new object[] {
            "Text",
            "CheckBox",
            "Tag"});
            this.comboBox2.Location = new System.Drawing.Point(62, 136);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(216, 21);
            this.comboBox2.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.comboBox2.TabIndex = 12;
            this.comboBox2.Text = "Text";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(62, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Sort Type";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(62, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Sort Order";
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.White;
            this.comboBox1.BeforeTouchSize = new System.Drawing.Size(216, 21);
            this.comboBox1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.Items.AddRange(new object[] {
            "None",
            "Ascending",
            "Descending"});
            this.comboBox1.Location = new System.Drawing.Point(62, 80);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(216, 21);
            this.comboBox1.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.comboBox1.TabIndex = 9;
            this.comboBox1.Text = "None";
            // 
            // button1
            // 
            this.button1.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218)))));
            this.button1.BeforeTouchSize = new System.Drawing.Size(136, 23);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.IsBackStageButton = false;
            this.button1.Location = new System.Drawing.Point(105, 218);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Sort selected node";
            this.button1.UseVisualStyle = true;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.gradientPanel1.Controls.Add(this.treeViewAdv3);
            this.gradientPanel1.Controls.Add(this.gradientPanel2);
            this.gradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gradientPanel1.Location = new System.Drawing.Point(10, 10);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(580, 463);
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
            this.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(229)))));
            this.CaptionBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218)))));
            this.CaptionButtonColor = System.Drawing.Color.White;
            this.CaptionFont = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.CaptionForeColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(600, 483);
            this.Controls.Add(this.gradientPanel1);
            this.DropShadow = true;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(50, 300);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TreeViewAdv Sorting";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.treeViewAdv3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel2)).EndInit();
            this.gradientPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.comboBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel1)).EndInit();
            this.gradientPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

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

		#region DEST_DRAGDROP_LOGIC

		// Helps keep track of the node that is being dragged.
		private TreeNodeAdv currentSourceNode;

		
		
		#endregion DEST_DRAGDROP_LOGIC
			

        #region HighLighterColor
        Color highlighter = Color.Red;
        private void HighLighterColor_ButtonClicked(object sender, ButtonClickedEventArgs args)
        {
            colorDialog1.ShowDialog();
            highlighter = colorDialog1.Color;
        }
        #endregion

        #region ShowDragNodeCue
      
        
        #endregion

        private void Form1_Load(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            //Checking the Selected Nodes is null
            if (this.treeViewAdv3.SelectedNode == null) return;


            if (treeViewAdv3.SelectedNode.Expanded == false || !treeViewAdv3.SelectedNode.HasChildren)
            {
                //Display the Message Box when the Node has no children
                MessageBox.Show("The selected node isn`t expanded or hasn`t got child nodes to sort");
            }

            switch (this.comboBox1.SelectedIndex)
            {
                case 0: treeViewAdv3.SelectedNode.SortOrder = SortOrder.None; break;

                //Sorting the Nodes  in Ascending order
                case 1: treeViewAdv3.SelectedNode.SortOrder = SortOrder.Ascending; break;

                //Sorting the Nodes in Descending order
                case 2: treeViewAdv3.SelectedNode.SortOrder = SortOrder.Descending; break;
            }
            switch (this.comboBox2.SelectedIndex)
            {
                //Sort the node based on the node Text
                case 0: treeViewAdv3.SelectedNode.SortType = TreeNodeAdvSortType.Text; break;

                //Sort the node based on the value of the CheckBox
                case 1: treeViewAdv3.SelectedNode.SortType = TreeNodeAdvSortType.CheckBox; break;
                //Sort the nodes based on the node Tag
                case 2: treeViewAdv3.SelectedNode.SortType = TreeNodeAdvSortType.Tag; break;
            }

            treeViewAdv3.SelectedNode.Sort();
        }

        #region CONTEXTMENU

        private TreeNodeAdv rightMouseDownNodeCached = null;
        private void editItem_Click(object sender, System.EventArgs e)
        {
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
        

    }
#endregion
}


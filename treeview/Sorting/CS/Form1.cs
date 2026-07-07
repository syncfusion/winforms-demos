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
using Syncfusion.WinForms.Controls;
#if NETCORE
using ContextMenu = System.Windows.Forms.ContextMenuStrip;
using MenuItem = System.Windows.Forms.ToolStripMenuItem;
#else
using ContextMenu = System.Windows.Forms.ContextMenu;
using MenuItem = System.Windows.Forms.MenuItem;
#endif
namespace TreeViewAdvDragDrop
{
	#region Class Form1 Description
	
	public class Form1 : SfForm
	{
	
		#region Variable Declaration

        // Use the tracker only when you want to support dropping adjacent (above or below) to a node.
		// Otherwise simply listen to the DragOver and DragDrop events and provide/use the DropEffect.
		// When used this tracker will draw indicators above or below a node while dragging an item
		// over the node. The tracker need to be updated as shown below in the DragXXX events.
        private ColorDialog colorDialog1;
        private IContainer components;
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
        private Panel panel1;
		#endregion

		#region Form Constructor Initialization and Disposing
		
		public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
            this.MinimumSize = this.Size;
            
            this.treeViewAdv3.ThemeName = "Office2019Colorful";
            this.comboBox1.ThemeName = "Office2019Colorful";
            this.comboBox2.ThemeName = "Office2019Colorful";
            this.button1.ThemeName = "Office2019Colorful";
            this.treeViewAdv3.Nodes[0].Expand();
            this.treeViewAdv3.SelectedNode = this.treeViewAdv3.Nodes[0];
            treeViewAdv3.SelectedNode.SortOrder = SortOrder.Ascending;
            treeViewAdv3.SelectedNode.SortType = TreeNodeAdvSortType.Text;
            this.comboBox1.SelectedIndex = 1;
            this.comboBox2.SelectedIndex = 0;
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

        #region "Image Loading Methods"
        //Get and Load the images
#if NET9_0_OR_GREATER
        private Image GetImage(string path)
        {
            System.Reflection.Assembly asm = System.Reflection.Assembly.GetExecutingAssembly();
            if (asm != null && !string.IsNullOrEmpty(path))
                return Image.FromStream(asm.GetManifestResourceStream(path));
            return null;
        }

        private void LoadImages(ImageList imageList, string folder, int count)
        {
            for (int i = 1; i <= count; i++)
            {
                string imagePath = ($"TreeViewAdvDragDrop.Images.{folder}.Image_{i}.png");
                imageList.Images.Add(GetImage(imagePath));
            }
        }
#endif
        #endregion


        #region Windows Form Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            Syncfusion.Windows.Forms.Tools.TreeNodeAdvStyleInfo treeNodeAdvStyleInfo1 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdvStyleInfo();
            Syncfusion.Windows.Forms.Tools.TreeNodeAdv treeNodeAdv1 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdv();
            Syncfusion.Windows.Forms.Tools.TreeViewAdvVisualStyle treeViewAdvVisualStyle1 = new Syncfusion.Windows.Forms.Tools.TreeViewAdvVisualStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.treeViewAdv3 = new Syncfusion.Windows.Forms.Tools.TreeViewAdv();
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.gradientPanel2 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            this.comboBox2 = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox1 = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.button1 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.contextMenu1 = new ContextMenu();
            this.editItem = new MenuItem();
            this.copyItem = new MenuItem();
            this.cutItem = new MenuItem();
            this.leftImageList = new System.Windows.Forms.ImageList(this.components);
            this.rightImageList = new System.Windows.Forms.ImageList(this.components);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.gradientPanel1 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            this.panel1 = new System.Windows.Forms.Panel();
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
            // treeViewAdv3
            // 
            this.treeViewAdv3.AddSeparatorAtEnd = true;
            this.treeViewAdv3.AllowDrop = true;
            this.treeViewAdv3.BackColor = System.Drawing.Color.White;
            this.treeViewAdv3.BackgroundColor = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255))))));
            treeNodeAdvStyleInfo1.CheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            treeNodeAdvStyleInfo1.EnsureDefaultOptionedChild = true;
            treeNodeAdvStyleInfo1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            treeNodeAdvStyleInfo1.InteractiveCheckBox = true;
            treeNodeAdvStyleInfo1.IntermediateCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            treeNodeAdvStyleInfo1.OptionButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            treeNodeAdvStyleInfo1.SelectedOptionButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            treeNodeAdvStyleInfo1.ShowCheckBox = true;
            treeNodeAdvStyleInfo1.ShowOptionButton = false;
            treeNodeAdvStyleInfo1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            treeNodeAdvStyleInfo1.ThemesEnabled = false;
            this.treeViewAdv3.BaseStylePairs.AddRange(new Syncfusion.Windows.Forms.Tools.StyleNamePair[] {
            new Syncfusion.Windows.Forms.Tools.StyleNamePair("Standard", treeNodeAdvStyleInfo1)});
            this.treeViewAdv3.BeforeTouchSize = new System.Drawing.Size(470, 463);
            this.treeViewAdv3.Border3DStyle = System.Windows.Forms.Border3DStyle.Flat;
            this.treeViewAdv3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.treeViewAdv3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.treeViewAdv3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeViewAdv3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeViewAdv3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
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
            this.treeViewAdv3.InteractiveCheckBoxes = true;
            this.treeViewAdv3.ItemHeight = 25;
            this.treeViewAdv3.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(94)))), ((int)(((byte)(94)))));
            this.treeViewAdv3.LoadOnDemand = true;
            this.treeViewAdv3.Location = new System.Drawing.Point(0, 0);
            this.treeViewAdv3.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218)))));
            this.treeViewAdv3.Name = "treeViewAdv3";
            treeNodeAdv1.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv1.EnsureDefaultOptionedChild = true;
            treeNodeAdv1.MultiLine = true;
            treeNodeAdv1.ShowLine = true;
            treeNodeAdv1.Text = "Local Disk (C:)";
            this.treeViewAdv3.Nodes.AddRange(new Syncfusion.Windows.Forms.Tools.TreeNodeAdv[] {
            treeNodeAdv1});
            this.treeViewAdv3.PathSeparator = "/";
            this.treeViewAdv3.SelectedNodeBackground = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197))))));
            this.treeViewAdv3.SelectedNodeForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.treeViewAdv3.ShowCheckBoxes = true;
            this.treeViewAdv3.ShowFocusRect = false;
            this.treeViewAdv3.Size = new System.Drawing.Size(470, 463);
            this.treeViewAdv3.StateImageList = this.imageList2;
            this.treeViewAdv3.Style = Syncfusion.Windows.Forms.Tools.TreeStyle.Office2016Colorful;
            this.treeViewAdv3.TabIndex = 5;
            this.treeViewAdv3.ThemeName = "Office2016Colorful";
            this.treeViewAdv3.ThemesEnabled = false;
            treeViewAdvVisualStyle1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            treeViewAdvVisualStyle1.TreeNodeAdvStyle.CheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            treeViewAdvVisualStyle1.TreeNodeAdvStyle.EnsureDefaultOptionedChild = true;
            treeViewAdvVisualStyle1.TreeNodeAdvStyle.IntermediateCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            treeViewAdvVisualStyle1.TreeNodeAdvStyle.OptionButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            treeViewAdvVisualStyle1.TreeNodeAdvStyle.SelectedOptionButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.treeViewAdv3.ThemeStyle = treeViewAdvVisualStyle1;
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
            this.treeViewAdv3.TransparentControls = true;
            this.treeViewAdv3.BeforeExpand += new Syncfusion.Windows.Forms.Tools.TreeViewAdvCancelableNodeEventHandler(this.treeViewAdv3_BeforeExpand);
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
            this.gradientPanel2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.gradientPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gradientPanel2.Controls.Add(this.comboBox2);
            this.gradientPanel2.Controls.Add(this.label2);
            this.gradientPanel2.Controls.Add(this.label5);
            this.gradientPanel2.Controls.Add(this.comboBox1);
            this.gradientPanel2.Controls.Add(this.button1);
            this.gradientPanel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.gradientPanel2.Location = new System.Drawing.Point(478, 0);
            this.gradientPanel2.Name = "gradientPanel2";
            this.gradientPanel2.Size = new System.Drawing.Size(261, 463);
            this.gradientPanel2.TabIndex = 6;
            // 
            // comboBox2
            // 
            this.comboBox2.BeforeTouchSize = new System.Drawing.Size(216, 25);
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.comboBox2.Items.AddRange(new object[] {
            "Text",
            "CheckBox",
            "Tag"});
            this.comboBox2.Location = new System.Drawing.Point(25, 168);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(216, 25);
            this.comboBox2.TabIndex = 12;
            this.comboBox2.Text = "Text";
            this.comboBox2.ThemeName = "Default";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Sort Type :";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(25, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Sort Order :";
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.White;
            this.comboBox1.BeforeTouchSize = new System.Drawing.Size(216, 25);
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.Items.AddRange(new object[] {
            "None",
            "Ascending",
            "Descending"});
            this.comboBox1.Location = new System.Drawing.Point(25, 112);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(216, 25);
            this.comboBox1.TabIndex = 9;
            this.comboBox1.Text = "None";
            // 
            // button1
            // 
            this.button1.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218)))));
            this.button1.BeforeTouchSize = new System.Drawing.Size(142, 23);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.IsBackStageButton = false;
            this.button1.Location = new System.Drawing.Point(60, 228);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Apply";
            this.button1.ThemeName = "Metro";
            this.button1.UseVisualStyle = true;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // contextMenu1
            // 
#if NETCORE
            this.contextMenu1.Items.AddRange(new MenuItem[] {
#else
            this.contextMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
#endif
            this.editItem,
            this.copyItem,
            this.cutItem});
            // 
            // editItem
            // 
#if NETCORE
            this.editItem.MergeIndex = 0;
#else
            this.editItem.Index = 0;
#endif
            this.editItem.Text = "&Edit";
            this.editItem.Click += new System.EventHandler(this.editItem_Click);
            // 
            // copyItem
            // 
#if NETCORE
            this.copyItem.MergeIndex = 1;
#else
            this.copyItem.Index = 1;
#endif
            this.copyItem.Text = "&Copy";
            this.copyItem.Click += new System.EventHandler(this.copyItem_Click);
            // 
            // cutItem
            // 
#if NETCORE
            this.cutItem.MergeIndex = 2;
#else
            this.cutItem.Index = 2;
#endif
            this.cutItem.Text = "Cu&t";
            this.cutItem.Click += new System.EventHandler(this.cutItem_Click);
            // 
            // leftImageList
            // 
#if NET9_0_OR_GREATER
            LoadImages(this.leftImageList, "LeftImageList", 8);
#else
            this.leftImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("leftImageList.ImageStream")));
#endif
            this.leftImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.leftImageList.Images.SetKeyName(0, "");
            this.leftImageList.Images.SetKeyName(1, "");
            this.leftImageList.Images.SetKeyName(2, "");
            this.leftImageList.Images.SetKeyName(3, "");
            this.leftImageList.Images.SetKeyName(4, "");
            // 
            // rightImageList
            // 
#if NET9_0_OR_GREATER
            LoadImages(this.rightImageList, "RightImageList", 8);
#else
            this.rightImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("rightImageList.ImageStream")));
#endif
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
            this.gradientPanel1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gradientPanel1.Controls.Add(this.treeViewAdv3);
            this.gradientPanel1.Controls.Add(this.panel1);
            this.gradientPanel1.Controls.Add(this.gradientPanel2);
            this.gradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gradientPanel1.Location = new System.Drawing.Point(10, 10);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(739, 463);
            this.gradientPanel1.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(470, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(8, 463);
            this.panel1.TabIndex = 7;
            // 
            // stateImageList
            // 
#if NET9_0_OR_GREATER
            LoadImages(this.stateImageList, "StateImageList", 8);
#else
            this.stateImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("stateImageList.ImageStream")));
#endif
            this.stateImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.stateImageList.Images.SetKeyName(0, "");
            this.stateImageList.Images.SetKeyName(1, "");
            this.stateImageList.Images.SetKeyName(2, "");
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 18);
            this.ClientSize = new System.Drawing.Size(759, 483);
            this.Controls.Add(this.gradientPanel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(50, 300);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sorting";
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
            SkinManager.LoadAssembly(typeof(Syncfusion.WinForms.Themes.Office2019Theme).Assembly);
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

        private void treeViewAdv3_BeforeExpand(object sender, TreeViewAdvCancelableNodeEventArgs e)
        {
            try
            {

                //Checking Whether the Node has been  expanded atleast once
                if (e.Node.ExpandedOnce) return;

                //Get the Path of the node and AddSeparatorAtEnd Property set to true
                string path = "C:\\";

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


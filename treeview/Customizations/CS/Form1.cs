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
using System.Diagnostics;

using Syncfusion.Windows.Forms;
using Syncfusion.Windows.Forms.Tools;
using System.IO;
using Syncfusion.Drawing;
using Syncfusion.Licensing;
using Syncfusion.WinForms.Controls;

namespace _TreeViewAdvImageOverLayingDemo
{
	#region Class Form1 Description
	
	public class Form1 : SfForm
	{
	
		#region Variable Declaration

        // Use the tracker only when you want to support dropping adjacent (above or below) to a node.
		// Otherwise simply listen to the DragOver and DragDrop events and provide/use the DropEffect.
		// When used this tracker will draw indicators above or below a node while dragging an item
		// over the node. The tracker need to be updated as shown below in the DragXXX events.
        private IContainer components;
        private ImageList leftImageList;
        private ImageList rightImageList;
        private ImageList stateImageList;
        private TreeViewAdv treeViewAdv2;
        private ButtonAdv buttonAdv1;
        private GradientPanel gradientPanel1;
		#endregion

		#region Form Constructor Initialization and Disposing
		
		public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
            this.MinimumSize = this.Size;
            this.treeViewAdv2.ThemeName = "Office2019Colorful";
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
                string imagePath = ($"_TreeViewAdvImageOverLayingDemo.Images.{folder}.Image_{i}.png");
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
            Syncfusion.Windows.Forms.Tools.TreeViewAdvVisualStyle treeViewAdvVisualStyle1 = new Syncfusion.Windows.Forms.Tools.TreeViewAdvVisualStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.gradientPanel1 = new GradientPanel();
           this.treeViewAdv2 = new Syncfusion.Windows.Forms.Tools.TreeViewAdv();
            this.leftImageList = new System.Windows.Forms.ImageList(this.components);
            this.rightImageList = new System.Windows.Forms.ImageList(this.components);
            this.buttonAdv1 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.stateImageList = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.treeViewAdv2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel1)).BeginInit();
            this.SuspendLayout();
          
            // 
            // treeViewAdv2
            // 
            this.treeViewAdv2.AllowDrop = true;
            this.treeViewAdv2.BackColor = System.Drawing.Color.White;
            treeNodeAdvStyleInfo1.CheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            treeNodeAdvStyleInfo1.EnsureDefaultOptionedChild = true;
            treeNodeAdvStyleInfo1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            treeNodeAdvStyleInfo1.IntermediateCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            treeNodeAdvStyleInfo1.NoChildrenImgIndex = -1;
            treeNodeAdvStyleInfo1.OptionButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            treeNodeAdvStyleInfo1.SelectedOptionButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            treeNodeAdvStyleInfo1.TextColor = System.Drawing.Color.Black;
            this.treeViewAdv2.BaseStylePairs.AddRange(new Syncfusion.Windows.Forms.Tools.StyleNamePair[] {
            new Syncfusion.Windows.Forms.Tools.StyleNamePair("Standard", treeNodeAdvStyleInfo1)});
            this.treeViewAdv2.BeforeTouchSize = new System.Drawing.Size(766, 499);
            this.treeViewAdv2.Border3DStyle = System.Windows.Forms.Border3DStyle.Flat;
            this.treeViewAdv2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
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
            this.treeViewAdv2.ItemHeight = 25;
            this.treeViewAdv2.LeftImageList = this.leftImageList;
            this.treeViewAdv2.Location = new System.Drawing.Point(10, 52);
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
            treeNodeAdv2.ShowLine = true;
            treeNodeAdv2.ShowOptionButton = true;
            treeNodeAdv2.Text = "Single";
            treeNodeAdv3.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv3.EnsureDefaultOptionedChild = true;
            treeNodeAdv3.MultiLine = true;
            treeNodeAdv3.ShowLine = true;
            treeNodeAdv3.ShowOptionButton = true;
            treeNodeAdv3.Text = "Married";
            treeNodeAdv4.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv4.EnsureDefaultOptionedChild = true;
            treeNodeAdv4.MultiLine = true;
            treeNodeAdv4.ShowLine = true;
            treeNodeAdv4.ShowOptionButton = true;
            treeNodeAdv4.Text = "Married with children";
            treeNodeAdv1.Nodes.AddRange(new Syncfusion.Windows.Forms.Tools.TreeNodeAdv[] {
            treeNodeAdv2,
            treeNodeAdv3,
            treeNodeAdv4});
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
            treeNodeAdv6.ShowCheckBox = true;
            treeNodeAdv6.ShowLine = true;
            treeNodeAdv6.Text = "Hepatitis B";
            treeNodeAdv7.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv7.EnsureDefaultOptionedChild = true;
            treeNodeAdv7.MultiLine = true;
            treeNodeAdv7.ShowCheckBox = true;
            treeNodeAdv7.ShowLine = true;
            treeNodeAdv7.Text = "Tetanus";
            treeNodeAdv8.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv8.EnsureDefaultOptionedChild = true;
            treeNodeAdv8.MultiLine = true;
            treeNodeAdv8.ShowCheckBox = true;
            treeNodeAdv8.ShowLine = true;
            treeNodeAdv8.Text = "Polio ";
            treeNodeAdv9.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv9.EnsureDefaultOptionedChild = true;
            treeNodeAdv9.MultiLine = true;
            treeNodeAdv9.ShowCheckBox = true;
            treeNodeAdv9.ShowLine = true;
            treeNodeAdv9.Text = "Measles";
            treeNodeAdv5.Nodes.AddRange(new Syncfusion.Windows.Forms.Tools.TreeNodeAdv[] {
            treeNodeAdv6,
            treeNodeAdv7,
            treeNodeAdv8,
            treeNodeAdv9});
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
            treeNodeAdv11.ShowLine = true;
            treeNodeAdv11.Text = "Canada";
            treeNodeAdv12.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv12.EnsureDefaultOptionedChild = true;
            treeNodeAdv12.LeftImageIndices = new int[] {
        1};
            treeNodeAdv12.MultiLine = true;
            treeNodeAdv12.ShowLine = true;
            treeNodeAdv12.Text = "France";
            treeNodeAdv13.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv13.EnsureDefaultOptionedChild = true;
            treeNodeAdv13.LeftImageIndices = new int[] {
        2};
            treeNodeAdv13.MultiLine = true;
            treeNodeAdv13.ShowLine = true;
            treeNodeAdv13.Text = "Germany";
            treeNodeAdv14.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv14.EnsureDefaultOptionedChild = true;
            treeNodeAdv14.LeftImageIndices = new int[] {
        3};
            treeNodeAdv14.MultiLine = true;
            treeNodeAdv14.ShowLine = true;
            treeNodeAdv14.Text = "UK";
            treeNodeAdv15.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv15.EnsureDefaultOptionedChild = true;
            treeNodeAdv15.LeftImageIndices = new int[] {
        4};
            treeNodeAdv15.MultiLine = true;
            treeNodeAdv15.ShowLine = true;
            treeNodeAdv15.Text = "USA";
            treeNodeAdv10.Nodes.AddRange(new Syncfusion.Windows.Forms.Tools.TreeNodeAdv[] {
            treeNodeAdv11,
            treeNodeAdv12,
            treeNodeAdv13,
            treeNodeAdv14,
            treeNodeAdv15});
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
            treeNodeAdv19.RightImageIndices = new int[] {
        4,
        4};
            treeNodeAdv19.ShowLine = true;
            treeNodeAdv19.Text = "Matrix Reloaded";
            treeNodeAdv20.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv20.EnsureDefaultOptionedChild = true;
            treeNodeAdv20.MultiLine = true;
            treeNodeAdv20.RightImageIndices = new int[] {
        4,
        4,
        4};
            treeNodeAdv20.ShowLine = true;
            treeNodeAdv20.Text = "T3";
            treeNodeAdv21.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv21.EnsureDefaultOptionedChild = true;
            treeNodeAdv21.MultiLine = true;
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
            this.treeViewAdv2.ShowLines = false;
            this.treeViewAdv2.Size = new System.Drawing.Size(766, 499);
            this.treeViewAdv2.Style = Syncfusion.Windows.Forms.Tools.TreeStyle.Metro;
            this.treeViewAdv2.TabIndex = 3;
            this.treeViewAdv2.Text = "treeViewAdv2";
            this.treeViewAdv2.ThemeName = "Metro";
            treeViewAdvVisualStyle1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            treeViewAdvVisualStyle1.TreeNodeAdvStyle.CheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            treeViewAdvVisualStyle1.TreeNodeAdvStyle.EnsureDefaultOptionedChild = true;
            treeViewAdvVisualStyle1.TreeNodeAdvStyle.IntermediateCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            treeViewAdvVisualStyle1.TreeNodeAdvStyle.OptionButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            treeViewAdvVisualStyle1.TreeNodeAdvStyle.SelectedOptionButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.treeViewAdv2.ThemeStyle = treeViewAdvVisualStyle1;
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
            
            // 
            // leftImageList
            //
#if NET9_0_OR_GREATER
            LoadImages(this.leftImageList, "LeftImagesList", 5);
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
            // gradientPanel1
            // 
            this.gradientPanel1.BorderColor = System.Drawing.Color.DarkGray;
            this.gradientPanel1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gradientPanel1.Controls.Add(this.buttonAdv1);
            this.gradientPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gradientPanel1.Location = new System.Drawing.Point(10, 0);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(766, 35);
            this.gradientPanel1.TabIndex = 3;
            // 
            // buttonAdv1
            // 
            this.buttonAdv1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAdv1.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.buttonAdv1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.buttonAdv1.BeforeTouchSize = new System.Drawing.Size(120, 31);
            this.buttonAdv1.ForeColor = System.Drawing.Color.White;
            this.buttonAdv1.Image = global::_TreeViewAdvImageOverLayingDemo.Properties.Resources.touch_padding2;
            this.buttonAdv1.IsBackStageButton = false;
            this.buttonAdv1.Location = new System.Drawing.Point(648, 0);
            this.buttonAdv1.Name = "buttonAdv1";
            this.buttonAdv1.Size = new System.Drawing.Size(120, 31);
            this.buttonAdv1.TabIndex = 0;
            this.buttonAdv1.Text = "Enable Touch";
            this.buttonAdv1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonAdv1.ThemeName = "Metro";
            this.buttonAdv1.UseVisualStyle = true;
            this.buttonAdv1.UseVisualStyleBackColor = true;
            this.buttonAdv1.Click += new System.EventHandler(this.buttonAdv1_Click);
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
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 15);
            this.ClientSize = new System.Drawing.Size(786, 561);
            this.Controls.Add(this.treeViewAdv2);
            this.Controls.Add(this.gradientPanel1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(50, 300);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(10,5,10,10);
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customization";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.treeViewAdv2)).EndInit();
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

        private void Form1_Load(object sender, EventArgs e)
        {
            this.treeViewAdv2.Nodes[0].Expanded = true;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.CenterToScreen();
        }

        private void buttonAdv1_Click(object sender, EventArgs e)
        {
            this.treeViewAdv2.EnableTouchMode = !this.treeViewAdv2.EnableTouchMode;
            if (this.treeViewAdv2.EnableTouchMode)
            {
                this.treeViewAdv2.GutterSpace = 15;
                this.buttonAdv1.Text = "Disable Touch";
            }
            else
            {
                this.treeViewAdv2.GutterSpace = 3;
                this.treeViewAdv2.ItemHeight = 25;
                this.buttonAdv1.Text = "Enable Touch";
            }

        }
    }
#endregion
}


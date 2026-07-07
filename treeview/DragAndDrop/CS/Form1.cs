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
using Syncfusion.Windows.Forms.Utils;
#if NETCORE
using ContextMenu = System.Windows.Forms.ContextMenuStrip;
using MenuItem = System.Windows.Forms.ToolStripMenuItem;
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
		private TreeViewAdvDragHighlightTracker treeViewDragHighlightTracker = null;
		private TreeViewAdvDragHighlightTracker treeViewDragHighlightTracker1 = null;
        private GradientPanel panel1;
        private Label label19;
        private Label label1;
        private IContainer components;
        private Label label3;
        private ScrollersFrame scrollersFrame1;
        private CheckBoxAdv checkBoxAdv1;
        private GradientPanel gradientPanel1;
        private ImageList imageList1;
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
        private ColorPickerButton colorPickerButton1;
        private RichTextBox richTextBox1;
        private Panel panel3;
        private TreeViewAdv treeViewAdv2;
        private TreeViewAdv treeViewAdv1;
        private SplitContainerAdv splitContainerAdv1;
		#endregion

		#region Form Constructor Initialization and Disposing
		
		public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
            this.treeViewAdv1.AutoScrolling = ScrollBars.Both;
            this.MinimumSize = this.Size;
            
			//
			// TODO: Add any constructor code after InitializeComponent call
			//
			
		
			#region Delegate Declaration
			this.treeViewDragHighlightTracker = new TreeViewAdvDragHighlightTracker(this.treeViewAdv1);
			// This event will let you disable certain drop-positions for certain nodes while dragging.
			this.treeViewDragHighlightTracker.QueryAllowedPositionsForNode += 
				new QueryAllowedPositionsEventHandler(this.TreeDragDrop_QueryAllowedPositionsForNode);
			this.treeViewDragHighlightTracker.QueryDragInsertInfo+=
				new QueryDragInsertInfoEventHandler(treeViewDragHighlightTracker_QueryDragInsertInfo);
            this.treeViewDragHighlightTracker1 = new TreeViewAdvDragHighlightTracker(this.treeViewAdv2);
            // This event will let you disable certain drop-positions for certain nodes while dragging.
            this.treeViewDragHighlightTracker1.QueryAllowedPositionsForNode +=
                new QueryAllowedPositionsEventHandler(this.TreeDragDrop_QueryAllowedPositionsForNode1);
            this.treeViewDragHighlightTracker1.QueryDragInsertInfo +=
                new QueryDragInsertInfoEventHandler(treeViewDragHighlightTracker_QueryDragInsertInfo1);

            #endregion
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
					this.treeViewDragHighlightTracker.QueryAllowedPositionsForNode -= 
						new QueryAllowedPositionsEventHandler(this.TreeDragDrop_QueryAllowedPositionsForNode);
					this.treeViewDragHighlightTracker = null;
				}
                if (treeViewDragHighlightTracker1 != null)
                {
                    this.treeViewDragHighlightTracker1.QueryAllowedPositionsForNode -=
                        new QueryAllowedPositionsEventHandler(this.TreeDragDrop_QueryAllowedPositionsForNode1);
                    this.treeViewDragHighlightTracker1 = null;
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
            Syncfusion.Windows.Forms.Tools.TreeNodeAdv treeNodeAdv22 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdv();
            Syncfusion.Windows.Forms.Tools.TreeNodeAdv treeNodeAdv23 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdv();
            Syncfusion.Windows.Forms.Tools.TreeNodeAdv treeNodeAdv24 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdv();
            Syncfusion.Windows.Forms.Tools.TreeNodeAdv treeNodeAdv25 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdv();
            Syncfusion.Windows.Forms.Tools.TreeNodeAdv treeNodeAdv26 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdv();
            Syncfusion.Windows.Forms.Tools.TreeNodeAdv treeNodeAdv27 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdv();
            Syncfusion.Windows.Forms.Tools.TreeNodeAdv treeNodeAdv28 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdv();
            Syncfusion.Windows.Forms.Tools.TreeNodeAdv treeNodeAdv29 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdv();
            Syncfusion.Windows.Forms.Tools.TreeNodeAdv treeNodeAdv30 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdv();
            Syncfusion.Windows.Forms.Tools.TreeViewAdvVisualStyle treeViewAdvVisualStyle1 = new Syncfusion.Windows.Forms.Tools.TreeViewAdvVisualStyle();
            Syncfusion.Windows.Forms.MetroColorTable metroColorTable1 = new Syncfusion.Windows.Forms.MetroColorTable();
            Syncfusion.Windows.Forms.MetroColorTable metroColorTable2 = new Syncfusion.Windows.Forms.MetroColorTable();
            Syncfusion.Windows.Forms.MetroColorTable metroColorTable3 = new Syncfusion.Windows.Forms.MetroColorTable();
            Syncfusion.Windows.Forms.MetroColorTable metroColorTable4 = new Syncfusion.Windows.Forms.MetroColorTable();
            Syncfusion.Windows.Forms.MetroColorTable metroColorTable5 = new Syncfusion.Windows.Forms.MetroColorTable();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Syncfusion.Windows.Forms.Tools.TreeNodeAdvStyleInfo treeNodeAdvStyleInfo2 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdvStyleInfo();
            Syncfusion.Windows.Forms.Tools.TreeNodeAdv treeNodeAdv31 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdv();
            Syncfusion.Windows.Forms.Tools.TreeNodeAdv treeNodeAdv32 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdv();
            Syncfusion.Windows.Forms.Tools.TreeNodeAdv treeNodeAdv33 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdv();
            Syncfusion.Windows.Forms.Tools.TreeNodeAdv treeNodeAdv34 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdv();
            Syncfusion.Windows.Forms.Tools.TreeNodeAdv treeNodeAdv35 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdv();
            Syncfusion.Windows.Forms.Tools.TreeNodeAdv treeNodeAdv36 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdv();
            Syncfusion.Windows.Forms.Tools.TreeNodeAdv treeNodeAdv37 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdv();
            Syncfusion.Windows.Forms.Tools.TreeNodeAdv treeNodeAdv38 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdv();
            Syncfusion.Windows.Forms.Tools.TreeNodeAdv treeNodeAdv39 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdv();
            Syncfusion.Windows.Forms.Tools.TreeNodeAdv treeNodeAdv40 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdv();
            Syncfusion.Windows.Forms.Tools.TreeNodeAdv treeNodeAdv41 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdv();
            Syncfusion.Windows.Forms.Tools.TreeNodeAdv treeNodeAdv42 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdv();
            Syncfusion.Windows.Forms.Tools.TreeNodeAdv treeNodeAdv43 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdv();
            Syncfusion.Windows.Forms.Tools.TreeNodeAdv treeNodeAdv44 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdv();
            Syncfusion.Windows.Forms.Tools.TreeNodeAdv treeNodeAdv45 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdv();
            Syncfusion.Windows.Forms.Tools.TreeNodeAdv treeNodeAdv46 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdv();
            Syncfusion.Windows.Forms.Tools.TreeNodeAdv treeNodeAdv47 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdv();
            Syncfusion.Windows.Forms.Tools.TreeNodeAdv treeNodeAdv48 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdv();
            Syncfusion.Windows.Forms.Tools.TreeNodeAdv treeNodeAdv49 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdv();
            Syncfusion.Windows.Forms.Tools.TreeNodeAdv treeNodeAdv50 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdv();
            Syncfusion.Windows.Forms.Tools.TreeNodeAdv treeNodeAdv51 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdv();
            Syncfusion.Windows.Forms.Tools.TreeNodeAdv treeNodeAdv52 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdv();
            Syncfusion.Windows.Forms.Tools.TreeNodeAdv treeNodeAdv53 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdv();
            Syncfusion.Windows.Forms.Tools.TreeNodeAdv treeNodeAdv54 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdv();
            Syncfusion.Windows.Forms.Tools.TreeNodeAdv treeNodeAdv55 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdv();
            Syncfusion.Windows.Forms.Tools.TreeNodeAdv treeNodeAdv56 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdv();
            Syncfusion.Windows.Forms.Tools.TreeNodeAdv treeNodeAdv57 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdv();
            Syncfusion.Windows.Forms.Tools.TreeNodeAdv treeNodeAdv58 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdv();
            Syncfusion.Windows.Forms.Tools.TreeNodeAdv treeNodeAdv59 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdv();
            Syncfusion.Windows.Forms.Tools.TreeNodeAdv treeNodeAdv60 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdv();
            Syncfusion.Windows.Forms.Tools.TreeViewAdvVisualStyle treeViewAdvVisualStyle2 = new Syncfusion.Windows.Forms.Tools.TreeViewAdvVisualStyle();
            this.panel1 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.colorPickerButton1 = new Syncfusion.Windows.Forms.ColorPickerButton();
            this.checkBoxAdv1 = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.treeViewAdv2 = new Syncfusion.Windows.Forms.Tools.TreeViewAdv();
            this.scrollersFrame1 = new Syncfusion.Windows.Forms.ScrollersFrame(this.components);
            this.contextMenu1 = new ContextMenu();
            this.editItem = new MenuItem();
            this.copyItem = new MenuItem();
            this.cutItem = new MenuItem();
            this.leftImageList = new System.Windows.Forms.ImageList(this.components);
            this.rightImageList = new System.Windows.Forms.ImageList(this.components);
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.comboBox2 = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.comboBox1 = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.gradientPanel1 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            this.splitContainerAdv1 = new Syncfusion.Windows.Forms.Tools.SplitContainerAdv();
            this.treeViewAdv1 = new Syncfusion.Windows.Forms.Tools.TreeViewAdv();
            this.panel3 = new System.Windows.Forms.Panel();
            this.stateImageList = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.panel1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxAdv1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeViewAdv2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel1)).BeginInit();
            this.gradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerAdv1)).BeginInit();
            this.splitContainerAdv1.Panel1.SuspendLayout();
            this.splitContainerAdv1.Panel2.SuspendLayout();
            this.splitContainerAdv1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.treeViewAdv1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.richTextBox1);
            this.panel1.Controls.Add(this.colorPickerButton1);
            this.panel1.Controls.Add(this.checkBoxAdv1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label19);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(565, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(359, 514);
            this.panel1.TabIndex = 1;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.BackColor = System.Drawing.Color.White;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Location = new System.Drawing.Point(-1, 184);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(356, 328);
            this.richTextBox1.TabIndex = 47;
            this.richTextBox1.Text = "";
            // 
            // colorPickerButton1
            // 
            this.colorPickerButton1.BackColor = System.Drawing.Color.Red;
            this.colorPickerButton1.BeforeTouchSize = new System.Drawing.Size(110, 23);
            this.colorPickerButton1.IsBackStageButton = false;
            this.colorPickerButton1.Location = new System.Drawing.Point(164, 57);
            this.colorPickerButton1.MetroColor = System.Drawing.Color.Red;
            this.colorPickerButton1.Name = "colorPickerButton1";
            this.colorPickerButton1.SelectedAsBackcolor = true;
            this.colorPickerButton1.SelectedColor = System.Drawing.Color.Red;
            this.colorPickerButton1.Size = new System.Drawing.Size(110, 23);
            this.colorPickerButton1.TabIndex = 46;
            this.colorPickerButton1.UseVisualStyle = true;
            this.colorPickerButton1.UseVisualStyleBackColor = false;
            this.colorPickerButton1.ColorSelected += new System.EventHandler(this.colorPickerButton1_ColorSelected);
            this.colorPickerButton1.Click += new System.EventHandler(this.colorPickerButton1_Click);
            // 
            // checkBoxAdv1
            // 
            this.checkBoxAdv1.BeforeTouchSize = new System.Drawing.Size(150, 21);
            this.checkBoxAdv1.Checked = true;
            this.checkBoxAdv1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxAdv1.DrawFocusRectangle = false;
            this.checkBoxAdv1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxAdv1.Location = new System.Drawing.Point(16, 104);
            this.checkBoxAdv1.MetroColor = System.Drawing.Color.Gray;
            this.checkBoxAdv1.Name = "checkBoxAdv1";
            this.checkBoxAdv1.Size = new System.Drawing.Size(177, 27);
            this.checkBoxAdv1.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.checkBoxAdv1.TabIndex = 45;
            this.checkBoxAdv1.Text = "Show Drag Node Cue";
            this.checkBoxAdv1.ThemeName = "Metro";
            this.checkBoxAdv1.ThemesEnabled = false;
            this.checkBoxAdv1.CheckStateChanged += new System.EventHandler(this.checkBoxAdv1_CheckStateChanged);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Location = new System.Drawing.Point(-1, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(190, 23);
            this.label3.TabIndex = 43;
            this.label3.Text = "Drag And Drop Events";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(14, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 16);
            this.label1.TabIndex = 38;
            this.label1.Text = "Drag Highlighter Color";
            // 
            // label19
            // 
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label19.Location = new System.Drawing.Point(3, 8);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(180, 23);
            this.label19.TabIndex = 24;
            this.label19.Text = "Drag And Drop Features  ";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // treeViewAdv2
            // 
            this.treeViewAdv2.AllowDrop = true;
            this.treeViewAdv2.BackColor = System.Drawing.Color.White;
            this.treeViewAdv2.BackgroundColor = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255))))));
            treeNodeAdvStyleInfo1.CheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            treeNodeAdvStyleInfo1.EnsureDefaultOptionedChild = true;
            treeNodeAdvStyleInfo1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            treeNodeAdvStyleInfo1.IntermediateCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            treeNodeAdvStyleInfo1.OptionButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            treeNodeAdvStyleInfo1.SelectedOptionButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            treeNodeAdvStyleInfo1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.treeViewAdv2.BaseStylePairs.AddRange(new Syncfusion.Windows.Forms.Tools.StyleNamePair[] {
            new Syncfusion.Windows.Forms.Tools.StyleNamePair("Standard", treeNodeAdvStyleInfo2)});
            this.treeViewAdv2.BeforeTouchSize = new System.Drawing.Size(271, 514);
            this.treeViewAdv2.Border3DStyle = System.Windows.Forms.Border3DStyle.Flat;
            this.treeViewAdv2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.treeViewAdv2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeViewAdv2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeViewAdv2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            // 
            // 
            // 
            this.treeViewAdv2.HelpTextControl.BaseThemeName = null;
            this.treeViewAdv2.HelpTextControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.treeViewAdv2.HelpTextControl.Location = new System.Drawing.Point(732, 0);
            this.treeViewAdv2.HelpTextControl.Name = "helpText";
            this.treeViewAdv2.HelpTextControl.Size = new System.Drawing.Size(49, 15);
            this.treeViewAdv2.HelpTextControl.TabIndex = 0;
            this.treeViewAdv2.HelpTextControl.Text = "help text";
            this.treeViewAdv2.InactiveSelectedNodeForeColor = System.Drawing.SystemColors.ControlText;
            this.treeViewAdv2.Indent = 20;
            this.treeViewAdv2.ItemHeight = 25;
            this.treeViewAdv2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(94)))), ((int)(((byte)(94)))));
            this.treeViewAdv2.Location = new System.Drawing.Point(0, 0);
            this.treeViewAdv2.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218)))));
            this.treeViewAdv2.MetroScrollBars = true;
            this.treeViewAdv2.Name = "treeViewAdv2";
            treeNodeAdv1.Background = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.Transparent);
            treeNodeAdv1.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv1.EnsureDefaultOptionedChild = true;
            treeNodeAdv1.Expanded = true;
            treeNodeAdv1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            treeNodeAdv1.MultiLine = true;
            treeNodeAdv2.ChildStyle.CheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            treeNodeAdv2.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv2.ChildStyle.IntermediateCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            treeNodeAdv2.ChildStyle.OptionButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            treeNodeAdv2.ChildStyle.SelectedOptionButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            treeNodeAdv2.EnsureDefaultOptionedChild = true;
            treeNodeAdv2.MultiLine = true;
            treeNodeAdv2.Optioned = true;
            treeNodeAdv2.ShowLine = true;
            treeNodeAdv2.Text = "Cuba";
            treeNodeAdv3.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv3.EnsureDefaultOptionedChild = true;
            treeNodeAdv3.Expanded = true;
            treeNodeAdv3.MultiLine = true;
            treeNodeAdv3.ShowLine = true;
            treeNodeAdv3.Text = "Mexico";
            treeNodeAdv4.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv4.EnsureDefaultOptionedChild = true;
            treeNodeAdv4.MultiLine = true;
            treeNodeAdv4.ShowLine = true;
            treeNodeAdv4.Text = "United States";
            treeNodeAdv5.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv5.EnsureDefaultOptionedChild = true;
            treeNodeAdv5.MultiLine = true;
            treeNodeAdv5.ShowLine = true;
            treeNodeAdv5.Text = "Canada";
            treeNodeAdv1.Nodes.AddRange(new Syncfusion.Windows.Forms.Tools.TreeNodeAdv[] {
            treeNodeAdv2,
            treeNodeAdv3,
            treeNodeAdv4,
            treeNodeAdv5});
            treeNodeAdv1.ShowLine = true;
            treeNodeAdv1.Tag = "Continent";
            treeNodeAdv1.Text = "North America";
            treeNodeAdv6.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv6.EnsureDefaultOptionedChild = true;
            treeNodeAdv6.Expanded = true;
            treeNodeAdv6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            treeNodeAdv6.MultiLine = true;
            treeNodeAdv7.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv7.EnsureDefaultOptionedChild = true;
            treeNodeAdv7.Expanded = true;
            treeNodeAdv7.MultiLine = true;
            treeNodeAdv7.Optioned = true;
            treeNodeAdv7.ShowLine = true;
            treeNodeAdv7.Text = "Peru";
            treeNodeAdv8.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv8.EnsureDefaultOptionedChild = true;
            treeNodeAdv8.Expanded = true;
            treeNodeAdv8.MultiLine = true;
            treeNodeAdv8.ShowLine = true;
            treeNodeAdv8.Text = "Colombia";
            treeNodeAdv9.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv9.EnsureDefaultOptionedChild = true;
            treeNodeAdv9.MultiLine = true;
            treeNodeAdv9.ShowLine = true;
            treeNodeAdv9.Text = "Brazil";
            treeNodeAdv6.Nodes.AddRange(new Syncfusion.Windows.Forms.Tools.TreeNodeAdv[] {
            treeNodeAdv7,
            treeNodeAdv8,
            treeNodeAdv9});
            treeNodeAdv6.ShowLine = true;
            treeNodeAdv6.Tag = "Continent";
            treeNodeAdv6.Text = "South America";
            treeNodeAdv10.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv10.EnsureDefaultOptionedChild = true;
            treeNodeAdv10.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            treeNodeAdv10.MultiLine = true;
            treeNodeAdv10.ShowLine = true;
            treeNodeAdv10.Tag = "Continent";
            treeNodeAdv10.Text = "Antarctica";
            treeNodeAdv11.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv11.EnsureDefaultOptionedChild = true;
            treeNodeAdv11.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            treeNodeAdv11.MultiLine = true;
            treeNodeAdv12.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv12.EnsureDefaultOptionedChild = true;
            treeNodeAdv12.MultiLine = true;
            treeNodeAdv12.Optioned = true;
            treeNodeAdv12.ShowLine = true;
            treeNodeAdv12.Text = "Germany";
            treeNodeAdv13.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv13.EnsureDefaultOptionedChild = true;
            treeNodeAdv13.Expanded = true;
            treeNodeAdv13.MultiLine = true;
            treeNodeAdv13.ShowLine = true;
            treeNodeAdv13.Text = "Austria";
            treeNodeAdv14.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv14.EnsureDefaultOptionedChild = true;
            treeNodeAdv14.MultiLine = true;
            treeNodeAdv14.ShowLine = true;
            treeNodeAdv14.Text = "Belgium";
            treeNodeAdv15.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv15.EnsureDefaultOptionedChild = true;
            treeNodeAdv15.MultiLine = true;
            treeNodeAdv15.ShowLine = true;
            treeNodeAdv15.Text = "Finland";
            treeNodeAdv16.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv16.EnsureDefaultOptionedChild = true;
            treeNodeAdv16.MultiLine = true;
            treeNodeAdv16.ShowLine = true;
            treeNodeAdv16.Text = "France";
            treeNodeAdv17.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv17.EnsureDefaultOptionedChild = true;
            treeNodeAdv17.MultiLine = true;
            treeNodeAdv17.ShowLine = true;
            treeNodeAdv17.Text = "United Kingdom";
            treeNodeAdv18.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv18.EnsureDefaultOptionedChild = true;
            treeNodeAdv18.MultiLine = true;
            treeNodeAdv18.ShowLine = true;
            treeNodeAdv18.Text = "Italy";
            treeNodeAdv11.Nodes.AddRange(new Syncfusion.Windows.Forms.Tools.TreeNodeAdv[] {
            treeNodeAdv12,
            treeNodeAdv13,
            treeNodeAdv14,
            treeNodeAdv15,
            treeNodeAdv16,
            treeNodeAdv17,
            treeNodeAdv18});
            treeNodeAdv11.ShowLine = true;
            treeNodeAdv11.Tag = "Continent";
            treeNodeAdv11.Text = "Europe";
            treeNodeAdv19.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv19.EnsureDefaultOptionedChild = true;
            treeNodeAdv19.Expanded = true;
            treeNodeAdv19.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            treeNodeAdv19.MultiLine = true;
            treeNodeAdv20.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv20.EnsureDefaultOptionedChild = true;
            treeNodeAdv20.MultiLine = true;
            treeNodeAdv20.Optioned = true;
            treeNodeAdv20.ShowLine = true;
            treeNodeAdv20.Text = "Japan";
            treeNodeAdv21.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv21.EnsureDefaultOptionedChild = true;
            treeNodeAdv21.MultiLine = true;
            treeNodeAdv21.ShowLine = true;
            treeNodeAdv21.Text = "Indonesia";
            treeNodeAdv22.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv22.EnsureDefaultOptionedChild = true;
            treeNodeAdv22.MultiLine = true;
            treeNodeAdv22.ShowLine = true;
            treeNodeAdv22.Text = "Russia";
            treeNodeAdv23.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv23.EnsureDefaultOptionedChild = true;
            treeNodeAdv23.MultiLine = true;
            treeNodeAdv23.ShowLine = true;
            treeNodeAdv23.Text = "India";
            treeNodeAdv19.Nodes.AddRange(new Syncfusion.Windows.Forms.Tools.TreeNodeAdv[] {
            treeNodeAdv20,
            treeNodeAdv21,
            treeNodeAdv22,
            treeNodeAdv23});
            treeNodeAdv19.ShowLine = true;
            treeNodeAdv19.Tag = "Continent";
            treeNodeAdv19.Text = "Asia";
            treeNodeAdv24.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv24.EnsureDefaultOptionedChild = true;
            treeNodeAdv24.Expanded = true;
            treeNodeAdv24.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            treeNodeAdv24.MultiLine = true;
            treeNodeAdv25.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv25.EnsureDefaultOptionedChild = true;
            treeNodeAdv25.MultiLine = true;
            treeNodeAdv25.Optioned = true;
            treeNodeAdv25.ShowLine = true;
            treeNodeAdv25.Text = "Kenya";
            treeNodeAdv26.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv26.EnsureDefaultOptionedChild = true;
            treeNodeAdv26.Expanded = true;
            treeNodeAdv26.MultiLine = true;
            treeNodeAdv26.ShowLine = true;
            treeNodeAdv26.Text = "Madagascar";
            treeNodeAdv27.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv27.EnsureDefaultOptionedChild = true;
            treeNodeAdv27.MultiLine = true;
            treeNodeAdv27.ShowLine = true;
            treeNodeAdv27.Text = "Egypt";
            treeNodeAdv24.Nodes.AddRange(new Syncfusion.Windows.Forms.Tools.TreeNodeAdv[] {
            treeNodeAdv25,
            treeNodeAdv26,
            treeNodeAdv27});
            treeNodeAdv24.ShowLine = true;
            treeNodeAdv24.Tag = "Continent";
            treeNodeAdv24.Text = "Africa";
            treeNodeAdv28.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv28.EnsureDefaultOptionedChild = true;
            treeNodeAdv28.Expanded = true;
            treeNodeAdv28.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            treeNodeAdv28.MultiLine = true;
            treeNodeAdv29.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv29.EnsureDefaultOptionedChild = true;
            treeNodeAdv29.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            treeNodeAdv29.MultiLine = true;
            treeNodeAdv29.Optioned = true;
            treeNodeAdv29.ShowLine = true;
            treeNodeAdv29.Text = "Australia";
            treeNodeAdv30.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv30.EnsureDefaultOptionedChild = true;
            treeNodeAdv30.MultiLine = true;
            treeNodeAdv30.ShowLine = true;
            treeNodeAdv30.Text = "New Zealand";
            treeNodeAdv28.Nodes.AddRange(new Syncfusion.Windows.Forms.Tools.TreeNodeAdv[] {
            treeNodeAdv29,
            treeNodeAdv30});
            treeNodeAdv28.ShowLine = true;
            treeNodeAdv28.Tag = "Continent";
            treeNodeAdv28.Text = "Australia";
            this.treeViewAdv2.Nodes.AddRange(new Syncfusion.Windows.Forms.Tools.TreeNodeAdv[] {
            treeNodeAdv1,
            treeNodeAdv6,
            treeNodeAdv10,
            treeNodeAdv11,
            treeNodeAdv19,
            treeNodeAdv24,
            treeNodeAdv28});
            this.treeViewAdv2.PathSeparator = "/";
            this.treeViewAdv2.SelectedNodeBackground = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197))))));
            this.treeViewAdv2.SelectedNodeForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.treeViewAdv2.ShowFocusRect = false;
            this.treeViewAdv2.Size = new System.Drawing.Size(271, 514);
            this.treeViewAdv2.Style = Syncfusion.Windows.Forms.Tools.TreeStyle.Office2016Colorful;
            this.treeViewAdv2.TabIndex = 7;
            this.treeViewAdv2.Text = "treeViewAdv2";
            this.treeViewAdv2.ThemeName = "Office2016Colorful";
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
            this.treeViewAdv2.ToolTipControl.BaseThemeName = null;
            this.treeViewAdv2.ToolTipControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.treeViewAdv2.ToolTipControl.Location = new System.Drawing.Point(642, 0);
            this.treeViewAdv2.ToolTipControl.Name = "toolTip";
            this.treeViewAdv2.ToolTipControl.Size = new System.Drawing.Size(41, 15);
            this.treeViewAdv2.ToolTipControl.TabIndex = 1;
            this.treeViewAdv2.ToolTipControl.Text = "toolTip";
            this.treeViewAdv2.TransparentControls = true;
            this.treeViewAdv2.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.treeViewAdv_ItemDrag);
            this.treeViewAdv2.DragDrop += new System.Windows.Forms.DragEventHandler(this.treeViewAdv_DragDrop1);
            this.treeViewAdv2.DragOver += new System.Windows.Forms.DragEventHandler(this.treeViewAdv_DragOver1);
            this.treeViewAdv2.DragLeave += new System.EventHandler(this.treeViewAdv_DragLeave1);

            this.treeViewAdv2.QueryContinueDrag += new System.Windows.Forms.QueryContinueDragEventHandler(this.treeViewAdv_QueryContinueDrag);
            // 
            // scrollersFrame1
            // 
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
            this.scrollersFrame1.ThemeName = "Metro";
            this.scrollersFrame1.VerticallSmallChange = 13;
            this.scrollersFrame1.VisualStyle = Syncfusion.Windows.Forms.ScrollBarCustomDrawStyles.Metro;
            // 
            // contextMenu1
            // 
            ContextMenuHelper.GetContextMenuItems(this.contextMenu1).AddRange(new MenuItem[] {
            this.editItem,
            this.copyItem,
            this.cutItem});
            // 
            // editItem
            // 
            ContextMenuHelper.SetIndex(this.editItem, 0);
            this.editItem.Text = "&Edit";
            // 
            // copyItem
            // 
            ContextMenuHelper.SetIndex(this.copyItem, 1); 
            this.copyItem.Text = "&Copy";
            this.copyItem.Click += new System.EventHandler(this.copyItem_Click);
            // 
            // cutItem
            // 
            ContextMenuHelper.SetIndex(this.cutItem, 2);
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
            this.comboBox2.BeforeTouchSize = new System.Drawing.Size(216, 21);
            this.comboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.Location = new System.Drawing.Point(62, 136);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(216, 21);
            this.comboBox2.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.comboBox2.TabIndex = 12;
            this.comboBox2.ThemeName = "Metro";
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.White;
            this.comboBox1.BeforeTouchSize = new System.Drawing.Size(216, 21);
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.Location = new System.Drawing.Point(62, 80);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(216, 21);
            this.comboBox1.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.comboBox1.TabIndex = 9;
            this.comboBox1.ThemeName = "Metro";
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
            this.gradientPanel1.Controls.Add(this.splitContainerAdv1);
            this.gradientPanel1.Controls.Add(this.panel3);
            this.gradientPanel1.Controls.Add(this.panel1);
            this.gradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gradientPanel1.Location = new System.Drawing.Point(10, 10);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(924, 514);
            this.gradientPanel1.TabIndex = 3;
            // 
            // splitContainerAdv1
            // 
            this.splitContainerAdv1.BeforeTouchSize = 8;
            this.splitContainerAdv1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerAdv1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerAdv1.Name = "splitContainerAdv1";
            // 
            // splitContainerAdv1.Panel1
            // 
            this.splitContainerAdv1.Panel1.Controls.Add(this.treeViewAdv1);
            // 
            // splitContainerAdv1.Panel2
            // 
            this.splitContainerAdv1.Panel2.Controls.Add(this.treeViewAdv2);
            this.splitContainerAdv1.Size = new System.Drawing.Size(557, 514);
            this.splitContainerAdv1.SplitterDistance = 278;
            this.splitContainerAdv1.SplitterWidth = 8;
            this.splitContainerAdv1.TabIndex = 8;
            this.splitContainerAdv1.Text = "splitContainerAdv1";
            this.splitContainerAdv1.ThemeName = "None";
            // 
            // treeViewAdv1
            // 
            this.treeViewAdv1.AllowDrop = true;
            this.treeViewAdv1.BackColor = System.Drawing.Color.White;
            this.treeViewAdv1.BackgroundColor = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255))))));
            treeNodeAdvStyleInfo2.CheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            treeNodeAdvStyleInfo2.EnsureDefaultOptionedChild = true;
            treeNodeAdvStyleInfo2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            treeNodeAdvStyleInfo2.IntermediateCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            treeNodeAdvStyleInfo2.OptionButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            treeNodeAdvStyleInfo2.SelectedOptionButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            treeNodeAdvStyleInfo2.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.treeViewAdv1.BaseStylePairs.AddRange(new Syncfusion.Windows.Forms.Tools.StyleNamePair[] {
            new Syncfusion.Windows.Forms.Tools.StyleNamePair("Standard", treeNodeAdvStyleInfo2)});
            this.treeViewAdv1.BeforeTouchSize = new System.Drawing.Size(278, 514);
            this.treeViewAdv1.Border3DStyle = System.Windows.Forms.Border3DStyle.Flat;
            this.treeViewAdv1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.treeViewAdv1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeViewAdv1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeViewAdv1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            // 
            // 
            // 
            this.treeViewAdv1.HelpTextControl.BaseThemeName = null;
            this.treeViewAdv1.HelpTextControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.treeViewAdv1.HelpTextControl.Location = new System.Drawing.Point(732, 0);
            this.treeViewAdv1.HelpTextControl.Name = "helpText";
            this.treeViewAdv1.HelpTextControl.Size = new System.Drawing.Size(49, 15);
            this.treeViewAdv1.HelpTextControl.TabIndex = 0;
            this.treeViewAdv1.HelpTextControl.Text = "help text";
            this.treeViewAdv1.InactiveSelectedNodeForeColor = System.Drawing.SystemColors.ControlText;
            this.treeViewAdv1.Indent = 20;
            this.treeViewAdv1.ItemHeight = 25;
            this.treeViewAdv1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(94)))), ((int)(((byte)(94)))));
            this.treeViewAdv1.Location = new System.Drawing.Point(0, 0);
            this.treeViewAdv1.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218)))));
            this.treeViewAdv1.MetroScrollBars = true;
            this.treeViewAdv1.Name = "treeViewAdv1";
            treeNodeAdv31.Background = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.Transparent);
            treeNodeAdv31.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv31.EnsureDefaultOptionedChild = true;
            treeNodeAdv31.Expanded = true;
            treeNodeAdv31.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            treeNodeAdv31.MultiLine = true;
            treeNodeAdv32.ChildStyle.CheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            treeNodeAdv32.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv32.ChildStyle.IntermediateCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            treeNodeAdv32.ChildStyle.OptionButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            treeNodeAdv32.ChildStyle.SelectedOptionButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            treeNodeAdv32.EnsureDefaultOptionedChild = true;
            treeNodeAdv32.MultiLine = true;
            treeNodeAdv32.Optioned = true;
            treeNodeAdv32.ShowLine = true;
            treeNodeAdv32.Text = "Cuba";
            treeNodeAdv33.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv33.EnsureDefaultOptionedChild = true;
            treeNodeAdv33.Expanded = true;
            treeNodeAdv33.MultiLine = true;
            treeNodeAdv33.ShowLine = true;
            treeNodeAdv33.Text = "Mexico";
            treeNodeAdv34.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv34.EnsureDefaultOptionedChild = true;
            treeNodeAdv34.MultiLine = true;
            treeNodeAdv34.ShowLine = true;
            treeNodeAdv34.Text = "United States";
            treeNodeAdv35.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv35.EnsureDefaultOptionedChild = true;
            treeNodeAdv35.MultiLine = true;
            treeNodeAdv35.ShowLine = true;
            treeNodeAdv35.Text = "Canada";
            treeNodeAdv31.Nodes.AddRange(new Syncfusion.Windows.Forms.Tools.TreeNodeAdv[] {
            treeNodeAdv32,
            treeNodeAdv33,
            treeNodeAdv34,
            treeNodeAdv35});
            treeNodeAdv31.ShowLine = true;
            treeNodeAdv31.Tag = "Continent";
            treeNodeAdv31.Text = "North America";
            treeNodeAdv36.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv36.EnsureDefaultOptionedChild = true;
            treeNodeAdv36.Expanded = true;
            treeNodeAdv36.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            treeNodeAdv36.MultiLine = true;
            treeNodeAdv37.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv37.EnsureDefaultOptionedChild = true;
            treeNodeAdv37.Expanded = true;
            treeNodeAdv37.MultiLine = true;
            treeNodeAdv37.Optioned = true;
            treeNodeAdv37.ShowLine = true;
            treeNodeAdv37.Text = "Peru";
            treeNodeAdv38.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv38.EnsureDefaultOptionedChild = true;
            treeNodeAdv38.Expanded = true;
            treeNodeAdv38.MultiLine = true;
            treeNodeAdv38.ShowLine = true;
            treeNodeAdv38.Text = "Colombia";
            treeNodeAdv39.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv39.EnsureDefaultOptionedChild = true;
            treeNodeAdv39.MultiLine = true;
            treeNodeAdv39.ShowLine = true;
            treeNodeAdv39.Text = "Brazil";
            treeNodeAdv36.Nodes.AddRange(new Syncfusion.Windows.Forms.Tools.TreeNodeAdv[] {
            treeNodeAdv37,
            treeNodeAdv38,
            treeNodeAdv39});
            treeNodeAdv36.ShowLine = true;
            treeNodeAdv36.Tag = "Continent";
            treeNodeAdv36.Text = "South America";
            treeNodeAdv40.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv40.EnsureDefaultOptionedChild = true;
            treeNodeAdv40.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            treeNodeAdv40.MultiLine = true;
            treeNodeAdv40.ShowLine = true;
            treeNodeAdv40.Tag = "Continent";
            treeNodeAdv40.Text = "Antarctica";
            treeNodeAdv41.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv41.EnsureDefaultOptionedChild = true;
            treeNodeAdv41.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            treeNodeAdv41.MultiLine = true;
            treeNodeAdv42.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv42.EnsureDefaultOptionedChild = true;
            treeNodeAdv42.MultiLine = true;
            treeNodeAdv42.Optioned = true;
            treeNodeAdv42.ShowLine = true;
            treeNodeAdv42.Text = "Germany";
            treeNodeAdv43.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv43.EnsureDefaultOptionedChild = true;
            treeNodeAdv43.Expanded = true;
            treeNodeAdv43.MultiLine = true;
            treeNodeAdv43.ShowLine = true;
            treeNodeAdv43.Text = "Austria";
            treeNodeAdv44.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv44.EnsureDefaultOptionedChild = true;
            treeNodeAdv44.MultiLine = true;
            treeNodeAdv44.ShowLine = true;
            treeNodeAdv44.Text = "Belgium";
            treeNodeAdv45.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv45.EnsureDefaultOptionedChild = true;
            treeNodeAdv45.MultiLine = true;
            treeNodeAdv45.ShowLine = true;
            treeNodeAdv45.Text = "Finland";
            treeNodeAdv46.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv46.EnsureDefaultOptionedChild = true;
            treeNodeAdv46.MultiLine = true;
            treeNodeAdv46.ShowLine = true;
            treeNodeAdv46.Text = "France";
            treeNodeAdv47.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv47.EnsureDefaultOptionedChild = true;
            treeNodeAdv47.MultiLine = true;
            treeNodeAdv47.ShowLine = true;
            treeNodeAdv47.Text = "United Kingdom";
            treeNodeAdv48.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv48.EnsureDefaultOptionedChild = true;
            treeNodeAdv48.MultiLine = true;
            treeNodeAdv48.ShowLine = true;
            treeNodeAdv48.Text = "Italy";
            treeNodeAdv41.Nodes.AddRange(new Syncfusion.Windows.Forms.Tools.TreeNodeAdv[] {
            treeNodeAdv42,
            treeNodeAdv43,
            treeNodeAdv44,
            treeNodeAdv45,
            treeNodeAdv46,
            treeNodeAdv47,
            treeNodeAdv48});
            treeNodeAdv41.ShowLine = true;
            treeNodeAdv41.Tag = "Continent";
            treeNodeAdv41.Text = "Europe";
            treeNodeAdv49.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv49.EnsureDefaultOptionedChild = true;
            treeNodeAdv49.Expanded = true;
            treeNodeAdv49.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            treeNodeAdv49.MultiLine = true;
            treeNodeAdv50.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv50.EnsureDefaultOptionedChild = true;
            treeNodeAdv50.MultiLine = true;
            treeNodeAdv50.Optioned = true;
            treeNodeAdv50.ShowLine = true;
            treeNodeAdv50.Text = "Japan";
            treeNodeAdv51.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv51.EnsureDefaultOptionedChild = true;
            treeNodeAdv51.MultiLine = true;
            treeNodeAdv51.ShowLine = true;
            treeNodeAdv51.Text = "Indonesia";
            treeNodeAdv52.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv52.EnsureDefaultOptionedChild = true;
            treeNodeAdv52.MultiLine = true;
            treeNodeAdv52.ShowLine = true;
            treeNodeAdv52.Text = "Russia";
            treeNodeAdv53.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv53.EnsureDefaultOptionedChild = true;
            treeNodeAdv53.MultiLine = true;
            treeNodeAdv53.ShowLine = true;
            treeNodeAdv53.Text = "India";
            treeNodeAdv49.Nodes.AddRange(new Syncfusion.Windows.Forms.Tools.TreeNodeAdv[] {
            treeNodeAdv50,
            treeNodeAdv51,
            treeNodeAdv52,
            treeNodeAdv53});
            treeNodeAdv49.ShowLine = true;
            treeNodeAdv49.Tag = "Continent";
            treeNodeAdv49.Text = "Asia";
            treeNodeAdv54.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv54.EnsureDefaultOptionedChild = true;
            treeNodeAdv54.Expanded = true;
            treeNodeAdv54.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            treeNodeAdv54.MultiLine = true;
            treeNodeAdv55.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv55.EnsureDefaultOptionedChild = true;
            treeNodeAdv55.MultiLine = true;
            treeNodeAdv55.Optioned = true;
            treeNodeAdv55.ShowLine = true;
            treeNodeAdv55.Text = "Kenya";
            treeNodeAdv56.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv56.EnsureDefaultOptionedChild = true;
            treeNodeAdv56.Expanded = true;
            treeNodeAdv56.MultiLine = true;
            treeNodeAdv56.ShowLine = true;
            treeNodeAdv56.Text = "Madagascar";
            treeNodeAdv57.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv57.EnsureDefaultOptionedChild = true;
            treeNodeAdv57.MultiLine = true;
            treeNodeAdv57.ShowLine = true;
            treeNodeAdv57.Text = "Egypt";
            treeNodeAdv54.Nodes.AddRange(new Syncfusion.Windows.Forms.Tools.TreeNodeAdv[] {
            treeNodeAdv55,
            treeNodeAdv56,
            treeNodeAdv57});
            treeNodeAdv54.ShowLine = true;
            treeNodeAdv54.Tag = "Continent";
            treeNodeAdv54.Text = "Africa";
            treeNodeAdv58.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv58.EnsureDefaultOptionedChild = true;
            treeNodeAdv58.Expanded = true;
            treeNodeAdv58.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            treeNodeAdv58.MultiLine = true;
            treeNodeAdv59.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv59.EnsureDefaultOptionedChild = true;
            treeNodeAdv59.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            treeNodeAdv59.MultiLine = true;
            treeNodeAdv59.Optioned = true;
            treeNodeAdv59.ShowLine = true;
            treeNodeAdv59.Text = "Australia";
            treeNodeAdv60.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv60.EnsureDefaultOptionedChild = true;
            treeNodeAdv60.MultiLine = true;
            treeNodeAdv60.ShowLine = true;
            treeNodeAdv60.Text = "New Zealand";
            treeNodeAdv58.Nodes.AddRange(new Syncfusion.Windows.Forms.Tools.TreeNodeAdv[] {
            treeNodeAdv59,
            treeNodeAdv60});
            treeNodeAdv58.ShowLine = true;
            treeNodeAdv58.Tag = "Continent";
            treeNodeAdv58.Text = "Australia";
            this.treeViewAdv1.Nodes.AddRange(new Syncfusion.Windows.Forms.Tools.TreeNodeAdv[] {
            treeNodeAdv31,
            treeNodeAdv36,
            treeNodeAdv40,
            treeNodeAdv41,
            treeNodeAdv49,
            treeNodeAdv54,
            treeNodeAdv58});
            this.treeViewAdv1.PathSeparator = "/";
            this.treeViewAdv1.SelectedNodeBackground = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197))))));
            this.treeViewAdv1.SelectedNodeForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.treeViewAdv1.ShowFocusRect = false;
            this.treeViewAdv1.Size = new System.Drawing.Size(278, 514);
            this.treeViewAdv1.Style = Syncfusion.Windows.Forms.Tools.TreeStyle.Office2016Colorful;
            this.treeViewAdv1.TabIndex = 6;
            this.treeViewAdv1.Text = "treeViewAdv1";
            this.treeViewAdv1.ThemeName = "Office2016Colorful";
            treeViewAdvVisualStyle2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            treeViewAdvVisualStyle2.TreeNodeAdvStyle.CheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            treeViewAdvVisualStyle2.TreeNodeAdvStyle.EnsureDefaultOptionedChild = true;
            treeViewAdvVisualStyle2.TreeNodeAdvStyle.IntermediateCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            treeViewAdvVisualStyle2.TreeNodeAdvStyle.OptionButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            treeViewAdvVisualStyle2.TreeNodeAdvStyle.SelectedOptionButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.treeViewAdv1.ThemeStyle = treeViewAdvVisualStyle2;
            // 
            // 
            // 
            this.treeViewAdv1.ToolTipControl.BackColor = System.Drawing.SystemColors.Info;
            this.treeViewAdv1.ToolTipControl.BaseThemeName = null;
            this.treeViewAdv1.ToolTipControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.treeViewAdv1.ToolTipControl.Location = new System.Drawing.Point(642, 0);
            this.treeViewAdv1.ToolTipControl.Name = "toolTip";
            this.treeViewAdv1.ToolTipControl.Size = new System.Drawing.Size(41, 15);
            this.treeViewAdv1.ToolTipControl.TabIndex = 1;
            this.treeViewAdv1.ToolTipControl.Text = "toolTip";
            this.treeViewAdv1.TransparentControls = true;
            this.treeViewAdv1.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.treeViewAdv_ItemDrag);
            this.treeViewAdv1.DragDrop += new System.Windows.Forms.DragEventHandler(this.treeViewAdv_DragDrop);
            this.treeViewAdv1.DragOver += new System.Windows.Forms.DragEventHandler(this.treeViewAdv_DragOver);
            this.treeViewAdv1.DragLeave += new System.EventHandler(this.treeViewAdv_DragLeave);
            this.treeViewAdv1.QueryContinueDrag += new System.Windows.Forms.QueryContinueDragEventHandler(this.treeViewAdv_QueryContinueDrag);
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(557, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(8, 514);
            this.panel3.TabIndex = 5;
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
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 18);
            this.ClientSize = new System.Drawing.Size(944, 534);
            this.Controls.Add(this.gradientPanel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(50, 300);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Drag and Drop";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panel1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxAdv1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeViewAdv2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel1)).EndInit();
            this.gradientPanel1.ResumeLayout(false);
            this.splitContainerAdv1.Panel1.ResumeLayout(false);
            this.splitContainerAdv1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerAdv1)).EndInit();
            this.splitContainerAdv1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.treeViewAdv1)).EndInit();
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
			//if(!IsContinentNode(node))
			{
				// Only allow move
				DragDropEffects result = treeViewAdv.DoDragDrop(node, DragDropEffects.Move);
			}

            this.richTextBox1.AppendText("\""+node.Text+"\"" + " node drag started.\n");
	
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

		private void treeViewAdv_DragOver(object sender, System.Windows.Forms.DragEventArgs e)
		{
			// Determine drag effects
			bool droppable = true;
			TreeNodeAdv destinationNode = null;
			TreeViewAdv treeView = sender as TreeViewAdv;
			Point ptInTree = treeView.PointToClient(new Point(e.X, e.Y));
			this.currentSourceNode = null;

			// Looking for a single tree node.
			if( e.Data.GetDataPresent(typeof(TreeNodeAdv)))
			{
				// Get the destination and source node.
				destinationNode = treeView.GetNodeAtPoint(ptInTree);
				TreeNodeAdv sourceNode = (TreeNodeAdv) e.Data.GetData(typeof(TreeNodeAdv));
				// Cache this for use later in the TreeDragDrop_QueryAllowedPositionsForNode event handler.
				this.currentSourceNode = sourceNode;
				droppable = this.CanDrop(sourceNode, destinationNode);
			}
			else
				droppable = false;

			if(droppable)
				// If Moving is allowed:
				e.Effect = DragDropEffects.Move;
			else
				e.Effect = DragDropEffects.None;

            // Let the highlight tracker keep track of the current highlight node.
            this.treeViewDragHighlightTracker.SetHighlightNode(destinationNode, ptInTree);
        }
        private void treeViewAdv_DragOver1(object sender, System.Windows.Forms.DragEventArgs e)
        {
            // Determine drag effects
            bool droppable = true;
            TreeNodeAdv destinationNode = null;
            TreeViewAdv treeView = sender as TreeViewAdv;
            Point ptInTree = treeView.PointToClient(new Point(e.X, e.Y));
            this.currentSourceNode = null;

            // Looking for a single tree node.
            if (e.Data.GetDataPresent(typeof(TreeNodeAdv)))
            {
                // Get the destination and source node.
                destinationNode = treeView.GetNodeAtPoint(ptInTree);
                TreeNodeAdv sourceNode = (TreeNodeAdv)e.Data.GetData(typeof(TreeNodeAdv));
                // Cache this for use later in the TreeDragDrop_QueryAllowedPositionsForNode event handler.
                this.currentSourceNode = sourceNode;
                droppable = this.CanDrop(sourceNode, destinationNode);
            }
            else
                droppable = false;

            if (droppable)
                // If Moving is allowed:
                e.Effect = DragDropEffects.Move;
            else
                e.Effect = DragDropEffects.None;

            // Let the highlight tracker keep track of the current highlight node.
            this.treeViewDragHighlightTracker1.SetHighlightNode(destinationNode, ptInTree);

        }
        private bool CanDrop(TreeNodeAdv sourceNode, TreeNodeAdv destinationNode)
		{
			if(// Support drag and drop only within the same tree
				//sourceNode.TreeView != this.treeViewAdv1 ||
				// Cannot drop into empty area
				destinationNode == null ||
				// Cannot drop over the source's parent
				//destinationNode == sourceNode.Parent ||
				// Or over itself
				destinationNode == sourceNode
				)
				return false;
			else
				return true;
		}
		private void treeViewAdv_DragLeave(object sender, System.EventArgs e)
		{
			// Let the highlight tracker keep track of the current highlight node.
			this.treeViewDragHighlightTracker.ClearHighlightNode();
        }

        private void treeViewAdv_DragLeave1(object sender, System.EventArgs e)
        {
            // Let the highlight tracker keep track of the current highlight node.
            this.treeViewDragHighlightTracker1.ClearHighlightNode();
        }

        private void treeViewAdv_DragDrop(object sender, System.Windows.Forms.DragEventArgs e)
		{
			TreeViewAdv treeView = sender as TreeViewAdv;

			// Get the destination and source node.

			TreeNodeAdv sourceNode = (TreeNodeAdv) e.Data.GetData(typeof(TreeNodeAdv));
			
			TreeNodeAdv destinationNode = this.treeViewDragHighlightTracker.HighlightNode;
			TreeViewDropPositions dropPosition = this.treeViewDragHighlightTracker.DropPosition;
			// Clear the highlight info in the tracker.
			this.treeViewDragHighlightTracker.ClearHighlightNode();

			this.currentSourceNode = null;

			// Move the source node based on the tracked info.
			if(destinationNode != null)
			{
				switch (dropPosition)
				{
					case TreeViewDropPositions.AboveNode:
						sourceNode.Move(destinationNode, NodePositions.Previous);
						break;
					case TreeViewDropPositions.BelowNode:
						sourceNode.Move(destinationNode, NodePositions.Next);
						break;
					case TreeViewDropPositions.OnNode:
						sourceNode.Move(destinationNode.Nodes);
						destinationNode.Expand();
						break;
				}
			}
			
			treeView.SelectedNode = sourceNode;
            this.richTextBox1.AppendText("\"" + sourceNode.Text + "\"" + " node drag dropped.\n");
        }

        private void treeViewAdv_DragDrop1(object sender, System.Windows.Forms.DragEventArgs e)
        {
            TreeViewAdv treeView = sender as TreeViewAdv;

            // Get the destination and source node.

            TreeNodeAdv sourceNode = (TreeNodeAdv)e.Data.GetData(typeof(TreeNodeAdv));

            TreeNodeAdv destinationNode = this.treeViewDragHighlightTracker1.HighlightNode;
            TreeViewDropPositions dropPosition = this.treeViewDragHighlightTracker1.DropPosition;
            // Clear the highlight info in the tracker.
            this.treeViewDragHighlightTracker1.ClearHighlightNode();

            this.currentSourceNode = null;

            // Move the source node based on the tracked info.
            if (destinationNode != null)
            {
                switch (dropPosition)
                {
                    case TreeViewDropPositions.AboveNode:
                        sourceNode.Move(destinationNode, NodePositions.Previous);
                        break;
                    case TreeViewDropPositions.BelowNode:
                        sourceNode.Move(destinationNode, NodePositions.Next);
                        break;
                    case TreeViewDropPositions.OnNode:
                        sourceNode.Move(destinationNode.Nodes);
                        destinationNode.Expand();
                        break;
                }
            }

            treeView.SelectedNode = sourceNode;
            this.richTextBox1.AppendText("\"" + sourceNode.Text + "\"" + " node drag dropped.\n");
        }

        #endregion DEST_DRAGDROP_LOGIC

        #region Delegate Defintion

        private void treeViewDragHighlightTracker_QueryDragInsertInfo(object sender, QueryDragInsertInfoEventArgs args)
		{
            args.DragInsertColor = colorPickerButton1.SelectedColor; 
    	}

        private void treeViewDragHighlightTracker_QueryDragInsertInfo1(object sender, QueryDragInsertInfoEventArgs args)
        {
            args.DragInsertColor = colorPickerButton1.SelectedColor;
        }

        // Specifiy the allowed drop positions for the specified highlight node.
        private void TreeDragDrop_QueryAllowedPositionsForNode(object sender, QueryAllowedPositionsEventArgs e)
		{
            if (!this.IsContinentNode(e.HighlightNode))
            {
				// If this a country node, only allow drop above or below it.

				if(e.HighlightNode != this.currentSourceNode)
					e.AllowedPositions = TreeViewDropPositions.AboveNode | TreeViewDropPositions.BelowNode;
				else
					// Cannot drop beside itself
					e.AllowedPositions = TreeViewDropPositions.None;

				this.treeViewDragHighlightTracker.EdgeSensitivityOnTop = e.HighlightNode.Bounds.Height / 2;

				e.ShowSelectionHighlight = false;
			}
            else
            {
                // If this is a continent node allow all drop positions (default behavior).
                this.treeViewDragHighlightTracker.EdgeSensitivityOnTop = e.HighlightNode.Bounds.Height / 4;

                e.ShowSelectionHighlight = false;

            }

        }

        private void TreeDragDrop_QueryAllowedPositionsForNode1(object sender, QueryAllowedPositionsEventArgs e)
        {
            if (!this.IsContinentNode(e.HighlightNode))
            {
                // If this a country node, only allow drop above or below it.

                if (e.HighlightNode != this.currentSourceNode)
                    e.AllowedPositions = TreeViewDropPositions.AboveNode | TreeViewDropPositions.BelowNode;
                else
                    // Cannot drop beside itself
                    e.AllowedPositions = TreeViewDropPositions.None;

                this.treeViewDragHighlightTracker1.EdgeSensitivityOnTop = e.HighlightNode.Bounds.Height / 2;

                e.ShowSelectionHighlight = false;
            }
            else
            {
                // If this is a continent node allow all drop positions (default behavior).
                this.treeViewDragHighlightTracker1.EdgeSensitivityOnTop = e.HighlightNode.Bounds.Height / 4;

                e.ShowSelectionHighlight = false;

            }

        }
        #endregion


        #region ShowDragNodeCue
        private void checkBoxAdv1_CheckStateChanged(object sender, EventArgs e)
        {
            this.treeViewAdv1.ShowDragNodeCue = this.checkBoxAdv1.Checked;
            this.treeViewAdv2.ShowDragNodeCue = this.checkBoxAdv1.Checked;
        }
        
        #endregion

        private void Form1_Load(object sender, EventArgs e)
        {
            this.treeViewAdv1.ThemeName = "Office2019Colorful";
            this.treeViewAdv2.ThemeName = "Office2019Colorful";
            this.colorPickerButton1.ThemeName= this.checkBoxAdv1.ThemeName= "Office2019Colorful";
            this.colorPickerButton1.ThemeStyle.BackColor = colorPickerButton1.SelectedColor;
        }
        
        
        #region CONTEXTMENU

        private TreeNodeAdv rightMouseDownNodeCached = null;
       


        private void cutItem_Click(object sender, System.EventArgs e)
        {
            MessageBox.Show("Not Implemented. Only Edit menu is implemented.");
        }

        private void copyItem_Click(object sender, System.EventArgs e)
        {
            MessageBox.Show("Not Implemented. Only Edit menu is implemented.");
        }
        #endregion CONTEXTMENU

      
        private void colorPickerButton1_Click(object sender, EventArgs e)
        {
            this.colorPickerButton1.ThemeStyle.BackColor = colorPickerButton1.SelectedColor;
            this.colorPickerButton1.Refresh();
        }

        private void colorPickerButton1_ColorSelected(object sender, EventArgs e)
        {
            this.colorPickerButton1.ThemeStyle.BackColor = colorPickerButton1.SelectedColor;
            this.colorPickerButton1.Refresh();
        }
    }
#endregion
}


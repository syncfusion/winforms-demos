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
		private Syncfusion.Windows.Forms.Tools.TreeViewAdv treeViewAdv1;
		// Use the tracker only when you want to support dropping adjacent (above or below) to a node.
		// Otherwise simply listen to the DragOver and DragDrop events and provide/use the DropEffect.
		// When used this tracker will draw indicators above or below a node while dragging an item
		// over the node. The tracker need to be updated as shown below in the DragXXX events.
		private TreeViewAdvDragHighlightTracker treeViewDragHighlightTracker = null;
        private Panel panel1;
        private Label label19;
        private ButtonEdit HighLighterColor;
        private ButtonEditChildButton buttonEditChildButton1;
        private Label label1;
        private ColorDialog colorDialog1;
        private ListView listView1;
        private ColumnHeader columnHeader1;
        private IContainer components;
        private Label label3;
        private ScrollersFrame scrollersFrame1;
        private CheckBoxAdv checkBoxAdv1;
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
        private System.Windows.Forms.ListViewItem listViewItem1;
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
            try
            {
                System.Drawing.Icon ico = new System.Drawing.Icon(GetIconFile(@"common\Images\Grid\Icon\sfgrid.ico"));
                this.Icon = ico;
            }
            catch { }



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
			
			#endregion
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
					this.treeViewDragHighlightTracker.QueryAllowedPositionsForNode -= 
						new QueryAllowedPositionsEventHandler(this.TreeDragDrop_QueryAllowedPositionsForNode);
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
            Syncfusion.Windows.Forms.MetroColorTable metroColorTable1 = new Syncfusion.Windows.Forms.MetroColorTable();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.treeViewAdv1 = new Syncfusion.Windows.Forms.Tools.TreeViewAdv();
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkBoxAdv1 = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.label3 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.HighLighterColor = new Syncfusion.Windows.Forms.Tools.ButtonEdit();
            this.buttonEditChildButton1 = new Syncfusion.Windows.Forms.Tools.ButtonEditChildButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.scrollersFrame1 = new Syncfusion.Windows.Forms.ScrollersFrame(this.components);
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
            ((System.ComponentModel.ISupportInitialize)(this.treeViewAdv1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxAdv1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HighLighterColor)).BeginInit();
            this.HighLighterColor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel1)).BeginInit();
            this.gradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeViewAdv1
            // 
            this.treeViewAdv1.AllowDrop = true;
            this.treeViewAdv1.BackColor = System.Drawing.Color.White;
            this.treeViewAdv1.BeforeTouchSize = new System.Drawing.Size(268, 457);
            this.treeViewAdv1.Border3DStyle = System.Windows.Forms.Border3DStyle.Flat;
            this.treeViewAdv1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.treeViewAdv1.Dock = System.Windows.Forms.DockStyle.Left;
            this.treeViewAdv1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeViewAdv1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(184)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.treeViewAdv1.HelpTextControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.treeViewAdv1.HelpTextControl.Location = new System.Drawing.Point(732, 0);
            this.treeViewAdv1.HelpTextControl.Name = "helpText";
            this.treeViewAdv1.HelpTextControl.Size = new System.Drawing.Size(49, 15);
            this.treeViewAdv1.HelpTextControl.TabIndex = 0;
            this.treeViewAdv1.HelpTextControl.Text = "help text";
            this.treeViewAdv1.InactiveSelectedNodeForeColor = System.Drawing.SystemColors.ControlText;
            this.treeViewAdv1.Indent = 20;
            this.treeViewAdv1.LineColor = System.Drawing.Color.White;
            this.treeViewAdv1.Location = new System.Drawing.Point(0, 0);
            this.treeViewAdv1.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218)))));
            this.treeViewAdv1.MetroScrollBars = true;
            this.treeViewAdv1.Name = "treeViewAdv1";
            treeNodeAdv1.Background = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.Transparent);
            treeNodeAdv1.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv1.EnsureDefaultOptionedChild = true;
            treeNodeAdv1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            treeNodeAdv1.MultiLine = true;
            treeNodeAdv1.PlusMinusSize = new System.Drawing.Size(9, 9);
            treeNodeAdv1.ShowLine = true;
            treeNodeAdv1.Tag = "Continent";
            treeNodeAdv1.Text = "North America";
            treeNodeAdv1.TextColor = System.Drawing.Color.Tomato;
            treeNodeAdv2.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv2.EnsureDefaultOptionedChild = true;
            treeNodeAdv2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            treeNodeAdv2.MultiLine = true;
            treeNodeAdv2.PlusMinusSize = new System.Drawing.Size(9, 9);
            treeNodeAdv2.ShowLine = true;
            treeNodeAdv2.Tag = "Continent";
            treeNodeAdv2.Text = "South America";
            treeNodeAdv2.TextColor = System.Drawing.Color.Tomato;
            treeNodeAdv3.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv3.EnsureDefaultOptionedChild = true;
            treeNodeAdv3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            treeNodeAdv3.MultiLine = true;
            treeNodeAdv3.PlusMinusSize = new System.Drawing.Size(9, 9);
            treeNodeAdv3.ShowLine = true;
            treeNodeAdv3.Tag = "Continent";
            treeNodeAdv3.Text = "Antarctica";
            treeNodeAdv3.TextColor = System.Drawing.Color.Tomato;
            treeNodeAdv4.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv4.EnsureDefaultOptionedChild = true;
            treeNodeAdv4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            treeNodeAdv4.MultiLine = true;
            treeNodeAdv4.PlusMinusSize = new System.Drawing.Size(9, 9);
            treeNodeAdv4.ShowLine = true;
            treeNodeAdv4.Tag = "Continent";
            treeNodeAdv4.Text = "Europe";
            treeNodeAdv4.TextColor = System.Drawing.Color.Tomato;
            treeNodeAdv5.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv5.EnsureDefaultOptionedChild = true;
            treeNodeAdv5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            treeNodeAdv5.MultiLine = true;
            treeNodeAdv5.PlusMinusSize = new System.Drawing.Size(9, 9);
            treeNodeAdv5.ShowLine = true;
            treeNodeAdv5.Tag = "Continent";
            treeNodeAdv5.Text = "Asia";
            treeNodeAdv5.TextColor = System.Drawing.Color.Tomato;
            treeNodeAdv6.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv6.EnsureDefaultOptionedChild = true;
            treeNodeAdv6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            treeNodeAdv6.MultiLine = true;
            treeNodeAdv6.PlusMinusSize = new System.Drawing.Size(9, 9);
            treeNodeAdv6.ShowLine = true;
            treeNodeAdv6.Tag = "Continent";
            treeNodeAdv6.Text = "Africa";
            treeNodeAdv6.TextColor = System.Drawing.Color.Tomato;
            treeNodeAdv7.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv7.EnsureDefaultOptionedChild = true;
            treeNodeAdv7.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            treeNodeAdv7.MultiLine = true;
            treeNodeAdv7.PlusMinusSize = new System.Drawing.Size(9, 9);
            treeNodeAdv7.ShowLine = true;
            treeNodeAdv7.Tag = "Continent";
            treeNodeAdv7.Text = "Australia";
            treeNodeAdv7.TextColor = System.Drawing.Color.Tomato;
            treeNodeAdv8.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv8.EnsureDefaultOptionedChild = true;
            treeNodeAdv8.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            treeNodeAdv8.MultiLine = true;
            treeNodeAdv8.PlusMinusSize = new System.Drawing.Size(9, 9);
            treeNodeAdv8.ShowLine = true;
            treeNodeAdv8.Text = "Australia";
            treeNodeAdv8.TextColor = System.Drawing.Color.Blue;
            treeNodeAdv9.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv9.EnsureDefaultOptionedChild = true;
            treeNodeAdv9.MultiLine = true;
            treeNodeAdv9.PlusMinusSize = new System.Drawing.Size(9, 9);
            treeNodeAdv9.ShowLine = true;
            treeNodeAdv9.Text = "Austria";
            treeNodeAdv9.TextColor = System.Drawing.Color.Blue;
            treeNodeAdv10.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv10.EnsureDefaultOptionedChild = true;
            treeNodeAdv10.MultiLine = true;
            treeNodeAdv10.PlusMinusSize = new System.Drawing.Size(9, 9);
            treeNodeAdv10.ShowLine = true;
            treeNodeAdv10.Text = "Belgium";
            treeNodeAdv10.TextColor = System.Drawing.Color.Blue;
            treeNodeAdv11.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv11.EnsureDefaultOptionedChild = true;
            treeNodeAdv11.MultiLine = true;
            treeNodeAdv11.PlusMinusSize = new System.Drawing.Size(9, 9);
            treeNodeAdv11.ShowLine = true;
            treeNodeAdv11.Text = "Brazil";
            treeNodeAdv11.TextColor = System.Drawing.Color.Blue;
            treeNodeAdv12.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv12.EnsureDefaultOptionedChild = true;
            treeNodeAdv12.MultiLine = true;
            treeNodeAdv12.PlusMinusSize = new System.Drawing.Size(9, 9);
            treeNodeAdv12.ShowLine = true;
            treeNodeAdv12.Text = "Canada";
            treeNodeAdv12.TextColor = System.Drawing.Color.Blue;
            treeNodeAdv13.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv13.EnsureDefaultOptionedChild = true;
            treeNodeAdv13.MultiLine = true;
            treeNodeAdv13.PlusMinusSize = new System.Drawing.Size(9, 9);
            treeNodeAdv13.ShowLine = true;
            treeNodeAdv13.Text = "Denmark";
            treeNodeAdv13.TextColor = System.Drawing.Color.Blue;
            treeNodeAdv14.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv14.EnsureDefaultOptionedChild = true;
            treeNodeAdv14.MultiLine = true;
            treeNodeAdv14.PlusMinusSize = new System.Drawing.Size(9, 9);
            treeNodeAdv14.ShowLine = true;
            treeNodeAdv14.Text = "Finland";
            treeNodeAdv14.TextColor = System.Drawing.Color.Blue;
            treeNodeAdv15.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv15.EnsureDefaultOptionedChild = true;
            treeNodeAdv15.MultiLine = true;
            treeNodeAdv15.PlusMinusSize = new System.Drawing.Size(9, 9);
            treeNodeAdv15.ShowLine = true;
            treeNodeAdv15.Text = "France";
            treeNodeAdv15.TextColor = System.Drawing.Color.Blue;
            treeNodeAdv16.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv16.EnsureDefaultOptionedChild = true;
            treeNodeAdv16.MultiLine = true;
            treeNodeAdv16.PlusMinusSize = new System.Drawing.Size(9, 9);
            treeNodeAdv16.ShowLine = true;
            treeNodeAdv16.Text = "Germany";
            treeNodeAdv16.TextColor = System.Drawing.Color.Blue;
            treeNodeAdv17.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv17.EnsureDefaultOptionedChild = true;
            treeNodeAdv17.MultiLine = true;
            treeNodeAdv17.PlusMinusSize = new System.Drawing.Size(9, 9);
            treeNodeAdv17.ShowLine = true;
            treeNodeAdv17.Text = "Ireland";
            treeNodeAdv17.TextColor = System.Drawing.Color.Blue;
            treeNodeAdv18.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv18.EnsureDefaultOptionedChild = true;
            treeNodeAdv18.MultiLine = true;
            treeNodeAdv18.PlusMinusSize = new System.Drawing.Size(9, 9);
            treeNodeAdv18.ShowLine = true;
            treeNodeAdv18.Text = "Italy";
            treeNodeAdv18.TextColor = System.Drawing.Color.Blue;
            treeNodeAdv19.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv19.EnsureDefaultOptionedChild = true;
            treeNodeAdv19.MultiLine = true;
            treeNodeAdv19.PlusMinusSize = new System.Drawing.Size(9, 9);
            treeNodeAdv19.ShowLine = true;
            treeNodeAdv19.Text = "Japan";
            treeNodeAdv19.TextColor = System.Drawing.Color.Blue;
            treeNodeAdv20.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv20.EnsureDefaultOptionedChild = true;
            treeNodeAdv20.MultiLine = true;
            treeNodeAdv20.PlusMinusSize = new System.Drawing.Size(9, 9);
            treeNodeAdv20.ShowLine = true;
            treeNodeAdv20.Text = "Mexico";
            treeNodeAdv20.TextColor = System.Drawing.Color.Blue;
            treeNodeAdv21.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv21.EnsureDefaultOptionedChild = true;
            treeNodeAdv21.MultiLine = true;
            treeNodeAdv21.PlusMinusSize = new System.Drawing.Size(9, 9);
            treeNodeAdv21.ShowLine = true;
            treeNodeAdv21.Text = "Netherlands";
            treeNodeAdv21.TextColor = System.Drawing.Color.Blue;
            treeNodeAdv22.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv22.EnsureDefaultOptionedChild = true;
            treeNodeAdv22.MultiLine = true;
            treeNodeAdv22.PlusMinusSize = new System.Drawing.Size(9, 9);
            treeNodeAdv22.ShowLine = true;
            treeNodeAdv22.Text = "Norway";
            treeNodeAdv22.TextColor = System.Drawing.Color.Blue;
            treeNodeAdv23.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv23.EnsureDefaultOptionedChild = true;
            treeNodeAdv23.MultiLine = true;
            treeNodeAdv23.PlusMinusSize = new System.Drawing.Size(9, 9);
            treeNodeAdv23.ShowLine = true;
            treeNodeAdv23.Text = "New Zealand";
            treeNodeAdv23.TextColor = System.Drawing.Color.Blue;
            treeNodeAdv24.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv24.EnsureDefaultOptionedChild = true;
            treeNodeAdv24.MultiLine = true;
            treeNodeAdv24.PlusMinusSize = new System.Drawing.Size(9, 9);
            treeNodeAdv24.ShowLine = true;
            treeNodeAdv24.Text = "Portugal";
            treeNodeAdv24.TextColor = System.Drawing.Color.Blue;
            treeNodeAdv25.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv25.EnsureDefaultOptionedChild = true;
            treeNodeAdv25.MultiLine = true;
            treeNodeAdv25.PlusMinusSize = new System.Drawing.Size(9, 9);
            treeNodeAdv25.ShowLine = true;
            treeNodeAdv25.Text = "Russia";
            treeNodeAdv25.TextColor = System.Drawing.Color.Blue;
            treeNodeAdv26.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv26.EnsureDefaultOptionedChild = true;
            treeNodeAdv26.MultiLine = true;
            treeNodeAdv26.PlusMinusSize = new System.Drawing.Size(9, 9);
            treeNodeAdv26.ShowLine = true;
            treeNodeAdv26.Text = "Spain";
            treeNodeAdv26.TextColor = System.Drawing.Color.Blue;
            treeNodeAdv27.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv27.EnsureDefaultOptionedChild = true;
            treeNodeAdv27.MultiLine = true;
            treeNodeAdv27.PlusMinusSize = new System.Drawing.Size(9, 9);
            treeNodeAdv27.ShowLine = true;
            treeNodeAdv27.Text = "Sweden";
            treeNodeAdv27.TextColor = System.Drawing.Color.Blue;
            treeNodeAdv28.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv28.EnsureDefaultOptionedChild = true;
            treeNodeAdv28.MultiLine = true;
            treeNodeAdv28.PlusMinusSize = new System.Drawing.Size(9, 9);
            treeNodeAdv28.ShowLine = true;
            treeNodeAdv28.Text = "United Kingdom";
            treeNodeAdv28.TextColor = System.Drawing.Color.Blue;
            treeNodeAdv29.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv29.EnsureDefaultOptionedChild = true;
            treeNodeAdv29.MultiLine = true;
            treeNodeAdv29.PlusMinusSize = new System.Drawing.Size(9, 9);
            treeNodeAdv29.ShowLine = true;
            treeNodeAdv29.Text = "United States";
            treeNodeAdv29.TextColor = System.Drawing.Color.Blue;
            this.treeViewAdv1.Nodes.AddRange(new Syncfusion.Windows.Forms.Tools.TreeNodeAdv[] {
            treeNodeAdv1,
            treeNodeAdv2,
            treeNodeAdv3,
            treeNodeAdv4,
            treeNodeAdv5,
            treeNodeAdv6,
            treeNodeAdv7,
            treeNodeAdv8,
            treeNodeAdv9,
            treeNodeAdv10,
            treeNodeAdv11,
            treeNodeAdv12,
            treeNodeAdv13,
            treeNodeAdv14,
            treeNodeAdv15,
            treeNodeAdv16,
            treeNodeAdv17,
            treeNodeAdv18,
            treeNodeAdv19,
            treeNodeAdv20,
            treeNodeAdv21,
            treeNodeAdv22,
            treeNodeAdv23,
            treeNodeAdv24,
            treeNodeAdv25,
            treeNodeAdv26,
            treeNodeAdv27,
            treeNodeAdv28,
            treeNodeAdv29});
            this.treeViewAdv1.PathSeparator = "/";
            this.treeViewAdv1.SelectedNodeBackground = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218))))));
            this.treeViewAdv1.SelectedNodeForeColor = System.Drawing.SystemColors.HighlightText;
            this.treeViewAdv1.ShowFocusRect = false;
            this.treeViewAdv1.Size = new System.Drawing.Size(268, 457);
            this.treeViewAdv1.Style = Syncfusion.Windows.Forms.Tools.TreeStyle.Metro;
            this.treeViewAdv1.TabIndex = 0;
            this.treeViewAdv1.Text = "treeViewAdv1";
            // 
            // 
            // 
            this.treeViewAdv1.ToolTipControl.BackColor = System.Drawing.SystemColors.Info;
            this.treeViewAdv1.ToolTipControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.treeViewAdv1.ToolTipControl.Location = new System.Drawing.Point(642, 0);
            this.treeViewAdv1.ToolTipControl.Name = "toolTip";
            this.treeViewAdv1.ToolTipControl.Size = new System.Drawing.Size(41, 15);
            this.treeViewAdv1.ToolTipControl.TabIndex = 1;
            this.treeViewAdv1.ToolTipControl.Text = "toolTip";
            this.treeViewAdv1.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.treeViewAdv_ItemDrag);
            this.treeViewAdv1.DragLeave += new System.EventHandler(this.treeViewAdv_DragLeave);
            this.treeViewAdv1.DragOver += new System.Windows.Forms.DragEventHandler(this.treeViewAdv_DragOver);
            this.treeViewAdv1.DragDrop += new System.Windows.Forms.DragEventHandler(this.treeViewAdv_DragDrop);
            this.treeViewAdv1.QueryContinueDrag += new System.Windows.Forms.QueryContinueDragEventHandler(this.treeViewAdv_QueryContinueDrag);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.checkBoxAdv1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.listView1);
            this.panel1.Controls.Add(this.HighLighterColor);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label19);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(268, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(310, 457);
            this.panel1.TabIndex = 1;
            // 
            // checkBoxAdv1
            // 
            this.checkBoxAdv1.BeforeTouchSize = new System.Drawing.Size(150, 21);
            this.checkBoxAdv1.Checked = true;
            this.checkBoxAdv1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxAdv1.DrawFocusRectangle = false;
            this.checkBoxAdv1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxAdv1.Location = new System.Drawing.Point(15, 121);
            this.checkBoxAdv1.MetroColor = System.Drawing.Color.Gray;
            this.checkBoxAdv1.Name = "checkBoxAdv1";
            this.checkBoxAdv1.Size = new System.Drawing.Size(177, 27);
            this.checkBoxAdv1.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.checkBoxAdv1.TabIndex = 45;
            this.checkBoxAdv1.Text = "ShowDragNodeCue";
            this.checkBoxAdv1.ThemesEnabled = false;
            this.checkBoxAdv1.CheckStateChanged += new System.EventHandler(this.checkBoxAdv1_CheckStateChanged);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Location = new System.Drawing.Point(-14, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(190, 23);
            this.label3.TabIndex = 43;
            this.label3.Text = "       Drag And Drop Events";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(0, 236);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(308, 219);
            this.listView1.TabIndex = 42;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Events";
            this.columnHeader1.Width = 302;
            // 
            // HighLighterColor
            // 
            this.HighLighterColor.BeforeTouchSize = new System.Drawing.Size(102, 21);
            this.HighLighterColor.Border3DStyle = System.Windows.Forms.Border3DStyle.Flat;
            this.HighLighterColor.Buttons.Add(this.buttonEditChildButton1);
            this.HighLighterColor.ButtonStyle = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.HighLighterColor.Controls.Add(this.buttonEditChildButton1);
            this.HighLighterColor.FlatBorderColor = System.Drawing.SystemColors.AppWorkspace;
            this.HighLighterColor.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HighLighterColor.Location = new System.Drawing.Point(154, 61);
            this.HighLighterColor.MetroColor = System.Drawing.Color.DarkGray;
            this.HighLighterColor.Name = "HighLighterColor";
            this.HighLighterColor.Size = new System.Drawing.Size(102, 21);
            this.HighLighterColor.TabIndex = 39;
            this.HighLighterColor.UseVisualStyle = true;
            this.HighLighterColor.ButtonClicked += new Syncfusion.Windows.Forms.Tools.ButtonClickedEventHandler(this.HighLighterColor_ButtonClicked);
            // 
            // buttonEditChildButton1
            // 
            this.buttonEditChildButton1.BackColor = System.Drawing.Color.DarkGray;
            this.buttonEditChildButton1.BeforeTouchSize = new System.Drawing.Size(20, 17);
            this.buttonEditChildButton1.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.Flat;
            this.buttonEditChildButton1.ComboEditBackColor = System.Drawing.SystemColors.Window;
            this.buttonEditChildButton1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditChildButton1.ForeColor = System.Drawing.Color.White;
            this.buttonEditChildButton1.Image = null;
            this.buttonEditChildButton1.IsBackStageButton = false;
            this.buttonEditChildButton1.Name = "buttonEditChildButton1";
            this.buttonEditChildButton1.PreferredWidth = 20;
            this.buttonEditChildButton1.TabIndex = 1;
            this.buttonEditChildButton1.Text = "...";
            this.buttonEditChildButton1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(15, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 14);
            this.label1.TabIndex = 38;
            this.label1.Text = "DragHighlighterColor";
            // 
            // label19
            // 
            this.label19.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label19.Location = new System.Drawing.Point(-14, 8);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(180, 23);
            this.label19.TabIndex = 24;
            this.label19.Text = "       Drag And Drop Features  ";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.comboBox2.BeforeTouchSize = new System.Drawing.Size(216, 21);
            this.comboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.Location = new System.Drawing.Point(62, 136);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(216, 21);
            this.comboBox2.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.comboBox2.TabIndex = 12;
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
            this.gradientPanel1.Controls.Add(this.panel1);
            this.gradientPanel1.Controls.Add(this.treeViewAdv1);
            this.gradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gradientPanel1.Location = new System.Drawing.Point(10, 10);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(580, 459);
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
            this.CaptionFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CaptionForeColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(600, 479);
            this.Controls.Add(this.gradientPanel1);
            this.DropShadow = true;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(50, 300);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Drag and Drop";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.treeViewAdv1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxAdv1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HighLighterColor)).EndInit();
            this.HighLighterColor.ResumeLayout(false);
            this.HighLighterColor.PerformLayout();
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
            this.listView1.Items.Add(listViewItem1);
	
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
            listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] { "DragOver", e.Data.ToString() });
            this.listView1.Items.Add(listViewItem1);
	
           	
		}
		private bool CanDrop(TreeNodeAdv sourceNode, TreeNodeAdv destinationNode)
		{
			if(// Support drag and drop only within the same tree
				sourceNode.TreeView != this.treeViewAdv1 ||
				// Cannot drop into empty area
				destinationNode == null ||
				// Cannot drop over the source's parent
				destinationNode == sourceNode.Parent ||
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
            listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] { "DragLeave", e.ToString() });
            this.listView1.Items.Add(listViewItem1);
	
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
            listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] { "DragDrop", e.Data.ToString() });
            this.listView1.Items.Add(listViewItem1);
	
            
		}
		
		#endregion DEST_DRAGDROP_LOGIC
			
		#region Delegate Defintion
		
		private void treeViewDragHighlightTracker_QueryDragInsertInfo(object sender, QueryDragInsertInfoEventArgs args)
		{
            args.DragInsertColor = highlighter;
    	}

		// Specifiy the allowed drop positions for the specified highlight node.
		private void TreeDragDrop_QueryAllowedPositionsForNode(object sender, QueryAllowedPositionsEventArgs e)
		{
			if(!this.IsContinentNode(e.HighlightNode))
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

				e.ShowSelectionHighlight = 
					// Only if the source node is droppable
					this.CanDrop(this.currentSourceNode, e.HighlightNode)
					// and droppable ON the node (not beside it)
					&& e.NewDropPosition == TreeViewDropPositions.OnNode;
			}

		}
		#endregion

        #region HighLighterColor
        Color highlighter = Color.Red;
        private void HighLighterColor_ButtonClicked(object sender, ButtonClickedEventArgs args)
        {
            colorDialog1.ShowDialog();
            highlighter = colorDialog1.Color;
            this.HighLighterColor.BackColor=colorDialog1.Color;
        }
        #endregion

        #region ShowDragNodeCue
        private void checkBoxAdv1_CheckStateChanged(object sender, EventArgs e)
        {
            this.treeViewAdv1.ShowDragNodeCue = this.checkBoxAdv1.Checked;
        }
        
        #endregion

        private void Form1_Load(object sender, EventArgs e)
        {
            //this.treeViewAdv1.Office2007ScrollBars = true;
            this.scrollersFrame1.AttachedTo = this.listView1;
            this.HighLighterColor.BackColor = Color.Red;
            this.HighLighterColor.TextBox.BackColor = Color.Red;                   
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

        private void treeViewAdv2_NodeEditorValidated(object sender, TreeNodeAdvEditEventArgs e)
        {
            // Typically, you might have to update the bound data source, if any, with the new Label.
            e.Node.Text = e.Node.Text.ToUpper();
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

        #endregion

    }
#endregion
}


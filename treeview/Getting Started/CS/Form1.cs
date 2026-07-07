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
using Syncfusion.WinForms.ListView;
using System.Collections.Generic;
using Syncfusion.HighContrastTheme.WinForms;
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
        private IContainer components;
        private GradientPanel gradientPanel1;
        private ContextMenu contextMenu1;
        private MenuItem editItem;
        private MenuItem copyItem;
        private MenuItem cutItem;
        private TreeViewAdv treeViewAdv2;
        private GradientPanel panel1;
        private Label labelNodeHeight;
        private Label labelIndentSpace;
        private Label gutterSpacelabel;
        private ButtonAdv collapseButton;
        private ButtonAdv expandButton;
        private NumericUpDownExt nodeHeightUpDown;
        private NumericUpDownExt indentSpaceUpDown;
        private NumericUpDownExt gutterSpaceUpDown;
        private CheckBoxAdv fullRowSelection;
        private CheckBoxAdv nodeEdit;
        private CheckBoxAdv showOptionBox;
        private CheckBoxAdv showCheckBox;
        private CheckBoxAdv showPlusMinus;
        private CheckBoxAdv pixelScrolling;
        private Label visualStylelabel;
        private SfComboBox sfcomboBox1;
        private Panel panel2;
        private CheckBoxAdv showLines;
        #endregion

        #region Form Constructor Initialization and Disposing

        public Form1()
        {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();
            this.MinimumSize = this.Size;
        }


        /// <summary>
        /// Form load event 
        /// </summary>
        /// <param name="sender">Form </param>
        /// <param name="e">Event args for Form loading</param>
        private void Form1_Load(object sender, EventArgs e)
        {
            #region Initial settings
            this.treeViewAdv2.ThemeName = "Office2019Colorful";
            this.treeViewAdv2.HideSelection = false;
            this.showCheckBox.ThemeName = this.showPlusMinus.ThemeName = this.pixelScrolling.ThemeName =this.showOptionBox.ThemeName =
                this.nodeEdit.ThemeName = this.fullRowSelection.ThemeName = this.showLines.ThemeName = "Office2019Colorful";
            this.expandButton.ThemeName = this.collapseButton.ThemeName = "Office2019Colorful";
            this.sfcomboBox1.ThemeName = "Office2019Colorful";
            this.gutterSpaceUpDown.ThemeStyle.Font = new Font("Microsoft Sans Serif", 8.25F);
            this.nodeHeightUpDown.ThemeStyle.Font = new Font("Microsoft Sans Serif", 8.25F);
            this.indentSpaceUpDown.ThemeStyle.Font = new Font("Microsoft Sans Serif", 8.25F);

            this.gutterSpaceUpDown.ThemeName ="Office2019Colorful";
            this.indentSpaceUpDown.ThemeName ="Office2019Colorful";
            this.nodeHeightUpDown.ThemeName = "Office2019Colorful";
            // Check Box settings
            this.showCheckBox.Checked = this.treeViewAdv2.ShowCheckBoxes;
            this.showLines.Checked = this.treeViewAdv2.ShowLines;
            this.showOptionBox.Checked = this.treeViewAdv2.ShowOptionButtons;
            this.fullRowSelection.Checked = this.treeViewAdv2.FullRowSelect;
            this.showPlusMinus.Checked = this.treeViewAdv2.ShowPlusMinus;

            //NumericUpDown setting
            this.gutterSpaceUpDown.Value = this.treeViewAdv2.GutterSpace;
            this.indentSpaceUpDown.Value = this.treeViewAdv2.Indent;
            this.nodeHeightUpDown.Value = this.treeViewAdv2.ItemHeight;

            #endregion

            PopulateComboBoxItems();

            sfcomboBox1.SelectedIndex = 0;
        }

        private void PopulateComboBoxItems()
        {
            List<string> items = new List<string>();

            items.AddRange(new string[] { "Office2019Colorful","HighContrastBlack",
            "Office2016Colorful",
            "Office2016White",
            "Office2016Black",
            "Office2016DarkGray"});
            this.sfcomboBox1.DataSource = items;
            this.sfcomboBox1.AllowDropDownResize = false;
        }
        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
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
            Syncfusion.Windows.Forms.Tools.TreeNodeAdv treeNodeAdv31 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdv();
            Syncfusion.Windows.Forms.Tools.TreeNodeAdv treeNodeAdv32 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdv();
            Syncfusion.Windows.Forms.Tools.TreeNodeAdv treeNodeAdv33 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdv();
            Syncfusion.Windows.Forms.Tools.TreeNodeAdv treeNodeAdv34 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdv();
            Syncfusion.Windows.Forms.Tools.TreeNodeAdv treeNodeAdv35 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdv();
            Syncfusion.Windows.Forms.Tools.TreeViewAdvVisualStyle treeViewAdvVisualStyle1 = new Syncfusion.Windows.Forms.Tools.TreeViewAdvVisualStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));            
            this.treeViewAdv2 = new Syncfusion.Windows.Forms.Tools.TreeViewAdv();
            this.contextMenu1 = new ContextMenu();
            this.editItem = new MenuItem();
            this.copyItem = new MenuItem();
            this.cutItem = new MenuItem();
            this.gradientPanel1 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            this.visualStylelabel = new System.Windows.Forms.Label();
            this.sfcomboBox1 = new Syncfusion.WinForms.ListView.SfComboBox();
            this.labelNodeHeight = new System.Windows.Forms.Label();
            this.labelIndentSpace = new System.Windows.Forms.Label();
            this.gutterSpacelabel = new System.Windows.Forms.Label();
            this.collapseButton = new Syncfusion.Windows.Forms.ButtonAdv();
            this.expandButton = new Syncfusion.Windows.Forms.ButtonAdv();
            this.nodeHeightUpDown = new Syncfusion.Windows.Forms.Tools.NumericUpDownExt();
            this.indentSpaceUpDown = new Syncfusion.Windows.Forms.Tools.NumericUpDownExt();
            this.gutterSpaceUpDown = new Syncfusion.Windows.Forms.Tools.NumericUpDownExt();
            this.fullRowSelection = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.nodeEdit = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.showOptionBox = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.showCheckBox = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.showPlusMinus = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.showLines = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.pixelScrolling = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            ((System.ComponentModel.ISupportInitialize)(this.treeViewAdv2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel1)).BeginInit();
            this.gradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panel1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sfcomboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nodeHeightUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.indentSpaceUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gutterSpaceUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fullRowSelection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nodeEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.showOptionBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.showCheckBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.showPlusMinus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.showLines)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pixelScrolling)).BeginInit();
            this.SuspendLayout();
            // 
            // treeViewAdv2
            // 
            this.treeViewAdv2.AllowDrop = true;
            this.treeViewAdv2.BackColor = System.Drawing.Color.White;
            treeNodeAdvStyleInfo1.EnsureDefaultOptionedChild = true;
            treeNodeAdvStyleInfo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            treeNodeAdvStyleInfo1.IntermediateCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            treeNodeAdvStyleInfo1.NoChildrenImgIndex = -1;
            treeNodeAdvStyleInfo1.SelectedOptionButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            treeNodeAdvStyleInfo1.TextColor = System.Drawing.Color.Black;
            this.treeViewAdv2.BaseStylePairs.AddRange(new Syncfusion.Windows.Forms.Tools.StyleNamePair[] {
            new Syncfusion.Windows.Forms.Tools.StyleNamePair("Standard", treeNodeAdvStyleInfo1)});
            this.treeViewAdv2.BeforeTouchSize = new System.Drawing.Size(596, 511);
            this.treeViewAdv2.Border3DStyle = System.Windows.Forms.Border3DStyle.Flat;
            this.treeViewAdv2.BorderColor = System.Drawing.Color.Gainsboro;
            this.treeViewAdv2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
#if NETCORE
            this.treeViewAdv2.ContextMenuStrip = this.contextMenu1;
#else
            this.treeViewAdv2.ContextMenu = this.contextMenu1;
#endif
            this.treeViewAdv2.Dock = System.Windows.Forms.DockStyle.Fill;
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
            this.treeViewAdv2.ItemHeight = 25;
            this.treeViewAdv2.Location = new System.Drawing.Point(0, 0);
            this.treeViewAdv2.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218)))));
            this.treeViewAdv2.MinimumSize = new System.Drawing.Size(300, 0);
            this.treeViewAdv2.Name = "treeViewAdv2";
            this.treeViewAdv2.NoChildrenImgIndex = -1;
            treeNodeAdv1.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv1.ChildStyle.IntermediateCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            treeNodeAdv1.ChildStyle.SelectedOptionButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            treeNodeAdv1.EnsureDefaultOptionedChild = true;
            treeNodeAdv1.Expanded = true;
            treeNodeAdv1.MultiLine = true;
            treeNodeAdv2.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv2.ChildStyle.IntermediateCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            treeNodeAdv2.ChildStyle.SelectedOptionButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            treeNodeAdv2.EnsureDefaultOptionedChild = true;
            treeNodeAdv2.Expanded = true;
            treeNodeAdv2.MultiLine = true;
            treeNodeAdv2.Optioned = true;
            treeNodeAdv2.ShowLine = true;
            treeNodeAdv2.Text = "Inbox [23]";
            treeNodeAdv3.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv3.ChildStyle.IntermediateCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            treeNodeAdv3.ChildStyle.SelectedOptionButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            treeNodeAdv3.EnsureDefaultOptionedChild = true;
            treeNodeAdv3.MultiLine = true;
            treeNodeAdv3.ShowLine = true;
            treeNodeAdv3.Text = "Archive";
            treeNodeAdv4.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv4.ChildStyle.IntermediateCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            treeNodeAdv4.ChildStyle.SelectedOptionButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            treeNodeAdv4.EnsureDefaultOptionedChild = true;
            treeNodeAdv4.MultiLine = true;
            treeNodeAdv4.ShowLine = true;
            treeNodeAdv4.Text = "Drafts [3]";
            treeNodeAdv5.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv5.ChildStyle.IntermediateCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            treeNodeAdv5.ChildStyle.SelectedOptionButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            treeNodeAdv5.EnsureDefaultOptionedChild = true;
            treeNodeAdv5.MultiLine = true;
            treeNodeAdv5.ShowLine = true;
            treeNodeAdv5.Text = "Sent Items [4]";
            treeNodeAdv6.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv6.ChildStyle.IntermediateCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            treeNodeAdv6.ChildStyle.SelectedOptionButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            treeNodeAdv6.EnsureDefaultOptionedChild = true;
            treeNodeAdv6.MultiLine = true;
            treeNodeAdv6.ShowLine = true;
            treeNodeAdv6.Text = "Outbox";
            treeNodeAdv1.Nodes.AddRange(new Syncfusion.Windows.Forms.Tools.TreeNodeAdv[] {
            treeNodeAdv2,
            treeNodeAdv3,
            treeNodeAdv4,
            treeNodeAdv5,
            treeNodeAdv6});
            treeNodeAdv1.ShowLine = true;
            treeNodeAdv1.Text = "Favorites";
            treeNodeAdv7.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv7.ChildStyle.IntermediateCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            treeNodeAdv7.ChildStyle.SelectedOptionButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            treeNodeAdv7.EnsureDefaultOptionedChild = true;
            treeNodeAdv7.Expanded = true;
            treeNodeAdv7.MultiLine = true;
            treeNodeAdv8.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv8.ChildStyle.IntermediateCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            treeNodeAdv8.ChildStyle.SelectedOptionButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            treeNodeAdv8.EnsureDefaultOptionedChild = true;
            treeNodeAdv8.Expanded = true;
            treeNodeAdv8.MultiLine = true;
            treeNodeAdv8.Optioned = true;
            treeNodeAdv8.ShowLine = true;
            treeNodeAdv8.Text = "Inbox [23]";
            treeNodeAdv9.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv9.ChildStyle.IntermediateCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            treeNodeAdv9.ChildStyle.SelectedOptionButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            treeNodeAdv9.EnsureDefaultOptionedChild = true;
            treeNodeAdv9.MultiLine = true;
            treeNodeAdv9.ShowLine = true;
            treeNodeAdv9.Text = "Outbox";
            treeNodeAdv10.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv10.ChildStyle.IntermediateCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            treeNodeAdv10.ChildStyle.SelectedOptionButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            treeNodeAdv10.EnsureDefaultOptionedChild = true;
            treeNodeAdv10.MultiLine = true;
            treeNodeAdv10.ShowLine = true;
            treeNodeAdv10.Text = "Drafts [3]";
            treeNodeAdv11.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv11.ChildStyle.IntermediateCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            treeNodeAdv11.ChildStyle.SelectedOptionButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            treeNodeAdv11.EnsureDefaultOptionedChild = true;
            treeNodeAdv11.MultiLine = true;
            treeNodeAdv11.ShowLine = true;
            treeNodeAdv11.Text = "Sent Items [4]";
            treeNodeAdv12.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv12.ChildStyle.IntermediateCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            treeNodeAdv12.ChildStyle.SelectedOptionButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            treeNodeAdv12.EnsureDefaultOptionedChild = true;
            treeNodeAdv12.MultiLine = true;
            treeNodeAdv12.ShowLine = true;
            treeNodeAdv12.Text = "Clutter";
            treeNodeAdv13.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv13.ChildStyle.IntermediateCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            treeNodeAdv13.ChildStyle.SelectedOptionButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            treeNodeAdv13.EnsureDefaultOptionedChild = true;
            treeNodeAdv13.MultiLine = true;
            treeNodeAdv13.ShowLine = true;
            treeNodeAdv13.Text = "Archive";
            treeNodeAdv14.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv14.ChildStyle.IntermediateCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            treeNodeAdv14.ChildStyle.SelectedOptionButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            treeNodeAdv14.EnsureDefaultOptionedChild = true;
            treeNodeAdv14.MultiLine = true;
            treeNodeAdv14.ShowLine = true;
            treeNodeAdv14.Text = "Deleted Items";
            treeNodeAdv15.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv15.ChildStyle.IntermediateCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            treeNodeAdv15.ChildStyle.SelectedOptionButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            treeNodeAdv15.EnsureDefaultOptionedChild = true;
            treeNodeAdv15.Expanded = true;
            treeNodeAdv15.MultiLine = true;
            treeNodeAdv16.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv16.ChildStyle.IntermediateCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            treeNodeAdv16.ChildStyle.SelectedOptionButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            treeNodeAdv16.EnsureDefaultOptionedChild = true;
            treeNodeAdv16.MultiLine = true;
            treeNodeAdv16.Optioned = true;
            treeNodeAdv16.ShowLine = true;
            treeNodeAdv16.Text = "My Calendar";
            treeNodeAdv15.Nodes.AddRange(new Syncfusion.Windows.Forms.Tools.TreeNodeAdv[] {
            treeNodeAdv16});
            treeNodeAdv15.ShowLine = true;
            treeNodeAdv15.Text = "Calendar";
            treeNodeAdv17.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv17.ChildStyle.IntermediateCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            treeNodeAdv17.ChildStyle.SelectedOptionButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            treeNodeAdv17.EnsureDefaultOptionedChild = true;
            treeNodeAdv17.MultiLine = true;
            treeNodeAdv17.ShowLine = true;
            treeNodeAdv17.Text = "Contacts";
            treeNodeAdv18.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv18.ChildStyle.IntermediateCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            treeNodeAdv18.ChildStyle.SelectedOptionButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            treeNodeAdv18.EnsureDefaultOptionedChild = true;
            treeNodeAdv18.MultiLine = true;
            treeNodeAdv18.ShowLine = true;
            treeNodeAdv18.Text = "Conversation History";
            treeNodeAdv19.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv19.ChildStyle.IntermediateCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            treeNodeAdv19.ChildStyle.SelectedOptionButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            treeNodeAdv19.EnsureDefaultOptionedChild = true;
            treeNodeAdv19.MultiLine = true;
            treeNodeAdv19.ShowLine = true;
            treeNodeAdv19.Text = "Journal";
            treeNodeAdv20.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv20.ChildStyle.IntermediateCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            treeNodeAdv20.ChildStyle.SelectedOptionButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            treeNodeAdv20.EnsureDefaultOptionedChild = true;
            treeNodeAdv20.MultiLine = true;
            treeNodeAdv20.ShowLine = true;
            treeNodeAdv20.Text = "Junk Email";
            treeNodeAdv21.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv21.ChildStyle.IntermediateCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            treeNodeAdv21.ChildStyle.SelectedOptionButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            treeNodeAdv21.EnsureDefaultOptionedChild = true;
            treeNodeAdv21.MultiLine = true;
            treeNodeAdv21.ShowLine = true;
            treeNodeAdv21.Text = "Notes";
            treeNodeAdv22.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv22.ChildStyle.IntermediateCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            treeNodeAdv22.ChildStyle.SelectedOptionButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            treeNodeAdv22.EnsureDefaultOptionedChild = true;
            treeNodeAdv22.IntermediateCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            treeNodeAdv22.MultiLine = true;
            treeNodeAdv22.SelectedOptionButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            treeNodeAdv22.ShowLine = true;
            treeNodeAdv22.Text = "RSS Subscriptions";
            treeNodeAdv23.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv23.ChildStyle.IntermediateCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            treeNodeAdv23.ChildStyle.SelectedOptionButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            treeNodeAdv23.EnsureDefaultOptionedChild = true;
            treeNodeAdv23.Expanded = true;
            treeNodeAdv23.IntermediateCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            treeNodeAdv23.MultiLine = true;
            treeNodeAdv24.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv24.ChildStyle.IntermediateCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            treeNodeAdv24.ChildStyle.SelectedOptionButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            treeNodeAdv24.EnsureDefaultOptionedChild = true;
            treeNodeAdv24.IntermediateCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            treeNodeAdv24.MultiLine = true;
            treeNodeAdv24.SelectedOptionButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            treeNodeAdv24.ShowLine = true;
            treeNodeAdv24.Text = "Missed Calls";
            treeNodeAdv25.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv25.ChildStyle.IntermediateCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            treeNodeAdv25.ChildStyle.SelectedOptionButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            treeNodeAdv25.EnsureDefaultOptionedChild = true;
            treeNodeAdv25.IntermediateCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            treeNodeAdv25.MultiLine = true;
            treeNodeAdv25.SelectedOptionButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            treeNodeAdv25.ShowLine = true;
            treeNodeAdv25.Text = "Missed Conversations";
            treeNodeAdv26.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv26.ChildStyle.IntermediateCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            treeNodeAdv26.ChildStyle.SelectedOptionButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            treeNodeAdv26.EnsureDefaultOptionedChild = true;
            treeNodeAdv26.IntermediateCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            treeNodeAdv26.MultiLine = true;
            treeNodeAdv26.SelectedOptionButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            treeNodeAdv26.ShowLine = true;
            treeNodeAdv26.Text = "Voice Mail";
            treeNodeAdv23.Nodes.AddRange(new Syncfusion.Windows.Forms.Tools.TreeNodeAdv[] {
            treeNodeAdv24,
            treeNodeAdv25,
            treeNodeAdv26});
            treeNodeAdv23.SelectedOptionButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            treeNodeAdv23.ShowLine = true;
            treeNodeAdv23.Text = "Search Folders";
            treeNodeAdv7.Nodes.AddRange(new Syncfusion.Windows.Forms.Tools.TreeNodeAdv[] {
            treeNodeAdv8,
            treeNodeAdv9,
            treeNodeAdv10,
            treeNodeAdv11,
            treeNodeAdv12,
            treeNodeAdv13,
            treeNodeAdv14,
            treeNodeAdv15,
            treeNodeAdv17,
            treeNodeAdv18,
            treeNodeAdv19,
            treeNodeAdv20,
            treeNodeAdv21,
            treeNodeAdv22,
            treeNodeAdv23});
            treeNodeAdv7.ShowLine = true;
            treeNodeAdv7.Text = "Robert.Downey@outlook.com";
            treeNodeAdv27.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv27.ChildStyle.IntermediateCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            treeNodeAdv27.ChildStyle.SelectedOptionButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            treeNodeAdv27.EnsureDefaultOptionedChild = true;
            treeNodeAdv27.Expanded = true;
            treeNodeAdv27.IntermediateCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            treeNodeAdv27.MultiLine = true;
            treeNodeAdv28.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv28.ChildStyle.IntermediateCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            treeNodeAdv28.ChildStyle.SelectedOptionButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            treeNodeAdv28.EnsureDefaultOptionedChild = true;
            treeNodeAdv28.IntermediateCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            treeNodeAdv28.MultiLine = true;
            treeNodeAdv28.SelectedOptionButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            treeNodeAdv28.ShowLine = true;
            treeNodeAdv28.Text = "Sales Team";
            treeNodeAdv29.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv29.ChildStyle.IntermediateCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            treeNodeAdv29.ChildStyle.SelectedOptionButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            treeNodeAdv29.EnsureDefaultOptionedChild = true;
            treeNodeAdv29.IntermediateCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            treeNodeAdv29.MultiLine = true;
            treeNodeAdv29.SelectedOptionButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            treeNodeAdv29.ShowLine = true;
            treeNodeAdv29.Text = "Support Team";
            treeNodeAdv27.Nodes.AddRange(new Syncfusion.Windows.Forms.Tools.TreeNodeAdv[] {
            treeNodeAdv28,
            treeNodeAdv29});
            treeNodeAdv27.SelectedOptionButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            treeNodeAdv27.ShowLine = true;
            treeNodeAdv27.Text = "Groups";
            treeNodeAdv30.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv30.ChildStyle.IntermediateCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            treeNodeAdv30.ChildStyle.SelectedOptionButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            treeNodeAdv30.EnsureDefaultOptionedChild = true;
            treeNodeAdv30.Expanded = true;
            treeNodeAdv30.IntermediateCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            treeNodeAdv30.MultiLine = true;
            treeNodeAdv31.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv31.ChildStyle.IntermediateCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            treeNodeAdv31.ChildStyle.SelectedOptionButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            treeNodeAdv31.EnsureDefaultOptionedChild = true;
            treeNodeAdv31.IntermediateCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            treeNodeAdv31.MultiLine = true;
            treeNodeAdv31.SelectedOptionButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            treeNodeAdv31.ShowLine = true;
            treeNodeAdv31.Text = "My Calendar";
            treeNodeAdv32.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv32.ChildStyle.IntermediateCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            treeNodeAdv32.ChildStyle.SelectedOptionButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            treeNodeAdv32.EnsureDefaultOptionedChild = true;
            treeNodeAdv32.IntermediateCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            treeNodeAdv32.MultiLine = true;
            treeNodeAdv32.SelectedOptionButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            treeNodeAdv32.ShowLine = true;
            treeNodeAdv32.Text = "Birthdays";
            treeNodeAdv33.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv33.ChildStyle.IntermediateCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            treeNodeAdv33.ChildStyle.SelectedOptionButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            treeNodeAdv33.EnsureDefaultOptionedChild = true;
            treeNodeAdv33.IntermediateCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            treeNodeAdv33.MultiLine = true;
            treeNodeAdv33.SelectedOptionButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            treeNodeAdv33.ShowLine = true;
            treeNodeAdv33.Text = "Holidays";
            treeNodeAdv30.Nodes.AddRange(new Syncfusion.Windows.Forms.Tools.TreeNodeAdv[] {
            treeNodeAdv31,
            treeNodeAdv32,
            treeNodeAdv33});
            treeNodeAdv30.SelectedOptionButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            treeNodeAdv30.ShowLine = true;
            treeNodeAdv30.Text = "Favorite Group Calendar";
            treeNodeAdv34.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv34.ChildStyle.IntermediateCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            treeNodeAdv34.ChildStyle.SelectedOptionButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            treeNodeAdv34.EnsureDefaultOptionedChild = true;
            treeNodeAdv34.Expanded = true;
            treeNodeAdv34.IntermediateCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            treeNodeAdv34.MultiLine = true;
            treeNodeAdv35.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv35.ChildStyle.IntermediateCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            treeNodeAdv35.ChildStyle.SelectedOptionButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            treeNodeAdv35.EnsureDefaultOptionedChild = true;
            treeNodeAdv35.IntermediateCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            treeNodeAdv35.MultiLine = true;
            treeNodeAdv35.SelectedOptionButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            treeNodeAdv35.ShowLine = true;
            treeNodeAdv35.Text = "All Public Folders";
            treeNodeAdv34.Nodes.AddRange(new Syncfusion.Windows.Forms.Tools.TreeNodeAdv[] {
            treeNodeAdv35});
            treeNodeAdv34.SelectedOptionButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            treeNodeAdv34.ShowLine = true;
            treeNodeAdv34.Text = "Public Folders";
            this.treeViewAdv2.Nodes.AddRange(new Syncfusion.Windows.Forms.Tools.TreeNodeAdv[] {
            treeNodeAdv1,
            treeNodeAdv7,
            treeNodeAdv27,
            treeNodeAdv30,
            treeNodeAdv34});
            this.treeViewAdv2.PathSeparator = "/";
            this.treeViewAdv2.SelectedNodeBackground = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218))))));
            this.treeViewAdv2.SelectedNodeForeColor = System.Drawing.SystemColors.HighlightText;
            this.treeViewAdv2.ShowFocusRect = false;
            this.treeViewAdv2.ShowLines = false;
            this.treeViewAdv2.Size = new System.Drawing.Size(596, 511);
            this.treeViewAdv2.Style = Syncfusion.Windows.Forms.Tools.TreeStyle.Metro;
            this.treeViewAdv2.TabIndex = 3;
            this.treeViewAdv2.Text = "treeViewAdv2";
            this.treeViewAdv2.ThemeName = "Metro";
            treeViewAdvVisualStyle1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            treeViewAdvVisualStyle1.TreeNodeAdvStyle.EnsureDefaultOptionedChild = true;
            treeViewAdvVisualStyle1.TreeNodeAdvStyle.IntermediateCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
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
            // 
            // contextMenu1
            // 
#if NETCORE
            this.contextMenu1.Items.AddRange(new MenuItem[] {
#else
            this.contextMenu1.MenuItems.AddRange(new MenuItem[] {
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
            // gradientPanel1
            // 
            this.gradientPanel1.BorderColor = System.Drawing.Color.DarkGray;
            this.gradientPanel1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gradientPanel1.Controls.Add(this.treeViewAdv2);
            this.gradientPanel1.Controls.Add(this.panel2);
            this.gradientPanel1.Controls.Add(this.panel1);
            this.gradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gradientPanel1.Location = new System.Drawing.Point(10, 10);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(900, 511);
            this.gradientPanel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(596, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(8, 511);
            this.panel2.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.visualStylelabel);
            this.panel1.Controls.Add(this.sfcomboBox1);
            this.panel1.Controls.Add(this.labelNodeHeight);
            this.panel1.Controls.Add(this.labelIndentSpace);
            this.panel1.Controls.Add(this.gutterSpacelabel);
            this.panel1.Controls.Add(this.collapseButton);
            this.panel1.Controls.Add(this.expandButton);
            this.panel1.Controls.Add(this.nodeHeightUpDown);
            this.panel1.Controls.Add(this.indentSpaceUpDown);
            this.panel1.Controls.Add(this.gutterSpaceUpDown);
            this.panel1.Controls.Add(this.fullRowSelection);
            this.panel1.Controls.Add(this.nodeEdit);
            this.panel1.Controls.Add(this.showOptionBox);
            this.panel1.Controls.Add(this.showCheckBox);
            this.panel1.Controls.Add(this.showPlusMinus);
            this.panel1.Controls.Add(this.showLines);
            this.panel1.Controls.Add(this.pixelScrolling);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(604, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(296, 511);
            this.panel1.TabIndex = 4;
            // 
            // visualStylelabel
            // 
            this.visualStylelabel.AutoSize = true;
            this.visualStylelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.visualStylelabel.ForeColor = System.Drawing.Color.Black;
            this.visualStylelabel.Location = new System.Drawing.Point(33, 283);
            this.visualStylelabel.Name = "visualStylelabel";
            this.visualStylelabel.Size = new System.Drawing.Size(69, 15);
            this.visualStylelabel.TabIndex = 16;
            this.visualStylelabel.Text = "Visual Style";
            // 
            // sfcomboBox1
            // 
            this.sfcomboBox1.AllowDropDownResize = false;
            this.sfcomboBox1.DropDownStyle = Syncfusion.WinForms.ListView.Enums.DropDownStyle.DropDownList;
            this.sfcomboBox1.Location = new System.Drawing.Point(129, 281);
            this.sfcomboBox1.Name = "sfcomboBox1";
            this.sfcomboBox1.Size = new System.Drawing.Size(133, 23);
            this.sfcomboBox1.TabIndex = 15;
            this.sfcomboBox1.Text = "Office2019Colorful";
            this.sfcomboBox1.SelectedIndexChanged += new System.EventHandler(this.sfComboBox1_SelectedIndexChanged);
            // 
            // labelNodeHeight
            // 
            this.labelNodeHeight.AutoSize = true;
            this.labelNodeHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNodeHeight.ForeColor = System.Drawing.Color.Black;
            this.labelNodeHeight.Location = new System.Drawing.Point(32, 391);
            this.labelNodeHeight.Name = "labelNodeHeight";
            this.labelNodeHeight.Size = new System.Drawing.Size(76, 15);
            this.labelNodeHeight.TabIndex = 14;
            this.labelNodeHeight.Text = "Node Height";
            // 
            // labelIndentSpace
            // 
            this.labelIndentSpace.AutoSize = true;
            this.labelIndentSpace.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIndentSpace.ForeColor = System.Drawing.Color.Black;
            this.labelIndentSpace.Location = new System.Drawing.Point(32, 356);
            this.labelIndentSpace.Name = "labelIndentSpace";
            this.labelIndentSpace.Size = new System.Drawing.Size(79, 15);
            this.labelIndentSpace.TabIndex = 13;
            this.labelIndentSpace.Text = "Indent Space";
            // 
            // gutterSpacelabel
            // 
            this.gutterSpacelabel.AutoSize = true;
            this.gutterSpacelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gutterSpacelabel.ForeColor = System.Drawing.Color.Black;
            this.gutterSpacelabel.Location = new System.Drawing.Point(32, 321);
            this.gutterSpacelabel.Name = "gutterSpacelabel";
            this.gutterSpacelabel.Size = new System.Drawing.Size(78, 15);
            this.gutterSpacelabel.TabIndex = 12;
            this.gutterSpacelabel.Text = "Gutter Space";
            // 
            // collapseButton
            // 
            this.collapseButton.AccessibleName = "Button";
            this.collapseButton.BeforeTouchSize = new System.Drawing.Size(230, 28);
            this.collapseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.collapseButton.IsBackStageButton = false;
            this.collapseButton.Location = new System.Drawing.Point(32, 467);
            this.collapseButton.Name = "collapseButton";
            this.collapseButton.Size = new System.Drawing.Size(230, 28);
            this.collapseButton.TabIndex = 11;
            this.collapseButton.Text = "Collapse All";
            this.collapseButton.UseVisualStyle = true;
            this.collapseButton.UseVisualStyleBackColor = true;
            this.collapseButton.Click += new System.EventHandler(this.expandButton_Click);
            // 
            // expandButton
            // 
            this.expandButton.AccessibleName = "Button";
            this.expandButton.BeforeTouchSize = new System.Drawing.Size(230, 28);
            this.expandButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expandButton.IsBackStageButton = false;
            this.expandButton.Location = new System.Drawing.Point(32, 423);
            this.expandButton.Name = "expandButton";
            this.expandButton.Size = new System.Drawing.Size(230, 28);
            this.expandButton.TabIndex = 10;
            this.expandButton.Text = "Expand All ";
            this.expandButton.UseVisualStyle = true;
            this.expandButton.UseVisualStyleBackColor = true;
            this.expandButton.Click += new System.EventHandler(this.expandButton_Click);
            // 
            // nodeHeightUpDown
            // 
            this.nodeHeightUpDown.BeforeTouchSize = new System.Drawing.Size(133, 21);
            this.nodeHeightUpDown.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nodeHeightUpDown.Location = new System.Drawing.Point(129, 389);
            this.nodeHeightUpDown.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nodeHeightUpDown.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.nodeHeightUpDown.Minimum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.nodeHeightUpDown.Name = "nodeHeightUpDown";
            this.nodeHeightUpDown.Size = new System.Drawing.Size(133, 21);
            this.nodeHeightUpDown.TabIndex = 9;
            this.nodeHeightUpDown.ThemeStyle.HoverUpDownForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.nodeHeightUpDown.ThemeStyle.PressedUpDownForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.nodeHeightUpDown.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.nodeHeightUpDown.ValueChanged += new System.EventHandler(this.nodeHeightUpDown_ValueChanged);
            // 
            // indentSpaceUpDown
            // 
            this.indentSpaceUpDown.BeforeTouchSize = new System.Drawing.Size(133, 21);
            this.indentSpaceUpDown.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.indentSpaceUpDown.Location = new System.Drawing.Point(129, 354);
            this.indentSpaceUpDown.Maximum = new decimal(new int[] {
            35,
            0,
            0,
            0});
            this.indentSpaceUpDown.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.indentSpaceUpDown.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.indentSpaceUpDown.Name = "indentSpaceUpDown";
            this.indentSpaceUpDown.Size = new System.Drawing.Size(133, 21);
            this.indentSpaceUpDown.TabIndex = 8;
            this.indentSpaceUpDown.ThemeStyle.HoverUpDownForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.indentSpaceUpDown.ThemeStyle.PressedUpDownForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.indentSpaceUpDown.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.indentSpaceUpDown.ValueChanged += new System.EventHandler(this.nodeHeightUpDown_ValueChanged);
            // 
            // gutterSpaceUpDown
            // 
            this.gutterSpaceUpDown.BeforeTouchSize = new System.Drawing.Size(133, 21);
            this.gutterSpaceUpDown.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gutterSpaceUpDown.Location = new System.Drawing.Point(129, 319);
            this.gutterSpaceUpDown.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.gutterSpaceUpDown.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.gutterSpaceUpDown.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.gutterSpaceUpDown.Name = "gutterSpaceUpDown";
            this.gutterSpaceUpDown.Size = new System.Drawing.Size(133, 21);
            this.gutterSpaceUpDown.TabIndex = 7;
            this.gutterSpaceUpDown.ThemeStyle.HoverUpDownForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.gutterSpaceUpDown.ThemeStyle.PressedUpDownForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.gutterSpaceUpDown.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.gutterSpaceUpDown.ValueChanged += new System.EventHandler(this.nodeHeightUpDown_ValueChanged);
            // 
            // fullRowSelection
            // 
            this.fullRowSelection.BeforeTouchSize = new System.Drawing.Size(150, 21);
            this.fullRowSelection.Location = new System.Drawing.Point(32, 200);
            this.fullRowSelection.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(89)))), ((int)(((byte)(91)))));
            this.fullRowSelection.Name = "fullRowSelection";
            this.fullRowSelection.Size = new System.Drawing.Size(150, 21);
            this.fullRowSelection.TabIndex = 6;
            this.fullRowSelection.Text = "Allow full row selection";
            this.fullRowSelection.ThemesEnabled = false;
            this.fullRowSelection.CheckedChanged += new System.EventHandler(this.checkBoxAdv6_CheckedChanged);
            // 
            // nodeEdit
            // 
            this.nodeEdit.BeforeTouchSize = new System.Drawing.Size(150, 21);
            this.nodeEdit.Location = new System.Drawing.Point(32, 163);
            this.nodeEdit.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(89)))), ((int)(((byte)(91)))));
            this.nodeEdit.Name = "nodeEdit";
            this.nodeEdit.Size = new System.Drawing.Size(150, 21);
            this.nodeEdit.TabIndex = 5;
            this.nodeEdit.Text = "Allow editing of nodes";
            this.nodeEdit.ThemesEnabled = false;
            this.nodeEdit.CheckedChanged += new System.EventHandler(this.checkBoxAdv6_CheckedChanged);
            // 
            // showOptionBox
            // 
            this.showOptionBox.BeforeTouchSize = new System.Drawing.Size(150, 21);
            this.showOptionBox.Location = new System.Drawing.Point(32, 125);
            this.showOptionBox.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(89)))), ((int)(((byte)(91)))));
            this.showOptionBox.Name = "showOptionBox";
            this.showOptionBox.Size = new System.Drawing.Size(150, 21);
            this.showOptionBox.TabIndex = 4;
            this.showOptionBox.Text = "Show OptionBox";
            this.showOptionBox.ThemesEnabled = false;
            this.showOptionBox.CheckedChanged += new System.EventHandler(this.checkBoxAdv6_CheckedChanged);
            // 
            // showCheckBox
            // 
            this.showCheckBox.BeforeTouchSize = new System.Drawing.Size(150, 21);
            this.showCheckBox.Location = new System.Drawing.Point(32, 89);
            this.showCheckBox.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(89)))), ((int)(((byte)(91)))));
            this.showCheckBox.Name = "showCheckBox";
            this.showCheckBox.Size = new System.Drawing.Size(150, 21);
            this.showCheckBox.TabIndex = 3;
            this.showCheckBox.Text = "Show CheckBox";
            this.showCheckBox.ThemesEnabled = false;
            this.showCheckBox.CheckedChanged += new System.EventHandler(this.checkBoxAdv6_CheckedChanged);
            // 
            // showPlusMinus
            // 
            this.showPlusMinus.BeforeTouchSize = new System.Drawing.Size(150, 21);
            this.showPlusMinus.Location = new System.Drawing.Point(32, 50);
            this.showPlusMinus.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(89)))), ((int)(((byte)(91)))));
            this.showPlusMinus.Name = "showPlusMinus";
            this.showPlusMinus.Size = new System.Drawing.Size(150, 21);
            this.showPlusMinus.TabIndex = 2;
            this.showPlusMinus.Text = "Show Plus Minus";
            this.showPlusMinus.ThemesEnabled = false;
            this.showPlusMinus.CheckedChanged += new System.EventHandler(this.checkBoxAdv6_CheckedChanged);
            // 
            // showLines
            // 
            this.showLines.BeforeTouchSize = new System.Drawing.Size(150, 21);
            this.showLines.Location = new System.Drawing.Point(32, 12);
            this.showLines.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(89)))), ((int)(((byte)(91)))));
            this.showLines.Name = "showLines";
            this.showLines.Size = new System.Drawing.Size(150, 21);
            this.showLines.TabIndex = 1;
            this.showLines.Text = "Show Lines";
            this.showLines.ThemesEnabled = false;
            this.showLines.CheckedChanged += new System.EventHandler(this.checkBoxAdv6_CheckedChanged);
            // 
            // pixelScrolling
            // 
            this.pixelScrolling.BeforeTouchSize = new System.Drawing.Size(150, 21);
            this.pixelScrolling.Location = new System.Drawing.Point(32, 236);
            this.pixelScrolling.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(89)))), ((int)(((byte)(91)))));
            this.pixelScrolling.Name = "pixelScrolling";
            this.pixelScrolling.Size = new System.Drawing.Size(150, 21);
            this.pixelScrolling.TabIndex = 1;
            this.pixelScrolling.Text = "Pixel Scrolling";
            this.pixelScrolling.ThemesEnabled = false;
            this.pixelScrolling.Checked = true;
            this.treeViewAdv2.VScrollPixel = !this.treeViewAdv2.VScrollPixel;
            this.pixelScrolling.CheckedChanged += PixelScrolling_CheckedChanged;
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
            this.ClientSize = new System.Drawing.Size(920, 531);
            this.Controls.Add(this.gradientPanel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(50, 300);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Getting Started";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.treeViewAdv2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel1)).EndInit();
            this.gradientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panel1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sfcomboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nodeHeightUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.indentSpaceUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gutterSpaceUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fullRowSelection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nodeEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.showOptionBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.showCheckBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.showPlusMinus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.showLines)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pixelScrolling)).EndInit();
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
            SkinManager.LoadAssembly(typeof(Syncfusion.WinForms.Themes.Office2019Theme).Assembly);
            SkinManager.LoadAssembly(typeof(Syncfusion.WinForms.Themes.Office2016Theme).Assembly);
            SkinManager.LoadAssembly(typeof(HighContrastTheme).Assembly);
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

        #region Properties
        private void checkBoxAdv6_CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as CheckBoxAdv).Name.Equals("showCheckBox"))
            {
                this.treeViewAdv2.ShowCheckBoxes = this.showCheckBox.Checked;
                if (showCheckBox.Checked)
                    this.showOptionBox.Checked = false;
            }
            else if ((sender as CheckBoxAdv).Name.Equals("showOptionBox"))
            {
                this.treeViewAdv2.ShowOptionButtons = this.showOptionBox.Checked;
                if (showOptionBox.Checked)
                    this.showCheckBox.Checked = false;
            }
            else if ((sender as CheckBoxAdv).Name.Equals("showLines"))
            {
                this.treeViewAdv2.ShowLines = this.showLines.Checked;
            }
            else if ((sender as CheckBoxAdv).Name.Equals("fullRowSelection"))
            {
                this.treeViewAdv2.FullRowSelect = this.fullRowSelection.Checked;
            }
            else if ((sender as CheckBoxAdv).Name.Equals("nodeEdit"))
            {
                this.treeViewAdv2.LabelEdit = this.nodeEdit.Checked;
            }
            else if ((sender as CheckBoxAdv).Name.Equals("showPlusMinus"))
            {
                this.treeViewAdv2.ShowPlusMinus = this.showPlusMinus.Checked;
            }
        }

        private void PixelScrolling_CheckedChanged(object sender, EventArgs e)
        {
            if (this.pixelScrolling.Checked)
            {
                this.treeViewAdv2.VScrollPixel = !this.treeViewAdv2.VScrollPixel;
            }
            else
            {
                this.treeViewAdv2.VScrollPixel = !this.treeViewAdv2.VScrollPixel;
            }
        }
        private void nodeHeightUpDown_ValueChanged(object sender, EventArgs e)
        {
            if ((sender as NumericUpDownExt).Name.Equals("gutterSpaceUpDown"))
            {
                this.treeViewAdv2.GutterSpace = (int)this.gutterSpaceUpDown.Value;
            }
            else if ((sender as NumericUpDownExt).Name.Equals("indentSpaceUpDown"))
            {
                this.treeViewAdv2.Indent = (int)this.indentSpaceUpDown.Value;
            }
            else if ((sender as NumericUpDownExt).Name.Equals("nodeHeightUpDown"))
            {
                this.treeViewAdv2.ItemHeight = (int)this.nodeHeightUpDown.Value;
            }
        }

        private void expandButton_Click(object sender, EventArgs e)
        {
            if ((sender as ButtonAdv).Name.Equals("expandButton"))
            {
                this.treeViewAdv2.ExpandAll();
            }
            else if ((sender as ButtonAdv).Name.Equals("collapseButton"))
            {
                this.treeViewAdv2.CollapseAll();
            }
        }
        #endregion

        private void sfComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if(sfcomboBox1.SelectedIndex == 0)
            {
                this.BackColor = Color.White;
                this.Style.TitleBar.BackColor = Color.FromArgb(242, 242, 242);
                this.Style.TitleBar.CloseButtonForeColor = Color.FromArgb(51,51,51);
                this.Style.TitleBar.MinimizeButtonForeColor = Color.FromArgb(51,51,51);
                this.Style.TitleBar.MaximizeButtonForeColor = Color.FromArgb(51, 51, 51);
                this.Style.TitleBar.ForeColor = this.visualStylelabel.ForeColor = this.gutterSpacelabel.ForeColor
                    = this.labelIndentSpace.ForeColor = this.labelNodeHeight.ForeColor = Color.Black;
                SkinManager.SetVisualStyle(this, "Office2019Colorful");
                this.gradientPanel1.ThemeStyle.BackColor = Color.White; 
                this.panel1.ThemeStyle.BackColor = Color.White;
            }
            else if (sfcomboBox1.SelectedIndex == 1)
            {
                this.BackColor = Color.Black;
                this.Style.TitleBar.BackColor = Color.FromArgb(37, 37, 37);
                this.Style.TitleBar.CloseButtonForeColor = Color.White;
                this.Style.TitleBar.MinimizeButtonForeColor = Color.White;
                this.Style.TitleBar.MaximizeButtonForeColor = Color.White;
                this.Style.TitleBar.ForeColor = this.visualStylelabel.ForeColor = this.gutterSpacelabel.ForeColor
                    = this.labelIndentSpace.ForeColor = this.labelNodeHeight.ForeColor = Color.White;
                SkinManager.SetVisualStyle(this, "HighContrastBlack");
                this.gradientPanel1.ThemeStyle.BackColor = Color.Black;
                this.panel1.ThemeStyle.BorderColor = Color.White;
                this.panel1.ThemeStyle.BackColor = Color.Black;
            }
            else if(sfcomboBox1.SelectedIndex == 2)
            {
                this.BackColor = Color.White;
                this.Style.TitleBar.BackColor = Color.FromArgb(242, 242, 242);
                this.Style.TitleBar.CloseButtonForeColor = Color.FromArgb(51, 51, 51);
                this.Style.TitleBar.MinimizeButtonForeColor = Color.FromArgb(51, 51, 51);
                this.Style.TitleBar.MaximizeButtonForeColor = Color.FromArgb(51, 51, 51);
                this.Style.TitleBar.ForeColor = this.visualStylelabel.ForeColor = this.gutterSpacelabel.ForeColor
                    = this.labelIndentSpace.ForeColor = this.labelNodeHeight.ForeColor = Color.Black;
                SkinManager.SetVisualStyle(this, "Office2016Colorful");
                this.gradientPanel1.BackColor = Color.White;
                this.panel1.BackColor = Color.White;
                this.panel1.BorderColor= Color.FromArgb(210,210,210);
            }
            else if (sfcomboBox1.SelectedIndex == 4)
            {
                SkinManager.SetVisualStyle(this, "Office2016Black");
                this.BackColor = ColorTranslator.FromHtml("#262626");
                this.Style.TitleBar.BackColor = ColorTranslator.FromHtml("#363636");
                this.Style.TitleBar.CloseButtonForeColor = Color.White;
                this.Style.TitleBar.MinimizeButtonForeColor = Color.White;
                this.Style.TitleBar.MaximizeButtonForeColor = Color.White;
                this.Style.TitleBar.ForeColor = this.visualStylelabel.ForeColor = this.gutterSpacelabel.ForeColor
                    = this.labelIndentSpace.ForeColor = this.labelNodeHeight.ForeColor = Color.White;
                this.gradientPanel1.BackColor = ColorTranslator.FromHtml("#262626");
                this.panel1.BorderColor = Color.White;
                this.panel1.BackColor= ColorTranslator.FromHtml("#262626");
            }
            else if (sfcomboBox1.SelectedIndex == 3)
            {
                this.BackColor = Color.White;
                this.Style.TitleBar.BackColor = Color.FromArgb(242, 242, 242);
                this.Style.TitleBar.CloseButtonForeColor = Color.FromArgb(51, 51, 51);
                this.Style.TitleBar.MinimizeButtonForeColor = Color.FromArgb(51, 51, 51);
                this.Style.TitleBar.MaximizeButtonForeColor = Color.FromArgb(51, 51, 51);
                this.Style.TitleBar.ForeColor = this.visualStylelabel.ForeColor = this.gutterSpacelabel.ForeColor
                    = this.labelIndentSpace.ForeColor = this.labelNodeHeight.ForeColor = Color.Black;
                SkinManager.SetVisualStyle(this, "Office2016White");
                this.gradientPanel1.BackColor = Color.White;
                this.panel1.BorderColor= Color.FromArgb(210,210,210);
                this.panel1.BackColor = Color.White;
            }
            else if (sfcomboBox1.SelectedIndex == 5)
            {
                this.BackColor = Color.FromArgb(102, 102, 102); 
                this.Style.TitleBar.BackColor = ColorTranslator.FromHtml("#505050");
                this.Style.TitleBar.CloseButtonForeColor = Color.White;
                this.Style.TitleBar.MinimizeButtonForeColor = Color.White;
                this.Style.TitleBar.MaximizeButtonForeColor = Color.White;
                this.Style.TitleBar.ForeColor = this.visualStylelabel.ForeColor = this.gutterSpacelabel.ForeColor
                    = this.labelIndentSpace.ForeColor = this.labelNodeHeight.ForeColor = Color.White;
                SkinManager.SetVisualStyle(this, "Office2016DarkGray");
                this.panel1.BackColor = Color.FromArgb(102, 102, 102);
                this.panel1.BorderColor = Color.White;
                this.gradientPanel1.BackColor = Color.FromArgb(102, 102, 102);
            }
        }
    }
    #endregion
}


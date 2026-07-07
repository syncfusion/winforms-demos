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
using System.IO;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using Syncfusion.Windows.Forms;
using Syncfusion.Windows.Forms.Tools;
using Syncfusion.Drawing;
using System.Diagnostics;
using Syncfusion.Licensing;

namespace TreeViewAdvLoadOnDemand
{
	#region Class Form1 Description
	
	public class Form1 : MetroForm
	{
		#region Variable Declaration
		private Syncfusion.Windows.Forms.Tools.TreeViewAdv treeViewAdv2;
		private System.Windows.Forms.ImageList imageList1;
		private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private SplitContainerAdv splitContainerAdv1;
		private System.ComponentModel.IContainer components;
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
                string imagePath = ($"TreeViewAdvLoadOnDemand.Images.{folder}.Image_{i}.png");
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
            Syncfusion.Windows.Forms.Tools.TreeNodeAdv treeNodeAdv1 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdv();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.treeViewAdv2 = new Syncfusion.Windows.Forms.Tools.TreeViewAdv();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.splitContainerAdv1 = new Syncfusion.Windows.Forms.Tools.SplitContainerAdv();
            ((System.ComponentModel.ISupportInitialize)(this.treeViewAdv2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerAdv1)).BeginInit();
            this.splitContainerAdv1.Panel1.SuspendLayout();
            this.splitContainerAdv1.Panel2.SuspendLayout();
            this.splitContainerAdv1.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeViewAdv2
            // 
            this.treeViewAdv2.AddSeparatorAtEnd = true;
            this.treeViewAdv2.AllowDrop = true;
            this.treeViewAdv2.BackColor = System.Drawing.Color.White;
            this.treeViewAdv2.Border3DStyle = System.Windows.Forms.Border3DStyle.Flat;
            this.treeViewAdv2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.treeViewAdv2.CanSelectDisabledNode = false;
            this.treeViewAdv2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeViewAdv2.DpiAware = false;
            this.treeViewAdv2.DragOnText = false;
            this.treeViewAdv2.Font = new System.Drawing.Font("Verdana", 8F);
            this.treeViewAdv2.GridOfficeScrollBars = Syncfusion.Windows.Forms.OfficeScrollBars.Metro;
            // 
            // 
            // 
            this.treeViewAdv2.HelpTextControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.treeViewAdv2.HelpTextControl.Location = new System.Drawing.Point(732, 0);
            this.treeViewAdv2.HelpTextControl.Name = "helpText";
            this.treeViewAdv2.HelpTextControl.Size = new System.Drawing.Size(49, 15);
            this.treeViewAdv2.HelpTextControl.TabIndex = 0;
            this.treeViewAdv2.HelpTextControl.Text = "help text";
            this.treeViewAdv2.HideSelection = false;
            this.treeViewAdv2.IgnoreThemeBackground = true;
            this.treeViewAdv2.Indent = 20;
            this.treeViewAdv2.ItemHeight = 18;
            this.treeViewAdv2.LabelEdit = true;
            this.treeViewAdv2.LeftImageList = this.imageList1;
            this.treeViewAdv2.LineColor = System.Drawing.Color.Transparent;
            this.treeViewAdv2.LoadOnDemand = true;
            this.treeViewAdv2.Location = new System.Drawing.Point(0, 0);
            this.treeViewAdv2.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218)))));
            this.treeViewAdv2.MetroScrollBars = true;
            this.treeViewAdv2.Name = "treeViewAdv2";
            treeNodeAdv1.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv1.EnsureDefaultOptionedChild = true;
            treeNodeAdv1.Height = 16;
            treeNodeAdv1.MultiLine = true;
            treeNodeAdv1.PlusMinusSize = new System.Drawing.Size(9, 9);
            treeNodeAdv1.ShowLine = true;
            treeNodeAdv1.Text = "C:";
            this.treeViewAdv2.Nodes.AddRange(new Syncfusion.Windows.Forms.Tools.TreeNodeAdv[] {
            treeNodeAdv1});
            this.treeViewAdv2.OwnerDrawNodes = true;
            this.treeViewAdv2.PathSeparator = "/";
            this.treeViewAdv2.SelectionMode = Syncfusion.Windows.Forms.Tools.TreeSelectionMode.MultiSelectSameLevel;
            this.treeViewAdv2.ShowFocusRect = false;
            this.treeViewAdv2.Size = new System.Drawing.Size(191, 481);
            this.treeViewAdv2.StateImageList = this.imageList1;
            this.treeViewAdv2.Style = Syncfusion.Windows.Forms.Tools.TreeStyle.Metro;
            this.treeViewAdv2.TabIndex = 2;
            this.treeViewAdv2.ThemesEnabled = false;
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
            this.treeViewAdv2.AfterSelect += new System.EventHandler(this.treeViewAdv2_AfterSelect);
            this.treeViewAdv2.BeforeExpand += new Syncfusion.Windows.Forms.Tools.TreeViewAdvCancelableNodeEventHandler(this.treeViewAdv2_BeforeExpand);
            // 
            // imageList1
            // 
#if NET9_0_OR_GREATER
            LoadImages(this.imageList1, "ImageList1", 3);
#else
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
#endif
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "");
            this.imageList1.Images.SetKeyName(1, "");
            this.imageList1.Images.SetKeyName(2, "");
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.White;
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox1.HorizontalScrollbar = true;
            this.listBox1.Location = new System.Drawing.Point(0, 0);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(250, 481);
            this.listBox1.TabIndex = 0;
            // 
            // splitContainerAdv1
            // 
            this.splitContainerAdv1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainerAdv1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainerAdv1.IsSplitterFixed = true;
            this.splitContainerAdv1.Location = new System.Drawing.Point(41, 25);
            this.splitContainerAdv1.Name = "splitContainerAdv1";
            // 
            // splitContainerAdv1.Panel1
            // 
            this.splitContainerAdv1.Panel1.Controls.Add(this.treeViewAdv2);
            // 
            // splitContainerAdv1.Panel2
            // 
            this.splitContainerAdv1.Panel2.Controls.Add(this.listBox1);
            this.splitContainerAdv1.Size = new System.Drawing.Size(449, 483);
            this.splitContainerAdv1.SplitterDistance = 193;
            this.splitContainerAdv1.SplitterWidth = 4;
            this.splitContainerAdv1.TabIndex = 3;
            this.splitContainerAdv1.Text = "splitContainerAdv1";
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 15);
            this.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.CaptionAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ClientSize = new System.Drawing.Size(532, 550);
            this.Controls.Add(this.splitContainerAdv1);
            this.DropShadow = true;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IconAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.MetroColor = System.Drawing.Color.White;
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Load On Demand";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.treeViewAdv2)).EndInit();
            this.splitContainerAdv1.Panel1.ResumeLayout(false);
            this.splitContainerAdv1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerAdv1)).EndInit();
            this.splitContainerAdv1.ResumeLayout(false);
            this.ResumeLayout(false);

		}
		#endregion
        #region Main Function Definition

        [STAThread]
		static void Main() 
		{
            SyncfusionLicenseProvider.RegisterLicense(DemoCommon.FindLicenseKey());
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

        #region TreeViewAdv Event Handler

        #region Load the child nodes 

        //This Event will be fired  before a node is expanded
        private void treeViewAdv2_BeforeExpand(object sender, Syncfusion.Windows.Forms.Tools.TreeViewAdvCancelableNodeEventArgs e)
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
		#endregion

		#region Fill the listbox on the right with the directories and files below the selected node.
		// This Event will be fired  after a node is selected
		
		private void treeViewAdv2_AfterSelect(object sender, EventArgs e)
		{
			if(this.treeViewAdv2.SelectedNode!=null)
			{
				Rectangle bounds = this.treeViewAdv2.SelectedNode.Bounds;

				this.listBox1.Items.Clear();
				try
				{
					this.listBox1.Items.AddRange(Directory.GetFiles(this.treeViewAdv2.SelectedNode.GetPath("\\")));
				}
				catch{}	// Exception will be thrown in the user renamed the dirs and then selects them. Lose the exception.
			}
		}
		#endregion

		#endregion

		#region Form Event Handler
		
		private void Form1_Load(object sender, System.EventArgs e)
		{
			//Expand the Fist Node in the TreeViewAdv Control
			this.treeViewAdv2.Nodes[0].Expanded = true;
		}
		#endregion

       
	}
	#endregion
}

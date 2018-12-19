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

using Syncfusion.Windows.Forms.Tools;
using Syncfusion.Windows.Forms;
using System.IO;
using Syncfusion.Licensing;

namespace _TreeViewAdvImageOverLayingDemo
{
	#region Class Form1 Description
	
	public class Form1 : MetroForm
	{
		#region Variable Declaration
		private Syncfusion.Windows.Forms.Tools.TreeViewAdv treeViewAdv1;
		private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ImageList imageList2;
        private Panel panel1;
        private ButtonAdv buttonAdv1;
		private System.ComponentModel.IContainer components;
		#endregion
		
		#region Form Constructor Initialization Disposing
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
            this.MaximizeBox = false;
            //
			// TODO: Add any constructor code after InitializeComponent call
			//
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
            Syncfusion.Windows.Forms.Tools.TreeNodeAdv treeNodeAdv36 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdv();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.treeViewAdv1 = new Syncfusion.Windows.Forms.Tools.TreeViewAdv();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonAdv1 = new Syncfusion.Windows.Forms.ButtonAdv();
            ((System.ComponentModel.ISupportInitialize)(this.treeViewAdv1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeViewAdv1
            // 
            this.treeViewAdv1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.treeViewAdv1.BackColor = System.Drawing.Color.White;
            this.treeViewAdv1.BeforeTouchSize = new System.Drawing.Size(386, 393);
            this.treeViewAdv1.Border3DStyle = System.Windows.Forms.Border3DStyle.Flat;
            this.treeViewAdv1.BorderColor = System.Drawing.Color.Gray;
            this.treeViewAdv1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.treeViewAdv1.CanSelectDisabledNode = false;
            this.treeViewAdv1.Font = new System.Drawing.Font("Segoe UI", 9.50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeViewAdv1.ForeColor = System.Drawing.Color.Black;
            // 
            // 
            // 
            this.treeViewAdv1.HelpTextControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.treeViewAdv1.HelpTextControl.Location = new System.Drawing.Point(732, 0);
            this.treeViewAdv1.HelpTextControl.Name = "helpText";
            this.treeViewAdv1.HelpTextControl.Size = new System.Drawing.Size(49, 15);
            this.treeViewAdv1.HelpTextControl.TabIndex = 0;
            this.treeViewAdv1.HelpTextControl.Text = "help text";
            this.treeViewAdv1.IgnoreThemeBackground = true;
            this.treeViewAdv1.LeftImageList = this.imageList1;
            this.treeViewAdv1.Location = new System.Drawing.Point(10, 54);
            this.treeViewAdv1.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218)))));
            this.treeViewAdv1.Name = "treeViewAdv1";
            treeNodeAdv19.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv19.EnsureDefaultOptionedChild = true;
            treeNodeAdv19.Expanded = true;
            treeNodeAdv19.LeftImageIndices = new int[] {
        1};
            treeNodeAdv19.MultiLine = true;
            treeNodeAdv20.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv20.EnsureDefaultOptionedChild = true;
            treeNodeAdv20.Expanded = true;
            treeNodeAdv20.LeftImageIndices = new int[] {
        1};
            treeNodeAdv20.MultiLine = true;
            treeNodeAdv20.Optioned = true;
            treeNodeAdv20.PlusMinusSize = new System.Drawing.Size(9, 9);
            treeNodeAdv20.ShowLine = true;
            treeNodeAdv20.Text = "India";
            treeNodeAdv21.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv21.EnsureDefaultOptionedChild = true;
            treeNodeAdv21.LeftImageIndices = new int[] {
        2};
            treeNodeAdv21.MultiLine = true;
            treeNodeAdv21.PlusMinusSize = new System.Drawing.Size(9, 9);
            treeNodeAdv21.ShowLine = true;
            treeNodeAdv21.Text = "China";
            treeNodeAdv19.Nodes.AddRange(new Syncfusion.Windows.Forms.Tools.TreeNodeAdv[] {
            treeNodeAdv20,
            treeNodeAdv21});
            treeNodeAdv19.PlusMinusSize = new System.Drawing.Size(9, 9);
            treeNodeAdv19.ShowLine = true;
            treeNodeAdv19.Text = "Asia";
            treeNodeAdv22.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv22.EnsureDefaultOptionedChild = true;
            treeNodeAdv22.Expanded = true;
            treeNodeAdv22.LeftImageIndices = new int[] {
        7};
            treeNodeAdv22.MultiLine = true;
            treeNodeAdv23.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv23.EnsureDefaultOptionedChild = true;
            treeNodeAdv23.Expanded = true;
            treeNodeAdv23.LeftImageIndices = new int[] {
        3};
            treeNodeAdv23.MultiLine = true;
            treeNodeAdv23.Optioned = true;
            treeNodeAdv23.PlusMinusSize = new System.Drawing.Size(9, 9);
            treeNodeAdv23.ShowLine = true;
            treeNodeAdv23.Text = "Britain";
            treeNodeAdv24.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv24.EnsureDefaultOptionedChild = true;
            treeNodeAdv24.LeftImageIndices = new int[] {
        4};
            treeNodeAdv24.MultiLine = true;
            treeNodeAdv24.PlusMinusSize = new System.Drawing.Size(9, 9);
            treeNodeAdv24.ShowLine = true;
            treeNodeAdv24.Text = "France";
            treeNodeAdv22.Nodes.AddRange(new Syncfusion.Windows.Forms.Tools.TreeNodeAdv[] {
            treeNodeAdv23,
            treeNodeAdv24});
            treeNodeAdv22.PlusMinusSize = new System.Drawing.Size(9, 9);
            treeNodeAdv22.ShowLine = true;
            treeNodeAdv22.Text = "Europe";
            treeNodeAdv25.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv25.EnsureDefaultOptionedChild = true;
            treeNodeAdv25.Expanded = true;
            treeNodeAdv25.LeftImageIndices = new int[] {
        6};
            treeNodeAdv25.MultiLine = true;
            treeNodeAdv26.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv26.EnsureDefaultOptionedChild = true;
            treeNodeAdv26.Expanded = true;
            treeNodeAdv26.LeftImageIndices = new int[] {
        5};
            treeNodeAdv26.MultiLine = true;
            treeNodeAdv26.Optioned = true;
            treeNodeAdv26.PlusMinusSize = new System.Drawing.Size(9, 9);
            treeNodeAdv26.ShowLine = true;
            treeNodeAdv26.Text = "United States";
            treeNodeAdv27.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv27.EnsureDefaultOptionedChild = true;
            treeNodeAdv27.LeftImageIndices = new int[] {
        6};
            treeNodeAdv27.MultiLine = true;
            treeNodeAdv27.PlusMinusSize = new System.Drawing.Size(9, 9);
            treeNodeAdv27.ShowLine = true;
            treeNodeAdv27.Text = "Canada";
            treeNodeAdv25.Nodes.AddRange(new Syncfusion.Windows.Forms.Tools.TreeNodeAdv[] {
            treeNodeAdv26,
            treeNodeAdv27});
            treeNodeAdv25.PlusMinusSize = new System.Drawing.Size(9, 9);
            treeNodeAdv25.ShowLine = true;
            treeNodeAdv25.Text = "North America";
            treeNodeAdv28.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv28.EnsureDefaultOptionedChild = true;
            treeNodeAdv28.Expanded = true;
            treeNodeAdv28.LeftImageIndices = new int[] {
        9};
            treeNodeAdv28.MultiLine = true;
            treeNodeAdv29.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv29.EnsureDefaultOptionedChild = true;
            treeNodeAdv29.LeftImageIndices = new int[] {
        10};
            treeNodeAdv29.MultiLine = true;
            treeNodeAdv29.Optioned = true;
            treeNodeAdv29.PlusMinusSize = new System.Drawing.Size(9, 9);
            treeNodeAdv29.RightImageIndices = new int[] {
        0};
            treeNodeAdv29.ShowLine = true;
            treeNodeAdv29.Text = "Australia";
            treeNodeAdv30.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv30.EnsureDefaultOptionedChild = true;
            treeNodeAdv30.LeftImageIndices = new int[] {
        11};
            treeNodeAdv30.MultiLine = true;
            treeNodeAdv30.PlusMinusSize = new System.Drawing.Size(9, 9);
            treeNodeAdv30.RightImageIndices = new int[] {
        1};
            treeNodeAdv30.ShowLine = true;
            treeNodeAdv30.Text = "New Zealand";
            treeNodeAdv28.Nodes.AddRange(new Syncfusion.Windows.Forms.Tools.TreeNodeAdv[] {
            treeNodeAdv29,
            treeNodeAdv30});
            treeNodeAdv28.PlusMinusSize = new System.Drawing.Size(9, 9);
            treeNodeAdv28.RightImageIndices = new int[] {
        0};
            treeNodeAdv28.ShowLine = true;
            treeNodeAdv28.Text = "Australia";
            treeNodeAdv31.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv31.EnsureDefaultOptionedChild = true;
            treeNodeAdv31.Expanded = true;
            treeNodeAdv31.LeftImageIndices = new int[] {
        12};
            treeNodeAdv31.MultiLine = true;
            treeNodeAdv32.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv32.EnsureDefaultOptionedChild = true;
            treeNodeAdv32.LeftImageIndices = new int[] {
        13};
            treeNodeAdv32.MultiLine = true;
            treeNodeAdv32.Optioned = true;
            treeNodeAdv32.PlusMinusSize = new System.Drawing.Size(9, 9);
            treeNodeAdv32.RightImageIndices = new int[] {
        2};
            treeNodeAdv32.ShowLine = true;
            treeNodeAdv32.Text = "Brazil";
            treeNodeAdv33.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv33.EnsureDefaultOptionedChild = true;
            treeNodeAdv33.LeftImageIndices = new int[] {
        14};
            treeNodeAdv33.MultiLine = true;
            treeNodeAdv33.PlusMinusSize = new System.Drawing.Size(9, 9);
            treeNodeAdv33.RightImageIndices = new int[] {
        3};
            treeNodeAdv33.ShowLine = true;
            treeNodeAdv33.Text = "Argentina";
            treeNodeAdv31.Nodes.AddRange(new Syncfusion.Windows.Forms.Tools.TreeNodeAdv[] {
            treeNodeAdv32,
            treeNodeAdv33});
            treeNodeAdv31.PlusMinusSize = new System.Drawing.Size(9, 9);
            treeNodeAdv31.RightImageIndices = new int[] {
        6};
            treeNodeAdv31.ShowLine = true;
            treeNodeAdv31.Text = "South America";
            treeNodeAdv34.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv34.EnsureDefaultOptionedChild = true;
            treeNodeAdv34.Expanded = true;
            treeNodeAdv34.LeftImageIndices = new int[] {
        15};
            treeNodeAdv34.MultiLine = true;
            treeNodeAdv35.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv35.EnsureDefaultOptionedChild = true;
            treeNodeAdv35.LeftImageIndices = new int[] {
        16};
            treeNodeAdv35.MultiLine = true;
            treeNodeAdv35.Optioned = true;
            treeNodeAdv35.PlusMinusSize = new System.Drawing.Size(9, 9);
            treeNodeAdv35.RightImageIndices = new int[] {
        4};
            treeNodeAdv35.ShowLine = true;
            treeNodeAdv35.Text = "South Africa";
            treeNodeAdv36.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv36.EnsureDefaultOptionedChild = true;
            treeNodeAdv36.LeftImageIndices = new int[] {
        17};
            treeNodeAdv36.MultiLine = true;
            treeNodeAdv36.PlusMinusSize = new System.Drawing.Size(9, 9);
            treeNodeAdv36.RightImageIndices = new int[] {
        5};
            treeNodeAdv36.ShowLine = true;
            treeNodeAdv36.Text = "Zimbabwe";
            treeNodeAdv34.Nodes.AddRange(new Syncfusion.Windows.Forms.Tools.TreeNodeAdv[] {
            treeNodeAdv35,
            treeNodeAdv36});
            treeNodeAdv34.PlusMinusSize = new System.Drawing.Size(9, 9);
            treeNodeAdv34.RightImageIndices = new int[] {
        7};
            treeNodeAdv34.ShowLine = true;
            treeNodeAdv34.Text = "Africa";
            this.treeViewAdv1.Nodes.AddRange(new Syncfusion.Windows.Forms.Tools.TreeNodeAdv[] {
            treeNodeAdv19,
            treeNodeAdv22,
            treeNodeAdv25,
            treeNodeAdv28,
            treeNodeAdv31,
            treeNodeAdv34});
            this.treeViewAdv1.OwnerDrawNodes = true;
            this.treeViewAdv1.OwnerDrawNodesBackground = true;
            this.treeViewAdv1.RightImageList = this.imageList2;
            this.treeViewAdv1.ShowFocusRect = true;
            this.treeViewAdv1.ShowLines = false;
            this.treeViewAdv1.Size = new System.Drawing.Size(386, 393);
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
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "");
            this.imageList2.Images.SetKeyName(1, "");
            this.imageList2.Images.SetKeyName(2, "");
            this.imageList2.Images.SetKeyName(3, "");
            this.imageList2.Images.SetKeyName(4, "");
            this.imageList2.Images.SetKeyName(5, "");
            this.imageList2.Images.SetKeyName(6, "");
            this.imageList2.Images.SetKeyName(7, "");
            this.imageList2.Images.SetKeyName(8, "");
            //this.imageList2.Images.SetKeyName(9, "touch padding2.png");
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonAdv1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(10, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(386, 35);
            this.panel1.TabIndex = 1;
            // 
            // buttonAdv1
            // 
            this.buttonAdv1.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.buttonAdv1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.buttonAdv1.BeforeTouchSize = new System.Drawing.Size(110, 38);
            this.buttonAdv1.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonAdv1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdv1.ForeColor = System.Drawing.Color.White;
            this.buttonAdv1.Image = global::_TreeViewAdvImageOverLayingDemo.Properties.Resources.touch_padding2;
            this.buttonAdv1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAdv1.IsBackStageButton = false;
            this.buttonAdv1.Location = new System.Drawing.Point(276, 0);
            this.buttonAdv1.Name = "buttonAdv1";
            this.buttonAdv1.Size = new System.Drawing.Size(120, 34);
            this.buttonAdv1.TabIndex = 0;
            this.buttonAdv1.Text = "Enable Touch";
            this.buttonAdv1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonAdv1.UseVisualStyle = true;
            this.buttonAdv1.UseVisualStyleBackColor = false;
            this.buttonAdv1.Click += new System.EventHandler(this.buttonAdv1_Click);
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 15);
            this.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.ClientSize = new System.Drawing.Size(406, 457);
            this.Controls.Add(this.treeViewAdv1);
            this.Controls.Add(this.panel1);
            this.DropShadow = true;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customizations";
            ((System.ComponentModel.ISupportInitialize)(this.treeViewAdv1)).EndInit();
            this.panel1.ResumeLayout(false);
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

        private void buttonAdv1_Click(object sender, EventArgs e)
        {
            this.treeViewAdv1.EnableTouchMode = !this.treeViewAdv1.EnableTouchMode;
            if (this.treeViewAdv1.EnableTouchMode)
            {
                this.treeViewAdv1.GutterSpace = 15;
                this.buttonAdv1.Text = "Disable Touch";
            }
            else
            {
                this.treeViewAdv1.GutterSpace = 3;
                this.buttonAdv1.Text = "Enable Touch";
            }

        }
	}
#endregion
}

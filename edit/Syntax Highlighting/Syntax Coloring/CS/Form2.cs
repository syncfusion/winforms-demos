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
using System.IO;
using Syncfusion.Windows.Forms;
using Syncfusion.WinForms.Controls;

namespace SyntaxColoringDemo
{
	/// <summary>
	/// Summary description for Form2.
	/// </summary>
	public class Form2 : SfForm
	{
		private System.Windows.Forms.TreeView treeView1;
		private Syncfusion.Windows.Forms.Edit.EditControl editControl1;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;
		private string BasePath = Path.GetDirectoryName(Application.ExecutablePath) + @"\..\..\Test Files\Config.xml";

		public Form2()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			this.treeView1.ExpandAll();

			this.editControl1.LoadFile(BasePath);
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("CSharp");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("VB.NET");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("HTML");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("XML");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Pascal");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("SQL");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Java");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("VBScript");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("JScript");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Default");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Prebuilt Configurations", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5,
            treeNode6,
            treeNode7,
            treeNode8,
            treeNode9,
            treeNode10});
            Syncfusion.Windows.Forms.Edit.Implementation.Config.Config config1 = new Syncfusion.Windows.Forms.Edit.Implementation.Config.Config();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.editControl1 = new Syncfusion.Windows.Forms.Edit.EditControl();
            ((System.ComponentModel.ISupportInitialize)(this.editControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Left;
            this.treeView1.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.treeView1.ItemHeight = 20;
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "";
            treeNode1.Text = "CSharp";
            treeNode2.Name = "";
            treeNode2.Text = "VB.NET";
            treeNode3.Name = "";
            treeNode3.Text = "HTML";
            treeNode4.Name = "";
            treeNode4.Text = "XML";
            treeNode5.Name = "";
            treeNode5.Text = "Pascal";
            treeNode6.Name = "";
            treeNode6.Text = "SQL";
            treeNode7.Name = "";
            treeNode7.Text = "Java";
            treeNode8.Name = "";
            treeNode8.Text = "VBScript";
            treeNode9.Name = "";
            treeNode9.Text = "JScript";
            treeNode10.Name = "";
            treeNode10.Text = "Default";
            treeNode11.Name = "";
            treeNode11.Text = "Prebuilt Configurations";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode11});
            this.treeView1.Size = new System.Drawing.Size(176, 430);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // editControl1
            // 
            this.editControl1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.editControl1.CodeSnipptSize = new System.Drawing.Size(100, 100);
            this.editControl1.Configurator = config1;
            this.editControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.editControl1.GraphicsTextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.editControl1.IndicatorMarginBackColor = System.Drawing.Color.Empty;
            this.editControl1.LineNumbersFont = new System.Drawing.Font("Segoe UI", 8.25F);
            this.editControl1.Location = new System.Drawing.Point(176, 0);
            this.editControl1.Name = "editControl1";
            this.editControl1.RenderRightToLeft = false;
            this.editControl1.ScrollPosition = new System.Drawing.Point(0, 0);
            this.editControl1.ScrollVisualStyle = Syncfusion.Windows.Forms.ScrollBarCustomDrawStyles.Metro;
            this.editControl1.SharedFileMode = true;
            this.editControl1.ShowHorizontalSplitters = false;
            this.editControl1.ShowIndicatorMargin = false;
            this.editControl1.ShowSelectionMargin = false;
            this.editControl1.ShowVerticalSplitters = false;
            this.editControl1.Size = new System.Drawing.Size(528, 430);

            this.editControl1.StatusBarSettings.TextPanel.AutoSize = false;
            this.editControl1.TabIndex = 1;
            this.editControl1.Text = "";
            this.editControl1.TransferFocusOnTab = true;
            this.editControl1.UseXPStyleBorder = true;
            this.editControl1.VisualColumn = 1;
            // 
            // Form2
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 15);
            this.ClientSize = new System.Drawing.Size(704, 430);
            this.Controls.Add(this.editControl1);
            this.Controls.Add(this.treeView1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(716, 467);
            this.Name = "Form2";
            this.Text = "Configuration Settings Display";
            ((System.ComponentModel.ISupportInitialize)(this.editControl1)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

		private void treeView1_AfterSelect(object sender, System.Windows.Forms.TreeViewEventArgs e)
		{
			switch (this.treeView1.SelectedNode.Text)
			{
				case "CSharp" :
					this.editControl1.GoTo(168,3);
					break;
				case "HTML" :
					this.editControl1.GoTo(834,3);
					break;
				case "XML" :
					this.editControl1.GoTo(734,3);
					break;
				case "Pascal" :
					this.editControl1.GoTo(589,3);
					break;
				case "VB.NET" :
					this.editControl1.GoTo(1697,3);
					break;
				case "SQL" :
					this.editControl1.GoTo(1945,3);
					break;
				case "Java" :
					this.editControl1.GoTo(3209,3);
					break;
				case "Default" :
					this.editControl1.GoTo(3,2);
					break;
				case "VBScript" :
					this.editControl1.GoTo(3346,3);
					break;
				case "JScript" :
					this.editControl1.GoTo(3772,3);
					break;
			}
		}
	}
}

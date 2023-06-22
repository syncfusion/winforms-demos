#region Copyright Syncfusion Inc. 2001-2023.
// Copyright Syncfusion Inc. 2001-2023. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using System.Reflection;

namespace Syncfusion.Windows.Forms.Diagram.Samples.DiagramTool
{
	/// <summary>
	/// Summary description for UserControl1.
	/// </summary>
    [ToolboxItem(false)]
	public class AssemblyListControl : System.Windows.Forms.UserControl
	{
		private System.Windows.Forms.Label label1;
		public MultilineListBox listBox1;
		private System.Windows.Forms.CheckBox checkBox1;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;
		private Assembly[] projectAssembly=null;
		private System.Windows.Forms.ContextMenuStrip contextMenu1;
		private System.Windows.Forms.ToolStripMenuItem menuItem1;

		public AssemblyListControl()
		{
			
			// This call is required by the Windows.Forms Form Designer.
			InitializeComponent();
			this.listBox1.ContextMenuStrip=contextMenu1;
			// TODO: Add any initialization after the InitForm call

		}
		public void GetAssemblyFromCurrentProject(Assembly[] assembly)
		{
			this.projectAssembly=assembly;
			this.PrepareListOfAssemblies();
		}
		
		public void PrepareListOfAssemblies()
		{
			this.listBox1.Items.Clear();

			foreach(Assembly a in projectAssembly)
			{
                if (a.FullName.IndexOf("Syncfusion") >= 0 || !this.checkBox1.Checked)
                    this.listBox1.Items.Add(String.Format("Assembly Name: {0}\r\n Location: {1}\r\n", a.FullName, a.CodeBase));

			}
		}
		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if( components != null )
					components.Dispose();
			}
			base.Dispose( disposing );
		}

		#region Component Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.contextMenu1 = new System.Windows.Forms.ContextMenuStrip();
            this.menuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.listBox1 = new MultilineListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(101)))));
            this.label1.Location = new System.Drawing.Point(0, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Referenced Assemblies";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // checkBox1
            // 
            this.checkBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.checkBox1.Location = new System.Drawing.Point(203, 14);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(105, 20);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "Syncfusion Only";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // contextMenu1
            // 
            this.contextMenu1.Items.AddRange(new System.Windows.Forms.ToolStripMenuItem[] {
            this.menuItem1});
            // 
            // menuItem1
            // 
            this.menuItem1.ImageIndex = 0;
            this.menuItem1.Text = "Copy All";
            this.menuItem1.Click += new System.EventHandler(this.menuItem1_Click);
            // 
            // listBox1
            // 
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.listBox1.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.Location = new System.Drawing.Point(0, 36);
            this.listBox1.Name = "listBox1";
            this.listBox1.ScrollAlwaysVisible = true;
            this.listBox1.Size = new System.Drawing.Size(304, 108);
            this.listBox1.TabIndex = 1;
            // 
            // AssemblyListControl
            // 
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label1);
            this.Name = "AssemblyListControl";
            this.Size = new System.Drawing.Size(304, 144);
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

		private void checkBox1_CheckedChanged(object sender, System.EventArgs e)
		{
			this.PrepareListOfAssemblies();
		}

		private void menuItem1_Click(object sender, System.EventArgs e)
		{
			this.CopyInfo();
		}
		internal void CopyInfo()
		{
			string assembliesList=String.Empty;
			for(int i=0;i<this.listBox1.Items.Count;i++)
			{
				assembliesList+=this.listBox1.Items[i].ToString()+"\r\n\r\n";
			}
			
			Clipboard.SetDataObject((object)assembliesList);
		}
	}

	[ToolboxItem(false)]
	public class MultilineListBox:ListBox
	{
		public MultilineListBox()
		{
			this.DrawMode = DrawMode.OwnerDrawVariable;
			this.ScrollAlwaysVisible = true;
		}

		protected override void OnMeasureItem(MeasureItemEventArgs e)
		{
			if(Site!=null)
				return;
			if(e.Index > -1)
			{
				string s = Items[e.Index].ToString();
				SizeF sf = e.Graphics.MeasureString(s,Font,Width);
				int htex = (e.Index==0) ? 15 : 10;
				e.ItemHeight = (int)sf.Height + htex;			
				e.ItemWidth = Width;
			}
		}

		protected override void OnDrawItem(DrawItemEventArgs e)
		{
			if(Site!=null)
				return;
			if(e.Index > -1)
			{
				string s = Items[e.Index].ToString();							
			
				if((e.State & DrawItemState.Focus)==0)
				{
					e.Graphics.FillRectangle(new SolidBrush(SystemColors.Window),e.Bounds);
					e.Graphics.DrawString(s,Font,new SolidBrush(SystemColors.WindowText),
						e.Bounds);				
					e.Graphics.DrawRectangle(new Pen(SystemColors.Highlight),e.Bounds);				
				}
				else
				{
					e.Graphics.FillRectangle(new SolidBrush(SystemColors.Highlight),e.Bounds);
					e.Graphics.DrawString(s,Font,new SolidBrush(SystemColors.HighlightText),
						e.Bounds);
				}
			}
		}
	}
}

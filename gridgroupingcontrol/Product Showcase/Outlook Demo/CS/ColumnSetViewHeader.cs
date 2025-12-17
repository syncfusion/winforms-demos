#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
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

using Syncfusion.Grouping;
using Syncfusion.Windows.Forms.Grid;
using Syncfusion.Windows.Forms.Grid.Grouping;

namespace OutlookDemo
{
	/// <summary>
	/// Summary description for ColumnSetViewHeader.
	/// </summary>
	public class ColumnSetViewHeader : System.Windows.Forms.UserControl
	{
		private Syncfusion.Windows.Forms.Grid.GridControl gridControl1;
		private System.Windows.Forms.Panel panel1;
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public ColumnSetViewHeader()
		{
			// This call is required by the Windows.Forms Form Designer.
			InitializeComponent();
			this.gridControl1.ThemesEnabled = false;
			this.gridControl1.BaseStylesMap["Column Header"].StyleInfo.BackColor = SystemColors.Control;
			this.gridControl1.Enabled = false;
			this.gridControl1.HScrollBehavior = GridScrollbarMode.Disabled;
			this.gridControl1[0,2].Text = "Newest On Top";
			this.gridControl1[0,2].HorizontalAlignment = GridHorizontalAlignment.Left;
			this.gridControl1[0,1].Text = "Arranged By: ";
			this.gridControl1[0,1].HorizontalAlignment = GridHorizontalAlignment.Left;
			// TODO: Add any initialization after the InitializeComponent call
			this.gridControl1.QueryColWidth += new GridRowColSizeEventHandler(gridControl1_QueryColWidth);
			this.gridControl1.CellClick += new GridCellClickEventHandler(gridControl1_CellClick);
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

		#region Component Designer generated code
		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			Syncfusion.Windows.Forms.Grid.GridBaseStyle gridBaseStyle1 = new Syncfusion.Windows.Forms.Grid.GridBaseStyle();
			Syncfusion.Windows.Forms.Grid.GridBaseStyle gridBaseStyle2 = new Syncfusion.Windows.Forms.Grid.GridBaseStyle();
			Syncfusion.Windows.Forms.Grid.GridBaseStyle gridBaseStyle3 = new Syncfusion.Windows.Forms.Grid.GridBaseStyle();
			Syncfusion.Windows.Forms.Grid.GridBaseStyle gridBaseStyle4 = new Syncfusion.Windows.Forms.Grid.GridBaseStyle();
			this.gridControl1 = new Syncfusion.Windows.Forms.Grid.GridControl();
			this.panel1 = new System.Windows.Forms.Panel();
			((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// gridControl1
			// 
			gridBaseStyle1.Name = "Header";
			gridBaseStyle1.StyleInfo.Borders.Bottom = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None);
			gridBaseStyle1.StyleInfo.Borders.Left = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None);
			gridBaseStyle1.StyleInfo.Borders.Right = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None);
			gridBaseStyle1.StyleInfo.Borders.Top = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None);
			gridBaseStyle1.StyleInfo.CellType = "Header";
			gridBaseStyle1.StyleInfo.Font.Bold = true;
			gridBaseStyle1.StyleInfo.Interior = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb(((System.Byte)(203)), ((System.Byte)(199)), ((System.Byte)(184))), System.Drawing.Color.FromArgb(((System.Byte)(238)), ((System.Byte)(234)), ((System.Byte)(216))));
			gridBaseStyle1.StyleInfo.VerticalAlignment = Syncfusion.Windows.Forms.Grid.GridVerticalAlignment.Middle;
			gridBaseStyle2.Name = "Column Header";
			gridBaseStyle2.StyleInfo.BaseStyle = "Header";
			gridBaseStyle2.StyleInfo.HorizontalAlignment = Syncfusion.Windows.Forms.Grid.GridHorizontalAlignment.Center;
			gridBaseStyle3.Name = "Row Header";
			gridBaseStyle3.StyleInfo.BaseStyle = "Header";
			gridBaseStyle3.StyleInfo.HorizontalAlignment = Syncfusion.Windows.Forms.Grid.GridHorizontalAlignment.Left;
			gridBaseStyle3.StyleInfo.Interior = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Horizontal, System.Drawing.Color.FromArgb(((System.Byte)(203)), ((System.Byte)(199)), ((System.Byte)(184))), System.Drawing.Color.FromArgb(((System.Byte)(238)), ((System.Byte)(234)), ((System.Byte)(216))));
			gridBaseStyle4.Name = "Standard";
			gridBaseStyle4.StyleInfo.Font.Facename = "Tahoma";
			gridBaseStyle4.StyleInfo.Interior = new Syncfusion.Drawing.BrushInfo(System.Drawing.SystemColors.Window);
			this.gridControl1.BaseStylesMap.AddRange(new Syncfusion.Windows.Forms.Grid.GridBaseStyle[] {
																										   gridBaseStyle1,
																										   gridBaseStyle2,
																										   gridBaseStyle3,
																										   gridBaseStyle4});
			this.gridControl1.ColCount = 2;
			this.gridControl1.ColWidthEntries.AddRange(new Syncfusion.Windows.Forms.Grid.GridColWidth[] {
																											new Syncfusion.Windows.Forms.Grid.GridColWidth(0, 35)});
			this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gridControl1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.gridControl1.Location = new System.Drawing.Point(0, 0);
			this.gridControl1.Name = "gridControl1";
			this.gridControl1.Properties.BackgroundColorString = "Control";
			this.gridControl1.Properties.FixedLinesColorString = "ActiveCaption";
			this.gridControl1.Properties.GridLineColorString = "GrayText";
			this.gridControl1.Properties.ResizingCellsLinesColorString = "Red";
			this.gridControl1.Properties.RowHeaders = false;
			this.gridControl1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.gridControl1.RowCount = 0;
			this.gridControl1.RowHeightEntries.AddRange(new Syncfusion.Windows.Forms.Grid.GridRowHeight[] {
																											  new Syncfusion.Windows.Forms.Grid.GridRowHeight(0, 25)});
			//this.gridControl1.SerializeCellsBehavior = Syncfusion.Windows.Forms.Grid.GridSerializeCellsBehavior.SerializeAsRangeStylesIntoCode;
			this.gridControl1.Size = new System.Drawing.Size(344, 24);
			this.gridControl1.SmartSizeBox = false;
			this.gridControl1.TabIndex = 0;
			this.gridControl1.ThemesEnabled = true;
			this.gridControl1.Click += new System.EventHandler(this.gridControl1_Click);
			this.gridControl1.CellClick += new Syncfusion.Windows.Forms.Grid.GridCellClickEventHandler(this.gridControl1_CellClick);
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.gridControl1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(344, 24);
			this.panel1.TabIndex = 1;
			// 
			// ColumnSetViewHeader
			// 
			this.Controls.Add(this.panel1);
			this.Name = "ColumnSetViewHeader";
			this.Size = new System.Drawing.Size(344, 24);
			((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		# region GridControl events

		private bool flag;
		private void gridControl1_CellClick(object sender, Syncfusion.Windows.Forms.Grid.GridCellClickEventArgs e)
		{
			if(e.ColIndex == 2 && flag)
			{
				this.gridControl1[0,2].Tag = ListSortDirection.Ascending;
				this.gridControl1[0,2].Text = "Oldest On Top";
			}
			if(e.ColIndex == 2 && !flag)
			{
				this.gridControl1[0,2].Tag = ListSortDirection.Descending;
				this.gridControl1[0,2].Text = "Newest On Top";
			}
			flag = !flag;
		}
		private void gridControl1_QueryColWidth(object sender, GridRowColSizeEventArgs e)
		{
			if(e.Index == 1)
			{
				e.Size = pane.Grid.TableDescriptor.Columns["mails"].Width + 
					pane.SecondColumnSetSize; // size of 2 column sets
			}
			if(e.Index == 2)
			{
				e.Size = pane.Grid.Width - this.gridControl1.ColWidths[1];
			}
			e.Handled = true;
		}
		# endregion

		private GroupingPanel pane;
		public GroupingPanel Pane
		{
			get{return pane;}
		}
		# region class support functions
		public void wire(GroupingPanel f)
		{
			if(!f.NormalView)
			{
				pane = f;
			}
		}
		# endregion

		private void gridControl1_Click(object sender, System.EventArgs e)
		{
		
		}
	}
}

#region Copyright Syncfusion Inc. 2001 - 2015
//
//  Copyright Syncfusion Inc. 2001 - 2015. All rights reserved.
//
//  Use of this code is subject to the terms of our license.
//  A copy of the current license can be obtained at any time by e-mailing
//  licensing@syncfusion.com. Any infringement will be prosecuted under
//  applicable laws. 
//
#endregion

using System;
using System.Diagnostics;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

using Syncfusion.Windows.Forms;
using Syncfusion.Windows.Forms.Grid;
using DemoCommon.Grid;

namespace Syncfusion.Samples.GridPad
{
	/// <summary>
	///    Summary description for RecordFrame.
	/// </summary>
    public class RecordFrame : GridDemoForm
    {
        #region API Definition
        /// <summary>
		///    Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components;

		private GridRecordNavigationControl recordNavigationControl1;
        private SampleGrid grid1 = null;
        private GridModel model = null;
		//private bool inUpdate = false;
        //private int savedRecord = -1;
        #endregion

        #region Constructor
        public RecordFrame()
		{
            model = new GridModel();
            SampleGrid.SetupGridModel(model);
            InitializeComponent();
            if(DpiAware.GetCurrentDpi() > 96)
            {
                this.CaptionBarHeight = (int)DpiAware.LogicalToDeviceUnits(this.CaptionBarHeight);
            }
            grid1.Model = model;
            this.grid1.CurrentCell.MoveTo(1, 1);

            this.grid1.GridVisualStyles = GridVisualStyles.Metro;

            model.EnableGridListControlInComboBox = false;

		}
        #endregion

        #region Designer Stuff
        /// <summary>
		///    Clean up any resources being used.
		/// </summary>
		protected override void Dispose(bool disposing)
		{
			if (disposing)
			{
				if (components != null)
					components.Dispose();
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		///    Required method for Designer support - do not modify
		///    the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo1 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo2 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            this.recordNavigationControl1 = new Syncfusion.Windows.Forms.Grid.GridRecordNavigationControl();
            this.grid1 = new SampleGrid();
            this.components = new Container();
            this.recordNavigationControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid1)).BeginInit();
            this.SuspendLayout();
            // 
            // recordNavigationControl1
            // 
            this.recordNavigationControl1.AllowAddNew = false;
            this.recordNavigationControl1.Controls.Add(this.grid1);
            this.recordNavigationControl1.DisabledArrowColor = System.Drawing.SystemColors.GrayText;
            this.recordNavigationControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.recordNavigationControl1.EnabledArrowColor = System.Drawing.SystemColors.WindowText;
            this.recordNavigationControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.recordNavigationControl1.GridOfficeScrollBars = Syncfusion.Windows.Forms.OfficeScrollBars.Metro;
            this.recordNavigationControl1.Location = new System.Drawing.Point(0, 0);
            this.recordNavigationControl1.MaxRecord = 0;
            this.recordNavigationControl1.MinRecord = 1;
            this.recordNavigationControl1.MinRepeatClickDelay = 15;
            this.recordNavigationControl1.Name = "recordNavigationControl1";
            this.recordNavigationControl1.NavigationBarBackColor = System.Drawing.SystemColors.Window;
            this.recordNavigationControl1.ShowToolTips = true;
            this.recordNavigationControl1.Size = new System.Drawing.Size(284, 262);
            this.recordNavigationControl1.SplitBars = ((Syncfusion.Windows.Forms.DynamicSplitBars)((Syncfusion.Windows.Forms.DynamicSplitBars.SplitRows | Syncfusion.Windows.Forms.DynamicSplitBars.SplitColumns)));
            this.recordNavigationControl1.TabIndex = 0;
            this.recordNavigationControl1.ThemesEnabled = true;
            this.recordNavigationControl1.Enter += new System.EventHandler(this.SplitterEnter);
            this.recordNavigationControl1.GotFocus += new System.EventHandler(this.SplitterGotFocus);
            // 
            // grid1
            // 
            this.grid1.DpiAware = true;
            this.grid1.AllowDragSelectedCols = true;
            this.grid1.AllowDragSelectedRows = true;
            this.grid1.BackColor = System.Drawing.Color.White;
            this.grid1.ColCount = 0;
            this.grid1.DefaultColWidth = 0;
            this.grid1.DefaultGridBorderStyle = Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid;
            this.grid1.ExcelLikeCurrentCell = true;
            this.grid1.ExcelLikeSelectionFrame = true;
            this.grid1.FillSplitterPane = true;
            this.grid1.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.grid1.ForeColor = System.Drawing.SystemColors.WindowText;
            gridCellInfo1.Col = -1;
            gridCellInfo1.Row = -1;
            gridCellInfo1.StyleInfo.Font.Bold = false;
            gridCellInfo1.StyleInfo.Font.Facename = "Verdana";
            gridCellInfo1.StyleInfo.Font.Italic = false;
            gridCellInfo1.StyleInfo.Font.Size = 8.25F;
            gridCellInfo1.StyleInfo.Font.Strikeout = false;
            gridCellInfo1.StyleInfo.Font.Underline = false;
            gridCellInfo1.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point;
            gridCellInfo1.StyleInfo.TextColor = System.Drawing.Color.MidnightBlue;
            gridCellInfo2.Col = -1;
            gridCellInfo2.Row = -1;
            gridCellInfo2.StyleInfo.Font.Facename = "Verdana";
            gridCellInfo2.StyleInfo.TextColor = System.Drawing.Color.MidnightBlue;
            this.grid1.GridCells.AddRange(new Syncfusion.Windows.Forms.Grid.GridCellInfo[] {
            gridCellInfo1,
            gridCellInfo2});
            this.grid1.GridOfficeScrollBars = Syncfusion.Windows.Forms.OfficeScrollBars.Metro;
            this.grid1.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro;
            this.grid1.DefaultRowHeight = (int)DpiAware.LogicalToDeviceUnits(20.0f);
            this.grid1.HorizontalScrollTips = true;
            this.grid1.HorizontalThumbTrack = true;
            this.grid1.Location = new System.Drawing.Point(0, 0);
            this.grid1.MetroScrollBars = true;
            this.grid1.Name = "grid1";
            this.grid1.Properties.GridLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.grid1.Properties.MarkColHeader = false;
            this.grid1.Properties.MarkRowHeader = false;
            this.grid1.RowCount = 0;
            this.grid1.Size = new System.Drawing.Size(263, 241);
            this.grid1.SmartSizeBox = false;
            this.grid1.ThemesEnabled = true;
            this.grid1.VerticalScrollTips = true;
            // 
            // RecordFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.recordNavigationControl1);
            this.Name = "RecordFrame";
            this.Text = "Grid Splitter";
            this.recordNavigationControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid1)).EndInit();
            this.ResumeLayout(false);

		}
        #endregion

        void SplitterEnter(object sender, EventArgs e)
		{
			if (this.recordNavigationControl1.HasControlFocus && !this.recordNavigationControl1.IsValidating)
				this.Activate();
		}

		void SplitterGotFocus(object sender, EventArgs e)
		{
			if (this.recordNavigationControl1.IsActiveControl && !this.recordNavigationControl1.IsValidating)
				this.Activate();
		}
         
	}
}

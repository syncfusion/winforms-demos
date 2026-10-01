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
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows.Forms;
using System.Data;
using System.Reflection;

using Syncfusion.Windows.Forms.Grid;
using DemoCommon.Grid;
using Syncfusion.Windows.Forms;

namespace Syncfusion.Samples.GridPad
{
	/// <summary>
	///    GridFrame is a MDI Child window that hosts the SampleGrid control.
	/// </summary>
    public class GridFrame : GridDemoForm
    {
        #region API Definition
        /// <summary>
		///    Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components;
        private SampleGrid grid1 = null;
		private GridModel model;
        #endregion

        #region Constructor
        public GridFrame()
		{
            model = new GridModel();
            SampleGrid.SetupGridModel(model);
            InitializeComponent();          

            grid1.Model.SelectionChanging += new GridSelectionChangingEventHandler(grid1_SelectionChanging);
            this.grid1.CurrentCell.MoveTo(1, 1);

            grid1.Model = model;
            grid1.Model.EnableGridListControlInComboBox = false;
            grid1.GridVisualStyles = Windows.Forms.GridVisualStyles.Metro;
		}
        

        public GridFrame(GridModel model)
        {
            this.model = model;
            SampleGrid.SetupGridModel(model);
            InitializeComponent();

            grid1.Model.SelectionChanging += new GridSelectionChangingEventHandler(grid1_SelectionChanging);
            this.grid1.CurrentCell.MoveTo(1, 1);

            grid1.Model = model;
        }
        #endregion      
		
        #region Designer Stuffs
        /// <summary>
		///    Required method for Designer support - do not modify
		///    the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo1 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            this.grid1 = new SampleGrid();
            ((System.ComponentModel.ISupportInitialize)(this.grid1)).BeginInit();
            this.components = new Container();
            this.SuspendLayout();
            // 
            // grid1
            // 
            this.grid1.AllowDragSelectedCols = true;
            this.grid1.AllowDragSelectedRows = true;
            this.grid1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grid1.BackColor = System.Drawing.Color.White;
            this.grid1.ColCount = 0;
            this.grid1.DefaultColWidth = 0;
            this.grid1.DefaultGridBorderStyle = Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid;
            this.grid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid1.ExcelLikeCurrentCell = true;
            this.grid1.ExcelLikeSelectionFrame = true;
            this.grid1.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.grid1.ForeColor = System.Drawing.SystemColors.WindowText;
            gridCellInfo1.Col = -1;
            gridCellInfo1.Row = -1;
            gridCellInfo1.StyleInfo.Borders.Bottom = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234))))), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin);
            gridCellInfo1.StyleInfo.Borders.Right = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234))))), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin);
            gridCellInfo1.StyleInfo.Font.Facename = "Segoe UI";
            gridCellInfo1.StyleInfo.Interior = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.White);
            gridCellInfo1.StyleInfo.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.grid1.GridCells.AddRange(new Syncfusion.Windows.Forms.Grid.GridCellInfo[] {
            gridCellInfo1});
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
            this.grid1.Size = this.ClientSize;
            this.grid1.SmartSizeBox = false;
            this.grid1.TabIndex = 1;
            this.grid1.ThemesEnabled = true;
            this.grid1.VerticalScrollTips = true;
            // 
            // GridFrame
            // 
            this.CausesValidation = false;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 333);
            this.Controls.Add(this.grid1);
            this.Name = "GridFrame";
            ((System.ComponentModel.ISupportInitialize)(this.grid1)).EndInit();
            this.ResumeLayout(false);

		}
        /// <summary>
        ///    Clean up any resources being used.
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

        #region Events
        /// <summary>
		/// SelectionChanging event handler for grid.
		/// </summary>
		/// <model name="sender"></model>
		/// <model name="e"></model>
		public void grid1_SelectionChanging(object sender, GridSelectionChangingEventArgs e)
		{
			if (e.Cancel)
				return;
        }
        #endregion
    }
}

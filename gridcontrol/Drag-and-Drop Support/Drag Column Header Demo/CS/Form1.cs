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
using System.Windows.Forms;
using System.Data;
using Syncfusion.Windows.Forms.Grid;
using Syncfusion.Windows.Forms;
using DemoCommon.Grid;

namespace DragColumnHeader
{
    /// <summary>
    /// Summary description for Form1.
    /// </summary>
    public class Form1 : GridDemoForm
    {
        #region "API Definition"

        private Syncfusion.Windows.Forms.Grid.GridControl gridControl1;
        private System.Windows.Forms.Panel panel1;
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.Container components = null;
        #endregion

        #region Constructor

        public Form1()
        {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();
            if (DpiAware.GetCurrentDpi() > 96)
            {
                this.CaptionBarHeight = (int)DpiAware.LogicalToDeviceUnits(this.CaptionBarHeight);
            }
            this.GridSettings();
            this.SampleCustomization();
        }

        #endregion

        #region "Sample Grid Settings"

        /// <summary>
        /// Setting GridGrouping control Properties
        /// </summary>
        private void GridSettings()
        {
            this.gridControl1.RowCount = 40;
            this.gridControl1.ColCount = 20;

            for (int row = 1; row <= this.gridControl1.RowCount; ++row)
                for (int i = 1; i <= this.gridControl1.ColCount; ++i)
                    this.gridControl1[row, i].Text = (i * row) + 20.ToString();

            this.gridControl1.DefaultRowHeight = (int)DpiAware.LogicalToDeviceUnits(18.0f);
            this.gridControl1.DefaultColWidth = (int)DpiAware.LogicalToDeviceUnits(70.0f);
            this.gridControl1.GridVisualStyles = GridVisualStyles.Metro;
            this.gridControl1.DefaultGridBorderStyle = GridBorderStyle.Solid;
            this.gridControl1.Properties.GridLineColor = Color.FromArgb(208, 215, 229);
            GridStyleInfo style = gridControl1.BaseStylesMap["Header"].StyleInfo;
            style.Font.Facename = "Segoe UI";
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        #endregion

        #region "Sample Customizations"

        /// <summary>
        /// Grouping sample Customizations 
        /// </summary>
        private void SampleCustomization()
        {
            this.gridControl1.QueryAllowDragColumnHeader += new GridQueryDragColumnHeaderEventHandler(gridControl1_QueryAllowDragColumnHeader);
            this.gridControl1.ControllerOptions |= GridControllerOptions.DragColumnHeader;
            this.gridControl1.CellClick += new GridCellClickEventHandler(gridControl1_CellClick);
            this.gridControl1.CellDoubleClick += new GridCellClickEventHandler(gridControl1_CellDoubleClick);
        }

        #region Event Handlers

        #region gridControl1_CellClick
        /// <summary>
        /// Writes the CellClik event in output
        /// </summary>
        private void gridControl1_CellClick(object sender, GridCellClickEventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("gridControl1_CellClick: " + e.ToString());
        }
        #endregion

        #region gridControl1_CellDoubleClick
        /// <summary>
        /// Writes the Cell double Clik event in output
        /// </summary>
        private void gridControl1_CellDoubleClick(object sender, GridCellClickEventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("gridControl1_CellDoubleClick: " + e.ToString());
            e.Cancel = true; // Avoid subsequent CellClick being raised.
        }
        #endregion

        #region QueryAllowDragColumnHeader
        /// <summary>
        /// Allow to drag the column header
        /// </summary>
        void gridControl1_QueryAllowDragColumnHeader(object sender, GridQueryDragColumnHeaderEventArgs e)
        {
            if (e.Reason != GridQueryDragColumnHeaderReason.HitTest)
                System.Diagnostics.Debug.WriteLine("gridControl1_QueryAllowDragColumnHeader: " + e.ToString());
        }
        #endregion

        #endregion

        #endregion

        #region "Designer Stuffs"

        #region Dispose
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
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo1 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            this.gridControl1 = new Syncfusion.Windows.Forms.Grid.GridControl();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DpiAware = true;
            this.gridControl1.AlphaBlendSelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(94)))), ((int)(((byte)(171)))), ((int)(((byte)(222)))));
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.BackColor = System.Drawing.Color.White;
            this.gridControl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gridControl1.ColCount = 20;
            this.gridControl1.DefaultGridBorderStyle = Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid;
            this.gridControl1.EnableIntelliMouse = true;
            this.gridControl1.Font = new System.Drawing.Font("Segoe UI", 9F);
            gridCellInfo1.Col = -1;
            gridCellInfo1.Row = -1;
            gridCellInfo1.StyleInfo.Borders.Bottom = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234))))), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin);
            gridCellInfo1.StyleInfo.Borders.Right = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234))))), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin);
            gridCellInfo1.StyleInfo.Font.Facename = "Segoe UI";
            gridCellInfo1.StyleInfo.Interior = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.White);
            gridCellInfo1.StyleInfo.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gridControl1.GridCells.AddRange(new Syncfusion.Windows.Forms.Grid.GridCellInfo[] {
            gridCellInfo1});
            //this.gridControl1.GridOfficeScrollBars = Syncfusion.Windows.Forms.OfficeScrollBars.Metro;
            //this.gridControl1.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro;
            this.gridControl1.DefaultRowHeight = (int)DpiAware.LogicalToDeviceUnits(20.0f);
            this.gridControl1.HorizontalThumbTrack = true;
            this.gridControl1.HScrollPixel = true;
            this.gridControl1.Location = new System.Drawing.Point(12, 12);
            //this.gridControl1.MetroScrollBars = true;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Properties.ForceImmediateRepaint = false;
            this.gridControl1.Properties.GridLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.gridControl1.Properties.MarkColHeader = false;
            this.gridControl1.Properties.MarkRowHeader = false;
            this.gridControl1.RowCount = 12;
            this.gridControl1.RowHeightEntries.AddRange(new Syncfusion.Windows.Forms.Grid.GridRowHeight[] {
            new Syncfusion.Windows.Forms.Grid.GridRowHeight(0, 29)});
            this.gridControl1.Size = new System.Drawing.Size(888, 518);
            this.gridControl1.SmartSizeBox = false;
            this.gridControl1.TabIndex = 0;
            this.gridControl1.Text = "gridControl1";
            this.gridControl1.ThemesEnabled = true;
            this.gridControl1.VerticalThumbTrack = true;
            this.gridControl1.VScrollPixel = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(912, 543);
            this.panel1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 543);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(500, 300);
            this.Name = "Form1";
            this.Text = "Drag Column Header";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion

        #region "Main"
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense(Syncfusion.Licensing.DemoCommon.FindLicenseKey());
# if SyncfusionFramework1_1 || SyncfusionFramework2_0
            Application.EnableVisualStyles();
# endif
            Application.Run(new Form1());
        }

        #endregion

        #endregion
    }
}

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
using System.Collections.Specialized;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Text;
using System.IO;
using System.Reflection;

using Syncfusion.Windows.Forms;
using Syncfusion.Windows.Forms.Grid;
using Syncfusion.Diagnostics;
using Syncfusion.Windows.Forms.Tools;
using DemoCommon.Grid;

namespace CustomCellAutoSizing
{
	public class Form1 : GridDemoForm
    {
        #region "API Definiton"

        private Syncfusion.Windows.Forms.Grid.GridControl gridControl1;
        private Syncfusion.Windows.Forms.Tools.CheckBoxAdv checkBox1;
		public bool usePreferredClientSize = true;
		private System.Windows.Forms.Panel panel1;
		private System.ComponentModel.IContainer components=null;

        #endregion

        #region "Constructor"
        /// <summary>
        /// Form Constructor
        /// </summary>
        public Form1()
		{
			InitializeComponent();
            if (DpiAware.GetCurrentDpi() > 96)
            {
                this.CaptionBarHeight = (int)DpiAware.LogicalToDeviceUnits(this.CaptionBarHeight);
            }
            this.GridSettings();

        }

        #endregion

        #region "Grid Settings"
        /// <summary>
        /// Grid Settings for better look and feel
        /// </summary>
        private void GridSettings()
        {

            this.gridControl1.GridVisualStyles = GridVisualStyles.Office2007Blue;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.gridControl1.GridVisualStyles = GridVisualStyles.Metro;

            this.gridControl1.Model.Options.DisplayEmptyColumns = true;
            this.gridControl1.Model.Options.DisplayEmptyRows = true;

        }
        #endregion

        #region "Designer Stuffs"

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

        #region Windows Form Designer generated code
        /// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.gridControl1 = new Syncfusion.Windows.Forms.Grid.GridControl();
            this.checkBox1 = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DpiAware = true;
            this.gridControl1.AlphaBlendSelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(94)))), ((int)(((byte)(171)))), ((int)(((byte)(222)))));
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gridControl1.ColCount = 11;
            this.gridControl1.ColWidthEntries.AddRange(new Syncfusion.Windows.Forms.Grid.GridColWidth[] {
            new Syncfusion.Windows.Forms.Grid.GridColWidth(0, 35),
            new Syncfusion.Windows.Forms.Grid.GridColWidth(1, 176),
            new Syncfusion.Windows.Forms.Grid.GridColWidth(2, 66)});
            this.gridControl1.DefaultGridBorderStyle = Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid;
            this.gridControl1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gridControl1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gridControl1.ThemesEnabled = true;
            this.gridControl1.GridOfficeScrollBars = Syncfusion.Windows.Forms.OfficeScrollBars.Metro;
            this.gridControl1.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro;
            this.gridControl1.DefaultRowHeight = (int)DpiAware.LogicalToDeviceUnits(20.0f);
            this.gridControl1.Location = new System.Drawing.Point(-2, -2);
            this.gridControl1.MetroScrollBars = true;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Properties.ForceImmediateRepaint = false;
            this.gridControl1.Properties.GridLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.gridControl1.Properties.MarkColHeader = false;
            this.gridControl1.Properties.MarkRowHeader = false;
            this.gridControl1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.gridControl1.RowHeightEntries.AddRange(new Syncfusion.Windows.Forms.Grid.GridRowHeight[] {
            new Syncfusion.Windows.Forms.Grid.GridRowHeight(0, 21),
            new Syncfusion.Windows.Forms.Grid.GridRowHeight(1, 17),
            new Syncfusion.Windows.Forms.Grid.GridRowHeight(2, 18),
            new Syncfusion.Windows.Forms.Grid.GridRowHeight(3, 17),
            new Syncfusion.Windows.Forms.Grid.GridRowHeight(4, 18)});
            this.gridControl1.SerializeCellsBehavior = Syncfusion.Windows.Forms.Grid.GridSerializeCellsBehavior.SerializeAsRangeStylesIntoCode;
            this.gridControl1.Size = new System.Drawing.Size(866, 489);
            this.gridControl1.SmartSizeBox = false;
            this.gridControl1.TabIndex = 0;
            
            // 
            // checkBox1
            // 
            this.checkBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBox1.BeforeTouchSize = new System.Drawing.Size(150, 21);
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.DrawFocusRectangle = false;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(511, 511);
            this.checkBox1.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(90, 24);
            this.checkBox1.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.checkBox1.TabIndex = 1;
            this.checkBox1.Text = "Resize To Fit";
            this.checkBox1.ThemesEnabled = false;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.gridControl1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(864, 493);
            this.panel1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 543);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(600, 500);
            this.Name = "Form1";
            this.Text = "Custom Cell Autosizing";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

		}
		#endregion

		[STAThread]
		static void Main()
        {
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense(Syncfusion.Licensing.DemoCommon.FindLicenseKey());
			Application.Run(new Form1());
        }

        #endregion
        
        #region Event Handlers

        private void Form1_Load(object sender, System.EventArgs e)
        {
            InitializeForm();
        }
        int colsize, rowsize;
        void InitializeForm()
        {
            gridControl1.BeginUpdate();
            gridControl1.ThemesEnabled = true;
            gridControl1.TableStyle.FloatCell = true;
            gridControl1.FloatCellsMode = GridFloatCellsMode.OnDemandCalculation;
            gridControl1.AllowSelection = GridSelectionFlags.Any;
            //Register Custom Cell Types
            this.gridControl1.CellModels.Add("Slider", new CustomControlCellModel(this.gridControl1.Model));
            this.gridControl1.CellModels.Add("DataEntry", new CustomControlCellModel(gridControl1.Model));
            this.gridControl1.CellModels.Add("ChoiceList", new CustomControlCellModel(gridControl1.Model));

            Control control;
            GridStyleInfo style;

            //Setup DataEntry Cell
            style = gridControl1[2, 2];
            style.CellType = "DataEntry";
            control = new DataEntryControl();
            MakeUnBuffered(control);
            //Pass the type of CellControl to cell model class through its Tag
            style.Tag = control;

            //Setup ChoiceList Cell
            style = gridControl1[3, 3];
            style.CellType = "ChoiceList";
            control = new ChoiceListControl();
            MakeUnBuffered(control);
            //Pass the type of CellControl to cell model class through its Tag
            style.Tag = control;

            //Setup Slider Cell
            style = gridControl1[4, 4];
            style.CellType = "Slider";
            //Pass the type of CellControl to cell model class through its Tag
            style.Tag = new TrackBar();

            colsize = gridControl1.ColWidths[2];
            rowsize = gridControl1.RowHeights[2];

            //Call ResizeToFit which in turn calls OnQueryPreferredClientSize method in the cell model class
            //in order to retrieve the Correct size of the controls in grid cells and adjust respective 
            //RowHeights & ColWidths in order to make the cells to fit controls.
            this.gridControl1.RowHeights[0] = (int)DpiAware.LogicalToDeviceUnits(21.0f);
            gridControl1.RowHeights.ResizeToFit(GridRangeInfo.Table(), GridResizeToFitOptions.NoShrinkSize);
            gridControl1.ColWidths.ResizeToFit(GridRangeInfo.Table());

            this.gridControl1.CellClick += new GridCellClickEventHandler(gridControl1_CellClick);
            gridControl1.EndUpdate(true);
            Application.Idle += new EventHandler(Application_Idle);
            for (int i = 1; i <= 4; i++)
            {
                widths.Add(i, gridControl1.ColWidths[i]);
            }
        }

        void gridControl1_CellClick(object sender, GridCellClickEventArgs e)
        {
            this.gridControl1.Refresh();
        }
        Hashtable widths = new Hashtable();
        void Application_Idle(object sender, EventArgs e)
        {
            for (int i = 1; i <= 4; i++)
            {
                if (gridControl1.ColWidths[i] < int.Parse(widths[i].ToString()))
                    gridControl1.ColWidths[i] = int.Parse(widths[i].ToString());
            }
        }

        private void MakeUnBuffered(Control control)
        {

            System.Reflection.MethodInfo mInfo = typeof(Control).GetMethod("SetStyle",
                System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.InvokeMethod |
                System.Reflection.BindingFlags.NonPublic);
            if (mInfo != null)
            {
                mInfo.Invoke(control, new

                    object[] { Syncfusion.Windows.Forms.WhidbeyCompatibleControlStyles.DoubleBuffer, false });
            }
            foreach (Control cc in control.Controls)
            {
                cc.CausesValidation = false;
                MakeUnBuffered(cc);
            }
        }
        void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBox1.Checked)
            {
                gridControl1.BeginUpdate();
                gridControl1.RowHeights.ResizeToFit(GridRangeInfo.Table());
                gridControl1.ColWidths.ResizeToFit(GridRangeInfo.Table());
                gridControl1.EndUpdate(true);
            }
            else
            {
                gridControl1.BeginUpdate();
                for (int i = 2; i <= 6; i++)
                {
                    gridControl1.RowHeights[i] = rowsize;
                    gridControl1.ColWidths[i] = colsize;
                }
                gridControl1.EndUpdate(true);
            }
            this.gridControl1.Refresh();
        }
        #endregion
	}
}

#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using Syncfusion.Windows.Forms.Grid;
using Syncfusion.Grouping;
using Syncfusion.GridHelperClasses;
using Syncfusion.Windows.Forms.Grid.Grouping;
using Syncfusion.Windows.Forms;
using DemoCommon.Grid;

namespace ExcelStyleFilter
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : GridDemoForm
    {
        #region "API Definitions"

        private Syncfusion.Windows.Forms.Grid.Grouping.GridGroupingControl gridGroupingControl1;
        private GridOffice2007Filter filter;
        private Syncfusion.Windows.Forms.Tools.CheckBoxAdv showFilter;
        private Syncfusion.Windows.Forms.Tools.CheckBoxAdv EnableFilteredColIcon;
        private GroupBox groupBox1;
        private Syncfusion.Windows.Forms.Tools.CheckBoxAdv filterMouseHover;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

        #endregion

        #region "Constructor"

        public Form1()
		{
			InitializeComponent();
            GridSettings();
            SampleCustomization();
		}

        #endregion

        #region "GridSettings"

        void GridSettings()
        {
            #region "DataSource"
            DataTable dt = new DataTable("MyTable");

            int nCols = 10;
            int nRows = 30;

            for (int i = 0; i < nCols; i++)
            {
                dt.Columns.Add(new DataColumn(string.Format("Col {0}", i), typeof(int)));
            }
            Random rand = new Random();

            for (int i = 0; i < nRows; ++i)
            {
                DataRow dr = dt.NewRow();
                for (int j = 0; j < nCols; j++)

                    dr[j] = rand.Next(500);
                dt.Rows.Add(dr);
            }

            this.gridGroupingControl1.DataSource = dt;
			this.gridGroupingControl1.TableControl.DpiAware = true;
            #endregion
            this.gridGroupingControl1.TopLevelGroupOptions.ShowAddNewRecordBeforeDetails = false;
            this.gridGroupingControl1.TopLevelGroupOptions.ShowCaption = false;
            this.BackColor = Color.White;
            this.gridGroupingControl1.GridVisualStyles = GridVisualStyles.Metro;
            this.gridGroupingControl1.AllowProportionalColumnSizing = true;
            this.gridGroupingControl1.TableOptions.ListBoxSelectionMode = SelectionMode.MultiExtended;

            //Navigate to other control using tabkey navigation
            this.gridGroupingControl1.WantTabKey = false;
        }

        #endregion

        #region "Sample Customization"

        void SampleCustomization()
        {
            filter = new GridOffice2007Filter();
            //Allow Filter for each Columns.
            foreach (GridColumnDescriptor col in this.gridGroupingControl1.TableDescriptor.Columns)
            {
                col.AllowFilter = true;
            }
            this.showFilter.Checked = true;
            this.EnableFilteredColIcon.Checked = true;
        }

        #region "Events"

        // This checkbox decides whether to show Filter or not.
        private void showFilter_CheckStateChanged(object sender, EventArgs e)
        {
            if (this.showFilter.Checked)
            {
                filter.WireGrid(this.gridGroupingControl1);
                this.EnableFilteredColIcon.Enabled = true;
                this.filterMouseHover.Enabled = true;
            }
            else
            {
                filter.UnWireGrid(this.gridGroupingControl1);
                this.EnableFilteredColIcon.Enabled = false;
                this.filterMouseHover.Enabled = false;
            }
        }

        // This checkbox decides whether to show Filter Icon or not.
        private void EnableFilteredColIcon_CheckStateChanged(object sender, EventArgs e)
        {
            GridOffice2007Filter.EnableFilteredColumnIcon = this.EnableFilteredColIcon.Checked;
            this.gridGroupingControl1.Refresh();
        }

        // This checkbox decides whether to show Filter while doing mouse hover
        private void filterMouseHover_CheckStateChanged(object sender, EventArgs e)
        {
            GridOffice2007Filter.ShowOffice2007FilterOnMouseHover = this.filterMouseHover.Checked;
            this.gridGroupingControl1.Refresh();
        }
        #endregion

        #endregion

        #region "Designer Stuffs"

        #region Dispose
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
            this.gridGroupingControl1 = new Syncfusion.Windows.Forms.Grid.Grouping.GridGroupingControl();
            this.showFilter = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.EnableFilteredColIcon = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.filterMouseHover = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            ((System.ComponentModel.ISupportInitialize)(this.gridGroupingControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.showFilter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EnableFilteredColIcon)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.filterMouseHover)).BeginInit();
            this.SuspendLayout();
            // 
            // gridGroupingControl1
            // 
            this.gridGroupingControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridGroupingControl1.BackColor = System.Drawing.SystemColors.Window;
            this.gridGroupingControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridGroupingControl1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.gridGroupingControl1.GridOfficeScrollBars = Syncfusion.Windows.Forms.OfficeScrollBars.Metro;
            this.gridGroupingControl1.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro;
            this.gridGroupingControl1.Location = new System.Drawing.Point(8, 9);
            this.gridGroupingControl1.Name = "gridGroupingControl1";
            this.gridGroupingControl1.Size = new System.Drawing.Size(782, 635);
            this.gridGroupingControl1.TabIndex = 1;
            this.gridGroupingControl1.TableDescriptor.AllowNew = false;
            this.gridGroupingControl1.TableDescriptor.Appearance.AnyCell.Font.Facename = "Segoe UI";
            this.gridGroupingControl1.TableDescriptor.Appearance.AnyCell.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gridGroupingControl1.TableDescriptor.Appearance.AnyGroupCell.Borders.Bottom = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234))))), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin);
            this.gridGroupingControl1.TableDescriptor.Appearance.AnyGroupCell.Borders.Right = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234))))), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin);
            this.gridGroupingControl1.TableDescriptor.Appearance.AnyGroupCell.Interior = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235))))));
            this.gridGroupingControl1.TableDescriptor.Appearance.AnyGroupCell.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gridGroupingControl1.TableDescriptor.Appearance.AnyRecordFieldCell.Borders.Bottom = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234))))), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin);
            this.gridGroupingControl1.TableDescriptor.Appearance.AnyRecordFieldCell.Borders.Right = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234))))), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin);
            this.gridGroupingControl1.TableDescriptor.Appearance.AnySummaryCell.Borders.Right = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208))))), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin);
            this.gridGroupingControl1.TableDescriptor.Appearance.AnySummaryCell.Borders.Top = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208))))), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin);
            this.gridGroupingControl1.TableDescriptor.Appearance.AnySummaryCell.Interior = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208))))));
            this.gridGroupingControl1.TableDescriptor.Appearance.ColumnHeaderCell.Font.Bold = true;
            this.gridGroupingControl1.TableDescriptor.Appearance.GroupCaptionCell.CellType = "ColumnHeader";
            this.gridGroupingControl1.TableDescriptor.TableOptions.ColumnHeaderRowHeight = (int)DpiAware.LogicalToDeviceUnits(25.0f);
            this.gridGroupingControl1.TableDescriptor.TableOptions.RecordRowHeight = (int)DpiAware.LogicalToDeviceUnits(20.0f);
            this.gridGroupingControl1.TableOptions.GridLineBorder = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229))))));
            this.gridGroupingControl1.Text = "gridGroupingControl1";
            this.gridGroupingControl1.VersionInfo = "4.201.0.37";
            // 
            // showFilter
            // 
            this.showFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.showFilter.DrawFocusRectangle = false;
            this.showFilter.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showFilter.Location = new System.Drawing.Point(6, 30);
            this.showFilter.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.showFilter.Name = "showFilter";
            this.showFilter.Size = new System.Drawing.Size(162, 28);
            this.showFilter.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.showFilter.DrawFocusRectangle = true;
            this.showFilter.TabIndex = 2;
            this.showFilter.Text = "Enable Office2007Filter";
            this.showFilter.ThemesEnabled = false;
            this.showFilter.CheckStateChanged += new System.EventHandler(this.showFilter_CheckStateChanged);
            // 
            // EnableFilteredColIcon
            // 
            this.EnableFilteredColIcon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.EnableFilteredColIcon.DrawFocusRectangle = false;
            this.EnableFilteredColIcon.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnableFilteredColIcon.Location = new System.Drawing.Point(7, 69);
            this.EnableFilteredColIcon.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.EnableFilteredColIcon.Name = "EnableFilteredColIcon";
            this.EnableFilteredColIcon.Size = new System.Drawing.Size(184, 19);
            this.EnableFilteredColIcon.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.EnableFilteredColIcon.DrawFocusRectangle = true;
            this.EnableFilteredColIcon.TabIndex = 3;
            this.EnableFilteredColIcon.Text = "Enable Filtered Column Icon";
            this.EnableFilteredColIcon.ThemesEnabled = false;
            this.EnableFilteredColIcon.CheckStateChanged += new System.EventHandler(this.EnableFilteredColIcon_CheckStateChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.filterMouseHover);
            this.groupBox1.Controls.Add(this.showFilter);
            this.groupBox1.Controls.Add(this.EnableFilteredColIcon);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(800, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 162);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filter Options";
            // 
            // filterMouseHover
            // 
            this.filterMouseHover.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.filterMouseHover.Checked = true;
            this.filterMouseHover.CheckState = System.Windows.Forms.CheckState.Checked;
            this.filterMouseHover.DrawFocusRectangle = false;
            this.filterMouseHover.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filterMouseHover.Location = new System.Drawing.Point(7, 100);
            this.filterMouseHover.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.filterMouseHover.Name = "filterMouseHover";
            this.filterMouseHover.Size = new System.Drawing.Size(184, 28);
            this.filterMouseHover.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.filterMouseHover.DrawFocusRectangle = true;
            this.filterMouseHover.TabIndex = 4;
            this.filterMouseHover.Text = "Show filter on MouseHover";
            this.filterMouseHover.ThemesEnabled = false;
            this.filterMouseHover.CheckStateChanged += new System.EventHandler(this.filterMouseHover_CheckStateChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 656);
            this.MinimumSize = new System.Drawing.Size(900, 500);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gridGroupingControl1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MS Excel-Style Filter";
            ((System.ComponentModel.ISupportInitialize)(this.gridGroupingControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.showFilter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EnableFilteredColIcon)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.filterMouseHover)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

        #region "Static Main method"
        /// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
        {
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense(Syncfusion.Licensing.DemoCommon.FindLicenseKey());
			Application.Run(new Form1());
		}
        #endregion

        #endregion
	}
}

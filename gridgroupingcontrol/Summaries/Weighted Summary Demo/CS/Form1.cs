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
using Syncfusion.Windows.Forms.Grid.Grouping;
using Syncfusion.Windows.Forms.Grid;
using Syncfusion.Grouping;

using ISummary = Syncfusion.Collections.BinaryTree.ITreeTableSummary;
using Syncfusion.Windows.Forms;
using DemoCommon.Grid;

namespace WeightedSummary
{
    /// <summary>
    /// Summary description for Form1.
    /// </summary>
    public class Form1 : GridDemoForm
    {
        #region "API Definition"

        private Syncfusion.Windows.Forms.Grid.Grouping.GridGroupingControl gridGroupingControl1;
        private Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private PropertyGrid propertyGrid1;
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
        /// Setting GridGrouping control properties
        /// </summary>
        private void GridSettings()
        {
            //Set DataSource for the grid
            this.gridGroupingControl1.DataSource = GetTable();

            //used to set multiextended selection mode in gridgrouping control. 
			this.gridGroupingControl1.TableControl.DpiAware = true;
            this.gridGroupingControl1.TableOptions.ListBoxSelectionMode = SelectionMode.MultiExtended;
            this.gridGroupingControl1.AllowProportionalColumnSizing = true;

            //Navigate to other control using tabkey navigation
            this.gridGroupingControl1.WantTabKey = false;
        }

        #endregion

        #region "Sample Customizations"

        /// <summary>
        /// WeightedSummary sample Customizations
        /// </summary>
        private void SampleCustomization()
        {
            this.label1.Text += "	Weighted sum of Col2 using weights from Col3";
            this.label2.Text += "	Weighted sum of Col4 using weights from Col5";

            //needed to setup the CustomSummary type
            this.gridGroupingControl1.TableDescriptor.QueryCustomSummary += new GridQueryCustomSummaryEventHandler(gridGroupingControl1_QueryCustomSummary);

            //use a code naming convention to pass the column holding the weights into the SummaryDescriptor

            //weighted sum of Col2 using weights from Col3
            GridSummaryColumnDescriptor wgtSumCol2 = GetWeightedSummaryColumnDescriptor("Col2", "Col3");

            //weighted sum of Col4 using weights from Col5
            GridSummaryColumnDescriptor wgtSumCol4 = GetWeightedSummaryColumnDescriptor("Col4", "Col5");

            //add the summary columns to a summary row
            this.gridGroupingControl1.TableDescriptor.SummaryRows.Add(new GridSummaryRowDescriptor("Row0", "Weighted Summary", new GridSummaryColumnDescriptor[] { wgtSumCol2, wgtSumCol4 }));
            this.gridGroupingControl1.TableDescriptor.Columns["Col0"].Width = 150;

            //group a column
            this.gridGroupingControl1.TableDescriptor.GroupedColumns.Add("Col1");
            this.gridGroupingControl1.Table.ExpandAllGroups();

            foreach (GridColumnDescriptor col in this.gridGroupingControl1.TableDescriptor.Columns)
            {
                System.Text.RegularExpressions.Regex rex = new System.Text.RegularExpressions.Regex(@"\d+");
                int index = rex.Match(col.MappingName.Substring(1)).Index;
                string name = "";
                while (index > 0)
                {
                    name += col.MappingName.Substring(0, index + 1) + " ";
                    string secondName = col.MappingName.Substring(index + 1);
                    index = rex.Match(secondName.Substring(1)).Index;
                    while (index > 0)
                    {
                        name += secondName.Substring(0, index + 1) + " ";
                        index = rex.Match(col.MappingName.Substring(name.Replace(" ", "").Length).Substring(1)).Index;
                    }
                }
                name += col.MappingName.Substring(name.Replace(" ", "").Length);
                col.HeaderText = name;
            }
        }

        #region GetWeightedSummaryColumnDescriptor

        /// <summary>
        /// Applying WeightedSummary for Given Columns
        /// </summary>
        private GridSummaryColumnDescriptor GetWeightedSummaryColumnDescriptor(string sourceCol, string weightCol)
        {
            GridSummaryColumnDescriptor wgtSumCol = new GridSummaryColumnDescriptor();
            wgtSumCol.Name = string.Format("{0}_{1}", sourceCol, weightCol); //special name following the convention above
            wgtSumCol.DataMember = sourceCol; //the column this summary is applied to
            wgtSumCol.DisplayColumn = sourceCol; //where thissummary is displayed
            wgtSumCol.Format = "{WeightedAverage:#.##}"; //what is displayed in the summary
            wgtSumCol.SummaryType = SummaryType.Custom; //marks this as a CustomSummary
            wgtSumCol.Appearance.AnySummaryCell.HorizontalAlignment = GridHorizontalAlignment.Right;
            wgtSumCol.MaxLength = 6;

            return wgtSumCol;
        }

        #endregion

        #region gridGroupingControl1_QueryCustomSummary Event Handler
        
        /// <summary>
        /// Creating a CustomSummaary method.
        /// </summary>
        private void gridGroupingControl1_QueryCustomSummary(object sender, GridQueryCustomSummaryEventArgs e)
        {
            if (e.SummaryDescriptor.SummaryType == SummaryType.Custom)
            {
                e.SummaryDescriptor.CreateSummaryMethod =
                    new CreateSummaryDelegate(WeightedSummary.CreateSummaryMethod);
            }
            e.Handled = true;
        }

        #endregion

        #endregion

        #region "Designer Stuffs"

        #region "Dispose"

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
            this.gridGroupingControl1 = new Syncfusion.Windows.Forms.Grid.Grouping.GridGroupingControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.propertyGrid1 = new System.Windows.Forms.PropertyGrid();
            ((System.ComponentModel.ISupportInitialize)(this.gridGroupingControl1)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridGroupingControl1
            // 
            this.gridGroupingControl1.AlphaBlendSelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(94)))), ((int)(((byte)(171)))), ((int)(((byte)(222)))));
            //this.gridGroupingControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            //| System.Windows.Forms.AnchorStyles.Right)));
            this.gridGroupingControl1.Dock = DockStyle.Fill;
            this.gridGroupingControl1.BackColor = System.Drawing.SystemColors.Window;
            this.gridGroupingControl1.GridOfficeScrollBars = Syncfusion.Windows.Forms.OfficeScrollBars.Metro;
            this.gridGroupingControl1.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro;
            this.gridGroupingControl1.Location = new System.Drawing.Point(0, 0);
            this.gridGroupingControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gridGroupingControl1.Name = "gridGroupingControl1";
            this.gridGroupingControl1.ShowCurrentCellBorderBehavior = Syncfusion.Windows.Forms.Grid.GridShowCurrentCellBorder.GrayWhenLostFocus;
            this.gridGroupingControl1.Size = new System.Drawing.Size(1175, 796);
            this.gridGroupingControl1.TabIndex = 0;
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
            this.gridGroupingControl1.TableDescriptor.TableOptions.ColumnHeaderRowHeight = (int)DpiAware.LogicalToDeviceUnits(25);
            this.gridGroupingControl1.TableDescriptor.TableOptions.RecordRowHeight = (int)DpiAware.LogicalToDeviceUnits(20);
            this.gridGroupingControl1.Text = "gridGroupingControl1";
            this.gridGroupingControl1.VersionInfo = "4.400.0.50";
            // 
            // panel1
            // 
            this.panel1.Dock = DockStyle.Fill;
            this.panel1.Controls.Add(this.gridGroupingControl1);
            this.panel1.Location = new System.Drawing.Point(42, 35);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1179, 797);
            this.panel1.TabIndex = 16;
            // 
            // groupBox1
            // 
            //this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            //| System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Dock = DockStyle.Bottom;
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.groupBox1.ForeColor = System.Drawing.Color.DimGray;
            this.groupBox1.Location = new System.Drawing.Point(18, 865);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(1482, 150);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Summary Details";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(72, 86);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1209, 37);
            this.label2.TabIndex = 1;
            this.label2.Text = "Summary Column \'Col4\' :";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(72, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(747, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Summary Column \'Col2\' :";
            // 
            // propertyGrid1
            // 
            //this.propertyGrid1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            // | System.Windows.Forms.AnchorStyles.Right)));
            this.propertyGrid1.Dock = DockStyle.Right;
            this.propertyGrid1.BackColor = System.Drawing.Color.White;
            this.propertyGrid1.CommandsBackColor = System.Drawing.Color.White;
            this.propertyGrid1.CommandsDisabledLinkColor = System.Drawing.Color.White;
            this.propertyGrid1.HelpBackColor = System.Drawing.Color.White;
            this.propertyGrid1.LineColor = System.Drawing.Color.White;
            this.propertyGrid1.Location = new System.Drawing.Point(1246, 14);
            this.propertyGrid1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.propertyGrid1.Name = "propertyGrid1";
            this.propertyGrid1.SelectedObject = this.gridGroupingControl1;
            this.propertyGrid1.Size = new System.Drawing.Size(300, 818);
            this.propertyGrid1.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1513, 1010);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.propertyGrid1);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(1189, 585);
            this.Name = "Form1";
            this.Text = "Weighted Summary";
            ((System.ComponentModel.ISupportInitialize)(this.gridGroupingControl1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        #endregion

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

        # region DataTable

        /// <summary>
        /// Return datatable to set datasource for the grid.
        /// </summary>
        private DataTable GetTable()
        {
            DataTable dt = new DataTable("MyTable");

            int nCols = 8;
            int nRows = 50;

            for (int i = 0; i < nCols; i++)
                dt.Columns.Add(new DataColumn(string.Format("Col{0}", i), typeof(int)));

            Random r = new Random();
            for (int i = 0; i < nRows; ++i)
            {
                DataRow dr = dt.NewRow();
                for (int j = 0; j < nCols; j++)
                    dr[j] = r.Next(10);
                dt.Rows.Add(dr);
            }
            return dt;
        }
        #endregion

    }
}

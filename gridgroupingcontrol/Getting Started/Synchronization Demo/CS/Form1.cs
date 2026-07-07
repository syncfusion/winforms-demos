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
using System.IO;

using System.Data.OleDb;
using Syncfusion.Grouping;
using Syncfusion.Windows.Forms.Grid;
using Syncfusion.Windows.Forms;
using DemoCommon.Grid;

namespace FirstGridGroupCtl
{
    /// <summary>
    /// Summary description for Form1.
    /// </summary>
    public class Form1 : GridDemoForm
    {
        #region API Definition
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Splitter splitter1;
        private Syncfusion.Windows.Forms.Grid.GridDataBoundGrid gridDataBoundGrid1;
        private Syncfusion.Windows.Forms.Grid.Grouping.GridGroupingControl gridGroupingControl1;
        private Panel panel2;
        private Panel panel3;
        private Label label1;
        private Label label2;
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
            //
            // TODO: Add any constructor code after InitializeComponent call
            //              
        }
        private void Form1_Load(object sender, System.EventArgs e)
        {
            //set the datasorce for the grids
            DataSet ds = GetACCDataSet();
            DataView dv = ds.Tables["ACCStats"].DefaultView;
            this.gridGroupingControl1.TableDescriptor.AllowNew = false;
            this.gridGroupingControl1.DataSource = dv;//ds.Tables["ACCStats"];

            this.gridDataBoundGrid1.DataSource = dv;
            this.gridDataBoundGrid1.UseListChangedEvent = true;
            GridSettings();
            this.gridDataBoundGrid1.DefaultRowHeight = (int)DpiAware.LogicalToDeviceUnits(25);
        }
        #endregion

        #region Designer stuffs
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Syncfusion.Windows.Forms.Grid.GridBaseStyle gridBaseStyle5 = new Syncfusion.Windows.Forms.Grid.GridBaseStyle();
            Syncfusion.Windows.Forms.Grid.GridBaseStyle gridBaseStyle6 = new Syncfusion.Windows.Forms.Grid.GridBaseStyle();
            Syncfusion.Windows.Forms.Grid.GridBaseStyle gridBaseStyle7 = new Syncfusion.Windows.Forms.Grid.GridBaseStyle();
            Syncfusion.Windows.Forms.Grid.GridBaseStyle gridBaseStyle8 = new Syncfusion.Windows.Forms.Grid.GridBaseStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.gridDataBoundGrid1 = new Syncfusion.Windows.Forms.Grid.GridDataBoundGrid();
            this.gridGroupingControl1 = new Syncfusion.Windows.Forms.Grid.Grouping.GridGroupingControl();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridDataBoundGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridGroupingControl1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.gridDataBoundGrid1);
            this.panel1.Location = new System.Drawing.Point(12, 50);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(730, 680);
            this.panel1.TabIndex = 0;
            // 
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(146)))), ((int)(((byte)(206)))));
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(8, 723);
            this.splitter1.TabIndex = 1;
            this.splitter1.TabStop = false;
            this.splitter1.Visible = false;
            // 
            // gridDataBoundGrid1
            // 
            this.gridDataBoundGrid1.AllowDragSelectedCols = true;
            this.gridDataBoundGrid1.AlphaBlendSelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(94)))), ((int)(((byte)(171)))), ((int)(((byte)(222)))));
            gridBaseStyle5.Name = "Column Header";
            gridBaseStyle5.StyleInfo.BaseStyle = "Header";
            gridBaseStyle5.StyleInfo.CellType = "ColumnHeaderCell";
            gridBaseStyle5.StyleInfo.Enabled = false;
            gridBaseStyle5.StyleInfo.Font.Bold = true;
            gridBaseStyle5.StyleInfo.Font.Facename = "Segoe UI";
            gridBaseStyle5.StyleInfo.HorizontalAlignment = Syncfusion.Windows.Forms.Grid.GridHorizontalAlignment.Center;
            gridBaseStyle6.Name = "Header";
            gridBaseStyle6.StyleInfo.Borders.Bottom = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None);
            gridBaseStyle6.StyleInfo.Borders.Left = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None);
            gridBaseStyle6.StyleInfo.Borders.Right = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None);
            gridBaseStyle6.StyleInfo.Borders.Top = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None);
            gridBaseStyle6.StyleInfo.CellType = "Header";
            gridBaseStyle6.StyleInfo.Font.Bold = true;
            gridBaseStyle6.StyleInfo.Interior = new Syncfusion.Drawing.BrushInfo(System.Drawing.SystemColors.Control);
            gridBaseStyle6.StyleInfo.VerticalAlignment = Syncfusion.Windows.Forms.Grid.GridVerticalAlignment.Middle;
            gridBaseStyle7.Name = "Standard";
            gridBaseStyle7.StyleInfo.CheckBoxOptions.CheckedValue = "True";
            gridBaseStyle7.StyleInfo.CheckBoxOptions.UncheckedValue = "False";
            gridBaseStyle7.StyleInfo.Interior = new Syncfusion.Drawing.BrushInfo(System.Drawing.SystemColors.Window);
            gridBaseStyle8.Name = "Row Header";
            gridBaseStyle8.StyleInfo.BaseStyle = "Header";
            gridBaseStyle8.StyleInfo.CellType = "RowHeaderCell";
            gridBaseStyle8.StyleInfo.Enabled = true;
            gridBaseStyle8.StyleInfo.HorizontalAlignment = Syncfusion.Windows.Forms.Grid.GridHorizontalAlignment.Left;
            this.gridDataBoundGrid1.BaseStylesMap.AddRange(new Syncfusion.Windows.Forms.Grid.GridBaseStyle[] {
            gridBaseStyle5,
            gridBaseStyle6,
            gridBaseStyle7,
            gridBaseStyle8});
            this.gridDataBoundGrid1.DefaultRowHeight = (int)DpiAware.LogicalToDeviceUnits(20.0f);
            this.gridDataBoundGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridDataBoundGrid1.GridOfficeScrollBars = Syncfusion.Windows.Forms.OfficeScrollBars.Metro;
            this.gridDataBoundGrid1.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro;
            this.gridDataBoundGrid1.Location = new System.Drawing.Point(0, 0);
            this.gridDataBoundGrid1.MetroScrollBars = true;
            this.gridDataBoundGrid1.Name = "gridDataBoundGrid1";
            this.gridDataBoundGrid1.Properties.ForceImmediateRepaint = false;
            this.gridDataBoundGrid1.Properties.GridLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.gridDataBoundGrid1.Properties.MarkColHeader = false;
            this.gridDataBoundGrid1.Properties.MarkRowHeader = false;
            this.gridDataBoundGrid1.ShowCurrentCellBorderBehavior = Syncfusion.Windows.Forms.Grid.GridShowCurrentCellBorder.GrayWhenLostFocus;
            this.gridDataBoundGrid1.Size = new System.Drawing.Size(730, 680);
            this.gridDataBoundGrid1.SmartSizeBox = false;
            this.gridDataBoundGrid1.SortBehavior = Syncfusion.Windows.Forms.Grid.GridSortBehavior.DoubleClick;
            this.gridDataBoundGrid1.TabIndex = 2;
            this.gridDataBoundGrid1.Text = "gridDataBoundGrid1";
            this.gridDataBoundGrid1.VerticalThumbTrack = true;
            // 
            // gridGroupingControl1
            // 
            this.gridGroupingControl1.BackColor = System.Drawing.SystemColors.Window;
            this.gridGroupingControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridGroupingControl1.Enabled = false;
            this.gridGroupingControl1.FreezeCaption = false;
            this.gridGroupingControl1.GridOfficeScrollBars = Syncfusion.Windows.Forms.OfficeScrollBars.Metro;
            this.gridGroupingControl1.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro;
            this.gridGroupingControl1.Location = new System.Drawing.Point(0, 0);
            this.gridGroupingControl1.Name = "gridGroupingControl1";
            this.gridGroupingControl1.Size = new System.Drawing.Size(730, 680);
            this.gridGroupingControl1.TabIndex = 1;
            this.gridGroupingControl1.TableDescriptor.AllowNew = false;
            this.gridGroupingControl1.TableDescriptor.TableOptions.ColumnHeaderRowHeight = (int)DpiAware.LogicalToDeviceUnits(25.0f);
            this.gridGroupingControl1.TableDescriptor.TableOptions.RecordRowHeight = (int)DpiAware.LogicalToDeviceUnits(25.0f);
            this.gridGroupingControl1.Text = "gridGroupingControl1";
            this.gridGroupingControl1.ThemesEnabled = false;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.gridGroupingControl1);
            this.panel2.Location = new System.Drawing.Point(770, 50);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(730, 680);
            this.panel2.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel3.Location = new System.Drawing.Point(664, 14);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(2, 937);
            this.panel3.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(317, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "GridDataBoundGrid";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right))));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1080, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "GridGroupingControl";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1513, 721);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(1000, 600);
            this.Name = "Form1";
            this.Text = "Synchronization Grid";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridDataBoundGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridGroupingControl1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }
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

        #region Get the data from a CSV file

        private ArrayList GetUniqueValues(DataTable table, string colName)
        {
            ArrayList al = new ArrayList();
            al.Add("all");
            foreach (DataRow dr in table.Rows)
            {
                string s = dr[colName].ToString();
                int loc = al.BinarySearch(s);
                if (loc < 0)
                {
                    al.Insert(-loc - 1, s);
                }
            }
            return al;
        }
        private DataSet GetACCDataSet()
        {
            OleDbConnection conn = null;
            DataSet ds = null;
            try
            {
                string fileName = @"ACC.csv";

                for (int n = 0; n < 10; n++)
                {
                    if (File.Exists(fileName))
                    {
                        break;
                    }
                    fileName = @"..\" + fileName;
                }

                string dir = Path.GetDirectoryName(fileName);

                string connString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + dir + ";Extended Properties=Text;";
                conn = new OleDbConnection(connString);
                conn.Open();
                string select = "SELECT * FROM ACC.csv";
                OleDbDataAdapter adapt = new OleDbDataAdapter(select, conn);
                ds = new DataSet();
                adapt.Fill(ds, "ACCStats");
                conn.Close();
            }
            catch (Exception ex)
            {
                if (conn != null && conn.State == ConnectionState.Open)
                {
                    conn.Close();
                    MessageBox.Show(ex.ToString());
                }
                return null;
            }

            return ds;
        }
        #endregion

        #region Cell activatingEvents
        private void TableControl_CurrentCellActivated(object sender, EventArgs e)
        {
            GridControlBase grid = sender as GridControlBase;
            if (grid != null)
                grid.CurrentCell.ScrollInView();
        }

        private void gridDataBoundGrid1_CurrentCellActivated(object sender, EventArgs e)
        {
            GridControlBase grid = sender as GridControlBase;
            if (grid != null)
                grid.CurrentCell.ScrollInView();
        }
        #endregion

        #region Grid Settings
        /// <summary>
        /// Grid Settings for better Look and Feel
        /// </summary>
        private void GridSettings()
        {
            //Setting SelectionMode in grid
            this.gridDataBoundGrid1.Model.Options.ListBoxSelectionMode = SelectionMode.MultiExtended;

            //Setting the GridDataBoundGrid's Column HeaderText
            this.gridDataBoundGrid1.Binder.InternalColumns[2].HeaderText = "Wins";
            this.gridDataBoundGrid1.Binder.InternalColumns[3].HeaderText = "Losses";
            this.gridDataBoundGrid1.Binder.InternalColumns[4].HeaderText = "Ties";
            this.gridDataBoundGrid1.Binder.InternalColumns[5].HeaderText = "Year";

            //Setting the GridGroupingControl's Column HeaderText
            this.gridGroupingControl1.TableDescriptor.Columns[2].HeaderText = "Wins";
            this.gridGroupingControl1.TableDescriptor.Columns[3].HeaderText = "Losses";
            this.gridGroupingControl1.TableDescriptor.Columns[4].HeaderText = "Ties";
            this.gridGroupingControl1.TableDescriptor.Columns[5].HeaderText = "Year";
			this.gridGroupingControl1.TableControl.DpiAware = true;

            this.gridGroupingControl1.TableControl.CurrentCellActivated += new EventHandler(TableControl_CurrentCellActivated);
            this.gridDataBoundGrid1.CurrentCellActivated += new EventHandler(gridDataBoundGrid1_CurrentCellActivated);
            this.gridGroupingControl1.ShowGroupDropArea = true;
            this.gridDataBoundGrid1.AllowProportionalColumnSizing = true;
            this.gridGroupingControl1.AllowProportionalColumnSizing = true;
            this.gridGroupingControl1.TopLevelGroupOptions.ShowAddNewRecordBeforeDetails = false;
            this.gridGroupingControl1.TopLevelGroupOptions.ShowCaption = false;
            this.gridGroupingControl1.ThemesEnabled = true;
            this.gridDataBoundGrid1.ThemesEnabled = true;
            this.gridDataBoundGrid1.GridVisualStyles = GridVisualStyles.Metro;
            this.gridDataBoundGrid1.GridOfficeScrollBars = OfficeScrollBars.Metro;
            this.gridGroupingControl1.GridOfficeScrollBars = OfficeScrollBars.Metro;
            this.gridGroupingControl1.GridVisualStyles = GridVisualStyles.Metro;
        }
        #endregion
    }
}

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

namespace ExcelLikeFreezePanes
{
    /// <summary>
    /// Summary description for Form1.
    /// </summary>
    public class Form1 : GridDemoForm
    {
        #region Private Members

        private Syncfusion.Windows.Forms.Grid.GridControl gridControl1;
        private Syncfusion.Windows.Forms.ButtonAdv button1;
        private ButtonAdv button2;
        private ButtonAdv button4;
        private ButtonAdv button3;
        private GroupBox groupBox1;
        private IContainer components;

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
            this.gridControl1.HorizontalThumbTrack = true;
            this.gridControl1.VerticalThumbTrack = true;
            this.gridControl1.HScrollPixel = true;
            this.gridControl1.ThemesEnabled = true;
            this.gridControl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gridControl1.ColCount = 100;
            this.gridControl1.RowCount = 1000;

            this.gridControl1.LeftColIndex = 2;

            this.gridControl1.BackColor = System.Drawing.Color.White;
            Random rnd = new Random();

            for (int c = 1; c <= this.gridControl1.ColCount; c++)
            {
                for (int r = 1; r <= this.gridControl1.RowCount; r++)
                {
                    int v = rnd.Next(100);
                    if (v > 80)
                    {
                        GridStyleInfo style = new GridStyleInfo();
                        style.CellValue = v;
                        style.BackColor = this.colors[v % colors.Length];

                        this.gridControl1.SetCellInfo(r, c, style, Syncfusion.Styles.StyleModifyType.Copy, false, true);
                    }
                }
            }
            this.gridControl1.GridVisualStyles = GridVisualStyles.Metro;

            //tab key navigation set as false to move the next control
            this.gridControl1.WantTabKey = false;
        }

        #endregion

        #region "Sample Customizations"

        bool frozen = false;
        int frozenTopRow = 0;
        int frozenLeftCol = 0;

        /// <summary>
        /// Grouping sample Customizations 
        /// </summary>
        private void SampleCustomization()
        {
            //Set ExcelLikeCurrentCell 
            this.gridControl1.ExcelLikeCurrentCell = true;

            //Enable ExcelLikeSelectionFrame
            this.gridControl1.ExcelLikeSelectionFrame = true;

            //Hook-Up PrepareViewStyleInfo Event 
            this.gridControl1.PrepareViewStyleInfo += new GridPrepareViewStyleInfoEventHandler(gridControl1_PrepareViewStyleInfo);
        }

        #region PrepareViewStyleInfo Event

        /// <summary>
        /// Prepare Style for For Frozen Columns and Rows
        /// </summary>
        private void gridControl1_PrepareViewStyleInfo(object sender, GridPrepareViewStyleInfoEventArgs e)
        {
            if (e.RowIndex > 0 && e.ColIndex > 0)
            {
                Color c = Color.FromArgb(192, 201, 219);

                if (e.RowIndex == this.gridControl1.Rows.FrozenCount)
                    e.Style.Borders.Bottom = new GridBorder(GridBorderStyle.Solid, c, GridBorderWeight.Medium);

                if (e.ColIndex == this.gridControl1.Cols.FrozenCount)
                    e.Style.Borders.Right = new GridBorder(GridBorderStyle.Solid, c, GridBorderWeight.Medium);
            }
        }

        #endregion

        #region Event Handlers

        /// <summary>
        /// Freeze Current Row/Columns
        /// </summary>
        private void button1_Click(object sender, System.EventArgs e)
        {
            frozen = !frozen;

            if (frozen)
            {
                int row, col;
                row = this.gridControl1.CurrentCell.RowIndex;
                col = this.gridControl1.CurrentCell.ColIndex;

                //Retrive the TopRowIndex & LeftColIndex of the current view
                frozenTopRow = this.gridControl1.TopRowIndex;
                frozenLeftCol = this.gridControl1.LeftColIndex;

                //Hide those rows and columns(except headers) which precede Top Row and Left Column
                this.gridControl1.RowHeights.SetRange(this.gridControl1.Rows.HeaderCount + 1, frozenTopRow - 1, 0);
                this.gridControl1.ColWidths.SetRange(this.gridControl1.Cols.HeaderCount + 1, frozenLeftCol - 1, 0);

                //Freeze the rows and columns with respect to current cell
                this.gridControl1.Model.Rows.FrozenCount = row;
                this.gridControl1.Model.Cols.FrozenCount = col;

                this.gridControl1.Focus();

                this.button1.Text = this.button1.Text.Replace("Freeze", "Unfreeze");
            }
            else
            {
                //Release the frozen & Hidden Rows and Columns
                this.gridControl1.BeginUpdate();

                this.gridControl1.Model.Rows.FrozenCount = this.gridControl1.Rows.HeaderCount;
                this.gridControl1.Model.Cols.FrozenCount = this.gridControl1.Cols.HeaderCount;

                this.gridControl1.RowHeights.ResetRange(this.gridControl1.Rows.HeaderCount + 1, frozenTopRow - 1);
                this.gridControl1.ColWidths.ResetRange(this.gridControl1.Cols.HeaderCount + 1, frozenLeftCol - 1);

                this.gridControl1.InternalSetTopRow(frozenTopRow);
                this.gridControl1.InternalSetLeftCol(frozenLeftCol);

                this.gridControl1.EndUpdate(false);
                this.gridControl1.Refresh();
                this.gridControl1.Focus();
                this.button1.Text = this.button1.Text.Replace("Unfreeze", "Freeze");

            }
        }
        Color[] colors = new Color[] {
										 
										 Color.FromArgb( 0x85, 0xbf, 0x75 ),										 
										 Color.FromArgb( 0xb4, 0xe7, 0xf2 ),
										 Color.FromArgb( 0xff, 0xbf, 0x34 ),
                                         Color.LightGray,
										 Color.FromArgb( 0x3a, 0x86, 0x7e ),
		};



        /// <summary>
        /// Freeze Selected Rows and Columns
        /// </summary>
        private void button2_Click(object sender, EventArgs e)
        {
            if (this.gridControl1.Selections.Count == 0)
                MessageBox.Show("Select rows/columns to freeze", "Error");
            else
            {
                this.gridControl1.BeginUpdate();
                //Freezes the selected columns (Moves them to the start of the grid and sets FrozenCount)
                this.gridControl1.Cols.FreezeSelection();

                //Freezes the selected columns (Moves them to the start of the grid and sets FrozenCount)
                this.gridControl1.Rows.FreezeSelection();
                this.gridControl1.EndUpdate();
            }
        }

        /// <summary>
        /// Freeze Range of cells
        /// </summary>
        private void button3_Click(object sender, EventArgs e)
        {
            this.gridControl1.BeginUpdate();
            //Freeze the specified range of rows
            this.gridControl1.Rows.FreezeRange(2, 5);
            this.gridControl1.EndUpdate();
        }

        /// <summary>
        /// Reset All 
        /// </summary>
        private void button4_Click(object sender, EventArgs e)
        {
            //Reset the grid
            this.gridControl1.BeginUpdate();
            this.gridControl1.ColCount = 100;
            this.gridControl1.RowCount = 1000;

            this.gridControl1.Rows.FrozenCount = 0;
            this.gridControl1.Cols.FrozenCount = 0;

            this.gridControl1.Rows.HeaderCount = 0;
            this.gridControl1.Cols.HeaderCount = 0;
            this.gridControl1.EndUpdate();
        }
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
                this.gridControl1.PrepareViewStyleInfo -= new GridPrepareViewStyleInfoEventHandler(gridControl1_PrepareViewStyleInfo);

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
            this.components = new System.ComponentModel.Container();
            this.gridControl1 = new Syncfusion.Windows.Forms.Grid.GridControl();
            this.button1 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.button2 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.button4 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.button3 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DpiAware = true;
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.Location = new System.Drawing.Point(12, 1);
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RowCount = 200;
            this.gridControl1.Size = new System.Drawing.Size(572, 376);
            this.gridControl1.SmartSizeBox = false;
            this.gridControl1.TabIndex = 0;
            this.gridControl1.Text = "gridControl1";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.button1.FlatStyle = FlatStyle.Flat;
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.button1.BeforeTouchSize = new System.Drawing.Size(148, 29);
            this.button1.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.RaisedInner;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.IsBackStageButton = false;
            this.button1.Location = new System.Drawing.Point(20, 192);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(156, 29);
            this.button1.TabIndex = 7;
            this.button1.Text = "&Freeze Current Row/Col";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.button2.FlatStyle = FlatStyle.Flat;
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.button2.BeforeTouchSize = new System.Drawing.Size(148, 30);
            this.button2.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.RaisedInner;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.IsBackStageButton = false;
            this.button2.Location = new System.Drawing.Point(20, 48);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(156, 30);
            this.button2.TabIndex = 3;
            this.button2.Text = "Freeze Row, Column";
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button4
            // 
            this.button4.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.button4.FlatStyle = FlatStyle.Flat;
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.button4.BeforeTouchSize = new System.Drawing.Size(148, 28);
            this.button4.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.RaisedInner;
            this.button4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.IsBackStageButton = false;
            this.button4.Location = new System.Drawing.Point(20, 145);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(156, 28);
            this.button4.TabIndex = 6;
            this.button4.Text = "Reset All";
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.button3.FlatStyle = FlatStyle.Flat;
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.button3.BeforeTouchSize = new System.Drawing.Size(148, 29);
            this.button3.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.RaisedInner;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.IsBackStageButton = false;
            this.button3.Location = new System.Drawing.Point(20, 96);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(156, 29);
            this.button3.TabIndex = 5;
            this.button3.Text = "Freeze Range";
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Dock = DockStyle.Right;
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Location = new System.Drawing.Point(603, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(190, 376);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Freeze Options";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 403);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gridControl1);
            this.MinimumSize = new System.Drawing.Size(600, 350);
            this.Name = "Form1";
            this.Text = "Freeze Pane";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
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

    }
}

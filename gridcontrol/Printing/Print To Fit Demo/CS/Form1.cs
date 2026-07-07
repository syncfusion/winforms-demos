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

namespace PrintAsBitmap
{

    using System;
    using System.Drawing;
    using System.Collections;
    using System.ComponentModel;
    using System.Windows.Forms;
    using System.Data;

    using Syncfusion.Windows.Forms.Grid;
    using Syncfusion.Windows.Forms;
    using DemoCommon.Grid;

    public class Form1 : GridDemoForm
    {
        #region "API Definition
        private Syncfusion.Windows.Forms.Grid.GridControl gridControl1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Syncfusion.Windows.Forms.ButtonAdv button1;
        private Syncfusion.Windows.Forms.ButtonAdv button2;
        private Syncfusion.Windows.Forms.ButtonAdv button3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private Syncfusion.Windows.Forms.ButtonAdv button4;
        private System.Windows.Forms.Panel panel1;
        private GroupBox groupBox2;
        private IContainer components;
        #endregion

        #region "Constructor"
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
            //
            // TODO: Add any constructor code after InitializeComponent call
            //
        }
        #endregion

        #region "Sample Grid Settings"

        /// <summary>
        /// Setting Grid control Properties
        /// </summary>
        private void GridSettings()
        {
            PopulateGridWithInts(30, 10);
            this.gridControl1.DefaultRowHeight = (int)DpiAware.LogicalToDeviceUnits(22.0f);
            this.gridControl1.DefaultColWidth = (int)DpiAware.LogicalToDeviceUnits(70.0f);
            this.gridControl1.GridVisualStyles = GridVisualStyles.Metro;
            this.gridControl1.DefaultGridBorderStyle = GridBorderStyle.Solid;
            this.gridControl1.Properties.GridLineColor = Color.FromArgb(208, 215, 229);
            GridStyleInfo style = gridControl1.BaseStylesMap["Header"].StyleInfo;
            style.Font.Facename = "Segoe UI";
            this.BackColor = Color.White;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.gridControl1.ThemesEnabled = true;

            //tab key navigation set as false to move the next control
            this.gridControl1.WantTabKey = false;
        }

        #endregion

        #region "Sample Customizations"

        /// <summary>
        /// PrintAsBitmap sample Customizations 
        /// </summary>
        private void SampleCustomization()
        {

        }
        #region Event handlers

        #region ShowBitMap
        /// <summary>
        /// Show the content as a bitmap image
        /// </summary>
        private void button1_Click(object sender, System.EventArgs e)
        {
            //draw a fullsize bitmap of the grid...
            int gridHeight = this.gridControl1.RowHeights.GetTotal(0, this.gridControl1.RowCount);
            int gridWidth = this.gridControl1.ColWidths.GetTotal(0, this.gridControl1.ColCount);

            Bitmap gridBM = new Bitmap(gridWidth, gridHeight);

            Graphics g = Graphics.FromImage(gridBM);

            this.gridControl1.GridBounds = new Rectangle(0, 0, gridWidth, gridHeight);
            this.gridControl1.DrawGrid(g);
            this.gridControl1.ResetGridBounds();

            g.Dispose();

            //create a bitmap the the proper target size
            Bitmap picBM = new Bitmap(this.pictureBox1.Size.Width, this.pictureBox1.Size.Height);

            //draw grid bitmap into the new bitmap...
            System.Drawing.GraphicsUnit gu = System.Drawing.GraphicsUnit.Point;
            g = Graphics.FromImage(picBM);
            RectangleF srcRect = gridBM.GetBounds(ref gu);
            Rectangle destRect = new Rectangle(0, 0, picBM.Width, picBM.Height);


            g.DrawImage(gridBM, destRect, srcRect, gu);
            g.Dispose();

            //show the new bitmap
            this.pictureBox1.Image = picBM;

        }
        #endregion

        #region PrintPreviewToFit
        /// <summary>
        /// show the PrintPrevie dialog 
        /// </summary>
        private void button2_Click(object sender, System.EventArgs e)
        {
            if (this.gridControl1 != null)
            {
                try
                {
                    //uses the default printer
                    GridPrintToFitDocument pd = new GridPrintToFitDocument(this.gridControl1, true);
                    PrintPreviewDialog dlg = new PrintPreviewDialog();
                    dlg.Document = pd;
                    dlg.ShowDialog();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred attempting to preview the grid - " + ex.Message);
                }
            }

        }
        #endregion

        #region PrintToFit
        /// <summary>
        /// Print the Gird with fit to the size
        /// </summary>
        private void button3_Click(object sender, System.EventArgs e)
        {
            if (this.gridControl1 != null)
            {
                try
                {
                    GridPrintToFitDocument pd = new GridPrintToFitDocument(this.gridControl1, true);
                    PrintDialog dlg = new PrintDialog();
                    dlg.Document = pd;
                    if (dlg.ShowDialog() == DialogResult.OK)
                        pd.Print();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred attempting to print the grid - " + ex.Message);
                }
            }

        }
        #endregion

        #region Apply
        /// <summary>
        /// Populate the grid with the enterd row col count values
        /// </summary>
        private void button4_Click(object sender, System.EventArgs e)
        {
            PopulateGridWithInts((int)this.numericUpDown1.Value, (int)this.numericUpDown2.Value);
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

        #region Windows Generated Designer Code
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo2 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            this.gridControl1 = new Syncfusion.Windows.Forms.Grid.GridControl();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.button2 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.button3 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button4 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DpiAware = true;
            this.gridControl1.AllowDrop = true;
            this.gridControl1.AlphaBlendSelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(94)))), ((int)(((byte)(171)))), ((int)(((byte)(222)))));
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gridControl1.ColCount = 7;
            this.gridControl1.DefaultGridBorderStyle = Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid;
            this.gridControl1.Font = new System.Drawing.Font("Segoe UI", 9F);
            gridCellInfo2.Col = -1;
            gridCellInfo2.Row = -1;
            gridCellInfo2.StyleInfo.Borders.Bottom = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234))))), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin);
            gridCellInfo2.StyleInfo.Borders.Right = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234))))), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin);
            gridCellInfo2.StyleInfo.Font.Bold = false;
            gridCellInfo2.StyleInfo.Font.Facename = "Segoe UI";
            gridCellInfo2.StyleInfo.Font.Italic = false;
            gridCellInfo2.StyleInfo.Font.Size = 9F;
            gridCellInfo2.StyleInfo.Font.Strikeout = false;
            gridCellInfo2.StyleInfo.Font.Underline = false;
            gridCellInfo2.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point;
            gridCellInfo2.StyleInfo.Interior = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.White);
            gridCellInfo2.StyleInfo.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gridControl1.GridCells.AddRange(new Syncfusion.Windows.Forms.Grid.GridCellInfo[] {
            gridCellInfo2});
            //this.gridControl1.GridOfficeScrollBars = Syncfusion.Windows.Forms.OfficeScrollBars.Metro;
            //this.gridControl1.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro;
            this.gridControl1.DefaultRowHeight = (int)DpiAware.LogicalToDeviceUnits(20.0f);
            this.gridControl1.DefaultColWidth = (int)DpiAware.LogicalToDeviceUnits(70.0f);
            this.gridControl1.Location = new System.Drawing.Point(12, 0);
            //this.gridControl1.MetroScrollBars = true;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Properties.ForceImmediateRepaint = false;
            this.gridControl1.Properties.GridLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.gridControl1.Properties.MarkColHeader = false;
            this.gridControl1.Properties.MarkRowHeader = false;
            this.gridControl1.RowCount = 16;
            this.gridControl1.RowHeightEntries.AddRange(new Syncfusion.Windows.Forms.Grid.GridRowHeight[] {
            new Syncfusion.Windows.Forms.Grid.GridRowHeight(0, 29)});
            this.gridControl1.Size = new System.Drawing.Size(460, 630);
            this.gridControl1.SmartSizeBox = false;
            this.gridControl1.TabIndex = 0;
            this.gridControl1.Text = "gridControl1";
            this.gridControl1.ThemesEnabled = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(647, 3);
            this.pictureBox1.Name = "pictureBox1";
#if NETCORE
            this.pictureBox1.Size = new System.Drawing.Size(357, 627);
#else
            this.pictureBox1.Size = new System.Drawing.Size(362, 627);
#endif
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.button1.FlatStyle = FlatStyle.Flat;
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.button1.BeforeTouchSize = new System.Drawing.Size(134, 28);
            this.button1.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.RaisedInner;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.IsBackStageButton = false;
            this.button1.Location = new System.Drawing.Point(16, 32);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 28);
            this.button1.TabIndex = 6;
            this.button1.Text = "Show Bitmap";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.button2.FlatStyle = FlatStyle.Flat;
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.button2.BeforeTouchSize = new System.Drawing.Size(134, 29);
            this.button2.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.RaisedInner;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.IsBackStageButton = false;
            this.button2.Location = new System.Drawing.Point(16, 80);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(134, 29);
            this.button2.TabIndex = 7;
            this.button2.Text = "PrintPreviewToFit";
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.button3.FlatStyle = FlatStyle.Flat;
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.button3.BeforeTouchSize = new System.Drawing.Size(134, 29);
            this.button3.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.RaisedInner;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.IsBackStageButton = false;
            this.button3.Location = new System.Drawing.Point(16, 127);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(134, 29);
            this.button3.TabIndex = 8;
            this.button3.Text = "PrintToFit";
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.numericUpDown2);
            this.groupBox1.Controls.Add(this.numericUpDown1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(478, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(163, 196);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Change Content";
            // 
            // button4
            // 
            this.button4.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.button4.FlatStyle = FlatStyle.Flat;
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.button4.BeforeTouchSize = new System.Drawing.Size(134, 28);
            this.button4.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.RaisedInner;
            this.button4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.IsBackStageButton = false;
            this.button4.Location = new System.Drawing.Point(15, 128);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(134, 28);
            this.button4.TabIndex = 4;
            this.button4.Text = "Apply";
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDown2.Location = new System.Drawing.Point(92, 83);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDown2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(57, 23);
            this.numericUpDown2.TabIndex = 3;
            this.numericUpDown2.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDown1.Location = new System.Drawing.Point(92, 38);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            80,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(57, 23);
            this.numericUpDown1.TabIndex = 2;
            this.numericUpDown1.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cols:";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rows:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.Dock = DockStyle.Fill;
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.gridControl1);
            this.panel1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1012, 652);
            this.panel1.TabIndex = 6;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Location = new System.Drawing.Point(478, 224);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(163, 406);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Printing Options";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 656);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "Form1";
            this.Text = "Print To Fit ";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        #endregion

        [STAThread]
        public static void Main()
        {
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense(Syncfusion.Licensing.DemoCommon.FindLicenseKey());
# if SyncfusionFramework1_1 || SyncfusionFramework2_0
            Application.EnableVisualStyles();
# endif
            Application.Run(new Form1());
        }


        #endregion

        #region PopulateGridWithInts
        /// <summary>
        /// Populate the grid with the number of row and col counts
        /// </summary>
        /// <param name="rowCount"></param>
        /// <param name="colCount"></param>
        private void PopulateGridWithInts(int rowCount, int colCount)
        {
            this.gridControl1.ResetVolatileData();
            this.gridControl1.ViewLayout.Reset();

            this.gridControl1.RowCount = rowCount;
            this.gridControl1.ColCount = colCount;

            this.gridControl1.BeginUpdate();

            Random r = new Random();

            for (int i = 1; i <= this.gridControl1.RowCount; ++i)
                for (int j = 1; j <= this.gridControl1.ColCount; ++j)
                    this.gridControl1[i, j].CellValue = r.Next(1000);

            this.gridControl1.EndUpdate();
            this.gridControl1.Refresh();
            this.gridControl1.UpdateScrollBars();

        }
        #endregion


    }

    #region "Derived Class"
    public class GridPrintToFitDocument : GridPrintDocument
    {
        private GridControlBase _grid;

        public GridPrintToFitDocument(GridControlBase grid, bool printPreview)
            : base(grid, printPreview)
        {
            _grid = grid;
        }

        protected override void OnPrintPage(System.Drawing.Printing.PrintPageEventArgs ev)
        {

            ev.HasMorePages = false;

            //draw a fullsize bitmap of the grid...
            int gridHeight = _grid.Model.RowHeights.GetTotal(0, _grid.Model.RowCount);
            int gridWidth = _grid.Model.ColWidths.GetTotal(0, _grid.Model.ColCount);

            Bitmap gridBM = new Bitmap(gridWidth, gridHeight);

            Graphics g = Graphics.FromImage(gridBM);

            this._grid.GridBounds = new Rectangle(0, 0, gridWidth, gridHeight);
            this._grid.DrawGrid(g);
            this._grid.ResetGridBounds();

            g.Dispose();

            Rectangle destRect = ev.MarginBounds;


            //use the printer graphics
            g = ev.Graphics;

            //draw grid bitmap into the rect on the print page
            System.Drawing.GraphicsUnit gu = System.Drawing.GraphicsUnit.Point;
            RectangleF srcRect = gridBM.GetBounds(ref gu);


            //adjust destRect to make sizing proportional
            // you can comment this out this block if you don't want proportional fit
            float srcRatio = srcRect.Width / srcRect.Height;
            float tarRatio = (float)destRect.Width / destRect.Height;
            if (tarRatio < srcRatio)
            {
                destRect.Height = (int)(destRect.Width / srcRatio);
            }
            else
            {
                destRect.Width = (int)(destRect.Height * srcRatio);
            }
            //////////////endof proportional fit//////////////////////////

            g.DrawImage(gridBM, destRect, srcRect, gu);

        }

    }
    #endregion

}

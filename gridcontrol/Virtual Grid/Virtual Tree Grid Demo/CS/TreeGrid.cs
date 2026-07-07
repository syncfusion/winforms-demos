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

namespace CustomGridCell
{
    using System;
    using System.Drawing;
    using System.Collections;
    using System.ComponentModel;
    using System.Windows.Forms;
    using System.Data;
    using Syncfusion.Windows.Forms.Grid;
    using Syncfusion.Windows.Forms;
    using System.Runtime.Serialization;
    using System.Runtime.Serialization.Formatters.Binary;
    using System.IO;
    using DemoCommon.Grid;

    /// <summary>
    /// Summary description for Form1.
    /// </summary>
    public class TreeGridForm : GridDemoForm
    {
        #region API Definition
        private Syncfusion.Windows.Forms.Grid.GridControl gridControl1;
        private System.Windows.Forms.ImageList imageList1;
        private System.ComponentModel.IContainer components;

        static public int NoChildBMP;
        static public int OpenedBMP;
        static public int ClosedBMP;
        private Syncfusion.Windows.Forms.ButtonAdv button1;
        private Syncfusion.Windows.Forms.ButtonAdv button2;
        private Syncfusion.Windows.Forms.ButtonAdv button3;
        private Syncfusion.Windows.Forms.ButtonAdv button4;
        private Syncfusion.Windows.Forms.ButtonAdv button5;
        private System.Windows.Forms.Panel panel1;
        private Label label1;
        private GroupBox groupBox2;
        private GroupBox groupBox1;


        //sample data members...
        public static CollapsibleDataSource externalData;
        #endregion

        #region Constructor
        public TreeGridForm()
        {
            NoChildBMP = 2;
            OpenedBMP = 0;
            ClosedBMP = 1;            
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();
            if (DpiAware.GetCurrentDpi() > 96)
            {
                this.CaptionBarHeight = (int)DpiAware.LogicalToDeviceUnits(this.CaptionBarHeight);
            }
            SampleCustomization();
            GridSettings();        
            
        }
        #endregion

        #region Reading the Data
        /// <summary>
        /// Reading the Data file
        /// </summary>
        /// <param name="cdsFileName">data file</param>        
        string FindFullPath(string cdsFileName)
        {
            // Check both in parent folder and Parent\Data folders.
            string cdsDataFileName = @"Data\" + cdsFileName;
            for (int n = 0; n < 10; n++)
            {
                if (System.IO.File.Exists(cdsFileName))
                {
                    return Path.GetFullPath(cdsFileName);
                }
                if (System.IO.File.Exists(cdsDataFileName))
                {
                    return Path.GetFullPath(cdsDataFileName);
                }
                cdsFileName = @"..\" + cdsFileName;
                cdsDataFileName = @"..\" + cdsDataFileName;
            }

            return "";
        }        

        
        #endregion

        #region Designer Stuffs
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Syncfusion.Windows.Forms.Grid.GridBaseStyle gridBaseStyle21 = new Syncfusion.Windows.Forms.Grid.GridBaseStyle();
            Syncfusion.Windows.Forms.Grid.GridBaseStyle gridBaseStyle22 = new Syncfusion.Windows.Forms.Grid.GridBaseStyle();
            Syncfusion.Windows.Forms.Grid.GridBaseStyle gridBaseStyle23 = new Syncfusion.Windows.Forms.Grid.GridBaseStyle();
            Syncfusion.Windows.Forms.Grid.GridBaseStyle gridBaseStyle24 = new Syncfusion.Windows.Forms.Grid.GridBaseStyle();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo6 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            this.gridControl1 = new Syncfusion.Windows.Forms.Grid.GridControl();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.button1 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.button2 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.button3 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.button4 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.button5 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DpiAware = true;
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.BackColor = System.Drawing.Color.White;
            gridBaseStyle21.Name = "Header";
            gridBaseStyle21.StyleInfo.Borders.Bottom = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None);
            gridBaseStyle21.StyleInfo.Borders.Left = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None);
            gridBaseStyle21.StyleInfo.Borders.Right = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None);
            gridBaseStyle21.StyleInfo.Borders.Top = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None);
            gridBaseStyle21.StyleInfo.CellType = "Header";
            gridBaseStyle21.StyleInfo.Font.Bold = true;
            gridBaseStyle21.StyleInfo.Interior = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(199)))), ((int)(((byte)(184))))), System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(234)))), ((int)(((byte)(216))))));
            gridBaseStyle21.StyleInfo.VerticalAlignment = Syncfusion.Windows.Forms.Grid.GridVerticalAlignment.Middle;
            gridBaseStyle22.Name = "Standard";
            gridBaseStyle22.StyleInfo.Font.Facename = "Segoe UI";
            gridBaseStyle22.StyleInfo.Interior = new Syncfusion.Drawing.BrushInfo(System.Drawing.SystemColors.Window);
            gridBaseStyle23.Name = "Column Header";
            gridBaseStyle23.StyleInfo.BaseStyle = "Header";
            gridBaseStyle23.StyleInfo.HorizontalAlignment = Syncfusion.Windows.Forms.Grid.GridHorizontalAlignment.Center;
            gridBaseStyle24.Name = "Row Header";
            gridBaseStyle24.StyleInfo.BaseStyle = "Header";
            gridBaseStyle24.StyleInfo.HorizontalAlignment = Syncfusion.Windows.Forms.Grid.GridHorizontalAlignment.Left;
            gridBaseStyle24.StyleInfo.Interior = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Horizontal, System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(199)))), ((int)(((byte)(184))))), System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(234)))), ((int)(((byte)(216))))));
            this.gridControl1.BaseStylesMap.AddRange(new Syncfusion.Windows.Forms.Grid.GridBaseStyle[] {
            gridBaseStyle21,
            gridBaseStyle22,
            gridBaseStyle23,
            gridBaseStyle24});
            this.gridControl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gridControl1.ColWidthEntries.AddRange(new Syncfusion.Windows.Forms.Grid.GridColWidth[] {
            new Syncfusion.Windows.Forms.Grid.GridColWidth(0, 35)});
            this.gridControl1.DefaultGridBorderStyle = Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid;
            this.gridControl1.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.gridControl1.ForeColor = System.Drawing.Color.MidnightBlue;
            gridCellInfo6.Col = -1;
            gridCellInfo6.Row = -1;
            gridCellInfo6.StyleInfo.Borders.Bottom = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234))))), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin);
            gridCellInfo6.StyleInfo.Borders.Right = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234))))), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin);
            gridCellInfo6.StyleInfo.Font.Bold = false;
            gridCellInfo6.StyleInfo.Font.Facename = "Segoe UI";
            gridCellInfo6.StyleInfo.Font.Italic = false;
            gridCellInfo6.StyleInfo.Font.Size = 8.5F;
            gridCellInfo6.StyleInfo.Font.Strikeout = false;
            gridCellInfo6.StyleInfo.Font.Underline = false;
            gridCellInfo6.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point;
            gridCellInfo6.StyleInfo.Interior = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.White);
            gridCellInfo6.StyleInfo.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gridControl1.GridCells.AddRange(new Syncfusion.Windows.Forms.Grid.GridCellInfo[] {
            gridCellInfo6});
            this.gridControl1.GridOfficeScrollBars = Syncfusion.Windows.Forms.OfficeScrollBars.Metro;
            this.gridControl1.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro;
            this.gridControl1.DefaultRowHeight = (int)DpiAware.LogicalToDeviceUnits(25.0f);
            this.gridControl1.RowHeights[0] = (int)DpiAware.LogicalToDeviceUnits(30.0f);
            this.gridControl1.HorizontalThumbTrack = true;
            this.gridControl1.Location = new System.Drawing.Point(29, 29);
            this.gridControl1.MetroScrollBars = true;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Properties.BackgroundColor = System.Drawing.Color.White;
            this.gridControl1.Properties.GridLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.gridControl1.Properties.MarkColHeader = false;
            this.gridControl1.Properties.MarkRowHeader = false;
            this.gridControl1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.gridControl1.RowHeightEntries.AddRange(new Syncfusion.Windows.Forms.Grid.GridRowHeight[] {
            new Syncfusion.Windows.Forms.Grid.GridRowHeight(0, 21)});
            this.gridControl1.SerializeCellsBehavior = Syncfusion.Windows.Forms.Grid.GridSerializeCellsBehavior.SerializeIntoCode;
            this.gridControl1.Size = new System.Drawing.Size(500, 361);
            this.gridControl1.SmartSizeBox = false;
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ThemesEnabled = true;
            this.gridControl1.VerticalThumbTrack = true;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button1.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.button1.FlatStyle = FlatStyle.Flat;
            this.button1.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.RaisedInner;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(25, 31);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 26);
            this.button1.TabIndex = 1;
            this.button1.Text = "Load DataSource";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button2.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.button2.FlatStyle = FlatStyle.Flat;
            this.button2.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.RaisedInner;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(25, 78);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 26);
            this.button2.TabIndex = 2;
            this.button2.Text = "Save DataSource";
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.button3.FlatStyle = FlatStyle.Flat;
            this.button3.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.RaisedInner;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(25, 122);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(112, 26);
            this.button3.TabIndex = 3;
            this.button3.Text = "Reset";
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.button4.FlatStyle = FlatStyle.Flat;
            this.button4.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.RaisedInner;
            this.button4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(25, 34);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(112, 26);
            this.button4.TabIndex = 5;
            this.button4.Text = "Expand All";
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button5.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.button5.FlatStyle = FlatStyle.Flat;
            this.button5.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.RaisedInner;
            this.button5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(25, 79);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(112, 26);
            this.button5.TabIndex = 6;
            this.button5.Text = "Close All";
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.gridControl1);
            this.panel1.Location = new System.Drawing.Point(-6, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(721, 649);
            this.panel1.TabIndex = 7;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.button5);
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Location = new System.Drawing.Point(547, 231);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(160, 159);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Expand Options";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(547, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(160, 177);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Data Source";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(26, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(501, 26);
            this.label1.TabIndex = 4;
            this.label1.Text = "Right-Click node in Column A for Positive/Negative indent";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TreeGridForm
            //            
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 402);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(550, 400);
            this.Name = "TreeGridForm";
            this.Text = "Virtual Tree Grid";            
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense(Syncfusion.Licensing.DemoCommon.FindLicenseKey());
# if SyncfusionFramework1_1 || SyncfusionFramework2_0
            Application.EnableVisualStyles();
# endif
            Application.Run(new TreeGridForm());
        }
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

        #region Sample Customization
        /// <summary>
        /// Sample Customization for adding Tree Cell
        /// </summary>
        private void SampleCustomization()
        {
            #region load the bitmaps
            this.imageList1.ImageSize = new Size(20, 17);
            Bitmap bm = new Bitmap(GetType().Module.Assembly.GetManifestResourceStream("CustomGridCell.minus.bmp"));
            this.imageList1.Images.Add(bm, Color.White);
            bm = new Bitmap(GetType().Module.Assembly.GetManifestResourceStream("CustomGridCell.plus.bmp"));
            this.imageList1.Images.Add(bm, Color.White);
            bm = new Bitmap(GetType().Module.Assembly.GetManifestResourceStream("CustomGridCell.nochild.bmp"));
            this.imageList1.Images.Add(bm, Color.White);
            #endregion     

            //Add a custom cell control
            gridControl1.CellModels.Add("TreeCell", new TreeCellModel(gridControl1.Model));           
        }
        #endregion

        #region GridSettings
        /// <summary>
        /// Grid Settings for better look and feel. 
        /// </summary>
        private void GridSettings()
        {
            gridControl1.ControllerOptions = GridControllerOptions.All & (~GridControllerOptions.OleDataSource);

            //make the imagelist available thru the tablestyle
            gridControl1.TableStyle.ImageList = this.imageList1;

            //create a sample data for a virtual grid
            externalData = new CollapsibleDataSource(100);
            externalData.InitData(); //initializes an external datasource
            externalData.CollapseData(); // c

            //hook up the events needed for virtual grid
            gridControl1.ResetVolatileData();
            gridControl1.QueryCellInfo += new GridQueryCellInfoEventHandler(GridQueryCellInfo);
            gridControl1.QueryRowCount += new GridRowColCountEventHandler(GridQueryRowCount);
            gridControl1.QueryColCount += new GridRowColCountEventHandler(GridQueryColCount);
            gridControl1.QueryColWidth += new GridRowColSizeEventHandler(GridQueryColWidth);

            //handle saving data back to the data source...
            gridControl1.SaveCellInfo += new GridSaveCellInfoEventHandler(GridSaveCellInfo);

            //load a sample file...
            ReadData(FindFullPath("datasample.cds"));

            this.gridControl1.ColCount = 4;
            this.gridControl1.DefaultRowHeight = (int)DpiAware.LogicalToDeviceUnits(22.0f);
            this.gridControl1.DefaultColWidth = (int)DpiAware.LogicalToDeviceUnits(70.0f);
            this.gridControl1.RowHeights[0] = (int)DpiAware.LogicalToDeviceUnits(30.0f);
            this.gridControl1.DefaultGridBorderStyle = GridBorderStyle.Solid;

            //tab key navigation set as false to move the next control
            this.gridControl1.WantTabKey = false;
        }
        #endregion

        #region Event Handlers

        #region Grid Events
        void GridSaveCellInfo(object sender, GridSaveCellInfoEventArgs e)
        {
            try
            {
                //move the changes back to the external data object
                if (e.ColIndex == 1 && e.RowIndex > 0)
                {

                    externalData[e.RowIndex - 1].ExpandState = (int)e.Style.ImageIndex;
                    externalData[e.RowIndex - 1].IndentLevel = (int)e.Style.Tag;
                }

                if (e.ColIndex > 0 && e.RowIndex > 0)
                {
                    externalData[e.RowIndex - 1].Items[e.ColIndex - 1] = (string)e.Style.CellValue;

                }
            }
            catch { }

            //refresh this row so change is displayed
            if (!externalData.Locked)
            {
                externalData.CollapseData();
                this.gridControl1.Refresh();
            }
            e.Handled = true;
        }

        void GridQueryColWidth(object sender, GridRowColSizeEventArgs e)
        {
            if (e.Index == 1)
                e.Size = (int)DpiAware.LogicalToDeviceUnits(200);
            else if (e.Index > 0)
                e.Size = (int)DpiAware.LogicalToDeviceUnits(100);
            else
                e.Size = 0;//hide the header // 30;

            e.Handled = true;
        }
        void GridQueryRowCount(object sender, GridRowColCountEventArgs e)
        {
            e.Count = externalData.RowCount;
            e.Handled = true;
        }

        void GridQueryColCount(object sender, GridRowColCountEventArgs e)
        {
            e.Count = externalData.ColCount;
            e.Handled = true;
        }

        void GridQueryCellInfo(object sender, GridQueryCellInfoEventArgs e)
        {
            if (e.RowIndex > 0 && e.ColIndex > 0)
            {
                e.Style.CellValue = externalData[e.RowIndex - 1].Items[e.ColIndex - 1];
                if (e.ColIndex == 1)
                {
                    e.Style.CellType = "TreeCell";
                    e.Style.Tag = externalData[e.RowIndex - 1].IndentLevel;
                    e.Style.ImageIndex = (int)externalData[e.RowIndex - 1].ExpandState;
                }
                e.Handled = true;
            }
        }
        #endregion

        #region Helper Method
        private void ReadData(string fileName)
        {
            try
            {
                IFormatter formatter = new BinaryFormatter();
                Stream stream = new FileStream(fileName, FileMode.Open, FileAccess.Read, FileShare.Read);
                externalData = (CollapsibleDataSource)formatter.Deserialize(stream);
                stream.Close();

                gridControl1.ResetVolatileData();
                externalData.CollapseData();
                this.gridControl1.Refresh();
            }
            catch { }
        }
        #endregion

        #region Button click events

        private void button1_Click(object sender, System.EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.Filter = "Collapsible Data Files|*.cds";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.InitialDirectory = Application.ExecutablePath;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                ReadData(openFileDialog1.FileName);
            }
        }

        private void button2_Click(object sender, System.EventArgs e)
        {
            // Create a SaveFileDialog 
            SaveFileDialog saveFile1 = new SaveFileDialog();
            saveFile1.DefaultExt = "*.cds";
            saveFile1.Filter = "Collapsible Data Files|*.cds";
            saveFile1.FileName = "Untitled";
            saveFile1.InitialDirectory = Application.ExecutablePath;

            // get a file name from the user
            if (saveFile1.ShowDialog() == DialogResult.OK)
            {
                IFormatter formatter = new BinaryFormatter();
                Stream stream = new FileStream(saveFile1.FileName, FileMode.Create, FileAccess.Write, FileShare.None);
                formatter.Serialize(stream, externalData);
                stream.Close();
            }
        }

        private void button3_Click(object sender, System.EventArgs e)
        {
            gridControl1.ResetVolatileData();
            externalData.InitData();
            externalData.CollapseData();
            this.gridControl1.Refresh();
        }

        private void button4_Click(object sender, System.EventArgs e)
        {
            gridControl1.ResetVolatileData();
            externalData.ExpandAll();
            externalData.CollapseData();
            gridControl1.UpdateScrollBars();
            this.gridControl1.Invalidate();
        }

        private void button5_Click(object sender, System.EventArgs e)
        {
            gridControl1.ResetVolatileData();
            externalData.CloseAll();
            externalData.CollapseData();
            gridControl1.CurrentCell.MoveTo(1, 1);
            gridControl1.UpdateScrollBars();
            this.gridControl1.Invalidate();
        }
        #endregion

        #endregion
    }
}

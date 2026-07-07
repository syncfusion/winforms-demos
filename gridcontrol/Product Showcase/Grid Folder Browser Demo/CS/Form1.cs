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


namespace FolderBrowser
{
	using System;
	using System.Drawing;
	using System.Collections;
	using System.ComponentModel;
	using System.Windows.Forms;
	using System.Data;
	using Syncfusion.Windows.Forms.Grid;
	using System.Runtime.Serialization;
	using System.Runtime.Serialization.Formatters.Binary;
	using System.IO;
    using DemoCommon.Grid;
    using Syncfusion.Windows.Forms;

	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class TreeGridForm : GridDemoForm
    {
        #region "API Definition"
        private Syncfusion.Windows.Forms.Grid.GridControl gridControl1;
		private System.Windows.Forms.ImageList imageList1;
		private System.ComponentModel.IContainer components;

		static public int NoChildBMP;
		static public int OpenedBMP;
		static public int ClosedBMP;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel1;
		private Syncfusion.Windows.Forms.Tools.ComboBoxAdv comboBox1;
        private Syncfusion.Windows.Forms.Tools.CheckBoxAdv checkBox1;

		//sample data members...
		public static CollapsibleDataSource externalData;
        #endregion

        #region "Constructor"
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

            SampleData();

            GridSettings();
            
		}
        #endregion

        #region "Image Loading Methods"
        //Get and Load the images
#if NET9_0_OR_GREATER
        private Image GetImage(string path)
        {
            System.Reflection.Assembly asm = System.Reflection.Assembly.GetExecutingAssembly();
            if (asm != null && !string.IsNullOrEmpty(path))
                return Image.FromStream(asm.GetManifestResourceStream(path));
            return null;
        }

        private void LoadImages(ImageList imageList, string folder, int count)
        {
            for (int i = 1; i <= count; i++)
            {
                string imagePath = ($"FolderBrowserSample.Images.{folder}.Image_{i}.png");
                imageList.Images.Add(GetImage(imagePath));
            }
        }
#endif
        #endregion


        #region Designer Stuffs
       
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
            this.components = new System.ComponentModel.Container();
            Syncfusion.Windows.Forms.Grid.GridBaseStyle gridBaseStyle1 = new Syncfusion.Windows.Forms.Grid.GridBaseStyle();
            Syncfusion.Windows.Forms.Grid.GridBaseStyle gridBaseStyle2 = new Syncfusion.Windows.Forms.Grid.GridBaseStyle();
            Syncfusion.Windows.Forms.Grid.GridBaseStyle gridBaseStyle3 = new Syncfusion.Windows.Forms.Grid.GridBaseStyle();
            Syncfusion.Windows.Forms.Grid.GridBaseStyle gridBaseStyle4 = new Syncfusion.Windows.Forms.Grid.GridBaseStyle();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo1 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo2 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo3 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo4 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo5 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo6 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo7 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo8 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo9 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TreeGridForm));
            this.gridControl1 = new Syncfusion.Windows.Forms.Grid.GridControl();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkBox1 = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.comboBox1 = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DpiAware = true;
            this.gridControl1.AllowSelection = ((Syncfusion.Windows.Forms.Grid.GridSelectionFlags)(((((((Syncfusion.Windows.Forms.Grid.GridSelectionFlags.Row | Syncfusion.Windows.Forms.Grid.GridSelectionFlags.Table)
                        | Syncfusion.Windows.Forms.Grid.GridSelectionFlags.Cell)
                        | Syncfusion.Windows.Forms.Grid.GridSelectionFlags.Multiple)
                        | Syncfusion.Windows.Forms.Grid.GridSelectionFlags.Shift)
                        | Syncfusion.Windows.Forms.Grid.GridSelectionFlags.Keyboard)
                        | Syncfusion.Windows.Forms.Grid.GridSelectionFlags.AlphaBlend)));
            this.gridControl1.AlphaBlendSelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.BackColor = System.Drawing.Color.White;
            gridBaseStyle1.Name = "Header";
            gridBaseStyle1.StyleInfo.Borders.Bottom = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None);
            gridBaseStyle1.StyleInfo.Borders.Left = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None);
            gridBaseStyle1.StyleInfo.Borders.Right = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None);
            gridBaseStyle1.StyleInfo.Borders.Top = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None);
            gridBaseStyle1.StyleInfo.CellType = "Header";
            gridBaseStyle1.StyleInfo.Font.Bold = true;
            gridBaseStyle1.StyleInfo.Font.Facename = "Segoe UI";
            gridBaseStyle1.StyleInfo.Interior = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(199)))), ((int)(((byte)(184))))), System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(234)))), ((int)(((byte)(216))))));
            gridBaseStyle1.StyleInfo.VerticalAlignment = Syncfusion.Windows.Forms.Grid.GridVerticalAlignment.Middle;
            gridBaseStyle2.Name = "Standard";
            gridBaseStyle2.StyleInfo.Font.Facename = "Segoe UI";
            gridBaseStyle2.StyleInfo.Interior = new Syncfusion.Drawing.BrushInfo(System.Drawing.SystemColors.Window);
            gridBaseStyle3.Name = "Column Header";
            gridBaseStyle3.StyleInfo.BaseStyle = "Header";
            gridBaseStyle3.StyleInfo.Font.Facename = "Segoe UI";
            gridBaseStyle3.StyleInfo.HorizontalAlignment = Syncfusion.Windows.Forms.Grid.GridHorizontalAlignment.Center;
            gridBaseStyle4.Name = "Row Header";
            gridBaseStyle4.StyleInfo.BaseStyle = "Header";
            gridBaseStyle4.StyleInfo.HorizontalAlignment = Syncfusion.Windows.Forms.Grid.GridHorizontalAlignment.Left;
            gridBaseStyle4.StyleInfo.Interior = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Horizontal, System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(199)))), ((int)(((byte)(184))))), System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(234)))), ((int)(((byte)(216))))));
            this.gridControl1.BaseStylesMap.AddRange(new Syncfusion.Windows.Forms.Grid.GridBaseStyle[] {
            gridBaseStyle1,
            gridBaseStyle2,
            gridBaseStyle3,
            gridBaseStyle4});
            this.gridControl1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gridControl1.ColCount = 5;
            this.gridControl1.ColWidthEntries.AddRange(new Syncfusion.Windows.Forms.Grid.GridColWidth[] {
            new Syncfusion.Windows.Forms.Grid.GridColWidth(0, 35),
            new Syncfusion.Windows.Forms.Grid.GridColWidth(4, 89)});
            this.gridControl1.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            gridCellInfo1.Col = -1;
            gridCellInfo1.Row = -1;
            gridCellInfo1.StyleInfo.Font.Bold = false;
            gridCellInfo1.StyleInfo.Font.Facename = "Segoe UI";
            gridCellInfo1.StyleInfo.Font.Italic = false;
            gridCellInfo1.StyleInfo.Font.Size = 8.25F;
            gridCellInfo1.StyleInfo.Font.Strikeout = false;
            gridCellInfo1.StyleInfo.Font.Underline = false;
            gridCellInfo1.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point;
            gridCellInfo2.Col = -1;
            gridCellInfo2.Row = -1;
            gridCellInfo2.StyleInfo.Font.Bold = false;
            gridCellInfo2.StyleInfo.Font.Facename = "Segoe UI";
            gridCellInfo2.StyleInfo.Font.Italic = false;
            gridCellInfo2.StyleInfo.Font.Size = 8.25F;
            gridCellInfo2.StyleInfo.Font.Strikeout = false;
            gridCellInfo2.StyleInfo.Font.Underline = false;
            gridCellInfo2.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point;
            gridCellInfo3.Col = -1;
            gridCellInfo3.Row = -1;
            gridCellInfo3.StyleInfo.Font.Bold = false;
            gridCellInfo3.StyleInfo.Font.Facename = "Segoe UI";
            gridCellInfo3.StyleInfo.Font.Italic = false;
            gridCellInfo3.StyleInfo.Font.Size = 8.25F;
            gridCellInfo3.StyleInfo.Font.Strikeout = false;
            gridCellInfo3.StyleInfo.Font.Underline = false;
            gridCellInfo3.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point;
            gridCellInfo4.Col = -1;
            gridCellInfo4.Row = -1;
            gridCellInfo4.StyleInfo.Font.Bold = false;
            gridCellInfo4.StyleInfo.Font.Facename = "Segoe UI";
            gridCellInfo4.StyleInfo.Font.Italic = false;
            gridCellInfo4.StyleInfo.Font.Size = 8.25F;
            gridCellInfo4.StyleInfo.Font.Strikeout = false;
            gridCellInfo4.StyleInfo.Font.Underline = false;
            gridCellInfo4.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point;
            gridCellInfo5.Col = 1;
            gridCellInfo5.Row = 0;
            gridCellInfo5.StyleInfo.Text = "Name";
            gridCellInfo6.Col = 2;
            gridCellInfo6.Row = 0;
            gridCellInfo6.StyleInfo.Text = "Size";
            gridCellInfo7.Col = 3;
            gridCellInfo7.Row = 0;
            gridCellInfo7.StyleInfo.Text = "Path";
            gridCellInfo8.Col = 4;
            gridCellInfo8.Row = 0;
            gridCellInfo8.StyleInfo.Text = "Modified Time";
            gridCellInfo8.StyleInfo.Themed = true;
            gridCellInfo9.Col = 5;
            gridCellInfo9.Row = 0;
            gridCellInfo9.StyleInfo.Text = "Type";
            this.gridControl1.GridCells.AddRange(new Syncfusion.Windows.Forms.Grid.GridCellInfo[] {
            gridCellInfo1,
            gridCellInfo2,
            gridCellInfo3,
            gridCellInfo4,
            gridCellInfo5,
            gridCellInfo6,
            gridCellInfo7,
            gridCellInfo8,
            gridCellInfo9});
            this.gridControl1.HorizontalThumbTrack = true;
            this.gridControl1.Location = new System.Drawing.Point(-1, 50);
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Properties.BackgroundColor = System.Drawing.Color.White;
            this.gridControl1.Properties.ForceImmediateRepaint = false;
            this.gridControl1.Properties.MarkColHeader = false;
            this.gridControl1.Properties.MarkRowHeader = false;
            this.gridControl1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.gridControl1.RowHeightEntries.AddRange(new Syncfusion.Windows.Forms.Grid.GridRowHeight[] {
            new Syncfusion.Windows.Forms.Grid.GridRowHeight(0, 21)});
            this.gridControl1.SerializeCellsBehavior = Syncfusion.Windows.Forms.Grid.GridSerializeCellsBehavior.SerializeIntoCode;
            this.gridControl1.ShowCurrentCellBorderBehavior = Syncfusion.Windows.Forms.Grid.GridShowCurrentCellBorder.HideAlways;
            this.gridControl1.Size = new System.Drawing.Size(860, 564);
            this.gridControl1.SmartSizeBox = false;
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ThemesEnabled = true;
            this.gridControl1.DpiAware = true;
            this.gridControl1.VerticalThumbTrack = true;
            // 
            // imageList1
            // 
#if NET9_0_OR_GREATER
            LoadImages(this.imageList1, "ImageList1", 6);
#else
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
#endif
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "");
            this.imageList1.Images.SetKeyName(1, "");
            this.imageList1.Images.SetKeyName(2, "");
            this.imageList1.Images.SetKeyName(3, "");
            this.imageList1.Images.SetKeyName(4, "");
            this.imageList1.Images.SetKeyName(5, "");
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(100)))), ((int)(((byte)(19)))));
            this.label1.Location = new System.Drawing.Point(3, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Logical Drives";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Controls.Add(this.gridControl1);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(863, 619);
            this.panel1.TabIndex = 7;
            // 
            // checkBox1
            // 
            this.checkBox1.BeforeTouchSize = new System.Drawing.Size(150, 21);
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.ForeColor = System.Drawing.Color.Navy;
            this.checkBox1.Location = new System.Drawing.Point(407, 12);
            this.checkBox1.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(216)))));
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(104, 24);
            this.checkBox1.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.checkBox1.DrawFocusRectangle = true;
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "Hide Details";
            this.checkBox1.ThemesEnabled = false;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.White;
            this.comboBox1.BeforeTouchSize = new System.Drawing.Size(184, 23);
            this.comboBox1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.Location = new System.Drawing.Point(162, 13);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(184, 23);
            this.comboBox1.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.comboBox1.TabIndex = 1;
            this.comboBox1.Text = "[select drive]";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            //
            //High DPI Support
            //
            if (DpiAware.GetCurrentDpi() > 96)
            {
                this.checkBox1.Size = new System.Drawing.Size((int)DpiAware.LogicalToDeviceUnits(104.0f), 24);
                this.label1.Size = new System.Drawing.Size(136, (int)DpiAware.LogicalToDeviceUnits(16.0f));
            }
            // 
            // TreeGridForm
            // 

            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218)))));
            this.CaptionFont = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClientSize = new System.Drawing.Size(888, 646);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimumSize = new System.Drawing.Size(600, 500);
            this.Name = "TreeGridForm";
            this.Text = "Grid Folder Browser";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.checkBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBox1)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion
        
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

        #region Events
        void GridSaveCellInfo(object sender, GridSaveCellInfoEventArgs e)
		{
			try
			{
				//move the changes back to the external data object
				if(e.ColIndex == 1 && e.RowIndex > 0)
				{
					externalData[e.RowIndex - 1].ExpandState = (int) e.Style.ImageIndex;
					externalData[e.RowIndex - 1].IndentLevel = (int) e.Style.Tag;
				}

				if( e.ColIndex > 0 && e.RowIndex > 0)
				{
					externalData[e.RowIndex - 1].Items[e.ColIndex - 1] = (string) e.Style.CellValue;

				}
			}
			catch{}

			//refresh this row so change is displayed
			if(!externalData.Locked)
			{
				externalData.CollapseData();
				this.gridControl1.Refresh();
			}
			e.Handled = true;
		}

		void GridQueryColWidth(object sender, GridRowColSizeEventArgs e) 
		{
			if( e.Index == 1 || e.Index == 3)
				e.Size = 500;
			else if (e.Index > 0)
				e.Size = 100;
			else
				e.Size = 0;//hide the header

			e.Handled = true;
		}
		void GridQueryRowCount(object sender, GridRowColCountEventArgs e) 
		{
			if(externalData != null)
				e.Count = externalData.RowCount;
			e.Handled = true;
		}

		void GridQueryColCount(object sender, GridRowColCountEventArgs e) 
		{
			if(externalData != null)
				e.Count = externalData.ColCount;
			e.Handled = true;
		}

		void GridQueryCellInfo(object sender, GridQueryCellInfoEventArgs e) 
		{
			if (e.RowIndex > 0 && e.ColIndex > 0)
			{
				if(externalData != null)
				{
					e.Style.CellValue = externalData[e.RowIndex - 1].Items[e.ColIndex - 1];
					if (e.ColIndex == 1)
					{
						e.Style.CellType = "TreeCell";
						e.Style.Tag = externalData[e.RowIndex - 1].IndentLevel;
						e.Style.ImageIndex = (int) externalData[e.RowIndex - 1].ExpandState;
					}
				}
				e.Handled = true;

				if(e.ColIndex == 2)
				{
					double value = double.Parse(e.Style.Text);
					if(value < 1024)
					{
						e.Style.CellValue = value + " B";
					}
					else if(value < 1048575)
					{
						value = Math.Floor(value/1024);
						e.Style.CellValue = value + " KB";
					}
					else if(value < 1073741824)
					{
						value = Math.Floor(value/1048575);
						e.Style.CellValue = value + " MB";
					}
					else if(value > 1073741824)
					{
						value = Math.Floor(value/1073741824);
						e.Style.CellValue = value + " GB";
					}
				}
			}

		}

		private void comboBox1_SelectedIndexChanged(object sender, System.EventArgs e)
		{
            if (this.comboBox1.SelectedItem != null)
                externalData = new CollapsibleDataSource(this.comboBox1.SelectedItem.ToString());
			if(externalData.IsEmpty)
				externalData = null;
			else
			{
				externalData.InitData();
				externalData.CollapseData();
			}
			if(TreeCellRenderer.nodeList != null )
				TreeCellRenderer.nodeList.Clear();
			gridControl1.ResetVolatileData();
			gridControl1.Refresh();
		}

		private void gridControl1_CellDoubleClick(object sender, GridCellClickEventArgs e)
		{
			if( e.RowIndex > 0 && e.ColIndex == 1 )
			{
				if(this.gridControl1[e.RowIndex, e.ColIndex].ImageIndex == (int) TreeNodeState.Opened)
				{
					this.gridControl1[e.RowIndex, e.ColIndex].ImageIndex = (int) TreeNodeState.Closed;
				}
				else if(this.gridControl1[e.RowIndex, e.ColIndex].ImageIndex == (int) TreeNodeState.Closed)
				{
					this.gridControl1[e.RowIndex, e.ColIndex].ImageIndex = (int) TreeNodeState.Opened;
					if(! TreeCellRenderer.nodeList.Contains(this.gridControl1[e.RowIndex, 3].Text))
					{
						int indent = externalData[e.RowIndex-1].IndentLevel;
						externalData.InsertData(e.RowIndex, this.gridControl1[e.RowIndex,3].Text, indent);
						TreeCellRenderer.nodeList.Add(this.gridControl1[e.RowIndex,3].Text,"Added");
					}
					this.gridControl1.Refresh();
					this.gridControl1.ColWidths.ResizeToFit(GridRangeInfo.Table());
				}
			}
		}

		private void checkBox1_CheckedChanged(object sender, System.EventArgs e)
		{
			if(checkBox1.Checked)
			{
				this.gridControl1.Cols.Hidden[2] = true;
				this.gridControl1.Cols.Hidden[3] = true;
				this.gridControl1.Cols.Hidden[4] = true;
				this.gridControl1.Cols.Hidden[5] = true;
			}
			else
			{
				this.gridControl1.Cols.Hidden[2] = false;
				this.gridControl1.Cols.Hidden[3] = false;
				this.gridControl1.Cols.Hidden[4] = false;
				this.gridControl1.Cols.Hidden[5] = false;
			}
        }
        #endregion

        #endregion

        #region Populating Sample Data to grid
        /// <summary>
        /// Populating the Sample data for grid
        /// </summary>
        private void SampleData()
        {
            //create a sample data for a virtual grid
            externalData = new CollapsibleDataSource(this.comboBox1.SelectedItem.ToString());
            externalData.InitData(); //initializes an external datasource
            externalData.CollapseData(); // c

            //hook up the events needed for virtual grid
            gridControl1.ResetVolatileData();
            gridControl1.QueryCellInfo += new GridQueryCellInfoEventHandler(GridQueryCellInfo);
            gridControl1.QueryRowCount += new GridRowColCountEventHandler(GridQueryRowCount);
            gridControl1.QueryColCount += new GridRowColCountEventHandler(GridQueryColCount);
            //gridControl1.QueryColWidth += new GridRowColSizeEventHandler(GridQueryColWidth);

            //handle saving data back to the data source...
            gridControl1.SaveCellInfo += new GridSaveCellInfoEventHandler(GridSaveCellInfo);
        }
        #endregion

        #region Sample Customization
        /// <summary>
        /// Sample customization for adding the Tree cell to grid
        /// </summary>
        private void SampleCustomization()
        {
            string[] drives = System.IO.Directory.GetLogicalDrives();
            foreach (string drv in drives)
                this.comboBox1.Items.Add(drv);
            this.comboBox1.SelectedIndex = 0;

            //add a custom cell control
            gridControl1.CellModels.Add("TreeCell", new TreeCellModel(gridControl1.Model));

            //make the imagelist available thru the tablestyle
            gridControl1.TableStyle.ImageList = this.imageList1;
        }
        #endregion

        #region GridSettings
        /// <summary>
        /// Grid settings for better look and feel. 
        /// </summary>
        private void GridSettings()
        {
            gridControl1.ControllerOptions = GridControllerOptions.All & (~GridControllerOptions.OleDataSource);
            this.gridControl1.DefaultGridBorderStyle = GridBorderStyle.None;
            this.gridControl1.Properties.RowHeaders = false;
            this.gridControl1.CellDoubleClick += new GridCellClickEventHandler(gridControl1_CellDoubleClick);
            this.gridControl1.ColWidths.ResizeToFit(GridRangeInfo.Table());
            this.gridControl1.TableStyle.Trimming = StringTrimming.EllipsisCharacter;
            this.gridControl1.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro;
            this.gridControl1.DefaultRowHeight = (int)DpiAware.LogicalToDeviceUnits(18.0f);
            this.gridControl1.DefaultColWidth = (int)DpiAware.LogicalToDeviceUnits(100.0f);
            this.gridControl1.ListBoxSelectionMode = SelectionMode.One;
            this.gridControl1.AllowProportionalColumnSizing = true;
            this.gridControl1.BrowseOnly = true;

            //tab key navigation set as false to move the next control
            this.gridControl1.WantTabKey = false;
        }
        #endregion
    }
}

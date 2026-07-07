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

namespace MultipleViews
{
	using System;
	using System.Drawing;
	using System.Collections;
	using System.ComponentModel;
	using System.Windows.Forms;
	using System.Data;

	using Syncfusion.Drawing;
	using Syncfusion.Windows.Forms.Grid;
    using Syncfusion.Windows.Forms;
    using DemoCommon.Grid;

	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class MultipleViewForm : GridDemoForm
    {
        #region "API Definition"
        private GridControl gridControl1;
		private GridControl gridControl2;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

        #endregion

        #region "Constructor"
        /// <summary>
        /// Form Constructor
        /// </summary>
        public MultipleViewForm()
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

            #region Buffer text
            gridControl1.Model.TextDataExchange.PasteTextFromBuffer( 
				"1\tDavolio	Nancy\r\n" +
				"2\tFuller	Andrew\r\n" +
				"3\tLeverling	Janet\r\n" +
				"4\tPeacock	Margaret\r\n" +
				"5\tBuchanan	Steven\r\n" +
				"6\tSuyama	Michael\r\n" +
				"7\tKing	Robert\r\n" +
				"8\tCallahan	Laura\r\n" +
				"9\tDodsworth	Anne\r\n",
				GridRangeInfo.Cell(1,1), int.MaxValue);
            #endregion

            #region Style Info
            GridStyleInfo standard = gridControl1.BaseStylesMap["Standard"].StyleInfo;
			//System.IO.Stream strm = null; 
			ImageList imageList = new ImageList();

			System.IO.Stream strm = null; 
			string iconName = "MultipleViews.user.ico"; 
			strm = this.GetType().Assembly.GetManifestResourceStream(iconName); 
			Icon icon = new Icon(strm);
			imageList.Images.Add(icon.ToBitmap());

			iconName = "MultipleViews.userH.ico";
			strm = this.GetType().Assembly.GetManifestResourceStream(iconName); 
			icon = new Icon(strm);
			imageList.Images.Add(icon.ToBitmap());

			iconName = "MultipleViews.userJ.ico";
			strm = this.GetType().Assembly.GetManifestResourceStream(iconName); 
			icon = new Icon(strm);
			imageList.Images.Add(icon.ToBitmap());
 
			standard.ImageList = imageList;

            int rowIndex = 1;
			int colIndex = 2;
			gridControl1[rowIndex++, colIndex].ImageIndex = 1;
			gridControl1[rowIndex++, colIndex].ImageIndex = 2;
			gridControl1[rowIndex++, colIndex].ImageIndex = 0;
			gridControl1[rowIndex++, colIndex].ImageIndex = 1;
			gridControl1[rowIndex++, colIndex].ImageIndex = 1;
			gridControl1[rowIndex++, colIndex].ImageIndex = 2;
			gridControl1[rowIndex++, colIndex].ImageIndex = 2;
			gridControl1[rowIndex++, colIndex].ImageIndex = 0;
			gridControl1[rowIndex++, colIndex].ImageIndex = 1;

			//gridControl1.Model.Options.DataObjectConsumerOptions = GridDataObjectConsumerOptions.Styles;
			gridControl1.DataObjectConsumerOptions = GridDataObjectConsumerOptions.All;

			GridStyleInfo style;
			style = new GridStyleInfo();
			style.Interior = new BrushInfo(Color.White);
			style.TextColor = Color.FromArgb( 0x82, 0x2e, 0x1b );
			gridControl1.ChangeCells(GridRangeInfo.Cells(1, 1, 9, 3), style);
			
			style = new GridStyleInfo();
			style.HorizontalAlignment = GridHorizontalAlignment.Right;
			style.CellValueType = typeof(int);
			style.Format = "000";
			gridControl1.ChangeCells(GridRangeInfo.Cells(1, 1, 9, 1), style);

			gridControl1.ColWidths.ResizeToFit(GridRangeInfo.Cells(1, 1, 9, 3));

			gridControl1.CommandStack.Enabled = true;

            // Make second grid controls share the same model.
            #endregion

            #region Properties
            this.gridControl1.DefaultRowHeight = (int)DpiAware.LogicalToDeviceUnits(18.0f);
			this.gridControl1.DefaultColWidth = (int)DpiAware.LogicalToDeviceUnits(70.0f);			
            this.gridControl1.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Office2007Blue;
            this.gridControl1.Properties.GridLineColor = Color.FromArgb(208, 215, 229);
            this.gridControl1.DefaultGridBorderStyle = Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid;
            style = this.gridControl1.BaseStylesMap["Header"].StyleInfo;
            style.TextColor = System.Drawing.Color.MidnightBlue;
            style.Font.Facename = "Verdana";
            style = this.gridControl1.BaseStylesMap["Standard"].StyleInfo;
            style.TextColor = System.Drawing.Color.MidnightBlue;
            style.Font.Facename = "Verdana";            
			gridControl2.Model = gridControl1.Model;
            this.gridControl1.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro;
            this.gridControl1.Model.ColWidths.ResizeToFit(GridRangeInfo.Table());
            this.gridControl2.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro;
            #endregion
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

            //Used to set default row height
            this.gridControl1.DefaultRowHeight = (int)DpiAware.LogicalToDeviceUnits(22.0f);

            this.gridControl1.Model.Options.DisplayEmptyColumns = true;
            this.gridControl1.Model.Options.DisplayEmptyRows = true;

            //tab key navigation set as false to move the next control
            this.gridControl1.WantTabKey = false;
            this.gridControl2.WantTabKey = false;

        }
        #endregion

        #region "Event Handler"

        private void MultipleViewForm_Layout(object sender, System.Windows.Forms.LayoutEventArgs e)
        {
            int xOffSet = 14;
            int yOffSet = 14;
            int width = ClientRectangle.Width / 2 - 3 * xOffSet / 2;//2 * xOffSet + xOffSet / 2;
            int height = ClientRectangle.Height - 2 * yOffSet;

            gridControl1.Location = new Point(xOffSet, yOffSet);
            gridControl1.Size = new Size(width, height);

            gridControl2.Location = new Point(width + 2 * xOffSet, yOffSet);
            gridControl2.Size = new Size(width, height);

        }
        #endregion

        #region "Form Handlers"

        private string GetIconFile(string bitmapName)
        {
            for (int n = 0; n < 10; n++)
            {
                if (System.IO.File.Exists(bitmapName))
                    return bitmapName;

                bitmapName = @"..\" + bitmapName;
            }

            return bitmapName;
        }
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

        #region Windows Form Designer generated code
        /// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.gridControl1 = new Syncfusion.Windows.Forms.Grid.GridControl();
            this.gridControl2 = new Syncfusion.Windows.Forms.Grid.GridControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DpiAware = true;
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gridControl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gridControl1.ColCount = 55;
            this.gridControl1.HorizontalThumbTrack = true;
            this.gridControl1.Location = new System.Drawing.Point(12, 12);
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RowCount = 100;
            this.gridControl1.Size = new System.Drawing.Size(280, 339);
            this.gridControl1.SmartSizeBox = false;
            this.gridControl1.TabIndex = 0;
            this.gridControl1.Text = "gridControl1";
            this.gridControl1.ThemesEnabled = true;
            this.gridControl1.VerticalThumbTrack = true;
            // 
            // gridControl2
            // 
            this.gridControl2.DpiAware = true;
            this.gridControl2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gridControl2.ColCount = 20;
            this.gridControl2.HorizontalThumbTrack = true;
            this.gridControl2.Location = new System.Drawing.Point(308, 10);
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.RowCount = 100;
            this.gridControl2.Size = new System.Drawing.Size(260, 341);
            this.gridControl2.SmartSizeBox = false;
            this.gridControl2.TabIndex = 1;
            this.gridControl2.Text = "gridControl1";
            this.gridControl2.ThemesEnabled = true;
            this.gridControl2.VerticalThumbTrack = true;
            // 
            // MultipleViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 456);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.gridControl2);
            this.DropShadow = false;
            this.MinimumSize = new System.Drawing.Size(500, 300);
            this.Name = "MultipleViewForm";
            this.Text = "Multiple View ";
            this.Layout += new System.Windows.Forms.LayoutEventHandler(this.MultipleViewForm_Layout);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
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
			Application.Run(new MultipleViewForm());
        }
        #endregion
    }
}

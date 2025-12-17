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

namespace GridPopulationSample
{
	using System;
	using System.Drawing;
	using System.Collections;
	using System.ComponentModel;
	using System.Windows.Forms;
	using System.Data;
	using Syncfusion.Windows.Forms.Grid;
	using Syncfusion.ComponentModel;
    using Syncfusion.Windows.Forms;
    using DemoCommon.Grid;

	/// <summary>
	/// Summary description for Form1.
	/// </summary>
    public class Form1 : GridDemoForm
    {
        #region API Definition
        private Syncfusion.Windows.Forms.Grid.GridControl gridControl1;
		private System.Windows.Forms.Label statsLabel;
        private Syncfusion.Windows.Forms.ButtonAdv gridCellIndexerButton;
        private Syncfusion.Windows.Forms.ButtonAdv populateValuesbutton;
        private Syncfusion.Windows.Forms.ButtonAdv virtualButton;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.NumericUpDown rowNumeric;
        private Syncfusion.Windows.Forms.ButtonAdv applyButton;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;

		private int [,] intArray;
		private int numArrayRows;
		private int numArrayCols;
		private System.Windows.Forms.NumericUpDown colNumeric;
		private bool isInVirtualMode;
        private System.Windows.Forms.Panel panel1;
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
            GridSettings();

            SampleCustomization();   
            this.gridControl1.ColWidths[0] = (int)DpiAware.LogicalToDeviceUnits(35);

        }
        #endregion

        #region Sample Customization
        /// <summary>
        /// Sample customization for populating the data
        /// </summary>
        private void SampleCustomization()
        {
            //Set up a possible progress bar dialog for any populations that take a long time.
            //We need to create a handler for the status dialog to set some properties and give
            //it to the GridControl.Model OperationFeeadbackListener.
            Syncfusion.Windows.Forms.DelayedStatusDialog handler = new Syncfusion.Windows.Forms.DelayedStatusDialog();

            this.gridControl1.Model.OperationFeedbackListener = handler;

            //start displaying progress bar after 2000 msecs if operation is less than 60% complete
            //show wait cursor after 2000 msecs if operation is less than 80 % complete
            handler.Delay = 2000; //default is 500
            handler.ShowDialogPercentRule = 60; //default is 25
            handler.ShowWaitCursorPercentRule = 80; //default value is 75

            //set up the integer array that serves as external data
            this.SetUpArray();

            isInVirtualMode = false;
        }

        #endregion

        #region Grid Settings
        /// <summary>
        /// Grid Settings for better look and feel
        /// </summary>
        private void GridSettings()
        {
            this.gridControl1.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro;
            //Used to set default row height
            this.gridControl1.DefaultRowHeight = (int)DpiAware.LogicalToDeviceUnits(22.0f);           

            this.gridControl1.DefaultGridBorderStyle = GridBorderStyle.Solid;
            GridStyleInfo style = this.gridControl1.BaseStylesMap["Header"].StyleInfo;
            style.Font.Facename = "Segoe UI";
            style = this.gridControl1.BaseStylesMap["Standard"].StyleInfo;
            style.Font.Facename = "Segoe UI";


            //tab key navigation set as false to move the next control
            this.gridControl1.WantTabKey = false;
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
            this.gridControl1 = new Syncfusion.Windows.Forms.Grid.GridControl();
            this.statsLabel = new System.Windows.Forms.Label();
            this.gridCellIndexerButton = new Syncfusion.Windows.Forms.ButtonAdv();
            this.populateValuesbutton = new Syncfusion.Windows.Forms.ButtonAdv();
            this.virtualButton = new Syncfusion.Windows.Forms.ButtonAdv();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.applyButton = new Syncfusion.Windows.Forms.ButtonAdv();
            this.colNumeric = new System.Windows.Forms.NumericUpDown();
            this.rowNumeric = new System.Windows.Forms.NumericUpDown();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.colNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rowNumeric)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DpiAware = true;
            this.gridControl1.ActivateCurrentCellBehavior = Syncfusion.Windows.Forms.Grid.GridCellActivateAction.DblClickOnCell;
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.BackColor = System.Drawing.Color.White;
            this.gridControl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gridControl1.DefaultGridBorderStyle = Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid;
            this.gridControl1.DefaultRowHeight = (int)DpiAware.LogicalToDeviceUnits(18.0f);
            this.gridControl1.DefaultColWidth = (int)DpiAware.LogicalToDeviceUnits(70.0f);
            this.gridControl1.ForeColor = System.Drawing.Color.White;
            this.gridControl1.Location = new System.Drawing.Point(23, 3);
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RowCount = 1000;
            this.gridControl1.Size = new System.Drawing.Size(518, 345);
            this.gridControl1.SmartSizeBox = false;
            this.gridControl1.TabIndex = 0;
            this.gridControl1.Text = "grid";
            this.gridControl1.ThemesEnabled = true;
            // 
            // statsLabel
            // 
            this.statsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.statsLabel.BackColor = System.Drawing.Color.White;
            this.statsLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.statsLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.statsLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statsLabel.Location = new System.Drawing.Point(559, 268);
            this.statsLabel.Name = "statsLabel";
            this.statsLabel.Size = new System.Drawing.Size(144, 80);
            this.statsLabel.TabIndex = 0;
            this.statsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gridCellIndexerButton
            // 
            this.gridCellIndexerButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gridCellIndexerButton.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.gridCellIndexerButton.FlatStyle = FlatStyle.Flat;
            this.gridCellIndexerButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.gridCellIndexerButton.BeforeTouchSize = new System.Drawing.Size(120, 23);
            this.gridCellIndexerButton.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.RaisedInner;
            this.gridCellIndexerButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridCellIndexerButton.ForeColor = System.Drawing.Color.White;
            this.gridCellIndexerButton.IsBackStageButton = false;
            this.gridCellIndexerButton.Location = new System.Drawing.Point(570, 139);
            this.gridCellIndexerButton.Name = "gridCellIndexerButton";
            this.gridCellIndexerButton.Size = new System.Drawing.Size(120, 23);
            this.gridCellIndexerButton.TabIndex = 4;
            this.gridCellIndexerButton.Text = "Grid Cell Indexer";
            this.gridCellIndexerButton.Click += new System.EventHandler(this.gridCellIndexerButton_Click);
            // 
            // populateValuesbutton
            // 
            this.populateValuesbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.populateValuesbutton.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.populateValuesbutton.FlatStyle = FlatStyle.Flat;
            this.populateValuesbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.populateValuesbutton.BeforeTouchSize = new System.Drawing.Size(120, 23);
            this.populateValuesbutton.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.RaisedInner;
            this.populateValuesbutton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.populateValuesbutton.ForeColor = System.Drawing.Color.White;
            this.populateValuesbutton.IsBackStageButton = false;
            this.populateValuesbutton.Location = new System.Drawing.Point(570, 182);
            this.populateValuesbutton.Name = "populateValuesbutton";
            this.populateValuesbutton.Size = new System.Drawing.Size(120, 23);
            this.populateValuesbutton.TabIndex = 5;
            this.populateValuesbutton.Text = "PopulateValues ";
            this.populateValuesbutton.Click += new System.EventHandler(this.populateValuesbutton_Click);
            // 
            // virtualButton
            // 
            this.virtualButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.virtualButton.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.virtualButton.FlatStyle = FlatStyle.Flat;
            this.virtualButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.virtualButton.BeforeTouchSize = new System.Drawing.Size(120, 23);
            this.virtualButton.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.RaisedInner;
            this.virtualButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.virtualButton.ForeColor = System.Drawing.Color.White;
            this.virtualButton.IsBackStageButton = false;
            this.virtualButton.Location = new System.Drawing.Point(570, 226);
            this.virtualButton.Name = "virtualButton";
            this.virtualButton.Size = new System.Drawing.Size(120, 23);
            this.virtualButton.TabIndex = 6;
            this.virtualButton.Text = "Virtual Grid";
            this.virtualButton.Click += new System.EventHandler(this.virtualButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.applyButton);
            this.groupBox1.Controls.Add(this.colNumeric);
            this.groupBox1.Controls.Add(this.rowNumeric);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox1.Location = new System.Drawing.Point(559, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(144, 116);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label2.Location = new System.Drawing.Point(8, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Columns";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Location = new System.Drawing.Point(8, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Rows";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // applyButton
            // 
            this.applyButton.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.applyButton.FlatStyle = FlatStyle.Flat;
            this.applyButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.applyButton.BeforeTouchSize = new System.Drawing.Size(128, 24);
            this.applyButton.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.RaisedInner;
            this.applyButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.applyButton.ForeColor = System.Drawing.Color.White;
            this.applyButton.IsBackStageButton = false;
            this.applyButton.Location = new System.Drawing.Point(8, 72);
            this.applyButton.Name = "applyButton";
            this.applyButton.Size = new System.Drawing.Size(128, 24);
            this.applyButton.TabIndex = 3;
            this.applyButton.Text = "Change Data";
            this.applyButton.Click += new System.EventHandler(this.applyButton_Click);
            // 
            // colNumeric
            // 
            this.colNumeric.BackColor = System.Drawing.Color.White;
            this.colNumeric.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.colNumeric.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.colNumeric.Location = new System.Drawing.Point(80, 42);
            this.colNumeric.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.colNumeric.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.colNumeric.Name = "colNumeric";
            this.colNumeric.Size = new System.Drawing.Size(56, 20);
            this.colNumeric.TabIndex = 2;
            this.colNumeric.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.colNumeric.ValueChanged += new System.EventHandler(this.Numeric_ValueChanged);
            // 
            // rowNumeric
            // 
            this.rowNumeric.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rowNumeric.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.rowNumeric.Location = new System.Drawing.Point(80, 16);
            this.rowNumeric.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.rowNumeric.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.rowNumeric.Name = "rowNumeric";
            this.rowNumeric.Size = new System.Drawing.Size(56, 20);
            this.rowNumeric.TabIndex = 1;
            this.rowNumeric.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.rowNumeric.ValueChanged += new System.EventHandler(this.Numeric_ValueChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.virtualButton);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.populateValuesbutton);
            this.panel1.Controls.Add(this.statsLabel);
            this.panel1.Controls.Add(this.gridCellIndexerButton);
            this.panel1.Controls.Add(this.gridControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(718, 365);
            this.panel1.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 365);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(300, 400);
            this.Name = "Form1";
            this.Text = "Grid Population";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.colNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rowNumeric)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

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
            Application.Run(new Form1());
        }    
		#endregion		    

        #region Event Handlers
        private void applyButton_Click(object sender, System.EventArgs e)
		{
			this.gridCellIndexerButton.Enabled = true;
			this.populateValuesbutton.Enabled = true;
			this.virtualButton.Enabled = true;
			
			SetUpArray();
			this.gridControl1.ResetVolatileData();
			this.gridControl1.Refresh();
        }

        #region Indexer
        private void gridCellIndexerButton_Click(object sender, System.EventArgs e)
		{
			if(isInVirtualMode)
				SetVirtualMode(false);

			
			//allow a cancel for long operations
			OperationFeedback op = new OperationFeedback(this.gridControl1.Model);
			op.AllowNestedFeedback = false;
			op.AllowNestedProgress = false;
			op.Description ="Population Progress";
			op.AllowCancel = true;
			
			int total = this.numArrayRows * this.numArrayCols;
			int progress = 0;
                    
			this.Cursor = Cursors.WaitCursor;
			int ticks = Environment.TickCount;
			this.gridControl1.BeginUpdate();
			this.gridControl1.RowCount = this.numArrayRows;
			this.gridControl1.ColCount = this.numArrayCols;

			for (int i = 0; i < this.numArrayRows; ++i)
			{
				for(int j = 0; j < this.numArrayCols; ++j)
					this.gridControl1[i + 1, j + 1].CellValue = this.intArray[i,j];
				
				progress += this.numArrayCols;
                op.PercentComplete = (int) (progress * 100 / total);
				if (op.ShouldCancel)
					break;
			}

			//Close out the operation progress dialog
			op.Close();

			this.gridControl1.EndUpdate();
			this.gridControl1.Refresh();

			this.statsLabel.Text = string.Format("\nGrid Cell Indexer\r\n\r\n{0} ticks", Environment.TickCount - ticks);

			this.Cursor = Cursors.Arrow;
        }
        #endregion

        #region Populate Values
        private void populateValuesbutton_Click(object sender, System.EventArgs e)
		{
			if(isInVirtualMode)
				SetVirtualMode(false);

			//OperationFeedback not needed here as it is 
			//embedded in the PopulateValues method

			this.Cursor = Cursors.WaitCursor;
			int ticks = Environment.TickCount;
			this.gridControl1.BeginUpdate();
			this.gridControl1.RowCount = this.numArrayRows;
			this.gridControl1.ColCount = this.numArrayCols;

			gridControl1.Model.PopulateValues(GridRangeInfo.Cells(1, 1, this.numArrayRows, this.numArrayCols), this.intArray);
			this.gridControl1.EndUpdate();
			Refresh();
			this.statsLabel.Text = string.Format("\nPopulateValues\r\n\r\n{0} ticks", Environment.TickCount - ticks);

			this.Cursor = Cursors.Arrow;
        }
        #endregion

        private void virtualButton_Click(object sender, System.EventArgs e)
		{
			if(!isInVirtualMode)
				SetVirtualMode(true);

			int ticks = Environment.TickCount;
		
			this.gridControl1.Refresh();
			this.statsLabel.Text = string.Format("\nVirtualMode\r\n\r\n{0} ticks", Environment.TickCount - ticks);

		}

		// setup the array that holds the data that we want to move to the grid
		private void SetUpArray()
		{
			this.Cursor = Cursors.WaitCursor;
			this.numArrayCols = (int) this.colNumeric.Value;
			this.numArrayRows = (int) this.rowNumeric.Value;

			Random r = new Random();

			this.intArray = new int[this.numArrayRows, this.numArrayCols];

			for (int i = 0; i < this.numArrayRows; ++i)
				for(int j = 0; j < this.numArrayCols; ++j)
					this.intArray[i, j] = r.Next(10000);
			this.Cursor = Cursors.Arrow;
		}

		private void Numeric_ValueChanged(object sender, System.EventArgs e)
		{
			this.gridCellIndexerButton.Enabled = false;
			this.populateValuesbutton.Enabled = false;
			this.virtualButton.Enabled = false;
	//		this.applyButton.Enabled = true;
		}

		#region Virtual Mode
		private void SetVirtualMode(bool on)
		{
			this.gridControl1.ResetVolatileData();
			isInVirtualMode = on;
			try
			{
				if(on)
				{
					this.gridControl1.QueryCellInfo += new GridQueryCellInfoEventHandler(QueryCellInfoHandler);
					this.gridControl1.QueryColCount += new GridRowColCountEventHandler(GridQueryColCount);
					this.gridControl1.QueryRowCount += new GridRowColCountEventHandler(GridQueryRowCount);
				}
				else
				{
					this.gridControl1.QueryCellInfo -= new GridQueryCellInfoEventHandler(QueryCellInfoHandler);
					this.gridControl1.QueryColCount -= new GridRowColCountEventHandler(GridQueryColCount);
					this.gridControl1.QueryRowCount -= new GridRowColCountEventHandler(GridQueryRowCount);
				}
			}
			catch{}
		}

		private void QueryCellInfoHandler(object sender, GridQueryCellInfoEventArgs e)
		{
			if(e.ColIndex > 0 && e.RowIndex > 0)
			{
				e.Style.CellValue = this.intArray[e.RowIndex - 1, e.ColIndex - 1];
				e.Handled = true;
			}
		}
		
		private void GridQueryColCount(object sender, GridRowColCountEventArgs e)
		{
			e.Count = this.numArrayCols;
			e.Handled = true;
		}

		private void GridQueryRowCount(object sender, GridRowColCountEventArgs e)
		{
			e.Count = this.numArrayRows;
			e.Handled = true;
		}
	
		#endregion

       
        #endregion
    }
}

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
using System.Reflection;
using Syncfusion.Windows.Forms.Grid;
using Syncfusion.GridHelperClasses;
using DemoCommon.Grid;
using Syncfusion.Windows.Forms;

namespace FormulaCellSelection
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : GridDemoForm
    {
        #region "API Definition"

        private GridAwareTextBox gridAwareTextBox1;
        private GridControl gridControl1;
		
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

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

			// TODO: Add any constructor code after InitializeComponent call
			//
            this.GridSettings();
        }

        #endregion

        #region "Grid Settings"
        /// <summary>
        /// Grid Settings for better look and feel
        /// </summary>
        private void GridSettings()
        {
            //Used to set default row height
            this.gridControl1.DefaultRowHeight = (int)DpiAware.LogicalToDeviceUnits(22.0f);

            this.gridControl1.Model.Options.DisplayEmptyColumns = true;
            this.gridControl1.Model.Options.DisplayEmptyRows = true;

            //Navigate the tab key to other control
            this.gridControl1.WantTabKey = false;
        }
        #endregion

        #region "Designer Stuffs"

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
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo1 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo2 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo3 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo4 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            this.gridAwareTextBox1 = new Syncfusion.Windows.Forms.Grid.GridAwareTextBox();
            this.gridControl1 = new Syncfusion.Windows.Forms.Grid.GridControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridAwareTextBox1
            // 
            this.gridAwareTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gridAwareTextBox1.AutoSuggestFormula = false;
            this.gridAwareTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gridAwareTextBox1.DisabledBackColor = System.Drawing.SystemColors.Window;
            this.gridAwareTextBox1.EnabledBackColor = System.Drawing.SystemColors.Window;
            this.gridAwareTextBox1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridAwareTextBox1.Location = new System.Drawing.Point(12, 12);
            this.gridAwareTextBox1.Name = "gridAwareTextBox1";
            this.gridAwareTextBox1.Size = new System.Drawing.Size(764, 27);
            this.gridAwareTextBox1.TabIndex = 4;
            // 
            // gridControl1
            // 
            this.gridControl1.DpiAware = true;
            this.gridControl1.AlphaBlendSelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(94)))), ((int)(((byte)(171)))), ((int)(((byte)(222)))));
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gridControl1.DefaultGridBorderStyle = Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid;
            this.gridControl1.Font = new System.Drawing.Font("Segoe UI", 9F);
            gridCellInfo1.Col = -1;
            gridCellInfo1.Row = -1;
            gridCellInfo1.StyleInfo.Font.Bold = false;
            gridCellInfo1.StyleInfo.Font.Facename = "Segoe UI";
            gridCellInfo1.StyleInfo.Font.Italic = false;
            gridCellInfo1.StyleInfo.Font.Size = 9F;
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
            gridCellInfo4.StyleInfo.Borders.Bottom = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234))))), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin);
            gridCellInfo4.StyleInfo.Borders.Right = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234))))), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin);
            gridCellInfo4.StyleInfo.Font.Facename = "Segoe UI";
            gridCellInfo4.StyleInfo.Interior = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.White);
            gridCellInfo4.StyleInfo.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gridControl1.GridCells.AddRange(new Syncfusion.Windows.Forms.Grid.GridCellInfo[] {
            gridCellInfo1,
            gridCellInfo2,
            gridCellInfo3,
            gridCellInfo4});
            //this.gridControl1.GridOfficeScrollBars = Syncfusion.Windows.Forms.OfficeScrollBars.Metro;
            //this.gridControl1.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro;
            this.gridControl1.DefaultRowHeight = (int)DpiAware.LogicalToDeviceUnits(20.0f);
            this.gridControl1.Location = new System.Drawing.Point(12, 44);
            //this.gridControl1.MetroScrollBars = true;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Properties.ForceImmediateRepaint = false;
            this.gridControl1.Properties.GridLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.gridControl1.Properties.MarkColHeader = false;
            this.gridControl1.Properties.MarkRowHeader = false;
            this.gridControl1.RowCount = 30;
            this.gridControl1.RowHeightEntries.AddRange(new Syncfusion.Windows.Forms.Grid.GridRowHeight[] {
            new Syncfusion.Windows.Forms.Grid.GridRowHeight(0, 29)});
            this.gridControl1.Size = new System.Drawing.Size(764, 358);
            this.gridControl1.SmartSizeBox = false;
            this.gridControl1.TabIndex = 6;
            this.gridControl1.Text = "gridControl1";
            this.gridControl1.ThemesEnabled = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 414);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.gridAwareTextBox1);
            this.MinimumSize = new System.Drawing.Size(500, 400);
            this.Name = "Form1";
            this.Text = "Formula Range Selection";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
        {
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense(Syncfusion.Licensing.DemoCommon.FindLicenseKey());
# if SyncfusionFramework1_1 || SyncfusionFramework2_0  
			Application.EnableVisualStyles();
# endif
			Application.Run(new Form1());
        }
        #endregion

        #region "Event Handler"

        private void Form1_Load(object sender, System.EventArgs e)
		{
			//wire the grid to the textbox
			this.gridAwareTextBox1.WireGrid(this.gridControl1);
			
			//Excel properties if wanted
			this.gridControl1.ExcelLikeCurrentCell = true;
			this.gridControl1.ExcelLikeSelectionFrame = true;
			this.gridControl1.ShouldSynchronizeCurrentCell = true;
			
			//make enter key move down
			this.gridControl1.EnterKeyBehavior = GridDirectionType.Down;

			//add the mousecontroller that handles formularange selections
			FormulaRangeSelectionController formulaController = new FormulaRangeSelectionController(gridControl1);
			gridControl1.MouseControllerDispatcher.Add(formulaController);

			//if you want the user to have to hold down control before a 
			//drag is started, then uncomment this line
			//formulaController.MouseRequiresControlKey = true;

			//if you want the user to have to hold down control in order
			//to start a drag with the arrow keys, then uncomment this line
			//formulaController.KeyBoardRequiresControlKey = true;

			//turn off ole D&D
			//this.gridControl1.ControllerOptions = GridControllerOptions.All & (~GridControllerOptions.OleDataSource);

			//set cell 1,1 current
			this.gridControl1.ForceCurrentCellMoveTo = true; //required to get the move to take in FormLoad
			this.gridControl1.CurrentCell.MoveTo(1,1);

			//put some random values in column 1
			Random r = new Random();
			for(int row = 1; row <= this.gridControl1.RowCount; ++row)
			{
				this.gridControl1[row, 1].CellValue = r.Next(1000);
			}          

			this.gridControl1.CurrentCell.MoveTo(5,2);
			this.gridControl1[5,2].Text = "=Sum(A1:A5)";
			this.gridAwareTextBox1.Text = "=Sum(A1:A5)";			
			this.gridControl1.DefaultRowHeight = (int)DpiAware.LogicalToDeviceUnits(18.0f);
			this.gridControl1.DefaultColWidth = (int)DpiAware.LogicalToDeviceUnits(70.0f);
            this.gridControl1.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro;
            this.gridControl1.TableStyle.CellType = GridCellTypeName.FormulaCell;
		}
        #endregion
        
        #region splitter event handlers - required
        //When a new splitter pane is created, a new GridControl is created. So, this new control
		//needs to be wired as the original control was.
		private void splitterControl1_PaneCreated(object sender, Syncfusion.Windows.Forms.SplitterPaneEventArgs e)
		{
			GridControlBase grid = (GridControlBase) e.Control;
			this.gridAwareTextBox1.WireGrid(grid);
		
			FormulaRangeSelectionController formulaController = new FormulaRangeSelectionController(grid);
			grid.MouseControllerDispatcher.Add(formulaController);
		}

		//When the pane goes away, the dynamically created GridControl goes away as well, so we
		//need to unwire things...
		private void splitterControl1_PaneClosing(object sender, Syncfusion.Windows.Forms.SplitterPaneEventArgs e)
		{
			GridControlBase grid = (GridControlBase) e.Control;
			this.gridAwareTextBox1.UnwireGrid(grid);
		}

		#endregion	
		
	}
}

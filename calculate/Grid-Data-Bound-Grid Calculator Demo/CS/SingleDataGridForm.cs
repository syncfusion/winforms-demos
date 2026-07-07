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
using Syncfusion.Calculate;
using DemoCommon.Grid;
using Syncfusion.Windows.Forms;

namespace GridDataBoundGridCalculator
{
	/// <summary>
	/// Summary description for SinglegridDataBoundGrid.
	/// </summary>
	public class SingleGridDataBoundGridForm : GridDemoForm
	{
		private GridDataBoundGridCalculator.CalcGridDataBoundGrid gridDataBoundGrid1;
		private System.Windows.Forms.TextBox textBox1;
		private ButtonAdv button1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private IContainer components;

		public SingleGridDataBoundGridForm()
		{
			//
			// Required for Windows Form Designer support.
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
		/// Required method for Designer support; do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            Syncfusion.Windows.Forms.Grid.GridBaseStyle gridBaseStyle1 = new Syncfusion.Windows.Forms.Grid.GridBaseStyle();
            Syncfusion.Windows.Forms.Grid.GridBaseStyle gridBaseStyle2 = new Syncfusion.Windows.Forms.Grid.GridBaseStyle();
            Syncfusion.Windows.Forms.Grid.GridBaseStyle gridBaseStyle3 = new Syncfusion.Windows.Forms.Grid.GridBaseStyle();
            Syncfusion.Windows.Forms.Grid.GridBaseStyle gridBaseStyle4 = new Syncfusion.Windows.Forms.Grid.GridBaseStyle();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gridDataBoundGrid1 = new GridDataBoundGridCalculator.CalcGridDataBoundGrid();
            ((System.ComponentModel.ISupportInitialize)(this.gridDataBoundGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(390, 152);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(208, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.Enter += new System.EventHandler(this.textBox1_Enter);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.button1.BeforeTouchSize = new System.Drawing.Size(75, 23);
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.IsBackStageButton = false;
            this.button1.Location = new System.Drawing.Point(462, 184);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Compute";
            this.button1.UseVisualStyle = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Location = new System.Drawing.Point(390, 224);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 40);
            this.label1.TabIndex = 3;
            // 
            // checkBox1
            // 
            this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.checkBox1.Location = new System.Drawing.Point(20, 68);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(344, 16);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "Show any formulas in the GridDataBoundGrid.";
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label2
            // 
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(472, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Try entering formulas such as = A4 + B4 into a cell in this GridDataBoundGrid.";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(390, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(288, 39);
            this.label3.TabIndex = 7;
            this.label3.Text = "Enter a formula based on GridDataBoundGrid cells like    = A1 + B2 + Cos(B1).    " +
                "                              Then press Compute. ";
            // 
            // gridDataBoundGrid1
            // 
            this.gridDataBoundGrid1.DpiAware = true;
            this.gridDataBoundGrid1.ActivateCurrentCellBehavior = Syncfusion.Windows.Forms.Grid.GridCellActivateAction.DblClickOnCell;
            this.gridDataBoundGrid1.AllowDragSelectedCols = true;
            this.gridDataBoundGrid1.AlphaBlendSelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(94)))), ((int)(((byte)(171)))), ((int)(((byte)(222)))));
            this.gridDataBoundGrid1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            gridBaseStyle1.Name = "Column Header";
            gridBaseStyle1.StyleInfo.BaseStyle = "Header";
            gridBaseStyle1.StyleInfo.CellType = "ColumnHeaderCell";
            gridBaseStyle1.StyleInfo.Enabled = false;
            gridBaseStyle1.StyleInfo.Font.Bold = true;
            gridBaseStyle1.StyleInfo.HorizontalAlignment = Syncfusion.Windows.Forms.Grid.GridHorizontalAlignment.Center;
            gridBaseStyle2.Name = "Header";
            gridBaseStyle2.StyleInfo.Borders.Bottom = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None);
            gridBaseStyle2.StyleInfo.Borders.Left = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None);
            gridBaseStyle2.StyleInfo.Borders.Right = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None);
            gridBaseStyle2.StyleInfo.Borders.Top = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None);
            gridBaseStyle2.StyleInfo.CellType = "Header";
            gridBaseStyle2.StyleInfo.Font.Bold = true;
            gridBaseStyle2.StyleInfo.Interior = new Syncfusion.Drawing.BrushInfo(System.Drawing.SystemColors.Control);
            gridBaseStyle2.StyleInfo.VerticalAlignment = Syncfusion.Windows.Forms.Grid.GridVerticalAlignment.Middle;
            gridBaseStyle3.Name = "Standard";
            gridBaseStyle3.StyleInfo.CheckBoxOptions.CheckedValue = "True";
            gridBaseStyle3.StyleInfo.CheckBoxOptions.UncheckedValue = "False";
            gridBaseStyle3.StyleInfo.Interior = new Syncfusion.Drawing.BrushInfo(System.Drawing.SystemColors.Window);
            gridBaseStyle4.Name = "Row Header";
            gridBaseStyle4.StyleInfo.BaseStyle = "Header";
            gridBaseStyle4.StyleInfo.CellType = "RowHeaderCell";
            gridBaseStyle4.StyleInfo.Enabled = true;
            gridBaseStyle4.StyleInfo.HorizontalAlignment = Syncfusion.Windows.Forms.Grid.GridHorizontalAlignment.Left;
            this.gridDataBoundGrid1.BaseStylesMap.AddRange(new Syncfusion.Windows.Forms.Grid.GridBaseStyle[] {
            gridBaseStyle1,
            gridBaseStyle2,
            gridBaseStyle3,
            gridBaseStyle4});
            this.gridDataBoundGrid1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gridDataBoundGrid1.DataMember = "";
            this.gridDataBoundGrid1.GridOfficeScrollBars = Syncfusion.Windows.Forms.OfficeScrollBars.Metro;
            this.gridDataBoundGrid1.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro;
            this.gridDataBoundGrid1.DefaultRowHeight = (int)DpiAware.LogicalToDeviceUnits(20.0f);
            this.gridDataBoundGrid1.Location = new System.Drawing.Point(24, 126);
            this.gridDataBoundGrid1.MetroScrollBars = true;
            this.gridDataBoundGrid1.Name = "gridDataBoundGrid1";
            this.gridDataBoundGrid1.Properties.ForceImmediateRepaint = false;
            this.gridDataBoundGrid1.Properties.GridLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.gridDataBoundGrid1.Properties.MarkColHeader = false;
            this.gridDataBoundGrid1.Properties.MarkRowHeader = false;
            this.gridDataBoundGrid1.ShowCurrentCellBorderBehavior = Syncfusion.Windows.Forms.Grid.GridShowCurrentCellBorder.GrayWhenLostFocus;
            this.gridDataBoundGrid1.Size = new System.Drawing.Size(358, 144);
            this.gridDataBoundGrid1.SmartSizeBox = false;
            this.gridDataBoundGrid1.SortBehavior = Syncfusion.Windows.Forms.Grid.GridSortBehavior.None;
            this.gridDataBoundGrid1.TabIndex = 0;
            this.gridDataBoundGrid1.ThemesEnabled = true;
            //
            // panel1
            //
            this.panel1.Dock = DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Size = new System.Drawing.Size(690, 305);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.gridDataBoundGrid1);
            // 
            // SingleGridDataBoundGridForm
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 310);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(650, 300);
            this.Name = "SingleGridDataBoundGridForm";
            this.Text = "Grid-Data-Bound-Grid Calculator ";
            this.Load += new System.EventHandler(this.SinglegridDataBoundGridForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridDataBoundGrid1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion


		#region Adding a formula to the formula library - step 1

		//Adding a formula to the CalcEngine Library:
		//Step 1: Code it with this signature:
		//			public string MyLibraryFormula(string args)
		//   return the computed value as a string...
		//   use the Engine's public members as needed in your code.
		//   This sample computes the minimum of arbitary range:
		//     egs:		=myMin(A1:C3)
		//				=mymin(a1,c2,a4,b2)
		public string ComputeMyMin(string args)
		{
			double min = double.MaxValue;
			double d;
			string s1;

			foreach(string r in args.Split(new char[]{','}))
			{
				if(r.IndexOf(':') > -1) //cell range
				{
					foreach(string s in engine.GetCellsFromArgs(r))
					{
						//s is a cell line a21 or c3...
						try
						{
							s1 = engine.GetValueFromArg(s);
						}
						catch(Exception ex)
						{
							return ex.Message;
						}
						if(s1 != "")
						{
							if(double.TryParse(s1, System.Globalization.NumberStyles.Number, null, out d))
							{
								min = Math.Min(min, d);
							}
						}
					}
				}
				else
				{
					try
					{
						s1 = engine.GetValueFromArg(r);
					}
					catch(Exception ex)
					{
						return ex.Message;
					}
					if(s1 != "")
					{
						if(double.TryParse(s1, System.Globalization.NumberStyles.Number, null, out d))
						{
							min = Math.Min(min, d);
						}
					}
				}
			}	
			if(min != double.MaxValue)
				return min.ToString();
			return "";
		}

		#endregion
		
		private Syncfusion.Calculate.CalcEngine engine;
		private DataTable dt;

		private void SinglegridDataBoundGridForm_Load(object sender, System.EventArgs e)
		{
			#region create a DataTable

			this.dt = new DataTable("MyTable");

			int nCols = 5;
			int nRows = 7;

			for(int i = 0; i < nCols; i++)
				this.dt.Columns.Add(new DataColumn(string.Format("{0}", (char) ((int)'A' + i))));

			Random r = new Random();

			for(int i = 0; i < nRows; ++i)
			{
				
 				DataRow dr = this.dt.NewRow();

				for(int j = 0; j < nCols; j++)
				{
					 if(j == 0)
					{
						dr[j] = (i + 1).ToString();
					}
					 else if(j == 1)
					 {
						 if(i == 0)
							 dr[j] = 1;
						 else
							dr[j] = string.Format("=B{0} + {0}", i);
					 }
					 else
						dr[j] = r.Next(100).ToString();
				}
				this.dt.Rows.Add(dr);
			}
			#endregion

			this.gridDataBoundGrid1.DataSource = this.dt;
			this.gridDataBoundGrid1.AllowResizeToFit = false;
			this.gridDataBoundGrid1.DefaultColWidth = (int)DpiAware.LogicalToDeviceUnits(60.0f);
            this.gridDataBoundGrid1.DpiAware = true;
			//Call this to reset static members in case other form is loaded first:
			Syncfusion.Calculate.CalcEngine.ResetSheetFamilyID();
			//Create a CalcEngine object, tie it to the gridDataBoundGrid that implements ICalcData:
			engine = new Syncfusion.Calculate.CalcEngine(this.gridDataBoundGrid1);
			//Set the CalcEngine to track dependencies required for auto updating:
			engine.UseDependencies = true;

			//Call RecalculateRange so any formulas in the data can be initially computed.
			//Code for all cells:
			//engine.RecalculateRange(RangeInfo.Cells(1, 1, dt.Rows.Count, dt.Columns.Count), this.gridDataBoundGrid1); 

			//We only have formulas in column two, so just recalc that range:
			engine.RecalculateRange(RangeInfo.Cells(1, 2, dt.Rows.Count, 2), this.gridDataBoundGrid1);

            this.gridDataBoundGrid1.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro;
            this.gridDataBoundGrid1.Properties.BackgroundColor = System.Drawing.Color.FromArgb(((System.Byte)(227)), ((System.Byte)(239)), ((System.Byte)(255)));
            this.gridDataBoundGrid1.Properties.GridLineColor = System.Drawing.Color.FromArgb(((System.Byte)(208)), ((System.Byte)(215)), ((System.Byte)(229)));
            this.gridDataBoundGrid1.Model.Options.DefaultGridBorderStyle = GridBorderStyle.Solid;
            this.gridDataBoundGrid1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.gridDataBoundGrid1.Font = new System.Drawing.Font("Verdana", 8.5F);
            this.gridDataBoundGrid1.Model.RowCount = 25;
            this.gridDataBoundGrid1.AllowProportionalColumnSizing = true;

			#region Adding a formula to the formula library - step 2
			//Adding formula to the CalcEngine Library.
			//Step 2: Call the AddFunction member of the engine.
			
			//Add formula name Min to the Library:
			engine.AddFunction("MyMin", new Syncfusion.Calculate.CalcEngine.LibraryFunction(ComputeMyMin));
			#endregion

		}

        #region [Evnet Handlers]
        private void textBox1_Enter(object sender, System.EventArgs e)
		{
			//Clear the display of last calculation value as the text box gets focus:
			this.label1.Text = "";
		}

		//Computes the value of a formula entered into textBox1.
		private void button1_Click(object sender, System.EventArgs e)
		{
			//-code to parse and compute a formula
			//-turn off dependency tracking as this formula comes from the
			//text box and is not entered into the grid.
			this.engine.UseDependencies = false;
            try
            {
                this.label1.Text = this.engine.ParseAndComputeFormula(this.textBox1.Text);
            }
            catch (Exception ex)
            {
                this.label1.Text = ex.Message;
            }			
			this.engine.UseDependencies = true;
		}

        private void checkBox1_CheckedChanged(object sender, System.EventArgs e)
        {
            this.gridDataBoundGrid1.Focus();
            this.gridDataBoundGrid1.CurrentCell.MoveTo(1, 1);
            this.gridDataBoundGrid1.Locked = this.checkBox1.Checked;
            this.gridDataBoundGrid1.TableStyle.TextColor = this.checkBox1.Checked ? Color.Gray : SystemColors.WindowText;

            DataTable dt = this.gridDataBoundGrid1.DataSource as DataTable;

            this.gridDataBoundGrid1.BeginUpdate();

            if (this.checkBox1.Checked)
            {
                engine.IgnoreValueChanged = true;
                for (int row = 0; row < dt.Rows.Count; ++row)
                {
                    for (int col = 0; col < dt.Columns.Count; ++col)
                    {
                        //All calls into CalcEngine are one-based:
                        string s = this.engine.GetFormulaRowCol(this.gridDataBoundGrid1, row + 1, col + 1);
                        if (s.Length > 0)
                        {
                            //No calculation as ValueChanged is not raised:
                            this.gridDataBoundGrid1[row + 1, col + 1].Text = s;
                        }
                    }
                }
                engine.IgnoreValueChanged = false;
            }
            else
            {
                for (int row = 0; row < dt.Rows.Count; ++row)
                {
                    for (int col = 0; col < dt.Columns.Count; ++col)
                    {
                        //All calls into CalcEngine are one-based:
                        string s = this.engine.GetFormulaRowCol(this.gridDataBoundGrid1, row + 1, col + 1);
                        if (s.Length > 0)
                        {
                            //Set the formula into the cell and force a calculation:
                            this.gridDataBoundGrid1[row + 1, col + 1].Text = s;
                        }
                    }
                }
                this.gridDataBoundGrid1.Binder.EndEdit();
            }
            this.gridDataBoundGrid1.EndUpdate();
            this.gridDataBoundGrid1.Refresh();
        }
        #endregion
    }
}

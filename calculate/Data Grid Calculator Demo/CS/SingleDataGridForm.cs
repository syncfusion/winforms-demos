#region Copyright Syncfusion Inc. 2001 - 2006
//
//  Copyright Syncfusion Inc. 2001 - 2006. All rights reserved.
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
using Syncfusion.Calculate;
using DemoCommon.Grid;
using Syncfusion.Windows.Forms;

namespace DataGridCalculator
{
	/// <summary>
	/// Summary description for SingleDataGrid.
	/// </summary>
	public class SingleDataGridForm : GridDemoForm
	{
		private System.Windows.Forms.TextBox textBox1;
		private ButtonAdv button1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private DataGridCalculator.CalcDataGrid dataGrid1;
        private System.Windows.Forms.CheckBox checkBox2;
        private IContainer components;

		public SingleDataGridForm()
		{
			//
			// Required for Windows Form Designer support.
			//
			InitializeComponent();
			if (DpiAware.GetCurrentDpi() > 96)
			{
				this.CaptionBarHeight = (int)DpiAware.LogicalToDeviceUnits(this.CaptionBarHeight);
			}

			this.dataGrid1.FlatMode = true;
        }

        #region FindFile Utility
        /// <summary>
        /// Finds a file of the given name in the current directory or sibling "Data" directory.
        /// If file is not found, the parent folder is checked until the file is found. This method
        /// is used by our samples when they load data from a separate "Data" folder.
        /// </summary>
        /// <param name="dataDirName">The name of the "Data" folder.</param>
        /// <param name="fileName">The filename to be searched.</param>
        /// <returns>The full path of the file that was found; an empty string is returned if file is not found.</returns>

        public static string FindFile(string dataDirName, string fileName)
        {
            dataDirName = dataDirName.TrimEnd('\\', '/');
            // Check both in parent folder and Parent\Data folders.
            string dataFileName = dataDirName + "\\" + fileName;
            for (int n = 0; n < 10; n++)
            {
                if (System.IO.File.Exists(fileName))
                {
                    return fileName;
                }
                if (System.IO.File.Exists(dataFileName))
                {
                    return dataFileName;
                }
                fileName = @"..\" + fileName;
                dataFileName = @"..\" + dataFileName;
            }

            return "";
        }
        #endregion

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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.dataGrid1 = new DataGridCalculator.CalcDataGrid();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(465, 118);
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
            this.button1.Location = new System.Drawing.Point(529, 156);
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
            this.label1.Location = new System.Drawing.Point(473, 194);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 85);
            this.label1.TabIndex = 3;
            // 
            // checkBox1
            // 
            this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.checkBox1.Location = new System.Drawing.Point(24, 52);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(344, 24);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "Show any formulas in the DataGrid.";
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(368, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "Try entering formulas such as = A4 + B4 into a cell in this DataGrid.";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(465, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(208, 56);
            this.label3.TabIndex = 7;
            this.label3.Text = "Enter a formula based on DataGrid cells like = A1 + B2 + Cos(B1).             The" +
                "n press Compute. ";
            // 
            // checkBox2
            // 
            this.checkBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.checkBox2.Location = new System.Drawing.Point(473, 14);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(192, 24);
            this.checkBox2.TabIndex = 9;
            this.checkBox2.Text = "SuspendCalculations";
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // dataGrid1
            // 
            this.dataGrid1.AllowSorting = false;
            this.dataGrid1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGrid1.DataMember = "";
            this.dataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.dataGrid1.Location = new System.Drawing.Point(22, 110);
            this.dataGrid1.Name = "dataGrid1";
            this.dataGrid1.Size = new System.Drawing.Size(418, 164);
            this.dataGrid1.TabIndex = 8;
            // 
            // SingleDataGridForm
            // 
            this.AcceptButton = this.button1;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(696, 307);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.dataGrid1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.MinimumSize = new System.Drawing.Size(650, 300);
            this.Name = "SingleDataGridForm";
            this.Text = "Data Grid Calculator";
            this.Load += new System.EventHandler(this.SingleDataGridForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion


		#region Adding a formula to the formula library - step 1

		//adding formula to the CalcEngine Library
		//step1: code it with this signature
		//			public string MyLibraryFormula(string args)
		//   return the computed value as a string...
		//   use the Engines public members as needed in your code.
		//   This sample computes the minimum of are arbitary range
		//     egs:		=Mymin(A1:C3)
		//				=mymin(a1,c2,a4,b2)
		public string ComputeMymin(string args)
		{	//assumes this.engine is the CalcEngine object

			double min = double.MaxValue;
			double d;
			string s1;
			
			foreach(string r in args.Split(new char[]{CalcEngine.ParseArgumentSeparator}))
			{
				if(r.IndexOf(':') > -1) //cell range
				{
					foreach(string s in engine.GetCellsFromArgs(r))
					{   //s is a cell line a21 or c3...
						try
						{
							s1 = engine.GetValueFromArg(s);
							if(s1 != ""
								&& double.TryParse(s1, System.Globalization.NumberStyles.Number, 
													null, out d))
							{
								min = Math.Min(min, d);
							}
						}
						catch(Exception ex)
						{
							return ex.Message;
						}
					}
				}
				else
				{
					try
					{
						s1 = engine.GetValueFromArg(r);
						if(s1 != ""
							&& double.TryParse(s1, System.Globalization.NumberStyles.Number, 
							null, out d))
						{
							min = Math.Min(min, d);
						}
					}
					catch(Exception ex) 
					{
						return ex.Message;
					}
				}
			}	
			if(min != double.MaxValue)
				return min.ToString();
			return "";
		}


		#endregion
		
		Syncfusion.Calculate.CalcEngine engine;
		private DataTable dt;

		private void SingleDataGridForm_Load(object sender, System.EventArgs e)
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

			
			//dataGrid1 is an instance of CalcDataGrid

			//Set the datasource to a DataTable:
			this.dataGrid1.DataSource = this.dt;


			//Call this to reset static members in case other form is loaded first:
			Syncfusion.Calculate.CalcEngine.ResetSheetFamilyID();
			//Create a CalcEngine object, tie it to the DataGrid that implements ICalcData:
			engine = new Syncfusion.Calculate.CalcEngine(this.dataGrid1);

			//Register multiple ICalcData objects for cross sheet references:
			int sheetfamilyID = Syncfusion.Calculate.CalcEngine.CreateSheetFamilyID();
			engine.RegisterGridAsSheet("SingleGrid", this.dataGrid1, sheetfamilyID);

			//Set the CalcEngine to track dependencies required for auto updating:
			engine.UseDependencies = true;

			//engine.IgnoreValueChanged = True;
			 
			//Call RecalculateRange so any formulas in the data can be initially computed:
			engine.RecalculateRange(RangeInfo.Cells(1, 1, dt.Rows.Count, dt.Columns.Count), this.dataGrid1); 

			//engine.IgnoreValueChanged = false; 

			#region Adding a formula to the formula library - step 2
			//Adding formulas to the CalcEngine Library:
			//Step 2: Call the AddFunction member of the Engine.
			
			

			//Add formula name Min to the Library:
			engine.AddFunction("Mymin", new Syncfusion.Calculate.CalcEngine.LibraryFunction(ComputeMymin));
			
			
			#endregion

		}


		private void textBox1_Enter(object sender, System.EventArgs e)
		{
			//Clear the display of the last calculation value as the text box gets focus:
			this.label1.Text = "";
		}

		//Compute the value of a formula entered into textBox1"
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
			catch(Exception ex)
			{
				this.label1.Text = ex.Message;
			}
			this.engine.UseDependencies = true;

		}


		private void checkBox1_CheckedChanged(object sender, System.EventArgs e)
		{
			DataTable dt = this.dataGrid1.DataSource as DataTable;
			CurrencyManager cm = this.dataGrid1.BindingContext[this.dataGrid1.DataSource, this.dataGrid1.DataMember] as CurrencyManager;
			int save  = cm.Position;
			
			if(this.checkBox1.Checked)
			{
				engine.IgnoreValueChanged = true;
				for(int row = 0; row < dt.Rows.Count; ++row)
				{
					for(int col = 0; col < dt.Columns.Count; ++col)
					{
						string s = this.engine.GetFormulaRowCol(this.dataGrid1, row + 1, col + 1); //one-based call

						if(s.Length > 0)
						{
							//No calculation as ValueChanged is not raised.
							this.dataGrid1[row, col] = s;
						}
					}
				}
				cm.Position = save;
				engine.IgnoreValueChanged = false;
			}
			else
			{
				for(int row = 0; row < dt.Rows.Count; ++row)
				{
					for(int col = 0; col < dt.Columns.Count; ++col)
					{
						string s = this.engine.GetFormulaRowCol(this.dataGrid1, row + 1, col + 1); //one-based call
						if(s.Length > 0)
						{
							//Setting the value forces the calculation.
							//The ValueChanged event will be raised.
							this.dataGrid1[row, col] = s;
						}
					}
				}
				cm.Position = save;
			}
			

			this.dataGrid1.ReadOnly = this.checkBox1.Checked;
			if(this.dataGrid1.ReadOnly)
				this.checkBox1.Text = "Showing Formulas (Read-only DataGrid)";
			else
				this.checkBox1.Text = "Show any formulas in the DataGrid.";
		}

		private void checkBox2_CheckedChanged(object sender, System.EventArgs e)
		{
			this.engine.CalculatingSuspended = this.checkBox2.Checked;
		}
	}
}

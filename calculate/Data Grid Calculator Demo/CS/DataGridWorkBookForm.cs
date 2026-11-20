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
	/// Summary description for DataGridWorkBook.
	/// </summary>
	public class DataGridWorkBookForm : GridDemoForm
	{
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.TabPage tabPage3;
		private System.Windows.Forms.TabPage tabPage4;
		private System.Windows.Forms.TabPage tabPage5;
		private DataGridCalculator.CalcDataGrid dataGrid1;
		private DataGridCalculator.CalcDataGrid dataGrid2;
		private DataGridCalculator.CalcDataGrid dataGrid3;
		private DataGridCalculator.CalcDataGrid dataGrid4;
		private DataGridCalculator.CalcDataGrid dataGrid5;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.Label label1;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public DataGridWorkBookForm()
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
				if(components != null)
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGrid1 = new DataGridCalculator.CalcDataGrid();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGrid2 = new DataGridCalculator.CalcDataGrid();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dataGrid3 = new DataGridCalculator.CalcDataGrid();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.dataGrid4 = new DataGridCalculator.CalcDataGrid();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.dataGrid5 = new DataGridCalculator.CalcDataGrid();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid2)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid3)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid4)).BeginInit();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid5)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Location = new System.Drawing.Point(32, 64);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(656, 360);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGrid1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(648, 334);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "DG1";
            // 
            // dataGrid1
            // 
            this.dataGrid1.AllowSorting = false;
            this.dataGrid1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGrid1.DataMember = "";
            this.dataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.dataGrid1.Location = new System.Drawing.Point(0, 0);
            this.dataGrid1.Name = "dataGrid1";
            this.dataGrid1.Size = new System.Drawing.Size(648, 334);
            this.dataGrid1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGrid2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(648, 334);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "DG2";
            // 
            // dataGrid2
            // 
            this.dataGrid2.AllowSorting = false;
            this.dataGrid2.DataMember = "";
            this.dataGrid2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGrid2.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.dataGrid2.Location = new System.Drawing.Point(0, 0);
            this.dataGrid2.Name = "dataGrid2";
            this.dataGrid2.Size = new System.Drawing.Size(648, 334);
            this.dataGrid2.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dataGrid3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(648, 334);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "DG3";
            // 
            // dataGrid3
            // 
            this.dataGrid3.AllowSorting = false;
            this.dataGrid3.DataMember = "";
            this.dataGrid3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGrid3.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.dataGrid3.Location = new System.Drawing.Point(0, 0);
            this.dataGrid3.Name = "dataGrid3";
            this.dataGrid3.Size = new System.Drawing.Size(648, 334);
            this.dataGrid3.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.dataGrid4);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(648, 334);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "DG4";
            // 
            // dataGrid4
            // 
            this.dataGrid4.AllowSorting = false;
            this.dataGrid4.DataMember = "";
            this.dataGrid4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGrid4.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.dataGrid4.Location = new System.Drawing.Point(0, 0);
            this.dataGrid4.Name = "dataGrid4";
            this.dataGrid4.Size = new System.Drawing.Size(648, 334);
            this.dataGrid4.TabIndex = 0;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.dataGrid5);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(648, 334);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "DG5";
            // 
            // dataGrid5
            // 
            this.dataGrid5.AllowSorting = false;
            this.dataGrid5.DataMember = "";
            this.dataGrid5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGrid5.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.dataGrid5.Location = new System.Drawing.Point(0, 0);
            this.dataGrid5.Name = "dataGrid5";
            this.dataGrid5.Size = new System.Drawing.Size(648, 334);
            this.dataGrid5.TabIndex = 0;
            // 
            // checkBox1
            // 
            this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.checkBox1.Location = new System.Drawing.Point(32, 24);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(224, 24);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.Text = "Show Formulas";
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(306, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(382, 48);
            this.label1.TabIndex = 4;
            this.label1.Text = "Enter a formula like   = Sum(DG2!B2:DG2!B5)   into a cell.";
            // 
            // DataGridWorkBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 454);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.tabControl1);
            this.MinimumSize = new System.Drawing.Size(700, 300);
            this.Name = "DataGridWorkBookForm";
            this.Text = "Data Grid Calculator ";
            this.Load += new System.EventHandler(this.DataGridWorkBookForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid2)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid3)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid4)).EndInit();
            this.tabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid5)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion


		Syncfusion.Calculate.CalcEngine engine;

		private void DataGridWorkBookForm_Load(object sender, System.EventArgs e)
		{
			this.dataGrid1.DataSource = GetARandomTable();
			this.dataGrid2.DataSource = GetARandomTable();
			this.dataGrid3.DataSource = GetARandomTable();
			this.dataGrid4.DataSource = GetARandomTable();
			this.dataGrid5.DataSource = GetARandomTable();

			if(engine == null)
			{
				//Call this to reset static members in case other form is loaded first:
				Syncfusion.Calculate.CalcEngine.ResetSheetFamilyID();
			
				//Create the engine:
				engine = new Syncfusion.Calculate.CalcEngine(this.dataGrid1);

				//Track dependencies required for auto calculations:
				engine.UseDependencies = true;
			
				//Register multiple ICalcData objects for cross sheet references:
				int sheetfamilyID = Syncfusion.Calculate.CalcEngine.CreateSheetFamilyID();
				engine.RegisterGridAsSheet("DG1", this.dataGrid1, sheetfamilyID);
				engine.RegisterGridAsSheet("DG2", this.dataGrid2, sheetfamilyID);
				engine.RegisterGridAsSheet("DG3", this.dataGrid3, sheetfamilyID);
				engine.RegisterGridAsSheet("DG4", this.dataGrid4, sheetfamilyID);
				engine.RegisterGridAsSheet("DG5", this.dataGrid5, sheetfamilyID);
			}
		}

		#region Create DataTables

		Random r = new Random();
		int tableCount = 0;
		private DataTable GetARandomTable()
		{
			DataTable dt = new DataTable(string.Format("Table{0}", tableCount));

			int nRows = r.Next(100) + 5;
			int nCols = r.Next(20) + 5;

			for(int i = 0; i < nCols; ++i)
				dt.Columns.Add(new DataColumn(RangeInfo.GetAlphaLabel(i+1)));

			tableCount++;

			for(int i = 0; i < nRows; ++i)
			{
				DataRow dr = dt.NewRow();
				for(int j = 0; j < nCols; ++j)
				{
					if(j == 0)
						dr[j] = i + 1;
					else
						dr[j] = r.Next(1000);
				}
				dt.Rows.Add(dr);
			}
			dt.DefaultView.AllowNew = false;
			return dt;
		}

		#endregion


		#region  CheckBox handler code

		private void checkBox1_CheckedChanged(object sender, System.EventArgs e)
		{
			this.Cursor = Cursors.WaitCursor;
			ShowFormulas(this.checkBox1.Checked, this.dataGrid1);
			ShowFormulas(this.checkBox1.Checked, this.dataGrid2);
			ShowFormulas(this.checkBox1.Checked, this.dataGrid3);
			ShowFormulas(this.checkBox1.Checked, this.dataGrid4);
			ShowFormulas(this.checkBox1.Checked, this.dataGrid5);
			this.Cursor = Cursors.Default;
		}

		private void ShowFormulas(bool show, DataGrid grid)
		{
			DataTable dt = grid.DataSource as DataTable;

			if(show)
			{
				engine.IgnoreValueChanged = true;
				for(int row = 0; row < dt.Rows.Count; ++row)
				{
					for(int col = 0; col < dt.Columns.Count; ++col)
					{
						string s = this.engine.GetFormulaRowCol((ICalcData)grid, row+1, col+1); //one-based
						if(s.Length > 0)
							grid[row, col] = s;
					}
				}
				engine.IgnoreValueChanged = false;
			}
			else
			{
				for(int row = 0; row < dt.Rows.Count; ++row)
				{
					for(int col = 0; col < dt.Columns.Count; ++col)
					{
						string s = this.engine.GetFormulaRowCol((ICalcData)grid, row+1, col+1); //one-based
						if(s.Length > 0)
							grid[row, col] = s;
					}
				}
			}
			grid.ReadOnly = show;
			if(show)
				this.checkBox1.Text = "Showing Formulas (Read-only DataGrid)";
			else
				this.checkBox1.Text = "Show Formulas";
			

		}
		#endregion
	}
}

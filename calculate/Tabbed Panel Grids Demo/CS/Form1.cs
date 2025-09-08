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
using Syncfusion.Calculate;
using DemoCommon.Grid;
using Syncfusion.Windows.Forms;

namespace TabbedPanelGrids
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : GridDemoForm
    {
        #region API Definition
        private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Label label2;

		private Syncfusion.Calculate.CalcWorkbook workBook;
		private System.Windows.Forms.MainMenu mainMenu1;
		private System.Windows.Forms.MenuItem menuItem1;
		private System.Windows.Forms.MenuItem menuItem2;
		private System.Windows.Forms.MenuItem menuItem3;
		private System.Windows.Forms.MenuItem menuItem4;
		private System.Windows.Forms.MenuItem menuItem5;
		private System.Windows.Forms.MenuItem menuItem6;
		private System.Windows.Forms.MenuItem menuItem7;
		private System.Windows.Forms.MenuItem menuItem8;
		private System.Windows.Forms.MenuItem menuItem9;
		private System.Windows.Forms.MenuItem menuItem10;
		private System.Windows.Forms.MenuItem menuItem11;
		private System.Windows.Forms.MenuItem menuItem12;
		private System.Windows.Forms.MenuItem menuItem13;
        private System.Windows.Forms.MenuItem menuItem14;
        private IContainer components;
        #endregion

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
			//create an empty work book
			this.workBook = new Syncfusion.Calculate.CalcWorkbook(null, null);

			//hook up a hidden acceptbutton to catch enter keys
			Button but = new Button();
			this.Controls.Add(but);
			but.Click += new EventHandler(EnterKeyPressed);
			but.Size = new Size(1, 1);
			this.AcceptButton = but;

			//load a sample SSS file
			string fileName = @"..\\..\\..\\sample.sss";
			System.IO.FileInfo fi = new System.IO.FileInfo(fileName);
			if(fi.Exists)
				LoadFile(fileName);
			
		}
     
		#region Windows Form Designer stuffs
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.mainMenu1 = new System.Windows.Forms.MainMenu(this.components);
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.menuItem3 = new System.Windows.Forms.MenuItem();
            this.menuItem14 = new System.Windows.Forms.MenuItem();
            this.menuItem4 = new System.Windows.Forms.MenuItem();
            this.menuItem5 = new System.Windows.Forms.MenuItem();
            this.menuItem6 = new System.Windows.Forms.MenuItem();
            this.menuItem7 = new System.Windows.Forms.MenuItem();
            this.menuItem12 = new System.Windows.Forms.MenuItem();
            this.menuItem8 = new System.Windows.Forms.MenuItem();
            this.menuItem10 = new System.Windows.Forms.MenuItem();
            this.menuItem9 = new System.Windows.Forms.MenuItem();
            this.menuItem13 = new System.Windows.Forms.MenuItem();
            this.menuItem11 = new System.Windows.Forms.MenuItem();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Location = new System.Drawing.Point(24, 40);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(434, 484);
            this.tabControl1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Location = new System.Drawing.Point(37, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "rows";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(72, 8);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(24, 20);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = "5";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(184, 8);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(24, 20);
            this.textBox2.TabIndex = 6;
            this.textBox2.Text = "5";
            // 
            // label2
            // 
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label2.Location = new System.Drawing.Point(136, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "columns";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem1,
            this.menuItem5});
            // 
            // menuItem1
            // 
            this.menuItem1.Index = 0;
            this.menuItem1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem2,
            this.menuItem3,
            this.menuItem14,
            this.menuItem4});
            this.menuItem1.Text = "File";
            // 
            // menuItem2
            // 
            this.menuItem2.Index = 0;
            this.menuItem2.Text = "Load SSS";
            this.menuItem2.Click += new System.EventHandler(this.menuItem2_Click);
            // 
            // menuItem3
            // 
            this.menuItem3.Index = 1;
            this.menuItem3.Text = "Save SSS";
            this.menuItem3.Click += new System.EventHandler(this.menuItem3_Click);
            // 
            // menuItem14
            // 
            this.menuItem14.Index = 2;
            this.menuItem14.Text = "-";
            // 
            // menuItem4
            // 
            this.menuItem4.Index = 3;
            this.menuItem4.Text = "Exit";
            this.menuItem4.Click += new System.EventHandler(this.menuItem4_Click);
            // 
            // menuItem5
            // 
            this.menuItem5.Index = 1;
            this.menuItem5.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem6,
            this.menuItem7,
            this.menuItem12,
            this.menuItem8,
            this.menuItem10,
            this.menuItem9,
            this.menuItem13,
            this.menuItem11});
            this.menuItem5.Text = "Sheets";
            // 
            // menuItem6
            // 
            this.menuItem6.Index = 0;
            this.menuItem6.Text = "Add Sheet";
            this.menuItem6.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuItem7
            // 
            this.menuItem7.Index = 1;
            this.menuItem7.Text = "Remove Sheet";
            this.menuItem7.Click += new System.EventHandler(this.button2_Click);
            // 
            // menuItem12
            // 
            this.menuItem12.Index = 2;
            this.menuItem12.Text = "-";
            // 
            // menuItem8
            // 
            this.menuItem8.Index = 3;
            this.menuItem8.Text = "Random Data";
            this.menuItem8.Click += new System.EventHandler(this.menuItem8_Click);
            // 
            // menuItem10
            // 
            this.menuItem10.Index = 4;
            this.menuItem10.Text = "Sum Edges";
            this.menuItem10.Click += new System.EventHandler(this.menuItem10_Click);
            // 
            // menuItem9
            // 
            this.menuItem9.Index = 5;
            this.menuItem9.Text = "Chain Formulas";
            this.menuItem9.Click += new System.EventHandler(this.menuItem9_Click);
            // 
            // menuItem13
            // 
            this.menuItem13.Index = 6;
            this.menuItem13.Text = "-";
            // 
            // menuItem11
            // 
            this.menuItem11.Index = 7;
            this.menuItem11.Text = "Move Tabs";
            this.menuItem11.Click += new System.EventHandler(this.menuItem11_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CaptionFont = new System.Drawing.Font("Segoe UI", 18F);
            this.ClientSize = new System.Drawing.Size(506, 590);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Menu = this.mainMenu1;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(500, 500);
            this.Name = "Form1";
            this.Text = "Tabbed Panel Grids ";
            this.ResumeLayout(false);
            this.PerformLayout();

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

		#region Add Tab
		private int tabPageNumber = 0;
		private void button1_Click(object sender, System.EventArgs e)
		{
			//insert tab
			//restrict because of all the textboxes
			int nRows = Math.Min(20, int.Parse(this.textBox1.Text)); 
			int nCols = Math.Min(10, int.Parse(this.textBox2.Text));

			CreateTabPage(nRows, nCols, null);
		
		}

		private PanelGrid CreateTabPage(int nRows, int nCols, CalcSheet sheet)
		{
			//create a tabpage that holds an array of textboxes to 
			//to display the CalcSheet
			int count = tabPageNumber;
			tabPageNumber++;
			string name = string.Format("sheet{0}", count);
			TabPage tp = new TabPage(name);
			tp.Dock = DockStyle.Fill;
			this.tabControl1.TabPages.Add(tp);

			//add left and top panels
			Panel left = new Panel();
			left.Width = 30;
			left.Dock = DockStyle.Left;
			tp.Controls.Add(left);
			Panel top = new Panel();
			top.Height = 20;
			top.Dock = DockStyle.Top;
			tp.Controls.Add(top);

			//initialize the grid
			PanelGrid pg = new PanelGrid();
			pg.Dock = DockStyle.Fill;
			pg.InitGrid(this.workBook, sheet, nRows, nCols, tp.ClientSize, left, top, name);

			//and add the grid to the tabpage
			tp.Controls.Add(pg);

			this.tabControl1.SelectedTab = tp;

			return pg;
		}
		#endregion

		#region remove tab
		private void button2_Click(object sender, System.EventArgs e)
		{
			//remove tab
			TabPage tp = this.tabControl1.SelectedTab;
			CalcSheet sheet = this.workBook.CalcSheetList[tp.Text];
			this.workBook.CalcSheetList.Remove(sheet);
			this.tabControl1.TabPages.Remove(tp);
		}
		#endregion

		#region load a SSS file from disk

		private void menuItem2_Click(object sender, System.EventArgs e)
		{
			//load SSS
			OpenFileDialog dlg = new OpenFileDialog();

			dlg.InitialDirectory = @"..\\..\\" ;
			dlg.Filter = "SSS files (*.sss)|*.sss|All files (*.*)|*.*";
			dlg.FilterIndex = 1 ;
			 
			if(dlg.ShowDialog() == DialogResult.OK)
			{
				if(this.workBook != null && this.workBook.CalcSheetList.Count > 0)
				{
					
					CalcSheet[] sheets = this.workBook.CalcSheetList.ToArray();

					foreach(CalcSheet sheet in sheets)
					{
						//this.workBook.CalcSheetList.Remove(sheet);
						CalcEngine.UnregisterGridAsSheet(sheet.Name, sheet);

						this.workBook.CalcSheetList.Remove(sheet);
						this.tabControl1.TabPages.RemoveAt(0); //removing the first one all the time
					}
				}
				LoadFile(dlg.FileName);
			}
		}

		private void LoadFile(string fileName)
		{
			CalcEngine.ResetSheetFamilyID();
			tabPageNumber = 0;

			//instantiate a workbook
			this.workBook = CalcWorkbook.ReadSSS(fileName);
			tabPageNumber = 0;
			//make the tabs reflect the new workbook
			CreateGridsForWorkbook();
		}

		//create a set of tabpages/PanelGrids based on the current workBook.
		private void CreateGridsForWorkbook()
		{
			this.tabControl1.TabPages.Clear();
			foreach(CalcSheet sheet in this.workBook.CalcSheetList)
			{
				PanelGrid pg = CreateTabPage(sheet.RowCount, sheet.ColCount, sheet);
				for(int row = 1; row <= sheet.RowCount; ++row)
					for(int col = 1; col <= sheet.ColCount; ++col)
					{
						TextBox tb = pg.GetTextBox(row, col);
						tb.Text = sheet.GetValueRowCol(row, col).ToString();
					}
			}
			this.workBook.CalculateAll();
		}

		#endregion

		#region save an SSS file to disk

		private void menuItem3_Click(object sender, System.EventArgs e)
		{
			//save SSS
			SaveFileDialog dlg = new SaveFileDialog();

			dlg.Filter = "SSS files (*.sss)|*.sss|All files (*.*)|*.*";
			dlg.FilterIndex = 1 ;
			if(dlg.ShowDialog() == DialogResult.OK)
			{
				this.workBook.WriteSSS(dlg.FileName);
			}


		}
		#endregion

		#region autogenerated data and formulas

		private void menuItem8_Click(object sender, System.EventArgs e)
		{
			//random data
			
			TabPage tp = this.tabControl1.SelectedTab;
			PanelGrid pg = GetPanelGrid(tp);

			Random r = new Random();

			//misses the last row and last col
			for(int row = 1; row < pg.rowCount; ++row)
				for(int col = 1; col < pg.colCount; ++col)
				{
				    pg.sheet[row, col] =   (r.Next(1000) / 10d).ToString();
				}

			this.workBook.CalculateAll();
		}

		private void menuItem9_Click(object sender, System.EventArgs e)
		{
			//chain formulas
			TabPage tp = this.tabControl1.SelectedTab;
			PanelGrid pg = GetPanelGrid(tp);

			this.workBook.ClearFormulas(pg.sheet);
			
			Random r = new Random();

			 
			for(int col = 1; col <= pg.colCount; ++col)
			{
				string col1 = RangeInfo.GetAlphaLabel(col);
				for(int row = 1; row <= pg.rowCount; ++row)
				{
					if(row == 1)
					{
						if(col == 1)
							pg.sheet[row, col] = "100";
						else
							pg.sheet[row, col] = string.Format("={0}{1} + 1", RangeInfo.GetAlphaLabel(col-1), pg.rowCount);
					}
					else
					{
						pg.sheet[row, col] = string.Format("={0}{1} + 1", col1, row - 1);
					}
				}
			}

			this.workBook.CalculateAll();
		}
		#endregion

		#region lookup utility

		private PanelGrid GetPanelGrid(TabPage tp)
		{
			PanelGrid grid = null;
			foreach(Control c in tp.Controls)
			{
				if(c is PanelGrid)
				{
					grid = c as PanelGrid;
					break;
				}
			}
			return grid;
		}

		#endregion

		#region handle enter key

		private void EnterKeyPressed(object sender, EventArgs e)
		{
			TabPage tp = this.tabControl1.SelectedTab;
			PanelGrid pg = GetPanelGrid(tp);
			int row, col;
			TextBox tb = pg.GetActiveTextBoxRowCol(out row, out col);
			if(tb != null)
			{
				if(row < pg.rowCount)
				{
					tb = pg.GetTextBox(row + 1, col);
				}
				else if(col < pg.colCount)
				{
					tb = pg.GetTextBox(1, col + 1);
				}

				tb.Focus();
			}
			 
		}

		#endregion

        #region [Event Handlers]

        private void menuItem4_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void menuItem10_Click(object sender, System.EventArgs e)
		{
			//sum edges
			TabPage tp = this.tabControl1.SelectedTab;
			PanelGrid pg = GetPanelGrid(tp);

			pg.GetTextBox(1,1).Focus(); //make sure focu is not on an edge

			this.workBook.ClearFormulas(pg.sheet);
			int row = pg.rowCount;
			int col;
			for(col = 1; col <= pg.colCount; ++col)
			{
				pg.sheet[row, col] = string.Format("=Sum({0}1:{0}{1})", RangeInfo.GetAlphaLabel(col), row-1);
			}

			string col1 = RangeInfo.GetAlphaLabel(pg.colCount-1);
			for(row = 1; row <= pg.rowCount-1; ++row)
			{
				pg.sheet[row, pg.colCount] = string.Format("=Sum(A{1}:{0}{1})", col1, row);
			}

			this.workBook.CalculateAll();
		}

		private void menuItem11_Click(object sender, System.EventArgs e)
		{
			//Move Tabs
			if(this.tabControl1.TabPages.Count > 1)
			{
				TabPage selected = this.tabControl1.SelectedTab;
				TabPage tp = this.tabControl1.TabPages[this.tabControl1.TabPages.Count - 1];
				for(int i = this.tabControl1.TabPages.Count - 1; i > 0; --i)
				{
					this.tabControl1.TabPages[i] = this.tabControl1.TabPages[i-1];
				}
				this.tabControl1.TabPages[0] = tp;
				this.tabControl1.SelectedTab = selected;
			}
        }
        #endregion
    }
}

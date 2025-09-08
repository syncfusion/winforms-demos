#region Copyright Syncfusion Inc. 2001 - 2019
//
//  Copyright Syncfusion Inc. 2001 - 2019. All rights reserved.
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
using System.IO;
using System.Diagnostics;
using Syncfusion.Calculate;
using Syncfusion.Licensing;
using Syncfusion.XlsIO;
using Syncfusion.Windows.Forms;

namespace XLFormulaCalc
{
	/// <summary>
	/// Summary description for SingleDataGrid.
	/// </summary>
	public class Form1 : MetroForm
    {
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Label label3;
        private Button button1;
        private Button button2;
        private Label label4;
        private Syncfusion.Windows.Forms.TabBarSplitterControl tabBarSplitterControl1;
        private Syncfusion.Windows.Forms.TabBarPage tabBarPage1;
        private Syncfusion.Windows.Forms.TabBarPage tabBarPage2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private DataGridViewCellStyle dataGridViewCellStyle1;

        ExcelEngine eng;
        IWorkbook workBook;
        CalcEngine calcEngine;
        private PictureBox pictureBox3;
        private Panel panel2;

		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Form1()
		{
			//
			// Required for Windows Form Designer support.
			//
			InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;           
            this.StartPosition = FormStartPosition.CenterScreen;
			//this.dataGrid1.FlatMode = true;
            dataGridView1.Paint += new PaintEventHandler(dataGrid1_Paint);
            dataGridView2.Paint += new PaintEventHandler(dataGrid2_Paint);
        }

        void dataGrid2_Paint(object sender, PaintEventArgs e)
        {
            if (dataGridView2.DataSource != null)
            {
                for (int i = 1; i <= 15; i++)
                {
                    Rectangle rect = dataGridView2.GetCellDisplayRectangle(0, i - 1, true);
                    if (i > 9)
                        rect.X = rect.X - 28;
                    else
                        rect.X = rect.X - 24;

                    e.Graphics.DrawString(i.ToString(), new Font("Verdana", 9f, FontStyle.Regular), Brushes.Black, rect);
                }
            }
        }

        void dataGrid1_Paint(object sender, PaintEventArgs e)
        {
            if (dataGridView1.DataSource != null)
            {
                for (int i = 1; i <= 15; i++)
                {
                    Rectangle rect = dataGridView1.GetCellDisplayRectangle(0, i - 1, true);
                    if(i > 9)
                        rect.X = rect.X - 28;
                    else
                        rect.X = rect.X-24;

                    e.Graphics.DrawString(i.ToString(), new Font("Verdana", 9f, FontStyle.Regular), Brushes.Black, rect);
                }
            }
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tabBarSplitterControl1 = new Syncfusion.Windows.Forms.TabBarSplitterControl();
            this.tabBarPage1 = new Syncfusion.Windows.Forms.TabBarPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabBarPage2 = new Syncfusion.Windows.Forms.TabBarPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tabBarSplitterControl1.SuspendLayout();
            this.tabBarPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabBarPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(150, 596);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 26);
            this.label1.TabIndex = 3;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(368, 22);
            this.label2.TabIndex = 6;
            this.label2.Text = "Click on any formula cell to get the calculated result.";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 604);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Computed Value:";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(15, 131);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Import Data From Excel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(187, 131);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(201, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Open sample workbook in Excel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(243, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "View of Imported Excel Worksheets:";
            // 
            // tabBarSplitterControl1
            // 
            this.tabBarSplitterControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tabBarSplitterControl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabBarSplitterControl1.Controls.Add(this.tabBarPage1);
            this.tabBarSplitterControl1.Controls.Add(this.tabBarPage2);
            this.tabBarSplitterControl1.EnabledColor = System.Drawing.SystemColors.WindowText;
            this.tabBarSplitterControl1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabBarSplitterControl1.Location = new System.Drawing.Point(18, 200);
            this.tabBarSplitterControl1.Name = "tabBarSplitterControl1";
            this.tabBarSplitterControl1.Office2007ScrollBars = true;
            this.tabBarSplitterControl1.RelativeWidth = 24;
            this.tabBarSplitterControl1.Size = new System.Drawing.Size(567, 386);
            this.tabBarSplitterControl1.SplitBars = Syncfusion.Windows.Forms.DynamicSplitBars.None;
            this.tabBarSplitterControl1.Style = Syncfusion.Windows.Forms.TabBarSplitterStyle.Office2007;
            this.tabBarSplitterControl1.TabFolderDelta = 11;
            this.tabBarSplitterControl1.TabIndex = 13;
            this.tabBarSplitterControl1.Text = "tabBarSplitterControl1";
            this.tabBarSplitterControl1.ThemesEnabled = true;
            // 
            // tabBarPage1
            // 
            this.tabBarPage1.Controls.Add(this.dataGridView1);
            this.tabBarPage1.Location = new System.Drawing.Point(0, 0);
            this.tabBarPage1.Name = "tabBarPage1";
            this.tabBarPage1.SplitBars = Syncfusion.Windows.Forms.DynamicSplitBars.None;
            this.tabBarPage1.TabBackColor = System.Drawing.SystemColors.Control;
            this.tabBarPage1.Text = "Sheet1";
            this.tabBarPage1.ThemesEnabled = true;
            // 
            // dataGrid1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.DataMember = "";
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(218)))), ((int)(((byte)(229)))));
            dataGridViewCellStyle1 = new DataGridViewCellStyle();
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.TopLeft;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGrid1";
            this.dataGridView1.RowTemplate.Height = 18;
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(17506, 8487);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.dataGrid1_MouseClick);
            // 
            // tabBarPage2
            // 
            this.tabBarPage2.Controls.Add(this.dataGridView2);
            this.tabBarPage2.Location = new System.Drawing.Point(0, 0);
            this.tabBarPage2.Name = "tabBarPage2";
            this.tabBarPage2.SplitBars = ((Syncfusion.Windows.Forms.DynamicSplitBars)((Syncfusion.Windows.Forms.DynamicSplitBars.SplitRows | Syncfusion.Windows.Forms.DynamicSplitBars.SplitColumns)));
            this.tabBarPage2.TabBackColor = System.Drawing.SystemColors.Control;
            this.tabBarPage2.Text = "Sheet2";
            this.tabBarPage2.ThemesEnabled = true;
            // 
            // dataGrid2
            // 
            this.dataGridView2.DataMember = "";
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView2.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            this.dataGridView2.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            this.dataGridView2.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(218)))), ((int)(((byte)(229)))));
            this.dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView2.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView2.Location = new System.Drawing.Point(0, 0);
            this.dataGridView2.Name = "dataGrid2";
            this.dataGridView2.RowTemplate.Height = 18;
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(575, 338);
            this.dataGridView2.TabIndex = 4;
            this.dataGridView2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.dataGrid2_MouseClick);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(0, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(639, 71);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 17;
            this.pictureBox3.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(-3, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(486, 71);
            this.panel2.TabIndex = 22;
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(603, 631);
            this.Controls.Add(this.tabBarSplitterControl1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Compute Specific Formula";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.tabBarSplitterControl1.ResumeLayout(false);
            this.tabBarPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabBarPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
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
			SyncfusionLicenseProvider.RegisterLicense(DemoCommon.FindLicenseKey());
            Application.EnableVisualStyles();
            Application.Run(new Form1());
        }


        private void dataGrid1_MouseClick(object sender, MouseEventArgs e)
        {
            Point pt = new Point(e.X, e.Y);
            DataGridView.HitTestInfo hitInfo = this.dataGridView1.HitTest(pt.X, pt.Y);
            if (hitInfo.Type == DataGridViewHitTestType.Cell)
            {
                if (this.dataGridView1[hitInfo.ColumnIndex, hitInfo.RowIndex].Value.ToString().StartsWith("="))
                    this.label1.Text = calcEngine.ParseAndComputeFormula(this.dataGridView1[hitInfo.ColumnIndex, hitInfo.RowIndex].Value.ToString());
                else
                    this.label1.Text = "Not a Formula Cell";
            }
        }

        void dataGrid2_MouseClick(object sender, MouseEventArgs e)
        {
            Point pt = new Point(e.X, e.Y);
            DataGridView.HitTestInfo hitInfo = this.dataGridView2.HitTest(pt.X, pt.Y);
            if (hitInfo.Type == DataGridViewHitTestType.Cell)
            {
                if (this.dataGridView2[hitInfo.ColumnIndex, hitInfo.RowIndex].Value.ToString().StartsWith("="))
                    this.label1.Text = calcEngine.ParseAndComputeFormula(this.dataGridView2[hitInfo.ColumnIndex, hitInfo.RowIndex].Value.ToString());
                else
                    this.label1.Text = "Not a Formula Cell";
            }
        }        

        private void button1_Click(object sender, EventArgs e)
        {
            eng = new ExcelEngine();
#if NETCORE
            workBook = eng.Excel.Workbooks.Open(@"..\..\..\..\..\..\..\common\Data\XlsIO\Input.xls");
#else
            workBook = eng.Excel.Workbooks.Open(@"..\..\..\..\..\..\common\Data\XlsIO\Input.xls");
#endif
            IWorksheet sheet = workBook.Worksheets[0];
            IWorksheet sheet2 = workBook.Worksheets[1];

            //Enable to calculate formulas in the sheet.
            sheet.EnableSheetCalculations();
            
            //Assign the sheet calcEngine.
            calcEngine = sheet.CalcEngine;

            //Load the datagrids with the data from Xls file.
            DataTable dt = new DataTable("Input Data");
            dt = sheet.ExportDataTable(1, 1, 15, 5, ExcelExportDataTableOptions.None);
            this.dataGridView1.DataSource = dt;
            this.dataGridView1.Rows[0].Cells[0].Selected = false;

            DataTable dt2 = new DataTable("Sheet2 Data");
            dt2 = sheet2.ExportDataTable(1, 1, 15, 8, ExcelExportDataTableOptions.None);
            this.dataGridView2.DataSource = dt2;
            this.dataGridView2.Rows[0].Cells[0].Selected = false;

            this.button1.Enabled = false;

            for (int i = 0; i < 5; i++)
            {
                switch (i)
                {
                    case 3:
                        this.dataGridView1.Columns[i].Width = 180; break;
                    case 4:
                        this.dataGridView1.Columns[i].Width = 210; break;
                    default:
                        this.dataGridView1.Columns[i].Width = 60; break;
                }
                this.dataGridView1.Columns[i].HeaderText = string.Format("{0}", (char)((int)'A' + i));
            }

            for (int j = 0; j < 8; j++)
            {
                this.dataGridView2.Columns[j].Width = 70;
                this.dataGridView2.Columns[j].HeaderText = string.Format("{0}", (char)((int)'A' + j));
            }

            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView2.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView2.EnableHeadersVisualStyles = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Launching the Excel file using the default Application.[MS Excel Or Free ExcelViewer]
#if NETCORE
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            process.StartInfo = new System.Diagnostics.ProcessStartInfo(@"..\..\..\..\..\..\..\common\Data\XlsIO\Input.xls")
            {
                UseShellExecute = true
            };
            process.Start();
#else
            Process.Start(@"..\..\..\..\..\..\common\Data\XlsIO\Input.xls");
#endif
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (eng != null)
            {
                workBook.Close();
                eng.Dispose();
            }
           
        }
    }
	/// <summary>
    /// Represents a class that is used to find the licensing file for Syncfusion controls.
    /// </summary>
	public class DemoCommon
    {

        /// <summary>
        /// Finds the license key from the Common folder.
        /// </summary>
        /// <returns>Returns the license key.</returns>
        public static string FindLicenseKey()
        {
            string licenseKeyFile = "common\\SyncfusionLicense.txt";
            for (int n = 0; n < 20; n++)
            {
                if (!System.IO.File.Exists(licenseKeyFile))
                {
                    licenseKeyFile = @"..\" + licenseKeyFile;
                    continue;
                }
                return File.ReadAllText(licenseKeyFile);
            }
            return string.Empty;
        }
    }
}

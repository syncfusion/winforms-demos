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

using Syncfusion.Grouping;
using ISummary = Syncfusion.Collections.BinaryTree.ITreeTableSummary;

namespace GroupingWithDataGrid
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.DataGrid dataGrid1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label MinB;
		private System.Windows.Forms.Label MinA;
		private System.Windows.Forms.Label MaxB;
		private System.Windows.Forms.Label MaxA;
		private System.Windows.Forms.Label TotalB;
		private System.Windows.Forms.Label TotalA;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label CountB;
		private System.Windows.Forms.Label CountA;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.NumericUpDown numericUpDown1;
		private System.Windows.Forms.Button NewData;
		private System.Windows.Forms.Panel panel2;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

            try
            {
                System.Drawing.Icon ico = new System.Drawing.Icon(GetIconFile(@"common\Images\Grid\Icon\sfgrid.ico"));
                this.Icon = ico;
            }
            catch { }	

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}
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
            this.dataGrid1 = new System.Windows.Forms.DataGrid();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CountB = new System.Windows.Forms.Label();
            this.CountA = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.TotalB = new System.Windows.Forms.Label();
            this.TotalA = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.MinB = new System.Windows.Forms.Label();
            this.MinA = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.MaxB = new System.Windows.Forms.Label();
            this.MaxA = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.NewData = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGrid1
            // 
            this.dataGrid1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGrid1.DataMember = "";
            this.dataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.dataGrid1.Location = new System.Drawing.Point(8, 16);
            this.dataGrid1.Name = "dataGrid1";
            this.dataGrid1.Size = new System.Drawing.Size(208, 384);
            this.dataGrid1.TabIndex = 0;
            this.dataGrid1.CurrentCellChanged += new System.EventHandler(this.dataGrid1_CurrentCellChanged);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.CountB);
            this.panel1.Controls.Add(this.CountA);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.TotalB);
            this.panel1.Controls.Add(this.TotalA);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.MinB);
            this.panel1.Controls.Add(this.MinA);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.MaxB);
            this.panel1.Controls.Add(this.MaxA);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(224, 128);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(296, 80);
            this.panel1.TabIndex = 1;
            // 
            // CountB
            // 
            this.CountB.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.CountB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CountB.Location = new System.Drawing.Point(240, 56);
            this.CountB.Name = "CountB";
            this.CountB.Size = new System.Drawing.Size(56, 23);
            this.CountB.TabIndex = 14;
            this.CountB.Text = "B";
            this.CountB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CountA
            // 
            this.CountA.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.CountA.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CountA.Location = new System.Drawing.Point(240, 32);
            this.CountA.Name = "CountA";
            this.CountA.Size = new System.Drawing.Size(56, 23);
            this.CountA.TabIndex = 13;
            this.CountA.Text = "A";
            this.CountA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(248, 8);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(40, 23);
            this.label15.TabIndex = 12;
            this.label15.Text = "Count";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TotalB
            // 
            this.TotalB.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.TotalB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalB.Location = new System.Drawing.Point(184, 56);
            this.TotalB.Name = "TotalB";
            this.TotalB.Size = new System.Drawing.Size(56, 23);
            this.TotalB.TabIndex = 11;
            this.TotalB.Text = "B";
            this.TotalB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TotalA
            // 
            this.TotalA.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.TotalA.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalA.Location = new System.Drawing.Point(184, 32);
            this.TotalA.Name = "TotalA";
            this.TotalA.Size = new System.Drawing.Size(56, 23);
            this.TotalA.TabIndex = 10;
            this.TotalA.Text = "A";
            this.TotalA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(192, 8);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(48, 23);
            this.label12.TabIndex = 9;
            this.label12.Text = "Total";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MinB
            // 
            this.MinB.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.MinB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinB.Location = new System.Drawing.Point(120, 56);
            this.MinB.Name = "MinB";
            this.MinB.Size = new System.Drawing.Size(64, 23);
            this.MinB.TabIndex = 8;
            this.MinB.Text = "B";
            this.MinB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MinA
            // 
            this.MinA.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.MinA.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinA.Location = new System.Drawing.Point(120, 32);
            this.MinA.Name = "MinA";
            this.MinA.Size = new System.Drawing.Size(64, 23);
            this.MinA.TabIndex = 7;
            this.MinA.Text = "A";
            this.MinA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(128, 8);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 23);
            this.label9.TabIndex = 6;
            this.label9.Text = "Minimum";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MaxB
            // 
            this.MaxB.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.MaxB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaxB.Location = new System.Drawing.Point(64, 56);
            this.MaxB.Name = "MaxB";
            this.MaxB.Size = new System.Drawing.Size(56, 23);
            this.MaxB.TabIndex = 5;
            this.MaxB.Text = "B";
            this.MaxB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MaxA
            // 
            this.MaxA.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.MaxA.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaxA.Location = new System.Drawing.Point(64, 32);
            this.MaxA.Name = "MaxA";
            this.MaxA.Size = new System.Drawing.Size(56, 23);
            this.MaxA.TabIndex = 4;
            this.MaxA.Text = "A";
            this.MaxA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(64, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 23);
            this.label6.TabIndex = 3;
            this.label6.Text = "Maximum";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "B";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "A";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Column";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label4.Location = new System.Drawing.Point(16, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Number of rows";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(128, 16);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(56, 20);
            this.numericUpDown1.TabIndex = 3;
            this.numericUpDown1.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // NewData
            // 
            this.NewData.BackColor = System.Drawing.SystemColors.ControlLight;
            this.NewData.Location = new System.Drawing.Point(32, 48);
            this.NewData.Name = "NewData";
            this.NewData.Size = new System.Drawing.Size(152, 23);
            this.NewData.TabIndex = 4;
            this.NewData.Text = "Generate New Data";
            this.NewData.UseVisualStyleBackColor = false;
            this.NewData.Click += new System.EventHandler(this.NewData_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.numericUpDown1);
            this.panel2.Controls.Add(this.NewData);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(264, 16);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(216, 80);
            this.panel2.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.AutoScaleDimensions = new SizeF(6F, 13F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 422);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGrid1);
            this.MinimumSize = new System.Drawing.Size(544, 300);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Grouping With Data Grid Demo";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
        {
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense(DemoCommon.FindLicenseKey());
# if SyncfusionFramework1_1 || SyncfusionFramework2_0  
			Application.EnableVisualStyles();
# endif
			Application.Run(new Form1());
		}

		//our datasource
		DataTable myTable;

		//grouping support objects 
		private Syncfusion.Grouping.Table theTable;
		private Syncfusion.Grouping.Engine engine;

		private void Form1_Load(object sender, System.EventArgs e)
		{
			//get a DataTable
			myTable = GetATable();

			//set it into the DataGrid
			this.dataGrid1.DataSource = myTable;

			//create a new grouping engine and assign it a IList datasource
			engine = new Engine();
			engine.SetSourceList(myTable.DefaultView);
			engine.RecordAsDisplayElements = true;

			//enable the 2 summar

			//get a reference to the underlying grouping Table
			theTable = engine.Table;

			//add the Summaries that we want
			engine.TableDescriptor.Summaries.Add("AStats", "A", SummaryType.Int32Aggregate);
			engine.TableDescriptor.Summaries.Add("BStats", "B", SummaryType.Int32Aggregate);
		
			RefreshStatsPanel();

			//turn off AddNew
			//dt.DefaultView.AllowNew = false;


		}

		private DataTable GetATable()
		{
			DataTable dt = new DataTable("MyTable");
			dt.Columns.Add(new DataColumn("A", typeof(int)));
			dt.Columns.Add(new DataColumn("B", typeof(int)));

			PopulateDataTable(100, dt);

			return dt;
		}

		private void PopulateDataTable(int nRows, DataTable dt)
		{
			if (this.dataGrid1.CurrentRowIndex >= 0)
				this.dataGrid1.CurrentRowIndex = 0;
			dt.Clear();
			dt.Rows.Clear();

			Random r = new Random();

			for(int i = 0; i < nRows; i++)
			{
				DataRow dr = dt.NewRow();
				dr[0] = r.Next(1000);
				dr[1] = r.Next(1000);
				dt.Rows.Add(dr);
			}
		}

		private void NewData_Click(object sender, System.EventArgs e)
		{
			PopulateDataTable((int) this.numericUpDown1.Value, this.myTable);
			RefreshStatsPanel();
		}

		private void RefreshStatsPanel()
		{
			ISummary[] summaries = this.theTable.TopLevelGroup.GetSummaries(this.theTable);
			SummaryDescriptorCollection sdc = this.theTable.TableDescriptor.Summaries;
			int index = sdc.IndexOf(sdc["AStats"]);
			Int32AggregateSummary summary = summaries[index] as Int32AggregateSummary;
			
			
			MaxA.Text = summary.Maximum.ToString();
			MinA.Text = summary.Minimum.ToString();
			TotalA.Text = summary.Sum.ToString();
			CountA.Text = summary.Count.ToString();;
			
			index = sdc.IndexOf(sdc["BStats"]);
			summary = summaries[index] as Int32AggregateSummary;
			
			MaxB.Text = summary.Maximum.ToString();
			MinB.Text = summary.Minimum.ToString();
			TotalB.Text = summary.Sum.ToString();
			CountB.Text = summary.Count.ToString();;
		
	
		}

		private void dataGrid1_CurrentCellChanged(object sender, System.EventArgs e)
		{
			RefreshStatsPanel();
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
			string licenseKeyFile = "..\\Common\\SyncfusionLicense.txt";
			for (int n = 0; n < 20; n++)
			{
				if (!System.IO.File.Exists(licenseKeyFile))
				{
					licenseKeyFile = @"..\" + licenseKeyFile;
					continue;
				}
				return System.IO.File.ReadAllText(licenseKeyFile);
			}
			return string.Empty;
		}
	}
}

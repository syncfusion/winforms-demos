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

namespace RandomTest
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
    {
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label totalCount;
		private System.Windows.Forms.Label bucket3Count;
		private System.Windows.Forms.Label bucket56Count;
		private System.Windows.Forms.Label average;
		private System.Windows.Forms.Label median;
        private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label percent25;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label percent75;
		private System.Windows.Forms.Label label11;
        private Panel panel2;
        private NumericUpDown refreshrate;
        private Label label7;
        private NumericUpDown timeInTest;
        private Label label6;
        private Button StartTestbutton;
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.totalCount = new System.Windows.Forms.Label();
            this.bucket3Count = new System.Windows.Forms.Label();
            this.bucket56Count = new System.Windows.Forms.Label();
            this.average = new System.Windows.Forms.Label();
            this.median = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.percent75 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.percent25 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.refreshrate = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.timeInTest = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.StartTestbutton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.refreshrate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeInTest)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Location = new System.Drawing.Point(16, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 32);
            this.label2.TabIndex = 6;
            this.label2.Text = "Total number of random numbers";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(16, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 32);
            this.label1.TabIndex = 7;
            this.label1.Text = "Count in bucket 3";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label3.Location = new System.Drawing.Point(16, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 32);
            this.label3.TabIndex = 8;
            this.label3.Text = "Count in bucket 56";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label4.Location = new System.Drawing.Point(16, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 32);
            this.label4.TabIndex = 9;
            this.label4.Text = "Average value of all random numbers";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label5.Location = new System.Drawing.Point(16, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 32);
            this.label5.TabIndex = 10;
            this.label5.Text = "Median value of all random numbers";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // totalCount
            // 
            this.totalCount.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.totalCount.Location = new System.Drawing.Point(136, 16);
            this.totalCount.Name = "totalCount";
            this.totalCount.Size = new System.Drawing.Size(56, 32);
            this.totalCount.TabIndex = 11;
            this.totalCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bucket3Count
            // 
            this.bucket3Count.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.bucket3Count.Location = new System.Drawing.Point(136, 48);
            this.bucket3Count.Name = "bucket3Count";
            this.bucket3Count.Size = new System.Drawing.Size(56, 32);
            this.bucket3Count.TabIndex = 12;
            this.bucket3Count.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bucket56Count
            // 
            this.bucket56Count.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.bucket56Count.Location = new System.Drawing.Point(136, 80);
            this.bucket56Count.Name = "bucket56Count";
            this.bucket56Count.Size = new System.Drawing.Size(56, 32);
            this.bucket56Count.TabIndex = 13;
            this.bucket56Count.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // average
            // 
            this.average.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.average.Location = new System.Drawing.Point(136, 112);
            this.average.Name = "average";
            this.average.Size = new System.Drawing.Size(56, 32);
            this.average.TabIndex = 14;
            this.average.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // median
            // 
            this.median.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.median.Location = new System.Drawing.Point(136, 144);
            this.median.Name = "median";
            this.median.Size = new System.Drawing.Size(56, 32);
            this.median.TabIndex = 15;
            this.median.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.percent75);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.percent25);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.median);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.totalCount);
            this.panel1.Controls.Add(this.bucket3Count);
            this.panel1.Controls.Add(this.bucket56Count);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.average);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(24, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 248);
            this.panel1.TabIndex = 16;
            // 
            // percent75
            // 
            this.percent75.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.percent75.Location = new System.Drawing.Point(136, 208);
            this.percent75.Name = "percent75";
            this.percent75.Size = new System.Drawing.Size(56, 32);
            this.percent75.TabIndex = 19;
            this.percent75.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label11.Location = new System.Drawing.Point(16, 208);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(112, 32);
            this.label11.TabIndex = 18;
            this.label11.Text = "75 percentile level";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // percent25
            // 
            this.percent25.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.percent25.Location = new System.Drawing.Point(136, 176);
            this.percent25.Name = "percent25";
            this.percent25.Size = new System.Drawing.Size(56, 32);
            this.percent25.TabIndex = 17;
            this.percent25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label9.Location = new System.Drawing.Point(16, 176);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(112, 32);
            this.label9.TabIndex = 16;
            this.label9.Text = "25 percentile level";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.refreshrate);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.timeInTest);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.StartTestbutton);
            this.panel2.Location = new System.Drawing.Point(230, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(211, 252);
            this.panel2.TabIndex = 21;
            // 
            // refreshrate
            // 
            this.refreshrate.Location = new System.Drawing.Point(133, 162);
            this.refreshrate.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.refreshrate.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.refreshrate.Name = "refreshrate";
            this.refreshrate.Size = new System.Drawing.Size(64, 20);
            this.refreshrate.TabIndex = 25;
            this.refreshrate.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label7.Location = new System.Drawing.Point(13, 162);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 24);
            this.label7.TabIndex = 24;
            this.label7.Text = "Refresh iteration";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // timeInTest
            // 
            this.timeInTest.Location = new System.Drawing.Point(133, 130);
            this.timeInTest.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.timeInTest.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.timeInTest.Name = "timeInTest";
            this.timeInTest.Size = new System.Drawing.Size(64, 20);
            this.timeInTest.TabIndex = 23;
            this.timeInTest.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label6.Location = new System.Drawing.Point(13, 128);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 32);
            this.label6.TabIndex = 22;
            this.label6.Text = "Number of seconds in test";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // StartTestbutton
            // 
            this.StartTestbutton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.StartTestbutton.Location = new System.Drawing.Point(21, 66);
            this.StartTestbutton.Name = "StartTestbutton";
            this.StartTestbutton.Size = new System.Drawing.Size(176, 32);
            this.StartTestbutton.TabIndex = 21;
            this.StartTestbutton.Text = "Start Test";
            this.StartTestbutton.Click += new EventHandler(StartTestbutton_Click);
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.AutoScaleDimensions = new SizeF(6F, 13F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 286);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(480, 324);
            this.Name = "Form1";
            this.Text = "Random Test Demo";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.refreshrate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeInTest)).EndInit();
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

		//grouping support objects 
		private Syncfusion.Grouping.Table theTable;
		private Syncfusion.Grouping.Engine engine;

		//supports IBindingList
		IntegerCollection intCollection;

		private void Form1_Load(object sender, System.EventArgs e)
		{
			//create an integer collection to hold the random numbers
			intCollection = new IntegerCollection();
			
			//create a new grouping engine and assign it a IList datasource
			engine = new Engine();
			engine.SetSourceList(intCollection);
			engine.RecordAsDisplayElements = true;

			//get a reference to the underlying grouping Table
			theTable = engine.Table;

			//group by the Value
			engine.TableDescriptor.GroupedColumns.Add("Value");

			//add the Summaries that we want
			engine.TableDescriptor.Summaries.Add("Int32Agg", "Value", SummaryType.Int32Aggregate);
			engine.TableDescriptor.Summaries.Add("Vect", "Value", SummaryType.DoubleVector);

		}

		private void StartTestbutton_Click(object sender, System.EventArgs e)
		{
			this.totalCount.Text = "";
			this.average.Text = "";
			this.median.Text = "";
			this.percent25.Text = "";
			this.percent75.Text = "";
			this.bucket56Count.Text = "";
			this.bucket3Count.Text = "";
		
			intCollection.Clear();

			int refreshValue = (int) this.refreshrate.Value;
			
			int timeLimit = Environment.TickCount + 1000 * (int) this.timeInTest.Value;

			int count = 0;

			Random r = new Random();

			while(count < int.MaxValue && Environment.TickCount < timeLimit)
			{
				intCollection.Add(new WrappedInt(r.Next(100)));
				count++;
				if((count % refreshValue) == 0)
				{
					UpdateDisplay();
					Application.DoEvents();
				}
			}
			UpdateDisplay();
		}

		private void UpdateDisplay()
		{
			//bool summaryChange;
			ISummary[] summaries = this.theTable.TopLevelGroup.GetSummaries(this.theTable);
			SummaryDescriptorCollection sdc = this.theTable.TableDescriptor.Summaries;
			int index = sdc.IndexOf(sdc["Int32Agg"]);
			Int32AggregateSummary summaryInt32Agg = summaries[index] as Int32AggregateSummary;
			
			this.totalCount.Text = this.theTable.Records.Count.ToString();
			this.average.Text = summaryInt32Agg.Average.ToString("F2");

			index = sdc.IndexOf(sdc["Vect"]);
			DoubleVectorSummary summaryVector = summaries[index] as DoubleVectorSummary;
			
			this.median.Text = summaryVector.Median.ToString();
			this.percent25.Text = summaryVector.Percentile25.ToString();
			this.percent75.Text = summaryVector.Percentile75.ToString();
			
			index = sdc.IndexOf(sdc["Int32Agg"]);

			int bucketCount = this.theTable.TopLevelGroup.Groups.Count;
			if (bucketCount > 3)
			{
				summaries = this.theTable.TopLevelGroup.Groups[3].GetSummaries(this.theTable);
				summaryInt32Agg = summaries[index] as Int32AggregateSummary;

				this.bucket3Count.Text = summaryInt32Agg.Count.ToString();
			}
			else
				// Less than 3 buckets ...
				this.bucket3Count.Text = "###";

			if (bucketCount > 56)
			{
				summaries = this.theTable.TopLevelGroup.Groups[56].GetSummaries(this.theTable);
				summaryInt32Agg = summaries[index] as Int32AggregateSummary;
				this.bucket56Count.Text = summaryInt32Agg.Count.ToString();
			}
			else
				// Less than 56 buckets ...
				this.bucket56Count.Text = "###";
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

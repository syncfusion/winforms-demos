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

namespace ArrayICalcData
{
    /// <summary>
    /// Summary description for Form1.
    /// </summary>
    public class Form1 : GridDemoForm
    {
        #region API definitions
        private ButtonAdv button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private ButtonAdv button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private IContainer components;
        private Random r = new Random();
        private ArrayCalcData data;
        int nRows;
        int nCols;
        #endregion

        public Form1()
        {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();
            if(DpiAware.GetCurrentDpi() > 96)
            {
                this.CaptionBarHeight = (int)DpiAware.LogicalToDeviceUnits(this.CaptionBarHeight);
            }
           
        }

        #region Windows Designer stuffs
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button1 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.button2 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.button1.BeforeTouchSize = new System.Drawing.Size(288, 23);
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.IsBackStageButton = false;
            this.button1.Location = new System.Drawing.Point(26, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(288, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Generate Data";
            this.button1.UseVisualStyle = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(24, 88);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(288, 232);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(65, 53);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(32, 20);
            this.textBox2.TabIndex = 2;
            this.textBox2.Text = "0";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(137, 53);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(32, 20);
            this.textBox3.TabIndex = 3;
            this.textBox3.Text = "0";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(217, 53);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(48, 20);
            this.textBox4.TabIndex = 4;
            this.textBox4.Text = "123";
            // 
            // button2
            // 
            this.button2.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.button2.BeforeTouchSize = new System.Drawing.Size(40, 23);
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.IsBackStageButton = false;
            this.button2.Location = new System.Drawing.Point(273, 52);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(40, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Set";
            this.button2.UseVisualStyle = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Row:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(113, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 23);
            this.label2.TabIndex = 7;
            this.label2.Text = "Col:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(176, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 23);
            this.label3.TabIndex = 8;
            this.label3.Text = "Value:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 342);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(300, 300);
            this.Name = "Form1";
            this.Text = "Array ICalcData";
            this.Load += new System.EventHandler(this.Form1_Load);
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

        private void wait(double secs)
        {
            DateTime dt = DateTime.Now;
            while (((TimeSpan)(DateTime.Now - dt)).TotalSeconds < secs)
            {
                Application.DoEvents();
            }
        }
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

        /// <summary>
        /// Populates the double array.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, System.EventArgs e)
        {
            //create some sample data
            this.nRows = r.Next(10) + 2;
            this.nCols = r.Next(3) + 1;
            double[,] a = new double[nRows, nCols];//{{1.1,2.1},{3.1,4.1}};
            for (int row = 0; row < nRows; ++row)
                for (int col = 0; col < nCols; ++col)
                    a[row, col] = ((double)r.Next(100)) / 10;

            //create a ArrayCalcData object and pass it this array
            this.data = new ArrayCalcData(a);

            //create an CalcEngine object using this ArrayCalcData object
            CalcEngine engine = new CalcEngine(this.data);

            //Turn on dependency tracking so values set with the Set button
            //take effect immediately
            engine.UseDependencies = true;

            //call RecalculateRange so any formulas in the data can be initially computed.
            engine.RecalculateRange(RangeInfo.Cells(1, 1, nRows + 1, nCols + 1), data);

            ShowObject();
        }

        /// <summary>
        /// Displays the ArrayCalcData values in a TextBox.
        /// </summary>
        private void ShowObject()
        {
            this.textBox1.Text = "";

            for (int i = 0; i <= this.nRows + 1; ++i)
            {
                for (int j = 0; j <= this.nCols + 1; ++j)
                {
                    if (j == 0)
                    {
                        if (i == this.nRows + 1)
                            this.textBox1.Text += "Sum" + "\t";
                        else
                            this.textBox1.Text += "\t";
                        continue;
                    }
                    if (i == 0)
                    {
                        if (j == this.nCols + 1)
                            this.textBox1.Text += "Sum";
                        else
                            this.textBox1.Text += "\t";
                    }
                    else
                        this.textBox1.Text += this.data[i - 1, j - 1].ToString() + "\t";
                }
                this.textBox1.Text += "\r\n";
            }
        }

        /// <summary>
        /// Populates a single entry in the ArrayCalcData object.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, System.EventArgs e)
        {
            if (this.nRows == 0)
            {
                MessageBox.Show("Generate data first.");
                return;
            }

            try
            {
                int row = int.Parse(this.textBox2.Text);
                int col = int.Parse(this.textBox3.Text);
                string val = this.textBox4.Text;
                if (nRows != row && nCols != col)
                {
                    this.data[row, col] = val;
                }
                else
                {
                    MessageBox.Show("Please enter a valid row and column index.\nThis field is belongs to Sum of the rows and columns");
                }

                ShowObject();
            }
            catch (IndexOutOfRangeException ex1)
            {
                MessageBox.Show("Please enter a valid row and column index.\r\nException: " + ex1.Message);
            }
            catch (FormatException ex2)
            {
                MessageBox.Show("Please enter a valid row and column index.\r\nException: " + ex2.Message);
            }
        }

        private void Form1_Load(object sender, System.EventArgs e)
        {
            if (Environment.CommandLine.EndsWith("automatedtest"))
            {
                this.button1.PerformClick();
                this.button2.PerformClick();
            }
        }
    }
}

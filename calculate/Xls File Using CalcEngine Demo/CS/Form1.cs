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
using System.Globalization;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

using Syncfusion.Calculate;
using Syncfusion.XlsIO;
using DemoCommon.Grid;
using Syncfusion.Windows.Forms;

namespace XlsFileUsingExcelRW
{
    /// <summary>
    /// Summary description for Form1.
    /// </summary>
    public class Form1 : GridDemoForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
       

        public Form1()
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

        #region Windows Form Designer stuffs
        /// <summary>
        /// Required method for Designer support; do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.numericUpDownAge = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownPoints = new System.Windows.Forms.NumericUpDown();
            this.comboBoxSex = new System.Windows.Forms.ComboBox();
            this.button1 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.comboBoxState = new System.Windows.Forms.ComboBox();
            this.comboBoxModel = new System.Windows.Forms.ComboBox();
            this.numericUpDownModelYear = new System.Windows.Forms.NumericUpDown();
            this.checkBoxMultipleCars = new System.Windows.Forms.CheckBox();
            this.textBoxBaseAmount = new System.Windows.Forms.TextBox();
            this.labelPrice = new System.Windows.Forms.Label();
            this.button2 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPoints)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownModelYear)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(47, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Age";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(47, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sex";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(47, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "State";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(47, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Points";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(47, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "Model";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(47, 175);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 23);
            this.label6.TabIndex = 5;
            this.label6.Text = "Model Year";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(11, 207);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(136, 23);
            this.label7.TabIndex = 6;
            this.label7.Text = "Discount for multiple cars";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(47, 239);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 23);
            this.label8.TabIndex = 7;
            this.label8.Text = "Base Amount";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // numericUpDownAge
            // 
            this.numericUpDownAge.Location = new System.Drawing.Point(163, 14);
            this.numericUpDownAge.Maximum = new decimal(new int[] {
            90,
            0,
            0,
            0});
            this.numericUpDownAge.Minimum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.numericUpDownAge.Name = "numericUpDownAge";
            this.numericUpDownAge.Size = new System.Drawing.Size(48, 20);
            this.numericUpDownAge.TabIndex = 9;
            this.numericUpDownAge.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            // 
            // numericUpDownPoints
            // 
            this.numericUpDownPoints.Location = new System.Drawing.Point(163, 111);
            this.numericUpDownPoints.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.numericUpDownPoints.Name = "numericUpDownPoints";
            this.numericUpDownPoints.Size = new System.Drawing.Size(48, 20);
            this.numericUpDownPoints.TabIndex = 10;
            // 
            // comboBoxSex
            // 
            this.comboBoxSex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSex.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.comboBoxSex.Location = new System.Drawing.Point(163, 46);
            this.comboBoxSex.Name = "comboBoxSex";
            this.comboBoxSex.Size = new System.Drawing.Size(64, 21);
            this.comboBoxSex.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.button1.BeforeTouchSize = new System.Drawing.Size(184, 23);
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.IsBackStageButton = false;
            this.button1.Location = new System.Drawing.Point(272, 38);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(184, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Compute Annual Premium";
            this.button1.UseVisualStyle = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBoxState
            // 
            this.comboBoxState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxState.Items.AddRange(new object[] {
            "AL",
            "AK",
            "AZ",
            "AR",
            "CA",
            "CO",
            "CT",
            "DE",
            "FL",
            "GA",
            "HI",
            "ID",
            "IL",
            "IN",
            "IA",
            "KA",
            "KY",
            "LA",
            "ME",
            "MD",
            "MA",
            "MI",
            "MN",
            "MS",
            "MO",
            "MT",
            "NE",
            "NV",
            "NH",
            "NJ",
            "NM",
            "NY",
            "NC",
            "ND",
            "OH",
            "OK",
            "OR",
            "PA",
            "RI",
            "SC",
            "SD",
            "TN",
            "TX",
            "UT",
            "VT",
            "VA",
            "WA",
            "WV",
            "WI",
            "WY"});
            this.comboBoxState.Location = new System.Drawing.Point(163, 78);
            this.comboBoxState.Name = "comboBoxState";
            this.comboBoxState.Size = new System.Drawing.Size(64, 21);
            this.comboBoxState.TabIndex = 13;
            // 
            // comboBoxModel
            // 
            this.comboBoxModel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxModel.Items.AddRange(new object[] {
            "Ford",
            "Chevrolet",
            "Buick",
            "Toyota",
            "BMW",
            "Mercedes",
            "Honda",
            "Hundai",
            "Mitsubishu",
            "Cadilac",
            "Lexis"});
            this.comboBoxModel.Location = new System.Drawing.Point(163, 143);
            this.comboBoxModel.Name = "comboBoxModel";
            this.comboBoxModel.Size = new System.Drawing.Size(80, 21);
            this.comboBoxModel.TabIndex = 14;
            // 
            // numericUpDownModelYear
            // 
            this.numericUpDownModelYear.Location = new System.Drawing.Point(163, 175);
            this.numericUpDownModelYear.Maximum = new decimal(new int[] {
            2005,
            0,
            0,
            0});
            this.numericUpDownModelYear.Minimum = new decimal(new int[] {
            1972,
            0,
            0,
            0});
            this.numericUpDownModelYear.Name = "numericUpDownModelYear";
            this.numericUpDownModelYear.Size = new System.Drawing.Size(48, 20);
            this.numericUpDownModelYear.TabIndex = 15;
            this.numericUpDownModelYear.Value = new decimal(new int[] {
            2004,
            0,
            0,
            0});
            // 
            // checkBoxMultipleCars
            // 
            this.checkBoxMultipleCars.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.checkBoxMultipleCars.Location = new System.Drawing.Point(163, 207);
            this.checkBoxMultipleCars.Name = "checkBoxMultipleCars";
            this.checkBoxMultipleCars.Size = new System.Drawing.Size(16, 24);
            this.checkBoxMultipleCars.TabIndex = 16;
            // 
            // textBoxBaseAmount
            // 
            this.textBoxBaseAmount.Location = new System.Drawing.Point(163, 239);
            this.textBoxBaseAmount.Name = "textBoxBaseAmount";
            this.textBoxBaseAmount.Size = new System.Drawing.Size(48, 20);
            this.textBoxBaseAmount.TabIndex = 17;
            this.textBoxBaseAmount.Text = "600";
            // 
            // labelPrice
            // 
            this.labelPrice.Location = new System.Drawing.Point(320, 80);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(128, 64);
            this.labelPrice.TabIndex = 18;
            // 
            // button2
            // 
            this.button2.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.button2.BeforeTouchSize = new System.Drawing.Size(184, 23);
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.IsBackStageButton = false;
            this.button2.Location = new System.Drawing.Point(272, 159);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(184, 23);
            this.button2.TabIndex = 19;
            this.button2.Text = "Auto Process with Random Inputs";
            this.button2.UseVisualStyle = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.comboBoxModel);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.comboBoxState);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.comboBoxSex);
            this.panel1.Controls.Add(this.numericUpDownAge);
            this.panel1.Controls.Add(this.textBoxBaseAmount);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.checkBoxMultipleCars);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.numericUpDownModelYear);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.numericUpDownPoints);
            this.panel1.Location = new System.Drawing.Point(14, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(490, 269);
            this.panel1.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(309, 73);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(125, 69);
            this.label9.TabIndex = 21;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.CaptionFont = new System.Drawing.Font("Segoe UI", 18F);
            this.ClientSize = new System.Drawing.Size(516, 286);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelPrice);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(528, 332);
            this.Name = "Form1";
            this.Text = "Xls File Using CalcEngine ";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPoints)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownModelYear)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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

        #region API Definitions
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown numericUpDownAge;
        private ButtonAdv button1;
        private System.Windows.Forms.ComboBox comboBoxSex;
        private System.Windows.Forms.ComboBox comboBoxState;
        private System.Windows.Forms.ComboBox comboBoxModel;
        private System.Windows.Forms.NumericUpDown numericUpDownModelYear;
        private System.Windows.Forms.CheckBox checkBoxMultipleCars;
        private System.Windows.Forms.TextBox textBoxBaseAmount;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.NumericUpDown numericUpDownPoints;
        private ButtonAdv button2;
        private IContainer components;
        private Panel panel1;
        private Label label9;
        private XlsIOCalcWorkbook calcWB;
        #endregion

        private void Form1_Load(object sender, System.EventArgs e)
        {
#if !NETCORE
            calcWB = XlsIOCalcWorkbook.CreateFromXLS(@"..\..\..\CarIns.xls");
#else
            calcWB = XlsIOCalcWorkbook.CreateFromXLS(@"..\..\..\..\CarIns.xls");
#endif
            this.calcWB.Engine.LockDependencies = false;
            this.calcWB.CalculateAll();
            this.calcWB.Engine.LockDependencies = true;

            //Set some initial values on the form:
            this.comboBoxSex.SelectedIndex = 0;
            this.comboBoxState.SelectedIndex = 0;
            this.comboBoxModel.SelectedIndex = 0;

            if (Environment.CommandLine.EndsWith("automatedtest"))
            {
                this.button1.PerformClick();
            }

        }

#region [variable Declaration]
        private int ageRow = 3;
        private int sexRow = 4;
        private int stateRow = 5;
        private int pointsRow = 6;
        private int modelRow = 7;
        private int modelYearRow = 8;
        private int multipleDiscountRow = 9;
#endregion

        //Set the input values into the CalcSheets:
        private void SetSheetInputs()
        {
            CalcSheet inputSheet = this.calcWB["Inputs"];
            inputSheet[ageRow, 2] = this.numericUpDownAge.Value.ToString();
            inputSheet[sexRow, 2] = this.comboBoxSex.Text[0].ToString();
            inputSheet[stateRow, 2] = this.comboBoxState.Text;
            inputSheet[pointsRow, 2] = this.numericUpDownPoints.Value.ToString();
            inputSheet[modelRow, 2] = this.comboBoxModel.Text;
            inputSheet[modelYearRow, 2] = this.numericUpDownModelYear.Value.ToString();
            inputSheet[multipleDiscountRow, 2] = this.checkBoxMultipleCars.Checked ? "Yes" : "No";
            inputSheet[3, 5] = this.textBoxBaseAmount.Text;
        }
#region [Event Handlers]
        private void button1_Click(object sender, System.EventArgs e)
        {
            //Initialize calcsheet with input values from the form:
            SetSheetInputs();

            // Calculations not suspended so just getting the value triggers the computation,
            // so these two lines are not needed.....
            //this.calcWB.Engine.UpdateCalcID();
            //this.calcWB.Engine.PullUpdatedValue(this.calcWB.GetSheetID("Outputs"), 1, 1);

            //Get the value from cell 1,1 on the output sheet:
            double d;
            if (double.TryParse(calcWB["Outputs"][1, 1].ToString(), NumberStyles.Any, null, out d))
            {
                //Cell 1,1 on the output sheet has the result:
                this.label9.Text = string.Format("{0:C2}", d);
            }
            else
                this.label9.Text = "---";

        }

        //Do the calculation multiple times:
        private void button2_Click(object sender, System.EventArgs e)
        {
            //Run 1000 interations:
            int num = 1000;

            this.Cursor = Cursors.WaitCursor;
            DateTime start = DateTime.Now;
            CalcSheet inputSheet = this.calcWB["Inputs"];
            Random r = new Random();

            this.calcWB.Engine.CalculatingSuspended = true;

            for (int i = 0; i < num; ++i)
            {
                //1) Set random values into the Inputs sheet:
                inputSheet[ageRow, 2] = (r.Next(74) + 15).ToString();
                inputSheet[sexRow, 2] = r.Next(2) == 1 ? "M" : "F";
                inputSheet[stateRow, 2] = this.comboBoxState.Items[r.Next(50)];
                inputSheet[pointsRow, 2] = r.Next(15).ToString();
                inputSheet[modelRow, 2] = r.Next(11).ToString();
                inputSheet[modelYearRow, 2] = (33 + r.Next(1972)).ToString();
                inputSheet[multipleDiscountRow, 2] = r.Next(2) == 1 ? "Yes" : "No";
                inputSheet[3, 5] = this.textBoxBaseAmount.Text;

                //2) Calculations are suspended so need to pull the computed value to
                //make sure it has been calculated with the latest changes:
                this.calcWB.Engine.UpdateCalcID();
                this.calcWB.Engine.PullUpdatedValue(this.calcWB.GetSheetID("Outputs"), 1, 1);

                //3) Get the value from cell 1,1 on the output sheet:
                double d;
                if (double.TryParse(calcWB["Outputs"][1, 1].ToString(), NumberStyles.Any, null, out d))
                {
                    this.label9.Text = string.Format("{0:C2}", d); //cell 1,1 on the outputs sheet has the result
                }
                else
                    this.label9.Text = "---";

                //Allow the label to update:
                this.label9.Refresh();
            }
            this.calcWB.Engine.CalculatingSuspended = false;
            this.Cursor = Cursors.Default;
            this.label9.Text = string.Format("{0} updates in {1} seconds", num, (TimeSpan)(DateTime.Now - start));
        }
#endregion
    }
}

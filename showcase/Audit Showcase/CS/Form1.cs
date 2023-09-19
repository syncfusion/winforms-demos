#region Copyright Syncfusion Inc. 2001-2023.
// Copyright Syncfusion Inc. 2001-2023. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Syncfusion.PMML;
using Syncfusion.Windows.Forms;
using Syncfusion.WinForms.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Audit_Showcase_sample
{
    public partial class Form1 : SfForm
    {
        #region Constructor

        public Form1()
        {
            InitializeComponent();
            LoadComboBoxCollection();           
            this.SizeChanged += Form1_SizeChanged;
            this.MinimumSize = new Size(this.getInfoPanel.Width + this.gradientPanel1.Width, this.gradientPanel1.Height + this.Style.TitleBar.Height + this.gradientPanel1.Margin.Top + this.gradientPanel1.Margin.Bottom);
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            this.auditDescription.Width = this.ClientRectangle.Width - this.gradientPanel1.Margin.Left - this.gradientPanel1.Width - this.gradientPanel1.Margin.Right;
            this.gradientPanel1.Location = new Point(getInfoPanel.Width + this.gradientPanel1.Margin.Left, this.gradientPanel1.Margin.Top);
        }

        #endregion

        #region Methods

        private void LoadComboBoxCollection()
        {
            List<string> GenderCollectionItems = new List<string>();
            GenderCollectionItems.Add("Male");
            GenderCollectionItems.Add("Female");
            GenderCollection.DataSource = GenderCollectionItems;
            GenderCollection.SelectedIndex = 1;

            List<string> EmploymentCollectionItems = new List<string>();
            EmploymentCollectionItems.Add("Consultant");
            EmploymentCollectionItems.Add("Private");
            EmploymentCollectionItems.Add("PSFederal");
            EmploymentCollectionItems.Add("PSLocal");
            EmploymentCollectionItems.Add("PSState");
            EmploymentCollectionItems.Add("SelfEmp");
            EmploymentCollectionItems.Add("Volunteer");
            EmploymentCollection.DataSource = EmploymentCollectionItems;
            EmploymentCollection.SelectedIndex = 1;

            List<string> EducationCollectionItems = new List<string>();
            EducationCollectionItems.Add("Associate");
            EducationCollectionItems.Add("Bachelor");
            EducationCollectionItems.Add("College");
            EducationCollectionItems.Add("Doctorate");
            EducationCollectionItems.Add("HSgrad");
            EducationCollectionItems.Add("Master");
            EducationCollectionItems.Add("Preschool");
            EducationCollectionItems.Add("Professional");
            EducationCollectionItems.Add("Vocational");
            EducationCollectionItems.Add("Yr9");
            EducationCollectionItems.Add("Yr10");
            EducationCollectionItems.Add("Yr11");
            EducationCollectionItems.Add("Yr12");
            EducationCollectionItems.Add("Yr1t4");
            EducationCollectionItems.Add("Yr5t6");
            EducationCollectionItems.Add("Yr7t8");
            EducationCollection.DataSource = EducationCollectionItems;
            EducationCollection.SelectedIndex = 2;

            List<string> MaritalCollectionItems = new List<string>();
            MaritalCollectionItems.Add("Absent");
            MaritalCollectionItems.Add("Divorced");
            MaritalCollectionItems.Add("Married");
            MaritalCollectionItems.Add("Married-spouse-absent");
            MaritalCollectionItems.Add("Unmarried");
            MaritalCollectionItems.Add("Widowed");
            MaritalCollection.DataSource = MaritalCollectionItems;
            MaritalCollection.SelectedIndex = 2;           

            List<string> OccupationCollectionItems = new List<string>();
            OccupationCollectionItems.Add("Cleaner");
            OccupationCollectionItems.Add("Clerical");
            OccupationCollectionItems.Add("Executive");
            OccupationCollectionItems.Add("Farming");
            OccupationCollectionItems.Add("Home");
            OccupationCollectionItems.Add("Machinist");
            OccupationCollectionItems.Add("Military");
            OccupationCollectionItems.Add("Professional");
            OccupationCollectionItems.Add("Protective");
            OccupationCollectionItems.Add("Repair");
            OccupationCollectionItems.Add("Sales");
            OccupationCollectionItems.Add("Service");
            OccupationCollectionItems.Add("Support");
            OccupationCollectionItems.Add("Transport");
            OccupationCollection.DataSource = OccupationCollectionItems;
            OccupationCollection.SelectedIndex = 0;

            List<string> AccountsCollectionItems = new List<string>();
            AccountsCollectionItems.Add("Canada");
            AccountsCollectionItems.Add("China");
            AccountsCollectionItems.Add("Columbia");
            AccountsCollectionItems.Add("Cuba");
            AccountsCollectionItems.Add("Ecuador");
            AccountsCollectionItems.Add("England");
            AccountsCollectionItems.Add("Fiji");
            AccountsCollectionItems.Add("Germany");
            AccountsCollectionItems.Add("Greece");
            AccountsCollectionItems.Add("Guatemala");
            AccountsCollectionItems.Add("Hong");
            AccountsCollectionItems.Add("Hungary");
            AccountsCollectionItems.Add("India");
            AccountsCollectionItems.Add("Indonesia");
            AccountsCollectionItems.Add("Iran");
            AccountsCollectionItems.Add("Ireland");
            AccountsCollectionItems.Add("Italy");
            AccountsCollectionItems.Add("Jamaica");
            AccountsCollectionItems.Add("Japan");
            AccountsCollectionItems.Add("Malaysia");
            AccountsCollectionItems.Add("Mexico");
            AccountsCollectionItems.Add("NewZealand");
            AccountsCollectionItems.Add("Nicaragua");
            AccountsCollectionItems.Add("Philippines");
            AccountsCollectionItems.Add("Poland");
            AccountsCollectionItems.Add("Portugal");
            AccountsCollectionItems.Add("Scotland");
            AccountsCollectionItems.Add("Singapore");
            AccountsCollectionItems.Add("Taiwan");
            AccountsCollectionItems.Add("UnitedStates");
            AccountsCollectionItems.Add("Vietnam");
            AccountsCollectionItems.Add("Yugoslavia");
            AccountsCollection.DataSource = AccountsCollectionItems;
            AccountsCollection.SelectedIndex = 0;
        }

        #endregion

        #region Events

        private void button_Click(object sender, EventArgs e)
        {
            PMMLEvaluator evaluator = new PMMLEvaluatorFactory().
                GetPMMLEvaluatorInstance(new PMMLDocument(new MemoryStream(Encoding.ASCII.GetBytes(File.ReadAllText("Data/Audit.pmml")))));

            //Create and anonymous type for audit record
            var audit = new
            {
                ID = 0,
                Age = AgeTextValue.Text.Trim() != "" ? AgeTextValue.Text : "20",
                Employment = EmploymentCollection.SelectedItem,
                Education = EducationCollection.SelectedItem,
                Marital = MaritalCollection.SelectedItem,
                Occupation = OccupationCollection.SelectedItem,
                Income = IncomeTextValue.Text.Trim() != "" ? IncomeTextValue.Text.ToString() : "20000",
                Sex = GenderCollection.SelectedItem,
                Deductions = DeductionTextValue.Text.Trim() != "" ? DeductionTextValue.Text.ToString() : "10000",
                Hours = HoursTextValue.Text.Trim() != "" ? HoursTextValue.Text.ToString() : "12",
                Accounts = AccountsCollection.SelectedItem,
                Adjustment = 0
            };

            //Get predicted result
            PredictedResult predictedResult = evaluator.GetResult(audit, null);
            //Get predicted category 0 or 1
            string auditPredicted = (predictedResult.PredictedValue != null) ? predictedResult.PredictedValue.ToString() : "-";

            // Display result based on predicted category
            thumb.Image = auditPredicted == "0" ? Image.FromFile("Images/thumb_yes.png") : Image.FromFile("Images/thumb_no.png");
            AuditPredicted.Text = auditPredicted == "0" ? "YES!" : "NO!";
            PredictedText.Text = auditPredicted == "0" ? "Your audit risk is low." : "Your audit risk is high.";
        }
        #endregion   
        }
}

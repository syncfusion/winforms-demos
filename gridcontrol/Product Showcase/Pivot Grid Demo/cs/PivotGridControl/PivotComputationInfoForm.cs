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
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PivotGridLibrary
{
    public partial class PivotComputationInfoForm : Form
    {
        public PivotComputationInfoForm()
        {
            InitializeComponent();

            listBox1.DataSource = Choices;

            listBox1.SelectedIndexChanged += new EventHandler(listBox1_SelectedIndexChanged);
            
        }

        void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            PivotComputationInfo info = listBox1.SelectedItem as PivotComputationInfo;
            if (info != null)
            {
                this.textBoxDescription.Text = string.Format(pivotGrid.DefaultDescriptionFormat, info.CalculationName, ComputationInfo.FieldName);
            }
        }

        private void PivotComputationInfoForm_Load(object sender, EventArgs e)
        {
           
            MoveComputationInfoToForm();
       }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            if (DialogResult != DialogResult.Cancel)
            {
                MoveComputationInfoFromForm();
            }
        }

        private void MoveComputationInfoFromForm()
        {
            this.ComputationInfo.Description = textBoxDescription.Text;
            this.ComputationInfo.Format = textBoxFormat.Text;
            PivotComputationInfo info = listBox1.SelectedItem as PivotComputationInfo;
            if(info != null)
            {
                this.ComputationInfo.Summary = info.Summary;
                this.ComputationInfo.Pd = info.Pd;
             //   this.ComputationInfo.FieldName = info.FieldName;  cnnot change the FieldName
                this.ComputationInfo.CalculationName = info.CalculationName;
            }
            
        }

        private void MoveComputationInfoToForm()
        {
            textBoxDescription.Text = this.ComputationInfo.Description;
            textBoxFormat.Text = this.ComputationInfo.Format;
            labelName.Text = this.ComputationInfo.FieldName;
            int loc;
            if (Choices.Find(this.ComputationInfo.CalculationName, out loc) != null)
            {
                listBox1.SelectedIndex = loc;
            }
        }

        PivotComputationInfoList choices;

        public virtual PivotComputationInfoList Choices
        {
            get 
            {
                if (choices == null)
                {
                    choices = new PivotComputationInfoList();
                    choices.PopulateWithListChoices();
                }
                return choices; 
            }
           
        }


        PivotGridControl pivotGrid;

        internal PivotGridControl PivotGrid
        {
            get { return pivotGrid; }
            set { pivotGrid = value; }
        }

        PivotComputationInfo computationInfo;

        internal PivotComputationInfo ComputationInfo
        {
            get { return computationInfo; }
            set { computationInfo = value; }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Close();
        }

    }
}
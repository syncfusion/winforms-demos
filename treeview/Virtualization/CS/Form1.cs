#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Syncfusion.Windows.Forms;
using Syncfusion.Windows.Forms.Tools;
using Syncfusion.WinForms.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Virtualization_Demo
{
    public partial class Form1 : SfForm
    {
        #region Constuctor
        /// <summary>
        /// Initialize the new instance of Form.
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }
        #endregion

        #region Fields

        /// <summary>
        /// Indicates whether the Collection Changed event is triggered or not.
        /// </summary>
        bool isSelectedChangedCalled = false;

        /// <summary>
        /// Represents the number of nodes loaded in TreeViewAdv
        /// </summary>
        private int NodeCount = 0;

        #endregion

        #region Methods

        /// <summary>
        /// Represents a method which populate the ComboBox.
        /// </summary>
        private void PopulateNodeCountComboBox()
        {
            List<string> comboboxitems = new List<string>();
            comboboxitems.Add("10K");
            comboboxitems.Add("20K");
            comboboxitems.Add("50K");
            comboboxitems.Add("100K");
            comboboxitems.Add("200K");

            nodeCount_ComboBox.DataSource = comboboxitems;
        }
        #endregion

        #region Events

        /// <summary>
        /// Represents a Form_Load event.
        /// </summary>
        /// <param name="sender">Form</param>
        /// <param name="e">Event Arguments</param>
        private void Form1_Load(object sender, EventArgs e)
        {
            // Set Office 2019 theme for all the syncfusion controls in the form.

            expandOnLoad_checkBoxAdv.ThemeName = "Office2019Colorful";

            showCheckBox_CheckBoxAdv.ThemeName = "Office2019Colorful";

            nodeCount_ComboBox.ThemeName = "Office2019Colorful";

            load_Button.ThemeName = "Office2019Colorful";

            treeViewAdv1.ThemeName = "Office2019Colorful";

            treeViewAdv1.LeftImageList = leftImageList;

            treeViewAdv1.ShouldSelectNodeOnEnter = false;

            treeViewAdv1.ItemHeight = 25;

            PopulateNodeCountComboBox();

            nodeCount_ComboBox.SelectedIndex = 3;
        }  

        /// <summary>
        /// Represents a SelectedIndexChanged event of SfComboBox.
        /// </summary>
        /// <param name="sender">SfComboBox</param>
        /// <param name="e">Event Arguments</param>
        private void nodeCount_Combobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            isSelectedChangedCalled = true;
            if(nodeCount_ComboBox.SelectedIndex == 0)
            {
                NodeCount = 10000;
            }
            else if(nodeCount_ComboBox.SelectedIndex == 1)
            {
                NodeCount = 20000;
            }
            else if (nodeCount_ComboBox.SelectedIndex == 2)
            {
                NodeCount = 50000;
            }
            else if (nodeCount_ComboBox.SelectedIndex == 3)
            {
                NodeCount = 100000;
            }
            else 
            {
                NodeCount = 200000;
            }
        }

        /// <summary>
        /// Represents a CheckStateChanged Event of CheckBoxAdv control.
        /// </summary>
        /// <param name="sender">CheckBoxAdv</param>
        /// <param name="e">Event Arguments</param>
        private void showCheckBox_CheckBoxAdv_CheckStateChanged(object sender, EventArgs e)
        {
            if(showCheckBox_CheckBoxAdv.Checked)
            {
                treeViewAdv1.ShowCheckBoxes = true;
            }
            else
            {
                treeViewAdv1.ShowCheckBoxes = false;
            }
        }

        /// <summary>
        /// Represents a click event of SfButton control.
        /// </summary>
        /// <param name="sender">SfButton</param>
        /// <param name="e">Event Argument</param>
        private void load_Button_Click(object sender, EventArgs e)
        {
            if (isSelectedChangedCalled)
                treeViewAdv1.Nodes.Clear();
                        
            int imax = NodeCount / 100;

            DateTime startTime = DateTime.Now;

            treeViewAdv1.ShowLines = false;

            treeViewAdv1.BeginInvoke((System.Action)(() => {
                for (int i = 1; i <= imax; i++)
                {
                    TreeNodeAdv treeNodeAdv = new TreeNodeAdv("Parent Item - " + i);
                    
                    //treeNodeAdv.LeftImageIndices = new int[] { 0 };

                    if (expandOnLoad_checkBoxAdv.Checked)
                    {
                        treeNodeAdv.Expanded = true;
                    }

                    for (int j = 1; j <= 10; j++)
                    {
                        TreeNodeAdv child = new TreeNodeAdv("Sub Item - " + j);
                        
                        //child.LeftImageIndices = new int[] { 0 };

                        if (expandOnLoad_checkBoxAdv.Checked)
                        {
                            child.Expanded = true;
                        }

                        for (int k = 1; k <= 10; k++)
                        {
                            TreeNodeAdv nestedchild = new TreeNodeAdv("Item - " + k);

                            //nestedchild.LeftImageIndices = new int[] { 0 };

                            child.Nodes.Add(nestedchild);
                        }

                        treeNodeAdv.Nodes.Add(child);
                    }

                    treeViewAdv1.Nodes.Add(treeNodeAdv);
                }
                
                this.timeTakenLabel.Text = ("Loaded in " + Math.Round((DateTime.Now - startTime).TotalMilliseconds,2) + " milliseconds");
            }));
        }
        #endregion
    }
}

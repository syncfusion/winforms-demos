#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Drawing;
using System.Windows.Forms;
using Syncfusion.Windows.Forms.Tools;

namespace RibbonCustomization
{
    public partial class Form1 : RibbonForm
    {
        Syncfusion.Windows.Forms.Tools.ToolStripTabGroup toolStripTabGroup1 = new Syncfusion.Windows.Forms.Tools.ToolStripTabGroup();
        public Form1()
        {
            InitializeComponent();
            foreach (ToolStripTabItem items in this.ribbonControlAdv1.Header.MainItems)
            {
                foreach (ToolStripEx item in items.Panel.Controls)
                {
                    item.LauncherClick += new EventHandler(item_LauncherClick);
                }
            }
            PopulateColorTable();
            PopulateTabGroup();
            this.toolStripCheckBox3.Checked = true;
            this.toolStripCheckBox4.Checked = this.ShowApplicationIcon;
        }

        /// <summary>
        /// This event raises when the launcher is clicked
        /// </summary>
        /// <param name="sender">Instance of the Object</param>
        /// <param name="e">Contains data for the source</param>
        void item_LauncherClick(object sender, EventArgs e)
        {
            MessageBox.Show("Launcher is clicked", "Launcher");
        }
       
        private void Form1_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.Padding = new Padding(1);
        }

        #region Avoid flickering
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;   // WS_EX_COMPOSITED
                return cp;
            }
        }
        #endregion

        #region Color table
        Syncfusion.Windows.Forms.Tools.Office2016ColorTable office2016ColorTable1 = new Syncfusion.Windows.Forms.Tools.Office2016ColorTable();
        Syncfusion.Windows.Forms.Tools.Office2016ColorTable office2016ColorTable2 = new Syncfusion.Windows.Forms.Tools.Office2016ColorTable();
        Syncfusion.Windows.Forms.Tools.Office2016ColorTable office2016ColorTable3 = new Syncfusion.Windows.Forms.Tools.Office2016ColorTable();

        private void PopulateColorTable()
        {
            office2016ColorTable1.CheckedTabForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(25)))), ((int)(((byte)(170)))));
            office2016ColorTable1.HeaderColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(25)))), ((int)(((byte)(170)))));
            office2016ColorTable1.HoverCollapsedDropDownButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            office2016ColorTable1.QATDropDownForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            office2016ColorTable1.QuickDropDownPressedcolor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(18)))), ((int)(((byte)(118)))));
            office2016ColorTable1.QuickDropDownSelectedcolor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(29)))), ((int)(((byte)(197)))));
            office2016ColorTable1.SelectedTabColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(29)))), ((int)(((byte)(197)))));
            office2016ColorTable1.SplitButtonBackgroundPressed = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(18)))), ((int)(((byte)(118)))));
            office2016ColorTable1.SplitButtonBackgroundSelected = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(29)))), ((int)(((byte)(197)))));
            office2016ColorTable1.SystemButtonBackground=office2016ColorTable1.TabGroupBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(29)))), ((int)(((byte)(197)))));
            office2016ColorTable1.TabBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(25)))), ((int)(((byte)(170)))));
            office2016ColorTable2.CheckedTabForeColor = office2016ColorTable2.TabGroupForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(115)))), ((int)(((byte)(70)))));
            office2016ColorTable2.HeaderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(115)))), ((int)(((byte)(70)))));
            office2016ColorTable2.HoverCollapsedDropDownButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            office2016ColorTable2.QATDropDownForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            office2016ColorTable2.QuickDropDownSelectedcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(158)))), ((int)(((byte)(97)))));
            office2016ColorTable2.SelectedTabColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(158)))), ((int)(((byte)(97)))));
            office2016ColorTable2.SystemButtonBackground= office2016ColorTable2.TabGroupBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(158)))), ((int)(((byte)(97)))));
            office2016ColorTable2.TabBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(115)))), ((int)(((byte)(70)))));
            office2016ColorTable3.HoverCollapsedDropDownButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            office2016ColorTable3.QATDropDownForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));

        }
        private void toolStripComboBoxEx1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.ribbonControlAdv1.Office2016ColorTable.Clear();
            if(toolStripComboBoxEx1.SelectedIndex==0)
            {
                this.ribbonControlAdv1.Office2016ColorTable.Add(office2016ColorTable3);
                this.ribbonControlAdv1.MenuColor = Color.FromArgb(0, 114, 198);
            }
            else if (toolStripComboBoxEx1.SelectedIndex == 1)
            {
                this.ribbonControlAdv1.Office2016ColorTable.Add(office2016ColorTable1);
                this.ribbonControlAdv1.MenuColor = Color.FromArgb(119, 25, 169);
            }
            else if (toolStripComboBoxEx1.SelectedIndex == 2)
            {
                this.ribbonControlAdv1.Office2016ColorTable.Add(office2016ColorTable2);
                this.ribbonControlAdv1.MenuColor = Color.FromArgb(33, 115, 70);
            }
        }

       
        #endregion

        private void toolStripCheckBox4_CheckedChanged(object sender, EventArgs e)
        {
            this.ShowApplicationIcon = this.toolStripCheckBox4.Checked;
        }

        private void PopulateTabGroup()
        {
            toolStripTabGroup1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(70)))), ((int)(((byte)(122)))));
            toolStripTabGroup1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            toolStripTabGroup1.Name = "Correction";
            toolStripTabGroup1.Visible = true;
            this.ribbonControlAdv1.TabGroups.Add(toolStripTabGroup1);
            this.ribbonControlAdv1.TabGroups.SetTabGroup(toolStripTabItem3, toolStripTabGroup1);
        }
        private void toolStripCheckBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (toolStripCheckBox3.Checked)
            {
                this.ribbonControlAdv1.TabGroups.SetTabGroup(this.toolStripTabItem3, this.toolStripTabGroup1);
            }
            else
            {
                this.ribbonControlAdv1.TabGroups.SetTabGroup(this.toolStripTabItem3, null);
            }
        }

        private void CustomSystemButtons()
        {
            //Instance to create custom button
            RibbonTitleButton button1 = new RibbonTitleButton();
            // Sets the image for the Custom button
#if NETCORE
            button1.Image = Image.FromFile("..//..//..//Images/Minimize-WF.png");
#else
            button1.Image = Image.FromFile("..//..//Images/Minimize-WF.png");
#endif
            // Sets the tooltip text for the custom button 
            button1.ToolTipText = "Minimize form";
            // Sets the Hover backcolor for the custom button
            // Assigns the button to the RibbonControlAdv.
            this.ribbonControlAdv1.MinimizeButton = button1;

            //Instance to create custom button
            RibbonTitleButton button2 = new RibbonTitleButton();
            // Sets the image for the Custom button
#if NETCORE
            button2.Image = Image.FromFile("..//..//..//Images/Maximize3-WF.png");
#else
             button2.Image = Image.FromFile("..//..//Images/Maximize3-WF.png");
#endif
            // Sets the tooltip text for the custom button 
            button2.ToolTipText = "Max form";
            // Sets the Hover backcolor for the custom button
            // Assigns the button to the RibbonControlAdv.
            this.ribbonControlAdv1.MaximizeButton = button2;

            //Instance to create custom button
            RibbonTitleButton button3 = new RibbonTitleButton();
            // Sets the image for the Custom button
#if NETCORE
            button3.Image = Image.FromFile("..//..//..//Images/Restore-01.png");
#else
             button3.Image = Image.FromFile("..//..//Images/Restore-01.png");
#endif
            // Sets the tooltip text for the custom button 
            button3.ToolTipText = "Restore form";
            // Sets the Hover backcolor for the custom button
            // Assigns the button to the RibbonControlAdv.
            this.ribbonControlAdv1.RestoreButton = button3;

            //Instance to create custom button
            RibbonTitleButton button4 = new RibbonTitleButton();
            // Sets the image for the Custom button
#if NETCORE
            button4.Image = Image.FromFile("..//..//..//Images/Close.png");
#else
             button4.Image = Image.FromFile("..//..//Images/Close.png");
#endif
            // Sets the tooltip text for the custom button 
            button4.ToolTipText = "Close form";
            // Sets the Hover backcolor for the custom button
            button4.HoverBackColor = Color.Red;
            // Assigns the button to the RibbonControlAdv.
            this.ribbonControlAdv1.CloseButton = button4;
        }

        private void toolStripRadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (toolStripRadioButton1.Checked)
            {
                CustomSystemButtons();
            }
            else
            {
                this.ribbonControlAdv1.MinimizeButton = this.ribbonControlAdv1.MaximizeButton = this.ribbonControlAdv1.CloseButton = this.ribbonControlAdv1.RestoreButton = null;
            }
        }
    }
}

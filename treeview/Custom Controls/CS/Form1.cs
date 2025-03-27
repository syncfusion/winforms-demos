#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Syncfusion.Windows.Forms;
using Syncfusion.Windows.Forms.Tools;
using Syncfusion.Windows.Forms.Tools.XPMenus;
using Syncfusion.WinForms.Controls;

namespace CustomControls_2005
{
    public partial class Form1 : SfForm
    {
        public Form1()
        {
            InitializeComponent();
            
            #region Default Grid Values
            this.gridControl1.RowCount = 10;
            this.gridControl2.RowCount = 10;
            this.gridControl3.RowCount = 10;
            #region Default Grid Values

            this.gridControl1[0, 0].Text = "S.No";
            this.gridControl2[0, 0].Text = "S.No";
            this.gridControl3[0, 0].Text = "S.No";
            this.gridControl1[0, 1].Text = "Country";
            this.gridControl2[0, 1].Text = "Country";
            this.gridControl3[0, 1].Text = "Country";
            this.gridControl1[0, 2].Text = "Year";
            this.gridControl2[0, 2].Text = "Year";
            this.gridControl3[0, 2].Text = "Year";
            this.gridControl1[0, 3].Text = "Population";
            this.gridControl2[0, 3].Text = "Population";
            this.gridControl3[0, 3].Text = "Population";
            this.gridControl1[1, 1].Text = "Mexico";
            this.gridControl2[1, 1].Text = "Belize";
            this.gridControl3[1, 1].Text = "Brazil";
            this.gridControl1[2, 1].Text = "Mexico";
            this.gridControl2[2, 1].Text = "Belize";
            this.gridControl3[2, 1].Text = "Brazil";
            this.gridControl1[3, 1].Text = "Mexico";
            this.gridControl2[3, 1].Text = "Belize";
            this.gridControl3[3, 1].Text = "Brazil";
            this.gridControl1[4, 1].Text = "Mexico";
            this.gridControl2[4, 1].Text = "Belize";
            this.gridControl3[4, 1].Text = "Brazil";
            this.gridControl1[5, 1].Text = "Mexico";
            this.gridControl2[5, 1].Text = "Belize";
            this.gridControl3[5, 1].Text = "Brazil";
            this.gridControl1[6, 1].Text = "Mexico";
            this.gridControl2[6, 1].Text = "Belize";
            this.gridControl3[6, 1].Text = "Brazil";
            this.gridControl1[7, 1].Text = "Mexico";
            this.gridControl2[7, 1].Text = "Belize";
            this.gridControl3[7, 1].Text = "Brazil";
            this.gridControl1[8, 1].Text = "Mexico";
            this.gridControl2[8, 1].Text = "Belize";
            this.gridControl3[8, 1].Text = "Brazil";
            this.gridControl1[9, 1].Text = "Mexico";
            this.gridControl2[9, 1].Text = "Belize";
            this.gridControl3[9, 1].Text = "Brazil";
            this.gridControl1[10, 1].Text = "Mexico";
            this.gridControl2[10, 1].Text = "Belize";
            this.gridControl3[10, 1].Text = "Brazil";

            this.gridControl1[1, 2].Text = "2005";
            this.gridControl2[1, 2].Text = "2005";
            this.gridControl3[1, 2].Text = "2005";
            this.gridControl1[2, 2].Text = "2006";
            this.gridControl2[2, 2].Text = "2006";
            this.gridControl3[2, 2].Text = "2006";
            this.gridControl1[3, 2].Text = "2007";
            this.gridControl2[3, 2].Text = "2007";
            this.gridControl3[3, 2].Text = "2007";
            this.gridControl1[4, 2].Text = "2008";
            this.gridControl2[4, 2].Text = "2008";
            this.gridControl3[4, 2].Text = "2008";
            this.gridControl1[5, 2].Text = "2009";
            this.gridControl2[5, 2].Text = "2009";
            this.gridControl3[5, 2].Text = "2009";
            this.gridControl1[6, 2].Text = "2010";
            this.gridControl2[6, 2].Text = "2010";
            this.gridControl3[6, 2].Text = "2010";
            this.gridControl1[7, 2].Text = "2011";
            this.gridControl2[7, 2].Text = "2011";
            this.gridControl3[7, 2].Text = "2011";
            this.gridControl1[8, 2].Text = "2012";
            this.gridControl2[8, 2].Text = "2012";
            this.gridControl3[8, 2].Text = "2012";
            this.gridControl1[9, 2].Text = "2013";
            this.gridControl2[9, 2].Text = "2013";
            this.gridControl3[9, 2].Text = "2013";
            this.gridControl1[10, 2].Text = "2014";
            this.gridControl2[10, 2].Text = "2014";
            this.gridControl3[10, 2].Text = "2014";

            this.gridControl1[1, 3].Text = "10.1 Million";
            this.gridControl2[1, 3].Text = "11.1 Million";
            this.gridControl3[1, 3].Text = "17.1 Million";
            this.gridControl1[2, 3].Text = "25.3 Million";
            this.gridControl2[2, 3].Text = "29.3 Million";
            this.gridControl3[2, 3].Text = "28.3 Million";
            this.gridControl1[3, 3].Text = "100.1 Million";
            this.gridControl2[3, 3].Text = "190.1 Million";
            this.gridControl3[3, 3].Text = "150.1 Million";
            this.gridControl1[4, 3].Text = "1.2 Billion";
            this.gridControl2[4, 3].Text = "1.3 Billion";
            this.gridControl3[4, 3].Text = "1.1 Billion";
            this.gridControl1[5, 3].Text = "224.3 Million";
            this.gridControl2[5, 3].Text = "194.3 Million";
            this.gridControl3[5, 3].Text = "294.3 Million";
            this.gridControl1[6, 3].Text = "678 Million";
            this.gridControl2[6, 3].Text = "456 Million";
            this.gridControl3[6, 3].Text = "374 Million";
            this.gridControl1[7, 3].Text = "389.3 Million";
            this.gridControl2[7, 3].Text = "569.3 Million";
            this.gridControl3[7, 3].Text = "239.3 Million";
            this.gridControl1[8, 3].Text = "686.6 Million";
            this.gridControl2[8, 3].Text = "676.6 Million";
            this.gridControl3[8, 3].Text = "786.6 Million";
            this.gridControl1[9, 3].Text = "891.2 Million";
            this.gridControl2[9, 3].Text = "861.2 Million";
            this.gridControl3[9, 3].Text = "781.2 Million";
            this.gridControl1[10, 3].Text = "719 Million";
            this.gridControl2[10, 3].Text = "709 Million";
            this.gridControl3[10, 3].Text = "711 Million";

            this.treeViewAdv1.Nodes[0].Nodes[0].Nodes[2].Nodes[0].Height = 222;
            this.treeViewAdv1.Nodes[0].Nodes[1].Nodes[2].Nodes[0].Height = 222;
            this.treeViewAdv1.Nodes[0].Nodes[2].Nodes[2].Nodes[0].Height = 222;
            this.treeViewAdv1.Nodes[0].Nodes[0].Nodes[2].Nodes[0].CustomControl.Location = new Point(2, 2);
            this.gridControl1.HScrollBehavior = Syncfusion.Windows.Forms.Grid.GridScrollbarMode.Disabled;
            this.gridControl2.HScrollBehavior = Syncfusion.Windows.Forms.Grid.GridScrollbarMode.Disabled;
            this.gridControl3.HScrollBehavior = Syncfusion.Windows.Forms.Grid.GridScrollbarMode.Disabled;
            comboBoxAdv1.SelectedIndex = 0;
            comboBoxAdv2.SelectedIndex = 0;
            comboBoxAdv3.SelectedIndex = 0;
            this.dateTimePickerAdv1.Value = DateTime.Now;
            this.dateTimePickerAdv2.Value = DateTime.Now;
            this.dateTimePickerAdv3.Value = DateTime.Now;
            this.treeViewAdv1.ThemeName = "Office2019Colorful";
            this.comboBoxAdv1.ThemeName = "Office2019Colorful";
            this.comboBoxAdv2.ThemeName = "Office2019Colorful";
            this.comboBoxAdv3.ThemeName = "Office2019Colorful";
            this.gridControl1.GridVisualStyles = GridVisualStyles.Office2016Colorful;
            this.gridControl2.GridVisualStyles = GridVisualStyles.Office2016Colorful;
            this.gridControl3.GridVisualStyles = GridVisualStyles.Office2016Colorful;
            this.dateTimePickerAdv1.ThemeName = "Office2019Colorful";
            this.dateTimePickerAdv2.ThemeName = "Office2019Colorful";
            this.dateTimePickerAdv3.ThemeName = "Office2019Colorful";
            #endregion
            comboBoxAdv1.SelectedIndex = 0;
			comboBoxAdv2.SelectedIndex = 0;
			comboBoxAdv3.SelectedIndex = 0;
            this.treeViewAdv1.ThemeName = "Office2019Colorful";
            this.comboBoxAdv1.ThemeName = "Office2019Colorful";
            this.comboBoxAdv2.ThemeName = "Office2019Colorful";
            this.comboBoxAdv3.ThemeName = "Office2019Colorful";
            this.gridControl1.GridVisualStyles = GridVisualStyles.Office2016Colorful;
            this.gridControl2.GridVisualStyles = GridVisualStyles.Office2016Colorful;
            this.gridControl3.GridVisualStyles = GridVisualStyles.Office2016Colorful;
            this.gridControl1.RowHeightEntries.AddRange(new Syncfusion.Windows.Forms.Grid.GridRowHeight[] {
            new Syncfusion.Windows.Forms.Grid.GridRowHeight(0, 18)});
            this.gridControl2.RowHeightEntries.AddRange(new Syncfusion.Windows.Forms.Grid.GridRowHeight[] {
            new Syncfusion.Windows.Forms.Grid.GridRowHeight(0, 18)});
            this.gridControl3.RowHeightEntries.AddRange(new Syncfusion.Windows.Forms.Grid.GridRowHeight[] {
            new Syncfusion.Windows.Forms.Grid.GridRowHeight(0, 18)});
            this.dateTimePickerAdv1.ThemeName="Office2019Colorful";
            this.dateTimePickerAdv2.ThemeName =" Office2019Colorful";
            this.dateTimePickerAdv3.ThemeName = "Office2019Colorful";
            this.xpToolBar4.Style = VisualStyle.Office2016White;
            this.xpToolBar2.Style = VisualStyle.Office2016White;
            this.xpToolBar3.Style = VisualStyle.Office2016White;
            this.xpToolBar1.Style = VisualStyle.Office2016White;
            #endregion
            this.StartPosition = FormStartPosition.CenterScreen;
            this.CenterToScreen();
        }
       
        #region StateImage
        private void StateImageBarItem_Click(object sender, EventArgs e)
        {
            BarItem barItem = sender as BarItem;
            if (barItem.Checked != true)
            {
                barItem.Checked = true;
            }
            else
            {
              barItem.Checked = false;
            }
            if (barItem.Checked)
            {
                if (barItem == this.barItem1)
                {
                    this.treeViewAdv1.Nodes[0].Nodes[0].OpenImgIndex = this.comboBoxAdv1.SelectedIndex;
                    this.treeViewAdv1.Nodes[0].Nodes[0].ClosedImgIndex = this.comboBoxAdv1.SelectedIndex;
                    this.treeViewAdv1.Nodes[0].Nodes[0].ShowPlusMinus = false;
               }
                if (barItem == this.barItem7)
                {
                    int imageindex = this.comboBoxAdv2.SelectedIndex + 3;
                    this.treeViewAdv1.Nodes[0].Nodes[1].OpenImgIndex = imageindex;
                    this.treeViewAdv1.Nodes[0].Nodes[1].ClosedImgIndex = imageindex;
                    this.treeViewAdv1.Nodes[0].Nodes[1].ShowPlusMinus = false;
                }
                if (barItem == this.barItem13)
                {
                    int imageindex = this.comboBoxAdv3.SelectedIndex + 6;
                    this.treeViewAdv1.Nodes[0].Nodes[2].OpenImgIndex = imageindex;
                    this.treeViewAdv1.Nodes[0].Nodes[2].ClosedImgIndex = imageindex;
                    this.treeViewAdv1.Nodes[0].Nodes[2].ShowPlusMinus = false;
                }
            }
            else
            {
                if (barItem == this.barItem1)
                {
                    this.treeViewAdv1.Nodes[0].Nodes[0].OpenImgIndex = -1;
                    this.treeViewAdv1.Nodes[0].Nodes[0].ClosedImgIndex = -1;
                    this.treeViewAdv1.Nodes[0].Nodes[0].ShowPlusMinus = true;
                }
                if (barItem == this.barItem7)
                {
                    this.treeViewAdv1.Nodes[0].Nodes[1].OpenImgIndex = -1;
                    this.treeViewAdv1.Nodes[0].Nodes[1].ClosedImgIndex = -1;
                    this.treeViewAdv1.Nodes[0].Nodes[1].ShowPlusMinus = true;
                }
                if (barItem == this.barItem13)
                {
                    this.treeViewAdv1.Nodes[0].Nodes[2].OpenImgIndex = -1;
                    this.treeViewAdv1.Nodes[0].Nodes[2].ClosedImgIndex = -1;
                    this.treeViewAdv1.Nodes[0].Nodes[2].ShowPlusMinus = true;
                }
                this.treeViewAdv1.Refresh(); 
            }



        }
        #endregion

        #region LeftImage
        private void LeftImageBarItem_Click(object sender, EventArgs e)
        {
            BarItem barItem = sender as BarItem;
            if (barItem.Checked != true)
            {
                barItem.Checked = true;
            }
            else
            {
              barItem.Checked = false;
            }
            if (barItem.Checked)
            {
                if (barItem == this.barItem2)
                {
                    this.treeViewAdv1.Nodes[0].Nodes[0].Nodes[0].LeftImageIndices = new int[] { 0 };
                    this.treeViewAdv1.Nodes[0].Nodes[0].Nodes[1].LeftImageIndices = new int[] { 1 };
                    this.treeViewAdv1.Nodes[0].Nodes[0].Nodes[2].LeftImageIndices = new int[] { 2 };
                }
                if (barItem == this.barItem8)
                {
                    this.treeViewAdv1.Nodes[0].Nodes[1].Nodes[0].LeftImageIndices = new int[] { 0 };
                    this.treeViewAdv1.Nodes[0].Nodes[1].Nodes[1].LeftImageIndices = new int[] { 1 };
                    this.treeViewAdv1.Nodes[0].Nodes[1].Nodes[2].LeftImageIndices = new int[] { 2 };
                }
                if (barItem == this.barItem14)
                {
                    this.treeViewAdv1.Nodes[0].Nodes[2].Nodes[0].LeftImageIndices = new int[] { 0 };
                    this.treeViewAdv1.Nodes[0].Nodes[2].Nodes[1].LeftImageIndices = new int[] { 1 };
                    this.treeViewAdv1.Nodes[0].Nodes[2].Nodes[2].LeftImageIndices = new int[] { 2 };
                }
            }
            else
            {
                if (barItem == this.barItem2)
                {
                    this.treeViewAdv1.Nodes[0].Nodes[0].Nodes[0].LeftImageIndices = new int[] { -1 };
                    this.treeViewAdv1.Nodes[0].Nodes[0].Nodes[1].LeftImageIndices = new int[] { -1 };
                    this.treeViewAdv1.Nodes[0].Nodes[0].Nodes[2].LeftImageIndices = new int[] { -1 };
                }
                if (barItem == this.barItem8)
                {
                    this.treeViewAdv1.Nodes[0].Nodes[1].Nodes[0].LeftImageIndices = new int[] { -1 };
                    this.treeViewAdv1.Nodes[0].Nodes[1].Nodes[1].LeftImageIndices = new int[] { -1 };
                    this.treeViewAdv1.Nodes[0].Nodes[1].Nodes[2].LeftImageIndices = new int[] { -1 };
                }
                if (barItem == this.barItem14)
                {
                    this.treeViewAdv1.Nodes[0].Nodes[2].Nodes[0].LeftImageIndices = new int[] { -1 };
                    this.treeViewAdv1.Nodes[0].Nodes[2].Nodes[1].LeftImageIndices = new int[] { -1 };
                    this.treeViewAdv1.Nodes[0].Nodes[2].Nodes[2].LeftImageIndices = new int[] { -1 };
                }
            }
            this.treeViewAdv1.Refresh(); 
        }
        
        #endregion

        #region RightImage
        private void RightImageBarItem_Click(object sender, EventArgs e)
        {
            BarItem barItem = sender as BarItem;
            if (barItem.Checked != true)
            {
                barItem.Checked = true;
            }
            else
            {
                barItem.Checked = false;
            }
            if (barItem.Checked)
            {
                if (barItem == this.barItem3)
                {
                    this.treeViewAdv1.Nodes[0].Nodes[0].Nodes[0].RightImageIndices = new int[] { 0 };
                    this.treeViewAdv1.Nodes[0].Nodes[0].Nodes[1].RightImageIndices = new int[] { 1 };
                    this.treeViewAdv1.Nodes[0].Nodes[0].Nodes[2].RightImageIndices = new int[] { 2 };
                }
                if (barItem == this.barItem9)
                {
                    this.treeViewAdv1.Nodes[0].Nodes[1].Nodes[0].RightImageIndices = new int[] { 0 };
                    this.treeViewAdv1.Nodes[0].Nodes[1].Nodes[1].RightImageIndices = new int[] { 1 };
                    this.treeViewAdv1.Nodes[0].Nodes[1].Nodes[2].RightImageIndices = new int[] { 2 };
                }
                if (barItem == this.barItem15)
                {
                    this.treeViewAdv1.Nodes[0].Nodes[2].Nodes[0].RightImageIndices = new int[] { 0 };
                    this.treeViewAdv1.Nodes[0].Nodes[2].Nodes[1].RightImageIndices = new int[] { 1 };
                    this.treeViewAdv1.Nodes[0].Nodes[2].Nodes[2].RightImageIndices = new int[] { 2 };
                }
            }
            else
            {

                if (barItem == this.barItem3)
                {
                    this.treeViewAdv1.Nodes[0].Nodes[0].Nodes[0].RightImageIndices = new int[] { -1 };
                    this.treeViewAdv1.Nodes[0].Nodes[0].Nodes[1].RightImageIndices = new int[] { -1 };
                    this.treeViewAdv1.Nodes[0].Nodes[0].Nodes[2].RightImageIndices = new int[] { -1 };
                }
                if (barItem == this.barItem9)
                {
                    this.treeViewAdv1.Nodes[0].Nodes[1].Nodes[0].RightImageIndices = new int[] { -1 };
                    this.treeViewAdv1.Nodes[0].Nodes[1].Nodes[1].RightImageIndices = new int[] { -1 };
                    this.treeViewAdv1.Nodes[0].Nodes[1].Nodes[2].RightImageIndices = new int[] { -1 };
                }
                if (barItem == this.barItem15)
                {
                    this.treeViewAdv1.Nodes[0].Nodes[2].Nodes[0].RightImageIndices = new int[] { -1 };
                    this.treeViewAdv1.Nodes[0].Nodes[2].Nodes[1].RightImageIndices = new int[] { -1 };
                    this.treeViewAdv1.Nodes[0].Nodes[2].Nodes[2].RightImageIndices = new int[] { -1 };
                }
            }
            this.treeViewAdv1.Refresh(); 

        }
        #endregion

        #region Stye1
        private void Style1BarItem_Click(object sender, EventArgs e)
        {
            BarItem barItem = sender as BarItem;
            if (barItem == this.barItem4)
            {
                this.treeViewAdv1.Nodes[0].Nodes[0].ChildStyle.BaseStyle = "Style1";
                this.treeViewAdv1.SelectedNode = null;
                this.treeViewAdv1.SelectedNode = this.treeViewAdv1.Nodes[0].Nodes[0];
            }
            if (barItem == this.barItem10)
            {
                this.treeViewAdv1.Nodes[0].Nodes[1].ChildStyle.BaseStyle = "Style1";
                this.treeViewAdv1.SelectedNode = null;
                this.treeViewAdv1.SelectedNode = this.treeViewAdv1.Nodes[0].Nodes[1];
            }
            if (barItem == this.barItem16)
            {
                this.treeViewAdv1.Nodes[0].Nodes[2].ChildStyle.BaseStyle = "Style1";
                this.treeViewAdv1.SelectedNode = null;
                this.treeViewAdv1.SelectedNode = this.treeViewAdv1.Nodes[0].Nodes[2];
            }
            this.treeViewAdv1.Refresh();
        }
#endregion

        #region style2
        private void Style2BarItem_Click(object sender, EventArgs e)
        {
            BarItem barItem = sender as BarItem;
                if (barItem == this.barItem5)
                {
                    this.treeViewAdv1.Nodes[0].Nodes[0].ChildStyle.BaseStyle = "Style2";
                    this.treeViewAdv1.SelectedNode = null;
                    this.treeViewAdv1.SelectedNode = this.treeViewAdv1.Nodes[0].Nodes[0];
                    
                }
                if (barItem == this.barItem11)
                {
                    this.treeViewAdv1.Nodes[0].Nodes[1].ChildStyle.BaseStyle = "Style2";
                    this.treeViewAdv1.SelectedNode = null;
                    this.treeViewAdv1.SelectedNode = this.treeViewAdv1.Nodes[0].Nodes[1];
                }
                if (barItem == this.barItem17)
                {
                    this.treeViewAdv1.Nodes[0].Nodes[2].ChildStyle.BaseStyle = "Style2";
                    this.treeViewAdv1.SelectedNode = null;
                    this.treeViewAdv1.SelectedNode = this.treeViewAdv1.Nodes[0].Nodes[2];
                }
                this.treeViewAdv1.Refresh();
            
        }
        #endregion

        #region Style3
        private void Style3BarItem_Click(object sender, EventArgs e)
        {
            BarItem barItem = sender as BarItem;
                if (barItem == this.barItem6)
                {
                    this.treeViewAdv1.Nodes[0].Nodes[0].ChildStyle.BaseStyle = "Style3";
                    this.treeViewAdv1.SelectedNode = null;
                    this.treeViewAdv1.SelectedNode = this.treeViewAdv1.Nodes[0].Nodes[0];
                }
                if (barItem == this.barItem12)
                {
                    this.treeViewAdv1.Nodes[0].Nodes[1].ChildStyle.BaseStyle = "Style3";
                    this.treeViewAdv1.SelectedNode = null;
                    this.treeViewAdv1.SelectedNode = this.treeViewAdv1.Nodes[0].Nodes[1];
                }
                if (barItem == this.barItem18)
                {
                    this.treeViewAdv1.Nodes[0].Nodes[2].ChildStyle.BaseStyle = "Style3";
                    this.treeViewAdv1.SelectedNode = null;
                    this.treeViewAdv1.SelectedNode = this.treeViewAdv1.Nodes[0].Nodes[2];
                }
                this.treeViewAdv1.Refresh();
            }
        #endregion

        #region "Image Loading Methods"
        //Get and Load the images
#if NET9_0_OR_GREATER
        private Image GetImage(string path)
        {
            System.Reflection.Assembly asm = System.Reflection.Assembly.GetExecutingAssembly();
            if (asm != null && !string.IsNullOrEmpty(path))
                return Image.FromStream(asm.GetManifestResourceStream(path));
            return null;
        }

        private void LoadImages(ImageList imageList, string folder, int count)
        {
            for (int i = 1; i <= count; i++)
            {
                string imagePath = ($"CustomControls_2005.Images.{folder}.Image_{i}.png");
                imageList.Images.Add(GetImage(imagePath));
            }
        }
#endif
        #endregion


        #region Update Grid
        private void ComboBoxAdv_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBoxAdv comboBoxAdv = sender as ComboBoxAdv;
            if (comboBoxAdv == this.comboBoxAdv1)
            {
                if (this.comboBoxAdv1.SelectedItem.ToString() == "Mexico")
                {
                    for (int i = 0; i < 11; i++)
                    {
                        this.gridControl1[i, 1].Text = "Mexico";
                    }
                    this.gridControl1[1, 3].Text = "10.1 Million";
                    this.gridControl1[2, 3].Text = "25.3 Million";
                    this.gridControl1[3, 3].Text = "100.1 Million";
                    this.gridControl1[4, 3].Text = "1.2 Billion";
                    this.gridControl1[5, 3].Text = "224.3 Million";
                    this.gridControl1[6, 3].Text = "678 Million";
                    this.gridControl1[7, 3].Text = "389.3 Million";
                    this.gridControl1[8, 3].Text = "686.6 Million";
                    this.gridControl1[9, 3].Text = "891.2 Million";
                    this.gridControl1[10, 3].Text = "719 Million";
                }
                if (this.comboBoxAdv1.SelectedItem.ToString() == "Canada")
                {
                    for (int i = 0; i < 11; i++)
                    {
                        this.gridControl1[i, 1].Text = "Canada";
                    }
                    this.gridControl1[1, 3].Text = "11.1 Million";
                    this.gridControl1[2, 3].Text = "29.3 Million";
                    this.gridControl1[3, 3].Text = "190.1 Million";
                    this.gridControl1[4, 3].Text = "1.3 Billion";
                    this.gridControl1[5, 3].Text = "194.3 Million";
                    this.gridControl1[6, 3].Text = "456 Million";
                    this.gridControl1[7, 3].Text = "569.3 Million";
                    this.gridControl1[8, 3].Text = "676.6 Million";
                    this.gridControl1[9, 3].Text = "861.2 Million";
                    this.gridControl1[10, 3].Text = "709 Million";
                }
                if (this.comboBoxAdv1.SelectedItem.ToString() == "Bermuda")
                {
                    for (int i = 0; i < 11; i++)
                    {
                        this.gridControl1[i, 1].Text = "Bermuda";
                    }
                    this.gridControl1[1, 3].Text = "17.1 Million";
                    this.gridControl1[2, 3].Text = "28.3 Million";
                    this.gridControl1[3, 3].Text = "150.1 Million";
                    this.gridControl1[4, 3].Text = "1.1 Billion";
                    this.gridControl1[5, 3].Text = "294.3 Million";
                    this.gridControl1[6, 3].Text = "374 Million";
                    this.gridControl1[7, 3].Text = "239.3 Million";
                    this.gridControl1[8, 3].Text = "786.6 Million";
                    this.gridControl1[9, 3].Text = "781.2 Million";
                    this.gridControl1[10, 3].Text = "711 Million";
                }
                this.treeViewAdv1.Nodes[0].Nodes[0].OpenImgIndex = this.comboBoxAdv1.SelectedIndex;
                this.treeViewAdv1.Nodes[0].Nodes[0].ClosedImgIndex = this.comboBoxAdv1.SelectedIndex;
            }
            if (comboBoxAdv == this.comboBoxAdv2)
            {
                if (this.comboBoxAdv2.SelectedItem.ToString() == "Belize")
                {
                    for (int i = 0; i < 11; i++)
                    {
                        this.gridControl2[i, 1].Text = "Belize";
                    }
                    this.gridControl2[1, 3].Text = "17.1 Million";
                    this.gridControl2[2, 3].Text = "28.3 Million";
                    this.gridControl2[3, 3].Text = "150.1 Million";
                    this.gridControl2[4, 3].Text = "1.1 Billion";
                    this.gridControl2[5, 3].Text = "294.3 Million";
                    this.gridControl2[6, 3].Text = "374 Million";
                    this.gridControl2[7, 3].Text = "239.3 Million";
                    this.gridControl2[8, 3].Text = "786.6 Million";
                    this.gridControl2[9, 3].Text = "781.2 Million";
                    this.gridControl2[10, 3].Text = "711 Million";

                }
                if (this.comboBoxAdv2.SelectedItem.ToString() == "Panama")
                {
                    for (int i = 0; i < 11; i++)
                    {
                        this.gridControl2[i, 1].Text = "Panama";
                    }
                    this.gridControl2[1, 3].Text = "10.1 Million";
                    this.gridControl2[2, 3].Text = "25.3 Million";
                    this.gridControl2[3, 3].Text = "100.1 Million";
                    this.gridControl2[4, 3].Text = "1.2 Billion";
                    this.gridControl2[5, 3].Text = "224.3 Million";
                    this.gridControl2[6, 3].Text = "678 Million";
                    this.gridControl2[7, 3].Text = "389.3 Million";
                    this.gridControl2[8, 3].Text = "686.6 Million";
                    this.gridControl2[9, 3].Text = "891.2 Million";
                    this.gridControl2[10, 3].Text = "719 Million";
                }
                if (this.comboBoxAdv2.SelectedItem.ToString() == "Costa Rica")
                {
                    for (int i = 0; i < 11; i++)
                    {
                        this.gridControl2[i, 1].Text = "Costa Rica";
                    }
                    this.gridControl2[1, 3].Text = "11.1 Million";
                    this.gridControl2[2, 3].Text = "29.3 Million";
                    this.gridControl2[3, 3].Text = "190.1 Million";
                    this.gridControl2[4, 3].Text = "1.3 Billion";
                    this.gridControl2[5, 3].Text = "194.3 Million";
                    this.gridControl2[6, 3].Text = "456 Million";
                    this.gridControl2[7, 3].Text = "569.3 Million";
                    this.gridControl2[8, 3].Text = "676.6 Million";
                    this.gridControl2[9, 3].Text = "861.2 Million";
                    this.gridControl2[10, 3].Text = "709 Million";
                }
                int imageindex = this.comboBoxAdv2.SelectedIndex + 3;
                this.treeViewAdv1.Nodes[0].Nodes[1].OpenImgIndex = imageindex;
                this.treeViewAdv1.Nodes[0].Nodes[1].ClosedImgIndex = imageindex;

            }
            if (comboBoxAdv == this.comboBoxAdv3)
            {
                if (this.comboBoxAdv3.SelectedItem.ToString() == "Brazil")
                {
                    for (int i = 0; i < 11; i++)
                    {
                        this.gridControl3[i, 1].Text = "Brazil";
                    }
                    this.gridControl3[1, 3].Text = "11.1 Million";
                    this.gridControl3[2, 3].Text = "29.3 Million";
                    this.gridControl3[3, 3].Text = "190.1 Million";
                    this.gridControl3[4, 3].Text = "1.3 Billion";
                    this.gridControl3[5, 3].Text = "194.3 Million";
                    this.gridControl3[6, 3].Text = "456 Million";
                    this.gridControl3[7, 3].Text = "569.3 Million";
                    this.gridControl3[8, 3].Text = "676.6 Million";
                    this.gridControl3[9, 3].Text = "861.2 Million";
                    this.gridControl3[10, 3].Text = "709 Million";
                }
                if (this.comboBoxAdv3.SelectedItem.ToString() == "Argentina")
                {
                    for (int i = 0; i < 11; i++)
                    {
                        this.gridControl3[i, 1].Text = "Argentina";
                    }
                    this.gridControl3[1, 3].Text = "17.1 Million";
                    this.gridControl3[2, 3].Text = "28.3 Million";
                    this.gridControl3[3, 3].Text = "150.1 Million";
                    this.gridControl3[4, 3].Text = "1.1 Billion";
                    this.gridControl3[5, 3].Text = "294.3 Million";
                    this.gridControl3[6, 3].Text = "374 Million";
                    this.gridControl3[7, 3].Text = "239.3 Million";
                    this.gridControl3[8, 3].Text = "786.6 Million";
                    this.gridControl3[9, 3].Text = "781.2 Million";
                    this.gridControl3[10, 3].Text = "711 Million";
                }
                if (this.comboBoxAdv3.SelectedItem.ToString() == "Colombia")
                {
                    for (int i = 0; i < 11; i++)
                    {
                        this.gridControl3[i, 1].Text = "Colombia";
                    }
                    this.gridControl3[1, 3].Text = "10.1 Million";
                    this.gridControl3[2, 3].Text = "25.3 Million";
                    this.gridControl3[3, 3].Text = "100.1 Million";
                    this.gridControl3[4, 3].Text = "1.2 Billion";
                    this.gridControl3[5, 3].Text = "224.3 Million";
                    this.gridControl3[6, 3].Text = "678 Million";
                    this.gridControl3[7, 3].Text = "389.3 Million";
                    this.gridControl3[8, 3].Text = "686.6 Million";
                    this.gridControl3[9, 3].Text = "891.2 Million";
                    this.gridControl3[10, 3].Text = "719 Million";
                }
                int imageindex = this.comboBoxAdv3.SelectedIndex + 6;
                this.treeViewAdv1.Nodes[0].Nodes[2].OpenImgIndex = imageindex;
                this.treeViewAdv1.Nodes[0].Nodes[2].ClosedImgIndex = imageindex;

            }
            this.treeViewAdv1.Refresh();
        }

        #endregion

        #region Clear Styles
        private void barItem22_Click(object sender, EventArgs e)
        {
     standardStyle();
        }
        private void standardStyle()
        {
            this.treeViewAdv1.Nodes[0].BaseStyle = "Standard";
            this.treeViewAdv1.Nodes[0].ChildStyle.BaseStyle = "Standard";
            foreach (TreeNodeAdv treenode in this.treeViewAdv1.Nodes[0].Nodes)
            {
                treenode.ChildStyle.BaseStyle = "Standard";
            }

            this.treeViewAdv1.Refresh();
        }
        #endregion
   }
            
}

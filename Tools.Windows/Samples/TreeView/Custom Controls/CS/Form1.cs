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

namespace CustomControls_2005
{
    public partial class Form1 : MetroForm
    {
        public Form1()
        {
            InitializeComponent();
            this.MinimumSize = this.Size;
            try
            {
                System.Drawing.Icon ico = new System.Drawing.Icon(GetIconFile(@"common\Images\Grid\Icon\sfgrid.ico"));
                this.Icon = ico;
            }
            catch { }


            #region Default Grid Values
            this.gridControl1[2, 1].Text = "2007";
            this.gridControl1[2, 2].Text = "107,449,525";
            this.gridControl1[2, 3].Text = "1,972,550(sq km) 761,602(sq mi)";
            this.gridControl2[2, 1].Text = "2007";
            this.gridControl2[2, 2].Text = "287,730";
            this.gridControl2[2, 3].Text = "22,966(sq km) 8,867(sq mi)";
            this.gridControl3[2, 1].Text = "2007";
            this.gridControl3[2, 2].Text = "188,078,227";
            this.gridControl3[2, 3].Text = "8,511,965(sq km)3,286,470(sq mi)";
			
			comboBoxAdv1.SelectedIndex = 0;
			comboBoxAdv2.SelectedIndex = 0;
			comboBoxAdv3.SelectedIndex = 0;
#endregion
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

        #region Update Grid
            private void ComboBoxAdv_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBoxAdv comboBoxAdv = sender as ComboBoxAdv;
            if (comboBoxAdv == this.comboBoxAdv1)
            {
                if (this.comboBoxAdv1.SelectedItem.ToString() == "Mexico")
                {
                    this.gridControl1[2, 1].Text = "2007";
                    this.gridControl1[2, 2].Text = "107,449,525";
                    this.gridControl1[2, 3].Text = "1,972,550(sq km) 761,602(sq mi)";
             
                }
                if (this.comboBoxAdv1.SelectedItem.ToString() == "Canada")
                {
                    this.gridControl1[2, 1].Text = "2007";
                    this.gridControl1[2, 2].Text = "33,098,932";
                    this.gridControl1[2, 3].Text = "9,984,670(sq km)3,855,081(sq mi)";
                }
                if (this.comboBoxAdv1.SelectedItem.ToString() == "Bermuda")
                {
                    this.gridControl1[2, 1].Text = "2007";
                    this.gridControl1[2, 2].Text = "65,773";
                    this.gridControl1[2, 3].Text = "53(sq km)20(sq mi)";
                }
                this.treeViewAdv1.Nodes[0].Nodes[0].OpenImgIndex = this.comboBoxAdv1.SelectedIndex;
                this.treeViewAdv1.Nodes[0].Nodes[0].ClosedImgIndex = this.comboBoxAdv1.SelectedIndex;
             }
            if (comboBoxAdv == this.comboBoxAdv2)
            {
                if (this.comboBoxAdv2.SelectedItem.ToString() == "Belize")
                {
                    this.gridControl2[2, 1].Text = "2007";
                    this.gridControl2[2, 2].Text = "287,730";
                    this.gridControl2[2, 3].Text = "22,966(sq km) 8,867(sq mi)";

                }
                if (this.comboBoxAdv2.SelectedItem.ToString() == "Panama")
                {
                    this.gridControl2[2, 1].Text = "2007";
                    this.gridControl2[2, 2].Text = "3,191,319";
                    this.gridControl2[2, 3].Text = "78,200(sq km)30,193(sq mi)";
                }
                if (this.comboBoxAdv2.SelectedItem.ToString() == "Costa Rica")
                {
                    this.gridControl2[2, 1].Text = "2007";
                    this.gridControl2[2, 2].Text = "4,075,261";
                    this.gridControl2[2, 3].Text = "51,100(sq km)19,730(sq mi)";
                }
                int imageindex = this.comboBoxAdv2.SelectedIndex + 3;
                this.treeViewAdv1.Nodes[0].Nodes[1].OpenImgIndex = imageindex;
                this.treeViewAdv1.Nodes[0].Nodes[1].ClosedImgIndex = imageindex;
             
            }
            if (comboBoxAdv == this.comboBoxAdv3)
            {
                if (this.comboBoxAdv3.SelectedItem.ToString() == "Brazil")
                {
                    this.gridControl3[2, 1].Text = "2007";
                    this.gridControl3[2, 2].Text = "188,078,227";
                    this.gridControl3[2, 3].Text = "8,511,965(sq km)3,286,470(sq mi)";

                }
                if (this.comboBoxAdv3.SelectedItem.ToString() == "Argentina")
                {
                    this.gridControl3[2, 1].Text = "2007";
                    this.gridControl3[2, 2].Text = "39,921,833";
                    this.gridControl3[2, 3].Text = "2,766,890(sq km)1,068,296(sq mi)";
                }
                if (this.comboBoxAdv3.SelectedItem.ToString() == "Colombia")
                {
                    this.gridControl3[2, 1].Text = "2007";
                    this.gridControl3[2, 2].Text = "43,593,035";
                    this.gridControl3[2, 3].Text = "1,138,910(sq km)439,733(sq mi)";
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

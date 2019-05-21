#region Copyright Syncfusion Inc. 2001-2016.
// Copyright Syncfusion Inc. 2001-2016. All rights reserved.
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

namespace PrintingCustomization
{
    public partial class Form1 : MetroForm
    {
        public TreeViewPrintDocument printDocument;
        private MetroArrowColorTable colorTable = new MetroArrowColorTable();
        internal Form1()
        {
            InitializeComponent();
            
            this.CaptionFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            //this.MinimumSize = this.Size;
            colorTable.ArrowNormal = Color.LightGray;
            colorTable.ArrowHovered = ColorTranslator.FromHtml("#16A5DC");
            this.treeViewAdv1.MetroArrowColorTable = colorTable;
            this.treeViewAdv1.UpdateStyles();
            printDocument = new TreeViewPrintDocument(this.treeViewAdv1);
            this.Load += Form1_Load;
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
            this.gridControl2[1, 3].Text = "10.1 Million";
            this.gridControl3[1, 3].Text = "10.1 Million";
            this.gridControl1[2, 3].Text = "29.3 Million";
            this.gridControl2[2, 3].Text = "29.3 Million";
            this.gridControl3[2, 3].Text = "29.3 Million";
            this.gridControl1[3, 3].Text = "120.1 Million";
            this.gridControl2[3, 3].Text = "120.1 Million";
            this.gridControl3[3, 3].Text = "120.1 Million";
            this.gridControl1[4, 3].Text = "1.2 Billion";
            this.gridControl2[4, 3].Text = "1.2 Billion";
            this.gridControl3[4, 3].Text = "1.2 Billion";
            this.gridControl1[5, 3].Text = "294.3 Million";
            this.gridControl2[5, 3].Text = "294.3 Million";
            this.gridControl3[5, 3].Text = "294.3 Million";
            this.gridControl1[6, 3].Text = "478 Million";
            this.gridControl2[6, 3].Text = "478 Million";
            this.gridControl3[6, 3].Text = "478 Million";
            this.gridControl1[7, 3].Text = "389.3 Million";
            this.gridControl2[7, 3].Text = "389.3 Million";
            this.gridControl3[7, 3].Text = "389.3 Million";
            this.gridControl1[8, 3].Text = "686.6 Million";
            this.gridControl2[8, 3].Text = "686.6 Million";
            this.gridControl3[8, 3].Text = "686.6 Million";
            this.gridControl1[9, 3].Text = "891.2 Million";
            this.gridControl2[9, 3].Text = "891.2 Million";
            this.gridControl3[9, 3].Text = "891.2 Million";
            this.gridControl1[10, 3].Text = "719 Million";
            this.gridControl2[10, 3].Text = "719 Million";
            this.gridControl3[10, 3].Text = "719 Million";
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
            #endregion
        }

        void Form1_Load(object sender, EventArgs e)
        {
            this.MinimumSize = this.Size;
            this.treeViewAdv1.ExpandAll();
            this.treeViewAdv1.ShowLines = false;
            TreeNodeAdv node = new TreeNodeAdv();
            this.treeViewAdv1.VScrollBar.Value = 0;
            this.treeViewAdv1.SelectedNode = this.treeViewAdv1.Nodes[0];
            this.splitContainerAdv1.Panel1.MinimumSize = new Size(this.splitContainerAdv1.Panel1.Width, this.splitContainerAdv1.Panel1.Height);
            //for (int i = 0; i <= 10; i++)
            //{
            //    node.Text = "TreeNodeAdv" + (i + 1).ToString();
            //    this.treeViewAdv1.Nodes.Add(node);
            //}
            //this.treeViewAdv1.VScrollBar.Value = 0;
            this.Resize += new EventHandler(Form1_Resize);
        }

        void Form1_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
                this.splitContainerAdv1.SplitterDistance = this.Width - (this.Width / 4);
            else
                this.splitContainerAdv1.SplitterDistance = this.Width - (this.Width / 3)- 100;
        }


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
                }
                if (this.comboBoxAdv1.SelectedItem.ToString() == "Canada")
                {
                    for (int i = 0; i < 11; i++)
                    {
                        this.gridControl1[i, 1].Text = "Canada";
                    }  
                }
                if (this.comboBoxAdv1.SelectedItem.ToString() == "Bermuda")
                {
                    for (int i = 0; i < 11; i++)
                    {
                        this.gridControl1[i, 1].Text = "Bermuda";
                    } 
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
                }
                if (this.comboBoxAdv2.SelectedItem.ToString() == "Panama")
                {
                    for (int i = 0; i < 11; i++)
                    {
                        this.gridControl2[i, 1].Text = "Panama";
                    } 
                }
                if (this.comboBoxAdv2.SelectedItem.ToString() == "Costa Rica")
                {
                    for (int i = 0; i < 11; i++)
                    {
                        this.gridControl2[i, 1].Text = "Costa Rica";
                    } 
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
                }
                if (this.comboBoxAdv3.SelectedItem.ToString() == "Argentina")
                {
                    for (int i = 0; i < 11; i++)
                    {
                        this.gridControl3[i, 1].Text = "Argentina";
                    } 
                }
                if (this.comboBoxAdv3.SelectedItem.ToString() == "Colombia")
                {
                    for (int i = 0; i < 11; i++)
                    {
                        this.gridControl3[i, 1].Text = "Colombia";
                    } 
                }
                int imageindex = this.comboBoxAdv3.SelectedIndex + 6;
                this.treeViewAdv1.Nodes[0].Nodes[2].OpenImgIndex = imageindex;
                this.treeViewAdv1.Nodes[0].Nodes[2].ClosedImgIndex = imageindex;
                
            }
            this.treeViewAdv1.Refresh(); 
        }

            #endregion

       
        private void buttonAdv1_Click(object sender, EventArgs e)
        {
            //To update the updated layout image.
            printDocument.PrepareTreeImage(this.treeViewAdv1);
            PreviewForm printForm = new PreviewForm(printDocument);
            printForm.trackBarEx1.Value = 20;
            printForm.ShowDialog();

        }

        private void buttonAdv2_Click(object sender, EventArgs e)
        {
            printDocument.Print();
        }
   }
}

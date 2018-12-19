#region Copyright Syncfusion Inc. 2001 - 2014
// Copyright Syncfusion Inc. 2001 - 2014. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
#region file using directives
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Text;
using System.Windows.Forms;
using Syncfusion.Windows.Forms;
using Syncfusion.Windows.Forms.Tools;
using Syncfusion.Windows.Forms.Tools.XPMenus;
#endregion

namespace ScrollersFrame_2005
{
    public partial class Form1 : MetroForm
    {
        #region Variables.
        ToolTip toolTip1 = new ToolTip();
        ToolTip toolTip2 = new ToolTip();
        ToolTip toolTip3 = new ToolTip();
        #endregion

        #region Constructor
        public Form1()
        {
            InitializeComponent();
            this.MinimumSize = this.Size;
            parentBarItem4.Enabled = false;
            treeView3.ExpandAll();
            this.mainFrameBarManager1.MainMenuBar.DrawBackground += new PaintEventHandler(MainMenuBar_DrawBackground);
            // Add controls to the scrollers here.
            this.scrollersFrame2.HorizontalScroller.ControlsBefore.Add(buttonAdv3);
            this.scrollersFrame2.VerticalScroller.ControlsAfter.Add(buttonAdv1);
            this.scrollersFrame2.VerticalScroller.ControlsAfter.Add(buttonAdv2);     
            //Set the ToolTip to ScrollBar controls.
            this.toolTip1.SetToolTip(this.buttonAdv1, "Redo");
            this.toolTip2.SetToolTip(this.buttonAdv2, "Undo");
            this.toolTip3.SetToolTip(this.buttonAdv3, "Collapse");
            this.barItem4.Checked = true;
            try
            {
                System.Drawing.Icon ico = new System.Drawing.Icon(GetIconFile(@"common\Images\Grid\Icon\sfgrid.ico"));
                this.Icon = ico;
            }
            catch { }
        }
        #endregion

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

        void MainMenuBar_DrawBackground(object sender, PaintEventArgs e)
        {
            e.Graphics.FillRectangle(Brushes.White,e.ClipRectangle);
        }
        
        #region Office 2007 Themes
        private void barItem_Click(object sender, EventArgs e)
        {
            BarItem bitem = (BarItem)sender;
            UnCheckAll();

            switch(bitem.Text)
            {
                case "Blue":
                    barItem7.Checked = true;
                    if (this.scrollersFrame2.VisualStyle == ScrollBarCustomDrawStyles.Office2007)
                    {
                        this.scrollersFrame2.OfficeColorScheme = Office2007ColorScheme.Blue;
                        this.buttonAdv1.Office2007ColorScheme = Office2007Theme.Blue;
                        this.buttonAdv2.Office2007ColorScheme = Office2007Theme.Blue;
                        this.buttonAdv3.Office2007ColorScheme = Office2007Theme.Blue;
                    }
                    else if (this.scrollersFrame2.VisualStyle == ScrollBarCustomDrawStyles.Office2010)
                    {
                        this.scrollersFrame2.Office2010ColorScheme = Office2010ColorScheme.Blue;
                        this.buttonAdv1.Office2010ColorScheme = Office2010Theme.Blue;
                        this.buttonAdv2.Office2010ColorScheme = Office2010Theme.Blue;
                        this.buttonAdv3.Office2010ColorScheme = Office2010Theme.Blue;
                    }
                    this.mainFrameBarManager1.Office2007Theme = Office2007Theme.Blue;
                    this.BackColor = Color.FromArgb(246, 249, 254);
                    this.buttonAdv1.Office2007ColorScheme = Office2007Theme.Blue;
                    this.buttonAdv2.Office2007ColorScheme = Office2007Theme.Blue;
                    this.buttonAdv3.Office2007ColorScheme = Office2007Theme.Blue;
                    this.gradientPanel1.BorderColor = Color.FromArgb(222, 231, 246);
                    break;
                case "Silver":
                    barItem8.Checked = true;
                    if (this.scrollersFrame2.VisualStyle == ScrollBarCustomDrawStyles.Office2007)
                    {
                        this.scrollersFrame2.OfficeColorScheme = Office2007ColorScheme.Silver;
                        this.buttonAdv1.Office2007ColorScheme = Office2007Theme.Silver;
                        this.buttonAdv2.Office2007ColorScheme = Office2007Theme.Silver;
                        this.buttonAdv3.Office2007ColorScheme = Office2007Theme.Silver;
                    }
                    else if (this.scrollersFrame2.VisualStyle == ScrollBarCustomDrawStyles.Office2010)
                    {
                        this.scrollersFrame2.Office2010ColorScheme = Office2010ColorScheme.Silver;
                        this.buttonAdv1.Office2010ColorScheme = Office2010Theme.Silver;
                        this.buttonAdv2.Office2010ColorScheme = Office2010Theme.Silver;
                        this.buttonAdv3.Office2010ColorScheme = Office2010Theme.Silver;
                    }
                    this.mainFrameBarManager1.Office2007Theme = Office2007Theme.Silver;
                    this.BackColor = Color.FromArgb(202, 207, 217);
                  
                    this.gradientPanel1.BorderColor = Color.Gray;
                    break;
                case "Black":                   
                    barItem9.Checked = true;
                    if (this.scrollersFrame2.VisualStyle == ScrollBarCustomDrawStyles.Office2007)
                    {
                        this.scrollersFrame2.OfficeColorScheme = Office2007ColorScheme.Black;
                        this.buttonAdv1.Office2007ColorScheme = Office2007Theme.Black;
                        this.buttonAdv2.Office2007ColorScheme = Office2007Theme.Black;
                        this.buttonAdv3.Office2007ColorScheme = Office2007Theme.Black;
                    }
                    else if (this.scrollersFrame2.VisualStyle == ScrollBarCustomDrawStyles.Office2010)
                    {
                        this.scrollersFrame2.Office2010ColorScheme = Office2010ColorScheme.Black;         
                        this.buttonAdv1.Office2010ColorScheme = Office2010Theme.Black;
                        this.buttonAdv2.Office2010ColorScheme = Office2010Theme.Black;
                        this.buttonAdv3.Office2010ColorScheme = Office2010Theme.Black;
                    }
                    this.mainFrameBarManager1.Office2007Theme = Office2007Theme.Black;
                    this.BackColor = Color.FromArgb(113, 113, 113);
               
                    this.gradientPanel1.BorderColor = Color.LightGray;
                    break;
            }
        }
        #endregion
      
        private void UnCheckAll()
        {
            this.barItem7.Checked = false;
            this.barItem8.Checked = false;
            this.barItem9.Checked = false;
        }

        private void UnCheckVisualStyle()
        {
            this.barItem1.Checked = false;
            this.barItem2.Checked = false;
            this.barItem3.Checked = false;
            this.barItem4.Checked = false;
        }

        private void buttonAdv3_Click(object sender, EventArgs e)
        {
            treeView3.CollapseAll();
        }

        private void parentBarItem4_Click(object sender, EventArgs e)
        {
        }

        private void barItem1_Click(object sender, EventArgs e)
        {
            UnCheckVisualStyle();
            this.barItem1.Checked = true;
            this.mainFrameBarManager1.Style = VisualStyle.Default;
            parentBarItem4.Enabled = false;
            this.BackColor = Color.White;
            this.scrollersFrame2.VisualStyle = ScrollBarCustomDrawStyles.Classic;
            this.buttonAdv1.Appearance = ButtonAppearance.Classic;
            this.buttonAdv2.Appearance = ButtonAppearance.Classic;
            this.buttonAdv3.Appearance = ButtonAppearance.Classic;
        }

        private void barItem3_Click(object sender, EventArgs e)
        {
            UnCheckVisualStyle();
            this.barItem3.Checked = true;
            this.scrollersFrame2.VisualStyle = ScrollBarCustomDrawStyles.Office2007;
            parentBarItem4.Enabled = true;
            this.buttonAdv1.Appearance = ButtonAppearance.Office2007;
            this.buttonAdv2.Appearance = ButtonAppearance.Office2007;
            this.buttonAdv3.Appearance = ButtonAppearance.Office2007;
        }

        private void barItem2_Click(object sender, EventArgs e)
        {
            UnCheckVisualStyle();
            this.barItem2.Checked = true;
            this.mainFrameBarManager1.Style = VisualStyle.Office2010;
            parentBarItem4.Enabled = true;
            this.BackColor = Color.White;
            this.scrollersFrame2.VisualStyle = ScrollBarCustomDrawStyles.Office2010;
            this.buttonAdv1.Appearance = ButtonAppearance.Office2010;
            this.buttonAdv2.Appearance = ButtonAppearance.Office2010;
            this.buttonAdv3.Appearance = ButtonAppearance.Office2010;
        }

        private void barItem4_Click(object sender, EventArgs e)
        {
            UnCheckVisualStyle();
            this.barItem4.Checked = true;
            this.mainFrameBarManager1.Style = VisualStyle.Metro;
            parentBarItem4.Enabled = false;          
            this.BackColor = Color.White;
            this.scrollersFrame2.VisualStyle = ScrollBarCustomDrawStyles.Metro;
            this.buttonAdv1.Appearance = ButtonAppearance.Metro;
            this.buttonAdv2.Appearance = ButtonAppearance.Metro;
            this.buttonAdv3.Appearance = ButtonAppearance.Metro;
        }

    }
}
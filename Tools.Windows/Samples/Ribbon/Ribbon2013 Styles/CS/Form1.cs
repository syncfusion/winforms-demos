using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Syncfusion.Windows.Forms.Tools;

namespace BackStageDemo
{
    public partial class Form1 : RibbonForm
    {
        Syncfusion.Windows.Forms.Tools.ToolStripTabGroup toolStripTabGroup1 = new Syncfusion.Windows.Forms.Tools.ToolStripTabGroup();
        public Form1()
        {
            InitializeComponent();
            toolStripTabGroup1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            toolStripTabGroup1.Name = "Layout";
            toolStripTabGroup1.Visible = true;         

            getIcon(false);
            Point[] point = new Point[2];
            point[0] = new Point(this.transparentPanel3.Left + 2, this.transparentPanel3.Top + this.transparentPanel3.Height - 2);
            point[1] = new Point(this.transparentPanel3.Left + this.transparentPanel3.Width - 2, this.transparentPanel3.Top + this.transparentPanel3.Height - 2);
            this.panel3.Invalidate();
            panel2.Location = new Point(0, 0);
            foreach (ToolStripTabItem items in this.ribbonControlAdv1.Header.MainItems)
            {
                foreach (ToolStripEx item in items.Panel.Controls)
                {
                    item.LauncherClick += new EventHandler(item_LauncherClick);
                }
            } 
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
        #region Form Icon
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
        #endregion
        private void Form1_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.Padding = new Padding(1);
            this.toolStripEx12.CollapsedDropDownButtonText = "Tags";
            this.toolStripEx12.Image = global::WindowsFormsApplication626.Properties.Resources.follow;
            this.toolStripEx10.CollapsedDropDownButtonText = "Include";
            this.toolStripEx10.Image = global::WindowsFormsApplication626.Properties.Resources.attach;
            this.toolStripEx9.CollapsedDropDownButtonText = "Names";
            this.toolStripEx9.Image = global::WindowsFormsApplication626.Properties.Resources.address;
            this.toolStripEx5.CollapsedDropDownButtonText = "Basic Text";
            this.toolStripEx5.Image = this.toolStripButton15.Image;
            this.toolStripEx13.CollapsedDropDownButtonText = "Permission";
            this.toolStripEx9.Image = global::WindowsFormsApplication626.Properties.Resources.permission;
            this.toolStripEx3.CollapsedDropDownButtonText = "Themes";
            this.toolStripEx14.Image = global::WindowsFormsApplication626.Properties.Resources.themes;
            this.toolStripEx14.CollapsedDropDownButtonText = "Tracking";
            this.toolStripEx14.Image = global::WindowsFormsApplication626.Properties.Resources.use;
            this.toolStripEx16.CollapsedDropDownButtonText = "Zoom";
            this.toolStripEx16.Image = this.toolStripButton30.Image;
            this.toolStripEx17.CollapsedDropDownButtonText = "Ink";
            this.toolStripEx17.Image = this.toolStripButton33.Image;
            this.ribbonControlAdv1.TouchMode = true;
            this.transparentPanel2.Image = global::WindowsFormsApplication626.Properties.Resources.Disdark;
            this.transparentPanel1.Image = global::WindowsFormsApplication626.Properties.Resources.Dislight;
            getDisabled(true);
        }
        private void getDisabled()
        {

            this.transparentPanel3.Image = global::WindowsFormsApplication626.Properties.Resources.Dis2013;
            this.transparentPanel2.Image = global::WindowsFormsApplication626.Properties.Resources.Disdark;
            this.transparentPanel1.Image = global::WindowsFormsApplication626.Properties.Resources.Dislight;

        }
        private void getDisabled(bool value)
        {
            this.transparentPanel16.Image = global::WindowsFormsApplication626.Properties.Resources.DisFloweral;
            this.transparentPanel15.Image = global::WindowsFormsApplication626.Properties.Resources.DisCircles2;
            this.transparentPanel12.Image = global::WindowsFormsApplication626.Properties.Resources.DisCircles;
            this.transparentPanel14.Image = global::WindowsFormsApplication626.Properties.Resources.DisDottedArrows;
            this.transparentPanel13.Image = global::WindowsFormsApplication626.Properties.Resources.DisLines;
            this.transparentPanel7.Image = global::WindowsFormsApplication626.Properties.Resources.DisNodes;
            this.transparentPanel8.Image = global::WindowsFormsApplication626.Properties.Resources.DisBirds;
            this.transparentPanel9.Image = global::WindowsFormsApplication626.Properties.Resources.DisBoxes3D;
            this.transparentPanel10.Image = global::WindowsFormsApplication626.Properties.Resources.DisBubbles;
            this.transparentPanel11.Image = global::WindowsFormsApplication626.Properties.Resources.DisButterflies;
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            ribbonControlAdv1.RibbonStyle = RibbonStyle.Office2013;
        }
        private void transparentPanel1_Click(object sender, EventArgs e)
        {
            getDisabled();
            this.ribbonControlAdv1.RibbonStyle = RibbonStyle.Office2013;
            this.ribbonControlAdv1.Office2013ColorScheme = Office2013ColorScheme.DarkGray;
            this.transparentPanel1.Image = global::WindowsFormsApplication626.Properties.Resources.dark;
        }

        private void transparentPanel2_Click(object sender, EventArgs e)
        {
            getDisabled();
            this.ribbonControlAdv1.RibbonStyle = RibbonStyle.Office2013;
            this.ribbonControlAdv1.Office2013ColorScheme = Office2013ColorScheme.LightGray;
            this.transparentPanel2.Image = global::WindowsFormsApplication626.Properties.Resources.light;
        }

        private void transparentPanel3_Click(object sender, EventArgs e)
        {
            getDisabled();
            this.ribbonControlAdv1.RibbonStyle = RibbonStyle.Office2013;
            this.ribbonControlAdv1.Office2013ColorScheme = Office2013ColorScheme.White;
            this.transparentPanel3.Image = global::WindowsFormsApplication626.Properties.Resources._2013;

        }
        private void getIcon(bool value)
        {
            if (value)
            {
                
                this.backStageButton5.Image = global::WindowsFormsApplication626.Properties.Resources.Options;
                this.backStageButton4.Image = global::WindowsFormsApplication626.Properties.Resources.Close32;
                this.backStageButton3.Image = global::WindowsFormsApplication626.Properties.Resources.Open32;
                this.backStageButton2.Image = global::WindowsFormsApplication626.Properties.Resources.SaveAs32;
                this.backStageButton1.Image = global::WindowsFormsApplication626.Properties.Resources.Save16;
            }
            else
            {
               
                this.backStageButton5.Image = null;
                this.backStageButton4.Image = null;
                this.backStageButton3.Image = null;
                this.backStageButton2.Image = null;
                this.backStageButton1.Image = null;
            }
        }

     
        private void transparentPanel12_Click(object sender, EventArgs e)
        {
            getDisabled(true);
            this.ribbonControlAdv1.RibbonHeaderImage = RibbonHeaderImage.Circles;
            this.transparentPanel12.Image = global::WindowsFormsApplication626.Properties.Resources.Circles;
        }

        private void transparentPanel8_Click(object sender, EventArgs e)
        {
            getDisabled(true);
            this.ribbonControlAdv1.RibbonHeaderImage = RibbonHeaderImage.Birds;
            this.transparentPanel8.Image = global::WindowsFormsApplication626.Properties.Resources.Birds;
        }

        private void transparentPanel9_Click(object sender, EventArgs e)
        {
            getDisabled(true);
            this.ribbonControlAdv1.RibbonHeaderImage = RibbonHeaderImage.Boxes3D;
            this.transparentPanel9.Image = global::WindowsFormsApplication626.Properties.Resources.Boxes3D;
        }

        private void transparentPanel10_Click(object sender, EventArgs e)
        {
            getDisabled(true);
            this.ribbonControlAdv1.RibbonHeaderImage = RibbonHeaderImage.Bubbles;
            this.transparentPanel10.Image = global::WindowsFormsApplication626.Properties.Resources.Bubbles;

        }

        private void transparentPanel11_Click(object sender, EventArgs e)
        {
            getDisabled(true);
            this.ribbonControlAdv1.RibbonHeaderImage = RibbonHeaderImage.Butterflies;
            this.transparentPanel11.Image = global::WindowsFormsApplication626.Properties.Resources.Butterflies;
        }

        private void transparentPanel16_Click(object sender, EventArgs e)
        {
            getDisabled(true);
            this.ribbonControlAdv1.RibbonHeaderImage = RibbonHeaderImage.Floweral;
            this.transparentPanel16.Image = global::WindowsFormsApplication626.Properties.Resources.Floweral;
        }

        private void transparentPanel15_Click(object sender, EventArgs e)
        {
            getDisabled(true);
            this.ribbonControlAdv1.RibbonHeaderImage = RibbonHeaderImage.Circles2;
            this.transparentPanel15.Image = global::WindowsFormsApplication626.Properties.Resources.Circles2;
        }

        private void transparentPanel14_Click(object sender, EventArgs e)
        {
            getDisabled(true);
            this.ribbonControlAdv1.RibbonHeaderImage = RibbonHeaderImage.DottedArrows;
            this.transparentPanel14.Image = global::WindowsFormsApplication626.Properties.Resources.DottedArrows;
        }

        private void transparentPanel13_Click(object sender, EventArgs e)
        {
            getDisabled(true);
            this.ribbonControlAdv1.RibbonHeaderImage = RibbonHeaderImage.Lines ;
            this.transparentPanel13.Image = global::WindowsFormsApplication626.Properties.Resources.Lines;
        }

        private void transparentPanel7_Click(object sender, EventArgs e)
        {
            getDisabled(true);
            this.ribbonControlAdv1.RibbonHeaderImage = RibbonHeaderImage.Nodes;
            this.transparentPanel7.Image = global::WindowsFormsApplication626.Properties.Resources.Nodes;
        }

        private void getPanel()
        {
        }

        private void toolStripEx2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

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
    }
}

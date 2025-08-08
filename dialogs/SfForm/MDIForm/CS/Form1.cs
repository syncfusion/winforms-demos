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
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Syncfusion.Windows.Forms;
using Syncfusion.WinForms.Controls;

namespace MDIForm
{
    public partial class Form1 : SfForm
    {
        int count = 0;
        System.Drawing.Icon ico;
        public Form1()
        {
            InitializeComponent();
            this.MdiChildActivate += Form1_MdiChildActivate;
            try
            {
                ico = new System.Drawing.Icon(GetIconFile(@"common\Images\Grid\Icon\sficon.ico"));
                this.Icon = ico;
            }
            catch { }
        }

        /// <summary>
        /// Get the SfIcon.
        /// </summary>
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

        /// <summary>
        /// Occurs when an MDI child in activated.
        /// </summary>
        private void Form1_MdiChildActivate(object sender, EventArgs e)
        {
            if ((sender as Form).ActiveMdiChild != null)
            {
                var formText = (sender as Form).ActiveMdiChild.Text;
                foreach (ToolStripItem item in this.windowToolStripMenuItem.DropDownItems)
                {
                    if (item.Text.Equals(formText))
                    {
                        ((ToolStripMenuItem)item).Checked = true;
                    }
                    else
                    {
                        ((ToolStripMenuItem)item).Checked = false;
                    }
                }
            }
        }

        /// <summary>
        /// Occurs when chlicking on the New Menu
        /// </summary>
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            count++;
            SfForm childForm = new SfForm();
            childForm.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            childForm.AutoScaleMode = AutoScaleMode.Font;
            childForm.MdiParent = this;
            childForm.Height = (int)DpiAware.LogicalToDeviceUnits(170.0f);
            childForm.Text = "MDI Child - " + count;
            childForm.Name = "SfForm" + count;
            childForm.Icon = ico;
            this.windowToolStripMenuItem.DropDownItems.Add(childForm.Text, null, On_ChildMenuClick);
            childForm.Show();
            childForm.FormClosed += ChildForm_FormClosed;
        }

        /// <summary>
        /// Occurs when any MDI child is closed.
        /// </summary>
        private void ChildForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            foreach (ToolStripItem item in this.windowToolStripMenuItem.DropDownItems)
            {
                if (item.Text.Equals((sender as Form).Text))
                {
                    this.windowToolStripMenuItem.DropDownItems.Remove(item);
                    count--;
                    break;
                }
            }
        }

        /// <summary>
        /// Occurs when clicking on the Form name in Windows Menu.
        /// </summary>
        private void On_ChildMenuClick(object sender, EventArgs e)
        {
            var formtext = (sender as ToolStripItem).Text;

            foreach (ToolStripItem item in this.windowToolStripMenuItem.DropDownItems)
            {
                if (item.Text.Equals(formtext))
                {
                    ((ToolStripMenuItem)item).Checked = true;
                    break;
                }
            }

            foreach (Form form in this.MdiChildren)
            {
                if (form.Text.Equals(formtext))
                {
                    form.BringToFront();
                }
            }
        }

        /// <summary>
        /// Close the active MDI child.
        /// </summary>
        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ActiveMdiChild.Close();
        }

        /// <summary>
        /// Close the 'parent form.
        /// </summary>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        /// <summary>
        /// Close all the MDI children.
        /// </summary>
        private void closeAllWindowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form form in this.MdiChildren)
            {
                form.Close();
            }
        }

        /// <summary>
        /// Disable the close option when no MDI child is active.
        /// </summary>
        private void FileToolStripMenuItem_DropDownOpening(object sender, System.EventArgs e)
        {
            if (this.ActiveMdiChild == null)
                fileToolStripMenuItem.DropDownItems[1].Enabled = false;
            else
                fileToolStripMenuItem.DropDownItems[1].Enabled = true;
        }

        /// <summary>
        /// Disable the closeAll option when no MDI child is active.
        /// </summary>
        private void WindowToolStripMenuItem_DropDownOpening(object sender, System.EventArgs e)
        {
            if (this.ActiveMdiChild == null)
                windowToolStripMenuItem.DropDownItems[0].Enabled = false;
            else
                windowToolStripMenuItem.DropDownItems[0].Enabled = true;
        }
    }
}

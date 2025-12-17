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
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp73
{
    public partial class Form1 : MetroForm
    {
        public Form1()
        {
            InitializeComponent();
#if NETCORE
            this.Icon = new System.Drawing.Icon(@"..\\..\\..\\\sficon.ico");
#else
            this.Icon = new System.Drawing.Icon(@"..\\..\\\sficon.ico");
#endif
            this.BorderColor = ColorTranslator.FromHtml("#d6dbe9");
            this.MetroColor = ColorTranslator.FromHtml("#d6dbe9");
            this.bar1.BarStyle = Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.IsMainMenu | Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.Visible;
            this.controlBar1.Width = 282;
            this.controlBar2.Width = 282;
            this.controlBar1.DockState = Syncfusion.Windows.Forms.Tools.CommandBarDockState.Left;
            this.controlBar2.DockState = Syncfusion.Windows.Forms.Tools.CommandBarDockState.Right;
            VS2005Colors.BarItemHighlightDarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(96)))), ((int)(((byte)(130)))));
            VS2005Colors.BarItemHighlightLightColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(96)))), ((int)(((byte)(130)))));
            VS2005Colors.CommandBarLightColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(96)))), ((int)(((byte)(130)))));
            VS2005Colors.CommandBarDarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(96)))), ((int)(((byte)(130)))));
            this.controlBar1.ForeColor = Color.White;
            this.controlBar2.ForeColor = Color.White;
            this.treeViewAdv1.ForeColor = Color.Black;
            this.treeViewAdv2.ForeColor = Color.Black;
            this.treeViewAdv1.BorderStyle = BorderStyle.None;
            this.barItem1.Click += BarItem1_Click;
            this.barItem2.Click += BarItem2_Click;
            this.barItem3.Click += BarItem3_Click;
            this.barItem4.Click += BarItem4_Click;
            this.barItem5.Click += BarItem5_Click;
            this.barItem6.Click += BarItem6_Click;
        }

        private void BarItem6_Click(object sender, System.EventArgs e)
        {
            this.controlBar1.Hide();
            this.treeViewAdv1.Hide();
            this.textBoxExt1.Hide();
            this.gradientPanel.Hide();
        }

        private void BarItem5_Click(object sender, System.EventArgs e)
        {
            this.controlBar1.DisableFloating = true;
            this.controlBar1.DisableDocking = false;
            this.controlBar1.DockState = Syncfusion.Windows.Forms.Tools.CommandBarDockState.Right;
        }

        private void BarItem4_Click(object sender, System.EventArgs e)
        {
            this.controlBar1.DisableFloating = true;
            this.controlBar1.DisableDocking = false;
            this.controlBar1.DockState = Syncfusion.Windows.Forms.Tools.CommandBarDockState.Left;
        }

        private void BarItem3_Click(object sender, System.EventArgs e)
        {
            this.controlBar1.DisableFloating = true;
            this.controlBar1.DisableDocking = false;
            this.controlBar1.DockState = Syncfusion.Windows.Forms.Tools.CommandBarDockState.Bottom;
        }

        private void BarItem2_Click(object sender, System.EventArgs e)
        {
            this.controlBar1.DisableFloating = true;
            this.controlBar1.DisableDocking = false;
            this.controlBar1.DockState = Syncfusion.Windows.Forms.Tools.CommandBarDockState.Top;
        }
        
        private void BarItem1_Click(object sender, System.EventArgs e)
        {
            this.controlBar1.DisableFloating = false;
            this.controlBar1.DisableDocking = true;
        }
    }
}

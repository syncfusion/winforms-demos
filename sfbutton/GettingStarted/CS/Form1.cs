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
#if !NETCORE
using DemoCommon.Grid;
#endif
using Syncfusion.WinForms.Controls;

namespace GettingStarted
{
    public partial class Form1 : Form
    {

        public Form1()
        {
#if NETCORE
            this.Icon = new System.Drawing.Icon(@"..\\..\\..\\\sficon.ico");
#else
            this.Icon = new System.Drawing.Icon(@"..\\..\\\sficon.ico");
#endif
            InitializeComponent();
            InitializeButtonSettings();
            SampleSettings();
            this.MouseWheel += Form1_MouseWheel;
        }

        /// <summary>
        /// Occurs when mouse wheel operation occurs for the form.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">A mouse event arguments.</param>
        void Form1_MouseWheel(object sender, MouseEventArgs e)
        {
            panel2.Focus();
        }
        
        /// <summary>
        /// Customize the style settings for the buttons.
        /// </summary>
        private void InitializeButtonSettings()
        {        
            //Initialize no borders for the icon buttons
            IconButton1.Style.HoverBorder = null;
            IconButton1.Style.FocusedBorder = null;
            IconButton2.Style.HoverBorder = null;
            IconButton2.Style.FocusedBorder = null;
            IconButton3.Style.HoverBorder = null;
            IconButton3.Style.FocusedBorder = null;

            ImageButton1.Style.FocusedBorder = null;
            ImageButton1.Style.FocusedBackColor = ImageButton1.Style.PressedBackColor;

            ImageButton2.Style.FocusedBorder = null;
            ImageButton2.Style.FocusedBackColor = ImageButton1.Style.PressedBackColor;

            ImageButton3.Style.FocusedBorder = null;
            ImageButton3.Style.FocusedBackColor = ImageButton1.Style.PressedBackColor;            
        }

        /// <summary>
        /// Initialize the sample settings.
        /// </summary>
        private void SampleSettings()
        {
            //Initialize fore colors for labels
            label3.ForeColor = ColorTranslator.FromHtml("#171717");
            label5.ForeColor = ColorTranslator.FromHtml("#171717");
            label7.ForeColor = ColorTranslator.FromHtml("#171717");
            label9.ForeColor = ColorTranslator.FromHtml("#171717");
            label10.ForeColor = ColorTranslator.FromHtml("#171717");
            label11.ForeColor = ColorTranslator.FromHtml("#171717");
            label12.ForeColor = ColorTranslator.FromHtml("#171717");
            label13.ForeColor = ColorTranslator.FromHtml("#171717");
            label15.ForeColor = ColorTranslator.FromHtml("#171717");
            label2.ForeColor = ColorTranslator.FromHtml("#666666");
            label4.ForeColor = ColorTranslator.FromHtml("#666666");
            label6.ForeColor = ColorTranslator.FromHtml("#666666");
            label8.ForeColor = ColorTranslator.FromHtml("#666666");
            label14.ForeColor = ColorTranslator.FromHtml("#666666");
            label16.ForeColor = ColorTranslator.FromHtml("#666666");            
            label20.ForeColor = ColorTranslator.FromHtml("#CCCCCC");
            label21.ForeColor = ColorTranslator.FromHtml("#CCCCCC");
            checkBox1.ForeColor = ColorTranslator.FromHtml("#333333");
        }

        /// <summary>
        /// Changes the state of the SfButton to enabled or disabled. If this checkbox is checked, then all the SfButtons
        /// are disabled, otherwise all the SfButtons are enabled.
        /// </summary>
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            foreach (Control control in this.panel2.Controls)
            {
                if (control is SfButton)
                {
                    SfButton sfbutton = control as SfButton;
                    sfbutton.Enabled = !checkBox1.Checked;
                }
                else
                {
                    foreach (Control button in control.Controls)
                    {
                        if (button is SfButton)
                        {
                            SfButton sfbutton = button as SfButton;
                            sfbutton.Enabled = !checkBox1.Checked;
                        }
                    }
                }
            }
        }       
    }
}

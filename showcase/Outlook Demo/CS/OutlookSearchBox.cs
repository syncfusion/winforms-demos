#region Copyright Syncfusion Inc. 2001-2023.
// Copyright Syncfusion Inc. 2001-2023. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Syncfusion.Windows.Forms;

namespace OutlookDemo_2010
{
    public partial class OutlookSearchBox : UserControl
    {
        public OutlookSearchBox()
        {
            InitializeComponent();
            this.buttonEdit2.TextBox.Text = "By Date";
            this.buttonEdit1.TextBox.ForeColor = Color.FromArgb(68, 68, 68);
            this.buttonEdit2.TextBox.ForeColor = Color.FromArgb(68, 68, 68);
            this.buttonEditChildButton1.BackColor = Color.White;
            this.buttonEditChildButton2.BackColor = Color.White;
            this.buttonEditChildButton3.BackColor = Color.White;
            this.buttonEdit2.MetroColor = Color.White;
            this.buttonEdit2.TextBox.BackColor = Color.White;
            this.buttonEdit2.TextBox.Enabled = false;
            this.label1.ForeColor = Color.FromArgb(58, 187, 246);
            this.buttonEdit1.TextBox.ForeColor = Color.Gray;
            this.comboBoxAdv1.ForeColor = Color.FromArgb(68, 68, 68);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.buttonEdit1.Size = new Size((int)DpiAware.LogicalToDeviceUnits(200), 23);
            this.buttonEdit2.Size = new Size((int)DpiAware.LogicalToDeviceUnits(112), 29);
            this.comboBoxAdv1.Location = new Point(this.buttonEdit1.Location.X + this.buttonEdit1.Width , this.comboBoxAdv1.Location.Y);
            this.buttonEdit2.Location = new Point(this.Width - this.label2.Location.X - label2.Width - this.buttonEdit2.Margin.Left, this.buttonEdit2.Location.Y - 5);
            this.comboBoxAdv1.Style = VisualStyle.Metro;
            this.comboBoxAdv1.MetroBorderColor = ColorTranslator.FromHtml("#a0a0a0");
            this.buttonEdit1.UseVisualStyle = false;
            this.buttonEdit2.UseVisualStyle = false;
            this.buttonEdit1.Border3DStyle = Border3DStyle.Flat;
            this.buttonEdit2.Border3DStyle = Border3DStyle.Flat;
            this.buttonEditChildButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEditChildButton1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonEditChildButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.buttonEditChildButton1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonEdit1.FlatBorderColor = System.Drawing.Color.White;
            this.buttonEdit2.FlatBorderColor = System.Drawing.Color.White;
            this.buttonEditChildButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEditChildButton2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonEditChildButton2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.buttonEditChildButton1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonEditChildButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEditChildButton3.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonEditChildButton3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.buttonEditChildButton1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.SizeChanged += OutlookSearchBox_SizeChanged;
        }

        private void OutlookSearchBox_SizeChanged(object sender, EventArgs e)
        {
            this.buttonEdit1.Width = this.Width -  this.comboBoxAdv1.Width - (int)DpiAware.LogicalToDeviceUnits(50);
            this.buttonEdit1.Height = (int)DpiAware.LogicalToDeviceUnits(20);
            this.comboBoxAdv1.Location = new Point(this.Width - this.buttonEdit1.Location.X - this.comboBoxAdv1.Width - this.comboBoxAdv1.Margin.Left + (int)DpiAware.LogicalToDeviceUnits(25), this.comboBoxAdv1.Location.Y);
            this.buttonEdit2.Location = new Point(this.Width - this.buttonEdit1.Location.X - this.comboBoxAdv1.Width - this.comboBoxAdv1.Margin.Left + (int)DpiAware.LogicalToDeviceUnits(25), this.buttonEdit2.Location.Y );
        }

        private string m_SearchString = string.Empty;

        public string SearchString
        {
            get { return m_SearchString; }
            set { m_SearchString = value; }
        }



        private bool m_Label1Clicked = false;

        public bool Label1Clicked
        {
            get { return m_Label1Clicked; }
            set
            {
                m_Label1Clicked = value;
                label1.ForeColor = Color.FromArgb(58, 187, 246);
                label2.ForeColor = Color.FromArgb(68, 68, 68);
            }
        }

        private bool m_Label2Clicked = false;
        public bool Label2Clicked
        {
            get { return m_Label2Clicked; }
            set
            {
                m_Label2Clicked = value;
                label1.ForeColor = Color.FromArgb(68, 68, 68);
                label2.ForeColor = Color.FromArgb(58, 187, 246);
            }
        }

        // All

        private void label1_MouseEnter(object sender, EventArgs e)
        {
            (sender as Label).ForeColor = Color.FromArgb(58, 187, 246);
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            if (!this.Label1Clicked)
                (sender as Label).ForeColor = Color.FromArgb(68, 68, 68);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Label2Clicked = false;
            Label1Clicked = true;
        }
        
        // Unread

        private void label2_Click(object sender, EventArgs e)
        {
            Label1Clicked = false;
            Label2Clicked = true;
        }

        private void label2_MouseEnter(object sender, EventArgs e)
        {
            (sender as Label).ForeColor = Color.FromArgb(58, 187, 246);
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            if (!Label2Clicked)
                (sender as Label).ForeColor = Color.FromArgb(68, 68, 68);
        }
    }
}

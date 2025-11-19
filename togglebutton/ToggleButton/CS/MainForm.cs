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
using System.Windows.Forms;
using Syncfusion.Windows.Forms;
using Syncfusion.Windows.Forms.Tools;

namespace ToggleButtonDemo2010
{
    public partial class MainForm : MetroForm
    {
        public MainForm()
        {
            InitializeComponent();
            this.toggleButton1.ToggleStateChanged += new Syncfusion.Windows.Forms.Tools.ToggleStateChangedEventHandler(toggleButton1_ToggleStateChanged);
            this.toggleButton1.Location = new Point(this.gradientPanel3.Width / 2 - this.toggleButton1.Width / 2, this.gradientPanel3.Height / 2 - this.toggleButton1.Height / 2);
            this.SizeChanged += new EventHandler(MainForm_SizeChanged);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.comboBoxAdv3.DropDownStyle = ComboBoxStyle.DropDownList;
            this.comboBoxAdv6.SelectedIndex = 1;
#if NETCORE
            this.Icon = new Icon("..//..//..//icon_Zov_icon.ico");
#else
            this.Icon = new Icon("..//..//icon_Zov_icon.ico");
#endif
        }

        void MainForm_SizeChanged(object sender, EventArgs e)
        {
            this.toggleButton1.Location = new Point(this.gradientPanel3.Width / 2 - this.toggleButton1.Width / 2, this.gradientPanel3.Height / 2 - this.toggleButton1.Height / 2);
        }

        void toggleButton1_ToggleStateChanged(object sender, Syncfusion.Windows.Forms.Tools.ToggleStateChangedEventArgs e)
        {
            if (e.ToggleState == Syncfusion.Windows.Forms.Tools.ToggleButtonState.Active)
            {
                this.toggleButton1.Slider.Image = global::ToggleButtonDemo2010.Properties.Resources.big_tick;
                this.comboBoxAdv2.SelectedIndex = 0;
                this.textBoxExt1.Text = "OFF";
            }
            else
            {
                this.toggleButton1.Slider.Image = global::ToggleButtonDemo2010.Properties.Resources.Wrong;
                this.textBoxExt1.Text = "ON";
                this.comboBoxAdv2.SelectedIndex = 1;
            }
        }

        private void comboBoxAdv2_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(this.comboBoxAdv2.SelectedIndex)
            {
                case 0:
                    this.toggleButton1.ToggleState = Syncfusion.Windows.Forms.Tools.ToggleButtonState.Active;
                    break;
                case 1:
                    this.toggleButton1.ToggleState = Syncfusion.Windows.Forms.Tools.ToggleButtonState.Inactive;
                    break;
            }
        }

        private void textBoxExt1_TextChanged(object sender, EventArgs e)
        {
            if (this.comboBoxAdv2.SelectedIndex == 0)
                this.toggleButton1.ActiveState.Text = this.textBoxExt1.Text;
            else
                this.toggleButton1.InactiveState.Text = this.textBoxExt1.Text;
            this.Refresh();
        }

        private void colorPickerUIAdv1_Picked(object sender, Syncfusion.Windows.Forms.Tools.ColorPickerUIAdv.ColorPickedEventArgs args)
        {
            if (this.comboBoxAdv2.SelectedIndex == 0)
            {
                switch (this.comboBoxAdv1.SelectedIndex)
                {
                    case 0:
                        this.toggleButton1.ActiveState.BackColor = args.Color;
                        break;
                    case 1:
                        this.toggleButton1.ActiveState.BorderColor = args.Color;
                        break;
                    case 2:
                        this.toggleButton1.ActiveState.ForeColor = args.Color;
                        break;
                    case 3:
                        this.toggleButton1.ActiveState.HoverColor = args.Color;
                        break;
                }
            }
            else
            {
                switch (this.comboBoxAdv1.SelectedIndex)
                {
                    case 0:
                        this.toggleButton1.InactiveState.BackColor = args.Color;
                        break;
                    case 1:
                        this.toggleButton1.InactiveState.BorderColor = args.Color;
                        break;
                    case 2:
                        this.toggleButton1.InactiveState.ForeColor = args.Color;
                        break;
                    case 3:
                        this.toggleButton1.InactiveState.HoverColor = args.Color;
                        break;
                }
            }
            this.Refresh();
        }

        private void comboBoxAdv3_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(this.comboBoxAdv3.SelectedIndex)
            {
                case 0:
                    this.toggleButton1.Slider.DisplayMode = Syncfusion.Windows.Forms.Tools.DisplayType.Text;
                    this.toggleButton1.Invalidate();
                    this.textBoxExt2.Enabled = true;
                    break;
                case 1:
                    {
                        this.toggleButton1.Slider.DisplayMode = Syncfusion.Windows.Forms.Tools.DisplayType.Image;
                        if (this.toggleButton1.ToggleState == Syncfusion.Windows.Forms.Tools.ToggleButtonState.Active)
                            this.toggleButton1.Slider.Image = global::ToggleButtonDemo2010.Properties.Resources.big_tick;
                        else
                            this.toggleButton1.Slider.Image = global::ToggleButtonDemo2010.Properties.Resources.Wrong;
                        this.toggleButton1.Invalidate();
                        this.textBoxExt2.Enabled = false;
                    }
                    break;
            }
        }

        private void textBoxExt2_TextChanged(object sender, EventArgs e)
        {
            this.toggleButton1.Slider.Text = this.textBoxExt2.Text;
            this.Refresh();
        }

        void comboBox1_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            switch (this.comboBox1.SelectedIndex)
                {
                    case 0:
                        this.toggleButton1.Slider.Width = 5;
                        break;
                    case 1:
                        this.toggleButton1.Slider.Width = 10;
                        break;
                    case 2:
                        this.toggleButton1.Slider.Width = 20;
                        break;
                    case 3:
                        this.toggleButton1.Slider.Width = 30;
                        break;
                    case 4:
                        this.toggleButton1.Slider.Width = 40;
                        break;
                    case 5:
                        this.toggleButton1.Slider.Width = 50;
                        break;
                    case 6:
                        this.toggleButton1.Slider.Width = 60;
                        break;
                }
            this.Refresh();
        }

        private void colorPickerUIAdv2_Picked(object sender, Syncfusion.Windows.Forms.Tools.ColorPickerUIAdv.ColorPickedEventArgs args)
        {
            switch (this.comboBoxAdv4.SelectedIndex)
            {
                case 0:
                    this.toggleButton1.Slider.BackColor = args.Color;
                    break;
                case 1:
                    this.toggleButton1.Slider.InactiveBackColor = args.Color;
                    break;
                case 2:
                    this.toggleButton1.Slider.BorderColor = args.Color;
                    break;
                case 3:
                    this.toggleButton1.Slider.ForeColor = args.Color;
                    break;
                case 4:
                    this.toggleButton1.Slider.HoverColor = args.Color;
                    break;
                case 5:
                    this.toggleButton1.Slider.InactiveHoverColor = args.Color;
                    break;
            }
            this.Refresh();
        }

        private void checkBoxAdv1_CheckStateChanged(object sender, EventArgs e)
        {
            if (this.checkBoxAdv1.Checked)
                this.toggleButton1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            else
                this.toggleButton1.RightToLeft = System.Windows.Forms.RightToLeft.No;
        }

        private void checkBoxAdv2_CheckStateChanged(object sender, EventArgs e)
        {
            this.toggleButton1.Visible = !this.toggleButton1.Visible;
        }

        private void checkBoxAdv3_CheckStateChanged(object sender, EventArgs e)
        {
            this.toggleButton1.Enabled = !this.toggleButton1.Enabled;
        }
        private void UpdateStyle(Color backColor, Color foreColor)
        {
            this.CaptionBarColor = backColor;
            this.BackColor = backColor;
            this.MetroColor = Color.White;
            this.CaptionForeColor = foreColor;
            this.CaptionButtonColor = foreColor;
            this.CaptionButtonHoverColor = foreColor;

            foreach (Control ctrl in Collect(this.Controls))
            {
                if (!(ctrl is GroupBar))
                {
                    ctrl.BackColor = backColor;
                    ctrl.ForeColor = foreColor;
                }
                if (ctrl is ComboBoxAdv)
                {
                    (ctrl as ComboBoxAdv).Style = VisualStyle.Metro;
                }
                else if (ctrl is CheckBoxAdv)
                {
                    (ctrl as CheckBoxAdv).Style = CheckBoxAdvStyle.Metro;
                }
                else if (ctrl is ButtonEdit)
                {
                    (ctrl as ButtonEdit).ButtonStyle = ButtonAppearance.Office2016White;
                }
            }
        }

        IEnumerable<Control> Collect(Control.ControlCollection ctrls)
        {
            foreach (Control ctrl in ctrls)
            {
                yield return ctrl;

                foreach (var child in Collect(ctrl.Controls))
                    yield return child;
            }
        }

        private void comboBoxAdv6_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.UpdateStyle(Color.White, Color.Black);
            switch (this.comboBoxAdv6.SelectedItem.ToString())
            {
                case "Default":
                    {
                        this.toggleButton1.VisualStyle = Syncfusion.Windows.Forms.Tools.ToggleButtonStyle.Default;
                        SkinManager.SetVisualStyle(this.groupBar1, "Default");
                        this.groupBar1.VisualStyle = VisualStyle.Default;
                        this.groupBarItem1.BackColor = Color.White;
                        this.groupBarItem1.ForeColor = Color.Black;
                        this.groupBarItem2.BackColor = Color.White;
                        this.groupBarItem2.ForeColor = Color.Black;
                        this.groupBarItem3.BackColor = Color.White;
                        this.groupBarItem3.ForeColor = Color.Black;
                    }
                    break;
                case "Office2016Colorful":
                    {
                        this.toggleButton1.VisualStyle = Syncfusion.Windows.Forms.Tools.ToggleButtonStyle.Office2016Colorful;
                        SkinManager.SetVisualStyle(this.groupBar1, "Office2016Colorful");
                        this.groupBar1.VisualStyle = VisualStyle.Office2016Colorful;
                        this.groupBarItem1.BackColor = Color.White;
                        this.groupBarItem1.ForeColor = Color.Black;
                        this.groupBarItem2.BackColor = Color.White;
                        this.groupBarItem2.ForeColor = Color.Black;
                        this.groupBarItem3.BackColor = Color.White;
                        this.groupBarItem3.ForeColor = Color.Black;
                    }
                    break;
                case "Office2016DarkGray":
                    {
                        this.UpdateStyle(ColorTranslator.FromHtml("#666666"), Color.White);
                        this.toggleButton1.VisualStyle = Syncfusion.Windows.Forms.Tools.ToggleButtonStyle.Office2016DarkGray;
                        SkinManager.SetVisualStyle(this.groupBar1, "Office2016DarkGray");
                        this.groupBar1.VisualStyle = VisualStyle.Office2016DarkGray;
                        this.groupBarItem1.BackColor = ColorTranslator.FromHtml("#505050");
                        this.groupBarItem1.ForeColor = Color.White;
                        this.groupBarItem2.BackColor = ColorTranslator.FromHtml("#505050");
                        this.groupBarItem2.ForeColor = Color.White;
                        this.groupBarItem3.BackColor = ColorTranslator.FromHtml("#505050");
                        this.groupBarItem3.ForeColor = Color.White;
                    }
                    break;
                case "Office2016Black":
                    {
                        this.UpdateStyle(ColorTranslator.FromHtml("#262626"), Color.White);
                        this.toggleButton1.VisualStyle = Syncfusion.Windows.Forms.Tools.ToggleButtonStyle.Office2016Black;
                        SkinManager.SetVisualStyle(this.groupBar1, "Office2016Black");
                        this.groupBar1.VisualStyle = VisualStyle.Office2016Black;
                        this.groupBarItem1.BackColor = ColorTranslator.FromHtml("#252525");
                        this.groupBarItem1.ForeColor = Color.White;
                        this.groupBarItem2.BackColor = ColorTranslator.FromHtml("#252525");
                        this.groupBarItem2.ForeColor = Color.White;
                        this.groupBarItem3.BackColor = ColorTranslator.FromHtml("#252525");
                        this.groupBarItem3.ForeColor = Color.White;
                    }
                    break;
                case "Office2016White":
                    {
                        this.toggleButton1.VisualStyle = Syncfusion.Windows.Forms.Tools.ToggleButtonStyle.Office2016White;
                        SkinManager.SetVisualStyle(this.groupBar1, "Office2016White");
                        this.groupBar1.VisualStyle = VisualStyle.Office2016White;
                        this.groupBarItem1.BackColor = Color.White;
                        this.groupBarItem1.ForeColor = Color.Black;
                        this.groupBarItem2.BackColor = Color.White;
                        this.groupBarItem2.ForeColor = Color.Black;
                        this.groupBarItem3.BackColor = Color.White;
                        this.groupBarItem3.ForeColor = Color.Black;
                    }
                    break;
            }
        }

        private void comboBoxAdv5_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (this.comboBoxAdv5.SelectedIndex)
            {
                case 0:
                    this.toggleButton1.DisplayMode = Syncfusion.Windows.Forms.Tools.DisplayType.Text;
                    break;
                case 1:
                    {
                        this.toggleButton1.DisplayMode = Syncfusion.Windows.Forms.Tools.DisplayType.Image;
                        this.toggleButton1.ActiveState.Image = global::ToggleButtonDemo2010.Properties.Resources.Wrong;
                        this.toggleButton1.InactiveState.Image = global::ToggleButtonDemo2010.Properties.Resources.big_tick;
                    }
                    break;
            }
        }

        private void gradientPanel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

#region Copyright Syncfusion Inc. 2001 - 2019
// Copyright Syncfusion Inc. 2001 - 2019. All rights reserved.
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
using System.Runtime.InteropServices;

namespace GaugeTheme_2010
{
    public partial class ThemeChoiceControl : UserControl
    {
        public PopupControlContainer popup = new PopupControlContainer();
        public SyncfColorPicker ColorPicker = new SyncfColorPicker();
        public static Color SelectedColor = Color.Empty;
        [DllImport("user32.dll")]
        private static extern long LockWindowUpdate(long Handle);

        public ThemeChoiceControl()
        {
            InitializeComponent();
            popup.PopupParent = this.buttonEdit1;
            //popup.Size = new Size(215, 125); 
            popup.Visible = false;
            ColorPicker.ParentControl = this;
            this.Controls.Add(popup);
            popup.Controls.Add(ColorPicker);
            ColorPicker.Dock = DockStyle.Fill;
            this.buttonEditChildButton1.Click += buttonEditChildButton1_Click;
            this.ColorPicker.Picked += ColorPicker_Picked;
            this.textBoxExt2.ReadOnly = true;
            this.textBoxExt2.BackColor = Color.White;
        }

        private void ColorPicker_Picked(object sender, Syncfusion.Windows.Forms.Tools.ColorPickerUIAdv.ColorPickedEventArgs args)
        {
            this.textBoxExt2.Text = ColorTranslator.ToHtml(args.Color);
            this.textBoxExt2.SelectionStart = this.textBoxExt2.Text.Length;
            this.textBoxExt2.SelectionLength = this.textBoxExt2.Text.Length;
            this.buttonEditChildButton1.MetroColor = args.Color;
            this.popup.HidePopup(PopupCloseType.Deactivated);
        }

        private void buttonEditChildButton1_Click(object sender, EventArgs e)
        {
            if (!popup.Visible)
            {
                this.popup.ShowPopup(new Point(this.RectangleToScreen(this.buttonEdit1.Bounds).Location.X - 4, this.RectangleToScreen(this.buttonEdit1.Bounds).Location.Y + this.buttonEdit1.Height));
            }
            else
            {
                this.popup.HidePopup(PopupCloseType.Deactivated);
            }
        }
    }
}

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
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Syncfusion.Windows.Forms;
using System.IO;
using Syncfusion.Windows.Forms.Tools;
using System.Runtime.InteropServices;

namespace RadialMenuDemo
{
    public partial class RadialMenuMainForm : MetroForm
    {
        ColorCollection colorCollection = new ColorCollection();
        [DllImport("user32.dll")]
        static extern bool LockWindowUpdate(IntPtr hWndLock);
        #region Initialize

        public RadialMenuMainForm()
        {
            InitializeComponent();
            this.radialMenuItem15.MouseUp += new System.Windows.Forms.MouseEventHandler(this.radialMenuItem5_MouseUp);
            this.radialMenuItem13.MouseUp += new System.Windows.Forms.MouseEventHandler(this.radialMenuItem5_MouseUp);
            this.radialMenu1.BeforeCloseUp += new CancelEventHandler(radialMenu1_BeforeCloseUp);
            this.Load += new EventHandler(RadialMenuMainForm_Load);
            this.radialMenu1.ParentControl = this.richTextBox1;
            this.radialMenu1.MenuVisibility = true;
            this.MinimumSize = this.Size;
            this.richTextBox1.TextChanged += new EventHandler(richTextBox1_TextChanged);
            this.radialMenu1.DisplayStyle = Syncfusion.Windows.Forms.Tools.DisplayStyle.TextAboveImage;
            string path = Application.StartupPath.ToString() + @"..\..\..\Introduction.rtf";
            if (File.Exists(path))
                this.richTextBox1.LoadFile(path, RichTextBoxStreamType.RichText);
            this.radialMenu1.MinimumSize = this.radialMenu1.Size;
            this.richTextBox1.MouseDown += richTextBox1_MouseDown;
            this.richTextBox1.GotFocus += richTextBox1_GotFocus;
#if NETCORE
            this.Icon = new Icon("../../../Icon/Icon.ico");
#else
            this.Icon = new Icon("../../Icon/Icon.ico");
#endif
            UpdateRadialMenuForOffice2016Theme();
            UpdateTheme();
            UpdateItemStyle();
            HookEvents();
            colorCollection.Color2 = Color.Tomato;
            this.colorPickerButton2.BackColor = Color.Tomato;
            this.radialColorPalette1.ColorPaletteItemCollection.Add(colorCollection);

        }

        private void HookEvents()
        {
            this.maximum_Size.ValueChanged += Maximum_Size_ValueChanged;
            this.minimum_Size.ValueChanged += Minimum_Size_ValueChanged;
            this.item_height.ValueChanged += Item_height_ValueChanged;
            this.colorPickerButton1.ColorSelected += ColorPickerButton1_ColorSelected;
            this.colorPickerButton2.ColorSelected += ColorPickerButton2_ColorSelected;
            this.colorPickerButton3.ColorSelected += ColorPickerButton3_ColorSelected;
            this.colorPickerButton4.ColorSelected += ColorPickerButton4_ColorSelected;
            this.colorPickerButton5.ColorSelected += ColorPickerButton5_ColorSelected;
            this.colorPickerButton6.ColorSelected += ColorPickerButton6_ColorSelected;
            this.colorPickerButton7.ColorSelected += ColorPickerButton7_ColorSelected;
            this.colorPickerButton8.ColorSelected += ColorPickerButton8_ColorSelected;
            this.apply_button.Click += Apply_button_Click;
            this.color_checkBoxAdv.CheckedChanged += Color_checkBoxAdv_CheckedChanged;
            this.cut_checkBoxAdv.CheckedChanged += Color_checkBoxAdv_CheckedChanged;
            this.copy_checkBoxAdv.CheckedChanged += Color_checkBoxAdv_CheckedChanged;
            this.paste_checkBoxAdv.CheckedChanged += Color_checkBoxAdv_CheckedChanged;
            this.undo_checkBoxAdv.CheckedChanged += Color_checkBoxAdv_CheckedChanged;
            this.edit_checkBox.CheckedChanged += Color_checkBoxAdv_CheckedChanged;
            this.size_checkBoxAdv.CheckedChanged += Color_checkBoxAdv_CheckedChanged;
            this.font_checkBoxAdv.CheckedChanged += Color_checkBoxAdv_CheckedChanged;
        }

        private void UpdateItemStyle()
        {
            this.colorPickerButton1.ForeColor = Color.Transparent;
            this.colorPickerButton2.ForeColor = Color.Transparent;
            this.colorPickerButton3.ForeColor = Color.Transparent;
            this.colorPickerButton4.ForeColor = Color.Transparent;
            this.colorPickerButton5.ForeColor = Color.Transparent;
            this.colorPickerButton6.ForeColor = Color.Transparent;
            this.colorPickerButton7.ForeColor = Color.Transparent;
            this.colorPickerButton8.ForeColor = Color.Transparent;

            this.label1.ForeColor = ColorTranslator.FromHtml("#444444");
            this.label2.ForeColor = ColorTranslator.FromHtml("#444444");
            this.label3.ForeColor = ColorTranslator.FromHtml("#444444");
            this.label4.ForeColor = ColorTranslator.FromHtml("#444444");
            this.maximum_label.ForeColor = ColorTranslator.FromHtml("#444444");
            this.minimum_label.ForeColor = ColorTranslator.FromHtml("#444444");
            this.itemheight_label.ForeColor = ColorTranslator.FromHtml("#444444");
            this.apply_button.ForeColor = ColorTranslator.FromHtml("#444444");

        }

        private void UpdateTheme()
        {
            this.maximum_Size.ThemeName = "Office2016Colorful";
            this.minimum_Size.ThemeName = "Office2016Colorful";
            this.item_height.ThemeName = "Office2016Colorful";

            this.colorPickerButton1.ThemeName = "Office2016Colorful";
            this.colorPickerButton2.ThemeName = "Office2016Colorful";
            this.colorPickerButton3.ThemeName = "Office2016Colorful";
            this.colorPickerButton4.ThemeName = "Office2016Colorful";
            this.colorPickerButton5.ThemeName = "Office2016Colorful";
            this.colorPickerButton6.ThemeName = "Office2016Colorful";
            this.colorPickerButton7.ThemeName = "Office2016Colorful";
            this.colorPickerButton8.ThemeName = "Office2016Colorful";

            this.apply_button.ThemeName = "Office2016Colorful";

            this.color_checkBoxAdv.ThemeName = "Office2016Colorful";
            this.cut_checkBoxAdv.ThemeName = "Office2016Colorful";
            this.copy_checkBoxAdv.ThemeName = "Office2016Colorful";
            this.paste_checkBoxAdv.ThemeName = "Office2016Colorful";
            this.undo_checkBoxAdv.ThemeName = "Office2016Colorful";
            this.edit_checkBox.ThemeName = "Office2016Colorful";
            this.size_checkBoxAdv.ThemeName = "Office2016Colorful";
            this.font_checkBoxAdv.ThemeName = "Office2016Colorful";

            this.scrollersFrame.VisualStyle = ScrollBarCustomDrawStyles.Office2016;
            this.scrollersFrame.Office2016ColorScheme = ScrollBarOffice2016ColorScheme.Colorful;
        }

        private void ColorPickerButton8_ColorSelected(object sender, EventArgs e)
        {
            colorCollection.Color8 = colorPickerButton8.SelectedColor;
            this.radialMenu1.Refresh();
        }

        private void ColorPickerButton7_ColorSelected(object sender, EventArgs e)
        {
            colorCollection.Color7 = colorPickerButton7.SelectedColor;
            this.radialMenu1.Refresh();
        }

        private void ColorPickerButton6_ColorSelected(object sender, EventArgs e)
        {
            colorCollection.Color6 = colorPickerButton6.SelectedColor;
            this.radialMenu1.Refresh();
        }

        private void Color_checkBoxAdv_CheckedChanged(object sender, EventArgs e)
        {
            foreach (Control ctrl in this.radialMenu1.Items)
            {
                if ((sender as CheckBoxAdv).Text == ctrl.Text)
                {
                    ctrl.Enabled = !(sender as CheckBoxAdv).Checked;
                }
                if (ctrl is RadialMenuItem)
                {
                    if ((ctrl as RadialMenuItem).Items.Count > 0)
                    {
                        setEnabledForSubItems((ctrl as RadialMenuItem), (sender as CheckBoxAdv).Text, !(sender as CheckBoxAdv).Checked);
                    }
                }
            }
            this.radialMenu1.Refresh();
        }

        private void Apply_button_Click(object sender, EventArgs e)
        {
            if (!this.radialColorPalette1.ColorPaletteItemCollection.Contains(colorCollection))
                this.radialColorPalette1.ColorPaletteItemCollection.Add(colorCollection);
        }

        private void ColorPickerButton5_ColorSelected(object sender, EventArgs e)
        {
            colorCollection.Color5 = colorPickerButton5.SelectedColor;
            this.radialMenu1.Refresh();
        }

        private void ColorPickerButton4_ColorSelected(object sender, EventArgs e)
        {
            colorCollection.Color4 = colorPickerButton4.SelectedColor;
            this.radialMenu1.Refresh();
        }

        private void ColorPickerButton3_ColorSelected(object sender, EventArgs e)
        {
            colorCollection.Color3 = colorPickerButton3.SelectedColor;
            this.radialMenu1.Refresh();
        }

        private void ColorPickerButton2_ColorSelected(object sender, EventArgs e)
        {
            colorCollection.Color2 = colorPickerButton2.SelectedColor;
            this.radialMenu1.Refresh();
        }

        private void ColorPickerButton1_ColorSelected(object sender, EventArgs e)
        {
            colorCollection.Color1 = colorPickerButton1.SelectedColor;
            this.radialMenu1.Refresh();
        }

        private void Item_height_ValueChanged(object sender, EventArgs e)
        {
            this.radialFontListBox1.ItemHeight = (int)this.item_height.Value;
        }

        private void Minimum_Size_ValueChanged(object sender, EventArgs e)
        {
            this.radialMenuSlider1.MinimumValue = (int)this.minimum_Size.Value;
        }

        private void Maximum_Size_ValueChanged(object sender, EventArgs e)
        {
            this.radialMenuSlider1.MaximumValue = (int)this.maximum_Size.Value;
        }

        void richTextBox1_GotFocus(object sender, EventArgs e)
        {
            this.radialMenu1.ShowRadialMenu();
        }

        void richTextBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (this.radialMenu1.MenuVisibility)
            {
                this.radialMenu1.ItemOnLoad = null;
                this.radialMenu1.MenuVisibility = false;
                this.radialMenu1.Refresh();
            }
        }

        void richTextBox1_TextChanged(object sender, EventArgs e)
        {

            RichTextBox r = new RichTextBox();
            string path = Application.StartupPath.ToString() + @"..\..\..\Introduction.rtf";
            r.LoadFile(path, RichTextBoxStreamType.RichText);
            if(!this.undo_checkBoxAdv.Checked)
                this.radialMenuItem15.Enabled = this.radialMenuItem5.Enabled = this.radialMenuItem13.Enabled = !this.richTextBox1.Text.Equals(r.Text);
            this.radialMenu1.Refresh();
        }



        #region SetEnable/Disable

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
            foreach (Control ctrl in this.radialMenu1.Items)
            {
                if ((sender as CheckBoxAdv).Text == ctrl.Text)
                {
                    ctrl.Enabled = !(sender as CheckBoxAdv).Checked;
                }
                if (ctrl is RadialMenuItem)
                {
                    if ((ctrl as RadialMenuItem).Items.Count > 0)
                    {
                        setEnabledForSubItems((ctrl as RadialMenuItem), (sender as CheckBoxAdv).Text, !(sender as CheckBoxAdv).Checked);
                    }
                }
            }
            this.radialMenu1.Refresh();
        }
        private void setEnabledForSubItems(RadialMenuItem item, string testString, bool checkedState)
        {
            foreach (Control ctrl in item.Items)
            {
                if (testString == ctrl.Text)
                {
                    ctrl.Enabled = checkedState;
                }
            }
        }

        #endregion

        void RadialMenuMainForm_Load(object sender, EventArgs e)
        {
            this.radialMenu1.ShowRadialMenu(new Point(200, 200));
        }

        #endregion

        #region PopUp Customization

        void radialMenu1_BeforeCloseUp(object sender, CancelEventArgs e)
        {

            if (this.radialMenu1.MenuVisibility)
            {
                this.radialMenu1.MenuVisibility = false;
                this.radialMenu1.ItemOnLoad = null;
                this.radialMenu1.Refresh();
            }
        }
        protected override void OnLayout(LayoutEventArgs levent)
        {
            base.OnLayout(levent);

        }
        private void setRadialMenuLocation()
        {
            int locationX = 0;
            int locationY = 0;
            locationX = (Cursor.Position.X - this.radialMenu1.Width / 8 - 70);
            if (locationX + this.radialMenu1.Width > Screen.PrimaryScreen.Bounds.Width)
            {
                locationX = Screen.PrimaryScreen.Bounds.Width - this.radialMenu1.Width;
            }
            locationY = Cursor.Position.Y - this.radialMenu1.Height / 2;
            if (locationY + this.radialMenu1.Height > Screen.PrimaryScreen.Bounds.Height)
                locationY = Screen.PrimaryScreen.Bounds.Height - this.radialMenu1.Height;
            Point location = new Point(locationX, locationY);
            this.radialMenu1.ShowRadialMenu(location);
            this.radialMenu1.PopupHost.Location = location;
            if (this.radialMenu1.PopupHost.Location.Y < 0)
                this.radialMenu1.PopupHost.Location = new Point(this.radialMenu1.PopupHost.Location.X, 0);
        }
        private void richTextBox1_MouseUp(object sender, MouseEventArgs e)
        {

            setRadialMenuLocation();
        }

        #endregion

        #region RadialMenu Customization      



        private void UpdateRadialMenuForOffice2016Theme()
        {
            LockWindowUpdate(this.Handle);
            this.radialMenu1.ImageList = imageListAdv1;

            this.richTextBox1.ForeColor = ColorTranslator.FromHtml("#262626");
            this.richTextBox1.BackColor = ColorTranslator.FromHtml("#ffffff");

            this.scrollersFrame.VisualStyle = ScrollBarCustomDrawStyles.Office2016;
            this.scrollersFrame.Office2016ColorScheme = ScrollBarOffice2016ColorScheme.Colorful;
            this.gradientPanel1.BorderColor = ColorTranslator.FromHtml("#c5c5c5");
            this.radialMenu1.Icon = global::Customization.Properties.Resources.A_Colorful;
            this.radialMenu1.MenuIcon = global::Customization.Properties.Resources.Arrow_Colorful;
            this.radialMenuItem1.ImageIndex = 34;
            this.radialFontListBox1.ImageIndex = 31;
            this.radialColorPalette1.ImageIndex = 28;
            this.radialMenuSlider1.ImageIndex = 33;
            this.radialMenuItem6.ImageIndex = 39;
            this.radialMenuItem13.ImageIndex = 37;
            this.radialMenuItem14.ImageIndex = 74;
            this.radialMenuItem15.ImageIndex = 37;
            this.radialMenuItem16.ImageIndex = 75;
            this.radialMenuItem2.ImageIndex = 30;
            this.radialMenuItem3.ImageIndex = 29;
            this.radialMenuItem4.ImageIndex = 32;
            this.radialMenuItem5.ImageIndex = 37;
            this.radialMenuItem7.ImageIndex = 35;
            this.radialMenuItem8.ImageIndex = 36;
            this.radialMenuItem9.ImageIndex = 38;
            this.radialMenuItem10.ImageIndex = 73;
            this.radialMenuItem11.ImageIndex = 39;
            this.radialMenuItem12.ImageIndex = 40;
            LockWindowUpdate(IntPtr.Zero);

            this.colorPickerButton1.ForeColor = Color.Transparent;
            this.colorPickerButton2.ForeColor = Color.Transparent;
            this.colorPickerButton3.ForeColor = Color.Transparent;
            this.colorPickerButton4.ForeColor = Color.Transparent;
            this.colorPickerButton5.ForeColor = Color.Transparent;
            this.colorPickerButton6.ForeColor = Color.Transparent;
            this.colorPickerButton7.ForeColor = Color.Transparent;
            this.colorPickerButton8.ForeColor = Color.Transparent;
        }
        private void radialMenuSlider1_SliderValueChanged(object sender, Syncfusion.Windows.Forms.Tools.RadialMenuSliderValueChangedEventArgs e)
        {
            if (this.richTextBox1.SelectedText == "")
            {
                this.richTextBox1.Font = new Font(this.richTextBox1.Font.Name, (float)e.Value, this.richTextBox1.Font.Style);
            }
            else
            {
                this.richTextBox1.SelectionFont = new Font(this.richTextBox1.Font.Name, (float)e.Value, this.richTextBox1.Font.Style);
            }
            this.richTextBox1.Refresh();
        }
        private void radialFontListBox1_RadialFontChanged(object sender, Syncfusion.Windows.Forms.Tools.SlectedIndexChangedEventArgs e)
        {
            if (this.richTextBox1.SelectedText == "")
            {
                this.richTextBox1.Font = new Font(e.SelectedFontName, this.richTextBox1.Font.Size, this.richTextBox1.Font.Style);
            }
            else
            {
                this.richTextBox1.SelectionFont = new Font(e.SelectedFontName, this.richTextBox1.Font.Size, this.richTextBox1.Font.Style);
            }
        }
        private void radialColorPalette1_ColorPaletteColorChanged(object sender, Syncfusion.Windows.Forms.Tools.SelctedColorChangedEventArgs e)
        {
            if (this.richTextBox1.SelectedText == "")
            {
                this.richTextBox1.ForeColor = e.SelectedColor;
            }
            else
            {
                this.richTextBox1.SelectionColor = e.SelectedColor;
            }
        }

        #endregion

        #region Edit

        private void radialMenuItem2_MouseUp(object sender, MouseEventArgs e)
        {
            this.richTextBox1.Cut();
        }
        private void radialMenuItem3_MouseUp(object sender, MouseEventArgs e)
        {
            this.richTextBox1.Copy();
        }

        private void radialMenuItem4_MouseUp(object sender, MouseEventArgs e)
        {
            this.richTextBox1.Paste();
        }

        private void radialMenuItem5_MouseUp(object sender, MouseEventArgs e)
        {
            this.richTextBox1.Undo();
        }

        #endregion

        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            if (this.WindowState != FormWindowState.Minimized)
                this.radialMenu1.ShowRadialMenu(new Point(700, 100));
        }

    }
    public class Panels : Panel
    {
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            int borderWidth = 1;
            Color borderColor = ColorTranslator.FromHtml("#c5c5c5");

            ControlPaint.DrawBorder(e.Graphics, e.ClipRectangle, borderColor,
            borderWidth, ButtonBorderStyle.Solid, borderColor, borderWidth,

            ButtonBorderStyle.Solid, borderColor, borderWidth, ButtonBorderStyle.Solid,

            borderColor, borderWidth, ButtonBorderStyle.Solid);
        }
    }
}
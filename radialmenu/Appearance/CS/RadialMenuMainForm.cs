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
        [DllImport("user32.dll")]
        static extern bool LockWindowUpdate(IntPtr hWndLock);
        #region Initialize

        public RadialMenuMainForm()
        {
            InitializeComponent();
            this.radialMenuItem15.MouseUp += new System.Windows.Forms.MouseEventHandler(this.radialMenuItem5_MouseUp);
            this.radialMenuItem13.MouseUp += new System.Windows.Forms.MouseEventHandler(this.radialMenuItem5_MouseUp);
            this.radialMenu1.BeforeCloseUp += new CancelEventHandler(radialMenu1_BeforeCloseUp);
            this.Deactivate += new EventHandler(RadialMenuMainForm_Deactivate);
            this.Load += new EventHandler(RadialMenuMainForm_Load);
            this.richTextBox1.MouseEnter += new EventHandler(richTextBox1_MouseEnter);
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
            this.radialMenu1.Style = RadialMenuStyle.Office2016Colorful;
            UpdateRadialMenuForOffice2016Theme();
#if NETCORE
            this.Icon = new Icon("../../../Icon/Icon.ico");
#else
            this.Icon = new Icon("../../Icon/Icon.ico");
#endif
            this.Outerarccolor.ColorSelected += Outerarccolor_ColorSelected;
            this.outerarchighlightedcolor.ColorSelected += Outerarchighlightedcolor_ColorSelected;
            this.rim_background.ColorSelected += Rim_background_ColorSelected;
            this.outer_arcgap.ValueChanged += Outer_arcgap_ValueChanged;
            this.rim_thickness.ValueChanged += Rim_thickness_ValueChanged;
            this.colorPickerButton3.ColorSelected += ColorPickerButton3_ColorSelected;
            this.colorPickerButton2.ColorSelected += ColorPickerButton2_ColorSelected;
            this.colorPickerButton1.ColorSelected += ColorPickerButton1_ColorSelected;
            this.colorPickerButton4.ColorSelected += ColorPickerButton4_ColorSelected1;
            this.colorPickerButton5.ColorSelected += ColorPickerButton5_ColorSelected;

            this.comboBox1.SelectedIndexChanged += ComboBox1_SelectedIndexChanged;
            this.comboBox2.SelectedIndexChanged += ComboBox2_SelectedIndexChanged;

            this.outer_arcgap.Font = new Font("Segoe UI", 10f);
            this.rim_thickness.Font = new Font("Segoe UI", 10f);

            this.radialMenu1.ForeColor = Color.Red;
            this.colorPickerButton4.SelectedColor = Color.Red;
            this.radialMenu1.InnerCircleColor = Color.DarkTurquoise;
            this.colorPickerButton1.SelectedColor = Color.DarkTurquoise;
            this.radialMenu1.DrillDownArrowColor = Color.DarkOrange;
            this.colorPickerButton2.SelectedColor = Color.DarkOrange;
            this.radialMenu1.CenterCircleRimColor = Color.PeachPuff;
            this.colorPickerButton3.SelectedColor = Color.PeachPuff;
            this.radialMenu1.RimBackground = Color.LightGreen;
            this.rim_background.SelectedColor = Color.LightGreen;
            this.radialMenu1.OuterArcColor = Color.DodgerBlue;
            this.Outerarccolor.SelectedColor = Color.DodgerBlue;
            this.radialMenu1.OuterArcHighLightedColor = Color.Red;
            this.outerarchighlightedcolor.SelectedColor = Color.HotPink;
            this.radialMenu1.HighlightedArcColor = Color.DarkSlateBlue;
            this.colorPickerButton5.SelectedColor = Color.DarkSlateBlue;

            this.comboBox2.SelectedIndex = 1;
            this.comboBox1.SelectedIndex = 1;


        }

        private void ColorPickerButton5_ColorSelected(object sender, EventArgs e)
        {
            this.radialMenu1.HighlightedArcColor = this.colorPickerButton5.SelectedColor;
        }

        private void ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedItem = (sender as ComboBoxAdv).SelectedItem.ToString();
            if (selectedItem == "Colorful")
            {
                this.radialMenu1.MenuIcon = AppearanceDemo.Properties.Resources.Arrow_Colorful;
            }
            else if (selectedItem == "Light")
            {
                this.radialMenu1.MenuIcon = AppearanceDemo.Properties.Resources.Arrow_DarkGray;
            }
            else
            {
                this.radialMenu1.MenuIcon = AppearanceDemo.Properties.Resources.Arrow_white;
            }
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedItem = (sender as ComboBoxAdv).SelectedItem.ToString();
            if(selectedItem == "Colorful")
            {
                this.radialMenu1.Icon = AppearanceDemo.Properties.Resources.A_Colorful;
            }
            else if(selectedItem == "Light")
            {
                this.radialMenu1.Icon = AppearanceDemo.Properties.Resources.A_DarkGray;
            }
            else
            {
                this.radialMenu1.Icon = AppearanceDemo.Properties.Resources.A_White;
            }
        }

        private void Outer_arcgap_ValueChanged(object sender, System.EventArgs e)
        {
            this.radialMenu1.OuterArcGap = (int)this.outer_arcgap.Value;
        }

        private void Rim_background_ColorSelected(object sender, System.EventArgs e)
        {
            this.radialMenu1.RimBackground = this.rim_background.SelectedColor;
        }

        private void Outerarchighlightedcolor_ColorSelected(object sender, System.EventArgs e)
        {
            this.radialMenu1.OuterArcHighLightedColor = this.outerarchighlightedcolor.SelectedColor;
        }

        private void Outerarccolor_ColorSelected(object sender, System.EventArgs e)
        {
            this.radialMenu1.OuterArcColor = this.Outerarccolor.SelectedColor;
        }
        private void Rim_thickness_ValueChanged(object sender, System.EventArgs e)
        {
            this.radialMenu1.OuterRimThickness = (int)this.rim_thickness.Value;
        }

        private void ColorPickerButton4_ColorSelected1(object sender, EventArgs e)
        {
            this.radialMenu1.ForeColor = this.colorPickerButton4.SelectedColor;
            this.radialMenu1.Refresh();
        }

        private void ColorPickerButton1_ColorSelected(object sender, EventArgs e)
        {
            this.radialMenu1.InnerCircleColor = this.colorPickerButton1.SelectedColor;
        }

        private void ColorPickerButton2_ColorSelected(object sender, EventArgs e)
        {
            this.radialMenu1.DrillDownArrowColor = this.colorPickerButton2.SelectedColor;
        }

        private void ColorPickerButton3_ColorSelected(object sender, EventArgs e)
        {
            this.radialMenu1.CenterCircleRimColor = this.colorPickerButton3.SelectedColor;
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

        void richTextBox1_MouseEnter(object sender, EventArgs e)
        {

        }


        void RadialMenuMainForm_Deactivate(object sender, EventArgs e)
        {
        }

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
            locationX = (Cursor.Position.X + this.radialMenu1.Width / 8 - 85);
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

            this.Outerarccolor.Appearance = ButtonAppearance.Office2016Colorful;
            this.outerarchighlightedcolor.Appearance = ButtonAppearance.Office2016Colorful;
            this.rim_background.Appearance = ButtonAppearance.Office2016Colorful;

            this.rim_thickness.VisualStyle = VisualStyle.Office2016Colorful;
            this.outer_arcgap.VisualStyle = VisualStyle.Office2016Colorful;

            this.comboBox1.Style = VisualStyle.Office2016Colorful;
            this.comboBox2.Style = VisualStyle.Office2016Colorful;

            this.BackColor = ColorTranslator.FromHtml("#ffffff");
            this.ForeColor = ColorTranslator.FromHtml("#262626");
            this.richTextBox1.ForeColor = ColorTranslator.FromHtml("#262626");

            this.richTextBox1.BackColor = ColorTranslator.FromHtml("#ffffff");
            this.scrollersFrame.VisualStyle = ScrollBarCustomDrawStyles.Office2016;
            this.scrollersFrame.Office2016ColorScheme = ScrollBarOffice2016ColorScheme.Colorful;
            this.MetroColor = ColorTranslator.FromHtml("#0173c7");
            this.BorderColor = ColorTranslator.FromHtml("#c5c5c5");
            this.gradientPanel1.BorderColor = ColorTranslator.FromHtml("#c5c5c5");
            this.radialMenu1.Icon = global::AppearanceDemo.Properties.Resources.A_Colorful;
            this.radialMenu1.MenuIcon = global::AppearanceDemo.Properties.Resources.Arrow_Colorful;
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


            this.Outerarccolor.ForeColor = Color.Transparent;
            this.outerarchighlightedcolor.ForeColor = Color.Transparent;
            this.rim_background.ForeColor = Color.Transparent;
            this.colorPickerButton1.ForeColor = Color.Transparent;
            this.colorPickerButton2.ForeColor = Color.Transparent;
            this.colorPickerButton3.ForeColor = Color.Transparent;
            this.colorPickerButton4.ForeColor = Color.Transparent;
            this.colorPickerButton5.ForeColor = Color.Transparent;

            this.label1.ForeColor = ColorTranslator.FromHtml("#444444");
            this.label2.ForeColor = ColorTranslator.FromHtml("#444444");
            this.label3.ForeColor = ColorTranslator.FromHtml("#444444");
            this.label4.ForeColor = ColorTranslator.FromHtml("#444444");
            this.label5.ForeColor = ColorTranslator.FromHtml("#444444");
            this.label6.ForeColor = ColorTranslator.FromHtml("#444444");
            this.label7.ForeColor = ColorTranslator.FromHtml("#444444");
            this.label8.ForeColor = ColorTranslator.FromHtml("#444444");
            this.label9.ForeColor = ColorTranslator.FromHtml("#444444");
            this.label10.ForeColor = ColorTranslator.FromHtml("#444444");
            this.label11.ForeColor = ColorTranslator.FromHtml("#444444");
            this.rimthickness.ForeColor = ColorTranslator.FromHtml("#444444");
            LockWindowUpdate(IntPtr.Zero);
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

        private void RadialMenuMainForm_Load_1(object sender, EventArgs e)
        {

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
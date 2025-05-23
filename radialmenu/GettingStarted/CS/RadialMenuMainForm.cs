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
using Appearance = Syncfusion.Windows.Forms.Tools.Appearance;

namespace RadialMenuDemo
{
    public partial class RadialMenuMainForm : MetroForm
    {
        ColorCollection colorCollection = new ColorCollection();
        private SuperAccelerator superAccelerator1;
        [DllImport("user32.dll")]
        static extern bool LockWindowUpdate(IntPtr hWndLock);
        #region Initialize

        public RadialMenuMainForm()
        {
            InitializeComponent();
            this.radialMenu1.ShowToolTip=true;
            superAccelerator1 = new SuperAccelerator(this);
            this.superAccelerator1.SetAccelerator(this.radialMenuItem1, "E");
            this.superAccelerator1.SetAccelerator(this.radialMenuItem2, "X");
            this.superAccelerator1.SetAccelerator(this.radialMenuItem3, "C");
            this.superAccelerator1.SetAccelerator(this.radialMenuItem4, "P");
            this.superAccelerator1.SetAccelerator(this.radialMenuItem5, "U");
            this.superAccelerator1.SetAccelerator(this.radialMenuItem6, "L");
            this.superAccelerator1.SetAccelerator(this.radialMenuSlider1, "S");
            this.superAccelerator1.SetAccelerator(radialColorPalette1, "C");
            this.superAccelerator1.SetAccelerator(this.radialFontListBox1, "F");

            // Raise click event for radial menu items. 
            this.radialMenuItem1.Click += RadialMenuItem1_Click1;
            this.radialMenuItem6.Click += RadialMenuItem1_Click1;
            this.radialMenuItem5.Click += RadialMenuItem1_Click1;
            this.radialMenuSlider1.Click += RadialMenuSlider1_Click;
            this.radialColorPalette1.Click += RadialColorPalette1_Click;
            this.radialFontListBox1.Click += RadialFontListBox1_Click;

            this.radialMenuItem15.MouseUp += new System.Windows.Forms.MouseEventHandler(this.radialMenuItem5_MouseUp);
            this.radialMenuItem13.MouseUp += new System.Windows.Forms.MouseEventHandler(this.radialMenuItem5_MouseUp);
            this.radialMenu1.BeforeCloseUp += new CancelEventHandler(radialMenu1_BeforeCloseUp);
            this.Deactivate += new EventHandler(RadialMenuMainForm_Deactivate);
            this.Load += new EventHandler(RadialMenuMainForm_Load);
            this.richTextBox1.MouseEnter += new EventHandler(richTextBox1_MouseEnter);

            this.checkBox1.CheckStateChanged += new System.EventHandler(this.checkBox1_CheckStateChanged);
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.NumericUpDown1_ValueChanged);
            this.numericUpDown2.ValueChanged += NumericUpDown2_ValueChanged1;
            this.comboBox1.SelectedIndexChanged += ComboBox1_SelectedIndexChanged;
            this.comboBox3.SelectedIndexChanged += ComboBox3_SelectedIndexChanged;
            this.radialMenu1.Style = Syncfusion.Windows.Forms.Tools.RadialMenuStyle.Office2016Colorful;
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
            UpdateRadialMenuForOffice2016Theme();
            this.checkBox1.Text = "Index Based Menu Type";
            this.checkBox1.AutoSize = true;
#if NETCORE
            this.Icon = new Icon("../../../Icon/Icon.ico");
#else
            this.Icon = new Icon("../../Icon/Icon.ico");
#endif

            this.numericUpDown1.Font = new Font("Segoe UI", 10f);
            this.numericUpDown2.Font = new Font("Segoe UI", 10f);
        }

        /// <summary>
        /// Method used to drill down the radial menu font list box.
        /// </summary>
        /// <param name="sender">Specifies the object.</param>
        /// <param name="e">Specifies the EventArgs that contains the event data.</param>
        private void RadialFontListBox1_Click(object sender, EventArgs e)
        {
            this.radialMenu1.RadialFontListBoxDrillDown(sender as RadialFontListBox);
        }

        /// <summary>
        /// Method used to drill down the radial menu color palette.
        /// </summary>
        /// <param name="sender">Specifies the object.</param>
        /// <param name="e">Specifies the EventArgs that contains the event data.</param>
        private void RadialColorPalette1_Click(object sender, EventArgs e)
        {
            this.radialMenu1.RadialColorPaletteDrillDown(sender as RadialColorPalette);
        }

        /// <summary>
        /// Method used to drill down the radial menu slider.
        /// </summary>
        /// <param name="sender">Specifies the object.</param>
        /// <param name="e">Specifies the EventArgs that contains the event data.</param>
        private void RadialMenuSlider1_Click(object sender, EventArgs e)
        {
            this.radialMenu1.RadialMenuSliderDrillDown(sender as RadialMenuSlider);
        }

        /// <summary>
        /// Method used to drill down the radial menu item.
        /// </summary>
        /// <param name="sender">Specifies the object.</param>
        /// <param name="e">Specifies the EventArgs that contains the event data.</param>
        private void RadialMenuItem1_Click1(object sender, EventArgs e)
        {
            this.radialMenu1.RadialMenuItemDrillDown(sender as RadialMenuItem);
        }

        /// <summary>
        /// Method used to set the different size for images in radial menu.
        /// </summary>
        /// <param name="sender">Specifies the object.</param>
        /// <param name="e">Specifies the EventArgs that contains the event data.</param>
        private void ComboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((sender as ComboBoxAdv).SelectedIndex == 0)
                this.radialMenu1.MenuItemImageSize = new Size(16, 16);
            else if ((sender as ComboBoxAdv).SelectedIndex == 1)
                this.radialMenu1.MenuItemImageSize = new Size(24, 24);
            else if ((sender as ComboBoxAdv).SelectedIndex == 2)
                this.radialMenu1.MenuItemImageSize = new Size(28, 28);
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedItem = this.comboBox1.Text;
            switch (selectedItem)
            {
                case "Office2016 Colorful":
                    {
                        this.radialMenu1.Style = RadialMenuStyle.Office2016Colorful;
                        this.superAccelerator1.Appearance = Appearance.Office2016Colorful;
                        break;
                    }
                case "Office2016 White":
                    {
                        this.radialMenu1.Style = RadialMenuStyle.Office2016White;
                        this.superAccelerator1.Appearance = Appearance.Office2016White;
                        break;
                    }
                case "Office2016 Dark Gray":
                    {
                        this.radialMenu1.Style = RadialMenuStyle.Office2016DarkGray;
                        this.superAccelerator1.Appearance = Appearance.Office2016DarkGray;
                        break;
                    }
                case "Office2016 Black":
                    {
                        this.radialMenu1.Style = RadialMenuStyle.Office2016Black;
                        this.superAccelerator1.Appearance = Appearance.Office2016Black;
                        break;
                    }
            }
            UpdateRadialMenuForOffice2016Theme();
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
            locationX = (Cursor.Position.X + this.radialMenu1.Width / 8 - 90);
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
        private void checkBox1_CheckStateChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                this.radialMenu1.UseIndexBasedOrder = true;
            }
            else
            {
                this.radialMenu1.UseIndexBasedOrder = false;
            }
        }

        private void UpdateRadialMenuForOffice2016Theme()
        {
            LockWindowUpdate(this.Handle);
            if (this.radialMenu1.Style == RadialMenuStyle.Office2016Colorful)
            {
                this.CaptionBarColor = ColorTranslator.FromHtml("#0173c7");
                this.CaptionForeColor = ColorTranslator.FromHtml("#ffffff");
                this.CaptionButtonColor = ColorTranslator.FromHtml("#262626");

                this.checkBox1.Style = CheckBoxAdvStyle.Office2016Colorful;
                this.comboBox1.Style = VisualStyle.Office2016Colorful;
                this.comboBox2.Style = VisualStyle.Office2016Colorful;
                this.comboBox3.Style = VisualStyle.Office2016Colorful;
                this.numericUpDown1.VisualStyle = VisualStyle.Office2016Colorful;
                this.numericUpDown2.VisualStyle = VisualStyle.Office2016Colorful;

                this.radialMenu1.ImageList = imageListAdv1;
                this.BackColor = ColorTranslator.FromHtml("#ffffff");
                this.ForeColor = ColorTranslator.FromHtml("#262626");


                this.label1.ForeColor = ColorTranslator.FromHtml("#444444");
                this.label2.ForeColor = ColorTranslator.FromHtml("#444444");
                this.label3.ForeColor = ColorTranslator.FromHtml("#444444");
                this.label4.ForeColor = ColorTranslator.FromHtml("#444444");
                this.label5.ForeColor = ColorTranslator.FromHtml("#444444");
                this.checkBox1.ForeColor = ColorTranslator.FromHtml("#444444");

                this.richTextBox1.ForeColor = ColorTranslator.FromHtml("#262626");
                this.richTextBox1.BackColor = ColorTranslator.FromHtml("#ffffff");

                this.scrollersFrame.VisualStyle = ScrollBarCustomDrawStyles.Office2016;
                this.scrollersFrame.Office2016ColorScheme = ScrollBarOffice2016ColorScheme.Colorful;
                this.MetroColor = ColorTranslator.FromHtml("#0173c7");
                this.BorderColor = ColorTranslator.FromHtml("#c5c5c5");
                this.gradientPanel1.BorderColor = ColorTranslator.FromHtml("#c5c5c5");
                this.radialMenu1.Icon = global::GettingStartedDemo.Properties.Resources.A_Colorful;
                this.radialMenu1.MenuIcon = global::GettingStartedDemo.Properties.Resources.Arrow_Colorful;
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
            }
            else if (this.radialMenu1.Style == RadialMenuStyle.Office2016White)
            {
                this.CaptionBarColor = ColorTranslator.FromHtml("#ffffff");
                this.CaptionForeColor = ColorTranslator.FromHtml("#262626");
                this.CaptionButtonColor = ColorTranslator.FromHtml("#262626");

                this.checkBox1.Style = CheckBoxAdvStyle.Office2016White;
                this.comboBox1.Style = VisualStyle.Office2016White;
                this.comboBox2.Style = VisualStyle.Office2016White;
                this.comboBox3.Style = VisualStyle.Office2016White;
                this.numericUpDown1.VisualStyle = VisualStyle.Office2016White;
                this.numericUpDown2.VisualStyle = VisualStyle.Office2016White;

                this.BackColor = ColorTranslator.FromHtml("#ffffff");
                this.ForeColor = ColorTranslator.FromHtml("#262626");

                this.label1.ForeColor = ColorTranslator.FromHtml("#262626");
                this.label2.ForeColor = ColorTranslator.FromHtml("#262626");
                this.label3.ForeColor = ColorTranslator.FromHtml("#262626");
                this.label4.ForeColor = ColorTranslator.FromHtml("#262626");
                this.label5.ForeColor = ColorTranslator.FromHtml("#262626");
                this.checkBox1.ForeColor = ColorTranslator.FromHtml("#262626");

                this.richTextBox1.ForeColor = ColorTranslator.FromHtml("#262626");
                this.richTextBox1.BackColor = ColorTranslator.FromHtml("#ffffff");
                this.scrollersFrame.VisualStyle = ScrollBarCustomDrawStyles.Office2016;
                this.scrollersFrame.Office2016ColorScheme = ScrollBarOffice2016ColorScheme.White;
                this.MetroColor = ColorTranslator.FromHtml("#ffffff");
                this.BorderColor = ColorTranslator.FromHtml("#c5c5c5");
                this.gradientPanel1.BorderColor = ColorTranslator.FromHtml("#c5c5c5");
                this.radialMenu1.Icon = global::GettingStartedDemo.Properties.Resources.A_White;
                this.radialMenu1.MenuIcon = global::GettingStartedDemo.Properties.Resources.Arrow_white;
                this.scrollersFrame.VisualStyle = ScrollBarCustomDrawStyles.Office2016;
                this.scrollersFrame.Office2016ColorScheme = ScrollBarOffice2016ColorScheme.White;
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
            }
            else if (this.radialMenu1.Style == RadialMenuStyle.Office2016Black)
            {
                this.CaptionBarColor = ColorTranslator.FromHtml("#262626");
                this.CaptionForeColor = ColorTranslator.FromHtml("#f0f0f0");
                this.CaptionButtonColor = ColorTranslator.FromHtml("#f0f0f0");

                this.checkBox1.Style = CheckBoxAdvStyle.Office2016Black;
                this.comboBox1.Style = VisualStyle.Office2016Black;
                this.comboBox2.Style = VisualStyle.Office2016Black;
                this.comboBox3.Style = VisualStyle.Office2016Black;
                this.numericUpDown1.VisualStyle = VisualStyle.Office2016Black;
                this.numericUpDown2.VisualStyle = VisualStyle.Office2016Black;

                this.BackColor = ColorTranslator.FromHtml("#262626");
                this.ForeColor = ColorTranslator.FromHtml("#f0f0f0");

                this.label1.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                this.label2.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                this.label3.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                this.label4.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                this.label5.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                this.checkBox1.ForeColor = ColorTranslator.FromHtml("#f0f0f0");

                this.richTextBox1.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                this.richTextBox1.BackColor = ColorTranslator.FromHtml("#262626");
                this.scrollersFrame.VisualStyle = ScrollBarCustomDrawStyles.Office2016;
                this.scrollersFrame.Office2016ColorScheme = ScrollBarOffice2016ColorScheme.Black;
                this.BorderColor = ColorTranslator.FromHtml("#363636");
                this.MetroColor = ColorTranslator.FromHtml("#363636");
                this.gradientPanel1.BorderColor = ColorTranslator.FromHtml("#363636");
                this.radialMenu1.Icon = global::GettingStartedDemo.Properties.Resources.A_Black;
                this.radialMenu1.MenuIcon = global::GettingStartedDemo.Properties.Resources.Arrow_Black;
                this.radialMenuItem1.ImageIndex = 6;
                this.radialFontListBox1.ImageIndex = 3;
                this.radialColorPalette1.ImageIndex = 0;
                this.radialMenuSlider1.ImageIndex = 5;
                this.radialMenuItem6.ImageIndex = 11;
                this.radialMenuItem13.ImageIndex = 9;
                this.radialMenuItem14.ImageIndex = 71;
                this.radialMenuItem15.ImageIndex = 9;
                this.radialMenuItem16.ImageIndex = 72;
                this.radialMenuItem2.ImageIndex = 2;
                this.radialMenuItem3.ImageIndex = 1;
                this.radialMenuItem4.ImageIndex = 4;
                this.radialMenuItem5.ImageIndex = 9;
                this.radialMenuItem7.ImageIndex = 7;
                this.radialMenuItem8.ImageIndex = 8;
                this.radialMenuItem9.ImageIndex = 10;
                this.radialMenuItem10.ImageIndex = 70;
                this.radialMenuItem11.ImageIndex = 11;
                this.radialMenuItem12.ImageIndex = 12;

            }
            else if (this.radialMenu1.Style == RadialMenuStyle.Office2016DarkGray)
            {
                this.CaptionBarColor = ColorTranslator.FromHtml("#666666");
                this.CaptionForeColor = ColorTranslator.FromHtml("#f0f0f0");
                this.CaptionButtonColor = ColorTranslator.FromHtml("#f0f0f0");

                this.checkBox1.Style = CheckBoxAdvStyle.Office2016DarkGray;
                this.comboBox1.Style = VisualStyle.Office2016DarkGray;
                this.comboBox2.Style = VisualStyle.Office2016DarkGray;
                this.numericUpDown1.VisualStyle = VisualStyle.Office2016DarkGray;
                this.numericUpDown2.VisualStyle = VisualStyle.Office2016DarkGray;
                this.comboBox3.Style = VisualStyle.Office2016DarkGray;

                this.BackColor = ColorTranslator.FromHtml("#666666");
                this.ForeColor = ColorTranslator.FromHtml("#f0f0f0");

                this.label1.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                this.label2.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                this.label3.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                this.label4.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                this.label5.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                this.checkBox1.ForeColor = ColorTranslator.FromHtml("#f0f0f0");

                this.richTextBox1.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                this.richTextBox1.BackColor = ColorTranslator.FromHtml("#666666");
                this.scrollersFrame.VisualStyle = ScrollBarCustomDrawStyles.Office2016;
                this.scrollersFrame.Office2016ColorScheme = ScrollBarOffice2016ColorScheme.DarkGray;
                this.MetroColor = ColorTranslator.FromHtml("#505050");
                this.BorderColor = ColorTranslator.FromHtml("#444444");
                this.gradientPanel1.BorderColor = ColorTranslator.FromHtml("#444444");
                this.radialMenu1.Icon = global::GettingStartedDemo.Properties.Resources.A_DarkGray;
                this.radialMenu1.MenuIcon = global::GettingStartedDemo.Properties.Resources.Arrow_DarkGray;
                this.radialMenuItem1.ImageIndex = 20;
                this.radialFontListBox1.ImageIndex = 17;
                this.radialColorPalette1.ImageIndex = 14;
                this.radialMenuSlider1.ImageIndex = 19;
                this.radialMenuItem6.ImageIndex = 25;
                this.radialMenuItem13.ImageIndex = 23;
                this.radialMenuItem14.ImageIndex = 68;
                this.radialMenuItem15.ImageIndex = 23;
                this.radialMenuItem16.ImageIndex = 69;
                this.radialMenuItem2.ImageIndex = 16;
                this.radialMenuItem3.ImageIndex = 15;
                this.radialMenuItem4.ImageIndex = 18;
                this.radialMenuItem5.ImageIndex = 23;
                this.radialMenuItem7.ImageIndex = 21;
                this.radialMenuItem8.ImageIndex = 22;
                this.radialMenuItem9.ImageIndex = 24;
                this.radialMenuItem10.ImageIndex = 67;
                this.radialMenuItem11.ImageIndex = 25;
                this.radialMenuItem12.ImageIndex = 26;
            }

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


        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.comboBox2.SelectedItem.ToString() == "TextAboveImage")
            {
                this.radialMenu1.DisplayStyle = Syncfusion.Windows.Forms.Tools.DisplayStyle.TextAboveImage;
            }
            else if (this.comboBox2.SelectedItem.ToString() == "ImageAboveText")
            {
                this.radialMenu1.DisplayStyle = Syncfusion.Windows.Forms.Tools.DisplayStyle.ImageAboveText;
            }
            else if (this.comboBox2.SelectedItem.ToString() == "Text")
            {
                this.radialMenu1.DisplayStyle = Syncfusion.Windows.Forms.Tools.DisplayStyle.Text;
            }
            else if (this.comboBox2.SelectedItem.ToString() == "Image")
            {
                this.radialMenu1.DisplayStyle = Syncfusion.Windows.Forms.Tools.DisplayStyle.Image;
            }
            this.radialMenu1.Refresh();
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            if (this.WindowState != FormWindowState.Minimized)
                this.radialMenu1.ShowRadialMenu(new Point(700, 100));
        }

        private void NumericUpDown2_ValueChanged1(object sender, EventArgs e)
        {
            this.radialMenu1.StartAngle((int)numericUpDown2.Value);
            this.radialMenu1.Refresh();
        }


        private void NumericUpDown1_ValueChanged(object sender, System.EventArgs e)
        {
            this.radialMenu1.WedgeCount = (int)this.numericUpDown1.Value;

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
#region Copyright Syncfusion Inc. 2001 - 2014
// Copyright Syncfusion Inc. 2001 - 2014. All rights reserved.
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
            this.Deactivate += new EventHandler(RadialMenuMainForm_Deactivate);
            this.Load += new EventHandler(RadialMenuMainForm_Load);           
            this.richTextBox1.MouseEnter += new EventHandler(richTextBox1_MouseEnter);          
            try
            {
                System.Drawing.Icon ico = new System.Drawing.Icon(GetIconFile(@"common\Images\Grid\Icon\sfgrid.ico"));
                this.Icon = ico;
            }
            catch { }
            this.radialMenu1.ParentControl = this.richTextBox1;
            this.radialMenu1.MenuVisibility = true;
            this.MinimumSize = this.Size;
            this.richTextBox1.TextChanged += new EventHandler(richTextBox1_TextChanged);
            this.radialMenu1.DisplayStyle = Syncfusion.Windows.Forms.Tools.DisplayStyle.TextAboveImage;
            string path = Application.StartupPath.ToString() + @"..\..\..\Introduction.rtf";
            if (File.Exists(path))
                this.richTextBox1.LoadFile(path, RichTextBoxStreamType.RichText);
            this.checkBox7.CheckedChanged += new System.EventHandler(this.checkBox10_CheckedChanged);
            this.checkBox8.CheckedChanged += new System.EventHandler(this.checkBox10_CheckedChanged);
            this.checkBox9.CheckedChanged += new System.EventHandler(this.checkBox10_CheckedChanged);
            this.checkBox10.CheckedChanged += new System.EventHandler(this.checkBox10_CheckedChanged);
            this.checkBox11.CheckedChanged += new System.EventHandler(this.checkBox10_CheckedChanged);
            this.checkBox12.CheckedChanged += new System.EventHandler(this.checkBox10_CheckedChanged);
            this.checkBox13.CheckedChanged += new System.EventHandler(this.checkBox10_CheckedChanged);
            this.checkBox14.CheckedChanged += new System.EventHandler(this.checkBox10_CheckedChanged);
            this.radialMenu1.MinimumSize = this.radialMenu1.Size;
            this.richTextBox1.MouseDown += richTextBox1_MouseDown;
            this.richTextBox1.GotFocus += richTextBox1_GotFocus;
            this.comboBoxAdv2.SelectedIndex = 1;
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

        #region  GetIconFile

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
            locationX = (Cursor.Position.X + this.radialMenu1.Width / 8);
            if (locationX + this.radialMenu1.Width> Screen.PrimaryScreen.Bounds.Width)
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
        private void checkBoxAdv7_CheckStateChanged(object sender, EventArgs e)
        {
            if (checkBoxAdv7.Checked)
            {
                this.radialMenu1.UseIndexBasedOrder = true;
            }
            else
            {
                this.radialMenu1.UseIndexBasedOrder = false;
            }
        }
        private void checkBoxAdv8_CheckStateChanged(object sender, EventArgs e)
        {
            if (checkBoxAdv8.Checked)
            {
                this.radialMenu1.PersistPreviousState = true;
            }
            else
            {
                this.radialMenu1.PersistPreviousState = false;
            }
        }
        private void checkBoxAdv9_CheckStateChanged(object sender, EventArgs e)
        {
            if (checkBoxAdv9.Checked)
            {
                this.radialMenu1.EnableTransition = true;
            }
            else
            {
                this.radialMenu1.EnableTransition = false;
            }
        }

       private void comboBoxAdv1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (checkBoxAdv10.Checked)
            {
                if (this.comboBoxAdv1.SelectedItem.ToString() == "Edit")
                {
                   
                    this.radialMenu1.ItemOnLoad = this.radialMenuItem1;
                }
                else
                {
                    this.radialMenu1.ItemOnLoad = null;
                }
            }
            this.radialMenu1.Refresh();
        }
        private void comboBoxAdv2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.comboBoxAdv2.SelectedIndex == 0)
            {
                this.radialMenu1.Style = RadialMenuStyle.Default;
            }
           else if (this.comboBoxAdv2.SelectedIndex == 1)
            {
                this.radialMenu1.Style = RadialMenuStyle.Office2016Colorful;
            }
            else if(this.comboBoxAdv2.SelectedIndex == 2)
            {
                this.radialMenu1.Style = RadialMenuStyle.Office2016White;
            }
            else if(this.comboBoxAdv2.SelectedIndex == 3)
            {
                this.radialMenu1.Style = RadialMenuStyle.Office2016DarkGray;
            }
            else 
            {
                this.radialMenu1.Style = RadialMenuStyle.Office2016Black;
            }

            UpdateRadialMenuForOffice2016Theme();
        }
        private void UpdateRadialMenuForOffice2016Theme()
        {
            LockWindowUpdate(this.Handle);
            this.radialMenu1.ImageList = imageListAdv1;

            if (this.radialMenu1.Style == RadialMenuStyle.Default)
            {
                this.BackColor = System.Drawing.Color.White;
                this.ForeColor = System.Drawing.Color.Black;
                this.CaptionForeColor = System.Drawing.Color.White;
                this.CaptionBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(151)))), ((int)(((byte)(217)))));
                this.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(151)))), ((int)(((byte)(217)))));
                this.CaptionButtonColor = ColorTranslator.FromHtml("#262626");
                this.label1.ForeColor = System.Drawing.Color.Black;
                this.label2.ForeColor = System.Drawing.Color.Black;
                this.label3.ForeColor = System.Drawing.Color.Black;
                this.label4.ForeColor = System.Drawing.Color.Black;
                this.label5.ForeColor = System.Drawing.Color.Black;
                this.label6.ForeColor = System.Drawing.Color.Black;
                this.label7.ForeColor = System.Drawing.Color.Black;
                this.label8.ForeColor = System.Drawing.Color.Black;
                this.label9.ForeColor = System.Drawing.Color.Black;
                this.label10.ForeColor = System.Drawing.Color.Black;
                this.richTextBox1.ForeColor = System.Drawing.Color.Black;

                this.panel1.BackColor = ColorTranslator.FromHtml("#ffffff");
                this.panel2.BackColor = ColorTranslator.FromHtml("#ffffff");
                this.panel3.BackColor = ColorTranslator.FromHtml("#ffffff");
                this.panel4.BackColor = ColorTranslator.FromHtml("#ffffff");
                this.panel5.BackColor = ColorTranslator.FromHtml("#ffffff");
                this.panel6.BackColor = ColorTranslator.FromHtml("#ffffff");
                this.panel7.BackColor = ColorTranslator.FromHtml("#ffffff");
                this.panel8.BackColor = ColorTranslator.FromHtml("#ffffff");
                this.panel9.BackColor = ColorTranslator.FromHtml("#ffffff");
                this.panel10.BackColor = ColorTranslator.FromHtml("#ffffff");
                this.panel11.BackColor = ColorTranslator.FromHtml("#ffffff");
                this.richTextBox1.BackColor = ColorTranslator.FromHtml("#ffffff");

                //this.radialMenuItem7.BackColor= System.Drawing.Color.White;
                //this.radialMenuItem8.BackColor = System.Drawing.Color.White;
                //this.radialMenuItem9.BackColor = System.Drawing.Color.White;
                //this.radialMenuItem10.BackColor = System.Drawing.Color.White;
                //this.radialMenuItem11.BackColor = System.Drawing.Color.White;
                //this.radialMenuItem12.BackColor = System.Drawing.Color.White;
                //this.radialMenuItem2.BackColor = System.Drawing.Color.White;
                //this.radialMenuItem3.BackColor = System.Drawing.Color.White;
                //this.radialMenuItem4.BackColor = System.Drawing.Color.White;
                //this.radialMenuItem5.BackColor = System.Drawing.Color.White;

                this.groupBar1.VisualStyle = VisualStyle.Metro;
                this.colorPickerButton1.Appearance = ButtonAppearance.Metro;
                this.colorPickerButton2.Appearance = ButtonAppearance.Metro;
                this.colorPickerButton3.Appearance = ButtonAppearance.Metro;
                this.colorPickerButton4.Appearance = ButtonAppearance.Metro;
                this.colorPickerButton5.Appearance = ButtonAppearance.Metro;
                this.colorPickerButton6.Appearance = ButtonAppearance.Metro;
                this.colorPickerButton7.Appearance = ButtonAppearance.Metro;
                this.colorPickerButton8.Appearance = ButtonAppearance.Metro;
                this.colorPickerButton9.Appearance = ButtonAppearance.Metro;
                this.colorPickerButton10.Appearance = ButtonAppearance.Metro;
                this.colorPickerButton12.Appearance = ButtonAppearance.Metro;
                this.colorPickerButton13.Appearance = ButtonAppearance.Metro;
                this.colorPickerButton14.Appearance = ButtonAppearance.Metro;
                this.checkBoxAdv7.Style = CheckBoxAdvStyle.Metro;
                this.checkBoxAdv10.Style = CheckBoxAdvStyle.Metro;
                this.checkBoxAdv8.Style = CheckBoxAdvStyle.Metro;
                this.checkBoxAdv9.Style = CheckBoxAdvStyle.Metro;
                this.checkBox10.Style = CheckBoxAdvStyle.Metro;
                this.checkBox2.Style = CheckBoxAdvStyle.Metro;
                this.checkBox3.Style = CheckBoxAdvStyle.Metro;
                this.checkBox4.Style = CheckBoxAdvStyle.Metro;
                this.checkBox5.Style = CheckBoxAdvStyle.Metro;
                this.checkBox6.Style = CheckBoxAdvStyle.Metro;
                this.checkBox7.Style = CheckBoxAdvStyle.Metro;
                this.checkBox8.Style = CheckBoxAdvStyle.Metro;
                this.checkBox9.Style = CheckBoxAdvStyle.Metro;
                this.checkBox10.Style = CheckBoxAdvStyle.Metro;
                this.checkBox11.Style = CheckBoxAdvStyle.Metro;
                this.checkBox12.Style = CheckBoxAdvStyle.Metro;
                this.checkBox13.Style = CheckBoxAdvStyle.Metro;
                this.checkBox14.Style = CheckBoxAdvStyle.Metro;
                this.buttonAdv1.Appearance = ButtonAppearance.Metro;
                this.comboBox1.Style = VisualStyle.Metro;
                this.comboBoxAdv1.Style = VisualStyle.Metro;
                this.comboBoxAdv2.Style = VisualStyle.Metro;
                this.radioButton1.Style = RadioButtonAdvStyle.Metro;
                this.radioButton2.Style = RadioButtonAdvStyle.Metro;
                this.radioButton3.Style = RadioButtonAdvStyle.Metro;
                this.numericUpDown1.VisualStyle = VisualStyle.Metro;
                this.numericUpDown2.VisualStyle = VisualStyle.Metro;
                this.numericUpDown3.VisualStyle = VisualStyle.Metro;
                this.numericUpDown4.VisualStyle = VisualStyle.Metro;
                this.numericUpDown5.VisualStyle = VisualStyle.Metro;
                this.scrollersFrame.VisualStyle = ScrollBarCustomDrawStyles.Metro;
                this.ShowIcon = true;
                this.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
                this.gradientPanel1.BorderColor = ColorTranslator.FromHtml("#ff1197d9");
                this.gradientPanel2.BorderColor = ColorTranslator.FromHtml("#ff1197d9");
                this.groupBar1.BorderColor = ColorTranslator.FromHtml("#ffc6c6c6");
                this.radialMenu1.Icon = global::RadialMenuDemo_2010.Properties.Resources._0000_Layer_4;
                this.radialMenu1.MenuIcon = global::RadialMenuDemo_2010.Properties.Resources._0001_Layer_3;
                this.radialMenuItem1.ImageIndex = 43;
                this.radialFontListBox1.ImageIndex = 45;
                this.radialColorPalette1.ImageIndex = 42;
                this.radialMenuSlider1.ImageIndex = 47;
                this.radialMenuItem6.ImageIndex = 55;
                this.radialMenuItem13.ImageIndex = 48;
                this.radialMenuItem14.ImageIndex = 60;
                this.radialMenuItem15.ImageIndex = 48;
                this.radialMenuItem16.ImageIndex = 66;
                this.radialMenuItem2.ImageIndex = 44;
                this.radialMenuItem3.ImageIndex = 43;
                this.radialMenuItem4.ImageIndex = 46;
                this.radialMenuItem5.ImageIndex = 48;
                this.radialMenuItem7.ImageIndex = 50;
                this.radialMenuItem8.ImageIndex = 51;
                this.radialMenuItem9.ImageIndex = 53;
                this.radialMenuItem10.ImageIndex = 54;
                this.radialMenuItem11.ImageIndex = 55;
                this.radialMenuItem12.ImageIndex = 56;
            }
            else if (this.radialMenu1.Style == RadialMenuStyle.Office2016Colorful)
            {
                this.BackColor = ColorTranslator.FromHtml("#ffffff");
                this.ForeColor = ColorTranslator.FromHtml("#262626");
                this.CaptionBarColor = ColorTranslator.FromHtml("#0173c7");
                this.CaptionForeColor = ColorTranslator.FromHtml("#ffffff");
                this.CaptionButtonColor = ColorTranslator.FromHtml("#262626");

                this.label1.ForeColor = ColorTranslator.FromHtml("#262626");
                this.label2.ForeColor = ColorTranslator.FromHtml("#262626");
                this.label3.ForeColor = ColorTranslator.FromHtml("#262626");
                this.label4.ForeColor = ColorTranslator.FromHtml("#262626");
                this.label5.ForeColor = ColorTranslator.FromHtml("#262626");
                this.label6.ForeColor = ColorTranslator.FromHtml("#262626");
                this.label7.ForeColor = ColorTranslator.FromHtml("#262626");
                this.label8.ForeColor = ColorTranslator.FromHtml("#262626");
                this.label9.ForeColor = ColorTranslator.FromHtml("#262626");
                this.label10.ForeColor = ColorTranslator.FromHtml("#262626");
                this.richTextBox1.ForeColor = ColorTranslator.FromHtml("#262626");

                this.panel1.BackColor = SystemColors.ControlLightLight;
                this.panel2.BackColor = SystemColors.ControlLightLight;
                this.panel3.BackColor = SystemColors.ControlLightLight;
                this.panel4.BackColor = SystemColors.ControlLightLight;
                this.panel5.BackColor = SystemColors.ControlLightLight;
                this.panel6.BackColor = SystemColors.ControlLightLight;
                this.panel7.BackColor = SystemColors.ControlLightLight;
                this.panel8.BackColor = SystemColors.ControlLightLight;
                this.panel9.BackColor = ColorTranslator.FromHtml("#ffffff");
                this.panel10.BackColor = SystemColors.ControlLightLight;
                this.panel11.BackColor = SystemColors.ControlLightLight;
                this.richTextBox1.BackColor = ColorTranslator.FromHtml("#ffffff");

                //this.radialMenuItem7.BackColor = System.Drawing.Color.White;
                //this.radialMenuItem8.BackColor = System.Drawing.Color.White;
                //this.radialMenuItem9.BackColor = System.Drawing.Color.White;
                //this.radialMenuItem10.BackColor = System.Drawing.Color.White;
                //this.radialMenuItem11.BackColor = System.Drawing.Color.White;
                //this.radialMenuItem12.BackColor = System.Drawing.Color.White;
                //this.radialMenuItem2.BackColor = System.Drawing.Color.White;
                //this.radialMenuItem3.BackColor = System.Drawing.Color.White;
                //this.radialMenuItem4.BackColor = System.Drawing.Color.White;
                //this.radialMenuItem5.BackColor = System.Drawing.Color.White;

                this.groupBar1.VisualStyle = VisualStyle.Office2016Colorful;
                this.colorPickerButton1.Appearance = ButtonAppearance.Office2016Colorful;
                this.colorPickerButton2.Appearance = ButtonAppearance.Office2016Colorful;
                this.colorPickerButton3.Appearance = ButtonAppearance.Office2016Colorful;
                this.colorPickerButton4.Appearance = ButtonAppearance.Office2016Colorful;
                this.colorPickerButton5.Appearance = ButtonAppearance.Office2016Colorful;
                this.colorPickerButton6.Appearance = ButtonAppearance.Office2016Colorful;
                this.colorPickerButton7.Appearance = ButtonAppearance.Office2016Colorful;
                this.colorPickerButton8.Appearance = ButtonAppearance.Office2016Colorful;
                this.colorPickerButton9.Appearance = ButtonAppearance.Office2016Colorful;
                this.colorPickerButton10.Appearance = ButtonAppearance.Office2016Colorful;
                this.colorPickerButton12.Appearance = ButtonAppearance.Office2016Colorful;
                this.colorPickerButton13.Appearance = ButtonAppearance.Office2016Colorful;
                this.colorPickerButton14.Appearance = ButtonAppearance.Office2016Colorful;
                this.checkBoxAdv7.Style = CheckBoxAdvStyle.Office2016Colorful;
                this.checkBoxAdv10.Style = CheckBoxAdvStyle.Office2016Colorful;
                this.checkBoxAdv8.Style = CheckBoxAdvStyle.Office2016Colorful;
                this.checkBoxAdv9.Style = CheckBoxAdvStyle.Office2016Colorful;
                this.checkBox10.Style = CheckBoxAdvStyle.Office2016Colorful;
                this.checkBox2.Style = CheckBoxAdvStyle.Office2016Colorful;
                this.checkBox3.Style = CheckBoxAdvStyle.Office2016Colorful;
                this.checkBox4.Style = CheckBoxAdvStyle.Office2016Colorful;
                this.checkBox5.Style = CheckBoxAdvStyle.Office2016Colorful;
                this.checkBox6.Style = CheckBoxAdvStyle.Office2016Colorful;
                this.checkBox7.Style = CheckBoxAdvStyle.Office2016Colorful;
                this.checkBox8.Style = CheckBoxAdvStyle.Office2016Colorful;
                this.checkBox9.Style = CheckBoxAdvStyle.Office2016Colorful;
                this.checkBox10.Style = CheckBoxAdvStyle.Office2016Colorful;
                this.checkBox11.Style = CheckBoxAdvStyle.Office2016Colorful;
                this.checkBox12.Style = CheckBoxAdvStyle.Office2016Colorful;
                this.checkBox13.Style = CheckBoxAdvStyle.Office2016Colorful;
                this.checkBox14.Style = CheckBoxAdvStyle.Office2016Colorful;
                this.buttonAdv1.Appearance = ButtonAppearance.Office2016Colorful;
                this.comboBox1.Style = VisualStyle.Office2016Colorful;
                this.comboBoxAdv1.Style = VisualStyle.Office2016Colorful;
                this.comboBoxAdv2.Style = VisualStyle.Office2016Colorful;
                this.radioButton1.Style = RadioButtonAdvStyle.Office2016Colorful;
                this.radioButton2.Style = RadioButtonAdvStyle.Office2016Colorful;
                this.radioButton3.Style = RadioButtonAdvStyle.Office2016Colorful;
                this.numericUpDown1.VisualStyle = VisualStyle.Office2016Colorful;
                this.numericUpDown2.VisualStyle = VisualStyle.Office2016Colorful;
                this.numericUpDown3.VisualStyle = VisualStyle.Office2016Colorful;
                this.numericUpDown4.VisualStyle = VisualStyle.Office2016Colorful;
                this.numericUpDown5.VisualStyle = VisualStyle.Office2016Colorful;
                this.scrollersFrame.VisualStyle = ScrollBarCustomDrawStyles.Office2016;
                this.scrollersFrame.Office2016ColorScheme = ScrollBarOffice2016ColorScheme.Colorful;
                this.ShowIcon = false;
                this.MetroColor = ColorTranslator.FromHtml("#0173c7");
                this.BorderColor = ColorTranslator.FromHtml("#c5c5c5");
                this.gradientPanel1.BorderColor = ColorTranslator.FromHtml("#c5c5c5");
                this.gradientPanel2.BorderColor = ColorTranslator.FromHtml("#c5c5c5");
                this.groupBar1.BorderColor = ColorTranslator.FromHtml("#c5c5c5");
                this.radialMenu1.Icon = global::RadialMenuDemo_2010.Properties.Resources.A_Colorful;
                this.radialMenu1.MenuIcon = global::RadialMenuDemo_2010.Properties.Resources.Arrow_Colorful;
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
                this.BackColor = ColorTranslator.FromHtml("#ffffff");
                this.ForeColor = ColorTranslator.FromHtml("#262626");
                this.CaptionBarColor = ColorTranslator.FromHtml("#ffffff");
                this.CaptionForeColor = ColorTranslator.FromHtml("#262626");
                this.CaptionButtonColor= ColorTranslator.FromHtml("#262626");
                this.label1.ForeColor = ColorTranslator.FromHtml("#262626");
                this.label2.ForeColor = ColorTranslator.FromHtml("#262626");
                this.label3.ForeColor = ColorTranslator.FromHtml("#262626");
                this.label4.ForeColor = ColorTranslator.FromHtml("#262626");
                this.label5.ForeColor = ColorTranslator.FromHtml("#262626");
                this.label6.ForeColor = ColorTranslator.FromHtml("#262626");
                this.label7.ForeColor = ColorTranslator.FromHtml("#262626");
                this.label8.ForeColor = ColorTranslator.FromHtml("#262626");
                this.label9.ForeColor = ColorTranslator.FromHtml("#262626");
                this.label10.ForeColor = ColorTranslator.FromHtml("#262626");
                this.richTextBox1.ForeColor = ColorTranslator.FromHtml("#262626");

                this.panel1.BackColor = ColorTranslator.FromHtml("#ffffff");
                this.panel2.BackColor = ColorTranslator.FromHtml("#ffffff");
                this.panel3.BackColor = ColorTranslator.FromHtml("#ffffff");
                this.panel4.BackColor = ColorTranslator.FromHtml("#ffffff");
                this.panel5.BackColor = ColorTranslator.FromHtml("#ffffff");
                this.panel6.BackColor = ColorTranslator.FromHtml("#ffffff");
                this.panel7.BackColor = ColorTranslator.FromHtml("#ffffff");
                this.panel8.BackColor = ColorTranslator.FromHtml("#ffffff");
                this.panel9.BackColor = ColorTranslator.FromHtml("#ffffff");
                this.panel10.BackColor = ColorTranslator.FromHtml("#ffffff");
                this.panel11.BackColor = ColorTranslator.FromHtml("#ffffff");
                this.richTextBox1.BackColor = ColorTranslator.FromHtml("#ffffff");

                //this.radialMenuItem7.BackColor = System.Drawing.Color.White;
                //this.radialMenuItem8.BackColor = System.Drawing.Color.White;
                //this.radialMenuItem9.BackColor = System.Drawing.Color.White;
                //this.radialMenuItem10.BackColor = System.Drawing.Color.White;
                //this.radialMenuItem11.BackColor = System.Drawing.Color.White;
                //this.radialMenuItem12.BackColor = System.Drawing.Color.White;
                //this.radialMenuItem2.BackColor = System.Drawing.Color.White;
                //this.radialMenuItem3.BackColor = System.Drawing.Color.White;
                //this.radialMenuItem4.BackColor = System.Drawing.Color.White;
                //this.radialMenuItem5.BackColor = System.Drawing.Color.White;

                this.groupBar1.VisualStyle = VisualStyle.Office2016White;
                this.colorPickerButton1.Appearance = ButtonAppearance.Office2016White;
                this.colorPickerButton2.Appearance = ButtonAppearance.Office2016White;
                this.colorPickerButton3.Appearance = ButtonAppearance.Office2016White;
                this.colorPickerButton4.Appearance = ButtonAppearance.Office2016White;
                this.colorPickerButton5.Appearance = ButtonAppearance.Office2016White;
                this.colorPickerButton6.Appearance = ButtonAppearance.Office2016White;
                this.colorPickerButton7.Appearance = ButtonAppearance.Office2016White;
                this.colorPickerButton8.Appearance = ButtonAppearance.Office2016White;
                this.colorPickerButton9.Appearance = ButtonAppearance.Office2016White;
                this.colorPickerButton10.Appearance = ButtonAppearance.Office2016White;
                this.colorPickerButton12.Appearance = ButtonAppearance.Office2016White;
                this.colorPickerButton13.Appearance = ButtonAppearance.Office2016White;
                this.colorPickerButton14.Appearance = ButtonAppearance.Office2016White;
                this.checkBoxAdv7.Style = CheckBoxAdvStyle.Office2016White;
                this.checkBoxAdv10.Style = CheckBoxAdvStyle.Office2016White;
                this.checkBoxAdv8.Style = CheckBoxAdvStyle.Office2016White;
                this.checkBoxAdv9.Style = CheckBoxAdvStyle.Office2016White;
                this.checkBox2.Style = CheckBoxAdvStyle.Office2016White;
                this.checkBox3.Style = CheckBoxAdvStyle.Office2016White;
                this.checkBox4.Style = CheckBoxAdvStyle.Office2016White;
                this.checkBox5.Style = CheckBoxAdvStyle.Office2016White;
                this.checkBox6.Style = CheckBoxAdvStyle.Office2016White;
                this.checkBox7.Style = CheckBoxAdvStyle.Office2016White;
                this.checkBox8.Style = CheckBoxAdvStyle.Office2016White;
                this.checkBox9.Style = CheckBoxAdvStyle.Office2016White;
                this.checkBox10.Style = CheckBoxAdvStyle.Office2016White;
                this.checkBox11.Style = CheckBoxAdvStyle.Office2016White;
                this.checkBox12.Style = CheckBoxAdvStyle.Office2016White;
                this.checkBox13.Style = CheckBoxAdvStyle.Office2016White;
                this.checkBox14.Style = CheckBoxAdvStyle.Office2016White;
                this.buttonAdv1.Appearance = ButtonAppearance.Office2016White;
                this.comboBox1.Style = VisualStyle.Office2016White;
                this.comboBoxAdv1.Style = VisualStyle.Office2016White;
                this.comboBoxAdv2.Style = VisualStyle.Office2016White;
                this.radioButton1.Style = RadioButtonAdvStyle.Office2016White;
                this.radioButton2.Style = RadioButtonAdvStyle.Office2016White;
                this.radioButton3.Style = RadioButtonAdvStyle.Office2016White;
                this.numericUpDown1.VisualStyle = VisualStyle.Office2016White;
                this.numericUpDown2.VisualStyle = VisualStyle.Office2016White;
                this.numericUpDown3.VisualStyle = VisualStyle.Office2016White;
                this.numericUpDown4.VisualStyle = VisualStyle.Office2016White;
                this.numericUpDown5.VisualStyle = VisualStyle.Office2016White;
                this.scrollersFrame.VisualStyle = ScrollBarCustomDrawStyles.Office2016;
                this.scrollersFrame.Office2016ColorScheme = ScrollBarOffice2016ColorScheme.White;
                this.MetroColor = ColorTranslator.FromHtml("#ffffff");
                this.ShowIcon = false;
                this.BorderColor = ColorTranslator.FromHtml("#c5c5c5");
                this.gradientPanel1.BorderColor = ColorTranslator.FromHtml("#c5c5c5");
                this.gradientPanel2.BorderColor = ColorTranslator.FromHtml("#c5c5c5");
                this.groupBar1.BorderColor = ColorTranslator.FromHtml("#c5c5c5");
                this.radialMenu1.Icon = global::RadialMenuDemo_2010.Properties.Resources.A_White;
                this.radialMenu1.MenuIcon = global::RadialMenuDemo_2010.Properties.Resources.Arrow_white;
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
                this.BackColor = ColorTranslator.FromHtml("#262626");
                this.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                this.CaptionBarColor = ColorTranslator.FromHtml("#363636");
                this.CaptionForeColor = ColorTranslator.FromHtml("#f0f0f0");
                this.CaptionButtonColor = ColorTranslator.FromHtml("#f0f0f0");

                this.label1.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                this.label2.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                this.label3.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                this.label4.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                this.label5.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                this.label6.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                this.label7.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                this.label8.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                this.label9.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                this.label10.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                this.richTextBox1.ForeColor = ColorTranslator.FromHtml("#f0f0f0");

                //this.radialMenuItem7.BackColor = ColorTranslator.FromHtml("#262626");
                //this.radialMenuItem8.BackColor = ColorTranslator.FromHtml("#262626");
                //this.radialMenuItem9.BackColor = ColorTranslator.FromHtml("#262626");
                //this.radialMenuItem10.BackColor = ColorTranslator.FromHtml("#262626");
                //this.radialMenuItem11.BackColor = ColorTranslator.FromHtml("#262626");
                //this.radialMenuItem12.BackColor = ColorTranslator.FromHtml("#262626");
                //this.radialMenuItem2.BackColor = ColorTranslator.FromHtml("#262626");
                //this.radialMenuItem3.BackColor = ColorTranslator.FromHtml("#262626");
                //this.radialMenuItem4.BackColor = ColorTranslator.FromHtml("#262626");
                //this.radialMenuItem5.BackColor = ColorTranslator.FromHtml("#262626");

                this.panel1.BackColor = ColorTranslator.FromHtml("#262626");
                this.panel2.BackColor = ColorTranslator.FromHtml("#262626");
                this.panel3.BackColor = ColorTranslator.FromHtml("#262626");
                this.panel4.BackColor = ColorTranslator.FromHtml("#262626");
                this.panel5.BackColor = ColorTranslator.FromHtml("#262626");
                this.panel6.BackColor = ColorTranslator.FromHtml("#262626");
                this.panel7.BackColor = ColorTranslator.FromHtml("#262626");
                this.panel8.BackColor = ColorTranslator.FromHtml("#262626");
                this.panel9.BackColor = ColorTranslator.FromHtml("#262626");
                this.panel10.BackColor = ColorTranslator.FromHtml("#262626");
                this.panel11.BackColor = ColorTranslator.FromHtml("#262626");
                this.richTextBox1.BackColor = ColorTranslator.FromHtml("#262626");

                this.groupBar1.VisualStyle = VisualStyle.Office2016Black;
                this.colorPickerButton1.Appearance = ButtonAppearance.Office2016Black;
                this.colorPickerButton2.Appearance = ButtonAppearance.Office2016Black;
                this.colorPickerButton3.Appearance = ButtonAppearance.Office2016Black;
                this.colorPickerButton4.Appearance = ButtonAppearance.Office2016Black;
                this.colorPickerButton5.Appearance = ButtonAppearance.Office2016Black;
                this.colorPickerButton6.Appearance = ButtonAppearance.Office2016Black;
                this.colorPickerButton7.Appearance = ButtonAppearance.Office2016Black;
                this.colorPickerButton8.Appearance = ButtonAppearance.Office2016Black;
                this.colorPickerButton9.Appearance = ButtonAppearance.Office2016Black;
                this.colorPickerButton10.Appearance = ButtonAppearance.Office2016Black;
                this.colorPickerButton12.Appearance = ButtonAppearance.Office2016Black;
                this.colorPickerButton13.Appearance = ButtonAppearance.Office2016Black;
                this.colorPickerButton14.Appearance = ButtonAppearance.Office2016Black;
                this.checkBoxAdv7.Style = CheckBoxAdvStyle.Office2016Black;
                this.checkBoxAdv10.Style = CheckBoxAdvStyle.Office2016Black;
                this.checkBoxAdv8.Style = CheckBoxAdvStyle.Office2016Black;
                this.checkBoxAdv9.Style = CheckBoxAdvStyle.Office2016Black;
                this.checkBox2.Style = CheckBoxAdvStyle.Office2016Black;
                this.checkBox3.Style = CheckBoxAdvStyle.Office2016Black;
                this.checkBox4.Style = CheckBoxAdvStyle.Office2016Black;
                this.checkBox5.Style = CheckBoxAdvStyle.Office2016Black;
                this.checkBox6.Style = CheckBoxAdvStyle.Office2016Black;
                this.checkBox7.Style = CheckBoxAdvStyle.Office2016Black;
                this.checkBox8.Style = CheckBoxAdvStyle.Office2016Black;
                this.checkBox9.Style = CheckBoxAdvStyle.Office2016Black;
                this.checkBox10.Style = CheckBoxAdvStyle.Office2016Black;
                this.checkBox11.Style = CheckBoxAdvStyle.Office2016Black;
                this.checkBox12.Style = CheckBoxAdvStyle.Office2016Black;
                this.checkBox13.Style = CheckBoxAdvStyle.Office2016Black;
                this.checkBox14.Style = CheckBoxAdvStyle.Office2016Black;
                this.buttonAdv1.Appearance = ButtonAppearance.Office2016Black;
                this.comboBox1.Style = VisualStyle.Office2016Black;
                this.comboBoxAdv1.Style = VisualStyle.Office2016Black;
                this.comboBoxAdv2.Style = VisualStyle.Office2016Black;
                this.radioButton1.Style = RadioButtonAdvStyle.Office2016Black;
                this.radioButton2.Style = RadioButtonAdvStyle.Office2016Black;
                this.radioButton3.Style = RadioButtonAdvStyle.Office2016Black;
                this.numericUpDown1.VisualStyle = VisualStyle.Office2016Black;
                this.numericUpDown2.VisualStyle = VisualStyle.Office2016Black;
                this.numericUpDown3.VisualStyle = VisualStyle.Office2016Black;
                this.numericUpDown4.VisualStyle = VisualStyle.Office2016Black;
                this.numericUpDown5.VisualStyle = VisualStyle.Office2016Black;
                this.scrollersFrame.VisualStyle = ScrollBarCustomDrawStyles.Office2016;
                this.scrollersFrame.Office2016ColorScheme = ScrollBarOffice2016ColorScheme.Black;
                this.ShowIcon = false;
                this.BorderColor = ColorTranslator.FromHtml("#363636");
                this.MetroColor = ColorTranslator.FromHtml("#363636");
                this.gradientPanel1.BorderColor = ColorTranslator.FromHtml("#363636");
                this.gradientPanel2.BorderColor = ColorTranslator.FromHtml("#363636");
                this.groupBar1.BorderColor = ColorTranslator.FromHtml("#363636");
                this.radialMenu1.Icon = global::RadialMenuDemo_2010.Properties.Resources.A_Black;
                this.radialMenu1.MenuIcon = global::RadialMenuDemo_2010.Properties.Resources.Arrow_Black;
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
                this.BackColor = ColorTranslator.FromHtml("#666666");
                this.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                this.CaptionBarColor = ColorTranslator.FromHtml("#505050");
                this.CaptionForeColor = ColorTranslator.FromHtml("#f0f0f0");
                this.CaptionButtonColor = ColorTranslator.FromHtml("#f0f0f0");

                this.label1.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                this.label2.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                this.label3.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                this.label4.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                this.label5.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                this.label6.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                this.label7.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                this.label8.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                this.label9.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                this.label10.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                this.richTextBox1.ForeColor = ColorTranslator.FromHtml("#f0f0f0");

                this.panel1.BackColor = ColorTranslator.FromHtml("#666666");
                this.panel2.BackColor = ColorTranslator.FromHtml("#666666");
                this.panel3.BackColor = ColorTranslator.FromHtml("#666666");
                this.panel4.BackColor = ColorTranslator.FromHtml("#666666");
                this.panel5.BackColor = ColorTranslator.FromHtml("#666666");
                this.panel6.BackColor = ColorTranslator.FromHtml("#666666");
                this.panel7.BackColor = ColorTranslator.FromHtml("#666666");
                this.panel8.BackColor = ColorTranslator.FromHtml("#666666");
                this.panel9.BackColor = ColorTranslator.FromHtml("#666666");
                this.panel10.BackColor = ColorTranslator.FromHtml("#666666");
                this.panel11.BackColor = ColorTranslator.FromHtml("#666666");
                this.richTextBox1.BackColor = ColorTranslator.FromHtml("#666666");

                //this.radialMenuItem7.BackColor = ColorTranslator.FromHtml("#666666");
                //this.radialMenuItem8.BackColor = ColorTranslator.FromHtml("#666666");
                //this.radialMenuItem9.BackColor = ColorTranslator.FromHtml("#666666");
                //this.radialMenuItem10.BackColor = ColorTranslator.FromHtml("#666666");
                //this.radialMenuItem11.BackColor = ColorTranslator.FromHtml("#666666");
                //this.radialMenuItem12.BackColor = ColorTranslator.FromHtml("#666666");
                //this.radialMenuItem2.BackColor = ColorTranslator.FromHtml("#666666");
                //this.radialMenuItem3.BackColor = ColorTranslator.FromHtml("#666666");
                //this.radialMenuItem4.BackColor = ColorTranslator.FromHtml("#666666");
                //this.radialMenuItem5.BackColor = ColorTranslator.FromHtml("#666666");

                this.groupBar1.VisualStyle = VisualStyle.Office2016DarkGray;
                this.colorPickerButton1.Appearance = ButtonAppearance.Office2016DarkGray;
                this.colorPickerButton2.Appearance = ButtonAppearance.Office2016DarkGray;
                this.colorPickerButton3.Appearance = ButtonAppearance.Office2016DarkGray;
                this.colorPickerButton4.Appearance = ButtonAppearance.Office2016DarkGray;
                this.colorPickerButton5.Appearance = ButtonAppearance.Office2016DarkGray;
                this.colorPickerButton6.Appearance = ButtonAppearance.Office2016DarkGray;
                this.colorPickerButton7.Appearance = ButtonAppearance.Office2016DarkGray;
                this.colorPickerButton8.Appearance = ButtonAppearance.Office2016DarkGray;
                this.colorPickerButton9.Appearance = ButtonAppearance.Office2016DarkGray;
                this.colorPickerButton10.Appearance = ButtonAppearance.Office2016DarkGray;
                this.colorPickerButton12.Appearance = ButtonAppearance.Office2016DarkGray;
                this.colorPickerButton13.Appearance = ButtonAppearance.Office2016DarkGray;
                this.colorPickerButton14.Appearance = ButtonAppearance.Office2016DarkGray;
                this.checkBoxAdv7.Style = CheckBoxAdvStyle.Office2016DarkGray;
                this.checkBoxAdv10.Style = CheckBoxAdvStyle.Office2016DarkGray;
                this.checkBoxAdv8.Style = CheckBoxAdvStyle.Office2016DarkGray;
                this.checkBoxAdv9.Style = CheckBoxAdvStyle.Office2016DarkGray;
                this.checkBox2.Style = CheckBoxAdvStyle.Office2016DarkGray;
                this.checkBox3.Style = CheckBoxAdvStyle.Office2016DarkGray;
                this.checkBox4.Style = CheckBoxAdvStyle.Office2016DarkGray;
                this.checkBox5.Style = CheckBoxAdvStyle.Office2016DarkGray;
                this.checkBox6.Style = CheckBoxAdvStyle.Office2016DarkGray;
                this.checkBox7.Style = CheckBoxAdvStyle.Office2016DarkGray;
                this.checkBox8.Style = CheckBoxAdvStyle.Office2016DarkGray;
                this.checkBox9.Style = CheckBoxAdvStyle.Office2016DarkGray;
                this.checkBox10.Style = CheckBoxAdvStyle.Office2016DarkGray;
                this.checkBox11.Style = CheckBoxAdvStyle.Office2016DarkGray;
                this.checkBox12.Style = CheckBoxAdvStyle.Office2016DarkGray;
                this.checkBox13.Style = CheckBoxAdvStyle.Office2016DarkGray;
                this.checkBox14.Style = CheckBoxAdvStyle.Office2016DarkGray;
                this.buttonAdv1.Appearance = ButtonAppearance.Office2016DarkGray;
                this.comboBox1.Style = VisualStyle.Office2016DarkGray;
                this.comboBoxAdv1.Style = VisualStyle.Office2016DarkGray;
                this.comboBoxAdv2.Style = VisualStyle.Office2016DarkGray;
                this.radioButton1.Style = RadioButtonAdvStyle.Office2016DarkGray;
                this.radioButton2.Style = RadioButtonAdvStyle.Office2016DarkGray;
                this.radioButton3.Style = RadioButtonAdvStyle.Office2016DarkGray;
                this.numericUpDown1.VisualStyle = VisualStyle.Office2016DarkGray;
                this.numericUpDown2.VisualStyle = VisualStyle.Office2016DarkGray;
                this.numericUpDown3.VisualStyle = VisualStyle.Office2016DarkGray;
                this.numericUpDown4.VisualStyle = VisualStyle.Office2016DarkGray;
                this.numericUpDown5.VisualStyle = VisualStyle.Office2016DarkGray;
                this.scrollersFrame.VisualStyle = ScrollBarCustomDrawStyles.Office2016;
                this.scrollersFrame.Office2016ColorScheme = ScrollBarOffice2016ColorScheme.DarkGray;
                this.MetroColor = ColorTranslator.FromHtml("#505050");
                this.ShowIcon = false;
                this.BorderColor = ColorTranslator.FromHtml("#444444");
                this.gradientPanel1.BorderColor = ColorTranslator.FromHtml("#444444");
                this.gradientPanel2.BorderColor = ColorTranslator.FromHtml("#444444");
                this.groupBar1.BorderColor = ColorTranslator.FromHtml("#444444");
                this.radialMenu1.Icon = global::RadialMenuDemo_2010.Properties.Resources.A_DarkGray;
                this.radialMenu1.MenuIcon = global::RadialMenuDemo_2010.Properties.Resources.Arrow_DarkGray;
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
        private void colorPickerButton1_ColorSelected(object sender, EventArgs e)
        {
            this.radialMenu1.RimBackground = colorPickerButton1.SelectedColor;
        }

        private void colorPickerButton2_ColorSelected(object sender, EventArgs e)
        {
            this.radialMenu1.HighlightedArcColor = colorPickerButton2.SelectedColor;
        }

        private void colorPickerButton3_ColorSelected(object sender, EventArgs e)
        {
            this.radialMenu1.OuterArcColor = colorPickerButton3.SelectedColor;
        }

        private void colorPickerButton4_ColorSelected(object sender, EventArgs e)
        {
            this.radialMenu1.OuterArcHighLightedColor = colorPickerButton4.SelectedColor;
        }

        private void colorPickerButton5_ColorSelected(object sender, EventArgs e)
        {
            this.radialMenu1.DrillDownArrowColor = colorPickerButton5.SelectedColor;
        }
        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {
            this.radialMenu1.WedgeCount = (int)this.numericUpDown4.Value;
        }

        #endregion

        #region Slider Customization

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            this.radialMenuSlider1.MaximumValue = (int)this.numericUpDown2.Value;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            this.radialMenuSlider1.MinimumValue = (int)this.numericUpDown1.Value;
        }

        #endregion

        #region FontListBox Customization

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            this.radialFontListBox1.ItemHeight = (int)this.numericUpDown3.Value;
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

       

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                this.radialMenu1.ShowToolTip = true;
            }
            else
            {
                this.radialMenu1.ShowToolTip = false;
            }
        }
     
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(this.comboBox1.SelectedItem.ToString() == "TextAboveImage")
            {
                this.radialMenu1.DisplayStyle = Syncfusion.Windows.Forms.Tools.DisplayStyle.TextAboveImage;
            }
            else if (this.comboBox1.SelectedItem.ToString() == "ImageAboveText")
            {
                this.radialMenu1.DisplayStyle = Syncfusion.Windows.Forms.Tools.DisplayStyle.ImageAboveText;
            }
            else if (this.comboBox1.SelectedItem.ToString() == "Text")
            {
                this.radialMenu1.DisplayStyle = Syncfusion.Windows.Forms.Tools.DisplayStyle.Text;
            }
            else if (this.comboBox1.SelectedItem.ToString() == "Image")
            {
                this.radialMenu1.DisplayStyle = Syncfusion.Windows.Forms.Tools.DisplayStyle.Image;
            }
            this.radialMenu1.Refresh();
        }     

        private void colorPickerButton6_ColorSelected_1(object sender, EventArgs e)
        {
            
            colorCollection.Color1 = colorPickerButton6.SelectedColor;
            this.radialMenu1.Refresh();
        }

        private void colorPickerButton7_ColorSelected(object sender, EventArgs e)
        {
            colorCollection.Color2 = colorPickerButton7.SelectedColor;
            this.radialMenu1.Refresh();
        }
        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            if (this.WindowState != FormWindowState.Minimized)
                this.radialMenu1.ShowRadialMenu(new  Point(700,100));
        }
        private void colorPickerButton8_ColorSelected(object sender, EventArgs e)
        {
            colorCollection.Color3= colorPickerButton8.SelectedColor;
            this.radialMenu1.Refresh();
        }

        private void colorPickerButton9_ColorSelected(object sender, EventArgs e)
        {
            colorCollection.Color4 = colorPickerButton9.SelectedColor;
            this.radialMenu1.Refresh();
        }

        private void colorPickerButton10_ColorSelected(object sender, EventArgs e)
        {
            colorCollection.Color5 = colorPickerButton10.SelectedColor;
            this.radialMenu1.Refresh();
        }

        private void colorPickerButton12_ColorSelected(object sender, EventArgs e)
        {
            colorCollection.Color6 = colorPickerButton12.SelectedColor;
            this.radialMenu1.Refresh();
        }

        private void colorPickerButton13_ColorSelected(object sender, EventArgs e)
        {
            colorCollection.Color7 = colorPickerButton13.SelectedColor;
            this.radialMenu1.Refresh();
        }

        private void colorPickerButton14_ColorSelected(object sender, EventArgs e)
        {
            colorCollection.Color8= colorPickerButton14.SelectedColor;
            this.radialMenu1.Refresh();
        }

        private void buttonAdv1_Click_1(object sender, EventArgs e)
        {
            if (!this.radialColorPalette1.ColorPaletteItemCollection.Contains(colorCollection))
                this.radialColorPalette1.ColorPaletteItemCollection.Add(colorCollection);
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                this.radialMenuItem2.CheckMode = CheckMode.Check;
            }
            else if (radioButton2.Checked)
            {
                this.radialMenuItem2.CheckMode = CheckMode.Option;
                this.radialMenuItem2.GroupName = "group1";
            }
            else if (radioButton3.Checked)
            {
                this.radialMenuItem2.CheckMode = CheckMode.None;
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

            if (radioButton1.Checked)
            {
                this.radialMenuItem3.CheckMode = CheckMode.Check;
            }
            else if (radioButton2.Checked)
            {
                this.radialMenuItem3.CheckMode = CheckMode.Option;
                this.radialMenuItem3.GroupName = "group1";
            }
            else if (radioButton3.Checked)
            {
                this.radialMenuItem3.CheckMode = CheckMode.None;
            }
        }
        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                this.radialMenuItem4.CheckMode = CheckMode.Check;
         
            }
            else if (radioButton2.Checked)
            {
                this.radialMenuItem4.CheckMode = CheckMode.Option;
                this.radialMenuItem4.GroupName = "group1";
                
            }
            else if (radioButton3.Checked)
            {
                this.radialMenuItem4.CheckMode = CheckMode.None;
            }
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                this.radialMenuItem5.CheckMode = CheckMode.Check;
            }
            else if (radioButton2.Checked)
            {
                this.radialMenuItem5.CheckMode = CheckMode.Option;
                this.radialMenuItem5.GroupName = "group1";
            }
            else if (radioButton3.Checked)
            {
                this.radialMenuItem5.CheckMode = CheckMode.None;
            }
        }
        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {
            this.panel9.Visible = true;
            this.radialMenuItem2.Checked = false;
            this.radialMenuItem3.Checked = false;
            this.radialMenuItem4.Checked = false;
            this.radialMenuItem5.Checked = false;
            this.radialMenu1.Refresh();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            this.radialMenuItem2.Checked = false;
            this.radialMenuItem3.Checked = false;
            this.radialMenuItem4.Checked = false;
            this.radialMenuItem5.Checked = false;
            this.checkBox3.Checked = false;
            this.checkBox4.Checked = false;
            this.checkBox5.Checked = false;
            this.checkBox6.Checked = false;
            this.radialMenu1.Refresh();
            this.panel9.Visible = false;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            
            this.panel9.Visible = true;
            this.checkBox3.Checked = false;
            this.checkBox4.Checked = false;
            this.checkBox5.Checked = false;
            this.checkBox6.Checked = false;
            this.radialMenuItem2.Checked = false;
            this.radialMenuItem3.Checked = false;
            this.radialMenuItem4.Checked = false;
            this.radialMenuItem5.Checked = false;
            this.radialMenu1.Refresh();
        }

        private void numericUpDown5_ValueChanged(object sender, EventArgs e)
        {
            this.radialMenu1.StartAngle((int)numericUpDown5.Value);
            this.radialMenu1.Refresh();
        }

        private void buttonAdv2_Click(object sender, EventArgs e)
        {
            this.radialMenu1.Items.Clear();
            this.radialMenu1.UseIndexBasedOrder = true;
            this.radialMenu1.WedgeCount = 8;
            this.numericUpDown4.Value = 8;
            this.radialMenu1.Items.Add(this.radialMenuItem1);
            this.radialMenu1.Items.Add(this.radialMenuSlider1);
            this.radialMenu1.Items.Add(this.radialColorPalette1);
            this.radialMenu1.Items.Add(this.radialFontListBox1);
            this.radialMenu1.ItemOnLoad = null;
            this.radialMenu1.Refresh();
        }

        
        
          
       
    }
}
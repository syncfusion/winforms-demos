using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Syncfusion.Windows.Forms;
using System.Text.RegularExpressions;

namespace Radial
{
    public partial class Form1 : MetroForm
    {
        #region Initialization
        public Form1()
        {
            InitializeComponent();
            this.MinimumSize = this.Size;
            try
            {
                System.Drawing.Icon ico = new System.Drawing.Icon(GetIconFile(@"common\Images\Grid\Icon\sfgrid.ico"));
                this.Icon = ico;
            }
            catch { }
            this.radialSlider1.RangeStyle = Syncfusion.Windows.Forms.Tools.RangeStyles.Solid;
            this.radialSlider1.ValueChanged += new Syncfusion.Windows.Forms.Tools.RadialSlider.ValueChangedEventHandler(radialSlider1_ValueChanged);
            ScrollersFrame Sframe = new ScrollersFrame();
            Sframe.VisualStyle = ScrollBarCustomDrawStyles.Metro;
            Sframe.AttachedTo = this.richTextBox1;
            UpdateRadialSliderStyleforOffice2016Themes();
        }
        #endregion
        #region Form Icon
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
        #region events
        #region Customize value

        Char[] unallowedchar = { '!', '@', '#', '$', '%', '^', '&', '*', '(', ')', '_', '+' };
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {

                for (int i = 0; i < unallowedchar.Length; i++)
                {
                    {
                        if (textBox1.Text.Contains(unallowedchar[i]))
                        {
                            textBox1.Text = String.Empty;
                            MessageBoxAdv.Show("No special characters allowed","Invalid Input");
                        }
                    }
                }

                if (textBox1.Text != string.Empty)
                    this.radialSlider1.SliderDivision = Convert.ToInt32(this.textBox1.Text);
            }
            catch (Exception)
            {
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < unallowedchar.Length; i++)
                {
                    {
                        if (textBox2.Text.Contains(unallowedchar[i]))
                        {
                            textBox2.Text = String.Empty;
                            MessageBoxAdv.Show("No special characters allowed", "Invalid Input");
                        }
                    }
                }
                if (textBox2.Text != string.Empty)
                    this.radialSlider1.MaximumValue = Convert.ToInt32(this.textBox2.Text);
            }
            catch (Exception)
            {
            }
        }
        #endregion
        #region OuterCircle
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            this.radialSlider1.ShowOuterCircle = this.checkBox1.Checked;
        }

        #endregion
        #region SliderValueChanged
        private void radialSlider1_ValueChanged(object sender, Syncfusion.Windows.Forms.Tools.RadialSlider.ValueChangedEventArgs args)
        {
            if (this.richTextBox1.SelectedText.Length == 0)
            {
                this.richTextBox1.SelectAll();
            }
            if (this.radialSlider1.Value > 0)
            {
                this.richTextBox1.SelectionFont = new System.Drawing.Font(Font.Name, (float)this.radialSlider1.Value);//
                this.Refresh();
            }
        }
        #endregion
        #region SliderFrame
        private void radioButtonAdv1_CheckChanged(object sender, EventArgs e)
        {
            if (radioButtonAdv1.Checked)
            {
                this.radialSlider1.SliderStyle = Syncfusion.Windows.Forms.Tools.SliderStyles.Default;
                radioButtonAdv3.Enabled = radioButtonAdv4.Enabled = true;
                checkBoxAdv1.Enabled = true;
                colorPickerButton1.Enabled = colorPickerButton2.Enabled = colorPickerButton3.Enabled = colorPickerButton4.Enabled = true;
                this.groupBox1.Enabled = true;
            }
        }

        private void radioButtonAdv2_CheckChanged(object sender, EventArgs e)
        {
            if (radioButtonAdv2.Checked)
            {
                this.radialSlider1.SliderStyle = Syncfusion.Windows.Forms.Tools.SliderStyles.Frame;
                radioButtonAdv3.Enabled = radioButtonAdv4.Enabled = false;
                checkBoxAdv1.Enabled = false;
                colorPickerButton1.Enabled = colorPickerButton2.Enabled = colorPickerButton3.Enabled = colorPickerButton4.Enabled = false;
                this.groupBox1.Enabled = false;
            }
        }
        #endregion
        #region SliderCustomization
        private void checkBoxAdv1_CheckStateChanged(object sender, EventArgs e)
        {
            this.radialSlider1.ShowOuterCircle = checkBoxAdv1.Checked;
        }
        private void radioButtonAdv3_CheckChanged(object sender, EventArgs e)
        {
            if (this.radioButtonAdv3.Checked)
                this.radialSlider1.NeedleType = Syncfusion.Windows.Forms.Tools.SliderNeedleType.StraightLine;
        }

        private void radioButtonAdv4_CheckChanged(object sender, EventArgs e)
        {
            if (this.radioButtonAdv4.Checked)
                this.radialSlider1.NeedleType = Syncfusion.Windows.Forms.Tools.SliderNeedleType.DottedLine;
        }

        private void colorPickerButton3_ColorSelected_1(object sender, EventArgs e)
        {
            this.radialSlider1.InnerCircleColor = colorPickerButton3.SelectedColor;
        }

        private void colorPickerButton1_ColorSelected(object sender, EventArgs e)
        {
            this.radialSlider1.SliderNeedleColor = colorPickerButton1.SelectedColor;
        }

        private void colorPickerButton4_ColorSelected(object sender, EventArgs e)
        {
            this.radialSlider1.LinesColor = colorPickerButton4.SelectedColor;
        }

        private void colorPickerButton5_ColorSelected(object sender, EventArgs e)
        {
            this.radialSlider1.ForeColor = colorPickerButton5.SelectedColor;
        }

        private void colorPickerButton2_ColorSelected(object sender, EventArgs e)
        {
            this.radialSlider1.OuterCircleColor = colorPickerButton2.SelectedColor;
        }
        #endregion
        #region VisualStyle
       
        private void ComboBoxAdv1_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (this.comboBoxAdv1.SelectedIndex == 0)
            {
                this.radialSlider1.Style = Syncfusion.Windows.Forms.Tools.RadialSliderStyle.Office2016Colorful;
            }
            else if (this.comboBoxAdv1.SelectedIndex == 1)
            {
                this.radialSlider1.Style = Syncfusion.Windows.Forms.Tools.RadialSliderStyle.Office2016White;
            }
            else if (this.comboBoxAdv1.SelectedIndex == 2)
            {
                this.radialSlider1.Style = Syncfusion.Windows.Forms.Tools.RadialSliderStyle.Office2016DarkGray;
            }
            else if (this.comboBoxAdv1.SelectedIndex == 3)
            {
                this.radialSlider1.Style = Syncfusion.Windows.Forms.Tools.RadialSliderStyle.Office2016Black;
            }

            UpdateRadialSliderStyleforOffice2016Themes();
        }

        private void UpdateRadialSliderStyleforOffice2016Themes()
        {
            if (this.radialSlider1.Style == Syncfusion.Windows.Forms.Tools.RadialSliderStyle.Office2016Colorful)
            {
                this.BackColor = ColorTranslator.FromHtml("#ffffff");
                this.ForeColor = ColorTranslator.FromHtml("#262626");
                this.label1.BackColor = ColorTranslator.FromHtml("#ffffff");
                this.label2.BackColor = ColorTranslator.FromHtml("#ffffff");
                this.label3.BackColor = ColorTranslator.FromHtml("#ffffff");
                this.label1.ForeColor = ColorTranslator.FromHtml("#262626");
                this.label2.ForeColor = ColorTranslator.FromHtml("#262626");
                this.label3.ForeColor = ColorTranslator.FromHtml("#262626");
                this.panel1.BackColor = ColorTranslator.FromHtml("#ffffff");
                this.panel2.BackColor = ColorTranslator.FromHtml("#ffffff");
                this.panel3.BackColor = ColorTranslator.FromHtml("#ffffff");
                this.panel4.BackColor = ColorTranslator.FromHtml("#ffffff");
                this.CaptionBarColor = ColorTranslator.FromHtml("#0173c7");
                this.CaptionForeColor = ColorTranslator.FromHtml("#ffffff");
                this.groupBar1.VisualStyle = VisualStyle.Office2016Colorful;
                this.gradientPanelExt1.BackColor = ColorTranslator.FromHtml("#ffffff");
                this.gradientPanelExt2.BackColor = ColorTranslator.FromHtml("#ffffff");
                this.groupBox1.BackColor = ColorTranslator.FromHtml("#ffffff");
                this.groupBox1.ForeColor = ColorTranslator.FromHtml("#262626");
                this.groupBox2.BackColor = ColorTranslator.FromHtml("#ffffff");
                this.groupBox2.ForeColor = ColorTranslator.FromHtml("#262626");
                this.groupBox3.BackColor = ColorTranslator.FromHtml("#ffffff");
                this.groupBox3.ForeColor = ColorTranslator.FromHtml("#262626");
                this.groupBox4.BackColor = ColorTranslator.FromHtml("#ffffff");
                this.groupBox4.ForeColor = ColorTranslator.FromHtml("#262626");
                this.groupBox5.BackColor = ColorTranslator.FromHtml("#ffffff");
                this.groupBox5.ForeColor = ColorTranslator.FromHtml("#262626");
                this.groupBox6.BackColor = ColorTranslator.FromHtml("#ffffff");
                this.groupBox6.ForeColor = ColorTranslator.FromHtml("#262626");
                this.richTextBox1.BackColor = ColorTranslator.FromHtml("#ffffff");
                this.richTextBox1.ForeColor = ColorTranslator.FromHtml("#262626");
                this.textBox1.BackColor = ColorTranslator.FromHtml("#ffffff");
                this.textBox1.ForeColor = ColorTranslator.FromHtml("#262626");
                this.textBox2.BackColor = ColorTranslator.FromHtml("#ffffff");
                this.textBox2.ForeColor = ColorTranslator.FromHtml("#262626");
                this.checkBoxAdv1.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Office2016Colorful;
                this.radioButtonAdv1.Style = Syncfusion.Windows.Forms.Tools.RadioButtonAdvStyle.Office2016Colorful;
                this.radioButtonAdv2.Style = Syncfusion.Windows.Forms.Tools.RadioButtonAdvStyle.Office2016Colorful;
                this.radioButtonAdv3.Style = Syncfusion.Windows.Forms.Tools.RadioButtonAdvStyle.Office2016Colorful;
                this.radioButtonAdv4.Style = Syncfusion.Windows.Forms.Tools.RadioButtonAdvStyle.Office2016Colorful;
                this.comboBoxAdv1.Style = VisualStyle.Office2016Colorful;
                this.colorPickerButton1.Appearance = ButtonAppearance.Office2016Colorful;
                this.colorPickerButton2.Appearance = ButtonAppearance.Office2016Colorful;
                this.colorPickerButton3.Appearance = ButtonAppearance.Office2016Colorful;
                this.colorPickerButton4.Appearance = ButtonAppearance.Office2016Colorful;
                this.colorPickerButton5.Appearance = ButtonAppearance.Office2016Colorful;
                this.ShowIcon = false;
                this.MetroColor = ColorTranslator.FromHtml("#0173c7");
                this.BorderColor = ColorTranslator.FromHtml("#c5c5c5");

            }
            else if (this.radialSlider1.Style == Syncfusion.Windows.Forms.Tools.RadialSliderStyle.Office2016Black)
            {

                this.BackColor = ColorTranslator.FromHtml("#262626");
                this.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                this.CaptionBarColor = ColorTranslator.FromHtml("#363636");
                this.CaptionForeColor = ColorTranslator.FromHtml("#f0f0f0");
                this.MetroColor = ColorTranslator.FromHtml("#363636");
                this.CaptionForeColor = ColorTranslator.FromHtml("#f0f0f0");
                this.label1.BackColor = ColorTranslator.FromHtml("#262626");
                this.label2.BackColor = ColorTranslator.FromHtml("#262626");
                this.label3.BackColor = ColorTranslator.FromHtml("#262626");
                this.label1.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                this.label2.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                this.label3.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                this.panel1.BackColor = ColorTranslator.FromHtml("#262626");
                this.panel2.BackColor = ColorTranslator.FromHtml("#262626");
                this.panel3.BackColor = ColorTranslator.FromHtml("#262626");
                this.panel4.BackColor = ColorTranslator.FromHtml("#262626");
                this.groupBar1.VisualStyle = VisualStyle.Office2016Black;
                this.gradientPanelExt1.BackColor = ColorTranslator.FromHtml("#262626");
                this.gradientPanelExt2.BackColor = ColorTranslator.FromHtml("#262626");
                this.groupBox1.BackColor = ColorTranslator.FromHtml("#262626");
                this.groupBox1.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                this.groupBox2.BackColor = ColorTranslator.FromHtml("#262626");
                this.groupBox2.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                this.groupBox3.BackColor = ColorTranslator.FromHtml("#262626");
                this.groupBox3.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                this.groupBox4.BackColor = ColorTranslator.FromHtml("#262626");
                this.groupBox4.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                this.groupBox5.BackColor = ColorTranslator.FromHtml("#262626");
                this.groupBox5.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                this.groupBox6.BackColor = ColorTranslator.FromHtml("#262626");
                this.groupBox6.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                this.richTextBox1.BackColor = ColorTranslator.FromHtml("#262626");
                this.richTextBox1.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                this.textBox1.BackColor = ColorTranslator.FromHtml("#262626");
                this.textBox1.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                this.textBox2.BackColor = ColorTranslator.FromHtml("#262626");
                this.textBox2.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                this.checkBoxAdv1.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Office2016Black;
                this.radioButtonAdv1.Style = Syncfusion.Windows.Forms.Tools.RadioButtonAdvStyle.Office2016Black;
                this.radioButtonAdv2.Style = Syncfusion.Windows.Forms.Tools.RadioButtonAdvStyle.Office2016Black;
                this.radioButtonAdv3.Style = Syncfusion.Windows.Forms.Tools.RadioButtonAdvStyle.Office2016Black;
                this.radioButtonAdv4.Style = Syncfusion.Windows.Forms.Tools.RadioButtonAdvStyle.Office2016Black;
                this.comboBoxAdv1.Style = VisualStyle.Office2016Black;
                this.colorPickerButton1.Appearance = ButtonAppearance.Office2016Black;
                this.colorPickerButton2.Appearance = ButtonAppearance.Office2016Black;
                this.colorPickerButton3.Appearance = ButtonAppearance.Office2016Black;
                this.colorPickerButton4.Appearance = ButtonAppearance.Office2016Black;
                this.colorPickerButton5.Appearance = ButtonAppearance.Office2016Black;
                this.ShowIcon = false;
                this.BorderColor = ColorTranslator.FromHtml("#363636");
            }
            else if (this.radialSlider1.Style == Syncfusion.Windows.Forms.Tools.RadialSliderStyle.Office2016White)
            {
                this.BackColor = ColorTranslator.FromHtml("#ffffff");
                this.ForeColor = ColorTranslator.FromHtml("#262626");
                this.CaptionBarColor = ColorTranslator.FromHtml("#ffffff");
                this.CaptionForeColor = ColorTranslator.FromHtml("#262626");
                this.groupBar1.VisualStyle = VisualStyle.Office2016White;
                this.label1.BackColor = ColorTranslator.FromHtml("#ffffff");
                this.label2.BackColor = ColorTranslator.FromHtml("#ffffff");
                this.label3.BackColor = ColorTranslator.FromHtml("#ffffff");
                this.label1.ForeColor = ColorTranslator.FromHtml("#262626");
                this.label2.ForeColor = ColorTranslator.FromHtml("#262626");
                this.label3.ForeColor = ColorTranslator.FromHtml("#262626");
                this.gradientPanelExt1.BackColor = ColorTranslator.FromHtml("#ffffff");
                this.gradientPanelExt2.BackColor = ColorTranslator.FromHtml("#ffffff");
                this.panel1.BackColor = ColorTranslator.FromHtml("#ffffff");
                this.panel2.BackColor = ColorTranslator.FromHtml("#ffffff");
                this.panel3.BackColor = ColorTranslator.FromHtml("#ffffff");
                this.panel4.BackColor = ColorTranslator.FromHtml("#ffffff");
                this.groupBox1.BackColor = ColorTranslator.FromHtml("#ffffff");
                this.groupBox1.ForeColor = ColorTranslator.FromHtml("#262626");
                this.groupBox2.BackColor = ColorTranslator.FromHtml("#ffffff");
                this.groupBox2.ForeColor = ColorTranslator.FromHtml("#262626");
                this.groupBox3.BackColor = ColorTranslator.FromHtml("#ffffff");
                this.groupBox3.ForeColor = ColorTranslator.FromHtml("#262626");
                this.groupBox4.BackColor = ColorTranslator.FromHtml("#ffffff");
                this.groupBox4.ForeColor = ColorTranslator.FromHtml("#262626");
                this.groupBox5.BackColor = ColorTranslator.FromHtml("#ffffff");
                this.groupBox5.ForeColor = ColorTranslator.FromHtml("#262626");
                this.groupBox6.BackColor = ColorTranslator.FromHtml("#ffffff");
                this.groupBox6.ForeColor = ColorTranslator.FromHtml("#262626");
                this.richTextBox1.BackColor = ColorTranslator.FromHtml("#ffffff");
                this.richTextBox1.ForeColor = ColorTranslator.FromHtml("#262626");
                this.textBox1.BackColor = ColorTranslator.FromHtml("#ffffff");
                this.textBox1.ForeColor = ColorTranslator.FromHtml("#262626");
                this.textBox2.BackColor = ColorTranslator.FromHtml("#ffffff");
                this.textBox2.ForeColor = ColorTranslator.FromHtml("#262626");
                this.checkBoxAdv1.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Office2016White;
                this.radioButtonAdv1.Style = Syncfusion.Windows.Forms.Tools.RadioButtonAdvStyle.Office2016White;
                this.radioButtonAdv2.Style = Syncfusion.Windows.Forms.Tools.RadioButtonAdvStyle.Office2016White;
                this.radioButtonAdv3.Style = Syncfusion.Windows.Forms.Tools.RadioButtonAdvStyle.Office2016White;
                this.radioButtonAdv4.Style = Syncfusion.Windows.Forms.Tools.RadioButtonAdvStyle.Office2016White;
                this.comboBoxAdv1.Style = VisualStyle.Office2016White;
                this.colorPickerButton1.Appearance = ButtonAppearance.Office2016White;
                this.colorPickerButton2.Appearance = ButtonAppearance.Office2016White;
                this.colorPickerButton3.Appearance = ButtonAppearance.Office2016White;
                this.colorPickerButton4.Appearance = ButtonAppearance.Office2016White;
                this.colorPickerButton5.Appearance = ButtonAppearance.Office2016White;
                this.MetroColor = ColorTranslator.FromHtml("#ffffff");
                this.ShowIcon = false;
                this.BorderColor = ColorTranslator.FromHtml("#c5c5c5");
            }
            else if (this.radialSlider1.Style == Syncfusion.Windows.Forms.Tools.RadialSliderStyle.Office2016DarkGray)
            {
                this.BackColor = ColorTranslator.FromHtml("#666666");
                this.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                this.CaptionBarColor = ColorTranslator.FromHtml("#505050");
                this.CaptionForeColor = ColorTranslator.FromHtml("#f0f0f0");
                this.groupBar1.VisualStyle = VisualStyle.Office2016DarkGray;
                this.label1.BackColor = ColorTranslator.FromHtml("#666666");
                this.label2.BackColor = ColorTranslator.FromHtml("#666666");
                this.label3.BackColor = ColorTranslator.FromHtml("#666666");
                this.label1.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                this.label2.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                this.label3.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                this.gradientPanelExt1.BackColor = ColorTranslator.FromHtml("#666666");
                this.gradientPanelExt2.BackColor = ColorTranslator.FromHtml("#666666");
                this.panel1.BackColor = ColorTranslator.FromHtml("#666666");
                this.panel2.BackColor = ColorTranslator.FromHtml("#666666");
                this.panel3.BackColor = ColorTranslator.FromHtml("#666666");
                this.panel4.BackColor = ColorTranslator.FromHtml("#666666");
                this.groupBox1.BackColor = ColorTranslator.FromHtml("#666666");
                this.groupBox1.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                this.groupBox2.BackColor = ColorTranslator.FromHtml("#666666");
                this.groupBox2.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                this.groupBox3.BackColor = ColorTranslator.FromHtml("#666666");
                this.groupBox3.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                this.groupBox4.BackColor = ColorTranslator.FromHtml("#666666");
                this.groupBox4.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                this.groupBox5.BackColor = ColorTranslator.FromHtml("#666666");
                this.groupBox5.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                this.groupBox6.BackColor = ColorTranslator.FromHtml("#666666");
                this.groupBox6.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                this.richTextBox1.BackColor = ColorTranslator.FromHtml("#666666");
                this.richTextBox1.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                this.textBox1.BackColor = ColorTranslator.FromHtml("#666666");
                this.textBox1.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                this.textBox2.BackColor = ColorTranslator.FromHtml("#666666");
                this.textBox2.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                this.checkBoxAdv1.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Office2016DarkGray;
                this.radioButtonAdv1.Style = Syncfusion.Windows.Forms.Tools.RadioButtonAdvStyle.Office2016DarkGray;
                this.radioButtonAdv2.Style = Syncfusion.Windows.Forms.Tools.RadioButtonAdvStyle.Office2016DarkGray;
                this.radioButtonAdv3.Style = Syncfusion.Windows.Forms.Tools.RadioButtonAdvStyle.Office2016DarkGray;
                this.radioButtonAdv4.Style = Syncfusion.Windows.Forms.Tools.RadioButtonAdvStyle.Office2016DarkGray;
                this.comboBoxAdv1.Style = VisualStyle.Office2016DarkGray;
                this.colorPickerButton1.Appearance = ButtonAppearance.Office2016DarkGray;
                this.colorPickerButton2.Appearance = ButtonAppearance.Office2016DarkGray;
                this.colorPickerButton3.Appearance = ButtonAppearance.Office2016DarkGray;
                this.colorPickerButton4.Appearance = ButtonAppearance.Office2016DarkGray;
                this.colorPickerButton5.Appearance = ButtonAppearance.Office2016DarkGray;
                this.MetroColor = ColorTranslator.FromHtml("#505050");
                this.ShowIcon = false;
                this.BorderColor = ColorTranslator.FromHtml("#444444");
            }
        }
        #endregion

        #endregion
        #region Overrides
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            this.panel2.Width = this.Width - this.panel3.Width;
            this.gradientPanelExt2.Width = this.panel2.Width - 5;
            this.gradientPanelExt2.Height = this.Height - 75;
            this.panel3.Location = new Point(this.Width - this.gradientPanelExt1.Width, this.panel3.Location.Y);
            this.richTextBox1.Width = (this.Width - this.panel3.Width - 100);
            this.richTextBox1.Height = (this.Height - 200);
        }
        #endregion
    }
}

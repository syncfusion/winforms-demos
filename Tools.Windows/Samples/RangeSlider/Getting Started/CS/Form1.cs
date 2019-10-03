#region Copyright Syncfusion Inc. 2001-2019.
// Copyright Syncfusion Inc. 2001-2019. All rights reserved.
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
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RangeSlider_2017
{
    public partial class Form1 : SfForm
    {
    
        #region Constructor
        public Form1()
        {
            InitializeComponent();
            ApplyUIConfiguration();
        }

        #endregion

        #region Events
        private void numericUpDownExt1_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDownExt num = sender as NumericUpDownExt;
            if ((int)num.Value <= this.rangeSlider1.SliderMax)
            {
                this.rangeSlider1.SliderMin = (int)num.Value;
                this.rangeSlider2.SliderMin = (int)num.Value;
            }
            else
            {
                num.Value = this.rangeSlider1.SliderMin;
            }
        }

        private void numericUpDownExt2_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDownExt num = sender as NumericUpDownExt;
            if ((int)num.Value >= this.rangeSlider1.SliderMin)
            {
                this.rangeSlider1.SliderMax = (int)num.Value;
                this.rangeSlider2.SliderMax = (int)num.Value;
            }
            else
            {
                num.Value = this.rangeSlider1.SliderMin;
            }
        }

        private void checkBoxAdv1_CheckStateChanged(object sender, EventArgs e)
        {
            CheckBoxAdv check = sender as CheckBoxAdv;
            this.rangeSlider1.ShowTicks = check.Checked;
            this.rangeSlider2.ShowTicks = check.Checked;
        }

        private void comboBoxAdv1_Click(object sender, EventArgs e)
        {
            ComboBoxAdv combo = sender as ComboBoxAdv;
            if (combo.SelectedIndex == 0)
            {
                this.rangeSlider1.TickPlacement = TickPlacement.BottomRight;
                this.rangeSlider2.TickPlacement = TickPlacement.BottomRight;
            }
            else if (combo.SelectedIndex == 1)
            {
                this.rangeSlider1.TickPlacement = TickPlacement.TopLeft;
                this.rangeSlider2.TickPlacement = TickPlacement.TopLeft;
            }
            else if (combo.SelectedIndex == 2)
            {
                this.rangeSlider1.TickPlacement = TickPlacement.Inline;
                this.rangeSlider2.TickPlacement = TickPlacement.Inline;
            }
            else if (combo.SelectedIndex == 3)
            {
                this.rangeSlider1.TickPlacement = TickPlacement.Both;
                this.rangeSlider2.TickPlacement = TickPlacement.Both;
            }
        }

        private void checkBoxAdv2_CheckStateChanged(object sender, EventArgs e)
        {
            CheckBoxAdv check = sender as CheckBoxAdv;
            this.rangeSlider1.ShowLabels = check.Checked;
            this.rangeSlider2.ShowLabels = check.Checked;
        }

        private void comboBoxAdv2_Click(object sender, EventArgs e)
        {
            ComboBoxAdv combo = sender as ComboBoxAdv;
            if (combo.SelectedIndex == 0)
            {
                this.rangeSlider1.LabelPlacement = LabelPlacement.BottomRight;
                this.rangeSlider2.LabelPlacement = LabelPlacement.BottomRight;
            }
            else if (combo.SelectedIndex == 1)
            {
                this.rangeSlider1.LabelPlacement = LabelPlacement.TopLeft;
                this.rangeSlider2.LabelPlacement = LabelPlacement.TopLeft;
            }
            else if (combo.SelectedIndex == 2)
            {
                this.rangeSlider1.LabelPlacement = LabelPlacement.Both;
                this.rangeSlider2.LabelPlacement = LabelPlacement.Both;
            }
        }
        
        private void rangeSlider1_ValueChanged(object sender, EventArgs e)
        {
            RangeSlider range = sender as RangeSlider;
            this.numericUpDownExt1.Value = range.SliderMin;
            this.numericUpDownExt2.Value = range.SliderMax;
        }
        #endregion

        #region Methods
        private void ApplyUIConfiguration()
        {
            this.rangeSlider1.ShowLabels = true;
            this.rangeSlider2.ShowLabels = true;
            this.comboBoxAdv1.SelectedIndex = 0;
            this.comboBoxAdv2.SelectedIndex = 0;
            this.BackColor = System.Drawing.Color.White;
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel3.BorderColor = ColorTranslator.FromHtml("#e8e8ec");
            this.panel4.BorderColor = ColorTranslator.FromHtml("#e8e8ec");
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.numericUpDownExt1.VisualStyle = VisualStyle.Office2016Colorful;
            this.numericUpDownExt2.VisualStyle = VisualStyle.Office2016Colorful;
            this.comboBoxAdv1.Style = VisualStyle.Office2016Colorful;
            this.comboBoxAdv2.Style = VisualStyle.Office2016Colorful;
            this.checkBoxAdv1.Style = CheckBoxAdvStyle.Office2016Colorful;
            this.checkBoxAdv2.Style = CheckBoxAdvStyle.Office2016Colorful;
            this.rangeSlider1.SliderSize = new Size(6, 16);
            this.rangeSlider2.SliderSize = new Size(6, 16);
            this.rangeSlider1.ThumbColor = ColorTranslator.FromHtml("#106ebe");
            this.rangeSlider1.RangeColor = ColorTranslator.FromHtml("#106ebe");
            this.rangeSlider1.TickColor = ColorTranslator.FromHtml("#262626");
            this.rangeSlider1.ForeColor = ColorTranslator.FromHtml("#262626");
            this.rangeSlider2.ThumbColor = ColorTranslator.FromHtml("#106ebe");
            this.rangeSlider2.RangeColor = ColorTranslator.FromHtml("#106ebe");
            this.rangeSlider2.TickColor = ColorTranslator.FromHtml("#262626");
            this.rangeSlider2.ForeColor = ColorTranslator.FromHtml("#262626");
            this.rangeSlider1.AutoSize = false;
            this.rangeSlider2.AutoSize = false;
            this.rangeSlider1.Size = new Size(300, 60);
            this.rangeSlider2.Size = new Size(60, 300);
            this.rangeSlider1.SliderMin = 4;
            this.rangeSlider2.SliderMin = 4;
            this.rangeSlider2.SliderMax = 8;
            this.rangeSlider2.SliderMax = 8;
        }
        #endregion

    }
}

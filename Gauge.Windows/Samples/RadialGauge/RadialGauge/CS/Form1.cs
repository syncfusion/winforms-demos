using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Syncfusion.Windows.Forms;
using Syncfusion.Windows.Forms.Gauge;
using System.Runtime.InteropServices;
using System.IO;

namespace RadialGaugeDemo
{
    public partial class Form1 : MetroForm
    {
        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            comboBox5.SelectedIndex = 0;
            this.pictureBox1.Visible = false;
            this.textBox1.LostFocus += new EventHandler(textBox1_LostFocus);
            toolTip1.SetToolTip(colorPickerButton1, colorPickerButton1.Text);
            try
            {
                System.Drawing.Icon ico = new System.Drawing.Icon(GetIconFile(@"common\Images\Grid\Icon\sfgrid.ico"));
                this.Icon = ico;
            }
            catch { }
            this.textBox2.TextChanged += TextBox2_TextChanged;
            this.textBox3.TextChanged += TextBox3_TextChanged;
            this.textBox4.TextChanged += TextBox4_TextChanged;
        }

        private void TextBox4_TextChanged(object sender, EventArgs e)
        {
            if (textBox4.Text.Contains("-"))
            {
                this.textBox4.Text = string.Empty;
                MessageBox.Show("Negative Values are not allowed");

            }
        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {
            if (textBox3.Text.Contains("-"))
            {
                this.textBox3.Text = string.Empty;
                MessageBox.Show("Negative Values are not allowed");

            }
        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text.Contains("-"))
            {
                this.textBox2.Text = string.Empty;
                MessageBox.Show("Negative Values are not allowed");

            }
        }

        #region Helpers
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

        #region Event Handlers
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.comboBox1.Text == "Inside")
                this.radialGauge1.TickPlacement = TickPlacement.Inside;
            else
                this.radialGauge1.TickPlacement = TickPlacement.OutSide;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.comboBox2.Text == "Inside")
                this.radialGauge1.LabelPlacement = LabelPlacement.Inside;
            else
                this.radialGauge1.LabelPlacement = LabelPlacement.Outside;
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (this.comboBox3.Text)
            {
                case "Blue":
                    this.radialGauge1.VisualStyle = ThemeStyle.Blue;
                    radialGauge1.Refresh();
                    break;
                case "Black":
                    this.radialGauge1.VisualStyle = ThemeStyle.Black;
                    radialGauge1.Refresh();
                    break;
                case "Silver":
                    this.radialGauge1.VisualStyle = ThemeStyle.Silver;
                    radialGauge1.Refresh();
                    break;
                case "Metro":
                    this.radialGauge1.VisualStyle = ThemeStyle.Metro;
                    radialGauge1.Refresh();
                    break;
                case "Managed":
                    this.radialGauge1.VisualStyle = ThemeStyle.None;
                    this.radialGauge1.BackgroundGradientStartColor = ColorTranslator.FromHtml("#FFFFFF");
                    this.radialGauge1.BackgroundGradientEndColor = Color.FromArgb(255, 128, 0);
                    this.radialGauge1.OuterFrameGradientStartColor = Color.FromArgb(255, 128, 0);
                    this.radialGauge1.OuterFrameGradientEndColor = ColorTranslator.FromHtml("#843B04");
                    this.radialGauge1.InnerFrameGradientStartColor = ColorTranslator.FromHtml("#FFFFFF");
                    this.radialGauge1.InnerFrameGradientEndColor = Color.FromArgb(255, 128, 0);
                    this.radialGauge1.GaugeArcColor = Color.White;
                    this.radialGauge1.NeedleColor = Color.White;
                    this.radialGauge1.MajorTickMarkColor = Color.White;
                    this.radialGauge1.MinorTickMarkColor = Color.White;
                    this.radialGauge1.InterLinesColor = Color.White;
                    this.radialGauge1.ScaleLabelColor = Color.Black;
                    radialGauge1.Refresh();
                    break;
                default:
                    this.radialGauge1.VisualStyle = ThemeStyle.None;
                    radialGauge1.Refresh();
                    break;
            }
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.comboBox4.Text == "Default")
                this.radialGauge1.NeedleStyle = NeedleStyle.Default;
            else if (this.comboBox4.Text == "Pointer")
                this.radialGauge1.NeedleStyle = NeedleStyle.Pointer;
            else
                this.radialGauge1.NeedleStyle = NeedleStyle.Advanced;
        }


        LinkLabel pickerParent = null;
        private void linkLabel6_Click(object sender, EventArgs e)
        {
            colorPickerUIAdv1.Visible = true;
            pickerParent = (sender as LinkLabel);
        }

        private void colorPickerUIAdv1_Picked(object sender, Syncfusion.Windows.Forms.Tools.ColorPickerUIAdv.ColorPickedEventArgs args)
        {
            switch (this.comboBox5.SelectedItem.ToString())
            {
                case "GaugeArcColor":
                    radialGauge1.GaugeArcColor = args.Color;
                    break;
                case "MajorTicksLineColor":
                    radialGauge1.MajorTickMarkColor = args.Color;
                    break;
                case "MinorTicksLineColor":
                    radialGauge1.MinorTickMarkColor = args.Color;
                    break;
                case "InnerTickLineColor":
                    radialGauge1.InterLinesColor = args.Color;
                    break;
                case "NeedleColor":
                    radialGauge1.NeedleColor = args.Color;
                    break;
                case "BackGroundStartColor":
                    radialGauge1.BackgroundGradientStartColor = args.Color;
                    break;
                case "BackGroundEndColor":
                    radialGauge1.BackgroundGradientEndColor = args.Color;
                    break;
                case "OuterFrameStartColor":
                    radialGauge1.OuterFrameGradientStartColor = args.Color;
                    break;
                case "OuterFrameEndColor":
                    radialGauge1.OuterFrameGradientEndColor = args.Color;
                    break;
                case "FrameBorderStartColor":
                    radialGauge1.InnerFrameGradientStartColor = args.Color;
                    break;
                case "FrameBorderEndColor":
                    radialGauge1.InnerFrameGradientEndColor = args.Color;
                    break;
            }
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            this.textBox1.ForeColor = Color.Black;
            this.textBox1.Text = string.Empty;
        }

        void textBox1_LostFocus(object sender, EventArgs e)
        {
            if (textBox1.Text == string.Empty)
            {
                this.textBox1.Text = "[Set Custom Label]";
                this.textBox1.ForeColor = Color.Gray;
            }
        }

        private void buttonAdv1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != string.Empty && textBox1.Text != "[Set Custom Label]")
                radialGauge1.GaugeLabel = textBox1.Text;
            else
                MessageBox.Show("Enter text to display as Gauge Label");
        }

        private void checkBoxAdv1_CheckedChanged(object sender, EventArgs e)
        {
            this.radialGauge1.ShowGaugeValue = this.checkBoxAdv1.Checked;
        }

        private void buttonAdv2_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "[Set Custom Label]";
            this.textBox1.ForeColor = Color.Gray;
            this.radialGauge1.GaugeLabel = "Gauge";
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            this.radialGauge1.Value = this.trackBar1.Value;
            radialGauge1.Invalidate();
        }
        #endregion

        #region For Ranges
        private void buttonAdv4_Click(object sender, EventArgs e)
        {
            this.pictureBox1.Visible = false;
            this.radialGauge1.Ranges.Clear();
            radialGauge1.Refresh();
        }

        private void buttonAdv6_Click(object sender, EventArgs e)
        {
            if (buttonAdv6.Text == "Cancel")
            {
                this.panel7.Visible = false;
                this.panel7.SendToBack();
            }
            else
            {
                panel7.Visible = false;
                groupBox5.Visible = false;
                buttonAdv5.Text = "Add";
                buttonAdv6.Text = "Cancel";
                ResetTextboxes();
            }
        }

        //ADD
        private void buttonAdv5_Click(object sender, EventArgs e)
        {
            int startValue = 0, endValue = 0, height = 0;
            if (buttonAdv5.Text == "Add")
            {
                if (int.TryParse(textBox2.Text, out startValue) && int.TryParse(textBox3.Text, out endValue) && int.TryParse(textBox4.Text, out height))
                {
                    this.panel7.Visible = false;
                    this.panel7.SendToBack();
                    Range newRange = new Range();
                    newRange.EndValue = endValue;
                    newRange.StartValue = startValue;
                    if (height < 93)
                    {
                        newRange.Height = height;
                        newRange.Color = colorPickerButton1.SelectedColor;
                        this.radialGauge1.Ranges.Add(newRange);
                        ResetTextboxes();
                        radialGauge1.Refresh();
                    }
                    else
                    {
                        MessageBox.Show("Enter a minimum value");
                    }
                }
                else
                {
                    if (MessageBox.Show("Please enter valid input parameters", "Invalid", MessageBoxButtons.YesNo) == DialogResult.No)
                    {
                        ResetTextboxes();
                    }
                }
            }
            else
            {
                buttonAdv5.Text = "Add";
                buttonAdv6.Text = "Cancel";
                if (existingRange != null)
                {
                    if (int.TryParse(textBox2.Text, out startValue) && int.TryParse(textBox3.Text, out endValue) && int.TryParse(textBox4.Text, out height))
                    {
                        existingRange.EndValue = endValue;
                        existingRange.StartValue = startValue;
                        if (height < 93)
                        {
                            existingRange.Height = height;
                            existingRange.Color = colorPickerButton1.SelectedColor;
                            ResetTextboxes();
                            radialGauge1.Refresh();
                            panel7.Visible = false;
                            groupBox5.Visible = false;
                        }
                        else
                        {
                            MessageBox.Show("Enter a minimum value");
                        }
                    }
                    else
                    {                       
                        if (MessageBox.Show("Invalid input parameters. Select Yes to retry or No to clear ranges while exit", "Invalid", MessageBoxButtons.YesNo) == DialogResult.No)
                        {
                            ResetTextboxes();
                        }
                    }
                }
            }
        }

        //Cancel
        private void buttonAdv3_Click(object sender, EventArgs e)
        {
            this.pictureBox1.Visible = false;
            this.panel7.Visible = true;
            this.panel7.BringToFront();
        }

        // Modify Ranges
        private void buttonAdv7_Click(object sender, EventArgs e)
        {
            groupBox5.Visible = true;
            flowLayoutPanel1.Controls.Clear();
            if (radialGauge1.Ranges.Count > 0)
            {
                this.pictureBox1.Visible = true;
                for (int i = 0; i < radialGauge1.Ranges.Count; i++)
                {
                    LinkLabel rLabel = new LinkLabel();
                    if (radialGauge1.Ranges[i].Name == "Alert Range"|| radialGauge1.Ranges[i].Name == "Normal range"||radialGauge1.Ranges[i].Name == "Check Range" )
                        rLabel.Text = radialGauge1.Ranges[i].Name;
                    else
                        rLabel.Text = "Range" + (i + 1);  
                    rLabel.Click += new EventHandler(rLabel_Click);
                    rLabel.Tag = radialGauge1.Ranges[i];
                    flowLayoutPanel1.Controls.Add(rLabel);
                }
            }
            else
            {
                MessageBox.Show("Currently no ranges found in RadialGauge");
                panel7.Visible = false;
                groupBox5.Visible = false;
                buttonAdv5.Text = "Add";
                buttonAdv6.Text = "Cancel";
                ResetTextboxes();
                this.pictureBox1.Visible = false;
            }
        }

        //Selected Range
        Range existingRange;
        void rLabel_Click(object sender, EventArgs e)
        {
            this.pictureBox1.Visible = false;
            groupBox5.Visible = false;
            panel7.Visible = true;
            panel7.BringToFront();
            buttonAdv5.Text = "Update";
            buttonAdv6.Text = "Ignore";
            
            if ((sender as LinkLabel).Tag != null && (sender as LinkLabel).Tag as Range != null)
            {
                existingRange = (sender as LinkLabel).Tag as Range;
                textBox2.Text = existingRange.StartValue.ToString();
                textBox3.Text = existingRange.EndValue.ToString();
                textBox4.Text = existingRange.Height.ToString();
                colorPickerButton1.SelectedColor = existingRange.Color;
                toolTip1.SetToolTip(colorPickerButton1, colorPickerButton1.Text);
            }
        }

        private void ResetTextboxes()
        {
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            colorPickerButton1.SelectedColor = Color.Empty;
            colorPickerButton1.Text = "Empty";
            toolTip1.SetToolTip(colorPickerButton1, colorPickerButton1.Text);
        }

        private void colorPickerButton1_ColorSelected(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(colorPickerButton1, colorPickerButton1.Text);
        }
        

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            panel7.Visible = false;
            groupBox5.Visible = false;
            buttonAdv5.Text = "Add";
            buttonAdv6.Text = "Cancel";
            ResetTextboxes();
            this.pictureBox1.Visible = false;
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            this.pictureBox1.Cursor = Cursors.Hand;
        }
        #endregion

    }
								/// <summary>
/// Represents a class that is used to find the licensing file for Syncfusion controls.
/// </summary>
public class DemoCommon
{

    /// <summary>
    /// Finds the license key from the Common folder.
    /// </summary>
    /// <returns>Returns the license key.</returns>
    public static string FindLicenseKey()
    {
        string licenseKeyFile = "..\\Common\\SyncfusionLicense.txt";
        for (int n = 0; n < 20; n++)
        {
            if (!System.IO.File.Exists(licenseKeyFile))
           {
                licenseKeyFile = @"..\" + licenseKeyFile;
                continue;
            }
            return File.ReadAllText(licenseKeyFile);
        }
        return string.Empty;
    }
}
}

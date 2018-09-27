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
using Syncfusion.Windows.Forms.Gauge;
using System.Runtime.InteropServices;
using System.IO;

namespace LinearGaugeDemo
{
    public partial class Form1 : MetroForm
    {
        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            comboBox5.SelectedIndex = 0;
            colorPickerButton1.SelectedColor = Color.Red;
            toolTip1.SetToolTip(colorPickerButton1, colorPickerButton1.Text);
            try
            {
                System.Drawing.Icon ico = new System.Drawing.Icon(GetIconFile(@"common\Images\Grid\Icon\sfgrid.ico"));
                this.Icon = ico;
            }
            catch { }
            this.textBox3.TextChanged += TextBox3_TextChanged;
            this.textBox2.TextChanged += TextBox2_TextChanged;
        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text.Contains("-"))
            {
               
                textBox2.Text = string.Empty;
                MessageBox.Show("Negative Values are not allowed");

            }
        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {
            if (textBox3.Text.Contains("-"))
            {
                
                textBox3.Text = string.Empty;
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


        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (this.comboBox3.Text)
            {
                case "Blue":
                    this.linearGauge1.VisualStyle = ThemeStyle.Blue;
                    linearGauge1.Refresh();
                    break;
                case "Black":
                    this.linearGauge1.VisualStyle = ThemeStyle.Black;
                    linearGauge1.Refresh();
                    break;
                case "Silver":
                    this.linearGauge1.VisualStyle = ThemeStyle.Silver;
                    linearGauge1.Refresh();
                    break;
                case "Metro":
                    this.linearGauge1.VisualStyle = ThemeStyle.Metro;
                    linearGauge1.Refresh();
                    break;
                case "Managed":
                    this.linearGauge1.VisualStyle = ThemeStyle.None;
                    this.linearGauge1.BackgroundGradientStartColor = ColorTranslator.FromHtml("#FFFFFF");
                    this.linearGauge1.BackgroundGradientEndColor = Color.FromArgb(255, 128, 0);
                    this.linearGauge1.OuterFrameGradientStartColor = Color.FromArgb(255, 128, 0);
                    this.linearGauge1.OuterFrameGradientEndColor = ColorTranslator.FromHtml("#843B04");
                    this.linearGauge1.InnerFrameGradientStartColor = ColorTranslator.FromHtml("#FFFFFF");
                    this.linearGauge1.InnerFrameGradientEndColor = Color.FromArgb(255, 128, 0);
                    this.linearGauge1.NeedleColor = Color.White;
                    this.linearGauge1.MajorTickMarkColor = Color.White;
                    this.linearGauge1.MinorTickMarkColor = Color.White;
                    this.linearGauge1.ScaleLabelColor = Color.Black;
                    linearGauge1.Refresh();
                    break;
                default:
                    this.linearGauge1.VisualStyle = ThemeStyle.None;
                    linearGauge1.Refresh();
                    break;
            }
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
                case "GaugeBaseColor":
                    linearGauge1.GaugeBaseColor = args.Color;
                    break;
                case "MajorTicksLineColor":
                    linearGauge1.MajorTickMarkColor = args.Color;
                    break;
                case "MinorTicksLineColor":
                    linearGauge1.MinorTickMarkColor = args.Color;
                    break;
                case "NeedleColor":
                    linearGauge1.NeedleColor = args.Color;
                    break;
                case "BackGroundStartColor":
                    linearGauge1.BackgroundGradientStartColor = args.Color;
                    break;
                case "BackGroundEndColor":
                    linearGauge1.BackgroundGradientEndColor = args.Color;
                    break;
                case "OuterFrameStartColor":
                    linearGauge1.OuterFrameGradientStartColor = args.Color;
                    break;
                case "OuterFrameEndColor":
                    linearGauge1.OuterFrameGradientEndColor = args.Color;
                    break;
                case "FrameBorderStartColor":
                    linearGauge1.InnerFrameGradientStartColor = args.Color;
                    break;
                case "FrameBorderEndColor":
                    linearGauge1.InnerFrameGradientEndColor = args.Color;
                    break;
            }
        }
        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            this.linearGauge1.Value = this.trackBar1.Value;
            linearGauge1.Invalidate();
        }
        #endregion

        #region For Ranges
        private void buttonAdv4_Click(object sender, EventArgs e)
        {
            this.linearGauge1.Ranges.Clear();
            linearGauge1.Refresh();
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
                if (int.TryParse(textBox2.Text, out startValue) && int.TryParse(textBox3.Text, out endValue))
                {
                    this.panel7.Visible = false;
                    this.panel7.SendToBack();
                    LinearRange newRange = new LinearRange();
                    newRange.EndValue = endValue;
                    newRange.StartValue = startValue;
                    newRange.Height = height;
                    newRange.Color = colorPickerButton1.SelectedColor;
                    this.linearGauge1.Ranges.Add(newRange);
                    ResetTextboxes();
                    linearGauge1.Refresh();
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
                        existingRange.Height = height;
                        existingRange.Color = colorPickerButton1.SelectedColor;
                        ResetTextboxes();
                        linearGauge1.Refresh();
                        panel7.Visible = false;
                        groupBox5.Visible = false;
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
            this.panel7.Visible = true;
            this.panel7.BringToFront();
        }

        // Modify Ranges
        private void buttonAdv7_Click(object sender, EventArgs e)
        {
            groupBox5.Visible = true;
            flowLayoutPanel1.Controls.Clear();
            if (linearGauge1.Ranges.Count > 0)
            {
                for (int i = 0; i < linearGauge1.Ranges.Count; i++)
                {
                    LinkLabel rLabel = new LinkLabel();
                    rLabel.Text = linearGauge1.Ranges[i].Name;
                    rLabel.Click += new EventHandler(rLabel_Click);
                    rLabel.Tag = linearGauge1.Ranges[i];
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
            }
        }

        //Selected Range
        Range existingRange;
        void rLabel_Click(object sender, EventArgs e)
        {
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
        #endregion

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    this.linearGauge1.LinearFrameType = LinearFrameType.Horizontal;
                    this.linearGauge1.Size = new Size(300, 125);
                    break;
                case 1:
                    this.linearGauge1.LinearFrameType = LinearFrameType.Vertical;
                    this.linearGauge1.Size = new Size(125, 300);
                    break;
            }
        }

        #region Resize Behavior

        [DllImport("user32.dll")]
        static extern bool LockWindowUpdate(IntPtr hWndLock);


        private bool isLocked;
        private Size currentSize;

        private void LockWindow()
        {
            if (!isLocked)
            {
                isLocked = true;
                LockWindowUpdate(this.Handle);
            }
        }

        private void UnlockWindow()
        {
            if (isLocked)
            {
                isLocked = false;
                LockWindowUpdate(IntPtr.Zero);
            }
            this.Update();
        }

        private bool IsResized()
        {
            if (currentSize.IsEmpty)
            {
                return false;
            }
            else
            {
                return this.Size != currentSize;
            }
        }

        protected override void OnResizeBegin(EventArgs e)
        {
            currentSize = this.Size;
            base.OnResizeBegin(e);
        }

        protected override void OnResizeEnd(EventArgs e)
        {
            base.OnResizeEnd(e);
            currentSize = this.Size;
            this.UnlockWindow();
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);

            if (this.WindowState == FormWindowState.Normal)
            {
                if (isLocked || IsResized())
                {
                    currentSize = this.Size;
                    UnlockWindow();
                    LockWindow();
                }
            }
        }


        protected override void OnMove(EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal && IsResized() && !isLocked)
            {
                LockWindow();
            }

            base.OnMove(e);
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

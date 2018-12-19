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

namespace DigitalGaugeDemo
{
    public partial class Form1 : MetroForm
    {
        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            comboBox5.SelectedIndex = 0;
            this.comboBoxAdv1.SelectedIndex = 0;
            this.comboBox3.SelectedIndex = 1;
            try
            {
                System.Drawing.Icon ico = new System.Drawing.Icon(GetIconFile(@"common\Images\Grid\Icon\sfgrid.ico"));
                this.Icon = ico;
            }
            catch { }
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
                    this.digitalGauge1.VisualStyle = ThemeStyle.Blue;
                    digitalGauge1.Refresh();
                    break;
                case "Black":
                    this.digitalGauge1.VisualStyle = ThemeStyle.Black;
                    digitalGauge1.Refresh();
                    break;
                case "Silver":
                    this.digitalGauge1.VisualStyle = ThemeStyle.Silver;
                    digitalGauge1.Refresh();
                    break;
                case "Metro":
                    this.digitalGauge1.VisualStyle = ThemeStyle.Metro;
                    digitalGauge1.Refresh();
                    break;
                case "Managed":
                    this.digitalGauge1.VisualStyle = ThemeStyle.None;
                    this.digitalGauge1.BackgroundGradientStartColor = ColorTranslator.FromHtml("#FFFFFF");
                    this.digitalGauge1.BackgroundGradientEndColor = Color.FromArgb(255, 128, 0);
                    this.digitalGauge1.OuterFrameGradientStartColor = Color.FromArgb(255, 128, 0);
                    this.digitalGauge1.OuterFrameGradientEndColor = ColorTranslator.FromHtml("#843B04");
                    digitalGauge1.Refresh();
                    break;
                default:
                    this.digitalGauge1.VisualStyle = ThemeStyle.None;
                    digitalGauge1.Refresh();
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
                case "ForeColor":
                    digitalGauge1.ForeColor = args.Color;
                    break;
                case "BackGroundStartColor":
                    digitalGauge1.BackgroundGradientStartColor = args.Color;
                    break;
                case "BackGroundEndColor":
                    digitalGauge1.BackgroundGradientEndColor = args.Color;
                    break;
                case "OuterFrameStartColor":
                    digitalGauge1.OuterFrameGradientStartColor = args.Color;
                    break;
                case "OuterFrameEndColor":
                    digitalGauge1.OuterFrameGradientEndColor = args.Color;
                    break;
                case "FrameBorderColor":
                    digitalGauge1.FrameBorderColor = args.Color;
                    break;
            }
        }

        #endregion

        private void comboBoxAdv1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(comboBoxAdv1.SelectedIndex)
            {
                case 0:
                    this.digitalGauge1.CharacterType = CharacterType.SevenSegment;
                    break;
                case 1:
                    this.digitalGauge1.CharacterType = CharacterType.FourteenSegment;
                    break;
                case 2:
                    this.digitalGauge1.CharacterType = CharacterType.SixteenSegment;
                    break;
                case 3:
                    this.digitalGauge1.CharacterType = CharacterType.DotMatrixSegment;
                    break;
            }
        }

        private void textBoxExt1_TextChanged(object sender, EventArgs e)
        {
            if (this.integerTextBox1.Text != "")
                this.digitalGauge1.CharacterCount = Int32.Parse( this.integerTextBox1.IntegerValue.ToString());
        }

        private void textBoxExt2_TextChanged(object sender, EventArgs e)
        {
            this.digitalGauge1.Value = this.textBoxExt2.Text;
        }

        private void checkBoxAdv1_CheckStateChanged(object sender, EventArgs e)
        {
            this.digitalGauge1.ShowInvisibleSegments = this.checkBoxAdv1.Checked;
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

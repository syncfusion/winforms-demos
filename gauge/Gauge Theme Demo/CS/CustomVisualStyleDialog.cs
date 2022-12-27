#region Copyright Syncfusion Inc. 2001-2019.
// Copyright Syncfusion Inc. 2001-2019. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Syncfusion.Windows.Forms.Gauge;
using Syncfusion.WinForms.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GaugeTheme_2010
{
    public partial class CustomVisualStyleDialog : SfForm
    {
        public Form1 Mainform = null;
        bool isupdate;
        List<string> BrushNames = new List<string>();
        internal Dictionary<string, Color> previousColors = new Dictionary<string, Color>();
        RadialGaugeThemeBrush RadialBrush = new RadialGaugeThemeBrush();
        LinearGaugeThemeBrush LinearBrush = new LinearGaugeThemeBrush();
        DigitalGaugeThemeBrush DigitalBrush = new DigitalGaugeThemeBrush();
        public CustomVisualStyleDialog(Form1 form)
        {
            Mainform = form;
            InitializeComponent();
            BrushNames.Add("BackgroundColor");
            BrushNames.Add("OuterFrameBackgroundColor");
            BrushNames.Add("InnerFrameBackgroundColor");
            BrushNames.Add("ArcColor");
            BrushNames.Add("MinorTickMarkColor");
            BrushNames.Add("MajorTickMarkColor");
            BrushNames.Add("InterLinesColor");
            BrushNames.Add("ScaleLabelColor");
            BrushNames.Add("NeedlePointerColor");
            BrushNames.Add("GaugeLabelColor");
            BrushNames.Add("GaugeValueColor");
            for (int i = 0; i < 11; i++)
            {
                ThemeChoiceControl themeChoiceControl = new ThemeChoiceControl();
                themeChoiceControl.Padding = new System.Windows.Forms.Padding(themeChoiceControl.Padding.Left, themeChoiceControl.Padding.Top, themeChoiceControl.Padding.Right, themeChoiceControl.Padding.Bottom);
                themeChoiceControl.ColorPicker.Picked += ColorPicker_Picked;
                themeChoiceControl.BrushName.Text = BrushNames[i];
                if (themeChoiceControl.BrushName.Text == "BackgroundColor")
                {
                    if (Mainform.RestoreColors.Keys.Contains<string>("BackgroundColor"))
                    {
                        UpdateColors(themeChoiceControl, "BackgroundColor");
                    }
                    else
                    {
                        themeChoiceControl.buttonEdit1.Text = "#FFFFFF";
                    }
                    
                }
                else if (themeChoiceControl.BrushName.Text == "OuterFrameBackgroundColor")
                {
                    if (Mainform.RestoreColors.Keys.Contains<string>("OuterFrameBackgroundColor"))
                    {
                        UpdateColors(themeChoiceControl, "OuterFrameBackgroundColor");
                    }
                    else
                    {
                        themeChoiceControl.buttonEdit1.Text = "#c5c5c5";
                    }
                }
                else if (themeChoiceControl.BrushName.Text == "InnerFrameBackgroundColor")
                {
                    if (Mainform.RestoreColors.Keys.Contains<string>("InnerFrameBackgroundColor"))
                    {
                        UpdateColors(themeChoiceControl, "InnerFrameBackgroundColor");
                    }
                    else
                    {
                        themeChoiceControl.buttonEdit1.Text = "#FFFFFF";
                    }
                }
                else if (themeChoiceControl.BrushName.Text == "ArcColor")
                {
                    if (Mainform.RestoreColors.Keys.Contains<string>("ArcColor"))
                    {
                        UpdateColors(themeChoiceControl, "ArcColor");
                    }
                    else
                    {
                        themeChoiceControl.buttonEdit1.Text = "#b5b5b5";
                    }
                }
                else if (themeChoiceControl.BrushName.Text == "MinorTickMarkColor")
                {
                    if (Mainform.RestoreColors.Keys.Contains<string>("MinorTickMarkColor"))
                    {
                        UpdateColors(themeChoiceControl, "MinorTickMarkColor");
                    }
                    else
                    {
                        themeChoiceControl.buttonEdit1.Text = "#b5b5b5";
                    }
                }
                else if (themeChoiceControl.BrushName.Text == "MajorTickMarkColor")
                {
                    if (Mainform.RestoreColors.Keys.Contains<string>("MajorTickMarkColor"))
                    {
                        UpdateColors(themeChoiceControl, "MajorTickMarkColor");
                    }
                    else
                    {
                        themeChoiceControl.buttonEdit1.Text = "#3d3d3d";
                    }
                }
                else if (themeChoiceControl.BrushName.Text == "InterLinesColor")
                {
                    if (Mainform.RestoreColors.Keys.Contains<string>("InterLinesColor"))
                    {
                        UpdateColors(themeChoiceControl, "InterLinesColor");
                    }
                    else
                    {
                        themeChoiceControl.buttonEdit1.Text = "#3d3d3d";
                    }
                }
                else if (themeChoiceControl.BrushName.Text == "NeedlePointerColor")
                {
                    if (Mainform.RestoreColors.Keys.Contains<string>("NeedlePointerColor"))
                    {
                        UpdateColors(themeChoiceControl, "NeedlePointerColor");
                    }
                    else
                    {
                        themeChoiceControl.buttonEdit1.Text = "#0173c7";
                    }
                }
                else if (themeChoiceControl.BrushName.Text == "ScaleLabelColor")
                {
                    if (Mainform.RestoreColors.Keys.Contains<string>("ScaleLabelColor"))
                    {
                        UpdateColors(themeChoiceControl, "ScaleLabelColor");
                    }
                    else
                    {
                        themeChoiceControl.buttonEdit1.Text = "#5e5e5e";
                    }
                }
                else if (themeChoiceControl.BrushName.Text == "GaugeLabelColor")
                {
                    if (Mainform.RestoreColors.Keys.Contains<string>("GaugeLabelColor"))
                    {
                        UpdateColors(themeChoiceControl, "GaugeLabelColor");
                    }
                    else
                    {
                        themeChoiceControl.buttonEdit1.Text = "#5e5e5e";
                    }
                }
                else if (themeChoiceControl.BrushName.Text == "GaugeValueColor")
                {
                    if (Mainform.RestoreColors.Keys.Contains<string>("GaugeValueColor"))
                    {
                        UpdateColors(themeChoiceControl, "GaugeValueColor");
                    }
                    else
                    {
                        themeChoiceControl.buttonEdit1.Text = "#5e5e5e";
                    }
                }
                if (themeChoiceControl.buttonEdit1.Text == "#FFFFFF")
                    themeChoiceControl.buttonEditChildButton1.MetroColor = Color.Wheat;
                else
                    themeChoiceControl.buttonEditChildButton1.MetroColor = ColorTranslator.FromHtml(themeChoiceControl.buttonEdit1.Text);
                this.flowLayoutPanel1.Controls.Add(themeChoiceControl);
                previousColors.Add(themeChoiceControl.BrushName.Text, themeChoiceControl.buttonEditChildButton1.MetroColor);

            }
            this.FormClosing += Form2_FormClosing;
            this.StartPosition = FormStartPosition.CenterParent;
            try
            {
                System.Drawing.Icon ico = new System.Drawing.Icon(GetIconFile(@"common\Images\Grid\Icon\sfgrid1.ico"));
                this.Icon = ico;
            }
            catch { }
        }

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

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!isupdate)
            {
               foreach(KeyValuePair<string, Color> value in this.previousColors)
                {
                    if (Mainform.RestoreColors.Keys.Contains<string>(value.Key))
                    {
                        Mainform.RestoreColors.Remove(value.Key);
                        Mainform.RestoreColors.Add(value.Key, value.Value);
                    }
                }
            }
        }

        private void ColorPicker_Picked(object sender, Syncfusion.Windows.Forms.Tools.ColorPickerUIAdv.ColorPickedEventArgs args)
        {
            if (sender is SyncfColorPicker)
            {
                if ((sender as SyncfColorPicker).ParentControl != null)
                {
                    if ((sender as SyncfColorPicker).ParentControl is ThemeChoiceControl)
                    {
                        if (((sender as SyncfColorPicker).ParentControl as ThemeChoiceControl).BrushName.Text == "BackgroundColor")
                        {
                            RadialBrush.BackgroundGradientStartColor = args.Color;
                            RadialBrush.BackgroundGradientEndColor = args.Color;
                            LinearBrush.BackgroundGradientStartColor = args.Color;
                            LinearBrush.BackgroundGradientEndColor = args.Color;
                            DigitalBrush.BackgroundGradientStartColor = args.Color;
                            DigitalBrush.BackgroundGradientEndColor = args.Color;
                            ValidateColors(Mainform.RestoreColors, "BackgroundColor");
                            Mainform.RestoreColors.Add("BackgroundColor" ,args.Color);
                        }
                        else if (((sender as SyncfColorPicker).ParentControl as ThemeChoiceControl).BrushName.Text == "OuterFrameBackgroundColor")
                        {
                            RadialBrush.OuterFrameGradientStartColor = args.Color;
                            RadialBrush.OuterFrameGradientEndColor = args.Color;
                            LinearBrush.OuterFrameGradientStartColor = args.Color;
                            LinearBrush.OuterFrameGradientEndColor = args.Color;
                            DigitalBrush.OuterFrameGradientStartColor = args.Color;
                            DigitalBrush.OuterFrameGradientEndColor = args.Color;
                            ValidateColors(Mainform.RestoreColors, "OuterFrameBackgroundColor");
                            Mainform.RestoreColors.Add("OuterFrameBackgroundColor" , args.Color);
                        }
                        else if (((sender as SyncfColorPicker).ParentControl as ThemeChoiceControl).BrushName.Text == "InnerFrameBackgroundColor")
                        {
                            RadialBrush.InnerFrameGradientStartColor = args.Color;
                            RadialBrush.InnerFrameGradientEndColor = args.Color;
                            LinearBrush.InnerFrameGradientStartColor = args.Color;
                            LinearBrush.InnerFrameGradientEndColor = args.Color;
                            DigitalBrush.FrameBorderColor = args.Color;
                            ValidateColors(Mainform.RestoreColors, "InnerFrameBackgroundColor");
                            Mainform.RestoreColors.Add("InnerFrameBackgroundColor" , args.Color);
                        }
                        else if (((sender as SyncfColorPicker).ParentControl as ThemeChoiceControl).BrushName.Text == "ArcColor")
                        {
                            RadialBrush.ArcColor = args.Color;
                            ValidateColors(Mainform.RestoreColors, "ArcColor");
                            Mainform.RestoreColors.Add("ArcColor" , args.Color);
                        }
                        else if (((sender as SyncfColorPicker).ParentControl as ThemeChoiceControl).BrushName.Text == "MinorTickMarkColor")
                        {
                            RadialBrush.MinorTickMarkColor = args.Color;
                            LinearBrush.MinorTickMarkColor = args.Color;
                            ValidateColors(Mainform.RestoreColors, "MinorTickMarkColor");
                            Mainform.RestoreColors.Add("MinorTickMarkColor" ,args.Color);
                        }
                        else if (((sender as SyncfColorPicker).ParentControl as ThemeChoiceControl).BrushName.Text == "MajorTickMarkColor")
                        {
                            RadialBrush.MajorTickMarkColor = args.Color;
                            LinearBrush.MajorTickMarkColor = args.Color;
                            ValidateColors(Mainform.RestoreColors, "MajorTickMarkColor");
                            Mainform.RestoreColors.Add("MajorTickMarkColor" , args.Color);
                        }
                        else if (((sender as SyncfColorPicker).ParentControl as ThemeChoiceControl).BrushName.Text == "InterLinesColor")
                        {
                            RadialBrush.InterLinesColor = args.Color;
                            LinearBrush.ScaleColor = args.Color;
                            ValidateColors(Mainform.RestoreColors, "InterLinesColor");
                            Mainform.RestoreColors.Add("InterLinesColor" , args.Color);
                        }
                        else if (((sender as SyncfColorPicker).ParentControl as ThemeChoiceControl).BrushName.Text == "ScaleLabelColor")
                        {
                            RadialBrush.ScaleLabelColor = args.Color;
                            LinearBrush.ScaleLabelColor = args.Color;
                            DigitalBrush.ForeColor = args.Color;
                            ValidateColors(Mainform.RestoreColors, "ScaleLabelColor");
                            Mainform.RestoreColors.Add("ScaleLabelColor" , args.Color);
                        }
                        else if (((sender as SyncfColorPicker).ParentControl as ThemeChoiceControl).BrushName.Text == "NeedlePointerColor")
                        {
                            RadialBrush.NeedleColor = args.Color;
                            LinearBrush.NeedleColor = args.Color;
                            ValidateColors(Mainform.RestoreColors, "NeedlePointerColor");
                            Mainform.RestoreColors.Add("NeedlePointerColor" , args.Color);
                        }
                        else if (((sender as SyncfColorPicker).ParentControl as ThemeChoiceControl).BrushName.Text == "GaugeLabelColor")
                        {
                            RadialBrush.LabelColor = args.Color;
                            ValidateColors(Mainform.RestoreColors, "GaugeLabelColor");
                            Mainform.RestoreColors.Add("GaugeLabelColor" ,args.Color);
                        }
                        else if (((sender as SyncfColorPicker).ParentControl as ThemeChoiceControl).BrushName.Text == "GaugeValueColor")
                        {
                            RadialBrush.ValueColor = args.Color;
                            ValidateColors(Mainform.RestoreColors, "GaugeValueColor");
                            Mainform.RestoreColors.Add("GaugeValueColor" , args.Color);
                        }
                      
                    }
                }
            }
        }

        private void UpdateColors_Click(object sender, EventArgs e)
        {
            Mainform.radialGauge1.ThemeBrush.Clear();
            Mainform.digitalGauge1.ThemeBrush.Clear();
            Mainform.linearGauge1.ThemeBrush.Clear();
            Mainform.radialGauge1.ThemeBrush.Add(RadialBrush);
            Mainform.linearGauge1.ThemeBrush.Add(LinearBrush);
            Mainform.digitalGauge1.ThemeBrush.Add(DigitalBrush);
            Mainform.radialGauge1.Invalidate();
            Mainform.linearGauge1.Invalidate();
            Mainform.digitalGauge1.Invalidate();
            Mainform.LinearGaugePanel.Invalidate();
            Mainform.DigitalGaugePanel.Invalidate();
            Mainform.RadialGaugePanel.Invalidate();
            isupdate = true;
            previousColors.Clear();
            foreach (ThemeChoiceControl control in this.flowLayoutPanel1.Controls)
            {
                previousColors.Add(control.BrushName.Text, control.buttonEditChildButton1.MetroColor);
            }
            this.Close();
        }

        void ValidateColors(Dictionary<string, Color> list, string remove)
        {
           foreach(KeyValuePair<string,Color> key in list)
            {
                if (key.Key.Equals(remove))
                {
                    list.Remove(key.Key);
                    break;
                }
            }
        }
        void UpdateColors(ThemeChoiceControl themeChoiceControl, string text)
        {
            if (Mainform.RestoreColors.Count > 0)
            {
                foreach (KeyValuePair<string, Color> colors in Mainform.RestoreColors)
                {
                    if (colors.Key == text)
                    {
                        themeChoiceControl.buttonEdit1.Text = ColorTranslator.ToHtml(colors.Value); ;
                        themeChoiceControl.buttonEditChildButton1.MetroColor = colors.Value;
                    }
                }
            }
        }
    }
}

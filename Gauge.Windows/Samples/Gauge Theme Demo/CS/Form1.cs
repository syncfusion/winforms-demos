#region Copyright Syncfusion Inc. 2001-2017.
// Copyright Syncfusion Inc. 2001-2017. All rights reserved.
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
using System.Runtime.InteropServices;
using Syncfusion.Windows.Forms.Gauge;
using System.IO;

namespace GaugeTheme_2010
{
    public partial class Form1 : MetroForm
    {
        List<string> BrushNames = new List<string>();
        RadialGaugeThemeBrush RadialBrush  = new RadialGaugeThemeBrush();
        LinearGaugeThemeBrush LinearBrush  = new LinearGaugeThemeBrush();
        DigitalGaugeThemeBrush DigitalBrush = new DigitalGaugeThemeBrush();
        public Form1()
        {
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
                    themeChoiceControl.buttonEdit1.Text = "#FFFFFF";
                }
                else if (themeChoiceControl.BrushName.Text == "OuterFrameBackgroundColor")
                {
                    themeChoiceControl.buttonEdit1.Text = "#c5c5c5";
                }
                else if (themeChoiceControl.BrushName.Text == "InnerFrameBackgroundColor")
                {
                    themeChoiceControl.buttonEdit1.Text = "#FFFFFF";
                }
                else if (themeChoiceControl.BrushName.Text == "ArcColor")
                {
                    themeChoiceControl.buttonEdit1.Text = "#b5b5b5";
                }
                else if (themeChoiceControl.BrushName.Text == "ArcColor")
                {
                    themeChoiceControl.buttonEdit1.Text = "#b5b5b5";
                }
                else if (themeChoiceControl.BrushName.Text == "MinorTickMarkColor")
                {
                    themeChoiceControl.buttonEdit1.Text = "#b5b5b5";
                }
                else if (themeChoiceControl.BrushName.Text == "MajorTickMarkColor")
                {
                    themeChoiceControl.buttonEdit1.Text = "#3d3d3d";
                }
                else if (themeChoiceControl.BrushName.Text == "InterLinesColor")
                {
                    themeChoiceControl.buttonEdit1.Text = "#3d3d3d";
                }
                else if (themeChoiceControl.BrushName.Text == "NeedlePointerColor")
                {
                    themeChoiceControl.buttonEdit1.Text = "#0173c7";
                }
                else if (themeChoiceControl.BrushName.Text == "ScaleLabelColor")
                {
                    themeChoiceControl.buttonEdit1.Text = "#5e5e5e";
                }
                else if (themeChoiceControl.BrushName.Text == "GaugeLabelColor")
                {
                    themeChoiceControl.buttonEdit1.Text = "#5e5e5e";
                }
                else if (themeChoiceControl.BrushName.Text == "GaugeValueColor")
                {
                    themeChoiceControl.buttonEdit1.Text = "#5e5e5e";
                }
                if (themeChoiceControl.buttonEdit1.Text == "#FFFFFF")
                    themeChoiceControl.buttonEditChildButton1.MetroColor = Color.Wheat;
                else
                    themeChoiceControl.buttonEditChildButton1.MetroColor = ColorTranslator.FromHtml(themeChoiceControl.buttonEdit1.Text);
                this.flowLayoutPanel1.Controls.Add(themeChoiceControl);
            }
            this.comboBoxAdv1.DropDownButton.MetroArrowColor = Color.Black;
            this.radialGauge1.ReadOnly = false;
            this.linearGauge1.ReadOnly = false;
            this.flowLayoutPanel1.BackColor = ColorTranslator.FromHtml("#f5f5f5");
            this.radialGauge1.VisualStyle = Syncfusion.Windows.Forms.Gauge.ThemeStyle.Office2016Colorful;
            this.digitalGauge1.VisualStyle = Syncfusion.Windows.Forms.Gauge.ThemeStyle.Office2016Colorful;
            this.linearGauge1.VisualStyle = Syncfusion.Windows.Forms.Gauge.ThemeStyle.Office2016Colorful;
            this.radialGauge1.Value = 25;
            this.digitalGauge1.Value = "1234";
            this.linearGauge1.Value = 25;
            this.comboBoxAdv1.SelectedIndexChanged += ComboBoxAdv1_SelectedIndexChanged;
            this.RadialGaugePanel.SizeChanged += new EventHandler(RadialGaugePanel_SizeChanged);
            this.LinearGaugePanel.SizeChanged += new EventHandler(LinearGaugePanel_SizeChanged);
            this.DigitalGaugePanel.SizeChanged += new EventHandler(DigitalGaugePanel_SizeChanged);
            this.RadialGaugePanel.Paint += new PaintEventHandler(RadialGaugePanel_Paint);
            this.LinearGaugePanel.Paint += new PaintEventHandler(LinearGaugePanel_Paint);
            this.radialGauge1.MinorDifference = 10;
        }

        void LinearGaugePanel_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            e.Graphics.FillRectangle(new SolidBrush(Color.LightGray), new Rectangle(this.LinearGaugePanel.DisplayRectangle.X, (this.LinearGaugePanel.DisplayRectangle.Y + this.LinearGaugePanel.DisplayRectangle.Height - 2),
                this.LinearGaugePanel.DisplayRectangle.Width, this.LinearGaugePanel.DisplayRectangle.Height- 2));
        }

        void RadialGaugePanel_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            e.Graphics.FillRectangle(new SolidBrush(Color.LightGray), new Rectangle(this.DigitalGaugePanel.DisplayRectangle.X + this.DigitalGaugePanel.DisplayRectangle.Width - 3, this.DigitalGaugePanel.DisplayRectangle.Y, 2, (this.DigitalGaugePanel.DisplayRectangle.Height * 2)));
        }

        void DigitalGaugePanel_SizeChanged(object sender, EventArgs e)
        {
            this.digitalGauge1.Left = (this.DigitalGaugePanel.Width - this.digitalGauge1.Width) / 2;
            this.digitalGauge1.Top = (this.DigitalGaugePanel.Height - this.digitalGauge1.Height) / 2;
        }

        void LinearGaugePanel_SizeChanged(object sender, EventArgs e)
        {
            this.linearGauge1.Left = (this.LinearGaugePanel.Width - this.linearGauge1.Width) / 2;
            this.linearGauge1.Top = (this.LinearGaugePanel.Height - this.linearGauge1.Height) / 2;
        }

        void RadialGaugePanel_SizeChanged(object sender, EventArgs e)
        {
            this.radialGauge1.Left = (this.RadialGaugePanel.Width - this.radialGauge1.Width) / 2;
            this.radialGauge1.Top = (this.RadialGaugePanel.Height - this.radialGauge1.Height) / 2;
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
                        }
                        else if (((sender as SyncfColorPicker).ParentControl as ThemeChoiceControl).BrushName.Text == "OuterFrameBackgroundColor")
                        {
                            RadialBrush.OuterFrameGradientStartColor = args.Color;
                            RadialBrush.OuterFrameGradientEndColor = args.Color;
                            LinearBrush.OuterFrameGradientStartColor = args.Color;
                            LinearBrush.OuterFrameGradientEndColor = args.Color;
                            DigitalBrush.OuterFrameGradientStartColor = args.Color;
                            DigitalBrush.OuterFrameGradientEndColor = args.Color;
                        }
                        else if (((sender as SyncfColorPicker).ParentControl as ThemeChoiceControl).BrushName.Text == "InnerFrameBackgroundColor")
                        {
                            RadialBrush.InnerFrameGradientStartColor = args.Color;
                            RadialBrush.InnerFrameGradientEndColor = args.Color;
                            LinearBrush.InnerFrameGradientStartColor = args.Color;
                            LinearBrush.InnerFrameGradientEndColor = args.Color;
                            DigitalBrush.FrameBorderColor = args.Color;
                        }
                        else if (((sender as SyncfColorPicker).ParentControl as ThemeChoiceControl).BrushName.Text == "ArcColor")
                        {
                            RadialBrush.ArcColor = args.Color;
                        }
                        else if (((sender as SyncfColorPicker).ParentControl as ThemeChoiceControl).BrushName.Text == "MinorTickMarkColor")
                        {
                            RadialBrush.MinorTickMarkColor = args.Color;
                            LinearBrush.MinorTickMarkColor = args.Color;
                        }
                        else if (((sender as SyncfColorPicker).ParentControl as ThemeChoiceControl).BrushName.Text == "MajorTickMarkColor")
                        {
                            RadialBrush.MajorTickMarkColor = args.Color;
                            LinearBrush.MajorTickMarkColor = args.Color;
                        }
                        else if (((sender as SyncfColorPicker).ParentControl as ThemeChoiceControl).BrushName.Text == "InterLinesColor")
                        {
                            RadialBrush.InterLinesColor = args.Color;
                            LinearBrush.ScaleColor = args.Color;
                        }
                        else if (((sender as SyncfColorPicker).ParentControl as ThemeChoiceControl).BrushName.Text == "ScaleLabelColor")
                        {
                            RadialBrush.ScaleLabelColor = args.Color;
                            LinearBrush.ScaleLabelColor = args.Color;
                            DigitalBrush.ForeColor = args.Color;
                        }
                        else if (((sender as SyncfColorPicker).ParentControl as ThemeChoiceControl).BrushName.Text == "NeedlePointerColor")
                        {
                            RadialBrush.NeedleColor = args.Color;
                            LinearBrush.NeedleColor = args.Color;
                        }
                        else if (((sender as SyncfColorPicker).ParentControl as ThemeChoiceControl).BrushName.Text == "GaugeLabelColor")
                        {
                            RadialBrush.LabelColor = args.Color;
                        }
                        else if (((sender as SyncfColorPicker).ParentControl as ThemeChoiceControl).BrushName.Text == "GaugeValueColor")
                        {
                            RadialBrush.ValueColor = args.Color;
                        }
                        this.radialGauge1.ThemeBrush.Clear();
                        this.digitalGauge1.ThemeBrush.Clear();
                        this.linearGauge1.ThemeBrush.Clear();
                        this.radialGauge1.ThemeBrush.Add(RadialBrush);
                        this.linearGauge1.ThemeBrush.Add(LinearBrush);
                        this.digitalGauge1.ThemeBrush.Add(DigitalBrush);
                        this.radialGauge1.Invalidate();
                        this.linearGauge1.Invalidate();
                        this.digitalGauge1.Invalidate();
                        this.LinearGaugePanel.Invalidate();
                        this.DigitalGaugePanel.Invalidate();
                        this.RadialGaugePanel.Invalidate();
                    }
                }
            }
        }

        private void ComboBoxAdv1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.comboBoxAdv1.SelectedItem.ToString() == "Office2016Colorful")
            {
                this.radialGauge1.VisualStyle = Syncfusion.Windows.Forms.Gauge.ThemeStyle.Office2016Colorful;
                this.digitalGauge1.VisualStyle = Syncfusion.Windows.Forms.Gauge.ThemeStyle.Office2016Colorful;
                this.linearGauge1.VisualStyle = Syncfusion.Windows.Forms.Gauge.ThemeStyle.Office2016Colorful;
            }
            else if (this.comboBoxAdv1.SelectedItem.ToString() == "Office2016White")
            {
                this.radialGauge1.VisualStyle = Syncfusion.Windows.Forms.Gauge.ThemeStyle.Office2016White;
                this.digitalGauge1.VisualStyle = Syncfusion.Windows.Forms.Gauge.ThemeStyle.Office2016White;
                this.linearGauge1.VisualStyle = Syncfusion.Windows.Forms.Gauge.ThemeStyle.Office2016White;
            }
            else if (this.comboBoxAdv1.SelectedItem.ToString() == "Office2016DarkGray")
            {
                this.radialGauge1.VisualStyle = Syncfusion.Windows.Forms.Gauge.ThemeStyle.Office2016DarkGray;
                this.digitalGauge1.VisualStyle = Syncfusion.Windows.Forms.Gauge.ThemeStyle.Office2016DarkGray;
                this.linearGauge1.VisualStyle = Syncfusion.Windows.Forms.Gauge.ThemeStyle.Office2016DarkGray;
            }
            else if (this.comboBoxAdv1.SelectedItem.ToString() == "Office2016Black")
            {
                this.radialGauge1.VisualStyle = Syncfusion.Windows.Forms.Gauge.ThemeStyle.Office2016Black;
                this.digitalGauge1.VisualStyle = Syncfusion.Windows.Forms.Gauge.ThemeStyle.Office2016Black;
                this.linearGauge1.VisualStyle = Syncfusion.Windows.Forms.Gauge.ThemeStyle.Office2016Black;
            }
            else if (this.comboBoxAdv1.SelectedItem.ToString() == "Metro")
            {
                this.radialGauge1.VisualStyle = Syncfusion.Windows.Forms.Gauge.ThemeStyle.Metro;
                this.digitalGauge1.VisualStyle = Syncfusion.Windows.Forms.Gauge.ThemeStyle.Metro;
                this.linearGauge1.VisualStyle = Syncfusion.Windows.Forms.Gauge.ThemeStyle.Metro;
            }
            else if (this.comboBoxAdv1.SelectedItem.ToString() == "Blue")
            {
                this.radialGauge1.VisualStyle = Syncfusion.Windows.Forms.Gauge.ThemeStyle.Blue;
                this.digitalGauge1.VisualStyle = Syncfusion.Windows.Forms.Gauge.ThemeStyle.Blue;
                this.linearGauge1.VisualStyle = Syncfusion.Windows.Forms.Gauge.ThemeStyle.Blue;
            }
            else if (this.comboBoxAdv1.SelectedItem.ToString() == "Black")
            {
                this.radialGauge1.VisualStyle = Syncfusion.Windows.Forms.Gauge.ThemeStyle.Black;
                this.digitalGauge1.VisualStyle = Syncfusion.Windows.Forms.Gauge.ThemeStyle.Black;
                this.linearGauge1.VisualStyle = Syncfusion.Windows.Forms.Gauge.ThemeStyle.Black;
            }
            else if (this.comboBoxAdv1.SelectedItem.ToString() == "Silver")
            {
                this.radialGauge1.VisualStyle = Syncfusion.Windows.Forms.Gauge.ThemeStyle.Silver;
                this.digitalGauge1.VisualStyle = Syncfusion.Windows.Forms.Gauge.ThemeStyle.Silver;
                this.linearGauge1.VisualStyle = Syncfusion.Windows.Forms.Gauge.ThemeStyle.Silver;
            }
            else if (this.comboBoxAdv1.SelectedItem.ToString() == "Custom")
            {
                this.radialGauge1.VisualStyle = Syncfusion.Windows.Forms.Gauge.ThemeStyle.Custom;
                this.digitalGauge1.VisualStyle = Syncfusion.Windows.Forms.Gauge.ThemeStyle.Custom;
                this.linearGauge1.VisualStyle = Syncfusion.Windows.Forms.Gauge.ThemeStyle.Custom;
            }
            UpdateRadialGaugeCustomTheme();
            this.radialGauge1.Refresh();
            this.digitalGauge1.Refresh();
            this.linearGauge1.Refresh();
        }

        private void panel10_SizeChanged(object sender, EventArgs e)
        {
            this.RadialGaugePanel.Width = (sender as Panel).Width / 2;
        }

        private void LinearDigitalBasePanel_SizeChanged(object sender, EventArgs e)
        {
            this.LinearGaugePanel.Height = this.LinearDigitalBasePanel.Height / 2;
        }

        public void UpdateRadialGaugeCustomTheme()
        {
            for (int i = 0; i < this.flowLayoutPanel1.Controls.Count; i++)
            {
                ThemeChoiceControl themeChoiceControl = (ThemeChoiceControl)this.flowLayoutPanel1.Controls[i];

                if (themeChoiceControl.BrushName.Text == "BackgroundColor")
                {
                    if (this.radialGauge1.VisualStyle == ThemeStyle.Office2016Colorful)
                    {
                        themeChoiceControl.buttonEdit1.Text = "#FFFFFF";
                    }
                    else if (this.radialGauge1.VisualStyle == ThemeStyle.Office2016DarkGray)
                    {
                        themeChoiceControl.buttonEdit1.Text = "#b2b2b2";
                    }
                    else if (this.radialGauge1.VisualStyle == ThemeStyle.Office2016White)
                    {
                        themeChoiceControl.buttonEdit1.Text = "#FFFFFF";
                    }
                    else if (this.radialGauge1.VisualStyle == ThemeStyle.Office2016Black)
                    {
                        themeChoiceControl.buttonEdit1.Text = "#262626";
                    }
                    else if (this.radialGauge1.VisualStyle == ThemeStyle.Metro)
                    {
                        themeChoiceControl.buttonEdit1.Text = "#FFFFFF";
                    }
                    else if (this.radialGauge1.VisualStyle == ThemeStyle.Black)
                    {
                        themeChoiceControl.buttonEdit1.Text = "#323031";
                    }
                    else if (this.radialGauge1.VisualStyle == ThemeStyle.Blue)
                    {
                        themeChoiceControl.buttonEdit1.Text = "#ECF4FC";
                    }
                }
                else if (themeChoiceControl.BrushName.Text == "OuterFrameBackgroundColor")
                {
                    if (this.radialGauge1.VisualStyle == ThemeStyle.Office2016Colorful)
                    {
                        themeChoiceControl.buttonEdit1.Text = "#c5c5c5";
                    }
                    else if (this.radialGauge1.VisualStyle == ThemeStyle.Office2016DarkGray)
                    {
                        themeChoiceControl.buttonEdit1.Text = "#6a6a6a";
                    }
                    else if (this.radialGauge1.VisualStyle == ThemeStyle.Office2016White)
                    {
                        themeChoiceControl.buttonEdit1.Text = "#E6E6E6";
                    }
                    else if (this.radialGauge1.VisualStyle == ThemeStyle.Office2016Black)
                    {
                        themeChoiceControl.buttonEdit1.Text = "#363636";
                    }
                    else if (this.radialGauge1.VisualStyle == ThemeStyle.Metro)
                    {
                        themeChoiceControl.buttonEdit1.Text = "#808080";
                    }
                    else if (this.radialGauge1.VisualStyle == ThemeStyle.Black)
                    {
                        themeChoiceControl.buttonEdit1.Text = "#CEDDEE";
                    }
                    else if (this.radialGauge1.VisualStyle == ThemeStyle.Blue)
                    {
                        themeChoiceControl.buttonEdit1.Text = "#BDCAD9";
                    }
                }
                else if (themeChoiceControl.BrushName.Text == "InnerFrameBackgroundColor")
                {
                    if (this.radialGauge1.VisualStyle == ThemeStyle.Office2016Colorful)
                    {
                        themeChoiceControl.buttonEdit1.Text = "#ffffff";
                    }
                    else if (this.radialGauge1.VisualStyle == ThemeStyle.Office2016DarkGray)
                    {
                        themeChoiceControl.buttonEdit1.Text = "#b2b2b2";
                    }
                    else if (this.radialGauge1.VisualStyle == ThemeStyle.Office2016White)
                    {
                        themeChoiceControl.buttonEdit1.Text = "#FFFFFF";
                    }
                    else if (this.radialGauge1.VisualStyle == ThemeStyle.Office2016Black)
                    {
                        themeChoiceControl.buttonEdit1.Text = "#262626";
                    }
                    else if (this.radialGauge1.VisualStyle == ThemeStyle.Metro)
                    {
                        themeChoiceControl.buttonEdit1.Text = "#808080";
                    }
                    else if (this.radialGauge1.VisualStyle == ThemeStyle.Black)
                    {
                        themeChoiceControl.buttonEdit1.Text = "#232021";
                    }
                    else if (this.radialGauge1.VisualStyle == ThemeStyle.Blue)
                    {
                        themeChoiceControl.buttonEdit1.Text = "#849DBD";
                    }
                }
                else if (themeChoiceControl.BrushName.Text == "ArcColor")
                {
                    if (this.radialGauge1.VisualStyle == ThemeStyle.Office2016Colorful)
                    {
                        themeChoiceControl.buttonEdit1.Text = "#b5b5b5";
                    }
                    else if (this.radialGauge1.VisualStyle == ThemeStyle.Office2016DarkGray)
                    {
                        themeChoiceControl.buttonEdit1.Text = "#262626";
                    }
                    else if (this.radialGauge1.VisualStyle == ThemeStyle.Office2016White)
                    {
                        themeChoiceControl.buttonEdit1.Text = "#B5B5B5";
                    }
                    else if (this.radialGauge1.VisualStyle == ThemeStyle.Office2016Black)
                    {
                        themeChoiceControl.buttonEdit1.Text = "#686868";
                    }
                    else if (this.radialGauge1.VisualStyle == ThemeStyle.Metro)
                    {
                        themeChoiceControl.buttonEdit1.Text = "#808080";
                    }
                    else if (this.radialGauge1.VisualStyle == ThemeStyle.Black)
                    {
                        themeChoiceControl.buttonEdit1.Text = "#FFFFFF";
                    }
                    else if (this.radialGauge1.VisualStyle == ThemeStyle.Blue)
                    {
                        themeChoiceControl.buttonEdit1.Text = "#5F6F77";
                    }
                }
                else if (themeChoiceControl.BrushName.Text == "MinorTickMarkColor")
                {
                    if (this.radialGauge1.VisualStyle == ThemeStyle.Office2016Colorful)
                    {
                        themeChoiceControl.buttonEdit1.Text = "#b5b5b5";
                    }
                    else if (this.radialGauge1.VisualStyle == ThemeStyle.Office2016DarkGray)
                    {
                        themeChoiceControl.buttonEdit1.Text = "#444444";
                    }
                    else if (this.radialGauge1.VisualStyle == ThemeStyle.Office2016White)
                    {
                        themeChoiceControl.buttonEdit1.Text = "#ACACAC";
                    }
                    else if (this.radialGauge1.VisualStyle == ThemeStyle.Office2016Black)
                    {
                        themeChoiceControl.buttonEdit1.Text = "#444444";
                    }
                    else if (this.radialGauge1.VisualStyle == ThemeStyle.Metro)
                    {
                        themeChoiceControl.buttonEdit1.Text = "#808080";
                    }
                    else if (this.radialGauge1.VisualStyle == ThemeStyle.Black)
                    {
                        themeChoiceControl.buttonEdit1.Text = "#FFFFFF";
                    }
                    else if (this.radialGauge1.VisualStyle == ThemeStyle.Blue)
                    {
                        themeChoiceControl.buttonEdit1.Text = "#5F6F77";
                    }
                }
                else if (themeChoiceControl.BrushName.Text == "MajorTickMarkColor")
                {
                    if (this.radialGauge1.VisualStyle == ThemeStyle.Office2016Colorful)
                    {
                        themeChoiceControl.buttonEdit1.Text = "#3d3d3d";
                    }
                    else if (this.radialGauge1.VisualStyle == ThemeStyle.Office2016DarkGray)
                    {
                        themeChoiceControl.buttonEdit1.Text = "#3D3D3D";
                    }
                    else if (this.radialGauge1.VisualStyle == ThemeStyle.Office2016White)
                    {
                        themeChoiceControl.buttonEdit1.Text = "#737373";
                    }
                    else if (this.radialGauge1.VisualStyle == ThemeStyle.Office2016Black)
                    {
                        themeChoiceControl.buttonEdit1.Text = "#686868";
                    }
                    else if (this.radialGauge1.VisualStyle == ThemeStyle.Metro)
                    {
                        themeChoiceControl.buttonEdit1.Text = "#808080";
                    }
                    else if (this.radialGauge1.VisualStyle == ThemeStyle.Black)
                    {
                        themeChoiceControl.buttonEdit1.Text = "#FFFFFF";
                    }
                    else if (this.radialGauge1.VisualStyle == ThemeStyle.Blue)
                    {
                        themeChoiceControl.buttonEdit1.Text = "#5F6F77";
                    }
                }
                else if (themeChoiceControl.BrushName.Text == "InterLinesColor")
                {
                    if (this.radialGauge1.VisualStyle == ThemeStyle.Office2016Colorful)
                    {
                        themeChoiceControl.buttonEdit1.Text = "#3d3d3d";
                    }
                    else if (this.radialGauge1.VisualStyle == ThemeStyle.Office2016DarkGray)
                    {
                        themeChoiceControl.buttonEdit1.Text = "#3D3D3D";
                    }
                    else if (this.radialGauge1.VisualStyle == ThemeStyle.Office2016White)
                    {
                        themeChoiceControl.buttonEdit1.Text = "#737373";
                    }
                    else if (this.radialGauge1.VisualStyle == ThemeStyle.Office2016Black)
                    {
                        themeChoiceControl.buttonEdit1.Text = "#686868";
                    }
                    else if (this.radialGauge1.VisualStyle == ThemeStyle.Metro)
                    {
                        themeChoiceControl.buttonEdit1.Text = "#808080";
                    }
                    else if (this.radialGauge1.VisualStyle == ThemeStyle.Black)
                    {
                        themeChoiceControl.buttonEdit1.Text = "#FFFFFF";
                    }
                    else if (this.radialGauge1.VisualStyle == ThemeStyle.Blue)
                    {
                        themeChoiceControl.buttonEdit1.Text = "#5F6F77";
                    }
                }
                else if (themeChoiceControl.BrushName.Text == "NeedlePointerColor")
                {
                    if (this.radialGauge1.VisualStyle == ThemeStyle.Office2016Colorful)
                    {
                        themeChoiceControl.buttonEdit1.Text = "#0173c7";
                    }
                    else if (this.radialGauge1.VisualStyle == ThemeStyle.Office2016DarkGray)
                    {
                        themeChoiceControl.buttonEdit1.Text = "#0173c7";
                    }
                    else if (this.radialGauge1.VisualStyle == ThemeStyle.Office2016White)
                    {
                        themeChoiceControl.buttonEdit1.Text = "#0173c7";
                    }
                    else if (this.radialGauge1.VisualStyle == ThemeStyle.Office2016Black)
                    {
                        themeChoiceControl.buttonEdit1.Text = "#0173c7";
                    }
                    else if (this.radialGauge1.VisualStyle == ThemeStyle.Metro)
                    {
                        themeChoiceControl.buttonEdit1.Text = "#11b4cd";
                    }
                    else if (this.radialGauge1.VisualStyle == ThemeStyle.Black)
                    {
                        themeChoiceControl.buttonEdit1.Text = "#FFFFFF";
                    }
                    else if (this.radialGauge1.VisualStyle == ThemeStyle.Blue)
                    {
                        themeChoiceControl.buttonEdit1.Text = "#5F6F77";
                    }
                }
                else if (themeChoiceControl.BrushName.Text == "ScaleLabelColor")
                {
                    if (this.radialGauge1.VisualStyle == ThemeStyle.Office2016Colorful)
                    {
                        themeChoiceControl.buttonEdit1.Text = "#5e5e5e";
                    }
                    else if (this.radialGauge1.VisualStyle == ThemeStyle.Office2016DarkGray)
                    {
                        themeChoiceControl.buttonEdit1.Text = "#000000";
                    }
                    else if (this.radialGauge1.VisualStyle == ThemeStyle.Office2016White)
                    {
                        themeChoiceControl.buttonEdit1.Text = "#444445";
                    }
                    else if (this.radialGauge1.VisualStyle == ThemeStyle.Office2016Black)
                    {
                        themeChoiceControl.buttonEdit1.Text = "#FFFFFF";
                    }
                    else if (this.radialGauge1.VisualStyle == ThemeStyle.Metro)
                    {
                        themeChoiceControl.buttonEdit1.Text = "#808080";
                    }
                    else if (this.radialGauge1.VisualStyle == ThemeStyle.Black)
                    {
                        themeChoiceControl.buttonEdit1.Text = "#808080";
                    }
                    else if (this.radialGauge1.VisualStyle == ThemeStyle.Blue)
                    {
                        themeChoiceControl.buttonEdit1.Text = "#808080";
                    }
                }
                else if (themeChoiceControl.BrushName.Text == "GaugeLabelColor")
                {
                    if (this.radialGauge1.VisualStyle == ThemeStyle.Office2016Colorful)
                    {
                        themeChoiceControl.buttonEdit1.Text = "#5e5e5e";
                    }
                    else if (this.radialGauge1.VisualStyle == ThemeStyle.Office2016DarkGray)
                    {
                        themeChoiceControl.buttonEdit1.Text = "#000000";
                    }
                    else if (this.radialGauge1.VisualStyle == ThemeStyle.Office2016White)
                    {
                        themeChoiceControl.buttonEdit1.Text = "#444445";
                    }
                    else if (this.radialGauge1.VisualStyle == ThemeStyle.Office2016Black)
                    {
                        themeChoiceControl.buttonEdit1.Text = "#FFFFFF";
                    }
                    else if (this.radialGauge1.VisualStyle == ThemeStyle.Metro)
                    {
                        themeChoiceControl.buttonEdit1.Text = "#808080";
                    }
                    else if (this.radialGauge1.VisualStyle == ThemeStyle.Black)
                    {
                        themeChoiceControl.buttonEdit1.Text = "#808080";
                    }
                    else if (this.radialGauge1.VisualStyle == ThemeStyle.Blue)
                    {
                        themeChoiceControl.buttonEdit1.Text = "#808080";
                    }
                }
                else if (themeChoiceControl.BrushName.Text == "GaugeValueColor")
                {
                    if (this.radialGauge1.VisualStyle == ThemeStyle.Office2016Colorful)
                    {
                        themeChoiceControl.buttonEdit1.Text = "#5e5e5e";
                    }
                    else if (this.radialGauge1.VisualStyle == ThemeStyle.Office2016DarkGray)
                    {
                        themeChoiceControl.buttonEdit1.Text = "#000000";
                    }
                    else if (this.radialGauge1.VisualStyle == ThemeStyle.Office2016White)
                    {
                        themeChoiceControl.buttonEdit1.Text = "#444445";
                    }
                    else if (this.radialGauge1.VisualStyle == ThemeStyle.Office2016Black)
                    {
                        themeChoiceControl.buttonEdit1.Text = "#FFFFFF";
                    }
                    else if (this.radialGauge1.VisualStyle == ThemeStyle.Metro)
                    {
                        themeChoiceControl.buttonEdit1.Text = "#808080";
                    }
                    else if (this.radialGauge1.VisualStyle == ThemeStyle.Black)
                    {
                        themeChoiceControl.buttonEdit1.Text = "#808080";
                    }
                    else if (this.radialGauge1.VisualStyle == ThemeStyle.Blue)
                    {
                        themeChoiceControl.buttonEdit1.Text = "#808080";
                    }
                }
                if (themeChoiceControl.buttonEdit1.Text.ToLower().ToString() == "#ffffff")
                {
                    themeChoiceControl.buttonEditChildButton1.MetroColor = Color.Wheat;
                }
                else
                {
                    themeChoiceControl.buttonEditChildButton1.MetroColor = ColorTranslator.FromHtml(themeChoiceControl.buttonEdit1.Text);
                }
            }
        }
        
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

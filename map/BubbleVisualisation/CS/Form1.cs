#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Syncfusion.UI.Xaml.Maps;
using Syncfusion.Windows.Forms;
using Syncfusion.Windows.Forms.Maps;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BubbleVisualization
{
    public partial class Form1 : MetroForm
    {
        public Form1()
        {
            InitializeComponent();
            try
            {
                System.Drawing.Icon ico = new System.Drawing.Icon(GetIconFile(@"common\Images\Grid\Icon\sfgrid.ico"));
                this.Icon = ico;
            }
            catch { }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.MetroColor = Color.White;
            this.mapsControl1.Dock = DockStyle.Fill;
            this.mapsControl1.Margin = new Padding(0, 0, 4, 0);
            this.mapsControl1.MapBackgroundBrush = new SolidBrush(Color.White);
            this.mapsControl1.MapItemsShape = Syncfusion.Windows.Forms.Maps.MapItemShapes.None;
            this.mapsControl1.MapItemDrawing += mapsControl1_MapItemDrawing;
            this.mapsControl1.MapItemStroke = new SolidBrush(Color.Black);

            #region data

            MapViewModel viewmodel = new MapViewModel();

            #endregion

            ShapeFileLayer shapeLayer = new ShapeFileLayer();
            shapeLayer.ShapeSetting.FillSetting.AutoFillColors = false;
            shapeLayer.ShowMapItem = true;
            shapeLayer.Uri = "world1.shp";
            shapeLayer.ItemSource = viewmodel.Countries1;
            shapeLayer.ShapeIDPath = "NAME";
            shapeLayer.ShapeIDTableField = "NAME";
            shapeLayer.ShapeSetting.ShapeValuePath = "Population";
            shapeLayer.ShapeSetting.ShapeColorValuePath = "Population";
            shapeLayer.ShapeSetting.ShapeDisplayValuePath = "Population";
            shapeLayer.ShapeSetting.TextForeground = "Black";
            shapeLayer.ShapeSetting.ShapeFill = "#E5E5E5";
            shapeLayer.ShapeSetting.ShapeStrokeThickness = 0.5;
            shapeLayer.ShapeSetting.ShapeStroke = "#C1C1C1";

            #region Bubble Visualization

            shapeLayer.BubbleSetting.AutoFillColors = false;
            shapeLayer.BubbleSetting.MaxSize = 70;
            shapeLayer.BubbleSetting.MinSize = 25;
            shapeLayer.BubbleSetting.ValuePath = "Population";
            shapeLayer.BubbleSetting.ColorValuePath = "Population";
            shapeLayer.BubbleSetting.ColorMappings = new System.Collections.ObjectModel.ObservableCollection<ColorMapping>();
            shapeLayer.BubbleSetting.ColorMappings.Add(new RangeColorMapping { From =314623001, To = 1347350000, Color = System.Drawing.Color.FromArgb(0x7F, 0x20, 0xBC, 0xEE) });
            shapeLayer.BubbleSetting.ColorMappings.Add(new RangeColorMapping { From = 143228301, To= 314623001, Color = System.Drawing.Color.FromArgb(0x7F, 0xA7, 0xCE, 0x38) });
            shapeLayer.BubbleSetting.ColorMappings.Add(new RangeColorMapping { From = 82724090, To= 143228301, Color = System.Drawing.Color.FromArgb(0x7F, 0xF1, 0xB2, 0x1A) });
            shapeLayer.BubbleSetting.ColorMappings.Add(new RangeColorMapping { From = 22789702,  To= 50586757, Color = System.Drawing.Color.FromArgb(0x7F, 0x1D, 0xA2, 0x49) });
            shapeLayer.BubbleSetting.ColorMappings.Add(new RangeColorMapping { From = 0, To = 22789702, Color = System.Drawing.Color.FromArgb(0x7F, 0xEB, 0x73, 0x7C) });
            shapeLayer.BubbleSetting.ColorMappings.Add(new RangeColorMapping { From = 50586757, To = 82724090, Color = System.Drawing.Color.FromArgb(0x7F, 0xED, 0x2D, 0x95) });

            #endregion

            this.mapsControl1.Layers.Add(shapeLayer);
        }

        void mapsControl1_MapItemDrawing(object sender, MapItemDrawingEventArgs e)
        {
            e.Handled = true;
            BubbleVisualization.Country country = e.Data as BubbleVisualization.Country;
            PointF point = new PointF((float)e.X, (float)e.Y);
            Font font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            if (country != null)
            {
                e.Graphics.DrawString(country.PopulationFormat, font, new SolidBrush(Color.Black), point.X - 40, point.Y - 10);
            }
        }
    }
}

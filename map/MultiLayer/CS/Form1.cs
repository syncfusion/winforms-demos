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

namespace MultiLayer
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
            this.mapsControl1.MapItemDrawing += mapsControl1_MapItemDrawing;
            this.mapsControl1.Margin = new Padding(0, 0, 4, 0);
            this.mapsControl1.MapBackgroundBrush = new SolidBrush(Color.White);
            this.mapsControl1.MapItemsShape = Syncfusion.Windows.Forms.Maps.MapItemShapes.None;
            this.mapsControl1.MapItemStroke = new SolidBrush(Color.Black);

            #region data

            MapViewModel viewmodel = new MapViewModel();

            #endregion

            ShapeFileLayer shapeLayer = new ShapeFileLayer();
            shapeLayer.ShapeSetting.FillSetting.AutoFillColors = false;
            shapeLayer.ShowMapItem = true;
            shapeLayer.Uri = "continent.shp";
            shapeLayer.ItemSource = viewmodel.MuliLayerList;
            shapeLayer.ShapeIDPath = "NAME";
            shapeLayer.ShapeIDTableField = "Continent";
            shapeLayer.ShapeSetting.ShapeValuePath = "Weather";
			shapeLayer.ShapeSetting.ShapeColorValuePath = "Weather";
            shapeLayer.ShapeSetting.ShapeFill = "#E5E5E5";
            shapeLayer.ShapeSetting.ShapeStrokeThickness = 0.5;
            shapeLayer.ShapeSetting.ShapeStroke = "#C1C1C1";
            shapeLayer.BubbleSetting.AutoFillColors = false;
            shapeLayer.BubbleSetting.MaxSize = 60;
            shapeLayer.BubbleSetting.MinSize = 30;
            shapeLayer.BubbleSetting.ValuePath = "Weather";
            shapeLayer.BubbleSetting.ColorValuePath = "Weather";
            shapeLayer.BubbleSetting.ColorMappings = new System.Collections.ObjectModel.ObservableCollection<ColorMapping>();
            shapeLayer.BubbleSetting.ColorMappings.Add(new RangeColorMapping { From = 0, To = 30, Color = System.Drawing.Color.FromArgb(0x8C, 0x5F, 0xD3) });
            shapeLayer.BubbleSetting.ColorMappings.Add(new RangeColorMapping { From = 45, To = 55, Color = System.Drawing.Color.FromArgb(0xEF, 0x6A, 0xB3) });
            shapeLayer.BubbleSetting.ColorMappings.Add(new RangeColorMapping { From = 30, To = 40, Color = System.Drawing.Color.FromArgb(0x8A, 0xC6, 0x3C) });
            shapeLayer.BubbleSetting.ColorMappings.Add(new RangeColorMapping { From = 40, To = 45, Color = System.Drawing.Color.FromArgb(0x8A, 0xC6, 0x3C) });

            #region Multi-Layer(Sublayer)

            SubShapeFileLayer layer1 = new SubShapeFileLayer();
            layer1.Uri = "Africa.shp";
            layer1.ItemSource = viewmodel.AfricaList;
            layer1.ShapeIDPath = "NAME";
            layer1.ShapeIDTableField = "Country";
            layer1.ShapeSetting.ShapeValuePath = "Weather";
			layer1.ShapeSetting.ShapeColorValuePath = "Weather";
            layer1.ShapeSetting.ShapeFill = "#8DCEFF";
            layer1.ShapeSetting.ShapeStrokeThickness = 0.5;
            layer1.ShapeSetting.ShapeStroke = "#2F8CEA";
            layer1.BubbleSetting.AutoFillColors = false;
            layer1.BubbleSetting.MaxSize = 30;
            layer1.BubbleSetting.MinSize = 10;
            layer1.BubbleSetting.ValuePath = "Weather";
            layer1.BubbleSetting.ColorValuePath = "Weather";
            layer1.BubbleSetting.ColorMappings = new System.Collections.ObjectModel.ObservableCollection<ColorMapping>();
            layer1.BubbleSetting.ColorMappings.Add(new RangeColorMapping { From = 0, To = 30, Color = System.Drawing.Color.FromArgb(0x8C, 0x5F, 0xD3) });
            layer1.BubbleSetting.ColorMappings.Add(new RangeColorMapping { From = 30, To = 35, Color = System.Drawing.Color.FromArgb(0xEF, 0x6A, 0xB3) });
            layer1.BubbleSetting.ColorMappings.Add(new RangeColorMapping { From = 35, To = 40, Color = System.Drawing.Color.FromArgb(0x8A, 0xC6, 0x3C) });
            layer1.BubbleSetting.ColorMappings.Add(new RangeColorMapping { From = 40, To = 50, Color = System.Drawing.Color.FromArgb(0xF7, 0x9E, 0x46) });

            SubShapeFileLayer layer2 = new SubShapeFileLayer();
            layer2.Uri = "australia.shp";
            layer2.ItemSource = viewmodel.OceaniaList;
            layer2.ShapeIDPath = "NAME";
            layer2.ShapeIDTableField = "ADMIN_NAME";
            layer2.ShapeSetting.ShapeValuePath = "Weather";
            layer2.ShapeSetting.ShapeColorValuePath = "Weather";
            layer2.ShapeSetting.ShapeFill = "#8DCEFF";
            layer2.ShapeSetting.ShapeStrokeThickness = 0.5;
            layer2.ShapeSetting.ShapeStroke = "#2F8CEA";
            layer2.BubbleSetting.AutoFillColors = false;
            layer2.BubbleSetting.MaxSize = 30;
            layer2.BubbleSetting.MinSize = 10;
            layer2.BubbleSetting.ValuePath = "Weather";
            layer2.BubbleSetting.ColorValuePath = "Weather";
            layer2.BubbleSetting.ColorMappings = new System.Collections.ObjectModel.ObservableCollection<ColorMapping>();
            layer2.BubbleSetting.ColorMappings.Add(new RangeColorMapping { From = 0, To = 20, Color = System.Drawing.Color.FromArgb(0x8C, 0x5F, 0xD3) });
            layer2.BubbleSetting.ColorMappings.Add(new RangeColorMapping { From = 20, To = 25, Color = System.Drawing.Color.FromArgb(0xEF, 0x6A, 0xB3) });
            layer2.BubbleSetting.ColorMappings.Add(new RangeColorMapping { From = 25, To = 30, Color = System.Drawing.Color.FromArgb(0x8A, 0xC6, 0x3C) });
            layer2.BubbleSetting.ColorMappings.Add(new RangeColorMapping { From =30, To = 35, Color = System.Drawing.Color.FromArgb(0xF7, 0x9E, 0x46) });
            shapeLayer.SubShapeFileLayers.Add(layer1);
            shapeLayer.SubShapeFileLayers.Add(layer2);

            #endregion

            this.mapsControl1.Layers.Add(shapeLayer);
        }

        void mapsControl1_MapItemDrawing(object sender, MapItemDrawingEventArgs e)
        {
            e.Handled = true;
            MultiLayer.Country country = e.Data as MultiLayer.Country;
            PointF point=new PointF((float)e.X, (float)e.Y);
            Font font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            if (country != null)
            {
                e.Graphics.DrawString(country.Weather.ToString()+"°C", font, new SolidBrush(Color.Black), point.X - 17, point.Y - 10);
            }
        }
    }
}

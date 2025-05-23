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

namespace HeatMap
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

            #region data

            MapViewModel viewmodel = new MapViewModel();

            #endregion

            ShapeFileLayer shapeLayer = new ShapeFileLayer();

            #region HeatMap Demo

            shapeLayer.Uri = "world1.shp";
            shapeLayer.ItemSource = viewmodel.Countries;
            shapeLayer.ShapeIDPath = "NAME";
            shapeLayer.ShapeIDTableField = "NAME";
            shapeLayer.ShapeSetting.ShapeValuePath = "Population";
			shapeLayer.ShapeSetting.ShapeColorValuePath = "Population";
            shapeLayer.ShapeSetting.ShapeDisplayValuePath = "NAME";
            shapeLayer.ShapeSetting.TextForeground = "Black";
            shapeLayer.ShowMapItem = false;
            shapeLayer.ShapeSetting.ShapeFill = "#E5E5E5";
            shapeLayer.ShapeSetting.ShapeStrokeThickness = 0.5;
            shapeLayer.ShapeSetting.ShapeStroke = "#C1C1C1";
            shapeLayer.ShapeSetting.FillSetting.AutoFillColors = false;
            shapeLayer.ShapeSetting.FillSetting.ColorMappings = new System.Collections.ObjectModel.ObservableCollection<ColorMapping>();
            shapeLayer.ShapeSetting.FillSetting.ColorMappings.Add(new RangeColorMapping { From = 750000000, To = 1500000000, Color = System.Drawing.Color.FromArgb(0x2A, 0x91, 0xCF) });
            shapeLayer.ShapeSetting.FillSetting.ColorMappings.Add(new RangeColorMapping { From = 0, To = 750000000, Color = System.Drawing.Color.FromArgb(0x3D, 0x9F, 0xD8) });
            shapeLayer.ShapeSetting.FillSetting.ColorMappings.Add(new RangeColorMapping { From = 0, To = 0, Color = System.Drawing.Color.FromArgb(0xC7, 0xE9, 0xFA) });

            #endregion

            #region Annotation

            shapeLayer.Annotations.Add(new Annotation() { AnnotationLabel = "North America", Latitude = 40.4230, Longitude = -112.7372,AnnotationStroke = new SolidBrush(Color.OrangeRed) });
            shapeLayer.Annotations.Add(new Annotation() { AnnotationLabel = "Africa", Latitude = 9.1021, Longitude = 18.2812, AnnotationStroke = new SolidBrush(Color.OrangeRed) });
            shapeLayer.Annotations.Add(new Annotation() { AnnotationLabel = "Europe", Latitude = 53.0000, Longitude = 9.0000, AnnotationStroke = new SolidBrush(Color.OrangeRed) });
            shapeLayer.Annotations.Add(new Annotation() { AnnotationLabel = "South America", Latitude = -19.6048, Longitude = -73.0625, AnnotationStroke = new SolidBrush(Color.OrangeRed) });
            shapeLayer.Annotations.Add(new Annotation() { AnnotationLabel = "Asia", Latitude = 49.8380, Longitude = 105.8203, AnnotationStroke = new SolidBrush(Color.OrangeRed) });
            shapeLayer.Annotations.Add(new Annotation() { AnnotationLabel = "Oceania", Latitude = -20.3456, Longitude = 120.4346, AnnotationStroke = new SolidBrush(Color.OrangeRed) });

            #endregion

            this.mapsControl1.AnnotationDrawing += MapsControl1_AnnotationDrawing;
            this.mapsControl1.Layers.Add(shapeLayer);
        }

        /// <summary>
        /// This method is used to draw the customization of label.
        /// </summary>
        /// <param name="sender">This is object of maps control.</param>
        /// <param name="e">This is event args parameter.</param>
        private void MapsControl1_AnnotationDrawing(object sender, AnnotationDrawingEventArgs e)
        {
            var font = new Font("Segoe UI", (int)DpiAware.LogicalToDeviceUnits(12F), FontStyle.Regular, GraphicsUnit.Pixel, ((byte)(0)));
            StringFormat format = new StringFormat();
            format.FormatFlags = StringFormatFlags.FitBlackBox;
            var location = (e.Annotation as Annotation);
            e.Handled = true;
            PointF point = new PointF((float)e.X, (float)e.Y);
            e.Graphics.DrawString(location.AnnotationLabel, font, location.AnnotationStroke, new PointF(point.X + 10, point.Y + 3));
        }
    }
}

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
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DataMarkers
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
            this.mapsControl1.Dock = DockStyle.Fill;            
           
            this.mapsControl1.Margin = new Padding(0, 0, 4, 0);
            this.mapsControl1.MapBackgroundBrush = new SolidBrush(Color.White);
            this.mapsControl1.MapItemsShape = Syncfusion.Windows.Forms.Maps.MapItemShapes.None;
            this.mapsControl1.MapItemStroke = new SolidBrush(Color.Black);
            ShapeFileLayer shapeLayer = new ShapeFileLayer();
            shapeLayer.ShapeSetting.FillSetting.AutoFillColors = false;
            shapeLayer.ShowMapItem = true;
            shapeLayer.Uri = "world1.shp";
            shapeLayer.ShapeIDPath = "NAME";
            shapeLayer.ShapeIDTableField = "NAME";
            shapeLayer.ShowMapItem = true;            
            shapeLayer.ShapeSetting.ShapeFill = "#626171";
            shapeLayer.ShapeSetting.ShapeStrokeThickness = 0.5;
            shapeLayer.ShapeSetting.ShapeStroke = "#C1C1C1";
            shapeLayer.ShapeSetting.FillSetting.AutoFillColors = false;
            Annotation annotation1 = new Annotation() { AnnotationShape = AnnotationShapes.Rectangle, AnnotationLabel = "United States", Latitude = 35.8233, Longitude =-78.8258 };
            Annotation annotation2 = new Annotation() { AnnotationShape = AnnotationShapes.Rectangle, AnnotationLabel = "India", Latitude = 13.0810, Longitude = 79.970 };
            shapeLayer.Annotations.Add(annotation1);
            shapeLayer.Annotations.Add(annotation2);
             shapeLayer.Annotations = new ObservableCollection<Annotation>(){
            new SyncfusionLocations() { Name = "USA", Latitude = 38.8833, Longitude = -77.0167},
            new SyncfusionLocations() { Name = "Brazil", Latitude = -15.7833, Longitude = -47.8667},
            new SyncfusionLocations() { Name = "India", Latitude = 21.0000, Longitude = 78.0000},
            new SyncfusionLocations() { Name = "China", Latitude = 35.0000, Longitude = 103.0000},
            new SyncfusionLocations() { Name = "Indonesia", Latitude = -6.1750, Longitude = 106.8283},

        };

        
            this.mapsControl1.AnnotationDrawing += mapsControl1_AnnotationDrawing;
            this.mapsControl1.Layers.Add(shapeLayer);
           
        }

        void mapsControl1_AnnotationDrawing(object sender, AnnotationDrawingEventArgs e)
        {
            var font = new Font("Segoe UI", (int)DpiAware.LogicalToDeviceUnits(12F), FontStyle.Regular, GraphicsUnit.Pixel, ((byte)(0)));
            StringFormat format = new StringFormat();
            format.FormatFlags = StringFormatFlags.FitBlackBox;
            var location = (e.Annotation as SyncfusionLocations);
            e.Handled = true;
            PointF point = new PointF((float)e.X, (float)e.Y);
#if NETCORE
            Image img = Image.FromFile("..//..//..//pin.png");
#else
            Image img = Image.FromFile("..//..//pin.png");
#endif
            e.Graphics.DrawImage(img, point.X - 10, point.Y - 25, 20, 30);
            e.Graphics.FillRectangle(new SolidBrush(Color.DarkCyan), new RectangleF(point.X + 5, point.Y + 2, (int)DpiAware.LogicalToDeviceUnits(60), (int)DpiAware.LogicalToDeviceUnits(20)));
            e.Graphics.DrawString(location.Name, font, new SolidBrush(Color.White), new PointF(point.X + 10, point.Y + 3));

        }
        
    }

    public class SyncfusionLocations : Annotation
    {
        public string Name { get; set; }  
    }


}

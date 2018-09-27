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

namespace MapPoints
{
    public partial class Form1 : MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.MetroColor = Color.White;
            this.mapsControl1.Dock = DockStyle.Fill;
            this.mapsControl1.Margin = new Padding(0, 0, 4, 0);
            this.mapsControl1.MapBackgroundBrush = new SolidBrush(Color.White);
            this.mapsControl1.MapItemsShape = Syncfusion.Windows.Forms.Maps.MapItemShapes.None;
            this.mapsControl1.MapItemStroke = new SolidBrush(Color.Black);

            #region data

            MapViewModel viewmodel = new MapViewModel();

            #endregion

            ShapeFileLayer shapeLayer = new ShapeFileLayer();
            shapeLayer.ShapeSetting.FillSetting.AutoFillColors = false;
            shapeLayer.Uri = "states.shp";
           
            shapeLayer.ShapeSetting.ShapeFill = "#E5E5E5";
            shapeLayer.ShapeSetting.ShapeStrokeThickness = 0.5;
            shapeLayer.ShapeSetting.ShapeStroke = "#C1C1C1";
         
            #region Sub-Layer(Sublayer)

            SubShapeFileLayer layer1 = new SubShapeFileLayer();
            layer1.Uri = "landslide.shp";           
            layer1.ShapeSetting.ShapeFill = "#8DCEFF";
            layer1.ShapeSetting.ShapeStrokeThickness = 0.5;
            layer1.ShapeSetting.ShapeStroke = "#2F8CEA";      
            shapeLayer.SubShapeFileLayers.Add(layer1);

            #endregion

            this.mapsControl1.Layers.Add(shapeLayer);
        }
    }
}

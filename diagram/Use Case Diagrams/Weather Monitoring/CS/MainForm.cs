#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
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
using System.Text;
using System.Windows.Forms;
using Syncfusion.Windows.Forms.Diagram.Samples.gov.weather.graphical;
using System.Xml;
using System.Threading;

namespace Syncfusion.Windows.Forms.Diagram.Samples
{
    public partial class MainForm : MetroForm
    {
        /// <summary>
        /// NDFD weather service
        /// </summary>
        private ndfdXML weatherService;
        private List<State> states;
        private int value = 0;
        private int maximum = 0;      
        private bool bIsLoading;
        private NodeCollection records;
        public MainForm()
        {
            InitializeComponent();
            diagram1.KeyDown += new KeyEventHandler(diagram1_KeyDown);
            diagram1.Model.BackgroundImageLayout = Syncfusion.Windows.Forms.Diagram.ImageLayout.Stretch;
            diagram1.Model.BackgroundImage = Image.FromFile(@"..\..\..\..\..\..\Common\Images\Diagram\Weather Monitoring\Map.png");
            diagram1.Model.LogicalSize = diagram1.Model.BackgroundImage.Size;
            TextNode txtNode = new TextNode("Loading  0 %", new RectangleF(0,0,300,50));
            txtNode.FontStyle.Family = "Segoe UI";
            txtNode.FontStyle.Size = 14;
            txtNode.FontColorStyle.Color = Color.Black;            
            txtNode.LineStyle.LineWidth = 0;
            txtNode.PinPoint = new PointF(800,570);
            txtNode.EditStyle.AllowSelect = false;
            txtNode.Name = "Status";
            diagram1.Model.AppendChild(txtNode);
            InitStates();
        }

        #region Event Handlers
        void diagram1_KeyDown(object sender, KeyEventArgs e)
        {
            if (!bIsLoading)
            {
                if (e.KeyCode == Keys.F5)
                {
                    bIsLoading = true;
                    diagram1.Model.Clear();
                    TextNode txtNode = new TextNode("Loading  0 %", new RectangleF(0, 0, 300, 50));
                    txtNode.FontStyle.Family = "Segoe UI";
                    txtNode.FontStyle.Size = 14;
                    txtNode.FontColorStyle.Color = Color.Black;
                    txtNode.LineStyle.LineWidth = 0;
                    txtNode.PinPoint = new PointF(800, 570);
                    txtNode.EditStyle.AllowSelect = false;
                    txtNode.Name = "Status";
                    diagram1.Model.AppendChild(txtNode);
                    backgroundWorker1.RunWorkerAsync();
                }
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            ((TextNode)diagram1.Model.Nodes["Status"]).Text = "Loading  0 %";
            backgroundWorker1.RunWorkerAsync();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            bIsLoading = true;
            GenerateReport();
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (records != null && !records.IsEmpty)
            {
                int i;
                diagram1.Model.AppendChildren(records, out i);
                bIsLoading = false;
                value = 0;
            }
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            int percent = e.ProgressPercentage * 100 / maximum;
            if (percent == 100)
                ((TextNode)diagram1.Model.Nodes["Status"]).Text = "Hit F5 to refresh the report.";
            else
                ((TextNode)diagram1.Model.Nodes["Status"]).Text = "Loading  " + percent + " %";
        }
        #endregion

        #region Initialize Diagram
        /// <summary>
        /// Initiate state nodes
        /// </summary>
        private void InitStates()
        {
            weatherService = new ndfdXML();
            states = new List<State>();
            states.Add(new State("WA", 47.3030m, -120.1245m));
            states.Add(new State("TX", 31.1060m, -99.6475m));
            states.Add(new State("CA", 37.1700m, -119.7462m));
            states.Add(new State("GA", 32.9866m, -84.6487m));
            states.Add(new State("MT", 46.9048m, -110.3261m));
            states.Add(new State("CO", 39.0646m, -106.3272m));
            states.Add(new State("NV", 39.4199m, -117.1219m));
            states.Add(new State("AZ", 34.1112m, -112.0131m));
            states.Add(new State("MO", 38.4623m, -93.3020m));
            states.Add(new State("PA", 40.5773m, -79.2640m));
            states.Add(new State("WI", 44.2563m, -90.6385m));
            states.Add(new State("ND", 47.5362m, -100.7930m));
            states.Add(new State("NE", 41.1289m, -99.2883m));
        }

        /// <summary>
        /// Converts latitude and longitude to (x,y) coordinates on the background map.
        /// </summary>
        private PointF ConvertCoordinates(decimal latitude, decimal longitude)
        {
            SizeF mapSize = diagram1.Model.LogicalSize;
            double y = ((double)latitude - 18d) * mapSize.Height / (55.5d - 18d);
            double x = (-(double)longitude - 70d) * mapSize.Width / (125d - 70d);
            return new PointF((float)mapSize.Width - (float)x, (float)mapSize.Height - (float)y);
        }

        /// <summary>
        /// Generate the reports
        /// </summary>
        private void GenerateReport()
        {
            records = new NodeCollection();           
            maximum = states.Count;
            try
            {
                foreach (State state in states)
                {
                    weatherParametersType weatherType = new weatherParametersType();

                    //specifies parameters maximum temperature, weather condition and cloud amount
                    weatherType.maxt = true;
                    weatherType.sky = true;
                    weatherType.wx = true;


                    // call the weather service.                
                    //weatherService.NDFDgenAsync(state.Latitude, state.Longitude, productType.timeseries, DateTime.Now.Date, DateTime.Now.AddDays(1).Date, unitType.e, weatherType, state);
                    string str = weatherService.NDFDgenByDay(state.Latitude, state.Longitude, DateTime.Now.Date, "1", unitType.e, formatType.Item24hourly);
                    WeatherNode node = new WeatherNode();

                    // get coordinates on map.
                    PointF location = ConvertCoordinates(state.Latitude, state.Longitude);
                    node.PinPoint = new PointF(location.X - node.Size.Width / 2, location.Y - node.Size.Height / 2);
                    node.State = node.Name = state.Name;
                    if (!string.IsNullOrEmpty(str))
                    {
                        XmlDocument doc = new XmlDocument();
#if SyncfusionFramework4_0
                        doc.XmlResolver = null;
#endif
                        doc.LoadXml(str);
                        node.Temperature = XmlConvert.ToDecimal(doc.SelectSingleNode("dwml/data/parameters/temperature[@type='maximum']/value/text()").Value);
                        XmlNode n = doc.SelectSingleNode("dwml/data/parameters/weather/weather-conditions/value");
                        string weather = null;
                        if (n != null)
                        {
                            XmlAttribute attr = n.Attributes["weather-type"];
                            if (attr != null)
                                weather = n.Attributes["weather-type"].Value;
                        }
                        if (weather == "freezing rain" ||
                            weather == "rain" ||
                            weather == "hail" ||
                            weather == "rain showers" ||
                            weather == "freezing drizzle" ||
                            weather == "drizzle")
                        {
                            node.WeatherCondition = WeatherCondition.Rain;
                        }
                        else if (weather == "show showers" ||
                            weather == "blowing snow" ||
                            weather == "snow" ||
                            weather == "ice pellets")
                        {
                            node.WeatherCondition = WeatherCondition.Snow;
                        }
                        else if (weather == "thunderstorms")
                        {
                            node.WeatherCondition = WeatherCondition.ThunderStorm;
                        }
                        else
                        {
                            node.WeatherCondition = WeatherCondition.None;
                        }

                        records.Add(node);
                        value++;
                        backgroundWorker1.ReportProgress(value);
                    }

                }
            }
            catch (Exception exp)
            {
                MessageBox.Show("Failed to establish connection with the service provider");
            }
        }

        #endregion
    }
}
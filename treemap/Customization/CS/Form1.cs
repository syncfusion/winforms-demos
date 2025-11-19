#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Syncfusion.Windows.Forms;
using Syncfusion.Windows.Forms.TreeMap;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace CustomizationDemo
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

            this.MetroColor = Color.White;
            this.BackColor = Color.White;

            #region Sample Header

            Label sampleHeader = new Label();
            sampleHeader.Text = "This sample represents TreeMap showing Olympic Medals won by United States in various events.";
            sampleHeader.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            sampleHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(150)))), ((int)(((byte)(205)))));
            sampleHeader.ForeColor = System.Drawing.Color.White;
            sampleHeader.Size = new System.Drawing.Size(970, (int)DpiAware.LogicalToDeviceUnits(35));
            sampleHeader.Margin = new System.Windows.Forms.Padding(0);
            sampleHeader.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            sampleHeader.Dock = DockStyle.Top;
            this.Controls.Add(sampleHeader);

            #endregion

            #region TreeMap

            Panel sampleLayoutPanel = new Panel();
            sampleLayoutPanel.Dock = DockStyle.Fill;
            sampleLayoutPanel.Padding = new System.Windows.Forms.Padding(10, (int)DpiAware.LogicalToDeviceUnits(35), 0, 0);

            OlymicMedalsViewModel olymicMedalsViewModel = new OlymicMedalsViewModel();

            TreeMap treeMap = new TreeMap();
            treeMap.Dock = DockStyle.Fill;
            treeMap.Margin = new System.Windows.Forms.Padding(0, 0, 10, 10);
            treeMap.ItemsSource = olymicMedalsViewModel.OlympicMedalsDetails;
            treeMap.WeightValuePath = "TotalMedals";
            treeMap.ColorValuePath = "GoldMedals";
            treeMap.ItemsLayoutMode = ItemsLayoutModes.Squarified;
            treeMap.LeafItemDrawing += treeMap_LeafItemDrawing;
            ToolTipInfo itemInfo = new ToolTipInfo();
            itemInfo.ToolTipHeaderPattern = "<b>{Country} - {GameName}</b>";
            itemInfo.ToolTipContentPattern = "GoldMedals \t {GoldMedals}  \nSilverMedals \t {SilverMedals}  \nBronzeMedals \t {BronzeMedals}";
            treeMap.ItemToolTipInfo = itemInfo;
            treeMap.LeafItemSettings.LabelPath = "GameName";
            #region Range ColorMapping

            UniColorMapping uniColorMapping = new UniColorMapping();
            uniColorMapping.Color = Color.FromArgb(215, 48, 40);
            treeMap.LeafColorMapping = uniColorMapping;

            #endregion

            sampleLayoutPanel.Controls.Add(treeMap);
            this.Controls.Add(sampleLayoutPanel);

            #endregion
        }

        void treeMap_LeafItemDrawing(object sender, LeafItemDrawingEventArgs e)
        {
            e.Cancel = true;
            if (e.Graphics != null && e.Cancel)
            {
                e.Graphics.FillRectangle((e.Color), e.RectSize);
                e.Graphics.DrawRectangle(new Pen(new SolidBrush(Color.White), 5), e.RectSize);
                e.Graphics.DrawString(e.Label, new Font("Segoe UI", (float)12), new SolidBrush(Color.White), e.RectSize.X, e.RectSize.Y);

                Image image = (e.Data as OlympicMedals).GameImage;

                if (image != null)
                {
                    e.Graphics.DrawImage(image, new Point(e.RectSize.X + (e.RectSize.Width / 2) - image.Width / 2, e.RectSize.Y + (e.RectSize.Height / 2) - image.Height / 2));
                }
            }
        }
    }

    #region View Model

    public class OlymicMedalsViewModel
    {
        public ObservableCollection<OlympicMedals> OlympicMedalsDetails { get; set; }

        public OlymicMedalsViewModel()
        {
            var directoryPath = Application.StartupPath.Replace("bin\\Debug", "Images"); ;
            this.OlympicMedalsDetails = new ObservableCollection<OlympicMedals>();
            this.OlympicMedalsDetails.Add(new OlympicMedals { Country = "US", GameName = "Swimming", GoldMedals = 16, SilverMedals = 9, BronzeMedals = 6, TotalMedals = 31, GameImage = this.GetImage("Swimming") });
            this.OlympicMedalsDetails.Add(new OlympicMedals { Country = "US", GameName = "Track and Field", GoldMedals = 9, SilverMedals = 13, BronzeMedals = 7, TotalMedals = 29, GameImage = this.GetImage("TrackAndField") });
            this.OlympicMedalsDetails.Add(new OlympicMedals { Country = "US", GameName = "Gymnastics", GoldMedals = 3, SilverMedals = 1, BronzeMedals = 2, TotalMedals = 6, GameImage = this.GetImage("Gymnastics") });
            this.OlympicMedalsDetails.Add(new OlympicMedals { Country = "US", GameName = "Boxing", GoldMedals = 1, SilverMedals = 0, BronzeMedals = 1, TotalMedals = 2, GameImage = this.GetImage("Boxing") });
            this.OlympicMedalsDetails.Add(new OlympicMedals { Country = "US", GameName = "Cycling", GoldMedals = 1, SilverMedals = 2, BronzeMedals = 1, TotalMedals = 4, GameImage = this.GetImage("Cycling") });
            this.OlympicMedalsDetails.Add(new OlympicMedals { Country = "US", GameName = "Shooting", GoldMedals = 3, SilverMedals = 0, BronzeMedals = 1, TotalMedals = 4, GameImage = this.GetImage("Shooting") });
            this.OlympicMedalsDetails.Add(new OlympicMedals { Country = "US", GameName = "Wrestling", GoldMedals = 2, SilverMedals = 0, BronzeMedals = 2, TotalMedals = 4, GameImage = this.GetImage("Wrestling") });
            this.OlympicMedalsDetails.Add(new OlympicMedals { Country = "US", GameName = "Archery", GoldMedals = 0, SilverMedals = 1, BronzeMedals = 0, TotalMedals = 1, GameImage = this.GetImage("Archery") });
            this.OlympicMedalsDetails.Add(new OlympicMedals { Country = "US", GameName = "Soccer", GoldMedals = 1, SilverMedals = 0, BronzeMedals = 0, TotalMedals = 1, GameImage = this.GetImage("Soccer") });
            this.OlympicMedalsDetails.Add(new OlympicMedals { Country = "US", GameName = "Diving", GoldMedals = 1, SilverMedals = 1, BronzeMedals = 2, TotalMedals = 4, GameImage = this.GetImage("Diving") });
        }

        public Image GetImage(string image)
        {
            Image img = null;

#if NETCORE
            img = Image.FromFile(@"..\..\..\..\..\Images\" + image + ".png");
#else
            img = Image.FromFile(@"..\..\..\..\Images\" + image + ".png");
#endif
            return img;
        }
    }

    public class OlympicMedals
    {
        public string Country { get; set; }
        public string GameName { get; set; }
        public double GoldMedals { get; set; }
        public double SilverMedals { get; set; }
        public double BronzeMedals { get; set; }
        public double TotalMedals { get; set; }
        public Image GameImage { get; set; }
    }

#endregion
}

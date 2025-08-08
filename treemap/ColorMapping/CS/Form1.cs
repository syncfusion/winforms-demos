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
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FlatCollectionTreeMap
{
    #region Form1

    public partial class Form1 : MetroForm
    {
        #region Private Variables
        int colorMappingSelectedIndex = 2;
        GroupBox treeMapContainer = new GroupBox();
        GroupBox userOptionsGroupBox = new GroupBox();
        Panel treeMapPanel = new Panel();
        Label layoutModeLabel = new Label();
        ComboBox layoutModeComboBox = new ComboBox();
        DesaturationColorMapping desaturationColorMapping = new DesaturationColorMapping();
        RangeBrushColorMapping rangeBrushColorMapping = new RangeBrushColorMapping();
        UniColorMapping uniColorMapping = new UniColorMapping();
        PaletteColorMapping paletteColorMapping = new PaletteColorMapping();

        Label sampleHeader = new Label();
        TreeMap TreeMap1 = new TreeMap();
        Splitter splitter = new Splitter();
        #endregion

        #region Contructor

        public Form1()
        {
            InitializeComponent();
            try
            {
                System.Drawing.Icon ico = new System.Drawing.Icon(GetIconFile(@"common\Images\Grid\Icon\sfgrid.ico"));
                this.Icon = ico;
            }
            catch { }

            this.BackColor = Color.White;

            PopulationViewModel data = new PopulationViewModel();
            TreeMap1.ItemsSource = data.PopulationDetails;
            TreeMap1.WeightValuePath = "Population";
            TreeMap1.ColorValuePath = "Growth"; //"Population";
            TreeMap1.LegendSetting.LegendType = LegendTypes.Ellipse;
            TreeMap1.LegendSetting.LegendGap = 130;
            TreeMap1.LegendSetting.ShowLegend = true;
            //TreeMap1.IsLegendVisible = false;
            TreeMap1.LegendSetting.LegendPosition = LegendPositions.Top;
            TreeMap1.Dock = DockStyle.Fill;
            TreeMap1.ItemsLayoutMode = Syncfusion.Windows.Forms.TreeMap.ItemsLayoutModes.SliceAndDiceAuto;
            ToolTipInfo itemInfoHead = new ToolTipInfo();
            itemInfoHead.ToolTipHeaderPattern = "<b>{Label}</b>";
            itemInfoHead.ToolTipContentPattern = "Growth \t  :  {Growth} % ";
            TreeMap1.HeaderToolTipInfo = itemInfoHead;
            ToolTipInfo itemInfo = new ToolTipInfo();
            itemInfo.ToolTipHeaderPattern = "<b>{Country}</b>";
            itemInfo.ToolTipContentPattern = "Growth \t      :  {Growth} %  \nPopulation   :  {StrPopulation}  ";
            TreeMap1.ItemToolTipInfo = itemInfo;  
            #region ColorMapping

            #region UniColorMapping
            
            uniColorMapping.Color = Color.MediumSlateBlue;
            
            #endregion


            #region RangeColorMapping

            rangeBrushColorMapping.Brushes.Add(new RangeBrush() { Color = System.Drawing.ColorTranslator.FromHtml("#77D8D8"), From = 0, To = 1, LegendLabel = "1% Growth" });
            rangeBrushColorMapping.Brushes.Add(new RangeBrush() { Color = System.Drawing.ColorTranslator.FromHtml("#AED960"), From = 0, To = 2, LegendLabel = "2% Growth" });
            rangeBrushColorMapping.Brushes.Add(new RangeBrush() { Color = System.Drawing.ColorTranslator.FromHtml("#FFAF51"), From = 0, To = 3, LegendLabel = "3% Growth" });
            rangeBrushColorMapping.Brushes.Add(new RangeBrush() { Color = System.Drawing.ColorTranslator.FromHtml("#F3D240"), From = 0, To = 4, LegendLabel = "4% Growth" });

            #endregion


            #region DesaturationColorMapping

            desaturationColorMapping.Color = Color.OrangeRed;
            desaturationColorMapping.From = 220;
            desaturationColorMapping.To = 0;
            desaturationColorMapping.RangeMinimum = 0;
            desaturationColorMapping.RangeMaximum = 80000;
            this.TreeMap1.LeafColorMapping = desaturationColorMapping;

            #endregion

            #region PaletteColorMapping
            
            paletteColorMapping.Colors = new List<Brush>() 
            {
                new SolidBrush(Color.MediumSeaGreen),
                new SolidBrush(Color.PaleVioletRed),
                new SolidBrush(Color.MediumSlateBlue),
            };
            
            #endregion


            #endregion

            TreeMap1.LeafItemSettings.LabelPath = "Country";
            splitter.Dock = DockStyle.Top;
            splitter.Height = 40;
            userOptionsGroupBox.Controls.Add(splitter);

            layoutModeComboBox.Items.Add("UniColorMapping");
            layoutModeComboBox.Items.Add("RangeColorMapping");
            layoutModeComboBox.Items.Add("DesaturationColorMapping");
            layoutModeComboBox.Items.Add("PaletteColorMapping");
            layoutModeComboBox.SelectedIndex = 2;
            layoutModeComboBox.KeyDown += layoutModeComboBox_KeyDown;
            layoutModeComboBox.Dock = DockStyle.Top;
            layoutModeComboBox.SelectedValueChanged += layoutModeComboBox_SelectedValueChanged;
            userOptionsGroupBox.Controls.Add(layoutModeComboBox);

            layoutModeLabel.Text = "Color Mapping:";
            layoutModeLabel.Height = (int)DpiAware.LogicalToDeviceUnits(layoutModeLabel.Height);
            layoutModeLabel.Dock = DockStyle.Top;
            layoutModeLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            layoutModeComboBox.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            userOptionsGroupBox.Controls.Add(layoutModeLabel);
            userOptionsGroupBox.Padding = new System.Windows.Forms.Padding(20, 20, 20, 30);
            userOptionsGroupBox.Dock = DockStyle.Right;
            userOptionsGroupBox.Width = (int)DpiAware.LogicalToDeviceUnits(userOptionsGroupBox.Width);

            treeMapPanel.Dock = DockStyle.Fill;
            treeMapPanel.Controls.Add(TreeMap1);
            treeMapPanel.Controls.Add(userOptionsGroupBox);
            this.Controls.Add(treeMapPanel);

            sampleHeader.Text = "This sample demonstrates the various types of  Color Mapping available in TreeMap.";
            sampleHeader.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            sampleHeader.Location = new Point(10, 10);
            sampleHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(150)))), ((int)(((byte)(205)))));
            sampleHeader.ForeColor = System.Drawing.Color.White;
            sampleHeader.Location = new System.Drawing.Point(0, 0);
            sampleHeader.Size = new System.Drawing.Size(284, (int)DpiAware.LogicalToDeviceUnits(33));
            sampleHeader.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            sampleHeader.Dock = DockStyle.Top;
            this.Controls.Add(sampleHeader);
        }

        void layoutModeComboBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
           {
               layoutModeComboBox.Text = layoutModeComboBox.Items[colorMappingSelectedIndex].ToString();
           }
        }

        #endregion

        #region Events

        void layoutModeComboBox_SelectedValueChanged(object sender, EventArgs e)
        {

            colorMappingSelectedIndex = (sender as ComboBox).SelectedIndex;
            
            if (((sender as ComboBox).SelectedIndex == 0))
            {
                this.TreeMap1.LeafColorMapping = uniColorMapping;
            }
            else if (((sender as ComboBox).SelectedIndex == 1))
            {
                this.TreeMap1.LeafColorMapping = rangeBrushColorMapping;
            }
            else if (((sender as ComboBox).SelectedIndex == 2))
            {
                this.TreeMap1.LeafColorMapping = desaturationColorMapping;
            }
            else
            {
                this.TreeMap1.LeafColorMapping = paletteColorMapping;
            }
        }
        #endregion
    }

    #endregion

    #region View Model

    public class PopulationViewModel
    {
        public PopulationViewModel()
        {
            this.PopulationDetails = new ObservableCollection<PopulationDetail>();
            PopulationDetails.Add(new PopulationDetail() { Continent = "Asia", Country = "Indonesia", Growth = 3, Population = 237641326, StrPopulation = "237.6 M" });
            PopulationDetails.Add(new PopulationDetail() { Continent = "Asia", Country = "Russia", Growth = 2, Population = 152518015, StrPopulation = "152.5 M" });
            PopulationDetails.Add(new PopulationDetail() { Continent = "Asia", Country = "Malaysia", Growth = 1, Population = 29672000, StrPopulation = "29.7 M" });
            PopulationDetails.Add(new PopulationDetail() { Continent = "North America", Country = "United States", Growth = 4, Population = 315645000, StrPopulation = "315.6 M" });
            PopulationDetails.Add(new PopulationDetail() { Continent = "North America", Country = "Mexico", Growth = 2, Population = 112336538, StrPopulation = "112.3 M" });
            PopulationDetails.Add(new PopulationDetail() { Continent = "North America", Country = "Canada", Growth = 1, Population = 35056064, StrPopulation = "35.1 M" });
            PopulationDetails.Add(new PopulationDetail() { Continent = "South America", Country = "Colombia", Growth = 1, Population = 47000000, StrPopulation = "47 M" });
            PopulationDetails.Add(new PopulationDetail() { Continent = "South America", Country = "Brazil", Growth = 3, Population = 193946886, StrPopulation = "193.9 M" });
            PopulationDetails.Add(new PopulationDetail() { Continent = "Africa", Country = "Nigeria", Growth = 2, Population = 170901000, StrPopulation = "170.9 M" });
            PopulationDetails.Add(new PopulationDetail() { Continent = "Africa", Country = "Egypt", Growth = 1, Population = 83661000, StrPopulation = "83 M" });
            PopulationDetails.Add(new PopulationDetail() { Continent = "Europe", Country = "Germany", Growth = 1, Population = 81993000, StrPopulation = "82 M" });
            PopulationDetails.Add(new PopulationDetail() { Continent = "Europe", Country = "France", Growth = 1, Population = 65605000, StrPopulation = "65.6 M" });
            PopulationDetails.Add(new PopulationDetail() { Continent = "Europe", Country = "UK", Growth = 1, Population = 63181775, StrPopulation = "63.2 M" });

        }

        public ObservableCollection<PopulationDetail> PopulationDetails
        {
            get;
            set;
        }

        public class PopulationDetail
        {
            public string Continent { get; set; }
            public string Country { get; set; }
            public double Growth { get; set; }
            public double Population { get; set; }
            public string StrPopulation { get; set; }
        }
    }

    #endregion
}

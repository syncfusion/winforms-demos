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
        int LayoutModeSelectedIndex =0;
        int LegendPositionSelectedIndex = 2;
        GroupBox treeMapContainer = new GroupBox();
        GroupBox userOptionsGroupBox = new GroupBox();
        ComboBox LegendPositionComboBox = new ComboBox();
        Label legendpositionLabel = new Label();
        Label layoutModeLabel = new Label();
        ComboBox layoutModeComboBox = new ComboBox();
        Label sampleHeader = new Label();
        TreeMap TreeMap1 = new TreeMap();
        Splitter splitter = new Splitter();
        Panel treeMapPanel = new Panel();
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

            this.MetroColor = Color.White;
            this.BackColor = Color.White;

            PopulationViewModel data = new PopulationViewModel();
            TreeMap1.ItemsSource = data.PopulationDetails;
            TreeMap1.WeightValuePath = "Population";
            TreeMap1.ColorValuePath = "Growth";
            TreeMap1.LegendSetting.LegendType = LegendTypes.Ellipse;
            TreeMap1.LegendSetting.LegendGap = 150;
            TreeMap1.LegendSetting.ShowLegend = true;
            TreeMap1.LegendSetting.LegendPosition = LegendPositions.Top;
            TreeMap1.Dock = DockStyle.Fill;
            //TreeMap1.Margin = new System.Windows.Forms.Padding(10,10,10,10);
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

            #region Range ColorMapping

            //RangeBrushColorMapping
            RangeBrushColorMapping rangeBrushColorMapping = new RangeBrushColorMapping();
            rangeBrushColorMapping.Brushes.Add(new RangeBrush() { Color = System.Drawing.ColorTranslator.FromHtml("#77D8D8"), From = 0, To = 1, LegendLabel = "1% Growth" });
            rangeBrushColorMapping.Brushes.Add(new RangeBrush() { Color = System.Drawing.ColorTranslator.FromHtml("#AED960"), From = 0, To = 2, LegendLabel = "2% Growth" });
            rangeBrushColorMapping.Brushes.Add(new RangeBrush() { Color = System.Drawing.ColorTranslator.FromHtml("#FFAF51"), From = 0, To = 3, LegendLabel = "3% Growth" });
            rangeBrushColorMapping.Brushes.Add(new RangeBrush() { Color = System.Drawing.ColorTranslator.FromHtml("#F3D240"), From = 0, To = 4, LegendLabel = "4% Growth" });
            TreeMap1.LeafColorMapping = rangeBrushColorMapping;

            #endregion

            #endregion

            #region Level

            //Level

            TreeMapFlatLevel treeMapFlatLevel1 = new TreeMapFlatLevel();
            treeMapFlatLevel1.GroupPath = "Continent";
            TreeMap1.Levels.Add(treeMapFlatLevel1);

            TreeMap1.LeafItemSettings.LabelPath = "Country";
            TreeMap1.LeafItemDrawing += TreeMap1_LeafItemDrawing;
            #endregion

            LegendPositionComboBox.Items.Add("Left");
            LegendPositionComboBox.Items.Add("Right");
            LegendPositionComboBox.Items.Add("Top");
            LegendPositionComboBox.Items.Add("Bottom");
            LegendPositionComboBox.SelectedIndex = 2;
            LegendPositionComboBox.KeyDown += LegendPositionComboBox_KeyDown;
            LegendPositionComboBox.Dock = DockStyle.Top;
            LegendPositionComboBox.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            LegendPositionComboBox.SelectedValueChanged += comboBox1_SelectedValueChanged;
            userOptionsGroupBox.Controls.Add(LegendPositionComboBox);
            
            legendpositionLabel.Text = "Legend Position :";
            legendpositionLabel.Height = (int)DpiAware.LogicalToDeviceUnits(legendpositionLabel.Height);
            legendpositionLabel.Dock = DockStyle.Top;
            legendpositionLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            userOptionsGroupBox.Controls.Add(legendpositionLabel);

            splitter.Dock = DockStyle.Top;
            splitter.Height = 40;
            userOptionsGroupBox.Controls.Add(splitter);

            layoutModeComboBox.Items.Add("SliceAndDiceAuto");
            layoutModeComboBox.Items.Add("SliceAndDiceHorizontal");
            layoutModeComboBox.Items.Add("SliceAndDiceVertical");
            layoutModeComboBox.Items.Add("Squarified");
            layoutModeComboBox.SelectedIndex = 0;
            layoutModeComboBox.KeyDown += layoutModeComboBox_KeyDown;
            layoutModeComboBox.Dock = DockStyle.Top;
            layoutModeComboBox.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            layoutModeComboBox.SelectedValueChanged += layoutModeComboBox_SelectedValueChanged;
            userOptionsGroupBox.Controls.Add(layoutModeComboBox);

            layoutModeLabel.Text = "TreeMap Layout :";
            layoutModeLabel.Height = (int)DpiAware.LogicalToDeviceUnits(layoutModeLabel.Height);
            layoutModeLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            layoutModeLabel.Dock = DockStyle.Top;
            userOptionsGroupBox.Controls.Add(layoutModeLabel);
            userOptionsGroupBox.Dock = DockStyle.Right;
            userOptionsGroupBox.Width = (int)DpiAware.LogicalToDeviceUnits(userOptionsGroupBox.Width);
          
            treeMapContainer.Name = "Population Growth FY2012";
            treeMapPanel.Dock = DockStyle.Fill;
            treeMapPanel.Controls.Add(TreeMap1);
            treeMapPanel.Controls.Add(userOptionsGroupBox);
            this.Controls.Add(treeMapPanel);

            sampleHeader.Text = "This sample represents various types of layout available in the TreeMap for arrangement of items";
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

        /// <summary>
        /// This method is used to draw the customization of leaf item.
        /// </summary>
        /// <param name="sender">This is object of treemap control.</param>
        /// <param name="e">This is event args parameter.</param>
        private void TreeMap1_LeafItemDrawing(object sender, LeafItemDrawingEventArgs e)
        {
            e.Cancel = true;
            if (e.Graphics != null && e.Cancel)
            {
                e.Graphics.FillRectangle((e.Color), e.RectSize);
                e.Graphics.DrawRectangle(new Pen(new SolidBrush(Color.White), 1), e.RectSize);
                e.Graphics.DrawString(e.Label, new Font("Segoe UI", 11), new SolidBrush(Color.White), e.RectSize.X, e.RectSize.Y);
            }
        }

        void LegendPositionComboBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                LegendPositionComboBox.Text = LegendPositionComboBox.Items[LegendPositionSelectedIndex].ToString();
            }
        }

        void layoutModeComboBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                layoutModeComboBox.Text = layoutModeComboBox.Items[LayoutModeSelectedIndex].ToString();
            }
        }

        #endregion

        #region Events

        void layoutModeComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            LayoutModeSelectedIndex = (sender as ComboBox).SelectedIndex;
            if (((sender as ComboBox).SelectedIndex == 0))
            {
                this.TreeMap1.ItemsLayoutMode = ItemsLayoutModes.SliceAndDiceAuto;
            }
            else if (((sender as ComboBox).SelectedIndex == 1))
            {
                this.TreeMap1.ItemsLayoutMode = ItemsLayoutModes.SliceAndDiceHorizontal;
            }
            else if (((sender as ComboBox).SelectedIndex == 2))
            {
                this.TreeMap1.ItemsLayoutMode = ItemsLayoutModes.SliceAndDiceVertical;
            }
            else
            {
                this.TreeMap1.ItemsLayoutMode = ItemsLayoutModes.Squarified;
            }
        }

        void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            LegendPositionSelectedIndex = (sender as ComboBox).SelectedIndex;
            if (((sender as ComboBox).SelectedIndex == 0))
            {
                this.TreeMap1.LegendSetting.LegendPosition = LegendPositions.Left;
                this.TreeMap1.LegendSetting.LegendGap = 50;
            }
            else if (((sender as ComboBox).SelectedIndex == 1))
            {
                this.TreeMap1.LegendSetting.LegendPosition = LegendPositions.Right;
                this.TreeMap1.LegendSetting.LegendGap = 50;
            }
            else if (((sender as ComboBox).SelectedIndex == 2))
            {
                this.TreeMap1.LegendSetting.LegendPosition = LegendPositions.Top;
                this.TreeMap1.LegendSetting.LegendGap = 150;
            }
            else
            {
                this.TreeMap1.LegendSetting.LegendPosition = LegendPositions.Bottom;
                this.TreeMap1.LegendSetting.LegendGap = 150;
            }
            this.TreeMap1.Refresh();
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
            PopulationDetails.Add(new PopulationDetail() { Continent = "Asia", Country = "Malaysia", Growth = 1, Population = 29672000, StrPopulation  = "29.7 M"});
            PopulationDetails.Add(new PopulationDetail() { Continent = "North America", Country = "United States", Growth = 4, Population = 315645000, StrPopulation = "315.6 M" });
            PopulationDetails.Add(new PopulationDetail() { Continent = "North America", Country = "Mexico", Growth = 2, Population = 112336538, StrPopulation = "112.3 M"});
            PopulationDetails.Add(new PopulationDetail() { Continent = "North America", Country = "Canada", Growth = 1, Population = 35056064, StrPopulation = "35.1 M"});
            PopulationDetails.Add(new PopulationDetail() { Continent = "South America", Country = "Colombia", Growth = 1, Population = 47000000, StrPopulation = "47 M" });
            PopulationDetails.Add(new PopulationDetail() { Continent = "South America", Country = "Brazil", Growth = 3, Population = 193946886, StrPopulation = "193.9 M" });
            PopulationDetails.Add(new PopulationDetail() { Continent = "Africa", Country = "Nigeria", Growth = 2, Population = 170901000, StrPopulation = "170.9 M"});
            PopulationDetails.Add(new PopulationDetail() { Continent = "Africa", Country = "Egypt", Growth = 1, Population = 83661000, StrPopulation = "83 M"});
            PopulationDetails.Add(new PopulationDetail() { Continent = "Europe", Country = "Germany", Growth = 1, Population = 81993000, StrPopulation ="82 M"});
            PopulationDetails.Add(new PopulationDetail() { Continent = "Europe", Country = "France", Growth = 1, Population = 65605000, StrPopulation  = "65.6 M"});
            PopulationDetails.Add(new PopulationDetail() { Continent = "Europe", Country = "UK", Growth = 1, Population = 63181775, StrPopulation = "63.2 M"});

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

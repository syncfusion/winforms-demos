using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using Syncfusion.Windows.Forms;
using Syncfusion.Windows.Forms.BulletGraph;

namespace BulletGraphMeasuresDemo
{
    public partial class Form1 : MetroForm
    {
        #region Private Members

        private readonly BulletGraph bulletGraph1;
        private readonly ComboBox range1StrokeComboBox, range2StrokeComboBox, range3StrokeComboBox;
        private readonly Dictionary<string, Color> colorsList = new Dictionary<string, Color>();

        #endregion

        #region Constructor

        public Form1()
        {
            InitializeComponent();

            bulletGraph1 = new BulletGraph();
            InitializeBulletGraph(bulletGraph1);
            bulletGraph1.Minimum = 0;
            bulletGraph1.Maximum = 1600;
            bulletGraph1.Interval = 200;
            bulletGraph1.FeaturedMeasure = 1400;
            bulletGraph1.ComparativeMeasure = 1072;
            bulletGraph1.Caption = "CIT Revenue YTD \n      $ (millions) \n \n";
            bulletGraph1.QualitativeRanges.Add(new QualitativeRange { RangeCaption = "Bad", RangeEnd = 700, RangeStroke = Color.FromArgb(97, 163, 1) });
            bulletGraph1.QualitativeRanges.Add(new QualitativeRange { RangeCaption = "Good", RangeEnd = 1250, RangeStroke = Color.FromArgb(252, 218, 33) });
            bulletGraph1.QualitativeRanges.Add(new QualitativeRange { RangeCaption = "Excellent", RangeEnd = 1600, RangeStroke = Color.FromArgb(214, 30, 64) });

            var bulletGraphPanel = new Panel();
            bulletGraphPanel.Dock = DockStyle.Fill;
            bulletGraphPanel.Controls.Add(bulletGraph1);

            var splitter = new Splitter();
            splitter.Dock = DockStyle.Left;
            splitter.BackColor = Color.FromArgb(205, 205, 205);

            var range1StrokeLabel = new Label();
            range1StrokeLabel.Width = 250;
            range1StrokeLabel.Margin = new Padding(20, 30, 0, 0);
            range1StrokeLabel.Text = "Range1 Stroke";
            range1StrokeLabel.TextAlign = ContentAlignment.MiddleLeft;
            range1StrokeLabel.Font = new Font("Segoe UI", 12F);

            range1StrokeComboBox = new ComboBox();
            range1StrokeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            range1StrokeComboBox.Width = 250;
            range1StrokeComboBox.Margin = new Padding(25, 20, 0, 0);
            range1StrokeComboBox.SelectedValueChanged += range1StrokeComboBox_SelectedValueChanged;
            range1StrokeComboBox.Font = new Font("Segoe UI", 12F);

            var range2StrokeLabel = new Label();
            range2StrokeLabel.Width = 250;
            range2StrokeLabel.Margin = new Padding(20, 30, 0, 0);
            range2StrokeLabel.Text = "Range2 Stroke";
            range2StrokeLabel.TextAlign = ContentAlignment.MiddleLeft;
            range2StrokeLabel.Font = new Font("Segoe UI", 12F);

            range2StrokeComboBox = new ComboBox();
            range2StrokeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            range2StrokeComboBox.Width = 250;
            range2StrokeComboBox.Margin = new Padding(25, 20, 0, 0);
            range2StrokeComboBox.SelectedValueChanged += range2StrokeComboBox_SelectedValueChanged;
            range2StrokeComboBox.Font = new Font("Segoe UI", 12F);

            var range3StrokeLabel = new Label();
            range3StrokeLabel.Width = 250;
            range3StrokeLabel.Margin = new Padding(20, 30, 0, 0);
            range3StrokeLabel.Text = "Range3 Stroke";
            range3StrokeLabel.TextAlign = ContentAlignment.MiddleLeft;
            range3StrokeLabel.Font = new Font("Segoe UI", 12F);

            range3StrokeComboBox = new ComboBox();
            range3StrokeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            range3StrokeComboBox.Width = 250;
            range3StrokeComboBox.Margin = new Padding(25, 20, 0, 0);
            range3StrokeComboBox.SelectedValueChanged += range3StrokeComboBox_SelectedValueChanged;
            range3StrokeComboBox.Font = new Font("Segoe UI", 12F);

            var optionsFlowLayoutPanel = new FlowLayoutPanel();
            optionsFlowLayoutPanel.Width = 300;
            optionsFlowLayoutPanel.Dock = DockStyle.Fill;
            optionsFlowLayoutPanel.FlowDirection = FlowDirection.TopDown;
            optionsFlowLayoutPanel.Controls.Add(range1StrokeLabel);
            optionsFlowLayoutPanel.Controls.Add(range1StrokeComboBox);
            optionsFlowLayoutPanel.Controls.Add(range2StrokeLabel);
            optionsFlowLayoutPanel.Controls.Add(range2StrokeComboBox);
            optionsFlowLayoutPanel.Controls.Add(range3StrokeLabel);
            optionsFlowLayoutPanel.Controls.Add(range3StrokeComboBox);

            var optionsPanel = new Panel();
            optionsPanel.Dock = DockStyle.Right;
            optionsPanel.Width = 300;
            optionsPanel.Controls.Add(splitter);
            optionsPanel.Controls.Add(optionsFlowLayoutPanel);

            Controls.Add(bulletGraphPanel);
            Controls.Add(optionsPanel);
        }

        #endregion

        #region Initialize BulletGraph

        void InitializeBulletGraph(BulletGraph bulletGraph)
        {
            bulletGraph.BackColor = Color.White;
            bulletGraph.Dock = DockStyle.Fill;
            bulletGraph.Orientation = Orientation.Vertical;
            bulletGraph.MinimumSize = new Size(400, 400);
            bulletGraph.QualitativeRangesSize = 32;
            bulletGraph.MinorTicksPerInterval = 1;
            bulletGraph.MajorTickSize = 14;
            bulletGraph.MinorTickSize = 8;
            bulletGraph.MajorTickStrokeThickness = 2;
            bulletGraph.MinorTickStrokeThickness = 2;
            bulletGraph.LabelFontSize = 10;
            bulletGraph.CaptionFontSize = 12;
            bulletGraph.FeaturedMeasureBarStrokeThickness = 7;
            bulletGraph.ComparativeMeasureSymbolStrokeThickness = 5;
        }

        #endregion

        #region Events

        void range1StrokeComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            if (bulletGraph1 != null && colorsList.Count > 0)
            {
                bulletGraph1.QualitativeRanges[0].RangeStroke = colorsList[range1StrokeComboBox.SelectedValue.ToString()];
                bulletGraph1.Invalidate();
            }
        }

        void range2StrokeComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            if (bulletGraph1 != null && colorsList.Count > 0)
            {
                bulletGraph1.QualitativeRanges[1].RangeStroke = colorsList[range2StrokeComboBox.SelectedValue.ToString()];
                bulletGraph1.Invalidate();
            }
        }

        void range3StrokeComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            if (bulletGraph1 != null && colorsList.Count > 0)
            {
                bulletGraph1.QualitativeRanges[2].RangeStroke = colorsList[range3StrokeComboBox.SelectedValue.ToString()];
                bulletGraph1.Invalidate();
            }
        }

        #endregion

        #region Override Methods

        protected override void OnLoad(EventArgs e)
        {
            Type colorType = typeof(Color);
            IEnumerable<PropertyInfo> propInfos = colorType.GetProperties();
            foreach (var propInfo in propInfos)
            {
                if (propInfo.PropertyType.Name == "Color")
                    colorsList.Add(propInfo.Name, (Color)propInfo.GetValue(propInfo, null));
            }

            range1StrokeComboBox.DataSource = colorsList.Keys.ToList();
            range2StrokeComboBox.DataSource = colorsList.Keys.ToList();
            range3StrokeComboBox.DataSource = colorsList.Keys.ToList();
            range1StrokeComboBox.SelectedIndex = 45;
            range2StrokeComboBox.SelectedIndex = 49;
            range3StrokeComboBox.SelectedIndex = 20;

            base.OnLoad(e);
        }

        #endregion
    }
}

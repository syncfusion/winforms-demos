#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Drawing;
using Syncfusion.Windows.Forms;
using System.Windows.Forms;
using Syncfusion.Windows.Forms.BulletGraph;

namespace GettingStartedDemo
{
    public partial class Form : MetroForm
    {
        #region Private Members

        private readonly ComboBox labelPositionComboBox, tickPositionComboBox;
        private readonly BulletGraph bulletGraph1, bulletGraph2, bulletGraph3;
        private readonly Panel bulletGraphPanel;

        #endregion

        #region Constructor

        public Form()
        {
            InitializeComponent();
            this.SizeChanged += Form_SizeChanged;
            var headerLabel = new Label();
            headerLabel.Dock = DockStyle.Top;
            headerLabel.Height = (int)DpiAware.LogicalToDeviceUnits(80);
            headerLabel.Text = "2005 YTD Actual Vs Budget";
            headerLabel.TextAlign = ContentAlignment.MiddleCenter;
            headerLabel.Font = new Font("Segoe UI", 18F);

            bulletGraph1 = new BulletGraph();
            InitializeBulletGraph(bulletGraph1);
            bulletGraph1.Location = new Point((int)DpiAware.LogicalToDeviceUnits(20), (int)DpiAware.LogicalToDeviceUnits(80));
            bulletGraph1.Minimum = 0;
            bulletGraph1.Maximum = 300;
            bulletGraph1.Interval = 50;
            bulletGraph1.FeaturedMeasure = 270;
            bulletGraph1.ComparativeMeasure = 250;
            bulletGraph1.Caption = "     Revenue \n U.S. $ (1,000s)";
            bulletGraph1.QualitativeRanges.Add(new QualitativeRange { RangeCaption = "Bad", RangeEnd = 150, RangeStroke = Color.FromArgb(235, 235, 235) });
            bulletGraph1.QualitativeRanges.Add(new QualitativeRange { RangeCaption = "Good", RangeEnd = 225, RangeStroke = Color.FromArgb(216, 216, 216) });
            bulletGraph1.QualitativeRanges.Add(new QualitativeRange { RangeCaption = "Excellent", RangeEnd = 300, RangeStroke = Color.FromArgb(127, 127, 127) });

            bulletGraph2 = new BulletGraph();
            InitializeBulletGraph(bulletGraph2);
            bulletGraph2.Location = new Point((int)DpiAware.LogicalToDeviceUnits(20), (int)DpiAware.LogicalToDeviceUnits(230));
            bulletGraph2.Minimum = 0;
            bulletGraph2.Maximum = 150;
            bulletGraph2.Interval = 25;
            bulletGraph2.FeaturedMeasure = 45;
            bulletGraph2.ComparativeMeasure = 30;
            bulletGraph2.Caption = "     Expenses \n U.S. $ (1,000s)";
            bulletGraph2.QualitativeRanges.Add(new QualitativeRange { RangeCaption = "Bad", RangeEnd = 40, RangeStroke = Color.FromArgb(235, 235, 235) });
            bulletGraph2.QualitativeRanges.Add(new QualitativeRange { RangeCaption = "Good", RangeEnd = 80, RangeStroke = Color.FromArgb(216, 216, 216) });
            bulletGraph2.QualitativeRanges.Add(new QualitativeRange { RangeCaption = "Excellent", RangeEnd = 150, RangeStroke = Color.FromArgb(127, 127, 127) });

            bulletGraph3 = new BulletGraph();
            InitializeBulletGraph(bulletGraph3);
            bulletGraph3.Location = new Point((int)DpiAware.LogicalToDeviceUnits(20), (int)DpiAware.LogicalToDeviceUnits(380));
            bulletGraph3.Minimum = 0;
            bulletGraph3.Maximum = 30;
            bulletGraph3.Interval = 5;
            bulletGraph3.FeaturedMeasure = 22.5;
            bulletGraph3.ComparativeMeasure = 27;
            bulletGraph3.Caption = "     Profit \n Percentage(%)";
            bulletGraph3.QualitativeRanges.Add(new QualitativeRange { RangeCaption = "Bad", RangeEnd = 20, RangeStroke = Color.FromArgb(235, 235, 235) });
            bulletGraph3.QualitativeRanges.Add(new QualitativeRange { RangeCaption = "Good", RangeEnd = 25, RangeStroke = Color.FromArgb(216, 216, 216) });
            bulletGraph3.QualitativeRanges.Add(new QualitativeRange { RangeCaption = "Excellent", RangeEnd = 30, RangeStroke = Color.FromArgb(127, 127, 127) });

            bulletGraphPanel = new Panel();
            bulletGraphPanel.Dock = DockStyle.Fill;
            bulletGraphPanel.Controls.Add(headerLabel);
            bulletGraphPanel.Controls.Add(bulletGraph1);
            bulletGraphPanel.Controls.Add(bulletGraph2);
            bulletGraphPanel.Controls.Add(bulletGraph3);

            var splitter = new Splitter();
            splitter.Dock = DockStyle.Left;
            splitter.BackColor = Color.FromArgb(205, 205, 205);

            var flowDirectionLabel = new Label();
            flowDirectionLabel.Width = (int)DpiAware.LogicalToDeviceUnits(250);
            flowDirectionLabel.Height = (int)DpiAware.LogicalToDeviceUnits(flowDirectionLabel.Height);
            flowDirectionLabel.Margin = new Padding(20, 30, 0, 0);
            flowDirectionLabel.Text = "Flow Direction";
            flowDirectionLabel.TextAlign = ContentAlignment.MiddleLeft;
            flowDirectionLabel.Font = new Font("Segoe UI", 12F);

            var flowDirectionComboBox = new ComboBox();
            flowDirectionComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            flowDirectionComboBox.Width = (int)DpiAware.LogicalToDeviceUnits(250);
            flowDirectionComboBox.Margin = new Padding(25, 20, 0, 0);
            flowDirectionComboBox.DataSource = Enum.GetValues(typeof(BulletGraphFlowDirection));
            flowDirectionComboBox.SelectedValueChanged += flowDirectionComboBox_SelectedValueChanged;
            flowDirectionComboBox.Font = new Font("Segoe UI", 12F);

            var labelPositionLabel = new Label();
            labelPositionLabel.Width = (int)DpiAware.LogicalToDeviceUnits(250);
            labelPositionLabel.Height = (int)DpiAware.LogicalToDeviceUnits(labelPositionLabel.Height);
            labelPositionLabel.Margin = new Padding(20, 30, 0, 0);
            labelPositionLabel.Text = "Label Position";
            labelPositionLabel.TextAlign = ContentAlignment.MiddleLeft;
            labelPositionLabel.Font = new Font("Segoe UI", 12F);

            labelPositionComboBox = new ComboBox();
            labelPositionComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            labelPositionComboBox.Width = (int)DpiAware.LogicalToDeviceUnits(250);
            labelPositionComboBox.Margin = new Padding(25, 20, 0, 0);
            labelPositionComboBox.DataSource = Enum.GetValues(typeof(BulletGraphLabelsPosition));
            labelPositionComboBox.SelectedValueChanged += labelPositionComboBox_SelectedValueChanged;
            labelPositionComboBox.Font = new Font("Segoe UI", 12F);

            var tickPositionLabel = new Label();
            tickPositionLabel.Width = (int)DpiAware.LogicalToDeviceUnits(250);
            tickPositionLabel.Height = (int)DpiAware.LogicalToDeviceUnits(tickPositionLabel.Height);
            tickPositionLabel.Margin = new Padding(20, 30, 0, 0);
            tickPositionLabel.Text = "Tick Position";
            tickPositionLabel.TextAlign = ContentAlignment.MiddleLeft;
            tickPositionLabel.Font = new Font("Segoe UI", 12F);

            tickPositionComboBox = new ComboBox();
            tickPositionComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            tickPositionComboBox.Width = (int)DpiAware.LogicalToDeviceUnits(250);
            tickPositionComboBox.Margin = new Padding(25, 20, 0, 0);
            tickPositionComboBox.DataSource = Enum.GetValues(typeof(BulletGraphTicksPosition));
            tickPositionComboBox.SelectedValueChanged += tickPositionComboBox_SelectedValueChanged;
            tickPositionComboBox.Font = new Font("Segoe UI", 12F);

            var captionPositionLabel = new Label();
            captionPositionLabel.Width = (int)DpiAware.LogicalToDeviceUnits(250);
            captionPositionLabel.Height = (int)DpiAware.LogicalToDeviceUnits(captionPositionLabel.Height);
            captionPositionLabel.Margin = new Padding(20, 30, 0, 0);
            captionPositionLabel.Text = "Caption Position";
            captionPositionLabel.TextAlign = ContentAlignment.MiddleLeft;
            captionPositionLabel.Font = new Font("Segoe UI", 12F);

            var captionPositionComboBox = new ComboBox();
            captionPositionComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            captionPositionComboBox.Width = (int)DpiAware.LogicalToDeviceUnits(250);
            captionPositionComboBox.Margin = new Padding(25, 20, 0, 0);
            captionPositionComboBox.DataSource = Enum.GetValues(typeof(BulletGraphCaptionPosition));
            captionPositionComboBox.SelectedValueChanged += captionPositionComboBox_SelectedValueChanged;
            captionPositionComboBox.Font = new Font("Segoe UI", 12F);

            var optionsFlowLayoutPanel = new FlowLayoutPanel();
            optionsFlowLayoutPanel.Width = (int)DpiAware.LogicalToDeviceUnits(300);
            optionsFlowLayoutPanel.Dock = DockStyle.Fill;
            optionsFlowLayoutPanel.FlowDirection = FlowDirection.TopDown;
            optionsFlowLayoutPanel.Controls.Add(flowDirectionLabel);
            optionsFlowLayoutPanel.Controls.Add(flowDirectionComboBox);
            optionsFlowLayoutPanel.Controls.Add(labelPositionLabel);
            optionsFlowLayoutPanel.Controls.Add(labelPositionComboBox);
            optionsFlowLayoutPanel.Controls.Add(tickPositionLabel);
            optionsFlowLayoutPanel.Controls.Add(tickPositionComboBox);
            optionsFlowLayoutPanel.Controls.Add(captionPositionLabel);
            optionsFlowLayoutPanel.Controls.Add(captionPositionComboBox);

            var optionsPanel = new Panel();
            optionsPanel.Dock = DockStyle.Right;
            optionsPanel.Width = (int)DpiAware.LogicalToDeviceUnits(300);
            optionsPanel.Controls.Add(splitter);
            optionsPanel.Controls.Add(optionsFlowLayoutPanel);

            Controls.Add(bulletGraphPanel);
            Controls.Add(optionsPanel);
        }

        private void Form_SizeChanged(object sender, EventArgs e)
        {
            bulletGraph1.Location = new Point((this.bulletGraphPanel.Width / 2) - (this.bulletGraph1.Width / 2), (int)DpiAware.LogicalToDeviceUnits(80));
            bulletGraph2.Location = new Point((this.bulletGraphPanel.Width / 2) - (this.bulletGraph2.Width / 2), (int)DpiAware.LogicalToDeviceUnits(230));
            bulletGraph3.Location = new Point((this.bulletGraphPanel.Width / 2) - (this.bulletGraph3.Width / 2), (int)DpiAware.LogicalToDeviceUnits(380));
        }

        #endregion

        #region Initialize BulletGraph

        void InitializeBulletGraph(BulletGraph bulletGraph)
        {
            bulletGraph.BackColor = Color.White;
            bulletGraph.MinimumSize = GetPreferredSize(new Size(600, 150));
            bulletGraph.QuantitativeScaleLength = (int)DpiAware.LogicalToDeviceUnits(400);
            bulletGraph.QualitativeRangesSize = (int)DpiAware.LogicalToDeviceUnits(32);
            bulletGraph.MinorTicksPerInterval = (int)DpiAware.LogicalToDeviceUnits(1);
            bulletGraph.MajorTickSize = (int)DpiAware.LogicalToDeviceUnits(14);
            bulletGraph.MinorTickSize = (int)DpiAware.LogicalToDeviceUnits(8);
            bulletGraph.MajorTickStrokeThickness = (int)DpiAware.LogicalToDeviceUnits(2);
            bulletGraph.MinorTickStrokeThickness = (int)DpiAware.LogicalToDeviceUnits(2);
            bulletGraph.LabelFontSize = 10;
            bulletGraph.CaptionFontSize = 12;
            bulletGraph.FeaturedMeasureBarStrokeThickness = (int)DpiAware.LogicalToDeviceUnits(7);
            bulletGraph.ComparativeMeasureSymbolStrokeThickness = (int)DpiAware.LogicalToDeviceUnits(5);
        }

        #endregion

        #region Events

        void flowDirectionComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            if (bulletGraph1 != null)
                bulletGraph1.FlowDirection = (BulletGraphFlowDirection)((sender as ComboBox).SelectedValue);
            if (bulletGraph2 != null)
                bulletGraph2.FlowDirection = (BulletGraphFlowDirection)((sender as ComboBox).SelectedValue);
            if (bulletGraph3 != null)
                bulletGraph3.FlowDirection = (BulletGraphFlowDirection)((sender as ComboBox).SelectedValue);
        }

        void labelPositionComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            if (bulletGraph1 != null)
                bulletGraph1.LabelPosition = (BulletGraphLabelsPosition)((sender as ComboBox).SelectedValue);
            if (bulletGraph2 != null)
                bulletGraph2.LabelPosition = (BulletGraphLabelsPosition)((sender as ComboBox).SelectedValue);
            if (bulletGraph3 != null)
                bulletGraph3.LabelPosition = (BulletGraphLabelsPosition)((sender as ComboBox).SelectedValue);
        }

        void tickPositionComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            if (bulletGraph1 != null)
                bulletGraph1.TickPosition = (BulletGraphTicksPosition)((sender as ComboBox).SelectedValue);
            if (bulletGraph2 != null)
                bulletGraph2.TickPosition = (BulletGraphTicksPosition)((sender as ComboBox).SelectedValue);
            if (bulletGraph3 != null)
                bulletGraph3.TickPosition = (BulletGraphTicksPosition)((sender as ComboBox).SelectedValue);
        }

        void captionPositionComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            if (bulletGraph1 != null)
                bulletGraph1.CaptionPosition = (BulletGraphCaptionPosition)((sender as ComboBox).SelectedValue);
            if (bulletGraph2 != null)
                bulletGraph2.CaptionPosition = (BulletGraphCaptionPosition)((sender as ComboBox).SelectedValue);
            if (bulletGraph3 != null)
                bulletGraph3.CaptionPosition = (BulletGraphCaptionPosition)((sender as ComboBox).SelectedValue);
        }

        #endregion

        #region Override Methods

        protected override void OnLoad(EventArgs e)
        {
            labelPositionComboBox.SelectedIndex = 1;
            tickPositionComboBox.SelectedIndex = 1;
            base.OnLoad(e);
        }

        public override Size GetPreferredSize(Size proposedSize)
        {
            int width = (int)DpiAware.LogicalToDeviceUnits(proposedSize.Width);
            int height = (int)DpiAware.LogicalToDeviceUnits(proposedSize.Height);
            return new Size(width, height);
        }

        #endregion
    }
}

#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using DemoCommon.Grid;
using Syncfusion.WinForms.SmithChart;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Customization
{
    public partial class Form1 : GridDemoForm
    {       
        ViewModel vm = new ViewModel();
        public Form1()
        {
            InitializeComponent();   
            
            LineSeries series = new LineSeries();
            series.MarkerVisible = true;
            series.LegendText = "Transmission1";
            series.DataSource = vm.Trace1;
            series.ResistanceMember = "Resistance";
            series.ReactanceMember = "Reactance";
            series.TooltipVisible = true;
            sfSmithChart1.Series.Add(series);
           
            LineSeries series1 = new LineSeries();
            series1.MarkerVisible = true;         
            series1.LegendText = "Transmission2";
            series1.DataSource = vm.Trace2;
            series1.ResistanceMember = "Resistance";
            series1.ReactanceMember = "Reactance";
            series1.TooltipVisible = true;
            sfSmithChart1.Series.Add(series1);            

            sfSmithChart1.RadialAxis.MinorGridlinesVisible = true;           
            sfSmithChart1.HorizontalAxis.MinorGridlinesVisible = true;          

            sfSmithChart1.ThemeName = "Office2016White";
            sfSmithChart1.Legend.Visible = true;
        }

        private void PaletteChanged(object sender, EventArgs e)
        {
            var combo = sender as ComboBox;
            if (combo.SelectedIndex == 0)
                sfSmithChart1.ColorModel.Palette = Syncfusion.WinForms.SmithChart.ChartColorPalette.Metro;
            else if (combo.SelectedIndex == 1)
                sfSmithChart1.ColorModel.Palette = Syncfusion.WinForms.SmithChart.ChartColorPalette.WarmCold;
            else if (combo.SelectedIndex == 2)
                sfSmithChart1.ColorModel.Palette = Syncfusion.WinForms.SmithChart.ChartColorPalette.Triad;
            else if (combo.SelectedIndex == 3)
                sfSmithChart1.ColorModel.Palette = Syncfusion.WinForms.SmithChart.ChartColorPalette.Colorful;
            else if (combo.SelectedIndex == 4)
                sfSmithChart1.ColorModel.Palette = Syncfusion.WinForms.SmithChart.ChartColorPalette.Nature;           
        }

        private void LegendPosition(object sender, EventArgs e)
        {
            var combo = sender as ComboBox;
            if (combo.SelectedIndex == 0)
                sfSmithChart1.Legend.DockPosition = Syncfusion.WinForms.SmithChart.ChartDockPosition.Top;
            else if (combo.SelectedIndex == 1)
                sfSmithChart1.Legend.DockPosition = Syncfusion.WinForms.SmithChart.ChartDockPosition.Left;
            else if (combo.SelectedIndex == 2)
                sfSmithChart1.Legend.DockPosition = Syncfusion.WinForms.SmithChart.ChartDockPosition.Right;
            else if (combo.SelectedIndex == 3)
                sfSmithChart1.Legend.DockPosition = Syncfusion.WinForms.SmithChart.ChartDockPosition.Bottom;
            else
                sfSmithChart1.Legend.DockPosition = Syncfusion.WinForms.SmithChart.ChartDockPosition.Floating;
        }

        private void RadialMinor(object sender, EventArgs e)
        {
            var check = sender as CheckBox;
            if (check.Checked)
                sfSmithChart1.RadialAxis.MinorGridlinesVisible = true;
            else
                sfSmithChart1.RadialAxis.MinorGridlinesVisible = false;
        }

        private void HorizontalMinor(object sender, EventArgs e)
        {
            var check = sender as CheckBox;
            if (check.Checked)
                sfSmithChart1.HorizontalAxis.MinorGridlinesVisible = true;
            else
                sfSmithChart1.HorizontalAxis.MinorGridlinesVisible = false;
        }

        private void Radius(object sender, EventArgs e)
        {
            var combo = sender as ComboBox;
            if (combo.SelectedIndex == 0)
                sfSmithChart1.Radius = 0.1f;
            else if(combo.SelectedIndex==1)
                sfSmithChart1.Radius = 0.2f;
            else if (combo.SelectedIndex == 2)
                sfSmithChart1.Radius = 0.3f;
            else if (combo.SelectedIndex == 3)
                sfSmithChart1.Radius = 0.4f;
            else if (combo.SelectedIndex == 4)
                sfSmithChart1.Radius = 0.5f;
            else if (combo.SelectedIndex == 5)
                sfSmithChart1.Radius = 0.6f;
            else if (combo.SelectedIndex == 6)
                sfSmithChart1.Radius = 0.7f;
            else if (combo.SelectedIndex == 7)
                sfSmithChart1.Radius = 0.8f;
            else if (combo.SelectedIndex == 8)
                sfSmithChart1.Radius = 0.9f;
            else if (combo.SelectedIndex == 9)
                sfSmithChart1.Radius = 1f;
        }

        private void VisualStyleChanged(object sender, EventArgs e)
        {
            var combo = sender as ComboBox;
            if (combo.SelectedIndex == 0)
                sfSmithChart1.ThemeName = "Office2016White";
            else if (combo.SelectedIndex == 1)
                sfSmithChart1.ThemeName = "Office2016DarkGray";
            else if (combo.SelectedIndex == 2)
                sfSmithChart1.ThemeName = "Office2016Colorful";
            else
                sfSmithChart1.ThemeName = "Office2016Black";
        }
    }

    public class Model
    {
        public double Resistance { get; set; }

        public double Reactance { get; set; }
    }

    public class ViewModel
    {
        public ViewModel()
        {
            Trace1 = new ObservableCollection<Model>();

            Trace1.Add(new Model() { Resistance = 0, Reactance = 0.05 });
            Trace1.Add(new Model() { Resistance = 0.3, Reactance = 0.1 });
            Trace1.Add(new Model() { Resistance = 0.5, Reactance = 0.2 });
            Trace1.Add(new Model() { Resistance = 1.0, Reactance = 0.4 });
            Trace1.Add(new Model() { Resistance = 1.5, Reactance = 0.5 });
            Trace1.Add(new Model() { Resistance = 2.0, Reactance = 0.5 });
            Trace1.Add(new Model() { Resistance = 2.5, Reactance = 0.4 });
            Trace1.Add(new Model() { Resistance = 3.5, Reactance = 0.0 });
            Trace1.Add(new Model() { Resistance = 4.5, Reactance = -0.5 });
            Trace1.Add(new Model() { Resistance = 5, Reactance = -1.0 });
            Trace1.Add(new Model() { Resistance = 6, Reactance = -1.5 });
            Trace1.Add(new Model() { Resistance = 7, Reactance = -2.5 });
            Trace1.Add(new Model() { Resistance = 8, Reactance = -3.5 });
            Trace1.Add(new Model() { Resistance = 9, Reactance = -4.5 });
            Trace1.Add(new Model() { Resistance = 10, Reactance = -10 });
            Trace1.Add(new Model() { Resistance = 20, Reactance = -50 });

            Trace2 = new ObservableCollection<Model>();

            Trace2.Add(new Model() { Resistance = 0, Reactance = 0.15 });
            Trace2.Add(new Model() { Resistance = 0.3, Reactance = 0.2 });
            Trace2.Add(new Model() { Resistance = 0.5, Reactance = 0.4 });
            Trace2.Add(new Model() { Resistance = 1.0, Reactance = 0.8 });
            Trace2.Add(new Model() { Resistance = 1.5, Reactance = 1.0 });
            Trace2.Add(new Model() { Resistance = 2.0, Reactance = 1.2 });
            Trace2.Add(new Model() { Resistance = 2.5, Reactance = 1.3 });
            Trace2.Add(new Model() { Resistance = 3.5, Reactance = 1.6 });
            Trace2.Add(new Model() { Resistance = 4.5, Reactance = 2.0 });
            Trace2.Add(new Model() { Resistance = 6, Reactance = 4.5 });
            Trace2.Add(new Model() { Resistance = 8, Reactance = 6 });
            Trace2.Add(new Model() { Resistance = 10, Reactance = 25 });
        }

        public ObservableCollection<Model> Trace1 { get; set; }
        public ObservableCollection<Model> Trace2 { get; set; }
    }
}

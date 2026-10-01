#region Copyright Syncfusion Inc. 2001 - 2019
// Copyright Syncfusion Inc. 2001 - 2019. All rights reserved.
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
using Syncfusion.Windows.Forms.Tools;
using Syncfusion.Windows.Forms.Chart;
using Syncfusion.Windows.Forms;
using Syncfusion.Drawing;
using System.IO;

namespace ChartTemplate_2005
{
    public partial class Form1 : Syncfusion.Windows.Forms.MetroForm
    {
        Form2 frm = new Form2();
        string filePath;
        string defaultPath;
        bool saveChartAppearance = true;
        #region Constructor
        public Form1()
        {
            BorderColor = Color.FromArgb(0xFF, 0xCD, 0xCD, 0xCD);
            BorderThickness = 3;
            CaptionBarHeight = 75;
            CaptionBarColor = Color.FromArgb(0xFF, 0x1B, 0xA1, 0xE2);
            CaptionFont = new Font("Segoe UI", 22.0f);
            CaptionForeColor = Color.White;
            CaptionAlign = HorizontalAlignment.Left;
            ShowIcon = false;
            CaptionButtonColor = Color.White;
            CaptionButtonHoverColor = Color.White; 
            InitializeComponent();

            this.propertyGrid1.SelectedObject = this.chartControl1;

            this.ActiveControl = this.buttonAdv1;
           // this.buttonAdv1.State = ButtonAdvState.Pressed;
            frm.buttonAdv1.Click += new EventHandler(buttonAdv1_Click);
            frm.buttonAdv2.Click += new EventHandler(buttonAdv2_Click);

            //Copies the required template files to the Debug folder from Template folder
            DirectoryInfo di = new DirectoryInfo(Application.StartupPath);
            di = di.Parent.Parent;
#if NETCORE
            filePath = di.FullName + @"\..\..\Templates";
#else
             filePath = di.FullName + @"\..\Templates";
#endif
            defaultPath = Application.StartupPath.ToString();
            DirectoryInfo dir = new DirectoryInfo(filePath);
            FileInfo[] files = dir.GetFiles("*.*");
            foreach (FileInfo file in files)
            {
                Char[] ch = new Char[] { 'D', 'e', 'b', 'u', 'g' };
                string newFile = file.Name.TrimStart(ch);
                defaultPath = Application.StartupPath.ToString() + "\\" + newFile;
                file.CopyTo(defaultPath, true);
            }
            InitializeChart();
            ChartAppearance.ApplyChartStyles(this.chartControl1);

            this.chartControl1.Dock = DockStyle.Fill;
        }
#endregion

#region InitializeChartData
        public void InitializeChart()
        {
            // Initialize ChartSeries
            ChartSeries series1 = new ChartSeries("Hard Disk");

            series1.Points.Add(1, 187);
            series1.Points.Add(2, 151);
            series1.Points.Add(3, 180);
            series1.Points.Add(4, 206);
            series1.Points.Add(5, 122);
            series1.Points.Add(6, 31);
            series1.Points.Add(7, 189);
            series1.Points.Add(8, 54);
            series1.Points.Add(9, 181);
            series1.Points.Add(10, 201);
            series1.Points.Add(11, 391);
            series1.Points.Add(12, 311);

            series1.Styles[0].Text = string.Format("{0}", series1.Points[0].YValues[0]);
            series1.Styles[1].Text = string.Format("{0}", series1.Points[1].YValues[0]);
            series1.Styles[2].Text = string.Format("{0}", series1.Points[2].YValues[0]);
            series1.Styles[3].Text = string.Format("{0}", series1.Points[3].YValues[0]);
            series1.Styles[4].Text = string.Format("{0}", series1.Points[4].YValues[0]);
            series1.Style.DisplayText = true;
            series1.Style.TextOrientation = ChartTextOrientation.Up;

            this.chartControl1.Series.Add(series1);

            ChartSeries series2 = new ChartSeries("Monitor");
            series2.Points.Add(1, 256);
            series2.Points.Add(2, 451);
            series2.Points.Add(3, 382);
            series2.Points.Add(4, 437);
            series2.Points.Add(5, 321);
            series2.Points.Add(6, 234);
            series2.Points.Add(7, 425);
            series2.Points.Add(8, 257);
            series2.Points.Add(9, 382);
            series2.Points.Add(10, 301);
            series2.Points.Add(11, 472);
            series2.Points.Add(12, 421);
            series2.Style.DisplayText = true;
            series2.Style.TextOrientation = ChartTextOrientation.Up;
            series2.Styles[0].Text = string.Format("{0}", series1.Points[0].YValues[0]);
            series2.Styles[1].Text = string.Format("{0}", series1.Points[1].YValues[0]);
            series2.Styles[2].Text = string.Format("{0}", series1.Points[2].YValues[0]);
            series2.Styles[3].Text = string.Format("{0}", series1.Points[3].YValues[0]);
            series2.Styles[4].Text = string.Format("{0}", series1.Points[4].YValues[0]);


            this.chartControl1.Series.Add(series2);
            chartControl1.ColumnDrawMode = ChartColumnDrawMode.ClusteredMode;
            chartControl1.PrimaryXAxis.RangeType = ChartAxisRangeType.Set;
            chartControl1.PrimaryXAxis.Range = new MinMaxInfo(0, 13, 1);
            ChartTemplate ct = new ChartTemplate(typeof(ChartControl));
            ct.Load("Column_Square.xml");
            ct.Apply(this.chartControl1);
            chartControl1.Series3D = false;
        }

#endregion

#region Save Template
        int templateCount = 0;
        string saveTemplateFile = "";
        private void buttonAdv1_Click(object sender, EventArgs e)
        {
            //Saves file to the same template
            if (frm.radioButton1.Checked)
            {
                SaveTemplate(currentTemplate);
            }
            //Saves file to a new template
            if (frm.radioButton2.Checked)
            {
                if (templateCount < 2)
                {
                    if (templateCount == 0)
                    {
                        Templatebutton.Visible = true;                
                        this.buttonAdv7.Visible = true;
                        this.buttonAdv11.Visible = true;
                    }
                    if (templateCount == 1)
                    {
                        Templatebutton.Visible = true;    
                        this.buttonAdv10.Visible = true;
                        this.buttonAdv12.Visible = true;
                    }
                    templateCount = templateCount + 1;


                    saveTemplateFile = "Template" + templateCount.ToString() + ".xml";
                    SaveTemplate(saveTemplateFile);
                }
                else
                {
                    MessageBox.Show("Programmed to add only two user defined templates");
                }
            }
            frm.Hide();

        }

        private void SaveTemplate(string templateFileName)
        {
            if (File.Exists(templateFileName))
                File.Delete(templateFileName);
            ChartControl chart = this.chartControl1;
            ChartTemplate template = new ChartTemplate(typeof(ChartControl));
            if (saveChartAppearance)
            {
                template.Scan(chart);
                template.Save(templateFileName);
            }
            Stream stream = new FileStream(templateFileName, FileMode.OpenOrCreate);
            for (int i = 0; i < chart.Series.Count; i++)
            {
                template = new ChartTemplate(chart.Series[i].GetType());
                template.ScanSeries(chart.Series[i]);
                template.SaveSeries(stream);
            }
            stream.Dispose();
            stream.Close();
        }
        private void buttonAdv2_Click(object sender, EventArgs e)
        {
            frm.Hide();
        }

        private void SaveTemplate_Click(object sender, EventArgs e)
        {

            frm.Show();

        }
#endregion

#region ContextMenu - Copy To clipboard
        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string cc = "";
            switch (this.contextMenuStrip1.SourceControl.Name)
            {
                case "buttonAdv1":
                    cc = Application.StartupPath.ToString() + "\\Column_Cylinder.xml";

                    break;
                case "buttonAdv2":
                    cc = Application.StartupPath.ToString() + "\\Column_Square.xml";
                    break;
                case "buttonAdv3":
                    cc = Application.StartupPath.ToString() + "\\Area.xml";
                    break;
                case "buttonAdv4":
                    cc = Application.StartupPath.ToString() + "\\Area_3D.xml";
                    break;
                case "buttonAdv5":
                    cc = Application.StartupPath.ToString() + "\\Line.xml";
                    break;
                case "buttonAdv6":
                    cc = Application.StartupPath.ToString() + "\\Line_3D.xml";
                    break;
                case "buttonAdv7":
                    cc = Application.StartupPath.ToString() + "\\Template1.xml";
                    break;
                case "buttonAdv10":
                    cc = Application.StartupPath.ToString() + "\\Template2.xml";
                    break;
            }
            Clipboard.SetDataObject(cc, true);
        }
#endregion

#region Load template
        string currentTemplate = "Column_Square.xml";
        private void ChartType_Click(object sender, EventArgs e)
        {
            ButtonAdv chartButton = sender as ButtonAdv;
            this.buttonAdv1.Enabled = true;
            this.buttonAdv2.Enabled = true;
            this.buttonAdv3.Enabled = true;
            this.buttonAdv4.Enabled = true;
            this.buttonAdv5.Enabled = true;
            this.buttonAdv6.Enabled = true;
            this.buttonAdv7.Enabled = true;
            this.buttonAdv10.Enabled = true;
            string filePath = Application.StartupPath.ToString();
            foreach (Button buttonAdv in this.panel3.Controls)
            {
                //buttonAdv.State = ButtonAdvState.Default;
                buttonAdv.Refresh();
            }
            if (chartButton == this.buttonAdv1)
            {
#region Control settings

                this.toolStripStatusLabel1.Text = filePath + "\\Column_Cylinder.xml";
                currentTemplate = "Column_Cylinder.xml";
                //this.buttonAdv1.State = ButtonAdvState.Pressed;
                this.buttonAdv1.Enabled = false;
#endregion

            }
            if (chartButton == this.buttonAdv2)
            {
#region Control settings

                this.toolStripStatusLabel1.Text = filePath + "\\Column_Square.xml";
               // this.buttonAdv2.State = ButtonAdvState.Pressed;
                this.buttonAdv2.Enabled = false;
                currentTemplate = "Column_Square.xml";
#endregion

            }
            if (chartButton == this.buttonAdv3)
            {
#region Control settings

                this.toolStripStatusLabel1.Text = filePath + "\\Area.xml";
                //this.buttonAdv3.State = ButtonAdvState.Pressed;
                this.buttonAdv3.Enabled = false;
                currentTemplate = "Area.xml";
#endregion

            }
            if (chartButton == this.buttonAdv4)
            {
#region Control settings

                this.toolStripStatusLabel1.Text = filePath + "\\Area_3D.xml";
               // this.buttonAdv4.State = ButtonAdvState.Pressed;
                this.buttonAdv4.Enabled = false;
                currentTemplate = "Area_3D.xml";
#endregion

            }
            if (chartButton == this.buttonAdv5)
            {
#region Control settings

                this.toolStripStatusLabel1.Text = filePath + "\\Line.xml";
               // this.buttonAdv5.State = ButtonAdvState.Pressed;
                this.buttonAdv5.Enabled = false;
                currentTemplate = "Line.xml";
#endregion

            }
            if (chartButton == this.buttonAdv6)
            {
#region Control settings

                this.toolStripStatusLabel1.Text = filePath + "\\Line_3D.xml";
               // this.buttonAdv6.State = ButtonAdvState.Pressed;
                this.buttonAdv6.Enabled = false;
                currentTemplate = "Line_3D.xml";
#endregion

            }
            if (chartButton == this.buttonAdv7)
            {
#region Control settings

                this.toolStripStatusLabel1.Text = filePath + "\\Template1.xml";
               // this.buttonAdv7.State = ButtonAdvState.Pressed;
                currentTemplate = "Template1.xml";
                this.buttonAdv7.Enabled = false;
#endregion

            }
            if (chartButton == this.buttonAdv10)
            {
#region Control settings
                this.toolStripStatusLabel1.Text = filePath + "\\Template2.xml";
               // this.buttonAdv10.State = ButtonAdvState.Pressed;
                currentTemplate = "Template2.xml";
                this.buttonAdv10.Enabled = false;
#endregion

            }

            ChartTemplate.Load(this.chartControl1, currentTemplate);

#region Control settings

            this.propertyGrid1.Refresh();
#endregion
        }
#endregion

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            saveChartAppearance = (sender as CheckBox).Checked;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            ChartTemplate.StoreSeriesData = (sender as CheckBox).Checked;
        }
        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            ChartTemplate.StoreSeriesStyle = (sender as CheckBox).Checked;
        }
    }
}
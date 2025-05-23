#region Copyright Syncfusion Inc. 2001 - 2011
// Copyright Syncfusion Inc. 2001 - 2011. All rights reserved.
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
using Syncfusion.Windows.Forms;
using Syncfusion.Windows.Forms.Chart;
using Syncfusion.Windows.Forms.Tools;

namespace SparklineControl_2008
{
    public partial class Form1 : MetroForm
    {
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
        }
        private double[,] intArray;
        SparkLine[,] sparkline = new SparkLine[14, 3];

        private void Form1_Load(object sender, EventArgs e)
        {
            ToolStripControlHost host2 = new ToolStripControlHost(this.panel2);
            this.toolStripEx4.Items.Add(host2);
            ToolStripControlHost host1 = new ToolStripControlHost(this.panel1);
            this.toolStripEx4.Items.Add(host1);
            this.gridControl1.Rows.DefaultSize = 30;
            this.gridControl1.Cols.DefaultSize = 95;
            this.gridControl1.ColWidths[10] = 160;
            this.ribbonControlAdv1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
| System.Windows.Forms.AnchorStyles.Left)
| System.Windows.Forms.AnchorStyles.Right)));
            SparkLineSource();
            this.toolStripEx1.LauncherMouseEnter += toolStripEx1_LauncherMouseEnter;
            this.toolStripEx1.LauncherMouseLeave += toolStripEx1_LauncherMouseLeave;
            this.toolStripEx2.LauncherMouseEnter += toolStripEx1_LauncherMouseEnter;
            this.toolStripEx2.LauncherMouseLeave += toolStripEx1_LauncherMouseLeave;
            this.toolStripEx3.LauncherMouseEnter += toolStripEx1_LauncherMouseEnter;
            this.toolStripEx3.LauncherMouseLeave += toolStripEx1_LauncherMouseLeave;
            this.toolStripEx4.LauncherMouseEnter += toolStripEx1_LauncherMouseEnter;
            this.toolStripEx4.LauncherMouseLeave += toolStripEx1_LauncherMouseLeave;
        }

        void toolStripEx1_LauncherMouseLeave(object o, EventArgs e)
        {
            this.toolTip1.Hide(o as ToolStripEx);
        }

        void toolStripEx1_LauncherMouseEnter(object o, MouseEventArgs e)
        {
            ToolStripEx tool = o as ToolStripEx;
            switch (tool.Text)
            {
                case "Type":
                    this.toolTip1.ToolTipTitle = "Sparkline Type";
                    this.toolTip1.Show("Type of sparkline", o as ToolStripEx, e.Location);
                    break;
                case "Marker":
                    this.toolTip1.ToolTipTitle = "Marker";
                    this.toolTip1.Show("Display or hide marker for high, low, start, \nend and negative points or all points", o as ToolStripEx, e.Location);
                    break;
                case "Style":
                    this.toolTip1.ToolTipTitle = "Style";
                    this.toolTip1.Show("Styles for spark line", o as ToolStripEx, e.Location);
                    break;
                case "Custom Color":
                    this.toolTip1.ToolTipTitle = "Marker";
                    this.toolTip1.Show("Customize the color of\n marker and spark line", o as ToolStripEx, e.Location);
                    break;
            }
            
            
        }        
        #region InitializeSparkline
        void SparkLineSource()
        {
            Random r = new Random();

            this.intArray = new double[14, 9];

            for (int i = 0; i < 14; ++i)
                for (int j = 0; j < 9; ++j)
                    this.intArray[i, j] = r.Next(-50, 300);

            for (int i = 0; i < 14; ++i)
            {
                for (int j = 0; j < 9; ++j)
                    this.gridControl1[i + 1, j + 1].CellValue = this.intArray[i, j];
                
            }

            for (int i = 0; i < 14; ++i)
            {
                for (int j = 0; j < 3; ++j)
                    sparkline[i, j] = new SparkLine();
            }

            this.gridControl1.PrepareViewStyleInfo += new Syncfusion.Windows.Forms.Grid.GridPrepareViewStyleInfoEventHandler(gridControl1_PrepareViewStyleInfo);
            this.gridControl1.Refresh();
        }
        #endregion

        #region Helper Method
        void gridControl1_PrepareViewStyleInfo(object sender, Syncfusion.Windows.Forms.Grid.GridPrepareViewStyleInfoEventArgs e)
        {
            double[] sourceItem = new double[9];
            if (e.ColIndex > 9 && e.RowIndex > 0 && e.RowIndex <= 14)
            {
                for (int j = 0; j < 9; ++j)
                {
                    if (this.gridControl1[e.RowIndex, j + 1].CellValue.ToString() != "")
                        sourceItem[j] = Convert.ToDouble(this.gridControl1[e.RowIndex, j + 1].CellValue);
                }
               
               
                this.sparkline[e.RowIndex - 1, e.ColIndex - 8].Source = sourceItem;
                e.Style.CellType = "Control";
                
                e.Style.Control = this.sparkline[e.RowIndex - 1, e.ColIndex - 8];
            }
        }
     
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.toolStripButton1.Checked = true;
            this.toolStripButton2.Checked = false;
            this.toolStripButton3.Checked = false;
            
            for (int i = 0; i < 14; ++i)
            {
                for (int j = 0; j < 3; ++j)
                {
                    sparkline[i, j].Type = SparkLineType.Line;
                    sparkline[i, j].Markers.ShowNegativePoint = false;
                    if (toolStripCheckBox3.Checked)
                    sparkline[i, j].Markers.ShowNegativePoint =true;
                }
            }
            this.gridControl1.Refresh();
            
        }       
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            this.toolStripButton1.Checked = false;
            this.toolStripButton2.Checked = true;
            this.toolStripButton3.Checked = false;
            for (int i = 0; i < 14; ++i)
            {
                for (int j = 0; j < 3; ++j)
                {
                    sparkline[i, j].Type = SparkLineType.Column;
                    sparkline[i, j].Markers.ShowNegativePoint = false;
                    if(toolStripCheckBox3.Checked)
                    sparkline[i, j].Markers.ShowNegativePoint = true;
                    
                }
            }
            this.gridControl1.Refresh();
        }
        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            this.toolStripButton1.Checked = false;
            this.toolStripButton2.Checked = false;
            this.toolStripButton3.Checked = true;
            for (int i = 0; i < 14; ++i)
            {
                for (int j = 0; j < 3; ++j)
                {
                    sparkline[i, j].Type = SparkLineType.WinLoss;
                    
                }
            }
            this.gridControl1.Refresh();

        }

        private void toolStripCheckBox1_Click(object sender, EventArgs e)
        {
            if (toolStripCheckBox1.Checked)
            {
                for (int i = 0; i < 14; ++i)
                {
                    for (int j = 0; j < 3; ++j)
                    {
                        sparkline[i, j].Markers.ShowHighPoint = true;
                    }
                }
            }
            else
            {
               
                    for (int i = 0; i < 14; ++i)
                    {
                        for (int j = 0; j < 3; ++j)
                        {
                            sparkline[i, j].Markers.ShowHighPoint = false;
                        }
                    }
                
            }
            this.gridControl1.Refresh();
        }

        private void toolStripCheckBox2_Click(object sender, EventArgs e)
        {
            if (toolStripCheckBox2.Checked)
            {
                for (int i = 0; i < 14; ++i)
                {
                    for (int j = 0; j < 3; ++j)
                    {
                        sparkline[i, j].Markers.ShowLowPoint = true;
                    }
                }
            }
            else
            {
                for (int i = 0; i < 14; ++i)
                {
                    for (int j = 0; j < 3; ++j)
                    {
                        sparkline[i, j].Markers.ShowLowPoint = false;
                    }
                }
            }
            this.gridControl1.Refresh();
        }

        private void toolStripCheckBox3_Click(object sender, EventArgs e)
        {
            if (toolStripCheckBox3.Checked)
            {
                for (int i = 0; i < 14; ++i)
                {
                    for (int j = 0; j < 3; ++j)
                    {
                        sparkline[i, j].Markers.ShowNegativePoint = true;
                    }
                }
            }
            else
            {
                for (int i = 0; i < 14; ++i)
                {
                    for (int j = 0; j < 3; ++j)
                    {
                        sparkline[i, j].Markers.ShowNegativePoint = false;
                    }
                }

            }
            this.gridControl1.Refresh();
        }

        private void toolStripCheckBox4_Click(object sender, EventArgs e)
        {
            if (toolStripCheckBox4.Checked)
            {
                for (int i = 0; i < 14; ++i)
                {
                    for (int j = 0; j < 3; ++j)
                    {
                        sparkline[i, j].Markers.ShowStartPoint = true;
                    }
                }
            }
            else
            {
                for (int i = 0; i < 14; ++i)
                {
                    for (int j = 0; j < 3; ++j)
                    {
                        sparkline[i, j].Markers.ShowStartPoint = false;
                    }
                }
            }
            this.gridControl1.Refresh();
        }

        private void toolStripCheckBox5_Click(object sender, EventArgs e)
        {
            if (toolStripCheckBox5.Checked)
            {
                for (int i = 0; i < 14; ++i)
                {
                    for (int j = 0; j < 3; ++j)
                    {
                        sparkline[i, j].Markers.ShowEndPoint = true;
                    }
                }
            }
            else
            {
                for (int i = 0; i < 14; ++i)
                {
                    for (int j = 0; j < 3; ++j)
                    {
                        sparkline[i, j].Markers.ShowEndPoint = false;
                    }
                }
            }
            this.gridControl1.Refresh();
        }

        private void toolStripCheckBox6_Click(object sender, EventArgs e)
        {
            if (toolStripCheckBox6.Checked)
            {
                for (int i = 0; i < 14; ++i)
                {
                    for (int j = 0; j < 3; ++j)
                    {
                        sparkline[i, j].Markers.ShowMarker = true;
                    }
                }
            }
            else
            {
                for (int i = 0; i < 14; ++i)
                {
                    for (int j = 0; j < 3; ++j)
                    {
                        sparkline[i, j].Markers.ShowMarker = false;
                    }
                }  
            }
            this.gridControl1.Refresh();
        }

        private void toolStripGallery1_GalleryItemClicked(object sender, Syncfusion.Windows.Forms.Tools.ToolStripGalleryItemEventArgs args)
        {
            Color interior = Color.Black;
            switch (args.GalleryItem.ImageIndex)
            {
                case 0:
                    interior = Color.DarkBlue;
                    break;
                case 1:
                    interior = Color.Maroon;
                    break;
                case 2:
                    interior = Color.DarkGreen;
                    break;
                case 3:
                    interior = Color.FromArgb(30, 75, 120);
                    break; 
                case 4:
                    interior = Color.FromArgb(49, 134, 156);
                    break;
                case 5:
                    interior = Color.Brown;
                    break;
                case 6:
                    interior = Color.FromArgb(57, 93, 140);
                    break;
                 case 7:
                    interior = Color.FromArgb(148, 52, 49);
                    break;
                case 8:
                    interior = Color.Green;
                    break;
                case 9:
                    interior = Color.FromArgb(113, 51, 154);
                    break;
                 case 10:
                    interior = Color.FromArgb(77, 171, 200);
                    break; 
                case 11:
                    interior = Color.FromArgb(245, 154, 64);
                    break;
                case 12:
                    interior = Color.FromArgb(90, 142, 206);
                    break;
            }
           

            for (int i = 0; i < 14; ++i)
            {
                for (int j = 0; j < 3; ++j)
                {
                    sparkline[i, j].LineStyle.LineColor = interior;
                    sparkline[i, j].ColumnStyle.ColumnColor =new Syncfusion.Drawing.BrushInfo(interior);
                }
            }
            this.gridControl1.Refresh();
        }     

        private void colorPickerUIAdv1_Picked(object sender, Syncfusion.Windows.Forms.Tools.ColorPickerUIAdv.ColorPickedEventArgs args)
        {
            for (int i = 0; i < 14; ++i)
            {
                for (int j = 0; j < 3; ++j)
                {
                    sparkline[i, j].LineStyle.LineColor = args.Color;
					sparkline[i, j].ColumnStyle.ColumnColor  =new Syncfusion.Drawing.BrushInfo(args.Color);
                }
            }
            this.gridControl1.Refresh();
            // Ensures that the PopupControlContainer is closed after the selection of a color.
            ColorPickerUIAdv cc = sender as ColorPickerUIAdv;
            Syncfusion.Windows.Forms.PopupControlContainer pcc = cc.Parent as Syncfusion.Windows.Forms.PopupControlContainer;
            pcc.HidePopup(Syncfusion.Windows.Forms.PopupCloseType.Done);

        }

        private void colorPickerUIAdv2_Picked(object sender, ColorPickerUIAdv.ColorPickedEventArgs args)
        {
            for (int i = 0; i < 14; ++i)
            {
                for (int j = 0; j < 3; ++j)
                {
                    sparkline[i, j].Markers.HighPointColor =new Syncfusion.Drawing.BrushInfo(args.Color);
                }
            }
            this.gridControl1.Refresh();
            // Ensures that the PopupControlContainer is closed after the selection of a color.
            ColorPickerUIAdv cc = sender as ColorPickerUIAdv;
            Syncfusion.Windows.Forms.PopupControlContainer pcc = cc.Parent as Syncfusion.Windows.Forms.PopupControlContainer;
            pcc.HidePopup(Syncfusion.Windows.Forms.PopupCloseType.Done);
        }

        private void colorPickerUIAdv3_Picked(object sender, ColorPickerUIAdv.ColorPickedEventArgs args)
        {
            for (int i = 0; i < 14; ++i)
            {
                for (int j = 0; j < 3; ++j)
                {
                    sparkline[i, j].Markers.LowPointColor = new Syncfusion.Drawing.BrushInfo(args.Color);
                }
            }
            this.gridControl1.Refresh();
            // Ensures that the PopupControlContainer is closed after the selection of a color.
            ColorPickerUIAdv cc = sender as ColorPickerUIAdv;
            Syncfusion.Windows.Forms.PopupControlContainer pcc = cc.Parent as Syncfusion.Windows.Forms.PopupControlContainer;
            pcc.HidePopup(Syncfusion.Windows.Forms.PopupCloseType.Done);
        }

        private void colorPickerUIAdv4_Picked(object sender, ColorPickerUIAdv.ColorPickedEventArgs args)
        {
            for (int i = 0; i < 14; ++i)
            {
                for (int j = 0; j < 3; ++j)
                {
                    sparkline[i, j].Markers.NegativePointColor  = new Syncfusion.Drawing.BrushInfo(args.Color);
                }
            }
            this.gridControl1.Refresh();
            // Ensures that the PopupControlContainer is closed after the selection of a color.
            ColorPickerUIAdv cc = sender as ColorPickerUIAdv;
            Syncfusion.Windows.Forms.PopupControlContainer pcc = cc.Parent as Syncfusion.Windows.Forms.PopupControlContainer;
            pcc.HidePopup(Syncfusion.Windows.Forms.PopupCloseType.Done);
        }

        private void colorPickerUIAdv5_Picked(object sender, ColorPickerUIAdv.ColorPickedEventArgs args)
        {
            for (int i = 0; i < 14; ++i)
            {
                for (int j = 0; j < 3; ++j)
                {
                    sparkline[i, j].Markers.StartPointColor  = new Syncfusion.Drawing.BrushInfo(args.Color);
                }
            }
            this.gridControl1.Refresh();
            // Ensures that the PopupControlContainer is closed after the selection of a color.
            ColorPickerUIAdv cc = sender as ColorPickerUIAdv;
            Syncfusion.Windows.Forms.PopupControlContainer pcc = cc.Parent as Syncfusion.Windows.Forms.PopupControlContainer;
            pcc.HidePopup(Syncfusion.Windows.Forms.PopupCloseType.Done);
        }

        private void colorPickerUIAdv6_Picked(object sender, ColorPickerUIAdv.ColorPickedEventArgs args)
        {
            for (int i = 0; i < 14; ++i)
            {
                for (int j = 0; j < 3; ++j)
                {
                    sparkline[i, j].Markers.EndPointColor = new Syncfusion.Drawing.BrushInfo(args.Color);
                }
            }
            this.gridControl1.Refresh();
            // Ensures that the PopupControlContainer is closed after the selection of a color.
            ColorPickerUIAdv cc = sender as ColorPickerUIAdv;
            Syncfusion.Windows.Forms.PopupControlContainer pcc = cc.Parent as Syncfusion.Windows.Forms.PopupControlContainer;
            pcc.HidePopup(Syncfusion.Windows.Forms.PopupCloseType.Done);
        }

        private void colorPickerUIAdv7_Picked(object sender, ColorPickerUIAdv.ColorPickedEventArgs args)
        {
            for (int i = 0; i < 14; ++i)
            {
                for (int j = 0; j < 3; ++j)
                {
                    sparkline[i, j].Markers.MarkerColor  = new Syncfusion.Drawing.BrushInfo(args.Color);
                }
            }
            this.gridControl1.Refresh();
            // Ensures that the PopupControlContainer is closed after the selection of a color.
            ColorPickerUIAdv cc = sender as ColorPickerUIAdv;
            Syncfusion.Windows.Forms.PopupControlContainer pcc = cc.Parent as Syncfusion.Windows.Forms.PopupControlContainer;
            pcc.HidePopup(Syncfusion.Windows.Forms.PopupCloseType.Done);
        }
        #endregion
    }
}

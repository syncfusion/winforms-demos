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

using Syncfusion.Windows.Forms.Diagram;
using Syncfusion.Windows.Forms;
using System.Drawing.Drawing2D;
using System.IO;
#if !NETCORE
using System.Runtime.Serialization.Formatters.Soap;
#endif
using System.Runtime.Serialization;
using Syncfusion;
using System.Runtime.Serialization.Formatters.Binary;
using System.Collections;
using Syncfusion.Windows.Forms.Diagram.Controls;


namespace Clock
{
    public partial class Form1 : MetroForm
    {
        #region Members
        int x = 0;
        Node mynode;
        Node centerNode;
        Node secondsNode;
        Node hoursNode;
        Node minutesNode;
        SymbolPalette palette;
        SymbolPalette digitalPalette = new SymbolPalette();
        Group digit, digit1, digit2, digit3, digit4, digit5, digit6, colon1, colon2;
        int hour, min, sec, ms;
        private int[] zero = new int[] { 1, 2, 3, 4, 5, 6, };
        private int[] one = new int[] { 3, 6 };
        private int[] two = new int[] { 2, 3, 4, 5, 7 };
        private int[] three = new int[] { 2, 3, 5, 6, 7 };
        private int[] four = new int[] { 1, 3, 6, 7 };
        private int[] five = new int[] { 1, 2, 5, 6, 7 };
        private int[] six = new int[] { 1, 2, 4, 5, 6, 7 };
        private int[] seven = new int[] { 2, 3, 6 };
        private int[] eight = new int[] { 1, 2, 3, 4, 5, 6, 7 };
        private int[] nine = new int[] { 1, 2, 3, 5, 6, 7 };

        ArrayList bitList = new ArrayList();
        #endregion

        #region Form Initialize
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DiagramAppearance();

            PaletteGroupBar paletteGroupBar = new PaletteGroupBar();
            // Load Palette
#if NETCORE
            paletteGroupBar.LoadPalette(@"..\..\..\..\..\..\..\common\Data\Diagram\xml\ClockSymbols.xml");
#else
            paletteGroupBar.LoadPalette(@"..\..\..\..\..\..\common\Data\Diagram\xml\ClockSymbols.xml");
#endif

            if (paletteGroupBar != null && paletteGroupBar.CurrentSymbolPalette != null)
            {
                palette = paletteGroupBar.CurrentSymbolPalette;
            }
            diagram1.BeginUpdate();
            // populate Diagram with nodes
            AddingNodesToTheDrawingArea();
            diagram1.EndUpdate();

            this.timer1.Start();

        }
#endregion

#region Private Methods
        /// <summary>
        /// Change's the appearance of Diagram
        /// </summary>
        private void DiagramAppearance()
        {
            this.diagram1.HorizontalRuler.BackgroundColor = Color.White;
            this.diagram1.VerticalRuler.BackgroundColor = Color.White;
            this.diagram1.View.Grid.GridStyle = GridStyle.Line;
            this.diagram1.View.Grid.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.diagram1.View.Grid.Color = Color.LightGray;
            this.diagram1.View.Grid.VerticalSpacing = 15;
            this.diagram1.View.Grid.HorizontalSpacing = 15;
            this.diagram1.Model.BackgroundStyle.GradientCenter = 0.5f;
            this.diagram1.View.HandleColor = Color.AliceBlue;
            this.diagram1.View.HandleOutlineColor = Color.SkyBlue;
            this.diagram1.Model.RenderingStyle.SmoothingMode = SmoothingMode.HighQuality;
            this.diagram1.View.SelectionList.Clear();
        }

#endregion

#region Helper methods

        /// <summary>
        /// Insert nodes from the palete 
        /// </summary>
        public void AddingNodesToTheDrawingArea()
        {
            InsertNodeFromPallete(0, new PointF(85, 60));
            InsertNodeFromPallete(3, new PointF(173, 150));
            InsertNodeFromPallete(4, new PointF(173, 150));
            InsertNodeFromPallete(5, new PointF(173, 153));
            InsertNodeFromPallete(6, new PointF(171, 145));

            foreach (Node node in this.diagram1.Model.Nodes)
            {
                if (node.Name.Equals("ClockHead"))
                {
                    mynode = node as Node;
                }
                else if (node.Name.Equals("Oscillator"))
                {
                    centerNode = node as Node;
                }
                else if (node.Name.Equals("Seconds"))
                {
                    secondsNode = node as Node;
                }
                else if (node.Name.Equals("Hours"))
                {
                    hoursNode = node as Node;
                }
                else if (node.Name.Equals("Minutes"))
                {
                    minutesNode = node as Node;
                }
                node.EditStyle.AllowSelect = false;
            }

#region Digital clock

            Syncfusion.Windows.Forms.Diagram.RoundRect outerRect = new Syncfusion.Windows.Forms.Diagram.RoundRect(325, 70, 420, 160,MeasureUnits.Pixel);
            outerRect.FillStyle.Color = ColorTranslator.FromHtml("#FF119EDA");           
            outerRect.LineStyle.LineWidth = 0;
            outerRect.EditStyle.AllowSelect = false;
            diagram1.Model.AppendChild(outerRect);
            Syncfusion.Windows.Forms.Diagram.RoundRect innerRect = new Syncfusion.Windows.Forms.Diagram.RoundRect(335, 80, 400, 140, MeasureUnits.Pixel);
            innerRect.FillStyle.Color = ColorTranslator.FromHtml("#FF96D3ED");
            innerRect.LineStyle.LineWidth = 0;
            innerRect.EditStyle.AllowSelect = false;
            diagram1.Model.AppendChild(innerRect);
            Syncfusion.Windows.Forms.Diagram.RoundRect innerRect1 = new Syncfusion.Windows.Forms.Diagram.RoundRect(345, 90, 380, 120,7, MeasureUnits.Pixel);
            innerRect1.FillStyle.Color = Color.White;
            innerRect1.LineStyle.LineWidth = 0;
            innerRect1.EditStyle.AllowSelect = false;
            diagram1.Model.AppendChild(innerRect1);

            bitList.Add(zero);
            bitList.Add(one);
            bitList.Add(two);
            bitList.Add(three);
            bitList.Add(four);
            bitList.Add(five);
            bitList.Add(six);
            bitList.Add(seven);
            bitList.Add(eight);
            bitList.Add(nine);

            digit = new Group(palette.Nodes[7] as Group);
            ApplyStyle(digit);
            digit.PinPoint = new PointF(380, 150);
            digit.EditStyle.AllowSelect = false;
            digit.Visible = false;
            diagram1.Model.AppendChild(digit);

            digit1 = new Group(palette.Nodes[7] as Group);
            ApplyStyle(digit1);
            digit1.PinPoint = new PointF(430, 150);
            digit1.EditStyle.AllowSelect = false;
            digit1.Visible = false;
            diagram1.Model.AppendChild(digit1);

            digit2 = new Group(palette.Nodes[7] as Group);
            ApplyStyle(digit2);
            digit2.PinPoint = new PointF(515, 150);
            digit2.EditStyle.AllowSelect = false;
            digit2.Visible = false;
            diagram1.Model.AppendChild(digit2);

            digit3 = new Group(palette.Nodes[7] as Group);
            ApplyStyle(digit3);
            digit3.PinPoint = new PointF(565, 150);
            digit3.EditStyle.AllowSelect = false;
            digit3.Visible = false;
            diagram1.Model.AppendChild(digit3);

            digit4 = new Group(palette.Nodes[7] as Group);
            ApplyStyle(digit4);
            digit4.PinPoint = new PointF(640, 150);
            digit4.EditStyle.AllowSelect = false;
            digit4.Visible = false;
            diagram1.Model.AppendChild(digit4);

            digit5 = new Group(palette.Nodes[7] as Group);
            ApplyStyle(digit5);
            digit5.PinPoint = new PointF(690, 150);
            digit5.EditStyle.AllowSelect = false;
            digit5.Visible = false;
            diagram1.Model.AppendChild(digit5);

            colon1 = new Group(palette.Nodes[8] as Group);
            ApplyStyle(colon1);
            colon1.PinPoint = new PointF(470, 150);
            colon1.EditStyle.AllowSelect = false;
            diagram1.Model.AppendChild(colon1);

            colon2 = new Group(palette.Nodes[8] as Group);
            ApplyStyle(colon2);
            colon2.PinPoint = new PointF(600, 150);
            colon2.EditStyle.AllowSelect = false;
            diagram1.Model.AppendChild(colon2);

#endregion

            this.diagram1.Controller.SelectionList.Clear();
        }

        /// <summary>
        /// Apply fill color for nodes
        /// </summary>
        /// <param name="gNode">Group Node</param>
        private void ApplyStyle(Group gNode)
        {
            foreach (Node node in gNode.Nodes)
            {
                if (node is FilledPath)
                {
                    ((FilledPath)node).FillStyle.Color = ColorTranslator.FromHtml("#FF333333");
                }
            }
        }

        /// <summary>
        ///  Get the SymbolPalette by deserializing the SymbolPalette file
        /// </summary>
        /// <param name="filepath">Path of the file</param>
        /// <returns>returns palette</returns>
        public SymbolPalette LoadPalette(string filepath)
        {
            SymbolPalette curSymbolPalette = null;
            FileStream iStream = new FileStream(filepath, FileMode.Open, FileAccess.Read);
            if (iStream != null)
            {
#pragma warning disable SYSLIB0011
                IFormatter formatter = new BinaryFormatter();
#pragma warning restore SYSLIB0011
                formatter.Binder = new OldToNewDeserializationBinder();
                try
                {
                    AppDomain.CurrentDomain.AssemblyResolve +=
                        new ResolveEventHandler(DiagramBaseAssembly.AssemblyResolver);
#pragma warning disable SYSLIB0011
                    curSymbolPalette = (SymbolPalette)formatter.Deserialize(iStream);
#pragma warning restore SYSLIB0011 
                }
                catch (SerializationException)
                {
                    try
                    {
#if !NETCORE
                        formatter = new SoapFormatter();
                        formatter.Binder = new OldToNewDeserializationBinder();
                        iStream.Position = 0;
                        curSymbolPalette = (SymbolPalette)formatter.Deserialize(iStream);
#endif
                    }
                    catch (Exception se)
                    {
                        // To get the version from the edp file
                        string strRegex = @"version\w*=\w*\d+\.\d+\.\d+(\.\d+)+\w*,";
                        System.Text.RegularExpressions.Regex regex = new System.Text.RegularExpressions.Regex(strRegex, System.Text.RegularExpressions.RegexOptions.IgnoreCase | System.Text.RegularExpressions.RegexOptions.Singleline);
                        StreamReader sr = File.OpenText(filepath);
                        string strFileContent = sr.ReadToEnd();
                        System.Text.RegularExpressions.Match version = regex.Match(strFileContent);
                        string strVersion = version.Value;

                        if (string.IsNullOrEmpty(strVersion))
                        {
                            throw new System.Exception("Incompatible with older version.\nPlease use the converter utility to make it compatible with newer version", se);
                        }
                        else
                        {
                            throw new System.Exception("Unable to parse the palette file " + strVersion, se);
                        }
                    }
                }
                finally
                {
                    iStream.Close();
                    AppDomain.CurrentDomain.AssemblyResolve -=
                       new ResolveEventHandler(DiagramBaseAssembly.AssemblyResolver);
                }
            }
            return curSymbolPalette;
        }

        /// <summary>
        /// Insert the node from the palette
        /// </summary>
        /// <param name="nNodeIndex">Node's index</param>
        /// <param name="ptLocation">Node's location</param>
        /// <returns></returns>
        private Node InsertNodeFromPallete(int nNodeIndex, PointF ptLocation)
        {
            Node node = null;
            NodeCollection nodes = palette.Nodes;

            if (nNodeIndex >= 0 && nNodeIndex < nodes.Count)
            {
                node = (Node)nodes[nNodeIndex].Clone();
                InsertNode(node, ptLocation);
            }

            return node;
        }
        /// <summary>
        /// Insert the node into the diagram
        /// </summary>
        /// <param name="node">Node</param>
        /// <param name="ptLocation">Node's location</param>
        /// <returns></returns>
        private Node InsertNode(Node node, PointF ptLocation)
        {
            MeasureUnits units = MeasureUnits.Pixel;
            SizeF szPinOffset = ((IUnitIndependent)node).GetPinPointOffset(units);
           
            ptLocation.X += szPinOffset.Width;
            ptLocation.Y += szPinOffset.Height;
           
            ((IUnitIndependent)node).SetPinPoint(ptLocation, units);
            if (node.Name == "ClockHead" && node is Group)
            {
                if(((Group)node).Nodes[0] is FilledPath)
                {
                    ((FilledPath)((Group)node).Nodes[0]).FillStyle.Color = ColorTranslator.FromHtml("#FF119EDA");
                }
                if(((Group)node).Nodes[1] is FilledPath)
                {
                    ((FilledPath)((Group)node).Nodes[1]).FillStyle.Color = ColorTranslator.FromHtml("#FF96D3ED");
                }               
            }
            if (node.Name == "CenterPiece" && node is Group)
            {
                if (((Group)node).Nodes[0] is FilledPath)
                {
                    ((FilledPath)((Group)node).Nodes[0]).FillStyle.Color = ColorTranslator.FromHtml("#FF96D3ED");
                }   
                if (((Group)node).Nodes[1] is FilledPath)
                {
                    ((FilledPath)((Group)node).Nodes[1]).FillStyle.Color = ColorTranslator.FromHtml("#FF119EDA");
                }
               
            }
            if (node.Name == "Seconds")
            {
                if (node is FilledPath)
                {
                    ((FilledPath)node).FillStyle.Color = ColorTranslator.FromHtml("#FF119EDA");
                }
            }
           
            this.diagram1.Model.AppendChild(node);
            return node;
        }

        /// <summary>
        /// Hide/Show digit nodes
        /// </summary>
        /// <param name="p">Index</param>
        /// <param name="displayNode">Node to show</param>
        private void DrawClock(int p, Group displayNode)
        {
            diagram1.BeginUpdate();

            int[] bits = bitList[p] as int[];
            //int j = 0;
            for (int i = 0, j = 0; i < displayNode.Nodes.Count; i++)
            {
                displayNode.Visible = true;
                if (i == bits[j] - 1)
                {
                    Node node = displayNode.Nodes[bits[j] - 1];
                    if (node != null)
                        node.Visible = true;
                    if (j < bits.Length - 1)
                        j++;
                }
                else
                {
                    Node node = displayNode.Nodes[i];
                    if (node != null)
                        node.Visible = false;
                }
            }
            diagram1.EndUpdate();
        }


#endregion

#region Event Handlers

        private void timer1_Tick(object sender, EventArgs e)
        {

            secondsNode.RotationAngle = DateTime.Now.Second * (360 / 60) + 270;

            minutesNode.RotationAngle = DateTime.Now.Minute * (360 / 60) + 270;

            // Calculate the hour
            int hour = DateTime.Now.Hour;
            if (hour >= 12)
                hour -= 12;
            // Calculate minutes passed of the current hour
            int passedMinutes = hour * 60 + DateTime.Now.Minute;

            hoursNode.RotationAngle = passedMinutes / 720F * 360 + 270;

            DateTime dt = DateTime.Now;

            hour = dt.Hour;
            min = dt.Minute;
            sec = dt.Second;
            ms = dt.Millisecond;

            DrawClock(hour / 10, digit);
            DrawClock(hour % 10, digit1);
            DrawClock(min / 10, digit2);
            DrawClock(min % 10, digit3);
            DrawClock(sec / 10, digit4);
            DrawClock(sec % 10, digit5);
			diagram1.Refresh();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.timer1.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.timer1.Stop();
        }
       

#endregion
    }
   
}

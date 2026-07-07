#region Copyright Syncfusion Inc. 2001 - 2013
// Copyright Syncfusion Inc. 2001 - 2013. All rights reserved.
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
using Syncfusion.Windows.Forms.Diagram.Controls;
using Syncfusion.Windows.Forms.Diagram;
using System.Drawing.Drawing2D;
using System.IO;
using System.Drawing.Printing;
using System.Drawing.Imaging;
using Syncfusion.SVG.IO;
using Syncfusion.Windows.Forms;
using System.Collections;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using Syncfusion;

namespace SeatReservation
{
    public partial class Form1 : Form
    {
        #region Members
        public string fileName;
        private Hashtable seatsReserved = new Hashtable();

        private ArrayList selectedSeats = null;
        private NodeCollection seats = new NodeCollection();
        bool newSelection = false;
        #endregion

        #region Form Initialize
        public Form1()
        {
            InitializeComponent();
            diagram1.BeginUpdate();
            diagram1.Model.BoundaryConstraintsEnabled = false;
            diagram1.Controller.Guides.Enable = false;
            PaletteGroupBar paletteGroupBar = new PaletteGroupBar();
#if !NETCORE
            paletteGroupBar.LoadPalette(@"..\..\..\..\..\..\common\Data\Diagram\xml\SeatReservationSymbols.xml");
#else
            paletteGroupBar.LoadPalette(@"..\..\..\..\..\..\..\common\Data\Diagram\xml\SeatReservationSymbols.xml");
#endif
            this.diagram1.Model.RenderingStyle.SmoothingMode = SmoothingMode.HighQuality;
            this.diagram1.Model.DocumentSize = new PageSize(1169, 1269);
            this.diagram1.Model.BoundaryConstraintsEnabled = false;
            diagram1.Controller.InPlaceEditing = false;
            if (paletteGroupBar != null && paletteGroupBar.CurrentSymbolPalette != null)
                InitializeDiagram(paletteGroupBar.CurrentSymbolPalette);
            DiagramAppearance();
            diagram1.EndUpdate();

            diagram1.EventSink.NodeMouseEnter += new NodeMouseEventHandler(EventSink_NodeMouseEnter);
            diagram1.EventSink.NodeMouseLeave += new NodeMouseEventHandler(EventSink_NodeMouseLeave);
            diagram1.EventSink.NodeClick += new NodeMouseEventHandler(EventSink_NodeClick);

        }
#endregion

#region Initialize Diagram
        private void InitializeDiagram(SymbolPalette palette)
        {
            float x = 150;
            float y = 150;
            int rowNodeCnt = 1, j = 0;
            string[] strRow = new string[] { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J" };

            TextNode txtNode = new TextNode("View and Change Seats", new RectangleF(250, 20, 400, 70));
            txtNode.FontColorStyle.Color = Color.White;
            txtNode.FontStyle.Family = "Arial";
            txtNode.FontStyle.Size = 17;
            txtNode.HorizontalAlignment = StringAlignment.Center;
            txtNode.FontStyle.Bold = true;
            txtNode.LineStyle.LineColor = Color.Transparent;
            txtNode.EditStyle.AllowSelect = false;
            diagram1.Model.AppendChild(txtNode);

            Group availSeats = new Group(palette.Nodes["Seat"] as Group);
            availSeats.Name = "availSeats";
            availSeats.PinPoint = new PointF(250, 80);
            availSeats.Size = new SizeF(20, 20);
            availSeats.EditStyle.AllowMoveX = false;
            availSeats.EditStyle.AllowMoveY = false;
            UpdateEditStyle(availSeats);
            diagram1.Model.AppendChild(availSeats);
            TextNode availTNode = new TextNode("Available Seats", new RectangleF(265, 70, 90, 20));
            availTNode.FontStyle.Family = "Arial";
            availTNode.FontColorStyle.Color = Color.White;
            availTNode.FontStyle.Size = 8;
            availTNode.VerticalAlignment = StringAlignment.Center;
            availTNode.LineStyle.LineColor = Color.Transparent;
            availTNode.EditStyle.AllowSelect = false;
            diagram1.Model.AppendChild(availTNode);

            Group bookedSeats = new Group(palette.Nodes["Seat"] as Group);
            bookedSeats.Name = "bookedSeats";
            bookedSeats.PinPoint = new PointF(380, 80);
            bookedSeats.Size = new SizeF(20, 20);
            bookedSeats.EditStyle.AllowMoveX = false;
            bookedSeats.EditStyle.AllowMoveY = false;
            UpdateEditStyle(bookedSeats);
            foreach (Node node in bookedSeats.Nodes)
            {
                if (node is FilledPath)
                {
                    ((FilledPath)node).FillStyle.Color = Color.FromArgb(134, 134, 134);
                    ((FilledPath)node).FillStyle.ForeColor = Color.FromArgb(163, 163, 163);
                    node.LineStyle.LineColor = Color.DarkGray;
                }
            }
            diagram1.Model.AppendChild(bookedSeats);
            TextNode bookedTNode = new TextNode("Booked Seats", new RectangleF(395, 70, 90, 20));
            bookedTNode.FontStyle.Family = "Arial";
            bookedTNode.FontColorStyle.Color = Color.White;
            bookedTNode.FontStyle.Size = 8;
            bookedTNode.VerticalAlignment = StringAlignment.Center;
            bookedTNode.LineStyle.LineColor = Color.Transparent;
            bookedTNode.EditStyle.AllowSelect = false;
            diagram1.Model.AppendChild(bookedTNode);

            Group curSelSeats = new Group(palette.Nodes["Seat"] as Group);
            curSelSeats.PinPoint = new PointF(500, 80);
            curSelSeats.Size = new SizeF(20, 20);
            curSelSeats.EditStyle.AllowMoveX = false;
            curSelSeats.EditStyle.AllowMoveY = false;
            UpdateEditStyle(curSelSeats);
            foreach (Node node in curSelSeats.Nodes)
            {
                if (node is FilledPath)
                {
                    ((FilledPath)node).FillStyle.Color = Color.FromArgb(0, 155, 0);
                    ((FilledPath)node).FillStyle.ForeColor = Color.FromArgb(80, 255, 89);
                    node.LineStyle.LineColor = Color.Black;
                }
            }
            diagram1.Model.AppendChild(curSelSeats);
            TextNode CurSelTNode = new TextNode("Current Selection", new RectangleF(515, 70, 90, 20));
            CurSelTNode.FontStyle.Family = "Arial";
            CurSelTNode.FontColorStyle.Color = Color.White;
            CurSelTNode.FontStyle.Size = 8;
            CurSelTNode.VerticalAlignment = StringAlignment.Center;
            CurSelTNode.LineStyle.LineColor = Color.Transparent;
            CurSelTNode.EditStyle.AllowSelect = false;
            diagram1.Model.AppendChild(CurSelTNode);

            for (int i = 1; i < 106; i++)
            {
                Group seatNode = new Group(palette.Nodes["Seat"] as Group);
                Syncfusion.Windows.Forms.Diagram.Label lbl = new Syncfusion.Windows.Forms.Diagram.Label(seatNode, i.ToString());
                lbl.FontStyle.Family = "Arial";
                lbl.FontColorStyle.Color = Color.White;
                seatNode.Labels.Add(lbl);
                seatNode.Size = new SizeF(30, 30);
                seatNode.PinPoint = new PointF(x, y);
                seatNode.EditStyle.AllowMoveX = false;
                seatNode.EditStyle.AllowMoveY = false;
                UpdateEditStyle(seatNode);
                seatNode.EditStyle.DefaultHandleEditMode = HandleEditMode.None;
                diagram1.Model.AppendChild(seatNode);
                seats.Add(seatNode);

                if (rowNodeCnt == 10)
                    x = x + 80;
                else
                    x = x + 40;

                if (rowNodeCnt == 15)
                {
                    Syncfusion.Windows.Forms.Diagram.Rectangle rowNode = new Syncfusion.Windows.Forms.Diagram.Rectangle(100, y - 10, 20, 20);
                    rowNode.FillStyle.Color = Color.Goldenrod;
                    rowNode.FillStyle.ForeColor = Color.Yellow;
                    rowNode.FillStyle.Type = FillStyleType.LinearGradient;
                    rowNode.LineStyle.LineColor = Color.Goldenrod;
                    rowNode.EditStyle.AllowSelect = false;
                    Syncfusion.Windows.Forms.Diagram.Label lbl1 = new Syncfusion.Windows.Forms.Diagram.Label(rowNode, strRow[j]);
                    lbl1.FontStyle.Family = "Arial";
                    lbl1.FontColorStyle.Color = Color.Black;
                    rowNode.Labels.Add(lbl1);
                    diagram1.Model.AppendChild(rowNode);
                    x = 150;
                    y = y + 40;
                    rowNodeCnt = 0;
                    j++;
                }
                rowNodeCnt++;
            }
            Syncfusion.Windows.Forms.Diagram.Rectangle rect = new Syncfusion.Windows.Forms.Diagram.Rectangle(150, y + 40, 600, 50);
            rect.FillStyle.Color = Color.WhiteSmoke;
            rect.LineStyle.LineColor = Color.LightGray;
            Syncfusion.Windows.Forms.Diagram.Label label = new Syncfusion.Windows.Forms.Diagram.Label(rect, "Screen this way");
            label.FontStyle.Bold = true;
            label.FontStyle.Size = 16;
            label.FontStyle.Family = "Segoe UI";
            rect.Labels.Add(label);
            diagram1.Model.AppendChild(rect);
            diagram1.BeginUpdate();
            ReserveSeats();
            diagram1.EndUpdate();
        }

        private void ReserveSeats()
        {
            Random rand = new Random();
            bool updated = false;
            //Randomly select some seats and mark them as "Reserved".
            int count = 0;
            while (count < 15)
            {
                Group grp = seats[rand.Next(1, 50)] as Group;
                if (grp != null)
                {
                    foreach (Node node1 in grp.Nodes)
                    {
                        if ((node1 != null) && (node1.Name != "BitmapNode") && (!node1.Name.StartsWith("Exit")) && !node1.Name.StartsWith("Group"))

                            if (node1 is FilledPath)
                            {
                                updated = true;
                                ((FilledPath)node1).FillStyle.Color = Color.FromArgb(134, 134, 134);
                                ((FilledPath)node1).FillStyle.ForeColor = Color.FromArgb(163, 163, 163);
                                node1.LineStyle.LineColor = Color.DarkGray;
                            }
                    }
                    if (!seatsReserved.ContainsKey(grp.Name) && updated)
                    {
                        seatsReserved.Add(grp.Name, "Reserved");
                        count++;
                    }
                    updated = false;
                }
            }


            selectedSeats = new ArrayList();
            this.textBox2.Text = "";
        }

        private void UpdateEditStyle(Node curNode)
        {
            if (curNode is Group)
            {
                foreach (Node node in ((Group)curNode).Nodes)
                {
                    node.EditStyle.DefaultHandleEditMode = HandleEditMode.None;
                }
            }
            else
                curNode.EditStyle.DefaultHandleEditMode = HandleEditMode.None;
        }

        // Get the SymbolPalette by deserializing the SymbolPalette file
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
#pragma warning disable SYSLIB0011
                        formatter = new BinaryFormatter();
#pragma warning restore SYSLIB0011
                        formatter.Binder = new OldToNewDeserializationBinder();
                        iStream.Position = 0;
#pragma warning disable SYSLIB0011
                        curSymbolPalette = (SymbolPalette)formatter.Deserialize(iStream);
#pragma warning restore SYSLIB0011
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

#endregion

#region Private Methods
        /// <summary>
        /// Change's the appearance of Diagram Control
        /// </summary>        
        private void DiagramAppearance()
        {           
            this.diagram1.View.Grid.GridStyle = GridStyle.Line;
            this.diagram1.View.Grid.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.diagram1.View.Grid.Color = Color.LightGray;
            this.diagram1.View.Grid.VerticalSpacing = 15;
            this.diagram1.View.Grid.HorizontalSpacing = 15;
            this.diagram1.Model.BackgroundStyle.GradientCenter = 0.5f;
            this.diagram1.View.HandleRenderer.HandleColor = Color.AliceBlue;
            this.diagram1.View.HandleRenderer.HandleOutlineColor = Color.SkyBlue;            
            this.diagram1.View.SelectionList.Clear();
        }

#endregion

#region Event Handlers

        void EventSink_NodeClick(NodeMouseEventArgs evtArgs)
        {
            diagram1.BeginUpdate();
            if (newSelection)
            {
                this.textBox2.Text = "";
                this.textBox1.Text = "";
            }
            if (evtArgs.Node is Group && seats.Contains(evtArgs.Node))
            {
                bool alreadySelected = false;
                Group seatNode = evtArgs.Node as Group;
                foreach (string val in selectedSeats)
                    if (val == seatNode.Name)
                        alreadySelected = true;
                if (seatsReserved.ContainsKey(seatNode.Name))
                {
#if !NETCORE
                    MessageBoxAdv.Show("This seat is already reserved", "Reservation Status", MessageBoxButtons.OK, MessageBoxIcon.Warning);
#else
                    MessageBox.Show("This seat is already reserved", "Reservation Status", MessageBoxButtons.OK, MessageBoxIcon.Warning);
#endif
                    if (alreadySelected)
                    {
                        selectedSeats.Remove(seatNode.Name);
                    }
                }
                else
                {
                    if (!selectedSeats.Contains(seatNode.Name))
                    {
                        foreach (Node node in seatNode.Nodes)
                        {
                            if (node is FilledPath)
                            {
                                ((FilledPath)node).FillStyle.Color = Color.FromArgb(0, 155, 0);
                                ((FilledPath)node).FillStyle.ForeColor = Color.FromArgb(80, 255, 89);
                                node.LineStyle.LineColor = Color.Black;
                            }
                        }
                        selectedSeats.Add(seatNode.Name);
                        if (textBox1.Text == "")
                            textBox1.Text = "";
                        textBox1.Text += seatNode.Name + ", ";
                        newSelection = false;
                    }
                }
            }
            diagram1.EndUpdate();
        }

        void EventSink_NodeMouseLeave(NodeMouseEventArgs evtArgs)
        {
            diagram1.Controller.ActiveTool.ActionCursor = Cursors.Default;
        }

        void EventSink_NodeMouseEnter(NodeMouseEventArgs evtArgs)
        {
            diagram1.Controller.ActiveTool.ActionCursor = Cursors.Hand;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            diagram1.BeginUpdate();
            this.textBox2.Text = "";
            foreach (object val in selectedSeats)
            {
                Node node1 = diagram1.Model.Nodes.FindNodeByName(val.ToString());
                seatsReserved.Add(node1.Name, "Reserved");
                Group grp = node1 as Group;
                foreach (Node gnode in grp.Nodes)
                {
                    if (gnode is FilledPath)
                    {
                        ((FilledPath)gnode).FillStyle.Color = Color.FromArgb(134, 134, 134);
                        ((FilledPath)gnode).FillStyle.ForeColor = Color.FromArgb(163, 163, 163);
                        gnode.LineStyle.LineColor = Color.DarkGray;
                    }
                }
                if (this.textBox2.Text != "")
                    textBox2.Text += ", " + node1.Name;
                else
                    textBox2.Text = node1.Name;
            }
            textBox1.Text = "";
            selectedSeats.Clear();
            diagram1.Refresh();
            diagram1.EndUpdate();
            newSelection = true;
        }


#endregion

#region Helper Methods

#endregion
    }
}

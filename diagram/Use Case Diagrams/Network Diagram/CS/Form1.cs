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
using System.Drawing.Printing;
using Syncfusion.Windows.Forms.Diagram;
using System.Collections;
using Syncfusion.Windows.Forms.Diagram.Controls;
using Syncfusion.Windows.Forms.Tools;
using System.Drawing.Drawing2D;
using System.IO;
using Syncfusion.SVG.IO;
using System.Drawing.Imaging;
using Syncfusion.Windows.Forms;

namespace Network_Diagram
{
    public partial class Form1 : Form
    {
        #region Members
        bool needSave = false;
        public string fileName;
        #endregion

        #region Form Initialize
        public Form1()
        {
            InitializeComponent();
            this.diagram1.BeginUpdate();
#if !NETCORE
            paletteGroupBar1.LoadPalette(@"..\..\..\..\..\..\common\Data\Diagram\xml\NetworkSymbols.xml");
#else
            paletteGroupBar1.LoadPalette(@"..\..\..\..\..\..\..\common\Data\Diagram\xml\NetworkSymbols.xml");
#endif
            this.diagram1.Model.BoundaryConstraintsEnabled = false;
            this.diagram1.Model.RenderingStyle.SmoothingMode = SmoothingMode.HighQuality;
            GroupBarAppearance();
            InitailizeDiagram();
            this.diagram1.View.SelectionList.Clear();
            comboLayers.SelectedIndex = 0;
            this.diagram1.EndUpdate();
        }
#endregion

#region Private Methods
        /// <summary>
        /// Change's the appearance of GroupBar
        /// </summary>
        private void GroupBarAppearance()
        {
           this.paletteGroupBar1.BorderColor = System.Drawing.ColorTranslator.FromHtml("#119EDA");
           foreach (GroupBarItem item in paletteGroupBar1.GroupBarItems)
            {
                //palette view settings
                if (item.Client is PaletteGroupView)
                {
                    PaletteGroupView view = item.Client as PaletteGroupView;
                    view.Font = new Font("Segoe UI", 9, System.Drawing.FontStyle.Regular);
                    view.ForeColor = Color.Black;
                    view.FlowView = true;
                    view.ShowToolTips = true;
                    view.ShowFlowViewItemText = true;
                    view.SelectedItemColor = Color.FromArgb(255, 219, 118);
                    view.HighlightItemColor = Color.FromArgb(255, 227, 149);
                    view.SelectingItemColor = Color.FromArgb(255, 238, 184);
                    view.SelectedHighlightItemColor = Color.FromArgb(255, 218, 115);
                    view.FlowViewItemTextLength = (int)DpiAware.LogicalToDeviceUnits(80);
                    view.BackColor = Color.White;
                    view.TextWrap = true;
                    view.FlatLook = true;
                    view.BorderStyle = BorderStyle.FixedSingle;                   
                }
            }         
        }

        /// <summary>
        /// Changes the appearance of the Diagram
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
            this.diagram1.View.HandleRenderer.HandleColor = Color.AliceBlue;
            this.diagram1.View.HandleRenderer.HandleOutlineColor = Color.SkyBlue;
            this.diagram1.Model.RenderingStyle.SmoothingMode = SmoothingMode.HighQuality;
            this.diagram1.Model.DocumentSize = new PageSize(this.diagram1.View.ClientRectangle.Size.Width, diagram1.View.ClientRectangle.Size.Height);
            this.diagram1.Model.BoundaryConstraintsEnabled = false;
            this.diagram1.Model.MinimumSize = diagram1.View.ClientRectangle.Size;
            this.diagram1.Model.SizeToContent = true;
            this.diagram1.View.SelectionList.Clear();
        }
#endregion

#region InitializeDiagram
        /// <summary>
        /// Initialize the Diagram
        /// </summary>
        protected void InitailizeDiagram()
        {
            Layer ethnet = CreateLayer("Ethernet Layer");
            Layer controlnet = CreateLayer("ControlNet Layer");
            Layer devicenet = CreateLayer("DeviceNet Layer");

            //	Add TextNodes to display Layer Names
            InsertTextNode("Ethernet", new PointF(350, 180), ethnet);
            InsertTextNode("Control Net", new PointF(320, 370), controlnet);
            InsertTextNode("Device Net", new PointF(500, 550), devicenet);

            // Add  TextNodes to highlight Various SymbolName.
            // Add a TextNode to highlight the Diagram Name
            Syncfusion.Windows.Forms.Diagram.TextNode txtnode = new TextNode("WIRELESS NETWORK FLOW DIAGRAM");
            txtnode.FontStyle.Size = 17;
            txtnode.FontStyle.Bold = true;
            txtnode.FontStyle.Family = "Arial";
            txtnode.FontColorStyle.Color = Color.Black;
            txtnode.LineStyle.LineColor = Color.Transparent;
            txtnode.SizeToText(Size.Empty);
            InsertNode(txtnode, new PointF(415, 25), null);

            if (this.paletteGroupBar1.CurrentSymbolPalette == null)
                return;

            // TextNode For Servers
            InsertHighlightTextNode("Servers", new PointF(250, 100), ethnet);
            // TextNode For WorkStations
            InsertHighlightTextNode("WorkStations", new PointF(480, 100), ethnet);
            // TextNode For Modem
            InsertHighlightTextNode("Modem", new PointF(600, 175), ethnet);
            // TextNode For Modem1
            InsertHighlightTextNode("Modem1", new PointF(730, 120), ethnet);
            // TextNode For RemoteController
            InsertHighlightTextNode("RemoteController", new PointF(870, 100), ethnet);
            // TextNode For RemoteWorkStations
            InsertHighlightTextNode("Remote WorkStations", new PointF(930, 250), ethnet);
            // TextNode For Modem2
            InsertHighlightTextNode("Modem2", new PointF(650, 270), ethnet);
            // TextNode For PortableWorkStations
            InsertHighlightTextNode("Portable WorkStation", new PointF(930, 320), ethnet);
            // TextNode For Modem3
            InsertHighlightTextNode("Modem3", new PointF(500, 350), ethnet);
            // TextNode For Modem4
            InsertHighlightTextNode("Modem4", new PointF(450, 230), ethnet);

            // TextNode For ControlLogic
            InsertHighlightTextNode("ControlLogic", new PointF(170, 400), controlnet);
            // TextNode For ControlLogic1
            InsertHighlightTextNode("ControlLogic1", new PointF(750, 360), controlnet);

            // TextNode For Hub Management Interface
            InsertHighlightTextNode("HMI", new PointF(910, 410), devicenet);
            // TextNode For DriveC
            InsertHighlightTextNode("DriveC", new PointF(800, 520), devicenet);
            // TextNode For DriveB
            InsertHighlightTextNode("DriveB", new PointF(650, 520), devicenet);
            // TextNode For DriveA
            InsertHighlightTextNode("DriveA", new PointF(550, 520), devicenet);
            // TextNode For Sensor
            InsertHighlightTextNode("Sensor", new PointF(400, 510), devicenet);
            // TextNode For AnalogI/O Device
            InsertHighlightTextNode("Analog I/O Device", new PointF(250, 550), devicenet);

            // Insert the Network Symbols.
            // Insert server  
            Node server = InsertNodeFromPallete(0, new PointF(236, 100), ethnet);
            //Insert server1  
            Node server1 = InsertNodeFromPallete(0, new PointF(186, 100), ethnet);
            // Insert WorkStation
            Node ws = InsertNodeFromPallete(1, new PointF(420, 100), ethnet);
            //Insert WorkStation 
            Node ws1 = InsertNodeFromPallete(1, new PointF(520, 100), ethnet);
            // Insert modem
            Node modem = InsertNodeFromPallete(2, new PointF(630, 140), ethnet);
            //Insert modem1 
            Node modem1 = InsertNodeFromPallete(2, new PointF(760, 140), ethnet);
            //Insert Portable WS
            Node rc = InsertNodeFromPallete(3, new PointF(890, 110), ethnet);
            //Insert RemoteWorkStations
            Node rws = InsertNodeFromPallete(1, new PointF(850, 230), ethnet);
            //Insert modem2
            Node modem2 = InsertNodeFromPallete(2, new PointF(650, 220), ethnet);
            //Insert RemoteController
            Node pws = InsertNodeFromPallete(1, new PointF(850, 320), ethnet);
            //Insert modem3
            Node modem3 = InsertNodeFromPallete(2, new PointF(500, 300), ethnet);
            //Insert modem4  
            Node modem4 = InsertNodeFromPallete(2, new PointF(500, 200), ethnet);

            //Insert ControlLogic
            Node clx = InsertNodeFromPallete(3, new PointF(800, 360), controlnet);
            //Insert ControlLogic1
            Node clx1 = InsertNodeFromPallete(3, new PointF(252, 360), controlnet);

            // Insert HMI
            Node hmi = InsertNodeFromPallete(4, new PointF(880, 410), devicenet);
            // Insert Analog I/O Device
            Node analog = InsertNodeFromPallete(5, new PointF(250, 470), devicenet);
            // InsertSensor Device
            Node sensor = InsertNodeFromPallete(6, new PointF(450, 470), devicenet);
            //Insert DriveA
            Node driveA = InsertNodeFromPallete(7, new PointF(550, 470), devicenet);
            //Insert DriveB
            Node driveB = InsertNodeFromPallete(7, new PointF(650, 470), devicenet);
            //Insert DriveC
            Node driveC = InsertNodeFromPallete(7, new PointF(800, 470), devicenet);

             //Insert Arrows to indicate the Network Flow.
            InsertNodeFromPallete(8, new PointF(400, 170),0, ethnet);

            InsertNodeFromPallete(8, new PointF(250, 170), 90, ethnet);
            InsertNodeFromPallete(8, new PointF(565, 340),0, controlnet);
            InsertNodeFromPallete(8, new PointF(270, 420), 90, devicenet);
            InsertNodeFromPallete(8, new PointF(575, 420), 90, devicenet);
            InsertNodeFromPallete(8, new PointF(250, 280), 90, ethnet);

            // Create Links between the NetworkSymbols.
            ConnectNodes(server, server1);
            ConnectNodes(server1, ws);
            ConnectNodes(modem4, server1);
            ConnectNodes(server, clx1);
            ConnectNodes(ws, ws1);
            ConnectNodes(ws1, modem);
            ConnectNodes(ws1, modem4);
            ConnectNodes(modem1, modem);
            ConnectNodes(modem1, rc);
            ConnectNodes(modem2, rws);
            ConnectNodes(modem3, pws);
            ConnectNodes(modem3, modem4);
            ConnectNodes(modem2, modem4);
            ConnectNodes(clx, clx1);
            ConnectNodes(clx, driveB);
            ConnectNodes(clx1, analog);
            ConnectNodes(clx, driveA);
            ConnectNodes(clx1, sensor);
            ConnectNodes(hmi, driveC);
            ConnectNodes(hmi, driveB);
        }
        /// <summary>
        /// Creates the Layer with given name
        /// </summary>
        /// <param name="strName">Layer's Name</param>
        /// <returns>returns the layer</returns>
        private Layer CreateLayer(string strName)
        {
            Layer layer = new Layer(this.diagram1.Model, strName);

            this.diagram1.Controller.Model.Layers.Add(layer);
            return layer;
        }

        /// <summary>
        /// Connects the nodes
        /// </summary>
        /// <param name="parentNode">Parent node</param>
        /// <param name="subNode">Child node</param>
        private void ConnectNodes(Node parentNode, Node subNode)
        {
            if (parentNode.CentralPort == null || subNode.CentralPort == null)
                return;

            this.diagram1.Model.BeginUpdate();

            // Create directed link
            PointF[] pts = new PointF[] { PointF.Empty, new PointF(0, 1) };
            OrthogonalConnector line = new OrthogonalConnector(pts[0], pts[1]);
            line.HeadDecorator.DecoratorShape = DecoratorShape.Filled45Arrow;
            line.HeadDecorator.FillStyle.Color = Color.Black;           
            line.LineStyle.LineColor = Color.Black;

            this.diagram1.Model.AppendChild(line);

            parentNode.CentralPort.TryConnect(line.TailEndPoint);
            subNode.CentralPort.TryConnect(line.HeadEndPoint);
            this.diagram1.Model.SendToBack(line);

            this.diagram1.Model.EndUpdate();
        }

        /// <summary>
        /// Insert the node from palette
        /// </summary>
        /// <param name="nNodeIndex">Index</param>
        /// <param name="ptPinPoint">Node's Location</param>
        /// <param name="angle">Rotation angle</param>
        /// <param name="layer">Layer</param>
        /// <returns></returns>
        private Node InsertNodeFromPallete(int nNodeIndex, PointF ptPinPoint, float angle, Layer layer)
        {
            Node node = InsertNodeFromPallete(nNodeIndex, ptPinPoint, layer);
            node.Rotate(angle);
            node.Size = new SizeF(20, 20);
            return node;
        }

        /// <summary>
        /// Insert the node from palette
        /// </summary>
        /// <param name="nNodeIndex">Index</param>
        /// <param name="ptPinPoint">Node's Location</param>
        /// <param name="layer">Layer</param>
        /// <returns>returns the node</returns>
        private Node InsertNodeFromPallete(int nNodeIndex, PointF ptPinPoint, Layer layer)
        {
            Node node = null;
            NodeCollection nodes = paletteGroupBar1.CurrentSymbolPalette.Nodes;

            if (nNodeIndex >= 0 && nNodeIndex < nodes.Count)
            {
                node = (Node)nodes[nNodeIndex].Clone();
                InsertNode(node, ptPinPoint, layer);
            }
            node.Size = new SizeF(50, 50);
            return node;
        }

        /// <summary>
        /// Insert Node into the diagram
        /// </summary>
        /// <param name="node">Node</param>
        /// <param name="ptPinPoint">Node's Location</param>
        /// <param name="layer">Layer</param>
        /// <returns>returns the node</returns>
        private Node InsertNode(Node node, PointF ptPinPoint, Layer layer)
        {
            MeasureUnits units = MeasureUnits.Pixel;

            SizeF szPinOffset = ((IUnitIndependent)node).GetPinPointOffset(units);
            ptPinPoint.X += szPinOffset.Width;
            ptPinPoint.Y += szPinOffset.Height;
            ((IUnitIndependent)node).SetPinPoint(ptPinPoint, units);

            node.EnableCentralPort = true;
            node.ShadowStyle.Visible = false;
            this.diagram1.Model.AppendChild(node);

            if (layer != null)
            {
                layer.Nodes.Add(node);
                node.Layers.Add(layer);
            }

            return node;
        }

        /// <summary>
        /// Insert the TextNode
        /// </summary>
        /// <param name="strText">TextNode's Text</param>
        /// <param name="ptPinPoint">Node's Location</param>
        /// <param name="layer">Layer</param>
        /// <returns>returns the text node</returns>
        private TextNode InsertTextNode(string strText, PointF ptPinPoint, Layer layer)
        {
            Syncfusion.Windows.Forms.Diagram.TextNode txtnode = new TextNode(strText);
            txtnode.FontStyle.Size = 15;           
            txtnode.FontStyle.Family = "Arial";
            txtnode.FontColorStyle.Color = Color.Black;
            txtnode.LineStyle.LineColor = Color.Transparent;
            txtnode.SizeToText(SizeF.Empty);
            InsertNode(txtnode, ptPinPoint, layer);

            return txtnode;
        }
        /// <summary>
        /// Insert the TextNode
        /// </summary>
        /// <param name="strText">TextNode's Text</param>
        /// <param name="ptPinPoint">Node's Location</param>
        /// <param name="layer">Layer</param>
        /// <returns>returns the text node</returns>
        private TextNode InsertHighlightTextNode(string strText, PointF ptPinPoint, Layer layer)
        {
            Syncfusion.Windows.Forms.Diagram.TextNode txtnode = new TextNode(strText);
            txtnode.FontStyle.Size = 10;            
            txtnode.FontStyle.Family = "Arial";
            txtnode.FontColorStyle.Color = Color.Black;
            txtnode.LineStyle.LineColor = Color.Transparent;
            txtnode.SizeToText(SizeF.Empty);

            InsertNode(txtnode, ptPinPoint, layer);

            return txtnode;
        }

        /// <summary>
        /// Set the visibility state for the links that enter or exit the symbols in this layer. 
        /// </summary>
        private void SetConnectingLinksVisibility()
        {
            LayerCollection layers = this.diagram1.Controller.Model.Layers;

            foreach (Layer layer in layers)
            {
                SetConnectingLinksVisibility(layer);
            }
        }

        /// <summary>
        /// Set the visibility state for the links that enter or exit the symbols in this layer. 
        /// </summary>
        /// <param name="layer">Layer</param>
        private void SetConnectingLinksVisibility(Layer layer)
        {
            this.diagram1.Model.BeginUpdate();
            NodeCollection nodes = layer.Nodes;
            bool bVisible = true;

            foreach (Node endnode1 in nodes)
            {
                ICollection linksinlayer = endnode1.Edges;

                foreach (ConnectorBase lnk in linksinlayer)
                {
                    Node endnode2 = (lnk.FromNode == endnode1) ? lnk.ToNode as Node : lnk.FromNode as Node;

                    // Show the link only if the symbols on both ends of the link are visible. 						
                    foreach (Layer lr in endnode1.Layers)
                    {
                        if (!lr.Visible)
                        {
                            bVisible = false;
                            break;
                        }
                    }

                    if (endnode2 != null)
                    {
                        foreach (Layer lr in endnode2.Layers)
                        {
                            if (!lr.Visible)
                            {
                                bVisible = false;
                                break;
                            }
                        }
                    }
                    else
                        Console.WriteLine("Nodes has been deleted...");

                    lnk.Visible = bVisible;
                    bVisible = true;
                }
            }
            this.diagram1.Model.EndUpdate();
        }
        #endregion

        #region Properties

         bool SaveChanges
        {
            get
            {
                if (diagram1.Model.Modified || needSave)
                    return true;
                else
                    return false;
            }
            set
            {
                needSave = value;
            }
        }

        public bool HasFileName
        {
            get
            {
                return (this.fileName != null && this.fileName.Length > 0);
            }
        }

#endregion

#region Event Handlers

        private void createLyr_Click(object sender, EventArgs e)
        {
            Layer nwLayer = new Layer();
            nwLayer.Name = txtLayerName.Text;
            nwLayer.Enabled = chkEnableNewlayer.Checked;
            if (nwLayer.Name != string.Empty)
            {
                comboLayers.Items.Add(nwLayer.Name);
            }
            diagram1.Model.Layers.Add(nwLayer);
            diagram1.Model.ActiveLayers.Add(nwLayer);
        }

        private void apply_Click(object sender, EventArgs e)
        {
            this.diagram1.Model.BeginUpdate();
            if (comboLayers.Items.Count > 0 && comboLayers.SelectedItem != null)
            {
                Layer curLayer = this.diagram1.Model.Layers[comboLayers.SelectedItem.ToString()];
                if (chkVisibleLyr.Checked)
                {
                    curLayer.Visible = true;
                    this.SetConnectingLinksVisibility();
                }
                else
                {
                    curLayer.Visible = false;
                    this.SetConnectingLinksVisibility();
                }

                if (chkEnableLyr.Checked)
                {
                    curLayer.Enabled = true;
                }
                else
                {
                    curLayer.Enabled = false;
                }
                if (chkRemoveLyr.Checked)
                {
                    Layer lyr = diagram1.Model.Layers[comboLayers.SelectedItem.ToString()];
                    for (int i = lyr.Nodes.Count - 1; i >= 0; i--)
                    {
                        ICollection lnklayer = lyr.Nodes[i].Edges;
                        foreach (ConnectorBase lnk in lnklayer)
                        {
                            diagram1.Model.Nodes.Remove(lnk);
                            comboLayers.Text = string.Empty;
                        }
                        diagram1.Model.Nodes.Remove(lyr.Nodes[i]);
                    }
                    diagram1.Model.Layers.Remove(lyr);
                    comboLayers.Items.Remove(comboLayers.SelectedItem);
                }
                this.diagram1.EndUpdate();
                this.diagram1.Invalidate(true);
            }
        }

        private void comboLayers_SelectedIndexChanged(object sender, EventArgs e)
        {
            Layer lyr = this.diagram1.Model.Layers[comboLayers.SelectedItem.ToString()];
            chkEnableLyr.Checked = lyr.Enabled;
            chkVisibleLyr.Checked = lyr.Visible;
        }
       
#region Hide/show layers
        private void Ethernet_CheckedChanged(object sender, EventArgs e)
        {
            this.diagram1.Model.BeginUpdate();
            Layer ethernet = this.diagram1.Model.Layers["Ethernet Layer"];
            if (ethernet.Visible)
            {
                ethernet.Visible = false;
            }
            else
            {
                ethernet.Visible = true;
            }
            this.SetConnectingLinksVisibility();
            this.diagram1.EndUpdate();
            this.diagram1.Invalidate(true);

        }

        private void ControlNet_CheckedChanged(object sender, EventArgs e)
        {
            this.diagram1.Model.BeginUpdate();
            Layer controlnet = this.diagram1.Model.Layers["ControlNet Layer"];
            if (controlnet.Visible)
            {
                controlnet.Visible = false;
            }
            else
            {
                controlnet.Visible = true;
            }
            this.SetConnectingLinksVisibility();
            this.diagram1.EndUpdate();
            this.diagram1.Invalidate(true);
        }

        private void DeviceNet_CheckedChanged(object sender, EventArgs e)
        {
            this.diagram1.Model.BeginUpdate();
            Layer devicenet = this.diagram1.Model.Layers["DeviceNet Layer"];
            if (devicenet.Visible)
            {
                devicenet.Visible = false;
            }
            else
            {
                devicenet.Visible = true;
            }
            this.SetConnectingLinksVisibility();
            this.diagram1.EndUpdate();
            this.diagram1.Invalidate(true);
        }
#endregion
       

        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            if (this.SaveChanges)
            {
                DialogResult res = MessageBoxAdv.Show(this, "The diagram or its association has been modified. Save changes?", "Save changes", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    this.saveFileDialog1.FileName = "Diagram";
                    saveFileDialog1.Filter = @"XML file(*.xml)|*.xml|EDD file(*.edd)|*.edd|All files|*.*";
                    saveFileDialog1.Title = "Save File As:";

                    if (this.HasFileName)
                    {
                        this.saveFileDialog1.FileName = this.fileName;
                    }
                    if (this.saveFileDialog1.ShowDialog(this) == DialogResult.OK)
                    {
                        this.fileName = this.saveFileDialog1.FileName;
                        SaveDiagramAs(saveFileDialog1.FileName, saveFileDialog1.FilterIndex);
                        diagram1.Model.Clear();
                        Model model = new Model();
                        model.RenderingStyle.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
                        model.LineStyle.LineColor = Color.LightGray;
                        diagram1.Model = model;
                    }
                }
                else if (res == DialogResult.No)
                {
                    diagram1.Model.Clear();
                    Model model = new Model();
                    model.RenderingStyle.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
                    model.LineStyle.LineColor = Color.LightGray;
                    diagram1.Model = model;
                    comboLayers.Items.Clear();
                    comboLayers.Text = "";
                }
            }
        }      
        

#endregion
               
#region Helper Methods
        private void SaveDiagramAs(string filename, int index)
        {
            switch (index)
            {
                case 1:
#if NETCORE || NET50 || NET80 || NET60 || NET70 || NET90 || SyncfusionFramework4_6_2 || SyncfusionFramework4_6 || SyncfusionFramework4_5_1 || SyncfusionFramework4_5

                    diagram1.SaveXml(filename);
                    this.diagram1.Refresh();
#else
                        this.diagram1.SaveSoap(filename);
#endif
                    break;
                case 2:
                    diagram1.SaveBinary(filename);

                    break;
                default:
                    diagram1.SaveBinary(filename);
                    break;
            }
        }
       
#endregion
       
    }
}



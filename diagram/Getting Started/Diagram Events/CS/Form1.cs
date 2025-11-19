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
using System.Drawing.Imaging;
using Syncfusion.Windows.Forms.Tools;
using Syncfusion.Windows.Forms.Diagram.Controls;
using System.Drawing.Drawing2D;
using Syncfusion.Windows.Forms;
using System.IO;
using System.Drawing.Printing;
using Syncfusion.SVG.IO;
using DemoCommon.Diagram;


namespace DiagramEvents
{
    public partial class Form1 : Form
    {
#region Members
        private bool mload = true;
#endregion

#region Form Initialize 
        public Form1()
        {
            InitializeComponent();
#if !NETCORE
            paletteGroupBar1.LoadPalette(@"..\..\..\..\..\..\common\Data\Diagram\xml\Flowchart Symbols.xml");
#else
            paletteGroupBar1.LoadPalette(@"..\..\..\..\..\..\..\common\Data\Diagram\xml\Flowchart Symbols.xml");
#endif
            GroupBarAppearance();
            diagram1.Model.LineStyle.LineColor = Color.LightGray;
            //diagram view settings
            diagram1.View.Grid.GridStyle = Syncfusion.Windows.Forms.Diagram.GridStyle.Line;
            diagram1.View.Grid.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            diagram1.View.Grid.Color = Color.LightGray;
            diagram1.View.HandleRenderer.HandleColor = Color.White;
            diagram1.View.HandleRenderer.HandleOutlineColor = Color.Gray;
            diagram1.View.BackgroundColor = Color.White;
            diagram1.View.Grid.HorizontalSpacing = 15;
            diagram1.View.Grid.VerticalSpacing = 15;                  
            
            this.diagram1.HScroll = false;
            this.diagram1.VScroll = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            diagram1.DragDrop += new DragEventHandler(diagram1_DragDrop);
            diagram1.EventSink.NodeCollectionChanging += new CollectionExEventHandler(EventSink_NodeCollectionChanging);
            diagram1.EventSink.NodeCollectionChanged += new CollectionExEventHandler(EventSink_NodeCollectionChanged);           
            diagram1.EventSink.NodeSelected += new NodeSelectedEventHandler(EventSink_NodeSelected);     
            diagram1.EventSink.NodeDeselected += new NodeSelectedEventHandler(EventSink_NodeDeselected);       
            diagram1.EventSink.NodeClick += new NodeMouseEventHandler(EventSink_NodeClick);       
            diagram1.EventSink.NodeDoubleClick += new NodeMouseEventHandler(EventSink_NodeDoubleClick);       
            diagram1.EventSink.NodeMouseEnter += new NodeMouseEventHandler(EventSink_NodeMouseEnter);       
            diagram1.EventSink.NodeMouseLeave += new NodeMouseEventHandler(EventSink_NodeMouseLeave);       
            diagram1.EventSink.SelectionListChanging += new CollectionExEventHandler(EventSink_SelectionListChanging);
            diagram1.EventSink.SelectionListChanged += new CollectionExEventHandler(EventSink_SelectionListChanged);        
            diagram1.EventSink.MagnificationChanged += new ViewMagnificationEventHandler(EventSink_MagnificationChanged);        
            diagram1.EventSink.OriginChanged += new ViewOriginEventHandler(EventSink_OriginChanged);
        }
#endregion

#region Private Methods
        /// <summary>
        /// Change's the appearance of Diagram
        /// </summary>
        private void DiagramAppearance()
        {
            this.diagram1.Model.LineStyle.LineColor = Color.LightGray;
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
            this.diagram1.Model.DocumentSize = new PageSize(this.diagram1.View.ClientRectangle.Size.Width, diagram1.View.ClientRectangle.Size.Height);
            this.diagram1.Model.BoundaryConstraintsEnabled = false;
            this.diagram1.Model.MinimumSize = diagram1.View.ClientRectangle.Size;
            this.diagram1.Model.SizeToContent = true;
            this.diagram1.View.BackgroundColor = Color.White;
            this.diagram1.View.SelectionList.Clear();
        }

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
#endregion

#region Event Handlers
        private void MainForm_Activated(object sender, EventArgs e)
        {
            if (this.mload)
            {
                this.mload = false;
#if !NETCORE
                MessageBoxAdv.Office2007Theme = Office2007Theme.Blue;
                MessageBoxAdv.Show("Drag and drop a Symbol from the Symbol Palette and watch the events fired in the daigram control through Event log viewer", "Essential Diagram ", MessageBoxButtons.OK, MessageBoxIcon.Information);
#else
                MessageBox.Show("Drag and drop a Symbol from the Symbol Palette and watch the events fired in the daigram control through Event log viewer", "Essential Diagram ", MessageBoxButtons.OK, MessageBoxIcon.Information);
#endif
                this.Activate();
            }
        }
        void diagram1_DragDrop(object sender, DragEventArgs e)
        {
            listBox1.Items.Add("\nDrag drop event Fired.\n");
        }
        void EventSink_OriginChanged(ViewOriginEventArgs evtArgs)
        {
             listBox1.Items.Add("\nOriginChanged event Fired.\n"); 
        }

        void EventSink_MagnificationChanged(ViewMagnificationEventArgs evtArgs)
        {
             listBox1.Items.Add( "\nMagnificationChanged event Fired.\n"); 
        }

        void EventSink_SelectionListChanged(CollectionExEventArgs evtArgs)
        {
             listBox1.Items.Add( "\nSelectionListChanged event Fired.\n"); 
        }

        void EventSink_SelectionListChanging(CollectionExEventArgs evtArgs)
        {
             listBox1.Items.Add("\nSelectionListChanging event Fired.\n"); 
        }

        void EventSink_NodeMouseLeave(NodeMouseEventArgs evtArgs)
        {
             listBox1.Items.Add("\nNodeMouseLeave event Fired.\n"); 
        }

        void EventSink_NodeDoubleClick(NodeMouseEventArgs evtArgs)
        {
             listBox1.Items.Add("\nNodeDoubleClick event Fired.\n"); 
        }

        void EventSink_NodeClick(NodeMouseEventArgs evtArgs)
        {
             listBox1.Items.Add("\nNodeClick event Fired.\n"); 
        }

        void EventSink_NodeDeselected(NodeSelectedEventArgs evtArgs)
        {
             listBox1.Items.Add( "\nNodeDeselected event Fired.\n"); 
        }

        void EventSink_NodeMouseEnter(NodeMouseEventArgs evtArgs)
        {
             listBox1.Items.Add("\nNodeMouseEnter event Fired.\n"); 
        }

        void EventSink_NodeSelected(NodeSelectedEventArgs evtArgs)
        {
            listBox1.Items.Add("\nNodeSelected event Fired.\n"); 
        }

        void EventSink_NodeCollectionChanged(CollectionExEventArgs evtArgs)
        {
             listBox1.Items.Add( "\nNodeCollectionChanged event Fired.\n"); 
        }

        void EventSink_NodeCollectionChanging(CollectionExEventArgs evtArgs)
        {
            listBox1.Items.Add("\nNodeCollectionChanging event Fired.\n"); 
        }

        private void clear_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

#endregion
               
    }
   
}

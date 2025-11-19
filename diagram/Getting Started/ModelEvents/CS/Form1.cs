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


namespace ModelEvents
{
    public partial class Form1 : MetroForm
    {
        #region Members
        private bool mload = true;
        #endregion

        #region Form Initialize
        public Form1()
        {
            InitializeComponent();
            this.diagram1.HScroll = false;
            this.diagram1.VScroll = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            diagram1.BeginUpdate();            
            this.diagram1.Model.SizeToContent = true;
            this.diagram1.Model.BoundaryConstraintsEnabled = false;
#if !NETCORE
            paletteGroupBar1.LoadPalette(@"..\..\..\..\..\..\common\Data\Diagram\xml\Flowchart Symbols.xml");
#else
            paletteGroupBar1.LoadPalette(@"..\..\..\..\..\..\..\common\Data\Diagram\xml\Flowchart Symbols.xml");
#endif
            DiagramAppearance();
            GroupBarAppearance();
            diagram1.EndUpdate();
           
            diagram1.Model.EventSink.NodeCollectionChanging += new CollectionExEventHandler(EventSink_NodeCollectionChanging);        
            diagram1.Model.EventSink.NodeCollectionChanged += new CollectionExEventHandler(EventSink_NodeCollectionChanged);       
            diagram1.Model.EventSink.ConnectionsChanging += new CollectionExEventHandler(EventSink_ConnectionsChanging);       
            diagram1.Model.EventSink.ConnectionsChanged += new CollectionExEventHandler(EventSink_ConnectionsChanged);       
            diagram1.Model.EventSink.PinPointChanging += new PinPointChangingEventHandler(EventSink_PinPointChanging);        
            diagram1.Model.EventSink.PinPointChanged += new PinPointChangedEventHandler(EventSink_PinPointChanged);        
            diagram1.Model.EventSink.SizeChanging += new SizeChangingEventHandler(EventSink_SizeChanging);        
            diagram1.Model.EventSink.SizeChanged += new SizeChangedEventHandler(EventSink_SizeChanged);       
            diagram1.Model.EventSink.PropertyChanging += new Syncfusion.Windows.Forms.Diagram.PropertyChangingEventHandler(EventSink_PropertyChanging);       
            diagram1.Model.EventSink.PropertyChanged += new Syncfusion.Windows.Forms.Diagram.PropertyChangedEventHandler(EventSink_PropertyChanged);       
            diagram1.Model.EventSink.FlipChanging += new FlipChangingEventHandler(EventSink_FlipChanging);       
            diagram1.Model.EventSink.FlipChanged += new FlipChangedEventHandler(EventSink_FlipChanged);       
            diagram1.Model.EventSink.ZOrderChanging += new ZOrderChangingEventHandler(EventSink_ZOrderChanging);       
            diagram1.Model.EventSink.ZOrderChanged += new ZOrderChangedEventHandler(EventSink_ZOrderChanged);       
            diagram1.Model.EventSink.VertexChanging += new VertexChangingEventHandler(EventSink_VertexChanging);      
            diagram1.Model.EventSink.VertexChanged += new VertexChangedEventHandler(EventSink_VertexChanged);
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
            this.diagram1.View.HandleRenderer.HandleColor = Color.AliceBlue;
            this.diagram1.View.HandleRenderer.HandleOutlineColor = Color.SkyBlue;
            this.diagram1.Model.RenderingStyle.SmoothingMode = SmoothingMode.HighQuality;
            this.diagram1.Model.DocumentSize = new PageSize(this.diagram1.View.ClientRectangle.Size.Width, diagram1.View.ClientRectangle.Size.Height);
            this.diagram1.Model.BoundaryConstraintsEnabled = false;
            this.diagram1.Model.MinimumSize = diagram1.View.ClientRectangle.Size;
            this.diagram1.Model.SizeToContent = true;
            diagram1.View.BackgroundColor = Color.White;
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
                MessageBoxAdv.Show("Drag and drop a Symbol from the Symbol Palette and watch the events fired in the diagram control through Event log viewer", "Essential Diagram ", MessageBoxButtons.OK, MessageBoxIcon.Information);
#else
                MessageBox.Show("Drag and drop a Symbol from the Symbol Palette and watch the events fired in the diagram control through Event log viewer", "Essential Diagram ", MessageBoxButtons.OK, MessageBoxIcon.Information);
#endif
                this.Activate();
            }
        }

        void EventSink_VertexChanged(VertexChangedEventArgs evtArgs)
        {
             listBox1.Items.Add("\nVertexChanged event Fired.\n"); 
        }

        void EventSink_VertexChanging(VertexChangingEventArgs evtArgs)
        {
             listBox1.Items.Add("\nVertexChanging event Fired.\n"); 
        }

        void EventSink_ZOrderChanged(ZOrderChangedEventArgs evtArgs)
        {
             listBox1.Items.Add("\nZOrderChanged event Fired.\n"); 
        }

        void EventSink_ZOrderChanging(ZOrderChangingEventArgs evtArgs)
        {
             listBox1.Items.Add("\nZOrderChanging event Fired.\n"); 
        }

        void EventSink_FlipChanged(FlipChangedEventArgs evtArgs)
        {
             listBox1.Items.Add( "\nFlipChanged event Fired.\n"); 
        }

        void EventSink_FlipChanging(FlipChangingEventArgs evtArgs)
        {
             listBox1.Items.Add("\nFlipChanging event Fired.\n"); 
        }

        void EventSink_PropertyChanged(Syncfusion.Windows.Forms.Diagram.PropertyChangedEventArgs evtArgs)
        {
             listBox1.Items.Add( "\nPropertyChanged event Fired.\n"); 
        }

        void EventSink_PropertyChanging(Syncfusion.Windows.Forms.Diagram.PropertyChangingEventArgs evtArgs)
        {
            listBox1.Items.Add( "\nPropertyChanging event Fired.\n"); 
        }

        void EventSink_SizeChanged(SizeChangedEventArgs evtArgs)
        {
             listBox1.Items.Add("\nSizeChanged event Fired.\n"); 
        }

        void EventSink_SizeChanging(SizeChangingEventArgs evtArgs)
        {
             listBox1.Items.Add("\nSizeChanging event Fired.\n"); 
        }

        void EventSink_PinPointChanged(PinPointChangedEventArgs evtArgs)
        {
             listBox1.Items.Add("\nPinPointChanged event Fired.\n"); 
        }

        void EventSink_PinPointChanging(PinPointChangingEventArgs evtArgs)
        {
             listBox1.Items.Add("\nPinPointChanging event Fired.\n"); 
        }

        void EventSink_ConnectionsChanged(CollectionExEventArgs evtArgs)
        {
             listBox1.Items.Add("\nConnectionsChanged event Fired.\n"); 
        }

        void EventSink_ConnectionsChanging(CollectionExEventArgs evtArgs)
        {
             listBox1.Items.Add("\nConnectionsChanging event Fired.\n"); 
        }

        void EventSink_NodeCollectionChanged(CollectionExEventArgs evtArgs)
        {
             listBox1.Items.Add("\nNodeCollectionChanged event Fired.\n"); 
        }

        void EventSink_NodeCollectionChanging(CollectionExEventArgs evtArgs)
        {
             listBox1.Items.Add("\nNodeCollectionChanging event Fired.\n"); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }
#endregion
    }   
}

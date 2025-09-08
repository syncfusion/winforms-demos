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
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Xml;

namespace Serialization
{
    public partial class Form1 : Form
    {
        #region Members
        private string fileName = null;
        private bool promptOnSave = true;
        #endregion

        #region Form Initialize
        public Form1()
        {
            InitializeComponent();
            this.diagram1.Model = this.model1;
            this.FileName = "Diagram1";
            // Load Palette

#if !(NET60 || NET70 || NET80 || NET90)
            this.paletteGroupBar1.LoadPalette(@"..\..\..\..\..\..\common\Data\Diagram\xml\Flowchart Symbols.xml");
#else
            this.paletteGroupBar1.LoadPalette(@"..\..\..\..\..\..\..\common\Data\Diagram\xml\Flowchart Symbols.xml");
#endif
            Diagram();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            diagram1.BeginUpdate();         
            DiagramAppearance();        
            GroupBarAppearance();
            diagram1.EndUpdate();
        }
#endregion

#region Private Methods

        private void Diagram()
        {
            Node decision = paletteGroupBar1.CurrentSymbolPalette.Nodes["Decision"];
            decision.PinPoint = new PointF(100, 100);
            decision.Size = new SizeF(120, 100);
            diagram1.Model.AppendChild(decision);
            Node process = paletteGroupBar1.CurrentSymbolPalette.Nodes["Process"];
            process.PinPoint = new PointF(300, 100);
            process.Size = new SizeF(120, 80);
            diagram1.Model.AppendChild(process);
            Node internalstorage = paletteGroupBar1.CurrentSymbolPalette.Nodes["Internal Storage"];
            internalstorage.PinPoint = new PointF(100, 300);
            internalstorage.Size = new SizeF(100, 100);
            diagram1.Model.AppendChild(internalstorage);
            Syncfusion.Windows.Forms.Diagram.LineConnector lineconnector = new Syncfusion.Windows.Forms.Diagram.LineConnector(new System.Drawing.PointF(100, 100), new System.Drawing.PointF(300, 100));
            decision.CentralPort.TryConnect(lineconnector.TailEndPoint);
            process.CentralPort.TryConnect(lineconnector.HeadEndPoint);
            diagram1.Model.AppendChild(lineconnector);
            Syncfusion.Windows.Forms.Diagram.LineConnector lineconnector2 = new Syncfusion.Windows.Forms.Diagram.LineConnector(new System.Drawing.PointF(100, 150), new System.Drawing.PointF(100, 250));
            diagram1.Model.AppendChild(lineconnector2);
            decision.CentralPort.TryConnect(lineconnector2.TailEndPoint);
            internalstorage.CentralPort.TryConnect(lineconnector2.HeadEndPoint);
        }
        /// <summary>
        /// Change's the appearance of the Diagram 
        /// </summary>
        private void DiagramAppearance()
        {
            this.diagram1.Model.LineStyle.LineColor = Color.LightGray;           
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

        /// <summary>
        /// Change's the appearance of the GroupBarAppearance 
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
        
#region Properties

        private string FileName
        {
            get
            {
                return this.fileName;
            }
            set
            {
                this.fileName = value;
                string docName = Path.GetFileNameWithoutExtension(this.fileName);

            }
        }
#endregion

#region Event Handlers
        private void newToolStripButton_Click_1(object sender, EventArgs e)
        {
            this.diagram1.Model.Clear();
        }

        private void openToolStripButton_Click_1(object sender, EventArgs e)
        {
            openFileDialog1.Filter = @"XML file(*.xml)|*.xml|EDD file(*.edd)|*.edd";
            if (this.openFileDialog1.ShowDialog(this) == DialogResult.OK)
            {
                this.FileName = this.openFileDialog1.FileName;

                switch (this.openFileDialog1.FilterIndex)
                {
                    case 1:

#if NET80 || NET60 || NET70 || NET90 || SyncfusionFramework4_6_2 || SyncfusionFramework4_6 || SyncfusionFramework4_5_1 || SyncfusionFramework4_5

                        diagram1.LoadXml(this.FileName);
#else
                        diagram1.LoadSoap(this.FileName);
#endif

                        break;
                    case 2:
#if NET80 || NET60 || NET70 || NET90 || SyncfusionFramework4_6_2 || SyncfusionFramework4_6 || SyncfusionFramework4_5_1 || SyncfusionFramework4_5 || SyncfusionFramework4_0
                        diagram1.LoadBinary(this.FileName);
#endif
                        break;
                 
                }
                this.promptOnSave = false;
                this.diagram1.Refresh();
            }
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            if (this.promptOnSave)
            {
                this.saveFileDialog1.FileName = this.fileName;
                saveFileDialog1.Filter = @"XML file(*.xml)|*.xml|EDD file(*.edd)|*.edd";
                if (this.saveFileDialog1.ShowDialog(this) == DialogResult.OK)
                {
                    this.FileName = this.saveFileDialog1.FileName;
                    switch (saveFileDialog1.FilterIndex)
                    {
                        case 1:
#if NET80 || NET60 || NET70 || NET90 || SyncfusionFramework4_6_2 || SyncfusionFramework4_6 || SyncfusionFramework4_5_1 || SyncfusionFramework4_5

                            diagram1.SaveXml(this.FileName);
                            this.diagram1.Refresh();
#else
                this.diagram1.SaveSoap(this.fileName);
#endif
                            break;
                        case 2:
#if NET80 || NET60 || NET70 || NET90 || SyncfusionFramework4_6_2 || SyncfusionFramework4_6 || SyncfusionFramework4_5_1 || SyncfusionFramework4_5 || SyncfusionFramework4_0
                            diagram1.SaveBinary(this.FileName);
#endif
                            break;
                        
                    }
                }
                this.promptOnSave = false;
            }
            else
            {
                FileInfo fi = new FileInfo(this.fileName);
                if (fi.Extension == ".edp")
#if NET80 || NET60 || NET70 || NET90 || SyncfusionFramework4_6_2 || SyncfusionFramework4_6 || SyncfusionFramework4_5_1 || SyncfusionFramework4_5 || SyncfusionFramework4_0
                    diagram1.SaveBinary(this.FileName);
#endif
                else if (fi.Extension == ".xml")
#if NET80 || NET60 || NET70 || NET90 || SyncfusionFramework4_6_2 || SyncfusionFramework4_6 || SyncfusionFramework4_5_1 || SyncfusionFramework4_5

                            diagram1.SaveXml(this.FileName);
                            this.diagram1.Refresh();
#else
                this.diagram1.SaveSoap(this.fileName);
#endif

            }
        }

      
        private void saveAsToolStripButton_Click(object sender, EventArgs e)
        {
            this.saveFileDialog1.FileName = this.fileName;
            saveFileDialog1.Filter = @"XML file(*.xml)|*.xml|EDD file(*.edd)|*.edd";
            if (this.saveFileDialog1.ShowDialog(this) == DialogResult.OK)
            {
                this.FileName = this.saveFileDialog1.FileName;
                switch (saveFileDialog1.FilterIndex)
                {
                    case 1:
#if NET80 || NET60 || NET70 || NET90 || SyncfusionFramework4_6_2 || SyncfusionFramework4_6 || SyncfusionFramework4_5_1 || SyncfusionFramework4_5

                        diagram1.SaveXml(this.FileName);
                        this.diagram1.Refresh();
#else
                this.diagram1.SaveSoap(this.fileName);
#endif
                        break;
                    case 2:
#if NET80 || NET60 || NET70 || NET90 || SyncfusionFramework4_6_2 || SyncfusionFramework4_6 || SyncfusionFramework4_5_1 || SyncfusionFramework4_5 || SyncfusionFramework4_0
                        diagram1.SaveBinary(this.FileName);
#endif
                        break;
                    
                }
            }
        }      
        
#endregion

        
    }
}

#region Copyright Syncfusion Inc. 2001 - 2012
// Copyright Syncfusion Inc. 2001 - 2012. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion

using System;
using System.ComponentModel;
using System.Windows.Forms;
using Syncfusion.Windows.Forms.Diagram;
using Syncfusion.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Threading;
using System.Globalization;
using System.Resources;
using Syncfusion.Windows.Forms.Tools;
using Syncfusion.Windows.Forms.Diagram.Controls;
using Syncfusion.Licensing;

namespace CustomCommand
{
    /// <summary>
    /// Summary description for Form1.
    /// </summary>
    public partial class Form1 : Form
    {
        public Form1( ) {
            // Sets the culture to French (France)
            Thread.CurrentThread.CurrentCulture = new CultureInfo("ar-EG");
            // Sets the UI culture to French (France)
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("ar-EG");

            InitializeComponent( );
            this.diagram1.HScroll = false;
            this.diagram1.VScroll = false;
            this.diagram1.Model = this.model1;          
        }

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// 
        protected override void OnLoad( EventArgs e ) {
            base.OnLoad( e );
            Application.Idle += new EventHandler( Application_Idle );
            
        }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main( ) {
            SyncfusionLicenseProvider.RegisterLicense(DemoCommon.FindLicenseKey());
            // Sets the culture to French (France)
            Thread.CurrentThread.CurrentCulture = new CultureInfo("ar-EG");
            // Sets the UI culture to French (France)
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("ar-EG");
            Application.EnableVisualStyles();
            Application.Run( new Form1( ) );
        }

        #region Class Events
        /// <summary>
        /// Loads the Symbol palette into the palettegroupBar
        /// </summary>
        protected void LoadSymbolPalette( ) {
            // Create a SymbolPalette for the PaletteGroupView control
#if !NETCORE
            this.paletteGroupBar1.LoadPalette(@"..\..\..\..\..\..\common\Data\Diagram\xml\Flowchart Symbols.xml");
            this.paletteGroupBar1.LoadPalette(@"..\..\..\..\..\..\common\Data\Diagram\xml\Basic Shapes.xml");
#else
            this.paletteGroupBar1.LoadPalette(@"..\..\..\..\..\..\..\common\Data\Diagram\xml\Flowchart Symbols.xml");
            this.paletteGroupBar1.LoadPalette(@"..\..\..\..\..\..\..\common\Data\Diagram\xml\Basic Shapes.xml");
#endif

        }
        void LoadDiagram()
        {
            this.diagram1.Model.HistoryManager.Pause();
            this.diagram1.Model.RenderingStyle.SmoothingMode = SmoothingMode.HighQuality;
            Syncfusion.Windows.Forms.Diagram.Ellipse ellipse = new Syncfusion.Windows.Forms.Diagram.Ellipse(495, 5, 110, 70);
            ellipse.FillStyle.Type = FillStyleType.LinearGradient;
            ellipse.FillStyle.Color = Color.FromArgb(51, 153, 255);
            ellipse.FillStyle.ForeColor = Color.FromArgb(51, 153, 255);
            ellipse.LineStyle.LineColor = Color.Black;
            ellipse.LineStyle.LineWidth = 2.0f;
            ellipse.LineStyle.LineJoin = LineJoin.Miter;
            Syncfusion.Windows.Forms.Diagram.Label label = new Syncfusion.Windows.Forms.Diagram.Label();
            label.Text = "Start";
            label.FontStyle.Family = "Arial";
            ellipse.Labels.Add(label);
            diagram1.Model.AppendChild(ellipse);
            Syncfusion.Windows.Forms.Diagram.Rectangle process = new Syncfusion.Windows.Forms.Diagram.Rectangle(500, 100, 100, 70);
            process.FillStyle.Type = FillStyleType.LinearGradient;
            process.FillStyle.Color = Color.FromArgb(51, 153, 255);
            process.FillStyle.ForeColor = Color.FromArgb(51, 153, 255);
            process.LineStyle.LineColor = Color.Black;
            process.LineStyle.LineWidth = 2.0f;
            process.LineStyle.LineJoin = LineJoin.Miter;
            Syncfusion.Windows.Forms.Diagram.Label label2 = new Syncfusion.Windows.Forms.Diagram.Label();
            label2.Text = "Process";
            label2.FontStyle.Family = "Arial";
            process.Labels.Add(label2);
            diagram1.Model.AppendChild(process);
            OrthogonalConnector link = new OrthogonalConnector(ellipse.PinPoint, process.PinPoint);
            link.LineStyle.LineColor = Color.Black;
            link.LineStyle.LineWidth = 2f;
            diagram1.Model.AppendChild(link);
            link.HeadDecorator.DecoratorShape = DecoratorShape.Filled45Arrow;
            link.HeadDecorator.Size = new SizeF(8, 8);
            link.HeadDecorator.FillStyle.Color = Color.Black;
            link.HeadDecorator.LineStyle.LineColor = Color.Black;
            ellipse.CentralPort.TryConnect(link.TailEndPoint);
            process.CentralPort.TryConnect(link.HeadEndPoint);
            Polygon decision = new Polygon(new PointF[] { new PointF(0, 50), new PointF(50, 0), new PointF(100, 50), new PointF(50, 100), new PointF(0, 50) });
            decision.FillStyle.Type = FillStyleType.LinearGradient;
            decision.FillStyle.Color = Color.FromArgb(51, 153, 255);
            decision.FillStyle.ForeColor = Color.FromArgb(51, 153, 255);
            decision.LineStyle.LineColor = Color.Black;
            decision.LineStyle.LineWidth = 2.0f;
            decision.LineStyle.LineJoin = LineJoin.Miter;
            Syncfusion.Windows.Forms.Diagram.Label label3 = new Syncfusion.Windows.Forms.Diagram.Label();
            label3.Text = "Decision";
            label3.FontStyle.Family = "Arial";
            decision.Labels.Add(label3);
            decision.PinPoint = new PointF(550, 250);
            diagram1.Model.AppendChild(decision);
            OrthogonalConnector link2 = new OrthogonalConnector(decision.PinPoint, process.PinPoint);
            link2.LineStyle.LineColor = Color.Black;
            link2.LineStyle.LineWidth = 2f;
            diagram1.Model.AppendChild(link2);
            link2.TailDecorator.DecoratorShape = DecoratorShape.Filled45Arrow;
            link2.TailDecorator.Size = new SizeF(8, 8);
            link2.TailDecorator.FillStyle.Color = Color.Black;
            link2.TailDecorator.LineStyle.LineColor = Color.Black;
            decision.CentralPort.TryConnect(link2.TailEndPoint);
            process.CentralPort.TryConnect(link2.HeadEndPoint);
            Syncfusion.Windows.Forms.Diagram.Rectangle process2 = new Syncfusion.Windows.Forms.Diagram.Rectangle(500, 325, 100, 70);
            process2.FillStyle.Type = FillStyleType.LinearGradient;
            process2.FillStyle.Color = Color.FromArgb(51, 153, 255);
            process2.FillStyle.ForeColor = Color.FromArgb(51, 153, 255);
            process2.LineStyle.LineColor = Color.Black;
            process2.LineStyle.LineWidth = 2.0f;
            process2.LineStyle.LineJoin = LineJoin.Miter;
            Syncfusion.Windows.Forms.Diagram.Label label4 = new Syncfusion.Windows.Forms.Diagram.Label();
            label4.Text = "Process2";
            label4.FontStyle.Family = "Arial";
            process2.Labels.Add(label4);
            diagram1.Model.AppendChild(process2);
            diagram1.Model.AppendChild(decision); OrthogonalConnector link3 = new OrthogonalConnector(decision.PinPoint, process2.PinPoint);
            link3.LineStyle.LineColor = Color.Black;
            link3.LineStyle.LineWidth = 2f;
            diagram1.Model.AppendChild(link3);
            link3.TailDecorator.DecoratorShape = DecoratorShape.Filled45Arrow;
            link3.TailDecorator.Size = new SizeF(8, 8);
            link3.TailDecorator.FillStyle.Color = Color.Black;
            link3.TailDecorator.LineStyle.LineColor = Color.Black;
            decision.CentralPort.TryConnect(link3.HeadEndPoint);
            process2.CentralPort.TryConnect(link3.TailEndPoint);
            Syncfusion.Windows.Forms.Diagram.Ellipse ellipse2 = new Syncfusion.Windows.Forms.Diagram.Ellipse(495, 420, 110, 70);
            ellipse2.FillStyle.Type = FillStyleType.LinearGradient;
            ellipse2.FillStyle.Color = Color.FromArgb(51, 153, 255);
            ellipse2.FillStyle.ForeColor = Color.FromArgb(51, 153, 255);
            ellipse2.LineStyle.LineColor = Color.Black;
            ellipse2.LineStyle.LineWidth = 2.0f;
            ellipse2.LineStyle.LineJoin = LineJoin.Miter;
            Syncfusion.Windows.Forms.Diagram.Label label5 = new Syncfusion.Windows.Forms.Diagram.Label();
            label5.Text = "End";
            label5.FontStyle.Family = "Arial";
            ellipse2.Labels.Add(label5);
            diagram1.Model.AppendChild(ellipse2);
            diagram1.Model.AppendChild(decision); OrthogonalConnector link4 = new OrthogonalConnector(process2.PinPoint, ellipse2.PinPoint);
            link4.LineStyle.LineColor = Color.Black;
            link4.LineStyle.LineWidth = 2f;
            diagram1.Model.AppendChild(link4);
            link4.HeadDecorator.DecoratorShape = DecoratorShape.Filled45Arrow;
            link4.HeadDecorator.Size = new SizeF(8, 8);
            link4.HeadDecorator.FillStyle.Color = Color.Black;
            link4.HeadDecorator.LineStyle.LineColor = Color.Black;

            ellipse2.CentralPort.TryConnect(link4.HeadEndPoint);
            process2.CentralPort.TryConnect(link4.TailEndPoint);
            this.diagram1.Model.HistoryManager.Resume();
            diagram1.View.SelectionList.Clear();
        }

        private void Application_Idle( object sender, EventArgs e ) {
            // update UI
            string strBIText = "Undo";

            string[] strDescriptions;
            int nDescWanted = 1;
            int nDescReturned = this.diagram1.Model.HistoryManager.GetUndoDescriptions( nDescWanted, out strDescriptions );

            if ( nDescReturned == nDescWanted )
                strBIText = strBIText + " " + strDescriptions[0];

            undoToolStripMenuItem.Text = strBIText;

            if ( nDescReturned == 0 )
                undoToolStripMenuItem.Enabled = false;
            else
                undoToolStripMenuItem.Enabled = true;

            strBIText = "Redo";
            // clear strDecsriptions.
            nDescReturned = this.diagram1.Model.HistoryManager.GetRedoDescriptions( nDescWanted, out strDescriptions );
            if ( nDescReturned == nDescWanted )
                strBIText = strBIText + " " + strDescriptions[0];

            redoToolStripMenuItem.Text = strBIText;

            if ( nDescReturned != 0 )
                redoToolStripMenuItem.Enabled = true;
            else
                redoToolStripMenuItem.Enabled = false;
        }

        

        private void Form1_Load( object sender, EventArgs e ) {
            this.LoadSymbolPalette();
            this.LoadDiagram();
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

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.diagram1.Model.HistoryManager.Undo();
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.diagram1.Model.HistoryManager.Redo();
        }

        private void startAtomicActionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.diagram1.Model.HistoryManager.StartAtomicAction("Custom Action");
        }

        private void endAtomicActionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.diagram1.Model.HistoryManager.EndAtomicAction();
        }

       
#endregion

       
    }
    /// <summary>
    /// Represents a class that is used to find the licensing file for Syncfusion controls.
    /// </summary>
    public class DemoCommon
    {

        /// <summary>
        /// Finds the license key from the Common folder.
        /// </summary>
        /// <returns>Returns the license key.</returns>
        public static string FindLicenseKey()
        {
            string licenseKeyFile = "..\\Common\\SyncfusionLicense.txt";
            for (int n = 0; n < 20; n++)
            {
                if (!System.IO.File.Exists(licenseKeyFile))
                {
                    licenseKeyFile = @"..\" + licenseKeyFile;
                    continue;
                }
                return System.IO.File.ReadAllText(licenseKeyFile);
            }
            return string.Empty;
        }
    }
}

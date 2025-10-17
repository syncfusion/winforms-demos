#region Copyright Syncfusion Inc. 2001 - 2012
//
//  Copyright Syncfusion Inc. 2001 - 2012. All rights reserved.
//
//  Use of this code is subject to the terms of our license.
//  A copy of the current license can be obtained at any time by e-mailing
//  licensing@syncfusion.com. Any infringement will be prosecuted under
//  applicable laws. 
//
#endregion

using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Drawing.Imaging;
using System.Drawing.Drawing2D;
using System.IO;

using Syncfusion.Windows.Forms.Diagram;
using Syncfusion.Windows.Forms.Diagram.Controls;

using Syncfusion.SVG.IO;
using Syncfusion.Windows.Forms;
using System.Reflection;
using Syncfusion.Licensing;

namespace ExportImage
{
    public partial class MainForm : Form
    {

        public MainForm()
        {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();
            this.diagram1.Model = this.Model;
        }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            SyncfusionLicenseProvider.RegisterLicense(DemoCommon.FindLicenseKey());
            Application.Run(new MainForm());
        }

#region ClassMethods

        private void AddInfotoImage()
        {
            TextNode txtnode = new TextNode("Image created using Syncfusion Essential Diagram");

            txtnode.LineStyle.LineColor = Color.Transparent;
            txtnode.Name = "ImageInfo";
            txtnode.BackgroundStyle.Color = Color.Azure;
            txtnode.FontStyle.Family = "Arial";
            txtnode.SizeToText(new SizeF(0, 0));

            PointF location = new PointF((this.diagram1.Model.DocumentSize.Width / 2), (this.diagram1.Model.DocumentSize.Height - (2 * (txtnode.Size.Height))));
            txtnode.PinPoint = location;

            this.diagram1.Controller.Model.AppendChild(txtnode);
        }

        private void RemoveInfofromImage()
        {
            TextNode tnode = (TextNode)this.diagram1.Controller.Model.Nodes.FindNodeByName("ImageInfo");

            if (tnode != null)
            {
                this.diagram1.Controller.Model.RemoveChild(tnode);
            }
        }





        private void SaveImage(string filename, ImageFormat imageformat)
        {
            if (imageformat != ImageFormat.Emf)
            {
                Image img = this.diagram1.View.ExportDiagramAsImage(true);
                img.Save(filename, imageformat); 
            }
            else	
            {
                // Export diagram to a metafile
                this.SaveDiagramAsEmf(filename);
            }
        }

        // Create a Metafile with the provided file name and draw teh diagram to it.
        private void SaveDiagramAsEmf(string filename)
        {
            // Create a Metafile with the provided file name and draw the diagram to it.
            Image diagramimage = new Bitmap(1, 1, PixelFormat.Format24bppRgb);
            Graphics grfx = Graphics.FromImage(diagramimage);
            IntPtr hdc = grfx.GetHdc();
            Metafile emf = new Metafile(filename, hdc, EmfType.EmfOnly);
            Graphics emfgrfx = Graphics.FromImage(emf);

            this.diagram1.ExportDiagramToGraphics(emfgrfx);

            grfx.ReleaseHdc(hdc);
            grfx.Dispose();
            emfgrfx.Dispose();
            diagramimage.Dispose();
            emf.Dispose();
        }
#endregion

#region Main_Load
        private void MainForm_Load(object sender, EventArgs e)
        {
#if !NETCORE
            this.diagram1.LoadXml(@"..\..\..\..\..\..\common\Data\Diagram\xml\ExportImage_DataFlow.xml");
#else
            this.diagram1.LoadXml(@"..\..\..\..\..\..\..\common\Data\Diagram\xml\ExportImage_DataFlow.xml");
#endif
            this.paletteGroupView1.ShowToolTips = true;
            this.diagram1.View.SelectionList.Clear();
            // Make the diagram Readonly
            foreach (Node n in this.diagram1.Model.Nodes)
            {
                n.EditStyle.AllowSelect = false;
            }
            this.diagram1.AllowDrop = false;

        }
#endregion

#region Export
        // Exports the Diagram as Image file format.
#region ExportImageFormat
        private void ExportImage()
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = @"Windows Bitmap(*.bmp)|*.bmp|Exchangeable Image Format(*.exif)|*.exif|Graphics Interchange Format(*.gif)|*.gif|Windows Icon Image(*.ico)|*.ico|Joint Photographic Experts Group(*.jpeg)|*.jpeg|W3C Portable Network Graphics(*.png)|*.png|Tag Image File Format(*.tiff)|*.tiff";//|Enhanced Metafile Format(*.emf)|*.emf";
            saveFileDialog1.Title = "Export Diagram As:";
            saveFileDialog1.FileName = "Diagram";

            ImageFormat imgformat = ImageFormat.Bmp;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                switch (saveFileDialog1.FilterIndex)
                {
                    case 1:
                        imgformat = ImageFormat.Bmp;
                        break;
                    case 2:
                        imgformat = ImageFormat.Exif;
                        break;
                    case 3:
                        imgformat = ImageFormat.Gif;
                        break;
                    case 4:
                        imgformat = ImageFormat.Icon;
                        break;
                    case 5:
                        imgformat = ImageFormat.Jpeg;
                        break;
                    case 6:
                        imgformat = ImageFormat.Png;
                        break;
                    case 7:
                        imgformat = ImageFormat.Tiff;
                        break;
                }
                AddInfotoImage();
                SaveImage(saveFileDialog1.FileName, imgformat);
                RemoveInfofromImage();
            }
            else
            {
                return;
            }
        }
#endregion

        // Exports the Diagram as Emf file format
#region ExportEmf
        private void ExportEmf()
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = @"Enhanced Metafile Format(*.emf)|*.emf";
            saveFileDialog1.Title = "Export Diagram As:";
            saveFileDialog1.FileName = "Diagram";

            ImageFormat imgformat = ImageFormat.Emf;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                imgformat = ImageFormat.Emf;
                AddInfotoImage();
                SaveImage(saveFileDialog1.FileName, imgformat);
                RemoveInfofromImage();
            }
            else
            {
                return;
            }

        }
#endregion

        // Exports the Diagram as Svg file format
#region ExportSvg
        private void ExportSvg()
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = @"Scalable Vector Graphics Format(*.svg)|*.svg";
            saveFileDialog1.Title = "Export Diagram As:";
            saveFileDialog1.FileName = "Diagram";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {

                ToSvg tosvg = new ToSvg();
                // Get Diagram Nodes Bounding Rectangle.
                RectangleF rectBounding = this.diagram1.Model.GetBoundingRect();
                Graphics gfx = tosvg.GetRealGraphics(new Size((int)rectBounding.Width, (int)rectBounding.Height));
                AddInfotoImage();
                this.diagram1.ExportDiagramToGraphics(gfx);
                tosvg.Save(saveFileDialog1.FileName);
                RemoveInfofromImage();
            }
            else
            {
                return;
            }
        }


#endregion

#endregion

#region Event Handlers
        // Displays popup menu on right click the mouse on Diagram
#region PopupMenu

        private void diagram1_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Right)
            {
                this.contextMenu2.Show(sender as Diagram, new Point(e.X, e.Y));

            }

        }
#endregion

#region PalatteGroupBar color setting
        private void PaletteGroupBar1_ProvideGroupBarItemBrush(object sender, Syncfusion.Windows.Forms.Tools.ProvideGroupBarItemBrushEventArgs args)
        {

            Blend blend = new Blend();
            blend.Factors = new float[] { 0.0f, 0.0f, 1.0f };
            blend.Positions = new float[] { 0.0F, 0.5f, 1.0F };
            // Estimate the GroupBarItem bounds
            System.Drawing.Rectangle rcgroupbaritem = args.Bounds;
            // Create and initialize the LinearGradientBrush
            LinearGradientBrush lgbrush = new LinearGradientBrush(rcgroupbaritem, Color.WhiteSmoke, Color.FromArgb(218, 231, 249), 90, true);
            lgbrush.Blend = blend;
            args.BackgroundBrush = lgbrush;
            args.BackgroundBrush = lgbrush;

        }
#endregion

        private void exportAsImageToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ExportImage();
        }
        private void exportAsSVGToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ExportSvg();
        }

        private void exportAsEmfToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ExportEmf();
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

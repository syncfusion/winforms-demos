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
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Syncfusion.Windows.Forms.Tools;
using Syncfusion.Windows.Forms.Diagram.Controls;
using System.Drawing.Printing;
using Syncfusion.Windows.Forms.Diagram;
using System.IO;
using Syncfusion.Windows.Forms;

namespace Sequence_Diagram_2005
{
    /// <summary>
    /// Sample application form.
    /// </summary>
    public partial class MainForm : Form
    {
        #region Class Members
        string strFileName = string.Empty;
        #endregion

        #region Class Initialization
        /// <summary>
        /// Intializes the new instance of MainForm class
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            //load sequence diagram

#if !(NETCORE || NET50 || NET80 || NET60 || NET70 || NET90)
            strFileName = @"..\..\..\..\..\..\common\Data\Diagram\xml\Sequence Diagram.xml";
            diagram1.LoadXml(@"..\..\..\..\..\..\common\Data\Diagram\xml\Sequence Diagram.xml");  
            //load sequence diagram shapes into the palette
            paletteGroupBar1.LoadPalette(@"..\..\..\..\..\..\common\Data\Diagram\xml\Sequence Diagram Shapes.xml");
#else
            strFileName = @"..\..\..\..\..\..\..\common\Data\Diagram\xml\Sequence Diagram.xml";
            diagram1.LoadXml(@"..\..\..\..\..\..\..\common\Data\Diagram\xml\Sequence Diagram.xml");
            //load sequence diagram shapes into the palette
            paletteGroupBar1.LoadPalette(@"..\..\..\..\..\..\..\common\Data\Diagram\xml\Sequence Diagram Shapes.xml");
#endif
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
            foreach (GroupBarItem item in paletteGroupBar1.GroupBarItems)
            {
                this.paletteGroupBar1.BorderColor = System.Drawing.ColorTranslator.FromHtml("#119EDA");
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
                    view.BorderStyle = BorderStyle.None;                   
                }
            }
            Application.Idle += new EventHandler(Application_Idle);
            btnRuler.Checked = diagram1.ShowRulers;
            btnGrid.Checked = diagram1.View.Grid.Visible;
            btnSnapToGrid.Checked = diagram1.View.Grid.SnapToGrid;
        }
#endregion

#region Class Events
        private void Application_Idle(object sender, EventArgs e)
        {
            btnCut.Enabled = diagram1.Controller.CanCut;
            btnCopy.Enabled = diagram1.Controller.CanCopy;
            if(this.WindowState != FormWindowState.Minimized)
                btnPaste.Enabled = diagram1.Controller.CanPaste;            
            btnUndo.Enabled = diagram1.Model.HistoryManager.CanUndo;
            btnRedo.Enabled = diagram1.Model.HistoryManager.CanRedo;           
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            //creates a print document
            PrintDocument printDoc = diagram1.CreatePrintDocument();            
            PrintPreviewDialog printPreviewDlg = new PrintPreviewDialog();
            printDoc.PrinterSettings.FromPage = 0;
            printDoc.PrinterSettings.ToPage = 0;
            printDoc.PrinterSettings.PrintRange = PrintRange.AllPages;

            printPreviewDlg.Document = printDoc;
            printPreviewDlg.ShowDialog(this);
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            if (diagram1.Model.Modified)
            {
                if (MessageBox.Show("The Diagram has been modified. Save Changes?", "Save Changes", MessageBoxButtons.YesNoCancel) == DialogResult.Yes)
                {
                    btnSave_Click(sender, e);
                }
            }
            else
            {
                //Create a new diagram document
                diagram1.Model.Clear();
                Model model = new Model();
                model.RenderingStyle.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
                model.LineStyle.LineColor = Color.LightGray;
                diagram1.Model = model;
                strFileName = string.Empty;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            saveFileDialog.FilterIndex = 0;
            if (diagram1.Model.Modified)
            {
                if (strFileName == string.Empty)
                {
                    saveFileDialog.Filter = @"XML file(*.xml)|*.xml|EDD file(*.edd)|*.edd";
                    if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
                    {
                        if (saveFileDialog.FilterIndex == 1)
                        {
#if NETCORE || NET50 || NET80 || NET60 || NET70 || NET90 || SyncfusionFramework4_6_2 || SyncfusionFramework4_6 || SyncfusionFramework4_5_1 || SyncfusionFramework4_5

                            diagram1.SaveXml(saveFileDialog.FileName);
                            this.diagram1.Refresh();
#else
                        this.diagram1.SaveSoap(saveFileDialog.FileName);
#endif
                        }
                        else if (saveFileDialog.FilterIndex == 2)
                        {
                            diagram1.SaveBinary(saveFileDialog.FileName);
                        }

                        strFileName = saveFileDialog.FileName;
                    }
                }
                else
                {
                    //Serialize the diagram document as either binary or xml document
                    FileInfo fileInfo = new FileInfo(strFileName);
                    if (fileInfo.Extension == ".edd")
                        diagram1.SaveBinary(strFileName);

                    if (fileInfo.Extension == ".xml")
                    {
#if NETCORE || NET50 || NET80 || NET60 || NET70 || NET90 || SyncfusionFramework4_6_2 || SyncfusionFramework4_6 || SyncfusionFramework4_5_1 || SyncfusionFramework4_5

                        diagram1.SaveXml(strFileName);
                        this.diagram1.Refresh();
#else
                         diagram1.SaveSoap(strFileName);
#endif

                    }

                }
            }
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            if (diagram1.Model.Modified)
            {
                if (MessageBox.Show("The Diagram has been modified. Save Changes?", "Save Changes", MessageBoxButtons.YesNoCancel) == DialogResult.Yes)
                {
                    btnSave_Click(sender, e);
                }
            }
            //else
            {
                //Open a serialized binary/xml diagram document
                if (openFileDialog.ShowDialog(this) == DialogResult.OK)
                {
                    FileInfo fileInfo = new FileInfo(openFileDialog.FileName);
                    strFileName = openFileDialog.FileName;
                    if (fileInfo.Extension == ".edd")
                        diagram1.LoadBinary(strFileName);

                    if (fileInfo.Extension == ".xml")
                    {
#if NETCORE || NET50 || NET80 || NET60 || NET70 || NET90 || SyncfusionFramework4_6_2 || SyncfusionFramework4_6 || SyncfusionFramework4_5_1 || SyncfusionFramework4_5

                        diagram1.LoadXml(strFileName);
                        this.diagram1.Refresh();
#else
                        diagram1.LoadSoap(strFileName);
#endif
                    }

                }
            }
            strFileName = openFileDialog.FileName;
        }

        private void btnSaveAs_Click(object sender, EventArgs e)
        {
            //Save as the diagram with given file format
            saveAsFileDialog.FileName = "Diagram";
            saveAsFileDialog.Filter = @"XML file(*.xml)|*.xml|EDD file(*.edd)|*.edd";
            if (saveAsFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                if (saveAsFileDialog.FilterIndex == 1)
                {
#if NETCORE || NET50 || NET80 || NET60 || NET70 || NET90 || SyncfusionFramework4_6_2 || SyncfusionFramework4_6 || SyncfusionFramework4_5_1 || SyncfusionFramework4_5

                    diagram1.SaveXml(saveAsFileDialog.FileName);
                    this.diagram1.Refresh();
#else
                        this.diagram1.SaveSoap(saveAsFileDialog.FileName);
#endif
                }
                else if (saveAsFileDialog.FilterIndex == 2)
                {
                    diagram1.SaveBinary(saveAsFileDialog.FileName);
                }

                strFileName = saveAsFileDialog.FileName;
            }
        }

        private void exportPng_Click(object sender, EventArgs e)
        {
            //Export diagram as png
            exportFileDialog.Filter = "PNG | *.png";
            exportFileDialog.FileName = "Diagram";
            if (exportFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                diagram1.ExportDiagramAsImage(true).Save(exportFileDialog.FileName, System.Drawing.Imaging.ImageFormat.Png);
            }
        }

        private void exportJpg_Click(object sender, EventArgs e)
        {
            //Export diagram as jpg
            exportFileDialog.Filter = "JPG | *.jpg";
            exportFileDialog.FileName = "Diagram";
            if (exportFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                diagram1.ExportDiagramAsImage(true).Save(exportFileDialog.FileName, System.Drawing.Imaging.ImageFormat.Jpeg);
            }
        }

        private void exportPdf_Click(object sender, EventArgs e)
        {
            //Export diagram as gif
            exportFileDialog.Filter = "GIF | *.gif";
            exportFileDialog.FileName = "Diagram";
            if (exportFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                diagram1.ExportDiagramAsImage(true).Save(exportFileDialog.FileName, System.Drawing.Imaging.ImageFormat.Gif);
            }
        }

        private void btnUndo_Click(object sender, EventArgs e)
        {
            //Undo
            this.diagram1.Model.HistoryManager.Undo();
        }

        private void btnRedo_Click(object sender, EventArgs e)
        {
            //Redo
            this.diagram1.Model.HistoryManager.Redo();
        }

        private void btnCut_Click(object sender, EventArgs e)
        {
            //Cut
            this.diagram1.Controller.Cut();
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            //Copy
            this.diagram1.Controller.Copy();
        }

        private void btnPaste_Click(object sender, EventArgs e)
        {
            //Paste
            this.diagram1.Controller.Paste();
        }

        private void btnRuler_Click(object sender, EventArgs e)
        {
            //Enable ruler
            this.diagram1.ShowRulers = btnRuler.Checked;
        }

        private void btnSnapToGrid_Click(object sender, EventArgs e)
        {
            //Enable snap to grid
            diagram1.View.Grid.SnapToGrid = btnSnapToGrid.Checked;
        }

        private void btnGrid_Click(object sender, EventArgs e)
        {
            //Enable grid
            diagram1.View.Grid.Visible = btnGrid.Checked;
        }

        private void btnSize_Click(object sender, EventArgs e)
        {
            //Open a page size dialog for change the model document size
            using (PageSizeDialog dlgPageSize = new PageSizeDialog())
            {
                dlgPageSize.PageSize = (PageSize)this.diagram1.Model.DocumentSize.Clone();
                dlgPageSize.PrinterSettings = (System.Drawing.Printing.PageSettings)this.diagram1.View.PageSettings.Clone();
                if (dlgPageSize.ShowDialog(this.diagram1) == DialogResult.OK)
                {
                    this.diagram1.Model.DocumentSize = dlgPageSize.PageSize;
                    this.diagram1.View.PageSettings.Landscape = dlgPageSize.PrinterSettings.Landscape;
                }
            }
        }

        private void btnAutoSize_Click(object sender, EventArgs e)
        {
            //Fit the document to the diagram content
            this.diagram1.Model.SizeToContent = true;
        }

        private void btnPageSettings_Click(object sender, EventArgs e)
        {
            //Open a page setup dialog for diagram page setup
            using (Syncfusion.Windows.Forms.Diagram.PageSetupDialog dlgPageSetup = new Syncfusion.Windows.Forms.Diagram.PageSetupDialog(diagram1.View))
            {
                if (dlgPageSetup.ShowDialog() == DialogResult.OK)
                {
                    diagram1.UpdateView();
                }
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            //print the diagram document
            DiagramPrintDocument printDoc = diagram1.CreatePrintDocument();
            printDialog.Document = printDoc;
            printDialog.UseEXDialog = true;
            printDialog.AllowSomePages = true;
            if (printDialog.ShowDialog(this) == DialogResult.OK)
            {
                printDoc.PrinterSettings = printDialog.PrinterSettings;
                printDoc.Print();
            }
        }
#endregion
    }
}
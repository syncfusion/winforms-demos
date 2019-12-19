#region Copyright Syncfusion Inc. 2001 - 2019
//
//  Copyright Syncfusion Inc. 2001 - 2019. All rights reserved.
//
//  Use of this code is subject to the terms of our license.
//  A copy of the current license can be obtained at any time by e-mailing
//  licensing@syncfusion.com. Any infringement will be prosecuted under
//  applicable laws. 
//
#endregion

#region Usings
using System;
using System.Drawing;
using System.Drawing.Design;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.ComponentModel;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;
using System.Resources;
using System.Drawing.Printing;
using System.Text.RegularExpressions;
using System.IO;
using System.Runtime.Serialization.Formatters.Soap;
using Syncfusion.Windows.Forms.Diagram;
using Syncfusion.SVG.IO;
using Syncfusion.Windows.Forms.Diagram.Controls;
using Syncfusion.Windows.Forms.Tools;
using Syncfusion.Runtime.Serialization;
using Syncfusion.Windows.Forms.Tools.XPMenus;
using System.Collections.Generic;
using System.Diagnostics;
using Syncfusion.Licensing;

#endregion

namespace Syncfusion.Windows.Forms.Diagram.Samples.DiagramTool
{
    /// <summary>
    /// MainForm for the Essential Diagram Builder.
    /// </summary>
    public partial class MainForm : Office2007Form
    {
        string _initialFileLoc = "";
        public MainForm(string fileLocation)
            : this()
        {
            _initialFileLoc = fileLocation;
        }

        ParentBarItem contextMenuItem = new ParentBarItem();
        BarItem copyPathItem = new BarItem();

        Form currentForm = null;
        public MainForm()
        {
            InitializeComponent();
            this.dockingManager.Office2007Theme = Syncfusion.Windows.Forms.Office2007Theme.Managed;
            symbolPaletteGroupBar.VisualStyle = VisualStyle.Office2003;           
                                  
            tabbedMDIManager = new Tools.TabbedMDIManager();
            tabbedMDIManager.AttachToMdiContainer(this);
            copyPathItem.Text = "Copy Full Path";
            contextMenuItem.Items.Add(copyPathItem);
            tabbedMDIManager.ContextMenuItem = contextMenuItem;

            tabbedMDIManager.TabControlAdded += new Syncfusion.Windows.Forms.Tools.TabbedMDITabControlEventHandler(tabbedMDIManager_TabControlAdded);
            copyPathItem.Click += new EventHandler(copyPathItem_Click);
            tabbedMDIManager.ContextMenuItem.BeforePopup += new CancelEventHandler(ContextMenuItem_BeforePopup);
            // Create resource manager for strings
            this.resStringMgr = new ResourceManager("Syncfusion.Windows.Forms.Diagram.Samples.DiagramTool.Strings", typeof(MainForm).Assembly);
            this.dockingManager.DockContextMenu += new DockContextMenuEventHandler(dockingManager_DockContextMenu);
            this.Closing += new CancelEventHandler(MainForm_Closing);

            // Wire up OnIdle processing
            Application.Idle += new EventHandler(this.OnIdle);

            #region PropertyEditor Color Settings
            this.propertyEditor.PropertyGrid.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(227)), ((System.Byte)(239)), ((System.Byte)(255)));
            this.propertyEditor.PropertyGrid.CommandsBackColor = System.Drawing.Color.FromArgb(((System.Byte)(227)), ((System.Byte)(239)), ((System.Byte)(255)));
            this.propertyEditor.PropertyGrid.CommandsForeColor = System.Drawing.Color.MidnightBlue;
            this.propertyEditor.PropertyGrid.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
            this.propertyEditor.PropertyGrid.HelpBackColor = System.Drawing.Color.FromArgb(((System.Byte)(227)), ((System.Byte)(239)), ((System.Byte)(255)));
            this.propertyEditor.PropertyGrid.HelpForeColor = System.Drawing.Color.MidnightBlue;
            this.propertyEditor.PropertyGrid.LineColor = System.Drawing.Color.FromArgb(((System.Byte)(185)), ((System.Byte)(216)), ((System.Byte)(255)));
            this.propertyEditor.PropertyGrid.ViewBackColor = System.Drawing.Color.FromArgb(((System.Byte)(227)), ((System.Byte)(239)), ((System.Byte)(255)));
            this.propertyEditor.PropertyGrid.ViewForeColor = System.Drawing.Color.MidnightBlue;
            #endregion
        }

        Control ctrl;
        void dockingManager_DockContextMenu(object sender, DockContextMenuEventArgs arg)
        {
            ctrl = arg.Owner;
            arg.ContextMenu.BeforePopup += new CancelMouseEventHandler(ContextMenu_BeforePopup);
        }

        void ContextMenu_BeforePopup(object sender, CancelMouseEventArgs e)
        {
            if (ctrl.Name == "symbolPaletteGroupBar")
                e.Cancel = true;
        }

        void ContextMenuItem_BeforePopup(object sender, CancelEventArgs e)
        {
            ParentBarItem pItem = sender as ParentBarItem;
            foreach (BarItem item in pItem.Items)
            {
                if (item.Text == "New Hori&zontal Tab Group" || item.Text == "New &Vertical Tab Group")
                {
                    pItem.Items.Remove(item);
                    break;
                }
            }
        }

        void copyPathItem_Click(object sender, EventArgs e)
        {
            if (currentForm != null)
            {
                DiagramForm diagForm = currentForm as DiagramForm;
                if (diagForm != null)
                {
                    if (diagForm.FileName != null)
                        Clipboard.SetText(diagForm.FileName);
                }
            }
        }

        internal string FindFile(string fileName)
        {
            // Check both in parent folder and Parent\Data folders.
            string dataFileName = @"Data\" + fileName;
            for (int n = 0; n < 12; n++)
            {
                if (System.IO.File.Exists(fileName))
                {
                    return fileName;
                }
                if (System.IO.File.Exists(dataFileName))
                {
                    return dataFileName;
                }
                fileName = @"..\" + fileName;
                dataFileName = @"..\" + dataFileName;
            }

            return fileName;
        }

        #region MainForm Event Handlers

        Dictionary<string, SymbolPaletteInfo> paletteFileLocs;
        private void MainForm_Load(object sender, EventArgs e)
        {
            paletteFileLocs = new Dictionary<string, SymbolPaletteInfo>();
            this.barItemViewProperties.Checked = true;
            this.barItemViewSymbolPalette.Checked = true;

            //Loads default symbol palette
            LoadDefaults();

            // New diagram
            DiagramForm docForm = new DiagramForm(this);
            docForm.Closing += new CancelEventHandler(DiagramForm_Closing);

            // Subscribe for DocumentExplorer selection change
            m_documentExplorer.AfterSelect += new TreeViewEventHandler(m_documentExplorer_AfterSelect);

            // Load Diagram file.
            if (_initialFileLoc == "")
            {
                //docForm.Diagram.LoadBinary( FindFile( "Enhanced Line Routing.edd" ) );
                string path = FindFile("Enhanced Line Routing.edd");
                docForm.OpenFile(path);
                docForm.FileName = Path.GetFullPath(path);
            }
            else
            {
                docForm.Diagram.LoadBinary(_initialFileLoc);
                string fileName = _initialFileLoc;
               // string fileName = _initialFileLoc.Substring(0, _initialFileLoc.IndexOf("."));
                docForm.FileName = fileName;
            }
            // Attach created diagram to DocumentExplorer
            if (docForm.Diagram.Model != null)
                m_documentExplorer.AttachModel(docForm.Diagram.Model);

            tabbedMDIManager.SetTooltip(docForm, docForm.FileName);
            currentForm = docForm;

            docForm.Show();

            
            symbolPaletteGroupBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World);
            symbolPaletteGroupBar.ForeColor = Color.LightSkyBlue;
            foreach (GroupBarItem item in symbolPaletteGroupBar.GroupBarItems)
            {
                if (item.Client is PaletteGroupView)
                {
                    PaletteGroupView view = item.Client as PaletteGroupView;
                    view.FlowView = true;
                    view.ShowToolTips = true;
                    view.ShowFlowViewItemText = true;
                    view.ForeColor = Color.Black;
                    view.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
                    view.SelectedItemColor = Color.FromArgb(255, 219, 118);
                    view.HighlightItemColor = Color.FromArgb(255, 227, 149);
                    view.SelectingItemColor = Color.FromArgb(255, 238, 184);
                    view.SelectedHighlightItemColor = Color.FromArgb(255, 218, 115);
                    view.FlowViewItemTextLength = 60;
                    Color backColor = ColorTranslator.FromHtml("#EEF5FF");
                    view.BackColor = backColor;
                    view.FlatLook = true;
                }
            }

            // Load the save bar state
            if (File.Exists(@"..\..\persist.xml"))
            {
                AppStateSerializer serializer = new AppStateSerializer(SerializeMode.XMLFile, @"..\..\persist");
                this.mainFrameBarManager.LoadBarState(serializer);
            }

            this.symbolPaletteGroupBar.GroupBarItemAdded += new GroupBarItemEventHandler(symbolPaletteGroupBar_GroupBarItemAdded);           
        }
       



        void symbolPaletteGroupBar_GroupBarItemAdded(object sender, GroupBarItemEventArgs args)
        {
            PaletteGroupView view = symbolPaletteGroupBar.GroupBarItems[symbolPaletteGroupBar.GroupBarItems.Count - 1].Client as PaletteGroupView;
            view.FlowView = true;
            view.ShowToolTips = true;
            view.ShowFlowViewItemText = true;
            view.FlatLook = true;
            view.ForeColor = Color.Black;
            view.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            view.SelectedItemColor = Color.FromArgb(255, 219, 118);
            view.HighlightItemColor = Color.FromArgb(255, 227, 149);
            view.SelectingItemColor = Color.FromArgb(255, 238, 184);
            view.SelectedHighlightItemColor = Color.FromArgb(255, 218, 115);
            view.FlowViewItemTextLength = 60;
            Color backColor = ColorTranslator.FromHtml("#EEF5FF");
            view.BackColor = backColor;
        }

        private void LoadDefaults()
        {
            //Load Palettes
            string[] symbolPalettes = new string[] { 
                "Basic  Shapes.edp",
                "Flowchart Symbols.edp", "FloorPlan Shapes.edp","NetworkSymbols.edp"
            };
            foreach (string symbolpalette in symbolPalettes)
            {
                string filepath = FindFile(symbolpalette);
                if (File.Exists(filepath))
                {
                    //AddPalette(filepath);
                    this.symbolPaletteGroupBar.LoadPalette(filepath);
                }
            }            
        }


        private void MainForm_MdiChildActivate(object sender, EventArgs e)
        {
            DiagramForm diagramForm = this.ActiveMdiChild as DiagramForm;
            if (diagramForm != null)
            {
                this.dockingManager.SetDockVisibility(this.pnlAssSymbols, true);

                if (this.dockingManager.GetDockVisibility(propertyEditor))
                {
                    this.propertyEditor.Diagram = diagramForm.Diagram;
                }

                // Subscribe for DocumentSink events
                if (diagramForm.Diagram.Model != null)
                {
                    Model document = diagramForm.Diagram.Model;
                }

                // If the OverviewControl is visible then change the OverviewControl.Model and OverviewControl.View 
                // properties to reference the new diagram's Model and View
                if (this.dockingManager.GetDockVisibility(overviewControl1))
                {
                    this.overviewControl1.Diagram = diagramForm.Diagram;
                }

                this.chkListAssSymbols.Items.Clear();

                foreach (AssociatedSymbolPaletteInfo aInfo in diagramForm.AssociatedSymbolPalettes)
                {
                    foreach (SymbolPaletteInfo sInfo in aInfo.SymbolPaletteInfo)
                    {
                        bool present = false;
                        foreach (GroupBarItem gbi in symbolPaletteGroupBar.GroupBarItems)
                        {
                            if (gbi.Text.Equals(sInfo.SymbolPaletteName))
                                present = true;
                        }
                        if (!present)
                        {
                            if (File.Exists(sInfo.FileLocation))
                                AddPalette(sInfo.FileLocation);
                            else
                            {
                                string assSymbolsPath = diagramForm.FileName.Substring(0, diagramForm.FileName.LastIndexOf("\\")) + "\\" + Path.GetFileName(sInfo.FileLocation);
                                if (File.Exists(assSymbolsPath))
                                {
                                    AddPalette(assSymbolsPath);
                                    sInfo.FileLocation = assSymbolsPath;
                                }
                                else
                                {
                                    SelectSymbolPalette dlg = new SelectSymbolPalette(sInfo.SymbolPaletteName);
                                    if (dlg.ShowDialog() == DialogResult.OK)
                                    {
                                        AddPalette(dlg.PaletteFileName);
                                        sInfo.FileLocation = dlg.PaletteFileName;
                                    }
                                    else
                                    {
                                        this.chkListAssSymbols.Items.Add(sInfo.SymbolPaletteName + "(Could not be found)", CheckState.Unchecked); continue;
                                    }
                                }
                            }
                        }
                        this.chkListAssSymbols.Items.Add(Path.GetFileName(sInfo.FileLocation), CheckState.Unchecked);
                    }

                }
            }
        }
        #endregion

        #region Properties

        private Controls.Diagram ActiveDiagram
        {
            get
            {
                Controls.Diagram diagram = null;

                if (this.ActiveMdiChild != null)
                {
                    DiagramForm diagramForm = this.ActiveMdiChild as DiagramForm;
                    if (diagramForm != null)
                    {
                        diagram = diagramForm.Diagram;
                    }
                }

                return diagram;
            }
        }

        private DiagramForm ActiveDiagramForm
        {
            get
            {
                DiagramForm diagramForm = null;

                if (this.ActiveMdiChild != null)
                {
                    diagramForm = this.ActiveMdiChild as DiagramForm;
                }

                return diagramForm;
            }
        }

        public PropertyEditor PropertyEditor
        {
            get
            {
                return this.propertyEditor;
            }
        }

        #endregion

        #region File Menu Event Handlers
        private void biSavePalette_Click(object sender, EventArgs e)
        {
            // Open symbol palette and add it to the symbol palette group bar
            if (savePaletteDialog.ShowDialog(this) == DialogResult.OK)
            {
                SymbolPalette symbolPalette = symbolPaletteGroupBar.CurrentSymbolPalette;
                string strSavePath = savePaletteDialog.FileName;

                if (symbolPalette != null)
                {
                    FileStream fStream = new FileStream(strSavePath, FileMode.OpenOrCreate, FileAccess.Write);
                    BinaryFormatter formatter = new BinaryFormatter();

                    formatter.Serialize(fStream, symbolPalette);
                    fStream.Close();
                }
            }
        }
        private void biFileAddPalette_Click(object sender, EventArgs e)
        {
            // Open symbol palette and add it to the symbol palette group bar
            if (openPaletteDialog.ShowDialog(this) == DialogResult.OK)
            {
                string strFileName = openPaletteDialog.FileName;
                AddPalette(strFileName);
            }
        }

        public void AddPalette(string strFileName)
        {
            SymbolPalette curSymbolPalette;
            FileStream iStream;
            RegexOptions options = RegexOptions.IgnoreCase | RegexOptions.RightToLeft;
            Match match = Regex.Match(strFileName, ".vss|.vsx|.vsd|.vdx", options);

            if (match.Success)
            {
                VisioStencilConverter converter = new VisioStencilConverter(strFileName, this);
                converter.ShowProgressDialog = true;
                curSymbolPalette = converter.Convert();
                if (curSymbolPalette != null)
                    AddPalette(strFileName, curSymbolPalette);
            }
            else
            {
                try
                {
                    iStream = new FileStream(strFileName, FileMode.Open, FileAccess.Read);
                }
                catch (Exception ex)
                {
                    iStream = null;
                    MessageBoxAdv.Show(this, ex.Message);
                }

                if (iStream != null)
                {
                    IFormatter formatter = new BinaryFormatter();
                    formatter.Binder = Syncfusion.Runtime.Serialization.AppStateSerializer.CustomBinder;

                    try
                    {
                        AppDomain.CurrentDomain.AssemblyResolve +=
                            new ResolveEventHandler(DiagramBaseAssembly.AssemblyResolver);
                        curSymbolPalette = (SymbolPalette)formatter.Deserialize(iStream);

                        if (curSymbolPalette.Name.Equals("BasicShapes"))
                            curSymbolPalette.Name = "Basic Shapes";

                        AddPalette(strFileName, curSymbolPalette);
                    }
                    catch (SerializationException)
                    {
                        try
                        {
                            formatter = new SoapFormatter();
                            iStream.Position = 0;
                            curSymbolPalette = (SymbolPalette)formatter.Deserialize(iStream);
                            AddPalette(strFileName, curSymbolPalette);
                        }
                        catch (Exception se)
                        {
                            MessageBoxAdv.Show(this, se.Message);
                        }
                    }
                    finally
                    {
                        iStream.Close();
                    }
                }
            }
        }

        #region DragNDrop Associate SymbolPalette support
        private void AddPalette(string fileLoc, SymbolPalette palette)
        {
            palette.Name = Path.GetFileNameWithoutExtension(fileLoc);
            if (!paletteFileLocs.ContainsKey(palette.Name))
            {
                this.symbolPaletteGroupBar.AddPalette(palette);
                paletteFileLocs.Add(palette.Name, new SymbolPaletteInfo(palette.Name, new FileInfo(fileLoc).FullName));

                PaletteGroupView pgView = (PaletteGroupView)this.symbolPaletteGroupBar.Controls[this.symbolPaletteGroupBar.Controls.Count - 1];
                if (pgView != null)
                {
                    //DragNDrop operations
                    bool flag = false;
                    pgView.MouseDown += delegate(object sender, MouseEventArgs mArgs)
                    {
                        Syncfusion.Windows.Forms.Diagram.Controls.PaletteGroupView.GroupViewPaletteItem item = (Syncfusion.Windows.Forms.Diagram.Controls.PaletteGroupView.GroupViewPaletteItem)pgView.GetItemAt(new Point(mArgs.X, mArgs.Y));
                        if (item != null && item.Tag != null)
                            flag = true;
                    };

                    pgView.MouseLeave += delegate(object msender, EventArgs e1)
                    {
                        flag = false;
                    };

                    pgView.MouseMove += delegate(object msender1, MouseEventArgs margs1)
                    {
                        if (flag)
                            DoDragDrop(paletteFileLocs[pgView.Palette.Name], DragDropEffects.All);
                    };
                }
            }
        }


        #endregion

        private void biFileNew_Click(object sender, EventArgs e)
        {
            // New diagram
            DiagramForm docForm = new DiagramForm(this);
            docForm.Closing += new CancelEventHandler(DiagramForm_Closing);
            // Attach just created diagram
            m_documentExplorer.AttachModel(docForm.Diagram.Model);
            tabbedMDIManager.SetTooltip(docForm, docForm.FileName);
            docForm.Show();          

        }

        private void biFileOpen_Click(object sender, EventArgs e)
        {
            // Open diagram
            if (this.openDiagramDialog.ShowDialog(this) == DialogResult.OK)
            {
                DiagramForm docForm = new DiagramForm(this);
                docForm.OpenFile(this.openDiagramDialog.FileName);

                if (docForm.Diagram.Model != null)
                {
                    m_documentExplorer.AttachModel(docForm.Diagram.Model);
                }

                docForm.Closing += new CancelEventHandler(DiagramForm_Closing);
                tabbedMDIManager.SetTooltip(docForm, docForm.FileName);
                docForm.Show();
            }
        }

        private void biFileSave_Click(object sender, EventArgs e)
        {
            // Save diagram
            DiagramForm docForm = this.ActiveDiagramForm;
            if (docForm != null)
            {
                if (!docForm.HasFileName)
                {
                    if (this.saveDiagramDialog.ShowDialog(this) == DialogResult.OK)
                    {
                        docForm.SaveAsFile(this.saveDiagramDialog.FileName);
                    }
                }
                else
                {
                    docForm.SaveFile();
                }
            }
        }

        private void biFileSaveAs_Click(object sender, EventArgs e)
        {
            // Save diagram
            DiagramForm docForm = this.ActiveDiagramForm;
            if (docForm != null)
            {
                if (docForm.HasFileName)
                {
                    this.saveDiagramDialog.FileName = docForm.FileName;
                }
                if (this.saveDiagramDialog.ShowDialog(this) == DialogResult.OK)
                {
                    string strFileName = this.saveDiagramDialog.FileName;
                    // search for file extension
                    RegexOptions options = RegexOptions.IgnoreCase;
                    Match match = Regex.Match(strFileName, "([^.]*)$", options);
                    if (match.Success)
                    {
                        Image imgDiagram;

                        switch (match.Value.ToLower())
                        {
                            case "svg":
                                ToSvg tosvg = new ToSvg();
                                // Get Diagram Nodes Bounding Rectangle.
                                RectangleF rectBounding = this.ActiveDiagramForm.Diagram.Model.GetBoundingRect();
                                Graphics gfx = tosvg.GetRealGraphics(new Size((int)rectBounding.Width, (int)rectBounding.Height));
                                this.ActiveDiagram.ExportDiagramToGraphics(gfx);
                                tosvg.Save(strFileName);

                                break;
                            case "emf":
                                //Save Diagram to created image.
                                imgDiagram = this.ActiveDiagram.ExportDiagramAsImage(false);

                                // Save image as metafile.
                                imgDiagram.Save(strFileName, ImageFormat.Emf);
                                break;
                            case "png":
                                //Save Diagram to created image.
                                imgDiagram = this.ActiveDiagram.ExportDiagramAsImage(false);

                                // Save image as metafile.
                                imgDiagram.Save(strFileName, ImageFormat.Png);
                                break;
                            case "jpg":
                            case "jpeg":
                                //Save Diagram to created image.
                                imgDiagram = this.ActiveDiagram.ExportDiagramAsImage(false);

                                // Save image as metafile.
                                imgDiagram.Save(strFileName, ImageFormat.Jpeg);
                                break;
                            case "tiff":
                                //Save Diagram to created image.
                                imgDiagram = this.ActiveDiagram.ExportDiagramAsImage(false);

                                // Save image as metafile.
                                imgDiagram.Save(strFileName, ImageFormat.Tiff);
                                break;
                            case "gif":
                                //Save Diagram to created image.
                                imgDiagram = this.ActiveDiagram.ExportDiagramAsImage(false);

                                // Save image as metafile.
                                imgDiagram.Save(strFileName, ImageFormat.Gif);
                                break;
                            case "bmp":
                                //Save Diagram to created image.
                                imgDiagram = this.ActiveDiagram.ExportDiagramAsImage(false);

                                // Save image as metafile.
                                imgDiagram.Save(strFileName, ImageFormat.Bmp);
                                break;

                            default:
                                docForm.SaveAsFile(this.saveDiagramDialog.FileName);
                                break;
                        }
                    }
                }
            }
        }

        private void biPrintPreview_Click(object sender, EventArgs e)
        {
            this.PrintPreview();
        }

        private void biFilePrint_Click(object sender, EventArgs e)
        {
            this.Print();
        }
        private void biPageSetup_Click(object sender, EventArgs e)
        {
            this.PageSetup();
        }
        private void biFileExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void barItemHeaderFooter_Click(object sender, EventArgs e)
        {
            HeaderFooterSetup();
        }
        private void barItemPageBorders_Click(object sender, EventArgs e)
        {
            PageBordersSetup();
        }
        #endregion

        #region Edit Menu Event Handlers

        private void barItemEditCut_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null)
            {
                DiagramForm diagramForm = this.ActiveMdiChild as DiagramForm;
                if (diagramForm != null)
                {
                    diagramForm.Diagram.Controller.Cut();
                }
            }
        }
        private void barItemEditCopy_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null)
            {
                DiagramForm diagramForm = this.ActiveMdiChild as DiagramForm;
                if (diagramForm != null)
                {
                    diagramForm.Diagram.Controller.Copy();
                }
            }
        }
        private void barItemEditPaste_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null)
            {
                DiagramForm diagramForm = this.ActiveMdiChild as DiagramForm;
                if (diagramForm != null)
                {
                    diagramForm.Diagram.Controller.Paste();
                }
            }
        }
        private void barItemEditUndo_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null)
            {
                DiagramForm diagramForm = this.ActiveMdiChild as DiagramForm;
                if (diagramForm != null)
                {
                    diagramForm.Diagram.Model.HistoryManager.Undo();
                    propertyEditor.PropertyGrid.Refresh();
                }
            }
        }
        private void barItemEditRedo_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null)
            {
                DiagramForm diagramForm = this.ActiveMdiChild as DiagramForm;
                if (diagramForm != null)
                {
                    diagramForm.Diagram.Model.HistoryManager.Redo();
                    propertyEditor.PropertyGrid.Refresh();
                }
            }
        }
        private void barItemEditSelectAll_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null)
            {
                DiagramForm diagramForm = this.ActiveMdiChild as DiagramForm;
                if (diagramForm != null)
                {
                    diagramForm.Diagram.Controller.SelectAll();
                }
            }
        }
        #endregion

        #region View Menu Event Handlers
        public void barShowRulers_Click(object sender, EventArgs e)
        {
            if (ActiveDiagram != null)
            {
                barShowRulers.Checked = !barShowRulers.Checked;
                this.ActiveDiagram.ShowRulers = barShowRulers.Checked;
            }
        }
        private void barItemViewSymbolPalette_Click(object sender, EventArgs e)
        {
            if (this.barItemViewSymbolPalette.Checked)
            {
                this.dockingManager.SetDockVisibility(this.symbolPaletteGroupBar, false);
                this.barItemViewSymbolPalette.Checked = false;
            }
            else
            {
                this.dockingManager.SetDockVisibility(this.symbolPaletteGroupBar, true);
                this.barItemViewSymbolPalette.Checked = true;
            }
        }


        private void barItemViewAssSymbols_Click(object sender, EventArgs e)
        {
            if (this.barItemViewAssSymbols.Checked)
            {
                this.dockingManager.SetDockVisibility(this.pnlAssSymbols, false);
                this.barItemViewAssSymbols.Checked = false;
            }
            else
            {
                this.dockingManager.SetDockVisibility(this.pnlAssSymbols, true);
                this.barItemViewAssSymbols.Checked = true;
            }
        }

        private void barItemViewProperties_Click(object sender, EventArgs e)
        {
            if (this.barItemViewProperties.Checked)
            {
                this.dockingManager.SetDockVisibility(this.propertyEditor, false);
            }
            else
            {
                this.dockingManager.SetDockVisibility(this.propertyEditor, true);
            }
        }

        private void barItemPanZoom_Click(object sender, EventArgs e)
        {
            if (barItemPanZoom.Checked)
            {
                dockingManager.SetDockVisibility(overviewControl1, false);
            }
            else
            {
                if (this.ActiveDiagram != null)
                {
                    dockingManager.SetDockVisibility(overviewControl1, true);
                }
            }
        }
        private void barItemDocumentExplorer_Click(object sender, EventArgs e)
        {
            if (barItemDocumentExplorer.Checked)
            {
                // Hide the document explorer control
                dockingManager.SetDockVisibility(m_documentExplorer, false);
                barItemDocumentExplorer.Checked = false;
            }
            else
            {
                // Initialize the OverviewControl with the active diagram's Model & View and display the control
                if ((this.ActiveDiagram != null) && (!this.dockingManager.GetDockVisibility(m_documentExplorer)))
                {
                    dockingManager.SetDockVisibility(m_documentExplorer, true);
                    dockingManager.SetControlSize(m_documentExplorer, new Size(201, 492));
                }

                barItemDocumentExplorer.Checked = true;
            }
        }
        private void HeaderFooterSetup()
        {
            Controls.Diagram activeDiagram = this.ActiveDiagram;
            if (activeDiagram != null && activeDiagram.Model != null)
            {
                HeaderFooterDialog dlgHF = new HeaderFooterDialog();
                dlgHF.Header = activeDiagram.Model.HeaderFooterData.Header;
                dlgHF.Footer = activeDiagram.Model.HeaderFooterData.Footer;
                dlgHF.MeasurementUnits = activeDiagram.Model.MeasurementUnits;
                if (dlgHF.ShowDialog() == DialogResult.OK)
                {
                    activeDiagram.Model.HeaderFooterData.Header = dlgHF.Header;
                    activeDiagram.Model.HeaderFooterData.Footer = dlgHF.Footer;
                }
            }
        }

        private void PageBordersSetup()
        {
            Controls.Diagram activeDiagram = this.ActiveDiagram;
            if (activeDiagram != null && activeDiagram.Model != null)
            {
                PageBorderDialog borderDialog = new PageBorderDialog();
                borderDialog.PageBorderStyle = activeDiagram.View.PageBorderStyle;
                if (borderDialog.ShowDialog() == DialogResult.OK)
                {
                    activeDiagram.View.PageBorderStyle = borderDialog.PageBorderStyle;
                    activeDiagram.View.RefreshPageSettings();
                    activeDiagram.UpdateView();
                }
            }
        }


        #endregion

        #region Window Menu Event Handlers

        private void biTabbedMDI_Click(object sender, EventArgs e)
        {
            // Toggle tabbed MDI mode
            Tools.XPMenus.BarItem barItem = sender as Tools.XPMenus.BarItem;
            if (barItem != null)
            {
                if (barItem.Checked)
                {
                    tabbedMDIManager.DetachFromMdiContainer(this, true);
                    barItem.Checked = false;
                }
                else
                {
                    tabbedMDIManager.AttachToMdiContainer(this);
                    barItem.Checked = true;
                }
            }
        }

        #endregion

        #region Help Menu Event Handlers

        private void barItemAbout_Click(object sender, EventArgs e)
        {
            DemoCommon.AboutForm aboutDlg = new DemoCommon.AboutForm(AppDomain.CurrentDomain.GetAssemblies());
            aboutDlg.ShowDialog(this);
        }

        #endregion

        #region Docking

        private void dockingManager_DockVisibilityChanged(object sender, Tools.DockVisibilityChangedEventArgs e)
        {
            if (e.Control == this.propertyEditor)
            {
                bool check = this.dockingManager.GetDockVisibility(propertyEditor);
                if (check)
                {
                    propertyEditor.Diagram = this.ActiveDiagram;
                    this.barItemViewProperties.Checked = true;
                }
                else
                {
                    propertyEditor.Diagram = null;
                    this.barItemViewProperties.Checked = false;
                }
            }
            else if (e.Control == this.symbolPaletteGroupBar)
            {
                this.barItemViewSymbolPalette.Checked = this.dockingManager.GetDockVisibility(symbolPaletteGroupBar);
            }
            else if (e.Control == this.pnlAssSymbols)
            {
                this.barItemViewAssSymbols.Checked = this.dockingManager.GetDockVisibility(this.pnlAssSymbols);
            }
            else if (e.Control == this.overviewControl1)
            {
                bool check = this.dockingManager.GetDockVisibility(overviewControl1);
                if (check)
                {
                    overviewControl1.Diagram = this.ActiveDiagram;
                    this.barItemViewProperties.Checked = true;
                }
                else
                {
                    overviewControl1.DetachDiagram();
                    this.barItemPanZoom.Checked = false;
                }
            }
            else if (e.Control == m_documentExplorer)
                barItemDocumentExplorer.Checked = this.dockingManager.GetDockVisibility(m_documentExplorer);
        }

        #endregion

        #region UI Updating

        public void UpdateAssociatedSymbolsList()
        {
            this.chkListAssSymbols.Items.Clear();
            foreach (AssociatedSymbolPaletteInfo aInfo in this.ActiveDiagramForm.AssociatedSymbolPalettes)
                foreach (SymbolPaletteInfo sInfo in aInfo.SymbolPaletteInfo)
                    this.chkListAssSymbols.Items.Add(sInfo.SymbolPaletteName, CheckState.Unchecked);
        }

        private void OnIdle(object sender, EventArgs evtArgs)
        {
            Controls.Diagram activeDiagram = this.ActiveDiagram;

            string editUndoText = this.resStringMgr.GetString("EditUndoText");
            string editRedoText = this.resStringMgr.GetString("EditRedoText");
            this.barItemPanZoom.Checked = dockingManager.GetDockVisibility(overviewControl1);
            this.barItemDocumentExplorer.Checked = dockingManager.GetDockVisibility(m_documentExplorer);
            this.barItemViewProperties.Checked = dockingManager.GetDockVisibility(propertyEditor);
            this.barItemViewSymbolPalette.Checked = dockingManager.GetDockVisibility(symbolPaletteGroupBar);
            this.barItemViewAssSymbols.Checked = dockingManager.GetDockVisibility(pnlAssSymbols);

            if (activeDiagram != null && activeDiagram.Model != null)
            {
                this.biFileSave.Enabled = true;
                this.biFileSaveAs.Enabled = true;
                this.barItemEditCopy.Enabled = activeDiagram.CanCopy;
                this.barItemEditCut.Enabled = activeDiagram.CanCut;
                if (this.WindowState != FormWindowState.Minimized)
                    this.barItemEditPaste.Enabled = activeDiagram.CanPaste;
                this.barItemEditUndo.Enabled = activeDiagram.Model.HistoryManager.CanUndo;
                this.barItemEditRedo.Enabled = activeDiagram.Model.HistoryManager.CanRedo;
                this.barItemEditDelete.Enabled = (this.ActiveDiagram.Controller.SelectionList.Count > 0);
                this.barShowRulers.Enabled = true;
                this.barShowRulers.Checked = this.ActiveDiagram.ShowRulers;
                this.barItemEditSelectAll.Enabled = true;
                this.biFilePrint.Enabled = true;
                this.biPageSetup.Enabled = true;
                barItemAlignLeft.Enabled = (this.ActiveDiagram.Controller.SelectionList.Count >= 2);
                barItemAlignCenter.Enabled = (this.ActiveDiagram.Controller.SelectionList.Count >= 2);
                barItemAlignRight.Enabled = (this.ActiveDiagram.Controller.SelectionList.Count >= 2);
                barItemAlignTop.Enabled = (this.ActiveDiagram.Controller.SelectionList.Count >= 2);
                barItemAlignMiddle.Enabled = (this.ActiveDiagram.Controller.SelectionList.Count >= 2);
                barItemAlignBottom.Enabled = (this.ActiveDiagram.Controller.SelectionList.Count >= 2);
                barItemFlipHorizontally.Enabled = (this.ActiveDiagram.Controller.SelectionList.Count > 0);
                barItemFlipVertically.Enabled = (this.ActiveDiagram.Controller.SelectionList.Count > 0);
                barItemFlipBoth.Enabled = (this.ActiveDiagram.Controller.SelectionList.Count > 0);
                barItemGroupingGroup.Enabled = (this.ActiveDiagram.Controller.SelectionList.Count > 1);
                barItemGroupingUnGroup.Enabled = true;
                barItemOrderFront.Enabled = (this.ActiveDiagram.Controller.SelectionList.Count > 0);
                barItemOrderForward.Enabled = (this.ActiveDiagram.Controller.SelectionList.Count > 0);
                barItemOrderBackward.Enabled = (this.ActiveDiagram.Controller.SelectionList.Count > 0);
                barItemOrderBack.Enabled = (this.ActiveDiagram.Controller.SelectionList.Count > 0);
                barItemRotateClock.Enabled = (this.ActiveDiagram.Controller.SelectionList.Count > 0);
                barItemRotateConter.Enabled = (this.ActiveDiagram.Controller.SelectionList.Count > 0);
                barItemResizeWidth.Enabled = (this.ActiveDiagram.Controller.SelectionList.Count > 1);
                barItemResizeHeight.Enabled = (this.ActiveDiagram.Controller.SelectionList.Count > 1);
                barItemResizeSize.Enabled = (this.ActiveDiagram.Controller.SelectionList.Count > 1);
                barItemResizeAcross.Enabled = (this.ActiveDiagram.Controller.SelectionList.Count > 1);
                barItemResizeDown.Enabled = (this.ActiveDiagram.Controller.SelectionList.Count > 1);
                if (this.ActiveDiagram.Controller.SelectionList.Count > 0)
                {
                    Node node = this.ActiveDiagram.Controller.SelectionList[0];
                    barItemFillStyle.Enabled = (TypeDescriptor.GetProperties(node, false)["FillStyle"] != null);
                    barItemShadowStyle.Enabled = (TypeDescriptor.GetProperties(node, false)["ShadowStyle"] != null);
                }

                string[] strDescriptions;
                int nDescWanted = 1;
                int nDescReturned = activeDiagram.Model.HistoryManager.GetUndoDescriptions(nDescWanted, out strDescriptions);

                if (nDescReturned == nDescWanted)
                    editUndoText = editUndoText + " " + strDescriptions[0];

                // clear strDecsriptions.
                nDescReturned = activeDiagram.Model.HistoryManager.GetRedoDescriptions(nDescWanted, out strDescriptions);
                if (nDescReturned == nDescWanted)
                    editRedoText = editRedoText + " " + strDescriptions[0];
            }
            else
            {
                this.biFileSave.Enabled = false;
                this.biFileSaveAs.Enabled = false;
                this.barItemEditCopy.Enabled = false;
                this.barItemEditCut.Enabled = false;
                this.barItemEditPaste.Enabled = false;
                this.barItemEditUndo.Enabled = false;
                this.barItemEditRedo.Enabled = false;
                this.barItemEditSelectAll.Enabled = false;
                this.biFilePrint.Enabled = false;
                this.biPageSetup.Enabled = false;
                this.barItemEditDelete.Enabled = false;
                this.barShowRulers.Enabled = false;

                barItemAlignLeft.Enabled = false;
                barItemAlignCenter.Enabled = false;
                barItemAlignRight.Enabled = false;
                barItemAlignTop.Enabled = false;
                barItemAlignMiddle.Enabled = false;
                barItemAlignBottom.Enabled = false;
                barItemFlipHorizontally.Enabled = false;
                barItemFlipVertically.Enabled = false;
                barItemFlipBoth.Enabled = false;
                barItemGroupingGroup.Enabled = false;
                barItemGroupingUnGroup.Enabled = false;
                barItemOrderFront.Enabled = false;
                barItemOrderForward.Enabled = false;
                barItemOrderBackward.Enabled = false;
                barItemOrderBack.Enabled = false;
                barItemRotateClock.Enabled = false;
                barItemRotateConter.Enabled = false;
                barItemResizeWidth.Enabled = false;
                barItemResizeHeight.Enabled = false;
                barItemResizeSize.Enabled = false;
                barItemResizeAcross.Enabled = false;
                barItemResizeDown.Enabled = false;
                barItemFillStyle.Enabled = false;
                barItemShadowStyle.Enabled = false;
            }

            this.barItemEditUndo.Text = editUndoText;
            this.barItemEditRedo.Text = editRedoText;

        }

        #endregion

        #region Printing

        private void PageSetup()
        {
            Controls.Diagram activeDiagram = this.ActiveDiagram;

            if (activeDiagram != null && activeDiagram.Model != null)
            {
                PrintSetupDialog dlgPrintSetup = new PrintSetupDialog();

                // Made to make values more user friendly 
                dlgPrintSetup.PageSettings = activeDiagram.View.PageSettings;
                dlgPrintSetup.PrintZoom = activeDiagram.View.PrintZoom;

                if (dlgPrintSetup.ShowDialog() == DialogResult.OK)
                {
                    activeDiagram.View.PageSettings = dlgPrintSetup.PageSettings;
                    activeDiagram.View.PrintZoom = dlgPrintSetup.PrintZoom;
                    activeDiagram.View.RefreshPageSettings();
                    activeDiagram.UpdateView();
                }
            }
        }

        private void Print()
        {
            //			TextNode txtnode = new TextNode( "Hello World" );
            //			txtnode.SizeToText( new SizeF( 500,50 ) );

            //			InsertNodesCmd inscmd = new InsertNodesCmd();
            //			inscmd.Location = new PointF( 50,50 );
            //			inscmd.Nodes.Add( txtnode );
            //			this.ActiveDiagram.Controller.ExecuteCommand( inscmd );

            //			GroupCmd grpcmd = new GroupCmd();
            //			grpcmd.Nodes.Add( txtnode );
            //			this.ActiveDiagram.Controller.ExecuteCommand( grpcmd );

            Controls.Diagram activeDiagram = this.ActiveDiagram;
            if (activeDiagram != null)
            {
                PrintDocument printDoc = activeDiagram.CreatePrintDocument();
                PrintDialog printDlg = new PrintDialog();
                printDlg.Document = printDoc;

                printDlg.AllowSomePages = true;

                if (printDlg.ShowDialog(this) == DialogResult.OK)
                {
                    printDoc.PrinterSettings = printDlg.PrinterSettings;
                    printDoc.Print();
                }
            }
        }

        private void PrintPreview()
        {
            Controls.Diagram activeDiagram = this.ActiveDiagram;

            if (activeDiagram != null)
            {
                PrintDocument printDoc = activeDiagram.CreatePrintDocument();
                PrintPreviewDialog printPreviewDlg = new PrintPreviewDialog();
                printPreviewDlg.StartPosition = FormStartPosition.CenterScreen;

                printDoc.PrinterSettings.FromPage = 0;
                printDoc.PrinterSettings.ToPage = 0;
                printDoc.PrinterSettings.PrintRange = PrintRange.AllPages;

                printPreviewDlg.Document = printDoc;
                printPreviewDlg.ShowDialog(this);
            }
        }

        #endregion

        #region MDI Window Management

        private void DiagramForm_Closing(object sender, CancelEventArgs e)
        {
            DiagramForm docForm = sender as DiagramForm;
            if (docForm != null && docForm.Diagram.Model != null)
            {
                if (docForm.SaveChanges)
                {
                    DialogResult res = MessageBoxAdv.Show(this, "The diagram or its association has been modified. Save changes?", "Save changes", MessageBoxButtons.YesNoCancel,MessageBoxIcon.Question);
                    if (res == DialogResult.Yes)
                    {
                        if (docForm.HasFileName)
                        {
                            this.saveDiagramDialog.FileName = docForm.FileName;
                        }
                        if (this.saveDiagramDialog.ShowDialog(this) == DialogResult.OK)
                        {
                            docForm.SaveAsFile(this.saveDiagramDialog.FileName);
                            docForm.fileName = this.saveDiagramDialog.FileName;
                        }
                        else
                        {
                            e.Cancel = true;
                        }
                    }
                    else if (res == DialogResult.Cancel)
                    {
                        e.Cancel = true;
                    }
                }

                if (!e.Cancel)
                {
                    m_documentExplorer.DetachModel(docForm.Diagram.Model);
                    this.overviewControl1.DetachDiagram();
                    this.chkListAssSymbols.Items.Clear();
                }
            }
        }

        #endregion

        #region Actions
        private void m_documentExplorer_AfterSelect(object sender, TreeViewEventArgs e)
        {
            // Update diagram's selection list depending on TreeNode Tag
            if (e.Node.Tag is Model)
            {
                foreach (Form frm in this.MdiChildren)
                {
                    DiagramForm frmDgm = frm as DiagramForm;

                    if (frmDgm != null)
                    {
                        if (frmDgm.Diagram != null && frmDgm.Diagram.Model != null
                            && frmDgm.Diagram.Model.Equals(e.Node.Tag))
                        {
                            frmDgm.BringToFront();
                            break;
                        }
                    }
                }
            }
            else if (e.Node.Tag is Node)
            {
                Node nodeTemp = e.Node.Tag as Node;

                if (nodeTemp != null)
                {
                    if (nodeTemp.Visible && nodeTemp.Root.Equals(this.ActiveDiagram.Model))
                    {
                        ActiveDiagram.View.SelectionList.Clear();
                        ActiveDiagram.View.SelectionList.Add(e.Node.Tag as Node);
                    }
                    else
                    {
                        propertyEditor.PropertyGrid.SelectedObject = nodeTemp;
                    }
                }
            }
        }

        private void barItemEditDelete_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null)
            {
                DiagramForm diagramForm = this.ActiveMdiChild as DiagramForm;
                if (diagramForm != null)
                {
                    diagramForm.Diagram.Controller.Delete();
                }
            }
        }

        private void barItemAlign_Click(object sender, EventArgs e)
        {
            switch (((Tools.XPMenus.BarItem)sender).ID)
            {
                case "AlignLeft":
                    this.ActiveDiagram.AlignLeft();
                    break;
                case "AlignCenter":
                    this.ActiveDiagram.AlignCenter();
                    break;
                case "AlignBottom":
                    this.ActiveDiagram.AlignBottom();
                    break;
                case "AlignMiddle":
                    this.ActiveDiagram.AlignMiddle();
                    break;
                case "AlignTop":
                    this.ActiveDiagram.AlignTop();
                    break;
                case "AlignRight":
                    this.ActiveDiagram.AlignRight();
                    break;
                default:
                    break;
            }

        }

        private void barItemFlip_Click(object sender, EventArgs e)
        {
            switch (((Tools.XPMenus.BarItem)sender).ID.ToLower())
            {
                case "fliphorizontally":
                    this.ActiveDiagram.FlipHorizontal();
                    break;
                case "flipvertically":
                    this.ActiveDiagram.FlipVertical();
                    break;
                case "flipboth":
                    this.ActiveDiagram.FlipHorizontal();
                    this.ActiveDiagram.FlipVertical();
                    break;
                default:
                    break;
            }

        }

        private void barItemGroupingGroup_Click(object sender, EventArgs e)
        {
            switch (((Tools.XPMenus.BarItem)sender).ID.ToLower())
            {
                case "group":
                    this.ActiveDiagram.Controller.Group();
                    break;
                case "ungroup":
                    this.ActiveDiagram.Controller.UnGroup();
                    break;
                default:
                    break;
            }
        }

        private void barItemOrder_Click(object sender, EventArgs e)
        {
            switch (((Tools.XPMenus.BarItem)sender).ID.ToLower())
            {
                case "bring to front":
                    this.ActiveDiagram.Controller.BringToFront();
                    break;
                case "bring forward":
                    this.ActiveDiagram.Controller.BringForward();
                    break;
                case "send backward":
                    this.ActiveDiagram.Controller.SendBackward();
                    break;
                case "send to back":
                    this.ActiveDiagram.Controller.SendToBack();
                    break;
                default:
                    break;
            }

        }

        private void barItemRotate_Click(object sender, EventArgs e)
        {
            switch (((Tools.XPMenus.BarItem)sender).ID.ToLower())
            {
                case "rotateclock":
                    this.ActiveDiagram.Rotate(90);
                    break;
                case "rotateconter":
                    this.ActiveDiagram.Rotate(-90);
                    break;
                default:
                    break;
            }

        }

        private void barItemResize_Click(object sender, EventArgs e)
        {
            switch (((Tools.XPMenus.BarItem)sender).ID.ToLower())
            {
                case "spaceacross":
                    this.ActiveDiagram.SpaceAcross();
                    break;
                case "spacedown":
                    this.ActiveDiagram.SpaceDown();
                    break;
                case "samesize":
                    this.ActiveDiagram.SameSize();
                    break;
                case "sameheight":
                    this.ActiveDiagram.SameHeight();
                    break;
                case "samewidth":
                    this.ActiveDiagram.SameWidth();
                    break;
                default:
                    break;
            }
        }

        private void barItemLayout_Click(object sender, EventArgs e)
        {
            LayoutDialog dialog = new LayoutDialog(this.ActiveDiagram);
            dialog.ShowDialog();
        }
        #endregion

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            SyncfusionLicenseProvider.ValidateLicense(Platform.Utility);
            Application.ThreadException += new System.Threading.ThreadExceptionEventHandler(DefaultExceptionHandler.Singleton.OnThreadException);
            if (args.Length > 0)
            {
                if (File.Exists(args[0]))
                    Application.Run(new MainForm(args[0]));
                else
                {
                    Console.WriteLine("File doesnot exists");
                    Console.WriteLine("----------------------");
                    Console.WriteLine("Running in default mode");
                    Application.Run(new MainForm());
                }
            }
            else
                Application.Run(new MainForm());
            Application.ThreadException -= new System.Threading.ThreadExceptionEventHandler(DefaultExceptionHandler.Singleton.OnThreadException);
        }


        internal Tools.XPMenus.ParentBarItem GetPopupParentBar()
        {
            return this.parentBarItemPopUp;
        }

        private void shadowBarItem_Click(object sender, System.EventArgs e)
        {
            ShadowStyleDialog ssd = new ShadowStyleDialog();
            ShadowStyle fs = null;
            foreach (Node n in this.ActiveDiagram.Controller.SelectionList)
            {
                fs = (ShadowStyle)TypeDescriptor.GetProperties(n, false)["ShadowStyle"].GetValue(n);
                if (fs != null)
                {
                    break;
                }
            }
            if (fs != null)
            {
                ssd.ShadowStyle.Color = fs.Color;
                ssd.ShadowStyle.ForeColor = fs.ForeColor;
                ssd.ShadowStyle.ColorAlphaFactor = fs.ColorAlphaFactor;
                ssd.ShadowStyle.ForeColorAlphaFactor = fs.ForeColorAlphaFactor;
                ssd.ShadowStyle.PathBrushStyle = fs.PathBrushStyle;
                ssd.ShadowStyle.OffsetX = fs.OffsetX;
                ssd.ShadowStyle.OffsetY = fs.OffsetY;
                ssd.ShadowStyle.Visible = fs.Visible;
                if (DialogResult.OK == ssd.ShowDialog())
                {
                    foreach (Node n in this.ActiveDiagram.Controller.SelectionList)
                    {
                        fs = (ShadowStyle)TypeDescriptor.GetProperties(n, false)["ShadowStyle"].GetValue(n);
                        if (fs != null)
                        {
                            fs.Color = ssd.ShadowStyle.Color;
                            fs.ForeColor = ssd.ShadowStyle.ForeColor;
                            fs.ColorAlphaFactor = ssd.ShadowStyle.ColorAlphaFactor;
                            fs.ForeColorAlphaFactor = ssd.ShadowStyle.ForeColorAlphaFactor;
                            fs.PathBrushStyle = ssd.ShadowStyle.PathBrushStyle;
                            fs.OffsetX = ssd.ShadowStyle.OffsetX;
                            fs.OffsetY = ssd.ShadowStyle.OffsetY;
                            fs.Visible = ssd.ShadowStyle.Visible;
                        }
                    }
                }
            }
        }

        private void fillBarItem_Click(object sender, System.EventArgs e)
        {
            FillStyleDialog fsd = new FillStyleDialog();
            Node node;
            FillStyle fs = null;
            foreach (Node n in this.ActiveDiagram.Controller.SelectionList)
            {
                fs = (FillStyle)TypeDescriptor.GetProperties(n, false)["FillStyle"].GetValue(n);
                if (fs != null)
                {
                    node = n;
                    break;
                }
            }

            if (fs != null)
            {
                fsd.FillStyle.Color = fs.Color;
                fsd.FillStyle.ForeColor = fs.ForeColor;
                fsd.FillStyle.ColorAlphaFactor = fs.ColorAlphaFactor;
                fsd.FillStyle.ForeColorAlphaFactor = fs.ForeColorAlphaFactor;
                fsd.FillStyle.Type = fs.Type;
                fsd.FillStyle.GradientAngle = fs.GradientAngle;
                fsd.FillStyle.GradientCenter = fs.GradientCenter;
                fsd.FillStyle.PathBrushStyle = fs.PathBrushStyle;
                fsd.FillStyle.HatchBrushStyle = fs.HatchBrushStyle;
                fsd.FillStyle.Texture = fs.Texture;
                fsd.FillStyle.TextureWrapMode = fs.TextureWrapMode;
                if (DialogResult.OK == fsd.ShowDialog())
                {
                    foreach (Node n in this.ActiveDiagram.Controller.SelectionList)
                    {
                        fs = (FillStyle)TypeDescriptor.GetProperties(n, false)["FillStyle"].GetValue(n);
                        if (fs != null)
                        {
                            fs.Color = fsd.FillStyle.Color;
                            fs.ForeColor = fsd.FillStyle.ForeColor;
                            fs.ColorAlphaFactor = fsd.FillStyle.ColorAlphaFactor;
                            fs.ForeColorAlphaFactor = fsd.FillStyle.ForeColorAlphaFactor;
                            fs.Type = fsd.FillStyle.Type;
                            fs.GradientAngle = fsd.FillStyle.GradientAngle;
                            fs.GradientCenter = fsd.FillStyle.GradientCenter;
                            fs.PathBrushStyle = fsd.FillStyle.PathBrushStyle;
                            fs.HatchBrushStyle = fsd.FillStyle.HatchBrushStyle;
                            fs.Texture = fsd.FillStyle.Texture;
                            fs.TextureWrapMode = fsd.FillStyle.TextureWrapMode;
                        }
                    }
                }
            }
        }

        private void tabbedMDIManager_TabControlAdded(object sender, Syncfusion.Windows.Forms.Tools.TabbedMDITabControlEventArgs args)
        {
            args.TabControl.TabStyle = typeof(TabRendererOffice2007);
            tabbedMDIManager.ContextMenuItem.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007;
            args.TabControl.SelectedIndexChanged += new EventHandler(TabControl_SelectedIndexChanged);
        }

        void TabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            MDITabPanel tc = sender as MDITabPanel;
            currentForm = tc.GetSelectedForm();
        }

        private void MainForm_Closing(object sender, CancelEventArgs e)
        {
            // Save Menu Bars State
            AppStateSerializer serializer = new AppStateSerializer(SerializeMode.XMLFile, @"..\..\persist");
            this.mainFrameBarManager.SaveBarState(serializer);
            serializer.PersistNow();
        }

        private void btnRemoveAss_Click(object sender, EventArgs e)
        {
            string mesg = "The palette symbols may be in use. Are you sure want to remove the association?";
            DialogResult dr = MessageBoxAdv.Show(mesg, " ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
                while (chkListAssSymbols.CheckedItems.Count != 0)
                {
                    string paletteName = chkListAssSymbols.CheckedItems[0].ToString();
                    RemoveAssociation(Path.GetFileNameWithoutExtension(paletteName));
                    chkListAssSymbols.Items.Remove(chkListAssSymbols.CheckedItems[0]);
                }
            btnRemoveAss.Enabled = false;
        }

        private void RemoveAssociation(string paletteName)
        {
            foreach (AssociatedSymbolPaletteInfo aInfo in this.ActiveDiagramForm.AssociatedSymbolPalettes)
            {
                for (int i = 0; i < aInfo.SymbolPaletteInfo.Count; i++)
                {
                    SymbolPaletteInfo sInfo = aInfo.SymbolPaletteInfo[i];
                    if (sInfo.SymbolPaletteName.Equals(paletteName))
                    {
                        aInfo.SymbolPaletteInfo.Remove(sInfo);
                        ActiveDiagramForm.SaveChanges = true;
                    }
                }
            }
        }

        private void chkListAssSymbols_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (chkListAssSymbols.CheckedItems.Count != 0)
                this.btnRemoveAss.Enabled = true;
            else
                this.btnRemoveAss.Enabled = false;
        }

    }
}
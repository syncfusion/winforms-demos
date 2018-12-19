namespace Sequence_Diagram_2005
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.toolBar = new System.Windows.Forms.ToolStrip();
            this.btnNew = new System.Windows.Forms.ToolStripButton();
            this.btnOpen = new System.Windows.Forms.ToolStripButton();
            this.btnSave = new System.Windows.Forms.ToolStripButton();
            this.btnSaveAs = new System.Windows.Forms.ToolStripButton();
            this.dropDownBtnExport = new System.Windows.Forms.ToolStripDropDownButton();
            this.exportPng = new System.Windows.Forms.ToolStripMenuItem();
            this.exportJpg = new System.Windows.Forms.ToolStripMenuItem();
            this.exportPdf = new System.Windows.Forms.ToolStripMenuItem();
            this.seperator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnUndo = new System.Windows.Forms.ToolStripButton();
            this.btnRedo = new System.Windows.Forms.ToolStripButton();
            this.btnCut = new System.Windows.Forms.ToolStripButton();
            this.btnCopy = new System.Windows.Forms.ToolStripButton();
            this.btnPaste = new System.Windows.Forms.ToolStripButton();
            this.separator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnRuler = new System.Windows.Forms.ToolStripButton();
            this.btnGrid = new System.Windows.Forms.ToolStripButton();
            this.btnSnapToGrid = new System.Windows.Forms.ToolStripButton();
            this.separator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnSize = new System.Windows.Forms.ToolStripButton();
            this.btnAutoSize = new System.Windows.Forms.ToolStripButton();
            this.btnPageSettings = new System.Windows.Forms.ToolStripButton();
            this.separator4 = new System.Windows.Forms.ToolStripSeparator();
            this.btnPreview = new System.Windows.Forms.ToolStripButton();
            this.btnPrint = new System.Windows.Forms.ToolStripButton();
            this.paletteGroupBar1 = new Syncfusion.Windows.Forms.Diagram.Controls.PaletteGroupBar(this.components);
            this.diagram1 = new Syncfusion.Windows.Forms.Diagram.Controls.Diagram(this.components);
            this.model1 = new Syncfusion.Windows.Forms.Diagram.Model(this.components);
            this.printDialog = new System.Windows.Forms.PrintDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.saveAsFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.exportFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.toolBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paletteGroupBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.model1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolBar
            // 
            this.toolBar.AutoSize = false;
            this.toolBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(240)))));
            this.toolBar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNew,
            this.btnOpen,
            this.btnSave,
            this.btnSaveAs,
            this.dropDownBtnExport,
            this.seperator1,
            this.btnUndo,
            this.btnRedo,
            this.btnCut,
            this.btnCopy,
            this.btnPaste,
            this.separator2,
            this.btnRuler,
            this.btnGrid,
            this.btnSnapToGrid,
            this.separator3,
            this.btnSize,
            this.btnAutoSize,
            this.btnPageSettings,
            this.separator4,
            this.btnPreview,
            this.btnPrint});
            this.toolBar.Location = new System.Drawing.Point(0, 0);
            this.toolBar.Name = "toolBar";
            this.toolBar.Size = new System.Drawing.Size(1034, 77);
            this.toolBar.TabIndex = 0;
            this.toolBar.Text = "toolStrip1";
            // 
            // btnNew
            // 
            this.btnNew.Image = ((System.Drawing.Image)(resources.GetObject("btnNew.Image")));
            this.btnNew.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNew.Name = "btnNew";
            this.btnNew.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnNew.Size = new System.Drawing.Size(46, 74);
            this.btnNew.Text = "New";
            this.btnNew.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.Image = ((System.Drawing.Image)(resources.GetObject("btnOpen.Image")));
            this.btnOpen.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnOpen.Size = new System.Drawing.Size(50, 74);
            this.btnOpen.Text = "Open";
            this.btnOpen.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnOpen.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnSave
            // 
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSave.Name = "btnSave";
            this.btnSave.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnSave.Size = new System.Drawing.Size(46, 74);
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnSaveAs
            // 
            this.btnSaveAs.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveAs.Image")));
            this.btnSaveAs.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnSaveAs.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSaveAs.Name = "btnSaveAs";
            this.btnSaveAs.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnSaveAs.Size = new System.Drawing.Size(61, 74);
            this.btnSaveAs.Text = "Save As";
            this.btnSaveAs.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSaveAs.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSaveAs.Click += new System.EventHandler(this.btnSaveAs_Click);
            // 
            // dropDownBtnExport
            // 
            this.dropDownBtnExport.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportPng,
            this.exportJpg,
            this.exportPdf});
            this.dropDownBtnExport.Image = ((System.Drawing.Image)(resources.GetObject("dropDownBtnExport.Image")));
            this.dropDownBtnExport.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.dropDownBtnExport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.dropDownBtnExport.Name = "dropDownBtnExport";
            this.dropDownBtnExport.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.dropDownBtnExport.ShowDropDownArrow = false;
            this.dropDownBtnExport.Size = new System.Drawing.Size(54, 74);
            this.dropDownBtnExport.Text = "Export";
            this.dropDownBtnExport.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.dropDownBtnExport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // exportPng
            // 
            this.exportPng.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(240)))));
            this.exportPng.Name = "exportPng";
            this.exportPng.Size = new System.Drawing.Size(99, 22);
            this.exportPng.Text = "PNG";
            this.exportPng.Click += new System.EventHandler(this.exportPng_Click);
            // 
            // exportJpg
            // 
            this.exportJpg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(240)))));
            this.exportJpg.Name = "exportJpg";
            this.exportJpg.Size = new System.Drawing.Size(99, 22);
            this.exportJpg.Text = "JPEG";
            this.exportJpg.Click += new System.EventHandler(this.exportJpg_Click);
            // 
            // exportPdf
            // 
            this.exportPdf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(240)))));
            this.exportPdf.Name = "exportPdf";
            this.exportPdf.Size = new System.Drawing.Size(99, 22);
            this.exportPdf.Text = "GIF";
            this.exportPdf.Click += new System.EventHandler(this.exportPdf_Click);
            // 
            // seperator1
            // 
            this.seperator1.AutoSize = false;
            this.seperator1.Name = "seperator1";
            this.seperator1.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.seperator1.Size = new System.Drawing.Size(6, 60);
            // 
            // btnUndo
            // 
            this.btnUndo.Image = ((System.Drawing.Image)(resources.GetObject("btnUndo.Image")));
            this.btnUndo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnUndo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnUndo.Size = new System.Drawing.Size(50, 74);
            this.btnUndo.Text = "Undo";
            this.btnUndo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnUndo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnUndo.Click += new System.EventHandler(this.btnUndo_Click);
            // 
            // btnRedo
            // 
            this.btnRedo.Image = ((System.Drawing.Image)(resources.GetObject("btnRedo.Image")));
            this.btnRedo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnRedo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRedo.Name = "btnRedo";
            this.btnRedo.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnRedo.Size = new System.Drawing.Size(48, 74);
            this.btnRedo.Text = "Redo";
            this.btnRedo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRedo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnRedo.Click += new System.EventHandler(this.btnRedo_Click);
            // 
            // btnCut
            // 
            this.btnCut.Image = ((System.Drawing.Image)(resources.GetObject("btnCut.Image")));
            this.btnCut.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnCut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCut.Name = "btnCut";
            this.btnCut.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnCut.Size = new System.Drawing.Size(46, 74);
            this.btnCut.Text = "Cut";
            this.btnCut.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCut.Click += new System.EventHandler(this.btnCut_Click);
            // 
            // btnCopy
            // 
            this.btnCopy.Image = ((System.Drawing.Image)(resources.GetObject("btnCopy.Image")));
            this.btnCopy.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnCopy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnCopy.Size = new System.Drawing.Size(49, 74);
            this.btnCopy.Text = "Copy";
            this.btnCopy.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCopy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // btnPaste
            // 
            this.btnPaste.Image = ((System.Drawing.Image)(resources.GetObject("btnPaste.Image")));
            this.btnPaste.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnPaste.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPaste.Name = "btnPaste";
            this.btnPaste.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnPaste.Size = new System.Drawing.Size(49, 74);
            this.btnPaste.Text = "Paste";
            this.btnPaste.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPaste.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnPaste.Click += new System.EventHandler(this.btnPaste_Click);
            // 
            // separator2
            // 
            this.separator2.AutoSize = false;
            this.separator2.Name = "separator2";
            this.separator2.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.separator2.Size = new System.Drawing.Size(6, 60);
            // 
            // btnRuler
            // 
            this.btnRuler.CheckOnClick = true;
            this.btnRuler.Image = ((System.Drawing.Image)(resources.GetObject("btnRuler.Image")));
            this.btnRuler.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnRuler.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRuler.Name = "btnRuler";
            this.btnRuler.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnRuler.Size = new System.Drawing.Size(48, 74);
            this.btnRuler.Text = "Ruler";
            this.btnRuler.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRuler.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnRuler.Click += new System.EventHandler(this.btnRuler_Click);
            // 
            // btnGrid
            // 
            this.btnGrid.CheckOnClick = true;
            this.btnGrid.Image = ((System.Drawing.Image)(resources.GetObject("btnGrid.Image")));
            this.btnGrid.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnGrid.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGrid.Name = "btnGrid";
            this.btnGrid.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnGrid.Size = new System.Drawing.Size(46, 74);
            this.btnGrid.Text = "Grid";
            this.btnGrid.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGrid.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnGrid.Click += new System.EventHandler(this.btnGrid_Click);
            // 
            // btnSnapToGrid
            // 
            this.btnSnapToGrid.CheckOnClick = true;
            this.btnSnapToGrid.Image = ((System.Drawing.Image)(resources.GetObject("btnSnapToGrid.Image")));
            this.btnSnapToGrid.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnSnapToGrid.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSnapToGrid.Name = "btnSnapToGrid";
            this.btnSnapToGrid.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnSnapToGrid.Size = new System.Drawing.Size(89, 74);
            this.btnSnapToGrid.Text = "Snap To Grid";
            this.btnSnapToGrid.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSnapToGrid.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSnapToGrid.Click += new System.EventHandler(this.btnSnapToGrid_Click);
            // 
            // separator3
            // 
            this.separator3.AutoSize = false;
            this.separator3.Name = "separator3";
            this.separator3.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.separator3.Size = new System.Drawing.Size(6, 60);
            // 
            // btnSize
            // 
            this.btnSize.Image = ((System.Drawing.Image)(resources.GetObject("btnSize.Image")));
            this.btnSize.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnSize.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSize.Name = "btnSize";
            this.btnSize.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnSize.Size = new System.Drawing.Size(46, 74);
            this.btnSize.Text = "Size";
            this.btnSize.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSize.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSize.Click += new System.EventHandler(this.btnSize_Click);
            // 
            // btnAutoSize
            // 
            this.btnAutoSize.Image = ((System.Drawing.Image)(resources.GetObject("btnAutoSize.Image")));
            this.btnAutoSize.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnAutoSize.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAutoSize.Name = "btnAutoSize";
            this.btnAutoSize.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnAutoSize.Size = new System.Drawing.Size(70, 74);
            this.btnAutoSize.Text = "Auto Size";
            this.btnAutoSize.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAutoSize.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAutoSize.Click += new System.EventHandler(this.btnAutoSize_Click);
            // 
            // btnPageSettings
            // 
            this.btnPageSettings.Image = ((System.Drawing.Image)(resources.GetObject("btnPageSettings.Image")));
            this.btnPageSettings.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnPageSettings.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPageSettings.Name = "btnPageSettings";
            this.btnPageSettings.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnPageSettings.Size = new System.Drawing.Size(80, 74);
            this.btnPageSettings.Text = "Page Setup";
            this.btnPageSettings.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPageSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnPageSettings.Click += new System.EventHandler(this.btnPageSettings_Click);
            // 
            // separator4
            // 
            this.separator4.AutoSize = false;
            this.separator4.Name = "separator4";
            this.separator4.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.separator4.Size = new System.Drawing.Size(6, 60);
            // 
            // btnPreview
            // 
            this.btnPreview.Image = ((System.Drawing.Image)(resources.GetObject("btnPreview.Image")));
            this.btnPreview.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnPreview.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnPreview.Size = new System.Drawing.Size(62, 74);
            this.btnPreview.Text = "Preview";
            this.btnPreview.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPreview.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Image = ((System.Drawing.Image)(resources.GetObject("btnPrint.Image")));
            this.btnPrint.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnPrint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnPrint.Size = new System.Drawing.Size(46, 74);
            this.btnPrint.Text = "Print";
            this.btnPrint.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPrint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // paletteGroupBar1
            // 
            this.paletteGroupBar1.AllowDrop = true;
            this.paletteGroupBar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.paletteGroupBar1.BorderColor = System.Drawing.Color.White;
            this.paletteGroupBar1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.paletteGroupBar1.Diagram = null;
            this.paletteGroupBar1.Dock = System.Windows.Forms.DockStyle.Left;
            this.paletteGroupBar1.EditMode = false;
            this.paletteGroupBar1.ExpandButtonToolTip = null;
            this.paletteGroupBar1.FlatLook = true;
            this.paletteGroupBar1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paletteGroupBar1.ForeColor = System.Drawing.Color.White;
            this.paletteGroupBar1.GroupBarDropDownToolTip = null;
            this.paletteGroupBar1.GroupBarItemHeight = 32;
            this.paletteGroupBar1.IndexOnVisibleItems = true;
            this.paletteGroupBar1.Location = new System.Drawing.Point(0, 77);
            this.paletteGroupBar1.MinimizeButtonToolTip = null;
            this.paletteGroupBar1.Name = "paletteGroupBar1";
            this.paletteGroupBar1.NavigationPaneTooltip = null;
            this.paletteGroupBar1.PopupClientSize = new System.Drawing.Size(0, 0);
            this.paletteGroupBar1.Size = new System.Drawing.Size(214, 595);
            this.paletteGroupBar1.TabIndex = 1;
            this.paletteGroupBar1.Text = "paletteGroupBar1";
            this.paletteGroupBar1.TextAlign = Syncfusion.Windows.Forms.Tools.TextAlignment.Left;
            this.paletteGroupBar1.VisualStyle = Syncfusion.Windows.Forms.VisualStyle.Metro;
            // 
            // diagram1
            // 
            this.diagram1.Controller.PasteOffset = new System.Drawing.SizeF(10F, 10F);
            this.diagram1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.diagram1.LayoutManager = null;
            this.diagram1.Location = new System.Drawing.Point(214, 77);
            this.diagram1.Model = this.model1;
            this.diagram1.Name = "diagram1";
            this.diagram1.ScrollVirtualBounds = ((System.Drawing.RectangleF)(resources.GetObject("diagram1.ScrollVirtualBounds")));
            this.diagram1.Size = new System.Drawing.Size(820, 595);
            this.diagram1.SmartSizeBox = false;
            this.diagram1.TabIndex = 2;
            this.diagram1.Text = "diagram1";
            // 
            // 
            // 
            this.diagram1.View.ClientRectangle = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.diagram1.View.Controller = this.diagram1.Controller;
            this.diagram1.View.Grid.MinPixelSpacing = 4F;
            this.diagram1.View.ScrollVirtualBounds = ((System.Drawing.RectangleF)(resources.GetObject("resource.ScrollVirtualBounds")));
            // 
            // model1
            // 
            this.model1.BackgroundStyle.PathBrushStyle = Syncfusion.Windows.Forms.Diagram.PathGradientBrushStyle.RectangleCenter;
            this.model1.DocumentScale.DisplayName = "No Scale";
            this.model1.DocumentScale.Height = 1F;
            this.model1.DocumentScale.Width = 1F;
            this.model1.DocumentSize.Height = 1169F;
            this.model1.DocumentSize.Width = 827F;
            this.model1.LineStyle.DashPattern = null;
            this.model1.LineStyle.LineColor = System.Drawing.Color.Black;
            this.model1.LogicalSize = new System.Drawing.SizeF(827F, 1169F);
            this.model1.ShadowStyle.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.model1.ShadowStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            // 
            // printDialog
            // 
            this.printDialog.UseEXDialog = true;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 672);
            this.Controls.Add(this.diagram1);
            this.Controls.Add(this.paletteGroupBar1);
            this.Controls.Add(this.toolBar);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sequence Diagram";
            this.toolBar.ResumeLayout(false);
            this.toolBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paletteGroupBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.model1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolBar;
        private System.Windows.Forms.ToolStripButton btnNew;
        private System.Windows.Forms.ToolStripButton btnOpen;
        private System.Windows.Forms.ToolStripButton btnSave;
        private System.Windows.Forms.ToolStripButton btnSaveAs;
        private Syncfusion.Windows.Forms.Diagram.Controls.PaletteGroupBar paletteGroupBar1;
        private Syncfusion.Windows.Forms.Diagram.Controls.Diagram diagram1;
        private Syncfusion.Windows.Forms.Diagram.Model model1;
        private System.Windows.Forms.ToolStripDropDownButton dropDownBtnExport;
        private System.Windows.Forms.ToolStripMenuItem exportPng;
        private System.Windows.Forms.ToolStripMenuItem exportJpg;
        private System.Windows.Forms.ToolStripMenuItem exportPdf;
        private System.Windows.Forms.ToolStripSeparator seperator1;
        private System.Windows.Forms.ToolStripButton btnUndo;
        private System.Windows.Forms.ToolStripButton btnRedo;
        private System.Windows.Forms.ToolStripButton btnCut;
        private System.Windows.Forms.ToolStripButton btnCopy;
        private System.Windows.Forms.ToolStripButton btnPaste;
        private System.Windows.Forms.ToolStripSeparator separator2;
        private System.Windows.Forms.ToolStripButton btnRuler;
        private System.Windows.Forms.ToolStripButton btnGrid;
        private System.Windows.Forms.ToolStripButton btnSnapToGrid;
        private System.Windows.Forms.ToolStripSeparator separator3;
        private System.Windows.Forms.ToolStripButton btnSize;
        private System.Windows.Forms.ToolStripButton btnAutoSize;
        private System.Windows.Forms.ToolStripButton btnPageSettings;
        private System.Windows.Forms.ToolStripSeparator separator4;
        private System.Windows.Forms.ToolStripButton btnPreview;
        private System.Windows.Forms.ToolStripButton btnPrint;
        private System.Windows.Forms.PrintDialog printDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.SaveFileDialog saveAsFileDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog exportFileDialog;
    }
}


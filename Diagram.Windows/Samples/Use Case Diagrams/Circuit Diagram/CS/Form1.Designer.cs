namespace Circuit_Diagram
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.newToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.openToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.saveAsToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.exportToolStripButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.pNGToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jPEGToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gIFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sVGToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.undoToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.redoToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.cutToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.copyToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.pasteToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.deleteToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.connectorToolStripButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.lineConnectorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.directedLineConnectorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orthogonalConnectorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.polylineConnectorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bezierConnectorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splineConnectorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.resetToolStripButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.zoomInToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.gridToolStripButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.showGridToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.snapToGridToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.rulerToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton11 = new System.Windows.Forms.ToolStripSeparator();
            this.pageSettingsToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.previewToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.printToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.diagram1 = new Syncfusion.Windows.Forms.Diagram.Controls.Diagram(this.components);
            this.model1 = new Syncfusion.Windows.Forms.Diagram.Model(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.paletteGroupBar1 = new Syncfusion.Windows.Forms.Diagram.Controls.PaletteGroupBar(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.panToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.panel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.diagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.model1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paletteGroupBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(240)))));
            this.panel1.Controls.Add(this.toolStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1764, 74);
            this.panel1.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.Transparent;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripButton,
            this.openToolStripButton,
            this.saveToolStripButton,
            this.saveAsToolStripButton,
            this.exportToolStripButton,
            this.toolStripSeparator1,
            this.undoToolStripButton,
            this.redoToolStripButton,
            this.toolStripSeparator4,
            this.cutToolStripButton,
            this.copyToolStripButton,
            this.pasteToolStripButton,
            this.deleteToolStripButton,
            this.toolStripSeparator2,
            this.connectorToolStripButton,
            this.toolStripSeparator6,
            this.panToolStripButton,
            this.resetToolStripButton,
            this.toolStripSeparator5,
            this.gridToolStripButton,
            this.rulerToolStripButton,
            this.toolStripButton11,
            this.pageSettingsToolStripButton,
            this.previewToolStripButton,
            this.printToolStripButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1764, 74);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // newToolStripButton
            // 
            this.newToolStripButton.AutoSize = false;
            this.newToolStripButton.BackColor = System.Drawing.Color.Transparent;
            this.newToolStripButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.newToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripButton.Image")));
            this.newToolStripButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.newToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.newToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newToolStripButton.Name = "newToolStripButton";
            this.newToolStripButton.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.newToolStripButton.Size = new System.Drawing.Size(50, 50);
            this.newToolStripButton.Text = "New";
            this.newToolStripButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.newToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.newToolStripButton.Click += new System.EventHandler(this.newToolStripButton_Click);
            // 
            // openToolStripButton
            // 
            this.openToolStripButton.AutoSize = false;
            this.openToolStripButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.openToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripButton.Image")));
            this.openToolStripButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.openToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.openToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripButton.Name = "openToolStripButton";
            this.openToolStripButton.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.openToolStripButton.Size = new System.Drawing.Size(70, 50);
            this.openToolStripButton.Text = "Open";
            this.openToolStripButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.openToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.openToolStripButton.Click += new System.EventHandler(this.openToolStripButton_Click);
            // 
            // saveToolStripButton
            // 
            this.saveToolStripButton.AutoSize = false;
            this.saveToolStripButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.saveToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripButton.Image")));
            this.saveToolStripButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.saveToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.saveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripButton.Name = "saveToolStripButton";
            this.saveToolStripButton.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.saveToolStripButton.Size = new System.Drawing.Size(50, 50);
            this.saveToolStripButton.Text = "Save";
            this.saveToolStripButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.saveToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.saveToolStripButton.Click += new System.EventHandler(this.saveToolStripButton_Click);
            // 
            // saveAsToolStripButton
            // 
            this.saveAsToolStripButton.AutoSize = false;
            this.saveAsToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("saveAsToolStripButton.Image")));
            this.saveAsToolStripButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.saveAsToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.saveAsToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveAsToolStripButton.Name = "saveAsToolStripButton";
            this.saveAsToolStripButton.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.saveAsToolStripButton.Size = new System.Drawing.Size(76, 50);
            this.saveAsToolStripButton.Text = "Save As";
            this.saveAsToolStripButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.saveAsToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.saveAsToolStripButton.Click += new System.EventHandler(this.saveAsToolStripButton_Click);
            // 
            // exportToolStripButton
            // 
            this.exportToolStripButton.AutoSize = false;
            this.exportToolStripButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.exportToolStripButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pNGToolStripMenuItem,
            this.jPEGToolStripMenuItem,
            this.gIFToolStripMenuItem,
            this.sVGToolStripMenuItem});
            this.exportToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("exportToolStripButton.Image")));
            this.exportToolStripButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.exportToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.exportToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.exportToolStripButton.Name = "exportToolStripButton";
            this.exportToolStripButton.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.exportToolStripButton.ShowDropDownArrow = false;
            this.exportToolStripButton.Size = new System.Drawing.Size(60, 50);
            this.exportToolStripButton.Text = "Export";
            this.exportToolStripButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.exportToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            // 
            // pNGToolStripMenuItem
            // 
            this.pNGToolStripMenuItem.Name = "pNGToolStripMenuItem";
            this.pNGToolStripMenuItem.Size = new System.Drawing.Size(109, 24);
            this.pNGToolStripMenuItem.Text = "PNG";
            this.pNGToolStripMenuItem.Click += new System.EventHandler(this.pNGToolStripMenuItem_Click);
            // 
            // jPEGToolStripMenuItem
            // 
            this.jPEGToolStripMenuItem.Name = "jPEGToolStripMenuItem";
            this.jPEGToolStripMenuItem.Size = new System.Drawing.Size(109, 24);
            this.jPEGToolStripMenuItem.Text = "JPEG";
            this.jPEGToolStripMenuItem.Click += new System.EventHandler(this.jPEGToolStripMenuItem_Click);
            // 
            // gIFToolStripMenuItem
            // 
            this.gIFToolStripMenuItem.Name = "gIFToolStripMenuItem";
            this.gIFToolStripMenuItem.Size = new System.Drawing.Size(109, 24);
            this.gIFToolStripMenuItem.Text = "GIF";
            this.gIFToolStripMenuItem.Click += new System.EventHandler(this.gIFToolStripMenuItem_Click_1);
            // 
            // sVGToolStripMenuItem
            // 
            this.sVGToolStripMenuItem.Name = "sVGToolStripMenuItem";
            this.sVGToolStripMenuItem.Size = new System.Drawing.Size(109, 24);
            this.sVGToolStripMenuItem.Text = "SVG";
            this.sVGToolStripMenuItem.Click += new System.EventHandler(this.sVGToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 74);
            // 
            // undoToolStripButton
            // 
            this.undoToolStripButton.AutoSize = false;
            this.undoToolStripButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.undoToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("undoToolStripButton.Image")));
            this.undoToolStripButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.undoToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.undoToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.undoToolStripButton.Name = "undoToolStripButton";
            this.undoToolStripButton.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.undoToolStripButton.Size = new System.Drawing.Size(60, 50);
            this.undoToolStripButton.Text = "Undo";
            this.undoToolStripButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.undoToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.undoToolStripButton.Click += new System.EventHandler(this.undoToolStripButton_Click);
            // 
            // redoToolStripButton
            // 
            this.redoToolStripButton.AutoSize = false;
            this.redoToolStripButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.redoToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("redoToolStripButton.Image")));
            this.redoToolStripButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.redoToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.redoToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.redoToolStripButton.Name = "redoToolStripButton";
            this.redoToolStripButton.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.redoToolStripButton.Size = new System.Drawing.Size(60, 50);
            this.redoToolStripButton.Text = "Redo";
            this.redoToolStripButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.redoToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.redoToolStripButton.Click += new System.EventHandler(this.redoToolStripButton_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 74);
            // 
            // cutToolStripButton
            // 
            this.cutToolStripButton.AutoSize = false;
            this.cutToolStripButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.cutToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("cutToolStripButton.Image")));
            this.cutToolStripButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.cutToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.cutToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cutToolStripButton.Name = "cutToolStripButton";
            this.cutToolStripButton.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.cutToolStripButton.Size = new System.Drawing.Size(60, 50);
            this.cutToolStripButton.Text = "Cut";
            this.cutToolStripButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cutToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.cutToolStripButton.Click += new System.EventHandler(this.cutToolStripButton_Click);
            // 
            // copyToolStripButton
            // 
            this.copyToolStripButton.AutoSize = false;
            this.copyToolStripButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.copyToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("copyToolStripButton.Image")));
            this.copyToolStripButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.copyToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.copyToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copyToolStripButton.Name = "copyToolStripButton";
            this.copyToolStripButton.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.copyToolStripButton.Size = new System.Drawing.Size(60, 50);
            this.copyToolStripButton.Text = "Copy";
            this.copyToolStripButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.copyToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.copyToolStripButton.Click += new System.EventHandler(this.copyToolStripButton_Click);
            // 
            // pasteToolStripButton
            // 
            this.pasteToolStripButton.AutoSize = false;
            this.pasteToolStripButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pasteToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("pasteToolStripButton.Image")));
            this.pasteToolStripButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.pasteToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.pasteToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pasteToolStripButton.Name = "pasteToolStripButton";
            this.pasteToolStripButton.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.pasteToolStripButton.Size = new System.Drawing.Size(60, 50);
            this.pasteToolStripButton.Text = "Paste";
            this.pasteToolStripButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.pasteToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.pasteToolStripButton.Click += new System.EventHandler(this.pasteToolStripButton_Click);
            // 
            // deleteToolStripButton
            // 
            this.deleteToolStripButton.AutoSize = false;
            this.deleteToolStripButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.deleteToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("deleteToolStripButton.Image")));
            this.deleteToolStripButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.deleteToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.deleteToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.deleteToolStripButton.Name = "deleteToolStripButton";
            this.deleteToolStripButton.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.deleteToolStripButton.Size = new System.Drawing.Size(60, 50);
            this.deleteToolStripButton.Text = "Delete";
            this.deleteToolStripButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.deleteToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.deleteToolStripButton.Click += new System.EventHandler(this.deleteToolStripButton_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 74);
            // 
            // connectorToolStripButton
            // 
            this.connectorToolStripButton.AutoSize = false;
            this.connectorToolStripButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lineConnectorToolStripMenuItem,
            this.directedLineConnectorToolStripMenuItem,
            this.orthogonalConnectorToolStripMenuItem,
            this.polylineConnectorToolStripMenuItem,
            this.bezierConnectorToolStripMenuItem,
            this.splineConnectorToolStripMenuItem});
            this.connectorToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("connectorToolStripButton.Image")));
            this.connectorToolStripButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.connectorToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.connectorToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.connectorToolStripButton.Name = "connectorToolStripButton";
            this.connectorToolStripButton.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.connectorToolStripButton.ShowDropDownArrow = false;
            this.connectorToolStripButton.Size = new System.Drawing.Size(80, 50);
            this.connectorToolStripButton.Text = "Connectors";
            this.connectorToolStripButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.connectorToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            // 
            // lineConnectorToolStripMenuItem
            // 
            this.lineConnectorToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.lineConnectorToolStripMenuItem.Name = "lineConnectorToolStripMenuItem";
            this.lineConnectorToolStripMenuItem.Size = new System.Drawing.Size(234, 24);
            this.lineConnectorToolStripMenuItem.Text = "Line Connector";
            this.lineConnectorToolStripMenuItem.Click += new System.EventHandler(this.lineConnectorToolStripMenuItem_Click);
            // 
            // directedLineConnectorToolStripMenuItem
            // 
            this.directedLineConnectorToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.directedLineConnectorToolStripMenuItem.Name = "directedLineConnectorToolStripMenuItem";
            this.directedLineConnectorToolStripMenuItem.Size = new System.Drawing.Size(234, 24);
            this.directedLineConnectorToolStripMenuItem.Text = "DirectedLine Connector";
            this.directedLineConnectorToolStripMenuItem.Click += new System.EventHandler(this.directedLineConnectorToolStripMenuItem_Click);
            // 
            // orthogonalConnectorToolStripMenuItem
            // 
            this.orthogonalConnectorToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.orthogonalConnectorToolStripMenuItem.Name = "orthogonalConnectorToolStripMenuItem";
            this.orthogonalConnectorToolStripMenuItem.Size = new System.Drawing.Size(234, 24);
            this.orthogonalConnectorToolStripMenuItem.Text = "Orthogonal Connector";
            this.orthogonalConnectorToolStripMenuItem.Click += new System.EventHandler(this.orthogonalConnectorToolStripMenuItem_Click);
            // 
            // polylineConnectorToolStripMenuItem
            // 
            this.polylineConnectorToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.polylineConnectorToolStripMenuItem.Name = "polylineConnectorToolStripMenuItem";
            this.polylineConnectorToolStripMenuItem.Size = new System.Drawing.Size(234, 24);
            this.polylineConnectorToolStripMenuItem.Text = "Polyline Connector";
            this.polylineConnectorToolStripMenuItem.Click += new System.EventHandler(this.polylineConnectorToolStripMenuItem_Click);
            // 
            // bezierConnectorToolStripMenuItem
            // 
            this.bezierConnectorToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.bezierConnectorToolStripMenuItem.Name = "bezierConnectorToolStripMenuItem";
            this.bezierConnectorToolStripMenuItem.Size = new System.Drawing.Size(234, 24);
            this.bezierConnectorToolStripMenuItem.Text = "Bezier Connector";
            this.bezierConnectorToolStripMenuItem.Click += new System.EventHandler(this.bezierConnectorToolStripMenuItem_Click);
            // 
            // splineConnectorToolStripMenuItem
            // 
            this.splineConnectorToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.splineConnectorToolStripMenuItem.Name = "splineConnectorToolStripMenuItem";
            this.splineConnectorToolStripMenuItem.Size = new System.Drawing.Size(234, 24);
            this.splineConnectorToolStripMenuItem.Text = "Spline Connector";
            this.splineConnectorToolStripMenuItem.Click += new System.EventHandler(this.splineConnectorToolStripMenuItem_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 74);
            // 
            // resetToolStripButton
            // 
            this.resetToolStripButton.AutoSize = false;
            this.resetToolStripButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zoomInToolStripMenuItem,
            this.zoomOutToolStripMenuItem,
            this.resetToolStripMenuItem});
            this.resetToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("resetToolStripButton.Image")));
            this.resetToolStripButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.resetToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.resetToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.resetToolStripButton.Name = "resetToolStripButton";
            this.resetToolStripButton.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.resetToolStripButton.ShowDropDownArrow = false;
            this.resetToolStripButton.Size = new System.Drawing.Size(70, 50);
            this.resetToolStripButton.Text = "Zoom";
            this.resetToolStripButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.resetToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            // 
            // zoomInToolStripMenuItem
            // 
            this.zoomInToolStripMenuItem.Name = "zoomInToolStripMenuItem";
            this.zoomInToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.zoomInToolStripMenuItem.Text = "ZoomIn";
            this.zoomInToolStripMenuItem.Click += new System.EventHandler(this.zoomInToolStripMenuItem_Click);
            // 
            // zoomOutToolStripMenuItem
            // 
            this.zoomOutToolStripMenuItem.Name = "zoomOutToolStripMenuItem";
            this.zoomOutToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.zoomOutToolStripMenuItem.Text = "ZoomOut";
            this.zoomOutToolStripMenuItem.Click += new System.EventHandler(this.zoomOutToolStripMenuItem_Click);
            // 
            // resetToolStripMenuItem
            // 
            this.resetToolStripMenuItem.Name = "resetToolStripMenuItem";
            this.resetToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.resetToolStripMenuItem.Text = "Reset";
            this.resetToolStripMenuItem.Click += new System.EventHandler(this.resetToolStripMenuItem_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 74);
            // 
            // gridToolStripButton
            // 
            this.gridToolStripButton.AutoSize = false;
            this.gridToolStripButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showGridToolStripMenuItem,
            this.snapToGridToolStripMenuItem1});
            this.gridToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("gridToolStripButton.Image")));
            this.gridToolStripButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.gridToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.gridToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.gridToolStripButton.Name = "gridToolStripButton";
            this.gridToolStripButton.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.gridToolStripButton.ShowDropDownArrow = false;
            this.gridToolStripButton.Size = new System.Drawing.Size(71, 50);
            this.gridToolStripButton.Text = "Grid";
            this.gridToolStripButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.gridToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            // 
            // showGridToolStripMenuItem
            // 
            this.showGridToolStripMenuItem.CheckOnClick = true;
            this.showGridToolStripMenuItem.Name = "showGridToolStripMenuItem";
            this.showGridToolStripMenuItem.Size = new System.Drawing.Size(156, 24);
            this.showGridToolStripMenuItem.Text = "Grid";
            this.showGridToolStripMenuItem.Click += new System.EventHandler(this.showGridToolStripMenuItem_Click_1);
            // 
            // snapToGridToolStripMenuItem1
            // 
            this.snapToGridToolStripMenuItem1.Checked = true;
            this.snapToGridToolStripMenuItem1.CheckOnClick = true;
            this.snapToGridToolStripMenuItem1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.snapToGridToolStripMenuItem1.Name = "snapToGridToolStripMenuItem1";
            this.snapToGridToolStripMenuItem1.Size = new System.Drawing.Size(156, 24);
            this.snapToGridToolStripMenuItem1.Text = "SnapToGrid";
            this.snapToGridToolStripMenuItem1.Click += new System.EventHandler(this.snapToGridToolStripMenuItem1_Click);
            // 
            // rulerToolStripButton
            // 
            this.rulerToolStripButton.AutoSize = false;
            this.rulerToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("rulerToolStripButton.Image")));
            this.rulerToolStripButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.rulerToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.rulerToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.rulerToolStripButton.Name = "rulerToolStripButton";
            this.rulerToolStripButton.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.rulerToolStripButton.Size = new System.Drawing.Size(70, 50);
            this.rulerToolStripButton.Text = "Ruler";
            this.rulerToolStripButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.rulerToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.rulerToolStripButton.Click += new System.EventHandler(this.rulerToolStripButton1_Click);
            // 
            // toolStripButton11
            // 
            this.toolStripButton11.Name = "toolStripButton11";
            this.toolStripButton11.Size = new System.Drawing.Size(6, 74);
            // 
            // pageSettingsToolStripButton
            // 
            this.pageSettingsToolStripButton.AutoSize = false;
            this.pageSettingsToolStripButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pageSettingsToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("pageSettingsToolStripButton.Image")));
            this.pageSettingsToolStripButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.pageSettingsToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.pageSettingsToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pageSettingsToolStripButton.Name = "pageSettingsToolStripButton";
            this.pageSettingsToolStripButton.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.pageSettingsToolStripButton.Size = new System.Drawing.Size(70, 50);
            this.pageSettingsToolStripButton.Text = "Settings";
            this.pageSettingsToolStripButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.pageSettingsToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.pageSettingsToolStripButton.Click += new System.EventHandler(this.pageSettingsToolStripButton_Click);
            // 
            // previewToolStripButton
            // 
            this.previewToolStripButton.AutoSize = false;
            this.previewToolStripButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.previewToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("previewToolStripButton.Image")));
            this.previewToolStripButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.previewToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.previewToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.previewToolStripButton.Name = "previewToolStripButton";
            this.previewToolStripButton.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.previewToolStripButton.Size = new System.Drawing.Size(70, 50);
            this.previewToolStripButton.Text = "Preview";
            this.previewToolStripButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.previewToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.previewToolStripButton.Click += new System.EventHandler(this.previewToolStripButton_Click);
            // 
            // printToolStripButton
            // 
            this.printToolStripButton.AutoSize = false;
            this.printToolStripButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.printToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("printToolStripButton.Image")));
            this.printToolStripButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.printToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.printToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.printToolStripButton.Name = "printToolStripButton";
            this.printToolStripButton.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.printToolStripButton.Size = new System.Drawing.Size(70, 50);
            this.printToolStripButton.Text = "Print";
            this.printToolStripButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.printToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.printToolStripButton.Click += new System.EventHandler(this.printToolStripButton_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 74);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1764, 693);
            this.panel2.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.diagram1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(285, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1479, 693);
            this.panel4.TabIndex = 0;
            // 
            // diagram1
            // 
            this.diagram1.Controller.PasteOffset = new System.Drawing.SizeF(10F, 10F);
            this.diagram1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.diagram1.LayoutManager = null;
            this.diagram1.Location = new System.Drawing.Point(0, 0);
            this.diagram1.Margin = new System.Windows.Forms.Padding(4);
            this.diagram1.MetroScrollBars = true;
            this.diagram1.Model = this.model1;
            this.diagram1.Name = "diagram1";
            this.diagram1.ScrollVirtualBounds = ((System.Drawing.RectangleF)(resources.GetObject("diagram1.ScrollVirtualBounds")));
            this.diagram1.Size = new System.Drawing.Size(1479, 693);
            this.diagram1.SmartSizeBox = false;
            this.diagram1.TabIndex = 0;
            this.diagram1.Text = "diagram1";
            // 
            // 
            // 
            this.diagram1.View.ClientRectangle = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.diagram1.View.Controller = this.diagram1.Controller;
            this.diagram1.View.Grid.MinPixelSpacing = 4F;
            this.diagram1.View.Grid.Visible = false;
            this.diagram1.View.ScrollVirtualBounds = ((System.Drawing.RectangleF)(resources.GetObject("resource.ScrollVirtualBounds")));
            this.diagram1.View.ZoomType = Syncfusion.Windows.Forms.Diagram.ZoomType.Center;
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
            this.model1.LineStyle.LineWidth = 0F;
            this.model1.LogicalSize = new System.Drawing.SizeF(827F, 1169F);
            this.model1.ShadowStyle.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.model1.ShadowStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.paletteGroupBar1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(285, 693);
            this.panel3.TabIndex = 0;
            // 
            // paletteGroupBar1
            // 
            this.paletteGroupBar1.AllowDrop = true;
            this.paletteGroupBar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.paletteGroupBar1.BorderColor = System.Drawing.Color.White;
            this.paletteGroupBar1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.paletteGroupBar1.Diagram = null;
            this.paletteGroupBar1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.paletteGroupBar1.EditMode = false;
            this.paletteGroupBar1.ExpandButtonToolTip = null;
            this.paletteGroupBar1.FlatLook = true;
            this.paletteGroupBar1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paletteGroupBar1.ForeColor = System.Drawing.Color.White;
            this.paletteGroupBar1.GroupBarDropDownToolTip = null;
            this.paletteGroupBar1.GroupBarItemHeight = 32;
            this.paletteGroupBar1.IndexOnVisibleItems = true;
            this.paletteGroupBar1.Location = new System.Drawing.Point(0, 0);
            this.paletteGroupBar1.Margin = new System.Windows.Forms.Padding(4);
            this.paletteGroupBar1.MinimizeButtonToolTip = null;
            this.paletteGroupBar1.Name = "paletteGroupBar1";
            this.paletteGroupBar1.NavigationPaneTooltip = null;
            this.paletteGroupBar1.PopupClientSize = new System.Drawing.Size(0, 0);
            this.paletteGroupBar1.Size = new System.Drawing.Size(285, 693);
            this.paletteGroupBar1.TabIndex = 1;
            this.paletteGroupBar1.Text = "paletteGroupBar1";
            this.paletteGroupBar1.TextAlign = Syncfusion.Windows.Forms.Tools.TextAlignment.Left;
            this.paletteGroupBar1.VisualStyle = Syncfusion.Windows.Forms.VisualStyle.Metro;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // panToolStripButton
            // 
            this.panToolStripButton.AutoSize = false;
            this.panToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("panToolStripButton.Image")));
            this.panToolStripButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.panToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.panToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.panToolStripButton.Name = "panToolStripButton";
            this.panToolStripButton.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.panToolStripButton.Size = new System.Drawing.Size(70, 50);
            this.panToolStripButton.Text = "Pan Tool";
            this.panToolStripButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.panToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.panToolStripButton.Click += new System.EventHandler(this.panToolStripButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1764, 767);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Circuit Diagram";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.diagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.model1)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.paletteGroupBar1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton saveToolStripButton;
        private System.Windows.Forms.ToolStripButton undoToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton redoToolStripButton;
        private System.Windows.Forms.ToolStripButton cutToolStripButton;
        private System.Windows.Forms.ToolStripButton copyToolStripButton;
        private System.Windows.Forms.ToolStripButton pasteToolStripButton;
        private System.Windows.Forms.ToolStripButton deleteToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripButton11;
        private System.Windows.Forms.ToolStripButton newToolStripButton;
        private System.Windows.Forms.ToolStripButton openToolStripButton;
        private System.Windows.Forms.ToolStripButton pageSettingsToolStripButton;
        private System.Windows.Forms.ToolStripButton previewToolStripButton;
        private System.Windows.Forms.ToolStripButton printToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton saveAsToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripDropDownButton gridToolStripButton;
        private System.Windows.Forms.ToolStripMenuItem showGridToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem snapToGridToolStripMenuItem1;
        private System.Windows.Forms.ToolStripDropDownButton exportToolStripButton;
        private System.Windows.Forms.ToolStripMenuItem pNGToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jPEGToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gIFToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sVGToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripDropDownButton connectorToolStripButton;
        private System.Windows.Forms.ToolStripMenuItem lineConnectorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem directedLineConnectorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem orthogonalConnectorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem polylineConnectorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bezierConnectorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem splineConnectorToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton resetToolStripButton;
        private System.Windows.Forms.ToolStripMenuItem zoomInToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zoomOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton rulerToolStripButton;
        private System.Windows.Forms.Panel panel4;
        private Syncfusion.Windows.Forms.Diagram.Controls.Diagram diagram1;
        private Syncfusion.Windows.Forms.Diagram.Model model1;
        private System.Windows.Forms.Panel panel3;
        private Syncfusion.Windows.Forms.Diagram.Controls.PaletteGroupBar paletteGroupBar1;
        private System.Windows.Forms.ToolStripButton panToolStripButton;
    }
}


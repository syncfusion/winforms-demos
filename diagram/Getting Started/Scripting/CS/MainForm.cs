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
using System.Windows.Forms;
using System.Resources;
using System.Reflection;
using System.IO;
using Syncfusion.Scripting;
using Syncfusion.Scripting.Design;
using System.Drawing;
using System.Drawing.Drawing2D;
using Syncfusion.Windows.Forms.Tools;
using Syncfusion.Windows.Forms.Diagram.Controls;
using Syncfusion.Licensing;


namespace Syncfusion.Windows.Forms.Diagram.Samples.Scripting
{
    /// <summary>
    /// Summary description for Form1.
    /// </summary>
    public class MainForm : Form
    {
        #region Fields
        private string m_strFileName;
        private bool promptOnSave = true;
        private bool mload = true;
        #endregion

        #region Form Controls

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton openToolStripButton;
        private System.Windows.Forms.ToolStripButton runToolStripButton;
        private Tools.GroupBarItem groupBarItemTestSymbols;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
        private ResourceManager resStringMgr = null;
        private System.ComponentModel.IContainer components = null;
        private Panel panel1;
        private ToolStripButton edittToolStripButton;
        private ToolStripButton stopToolStripButton;
        private Panel panel2;
        private Syncfusion.Windows.Forms.Diagram.Controls.PaletteGroupBar paletteGroupBar1;
        private Syncfusion.Windows.Forms.Diagram.Controls.Diagram diagram1;
        private Model model1;
        private Panel panel4;
        private ScriptingManager scriptingMgr;
        #endregion

        #region Initialize\finalize methods
        public MainForm()
        {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();
            this.diagram1.Model = this.model1;

            this.StartPosition = FormStartPosition.CenterScreen;
            //
            // Create resource manager for strings
            //
            this.resStringMgr = new ResourceManager("Syncfusion.Windows.Forms.Diagram.Samples.Scripting.Strings", typeof(MainForm).Assembly);

            // Setup the Diagram control for scripting capability
            this.InitializeScriptingManager();

            //
            // Set default filename
            //
            this.FileName = "Diagram1";
        }

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
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
            this.groupBarItemTestSymbols = new Syncfusion.Windows.Forms.Tools.GroupBarItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.openToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.runToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.edittToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.stopToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.paletteGroupBar1 = new Syncfusion.Windows.Forms.Diagram.Controls.PaletteGroupBar(this.components);
            this.diagram1 = new Syncfusion.Windows.Forms.Diagram.Controls.Diagram(this.components);
            this.model1 = new Syncfusion.Windows.Forms.Diagram.Model(this.components);
            this.panel4 = new System.Windows.Forms.Panel();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paletteGroupBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.model1)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBarItemTestSymbols
            // 
            this.groupBarItemTestSymbols.Client = null;
            this.groupBarItemTestSymbols.Text = "Test Symbols";
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripButton,
            this.runToolStripButton,
            this.edittToolStripButton,
            this.stopToolStripButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(630, 77);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
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
            this.openToolStripButton.Size = new System.Drawing.Size(100, 60);
            this.openToolStripButton.Text = "Open Script";
            this.openToolStripButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.openToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.openToolStripButton.Click += new System.EventHandler(this.openToolStripButton_Click);
            // 
            // runToolStripButton
            // 
            this.runToolStripButton.AutoSize = false;
            this.runToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("runToolStripButton.Image")));
            this.runToolStripButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.runToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.runToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.runToolStripButton.Name = "runToolStripButton";
            this.runToolStripButton.Size = new System.Drawing.Size(100, 60);
            this.runToolStripButton.Text = "Run Script";
            this.runToolStripButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.runToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.runToolStripButton.Click += new System.EventHandler(this.runToolStripButton_Click);
            // 
            // edittToolStripButton
            // 
            this.edittToolStripButton.AutoSize = false;
            this.edittToolStripButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.edittToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("edittToolStripButton.Image")));
            this.edittToolStripButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.edittToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.edittToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.edittToolStripButton.Name = "edittToolStripButton";
            this.edittToolStripButton.Size = new System.Drawing.Size(100, 60);
            this.edittToolStripButton.Text = "Edit Script";
            this.edittToolStripButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.edittToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.edittToolStripButton.Click += new System.EventHandler(this.edittToolStripButton_Click);
            // 
            // stopToolStripButton
            // 
            this.stopToolStripButton.AutoSize = false;
            this.stopToolStripButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.stopToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("stopToolStripButton.Image")));
            this.stopToolStripButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.stopToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.stopToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.stopToolStripButton.Name = "stopToolStripButton";
            this.stopToolStripButton.Size = new System.Drawing.Size(100, 60);
            this.stopToolStripButton.Text = "Stop Script";
            this.stopToolStripButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.stopToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.stopToolStripButton.Click += new System.EventHandler(this.stopToolStripButton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "edp";
            this.openFileDialog1.Filter = "Essential Diagram Files|*.edd|All files|*.*";
            this.openFileDialog1.Title = "Open Diagram";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "edp";
            this.saveFileDialog1.Filter = "Essential Diagram Files|*.edd|All files|*.*";
            this.saveFileDialog1.Title = "Save Diagram";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(240)))));
            this.panel1.Controls.Add(this.toolStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(630, 77);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.paletteGroupBar1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 77);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(215, 416);
            this.panel2.TabIndex = 1;
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
            this.paletteGroupBar1.GroupBarItemHeight = (int)DpiAware.LogicalToDeviceUnits(32);
            this.paletteGroupBar1.IndexOnVisibleItems = true;
            this.paletteGroupBar1.Location = new System.Drawing.Point(0, 0);
            this.paletteGroupBar1.MinimizeButtonToolTip = null;
            this.paletteGroupBar1.Name = "paletteGroupBar1";
            this.paletteGroupBar1.NavigationPaneTooltip = null;
            this.paletteGroupBar1.PopupClientSize = new System.Drawing.Size(0, 0);
            this.paletteGroupBar1.Size = new System.Drawing.Size(215, 416);
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
            this.diagram1.Location = new System.Drawing.Point(0, 0);
            this.diagram1.Model = this.model1;
            this.diagram1.Name = "diagram1";
            this.diagram1.ScrollVirtualBounds = new System.Drawing.RectangleF(0, 0, 0, 0);
            this.diagram1.Size = new System.Drawing.Size(415, 416);
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
            this.diagram1.View.ScrollVirtualBounds = new System.Drawing.RectangleF(0, 0, 0, 0);
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
            // panel4
            // 
            this.panel4.Controls.Add(this.diagram1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(215, 77);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(415, 416);
            this.panel4.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScaleBaseSize = new System.Drawing.Size((int)DpiAware.LogicalToDeviceUnits(6), (int)DpiAware.LogicalToDeviceUnits(14));
            this.ClientSize = new System.Drawing.Size((int)DpiAware.LogicalToDeviceUnits(630), (int)DpiAware.LogicalToDeviceUnits(493));
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Scripting";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Activated += new System.EventHandler(this.MainForm_Activated);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.paletteGroupBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.model1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        #endregion
        #endregion

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            SyncfusionLicenseProvider.RegisterLicense(DemoCommon.FindLicenseKey());
            // Register scripting engines
            ScriptEngineFactory.RegisterScriptEngine(ScriptLanguages.VisualBasic, typeof(Microsoft.VisualBasic.Vsa.VsaEngine));
            ScriptEngineFactory.RegisterScriptEngine(ScriptLanguages.JScript, typeof(Microsoft.JScript.Vsa.VsaEngine));
            Application.Run(new MainForm());
        }


        #region Properties
        /// <summary>
        /// Name of the File
        /// </summary>
        private string FileName
        {
            get { return m_strFileName; }
            set
            {
                m_strFileName = value;
                string title = resStringMgr.GetString("MainFormTitle");
                string docName = Path.GetFileNameWithoutExtension(m_strFileName);

            }
        }
        #endregion

        #region Event handlers
       
        private void openToolStripButton_Click(object sender, EventArgs e)
        {
            if (this.scriptingMgr != null)
                this.scriptingMgr.ApplicationBase = new DirectoryInfo(GetAssembliesPath()).FullName;

            OpenFileDialog fileDlg = new OpenFileDialog();
            fileDlg.InitialDirectory = Application.StartupPath;


            if (fileDlg.ShowDialog(this) == DialogResult.OK)
            {
                string sourceFile = fileDlg.FileName;
                this.scriptingMgr.LoadScript(sourceFile);
            }
        }

        private void runToolStripButton_Click(object sender, EventArgs e)
        {
            if (this.scriptingMgr != null)
                this.scriptingMgr.ApplicationBase = new DirectoryInfo(GetAssembliesPath()).FullName;

            bool compiled = this.scriptingMgr.CompileScript();

            if (compiled)
            {
                this.scriptingMgr.RunScript();
            }

        }

        private void edittToolStripButton_Click(object sender, EventArgs e)
        {
            // Create the ScriptEditControl and initialize it with the diagram's ScriptingManager instance
            ScriptEditForm scripteditform = new ScriptEditForm();
            ScriptEditControl scriptedit = scripteditform.ScriptEditControl;
            scriptedit.InitializeScriptEditor(this.scriptingMgr);
            // Disable external compilation
            scriptedit.EnableExternalCompile = true;
            // Show the ScriptEditForm as a modal dialog
            scripteditform.ShowDialog(this);
            scripteditform.Dispose();
        }

        private void stopToolStripButton_Click(object sender, EventArgs e)
        {
            if (this.scriptingMgr.IsScriptRunning)
            {
                this.scriptingMgr.ResetScriptEngine();
            }
        }

        private void helpToolStripButton_Click(object sender, EventArgs e)
        {
            string targetURL = @"http://help.syncfusion.com/";
            System.Diagnostics.Process.Start(targetURL);
        }

        private void infoToolStripButton_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_Activated(object sender, EventArgs e)
        {
            if (this.mload)
            {
                this.mload = false;
                MessageBoxAdv.Office2007Theme = Office2007Theme.Blue;
                MessageBoxAdv.Show("Press the Run Button and drag and drop a Symbol from the Symbol Palette", "Essential Diagram Scripting",MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Activate();
            }
        }
        private void scriptingMgr_CompileError(object sender, VsaErrorEventArgs evtArgs)
        {
            System.Diagnostics.Trace.WriteLine("Error compiling script: " + evtArgs.Error.Description);
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            DiagramAppearance();           
            this.paletteGroupBar1.LoadPalette(@"..\..\..\..\..\..\common\Data\Diagram\xml\Test Symbol.xml");
            GroupBarAppearance();
        }
        
        #endregion

        #region private Methods
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
                    view.BackColor = Color.White;
                    view.TextWrap = true;
                    view.BorderStyle = BorderStyle.FixedSingle;
                }
            }
        }

        /// <summary>
        /// Change's the appearance of Diagram control
        /// </summary>
        private void DiagramAppearance()
        {
            diagram1.Model.LineStyle.LineWidth = 0;
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
        #endregion

        #region Helper methods
        /// <summary>
        /// Opens the diagram file
        /// </summary>
        private void OpenFile()
        {
            if (this.openFileDialog1.ShowDialog(this) == DialogResult.OK)
            {
                this.FileName = this.openFileDialog1.FileName;
                FileInfo fi = new FileInfo(this.FileName);

                if (fi.Extension == ".xml")
                    this.diagram1.LoadSoap(this.FileName);
                else if (fi.Extension == ".edd")
                    this.diagram1.LoadBinary(this.FileName);
                this.promptOnSave = false;
                this.diagram1.Refresh();
            }
        }

        /// <summary>
        /// Saves the Diagram 
        /// </summary>
        private void SaveFile()
        {
            if (this.promptOnSave)
            {
                this.saveFileDialog1.FileName = this.m_strFileName;

                if (this.saveFileDialog1.ShowDialog(this) == DialogResult.OK)
                {
                    this.FileName = this.saveFileDialog1.FileName;
                    this.diagram1.SaveSoap(this.FileName);
                }
                this.promptOnSave = false;
            }
            else
            {
                this.diagram1.SaveSoap(this.m_strFileName);
            }
        }

        /// <summary>
        /// Saves the Daigram file
        /// </summary>
        private void SaveFileAs()
        {
            this.saveFileDialog1.FileName = this.m_strFileName;

            if (this.saveFileDialog1.ShowDialog(this) == DialogResult.OK)
            {
                this.FileName = this.saveFileDialog1.FileName;
                this.diagram1.SaveSoap(this.FileName);
            }
        }

        /// <summary>
        /// Set up scripting support by creating and initializing the DiagramScriptSite and ScriptingManager
        /// </summary>
        private void InitializeScriptingManager()
        {
            this.scriptingMgr = new ScriptingManager(new DiagramScriptSite(this.diagram1), new DiagramScript());
            string exepath = Application.ExecutablePath.ToLower();
            string testscriptpath = exepath.Substring(0, exepath.IndexOf("scripting\\cs"))
                                    + "scripting\\cs\\_TESTSCRIPT\\testscript.cs";
            this.scriptingMgr.Script.Language = ScriptLanguages.CSharp;
            this.scriptingMgr.LoadScript(testscriptpath);
            this.scriptingMgr.CompileError += new VsaErrorEventHandler(this.scriptingMgr_CompileError);
        }

        /// <summary>
        /// Gets the Assembly path
        /// </summary>
        /// <returns>returns the path of the assembly</returns>
        static string GetAssembliesPath()
        {
            string assembliesfolder = GetNETVersion();
            string exepath = Application.ExecutablePath.ToLower();
            string subpath = exepath.Substring(0, exepath.IndexOf("scripting.exe"));
            string assembliespath = subpath;
            //subpath + "\\precompiledassemblies\\" + subpath.Substring(subpath.LastIndexOf('\\')+1) + "\\" + assembliesfolder;
            return assembliespath;
        }

        /// <summary>
        /// Gets the .NET Framework version
        /// </summary>
        /// <returns>returns the .NET Framework version</returns>
        static string GetNETVersion()
        {
            Assembly[] assemblies = AppDomain.CurrentDomain.GetAssemblies();
            foreach (Assembly assmbly in assemblies)
            {
                string location = assmbly.Location;
                if (location.IndexOf("mscorlib.dll") >= 0)
                {
                    if (location.IndexOf("v1.0") >= 0)
                        return "1.0";
                    else if (location.IndexOf("v1.1") >= 0)
                        return "1.1";
                    else return "2.0";
                }
            }
            return "1.1";
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

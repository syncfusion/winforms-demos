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
using Syncfusion.Windows.Forms;
using Syncfusion.Windows.Forms.Diagram;
using Syncfusion.Windows.Forms.Diagram.Controls;
using System.Drawing.Printing;
using System.Threading;
using System.Diagnostics;
using Syncfusion.Licensing;

namespace LocalizingDialogs
{
    public class Form1 : MetroForm
    {
        #region Memberrs

        private Button PageSetup;
        private Button PageBorder;
        private Panel panel2;
        private Button HeaderFooter;
        private Panel panel3;
        private Diagram diagram1;
        private Model model1;
        private System.Windows.Forms.Label lytProp;
        private System.ComponentModel.IContainer components = null;

        #endregion

        #region Form Initialize

        public Form1()
        {
            InitializeComponent();
            
            //Code to fetch the German resources at run time.
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("de-DE");

            //Load a diagram.
            diagram1.Model.RenderingStyle.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;

            SymbolPalette palette = new SymbolPalette();
#if !NETCORE
            palette = palette.FromFile(@"..\..\..\..\..\..\common\Data\Diagram\xml\Flowchart Symbols.xml");
#else
            palette = palette.FromFile(@"..\..\..\..\..\..\..\common\Data\Diagram\xml\Flowchart Symbols.xml");
#endif
            Node start = palette.Nodes["On-page reference"];
            start.PinPoint = new PointF(70, 70);
            start.Size = new SizeF(80, 80);
            ((PathNode)start).Labels.Add(new Syncfusion.Windows.Forms.Diagram.Label(start, "Start"));
            diagram1.Model.AppendChild(start);
            Node decision = palette.Nodes["Decision"];
            decision.PinPoint = new PointF(270, 70);
            decision.Size = new SizeF(100,100);
            ((PathNode)decision).Labels.Add(new Syncfusion.Windows.Forms.Diagram.Label(decision, "Decision"));
            diagram1.Model.AppendChild(decision);
            Node document = palette.Nodes["Document"];
            document.PinPoint = new PointF(470, 70);
            document.Size = new SizeF(120, 80);
            ((PathNode)document).Labels.Add(new Syncfusion.Windows.Forms.Diagram.Label(document, "Document"));
            diagram1.Model.AppendChild(document);
            Node process = palette.Nodes["Process"];
            process.PinPoint = new PointF(270, 200);
            process.Size = new SizeF(100, 80);
            ((PathNode)process).Labels.Add(new Syncfusion.Windows.Forms.Diagram.Label(process, "Process"));
            diagram1.Model.AppendChild(process);
            Node end = palette.Nodes["On-page reference"].Clone() as Node;
            end.PinPoint = new PointF(270, 320);
            end.Size = new SizeF(80, 80);
            ((PathNode)end).Labels.Clear();
            ((PathNode)end).Labels.Add(new Syncfusion.Windows.Forms.Diagram.Label(end, "End"));
            diagram1.Model.AppendChild(end);

            ConnectNodes(start, decision, false);
            ConnectNodes(decision, document, false);
            ConnectNodes(document, process, true);
            ConnectNodes(decision, process, false);
            ConnectNodes(process, end, false);

            diagram1.Model.BackgroundStyle.Color = Color.White;
            foreach (Node node in diagram1.Model.Nodes)
                node.EditStyle.AllowSelect = false;
            diagram1.View.Grid.Visible = false;
            diagram1.View.SelectionList.Clear();
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
            this.PageSetup = new System.Windows.Forms.Button();
            this.PageBorder = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.HeaderFooter = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.diagram1 = new Syncfusion.Windows.Forms.Diagram.Controls.Diagram(this.components);
            this.model1 = new Syncfusion.Windows.Forms.Diagram.Model(this.components);
            this.lytProp = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.diagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.model1)).BeginInit();
            this.SuspendLayout();
            // 
            // PageSetup
            // 
            this.PageSetup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(163)))), ((int)(((byte)(0)))));
            this.PageSetup.FlatAppearance.BorderSize = 0;
            this.PageSetup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PageSetup.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PageSetup.ForeColor = System.Drawing.Color.White;
            this.PageSetup.Location = new System.Drawing.Point(13, 143);
            this.PageSetup.Name = "PageSetup";
            this.PageSetup.Size = new System.Drawing.Size(153, 25);
            this.PageSetup.TabIndex = 36;
            this.PageSetup.Text = "PageSetup Dialog";
            this.PageSetup.UseVisualStyleBackColor = false;
            this.PageSetup.Click += new System.EventHandler(this.PageSetup_Click);
            // 
            // PageBorder
            // 
            this.PageBorder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(163)))), ((int)(((byte)(0)))));
            this.PageBorder.FlatAppearance.BorderSize = 0;
            this.PageBorder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PageBorder.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PageBorder.ForeColor = System.Drawing.Color.White;
            this.PageBorder.Location = new System.Drawing.Point(13, 97);
            this.PageBorder.Name = "PageBorder";
            this.PageBorder.Size = new System.Drawing.Size(153, 25);
            this.PageBorder.TabIndex = 35;
            this.PageBorder.Text = "PageBorder Dialog";
            this.PageBorder.UseVisualStyleBackColor = false;
            this.PageBorder.Click += new System.EventHandler(this.PageBorder_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.lytProp);
            this.panel2.Controls.Add(this.PageSetup);
            this.panel2.Controls.Add(this.PageBorder);
            this.panel2.Controls.Add(this.HeaderFooter);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(555, 0);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(10);
            this.panel2.Size = new System.Drawing.Size(200, 460);
            this.panel2.TabIndex = 4;
            // 
            // HeaderFooter
            // 
            this.HeaderFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(163)))), ((int)(((byte)(0)))));
            this.HeaderFooter.FlatAppearance.BorderSize = 0;
            this.HeaderFooter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HeaderFooter.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeaderFooter.ForeColor = System.Drawing.Color.White;
            this.HeaderFooter.Location = new System.Drawing.Point(13, 50);
            this.HeaderFooter.Name = "HeaderFooter";
            this.HeaderFooter.Size = new System.Drawing.Size(153, 25);
            this.HeaderFooter.TabIndex = 34;
            this.HeaderFooter.Text = "HeaderFooter Dialog";
            this.HeaderFooter.UseVisualStyleBackColor = false;
            this.HeaderFooter.Click += new System.EventHandler(this.HeaderFooter_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.diagram1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(555, 460);
            this.panel3.TabIndex = 8;
            // 
            // diagram1
            // 
            this.diagram1.Controller.PasteOffset = new System.Drawing.SizeF(10F, 10F);
            this.diagram1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.diagram1.HScroll = true;
            this.diagram1.LayoutManager = null;
            this.diagram1.Location = new System.Drawing.Point(0, 0);
            this.diagram1.MetroScrollBars = true;
            this.diagram1.Model = this.model1;
            this.diagram1.Name = "diagram1";
            this.diagram1.ScrollVirtualBounds = new System.Drawing.RectangleF(0, 0, 0, 0);
            this.diagram1.Size = new System.Drawing.Size(555, 460);
            this.diagram1.SmartSizeBox = false;
            this.diagram1.TabIndex = 0;
            this.diagram1.Text = "diagram1";
            // 
            // 
            // 
            this.diagram1.View.ClientRectangle = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.diagram1.View.Controller = this.diagram1.Controller;
            this.diagram1.View.Grid.MinPixelSpacing = 4F;
            this.diagram1.View.ScrollVirtualBounds = new System.Drawing.RectangleF(0, 0, 0, 0);
            this.diagram1.View.ZoomType = Syncfusion.Windows.Forms.Diagram.ZoomType.Center;
            this.diagram1.VScroll = true;
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
            // lytProp
            // 
            this.lytProp.AutoEllipsis = true;
            this.lytProp.BackColor = System.Drawing.Color.White;
            this.lytProp.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lytProp.Location = new System.Drawing.Point(13, 13);
            this.lytProp.Name = "lytProp";
            this.lytProp.Size = new System.Drawing.Size(99, 20);
            this.lytProp.TabIndex = 54;
            this.lytProp.Text = "Dialogs";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 460);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Localization Demo";
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.diagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.model1)).EndInit();
            this.ResumeLayout(false);

        }

#endregion

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

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            SyncfusionLicenseProvider.RegisterLicense(DemoCommon.FindLicenseKey());
            string targetPath = Application.StartupPath + "\\" + "de-DE";
#if !NETCORE
            string sourceFile = System.IO.Path.GetFullPath("..\\..\\..\\de-DE\\Syncfusion.Diagram.Windows.resources.dll");
#else
            string sourceFile = System.IO.Path.GetFullPath("..\\..\\..\\..\\de-DE\\Syncfusion.Diagram.Windows.resources.dll");
#endif
            if (!System.IO.Directory.Exists(targetPath))
            {
                System.IO.Directory.CreateDirectory(targetPath);
                System.IO.File.Copy(sourceFile, targetPath + "\\Syncfusion.Diagram.Windows.resources.dll");
            }
#if !NETCORE
            ProcessStartInfo pstart = new ProcessStartInfo("..\\..\\Data\\run.bat");
#else
            ProcessStartInfo pstart = new ProcessStartInfo("..\\..\\..\\Data\\run.bat");
#endif
            pstart.UseShellExecute = false;
            //Hide DOS window
            pstart.CreateNoWindow = true;
            Process.Start(pstart);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

#endregion

#region Class Events
        private void HeaderFooter_Click(object sender, EventArgs e)
        {
            HeaderFooterDialog dlgHF = new HeaderFooterDialog();
            dlgHF.Header = diagram1.Model.HeaderFooterData.Header;
            dlgHF.Footer = diagram1.Model.HeaderFooterData.Footer;
            dlgHF.MeasurementUnits = diagram1.Model.MeasurementUnits;
            if (dlgHF.ShowDialog() == DialogResult.OK)
            {
                diagram1.Model.HeaderFooterData.Header = dlgHF.Header;
                diagram1.Model.HeaderFooterData.Footer = dlgHF.Footer;
            }
        }

        private void PageBorder_Click(object sender, EventArgs e)
        {
            PageBorderDialog borderDialog = new PageBorderDialog();
            borderDialog.PageBorderStyle = diagram1.View.PageBorderStyle;
            if (borderDialog.ShowDialog() == DialogResult.OK)
            {
                diagram1.View.PageBorderStyle = borderDialog.PageBorderStyle;
                diagram1.View.RefreshPageSettings();
                diagram1.UpdateView();
            }
        }

        private void PageSetup_Click(object sender, EventArgs e)
        {
            PrintSetupDialog dlgPrintSetup = new PrintSetupDialog();

            // Made to make values more user friendly. 
            dlgPrintSetup.PageSettings = this.diagram1.View.PageSettings;
            dlgPrintSetup.PrintZoom = this.diagram1.View.PrintZoom;

            if (dlgPrintSetup.ShowDialog() == DialogResult.OK)
            {
                this.diagram1.View.PageSettings = dlgPrintSetup.PageSettings;
                this.diagram1.View.PrintZoom = dlgPrintSetup.PrintZoom;
                this.diagram1.View.RefreshPageSettings();
            }
        }

       
#endregion
#region private methods
        /// <summary>
        /// Connects the nodes
        /// </summary>
        /// <param name="parent">Tail node</param>
        /// <param name="child">Head node</param>
        private void ConnectNodes(Node parent, Node child, bool useOrthogonal)
        {
            ConnectorBase conn;
            if (!useOrthogonal)
                conn = new LineConnector(PointF.Empty, new PointF(0, 1));
            else
                conn = new OrthogonalConnector(parent.PinPoint, child.PinPoint, false);

            conn.HeadDecorator.DecoratorShape = DecoratorShape.Filled45Arrow;
            conn.HeadDecorator.FillStyle.Color = Color.Black;
            diagram1.Model.AppendChild(conn);
            parent.CentralPort.Connect(conn.TailEndPoint);
            child.CentralPort.Connect(conn.HeadEndPoint);
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
#region Copyright Syncfusion Inc. 2001 - 2015
//
//  Copyright Syncfusion Inc. 2001 - 2015. All rights reserved.
//
//  Use of this code is subject to the terms of our license.
//  A copy of the current license can be obtained at any time by e-mailing
//  licensing@syncfusion.com. Any infringement will be prosecuted under
//  applicable laws. 
//
#endregion

namespace OleDragDrop
{
    using System;
    using System.Drawing;
    using System.Collections;
    using System.ComponentModel;
    using System.Windows.Forms;
    using System.Data;

    using Syncfusion.Windows.Forms.Grid;
    using Syncfusion.Drawing;
    using Syncfusion.Windows.Forms;
    using DemoCommon.Grid;

    /// <summary>
    /// Summary description for Form1.
    /// </summary>
    public class Form1 : GridDemoForm
    {
        #region "API Definition"

        private Syncfusion.Windows.Forms.Grid.GridControl gridControl1;
        private Syncfusion.Windows.Forms.Grid.GridControl gridControl2;
        private DNDRichTextBox richTextBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel richTextPanel;
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.Container components = null;

        #endregion

        #region Constructor

        public Form1()
        {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();
            if (DpiAware.GetCurrentDpi() > 96)
            {
                this.CaptionBarHeight = (int)DpiAware.LogicalToDeviceUnits(this.CaptionBarHeight);
            }
            this.PopulateRichText();
            this.GridSettings();
            this.SampleCustomization();
        }

        #endregion

        #region "Sample Grid Settings"

        /// <summary>
        /// Setting GridGrouping control Properties
        /// </summary>
        private void GridSettings()
        {
            #region Buffer Text
            gridControl1.Model.TextDataExchange.PasteTextFromBuffer(
                "1\tDavolio	Nancy\r\n" +
                "2\tFuller	Andrew\r\n" +
                "3\tLeverling	Janet\r\n" +
                "4\tPeacock	Margaret\r\n" +
                "5\tBuchanan	Steven\r\n" +
                "6\tSuyama	Michael\r\n" +
                "7\tKing	Robert\r\n" +
                "8\tCallahan	Laura\r\n" +
                "9\tDodsworth	Anne\r\n",
                GridRangeInfo.Cell(1, 1), int.MaxValue);

            #endregion

            #region GridStyleInfo
            GridStyleInfo style;

            style = new GridStyleInfo();
            style.Interior = new BrushInfo(Color.FromArgb(0xED, 0xF0, 0xF7));
            style.TextColor = Color.FromArgb(238, 122, 3); //Color.Orange;
            gridControl1.ChangeCells(GridRangeInfo.Cells(1, 1, 9, 3), style);

            style = new GridStyleInfo();
            style.HorizontalAlignment = GridHorizontalAlignment.Right;
            style.CellValueType = typeof(int);
            style.Format = "000";
            gridControl1.ChangeCells(GridRangeInfo.Cells(1, 1, 9, 1), style);
            #endregion

            gridControl1.ColWidths.ResizeToFit(GridRangeInfo.Cells(1, 1, 9, 3));

            gridControl1.CommandStack.Enabled = true;
            gridControl2.CommandStack.Enabled = true;

            gridControl1.AllowDrop = true;
            gridControl2.AllowDrop = true;

            gridControl1.ShowMessageBoxOnDrop = false;
            gridControl2.ShowMessageBoxOnDrop = false;
            //
            // TODO: Add any constructor code after InitializeComponent call
            //			
            richTextBox1.Text = "Drag content using OLE Drag-and-Drop between grids, any other application or use Copy Paste \r\n" +
                "Sample Data:\r\n" +
                "1	Davolio	    Nancy\r\n" +
                "2	Fuller	    Andrew\r\n" +
                "3	Leverling      Janet\r\n" +
                "4	Peacock	    Margaret\r\n" +
                "5	Buchanan    Steven\r\n" +
                "6	Suyama	    Michael\r\n" +
                "7	King	    Robert\r\n" +
                "8	Callahan    Laura\r\n" +
                "9	Dodsworth   Anne\r\n";

            this.gridControl1.DefaultRowHeight = (int)DpiAware.LogicalToDeviceUnits(22.0f);
            this.gridControl1.DefaultColWidth = (int)DpiAware.LogicalToDeviceUnits(70.0f);
            this.gridControl1.GridVisualStyles = GridVisualStyles.Metro;
            this.gridControl1.DefaultGridBorderStyle = GridBorderStyle.Solid;
            this.gridControl1.Properties.GridLineColor = Color.FromArgb(208, 215, 229);
            style = gridControl1.BaseStylesMap["Header"].StyleInfo;
            style.Font.Facename = "Segoe UI";

            
            this.gridControl2.GridVisualStyles = GridVisualStyles.Metro;
			this.gridControl2.DefaultRowHeight = (int)DpiAware.LogicalToDeviceUnits(22.0f);
            this.gridControl2.DefaultColWidth = (int)DpiAware.LogicalToDeviceUnits(70.0f);
            this.gridControl2.DefaultGridBorderStyle = GridBorderStyle.Solid;
            this.gridControl2.Properties.GridLineColor = Color.FromArgb(208, 215, 229);
            style = gridControl2.BaseStylesMap["Header"].StyleInfo;
            style.Font.Facename = "Segoe UI";
            this.BackColor = Color.White;// FromArgb(223, 227, 239);
            this.StartPosition = FormStartPosition.CenterScreen;

            //tab key navigation set as false to move the next control
            this.gridControl1.WantTabKey = false;
            this.gridControl2.WantTabKey = false;
        }

        #endregion

        #region "Sample Customizations"

        /// <summary>
        /// Grouping sample Customizations 
        /// </summary>
        private void SampleCustomization()
        {
            this.gridControl1.DragOver += new DragEventHandler(gridControl1_DragOver);
            this.gridControl2.DragOver += new DragEventHandler(gridControl2_DragOver);
        }

        #region Event handlers

        /// <summary>
        /// Set the Effects for dragover grid1
        /// </summary>
        private void gridControl1_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        /// <summary>
        /// Set the Effects for dragover grid2
        /// </summary>
        private void gridControl2_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        #endregion

        #endregion
        
        #region "Populate Rich TextBox"
        /// <summary>
        /// Add the customized richtext box.
        /// </summary>
        private void PopulateRichText()
        {
            this.richTextPanel = new Panel();
            this.richTextBox1 = new OleDragDrop.DNDRichTextBox();
            // 
            // richTextBox1
            // 
            this.richTextBox1.AcceptsTab = true;
            this.richTextBox1.AllowDrop = true;
            this.richTextBox1.AutoWordSelection = true;
            this.richTextBox1.BackColor = System.Drawing.Color.White;
            this.richTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ShowSelectionMargin = true;
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            this.richTextBox1.Dock = DockStyle.Fill;
            this.richTextBox1.TabStop = false;
            //richTextPanel1
            //this.richTextPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
            //            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextPanel.Dock = DockStyle.Bottom;
#if NETCORE
            this.richTextPanel.Location = new System.Drawing.Point(22, 372);
            this.richTextPanel.Size = new System.Drawing.Size(731, 400);
#else
            this.richTextPanel.Location = new System.Drawing.Point(22,10);
            this.richTextPanel.Size = new System.Drawing.Size(621, 400);
#endif
            this.richTextPanel.BorderStyle = BorderStyle.FixedSingle;
            this.richTextBox1.BorderStyle = BorderStyle.None;
            this.richTextPanel.Controls.Add(this.richTextBox1);
            this.Controls.Add(richTextPanel);
            //this.panel1.Controls.Add(this.richTextPanel);
        }

        #endregion

        #region "Designer Stuffs"

        #region Dispose
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
        #endregion

        #region Windows Form Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gridControl1 = new Syncfusion.Windows.Forms.Grid.GridControl();
            this.gridControl2 = new Syncfusion.Windows.Forms.Grid.GridControl();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DpiAware = true;
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gridControl1.ColCount = 55;
            this.gridControl1.ColWidthEntries.AddRange(new Syncfusion.Windows.Forms.Grid.GridColWidth[] {
            new Syncfusion.Windows.Forms.Grid.GridColWidth(0, 35)});
            this.gridControl1.HorizontalThumbTrack = true;
            this.gridControl1.Location = new System.Drawing.Point(22, 12);
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RowCount = 100;
            this.gridControl1.RowHeightEntries.AddRange(new Syncfusion.Windows.Forms.Grid.GridRowHeight[] {
            new Syncfusion.Windows.Forms.Grid.GridRowHeight(0, 25)});
            this.gridControl1.Size = new System.Drawing.Size(307, 400);
            this.gridControl1.SmartSizeBox = false;
            this.gridControl1.TabIndex = 0;
            this.gridControl1.Text = "gridControl1";
            this.gridControl1.ThemesEnabled = true;
            this.gridControl1.VerticalThumbTrack = true;
            // 
            // gridControl2
            // 
            this.gridControl2.DpiAware = true;
            this.gridControl2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gridControl2.ColCount = 55;
            this.gridControl2.ColWidthEntries.AddRange(new Syncfusion.Windows.Forms.Grid.GridColWidth[] {
            new Syncfusion.Windows.Forms.Grid.GridColWidth(0, 35)});
            this.gridControl2.HorizontalThumbTrack = true;
            this.gridControl2.Location = new System.Drawing.Point(336, 12);
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.RowCount = 100;
            this.gridControl2.RowHeightEntries.AddRange(new Syncfusion.Windows.Forms.Grid.GridRowHeight[] {
            new Syncfusion.Windows.Forms.Grid.GridRowHeight(0, 25)});
            this.gridControl2.Size = new System.Drawing.Size(307, 400);
            this.gridControl2.SmartSizeBox = false;
            this.gridControl2.TabIndex = 1;
            this.gridControl2.Text = "gridControl1";
            this.gridControl2.ThemesEnabled = true;
            this.gridControl2.VerticalThumbTrack = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.gridControl2);
            this.panel1.Controls.Add(this.gridControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(663, 473);
            this.panel1.TabIndex = 2;
           
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 473);
            this.Controls.Add(this.panel1);
            //this.Controls.Add(richTextPanel);
            this.DropShadow = true;
            this.MinimumSize = new System.Drawing.Size(560, 440);
            this.Name = "Form1";
            this.Text = "OLE Drag-and-Drop";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        #endregion

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense(Syncfusion.Licensing.DemoCommon.FindLicenseKey());
# if SyncfusionFramework1_1 || SyncfusionFramework2_0
            Application.EnableVisualStyles();
# endif
            Application.Run(new Form1());
        }
        #endregion

    }

    #region DNDRichTextBox
    /// <summary>
    /// Inherits the RichTextBox to do customization
    /// </summary>
    public class DNDRichTextBox : RichTextBox
    {

        public DNDRichTextBox()
        {
            this.AllowDrop = true;
            this.DragEnter += new System.Windows.Forms.DragEventHandler(Handle_DragEnter);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(Handle_DragDrop);
            this.MouseDown += new MouseEventHandler(DNDRichTextBox_MouseDown);
        }

        #region RichTextBox Events

        private void Handle_DragEnter(object sender, System.Windows.Forms.DragEventArgs e)
        {
            if (((DragEventArgs)e).Data.GetDataPresent(DataFormats.Text))
                ((DragEventArgs)e).Effect = DragDropEffects.Move | DragDropEffects.Copy;
            else
                ((DragEventArgs)e).Effect = DragDropEffects.None;
        }
        private void Handle_DragDrop(object sender, DragEventArgs e)
        {
            // Get start position to drop the text.
            int i = this.SelectionStart;
            string s = this.Text.Substring(i);
            this.Text = this.Text.Substring(0, i);

            // Drop the text on to the RichTextBox.
            this.Text = this.Text + e.Data.GetData(DataFormats.Text).ToString() + s;

            // Loads the file into the control. 
            //LoadFile((String)e.Data.GetData("Text"), System.Windows.Forms.RichTextBoxStreamType.RichText); 
        }

        private void DNDRichTextBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (this.SelectionLength > 0)
                DoDragDrop(this.SelectedText, DragDropEffects.Copy);
        }

        #endregion
    }
    #endregion
}

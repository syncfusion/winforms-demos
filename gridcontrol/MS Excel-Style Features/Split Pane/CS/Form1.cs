#region Copyright Syncfusion Inc. 2001 - 2018
//
//  Copyright Syncfusion Inc. 2001 - 2018. All rights reserved.
//
//  Use of this code is subject to the terms of our license.
//  A copy of the current license can be obtained at any time by e-mailing
//  licensing@syncfusion.com. Any infringement will be prosecuted under
//  applicable laws. 
//
#endregion

namespace SplitterPane
{
    using System;
    using System.Windows.Forms;
    using System.Data;
    using Syncfusion.Windows.Forms.Grid;
    using Syncfusion.Windows.Forms;
    using DemoCommon.Grid;
    using System.IO;

    /// <summary>
    /// Summary description for Form1.
    /// </summary>
    public class Form1 : GridDemoForm
    {
        private SplitterControl splitterControl1;
        private GridControl gridControl1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        #region API Definition
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
            this.GridSettings();
            //
            // TODO: Add any constructor code after InitializeComponent call
            //
        }
        #endregion

        #region "Sample Grid Settings"

        /// <summary>
        /// Setting Grid control Properties
        /// </summary>
        private void GridSettings()
        {
            DataSet ds = new DataSet();
            ReadXml(ds, @"..\..\..\..\..\..\Common\Data\HVData.xml");
            int rowCount = gridControl1.RowCount = ds.Tables[1].Rows.Count;
            int colCount = gridControl1.ColCount = ds.Tables[1].Columns.Count;
            this.gridControl1.PopulateHeaders(GridRangeInfo.Cells(0, 1, 0, colCount), ds.Tables[1]);
            this.gridControl1.PopulateValues(GridRangeInfo.Cells(1, 1, rowCount - 1, colCount), ds.Tables[1]);
            this.gridControl1.RowHeights.ResizeToFit(GridRangeInfo.Rows(1, rowCount - 1));
            this.gridControl1.ColWidths.ResizeToFit(GridRangeInfo.Rows(0, colCount - 1));
            this.gridControl1.ColStyles[4].Format = "dd/MM/yyyy";
            this.gridControl1.ColStyles[5].Format = "dd/MM/yyyy";
            this.gridControl1.ColStyles[6].Format = "dd/MM/yyyy";
        }

        void ReadXml(DataSet ds, string xmlFileName)
        {
            for (int n = 0; n < 10; n++)
            {
                if (File.Exists(xmlFileName))
                {
                    ds.ReadXml(xmlFileName);
                    break;
                }
                xmlFileName = @"..\" + xmlFileName;
            }
        }

        #endregion

        #region "Designer Stuffs"
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
            this.splitterControl1 = new Syncfusion.Windows.Forms.SplitterControl();
            this.gridControl1 = new Syncfusion.Windows.Forms.Grid.GridControl();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitterControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitterControl1
            // 
            this.splitterControl1.Dock = DockStyle.Fill;
            this.splitterControl1.BeforeTouchSize = new System.Drawing.Size(699, 404);
            this.splitterControl1.Controls.Add(this.gridControl1);
            this.splitterControl1.Location = new System.Drawing.Point(13, 13);
            this.splitterControl1.Name = "splitterControl1";
            this.splitterControl1.Size = new System.Drawing.Size(699, 404);
            this.splitterControl1.TabIndex = 0;
            this.splitterControl1.Text = "splitterControl1";
            this.splitterControl1.ShowToolTips = true;
            this.splitterControl1.HSplitPos = 50;
            this.splitterControl1.VSplitPos = 50;
            this.splitterControl1.Style = Syncfusion.Windows.Forms.Appearance.Metro;
            this.splitterControl1.SplitBars = DynamicSplitBars.Both;
            // 
            // gridControl1
            // 
            this.gridControl1.DpiAware = true;
            this.gridControl1.Location = new System.Drawing.Point(12, 12);
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(699, 433);
            this.gridControl1.SmartSizeBox = false;
            this.gridControl1.Text = "gridControl1";
            this.gridControl1.UseRightToLeftCompatibleTextBox = true;
            //
            // panel1
            //
            this.panel1.Dock = DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(725, 21);
            this.panel1.Size = new System.Drawing.Size(300, 200);
            this.panel1.Controls.Add(this.groupBox1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.comboBox3);
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(15, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(210, 160);
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Settings";
            this.groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left  ;
            this.groupBox1.AutoSize = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Splitter Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Scrollbar Style";
            // 
            //label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Show Scrollbar";

            System.Drawing.Size textSize = TextRenderer.MeasureText("Office2010", this.comboBox3.Font);

            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "None", "Column", "Row", "Both"});
            this.comboBox1.Location = new System.Drawing.Point(label1.Location.X + label1.Size.Width + 5, 110);
            this.comboBox1.SelectedItem = "Both";
            this.comboBox1.Name = "SplitterBar Behavior";
            this.comboBox1.Size = new System.Drawing.Size(textSize.Width + 30, textSize.Height);
            this.comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            this.comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // comboBox3
            // 
            this.comboBox3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "None","Metro","Office2007", "Office2010"});
            this.comboBox3.Location = new System.Drawing.Point(label1.Location.X + label1.Size.Width + 5, 70);
            this.comboBox3.SelectedItem = "Metro";
            this.comboBox3.Name = "Scrollbar Styles";
            this.comboBox3.Size = new System.Drawing.Size(textSize.Width + 30, textSize.Height);
            this.comboBox3.DropDownStyle = ComboBoxStyle.DropDownList;
            this.comboBox3.BackColor = System.Drawing.Color.White;
            this.comboBox3.SelectedIndexChanged += comboBox3_SelectedIndexChanged;
            // 
            // comboBox2
            // 
            this.comboBox2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "None","Horizontal","Vertical","Both"});
            this.comboBox2.Location = new System.Drawing.Point(label1.Location.X + label1.Size.Width + 5, 30);
            this.comboBox2.SelectedItem = "Both";
            this.comboBox2.Name = "Enablescrollbar";
            this.comboBox2.Size = new System.Drawing.Size(textSize.Width + 30, textSize.Height);
            this.comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            this.comboBox2.SelectedIndexChanged += ComboBox2_SelectedIndexChanged;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 420);
            this.splitterControl1.Controls.Add(gridControl1);
            this.Controls.Add(this.splitterControl1);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(500, 300);
            this.Name = "Form1";
            this.Text = "Split Pane";
            this.splitterControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #region ButtonEvents
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            var temp = comboBox.SelectedItem.ToString();
            this.splitterControl1.SplitterLayout.HSplitPos = 50;
            this.splitterControl1.SplitterLayout.VSplitPos = 50;
            if (temp == "None")
                this.splitterControl1.SplitBars = DynamicSplitBars.None;
            else if (temp == "Column")
                this.splitterControl1.SplitBars = DynamicSplitBars.SplitColumns;
            else if (temp == "Row")
                this.splitterControl1.SplitBars = DynamicSplitBars.SplitRows;
            else
                this.splitterControl1.SplitBars = DynamicSplitBars.Both;
        }
        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            var temp = comboBox.SelectedItem.ToString();
            if (temp == "Metro")
                this.splitterControl1.GridOfficeScrollBars = OfficeScrollBars.Metro;
            else if(temp == "None")
                this.splitterControl1.GridOfficeScrollBars = OfficeScrollBars.None;
            else if (temp == "Office2007")
                this.splitterControl1.GridOfficeScrollBars = OfficeScrollBars.Office2007;
            else
                this.splitterControl1.GridOfficeScrollBars = OfficeScrollBars.Office2010;
        }
        private void ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            var temp = comboBox.SelectedItem.ToString();
            if (temp == "Vertical")
            {
                this.splitterControl1.ShowVerticalScrollBar = true;
                this.splitterControl1.ShowHorizontalScrollBar = false;
            }
            else if (temp == "Horizontal")
            {
                this.splitterControl1.ShowHorizontalScrollBar = true;
                this.splitterControl1.ShowVerticalScrollBar = false;
            }
            else if (temp == "None")
            {
                this.splitterControl1.ShowHorizontalScrollBar = false;
                this.splitterControl1.ShowVerticalScrollBar = false;
            }
            else
            {
                this.splitterControl1.ShowVerticalScrollBar = true;
                this.splitterControl1.ShowHorizontalScrollBar = true;
            }
        }

        #endregion

        #endregion

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense(Syncfusion.Licensing.DemoCommon.FindLicenseKey());
#if SyncfusionFramework1_1 || SyncfusionFramework2_0
            Application.EnableVisualStyles();
#endif
            Application.Run(new Form1());
        }
        #endregion
    }
}

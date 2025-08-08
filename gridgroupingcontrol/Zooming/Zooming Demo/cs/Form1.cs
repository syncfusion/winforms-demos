#region Copyright Syncfusion Inc. 2001 - 2015
// Copyright Syncfusion Inc. 2001 - 2015. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion

using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using Syncfusion.Windows.Forms.Grid;
using Syncfusion.Drawing;
using Syncfusion.Styles;
using Syncfusion.Windows.Forms.Grid.Grouping;
using Syncfusion.Grouping;
using Syncfusion.GridHelperClasses.Zoom;
using Syncfusion.Windows.Forms;
using DemoCommon.Grid;
using Syncfusion.Windows.Forms.Tools;

namespace ZoomGrid
{
    /// <summary>
    /// Summary description for Form1.
    /// </summary>
    public class Form1 : GridDemoForm
    {
        #region "API Definition"

        private TrackBar trackBar1;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv comboBox1;
        private Syncfusion.Windows.Forms.Tools.CheckBoxAdv checkBox1;
        private Syncfusion.Windows.Forms.Grid.Grouping.GridGroupingControl gridGroupingControl1;
        private GroupBox groupBox1;
        private GroupBox groupBox3;
        private GroupBox groupBox2;
        private Label label4;
        private Label label3;
        private IContainer components;
        private Panel panel2;
        private ToolTip tipDesc;
        ZoomGroupingGrid zoom;
        private int numberParentRows = 30;
        private int numberChildRows = 150;
        private TrackBar trackBar2;
        private Label zoomSize;
        private Label zoomDisplaySize;
        private IntegerTextBox borderThickness;
        private Label label1;
        private ColorPickerButton colorPickerButton1;
        private DoubleTextBox zoomFactorText;
        private Label label2;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private int numberGrandChildRows = 250;

        #endregion

        #region "Constructor"

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
        }

        #endregion

        #region "Sample Grid Settings"

        /// <summary>
        /// GridGrouping control getting started customization.
        /// </summary>
        private void GridSettings()
        {
            #region Setting DataSource for GGC

            DataTable parentTable = GetTable();
            DataTable childTable = GetChildTable();
            DataTable grandChildTable = GetGrandChildTable();

            GridRelationDescriptor parentToChildRelationDescriptor = new GridRelationDescriptor();
            parentToChildRelationDescriptor.ChildTableName = "MyChildTable";
            parentToChildRelationDescriptor.RelationKind = RelationKind.RelatedMasterDetails;
            parentToChildRelationDescriptor.RelationKeys.Add("parentID", "ParentID");

            gridGroupingControl1.TableDescriptor.Relations.Add(parentToChildRelationDescriptor);

            GridRelationDescriptor childToGrandChildRelationDescriptor = new GridRelationDescriptor();
            childToGrandChildRelationDescriptor.ChildTableName = "MyGrandChildTable";
            childToGrandChildRelationDescriptor.RelationKind = RelationKind.RelatedMasterDetails;
            childToGrandChildRelationDescriptor.RelationKeys.Add("child ID", "Child ID");

            parentToChildRelationDescriptor.ChildTableDescriptor.Relations.Add(childToGrandChildRelationDescriptor);

            this.gridGroupingControl1.Engine.SourceListSet.Add("MyParentTable", parentTable);
            this.gridGroupingControl1.Engine.SourceListSet.Add("MyChildTable", childTable);
            this.gridGroupingControl1.Engine.SourceListSet.Add("MyGrandChildTable", grandChildTable);
            this.gridGroupingControl1.DataSource = GetTable();
            this.gridGroupingControl1.ShowCurrentCellBorderBehavior = GridShowCurrentCellBorder.HideAlways;

            #endregion

            #region Setting GridProperties

            this.gridGroupingControl1.TableControl.DpiAware = true;
			this.gridGroupingControl1.TopLevelGroupOptions.ShowAddNewRecordAfterDetails = false;
            this.gridGroupingControl1.TopLevelGroupOptions.ShowAddNewRecordBeforeDetails = false;
            this.gridGroupingControl1.ChildGroupOptions.ShowAddNewRecordAfterDetails = false;
            this.gridGroupingControl1.ChildGroupOptions.ShowAddNewRecordBeforeDetails = false;
            this.gridGroupingControl1.NestedTableGroupOptions.ShowAddNewRecordAfterDetails = false;
            this.gridGroupingControl1.NestedTableGroupOptions.ShowAddNewRecordBeforeDetails = false;
            this.gridGroupingControl1.Table.DefaultCaptionRowHeight = this.gridGroupingControl1.TableOptions.RecordRowHeight = (int)DpiAware.LogicalToDeviceUnits(25.0f);
            this.gridGroupingControl1.Table.DefaultColumnHeaderRowHeight = this.gridGroupingControl1.TableOptions.ColumnHeaderRowHeight = (int)DpiAware.LogicalToDeviceUnits(25.0f);

            this.SetStyle(ControlStyles.UserPaint, true);
            this.gridGroupingControl1.ThemesEnabled = true;
            this.gridGroupingControl1.GridVisualStyles = GridVisualStyles.Metro;
            this.gridGroupingControl1.GridOfficeScrollBars = OfficeScrollBars.Metro;

            // Header Text name cahnge
            this.gridGroupingControl1.TableDescriptor.Columns["parentID"].HeaderText = "Parent ID";
            this.gridGroupingControl1.TableDescriptor.Columns["ParentRel"].HeaderText = "Parent Relation";
            this.gridGroupingControl1.GetTableDescriptor("MyChildTable").Columns["child ID"].HeaderText = "Child ID";

            //Navigate to other control using tabkey navigation
            this.gridGroupingControl1.WantTabKey = false;

            #region Zooming


            // Initialize the Zooming to GridGroupingControl            
            zoom = new ZoomGroupingGrid(this.gridGroupingControl1);
            ZoomGroupingGrid.zoomCell = true;
            //used to set multiextended selection mode in gridgrouping control. 
            this.gridGroupingControl1.TableOptions.ListBoxSelectionMode = SelectionMode.None;
            //used to set GridCaptionRowHeight.
            zoom.ZoomBorderColor = this.colorPickerButton1.SelectedColor = SystemColors.ActiveBorder;
            zoom.ZoomSize = new Size(150, 150);
            zoom.ZoomBorderSize = 15;
            zoom.ZoomFactor = 1.5f;
            zoom.ZoomImageMode = ZoomGroupingGrid.ImageMode.Ellipse;
            this.gridGroupingControl1.TableControlQueryAllowSortColumn += new GridQueryAllowSortColumnEventHandler(gridGroupingControl1_TableControlQueryAllowSortColumn);
            #endregion
        }

        void gridGroupingControl1_TableControlQueryAllowSortColumn(object sender, GridQueryAllowSortColumnEventArgs e)
        {
            e.AllowSort = false;
        }

        #endregion
        #endregion

        #region "Sample Customization"


        #region "Zooming Handlers"

        /// <summary>
        /// Zooming the cell Handled on this checkbox
        /// </summary>
        void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            ZoomGroupingGrid.zoomCell = this.checkBox1.Checked;
            this.zoomSize.Visible = this.checkBox1.Checked;
            this.trackBar2.Visible = this.checkBox1.Checked;
            this.label2.Visible = this.checkBox1.Checked;
            this.zoomFactorText.Visible = this.checkBox1.Checked;
            this.label1.Visible = this.checkBox1.Checked;
            this.borderThickness.Visible = this.checkBox1.Checked;
            this.colorPickerButton1.Visible = this.checkBox1.Checked;
            this.zoomDisplaySize.Visible = this.checkBox1.Checked;
        }

        /// <summary>
        ///  Set zooming size for Grid
        /// </summary>
        void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (zoom != null)
            {
                if (this.comboBox1.SelectedItem == null) return;
                zoom.zoomGrid(this.comboBox1.SelectedItem.ToString());
                this.trackBar1.Value = Convert.ToInt16(this.comboBox1.SelectedItem);
            }
        }

        /// <summary>
        /// Set zooming Frequency for Grid
        /// </summary>
        void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            if (zoom != null)
            {
                zoom.zoomGrid(this.trackBar1.Value.ToString());
                this.comboBox1.Text = this.trackBar1.Value.ToString();
            }
        }

        /// <summary>
        /// Set zooming size for Grid
        /// </summary>
        void trackBar2_ValueChanged(object sender, EventArgs e)
        {
            if (zoom != null)
            {
                zoom.ZoomSize = new Size(this.trackBar2.Value, this.trackBar2.Value);
                this.zoomDisplaySize.Text = "( " + trackBar2.Value + " , " + trackBar2.Value + " )";
            }
        }

        void borderThickness_TextChanged(object sender, EventArgs e)
        {
            int text;
            if (int.TryParse(borderThickness.Text, out text))
            {
                zoom.ZoomBorderSize = text;
            }
        }


        void colorPickerButton1_ColorSelected(object sender, EventArgs e)
        {
            zoom.ZoomBorderColor = colorPickerButton1.SelectedColor;
            this.gridGroupingControl1.Refresh();
        }


        void zoomFactorText_TextChanged(object sender, EventArgs e)
        {
            float factor;
            if (float.TryParse(zoomFactorText.Text, out factor))
            {
                zoom.ZoomFactor = factor;
            }
        }


        private void mode_Changed(object sender, EventArgs e)
        {
            if ((sender as RadioButton).Text == "Rectangle Mode")
            {
                zoom.ZoomImageMode = ZoomGroupingGrid.ImageMode.Rectangle;
            }
            else
            {
                zoom.ZoomImageMode = ZoomGroupingGrid.ImageMode.Ellipse;
            }
        }
        #endregion

        #endregion

        #region "Designer Stuff"

        #region "Form Settings"

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

        #region "Windows Form Designer generated code"

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.comboBox1 = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.checkBox1 = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.gridGroupingControl1 = new Syncfusion.Windows.Forms.Grid.Grouping.GridGroupingControl();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.zoomFactorText = new DoubleTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.colorPickerButton1 = new Syncfusion.Windows.Forms.ColorPickerButton();
            this.borderThickness = new Syncfusion.Windows.Forms.Tools.IntegerTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.zoomDisplaySize = new System.Windows.Forms.Label();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.zoomSize = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tipDesc = new System.Windows.Forms.ToolTip(this.components);
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridGroupingControl1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.zoomFactorText)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.borderThickness)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // trackBar1
            // 
            this.trackBar1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBar1.AutoSize = false;
            this.trackBar1.BackColor = System.Drawing.Color.White;
            this.trackBar1.Location = new System.Drawing.Point(22, 112);
            this.trackBar1.Maximum = 400;
            this.trackBar1.Minimum = 50;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.trackBar1.Size = new System.Drawing.Size(195, 28);
            this.trackBar1.TabIndex = 2;
            this.trackBar1.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar1.Value = 100;
            this.trackBar1.ValueChanged += new System.EventHandler(this.trackBar1_ValueChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.White;
            this.comboBox1.BeforeTouchSize = new System.Drawing.Size(104, 21);
            this.comboBox1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.Items.AddRange(new object[] {
            "50",
            "75",
            "100",
            "150",
            "200",
            "300",
            "400"});
            this.comboBox1.ItemsImageIndexes.Add(new Syncfusion.Windows.Forms.Tools.ComboBoxAdv.ImageIndexItem(this.comboBox1, "50"));
            this.comboBox1.ItemsImageIndexes.Add(new Syncfusion.Windows.Forms.Tools.ComboBoxAdv.ImageIndexItem(this.comboBox1, "75"));
            this.comboBox1.ItemsImageIndexes.Add(new Syncfusion.Windows.Forms.Tools.ComboBoxAdv.ImageIndexItem(this.comboBox1, "100"));
            this.comboBox1.ItemsImageIndexes.Add(new Syncfusion.Windows.Forms.Tools.ComboBoxAdv.ImageIndexItem(this.comboBox1, "125"));
            this.comboBox1.Location = new System.Drawing.Point(113, 40);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(104, 21);
            this.comboBox1.SelectedValue = "100";
            this.comboBox1.Text = "100";
            this.comboBox1.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.BeforeTouchSize = new System.Drawing.Size(115, 24);
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.ForeColor = System.Drawing.Color.Black;
            this.checkBox1.Location = new System.Drawing.Point(27, 28);
            this.checkBox1.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(115, 24);
            this.checkBox1.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.checkBox1.DrawFocusRectangle = true;
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "Zoom Cell";
            this.checkBox1.ThemesEnabled = false;
            this.checkBox1.CheckStateChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // gridGroupingControl1
            // 
            this.gridGroupingControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridGroupingControl1.BackColor = System.Drawing.SystemColors.Window;
            this.gridGroupingControl1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridGroupingControl1.FreezeCaption = false;
            this.gridGroupingControl1.GridOfficeScrollBars = Syncfusion.Windows.Forms.OfficeScrollBars.Office2010;
            this.gridGroupingControl1.Location = new System.Drawing.Point(20, 20);
            this.gridGroupingControl1.Name = "gridGroupingControl1";
            this.gridGroupingControl1.Size = new System.Drawing.Size(710, 616);
            this.gridGroupingControl1.TabIndex = 0;
            this.gridGroupingControl1.Text = "gridGroupingControl1";
            this.gridGroupingControl1.ThemesEnabled = false;
            this.gridGroupingControl1.TopLevelGroupOptions.ShowCaption = false;
            this.gridGroupingControl1.VersionInfo = "10.104.0.44";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(752, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(243, 570);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Zooming Options";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radioButton2);
            this.groupBox3.Controls.Add(this.radioButton1);
            this.groupBox3.Controls.Add(this.zoomFactorText);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.colorPickerButton1);
            this.groupBox3.Controls.Add(this.borderThickness);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.zoomDisplaySize);
            this.groupBox3.Controls.Add(this.trackBar2);
            this.groupBox3.Controls.Add(this.zoomSize);
            this.groupBox3.Controls.Add(this.checkBox1);
            this.groupBox3.Location = new System.Drawing.Point(9, 193);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(223, 371);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Cell Level";
            // 
            // zoomFactorText
            // 
            this.zoomFactorText.Location = new System.Drawing.Point(158, 243);
            this.zoomFactorText.Name = "zoomFactorText";
            this.zoomFactorText.NumberDecimalDigits = 1;
            this.zoomFactorText.Size = new System.Drawing.Size(53, 29);
            this.zoomFactorText.TabIndex = 8;
            this.zoomFactorText.DoubleValue = 1.5D;
            this.zoomFactorText.TextChanged += new System.EventHandler(this.zoomFactorText_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 246);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 21);
            this.label2.TabIndex = 22;
            this.label2.Text = "Zoom Factor:";
            // 
            // colorPickerButton1
            // 
            this.colorPickerButton1.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.colorPickerButton1.BeforeTouchSize = new System.Drawing.Size(119, 24);
            this.colorPickerButton1.ColorUISize = new System.Drawing.Size(208, 230);
            this.colorPickerButton1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.colorPickerButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colorPickerButton1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colorPickerButton1.ForeColor = System.Drawing.Color.Black;
            this.colorPickerButton1.IsBackStageButton = false;
            this.colorPickerButton1.Location = new System.Drawing.Point(46, 331);
            this.colorPickerButton1.Name = "colorPickerButton1";
            this.colorPickerButton1.SelectedAsBackcolor = true;
            this.colorPickerButton1.Size = new System.Drawing.Size(119, 24);
            this.colorPickerButton1.TabIndex = 10;
            this.colorPickerButton1.Text = "Border Color";
            this.colorPickerButton1.UseVisualStyleBackColor = false;
            this.colorPickerButton1.ColorSelected += new System.EventHandler(this.colorPickerButton1_ColorSelected);
            // 
            // borderThickness
            // 
            this.borderThickness.Location = new System.Drawing.Point(158, 283);
            this.borderThickness.Name = "borderThickness";
            this.borderThickness.Size = new System.Drawing.Size(53, 29);
            this.borderThickness.TabIndex = 9;
            this.borderThickness.Text = "15";
            this.borderThickness.TextChanged += new System.EventHandler(this.borderThickness_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 286);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 21);
            this.label1.TabIndex = 20;
            this.label1.Text = "Border Thickness:";
            // 
            // zoomDisplaySize
            // 
            this.zoomDisplaySize.AutoSize = true;
            this.zoomDisplaySize.Location = new System.Drawing.Point(66, 205);
            this.zoomDisplaySize.Name = "zoomDisplaySize";
            this.zoomDisplaySize.Size = new System.Drawing.Size(85, 21);
            this.zoomDisplaySize.TabIndex = 19;
            this.zoomDisplaySize.Text = "( 150,150 )";
            // 
            // trackBar2
            // 
            this.trackBar2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBar2.AutoSize = false;
            this.trackBar2.BackColor = System.Drawing.Color.White;
            this.trackBar2.LargeChange = 50;
            this.trackBar2.Location = new System.Drawing.Point(16, 170);
            this.trackBar2.Maximum = 400;
            this.trackBar2.Minimum = 100;
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.trackBar2.Size = new System.Drawing.Size(195, 28);
            this.trackBar2.SmallChange = 50;
            this.trackBar2.TabIndex = 7;
            this.trackBar2.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar2.Value = 150;
            this.trackBar2.ValueChanged += new System.EventHandler(this.trackBar2_ValueChanged);
            // 
            // zoomSize
            // 
            this.zoomSize.AutoSize = true;
            this.zoomSize.Location = new System.Drawing.Point(12, 135);
            this.zoomSize.Name = "zoomSize";
            this.zoomSize.Size = new System.Drawing.Size(86, 21);
            this.zoomSize.TabIndex = 17;
            this.zoomSize.Text = "Zoom Size:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Controls.Add(this.trackBar1);
            this.groupBox2.Location = new System.Drawing.Point(9, 39);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(226, 148);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Grid Level";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 21);
            this.label4.TabIndex = 16;
            this.label4.Text = "Zoom Frequency:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 21);
            this.label3.TabIndex = 15;
            this.label3.Text = "Zoom Level";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.gridGroupingControl1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1012, 654);
            this.panel2.TabIndex = 19;
            // 
            // tipDesc
            // 
            this.tipDesc.BackColor = System.Drawing.Color.White;
            this.tipDesc.IsBalloon = true;
            this.tipDesc.OwnerDraw = true;
            this.tipDesc.ShowAlways = true;
            this.tipDesc.StripAmpersands = true;
            this.tipDesc.UseFading = false;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(46, 59);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(116, 25);
            this.radioButton1.TabIndex = 6;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Ellipse Mode";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.mode_Changed);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(46, 90);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(140, 25);
            this.radioButton2.TabIndex = 5;
            this.radioButton2.Text = "Rectangle Mode";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.mode_Changed);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 654);
            this.Controls.Add(this.panel2);
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "Form1";
            this.Text = "Zooming Grid";
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridGroupingControl1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.zoomFactorText)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.borderThickness)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense(Syncfusion.Licensing.DemoCommon.FindLicenseKey());
            Application.Run(new Form1());
        }

        #endregion

        #region "DataTable"

        /// <summary>
        /// Genrate a Data by DataTable
        /// </summary>
        private DataTable GetTable()
        {
            DataTable dt = new DataTable("ParentTable");

            dt.Columns.Add(new DataColumn("parentID")); 
            dt.Columns.Add(new DataColumn("Parent Name"));
            dt.Columns.Add(new DataColumn("Parent Description"));
            dt.Columns.Add(new DataColumn("ParentRel"));
            for (int i = 0; i < numberParentRows; i++)
            {
                DataRow dr = dt.NewRow();
                dr[0] = i;//.ToString();
                dr[1] = string.Format("parent Name{0}", i);
                dr[2] = string.Format("parent Desc{0}", i);
                dr[3] = string.Format("parent Relation{0}", i);
                dt.Rows.Add(dr);
            }
           
            return dt;
		}
        /// <summary>
        /// Generate a Child data for NestedTable
        /// </summary>
        private DataTable GetChildTable()
        {
            DataTable dt = new DataTable("ChildTable");

            dt.Columns.Add(new DataColumn("child ID")); //lower case c
            dt.Columns.Add(new DataColumn("Name"));
            dt.Columns.Add(new DataColumn("ParentID"));  //upper case P
            dt.Columns.Add(new DataColumn("child Descriptor"));
            dt.Columns.Add(new DataColumn("child Relation"));

            for (int i = 0; i < numberChildRows; i++)
            {
                DataRow dr = dt.NewRow();
                dr[0] = i.ToString();
                dr[1] = string.Format("ChildName{0}", i);
                dr[2] = (i % numberParentRows).ToString();
                dr[3] = string.Format("ChildDesc{0}", i);
                dr[4] = string.Format("ChildRel{0}", i);
                dt.Rows.Add(dr);
            }

            return dt;
        }

        /// <summary>
        /// Generate a Grand Child Table
        /// </summary>
        private DataTable GetGrandChildTable()
        {
            DataTable dt = new DataTable("GrandChildTable");

            dt.Columns.Add(new DataColumn("Grand Child ID"));
            dt.Columns.Add(new DataColumn("Name"));
            dt.Columns.Add(new DataColumn("Child ID")); //upper case C
            dt.Columns.Add(new DataColumn("Grand Child Descriptor"));

            for (int i = 0; i < numberGrandChildRows; i++)
            {
                DataRow dr = dt.NewRow();
                dr[0] = i.ToString();
                dr[1] = string.Format("GrandChildName{0}", i);
                dr[2] = (i % numberChildRows).ToString();
                dr[3] = string.Format("Grand Child Desc{0}", i);
                dt.Rows.Add(dr);
            }

            return dt;
        }
        #endregion

        #endregion
    }
}

#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Syncfusion.Windows.Forms.Tools;
using Syncfusion.Windows.Forms.Diagram;
using Syncfusion.Windows.Forms.Diagram.Controls;
using Syncfusion.Windows.Forms;

namespace PaletteGroupbar
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
            this.model2 = new Syncfusion.Windows.Forms.Diagram.Model(this.components);
            this.model1 = new Syncfusion.Windows.Forms.Diagram.Model(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.gradientPanel3 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            this.panel23 = new System.Windows.Forms.Panel();
            this.label20 = new System.Windows.Forms.Label();
            this.cbCollapse = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.label15 = new System.Windows.Forms.Label();
            this.cbAutoClose = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.cbShowGripper = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.numericCollapsedWidth = new System.Windows.Forms.NumericUpDown();
            this.label18 = new System.Windows.Forms.Label();
            this.cmbPopupResize = new System.Windows.Forms.ComboBox();
            this.panel18 = new System.Windows.Forms.Panel();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.cbAllowCollapse = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.gradientPanel2 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            this.cbStackedMode = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.cbChevron = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.cbThemesEnabled = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.cmbOffice2007Theme = new System.Windows.Forms.ComboBox();
            this.cmbVisualStyle = new System.Windows.Forms.ComboBox();
            this.panel17 = new System.Windows.Forms.Panel();
            this.label23 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.paletteGroupBar1 = new Syncfusion.Windows.Forms.Diagram.Controls.PaletteGroupBar(this.components);
            this.panel10 = new System.Windows.Forms.Panel();
            this.btnAddPalette = new System.Windows.Forms.Button();
            this.diagram1 = new Syncfusion.Windows.Forms.Diagram.Controls.Diagram(this.components);
            this.model3 = new Syncfusion.Windows.Forms.Diagram.Model(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.gpVSAppearance = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            this.panel16 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbflatLook = new System.Windows.Forms.CheckBox();
            this.cpBack = new Syncfusion.Windows.Forms.ColorPickerButton();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbGBBorder = new System.Windows.Forms.ComboBox();
            this.cbDrawClientBorder = new System.Windows.Forms.CheckBox();
            this.gpVSBehavior = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            this.cbDragNode = new System.Windows.Forms.CheckBox();
            this.cbEditMode = new System.Windows.Forms.CheckBox();
            this.panel15 = new System.Windows.Forms.Panel();
            this.label34 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.cbAnimatedSelection = new System.Windows.Forms.CheckBox();
            this.cbIntegratedScrolling = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbTextAlignment = new System.Windows.Forms.ComboBox();
            this.paletteGroupBar3 = new Syncfusion.Windows.Forms.Diagram.Controls.PaletteGroupBar(this.components);
            this.gradientPanel1 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            this.txtEvents = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabControlAdv1 = new Syncfusion.Windows.Forms.Tools.TabControlAdv();
            this.tabPageAdv1 = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.panel4 = new System.Windows.Forms.Panel();
            this.gradientPanel4 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.cbSmallImageView = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.cbFlowViewText = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.cbFlowView = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.cbButtonView = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tabPageAdv2 = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.panel5 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.model2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.model1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel3)).BeginInit();
            this.gradientPanel3.SuspendLayout();
            this.panel23.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbCollapse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbAutoClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbShowGripper)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericCollapsedWidth)).BeginInit();
            this.panel18.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbAllowCollapse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel2)).BeginInit();
            this.gradientPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbStackedMode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbChevron)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbThemesEnabled)).BeginInit();
            this.panel17.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paletteGroupBar1)).BeginInit();
            this.panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.diagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.model3)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gpVSAppearance)).BeginInit();
            this.gpVSAppearance.SuspendLayout();
            this.panel16.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gpVSBehavior)).BeginInit();
            this.gpVSBehavior.SuspendLayout();
            this.panel15.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paletteGroupBar3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel1)).BeginInit();
            this.gradientPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabControlAdv1)).BeginInit();
            this.tabControlAdv1.SuspendLayout();
            this.tabPageAdv1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel4)).BeginInit();
            this.gradientPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbSmallImageView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbFlowViewText)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbFlowView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbButtonView)).BeginInit();
            this.panel6.SuspendLayout();
            this.tabPageAdv2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // model2
            // 
            this.model2.BackgroundStyle.PathBrushStyle = Syncfusion.Windows.Forms.Diagram.PathGradientBrushStyle.RectangleCenter;
            this.model2.DocumentScale.DisplayName = "No Scale";
            this.model2.DocumentScale.Height = 1F;
            this.model2.DocumentScale.Width = 1F;
            this.model2.DocumentSize.Height = 1169F;
            this.model2.DocumentSize.Width = 827F;
            this.model2.LineStyle.DashPattern = null;
            this.model2.LineStyle.LineColor = System.Drawing.Color.Black;
            this.model2.LogicalSize = new System.Drawing.SizeF(827F, 1169F);
            this.model2.ShadowStyle.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.model2.ShadowStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            // 
            // model1
            // 
            this.model1.BackgroundStyle.PathBrushStyle = Syncfusion.Windows.Forms.Diagram.PathGradientBrushStyle.RectangleCenter;
            this.model1.DocumentScale.DisplayName = "No Scale";
            this.model1.DocumentScale.Height = 1F;
            this.model1.DocumentScale.Width = 1F;
            this.model1.DocumentSize.Height = 538F;
            this.model1.DocumentSize.Width = 673F;
            this.model1.LineStyle.DashPattern = null;
            this.model1.LineStyle.LineColor = System.Drawing.Color.Black;
            this.model1.LogicalSize = new System.Drawing.SizeF(673F, 538F);
            this.model1.ShadowStyle.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.model1.ShadowStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.gradientPanel3);
            this.panel3.Controls.Add(this.gradientPanel2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(309, 44);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(2);
            this.panel3.Size = new System.Drawing.Size(378, 518);
            this.panel3.TabIndex = 201;
            // 
            // gradientPanel3
            // 
            this.gradientPanel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(241)))), ((int)(((byte)(253)))));
            this.gradientPanel3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(227)))), ((int)(((byte)(246)))));
            this.gradientPanel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gradientPanel3.Controls.Add(this.panel23);
            this.gradientPanel3.Controls.Add(this.panel18);
            this.gradientPanel3.Controls.Add(this.cbAllowCollapse);
            this.gradientPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.gradientPanel3.Location = new System.Drawing.Point(2, 241);
            this.gradientPanel3.Margin = new System.Windows.Forms.Padding(4);
            this.gradientPanel3.Name = "gradientPanel3";
            this.gradientPanel3.Size = new System.Drawing.Size(374, 264);
            this.gradientPanel3.TabIndex = 199;
            // 
            // panel23
            // 
            this.panel23.BackColor = System.Drawing.Color.Transparent;
            this.panel23.Controls.Add(this.label20);
            this.panel23.Controls.Add(this.cbCollapse);
            this.panel23.Controls.Add(this.label15);
            this.panel23.Controls.Add(this.cbAutoClose);
            this.panel23.Controls.Add(this.cbShowGripper);
            this.panel23.Controls.Add(this.numericCollapsedWidth);
            this.panel23.Controls.Add(this.label18);
            this.panel23.Controls.Add(this.cmbPopupResize);
            this.panel23.Location = new System.Drawing.Point(34, 73);
            this.panel23.Margin = new System.Windows.Forms.Padding(4);
            this.panel23.Name = "panel23";
            this.panel23.Size = new System.Drawing.Size(310, 181);
            this.panel23.TabIndex = 201;
            this.panel23.Enabled = false;
            // 
            // label20
            // 
            this.label20.BackColor = System.Drawing.Color.Transparent;
            this.label20.Image = ((System.Drawing.Image)(resources.GetObject("label20.Image")));
            this.label20.Location = new System.Drawing.Point(164, 79);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(27, 25);
            this.label20.TabIndex = 201;
            // 
            // cbCollapse
            // 
            this.cbCollapse.AutoHeight = true;
            this.cbCollapse.BackColor = System.Drawing.Color.Transparent;
            this.cbCollapse.DrawFocusRectangle = false;
            this.cbCollapse.Enabled = false;
            this.cbCollapse.Location = new System.Drawing.Point(4, 5);
            this.cbCollapse.Margin = new System.Windows.Forms.Padding(4);
            this.cbCollapse.MetroColor = System.Drawing.Color.Black;
            this.cbCollapse.Name = "cbCollapse";
            this.cbCollapse.Size = new System.Drawing.Size(91, 17);
            this.cbCollapse.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.cbCollapse.TabIndex = 0;
            this.cbCollapse.Text = "Collapse";
            this.cbCollapse.ThemesEnabled = false;
            this.cbCollapse.CheckedChanged += new System.EventHandler(this.cbCollapse_CheckedChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Location = new System.Drawing.Point(4, 148);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(103, 13);
            this.label15.TabIndex = 5;
            this.label15.Text = "Popup Resize Mode";
            // 
            // cbAutoClose
            // 
            this.cbAutoClose.AutoHeight = true;
            this.cbAutoClose.BackColor = System.Drawing.Color.Transparent;
            this.cbAutoClose.DrawFocusRectangle = false;
            this.cbAutoClose.Location = new System.Drawing.Point(4, 79);
            this.cbAutoClose.Margin = new System.Windows.Forms.Padding(4);
            this.cbAutoClose.MetroColor = System.Drawing.Color.Black;
            this.cbAutoClose.Name = "cbAutoClose";
            this.cbAutoClose.Size = new System.Drawing.Size(152, 17);
            this.cbAutoClose.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.cbAutoClose.TabIndex = 11;
            this.cbAutoClose.Text = "Popup Auto Close";
            this.cbAutoClose.ThemesEnabled = false;
            this.cbAutoClose.CheckedChanged += new System.EventHandler(this.cbAutoClose_CheckedChanged);
            // 
            // cbShowGripper
            // 
            this.cbShowGripper.AutoHeight = true;
            this.cbShowGripper.BackColor = System.Drawing.Color.Transparent;
            this.cbShowGripper.DrawFocusRectangle = false;
            this.cbShowGripper.Location = new System.Drawing.Point(4, 42);
            this.cbShowGripper.Margin = new System.Windows.Forms.Padding(4);
            this.cbShowGripper.MetroColor = System.Drawing.Color.Black;
            this.cbShowGripper.Name = "cbShowGripper";
            this.cbShowGripper.Size = new System.Drawing.Size(148, 17);
            this.cbShowGripper.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.cbShowGripper.TabIndex = 1;
            this.cbShowGripper.Text = "Show Popup Gripper";
            this.cbShowGripper.ThemesEnabled = false;
            this.cbShowGripper.CheckedChanged += new System.EventHandler(this.cbShowGripper_CheckedChanged);
            // 
            // numericCollapsedWidth
            // 
            this.numericCollapsedWidth.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericCollapsedWidth.Location = new System.Drawing.Point(149, 116);
            this.numericCollapsedWidth.Margin = new System.Windows.Forms.Padding(4);
            this.numericCollapsedWidth.Maximum = new decimal(new int[] {
            80,
            0,
            0,
            0});
            this.numericCollapsedWidth.Minimum = new decimal(new int[] {
            32,
            0,
            0,
            0});
            this.numericCollapsedWidth.Name = "numericCollapsedWidth";
            this.numericCollapsedWidth.Size = new System.Drawing.Size(109, 20);
            this.numericCollapsedWidth.TabIndex = 8;
            this.numericCollapsedWidth.Value = new decimal(new int[] {
            32,
            0,
            0,
            0});
            this.numericCollapsedWidth.ValueChanged += new System.EventHandler(this.numericCollapsedWidth_ValueChanged);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Location = new System.Drawing.Point(4, 116);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(84, 13);
            this.label18.TabIndex = 7;
            this.label18.Text = "Collapsed Width";
            // 
            // cmbPopupResize
            // 
            this.cmbPopupResize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPopupResize.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbPopupResize.FormattingEnabled = true;
            this.cmbPopupResize.Items.AddRange(new object[] {
            "Both",
            "Horizontal",
            "None",
            "Vertical"});
            this.cmbPopupResize.Location = new System.Drawing.Point(149, 148);
            this.cmbPopupResize.Margin = new System.Windows.Forms.Padding(4);
            this.cmbPopupResize.Name = "cmbPopupResize";
            this.cmbPopupResize.Size = new System.Drawing.Size(149, 21);
            this.cmbPopupResize.TabIndex = 16;
            this.cmbPopupResize.SelectedIndexChanged += new System.EventHandler(this.cmbPopupResize_SelectedIndexChanged);
            // 
            // panel18
            // 
            this.panel18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.panel18.Controls.Add(this.label28);
            this.panel18.Controls.Add(this.label29);
            this.panel18.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel18.ForeColor = System.Drawing.Color.MidnightBlue;
            this.panel18.Location = new System.Drawing.Point(0, 0);
            this.panel18.Margin = new System.Windows.Forms.Padding(4);
            this.panel18.Name = "panel18";
            this.panel18.Size = new System.Drawing.Size(372, 33);
            this.panel18.TabIndex = 157;
            // 
            // label28
            // 
            this.label28.BackColor = System.Drawing.Color.White;
            this.label28.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label28.Location = new System.Drawing.Point(0, 31);
            this.label28.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(372, 2);
            this.label28.TabIndex = 139;
            // 
            // label29
            // 
            this.label29.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label29.Image = ((System.Drawing.Image)(resources.GetObject("label29.Image")));
            this.label29.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label29.Location = new System.Drawing.Point(5, 5);
            this.label29.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(202, 26);
            this.label29.TabIndex = 170;
            this.label29.Text = "Collapse Mode Properties";
            this.label29.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbAllowCollapse
            // 
            this.cbAllowCollapse.AutoHeight = true;
            this.cbAllowCollapse.BackColor = System.Drawing.Color.Transparent;
            this.cbAllowCollapse.DrawFocusRectangle = false;
            this.cbAllowCollapse.Location = new System.Drawing.Point(38, 45);
            this.cbAllowCollapse.Margin = new System.Windows.Forms.Padding(4);
            this.cbAllowCollapse.MetroColor = System.Drawing.Color.Black;
            this.cbAllowCollapse.Name = "cbAllowCollapse";
            this.cbAllowCollapse.Size = new System.Drawing.Size(127, 17);
            this.cbAllowCollapse.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.cbAllowCollapse.TabIndex = 22;
            this.cbAllowCollapse.Text = "AllowCollapse";
            this.cbAllowCollapse.ThemesEnabled = false;
            this.cbAllowCollapse.Enabled = false;
            this.cbAllowCollapse.CheckedChanged += new System.EventHandler(this.cbAllowCollapse_CheckedChanged);
            // 
            // gradientPanel2
            // 
            this.gradientPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(241)))), ((int)(((byte)(253)))));
            this.gradientPanel2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(227)))), ((int)(((byte)(246)))));
            this.gradientPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gradientPanel2.Controls.Add(this.cbStackedMode);
            this.gradientPanel2.Controls.Add(this.cbChevron);
            this.gradientPanel2.Controls.Add(this.cbThemesEnabled);
            this.gradientPanel2.Controls.Add(this.cmbOffice2007Theme);
            this.gradientPanel2.Controls.Add(this.cmbVisualStyle);
            this.gradientPanel2.Controls.Add(this.panel17);
            this.gradientPanel2.Controls.Add(this.label25);
            this.gradientPanel2.Controls.Add(this.label26);
            this.gradientPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.gradientPanel2.Location = new System.Drawing.Point(2, 2);
            this.gradientPanel2.Margin = new System.Windows.Forms.Padding(4);
            this.gradientPanel2.Name = "gradientPanel2";
            this.gradientPanel2.Size = new System.Drawing.Size(374, 239);
            this.gradientPanel2.TabIndex = 198;
            // 
            // cbStackedMode
            // 
            this.cbStackedMode.AutoHeight = true;
            this.cbStackedMode.BackColor = System.Drawing.Color.Transparent;
            this.cbStackedMode.DrawFocusRectangle = false;
            this.cbStackedMode.Location = new System.Drawing.Point(36, 57);
            this.cbStackedMode.Margin = new System.Windows.Forms.Padding(4);
            this.cbStackedMode.MetroColor = System.Drawing.Color.Black;
            this.cbStackedMode.Name = "cbStackedMode";
            this.cbStackedMode.Size = new System.Drawing.Size(160, 17);
            this.cbStackedMode.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.cbStackedMode.TabIndex = 164;
            this.cbStackedMode.Text = "Enable Stacked Mode";
            this.cbStackedMode.ThemesEnabled = false;
            this.cbStackedMode.CheckedChanged += new System.EventHandler(this.cbStackedMode_CheckedChanged);
            // 
            // cbChevron
            // 
            this.cbChevron.AutoHeight = true;
            this.cbChevron.BackColor = System.Drawing.Color.Transparent;
            this.cbChevron.DrawFocusRectangle = false;
            this.cbChevron.Location = new System.Drawing.Point(36, 94);
            this.cbChevron.Margin = new System.Windows.Forms.Padding(4);
            this.cbChevron.MetroColor = System.Drawing.Color.Black;
            this.cbChevron.Name = "cbChevron";
            this.cbChevron.Size = new System.Drawing.Size(127, 17);
            this.cbChevron.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.cbChevron.TabIndex = 163;
            this.cbChevron.Text = "Show Chevron";
            this.cbChevron.ThemesEnabled = false;
            this.cbChevron.CheckedChanged += new System.EventHandler(this.cbChevron_CheckedChanged);
            // 
            // cbThemesEnabled
            // 
            this.cbThemesEnabled.AutoHeight = true;
            this.cbThemesEnabled.BackColor = System.Drawing.Color.Transparent;
            this.cbThemesEnabled.DrawFocusRectangle = false;
            this.cbThemesEnabled.Location = new System.Drawing.Point(36, 131);
            this.cbThemesEnabled.Margin = new System.Windows.Forms.Padding(4);
            this.cbThemesEnabled.MetroColor = System.Drawing.Color.Black;
            this.cbThemesEnabled.Name = "cbThemesEnabled";
            this.cbThemesEnabled.Size = new System.Drawing.Size(127, 17);
            this.cbThemesEnabled.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.cbThemesEnabled.TabIndex = 162;
            this.cbThemesEnabled.Text = "Themes Enabled";
            this.cbThemesEnabled.ThemesEnabled = false;
            this.cbThemesEnabled.CheckedChanged += new System.EventHandler(this.cbThemesEnabled_CheckedChanged);
            // 
            // cmbOffice2007Theme
            // 
            this.cmbOffice2007Theme.Enabled = false;
            this.cmbOffice2007Theme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbOffice2007Theme.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbOffice2007Theme.FormattingEnabled = true;
            this.cmbOffice2007Theme.Items.AddRange(new object[] {
            "Managed",
            "Blue",
            "Silver",
            "Black"});
            this.cmbOffice2007Theme.Location = new System.Drawing.Point(148, 204);
            this.cmbOffice2007Theme.Margin = new System.Windows.Forms.Padding(4);
            this.cmbOffice2007Theme.Name = "cmbOffice2007Theme";
            this.cmbOffice2007Theme.Size = new System.Drawing.Size(184, 21);
            this.cmbOffice2007Theme.TabIndex = 159;
            this.cmbOffice2007Theme.SelectedIndexChanged += new System.EventHandler(this.cboOffice2007Theme_SelectedIndexChanged);
            // 
            // cmbVisualStyle
            // 
            this.cmbVisualStyle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbVisualStyle.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbVisualStyle.FormattingEnabled = true;
            this.cmbVisualStyle.Items.AddRange(new object[] {
            "Default",
            "Office2003",
            "Office2007",
            "Metro"});
            this.cmbVisualStyle.Location = new System.Drawing.Point(148, 169);
            this.cmbVisualStyle.Margin = new System.Windows.Forms.Padding(4);
            this.cmbVisualStyle.Name = "cmbVisualStyle";
            this.cmbVisualStyle.Size = new System.Drawing.Size(184, 21);
            this.cmbVisualStyle.TabIndex = 158;
            this.cmbVisualStyle.SelectedIndexChanged += new System.EventHandler(this.cboVisualStyle_SelectedIndexChanged);
            // 
            // panel17
            // 
            this.panel17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.panel17.Controls.Add(this.label23);
            this.panel17.Controls.Add(this.label27);
            this.panel17.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel17.Location = new System.Drawing.Point(0, 0);
            this.panel17.Margin = new System.Windows.Forms.Padding(4);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(372, 33);
            this.panel17.TabIndex = 157;
            // 
            // label23
            // 
            this.label23.BackColor = System.Drawing.Color.White;
            this.label23.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label23.Location = new System.Drawing.Point(0, 31);
            this.label23.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(372, 2);
            this.label23.TabIndex = 139;
            // 
            // label27
            // 
            this.label27.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label27.Image = ((System.Drawing.Image)(resources.GetObject("label27.Image")));
            this.label27.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label27.Location = new System.Drawing.Point(13, 1);
            this.label27.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(217, 26);
            this.label27.TabIndex = 170;
            this.label27.Text = "PaletteGroupBar Properties";
            this.label27.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label25
            // 
            this.label25.BackColor = System.Drawing.Color.Transparent;
            this.label25.ForeColor = System.Drawing.Color.Black;
            this.label25.Location = new System.Drawing.Point(36, 174);
            this.label25.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(88, 17);
            this.label25.TabIndex = 141;
            this.label25.Text = "Visual Styles";
            // 
            // label26
            // 
            this.label26.BackColor = System.Drawing.Color.Transparent;
            this.label26.ForeColor = System.Drawing.Color.Black;
            this.label26.Location = new System.Drawing.Point(36, 209);
            this.label26.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(99, 17);
            this.label26.TabIndex = 143;
            this.label26.Text = "ColorSchemes";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(241)))), ((int)(((byte)(253)))));
            this.panel7.Controls.Add(this.paletteGroupBar1);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel7.Location = new System.Drawing.Point(0, 44);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(309, 518);
            this.panel7.TabIndex = 5;
            // 
            // paletteGroupBar1
            // 
            this.paletteGroupBar1.AllowDrop = true;
            this.paletteGroupBar1.AnimatedSelection = false;
            this.paletteGroupBar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.paletteGroupBar1.BorderColor = System.Drawing.Color.White;
            this.paletteGroupBar1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.paletteGroupBar1.Diagram = null;
            this.paletteGroupBar1.Dock = System.Windows.Forms.DockStyle.Left;
            this.paletteGroupBar1.EditMode = false;
            this.paletteGroupBar1.ExpandButtonToolTip = null;
            this.paletteGroupBar1.ExpandedWidth = (int)DpiAware.LogicalToDeviceUnits(289);
            this.paletteGroupBar1.FlatLook = true;
            this.paletteGroupBar1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paletteGroupBar1.ForeColor = System.Drawing.Color.White;
            this.paletteGroupBar1.GroupBarDropDownToolTip = null;
            this.paletteGroupBar1.GroupBarItemHeight = (int)DpiAware.LogicalToDeviceUnits(25);
            this.paletteGroupBar1.IndexOnVisibleItems = true;
            this.paletteGroupBar1.Location = new System.Drawing.Point(0, 0);
            this.paletteGroupBar1.Margin = new System.Windows.Forms.Padding(4);
            this.paletteGroupBar1.MinimizeButtonToolTip = null;
            this.paletteGroupBar1.Name = "paletteGroupBar1";
            this.paletteGroupBar1.NavigationPaneTooltip = null;
            this.paletteGroupBar1.PopupClientSize = new System.Drawing.Size(0, 0);
            this.paletteGroupBar1.ShowChevron = false;
            this.paletteGroupBar1.Size = new System.Drawing.Size(309, 518);
            this.paletteGroupBar1.TabIndex = 3;
            this.paletteGroupBar1.Text = "paletteGroupBar2";
            this.paletteGroupBar1.TextAlign = Syncfusion.Windows.Forms.Tools.TextAlignment.Left;
            this.paletteGroupBar1.VisualStyle = Syncfusion.Windows.Forms.VisualStyle.Metro;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(241)))), ((int)(((byte)(253)))));
            this.panel10.Controls.Add(this.btnAddPalette);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel10.Location = new System.Drawing.Point(0, 0);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(1034, 44);
            this.panel10.TabIndex = 200;
            // 
            // btnAddPalette
            // 
            this.btnAddPalette.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.btnAddPalette.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAddPalette.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnAddPalette.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddPalette.ForeColor = System.Drawing.Color.Black;
            this.btnAddPalette.Image = ((System.Drawing.Image)(resources.GetObject("btnAddPalette.Image")));
            this.btnAddPalette.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnAddPalette.Location = new System.Drawing.Point(5, 6);
            this.btnAddPalette.Name = "btnAddPalette";
            this.btnAddPalette.Size = new System.Drawing.Size(122, 31);
            this.btnAddPalette.TabIndex = 11;
            this.btnAddPalette.Text = "Add Palette";
            this.btnAddPalette.UseVisualStyleBackColor = false;
            this.btnAddPalette.Click += new System.EventHandler(this.btnAddPalette_Click);
            // 
            // diagram1
            // 
            this.diagram1.Controller.PasteOffset = new System.Drawing.SizeF(10F, 10F);
            this.diagram1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.diagram1.DpiAware = false;
            this.diagram1.HScroll = true;
            this.diagram1.LayoutManager = null;
            this.diagram1.Location = new System.Drawing.Point(235, 0);
            this.diagram1.MetroScrollBars = true;
            this.diagram1.Model = this.model3;
            this.diagram1.Name = "diagram1";
            this.diagram1.ScrollVirtualBounds = new System.Drawing.RectangleF(0, 0, 0, 0);
            this.diagram1.Size = new System.Drawing.Size(515, 562);
            this.diagram1.SmartSizeBox = false;
            this.diagram1.TabIndex = 199;
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
            // model3
            // 
            this.model3.BackgroundStyle.PathBrushStyle = Syncfusion.Windows.Forms.Diagram.PathGradientBrushStyle.RectangleCenter;
            this.model3.DocumentScale.DisplayName = "No Scale";
            this.model3.DocumentScale.Height = 1F;
            this.model3.DocumentScale.Width = 1F;
            this.model3.DocumentSize.Height = 1169F;
            this.model3.DocumentSize.Width = 827F;
            this.model3.LineStyle.DashPattern = null;
            this.model3.LineStyle.LineColor = System.Drawing.Color.White;
            this.model3.LogicalSize = new System.Drawing.SizeF(827F, 1169F);
            this.model3.ShadowStyle.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.model3.ShadowStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.gpVSAppearance);
            this.panel2.Controls.Add(this.gpVSBehavior);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(750, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(284, 562);
            this.panel2.TabIndex = 198;
            // 
            // gpVSAppearance
            // 
            this.gpVSAppearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(241)))), ((int)(((byte)(253)))));
            this.gpVSAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(227)))), ((int)(((byte)(246)))));
            this.gpVSAppearance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gpVSAppearance.Controls.Add(this.panel16);
            this.gpVSAppearance.Controls.Add(this.label5);
            this.gpVSAppearance.Controls.Add(this.cbflatLook);
            this.gpVSAppearance.Controls.Add(this.cpBack);
            this.gpVSAppearance.Controls.Add(this.label7);
            this.gpVSAppearance.Controls.Add(this.cmbGBBorder);
            this.gpVSAppearance.Controls.Add(this.cbDrawClientBorder);
            this.gpVSAppearance.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gpVSAppearance.Location = new System.Drawing.Point(0, 293);
            this.gpVSAppearance.Margin = new System.Windows.Forms.Padding(4);
            this.gpVSAppearance.Name = "gpVSAppearance";
            this.gpVSAppearance.Size = new System.Drawing.Size(284, 269);
            this.gpVSAppearance.TabIndex = 197;
            // 
            // panel16
            // 
            this.panel16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.panel16.Controls.Add(this.label6);
            this.panel16.Controls.Add(this.label17);
            this.panel16.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel16.ForeColor = System.Drawing.Color.MidnightBlue;
            this.panel16.Location = new System.Drawing.Point(0, 0);
            this.panel16.Margin = new System.Windows.Forms.Padding(4);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(282, 33);
            this.panel16.TabIndex = 157;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label6.Location = new System.Drawing.Point(0, 31);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(282, 2);
            this.label6.TabIndex = 139;
            // 
            // label17
            // 
            this.label17.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Black;
            this.label17.Image = ((System.Drawing.Image)(resources.GetObject("label17.Image")));
            this.label17.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label17.Location = new System.Drawing.Point(13, 6);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(110, 21);
            this.label17.TabIndex = 170;
            this.label17.Text = "Appearance";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(20, 72);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 149;
            this.label5.Text = "BackColor";
            // 
            // cbflatLook
            // 
            this.cbflatLook.AutoSize = true;
            this.cbflatLook.BackColor = System.Drawing.Color.Transparent;
            this.cbflatLook.Checked = true;
            this.cbflatLook.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbflatLook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbflatLook.Location = new System.Drawing.Point(20, 104);
            this.cbflatLook.Margin = new System.Windows.Forms.Padding(4);
            this.cbflatLook.Name = "cbflatLook";
            this.cbflatLook.Size = new System.Drawing.Size(67, 17);
            this.cbflatLook.TabIndex = 133;
            this.cbflatLook.Text = "Flat Look";
            this.cbflatLook.UseVisualStyleBackColor = false;
            this.cbflatLook.CheckedChanged += new System.EventHandler(this.cbflatLook_CheckedChanged);
            // 
            // cpBack
            // 
            this.cpBack.BackColor = System.Drawing.SystemColors.Control;
            this.cpBack.ColorUISize = new System.Drawing.Size(208, 230);
            this.cpBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cpBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cpBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpBack.ForeColor = System.Drawing.Color.MidnightBlue;
            this.cpBack.Location = new System.Drawing.Point(115, 72);
            this.cpBack.Margin = new System.Windows.Forms.Padding(4);
            this.cpBack.Name = "cpBack";
            this.cpBack.SelectedAsBackcolor = true;
            this.cpBack.SelectedColor = System.Drawing.SystemColors.Control;
            this.cpBack.Size = new System.Drawing.Size(27, 25);
            this.cpBack.TabIndex = 148;
            this.cpBack.UseVisualStyleBackColor = false;
            this.cpBack.ColorSelected += new System.EventHandler(this.cpBack_ColorSelected);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(20, 177);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 13);
            this.label7.TabIndex = 136;
            this.label7.Text = "GroupBar BorderStyle";
            // 
            // cmbGBBorder
            // 
            this.cmbGBBorder.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGBBorder.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbGBBorder.FormattingEnabled = true;
            this.cmbGBBorder.Items.AddRange(new object[] {
            "None",
            "FixedSingle",
            "Fixed3D"});
            this.cmbGBBorder.Location = new System.Drawing.Point(170, 177);
            this.cmbGBBorder.Margin = new System.Windows.Forms.Padding(4);
            this.cmbGBBorder.Name = "cmbGBBorder";
            this.cmbGBBorder.Size = new System.Drawing.Size(108, 21);
            this.cmbGBBorder.TabIndex = 137;
            this.cmbGBBorder.SelectedIndexChanged += new System.EventHandler(this.cmbGBBorder_SelectedIndexChanged);
            // 
            // cbDrawClientBorder
            // 
            this.cbDrawClientBorder.AutoSize = true;
            this.cbDrawClientBorder.BackColor = System.Drawing.Color.Transparent;
            this.cbDrawClientBorder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbDrawClientBorder.Location = new System.Drawing.Point(20, 140);
            this.cbDrawClientBorder.Margin = new System.Windows.Forms.Padding(4);
            this.cbDrawClientBorder.Name = "cbDrawClientBorder";
            this.cbDrawClientBorder.Size = new System.Drawing.Size(105, 17);
            this.cbDrawClientBorder.TabIndex = 138;
            this.cbDrawClientBorder.Text = "DrawClientBorder";
            this.cbDrawClientBorder.UseVisualStyleBackColor = false;
            this.cbDrawClientBorder.CheckedChanged += new System.EventHandler(this.cbDrawClientBorder_CheckedChanged);
            // 
            // gpVSBehavior
            // 
            this.gpVSBehavior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(241)))), ((int)(((byte)(253)))));
            this.gpVSBehavior.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(227)))), ((int)(((byte)(246)))));
            this.gpVSBehavior.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gpVSBehavior.Controls.Add(this.cbDragNode);
            this.gpVSBehavior.Controls.Add(this.cbEditMode);
            this.gpVSBehavior.Controls.Add(this.panel15);
            this.gpVSBehavior.Controls.Add(this.cbAnimatedSelection);
            this.gpVSBehavior.Controls.Add(this.cbIntegratedScrolling);
            this.gpVSBehavior.Controls.Add(this.label1);
            this.gpVSBehavior.Controls.Add(this.cmbTextAlignment);
            this.gpVSBehavior.Dock = System.Windows.Forms.DockStyle.Top;
            this.gpVSBehavior.Location = new System.Drawing.Point(0, 0);
            this.gpVSBehavior.Margin = new System.Windows.Forms.Padding(4);
            this.gpVSBehavior.Name = "gpVSBehavior";
            this.gpVSBehavior.Size = new System.Drawing.Size(284, 229);
            this.gpVSBehavior.TabIndex = 196;
            // 
            // cbDragNode
            // 
            this.cbDragNode.AutoSize = true;
            this.cbDragNode.BackColor = System.Drawing.Color.Transparent;
            this.cbDragNode.Checked = true;
            this.cbDragNode.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbDragNode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbDragNode.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDragNode.Location = new System.Drawing.Point(17, 147);
            this.cbDragNode.Margin = new System.Windows.Forms.Padding(4);
            this.cbDragNode.Name = "cbDragNode";
            this.cbDragNode.Size = new System.Drawing.Size(121, 17);
            this.cbDragNode.TabIndex = 161;
            this.cbDragNode.Text = "Show DragNodeCue";
            this.cbDragNode.UseVisualStyleBackColor = false;
            this.cbDragNode.CheckedChanged += new System.EventHandler(this.cbDragNode_CheckedChanged);
            // 
            // cbEditMode
            // 
            this.cbEditMode.AutoSize = true;
            this.cbEditMode.BackColor = System.Drawing.Color.Transparent;
            this.cbEditMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbEditMode.Location = new System.Drawing.Point(17, 88);
            this.cbEditMode.Margin = new System.Windows.Forms.Padding(4);
            this.cbEditMode.Name = "cbEditMode";
            this.cbEditMode.Size = new System.Drawing.Size(71, 17);
            this.cbEditMode.TabIndex = 158;
            this.cbEditMode.Text = "Edit Mode";
            this.cbEditMode.UseVisualStyleBackColor = false;
            this.cbEditMode.CheckedChanged += new System.EventHandler(this.cbEditMode_CheckedChanged);
            // 
            // panel15
            // 
            this.panel15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.panel15.Controls.Add(this.label34);
            this.panel15.Controls.Add(this.label35);
            this.panel15.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel15.Location = new System.Drawing.Point(0, 0);
            this.panel15.Margin = new System.Windows.Forms.Padding(4);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(282, 33);
            this.panel15.TabIndex = 157;
            // 
            // label34
            // 
            this.label34.BackColor = System.Drawing.Color.White;
            this.label34.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label34.Location = new System.Drawing.Point(0, 31);
            this.label34.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(282, 2);
            this.label34.TabIndex = 139;
            // 
            // label35
            // 
            this.label35.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label35.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label35.Image = ((System.Drawing.Image)(resources.GetObject("label35.Image")));
            this.label35.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label35.Location = new System.Drawing.Point(13, 2);
            this.label35.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(90, 23);
            this.label35.TabIndex = 170;
            this.label35.Text = "Behavior";
            this.label35.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbAnimatedSelection
            // 
            this.cbAnimatedSelection.AutoSize = true;
            this.cbAnimatedSelection.BackColor = System.Drawing.Color.Transparent;
            this.cbAnimatedSelection.Checked = true;
            this.cbAnimatedSelection.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbAnimatedSelection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbAnimatedSelection.Location = new System.Drawing.Point(17, 59);
            this.cbAnimatedSelection.Margin = new System.Windows.Forms.Padding(4);
            this.cbAnimatedSelection.Name = "cbAnimatedSelection";
            this.cbAnimatedSelection.Size = new System.Drawing.Size(114, 17);
            this.cbAnimatedSelection.TabIndex = 132;
            this.cbAnimatedSelection.Text = "Animated Selection";
            this.cbAnimatedSelection.UseVisualStyleBackColor = false;
            this.cbAnimatedSelection.CheckedChanged += new System.EventHandler(this.cbAnimatedSelection_CheckedChanged);
            // 
            // cbIntegratedScrolling
            // 
            this.cbIntegratedScrolling.AutoSize = true;
            this.cbIntegratedScrolling.BackColor = System.Drawing.Color.Transparent;
            this.cbIntegratedScrolling.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbIntegratedScrolling.Location = new System.Drawing.Point(17, 118);
            this.cbIntegratedScrolling.Margin = new System.Windows.Forms.Padding(4);
            this.cbIntegratedScrolling.Name = "cbIntegratedScrolling";
            this.cbIntegratedScrolling.Size = new System.Drawing.Size(111, 17);
            this.cbIntegratedScrolling.TabIndex = 143;
            this.cbIntegratedScrolling.Text = "IntegratedScrolling";
            this.cbIntegratedScrolling.UseVisualStyleBackColor = false;
            this.cbIntegratedScrolling.CheckedChanged += new System.EventHandler(this.cbIntegratedScrolling_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(17, 188);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 141;
            this.label1.Text = "Text Alignment";
            // 
            // cmbTextAlignment
            // 
            this.cmbTextAlignment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTextAlignment.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbTextAlignment.FormattingEnabled = true;
            this.cmbTextAlignment.Items.AddRange(new object[] {
            "Left",
            "Center",
            "Right"});
            this.cmbTextAlignment.Location = new System.Drawing.Point(126, 184);
            this.cmbTextAlignment.Margin = new System.Windows.Forms.Padding(4);
            this.cmbTextAlignment.Name = "cmbTextAlignment";
            this.cmbTextAlignment.Size = new System.Drawing.Size(105, 21);
            this.cmbTextAlignment.TabIndex = 142;
            this.cmbTextAlignment.SelectedIndexChanged += new System.EventHandler(this.cmbTextAlignment_SelectedIndexChanged);
            // 
            // paletteGroupBar3
            // 
            this.paletteGroupBar3.AllowDrop = true;
            this.paletteGroupBar3.AnimatedSelection = false;
            this.paletteGroupBar3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.paletteGroupBar3.BorderColor = System.Drawing.Color.White;
            this.paletteGroupBar3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.paletteGroupBar3.Diagram = null;
            this.paletteGroupBar3.Dock = System.Windows.Forms.DockStyle.Left;
            this.paletteGroupBar3.EditMode = false;
            this.paletteGroupBar3.ExpandButtonToolTip = null;
            this.paletteGroupBar3.ExpandedWidth = 289;
            this.paletteGroupBar3.FlatLook = true;
            this.paletteGroupBar3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.paletteGroupBar3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(77)))), ((int)(((byte)(140)))));
            this.paletteGroupBar3.GroupBarDropDownToolTip = null;
            this.paletteGroupBar3.GroupBarItemHeight = 25;
            this.paletteGroupBar3.IndexOnVisibleItems = true;
            this.paletteGroupBar3.Location = new System.Drawing.Point(0, 0);
            this.paletteGroupBar3.Margin = new System.Windows.Forms.Padding(4);
            this.paletteGroupBar3.MinimizeButtonToolTip = null;
            this.paletteGroupBar3.Name = "paletteGroupBar3";
            this.paletteGroupBar3.PopupClientSize = new System.Drawing.Size(0, 0);
            this.paletteGroupBar3.ShowChevron = false;
            this.paletteGroupBar3.Size = new System.Drawing.Size(235, 562);
            this.paletteGroupBar3.TabIndex = 4;
            this.paletteGroupBar3.Text = "paletteGroupBar3";
            this.paletteGroupBar3.TextAlign = Syncfusion.Windows.Forms.Tools.TextAlignment.Left;
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(241)))), ((int)(((byte)(253)))));
            this.gradientPanel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(227)))), ((int)(((byte)(246)))));
            this.gradientPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gradientPanel1.Controls.Add(this.txtEvents);
            this.gradientPanel1.Controls.Add(this.panel1);
            this.gradientPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gradientPanel1.Location = new System.Drawing.Point(687, 304);
            this.gradientPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Padding = new System.Windows.Forms.Padding(2);
            this.gradientPanel1.Size = new System.Drawing.Size(347, 258);
            this.gradientPanel1.TabIndex = 202;
            // 
            // txtEvents
            // 
            this.txtEvents.AcceptsReturn = true;
            this.txtEvents.AcceptsTab = true;
            this.txtEvents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtEvents.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEvents.Location = new System.Drawing.Point(2, 35);
            this.txtEvents.Multiline = true;
            this.txtEvents.Name = "txtEvents";
            this.txtEvents.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtEvents.Size = new System.Drawing.Size(341, 219);
            this.txtEvents.TabIndex = 158;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(341, 33);
            this.panel1.TabIndex = 157;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label2.Location = new System.Drawing.Point(0, 31);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(341, 2);
            this.label2.TabIndex = 139;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label3.Image = ((System.Drawing.Image)(resources.GetObject("label3.Image")));
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Location = new System.Drawing.Point(13, 1);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 26);
            this.label3.TabIndex = 170;
            this.label3.Text = "Events";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabControlAdv1
            // 
            this.tabControlAdv1.ActiveTabFont = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.tabControlAdv1.Controls.Add(this.tabPageAdv1);
            this.tabControlAdv1.Controls.Add(this.tabPageAdv2);
            this.tabControlAdv1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlAdv1.Location = new System.Drawing.Point(0, 0);
            this.tabControlAdv1.Name = "tabControlAdv1";
            this.tabControlAdv1.Size = new System.Drawing.Size(1037, 586);
            this.tabControlAdv1.TabGap = 10;
            this.tabControlAdv1.TabIndex = 5;
            this.tabControlAdv1.TabPanelBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(216)))), ((int)(((byte)(237)))));
            this.tabControlAdv1.TabStyle = typeof(Syncfusion.Windows.Forms.Tools.TabRendererOffice2007);
            // 
            // tabPageAdv1
            // 
            this.tabPageAdv1.Controls.Add(this.panel4);
            this.tabPageAdv1.Image = null;
            this.tabPageAdv1.ImageSize = new System.Drawing.Size(16, 16);
            this.tabPageAdv1.Location = new System.Drawing.Point(1, 22);
            this.tabPageAdv1.Name = "tabPageAdv1";
            this.tabPageAdv1.ShowCloseButton = true;
            this.tabPageAdv1.Size = new System.Drawing.Size(1034, 562);
            this.tabPageAdv1.TabIndex = 1;
            this.tabPageAdv1.Text = "Outlook PaletteGroupbar";
            this.tabPageAdv1.ThemesEnabled = false;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.gradientPanel4);
            this.panel4.Controls.Add(this.gradientPanel1);
            this.panel4.Controls.Add(this.panel3);
            this.panel4.Controls.Add(this.panel7);
            this.panel4.Controls.Add(this.panel10);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1034, 562);
            this.panel4.TabIndex = 0;
            // 
            // gradientPanel4
            // 
            this.gradientPanel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(241)))), ((int)(((byte)(253)))));
            this.gradientPanel4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(227)))), ((int)(((byte)(246)))));
            this.gradientPanel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gradientPanel4.Controls.Add(this.numericUpDown1);
            this.gradientPanel4.Controls.Add(this.label9);
            this.gradientPanel4.Controls.Add(this.cbSmallImageView);
            this.gradientPanel4.Controls.Add(this.cbFlowViewText);
            this.gradientPanel4.Controls.Add(this.cbFlowView);
            this.gradientPanel4.Controls.Add(this.cbButtonView);
            this.gradientPanel4.Controls.Add(this.panel6);
            this.gradientPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gradientPanel4.Location = new System.Drawing.Point(687, 44);
            this.gradientPanel4.Margin = new System.Windows.Forms.Padding(4);
            this.gradientPanel4.Name = "gradientPanel4";
            this.gradientPanel4.Padding = new System.Windows.Forms.Padding(2);
            this.gradientPanel4.Size = new System.Drawing.Size(347, 260);
            this.gradientPanel4.TabIndex = 203;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown1.Location = new System.Drawing.Point(202, 155);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            160,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(109, 20);
            this.numericUpDown1.TabIndex = 170;
            this.numericUpDown1.Value = new decimal(new int[] {
            80,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(24, 158);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(132, 13);
            this.label9.TabIndex = 169;
            this.label9.Text = "FlowView Item TextLength";
            // 
            // cbSmallImageView
            // 
            this.cbSmallImageView.AutoHeight = true;
            this.cbSmallImageView.BackColor = System.Drawing.Color.Transparent;
            this.cbSmallImageView.DrawFocusRectangle = false;
            this.cbSmallImageView.Location = new System.Drawing.Point(18, 127);
            this.cbSmallImageView.Margin = new System.Windows.Forms.Padding(4);
            this.cbSmallImageView.MetroColor = System.Drawing.Color.Black;
            this.cbSmallImageView.Name = "cbSmallImageView";
            this.cbSmallImageView.Size = new System.Drawing.Size(204, 17);
            this.cbSmallImageView.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.cbSmallImageView.TabIndex = 168;
            this.cbSmallImageView.Text = "Small Image View";
            this.cbSmallImageView.ThemesEnabled = false;
            this.cbSmallImageView.CheckedChanged += new System.EventHandler(this.cbSmallImageView_CheckedChanged);
            // 
            // cbFlowViewText
            // 
            this.cbFlowViewText.AutoHeight = true;
            this.cbFlowViewText.BackColor = System.Drawing.Color.Transparent;
            this.cbFlowViewText.Checked = true;
            this.cbFlowViewText.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbFlowViewText.DrawFocusRectangle = false;
            this.cbFlowViewText.Location = new System.Drawing.Point(18, 99);
            this.cbFlowViewText.Margin = new System.Windows.Forms.Padding(4);
            this.cbFlowViewText.MetroColor = System.Drawing.Color.Black;
            this.cbFlowViewText.Name = "cbFlowViewText";
            this.cbFlowViewText.Size = new System.Drawing.Size(204, 17);
            this.cbFlowViewText.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.cbFlowViewText.TabIndex = 167;
            this.cbFlowViewText.Text = "Show FlowView ItemText";
            this.cbFlowViewText.ThemesEnabled = false;
            this.cbFlowViewText.CheckedChanged += new System.EventHandler(this.cbFlowViewText_CheckedChanged);
            // 
            // cbFlowView
            // 
            this.cbFlowView.AutoHeight = true;
            this.cbFlowView.BackColor = System.Drawing.Color.Transparent;
            this.cbFlowView.Checked = true;
            this.cbFlowView.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbFlowView.DrawFocusRectangle = false;
            this.cbFlowView.Location = new System.Drawing.Point(18, 71);
            this.cbFlowView.Margin = new System.Windows.Forms.Padding(4);
            this.cbFlowView.MetroColor = System.Drawing.Color.Black;
            this.cbFlowView.Name = "cbFlowView";
            this.cbFlowView.Size = new System.Drawing.Size(160, 17);
            this.cbFlowView.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.cbFlowView.TabIndex = 166;
            this.cbFlowView.Text = "Flow View";
            this.cbFlowView.ThemesEnabled = false;
            this.cbFlowView.CheckedChanged += new System.EventHandler(this.cbFlowView_CheckedChanged);
            // 
            // cbButtonView
            // 
            this.cbButtonView.AutoHeight = true;
            this.cbButtonView.BackColor = System.Drawing.Color.Transparent;
            this.cbButtonView.DrawFocusRectangle = false;
            this.cbButtonView.Location = new System.Drawing.Point(18, 43);
            this.cbButtonView.Margin = new System.Windows.Forms.Padding(4);
            this.cbButtonView.MetroColor = System.Drawing.Color.Black;
            this.cbButtonView.Name = "cbButtonView";
            this.cbButtonView.Size = new System.Drawing.Size(160, 17);
            this.cbButtonView.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.cbButtonView.TabIndex = 165;
            this.cbButtonView.Text = "Button View";
            this.cbButtonView.ThemesEnabled = false;
            this.cbButtonView.CheckedChanged += new System.EventHandler(this.cbButtonView_CheckedChanged);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.panel6.Controls.Add(this.label4);
            this.panel6.Controls.Add(this.label8);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.ForeColor = System.Drawing.Color.MidnightBlue;
            this.panel6.Location = new System.Drawing.Point(2, 2);
            this.panel6.Margin = new System.Windows.Forms.Padding(4);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(341, 33);
            this.panel6.TabIndex = 157;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label4.Location = new System.Drawing.Point(0, 31);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(341, 2);
            this.label4.TabIndex = 139;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label8.Image = ((System.Drawing.Image)(resources.GetObject("label8.Image")));
            this.label8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label8.Location = new System.Drawing.Point(13, 1);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(253, 26);
            this.label8.TabIndex = 170;
            this.label8.Text = "PaletteGroupView Properties";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabPageAdv2
            // 
            this.tabPageAdv2.Controls.Add(this.panel5);
            this.tabPageAdv2.Image = null;
            this.tabPageAdv2.ImageSize = new System.Drawing.Size(16, 16);
            this.tabPageAdv2.Location = new System.Drawing.Point(1, 22);
            this.tabPageAdv2.Name = "tabPageAdv2";
            this.tabPageAdv2.ShowCloseButton = true;
            this.tabPageAdv2.Size = new System.Drawing.Size(1034, 562);
            this.tabPageAdv2.TabBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(235)))), ((int)(((byte)(246)))));
            this.tabPageAdv2.TabIndex = 2;
            this.tabPageAdv2.Text = "VS Like PaletteGroupbar";
            this.tabPageAdv2.ThemesEnabled = false;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.diagram1);
            this.panel5.Controls.Add(this.paletteGroupBar3);
            this.panel5.Controls.Add(this.panel2);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1034, 562);
            this.panel5.TabIndex = 200;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.BorderThickness = 0;
            this.CaptionAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.CaptionBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.CaptionButtonColor = System.Drawing.Color.Black;
            this.CaptionFont = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CaptionForeColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(1037, 586);
            this.Controls.Add(this.tabControlAdv1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.Name = "Form1";
            this.Text = "PaletteGroupbar";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.model2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.model1)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel3)).EndInit();
            this.gradientPanel3.ResumeLayout(false);
            this.panel23.ResumeLayout(false);
            this.panel23.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbCollapse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbAutoClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbShowGripper)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericCollapsedWidth)).EndInit();
            this.panel18.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cbAllowCollapse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel2)).EndInit();
            this.gradientPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cbStackedMode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbChevron)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbThemesEnabled)).EndInit();
            this.panel17.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.paletteGroupBar1)).EndInit();
            this.panel10.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.diagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.model3)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gpVSAppearance)).EndInit();
            this.gpVSAppearance.ResumeLayout(false);
            this.gpVSAppearance.PerformLayout();
            this.panel16.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gpVSBehavior)).EndInit();
            this.gpVSBehavior.ResumeLayout(false);
            this.gpVSBehavior.PerformLayout();
            this.panel15.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.paletteGroupBar3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel1)).EndInit();
            this.gradientPanel1.ResumeLayout(false);
            this.gradientPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tabControlAdv1)).EndInit();
            this.tabControlAdv1.ResumeLayout(false);
            this.tabPageAdv1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel4)).EndInit();
            this.gradientPanel4.ResumeLayout(false);
            this.gradientPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbSmallImageView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbFlowViewText)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbFlowView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbButtonView)).EndInit();
            this.panel6.ResumeLayout(false);
            this.tabPageAdv2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        
        #endregion

        private Model model1;
        private Model model2;
        private GradientPanel gradientPanel3;
        private System.Windows.Forms.Panel panel23;
        private System.Windows.Forms.Label label20;
        private CheckBoxAdv cbCollapse;
        private System.Windows.Forms.Label label15;
        private CheckBoxAdv cbAutoClose;
        private CheckBoxAdv cbShowGripper;
        private System.Windows.Forms.NumericUpDown numericCollapsedWidth;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox cmbPopupResize;
        private System.Windows.Forms.Panel panel18;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label29;
        private CheckBoxAdv cbAllowCollapse;
        private GradientPanel gradientPanel2;
        private System.Windows.Forms.Panel panel17;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private PaletteGroupBar paletteGroupBar3;
        private System.Windows.Forms.ComboBox cmbOffice2007Theme;
        private System.Windows.Forms.ComboBox cmbVisualStyle;
        private GradientPanel gpVSAppearance;
        private System.Windows.Forms.Panel panel16;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox cbflatLook;
        private Syncfusion.Windows.Forms.ColorPickerButton cpBack;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbGBBorder;
        private System.Windows.Forms.CheckBox cbDrawClientBorder;
        private GradientPanel gpVSBehavior;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.CheckBox cbAnimatedSelection;
        private System.Windows.Forms.CheckBox cbIntegratedScrolling;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbTextAlignment;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel7;
        private PaletteGroupBar paletteGroupBar1;
        private System.Windows.Forms.Button btnAddPalette;
        private System.Windows.Forms.Panel panel2;
        private Diagram diagram1;
        private Model model3;
        private System.Windows.Forms.CheckBox cbEditMode;
        private System.Windows.Forms.CheckBox cbDragNode;
        private GradientPanel gradientPanel1;
        private System.Windows.Forms.TextBox txtEvents;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private CheckBoxAdv cbThemesEnabled;
        private CheckBoxAdv cbChevron;
        private CheckBoxAdv cbStackedMode;
        private TabControlAdv tabControlAdv1;
        private TabPageAdv tabPageAdv1;
        private TabPageAdv tabPageAdv2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private GradientPanel gradientPanel4;
        private CheckBoxAdv cbFlowView;
        private CheckBoxAdv cbButtonView;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private CheckBoxAdv cbFlowViewText;
        private CheckBoxAdv cbSmallImageView;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label9;
    }
}


using System.Drawing;
namespace ProgressBarAdv_CustomRender
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
            this.tabControlAdv1 = new Syncfusion.Windows.Forms.Tools.TabControlAdv();
            this.tabPageAdv1 = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.progressBarAdv1 = new Syncfusion.Windows.Forms.Tools.ProgressBarAdv();
            this.tabPageAdv3 = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.progressBarAdv3 = new Syncfusion.Windows.Forms.Tools.ProgressBarAdv();
            this.xpTaskBar1 = new Syncfusion.Windows.Forms.Tools.XPTaskBar();
            this.xpTaskBarBox1 = new Syncfusion.Windows.Forms.Tools.XPTaskBarBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.colorPickerButton2 = new Syncfusion.Windows.Forms.ColorPickerButton();
            this.colorPickerButton1 = new Syncfusion.Windows.Forms.ColorPickerButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxAdv1 = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.label1 = new System.Windows.Forms.Label();
            this.xpTaskBarBox2 = new Syncfusion.Windows.Forms.Tools.XPTaskBarBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonAdv2 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.buttonAdv1 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.comboBoxAdv2 = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.label4 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.tabControlAdv1)).BeginInit();
            this.tabControlAdv1.SuspendLayout();
            this.tabPageAdv1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.progressBarAdv1)).BeginInit();
            this.tabPageAdv3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.progressBarAdv3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpTaskBar1)).BeginInit();
            this.xpTaskBar1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xpTaskBarBox1)).BeginInit();
            this.xpTaskBarBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxAdv1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpTaskBarBox2)).BeginInit();
            this.xpTaskBarBox2.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxAdv2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlAdv1
            // 
            this.tabControlAdv1.BeforeTouchSize = new System.Drawing.Size(1006, 476);
            this.tabControlAdv1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabControlAdv1.Controls.Add(this.tabPageAdv1);
            this.tabControlAdv1.Controls.Add(this.tabPageAdv3);
            this.tabControlAdv1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlAdv1.FixedSingleBorderColor = System.Drawing.SystemColors.ControlDark;
            this.tabControlAdv1.FocusOnTabClick = false;
            this.tabControlAdv1.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.tabControlAdv1.InactiveTabColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.tabControlAdv1.ItemSize = new System.Drawing.Size(90, 30);
            this.tabControlAdv1.Location = new System.Drawing.Point(0, 0);
            this.tabControlAdv1.Name = "tabControlAdv1";
            this.tabControlAdv1.Size = new System.Drawing.Size(1006, 476);
            this.tabControlAdv1.TabIndex = 0;
            this.tabControlAdv1.TabPanelBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.tabControlAdv1.TabStyle = typeof(Syncfusion.Windows.Forms.Tools.TabRendererMetro);
            this.tabControlAdv1.SelectedIndexChanged += new System.EventHandler(this.tabControlAdv1_SelectedIndexChanged);
            // 
            // tabPageAdv1
            // 
            this.tabPageAdv1.Controls.Add(this.progressBarAdv1);
            this.tabPageAdv1.Image = null;
            this.tabPageAdv1.ImageSize = new System.Drawing.Size(16, 16);
            this.tabPageAdv1.Location = new System.Drawing.Point(1, 30);
            this.tabPageAdv1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tabPageAdv1.Name = "tabPageAdv1";
            this.tabPageAdv1.ShowCloseButton = true;
            this.tabPageAdv1.Size = new System.Drawing.Size(1004, 445);
            this.tabPageAdv1.TabIndex = 1;
            this.tabPageAdv1.Text = "Shapes";
            this.tabPageAdv1.ThemesEnabled = false;
            // 
            // progressBarAdv1
            // 
            this.progressBarAdv1.BackGradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.progressBarAdv1.BackGradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.progressBarAdv1.BackMultipleColors = new System.Drawing.Color[] {
        System.Drawing.Color.Empty};
            this.progressBarAdv1.BackSegments = false;
            this.progressBarAdv1.BackTubeEndColor = System.Drawing.Color.White;
            this.progressBarAdv1.BackTubeStartColor = System.Drawing.Color.LightGray;
            this.progressBarAdv1.BorderColor = System.Drawing.Color.LightGray;
            this.progressBarAdv1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.progressBarAdv1.CustomText = null;
            this.progressBarAdv1.CustomWaitingRender = false;
            this.progressBarAdv1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.progressBarAdv1.FontColor = System.Drawing.Color.White;
            this.progressBarAdv1.ForegroundImage = null;
            this.progressBarAdv1.GradientEndColor = System.Drawing.Color.Lime;
            this.progressBarAdv1.GradientStartColor = System.Drawing.Color.Red;
            this.progressBarAdv1.Location = new System.Drawing.Point(194, 98);
            this.progressBarAdv1.MultipleColors = new System.Drawing.Color[] {
        System.Drawing.Color.Empty};
            this.progressBarAdv1.Name = "progressBarAdv1";
            this.progressBarAdv1.ProgressStyle = Syncfusion.Windows.Forms.Tools.ProgressBarStyles.WaitingGradient;
            this.progressBarAdv1.SegmentWidth = 12;
            this.progressBarAdv1.Size = new System.Drawing.Size(280, 280);
            this.progressBarAdv1.TabIndex = 0;
            this.progressBarAdv1.Text = "progressBarAdv1";
            this.progressBarAdv1.ThemesEnabled = false;
            this.progressBarAdv1.TubeEndColor = System.Drawing.Color.Black;
            this.progressBarAdv1.TubeStartColor = System.Drawing.Color.Red;
            this.progressBarAdv1.Value = 0;
            this.progressBarAdv1.WaitingGradientWidth = 400;
            // 
            // tabPageAdv3
            // 
            this.tabPageAdv3.Controls.Add(this.progressBarAdv3);
            this.tabPageAdv3.Image = null;
            this.tabPageAdv3.ImageSize = new System.Drawing.Size(16, 16);
            this.tabPageAdv3.Location = new System.Drawing.Point(1, 30);
            this.tabPageAdv3.Name = "tabPageAdv3";
            this.tabPageAdv3.ShowCloseButton = true;
            this.tabPageAdv3.Size = new System.Drawing.Size(1066, 448);
            this.tabPageAdv3.TabIndex = 3;
            this.tabPageAdv3.Text = "Customization";
            this.tabPageAdv3.ThemesEnabled = false;
            // 
            // progressBarAdv3
            // 
            this.progressBarAdv3.BackGradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.progressBarAdv3.BackGradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.progressBarAdv3.BackMultipleColors = new System.Drawing.Color[] {
        System.Drawing.Color.Empty};
            this.progressBarAdv3.BackSegments = false;
            this.progressBarAdv3.BackTubeEndColor = System.Drawing.Color.White;
            this.progressBarAdv3.BackTubeStartColor = System.Drawing.Color.LightGray;
            this.progressBarAdv3.CustomText = null;
            this.progressBarAdv3.CustomWaitingRender = false;
            this.progressBarAdv3.FontColor = System.Drawing.Color.White;
            this.progressBarAdv3.ForegroundImage = null;
            this.progressBarAdv3.GradientEndColor = System.Drawing.Color.Lime;
            this.progressBarAdv3.GradientStartColor = System.Drawing.Color.Red;
            this.progressBarAdv3.Location = new System.Drawing.Point(11, 121);
            this.progressBarAdv3.MultipleColors = new System.Drawing.Color[] {
        System.Drawing.Color.Empty};
            this.progressBarAdv3.Name = "progressBarAdv3";
            this.progressBarAdv3.SegmentWidth = 12;
            this.progressBarAdv3.Size = new System.Drawing.Size(719, 209);
            this.progressBarAdv3.TabIndex = 0;
            this.progressBarAdv3.Text = "progressBarAdv3";
            this.progressBarAdv3.ThemesEnabled = false;
            this.progressBarAdv3.TubeEndColor = System.Drawing.Color.Black;
            this.progressBarAdv3.TubeStartColor = System.Drawing.Color.Red;
            this.progressBarAdv3.WaitingGradientWidth = 400;
            // 
            // xpTaskBar1
            // 
            this.xpTaskBar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.xpTaskBar1.BeforeTouchSize = new System.Drawing.Size(262, 476);
            this.xpTaskBar1.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.xpTaskBar1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.xpTaskBar1.Controls.Add(this.xpTaskBarBox1);
            this.xpTaskBar1.Controls.Add(this.xpTaskBarBox2);
            this.xpTaskBar1.Dock = System.Windows.Forms.DockStyle.Right;
            this.xpTaskBar1.Location = new System.Drawing.Point(744, 0);
            this.xpTaskBar1.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.xpTaskBar1.MinimumSize = new System.Drawing.Size(0, 0);
            this.xpTaskBar1.Name = "xpTaskBar1";
            this.xpTaskBar1.Size = new System.Drawing.Size(262, 476);
            this.xpTaskBar1.TabIndex = 2;
            // 
            // xpTaskBarBox1
            // 
            this.xpTaskBarBox1.Controls.Add(this.panel1);
            this.xpTaskBarBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xpTaskBarBox1.HeaderBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.xpTaskBarBox1.HeaderImageIndex = -1;
            this.xpTaskBarBox1.HitTaskBoxArea = false;
            this.xpTaskBarBox1.HotTrackColor = System.Drawing.Color.Empty;
            this.xpTaskBarBox1.ItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.xpTaskBarBox1.Location = new System.Drawing.Point(0, 0);
            this.xpTaskBarBox1.Name = "xpTaskBarBox1";
            this.xpTaskBarBox1.PreferredChildPanelHeight = 140;
            this.xpTaskBarBox1.ShowCollapseButton = false;
            this.xpTaskBarBox1.Size = new System.Drawing.Size(260, 173);
            this.xpTaskBarBox1.TabIndex = 0;
            this.xpTaskBarBox1.Text = "Layout Properties";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.panel1.Controls.Add(this.colorPickerButton2);
            this.panel1.Controls.Add(this.colorPickerButton1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.comboBoxAdv1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.panel1.Location = new System.Drawing.Point(2, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(256, 140);
            this.panel1.TabIndex = 0;
            // 
            // colorPickerButton2
            // 
            this.colorPickerButton2.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.colorPickerButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.colorPickerButton2.BeforeTouchSize = new System.Drawing.Size(19, 19);
            this.colorPickerButton2.ColorUISize = new System.Drawing.Size(208, 230);
            this.colorPickerButton2.ForeColor = System.Drawing.Color.White;
            this.colorPickerButton2.IsBackStageButton = false;
            this.colorPickerButton2.Location = new System.Drawing.Point(216, 88);
            this.colorPickerButton2.MetroColor = System.Drawing.Color.White;
            this.colorPickerButton2.Name = "colorPickerButton2";
            this.colorPickerButton2.SelectedColorGroup = Syncfusion.Windows.Forms.ColorUISelectedGroup.CustomColors;
            this.colorPickerButton2.Size = new System.Drawing.Size(19, 19);
            this.colorPickerButton2.TabIndex = 5;
            this.colorPickerButton2.UseVisualStyle = true;
            this.colorPickerButton2.ColorSelected += new System.EventHandler(this.colorPickerButton2_ColorSelected);
            // 
            // colorPickerButton1
            // 
            this.colorPickerButton1.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.colorPickerButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.colorPickerButton1.BeforeTouchSize = new System.Drawing.Size(19, 19);
            this.colorPickerButton1.ColorUISize = new System.Drawing.Size(208, 230);
            this.colorPickerButton1.ForeColor = System.Drawing.Color.White;
            this.colorPickerButton1.IsBackStageButton = false;
            this.colorPickerButton1.Location = new System.Drawing.Point(102, 88);
            this.colorPickerButton1.MetroColor = System.Drawing.Color.PaleTurquoise;
            this.colorPickerButton1.Name = "colorPickerButton1";
            this.colorPickerButton1.SelectedColorGroup = Syncfusion.Windows.Forms.ColorUISelectedGroup.CustomColors;
            this.colorPickerButton1.Size = new System.Drawing.Size(19, 19);
            this.colorPickerButton1.TabIndex = 4;
            this.colorPickerButton1.UseVisualStyle = true;
            this.colorPickerButton1.ColorSelected += new System.EventHandler(this.colorPickerButton1_ColorSelected);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.label3.Location = new System.Drawing.Point(132, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Background";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.label2.Location = new System.Drawing.Point(20, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Foreground";
            // 
            // comboBoxAdv1
            // 
            this.comboBoxAdv1.BackColor = System.Drawing.Color.White;
            this.comboBoxAdv1.BeforeTouchSize = new System.Drawing.Size(208, 25);
            this.comboBoxAdv1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAdv1.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.comboBoxAdv1.Items.AddRange(new object[] {
            "Radial",
            "Rectangle",
            "Circle",
            "Triangle"});
            this.comboBoxAdv1.ItemsImageIndexes.Add(new Syncfusion.Windows.Forms.Tools.ComboBoxAdv.ImageIndexItem(this.comboBoxAdv1, "Radial"));
            this.comboBoxAdv1.ItemsImageIndexes.Add(new Syncfusion.Windows.Forms.Tools.ComboBoxAdv.ImageIndexItem(this.comboBoxAdv1, "Rectangle"));
            this.comboBoxAdv1.ItemsImageIndexes.Add(new Syncfusion.Windows.Forms.Tools.ComboBoxAdv.ImageIndexItem(this.comboBoxAdv1, "Circle"));
            this.comboBoxAdv1.ItemsImageIndexes.Add(new Syncfusion.Windows.Forms.Tools.ComboBoxAdv.ImageIndexItem(this.comboBoxAdv1, "Triangle"));
            this.comboBoxAdv1.Location = new System.Drawing.Point(23, 48);
            this.comboBoxAdv1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.comboBoxAdv1.Name = "comboBoxAdv1";
            this.comboBoxAdv1.Size = new System.Drawing.Size(208, 25);
            this.comboBoxAdv1.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.comboBoxAdv1.TabIndex = 1;
            this.comboBoxAdv1.Text = "Radial";
            this.comboBoxAdv1.SelectedIndexChanged += new System.EventHandler(this.comboBoxAdv1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.label1.Location = new System.Drawing.Point(21, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Shapes";
            // 
            // xpTaskBarBox2
            // 
            this.xpTaskBarBox2.Controls.Add(this.panel2);
            this.xpTaskBarBox2.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.xpTaskBarBox2.HeaderBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.xpTaskBarBox2.HeaderImageIndex = -1;
            this.xpTaskBarBox2.HitTaskBoxArea = false;
            this.xpTaskBarBox2.HotTrackColor = System.Drawing.Color.Empty;
            this.xpTaskBarBox2.ItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.xpTaskBarBox2.Location = new System.Drawing.Point(0, 173);
            this.xpTaskBarBox2.Name = "xpTaskBarBox2";
            this.xpTaskBarBox2.PreferredChildPanelHeight = 140;
            this.xpTaskBarBox2.ShowCollapseButton = false;
            this.xpTaskBarBox2.Size = new System.Drawing.Size(260, 173);
            this.xpTaskBarBox2.TabIndex = 1;
            this.xpTaskBarBox2.Text = "Animation Settings";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.panel2.Controls.Add(this.buttonAdv2);
            this.panel2.Controls.Add(this.buttonAdv1);
            this.panel2.Controls.Add(this.comboBoxAdv2);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(2, 31);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(256, 140);
            this.panel2.TabIndex = 0;
            // 
            // buttonAdv2
            // 
            this.buttonAdv2.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.buttonAdv2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.buttonAdv2.BeforeTouchSize = new System.Drawing.Size(97, 27);
            this.buttonAdv2.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.buttonAdv2.ForeColor = System.Drawing.Color.White;
            this.buttonAdv2.IsBackStageButton = false;
            this.buttonAdv2.Location = new System.Drawing.Point(135, 85);
            this.buttonAdv2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.buttonAdv2.Name = "buttonAdv2";
            this.buttonAdv2.Size = new System.Drawing.Size(97, 27);
            this.buttonAdv2.TabIndex = 5;
            this.buttonAdv2.Text = "Stop";
            this.buttonAdv2.UseVisualStyle = true;
            this.buttonAdv2.Click += new System.EventHandler(this.buttonAdv2_Click);
            // 
            // buttonAdv1
            // 
            this.buttonAdv1.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.buttonAdv1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.buttonAdv1.BeforeTouchSize = new System.Drawing.Size(97, 27);
            this.buttonAdv1.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.buttonAdv1.ForeColor = System.Drawing.Color.White;
            this.buttonAdv1.IsBackStageButton = false;
            this.buttonAdv1.Location = new System.Drawing.Point(24, 85);
            this.buttonAdv1.Name = "buttonAdv1";
            this.buttonAdv1.Size = new System.Drawing.Size(97, 27);
            this.buttonAdv1.TabIndex = 4;
            this.buttonAdv1.Text = "Preview";
            this.buttonAdv1.UseVisualStyle = true;
            this.buttonAdv1.Click += new System.EventHandler(this.buttonAdv1_Click);
            // 
            // comboBoxAdv2
            // 
            this.comboBoxAdv2.BackColor = System.Drawing.Color.White;
            this.comboBoxAdv2.BeforeTouchSize = new System.Drawing.Size(208, 25);
            this.comboBoxAdv2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAdv2.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.comboBoxAdv2.Items.AddRange(new object[] {
            "Left to Right",
            "Right to Left"});
            this.comboBoxAdv2.ItemsImageIndexes.Add(new Syncfusion.Windows.Forms.Tools.ComboBoxAdv.ImageIndexItem(this.comboBoxAdv2, "Left to Right"));
            this.comboBoxAdv2.ItemsImageIndexes.Add(new Syncfusion.Windows.Forms.Tools.ComboBoxAdv.ImageIndexItem(this.comboBoxAdv2, "Right to Left"));
            this.comboBoxAdv2.Location = new System.Drawing.Point(24, 43);
            this.comboBoxAdv2.Name = "comboBoxAdv2";
            this.comboBoxAdv2.Size = new System.Drawing.Size(208, 25);
            this.comboBoxAdv2.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.comboBoxAdv2.TabIndex = 3;
            this.comboBoxAdv2.Text = "Left to Right";
            this.comboBoxAdv2.SelectedIndexChanged += new System.EventHandler(this.comboBoxAdv2_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.label4.Location = new System.Drawing.Point(26, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Animation";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218)))));
            this.CaptionBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218)))));
            this.CaptionBarHeight = 30;
            this.CaptionButtonColor = System.Drawing.Color.White;
            this.CaptionButtonHoverColor = System.Drawing.Color.White;
            this.CaptionFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CaptionForeColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1006, 476);
            this.Controls.Add(this.xpTaskBar1);
            this.Controls.Add(this.tabControlAdv1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Text = "Customization";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.tabControlAdv1)).EndInit();
            this.tabControlAdv1.ResumeLayout(false);
            this.tabPageAdv1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.progressBarAdv1)).EndInit();
            this.tabPageAdv3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.progressBarAdv3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpTaskBar1)).EndInit();
            this.xpTaskBar1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.xpTaskBarBox1)).EndInit();
            this.xpTaskBarBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxAdv1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpTaskBarBox2)).EndInit();
            this.xpTaskBarBox2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxAdv2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Syncfusion.Windows.Forms.Tools.TabControlAdv tabControlAdv1;
        private Syncfusion.Windows.Forms.Tools.TabPageAdv tabPageAdv1;
        private Syncfusion.Windows.Forms.Tools.XPTaskBar xpTaskBar1;
        private Syncfusion.Windows.Forms.Tools.XPTaskBarBox xpTaskBarBox1;
        private Syncfusion.Windows.Forms.Tools.XPTaskBarBox xpTaskBarBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Syncfusion.Windows.Forms.ColorPickerButton colorPickerButton2;
        private Syncfusion.Windows.Forms.ColorPickerButton colorPickerButton1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv comboBoxAdv1;
        private System.Windows.Forms.Label label1;
        private Syncfusion.Windows.Forms.ButtonAdv buttonAdv2;
        private Syncfusion.Windows.Forms.ButtonAdv buttonAdv1;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv comboBoxAdv2;
        private System.Windows.Forms.Label label4;
        private Syncfusion.Windows.Forms.Tools.ProgressBarAdv progressBarAdv1;
        private System.Windows.Forms.Timer timer1;
        private Syncfusion.Windows.Forms.Tools.TabPageAdv tabPageAdv3;
        private Syncfusion.Windows.Forms.Tools.ProgressBarAdv progressBarAdv3;

    }
}


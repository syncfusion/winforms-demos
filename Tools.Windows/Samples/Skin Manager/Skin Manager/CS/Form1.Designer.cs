namespace SkinManagerDemo_2008
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
            Syncfusion.Windows.Forms.Tools.CaptionButtonsCollection ccbgroupBar1 = new Syncfusion.Windows.Forms.Tools.CaptionButtonsCollection();
            this.dockingManager1 = new Syncfusion.Windows.Forms.Tools.DockingManager(this.components);
            this.groupBar1 = new Syncfusion.Windows.Forms.Tools.GroupBar();
            this.calculatorControl1 = new Syncfusion.Windows.Forms.Tools.CalculatorControl();
            this.groupBarItem1 = new Syncfusion.Windows.Forms.Tools.GroupBarItem();
            this.groupBarItem2 = new Syncfusion.Windows.Forms.Tools.GroupBarItem();
            this.groupBarItem3 = new Syncfusion.Windows.Forms.Tools.GroupBarItem();
            this.groupBarItem4 = new Syncfusion.Windows.Forms.Tools.GroupBarItem();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.xpTaskPane1 = new Syncfusion.Windows.Forms.Tools.XPTaskPane();
            this.wizardContainer1 = new Syncfusion.Windows.Forms.Tools.WizardContainer();
            this.xpTaskPage1 = new Syncfusion.Windows.Forms.Tools.XPTaskPage();
            this.colorPickerUIAdv1 = new Syncfusion.Windows.Forms.Tools.ColorPickerUIAdv();
            this.gradientPanelExt1 = new Syncfusion.Windows.Forms.Tools.GradientPanelExt();
            this.autoLabel1 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.toolStripEx1 = new Syncfusion.Windows.Forms.Tools.ToolStripEx();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dockingManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBar1)).BeginInit();
            this.groupBar1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xpTaskPane1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpTaskPane1.Header)).BeginInit();
            this.xpTaskPane1.SuspendLayout();
            this.wizardContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xpTaskPage1)).BeginInit();
            this.xpTaskPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanelExt1)).BeginInit();
            this.gradientPanelExt1.SuspendLayout();
            this.toolStripEx1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dockingManager1
            // 
            this.dockingManager1.ActiveCaptionFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            this.dockingManager1.DockLayoutStream = ((System.IO.MemoryStream)(resources.GetObject("dockingManager1.DockLayoutStream")));
            this.dockingManager1.HostControl = this;
            this.dockingManager1.InActiveCaptionFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            this.dockingManager1.MetroButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
           // this.dockingManager1.MetroCaptionColor = System.Drawing.Color.White;
            this.dockingManager1.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.dockingManager1.MetroSplitterBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(159)))), ((int)(((byte)(183)))));
            this.dockingManager1.ReduceFlickeringInRtl = false;
            this.dockingManager1.VisualStyle = Syncfusion.Windows.Forms.VisualStyle.Office2007;
            this.dockingManager1.CaptionButtons.Add(new Syncfusion.Windows.Forms.Tools.CaptionButton(Syncfusion.Windows.Forms.Tools.CaptionButtonType.Close, "CloseButton"));
            this.dockingManager1.CaptionButtons.Add(new Syncfusion.Windows.Forms.Tools.CaptionButton(Syncfusion.Windows.Forms.Tools.CaptionButtonType.Pin, "PinButton"));
            this.dockingManager1.CaptionButtons.Add(new Syncfusion.Windows.Forms.Tools.CaptionButton(Syncfusion.Windows.Forms.Tools.CaptionButtonType.Menu, "MenuButton"));
            this.dockingManager1.CaptionButtons.Add(new Syncfusion.Windows.Forms.Tools.CaptionButton(Syncfusion.Windows.Forms.Tools.CaptionButtonType.Maximize, "MaximizeButton"));
            this.dockingManager1.CaptionButtons.Add(new Syncfusion.Windows.Forms.Tools.CaptionButton(Syncfusion.Windows.Forms.Tools.CaptionButtonType.Restore, "RestoreButton"));
            this.dockingManager1.SetDockLabel(this.groupBar1, "groupBar1");
            this.dockingManager1.SetEnableDocking(this.groupBar1, true);
            ccbgroupBar1.MergeWith(this.dockingManager1.CaptionButtons, false);
            this.dockingManager1.SetCustomCaptionButtons(this.groupBar1, ccbgroupBar1);
            // 
            // groupBar1
            // 
            this.groupBar1.AllowDrop = true;
            this.groupBar1.AnimatedSelection = false;
            this.groupBar1.BeforeTouchSize = new System.Drawing.Size(202, 470);
            this.groupBar1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(146)))), ((int)(((byte)(206)))));
            this.groupBar1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.groupBar1.CollapseImage = ((System.Drawing.Image)(resources.GetObject("groupBar1.CollapseImage")));
            this.groupBar1.Controls.Add(this.calculatorControl1);
            this.groupBar1.ExpandButtonToolTip = null;
            this.groupBar1.ExpandImage = ((System.Drawing.Image)(resources.GetObject("groupBar1.ExpandImage")));
            this.groupBar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.groupBar1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(77)))), ((int)(((byte)(140)))));
            this.groupBar1.GroupBarDropDownToolTip = null;
            this.groupBar1.GroupBarItems.AddRange(new Syncfusion.Windows.Forms.Tools.GroupBarItem[] {
            this.groupBarItem1,
            this.groupBarItem2,
            this.groupBarItem3,
            this.groupBarItem4});
            this.groupBar1.HeaderBackColor = System.Drawing.SystemColors.ControlDark;
            this.groupBar1.HeaderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(65)))), ((int)(((byte)(140)))));
            this.groupBar1.IndexOnVisibleItems = true;
            this.groupBar1.Location = new System.Drawing.Point(3, 26);
            this.groupBar1.MinimizeButtonToolTip = null;
            this.groupBar1.Name = "groupBar1";
            this.groupBar1.NavigationPaneTooltip = null;
            this.groupBar1.PopupClientSize = new System.Drawing.Size(0, 0);
            this.groupBar1.SelectedItem = 3;
            this.groupBar1.Size = new System.Drawing.Size(202, 470);
            this.groupBar1.StackedMode = true;
            this.groupBar1.TabIndex = 1;
            this.groupBar1.Text = "groupBar1";
            this.groupBar1.VisualStyle = Syncfusion.Windows.Forms.VisualStyle.Office2007;
            // 
            // calculatorControl1
            // 
            this.calculatorControl1.AccessibleDescription = "Calculator control";
            this.calculatorControl1.AccessibleName = "Calculator Control";
            this.calculatorControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(209)))), ((int)(((byte)(252)))));
            this.calculatorControl1.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(209)))), ((int)(((byte)(252))))), System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(242)))), ((int)(((byte)(255))))));
            this.calculatorControl1.BeforeTouchSize = new System.Drawing.Size(200, 316);
            this.calculatorControl1.ButtonStyle = Syncfusion.Windows.Forms.ButtonAppearance.Office2007;
            this.calculatorControl1.Culture = new System.Globalization.CultureInfo("en-US");
            this.calculatorControl1.DoubleValue = 0D;
            this.calculatorControl1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.calculatorControl1.Location = new System.Drawing.Point(1, 27);
            this.calculatorControl1.MetroColor = System.Drawing.SystemColors.Control;
            this.calculatorControl1.Name = "calculatorControl1";
            this.calculatorControl1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.calculatorControl1.Size = new System.Drawing.Size(200, 316);
            this.calculatorControl1.TabIndex = 0;
            this.calculatorControl1.Text = "calculatorControl1";
            this.calculatorControl1.UseVisualStyle = true;
            // 
            // groupBarItem1
            // 
            this.groupBarItem1.Client = null;
            this.groupBarItem1.Text = "GroupBarItem0";
            // 
            // groupBarItem2
            // 
            this.groupBarItem2.Client = null;
            this.groupBarItem2.Text = "GroupBarItem1";
            // 
            // groupBarItem3
            // 
            this.groupBarItem3.Client = null;
            this.groupBarItem3.Text = "GroupBarItem2";
            // 
            // groupBarItem4
            // 
            this.groupBarItem4.Client = this.calculatorControl1;
            this.groupBarItem4.Text = "GroupBarItem3";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Form",
            "DockingManager",
            "GroupBar",
            "Calculator"});
            this.comboBox1.Location = new System.Drawing.Point(140, 30);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(149, 21);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.comboBox1.TextChanged += new System.EventHandler(this.comboBox1_TextChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Office 2007 Blue",
            "Office 2007 Black",
            "Office 2007 Silver",
            "Managed"});
            this.comboBox2.Location = new System.Drawing.Point(141, 68);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(147, 21);
            this.comboBox2.TabIndex = 4;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            this.comboBox2.TextChanged += new System.EventHandler(this.comboBox2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Parent Control";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(49, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Visual Theme";
            // 
            // xpTaskPane1
            // 
            this.xpTaskPane1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.xpTaskPane1.Controls.Add(this.wizardContainer1);
            // 
            // 
            // 
            this.xpTaskPane1.Header.BackColor = System.Drawing.Color.Transparent;
            this.xpTaskPane1.Header.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.xpTaskPane1.Header.Controls.Add(this.xpTaskPane1.HeaderLabel);
            this.xpTaskPane1.Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.xpTaskPane1.Header.Location = new System.Drawing.Point(0, 0);
            this.xpTaskPane1.Header.Name = "header";
            this.xpTaskPane1.Header.Size = new System.Drawing.Size(354, 22);
            this.xpTaskPane1.Header.TabIndex = 2;
            this.xpTaskPane1.Location = new System.Drawing.Point(221, 216);
            this.xpTaskPane1.MetroColor = System.Drawing.Color.White;
            this.xpTaskPane1.Name = "xpTaskPane1";
            this.xpTaskPane1.SelectedPage = this.xpTaskPage1;
            this.xpTaskPane1.Size = new System.Drawing.Size(358, 278);
            this.xpTaskPane1.TabIndex = 7;
            this.xpTaskPane1.TaskPages = new Syncfusion.Windows.Forms.Tools.XPTaskPage[] {
        this.xpTaskPage1};
            this.xpTaskPane1.TaskPanePageContainer = this.wizardContainer1;
            this.xpTaskPane1.VisualStyle = Syncfusion.Windows.Forms.VisualStyle.Office2007;
            // 
            // wizardContainer1
            // 
            this.wizardContainer1.Controls.Add(this.xpTaskPage1);
            this.wizardContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wizardContainer1.Location = new System.Drawing.Point(0, 22);
            this.wizardContainer1.Name = "wizardContainer1";
            this.wizardContainer1.Size = new System.Drawing.Size(354, 252);
            this.wizardContainer1.TabIndex = 6;
            // 
            // xpTaskPage1
            // 
            this.xpTaskPage1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(146)))), ((int)(((byte)(206)))));
            this.xpTaskPage1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.xpTaskPage1.Controls.Add(this.colorPickerUIAdv1);
            this.xpTaskPage1.LayoutName = "Card1";
            this.xpTaskPage1.Location = new System.Drawing.Point(0, 0);
            this.xpTaskPage1.Name = "xpTaskPage1";
            this.xpTaskPage1.NextPage = null;
            this.xpTaskPage1.PreviousPage = null;
            this.xpTaskPage1.Size = new System.Drawing.Size(354, 252);
            this.xpTaskPage1.TabIndex = 0;
            this.xpTaskPage1.Title = "Page Title";
            // 
            // colorPickerUIAdv1.RecentGroup
            // 
            this.colorPickerUIAdv1.RecentGroup.Name = "Recent Colors";
            this.colorPickerUIAdv1.RecentGroup.Visible = false;
            // 
            // colorPickerUIAdv1.StandardGroup
            // 
            this.colorPickerUIAdv1.StandardGroup.Name = "Standard Colors";
            // 
            // colorPickerUIAdv1.ThemeGroup
            // 
            this.colorPickerUIAdv1.ThemeGroup.IsSubItemsVisible = true;
            this.colorPickerUIAdv1.ThemeGroup.Name = "Theme Colors";
            // 
            // colorPickerUIAdv1
            // 
            this.colorPickerUIAdv1.BeforeTouchSize = new System.Drawing.Size(13, 13);
            this.colorPickerUIAdv1.ColorItemSize = new System.Drawing.Size(13, 13);
            this.colorPickerUIAdv1.HorizontalItemsSpacing = 19;
            this.colorPickerUIAdv1.Location = new System.Drawing.Point(15, 3);
            this.colorPickerUIAdv1.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.colorPickerUIAdv1.MinimumSize = new System.Drawing.Size(136, 195);
            this.colorPickerUIAdv1.Name = "colorPickerUIAdv1";
            this.colorPickerUIAdv1.SelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(190)))), ((int)(((byte)(140)))));
            this.colorPickerUIAdv1.Size = new System.Drawing.Size(307, 207);
            this.colorPickerUIAdv1.Style = Syncfusion.Windows.Forms.Tools.ColorPickerUIAdv.visualstyle.Default;
            this.colorPickerUIAdv1.TabIndex = 0;
            this.colorPickerUIAdv1.Text = "colorPickerUIAdv1";
            this.colorPickerUIAdv1.UseOffice2007Style = false;
            this.colorPickerUIAdv1.VerticalItemsSpacing = 3;
            this.colorPickerUIAdv1.Picked += new Syncfusion.Windows.Forms.Tools.ColorPickerUIAdv.ColorPickedEventHandler(this.colorPickerUIAdv1_Picked);
            // 
            // gradientPanelExt1
            // 
            this.gradientPanelExt1.BackColor = System.Drawing.Color.Transparent;
            this.gradientPanelExt1.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.ForwardDiagonal, System.Drawing.SystemColors.GradientInactiveCaption, System.Drawing.SystemColors.GradientInactiveCaption);
            this.gradientPanelExt1.Border = new System.Windows.Forms.Padding(12);
            this.gradientPanelExt1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gradientPanelExt1.Controls.Add(this.autoLabel1);
            this.gradientPanelExt1.Controls.Add(this.label2);
            this.gradientPanelExt1.Controls.Add(this.label1);
            this.gradientPanelExt1.Controls.Add(this.comboBox2);
            this.gradientPanelExt1.Controls.Add(this.comboBox1);
            this.gradientPanelExt1.Location = new System.Drawing.Point(218, 45);
            this.gradientPanelExt1.Name = "gradientPanelExt1";
            this.gradientPanelExt1.Size = new System.Drawing.Size(359, 162);
            this.gradientPanelExt1.TabIndex = 12;
            // 
            // autoLabel1
            // 
            this.autoLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoLabel1.Location = new System.Drawing.Point(57, 116);
            this.autoLabel1.Name = "autoLabel1";
            this.autoLabel1.Size = new System.Drawing.Size(244, 15);
            this.autoLabel1.TabIndex = 10;
            this.autoLabel1.Text = "Use Color Picker for Managed Colors";
            this.autoLabel1.Visible = false;
            this.autoLabel1.Click += new System.EventHandler(this.autoLabel1_Click);
            // 
            // toolStripEx1
            // 
            this.toolStripEx1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.toolStripEx1.Image = null;
            this.toolStripEx1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripLabel2});
            this.toolStripEx1.Location = new System.Drawing.Point(0, 0);
            this.toolStripEx1.Name = "toolStripEx1";
            this.toolStripEx1.Size = new System.Drawing.Size(639, 40);
            this.toolStripEx1.TabIndex = 0;
            this.toolStripEx1.Text = "Syncfusion";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(25, 22);
            this.toolStripLabel1.Text = "File";
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(27, 22);
            this.toolStripLabel2.Text = "Edit";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.ClientSize = new System.Drawing.Size(639, 539);
            this.Controls.Add(this.xpTaskPane1);
            this.Controls.Add(this.toolStripEx1);
            this.Controls.Add(this.gradientPanelExt1);
            this.DropShadow = true;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SkinManager Demo";
            ((System.ComponentModel.ISupportInitialize)(this.dockingManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBar1)).EndInit();
            this.groupBar1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.xpTaskPane1.Header)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpTaskPane1)).EndInit();
            this.xpTaskPane1.ResumeLayout(false);
            this.wizardContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.xpTaskPage1)).EndInit();
            this.xpTaskPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanelExt1)).EndInit();
            this.gradientPanelExt1.ResumeLayout(false);
            this.gradientPanelExt1.PerformLayout();
            this.toolStripEx1.ResumeLayout(false);
            this.toolStripEx1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Syncfusion.Windows.Forms.Tools.GroupBar groupBar1;
        private Syncfusion.Windows.Forms.Tools.CalculatorControl calculatorControl1;
        private Syncfusion.Windows.Forms.Tools.GroupBarItem groupBarItem1;
        private Syncfusion.Windows.Forms.Tools.GroupBarItem groupBarItem2;
        private Syncfusion.Windows.Forms.Tools.GroupBarItem groupBarItem3;
        private Syncfusion.Windows.Forms.Tools.GroupBarItem groupBarItem4;
        private Syncfusion.Windows.Forms.Tools.DockingManager dockingManager1;
        private Syncfusion.Windows.Forms.Tools.XPTaskPane xpTaskPane1;
        private Syncfusion.Windows.Forms.Tools.WizardContainer wizardContainer1;
        private Syncfusion.Windows.Forms.Tools.XPTaskPage xpTaskPage1;
        private Syncfusion.Windows.Forms.Tools.ColorPickerUIAdv colorPickerUIAdv1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private Syncfusion.Windows.Forms.Tools.GradientPanelExt gradientPanelExt1;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel1;
        private Syncfusion.Windows.Forms.Tools.ToolStripEx toolStripEx1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
    }
}


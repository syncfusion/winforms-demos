#region Copyright Syncfusion Inc. 2001 - 2015
// Copyright Syncfusion Inc. 2001 - 2015. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Syncfusion.Windows.Forms;
using System.Drawing;
namespace PortfolioManager
{
    partial class DashBoard
    {
        #region "API Definition"

        private Syncfusion.Windows.Forms.Tools.ToolStripEx dashBoardToolStrip;
        private Syncfusion.Windows.Forms.Grid.Grouping.GridGroupingControl Grid;
        private Syncfusion.Windows.Forms.Tools.GradientPanel addPortfolioPanel;
        private Syncfusion.Windows.Forms.ButtonAdv addPortfolioButton;
        private System.Windows.Forms.Label accountLabel;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv accountsComboBox;
        private Syncfusion.Windows.Forms.Tools.CheckBoxAdv priceLookUpCheckBox;
        private System.Windows.Forms.Label priceLabel;
        private Syncfusion.Windows.Forms.Tools.DoubleTextBox priceDoubleTextBox;
        private Syncfusion.Windows.Forms.Tools.NumericTextBox quantityTextBox;
        private System.Windows.Forms.Label quantityLabel;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt symbolTextBox;
        private System.Windows.Forms.Label symbolLabel;
        private System.Windows.Forms.ToolStripLabel detailViewToolStripLabel;
        private System.Windows.Forms.ToolStripLabel overViewToolStripLabel;
        private System.Windows.Forms.ToolStripLabel Industry_SectorViewtoolStripLabel;
        private Syncfusion.Windows.Forms.Tools.ImageListAdv dashboardImageList;
        private Syncfusion.Windows.Forms.Tools.AutoComplete symbolAutoComplete;
        private System.Windows.Forms.ToolStripLabel exchangeViewToolStripLabel;
        private System.Windows.Forms.Label exchangeLabel;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv exchangeComboBox;
        private Syncfusion.Windows.Forms.Tools.DockingManager dockingManager;
        private Syncfusion.Windows.Forms.Tools.DockingClientPanel dockingClientPanel1;
        private System.Windows.Forms.ImageList dashBoardImages16;
        private System.Windows.Forms.ImageList dashBoardImages24;


        #endregion

        #region "Designer Stuffs"

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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashBoard));
            Syncfusion.Windows.Forms.Tools.CaptionButtonsCollection ccbaddPortfolioPanel = new Syncfusion.Windows.Forms.Tools.CaptionButtonsCollection();
            this.dockingManager = new Syncfusion.Windows.Forms.Tools.DockingManager(this.components);
            this.dashBoardImages24 = new System.Windows.Forms.ImageList(this.components);
            this.addPortfolioPanel = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            this.exchangeComboBox = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.exchangeLabel = new System.Windows.Forms.Label();
            this.addPortfolioButton = new Syncfusion.Windows.Forms.ButtonAdv();
            this.accountLabel = new System.Windows.Forms.Label();
            this.accountsComboBox = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.priceLookUpCheckBox = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.priceLabel = new System.Windows.Forms.Label();
            this.priceDoubleTextBox = new Syncfusion.Windows.Forms.Tools.DoubleTextBox();
            this.quantityTextBox = new Syncfusion.Windows.Forms.Tools.NumericTextBox();
            this.quantityLabel = new System.Windows.Forms.Label();
            this.symbolTextBox = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.symbolLabel = new System.Windows.Forms.Label();
            this.dashBoardToolStrip = new Syncfusion.Windows.Forms.Tools.ToolStripEx();
            this.overViewToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.detailViewToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.Industry_SectorViewtoolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.exchangeViewToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.Grid = new Syncfusion.Windows.Forms.Grid.Grouping.GridGroupingControl();
            this.dashboardImageList = new Syncfusion.Windows.Forms.Tools.ImageListAdv(this.components);
            this.symbolAutoComplete = new Syncfusion.Windows.Forms.Tools.AutoComplete(this.components);
            this.dockingClientPanel1 = new Syncfusion.Windows.Forms.Tools.DockingClientPanel();
            this.dashBoardImages16 = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dockingManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addPortfolioPanel)).BeginInit();
            this.addPortfolioPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exchangeComboBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountsComboBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceLookUpCheckBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceDoubleTextBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantityTextBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.symbolTextBox)).BeginInit();
            this.dashBoardToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.symbolAutoComplete)).BeginInit();
            this.dockingClientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dockingManager
            // 
            this.dockingManager.ActiveCaptionBackground = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226))))));
            this.dockingManager.ActiveCaptionFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            this.dockingManager.BorderColor = System.Drawing.Color.White;
            this.dockingManager.CloseEnabled = false;
            this.dockingManager.DockLayoutStream = ((System.IO.MemoryStream)(resources.GetObject("dockingManager.DockLayoutStream")));
            this.dockingManager.EnableAutoAdjustCaption = true;
            this.dockingManager.HostControl = this;
            this.dockingManager.ImageList = this.dashBoardImages24;
            this.dockingManager.InActiveCaptionBackground = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212))))));
            this.dockingManager.InActiveCaptionFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            this.dockingManager.MetroButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dockingManager.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218)))));
            this.dockingManager.MetroSplitterBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(159)))), ((int)(((byte)(183)))));
            this.dockingManager.Office2007Theme = Syncfusion.Windows.Forms.Office2007Theme.Managed;
            this.dockingManager.ReduceFlickeringInRtl = false;
            this.dockingManager.ThemesEnabled = true;
            this.dockingManager.VisualStyle = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.dockingManager.CaptionButtons.Add(new Syncfusion.Windows.Forms.Tools.CaptionButton(Syncfusion.Windows.Forms.Tools.CaptionButtonType.Close, "CloseButton"));
            this.dockingManager.CaptionButtons.Add(new Syncfusion.Windows.Forms.Tools.CaptionButton(Syncfusion.Windows.Forms.Tools.CaptionButtonType.Pin, "PinButton"));
            this.dockingManager.CaptionButtons.Add(new Syncfusion.Windows.Forms.Tools.CaptionButton(Syncfusion.Windows.Forms.Tools.CaptionButtonType.Menu, "MenuButton"));
            this.dockingManager.CaptionButtons.Add(new Syncfusion.Windows.Forms.Tools.CaptionButton(Syncfusion.Windows.Forms.Tools.CaptionButtonType.Maximize, "MaximizeButton"));
            this.dockingManager.CaptionButtons.Add(new Syncfusion.Windows.Forms.Tools.CaptionButton(Syncfusion.Windows.Forms.Tools.CaptionButtonType.Restore, "RestoreButton"));
            this.dockingManager.SetDockLabel(this.addPortfolioPanel, "Add new stocks");
            this.dockingManager.SetDockIcon(this.addPortfolioPanel, 17);
            this.dockingManager.SetEnableDocking(this.addPortfolioPanel, true);
            ccbaddPortfolioPanel.MergeWith(this.dockingManager.CaptionButtons, false);
            this.dockingManager.SetCustomCaptionButtons(this.addPortfolioPanel, ccbaddPortfolioPanel);
            // 
            // dashBoardImages24
            // 
            this.dashBoardImages24.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("dashBoardImages24.ImageStream")));
            this.dashBoardImages24.TransparentColor = System.Drawing.Color.Transparent;
            this.dashBoardImages24.Images.SetKeyName(0, "AmericanFunds.png");
            this.dashBoardImages24.Images.SetKeyName(1, "Children-College-Savings.png");
            this.dashBoardImages24.Images.SetKeyName(2, "Day-Trading.png");
            this.dashBoardImages24.Images.SetKeyName(3, "Fidelity-Funds.png");
            this.dashBoardImages24.Images.SetKeyName(4, "Retirement-Savings.png");
            this.dashBoardImages24.Images.SetKeyName(5, "Schwab-Funds.png");
            this.dashBoardImages24.Images.SetKeyName(6, "Vanguard-Funds.png");
            this.dashBoardImages24.Images.SetKeyName(7, "Australian-Stock-Exchange.png");
            this.dashBoardImages24.Images.SetKeyName(8, "Bombay-Stock-Exchange-2.png");
            this.dashBoardImages24.Images.SetKeyName(9, "Franfurt-Stock-Exchange.png");
            this.dashBoardImages24.Images.SetKeyName(10, "Hong-Kong-Futures-Exchange.png");
            this.dashBoardImages24.Images.SetKeyName(11, "London-Stock-Exchange.png");
            this.dashBoardImages24.Images.SetKeyName(12, "New-York-Stock-Exchange.png");
            this.dashBoardImages24.Images.SetKeyName(13, "Paris-Stock-Exchange.png");
            this.dashBoardImages24.Images.SetKeyName(14, "Russian-Stock-Exchange.png");
            this.dashBoardImages24.Images.SetKeyName(15, "Swiss-Exchange.png");
            this.dashBoardImages24.Images.SetKeyName(16, "Tokyo-Stock-Exchange.png");
            this.dashBoardImages24.Images.SetKeyName(17, "Add-New-Stock-icon.png");
            // 
            // addPortfolioPanel
            // 
            this.addPortfolioPanel.AutoScroll = true;
            this.addPortfolioPanel.BackColor = System.Drawing.Color.Transparent;
            this.addPortfolioPanel.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.White, System.Drawing.Color.White);
            this.addPortfolioPanel.BorderColor = System.Drawing.Color.White;
            this.addPortfolioPanel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.addPortfolioPanel.Controls.Add(this.exchangeComboBox);
            this.addPortfolioPanel.Controls.Add(this.exchangeLabel);
            this.addPortfolioPanel.Controls.Add(this.addPortfolioButton);
            this.addPortfolioPanel.Controls.Add(this.accountLabel);
            this.addPortfolioPanel.Controls.Add(this.accountsComboBox);
            this.addPortfolioPanel.Controls.Add(this.priceLookUpCheckBox);
            this.addPortfolioPanel.Controls.Add(this.priceLabel);
            this.addPortfolioPanel.Controls.Add(this.priceDoubleTextBox);
            this.addPortfolioPanel.Controls.Add(this.quantityTextBox);
            this.addPortfolioPanel.Controls.Add(this.quantityLabel);
            this.addPortfolioPanel.Controls.Add(this.symbolTextBox);
            this.addPortfolioPanel.Controls.Add(this.symbolLabel);
            this.addPortfolioPanel.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.addPortfolioPanel.Location = new System.Drawing.Point(1, 35);
            this.addPortfolioPanel.Name = "addPortfolioPanel";
            this.addPortfolioPanel.Size = new System.Drawing.Size(360, 371);
            this.addPortfolioPanel.TabIndex = 2;
            // 
            // exchangeComboBox
            // 
            this.exchangeComboBox.BackColor = System.Drawing.Color.White;
            this.exchangeComboBox.BeforeTouchSize = new System.Drawing.Size(138, 33);
            this.exchangeComboBox.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.exchangeComboBox.Location = new System.Drawing.Point(150, 261);
            this.exchangeComboBox.Name = "exchangeComboBox";
            this.exchangeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.exchangeComboBox.Size = new System.Drawing.Size(200, 33);
            this.exchangeComboBox.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.exchangeComboBox.TabIndex = 11;
            // 
            // exchangeLabel
            // 
            this.exchangeLabel.AutoSize = true;
            this.exchangeLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exchangeLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.exchangeLabel.Location = new System.Drawing.Point(6, 261);
            this.exchangeLabel.Name = "exchangeLabel";
            this.exchangeLabel.Size = new System.Drawing.Size(133, 25);
            this.exchangeLabel.TabIndex = 10;
            this.exchangeLabel.Text = "StockExchange";
            // 
            // addPortfolioButton
            // 
            this.addPortfolioButton.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.addPortfolioButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(152)))), ((int)(((byte)(218)))));
            this.addPortfolioButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.addPortfolioButton.BeforeTouchSize = new System.Drawing.Size(128, 42);
            this.addPortfolioButton.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.None;
            this.addPortfolioButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.addPortfolioButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addPortfolioButton.IsBackStageButton = false;
            this.addPortfolioButton.Location = new System.Drawing.Point(67, 308);
            this.addPortfolioButton.Name = "addPortfolioButton";
            this.addPortfolioButton.Size = new System.Drawing.Size(250, 42);
            this.addPortfolioButton.TabIndex = 9;
            this.addPortfolioButton.Text = "Add to portfolio";
            this.addPortfolioButton.UseVisualStyle = true;
            this.addPortfolioButton.UseVisualStyleBackColor = true;
            this.addPortfolioButton.Click += new System.EventHandler(this.addPortfolioButton_Click);
            // 
            // accountLabel
            // 
            this.accountLabel.AutoSize = true;
            this.accountLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.accountLabel.Location = new System.Drawing.Point(46, 220);
            this.accountLabel.Name = "accountLabel";
            this.accountLabel.Size = new System.Drawing.Size(80, 25);
            this.accountLabel.TabIndex = 8;
            this.accountLabel.Text = "Account";
            // 
            // accountsComboBox
            // 
            this.accountsComboBox.BackColor = System.Drawing.Color.White;
            this.accountsComboBox.BeforeTouchSize = new System.Drawing.Size(138, 33);
            this.accountsComboBox.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.accountsComboBox.Location = new System.Drawing.Point(150, 220);
            this.accountsComboBox.Name = "accountsComboBox";
            this.accountsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.accountsComboBox.Size = new System.Drawing.Size(200, 33);
            this.accountsComboBox.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.accountsComboBox.TabIndex = 7;
            // 
            // priceLookUpCheckBox
            // 
            this.priceLookUpCheckBox.BeforeTouchSize = new System.Drawing.Size(228, 39);
            this.priceLookUpCheckBox.DrawFocusRectangle = false;
            this.priceLookUpCheckBox.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.priceLookUpCheckBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.priceLookUpCheckBox.Location = new System.Drawing.Point(23, 166);
            this.priceLookUpCheckBox.MetroColor = System.Drawing.Color.Blue;
            this.priceLookUpCheckBox.Name = "priceLookUpCheckBox";
            this.priceLookUpCheckBox.Size = new System.Drawing.Size(300, 39);
            this.priceLookUpCheckBox.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.priceLookUpCheckBox.TabIndex = 6;
            this.priceLookUpCheckBox.Text = "Use the current market price";
            this.priceLookUpCheckBox.ThemesEnabled = false;
            this.priceLookUpCheckBox.CheckStateChanged += new System.EventHandler(this.priceLookUpCheckBox_CheckStateChanged);
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.priceLabel.Location = new System.Drawing.Point(64, 125);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(53, 25);
            this.priceLabel.TabIndex = 5;
            this.priceLabel.Text = "Price";
            // 
            // priceDoubleTextBox
            // 
            this.priceDoubleTextBox.BackGroundColor = System.Drawing.SystemColors.Window;
            this.priceDoubleTextBox.BeforeTouchSize = new System.Drawing.Size(138, 32);
            this.priceDoubleTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.priceDoubleTextBox.DoubleValue = 0D;
            this.priceDoubleTextBox.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.priceDoubleTextBox.Location = new System.Drawing.Point(150, 125);
            this.priceDoubleTextBox.Metrocolor = System.Drawing.Color.Empty;
            this.priceDoubleTextBox.Name = "priceDoubleTextBox";
            this.priceDoubleTextBox.NullString = "0.0";
            this.priceDoubleTextBox.OverflowIndicatorToolTipText = null;
            this.priceDoubleTextBox.Size = new System.Drawing.Size(138, 32);
            this.priceDoubleTextBox.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.priceDoubleTextBox.TabIndex = 4;
            this.priceDoubleTextBox.Text = "0.00";
            // 
            // quantityTextBox
            // 
            this.quantityTextBox.BeforeTouchSize = new System.Drawing.Size(138, 32);
            this.quantityTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.quantityTextBox.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.quantityTextBox.Location = new System.Drawing.Point(150, 81);
            this.quantityTextBox.Metrocolor = System.Drawing.Color.Empty;
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.OverflowIndicatorToolTipText = null;
            this.quantityTextBox.Size = new System.Drawing.Size(138, 32);
            this.quantityTextBox.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.quantityTextBox.TabIndex = 3;
            this.quantityTextBox.Text = "0";
            this.quantityTextBox.Enter += new System.EventHandler(this.quantityTextBox_Enter);
            this.quantityTextBox.Leave += new System.EventHandler(this.quantityTextBox_Leave);
            // 
            // quantityLabel
            // 
            this.quantityLabel.AutoSize = true;
            this.quantityLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantityLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.quantityLabel.Location = new System.Drawing.Point(44, 81);
            this.quantityLabel.Name = "quantityLabel";
            this.quantityLabel.Size = new System.Drawing.Size(85, 25);
            this.quantityLabel.TabIndex = 2;
            this.quantityLabel.Text = "Quantity";
            // 
            // symbolTextBox
            // 
            this.symbolAutoComplete.SetAutoComplete(this.symbolTextBox, Syncfusion.Windows.Forms.Tools.AutoCompleteModes.MultiSuggest);
            this.symbolTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.symbolTextBox.BeforeTouchSize = new System.Drawing.Size(138, 32);
            this.symbolTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.symbolTextBox.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.symbolTextBox.Location = new System.Drawing.Point(150, 30);
            this.symbolTextBox.Metrocolor = System.Drawing.Color.Empty;
            this.symbolTextBox.Name = "symbolTextBox";
            this.symbolTextBox.OverflowIndicatorToolTipText = null;
            this.symbolTextBox.Size = new System.Drawing.Size(138, 32);
            this.symbolTextBox.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.symbolTextBox.TabIndex = 0;
            this.symbolTextBox.Text = "Symbol";
            this.symbolTextBox.Enter += new System.EventHandler(this.symbolTextBox_Enter);
            this.symbolTextBox.Leave += new System.EventHandler(this.symbolTextBox_Leave);
            // 
            // symbolLabel
            // 
            this.symbolLabel.AutoSize = true;
            this.symbolLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.symbolLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.symbolLabel.Location = new System.Drawing.Point(10, 30);
            this.symbolLabel.Name = "symbolLabel";
            this.symbolLabel.Size = new System.Drawing.Size(128, 25);
            this.symbolLabel.TabIndex = 1;
            this.symbolLabel.Text = "Symbol Name";
            // 
            // dashBoardToolStrip
            // 
            this.dashBoardToolStrip.AutoSize = false;
            this.dashBoardToolStrip.BackColor = System.Drawing.Color.White;
            this.dashBoardToolStrip.CaptionAlignment = Syncfusion.Windows.Forms.Tools.CaptionAlignment.Near;
            this.dashBoardToolStrip.CaptionFont = new System.Drawing.Font("Segoe UI", 10F);
            this.dashBoardToolStrip.CaptionStyle = Syncfusion.Windows.Forms.Tools.CaptionStyle.Top;
            this.dashBoardToolStrip.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dashBoardToolStrip.ForeColor = System.Drawing.Color.MidnightBlue;
            this.dashBoardToolStrip.Image = null;
            this.dashBoardToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.overViewToolStripLabel,
            this.detailViewToolStripLabel,
            this.Industry_SectorViewtoolStripLabel,
            this.exchangeViewToolStripLabel});
            this.dashBoardToolStrip.LauncherStyle = Syncfusion.Windows.Forms.Tools.LauncherStyle.Metro;
            this.dashBoardToolStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.dashBoardToolStrip.Location = new System.Drawing.Point(0, 0);
            this.dashBoardToolStrip.Name = "dashBoardToolStrip";
            this.dashBoardToolStrip.Office12Mode = false;
            this.dashBoardToolStrip.OfficeColorScheme = Syncfusion.Windows.Forms.Tools.ToolStripEx.ColorScheme.Silver;
            this.dashBoardToolStrip.ShowCaption = false;
            this.dashBoardToolStrip.Size = new System.Drawing.Size(781, 40);
            this.dashBoardToolStrip.Stretch = true;
            this.dashBoardToolStrip.TabIndex = 0;
            this.dashBoardToolStrip.Text = "VIEWS";
            this.dashBoardToolStrip.VisualStyle = Syncfusion.Windows.Forms.Tools.ToolStripExStyle.Metro;
            // 
            // overViewToolStripLabel
            // 
            this.overViewToolStripLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.overViewToolStripLabel.IsLink = true;
            this.overViewToolStripLabel.Name = "overViewToolStripLabel";
            this.overViewToolStripLabel.Size = new System.Drawing.Size(95, 35);
            this.overViewToolStripLabel.Text = "OverView";
            this.overViewToolStripLabel.Click += new System.EventHandler(this.overViewToolStripLabel_Click);
            // 
            // detailViewToolStripLabel
            // 
            this.detailViewToolStripLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.detailViewToolStripLabel.IsLink = true;
            this.detailViewToolStripLabel.Name = "detailViewToolStripLabel";
            this.detailViewToolStripLabel.Size = new System.Drawing.Size(104, 35);
            this.detailViewToolStripLabel.Text = "DetailView";
            this.detailViewToolStripLabel.Click += new System.EventHandler(this.detailViewToolStripLabel_Click);
            // 
            // Industry_SectorViewtoolStripLabel
            // 
            this.Industry_SectorViewtoolStripLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Industry_SectorViewtoolStripLabel.IsLink = true;
            this.Industry_SectorViewtoolStripLabel.Name = "Industry_SectorViewtoolStripLabel";
            this.Industry_SectorViewtoolStripLabel.Size = new System.Drawing.Size(188, 35);
            this.Industry_SectorViewtoolStripLabel.Text = "Industry/SectorView";
            this.Industry_SectorViewtoolStripLabel.Click += new System.EventHandler(this.Industry_SectorViewtoolStripLabel_Click);
            // 
            // exchangeViewToolStripLabel
            // 
            this.exchangeViewToolStripLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.exchangeViewToolStripLabel.IsLink = true;
            this.exchangeViewToolStripLabel.Name = "exchangeViewToolStripLabel";
            this.exchangeViewToolStripLabel.Size = new System.Drawing.Size(183, 35);
            this.exchangeViewToolStripLabel.Text = "StockExchangeView";
            this.exchangeViewToolStripLabel.Click += new System.EventHandler(this.exchangeViewToolStripLabel_Click);
            // 
            // Grid
            // 
            this.Grid.BackColor = System.Drawing.SystemColors.Window;
            this.Grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Grid.FreezeCaption = false;
            this.Grid.GridOfficeScrollBars = Syncfusion.Windows.Forms.OfficeScrollBars.Metro;
            this.Grid.Location = new System.Drawing.Point(0, 0);
            this.Grid.Name = "Grid";
            this.Grid.Size = new System.Drawing.Size(415, 407);
            this.Grid.TabIndex = 4;
            // 
            // dashboardImageList
            // 
            this.dashboardImageList.Images.AddRange(new System.Drawing.Image[] {
            ((System.Drawing.Image)(resources.GetObject("dashboardImageList.Images"))),
            ((System.Drawing.Image)(resources.GetObject("dashboardImageList.Images1"))),
            ((System.Drawing.Image)(resources.GetObject("dashboardImageList.Images2"))),
            ((System.Drawing.Image)(resources.GetObject("dashboardImageList.Images3"))),
            ((System.Drawing.Image)(resources.GetObject("dashboardImageList.Images4")))});
            this.dashboardImageList.ImageSize = new System.Drawing.Size(32, 32);
            this.dashboardImageList.UseImageSize = false;
            // 
            // symbolAutoComplete
            // 
            this.symbolAutoComplete.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218)))));
            this.symbolAutoComplete.PreferredWidth = 200;
            this.symbolAutoComplete.SingleClick = true;
            this.symbolAutoComplete.Style = Syncfusion.Windows.Forms.Tools.AutoCompleteStyle.Default;
            this.symbolAutoComplete.TextColor = System.Drawing.Color.Black;
            // 
            // dockingClientPanel1
            // 
            this.dockingClientPanel1.BackColor = System.Drawing.Color.White;
            this.dockingClientPanel1.Controls.Add(this.Grid);
            this.dockingClientPanel1.Location = new System.Drawing.Point(0, 40);
            this.dockingClientPanel1.Name = "dockingClientPanel1";
            this.dockingClientPanel1.Size = new System.Drawing.Size(415, 407);
            this.dockingClientPanel1.SizeToFit = true;
            this.dockingClientPanel1.TabIndex = 7;
            // 
            // dashBoardImages16
            // 
            this.dashBoardImages16.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("dashBoardImages16.ImageStream")));
            this.dashBoardImages16.TransparentColor = System.Drawing.Color.Transparent;
            this.dashBoardImages16.Images.SetKeyName(0, "basicMaterials.png");
            this.dashBoardImages16.Images.SetKeyName(1, "Consumer-Goods.png");
            this.dashBoardImages16.Images.SetKeyName(2, "finance.png");
            this.dashBoardImages16.Images.SetKeyName(3, "Healthcare.png");
            this.dashBoardImages16.Images.SetKeyName(4, "Industrial-Goods.png");
            this.dashBoardImages16.Images.SetKeyName(5, "Services.png");
            this.dashBoardImages16.Images.SetKeyName(6, "Technology.png");
            this.dashBoardImages16.Images.SetKeyName(7, "Utilities.png");
            this.dashBoardImages16.Images.SetKeyName(8, "agriculturalChemicals.png");
            this.dashBoardImages16.Images.SetKeyName(9, "aluminium.png");
            this.dashBoardImages16.Images.SetKeyName(10, "copper.png");
            this.dashBoardImages16.Images.SetKeyName(11, "gold.png");
            this.dashBoardImages16.Images.SetKeyName(12, "oil-&-gas.png");
            this.dashBoardImages16.Images.SetKeyName(13, "Silver.png");
            this.dashBoardImages16.Images.SetKeyName(14, "steel-&-iron.png");
            this.dashBoardImages16.Images.SetKeyName(15, "Appliances.png");
            this.dashBoardImages16.Images.SetKeyName(16, "Automotive-Manufacturers-1.png");
            this.dashBoardImages16.Images.SetKeyName(17, "Business-Equipment.png");
            this.dashBoardImages16.Images.SetKeyName(18, "Elecronic-Equipment-2.png");
            this.dashBoardImages16.Images.SetKeyName(19, "Sporting-Goods.png");
            this.dashBoardImages16.Images.SetKeyName(20, "Toys-&-Games.png");
            this.dashBoardImages16.Images.SetKeyName(21, "Accidents-&-Health-Insurance-2.png");
            this.dashBoardImages16.Images.SetKeyName(22, "Asst-management.png");
            this.dashBoardImages16.Images.SetKeyName(23, "Insurance-Brokers.png");
            this.dashBoardImages16.Images.SetKeyName(24, "Invesement.png");
            this.dashBoardImages16.Images.SetKeyName(25, "Real-Estate.png");
            this.dashBoardImages16.Images.SetKeyName(26, "Life-Insurance-2.png");
            this.dashBoardImages16.Images.SetKeyName(27, "Biotechnology.png");
            this.dashBoardImages16.Images.SetKeyName(28, "Healthcare-Plans.png");
            this.dashBoardImages16.Images.SetKeyName(29, "Hospital.png");
            this.dashBoardImages16.Images.SetKeyName(30, "Medical-Appliances-&-Equipment.png");
            this.dashBoardImages16.Images.SetKeyName(31, "Medical-Instruments-&-Supplies.png");
            this.dashBoardImages16.Images.SetKeyName(32, "MedicalPractitioners.png");
            this.dashBoardImages16.Images.SetKeyName(33, "Aerospace-&-Defense-Product-&-Services.png");
            this.dashBoardImages16.Images.SetKeyName(34, "cement.png");
            this.dashBoardImages16.Images.SetKeyName(35, "General-Building-Materials.png");
            this.dashBoardImages16.Images.SetKeyName(36, "Heavy-Construction.png");
            this.dashBoardImages16.Images.SetKeyName(37, "Manufactured-Housing.png");
            this.dashBoardImages16.Images.SetKeyName(38, "Metal-Fabrication.png");
            this.dashBoardImages16.Images.SetKeyName(39, "Textile-Industrial.png");
            this.dashBoardImages16.Images.SetKeyName(40, "Waste-Management.png");
            this.dashBoardImages16.Images.SetKeyName(41, "Apparel-Stores.png");
            this.dashBoardImages16.Images.SetKeyName(42, "Consumer-Services.png");
            this.dashBoardImages16.Images.SetKeyName(43, "Deparmental-stores.png");
            this.dashBoardImages16.Images.SetKeyName(44, "ElectronicsStores.png");
            this.dashBoardImages16.Images.SetKeyName(45, "FoodWholeSale-2.png");
            this.dashBoardImages16.Images.SetKeyName(46, "Lodging-3.png");
            this.dashBoardImages16.Images.SetKeyName(47, "MajorAirlines-2.png");
            this.dashBoardImages16.Images.SetKeyName(48, "Regional-Airlines.png");
            this.dashBoardImages16.Images.SetKeyName(49, "Business-Software-&-Services.png");
            this.dashBoardImages16.Images.SetKeyName(50, "Computer-Based-Systems.png");
            this.dashBoardImages16.Images.SetKeyName(51, "Data-Storage-Devices.png");
            this.dashBoardImages16.Images.SetKeyName(52, "Healthcare-Information-Services.png");
            this.dashBoardImages16.Images.SetKeyName(53, "Information-Technology-Services.png");
            this.dashBoardImages16.Images.SetKeyName(54, "Personal-Computers.png");
            this.dashBoardImages16.Images.SetKeyName(55, "Wireless-Communications.png");
            this.dashBoardImages16.Images.SetKeyName(56, "Diversified-Utilities-2.png");
            this.dashBoardImages16.Images.SetKeyName(57, "Electric-Utilities-2.png");
            this.dashBoardImages16.Images.SetKeyName(58, "Foreign-Utilities-2.png");
            this.dashBoardImages16.Images.SetKeyName(59, "Gas-Utilities.png");
            this.dashBoardImages16.Images.SetKeyName(60, "Water-Utilities.png");
            // 
            // DashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.dockingClientPanel1);
            this.Controls.Add(this.dashBoardToolStrip);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.Name = "DashBoard";
            this.Size = new System.Drawing.Size(781, 447);
            ((System.ComponentModel.ISupportInitialize)(this.dockingManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addPortfolioPanel)).EndInit();
            this.addPortfolioPanel.ResumeLayout(false);
            this.addPortfolioPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exchangeComboBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountsComboBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceLookUpCheckBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceDoubleTextBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantityTextBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.symbolTextBox)).EndInit();
            this.dashBoardToolStrip.ResumeLayout(false);
            this.dashBoardToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.symbolAutoComplete)).EndInit();
            this.dockingClientPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        #endregion

    }
}

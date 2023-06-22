#region Copyright Syncfusion Inc. 2001-2023.
// Copyright Syncfusion Inc. 2001-2023. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Syncfusion.Windows.Forms;
namespace PortfolioManager
{
    partial class DashBoard
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
            this.addPortfolioPanel = new Syncfusion.Windows.Forms.Tools.GradientPanelExt();
            this.exchangeComboBox = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.exchangeLabel = new System.Windows.Forms.Label();
            this.addPortfolioButton = new Syncfusion.Windows.Forms.ButtonAdv();
            this.accountLabel = new System.Windows.Forms.Label();
            this.accountsComboBox = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.priceLookUpCheckBox = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.priceLabel = new System.Windows.Forms.Label();
            this.priceDoubleTextBox = new Syncfusion.Windows.Forms.Tools.DoubleTextBox();
            this.quantityTextBox = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
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
            this.dockingManager.HostControl = this;
            this.dockingManager.ImageList = this.dashBoardImages24;
            this.dockingManager.InActiveCaptionFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
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
            this.addPortfolioPanel.BackColor = System.Drawing.Color.Transparent;
            this.addPortfolioPanel.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.White, System.Drawing.Color.White);
            this.addPortfolioPanel.Border = new System.Windows.Forms.Padding(2);
            this.addPortfolioPanel.BorderColor = System.Drawing.Color.White;
            this.addPortfolioPanel.BorderGap = 2;
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
            this.addPortfolioPanel.Location = new System.Drawing.Point(1, 26);
            this.addPortfolioPanel.Name = "addPortfolioPanel";
            this.addPortfolioPanel.Size = new System.Drawing.Size(255, 395);
            this.addPortfolioPanel.TabIndex = 2;
            // 
            // exchangeComboBox
            // 
            this.exchangeComboBox.BackColor = System.Drawing.Color.White;
            this.exchangeComboBox.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exchangeComboBox.Location = new System.Drawing.Point(102, 261);
            this.exchangeComboBox.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218)))));
            this.exchangeComboBox.Name = "exchangeComboBox";
            this.exchangeComboBox.Size = new System.Drawing.Size(123, 21);
            this.exchangeComboBox.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.exchangeComboBox.TabIndex = 11;
            // 
            // exchangeLabel
            // 
            this.exchangeLabel.AutoSize = true;
            this.exchangeLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.exchangeLabel.Location = new System.Drawing.Point(9, 268);
            this.exchangeLabel.Name = "exchangeLabel";
            this.exchangeLabel.Size = new System.Drawing.Size(84, 13);
            this.exchangeLabel.TabIndex = 10;
            this.exchangeLabel.Text = "StockExchange";
            // 
            // addPortfolioButton
            // 
            this.addPortfolioButton.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.addPortfolioButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(163)))), ((int)(((byte)(0)))));
            this.addPortfolioButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.addPortfolioButton.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.None;
            this.addPortfolioButton.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.addPortfolioButton.Location = new System.Drawing.Point(72, 321);
            this.addPortfolioButton.Name = "addPortfolioButton";
            this.addPortfolioButton.Size = new System.Drawing.Size(110, 22);
            this.addPortfolioButton.TabIndex = 9;
            this.addPortfolioButton.Text = "Add to portfolio";
            this.addPortfolioButton.UseVisualStyle = true;
            this.addPortfolioButton.UseVisualStyleBackColor = true;
            this.addPortfolioButton.Click += new System.EventHandler(this.addPortfolioButton_Click);
            // 
            // accountLabel
            // 
            this.accountLabel.AutoSize = true;
            this.accountLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.accountLabel.Location = new System.Drawing.Point(9, 223);
            this.accountLabel.Name = "accountLabel";
            this.accountLabel.Size = new System.Drawing.Size(49, 13);
            this.accountLabel.TabIndex = 8;
            this.accountLabel.Text = "Account";
            // 
            // accountsComboBox
            // 
            this.accountsComboBox.BackColor = System.Drawing.Color.White;
            this.accountsComboBox.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountsComboBox.Location = new System.Drawing.Point(102, 216);
            this.accountsComboBox.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218)))));
            this.accountsComboBox.Name = "accountsComboBox";
            this.accountsComboBox.Size = new System.Drawing.Size(123, 21);
            this.accountsComboBox.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.accountsComboBox.TabIndex = 7;
            // 
            // priceLookUpCheckBox
            // 
            this.priceLookUpCheckBox.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.priceLookUpCheckBox.Location = new System.Drawing.Point(102, 145);
            this.priceLookUpCheckBox.MetroColor = System.Drawing.Color.Blue;
            this.priceLookUpCheckBox.Name = "priceLookUpCheckBox";
            this.priceLookUpCheckBox.Size = new System.Drawing.Size(123, 48);
            this.priceLookUpCheckBox.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.priceLookUpCheckBox.TabIndex = 6;
            this.priceLookUpCheckBox.Text = "Use the current market price";
            this.priceLookUpCheckBox.ThemesEnabled = false;
            this.priceLookUpCheckBox.CheckStateChanged += new System.EventHandler(this.priceLookUpCheckBox_CheckStateChanged);
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.priceLabel.Location = new System.Drawing.Point(9, 125);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(31, 13);
            this.priceLabel.TabIndex = 5;
            this.priceLabel.Text = "Price";
            // 
            // priceDoubleTextBox
            // 
            this.symbolAutoComplete.SetAutoComplete(this.priceDoubleTextBox, Syncfusion.Windows.Forms.Tools.AutoCompleteModes.Disabled);
            this.priceDoubleTextBox.BackGroundColor = System.Drawing.SystemColors.Window;
            this.priceDoubleTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.priceDoubleTextBox.DoubleValue = 0D;
            this.priceDoubleTextBox.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceDoubleTextBox.Location = new System.Drawing.Point(102, 119);
            this.priceDoubleTextBox.Name = "priceDoubleTextBox";
            this.priceDoubleTextBox.NullString = "0.0";
            this.priceDoubleTextBox.OverflowIndicatorToolTipText = null;
            this.priceDoubleTextBox.Size = new System.Drawing.Size(123, 22);
            this.priceDoubleTextBox.TabIndex = 4;
            this.priceDoubleTextBox.Text = "0.00";
            // 
            // quantityTextBox
            // 
            this.symbolAutoComplete.SetAutoComplete(this.quantityTextBox, Syncfusion.Windows.Forms.Tools.AutoCompleteModes.Disabled);
            this.quantityTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.quantityTextBox.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantityTextBox.Location = new System.Drawing.Point(102, 71);
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.OverflowIndicatorToolTipText = null;
            this.quantityTextBox.Size = new System.Drawing.Size(123, 22);
            this.quantityTextBox.TabIndex = 3;
            this.quantityTextBox.Text = "0";
            this.quantityTextBox.Enter += new System.EventHandler(this.quantityTextBox_Enter);
            this.quantityTextBox.Leave += new System.EventHandler(this.quantityTextBox_Leave);
            // 
            // quantityLabel
            // 
            this.quantityLabel.AutoSize = true;
            this.quantityLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.quantityLabel.Location = new System.Drawing.Point(9, 77);
            this.quantityLabel.Name = "quantityLabel";
            this.quantityLabel.Size = new System.Drawing.Size(52, 13);
            this.quantityLabel.TabIndex = 2;
            this.quantityLabel.Text = "Quantity";
            // 
            // symbolTextBox
            // 
            this.symbolAutoComplete.SetAutoComplete(this.symbolTextBox, Syncfusion.Windows.Forms.Tools.AutoCompleteModes.MultiSuggest);
            this.symbolTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.symbolTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.symbolTextBox.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.symbolTextBox.Location = new System.Drawing.Point(102, 30);
            this.symbolTextBox.Name = "symbolTextBox";
            this.symbolTextBox.OverflowIndicatorToolTipText = null;
            this.symbolTextBox.Size = new System.Drawing.Size(123, 22);
            this.symbolTextBox.TabIndex = 0;
            this.symbolTextBox.Text = "Symbol";
            this.symbolTextBox.Enter += new System.EventHandler(this.symbolTextBox_Enter);
            this.symbolTextBox.Leave += new System.EventHandler(this.symbolTextBox_Leave);
            // 
            // symbolLabel
            // 
            this.symbolLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.symbolLabel.Location = new System.Drawing.Point(9, 31);
            this.symbolLabel.Name = "symbolLabel";
            this.symbolLabel.Size = new System.Drawing.Size(100, 18);
            this.symbolLabel.TabIndex = 1;
            this.symbolLabel.Text = "Symbol Name";
            // 
            // dashBoardToolStrip
            // 
            this.dashBoardToolStrip.BackColor = System.Drawing.Color.White;
            this.dashBoardToolStrip.CaptionFont = new System.Drawing.Font("Segoe UI", 8.25F);
            this.dashBoardToolStrip.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashBoardToolStrip.ForeColor = System.Drawing.Color.MidnightBlue;
            this.dashBoardToolStrip.Image = null;
            this.dashBoardToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.overViewToolStripLabel,
            this.detailViewToolStripLabel,
            this.Industry_SectorViewtoolStripLabel,
            this.exchangeViewToolStripLabel});
            this.dashBoardToolStrip.LauncherStyle = Syncfusion.Windows.Forms.Tools.LauncherStyle.Office2007;
            this.dashBoardToolStrip.Location = new System.Drawing.Point(0, 0);
            this.dashBoardToolStrip.Name = "dashBoardToolStrip";
            this.dashBoardToolStrip.OfficeColorScheme = Syncfusion.Windows.Forms.Tools.ToolStripEx.ColorScheme.Silver;
            this.dashBoardToolStrip.ShowCaption = false;
            this.dashBoardToolStrip.Size = new System.Drawing.Size(781, 25);
            this.dashBoardToolStrip.TabIndex = 0;
            this.dashBoardToolStrip.Text = "VIEWS";
            // 
            // overViewToolStripLabel
            // 
            this.overViewToolStripLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.overViewToolStripLabel.IsLink = true;
            this.overViewToolStripLabel.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.overViewToolStripLabel.Name = "overViewToolStripLabel";
            this.overViewToolStripLabel.Size = new System.Drawing.Size(53, 22);
            this.overViewToolStripLabel.Text = "OverView";
            this.overViewToolStripLabel.Click += new System.EventHandler(this.overViewToolStripLabel_Click);
            // 
            // detailViewToolStripLabel
            // 
            this.detailViewToolStripLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.detailViewToolStripLabel.IsLink = true;
            this.detailViewToolStripLabel.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.detailViewToolStripLabel.Name = "detailViewToolStripLabel";
            this.detailViewToolStripLabel.Size = new System.Drawing.Size(57, 22);
            this.detailViewToolStripLabel.Text = "DetailView";
            this.detailViewToolStripLabel.Click += new System.EventHandler(this.detailViewToolStripLabel_Click);
            // 
            // Industry_SectorViewtoolStripLabel
            // 
            this.Industry_SectorViewtoolStripLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.Industry_SectorViewtoolStripLabel.IsLink = true;
            this.Industry_SectorViewtoolStripLabel.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.Industry_SectorViewtoolStripLabel.Name = "Industry_SectorViewtoolStripLabel";
            this.Industry_SectorViewtoolStripLabel.Size = new System.Drawing.Size(103, 22);
            this.Industry_SectorViewtoolStripLabel.Text = "Industry/SectorView";
            this.Industry_SectorViewtoolStripLabel.Click += new System.EventHandler(this.Industry_SectorViewtoolStripLabel_Click);
            // 
            // exchangeViewToolStripLabel
            // 
            this.exchangeViewToolStripLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.exchangeViewToolStripLabel.IsLink = true;
            this.exchangeViewToolStripLabel.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.exchangeViewToolStripLabel.Name = "exchangeViewToolStripLabel";
            this.exchangeViewToolStripLabel.Size = new System.Drawing.Size(106, 22);
            this.exchangeViewToolStripLabel.Text = "StockExchangeView";
            this.exchangeViewToolStripLabel.Click += new System.EventHandler(this.exchangeViewToolStripLabel_Click);
            // 
            // Grid
            // 
            this.Grid.BackColor = System.Drawing.SystemColors.Window;
            this.Grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Grid.GridOfficeScrollBars = Syncfusion.Windows.Forms.OfficeScrollBars.Metro;
            this.Grid.Location = new System.Drawing.Point(0, 0);
            this.Grid.Name = "Grid";
            this.Grid.Size = new System.Drawing.Size(520, 422);
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
            this.symbolAutoComplete.PreferredWidth = 200;
            this.symbolAutoComplete.SingleClick = true;
            // 
            // dockingClientPanel1
            // 
            this.dockingClientPanel1.BackColor = System.Drawing.Color.White;
            this.dockingClientPanel1.Controls.Add(this.Grid);
            this.dockingClientPanel1.Location = new System.Drawing.Point(0, 25);
            this.dockingClientPanel1.Name = "dockingClientPanel1";
            this.dockingClientPanel1.Size = new System.Drawing.Size(520, 422);
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
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
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
            this.PerformLayout();

        }

        #endregion

        private Syncfusion.Windows.Forms.Tools.ToolStripEx dashBoardToolStrip;
        private Syncfusion.Windows.Forms.Grid.Grouping.GridGroupingControl Grid;
        private Syncfusion.Windows.Forms.Tools.GradientPanelExt addPortfolioPanel;
        private Syncfusion.Windows.Forms.ButtonAdv addPortfolioButton;
        private System.Windows.Forms.Label accountLabel;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv accountsComboBox;
        private Syncfusion.Windows.Forms.Tools.CheckBoxAdv priceLookUpCheckBox;
        private System.Windows.Forms.Label priceLabel;
        private Syncfusion.Windows.Forms.Tools.DoubleTextBox priceDoubleTextBox;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt quantityTextBox;
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

    }
}

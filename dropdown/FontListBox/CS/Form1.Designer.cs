#region Copyright Syncfusion Inc. 2001-2019.
// Copyright Syncfusion Inc. 2001-2019. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Syncfusion.Windows.Forms;
using Syncfusion.Windows.Forms.Tools;

namespace FontListBox_GettingStarted
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
            Syncfusion.Windows.Forms.MetroColorTable metroColorTable1 = new Syncfusion.Windows.Forms.MetroColorTable();
            Syncfusion.Windows.Forms.MetroColorTable metroColorTable2 = new Syncfusion.Windows.Forms.MetroColorTable();
            Syncfusion.Windows.Forms.MetroColorTable metroColorTable3 = new Syncfusion.Windows.Forms.MetroColorTable();
            Syncfusion.Windows.Forms.MetroColorTable metroColorTable4 = new Syncfusion.Windows.Forms.MetroColorTable();
            Syncfusion.Windows.Forms.MetroColorTable metroColorTable5 = new Syncfusion.Windows.Forms.MetroColorTable();
            Syncfusion.Windows.Forms.MetroColorTable metroColorTable6 = new Syncfusion.Windows.Forms.MetroColorTable();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.fontComboBox2 = new Syncfusion.Windows.Forms.Tools.FontComboBox();
            this.label1 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.label2 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.fontListBox1 = new Syncfusion.Windows.Forms.Tools.FontListBox();
            this.label3 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.scrollersFrame1 = new Syncfusion.Windows.Forms.ScrollersFrame(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.autoLabel10 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.sfComboBox1 = new Syncfusion.WinForms.ListView.SfComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.sfComboBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // fontComboBox2
            // 
            this.fontComboBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.fontComboBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fontComboBox2.DropDownHeight = 38;
            this.fontComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fontComboBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fontComboBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.fontComboBox2.IntegralHeight = false;
            this.fontComboBox2.ItemHeight = (int)DpiAware.LogicalToDeviceUnits(21.0f);
            this.fontComboBox2.Location = new System.Drawing.Point(21, 102);
            this.fontComboBox2.Margin = new System.Windows.Forms.Padding(2);
            this.fontComboBox2.MaxDropDownItems = 7;
            this.fontComboBox2.Name = "fontComboBox2";
            this.fontComboBox2.Office2007ColorTheme = Syncfusion.Windows.Forms.Office2007Theme.Silver;
            this.fontComboBox2.ShowSymbolFontPreview = false;
            this.fontComboBox2.Size = new System.Drawing.Size(268, 25);
            this.fontComboBox2.Sorted = true;
            this.fontComboBox2.TabIndex = 1;
            this.fontComboBox2.ThemeName = "Office2016Colorful";
            this.fontComboBox2.UseAutoComplete = true;
            this.fontComboBox2.VisualStyle = Syncfusion.Windows.Forms.Tools.ThemedComboBoxStyles.Office2016Colorful;
            this.fontComboBox2.SelectedIndexChanged += new System.EventHandler(this.fontComboBox2_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label1.Location = new System.Drawing.Point(20, 67);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "FontComboBox";
            this.label1.ThemeStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(-118, -107);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(440, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "The Sample showcases various ListBox controls available to select fonts";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // fontListBox1
            // 
            this.fontListBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.fontListBox1.BackColor = System.Drawing.SystemColors.Window;
            this.fontListBox1.BaseThemeName = "";
            this.fontListBox1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.fontListBox1.FormattingEnabled = true;
            this.fontListBox1.Items.AddRange(new object[] {
            "Agency FB",
            "Algerian",
            "Arial",
            "Arial Black",
            "Arial Narrow",
            "Arial Rounded MT Bold",
            "Bahnschrift",
            "Bahnschrift Condensed",
            "Bahnschrift Light",
            "Bahnschrift Light Condensed",
            "Bahnschrift Light SemiCondensed",
            "Bahnschrift SemiBold",
            "Bahnschrift SemiBold Condensed",
            "Bahnschrift SemiCondensed",
            "Bahnschrift SemiLight",
            "Bahnschrift SemiLight Condensed",
            "Baskerville Old Face",
            "Bauhaus 93",
            "Bell MT",
            "Berlin Sans FB",
            "Berlin Sans FB Demi",
            "Bernard MT Condensed",
            "Blackadder ITC",
            "Bodoni MT",
            "Bodoni MT Black",
            "Bodoni MT Condensed",
            "Bodoni MT Poster Compressed",
            "Book Antiqua",
            "Bookman Old Style",
            "Bradley Hand ITC",
            "Britannic Bold",
            "Broadway",
            "Brush Script MT",
            "Calibri",
            "Calibri Light",
            "Californian FB",
            "Calisto MT",
            "Cambria",
            "Candara",
            "Candara Light",
            "Castellar",
            "Centaur",
            "Century",
            "Century Gothic",
            "Century Schoolbook",
            "Chiller",
            "Colonna MT",
            "Comic Sans MS",
            "Consolas",
            "Constantia",
            "Cooper Black",
            "Copperplate Gothic Bold",
            "Copperplate Gothic Light",
            "Corbel",
            "Corbel Light",
            "Courier New",
            "Curlz MT",
            "Dubai",
            "Dubai Light",
            "Dubai Medium",
            "Ebrima",
            "Edwardian Script ITC",
            "Elephant",
            "Engravers MT",
            "Eras Bold ITC",
            "Eras Demi ITC",
            "Eras Light ITC",
            "Eras Medium ITC",
            "Felix Titling",
            "Footlight MT Light",
            "Forte",
            "Franklin Gothic Book",
            "Franklin Gothic Demi",
            "Franklin Gothic Demi Cond",
            "Franklin Gothic Heavy",
            "Franklin Gothic Medium",
            "Franklin Gothic Medium Cond",
            "Freestyle Script",
            "French Script MT",
            "Gabriola",
            "Gadugi",
            "Garamond",
            "Georgia",
            "Gigi",
            "Gill Sans MT",
            "Gill Sans MT Condensed",
            "Gill Sans MT Ext Condensed Bold",
            "Gill Sans Ultra Bold",
            "Gill Sans Ultra Bold Condensed",
            "Gloucester MT Extra Condensed",
            "Goudy Old Style",
            "Goudy Stout",
            "Haettenschweiler",
            "Harlow Solid Italic",
            "Harrington",
            "High Tower Text",
            "Impact",
            "Imprint MT Shadow",
            "Informal Roman",
            "Ink Free",
            "Javanese Text",
            "Jokerman",
            "Juice ITC",
            "Kristen ITC",
            "Kunstler Script",
            "Leelawadee",
            "Leelawadee UI",
            "Leelawadee UI Semilight",
            "Lucida Bright",
            "Lucida Calligraphy",
            "Lucida Console",
            "Lucida Fax",
            "Lucida Handwriting",
            "Lucida Sans",
            "Lucida Sans Typewriter",
            "Lucida Sans Unicode",
            "Magneto",
            "Maiandra GD",
            "Malgun Gothic",
            "Malgun Gothic Semilight",
            "Matura MT Script Capitals",
            "Microsoft Himalaya",
            "Microsoft JhengHei",
            "Microsoft JhengHei Light",
            "Microsoft JhengHei UI",
            "Microsoft JhengHei UI Light",
            "Microsoft New Tai Lue",
            "Microsoft PhagsPa",
            "Microsoft Sans Serif",
            "Microsoft Tai Le",
            "Microsoft Uighur",
            "Microsoft YaHei",
            "Microsoft YaHei Light",
            "Microsoft YaHei UI",
            "Microsoft YaHei UI Light",
            "Microsoft Yi Baiti",
            "MingLiU-ExtB",
            "MingLiU_HKSCS-ExtB",
            "Mistral",
            "Modern No. 20",
            "Mongolian Baiti",
            "Monotype Corsiva",
            "MS Gothic",
            "MS PGothic",
            "MS Reference Sans Serif",
            "MS UI Gothic",
            "MV Boli",
            "Myanmar Text",
            "Niagara Engraved",
            "Niagara Solid",
            "Nirmala UI",
            "Nirmala UI Semilight",
            "NSimSun",
            "OCR A Extended",
            "Old English Text MT",
            "Onyx",
            "Palace Script MT",
            "Palatino Linotype",
            "Papyrus",
            "Parchment",
            "Perpetua",
            "Perpetua Titling MT",
            "Playbill",
            "PMingLiU-ExtB",
            "Poor Richard",
            "Pristina",
            "Rage Italic",
            "Ravie",
            "Rockwell",
            "Rockwell Condensed",
            "Rockwell Extra Bold",
            "Script MT Bold",
            "Segoe Print",
            "Segoe Script",
            "Segoe UI",
            "Segoe UI Black",
            "Segoe UI Emoji",
            "Segoe UI Historic",
            "Segoe UI Light",
            "Segoe UI Semibold",
            "Segoe UI Semilight",
            "Segoe UI Symbol",
            "Showcard Gothic",
            "SimSun",
            "SimSun-ExtB",
            "Sitka Banner",
            "Sitka Display",
            "Sitka Heading",
            "Sitka Small",
            "Sitka Subheading",
            "Sitka Text",
            "Snap ITC",
            "Stencil",
            "Sylfaen",
            "Symbol",
            "Tahoma",
            "Tempus Sans ITC",
            "Times New Roman",
            "Trebuchet MS",
            "Tw Cen MT",
            "Tw Cen MT Condensed",
            "Tw Cen MT Condensed Extra Bold",
            "Verdana",
            "Viner Hand ITC",
            "Vivaldi",
            "Vladimir Script",
            "Wide Latin",
            "Yu Gothic",
            "Yu Gothic Light",
            "Yu Gothic Medium",
            "Yu Gothic UI",
            "Yu Gothic UI Light",
            "Yu Gothic UI Semibold",
            "Yu Gothic UI Semilight"});
            this.fontListBox1.Location = new System.Drawing.Point(22, 188);
            this.fontListBox1.Margin = new System.Windows.Forms.Padding(2);
            this.fontListBox1.MetroColor = System.Drawing.SystemColors.Highlight;
            this.fontListBox1.Name = "fontListBox1";
            this.fontListBox1.ScrollMetroColorTable = metroColorTable1;
            this.fontListBox1.Size = new System.Drawing.Size(268, 199);
            this.fontListBox1.TabIndex = 10;
            this.fontListBox1.ThemeName = "Office2019Colorful";
            this.fontListBox1.ItemHeight = (int)DpiAware.LogicalToDeviceUnits(21.0f);
            this.fontListBox1.SelectedIndexChanged += new System.EventHandler(this.fontListBox1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label3.Location = new System.Drawing.Point(19, 147);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Font List Box";
            this.label3.ThemeStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // scrollersFrame1
            // 
            this.scrollersFrame1.CustomRender = null;
            this.scrollersFrame1.MetroColorScheme = Syncfusion.Windows.Forms.MetroColorScheme.Managed;
            this.scrollersFrame1.MetroThumbSize = new System.Drawing.Size(0, 0);
            this.scrollersFrame1.Office2016ColorScheme = Syncfusion.Windows.Forms.ScrollBarOffice2016ColorScheme.Colorful;
            this.scrollersFrame1.ScrollMetroColorTable = metroColorTable2;
            metroColorTable3.ArrowChecked = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            metroColorTable3.ArrowCheckedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(94)))), ((int)(((byte)(94)))));
            metroColorTable3.ArrowInActive = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            metroColorTable3.ArrowNormal = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(178)))), ((int)(((byte)(178)))));
            metroColorTable3.ArrowNormalBackGround = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(94)))), ((int)(((byte)(94)))));
            metroColorTable3.ArrowNormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            metroColorTable3.ArrowPushed = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(211)))), ((int)(((byte)(211)))));
            metroColorTable3.ArrowPushedBackGround = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            metroColorTable3.ArrowPushedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(83)))), ((int)(((byte)(83)))));
            metroColorTable3.ScrollerBackground = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            metroColorTable3.ThumbChecked = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            metroColorTable3.ThumbCheckedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(94)))), ((int)(((byte)(94)))));
            metroColorTable3.ThumbInActive = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            metroColorTable3.ThumbNormal = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(94)))), ((int)(((byte)(94)))));
            metroColorTable3.ThumbNormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            metroColorTable3.ThumbPushed = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            metroColorTable3.ThumbPushedBorder = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(83)))), ((int)(((byte)(83)))));
            metroColorTable3.ThumbPushedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.scrollersFrame1.ScrollOffice2016BlackColorTable = metroColorTable3;
            metroColorTable4.ArrowChecked = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(114)))), ((int)(((byte)(114)))));
            metroColorTable4.ArrowCheckedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(94)))), ((int)(((byte)(94)))));
            metroColorTable4.ArrowInActive = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            metroColorTable4.ArrowNormal = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(114)))), ((int)(((byte)(114)))));
            metroColorTable4.ArrowNormalBackGround = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            metroColorTable4.ArrowNormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            metroColorTable4.ArrowPushed = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(114)))), ((int)(((byte)(114)))));
            metroColorTable4.ArrowPushedBackGround = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            metroColorTable4.ArrowPushedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            metroColorTable4.ScrollerBackground = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            metroColorTable4.ThumbChecked = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            metroColorTable4.ThumbCheckedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            metroColorTable4.ThumbInActive = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            metroColorTable4.ThumbNormal = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            metroColorTable4.ThumbNormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            metroColorTable4.ThumbPushed = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            metroColorTable4.ThumbPushedBorder = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            metroColorTable4.ThumbPushedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.scrollersFrame1.ScrollOffice2016ColorfulColorTable = metroColorTable4;
            metroColorTable5.ArrowChecked = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            metroColorTable5.ArrowCheckedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            metroColorTable5.ArrowInActive = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            metroColorTable5.ArrowNormal = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            metroColorTable5.ArrowNormalBackGround = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            metroColorTable5.ArrowNormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            metroColorTable5.ArrowPushed = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            metroColorTable5.ArrowPushedBackGround = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            metroColorTable5.ArrowPushedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            metroColorTable5.ScrollerBackground = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            metroColorTable5.ThumbChecked = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            metroColorTable5.ThumbCheckedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            metroColorTable5.ThumbInActive = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            metroColorTable5.ThumbNormal = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            metroColorTable5.ThumbNormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            metroColorTable5.ThumbPushed = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            metroColorTable5.ThumbPushedBorder = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            metroColorTable5.ThumbPushedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.scrollersFrame1.ScrollOffice2016DarkGrayColorTable = metroColorTable5;
            metroColorTable6.ArrowChecked = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(114)))), ((int)(((byte)(114)))));
            metroColorTable6.ArrowCheckedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(94)))), ((int)(((byte)(94)))));
            metroColorTable6.ArrowInActive = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            metroColorTable6.ArrowNormal = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(114)))), ((int)(((byte)(114)))));
            metroColorTable6.ArrowNormalBackGround = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            metroColorTable6.ArrowNormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            metroColorTable6.ArrowPushed = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(114)))), ((int)(((byte)(114)))));
            metroColorTable6.ArrowPushedBackGround = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            metroColorTable6.ArrowPushedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            metroColorTable6.ScrollerBackground = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            metroColorTable6.ThumbChecked = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            metroColorTable6.ThumbCheckedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            metroColorTable6.ThumbInActive = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            metroColorTable6.ThumbNormal = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            metroColorTable6.ThumbNormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            metroColorTable6.ThumbPushed = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            metroColorTable6.ThumbPushedBorder = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            metroColorTable6.ThumbPushedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.scrollersFrame1.ScrollOffice2016WhiteColorTable = metroColorTable6;
            this.scrollersFrame1.ShowMetroArrowButton = true;
            this.scrollersFrame1.SizeGripperVisibility = Syncfusion.Windows.Forms.SizeGripperVisibility.Auto;
            this.scrollersFrame1.ThemeName = "Office2016";
            this.scrollersFrame1.VisualStyle = Syncfusion.Windows.Forms.ScrollBarCustomDrawStyles.Office2016;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label4.Location = new System.Drawing.Point(362, 97);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(345, 131);
            this.label4.TabIndex = 14;
            this.label4.Text = resources.GetString("label4.Text");
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // autoLabel10
            // 
            this.autoLabel10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoLabel10.Location = new System.Drawing.Point(446, 26);
            this.autoLabel10.Name = "autoLabel10";
            this.autoLabel10.Size = new System.Drawing.Size(107, 16);
            this.autoLabel10.TabIndex = 56;
            this.autoLabel10.Text = "Choose theme";
            this.autoLabel10.ThemeStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.autoLabel10.Click += new System.EventHandler(this.autoLabel10_Click);
            // 
            // sfComboBox1
            // 
            this.sfComboBox1.DropDownStyle = Syncfusion.WinForms.ListView.Enums.DropDownStyle.DropDownList;
            this.sfComboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sfComboBox1.Location = new System.Drawing.Point(545, 25);
            this.sfComboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.sfComboBox1.Name = "sfComboBox1";
            this.sfComboBox1.Size = new System.Drawing.Size(157, 21);
            this.sfComboBox1.Style.EditorStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sfComboBox1.Style.ReadOnlyEditorStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sfComboBox1.TabIndex = 55;
            this.sfComboBox1.SelectedIndexChanged += new System.EventHandler(this.sfComboBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 396);
            this.Controls.Add(this.autoLabel10);
            this.Controls.Add(this.sfComboBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.fontListBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fontComboBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Font List Box";
            ((System.ComponentModel.ISupportInitialize)(this.sfComboBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Syncfusion.Windows.Forms.Tools.FontComboBox fontComboBox2;
        private AutoLabel label1;
        private AutoLabel label2;
        private Syncfusion.Windows.Forms.Tools.FontListBox fontListBox1;
        private AutoLabel label3;
        private Syncfusion.Windows.Forms.ScrollersFrame scrollersFrame1;
        private System.Windows.Forms.Label label4;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel10;
        private Syncfusion.WinForms.ListView.SfComboBox sfComboBox1;
    }
}


#region Copyright Syncfusion Inc. 2001-2017.
// Copyright Syncfusion Inc. 2001-2017. All rights reserved.
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
using System.Globalization;
using Syncfusion.Windows.Forms;
using Syncfusion.Windows.Forms.Tools;
using System.Text.RegularExpressions;
using Syncfusion.Drawing;
using Syncfusion.Licensing;
using System.IO;

namespace EditorControls
{
    /// <summary>
    /// Summary description for Form1.
    /// </summary>
    public class Form1 : MetroForm
    {
        #region Declarations
        private Syncfusion.Windows.Forms.Tools.CurrencyTextBox currencyTextBox1;
        private Syncfusion.Windows.Forms.Tools.CheckBoxAdv checkBox1;
        private System.Windows.Forms.Label label3;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv comboBoxAdv1;
        private System.Windows.Forms.Label label4;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt textBox1;
        private System.Windows.Forms.Label label6;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv comboBoxAdv2;
        private System.Windows.Forms.Label label7;
        private Syncfusion.Windows.Forms.Tools.IntegerTextBox integerTextBox1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter1;
        private System.Data.OleDb.OleDbCommand oleDbSelectCommand1;
        private System.Data.OleDb.OleDbConnection oleDbConnection1;
        private EditorControls.DataSet1 dataSet11;
        private Syncfusion.Windows.Forms.Tools.CheckBoxAdv checkBox2;
        private System.Windows.Forms.DataGrid dataGrid1;
        private Label label34;
        private Label label13;
        private CheckBoxAdv checkBox5;
        private Label label35;
        private Label label26;
        private Label label11;
        private Label label9;
        private CheckBoxAdv checkBox9;
        private CheckBoxAdv checkBox8;
        private CheckBoxAdv checkBox7;
        private CheckBoxAdv checkBox6;
        private CheckBoxAdv checkBox4;
        private CheckBoxAdv checkBox3;
        private CheckBoxAdv checkBox10;
        private CheckBoxAdv checkBox11;
        private ColorDialog colorDialog1;
        private Label label5;
        private Label label2;
        private Label label8;
        private Label label17;
        private ComboBoxAdv comboBox1;
        private Label label15;
        private Label label16;
        private Label label19;
        private Label label20;
        private Label label18;
        private ComboBoxAdv comboBox2;
        private RadioButtonAdv radFinancial;
        private RadioButtonAdv radWinStd;
        private CheckBoxAdv checkBox12;
        private Label label23;
        private ComboBoxAdv cboButtonType;
        private CheckBoxAdv checkBox13;
        private ComboBoxAdv comboBox3;
        private Label label30;
        private Label label29;
        private Label label28;
        private ComboBoxAdv comboBox4;
        private RadioButtonAdv radioButton1;
        private RadioButtonAdv radioButton2;
        private CheckBoxAdv checkBox14;
        private CheckBoxAdv checkBox15;
        private ToolTip toolTip1;
        private DoubleTextBox doubleTextBox1;
        private IntegerTextBox integerTextBox2;
        private RadioButtonAdv radioButton6;
        private RadioButtonAdv radioButton7;
        private Label label40;
        private ComboBoxAdv comboBox5;
        private ComboBoxAdv comboBox6;
        private Label label42;
        private Label label43;
        private Label label44;
        private CheckBoxAdv checkBox16;
        private TextBoxExt textBox3;
        private Label label55;
        private Label label54;
        private IntegerTextBox integerTextBox3;
        private Label label53;
        private TextBoxExt textBox2;
        private Label label52;
        private Label label46;
        private Label label61;
        private Label label69;
        private TextBoxExt textBox4;
        private Label label67;
        private Label label68;
        private NumericUpDownExt numericUpDownExt1;
        private Label label70;
        private IntegerTextBox integerTextBox7;
        private Label label72;
        private TextBoxExt textBox6;
        private Label label73;
        private NumericUpDownExt numericUpDownExt2;
        private NumericUpDownExt numericUpDownExt3;
        private NumericUpDownExt numericUpDownExt4;
        private NumericUpDownExt numericUpDownExt5;
        private Label label76;
        private PercentTextBox percentTextBox1;
        private Label label82;
        private Label label83;
        private CheckBoxAdv checkBox18;
        private CheckBoxAdv checkBox17;
        private GroupBox groupBox1;
        private Label label84;
        private Label label88;
        private Label label91;
        private DomainUpDownExt domainUpDownExt1;
        private CheckBoxAdv checkBox19;
        private Label label27;
        private DataGrid dataGrid2;
        private ButtonEdit NegativeColorEdit;
        private ButtonEditChildButton buttonEditChildButton1;
        private TextBoxExt textBoxExt2;
        private ButtonEdit PositiveColorEdit;
        private ButtonEditChildButton buttonEditChildButton5;
        private TextBoxExt textBoxExt1;
        private ButtonEdit buttonEdit1;
        private ButtonEditChildButton buttonEditChildButton2;
        private TextBoxExt textBoxExt3;
        private CheckBoxAdv checkBox21;
        private TextBoxExt textBoxExt4;
        private Label label103;
        private RadioButtonAdv radioButton10;
        private RadioButtonAdv radioButton11;
        private Label label105;
        private ComboBoxAdv comboBox10;
        private ComboBoxAdv comboBox11;
        private Label label106;
        private Label label107;
        private ComboBoxAdv comboBox12;
        private ComboBoxAdv comboBox9;
        private Label label101;
        private ComboBoxAdv comboBox8;
        private Label label100;
        private Label label108;
        private CheckBoxAdv checkBox25;
        private CheckBoxAdv checkBox24;
        private CheckBoxAdv checkBox23;
        private CheckBoxAdv checkBox22;
        private Label label109;
        private TextBoxExt textBox11;
        private Label label102;
        private CheckBoxAdv checkBox26;
        private Label label113;
        private Label label111;
        private ButtonEdit buttonEdit2;
        private ButtonEditChildButton buttonEditChildButton4;
        private Label label115;
        private EditableList editableList2;
        private GradientPanel gradientPanel3;
        private Label label116;
        private EditableList editableList1;
        private Label label118;
        private Label label119;
        private Label label120;
        private Label label121;
        private GradientPanel gradientPanel4;
        private Label label122;
        private ComboBoxAdv comboBox13;
        private Label label117;
        private CheckBoxAdv checkBox27;
        private CheckBoxAdv checkBox28;
        private ButtonEdit DomainBorderColorEdit;
        private ButtonEditChildButton buttonEditChildButton6;
        private TreeViewAdv treeViewAdv1;
        private GradientPanel gradientPanel1;
        private GradientPanel gradientPanel5;
        private GradientPanel gradientPanel6;
        private Label label33;
        private Label label37;
        private GradientPanel gradientPanel7;
        private GradientPanel gradientPanel8;
        private Label label38;
        private Label label56;
        private GradientPanel gradientPanel11;
        private GradientPanel gradientPanel9;
        private GradientPanel gradientPanel12;
        private Label label45;
        private Label label47;
        private GradientPanel gradientPanel10;
        private Label label57;
        private Label label63;
        private GradientLabel gradientLabel1;
        private Label label48;
        private Label label1;
        private Label label50;
        private Label label39;
        private Label label66;
        private NumericUpDownExt numericUpDownExt7;
        private Label label24;
        private Label label25;
        private Label label65;
        private GroupBox groupBox3;
        private GroupBox groupBox2;
        private GroupBox groupBox4;
        private GroupBox groupBox5;
        private Label label14;
        private CheckBoxAdv checkBox20;
        private CurrencyEdit currencyEdit1;
        private ButtonEdit buttonEdit3;
        private ButtonEditChildButton buttonEditChildButton3;
        private Label label80;
        private Label label81;
        private Label label90;
        private ComboBoxAdv comboBox7;
        private Label label93;
        private RadioButtonAdv radioButton8;
        private ButtonEdit buttonEdit4;
        private ButtonEditChildButton buttonEditChildButton7;
        private RadioButtonAdv radioButton9;
        private ButtonEdit buttonEdit5;
        private ButtonEditChildButton buttonEditChildButton8;
        private Label label95;
        private ComboBoxAdv comboBox14;
        private Label label96;
        private Label label97;
        private Label label71;
        private GroupBox groupBox6;
        private MaskedEditBox maskedEditBox1;
        private Label label64;
        private Label label98;
        private ComboBoxAdv comboBox15;
        private Label label79;
        private CheckBoxAdv checkBox29;
        private ComboBoxAdv comboBox16;
        private CheckBoxAdv checkBox30;
        private ComboBoxAdv comboBox17;
        private Label label125;
        private Label label126;
        private ComboBoxAdv comboBox18;
        private Label label75;
        private ComboBoxAdv comboBox19;
        private Label label77;
        private Label label78;
        private ButtonAdv button1;
        private ButtonEdit bannerClrEdit;
        private ButtonEditChildButton buttonEditChildButton9;
        private TextBoxExt textBoxExt5;
        private RadioButtonAdv rdoFocus;
        private RadioButtonAdv rdoEdit;
        private TextBoxExt txtBanner;
        private Label label127;
        private Label label124;
        private Label label99;
        private BannerTextProvider bannerTextProvider1;
        private Label label128;
        private ComboBoxAdv cmbMode;
        private TextBoxExt txtBnr;
        private Label label130;
        private Label label131;
        private Label label132;
        private ButtonAdv btnSetBanner;
        private ButtonEdit bannerClr;
        private ButtonEditChildButton buttonEditChildButton10;
        private TextBoxExt textBoxExt6;
        private TextBoxExt textBanner;
        private Label label136;
        private Label label135;
        private Label label134;
        private ButtonEdit bEditBanner;
        private TextBoxExt textBoxExt7;
        private ComboBoxAdv comboMode;
        private ButtonEditChildButton buttonEditChildButton11;
        private ButtonAdv buttonBanner;
        private Label label137;
        private Label label138;
        private NumericUpDownExt numericUpDownExt8;
        private NumericUpDownExt numericUpDownExt6;
        private NumericUpDownExt numericUpDownExt9;
        private Label label139;
        private DataTable Dt;
        private CheckBoxAdv checkBox32;
        private CheckBoxAdv checkBox31;
        private CheckBoxAdv chkPullCharOnDelete;
        private ComboBoxAdv comboBoxAdv3;
        private Label label31;
        private SkinManager skinManager1;
        private GradientPanel inputPanel;
        private GradientPanel textBoxPanel;
        private GradientPanel maskedEditPanel;
        private GradientPanel upDownPanel;
        private Panel baseRightpanel;
        private System.ComponentModel.IContainer components;
        #endregion

        #region Form constructor and Dispose
        public Form1()
        {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();

            try
            {
                System.Drawing.Icon ico = new System.Drawing.Icon(GetIconFile(@"common\Images\Grid\Icon\sfgrid.ico"));
                this.Icon = ico;
            }
            catch { }
            currencyEdit1.ButtonStyle = ButtonAppearance.Metro;
            currencyEdit1.FlatStyle = FlatStyle.Flat;
            currencyEdit1.Border3DStyle = Border3DStyle.Flat;


            //
            // TODO: Add any constructor code after InitializeComponent call
            //
        }
        private string GetIconFile(string bitmapName)
        {
            for (int n = 0; n < 10; n++)
            {
                if (System.IO.File.Exists(bitmapName))
                    return bitmapName;

                bitmapName = @"..\" + bitmapName;
            }

            return bitmapName;
        }

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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Syncfusion.Windows.Forms.MetroColorTable metroColorTable1 = new Syncfusion.Windows.Forms.MetroColorTable();
            Syncfusion.Windows.Forms.MetroColorTable metroColorTable2 = new Syncfusion.Windows.Forms.MetroColorTable();
            Syncfusion.Windows.Forms.Tools.TreeNodeAdvStyleInfo treeNodeAdvStyleInfo1 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdvStyleInfo();
            Syncfusion.Windows.Forms.Tools.TreeNodeAdv treeNodeAdv1 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdv();
            Syncfusion.Windows.Forms.Tools.TreeNodeAdv treeNodeAdv2 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdv();
            Syncfusion.Windows.Forms.Tools.TreeNodeAdv treeNodeAdv3 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdv();
            Syncfusion.Windows.Forms.Tools.TreeNodeAdv treeNodeAdv4 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdv();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.currencyTextBox1 = new Syncfusion.Windows.Forms.Tools.CurrencyTextBox();
            this.integerTextBox1 = new Syncfusion.Windows.Forms.Tools.IntegerTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox1 = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxAdv1 = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBox1 = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxAdv2 = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.dataGrid1 = new System.Windows.Forms.DataGrid();
            this.checkBox2 = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.oleDbDataAdapter1 = new System.Data.OleDb.OleDbDataAdapter();
            this.oleDbSelectCommand1 = new System.Data.OleDb.OleDbCommand();
            this.oleDbConnection1 = new System.Data.OleDb.OleDbConnection();
            this.inputPanel = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            this.gradientPanel11 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            this.numericUpDownExt8 = new Syncfusion.Windows.Forms.Tools.NumericUpDownExt();
            this.label138 = new System.Windows.Forms.Label();
            this.bannerClr = new Syncfusion.Windows.Forms.Tools.ButtonEdit();
            this.buttonEditChildButton10 = new Syncfusion.Windows.Forms.Tools.ButtonEditChildButton();
            this.textBoxExt6 = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.btnSetBanner = new Syncfusion.Windows.Forms.ButtonAdv();
            this.cmbMode = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.txtBnr = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.label130 = new System.Windows.Forms.Label();
            this.label131 = new System.Windows.Forms.Label();
            this.label132 = new System.Windows.Forms.Label();
            this.label128 = new System.Windows.Forms.Label();
            this.checkBox20 = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.NegativeColorEdit = new Syncfusion.Windows.Forms.Tools.ButtonEdit();
            this.buttonEditChildButton1 = new Syncfusion.Windows.Forms.Tools.ButtonEditChildButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label42 = new System.Windows.Forms.Label();
            this.comboBox6 = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.label46 = new System.Windows.Forms.Label();
            this.label61 = new System.Windows.Forms.Label();
            this.radioButton6 = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
            this.buttonEdit1 = new Syncfusion.Windows.Forms.Tools.ButtonEdit();
            this.buttonEditChildButton2 = new Syncfusion.Windows.Forms.Tools.ButtonEditChildButton();
            this.radioButton7 = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
            this.PositiveColorEdit = new Syncfusion.Windows.Forms.Tools.ButtonEdit();
            this.buttonEditChildButton5 = new Syncfusion.Windows.Forms.Tools.ButtonEditChildButton();
            this.label40 = new System.Windows.Forms.Label();
            this.comboBox5 = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.checkBox16 = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.label8 = new System.Windows.Forms.Label();
            this.label43 = new System.Windows.Forms.Label();
            this.label44 = new System.Windows.Forms.Label();
            this.gradientPanel9 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.gradientPanel12 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            this.label45 = new System.Windows.Forms.Label();
            this.label47 = new System.Windows.Forms.Label();
            this.gradientPanel7 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            this.integerTextBox2 = new Syncfusion.Windows.Forms.Tools.IntegerTextBox();
            this.label50 = new System.Windows.Forms.Label();
            this.gradientPanel10 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            this.label57 = new System.Windows.Forms.Label();
            this.label63 = new System.Windows.Forms.Label();
            this.label69 = new System.Windows.Forms.Label();
            this.numericUpDownExt1 = new Syncfusion.Windows.Forms.Tools.NumericUpDownExt();
            this.label68 = new System.Windows.Forms.Label();
            this.textBox4 = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.numericUpDownExt3 = new Syncfusion.Windows.Forms.Tools.NumericUpDownExt();
            this.label67 = new System.Windows.Forms.Label();
            this.gradientPanel5 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            this.label48 = new System.Windows.Forms.Label();
            this.percentTextBox1 = new Syncfusion.Windows.Forms.Tools.PercentTextBox();
            this.gradientPanel8 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            this.label38 = new System.Windows.Forms.Label();
            this.label56 = new System.Windows.Forms.Label();
            this.label73 = new System.Windows.Forms.Label();
            this.textBox6 = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.label72 = new System.Windows.Forms.Label();
            this.numericUpDownExt5 = new Syncfusion.Windows.Forms.Tools.NumericUpDownExt();
            this.integerTextBox7 = new Syncfusion.Windows.Forms.Tools.IntegerTextBox();
            this.label76 = new System.Windows.Forms.Label();
            this.label70 = new System.Windows.Forms.Label();
            this.numericUpDownExt4 = new Syncfusion.Windows.Forms.Tools.NumericUpDownExt();
            this.gradientPanel1 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            this.label39 = new System.Windows.Forms.Label();
            this.doubleTextBox1 = new Syncfusion.Windows.Forms.Tools.DoubleTextBox();
            this.gradientPanel6 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            this.label33 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.label52 = new System.Windows.Forms.Label();
            this.textBox2 = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.label53 = new System.Windows.Forms.Label();
            this.integerTextBox3 = new Syncfusion.Windows.Forms.Tools.IntegerTextBox();
            this.label54 = new System.Windows.Forms.Label();
            this.label55 = new System.Windows.Forms.Label();
            this.textBox3 = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.numericUpDownExt2 = new Syncfusion.Windows.Forms.Tools.NumericUpDownExt();
            this.textBoxPanel = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            this.checkBox32 = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.checkBox31 = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.numericUpDownExt6 = new Syncfusion.Windows.Forms.Tools.NumericUpDownExt();
            this.label137 = new System.Windows.Forms.Label();
            this.button1 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.bannerClrEdit = new Syncfusion.Windows.Forms.Tools.ButtonEdit();
            this.buttonEditChildButton9 = new Syncfusion.Windows.Forms.Tools.ButtonEditChildButton();
            this.textBoxExt5 = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.rdoFocus = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
            this.rdoEdit = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
            this.txtBanner = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.label127 = new System.Windows.Forms.Label();
            this.label124 = new System.Windows.Forms.Label();
            this.label99 = new System.Windows.Forms.Label();
            this.label77 = new System.Windows.Forms.Label();
            this.label78 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label25 = new System.Windows.Forms.Label();
            this.textBoxExt4 = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.label109 = new System.Windows.Forms.Label();
            this.checkBox21 = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.label103 = new System.Windows.Forms.Label();
            this.label107 = new System.Windows.Forms.Label();
            this.checkBox22 = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.buttonEdit2 = new Syncfusion.Windows.Forms.Tools.ButtonEdit();
            this.buttonEditChildButton4 = new Syncfusion.Windows.Forms.Tools.ButtonEditChildButton();
            this.textBoxExt3 = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.label108 = new System.Windows.Forms.Label();
            this.label106 = new System.Windows.Forms.Label();
            this.checkBox23 = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.label115 = new System.Windows.Forms.Label();
            this.comboBox12 = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.comboBox11 = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.checkBox24 = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.label113 = new System.Windows.Forms.Label();
            this.comboBox9 = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.comboBox10 = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.checkBox25 = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.label101 = new System.Windows.Forms.Label();
            this.label105 = new System.Windows.Forms.Label();
            this.checkBox26 = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.label111 = new System.Windows.Forms.Label();
            this.comboBox8 = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.radioButton11 = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
            this.label102 = new System.Windows.Forms.Label();
            this.label100 = new System.Windows.Forms.Label();
            this.radioButton10 = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
            this.textBox11 = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.maskedEditPanel = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            this.chkPullCharOnDelete = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.numericUpDownExt9 = new Syncfusion.Windows.Forms.Tools.NumericUpDownExt();
            this.label139 = new System.Windows.Forms.Label();
            this.comboBox18 = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.label126 = new System.Windows.Forms.Label();
            this.label79 = new System.Windows.Forms.Label();
            this.checkBox29 = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.comboBox16 = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.checkBox30 = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.comboBox17 = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.label125 = new System.Windows.Forms.Label();
            this.label98 = new System.Windows.Forms.Label();
            this.comboBox15 = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.buttonEdit3 = new Syncfusion.Windows.Forms.Tools.ButtonEdit();
            this.buttonEditChildButton3 = new Syncfusion.Windows.Forms.Tools.ButtonEditChildButton();
            this.textBoxExt2 = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.label80 = new System.Windows.Forms.Label();
            this.label81 = new System.Windows.Forms.Label();
            this.label90 = new System.Windows.Forms.Label();
            this.comboBox7 = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.label93 = new System.Windows.Forms.Label();
            this.radioButton8 = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
            this.buttonEdit4 = new Syncfusion.Windows.Forms.Tools.ButtonEdit();
            this.buttonEditChildButton7 = new Syncfusion.Windows.Forms.Tools.ButtonEditChildButton();
            this.radioButton9 = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
            this.buttonEdit5 = new Syncfusion.Windows.Forms.Tools.ButtonEdit();
            this.buttonEditChildButton8 = new Syncfusion.Windows.Forms.Tools.ButtonEditChildButton();
            this.textBoxExt1 = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.label95 = new System.Windows.Forms.Label();
            this.comboBox14 = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.label96 = new System.Windows.Forms.Label();
            this.label97 = new System.Windows.Forms.Label();
            this.label71 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.maskedEditBox1 = new Syncfusion.Windows.Forms.Tools.MaskedEditBox();
            this.label64 = new System.Windows.Forms.Label();
            this.upDownPanel = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            this.buttonBanner = new Syncfusion.Windows.Forms.ButtonAdv();
            this.comboMode = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.bEditBanner = new Syncfusion.Windows.Forms.Tools.ButtonEdit();
            this.buttonEditChildButton11 = new Syncfusion.Windows.Forms.Tools.ButtonEditChildButton();
            this.textBoxExt7 = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.textBanner = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.label136 = new System.Windows.Forms.Label();
            this.label135 = new System.Windows.Forms.Label();
            this.label134 = new System.Windows.Forms.Label();
            this.label75 = new System.Windows.Forms.Label();
            this.comboBox19 = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.radioButton2 = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
            this.radioButton1 = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.numericUpDownExt7 = new Syncfusion.Windows.Forms.Tools.NumericUpDownExt();
            this.label24 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.domainUpDownExt1 = new Syncfusion.Windows.Forms.Tools.DomainUpDownExt();
            this.label66 = new System.Windows.Forms.Label();
            this.label88 = new System.Windows.Forms.Label();
            this.label84 = new System.Windows.Forms.Label();
            this.DomainBorderColorEdit = new Syncfusion.Windows.Forms.Tools.ButtonEdit();
            this.buttonEditChildButton6 = new Syncfusion.Windows.Forms.Tools.ButtonEditChildButton();
            this.checkBox14 = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.dataGrid2 = new System.Windows.Forms.DataGrid();
            this.checkBox19 = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.label28 = new System.Windows.Forms.Label();
            this.label91 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.checkBox15 = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.label27 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.comboBox4 = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.comboBox3 = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label65 = new System.Windows.Forms.Label();
            this.currencyEdit1 = new Syncfusion.Windows.Forms.Tools.CurrencyEdit();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.comboBox1 = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.label83 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label82 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radWinStd = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
            this.radFinancial = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
            this.checkBox13 = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.comboBox2 = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.label23 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.cboButtonType = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.checkBox18 = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.checkBox12 = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.checkBox17 = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.checkBox28 = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.checkBox27 = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.comboBox13 = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.label117 = new System.Windows.Forms.Label();
            this.gradientPanel4 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            this.label122 = new System.Windows.Forms.Label();
            this.label118 = new System.Windows.Forms.Label();
            this.label119 = new System.Windows.Forms.Label();
            this.label120 = new System.Windows.Forms.Label();
            this.label121 = new System.Windows.Forms.Label();
            this.editableList2 = new Syncfusion.Windows.Forms.Tools.EditableList();
            this.gradientPanel3 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            this.label116 = new System.Windows.Forms.Label();
            this.editableList1 = new Syncfusion.Windows.Forms.Tools.EditableList();
            this.label34 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.checkBox5 = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.label35 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.checkBox9 = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.checkBox8 = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.checkBox7 = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.checkBox6 = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.checkBox4 = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.checkBox3 = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.checkBox10 = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.checkBox11 = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.dataSet11 = new EditorControls.DataSet1();
            this.treeViewAdv1 = new Syncfusion.Windows.Forms.Tools.TreeViewAdv();
            this.gradientLabel1 = new Syncfusion.Windows.Forms.Tools.GradientLabel();
            this.comboBoxAdv3 = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.label31 = new System.Windows.Forms.Label();
            this.skinManager1 = new Syncfusion.Windows.Forms.SkinManager(this.components);
            this.baseRightpanel = new System.Windows.Forms.Panel();
            this.bannerTextProvider1 = new Syncfusion.Windows.Forms.BannerTextProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.currencyTextBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.integerTextBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxAdv1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxAdv2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputPanel)).BeginInit();
            this.inputPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel11)).BeginInit();
            this.gradientPanel11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownExt8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bannerClr)).BeginInit();
            this.bannerClr.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxExt6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbMode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBnr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox20)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NegativeColorEdit)).BeginInit();
            this.NegativeColorEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioButton6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonEdit1)).BeginInit();
            this.buttonEdit1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radioButton7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PositiveColorEdit)).BeginInit();
            this.PositiveColorEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel9)).BeginInit();
            this.gradientPanel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel12)).BeginInit();
            this.gradientPanel12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel7)).BeginInit();
            this.gradientPanel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.integerTextBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel10)).BeginInit();
            this.gradientPanel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownExt1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownExt3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel5)).BeginInit();
            this.gradientPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.percentTextBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel8)).BeginInit();
            this.gradientPanel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownExt5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.integerTextBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownExt4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel1)).BeginInit();
            this.gradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.doubleTextBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel6)).BeginInit();
            this.gradientPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.integerTextBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownExt2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxPanel)).BeginInit();
            this.textBoxPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox32)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox31)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownExt6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bannerClrEdit)).BeginInit();
            this.bannerClrEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxExt5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdoFocus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdoEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBanner)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxExt4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox22)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonEdit2)).BeginInit();
            this.buttonEdit2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxExt3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox23)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBox12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox24)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox25)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox26)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioButton11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioButton10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maskedEditPanel)).BeginInit();
            this.maskedEditPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkPullCharOnDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownExt9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBox18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox29)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBox16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox30)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBox17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBox15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonEdit3)).BeginInit();
            this.buttonEdit3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxExt2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioButton8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonEdit4)).BeginInit();
            this.buttonEdit4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radioButton9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonEdit5)).BeginInit();
            this.buttonEdit5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxExt1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBox14)).BeginInit();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maskedEditBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.upDownPanel)).BeginInit();
            this.upDownPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboMode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bEditBanner)).BeginInit();
            this.bEditBanner.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxExt7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBanner)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBox19)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioButton2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioButton1)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownExt7)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DomainBorderColorEdit)).BeginInit();
            this.DomainBorderColorEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox19)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBox3)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.currencyEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.currencyEdit1.TextBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radWinStd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radFinancial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboButtonType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox28)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox27)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBox13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel4)).BeginInit();
            this.gradientPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.editableList2.TextBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel3)).BeginInit();
            this.gradientPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.editableList1.TextBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeViewAdv1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxAdv3)).BeginInit();
            this.baseRightpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "");
            this.imageList1.Images.SetKeyName(1, "App.ico");
            this.imageList1.Images.SetKeyName(2, "textBoxExt4.FarImage.png");
            // 
            // currencyTextBox1
            // 
            this.currencyTextBox1.BackGroundColor = System.Drawing.SystemColors.Window;
            this.currencyTextBox1.BeforeTouchSize = new System.Drawing.Size(130, 29);
            this.currencyTextBox1.Border3DStyle = System.Windows.Forms.Border3DStyle.RaisedOuter;
            this.currencyTextBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.currencyTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.currencyTextBox1.CurrentCultureRefresh = true;
            this.currencyTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.currencyTextBox1.DecimalValue = new decimal(new int[] {
            200,
            0,
            0,
            131072});
            this.currencyTextBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.currencyTextBox1.Location = new System.Drawing.Point(97, 115);
            this.currencyTextBox1.Metrocolor = System.Drawing.Color.Silver;
            this.currencyTextBox1.MinimumSize = new System.Drawing.Size(10, 6);
            this.currencyTextBox1.Name = "currencyTextBox1";
            this.currencyTextBox1.NullString = "";
            this.currencyTextBox1.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Black;
            this.currencyTextBox1.Office2010ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Black;
            this.currencyTextBox1.OverflowIndicatorToolTipText = "Text OverFlowing";
            this.currencyTextBox1.Size = new System.Drawing.Size(118, 29);
            this.currencyTextBox1.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Office2016Colorful;
            this.currencyTextBox1.TabIndex = 0;
            this.currencyTextBox1.Text = "$2.00";
            // 
            // integerTextBox1
            // 
            this.integerTextBox1.BackGroundColor = System.Drawing.SystemColors.Window;
            this.integerTextBox1.BeforeTouchSize = new System.Drawing.Size(130, 29);
            this.integerTextBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.integerTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.integerTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.integerTextBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.integerTextBox1.IntegerValue = ((long)(2));
            this.integerTextBox1.Location = new System.Drawing.Point(168, 261);
            this.integerTextBox1.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.integerTextBox1.Name = "integerTextBox1";
            this.integerTextBox1.NullString = "0";
            this.integerTextBox1.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Black;
            this.integerTextBox1.Office2010ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Black;
            this.integerTextBox1.OverflowIndicatorToolTipText = null;
            this.integerTextBox1.Size = new System.Drawing.Size(96, 29);
            this.integerTextBox1.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Office2016Colorful;
            this.integerTextBox1.TabIndex = 7;
            this.integerTextBox1.Text = "2";
            this.integerTextBox1.ThemesEnabled = false;
            this.integerTextBox1.IntegerValueChanged += new System.EventHandler(this.integerTextbox1_IntegerValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 261);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 46);
            this.label7.TabIndex = 6;
            this.label7.Text = "Decimal Digits \r\n(Between 0-99)";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.textBox1.BeforeTouchSize = new System.Drawing.Size(130, 29);
            this.textBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.textBox1.Location = new System.Drawing.Point(168, 214);
            this.textBox1.Metrocolor = System.Drawing.Color.Empty;
            this.textBox1.Name = "textBox1";
            this.textBox1.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Black;
            this.textBox1.Office2010ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Black;
            this.textBox1.Size = new System.Drawing.Size(96, 29);
            this.textBox1.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Office2016Colorful;
            this.textBox1.TabIndex = 5;
            this.textBox1.Text = "$";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 23);
            this.label4.TabIndex = 4;
            this.label4.Text = "Currency Symbol";
            // 
            // comboBoxAdv1
            // 
            this.comboBoxAdv1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.comboBoxAdv1.BeforeTouchSize = new System.Drawing.Size(111, 27);
            this.comboBoxAdv1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAdv1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxAdv1.Items.AddRange(new object[] {
            "Left",
            "Right",
            "Middle"});
            this.comboBoxAdv1.Location = new System.Drawing.Point(752, 69);
            this.comboBoxAdv1.Name = "comboBoxAdv1";
            this.comboBoxAdv1.Office2007ColorTheme = Syncfusion.Windows.Forms.Office2007Theme.Black;
            this.comboBoxAdv1.Office2010ColorTheme = Syncfusion.Windows.Forms.Office2010Theme.Managed;
            this.comboBoxAdv1.Size = new System.Drawing.Size(111, 27);
            this.comboBoxAdv1.Style = Syncfusion.Windows.Forms.VisualStyle.Office2016Colorful;
            this.comboBoxAdv1.TabIndex = 3;
            this.comboBoxAdv1.Text = "Left";
            this.comboBoxAdv1.SelectedIndexChanged += new System.EventHandler(this.comboBoxAdv1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(599, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Text Align";
            // 
            // checkBox1
            // 
            this.checkBox1.BeforeTouchSize = new System.Drawing.Size(198, 36);
            this.checkBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.DrawFocusRectangle = false;
            this.checkBox1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.checkBox1.HotBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.checkBox1.ImageCheckBoxSize = new System.Drawing.Size(16, 16);
            this.checkBox1.Location = new System.Drawing.Point(603, 177);
            this.checkBox1.MetroColor = System.Drawing.Color.Gray;
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Black;
            this.checkBox1.Office2010ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Black;
            this.checkBox1.Size = new System.Drawing.Size(198, 36);
            this.checkBox1.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Office2016Colorful;
            this.checkBox1.TabIndex = 1;
            this.checkBox1.Text = "ThemesEnabled";
            this.checkBox1.ThemesEnabled = false;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(599, 125);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 23);
            this.label6.TabIndex = 3;
            this.label6.Text = "Culture Settings";
            // 
            // comboBoxAdv2
            // 
            this.comboBoxAdv2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.comboBoxAdv2.BeforeTouchSize = new System.Drawing.Size(199, 27);
            this.comboBoxAdv2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAdv2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxAdv2.Location = new System.Drawing.Point(752, 125);
            this.comboBoxAdv2.Name = "comboBoxAdv2";
            this.comboBoxAdv2.Office2007ColorTheme = Syncfusion.Windows.Forms.Office2007Theme.Black;
            this.comboBoxAdv2.Office2010ColorTheme = Syncfusion.Windows.Forms.Office2010Theme.Managed;
            this.comboBoxAdv2.Size = new System.Drawing.Size(199, 27);
            this.comboBoxAdv2.Style = Syncfusion.Windows.Forms.VisualStyle.Office2016Colorful;
            this.comboBoxAdv2.TabIndex = 4;
            this.comboBoxAdv2.SelectedIndexChanged += new System.EventHandler(this.comboBoxAdv2_SelectedIndexChanged);
            // 
            // dataGrid1
            // 
            this.dataGrid1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGrid1.CaptionBackColor = System.Drawing.SystemColors.ControlLight;
            this.dataGrid1.DataMember = "";
            this.dataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.dataGrid1.Location = new System.Drawing.Point(960, 101);
            this.dataGrid1.Name = "dataGrid1";
            this.dataGrid1.Size = new System.Drawing.Size(336, 263);
            this.dataGrid1.TabIndex = 4;
            // 
            // checkBox2
            // 
            this.checkBox2.BeforeTouchSize = new System.Drawing.Size(213, 36);
            this.checkBox2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.checkBox2.DrawFocusRectangle = false;
            this.checkBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.checkBox2.HotBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.checkBox2.ImageCheckBoxSize = new System.Drawing.Size(16, 16);
            this.checkBox2.Location = new System.Drawing.Point(960, 57);
            this.checkBox2.MetroColor = System.Drawing.Color.Gray;
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Black;
            this.checkBox2.Office2010ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Black;
            this.checkBox2.Size = new System.Drawing.Size(213, 36);
            this.checkBox2.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Office2016Colorful;
            this.checkBox2.TabIndex = 2;
            this.checkBox2.Text = "Bind To DataBase";
            this.checkBox2.ThemesEnabled = false;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // oleDbDataAdapter1
            // 
            this.oleDbDataAdapter1.SelectCommand = this.oleDbSelectCommand1;
            this.oleDbDataAdapter1.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Sales", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("Amount", "Amount"),
                        new System.Data.Common.DataColumnMapping("ID", "ID"),
                        new System.Data.Common.DataColumnMapping("PurchaseDate", "PurchaseDate")})});
            // 
            // oleDbSelectCommand1
            // 
            this.oleDbSelectCommand1.CommandText = "SELECT Amount, ID, PurchaseDate FROM Sales";
            this.oleDbSelectCommand1.Connection = this.oleDbConnection1;
            // 
            // oleDbConnection1
            // 
            this.oleDbConnection1.ConnectionString = resources.GetString("oleDbConnection1.ConnectionString");
            // 
            // inputPanel
            // 
            this.inputPanel.AutoSize = true;
            this.inputPanel.BorderColor = System.Drawing.Color.Gainsboro;
            this.inputPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inputPanel.Controls.Add(this.gradientPanel11);
            this.inputPanel.Controls.Add(this.gradientPanel9);
            this.inputPanel.Controls.Add(this.gradientPanel7);
            this.inputPanel.Controls.Add(this.gradientPanel5);
            this.inputPanel.Controls.Add(this.gradientPanel1);
            this.inputPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inputPanel.Location = new System.Drawing.Point(0, 0);
            this.inputPanel.Name = "inputPanel";
            this.inputPanel.Size = new System.Drawing.Size(1350, 880);
            this.inputPanel.TabIndex = 8;
            // 
            // gradientPanel11
            // 
            this.gradientPanel11.BackColor = System.Drawing.Color.Transparent;
            this.gradientPanel11.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(178)))), ((int)(((byte)(227)))));
            this.gradientPanel11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gradientPanel11.Controls.Add(this.numericUpDownExt8);
            this.gradientPanel11.Controls.Add(this.label138);
            this.gradientPanel11.Controls.Add(this.bannerClr);
            this.gradientPanel11.Controls.Add(this.btnSetBanner);
            this.gradientPanel11.Controls.Add(this.cmbMode);
            this.gradientPanel11.Controls.Add(this.txtBnr);
            this.gradientPanel11.Controls.Add(this.label130);
            this.gradientPanel11.Controls.Add(this.label131);
            this.gradientPanel11.Controls.Add(this.label132);
            this.gradientPanel11.Controls.Add(this.label128);
            this.gradientPanel11.Controls.Add(this.checkBox20);
            this.gradientPanel11.Controls.Add(this.NegativeColorEdit);
            this.gradientPanel11.Controls.Add(this.label2);
            this.gradientPanel11.Controls.Add(this.label5);
            this.gradientPanel11.Controls.Add(this.dataGrid1);
            this.gradientPanel11.Controls.Add(this.label42);
            this.gradientPanel11.Controls.Add(this.comboBox6);
            this.gradientPanel11.Controls.Add(this.checkBox2);
            this.gradientPanel11.Controls.Add(this.label46);
            this.gradientPanel11.Controls.Add(this.label61);
            this.gradientPanel11.Controls.Add(this.radioButton6);
            this.gradientPanel11.Controls.Add(this.buttonEdit1);
            this.gradientPanel11.Controls.Add(this.radioButton7);
            this.gradientPanel11.Controls.Add(this.PositiveColorEdit);
            this.gradientPanel11.Controls.Add(this.label40);
            this.gradientPanel11.Controls.Add(this.comboBox5);
            this.gradientPanel11.Controls.Add(this.checkBox16);
            this.gradientPanel11.Controls.Add(this.label8);
            this.gradientPanel11.Controls.Add(this.label43);
            this.gradientPanel11.Controls.Add(this.label44);
            this.gradientPanel11.Controls.Add(this.comboBoxAdv1);
            this.gradientPanel11.Controls.Add(this.label3);
            this.gradientPanel11.Controls.Add(this.label6);
            this.gradientPanel11.Controls.Add(this.comboBoxAdv2);
            this.gradientPanel11.Controls.Add(this.checkBox1);
            this.gradientPanel11.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gradientPanel11.IgnoreThemeBackground = true;
            this.gradientPanel11.Location = new System.Drawing.Point(19, 445);
            this.gradientPanel11.Name = "gradientPanel11";
            this.gradientPanel11.Size = new System.Drawing.Size(1302, 421);
            this.gradientPanel11.TabIndex = 124;
            this.gradientPanel11.ThemesEnabled = true;
            // 
            // numericUpDownExt8
            // 
            this.numericUpDownExt8.BackColor = System.Drawing.Color.White;
            this.numericUpDownExt8.BeforeTouchSize = new System.Drawing.Size(145, 29);
            this.numericUpDownExt8.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.numericUpDownExt8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDownExt8.ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Black;
            this.numericUpDownExt8.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownExt8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.numericUpDownExt8.Location = new System.Drawing.Point(135, 147);
            this.numericUpDownExt8.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownExt8.MetroColor = System.Drawing.Color.Gray;
            this.numericUpDownExt8.Name = "numericUpDownExt8";
            this.numericUpDownExt8.Office2010ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Black;
            this.numericUpDownExt8.Size = new System.Drawing.Size(145, 29);
            this.numericUpDownExt8.TabIndex = 143;
            this.numericUpDownExt8.VisualStyle = Syncfusion.Windows.Forms.VisualStyle.Office2016Colorful;
            this.numericUpDownExt8.ValueChanged += new System.EventHandler(this.numericUpDownExt8_ValueChanged);
            // 
            // label138
            // 
            this.label138.AutoSize = true;
            this.label138.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label138.Location = new System.Drawing.Point(5, 148);
            this.label138.Name = "label138";
            this.label138.Size = new System.Drawing.Size(112, 23);
            this.label138.TabIndex = 141;
            this.label138.Text = "CornerRadius";
            // 
            // bannerClr
            // 
            this.bannerClr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bannerClr.BeforeTouchSize = new System.Drawing.Size(171, 35);
            this.bannerClr.Buttons.Add(this.buttonEditChildButton10);
            this.bannerClr.ButtonStyle = Syncfusion.Windows.Forms.ButtonAppearance.Office2016Colorful;
            this.bannerClr.Controls.Add(this.buttonEditChildButton10);
            this.bannerClr.Controls.Add(this.textBoxExt6);
            this.bannerClr.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.bannerClr.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bannerClr.Location = new System.Drawing.Point(392, 167);
            this.bannerClr.MetroColor = System.Drawing.Color.Gray;
            this.bannerClr.Name = "bannerClr";
            this.bannerClr.ShowTextBox = false;
            this.bannerClr.Size = new System.Drawing.Size(171, 35);
            this.bannerClr.TabIndex = 135;
            this.bannerClr.TextBox = this.textBoxExt6;
            this.bannerClr.UseVisualStyle = true;
            this.bannerClr.ButtonClicked += new Syncfusion.Windows.Forms.Tools.ButtonClickedEventHandler(this.bannerClr_ButtonClicked);
            // 
            // buttonEditChildButton10
            // 
            this.buttonEditChildButton10.BackColor = System.Drawing.Color.Gray;
            this.buttonEditChildButton10.BeforeTouchSize = new System.Drawing.Size(20, 31);
            this.buttonEditChildButton10.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.Flat;
            this.buttonEditChildButton10.ComboEditBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonEditChildButton10.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditChildButton10.Image = null;
            this.buttonEditChildButton10.IsBackStageButton = false;
            this.buttonEditChildButton10.Name = "buttonEditChildButton10";
            this.buttonEditChildButton10.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Black;
            this.buttonEditChildButton10.Office2010ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Black;
            this.buttonEditChildButton10.PreferredWidth = 20;
            this.buttonEditChildButton10.TabIndex = 1;
            this.buttonEditChildButton10.Text = "...";
            // 
            // textBoxExt6
            // 
            this.textBoxExt6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.textBoxExt6.BeforeTouchSize = new System.Drawing.Size(130, 29);
            this.textBoxExt6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.textBoxExt6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxExt6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.textBoxExt6.Location = new System.Drawing.Point(2, 3);
            this.textBoxExt6.Metrocolor = System.Drawing.Color.Empty;
            this.textBoxExt6.Name = "textBoxExt6";
            this.textBoxExt6.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Black;
            this.textBoxExt6.Office2010ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Black;
            this.textBoxExt6.OverflowIndicatorToolTipText = null;
            this.textBoxExt6.Size = new System.Drawing.Size(147, 29);
            this.textBoxExt6.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Office2016Colorful;
            this.textBoxExt6.TabIndex = 0;
            // 
            // btnSetBanner
            // 
            this.btnSetBanner.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2016Black;
            this.btnSetBanner.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.btnSetBanner.BeforeTouchSize = new System.Drawing.Size(171, 33);
            this.btnSetBanner.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetBanner.IsBackStageButton = false;
            this.btnSetBanner.Location = new System.Drawing.Point(392, 232);
            this.btnSetBanner.Name = "btnSetBanner";
            this.btnSetBanner.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Black;
            this.btnSetBanner.Office2010ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Black;
            this.btnSetBanner.Size = new System.Drawing.Size(171, 33);
            this.btnSetBanner.TabIndex = 2;
            this.btnSetBanner.Text = "Set Banner Text";
            this.btnSetBanner.UseVisualStyle = true;
            this.btnSetBanner.UseVisualStyleBackColor = true;
            this.btnSetBanner.Click += new System.EventHandler(this.btnSetBanner_Click);
            // 
            // cmbMode
            // 
            this.cmbMode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbMode.BeforeTouchSize = new System.Drawing.Size(171, 31);
            this.cmbMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMode.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMode.Items.AddRange(new object[] {
            "EditMode",
            "FocusMode"});
            this.cmbMode.Location = new System.Drawing.Point(392, 115);
            this.cmbMode.Name = "cmbMode";
            this.cmbMode.Office2007ColorTheme = Syncfusion.Windows.Forms.Office2007Theme.Black;
            this.cmbMode.Office2010ColorTheme = Syncfusion.Windows.Forms.Office2010Theme.Managed;
            this.cmbMode.Size = new System.Drawing.Size(171, 31);
            this.cmbMode.Style = Syncfusion.Windows.Forms.VisualStyle.Office2016Colorful;
            this.cmbMode.TabIndex = 134;
            this.cmbMode.Text = "EditMode";
            // 
            // txtBnr
            // 
            this.txtBnr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtBnr.BeforeTouchSize = new System.Drawing.Size(130, 29);
            this.txtBnr.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.txtBnr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBnr.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBnr.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBnr.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.txtBnr.Location = new System.Drawing.Point(392, 60);
            this.txtBnr.Metrocolor = System.Drawing.Color.Silver;
            this.txtBnr.Name = "txtBnr";
            this.txtBnr.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Black;
            this.txtBnr.Office2010ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Black;
            this.txtBnr.Size = new System.Drawing.Size(171, 29);
            this.txtBnr.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Office2016Colorful;
            this.txtBnr.TabIndex = 130;
            this.txtBnr.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBnr_KeyPress);
            // 
            // label130
            // 
            this.label130.AutoSize = true;
            this.label130.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label130.Location = new System.Drawing.Point(305, 63);
            this.label130.Name = "label130";
            this.label130.Size = new System.Drawing.Size(40, 23);
            this.label130.TabIndex = 131;
            this.label130.Text = "Text";
            // 
            // label131
            // 
            this.label131.AutoSize = true;
            this.label131.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label131.Location = new System.Drawing.Point(304, 119);
            this.label131.Name = "label131";
            this.label131.Size = new System.Drawing.Size(54, 23);
            this.label131.TabIndex = 132;
            this.label131.Text = "Mode";
            // 
            // label132
            // 
            this.label132.AutoSize = true;
            this.label132.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label132.Location = new System.Drawing.Point(304, 177);
            this.label132.Name = "label132";
            this.label132.Size = new System.Drawing.Size(51, 23);
            this.label132.TabIndex = 133;
            this.label132.Text = "Color";
            // 
            // label128
            // 
            this.label128.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label128.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label128.Location = new System.Drawing.Point(304, 5);
            this.label128.Name = "label128";
            this.label128.Size = new System.Drawing.Size(227, 34);
            this.label128.TabIndex = 122;
            this.label128.Text = "BannerText Settings";
            this.label128.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // checkBox20
            // 
            this.checkBox20.BeforeTouchSize = new System.Drawing.Size(286, 35);
            this.checkBox20.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.checkBox20.DrawFocusRectangle = false;
            this.checkBox20.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.checkBox20.HotBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.checkBox20.ImageCheckBoxSize = new System.Drawing.Size(16, 16);
            this.checkBox20.Location = new System.Drawing.Point(603, 283);
            this.checkBox20.MetroColor = System.Drawing.Color.Gray;
            this.checkBox20.Name = "checkBox20";
            this.checkBox20.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Black;
            this.checkBox20.Office2010ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Black;
            this.checkBox20.Size = new System.Drawing.Size(286, 35);
            this.checkBox20.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Office2016Colorful;
            this.checkBox20.TabIndex = 120;
            this.checkBox20.Text = "OverFlowIndicatorToolTip";
            this.checkBox20.ThemesEnabled = false;
            this.checkBox20.CheckedChanged += new System.EventHandler(this.checkBox20_CheckedChanged);
            // 
            // NegativeColorEdit
            // 
            this.NegativeColorEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.NegativeColorEdit.BeforeTouchSize = new System.Drawing.Size(145, 35);
            this.NegativeColorEdit.Buttons.Add(this.buttonEditChildButton1);
            this.NegativeColorEdit.ButtonStyle = Syncfusion.Windows.Forms.ButtonAppearance.Office2016Colorful;
            this.NegativeColorEdit.Controls.Add(this.buttonEditChildButton1);
            this.NegativeColorEdit.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.NegativeColorEdit.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NegativeColorEdit.Location = new System.Drawing.Point(135, 323);
            this.NegativeColorEdit.MetroColor = System.Drawing.Color.Gray;
            this.NegativeColorEdit.Name = "NegativeColorEdit";
            this.NegativeColorEdit.ShowTextBox = false;
            this.NegativeColorEdit.Size = new System.Drawing.Size(145, 35);
            this.NegativeColorEdit.TabIndex = 118;
            this.NegativeColorEdit.UseVisualStyle = true;
            this.NegativeColorEdit.ButtonClicked += new Syncfusion.Windows.Forms.Tools.ButtonClickedEventHandler(this.NegativeColorEdit_ButtonClicked);
            // 
            // buttonEditChildButton1
            // 
            this.buttonEditChildButton1.BackColor = System.Drawing.Color.Gray;
            this.buttonEditChildButton1.BeforeTouchSize = new System.Drawing.Size(18, 31);
            this.buttonEditChildButton1.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.Flat;
            this.buttonEditChildButton1.ComboEditBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonEditChildButton1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditChildButton1.Image = null;
            this.buttonEditChildButton1.IsBackStageButton = false;
            this.buttonEditChildButton1.Name = "buttonEditChildButton1";
            this.buttonEditChildButton1.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Black;
            this.buttonEditChildButton1.Office2010ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Black;
            this.buttonEditChildButton1.PreferredWidth = 18;
            this.buttonEditChildButton1.TabIndex = 1;
            this.buttonEditChildButton1.Text = "...";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 280);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 23);
            this.label2.TabIndex = 21;
            this.label2.Text = "Positive Color";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(5, 329);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 23);
            this.label5.TabIndex = 22;
            this.label5.Text = "Negative Color";
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label42.Location = new System.Drawing.Point(5, 377);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(102, 23);
            this.label42.TabIndex = 48;
            this.label42.Text = "Metro Color";
            // 
            // comboBox6
            // 
            this.comboBox6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.comboBox6.BeforeTouchSize = new System.Drawing.Size(145, 31);
            this.comboBox6.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox6.Enabled = false;
            this.comboBox6.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.comboBox6.Location = new System.Drawing.Point(135, 185);
            this.comboBox6.Name = "comboBox6";
            this.comboBox6.Office2007ColorTheme = Syncfusion.Windows.Forms.Office2007Theme.Black;
            this.comboBox6.Office2010ColorTheme = Syncfusion.Windows.Forms.Office2010Theme.Managed;
            this.comboBox6.Size = new System.Drawing.Size(145, 31);
            this.comboBox6.Style = Syncfusion.Windows.Forms.VisualStyle.Office2016Colorful;
            this.comboBox6.TabIndex = 49;
            this.comboBox6.SelectedIndexChanged += new System.EventHandler(this.comboBox6_SelectedIndexChanged);
            // 
            // label46
            // 
            this.label46.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label46.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label46.Location = new System.Drawing.Point(15, -1);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(226, 35);
            this.label46.TabIndex = 75;
            this.label46.Text = "Appearance Settings";
            this.label46.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label61
            // 
            this.label61.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label61.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label61.Location = new System.Drawing.Point(600, 5);
            this.label61.Name = "label61";
            this.label61.Size = new System.Drawing.Size(201, 34);
            this.label61.TabIndex = 79;
            this.label61.Text = "Behavior Settings";
            this.label61.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // radioButton6
            // 
            this.radioButton6.BeforeTouchSize = new System.Drawing.Size(145, 38);
            this.radioButton6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.radioButton6.DrawFocusRectangle = false;
            this.radioButton6.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.radioButton6.HotBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.radioButton6.ImageCheckBoxSize = new System.Drawing.Size(16, 16);
            this.radioButton6.Location = new System.Drawing.Point(135, 101);
            this.radioButton6.MetroColor = System.Drawing.Color.Gray;
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Black;
            this.radioButton6.Office2010ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Black;
            this.radioButton6.Size = new System.Drawing.Size(145, 38);
            this.radioButton6.Style = Syncfusion.Windows.Forms.Tools.RadioButtonAdvStyle.Office2016Colorful;
            this.radioButton6.TabIndex = 54;
            this.radioButton6.TabStop = false;
            this.radioButton6.Text = "Fixed3D";
            this.radioButton6.ThemesEnabled = true;
            this.radioButton6.CheckChanged += new System.EventHandler(this.radioButton6_CheckedChanged);
            // 
            // buttonEdit1
            // 
            this.buttonEdit1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonEdit1.BeforeTouchSize = new System.Drawing.Size(145, 35);
            this.buttonEdit1.Buttons.Add(this.buttonEditChildButton2);
            this.buttonEdit1.ButtonStyle = Syncfusion.Windows.Forms.ButtonAppearance.Office2016Colorful;
            this.buttonEdit1.Controls.Add(this.buttonEditChildButton2);
            this.buttonEdit1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonEdit1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEdit1.Location = new System.Drawing.Point(135, 367);
            this.buttonEdit1.MetroColor = System.Drawing.Color.Gray;
            this.buttonEdit1.Name = "buttonEdit1";
            this.buttonEdit1.ShowTextBox = false;
            this.buttonEdit1.Size = new System.Drawing.Size(145, 35);
            this.buttonEdit1.TabIndex = 119;
            this.buttonEdit1.UseVisualStyle = true;
            this.buttonEdit1.ButtonClicked += new Syncfusion.Windows.Forms.Tools.ButtonClickedEventHandler(this.buttonEdit1_ButtonClicked);
            // 
            // buttonEditChildButton2
            // 
            this.buttonEditChildButton2.BackColor = System.Drawing.Color.Gray;
            this.buttonEditChildButton2.BeforeTouchSize = new System.Drawing.Size(18, 31);
            this.buttonEditChildButton2.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.Flat;
            this.buttonEditChildButton2.ComboEditBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonEditChildButton2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditChildButton2.Image = null;
            this.buttonEditChildButton2.IsBackStageButton = false;
            this.buttonEditChildButton2.Name = "buttonEditChildButton2";
            this.buttonEditChildButton2.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Black;
            this.buttonEditChildButton2.Office2010ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Black;
            this.buttonEditChildButton2.PreferredWidth = 18;
            this.buttonEditChildButton2.TabIndex = 1;
            this.buttonEditChildButton2.Text = "...";
            // 
            // radioButton7
            // 
            this.radioButton7.BeforeTouchSize = new System.Drawing.Size(145, 38);
            this.radioButton7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.radioButton7.Checked = true;
            this.radioButton7.DrawFocusRectangle = false;
            this.radioButton7.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.radioButton7.HotBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.radioButton7.ImageCheckBoxSize = new System.Drawing.Size(16, 16);
            this.radioButton7.Location = new System.Drawing.Point(135, 60);
            this.radioButton7.MetroColor = System.Drawing.Color.Gray;
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Black;
            this.radioButton7.Office2010ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Black;
            this.radioButton7.Size = new System.Drawing.Size(145, 38);
            this.radioButton7.Style = Syncfusion.Windows.Forms.Tools.RadioButtonAdvStyle.Office2016Colorful;
            this.radioButton7.TabIndex = 53;
            this.radioButton7.Text = "FixedSingle";
            this.radioButton7.ThemesEnabled = true;
            this.radioButton7.CheckChanged += new System.EventHandler(this.radioButton7_CheckedChanged);
            // 
            // PositiveColorEdit
            // 
            this.PositiveColorEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.PositiveColorEdit.BeforeTouchSize = new System.Drawing.Size(145, 35);
            this.PositiveColorEdit.Buttons.Add(this.buttonEditChildButton5);
            this.PositiveColorEdit.ButtonStyle = Syncfusion.Windows.Forms.ButtonAppearance.Office2016Colorful;
            this.PositiveColorEdit.Controls.Add(this.buttonEditChildButton5);
            this.PositiveColorEdit.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.PositiveColorEdit.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PositiveColorEdit.Location = new System.Drawing.Point(135, 280);
            this.PositiveColorEdit.MetroColor = System.Drawing.Color.Gray;
            this.PositiveColorEdit.Name = "PositiveColorEdit";
            this.PositiveColorEdit.ShowTextBox = false;
            this.PositiveColorEdit.Size = new System.Drawing.Size(145, 35);
            this.PositiveColorEdit.TabIndex = 117;
            this.PositiveColorEdit.UseVisualStyle = true;
            this.PositiveColorEdit.ButtonClicked += new Syncfusion.Windows.Forms.Tools.ButtonClickedEventHandler(this.PositiveColorEdit_ButtonClicked);
            // 
            // buttonEditChildButton5
            // 
            this.buttonEditChildButton5.BackColor = System.Drawing.Color.Gray;
            this.buttonEditChildButton5.BeforeTouchSize = new System.Drawing.Size(18, 31);
            this.buttonEditChildButton5.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.Flat;
            this.buttonEditChildButton5.ComboEditBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonEditChildButton5.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditChildButton5.Image = null;
            this.buttonEditChildButton5.IsBackStageButton = false;
            this.buttonEditChildButton5.Name = "buttonEditChildButton5";
            this.buttonEditChildButton5.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Black;
            this.buttonEditChildButton5.Office2010ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Black;
            this.buttonEditChildButton5.PreferredWidth = 18;
            this.buttonEditChildButton5.TabIndex = 1;
            this.buttonEditChildButton5.Text = "...";
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label40.Location = new System.Drawing.Point(3, 69);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(101, 23);
            this.label40.TabIndex = 52;
            this.label40.Text = "Border Style";
            // 
            // comboBox5
            // 
            this.comboBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.comboBox5.BeforeTouchSize = new System.Drawing.Size(145, 31);
            this.comboBox5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox5.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.comboBox5.Items.AddRange(new object[] {
            "Left",
            "Top",
            "Right",
            "Bottom",
            "Middle",
            "All"});
            this.comboBox5.Location = new System.Drawing.Point(135, 230);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Office2007ColorTheme = Syncfusion.Windows.Forms.Office2007Theme.Black;
            this.comboBox5.Office2010ColorTheme = Syncfusion.Windows.Forms.Office2010Theme.Managed;
            this.comboBox5.Size = new System.Drawing.Size(145, 31);
            this.comboBox5.Style = Syncfusion.Windows.Forms.VisualStyle.Office2016Colorful;
            this.comboBox5.TabIndex = 50;
            this.comboBox5.Text = "Left";
            this.comboBox5.SelectedIndexChanged += new System.EventHandler(this.comboBox5_SelectedIndexChanged);
            // 
            // checkBox16
            // 
            this.checkBox16.BeforeTouchSize = new System.Drawing.Size(198, 35);
            this.checkBox16.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.checkBox16.DrawFocusRectangle = false;
            this.checkBox16.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.checkBox16.HotBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.checkBox16.ImageCheckBoxSize = new System.Drawing.Size(16, 16);
            this.checkBox16.Location = new System.Drawing.Point(601, 230);
            this.checkBox16.MetroColor = System.Drawing.Color.Gray;
            this.checkBox16.Name = "checkBox16";
            this.checkBox16.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Black;
            this.checkBox16.Office2010ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Black;
            this.checkBox16.Size = new System.Drawing.Size(198, 35);
            this.checkBox16.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Office2016Colorful;
            this.checkBox16.TabIndex = 60;
            this.checkBox16.Text = "OverFlowIndicator";
            this.checkBox16.ThemesEnabled = false;
            this.checkBox16.CheckedChanged += new System.EventHandler(this.checkBox16_CheckedChanged);
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label8.Location = new System.Drawing.Point(955, 3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(158, 35);
            this.label8.TabIndex = 24;
            this.label8.Text = "Data Binding";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label43.Location = new System.Drawing.Point(5, 232);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(105, 23);
            this.label43.TabIndex = 47;
            this.label43.Text = "Border Sides";
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label44.Location = new System.Drawing.Point(5, 183);
            this.label44.Margin = new System.Windows.Forms.Padding(0);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(122, 23);
            this.label44.TabIndex = 46;
            this.label44.Text = "Border3D Style";
            // 
            // gradientPanel9
            // 
            this.gradientPanel9.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(178)))), ((int)(((byte)(227)))));
            this.gradientPanel9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gradientPanel9.Controls.Add(this.currencyTextBox1);
            this.gradientPanel9.Controls.Add(this.label1);
            this.gradientPanel9.Controls.Add(this.gradientPanel12);
            this.gradientPanel9.Controls.Add(this.label4);
            this.gradientPanel9.Controls.Add(this.textBox1);
            this.gradientPanel9.Controls.Add(this.label7);
            this.gradientPanel9.Controls.Add(this.integerTextBox1);
            this.gradientPanel9.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gradientPanel9.IgnoreThemeBackground = true;
            this.gradientPanel9.Location = new System.Drawing.Point(19, 10);
            this.gradientPanel9.Name = "gradientPanel9";
            this.gradientPanel9.Size = new System.Drawing.Size(309, 408);
            this.gradientPanel9.TabIndex = 123;
            this.gradientPanel9.ThemesEnabled = true;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(5, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 35);
            this.label1.TabIndex = 127;
            this.label1.Text = "Properties";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gradientPanel12
            // 
            this.gradientPanel12.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(178)))), ((int)(((byte)(227)))));
            this.gradientPanel12.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gradientPanel12.Controls.Add(this.label45);
            this.gradientPanel12.Controls.Add(this.label47);
            this.gradientPanel12.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gradientPanel12.Location = new System.Drawing.Point(5, -1);
            this.gradientPanel12.Name = "gradientPanel12";
            this.gradientPanel12.Size = new System.Drawing.Size(250, 111);
            this.gradientPanel12.TabIndex = 124;
            this.gradientPanel12.ThemesEnabled = true;
            // 
            // label45
            // 
            this.label45.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label45.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label45.Location = new System.Drawing.Point(0, 27);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(250, 84);
            this.label45.TabIndex = 1;
            this.label45.Text = "CurrencyTextBox control is a textbox derived control for different currencies pre" +
    "sent.";
            // 
            // label47
            // 
            this.label47.Dock = System.Windows.Forms.DockStyle.Top;
            this.label47.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label47.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label47.Location = new System.Drawing.Point(0, 0);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(250, 27);
            this.label47.TabIndex = 123;
            this.label47.Text = "CurrencyTextBox";
            this.label47.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gradientPanel7
            // 
            this.gradientPanel7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(178)))), ((int)(((byte)(227)))));
            this.gradientPanel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gradientPanel7.Controls.Add(this.integerTextBox2);
            this.gradientPanel7.Controls.Add(this.label50);
            this.gradientPanel7.Controls.Add(this.gradientPanel10);
            this.gradientPanel7.Controls.Add(this.label69);
            this.gradientPanel7.Controls.Add(this.numericUpDownExt1);
            this.gradientPanel7.Controls.Add(this.label68);
            this.gradientPanel7.Controls.Add(this.textBox4);
            this.gradientPanel7.Controls.Add(this.numericUpDownExt3);
            this.gradientPanel7.Controls.Add(this.label67);
            this.gradientPanel7.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gradientPanel7.IgnoreThemeBackground = true;
            this.gradientPanel7.Location = new System.Drawing.Point(351, 10);
            this.gradientPanel7.Name = "gradientPanel7";
            this.gradientPanel7.Size = new System.Drawing.Size(308, 408);
            this.gradientPanel7.TabIndex = 122;
            this.gradientPanel7.ThemesEnabled = true;
            // 
            // integerTextBox2
            // 
            this.integerTextBox2.BackGroundColor = System.Drawing.SystemColors.Window;
            this.integerTextBox2.BeforeTouchSize = new System.Drawing.Size(130, 29);
            this.integerTextBox2.Border3DStyle = System.Windows.Forms.Border3DStyle.RaisedOuter;
            this.integerTextBox2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.integerTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.integerTextBox2.Culture = new System.Globalization.CultureInfo("bg-BG");
            this.integerTextBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.integerTextBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.integerTextBox2.IntegerValue = ((long)(2));
            this.integerTextBox2.Location = new System.Drawing.Point(81, 116);
            this.integerTextBox2.Metrocolor = System.Drawing.Color.Silver;
            this.integerTextBox2.Name = "integerTextBox2";
            this.integerTextBox2.NullString = "";
            this.integerTextBox2.NumberGroupSizes = new int[] {
        2};
            this.integerTextBox2.NumberNegativePattern = 2;
            this.integerTextBox2.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Black;
            this.integerTextBox2.Office2010ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Black;
            this.integerTextBox2.OverflowIndicatorToolTipText = "Text OverFlowing";
            this.integerTextBox2.Size = new System.Drawing.Size(118, 29);
            this.integerTextBox2.SpecialCultureValue = Syncfusion.Windows.Forms.Tools.SpecialCultureValues.None;
            this.integerTextBox2.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Office2016Colorful;
            this.integerTextBox2.TabIndex = 0;
            this.integerTextBox2.Text = "2";
            // 
            // label50
            // 
            this.label50.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label50.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label50.Location = new System.Drawing.Point(5, 170);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(130, 35);
            this.label50.TabIndex = 127;
            this.label50.Text = "Properties";
            this.label50.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gradientPanel10
            // 
            this.gradientPanel10.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(178)))), ((int)(((byte)(227)))));
            this.gradientPanel10.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gradientPanel10.Controls.Add(this.label57);
            this.gradientPanel10.Controls.Add(this.label63);
            this.gradientPanel10.Dock = System.Windows.Forms.DockStyle.Top;
            this.gradientPanel10.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gradientPanel10.Location = new System.Drawing.Point(0, 0);
            this.gradientPanel10.Name = "gradientPanel10";
            this.gradientPanel10.Size = new System.Drawing.Size(306, 111);
            this.gradientPanel10.TabIndex = 123;
            this.gradientPanel10.ThemesEnabled = true;
            // 
            // label57
            // 
            this.label57.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label57.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label57.Location = new System.Drawing.Point(0, 27);
            this.label57.Name = "label57";
            this.label57.Size = new System.Drawing.Size(306, 84);
            this.label57.TabIndex = 1;
            this.label57.Text = "Integer TextBox is used to display Int64 values ";
            // 
            // label63
            // 
            this.label63.Dock = System.Windows.Forms.DockStyle.Top;
            this.label63.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label63.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label63.Location = new System.Drawing.Point(0, 0);
            this.label63.Name = "label63";
            this.label63.Size = new System.Drawing.Size(306, 27);
            this.label63.TabIndex = 123;
            this.label63.Text = "IntegerTextBox";
            this.label63.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label69
            // 
            this.label69.AutoSize = true;
            this.label69.Location = new System.Drawing.Point(9, 214);
            this.label69.Name = "label69";
            this.label69.Size = new System.Drawing.Size(138, 23);
            this.label69.TabIndex = 90;
            this.label69.Text = "Negative Pattern";
            // 
            // numericUpDownExt1
            // 
            this.numericUpDownExt1.BackColor = System.Drawing.Color.White;
            this.numericUpDownExt1.BeforeTouchSize = new System.Drawing.Size(90, 29);
            this.numericUpDownExt1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.numericUpDownExt1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDownExt1.ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Black;
            this.numericUpDownExt1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.numericUpDownExt1.Location = new System.Drawing.Point(169, 210);
            this.numericUpDownExt1.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numericUpDownExt1.MetroColor = System.Drawing.Color.Silver;
            this.numericUpDownExt1.Name = "numericUpDownExt1";
            this.numericUpDownExt1.Office2010ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Black;
            this.numericUpDownExt1.Size = new System.Drawing.Size(90, 29);
            this.numericUpDownExt1.TabIndex = 92;
            this.numericUpDownExt1.VisualStyle = Syncfusion.Windows.Forms.VisualStyle.Office2016Colorful;
            this.numericUpDownExt1.ValueChanged += new System.EventHandler(this.numericUpDownExt1_ValueChanged);
            // 
            // label68
            // 
            this.label68.AutoSize = true;
            this.label68.Location = new System.Drawing.Point(9, 261);
            this.label68.Name = "label68";
            this.label68.Size = new System.Drawing.Size(137, 23);
            this.label68.TabIndex = 86;
            this.label68.Text = "Group Separator";
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.textBox4.BeforeTouchSize = new System.Drawing.Size(130, 29);
            this.textBox4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.textBox4.Location = new System.Drawing.Point(169, 261);
            this.textBox4.Metrocolor = System.Drawing.Color.Empty;
            this.textBox4.Name = "textBox4";
            this.textBox4.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Black;
            this.textBox4.Office2010ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Black;
            this.textBox4.Size = new System.Drawing.Size(90, 29);
            this.textBox4.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Office2016Colorful;
            this.textBox4.TabIndex = 89;
            this.textBox4.Text = ",";
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // numericUpDownExt3
            // 
            this.numericUpDownExt3.BackColor = System.Drawing.Color.White;
            this.numericUpDownExt3.BeforeTouchSize = new System.Drawing.Size(90, 29);
            this.numericUpDownExt3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.numericUpDownExt3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDownExt3.ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Black;
            this.numericUpDownExt3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.numericUpDownExt3.Location = new System.Drawing.Point(169, 313);
            this.numericUpDownExt3.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.numericUpDownExt3.MetroColor = System.Drawing.Color.Silver;
            this.numericUpDownExt3.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownExt3.Name = "numericUpDownExt3";
            this.numericUpDownExt3.Office2010ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Black;
            this.numericUpDownExt3.Size = new System.Drawing.Size(90, 29);
            this.numericUpDownExt3.TabIndex = 104;
            this.numericUpDownExt3.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDownExt3.VisualStyle = Syncfusion.Windows.Forms.VisualStyle.Office2016Colorful;
            this.numericUpDownExt3.ValueChanged += new System.EventHandler(this.numericUpDownExt3_ValueChanged);
            // 
            // label67
            // 
            this.label67.AutoSize = true;
            this.label67.Location = new System.Drawing.Point(9, 308);
            this.label67.Name = "label67";
            this.label67.Size = new System.Drawing.Size(100, 23);
            this.label67.TabIndex = 87;
            this.label67.Text = "Group Sizes";
            // 
            // gradientPanel5
            // 
            this.gradientPanel5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(178)))), ((int)(((byte)(227)))));
            this.gradientPanel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gradientPanel5.Controls.Add(this.label48);
            this.gradientPanel5.Controls.Add(this.percentTextBox1);
            this.gradientPanel5.Controls.Add(this.gradientPanel8);
            this.gradientPanel5.Controls.Add(this.label73);
            this.gradientPanel5.Controls.Add(this.textBox6);
            this.gradientPanel5.Controls.Add(this.label72);
            this.gradientPanel5.Controls.Add(this.numericUpDownExt5);
            this.gradientPanel5.Controls.Add(this.integerTextBox7);
            this.gradientPanel5.Controls.Add(this.label76);
            this.gradientPanel5.Controls.Add(this.label70);
            this.gradientPanel5.Controls.Add(this.numericUpDownExt4);
            this.gradientPanel5.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gradientPanel5.IgnoreThemeBackground = true;
            this.gradientPanel5.Location = new System.Drawing.Point(1013, 12);
            this.gradientPanel5.Name = "gradientPanel5";
            this.gradientPanel5.Size = new System.Drawing.Size(308, 407);
            this.gradientPanel5.TabIndex = 121;
            this.gradientPanel5.ThemesEnabled = true;
            // 
            // label48
            // 
            this.label48.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label48.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label48.Location = new System.Drawing.Point(5, 169);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(136, 35);
            this.label48.TabIndex = 125;
            this.label48.Text = "Properties";
            this.label48.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // percentTextBox1
            // 
            this.percentTextBox1.BackGroundColor = System.Drawing.SystemColors.Window;
            this.percentTextBox1.BeforeTouchSize = new System.Drawing.Size(130, 29);
            this.percentTextBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.percentTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.percentTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.percentTextBox1.DoubleValue = 0.53D;
            this.percentTextBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.percentTextBox1.Location = new System.Drawing.Point(93, 113);
            this.percentTextBox1.MaxValue = 100D;
            this.percentTextBox1.Metrocolor = System.Drawing.Color.Silver;
            this.percentTextBox1.MinValue = -100D;
            this.percentTextBox1.Name = "percentTextBox1";
            this.percentTextBox1.NullString = "";
            this.percentTextBox1.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Black;
            this.percentTextBox1.Office2010ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Black;
            this.percentTextBox1.OverflowIndicatorToolTipText = "Text OverFlowing";
            this.percentTextBox1.PercentGroupSeparator = "@";
            this.percentTextBox1.PercentGroupSizes = new int[] {
        2};
            this.percentTextBox1.Size = new System.Drawing.Size(116, 29);
            this.percentTextBox1.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Office2016Colorful;
            this.percentTextBox1.TabIndex = 0;
            this.percentTextBox1.Text = "53.00%";
            // 
            // gradientPanel8
            // 
            this.gradientPanel8.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(178)))), ((int)(((byte)(227)))));
            this.gradientPanel8.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gradientPanel8.Controls.Add(this.label38);
            this.gradientPanel8.Controls.Add(this.label56);
            this.gradientPanel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.gradientPanel8.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gradientPanel8.Location = new System.Drawing.Point(0, 0);
            this.gradientPanel8.Name = "gradientPanel8";
            this.gradientPanel8.Size = new System.Drawing.Size(306, 111);
            this.gradientPanel8.TabIndex = 123;
            this.gradientPanel8.ThemesEnabled = true;
            // 
            // label38
            // 
            this.label38.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label38.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label38.Location = new System.Drawing.Point(0, 27);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(306, 84);
            this.label38.TabIndex = 1;
            this.label38.Text = "PercentTextBox is used to display percentage values. ";
            // 
            // label56
            // 
            this.label56.Dock = System.Windows.Forms.DockStyle.Top;
            this.label56.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label56.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label56.Location = new System.Drawing.Point(0, 0);
            this.label56.Name = "label56";
            this.label56.Size = new System.Drawing.Size(306, 27);
            this.label56.TabIndex = 123;
            this.label56.Text = "PercentTextBox";
            this.label56.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label73
            // 
            this.label73.AutoSize = true;
            this.label73.Location = new System.Drawing.Point(19, 259);
            this.label73.Name = "label73";
            this.label73.Size = new System.Drawing.Size(148, 23);
            this.label73.TabIndex = 93;
            this.label73.Text = "Decimal separator";
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.textBox6.BeforeTouchSize = new System.Drawing.Size(130, 29);
            this.textBox6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox6.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.textBox6.Location = new System.Drawing.Point(173, 251);
            this.textBox6.Metrocolor = System.Drawing.Color.Empty;
            this.textBox6.Name = "textBox6";
            this.textBox6.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Black;
            this.textBox6.Office2010ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Black;
            this.textBox6.Size = new System.Drawing.Size(84, 29);
            this.textBox6.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Office2016Colorful;
            this.textBox6.TabIndex = 94;
            this.textBox6.Text = ".";
            this.textBox6.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // label72
            // 
            this.label72.AutoSize = true;
            this.label72.Location = new System.Drawing.Point(19, 307);
            this.label72.Name = "label72";
            this.label72.Size = new System.Drawing.Size(124, 46);
            this.label72.TabIndex = 95;
            this.label72.Text = "Decimal Digits\r\n(Between 0-99)";
            // 
            // numericUpDownExt5
            // 
            this.numericUpDownExt5.BackColor = System.Drawing.Color.White;
            this.numericUpDownExt5.BeforeTouchSize = new System.Drawing.Size(85, 29);
            this.numericUpDownExt5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.numericUpDownExt5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDownExt5.ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Black;
            this.numericUpDownExt5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.numericUpDownExt5.Location = new System.Drawing.Point(171, 204);
            this.numericUpDownExt5.MetroColor = System.Drawing.Color.Silver;
            this.numericUpDownExt5.Name = "numericUpDownExt5";
            this.numericUpDownExt5.Office2010ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Black;
            this.numericUpDownExt5.Size = new System.Drawing.Size(85, 29);
            this.numericUpDownExt5.TabIndex = 108;
            this.numericUpDownExt5.Value = new decimal(new int[] {
            52,
            0,
            0,
            0});
            this.numericUpDownExt5.VisualStyle = Syncfusion.Windows.Forms.VisualStyle.Office2016Colorful;
            this.numericUpDownExt5.ValueChanged += new System.EventHandler(this.numericUpDownExt5_ValueChanged);
            // 
            // integerTextBox7
            // 
            this.integerTextBox7.BackGroundColor = System.Drawing.SystemColors.Window;
            this.integerTextBox7.BeforeTouchSize = new System.Drawing.Size(130, 29);
            this.integerTextBox7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.integerTextBox7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.integerTextBox7.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.integerTextBox7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.integerTextBox7.IntegerValue = ((long)(2));
            this.integerTextBox7.Location = new System.Drawing.Point(173, 298);
            this.integerTextBox7.Metrocolor = System.Drawing.Color.Silver;
            this.integerTextBox7.Name = "integerTextBox7";
            this.integerTextBox7.NullString = "0";
            this.integerTextBox7.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Black;
            this.integerTextBox7.Office2010ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Black;
            this.integerTextBox7.OverflowIndicatorToolTipText = null;
            this.integerTextBox7.Size = new System.Drawing.Size(84, 29);
            this.integerTextBox7.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Office2016Colorful;
            this.integerTextBox7.TabIndex = 96;
            this.integerTextBox7.Text = "2";
            this.integerTextBox7.ThemesEnabled = false;
            this.integerTextBox7.TextChanged += new System.EventHandler(this.integerTextBox7_TextChanged);
            // 
            // label76
            // 
            this.label76.AutoSize = true;
            this.label76.Location = new System.Drawing.Point(19, 213);
            this.label76.Name = "label76";
            this.label76.Size = new System.Drawing.Size(114, 23);
            this.label76.TabIndex = 107;
            this.label76.Text = "Percent Value";
            // 
            // label70
            // 
            this.label70.AutoSize = true;
            this.label70.Location = new System.Drawing.Point(19, 353);
            this.label70.Name = "label70";
            this.label70.Size = new System.Drawing.Size(127, 23);
            this.label70.TabIndex = 98;
            this.label70.Text = "Positive Pattern";
            // 
            // numericUpDownExt4
            // 
            this.numericUpDownExt4.BackColor = System.Drawing.Color.White;
            this.numericUpDownExt4.BeforeTouchSize = new System.Drawing.Size(85, 29);
            this.numericUpDownExt4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.numericUpDownExt4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDownExt4.ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Black;
            this.numericUpDownExt4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.numericUpDownExt4.Location = new System.Drawing.Point(171, 345);
            this.numericUpDownExt4.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericUpDownExt4.MetroColor = System.Drawing.Color.Silver;
            this.numericUpDownExt4.Name = "numericUpDownExt4";
            this.numericUpDownExt4.Office2010ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Black;
            this.numericUpDownExt4.Size = new System.Drawing.Size(85, 29);
            this.numericUpDownExt4.TabIndex = 105;
            this.numericUpDownExt4.VisualStyle = Syncfusion.Windows.Forms.VisualStyle.Office2016Colorful;
            this.numericUpDownExt4.ValueChanged += new System.EventHandler(this.numericUpDownExt4_ValueChanged);
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(178)))), ((int)(((byte)(227)))));
            this.gradientPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gradientPanel1.Controls.Add(this.label39);
            this.gradientPanel1.Controls.Add(this.doubleTextBox1);
            this.gradientPanel1.Controls.Add(this.gradientPanel6);
            this.gradientPanel1.Controls.Add(this.label52);
            this.gradientPanel1.Controls.Add(this.textBox2);
            this.gradientPanel1.Controls.Add(this.label53);
            this.gradientPanel1.Controls.Add(this.integerTextBox3);
            this.gradientPanel1.Controls.Add(this.label54);
            this.gradientPanel1.Controls.Add(this.label55);
            this.gradientPanel1.Controls.Add(this.textBox3);
            this.gradientPanel1.Controls.Add(this.numericUpDownExt2);
            this.gradientPanel1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gradientPanel1.IgnoreThemeBackground = true;
            this.gradientPanel1.Location = new System.Drawing.Point(681, 12);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(310, 407);
            this.gradientPanel1.TabIndex = 120;
            this.gradientPanel1.ThemesEnabled = true;
            // 
            // label39
            // 
            this.label39.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label39.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label39.Location = new System.Drawing.Point(5, 169);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(131, 35);
            this.label39.TabIndex = 127;
            this.label39.Text = "Properties";
            this.label39.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // doubleTextBox1
            // 
            this.doubleTextBox1.BackGroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.doubleTextBox1.BeforeTouchSize = new System.Drawing.Size(130, 29);
            this.doubleTextBox1.Border3DStyle = System.Windows.Forms.Border3DStyle.RaisedOuter;
            this.doubleTextBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.doubleTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.doubleTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.doubleTextBox1.DoubleValue = 1D;
            this.doubleTextBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.doubleTextBox1.Location = new System.Drawing.Point(89, 113);
            this.doubleTextBox1.Metrocolor = System.Drawing.Color.Silver;
            this.doubleTextBox1.Name = "doubleTextBox1";
            this.doubleTextBox1.NullString = "";
            this.doubleTextBox1.NumberGroupSizes = new int[] {
        2};
            this.doubleTextBox1.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Black;
            this.doubleTextBox1.Office2010ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Black;
            this.doubleTextBox1.OverflowIndicatorToolTipText = "Text OverFlowing";
            this.doubleTextBox1.Size = new System.Drawing.Size(118, 29);
            this.doubleTextBox1.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Office2016Colorful;
            this.doubleTextBox1.TabIndex = 0;
            this.doubleTextBox1.Text = "1.00";
            // 
            // gradientPanel6
            // 
            this.gradientPanel6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(178)))), ((int)(((byte)(227)))));
            this.gradientPanel6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gradientPanel6.Controls.Add(this.label33);
            this.gradientPanel6.Controls.Add(this.label37);
            this.gradientPanel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.gradientPanel6.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gradientPanel6.Location = new System.Drawing.Point(0, 0);
            this.gradientPanel6.Name = "gradientPanel6";
            this.gradientPanel6.Size = new System.Drawing.Size(308, 111);
            this.gradientPanel6.TabIndex = 122;
            this.gradientPanel6.ThemesEnabled = true;
            // 
            // label33
            // 
            this.label33.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label33.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label33.Location = new System.Drawing.Point(0, 27);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(308, 84);
            this.label33.TabIndex = 1;
            this.label33.Text = "The DoubleTextBox supports display and collection of double values.";
            // 
            // label37
            // 
            this.label37.Dock = System.Windows.Forms.DockStyle.Top;
            this.label37.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label37.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label37.Location = new System.Drawing.Point(0, 0);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(308, 27);
            this.label37.TabIndex = 123;
            this.label37.Text = "DoubleTextBox";
            this.label37.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label52
            // 
            this.label52.AutoSize = true;
            this.label52.Location = new System.Drawing.Point(17, 217);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(148, 23);
            this.label52.TabIndex = 63;
            this.label52.Text = "Decimal separator";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.textBox2.BeforeTouchSize = new System.Drawing.Size(130, 29);
            this.textBox2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.textBox2.Location = new System.Drawing.Point(177, 213);
            this.textBox2.Metrocolor = System.Drawing.Color.Empty;
            this.textBox2.Name = "textBox2";
            this.textBox2.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Black;
            this.textBox2.Office2010ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Black;
            this.textBox2.Size = new System.Drawing.Size(74, 29);
            this.textBox2.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Office2016Colorful;
            this.textBox2.TabIndex = 64;
            this.textBox2.Text = ".";
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label53
            // 
            this.label53.AutoSize = true;
            this.label53.Location = new System.Drawing.Point(17, 264);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(119, 23);
            this.label53.TabIndex = 65;
            this.label53.Text = "Decimal Digits";
            // 
            // integerTextBox3
            // 
            this.integerTextBox3.BackGroundColor = System.Drawing.SystemColors.Window;
            this.integerTextBox3.BeforeTouchSize = new System.Drawing.Size(130, 29);
            this.integerTextBox3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.integerTextBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.integerTextBox3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.integerTextBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.integerTextBox3.IntegerValue = ((long)(2));
            this.integerTextBox3.Location = new System.Drawing.Point(177, 259);
            this.integerTextBox3.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.integerTextBox3.Name = "integerTextBox3";
            this.integerTextBox3.NullString = "0";
            this.integerTextBox3.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Black;
            this.integerTextBox3.Office2010ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Black;
            this.integerTextBox3.OverflowIndicatorToolTipText = null;
            this.integerTextBox3.Size = new System.Drawing.Size(74, 29);
            this.integerTextBox3.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Office2016Colorful;
            this.integerTextBox3.TabIndex = 66;
            this.integerTextBox3.Text = "2";
            this.integerTextBox3.ThemesEnabled = false;
            this.integerTextBox3.TextChanged += new System.EventHandler(this.integerTextBox3_TextChanged);
            // 
            // label54
            // 
            this.label54.AutoSize = true;
            this.label54.Location = new System.Drawing.Point(17, 311);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(137, 23);
            this.label54.TabIndex = 67;
            this.label54.Text = "Group Separator";
            // 
            // label55
            // 
            this.label55.AutoSize = true;
            this.label55.Location = new System.Drawing.Point(17, 358);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(100, 23);
            this.label55.TabIndex = 69;
            this.label55.Text = "Group Sizes";
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.textBox3.BeforeTouchSize = new System.Drawing.Size(130, 29);
            this.textBox3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.textBox3.Location = new System.Drawing.Point(177, 307);
            this.textBox3.Metrocolor = System.Drawing.Color.Empty;
            this.textBox3.Name = "textBox3";
            this.textBox3.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Black;
            this.textBox3.Office2010ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Black;
            this.textBox3.Size = new System.Drawing.Size(74, 29);
            this.textBox3.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Office2016Colorful;
            this.textBox3.TabIndex = 71;
            this.textBox3.Text = ",";
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // numericUpDownExt2
            // 
            this.numericUpDownExt2.BackColor = System.Drawing.Color.White;
            this.numericUpDownExt2.BeforeTouchSize = new System.Drawing.Size(74, 29);
            this.numericUpDownExt2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.numericUpDownExt2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDownExt2.ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Black;
            this.numericUpDownExt2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.numericUpDownExt2.Location = new System.Drawing.Point(177, 353);
            this.numericUpDownExt2.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.numericUpDownExt2.MetroColor = System.Drawing.Color.Silver;
            this.numericUpDownExt2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownExt2.Name = "numericUpDownExt2";
            this.numericUpDownExt2.Office2010ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Black;
            this.numericUpDownExt2.Size = new System.Drawing.Size(74, 29);
            this.numericUpDownExt2.TabIndex = 103;
            this.numericUpDownExt2.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDownExt2.VisualStyle = Syncfusion.Windows.Forms.VisualStyle.Office2016Colorful;
            this.numericUpDownExt2.ValueChanged += new System.EventHandler(this.numericUpDownExt2_ValueChanged);
            // 
            // textBoxPanel
            // 
            this.textBoxPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPanel.BorderColor = System.Drawing.Color.Gainsboro;
            this.textBoxPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxPanel.Controls.Add(this.checkBox32);
            this.textBoxPanel.Controls.Add(this.checkBox31);
            this.textBoxPanel.Controls.Add(this.numericUpDownExt6);
            this.textBoxPanel.Controls.Add(this.label137);
            this.textBoxPanel.Controls.Add(this.button1);
            this.textBoxPanel.Controls.Add(this.bannerClrEdit);
            this.textBoxPanel.Controls.Add(this.rdoFocus);
            this.textBoxPanel.Controls.Add(this.rdoEdit);
            this.textBoxPanel.Controls.Add(this.txtBanner);
            this.textBoxPanel.Controls.Add(this.label127);
            this.textBoxPanel.Controls.Add(this.label124);
            this.textBoxPanel.Controls.Add(this.label99);
            this.textBoxPanel.Controls.Add(this.label77);
            this.textBoxPanel.Controls.Add(this.label78);
            this.textBoxPanel.Controls.Add(this.groupBox4);
            this.textBoxPanel.Controls.Add(this.label109);
            this.textBoxPanel.Controls.Add(this.checkBox21);
            this.textBoxPanel.Controls.Add(this.label103);
            this.textBoxPanel.Controls.Add(this.label107);
            this.textBoxPanel.Controls.Add(this.checkBox22);
            this.textBoxPanel.Controls.Add(this.buttonEdit2);
            this.textBoxPanel.Controls.Add(this.label108);
            this.textBoxPanel.Controls.Add(this.label106);
            this.textBoxPanel.Controls.Add(this.checkBox23);
            this.textBoxPanel.Controls.Add(this.label115);
            this.textBoxPanel.Controls.Add(this.comboBox12);
            this.textBoxPanel.Controls.Add(this.comboBox11);
            this.textBoxPanel.Controls.Add(this.checkBox24);
            this.textBoxPanel.Controls.Add(this.label113);
            this.textBoxPanel.Controls.Add(this.comboBox9);
            this.textBoxPanel.Controls.Add(this.comboBox10);
            this.textBoxPanel.Controls.Add(this.checkBox25);
            this.textBoxPanel.Controls.Add(this.label101);
            this.textBoxPanel.Controls.Add(this.label105);
            this.textBoxPanel.Controls.Add(this.checkBox26);
            this.textBoxPanel.Controls.Add(this.label111);
            this.textBoxPanel.Controls.Add(this.comboBox8);
            this.textBoxPanel.Controls.Add(this.radioButton11);
            this.textBoxPanel.Controls.Add(this.label102);
            this.textBoxPanel.Controls.Add(this.label100);
            this.textBoxPanel.Controls.Add(this.radioButton10);
            this.textBoxPanel.Controls.Add(this.textBox11);
            this.textBoxPanel.Location = new System.Drawing.Point(0, 0);
            this.textBoxPanel.Name = "textBoxPanel";
            this.textBoxPanel.Size = new System.Drawing.Size(1340, 882);
            this.textBoxPanel.TabIndex = 9;
            // 
            // checkBox32
            // 
            this.checkBox32.BeforeTouchSize = new System.Drawing.Size(115, 30);
            this.checkBox32.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.checkBox32.Checked = true;
            this.checkBox32.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox32.DrawFocusRectangle = false;
            this.checkBox32.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox32.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.checkBox32.HotBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.checkBox32.ImageCheckBoxSize = new System.Drawing.Size(16, 16);
            this.checkBox32.Location = new System.Drawing.Point(1021, 701);
            this.checkBox32.MetroColor = System.Drawing.Color.Gray;
            this.checkBox32.Name = "checkBox32";
            this.checkBox32.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Black;
            this.checkBox32.Office2010ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Black;
            this.checkBox32.Size = new System.Drawing.Size(115, 30);
            this.checkBox32.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Office2016Colorful;
            this.checkBox32.TabIndex = 146;
            this.checkBox32.Text = "FarImage";
            this.checkBox32.ThemesEnabled = false;
            this.checkBox32.CheckedChanged += new System.EventHandler(this.checkBox32_CheckedChanged);
            // 
            // checkBox31
            // 
            this.checkBox31.BeforeTouchSize = new System.Drawing.Size(130, 29);
            this.checkBox31.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.checkBox31.Checked = true;
            this.checkBox31.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox31.DrawFocusRectangle = false;
            this.checkBox31.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox31.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.checkBox31.HotBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.checkBox31.ImageCheckBoxSize = new System.Drawing.Size(16, 16);
            this.checkBox31.Location = new System.Drawing.Point(1159, 704);
            this.checkBox31.MetroColor = System.Drawing.Color.Gray;
            this.checkBox31.Name = "checkBox31";
            this.checkBox31.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Black;
            this.checkBox31.Office2010ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Black;
            this.checkBox31.Size = new System.Drawing.Size(130, 29);
            this.checkBox31.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Office2016Colorful;
            this.checkBox31.TabIndex = 145;
            this.checkBox31.Text = "Near Image";
            this.checkBox31.ThemesEnabled = false;
            this.checkBox31.CheckedChanged += new System.EventHandler(this.checkBox31_CheckedChanged);
            // 
            // numericUpDownExt6
            // 
            this.numericUpDownExt6.BackColor = System.Drawing.Color.White;
            this.numericUpDownExt6.BeforeTouchSize = new System.Drawing.Size(146, 29);
            this.numericUpDownExt6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.numericUpDownExt6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDownExt6.ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Black;
            this.numericUpDownExt6.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownExt6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.numericUpDownExt6.Location = new System.Drawing.Point(177, 562);
            this.numericUpDownExt6.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownExt6.MetroColor = System.Drawing.Color.Silver;
            this.numericUpDownExt6.Name = "numericUpDownExt6";
            this.numericUpDownExt6.Office2010ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Black;
            this.numericUpDownExt6.Size = new System.Drawing.Size(146, 29);
            this.numericUpDownExt6.TabIndex = 144;
            this.numericUpDownExt6.VisualStyle = Syncfusion.Windows.Forms.VisualStyle.Office2016Colorful;
            this.numericUpDownExt6.ValueChanged += new System.EventHandler(this.numericUpDownExt6_ValueChanged);
            // 
            // label137
            // 
            this.label137.AutoSize = true;
            this.label137.Location = new System.Drawing.Point(33, 562);
            this.label137.Name = "label137";
            this.label137.Size = new System.Drawing.Size(117, 23);
            this.label137.TabIndex = 139;
            this.label137.Text = "Corner Radius";
            // 
            // button1
            // 
            this.button1.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2016Black;
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.button1.BeforeTouchSize = new System.Drawing.Size(200, 34);
            this.button1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.IsBackStageButton = false;
            this.button1.Location = new System.Drawing.Point(485, 763);
            this.button1.Name = "button1";
            this.button1.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Black;
            this.button1.Office2010ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Black;
            this.button1.Size = new System.Drawing.Size(200, 34);
            this.button1.TabIndex = 138;
            this.button1.Text = "Set Banner Text";
            this.button1.UseVisualStyle = true;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bannerClrEdit
            // 
            this.bannerClrEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bannerClrEdit.BeforeTouchSize = new System.Drawing.Size(200, 35);
            this.bannerClrEdit.Buttons.Add(this.buttonEditChildButton9);
            this.bannerClrEdit.ButtonStyle = Syncfusion.Windows.Forms.ButtonAppearance.Office2016Colorful;
            this.bannerClrEdit.Controls.Add(this.buttonEditChildButton9);
            this.bannerClrEdit.Controls.Add(this.textBoxExt5);
            this.bannerClrEdit.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.bannerClrEdit.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bannerClrEdit.Location = new System.Drawing.Point(485, 701);
            this.bannerClrEdit.MetroColor = System.Drawing.Color.Gray;
            this.bannerClrEdit.Name = "bannerClrEdit";
            this.bannerClrEdit.ShowTextBox = false;
            this.bannerClrEdit.Size = new System.Drawing.Size(200, 35);
            this.bannerClrEdit.TabIndex = 137;
            this.bannerClrEdit.TextBox = this.textBoxExt5;
            this.bannerClrEdit.UseVisualStyle = true;
            this.bannerClrEdit.ButtonClicked += new Syncfusion.Windows.Forms.Tools.ButtonClickedEventHandler(this.bannerClrEdit_ButtonClicked);
            // 
            // buttonEditChildButton9
            // 
            this.buttonEditChildButton9.BackColor = System.Drawing.Color.Gray;
            this.buttonEditChildButton9.BeforeTouchSize = new System.Drawing.Size(20, 31);
            this.buttonEditChildButton9.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.Flat;
            this.buttonEditChildButton9.ComboEditBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonEditChildButton9.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditChildButton9.Image = null;
            this.buttonEditChildButton9.IsBackStageButton = false;
            this.buttonEditChildButton9.Name = "buttonEditChildButton9";
            this.buttonEditChildButton9.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Black;
            this.buttonEditChildButton9.Office2010ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Black;
            this.buttonEditChildButton9.PreferredWidth = 20;
            this.buttonEditChildButton9.TabIndex = 1;
            this.buttonEditChildButton9.Text = "...";
            // 
            // textBoxExt5
            // 
            this.textBoxExt5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.textBoxExt5.BeforeTouchSize = new System.Drawing.Size(130, 29);
            this.textBoxExt5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.textBoxExt5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxExt5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.textBoxExt5.Location = new System.Drawing.Point(2, 3);
            this.textBoxExt5.Metrocolor = System.Drawing.Color.Empty;
            this.textBoxExt5.Name = "textBoxExt5";
            this.textBoxExt5.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Black;
            this.textBoxExt5.Office2010ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Black;
            this.textBoxExt5.OverflowIndicatorToolTipText = null;
            this.textBoxExt5.Size = new System.Drawing.Size(176, 29);
            this.textBoxExt5.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Office2016Colorful;
            this.textBoxExt5.TabIndex = 0;
            // 
            // rdoFocus
            // 
            this.rdoFocus.BeforeTouchSize = new System.Drawing.Size(141, 25);
            this.rdoFocus.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.rdoFocus.Checked = true;
            this.rdoFocus.DrawFocusRectangle = false;
            this.rdoFocus.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoFocus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.rdoFocus.HotBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.rdoFocus.ImageCheckBoxSize = new System.Drawing.Size(16, 16);
            this.rdoFocus.Location = new System.Drawing.Point(803, 704);
            this.rdoFocus.MetroColor = System.Drawing.Color.Gray;
            this.rdoFocus.Name = "rdoFocus";
            this.rdoFocus.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Black;
            this.rdoFocus.Office2010ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Black;
            this.rdoFocus.Size = new System.Drawing.Size(141, 25);
            this.rdoFocus.Style = Syncfusion.Windows.Forms.Tools.RadioButtonAdvStyle.Office2016Colorful;
            this.rdoFocus.TabIndex = 136;
            this.rdoFocus.Text = "Focus Mode";
            this.rdoFocus.ThemesEnabled = true;
            // 
            // rdoEdit
            // 
            this.rdoEdit.BeforeTouchSize = new System.Drawing.Size(128, 26);
            this.rdoEdit.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.rdoEdit.DrawFocusRectangle = false;
            this.rdoEdit.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoEdit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.rdoEdit.HotBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.rdoEdit.ImageCheckBoxSize = new System.Drawing.Size(16, 16);
            this.rdoEdit.Location = new System.Drawing.Point(803, 661);
            this.rdoEdit.MetroColor = System.Drawing.Color.Gray;
            this.rdoEdit.Name = "rdoEdit";
            this.rdoEdit.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Black;
            this.rdoEdit.Office2010ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Black;
            this.rdoEdit.Size = new System.Drawing.Size(128, 26);
            this.rdoEdit.Style = Syncfusion.Windows.Forms.Tools.RadioButtonAdvStyle.Office2016Colorful;
            this.rdoEdit.TabIndex = 135;
            this.rdoEdit.Text = "Edit Mode";
            this.rdoEdit.ThemesEnabled = true;
            // 
            // txtBanner
            // 
            this.txtBanner.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtBanner.BeforeTouchSize = new System.Drawing.Size(130, 29);
            this.txtBanner.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.txtBanner.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBanner.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBanner.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBanner.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.txtBanner.Location = new System.Drawing.Point(485, 659);
            this.txtBanner.Metrocolor = System.Drawing.Color.Empty;
            this.txtBanner.Name = "txtBanner";
            this.txtBanner.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Black;
            this.txtBanner.Office2010ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Black;
            this.txtBanner.Size = new System.Drawing.Size(200, 29);
            this.txtBanner.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Office2016Colorful;
            this.txtBanner.TabIndex = 134;
            // 
            // label127
            // 
            this.label127.AutoSize = true;
            this.label127.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label127.Location = new System.Drawing.Point(717, 661);
            this.label127.Name = "label127";
            this.label127.Size = new System.Drawing.Size(54, 23);
            this.label127.TabIndex = 133;
            this.label127.Text = "Mode";
            // 
            // label124
            // 
            this.label124.AutoSize = true;
            this.label124.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label124.Location = new System.Drawing.Point(415, 704);
            this.label124.Name = "label124";
            this.label124.Size = new System.Drawing.Size(51, 23);
            this.label124.TabIndex = 132;
            this.label124.Text = "Color";
            // 
            // label99
            // 
            this.label99.AutoSize = true;
            this.label99.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label99.Location = new System.Drawing.Point(408, 659);
            this.label99.Name = "label99";
            this.label99.Size = new System.Drawing.Size(40, 23);
            this.label99.TabIndex = 131;
            this.label99.Text = "Text";
            // 
            // label77
            // 
            this.label77.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label77.ForeColor = System.Drawing.Color.Black;
            this.label77.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label77.Location = new System.Drawing.Point(376, 600);
            this.label77.Name = "label77";
            this.label77.Size = new System.Drawing.Size(240, 35);
            this.label77.TabIndex = 130;
            this.label77.Text = "Banner Text Settings";
            this.label77.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label78
            // 
            this.label78.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(164)))), ((int)(((byte)(190)))));
            this.label78.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label78.Location = new System.Drawing.Point(415, 638);
            this.label78.Name = "label78";
            this.label78.Size = new System.Drawing.Size(512, 1);
            this.label78.TabIndex = 129;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label25);
            this.groupBox4.Controls.Add(this.textBoxExt4);
            this.groupBox4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(376, 31);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(543, 304);
            this.groupBox4.TabIndex = 128;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "TextBoxExt";
            // 
            // label25
            // 
            this.label25.BackColor = System.Drawing.Color.Transparent;
            this.label25.Dock = System.Windows.Forms.DockStyle.Top;
            this.label25.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label25.Location = new System.Drawing.Point(3, 25);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(537, 82);
            this.label25.TabIndex = 1;
            this.label25.Text = "TextBoxExt is an advanced Textbox control that supports different border colors a" +
    "nd styles, options to show text overflow indicators and over flow indicator tool" +
    "tips. ";
            // 
            // textBoxExt4
            // 
            this.textBoxExt4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.textBoxExt4.BeforeTouchSize = new System.Drawing.Size(130, 29);
            this.textBoxExt4.Border3DStyle = System.Windows.Forms.Border3DStyle.Raised;
            this.textBoxExt4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.textBoxExt4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxExt4.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBoxExt4.FarImage = ((System.Drawing.Image)(resources.GetObject("textBoxExt4.FarImage")));
            this.textBoxExt4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.textBoxExt4.Location = new System.Drawing.Point(67, 111);
            this.textBoxExt4.Metrocolor = System.Drawing.Color.Silver;
            this.textBoxExt4.MinimumSize = new System.Drawing.Size(22, 18);
            this.textBoxExt4.Name = "textBoxExt4";
            this.textBoxExt4.NearImage = ((System.Drawing.Image)(resources.GetObject("textBoxExt4.NearImage")));
            this.textBoxExt4.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Black;
            this.textBoxExt4.Office2010ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Black;
            this.textBoxExt4.OverflowIndicatorToolTipText = null;
            this.textBoxExt4.ShowOverflowIndicatorToolTip = true;
            this.textBoxExt4.Size = new System.Drawing.Size(388, 29);
            this.textBoxExt4.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Office2016Colorful;
            this.textBoxExt4.TabIndex = 0;
            this.textBoxExt4.ThemesEnabled = false;
            // 
            // label109
            // 
            this.label109.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label109.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label109.Location = new System.Drawing.Point(673, 412);
            this.label109.Name = "label109";
            this.label109.Size = new System.Drawing.Size(202, 35);
            this.label109.TabIndex = 100;
            this.label109.Text = "OverflowIndicator";
            this.label109.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // checkBox21
            // 
            this.checkBox21.BeforeTouchSize = new System.Drawing.Size(102, 35);
            this.checkBox21.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.checkBox21.DrawFocusRectangle = false;
            this.checkBox21.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.checkBox21.HotBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.checkBox21.ImageCheckBoxSize = new System.Drawing.Size(16, 16);
            this.checkBox21.Location = new System.Drawing.Point(673, 484);
            this.checkBox21.MetroColor = System.Drawing.Color.Gray;
            this.checkBox21.Name = "checkBox21";
            this.checkBox21.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Black;
            this.checkBox21.Office2010ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Black;
            this.checkBox21.Size = new System.Drawing.Size(102, 35);
            this.checkBox21.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Office2016Colorful;
            this.checkBox21.TabIndex = 61;
            this.checkBox21.Text = "Visible";
            this.checkBox21.ThemesEnabled = false;
            this.checkBox21.CheckedChanged += new System.EventHandler(this.checkBox21_CheckedChanged);
            // 
            // label103
            // 
            this.label103.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label103.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label103.Location = new System.Drawing.Point(33, 412);
            this.label103.Name = "label103";
            this.label103.Size = new System.Drawing.Size(183, 35);
            this.label103.TabIndex = 84;
            this.label103.Text = "Border Settings";
            this.label103.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label107
            // 
            this.label107.AutoSize = true;
            this.label107.Location = new System.Drawing.Point(33, 629);
            this.label107.Margin = new System.Windows.Forms.Padding(0);
            this.label107.Name = "label107";
            this.label107.Size = new System.Drawing.Size(122, 23);
            this.label107.TabIndex = 76;
            this.label107.Text = "Border3D Style";
            // 
            // checkBox22
            // 
            this.checkBox22.BeforeTouchSize = new System.Drawing.Size(136, 35);
            this.checkBox22.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.checkBox22.Checked = true;
            this.checkBox22.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox22.DrawFocusRectangle = false;
            this.checkBox22.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox22.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.checkBox22.HotBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.checkBox22.ImageCheckBoxSize = new System.Drawing.Size(16, 16);
            this.checkBox22.Location = new System.Drawing.Point(485, 478);
            this.checkBox22.MetroColor = System.Drawing.Color.Gray;
            this.checkBox22.Name = "checkBox22";
            this.checkBox22.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Black;
            this.checkBox22.Office2010ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Black;
            this.checkBox22.Size = new System.Drawing.Size(136, 35);
            this.checkBox22.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Office2016Colorful;
            this.checkBox22.TabIndex = 92;
            this.checkBox22.Text = "Word Wrap";
            this.checkBox22.ThemesEnabled = false;
            this.checkBox22.CheckedChanged += new System.EventHandler(this.checkBox22_CheckedChanged);
            // 
            // buttonEdit2
            // 
            this.buttonEdit2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonEdit2.BeforeTouchSize = new System.Drawing.Size(152, 35);
            this.buttonEdit2.Buttons.Add(this.buttonEditChildButton4);
            this.buttonEdit2.ButtonStyle = Syncfusion.Windows.Forms.ButtonAppearance.Office2016Colorful;
            this.buttonEdit2.Controls.Add(this.buttonEditChildButton4);
            this.buttonEdit2.Controls.Add(this.textBoxExt3);
            this.buttonEdit2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonEdit2.Location = new System.Drawing.Point(177, 776);
            this.buttonEdit2.MetroColor = System.Drawing.Color.Gray;
            this.buttonEdit2.Name = "buttonEdit2";
            this.buttonEdit2.ShowTextBox = false;
            this.buttonEdit2.Size = new System.Drawing.Size(152, 35);
            this.buttonEdit2.TabIndex = 121;
            this.buttonEdit2.TextBox = this.textBoxExt3;
            this.buttonEdit2.UseVisualStyle = true;
            this.buttonEdit2.ButtonClicked += new Syncfusion.Windows.Forms.Tools.ButtonClickedEventHandler(this.buttonEdit2_ButtonClicked);
            // 
            // buttonEditChildButton4
            // 
            this.buttonEditChildButton4.BackColor = System.Drawing.Color.Gray;
            this.buttonEditChildButton4.BeforeTouchSize = new System.Drawing.Size(18, 31);
            this.buttonEditChildButton4.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.Flat;
            this.buttonEditChildButton4.ComboEditBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonEditChildButton4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditChildButton4.Image = null;
            this.buttonEditChildButton4.IsBackStageButton = false;
            this.buttonEditChildButton4.Name = "buttonEditChildButton4";
            this.buttonEditChildButton4.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Black;
            this.buttonEditChildButton4.Office2010ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Black;
            this.buttonEditChildButton4.PreferredWidth = 18;
            this.buttonEditChildButton4.TabIndex = 1;
            this.buttonEditChildButton4.Text = "...";
            // 
            // textBoxExt3
            // 
            this.textBoxExt3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.textBoxExt3.BeforeTouchSize = new System.Drawing.Size(130, 29);
            this.textBoxExt3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.textBoxExt3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxExt3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.textBoxExt3.Location = new System.Drawing.Point(2, 3);
            this.textBoxExt3.Metrocolor = System.Drawing.Color.Empty;
            this.textBoxExt3.Name = "textBoxExt3";
            this.textBoxExt3.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Black;
            this.textBoxExt3.Office2010ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Black;
            this.textBoxExt3.OverflowIndicatorToolTipText = null;
            this.textBoxExt3.ShowOverflowIndicatorToolTip = true;
            this.textBoxExt3.Size = new System.Drawing.Size(130, 29);
            this.textBoxExt3.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Office2016Colorful;
            this.textBoxExt3.TabIndex = 0;
            // 
            // label108
            // 
            this.label108.AutoSize = true;
            this.label108.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label108.Location = new System.Drawing.Point(1021, 562);
            this.label108.Name = "label108";
            this.label108.Size = new System.Drawing.Size(84, 23);
            this.label108.TabIndex = 91;
            this.label108.Text = "Text Align";
            // 
            // label106
            // 
            this.label106.AutoSize = true;
            this.label106.Location = new System.Drawing.Point(33, 703);
            this.label106.Name = "label106";
            this.label106.Size = new System.Drawing.Size(105, 23);
            this.label106.TabIndex = 77;
            this.label106.Text = "Border Sides";
            // 
            // checkBox23
            // 
            this.checkBox23.BeforeTouchSize = new System.Drawing.Size(142, 36);
            this.checkBox23.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.checkBox23.DrawFocusRectangle = false;
            this.checkBox23.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox23.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.checkBox23.HotBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.checkBox23.ImageCheckBoxSize = new System.Drawing.Size(16, 16);
            this.checkBox23.Location = new System.Drawing.Point(1159, 623);
            this.checkBox23.MetroColor = System.Drawing.Color.Gray;
            this.checkBox23.Name = "checkBox23";
            this.checkBox23.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Black;
            this.checkBox23.Office2010ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Black;
            this.checkBox23.Size = new System.Drawing.Size(142, 36);
            this.checkBox23.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Office2016Colorful;
            this.checkBox23.TabIndex = 93;
            this.checkBox23.Text = "Right To Left";
            this.checkBox23.ThemesEnabled = false;
            this.checkBox23.CheckedChanged += new System.EventHandler(this.checkBox23_CheckedChanged);
            // 
            // label115
            // 
            this.label115.AutoSize = true;
            this.label115.Location = new System.Drawing.Point(33, 777);
            this.label115.Name = "label115";
            this.label115.Size = new System.Drawing.Size(107, 23);
            this.label115.TabIndex = 120;
            this.label115.Text = "Border Color";
            // 
            // comboBox12
            // 
            this.comboBox12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.comboBox12.BeforeTouchSize = new System.Drawing.Size(120, 31);
            this.comboBox12.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox12.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.comboBox12.Items.AddRange(new object[] {
            "Left",
            "Right",
            "Center"});
            this.comboBox12.Location = new System.Drawing.Point(1176, 545);
            this.comboBox12.Name = "comboBox12";
            this.comboBox12.Office2007ColorTheme = Syncfusion.Windows.Forms.Office2007Theme.Black;
            this.comboBox12.Office2010ColorTheme = Syncfusion.Windows.Forms.Office2010Theme.Managed;
            this.comboBox12.Size = new System.Drawing.Size(120, 31);
            this.comboBox12.Style = Syncfusion.Windows.Forms.VisualStyle.Office2016Colorful;
            this.comboBox12.TabIndex = 90;
            this.comboBox12.Text = "Left";
            this.comboBox12.SelectedIndexChanged += new System.EventHandler(this.comboBox12_SelectedIndexChanged);
            // 
            // comboBox11
            // 
            this.comboBox11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.comboBox11.BeforeTouchSize = new System.Drawing.Size(152, 31);
            this.comboBox11.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox11.Enabled = false;
            this.comboBox11.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.comboBox11.Location = new System.Drawing.Point(177, 626);
            this.comboBox11.Name = "comboBox11";
            this.comboBox11.Office2007ColorTheme = Syncfusion.Windows.Forms.Office2007Theme.Black;
            this.comboBox11.Office2010ColorTheme = Syncfusion.Windows.Forms.Office2010Theme.Managed;
            this.comboBox11.Size = new System.Drawing.Size(152, 31);
            this.comboBox11.Style = Syncfusion.Windows.Forms.VisualStyle.Office2016Colorful;
            this.comboBox11.TabIndex = 78;
            this.comboBox11.SelectedIndexChanged += new System.EventHandler(this.comboBox11_SelectedIndexChanged);
            // 
            // checkBox24
            // 
            this.checkBox24.BeforeTouchSize = new System.Drawing.Size(179, 36);
            this.checkBox24.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.checkBox24.DrawFocusRectangle = false;
            this.checkBox24.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox24.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.checkBox24.HotBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.checkBox24.ImageCheckBoxSize = new System.Drawing.Size(16, 16);
            this.checkBox24.Location = new System.Drawing.Point(1021, 623);
            this.checkBox24.MetroColor = System.Drawing.Color.Gray;
            this.checkBox24.Name = "checkBox24";
            this.checkBox24.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Black;
            this.checkBox24.Office2010ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Black;
            this.checkBox24.Size = new System.Drawing.Size(179, 36);
            this.checkBox24.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Office2016Colorful;
            this.checkBox24.TabIndex = 94;
            this.checkBox24.Text = "Read Only";
            this.checkBox24.ThemesEnabled = false;
            this.checkBox24.CheckedChanged += new System.EventHandler(this.checkBox24_CheckedChanged);
            // 
            // label113
            // 
            this.label113.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label113.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label113.Location = new System.Drawing.Point(1021, 412);
            this.label113.Name = "label113";
            this.label113.Size = new System.Drawing.Size(120, 35);
            this.label113.TabIndex = 104;
            this.label113.Text = "General";
            this.label113.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // comboBox9
            // 
            this.comboBox9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.comboBox9.BeforeTouchSize = new System.Drawing.Size(154, 31);
            this.comboBox9.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox9.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.comboBox9.Items.AddRange(new object[] {
            "None",
            "Horizontal",
            "Vertical",
            "Both"});
            this.comboBox9.Location = new System.Drawing.Point(457, 541);
            this.comboBox9.Name = "comboBox9";
            this.comboBox9.Office2007ColorTheme = Syncfusion.Windows.Forms.Office2007Theme.Black;
            this.comboBox9.Office2010ColorTheme = Syncfusion.Windows.Forms.Office2010Theme.Managed;
            this.comboBox9.Size = new System.Drawing.Size(154, 31);
            this.comboBox9.Style = Syncfusion.Windows.Forms.VisualStyle.Office2016Colorful;
            this.comboBox9.TabIndex = 88;
            this.comboBox9.Text = "None";
            this.comboBox9.SelectedIndexChanged += new System.EventHandler(this.comboBox9_SelectedIndexChanged);
            // 
            // comboBox10
            // 
            this.comboBox10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.comboBox10.BeforeTouchSize = new System.Drawing.Size(152, 31);
            this.comboBox10.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox10.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.comboBox10.Items.AddRange(new object[] {
            "Left",
            "Top",
            "Right",
            "Bottom",
            "Middle",
            "All"});
            this.comboBox10.Location = new System.Drawing.Point(177, 703);
            this.comboBox10.Name = "comboBox10";
            this.comboBox10.Office2007ColorTheme = Syncfusion.Windows.Forms.Office2007Theme.Black;
            this.comboBox10.Office2010ColorTheme = Syncfusion.Windows.Forms.Office2010Theme.Managed;
            this.comboBox10.Size = new System.Drawing.Size(152, 31);
            this.comboBox10.Style = Syncfusion.Windows.Forms.VisualStyle.Office2016Colorful;
            this.comboBox10.TabIndex = 79;
            this.comboBox10.Text = "Left";
            this.comboBox10.SelectedIndexChanged += new System.EventHandler(this.comboBox10_SelectedIndexChanged);
            // 
            // checkBox25
            // 
            this.checkBox25.BeforeTouchSize = new System.Drawing.Size(179, 35);
            this.checkBox25.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.checkBox25.DrawFocusRectangle = false;
            this.checkBox25.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox25.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.checkBox25.HotBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.checkBox25.ImageCheckBoxSize = new System.Drawing.Size(16, 16);
            this.checkBox25.Location = new System.Drawing.Point(381, 478);
            this.checkBox25.MetroColor = System.Drawing.Color.Gray;
            this.checkBox25.Name = "checkBox25";
            this.checkBox25.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Black;
            this.checkBox25.Office2010ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Black;
            this.checkBox25.Size = new System.Drawing.Size(179, 35);
            this.checkBox25.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Office2016Colorful;
            this.checkBox25.TabIndex = 95;
            this.checkBox25.Text = "MultiLine";
            this.checkBox25.ThemesEnabled = false;
            this.checkBox25.CheckedChanged += new System.EventHandler(this.checkBox25_CheckedChanged);
            // 
            // label101
            // 
            this.label101.AutoSize = true;
            this.label101.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label101.Location = new System.Drawing.Point(371, 545);
            this.label101.Name = "label101";
            this.label101.Size = new System.Drawing.Size(83, 23);
            this.label101.TabIndex = 87;
            this.label101.Text = "Scrollbars";
            // 
            // label105
            // 
            this.label105.AutoSize = true;
            this.label105.Location = new System.Drawing.Point(33, 484);
            this.label105.Name = "label105";
            this.label105.Size = new System.Drawing.Size(101, 23);
            this.label105.TabIndex = 80;
            this.label105.Text = "Border Style";
            // 
            // checkBox26
            // 
            this.checkBox26.BeforeTouchSize = new System.Drawing.Size(168, 49);
            this.checkBox26.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.checkBox26.DrawFocusRectangle = false;
            this.checkBox26.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox26.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.checkBox26.HotBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.checkBox26.ImageCheckBoxSize = new System.Drawing.Size(16, 16);
            this.checkBox26.Location = new System.Drawing.Point(784, 478);
            this.checkBox26.MetroColor = System.Drawing.Color.Gray;
            this.checkBox26.Name = "checkBox26";
            this.checkBox26.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Black;
            this.checkBox26.Office2010ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Black;
            this.checkBox26.Size = new System.Drawing.Size(168, 49);
            this.checkBox26.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Office2016Colorful;
            this.checkBox26.TabIndex = 96;
            this.checkBox26.Text = "ToolTip visible";
            this.checkBox26.ThemesEnabled = false;
            this.checkBox26.CheckedChanged += new System.EventHandler(this.checkBox26_CheckedChanged);
            // 
            // label111
            // 
            this.label111.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label111.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label111.Location = new System.Drawing.Point(381, 412);
            this.label111.Name = "label111";
            this.label111.Size = new System.Drawing.Size(134, 35);
            this.label111.TabIndex = 102;
            this.label111.Text = "MultiLine";
            this.label111.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // comboBox8
            // 
            this.comboBox8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.comboBox8.BeforeTouchSize = new System.Drawing.Size(120, 31);
            this.comboBox8.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox8.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.comboBox8.Items.AddRange(new object[] {
            "Normal",
            "Upper Case",
            "Lower Case"});
            this.comboBox8.Location = new System.Drawing.Point(1175, 479);
            this.comboBox8.Name = "comboBox8";
            this.comboBox8.Office2007ColorTheme = Syncfusion.Windows.Forms.Office2007Theme.Black;
            this.comboBox8.Office2010ColorTheme = Syncfusion.Windows.Forms.Office2010Theme.Managed;
            this.comboBox8.Size = new System.Drawing.Size(120, 31);
            this.comboBox8.Style = Syncfusion.Windows.Forms.VisualStyle.Office2016Colorful;
            this.comboBox8.TabIndex = 86;
            this.comboBox8.Text = "Normal";
            this.comboBox8.SelectedIndexChanged += new System.EventHandler(this.comboBox8_SelectedIndexChanged);
            // 
            // radioButton11
            // 
            this.radioButton11.BeforeTouchSize = new System.Drawing.Size(134, 30);
            this.radioButton11.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.radioButton11.DrawFocusRectangle = false;
            this.radioButton11.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.radioButton11.HotBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.radioButton11.ImageCheckBoxSize = new System.Drawing.Size(16, 16);
            this.radioButton11.Location = new System.Drawing.Point(177, 481);
            this.radioButton11.MetroColor = System.Drawing.Color.Gray;
            this.radioButton11.Name = "radioButton11";
            this.radioButton11.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Black;
            this.radioButton11.Office2010ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Black;
            this.radioButton11.Size = new System.Drawing.Size(134, 30);
            this.radioButton11.Style = Syncfusion.Windows.Forms.Tools.RadioButtonAdvStyle.Office2016Colorful;
            this.radioButton11.TabIndex = 81;
            this.radioButton11.Text = "FixedSingle";
            this.radioButton11.ThemesEnabled = true;
            this.radioButton11.CheckChanged += new System.EventHandler(this.radioButton11_CheckedChanged);
            // 
            // label102
            // 
            this.label102.AutoSize = true;
            this.label102.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label102.Location = new System.Drawing.Point(669, 545);
            this.label102.Name = "label102";
            this.label102.Size = new System.Drawing.Size(94, 23);
            this.label102.TabIndex = 97;
            this.label102.Text = "ToolTipText";
            // 
            // label100
            // 
            this.label100.AutoSize = true;
            this.label100.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label100.Location = new System.Drawing.Point(1021, 485);
            this.label100.Name = "label100";
            this.label100.Size = new System.Drawing.Size(140, 23);
            this.label100.TabIndex = 85;
            this.label100.Text = "Character Casing";
            // 
            // radioButton10
            // 
            this.radioButton10.BeforeTouchSize = new System.Drawing.Size(119, 29);
            this.radioButton10.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.radioButton10.DrawFocusRectangle = false;
            this.radioButton10.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.radioButton10.HotBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.radioButton10.ImageCheckBoxSize = new System.Drawing.Size(16, 16);
            this.radioButton10.Location = new System.Drawing.Point(177, 516);
            this.radioButton10.MetroColor = System.Drawing.Color.Gray;
            this.radioButton10.Name = "radioButton10";
            this.radioButton10.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Black;
            this.radioButton10.Office2010ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Black;
            this.radioButton10.Size = new System.Drawing.Size(119, 29);
            this.radioButton10.Style = Syncfusion.Windows.Forms.Tools.RadioButtonAdvStyle.Office2016Colorful;
            this.radioButton10.TabIndex = 82;
            this.radioButton10.Text = "Fixed3D";
            this.radioButton10.ThemesEnabled = true;
            this.radioButton10.CheckChanged += new System.EventHandler(this.radioButton10_CheckedChanged);
            // 
            // textBox11
            // 
            this.textBox11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.textBox11.BeforeTouchSize = new System.Drawing.Size(130, 29);
            this.textBox11.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.textBox11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox11.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox11.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.textBox11.Location = new System.Drawing.Point(779, 541);
            this.textBox11.Metrocolor = System.Drawing.Color.Silver;
            this.textBox11.Name = "textBox11";
            this.textBox11.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Black;
            this.textBox11.Office2010ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Black;
            this.textBox11.Size = new System.Drawing.Size(146, 29);
            this.textBox11.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Office2016Colorful;
            this.textBox11.TabIndex = 98;
            this.textBox11.Text = "Text Overflowed";
            this.textBox11.TextChanged += new System.EventHandler(this.textBox11_TextChanged);
            // 
            // maskedEditPanel
            // 
            this.maskedEditPanel.BorderColor = System.Drawing.Color.Gainsboro;
            this.maskedEditPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.maskedEditPanel.Controls.Add(this.chkPullCharOnDelete);
            this.maskedEditPanel.Controls.Add(this.numericUpDownExt9);
            this.maskedEditPanel.Controls.Add(this.label139);
            this.maskedEditPanel.Controls.Add(this.comboBox18);
            this.maskedEditPanel.Controls.Add(this.label126);
            this.maskedEditPanel.Controls.Add(this.label79);
            this.maskedEditPanel.Controls.Add(this.checkBox29);
            this.maskedEditPanel.Controls.Add(this.comboBox16);
            this.maskedEditPanel.Controls.Add(this.checkBox30);
            this.maskedEditPanel.Controls.Add(this.comboBox17);
            this.maskedEditPanel.Controls.Add(this.label125);
            this.maskedEditPanel.Controls.Add(this.label98);
            this.maskedEditPanel.Controls.Add(this.comboBox15);
            this.maskedEditPanel.Controls.Add(this.buttonEdit3);
            this.maskedEditPanel.Controls.Add(this.label80);
            this.maskedEditPanel.Controls.Add(this.label81);
            this.maskedEditPanel.Controls.Add(this.label90);
            this.maskedEditPanel.Controls.Add(this.comboBox7);
            this.maskedEditPanel.Controls.Add(this.label93);
            this.maskedEditPanel.Controls.Add(this.radioButton8);
            this.maskedEditPanel.Controls.Add(this.buttonEdit4);
            this.maskedEditPanel.Controls.Add(this.radioButton9);
            this.maskedEditPanel.Controls.Add(this.buttonEdit5);
            this.maskedEditPanel.Controls.Add(this.label95);
            this.maskedEditPanel.Controls.Add(this.comboBox14);
            this.maskedEditPanel.Controls.Add(this.label96);
            this.maskedEditPanel.Controls.Add(this.label97);
            this.maskedEditPanel.Controls.Add(this.label71);
            this.maskedEditPanel.Controls.Add(this.groupBox6);
            this.maskedEditPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.maskedEditPanel.Location = new System.Drawing.Point(0, 0);
            this.maskedEditPanel.Name = "maskedEditPanel";
            this.maskedEditPanel.Size = new System.Drawing.Size(1350, 880);
            this.maskedEditPanel.TabIndex = 9;
            // 
            // chkPullCharOnDelete
            // 
            this.chkPullCharOnDelete.BeforeTouchSize = new System.Drawing.Size(332, 35);
            this.chkPullCharOnDelete.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.chkPullCharOnDelete.DrawFocusRectangle = false;
            this.chkPullCharOnDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.chkPullCharOnDelete.HotBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.chkPullCharOnDelete.ImageCheckBoxSize = new System.Drawing.Size(16, 16);
            this.chkPullCharOnDelete.Location = new System.Drawing.Point(161, 824);
            this.chkPullCharOnDelete.MetroColor = System.Drawing.Color.Gray;
            this.chkPullCharOnDelete.Name = "chkPullCharOnDelete";
            this.chkPullCharOnDelete.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Black;
            this.chkPullCharOnDelete.Office2010ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Black;
            this.chkPullCharOnDelete.Size = new System.Drawing.Size(332, 35);
            this.chkPullCharOnDelete.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Office2016Colorful;
            this.chkPullCharOnDelete.TabIndex = 171;
            this.chkPullCharOnDelete.Text = "Pull Char On Delete";
            this.chkPullCharOnDelete.ThemesEnabled = false;
            this.toolTip1.SetToolTip(this.chkPullCharOnDelete, "Pulls the adjacent character to the postion being deleted like MS MaskedTextBox.");
            this.chkPullCharOnDelete.CheckedChanged += new System.EventHandler(this.chkPullCharOnDelete_CheckedChanged);
            // 
            // numericUpDownExt9
            // 
            this.numericUpDownExt9.BackColor = System.Drawing.Color.White;
            this.numericUpDownExt9.BeforeTouchSize = new System.Drawing.Size(176, 29);
            this.numericUpDownExt9.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.numericUpDownExt9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDownExt9.ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Black;
            this.numericUpDownExt9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.numericUpDownExt9.Location = new System.Drawing.Point(889, 529);
            this.numericUpDownExt9.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownExt9.MetroColor = System.Drawing.Color.Silver;
            this.numericUpDownExt9.Name = "numericUpDownExt9";
            this.numericUpDownExt9.Office2010ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Black;
            this.numericUpDownExt9.Size = new System.Drawing.Size(176, 29);
            this.numericUpDownExt9.TabIndex = 170;
            this.numericUpDownExt9.VisualStyle = Syncfusion.Windows.Forms.VisualStyle.Office2016Colorful;
            this.numericUpDownExt9.ValueChanged += new System.EventHandler(this.numericUpDownExt9_ValueChanged);
            // 
            // label139
            // 
            this.label139.AutoSize = true;
            this.label139.Location = new System.Drawing.Point(755, 529);
            this.label139.Name = "label139";
            this.label139.Size = new System.Drawing.Size(112, 23);
            this.label139.TabIndex = 169;
            this.label139.Text = "CornerRadius";
            // 
            // comboBox18
            // 
            this.comboBox18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.comboBox18.BeforeTouchSize = new System.Drawing.Size(192, 31);
            this.comboBox18.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox18.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.comboBox18.Items.AddRange(new object[] {
            "*",
            "#",
            "@",
            "None"});
            this.comboBox18.Location = new System.Drawing.Point(357, 572);
            this.comboBox18.Name = "comboBox18";
            this.comboBox18.Office2007ColorTheme = Syncfusion.Windows.Forms.Office2007Theme.Black;
            this.comboBox18.Office2010ColorTheme = Syncfusion.Windows.Forms.Office2010Theme.Managed;
            this.comboBox18.Size = new System.Drawing.Size(192, 31);
            this.comboBox18.Style = Syncfusion.Windows.Forms.VisualStyle.Office2016Colorful;
            this.comboBox18.TabIndex = 168;
            this.comboBox18.Text = "*";
            this.comboBox18.SelectedIndexChanged += new System.EventHandler(this.comboBox18_SelectedIndexChanged);
            // 
            // label126
            // 
            this.label126.AutoSize = true;
            this.label126.Location = new System.Drawing.Point(161, 577);
            this.label126.Name = "label126";
            this.label126.Size = new System.Drawing.Size(159, 23);
            this.label126.TabIndex = 167;
            this.label126.Text = "Password Character";
            // 
            // label79
            // 
            this.label79.AutoSize = true;
            this.label79.Location = new System.Drawing.Point(161, 628);
            this.label79.Name = "label79";
            this.label79.Size = new System.Drawing.Size(84, 23);
            this.label79.TabIndex = 162;
            this.label79.Text = "Text Align";
            // 
            // checkBox29
            // 
            this.checkBox29.BeforeTouchSize = new System.Drawing.Size(180, 35);
            this.checkBox29.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.checkBox29.DrawFocusRectangle = false;
            this.checkBox29.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.checkBox29.HotBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.checkBox29.ImageCheckBoxSize = new System.Drawing.Size(16, 16);
            this.checkBox29.Location = new System.Drawing.Point(161, 757);
            this.checkBox29.MetroColor = System.Drawing.Color.Gray;
            this.checkBox29.Name = "checkBox29";
            this.checkBox29.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Black;
            this.checkBox29.Office2010ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Black;
            this.checkBox29.Size = new System.Drawing.Size(180, 35);
            this.checkBox29.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Office2016Colorful;
            this.checkBox29.TabIndex = 163;
            this.checkBox29.Text = "Right To Left";
            this.checkBox29.ThemesEnabled = false;
            this.checkBox29.CheckedChanged += new System.EventHandler(this.checkBox29_CheckedChanged);
            // 
            // comboBox16
            // 
            this.comboBox16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.comboBox16.BeforeTouchSize = new System.Drawing.Size(194, 31);
            this.comboBox16.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox16.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.comboBox16.Items.AddRange(new object[] {
            "Left",
            "Right",
            "Center"});
            this.comboBox16.Location = new System.Drawing.Point(355, 623);
            this.comboBox16.Name = "comboBox16";
            this.comboBox16.Office2007ColorTheme = Syncfusion.Windows.Forms.Office2007Theme.Black;
            this.comboBox16.Office2010ColorTheme = Syncfusion.Windows.Forms.Office2010Theme.Managed;
            this.comboBox16.Size = new System.Drawing.Size(194, 31);
            this.comboBox16.Style = Syncfusion.Windows.Forms.VisualStyle.Office2016Colorful;
            this.comboBox16.TabIndex = 161;
            this.comboBox16.Text = "Left";
            this.comboBox16.SelectedIndexChanged += new System.EventHandler(this.comboBox16_SelectedIndexChanged);
            // 
            // checkBox30
            // 
            this.checkBox30.BeforeTouchSize = new System.Drawing.Size(178, 35);
            this.checkBox30.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.checkBox30.DrawFocusRectangle = false;
            this.checkBox30.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.checkBox30.HotBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.checkBox30.ImageCheckBoxSize = new System.Drawing.Size(16, 16);
            this.checkBox30.Location = new System.Drawing.Point(167, 694);
            this.checkBox30.MetroColor = System.Drawing.Color.Gray;
            this.checkBox30.Name = "checkBox30";
            this.checkBox30.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Black;
            this.checkBox30.Office2010ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Black;
            this.checkBox30.Size = new System.Drawing.Size(178, 35);
            this.checkBox30.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Office2016Colorful;
            this.checkBox30.TabIndex = 164;
            this.checkBox30.Text = "Read Only";
            this.checkBox30.ThemesEnabled = false;
            this.checkBox30.CheckedChanged += new System.EventHandler(this.checkBox30_CheckedChanged);
            // 
            // comboBox17
            // 
            this.comboBox17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.comboBox17.BeforeTouchSize = new System.Drawing.Size(192, 31);
            this.comboBox17.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox17.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.comboBox17.Items.AddRange(new object[] {
            "Normal",
            "Upper Case",
            "Lower Case"});
            this.comboBox17.Location = new System.Drawing.Point(357, 512);
            this.comboBox17.Name = "comboBox17";
            this.comboBox17.Office2007ColorTheme = Syncfusion.Windows.Forms.Office2007Theme.Black;
            this.comboBox17.Office2010ColorTheme = Syncfusion.Windows.Forms.Office2010Theme.Managed;
            this.comboBox17.Size = new System.Drawing.Size(192, 31);
            this.comboBox17.Style = Syncfusion.Windows.Forms.VisualStyle.Office2016Colorful;
            this.comboBox17.TabIndex = 160;
            this.comboBox17.Text = "Normal";
            this.comboBox17.SelectedIndexChanged += new System.EventHandler(this.comboBox17_SelectedIndexChanged);
            // 
            // label125
            // 
            this.label125.AutoSize = true;
            this.label125.Location = new System.Drawing.Point(161, 516);
            this.label125.Name = "label125";
            this.label125.Size = new System.Drawing.Size(140, 23);
            this.label125.TabIndex = 159;
            this.label125.Text = "Character Casing";
            // 
            // label98
            // 
            this.label98.AutoSize = true;
            this.label98.Location = new System.Drawing.Point(161, 447);
            this.label98.Name = "label98";
            this.label98.Size = new System.Drawing.Size(49, 23);
            this.label98.TabIndex = 157;
            this.label98.Text = "Mask";
            // 
            // comboBox15
            // 
            this.comboBox15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.comboBox15.BeforeTouchSize = new System.Drawing.Size(192, 31);
            this.comboBox15.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox15.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.comboBox15.Items.AddRange(new object[] {
            "None",
            "##/##/####",
            "##.##",
            "###-########"});
            this.comboBox15.Location = new System.Drawing.Point(355, 447);
            this.comboBox15.Name = "comboBox15";
            this.comboBox15.Office2007ColorTheme = Syncfusion.Windows.Forms.Office2007Theme.Black;
            this.comboBox15.Office2010ColorTheme = Syncfusion.Windows.Forms.Office2010Theme.Managed;
            this.comboBox15.Size = new System.Drawing.Size(192, 31);
            this.comboBox15.Style = Syncfusion.Windows.Forms.VisualStyle.Office2016Colorful;
            this.comboBox15.TabIndex = 156;
            this.comboBox15.Text = "None";
            this.comboBox15.SelectedIndexChanged += new System.EventHandler(this.comboBox15_SelectedIndexChanged);
            // 
            // buttonEdit3
            // 
            this.buttonEdit3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonEdit3.BeforeTouchSize = new System.Drawing.Size(176, 35);
            this.buttonEdit3.Buttons.Add(this.buttonEditChildButton3);
            this.buttonEdit3.ButtonStyle = Syncfusion.Windows.Forms.ButtonAppearance.Office2016Colorful;
            this.buttonEdit3.Controls.Add(this.buttonEditChildButton3);
            this.buttonEdit3.Controls.Add(this.textBoxExt2);
            this.buttonEdit3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonEdit3.Location = new System.Drawing.Point(889, 754);
            this.buttonEdit3.MetroColor = System.Drawing.Color.Silver;
            this.buttonEdit3.Name = "buttonEdit3";
            this.buttonEdit3.ShowTextBox = false;
            this.buttonEdit3.Size = new System.Drawing.Size(176, 35);
            this.buttonEdit3.TabIndex = 154;
            this.buttonEdit3.TextBox = this.textBoxExt2;
            this.buttonEdit3.UseVisualStyle = true;
            this.buttonEdit3.ButtonClicked += new Syncfusion.Windows.Forms.Tools.ButtonClickedEventHandler(this.buttonEdit3_ButtonClicked);
            // 
            // buttonEditChildButton3
            // 
            this.buttonEditChildButton3.BackColor = System.Drawing.Color.Silver;
            this.buttonEditChildButton3.BeforeTouchSize = new System.Drawing.Size(18, 31);
            this.buttonEditChildButton3.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.Flat;
            this.buttonEditChildButton3.ComboEditBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonEditChildButton3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditChildButton3.Image = null;
            this.buttonEditChildButton3.IsBackStageButton = false;
            this.buttonEditChildButton3.Name = "buttonEditChildButton3";
            this.buttonEditChildButton3.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Black;
            this.buttonEditChildButton3.Office2010ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Black;
            this.buttonEditChildButton3.PreferredWidth = 18;
            this.buttonEditChildButton3.TabIndex = 1;
            this.buttonEditChildButton3.Text = "...";
            // 
            // textBoxExt2
            // 
            this.textBoxExt2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.textBoxExt2.BeforeTouchSize = new System.Drawing.Size(130, 29);
            this.textBoxExt2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.textBoxExt2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxExt2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.textBoxExt2.Location = new System.Drawing.Point(2, 3);
            this.textBoxExt2.Metrocolor = System.Drawing.Color.Empty;
            this.textBoxExt2.Name = "textBoxExt2";
            this.textBoxExt2.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Black;
            this.textBoxExt2.Office2010ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Black;
            this.textBoxExt2.OverflowIndicatorToolTipText = null;
            this.textBoxExt2.Size = new System.Drawing.Size(154, 29);
            this.textBoxExt2.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Office2016Colorful;
            this.textBoxExt2.TabIndex = 0;
            // 
            // label80
            // 
            this.label80.AutoSize = true;
            this.label80.Location = new System.Drawing.Point(755, 694);
            this.label80.Name = "label80";
            this.label80.Size = new System.Drawing.Size(91, 23);
            this.label80.TabIndex = 141;
            this.label80.Text = "Back Color";
            // 
            // label81
            // 
            this.label81.AutoSize = true;
            this.label81.Location = new System.Drawing.Point(755, 761);
            this.label81.Name = "label81";
            this.label81.Size = new System.Drawing.Size(89, 23);
            this.label81.TabIndex = 142;
            this.label81.Text = "Fore Color";
            // 
            // label90
            // 
            this.label90.AutoSize = true;
            this.label90.Location = new System.Drawing.Point(755, 837);
            this.label90.Name = "label90";
            this.label90.Size = new System.Drawing.Size(107, 23);
            this.label90.TabIndex = 145;
            this.label90.Text = "Border Color";
            // 
            // comboBox7
            // 
            this.comboBox7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.comboBox7.BeforeTouchSize = new System.Drawing.Size(172, 31);
            this.comboBox7.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox7.Enabled = false;
            this.comboBox7.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.comboBox7.Location = new System.Drawing.Point(893, 572);
            this.comboBox7.Name = "comboBox7";
            this.comboBox7.Office2007ColorTheme = Syncfusion.Windows.Forms.Office2007Theme.Black;
            this.comboBox7.Office2010ColorTheme = Syncfusion.Windows.Forms.Office2010Theme.Managed;
            this.comboBox7.Size = new System.Drawing.Size(172, 31);
            this.comboBox7.Style = Syncfusion.Windows.Forms.VisualStyle.Office2016Colorful;
            this.comboBox7.TabIndex = 146;
            this.comboBox7.SelectedIndexChanged += new System.EventHandler(this.comboBox7_SelectedIndexChanged);
            // 
            // label93
            // 
            this.label93.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label93.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label93.Location = new System.Drawing.Point(713, 362);
            this.label93.Name = "label93";
            this.label93.Size = new System.Drawing.Size(228, 35);
            this.label93.TabIndex = 152;
            this.label93.Text = "Appearance Settings";
            this.label93.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // radioButton8
            // 
            this.radioButton8.BeforeTouchSize = new System.Drawing.Size(146, 38);
            this.radioButton8.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.radioButton8.DrawFocusRectangle = false;
            this.radioButton8.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.radioButton8.HotBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.radioButton8.ImageCheckBoxSize = new System.Drawing.Size(16, 16);
            this.radioButton8.Location = new System.Drawing.Point(893, 484);
            this.radioButton8.MetroColor = System.Drawing.Color.Gray;
            this.radioButton8.Name = "radioButton8";
            this.radioButton8.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Black;
            this.radioButton8.Office2010ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Black;
            this.radioButton8.Size = new System.Drawing.Size(146, 38);
            this.radioButton8.Style = Syncfusion.Windows.Forms.Tools.RadioButtonAdvStyle.Office2016Colorful;
            this.radioButton8.TabIndex = 150;
            this.radioButton8.TabStop = false;
            this.radioButton8.Text = "Fixed3D";
            this.radioButton8.ThemesEnabled = true;
            this.radioButton8.CheckChanged += new System.EventHandler(this.radioButton8_CheckedChanged);
            // 
            // buttonEdit4
            // 
            this.buttonEdit4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonEdit4.BeforeTouchSize = new System.Drawing.Size(176, 35);
            this.buttonEdit4.Buttons.Add(this.buttonEditChildButton7);
            this.buttonEdit4.ButtonStyle = Syncfusion.Windows.Forms.ButtonAppearance.Office2016Colorful;
            this.buttonEdit4.Controls.Add(this.buttonEditChildButton7);
            this.buttonEdit4.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonEdit4.Location = new System.Drawing.Point(889, 824);
            this.buttonEdit4.MetroColor = System.Drawing.Color.Silver;
            this.buttonEdit4.Name = "buttonEdit4";
            this.buttonEdit4.ShowTextBox = false;
            this.buttonEdit4.Size = new System.Drawing.Size(176, 35);
            this.buttonEdit4.TabIndex = 155;
            this.buttonEdit4.UseVisualStyle = true;
            this.buttonEdit4.ButtonClicked += new Syncfusion.Windows.Forms.Tools.ButtonClickedEventHandler(this.buttonEdit4_ButtonClicked);
            // 
            // buttonEditChildButton7
            // 
            this.buttonEditChildButton7.BackColor = System.Drawing.Color.Silver;
            this.buttonEditChildButton7.BeforeTouchSize = new System.Drawing.Size(18, 31);
            this.buttonEditChildButton7.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.Flat;
            this.buttonEditChildButton7.ComboEditBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonEditChildButton7.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditChildButton7.Image = null;
            this.buttonEditChildButton7.IsBackStageButton = false;
            this.buttonEditChildButton7.Name = "buttonEditChildButton7";
            this.buttonEditChildButton7.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Black;
            this.buttonEditChildButton7.Office2010ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Black;
            this.buttonEditChildButton7.PreferredWidth = 18;
            this.buttonEditChildButton7.TabIndex = 1;
            this.buttonEditChildButton7.Text = "...";
            // 
            // radioButton9
            // 
            this.radioButton9.BeforeTouchSize = new System.Drawing.Size(146, 38);
            this.radioButton9.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.radioButton9.Checked = true;
            this.radioButton9.DrawFocusRectangle = false;
            this.radioButton9.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.radioButton9.HotBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.radioButton9.ImageCheckBoxSize = new System.Drawing.Size(16, 16);
            this.radioButton9.Location = new System.Drawing.Point(889, 445);
            this.radioButton9.MetroColor = System.Drawing.Color.Gray;
            this.radioButton9.Name = "radioButton9";
            this.radioButton9.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Black;
            this.radioButton9.Office2010ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Black;
            this.radioButton9.Size = new System.Drawing.Size(146, 38);
            this.radioButton9.Style = Syncfusion.Windows.Forms.Tools.RadioButtonAdvStyle.Office2016Colorful;
            this.radioButton9.TabIndex = 149;
            this.radioButton9.Text = "FixedSingle";
            this.radioButton9.ThemesEnabled = true;
            this.radioButton9.CheckChanged += new System.EventHandler(this.radioButton9_CheckedChanged);
            // 
            // buttonEdit5
            // 
            this.buttonEdit5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonEdit5.BeforeTouchSize = new System.Drawing.Size(176, 35);
            this.buttonEdit5.Buttons.Add(this.buttonEditChildButton8);
            this.buttonEdit5.ButtonStyle = Syncfusion.Windows.Forms.ButtonAppearance.Office2016Colorful;
            this.buttonEdit5.Controls.Add(this.buttonEditChildButton8);
            this.buttonEdit5.Controls.Add(this.textBoxExt1);
            this.buttonEdit5.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonEdit5.Location = new System.Drawing.Point(889, 683);
            this.buttonEdit5.MetroColor = System.Drawing.Color.Silver;
            this.buttonEdit5.Name = "buttonEdit5";
            this.buttonEdit5.ShowTextBox = false;
            this.buttonEdit5.Size = new System.Drawing.Size(176, 35);
            this.buttonEdit5.TabIndex = 153;
            this.buttonEdit5.TextBox = this.textBoxExt1;
            this.buttonEdit5.UseVisualStyle = true;
            this.buttonEdit5.ButtonClicked += new Syncfusion.Windows.Forms.Tools.ButtonClickedEventHandler(this.buttonEdit5_ButtonClicked);
            // 
            // buttonEditChildButton8
            // 
            this.buttonEditChildButton8.BackColor = System.Drawing.Color.Silver;
            this.buttonEditChildButton8.BeforeTouchSize = new System.Drawing.Size(18, 31);
            this.buttonEditChildButton8.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.Flat;
            this.buttonEditChildButton8.ComboEditBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonEditChildButton8.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditChildButton8.Image = null;
            this.buttonEditChildButton8.IsBackStageButton = false;
            this.buttonEditChildButton8.Name = "buttonEditChildButton8";
            this.buttonEditChildButton8.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Black;
            this.buttonEditChildButton8.Office2010ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Black;
            this.buttonEditChildButton8.PreferredWidth = 18;
            this.buttonEditChildButton8.TabIndex = 1;
            this.buttonEditChildButton8.Text = "...";
            // 
            // textBoxExt1
            // 
            this.textBoxExt1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.textBoxExt1.BeforeTouchSize = new System.Drawing.Size(130, 29);
            this.textBoxExt1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.textBoxExt1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxExt1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.textBoxExt1.Location = new System.Drawing.Point(2, 3);
            this.textBoxExt1.Metrocolor = System.Drawing.Color.Empty;
            this.textBoxExt1.Name = "textBoxExt1";
            this.textBoxExt1.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Black;
            this.textBoxExt1.Office2010ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Black;
            this.textBoxExt1.OverflowIndicatorToolTipText = null;
            this.textBoxExt1.Size = new System.Drawing.Size(154, 29);
            this.textBoxExt1.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Office2016Colorful;
            this.textBoxExt1.TabIndex = 0;
            // 
            // label95
            // 
            this.label95.AutoSize = true;
            this.label95.Location = new System.Drawing.Point(755, 452);
            this.label95.Name = "label95";
            this.label95.Size = new System.Drawing.Size(101, 23);
            this.label95.TabIndex = 148;
            this.label95.Text = "Border Style";
            // 
            // comboBox14
            // 
            this.comboBox14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.comboBox14.BeforeTouchSize = new System.Drawing.Size(176, 31);
            this.comboBox14.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox14.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.comboBox14.Items.AddRange(new object[] {
            "Left",
            "Top",
            "Right",
            "Bottom",
            "Middle",
            "All"});
            this.comboBox14.Location = new System.Drawing.Point(889, 622);
            this.comboBox14.Name = "comboBox14";
            this.comboBox14.Office2007ColorTheme = Syncfusion.Windows.Forms.Office2007Theme.Black;
            this.comboBox14.Office2010ColorTheme = Syncfusion.Windows.Forms.Office2010Theme.Managed;
            this.comboBox14.Size = new System.Drawing.Size(176, 31);
            this.comboBox14.Style = Syncfusion.Windows.Forms.VisualStyle.Office2016Colorful;
            this.comboBox14.TabIndex = 147;
            this.comboBox14.Text = "Left";
            this.comboBox14.SelectedIndexChanged += new System.EventHandler(this.comboBox14_SelectedIndexChanged);
            // 
            // label96
            // 
            this.label96.AutoSize = true;
            this.label96.Location = new System.Drawing.Point(755, 633);
            this.label96.Name = "label96";
            this.label96.Size = new System.Drawing.Size(105, 23);
            this.label96.TabIndex = 144;
            this.label96.Text = "Border Sides";
            // 
            // label97
            // 
            this.label97.AutoSize = true;
            this.label97.Location = new System.Drawing.Point(755, 572);
            this.label97.Margin = new System.Windows.Forms.Padding(0);
            this.label97.Name = "label97";
            this.label97.Size = new System.Drawing.Size(122, 23);
            this.label97.TabIndex = 143;
            this.label97.Text = "Border3D Style";
            // 
            // label71
            // 
            this.label71.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label71.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label71.Location = new System.Drawing.Point(120, 361);
            this.label71.Name = "label71";
            this.label71.Size = new System.Drawing.Size(132, 35);
            this.label71.TabIndex = 140;
            this.label71.Text = "Properties";
            this.label71.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.maskedEditBox1);
            this.groupBox6.Controls.Add(this.label64);
            this.groupBox6.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.ForeColor = System.Drawing.Color.Black;
            this.groupBox6.Location = new System.Drawing.Point(429, 66);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(522, 208);
            this.groupBox6.TabIndex = 130;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "MaskedEdit";
            // 
            // maskedEditBox1
            // 
            this.maskedEditBox1.AccessibleDescription = "MaskedEdit TextBox";
            this.maskedEditBox1.AccessibleName = "MaskedEditBox";
            this.maskedEditBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.maskedEditBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.maskedEditBox1.BeforeTouchSize = new System.Drawing.Size(130, 29);
            this.maskedEditBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.maskedEditBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.maskedEditBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.maskedEditBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.maskedEditBox1.Location = new System.Drawing.Point(176, 152);
            this.maskedEditBox1.Metrocolor = System.Drawing.Color.Silver;
            this.maskedEditBox1.Name = "maskedEditBox1";
            this.maskedEditBox1.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Black;
            this.maskedEditBox1.Office2010ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Black;
            this.maskedEditBox1.OverflowIndicatorToolTipText = null;
            this.maskedEditBox1.Size = new System.Drawing.Size(160, 27);
            this.maskedEditBox1.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Office2016Colorful;
            this.maskedEditBox1.TabIndex = 2;
            this.maskedEditBox1.ThemesEnabled = false;
            // 
            // label64
            // 
            this.label64.BackColor = System.Drawing.Color.Transparent;
            this.label64.Dock = System.Windows.Forms.DockStyle.Top;
            this.label64.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label64.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label64.Location = new System.Drawing.Point(3, 23);
            this.label64.Name = "label64";
            this.label64.Size = new System.Drawing.Size(516, 112);
            this.label64.TabIndex = 1;
            this.label64.Text = resources.GetString("label64.Text");
            // 
            // upDownPanel
            // 
            this.upDownPanel.BorderColor = System.Drawing.Color.Gainsboro;
            this.upDownPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.upDownPanel.Controls.Add(this.buttonBanner);
            this.upDownPanel.Controls.Add(this.comboMode);
            this.upDownPanel.Controls.Add(this.bEditBanner);
            this.upDownPanel.Controls.Add(this.textBanner);
            this.upDownPanel.Controls.Add(this.label136);
            this.upDownPanel.Controls.Add(this.label135);
            this.upDownPanel.Controls.Add(this.label134);
            this.upDownPanel.Controls.Add(this.label75);
            this.upDownPanel.Controls.Add(this.comboBox19);
            this.upDownPanel.Controls.Add(this.radioButton2);
            this.upDownPanel.Controls.Add(this.radioButton1);
            this.upDownPanel.Controls.Add(this.label14);
            this.upDownPanel.Controls.Add(this.groupBox3);
            this.upDownPanel.Controls.Add(this.groupBox2);
            this.upDownPanel.Controls.Add(this.label88);
            this.upDownPanel.Controls.Add(this.label84);
            this.upDownPanel.Controls.Add(this.DomainBorderColorEdit);
            this.upDownPanel.Controls.Add(this.checkBox14);
            this.upDownPanel.Controls.Add(this.dataGrid2);
            this.upDownPanel.Controls.Add(this.checkBox19);
            this.upDownPanel.Controls.Add(this.label28);
            this.upDownPanel.Controls.Add(this.label91);
            this.upDownPanel.Controls.Add(this.label29);
            this.upDownPanel.Controls.Add(this.checkBox15);
            this.upDownPanel.Controls.Add(this.label27);
            this.upDownPanel.Controls.Add(this.label30);
            this.upDownPanel.Controls.Add(this.comboBox4);
            this.upDownPanel.Controls.Add(this.comboBox3);
            this.upDownPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.upDownPanel.Location = new System.Drawing.Point(0, 0);
            this.upDownPanel.Name = "upDownPanel";
            this.upDownPanel.Size = new System.Drawing.Size(1350, 880);
            this.upDownPanel.TabIndex = 9;
            // 
            // buttonBanner
            // 
            this.buttonBanner.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2016Black;
            this.buttonBanner.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.buttonBanner.BeforeTouchSize = new System.Drawing.Size(158, 33);
            this.buttonBanner.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBanner.IsBackStageButton = false;
            this.buttonBanner.Location = new System.Drawing.Point(439, 615);
            this.buttonBanner.Name = "buttonBanner";
            this.buttonBanner.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Black;
            this.buttonBanner.Office2010ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Black;
            this.buttonBanner.Size = new System.Drawing.Size(158, 33);
            this.buttonBanner.TabIndex = 2;
            this.buttonBanner.Text = "Set Banner Text";
            this.buttonBanner.UseVisualStyle = true;
            this.buttonBanner.UseVisualStyleBackColor = true;
            this.buttonBanner.Click += new System.EventHandler(this.buttonBanner_Click);
            // 
            // comboMode
            // 
            this.comboMode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.comboMode.BeforeTouchSize = new System.Drawing.Size(161, 31);
            this.comboMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboMode.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboMode.Items.AddRange(new object[] {
            "EditMode",
            "FocusMode"});
            this.comboMode.Location = new System.Drawing.Point(439, 494);
            this.comboMode.Name = "comboMode";
            this.comboMode.Office2007ColorTheme = Syncfusion.Windows.Forms.Office2007Theme.Black;
            this.comboMode.Office2010ColorTheme = Syncfusion.Windows.Forms.Office2010Theme.Managed;
            this.comboMode.Size = new System.Drawing.Size(161, 31);
            this.comboMode.Style = Syncfusion.Windows.Forms.VisualStyle.Office2016Colorful;
            this.comboMode.TabIndex = 138;
            this.comboMode.Text = "EditMode";
            // 
            // bEditBanner
            // 
            this.bEditBanner.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bEditBanner.BeforeTouchSize = new System.Drawing.Size(160, 35);
            this.bEditBanner.Buttons.Add(this.buttonEditChildButton11);
            this.bEditBanner.ButtonStyle = Syncfusion.Windows.Forms.ButtonAppearance.Office2016Colorful;
            this.bEditBanner.Controls.Add(this.buttonEditChildButton11);
            this.bEditBanner.Controls.Add(this.textBoxExt7);
            this.bEditBanner.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.bEditBanner.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bEditBanner.Location = new System.Drawing.Point(439, 556);
            this.bEditBanner.MetroColor = System.Drawing.Color.Gray;
            this.bEditBanner.Name = "bEditBanner";
            this.bEditBanner.ShowTextBox = false;
            this.bEditBanner.Size = new System.Drawing.Size(160, 35);
            this.bEditBanner.TabIndex = 137;
            this.bEditBanner.TextBox = this.textBoxExt7;
            this.bEditBanner.UseVisualStyle = true;
            this.bEditBanner.ButtonClicked += new Syncfusion.Windows.Forms.Tools.ButtonClickedEventHandler(this.bEditBanner_ButtonClicked);
            // 
            // buttonEditChildButton11
            // 
            this.buttonEditChildButton11.BackColor = System.Drawing.Color.Gray;
            this.buttonEditChildButton11.BeforeTouchSize = new System.Drawing.Size(20, 31);
            this.buttonEditChildButton11.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.Flat;
            this.buttonEditChildButton11.ComboEditBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonEditChildButton11.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditChildButton11.Image = null;
            this.buttonEditChildButton11.IsBackStageButton = false;
            this.buttonEditChildButton11.Name = "buttonEditChildButton11";
            this.buttonEditChildButton11.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Black;
            this.buttonEditChildButton11.Office2010ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Black;
            this.buttonEditChildButton11.PreferredWidth = 20;
            this.buttonEditChildButton11.TabIndex = 1;
            this.buttonEditChildButton11.Text = "...";
            // 
            // textBoxExt7
            // 
            this.textBoxExt7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.textBoxExt7.BeforeTouchSize = new System.Drawing.Size(130, 29);
            this.textBoxExt7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.textBoxExt7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxExt7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.textBoxExt7.Location = new System.Drawing.Point(2, 3);
            this.textBoxExt7.Metrocolor = System.Drawing.Color.Empty;
            this.textBoxExt7.Name = "textBoxExt7";
            this.textBoxExt7.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Black;
            this.textBoxExt7.Office2010ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Black;
            this.textBoxExt7.OverflowIndicatorToolTipText = null;
            this.textBoxExt7.Size = new System.Drawing.Size(136, 29);
            this.textBoxExt7.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Office2016Colorful;
            this.textBoxExt7.TabIndex = 0;
            // 
            // textBanner
            // 
            this.textBanner.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.textBanner.BeforeTouchSize = new System.Drawing.Size(130, 29);
            this.textBanner.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.textBanner.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBanner.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBanner.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBanner.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.textBanner.Location = new System.Drawing.Point(439, 443);
            this.textBanner.Metrocolor = System.Drawing.Color.Empty;
            this.textBanner.Name = "textBanner";
            this.textBanner.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Black;
            this.textBanner.Office2010ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Black;
            this.textBanner.Size = new System.Drawing.Size(160, 29);
            this.textBanner.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Office2016Colorful;
            this.textBanner.TabIndex = 136;
            this.textBanner.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBanner_KeyPress);
            // 
            // label136
            // 
            this.label136.AutoSize = true;
            this.label136.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label136.Location = new System.Drawing.Point(360, 563);
            this.label136.Name = "label136";
            this.label136.Size = new System.Drawing.Size(51, 23);
            this.label136.TabIndex = 135;
            this.label136.Text = "Color";
            // 
            // label135
            // 
            this.label135.AutoSize = true;
            this.label135.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label135.Location = new System.Drawing.Point(360, 500);
            this.label135.Name = "label135";
            this.label135.Size = new System.Drawing.Size(54, 23);
            this.label135.TabIndex = 134;
            this.label135.Text = "Mode";
            // 
            // label134
            // 
            this.label134.AutoSize = true;
            this.label134.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label134.Location = new System.Drawing.Point(360, 447);
            this.label134.Name = "label134";
            this.label134.Size = new System.Drawing.Size(40, 23);
            this.label134.TabIndex = 133;
            this.label134.Text = "Text";
            // 
            // label75
            // 
            this.label75.AutoSize = true;
            this.label75.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label75.Location = new System.Drawing.Point(655, 551);
            this.label75.Name = "label75";
            this.label75.Size = new System.Drawing.Size(157, 46);
            this.label75.TabIndex = 131;
            this.label75.Text = "DomainUpdownExt\r\nSpin Orientation";
            // 
            // comboBox19
            // 
            this.comboBox19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.comboBox19.BeforeTouchSize = new System.Drawing.Size(220, 31);
            this.comboBox19.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox19.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.comboBox19.Items.AddRange(new object[] {
            "Vertical",
            "Horizontal"});
            this.comboBox19.Location = new System.Drawing.Point(659, 615);
            this.comboBox19.Name = "comboBox19";
            this.comboBox19.Office2007ColorTheme = Syncfusion.Windows.Forms.Office2007Theme.Black;
            this.comboBox19.Office2010ColorTheme = Syncfusion.Windows.Forms.Office2010Theme.Managed;
            this.comboBox19.Size = new System.Drawing.Size(220, 31);
            this.comboBox19.Style = Syncfusion.Windows.Forms.VisualStyle.Office2016Colorful;
            this.comboBox19.TabIndex = 130;
            this.comboBox19.Text = "Vertical";
            this.comboBox19.SelectedIndexChanged += new System.EventHandler(this.UpdownExtSpinOrientation_Changed);
            // 
            // radioButton2
            // 
            this.radioButton2.BeforeTouchSize = new System.Drawing.Size(111, 36);
            this.radioButton2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.radioButton2.DrawFocusRectangle = false;
            this.radioButton2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.radioButton2.HotBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.radioButton2.ImageCheckBoxSize = new System.Drawing.Size(16, 16);
            this.radioButton2.Location = new System.Drawing.Point(177, 483);
            this.radioButton2.MetroColor = System.Drawing.Color.Gray;
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Black;
            this.radioButton2.Office2010ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Black;
            this.radioButton2.Size = new System.Drawing.Size(111, 36);
            this.radioButton2.Style = Syncfusion.Windows.Forms.Tools.RadioButtonAdvStyle.Office2016Colorful;
            this.radioButton2.TabIndex = 45;
            this.radioButton2.TabStop = false;
            this.radioButton2.Text = "Fixed3D";
            this.radioButton2.ThemesEnabled = true;
            this.radioButton2.CheckChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.BeforeTouchSize = new System.Drawing.Size(128, 27);
            this.radioButton1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.radioButton1.Checked = true;
            this.radioButton1.DrawFocusRectangle = false;
            this.radioButton1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.radioButton1.HotBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.radioButton1.ImageCheckBoxSize = new System.Drawing.Size(16, 16);
            this.radioButton1.Location = new System.Drawing.Point(177, 447);
            this.radioButton1.MetroColor = System.Drawing.Color.Gray;
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Black;
            this.radioButton1.Office2010ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Black;
            this.radioButton1.Size = new System.Drawing.Size(128, 27);
            this.radioButton1.Style = Syncfusion.Windows.Forms.Tools.RadioButtonAdvStyle.Office2016Colorful;
            this.radioButton1.TabIndex = 44;
            this.radioButton1.Text = "FixedSingle";
            this.radioButton1.ThemesEnabled = true;
            this.radioButton1.CheckChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(49, 447);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(101, 23);
            this.label14.TabIndex = 128;
            this.label14.Text = "Border Style";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.numericUpDownExt7);
            this.groupBox3.Controls.Add(this.label24);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.Black;
            this.groupBox3.Location = new System.Drawing.Point(728, 51);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(536, 208);
            this.groupBox3.TabIndex = 127;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "NumericUpDownExt";
            // 
            // numericUpDownExt7
            // 
            this.numericUpDownExt7.BackColor = System.Drawing.Color.White;
            this.numericUpDownExt7.BeforeTouchSize = new System.Drawing.Size(218, 29);
            this.numericUpDownExt7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.numericUpDownExt7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDownExt7.ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Black;
            this.numericUpDownExt7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.numericUpDownExt7.Location = new System.Drawing.Point(171, 132);
            this.numericUpDownExt7.MetroColor = System.Drawing.Color.Gray;
            this.numericUpDownExt7.Name = "numericUpDownExt7";
            this.numericUpDownExt7.Office2010ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Black;
            this.numericUpDownExt7.Size = new System.Drawing.Size(218, 29);
            this.numericUpDownExt7.TabIndex = 124;
            this.numericUpDownExt7.VisualStyle = Syncfusion.Windows.Forms.VisualStyle.Office2016Colorful;
            // 
            // label24
            // 
            this.label24.BackColor = System.Drawing.Color.Transparent;
            this.label24.Dock = System.Windows.Forms.DockStyle.Top;
            this.label24.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label24.Location = new System.Drawing.Point(3, 25);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(530, 82);
            this.label24.TabIndex = 1;
            this.label24.Text = "NumericUpdownExt is an advanced NumericUpdown control to increment/decrement nume" +
    "ric values. It enables XP Themed look-and-feel for the UpDown.\r\n\r\n";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.domainUpDownExt1);
            this.groupBox2.Controls.Add(this.label66);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(93, 51);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(510, 208);
            this.groupBox2.TabIndex = 126;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "DomainUpDownExt";
            // 
            // domainUpDownExt1
            // 
            this.domainUpDownExt1.BackColor = System.Drawing.Color.White;
            this.domainUpDownExt1.BeforeTouchSize = new System.Drawing.Size(216, 29);
            this.domainUpDownExt1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.domainUpDownExt1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.domainUpDownExt1.ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Black;
            this.domainUpDownExt1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.domainUpDownExt1.Items.Add("Item1");
            this.domainUpDownExt1.Items.Add("Item2");
            this.domainUpDownExt1.Items.Add("Item3");
            this.domainUpDownExt1.Items.Add("Item4");
            this.domainUpDownExt1.Items.Add("Item5");
            this.domainUpDownExt1.Location = new System.Drawing.Point(128, 132);
            this.domainUpDownExt1.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.domainUpDownExt1.Name = "domainUpDownExt1";
            this.domainUpDownExt1.Office2010ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Black;
            this.domainUpDownExt1.Size = new System.Drawing.Size(216, 29);
            this.domainUpDownExt1.TabIndex = 52;
            this.domainUpDownExt1.ThemedBorder = false;
            this.domainUpDownExt1.VisualStyle = Syncfusion.Windows.Forms.VisualStyle.Office2016Colorful;
            // 
            // label66
            // 
            this.label66.BackColor = System.Drawing.Color.Transparent;
            this.label66.Dock = System.Windows.Forms.DockStyle.Top;
            this.label66.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label66.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label66.Location = new System.Drawing.Point(3, 25);
            this.label66.Name = "label66";
            this.label66.Size = new System.Drawing.Size(504, 82);
            this.label66.TabIndex = 1;
            this.label66.Text = "DomainUpDownEx is an advanced DomainUpDown control to increment/decrement string " +
    "values. It enables XP Themed look-and-feel for the UpDown.\r\n";
            // 
            // label88
            // 
            this.label88.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label88.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label88.Location = new System.Drawing.Point(360, 374);
            this.label88.Name = "label88";
            this.label88.Size = new System.Drawing.Size(239, 35);
            this.label88.TabIndex = 87;
            this.label88.Text = "BannerText Settings";
            this.label88.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label84
            // 
            this.label84.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label84.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label84.Location = new System.Drawing.Point(655, 375);
            this.label84.Name = "label84";
            this.label84.Size = new System.Drawing.Size(105, 36);
            this.label84.TabIndex = 89;
            this.label84.Text = "General";
            this.label84.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DomainBorderColorEdit
            // 
            this.DomainBorderColorEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.DomainBorderColorEdit.BeforeTouchSize = new System.Drawing.Size(130, 35);
            this.DomainBorderColorEdit.Buttons.Add(this.buttonEditChildButton6);
            this.DomainBorderColorEdit.ButtonStyle = Syncfusion.Windows.Forms.ButtonAppearance.Office2016Colorful;
            this.DomainBorderColorEdit.Controls.Add(this.buttonEditChildButton6);
            this.DomainBorderColorEdit.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.DomainBorderColorEdit.Location = new System.Drawing.Point(183, 676);
            this.DomainBorderColorEdit.MetroColor = System.Drawing.Color.Silver;
            this.DomainBorderColorEdit.Name = "DomainBorderColorEdit";
            this.DomainBorderColorEdit.ShowTextBox = false;
            this.DomainBorderColorEdit.Size = new System.Drawing.Size(130, 35);
            this.DomainBorderColorEdit.TabIndex = 120;
            this.DomainBorderColorEdit.UseVisualStyle = true;
            this.DomainBorderColorEdit.ButtonClicked += new Syncfusion.Windows.Forms.Tools.ButtonClickedEventHandler(this.DomainBorderColorEdit_ButtonClicked);
            // 
            // buttonEditChildButton6
            // 
            this.buttonEditChildButton6.BackColor = System.Drawing.Color.Silver;
            this.buttonEditChildButton6.BeforeTouchSize = new System.Drawing.Size(18, 31);
            this.buttonEditChildButton6.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.Flat;
            this.buttonEditChildButton6.ComboEditBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonEditChildButton6.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditChildButton6.Image = null;
            this.buttonEditChildButton6.IsBackStageButton = false;
            this.buttonEditChildButton6.Name = "buttonEditChildButton6";
            this.buttonEditChildButton6.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Black;
            this.buttonEditChildButton6.Office2010ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Black;
            this.buttonEditChildButton6.PreferredWidth = 18;
            this.buttonEditChildButton6.TabIndex = 1;
            this.buttonEditChildButton6.Text = "...";
            // 
            // checkBox14
            // 
            this.checkBox14.BeforeTouchSize = new System.Drawing.Size(220, 35);
            this.checkBox14.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.checkBox14.DrawFocusRectangle = false;
            this.checkBox14.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.checkBox14.HotBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.checkBox14.ImageCheckBoxSize = new System.Drawing.Size(16, 16);
            this.checkBox14.Location = new System.Drawing.Point(659, 439);
            this.checkBox14.MetroColor = System.Drawing.Color.Gray;
            this.checkBox14.Name = "checkBox14";
            this.checkBox14.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Black;
            this.checkBox14.Office2010ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Black;
            this.checkBox14.Size = new System.Drawing.Size(220, 35);
            this.checkBox14.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Office2016Colorful;
            this.checkBox14.TabIndex = 48;
            this.checkBox14.Text = "ThemesEnabled";
            this.checkBox14.ThemesEnabled = false;
            this.checkBox14.CheckedChanged += new System.EventHandler(this.checkBox14_CheckedChanged);
            // 
            // dataGrid2
            // 
            this.dataGrid2.DataMember = "";
            this.dataGrid2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGrid2.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.dataGrid2.Location = new System.Drawing.Point(951, 521);
            this.dataGrid2.Name = "dataGrid2";
            this.dataGrid2.Size = new System.Drawing.Size(346, 195);
            this.dataGrid2.TabIndex = 94;
            // 
            // checkBox19
            // 
            this.checkBox19.BeforeTouchSize = new System.Drawing.Size(234, 36);
            this.checkBox19.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.checkBox19.DrawFocusRectangle = false;
            this.checkBox19.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.checkBox19.HotBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.checkBox19.ImageCheckBoxSize = new System.Drawing.Size(16, 16);
            this.checkBox19.Location = new System.Drawing.Point(951, 447);
            this.checkBox19.MetroColor = System.Drawing.Color.Gray;
            this.checkBox19.Name = "checkBox19";
            this.checkBox19.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Black;
            this.checkBox19.Office2010ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Black;
            this.checkBox19.Size = new System.Drawing.Size(234, 36);
            this.checkBox19.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Office2016Colorful;
            this.checkBox19.TabIndex = 92;
            this.checkBox19.Text = "Bind To DataBase";
            this.checkBox19.ThemesEnabled = false;
            this.checkBox19.CheckedChanged += new System.EventHandler(this.checkBox19_CheckedChanged);
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(48, 527);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(122, 23);
            this.label28.TabIndex = 28;
            this.label28.Text = "Border3D Style";
            // 
            // label91
            // 
            this.label91.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label91.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label91.Location = new System.Drawing.Point(48, 374);
            this.label91.Name = "label91";
            this.label91.Size = new System.Drawing.Size(183, 35);
            this.label91.TabIndex = 85;
            this.label91.Text = "Border Settings";
            this.label91.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(47, 600);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(105, 23);
            this.label29.TabIndex = 29;
            this.label29.Text = "Border Sides";
            // 
            // checkBox15
            // 
            this.checkBox15.BeforeTouchSize = new System.Drawing.Size(202, 35);
            this.checkBox15.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.checkBox15.Checked = true;
            this.checkBox15.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox15.DrawFocusRectangle = false;
            this.checkBox15.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.checkBox15.HotBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.checkBox15.ImageCheckBoxSize = new System.Drawing.Size(16, 16);
            this.checkBox15.Location = new System.Drawing.Point(659, 483);
            this.checkBox15.MetroColor = System.Drawing.Color.Gray;
            this.checkBox15.Name = "checkBox15";
            this.checkBox15.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Black;
            this.checkBox15.Office2010ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Black;
            this.checkBox15.Size = new System.Drawing.Size(202, 35);
            this.checkBox15.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Office2016Colorful;
            this.checkBox15.TabIndex = 49;
            this.checkBox15.Text = "InterceptArrowKeys";
            this.checkBox15.ThemesEnabled = false;
            this.checkBox15.CheckedChanged += new System.EventHandler(this.checkBox15_CheckedChanged);
            // 
            // label27
            // 
            this.label27.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label27.Location = new System.Drawing.Point(945, 377);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(159, 35);
            this.label27.TabIndex = 96;
            this.label27.Text = "Data Binding";
            this.label27.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(49, 676);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(107, 23);
            this.label30.TabIndex = 30;
            this.label30.Text = "Border Color";
            // 
            // comboBox4
            // 
            this.comboBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.comboBox4.BeforeTouchSize = new System.Drawing.Size(134, 31);
            this.comboBox4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.comboBox4.Items.AddRange(new object[] {
            "Left",
            "Top",
            "Right",
            "Bottom",
            "Middle",
            "All"});
            this.comboBox4.Location = new System.Drawing.Point(183, 600);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Office2007ColorTheme = Syncfusion.Windows.Forms.Office2007Theme.Black;
            this.comboBox4.Office2010ColorTheme = Syncfusion.Windows.Forms.Office2010Theme.Managed;
            this.comboBox4.Size = new System.Drawing.Size(134, 31);
            this.comboBox4.Style = Syncfusion.Windows.Forms.VisualStyle.Office2016Colorful;
            this.comboBox4.TabIndex = 41;
            this.comboBox4.Text = "Left";
            this.comboBox4.SelectedIndexChanged += new System.EventHandler(this.comboBox4_SelectedIndexChanged);
            // 
            // comboBox3
            // 
            this.comboBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.comboBox3.BeforeTouchSize = new System.Drawing.Size(134, 31);
            this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox3.Enabled = false;
            this.comboBox3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.comboBox3.Location = new System.Drawing.Point(183, 528);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Office2007ColorTheme = Syncfusion.Windows.Forms.Office2007Theme.Black;
            this.comboBox3.Office2010ColorTheme = Syncfusion.Windows.Forms.Office2010Theme.Managed;
            this.comboBox3.Size = new System.Drawing.Size(134, 31);
            this.comboBox3.Style = Syncfusion.Windows.Forms.VisualStyle.Office2016Colorful;
            this.comboBox3.TabIndex = 40;
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label65);
            this.groupBox5.Controls.Add(this.currencyEdit1);
            this.groupBox5.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.ForeColor = System.Drawing.Color.Black;
            this.groupBox5.Location = new System.Drawing.Point(332, 27);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(456, 179);
            this.groupBox5.TabIndex = 129;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "CurrencyEdit";
            // 
            // label65
            // 
            this.label65.BackColor = System.Drawing.Color.Transparent;
            this.label65.Dock = System.Windows.Forms.DockStyle.Top;
            this.label65.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label65.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label65.Location = new System.Drawing.Point(3, 25);
            this.label65.Name = "label65";
            this.label65.Size = new System.Drawing.Size(450, 71);
            this.label65.TabIndex = 1;
            this.label65.Text = "Currency Edit is used to display currency values with a calculator button to disp" +
    "lay a dropdown calculator.\r\n";
            // 
            // currencyEdit1
            // 
            this.currencyEdit1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.currencyEdit1.BeforeTouchSize = new System.Drawing.Size(248, 30);
            this.currencyEdit1.Border3DStyle = System.Windows.Forms.Border3DStyle.Etched;
            this.currencyEdit1.ButtonStyle = Syncfusion.Windows.Forms.ButtonAppearance.Office2016Colorful;
            // 
            // 
            // 
            this.currencyEdit1.CalculatorButton.BackColor = System.Drawing.Color.Silver;
            this.currencyEdit1.CalculatorButton.BeforeTouchSize = new System.Drawing.Size(75, 23);
            this.currencyEdit1.CalculatorButton.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.Flat;
            this.currencyEdit1.CalculatorButton.ButtonType = Syncfusion.Windows.Forms.Tools.ButtonTypes.Calculator;
            this.currencyEdit1.CalculatorButton.ComboEditBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.currencyEdit1.CalculatorButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.currencyEdit1.CalculatorButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currencyEdit1.CalculatorButton.Image = ((System.Drawing.Image)(resources.GetObject("currencyEdit1.CalculatorButton.Image")));
            this.currencyEdit1.CalculatorButton.IsBackStageButton = false;
            this.currencyEdit1.CalculatorButton.Name = "";
            this.currencyEdit1.CalculatorButton.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Black;
            this.currencyEdit1.CalculatorButton.Office2010ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Black;
            this.currencyEdit1.CalculatorButton.PreferredWidth = 24;
            this.currencyEdit1.CalculatorButton.TabIndex = 1;
            this.currencyEdit1.FlatBorderColor = System.Drawing.SystemColors.ControlLight;
            this.currencyEdit1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.currencyEdit1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currencyEdit1.Location = new System.Drawing.Point(77, 109);
            this.currencyEdit1.MetroColor = System.Drawing.Color.Silver;
            this.currencyEdit1.Name = "currencyEdit1";
            this.currencyEdit1.PopupCalculatorAlignment = Syncfusion.Windows.Forms.Tools.CalculatorPopupAlignment.Left;
            this.currencyEdit1.Size = new System.Drawing.Size(248, 30);
            this.currencyEdit1.TabIndex = 4;
            // 
            // 
            // 
            this.currencyEdit1.TextBox.BackGroundColor = System.Drawing.SystemColors.Window;
            this.currencyEdit1.TextBox.BeforeTouchSize = new System.Drawing.Size(130, 29);
            this.currencyEdit1.TextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.currencyEdit1.TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.currencyEdit1.TextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.currencyEdit1.TextBox.DecimalValue = new decimal(new int[] {
            0,
            0,
            0,
            131072});
            this.currencyEdit1.TextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.currencyEdit1.TextBox.Location = new System.Drawing.Point(2, 4);
            this.currencyEdit1.TextBox.Metrocolor = System.Drawing.Color.Empty;
            this.currencyEdit1.TextBox.Name = "";
            this.currencyEdit1.TextBox.NullString = "0";
            this.currencyEdit1.TextBox.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Black;
            this.currencyEdit1.TextBox.Office2010ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Black;
            this.currencyEdit1.TextBox.OverflowIndicatorToolTipText = null;
            this.currencyEdit1.TextBox.Size = new System.Drawing.Size(220, 22);
            this.currencyEdit1.TextBox.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Office2016Colorful;
            this.currencyEdit1.TextBox.TabIndex = 0;
            this.currencyEdit1.TextBox.Text = "$0.00";
            this.currencyEdit1.UseVisualStyle = true;
            this.currencyEdit1.CalculatorShowing += new System.ComponentModel.CancelEventHandler(this.currencyEdit1_CalculatorShowing);
            // 
            // label15
            // 
            this.label15.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label15.Location = new System.Drawing.Point(80, 303);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(168, 30);
            this.label15.TabIndex = 26;
            this.label15.Text = "Culture Settings";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label16
            // 
            this.label16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(164)))), ((int)(((byte)(190)))));
            this.label16.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(80, 338);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(210, 2);
            this.label16.TabIndex = 25;
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.comboBox1.BeforeTouchSize = new System.Drawing.Size(186, 31);
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.comboBox1.Location = new System.Drawing.Point(84, 386);
            this.comboBox1.MetroColor = System.Drawing.Color.Gray;
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Office2007ColorTheme = Syncfusion.Windows.Forms.Office2007Theme.Black;
            this.comboBox1.Office2010ColorTheme = Syncfusion.Windows.Forms.Office2010Theme.Managed;
            this.comboBox1.Size = new System.Drawing.Size(186, 31);
            this.comboBox1.Style = Syncfusion.Windows.Forms.VisualStyle.Office2016Colorful;
            this.comboBox1.TabIndex = 27;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label83
            // 
            this.label83.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(164)))), ((int)(((byte)(190)))));
            this.label83.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label83.Location = new System.Drawing.Point(790, 337);
            this.label83.Name = "label83";
            this.label83.Size = new System.Drawing.Size(210, 2);
            this.label83.TabIndex = 86;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(80, 366);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(119, 19);
            this.label17.TabIndex = 28;
            this.label17.Text = "Culture Full Name";
            // 
            // label82
            // 
            this.label82.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label82.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label82.Location = new System.Drawing.Point(787, 301);
            this.label82.Name = "label82";
            this.label82.Size = new System.Drawing.Size(93, 30);
            this.label82.TabIndex = 87;
            this.label82.Text = "Others";
            this.label82.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radWinStd);
            this.groupBox1.Controls.Add(this.radFinancial);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(437, 419);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(201, 118);
            this.groupBox1.TabIndex = 93;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Calculator Type";
            // 
            // radWinStd
            // 
            this.radWinStd.BeforeTouchSize = new System.Drawing.Size(185, 32);
            this.radWinStd.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.radWinStd.DrawFocusRectangle = false;
            this.radWinStd.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radWinStd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.radWinStd.HotBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.radWinStd.ImageCheckBoxSize = new System.Drawing.Size(16, 16);
            this.radWinStd.Location = new System.Drawing.Point(8, 25);
            this.radWinStd.MetroColor = System.Drawing.Color.Gray;
            this.radWinStd.Name = "radWinStd";
            this.radWinStd.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Black;
            this.radWinStd.Office2010ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Black;
            this.radWinStd.Size = new System.Drawing.Size(185, 32);
            this.radWinStd.Style = Syncfusion.Windows.Forms.Tools.RadioButtonAdvStyle.Office2016Colorful;
            this.radWinStd.TabIndex = 33;
            this.radWinStd.TabStop = false;
            this.radWinStd.Text = "Windows Standard";
            this.radWinStd.ThemesEnabled = true;
            this.radWinStd.CheckChanged += new System.EventHandler(this.radWinStd_CheckedChanged);
            // 
            // radFinancial
            // 
            this.radFinancial.BeforeTouchSize = new System.Drawing.Size(185, 32);
            this.radFinancial.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.radFinancial.Checked = true;
            this.radFinancial.DrawFocusRectangle = false;
            this.radFinancial.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radFinancial.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.radFinancial.HotBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.radFinancial.ImageCheckBoxSize = new System.Drawing.Size(16, 16);
            this.radFinancial.Location = new System.Drawing.Point(8, 71);
            this.radFinancial.MetroColor = System.Drawing.Color.Gray;
            this.radFinancial.Name = "radFinancial";
            this.radFinancial.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Black;
            this.radFinancial.Office2010ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Black;
            this.radFinancial.Size = new System.Drawing.Size(185, 32);
            this.radFinancial.Style = Syncfusion.Windows.Forms.Tools.RadioButtonAdvStyle.Office2016Colorful;
            this.radFinancial.TabIndex = 34;
            this.radFinancial.Text = "Financial";
            this.radFinancial.ThemesEnabled = true;
            this.radFinancial.CheckChanged += new System.EventHandler(this.radFinancial_CheckedChanged);
            // 
            // checkBox13
            // 
            this.checkBox13.BeforeTouchSize = new System.Drawing.Size(204, 30);
            this.checkBox13.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.checkBox13.DrawFocusRectangle = false;
            this.checkBox13.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.checkBox13.HotBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.checkBox13.ImageCheckBoxSize = new System.Drawing.Size(16, 16);
            this.checkBox13.Location = new System.Drawing.Point(796, 544);
            this.checkBox13.MetroColor = System.Drawing.Color.Gray;
            this.checkBox13.Name = "checkBox13";
            this.checkBox13.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Black;
            this.checkBox13.Office2010ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Black;
            this.checkBox13.Size = new System.Drawing.Size(204, 30);
            this.checkBox13.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Office2016Colorful;
            this.checkBox13.TabIndex = 41;
            this.checkBox13.Text = "Read Only";
            this.checkBox13.ThemesEnabled = true;
            this.checkBox13.CheckedChanged += new System.EventHandler(this.checkBox13_CheckedChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.comboBox2.BeforeTouchSize = new System.Drawing.Size(186, 31);
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.comboBox2.Location = new System.Drawing.Point(84, 462);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Office2007ColorTheme = Syncfusion.Windows.Forms.Office2007Theme.Black;
            this.comboBox2.Office2010ColorTheme = Syncfusion.Windows.Forms.Office2010Theme.Managed;
            this.comboBox2.Size = new System.Drawing.Size(186, 31);
            this.comboBox2.Style = Syncfusion.Windows.Forms.VisualStyle.Office2016Colorful;
            this.comboBox2.TabIndex = 29;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(796, 358);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(83, 19);
            this.label23.TabIndex = 40;
            this.label23.Text = "Button Type";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(80, 437);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(131, 19);
            this.label18.TabIndex = 30;
            this.label18.Text = "Culture Short Name";
            // 
            // cboButtonType
            // 
            this.cboButtonType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cboButtonType.BeforeTouchSize = new System.Drawing.Size(200, 31);
            this.cboButtonType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboButtonType.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboButtonType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.cboButtonType.Location = new System.Drawing.Point(800, 389);
            this.cboButtonType.Name = "cboButtonType";
            this.cboButtonType.Office2007ColorTheme = Syncfusion.Windows.Forms.Office2007Theme.Black;
            this.cboButtonType.Office2010ColorTheme = Syncfusion.Windows.Forms.Office2010Theme.Managed;
            this.cboButtonType.Size = new System.Drawing.Size(200, 31);
            this.cboButtonType.Style = Syncfusion.Windows.Forms.VisualStyle.Office2016Colorful;
            this.cboButtonType.TabIndex = 39;
            this.cboButtonType.SelectedIndexChanged += new System.EventHandler(this.cboButtonType_SelectedIndexChanged);
            // 
            // label20
            // 
            this.label20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(164)))), ((int)(((byte)(190)))));
            this.label20.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(437, 334);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(210, 2);
            this.label20.TabIndex = 31;
            // 
            // label19
            // 
            this.label19.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label19.Location = new System.Drawing.Point(437, 299);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(182, 30);
            this.label19.TabIndex = 32;
            this.label19.Text = "Calculator Settings";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // checkBox18
            // 
            this.checkBox18.BeforeTouchSize = new System.Drawing.Size(207, 22);
            this.checkBox18.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.checkBox18.DrawFocusRectangle = false;
            this.checkBox18.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.checkBox18.HotBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.checkBox18.ImageCheckBoxSize = new System.Drawing.Size(16, 16);
            this.checkBox18.Location = new System.Drawing.Point(796, 493);
            this.checkBox18.MetroColor = System.Drawing.Color.Gray;
            this.checkBox18.Name = "checkBox18";
            this.checkBox18.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Black;
            this.checkBox18.Office2010ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Black;
            this.checkBox18.Size = new System.Drawing.Size(207, 22);
            this.checkBox18.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Office2016Colorful;
            this.checkBox18.TabIndex = 91;
            this.checkBox18.Text = "TransferToCalculator";
            this.checkBox18.ThemesEnabled = true;
            this.checkBox18.CheckedChanged += new System.EventHandler(this.checkBox18_CheckedChanged);
            // 
            // checkBox12
            // 
            this.checkBox12.BeforeTouchSize = new System.Drawing.Size(168, 27);
            this.checkBox12.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.checkBox12.Checked = true;
            this.checkBox12.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox12.DrawFocusRectangle = false;
            this.checkBox12.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.checkBox12.HotBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.checkBox12.ImageCheckBoxSize = new System.Drawing.Size(16, 16);
            this.checkBox12.Location = new System.Drawing.Point(437, 362);
            this.checkBox12.MetroColor = System.Drawing.Color.Gray;
            this.checkBox12.Name = "checkBox12";
            this.checkBox12.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Black;
            this.checkBox12.Office2010ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Black;
            this.checkBox12.Size = new System.Drawing.Size(168, 27);
            this.checkBox12.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Office2016Colorful;
            this.checkBox12.TabIndex = 35;
            this.checkBox12.Text = "Show Calculator";
            this.checkBox12.ThemesEnabled = true;
            this.checkBox12.CheckedChanged += new System.EventHandler(this.checkBox12_CheckedChanged);
            // 
            // checkBox17
            // 
            this.checkBox17.BeforeTouchSize = new System.Drawing.Size(204, 20);
            this.checkBox17.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.checkBox17.Checked = true;
            this.checkBox17.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox17.DrawFocusRectangle = false;
            this.checkBox17.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.checkBox17.HotBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.checkBox17.ImageCheckBoxSize = new System.Drawing.Size(16, 16);
            this.checkBox17.Location = new System.Drawing.Point(796, 444);
            this.checkBox17.MetroColor = System.Drawing.Color.Gray;
            this.checkBox17.Name = "checkBox17";
            this.checkBox17.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Black;
            this.checkBox17.Office2010ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Black;
            this.checkBox17.Size = new System.Drawing.Size(204, 20);
            this.checkBox17.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Office2016Colorful;
            this.checkBox17.TabIndex = 90;
            this.checkBox17.Text = "TransferFromCalculator";
            this.checkBox17.ThemesEnabled = true;
            this.checkBox17.CheckedChanged += new System.EventHandler(this.checkBox17_CheckedChanged);
            // 
            // checkBox28
            // 
            this.checkBox28.BeforeTouchSize = new System.Drawing.Size(125, 31);
            this.checkBox28.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.checkBox28.DrawFocusRectangle = false;
            this.checkBox28.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox28.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.checkBox28.HotBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.checkBox28.ImageCheckBoxSize = new System.Drawing.Size(16, 16);
            this.checkBox28.Location = new System.Drawing.Point(767, 358);
            this.checkBox28.MetroColor = System.Drawing.Color.Gray;
            this.checkBox28.Name = "checkBox28";
            this.checkBox28.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Black;
            this.checkBox28.Office2010ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Black;
            this.checkBox28.Size = new System.Drawing.Size(125, 31);
            this.checkBox28.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Office2016Colorful;
            this.checkBox28.TabIndex = 87;
            this.checkBox28.Text = "Right To Left";
            this.checkBox28.ThemesEnabled = true;
            this.checkBox28.CheckedChanged += new System.EventHandler(this.checkBox28_CheckedChanged);
            // 
            // checkBox27
            // 
            this.checkBox27.BeforeTouchSize = new System.Drawing.Size(255, 31);
            this.checkBox27.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.checkBox27.Checked = true;
            this.checkBox27.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox27.DrawFocusRectangle = false;
            this.checkBox27.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox27.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.checkBox27.HotBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.checkBox27.ImageCheckBoxSize = new System.Drawing.Size(16, 16);
            this.checkBox27.Location = new System.Drawing.Point(458, 358);
            this.checkBox27.MetroColor = System.Drawing.Color.Gray;
            this.checkBox27.Name = "checkBox27";
            this.checkBox27.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Black;
            this.checkBox27.Office2010ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Black;
            this.checkBox27.Size = new System.Drawing.Size(255, 31);
            this.checkBox27.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Office2016Colorful;
            this.checkBox27.TabIndex = 85;
            this.checkBox27.Text = "Want Button Visible";
            this.checkBox27.ThemesEnabled = true;
            this.checkBox27.CheckedChanged += new System.EventHandler(this.checkBox27_CheckedChanged);
            // 
            // comboBox13
            // 
            this.comboBox13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.comboBox13.BeforeTouchSize = new System.Drawing.Size(105, 31);
            this.comboBox13.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox13.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.comboBox13.Items.AddRange(new object[] {
            "Left",
            "Right",
            "Center"});
            this.comboBox13.Location = new System.Drawing.Point(237, 355);
            this.comboBox13.MetroColor = System.Drawing.Color.Gray;
            this.comboBox13.Name = "comboBox13";
            this.comboBox13.Office2007ColorTheme = Syncfusion.Windows.Forms.Office2007Theme.Black;
            this.comboBox13.Office2010ColorTheme = Syncfusion.Windows.Forms.Office2010Theme.Managed;
            this.comboBox13.Size = new System.Drawing.Size(105, 31);
            this.comboBox13.Style = Syncfusion.Windows.Forms.VisualStyle.Office2016Colorful;
            this.comboBox13.TabIndex = 84;
            this.comboBox13.Text = "Left";
            this.comboBox13.SelectedIndexChanged += new System.EventHandler(this.comboBox13_SelectedIndexChanged);
            // 
            // label117
            // 
            this.label117.AutoSize = true;
            this.label117.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label117.Location = new System.Drawing.Point(99, 358);
            this.label117.Name = "label117";
            this.label117.Size = new System.Drawing.Size(115, 19);
            this.label117.TabIndex = 83;
            this.label117.Text = "ListBox Text Align";
            // 
            // gradientPanel4
            // 
            this.gradientPanel4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(178)))), ((int)(((byte)(227)))));
            this.gradientPanel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gradientPanel4.Controls.Add(this.label122);
            this.gradientPanel4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gradientPanel4.Location = new System.Drawing.Point(237, 510);
            this.gradientPanel4.Name = "gradientPanel4";
            this.gradientPanel4.Size = new System.Drawing.Size(628, 61);
            this.gradientPanel4.TabIndex = 82;
            this.gradientPanel4.ThemesEnabled = true;
            // 
            // label122
            // 
            this.label122.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label122.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label122.Location = new System.Drawing.Point(0, 0);
            this.label122.Name = "label122";
            this.label122.Size = new System.Drawing.Size(626, 59);
            this.label122.TabIndex = 1;
            this.label122.Text = "Drag file names from Windows Explorer and drop them into EditableList. \r\nDouble C" +
    "lick on to any item to edit";
            // 
            // label118
            // 
            this.label118.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label118.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label118.Location = new System.Drawing.Point(94, 300);
            this.label118.Name = "label118";
            this.label118.Size = new System.Drawing.Size(120, 31);
            this.label118.TabIndex = 81;
            this.label118.Text = "Properties";
            this.label118.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label119
            // 
            this.label119.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(164)))), ((int)(((byte)(190)))));
            this.label119.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label119.Location = new System.Drawing.Point(94, 331);
            this.label119.Name = "label119";
            this.label119.Size = new System.Drawing.Size(910, 1);
            this.label119.TabIndex = 80;
            // 
            // label120
            // 
            this.label120.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label120.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label120.Location = new System.Drawing.Point(88, 462);
            this.label120.Name = "label120";
            this.label120.Size = new System.Drawing.Size(153, 31);
            this.label120.TabIndex = 79;
            this.label120.Text = "Drag And Drop";
            this.label120.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label121
            // 
            this.label121.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(164)))), ((int)(((byte)(190)))));
            this.label121.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label121.Location = new System.Drawing.Point(88, 493);
            this.label121.Name = "label121";
            this.label121.Size = new System.Drawing.Size(910, 1);
            this.label121.TabIndex = 78;
            // 
            // editableList2
            // 
            this.editableList2.AllowDrop = true;
            this.editableList2.AutoScroll = true;
            this.editableList2.BeforeTouchSize = new System.Drawing.Size(495, 123);
            // 
            // 
            // 
            this.editableList2.Button.BackColor = System.Drawing.Color.Azure;
            this.editableList2.Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editableList2.Button.ImageList = this.imageList1;
            this.editableList2.Button.Location = new System.Drawing.Point(157, 152);
            this.editableList2.Button.Name = "button";
            this.editableList2.Button.Size = new System.Drawing.Size(42, 25);
            this.editableList2.Button.TabIndex = 2;
            this.editableList2.Button.Text = "...";
            this.editableList2.Button.UseVisualStyleBackColor = false;
            this.editableList2.Button.Visible = false;
            this.editableList2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // 
            // 
            this.editableList2.ListBox.ColumnWidth = 1;
            this.editableList2.ListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.editableList2.ListBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.editableList2.ListBox.Location = new System.Drawing.Point(0, 0);
            this.editableList2.ListBox.Name = "listBox";
            this.editableList2.ListBox.Size = new System.Drawing.Size(495, 123);
            this.editableList2.ListBox.TabIndex = 0;
            this.editableList2.Location = new System.Drawing.Point(304, 579);
            this.editableList2.Name = "editableList2";
            metroColorTable1.ArrowChecked = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(149)))), ((int)(((byte)(152)))));
            metroColorTable1.ArrowCheckedBorderColor = System.Drawing.Color.Empty;
            metroColorTable1.ArrowInActive = System.Drawing.Color.White;
            metroColorTable1.ArrowNormal = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(198)))), ((int)(((byte)(198)))));
            metroColorTable1.ArrowNormalBackGround = System.Drawing.Color.Empty;
            metroColorTable1.ArrowNormalBorderColor = System.Drawing.Color.Empty;
            metroColorTable1.ArrowPushed = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(89)))), ((int)(((byte)(90)))));
            metroColorTable1.ArrowPushedBackGround = System.Drawing.Color.Empty;
            metroColorTable1.ArrowPushedBorderColor = System.Drawing.Color.Empty;
            metroColorTable1.ScrollerBackground = System.Drawing.Color.White;
            metroColorTable1.ThumbChecked = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(149)))), ((int)(((byte)(152)))));
            metroColorTable1.ThumbCheckedBorderColor = System.Drawing.Color.Empty;
            metroColorTable1.ThumbInActive = System.Drawing.Color.White;
            metroColorTable1.ThumbNormal = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(198)))), ((int)(((byte)(198)))));
            metroColorTable1.ThumbNormalBorderColor = System.Drawing.Color.Empty;
            metroColorTable1.ThumbPushed = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(89)))), ((int)(((byte)(90)))));
            metroColorTable1.ThumbPushedBorder = System.Drawing.Color.Empty;
            metroColorTable1.ThumbPushedBorderColor = System.Drawing.Color.Empty;
            this.editableList2.ScrollMetroColorTable = metroColorTable1;
            this.editableList2.Size = new System.Drawing.Size(495, 123);
            this.editableList2.TabIndex = 9;
            // 
            // 
            // 
            this.editableList2.TextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.editableList2.TextBox.BeforeTouchSize = new System.Drawing.Size(130, 29);
            this.editableList2.TextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.editableList2.TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.editableList2.TextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.editableList2.TextBox.Location = new System.Drawing.Point(11, 152);
            this.editableList2.TextBox.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.editableList2.TextBox.Name = "textBox";
            this.editableList2.TextBox.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Black;
            this.editableList2.TextBox.Office2010ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Black;
            this.editableList2.TextBox.Size = new System.Drawing.Size(140, 29);
            this.editableList2.TextBox.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Office2016Colorful;
            this.editableList2.TextBox.TabIndex = 2;
            this.editableList2.TextBox.Visible = false;
            this.editableList2.DragDrop += new System.Windows.Forms.DragEventHandler(this.editableList2_DragDrop);
            this.editableList2.DragEnter += new System.Windows.Forms.DragEventHandler(this.editableList2_DragEnter);
            // 
            // gradientPanel3
            // 
            this.gradientPanel3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(178)))), ((int)(((byte)(227)))));
            this.gradientPanel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gradientPanel3.Controls.Add(this.label116);
            this.gradientPanel3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gradientPanel3.Location = new System.Drawing.Point(125, 20);
            this.gradientPanel3.Name = "gradientPanel3";
            this.gradientPanel3.Size = new System.Drawing.Size(842, 70);
            this.gradientPanel3.TabIndex = 8;
            this.gradientPanel3.ThemesEnabled = true;
            // 
            // label116
            // 
            this.label116.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label116.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label116.Location = new System.Drawing.Point(0, 0);
            this.label116.Name = "label116";
            this.label116.Size = new System.Drawing.Size(840, 68);
            this.label116.TabIndex = 1;
            this.label116.Text = "EditableList control provides an editable Windows Forms list box with a Windows F" +
    "orms text box and button on \r\nthe current row to facilitate in-place editing.You" +
    " need to double Click on items to edit";
            // 
            // editableList1
            // 
            this.editableList1.AllowDrop = true;
            this.editableList1.AutoScroll = true;
            this.editableList1.BackColor = System.Drawing.Color.White;
            this.editableList1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.editableList1.BeforeTouchSize = new System.Drawing.Size(495, 143);
            // 
            // 
            // 
            this.editableList1.Button.BackColor = System.Drawing.Color.Azure;
            this.editableList1.Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editableList1.Button.ImageIndex = 0;
            this.editableList1.Button.Location = new System.Drawing.Point(627, 81);
            this.editableList1.Button.Name = "button";
            this.editableList1.Button.Size = new System.Drawing.Size(42, 25);
            this.editableList1.Button.TabIndex = 2;
            this.editableList1.Button.Text = "...";
            this.editableList1.Button.UseVisualStyleBackColor = false;
            this.editableList1.Button.Visible = false;
            this.editableList1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // 
            // 
            this.editableList1.ListBox.ColumnWidth = 1;
            this.editableList1.ListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.editableList1.ListBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.editableList1.ListBox.Items.AddRange(new object[] {
            "C:\\Program Files\\Syncfusion\\Essential Suite\\",
            "C:\\Program Files\\Syncfusion\\Essential Suite\\Tools\\",
            "C:\\Program Files\\Syncfusion\\Essential Suite\\Tools\\Samples\\",
            "C:\\Program Files\\Syncfusion\\Essential Suite\\Tools\\Samples\\EditableList\\",
            "C:\\Program Files\\Syncfusion\\Essential Suite\\Tools\\Samples\\EditableList\\EditableLi" +
                "stDemo\\",
            "C:\\Program Files\\Syncfusion\\Essential Suite\\Tools\\Samples\\EditableList\\EditableLi" +
                "stDemo\\CS\\",
            "C:\\Program Files\\Syncfusion\\Essential Suite\\Tools\\Samples\\EditableList\\EditableLi" +
                "stDemo\\VB\\"});
            this.editableList1.ListBox.Location = new System.Drawing.Point(0, 0);
            this.editableList1.ListBox.Name = "listBox";
            this.editableList1.ListBox.Size = new System.Drawing.Size(495, 143);
            this.editableList1.ListBox.TabIndex = 0;
            this.editableList1.Location = new System.Drawing.Point(304, 119);
            this.editableList1.Name = "editableList1";
            this.editableList1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            metroColorTable2.ArrowChecked = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(149)))), ((int)(((byte)(152)))));
            metroColorTable2.ArrowCheckedBorderColor = System.Drawing.Color.Empty;
            metroColorTable2.ArrowInActive = System.Drawing.Color.White;
            metroColorTable2.ArrowNormal = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(198)))), ((int)(((byte)(198)))));
            metroColorTable2.ArrowNormalBackGround = System.Drawing.Color.Empty;
            metroColorTable2.ArrowNormalBorderColor = System.Drawing.Color.Empty;
            metroColorTable2.ArrowPushed = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(89)))), ((int)(((byte)(90)))));
            metroColorTable2.ArrowPushedBackGround = System.Drawing.Color.Empty;
            metroColorTable2.ArrowPushedBorderColor = System.Drawing.Color.Empty;
            metroColorTable2.ScrollerBackground = System.Drawing.Color.White;
            metroColorTable2.ThumbChecked = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(149)))), ((int)(((byte)(152)))));
            metroColorTable2.ThumbCheckedBorderColor = System.Drawing.Color.Empty;
            metroColorTable2.ThumbInActive = System.Drawing.Color.White;
            metroColorTable2.ThumbNormal = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(198)))), ((int)(((byte)(198)))));
            metroColorTable2.ThumbNormalBorderColor = System.Drawing.Color.Empty;
            metroColorTable2.ThumbPushed = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(89)))), ((int)(((byte)(90)))));
            metroColorTable2.ThumbPushedBorder = System.Drawing.Color.Empty;
            metroColorTable2.ThumbPushedBorderColor = System.Drawing.Color.Empty;
            this.editableList1.ScrollMetroColorTable = metroColorTable2;
            this.editableList1.Size = new System.Drawing.Size(495, 143);
            this.editableList1.TabIndex = 7;
            // 
            // 
            // 
            this.editableList1.TextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.editableList1.TextBox.BeforeTouchSize = new System.Drawing.Size(130, 29);
            this.editableList1.TextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.editableList1.TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.editableList1.TextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.editableList1.TextBox.Location = new System.Drawing.Point(3, 81);
            this.editableList1.TextBox.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.editableList1.TextBox.Name = "textBox";
            this.editableList1.TextBox.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Black;
            this.editableList1.TextBox.Office2010ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Black;
            this.editableList1.TextBox.Size = new System.Drawing.Size(624, 29);
            this.editableList1.TextBox.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Office2016Colorful;
            this.editableList1.TextBox.TabIndex = 2;
            this.editableList1.TextBox.Visible = false;
            // 
            // label34
            // 
            this.label34.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label34.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label34.Image = ((System.Drawing.Image)(resources.GetObject("label34.Image")));
            this.label34.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label34.Location = new System.Drawing.Point(13, 98);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(100, 24);
            this.label34.TabIndex = 16;
            this.label34.Text = "More Options";
            this.label34.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(164)))), ((int)(((byte)(190)))));
            this.label13.Location = new System.Drawing.Point(13, 123);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(250, 1);
            this.label13.TabIndex = 13;
            // 
            // checkBox5
            // 
            this.checkBox5.BeforeTouchSize = new System.Drawing.Size(150, 21);
            this.checkBox5.Checked = true;
            this.checkBox5.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox5.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox5.ImageCheckBoxSize = new System.Drawing.Size(16, 16);
            this.checkBox5.Location = new System.Drawing.Point(26, 55);
            this.checkBox5.MetroColor = System.Drawing.Color.Empty;
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(68, 18);
            this.checkBox5.TabIndex = 5;
            this.checkBox5.Text = "First Tab";
            this.checkBox5.ThemesEnabled = false;
            // 
            // label35
            // 
            this.label35.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label35.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label35.Image = ((System.Drawing.Image)(resources.GetObject("label35.Image")));
            this.label35.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label35.Location = new System.Drawing.Point(291, 98);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(133, 24);
            this.label35.TabIndex = 17;
            this.label35.Text = "Custom Primitives";
            this.label35.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label26
            // 
            this.label26.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label26.Image = ((System.Drawing.Image)(resources.GetObject("label26.Image")));
            this.label26.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label26.Location = new System.Drawing.Point(13, 11);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(75, 24);
            this.label26.TabIndex = 15;
            this.label26.Text = "Visibility";
            this.label26.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(164)))), ((int)(((byte)(190)))));
            this.label11.Location = new System.Drawing.Point(291, 123);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(230, 1);
            this.label11.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(164)))), ((int)(((byte)(190)))));
            this.label9.Location = new System.Drawing.Point(13, 35);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(510, 1);
            this.label9.TabIndex = 7;
            // 
            // checkBox9
            // 
            this.checkBox9.BeforeTouchSize = new System.Drawing.Size(150, 21);
            this.checkBox9.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox9.ImageCheckBoxSize = new System.Drawing.Size(16, 16);
            this.checkBox9.Location = new System.Drawing.Point(142, 139);
            this.checkBox9.MetroColor = System.Drawing.Color.Empty;
            this.checkBox9.Name = "checkBox9";
            this.checkBox9.Size = new System.Drawing.Size(118, 18);
            this.checkBox9.TabIndex = 12;
            this.checkBox9.Text = "Show Close button";
            this.checkBox9.ThemesEnabled = false;
            // 
            // checkBox8
            // 
            this.checkBox8.BeforeTouchSize = new System.Drawing.Size(150, 21);
            this.checkBox8.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox8.ImageCheckBoxSize = new System.Drawing.Size(16, 16);
            this.checkBox8.Location = new System.Drawing.Point(26, 139);
            this.checkBox8.MetroColor = System.Drawing.Color.Empty;
            this.checkBox8.Name = "checkBox8";
            this.checkBox8.Size = new System.Drawing.Size(110, 18);
            this.checkBox8.TabIndex = 12;
            this.checkBox8.Text = "Show DropDown";
            this.checkBox8.ThemesEnabled = false;
            // 
            // checkBox7
            // 
            this.checkBox7.BeforeTouchSize = new System.Drawing.Size(150, 21);
            this.checkBox7.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox7.ImageCheckBoxSize = new System.Drawing.Size(16, 16);
            this.checkBox7.Location = new System.Drawing.Point(304, 139);
            this.checkBox7.MetroColor = System.Drawing.Color.Empty;
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(136, 18);
            this.checkBox7.TabIndex = 9;
            this.checkBox7.Text = "Show Custom Primitive";
            this.checkBox7.ThemesEnabled = false;
            // 
            // checkBox6
            // 
            this.checkBox6.BeforeTouchSize = new System.Drawing.Size(150, 21);
            this.checkBox6.Checked = true;
            this.checkBox6.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox6.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox6.ImageCheckBoxSize = new System.Drawing.Size(16, 16);
            this.checkBox6.Location = new System.Drawing.Point(294, 55);
            this.checkBox6.MetroColor = System.Drawing.Color.Empty;
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(69, 18);
            this.checkBox6.TabIndex = 4;
            this.checkBox6.Text = "Next Tab";
            this.checkBox6.ThemesEnabled = false;
            // 
            // checkBox4
            // 
            this.checkBox4.BeforeTouchSize = new System.Drawing.Size(150, 21);
            this.checkBox4.Checked = true;
            this.checkBox4.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox4.ImageCheckBoxSize = new System.Drawing.Size(16, 16);
            this.checkBox4.Location = new System.Drawing.Point(369, 55);
            this.checkBox4.MetroColor = System.Drawing.Color.Empty;
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(75, 18);
            this.checkBox4.TabIndex = 6;
            this.checkBox4.Text = "Next Page";
            this.checkBox4.ThemesEnabled = false;
            // 
            // checkBox3
            // 
            this.checkBox3.BeforeTouchSize = new System.Drawing.Size(150, 21);
            this.checkBox3.Checked = true;
            this.checkBox3.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox3.ImageCheckBoxSize = new System.Drawing.Size(16, 16);
            this.checkBox3.Location = new System.Drawing.Point(100, 55);
            this.checkBox3.MetroColor = System.Drawing.Color.Empty;
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(95, 18);
            this.checkBox3.TabIndex = 1;
            this.checkBox3.Text = "Previous Page";
            this.checkBox3.ThemesEnabled = false;
            // 
            // checkBox10
            // 
            this.checkBox10.BeforeTouchSize = new System.Drawing.Size(150, 21);
            this.checkBox10.Checked = true;
            this.checkBox10.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox10.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox10.ImageCheckBoxSize = new System.Drawing.Size(16, 16);
            this.checkBox10.Location = new System.Drawing.Point(449, 55);
            this.checkBox10.MetroColor = System.Drawing.Color.Empty;
            this.checkBox10.Name = "checkBox10";
            this.checkBox10.Size = new System.Drawing.Size(68, 18);
            this.checkBox10.TabIndex = 2;
            this.checkBox10.Text = "Last Tab";
            this.checkBox10.ThemesEnabled = false;
            // 
            // checkBox11
            // 
            this.checkBox11.BeforeTouchSize = new System.Drawing.Size(150, 21);
            this.checkBox11.Checked = true;
            this.checkBox11.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox11.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox11.ImageCheckBoxSize = new System.Drawing.Size(16, 16);
            this.checkBox11.Location = new System.Drawing.Point(202, 55);
            this.checkBox11.MetroColor = System.Drawing.Color.Empty;
            this.checkBox11.Name = "checkBox11";
            this.checkBox11.Size = new System.Drawing.Size(89, 18);
            this.checkBox11.TabIndex = 3;
            this.checkBox11.Text = "Previous Tab";
            this.checkBox11.ThemesEnabled = false;
            // 
            // dataSet11
            // 
            this.dataSet11.DataSetName = "DataSet1";
            this.dataSet11.Locale = new System.Globalization.CultureInfo("en-US");
            this.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // treeViewAdv1
            // 
            this.treeViewAdv1.AccelerateScrolling = Syncfusion.Windows.Forms.AccelerateScrollingBehavior.Immediate;
            this.treeViewAdv1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.treeViewAdv1.BackgroundColor = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255))))));
            treeNodeAdvStyleInfo1.EnsureDefaultOptionedChild = true;
            treeNodeAdvStyleInfo1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            treeNodeAdvStyleInfo1.ShowPlusMinus = false;
            treeNodeAdvStyleInfo1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            treeNodeAdvStyleInfo1.ThemesEnabled = false;
            this.treeViewAdv1.BaseStylePairs.AddRange(new Syncfusion.Windows.Forms.Tools.StyleNamePair[] {
            new Syncfusion.Windows.Forms.Tools.StyleNamePair("Standard", treeNodeAdvStyleInfo1)});
            this.treeViewAdv1.BeforeTouchSize = new System.Drawing.Size(254, 880);
            this.treeViewAdv1.Border3DStyle = System.Windows.Forms.Border3DStyle.Flat;
            this.treeViewAdv1.BorderColor = System.Drawing.Color.Gainsboro;
            this.treeViewAdv1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.treeViewAdv1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeViewAdv1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            // 
            // 
            // 
            this.treeViewAdv1.HelpTextControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.treeViewAdv1.HelpTextControl.Location = new System.Drawing.Point(0, 0);
            this.treeViewAdv1.HelpTextControl.Name = "helpText";
            this.treeViewAdv1.HelpTextControl.Size = new System.Drawing.Size(71, 22);
            this.treeViewAdv1.HelpTextControl.TabIndex = 0;
            this.treeViewAdv1.HelpTextControl.Text = "help text";
            this.treeViewAdv1.HotTracking = true;
            this.treeViewAdv1.InactiveSelectedNodeForeColor = System.Drawing.SystemColors.ControlText;
            this.treeViewAdv1.ItemHeight = 56;
            this.treeViewAdv1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(94)))), ((int)(((byte)(94)))));
            this.treeViewAdv1.Location = new System.Drawing.Point(0, 53);
            this.treeViewAdv1.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218)))));
            this.treeViewAdv1.Name = "treeViewAdv1";
            treeNodeAdv1.BaseStyle = "Style2";
            treeNodeAdv1.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv1.EnsureDefaultOptionedChild = true;
            treeNodeAdv1.Expanded = true;
            treeNodeAdv1.MultiLine = true;
            treeNodeAdv1.PlusMinusSize = new System.Drawing.Size(9, 9);
            treeNodeAdv1.ShowLine = true;
            treeNodeAdv1.Text = "Input Controls";
            treeNodeAdv2.BaseStyle = "Style2";
            treeNodeAdv2.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv2.EnsureDefaultOptionedChild = true;
            treeNodeAdv2.Expanded = true;
            treeNodeAdv2.MultiLine = true;
            treeNodeAdv2.PlusMinusSize = new System.Drawing.Size(9, 9);
            treeNodeAdv2.ShowLine = true;
            treeNodeAdv2.Text = "UpDownExt Controls";
            treeNodeAdv3.BaseStyle = "Style2";
            treeNodeAdv3.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv3.EnsureDefaultOptionedChild = true;
            treeNodeAdv3.MultiLine = true;
            treeNodeAdv3.PlusMinusSize = new System.Drawing.Size(9, 9);
            treeNodeAdv3.ShowLine = true;
            treeNodeAdv3.Text = "TextBoxExt";
            treeNodeAdv4.BaseStyle = "Style2";
            treeNodeAdv4.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv4.EnsureDefaultOptionedChild = true;
            treeNodeAdv4.MultiLine = true;
            treeNodeAdv4.PlusMinusSize = new System.Drawing.Size(9, 9);
            treeNodeAdv4.ShowLine = true;
            treeNodeAdv4.Text = "Masked Edit";
            this.treeViewAdv1.Nodes.AddRange(new Syncfusion.Windows.Forms.Tools.TreeNodeAdv[] {
            treeNodeAdv1,
            treeNodeAdv2,
            treeNodeAdv3,
            treeNodeAdv4});
            this.treeViewAdv1.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Black;
            this.treeViewAdv1.Office2010ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Black;
            this.treeViewAdv1.SelectedNodeBackground = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197))))));
            this.treeViewAdv1.SelectedNodeForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.treeViewAdv1.ShowFocusRect = false;
            this.treeViewAdv1.ShowLines = false;
            this.treeViewAdv1.ShowPlusMinus = false;
            this.treeViewAdv1.Size = new System.Drawing.Size(254, 880);
            this.treeViewAdv1.Style = Syncfusion.Windows.Forms.Tools.TreeStyle.Office2016Colorful;
            this.treeViewAdv1.TabIndex = 4;
            this.treeViewAdv1.Text = "treeViewAdv1";
            this.treeViewAdv1.ThemesEnabled = false;
            // 
            // 
            // 
            this.treeViewAdv1.ToolTipControl.BackColor = System.Drawing.SystemColors.Info;
            this.treeViewAdv1.ToolTipControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.treeViewAdv1.ToolTipControl.Location = new System.Drawing.Point(0, 0);
            this.treeViewAdv1.ToolTipControl.Name = "toolTip";
            this.treeViewAdv1.ToolTipControl.Size = new System.Drawing.Size(58, 22);
            this.treeViewAdv1.ToolTipControl.TabIndex = 1;
            this.treeViewAdv1.ToolTipControl.Text = "toolTip";
            this.treeViewAdv1.TransparentControls = true;
            this.treeViewAdv1.AfterSelect += new System.EventHandler(this.treeViewAdv1_AfterSelect);
            // 
            // gradientLabel1
            // 
            this.gradientLabel1.BackgroundColor = new Syncfusion.Drawing.BrushInfo();
            this.gradientLabel1.BeforeTouchSize = new System.Drawing.Size(1609, 50);
            this.gradientLabel1.BorderColor = System.Drawing.Color.Gainsboro;
            this.gradientLabel1.BorderSides = ((System.Windows.Forms.Border3DSide)((((System.Windows.Forms.Border3DSide.Left | System.Windows.Forms.Border3DSide.Top) 
            | System.Windows.Forms.Border3DSide.Right) 
            | System.Windows.Forms.Border3DSide.Bottom)));
            this.gradientLabel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gradientLabel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gradientLabel1.ForeColor = System.Drawing.Color.Black;
            this.gradientLabel1.Location = new System.Drawing.Point(0, 0);
            this.gradientLabel1.Name = "gradientLabel1";
            this.gradientLabel1.Size = new System.Drawing.Size(1609, 50);
            this.gradientLabel1.TabIndex = 5;
            this.gradientLabel1.Text = " Editor Controls";
            this.gradientLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.gradientLabel1.Click += new System.EventHandler(this.gradientLabel1_Click);
            // 
            // comboBoxAdv3
            // 
            this.comboBoxAdv3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.comboBoxAdv3.BeforeTouchSize = new System.Drawing.Size(217, 31);
            this.comboBoxAdv3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAdv3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxAdv3.Items.AddRange(new object[] {
            "Office2007Blue",
            "Office2007Silver",
            "Office2007Black",
            "Office2010Blue",
            "Office2010Black",
            "Office2010Silver",
            "Metro",
            "Office2016Colorful",
            "Office2016White",
            "Office2016DarkGray",
            "Office2016Black"});
            this.comboBoxAdv3.Location = new System.Drawing.Point(1317, 8);
            this.comboBoxAdv3.Name = "comboBoxAdv3";
            this.comboBoxAdv3.Office2007ColorTheme = Syncfusion.Windows.Forms.Office2007Theme.Black;
            this.comboBoxAdv3.Office2010ColorTheme = Syncfusion.Windows.Forms.Office2010Theme.Managed;
            this.comboBoxAdv3.Size = new System.Drawing.Size(217, 31);
            this.comboBoxAdv3.Style = Syncfusion.Windows.Forms.VisualStyle.Office2016Colorful;
            this.comboBoxAdv3.TabIndex = 6;
            this.comboBoxAdv3.Text = "Office2007Blue";
            this.comboBoxAdv3.SelectedIndexChanged += new System.EventHandler(this.comboBoxAdv3_SelectedIndexChanged);
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.BackColor = System.Drawing.Color.Transparent;
            this.label31.Location = new System.Drawing.Point(1213, 13);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(95, 23);
            this.label31.TabIndex = 7;
            this.label31.Text = "Visual Style";
            // 
            // skinManager1
            // 
            this.skinManager1.Controls = this;
            this.skinManager1.VisualTheme = Syncfusion.Windows.Forms.VisualTheme.Office2016Colorful;
            // 
            // baseRightpanel
            // 
            this.baseRightpanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.baseRightpanel.Controls.Add(this.maskedEditPanel);
            this.baseRightpanel.Controls.Add(this.inputPanel);
            this.baseRightpanel.Controls.Add(this.upDownPanel);
            this.baseRightpanel.Controls.Add(this.textBoxPanel);
            this.baseRightpanel.Location = new System.Drawing.Point(258, 53);
            this.baseRightpanel.Name = "baseRightpanel";
            this.baseRightpanel.Size = new System.Drawing.Size(1350, 880);
            this.baseRightpanel.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(8, 22);
            this.BackColor = System.Drawing.Color.White;
            this.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.ClientSize = new System.Drawing.Size(1609, 940);
            this.Controls.Add(this.treeViewAdv1);
            this.Controls.Add(this.label31);
            this.Controls.Add(this.comboBoxAdv3);
            this.Controls.Add(this.gradientLabel1);
            this.Controls.Add(this.baseRightpanel);
            this.DropShadow = true;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1621, 987);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editor";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.currencyTextBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.integerTextBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxAdv1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxAdv2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputPanel)).EndInit();
            this.inputPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel11)).EndInit();
            this.gradientPanel11.ResumeLayout(false);
            this.gradientPanel11.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownExt8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bannerClr)).EndInit();
            this.bannerClr.ResumeLayout(false);
            this.bannerClr.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxExt6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbMode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBnr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox20)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NegativeColorEdit)).EndInit();
            this.NegativeColorEdit.ResumeLayout(false);
            this.NegativeColorEdit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioButton6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonEdit1)).EndInit();
            this.buttonEdit1.ResumeLayout(false);
            this.buttonEdit1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radioButton7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PositiveColorEdit)).EndInit();
            this.PositiveColorEdit.ResumeLayout(false);
            this.PositiveColorEdit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel9)).EndInit();
            this.gradientPanel9.ResumeLayout(false);
            this.gradientPanel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel12)).EndInit();
            this.gradientPanel12.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel7)).EndInit();
            this.gradientPanel7.ResumeLayout(false);
            this.gradientPanel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.integerTextBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel10)).EndInit();
            this.gradientPanel10.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownExt1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownExt3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel5)).EndInit();
            this.gradientPanel5.ResumeLayout(false);
            this.gradientPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.percentTextBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel8)).EndInit();
            this.gradientPanel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.textBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownExt5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.integerTextBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownExt4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel1)).EndInit();
            this.gradientPanel1.ResumeLayout(false);
            this.gradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.doubleTextBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel6)).EndInit();
            this.gradientPanel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.textBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.integerTextBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownExt2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxPanel)).EndInit();
            this.textBoxPanel.ResumeLayout(false);
            this.textBoxPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox32)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox31)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownExt6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bannerClrEdit)).EndInit();
            this.bannerClrEdit.ResumeLayout(false);
            this.bannerClrEdit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxExt5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdoFocus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdoEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBanner)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxExt4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox22)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonEdit2)).EndInit();
            this.buttonEdit2.ResumeLayout(false);
            this.buttonEdit2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxExt3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox23)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBox12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox24)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox25)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox26)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioButton11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioButton10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maskedEditPanel)).EndInit();
            this.maskedEditPanel.ResumeLayout(false);
            this.maskedEditPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkPullCharOnDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownExt9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBox18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox29)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBox16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox30)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBox17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBox15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonEdit3)).EndInit();
            this.buttonEdit3.ResumeLayout(false);
            this.buttonEdit3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxExt2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioButton8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonEdit4)).EndInit();
            this.buttonEdit4.ResumeLayout(false);
            this.buttonEdit4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radioButton9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonEdit5)).EndInit();
            this.buttonEdit5.ResumeLayout(false);
            this.buttonEdit5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxExt1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBox14)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maskedEditBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.upDownPanel)).EndInit();
            this.upDownPanel.ResumeLayout(false);
            this.upDownPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboMode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bEditBanner)).EndInit();
            this.bEditBanner.ResumeLayout(false);
            this.bEditBanner.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxExt7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBanner)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBox19)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioButton2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioButton1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownExt7)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DomainBorderColorEdit)).EndInit();
            this.DomainBorderColorEdit.ResumeLayout(false);
            this.DomainBorderColorEdit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox19)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBox3)).EndInit();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.currencyEdit1.TextBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.currencyEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radWinStd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radFinancial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboButtonType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox28)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox27)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBox13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel4)).EndInit();
            this.gradientPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.editableList2.TextBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel3)).EndInit();
            this.gradientPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.editableList1.TextBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeViewAdv1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxAdv3)).EndInit();
            this.baseRightpanel.ResumeLayout(false);
            this.baseRightpanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        #region Main
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            SyncfusionLicenseProvider.RegisterLicense(DemoCommon.FindLicenseKey());
            Application.Run(new Form1());
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
                    return File.ReadAllText(licenseKeyFile);
                }
                return string.Empty;
            }
        }

        #endregion



        #region Form Load
        private void Form1_Load(object sender, System.EventArgs e)
        {
            //Currency TextBox
            PopulateCultures();
            this.comboBoxAdv1.SelectedIndex = 0;
            //Syncfusion.Windows.Forms.WinFormsUtils.UpdateDirectoryPath(this.oleDbConnection1, "Data", "CurrencyDataBinding.mdb");
            string mdbFile = Application.StartupPath + @" \..\..\..\..\..\..\..\..\..\Common\Data\CurrencyDataBinding.mdb";

            this.comboBoxAdv3.SelectedIndex = 7;

            // Database connection string
            this.oleDbConnection1.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + mdbFile;

            //CurrencyEdit
            // Load all Specific Cultures to the Combo Box
            foreach (CultureInfo info in CultureInfo.GetCultures(CultureTypes.SpecificCultures))
            {
                comboBox1.Items.Add(info.DisplayName);
                comboBox2.Items.Add(info.Name);
            }
            // Populate cboButtontype Combo Box with ButtonTypes
            string[] str = Enum.GetNames(typeof(ButtonTypes));
            cboButtonType.Items.AddRange(str);

            cboButtonType.SelectedIndex = 1;
            comboBox1.SelectedIndex = 64;

            //Populate DomainUpDown Border3DStyles
            string[] str1 = Enum.GetNames(typeof(Border3DStyle));
            comboBox3.Items.AddRange(str1);
            //Populate TextBoxes Border3DStyles
            comboBox6.Items.AddRange(str1);
            //Populate TextBoxExt Border3DStyles
            comboBox11.Items.AddRange(str1);
            //Populate MaskedEdit Border3DStyles
            comboBox7.Items.AddRange(str1);

            comboBox3.SelectedIndex = 0;
            comboBox4.SelectedIndex = 5;
            comboBox5.SelectedIndex = 5;
            comboBox6.SelectedIndex = 0;
            comboBox11.SelectedIndex = 0;
            comboBox10.SelectedIndex = 5;
            comboBox9.SelectedIndex = 0;
            comboBox8.SelectedIndex = 0;
            comboBox12.SelectedIndex = 0;
            comboBox15.SelectedIndex = 1;
            comboBox17.SelectedIndex = 0;
            comboBox16.SelectedIndex = 0;
            comboBox14.SelectedIndex = 5;

            comboBox1.SelectedItem = "English (Australia)";
            comboBox13.SelectedIndex = 0;
            this.treeViewAdv1.FullRowSelect = true;
            this.gradientLabel1.BorderAppearance = BorderStyle.FixedSingle;
            this.inputPanel.Visible = true;
            this.upDownPanel.Visible = false;
            this.maskedEditPanel.Visible = false;
            this.textBoxPanel.Visible = false;
            this.treeViewAdv1.SelectedNode = this.treeViewAdv1.Nodes[0];
            this.treeViewAdv1.Nodes[0].BaseStyle = "Style1";
            cmbMode.SelectedIndex = 0;
            comboMode.SelectedIndex = 0;
            Application.Idle += new EventHandler(Application_Idle);
            CreateDatatable();
        }

        #endregion

        #region TextBox

        #region TextBox Culture Settings
        private void PopulateCultures()
        {
            comboBoxAdv2.Items.Add("(Default)");
            comboBoxAdv2.Items.Add("(UICulture)");
            comboBoxAdv2.Items.Add("(InstalledUICulture)");
            foreach (CultureInfo c in CultureInfo.GetCultures(CultureTypes.SpecificCultures))
            {
                comboBoxAdv2.Items.Add(c.Name);
            }

            this.comboBoxAdv2.SelectedIndex = 0;
        }

        private void comboBoxAdv2_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            string selected = this.comboBoxAdv2.SelectedItem.ToString();

            if (selected.Equals("(Default)"))
            {
                this.currencyTextBox1.SpecialCultureValue = SpecialCultureValues.CurrentCulture;
                this.doubleTextBox1.SpecialCultureValue = SpecialCultureValues.CurrentCulture;
                this.integerTextBox2.SpecialCultureValue = SpecialCultureValues.CurrentCulture;
                this.percentTextBox1.SpecialCultureValue = SpecialCultureValues.CurrentCulture;
                this.currencyTextBox1.Culture = new CultureInfo(CultureInfo.CurrentCulture.LCID, this.currencyTextBox1.UseUserOverride);
                this.doubleTextBox1.Culture = new CultureInfo(CultureInfo.CurrentCulture.LCID, this.doubleTextBox1.UseUserOverride);
                this.integerTextBox2.Culture = new CultureInfo(CultureInfo.CurrentCulture.LCID, this.integerTextBox2.UseUserOverride);
                this.percentTextBox1.Culture = new CultureInfo(CultureInfo.CurrentCulture.LCID, this.percentTextBox1.UseUserOverride);
            }
            else if (selected.Equals("(UICulture)"))
            {
                this.currencyTextBox1.SpecialCultureValue = SpecialCultureValues.UICulture;
                this.doubleTextBox1.SpecialCultureValue = SpecialCultureValues.UICulture;
                this.integerTextBox2.SpecialCultureValue = SpecialCultureValues.UICulture;
                this.percentTextBox1.SpecialCultureValue = SpecialCultureValues.UICulture;
                this.currencyTextBox1.Culture = new CultureInfo(CultureInfo.CurrentUICulture.LCID, this.currencyTextBox1.UseUserOverride);
                this.doubleTextBox1.Culture = new CultureInfo(CultureInfo.CurrentUICulture.LCID, this.doubleTextBox1.UseUserOverride);
                this.integerTextBox2.Culture = new CultureInfo(CultureInfo.CurrentUICulture.LCID, this.integerTextBox2.UseUserOverride);
                this.percentTextBox1.Culture = new CultureInfo(CultureInfo.CurrentUICulture.LCID, this.percentTextBox1.UseUserOverride);

            }
            else if (selected.Equals("(InstalledUICulture)"))
            {
                this.currencyTextBox1.SpecialCultureValue = SpecialCultureValues.InstalledCulture;
                this.doubleTextBox1.SpecialCultureValue = SpecialCultureValues.InstalledCulture;
                this.integerTextBox2.SpecialCultureValue = SpecialCultureValues.InstalledCulture;
                this.percentTextBox1.SpecialCultureValue = SpecialCultureValues.InstalledCulture;
                this.currencyTextBox1.Culture = new CultureInfo(CultureInfo.InstalledUICulture.LCID, this.currencyTextBox1.UseUserOverride);
                this.doubleTextBox1.Culture = new CultureInfo(CultureInfo.InstalledUICulture.LCID, this.doubleTextBox1.UseUserOverride);
                this.integerTextBox2.Culture = new CultureInfo(CultureInfo.InstalledUICulture.LCID, this.integerTextBox2.UseUserOverride);
                this.percentTextBox1.Culture = new CultureInfo(CultureInfo.InstalledUICulture.LCID, this.percentTextBox1.UseUserOverride);

            }
            else
            {

                this.currencyTextBox1.SpecialCultureValue = SpecialCultureValues.None;
                this.doubleTextBox1.SpecialCultureValue = SpecialCultureValues.None;
                this.integerTextBox2.SpecialCultureValue = SpecialCultureValues.None;
                this.percentTextBox1.SpecialCultureValue = SpecialCultureValues.None;
                this.currencyTextBox1.Culture = new CultureInfo(selected, this.currencyTextBox1.UseUserOverride);
                this.doubleTextBox1.Culture = new CultureInfo(selected, this.doubleTextBox1.UseUserOverride);
                this.integerTextBox2.Culture = new CultureInfo(selected, this.integerTextBox2.UseUserOverride);
                this.percentTextBox1.Culture = new CultureInfo(selected, this.percentTextBox1.UseUserOverride);

            }

            this.currencyTextBox1.Text = this.currencyTextBox1.Text;
        }
        #endregion

        #region TextBox DataBinding
        //Databinding
        private void checkBox2_CheckedChanged(object sender, System.EventArgs e)
        {
            if (this.checkBox2.Checked == true)
            {
                this.currencyTextBox1.DataBindings.Add("Text", Dt, "Amount");
                this.doubleTextBox1.DataBindings.Add("Text", Dt, "Amount");
                this.integerTextBox2.DataBindings.Add("Text", Dt, "Amount");


                this.dataGrid1.DataSource = Dt;
            }
            else
            {
                this.currencyTextBox1.DataBindings.Clear();
                this.doubleTextBox1.DataBindings.Clear();
                this.integerTextBox2.DataBindings.Clear();
                this.currencyTextBox1.Text = "1";
                this.dataGrid1.DataSource = null;
            }
        }
        public void CreateDatatable()
        {
            Dt = new DataTable();
            DataColumn column1 = new DataColumn("ID", typeof(int));
            DataColumn column2 = new DataColumn("PurchaseDate", typeof(DateTime));
            DataColumn column3 = new DataColumn("Amount", typeof(int));
            //DataColumn[] cols=new DataColumn[]  {column1,column2,column3};
            Dt.Columns.Add(column1);
            Dt.Columns.Add(column2);
            Dt.Columns.Add(column3);

            Dt.Rows.Add("1", "12/1/2004", 21);
            Dt.Rows.Add("2", "11/5/2004", 33);
            Dt.Rows.Add("3", "8/4/2005", 4434);
            Dt.Rows.Add("4", "5/7/2006", 4555);
            Dt.Rows.Add("5", "12/6/2007", 3466);


        }
        #endregion

        #region TextBox Text Colors
        //Positive color
        private void PositiveColorEdit_ButtonClicked(object sender, ButtonClickedEventArgs args)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                PositiveColorEdit.BackColor = colorDialog1.Color;
                this.currencyTextBox1.PositiveColor = colorDialog1.Color;
                this.doubleTextBox1.PositiveColor = colorDialog1.Color;
                this.integerTextBox2.PositiveColor = colorDialog1.Color;
                this.percentTextBox1.PositiveColor = colorDialog1.Color;

            }

        }
        //Negative color
        private void NegativeColorEdit_ButtonClicked(object sender, ButtonClickedEventArgs args)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                NegativeColorEdit.BackColor = colorDialog1.Color;
                this.currencyTextBox1.NegativeColor = colorDialog1.Color;
                this.doubleTextBox1.NegativeColor = colorDialog1.Color;
                this.integerTextBox2.NegativeColor = colorDialog1.Color;
                this.percentTextBox1.NegativeColor = colorDialog1.Color;
            }
        }
        #endregion

        #region TextBox BorderStyle
        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioButton7.Checked)
            {
                this.currencyTextBox1.BorderStyle = BorderStyle.FixedSingle;
                this.doubleTextBox1.BorderStyle = BorderStyle.FixedSingle;
                this.integerTextBox2.BorderStyle = BorderStyle.FixedSingle;
                this.percentTextBox1.BorderStyle = BorderStyle.FixedSingle;
                this.comboBox6.Enabled = false;
            }
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioButton6.Checked)
            {
                this.numericUpDownExt8.Value = 0;
                this.currencyTextBox1.CornerRadius = 0;
                this.doubleTextBox1.CornerRadius = 0;
                this.integerTextBox2.CornerRadius = 0;
                this.percentTextBox1.CornerRadius = 0;
                this.currencyTextBox1.BorderStyle = BorderStyle.Fixed3D;
                this.doubleTextBox1.BorderStyle = BorderStyle.Fixed3D;
                this.integerTextBox2.BorderStyle = BorderStyle.Fixed3D;
                this.percentTextBox1.BorderStyle = BorderStyle.Fixed3D;
                this.comboBox6.Enabled = true;
            }
        }
        #endregion

        #region TextBox Controls Border3DStyle
        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.checkBox1.Checked = false;
            switch (comboBox6.Items[comboBox6.SelectedIndex].ToString())
            {
                case "RaisedOuter":
                    this.currencyTextBox1.Border3DStyle = Border3DStyle.RaisedOuter;
                    this.doubleTextBox1.Border3DStyle = Border3DStyle.RaisedOuter;
                    this.integerTextBox2.Border3DStyle = Border3DStyle.RaisedOuter;
                    this.percentTextBox1.Border3DStyle = Border3DStyle.RaisedOuter;

                    break;
                case "Adjust":
                    this.currencyTextBox1.Border3DStyle = Border3DStyle.Adjust;
                    this.doubleTextBox1.Border3DStyle = Border3DStyle.Adjust;
                    this.integerTextBox2.Border3DStyle = Border3DStyle.Adjust;
                    this.percentTextBox1.Border3DStyle = Border3DStyle.Adjust;
                    break;
                case "Bump":
                    this.currencyTextBox1.Border3DStyle = Border3DStyle.Bump;
                    this.doubleTextBox1.Border3DStyle = Border3DStyle.Bump;
                    this.integerTextBox2.Border3DStyle = Border3DStyle.Bump;
                    this.percentTextBox1.Border3DStyle = Border3DStyle.Bump;

                    break;
                case "Etched":

                    this.currencyTextBox1.Border3DStyle = Border3DStyle.Etched;
                    this.doubleTextBox1.Border3DStyle = Border3DStyle.Etched;
                    this.integerTextBox2.Border3DStyle = Border3DStyle.Etched;
                    this.percentTextBox1.Border3DStyle = Border3DStyle.Etched;


                    break;
                case "Flat":
                    this.currencyTextBox1.Border3DStyle = Border3DStyle.Flat;
                    this.doubleTextBox1.Border3DStyle = Border3DStyle.Flat;
                    this.integerTextBox2.Border3DStyle = Border3DStyle.Flat;
                    this.percentTextBox1.Border3DStyle = Border3DStyle.Flat;


                    break;
                case "Raised":
                    this.currencyTextBox1.Border3DStyle = Border3DStyle.Raised;
                    this.doubleTextBox1.Border3DStyle = Border3DStyle.Raised;
                    this.integerTextBox2.Border3DStyle = Border3DStyle.Raised;
                    this.percentTextBox1.Border3DStyle = Border3DStyle.Raised;


                    break;
                case "RaisedInner":
                    this.currencyTextBox1.Border3DStyle = Border3DStyle.RaisedInner;
                    this.doubleTextBox1.Border3DStyle = Border3DStyle.RaisedInner;
                    this.integerTextBox2.Border3DStyle = Border3DStyle.RaisedInner;
                    this.percentTextBox1.Border3DStyle = Border3DStyle.RaisedInner;
                    break;
                case "Sunken":
                    this.currencyTextBox1.Border3DStyle = Border3DStyle.Sunken;
                    this.doubleTextBox1.Border3DStyle = Border3DStyle.Sunken;
                    this.integerTextBox2.Border3DStyle = Border3DStyle.Sunken;
                    this.percentTextBox1.Border3DStyle = Border3DStyle.Sunken;

                    break;
                case "SunkenInner":
                    this.currencyTextBox1.Border3DStyle = Border3DStyle.SunkenInner;
                    this.doubleTextBox1.Border3DStyle = Border3DStyle.SunkenInner;
                    this.integerTextBox2.Border3DStyle = Border3DStyle.SunkenInner;
                    this.percentTextBox1.Border3DStyle = Border3DStyle.SunkenInner;
                    break;
                case "SunkenOuter":
                    this.currencyTextBox1.Border3DStyle = Border3DStyle.SunkenOuter;
                    this.doubleTextBox1.Border3DStyle = Border3DStyle.SunkenOuter;
                    this.integerTextBox2.Border3DStyle = Border3DStyle.SunkenOuter;
                    this.percentTextBox1.Border3DStyle = Border3DStyle.SunkenOuter;

                    break;
            }
        }
        #endregion

        #region TextBox BorderColor
        private void buttonEdit1_ButtonClicked(object sender, ButtonClickedEventArgs args)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                this.radioButton7.Checked = true;
                this.buttonEdit1.BackColor = colorDialog1.Color;
                this.currencyTextBox1.Metrocolor = colorDialog1.Color;
                this.doubleTextBox1.Metrocolor = colorDialog1.Color;
                this.integerTextBox2.Metrocolor = colorDialog1.Color;
                this.percentTextBox1.Metrocolor = colorDialog1.Color;
            }
        }
        #endregion

        #region TextBox BorderSides
        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox5.Items[comboBox5.SelectedIndex].ToString())
            {
                case "Left":
                    this.currencyTextBox1.BorderSides = System.Windows.Forms.Border3DSide.Left;
                    this.doubleTextBox1.BorderSides = System.Windows.Forms.Border3DSide.Left;
                    this.integerTextBox2.BorderSides = System.Windows.Forms.Border3DSide.Left;
                    this.percentTextBox1.BorderSides = System.Windows.Forms.Border3DSide.Left;

                    break;
                case "Top":
                    this.currencyTextBox1.BorderSides = System.Windows.Forms.Border3DSide.Top;
                    this.doubleTextBox1.BorderSides = System.Windows.Forms.Border3DSide.Top;
                    this.integerTextBox2.BorderSides = System.Windows.Forms.Border3DSide.Top;
                    this.percentTextBox1.BorderSides = System.Windows.Forms.Border3DSide.Top;
                    break;
                case "Right":
                    this.currencyTextBox1.BorderSides = System.Windows.Forms.Border3DSide.Right;
                    this.doubleTextBox1.BorderSides = System.Windows.Forms.Border3DSide.Right;
                    this.integerTextBox2.BorderSides = System.Windows.Forms.Border3DSide.Right;
                    this.percentTextBox1.BorderSides = System.Windows.Forms.Border3DSide.Right;
                    break;
                case "Bottom":
                    this.currencyTextBox1.BorderSides = System.Windows.Forms.Border3DSide.Bottom;
                    this.doubleTextBox1.BorderSides = System.Windows.Forms.Border3DSide.Bottom;
                    this.integerTextBox2.BorderSides = System.Windows.Forms.Border3DSide.Bottom;
                    this.percentTextBox1.BorderSides = System.Windows.Forms.Border3DSide.Bottom;
                    break;
                case "Middle":
                    this.currencyTextBox1.BorderSides = System.Windows.Forms.Border3DSide.Middle;
                    this.doubleTextBox1.BorderSides = System.Windows.Forms.Border3DSide.Middle;
                    this.integerTextBox2.BorderSides = System.Windows.Forms.Border3DSide.Middle;
                    this.percentTextBox1.BorderSides = System.Windows.Forms.Border3DSide.Middle;
                    break;
                case "All":
                    this.currencyTextBox1.BorderSides = System.Windows.Forms.Border3DSide.All;
                    this.doubleTextBox1.BorderSides = System.Windows.Forms.Border3DSide.All;
                    this.integerTextBox2.BorderSides = System.Windows.Forms.Border3DSide.All;
                    this.percentTextBox1.BorderSides = System.Windows.Forms.Border3DSide.All;
                    break;

            }
        }
        #endregion

        #region TextBox TextAlignment
        private void comboBoxAdv1_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (this.comboBoxAdv1.Text == "Left")
            {
                this.currencyTextBox1.TextAlign = HorizontalAlignment.Left;
                this.doubleTextBox1.TextAlign = HorizontalAlignment.Left;
                this.integerTextBox2.TextAlign = HorizontalAlignment.Left;
                this.percentTextBox1.TextAlign = HorizontalAlignment.Left;
            }
            else if (this.comboBoxAdv1.Text == "Right")
            {
                this.currencyTextBox1.TextAlign = HorizontalAlignment.Right;
                this.doubleTextBox1.TextAlign = HorizontalAlignment.Right;
                this.integerTextBox2.TextAlign = HorizontalAlignment.Right;
                this.percentTextBox1.TextAlign = HorizontalAlignment.Right;
            }
            else
            {
                this.currencyTextBox1.TextAlign = HorizontalAlignment.Center;
                this.doubleTextBox1.TextAlign = HorizontalAlignment.Center;
                this.integerTextBox2.TextAlign = HorizontalAlignment.Center;
                this.percentTextBox1.TextAlign = HorizontalAlignment.Center;
            }
        }
        #endregion

        #region TextBox ThemesEnabled
        private void checkBox1_CheckedChanged(object sender, System.EventArgs e)
        {
            this.currencyTextBox1.ThemesEnabled = this.checkBox1.Checked;
            this.doubleTextBox1.ThemesEnabled = this.checkBox1.Checked;
            this.integerTextBox2.ThemesEnabled = this.checkBox1.Checked;
            this.percentTextBox1.ThemesEnabled = this.checkBox1.Checked;
        }
        #endregion

        #region TextBox ShowOverFlowIndicator
        private void checkBox16_CheckedChanged(object sender, EventArgs e)
        {
            this.currencyTextBox1.ShowOverflowIndicator = this.checkBox16.Checked;
            this.doubleTextBox1.ShowOverflowIndicator = this.checkBox16.Checked;
            this.integerTextBox2.ShowOverflowIndicator = this.checkBox16.Checked;
            this.percentTextBox1.ShowOverflowIndicator = this.checkBox16.Checked;
        }
        #endregion

        #region TextBox ShowOverFlowIndicatorToolTip
        private void checkBox20_CheckedChanged(object sender, EventArgs e)
        {
            this.currencyTextBox1.ShowOverflowIndicatorToolTip = this.checkBox20.Checked;
            this.doubleTextBox1.ShowOverflowIndicatorToolTip = this.checkBox20.Checked;
            this.integerTextBox2.ShowOverflowIndicatorToolTip = this.checkBox20.Checked;
            this.percentTextBox1.ShowOverflowIndicatorToolTip = this.checkBox20.Checked;

        }
        #endregion

        #region Properties

        #region Currency TextBox Properties
        //To set the currency symbol of the Currency TextBox
        private void textBox1_TextChanged(object sender, System.EventArgs e)
        {
            if (ValidateText(textBox1.Text))
            {
                try
                {
                    this.currencyTextBox1.CurrencySymbol = this.textBox1.Text;
                }
                catch (Exception e1)
                {
                    MessageBox.Show(e1.Message);
                    this.textBox1.Text = "$";
                }
            }
            else
            {
                MessageBox.Show("Enter only special characters", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Text = string.Empty;
            }
        }

        //To set the CurrencyDecimalDigits of the IntegerTextBox
        private void integerTextbox1_IntegerValueChanged(object sender, System.EventArgs e)
        {
            try
            {
                this.currencyTextBox1.CurrencyDecimalDigits = (int)(this.integerTextBox1.IntegerValue);
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Values between 0 to 99 are only allowed", "Incorrect Value");
                this.integerTextBox1.IntegerValue = 1;
            }
        }
        #endregion

        #region DoubleTextBox
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (ValidateText(textBox2.Text))
            {
                if (this.textBox2.Text != "")
                {
                    this.doubleTextBox1.NumberDecimalSeparator = this.textBox2.Text;
                }
            }
            else
            {
                MessageBox.Show("Enter only special characters", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox2.Text = string.Empty;
            }

        }

        private void integerTextBox3_TextChanged(object sender, EventArgs e)
        {
            int decimalValue = Convert.ToInt16(this.integerTextBox3.Text);
            if (decimalValue > 0 & decimalValue < 99)
                this.doubleTextBox1.NumberDecimalDigits = Convert.ToInt16(this.integerTextBox3.Text);
            else
                this.integerTextBox3.Text = "0";
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            int result;
            if (ValidateText(textBox3.Text))
            {
                if (int.TryParse(textBox3.Text, out result))
                {
                    textBox3.Text = String.Empty;
                }
                this.doubleTextBox1.NumberGroupSeparator = this.textBox3.Text;
            }
            else
            {
                MessageBox.Show("Enter only special characters", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox3.Text = string.Empty;
            }
        }


        private void numericUpDownExt2_ValueChanged(object sender, EventArgs e)
        {
            int x = Convert.ToInt16(this.numericUpDownExt2.Value);
            this.doubleTextBox1.NumberGroupSizes = new int[] { x };
        }

        #endregion

        #region PercentTextBox
        //To set the Percent Value of the PercentTextBox
        private void numericUpDownExt5_ValueChanged(object sender, EventArgs e)
        {
            double x = Convert.ToDouble(this.numericUpDownExt5.Value);
            this.percentTextBox1.PercentValue = x;
        }

        //To set the Decimal Separator of PercentTextBox
        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            if (ValidateText(textBox6.Text))
            {
                if (this.textBox6.Text != "")
                {
                    this.percentTextBox1.PercentDecimalSeparator = this.textBox6.Text;
                }
            }
            else
            {
                MessageBox.Show("Enter only special characters", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox6.Text = string.Empty;
            }
        }
        //To set the Decimal Digits of PercentTextBox
        private void integerTextBox7_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.percentTextBox1.PercentDecimalDigits = Convert.ToInt16(this.integerTextBox7.Text);
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Values between 0 to 99 are only allowed");
                this.integerTextBox7.IntegerValue = 1;
            }
        }



        //To set the PercentPositivePattern  of PercentTextBox
        private void numericUpDownExt4_ValueChanged(object sender, EventArgs e)
        {
            int x = Convert.ToInt16(this.numericUpDownExt4.Value);

            this.percentTextBox1.PercentPositivePattern = x;
        }

        #endregion

        #region IntegerTextBox properties
        //To set the NumberNegativePattern of IntegerTextBox
        private void numericUpDownExt1_ValueChanged(object sender, EventArgs e)
        {
            int x = Convert.ToInt16(this.numericUpDownExt1.Value);

            this.integerTextBox2.NumberNegativePattern = x;

        }

        private bool ValidateText(string str)
        {
            bool valid = false;
            if (!Regex.IsMatch(str, "[0-9a-zA-Z]"))
                valid = true;
            return valid;
        }
        //To set the NumberGroupSeparator of IntegerTextBox
        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            int result;
            if (ValidateText(textBox4.Text))
            {
                if (int.TryParse(textBox4.Text, out result))
                {
                    textBox4.Text = String.Empty;
                }
                if (this.textBox4.Text != "")
                {
                    this.integerTextBox2.NumberGroupSeparator = this.textBox4.Text;
                }
            }
            else
            {
                MessageBox.Show("Enter only special characters", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox4.Text = string.Empty;
            }
        }

        //To set the NumberGroupSizes of IntegerTextBox
        private void numericUpDownExt3_ValueChanged(object sender, EventArgs e)
        {
            int x = Convert.ToInt16(this.numericUpDownExt3.Value);
            this.integerTextBox2.NumberGroupSizes = new int[] { x };

        }




        #endregion

        #endregion

        #endregion

        #region Currency Edit

        #region Culture Settings
        private void comboBox1_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            comboBox2.SelectedIndex = comboBox1.SelectedIndex;
        }

        private void comboBox2_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            comboBox1.SelectedIndex = comboBox2.SelectedIndex;
            string culture = comboBox2.Items[comboBox2.SelectedIndex].ToString();
            System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(culture);
            currencyEdit1.TextBox.SpecialCultureValue = SpecialCultureValues.UICulture;
            currencyEdit1.TextBox.Culture = new System.Globalization.CultureInfo(culture);
        }
        #endregion

        #region Calculator Type
        private void radWinStd_CheckedChanged(object sender, EventArgs e)
        {
            if (radWinStd.Checked == true)
                currencyEdit1.CalculatorLayoutType = CalculatorLayoutTypes.WindowsStandard;

        }

        private void radFinancial_CheckedChanged(object sender, EventArgs e)
        {
            if (radFinancial.Checked == true)
                currencyEdit1.CalculatorLayoutType = CalculatorLayoutTypes.Financial;

        }
        #endregion

        private void checkBox12_CheckedChanged(object sender, EventArgs e)
        {
            this.currencyEdit1.Text = "0";
            this.currencyEdit1.ShowCalculator = this.checkBox12.Checked;

        }

        private void currencyEdit1_CalculatorShowing(object sender, CancelEventArgs e)
        {
            currencyEdit1.CalcPopup.Calculator.UseVerticalAndHorizontalSpacing = true;
            currencyEdit1.CalcPopup.Calculator.HorizontalSpacing = 1;
            currencyEdit1.CalcPopup.Calculator.VerticalSpacing = 0;

        }


        private void checkBox17_CheckedChanged(object sender, EventArgs e)
        {
            this.currencyEdit1.TransferFromCalculator = this.checkBox17.Checked;
        }

        private void checkBox18_CheckedChanged(object sender, EventArgs e)
        {
            this.currencyEdit1.TransferToCalculator = this.checkBox18.Checked;

        }


        #region Set Button Style

        private void ButtonStyle_CheckedChanged(object sender, System.EventArgs e)
        {
            //if (sender == radClassic)
            //{

            //    currencyEdit1.ButtonStyle = ButtonAppearance.Classic;
            //    currencyEdit1.CalcPopup.Calculator.ButtonStyle = ButtonAppearance.Classic;
            //}
            //else if (sender == radOffice2000)
            //{

            //    currencyEdit1.ButtonStyle = ButtonAppearance.Office2000;
            //    currencyEdit1.CalcPopup.Calculator.ButtonStyle = ButtonAppearance.Office2000;
            //}
            //else if (sender == radOffice2003)
            //{

            //    currencyEdit1.ButtonStyle = ButtonAppearance.Office2003;
            //    currencyEdit1.CalcPopup.Calculator.ButtonStyle = ButtonAppearance.Office2003;
            //}
            //else if (sender == radOffice2007)
            //{

            //    currencyEdit1.ButtonStyle = ButtonAppearance.Office2007;
            //    currencyEdit1.FlatStyle = FlatStyle.Flat;
            //    currencyEdit1.Border3DStyle = Border3DStyle.Flat;
            //    currencyEdit1.CalcPopup.Calculator.ButtonStyle = ButtonAppearance.Office2007;
            //}
            //else if (sender == radOfficeXP)
            //{

            //    currencyEdit1.ButtonStyle = ButtonAppearance.OfficeXP;
            //    currencyEdit1.CalcPopup.Calculator.ButtonStyle = ButtonAppearance.OfficeXP;
            //}
            //else if (sender == radWinXP)
            //{

            //    currencyEdit1.ButtonStyle = ButtonAppearance.WindowsXP;
            //    currencyEdit1.CalcPopup.Calculator.ButtonStyle = ButtonAppearance.WindowsXP;
            //}
            //else if (sender == radioButtonAdv1)
            //{
            //    currencyEdit1.ButtonStyle = ButtonAppearance.Metro;
            //    currencyEdit1.CalcPopup.Calculator.ButtonStyle = ButtonAppearance.Metro;
            //}
        }

        #endregion

        #region Currency Edit Button Type
        private void cboButtonType_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cboButtonType.Items[cboButtonType.SelectedIndex].ToString())
            {
                case "Browse":
                    currencyEdit1.CalculatorButton.ButtonType = ButtonTypes.Browse;
                    break;
                case "Calculator":
                    currencyEdit1.CalculatorButton.ButtonType = ButtonTypes.Calculator;
                    break;
                case "Check":
                    currencyEdit1.CalculatorButton.ButtonType = ButtonTypes.Check;
                    break;
                case "ComboXPDown":
                    currencyEdit1.CalculatorButton.ButtonType = ButtonTypes.ComboXPDown;
                    break;
                case "Currency":
                    currencyEdit1.CalculatorButton.ButtonType = ButtonTypes.Currency;
                    break;
                case "Down":
                    currencyEdit1.CalculatorButton.ButtonType = ButtonTypes.Down;
                    break;
                case "Left":
                    currencyEdit1.CalculatorButton.ButtonType = ButtonTypes.Left;
                    break;
                case "LeftEnd":
                    currencyEdit1.CalculatorButton.ButtonType = ButtonTypes.LeftEnd;
                    break;
                case "Normal":
                    currencyEdit1.CalculatorButton.ButtonType = ButtonTypes.Normal;
                    break;
                case "Redo":
                    currencyEdit1.CalculatorButton.ButtonType = ButtonTypes.Redo;
                    break;
                case "Right":
                    currencyEdit1.CalculatorButton.ButtonType = ButtonTypes.Right;
                    break;
                case "RightEnd":
                    currencyEdit1.CalculatorButton.ButtonType = ButtonTypes.RightEnd;
                    break;
                case "Undo":
                    currencyEdit1.CalculatorButton.ButtonType = ButtonTypes.Undo;
                    break;
                case "Up":
                    currencyEdit1.CalculatorButton.ButtonType = ButtonTypes.Up;
                    break;
            }
        }
        #endregion

        #region ReadOnly
        private void checkBox13_CheckedChanged(object sender, EventArgs e)
        {
            this.currencyEdit1.TextBox.ReadOnly = checkBox13.Checked;
            this.currencyEdit1.CalculatorButton.Enabled = !checkBox13.Checked;
        }
        #endregion

        #endregion

        #region DomainUpDownExt

        #region Border3DStyle
        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox3.Items[comboBox3.SelectedIndex].ToString())
            {
                case "RaisedOuter":
                    this.domainUpDownExt1.Border3DStyle = Border3DStyle.RaisedOuter;
                    this.numericUpDownExt7.Border3DStyle = Border3DStyle.RaisedOuter;
                    break;
                case "Adjust":
                    this.domainUpDownExt1.Border3DStyle = Border3DStyle.Adjust;
                    this.numericUpDownExt7.Border3DStyle = Border3DStyle.Adjust;
                    break;
                case "Bump":
                    this.domainUpDownExt1.Border3DStyle = Border3DStyle.Bump;
                    this.numericUpDownExt7.Border3DStyle = Border3DStyle.Bump;
                    break;
                case "Etched":
                    this.domainUpDownExt1.Border3DStyle = Border3DStyle.Etched;
                    this.numericUpDownExt7.Border3DStyle = Border3DStyle.Etched;
                    break;
                case "Flat":
                    this.domainUpDownExt1.Border3DStyle = Border3DStyle.Flat;
                    this.numericUpDownExt7.Border3DStyle = Border3DStyle.Flat;
                    break;
                case "Raised":
                    this.domainUpDownExt1.Border3DStyle = Border3DStyle.Raised;
                    this.numericUpDownExt7.Border3DStyle = Border3DStyle.Raised;
                    break;
                case "RaisedInner":
                    this.domainUpDownExt1.Border3DStyle = Border3DStyle.RaisedInner;
                    this.numericUpDownExt7.Border3DStyle = Border3DStyle.RaisedOuter;
                    break;
                case "Sunken":
                    this.domainUpDownExt1.Border3DStyle = Border3DStyle.Sunken;
                    this.numericUpDownExt7.Border3DStyle = Border3DStyle.Sunken;
                    break;
                case "SunkenInner":
                    this.domainUpDownExt1.Border3DStyle = Border3DStyle.SunkenInner;
                    this.numericUpDownExt7.Border3DStyle = Border3DStyle.SunkenInner;
                    break;
                case "SunkenOuter":
                    this.domainUpDownExt1.Border3DStyle = Border3DStyle.SunkenOuter;
                    this.numericUpDownExt7.Border3DStyle = Border3DStyle.SunkenOuter;
                    break;
            }
        }
        #endregion

        #region BorderSides

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox4.Items[comboBox4.SelectedIndex].ToString())
            {
                case "Left":
                    this.domainUpDownExt1.BorderSides = System.Windows.Forms.Border3DSide.Left;
                    this.numericUpDownExt7.BorderSides = System.Windows.Forms.Border3DSide.Left;
                    break;
                case "Top":
                    this.domainUpDownExt1.BorderSides = System.Windows.Forms.Border3DSide.Top;
                    this.numericUpDownExt7.BorderSides = System.Windows.Forms.Border3DSide.Top;
                    break;
                case "Right":
                    this.domainUpDownExt1.BorderSides = System.Windows.Forms.Border3DSide.Right;
                    this.numericUpDownExt7.BorderSides = System.Windows.Forms.Border3DSide.Right;
                    break;
                case "Bottom":
                    this.domainUpDownExt1.BorderSides = System.Windows.Forms.Border3DSide.Bottom;
                    this.numericUpDownExt7.BorderSides = System.Windows.Forms.Border3DSide.Bottom;
                    break;
                case "Middle":
                    this.domainUpDownExt1.BorderSides = System.Windows.Forms.Border3DSide.Middle;
                    this.numericUpDownExt7.BorderSides = System.Windows.Forms.Border3DSide.Middle;
                    break;
                case "All":
                    this.domainUpDownExt1.BorderSides = System.Windows.Forms.Border3DSide.All;
                    this.numericUpDownExt7.BorderSides = System.Windows.Forms.Border3DSide.All;
                    break;

            }


        }
        #endregion

        #region BorderColor
        private void DomainBorderColorEdit_ButtonClicked(object sender, ButtonClickedEventArgs args)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                this.radioButton1.Checked = true;
                this.domainUpDownExt1.BorderStyle = BorderStyle.FixedSingle;
                DomainBorderColorEdit.BackColor = colorDialog1.Color;
                this.domainUpDownExt1.BorderColor = colorDialog1.Color;
                this.numericUpDownExt7.BorderColor = colorDialog1.Color;
            }
        }
        #endregion

        #region UpDownExt BorderStyle
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioButton1.Checked)
            {
                this.domainUpDownExt1.BorderStyle = BorderStyle.FixedSingle;
                this.numericUpDownExt7.BorderStyle = BorderStyle.FixedSingle;
                this.comboBox3.Enabled = false;
                this.comboBox4.Enabled = true;
                DomainBorderColorEdit.Enabled = true;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioButton2.Checked)
            {
                this.domainUpDownExt1.BorderStyle = BorderStyle.Fixed3D;
                this.numericUpDownExt7.BorderStyle = BorderStyle.Fixed3D;
                this.comboBox3.Enabled = true;
                this.comboBox4.Enabled = true;
                DomainBorderColorEdit.Enabled = false;
            }
        }
        #endregion

        #region UpDownExt Themes Enabled

        private void checkBox14_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBox14.Checked)
            {
                this.comboBox3.Enabled = false;
                this.comboBox4.Enabled = false;
                DomainBorderColorEdit.Enabled = false;
                this.radioButton1.Enabled = false;
                this.radioButton2.Enabled = false;
                this.domainUpDownExt1.ThemesEnabled = true;
                this.domainUpDownExt1.ThemedBorder = true;
                this.numericUpDownExt7.ThemesEnabled = true;
            }
            else
            {
                this.comboBox3.Enabled = true;
                this.comboBox4.Enabled = true;
                DomainBorderColorEdit.Enabled = true;
                this.radioButton1.Enabled = true;
                this.radioButton2.Enabled = true;
                this.domainUpDownExt1.ThemedBorder = false;
                this.domainUpDownExt1.ThemesEnabled = false;
                this.numericUpDownExt7.ThemesEnabled = false;
            }
        }
        #endregion

        #region UpDownExt InterceptArrowKeys
        private void checkBox15_CheckedChanged(object sender, EventArgs e)
        {
            Console.WriteLine(this.checkBox15.Checked);
            this.domainUpDownExt1.InterceptArrowKeys = this.checkBox15.Checked;
            this.numericUpDownExt7.InterceptArrowKeys = this.checkBox15.Checked;
        }
        #endregion

        #region UpDownExt Office2007Style
        private void OfficeStyle_CheckedChanged(object sender, EventArgs e)
        {
            //if (this.radioButton3.Checked)
            //{
            //    this.domainUpDownExt1.VisualStyle = VisualStyle.Office2007;
            //    this.domainUpDownExt1.ColorScheme = Office2007Theme.Blue;
            //    this.numericUpDownExt7.VisualStyle = VisualStyle.Office2007;
            //    this.numericUpDownExt7.ColorScheme = Office2007Theme.Blue;
            //}
            //if (this.radioButton4.Checked)
            //{
            //    this.domainUpDownExt1.VisualStyle = VisualStyle.Office2007;
            //    this.domainUpDownExt1.ColorScheme = Office2007Theme.Silver;
            //    this.numericUpDownExt7.VisualStyle = VisualStyle.Office2007;
            //    this.numericUpDownExt7.ColorScheme = Office2007Theme.Silver;
            //}
            //if (this.radioButton5.Checked)
            //{
            //    this.domainUpDownExt1.VisualStyle = VisualStyle.Office2007;
            //    this.domainUpDownExt1.ColorScheme = Office2007Theme.Black;
            //    this.numericUpDownExt7.VisualStyle = VisualStyle.Office2007;
            //    this.numericUpDownExt7.ColorScheme = Office2007Theme.Black;
            //}

            //if (this.radioButton12.Checked)
            //{
            //    this.domainUpDownExt1.VisualStyle = VisualStyle.Office2007;
            //    this.domainUpDownExt1.ColorScheme = Office2007Theme.Managed;
            //    this.numericUpDownExt7.VisualStyle = VisualStyle.Office2007;
            //    this.numericUpDownExt7.ColorScheme = Office2007Theme.Managed;
            //    Office2007Colors.ApplyManagedColors(this, Color.Orange);
            //}
        }
        #endregion

        #region UpDownExt DataBinding
        private void checkBox19_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBox19.Checked == true)
            {
                //this.domainUpDownExt1.DataBindings.Add("Text", this.dataSet11.Sales, "Amount");
                //this.numericUpDownExt7.DataBindings.Add("Text", this.dataSet11.Sales, "Amount");
                //this.oleDbDataAdapter1.Fill(this.dataSet11.Sales);
                //this.dataGrid2.DataSource = this.dataSet11.Sales;

                this.domainUpDownExt1.DataBindings.Add("Text", Dt, "Amount");
                this.numericUpDownExt7.DataBindings.Add("Text", Dt, "Amount");
                this.dataGrid2.DataSource = Dt;


            }
            else
            {
                this.domainUpDownExt1.DataBindings.Clear();
                this.numericUpDownExt7.DataBindings.Clear();
                this.dataGrid2.DataSource = null;
            }
        }
        #endregion

        #region DomainUpDownSpinOrientation

        private void UpdownExtSpinOrientation_Changed(object sender, EventArgs e)
        {
            this.domainUpDownExt1.SpinOrientation = (Orientation)Enum.Parse(typeof(Orientation), this.comboBox19.SelectedItem.ToString());
        }
        #endregion


        #endregion

        #region TextBoxExt


        #region TextBoxExt BorderStyle
        private void radioButton11_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioButton11.Checked)
            {
                this.textBoxExt4.BorderStyle = BorderStyle.FixedSingle;
                this.comboBox11.Enabled = false;
                this.buttonEditChildButton4.Enabled = true;
            }
        }

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioButton10.Checked)
            {
                this.textBoxExt4.CornerRadius = 0;
                this.numericUpDownExt6.Value = 0;
                this.textBoxExt4.BorderStyle = BorderStyle.Fixed3D;
                this.comboBox11.Enabled = true;
                this.buttonEditChildButton4.Enabled = false;
            }
        }
        #endregion

        #region TextBoxExt BorderSides
        private void comboBox10_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox10.Items[comboBox10.SelectedIndex].ToString())
            {
                case "Left":
                    this.textBoxExt4.BorderSides = System.Windows.Forms.Border3DSide.Left;
                    break;
                case "Top":
                    this.textBoxExt4.BorderSides = System.Windows.Forms.Border3DSide.Top;
                    break;
                case "Right":
                    this.textBoxExt4.BorderSides = System.Windows.Forms.Border3DSide.Right;
                    break;
                case "Bottom":
                    this.textBoxExt4.BorderSides = System.Windows.Forms.Border3DSide.Bottom;
                    break;
                case "Middle":
                    this.textBoxExt4.BorderSides = System.Windows.Forms.Border3DSide.Middle;
                    break;
                case "All":
                    this.textBoxExt4.BorderSides = System.Windows.Forms.Border3DSide.All;
                    break;

            }
        }
        #endregion

        #region TextBoxExt Border3DStyle
        private void comboBox11_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox11.Items[comboBox11.SelectedIndex].ToString())
            {
                case "RaisedOuter":
                    this.textBoxExt4.Border3DStyle = Border3DStyle.RaisedOuter;
                    break;
                case "Adjust":
                    this.textBoxExt4.Border3DStyle = Border3DStyle.Adjust;
                    break;
                case "Bump":
                    this.textBoxExt4.Border3DStyle = Border3DStyle.Bump;
                    break;
                case "Etched":
                    this.textBoxExt4.Border3DStyle = Border3DStyle.Etched;
                    break;
                case "Flat":
                    this.textBoxExt4.Border3DStyle = Border3DStyle.Flat;
                    break;
                case "Raised":
                    this.textBoxExt4.Border3DStyle = Border3DStyle.Raised;
                    break;
                case "RaisedInner":
                    this.textBoxExt4.Border3DStyle = Border3DStyle.RaisedInner;
                    break;
                case "Sunken":
                    this.textBoxExt4.Border3DStyle = Border3DStyle.Sunken;
                    break;
                case "SunkenInner":
                    this.textBoxExt4.Border3DStyle = Border3DStyle.SunkenInner;
                    break;
                case "SunkenOuter":
                    this.textBoxExt4.Border3DStyle = Border3DStyle.SunkenOuter;
                    break;
            }
        }
        #endregion

        #region TextBoxExt Character casing
        private void comboBox8_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox8.Items[comboBox8.SelectedIndex].ToString())
            {
                case "Normal":
                    this.textBoxExt4.CharacterCasing = CharacterCasing.Normal;
                    break;
                case "Upper Case":
                    this.textBoxExt4.CharacterCasing = CharacterCasing.Upper;
                    break;
                case "Lower Case":
                    this.textBoxExt4.CharacterCasing = CharacterCasing.Lower;
                    break;
            }
        }
        #endregion

        #region TextBoxExt TextAlign
        private void comboBox12_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox12.Items[comboBox12.SelectedIndex].ToString())
            {
                case "Left":
                    this.textBoxExt4.TextAlign = HorizontalAlignment.Left;
                    break;
                case "Right":
                    this.textBoxExt4.TextAlign = HorizontalAlignment.Right;
                    break;
                case "Center":
                    this.textBoxExt4.TextAlign = HorizontalAlignment.Center;
                    break;
            }
        }
        #endregion

        //To set as MultiLine
        private void checkBox25_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBox25.Checked)
            {
                this.textBoxExt4.Multiline = true;
                this.textBoxExt4.Text = "We are a leading provider of software components and tools for the Microsoft .NET platform. Powerful and feature-rich, Syncfusion�s broad range of products are vital to mission-critical applications in organizations ranging from small businesses to multinational Fortune 100 companies.  Syncfusion's mission is to produce world-class software components that enable developers to produce quality software for the most demanding of environments. Our innovative libraries are designed to be extensible to ensure maximum benefit to customers, and we provide full source code to enable seamless integration of our libraries with our customers' projects. We firmly believe that our success is closely tied to that of our customers. To help our customers succeed, we strive to offer technical support that is accessible, accurate, and fast.";
                this.textBoxExt4.Size = new Size(242, 77);
            }
            else
            {
                this.textBoxExt4.Multiline = false;
                this.textBoxExt4.Text = "TextBoxExt";
            }
        }

        //To make the TextBoxExt as readOnly
        private void checkBox24_CheckedChanged(object sender, EventArgs e)
        {
            this.textBoxExt4.ReadOnly = this.checkBox24.Checked;
        }

        //Right To Left
        private void checkBox23_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBox23.Checked)
            {

                this.textBoxExt4.RightToLeft = RightToLeft.Yes;
            }
            else
            {
                this.textBoxExt4.RightToLeft = RightToLeft.No;
            }
        }

        //To set Word Wrap
        private void checkBox22_CheckedChanged(object sender, EventArgs e)
        {
            this.textBoxExt4.WordWrap = this.checkBox22.Checked;
        }

        #region TextBoxExt ScrollBars
        private void comboBox9_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox9.Items[comboBox9.SelectedIndex].ToString())
            {
                case "None":
                    this.textBoxExt4.ScrollBars = ScrollBars.None;
                    break;
                case "Horizontal":
                    this.textBoxExt4.ScrollBars = ScrollBars.Horizontal;
                    break;
                case "Vertical":
                    this.textBoxExt4.ScrollBars = ScrollBars.Vertical;
                    break;
                case "Both":
                    this.textBoxExt4.ScrollBars = ScrollBars.Both;
                    break;
            }
        }
        #endregion

        //To set the TextBoxExt OverflowIndicatorToolTip Text
        private void textBox11_TextChanged(object sender, EventArgs e)
        {
            if (this.textBox11.Text != "")
            {
                this.textBoxExt4.OverflowIndicatorToolTipText = this.textBox11.Text;
            }
        }

        //To show the TextBoxExt OverflowIndicatorToolTip
        private void checkBox26_CheckedChanged(object sender, EventArgs e)
        {
            this.textBoxExt4.ShowOverflowIndicatorToolTip = this.checkBox26.Checked;
            if (!string.IsNullOrEmpty(textBoxExt4.Text))
                this.textBoxExt4.OverflowIndicatorToolTipText = this.textBox11.Text;
        }

        //To show the TextBoxExt OverflowIndicator
        private void checkBox21_CheckedChanged(object sender, EventArgs e)
        {
            this.textBoxExt4.ShowOverflowIndicator = this.checkBox21.Checked;
        }

        //TextBoxExt BorderColor
        private void buttonEdit2_ButtonClicked(object sender, ButtonClickedEventArgs args)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                this.buttonEdit2.BackColor = colorDialog1.Color;
                this.textBoxExt4.Metrocolor = colorDialog1.Color;
            }

        }
        #endregion

        #region EditableList

        #region DragDrop
        private void editableList2_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData("FileDrop", false);

            foreach (string s in files)
            {
                this.editableList2.ListBox.Items.Add(s.Substring(1 + s.LastIndexOf(@"\")));
            }
        }
        #endregion

        #region DragEnter
        private void editableList2_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))

                e.Effect = DragDropEffects.All;

            else

                e.Effect = DragDropEffects.None;

        }
        #endregion


        #region ListBoxTextAlign

        private void comboBox13_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox13.Items[comboBox13.SelectedIndex].ToString())
            {
                case "Left":
                    this.editableList1.ListBoxTextAlignment = TextAlignment.Left;
                    break;
                case "Right":
                    this.editableList1.ListBoxTextAlignment = TextAlignment.Right;
                    break;
                case "Center":
                    this.editableList1.ListBoxTextAlignment = TextAlignment.Center;
                    break;
            }
        }
        #endregion

        #region Want Button
        private void checkBox27_CheckedChanged(object sender, EventArgs e)
        {
            this.editableList1.WantButton = this.checkBox27.Checked;
        }
        #endregion

        #region RightToLeft
        private void checkBox28_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBox28.Checked)
            {
                this.editableList1.RightToLeft = RightToLeft.Yes;
            }
            else
            {

                this.editableList1.RightToLeft = RightToLeft.No;
            }
        }
        #endregion

        #endregion

        #region Control Visible

        private void treeViewAdv1_AfterSelect(object sender, EventArgs e)
        {
            this.treeViewAdv1.Nodes[0].BaseStyle = "Style2";

            if (this.treeViewAdv1.SelectedNode.Text == "Input Controls")
            {
                this.inputPanel.Visible = true;
                this.upDownPanel.Visible = false;
                this.maskedEditPanel.Visible = false;
                this.textBoxPanel.Visible = false;
            }
            else if (this.treeViewAdv1.SelectedNode.Text == "UpDownExt Controls")
            {
                this.inputPanel.Visible = false;
                this.upDownPanel.Visible = true;
                this.maskedEditPanel.Visible = false;
                this.textBoxPanel.Visible = false;

            }
            else if (this.treeViewAdv1.SelectedNode.Text == "TextBoxExt")
            {
                this.textBoxPanel.Visible = true;
                this.upDownPanel.Visible = false;
                this.maskedEditPanel.Visible = false;
                this.inputPanel.Visible = false;

            }
            else if (this.treeViewAdv1.SelectedNode.Text == "Masked Edit")
            {
                this.maskedEditPanel.Visible = true;
                this.upDownPanel.Visible = false;
                this.textBoxPanel.Visible = false;
                this.inputPanel.Visible = false;

            }
        }
        #endregion

        #region MaskedEditBox
        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            this.maskedEditBox1.BorderStyle = BorderStyle.FixedSingle;
            this.comboBox7.Enabled = false;
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioButton8.Checked)
            {
                this.maskedEditBox1.CornerRadius = 0;
                this.numericUpDownExt9.Value = 0;
                this.maskedEditBox1.BorderStyle = BorderStyle.Fixed3D;
                this.comboBox7.Enabled = true;
            }

        }

        private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox7.Items[comboBox7.SelectedIndex].ToString())
            {
                case "RaisedOuter":
                    this.maskedEditBox1.Border3DStyle = Border3DStyle.RaisedOuter;

                    break;
                case "Adjust":
                    this.maskedEditBox1.Border3DStyle = Border3DStyle.Adjust;
                    break;
                case "Bump":
                    this.maskedEditBox1.Border3DStyle = Border3DStyle.Bump;

                    break;
                case "Etched":

                    this.maskedEditBox1.Border3DStyle = Border3DStyle.Etched;


                    break;
                case "Flat":
                    this.maskedEditBox1.Border3DStyle = Border3DStyle.Flat;


                    break;
                case "Raised":
                    this.maskedEditBox1.Border3DStyle = Border3DStyle.Raised;

                    break;
                case "RaisedInner":
                    this.maskedEditBox1.Border3DStyle = Border3DStyle.RaisedInner;
                    break;
                case "Sunken":
                    this.maskedEditBox1.Border3DStyle = Border3DStyle.Sunken;

                    break;
                case "SunkenInner":
                    this.maskedEditBox1.Border3DStyle = Border3DStyle.SunkenInner;
                    break;
                case "SunkenOuter":
                    this.maskedEditBox1.Border3DStyle = Border3DStyle.SunkenOuter;

                    break;
            }
        }

        private void comboBox14_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox14.Items[comboBox14.SelectedIndex].ToString())
            {
                case "Left":
                    this.maskedEditBox1.BorderSides = System.Windows.Forms.Border3DSide.Left;
                    break;
                case "Top":
                    this.maskedEditBox1.BorderSides = System.Windows.Forms.Border3DSide.Top;
                    break;
                case "Right":
                    this.maskedEditBox1.BorderSides = System.Windows.Forms.Border3DSide.Right;
                    break;
                case "Bottom":
                    this.maskedEditBox1.BorderSides = System.Windows.Forms.Border3DSide.Bottom;
                    break;
                case "Middle":
                    this.maskedEditBox1.BorderSides = System.Windows.Forms.Border3DSide.Middle;
                    break;
                case "All":
                    this.maskedEditBox1.BorderSides = System.Windows.Forms.Border3DSide.All;
                    break;

            }
        }

        private void buttonEdit5_ButtonClicked(object sender, ButtonClickedEventArgs args)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {

                this.buttonEdit5.BackColor = colorDialog1.Color;
                this.maskedEditBox1.BackColor = colorDialog1.Color;
            }
        }

        private void buttonEdit3_ButtonClicked(object sender, ButtonClickedEventArgs args)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {

                this.buttonEdit3.BackColor = colorDialog1.Color;
                this.maskedEditBox1.ForeColor = colorDialog1.Color;
            }
        }

        private void buttonEdit4_ButtonClicked(object sender, ButtonClickedEventArgs args)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {

                this.buttonEdit4.BackColor = colorDialog1.Color;
                this.maskedEditBox1.Metrocolor = colorDialog1.Color;
            }
        }

        private void comboBox15_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox15.Items[comboBox15.SelectedIndex].ToString())
            {
                case "None":
                    this.maskedEditBox1.Mask = "";

                    break;

                case "##/##/####":
                    this.maskedEditBox1.Mask = "##/##/####";

                    break;
                case "##.##":
                    this.maskedEditBox1.Mask = "##.##";

                    break;
                case "###-########":
                    this.maskedEditBox1.Mask = "###-########";

                    break;
            }



        }


        private void comboBox17_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox17.Items[comboBox17.SelectedIndex].ToString())
            {
                case "Normal":
                    this.maskedEditBox1.CharacterCasing = CharacterCasing.Normal;
                    break;
                case "Upper Case":
                    this.maskedEditBox1.CharacterCasing = CharacterCasing.Upper;
                    break;
                case "Lower Case":
                    this.maskedEditBox1.CharacterCasing = CharacterCasing.Lower;
                    break;
            }
        }

        private void comboBox16_SelectedIndexChanged(object sender, EventArgs e)
        {

            switch (comboBox16.Items[comboBox16.SelectedIndex].ToString())
            {
                case "Left":
                    this.maskedEditBox1.TextAlign = HorizontalAlignment.Left;

                    break;
                case "Right":
                    this.maskedEditBox1.TextAlign = HorizontalAlignment.Right;

                    break;
                case "Center":
                    this.maskedEditBox1.TextAlign = HorizontalAlignment.Center;

                    break;
            }

        }

        private void checkBox30_CheckedChanged(object sender, EventArgs e)
        {
            this.maskedEditBox1.ReadOnly = this.checkBox30.Checked;

        }

        private void checkBox29_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBox29.Checked)
            {
                this.maskedEditBox1.RightToLeft = RightToLeft.Yes;
            }
            else
            {

                this.maskedEditBox1.RightToLeft = RightToLeft.No;
            }
        }


        private void comboBox18_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox18.Items[comboBox18.SelectedIndex].ToString())
            {
                case "*":
                    this.maskedEditBox1.PasswordChar = '*';
                    break;
                case "#":
                    this.maskedEditBox1.PasswordChar = '#';
                    break;
                case "@":
                    this.maskedEditBox1.PasswordChar = '@';
                    break;
                case "None":
                    this.maskedEditBox1.PasswordChar = '\0';
                    break;
            }
        }



        #endregion

        #region Banner Text Settings

        void Application_Idle(object sender, EventArgs e)
        {
            if (txtBanner.Text == "")
                button1.Enabled = false;
            else
                button1.Enabled = true;

            if (txtBnr.Text == "")
                btnSetBanner.Enabled = false;
            else
                btnSetBanner.Enabled = true;

            if (textBanner.Text == "")
                buttonBanner.Enabled = false;
            else
                buttonBanner.Enabled = true;
        }

        //TextBoxExt
        private void bannerClrEdit_ButtonClicked(object sender, ButtonClickedEventArgs args)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
                bannerClrEdit.BackColor = colorDialog1.Color;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BannerTextMode mode;
            if (rdoEdit.Checked)
                mode = BannerTextMode.EditMode;
            else
                mode = BannerTextMode.FocusMode;

            BannerTextInfo binfo = this.bannerTextProvider1.GetBannerText(this.textBoxExt4);
            binfo.Text = txtBanner.Text;
            binfo.Mode = mode;
            binfo.Color = bannerClrEdit.TextBox.BackColor;
            binfo.Visible = true;
            this.bannerTextProvider1.SetBannerText(this.textBoxExt4, binfo);
            this.textBoxExt4.Refresh();
        }

        //Input Controls
        private void bannerClr_ButtonClicked(object sender, ButtonClickedEventArgs args)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
                bannerClr.BackColor = colorDialog1.Color;
        }

        private void btnSetBanner_Click(object sender, EventArgs e)
        {
            BannerTextMode mode = (BannerTextMode)Enum.Parse(typeof(BannerTextMode), cmbMode.SelectedItem.ToString());
            BannerTextInfo binfo = this.bannerTextProvider1.GetBannerText(this.currencyTextBox1);
            binfo.Text = txtBnr.Text;
            binfo.Mode = mode;
            binfo.Color = bannerClr.TextBox.BackColor;
            binfo.Visible = true;
            this.bannerTextProvider1.SetBannerText(this.currencyTextBox1, binfo);
            currencyTextBox1.Refresh();

            BannerTextInfo binfo2 = this.bannerTextProvider1.GetBannerText(this.integerTextBox2);
            binfo2.Text = txtBnr.Text;
            binfo2.Mode = mode;
            binfo2.Color = bannerClr.TextBox.BackColor;
            binfo2.Visible = true;
            this.bannerTextProvider1.SetBannerText(this.integerTextBox2, binfo2);
            integerTextBox1.Refresh();

            BannerTextInfo binfo3 = this.bannerTextProvider1.GetBannerText(this.doubleTextBox1);
            binfo3.Text = txtBnr.Text;
            binfo3.Mode = mode;
            binfo3.Color = bannerClr.TextBox.BackColor;
            binfo3.Visible = true;
            this.bannerTextProvider1.SetBannerText(this.doubleTextBox1, binfo3);
            doubleTextBox1.Refresh();

            BannerTextInfo binfo4 = this.bannerTextProvider1.GetBannerText(this.percentTextBox1);
            binfo4.Text = txtBnr.Text;
            binfo4.Mode = mode;
            binfo4.Color = bannerClr.TextBox.BackColor;
            binfo4.Visible = true;
            this.bannerTextProvider1.SetBannerText(this.percentTextBox1, binfo4);
            percentTextBox1.Refresh();
        }

        //UpDown controls
        private void bEditBanner_ButtonClicked(object sender, ButtonClickedEventArgs args)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
                bEditBanner.BackColor = colorDialog1.Color;
        }

        private void buttonBanner_Click(object sender, EventArgs e)
        {
            BannerTextMode mode = (BannerTextMode)Enum.Parse(typeof(BannerTextMode), comboMode.SelectedItem.ToString());

            BannerTextInfo binfo = this.bannerTextProvider1.GetBannerText(this.domainUpDownExt1);
            binfo.Text = textBanner.Text;
            binfo.Mode = mode;
            binfo.Color = bEditBanner.TextBox.BackColor;
            binfo.Visible = true;
            this.bannerTextProvider1.SetBannerText(this.domainUpDownExt1, binfo);
            domainUpDownExt1.Refresh();

            BannerTextInfo binfo2 = this.bannerTextProvider1.GetBannerText(this.numericUpDownExt7);
            binfo2.Text = textBanner.Text;
            binfo2.Mode = mode;
            binfo2.Color = bEditBanner.TextBox.BackColor;
            binfo2.Visible = true;
            this.bannerTextProvider1.SetBannerText(this.numericUpDownExt7, binfo2);
            this.numericUpDownExt7.Refresh();
        }
        #endregion

        private void gradientLabel1_Click(object sender, EventArgs e)
        {

        }
        private void numericUpDownExt8_ValueChanged(object sender, EventArgs e)
        {
            if (this.numericUpDownExt8.Value != 0)
            {
                this.radioButton6.Checked = false;
                this.radioButton7.Checked = true;

                this.currencyTextBox1.CornerRadius = (int)this.numericUpDownExt8.Value;
                this.currencyTextBox1.CornerRadius = (int)this.numericUpDownExt8.Value;
                this.doubleTextBox1.CornerRadius = (int)this.numericUpDownExt8.Value;
                this.integerTextBox2.CornerRadius = (int)this.numericUpDownExt8.Value;
                this.percentTextBox1.CornerRadius = (int)this.numericUpDownExt8.Value;
            }
        }

        private void numericUpDownExt6_ValueChanged(object sender, EventArgs e)
        {
            if (this.numericUpDownExt6.Value != 0)
            {
                this.radioButton10.Checked = false;
                this.radioButton11.Checked = true;
                this.textBoxExt4.BorderStyle = BorderStyle.FixedSingle;
                this.textBoxExt4.CornerRadius = (int)this.numericUpDownExt6.Value;
            }
        }

        private void numericUpDownExt9_ValueChanged(object sender, EventArgs e)
        {
            if (this.numericUpDownExt9.Value != 0)
            {
                this.radioButton8.Checked = false;
                this.radioButton9.Checked = true;
                this.maskedEditBox1.BorderStyle = BorderStyle.FixedSingle;
                this.maskedEditBox1.CornerRadius = (int)this.numericUpDownExt9.Value;
            }
        }

        private void checkBox32_CheckedChanged(object sender, EventArgs e)
        {
            if (!this.checkBox32.Checked)
                this.textBoxExt4.FarImage = null;
            else
                this.textBoxExt4.FarImage = new Bitmap("..//..//FarImage.png");
        }

        private void checkBox31_CheckedChanged(object sender, EventArgs e)
        {
            if (!this.checkBox31.Checked)
                this.textBoxExt4.NearImage = null;
            else
                this.textBoxExt4.NearImage = new Bitmap("..//..//NearImage.png");
        }

        private void chkPullCharOnDelete_CheckedChanged(object sender, EventArgs e)
        {
            this.maskedEditBox1.PullCharOnDelete = this.chkPullCharOnDelete.Checked;
        }

        private void textBanner_KeyPress(object sender, KeyPressEventArgs e)
        {
            //define a string containing special characters
            string arr = "!@#$%^&*()+=-[]\\\';,./{}|\":<>?1234567890";
            for (int k = 0; k < arr.Length; k++)
            {
                if (e.KeyChar == arr[k])
                {
                    textBanner.Text = string.Empty;
                    MessageBox.Show("special and numeric characters not allowed", "Invalid");
                    e.Handled = true;
                    break;

                }
            }
        }

        private void txtBnr_KeyPress(object sender, KeyPressEventArgs e)
        {
            //define a string containing special characters
            string arr = "!@#$%^&*()+=-[]\\\';,./{}|\":<>?1234567890";
            for (int k = 0; k < arr.Length; k++)
            {
                if (e.KeyChar == arr[k])
                {
                    txtBnr.Text = string.Empty;
                    MessageBox.Show("special and numeric characters not allowed", "Invalid");
                    e.Handled = true;
                    break;

                }
            }
        }

        private void GetColors(Color backcolor, Color forecolor)
        {
            BrushInfo brush = new BrushInfo(backcolor);
            this.gradientLabel1.BackgroundColor = brush;
            //this.gradientLabel1.BorderColor = forecolor;
            this.dataGrid1.CaptionBackColor = backcolor;
            this.dataGrid2.CaptionBackColor = backcolor;
            this.BackColor = backcolor;
            this.CaptionBarColor = backcolor;
            this.MetroColor = backcolor;
            this.groupBox1.ForeColor = forecolor;
            this.groupBox2.ForeColor = forecolor;
            this.groupBox3.ForeColor = forecolor;
            this.groupBox4.ForeColor = forecolor;
            this.groupBox5.ForeColor = forecolor;
            this.groupBox6.ForeColor = forecolor;
            this.gradientLabel1.ForeColor = forecolor;
            this.ForeColor = forecolor;
            this.CaptionForeColor = forecolor;
            this.dataGrid1.CaptionForeColor = forecolor;
            this.dataGrid2.CaptionForeColor = forecolor;
            this.gradientLabel1.BorderColor = Color.Gainsboro;
            //this.treeViewAdv1.BackColor = backcolor;
        }
        private void comboBoxAdv3_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.skinManager1.VisualTheme = VisualTheme.Office2016White;
            this.gradientLabel1.BorderColor = ControlPaint.LightLight(Color.Black);
            if (this.comboBoxAdv3.SelectedItem.ToString().Equals("Office2007Blue"))
            {
                this.GetColors(Color.White, Color.Black);
                this.skinManager1.VisualTheme = VisualTheme.Office2007Blue;
            }
            else if (this.comboBoxAdv3.SelectedItem.ToString().Equals("Office2007Silver"))
            {
                this.skinManager1.VisualTheme = VisualTheme.Office2007Silver;
                this.GetColors(Color.White, Color.Black);
            }
            else if (this.comboBoxAdv3.SelectedItem.ToString().Equals("Office2010Silver"))
            {
                this.skinManager1.VisualTheme = VisualTheme.Office2010Silver;
                this.GetColors(Color.White, Color.Black);
            }
            else if (this.comboBoxAdv3.SelectedItem.ToString().Equals("Metro"))
            {
                this.skinManager1.VisualTheme = VisualTheme.Metro;
                this.GetColors(Color.White, Color.Black);
                this.dataGrid1.CaptionBackColor = Color.FromArgb(22, 165, 220);
                this.dataGrid2.CaptionBackColor = Color.FromArgb(22, 165, 220);
                this.dataGrid1.CaptionForeColor = Color.White;
                this.dataGrid2.CaptionForeColor = Color.White;
            }
            else if (this.comboBoxAdv3.SelectedItem.ToString().Equals("Office2010Blue"))
            {
                this.skinManager1.VisualTheme = VisualTheme.Office2010Blue;
                this.GetColors(Color.White, Color.Black);
            }
            else if (this.comboBoxAdv3.SelectedItem.ToString().Equals("Office2007Black"))
            {
                this.skinManager1.VisualTheme = VisualTheme.Office2007Black;
                this.GetColors(Color.Black, Color.White);
            }
            else if (this.comboBoxAdv3.SelectedItem.ToString().Equals("Office2010Black"))
            {
                this.skinManager1.VisualTheme = VisualTheme.Office2010Black;
                this.GetColors(Color.Black, Color.White);
            }
            else if (this.comboBoxAdv3.SelectedItem.ToString().Equals("Office2016DarkGray"))
            {
                this.skinManager1.VisualTheme = VisualTheme.Office2016DarkGray;
                this.GetColors(Color.FromArgb(102, 102, 102), Color.LightGray);
                this.treeViewAdv1.Style = TreeStyle.Office2016DarkGray;              
            }
            else if (this.comboBoxAdv3.SelectedItem.ToString().Equals("Office2016Colorful"))
            {
                this.treeViewAdv1.Style = TreeStyle.Office2016Colorful;
                this.skinManager1.VisualTheme = VisualTheme.Office2016Colorful;
                this.GetColors(Color.White, Color.Black);
            }
            else if (this.comboBoxAdv3.SelectedItem.ToString().Equals("Office2016White"))
            {
                this.skinManager1.VisualTheme = VisualTheme.Office2016White;
                this.treeViewAdv1.Style = TreeStyle.Office2016White;
                this.GetColors(Color.White, Color.Black);
            }
            else if (this.comboBoxAdv3.SelectedItem.ToString().Equals("Office2016Black"))
            {
                this.skinManager1.VisualTheme = VisualTheme.Office2016Black;
                this.treeViewAdv1.Style = TreeStyle.Office2016Black;
                this.GetColors(Color.FromArgb(37, 37, 37), Color.White);
            }
            this.Invalidate();
        }

    }
}
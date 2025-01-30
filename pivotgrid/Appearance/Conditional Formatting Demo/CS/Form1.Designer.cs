#region Copyright Syncfusion Inc. 2001 - 2018
// Copyright Syncfusion Inc. 2001 - 2018. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Syncfusion.Windows.Forms;
using System.Drawing;
using System.Windows.Forms;

namespace ConditionalFormating
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pnlRule1 = new System.Windows.Forms.Panel();
            this.cboRule1FormatStyle = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.lblFormatStyle = new System.Windows.Forms.Label();
            this.cboRule1SummaryElement = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.lblSummaryElement = new System.Windows.Forms.Label();
            this.cboRule1ImageName = new Syncfusion.Windows.Forms.Tools.ComboDropDown();
            this.grdDropDown = new Syncfusion.Windows.Forms.Grid.GridListControl();
            this.lblImageName = new System.Windows.Forms.Label();
            this.pnlRule2 = new System.Windows.Forms.Panel();
            this.cboRule2SummaryElement = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.label6 = new System.Windows.Forms.Label();
            this.cboRule2predicateType = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.cboRule2ConditionType = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.lblPredicateType = new System.Windows.Forms.Label();
            this.lblConditionType = new System.Windows.Forms.Label();
            this.pnlRule2Value = new System.Windows.Forms.Panel();
            this.lblRule2And = new System.Windows.Forms.Label();
            this.txtRule2EndValue = new System.Windows.Forms.TextBox();
            this.txtRule2StartValue = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pnlRule3 = new System.Windows.Forms.Panel();
            this.cboRule3SummaryElement = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRule3RankValue = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cboRule3FormatRankType = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.lblFormatRankType = new System.Windows.Forms.Label();
            this.pnlRule1Value = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.cboValueType4 = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.cboValueType3 = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.cboValueType2 = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.txtValue4 = new Syncfusion.Windows.Forms.Tools.NumericTextBox();
            this.txtValue3 = new Syncfusion.Windows.Forms.Tools.NumericTextBox();
            this.txtValue2 = new Syncfusion.Windows.Forms.Tools.NumericTextBox();
            this.txtValue1 = new Syncfusion.Windows.Forms.Tools.NumericTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboValueType1 = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.lblValueType = new System.Windows.Forms.Label();
            this.pnlRule4 = new System.Windows.Forms.Panel();
            this.cboRule4SummaryElement = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.cboRule4FormatValueType = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.lblFormatValueType = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pnlRule5 = new System.Windows.Forms.Panel();
            this.cboRule5SummaryElement = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.label7 = new System.Windows.Forms.Label();
            this.cboRule5FormatAllType = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.lblFormatAllType = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.grdRuleType = new Syncfusion.Windows.Forms.Grid.GridListControl();
            this.buttonAdv1 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.buttonAdv2 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pivotGridControl1 = new Syncfusion.Windows.Forms.PivotAnalysis.PivotGridControl(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.pnlRule1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboRule1FormatStyle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboRule1SummaryElement)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboRule1ImageName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdDropDown)).BeginInit();
            this.pnlRule2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboRule2SummaryElement)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboRule2predicateType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboRule2ConditionType)).BeginInit();
            this.pnlRule2Value.SuspendLayout();
            this.pnlRule3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboRule3SummaryElement)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboRule3FormatRankType)).BeginInit();
            this.pnlRule1Value.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboValueType4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboValueType3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboValueType2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtValue4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtValue3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtValue2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtValue1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboValueType1)).BeginInit();
            this.pnlRule4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboRule4SummaryElement)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboRule4FormatValueType)).BeginInit();
            this.pnlRule5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboRule5SummaryElement)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboRule5FormatAllType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdRuleType)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.pnlRule1);
            this.groupBox1.Controls.Add(this.pnlRule2);
            this.groupBox1.Controls.Add(this.pnlRule2Value);
            this.groupBox1.Controls.Add(this.pnlRule3);
            this.groupBox1.Controls.Add(this.pnlRule1Value);
            this.groupBox1.Controls.Add(this.pnlRule4);
            this.groupBox1.Controls.Add(this.pnlRule5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.grdRuleType);
            this.groupBox1.Controls.Add(this.buttonAdv1);
            this.groupBox1.Controls.Add(this.buttonAdv2);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(0);
            this.groupBox1.Size = new System.Drawing.Size(321, 562);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Options";
            // 
            // pnlRule1
            // 
            this.pnlRule1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlRule1.Controls.Add(this.cboRule1FormatStyle);
            this.pnlRule1.Controls.Add(this.lblFormatStyle);
            this.pnlRule1.Controls.Add(this.cboRule1SummaryElement);
            this.pnlRule1.Controls.Add(this.lblSummaryElement);
            this.pnlRule1.Controls.Add(this.cboRule1ImageName);
            this.pnlRule1.Controls.Add(this.lblImageName);
            this.pnlRule1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlRule1.ForeColor = System.Drawing.Color.Black;
            this.pnlRule1.Location = new System.Drawing.Point(12, 165);
            this.pnlRule1.Margin = new System.Windows.Forms.Padding(0);
            this.pnlRule1.Name = "pnlRule1";
            this.pnlRule1.Size = new System.Drawing.Size(309, 120);
            this.pnlRule1.TabIndex = 6;
            // 
            // cboRule1FormatStyle
            // 
            this.cboRule1FormatStyle.BackColor = System.Drawing.Color.White;
            this.cboRule1FormatStyle.BeforeTouchSize = new System.Drawing.Size(162, 21);
            this.cboRule1FormatStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRule1FormatStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboRule1FormatStyle.Items.AddRange(new object[] {
            "IconSets"});
            this.cboRule1FormatStyle.Location = new System.Drawing.Point(128, 19);
            this.cboRule1FormatStyle.Margin = new System.Windows.Forms.Padding(0);
            this.cboRule1FormatStyle.Name = "cboRule1FormatStyle";
            this.cboRule1FormatStyle.Size = new System.Drawing.Size(162, 21);
            this.cboRule1FormatStyle.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.cboRule1FormatStyle.TabIndex = 14;
            this.cboRule1FormatStyle.Text = "IconSets";
            this.cboRule1FormatStyle.ThemeName = "Metro";
            // 
            // lblFormatStyle
            // 
            this.lblFormatStyle.AutoSize = true;
            this.lblFormatStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormatStyle.Location = new System.Drawing.Point(4, 22);
            this.lblFormatStyle.Margin = new System.Windows.Forms.Padding(0);
            this.lblFormatStyle.Name = "lblFormatStyle";
            this.lblFormatStyle.Size = new System.Drawing.Size(73, 15);
            this.lblFormatStyle.TabIndex = 0;
            this.lblFormatStyle.Text = "Format Style";
            // 
            // cboRule1SummaryElement
            // 
            this.cboRule1SummaryElement.BackColor = System.Drawing.Color.White;
            this.cboRule1SummaryElement.BeforeTouchSize = new System.Drawing.Size(162, 21);
            this.cboRule1SummaryElement.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRule1SummaryElement.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboRule1SummaryElement.Items.AddRange(new object[] {
            "Quantity",
            "Amount"});
            this.cboRule1SummaryElement.Location = new System.Drawing.Point(128, 53);
            this.cboRule1SummaryElement.Margin = new System.Windows.Forms.Padding(0);
            this.cboRule1SummaryElement.Name = "cboRule1SummaryElement";
            this.cboRule1SummaryElement.Size = new System.Drawing.Size(162, 21);
            this.cboRule1SummaryElement.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.cboRule1SummaryElement.TabIndex = 15;
            this.cboRule1SummaryElement.Text = "Quantity";
            this.cboRule1SummaryElement.ThemeName = "Metro";
            // 
            // lblSummaryElement
            // 
            this.lblSummaryElement.AutoSize = true;
            this.lblSummaryElement.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSummaryElement.Location = new System.Drawing.Point(0, 53);
            this.lblSummaryElement.Margin = new System.Windows.Forms.Padding(0);
            this.lblSummaryElement.Name = "lblSummaryElement";
            this.lblSummaryElement.Size = new System.Drawing.Size(104, 15);
            this.lblSummaryElement.TabIndex = 1;
            this.lblSummaryElement.Text = "Summary Element";
            // 
            // cboRule1ImageName
            // 
            this.cboRule1ImageName.BackColor = System.Drawing.Color.White;
            this.cboRule1ImageName.BeforeTouchSize = new System.Drawing.Size(162, 21);
            this.cboRule1ImageName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRule1ImageName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboRule1ImageName.Location = new System.Drawing.Point(128, 88);
            this.cboRule1ImageName.Margin = new System.Windows.Forms.Padding(0);
            this.cboRule1ImageName.Name = "cboRule1ImageName";
            this.cboRule1ImageName.PopupControl = this.grdDropDown;
            this.cboRule1ImageName.Size = new System.Drawing.Size(162, 21);
            this.cboRule1ImageName.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.cboRule1ImageName.TabIndex = 16;
            // 
            // grdDropDown
            // 
            this.grdDropDown.BackColor = System.Drawing.Color.White;
            this.grdDropDown.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.grdDropDown.ItemHeight = 17;
            this.grdDropDown.Location = new System.Drawing.Point(9, 441);
            this.grdDropDown.Name = "grdDropDown";
            this.grdDropDown.Properties.BackgroundColor = System.Drawing.SystemColors.Window;
            this.grdDropDown.SelectedIndex = -1;
            this.grdDropDown.Size = new System.Drawing.Size(97, 73);
            this.grdDropDown.TabIndex = 3;
            this.grdDropDown.TopIndex = 0;
            // 
            // lblImageName
            // 
            this.lblImageName.AutoSize = true;
            this.lblImageName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImageName.Location = new System.Drawing.Point(4, 88);
            this.lblImageName.Margin = new System.Windows.Forms.Padding(0);
            this.lblImageName.Name = "lblImageName";
            this.lblImageName.Size = new System.Drawing.Size(40, 15);
            this.lblImageName.TabIndex = 3;
            this.lblImageName.Text = "Image";
            // 
            // pnlRule2
            // 
            this.pnlRule2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlRule2.Controls.Add(this.cboRule2SummaryElement);
            this.pnlRule2.Controls.Add(this.label6);
            this.pnlRule2.Controls.Add(this.cboRule2predicateType);
            this.pnlRule2.Controls.Add(this.cboRule2ConditionType);
            this.pnlRule2.Controls.Add(this.lblPredicateType);
            this.pnlRule2.Controls.Add(this.lblConditionType);
            this.pnlRule2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlRule2.ForeColor = System.Drawing.Color.Black;
            this.pnlRule2.Location = new System.Drawing.Point(12, 165);
            this.pnlRule2.Margin = new System.Windows.Forms.Padding(0);
            this.pnlRule2.Name = "pnlRule2";
            this.pnlRule2.Size = new System.Drawing.Size(309, 132);
            this.pnlRule2.TabIndex = 19;
            this.pnlRule2.Visible = false;
            // 
            // cboRule2SummaryElement
            // 
            this.cboRule2SummaryElement.BackColor = System.Drawing.Color.White;
            this.cboRule2SummaryElement.BeforeTouchSize = new System.Drawing.Size(165, 21);
            this.cboRule2SummaryElement.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRule2SummaryElement.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboRule2SummaryElement.ForeColor = System.Drawing.Color.Black;
            this.cboRule2SummaryElement.Items.AddRange(new object[] {
            "Quantity",
            "Amount"});
            this.cboRule2SummaryElement.Location = new System.Drawing.Point(134, 57);
            this.cboRule2SummaryElement.Margin = new System.Windows.Forms.Padding(0);
            this.cboRule2SummaryElement.Name = "cboRule2SummaryElement";
            this.cboRule2SummaryElement.Size = new System.Drawing.Size(165, 21);
            this.cboRule2SummaryElement.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.cboRule2SummaryElement.TabIndex = 15;
            this.cboRule2SummaryElement.Text = "Quantity";
            this.cboRule2SummaryElement.ThemeName = "Metro";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(7, 57);
            this.label6.Margin = new System.Windows.Forms.Padding(0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 15);
            this.label6.TabIndex = 1;
            this.label6.Text = "Summary Element";
            // 
            // cboRule2predicateType
            // 
            this.cboRule2predicateType.BackColor = System.Drawing.Color.White;
            this.cboRule2predicateType.BeforeTouchSize = new System.Drawing.Size(165, 21);
            this.cboRule2predicateType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRule2predicateType.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboRule2predicateType.ForeColor = System.Drawing.Color.Black;
            this.cboRule2predicateType.Items.AddRange(new object[] {
            "And",
            "Or"});
            this.cboRule2predicateType.Location = new System.Drawing.Point(134, 22);
            this.cboRule2predicateType.Margin = new System.Windows.Forms.Padding(0);
            this.cboRule2predicateType.Name = "cboRule2predicateType";
            this.cboRule2predicateType.Size = new System.Drawing.Size(165, 21);
            this.cboRule2predicateType.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.cboRule2predicateType.TabIndex = 19;
            this.cboRule2predicateType.Text = "And";
            this.cboRule2predicateType.ThemeName = "Metro";
            // 
            // cboRule2ConditionType
            // 
            this.cboRule2ConditionType.BackColor = System.Drawing.Color.White;
            this.cboRule2ConditionType.BeforeTouchSize = new System.Drawing.Size(165, 21);
            this.cboRule2ConditionType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRule2ConditionType.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboRule2ConditionType.ForeColor = System.Drawing.Color.Black;
            this.cboRule2ConditionType.Items.AddRange(new object[] {
            "Equals",
            "NotEquals",
            "LessThan",
            "LessThanOrEqual",
            "GreaterThan",
            "GreaterThanOrEqual",
            "Between"});
            this.cboRule2ConditionType.Location = new System.Drawing.Point(134, 98);
            this.cboRule2ConditionType.Margin = new System.Windows.Forms.Padding(0);
            this.cboRule2ConditionType.Name = "cboRule2ConditionType";
            this.cboRule2ConditionType.Size = new System.Drawing.Size(165, 21);
            this.cboRule2ConditionType.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.cboRule2ConditionType.TabIndex = 20;
            this.cboRule2ConditionType.Text = "Equals";
            this.cboRule2ConditionType.ThemeName = "Metro";
            this.cboRule2ConditionType.SelectedValueChanged += new System.EventHandler(this.cboRule2ConditionType_SelectedValueChanged);
            // 
            // lblPredicateType
            // 
            this.lblPredicateType.AutoSize = true;
            this.lblPredicateType.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPredicateType.ForeColor = System.Drawing.Color.Black;
            this.lblPredicateType.Location = new System.Drawing.Point(4, 22);
            this.lblPredicateType.Margin = new System.Windows.Forms.Padding(0);
            this.lblPredicateType.Name = "lblPredicateType";
            this.lblPredicateType.Size = new System.Drawing.Size(84, 15);
            this.lblPredicateType.TabIndex = 6;
            this.lblPredicateType.Text = "Predicate Type";
            // 
            // lblConditionType
            // 
            this.lblConditionType.AutoSize = true;
            this.lblConditionType.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConditionType.ForeColor = System.Drawing.Color.Black;
            this.lblConditionType.Location = new System.Drawing.Point(7, 98);
            this.lblConditionType.Margin = new System.Windows.Forms.Padding(0);
            this.lblConditionType.Name = "lblConditionType";
            this.lblConditionType.Size = new System.Drawing.Size(88, 15);
            this.lblConditionType.TabIndex = 5;
            this.lblConditionType.Text = "Condition Type";
            // 
            // pnlRule2Value
            // 
            this.pnlRule2Value.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlRule2Value.Controls.Add(this.lblRule2And);
            this.pnlRule2Value.Controls.Add(this.txtRule2EndValue);
            this.pnlRule2Value.Controls.Add(this.txtRule2StartValue);
            this.pnlRule2Value.Controls.Add(this.label4);
            this.pnlRule2Value.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlRule2Value.ForeColor = System.Drawing.Color.Black;
            this.pnlRule2Value.Location = new System.Drawing.Point(12, 305);
            this.pnlRule2Value.Margin = new System.Windows.Forms.Padding(0);
            this.pnlRule2Value.Name = "pnlRule2Value";
            this.pnlRule2Value.Size = new System.Drawing.Size(309, 89);
            this.pnlRule2Value.TabIndex = 27;
            this.pnlRule2Value.Visible = false;
            // 
            // lblRule2And
            // 
            this.lblRule2And.AutoSize = true;
            this.lblRule2And.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRule2And.ForeColor = System.Drawing.Color.Black;
            this.lblRule2And.Location = new System.Drawing.Point(142, 43);
            this.lblRule2And.Margin = new System.Windows.Forms.Padding(0);
            this.lblRule2And.Name = "lblRule2And";
            this.lblRule2And.Size = new System.Drawing.Size(27, 15);
            this.lblRule2And.TabIndex = 6;
            this.lblRule2And.Text = "and";
            // 
            // txtRule2EndValue
            // 
            this.txtRule2EndValue.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRule2EndValue.ForeColor = System.Drawing.Color.Black;
            this.txtRule2EndValue.Location = new System.Drawing.Point(180, 40);
            this.txtRule2EndValue.Margin = new System.Windows.Forms.Padding(0);
            this.txtRule2EndValue.Name = "txtRule2EndValue";
            this.txtRule2EndValue.Size = new System.Drawing.Size(119, 23);
            this.txtRule2EndValue.TabIndex = 5;
            this.txtRule2EndValue.Text = "18";
            // 
            // txtRule2StartValue
            // 
            this.txtRule2StartValue.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRule2StartValue.ForeColor = System.Drawing.Color.Black;
            this.txtRule2StartValue.Location = new System.Drawing.Point(10, 40);
            this.txtRule2StartValue.Margin = new System.Windows.Forms.Padding(0);
            this.txtRule2StartValue.Name = "txtRule2StartValue";
            this.txtRule2StartValue.Size = new System.Drawing.Size(114, 23);
            this.txtRule2StartValue.TabIndex = 4;
            this.txtRule2StartValue.Text = "8";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(8, 15);
            this.label4.Margin = new System.Windows.Forms.Padding(0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Value(s)";
            // 
            // pnlRule3
            // 
            this.pnlRule3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlRule3.Controls.Add(this.cboRule3SummaryElement);
            this.pnlRule3.Controls.Add(this.label3);
            this.pnlRule3.Controls.Add(this.txtRule3RankValue);
            this.pnlRule3.Controls.Add(this.label5);
            this.pnlRule3.Controls.Add(this.cboRule3FormatRankType);
            this.pnlRule3.Controls.Add(this.lblFormatRankType);
            this.pnlRule3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlRule3.ForeColor = System.Drawing.Color.Black;
            this.pnlRule3.Location = new System.Drawing.Point(12, 165);
            this.pnlRule3.Margin = new System.Windows.Forms.Padding(0);
            this.pnlRule3.Name = "pnlRule3";
            this.pnlRule3.Size = new System.Drawing.Size(309, 133);
            this.pnlRule3.TabIndex = 24;
            this.pnlRule3.Visible = false;
            // 
            // cboRule3SummaryElement
            // 
            this.cboRule3SummaryElement.BackColor = System.Drawing.Color.White;
            this.cboRule3SummaryElement.BeforeTouchSize = new System.Drawing.Size(165, 21);
            this.cboRule3SummaryElement.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRule3SummaryElement.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboRule3SummaryElement.ForeColor = System.Drawing.Color.Black;
            this.cboRule3SummaryElement.Items.AddRange(new object[] {
            "Quantity",
            "Amount"});
            this.cboRule3SummaryElement.Location = new System.Drawing.Point(134, 57);
            this.cboRule3SummaryElement.Margin = new System.Windows.Forms.Padding(0);
            this.cboRule3SummaryElement.Name = "cboRule3SummaryElement";
            this.cboRule3SummaryElement.Size = new System.Drawing.Size(165, 21);
            this.cboRule3SummaryElement.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.cboRule3SummaryElement.TabIndex = 24;
            this.cboRule3SummaryElement.Text = "Quantity";
            this.cboRule3SummaryElement.ThemeName = "Metro";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(4, 57);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 15);
            this.label3.TabIndex = 23;
            this.label3.Text = "Summary Element";
            // 
            // txtRule3RankValue
            // 
            this.txtRule3RankValue.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRule3RankValue.ForeColor = System.Drawing.Color.Black;
            this.txtRule3RankValue.Location = new System.Drawing.Point(134, 90);
            this.txtRule3RankValue.Margin = new System.Windows.Forms.Padding(0);
            this.txtRule3RankValue.Name = "txtRule3RankValue";
            this.txtRule3RankValue.Size = new System.Drawing.Size(165, 23);
            this.txtRule3RankValue.TabIndex = 4;
            this.txtRule3RankValue.Text = "25";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(4, 98);
            this.label5.Margin = new System.Windows.Forms.Padding(0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "Value";
            // 
            // cboRule3FormatRankType
            // 
            this.cboRule3FormatRankType.BackColor = System.Drawing.Color.White;
            this.cboRule3FormatRankType.BeforeTouchSize = new System.Drawing.Size(165, 21);
            this.cboRule3FormatRankType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRule3FormatRankType.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboRule3FormatRankType.ForeColor = System.Drawing.Color.Black;
            this.cboRule3FormatRankType.Items.AddRange(new object[] {
            "Top",
            "Bottom"});
            this.cboRule3FormatRankType.Location = new System.Drawing.Point(134, 16);
            this.cboRule3FormatRankType.Margin = new System.Windows.Forms.Padding(0);
            this.cboRule3FormatRankType.Name = "cboRule3FormatRankType";
            this.cboRule3FormatRankType.Size = new System.Drawing.Size(165, 21);
            this.cboRule3FormatRankType.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.cboRule3FormatRankType.TabIndex = 22;
            this.cboRule3FormatRankType.Text = "Top";
            this.cboRule3FormatRankType.ThemeName = "Metro";
            // 
            // lblFormatRankType
            // 
            this.lblFormatRankType.AutoSize = true;
            this.lblFormatRankType.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormatRankType.ForeColor = System.Drawing.Color.Black;
            this.lblFormatRankType.Location = new System.Drawing.Point(4, 22);
            this.lblFormatRankType.Margin = new System.Windows.Forms.Padding(0);
            this.lblFormatRankType.Name = "lblFormatRankType";
            this.lblFormatRankType.Size = new System.Drawing.Size(102, 15);
            this.lblFormatRankType.TabIndex = 9;
            this.lblFormatRankType.Text = "Format Rank Type";
            // 
            // pnlRule1Value
            // 
            this.pnlRule1Value.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlRule1Value.Controls.Add(this.textBox1);
            this.pnlRule1Value.Controls.Add(this.textBox2);
            this.pnlRule1Value.Controls.Add(this.textBox3);
            this.pnlRule1Value.Controls.Add(this.textBox4);
            this.pnlRule1Value.Controls.Add(this.cboValueType4);
            this.pnlRule1Value.Controls.Add(this.cboValueType3);
            this.pnlRule1Value.Controls.Add(this.cboValueType2);
            this.pnlRule1Value.Controls.Add(this.txtValue4);
            this.pnlRule1Value.Controls.Add(this.txtValue3);
            this.pnlRule1Value.Controls.Add(this.txtValue2);
            this.pnlRule1Value.Controls.Add(this.txtValue1);
            this.pnlRule1Value.Controls.Add(this.label1);
            this.pnlRule1Value.Controls.Add(this.cboValueType1);
            this.pnlRule1Value.Controls.Add(this.lblValueType);
            this.pnlRule1Value.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlRule1Value.ForeColor = System.Drawing.Color.Black;
            this.pnlRule1Value.Location = new System.Drawing.Point(12, 305);
            this.pnlRule1Value.Margin = new System.Windows.Forms.Padding(0);
            this.pnlRule1Value.Name = "pnlRule1Value";
            this.pnlRule1Value.Size = new System.Drawing.Size(309, 188);
            this.pnlRule1Value.TabIndex = 7;
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(145, 154);
            this.textBox1.Margin = new System.Windows.Forms.Padding(0);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(32, 23);
            this.textBox1.TabIndex = 28;
            this.textBox1.Text = ">=";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(145, 115);
            this.textBox2.Margin = new System.Windows.Forms.Padding(0);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(32, 23);
            this.textBox2.TabIndex = 27;
            this.textBox2.Text = ">=";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox3
            // 
            this.textBox3.Enabled = false;
            this.textBox3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(145, 74);
            this.textBox3.Margin = new System.Windows.Forms.Padding(0);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(32, 23);
            this.textBox3.TabIndex = 26;
            this.textBox3.Text = ">=";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox4
            // 
            this.textBox4.Enabled = false;
            this.textBox4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(145, 37);
            this.textBox4.Margin = new System.Windows.Forms.Padding(0);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(32, 23);
            this.textBox4.TabIndex = 25;
            this.textBox4.Text = ">=";
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cboValueType4
            // 
            this.cboValueType4.BackColor = System.Drawing.Color.White;
            this.cboValueType4.BeforeTouchSize = new System.Drawing.Size(114, 21);
            this.cboValueType4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboValueType4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboValueType4.Items.AddRange(new object[] {
            "Percent ",
            "Number"});
            this.cboValueType4.Location = new System.Drawing.Point(10, 156);
            this.cboValueType4.Margin = new System.Windows.Forms.Padding(0);
            this.cboValueType4.Name = "cboValueType4";
            this.cboValueType4.Size = new System.Drawing.Size(114, 21);
            this.cboValueType4.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.cboValueType4.TabIndex = 24;
            this.cboValueType4.Text = "Percent ";
            this.cboValueType4.ThemeName = "Metro";
            // 
            // cboValueType3
            // 
            this.cboValueType3.BackColor = System.Drawing.Color.White;
            this.cboValueType3.BeforeTouchSize = new System.Drawing.Size(113, 21);
            this.cboValueType3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboValueType3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboValueType3.Items.AddRange(new object[] {
            "Percent ",
            "Number"});
            this.cboValueType3.Location = new System.Drawing.Point(11, 115);
            this.cboValueType3.Margin = new System.Windows.Forms.Padding(0);
            this.cboValueType3.Name = "cboValueType3";
            this.cboValueType3.Size = new System.Drawing.Size(113, 21);
            this.cboValueType3.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.cboValueType3.TabIndex = 22;
            this.cboValueType3.Text = "Percent ";
            this.cboValueType3.ThemeName = "Metro";
            // 
            // cboValueType2
            // 
            this.cboValueType2.BackColor = System.Drawing.Color.White;
            this.cboValueType2.BeforeTouchSize = new System.Drawing.Size(113, 21);
            this.cboValueType2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboValueType2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboValueType2.Items.AddRange(new object[] {
            "Percent ",
            "Number"});
            this.cboValueType2.Location = new System.Drawing.Point(11, 74);
            this.cboValueType2.Margin = new System.Windows.Forms.Padding(0);
            this.cboValueType2.Name = "cboValueType2";
            this.cboValueType2.Size = new System.Drawing.Size(113, 21);
            this.cboValueType2.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.cboValueType2.TabIndex = 20;
            this.cboValueType2.Text = "Percent ";
            this.cboValueType2.ThemeName = "Metro";
            // 
            // txtValue4
            // 
            this.txtValue4.BeforeTouchSize = new System.Drawing.Size(95, 23);
            this.txtValue4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValue4.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtValue4.Location = new System.Drawing.Point(202, 154);
            this.txtValue4.Margin = new System.Windows.Forms.Padding(0);
            this.txtValue4.Name = "txtValue4";
            this.txtValue4.Size = new System.Drawing.Size(97, 23);
            this.txtValue4.TabIndex = 7;
            this.txtValue4.ThemeName = "Default";
            // 
            // txtValue3
            // 
            this.txtValue3.BeforeTouchSize = new System.Drawing.Size(95, 23);
            this.txtValue3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValue3.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtValue3.Location = new System.Drawing.Point(202, 115);
            this.txtValue3.Margin = new System.Windows.Forms.Padding(0);
            this.txtValue3.Name = "txtValue3";
            this.txtValue3.Size = new System.Drawing.Size(97, 23);
            this.txtValue3.TabIndex = 6;
            this.txtValue3.ThemeName = "Default";
            // 
            // txtValue2
            // 
            this.txtValue2.BeforeTouchSize = new System.Drawing.Size(95, 23);
            this.txtValue2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValue2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtValue2.Location = new System.Drawing.Point(204, 74);
            this.txtValue2.Margin = new System.Windows.Forms.Padding(0);
            this.txtValue2.Name = "txtValue2";
            this.txtValue2.Size = new System.Drawing.Size(95, 23);
            this.txtValue2.TabIndex = 5;
            this.txtValue2.ThemeName = "Default";
            // 
            // txtValue1
            // 
            this.txtValue1.BeforeTouchSize = new System.Drawing.Size(95, 23);
            this.txtValue1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValue1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtValue1.Location = new System.Drawing.Point(204, 37);
            this.txtValue1.Margin = new System.Windows.Forms.Padding(0);
            this.txtValue1.Name = "txtValue1";
            this.txtValue1.Size = new System.Drawing.Size(95, 23);
            this.txtValue1.TabIndex = 4;
            this.txtValue1.ThemeName = "Default";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(201, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Value";
            // 
            // cboValueType1
            // 
            this.cboValueType1.BackColor = System.Drawing.Color.White;
            this.cboValueType1.BeforeTouchSize = new System.Drawing.Size(113, 21);
            this.cboValueType1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboValueType1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboValueType1.Items.AddRange(new object[] {
            "Percent ",
            "Number"});
            this.cboValueType1.Location = new System.Drawing.Point(11, 37);
            this.cboValueType1.Margin = new System.Windows.Forms.Padding(0);
            this.cboValueType1.Name = "cboValueType1";
            this.cboValueType1.Size = new System.Drawing.Size(113, 21);
            this.cboValueType1.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.cboValueType1.TabIndex = 18;
            this.cboValueType1.Text = "Percent ";
            this.cboValueType1.ThemeName = "Metro";
            // 
            // lblValueType
            // 
            this.lblValueType.AutoSize = true;
            this.lblValueType.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValueType.Location = new System.Drawing.Point(8, 10);
            this.lblValueType.Margin = new System.Windows.Forms.Padding(0);
            this.lblValueType.Name = "lblValueType";
            this.lblValueType.Size = new System.Drawing.Size(64, 15);
            this.lblValueType.TabIndex = 4;
            this.lblValueType.Text = "Value Type";
            // 
            // pnlRule4
            // 
            this.pnlRule4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlRule4.Controls.Add(this.cboRule4SummaryElement);
            this.pnlRule4.Controls.Add(this.cboRule4FormatValueType);
            this.pnlRule4.Controls.Add(this.lblFormatValueType);
            this.pnlRule4.Controls.Add(this.label8);
            this.pnlRule4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlRule4.ForeColor = System.Drawing.Color.Black;
            this.pnlRule4.Location = new System.Drawing.Point(12, 165);
            this.pnlRule4.Margin = new System.Windows.Forms.Padding(0);
            this.pnlRule4.Name = "pnlRule4";
            this.pnlRule4.Size = new System.Drawing.Size(309, 96);
            this.pnlRule4.TabIndex = 26;
            this.pnlRule4.Visible = false;
            // 
            // cboRule4SummaryElement
            // 
            this.cboRule4SummaryElement.BackColor = System.Drawing.Color.White;
            this.cboRule4SummaryElement.BeforeTouchSize = new System.Drawing.Size(165, 21);
            this.cboRule4SummaryElement.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRule4SummaryElement.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboRule4SummaryElement.Items.AddRange(new object[] {
            "Quantity",
            "Amount"});
            this.cboRule4SummaryElement.Location = new System.Drawing.Point(125, 63);
            this.cboRule4SummaryElement.Margin = new System.Windows.Forms.Padding(0);
            this.cboRule4SummaryElement.Name = "cboRule4SummaryElement";
            this.cboRule4SummaryElement.Size = new System.Drawing.Size(165, 21);
            this.cboRule4SummaryElement.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.cboRule4SummaryElement.TabIndex = 24;
            this.cboRule4SummaryElement.Text = "Quantity";
            this.cboRule4SummaryElement.ThemeName = "Metro";
            // 
            // cboRule4FormatValueType
            // 
            this.cboRule4FormatValueType.BackColor = System.Drawing.Color.White;
            this.cboRule4FormatValueType.BeforeTouchSize = new System.Drawing.Size(165, 21);
            this.cboRule4FormatValueType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRule4FormatValueType.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboRule4FormatValueType.Items.AddRange(new object[] {
            "Above",
            "Below",
            "EqualOrAbove",
            "EqualOrBelow"});
            this.cboRule4FormatValueType.Location = new System.Drawing.Point(125, 22);
            this.cboRule4FormatValueType.Margin = new System.Windows.Forms.Padding(0);
            this.cboRule4FormatValueType.Name = "cboRule4FormatValueType";
            this.cboRule4FormatValueType.Size = new System.Drawing.Size(165, 21);
            this.cboRule4FormatValueType.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.cboRule4FormatValueType.TabIndex = 23;
            this.cboRule4FormatValueType.Text = "Above";
            this.cboRule4FormatValueType.ThemeName = "Metro";
            // 
            // lblFormatValueType
            // 
            this.lblFormatValueType.AutoSize = true;
            this.lblFormatValueType.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormatValueType.Location = new System.Drawing.Point(4, 22);
            this.lblFormatValueType.Margin = new System.Windows.Forms.Padding(0);
            this.lblFormatValueType.Name = "lblFormatValueType";
            this.lblFormatValueType.Size = new System.Drawing.Size(104, 15);
            this.lblFormatValueType.TabIndex = 11;
            this.lblFormatValueType.Text = "Format Value Type";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(8, 63);
            this.label8.Margin = new System.Windows.Forms.Padding(0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 15);
            this.label8.TabIndex = 23;
            this.label8.Text = "Summary Element";
            // 
            // pnlRule5
            // 
            this.pnlRule5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlRule5.Controls.Add(this.cboRule5SummaryElement);
            this.pnlRule5.Controls.Add(this.label7);
            this.pnlRule5.Controls.Add(this.cboRule5FormatAllType);
            this.pnlRule5.Controls.Add(this.lblFormatAllType);
            this.pnlRule5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlRule5.ForeColor = System.Drawing.Color.Black;
            this.pnlRule5.Location = new System.Drawing.Point(12, 165);
            this.pnlRule5.Margin = new System.Windows.Forms.Padding(0);
            this.pnlRule5.Name = "pnlRule5";
            this.pnlRule5.Size = new System.Drawing.Size(309, 96);
            this.pnlRule5.TabIndex = 26;
            this.pnlRule5.Visible = false;
            // 
            // cboRule5SummaryElement
            // 
            this.cboRule5SummaryElement.BackColor = System.Drawing.Color.White;
            this.cboRule5SummaryElement.BeforeTouchSize = new System.Drawing.Size(165, 21);
            this.cboRule5SummaryElement.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRule5SummaryElement.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboRule5SummaryElement.ForeColor = System.Drawing.Color.Black;
            this.cboRule5SummaryElement.Items.AddRange(new object[] {
            "Quantity",
            "Amount"});
            this.cboRule5SummaryElement.Location = new System.Drawing.Point(125, 57);
            this.cboRule5SummaryElement.Margin = new System.Windows.Forms.Padding(0);
            this.cboRule5SummaryElement.Name = "cboRule5SummaryElement";
            this.cboRule5SummaryElement.Size = new System.Drawing.Size(165, 21);
            this.cboRule5SummaryElement.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.cboRule5SummaryElement.TabIndex = 24;
            this.cboRule5SummaryElement.Text = "Quantity";
            this.cboRule5SummaryElement.ThemeName = "Metro";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(7, 57);
            this.label7.Margin = new System.Windows.Forms.Padding(0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 15);
            this.label7.TabIndex = 23;
            this.label7.Text = "Summary Element";
            // 
            // cboRule5FormatAllType
            // 
            this.cboRule5FormatAllType.BackColor = System.Drawing.Color.White;
            this.cboRule5FormatAllType.BeforeTouchSize = new System.Drawing.Size(165, 21);
            this.cboRule5FormatAllType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRule5FormatAllType.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboRule5FormatAllType.ForeColor = System.Drawing.Color.Black;
            this.cboRule5FormatAllType.Items.AddRange(new object[] {
            "Duplicate",
            "Unique"});
            this.cboRule5FormatAllType.Location = new System.Drawing.Point(125, 19);
            this.cboRule5FormatAllType.Margin = new System.Windows.Forms.Padding(0);
            this.cboRule5FormatAllType.Name = "cboRule5FormatAllType";
            this.cboRule5FormatAllType.Size = new System.Drawing.Size(165, 21);
            this.cboRule5FormatAllType.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.cboRule5FormatAllType.TabIndex = 21;
            this.cboRule5FormatAllType.Text = "Duplicate";
            this.cboRule5FormatAllType.ThemeName = "Metro";
            // 
            // lblFormatAllType
            // 
            this.lblFormatAllType.AutoSize = true;
            this.lblFormatAllType.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormatAllType.ForeColor = System.Drawing.Color.Black;
            this.lblFormatAllType.Location = new System.Drawing.Point(7, 19);
            this.lblFormatAllType.Margin = new System.Windows.Forms.Padding(0);
            this.lblFormatAllType.Name = "lblFormatAllType";
            this.lblFormatAllType.Size = new System.Drawing.Size(90, 15);
            this.lblFormatAllType.TabIndex = 12;
            this.lblFormatAllType.Text = "Format All Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 27);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 15);
            this.label2.TabIndex = 18;
            this.label2.Text = "Rule Type";
            // 
            // grdRuleType
            // 
            this.grdRuleType.BackColor = System.Drawing.Color.White;
            this.grdRuleType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.grdRuleType.ItemHeight = 15;
            this.grdRuleType.Location = new System.Drawing.Point(12, 47);
            this.grdRuleType.Margin = new System.Windows.Forms.Padding(0);
            this.grdRuleType.Name = "grdRuleType";
            this.grdRuleType.Properties.BackgroundColor = System.Drawing.SystemColors.Window;
            this.grdRuleType.SelectedIndex = -1;
            this.grdRuleType.Size = new System.Drawing.Size(309, 109);
            this.grdRuleType.TabIndex = 5;
            this.grdRuleType.TopIndex = 0;
            // 
            // buttonAdv1
            // 
            this.buttonAdv1.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.buttonAdv1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(130)))), ((int)(((byte)(195)))));
            this.buttonAdv1.BeforeTouchSize = new System.Drawing.Size(120, 29);
            this.buttonAdv1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdv1.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdv1.ForeColor = System.Drawing.Color.White;
            this.buttonAdv1.Location = new System.Drawing.Point(183, 508);
            this.buttonAdv1.Margin = new System.Windows.Forms.Padding(0);
            this.buttonAdv1.Name = "buttonAdv1";
            this.buttonAdv1.Size = new System.Drawing.Size(120, 29);
            this.buttonAdv1.TabIndex = 13;
            this.buttonAdv1.Text = "Set";
            this.buttonAdv1.ThemeName = "Metro";
            this.buttonAdv1.Click += new System.EventHandler(this.buttonAdv1_Click);
            // 
            // buttonAdv2
            // 
            this.buttonAdv2.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.buttonAdv2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(130)))), ((int)(((byte)(195)))));
            this.buttonAdv2.BeforeTouchSize = new System.Drawing.Size(120, 29);
            this.buttonAdv2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdv2.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdv2.ForeColor = System.Drawing.Color.White;
            this.buttonAdv2.Location = new System.Drawing.Point(44, 508);
            this.buttonAdv2.Margin = new System.Windows.Forms.Padding(0);
            this.buttonAdv2.Name = "buttonAdv2";
            this.buttonAdv2.Size = new System.Drawing.Size(120, 29);
            this.buttonAdv2.TabIndex = 28;
            this.buttonAdv2.Text = "Clear";
            this.buttonAdv2.ThemeName = "Metro";
            this.buttonAdv2.Click += new System.EventHandler(this.buttonAdv2_Click);
            // 
            // imageList1
            // 
#if NET9_0_OR_GREATER
            LoadImages(this.imageList1, "ImageList1", 17);
#else
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
#endif
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "ThreeTriangle.png");
            this.imageList1.Images.SetKeyName(1, "ThreeTrafficLightsUnrimmed.png");
            this.imageList1.Images.SetKeyName(2, "ThreeTrafficLightsrimmed.png");
            this.imageList1.Images.SetKeyName(3, "ThreeSymbolsUnCircled.png");
            this.imageList1.Images.SetKeyName(4, "ThreeSymbols.png");
            this.imageList1.Images.SetKeyName(5, "ThreeStars.png");
            this.imageList1.Images.SetKeyName(6, "ThreeSigns.png");
            this.imageList1.Images.SetKeyName(7, "RedToBack.png");
            this.imageList1.Images.SetKeyName(8, "FourRating.png");
            this.imageList1.Images.SetKeyName(9, "FourArrowsGray.png");
            this.imageList1.Images.SetKeyName(10, "FourTrafficLight.png");
            this.imageList1.Images.SetKeyName(11, "FourArrowsColored.png");
            this.imageList1.Images.SetKeyName(12, "FiveArrowsColored.png");
            this.imageList1.Images.SetKeyName(13, "FiveArrowsGray.png");
            this.imageList1.Images.SetKeyName(14, "FiveBoxes.png");
            this.imageList1.Images.SetKeyName(15, "FiveQuarters.png");
            this.imageList1.Images.SetKeyName(16, "FiveRatings.png");
            // 
            // pivotGridControl1
            // 
            this.pivotGridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pivotGridControl1.EditManager = null;
            this.pivotGridControl1.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro;
            this.pivotGridControl1.Location = new System.Drawing.Point(0, 8);
            this.pivotGridControl1.Margin = new System.Windows.Forms.Padding(0);
            this.pivotGridControl1.Name = "pivotGridControl1";
            this.pivotGridControl1.Size = new System.Drawing.Size(707, 554);
            this.pivotGridControl1.TabIndex = 0;
            this.pivotGridControl1.Text = "pivotGridControl1";
            this.pivotGridControl1.ThemeName = "Metro";
            this.pivotGridControl1.UpdateManager = null;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(716, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(324, 562);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pivotGridControl1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(716, 562);
            this.panel2.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.CaptionAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.CaptionBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.CaptionBarHeight = 50;
            this.CaptionButtonColor = System.Drawing.Color.White;
            this.CaptionButtonHoverColor = System.Drawing.Color.White;
            this.CaptionFont = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CaptionForeColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1040, 562);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(0);
            this.MetroColor = System.Drawing.Color.Transparent;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conditional Formatting";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.pnlRule1.ResumeLayout(false);
            this.pnlRule1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboRule1FormatStyle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboRule1SummaryElement)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboRule1ImageName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdDropDown)).EndInit();
            this.pnlRule2.ResumeLayout(false);
            this.pnlRule2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboRule2SummaryElement)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboRule2predicateType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboRule2ConditionType)).EndInit();
            this.pnlRule2Value.ResumeLayout(false);
            this.pnlRule2Value.PerformLayout();
            this.pnlRule3.ResumeLayout(false);
            this.pnlRule3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboRule3SummaryElement)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboRule3FormatRankType)).EndInit();
            this.pnlRule1Value.ResumeLayout(false);
            this.pnlRule1Value.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboValueType4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboValueType3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboValueType2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtValue4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtValue3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtValue2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtValue1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboValueType1)).EndInit();
            this.pnlRule4.ResumeLayout(false);
            this.pnlRule4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboRule4SummaryElement)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboRule4FormatValueType)).EndInit();
            this.pnlRule5.ResumeLayout(false);
            this.pnlRule5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboRule5SummaryElement)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboRule5FormatAllType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdRuleType)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        
        private Syncfusion.Windows.Forms.PivotAnalysis.PivotGridControl pivotGridControl1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblFormatStyle;
        private System.Windows.Forms.Label lblValueType;
        private System.Windows.Forms.Label lblImageName;
        private System.Windows.Forms.Label lblSummaryElement;
        private System.Windows.Forms.Label lblPredicateType;
        private System.Windows.Forms.Label lblFormatValueType;
        private System.Windows.Forms.Label lblFormatRankType;
        private System.Windows.Forms.Label lblFormatAllType;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv cboRule1FormatStyle;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv cboValueType1;
        private Syncfusion.Windows.Forms.Tools.ComboDropDown cboRule1ImageName;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv cboRule1SummaryElement;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv cboRule2predicateType;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv cboRule3FormatRankType;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv cboRule5FormatAllType;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv cboRule2ConditionType;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv cboRule4FormatValueType;
        private System.Windows.Forms.ImageList imageList1;
        private Syncfusion.Windows.Forms.Grid.GridListControl grdRuleType;
		private Syncfusion.Windows.Forms.Grid.GridListControl grdDropDown;
        private System.Windows.Forms.Panel pnlRule1;
        private System.Windows.Forms.Panel pnlRule1Value;
        private System.Windows.Forms.Label label1;
        private Syncfusion.Windows.Forms.Tools.NumericTextBox txtValue4;
        private Syncfusion.Windows.Forms.Tools.NumericTextBox txtValue3;
        private Syncfusion.Windows.Forms.Tools.NumericTextBox txtValue2;
        private Syncfusion.Windows.Forms.Tools.NumericTextBox txtValue1;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv cboValueType4;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv cboValueType3;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv cboValueType2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlRule2;
        private System.Windows.Forms.Panel pnlRule2Value;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv cboRule2SummaryElement;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblConditionType;
        private System.Windows.Forms.Label lblRule2And;
        private System.Windows.Forms.TextBox txtRule2EndValue;
        private System.Windows.Forms.TextBox txtRule2StartValue;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtRule3RankValue;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel pnlRule3;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv cboRule3SummaryElement;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pnlRule5;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv cboRule5SummaryElement;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel pnlRule4;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv cboRule4SummaryElement;
        private System.Windows.Forms.Label label8;
        private Syncfusion.Windows.Forms.ButtonAdv buttonAdv1;
        private Syncfusion.Windows.Forms.ButtonAdv buttonAdv2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}
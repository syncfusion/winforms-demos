#region Copyright Syncfusion Inc. 2001-2019.
// Copyright Syncfusion Inc. 2001-2019. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Syncfusion.Windows.Forms.Tools;

namespace SfNumericTextBoxDemo
{
    partial class GettingStarted
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
            this.WatermarkLabel = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.NumericLabel = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.ValueRangeLabel = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.PercentageLabel = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.CustomUnitLabel = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.CurrencyLabel = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.RTLLabel = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.ValidationLabel = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.ValidationTextBox = new Syncfusion.WinForms.Input.SfNumericTextBox();
            this.RTLTextBox = new Syncfusion.WinForms.Input.SfNumericTextBox();
            this.MinMaxTextBox = new Syncfusion.WinForms.Input.SfNumericTextBox();
            this.PrefixSuffixTextBox = new Syncfusion.WinForms.Input.SfNumericTextBox();
            this.WatermarkTextBox = new Syncfusion.WinForms.Input.SfNumericTextBox();
            this.CurrencyTextBox = new Syncfusion.WinForms.Input.SfNumericTextBox();
            this.PercentageTextBox = new Syncfusion.WinForms.Input.SfNumericTextBox();
            this.NumericTextBox = new Syncfusion.WinForms.Input.SfNumericTextBox();
            this.autoLabel10 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.sfComboBox1 = new Syncfusion.WinForms.ListView.SfComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sfComboBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // WatermarkLabel
            // 
            this.WatermarkLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.WatermarkLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WatermarkLabel.Location = new System.Drawing.Point(316, 105);
            this.WatermarkLabel.Name = "WatermarkLabel";
            this.WatermarkLabel.Size = new System.Drawing.Size(71, 17);
            this.WatermarkLabel.TabIndex = 6;
            this.WatermarkLabel.Text = "Watermark";
            this.WatermarkLabel.ThemeStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            // 
            // NumericLabel
            // 
            this.NumericLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.NumericLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumericLabel.Location = new System.Drawing.Point(17, 105);
            this.NumericLabel.Name = "NumericLabel";
            this.NumericLabel.Size = new System.Drawing.Size(57, 17);
            this.NumericLabel.TabIndex = 7;
            this.NumericLabel.Text = "Numeric";
            this.NumericLabel.ThemeStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            // 
            // ValueRangeLabel
            // 
            this.ValueRangeLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ValueRangeLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ValueRangeLabel.Location = new System.Drawing.Point(316, 197);
            this.ValueRangeLabel.Name = "ValueRangeLabel";
            this.ValueRangeLabel.Size = new System.Drawing.Size(137, 17);
            this.ValueRangeLabel.TabIndex = 8;
            this.ValueRangeLabel.Text = "Value range (0 to 100)";
            this.ValueRangeLabel.ThemeStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            // 
            // PercentageLabel
            // 
            this.PercentageLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PercentageLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PercentageLabel.Location = new System.Drawing.Point(17, 197);
            this.PercentageLabel.Name = "PercentageLabel";
            this.PercentageLabel.Size = new System.Drawing.Size(51, 17);
            this.PercentageLabel.TabIndex = 9;
            this.PercentageLabel.Text = "Percent";
            this.PercentageLabel.ThemeStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            // 
            // CustomUnitLabel
            // 
            this.CustomUnitLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CustomUnitLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomUnitLabel.Location = new System.Drawing.Point(316, 290);
            this.CustomUnitLabel.Name = "CustomUnitLabel";
            this.CustomUnitLabel.Size = new System.Drawing.Size(77, 17);
            this.CustomUnitLabel.TabIndex = 10;
            this.CustomUnitLabel.Text = "Custom unit";
            this.CustomUnitLabel.ThemeStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            // 
            // CurrencyLabel
            // 
            this.CurrencyLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CurrencyLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrencyLabel.Location = new System.Drawing.Point(17, 290);
            this.CurrencyLabel.Name = "CurrencyLabel";
            this.CurrencyLabel.Size = new System.Drawing.Size(59, 17);
            this.CurrencyLabel.TabIndex = 11;
            this.CurrencyLabel.Text = "Currency";
            this.CurrencyLabel.ThemeStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            // 
            // RTLLabel
            // 
            this.RTLLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RTLLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RTLLabel.Location = new System.Drawing.Point(17, 382);
            this.RTLLabel.Name = "RTLLabel";
            this.RTLLabel.Size = new System.Drawing.Size(76, 17);
            this.RTLLabel.TabIndex = 18;
            this.RTLLabel.Text = "Right to left";
            this.RTLLabel.ThemeStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            // 
            // ValidationLabel
            // 
            this.ValidationLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ValidationLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ValidationLabel.Location = new System.Drawing.Point(316, 382);
            this.ValidationLabel.Name = "ValidationLabel";
            this.ValidationLabel.Size = new System.Drawing.Size(170, 17);
            this.ValidationLabel.TabIndex = 17;
            this.ValidationLabel.Text = "Validation (10 digit number)";
            this.ValidationLabel.ThemeStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // ValidationTextBox
            // 
            this.ValidationTextBox.AllowNull = true;
            this.ValidationTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ValidationTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ValidationTextBox.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.ValidationTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ValidationTextBox.HideTrailingZeros = true;
            this.ValidationTextBox.Location = new System.Drawing.Point(319, 406);
            this.ValidationTextBox.MinValue = 0D;
            this.ValidationTextBox.Name = "ValidationTextBox";
            this.ValidationTextBox.Size = new System.Drawing.Size(179, 25);
            this.ValidationTextBox.Suffix = "";
            this.ValidationTextBox.TabIndex = 16;
            this.ValidationTextBox.Text = "";
            this.ValidationTextBox.ThemeName = null;
            this.ValidationTextBox.Value = null;
            this.ValidationTextBox.ValueChangeMode = Syncfusion.WinForms.Input.Enums.ValueChangeMode.KeyPress;
            this.ValidationTextBox.WatermarkText = "Enter mobile number";
            // 
            // RTLTextBox
            // 
            this.RTLTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RTLTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RTLTextBox.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.RTLTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.RTLTextBox.Location = new System.Drawing.Point(20, 406);
            this.RTLTextBox.Name = "RTLTextBox";
            this.RTLTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RTLTextBox.Size = new System.Drawing.Size(179, 25);
            this.RTLTextBox.TabIndex = 15;
            this.RTLTextBox.Text = "123.00";
            this.RTLTextBox.ThemeName = null;
            this.RTLTextBox.Value = 123D;
            // 
            // MinMaxTextBox
            // 
            this.MinMaxTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MinMaxTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MinMaxTextBox.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.MinMaxTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.MinMaxTextBox.Location = new System.Drawing.Point(319, 221);
            this.MinMaxTextBox.MaxValue = 100D;
            this.MinMaxTextBox.MinValue = 0D;
            this.MinMaxTextBox.Name = "MinMaxTextBox";
            this.MinMaxTextBox.Size = new System.Drawing.Size(179, 25);
            this.MinMaxTextBox.TabIndex = 4;
            this.MinMaxTextBox.Text = "10.00";
            this.MinMaxTextBox.ThemeName = null;
            this.MinMaxTextBox.Value = 10D;
            // 
            // PrefixSuffixTextBox
            // 
            this.PrefixSuffixTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PrefixSuffixTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PrefixSuffixTextBox.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.PrefixSuffixTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.PrefixSuffixTextBox.HideTrailingZeros = true;
            this.PrefixSuffixTextBox.Location = new System.Drawing.Point(319, 314);
            this.PrefixSuffixTextBox.Name = "PrefixSuffixTextBox";
            this.PrefixSuffixTextBox.Size = new System.Drawing.Size(179, 25);
            this.PrefixSuffixTextBox.Suffix = "inches";
            this.PrefixSuffixTextBox.TabIndex = 6;
            this.PrefixSuffixTextBox.Text = "10 inches";
            this.PrefixSuffixTextBox.ThemeName = null;
            this.PrefixSuffixTextBox.Value = 10D;
            // 
            // WatermarkTextBox
            // 
            this.WatermarkTextBox.AllowNull = true;
            this.WatermarkTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.WatermarkTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.WatermarkTextBox.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.WatermarkTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.WatermarkTextBox.HideTrailingZeros = true;
            this.WatermarkTextBox.Location = new System.Drawing.Point(319, 129);
            this.WatermarkTextBox.MaxValue = 100D;
            this.WatermarkTextBox.MinValue = 0D;
            this.WatermarkTextBox.Name = "WatermarkTextBox";
            this.WatermarkTextBox.Size = new System.Drawing.Size(179, 25);
            this.WatermarkTextBox.TabIndex = 2;
            this.WatermarkTextBox.Text = "";
            this.WatermarkTextBox.ThemeName = null;
            this.WatermarkTextBox.ValidationMode = Syncfusion.WinForms.Input.Enums.ValidationMode.KeyPress;
            this.WatermarkTextBox.Value = null;
            this.WatermarkTextBox.ValueChangeMode = Syncfusion.WinForms.Input.Enums.ValueChangeMode.KeyPress;
            this.WatermarkTextBox.WatermarkText = "Enter your age";
            // 
            // CurrencyTextBox
            // 
            this.CurrencyTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CurrencyTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CurrencyTextBox.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.CurrencyTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.CurrencyTextBox.FormatMode = Syncfusion.WinForms.Input.Enums.FormatMode.Currency;
            this.CurrencyTextBox.Location = new System.Drawing.Point(20, 314);
            this.CurrencyTextBox.Name = "CurrencyTextBox";
            this.CurrencyTextBox.Size = new System.Drawing.Size(179, 25);
            this.CurrencyTextBox.TabIndex = 5;
            this.CurrencyTextBox.Text = "$123.00";
            this.CurrencyTextBox.ThemeName = null;
            this.CurrencyTextBox.Value = 123D;
            // 
            // PercentageTextBox
            // 
            this.PercentageTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PercentageTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PercentageTextBox.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.PercentageTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.PercentageTextBox.FormatMode = Syncfusion.WinForms.Input.Enums.FormatMode.Percent;
            this.PercentageTextBox.Location = new System.Drawing.Point(20, 221);
            this.PercentageTextBox.Name = "PercentageTextBox";
            this.PercentageTextBox.Size = new System.Drawing.Size(179, 25);
            this.PercentageTextBox.TabIndex = 3;
            this.PercentageTextBox.Text = "123.00%";
            this.PercentageTextBox.ThemeName = null;
            this.PercentageTextBox.Value = 123D;
            // 
            // NumericTextBox
            // 
            this.NumericTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.NumericTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NumericTextBox.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.NumericTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.NumericTextBox.Location = new System.Drawing.Point(20, 129);
            this.NumericTextBox.Name = "NumericTextBox";
            this.NumericTextBox.Size = new System.Drawing.Size(179, 25);
            this.NumericTextBox.TabIndex = 1;
            this.NumericTextBox.Text = "123.00";
            this.NumericTextBox.ThemeName = null;
            this.NumericTextBox.Value = 123D;
            // 
            // autoLabel10
            // 
            this.autoLabel10.BackColor = System.Drawing.SystemColors.Control;
            this.autoLabel10.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoLabel10.ForeColor = System.Drawing.SystemColors.ControlText;
            this.autoLabel10.Location = new System.Drawing.Point(229, 27);
            this.autoLabel10.Name = "autoLabel10";
            this.autoLabel10.Size = new System.Drawing.Size(98, 19);
            this.autoLabel10.TabIndex = 108;
            this.autoLabel10.Text = "Choose theme";
            this.autoLabel10.ThemeName = "Default";
            this.autoLabel10.ThemeStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            // 
            // sfComboBox1
            // 
            this.sfComboBox1.DropDownStyle = Syncfusion.WinForms.ListView.Enums.DropDownStyle.DropDownList;
            this.sfComboBox1.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sfComboBox1.Location = new System.Drawing.Point(325, 27);
            this.sfComboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.sfComboBox1.Name = "sfComboBox1";
            this.sfComboBox1.Size = new System.Drawing.Size(179, 20);
            this.sfComboBox1.Style.DropDownStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.sfComboBox1.Style.EditorStyle.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sfComboBox1.Style.ReadOnlyEditorStyle.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sfComboBox1.TabIndex = 107;
            this.sfComboBox1.SelectedIndexChanged += new System.EventHandler(this.sfComboBox1_SelectedIndexChanged);
            // 
            // GettingStarted
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 455);
            this.Controls.Add(this.autoLabel10);
            this.Controls.Add(this.sfComboBox1);
            this.Controls.Add(this.ValidationTextBox);
            this.Controls.Add(this.RTLTextBox);
            this.Controls.Add(this.RTLLabel);
            this.Controls.Add(this.ValidationLabel);
            this.Controls.Add(this.MinMaxTextBox);
            this.Controls.Add(this.PrefixSuffixTextBox);
            this.Controls.Add(this.WatermarkTextBox);
            this.Controls.Add(this.CurrencyTextBox);
            this.Controls.Add(this.PercentageTextBox);
            this.Controls.Add(this.NumericTextBox);
            this.Controls.Add(this.CurrencyLabel);
            this.Controls.Add(this.CustomUnitLabel);
            this.Controls.Add(this.PercentageLabel);
            this.Controls.Add(this.ValueRangeLabel);
            this.Controls.Add(this.NumericLabel);
            this.Controls.Add(this.WatermarkLabel);
            this.Name = "GettingStarted";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Numeric TextBox";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sfComboBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private AutoLabel WatermarkLabel;
        private AutoLabel NumericLabel;
        private AutoLabel ValueRangeLabel;
        private AutoLabel PercentageLabel;
        private AutoLabel CustomUnitLabel;
        private AutoLabel CurrencyLabel;
        private Syncfusion.WinForms.Input.SfNumericTextBox NumericTextBox;
        private Syncfusion.WinForms.Input.SfNumericTextBox PercentageTextBox;
        private Syncfusion.WinForms.Input.SfNumericTextBox CurrencyTextBox;
        private Syncfusion.WinForms.Input.SfNumericTextBox WatermarkTextBox;
        private Syncfusion.WinForms.Input.SfNumericTextBox PrefixSuffixTextBox;
        private Syncfusion.WinForms.Input.SfNumericTextBox MinMaxTextBox;
        private Syncfusion.WinForms.Input.SfNumericTextBox ValidationTextBox;
        private Syncfusion.WinForms.Input.SfNumericTextBox RTLTextBox;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel10;
        private Syncfusion.WinForms.ListView.SfComboBox sfComboBox1;
        private AutoLabel RTLLabel;
        private AutoLabel ValidationLabel;
    }
}
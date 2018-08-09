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
            this.WatermarkLabel = new System.Windows.Forms.Label();
            this.NumericLabel = new System.Windows.Forms.Label();
            this.ValueRangeLabel = new System.Windows.Forms.Label();
            this.PercentageLabel = new System.Windows.Forms.Label();
            this.CustomUnitLabel = new System.Windows.Forms.Label();
            this.CurrencyLabel = new System.Windows.Forms.Label();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.DescriptionPanel = new System.Windows.Forms.Panel();
            this.SeparatorPanel = new System.Windows.Forms.Panel();
            this.RTLLabel = new System.Windows.Forms.Label();
            this.ValidationLabel = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.ValidationTextBox = new Syncfusion.WinForms.Input.SfNumericTextBox();
            this.RTLTextBox = new Syncfusion.WinForms.Input.SfNumericTextBox();
            this.MinMaxTextBox = new Syncfusion.WinForms.Input.SfNumericTextBox();
            this.PrefixSuffixTextBox = new Syncfusion.WinForms.Input.SfNumericTextBox();
            this.WatermarkTextBox = new Syncfusion.WinForms.Input.SfNumericTextBox();
            this.CurrencyTextBox = new Syncfusion.WinForms.Input.SfNumericTextBox();
            this.PercentageTextBox = new Syncfusion.WinForms.Input.SfNumericTextBox();
            this.NumericTextBox = new Syncfusion.WinForms.Input.SfNumericTextBox();
            this.DescriptionPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // WatermarkLabel
            // 
            this.WatermarkLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.WatermarkLabel.AutoSize = true;
            this.WatermarkLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WatermarkLabel.Location = new System.Drawing.Point(523, 123);
            this.WatermarkLabel.Name = "WatermarkLabel";
            this.WatermarkLabel.Size = new System.Drawing.Size(71, 17);
            this.WatermarkLabel.TabIndex = 6;
            this.WatermarkLabel.Text = "Watermark";
            // 
            // NumericLabel
            // 
            this.NumericLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.NumericLabel.AutoSize = true;
            this.NumericLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumericLabel.Location = new System.Drawing.Point(134, 123);
            this.NumericLabel.Name = "NumericLabel";
            this.NumericLabel.Size = new System.Drawing.Size(57, 17);
            this.NumericLabel.TabIndex = 7;
            this.NumericLabel.Text = "Numeric";
            // 
            // ValueRangeLabel
            // 
            this.ValueRangeLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ValueRangeLabel.AutoSize = true;
            this.ValueRangeLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ValueRangeLabel.Location = new System.Drawing.Point(523, 226);
            this.ValueRangeLabel.Name = "ValueRangeLabel";
            this.ValueRangeLabel.Size = new System.Drawing.Size(137, 17);
            this.ValueRangeLabel.TabIndex = 8;
            this.ValueRangeLabel.Text = "Value range (0 to 100)";
            // 
            // PercentageLabel
            // 
            this.PercentageLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PercentageLabel.AutoSize = true;
            this.PercentageLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PercentageLabel.Location = new System.Drawing.Point(134, 226);
            this.PercentageLabel.Name = "PercentageLabel";
            this.PercentageLabel.Size = new System.Drawing.Size(51, 17);
            this.PercentageLabel.TabIndex = 9;
            this.PercentageLabel.Text = "Percent";
            // 
            // CustomUnitLabel
            // 
            this.CustomUnitLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CustomUnitLabel.AutoSize = true;
            this.CustomUnitLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomUnitLabel.Location = new System.Drawing.Point(523, 342);
            this.CustomUnitLabel.Name = "CustomUnitLabel";
            this.CustomUnitLabel.Size = new System.Drawing.Size(77, 17);
            this.CustomUnitLabel.TabIndex = 10;
            this.CustomUnitLabel.Text = "Custom unit";
            // 
            // CurrencyLabel
            // 
            this.CurrencyLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CurrencyLabel.AutoSize = true;
            this.CurrencyLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrencyLabel.Location = new System.Drawing.Point(134, 342);
            this.CurrencyLabel.Name = "CurrencyLabel";
            this.CurrencyLabel.Size = new System.Drawing.Size(59, 17);
            this.CurrencyLabel.TabIndex = 11;
            this.CurrencyLabel.Text = "Currency";
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.AutoEllipsis = true;
            this.DescriptionLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DescriptionLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 10.75F, System.Drawing.FontStyle.Bold);
            this.DescriptionLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.DescriptionLabel.Location = new System.Drawing.Point(0, 4);
            this.DescriptionLabel.MaximumSize = new System.Drawing.Size(0, 400);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(838, 51);
            this.DescriptionLabel.TabIndex = 12;
            this.DescriptionLabel.Text = "The following sample demonstrates the default functionalities of the NumericTextB" +
    "ox such as format mode, right to left, watermark, value range, custom unit and v" +
    "alidation.";
            // 
            // DescriptionPanel
            // 
            this.DescriptionPanel.Controls.Add(this.DescriptionLabel);
            this.DescriptionPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.DescriptionPanel.Location = new System.Drawing.Point(0, 0);
            this.DescriptionPanel.Name = "DescriptionPanel";
            this.DescriptionPanel.Size = new System.Drawing.Size(838, 55);
            this.DescriptionPanel.TabIndex = 13;
            // 
            // SeparatorPanel
            // 
            this.SeparatorPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.SeparatorPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.SeparatorPanel.Location = new System.Drawing.Point(0, 55);
            this.SeparatorPanel.Name = "SeparatorPanel";
            this.SeparatorPanel.Size = new System.Drawing.Size(838, 3);
            this.SeparatorPanel.TabIndex = 14;
            // 
            // RTLLabel
            // 
            this.RTLLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RTLLabel.AutoSize = true;
            this.RTLLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RTLLabel.Location = new System.Drawing.Point(134, 456);
            this.RTLLabel.Name = "RTLLabel";
            this.RTLLabel.Size = new System.Drawing.Size(76, 17);
            this.RTLLabel.TabIndex = 18;
            this.RTLLabel.Text = "Right to left";
            // 
            // ValidationLabel
            // 
            this.ValidationLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ValidationLabel.AutoSize = true;
            this.ValidationLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ValidationLabel.Location = new System.Drawing.Point(523, 456);
            this.ValidationLabel.Name = "ValidationLabel";
            this.ValidationLabel.Size = new System.Drawing.Size(170, 17);
            this.ValidationLabel.TabIndex = 17;
            this.ValidationLabel.Text = "Validation (10 digit number)";
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
            this.ValidationTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ValidationTextBox.HideTrailingZeros = true;
            this.ValidationTextBox.Location = new System.Drawing.Point(526, 480);
            this.ValidationTextBox.MinValue = 0D;
            this.ValidationTextBox.Name = "ValidationTextBox";
            this.ValidationTextBox.Size = new System.Drawing.Size(179, 20);
            this.ValidationTextBox.Suffix = "";
            this.ValidationTextBox.TabIndex = 16;
            this.ValidationTextBox.Text = "";
            this.ValidationTextBox.Value = null;
            this.ValidationTextBox.ValueChangeMode = Syncfusion.WinForms.Input.Enums.ValueChangeMode.KeyPress;
            this.ValidationTextBox.WatermarkText = "Enter mobile number";
            // 
            // RTLTextBox
            // 
            this.RTLTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RTLTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RTLTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.RTLTextBox.Location = new System.Drawing.Point(137, 480);
            this.RTLTextBox.Name = "RTLTextBox";
            this.RTLTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RTLTextBox.Size = new System.Drawing.Size(180, 20);
            this.RTLTextBox.TabIndex = 15;
            this.RTLTextBox.Text = "123.00";
            this.RTLTextBox.Value = 123D;
            // 
            // MinMaxTextBox
            // 
            this.MinMaxTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MinMaxTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MinMaxTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.MinMaxTextBox.Location = new System.Drawing.Point(526, 250);
            this.MinMaxTextBox.MaxValue = 100D;
            this.MinMaxTextBox.MinValue = 0D;
            this.MinMaxTextBox.Name = "MinMaxTextBox";
            this.MinMaxTextBox.Size = new System.Drawing.Size(179, 20);
            this.MinMaxTextBox.TabIndex = 4;
            this.MinMaxTextBox.Text = "10.00";
            this.MinMaxTextBox.Value = 10D;
            // 
            // PrefixSuffixTextBox
            // 
            this.PrefixSuffixTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PrefixSuffixTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PrefixSuffixTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.PrefixSuffixTextBox.HideTrailingZeros = true;
            this.PrefixSuffixTextBox.Location = new System.Drawing.Point(526, 366);
            this.PrefixSuffixTextBox.Name = "PrefixSuffixTextBox";
            this.PrefixSuffixTextBox.Size = new System.Drawing.Size(179, 20);
            this.PrefixSuffixTextBox.Suffix = "inches";
            this.PrefixSuffixTextBox.TabIndex = 6;
            this.PrefixSuffixTextBox.Text = "10 inches";
            this.PrefixSuffixTextBox.Value = 10D;
            // 
            // WatermarkTextBox
            // 
            this.WatermarkTextBox.AllowNull = true;
            this.WatermarkTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.WatermarkTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.WatermarkTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.WatermarkTextBox.HideTrailingZeros = true;
            this.WatermarkTextBox.Location = new System.Drawing.Point(526, 147);
            this.WatermarkTextBox.MaxValue = 100D;
            this.WatermarkTextBox.MinValue = 0D;
            this.WatermarkTextBox.Name = "WatermarkTextBox";
            this.WatermarkTextBox.Size = new System.Drawing.Size(179, 20);
            this.WatermarkTextBox.TabIndex = 2;
            this.WatermarkTextBox.Text = "";
            this.WatermarkTextBox.ValidationMode = Syncfusion.WinForms.Input.Enums.ValidationMode.KeyPress;
            this.WatermarkTextBox.Value = null;
            this.WatermarkTextBox.ValueChangeMode = Syncfusion.WinForms.Input.Enums.ValueChangeMode.KeyPress;
            this.WatermarkTextBox.WatermarkText = "Enter your age";
            // 
            // CurrencyTextBox
            // 
            this.CurrencyTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CurrencyTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CurrencyTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.CurrencyTextBox.FormatMode = Syncfusion.WinForms.Input.Enums.FormatMode.Currency;
            this.CurrencyTextBox.Location = new System.Drawing.Point(137, 366);
            this.CurrencyTextBox.Name = "CurrencyTextBox";
            this.CurrencyTextBox.Size = new System.Drawing.Size(180, 20);
            this.CurrencyTextBox.TabIndex = 5;
            this.CurrencyTextBox.Text = "$123.00";
            this.CurrencyTextBox.Value = 123D;
            // 
            // PercentageTextBox
            // 
            this.PercentageTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PercentageTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PercentageTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.PercentageTextBox.FormatMode = Syncfusion.WinForms.Input.Enums.FormatMode.Percent;
            this.PercentageTextBox.Location = new System.Drawing.Point(137, 250);
            this.PercentageTextBox.Name = "PercentageTextBox";
            this.PercentageTextBox.Size = new System.Drawing.Size(180, 20);
            this.PercentageTextBox.TabIndex = 3;
            this.PercentageTextBox.Text = "123.00 %";
            this.PercentageTextBox.Value = 123D;
            // 
            // NumericTextBox
            // 
            this.NumericTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.NumericTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NumericTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.NumericTextBox.Location = new System.Drawing.Point(138, 147);
            this.NumericTextBox.Name = "NumericTextBox";
            this.NumericTextBox.Size = new System.Drawing.Size(179, 20);
            this.NumericTextBox.TabIndex = 1;
            this.NumericTextBox.Text = "123.00";
            this.NumericTextBox.Value = 123D;
            // 
            // GettingStarted
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.BorderThickness = 10;
            this.CaptionAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.CaptionBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.CaptionBarHeight = 45;
            this.CaptionButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.CaptionButtonHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.CaptionFont = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.CaptionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(838, 602);
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
            this.Controls.Add(this.SeparatorPanel);
            this.Controls.Add(this.DescriptionPanel);
            this.Controls.Add(this.CurrencyLabel);
            this.Controls.Add(this.CustomUnitLabel);
            this.Controls.Add(this.PercentageLabel);
            this.Controls.Add(this.ValueRangeLabel);
            this.Controls.Add(this.NumericLabel);
            this.Controls.Add(this.WatermarkLabel);
            this.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.MinimumSize = new System.Drawing.Size(850, 550);
            this.Name = "GettingStarted";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Getting Started";
            this.DescriptionPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label WatermarkLabel;
        private System.Windows.Forms.Label NumericLabel;
        private System.Windows.Forms.Label ValueRangeLabel;
        private System.Windows.Forms.Label PercentageLabel;
        private System.Windows.Forms.Label CustomUnitLabel;
        private System.Windows.Forms.Label CurrencyLabel;
        private System.Windows.Forms.Label DescriptionLabel;
        private System.Windows.Forms.Panel DescriptionPanel;
        private System.Windows.Forms.Panel SeparatorPanel;
        private Syncfusion.WinForms.Input.SfNumericTextBox NumericTextBox;
        private Syncfusion.WinForms.Input.SfNumericTextBox PercentageTextBox;
        private Syncfusion.WinForms.Input.SfNumericTextBox CurrencyTextBox;
        private Syncfusion.WinForms.Input.SfNumericTextBox WatermarkTextBox;
        private Syncfusion.WinForms.Input.SfNumericTextBox PrefixSuffixTextBox;
        private Syncfusion.WinForms.Input.SfNumericTextBox MinMaxTextBox;
        private Syncfusion.WinForms.Input.SfNumericTextBox ValidationTextBox;
        private Syncfusion.WinForms.Input.SfNumericTextBox RTLTextBox;
        private System.Windows.Forms.Label RTLLabel;
        private System.Windows.Forms.Label ValidationLabel;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}
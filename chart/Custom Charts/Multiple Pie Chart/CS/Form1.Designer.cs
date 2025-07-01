#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
namespace MultiplePieChart_2005
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.chartControl1 = new Syncfusion.Windows.Forms.Chart.ChartControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.cbBxPieType = new System.Windows.Forms.ComboBox();
            this.ckBxDisplayText = new System.Windows.Forms.CheckBox();
            this.nUpDownPieHeight = new System.Windows.Forms.NumericUpDown();
            this.lblPieHeight = new System.Windows.Forms.Label();
            this.ckBxEnable3D = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUpDownPieHeight)).BeginInit();
            this.SuspendLayout();
            // 
            // chartControl1
            // 
            this.chartControl1.ChartArea.CursorLocation = new System.Drawing.Point(0, 0);
            this.chartControl1.ChartArea.CursorReDraw = false;
            this.chartControl1.DataSourceName = "";
            this.chartControl1.IsWindowLess = false;
            // 
            // 
            // 
            this.chartControl1.Legend.Location = new System.Drawing.Point(591, 75);
            this.chartControl1.Localize = null;
            this.chartControl1.Location = new System.Drawing.Point(0, 0);
            this.chartControl1.Name = "chartControl1";
            this.chartControl1.PrimaryXAxis.Crossing = double.NaN;
            this.chartControl1.PrimaryXAxis.Margin = true;
            this.chartControl1.PrimaryYAxis.Crossing = double.NaN;
            this.chartControl1.PrimaryYAxis.ForceZero = true;
            this.chartControl1.PrimaryYAxis.Margin = true;
            this.chartControl1.Size = new System.Drawing.Size(700, 547);
            this.chartControl1.TabIndex = 0;
            this.chartControl1.Text = "chartControl1";
            // 
            // 
            // 
            this.chartControl1.Title.Name = "Default";
            this.chartControl1.Titles.Add(this.chartControl1.Title);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cbBxPieType);
            this.panel1.Controls.Add(this.ckBxDisplayText);
            this.panel1.Controls.Add(this.nUpDownPieHeight);
            this.panel1.Controls.Add(this.lblPieHeight);
            this.panel1.Controls.Add(this.ckBxEnable3D);
            this.panel1.Location = new System.Drawing.Point(700, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(260, 636);
            this.panel1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label2.Location = new System.Drawing.Point(39, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 21);
            this.label2.TabIndex = 12;
            this.label2.Text = "Pie Style";
            // 
            // cbBxPieType
            // 
            this.cbBxPieType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBxPieType.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBxPieType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.cbBxPieType.FormattingEnabled = true;
            this.cbBxPieType.Location = new System.Drawing.Point(42, 59);
            this.cbBxPieType.Name = "cbBxPieType";
            this.cbBxPieType.Size = new System.Drawing.Size(180, 29);
            this.cbBxPieType.TabIndex = 11;
            this.cbBxPieType.SelectedIndexChanged += new System.EventHandler(this.cbBxPieType_SelectedIndexChanged);
            // 
            // ckBxDisplayText
            // 
            this.ckBxDisplayText.AutoSize = true;
            this.ckBxDisplayText.Checked = true;
            this.ckBxDisplayText.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckBxDisplayText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckBxDisplayText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.ckBxDisplayText.Location = new System.Drawing.Point(43, 102);
            this.ckBxDisplayText.Name = "ckBxDisplayText";
            this.ckBxDisplayText.Size = new System.Drawing.Size(112, 25);
            this.ckBxDisplayText.TabIndex = 10;
            this.ckBxDisplayText.Text = "Display Text";
            this.ckBxDisplayText.UseVisualStyleBackColor = true;
            this.ckBxDisplayText.CheckedChanged += new System.EventHandler(this.ckBxDisplayText_CheckedChanged);
            // 
            // nUpDownPieHeight
            // 
            this.nUpDownPieHeight.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nUpDownPieHeight.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.nUpDownPieHeight.Location = new System.Drawing.Point(43, 201);
            this.nUpDownPieHeight.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.nUpDownPieHeight.Minimum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.nUpDownPieHeight.Name = "nUpDownPieHeight";
            this.nUpDownPieHeight.Size = new System.Drawing.Size(180, 29);
            this.nUpDownPieHeight.TabIndex = 9;
            this.nUpDownPieHeight.Value = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.nUpDownPieHeight.Visible = false;
            this.nUpDownPieHeight.ValueChanged += new System.EventHandler(this.nUpDownPieHeight_ValueChanged);
            // 
            // lblPieHeight
            // 
            this.lblPieHeight.AutoSize = true;
            this.lblPieHeight.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPieHeight.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.lblPieHeight.Location = new System.Drawing.Point(39, 166);
            this.lblPieHeight.Name = "lblPieHeight";
            this.lblPieHeight.Size = new System.Drawing.Size(81, 21);
            this.lblPieHeight.TabIndex = 8;
            this.lblPieHeight.Text = "Pie Height";
            this.lblPieHeight.Visible = false;
            // 
            // ckBxEnable3D
            // 
            this.ckBxEnable3D.AutoSize = true;
            this.ckBxEnable3D.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckBxEnable3D.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.ckBxEnable3D.Location = new System.Drawing.Point(43, 134);
            this.ckBxEnable3D.Name = "ckBxEnable3D";
            this.ckBxEnable3D.Size = new System.Drawing.Size(99, 25);
            this.ckBxEnable3D.TabIndex = 2;
            this.ckBxEnable3D.Text = "Enable 3D";
            this.ckBxEnable3D.UseVisualStyleBackColor = true;
            this.ckBxEnable3D.CheckedChanged += new System.EventHandler(this.ckBxEnable3D_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(958, 634);
            this.Controls.Add(this.chartControl1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(767, 590);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Multiple Pie";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUpDownPieHeight)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Syncfusion.Windows.Forms.Chart.ChartControl chartControl1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox ckBxEnable3D;
        private System.Windows.Forms.Label lblPieHeight;
        private System.Windows.Forms.NumericUpDown nUpDownPieHeight;
        private System.Windows.Forms.CheckBox ckBxDisplayText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbBxPieType;
    }
}


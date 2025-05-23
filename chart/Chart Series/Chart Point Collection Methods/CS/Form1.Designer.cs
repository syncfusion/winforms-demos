#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
namespace ChartPointCollectionMethods_2005
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.txBxResult = new System.Windows.Forms.TextBox();
            this.btnResult = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txBxIndex = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txBxString = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txBxValue = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.rdBtnFindMinValue = new System.Windows.Forms.RadioButton();
            this.rdBtnFindMaxValue = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.rdBtnFindValue = new System.Windows.Forms.RadioButton();
            this.label25 = new System.Windows.Forms.Label();
            this.cbBxFindValue = new System.Windows.Forms.ComboBox();
            this.cbBxFindMaxValue = new System.Windows.Forms.ComboBox();
            this.cbBxFindMinValue = new System.Windows.Forms.ComboBox();
            this.chartControl1 = new Syncfusion.Windows.Forms.Chart.ChartControl();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.AutoScrollMargin = new System.Drawing.Size(0, 20);
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Controls.Add(this.txBxResult);
            this.panel2.Controls.Add(this.btnResult);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.txBxIndex);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txBxString);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txBxValue);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.rdBtnFindMinValue);
            this.panel2.Controls.Add(this.rdBtnFindMaxValue);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.rdBtnFindValue);
            this.panel2.Controls.Add(this.label25);
            this.panel2.Controls.Add(this.cbBxFindValue);
            this.panel2.Controls.Add(this.cbBxFindMaxValue);
            this.panel2.Controls.Add(this.cbBxFindMinValue);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.panel2.Location = new System.Drawing.Point(697, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(261, 584);
            this.panel2.TabIndex = 17;
            // 
            // txBxResult
            // 
            this.txBxResult.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txBxResult.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.txBxResult.Location = new System.Drawing.Point(42, 663);
            this.txBxResult.Name = "txBxResult";
            this.txBxResult.ReadOnly = true;
            this.txBxResult.Size = new System.Drawing.Size(174, 29);
            this.txBxResult.TabIndex = 12;
            // 
            // btnResult
            // 
            this.btnResult.BackColor = System.Drawing.Color.Gray;
            this.btnResult.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResult.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResult.ForeColor = System.Drawing.Color.White;
            this.btnResult.Location = new System.Drawing.Point(42, 614);
            this.btnResult.Name = "btnResult";
            this.btnResult.Size = new System.Drawing.Size(97, 35);
            this.btnResult.TabIndex = 5;
            this.btnResult.Text = "RESULT";
            this.btnResult.UseVisualStyleBackColor = false;
            this.btnResult.Click += new System.EventHandler(this.btnResult_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label3.Location = new System.Drawing.Point(38, 469);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 30);
            this.label3.TabIndex = 8;
            this.label3.Text = "Start Index";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.textBox1.Location = new System.Drawing.Point(42, 573);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(174, 27);
            this.textBox1.TabIndex = 15;
            // 
            // txBxIndex
            // 
            this.txBxIndex.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txBxIndex.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.txBxIndex.Location = new System.Drawing.Point(41, 501);
            this.txBxIndex.Name = "txBxIndex";
            this.txBxIndex.Size = new System.Drawing.Size(174, 27);
            this.txBxIndex.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label1.Location = new System.Drawing.Point(37, 284);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 44);
            this.label1.TabIndex = 6;
            this.label1.Text = "Enter Value (600,400,300,550,500,200)";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label4.Location = new System.Drawing.Point(38, 538);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 29);
            this.label4.TabIndex = 14;
            this.label4.Text = "End Index";
            // 
            // txBxString
            // 
            this.txBxString.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txBxString.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.txBxString.Location = new System.Drawing.Point(42, 430);
            this.txBxString.Name = "txBxString";
            this.txBxString.Size = new System.Drawing.Size(174, 27);
            this.txBxString.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label2.Location = new System.Drawing.Point(38, 376);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 44);
            this.label2.TabIndex = 7;
            this.label2.Text = "Enter \r\nString (like X,Y,Y1..)";
            // 
            // txBxValue
            // 
            this.txBxValue.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txBxValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.txBxValue.Location = new System.Drawing.Point(42, 337);
            this.txBxValue.Name = "txBxValue";
            this.txBxValue.Size = new System.Drawing.Size(173, 27);
            this.txBxValue.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label6.Location = new System.Drawing.Point(35, 66);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label6.Size = new System.Drawing.Size(185, 24);
            this.label6.TabIndex = 62;
            this.label6.Text = "Point Collection Method";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // rdBtnFindMinValue
            // 
            this.rdBtnFindMinValue.AutoSize = true;
            this.rdBtnFindMinValue.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdBtnFindMinValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.rdBtnFindMinValue.Location = new System.Drawing.Point(41, 134);
            this.rdBtnFindMinValue.Name = "rdBtnFindMinValue";
            this.rdBtnFindMinValue.Size = new System.Drawing.Size(117, 24);
            this.rdBtnFindMinValue.TabIndex = 2;
            this.rdBtnFindMinValue.TabStop = true;
            this.rdBtnFindMinValue.Text = "FindMinValue";
            this.rdBtnFindMinValue.UseVisualStyleBackColor = true;
            this.rdBtnFindMinValue.CheckedChanged += new System.EventHandler(this.rdBtnFindMinValue_CheckedChanged);
            // 
            // rdBtnFindMaxValue
            // 
            this.rdBtnFindMaxValue.AutoSize = true;
            this.rdBtnFindMaxValue.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdBtnFindMaxValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.rdBtnFindMaxValue.Location = new System.Drawing.Point(42, 171);
            this.rdBtnFindMaxValue.Name = "rdBtnFindMaxValue";
            this.rdBtnFindMaxValue.Size = new System.Drawing.Size(120, 24);
            this.rdBtnFindMaxValue.TabIndex = 1;
            this.rdBtnFindMaxValue.TabStop = true;
            this.rdBtnFindMaxValue.Text = "FindMaxValue";
            this.rdBtnFindMaxValue.UseVisualStyleBackColor = true;
            this.rdBtnFindMaxValue.CheckedChanged += new System.EventHandler(this.rdBtnFindMaxValue_CheckedChanged);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label5.Location = new System.Drawing.Point(34, 209);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(162, 24);
            this.label5.TabIndex = 61;
            this.label5.Text = "Select the method type";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // rdBtnFindValue
            // 
            this.rdBtnFindValue.AutoSize = true;
            this.rdBtnFindValue.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdBtnFindValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.rdBtnFindValue.Location = new System.Drawing.Point(42, 99);
            this.rdBtnFindValue.Name = "rdBtnFindValue";
            this.rdBtnFindValue.Size = new System.Drawing.Size(92, 24);
            this.rdBtnFindValue.TabIndex = 0;
            this.rdBtnFindValue.TabStop = true;
            this.rdBtnFindValue.Text = "FindValue";
            this.rdBtnFindValue.UseVisualStyleBackColor = true;
            this.rdBtnFindValue.CheckedChanged += new System.EventHandler(this.rdBtnFindValue_CheckedChanged);
            // 
            // label25
            // 
            this.label25.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label25.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label25.Location = new System.Drawing.Point(29, 30);
            this.label25.Name = "label25";
            this.label25.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label25.Size = new System.Drawing.Size(187, 24);
            this.label25.TabIndex = 60;
            this.label25.Text = "Find Min and Max methods";
            this.label25.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbBxFindValue
            // 
            this.cbBxFindValue.BackColor = System.Drawing.Color.White;
            this.cbBxFindValue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBxFindValue.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbBxFindValue.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBxFindValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.cbBxFindValue.FormattingEnabled = true;
            this.cbBxFindValue.Items.AddRange(new object[] {
            "FindValue(Double)",
            "FindValue(Double, String)",
            "FindValue(Double, String, Index)",
            "FindValue(Double, String, Index, Index)"});
            this.cbBxFindValue.Location = new System.Drawing.Point(41, 243);
            this.cbBxFindValue.Name = "cbBxFindValue";
            this.cbBxFindValue.Size = new System.Drawing.Size(174, 28);
            this.cbBxFindValue.TabIndex = 2;
            this.cbBxFindValue.SelectedIndexChanged += new System.EventHandler(this.cbBxFindValue_SelectedIndexChanged);
            // 
            // cbBxFindMaxValue
            // 
            this.cbBxFindMaxValue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBxFindMaxValue.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbBxFindMaxValue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBxFindMaxValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.cbBxFindMaxValue.FormattingEnabled = true;
            this.cbBxFindMaxValue.Items.AddRange(new object[] {
            "FindMaxValue()",
            "FindMaxValue(String)",
            "FindMaxValue(String, Index)",
            "FindMaxValue(String, Index, Index)"});
            this.cbBxFindMaxValue.Location = new System.Drawing.Point(41, 242);
            this.cbBxFindMaxValue.Name = "cbBxFindMaxValue";
            this.cbBxFindMaxValue.Size = new System.Drawing.Size(174, 29);
            this.cbBxFindMaxValue.TabIndex = 3;
            this.cbBxFindMaxValue.SelectedIndexChanged += new System.EventHandler(this.cbBxFindMaxValue_SelectedIndexChanged);
            // 
            // cbBxFindMinValue
            // 
            this.cbBxFindMinValue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBxFindMinValue.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbBxFindMinValue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBxFindMinValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.cbBxFindMinValue.FormattingEnabled = true;
            this.cbBxFindMinValue.Items.AddRange(new object[] {
            "FindMinValue()",
            "FindMinValue(String)",
            "FindMinValue(String, Index)",
            "FindMinValue(String, Index, Index)"});
            this.cbBxFindMinValue.Location = new System.Drawing.Point(43, 242);
            this.cbBxFindMinValue.Name = "cbBxFindMinValue";
            this.cbBxFindMinValue.Size = new System.Drawing.Size(174, 29);
            this.cbBxFindMinValue.TabIndex = 4;
            this.cbBxFindMinValue.SelectedIndexChanged += new System.EventHandler(this.cbBxFindMinValue_SelectedIndexChanged);
            // 
            // chartControl1
            // 
            this.chartControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartControl1.BackInterior = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.White, System.Drawing.Color.White);
            this.chartControl1.ChartArea.BackInterior = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.Transparent, System.Drawing.Color.Transparent);
            this.chartControl1.ChartArea.CursorLocation = new System.Drawing.Point(0, 0);
            this.chartControl1.ChartArea.CursorReDraw = false;
            this.chartControl1.ChartInterior = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.PathEllipse, System.Drawing.Color.White, System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(254))))));
            this.chartControl1.DataSourceName = "";
            this.chartControl1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chartControl1.IsWindowLess = false;
            // 
            // 
            // 
            this.chartControl1.Legend.BackInterior = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.White, System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(209)))), ((int)(((byte)(226))))));
            this.chartControl1.Legend.Location = new System.Drawing.Point(591, 31);
            this.chartControl1.Localize = null;
            this.chartControl1.Location = new System.Drawing.Point(0, 0);
            this.chartControl1.Name = "chartControl1";
            this.chartControl1.PrimaryXAxis.Crossing = double.NaN;
            this.chartControl1.PrimaryXAxis.Margin = true;
            this.chartControl1.PrimaryYAxis.Crossing = double.NaN;
            this.chartControl1.PrimaryYAxis.Margin = true;
            this.chartControl1.Size = new System.Drawing.Size(700, 572);
            this.chartControl1.TabIndex = 1;
            // 
            // 
            // 
            this.chartControl1.Title.Name = "Def_title";
            this.chartControl1.Title.Text = "";
            this.chartControl1.Titles.Add(this.chartControl1.Title);
            this.chartControl1.ChartFormatAxisLabel += new Syncfusion.Windows.Forms.Chart.ChartFormatAxisLabelEventHandler(this.chartControl1_ChartFormatAxisLabel);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(958, 584);
            this.Controls.Add(this.chartControl1);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(821, 500);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Point Collection Methods";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RadioButton rdBtnFindMinValue;
        private System.Windows.Forms.RadioButton rdBtnFindMaxValue;
        private System.Windows.Forms.RadioButton rdBtnFindValue;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbBxFindValue;
        private System.Windows.Forms.ComboBox cbBxFindMaxValue;
        private System.Windows.Forms.TextBox txBxResult;
        private System.Windows.Forms.ComboBox cbBxFindMinValue;
        private System.Windows.Forms.TextBox txBxIndex;
        private System.Windows.Forms.Button btnResult;
        private System.Windows.Forms.TextBox txBxString;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txBxValue;
        private System.Windows.Forms.Label label3;
        private Syncfusion.Windows.Forms.Chart.ChartControl chartControl1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}


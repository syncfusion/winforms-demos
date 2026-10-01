#region Copyright Syncfusion Inc. 2001 - 2018
// Copyright Syncfusion Inc. 2001 - 2018. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System.Drawing;

namespace SparklineTypes_2008
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.sparkLine1 = new Syncfusion.Windows.Forms.Chart.SparkLine();
            this.sparkLine2 = new Syncfusion.Windows.Forms.Chart.SparkLine();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.sparkLine3 = new Syncfusion.Windows.Forms.Chart.SparkLine();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.sparkLine1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.sparkLine2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.sparkLine3, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 250F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 250F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 250F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1432, 894);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // sparkLine1
            // 
            this.sparkLine1.Location = new System.Drawing.Point(719, 3);
            this.sparkLine1.Name = "sparkLine1";            
            this.sparkLine1.Size = new System.Drawing.Size(392, 129);            
            this.sparkLine1.TabIndex = 0;
            this.sparkLine1.Text = "sparkLine1";
            this.sparkLine1.Type = Syncfusion.Windows.Forms.Chart.SparkLineType.Line;
            // 
            // sparkLine2
            // 
            this.sparkLine2.Location = new System.Drawing.Point(719, 301);
            this.sparkLine2.Name = "sparkLine2";
            this.sparkLine2.Size = new System.Drawing.Size(392, 133);
            this.sparkLine2.TabIndex = 1;
            this.sparkLine2.Text = "sparkLine2";
            this.sparkLine2.Type = Syncfusion.Windows.Forms.Chart.SparkLineType.Column;
            // 
            // label3
            // 

            this.label3.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 500);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(324, 29);
            this.label3.TabIndex = 6;
            this.label3.Text = "Profit Comparison for each months";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 298);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(324, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "Revenue Status";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(324, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "Mean Working Hours for year";
            // 
            // sparkLine3
            // 
            this.sparkLine3.Location = new System.Drawing.Point(719, 599);
            this.sparkLine3.Name = "sparkLine3";
            this.sparkLine3.Size = new System.Drawing.Size(392, 133);
            this.sparkLine3.TabIndex = 8;
            this.sparkLine3.Text = "sparkLine3";
            this.sparkLine3.Type = Syncfusion.Windows.Forms.Chart.SparkLineType.WinLoss;
            // 
            // Form1
            //
            this.ClientSize = new System.Drawing.Size(1432, 894);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(1256, 687);
            this.Name = "Form1";
            this.Text = "Getting Started";
            this.Font =  new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Syncfusion.Windows.Forms.Chart.SparkLine sparkLine1;
        private Syncfusion.Windows.Forms.Chart.SparkLine sparkLine2;
        private Syncfusion.Windows.Forms.Chart.SparkLine sparkLine3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}


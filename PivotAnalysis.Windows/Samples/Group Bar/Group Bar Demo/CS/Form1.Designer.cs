#region Copyright Syncfusion Inc. 2001 - 2018
// Copyright Syncfusion Inc. 2001 - 2018. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion

using System.ComponentModel;
using System.Windows.Forms;
using Syncfusion.Windows.Forms.PivotAnalysis;
using Syncfusion.Windows.Forms.Tools;

namespace PivotGridGroupBarDemo
{
    partial class Form1
    {
        #region API Definitions

        private PivotGridControl pivotGridControl1;
        private GroupBox groupBox1;
        private CheckBoxAdv checkBoxAdv1;
        private CheckBoxAdv checkBoxAdv3;
        private CheckBoxAdv checkBoxAdv2;     

        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;
        
        #endregion

        #region Dispose

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
            this.pivotGridControl1 = new Syncfusion.Windows.Forms.PivotAnalysis.PivotGridControl(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBoxAdv1 = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.checkBoxAdv3 = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.checkBoxAdv2 = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxAdv1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxAdv3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxAdv2)).BeginInit();
            this.SuspendLayout();
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
            this.pivotGridControl1.Size = new System.Drawing.Size(1232, 859);
            this.pivotGridControl1.TabIndex = 0;
            this.pivotGridControl1.Text = "pivotGridControl1";
            this.pivotGridControl1.UpdateManager = null;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBoxAdv1);
            this.groupBox1.Controls.Add(this.checkBoxAdv3);
            this.groupBox1.Controls.Add(this.checkBoxAdv2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(1233, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(0);
            this.groupBox1.Size = new System.Drawing.Size(355, 825);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Options";
            // 
            // checkBoxAdv1
            // 
            this.checkBoxAdv1.BeforeTouchSize = new System.Drawing.Size(330, 40);
            this.checkBoxAdv1.Checked = true;
            this.checkBoxAdv1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxAdv1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxAdv1.ForeColor = System.Drawing.Color.Black;
            this.checkBoxAdv1.ImageCheckBoxSize = new System.Drawing.Size(20, 20);
            this.checkBoxAdv1.Location = new System.Drawing.Point(15, 170);
            this.checkBoxAdv1.Margin = new System.Windows.Forms.Padding(0);
            this.checkBoxAdv1.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.checkBoxAdv1.Name = "checkBoxAdv1";
            this.checkBoxAdv1.Size = new System.Drawing.Size(330, 40);
            this.checkBoxAdv1.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.checkBoxAdv1.TabIndex = 4;
            this.checkBoxAdv1.Text = "Allow Sorting";
            this.checkBoxAdv1.ThemesEnabled = false;
            this.checkBoxAdv1.CheckStateChanged += new System.EventHandler(this.checkBoxAdv1_CheckStateChanged);
            // 
            // checkBoxAdv3
            // 
            this.checkBoxAdv3.BeforeTouchSize = new System.Drawing.Size(330, 40);
            this.checkBoxAdv3.Checked = true;
            this.checkBoxAdv3.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxAdv3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxAdv3.ForeColor = System.Drawing.Color.Black;
            this.checkBoxAdv3.ImageCheckBoxSize = new System.Drawing.Size(20, 20);
            this.checkBoxAdv3.Location = new System.Drawing.Point(15, 50);
            this.checkBoxAdv3.Margin = new System.Windows.Forms.Padding(0);
            this.checkBoxAdv3.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.checkBoxAdv3.Name = "checkBoxAdv3";
            this.checkBoxAdv3.Size = new System.Drawing.Size(330, 40);
            this.checkBoxAdv3.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.checkBoxAdv3.TabIndex = 2;
            this.checkBoxAdv3.Text = "Enable Group Bar";
            this.checkBoxAdv3.ThemesEnabled = false;
            this.checkBoxAdv3.CheckStateChanged += new System.EventHandler(this.checkBoxAdv3_CheckStateChanged);
            // 
            // checkBoxAdv2
            // 
            this.checkBoxAdv2.BeforeTouchSize = new System.Drawing.Size(330, 40);
            this.checkBoxAdv2.Checked = true;
            this.checkBoxAdv2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxAdv2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxAdv2.ForeColor = System.Drawing.Color.Black;
            this.checkBoxAdv2.ImageCheckBoxSize = new System.Drawing.Size(20, 20);
            this.checkBoxAdv2.Location = new System.Drawing.Point(15, 110);
            this.checkBoxAdv2.Margin = new System.Windows.Forms.Padding(0);
            this.checkBoxAdv2.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.checkBoxAdv2.Name = "checkBoxAdv2";
            this.checkBoxAdv2.Size = new System.Drawing.Size(330, 40);
            this.checkBoxAdv2.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.checkBoxAdv2.TabIndex = 3;
            this.checkBoxAdv2.Text = "Allow Filtering";
            this.checkBoxAdv2.ThemesEnabled = false;
            this.checkBoxAdv2.CheckStateChanged += new System.EventHandler(this.checkBoxAdv2_CheckStateChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.CaptionAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.CaptionBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.CaptionBarHeight = 50;
            this.CaptionButtonColor = System.Drawing.Color.White;
            this.CaptionButtonHoverColor = System.Drawing.Color.White;
            this.CaptionFont = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CaptionForeColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1600, 850);
            this.Controls.Add(this.pivotGridControl1);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(0);
            this.MetroColor = System.Drawing.Color.Transparent;
            this.MinimumSize = new System.Drawing.Size(1600, 850);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Group Bar";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxAdv1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxAdv3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxAdv2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
    }
}
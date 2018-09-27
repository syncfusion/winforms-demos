#region Copyright Syncfusion Inc. 2001 - 2011
// Copyright Syncfusion Inc. 2001 - 2011. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
namespace ToolbarCustomization_2005
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
            this.CustomPanel = new System.Windows.Forms.Panel();
            this.Open = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnFirst = new System.Windows.Forms.ToolStripButton();
            this.btnPrevious = new System.Windows.Forms.ToolStripButton();
            this.txtPageNumber = new System.Windows.Forms.ToolStripTextBox();
            this.btnNext = new System.Windows.Forms.ToolStripButton();
            this.btnLast = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.Tooltip = new System.Windows.Forms.ToolTip(this.components);
            this.pdfViewerControl1 = new Syncfusion.Windows.Forms.PdfViewer.PdfViewerControl();
            this.panel2 = new System.Windows.Forms.Panel();
            this.DefaultToolbar = new System.Windows.Forms.RadioButton();
            this.CustomToolbar = new System.Windows.Forms.RadioButton();
            this.CustomPanel.SuspendLayout();
            this.Open.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // CustomPanel
            // 
            this.CustomPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CustomPanel.Controls.Add(this.Open);
            this.CustomPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.CustomPanel.Location = new System.Drawing.Point(0, 30);
            this.CustomPanel.Name = "CustomPanel";
            this.CustomPanel.Size = new System.Drawing.Size(284, 32);
            this.CustomPanel.TabIndex = 2;
            this.CustomPanel.Visible = false;
            // 
            // Open
            // 
            this.Open.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripSeparator1,
            this.btnFirst,
            this.btnPrevious,
            this.txtPageNumber,
            this.btnNext,
            this.btnLast,
            this.toolStripSeparator2});
            this.Open.Location = new System.Drawing.Point(0, 0);
            this.Open.Name = "Open";
            this.Open.Size = new System.Drawing.Size(284, 27);
            this.Open.TabIndex = 0;
            this.Open.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.AutoSize = false;
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(24, 24);
            this.toolStripButton1.Text = "Open";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // btnFirst
            // 
            this.btnFirst.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnFirst.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnFirst.Image = ((System.Drawing.Image)(resources.GetObject("btnFirst.Image")));
            this.btnFirst.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnFirst.Margin = new System.Windows.Forms.Padding(5, 1, 0, 2);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(27, 24);
            this.btnFirst.Text = "<<";
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnPrevious.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnPrevious.Image = ((System.Drawing.Image)(resources.GetObject("btnPrevious.Image")));
            this.btnPrevious.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPrevious.Margin = new System.Windows.Forms.Padding(5, 1, 0, 2);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(23, 24);
            this.btnPrevious.Text = "<";
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // txtPageNumber
            // 
            this.txtPageNumber.AutoSize = false;
            this.txtPageNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPageNumber.Name = "txtPageNumber";
            this.txtPageNumber.Size = new System.Drawing.Size(35, 23);
            this.txtPageNumber.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPageNumber.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPageNumber_KeyDown);
            // 
            // btnNext
            // 
            this.btnNext.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnNext.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnNext.Image = ((System.Drawing.Image)(resources.GetObject("btnNext.Image")));
            this.btnNext.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNext.Margin = new System.Windows.Forms.Padding(5, 1, 0, 2);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(23, 24);
            this.btnNext.Text = ">";
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnLast
            // 
            this.btnLast.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnLast.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnLast.Image = ((System.Drawing.Image)(resources.GetObject("btnLast.Image")));
            this.btnLast.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLast.Margin = new System.Windows.Forms.Padding(5, 1, 0, 2);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(27, 24);
            this.btnLast.Text = ">>";
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // pdfViewerControl1
            // 
            this.pdfViewerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pdfViewerControl1.Location = new System.Drawing.Point(0, 62);
            this.pdfViewerControl1.Name = "pdfViewerControl1";
            this.pdfViewerControl1.ShowToolBar = true;
            this.pdfViewerControl1.Size = new System.Drawing.Size(284, 200);
            this.pdfViewerControl1.TabIndex = 3;
            this.pdfViewerControl1.Text = "pdfViewerControl1";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.DefaultToolbar);
            this.panel2.Controls.Add(this.CustomToolbar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(284, 30);
            this.panel2.TabIndex = 4;
            // 
            // DefaultToolbar
            // 
            this.DefaultToolbar.AutoSize = true;
            this.DefaultToolbar.Checked = true;
            this.DefaultToolbar.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.DefaultToolbar.Location = new System.Drawing.Point(3, 9);
            this.DefaultToolbar.Name = "DefaultToolbar";
            this.DefaultToolbar.Size = new System.Drawing.Size(168, 20);
            this.DefaultToolbar.TabIndex = 0;
            this.DefaultToolbar.TabStop = true;
            this.DefaultToolbar.Text = "Show Default Toolbar";
            this.DefaultToolbar.UseVisualStyleBackColor = true;
            this.DefaultToolbar.CheckedChanged += new System.EventHandler(this.DefaultToolbar_Click);
            // 
            // CustomToolbar
            // 
            this.CustomToolbar.AutoSize = true;
            this.CustomToolbar.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.CustomToolbar.Location = new System.Drawing.Point(176, 9);
            this.CustomToolbar.Name = "CustomToolbar";
            this.CustomToolbar.Size = new System.Drawing.Size(170, 20);
            this.CustomToolbar.TabIndex = 1;
            this.CustomToolbar.Text = "Show Custom Toolbar";
            this.CustomToolbar.UseVisualStyleBackColor = true;
            this.CustomToolbar.CheckedChanged += new System.EventHandler(this.DefaultToolbar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.pdfViewerControl1);
            this.Controls.Add(this.CustomPanel);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Custom Toolbar";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.CustomPanel.ResumeLayout(false);
            this.CustomPanel.PerformLayout();
            this.Open.ResumeLayout(false);
            this.Open.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ToolTip Tooltip;
        private Syncfusion.Windows.Forms.PdfViewer.PdfViewerControl pdfViewerControl1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton CustomToolbar;
        private System.Windows.Forms.RadioButton DefaultToolbar;
        private System.Windows.Forms.Panel CustomPanel;
        private System.Windows.Forms.ToolStrip Open;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton btnFirst;
        private System.Windows.Forms.ToolStripButton btnPrevious;
        private System.Windows.Forms.ToolStripButton btnNext;
        private System.Windows.Forms.ToolStripButton btnLast;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripTextBox txtPageNumber;
    }
}


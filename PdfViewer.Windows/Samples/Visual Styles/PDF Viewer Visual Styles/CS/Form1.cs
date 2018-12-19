#region Copyright Syncfusion Inc. 2001 - 2018
// Copyright Syncfusion Inc. 2001 - 2018. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Syncfusion.Windows.Forms;
using Syncfusion.Windows.Forms.PdfViewer;

namespace GettingStarted
{
    public partial class Form1 : MetroForm
    {
        # region Constructor
        public Form1()
        {
            InitializeComponent();

            // Layout controls.
            Rectangle rect = System.Windows.Forms.Screen.PrimaryScreen.Bounds;
            this.MinimumSize = new Size(rect.Width * 2 / 3, rect.Height * (3 / 2));
            this.Location = new Point(rect.Width / 6, 0);
            this.CaptionBarColor = System.Drawing.ColorTranslator.FromHtml("#444444");
            this.CaptionButtonColor = Color.White;
            this.CaptionForeColor = Color.White;
            this.lblText.ForeColor = Color.White;
            comboBox1.Items.AddRange(new object[] {
             "Default", "Office2016Colorful","Office2016Black","Office2016White","Office2016DarkGray"});
            comboBox1.SelectedIndex = 4;

            Control toolbar = this.pdfViewerControl1.Controls["tableLayoutPanel1"].Controls["DocumentToolbar"];
            if (toolbar != null)
            {
                comboBox1.SelectedValueChanged += new EventHandler(comboBox1_SelectedValueChanged);
                comboBox1_SelectedValueChanged(null, null);

                tableLayoutPanel1.Dock = DockStyle.Right;
                toolbar.Controls.Add(tableLayoutPanel1);
            }
            this.WindowState = FormWindowState.Maximized;
        }

        #endregion

        #region Events
        private void Form1_Load(object sender, EventArgs e)
        {
		    pdfViewerControl1.Load(@"..\..\..\..\..\..\..\Common\Data\PDF\HTTP Succinctly.pdf");
        }
        /// <summary>
        /// Load files.
        /// </summary>
        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            if (sender != null)
            {
                ComboBox combo = sender as ComboBox;
                if (combo.SelectedItem.ToString() == "Default")
                {
                    this.CaptionBarColor = Color.White;
                    this.CaptionForeColor = Color.Black;
                    this.lblText.ForeColor = Color.Black;
                    this.pdfViewerControl1.VisualStyle = (Syncfusion.Windows.Forms.PdfViewer.VisualStyle)Enum.Parse(typeof(Syncfusion.Windows.Forms.PdfViewer.VisualStyle), combo.SelectedItem.ToString());
                }
                else if (combo.SelectedItem.ToString() == "Office2016Colorful")
                {
                    this.CaptionBarColor = System.Drawing.ColorTranslator.FromHtml("#0173c7");
                    this.CaptionButtonColor = Color.White;
                    this.CaptionForeColor = Color.White;
                    this.lblText.ForeColor = Color.Black;
                    this.pdfViewerControl1.VisualStyle = Syncfusion.Windows.Forms.PdfViewer.VisualStyle.Office2016Colorful;
                }
                else if (combo.SelectedItem.ToString() == "Office2016Black")
                {
                    this.CaptionBarColor = System.Drawing.ColorTranslator.FromHtml("#000000");
                    this.CaptionButtonColor = Color.White;
                    this.CaptionForeColor = Color.White;
                    this.lblText.ForeColor = Color.White;
                    this.pdfViewerControl1.VisualStyle = Syncfusion.Windows.Forms.PdfViewer.VisualStyle.Office2016Black;
                }
                else if (combo.SelectedItem.ToString() == "Office2016DarkGray")
                {
                    this.CaptionBarColor = System.Drawing.ColorTranslator.FromHtml("#444444");
                    this.CaptionButtonColor = Color.White;
                    this.CaptionForeColor = Color.White;
                    this.lblText.ForeColor = Color.White;
                    this.pdfViewerControl1.VisualStyle = Syncfusion.Windows.Forms.PdfViewer.VisualStyle.Office2016DarkGray;
                }
                else if (combo.SelectedItem.ToString() == "Office2016White")
                {
                    this.CaptionBarColor = System.Drawing.ColorTranslator.FromHtml("#FFFFFF");
                    this.CaptionButtonColor = Color.Black;
                    this.CaptionForeColor = Color.Black;
                    this.lblText.ForeColor = Color.Black;
                    this.pdfViewerControl1.VisualStyle = Syncfusion.Windows.Forms.PdfViewer.VisualStyle.Office2016White;
                }

            }
        }
        #endregion

        #region Helper Methods
        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            pdfViewerControl1.Dispose();
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        #endregion
    }
}
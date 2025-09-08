#region Copyright Syncfusion Inc. 2001 - 2011
// Copyright Syncfusion Inc. 2001 - 2011. All rights reserved.
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
            comboBox1.Items.AddRange(new object[] {
             "CorporateBrochure.pdf", "TextFormatting.pdf", "Invoice.pdf", "Graphics.pdf", "MultiColumnReports.pdf", "Barcode.pdf"});
            comboBox1.SelectedIndex = 0;

            Control toolbar = this.pdfViewerControl1.Controls["tableLayoutPanel1"].Controls["DocumentToolbar"];
            if (toolbar != null)
            {
                comboBox1.SelectedValueChanged += new EventHandler(comboBox1_SelectedValueChanged);
                comboBox1_SelectedValueChanged(null, null);

                tableLayoutPanel1.Dock = DockStyle.Right;
                toolbar.Controls.Add(tableLayoutPanel1);
            }
            this.MetroColor = Color.Transparent;
            this.WindowState = FormWindowState.Maximized;
        }
        # endregion

        # region Events

        /// <summary>
        /// Load files.
        /// </summary>
        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
		    pdfViewerControl1.Load(GetFullTemplatePath(comboBox1.SelectedItem.ToString()));
            pdfViewerControl1.Focus();
        }
        # endregion

        # region Helper Methods
        /// <summary>
        /// Gets the full path of the PDF template or image.
        /// </summary>
        /// <param name="fileName">Name of the file</param>
        /// <param name="image">True if image</param>
        /// <returns>Path of the file</returns>
        private string GetFullTemplatePath(string fileName)
        {
#if NETCORE
            string fullPath = @"..\..\..\..\..\..\..\Common\Data\PDF\";
#else
			string fullPath = @"..\..\..\..\..\..\Common\Data\PDF\";
#endif

            return string.Format(@"{0}{1}", fullPath, fileName);
        }

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            pdfViewerControl1.Dispose();
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
    }
}
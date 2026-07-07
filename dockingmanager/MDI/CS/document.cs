#region Copyright Syncfusion Inc. 2001 - 2019
//
//  Copyright Syncfusion Inc. 2001 - 2019. All rights reserved.
//
//  Use of this code is subject to the terms of our license.
//  A copy of the current license can be obtained at any time by e-mailing
//  licensing@syncfusion.com. Any infringement will be prosecuted under
//  applicable laws. 
//
#endregion

namespace MDIDemo
{
    using System;
    using System.ComponentModel;
    using System.Drawing;
    using System.Drawing.Text;
    using System.Windows.Forms;
    using System.Diagnostics;
    using System.IO;
    using Syncfusion.Windows.Forms.Tools.XPMenus;
    using Syncfusion.Windows.Forms;

    public class Document : MetroForm
    {
        internal System.Windows.Forms.RichTextBox richTextBox1;

        public Document(string docName)
        {
            InitializeComponent();
            if (docName == "Window1")
            {
                this.richTextBox1.LoadFile("RichTextBox-files//DockingManager.rtf");
                this.Text = docName;
            }
            else
            {
                this.richTextBox1.LoadFile("RichTextBox-files//DockingClientPanel.rtf");
                this.Text = docName;
            }
            //richTextBox1.Text = "The DockingManager control implements an architecture that allows child controls to be "+
            //"docked at any part of a window as in Microsoft Visual Studio. The dock panels containing the child elements can be interactively dragged to any area within the window. These windows can also be floated, tabbed, and auto hidden at run time.";
           
        }

        #region Initialize Component
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Document));
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(0, 0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(354, 295);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // Document
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(354, 295);
            this.Controls.Add(this.richTextBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Document";
            this.ResumeLayout(false);

        }

        #endregion

    }
}











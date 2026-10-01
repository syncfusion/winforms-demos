#region Copyright Syncfusion Inc. 2001-2019.
// Copyright Syncfusion Inc. 2001-2019. All rights reserved.
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
using Syncfusion.Windows.Forms.Tools;
using Syncfusion.Windows.Forms;

namespace TabSplitterContainer_2005
{
    public partial class SplitWindowForm : MetroForm
    {
        private string basePath = @"Resources\";
        
        public SplitWindowForm()
        {
            
            InitializeComponent();
        }
       
       
        public SplitWindowForm(string title, string filename)
            : this()
        {
            this.Text = title;
            this.richTextBox1.LoadFile(basePath + filename);
        }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public Image DesignWindow
        {
            get
            {
                return this.pictureBox1.Image;
            }
            set
            {
                this.pictureBox1.Image = value;
            }
        }
        
        public TabSplitterContainer SplitView
        {
            get {
                return this.tabSplitterContainer1;
            }
        }
        public RichTextBox richtextBox
        {
            get
            {
                return this.richTextBox1;
            }
        }
        public PictureBox pictureBox
        {
            get
            {
                return this.pictureBox1;
            }
        }       
        public TabSplitterPage designpage
        {
            get
            {
                return this.DesignPage;
            }
        }
        public TabSplitterPage xamlPage
        {
            get
            {
                return this.XAMLPage;
            }
        }
    }
}
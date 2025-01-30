#region Copyright Syncfusion Inc. 2001 - 2014
// Copyright Syncfusion Inc. 2001 - 2014. All rights reserved.
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

namespace RibbonControlMerging
{
    public partial class Form1 : RibbonForm
    {
        #region Form Constructor

        public Form1()
        {
            InitializeComponent();
            this.pictureBox1.Height += 5;
            this.ribbonControlAdv1.MenuColor = ColorTranslator.FromHtml("#217346");
            this.statusStripEx1.BackColor = ColorTranslator.FromHtml("#217346");
            this.statusStripLabel1.ForeColor = Color.White;
            this.ribbonControlAdv1.MenuButtonText = "File";
            this.ribbonControlAdv1.UseDefaultHighlightColor = false;
            this.ribbonControlAdv1.TouchMode = false;
            this.trackBarItem1.TrackBarExControl.Style = TrackBarEx.Theme.Metro;
            this.trackBarItem1.TrackBarExControl.BackColor = ColorTranslator.FromHtml("#217346");
            this.trackBarItem1.TrackBarExControl.ButtonSignColor = ColorTranslator.FromHtml("#09542b");
            this.trackBarItem1.TrackBarExControl.ForeColor = Color.White;
            this.trackBarItem1.TrackBarExControl.ShowButtons = true;
            this.backStageButton1.Click += new EventHandler(backStage1_Click);
            foreach (ToolStripTabItem items in this.ribbonControlAdv1.Header.MainItems)
            {
                foreach (ToolStripEx item in items.Panel.Controls)
                {
                    item.LauncherClick += new EventHandler(item_LauncherClick);
                }
            }
        }

        /// <summary>
        /// This event raises when the launcher is clicked
        /// </summary>
        /// <param name="sender">Instance of the Object</param>
        /// <param name="e">Contains data for the source</param>
        void item_LauncherClick(object sender, EventArgs e)
        {
            MessageBox.Show("Launcher is clicked","Launcher" );
        }
        #endregion
        #region Form Icon
        private string GetIconFile(string bitmapName)
        {
            for (int n = 0; n < 10; n++)
            {
                if (System.IO.File.Exists(bitmapName))
                    return bitmapName;

                bitmapName = @"..\" + bitmapName;
            }

            return bitmapName;
        }
        #endregion
      
        private void Form1_Load(object sender, EventArgs e)
        {
            this.trackBarItem1.TrackBarExControl.ButtonSignColor = Color.White;
            this.trackBarItem1.ValueChanged += new EventHandler(trackBarItem1_ValueChanged);
            this.trackBarItem1.Maximum = 200;
            this.trackBarItem1.Value = 100;
            this.toolStripStatusLabel1.AutoSize = false;
            this.toolStripStatusLabel1.ForeColor = Color.White;
            this.HelpButton = false;
            this.ribbonControlAdv1.QuickPanelVisible = true;
            this.ribbonControlAdv1.ShowQuickItemsDropDownButton = true;
            //To add items in the QAT
            ToolStripButton saveItem = new ToolStripButton(imageList1.Images[1]);
            QuickButtonReflectable quick = new QuickButtonReflectable(saveItem);
            this.ribbonControlAdv1.Header.AddQuickItem(quick);
            this.superAccelerator1.SetAccelerator(saveItem, "SA");
            this.ribbonControlAdv1.TouchMode = true;
            this.toolStripFontfaceComboBox.SelectedIndex = 0;
            this.toolStripFontSizeComboBox.SelectedIndex = 0;
            this.superAccelerator1.ForeColor = Color.White;
            this.superAccelerator1.BackColor = Color.Black;
            this.superAccelerator1.Appearance = Syncfusion.Windows.Forms.Tools.Appearance.Advanced;
            this.superAccelerator1.SetAccelerator(this.toolStripTabItem1, "H");
            this.superAccelerator1.SetMenuButtonAccelerator(this.ribbonControlAdv1, "F");
            this.superAccelerator1.SetAccelerator(this.backStageTab2, "N");
            this.superAccelerator1.SetAccelerator(this.backStageButton1, "E");
            this.superAccelerator1.SetAccelerator(this.backStageButton1, "E");
            this.superAccelerator1.SetAccelerator(this.toolStripBtnPaste, "P");
            this.superAccelerator1.SetAccelerator(this.toolStripBtnCut, "X");
            this.superAccelerator1.SetAccelerator(this.toolStripBtnCopy, "C");
            this.superAccelerator1.SetAccelerator(this.toolStripBtnCut, "X");
            this.superAccelerator1.SetAccelerator(this.boldToolstripBtn, "1");
            this.superAccelerator1.SetAccelerator(this.italicToolStripBtn, "2");
            this.superAccelerator1.SetAccelerator(this.underlineToolStripSplitBtn, "3");
            this.superAccelerator1.SetAccelerator(this.BottomBorderBtn, "D");
            this.superAccelerator1.SetAccelerator(this.growfontToolStripBtn, "FG");
            this.superAccelerator1.SetAccelerator(this.shrinkfontToolStripBtn, "FK");
            this.superAccelerator1.SetAccelerator(this.toolStripFontfaceComboBox, "FF");
            this.superAccelerator1.SetAccelerator(this.toolStripFontSizeComboBox, "FS");
            this.superAccelerator1.SetAccelerator(this.TopAlignBtn, "AT");
            this.superAccelerator1.SetAccelerator(this.MiddleAlignBtn, "AM");
            this.superAccelerator1.SetAccelerator(this.BottomAlignBtn, "AB");
            this.superAccelerator1.SetAccelerator(this.AlignLeftBtn, "AL");
            this.superAccelerator1.SetAccelerator(this.CenterBtn, "AC");
            this.superAccelerator1.SetAccelerator(this.AlignRightBtn, "AM");
            this.superAccelerator1.SetAccelerator(this.WrapTextBtn, "W");
            this.superAccelerator1.SetAccelerator(this.MergeCenterBtn, "M");
            this.superAccelerator1.SetAccelerator(this.InsertCellBtn, "I");
            this.superAccelerator1.SetAccelerator(this.DeleteCellBtn, "D");
            this.superAccelerator1.SetAccelerator(this.FormatBtn, "O");
            this.superAccelerator1.SetAccelerator(this.FillColorsBtn, "H");
            this.superAccelerator1.SetAccelerator(this.FontColorBtn, "FC");
            this.superAccelerator1.SetAccelerator(this.backStageButton2, "O");
            this.superAccelerator1.SetAccelerator(this.backStageButton3, "S");
            this.backStageButton2.Click += new EventHandler(backStageButton2_Click);
            this.backStageButton3.Click += new EventHandler(backStageButton3_Click);
            this.clipboardToolStripExt.ShowItemToolTips = true;
            this.AlignmentToolStripEx.ShowItemToolTips = true;
            this.CellsToolStripEx.ShowItemToolTips = true;
            this.fontToolStripExt.ShowItemToolTips = true;
        }

        void trackBarItem1_ValueChanged(object sender, EventArgs e)
        {
            this.toolStripStatusLabel1.Text = this.trackBarItem1.TrackBarExControl.Value.ToString();
        }

        void backStageButton3_Click(object sender, EventArgs e)
        {
            this.backStageView1.HideBackStage();
            this.saveFileDialog1.ShowDialog();
        }

        void backStageButton2_Click(object sender, EventArgs e)
        {
            this.backStageView1.HideBackStage();
            this.openFileDialog1.ShowDialog();
        }
        
        void backStage1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        Form2 frm = null;
        Form3 frm1 = null;
        private void label1_Click(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
            frm = new Form2();
            frm.MdiParent = this;
            frm.Text = "Book1";
            frm.Show();
            this.panel1.Visible = false;
            frm.FormClosed += new FormClosedEventHandler(frm_FormClosed);
            frm1 = new Form3();
            frm1.MdiParent = this;
            frm1.Text = "Employee Details";
            frm1.Show();
            frm1.FormClosed += Frm1_FormClosed;
            this.panel1.Visible = false;
        }

        private void Frm1_FormClosed(object sender, FormClosedEventArgs e)
        {
           if(frm.IsDisposed)
            {
                this.panel1.Visible = true;
                this.IsMdiContainer = false;
            }
        }

        void frm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (frm1.IsDisposed)
            {
                this.panel1.Visible = true;
                this.IsMdiContainer = false;
            }
        }

        private void panel3_MouseEnter(object sender, EventArgs e)
        {
            this.panel3.BackColor = ColorTranslator.FromHtml("#d3f0e0");
            this.label3.BackColor = ColorTranslator.FromHtml("#d3f0e0");
        }

    }
}
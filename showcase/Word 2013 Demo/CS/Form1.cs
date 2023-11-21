#region Copyright Syncfusion Inc. 2001 - 2023
//
// Copyright Syncfusion Inc. 2001 - 2023. All rights reserved.
//
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
//
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
using Word2007Demo_2005.Properties;
using Syncfusion.Drawing;
using System.IO;
using System.Threading;
using System.Runtime.InteropServices;

namespace Word2007Demo_2005
{
	// RibbonForm class is derived from a System.Windows.Forms to have Office 2007 look and feel.
    public partial class Form1 : RibbonForm
    {
        private static int EM_LINEINDEX = 0xbb;
        [DllImport("user32.dll")]
        extern static int SendMessage(IntPtr hwnd, int message, int wparam, int lparam);
        private Font font;
		private Point pt;
		private ProgressBarAdv progressBarAdv;

        public Form1()
        {
            InitializeComponent();
            this.richTextBox1.HideSelection = false;
            this.radialMenuItem13.CheckMode = CheckMode.Check;
            this.Deactivate += new EventHandler(Form1_Deactivate);
            this.trackBarItem1.TrackBarExControl.Style = TrackBarEx.Theme.Metro;
            this.trackBarItem1.TrackBarExControl.BackColor = Color.FromArgb(43, 87, 154);
            this.trackBarItem1.BackColor = Color.FromArgb(43, 87, 154);
            this.statusStripEx1.MetroColor = Color.FromArgb(43, 87, 154);
            this.radialMenu1.Icon = global::Word2007Demo_2005.Properties.Resources._0003_Layer_1___Copy___Copy___Copy;
            this.radialMenu1.MenuIcon = global::Word2007Demo_2005.Properties.Resources._0000_Layer_4;
            #region ProgressBarAdv Code
            progressBarAdv = new ProgressBarAdv();
            progressBarAdv.BackColor = System.Drawing.SystemColors.Control;
            progressBarAdv.BackGradientEndColor = System.Drawing.Color.White;
            progressBarAdv.BackGradientStartColor = System.Drawing.Color.LightGray;
            progressBarAdv.BackMultipleColors = new System.Drawing.Color[0];
            progressBarAdv.BackSegments = false;
            progressBarAdv.BackTubeEndColor = System.Drawing.Color.White;
            progressBarAdv.BackTubeStartColor = System.Drawing.Color.LightGray;
            progressBarAdv.BorderColor = System.Drawing.Color.Black;
            progressBarAdv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            progressBarAdv.CustomWaitingRender = false;
            progressBarAdv.FontColor = System.Drawing.Color.White;
            progressBarAdv.ForegroundImage = null;
            progressBarAdv.ForeSegments = false;
            progressBarAdv.GradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(87)))), ((int)(((byte)(154)))));
            progressBarAdv.GradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(87)))), ((int)(((byte)(154)))));
            progressBarAdv.Location = new System.Drawing.Point(2, 3);
            progressBarAdv.MultipleColors = new System.Drawing.Color[0];
            progressBarAdv.ProgressStyle = Syncfusion.Windows.Forms.Tools.ProgressBarStyles.Metro;
            progressBarAdv.SegmentWidth = 12;
            progressBarAdv.Size = new System.Drawing.Size(113, 16);
            progressBarAdv.TabIndex = 1;
            progressBarAdv.TextVisible = false;
            progressBarAdv.ThemesEnabled = true;
            progressBarAdv.TubeEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(87)))), ((int)(((byte)(154)))));
            progressBarAdv.TubeStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(87)))), ((int)(((byte)(154)))));
            progressBarAdv.WaitingGradientWidth = 400;
            progressBarAdv.Text = "Progress";
            progressBarAdv.Value = 0;
            progressTimer.Start();
            progressTimer.Tick += new EventHandler(progressTimer_Tick);
            #endregion
            this.richTextBox1.MouseDown += new MouseEventHandler(richTextBox1_MouseDown);
            //To host any .Net control into ToolStripEx, StatusStrip,
            // User can make use of ToolStripControlHost class
            // and host the control inside it and add the host
            // to item collection.
            ToolStripControlHost host = new ToolStripControlHost(progressBarAdv);
            this.statusStripEx1.Items.Add(host);
            this.splashControl1.ShowDialogSplash(this);
            this.EditorContextMenuStripEx.Renderer = new ContextMenuRenderer();
            //this.radialMenu1.ShowRadialMenu();
            this.radialMenu1.ParentControl = this.richTextBox1;
            this.radialMenuItem46.MouseUp += new MouseEventHandler(radialMenuItem5_MouseUp);
            this.radialMenuItem44.MouseUp += new MouseEventHandler(radialMenuItem5_MouseUp);
            this.radialMenuItem32.MouseUp += new MouseEventHandler(radialMenuItem4_MouseUp);
            this.radialMenuItem30.MouseUp += new MouseEventHandler(radialMenuItem3_MouseUp);
            this.radialMenuItem34.MouseUp += new MouseEventHandler(radialMenuItem2_MouseUp);
            this.richTextBox1.MouseUp += richTextBox1_MouseUp;
            this.radialMenu1.BeforeCloseUp += new CancelEventHandler(radialMenu1_BeforeCloseUp);
            this.richTextBox1.MouseDown += new MouseEventHandler(richTextBox1_MouseDown);
            this.radialMenuSlider1.SliderValueChanged += new SliderValueChangedEventArgs(radialMenuSlider1_SliderValueChanged);
            this.radialFontListBox1.RadialFontChanged += new SelectedFontChanged(radialFontListBox1_RadialFontChanged);
            this.radialColorPalette1.ColorPaletteColorChanged += new ColorChanged(radialColorPalette1_ColorPaletteColorChanged);
            this.Deactivate += new EventHandler(Form1_Deactivate);
            this.richTextBox1.GotFocus += new EventHandler(richTextBox1_GotFocus);
            this.radialMenu1.BeforePopup += new CancelEventHandler(radialMenu1_BeforePopup);
            this.richTextBox1.TextChanged += richTextBox1_TextChanged;
            this.radialMenu1.MenuVisibilityChanging+=radialMenu1_MenuVisibilityChanging;
            Office2016ColorTable officeColorTable = new Office2016ColorTable();
            officeColorTable.BackStageCaptionColor = Color.White;
            this.ribbonControlAdv1.Office2016ColorTable.Add(officeColorTable);
        }

        void radialMenu1_BeforePopup(object sender, CancelEventArgs e)
        {
            
        }

        void radialMenu1_BeforeCloseUp(object sender, CancelEventArgs e)
        {
            if (this.radialMenu1.MenuVisibility)
            {
                this.radialMenu1.MenuVisibility = false;
                this.radialMenu1.ItemOnLoad = null;
                this.radialMenu1.Refresh();
                visibility = true;
            }
        }

        void richTextBox1_GotFocus(object sender, EventArgs e)
        {
            Thread.Sleep(200);
            if (this.WindowState != FormWindowState.Minimized)
            {
                setRadialMenuLocation();
                if (!this.radialMenu1.IsShowing())
                    this.radialMenu1.ShowRadialMenu(new  Point(700,200));
            }
        }

        void radialMenuItem5_MouseUp(object sender, MouseEventArgs e)
        {
            this.richTextBox1.Undo();
        }
        private void UpdateCaretPos()
        {
            if (this.richTextBox1.SelectionLength == 0)
            {
                if (visibility)
                {
                    if (!this.radialMenu1.IsShowing())
                    {
                        if (this.WindowState != FormWindowState.Minimized)
                            this.radialMenu1.ShowRadialMenu(new Point(200, 200));
                    }
                    int line, col, index;
                    index = richTextBox1.SelectionStart;
                    line = richTextBox1.GetLineFromCharIndex(index);
                    col = index - SendMessage(richTextBox1.Handle, EM_LINEINDEX, -1, 0);
                    Point position = this.richTextBox1.GetPositionFromCharIndex(index);
                    if (this.radialMenu1.PopupHost != null)
                    {
                        this.radialMenu1.PopupHost.Location = position;
                        this.radialMenu1.PopupHost.Location = new Point(this.Location.X + this.radialMenu1.PopupHost.Location.X + this.radialMenu1.PopupHost.Width / 2, this.radialMenu1.PopupHost.Location.Y - 60);
                        if (this.radialMenu1.PopupHost.Location.X + this.radialMenu1.PopupHost.Width > Screen.PrimaryScreen.Bounds.Width)
                        {
                            if (position.Y < this.radialMenu1.Height)
                            {
                                this.radialMenu1.PopupHost.Location = new Point(Screen.PrimaryScreen.Bounds.Width - this.radialMenu1.Width, this.radialMenu1.PopupHost.Location.Y + this.radialMenu1.Width / 2);
                            }
                            else
                            {
                                this.radialMenu1.PopupHost.Location = new Point(Screen.PrimaryScreen.Bounds.Width - this.radialMenu1.Width, this.radialMenu1.PopupHost.Location.Y - this.radialMenu1.Width / 2);
                            }
                        }

                    }
                }
            }
        }
        private void setRadialMenuLocation()
        {
            UpdateCaretPos();
        }
        void radialMenuItem4_MouseUp(object sender, MouseEventArgs e)
        {

            this.richTextBox1.Paste();
        }

        void radialMenuItem3_MouseUp(object sender, MouseEventArgs e)
        {
            this.richTextBox1.Copy();
        }

        void radialMenuItem2_MouseUp(object sender, MouseEventArgs e)
        {
            this.richTextBox1.Cut();
        }
        private void radialMenuSlider1_SliderValueChanged(object sender, Syncfusion.Windows.Forms.Tools.RadialMenuSliderValueChangedEventArgs e)
        {
            if (this.richTextBox1.SelectedText == "")
            {
                this.richTextBox1.Font = new Font(this.richTextBox1.Font.Name, (float)e.Value, this.richTextBox1.Font.Style);
            }
            else
            {
                this.richTextBox1.SelectionFont = new Font(this.richTextBox1.Font.Name, (float)e.Value, this.richTextBox1.Font.Style);
            }
        }
        private void radialFontListBox1_RadialFontChanged(object sender, Syncfusion.Windows.Forms.Tools.SlectedIndexChangedEventArgs e)
        {
            if (this.richTextBox1.SelectedText == "")
            {
                this.richTextBox1.Font = new Font(e.SelectedFontName, this.richTextBox1.Font.Size, this.richTextBox1.Font.Style);
            }
            else
            {
                this.richTextBox1.SelectionFont = new Font(e.SelectedFontName, this.richTextBox1.Font.Size, this.richTextBox1.Font.Style);
            }
        }
        private void radialColorPalette1_ColorPaletteColorChanged(object sender, Syncfusion.Windows.Forms.Tools.SelctedColorChangedEventArgs e)
        {
            if (this.richTextBox1.SelectedText == "")
            {
                this.richTextBox1.ForeColor = e.SelectedColor;
            }
            else
            {
                this.richTextBox1.SelectionColor = e.SelectedColor;
            }
        }
        void Form1_Deactivate(object sender, EventArgs e)
        {
            this.EditorContextMenuStripEx.Close();
        }

        void richTextBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if(!(this.radialMenu1.IsShowing()))
            {
                this.setRadialMenuLocation();
            }
            if (this.radialMenu1.MenuVisibility)
            {
                if (this.radialMenu1.MenuVisibility)
                {
                    this.radialMenu1.MenuVisibility = false;
                    this.radialMenu1.ItemOnLoad = null;
                    this.radialMenu1.Refresh();
                }
            }
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
                check = true;
            if (!(this.radialMenu1.IsShowing()))
            {
                this.radialMenu1.HidePopup();
            }
        }


        void EditorContextMenuStripEx_Opened(object sender, EventArgs e)
        {
            if (check)
            {
              
                {
                    this.radialMenu1.PopupHost.Location = (new Point(this.EditorContextMenuStripEx.Bounds.X - 200, this.EditorContextMenuStripEx.Bounds.Y - 200));
                }
               
               
            }
            check = false;
        }		

        # region FormLoad

        private void Form1_Load(object sender, EventArgs e)
        {
            this.radialMenu1.MinimumSize = this.radialMenu1.Size;
            this.ribbonControlAdv1.BackStageView = this.backStageView1;
            this.radialMenu1.OuterRimThickness = 28;
            this.toolStripSplitButton1.BackColor = System.Drawing.Color.White;
            this.toolStripSplitButton2.BackColor = System.Drawing.Color.White;
            this.font = this.richTextBox1.SelectionFont;
            var host = new ToolStripControlHost(this.comboBox1);
            var fontsize = new ToolStripControlHost(this.comboBox2);
            var button1 = new ToolStripControlHost(this.toolStripButton10);
            var button2 = new ToolStripControlHost(this.toolStripButton11);
            this.PanelItem1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            host,
            fontsize,
            button1,
            button2});
            var button12 = new ToolStripControlHost(this.toolStripButton12);
            var button13 = new ToolStripControlHost(this.toolStripButton13);
            var button14 = new ToolStripControlHost(this.toolStripButton14);
            var button15 = new ToolStripControlHost(this.toolStripButton15);
            var button16 = new ToolStripControlHost(this.toolStripButton16);
            var button17 = new ToolStripControlHost(this.toolStripButton17);
            var Sbutton1 = new ToolStripControlHost(this.toolStripSplitButton1);
            var Sbutton2 = new ToolStripControlHost(this.toolStripSplitButton2);
            this.PanelItem2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            button12,
            button13,
            button14,
            button17,
            Sbutton1,
            Sbutton2,
            button15,
            button16});
            foreach (Object item in this.fontListBox1.Items)
            {
                this.toolStripFontfaceComboBox.Items.Add(item);
				this.FontFaceCombo.Items.Add(item);
            }

            this.toolStripFontfaceComboBox.SelectedItem = "Arial";
            this.toolStripFontSizeComboBox.SelectedIndex = 0;
            this.FontFaceCombo.SelectedItem = "Arial";
			this.FontSize.SelectedIndex = 0;

            this.richTextBox1.Text = "";
            string path = Application.StartupPath.ToString() + @"..\..\..\Introduction.rtf";
            if(File.Exists(path))
                this.richTextBox1.LoadFile(path, RichTextBoxStreamType.RichText);

            /////////////////////
            // Add items to QAT//
            ////////////////////
            ToolStripButton saveItem = new ToolStripButton(Resources.save);
            QuickButtonReflectable quickSave = new QuickButtonReflectable(saveItem);
            this.ribbonControlAdv1.Header.AddQuickItem(quickSave);

            ToolStripButton undoItem = new ToolStripButton(Resources.undo);
            undoItem.Enabled = false;
            QuickButtonReflectable quickUndo = new QuickButtonReflectable(undoItem);
            this.ribbonControlAdv1.Header.AddQuickItem(quickUndo);

            ToolStripButton redoItem = new ToolStripButton(Resources.redo);
            redoItem.Enabled = false;
            QuickButtonReflectable quickRedo = new QuickButtonReflectable(redoItem);
            this.ribbonControlAdv1.Header.AddQuickItem(quickRedo);

            //Attach office2007 scrolls for richtextbox.
            this.scrollersFrame1.AttachedTo = this.richTextBox1;
            this.statusStripEx1.ContextMenuStrip.Opening += new CancelEventHandler(ContextMenuStrip_Opening);
            statusStripLabel1.Text = statusStripLabel1.Text+": "+statusStripLabel1.StatusString;

            this.EditorContextMenuStripEx.Opened += new EventHandler(EditorContextMenuStripEx_Opened);

            ////Add tooltip
            this.radialMenu1.NextLevelOpening += new NextMenuLevelOpening(radialMenu1_NextLevelOpening);
            this.radialMenu1.PreviousLevelOpening += new PreviousMenuLevelOpening(radialMenu1_PreviousLevelOpening);
            this.radialMenu1.MenuVisibilityChanging += new StartMenulOpening(radialMenu1_MenuVisibilityChanging);
            this.radialMenu1.PreviousLevelOpened += radialMenu1_PreviousLevelOpened;
        }

        void radialMenu1_PreviousLevelOpened(object sender, PreviousLevelOpened e)
        {
            if (this.radialMenu1.ItemOnLoad == null)
            {
                this.radialMenu1.MenuIcon = global::Word2007Demo_2005.Properties.Resources._0000_Layer_4;
            }
        }

        void radialMenu1_MenuVisibilityChanging(object sender, MenuVisibilityChanging e)
        {
            if (!this.radialMenu1.MenuVisibility)
            {
                this.radialMenu1.MenuIcon = global::Word2007Demo_2005.Properties.Resources._0000_Layer_4;
            }
            else
            {
                    this.radialMenu1.Icon = global::Word2007Demo_2005.Properties.Resources._0003_Layer_1___Copy___Copy___Copy;
                    this.radialMenu1.MenuIcon = global::Word2007Demo_2005.Properties.Resources._0001_Layer_3;
                    this.radialMenu1.Refresh();
            }
        }

        void radialMenu1_PreviousLevelOpening(object sender, PreviousLevelOpening e)
        {
            visibility = true;
            if (!this.radialMenu1.MenuVisibility)
            {
                this.radialMenu1.Icon = global::Word2007Demo_2005.Properties.Resources._0003_Layer_1___Copy___Copy___Copy;
                this.radialMenu1.MenuIcon = global::Word2007Demo_2005.Properties.Resources._0000_Layer_4;
            }
        }
        private bool visibility = true;
        void radialMenu1_NextLevelOpening(object sender, NextLevelOpening e)
        {
            if (e.SelectedItem is RadialMenuSlider)
            {
                visibility = false;
            }
            else
            {
                visibility = true;
            }
            this.radialMenu1.Icon = global::Word2007Demo_2005.Properties.Resources._0003_Layer_1___Copy___Copy___Copy;
            this.radialMenu1.MenuIcon = global::Word2007Demo_2005.Properties.Resources._0001_Layer_3;
        }

        void EditorContextMenuStripEx_Closed(object sender, ToolStripDropDownClosedEventArgs e)
        {
            check = false;
        }

        void ContextMenuStrip_Opening(object sender, CancelEventArgs e)
        {
            statusStripEx1.ContextMenuStrip.Items[2].Text = "Page";  
        }

        # endregion
        
        # region Editor events

        private void growfontToolStripBtn_Click(object sender, EventArgs e)
        {
            if (this.toolStripFontSizeComboBox.SelectedItem.ToString() != "72")
                this.toolStripFontSizeComboBox.SelectedIndex++;
        }

        private void shrinkfontToolStripBtn_Click(object sender, EventArgs e)
        {
            if (this.toolStripFontSizeComboBox.SelectedItem.ToString() != "8")
                this.toolStripFontSizeComboBox.SelectedIndex--;
        }

        private void boldToolstripBtn_Click(object sender, EventArgs e)
        {
			this.boldToolstripBtn.Checked = !this.boldToolstripBtn.Checked;
            if (this.richTextBox1.SelectionFont != null)
            {
                if (!this.boldToolstripBtn.Checked)
                    this.richTextBox1.SelectionFont = new Font(this.richTextBox1.SelectionFont, (richTextBox1.SelectionFont.Style & ~(richTextBox1.SelectionFont.Style & FontStyle.Bold)));
                else
                    this.richTextBox1.SelectionFont = new Font(this.richTextBox1.SelectionFont, this.richTextBox1.SelectionFont.Style | FontStyle.Bold);
            }
        }

        private void italicToolStripBtn_Click(object sender, EventArgs e)
        {
            this.italicToolStripBtn.Checked = !this.italicToolStripBtn.Checked;
            if (this.richTextBox1.SelectionFont != null)
            {
                if (!this.italicToolStripBtn.Checked)
                    this.richTextBox1.SelectionFont = new Font(this.richTextBox1.SelectionFont, (richTextBox1.SelectionFont.Style & ~(richTextBox1.SelectionFont.Style & FontStyle.Italic)));
                else
                    this.richTextBox1.SelectionFont = new Font(this.richTextBox1.SelectionFont, this.richTextBox1.SelectionFont.Style | FontStyle.Italic);
            }
        }

        private void underlineToolStripSplitBtn_Click(object sender, EventArgs e)
        {
            if (this.richTextBox1.SelectionFont != null)
            {
                if (richTextBox1.SelectionFont.Underline)
                    this.richTextBox1.SelectionFont = new Font(this.richTextBox1.SelectionFont, (richTextBox1.SelectionFont.Style & ~(richTextBox1.SelectionFont.Style & FontStyle.Underline)));
                else
                    this.richTextBox1.SelectionFont = new Font(this.richTextBox1.SelectionFont, richTextBox1.SelectionFont.Style | FontStyle.Underline);
            }
        }

        private void strikethroToolStripBtn_Click(object sender, EventArgs e)
        {
            this.strikethroToolStripBtn.Checked = !this.strikethroToolStripBtn.Checked;
            if (this.richTextBox1.SelectionFont != null)
            {
                if (!this.strikethroToolStripBtn.Checked)
                    this.richTextBox1.SelectionFont = new Font(this.richTextBox1.SelectionFont, (richTextBox1.SelectionFont.Style & ~(richTextBox1.SelectionFont.Style & FontStyle.Strikeout)));
                else
                    this.richTextBox1.SelectionFont = new Font(this.richTextBox1.SelectionFont, richTextBox1.SelectionFont.Style | FontStyle.Strikeout);
            }
        }

        private void toolStripComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           // this.richTextBox1.SelectionFont = new Font(this.toolStripFontfaceComboBox.SelectedItem.ToString(), this.richTextBox1.SelectionFont.Size);
        }

        private void toolStripComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
           // this.richTextBox1.SelectionFont = new Font(this.richTextBox1.SelectionFont.Name, float.Parse(this.toolStripFontSizeComboBox.SelectedItem.ToString()));
        }

        private void cleartoolStripBtn_Click(object sender, EventArgs e)
        {
            this.richTextBox1.SelectionFont = font;
            this.richTextBox1.Font = font;
        }

        private void toolStripBtnCopy_Click(object sender, EventArgs e)
        {
			if(this.richTextBox1.SelectedText != null)
				this.richTextBox1.Copy();
        }

        private void toolStripBtnCut_Click(object sender, EventArgs e)
        {
			if (this.richTextBox1.SelectedText != null)
				this.richTextBox1.Cut();
        }

        private void toolStripBtnPaste_Click(object sender, EventArgs e)
        {
            this.richTextBox1.Paste();
        }

        private void deindentToolStripBtn_Click(object sender, EventArgs e)
        {
            if (this.richTextBox1.SelectionIndent > 0)
                this.richTextBox1.SelectionIndent = this.richTextBox1.SelectionIndent - 20;
        }

        private void inindentToolStripBtn_Click(object sender, EventArgs e)
        {
            this.richTextBox1.SelectionIndent = this.richTextBox1.SelectionIndent + 20;
        }

		private void selectAllToolStripMenuItem1_Click (object sender, EventArgs e)
		{
			richTextBox1.SelectAll();
		}

        private void undoToolStripBtn_Click(object sender, EventArgs e)
        {
            this.richTextBox1.Undo();
        }

        private void redoToolStripBtn_Click(object sender, EventArgs e)
        {
            this.richTextBox1.Redo();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            //UpdateCaretPos();
            RichTextBox r = new RichTextBox();
            string path = Application.StartupPath.ToString() + @"..\..\..\Introduction.rtf";
            r.LoadFile(path, RichTextBoxStreamType.RichText);
            this.undoToolStripBtn.Enabled = this.richTextBox1.CanUndo;
            this.redoToolStripBtn.Enabled = this.richTextBox1.CanRedo;
            this.radialMenuItem44.Enabled = !this.richTextBox1.Text.Equals(r.Text);
            this.radialMenuItem46.Enabled = !this.richTextBox1.Text.Equals(r.Text);
            this.radialMenuItem47.Enabled = this.richTextBox1.Text.Equals(r.Text);
            this.radialMenu1.Refresh();
        }

        # endregion

        # region SwitchThemes

		private void ColorSchemeItemCheck ( )
		{
			this.blueToolStripMenuItem.Checked = false;
			this.silverToolStripMenuItem.Checked = false;
			this.blackToolStripMenuItem.Checked = false;
		}

        // Blue Theme
        private void blueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ColorScheme = ColorSchemeType.Blue;
			this.scrollersFrame1.OfficeColorScheme = Office2007ColorScheme.Blue;

			ColorSchemeItemCheck();
			this.blueToolStripMenuItem.Checked = true;

           
            this.ribbonControlAdv1.Refresh();
        }

		// Silver Theme
		private void silverToolStripMenuItem_Click (object sender, EventArgs e)
		{
			this.ColorScheme = ColorSchemeType.Silver;
			this.scrollersFrame1.OfficeColorScheme = Office2007ColorScheme.Silver;

			ColorSchemeItemCheck();
			this.silverToolStripMenuItem.Checked = true;

            //this.gradientPanel1.BackgroundColor = new BrushInfo(GradientStyle.PathEllipse, Color.FromArgb(160, 164, 171), Color.FromArgb(204, 207, 216));
            this.ribbonControlAdv1.Refresh();
		}

		// Black theme
        private void blackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ColorScheme = ColorSchemeType.Black;
			this.scrollersFrame1.OfficeColorScheme = Office2007ColorScheme.Black;

			ColorSchemeItemCheck();
            this.blackToolStripMenuItem.Checked = true;
            
            //this.gradientPanel1.BackgroundColor = new BrushInfo(GradientStyle.PathEllipse, Color.FromArgb(57, 57, 57), Color.FromArgb(146, 148, 150));
            this.ribbonControlAdv1.Refresh();
        }

        # endregion
        private bool check = false;
        private void richTextBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if ((this.richTextBox1.SelectedText != String.Empty && e.Button == MouseButtons.Left) || e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                if (this.richTextBox1.SelectedText != String.Empty)
                {
                    this.radialMenu1.Icon = global::Word2007Demo_2005.Properties.Resources._0000_Layer_4;
                    this.radialMenu1.MenuIcon = global::Word2007Demo_2005.Properties.Resources._0000_Layer_4;
                    this.radialMenu1.Refresh();
                }
                Open = true;

            }
            else if (Open)
            {
                this.radialMenu1.HidePopup();
                this.richTextBox1.Select(0, 0);
                Open = false;
            }
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                this.radialMenu1.PopupHost.Location = new Point(Cursor.Position.X - this.radialMenu1.Width / 2, Cursor.Position.Y - this.radialMenu1.Height / 2);
            }
            else
            {
                setRadialMenuLocation();
            }
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                this.EditorContextMenuStripEx.Close();    
                //check = false;
            }
            if (this.richTextBox1.SelectedText == string.Empty)
            {
                this.radialMenu1.Icon = global::Word2007Demo_2005.Properties.Resources._0003_Layer_1___Copy___Copy___Copy;
                this.radialMenu1.MenuIcon = global::Word2007Demo_2005.Properties.Resources._0001_Layer_3;
                this.radialMenu1.Refresh();
            }
        }

        bool Open = false;
        //////////////////////////////////////////////////
        // To trigger click event for the gallery items //
        //////////////////////////////////////////////////
        private void toolStripGallery2_GalleryItemClicked(object sender, ToolStripGalleryItemEventArgs args)
        {
            switch (args.GalleryItem.Tag as string)
            {
                case "H1":
                    //MessageBox.Show("Gallery Item 1 is clicked");
                    break;
            }
        }

        //////////////////////////////////////////////////////////////////
        // Application will be closed on double clicking the menu button//
        /////////////////////////////////////////////////////////////////
        private void ribbonControlAdv1_MenuButtonDoubleClick(object sender, EventArgs e)
        {
           // this.Close();
        }

        void progressTimer_Tick(object sender, EventArgs e)
        {
            this.progressBarAdv.Value += 1;
            if (progressBarAdv.Value >= 100)
            {
                progressTimer.Stop();
                progressBarAdv.Value = 0;
                progressTimer.Start();
            }
        }

        void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void backStageTab9_Click(object sender, EventArgs e)
        {
            this.backStage1.Hide();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            using (Pen pen = new Pen(ColorTranslator.FromHtml("#c6c6c6")))
            {
                e.Graphics.DrawRectangle(pen, new Rectangle(0, 0, this.panel2.Width - 1, this.panel2.Height - 1));
            }
        }

        private void toolStripSplitButtonEx1_Click(object sender, EventArgs e)
        {
            this.richTextBox1.Paste();
        }
    }
    public class ContextMenuRenderer : ToolStripProfessionalRenderer
    {

        public ContextMenuRenderer()
        {

        }
        private Color menuBackColor = Color.LightSkyBlue;
        public Color MenuColor
        {
            get
            {
                return menuBackColor;
            }
            set
            {
                menuBackColor = value;
            }
        }
        /// <summary>
        /// Is triggered when the margin for the image is rendered.
        /// </summary>
        /// <param name="e"></param>
        protected override void OnRenderImageMargin(ToolStripRenderEventArgs e)
        {
            Rectangle marginRect = e.AffectedBounds;
            using (SolidBrush backBrush = new SolidBrush(Color.White))
            {
                e.Graphics.FillRectangle(backBrush, marginRect);
            }
        }
        protected override void OnRenderItemBackground(ToolStripItemRenderEventArgs e)
        {
            base.OnRenderItemBackground(e);
        }
        protected override void OnRenderMenuItemBackground(ToolStripItemRenderEventArgs e)
        {
            using (SolidBrush backBrush = new SolidBrush(ColorTranslator.FromHtml("#d5e1f2")))
            {
                if (e.Item.Selected)
                    e.Graphics.FillRectangle(backBrush, e.ToolStrip.Items[0].Bounds);
            }
        }
        /// <summary>
        /// Renders the image with different attributes
        /// </summary>
        /// <param name="e"></param>
        protected override void OnRenderItemImage(ToolStripItemImageRenderEventArgs e)
        {

            base.OnRenderItemImage(e);
        }

    }
}
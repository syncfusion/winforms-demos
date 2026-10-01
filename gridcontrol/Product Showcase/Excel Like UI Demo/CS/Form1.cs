#region Copyright Syncfusion Inc. 2001 - 2015
//
//  Copyright Syncfusion Inc. 2001 - 2015. All rights reserved.
//
//  Use of this code is subject to the terms of our license.
//  A copy of the current license can be obtained at any time by e-mailing
//  licensing@syncfusion.com. Any infringement will be prosecuted under
//  applicable laws. 
//
#endregion

using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections;
using System.ComponentModel;
using System.ComponentModel.Design;
using Syncfusion.Windows.Forms;
using Syncfusion.Windows.Forms.Design;
using Syncfusion.Collections;
using Syncfusion.ComponentModel;
using System.Drawing.Design;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Reflection;
using Syncfusion.Runtime.Serialization;

using Syncfusion.Windows.Forms.Grid;

using Syncfusion.Windows.Forms.Tools;
using Syncfusion.GridHelperClasses;

namespace ExcelLikeUI
{
    public partial class Form1 : RibbonForm
    {
        #region [private Variables ]
        private static int accCount = 1;
        Panel TabBarPane = new Panel();
        Panel newPanel = new Panel();
        #endregion

        #region [Constructor]
        public Form1()
        {
            InitializeComponent();
            this.excelRibbon.RibbonStyle = RibbonStyle.Office2013;
            try
            {
                System.Drawing.Icon ico = new System.Drawing.Icon(GetIconFile(@"Common\Images\Grid\Icon\sficon.ico"));
                this.Icon = ico;
            }
            catch { }

            this.BackStageInitializeComponent();
            this.backStageView1.HostForm = this;
            this.excelRibbon.BackStageView = this.backStageView1;
            newPanel.BorderStyle = BorderStyle.FixedSingle;
            xpToolBar1.Dock = DockStyle.Fill;
            newPanel.Size = xpToolBar1.Size;

            this.Controls.Remove(this.xpToolBar1);
            newPanel.Controls.Add(xpToolBar1);
        }
        #endregion

        #region "Image Loading Methods"
        //Get and Load the images
#if NET9_0_OR_GREATER
        private Image GetImage(string path)
        {
            System.Reflection.Assembly asm = System.Reflection.Assembly.GetExecutingAssembly();
            if (asm != null && !string.IsNullOrEmpty(path))
                return Image.FromStream(asm.GetManifestResourceStream(path));
            return null;
        }

        private void LoadImages(ImageList imageList, string folder, int count)
        {
            for (int i = 1; i <= count; i++)
            {
                string imagePath = ($"ExcelLikeUI.Images.{folder}.Image_{i}.png");
                imageList.Images.Add(GetImage(imagePath));
            }
        }
#endif
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

        #region [Methods]
        public void PopulateFonts()
        {
            foreach (FontFamily ff in FontFamily.Families)
            {
                if (ff.IsStyleAvailable(FontStyle.Regular))
                {
                    toolStripFontfaceComboBox.Items.Add(ff.Name);
                }
            }
        }
        #endregion

        #region[Form Load]
        private void Form1_Load(object sender, EventArgs e)
        {
            #region [Ribbon Related Changes]

            QuickItems();
            this.toolStripFontfaceComboBox.SelectedIndex = 0;
            this.toolStripFontSizeComboBox.SelectedIndex = 3;
            toolStripButton45.Checked = true;

            PopulateFonts();
            toolStripCheckBox1.Checked = true;
            toolStripCheckBox2.Checked = true;

            #region [Events]
            toolStripFontfaceComboBox.SelectedIndexChanged += new EventHandler(toolStripFontfaceComboBox_SelectedIndexChanged);
            toolStripFontSizeComboBox.SelectedIndexChanged += new EventHandler(toolStripFontSizeComboBox_SelectedIndexChanged);
            toolStripButton71.Click += new EventHandler(toolStripButton71_Click);
            toolStripButton74.Click += new EventHandler(toolStripButton74_Click);
            underlineToolStripSplitBtn.Click += new EventHandler(underlineToolStripSplitBtn_Click);
            italicToolStripBtn.Click += new EventHandler(italicToolStripBtn_Click);
            boldToolstripBtn.Click += new EventHandler(boldToolstripBtn_Click);
            topBorderToolStripButton.Click += topBorderToolStripButton_Click;
            bottomBorderToolStripButton.Click += bottomBorderToolStripButton_Click;
            leftBorderToolStripButton.Click += leftBorderToolStripButton_Click;
            rightBorderToolStripButton.Click += rightBorderToolStripButton_Click;
            wrapTextToolStripButton.Click += wrapTextToolStripButton_Click;
            mergeCenterToolStripButton.Click += mergeCenterToolStripButton_Click; freezeToolStripMenuItem.Click += new EventHandler(freezeToolStripMenuItem_Click);
            toolStripBtnCut.Click += new EventHandler(toolStripBtnCut_Click);
            toolStripPanelItem15.Click += new EventHandler(toolStripPanelItem15_Click);
            toolStripBtnCopy.Click += new EventHandler(toolStripBtnCopy_Click);
            toolStripButton59.Click += new EventHandler(toolStripButton_Click);
            toolStripButton60.Click += new EventHandler(toolStripButton_Click);
            toolStripButton61.Click += new EventHandler(toolStripButton_Click);
            lAlignToolStripBtn.Click += alignToolStripBtn_Click;
            rAlignToolStripBtn.Click += alignToolStripBtn_Click;
            centerToolStripBtn.Click += alignToolStripBtn_Click;
            toolStripButton46.Click += new EventHandler(toolStripButton46_Click);
            toolStripButton45.Click += new EventHandler(toolStripButton45_Click);
            toolStripCheckBox1.CheckedChanged += new EventHandler(toolStripCheckBox1_CheckedChanged);
            toolStripCheckBox2.CheckedChanged += new EventHandler(toolStripCheckBox2_CheckedChanged);
            this.toolStripDropDownButton1.DropDown = new CustomDropDown(this.colorPickerFont);
            this.toolStripDropDownButton2.DropDown = new CustomDropDown(this.colorPickerBackground);
            this.colorPickerFont.MouseUp += colorPicker_MouseUp;
            this.colorPickerBackground.MouseUp += colorPickerBackground_MouseUp;
            #endregion
            #endregion

            #region [WorkBook]
            // Create a new child
            WorkBook workBook = new WorkBook(this);
            this.gridAwareTextBoxItem1.WireGridAwareTextBox(workBook.gridAwareTextBox1, workBook._grid, true);
            this.gridAwareTextBoxItem2.WireGridAwareTextBox(workBook.gridAwareTextBox2, workBook._grid, false);
            this.workBook = workBook;
            Panel BackPanel = new Panel();
            Panel topPanel = new Panel();
            this.Controls.Add(this.xpToolBar1);
            topPanel.Dock = DockStyle.Top;
            TabBarPane.Size = new System.Drawing.Size(500, 500);
            
            BackPanel.Dock = DockStyle.Fill;
            TabBarPane.Controls.Add(workBook.tabBarSplitterControl);
            this.xpToolBar1.Bar.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.gridAwareTextBoxItem1,
            this.barItem1,
            this.barItem2,
            this.gridAwareTextBoxItem2});
            System.ComponentModel.ComponentResourceManager resources1 = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.barItem1.Image = ((Syncfusion.Windows.Forms.Tools.XPMenus.ImageExt)(resources1.GetObject("barItem1.Image")));
            this.barItem2.Image = ((Syncfusion.Windows.Forms.Tools.XPMenus.ImageExt)(resources1.GetObject("barItem2.Image")));
            
            workBook.tabBarSplitterControl.BringToFront();
            workBook.tabBarSplitterControl.Dock = DockStyle.Fill;
            
            TabBarPane.BringToFront();
            TabBarPane.Dock = DockStyle.Fill;
            BackPanel.Dock = DockStyle.Fill;
            this.Controls.Add(BackPanel);
            BackPanel.Controls.Add(TabBarPane);
            newPanel.Dock = DockStyle.Top;
            BackPanel.Controls.Add(newPanel);
             
            this.workBook.tabBarSplitterControl.EnableOffice2013Style = true;
            this.workBook.tabBarSplitterControl.ShowAddNewTabBarPageOption = true;
            this.workBook.tabBarSplitterControl.Style = TabBarSplitterStyle.Metro;
            excelRibbon.Header.QuickItemAdded += new ToolStripItemEventHandler(Header_QuickItemAdded);
            excelRibbon.Header.QuickItemRemoved += new ToolStripItemEventHandler(Header_QuickItemRemoved);
            workBook._grid.CurrentCellActivated += _grid_CurrentCellActivated;           

            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is MdiClient)
                {
                    MdiClient mdiClient = (MdiClient)ctrl;
                    mdiClient.BackColor = Color.FromArgb(165, 195, 239);
                }
            }
            #endregion
        }
        #endregion

        #region [BackStage]
        private void BackStageInitializeComponent()
        {
            this.backStageView1 = new Syncfusion.Windows.Forms.BackStageView(this.components);
            this.backStage1 = new Syncfusion.Windows.Forms.BackStage();
            this.saveBackStageButton = new Syncfusion.Windows.Forms.BackStageButton();
            this.openBackStageButton = new Syncfusion.Windows.Forms.BackStageButton();
            this.exitBackStageButton = new Syncfusion.Windows.Forms.BackStageButton();
            //newTabPanel = new NewTabPanel();
            ((System.ComponentModel.ISupportInitialize)(this.backStage1)).BeginInit();
            this.backStage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // backStageView1
            // 
            this.backStageView1.BackStage = this.backStage1;
            this.backStageView1.HostControl = null;
            // 
            // backStage1
            // 
            this.backStage1.AllowDrop = true;
            this.backStage1.BeforeTouchSize = new System.Drawing.Size(715, 449);
            this.backStage1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.backStage1.Controls.Add(this.openBackStageButton);
            this.backStage1.Controls.Add(this.saveBackStageButton);
            this.backStage1.Controls.Add(this.exitBackStageButton);
            this.backStage1.ItemSize = new System.Drawing.Size(138, 40);
            this.backStage1.Location = new System.Drawing.Point(1, 51);
            this.backStage1.Name = "backStage1";
            this.backStage1.OfficeColorScheme = Syncfusion.Windows.Forms.Tools.ToolStripEx.ColorScheme.Blue;
            this.backStage1.Size = new System.Drawing.Size(715, 449);
            this.backStage1.TabIndex = 4;
            // 
            // saveBackStageButton
            // 
            this.saveBackStageButton.Accelerator = "";
            this.saveBackStageButton.BackColor = System.Drawing.Color.Transparent;
            this.saveBackStageButton.BeforeTouchSize = new System.Drawing.Size(75, 23);
            this.saveBackStageButton.IsBackStageButton = false;
            this.saveBackStageButton.Location = new System.Drawing.Point(0, 53);
            this.saveBackStageButton.Name = "saveBackStageButton";
            this.saveBackStageButton.Size = new System.Drawing.Size(137, 38);
            this.saveBackStageButton.TabIndex = 4;
            this.saveBackStageButton.Text = "Save";
            this.saveBackStageButton.Click += saveAsBackStageButton_Click;
            
            // 
            // openBackStageButton
            // 
            this.openBackStageButton.Accelerator = "";
            this.openBackStageButton.BackColor = System.Drawing.Color.Transparent;
            this.openBackStageButton.BeforeTouchSize = new System.Drawing.Size(75, 23);
            this.openBackStageButton.IsBackStageButton = false;
            this.openBackStageButton.Location = new System.Drawing.Point(0, 53);
            this.openBackStageButton.Name = "openBackStageButton";
            this.openBackStageButton.Size = new System.Drawing.Size(137, 38);
            this.openBackStageButton.TabIndex = 4;
            this.openBackStageButton.Text = "Open";
            this.openBackStageButton.Click += openBackStageButton_Click;
            // 
            // exitBackStageButton
            // 
            this.exitBackStageButton.Accelerator = "";
            this.exitBackStageButton.BackColor = System.Drawing.Color.Transparent;
            this.exitBackStageButton.BeforeTouchSize = new System.Drawing.Size(75, 23);
            this.exitBackStageButton.IsBackStageButton = false;
            this.exitBackStageButton.Location = new System.Drawing.Point(0, 53);
            this.exitBackStageButton.Name = "exitBackStageButton";
            this.exitBackStageButton.Size = new System.Drawing.Size(137, 38);
            this.exitBackStageButton.TabIndex = 4;
            this.MinimumSize = new Size(867, 679);
            this.exitBackStageButton.Text = "Exit";
            this.exitBackStageButton.Click += new EventHandler(exitBackStageButton_Click);
            // 
            // 
            // 
            ((System.ComponentModel.ISupportInitialize)(this.backStage1)).EndInit();
            this.backStage1.ResumeLayout(false);
            this.ResumeLayout(false);
        }
        #endregion

        #region [Events]

        void openBackStageButton_Click(object sender, EventArgs e)
        {
            Syncfusion.GridExcelConverter.GridExcelConverterControl gecc = new Syncfusion.GridExcelConverter.GridExcelConverterControl();

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Files(*.xlsx)|*.xlsx";
            openFileDialog.DefaultExt = ".xlsx";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
                gecc.ExcelToGrid(openFileDialog.FileName, this.workBook._grid.Model);

            this.workBook._grid.Refresh();
            this.backStageView1.BackStage.Visible = false;
        }

        void saveAsBackStageButton_Click(object sender, EventArgs e)
        {
            Syncfusion.GridExcelConverter.GridExcelConverterControl gecc = new Syncfusion.GridExcelConverter.GridExcelConverterControl();

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Files(*.xlsx)|*.xlsx|Files(*.xls)|*.xls";
            saveFileDialog.DefaultExt = ".xlsx";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                gecc.GridToExcel(this.workBook._grid.Model, saveFileDialog.FileName);

                if (MessageBox.Show("Do you wish to open the xls file now?", "Export to Excel", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Process proc = new Process();
                    proc.StartInfo.FileName = saveFileDialog.FileName;
                    proc.StartInfo.UseShellExecute = true;
                    proc.Start();
                }
            }
            this.backStageView1.BackStage.Visible = false;
        }

        void exitBackStageButton_Click(object sender, EventArgs e)
        {
            this.backStageView1.HostForm.Close();
        }

        // Triggers when an item is added into quick access toolbar
        void Header_QuickItemAdded(object sender, ToolStripItemEventArgs e)
        {            
            this.superAccelerator1.SetAccelerator(e.Item, accCount.ToString());
            accCount++;
        }

        // Triggers when an item is removed into quick access toolbar
        void Header_QuickItemRemoved(object sender, ToolStripItemEventArgs e)
        {
            accCount--;
        }

        private void QuickItems()
        {
            ToolStripButton saveBtn = new ToolStripButton("Save");
            saveBtn.DisplayStyle = ToolStripItemDisplayStyle.Image;
            saveBtn.Image = this.imageList1.Images[0];
            saveBtn.Click += saveBtn_Click;
            excelRibbon.Header.AddQuickItem(saveBtn);
            
            ToolStripButton undoBtn = new ToolStripButton("Undo");
            undoBtn.DisplayStyle = ToolStripItemDisplayStyle.Image;
            undoBtn.Image  = this.imageList1.Images[1];
            excelRibbon.Header.AddQuickItem(undoBtn);
            undoBtn.Click += undoBtn_Click;

            ToolStripButton redoBtn = new ToolStripButton("Redo");
            redoBtn.DisplayStyle = ToolStripItemDisplayStyle.Image;
            redoBtn.Image = this.imageList1.Images[2];
            excelRibbon.Header.AddQuickItem(redoBtn);
            redoBtn.Click += redoBtn_Click;
        }

        void redoBtn_Click(object sender, EventArgs e)
        {
            if (!this.workBook._grid.CommandStack.InTransaction)
            {
                this.workBook._grid.CommandStack.Redo();
            }
        }

        void undoBtn_Click(object sender, EventArgs e)
        {
            if (!this.workBook._grid.CommandStack.InTransaction)
            {
                this.workBook._grid.CommandStack.Undo();
            }
        }

        void saveBtn_Click(object sender, EventArgs e)
        {
            Syncfusion.GridExcelConverter.GridExcelConverterControl gecc = new Syncfusion.GridExcelConverter.GridExcelConverterControl();

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Files(*.xlsx)|*.xlsx|Files(*.xls)|*.xls";
            saveFileDialog.DefaultExt = ".xlsx";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                gecc.GridToExcel(this.workBook._grid.Model, saveFileDialog.FileName);

                if (MessageBox.Show("Do you wish to open the xls file now?", "Export to Excel", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Process proc = new Process();
                    proc.StartInfo.FileName = saveFileDialog.FileName;
                    proc.StartInfo.UseShellExecute = true;
                    proc.Start();
                }
            }
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            this.gridAwareTextBoxItem2.MinWidth = this.Width -( this.gridAwareTextBoxItem1.MinWidth + 66 );
        }
        
        // Triggers when double-clicking the menu button.
        private void excelRibbon_MenuButtonDoubleClick(object sender, EventArgs e)
        {
            Close();
        }

        private void toolStripButton81_Click(object sender, EventArgs e)
        {
            WorkBook workBook = new WorkBook(this);
            workBook.MdiParent = this;
            workBook.Text = "WorkBook " + childWorkBookNumber++;
            workBook.Show();
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            Close();
        }
        
        private void toolStripPanelItem15_Click(object sender, EventArgs e)
        {
            workBook.Paste();
        }

        void toolStripBtnCut_Click(object sender, System.EventArgs e)
        {
            workBook.Cut();
        }

        void toolStripBtnCopy_Click(object sender, System.EventArgs e)
        {
            workBook.Copy();
        }

        void toolStripFontfaceComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            workBook.FontNameChanged(toolStripFontfaceComboBox.Text);
        }

        void toolStripFontSizeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            workBook.FontSizeChanged(toolStripFontSizeComboBox.Text);
        }

        void toolStripButton71_Click(object sender, EventArgs e)
        {
            float size = workBook.FontSizeIncrease();
            toolStripFontSizeComboBox.Text = size.ToString();
        }

        void toolStripButton74_Click(object sender, EventArgs e)
        {
            float size = workBook.FontSizeDecrease();
            toolStripFontSizeComboBox.Text = size.ToString();
        }

        void underlineToolStripSplitBtn_Click(object sender, EventArgs e)
        {
            underlineToolStripSplitBtn.Checked = !underlineToolStripSplitBtn.Checked;
            workBook.UnderLine(underlineToolStripSplitBtn.Checked);
        }

        void boldToolstripBtn_Click(object sender, EventArgs e)
        {
            boldToolstripBtn.Checked = !boldToolstripBtn.Checked;
            workBook.Bold(boldToolstripBtn.Checked);
        }  

        void mergeCenterToolStripButton_Click(object sender, EventArgs e)
        {
            mergeCenterToolStripButton.Checked = !mergeCenterToolStripButton.Checked;
            workBook.MergeCells(mergeCenterToolStripButton.Checked);
        }

        void wrapTextToolStripButton_Click(object sender, EventArgs e)
        {
            wrapTextToolStripButton.Checked = !wrapTextToolStripButton.Checked;
            workBook.WrapText(wrapTextToolStripButton.Checked);
        }

        void topBorderToolStripButton_Click(object sender, EventArgs e)
        {
            workBook.TopBorder();
        }

        void rightBorderToolStripButton_Click(object sender, EventArgs e)
        {
            workBook.RightBorder();
        }

        void leftBorderToolStripButton_Click(object sender, EventArgs e)
        {
            workBook.LeftBorder();
        }

        void bottomBorderToolStripButton_Click(object sender, EventArgs e)
        {
            workBook.BottomBorder();
        }

        private void noBorderToolStripButton5_Click(object sender, EventArgs e)
        {
            workBook.NoBorder();
        }

        void italicToolStripBtn_Click(object sender, EventArgs e)
        {
            italicToolStripBtn.Checked = !italicToolStripBtn.Checked;
            workBook.Italic(italicToolStripBtn.Checked);
        }

        void toolStripButton_Click(object sender, EventArgs e)
        {
            toolStripButton59.Checked = toolStripButton60.Checked = toolStripButton61.Checked = false;
            if ((sender as ToolStripButton).Text == toolStripButton59.Text && !toolStripButton59.Checked)
            {
                toolStripButton59.Checked = !toolStripButton59.Checked;
                workBook.TopAlign(toolStripButton59.Checked);
            }
            else if ((sender as ToolStripButton).Text == toolStripButton60.Text && !toolStripButton60.Checked)
            {
                toolStripButton60.Checked = !toolStripButton60.Checked;
                workBook.MiddleAlign(toolStripButton60.Checked);
            }
            else if ((sender as ToolStripButton).Text == toolStripButton61.Text && !toolStripButton61.Checked)
            {
                toolStripButton61.Checked = !toolStripButton61.Checked;
                workBook.BottomAlign(toolStripButton61.Checked);
            }

        }
        
        void alignToolStripBtn_Click(object sender, EventArgs e)
        {
            lAlignToolStripBtn.Checked = rAlignToolStripBtn.Checked = centerToolStripBtn.Checked = false;
            if ((sender as ToolStripButton).Text == lAlignToolStripBtn.Text && !lAlignToolStripBtn.Checked)
            {
                lAlignToolStripBtn.Checked = !lAlignToolStripBtn.Checked;
                workBook.LeftAlign(lAlignToolStripBtn.Checked);
            }
            else if ((sender as ToolStripButton).Text == centerToolStripBtn.Text && !centerToolStripBtn.Checked)
            {
                centerToolStripBtn.Checked = !centerToolStripBtn.Checked;
                workBook.CenterAlign(centerToolStripBtn.Checked);
            }
            else if ((sender as ToolStripButton).Text == rAlignToolStripBtn.Text && !rAlignToolStripBtn.Checked)
            {
                rAlignToolStripBtn.Checked = !rAlignToolStripBtn.Checked;
                workBook.RightAlign(rAlignToolStripBtn.Checked);
            }
        }

        void toolStripButton46_Click(object sender, EventArgs e)
        {
            if (!toolStripButton46.Checked)
            {
                workBook.PageLayout(true);
                toolStripButton45.Checked = false;
                toolStripButton46.Checked = true;
            }
        }

        void toolStripButton45_Click(object sender, EventArgs e)
        {
            if (!toolStripButton45.Checked)
            {
                workBook.PageLayout(false);
                toolStripButton46.Checked = false;
                toolStripButton45.Checked = true;
            }
        }

        void toolStripCheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (toolStripCheckBox2.Checked)
            {
                workBook.ShowRowHeader(true);
            }
            else
            {
                workBook.ShowRowHeader(false);
            }
        }

        void toolStripCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (toolStripCheckBox1.Checked)
            {
                workBook.ShowLines(true);
            }
            else
            {
                workBook.ShowLines(false);
            }
        }

        void freezeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!freezeToolStripMenuItem.Checked)
            {
                workBook.Freeze(true);
                freezeToolStripMenuItem.Checked = true;
            }
            else
            {
                workBook.Freeze(false);
                freezeToolStripMenuItem.Checked = false;
            }
        }

        bool flag;

        void colorPicker_MouseUp(object sender, MouseEventArgs e)
        {
            workBook.TextColorChanged(this.colorPickerFont.SelectedColor);
            this.toolStripDropDownButton1.HideDropDown();
            this.toolStripDropDownButton1.BackColor = this.colorPickerFont.SelectedColor;
        }

        void colorPickerBackground_MouseUp(object sender, MouseEventArgs e)
        {
            workBook.BackColorChanged(this.colorPickerBackground.SelectedColor);
            this.toolStripDropDownButton2.HideDropDown();
            this.toolStripDropDownButton2.BackColor = this.colorPickerBackground.SelectedColor;
        }

        void _grid_CurrentCellActivated(object sender, EventArgs e)
        {
            this.UpdateFontStyles(workBook._grid); ;
        }

        public void UpdateFontStyles(GridControl _grid)
        {
            flag = false;
            if (this.boldToolstripBtn != null)
                this.boldToolstripBtn.Checked = _grid[_grid.CurrentCell.RowIndex, _grid.CurrentCell.ColIndex].Font.Bold;

            if (this.underlineToolStripSplitBtn != null)
                this.underlineToolStripSplitBtn.Checked = _grid[_grid.CurrentCell.RowIndex, _grid.CurrentCell.ColIndex].Font.Underline;

            if (this.italicToolStripBtn != null)
                this.italicToolStripBtn.Checked = _grid[_grid.CurrentCell.RowIndex,_grid.CurrentCell.ColIndex].Font.Italic;

            if (this.toolStripFontSizeComboBox != null)
                this.toolStripFontSizeComboBox.Text = _grid[_grid.CurrentCell.RowIndex, _grid.CurrentCell.ColIndex].Font.Size.ToString();

            if (this.toolStripFontfaceComboBox != null)
                toolStripFontfaceComboBox.Text = _grid[_grid.CurrentCell.RowIndex, _grid.CurrentCell.ColIndex].Font.Facename;

            lAlignToolStripBtn.Checked = _grid[_grid.CurrentCell.RowIndex, _grid.CurrentCell.ColIndex].HorizontalAlignment == GridHorizontalAlignment.Left;
            centerToolStripBtn.Checked = _grid[_grid.CurrentCell.RowIndex, _grid.CurrentCell.ColIndex].HorizontalAlignment == GridHorizontalAlignment.Center;
            rAlignToolStripBtn.Checked = _grid[_grid.CurrentCell.RowIndex, _grid.CurrentCell.ColIndex].HorizontalAlignment == GridHorizontalAlignment.Right;

            toolStripButton59.Checked = _grid[_grid.CurrentCell.RowIndex,_grid.CurrentCell.ColIndex].VerticalAlignment == GridVerticalAlignment.Top;
            toolStripButton60.Checked = _grid[_grid.CurrentCell.RowIndex,_grid.CurrentCell.ColIndex].VerticalAlignment == GridVerticalAlignment.Middle;
            toolStripButton61.Checked = _grid[_grid.CurrentCell.RowIndex,_grid.CurrentCell.ColIndex].VerticalAlignment == GridVerticalAlignment.Bottom;

            mergeCenterToolStripButton.Checked = (_grid.Model.CoveredRanges.Ranges.Contains(GridRangeInfo.Cell(_grid.CurrentCell.RowIndex, _grid.CurrentCell.ColIndex)));//ActiveRange.Left == _grid.CurrentCell.ColIndex);
            foreach (GridRangeInfo range in _grid.Model.CoveredRanges.Ranges)
            {
                if (range.Top == _grid.CurrentCell.RowIndex && range.Left == _grid.CurrentCell.ColIndex)
                {
                    flag = true;
                    break;
                }
            }
            mergeCenterToolStripButton.Checked = flag;
            //(_grid.Model.Selections.Ranges.ActiveRange));// == _grid.CurrentCell.RowIndex && _grid.Model.CoveredRanges.Ranges.ActiveRange.Left == _grid.CurrentCell.ColIndex);
            wrapTextToolStripButton.Checked = _grid[_grid.CurrentCell.RowIndex, _grid.CurrentCell.ColIndex].WrapText;
        }

        void barItem2_Click(object sender, EventArgs e)
        {
            workBook.AcceptChanges();            
        }

        void barItem1_Click(object sender, EventArgs e)
        {
            workBook.RejectChanges();
        }

        #endregion
    }

    #region [Custom DropDown]
    //Creates the CustomDropDown class which has a color picker.
    public class CustomDropDown : ToolStripDropDown
    {
        public CustomDropDown(ColorPickerUIAdv colorPic)
        {
            this.Items.Add(new ToolStripControlHost(colorPic));
        }
    }
    #endregion
}

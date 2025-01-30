#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Syncfusion.Windows.Forms.Tools;
using Syncfusion.WinForms.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using WF_Word.Properties;

namespace WF_Word
{
    public partial class Form1 : RibbonForm
    {
        #region Fields

        SfButton button;
        ContextMenuStrip menuStrip;
        ToolStripMenuItem toolStripMenuItem1;
        ToolStripMenuItem toolStripMenuItem2;
        ToolStripMenuItem toolStripMenuItem3;
        ToolStripMenuItem toolStripMenuItem4;
        ToolStripSeparator separator;
        StringReader myReader;
        Dictionary<string, DateTime> lastOpened = new Dictionary<string, DateTime>();
        string[] drives;
        PrintDialog print = new PrintDialog();

        ColorPickerUIAdv colorpicker1 = new ColorPickerUIAdv();
        ColorPickerUIAdv colorpicker2 = new ColorPickerUIAdv();
        NumericUpDownExt leftNumeric = new NumericUpDownExt();
        NumericUpDownExt rightNumeric = new NumericUpDownExt();

        int indentText;
        Size savedsize = Size.Empty;
        Point savedLocation = Point.Empty;
        ToolStripItem lastclickedItem;
        ToolStripItem lastclickedmarginItem;
        ToolStripItem lastclickedsizeItem;
        private Office2016ColorTable office2016ColorTable1 = new Office2016ColorTable();
        #endregion

        #region Constructor and Loading function
        public Form1()
        {
            InitializeComponent();
            this.backStage1.VisibleFullText = true;
            this.sizeComboBox.Validated += SizeComboBox_Validated;
            this.fontComboBox.Validated += FontComboBox_Validated;
            this.wordribbon.MenuButtonClick += Wordribbon_MenuButtonClick;
            this.treeNavigator3.Visible = false;
            this.treeNavigator2.SelectionChanged += treeNavigator1_SelectionChanged;
#if NETCORE
            this.richTextBox1.LoadFile("..//..//..//temp.rtf");
            InfoTabLabelUpdate("..//..//..//temp.rtf");
#else
            this.richTextBox1.LoadFile("..//..//temp.rtf");
            InfoTabLabelUpdate("..//..//temp.rtf");
#endif
            this.rtbpanel.AutoScroll = true;
            this.rtbpanel.Dock = DockStyle.Fill;
            this.richTextBox1.Height = 1600;
            this.wordribbon.SelectedTab = this.insertTab;
            this.trackBarItem1.TrackBarExControl.Style = TrackBarEx.Theme.Office2016Colorful;
            this.printDocument.PrintPage += PrintDocument_PrintPage;
            StoreToGroupView();
            this.treeNavigator1.SelectedItem = this.recenttreeMenuItem;
            this.treeNavigator1.SelectedItem = this.SaveAsPCtreeMenuItem;
            this.groupView1.BackColor = Color.FromArgb(241, 241, 241);
            this.groupView1.HighlightItemColor =Color.FromArgb(197, 197, 197);
            this.groupView2.BackColor = Color.FromArgb(241, 241, 241);
            this.groupView2.HighlightItemColor = Color.FromArgb(197, 197, 197);
            drives = Directory.GetLogicalDrives();
            this.WindowState = FormWindowState.Maximized;
            foreach (string printer in System.Drawing.Printing.PrinterSettings.InstalledPrinters)
            {
                this.printerComboBox.Items.Add(printer);
            }
            foreach (object page in print.PrinterSettings.PaperSizes)
                this.pageSizecomboBox.Items.Add(page);
            this.collatedcomboBox.Items.Add("UnCollated");
            this.collatedcomboBox.Items.Add("Collated");
            this.orientationComboBox.Items.Add("Portrait Orientation");
            this.orientationComboBox.Items.Add("Landscape Orientation");
            this.collatedcomboBox.SelectedIndex = 0;
            this.orientationComboBox.SelectedIndex = 0;
            this.pageSizecomboBox.SelectedIndex = 0;
            this.printerComboBox.SelectedIndex = 1;
            foreach (FontFamily oneFontFamily in FontFamily.Families)
            {
                fontComboBox.Items.Add(oneFontFamily.Name);
            }
            sizeComboBox.Text = this.richTextBox1.Font.Size.ToString();
            fontComboBox.Text = this.richTextBox1.Font.FontFamily.Name;
            fontComboBox.ComboBox.TextBox.SelectionStart = 0;
            splitContainerAdv1.IsSplitterFixed = true;
            this.colorpicker1.Picked += Colorpicker1_Picked;
            this.colorpicker2.Picked += Colorpicker2_Picked;
            ToolStripButton saveItem = new ToolStripButton(Resources.Save16flat);
            QuickButtonReflectable quick = new QuickButtonReflectable(saveItem);
            this.wordribbon.Header.AddQuickItem(quick);
            this.wordribbon.TouchMode = true;
            indentText = this.richTextBox1.SelectionIndent;
            this.wordribbon.MenuColor = ColorTranslator.FromHtml("#2a579a");
            richTextBox1.SelectionStart = 0;
            richTextBox1.SelectedText = "\n\n";
            richTextBox1.SelectAll();
            richTextBox1.SelectionIndent = 50;
            richTextBox1.SelectionRightIndent = 50;
            richTextBox1.SelectionLength = 0;
            richTextBox1.DeselectAll();
            this.wordribbon.QuickPanelVisible = true;
            this.wordribbon.ThemeName = "Office2019Colorful";    
            this.Load += Form1_Load;
            this.backStage1.VisibleChanged += BackStage1_VisibleChanged;
            this.toolStripMenuItem1 = new ToolStripMenuItem();
            this.toolStripMenuItem1.Text = "user@syncfusion.com";
#if NETCORE
            this.toolStripMenuItem1.Image = Image.FromFile("..//..//..//Resources/customImage.png");
#else
            this.toolStripMenuItem1.Image = Image.FromFile("..//..//Resources/customImage.png");
#endif
            this.toolStripMenuItem2 = new ToolStripMenuItem();
            this.toolStripMenuItem2.Text = "View Account";
            this.separator = new ToolStripSeparator();
            this.toolStripMenuItem3 = new ToolStripMenuItem();
            this.toolStripMenuItem3.Height = 50;
            this.toolStripMenuItem3.Text = "Sign-in with different account";
#if NETCORE
            this.toolStripMenuItem3.Image = Image.FromFile("..//..//..//Resources/AddUser.png");
#else
            this.toolStripMenuItem3.Image = Image.FromFile("..//..//Resources/AddUser.png");
#endif
            this.toolStripMenuItem4 = new ToolStripMenuItem();
            this.toolStripMenuItem4.Text = "Sign out";
            this.menuStrip = new ContextMenuStrip();
            this.menuStrip.Items.AddRange(new ToolStripItem[] { this.toolStripMenuItem1, this.toolStripMenuItem2, this.separator, this.toolStripMenuItem3, this.toolStripMenuItem4 });
            this.button = new SfButton();
            this.button.ForeColor = Color.White;
            this.button.Font= Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.button.Size = new System.Drawing.Size(75, 50);
            this.button.Text = "Sign-In";
            this.button.Style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.button.Style.HoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(141)))), ((int)(((byte)(212)))));
            this.button.Style.FocusedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(87)))), ((int)(((byte)(154)))));
            this.button.Style.PressedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(87)))), ((int)(((byte)(154)))));
            this.button.Style.PressedForeColor = Color.White;
            this.button.Style.HoverForeColor = Color.White;
            this.button.Style.FocusedForeColor = Color.White;
#if NETCORE
            this.button.Image = Image.FromFile("..//..//..//Resources/customImage.png");
#else
            this.button.Image = Image.FromFile("..//..//Resources/customImage.png");
#endif
            this.button.Click += Button_Click;
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(button, "Click here to view details");
            this.HeaderItem = button;
        }

        private void BackStage1_VisibleChanged(object sender, EventArgs e)
        {
            if(this.backStage1.Visible)
            {
                this.statusStripEx1.Visible = false;
                this.statusStripEx1.Dock = DockStyleEx.None;
            }
            else
            {
                this.statusStripEx1.Visible = true;
                this.statusStripEx1.Dock = DockStyleEx.Bottom;
            }
        }

        private void Button_Click(object sender, EventArgs e)
        {
            menuStrip.Show(button, new Point(0, button.Height));
        }

        int storedfontindex = 0;
        int storedsizeindex = 0;
        private void SizeComboBox_Validated(object sender, EventArgs e)
        {
            if (sizeComboBox.SelectedIndex == -1)
            {
                sizeComboBox.SelectedIndex = storedsizeindex;
            }
        }
        private void FontComboBox_Validated(object sender, EventArgs e)
        {
            if (fontComboBox.SelectedIndex == -1)
            {
                fontComboBox.SelectedIndex = storedfontindex;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            savedsize = this.rtbpanel.Size;
            savedLocation = this.rtbpanel.Location;
            this.highlightSplitButton.DropDown = new CustomDropDown(colorpicker1);
            this.fontColorSplitButton.DropDown = new CustomDropDown(colorpicker2);
            AddNumericUpDownToPanelItem();
            this.richTextBox1.SelectionChanged += RichTextBox1_SelectionChanged;
        }

     
#endregion

#region To Avoid Flickering
        //protected override CreateParams CreateParams
        //{
        //    get
        //    {
        //        CreateParams cp = base.CreateParams;
        //        cp.ExStyle |= 0x02000000;   // WS_EX_COMPOSITED
        //        return cp;
        //    }
        //}

#endregion

#region Info Tab
        private void InfoTabLabelUpdate(string FileName)
        {
            if (!string.IsNullOrEmpty(FileName))
            {
                FileInfo fileInformation = new FileInfo(FileName);
                lengthvaluelabel.Text = this.richTextBox1.TextLength.ToString() + "characters";
                documentLabel.Text = fileInformation.Name;
                sizevaluelabel.Text = (fileInformation.Length / 1000).ToString() + " KB";
                createdTimeValuelabel.Text = fileInformation.CreationTime.ToString();
                lastAccessValueLabel.Text = fileInformation.LastAccessTime.ToString();
            }
        }

        void ResetLabels()
        {
            lengthvaluelabel.Text = this.richTextBox1.TextLength.ToString() + "characters";
            documentLabel.Text = "Info";
            sizevaluelabel.Text = "0 KB";
            createdTimeValuelabel.Text = DateTime.Now.ToString();
            lastAccessValueLabel.Text = "";
        }
#endregion

#region New Tab       
        private void blankDocumentbutton_Click(object sender, EventArgs e)
        {
            this.richTextBox1.ResetText();
            ResetLabels();
            this.wordribbon.BackStageView.HideBackStage();
            //this.richTextBox1.LoadFile()
        }

        private void specButton_Click(object sender, EventArgs e)
        {
            this.richTextBox1.LoadFile("..//..//Document1.rtf");
            this.wordribbon.BackStageView.HideBackStage();
        }

        private void reportdesignButton_Click(object sender, EventArgs e)
        {
            this.richTextBox1.LoadFile("..//..//Document2.rtf");
            this.wordribbon.BackStageView.HideBackStage();
        }

        private void resumeButton_Click(object sender, EventArgs e)
        {
            this.richTextBox1.LoadFile("..//..//Document3.rtf");
            this.wordribbon.BackStageView.HideBackStage();
        }

        private void coverLetterbutton_Click(object sender, EventArgs e)
        {
            this.richTextBox1.LoadFile("..//..//Document4.rtf");
            this.wordribbon.BackStageView.HideBackStage();
        }



#endregion

#region Open Tab 
        private void treeNavigator4_SelectionChanged(TreeNavigator sender, SelectionStateChangedEventArgs e)
        {
            this.openDocumentbutton.Text = e.SelectedItem.Text;
            TreenavigatorItemsUpdate(this.treeNavigator4, e);
        }

        private void browseMenuItem_Click()
        {
            OpenFile("Documents");
        }
        private void openDocumentbutton_Click(object sender, EventArgs e)
        {
            OpenFile(this.openDocumentbutton.Text);
        }
        private void OpenFile(string Path)
        {
            // Create an OpenFileDialog to request a file to open.
            OpenFileDialog openFile1 = new OpenFileDialog();

            // Initialize the OpenFileDialog to look for RTF files.
            openFile1.DefaultExt = "*.rtf";
            openFile1.Filter = "RTF Files|*.rtf";
            openFile1.InitialDirectory = Path;
            openFile1.RestoreDirectory = true;
            // Determine whether the user selected a file from the OpenFileDialog.
            if (openFile1.ShowDialog() == System.Windows.Forms.DialogResult.OK &&
               openFile1.FileName.Length > 0)
            {
                // Load the contents of the file into the RichTextBox.
                richTextBox1.LoadFile(openFile1.FileName, RichTextBoxStreamType.PlainText);
            }
            SaveDataToXML(openFile1.SafeFileName, openFile1.FileName, DateTime.Now);
            StoreToGroupView();
            //FileInfo fileinformation = new FileInfo(openFile1.FileName);
            InfoTabLabelUpdate(openFile1.FileName);
            //fileinformation.
            this.backStageView1.HideBackStage();
        }
        private void treeNavigator1_SelectionChanged(TreeNavigator sender, SelectionStateChangedEventArgs e)
        {
            if (e.SelectedItem == thisPCtreeMenuItem)
            {
                groupView1.Visible = false;
                openTabPCPanel.Visible = true;
                FillThisPCItems(this.treeNavigator4);
            }
            else
            {
                groupView1.Visible = true;
                openTabPCPanel.Visible = false;
            }
        }

        void StoreToGroupView()
        {
            string PATH = "..//..//xmldata.xml";
            string fName = string.Empty, path = string.Empty, date = string.Empty;
            if (System.IO.File.Exists(PATH))
            {
                XmlDocument xmldoc = new XmlDocument();
#if NET40
                xmldoc.XmlResolver = null;
#endif
                xmldoc.Load(PATH);
                XmlNode root = xmldoc.DocumentElement;

                foreach (XmlNode box in root)
                {
                    switch (box.Name)
                    {
                        case "FileName": fName = box.InnerText; break;
                        case "Path": path = box.InnerText; break;
                        case "DateTime": date = box.InnerText; break;
                    }
                }
                if (!CheckForPresentItems(fName))
                {
                    this.groupView1.GroupViewItems.Add(new GroupViewItem(fName + "\n" + path + "\t\t\t" + date, -1));
                    this.groupView2.GroupViewItems.Add(new GroupViewItem(fName + "\n" + path + "\t\t\t" + date, -1));
                }
            }
        }

        bool CheckForPresentItems(string Name)
        {
            bool present = false;
            for (int i = 0; i < this.groupView1.GroupViewItems.Count; i++)
            {
                if (this.groupView1.GroupViewItems[i].Text.StartsWith(Name))
                    present = true;
            }
            return present;
        }

        void SaveDataToXML(string name, string data, DateTime date)
        {
            string PATH = "..//..//xmldata.xml";
            XmlDocument doc = new XmlDocument();

            //If there is no current file, then create a new one
            if (!System.IO.File.Exists(PATH))
            {
                //Create neccessary nodes

                XmlElement root = doc.CreateElement("Details");
                XmlElement FileName = doc.CreateElement("FileName");
                XmlElement Path = doc.CreateElement("Path");
                XmlElement Date = doc.CreateElement("DateTime");

                //Add the values for each nodes
                FileName.InnerText = name;
                Path.InnerText = data;
                Date.InnerText = date.ToString();

                //Construct the document

                doc.AppendChild(root);
                root.AppendChild(FileName);
                root.AppendChild(Path);
                root.AppendChild(Date);

                doc.Save(PATH);
            }
            else //If there is already a file
            {
                //Load the XML File
#if NET40
                doc.XmlResolver = null;
#endif
                doc.Load(PATH);

                //Get the root element
                XmlElement root = doc.DocumentElement;

                XmlElement FileName = doc.CreateElement("FileName");
                XmlElement Path = doc.CreateElement("Path");
                XmlElement Date = doc.CreateElement("DateTime");

                //Add the values for each nodes
                FileName.InnerText = name;
                Path.InnerText = data;
                Date.InnerText = date.ToString();

                root.AppendChild(FileName);
                root.AppendChild(Path);
                root.AppendChild(Date);

                //Save the document
                doc.Save(PATH);
            }


        }

#endregion

#region Print tab 
        private void PrintDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs ev)
        {
            float linesPerPage = 0;
            float yPosition = 0;
            int count = 0;
            float leftMargin = ev.MarginBounds.Left;
            float topMargin = ev.MarginBounds.Top;
            string line = null;
            Font printFont = this.richTextBox1.Font;
            SolidBrush myBrush = new SolidBrush(Color.Black);

            // Work out the number of lines per page, using the MarginBounds.
            linesPerPage = ev.MarginBounds.Height / printFont.GetHeight(ev.Graphics);

            // Iterate over the string using the StringReader, printing each line.
            while (count < linesPerPage && ((line = myReader.ReadLine()) != null))
            {
                // calculate the next line position based on 
                // the height of the font according to the printing device
                yPosition = topMargin + (count * printFont.GetHeight(ev.Graphics));

                // draw the next line in the rich edit control

                ev.Graphics.DrawString(line, printFont, myBrush, leftMargin, yPosition, new StringFormat());
                count++;
            }

            // If there are more lines, print another page.
            if (line != null)
                ev.HasMorePages = true;
            else
                ev.HasMorePages = false;

            myBrush.Dispose();
        }

        private void Wordribbon_MenuButtonClick(object sender, EventArgs e)
        {
            string strText = this.richTextBox1.Text;
            myReader = new StringReader(strText);
            printPreviewControl.Document = printDocument;
          
        }

        private void printButton_Click(object sender, EventArgs e)
        {

            print.PrinterSettings.Copies = (short)this.copiesnumericUpDownExt1.Value;
            print.PrinterSettings.PrinterName = this.printerComboBox.SelectedItem.ToString();
            print.PrinterSettings.Collate = this.collatedcomboBox.SelectedIndex == 1 ? true : false;
            printDocument.DefaultPageSettings.Landscape = this.orientationComboBox.SelectedIndex == 1 ? true : false;
            //print.ShowDialog();
            switch(this.printerComboBox.SelectedItem.ToString())
            {
                case "Send To OneNote 2016":
                    break;
                case "Microsoft XPS Document Writer":
                    {
                        SaveFileDialog sd = new SaveFileDialog();
                        sd.Title = "Save Print Output As";
                        sd.DefaultExt = "*.oxps";
                        sd.Filter = "XPS Document|*.xps|OpenXPS Document|*.oxps";
                        sd.ShowDialog();
                    }
                    break;
                case "Microsoft Print to PDF":
                    {
                        SaveFileDialog sd = new SaveFileDialog();
                        sd.Title = "Save Print Output As";
                        sd.DefaultExt = "*.pdf";
                        sd.Filter = "PDF files|*.pdf";
                        sd.ShowDialog();
                    } break;
                case "Fax":
                    {

                    } break;
            }
            this.wordribbon.BackStageView.HideBackStage();
        }

        private void pageSetUplinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PageSetupDialog pg = new PageSetupDialog();

            pg.Document = printDocument;

            pg.ShowDialog();
        }

        private void printerComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.printerComboBox.SelectedItem != null)
                print.PrinterSettings.PrinterName = this.printerComboBox.SelectedItem.ToString();
            print.PrinterSettings.Collate = this.collatedcomboBox.SelectedIndex == 1 ? true : false;
            printDocument.DefaultPageSettings.Landscape = this.orientationComboBox.SelectedIndex == 1 ? true : false;
        }

#endregion

#region Save tab
        private void documentbutton_Click(object sender, EventArgs e)
        {
            SaveFile(documentbutton.Text);
        }

        private void SaveFile(string path)
        {
            SaveFileDialog saveFile1 = new SaveFileDialog();

            saveFile1.DefaultExt = "*.rtf";
            saveFile1.Filter = "RTF Files|*.rtf";

           if (path.Equals("Desktop"))
                path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            saveFile1.InitialDirectory = "@" + path;
            saveFile1.RestoreDirectory = true;
            if (saveFile1.ShowDialog() == System.Windows.Forms.DialogResult.OK &&
               saveFile1.FileName.Length > 0)
            {
                richTextBox1.SaveFile(saveFile1.FileName, RichTextBoxStreamType.PlainText);
            }
        }
        private void buttonAdv1_Click(object sender, EventArgs e)
        {
            if (this.SavetextBox.Text.Length > 0)
            {
                richTextBox1.SaveFile(this.SavetextBox.Text, RichTextBoxStreamType.PlainText);
            }
        }

        private void saveBrowsebutton_Click(object sender, EventArgs e)
        {
            SaveFile("Documents");
        }

        private void openBrowsebutton_Click(object sender, EventArgs e)
        {
            browseMenuItem_Click();
        }



        private void upOneLevelbutton_Click(object sender, EventArgs e)
        {
            this.groupView2.Visible = false;
            this.treeNavigator3.Visible = true;
            this.treeNavigator3.Size = this.groupView2.Size;
            this.treeNavigator3.Location = this.groupView2.Location;
            this.upOneLevelbutton.Enabled = true;

            if (documentbutton.Text.Equals("Document"))
            {
                this.documentbutton.Text = "This PC";
                this.upOneLevelbutton.Enabled = false;
                FillThisPCItems(this.treeNavigator3);
            }

            //string folder[]=
        }
        private void FillThisPCItems(TreeNavigator tree)
        {
            tree.Items.Add(new TreeMenuItem() { Text = "Desktop" });
            tree.Items.Add(new TreeMenuItem() { Text = "Documents" });
            foreach (string s in drives)
            {
                tree.Items.Add(new TreeMenuItem() { Text = s });
            }
        }
        private void treeNavigator3_SelectionChanged(TreeNavigator sender, SelectionStateChangedEventArgs e)
        {
            this.upOneLevelbutton.Enabled = true;
            this.documentbutton.Text = e.SelectedItem.Text;
            TreenavigatorItemsUpdate(treeNavigator3, e);
        }

        private void TreenavigatorItemsUpdate(TreeNavigator sender, SelectionStateChangedEventArgs e)
        {
            TreeNavigator tree = sender as TreeNavigator;
            int i = 2;
            if (e.SelectedItem.Text.Equals("Desktop"))
            {
                string[] folders = System.IO.Directory.GetDirectories(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "*", System.IO.SearchOption.TopDirectoryOnly);
                foreach (string folder in folders)
                {
                    (tree.Items[0] as TreeMenuItem).Items.Add(new TreeMenuItem() { Text = folder });
                }
            }
            if (e.SelectedItem.Text.Equals("Documents"))
            {
                string[] folders = System.IO.Directory.GetDirectories(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "*", System.IO.SearchOption.TopDirectoryOnly);
                foreach (string folder in folders)
                {
                    (tree.Items[1] as TreeMenuItem).Items.Add(new TreeMenuItem() { Text = folder });
                }
            }
            foreach (string s in drives)
            {
                if (s.Equals(e.SelectedItem.Text))
                {
                    string[] folders = System.IO.Directory.GetDirectories(s, "*", SearchOption.TopDirectoryOnly);
                    foreach (string folder in folders)
                    {
                        DirectoryInfo info = new DirectoryInfo(folder);
                        try
                        {
                            if ((info.Attributes & FileAttributes.Hidden) != FileAttributes.Hidden || (info.Attributes & FileAttributes.System) != FileAttributes.System)
                            {
                                (tree.Items[i] as TreeMenuItem).Items.Add(new TreeMenuItem() { Text = folder });
                            }
                        }
                        catch (UnauthorizedAccessException)
                        {

                        }

                    }
                }
                i++;
            }
        }

        private void savebackStageTab_Click(object sender, EventArgs e)
        {
            this.backStage1.SelectedTab = this.saveAsbackStageTab;
        }

        private void backStage1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (backStage1.SelectedTab == saveAsbackStageTab)
                this.splitContainerAdv1.SplitterDistance = this.treeNavigator2.Width;
        }

#endregion

#region Close tab
        private void closebackStageButton_Click(object sender, EventArgs e)
        {
            this.wordribbon.BackStageView.HideBackStage();
        }
#endregion

#region Clipboard
        private void pasteSplitButton_ButtonClick(object sender, EventArgs e)
        {
            this.richTextBox1.Paste();
        }

        private void cutButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.richTextBox1.SelectedText))
            {
                Clipboard.SetText(this.richTextBox1.SelectedText);
                this.richTextBox1.Cut();
            }
            //this.richTextBox1.de
        }

        private void copyButton_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(this.richTextBox1.SelectedText))
            {
                Clipboard.SetText(this.richTextBox1.SelectedText);
                this.richTextBox1.Copy();
            }
            //c
        }

#endregion

#region Font

        private void RichTextBox1_SelectionChanged(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionFont != null)
            {
                FontStyle style = this.richTextBox1.SelectionFont.Style;
                if (style == FontStyle.Bold)
                    this.boldToolStripButton.Checked = true;
                else if (style == FontStyle.Italic)
                    this.italicToolStripButton.Checked = true;
                else if (style == FontStyle.Strikeout)
                    this.strikeThroughButton.Checked = true;
                else if (style == FontStyle.Underline)
                    this.underlineButton.Checked = true;
                else if (style == FontStyle.Regular)
                {
                    this.boldToolStripButton.Checked = false;
                    this.italicToolStripButton.Checked = false;
                    this.strikeThroughButton.Checked = false;
                    this.underlineButton.Checked = false;
                }
            }
            else
            {
                this.boldToolStripButton.Checked = false;
                this.italicToolStripButton.Checked = false;
                this.strikeThroughButton.Checked = false;
                this.underlineButton.Checked = false;
            }
        }

        private void fontComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string font = this.fontComboBox.Text;
            if (this.sizeComboBox.Items.Contains(this.sizeComboBox.Text))
            {
                float size = Convert.ToSingle(this.sizeComboBox.Text);
                richTextBox1.SelectionFont = new Font(font, size);
            }
            if (fontComboBox.SelectedIndex != -1)
            {
               storedfontindex =  fontComboBox.SelectedIndex;
            }
            if(fontComboBox.SelectedIndex == -1)
            {
                fontComboBox.SelectedIndex = storedfontindex;
            }
            if(sizeComboBox.SelectedIndex != -1)
            {
                storedsizeindex = sizeComboBox.SelectedIndex;
            }
            if(sizeComboBox.SelectedIndex == -1)
            {
                sizeComboBox.SelectedIndex = storedsizeindex;
            }
        }

        private void increaseFontSizeButton_Click(object sender, EventArgs e)
        {
            float size = this.richTextBox1.Font.Size + 1;
            richTextBox1.SelectionFont = new Font(richTextBox1.Font.FontFamily, size);
        }

        private void decreaseFontSizeButton_Click(object sender, EventArgs e)
        {
            float size = this.richTextBox1.Font.Size - 1;
            richTextBox1.SelectionFont = new Font(richTextBox1.Font.FontFamily, size);
        }

        private void changeCaseDropDownButton_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem == this.upperCaseToolStripMenuItem)
                richTextBox1.SelectedText = richTextBox1.SelectedText.ToUpper();
            else if(e.ClickedItem == this.lowerCaseToolStripMenuItem)
                richTextBox1.SelectedText = richTextBox1.SelectedText.ToLower();
            else if(e.ClickedItem == this.sentenceCaseToolStripMenuItem)
            {
                string[] rtftextarray = richTextBox1.SelectedText.Split('.');
                richTextBox1.SelectedText = UppercaseFirst(rtftextarray);
                //foreach (string str in rtftextarray)
                //    richTextBox1.SelectedText += str;
            }
            else if(e.ClickedItem==this.capitializeEachWordToolStripMenuItem)
            {
                TextInfo textInfo = CultureInfo.CurrentCulture.TextInfo;
                richTextBox1.Text = textInfo.ToTitleCase(richTextBox1.Text);
            }
        }
        private string UppercaseFirst(string[] s)
        {
            string[] result = new string[] { };
            string strt = string.Empty;
            //int i = 0;
            foreach (string str in s)
            {
               strt+= char.ToUpper(str[0]) + str.Substring(1);
                //richTextBox1.SelectedText = result;
            }
            return strt;
            //return char.ToUpper(s[0]) + s.Substring(1);
        }
        private string[] CaptializeWord(string[] values)
        {

            string[] rtfText = new string[] { };
            TextInfo ti = CultureInfo.CurrentCulture.TextInfo;
            for(int i=0;i<values.Count();i++)
            //foreach (string text in values)
            {
                string text = values[i];
                text=ti.ToTitleCase(text);
                rtfText[i] += text;
            }
            return rtfText;
        }

        public void FormatSelectedString()
        {
            FontStyle style = FontStyle.Regular;
            if (boldToolStripButton.Checked)
            {
                style |= FontStyle.Bold;
            }
            if (strikeThroughButton.Checked)
            {
                style |= FontStyle.Strikeout;
            }
            if (underlineButton.Checked)
            {
                style |= FontStyle.Underline;
            }
            if (italicToolStripButton.Checked)
            {
                style |= FontStyle.Italic;
            }
            this.richTextBox1.SelectionFont = new Font(this.richTextBox1.Font.FontFamily, this.richTextBox1.Font.Size, style);
        }

        private void boldToolStripButton_Click(object sender, EventArgs e)
        {
            FormatSelectedString();
        }

        private void superScriptButton_Click(object sender, EventArgs e)
        {
            subScriptButton.Checked = false;
            if (superScriptButton.Checked)
                this.richTextBox1.SelectionCharOffset = 10;
            else
                this.richTextBox1.SelectionCharOffset = 0;
        }

        private void subScriptButton_Click(object sender, EventArgs e)
        {
            superScriptButton.Checked = false;
            if (subScriptButton.Checked)
                this.richTextBox1.SelectionCharOffset = -10;
            else
                this.richTextBox1.SelectionCharOffset = 0;
        }

        private void FonttoolStrip_LauncherClick(object sender, System.EventArgs e)
        {
            FontLauncherWindow font = new FontLauncherWindow(richTextBox1);
            font.Show();
        }

#endregion

#region Picture 
        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            OpenFileDialog OpenFileDialog1 = new OpenFileDialog();
            OpenFileDialog1.Filter = "All files |*.*";
            OpenFileDialog1.Multiselect = true;
            object orgdata = Clipboard.GetDataObject();

            if (OpenFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                foreach (string fname in OpenFileDialog1.FileNames)
                {
                    Image img = Image.FromFile(fname);
                    Clipboard.SetImage(img);
                    richTextBox1.Paste();

                }
            }
            Clipboard.SetDataObject(orgdata);
        }
#endregion

#region Paragraph 

        private void bulletSplitButton_ButtonClick(object sender, EventArgs e)
        {
            this.richTextBox1.SelectionBullet = true;
        }

        private void Colorpicker2_Picked(object sender, ColorPickerUIAdv.ColorPickedEventArgs args)
        {
            this.richTextBox1.SelectionColor = args.Color;
        }
        private void Colorpicker1_Picked(object sender, ColorPickerUIAdv.ColorPickedEventArgs args)
        {
            this.richTextBox1.SelectionBackColor = args.Color;
        }
        private void incIndentButton_Click(object sender, EventArgs e)
        {
            this.richTextBox1.SelectionIndent = indentText++;
        }
        private void decIndentButton_Click(object sender, EventArgs e)
        {
            this.richTextBox1.SelectionIndent = indentText--;
        }
        private void RightButton_Click(object sender, System.EventArgs e)
        {
            this.richTextBox1.SelectionAlignment = HorizontalAlignment.Right;
        }
        private void CenterButton_Click(object sender, System.EventArgs e)
        {
            this.richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
        }
        private void LeftButton_Click(object sender, System.EventArgs e)
        {
            this.richTextBox1.SelectionAlignment = HorizontalAlignment.Left;
        }

        private void bulletSplitButton_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem == noneMenuItem)
                this.richTextBox1.SelectionBullet = false;
            else
                this.richTextBox1.SelectionBullet = true;
        }
#endregion

#region PageSetUp

        private void coverPageDropDownButton_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
#if !NETCORE
            if (e.ClickedItem == specDesignToolStripMenuItem)
                this.richTextBox1.LoadFile("..//..//Document1.rtf");
            if (e.ClickedItem == reportDeisgnToolStripMenuItem)
                this.richTextBox1.LoadFile("..//..//Document2.rtf");
            if (e.ClickedItem == resumeToolStripMenuItem)
                this.richTextBox1.LoadFile("..//..//Document3.rtf");
            if (e.ClickedItem == coverLetterToolStripMenuItem)
                this.richTextBox1.LoadFile("..//..//Document4.rtf");
#else
            if (e.ClickedItem == specDesignToolStripMenuItem)
                this.richTextBox1.LoadFile("..//..//..//Document1.rtf");
            if (e.ClickedItem == reportDeisgnToolStripMenuItem)
                this.richTextBox1.LoadFile("..//..//..//Document2.rtf");
            if (e.ClickedItem == resumeToolStripMenuItem)
                this.richTextBox1.LoadFile("..//..//..//Document3.rtf");
            if (e.ClickedItem == coverLetterToolStripMenuItem)
                this.richTextBox1.LoadFile("..//..//..//Document4.rtf");
#endif
        }
        private void pageSetUptoolStrip_LauncherClick(object sender, EventArgs e)
        {
            PageSetupDialog pg = new PageSetupDialog();
            pg.Document = printDocument;
            if(pg.ShowDialog()== DialogResult.OK)
            {
                ApplyPageSettings(pg);
            }
        }
        void ApplyPageSettings(PageSetupDialog pagesetup)
        {
            ApplyPageSize(pagesetup.PageSettings.PaperSize.ToString());
            richTextBox1.SelectAll();
            richTextBox1.SelectionIndent = pagesetup.PageSettings.Margins.Left;
            richTextBox1.SelectionRightIndent = pagesetup.PageSettings.Margins.Right;
            richTextBox1.SelectionLength = 0;
            richTextBox1.DeselectAll();
            if (pagesetup.PageSettings.Landscape)
            {
                SetLandscapeSize(1.75F);
            }
            else
                SetNormalSize();
        }

        void ApplyPageSize(string toolstripItem)
        {
            if (toolstripItem.Equals("Letter"))
            {
                SetLandscapeSize(2);
            }
            else if (toolstripItem.Equals("Legal"))
            {
                SetLandscapeSize(2);
            }
            if (toolstripItem.Equals("A3"))
            {
                SetLandscapeSize(1.3F);
            }
            if (toolstripItem.Equals("A4"))
            {
                SetLandscapeSize(2.3F);
            }
            if (toolstripItem.Equals("Tabloid"))
            {
                SetLandscapeSize(1.75F);
            }
            if (toolstripItem.Equals("Executive"))
            {
                SetLandscapeSize(1.3F);
            }
        }

        private void orientationDropDownButton_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem != lastclickedItem)
            {
                if (e.ClickedItem == this.landscapeToolStripMenuItem)
                {
                    savedsize = this.rtbpanel.Size;
                    savedLocation = this.rtbpanel.Location;
                    SetLandscapeSize(1.75F);
                }
                else
                {
                    this.rtbpanel.Size = savedsize;
                    this.rtbpanel.Location = savedLocation;
                }
                lastclickedItem = e.ClickedItem;
            }
        }
        void SetLandscapeSize(float width)
        {
            this.rtbpanel.Width = (int)((this.Width) / width);
            this.rtbpanel.Location = new Point((this.Width - this.rtbpanel.Width) / 2, this.rtbpanel.Location.Y);
        }
        void SetNormalSize()
        {
            this.rtbpanel.Size = savedsize;
            this.rtbpanel.Location = savedLocation;
        }
        private void marginDropDownButton_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem != lastclickedmarginItem)
            {
                if (e.ClickedItem == normalToolStripMenuItem)
                {
                    richTextBox1.SelectAll();
                    richTextBox1.SelectionIndent = 80;
                    richTextBox1.SelectionRightIndent = 80;
                    richTextBox1.SelectionLength = 0;
                    richTextBox1.DeselectAll();
                }
                else if (e.ClickedItem == moderateToolStripMenuItem)
                {
                    richTextBox1.SelectAll();
                    richTextBox1.SelectionIndent = 60;
                    richTextBox1.SelectionRightIndent = 60;
                    richTextBox1.SelectionLength = 0;
                    richTextBox1.DeselectAll();
                }
                else if (e.ClickedItem == wideToolStripMenuItem)
                {
                    richTextBox1.SelectAll();
                    richTextBox1.SelectionIndent = 190;
                    richTextBox1.SelectionRightIndent = 190;
                    richTextBox1.SelectionLength = 0;
                    richTextBox1.DeselectAll();
                }
                else if (e.ClickedItem == narrowToolStripMenuItem)
                {
                    richTextBox1.SelectAll();
                    richTextBox1.SelectionIndent = 30;
                    richTextBox1.SelectionRightIndent = 30;
                    richTextBox1.SelectionLength = 0;
                    richTextBox1.DeselectAll();
                }
                lastclickedmarginItem = e.ClickedItem;
            }
        }

        private void sizeDropDownButton_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem != lastclickedsizeItem)
            {
                if (e.ClickedItem == letterToolStripMenuItem)
                {
                    SetLandscapeSize(2);
                }
                else if (e.ClickedItem == legalToolStripMenuItem)
                {
                    SetLandscapeSize(2);
                }
                if (e.ClickedItem == a3ToolStripMenuItem)
                {
                    SetLandscapeSize(1.3F);
                }
                if (e.ClickedItem == a4ToolStripMenuItem)
                {
                    SetLandscapeSize(2.3F);
                }
                if (e.ClickedItem == tabloidToolStripMenuItem)
                {
                    SetLandscapeSize(1.75F);
                }
                if (e.ClickedItem == executiveToolStripMenuItem)
                {
                    SetLandscapeSize(1.3F);
                }
            }
            lastclickedsizeItem = e.ClickedItem;
        }


#endregion

#region Layout Paragraph
        private void paragraphToolStrip_LauncherClick(object sender, EventArgs e)
        {
            ParagraphLauncher para = new WF_Word.ParagraphLauncher(richTextBox1);
            para.Show();
        }

        void AddNumericUpDownToPanelItem()
        {
            leftNumeric.Size = new System.Drawing.Size(90, 20);
            leftNumeric.Value = 0;
            leftNumeric.VisualStyle = Syncfusion.Windows.Forms.VisualStyle.Metro;
            leftNumeric.Minimum = 0;
            leftNumeric.Maximum = 500;
            leftNumeric.Increment = 1;
            leftNumeric.ValueChanged += LeftNumeric_ValueChanged;
            leftNumeric.VisualStyle = Syncfusion.Windows.Forms.VisualStyle.Office2016Colorful;
            ToolStripControlHost host1 = new ToolStripControlHost(leftNumeric);
            this.leftPanelItem.Items.Add(host1);
            rightNumeric.Size = new System.Drawing.Size(90, 20);
            rightNumeric.Value = 0;
            rightNumeric.Minimum = 0;
            rightNumeric.Maximum = 500;
            rightNumeric.Increment = 1;
            rightNumeric.VisualStyle = Syncfusion.Windows.Forms.VisualStyle.Metro;
            rightNumeric.ValueChanged += RightNumeric_ValueChanged;
            rightNumeric.VisualStyle = Syncfusion.Windows.Forms.VisualStyle.Office2016Colorful;
            ToolStripControlHost host2 = new ToolStripControlHost(rightNumeric);
            this.rightPanelItem.Items.Add(host2);
        }

        private void RightNumeric_ValueChanged(object sender, EventArgs e)
        {
            this.richTextBox1.SelectionRightIndent = (int)this.rightNumeric.Value;
        }

        private void LeftNumeric_ValueChanged(object sender, EventArgs e)
        {
            this.richTextBox1.SelectionIndent = (int)this.leftNumeric.Value;
        }




#endregion

        private void Form1_Resize(object sender, EventArgs e)
        {
            int X = (this.Width / 2) - (this.richTextBox1.Width / 2);
            this.richTextBox1.Location = new Point(X, this.richTextBox1.Location.Y);
        }

        private void toolStripGallery1_GalleryItemClicked(object sender, ToolStripGalleryItemEventArgs args)
        {
            if (toolStripGallery1.Items.IndexOf(toolStripGallery1.SelectedItem) == 0)
            {
                richTextBox1.SelectionFont = new System.Drawing.Font("Times New Roman", 11F);
                richTextBox1.SelectionColor = Color.Black;
            }
            else if (toolStripGallery1.Items.IndexOf(toolStripGallery1.SelectedItem) == 1)
            {
                richTextBox1.SelectionFont = new System.Drawing.Font("Segoe UI", 20F);
                richTextBox1.SelectionColor = Color.DarkBlue;
            }
            else if (toolStripGallery1.Items.IndexOf(toolStripGallery1.SelectedItem) == 2)
            {
                richTextBox1.SelectionFont = new System.Drawing.Font("Segoe UI", 18F);
                richTextBox1.SelectionColor = Color.DarkBlue;
            }
            else if (toolStripGallery1.Items.IndexOf(toolStripGallery1.SelectedItem) == 3)
            {
                richTextBox1.SelectionFont = new System.Drawing.Font("Segoe UI", 16F);
                richTextBox1.SelectionColor = Color.DarkBlue;
            }
            else if (toolStripGallery1.Items.IndexOf(toolStripGallery1.SelectedItem) == 4)
            {
                richTextBox1.SelectionFont = new System.Drawing.Font("Segoe UI", 14F);
                richTextBox1.SelectionColor = Color.DarkBlue;
            }
            else if (toolStripGallery1.Items.IndexOf(toolStripGallery1.SelectedItem) == 5)
            {
                richTextBox1.SelectionFont = new System.Drawing.Font("Segoe UI", 22F, FontStyle.Bold);
                richTextBox1.SelectionColor = Color.Black;
            }
            else if (toolStripGallery1.Items.IndexOf(toolStripGallery1.SelectedItem) == 6)
            {
                richTextBox1.SelectionFont = new System.Drawing.Font("Segoe UI", 15F, FontStyle.Italic);
                richTextBox1.SelectionColor = Color.Black;
            }
            else if (toolStripGallery1.Items.IndexOf(toolStripGallery1.SelectedItem) == 7)
            {
                richTextBox1.SelectionFont = new System.Drawing.Font("Segoe UI", 14F, FontStyle.Bold);
                richTextBox1.SelectionColor = Color.Black;
            }
            else if (toolStripGallery1.Items.IndexOf(toolStripGallery1.SelectedItem) == 8)
            {
                richTextBox1.SelectionFont = new System.Drawing.Font("Segoe UI", 14F, FontStyle.Underline);
                richTextBox1.SelectionColor = Color.Black;
            }
            else if (toolStripGallery1.Items.IndexOf(toolStripGallery1.SelectedItem) == 9)
            {
                richTextBox1.SelectionFont = new System.Drawing.Font("Segoe UI", 14F, FontStyle.Italic);
                richTextBox1.SelectionColor = Color.Black;
            }
        }
    }

#region Custom DropDown
    /// <summary>
    ///  Custom dropdown for DropDownbutton
    /// </summary>
    public class CustomDropDown:ToolStripDropDown
    {
        public CustomDropDown(ColorPickerUIAdv colorpicker)
        {
            this.Height = colorpicker.Height;
            this.Items.Add(new ToolStripControlHost(colorpicker));
        }
    }
#endregion
}

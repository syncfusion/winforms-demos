#region Copyright Syncfusion Inc. 2001 - 2018
//
//  Copyright Syncfusion Inc. 2001 - 2018. All rights reserved.
//
//  Use of this code is subject to the terms of our license.
//  A copy of the current license can be obtained at any time by e-mailing
//  licensing@syncfusion.com. Any infringement will be prosecuted under
//  applicable laws. 
//
#endregion

#region namespace
using Syncfusion.Windows.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Syncfusion.Windows.Forms.Tools;
using Syncfusion.Windows.Forms.Tools.XPMenus;
using Syncfusion.WinForms.Controls;
using Syncfusion.WinForms.Core;
using Syncfusion.Windows.Forms.Edit.Enums;
using System.Drawing.Drawing2D;
using Syncfusion.Windows.Forms.Edit.Interfaces;
using Syncfusion.Windows.Forms.Edit;
using System.Diagnostics;
using Syncfusion.Windows.Forms.Edit.Dialogs;
using Syncfusion.Windows.Forms.Edit.Utils;
#endregion

namespace Customization
{
    public partial class Form1 : SfForm
    {
        #region Variables

#if NETCORE
        /// <summary>
        /// Holds the default configuration file
        /// </summary>
        private string Defaultconfig = Path.GetDirectoryName(Application.ExecutablePath) + @"\..\..\..\config.xml";
        
        /// <summary>
        /// Holds the black theme configuration file
        /// </summary>
        private string blackThemeConfig = Path.GetDirectoryName(Application.ExecutablePath) + @"\..\..\..\BlackThemeConfig.xml";

        private string BasePath = Path.GetDirectoryName(Application.ExecutablePath) + @"\..\..\..\Test Files\";
#else
                /// <summary>
        /// Holds the default configuration file
        /// </summary>
        private string Defaultconfig = Path.GetDirectoryName(Application.ExecutablePath) + @"\..\..\config.xml";
        
        /// <summary>
        /// Holds the black theme configuration file
        /// </summary>
        private string blackThemeConfig = Path.GetDirectoryName(Application.ExecutablePath) + @"\..\..\BlackThemeConfig.xml";

        private string BasePath = Path.GetDirectoryName(Application.ExecutablePath) + @"\..\..\Test Files\";
#endif

        /// <summary>
        //Store the lexem name invoking the ContextPrompt popup
        /// </summary>
        string contextPromptLexem = "";

#endregion

#region Constructor

        /// <summary>
        /// Constructor
        /// </summary>
        public Form1()
        {
            InitializeComponent();
#if NETCORE
            List<string> languageList = new List<string>();
            languageList.Add("CSharp");
            languageList.Add("PowerShell");
            languageList.Add("HTML");
            languageList.Add("XML");
            languageList.Add("PASCAL");
            languageList.Add("HTML with Embeded JavaScript");
            languageList.Add("HTML with VBScript");
            languageList.Add("Delphi");
            languageList.Add("SQL");
            languageList.Add("Java");
            languageList.Add("VB.Net");
            languageList.Add("VBScript");
            languageList.Add("JScript");
            sfComboBox1.DataSource = languageList;
#else
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.sfComboBox1.DataSource = ((object)(resources.GetObject("sfComboBox1.DataSource")));
#endif

            try
            {
#if NETCORE
                System.Drawing.Icon ico = new System.Drawing.Icon(GetIconFile(GetIconFile(@"..\\..\\..\\\logo.ico")));
#else
                System.Drawing.Icon ico = new System.Drawing.Icon(GetIconFile(GetIconFile(@"..\\..\\\logo.ico")));
#endif
                this.Icon = ico;
            }
            catch { }
        }

#endregion

#region Events

        private void EditControl1_ContextChoiceBeforeOpen(object sender, CancelEventArgs e)
        {
            ILexem lex;
            ILexemLine lexemLine = this.editControl1.GetLine(this.editControl1.CurrentLine);

            //Gets the index of the current word in that line
            int ind = GetContextPromptCharIndex(lexemLine);

            if (ind <= 0)
            {
                e.Cancel = true;
                return;
            }
            lex = lexemLine.LineLexems[ind - 1] as ILexem;

            // If the count is less than '2', do not show the ContextPrompt popup
            if (lexemLine.LineLexems.Count < 2)
                e.Cancel = true;
            else
            {
                // Display ContextChoice popup if the lexem used to invoke them is "this" or "me" only
                if ((lex.Text == "Chat") || (lex.Text == "Database") || (lex.Text == "NewFile") || (lex.Text == "Find") || (lex.Text == "Home") || (lex.Text == "PieChart") || (lex.Text == "Tools"))
                {
                    this.contextPromptLexem = lex.Text;
                    e.Cancel = false;
                }
                else
                    e.Cancel = true;
            }
        }

        private void EditControl1_ContextPromptOpen(object sender, Syncfusion.Windows.Forms.Edit.ContextPromptUpdateEventArgs e)
        {
            if (this.contextPromptLexem != "")
            {
                PopulateContextPromptItems(e);
            }

        }

        private void PopulateContextPromptItems(ContextPromptUpdateEventArgs e)
        {

            switch (this.contextPromptLexem)
            {
                case "Activate":
                    e.List.Clear();
                    e.AddPrompt("Void.Form.Activate()", "Activate the form and give it focus");
                    e.AddPrompt("", "Activate the form and give it focus");
                    break;
                case "ActiveControl":
                    e.List.Clear();
                    e.AddPrompt("Control.Container.ActiveControl", "{get;set;}");
                    e.AddPrompt("", "Gets or Set the Active Control");
                    break;
                case "ActiceMDIChild":
                    e.List.Clear();
                    e.AddPrompt("ActiceMDIChild)", "");
                    e.AddPrompt("", "Activates the MDIChild of form");
                    break;
                case "AutoScroll":
                    e.List.Clear();
                    e.AddPrompt("AutoScroll", "Gets or sets the value indicating Autoscroll");
                    break;
                case "AcceptButton":
                    e.List.Clear();
                    e.AddPrompt("Void.Form.Activate()", "Activate the form and give it focus");
                    e.AddPrompt("", "Activate the form and give it focus");
                    break;
                case "BackColor":
                    e.List.Clear();
                    e.AddPrompt("", "Specifies the back color of the form.");
                    break;
                case "BackgroundImage":
                    e.List.Clear();
                    e.AddPrompt("BackgroundImage)", "");
                    e.AddPrompt("", "Gets or sets the background image displayed in the control.");
                    break;
                case "BackgroundImageLayout":
                    e.List.Clear();
                    e.AddPrompt("AutoScroll", "Gets or sets the background image layout as defined in the System.Windows.Forms.ImageLayout.");
                    break;
                case "CancelButton":
                    e.List.Clear();
                    e.AddPrompt("", "Gets or sets the button control that is clicked when the user presses the ESC key.");
                    break;
                case "CanFocus":
                    e.List.Clear();
                    e.AddPrompt("", "Invalidate");
                    e.AddPrompt("Gets a value indicating whether the control can receive focus", "");
                    break;
                case "CanSelect":
                    e.List.Clear();
                    e.AddPrompt("", "Gets a value indicating whether the control can be selected");
                    break;
            }
        }

        private void editControl1_ContextPromptSelectionChanged(Syncfusion.Windows.Forms.Edit.Forms.Popup.ContextPrompt sender, Syncfusion.Windows.Forms.Edit.ContextPromptSelectionChangedEventArgs e)
        {
            Console.WriteLine("SelectedIndex : " + e.SelectedIndex.ToString());
            Console.WriteLine("ContextPromptSelectionChanged");
        }
        
        private void EditControl1_ContextPromptClose(object sender, Syncfusion.Windows.Forms.Edit.ContextPromptCloseEventArgs e)
        {
            this.contextPromptLexem = "";
        }

        private int GetContextPromptCharIndex(ILexemLine line)
        {
            int lastPos = -1;

            for (int i = 0; i < line.LineLexems.Count; i++)
            {
                ILexem lex = line.LineLexems[i] as ILexem;

                if (lex.Text == "(")
                    lastPos = i;
            }

            return lastPos;
        }

        private void editControl1_ContextChoiceBeforeOpen(object sender, System.ComponentModel.CancelEventArgs e)
        {
            ILexem lex;
            ILexemLine lexemLine = this.editControl1.GetLine(this.editControl1.CurrentLine);

            //Gets the index of the current word in that line
            int ind = GetContextChoiceCharIndex(lexemLine);

            if (ind <= 0)
            {
                e.Cancel = true;
                return;
            }

            lex = lexemLine.LineLexems[ind - 1] as ILexem;

            // If the count is less than '2', do not show the ContextChoice popup
            if (lexemLine.LineLexems.Count < 2)
                e.Cancel = true;
            else
            {
                if ((lex.Text == "this") || (lex.Text == "me" || lex.Text == "bar1" || lex.Text == "Activate" || lex.Text == "ActiveControl" || lex.Text == "Invalidate" ||
                    lex.Text == "ActiceMDIChild" || lex.Text == "AutoScroll" || lex.Text == "Focus" || lex.Text == "CanSelect" || lex.Text == "BackgroundImageLayout"
                    || lex.Text == "CancelButton" || lex.Text == "CanFocus" || lex.Text == "BackgroundImage" || lex.Text == "AcceptButton" || lex.Text == "BackColor" || lex.Text == "CanSelect"))
                    e.Cancel = false;
                else
                    e.Cancel = true;
            }
        }

        private void editControl1_ContextChoiceOpen(Syncfusion.Windows.Forms.Edit.Interfaces.IContextChoiceController controller)
        {
            controller.Items.Add("Activate", "Activate the form and give it focus", this.editControl1.ContextChoiceController.Images["Image0"]);
            controller.Items.Add("ActiveControl", "Gets or sets the Active Control", this.editControl1.ContextChoiceController.Images["Image1"]);
            controller.Items.Add("ActiceMDIChild", "Activates the MDIChild of form", this.editControl1.ContextChoiceController.Images["Image3"]);
            controller.Items.Add("AutoScroll", "Gets or sets the value indicating Autoscroll", this.editControl1.ContextChoiceController.Images["Image4"]);
            controller.Items.Add("AcceptButton", "Gets or sets the button on the form that is clicked when the user presses the ENTER key", this.editControl1.ContextChoiceController.Images["Image2"]);
            controller.Items.Add("BackColor", "Specifies the back color of the form.", this.editControl1.ContextChoiceController.Images["Image6"]);
            controller.Items.Add("BackgroundImage", "Gets or sets the background image displayed in the control.", this.editControl1.ContextChoiceController.Images["Image7"]);
            controller.Items.Add("BackgroundImageLayout", "Gets or sets the background image layout as defined in the System.Windows.Forms.ImageLayout.", this.editControl1.ContextChoiceController.Images["Image9"]);
            controller.Items.Add("CancelButton", "Gets or sets the button control that is clicked when the user presses the ESC key.", this.editControl1.ContextChoiceController.Images["Image10"]);
            controller.Items.Add("CanFocus", "Gets a value indicating whether the control can receive focus.", this.editControl1.ContextChoiceController.Images["Image11"]);
            controller.Items.Add("CanSelect", "Gets a value indicating whether the control can be selected.", this.editControl1.ContextChoiceController.Images["Image10"]);
        }

        private void editControl1_ContextChoiceItemSelected(Syncfusion.Windows.Forms.Edit.Interfaces.IContextChoiceController sender, Syncfusion.Windows.Forms.Edit.ContextChoiceItemSelectedEventArgs e)
        {
            // Display the Context Choice item selected		
            Console.WriteLine("SelectedItem : " + e.SelectedItem.Text);
        }

        private void editControl1_ContextChoiceClose(Syncfusion.Windows.Forms.Edit.Interfaces.IContextChoiceController controller, System.Windows.Forms.DialogResult dialogresult)
        {
            controller.Items.Clear();
        }

        private int GetContextChoiceCharIndex(ILexemLine line)
        {
            int lastPos = -1;

            for (int i = 0; i < line.LineLexems.Count; i++)
            {
                ILexem lex = line.LineLexems[i] as ILexem;

                if (lex.Text == ".")
                    lastPos = i;
            }

            return lastPos;
        }

        private void EditControl1_UpdateContextToolTip1(object sender, Syncfusion.Windows.Forms.Edit.UpdateTooltipEventArgs e)
        {
            if (e.Text == string.Empty)
            {
                Point pointVirtual = editControl1.PointToVirtualPosition(new Point(e.X, e.Y));

                if (pointVirtual.Y > 0)
                {
                    // Get the current line  
                    ILexemLine line = editControl1.GetLine(pointVirtual.Y);

                    if (line != null)
                    {
                        // Get tokens from the current line  
                        ILexem lexem = line.FindLexemByColumn(pointVirtual.X);

                        if (lexem != null)
                        {
                            IConfigLexem configLexem = lexem.Config as IConfigLexem;
                            string formatName = configLexem.Format.Name;
                            e.Text = "This is a " + formatName + " : " + lexem.Text;
                        }
                    }
                }
            }

        }

        private void ToggleBookMark_Click(object sender, EventArgs e)
        {
            this.editControl1.BookmarkToggle();
        }

        private void RemoveAllBookMark_Click(object sender, EventArgs e)
        {
            this.editControl1.BookmarkClear();
        }

        private void NextBookMark_Click(object sender, EventArgs e)
        {
            this.editControl1.BookmarkNext();
        }
   
        private void PreviousbookMark_Click(object sender, EventArgs e)
        {
            this.editControl1.BookmarkPrevious();
        }

        private void FindFile_Click(object sender, EventArgs e)
        {
            this.editControl1.ShowReplaceDialog();
        }

        void Form1_Load(object sender, EventArgs e)
        {
            this.mainFrameBarManager1.ThemeName = "Office2019Colorful";
            this.editControl1.ThemeName = "Office2019Colorful";
            this.sfComboBox1.ThemeName = "Office2019Colorful";
            this.AddWordWrap();
            this.AddItemsUnderFile();
            this.AddItemsUnderEdit();
            this.AddItemsUnderWordWrap();
            this.AddItemsUnderWindow();
            this.Addsearch();
            this.EditControlSettings();
            this.BaritemCustomization();
            this.ComboBoxSettings();
            this.editControl1.HighlightCurrentLine = true;
            linenumber = new List<int>();
            UpdateControlAppearanceBasedOnTheme();
            this.sfComboBox1.DropDownListView.Height = 65;
            WireEvents();
        }

        private void ParentBarItem1_Click(object sender, EventArgs e)
        {
            this.editControl1.NewFile();
        }

        private void ParentBarItem2_Click(object sender, EventArgs e)
        {
            this.editControl1.LoadFile();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            BarItem mi = sender as BarItem;
            switch (mi.Text)
            {
                case "Save                     Ctrl+S":
                    this.editControl1.Save();
                    break;
                case "Save As HTML":
                    this.editControl1.SaveAsHTML("HTML");
                    System.Diagnostics.Process.Start("HTML");
                    break;
                case "Save As RTF":
                    this.editControl1.SaveAsRTF("RTF");
                    System.Diagnostics.Process.Start("RTF");
                    break;
            }
        }

        private void SaveAs_Click(object sender, EventArgs e)
        {
            this.editControl1.SaveAs();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.editControl1.Close();
        }

        private void Print_Click(object sender, EventArgs e)
        {
            this.editControl1.Print();
        }

        private void PrintPriview_Click(object sender, EventArgs e)
        {
            this.editControl1.PrintPreview();
        }

        void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Undo_Click(object sender, EventArgs e)
        {
            this.editControl1.Undo();
        }

        private void Redo_Click(object sender, EventArgs e)
        {
            this.barItem22.Enabled = true;
            this.editControl1.Redo();
        }

        private void Cut_Click(object sender, EventArgs e)
        {
            this.editControl1.Cut();
        }

        private void Copy_Click(object sender, EventArgs e)
        {
            this.editControl1.Copy();
        }

        private void PasteSpecial_Click(object sender, EventArgs e)
        {
            this.editControl1.Paste();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            this.editControl1.DeleteWord();
        }

        private void WordWrap_Click(object sender, EventArgs e)
        {
            if (this.editControl1.WordWrap == true)
            {
                this.editControl1.WordWrap = false;
            }
            else
            {
                this.editControl1.WordWrap = true;

            }
        }

        private void IncreaseLineIndent_Click(object sender, EventArgs e)
        {
            this.editControl1.IndentSelection();
        }

        private void DecreaseLineIndent_Click(object sender, EventArgs e)
        {
            this.editControl1.OutdentSelection();
        }

        private void Tabify_Click(object sender, EventArgs e)
        {
            this.editControl1.TabifySelection();
        }

        private void Untabify_Click(object sender, EventArgs e)
        {
            this.editControl1.UntabifySelection();
        }

        private void Tooglebookmark_Click(object sender, EventArgs e)
        {
            this.editControl1.BookmarkToggle();

        }

        private void Clearbookmark_Click(object sender, EventArgs e)
        {
            this.editControl1.BookmarkClear();

        }

        private void SelectAll_Click(object sender, EventArgs e)
        {
            this.editControl1.SelectAll();
        }

        private void Goto_Click(object sender, EventArgs e)
        {
            this.editControl1.ShowGoToDialog();
        }

        private void Replace_Click(object sender, EventArgs e)
        {
            this.editControl1.ShowReplaceDialog();
        }

        private void Find_Click(object sender, EventArgs e)
        {
            this.editControl1.ShowFindDialog();
        }

        private void Wraptype_Click(object sender, EventArgs e)
        {
            this.Character.Checked = false;
            this.Word.Checked = false;
            BarItem mi = sender as BarItem;
            mi.Checked = true;
            switch (mi.Text)
            {
                case "Character":
                    this.editControl1.WordWrapType = WordWrapType.WrapByChar;
                    break;
                case "Word":
                    this.editControl1.WordWrapType = WordWrapType.WrapByWord;
                    break;
            }
        }

        private void Wrapping_Click(object sender, EventArgs e)
        {
            this.Enable.Checked = false;
            this.Disable.Checked = false;
            BarItem mi = sender as BarItem;
            mi.Checked = true;
            switch (mi.Text)
            {
                case "Enable":
                    this.editControl1.WordWrap = true;
                    break;
                case "Disable":
                    this.editControl1.WordWrap = false;
                    break;
            }
        }

        private void RightToLeft_Click(object sender, EventArgs e)
        {
            this.editControl1.RenderRightToLeft = !this.editControl1.RenderRightToLeft;
            this.RightToLefts.Checked = !this.RightToLefts.Checked;
        }

        private void Splitter_Click(object sender, EventArgs e)
        {
            BarItem mi = sender as BarItem;

            switch (mi.Text)
            {
                case "Show Horizontal Splitters":
                    this.editControl1.ShowHorizontalSplitters = !this.editControl1.ShowHorizontalSplitters;
                    mi.Checked = !mi.Checked;
                    break;
                case "Show Vertical Splitters":
                    this.editControl1.ShowVerticalSplitters = !this.editControl1.ShowVerticalSplitters;
                    mi.Checked = !mi.Checked;
                    break;
                case "Split Vertically":
                    this.editControl1.SplitVertically();
                    mi.Checked = !mi.Checked;
                    break;
                case "Split Horizontally":
                    this.editControl1.SplitHorizontally();
                    mi.Checked = !mi.Checked;
                    break;
                case "Split Quadrantly":
                    this.editControl1.SplitFourQuadrants();
                    mi.Checked = !mi.Checked;
                    break;
                case "No Splits":
                    this.editControl1.SplitVertically();
                    this.editControl1.SplitHorizontally();
                    this.editControl1.SplitFourQuadrants();
                    this.editControl1.ShowVerticalSplitters = !this.editControl1.ShowVerticalSplitters;
                    this.editControl1.ShowHorizontalSplitters = !this.editControl1.ShowHorizontalSplitters;
                    break;

            }
        }

        private void Style_Click(object sender, EventArgs e)
        {
            this.Office2019Colorful.Checked = false;
            this.HighContrastBlack.Checked = false;
            BarItem mi = sender as BarItem;
            switch (mi.Text)
            {
                case "Office2019Colorful":
                    this.editControl1.ThemeName = "Office2019Colorful";
                    this.mainFrameBarManager1.ThemeName = "Office2019Colorful";
                    this.sfComboBox1.ThemeName = "Office2019Colorful";
                    this.label1.ForeColor = Color.Black;
                    this.textImageCmb.ThemeName = "Office2019Colorful";
                    this.customizeMenuCb.ThemeName = "Office2019Colorful";
                    this.customizeMenuCb.ThemeName = "HighContrastBlack";
                    mi.Checked = !mi.Checked;
                    break;
                case "HighContrastBlack":
                    this.editControl1.ThemeName = "HighContrastBlack";
                    this.mainFrameBarManager1.ThemeName = "HighContrastBlack";
                    this.sfComboBox1.ThemeName = "HighContrastBlack";
                    this.label1.ForeColor = Color.White;
                    this.textImageCmb.ThemeName = "HighContrastBlack";
                    this.customizeMenuCb.ThemeName = "HighContrastBlack";
                    this.barCB.ThemeName = "HighContrastBlack";
                    mi.Checked = !mi.Checked;
                    break;
            }
            UpdateControlAppearanceBasedOnTheme();
        }
        
        private void colorPickerUIAdv1_Picked(object sender, ColorPickerUIAdv.ColorPickedEventArgs args)
        {
            this.Background.PopupControlContainer.HidePopup(PopupCloseType.Done);
            this.editControl1.BackgroundColor = new Syncfusion.Drawing.BrushInfo(this.colorPickerUIAdv1.SelectedColor);
        }

        private void Form1_SizeChanged1(object sender, EventArgs e)
        {
            this.sfComboBox1.Location = new System.Drawing.Point(ClientSize.Width - (sfComboBox1.Width + 10), 6);
        }

        private void SfComboBox1_SelectedIndexChanged1(object sender, EventArgs e)
        {
            if (sfComboBox1.SelectedItem.ToString() == "CSharp")
            {
                this.editControl1.LoadFile(BasePath + "\\CSharpSource.cs");
            }
            else if (sfComboBox1.SelectedItem.ToString() == "PowerShell")
            {
                this.editControl1.LoadFile(BasePath + "\\Powershell.ps1");
                this.editControl1.ApplyConfiguration(KnownLanguages.PowerShell);
            }
            else if (sfComboBox1.SelectedItem.ToString() == "HTML")
            {
                this.editControl1.LoadFile(BasePath + "\\HTMLSource.html");
            }
            else if (sfComboBox1.SelectedItem.ToString() == "XML")
            {
                this.editControl1.LoadFile(BasePath + "\\XMLSource.xml");
            }
            else if (sfComboBox1.SelectedItem.ToString() == "PASCAL")
            {
                this.editControl1.LoadFile(BasePath + "\\PascalSource.pas");
            }
            else if (sfComboBox1.SelectedItem.ToString() == "HTML with Embeded JavaScript")
            {
                this.editControl1.LoadFile(BasePath + "\\HTML_JScript.html");
            }
            else if (sfComboBox1.SelectedItem.ToString() == "HTML with VBScript")
            {
                this.editControl1.LoadFile(BasePath + "\\HTML_VBScript.html");
            }
            else if (sfComboBox1.SelectedItem.ToString() == "Delphi")
            {
                this.editControl1.LoadFile(BasePath + "\\DelphiSource.pas");
            }
            else if (sfComboBox1.SelectedItem.ToString() == "SQL")
            {
                this.editControl1.LoadFile(BasePath + "\\SQLSource.sql");
            }
            else if (sfComboBox1.SelectedItem.ToString() == "Java")
            {
                this.editControl1.LoadFile(BasePath + "\\JavaSource.Java");
            }
            else if (sfComboBox1.SelectedItem.ToString() == "VB.Net")
            {
                this.editControl1.LoadFile(BasePath + "\\VBSource.vb");
            }
            else if (sfComboBox1.SelectedItem.ToString() == "VBScript")
            {
                this.editControl1.LoadFile(BasePath + "\\VBScriptSource.vbs");
                this.editControl1.ApplyConfiguration(KnownLanguages.VBScript);
            }
            else if (sfComboBox1.SelectedItem.ToString() == "JScript")
            {
                this.editControl1.LoadFile(BasePath + "\\JScriptSource.js");
                this.editControl1.ApplyConfiguration(KnownLanguages.JScript);
            }
        }

        private void undoList_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            int index = this.undoList.IndexFromPoint(e.X, e.Y);
            if (index != -1)
                this.undoList.SetSelected(index, true);
        }

        private void undoList_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            int index = this.undoList.IndexFromPoint(e.X, e.Y);
            if (index != -1)
            {
                ListBox.SelectedIndexCollection selectedIndices = this.undoList.SelectedIndices;
                for (int i = index; i >= 0; i--)
                {
                    if (!selectedIndices.Contains(i))
                        this.undoList.SetSelected(i, true);
                }

                for (int i = index + 1; i < this.undoList.Items.Count; i++)
                {
                    if (selectedIndices.Contains(i))
                        this.undoList.SetSelected(i, false);
                }

                index++;
                this.undoLabel.Text = "Undo " + index.ToString() + " Actions.";
            }
        }

        private void undoList_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            this.undoPopup.HidePopup(PopupCloseType.Done);
        }

        private void undoLabel_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            this.undoPopup.HidePopup(PopupCloseType.Deactivated);
        }

        private void undoPopup_CloseUp(object sender, Syncfusion.Windows.Forms.PopupClosedEventArgs args)
        {
            if (args.PopupCloseType == PopupCloseType.Done)
            {
                // Undo Actions here based on selections in the listbox.
            }
            this.undoList.SelectedIndex = -1;
        }

        private void undoPopup_BeforePopup(object sender, System.ComponentModel.CancelEventArgs e)
        {
            int count = this.undoList.Items.Count > 15 ? 15 : this.undoList.Items.Count;
            this.undoList.Height = this.undoList.ItemHeight * count;
            //this.undoPopup.Height = this.undoList.Height + 26;
            this.undoPopup.PopupHost.OverlapBorderColor = SystemColors.ControlDarkDark;
        }

#endregion

#region Function

        public void AddWordWrap()
        {
            this.Search = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.teamItem = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.formatItem = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.testItem = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.toolsItem = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.analyzeItem = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.windowItem = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();

            // 
            // viewItem
            // 
            this.viewItem = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.viewItem.BarName = "WordWrap";
            this.viewItem.CategoryIndex = 0;
            this.viewItem.ID = "WordWrap";
            this.viewItem.ShowToolTipInPopUp = false;
            this.viewItem.SizeToFit = true;
            this.viewItem.Text = "&Word Wrap";
            this.viewItem.SeparatorIndices.AddRange(new int[] {
            2,
            3,
           });

            // 
            // debugItem
            // 
            this.debugItem = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.debugItem.BarName = "Window";
            this.debugItem.CategoryIndex = 0;
            this.debugItem.ID = "Window";
            this.debugItem.ShowToolTipInPopUp = false;
            this.debugItem.SizeToFit = true;
            this.debugItem.Text = "&Window";
            // 
            // Search
            // 
            this.Search.BarName = "Search";
            this.Search.CategoryIndex = 0;
            this.Search.ID = "Search";
            this.Search.ShowToolTipInPopUp = false;
            this.Search.SizeToFit = true;
            this.Search.Text = "&Search";
            // 
            // debugItem
            // 
            this.debugItem.BarName = "Window";
            this.debugItem.CategoryIndex = 0;
            this.debugItem.ID = "Window";
            this.debugItem.ShowToolTipInPopUp = false;
            this.debugItem.SizeToFit = true;
            this.debugItem.Text = "&Window";

            this.mainFrameBarManager1.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {          
            this.viewItem,
            this.debugItem,
            this.barItem3,
            this.Search,
            this.windowItem,
           
            });

            this.bar1.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {          
            this.viewItem,             
            this.debugItem,
             this.Search,
            });
        }

        public void AddItemsUnderFile()
        {
            // 
            // parentBarItem1
            // 
            this.parentBarItem1 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.parentBarItem1.BarName = "parentBarItem1";
            this.parentBarItem1.CategoryIndex = 0;
            this.parentBarItem1.CustomTextFont = new System.Drawing.Font("Arial", 8.25F);
            this.parentBarItem1.ID = "New";
            this.parentBarItem1.ImageIndex = 96;
            this.parentBarItem1.ShowToolTipInPopUp = false;
            this.parentBarItem1.SizeToFit = true;
            this.parentBarItem1.Text = "&New";

            // 
            // parentBarItem2
            // 
            this.parentBarItem2 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.parentBarItem2.BarName = "parentBarItem2";
            this.parentBarItem2.CategoryIndex = 0;
            this.parentBarItem2.CustomTextFont = new System.Drawing.Font("Arial", 8.25F);
            this.parentBarItem2.ID = "New";
            this.parentBarItem2.ShowToolTipInPopUp = false;
            this.parentBarItem2.SizeToFit = true;
            this.parentBarItem2.Text = "&Open";

            // 
            // Save
            // 
            this.Save = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.Save.BarName = "Save";
            this.Save.CategoryIndex = 1;
            this.Save.ID = "";
            this.Save.ShowToolTipInPopUp = false;
            this.Save.SizeToFit = true;
            this.Save.Text = "Save";
            // 
            // Save
            // 
            this.SaveAsHTML = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.SaveAsHTML.BarName = "Save";
            this.SaveAsHTML.CategoryIndex = 1;
            this.SaveAsHTML.ID = "";
            this.SaveAsHTML.ShowToolTipInPopUp = false;
            this.SaveAsHTML.SizeToFit = true;
            this.SaveAsHTML.Text = "Save As HTML";

            // 
            // Save
            // 
            this.SaveAsRTF = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.SaveAsRTF.BarName = "Save";
            this.SaveAsRTF.CategoryIndex = 1;
            this.SaveAsRTF.ID = "";
            this.SaveAsRTF.ShowToolTipInPopUp = false;
            this.SaveAsRTF.SizeToFit = true;
            this.SaveAsRTF.Text = "Save As RTF";

            ///
            /// SaveAs
            ///
            this.SaveAs = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.SaveAs.BarName = "SaveAs..";
            this.SaveAs.CategoryIndex = 1;
            this.SaveAs.ID = "";
            this.SaveAs.ShowToolTipInPopUp = false;
            this.SaveAs.SizeToFit = true;
            this.SaveAs.Text = "Save as..";

            ///
            /// Print
            ///

            this.Print = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.Print.BarName = "Print";
            this.Print.CategoryIndex = 2;
            this.Print.ID = "";
            this.Print.ShowToolTipInPopUp = false;
            this.Print.SizeToFit = true;
            this.Print.Text = "Print";

            ///
            /// PrintPreview
            ///

            this.PrintPriview = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.PrintPriview.BarName = "PrintPreview";
            this.PrintPriview.CategoryIndex = 2;
            this.PrintPriview.ID = "";
            this.PrintPriview.ShowToolTipInPopUp = false;
            this.PrintPriview.SizeToFit = true;
            this.PrintPriview.Text = "Print Preview";

            ///
            /// Exit 
            ///
            this.Exit = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.Exit.BarName = "Exit";
            this.Exit.CategoryIndex = 2;
            this.Exit.ID = "";
            this.Exit.ShowToolTipInPopUp = false;
            this.Exit.SizeToFit = true;
            this.Exit.Text = "Exit";

            this.mainFrameBarManager1.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.parentBarItem1,
            this.parentBarItem2,
            this.Save,
            this.SaveAs,
            this.SaveAsHTML,
            this.SaveAsRTF,
            this.PrintPriview,
            this.Print,
            this.Exit});

            this.barItem1.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[]{
            this.parentBarItem1,
            this.parentBarItem2,
            this.Save,
            this.SaveAs,
            this.SaveAsHTML,
            this.SaveAsRTF,
            this.PrintPriview,
            this.Print,
            this.Exit});
        }

        public void AddItemsUnderEdit()
        {
            // 
            // undo
            // 
            this.undo = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.undo.BarName = "Undo";
            this.undo.CategoryIndex = 1;
            this.undo.ID = "Undo";
            this.undo.ShowToolTipInPopUp = false;
            this.undo.SizeToFit = true;
            this.undo.Text = "&Undo";
            // 
            // redo
            // 
            this.redo = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.redo.BarName = "Redo";
            this.redo.CategoryIndex = 1;
            this.redo.ID = "Redo";
            this.redo.ShowToolTipInPopUp = false;
            this.redo.SizeToFit = true;
            this.redo.Text = "&Redo";
            // 
            // Cut
            // 
            this.cut = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.cut.BarName = "addToSourceCotrol";
            this.cut.CategoryIndex = 1;
            this.cut.ID = "";
            this.cut.ShowToolTipInPopUp = false;
            this.cut.SizeToFit = true;
            this.cut.Text = "&Cut";

            ///
            /// Copy
            ///
            this.copy = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.copy.BarName = "SaveAll";
            this.copy.CategoryIndex = 1;
            this.copy.ID = "";
            this.copy.ShowToolTipInPopUp = false;
            this.copy.SizeToFit = true;
            this.copy.Text = "Copy";
            ///
            /// Paste 
            ///
            this.pasteSpecial = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.pasteSpecial.BarName = "Paste";
            this.pasteSpecial.CategoryIndex = 1;
            this.pasteSpecial.ID = "";
            this.pasteSpecial.ShowToolTipInPopUp = false;
            this.pasteSpecial.SizeToFit = true;
            this.pasteSpecial.Text = "Paste";

            ///
            /// Delete 
            ///
            this.Delete = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.Delete.BarName = "Delete";
            this.Delete.CategoryIndex = 1;
            this.Delete.ID = "";
            this.Delete.ShowToolTipInPopUp = false;
            this.Delete.SizeToFit = true;
            this.Delete.Text = "Delete";
            ///
            /// Selectall
            ///
            this.SelectAll = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.SelectAll.BarName = "Select All";
            this.SelectAll.CategoryIndex = 1;
            this.SelectAll.ID = "";
            this.SelectAll.ShowToolTipInPopUp = false;
            this.SelectAll.SizeToFit = true;
            this.SelectAll.Text = "Select All";
            ///
            /// Goto
            ///
            this.Goto = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.Goto.BarName = "Goto";
            this.Goto.CategoryIndex = 1;
            this.Goto.ID = "";
            this.Goto.ShowToolTipInPopUp = false;
            this.Goto.SizeToFit = true;
            this.Goto.Text = "Go to Line...";
            ///
            /// Find
            ///
            this.find = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.find.BarName = "Find in Files";
            this.find.CategoryIndex = 1;
            this.find.ID = "";
            this.find.ShowToolTipInPopUp = false;
            this.find.SizeToFit = true;
            this.find.Text = "Find in Files..";
            this.find.ImageIndex = 23;
            ///
            /// Replace in Files
            ///
            this.replace = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.replace.BarName = "Replace in Files";
            this.replace.CategoryIndex = 1;
            this.replace.ID = "";
            this.replace.ShowToolTipInPopUp = false;
            this.replace.SizeToFit = true;
            this.replace.Text = "Replace in Files..";
            this.replace.ImageIndex = 25;
            ///
            /// Word Wrap
            ///
            this.WordWrap = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.WordWrap.BarName = "Word Wrap";
            this.WordWrap.CategoryIndex = 1;
            this.WordWrap.ID = "";
            this.WordWrap.ShowToolTipInPopUp = false;
            this.WordWrap.SizeToFit = true;
            this.WordWrap.Text = "Word Wrap";
            this.WordWrap.MergeOrder = 10;
            //
            /// Increaseline indent
            ///
            this.IncreaseLineIndent = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.IncreaseLineIndent.BarName = "Increase line indent";
            this.IncreaseLineIndent.CategoryIndex = 1;
            this.IncreaseLineIndent.ID = "";
            this.IncreaseLineIndent.ShowToolTipInPopUp = false;
            this.IncreaseLineIndent.SizeToFit = true;
            this.IncreaseLineIndent.Text = "Increase Line Indent";
            this.IncreaseLineIndent.ImageIndex = 41;
            this.IncreaseLineIndent.MergeOrder = 10;
            //
            /// Decreaseline indent
            ///
            this.DecreaseLineIndent = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.DecreaseLineIndent.BarName = "Decrease Line Indent";
            this.DecreaseLineIndent.CategoryIndex = 1;
            this.DecreaseLineIndent.ID = "";
            this.DecreaseLineIndent.ShowToolTipInPopUp = false;
            this.DecreaseLineIndent.SizeToFit = true;
            this.DecreaseLineIndent.Text = "Decrease Line Indent";
            this.DecreaseLineIndent.ImageIndex = 42;
            this.DecreaseLineIndent.MergeOrder = 10;
            ///
            /// Advanced
            ///
            this.Advanced = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.Advanced.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.IncreaseLineIndent,
            this.DecreaseLineIndent,

            });
            this.Advanced.BarName = "Advanced";
            this.Advanced.CategoryIndex = 1;
            this.Advanced.ID = "";
            this.Advanced.ShowToolTipInPopUp = false;
            this.Advanced.SizeToFit = true;
            this.Advanced.Text = "Advanced";
            this.Advanced.MergeOrder = 10;

            ///
            /// Find and replace
            ///
            this.FindandReplace = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.FindandReplace.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
                this.find,
                this.replace,             
            });
            this.FindandReplace.BarName = "Find and Replace";
            this.FindandReplace.CategoryIndex = 1;
            this.FindandReplace.ID = "";
            this.FindandReplace.ShowToolTipInPopUp = false;
            this.FindandReplace.SizeToFit = true;
            this.FindandReplace.Text = "Find and Replace";
            this.FindandReplace.MergeOrder = 10;
            //
            /// Toggle Bookmark
            ///
            this.Tooglebookmark = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.Tooglebookmark.BarName = "Toggle Bookmark";
            this.Tooglebookmark.CategoryIndex = 1;
            this.Tooglebookmark.ID = "";
            this.Tooglebookmark.ShowToolTipInPopUp = false;
            this.Tooglebookmark.SizeToFit = true;
            this.Tooglebookmark.Text = "Toggle Bookmark";
            this.Tooglebookmark.MergeOrder = 10;

            //
            /// Next Bookmark
            ///
            this.Nextbookmark = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.Nextbookmark.BarName = "Next Bookmark";
            this.Nextbookmark.CategoryIndex = 1;
            this.Nextbookmark.ID = "";
            this.Nextbookmark.ShowToolTipInPopUp = false;
            this.Nextbookmark.SizeToFit = true;
            this.Nextbookmark.Text = "Next Bookmark in Document";
            this.Nextbookmark.ImageIndex = 30;
            this.Nextbookmark.MergeOrder = 10;
            //
            /// Previous Bookmark
            ///
            this.Previousbookmark = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.Previousbookmark.BarName = "Previous Bookmark";
            this.Previousbookmark.CategoryIndex = 1;
            this.Previousbookmark.ID = "";
            this.Previousbookmark.ShowToolTipInPopUp = false;
            this.Previousbookmark.SizeToFit = true;
            this.Previousbookmark.Text = "Previous Bookmark in Document";
            this.Nextbookmark.ImageIndex = 31;
            this.Previousbookmark.MergeOrder = 10;
            //
            /// Previous Bookmark
            ///
            this.Clearbookmark = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.Clearbookmark.BarName = "Clear Bookmark";
            this.Clearbookmark.CategoryIndex = 1;
            this.Clearbookmark.ID = "";
            this.Clearbookmark.ShowToolTipInPopUp = false;
            this.Clearbookmark.SizeToFit = true;
            this.Clearbookmark.Text = "Clear Bookmarks in Document";
            this.Clearbookmark.ImageIndex = 29;
            this.Clearbookmark.MergeOrder = 10;
            ///
            /// Bookmark
            ///
            this.Bookmark = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.Bookmark.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.Tooglebookmark,
            this.Nextbookmark,
            this.Previousbookmark,
            this.Clearbookmark
                  });
            this.Bookmark.BarName = "Bookmark";
            this.Bookmark.CategoryIndex = 1;
            this.Bookmark.ID = "";
            this.Bookmark.ShowToolTipInPopUp = false;
            this.Bookmark.SizeToFit = true;
            this.Bookmark.Text = "Bookmark";
            this.Bookmark.MergeOrder = 10;

            this.mainFrameBarManager1.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {          
            this.undo,
            this.redo,
            this.cut,
            this.copy,
            this.pasteSpecial,
            this.Delete,
            this.SelectAll,
            this.Advanced,
            this.Bookmark,
            
            });

            this.barItem2.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[]{
            this.undo,
            this.redo,
            this.cut,
            this.copy,
            this.pasteSpecial,
            this.Delete,
            this.SelectAll,
            this.Advanced,
            this.Bookmark,
            });

        }

        public void AddItemsUnderWordWrap()
        {
            this.Character = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.Character.BarName = "Character";
            this.Character.CategoryIndex = 1;
            this.Character.ID = "";
            this.Character.ShowToolTipInPopUp = false;
            this.Character.SizeToFit = true;
            this.Character.Text = "Character";

            this.Word = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.Word.BarName = "Word";
            this.Word.CategoryIndex = 1;
            this.Word.ID = "";
            this.Word.ShowToolTipInPopUp = false;
            this.Word.SizeToFit = true;
            this.Word.Text = "Word";
            // 
            // WrapType
            // 
            this.WrapType = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.WrapType.BarName = "WrapType";
            this.WrapType.CategoryIndex = 1;
            this.WrapType.ID = "WrapType";
            this.WrapType.ShowToolTipInPopUp = false;
            this.WrapType.SizeToFit = true;
            this.WrapType.Text = "WrapType";
            this.WrapType.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.Word,
            this.Character, });

            this.Enable = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.Enable.BarName = "Enable";
            this.Enable.CategoryIndex = 1;
            this.Enable.ID = "Enable";
            this.Enable.ShowToolTipInPopUp = false;
            this.Enable.SizeToFit = true;
            this.Enable.Text = "Enable";

            this.Disable = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.Disable.BarName = "Enable";
            this.Disable.CategoryIndex = 1;
            this.Disable.ID = "Disable";
            this.Disable.ShowToolTipInPopUp = false;
            this.Disable.SizeToFit = true;
            this.Disable.Text = "Disable";

            // 
            // Wrapping
            // 
            this.Wrapping = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.Wrapping.BarName = "Wrapping";
            this.Wrapping.CategoryIndex = 1;
            this.Wrapping.ID = "Wrapping";
            this.Wrapping.ShowToolTipInPopUp = false;
            this.Wrapping.SizeToFit = true;
            this.Wrapping.Text = "Wrapping                    ";
            this.Wrapping.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
             this.Enable,
             this.Disable});

            this.mainFrameBarManager1.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.Wrapping,
            this.WrapType,
            });

            this.viewItem.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[]{
            this.Wrapping,
            this.WrapType,
           }); ;


        }

        public void AddItemsUnderWindow()
        {
            // 
            // VerticalSplitter
            // 
            this.VerticalSplitter = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.VerticalSplitter.BarName = "Split Vertically";
            this.VerticalSplitter.CategoryIndex = 1;
            this.VerticalSplitter.ID = "Split into Vertical halves";
            this.VerticalSplitter.ShowToolTipInPopUp = false;
            this.VerticalSplitter.SizeToFit = true;
            this.VerticalSplitter.Text = "Split Vertically";
            // 
            // HorizontalSplitter
            // 
            this.HorizontalSplitter = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.HorizontalSplitter.BarName = "Split Horizontally";
            this.HorizontalSplitter.CategoryIndex = 1;
            this.HorizontalSplitter.ID = "";
            this.HorizontalSplitter.ShowToolTipInPopUp = false;
            this.HorizontalSplitter.SizeToFit = true;
            this.HorizontalSplitter.Text = "Split Horizontally";

            //
            // Office2019Colorful
            //
            this.Office2019Colorful = new BarItem();
            this.Office2019Colorful.BarName = "Office2019Colorful";
            this.Office2019Colorful.ID = "Office2019Colorful";
            this.Office2019Colorful.Text = "Office2019Colorful";
            this.Office2019Colorful.Checked = true;
            //
            // HighContrastBlack
            //
            this.HighContrastBlack = new BarItem();
            this.HighContrastBlack.BarName = "HighContrastBlack";
            this.HighContrastBlack.ID = "HighContrastBlack";
            this.HighContrastBlack.Text = "HighContrastBlack";
            //
            //ColorpickerUi
            //
            this.colorPickerUIAdv1 = new ColorPickerUIAdv();
            this.colorPickerUIAdv1.ColorItemSize = new System.Drawing.Size(13, 13);
            this.colorPickerUIAdv1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.colorPickerUIAdv1.Location = new System.Drawing.Point(0, 0);
            this.colorPickerUIAdv1.MinimumSize = new System.Drawing.Size(136, 195);
            this.colorPickerUIAdv1.Name = "colorPickerUIAdv1";
            this.colorPickerUIAdv1.SelectedColor = System.Drawing.Color.Empty;
            this.colorPickerUIAdv1.Size = new System.Drawing.Size(172, 201);
            this.colorPickerUIAdv1.TabIndex = 10003;
            this.colorPickerUIAdv1.Text = "colorPickerUIAdv1";
            this.colorPickerUIAdv1.UseOffice2007Style = false;
            this.colorPickerUIAdv1.VerticalItemsSpacing = 1;
            //
            //PopupContainer
            //
            this.popupControlContainer2 = new Syncfusion.Windows.Forms.PopupControlContainer();
            this.popupControlContainer2.Controls.Add(this.colorPickerUIAdv1);
            this.popupControlContainer2.Location = new System.Drawing.Point(173, 164);
            this.popupControlContainer2.Name = "popupControlContainer2";
            this.popupControlContainer2.Size = new System.Drawing.Size(172, 201);
            this.popupControlContainer2.TabIndex = 10002;
            this.popupControlContainer2.Visible = false;

            //
            //PopupContainer
            //
            this.popupControlContainer3 = new Syncfusion.Windows.Forms.PopupControlContainer();
            this.popupControlContainer3.Location = new System.Drawing.Point(173, 164);
            this.popupControlContainer3.Name = "popupControlContainer2";
            this.popupControlContainer3.Size = new System.Drawing.Size(172, 201);
            this.popupControlContainer3.TabIndex = 10002;
            this.popupControlContainer3.Visible = false;

            ///
            /// Background
            ///
            this.Background = new Syncfusion.Windows.Forms.Tools.XPMenus.DropDownBarItem();
            this.Background.BarName = "Background";
            this.Background.CategoryIndex = 1;
            this.Background.ID = "";
            this.Background.ShowToolTipInPopUp = false;
            this.Background.SizeToFit = true;
            this.Background.Text = "Background";
            this.Background.PopupControlContainer = this.popupControlContainer2;
            ///
            /// QuarantSplitter
            ///
            this.QuarantSplitter = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.QuarantSplitter.BarName = "Split Quadrantly";
            this.QuarantSplitter.CategoryIndex = 1;
            this.QuarantSplitter.ID = "";
            this.QuarantSplitter.ShowToolTipInPopUp = false;
            this.QuarantSplitter.SizeToFit = true;
            this.QuarantSplitter.Text = "Split Quadrantly";


            ///
            /// ShowVertical
            ///
            this.ShowVertical = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.ShowVertical.BarName = "Show Vertical Splitters";
            this.ShowVertical.CategoryIndex = 1;
            this.ShowVertical.ID = "";
            this.ShowVertical.ShowToolTipInPopUp = false;
            this.ShowVertical.SizeToFit = true;
            this.ShowVertical.Text = "Show Vertical Splitters";
    

            ///
            /// ShowVertical
            ///
            this.horizontalsplitter = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.horizontalsplitter.BarName = "Show Horizontal Splitters";
            this.horizontalsplitter.CategoryIndex = 1;
            this.horizontalsplitter.ID = "";
            this.horizontalsplitter.ShowToolTipInPopUp = false;
            this.horizontalsplitter.SizeToFit = true;
            this.horizontalsplitter.Text = "Show Horizontal Splitters";


            ///
            /// RightToleft
            ///
            this.RightToLefts = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.RightToLefts.BarName = "RightToLeft";
            this.RightToLefts.CategoryIndex = 1;
            this.RightToLefts.ID = "";
            this.RightToLefts.ShowToolTipInPopUp = false;
            this.RightToLefts.SizeToFit = true;
            this.RightToLefts.Text = "Right to Left";

            // 
            // Splitter
            // 
            this.Splitter = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.Splitter.BarName = "Splitter";
            this.Splitter.CategoryIndex = 1;
            this.Splitter.ID = "Splitter";
            this.Splitter.ShowToolTipInPopUp = false;
            this.Splitter.SizeToFit = true;
            this.Splitter.Text = "Splitter";
            this.Splitter.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
             this.VerticalSplitter,
             this.HorizontalSplitter,
             this.QuarantSplitter,
             this.ShowVertical,
             this.horizontalsplitter,

            });
            //
            // VisualStyle
            //
            this.EditControlStyle = new ParentBarItem();
            this.EditControlStyle.BarName = "VisualStyle";
            this.EditControlStyle.CategoryIndex = 2;
            this.EditControlStyle.ID = "VisualStyle";
            this.EditControlStyle.Text = "Style";
            this.EditControlStyle.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
                this.Office2019Colorful,
                this.HighContrastBlack,
            });

            this.mainFrameBarManager1.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.RightToLefts,
            this.Background,
            this.EditControlStyle
            });

            this.debugItem.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[]{
            this.RightToLefts,
            this.Background,
            this.EditControlStyle
            }); ;

            this.debugItem.MetroBackColor = ColorTranslator.FromHtml("#eaf0ff");
        }

        private void UpdateControlAppearanceBasedOnTheme()
        {
            LockWindowUpdate(this.Handle);

            if (this.editControl1.ThemeName == "Office2019Colorful")
            {
                this.mainFrameBarManager1.ThemeName = "Office2019Colorful";
                this.colorPickerUIAdv1.ThemeName = "Office2019Colorful";
                this.editControl1.BackgroundColor = new Syncfusion.Drawing.BrushInfo(ColorTranslator.FromHtml("#ffffff"));
                this.rightSidePanel.BackColor = ColorTranslator.FromHtml("#ffffff");
                this.editControl1.IndicatorMarginBackColor = ColorTranslator.FromHtml("#ffffff");
                this.editControl1.SelectionTextColor = ColorTranslator.FromHtml("#bfdfff");
                this.editControl1.Configurator.Open(Defaultconfig);
                this.editControl1.ApplyConfiguration("C#");
            }
            else if (this.editControl1.ThemeName == "HighContrastBlack")
            {
                this.mainFrameBarManager1.ThemeName = "HighContrastBlack";
                this.colorPickerUIAdv1.ThemeName = "HighContrastBlack";
                this.editControl1.Configurator.Open(blackThemeConfig); 
                this.editControl1.BackgroundColor = new Syncfusion.Drawing.BrushInfo(ColorTranslator.FromHtml("#0a0a0a"));
                this.rightSidePanel.BackColor = ColorTranslator.FromHtml("#0a0a0a");
                this.editControl1.IndicatorMarginBackColor = (ColorTranslator.FromHtml("#363636"));
                this.editControl1.SelectionTextColor = ColorTranslator.FromHtml("#0173c7");
                this.editControl1.ApplyConfiguration("C#");
            }
            
            LockWindowUpdate(IntPtr.Zero);
        }

        public void Addsearch()
        {
            this.Search.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[]{
            this.FindandReplace,
            this.Goto,
            });
        }

        public void EditControlSettings()
        {
            this.editControl1.ShowIndicatorMargin = true;
            this.editControl1.CurrentLineHighlightColor = ColorTranslator.FromHtml("#c6c6c6");
            this.editControl1.LineNumbersColor = ColorTranslator.FromHtml("#3399ff");
            this.editControl1.ShowContextTooltip = true;
            this.editControl1.ShowLineNumbers = true;
            this.editControl1.ShowContentDividers = true;
            this.editControl1.ShowOutliningCollapsers = true;
            this.editControl1.ShowHorizontalScroller = true;
            this.editControl1.ScrollVisualStyle = ScrollBarCustomDrawStyles.Metro;
            this.editControl1.Configurator.Open(Defaultconfig);
            this.editControl1.ApplyConfiguration("C#");
#if NETCORE
            this.editControl1.LoadFile(Path.GetDirectoryName(Application.ExecutablePath) + @"\..\..\..\Content.cs");
#else
            this.editControl1.LoadFile(Path.GetDirectoryName(Application.ExecutablePath) + @"\..\..\Content.cs");
#endif
            this.editControl1.AutoCompleteSingleLexem = true;
            this.editControl1.SaveOnClose = false;
            this.ShowIcon = true;
            this.Size = new System.Drawing.Size(975, 442);
            this.editControl1.ShowIndicatorMargin = true;
        }

        public void BaritemCustomization()
        {
            this.bar1.BarStyle = ((Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle)(((((Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.AllowQuickCustomizing | Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.IsMainMenu)
                       | Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.RotateWhenVertical)
                       | Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.Visible)
                       | Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.UseWholeRow)));
            this.barItem1.SeparatorIndices.AddRange(new int[] {
            2,
            6,
            8});
            this.Advanced.SeparatorIndices.AddRange(new int[] {
            2,
            4
           });
            this.barItem2.SeparatorIndices.AddRange(new int[] {
            2,
            4,
            7,
            9});
        }

        public void ComboBoxSettings()
        {
            List<ComboBoxSource> textImageRelationSource = new List<ComboBoxSource>();
            textImageRelationSource.Add(new ComboBoxSource("Default"));
            textImageRelationSource.Add(new ComboBoxSource("TextOnly"));
            textImageRelationSource.Add(new ComboBoxSource("ImageAndText"));
            this.textImageCmb.DataSource = textImageRelationSource;
            this.textImageCmb.DisplayMember = "Text";
            this.textImageCmb.ValueMember = "Text";
        }

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

        private void WireEvents()
        {
            this.undoPopup.CloseUp += new Syncfusion.Windows.Forms.PopupClosedEventHandler(this.undoPopup_CloseUp);
            this.undoPopup.BeforePopup += new System.ComponentModel.CancelEventHandler(this.undoPopup_BeforePopup);
            this.undoLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.undoLabel_MouseDown);

            this.undoList.MouseDown += new System.Windows.Forms.MouseEventHandler(this.undoList_MouseDown);
            this.undoList.MouseMove += new System.Windows.Forms.MouseEventHandler(this.undoList_MouseMove);
            this.undoList.MouseUp += new System.Windows.Forms.MouseEventHandler(this.undoList_MouseUp);

            this.parentBarItem1.Click += ParentBarItem1_Click;
            this.parentBarItem2.Click += ParentBarItem2_Click;
            this.Save.Click += Save_Click;
            this.SaveAsHTML.Click += Save_Click;
            this.SaveAsRTF.Click += Save_Click;
            this.SaveAs.Click += SaveAs_Click;
            this.Print.Click += Print_Click;
            this.PrintPriview.Click += PrintPriview_Click;
            this.Exit.Click += new EventHandler(Exit_Click);
            this.undo.Click += Undo_Click;
            this.redo.Click += Redo_Click;
            this.cut.Click += Cut_Click;
            this.copy.Click += Copy_Click;
            this.pasteSpecial.Click += PasteSpecial_Click;

            this.Delete.Click += Delete_Click;
            this.SelectAll.Click += SelectAll_Click;
            this.Goto.Click += Goto_Click;
            this.find.Click += Find_Click;
            this.replace.Click += Replace_Click;
            this.WordWrap.Click += WordWrap_Click;
            this.IncreaseLineIndent.Click += IncreaseLineIndent_Click;
            this.DecreaseLineIndent.Click += DecreaseLineIndent_Click;
            this.Character.Click += Wraptype_Click;

            this.Word.Click += Wraptype_Click;
            this.Enable.Click += Wrapping_Click;
            this.Disable.Click += Wrapping_Click;

            this.ShowVertical.Click += Splitter_Click;
            this.QuarantSplitter.Click += Splitter_Click;
            this.horizontalsplitter.Click += Splitter_Click;
            this.RightToLefts.Click += RightToLeft_Click;

            this.HorizontalSplitter.Click += Splitter_Click;
            this.VerticalSplitter.Click += Splitter_Click;
            this.Office2019Colorful.Click += Style_Click;
            this.HighContrastBlack.Click += Style_Click;
            this.colorPickerUIAdv1.Picked += new Syncfusion.Windows.Forms.Tools.ColorPickerUIAdv.ColorPickedEventHandler(this.colorPickerUIAdv1_Picked);

            this.barItem17.Click += ParentBarItem2_Click;
            this.barItem18.Click += Save_Click;
            this.barItem19.Click += SaveAs_Click;
            this.dropDownBarItem.Click += Undo_Click;
            this.barItem21.Click += Redo_Click;
            this.barItem22.Click += Cut_Click;
            this.barItem23.Click += Copy_Click;
            this.barItem24.Click += PasteSpecial_Click;
            this.sfComboBox1.SelectedIndexChanged += SfComboBox1_SelectedIndexChanged1;


            this.Tooglebookmark.Click += Tooglebookmark_Click;
            this.Nextbookmark.Click += NextBookMark_Click;
            this.Previousbookmark.Click += PreviousbookMark_Click;
            this.Clearbookmark.Click += Clearbookmark_Click;

            this.editControl1.UpdateContextToolTip += EditControl1_UpdateContextToolTip1;
            this.editControl1.ContextChoiceBeforeOpen += new System.ComponentModel.CancelEventHandler(this.editControl1_ContextChoiceBeforeOpen);
            this.editControl1.ContextChoiceOpen += new Syncfusion.Windows.Forms.Edit.ContextChoiceEventHandler(this.editControl1_ContextChoiceOpen);
            this.editControl1.ContextChoiceClose += new Syncfusion.Windows.Forms.Edit.ContextChoiceCloseEventHandler(this.editControl1_ContextChoiceClose);
            this.editControl1.ContextPromptBeforeOpen += EditControl1_ContextChoiceBeforeOpen;
            this.editControl1.ContextPromptOpen += EditControl1_ContextPromptOpen;
            this.editControl1.ContextPromptClose += EditControl1_ContextPromptClose;
            this.editControl1.ContextChoiceItemSelected += new Syncfusion.Windows.Forms.Edit.ContextChoiceItemSelectedEventHandler(this.editControl1_ContextChoiceItemSelected);
            this.editControl1.ContextPromptSelectionChanged += new Syncfusion.Windows.Forms.Edit.ContextPromptSelectionChangedEventHandler(this.editControl1_ContextPromptSelectionChanged);
            this.customizeMenuCb.CheckStateChanged += new EventHandler(customizeMenuCb_CheckStateChanged);
            this.barCB.CheckStateChanged += new EventHandler(barCB_CheckStateChanged);
            this.textImageCmb.SelectedIndexChanged += new EventHandler(textImageCmb_SelectedIndexChanged);
        }

        void textImageCmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.textImageCmb.Text != null)
            {
                switch (this.textImageCmb.Text)
                {
                    case "Default":
                        foreach (BarItem item in this.bar2.Items)
                        {
                            item.PaintStyle = PaintStyle.Default;
                        }
                        break;
                    case "TextOnly":
                        foreach (BarItem item in this.bar2.Items)
                        {
                            item.PaintStyle = PaintStyle.TextOnly;
                        }
                        break;
                    case "ImageAndText":
                        foreach (BarItem item in this.bar2.Items)
                        {
                            item.PaintStyle = PaintStyle.ImageAndText;
                        }
                        break;
                    default:
                        break;
                }
            }
        }

        void barCB_CheckStateChanged(object sender, EventArgs e)
        {
            this.mainFrameBarManager1.BarVisible = this.barCB.Checked;
        }

        void customizeMenuCb_CheckStateChanged(object sender, EventArgs e)
        {
            this.mainFrameBarManager1.EnableCustomizing = this.customizeMenuCb.Checked;
        }

        private void UnWireEvents()
        {
            this.SizeChanged -= Form1_SizeChanged1;
            this.undoPopup.CloseUp -= new Syncfusion.Windows.Forms.PopupClosedEventHandler(this.undoPopup_CloseUp);
            this.undoPopup.BeforePopup -= new System.ComponentModel.CancelEventHandler(this.undoPopup_BeforePopup);
            this.undoLabel.MouseDown -= new System.Windows.Forms.MouseEventHandler(this.undoLabel_MouseDown);
            this.undoList.MouseDown -= new System.Windows.Forms.MouseEventHandler(this.undoList_MouseDown);
            this.undoList.MouseMove -= new System.Windows.Forms.MouseEventHandler(this.undoList_MouseMove);
            this.undoList.MouseUp -= new System.Windows.Forms.MouseEventHandler(this.undoList_MouseUp);
            this.parentBarItem1.Click -= ParentBarItem1_Click;
            this.parentBarItem2.Click -= ParentBarItem2_Click;
            this.Save.Click -= Save_Click;
            this.SaveAsHTML.Click -= Save_Click;
            this.SaveAsRTF.Click -= Save_Click;
            this.SaveAs.Click -= SaveAs_Click;
            this.Print.Click -= Print_Click;
            this.PrintPriview.Click -= PrintPriview_Click;
            this.Exit.Click -= new EventHandler(Exit_Click);
            this.undo.Click -= Undo_Click;
            this.redo.Click -= Redo_Click;
            this.cut.Click -= Cut_Click;
            this.copy.Click -= Copy_Click;
            this.pasteSpecial.Click -= PasteSpecial_Click;
            this.Delete.Click -= Delete_Click;
            this.SelectAll.Click -= SelectAll_Click;
            this.Goto.Click -= Goto_Click;
            this.find.Click -= Find_Click;
            this.replace.Click -= Replace_Click;
            this.WordWrap.Click -= WordWrap_Click;
            this.IncreaseLineIndent.Click -= IncreaseLineIndent_Click;
            this.DecreaseLineIndent.Click -= DecreaseLineIndent_Click;
            this.Character.Click -= Wraptype_Click;
            this.Word.Click -= Wraptype_Click;
            this.Enable.Click -= Wrapping_Click;
            this.Disable.Click -= Wrapping_Click;
            this.ShowVertical.Click -= Splitter_Click;
            this.QuarantSplitter.Click -= Splitter_Click;
            this.horizontalsplitter.Click -= Splitter_Click;
            this.RightToLefts.Click -= RightToLeft_Click;
            this.HorizontalSplitter.Click -= Splitter_Click;
            this.VerticalSplitter.Click -= Splitter_Click;
            this.Office2019Colorful.Click -= Style_Click;
            this.HighContrastBlack.Click -= Style_Click;
            this.colorPickerUIAdv1.Picked -= new Syncfusion.Windows.Forms.Tools.ColorPickerUIAdv.ColorPickedEventHandler(this.colorPickerUIAdv1_Picked);
            this.barItem17.Click -= ParentBarItem2_Click;
            this.barItem18.Click -= Save_Click;
            this.barItem19.Click -= SaveAs_Click;
            this.dropDownBarItem.Click -= Undo_Click;
            this.barItem21.Click -= Redo_Click;
            this.barItem22.Click -= Cut_Click;
            this.barItem23.Click -= Copy_Click;
            this.barItem24.Click -= PasteSpecial_Click;
            this.sfComboBox1.SelectedIndexChanged -= SfComboBox1_SelectedIndexChanged1;
            this.Tooglebookmark.Click -= Tooglebookmark_Click;
            this.Nextbookmark.Click -= NextBookMark_Click;
            this.Previousbookmark.Click -= PreviousbookMark_Click;
            this.Clearbookmark.Click -= Clearbookmark_Click;
            this.editControl1.UpdateContextToolTip -= EditControl1_UpdateContextToolTip1;
            this.editControl1.ContextChoiceBeforeOpen -= new System.ComponentModel.CancelEventHandler(this.editControl1_ContextChoiceBeforeOpen);
            this.editControl1.ContextChoiceOpen -= new Syncfusion.Windows.Forms.Edit.ContextChoiceEventHandler(this.editControl1_ContextChoiceOpen);
            this.editControl1.ContextChoiceClose -= new Syncfusion.Windows.Forms.Edit.ContextChoiceCloseEventHandler(this.editControl1_ContextChoiceClose);
            this.editControl1.ContextPromptBeforeOpen -= EditControl1_ContextChoiceBeforeOpen;
            this.editControl1.ContextPromptOpen -= EditControl1_ContextPromptOpen;
            this.editControl1.ContextPromptClose -= EditControl1_ContextPromptClose;
            this.editControl1.ContextChoiceItemSelected -= new Syncfusion.Windows.Forms.Edit.ContextChoiceItemSelectedEventHandler(this.editControl1_ContextChoiceItemSelected);
            this.editControl1.ContextPromptSelectionChanged -= new Syncfusion.Windows.Forms.Edit.ContextPromptSelectionChangedEventHandler(this.editControl1_ContextPromptSelectionChanged);
            this.customizeMenuCb.CheckStateChanged -= new EventHandler(customizeMenuCb_CheckStateChanged);
            this.barCB.CheckStateChanged -= new EventHandler(barCB_CheckStateChanged);
            this.textImageCmb.SelectedIndexChanged -= new EventHandler(textImageCmb_SelectedIndexChanged);
        }

        protected override void OnClosed(EventArgs e)
        {
            UnWireEvents();
            base.OnClosed(e);
        }

#endregion
    }

    /// <summary>
    /// Represents a class that is used to find the licensing file for Syncfusion controls.
    /// </summary>
    public class DemoCommon
    {
        /// <summary>
        /// Finds the license key from the Common folder.
        /// </summary>
        /// <returns>Returns the license key.</returns>
        public static string FindLicenseKey()
        {
            string licenseKeyFile = "..\\Common\\SyncfusionLicense.txt";
            for (int n = 0; n < 20; n++)
            {
                if (!System.IO.File.Exists(licenseKeyFile))
                {
                    licenseKeyFile = @"..\" + licenseKeyFile;
                    continue;
                }
                return File.ReadAllText(licenseKeyFile);
            }
            return string.Empty;
        }
    }

    /// <summary>
    /// Represents the DataSource of ComboBox
    /// </summary>
    public class ComboBoxSource
    {
        public ComboBoxSource(string text)
        {
            this.Text = text;
        }

        /// <summary>
        /// Gets / sets the Text
        /// </summary>
        public string Text { get; set; }
    }
}

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

namespace GettingStartedDemo
{
    public partial class Form1 : SfForm
    {
#if NETCORE
        /// <summary>
        /// Holds the default configuration file
        /// </summary>
        private string Defaultconfig = Path.GetDirectoryName(Application.ExecutablePath) + @"..\..\..\..\config.xml";

        /// <summary>
        /// Holds the black theme configuration file
        /// </summary>
        private string blackThemeConfig = Path.GetDirectoryName(Application.ExecutablePath) + @"..\..\..\..\BlackThemeConfig.xml";
#else
         /// <summary>
        /// Holds the default configuration file
        /// </summary>
        private string Defaultconfig = Path.GetDirectoryName(Application.ExecutablePath) + @"\..\..\config.xml";

        /// <summary>
        /// Holds the black theme configuration file
        /// </summary>
        private string blackThemeConfig = Path.GetDirectoryName(Application.ExecutablePath) + @"\..\..\BlackThemeConfig.xml";
#endif
        private bool isUpdateSelectionHighlight = false;

        public Form1() 
        {
            InitializeComponent();
            try
            {
                this.Icon = new System.Drawing.Icon(GetIconFile(@"..\\..\\\logo.ico"));
            }
            catch { }
            this.Load += new EventHandler(Form1_Load);
            this.AddWordWrap();
            this.AddItemsUnderFile();
            this.AddItemsUnderEdit();
            this.AddItemsUnderView();
            this.AddItemsUnderWordWrap();
            this.AddItemsUnderWindow();
            this.Addsearch();
            this.AddOutlining();
            this.ColorCustomization();
            this.BaritemCustomization();
            this.editControl1.SelectionChanged += EditControl1_SelectionChanged;
        }

        private void EditControl1_SelectionChanged(object sender, EventArgs e)
        {
           if(!isUpdateSelectionHighlight)
            {
                if(string.IsNullOrEmpty(this.editControl1.SelectedText))
                {
                    this.editControl1.HighlightCurrentLine = true;
                    this.Hightlight.Checked = true;
                }
                else
                {
                    this.editControl1.HighlightCurrentLine = false;
                    this.Hightlight.Checked = false;
                }
            }
        }

        #region  Color Customization

        /// <summary>
        ///Method holds Color customization for custom controls 
        /// </summary>
        public void ColorCustomization()
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
            this.editControl1.LoadFile(Path.GetDirectoryName(Application.ExecutablePath) + @"..\..\..\..\Form1.cs");
#else
            this.editControl1.LoadFile(Path.GetDirectoryName(Application.ExecutablePath) + @"\..\..\Form1.cs");
#endif
            this.editControl1.UpdateContextToolTip += EditControl1_UpdateContextToolTip1;
            this.editControl1.ContextChoiceBeforeOpen += new System.ComponentModel.CancelEventHandler(this.editControl1_ContextChoiceBeforeOpen);
            this.editControl1.ContextChoiceOpen += new Syncfusion.Windows.Forms.Edit.ContextChoiceEventHandler(this.editControl1_ContextChoiceOpen);
            this.editControl1.ContextChoiceClose += new Syncfusion.Windows.Forms.Edit.ContextChoiceCloseEventHandler(this.editControl1_ContextChoiceClose);
            this.editControl1.ContextPromptBeforeOpen += EditControl1_ContextChoiceBeforeOpen;
            this.editControl1.ContextPromptOpen += EditControl1_ContextPromptOpen;
            this.editControl1.ContextPromptClose += EditControl1_ContextPromptClose;
            this.editControl1.ContextChoiceItemSelected += new Syncfusion.Windows.Forms.Edit.ContextChoiceItemSelectedEventHandler(this.editControl1_ContextChoiceItemSelected);
            this.editControl1.ContextPromptSelectionChanged += new Syncfusion.Windows.Forms.Edit.ContextPromptSelectionChangedEventHandler(this.editControl1_ContextPromptSelectionChanged);
            this.editControl1.AutoCompleteSingleLexem = true;
            this.editControl1.SaveOnClose = false;
            this.barItem1.MetroColor = ColorTranslator.FromHtml("#fdf4bf");
            this.barItem1.MetroBackColor = ColorTranslator.FromHtml("#eaf0ff");
            breakpointcolor = Color.Red;
            this.editControl1.ScrollVisualStyle = ScrollBarCustomDrawStyles.Metro;
            //this.CaptionFont = new System.Drawing.Font("Automatic", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editControl1.Style = Syncfusion.Windows.Forms.Edit.EditControlStyle.Office2016Colorful;
            this.ShowIcon = true;
            this.Size= new System.Drawing.Size(975, 742);
            this.editControl1.ShowIndicatorMargin = true;
        }
        /// <summary>
        /// Customize the Bar item  background and separator indices.
        /// </summary>
        private void BaritemCustomization()
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
            8,
            10});
           
            this.bar1.DrawBackground += bar1_DrawBackground;
        }

        /// <summary>
        /// Get the Caption icon
        /// </summary>
        /// <param name="bitmapName"></param>
        /// <returns></returns>
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
        /// <summary>
        /// Customize the menu bar background
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void bar1_DrawBackground(object sender, PaintEventArgs e)
        {
            e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(219, 223, 249)), e.ClipRectangle);
        }
        #endregion

        #region Draw BreakPoints

        /// <summary>
        /// Holds the breakpoint color
        /// </summary>
        private Color breakpointcolor;
        /// <summary>
        /// Draw breakpoints
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void draw_red_rectangle(object sender, BookmarkPaintEventArgs e)
        {
            SolidBrush brush = new SolidBrush(breakpointcolor);
            e.Graphics.FillEllipse(brush, e.ClipRectangle.X, e.ClipRectangle.Y - 2, e.ClipRectangle.Width + 1, e.ClipRectangle.Height);
        }
        #endregion

        #region intellisence
        //Store the lexem name invoking the ContextPrompt popup
        string contextPromptLexem = "";
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
        // Populate the context prompt list on popup
        private void EditControl1_ContextPromptOpen(object sender, Syncfusion.Windows.Forms.Edit.ContextPromptUpdateEventArgs e)
        {
            if (this.contextPromptLexem != "")
            {
                PopulateContextPromptItems(e);
            }

        }
        // Method that populates the context prompt list based on the lexem invoking it
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

        // Display the selected Context prompt item's index
        private void editControl1_ContextPromptSelectionChanged(Syncfusion.Windows.Forms.Edit.Forms.Popup.ContextPrompt sender, Syncfusion.Windows.Forms.Edit.ContextPromptSelectionChangedEventArgs e)
        {
            Console.WriteLine("SelectedIndex : " + e.SelectedIndex.ToString());
            Console.WriteLine("ContextPromptSelectionChanged");
        }
        // Clear the context prompt lexem name on close
        private void EditControl1_ContextPromptClose(object sender, Syncfusion.Windows.Forms.Edit.ContextPromptCloseEventArgs e)
        {
            this.contextPromptLexem = "";
        }
        // Returns the last index of the context prompt character - '(' in the current line
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

        // Ensure that the context choice popup is displayed if the invoking lexems are "this" or "me" only
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

        // Populate the context choice list on popup
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
        // Clear the Context Choice items list on closing the Context Choice popup
        private void editControl1_ContextChoiceClose(Syncfusion.Windows.Forms.Edit.Interfaces.IContextChoiceController controller, System.Windows.Forms.DialogResult dialogresult)
        {
            controller.Items.Clear();
        }
        // Returns the last index of the context choice character - '.' in the current line
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

        /// <summary>
        /// To Vew tooltip of Content of Edit Control
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        #endregion

        #region Bookmark Click event
        /// <summary>
        /// To toggle bookmark
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ToggleBookMark_Click(object sender, EventArgs e)
        {
            this.editControl1.BookmarkToggle();
        }

        /// <summary>
        /// To remove the added bookmark
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RemoveAllBookMark_Click(object sender, EventArgs e)
        {
            this.editControl1.BookmarkClear();
        }

        /// <summary>
        /// To move the next bookmark
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NextBookMark_Click(object sender, EventArgs e)
        {
            this.editControl1.BookmarkNext();
        }
        /// <summary>
        /// To move to previous bookmark
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void PreviousbookMark_Click(object sender, EventArgs e)
        {
            this.editControl1.BookmarkPrevious();
        }

        private void FindFile_Click(object sender, EventArgs e)
        {
            this.editControl1.ShowReplaceDialog();
        }

        #endregion

        #region WordWrap items
        public void AddWordWrap()
        {
            this.Outlining = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
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
            this.debugItem= new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.debugItem.BarName = "Window";
            this.debugItem.CategoryIndex = 0;
            this.debugItem.ID = "Window";
            this.debugItem.ShowToolTipInPopUp = false;
            this.debugItem.SizeToFit = true;
            this.debugItem.Text = "&Window";
            // 
            // Outlining
            // 
            this.Outlining.BarName = "Outlining";
            this.Outlining.CategoryIndex = 0;
            this.Outlining.ID = "Outlining";
            this.Outlining.ShowToolTipInPopUp = false;
            this.Outlining.SizeToFit = true;
            this.Outlining.Text = "&Outlining";
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
            this.Outlining,
            this.windowItem,
           
            });

            this.bar1.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {          
            this.viewItem,             
            this.debugItem,
             this.Search,
             this.Outlining,
            });
        }
        #endregion

        /// <summary>
        /// Raise Event on form load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void Form1_Load(object sender, EventArgs e)
        {
            this.mainFrameBarManager1.Style = VisualStyle.Office2016Colorful;
            this.editControl1.HighlightCurrentLine = true;
            linenumber = new List<int>();
            this.editControl1.Dock = DockStyle.Fill;
            UpdateEditControlStyleForOffice2016();
            UpdateArrowColor();
            this.Size = new Size(1000, 700);
        }

      #region Items under FilebarItem

        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem parentBarItem1;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem parentBarItem2;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem Save;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem SaveAs;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem SaveAsHTML;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem SaveAsRTF;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem Print;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem PrintPriview;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem Exit;
        
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
            this.parentBarItem1.Click += ParentBarItem1_Click;

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
            this.parentBarItem2.Text = "&Open                      Ctrl+O";
            this.parentBarItem2.Click += ParentBarItem2_Click;

            // 
            // Save
            // 
            this.Save = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.Save.BarName = "Save";
            this.Save.CategoryIndex = 1;
            this.Save.ID = "";
            this.Save.ShowToolTipInPopUp = false;
            this.Save.SizeToFit = true;
            this.Save.Text = "Save                     Ctrl+S";
            this.Save.Click += Save_Click;
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
            this.SaveAsHTML.Click += Save_Click;

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
           this.SaveAsRTF.Click += Save_Click;

            ///
            /// SaveAs
            ///
            this.SaveAs = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.SaveAs.BarName = "SaveAs..";
            this.SaveAs.CategoryIndex = 1;
            this.SaveAs.ID = "";
            this.SaveAs.ShowToolTipInPopUp = false;
            this.SaveAs.SizeToFit = true;
            this.SaveAs.Text = "Save as...             Ctrl+Shift+S";
            this.SaveAs.Click += SaveAs_Click;

            ///
            /// Print
            ///

            this.Print = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.Print.BarName = "Print";
            this.Print.CategoryIndex = 2;
            this.Print.ID = "";
            this.Print.ShowToolTipInPopUp = false;
            this.Print.SizeToFit = true;
            this.Print.Text = "Print                      Ctrl+P";
            this.Print.Click += Print_Click;

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
            this.PrintPriview.Click += PrintPriview_Click;

            ///
            /// Exit 
            ///
            this.Exit = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.Exit.BarName = "Exit";
            this.Exit.CategoryIndex = 2;
            this.Exit.ID = "";
            this.Exit.ShowToolTipInPopUp = false;
            this.Exit.SizeToFit = true;
            this.Exit.Text = "Exit                       (Alt+F4)";
            this.Exit.Click += new EventHandler(Exit_Click);

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

            this.barItem1.MetroBackColor = ColorTranslator.FromHtml("#eaf0ff");

        }

        #region File Events
        /// <summary>
        /// To Open new file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ParentBarItem1_Click(object sender, EventArgs e)
        {
            this.editControl1.NewFile();
        }

        /// <summary>
        /// To open existing file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ParentBarItem2_Click(object sender, EventArgs e)
        {
            this.editControl1.LoadFile();
        }

        /// <summary>
        /// To save file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// To save a file as
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveAs_Click(object sender, EventArgs e)
        {
            this.editControl1.SaveAs();
        }

        /// <summary>
        /// To close current file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Close_Click(object sender, EventArgs e)
        {
            this.editControl1.Close();
        }

        /// <summary>
        /// To print the Document
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Print_Click(object sender, EventArgs e)
        {
            this.editControl1.Print();
        }

        /// <summary>
        /// To show the print preview dialgue
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PrintPriview_Click(object sender, EventArgs e)
        {
            this.editControl1.PrintPreview();
        }

        /// <summary>
        /// To Exit from the application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        #endregion

      #region Items under EditbarItem

        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem undo;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem redo;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem cut;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem copy;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem pasteSpecial;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem Delete;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem SelectAll;
        private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem FindandReplace;
        private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem Selectiontype;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem Default;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem Block;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem find;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem replace;       
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem Goto;
        private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem Breakpoints;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem AddBreakpoints;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem RemoveBreakpoints;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem ClearBreakpoints;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem Hightlight;
        private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem Advanced;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem  WordWrap;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem IncreaseLineIndent;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem DecreaseLineIndent;
        private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem Bookmark;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem Tooglebookmark;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem Nextbookmark;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem Previousbookmark;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem Clearbookmark;

        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem showBarItem;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem hideBarItem;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem windowsBarItem;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem controlBarItem;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem unixBarItem;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem macBarItem;
        private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem endOfLineItem;
        private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem visibilityItem;
        private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem modeBarItem;
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
            this.undo.Click += Undo_Click;
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
            this.redo.Click += Redo_Click;
            // 
            // Cut
            // 
            this.cut = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.cut.BarName = "addToSourceCotrol";
            this.cut.CategoryIndex = 1;
            this.cut.ID = "";
            this.cut.ShowToolTipInPopUp = false;
            this.cut.SizeToFit = true;
            this.cut.Text = "Cut";
            this.cut.Click += Cut_Click;

            ///
            /// Copy
            ///
            this.copy = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.copy.BarName = "SaveAll";
            this.copy.CategoryIndex = 1;
            this.copy.ID = "";
            this.copy.ShowToolTipInPopUp = false;
            this.copy.SizeToFit = true;           
            this.copy.Text = "Copy                   (Ctrl+Shift+S)";
            this.copy.Click += Copy_Click;
            ///
            /// Paste 
            ///
            this.pasteSpecial = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.pasteSpecial.BarName = "Paste";
            this.pasteSpecial.CategoryIndex = 1;
            this.pasteSpecial.ID = "";
            this.pasteSpecial.ShowToolTipInPopUp = false;
            this.pasteSpecial.SizeToFit = true;           
            this.pasteSpecial.Text = "Paste                  (Ctrl+P)";
            this.pasteSpecial.Click += PasteSpecial_Click;

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
            this.Delete.Click += Delete_Click;
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
            this.SelectAll.Click += SelectAll_Click;
            
            ///
            /// Goto
            ///
            this.Goto = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.Goto.BarName = "Goto";
            this.Goto.CategoryIndex = 1;
            this.Goto.ID = "";
            this.Goto.ShowToolTipInPopUp = false;
            this.Goto.SizeToFit = true;
            this.Goto.Text = "Go to Line...                Ctrl+G";
            this.Goto.Click += Goto_Click;
            ///
            /// Find
            ///
            this.find = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.find.BarName = "Find in Files";
            this.find.CategoryIndex = 1;
            this.find.ID = "";
            this.find.ShowToolTipInPopUp = false;
            this.find.SizeToFit = true;
            this.find.Text = "Find in Files...           Ctrl+F";
            this.find.ImageIndex = 23;
            this.find.Click += Find_Click; ;
            ///
            /// Replace in Files
            ///
            this.replace = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.replace.BarName = "Replace in Files";
            this.replace.CategoryIndex = 1;
            this.replace.ID = "";
            this.replace.ShowToolTipInPopUp = false;
            this.replace.SizeToFit = true;
            this.replace.Text = "Replace in Files...    Ctrl+H";
            this.replace.ImageIndex = 25;
            this.replace.Click += Replace_Click;
            ///
            /// Highlight Current Line
            ///
            this.Hightlight = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.Hightlight.BarName = "Highlight Current Line";
            this.Hightlight.CategoryIndex = 1;
            this.Hightlight.ID = "";
            this.Hightlight.ShowToolTipInPopUp = false;
            this.Hightlight.SizeToFit = true;
            this.Hightlight.Text = "Highlight Current Line";
            this.Hightlight.Click += Hightlight_Click;
            this.Hightlight.MergeOrder = 10;
            this.Hightlight.Checked = true;
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
            this.WordWrap.Click += WordWrap_Click;
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
            this.IncreaseLineIndent.Click += IncreaseLineIndent_Click;
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
            this.DecreaseLineIndent.Click += DecreaseLineIndent_Click;
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
            this.FindandReplace .BarName = "Find and Replace";
            this.FindandReplace .CategoryIndex = 1;
            this.FindandReplace .ID = "";
            this.FindandReplace .ShowToolTipInPopUp = false;
            this.FindandReplace .SizeToFit = true;
            this.FindandReplace .Text = "Find and Replace";
            this.FindandReplace.MergeOrder = 10;

            //
            /// Default
            ///
            this.Default = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
           this.Default.BarName = "Defaults";
           this.Default.CategoryIndex = 1;
           this.Default.ID = "";
           this.Default.ShowToolTipInPopUp = false;
           this.Default.SizeToFit = true;
           this.Default.Text = "Default";
           this.Default.Checked = true;
           this.Default.Click += Block_Click;
            this.Default.MergeOrder = 10;

            //
            /// Block
            ///
            this.Block = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
           this.Block.BarName = "Block";
           this.Block.CategoryIndex = 1;
           this.Block.ID = "";
           this.Block.ShowToolTipInPopUp = false;
           this.Block.SizeToFit = true;
           this.Block.Text = "Block";
            this.Block.Click += Block_Click;
            this.Block.MergeOrder = 10;

            ///Selection Type
            ///
            this.Selectiontype = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.Selectiontype.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
                this.Default,
                this.Block,
            });
           this.Selectiontype.BarName = "SelectionMode";
           this.Selectiontype.CategoryIndex = 1;
           this.Selectiontype.ID = "";
           this.Selectiontype.ShowToolTipInPopUp = false;
           this.Selectiontype.SizeToFit = true;
           this.Selectiontype.Text = "Selection Mode";
           this.Selectiontype.MergeOrder = 10;

            //
            /// AddBreakpoints
            ///
            this.AddBreakpoints = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.AddBreakpoints.BarName = "Add breakpoint at selected line";
            this.AddBreakpoints.CategoryIndex = 1;
            this.AddBreakpoints.ID = "";
            this.AddBreakpoints.ShowToolTipInPopUp = false;
            this.AddBreakpoints.SizeToFit = true;
            this.AddBreakpoints.Text = "Add Breakpoint at Selected Line";
            this.AddBreakpoints.MergeOrder = 10;
            this.AddBreakpoints.Click += Breakpoints_Click;

            //
            /// RemoveBreakpoints
            ///
            this.RemoveBreakpoints = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.RemoveBreakpoints.BarName = "Add breakpoint at selected line";
            this.RemoveBreakpoints.CategoryIndex = 1;
            this.RemoveBreakpoints.ID = "";
            this.RemoveBreakpoints.ShowToolTipInPopUp = false;
            this.RemoveBreakpoints.SizeToFit = true;
            this.RemoveBreakpoints.Text = "Remove Breakpoint at Selected Line";
            this.RemoveBreakpoints.MergeOrder = 10;
            this.RemoveBreakpoints.Click += Breakpoints_Click; ;


            //
            /// ClearBreakpoints
            ///
            this.ClearBreakpoints = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.ClearBreakpoints.BarName = "ClearBreakpoints";
            this.ClearBreakpoints.CategoryIndex = 1;
            this.ClearBreakpoints.ID = "";
            this.ClearBreakpoints.ShowToolTipInPopUp = false;
            this.ClearBreakpoints.SizeToFit = true;
            this.ClearBreakpoints.Text = "Remove all Breakpoints";
            this.ClearBreakpoints.MergeOrder = 10;
            this.ClearBreakpoints.Click += Breakpoints_Click; ;

            ///
            /// Breakpoints
            ///
            this.Breakpoints = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.Breakpoints.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
             this.AddBreakpoints,
             this.RemoveBreakpoints,
             this.ClearBreakpoints
            });
            this.Breakpoints.BarName = "Breakpoints";
            this.Breakpoints.CategoryIndex = 1;
            this.Breakpoints.ID = "";
            this.Breakpoints.ShowToolTipInPopUp = false;
            this.Breakpoints.SizeToFit = true;
            this.Breakpoints.Text = "Breakpoint";
            this.Breakpoints.MergeOrder = 10;
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
            this.Tooglebookmark.Click += Tooglebookmark_Click;
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
            this.Nextbookmark.Click += NextBookMark_Click;
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
            this.Previousbookmark.Click += PreviousbookMark_Click;
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
            this.Clearbookmark.Click += Clearbookmark_Click;
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

            // EOL Modes
            this.macBarItem = new BarItem();
            this.macBarItem.Text = "Mac (CR)";
            this.macBarItem.BarName = "macBarItem";
            this.macBarItem.Click += MacBarItem_Click;

            this.unixBarItem = new BarItem();
            this.unixBarItem.Text = "Unix (LF)";
            this.unixBarItem.BarName = "unixBarItem";
            this.unixBarItem.Click += UnixBarItem_Click;

            this.controlBarItem = new BarItem();
            this.controlBarItem.Text = "Control (LF CR)";
            this.controlBarItem.BarName = "controlBarItem";
            this.controlBarItem.Click += ControlBarItem_Click;

            this.windowsBarItem = new BarItem();
            this.windowsBarItem.Text = "Windows (CR LF)";
            this.windowsBarItem.BarName = "windowsBarItem";
            this.windowsBarItem.Checked = true;
            this.windowsBarItem.Click += WindowsBarItem_Click;

            this.endOfLineItem = new ParentBarItem();
            this.endOfLineItem.Text = "EOL Conversion";
            this.endOfLineItem.BarName = "endOfLine";
            this.endOfLineItem.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.windowsBarItem,
            this.unixBarItem,
            this.macBarItem,
            this.controlBarItem});

            this.mainFrameBarManager1.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.undo,
            this.redo,
            this.cut,
            this.copy,
            this.pasteSpecial,
            this.Delete,
            this.Selectiontype,
            this.endOfLineItem,
            this.SelectAll,
             this.Hightlight,
            this.Advanced,
            this.Bookmark,
            this.Breakpoints,
            
            });

            this.barItem2.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[]{
            this.undo,
            this.redo,
            this.cut,
            this.copy,
            this.pasteSpecial,
            this.Delete,
            this.Selectiontype,
            this.endOfLineItem,
            this.SelectAll,
             this.Hightlight,
            this.Advanced,
            this.Bookmark,
            this.Breakpoints,
            });

            this.barItem2.MetroBackColor = ColorTranslator.FromHtml("#eaf0ff");
        }

        /// <summary>
        /// Event to handle selection mode
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Block_Click(object sender, EventArgs e)
        {
            this.Default.Checked = false;
            this.Block.Checked = false;
            BarItem mi = sender as BarItem;
            mi.Checked = true;
            switch (mi.Text)
            {
                case "Default":
                    this.editControl1.SelectionMode = SelectionModes.Default;
                    break;
                case "Block":
                    this.editControl1.SelectionMode = SelectionModes.Block;
                    break;
            }
        }

        /// <summary>
        /// Holds the collections of custom bookmarks
        /// </summary>
        private List<int> linenumber;
        /// <summary>
        /// Holds the value indicationg whether breakpoint is added or not.
        /// </summary>
        private bool isbreakpointadded = false;

        /// <summary>
        /// To handle break events
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Breakpoints_Click(object sender, EventArgs e)
        {
            this.AddBreakpoints.Checked = false;
            this.RemoveBreakpoints.Checked = false;
            this.ClearBreakpoints.Checked = false;
            BarItem mi = sender as BarItem;
            mi.Checked = true;

            switch (mi.Text.ToLower())
            {
                case "add breakpoint at selected line":
                    this.editControl1.SetCustomBookmark(this.editControl1.CurrentLine, new BookmarkPaintEventHandler(draw_red_rectangle));
                    isbreakpointadded = true;
                    linenumber.Add(this.editControl1.CurrentLine);
                    break;
                case "remove breakpoint at selected line":
                    this.editControl1.RemoveCustomBookmark(this.editControl1.CurrentLine, new BookmarkPaintEventHandler(draw_red_rectangle));
                    break;
                case "remove all breakpoints":
                    foreach (var c in linenumber)
                    {
                        this.editControl1.RemoveCustomBookmark(c, new BookmarkPaintEventHandler(draw_red_rectangle));
                    }
                    this.Refresh();
                    break;
            }
        }


        #region Edit Events

        /// <summary>
        /// To perform undo operation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Undo_Click(object sender, EventArgs e)
        {
            this.editControl1.Undo();
        }

        /// <summary>
        /// To perform Redo Operation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Redo_Click(object sender, EventArgs e)
        {
            this.editControl1.Redo();
        }

        /// <summary>
        /// To perform Cut Operation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Cut_Click(object sender, EventArgs e)
        {
            this.editControl1.Cut();
        }

        /// <summary>
        /// To Perform Copy operation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Copy_Click(object sender, EventArgs e)
        {
            this.editControl1.Copy();           
        }

        /// <summary>
        /// To perform paste operation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PasteSpecial_Click(object sender, EventArgs e)
        {
            this.editControl1.Paste();
        }

        /// <summary>
        /// To perform delete operaation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Delete_Click(object sender, EventArgs e)
        {
            this.editControl1.DeleteWord();
        }

        /// <summary>
        /// To Hightlight Current line
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Hightlight_Click(object sender, EventArgs e)
        {
            isUpdateSelectionHighlight = !isUpdateSelectionHighlight;
            this.editControl1.HighlightCurrentLine = !this.editControl1.HighlightCurrentLine;
            this.Hightlight.Checked = !this.Hightlight.Checked;
        }

        /// <summary>
        /// To perform Word wrap text
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void WordWrap_Click(object sender, EventArgs e)
        {
            if(this.editControl1.WordWrap == true)
            {
                this.editControl1.WordWrap = false;
            }
            else
            {
                this.editControl1.WordWrap = true;

            }

        }

        /// <summary>
        /// to Move the Selected text
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void IncreaseLineIndent_Click(object sender, EventArgs e)
        {
            this.editControl1.IndentSelection();
        }
        /// <summary>
        /// To decrease indent space
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DecreaseLineIndent_Click(object sender, EventArgs e)
        {
            this.editControl1.OutdentSelection();
        }

        /// <summary>
		/// Changes spaces sequences to tabs.
		/// </summary>
        private void Tabify_Click(object sender, EventArgs e)
        {
            this.editControl1.TabifySelection();
        }
        /// <summary>
        /// Changes tabs sequences to spaces.
        /// </summary>
        private void Untabify_Click(object sender, EventArgs e)
        {
            this.editControl1.UntabifySelection();
        }
        /// <summary>
        /// Toggle bookmark
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Tooglebookmark_Click(object sender, EventArgs e)
        {
            this.editControl1.BookmarkToggle();
           
        }
        /// <summary>
        /// To clear bookmark
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Clearbookmark_Click(object sender, EventArgs e)
        {
            this.editControl1.BookmarkClear();
           
        }
        /// <summary>
        /// To select all the content
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectAll_Click(object sender, EventArgs e)
        {
            this.editControl1.SelectAll();
        }
        /// <summary>
        /// To show goto dialog
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Goto_Click(object sender, EventArgs e)
        {
            this.editControl1.ShowGoToDialog();
        }
        /// <summary>
        /// To open replace dialog
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Replace_Click(object sender, EventArgs e)
        {
            this.editControl1.ShowReplaceDialog();
        }

        /// <summary>
        /// To open find dialog
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Find_Click(object sender, EventArgs e)
        {
             this.editControl1.ShowFindDialog();
        }

        /// <summary>
        /// Occurs when the control item is clicked.
        /// </summary>
        /// <param name="sender">The Source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> that contains the event data.</param>
        private void ControlBarItem_Click(object sender, EventArgs e)
        {
            this.editControl1.SetNewLineStyle(Syncfusion.IO.NewLineStyle.Control);
            this.controlBarItem.Checked = true;
            this.unixBarItem.Checked = false;
            this.macBarItem.Checked = false;
            this.windowsBarItem.Checked = false;
        }

        /// <summary>
        /// Occurs when the windows item is clicked.
        /// </summary>
        /// <param name="sender">The Source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> that contains the event data.</param>
        private void WindowsBarItem_Click(object sender, EventArgs e)
        {
            this.editControl1.SetNewLineStyle(Syncfusion.IO.NewLineStyle.Windows);
            this.windowsBarItem.Checked = true;
            this.controlBarItem.Checked = false;
            this.unixBarItem.Checked = false;
            this.macBarItem.Checked = false;
        }

        /// <summary>
        /// Occurs when the unix item is clicked.
        /// </summary>
        /// <param name="sender">The Source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> that contains the event data.</param>
        private void UnixBarItem_Click(object sender, EventArgs e)
        {
            this.editControl1.SetNewLineStyle(Syncfusion.IO.NewLineStyle.Unix);
            this.unixBarItem.Checked = true;
            this.controlBarItem.Checked = false;
            this.macBarItem.Checked = false;
            this.windowsBarItem.Checked = false;
        }

        /// <summary>
        /// Occurs when the mac item is clicked.
        /// </summary>
        /// <param name="sender">The Source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> that contains the event data.</param>
        private void MacBarItem_Click(object sender, EventArgs e)
        {
            this.editControl1.SetNewLineStyle(Syncfusion.IO.NewLineStyle.Mac);
            this.macBarItem.Checked = true;
            this.unixBarItem.Checked = false;
            this.controlBarItem.Checked = false;
            this.windowsBarItem.Checked = false;
        }

        #endregion

        #endregion

      #region Items under ViewbarItem

        private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem symbolsItem;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem lineNumberItem;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem indicatorItem;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem whiteSpaceItem;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem eolItem;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem indentItem;

        /// <summary>
        /// Method used to add the items under view bar item.
        /// </summary>
        public void AddItemsUnderView()
        {
            this.whiteSpaceItem = new BarItem();
            this.whiteSpaceItem.Text = "Show White Space and Tab";
            this.whiteSpaceItem.BarName = "whiteSpaceItem";
            this.whiteSpaceItem.Click += WhiteSpaceItem_Click;

            this.eolItem = new BarItem();
            this.eolItem.Text = "Show End of Line";
            this.eolItem.BarName = "eolItem";
            this.eolItem.Click += EolItem_Click;

            this.indentItem = new BarItem();
            this.indentItem.Text = "Show Indent Guide";
            this.indentItem.BarName = "indentItem";
            this.indentItem.Click += IndentItem_Click;

            this.symbolsItem = new ParentBarItem();
            this.symbolsItem.Text = "Show Symbols";
            this.symbolsItem.BarName = "showSymbolsItem";
            this.symbolsItem.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.whiteSpaceItem,
            this.eolItem,
            this.indentItem});

            this.lineNumberItem = new BarItem();
            this.lineNumberItem.Text = "Show Line Number";
            this.lineNumberItem.BarName = "lineNumberItem";
            this.lineNumberItem.Checked = true;
            this.lineNumberItem.Click += LineNumberItem_Click;

            this.indicatorItem = new BarItem();
            this.indicatorItem.Text = "Show Indicator Margin";
            this.indicatorItem.BarName = "indicatorItem";
            this.indicatorItem.Checked = true;
            this.indicatorItem.Click += IndicatorItem_Click;

            this.mainFrameBarManager1.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.symbolsItem,
            this.lineNumberItem,
            this.indicatorItem});

            this.viewBarItem.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.symbolsItem,
            this.lineNumberItem,
            this.indicatorItem});

            this.viewBarItem.MetroBackColor = ColorTranslator.FromHtml("#eaf0ff");
        }

        /// <summary>
        /// Occurs when the indicator item is clicked.
        /// </summary>
        /// <param name="sender">The Source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> that contains the event data.</param>
        private void IndicatorItem_Click(object sender, EventArgs e)
        {
            if (!this.indicatorItem.Checked)
            {
                this.editControl1.ShowIndicatorMargin = true;
                this.indicatorItem.Checked = true;
            }
            else
            {
                this.editControl1.ShowIndicatorMargin = false;
                this.indicatorItem.Checked = false;
            }
        }

        /// <summary>
        /// Occurs when the line number item is clicked.
        /// </summary>
        /// <param name="sender">The Source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> that contains the event data.</param>
        private void LineNumberItem_Click(object sender, EventArgs e)
        {
            if (!this.lineNumberItem.Checked)
            {
                this.editControl1.ShowLineNumbers = true;
                this.lineNumberItem.Checked = true;
            }
            else
            {
                this.editControl1.ShowLineNumbers = false;
                this.lineNumberItem.Checked = false;
            }
        }

        /// <summary>
        /// Occurs when the indent item is clicked.
        /// </summary>
        /// <param name="sender">The Source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> that contains the event data.</param>
        private void IndentItem_Click(object sender, EventArgs e)
        {
            if (!this.indentItem.Checked)
            {
                this.editControl1.ShowIndentationGuidelines = true;
                this.indentItem.Checked = true;
            }
            else
            {
                this.editControl1.ShowIndentationGuidelines = false;
                this.indentItem.Checked = false;
            }
        }

        /// <summary>
        /// Occurs when the white space item is clicked.
        /// </summary>
        /// <param name="sender">The Source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> that contains the event data.</param>
        private void WhiteSpaceItem_Click(object sender, EventArgs e)
        {
            if (!this.whiteSpaceItem.Checked)
            {
                this.editControl1.ShowWhitespaces = true;
                this.whiteSpaceItem.Checked = true;
            }
            else
            {
                this.editControl1.ShowWhitespaces = false;
                this.whiteSpaceItem.Checked = false;
            }
        }

        /// <summary>
        /// Occurs when the eol item is clicked.
        /// </summary>
        /// <param name="sender">The Source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> that contains the event data.</param>
        private void EolItem_Click(object sender, EventArgs e)
        {
            if (!this.eolItem.Checked)
            {
                this.editControl1.ShowEndOfLine = true;
                this.eolItem.Checked = true;
            }
            else
            {
                this.editControl1.ShowEndOfLine = false;
                this.eolItem.Checked = false;
            }
        }

        #endregion

      #region Items under Word Wrap barItem

        private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem Wrapping;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem Disable;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem Enable;
        private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem WrapType;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem Word;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem Character;
        public void AddItemsUnderWordWrap()
        {
            this.Character = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.Character.BarName = "Character";
            this.Character.CategoryIndex = 1;
            this.Character.ID = "";
            this.Character.ShowToolTipInPopUp = false;
            this.Character.SizeToFit = true;
            this.Character.Text = "Character";
            this.Character.Click += Wraptype_Click;


            this.Word = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.Word.BarName = "Word";
            this.Word.CategoryIndex = 1;
            this.Word.ID = "";
            this.Word.ShowToolTipInPopUp = false;
            this.Word.SizeToFit = true;
            this.Word.Text = "Word";
            this.Word.Click += Wraptype_Click;

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
            this.Enable.Click += Wrapping_Click;

            this.Disable = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.Disable.BarName = "Enable";
            this.Disable.CategoryIndex = 1;
            this.Disable.ID = "Disable";
            this.Disable.ShowToolTipInPopUp = false;
            this.Disable.SizeToFit = true;
            this.Disable.Text = "Disable";
            this.Disable.Click += Wrapping_Click;

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
            

            this.viewItem.MetroBackColor = ColorTranslator.FromHtml("#eaf0ff");
        }


        /// <summary>
        /// Specifies Wrap type
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Enable/Disable Word Wrap
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        #endregion

      #region Items under Window barItem

        private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem Splitter;
        private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem EditControlStyle;
        private Syncfusion.Windows.Forms.Tools.XPMenus.DropDownBarItem Background;
        private Syncfusion.Windows.Forms.Tools.XPMenus.DropDownBarItem BreakPointColor;

        private Syncfusion.Windows.Forms.PopupControlContainer popupControlContainer2;
        private Syncfusion.Windows.Forms.PopupControlContainer popupControlContainer3;

        private ColorPickerUIAdv colorPickerUIAdv1;
        private ColorPickerUIAdv colorPickerUIAdv2;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem VerticalSplitter;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem HorizontalSplitter;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem QuarantSplitter;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem ShowVertical;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem horizontalsplitter;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem Office2016Colorful;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem Office2016White;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem Office2016DarkGray;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem Office2016Black;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem RightToLefts;
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
            this.VerticalSplitter.Click += Splitter_Click;
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
            this.HorizontalSplitter.Click += Splitter_Click;
            //
            // Office2016Colorful
            //
            this.Office2016Colorful = new BarItem();
            this.Office2016Colorful.BarName = "Office2016Colorful";
            this.Office2016Colorful.ID = "Office2016Colorful";
            this.Office2016Colorful.Text = "Office2016Colorful";
            this.Office2016Colorful.Checked = true;
            this.Office2016Colorful.Click += Style_Click;
            //
            // Office2016White
            //
            this.Office2016White = new BarItem();
            this.Office2016White.BarName = "Office2016White";
            this.Office2016White.ID = "Office2016White";
            this.Office2016White.Text = "Office2016White";
            this.Office2016White.Click += Style_Click;
            //
            // Office2016DarkGray
            //
            this.Office2016DarkGray = new BarItem();
            this.Office2016DarkGray.BarName = "Office2016DarkGray";
            this.Office2016DarkGray.ID = "Office2016DarkGray";
            this.Office2016DarkGray.Text = "Office2016DarkGray";
            this.Office2016DarkGray.Click += Style_Click;
            //
            // Office2016Black
            //
            this.Office2016Black = new BarItem();
            this.Office2016Black.BarName = "Office2016Black";
            this.Office2016Black.ID = "Office2016Black";
            this.Office2016Black.Text = "Office2016Black";
            this.Office2016Black.Click += Style_Click;
            //
            //ColorpickerUi
            //
            this.colorPickerUIAdv1 = new ColorPickerUIAdv();
            this.colorPickerUIAdv1.ColorItemSize = new System.Drawing.Size(13, 13);
            this.colorPickerUIAdv1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.colorPickerUIAdv1.Location = new System.Drawing.Point(0, 0);
            this.colorPickerUIAdv1.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(110)))), ((int)(((byte)(218)))));
            this.colorPickerUIAdv1.MinimumSize = new System.Drawing.Size(136, 195);
            this.colorPickerUIAdv1.Name = "colorPickerUIAdv1";
            this.colorPickerUIAdv1.SelectedColor = System.Drawing.Color.Empty;
            this.colorPickerUIAdv1.Size = new System.Drawing.Size(172, 201);
            this.colorPickerUIAdv1.Style = Syncfusion.Windows.Forms.Tools.ColorPickerUIAdv.visualstyle.Metro;
            this.colorPickerUIAdv1.TabIndex = 10003;
            this.colorPickerUIAdv1.Text = "colorPickerUIAdv1";
            this.colorPickerUIAdv1.UseOffice2007Style = false;
            this.colorPickerUIAdv1.VerticalItemsSpacing = 1;
            this.colorPickerUIAdv1.Picked += new Syncfusion.Windows.Forms.Tools.ColorPickerUIAdv.ColorPickedEventHandler(this.colorPickerUIAdv1_Picked);
            //
            //ColorpickerUi
            //
            this.colorPickerUIAdv2 = new ColorPickerUIAdv();
            this.colorPickerUIAdv2.ColorItemSize = new System.Drawing.Size(13, 13);
            this.colorPickerUIAdv2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.colorPickerUIAdv2.Location = new System.Drawing.Point(0, 0);
            this.colorPickerUIAdv2.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(110)))), ((int)(((byte)(218)))));
            this.colorPickerUIAdv2.MinimumSize = new System.Drawing.Size(136, 195);
            this.colorPickerUIAdv2.Name = "colorPickerUIAdv2";
            this.colorPickerUIAdv2.SelectedColor = System.Drawing.Color.Empty;
            this.colorPickerUIAdv2.Size = new System.Drawing.Size(172, 201);
            this.colorPickerUIAdv2.Style = Syncfusion.Windows.Forms.Tools.ColorPickerUIAdv.visualstyle.Metro;
            this.colorPickerUIAdv2.TabIndex = 10003;
            this.colorPickerUIAdv2.Text = "colorPickerUIAdv2";
            this.colorPickerUIAdv2.UseOffice2007Style = false;
            this.colorPickerUIAdv2.VerticalItemsSpacing = 1;
            this.colorPickerUIAdv2.Picked += new Syncfusion.Windows.Forms.Tools.ColorPickerUIAdv.ColorPickedEventHandler(this.colorPickerUIAdv2_Picked);
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
            this.popupControlContainer3.Controls.Add(this.colorPickerUIAdv2);
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
            /// Background
            ///
            this.BreakPointColor = new Syncfusion.Windows.Forms.Tools.XPMenus.DropDownBarItem();
            this.BreakPointColor.BarName = "BreakPoint";
            this.BreakPointColor.CategoryIndex = 1;
            this.BreakPointColor.ID = "";
            this.BreakPointColor.ShowToolTipInPopUp = false;
            this.BreakPointColor.SizeToFit = true;
            this.BreakPointColor.Text = "Breakpoint Color";
            this.BreakPointColor.PopupControlContainer = this.popupControlContainer3;


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
            this.QuarantSplitter.Click += Splitter_Click;


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
            this.ShowVertical.Click += Splitter_Click;



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
            this.horizontalsplitter.Click += Splitter_Click;


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
            this.RightToLefts.Click += RightToLeft_Click;

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
                this.Office2016Colorful,
                this.Office2016White,
                this.Office2016DarkGray,
                this.Office2016Black
            });

            this.mainFrameBarManager1.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.RightToLefts,
            this.Background,
            this.BreakPointColor,
            this.EditControlStyle
            });

            this.debugItem.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[]{
            this.RightToLefts,
            this.Background,
            this.BreakPointColor,
            this.EditControlStyle
            }); ;

            this.debugItem.MetroBackColor = ColorTranslator.FromHtml("#eaf0ff");
        }


        /// <summary>
        /// To Perform RTL layout
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>      
        private void RightToLeft_Click(object sender, EventArgs e)
        {
            this.editControl1.RenderRightToLeft = !this.editControl1.RenderRightToLeft;
            this.RightToLefts.Checked = !this.RightToLefts.Checked;
        }
        /// <summary>
        /// To perform Splitter Operation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        /// <summary>
        /// To perform Style Operation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Style_Click(object sender, EventArgs e)
        {
            this.Office2016Colorful.Checked = false;
            this.Office2016Black.Checked = false;
            this.Office2016DarkGray.Checked = false;
            this.Office2016White.Checked = false;
            BarItem mi = sender as BarItem;
            switch (mi.Text)
            {
                case "Office2016Colorful":
                    this.editControl1.Style = Syncfusion.Windows.Forms.Edit.EditControlStyle.Office2016Colorful;
                    mi.Checked = !mi.Checked;
                    break;
                case "Office2016White":
                    this.editControl1.Style = Syncfusion.Windows.Forms.Edit.EditControlStyle.Office2016White;
                    mi.Checked = !mi.Checked;
                    break;
                case "Office2016DarkGray":
                    this.editControl1.Style = Syncfusion.Windows.Forms.Edit.EditControlStyle.Office2016DarkGray;
                    mi.Checked = !mi.Checked;
                    break;
                case "Office2016Black":
                    this.editControl1.Style = Syncfusion.Windows.Forms.Edit.EditControlStyle.Office2016Black;
                    mi.Checked = !mi.Checked;
                    break;
            }
            UpdateEditControlStyleForOffice2016();
            UpdateArrowColor();
        }
        /// <summary>
        /// Update editControl style
        /// </summary>
        private void UpdateEditControlStyleForOffice2016()
        {
            LockWindowUpdate(this.Handle);
            
             if (this.editControl1.Style == Syncfusion.Windows.Forms.Edit.EditControlStyle.Office2016Colorful)
            {
                this.mainFrameBarManager1.Style = VisualStyle.Office2016Colorful;
                this.BackColor = ColorTranslator.FromHtml("#0173c7");
                this.colorPickerUIAdv1.Style = ColorPickerUIAdv.visualstyle.Office2016Colorful;
                this.colorPickerUIAdv2.Style = ColorPickerUIAdv.visualstyle.Office2016Colorful;
                this.editControl1.Configurator.Open(Defaultconfig);
                this.editControl1.ApplyConfiguration("C#");
                this.editControl1.BackgroundColor = new Syncfusion.Drawing.BrushInfo(ColorTranslator.FromHtml("#ffffff"));
                this.editControl1.SelectionTextColor = ColorTranslator.FromHtml("#bfdfff");
                this.editControl1.IndicatorMarginBackColor = ColorTranslator.FromHtml("#e6e7e8");
                this.editControl1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            }
            else if (this.editControl1.Style == Syncfusion.Windows.Forms.Edit.EditControlStyle.Office2016White)
            {
                this.BackColor = ColorTranslator.FromHtml("#ffffff");
                this.mainFrameBarManager1.Style = VisualStyle.Office2016White;
                this.colorPickerUIAdv1.Style = ColorPickerUIAdv.visualstyle.Office2016White;
                this.colorPickerUIAdv2.Style = ColorPickerUIAdv.visualstyle.Office2016White;
                this.editControl1.Configurator.Open(Defaultconfig);
                this.editControl1.ApplyConfiguration("C#");
                this.editControl1.BackgroundColor = new Syncfusion.Drawing.BrushInfo(ColorTranslator.FromHtml("#ffffff"));
                this.editControl1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                this.editControl1.IndicatorMarginBackColor = ColorTranslator.FromHtml("#e6e7e8");
                this.editControl1.SelectionTextColor = ColorTranslator.FromHtml("#bfdfff");

            }
            else if (this.editControl1.Style == Syncfusion.Windows.Forms.Edit.EditControlStyle.Office2016DarkGray)
            {
                this.BackColor = ColorTranslator.FromHtml("#444444");
                this.mainFrameBarManager1.Style = VisualStyle.Office2016DarkGray;
                this.colorPickerUIAdv1.Style = ColorPickerUIAdv.visualstyle.Office2016DarkGray;
                this.colorPickerUIAdv2.Style = ColorPickerUIAdv.visualstyle.Office2016DarkGray;
                this.editControl1.Configurator.Open(blackThemeConfig);
                this.editControl1.ApplyConfiguration("C#");
                this.editControl1.BackgroundColor = new Syncfusion.Drawing.BrushInfo(ColorTranslator.FromHtml("#2d2d30"));
                this.editControl1.IndicatorMarginBackColor = (ColorTranslator.FromHtml("#363636"));
                this.editControl1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                this.editControl1.SelectionTextColor = ColorTranslator.FromHtml("#0173c7");

            }
            else if (this.editControl1.Style == Syncfusion.Windows.Forms.Edit.EditControlStyle.Office2016Black)
            {
                this.editControl1.SelectionTextColor = ColorTranslator.FromHtml("#0173c7");
                this.BackColor = ColorTranslator.FromHtml("#0a0a0a");
                this.mainFrameBarManager1.Style = VisualStyle.Office2016Black;
                this.colorPickerUIAdv1.Style = ColorPickerUIAdv.visualstyle.Office2016Black;
                this.colorPickerUIAdv2.Style = ColorPickerUIAdv.visualstyle.Office2016Black;
                this.editControl1.Configurator.Open(blackThemeConfig);
                this.editControl1.ApplyConfiguration("C#");
                this.editControl1.BackgroundColor = new Syncfusion.Drawing.BrushInfo(ColorTranslator.FromHtml("#0a0a0a"));
                this.editControl1.IndicatorMarginBackColor = (ColorTranslator.FromHtml("#363636"));
                this.editControl1.SelectionTextColor = ColorTranslator.FromHtml("#0173c7");
                this.editControl1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;

            }
            LockWindowUpdate(IntPtr.Zero);
        }

        /// <summary>
        /// Method used to update the arrow color of the dropdown items.
        /// </summary>
        private void UpdateArrowColor()
        {
            if (this.editControl1.Style == Syncfusion.Windows.Forms.Edit.EditControlStyle.Office2016Colorful)
            {
                this.endOfLineItem.CustomNormalTextColor = ColorTranslator.FromHtml("#444444");
                this.endOfLineItem.CustomActiveTextColor = ColorTranslator.FromHtml("#444444");
                this.Selectiontype.CustomNormalTextColor = ColorTranslator.FromHtml("#444444");
                this.Selectiontype.CustomActiveTextColor = ColorTranslator.FromHtml("#444444");
                this.Bookmark.CustomNormalTextColor = ColorTranslator.FromHtml("#444444");
                this.Bookmark.CustomActiveTextColor = ColorTranslator.FromHtml("#444444");
                this.Advanced.CustomNormalTextColor = ColorTranslator.FromHtml("#444444");
                this.Advanced.CustomActiveTextColor = ColorTranslator.FromHtml("#444444");
                this.Breakpoints.CustomNormalTextColor = ColorTranslator.FromHtml("#444444");
                this.Breakpoints.CustomActiveTextColor = ColorTranslator.FromHtml("#444444");
                this.symbolsItem.CustomNormalTextColor = ColorTranslator.FromHtml("#444444");
                this.symbolsItem.CustomActiveTextColor = ColorTranslator.FromHtml("#444444");
                this.Wrapping.CustomNormalTextColor = ColorTranslator.FromHtml("#444444");
                this.Wrapping.CustomActiveTextColor = ColorTranslator.FromHtml("#444444");
                this.WrapType.CustomNormalTextColor = ColorTranslator.FromHtml("#444444");
                this.WrapType.CustomActiveTextColor = ColorTranslator.FromHtml("#444444");
                this.Background.CustomNormalTextColor = ColorTranslator.FromHtml("#444444");
                this.Background.CustomActiveTextColor = ColorTranslator.FromHtml("#444444");
                this.BreakPointColor.CustomNormalTextColor = ColorTranslator.FromHtml("#444444");
                this.BreakPointColor.CustomActiveTextColor = ColorTranslator.FromHtml("#444444");
                this.EditControlStyle.CustomNormalTextColor = ColorTranslator.FromHtml("#444444");
                this.EditControlStyle.CustomActiveTextColor = ColorTranslator.FromHtml("#444444");
                this.FindandReplace.CustomNormalTextColor = ColorTranslator.FromHtml("#444444");
                this.FindandReplace.CustomActiveTextColor = ColorTranslator.FromHtml("#444444");
                this.Outline.CustomNormalTextColor = ColorTranslator.FromHtml("#444444");
                this.Outline.CustomActiveTextColor = ColorTranslator.FromHtml("#444444");
                this.editControl1.EndOfLineBackColor = Color.Black;
                this.editControl1.EndOfLineForeColor = Color.White;
            }
            else if (this.editControl1.Style == Syncfusion.Windows.Forms.Edit.EditControlStyle.Office2016White)
            {
                this.endOfLineItem.CustomNormalTextColor = ColorTranslator.FromHtml("#444444");
                this.endOfLineItem.CustomActiveTextColor = ColorTranslator.FromHtml("#444444");
                this.Selectiontype.CustomNormalTextColor = ColorTranslator.FromHtml("#444444");
                this.Selectiontype.CustomActiveTextColor = ColorTranslator.FromHtml("#444444");
                this.Bookmark.CustomNormalTextColor = ColorTranslator.FromHtml("#444444");
                this.Bookmark.CustomActiveTextColor = ColorTranslator.FromHtml("#444444");
                this.Advanced.CustomNormalTextColor = ColorTranslator.FromHtml("#444444");
                this.Advanced.CustomActiveTextColor = ColorTranslator.FromHtml("#444444");
                this.Breakpoints.CustomNormalTextColor = ColorTranslator.FromHtml("#444444");
                this.Breakpoints.CustomActiveTextColor = ColorTranslator.FromHtml("#444444");
                this.symbolsItem.CustomNormalTextColor = ColorTranslator.FromHtml("#444444");
                this.symbolsItem.CustomActiveTextColor = ColorTranslator.FromHtml("#444444");
                this.Wrapping.CustomNormalTextColor = ColorTranslator.FromHtml("#444444");
                this.Wrapping.CustomActiveTextColor = ColorTranslator.FromHtml("#444444");
                this.WrapType.CustomNormalTextColor = ColorTranslator.FromHtml("#444444");
                this.WrapType.CustomActiveTextColor = ColorTranslator.FromHtml("#444444");
                this.Background.CustomNormalTextColor = ColorTranslator.FromHtml("#444444");
                this.Background.CustomActiveTextColor = ColorTranslator.FromHtml("#444444");
                this.BreakPointColor.CustomNormalTextColor = ColorTranslator.FromHtml("#444444");
                this.BreakPointColor.CustomActiveTextColor = ColorTranslator.FromHtml("#444444");
                this.EditControlStyle.CustomNormalTextColor = ColorTranslator.FromHtml("#444444");
                this.EditControlStyle.CustomActiveTextColor = ColorTranslator.FromHtml("#444444");
                this.FindandReplace.CustomNormalTextColor = ColorTranslator.FromHtml("#444444");
                this.FindandReplace.CustomActiveTextColor = ColorTranslator.FromHtml("#444444");
                this.Outline.CustomNormalTextColor = ColorTranslator.FromHtml("#444444");
                this.Outline.CustomActiveTextColor = ColorTranslator.FromHtml("#444444");
                this.editControl1.EndOfLineBackColor = Color.Black;
                this.editControl1.EndOfLineForeColor = Color.White;
            }
            else if (this.editControl1.Style == Syncfusion.Windows.Forms.Edit.EditControlStyle.Office2016DarkGray)
            {
                this.endOfLineItem.CustomNormalTextColor = ColorTranslator.FromHtml("#444444");
                this.endOfLineItem.CustomActiveTextColor = ColorTranslator.FromHtml("#444444");
                this.Selectiontype.CustomNormalTextColor = ColorTranslator.FromHtml("#444444");
                this.Selectiontype.CustomActiveTextColor = ColorTranslator.FromHtml("#444444");
                this.Bookmark.CustomNormalTextColor = ColorTranslator.FromHtml("#444444");
                this.Bookmark.CustomActiveTextColor = ColorTranslator.FromHtml("#444444");
                this.Advanced.CustomNormalTextColor = ColorTranslator.FromHtml("#444444");
                this.Advanced.CustomActiveTextColor = ColorTranslator.FromHtml("#444444");
                this.Breakpoints.CustomNormalTextColor = ColorTranslator.FromHtml("#444444");
                this.Breakpoints.CustomActiveTextColor = ColorTranslator.FromHtml("#444444");
                this.symbolsItem.CustomNormalTextColor = ColorTranslator.FromHtml("#444444");
                this.symbolsItem.CustomActiveTextColor = ColorTranslator.FromHtml("#444444");
                this.Wrapping.CustomNormalTextColor = ColorTranslator.FromHtml("#444444");
                this.Wrapping.CustomActiveTextColor = ColorTranslator.FromHtml("#444444");
                this.WrapType.CustomNormalTextColor = ColorTranslator.FromHtml("#444444");
                this.WrapType.CustomActiveTextColor = ColorTranslator.FromHtml("#444444");
                this.Background.CustomNormalTextColor = ColorTranslator.FromHtml("#444444");
                this.Background.CustomActiveTextColor = ColorTranslator.FromHtml("#444444");
                this.BreakPointColor.CustomNormalTextColor = ColorTranslator.FromHtml("#444444");
                this.BreakPointColor.CustomActiveTextColor = ColorTranslator.FromHtml("#444444");
                this.EditControlStyle.CustomNormalTextColor = ColorTranslator.FromHtml("#444444");
                this.EditControlStyle.CustomActiveTextColor = ColorTranslator.FromHtml("#444444");
                this.FindandReplace.CustomNormalTextColor = ColorTranslator.FromHtml("#444444");
                this.FindandReplace.CustomActiveTextColor = ColorTranslator.FromHtml("#444444");
                this.Outline.CustomNormalTextColor = ColorTranslator.FromHtml("#444444");
                this.Outline.CustomActiveTextColor = ColorTranslator.FromHtml("#444444");
                this.editControl1.EndOfLineBackColor = Color.White;
                this.editControl1.EndOfLineForeColor = Color.Black;
            }
            else if (this.editControl1.Style == Syncfusion.Windows.Forms.Edit.EditControlStyle.Office2016Black)
            {
                this.endOfLineItem.CustomNormalTextColor = ColorTranslator.FromHtml("#f0f0f0");
                this.endOfLineItem.CustomActiveTextColor = ColorTranslator.FromHtml("#f0f0f0");
                this.Selectiontype.CustomNormalTextColor = ColorTranslator.FromHtml("#f0f0f0");
                this.Selectiontype.CustomActiveTextColor = ColorTranslator.FromHtml("#f0f0f0");
                this.Bookmark.CustomNormalTextColor = ColorTranslator.FromHtml("#f0f0f0");
                this.Bookmark.CustomActiveTextColor = ColorTranslator.FromHtml("#f0f0f0");
                this.Advanced.CustomNormalTextColor = ColorTranslator.FromHtml("#f0f0f0");
                this.Advanced.CustomActiveTextColor = ColorTranslator.FromHtml("#f0f0f0");
                this.Breakpoints.CustomNormalTextColor = ColorTranslator.FromHtml("#f0f0f0");
                this.Breakpoints.CustomActiveTextColor = ColorTranslator.FromHtml("#f0f0f0");
                this.symbolsItem.CustomNormalTextColor = ColorTranslator.FromHtml("#f0f0f0");
                this.symbolsItem.CustomActiveTextColor = ColorTranslator.FromHtml("#f0f0f0");
                this.Wrapping.CustomNormalTextColor = ColorTranslator.FromHtml("#f0f0f0");
                this.Wrapping.CustomActiveTextColor = ColorTranslator.FromHtml("#f0f0f0");
                this.WrapType.CustomNormalTextColor = ColorTranslator.FromHtml("#f0f0f0");
                this.WrapType.CustomActiveTextColor = ColorTranslator.FromHtml("#f0f0f0");
                this.Background.CustomNormalTextColor = ColorTranslator.FromHtml("#f0f0f0");
                this.Background.CustomActiveTextColor = ColorTranslator.FromHtml("#f0f0f0");
                this.BreakPointColor.CustomNormalTextColor = ColorTranslator.FromHtml("#f0f0f0");
                this.BreakPointColor.CustomActiveTextColor = ColorTranslator.FromHtml("#f0f0f0");
                this.EditControlStyle.CustomNormalTextColor = ColorTranslator.FromHtml("#f0f0f0");
                this.EditControlStyle.CustomActiveTextColor = ColorTranslator.FromHtml("#f0f0f0");
                this.FindandReplace.CustomNormalTextColor = ColorTranslator.FromHtml("#f0f0f0");
                this.FindandReplace.CustomActiveTextColor = ColorTranslator.FromHtml("#f0f0f0");
                this.Outline.CustomNormalTextColor = ColorTranslator.FromHtml("#f0f0f0");
                this.Outline.CustomActiveTextColor = ColorTranslator.FromHtml("#f0f0f0");
                this.editControl1.EndOfLineBackColor = Color.White;
                this.editControl1.EndOfLineForeColor = Color.Black;
            }
        }

        /// <summary>
        /// To Choose the background Control
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void colorPickerUIAdv1_Picked(object sender, ColorPickerUIAdv.ColorPickedEventArgs args)
        {
            this.Background.PopupControlContainer.HidePopup(PopupCloseType.Done);
            this.editControl1.BackgroundColor = new Syncfusion.Drawing.BrushInfo(this.colorPickerUIAdv1.SelectedColor);
        }
        /// <summary>
        /// To Choose the breakpoint Color
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void colorPickerUIAdv2_Picked(object sender, ColorPickerUIAdv.ColorPickedEventArgs args)
        {
            this.BreakPointColor.PopupControlContainer.HidePopup(PopupCloseType.Done);
            breakpointcolor = (this.colorPickerUIAdv2.SelectedColor);
            this.Refresh();
        }
        #endregion

      #region Items Under Search
        public void Addsearch()
        {
            this.Search.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[]{
            this.FindandReplace,
            this.Goto,
            });
        }
        #endregion

      #region Items under Outlining
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem ToggleOutlining;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem CollapseAll;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem Collapse;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem Expand;
        private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem Outline;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem enable;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem disable;
        public void AddOutlining()
        {
            // 
            //  ToggleOutlining
            // 
            this.ToggleOutlining = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.ToggleOutlining.BarName = "Toggle";
            this.ToggleOutlining.CategoryIndex = 1;
            this.ToggleOutlining.ID = "Toggle";
            this.ToggleOutlining.ShowToolTipInPopUp = false;
            this.ToggleOutlining.SizeToFit = true;
            this.ToggleOutlining.Text = "Expand All";
            this.ToggleOutlining.Click += Outlining_Click;
            // 
            //  CollapseAll
            // 
            this.CollapseAll = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.CollapseAll.BarName = "CollapseAll";
            this.CollapseAll.CategoryIndex = 1;
            this.CollapseAll.ID = "CollapseAll";
            this.CollapseAll.ShowToolTipInPopUp = false;
            this.CollapseAll.SizeToFit = true;
            this.CollapseAll.Text = "Collapse All";
            this.CollapseAll.Click += Outlining_Click;
            // 
            //  Collapse
            // 
            this.Collapse = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.Collapse.BarName = "Collapse";
            this.Collapse.CategoryIndex = 1;
            this.Collapse.ID = "Collapse";
            this.Collapse.ShowToolTipInPopUp = false;
            this.Collapse.SizeToFit = true;
            this.Collapse.Text = "Collapse Current Region";
            this.Collapse.Click += Outlining_Click;
            // 
            //  Expand
            // 
            this.Expand = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.Expand.BarName = "Expand";
            this.Expand.CategoryIndex = 1;
            this.Expand.ID = "Expand";
            this.Expand.ShowToolTipInPopUp = false;
            this.Expand.SizeToFit = true;
            this.Expand.Text = "Expand Current Region";
            this.Expand.Click += Outlining_Click;


            //Enable
            this.enable = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.enable.BarName = "Enable";
            this.enable.CategoryIndex = 1;
            this.enable.ID = "Enable";
            this.enable.ShowToolTipInPopUp = false;
            this.enable.SizeToFit = true;
            this.enable.Text = "Enable";
            this.enable.Checked = true;
            this.enable.Click += Enable_Click; ;

            //Disable
            this.disable = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.disable.BarName = "Disable";
            this.disable.CategoryIndex = 1;
            this.disable.ID = "Disable";
            this.disable.ShowToolTipInPopUp = false;
            this.disable.SizeToFit = true;
            this.disable.Text = "Disable";
            this.disable.Click += Enable_Click;

            // 
            // Outline
            // 
            this.Outline = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.Outline.BarName = "Outlining";
            this.Outline.CategoryIndex = 1;
            this.Outline.ID = "Outlining";
            this.Outline.ShowToolTipInPopUp = false;
            this.Outline.SizeToFit = true;
            this.Outline.Text = "Outline Visibility";
            this.Outline.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
           this.enable,
           this.disable, });



            this.Outlining.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[]{
            this.Outline,
            this.Collapse,
            this.Expand,
            this.CollapseAll,
            this.ToggleOutlining
            });
        }

        private void Enable_Click(object sender, EventArgs e)
        {
            this.enable.Checked = false;
            this.disable.Checked = false;
            BarItem mi = sender as BarItem;
            mi.Checked = true;
            switch (mi.Text)
            {
                case "Enable":
                    this.editControl1.ShowOutliningCollapsers = true;
                    this.ToggleOutlining.Enabled = true;
                    this.Collapse.Enabled = true;
                    this.Expand.Enabled = true;
                    this.CollapseAll.Enabled = true;
                    break;
                case "Disable":
                    this.editControl1.ShowOutliningCollapsers = false;
                    this.ToggleOutlining.Enabled = false;
                    this.Collapse.Enabled = false;
                    this.Expand.Enabled = false;
                    this.CollapseAll.Enabled = false;
                    break;
            }
        }

        private void Outlining_Click(object sender, EventArgs e)
        {
            this.ToggleOutlining.Checked = false;
            this.Collapse.Checked = false;
            this.CollapseAll.Checked = false;
            this.Expand.Checked = false;

            BarItem mi = sender as BarItem;
            mi.Checked = true;

            switch (mi.Text.ToLower())
            {
                case "expand all":
                    this.editControl1.ExpandAll();
                    break;
                case "collapse all":
                    this.editControl1.CollapseAll();
                    break;
                case "collapse current region":
                    this.editControl1.Collapse();
                    break;
                case "expand current region":
                    this.editControl1.Expand();
                    break;
            }
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
}

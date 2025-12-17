#region Copyright Syncfusion Inc. 2001 - 2014
//
//  Copyright Syncfusion Inc. 2001 - 2014. All rights reserved.
//
//  Use of this code is subject to the terms of our license.
//  A copy of the current license can be obtained at any time by e-mailing
//  licensing@syncfusion.com. Any infringement will be prosecuted under
//  applicable laws. 
//
#endregion

using System.Diagnostics;
using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Text.RegularExpressions;
using Syncfusion.Windows.Forms.Edit.Interfaces;
using Syncfusion.Windows.Forms.Edit.Implementation.Config;
using Syncfusion.Windows.Forms.Edit.Implementation.Parser;
using Syncfusion.Windows.Forms.Edit.Enums;
using Syncfusion.Windows.Forms.Edit.Implementation;
using Syncfusion.Windows.Forms;
using Syncfusion.Windows.Forms.Tools.XPMenus;
using Syncfusion.Licensing;
using System.IO;
using Syncfusion.WinForms.Controls;

namespace AdvancedIntellisenseDemo
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : SfForm
	{
    #region Class Private Members
		/// <summary>
		/// Hashtable with descriptions assigned to the lexem configuration.
		/// </summary>
		private Hashtable m_MethodComments = new Hashtable();
		/// <summary>
		/// Hashtable of the prompts list assigned to the lexem configuration.
		/// </summary>
		private Hashtable m_MethodPrompts = new Hashtable();
    #endregion
		private System.ComponentModel.IContainer components;

    #region Class Controls

        private Syncfusion.Windows.Forms.Edit.EditControl editControl1;
        private Syncfusion.Windows.Forms.Tools.XPMenus.MainFrameBarManager mainFrameBarManager1;
        private Syncfusion.Windows.Forms.Tools.XPMenus.Bar bar1;
        private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem parentBarItem1;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem1;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem2;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem3;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem4;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem5;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem6;
		private System.Windows.Forms.ImageList imageList1;
    #endregion

    #region Class Initialization/Finalization
		/// <summary>
		/// Creates and initiallizes form.
		/// </summary>
		public Form1()
		{
			InitializeComponent();
            this.AutoScaleMode = AutoScaleMode.Font;
            try
            {
                System.Drawing.Icon ico = new System.Drawing.Icon(GetIconFile(GetIconFile(@"..\\..\\\logo.ico")));
                this.Icon = ico;
            }
            catch { }
            Customization();
            // Creates new file using C# language configuration.
            editControl1.NewFile( editControl1.Configurator[ "C#" ] );

			// Creates format for methods coloring.
			ISnippetFormat formatMethod = editControl1.Language.Add( "Method", "Text" );
			formatMethod.FontColor = Color.HotPink;

			// Creates format for properties coloring.
			ISnippetFormat formatProperty = editControl1.Language.Add( "Property", "Text" );
			formatProperty.FontColor = Color.Goldenrod;

			// Disables ContextChoiceList dropping after dot in global context.
			ConfigLexem lexemDot_ = GetConfigLexem( (IConfigLexem)editControl1.Language, "." );
			lexemDot_.DropContextChoiceList = false;

			// Adds "this" word processing for global context.
			ConfigLexem lexemThis = GetConfigLexem( (IConfigLexem)editControl1.Language, "this" );
			lexemThis.Type = FormatType.String;
			// "this" starts it`s own context. It does not have EndBlock specified, so the first unprocessed token will force parser to exit from "this"'s context.
			lexemThis.IsComplex = true; 
      
			// Adds "." processing for "this" context: if "this" is followed by "." then the dot will
			// have "lexemDot" configuration.
			ConfigLexem lexemDot = GetConfigLexem( (IConfigLexem)lexemThis, "." );
			lexemDot.Type = FormatType.Operator;
			// "." can drop context choice list
			lexemDot.DropContextChoiceList = true; 
			lexemDot.IsComplex = true;

			// Add configuration for "Property1"
			ConfigLexem this_Property1 = GetConfigLexem( (IConfigLexem)lexemDot, "Property1" );
			this_Property1.Type = FormatType.Custom; this_Property1.FormatName = "Property";
			this_Property1.IsComplex = true;

			// Add configuration for "." after "Property1"
			ConfigLexem propertyDot = GetConfigLexem( (IConfigLexem)this_Property1, "." );
			propertyDot.Type = FormatType.Operator;
			propertyDot.DropContextChoiceList = true;
			propertyDot.IsComplex = true;
			propertyDot.Priority = 10;

			// Add "Method1" configuration after "this.Property1."
			ConfigLexem property_Method1 = GetConfigLexem( (IConfigLexem)propertyDot, "Method1" );
			property_Method1.Type = FormatType.Custom; property_Method1.FormatName = "Method";
			property_Method1.IsComplex = true;

			// Add "Method2" configuration after "this.Property1."
			ConfigLexem property_Method2 = GetConfigLexem( (IConfigLexem)propertyDot, "Method2" );
			property_Method2.Type = FormatType.Custom; property_Method2.FormatName = "Method";
			property_Method2.IsComplex = true;
      
			// Add "TestMethod" configuration after "this."
			ConfigLexem this_Method1 = GetConfigLexem( (IConfigLexem)lexemDot, "TestMethod" );
			this_Method1.Type = FormatType.Custom; this_Method1.FormatName = "Method";
			// needed for processing "(" and ")" next.
			this_Method1.IsComplex = true; 

			// Add "GenerateMap" configuration after "this."
			ConfigLexem this_Method2 = GetConfigLexem( (IConfigLexem)lexemDot, "GenerateMap" );
			this_Method2.Type = FormatType.Custom; this_Method2.FormatName = "Method";
			// needed for processing "(" and ")" next.
			this_Method2.IsComplex = true; 

			// Adds processing of the "(" after "this.Property1.Method1"
			ConfigLexem this_Method1_Braces = GetConfigLexem( (IConfigLexem)this_Method1, "(" );
			//Processing is done until ")" is found.
			this_Method1_Braces.EndBlock = ")"; 
			this_Method1_Braces.Type = FormatType.Operator;
			// Lexem with this config starts it`s own context.
			this_Method1_Braces.IsComplex = true; 
			// ContextPrompt is dropped after entering "("
			this_Method1_Braces.DropContextPrompt = true; 
			// Needed to override "(" from the global context. 
			this_Method1_Braces.Priority = 10; 

			ConfigLexem this_Method2_Braces = GetConfigLexem( (IConfigLexem)this_Method2, "(" );
			this_Method2_Braces.EndBlock = ")";
			this_Method2_Braces.Type = FormatType.Operator;
			this_Method2_Braces.IsComplex = true;
			this_Method2_Braces.DropContextPrompt = true;
			this_Method2_Braces.Priority = 10;
      
			// ResetCaches needed for resetting all configuration caches. Without ResetCaches user changes will not be used.
			editControl1.Language.ResetCaches();

			// Fills collection of descriptions for lexemes with different configurations.
			m_MethodComments[ this_Method1.ID ] = "Test description";
			m_MethodComments[ this_Method2.ID ] = "Generates Some Specific Map....or just tests descriptions in context choice list";
			m_MethodComments[ this_Property1.ID ] = "The only one property\nIt has multiline description";
			m_MethodComments[ property_Method1.ID ] = "Method 1";
			m_MethodComments[ property_Method2.ID ] = "Method 2";

			// Fills collection of prompts, assigned to different lexeme configurations.
			m_MethodPrompts[ this_Method1.ID ] = new DictionaryEntry[]
			{ 
				new DictionaryEntry( this_Method1.BeginBlock + "()", m_MethodComments[ this_Method1.ID ] ),
				new DictionaryEntry( this_Method1.BeginBlock + "( int testData )", 
				(string)m_MethodComments[ this_Method1.ID ] + "\ntestData should be specified" ),
				new DictionaryEntry( this_Method1.BeginBlock + "( int testData, string testParam )", 
				(string)m_MethodComments[ this_Method1.ID ] + "\ntestData and testParam should be specified" )
			};

			m_MethodPrompts[ this_Method2.ID ] = new DictionaryEntry[]
			{ 
				new DictionaryEntry( this_Method2.BeginBlock + "()", m_MethodComments[ this_Method2.ID ] )
			};
    
			// Sets text to be displayed.
			editControl1.Text = @"/* To see how the Context Choice list works, type ""this."" or ""this.Property1."" (if you have closed the popup window, you can re-open it with CTRL+Space shortcut)

To see how the Context ToolTip works move the mouse over some text and you will see information tooltip about text under cursor and description, if available.

To see how the Context Prompt feature works, type ""this.TestMethod("" and you will see list of the overloaded implementations of ""TestMethod"" methods. */

// Examples:  
this. //<- Press CTRL+Space to display the context choice list.

this.TestMethod( //<- Press CTRL+SHIFT+Space after ""("" to display the contextprompt items.

this.GenerateMap(); // Move the mouse over ""GenerateMap"" to see the context tooltip.
";

			// Resets undo buffer, so the user cannot undo setting of the text.
			editControl1.ResetUndoInfo();
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
		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

    #endregion
		
    #region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Syncfusion.Windows.Forms.Edit.Implementation.Config.Config config1 = new Syncfusion.Windows.Forms.Edit.Implementation.Config.Config();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.editControl1 = new Syncfusion.Windows.Forms.Edit.EditControl();
            this.mainFrameBarManager1 = new Syncfusion.Windows.Forms.Tools.XPMenus.MainFrameBarManager(this);
            this.bar1 = new Syncfusion.Windows.Forms.Tools.XPMenus.Bar(this.mainFrameBarManager1, "menu");
            this.parentBarItem1 = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.barItem1 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem2 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem3 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem4 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem5 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem6 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            ((System.ComponentModel.ISupportInitialize)(this.editControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainFrameBarManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "");
            this.imageList1.Images.SetKeyName(1, "");
            this.imageList1.Images.SetKeyName(2, "");
            // 
            // editControl1
            // 
            this.editControl1.CodeSnipptSize = new System.Drawing.Size(100, 100);
            this.editControl1.ColumnGuidesMeasuringFont = new System.Drawing.Font("Segoe UI", 8.25F);
            this.editControl1.Configurator = config1;
            this.editControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.editControl1.FilterAutoCompleteItems = false;
            this.editControl1.GraphicsTextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.editControl1.IndicatorMarginBackColor = System.Drawing.Color.Empty;
            this.editControl1.LineNumbersFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.editControl1.Location = new System.Drawing.Point(10, 39);
            this.editControl1.Name = "editControl1";
            this.editControl1.RenderRightToLeft = false;
            this.editControl1.SaveOnClose = false;
            this.editControl1.ScrollPosition = new System.Drawing.Point(0, 0);
            this.editControl1.ShowIndicatorMargin = false;
            this.editControl1.ShowSelectionMargin = false;
            this.editControl1.Size = new System.Drawing.Size(524, 408);

            this.editControl1.StatusBarSettings.TextPanel.AutoSize = false;
            this.editControl1.TabIndex = 0;
            this.editControl1.Text = "editControl1";
            this.editControl1.TransferFocusOnTab = true;
            this.editControl1.UseXPStyleBorder = true;
            this.editControl1.VisualColumn = 1;
            this.editControl1.WordWrap = true;
            this.editControl1.ContextChoiceBeforeOpen += new System.ComponentModel.CancelEventHandler(this.editControl1_ContextChoiceBeforeOpen);
            this.editControl1.ContextChoiceOpen += new Syncfusion.Windows.Forms.Edit.ContextChoiceEventHandler(this.editControl1_ContextChoiceOpen);
            this.editControl1.ContextPromptBeforeOpen += new System.ComponentModel.CancelEventHandler(this.editControl1_ContextChoiceBeforeOpen);
            this.editControl1.ContextPromptOpen += new Syncfusion.Windows.Forms.Edit.ContextPromptUpdateEventHandler(this.editControl1_ContextPromptOpen);
            this.editControl1.ContextPromptUpdate += new Syncfusion.Windows.Forms.Edit.ContextPromptUpdateEventHandler(this.editControl1_ContextPromptUpdate);
            this.editControl1.UpdateContextToolTip += new Syncfusion.Windows.Forms.Edit.UpdateTooltipEventHandler(this.editControl1_UpdateContextToolTip);
            // 
            // mainFrameBarManager1
            // 
#if !NETCORE
            this.mainFrameBarManager1.BarPositionInfo = ((System.IO.MemoryStream)(resources.GetObject("mainFrameBarManager1.BarPositionInfo")));
#endif
            this.mainFrameBarManager1.Bars.Add(this.bar1);
            this.mainFrameBarManager1.Categories.Add("file");
            this.mainFrameBarManager1.CurrentBaseFormType = "Syncfusion.Windows.Forms.MetroForm";
            this.mainFrameBarManager1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainFrameBarManager1.Form = this;
            this.mainFrameBarManager1.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.parentBarItem1,
            this.barItem1,
            this.barItem2,
            this.barItem3,
            this.barItem4,
            this.barItem5,
            this.barItem6});
            this.mainFrameBarManager1.MetroColor = System.Drawing.Color.DeepSkyBlue;
            this.mainFrameBarManager1.ResetCustomization = false;
            this.mainFrameBarManager1.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            // 
            // bar1
            // 
            this.bar1.BarName = "menu";
            this.bar1.Caption = "menu";
            this.bar1.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.parentBarItem1});
            this.bar1.Manager = this.mainFrameBarManager1;
            // 
            // parentBarItem1
            // 
            this.parentBarItem1.BarName = "parentBarItem1";
            this.parentBarItem1.CategoryIndex = 0;
            this.parentBarItem1.ID = "File";
            this.parentBarItem1.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.barItem1,
            this.barItem2,
            this.barItem3,
            this.barItem4,
            this.barItem5,
            this.barItem6});
            this.parentBarItem1.MetroColor = System.Drawing.Color.DeepSkyBlue;
            this.parentBarItem1.ShowToolTipInPopUp = false;
            this.parentBarItem1.SizeToFit = true;
            this.parentBarItem1.Text = "File";
            // 
            // barItem1
            // 
            this.barItem1.BarName = "barItem1";
            this.barItem1.CategoryIndex = 0;
            this.barItem1.ID = "New";
            this.barItem1.ShowToolTipInPopUp = false;
            this.barItem1.SizeToFit = true;
            this.barItem1.Text = "New";
            this.barItem1.Click += new System.EventHandler(this.MainMenuClick);
            // 
            // barItem2
            // 
            this.barItem2.BarName = "barItem2";
            this.barItem2.CategoryIndex = 0;
            this.barItem2.ID = "Open";
            this.barItem2.ShowToolTipInPopUp = false;
            this.barItem2.SizeToFit = true;
            this.barItem2.Text = "Open";
            this.barItem2.Click += new System.EventHandler(this.MainMenuClick);
            // 
            // barItem3
            // 
            this.barItem3.BarName = "barItem3";
            this.barItem3.CategoryIndex = 0;
            this.barItem3.ID = "Save";
            this.barItem3.ShowToolTipInPopUp = false;
            this.barItem3.SizeToFit = true;
            this.barItem3.Text = "Save";
            this.barItem3.Click += new System.EventHandler(this.MainMenuClick);
            // 
            // barItem4
            // 
            this.barItem4.BarName = "barItem4";
            this.barItem4.CategoryIndex = 0;
            this.barItem4.ID = "SaveAs";
            this.barItem4.ShowToolTipInPopUp = false;
            this.barItem4.SizeToFit = true;
            this.barItem4.Text = "SaveAs";
            this.barItem4.Click += new System.EventHandler(this.MainMenuClick);
            // 
            // barItem5
            // 
            this.barItem5.BarName = "barItem5";
            this.barItem5.CategoryIndex = 0;
            this.barItem5.ID = "Close";
            this.barItem5.ShowToolTipInPopUp = false;
            this.barItem5.SizeToFit = true;
            this.barItem5.Text = "Close";
            this.barItem5.Click += new System.EventHandler(this.MainMenuClick);
            // 
            // barItem6
            // 
            this.barItem6.BarName = "barItem6";
            this.barItem6.CategoryIndex = 0;
            this.barItem6.ID = "Exit";
            this.barItem6.ShowToolTipInPopUp = false;
            this.barItem6.SizeToFit = true;
            this.barItem6.Text = "Exit";
            this.barItem6.Click += new System.EventHandler(this.MainMenuClick);
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 15);
            this.ClientSize = new System.Drawing.Size(544, 457);
            this.Controls.Add(this.editControl1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(556, 494);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Advanced Intellisense";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.editControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainFrameBarManager1)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

    #region MAIN Method
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
 SyncfusionLicenseProvider.RegisterLicense(DemoCommon.FindLicenseKey());
Application.EnableVisualStyles();
			Application.Run(new Form1());
		}
    #endregion

    #region Class Helper Methods
		/// <summary>
		/// Looks for the configuration with given name in the specified container.
		/// </summary>
		/// <param name="container"></param>
		/// <param name="lexemStart"></param>
		/// <returns></returns>
		private ConfigLexem GetConfigLexem( IConfigLexem container, string lexemStart )
		{
			ConfigLexem lexem = null;
      
			// Searches configuration.
			foreach( IConfigLexem lexemTemp in container.SubLexems )
			{
				if( lexemTemp.IsEqualToBegin( lexemStart ) )
				{
					lexem = lexemTemp as ConfigLexem;
					break;
				}
			}

			// If it was not found, then create new one.
			if( lexem == null )
			{
				lexem = new ConfigLexem( lexemStart, "", FormatType.Text, false );
				container.SubLexems.Add( lexem );
        
				// ParentConfig will be updated in ResetCaches, but the newly created configuration cannot be used without ParentConfig being set.
				lexem.ParentConfig = container;
			}

			return lexem;
		}

		/// <summary>
		/// Looks for the first lexeme on the left with DropContextChoiceList set to true in config
		/// </summary>
		/// <returns></returns>
		private ILexem FindDropper()
		{
			ILexemLine line = editControl1.CurrentLineInstance;

			if( line == null ) return null;

			ILexem lexem = line.FindLexemByColumn( editControl1.CurrentColumn );

			if( lexem == null )
			{
				// If we are in the virtual space in the line.
				if( editControl1.CurrentColumn > 1 )
					lexem = line.FindLexemByColumn( line.LineLength );

				if( lexem == null ) return null;
			}
     
			// If current lexem is dropper itself
			if( lexem.Config.DropContextChoiceList )
				return lexem;

			int index = line.LineLexems.IndexOf( lexem );

			while( index > 0 && !lexem.Config.DropContextChoiceList )
				lexem = line.LineLexems[ --index ] as ILexem;

			if( index <= 0 ) lexem = null;

			return lexem;
		}

		/// <summary>
		/// Gets list of the items to be put to the context choice list.
		/// </summary>
		/// <returns></returns>
		private ICollection GetList()
		{
			// Gets neares context choice list "dropper"
			ILexem lexem = FindDropper();

			ArrayList list = new ArrayList();
			if( lexem == null ) return list;

			// Adds to the resulting list all lexeme configuratios with "Method" and "Property" formats.
			foreach( IConfigLexem confLex in lexem.Config.SubLexems )
			{
				if( confLex.Format.Name == "Method" )
					list.Add( confLex );
        
				if( confLex.Format.Name == "Property" )
					list.Add( confLex );
			}

			return list;
		}

		/// <summary>
		/// Parses contextprompt item's subject and adds all its parameters to the collection of bolded items.
		/// </summary>
		/// <param name="item"></param>
		private void ParseContectPromptSubject( ContextPromptItem item )
		{
			// Example: MethodName( int param, string param2 )
			// will be matched as : 1) "int param", 2) "string param2"
			Regex regex = new Regex( @"\(\s*((?<param>[^,]+)\s*\,*\s*)*\s*\)" );
			Match match = regex.Match( item.Subject );

			if( match.Success )
			{
				foreach( Capture param in match.Groups[ "param" ].Captures )
				{
					// Add matches to the list of bolded items.
					// Every bolded item has such properties:
					// BoldTextStart - starting index of the bolded substring of the subject
					// BoldTextLength - length of the bolded substring of the subject
					// Description - description, that should be shown when you select some bolded item.
          
					// Note: bolded items can not be selected automatically, 
					// user should select them while processing ContextPromptUpdate event. 
					ContextPromptBoldTextItem itemBolded = 
						item.BoldedItems.Add( param.Index, param.Length, param.Value );
				}
			}

		}
    #endregion

    #region Class Event Handlers
		/// <summary>
		/// Checks wether ContextChoice menu can be dropped.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void editControl1_ContextChoiceBeforeOpen(object sender, System.ComponentModel.CancelEventArgs e)
		{
			e.Cancel = ( FindDropper() == null );
		}
		/// <summary>
		/// Fills ContextChoiceMenu according to the current context.
		/// </summary>
		/// <param name="form"></param>
		private void editControl1_ContextChoiceOpen( IContextChoiceController controller )
		{
			// Gets the list of Method and Property configurations for current context.
			ICollection list = GetList();

			int imageIndex=0;
			// Adds configuration BeginBlocks and associated descriptions to the Context Choice List.
			foreach( IConfigLexem conf in list )
			{
				controller.Items.Add(conf.BeginBlock, (string)m_MethodComments[conf.ID], this.editControl1.ContextChoiceController.Images["Image"+imageIndex.ToString()] );
				imageIndex++;
			}
		}

		/// <summary>
		/// Fills context prompt menu.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void editControl1_ContextPromptOpen(object sender, Syncfusion.Windows.Forms.Edit.ContextPromptUpdateEventArgs e)
		{
			// First of all we should get lexem(if it is one), 
			// which opens current region that supports context prompt dropping.
			ILexem lex = GetCurrentContextPromptDropper();

			if( lex == null )
			{
				// If there is no such lexem, than we should not show context prompt.
				e.CloseForm = true;
				return;
			}

			IConfigLexem conf = lex.Config.ParentConfig;

			// If there is no prompts assigned to the found complex lexem, than we should exit.
			if( !m_MethodPrompts.Contains( conf.ID ) ) return;

			DictionaryEntry[] prompts = ( DictionaryEntry[] )m_MethodPrompts[ conf.ID ];
            e.List.Clear();
			// add prompts
			foreach( DictionaryEntry entry in prompts )
			{
				// Creates new context prompt item and adds it to the list of the prompts.
				ContextPromptItem itemNew = e.List.Add( (string)entry.Key, (string)entry.Value );
				// Parses subject of the item, splits it to the set of method parameters
				// and adds every parameter as boldable item to the context prompt item.
				ParseContectPromptSubject( itemNew );
			}
		}
		/// <summary>
		/// 
		/// </summary>
		/// <param name="stack"></param>
		/// <returns></returns>
		private IStackData GetCurrentDropperLexemConfigPair( out ConfigStack stack )
		{
			// Gets current stack of complex lexems.
			// Example: 
			// {                        <- first { in stack
			//   get
			//   { return null;
			//   }
			//   set
			//   {                      <- second { in stack
			//     CallMethod1( |<-cursor is here )
			//   }
			// When cursor is set as in example, stack will have such data:
			// 1) first lexem "{",its configuration and position
			// 2) complex lexem "set", its configuration and position 
			// 3) second lexem "{",its configuration and position
			// 4) complex lexem "CallMethod1", its configuration and position
			// 5) complex lexem lexem "(",its configuration and position, ( is context prompt dropper( DropContextPrompt == true ).
			// Note: this example is not appliable to configuration in current sample.

			stack = editControl1.GetCurrentStack();

			if( stack != null && stack.Count > 0 )
			{
				IStackData stackItem = stack.Pop();

				if( stackItem.Config.DropContextPrompt )
					return stackItem;
			}

			return null;
		}
		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		private ILexem GetCurrentContextPromptDropper()
		{
			ConfigStack stack;
			IStackData stackItem = 
				GetCurrentDropperLexemConfigPair( out stack );

			if( stackItem != null )
				return stackItem.Lexem;

			return null;
		}

		/// <summary>
		/// Fills context prompt menu.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void editControl1_ContextPromptUpdate(object sender, Syncfusion.Windows.Forms.Edit.ContextPromptUpdateEventArgs e)
		{
			if( e.List.SelectedItem == null ) return;

			ConfigStack stack;
      
			// Gets information about region, that supports context prompt dropping, we are currently in.
			IStackData dropper = GetCurrentDropperLexemConfigPair( out stack );

			if( dropper != null )
			{
				// If we have found start start of the region which is context prompt dropper, 
				// than we should get list of lexems inside that region that are before current cursor position.
				IList list = editControl1.GetLexemsInsideCurrentStack( false );

				if( list == null )
				{
					// If something is wrong than close context prompt.
					e.CloseForm = true;
					return;
				}
        
				int iIndex = 0;
        
				// Count all commas that are before that cursor position.
				// Doing that we can find index of the subject part we should make bolded.
				foreach( ILexem lexem in list )
				{
					if( lexem.Text == "," ) iIndex++;
				}

				// If we have found index of the bolded item in currently selected context prompt, 
				// than select it.
				if( iIndex >= e.List.SelectedItem.BoldedItems.Count || iIndex < 0 )
					e.List.SelectedItem.BoldedItems.SelectedItem = null;
				else
					e.List.SelectedItem.BoldedItems.SelectedItem = e.List.SelectedItem.BoldedItems[ iIndex ];
			}
			else
			{
				// If we have moved out of the region that supports context prompt dropping, than close context prompt.
				e.CloseForm = true;
			}
		}
		/// <summary>
		/// Gets lexeme info.
		/// </summary>
		/// <param name="lexem">Lexem.</param>
		/// <returns>Lexem info text.</returns>
		private string GetLexemInfo( ILexem lexem )
		{
			// Get configuration path of the lexem under cursor.
			// Example: Property1 will have path like "this->.->Property1".
			string confPath = lexem.Config.BeginBlock;
			IConfigLexem conf = lexem.Config.ParentConfig;

			while( conf != null && !( conf is IConfigLanguage ) )
			{
				confPath = conf.BeginBlock + "->" + confPath;
				conf = conf.ParentConfig;
			}

			return string.Format( "Text: \"{0}\"; ConfigPath: \"{1}\"; FormatName: {2}", lexem.Text, confPath, lexem.Config.Format.Name );
		}

		/// <summary>
		/// Gets context tooltip.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void editControl1_UpdateContextToolTip(object sender, Syncfusion.Windows.Forms.Edit.UpdateTooltipEventArgs e)
		{
			// If the text is already specified, than we should not change it. This is needed to display default tooltip for the collapsed region.
			if( e.Text != string.Empty )
				return;

			// Convert position of the mouse cursor to the position in text.
			Point virt = editControl1.PointToVirtualPosition( new Point( e.X, e.Y ), true );

			// If there is no text in tat position, tan exit.
			if( virt.IsEmpty == true ) return;

			ILexemLine line = editControl1.GetLine( virt.Y );

			if( line != null )
			{
				// Get lexem under cursor.
				ILexem lexem = line.FindLexemByColumn( virt.X );

				if( lexem != null )
				{
					// Set text of the tooltip.
					e.Text = GetLexemInfo( lexem ) + "\n";

					// Get stack of the lexem.
					ConfigStack stack = line.GetStackByColumn( virt.X );

					if( stack != null )
					{
						e.Text += "Stack before parsing lexem:\n";
            
						while( stack.Count > 0 )
						{
							IStackData stackItem = 
								( IStackData )stack.Pop();

							if( stackItem.Lexem != null )
								e.Text += "-- " + GetLexemInfo( stackItem.Lexem ) + "\n";
						}

						e.Text += "\n";
					}

					// Add description if present.
					if( m_MethodComments.Contains( lexem.Config.ID ) )
					{
						e.Text += "Lexem contains description:\n";
						e.Text += m_MethodComments[ lexem.Config.ID ];
					}
				}
			}
		}

    #endregion

		private void MainMenuClick(object sender, System.EventArgs e)
		{
            BarItem mi = sender as BarItem;
          

			switch (mi.Text)
			{
				case "New" :
					this.editControl1.NewFile();
					break;
				case "Open" :
					this.editControl1.LoadFile();
					break;
				case "Save" :
					this.editControl1.Save();
					break;
				case "SaveAs" :
					this.editControl1.SaveAs();
					break;
				case "Close" :
					this.editControl1.Close();
					break;
				case "Exit" :
					this.Close();
					break;
			}
		}


        #region Customization
        public void Customization()
        {
            this.mainFrameBarManager1.Style = VisualStyle.Office2016White;
            this.editControl1.Style = Syncfusion.Windows.Forms.Edit.EditControlStyle.Office2016White;
            this.Padding = new System.Windows.Forms.Padding(0);
        }
        #endregion


        private void Form1_Load(object sender, System.EventArgs e)
		{
			this.Size = new Size(550,500);

            this.editControl1.BorderStyle = BorderStyle.Fixed3D;
            this.editControl1.ShowVerticalSplitters = false;
            this.editControl1.ShowHorizontalSplitters = false;
            this.editControl1.ShowOutliningCollapsers = false;
            this.editControl1.ShowSelectionMargin = false;

			int index=0;
			foreach (Image img in this.imageList1.Images)
			{
				// Populating images using an external ImageList
				this.editControl1.ContextChoiceController.AddImage("Image"+index.ToString(), img);
				index++;
			}
		}
	}
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

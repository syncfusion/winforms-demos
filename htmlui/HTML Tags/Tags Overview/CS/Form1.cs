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

using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.IO;
using System.Reflection;
using Syncfusion.Windows.Forms;
using Syncfusion.Licensing;

namespace HTMLUITagsSample
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : MetroForm
	{
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.ListBox listBox1;

		private string templateText = "<html><head>$head</head><body>$body</body></html>";
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label label1;
        private Syncfusion.Windows.Forms.HTMLUI.HTMLUIControl htmluiControl1;
        private GroupBox groupBox2;
        private GroupBox groupBox1;
        private Syncfusion.Windows.Forms.ScrollersFrame scrollersFrame1;
        private Syncfusion.Windows.Forms.Tools.SplitContainerAdv splitContainerAdv1;
        private IContainer components;

		public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
            try
            {
                System.Drawing.Icon ico = new System.Drawing.Icon(GetIconFile(@"common\Images\Grid\Icon\sfgrid.ico"));
                this.Icon = ico;
            }
            catch { }
			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

        #region
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

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.htmluiControl1 = new Syncfusion.Windows.Forms.HTMLUI.HTMLUIControl();
            this.scrollersFrame1 = new Syncfusion.Windows.Forms.ScrollersFrame(this.components);
            this.splitContainerAdv1 = new Syncfusion.Windows.Forms.Tools.SplitContainerAdv();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.htmluiControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerAdv1)).BeginInit();
            this.splitContainerAdv1.Panel1.SuspendLayout();
            this.splitContainerAdv1.Panel2.SuspendLayout();
            this.splitContainerAdv1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.listBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(208, 481);
            this.panel1.TabIndex = 1;
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.White;
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.HorizontalScrollbar = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Items.AddRange(new object[] {
            "A (Link) ",
            "B (Bold) ",
            "BR (Break line) ",
            "EM (Makes text italic) ",
            "FONT (Inline element for text) ",
            "H1 (Heading 1)",
            "H2 (Heading 2)",
            "H3 (Heading 3)",
            "H4 (Heading 4)",
            "H5 (Heading 5)",
            "H6 (Heading 6)",
            "HR (Horizontal line) ",
            "I (Makes text italic) ",
            "U(Underlines text) ",
            "LINK (Used for attaching CSS document) ",
            "SPAN (Inline element for applying CSS style) ",
            "STRONG (Makes text bold) ",
            "STYLE (Used for attaching CSS inside html document) ",
            "TITLE (You can see it on the top of control) ",
            "INPUT(Windows Forms controls, such a button, textbox, etc...) ",
            "SELECT(ListBox or ComboBox win controls) ",
            "TEXTAREA(Multiline TextBox win control) ",
            "CHECKBOX(CheckBox win control) ",
            "RADIO(RadioBox win control) ",
            "CODE(Inlinetag for representing code sample) ",
            "DIV(Block tag container) ",
            "FORM(Container for win controls) ",
            "BODY(Container of visual document data) ",
            "HEAD(Container for document\'s settings) ",
            "LI(Simple item of the list) ",
            "OL(Ordered list container) ",
            "P(Container of text paragraph) ",
            "PRE(Container of formated text) ",
            "SCRIPT(Container of script code) ",
            "TABLE(Represents table container) ",
            "TR(Container of single row in the table) ",
            "TD(Container of single cell in the table) ",
            "TH(Header of the column in the table) ",
            "UL(Unordered list container) "});
            this.listBox1.Location = new System.Drawing.Point(0, 0);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(208, 481);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(513, 481);
            this.panel2.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(513, 206);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "HTML Tag code:";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(10, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(497, 54);
            this.label1.TabIndex = 5;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.htmluiControl1);
            this.groupBox1.Location = new System.Drawing.Point(0, 212);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(513, 266);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "HTML Output:";
            // 
            // htmluiControl1
            // 
            this.htmluiControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.htmluiControl1.BackColor = System.Drawing.Color.White;
            this.htmluiControl1.DefaultFormat.BackgroundColor = System.Drawing.SystemColors.Control;
            this.htmluiControl1.DefaultFormat.ForeColor = System.Drawing.SystemColors.ControlText;
            this.htmluiControl1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.htmluiControl1.ForeColor = System.Drawing.Color.Black;
            this.htmluiControl1.Location = new System.Drawing.Point(3, 16);
            this.htmluiControl1.Name = "htmluiControl1";
            this.htmluiControl1.ShowTitle = false;
            this.htmluiControl1.Size = new System.Drawing.Size(507, 224);
            this.htmluiControl1.TabIndex = 4;
            this.htmluiControl1.Text = resources.GetString("htmluiControl1.Text");
            // 
            // scrollersFrame1
            // 
            this.scrollersFrame1.AttachedTo = this.listBox1;
            this.scrollersFrame1.CustomRender = null;
            this.scrollersFrame1.MetroColorScheme = Syncfusion.Windows.Forms.MetroColorScheme.Managed;
            this.scrollersFrame1.SizeGripperVisibility = Syncfusion.Windows.Forms.SizeGripperVisibility.Auto;
            this.scrollersFrame1.VisualStyle = Syncfusion.Windows.Forms.ScrollBarCustomDrawStyles.Metro;
            // 
            // splitContainerAdv1
            // 
            this.splitContainerAdv1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerAdv1.IsSplitterFixed = true;
            this.splitContainerAdv1.Location = new System.Drawing.Point(10, 10);
            this.splitContainerAdv1.Name = "splitContainerAdv1";
            // 
            // splitContainerAdv1.Panel1
            // 
            this.splitContainerAdv1.Panel1.Controls.Add(this.panel1);
            // 
            // splitContainerAdv1.Panel2
            // 
            this.splitContainerAdv1.Panel2.Controls.Add(this.panel2);
            this.splitContainerAdv1.Size = new System.Drawing.Size(728, 481);
            this.splitContainerAdv1.SplitterDistance = 208;
            this.splitContainerAdv1.TabIndex = 3;
            this.splitContainerAdv1.Text = "splitContainerAdv1";
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.CaptionAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ClientSize = new System.Drawing.Size(748, 501);
            this.Controls.Add(this.splitContainerAdv1);
            this.DropShadow = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IconAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.IconTextRelation = System.Windows.Forms.LeftRightAlignment.Left;
            this.MetroColor = System.Drawing.Color.White;
            this.MinimumSize = new System.Drawing.Size(760, 537);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TagsOverview";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.htmluiControl1)).EndInit();
            this.splitContainerAdv1.Panel1.ResumeLayout(false);
            this.splitContainerAdv1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerAdv1)).EndInit();
            this.splitContainerAdv1.ResumeLayout(false);
            this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
            SyncfusionLicenseProvider.RegisterLicense(DemoCommon.FindLicenseKey());
            Application.Run(new Form1());
		}

		private void LoadHTML()
		{
			this.htmluiControl1.LoadFromString(templateText);
		}

		private void Form1_Load(object sender, System.EventArgs e)
		{
			LoadHTML();
		}

		private void listBox1_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			string changedText = String.Empty;
			string elementText = String.Empty;
			switch(this.listBox1.SelectedIndex)
			{
				case 0://A Link
					elementText = "<a href='test.htm'>Link</a>";
					changedText = templateText.Replace("$body", elementText);
					break;
				case 1://B
					elementText = "<b>Sample Text</b>";
					changedText = templateText.Replace("$body", elementText);
					break;
				case 2://BR
					elementText = "Line 1 <br />Line 2 <br />Line 3";
					changedText = templateText.Replace("$body", elementText);
					break;
				case 3://EM
					elementText = "<em>This &lt;em&gt; tag</em>";
					changedText = templateText.Replace("$body", elementText);
					break;
				case 4://FONT
					elementText = "<font face=\"Courier New\" size=\"6\">This is Courier New</font>";
					changedText = templateText.Replace("$body", elementText);
					break;
				case 5://H1
					elementText = "<h1>This is Heading 1</h1>";
					changedText = templateText.Replace("$body", elementText);
					break;
				case 6://H2
					elementText = "<h2>This is Heading 2</h2>";
					changedText = templateText.Replace("$body", elementText);
					break;
				case 7://H3
					elementText = "<h3>This is Heading 3</h3>";
					changedText = templateText.Replace("$body", elementText);
					break;
				case 8://H4
					elementText = "<h4>This is Heading 4</h4>";
					changedText = templateText.Replace("$body", elementText);
					break;
				case 9://H5
					elementText = "<h5>This is Heading 5</h5>";
					changedText = templateText.Replace("$body", elementText);
					break;
				case 10://H6
					elementText = "<h6>This is Heading 6</h6>";
					changedText = templateText.Replace("$body", elementText);
					break;
				case 11://HR
					elementText = "<hr>";
					changedText = templateText.Replace("$body", elementText);
					break;
				case 12://I
					elementText = "<i>This is &lt;i&gt; tag</i>";
					changedText = templateText.Replace("$body", elementText);
					break;
				case 13://U
					elementText = "<u>This is underlined text</u>";
					changedText = templateText.Replace("$body", elementText);
					break;
				
				case 14://LINK
					elementText = "<LINK href=\"http://www.syncfusion.com/include/ie4.css\" rel=\"stylesheet\" type=\"text/css\">";
					changedText = templateText.Replace("$head", elementText);
					elementText = "<p>Link to style sheet</p>";
					changedText = templateText.Replace("$body", elementText);
					break;
				case 15://SPAN
					elementText = "<p>This is a paragraph <span style=\"color:#0000FF;\">This is a paragraph</span> This is a paragraph</p>";
					changedText = templateText.Replace("$body", elementText);
					break;
				case 16://STRONG (Makes text bold) 
					elementText = "<strong>Bold Text</strong>";
					changedText = templateText.Replace("$body", elementText);
					break;
				case 17://STYLE (Used for attaching CSS inside html document) 
					elementText = "<p>This is a paragraph <span style=\"color:#0000FF;\">This is a paragraph</span> This is a paragraph</p>";
					changedText = templateText.Replace("$body", elementText);
					break;
				case 18://TITLE (You can see it on the top of control) 
					elementText = "<title>HTMLUI Sample Title</title>";
					changedText = templateText.Replace("$head", elementText);
					break;
				case 19://INPUT(Windows Forms controls, such a button, textbox, etc...) 
					elementText = "<form><input type=\"text\"></form>";
					changedText = templateText.Replace("$body", elementText);
					break;
				case 20://SELECT(ListBox or ComboBox win controls) 
					elementText = "<form><select><option value =\"volvo\">Volvo</option><option value =\"saab\">Saab</option><option value =\"opel\">Opel</option><option value =\"audi\">Audi</option></select></form>";
					changedText = templateText.Replace("$body", elementText);
					break;
				case 21://TEXTAREA(Multiline TextBox win control) 
					elementText = "<form><textarea rows=\"2\" cols=\"20\">Sample for textarea tag in HTMLUI.....</textarea></form>";
					changedText = templateText.Replace("$body", elementText);
					break;
				case 22://CHECKBOX(CheckBox win control) 
					elementText = "<form><input type=\"checkbox\"></form>";
					changedText = templateText.Replace("$body", elementText);
					break;
				case 23://RADIO(RadioBox win control) 
					elementText = "<form><input type=\"radio\"></form>";
					changedText = templateText.Replace("$body", elementText);
					break;
				case 24://CODE(Inlinetag for representing code sample) 
					elementText = "<code>Computer code text</code>";
					changedText = templateText.Replace("$body", elementText);
					break;
				case 25://DIV(Block tag container) 
					elementText = "This is some text <div style=\"color:#FF0000;\"><h4>This is a header in a div section</h4><p>This is a paragraph in a div section</p></div>";
					changedText = templateText.Replace("$body", elementText);
					break;
				case 26://FORM(Container for win controls) 
					elementText = "<form><input type=\"radio\"><input type=\"checkbox\"></form>";
					changedText = templateText.Replace("$body", elementText);
					break;
				case 27://BODY(Container of visual document data) 
					elementText = "Text in body tag";
					changedText = templateText.Replace("$body", elementText);
					break;
				case 28://HEAD(Container for document\'s settings) 
					elementText = "Head tag";
					changedText = templateText.Replace("$head", elementText);
					break;
				case 29://LI(Simple item of the list) 
					elementText = "<ol><li>Windows Forms</li><li>ASP.NET</li></ol>";
					changedText = templateText.Replace("$body", elementText);
					break;
				case 30://OL(Ordered list container)
					elementText = "<ol><li>Windows Forms</li><li>ASP.NET</li></ol>";
					changedText = templateText.Replace("$body", elementText);
					break;
				case 31://P(Container of text paragraph)
					elementText = "<p>This is some text in a paragraph</p>";
					changedText = templateText.Replace("$body", elementText);
					break;
				case 32://PRE(Container of formated text)
					elementText = "<pre>This text is in a fixed-pitch font, and it preserves       spaces</pre>";
					changedText = templateText.Replace("$body", elementText);
					break;
				case 33://SCRIPT(Container of script code)
					elementText = "<script language=\"C#\">Please refer to the scripting sample</script>";
					changedText = templateText.Replace("$head", elementText);
					break;
				case 34://TABLE(Represents table container)
					elementText = "<table border = \"1\"><tr><td>Cell A</td><td>Cell B</td></tr></table>";
					changedText = templateText.Replace("$body", elementText);
					break;
				case 35://TR(Container of single row in the table)
					elementText = "<table border = \"1\"><tr><td>Cell A</td><td>Cell B</td></tr></table>";
					changedText = templateText.Replace("$body", elementText);
					break;
				case 36://TD(Container of single cell in the table)
					elementText = "<table border = \"1\"><tr><td>Cell A</td><td>Cell B</td></tr></table>";
					changedText = templateText.Replace("$body", elementText);
					break;
				case 37://TH(Header of the column in the table) 
					elementText = "<table border = \"1\"><tr><th>Header 1</th><th>Header 2</th></tr><tr><td>Cell A</td><td>Cell B</td></tr></table>";
					changedText = templateText.Replace("$body", elementText);
					break;
				case 38://UL(Unordered list container)
					elementText = "<ul><li>Windows Forms</li><li>ASP.NET</li></ul>";
					changedText = templateText.Replace("$body", elementText);
					break;
				default:
					elementText = "Tag not specified";
					changedText = templateText.Replace("$body", elementText);
					break;
			}
			
			this.label1.Text = elementText;
			this.htmluiControl1.LoadFromString(changedText);
		}
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

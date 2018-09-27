#region Copyright Syncfusion Inc. 2001 - 2017
//
//  Copyright Syncfusion Inc. 2001 - 2017. All rights reserved.
//
//  Use of this code is subject to the terms of our license.
//  A copy of the current license can be obtained at any time by e-mailing
//  licensing@syncfusion.com. Any infringement will be prosecuted under
//  applicable laws. 
//
#endregion

using System;
using System.Drawing;
using System.ComponentModel;
using System.Windows.Forms;

using Syncfusion.DocIO;
using Syncfusion.DocIO.DLS;
using Syncfusion.Windows.Forms;
using Syncfusion.Windows.Forms.Tools;
using Syncfusion.Licensing;
using System.Reflection;
using System.Text;
using System.IO;

namespace EssentialDocIOSamples
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
    public class Form1 : MetroForm
    {
        private ButtonAdv button1;
        private Label label2;
        private PictureBox pictureBox1;
        private ToolTip toolTip1;
        private GroupBox groupBox1;
        private RadioButtonAdv wordDocxRadioBtn;
        private RadioButtonAdv wordDocRadioBtn;
        private IContainer components=null;

		public Form1()
		{
			//
			// Required for Windows Form Designer support
			//			
			InitializeComponent();
			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}
        /// <summary>
        /// Helper method to find a syncfusion license key from the Common folder
        /// </summary>
        /// <param name="fileName">File name of the syncfusion license key</param>
        /// <returns></returns>
        public static string FindLicenseKey()
        {
            int levelsToCheck = 12;
            string filePath = @"Common\SyncfusionLicense.txt";

            string rootPath = System.IO.Path.GetDirectoryName(Assembly.GetEntryAssembly().CodeBase.Replace(@"file:///", ""));

            for (int n = 0; n < levelsToCheck; n++)
            {
                string fileDataPath = System.IO.Path.Combine(rootPath, filePath);
                if (System.IO.File.Exists(fileDataPath))
                    return File.ReadAllText(fileDataPath, Encoding.UTF8);
                DirectoryInfo rootDirectory = Directory.GetParent(rootPath);
                if (rootDirectory == null)
                    break;
                rootPath = rootDirectory.FullName;
            }
            return string.Empty;
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

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.wordDocxRadioBtn = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
            this.wordDocRadioBtn = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wordDocxRadioBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wordDocRadioBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218)))));
            this.button1.BeforeTouchSize = new System.Drawing.Size(108, 23);
            this.button1.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.Dashed;
            this.button1.ComboEditBackColor = System.Drawing.Color.Silver;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.IsBackStageButton = false;
            this.button1.KeepFocusRectangle = false;
            this.button1.Location = new System.Drawing.Point(245, 153);
            this.button1.Name = "button1";
            this.button1.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Managed;
            this.button1.Size = new System.Drawing.Size(108, 23);
            this.button1.TabIndex = 26;
            this.button1.Text = "Generate";
            this.button1.UseVisualStyle = true;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(0, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(363, 50);
            this.label2.TabIndex = 75;
            this.label2.Text = "Click the button to view the generated Word document. Please note that Microsoft Word Viewer or Microsoft Word is required to view the resultant Word document.";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(365, 82);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 70;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.wordDocxRadioBtn);
            this.groupBox1.Controls.Add(this.wordDocRadioBtn);
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 138);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(209, 41);
            this.groupBox1.TabIndex = 101;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Save As";
            // 
            // worddocxRadioBtn
            // 
            this.wordDocxRadioBtn.BeforeTouchSize = new System.Drawing.Size(52, 20);
            this.wordDocxRadioBtn.Border3DStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.wordDocxRadioBtn.Checked = true;
            this.wordDocxRadioBtn.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wordDocxRadioBtn.GradientEnd = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.wordDocxRadioBtn.GradientStart = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.wordDocxRadioBtn.Location = new System.Drawing.Point(132, 18);
            this.wordDocxRadioBtn.MetroColor = System.Drawing.Color.Empty;
            this.wordDocxRadioBtn.Name = "wordDocxRadioBtn";
            this.wordDocxRadioBtn.Size = new System.Drawing.Size(52, 20);
            this.wordDocxRadioBtn.TabIndex = 103;
            this.wordDocxRadioBtn.Text = "DOCX";
            this.wordDocxRadioBtn.ThemesEnabled = true;
            // 
            // worddocRadioBtn
            // 
            this.wordDocRadioBtn.BeforeTouchSize = new System.Drawing.Size(49, 20);
            this.wordDocRadioBtn.Border3DStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.wordDocRadioBtn.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.wordDocRadioBtn.GradientEnd = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.wordDocRadioBtn.GradientStart = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.wordDocRadioBtn.Location = new System.Drawing.Point(17, 18);
            this.wordDocRadioBtn.MetroColor = System.Drawing.Color.Empty;
            this.wordDocRadioBtn.Name = "wordDocRadioBtn";
            this.wordDocRadioBtn.Size = new System.Drawing.Size(49, 20);
            this.wordDocRadioBtn.TabIndex = 44;
            this.wordDocRadioBtn.Text = "DOC";
            this.wordDocRadioBtn.ThemesEnabled = true;
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 15);
            this.BackColor = System.Drawing.Color.White;
            this.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218)))));
            this.ClientSize = new System.Drawing.Size(365, 191);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.DropShadow = true;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Document Settings";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.wordDocxRadioBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wordDocRadioBtn)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{	
            SyncfusionLicenseProvider.RegisterLicense(FindLicenseKey());
            Application.EnableVisualStyles();
			Application.Run(new Form1());			
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
            try
            {
                //A new document is created.
                WordDocument document = new WordDocument();

                //Adding a section to the document.
                IWSection section = document.AddSection();

                //Adding a paragraph to the section.			
                IWParagraph paragraph = section.AddParagraph();

                #region DocVariable
                string name = "John Smith";
                string address = "Cary, NC";
                //Get the variables in the existing document
                DocVariables dVariable = document.Variables;
                //Add doc variables
                dVariable.Add("Customer Name", name);
                dVariable.Add("Customer Address", address);
                #endregion DocVariable

                #region Document Properties
                //Setting document Properties
                document.BuiltinDocumentProperties.Author = "Essential DocIO";
                document.BuiltinDocumentProperties.ApplicationName = "Essential DocIO";
                document.BuiltinDocumentProperties.Category = "Document Generator";
                document.BuiltinDocumentProperties.Comments = "This document was generated using Essential DocIO";
                document.BuiltinDocumentProperties.Company = "Syncfusion Inc";
                document.BuiltinDocumentProperties.Subject = "Native Word Generator";
                document.BuiltinDocumentProperties.Keywords = "Syncfusion";
                document.BuiltinDocumentProperties.Manager = "Sync Manager";
                document.BuiltinDocumentProperties.Title = "Essential DocIO";

                // Add a custom document Property
                document.CustomDocumentProperties.Add("My_Doc_Date", DateTime.Today);
                document.CustomDocumentProperties.Add("My_Doc", true);
                document.CustomDocumentProperties.Add("My_ID", 1031);
                document.CustomDocumentProperties.Add("My_Comment", "Essential DocIO");
                //Remove a custome property
                document.CustomDocumentProperties.Remove("My_Doc");

                #endregion


                IWTextRange text = paragraph.AppendText("");
                text.CharacterFormat.FontName = "Calibri";
                text.CharacterFormat.FontSize = 13;
                text = paragraph.AppendText("This document is created with various Document Properties Summary Information and page settings information \n\n You can view Document Properties through: File -> Properties -> Summary/Custom.");
                text.CharacterFormat.FontName = "Calibri";
                text.CharacterFormat.FontSize = 13;


                #region Page setup

                // Write section properties
                section.PageSetup.PageSize = new SizeF(500, 750);
                section.PageSetup.Orientation = PageOrientation.Landscape;
                section.PageSetup.Margins.Bottom = 100;
                section.PageSetup.Margins.Top = 100;
                section.PageSetup.Margins.Left = 50;
                section.PageSetup.Margins.Right = 50;
                section.PageSetup.PageBordersApplyType = PageBordersApplyType.AllPages;
                section.PageSetup.Borders.BorderType = Syncfusion.DocIO.DLS.BorderStyle.DoubleWave;
                section.PageSetup.Borders.Color = Color.DarkBlue;
                section.PageSetup.VerticalAlignment = PageAlignment.Middle;

                #endregion

                paragraph = section.AddParagraph();
                text = paragraph.AppendText("");
                text.CharacterFormat.FontName = "Calibri";
                text.CharacterFormat.FontSize = 13;
                text = paragraph.AppendText("\n\n You can view Page setup options through File -> PageSetup.");
                text.CharacterFormat.FontName = "Calibri";
                text.CharacterFormat.FontSize = 13;

                #region Get document variables
                paragraph = document.LastSection.AddParagraph();
                dVariable = document.Variables;
                text = paragraph.AppendText("\n\n Document Variables\n");
                text.CharacterFormat.FontName = "Calibri";
                text.CharacterFormat.FontSize = 13;
                text.CharacterFormat.Bold = true;
                text = paragraph.AppendText("\n" + dVariable.GetNameByIndex(1) + ": " + dVariable.GetValueByIndex(1));
                text.CharacterFormat.FontName = "Calibri";
                text.CharacterFormat.FontSize = 13;
                //Display the current variable count
                text = paragraph.AppendText("\n\nDocument Variables Count: " + dVariable.Count);
                text.CharacterFormat.FontName = "Calibri";
                text.CharacterFormat.FontSize = 13;

                #endregion Get document variables

                //Save as doc format
                if (wordDocRadioBtn.Checked)
                {
                    //Saving the document to disk.
                    document.Save("Sample.doc");

                    //Message box confirmation to view the created document.
                    if (MessageBoxAdv.Show("Do you want to view the generated Word document?", "Document has been created", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        //Launching the MS Word file using the default Application.[MS Word Or Free WordViewer]
                        System.Diagnostics.Process.Start("Sample.doc");
                        //Exit
                        this.Close();
                    }
                }
                //Save as docx format
                else if (wordDocxRadioBtn.Checked)
                {
                    //Saving the document as .docx
                    document.Save("Sample.docx", FormatType.Docx);
                    //Message box confirmation to view the created document.
                    if (MessageBoxAdv.Show("Do you want to view the generated Word document?", "Document has been created", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        try
                        {
                            //Launching the MS Word file using the default Application.[MS Word Or Free WordViewer]
                            System.Diagnostics.Process.Start("Sample.docx");
                            //Exit
                            this.Close();
                        }
                        catch (Win32Exception ex)
                        {
                            MessageBoxAdv.Show("Microsoft Word Viewer or Microsoft Word is not installed in this system");
                            Console.WriteLine(ex.ToString());
                        }
                    }
                }
                else
                {
                    // Exit
                    this.Close();
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }

         }

	}
}

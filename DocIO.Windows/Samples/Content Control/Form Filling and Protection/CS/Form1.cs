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

    public class Form1 : MetroForm
    {
        #region Private Members

        private ToolTip toolTip1;
        private ButtonAdv buttonAdv1;
        private PictureBox pictureBox1;
        private Label label2;
        private IContainer components;

        #endregion

        #region Constructor, Main and Dispose
        public Form1()
        {
            //
            // Required for Windows Form Designer support
            //			
            InitializeComponent();
            Application.EnableVisualStyles();
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
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
		    SyncfusionLicenseProvider.RegisterLicense(FindLicenseKey());
            Application.Run(new Form1());
        }
        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
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
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.buttonAdv1 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAdv1
            // 
            this.buttonAdv1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAdv1.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.buttonAdv1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218)))));
            this.buttonAdv1.BeforeTouchSize = new System.Drawing.Size(173, 33);
            this.buttonAdv1.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.Dashed;
            this.buttonAdv1.ComboEditBackColor = System.Drawing.Color.Silver;
            this.buttonAdv1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdv1.ForeColor = System.Drawing.Color.White;
            this.buttonAdv1.IsBackStageButton = false;
            this.buttonAdv1.KeepFocusRectangle = false;
            this.buttonAdv1.Location = new System.Drawing.Point(287, 213);
            this.buttonAdv1.Name = "buttonAdv1";
            this.buttonAdv1.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Managed;
            this.buttonAdv1.Size = new System.Drawing.Size(173, 33);
            this.buttonAdv1.TabIndex = 62;
            this.buttonAdv1.Text = "Generate";
            this.buttonAdv1.UseVisualStyle = true;
            this.buttonAdv1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(486, 120);
            this.pictureBox1.TabIndex = 60;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(0, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(498, 72);
            this.label2.TabIndex = 68;
            this.label2.Text = "Click the button to view the generated Word document. Please note that Microsoft " +
    "Word Viewer or Microsoft Word is required to view the resultant Word document.";
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(8, 22);
            this.BackColor = System.Drawing.Color.White;
            this.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218)))));
            this.ClientSize = new System.Drawing.Size(486, 282);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonAdv1);
            this.Controls.Add(this.pictureBox1);
            this.DropShadow = true;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form Filling and Protection";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion

        #region Button_Click Event
        private void button1_Click(object sender, System.EventArgs e)
        {
            try
            {
                // Get Template document and database path.
                string dataPath = Application.StartupPath + @"\..\..\..\..\..\..\..\Common\Data\DocIO\";
                //Creates an empty Word document instance.
                WordDocument document = new WordDocument();

                //Opens template document.
                document.Open(System.IO.Path.Combine(dataPath, "ContentControlTemplate.docx"));

                IWTextRange textRange;
				//Gets table from the template document.
				IWTable table = document.LastSection.Tables[0];
				WTableRow row = table.Rows[1];
	
				#region Inserting content controls
	
				#region Calendar content control
				IWParagraph cellPara = row.Cells[0].Paragraphs[0];
				//Accesses the date picker content control.
				IInlineContentControl inlineControl = (cellPara.ChildEntities[2] as IInlineContentControl);
				textRange = inlineControl.ParagraphItems[0] as WTextRange;
				//Sets today's date to display.
				textRange.Text = DateTime.Now.ToShortDateString();
				textRange.CharacterFormat.FontSize = 14;
				//Protects the content control.
				inlineControl.ContentControlProperties.LockContents = true;
				#endregion
	
				#region Plain text content controls
				table = document.LastSection.Tables[1];
				row = table.Rows[0];
				cellPara = row.Cells[0].LastParagraph;
				//Accesses the plain text content control.
				inlineControl = (cellPara.ChildEntities[1] as IInlineContentControl);
				//Protects the content control.
				inlineControl.ContentControlProperties.LockContents = true;
				textRange = inlineControl.ParagraphItems[0] as WTextRange;
				//Sets text in plain text content control.
				textRange.Text = "Northwind Analytics";
				textRange.CharacterFormat.FontSize = 14;
	
				cellPara = row.Cells[1].LastParagraph;
				//Accesses the plain text content control.
				inlineControl = (cellPara.ChildEntities[1] as IInlineContentControl);
				//Protects the content control.
				inlineControl.ContentControlProperties.LockContents = true;
				textRange = inlineControl.ParagraphItems[0] as WTextRange;
				//Sets text in plain text content control.
				textRange.Text = "Northwind";
				textRange.CharacterFormat.FontSize = 14;
	
				row = table.Rows[1];
				cellPara = row.Cells[0].LastParagraph;
				//Accesses the plain text content control.
				inlineControl = (cellPara.ChildEntities[1] as IInlineContentControl);
				//Protects the content control.
				inlineControl.ContentControlProperties.LockContents = true;
				//Sets text in plain text content control.
				textRange = inlineControl.ParagraphItems[0] as WTextRange;
				textRange.Text = "10";
				textRange.CharacterFormat.FontSize = 14;
	
	
				cellPara = row.Cells[1].LastParagraph;
				//Accesses the plain text content control.
				inlineControl = (cellPara.ChildEntities[1] as IInlineContentControl);
				//Protects the content control.
				inlineControl.ContentControlProperties.LockContents = true;
				//Sets text in plain text content control.
				textRange = inlineControl.ParagraphItems[0] as WTextRange;
				textRange.Text = "Nancy Davolio";
				textRange.CharacterFormat.FontSize = 14;
				#endregion
	
				#region CheckBox Content control
				row = table.Rows[2];
				cellPara = row.Cells[0].LastParagraph;
				//Inserts checkbox content control.
				inlineControl = cellPara.AppendInlineContentControl(ContentControlType.CheckBox);
				inlineControl.ContentControlProperties.LockContents = true;
				//Sets checkbox as checked state.
				inlineControl.ContentControlProperties.IsChecked = true;
				textRange = cellPara.AppendText("C#, ");
				textRange.CharacterFormat.FontSize = 14;
	
				//Inserts checkbox content control.
				inlineControl = cellPara.AppendInlineContentControl(ContentControlType.CheckBox);
				inlineControl.ContentControlProperties.LockContents = true;
				//Sets checkbox as checked state.
				inlineControl.ContentControlProperties.IsChecked = true;
				textRange = cellPara.AppendText("VB");
				textRange.CharacterFormat.FontSize = 14;
				#endregion
	
	
				#region Drop down list content control
				cellPara = row.Cells[1].LastParagraph;
				//Accesses the dropdown list content control.
				inlineControl = (cellPara.ChildEntities[1] as IInlineContentControl);
				inlineControl.ContentControlProperties.LockContents = true;
				//Sets default option to display.
				textRange = inlineControl.ParagraphItems[0] as WTextRange;
				textRange.Text = "ASP.NET";
				textRange.CharacterFormat.FontSize = 14;
				inlineControl.ParagraphItems.Add(textRange);
	
				//Adds items to the dropdown list.
				ContentControlListItem item;
				item = new ContentControlListItem();
				item.DisplayText = "ASP.NET MVC";
				item.Value = "2";
				inlineControl.ContentControlProperties.ContentControlListItems.Add(item);
	
				item = new ContentControlListItem();
				item.DisplayText = "Windows Forms";
				item.Value = "3";
				inlineControl.ContentControlProperties.ContentControlListItems.Add(item);
	
				item = new ContentControlListItem();
				item.DisplayText = "WPF";
				item.Value = "4";
				inlineControl.ContentControlProperties.ContentControlListItems.Add(item);
	
				item = new ContentControlListItem();
				item.DisplayText = "Xamarin";
				item.Value = "5";
				inlineControl.ContentControlProperties.ContentControlListItems.Add(item);
				#endregion
	
				#region Calendar content control
				row = table.Rows[3];
				cellPara = row.Cells[0].LastParagraph;
				//Accesses the date picker content control.
				inlineControl = (cellPara.ChildEntities[1] as IInlineContentControl);
				inlineControl.ContentControlProperties.LockContents = true;
				//Sets default date to display.
				textRange = inlineControl.ParagraphItems[0] as WTextRange;
				textRange.Text = DateTime.Now.AddDays(-5).ToShortDateString();
				textRange.CharacterFormat.FontSize = 14;
	
				cellPara = row.Cells[1].LastParagraph;
				//Inserts date picker content control.
				inlineControl = (cellPara.ChildEntities[1] as IInlineContentControl);
				inlineControl.ContentControlProperties.LockContents = true;
				//Sets default date to display.
				textRange = inlineControl.ParagraphItems[0] as WTextRange;
				textRange.Text = DateTime.Now.AddDays(10).ToShortDateString();
				textRange.CharacterFormat.FontSize = 14;
				#endregion
	
				#endregion
				#region Block content control
				//Accesses the block content control.
				BlockContentControl blockContentControl = ((document.ChildEntities[0] as WSection).Body.ChildEntities[2] as BlockContentControl);
				//Protects the block content control
				blockContentControl.ContentControlProperties.LockContents = true;
				#endregion

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

                // Exit
                this.Close();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }
        #endregion

    }
}


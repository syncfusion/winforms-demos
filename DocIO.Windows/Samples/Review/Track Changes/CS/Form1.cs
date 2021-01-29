#region Copyright Syncfusion Inc. 2001 - 2021
//
//  Copyright Syncfusion Inc. 2001 - 2021. All rights reserved.
//
//  Use of this code is subject to the terms of our license.
//  A copy of the current license can be obtained at any time by e-mailing
//  licensing@syncfusion.com. Any infringement will be prosecuted under
//  applicable laws. 
//
#endregion

using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.IO;

using Syncfusion.DocIO;
using Syncfusion.DocIO.DLS;
using Syncfusion.Windows.Forms;
using Syncfusion.Windows.Forms.Tools;
using Syncfusion.Licensing;
using System.Reflection;
using System.Text;
using System.Diagnostics;

namespace EssentialDocIOSamples
{
    /// <summary>
    /// Summary description for Form1.
    /// </summary>
    public class Form1 : MetroForm
    {
        private ButtonAdv button1;
        private Label label2;
        private ToolTip toolTip1;
        private PictureBox pictureBox1;
        private OpenFileDialog openFileDialog1;
        private GroupBox groupBox2;
        private RadioButtonAdv radioButtonReject;
        private RadioButtonAdv radioButtonAccept;
        private ComboBox comboBoxAuthorName;
        private Label label8;
        private RadioButtonAdv radioButtonAcceptAll;
        private RadioButtonAdv radioButtonRejectAll;
        private ButtonAdv buttonAdv1;
        private IContainer components;

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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButtonAcceptAll = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
            this.radioButtonRejectAll = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
            this.comboBoxAuthorName = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.radioButtonReject = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
            this.radioButtonAccept = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
            this.buttonAdv1 = new Syncfusion.Windows.Forms.ButtonAdv();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radioButtonAcceptAll)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioButtonRejectAll)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioButtonReject)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioButtonAccept)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218)))));
            this.button1.BeforeTouchSize = new System.Drawing.Size(228, 34);
            this.button1.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.Dashed;
            this.button1.ComboEditBackColor = System.Drawing.Color.Silver;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.KeepFocusRectangle = false;
            this.button1.Location = new System.Drawing.Point(363, 470);
            this.button1.Name = "button1";
            this.button1.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Managed;
            this.button1.Size = new System.Drawing.Size(228, 34);
            this.button1.TabIndex = 26;
            this.button1.Text = "Generate";
            this.button1.ThemeName = "Metro";
            this.button1.UseVisualStyle = true;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(0, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(577, 74);
            this.label2.TabIndex = 72;
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(617, 120);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 70;
            this.pictureBox1.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButtonAcceptAll);
            this.groupBox2.Controls.Add(this.radioButtonRejectAll);
            this.groupBox2.Controls.Add(this.comboBoxAuthorName);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.radioButtonReject);
            this.groupBox2.Controls.Add(this.radioButtonAccept);
            this.groupBox2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(5, 213);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(612, 231);
            this.groupBox2.TabIndex = 120;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Track Changes Options";
            // 
            // radioButtonAcceptAll
            // 
            this.radioButtonAcceptAll.BeforeTouchSize = new System.Drawing.Size(583, 29);
            this.radioButtonAcceptAll.Border3DStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.radioButtonAcceptAll.Checked = true;
            this.radioButtonAcceptAll.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.radioButtonAcceptAll.ForeColor = System.Drawing.SystemColors.ControlText;
            this.radioButtonAcceptAll.GradientEnd = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.radioButtonAcceptAll.GradientStart = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.radioButtonAcceptAll.ImageCheckBoxSize = new System.Drawing.Size(19, 19);
            this.radioButtonAcceptAll.Location = new System.Drawing.Point(19, 151);
            this.radioButtonAcceptAll.MetroColor = System.Drawing.Color.Empty;
            this.radioButtonAcceptAll.Name = "radioButtonAcceptAll";
            this.radioButtonAcceptAll.Size = new System.Drawing.Size(583, 29);
            this.radioButtonAcceptAll.TabIndex = 90;
            this.radioButtonAcceptAll.Text = "Accepts all the tracked changes in the Word document";
            this.radioButtonAcceptAll.ThemesEnabled = true;
            // 
            // radioButtonRejectAll
            // 
            this.radioButtonRejectAll.BeforeTouchSize = new System.Drawing.Size(583, 29);
            this.radioButtonRejectAll.Border3DStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.radioButtonRejectAll.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.radioButtonRejectAll.ForeColor = System.Drawing.SystemColors.ControlText;
            this.radioButtonRejectAll.GradientEnd = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.radioButtonRejectAll.GradientStart = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.radioButtonRejectAll.ImageCheckBoxSize = new System.Drawing.Size(19, 19);
            this.radioButtonRejectAll.Location = new System.Drawing.Point(19, 190);
            this.radioButtonRejectAll.MetroColor = System.Drawing.Color.Empty;
            this.radioButtonRejectAll.Name = "radioButtonRejectAll";
            this.radioButtonRejectAll.Size = new System.Drawing.Size(583, 29);
            this.radioButtonRejectAll.TabIndex = 89;
            this.radioButtonRejectAll.TabStop = false;
            this.radioButtonRejectAll.Text = "Rejects all the tracked changes in the Word document";
            this.radioButtonRejectAll.ThemesEnabled = true;
            // 
            // comboBoxAuthorName
            // 
            this.comboBoxAuthorName.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxAuthorName.FormattingEnabled = true;
            this.comboBoxAuthorName.Items.AddRange(new object[] {
            "All",
            "Nancy Davolio",
            "Steven Buchanan",
            "Stanley Hudson",
            "Andrew Fuller"});
            this.comboBoxAuthorName.Location = new System.Drawing.Point(152, 34);
            this.comboBoxAuthorName.Name = "comboBoxAuthorName";
            this.comboBoxAuthorName.Size = new System.Drawing.Size(258, 28);
            this.comboBoxAuthorName.TabIndex = 88;
            this.comboBoxAuthorName.SelectedIndexChanged += new System.EventHandler(this.ComboBoxSelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.label8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label8.Location = new System.Drawing.Point(15, 34);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(131, 20);
            this.label8.TabIndex = 87;
            this.label8.Text = "Author Name:";
            // 
            // radioButtonReject
            // 
            this.radioButtonReject.BeforeTouchSize = new System.Drawing.Size(391, 28);
            this.radioButtonReject.Border3DStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.radioButtonReject.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.radioButtonReject.ForeColor = System.Drawing.SystemColors.ControlText;
            this.radioButtonReject.GradientEnd = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.radioButtonReject.GradientStart = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.radioButtonReject.ImageCheckBoxSize = new System.Drawing.Size(19, 19);
            this.radioButtonReject.Location = new System.Drawing.Point(19, 112);
            this.radioButtonReject.MetroColor = System.Drawing.Color.Empty;
            this.radioButtonReject.Name = "radioButtonReject";
            this.radioButtonReject.Size = new System.Drawing.Size(391, 28);
            this.radioButtonReject.TabIndex = 85;
            this.radioButtonReject.TabStop = false;
            this.radioButtonReject.Text = "Rejects all changes made by the author";
            this.radioButtonReject.ThemesEnabled = true;
            // 
            // radioButtonAccept
            // 
            this.radioButtonAccept.BeforeTouchSize = new System.Drawing.Size(409, 29);
            this.radioButtonAccept.Border3DStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.radioButtonAccept.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.radioButtonAccept.ForeColor = System.Drawing.SystemColors.ControlText;
            this.radioButtonAccept.GradientEnd = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.radioButtonAccept.GradientStart = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.radioButtonAccept.ImageCheckBoxSize = new System.Drawing.Size(19, 19);
            this.radioButtonAccept.Location = new System.Drawing.Point(19, 73);
            this.radioButtonAccept.MetroColor = System.Drawing.Color.Empty;
            this.radioButtonAccept.Name = "radioButtonAccept";
            this.radioButtonAccept.Size = new System.Drawing.Size(409, 29);
            this.radioButtonAccept.TabIndex = 84;
            this.radioButtonAccept.TabStop = false;
            this.radioButtonAccept.Text = "Accepts all changes made by the author";
            this.radioButtonAccept.ThemesEnabled = true;
            // 
            // buttonAdv1
            // 
            this.buttonAdv1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAdv1.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.buttonAdv1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218)))));
            this.buttonAdv1.BeforeTouchSize = new System.Drawing.Size(173, 34);
            this.buttonAdv1.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.Dashed;
            this.buttonAdv1.ComboEditBackColor = System.Drawing.Color.Silver;
            this.buttonAdv1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdv1.ForeColor = System.Drawing.Color.White;
            this.buttonAdv1.KeepFocusRectangle = false;
            this.buttonAdv1.Location = new System.Drawing.Point(24, 470);
            this.buttonAdv1.Name = "buttonAdv1";
            this.buttonAdv1.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Managed;
            this.buttonAdv1.Size = new System.Drawing.Size(173, 34);
            this.buttonAdv1.TabIndex = 121;
            this.buttonAdv1.Text = "View Template";
            this.buttonAdv1.ThemeName = "Metro";
            this.buttonAdv1.UseVisualStyle = true;
            this.buttonAdv1.UseVisualStyleBackColor = false;
            this.buttonAdv1.Click += new System.EventHandler(this.buttonAdv1_Click);
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(8, 22);
            this.BackColor = System.Drawing.Color.White;
            this.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218)))));
            this.ClientSize = new System.Drawing.Size(617, 529);
            this.Controls.Add(this.buttonAdv1);
            this.Controls.Add(this.groupBox2);
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
            this.Text = "Track Changes";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radioButtonAcceptAll)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioButtonRejectAll)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioButtonReject)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioButtonAccept)).EndInit();
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
                //Get Template document and database path.
                string dataPath = Application.StartupPath + @"..\..\..\..\..\..\..\..\Common\Data\DocIO\";

                //Loads the template document.
                WordDocument document = new WordDocument(Path.Combine(dataPath, "TrackChangesTemplate.docx"));
                string author = GetAuthorName(comboBoxAuthorName.SelectedIndex);
                //Accepts the all changes made by the author
                if (radioButtonAccept.Checked)
                    AcceptRevisionsOfAuthor(document, author);
                //Rejects the all the changes made by the author
                else if (radioButtonReject.Checked)
                    RejectRevisionsOfAuthor(document, author);
                //Rejects all the tracked changes revisions in the Word document
                else if (radioButtonRejectAll.Checked)
                    document.Revisions.RejectAll();
                //Accepts all the tracked changes revisions in the Word document
                else
                    document.Revisions.AcceptAll();

                //Saves and closes the Word document 
                document.Save("Track Changes.docx", FormatType.Docx);
                document.Close();
                //Message box confirmation to view the created document.
                if (MessageBoxAdv.Show("Do you want to view the generated Word document?", "Document has been created", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    try
                    {

                        //Launching the MS Word file using the default Application.[MS Word Or Free WordViewer]
#if NETCORE
                        System.Diagnostics.Process process = new System.Diagnostics.Process();
                        process.StartInfo = new System.Diagnostics.ProcessStartInfo("Track Changes.docx") { UseShellExecute = true };
                        process.Start();
#else
                        System.Diagnostics.Process.Start("Track Changes.docx");
#endif
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
        #region Helper Methods
        /// <summary>
        ///  Rejects the all changes made by the author
        /// </summary>
        private void RejectRevisionsOfAuthor(WordDocument document, string author)
        {
            //Iterate into all the revisions in Word document
            for (int i = document.Revisions.Count - 1; i >= 0; i--)
            {
                //Checks the author of current revision and rejects it.
                if (document.Revisions[i].Author == author)
                    document.Revisions[i].Reject();

                //Reset to last item when reject the moving related revisions.
                if (i > document.Revisions.Count - 1)
                    i = document.Revisions.Count;
            }
        }
        /// <summary>
        ///  Accepts the all changes made by the author
        /// </summary>
        private void AcceptRevisionsOfAuthor(WordDocument document, string author)
        {
            //Iterate into all the revisions in Word document
            for (int i = document.Revisions.Count - 1; i >= 0; i--)
            {
                //Checks the author of current revision and rejects it.
                if (document.Revisions[i].Author == author)
                    document.Revisions[i].Accept();

                //Reset to last item when accept the moving related revisions.
                if (i > document.Revisions.Count - 1)
                    i = document.Revisions.Count;
            }
        }
        /// <summary>
        /// Gets the author name
        /// </summary>
        private string GetAuthorName(int selectedIndex)
        {
            switch (selectedIndex)
            {
                case 1:
                    return "Nancy Davolio";
                case 2:
                    return "Steven Buchanan";
                case 3:
                    return "Stanley Hudson";
                case 4:
                    return "Andrew Fuller";
            }
            return string.Empty;
        }
        #endregion
   
             
        private void Form1_Load(object sender, EventArgs e)
        {
            this.comboBoxAuthorName.SelectedIndex = 0;            
        }
       

        /// <summary>
        /// The source template document.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAdv1_Click(object sender, EventArgs e)
        {
#if NETCORE
			System.Diagnostics.Process process = new System.Diagnostics.Process();
			process.StartInfo = new System.Diagnostics.ProcessStartInfo(Application.StartupPath + @"..\..\..\..\..\..\..\..\Common\Data\DocIO\TrackChangesTemplate.docx") { UseShellExecute = true };
			process.Start();
#else
            Process.Start(Application.StartupPath + @"\..\..\..\..\..\..\..\Common\Data\DocIO\TrackChangesTemplate.docx");
#endif
        }

        private void ComboBoxSelectedIndexChanged(object sender, EventArgs e)
        {
			//If All author selected disable the radio button otherwise enabled
            if (comboBoxAuthorName.SelectedIndex != 0)
            {
                radioButtonAccept.Checked = true;
                radioButtonAccept.Enabled = true;
                radioButtonReject.Enabled = true;
            }
            else
            {
                radioButtonAcceptAll.Checked = true;
                radioButtonAccept.Enabled = false;
                radioButtonReject.Enabled = false;
            }
        }
    }
}

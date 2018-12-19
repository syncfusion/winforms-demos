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
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Diagnostics;

using Syncfusion.DocIO;
using Syncfusion.DocIO.DLS;
using Syncfusion.Windows.Forms;
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
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.templateBtn = new Syncfusion.Windows.Forms.ButtonAdv();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.button1.Location = new System.Drawing.Point(210, 151);
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
            this.label2.Size = new System.Drawing.Size(363, 51);
            this.label2.TabIndex = 74;
            this.label2.Text = "Click the button to view the generated Word document. Please note that Microsoft Word Viewer or Microsoft Word is required to view the resultant Word document.";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(372, 85);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 70;
            this.pictureBox1.TabStop = false;
            // 
            // templateBtn
            // 
            this.templateBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.templateBtn.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.templateBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218)))));
            this.templateBtn.BeforeTouchSize = new System.Drawing.Size(108, 23);
            this.templateBtn.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.Dashed;
            this.templateBtn.ComboEditBackColor = System.Drawing.Color.Silver;
            this.templateBtn.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.templateBtn.ForeColor = System.Drawing.Color.White;
            this.templateBtn.IsBackStageButton = false;
            this.templateBtn.KeepFocusRectangle = false;
            this.templateBtn.Location = new System.Drawing.Point(58, 151);
            this.templateBtn.Name = "templateBtn";
            this.templateBtn.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Managed;
            this.templateBtn.Size = new System.Drawing.Size(108, 23);
            this.templateBtn.TabIndex = 101;
            this.templateBtn.Text = "View Template";
            this.templateBtn.UseVisualStyle = true;
            this.templateBtn.UseVisualStyleBackColor = false;
            this.templateBtn.Click += new System.EventHandler(this.templateBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 15);
            this.BackColor = System.Drawing.Color.White;
            this.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218)))));
            this.ClientSize = new System.Drawing.Size(372, 188);
            this.Controls.Add(this.templateBtn);
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
            this.Text = "Macro Preservation";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        // Create a DataSet.
        DataSet ds = new DataSet();
        private ButtonAdv button1;
        private Label label2;
        private ToolTip toolTip1;
        private PictureBox pictureBox1;
        private ButtonAdv templateBtn;

        private void button1_Click(object sender, System.EventArgs e)
        {
            try
            {
                // Load the macro-enabled template.
                WordDocument document = new WordDocument(@"..\..\..\..\..\..\..\Common\Data\DocIO\MacroTemplate.dotm");

                // Get the tables from Data Set.
                GetDataTable();

                // Execute Mail Merge with groups.
                document.MailMerge.ExecuteGroup(ds.Tables["Products"]);

                ds = null;
                ds = new DataSet();

                //Saving the document as .docm
                document.Save("Sample.docm", FormatType.Word2013Docm);
                //Message box confirmation to view the created document.
                if (MessageBoxAdv.Show("Do you want to view the generated Word document?", "Document has been created", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    try
                    {
                        //Launching the MS Word file using the default Application.[MS Word Or Free WordViewer]
                        System.Diagnostics.Process.Start("Sample.docm");
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

            catch (Exception Ex)
            {
                MessageBoxAdv.Show(Ex.Message + "\n\n\n" + Ex.StackTrace);
            }

        }

        private void GetDataTable()
        {
            // List of syncfusion products name.
            string[] products = { "DocIO", "PDF", "XlsIO"};

            // Add new Tables to the data set.
            DataRow row;
            ds.Tables.Add();

            // Add fields to the Products table.
            ds.Tables[0].TableName = "Products";
            ds.Tables[0].Columns.Add("ProductName");
            ds.Tables[0].Columns.Add("Binary");
            ds.Tables[0].Columns.Add("Source");

            // Inserting values to the tables.
            foreach (string product in products)
            {
                row = ds.Tables["Products"].NewRow();
                row["ProductName"] = string.Concat("Essential ", product);
                row["Binary"] = "$895.00";
                row["Source"] = "$1,295.00";
                ds.Tables["Products"].Rows.Add(row);
            }
        }

        /// <summary>
        /// The source template document.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void templateBtn_Click(object sender, EventArgs e)
        {
            Process.Start(@"..\..\..\..\..\..\..\Common\Data\DocIO\MacroTemplate.dotm");
        }

    }
}

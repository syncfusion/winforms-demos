#region Copyright Syncfusion Inc. 2001 - 2008
//
//  Copyright Syncfusion Inc. 2001 - 2008. All rights reserved.
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
using Syncfusion.XlsIO;
using Syncfusion.Windows.Forms;
using Syncfusion.Licensing;
using System.IO;
namespace EssentialXlsIOSamples
{
    /// <summary>
    /// Summary description for EncryptionDecryption.
    /// </summary>
    public class EncryptionDecryption : MetroForm
    {
        #region Constants
        private const string DEFAULTPATH = @"..\..\..\..\..\..\..\Common\Data\XlsIO\{0}";
        #endregion

        # region Fields
        private System.Windows.Forms.Button btnEncryption;
        private System.Windows.Forms.Label label1;
        private GroupBox groupBox1;
        private PictureBox pictureBox1;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox txtEnOpen;
        private Label label5;
        private Button btnEncryptSource;
        private TextBox txtEncryptSource;
        private Label label7;
        private Button btnDecryption;
        private GroupBox groupBox2;
        private Button btnDecryptSource;
        private TextBox txtDecryptSource;
        private Label label8;
        private TextBox txtDeOpen;
        private Label label10;
        private Label label11;
        private Label label12;
        private OpenFileDialog openFileDialog1;
        private Label label9;
        private ToolTip toolTip1;
        private Label label13;
        private GroupBox groupBox3;
        private RadioButton rdbExcel2010Encrypt;
        private RadioButton rdbExcel2007Encrypt;
        private GroupBox groupBox4;
        private RadioButton rdbExcel2010Decrypt;
        private RadioButton rdbExcel2007Decrypt;
        private RadioButton rdbExcel2013Encrypt;
        private RadioButton rdbExcel2013Decrypt;
        private IContainer components;

        # endregion

        # region Initialize


        public EncryptionDecryption()
        {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();
            string imageFile = @"..\..\..\..\..\..\..\Common\Images\XlsIO\";
            this.label9.Image = Image.FromFile(imageFile + "label8_Image.gif");
            this.label13.Image = Image.FromFile(imageFile + "label8_Image.gif");
            this.label2.Image = Image.FromFile(imageFile + "label_Image.gif");
            this.label12.Image = Image.FromFile(imageFile + "label_Image.gif");
            //
            // TODO: Add any constructor code after InitializeComponent call
            //
        }
        #endregion

        # region Encryption and Decryption

        # region Process Spreadsheet

        #region Encrypt the Spreadsheet
        /// <summary>
        /// Encrypt the selected spreadsheet
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEncryption_Click(object sender, System.EventArgs e)
        {
            //Checking for Source Document
            if (this.txtEncryptSource.Text == null || this.txtEncryptSource.Text.Length == 0)
            {
                MessageBox.Show("Please select workbook", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //Checking for Password
            if (this.txtEnOpen.Text == null || this.txtEnOpen.Text.Length == 0)
            {
                MessageBox.Show("Please use Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                #region Initialize Workbook
                //New instance of XlsIO is created.[Equivalent to launching MS Excel with no workbooks open].
                //The instantiation process consists of two steps.

                //Step 1 : Instantiate the spreadsheet creation engine.
                ExcelEngine excelEngine = new ExcelEngine();

                //Step 2 : Instantiate the excel application object.
                IApplication application = excelEngine.Excel;
                //Set the Default Version to the application
                if (this.rdbExcel2007Encrypt.Checked)
                    application.DefaultVersion = ExcelVersion.Excel2007;
                else if (this.rdbExcel2010Encrypt.Checked)
                    application.DefaultVersion = ExcelVersion.Excel2010;
                else if (this.rdbExcel2013Encrypt.Checked)
                    application.DefaultVersion = ExcelVersion.Excel2013;
                // Opening the Existing Worksheet from a Workbook.
                IWorkbook workbook = application.Workbooks.Open(this.txtEncryptSource.Text);
                #endregion

                //Encrypt the workbook with password.
                workbook.PasswordToOpen = this.txtEnOpen.Text;

                #region Save the Workbook
                //Save the workbook to disk.
                workbook.SaveAs("EncryptedWorkbook.xlsx");
                #endregion

                #region Workbook Close and Dispose
                //Close the workbook.
                workbook.Close();
                excelEngine.Dispose();
                #endregion

                #region View the Workbook
                //Message box confirmation to view the created spreadsheet.
                if (MessageBox.Show("Document is encrypted. Do you want to view the encrypted workbook?", "Workbook has been created",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Information)
                    == DialogResult.Yes)
                {
                    //Launching the Excel file using the default Application.[MS Excel Or Free ExcelViewer]
                    System.Diagnostics.Process.Start("EncryptedWorkbook.xlsx");
                }

                //Reset the controls of successful creation of spreadsheet.
                this.txtEncryptSource.Text = String.Empty;
                this.txtEnOpen.Text = String.Empty;
                #endregion
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
        #endregion

        #region Decrypt the Spreadsheet
        /// <summary>
        /// Decrypt the selected spreadsheet
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDecryption_Click(object sender, System.EventArgs e)
        {
            if (this.txtDecryptSource.Text == null || this.txtDecryptSource.Text.Length == 0)
            {
                MessageBox.Show("Please select workbook", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                #region Initialize Workbook
                //New instance of XlsIO is created.[Equivalent to launching MS Excel with no workbooks open].
                //The instantiation process consists of two steps.

                //Step 1 : Instantiate the spreadsheet creation engine.
                ExcelEngine excelEngine = new ExcelEngine();

                //Step 2 : Instantiate the excel application object.
                IApplication application = excelEngine.Excel;

                //Set the Default Version to the application
                if (this.rdbExcel2007Decrypt.Checked)
                    application.DefaultVersion = ExcelVersion.Excel2007;
                else if (this.rdbExcel2010Decrypt.Checked)
                    application.DefaultVersion = ExcelVersion.Excel2010;
                else if (this.rdbExcel2013Decrypt.Checked)
                    application.DefaultVersion = ExcelVersion.Excel2013;

                // Opening the encrypted Workbook.
                IWorkbook workbook = application.Workbooks.Open(this.txtDecryptSource.Text, ExcelParseOptions.Default, true, this.txtDeOpen.Text);
                #endregion

                #region Save the Workbook
                //Modify the decrypted document.
                workbook.Worksheets[0].Range["B2"].Text = "Demo for workbook decryption with Essential XlsIO";
                workbook.Worksheets[0].Range["B5"].Text = "This document is decrypted using password " + this.txtDeOpen.Text;

                //Save the workbook to disk.
                workbook.SaveAs("DecryptedWorkbook.xlsx");
                #endregion

                #region Workbook Close and Dispose
                //Close the workbook.
                workbook.Close();
                excelEngine.Dispose();
                #endregion

                #region View the Workbook
                //Message box confirmation to view the created spreadsheet.
                if (MessageBox.Show("Document is decrypted and modified. Do you want to view the modified workbook?", "Workbook has been created",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Information)
                    == DialogResult.Yes)
                {
                    //Launching the Excel file using the default Application.[MS Excel Or Free ExcelViewer]
                    System.Diagnostics.Process.Start("DecryptedWorkbook.xlsx");
                }
                else
                {
                    // Exit
                    this.Close();
                }
                #endregion

                //Reset the controls of successful creation of spreadsheet.
                this.txtDecryptSource.Text = String.Empty;
                this.txtDeOpen.Text = String.Empty;
            }
            catch (System.ArgumentException)
            {
                MessageBox.Show("Password is wrong!!! Please re-enter correct password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
        # endregion

        # endregion

        # region Get Spreadsheet

        /// <summary>
        /// Gets the source spreadsheet to encrypt
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEncryptSource_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Excel 2007 Spreadsheets (*.xlsx)|*.xlsx";
            openFileDialog1.Title = "Choose a Spreadsheet to Encrypt";
            openFileDialog1.InitialDirectory = Application.StartupPath + DEFAULTPATH;
            openFileDialog1.FileName = "";
            openFileDialog1.RestoreDirectory = true;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                this.txtEncryptSource.Text = openFileDialog1.FileName;
                this.btnEncryption.Enabled = true;
            }
            else
                this.btnEncryption.Enabled = false;
        }

        /// <summary>
        /// Gets the source spreadsheet to decrypt
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDecryptSource_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Excel 2007 Spreadsheets (*.xlsx)|*.xlsx";
            openFileDialog1.Title = "Choose a Spreadsheet to Decrypt";
            openFileDialog1.InitialDirectory = Application.StartupPath + DEFAULTPATH;
            openFileDialog1.FileName = "";
            openFileDialog1.RestoreDirectory = true;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                this.txtDecryptSource.Text = openFileDialog1.FileName;
                this.btnDecryption.Enabled = true;
            }
            else
                this.btnDecryption.Enabled = false;
        }

        # endregion

        # endregion

        #region Windows Form Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EncryptionDecryption));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rdbExcel2013Encrypt = new System.Windows.Forms.RadioButton();
            this.rdbExcel2010Encrypt = new System.Windows.Forms.RadioButton();
            this.rdbExcel2007Encrypt = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.btnEncryptSource = new System.Windows.Forms.Button();
            this.txtEncryptSource = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtEnOpen = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEncryption = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rdbExcel2013Decrypt = new System.Windows.Forms.RadioButton();
            this.rdbExcel2010Decrypt = new System.Windows.Forms.RadioButton();
            this.rdbExcel2007Decrypt = new System.Windows.Forms.RadioButton();
            this.label13 = new System.Windows.Forms.Label();
            this.btnDecryptSource = new System.Windows.Forms.Button();
            this.txtDecryptSource = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnDecryption = new System.Windows.Forms.Button();
            this.txtDeOpen = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(372, 56);
            this.label1.TabIndex = 1;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.btnEncryptSource);
            this.groupBox1.Controls.Add(this.txtEncryptSource);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtEnOpen);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnEncryption);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.groupBox1.Location = new System.Drawing.Point(12, 137);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(348, 167);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "     Encrypt Spreadsheet";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rdbExcel2013Encrypt);
            this.groupBox3.Controls.Add(this.rdbExcel2010Encrypt);
            this.groupBox3.Controls.Add(this.rdbExcel2007Encrypt);
            this.groupBox3.Location = new System.Drawing.Point(8, 86);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(333, 41);
            this.groupBox3.TabIndex = 73;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Save As";
            // 
            // rdbExcel2013Encrypt
            // 
            this.rdbExcel2013Encrypt.AutoSize = true;
            this.rdbExcel2013Encrypt.Location = new System.Drawing.Point(222, 16);
            this.rdbExcel2013Encrypt.Name = "rdbExcel2013Encrypt";
            this.rdbExcel2013Encrypt.Size = new System.Drawing.Size(88, 17);
            this.rdbExcel2013Encrypt.TabIndex = 3;
            this.rdbExcel2013Encrypt.TabStop = true;
            this.rdbExcel2013Encrypt.Text = "Excel 2013";
            this.rdbExcel2013Encrypt.UseVisualStyleBackColor = true;
            // 
            // rdbExcel2010Encrypt
            // 
            this.rdbExcel2010Encrypt.AutoSize = true;
            this.rdbExcel2010Encrypt.Location = new System.Drawing.Point(122, 16);
            this.rdbExcel2010Encrypt.Name = "rdbExcel2010Encrypt";
            this.rdbExcel2010Encrypt.Size = new System.Drawing.Size(88, 17);
            this.rdbExcel2010Encrypt.TabIndex = 2;
            this.rdbExcel2010Encrypt.Text = "Excel 2010";
            this.rdbExcel2010Encrypt.UseVisualStyleBackColor = true;
            // 
            // rdbExcel2007Encrypt
            // 
            this.rdbExcel2007Encrypt.AutoSize = true;
            this.rdbExcel2007Encrypt.Checked = true;
            this.rdbExcel2007Encrypt.Location = new System.Drawing.Point(22, 16);
            this.rdbExcel2007Encrypt.Name = "rdbExcel2007Encrypt";
            this.rdbExcel2007Encrypt.Size = new System.Drawing.Size(88, 17);
            this.rdbExcel2007Encrypt.TabIndex = 1;
            this.rdbExcel2007Encrypt.TabStop = true;
            this.rdbExcel2007Encrypt.Text = "Excel 2007";
            this.rdbExcel2007Encrypt.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(322, 32);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(20, 16);
            this.label9.TabIndex = 9;
            this.toolTip1.SetToolTip(this.label9, "Browse a spreadsheet to encrypt and give password");
            // 
            // btnEncryptSource
            // 
            this.btnEncryptSource.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEncryptSource.BackColor = System.Drawing.Color.Transparent;
            this.btnEncryptSource.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEncryptSource.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnEncryptSource.Location = new System.Drawing.Point(299, 29);
            this.btnEncryptSource.Name = "btnEncryptSource";
            this.btnEncryptSource.Size = new System.Drawing.Size(24, 20);
            this.btnEncryptSource.TabIndex = 0;
            this.btnEncryptSource.Text = "...";
            this.btnEncryptSource.UseVisualStyleBackColor = false;
            this.btnEncryptSource.Click += new System.EventHandler(this.btnEncryptSource_Click);
            // 
            // txtEncryptSource
            // 
            this.txtEncryptSource.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEncryptSource.Location = new System.Drawing.Point(110, 29);
            this.txtEncryptSource.Name = "txtEncryptSource";
            this.txtEncryptSource.Size = new System.Drawing.Size(185, 20);
            this.txtEncryptSource.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(6, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Source Document";
            // 
            // txtEnOpen
            // 
            this.txtEnOpen.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEnOpen.Location = new System.Drawing.Point(110, 60);
            this.txtEnOpen.Name = "txtEnOpen";
            this.txtEnOpen.PasswordChar = '*';
            this.txtEnOpen.Size = new System.Drawing.Size(232, 20);
            this.txtEnOpen.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(6, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Password To Open";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.MidnightBlue;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Location = new System.Drawing.Point(29, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 1);
            this.label3.TabIndex = 2;
            this.label3.Text = "label3";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(9, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 17);
            this.label2.TabIndex = 1;
            // 
            // btnEncryption
            // 
            this.btnEncryption.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEncryption.BackColor = System.Drawing.Color.Transparent;
            this.btnEncryption.Enabled = false;
            this.btnEncryption.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEncryption.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnEncryption.Image = ((System.Drawing.Image)(resources.GetObject("btnEncryption.Image")));
            this.btnEncryption.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEncryption.Location = new System.Drawing.Point(258, 135);
            this.btnEncryption.Name = "btnEncryption";
            this.btnEncryption.Size = new System.Drawing.Size(85, 26);
            this.btnEncryption.TabIndex = 5;
            this.btnEncryption.Text = "Encrypt";
            this.btnEncryption.UseVisualStyleBackColor = false;
            this.btnEncryption.Click += new System.EventHandler(this.btnEncryption_Click);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(0, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(372, 48);
            this.label4.TabIndex = 63;
            this.label4.Text = "Click the button to view an Excel spreadsheet generated by Essential XlsIO. Pleas" +
    "e note that MS Excel Viewer or MS Excel is required to view the resultant docume" +
    "nt.";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.btnDecryptSource);
            this.groupBox2.Controls.Add(this.txtDecryptSource);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.btnDecryption);
            this.groupBox2.Controls.Add(this.txtDeOpen);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.groupBox2.Location = new System.Drawing.Point(12, 313);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(348, 167);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "     Decrypt Spreadsheet";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.rdbExcel2013Decrypt);
            this.groupBox4.Controls.Add(this.rdbExcel2010Decrypt);
            this.groupBox4.Controls.Add(this.rdbExcel2007Decrypt);
            this.groupBox4.Location = new System.Drawing.Point(8, 86);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(333, 41);
            this.groupBox4.TabIndex = 74;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Save As";
            // 
            // rdbExcel2013Decrypt
            // 
            this.rdbExcel2013Decrypt.AutoSize = true;
            this.rdbExcel2013Decrypt.Location = new System.Drawing.Point(222, 16);
            this.rdbExcel2013Decrypt.Name = "rdbExcel2013Decrypt";
            this.rdbExcel2013Decrypt.Size = new System.Drawing.Size(88, 17);
            this.rdbExcel2013Decrypt.TabIndex = 3;
            this.rdbExcel2013Decrypt.TabStop = true;
            this.rdbExcel2013Decrypt.Text = "Excel 2013";
            this.rdbExcel2013Decrypt.UseVisualStyleBackColor = true;
            // 
            // rdbExcel2010Decrypt
            // 
            this.rdbExcel2010Decrypt.AutoSize = true;
            this.rdbExcel2010Decrypt.Location = new System.Drawing.Point(122, 16);
            this.rdbExcel2010Decrypt.Name = "rdbExcel2010Decrypt";
            this.rdbExcel2010Decrypt.Size = new System.Drawing.Size(88, 17);
            this.rdbExcel2010Decrypt.TabIndex = 2;
            this.rdbExcel2010Decrypt.Text = "Excel 2010";
            this.rdbExcel2010Decrypt.UseVisualStyleBackColor = true;
            // 
            // rdbExcel2007Decrypt
            // 
            this.rdbExcel2007Decrypt.AutoSize = true;
            this.rdbExcel2007Decrypt.Checked = true;
            this.rdbExcel2007Decrypt.Location = new System.Drawing.Point(21, 16);
            this.rdbExcel2007Decrypt.Name = "rdbExcel2007Decrypt";
            this.rdbExcel2007Decrypt.Size = new System.Drawing.Size(88, 17);
            this.rdbExcel2007Decrypt.TabIndex = 1;
            this.rdbExcel2007Decrypt.TabStop = true;
            this.rdbExcel2007Decrypt.Text = "Excel 2007";
            this.rdbExcel2007Decrypt.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(322, 33);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(20, 16);
            this.label13.TabIndex = 10;
            this.toolTip1.SetToolTip(this.label13, "Browse a spreadsheet to decrypt and give password");
            // 
            // btnDecryptSource
            // 
            this.btnDecryptSource.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDecryptSource.BackColor = System.Drawing.Color.Transparent;
            this.btnDecryptSource.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDecryptSource.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnDecryptSource.Location = new System.Drawing.Point(299, 29);
            this.btnDecryptSource.Name = "btnDecryptSource";
            this.btnDecryptSource.Size = new System.Drawing.Size(24, 20);
            this.btnDecryptSource.TabIndex = 6;
            this.btnDecryptSource.Text = "...";
            this.btnDecryptSource.UseVisualStyleBackColor = false;
            this.btnDecryptSource.Click += new System.EventHandler(this.btnDecryptSource_Click);
            // 
            // txtDecryptSource
            // 
            this.txtDecryptSource.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDecryptSource.Location = new System.Drawing.Point(110, 29);
            this.txtDecryptSource.Name = "txtDecryptSource";
            this.txtDecryptSource.Size = new System.Drawing.Size(185, 20);
            this.txtDecryptSource.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label8.Location = new System.Drawing.Point(6, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Source Document";
            // 
            // btnDecryption
            // 
            this.btnDecryption.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDecryption.BackColor = System.Drawing.Color.Transparent;
            this.btnDecryption.Enabled = false;
            this.btnDecryption.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDecryption.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnDecryption.Image = ((System.Drawing.Image)(resources.GetObject("btnDecryption.Image")));
            this.btnDecryption.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDecryption.Location = new System.Drawing.Point(258, 135);
            this.btnDecryption.Name = "btnDecryption";
            this.btnDecryption.Size = new System.Drawing.Size(85, 26);
            this.btnDecryption.TabIndex = 10;
            this.btnDecryption.Text = "Decrypt";
            this.btnDecryption.UseVisualStyleBackColor = false;
            this.btnDecryption.Click += new System.EventHandler(this.btnDecryption_Click);
            // 
            // txtDeOpen
            // 
            this.txtDeOpen.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDeOpen.Location = new System.Drawing.Point(110, 60);
            this.txtDeOpen.Name = "txtDeOpen";
            this.txtDeOpen.PasswordChar = '*';
            this.txtDeOpen.Size = new System.Drawing.Size(232, 20);
            this.txtDeOpen.TabIndex = 8;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label10.Location = new System.Drawing.Point(6, 63);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(98, 13);
            this.label10.TabIndex = 3;
            this.label10.Text = "Password To Open";
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.MidnightBlue;
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label11.Location = new System.Drawing.Point(29, 13);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(118, 1);
            this.label11.TabIndex = 2;
            this.label11.Text = "label11";
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(9, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(21, 17);
            this.label12.TabIndex = 1;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(372, 71);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 62;
            this.pictureBox1.TabStop = false;
            // 
            // EncryptionDecryption
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(372, 485);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "EncryptionDecryption";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Advanced Encrypt and Decrypt";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        #region Dispose
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


        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
			SyncfusionLicenseProvider.RegisterLicense(DemoCommon.FindLicenseKey());
            Application.EnableVisualStyles();
            Application.Run(new EncryptionDecryption());
        }

        # endregion
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

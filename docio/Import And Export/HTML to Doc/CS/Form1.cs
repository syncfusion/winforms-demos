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
using System.Drawing;
using Syncfusion.DocIO;
using Syncfusion.DocIO.DLS;
using Syncfusion.Windows.Forms;
using System.Windows.Forms;
using System.IO;
using Syncfusion.Licensing;
using System.Reflection;
using System.Text;

namespace HTMLToDoc_2005
{
    public partial class Form1 : MetroForm
    {
        #region Constructor
        public Form1()
        {		
            InitializeComponent();
        }		
        #endregion

        #region HTML to Doc
        string errorMessage = "";
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Tag.ToString() != string.Empty)
                {
                    WordDocument document = new WordDocument(textBox1.Tag.ToString());

                    #region Save and open Document
                    //Save as doc format
                    if (wordDocRadioBtn.Checked)
                    {
                        //Saving the document to disk.
                        document.Save("HTMLToWord.doc");

                        //Message box confirmation to view the created document.
                        if (MessageBoxAdv.Show("Do you want to view the generated Word document?", "Document has been created", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                        {
                            //Launching the MS Word file using the default Application.[MS Word Or Free WordViewer]
#if NETCORE
                       		System.Diagnostics.Process process = new System.Diagnostics.Process();
                       		process.StartInfo = new System.Diagnostics.ProcessStartInfo("HTMLToWord.doc") { UseShellExecute = true };
                       		process.Start();
#else
                            System.Diagnostics.Process.Start("HTMLToWord.doc");
#endif
                            //Exit
                            this.Close();
                        }
                    }
                    //Save as docx format
                    else if (wordDocxRadioBtn.Checked)
                    {
                        //Saving the document as .docx
                        document.Save("HTMLToWord.docx", FormatType.Docx);
                        //Message box confirmation to view the created document.
                        if (MessageBoxAdv.Show("Do you want to view the generated Word document?", "Document has been created", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                        {
                            try
                            {
                                //Launching the MS Word file using the default Application.[MS Word Or Free WordViewer]
#if NETCORE
                       			System.Diagnostics.Process process = new System.Diagnostics.Process();
                       			process.StartInfo = new System.Diagnostics.ProcessStartInfo("HTMLToWord.docx") { UseShellExecute = true };
                       			process.Start();
#else
                                System.Diagnostics.Process.Start("HTMLToWord.docx");
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
                    }
                    else
                    {
                        // Exit
                        this.Close();
                    }
                    #endregion
                }
                else
                {
                    MessageBoxAdv.Show("Browse or type the HTML content to be converted to word document");
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }
        #endregion

        #region Browse Word Document
        private void button3_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = new DirectoryInfo(Application.StartupPath + @"..\..\..\..\..\..\..\common\Data\DocIO\").FullName;
            openFileDialog1.FileName = "";
            openFileDialog1.Filter = "HTML Files(*.htm *.html)|*.htm;*.html";
            DialogResult result = openFileDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                this.textBox1.Text = openFileDialog1.SafeFileName;
                this.textBox1.Tag = openFileDialog1.FileName;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.textBox1.Text = "HTMLToWord.html";
            this.textBox1.Tag = Application.StartupPath + @"..\..\..\..\..\..\..\common\Data\DocIO\HTMLToWord.html";
        }
        #endregion

    }
}
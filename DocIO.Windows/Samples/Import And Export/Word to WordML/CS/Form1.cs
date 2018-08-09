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
using System.Windows.Forms;
using Syncfusion.DocIO;
using Syncfusion.DocIO.DLS;
using Syncfusion.Windows.Forms;
using System.IO;
using Syncfusion.Licensing;
using System.Reflection;
using System.Text;

namespace Word_To_WordML
{
    public partial class Form1 : MetroForm
    {
        public Form1()
        {		
            InitializeComponent();
            string path = Application.StartupPath + @"..\..\..\..\..\..\..\..\Common\Data\DocIO\";
            openFileDialog1.InitialDirectory = new DirectoryInfo(path).FullName;

        }		
        private string fullPath;
        #region Convert To WordML

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (this.textBox1.Text != String.Empty && fullPath != string.Empty)
                {
                    if (this.textBox1.Text.Contains("//")) // in case user copy-paste the path in the textbox
                    {
                        fullPath = this.textBox1.Text;
                    }

                    if (File.Exists(fullPath))
                    {
                        WordDocument doc = new WordDocument(fullPath);
                        //Export the doc to WordML and save as .WordML file
                        doc.Save("DocToWordML.xml", FormatType.WordML);
                        //Message box confirmation to view the created document.
                        if (MessageBoxAdv.Show("Do you want to view the WordML file?", "File has been created", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                        {
                            try
                            {
                                System.Diagnostics.Process.Start(@"DocToWordML.xml");
                                //Exit
                                this.Close();
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine(ex.ToString());
                            }
                        }
                    }

                    else
                    {
                        MessageBoxAdv.Show("File doesn't exist");
                    }
                }
                else
                {
                    MessageBoxAdv.Show("Browse a word document and click the button to convert as a WordML.");
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        #endregion

        #region Browse Document
        private void button3_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "";
            openFileDialog1.Filter = "Word Document(*.doc *.docx)|*.doc;*.docx";
            DialogResult result = openFileDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                this.textBox1.Text = openFileDialog1.SafeFileName;
                fullPath = openFileDialog1.FileName;
            }

        }
        #endregion Browse Document

        private void Form1_Load(object sender, EventArgs e)
        {
            this.textBox1.Text = "DocToWordML.doc";
            fullPath = Application.StartupPath + @"..\..\..\..\..\..\..\..\Common\Data\DocIO\DocToWordML.doc";


        }
    }
}
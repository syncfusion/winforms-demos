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
using Syncfusion.DocIO.DLS;
using Syncfusion.DocIO;
using Syncfusion.Windows.Forms;
using Syncfusion.Licensing;
using System.Reflection;
using System.Text;
using System.IO;

namespace DocToEPub_2005
{
    public partial class Form1 : MetroForm
    {
        OpenFileDialog openFileDialog1 = new OpenFileDialog();

        public Form1()
        {	
            InitializeComponent();
        }
        
        private void button3_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = Application.StartupPath + @"..\..\..\..\..\..\..\..\Common\Data\DocIO\";
            openFileDialog1.Filter = "Word 97 to 2003 Document (*.doc)|*.doc|Word 2007 Document(*.docx)|*.docx";

            openFileDialog1.FileName = "";
            DialogResult result = openFileDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                this.textBox1.Text = openFileDialog1.SafeFileName;
                this.textBox1.Tag = openFileDialog1.FileName;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.textBox1.Text = "Doc to EPub.doc";
            this.textBox1.Tag = Application.StartupPath + @"..\..\..\..\..\..\..\..\Common\Data\DocIO\Doc to EPub.doc";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.textBox1.Text))
            {
                try
                {
                    //Open the document to convert from Word to EPub
                    WordDocument document = new WordDocument((string)textBox1.Tag);

                    document.SaveOptions.EPubExportFont = this.checkBox1.Checked;

                    document.Save("Sample.epub", FormatType.EPub);

                    document.Close();

                    //Message box confirmation to view the created document.
                    if (MessageBoxAdv.Show("Do you want to view the EPub file?", "File has been created", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        try
                        {
                            System.Diagnostics.Process process = System.Diagnostics.Process.Start(@"Sample.epub");
                            if (process != null && process.ProcessName != null && process.ProcessName.ToLower() == "rundll32")
                            {
                                process.Kill();
                                MessageBoxAdv.Show("EPub viewer is not installed in this system!", "Status");
                            }
                            this.Close();
                        }
                        catch (Win32Exception)
                        {
                            MessageBoxAdv.Show("EPub viewer is not installed in this system!", "Status");
                        }
                        catch (Exception ex)
                        {
                            MessageBoxAdv.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        }
                    }
                }
                catch (Exception)
                {
                    MessageBoxAdv.Show("The input document could not be processed, could you please email the document to support@syncfusion.com for troubleshooting?", "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBoxAdv.Show("Browse a word document and click the button to convert as a EPub.");
            }
        }
    }
}
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
            this.label4.Visible = true;
            this.panel4.Visible = false;
            this.outpuTextBox.ReadOnly = true;
            StreamReader read = new StreamReader(Application.StartupPath + @"..\..\..\..\..\..\..\..\Common\Data\DocIO\Transitional.html");
            text = read.ReadToEnd();
            this.textBox1.Text = text;
        }		
        #endregion

        #region Browse HTML content
        String text;
        private void button2_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = Application.StartupPath + @"..\..\..\..\..\..\..\..\Common\Data\DocIO\";
            openFileDialog1.FileName = "";
            openFileDialog1.Filter = "HTML files (*.htm *.html)|*.htm;*.html";
            DialogResult result = openFileDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                StreamReader read = new StreamReader(openFileDialog1.OpenFile());
                text = read.ReadToEnd();
            }
            this.textBox1.Text = text;

            outpuTextBox.Clear();

        }
        #endregion

        #region HTML to Doc
        string errorMessage = "";
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.textBox1.Text != string.Empty)
                {
                    WordDocument document = new WordDocument();
                    IWSection section = document.AddSection();
                    // Set Margin of the document
                    section.PageSetup.Margins.All = 72;
                    IWParagraph para = section.AddParagraph();

                    bool valid = false;

                    // This manual validation check is Transitional. We do this here only for instructional purpose.
                    if (section.Body.IsValidXHTML(this.textBox1.Text, XHTMLValidationType.Transitional, out errorMessage))
                    {
                        valid = true;
                        document.XHTMLValidateOption = XHTMLValidationType.Transitional;
                    }
                    // This manual validation check is Strict. We do this here only for instructional purpose
                    else if (section.Body.IsValidXHTML(this.textBox1.Text, XHTMLValidationType.Strict, out errorMessage))
                    {
                        valid = true;
                        document.XHTMLValidateOption = XHTMLValidationType.Strict;
                    }
                    // This manual validation check is None. We do this here only for instructional purpose
                    else if (section.Body.IsValidXHTML(this.textBox1.Text, XHTMLValidationType.None, out errorMessage))
                    {
                        valid = true;
                        document.XHTMLValidateOption = XHTMLValidationType.None;
                    }              

                    if (!valid)
                    {
                        outpuTextBox.Text = "Content is not a welformatted XHTML content.\t\t\tError message:\t\t\t\t\t\t" + errorMessage;
                        this.panel4.Visible = true;
                        this.label4.Visible = false;
                        this.button3.Text = "-";
                        this.Size = new Size(384, 650);
                    }
                    else
                    {
                        // By default, the input html will be validated for XHTML format. This will provide you understandable error messages, if the format is invalid.
                        // However, if you are sure that the input html is valid, then you can skip the validation step to improve performance. However, any error messages 
                        //you might get here will not be very useful as to where exactly in your html, the issue is.

                        section.Body.InsertXHTML(this.textBox1.Text);

                        outpuTextBox.Text = "Conversion Successful";
                        this.panel4.Visible = true;
                        this.label4.Visible = false;
                        this.button3.Text = "-";
                        this.Size = new Size(384, 650);

                        #region Save and open Document
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
                        #endregion
                    }
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

        #region Events

        private void button3_Click(object sender, EventArgs e)
        {
            if (label4.Visible == true)
            {
                this.panel4.Visible = true;
                this.label4.Visible = false;
                this.button3.Text = "--";
                this.Size = new Size(384, 650);
            }
            else
            {
                this.panel4.Visible = false;
                this.label4.Visible = true;
                this.button3.Text = "+";
                this.Size = new Size(384, 650);
            }
        }

        #endregion

    }
}
#region Copyright Syncfusion Inc. 2001 - 2017
// Copyright Syncfusion Inc. 2001 - 2017. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.ComponentModel;
using System.Windows.Forms;
using Syncfusion.DocIO;
using Syncfusion.DocIO.DLS ;
using Syncfusion.Windows.Forms;
using Syncfusion.Licensing;
using System.Reflection;
using System.Text;
using System.IO;

namespace EncryptDocument_2005
{
    public partial class Form1 : MetroForm
    {
        public Form1()
        {		
            InitializeComponent();
        }
        /// <summary>
        /// Encrypt the selected Word document
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            if (this.txtEncryptSource.Text != null && this.txtEncryptSource.Text != "")
            {
                WordDocument document = new WordDocument(this.txtEncryptSource.Text);

                // Getting last section of the document.
                IWSection section = document.LastSection;

                // Adding a paragraph to the section.
                IWParagraph paragraph = section.AddParagraph();

                // Writing text
                IWTextRange text = paragraph.AppendText("This document was encrypted with password");
                text.CharacterFormat.FontSize = 16f;
                text.CharacterFormat.FontName = "Bitstream Vera Serif";

                // Encrypt the document by giving password
                document.EncryptDocument(txtEnOpen.Text);

                # region Save Document
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
                # endregion
            }
            else
            {
                MessageBox.Show("Please browse the document to encrypt");
            }
        }
        /// <summary>
        /// Gets the source document to encrypt
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = Application.StartupPath + @"..\..\..\..\..\..\..\..\Common\Data\DocIO\";
            openFileDialog1.Title = "Choose a Word document to Encrypt";
            openFileDialog1.Filter = "Word Document(*.doc *.docx *.rtf)|*.doc;*.docx;*.rtf";
            openFileDialog1.RestoreDirectory = true;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                this.txtEncryptSource.Text = openFileDialog1.FileName;               
            }
           
        }
        /// <summary>
        /// Gets the source document to decrypt
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDecryptSource_Click(object sender, EventArgs e)
        {
            openFileDialog2.InitialDirectory = Application.StartupPath + @"..\..\..\..\..\..\..\..\Common\Data\DocIO\";
            openFileDialog2.Title = "Choose a Word document to Decrypt";
            openFileDialog2.Filter = "Word Document(*.doc *.docx *.rtf)|*.doc;*.docx;*.rtf";
            openFileDialog2.RestoreDirectory = true;
            if (openFileDialog2.ShowDialog() == DialogResult.OK)
            {
                this.txtDecryptSource.Text = openFileDialog2.FileName;
                
            }
          
        }
        /// <summary>
        /// Decrypt the selected Word document
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.txtDecryptSource.Text != null && this.txtDecryptSource.Text != "")
                {
                    WordDocument document = new WordDocument(this.txtDecryptSource.Text, txtDeOpen.Text);

                    // Getting last section of the document.
                    IWSection section = document.LastSection;

                    // Adding a paragraph to the section.
                    IWParagraph paragraph = section.AddParagraph();

                    // Writing text
                    IWTextRange text = paragraph.AppendText("\nDemo For Document Decryption with Essential DocIO");
                    text.CharacterFormat.FontSize = 16f;
                    text.CharacterFormat.FontName = "Bitstream Vera Serif";

                    text = paragraph.AppendText("\nThis document is Decrypted");
                    text.CharacterFormat.FontSize = 16f;
                    text.CharacterFormat.FontName = "Bitstream Vera Serif";

                    # region Save Document
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
                    # endregion
                }
                else
                {
                    MessageBoxAdv.Show("Please browse the document to decrypt");
                }
            }
            catch (Exception e1)
            {
                MessageBoxAdv.Show(e1.Message, "Error Message");   
            }
        }
    
    }
    
}
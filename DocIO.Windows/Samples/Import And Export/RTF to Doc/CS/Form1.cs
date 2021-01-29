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
using System.Windows.Forms;
using Syncfusion.DocIO;
using Syncfusion.DocIO.DLS;
using Syncfusion.Windows.Forms;
using Syncfusion.Licensing;
using System.Reflection;
using System.Text;
using System.IO;

namespace RTFToDoc
{
    public partial class Form1 : MetroForm
    {
        public Form1()
        {		
            InitializeComponent();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = Application.StartupPath + @"..\..\..\..\..\..\..\..\Common\Data\DocIO\";
            openFileDialog1.FileName = "";
            openFileDialog1.Filter = "Word Document(*.rtf)|*.rtf";
            DialogResult result = openFileDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                this.textBox1.Text = openFileDialog1.SafeFileName;
                this.textBox1.Tag = openFileDialog1.FileName;

            }
        }
       
        private void Form1_Load(object sender, EventArgs e)
        {
            this.textBox1.Text = "RTFToWord.rtf";
            this.textBox1.Tag = Application.StartupPath + @"..\..\..\..\..\..\..\..\Common\Data\DocIO\RTFToWord.rtf";

        }

        private void btnRTFToDoc_Click(object sender, EventArgs e)
        {
            try
            {
                WordDocument document = new WordDocument();
                document.Open((string)this.textBox1.Tag, FormatType.Rtf);
                string outputFileName = Path.GetFileNameWithoutExtension((string)this.textBox1.Tag);
                //Saving the document to disk.
                document.Save(outputFileName + ".docx");

                //Message box confirmation to view the created document.
                if (MessageBoxAdv.Show("Do you want to view the generated Word document?", "Document has been created", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
					//Launching the MS Word file using the default Application.[MS Word Or Free WordViewer]
#if NETCORE
					System.Diagnostics.Process process = new System.Diagnostics.Process();
					process.StartInfo = new System.Diagnostics.ProcessStartInfo(outputFileName + ".docx") { UseShellExecute = true };
					process.Start();
#else                       
					System.Diagnostics.Process.Start(outputFileName + ".docx");
#endif
                    //Exit
                    this.Close();
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

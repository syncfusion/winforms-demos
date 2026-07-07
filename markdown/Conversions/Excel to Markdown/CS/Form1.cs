#region Copyright Syncfusion Inc. 2001 - 2019
//
//  Copyright Syncfusion Inc. 2001 - 2007. All rights reserved.
//
//  Use of this code is subject to the terms of our license.
//  A copy of the current license can be obtained at any time by e-mailing
//  licensing@syncfusion.com. Any infringement will be prosecuted under
//  applicable laws. 
//
#endregion

using Microsoft.Win32;
using Syncfusion.ExcelChartToImageConverter;
using Syncfusion.Windows.Forms;
using Syncfusion.XlsIO;
using Syncfusion.XlsIO.Implementation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace Excel_to_Markdown
{
    public partial class Form1 : MetroForm
    {
        public Form1()
        {
            InitializeComponent();
            string path = Application.StartupPath + @"..\..\..\..\..\..\..\common\Data\Markdown\";
            openFileDialog1.InitialDirectory = new DirectoryInfo(path).FullName;

        }
        private string fullPath;
        #region Convert To Markdown

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
                        string outputFileName = Path.GetFileNameWithoutExtension(fullPath);
                        ExcelEngine engine = new ExcelEngine();
                        IApplication application = engine.Excel;
                        IWorkbook book = application.Workbooks.Open(fullPath);
                        //Save the markdown file
                        book.SaveAs(outputFileName +".md", ExcelSaveType.Markdown);

                        //Message box confirmation to view the created document.
                        if (MessageBoxAdv.Show("Do you want to view the Markdown file?", "File has been created", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                        {
                            try
                            {
#if NETCORE
                                System.Diagnostics.Process process = new System.Diagnostics.Process();
                                process.StartInfo = new System.Diagnostics.ProcessStartInfo(outputFileName +".md") { UseShellExecute = true };
                                process.Start();
#else                       
                                System.Diagnostics.Process.Start(outputFileName + ".md");
#endif
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
                        MessageBoxAdv.Show("File doesn’t exist");
                    }
                }
                else
                {
                    MessageBoxAdv.Show("Browse a Excel document and click the button to convert as a Markdown.");
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
            openFileDialog1.Filter = "Excel Files (*.xls *.xlsx *.xlsm)|*.xls;*.xlsx;*.xlsm";
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
            this.textBox1.Text = "ExcelToMarkdown.xlsx";
            fullPath = Application.StartupPath + @"..\..\..\..\..\..\..\common\Data\Markdown\ExcelToMarkdown.xlsx";
        }
    }
}
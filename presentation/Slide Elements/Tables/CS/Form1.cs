#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Syncfusion.Presentation;
using Syncfusion.Presentation.Drawing;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using Syncfusion.Windows.Forms;
using Syncfusion.Licensing;
using System.Reflection;

namespace CreatePresentation
{
    public partial class Form1 : MetroForm
    {
        #region Private Members
        private System.Windows.Forms.Button btnCreatePresn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;

         /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        #endregion

        # region Constructor
        public Form1()
        {
            //
            // Required for Windows Form Designer support
            //
            
            InitializeComponent();
            this.MinimizeBox = true;
            Application.EnableVisualStyles();
        }
        /// <summary>
        /// Helper method to find a syncfusion license key from the Common folder
        /// </summary>
        /// <param name="fileName">File name of the syncfusion license key</param>
        /// <returns></returns>
        public static string FindLicenseKey()
        {
            string licenseKeyFile = "..\\common\\SyncfusionLicense.txt";
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
        #endregion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnCreatePresn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCreatePresn
            // 
            this.btnCreatePresn.Location = new System.Drawing.Point(268, 153);
            this.btnCreatePresn.Name = "btnCreatePresn";
            this.btnCreatePresn.Size = new System.Drawing.Size(113, 27);
            this.btnCreatePresn.TabIndex = 0;
            this.btnCreatePresn.Text = "Create Presentation";
            this.btnCreatePresn.UseVisualStyleBackColor = true;
            this.btnCreatePresn.Click += new System.EventHandler(this.btnCreatePresn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(381, 97);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(370, 42);
            this.label1.TabIndex = 27;
            this.label1.Text = "Click the button to view a presentation generated by Essential Presentation.\r\nPle" +
    "ase note that Microsoft PowerPoint viewer is required to view the resultant \r\nPresentation." +
    "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 200);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnCreatePresn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Table Formatting";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        [STAThread]
        static void Main()
        {
            SyncfusionLicenseProvider.RegisterLicense(FindLicenseKey());
            Application.Run(new Form1());
        }


        private void btnCreatePresn_Click(object sender, EventArgs e)
        {
            //Creates a new instance of the presentation.
            using (IPresentation presentation = Presentation.Create())
            {
                #region Slide1
                //To add a slide to PowerPoint presentation
                ISlide slide = presentation.Slides.Add(SlideLayoutType.TitleOnly);
                //To set the table title in a slide
                SetTableTitle(slide);
                //Get table data from xml file
                DataSet dataSet = new DataSet();
#if !NETCore
                dataSet.ReadXml(@"..\..\..\..\..\..\common\Data\Presentation\TableData.xml");
#else
                dataSet.ReadXml(@"..\..\..\..\..\..\..\common\Data\Presentation\TableData.xml");
#endif
                int columnCount = dataSet.Tables[0].Rows.Count+1;
                int rowCount = dataSet.Tables.Count - 1;
                //To add a new table in slide.
                ITable table = slide.Shapes.AddTable(rowCount, columnCount, 61.92, 95.76, 856.8, 378.72);
                //To set the style for the table.
                table.BuiltInStyle = BuiltInTableStyle.MediumStyle2Accent6;
               
                //To set category title
                SetCategoryTitle(table);
                //Iterates and sets the values to the table cells.
                for (int rowIndex = 0; rowIndex < table.Rows.Count; rowIndex++)
                {
                    IRow row = table.Rows[rowIndex];
                    if(rowIndex == 0)
                        AddHeaderRow(row, dataSet.Tables[0].Rows);
                    else
                        AddCell(row, dataSet.Tables[rowIndex+1]);
                }

                #endregion
                //Saves the presentation
                presentation.Save("TablesSample.pptx");

                if (MessageBox.Show("Do you want to view the generated Presentation?", "Presentation Created",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
#if !NETCore
                    System.Diagnostics.Process.Start("TablesSample.pptx");
#else
                    System.Diagnostics.Process process = new System.Diagnostics.Process();
                    process.StartInfo = new System.Diagnostics.ProcessStartInfo("TablesSample.pptx")
                    {
                        UseShellExecute = true
                    };
                    process.Start();
#endif
                    this.Close();
                }
            }
        }

        #region HelperMethods
        
        /// <summary>
        /// Sets the table title.
        /// </summary>
        /// <param name="slide">Represents the slide instance of the presentation.</param>
        private void SetTableTitle(ISlide slide)
        {
            IShape shape = slide.Shapes[0] as IShape;
            shape.Left = 84.24;
            shape.Top = 0;
            shape.Width = 792;
            shape.Height = 126.72;
            ITextBody textFrame = shape.TextBody;
            IParagraphs paragraphs = textFrame.Paragraphs;
            paragraphs.Add();
            IParagraph paragraph = paragraphs[0];
            paragraph.HorizontalAlignment = HorizontalAlignmentType.Center;

            //Instance to hold textparts in paragraph.
            ITextParts textParts = paragraph.TextParts;
            textParts.Add();
            ITextPart textPart = textParts[0];
            textPart.Text = "Target ";
            IFont font = textPart.Font;
            font.FontName = "Arial";
            font.FontSize = 28;
            font.Bold = true;
            font.CapsType = TextCapsType.All;
            textParts.Add();

            //Creates a textpart and assigns value to it.
            textPart = textParts[1];
            textPart.Text = "Vs ";
            font = textPart.Font;
            font.FontName = "Arial";
            font.FontSize = 18;
            textParts.Add();

            //Creates a textpart and assigns value to it.
            textPart = textParts[2];
            textPart.Text = "PERFORMANCE";
            font = textPart.Font;
            font.FontName = "Arial";
            font.FontSize = 28;
            font.Bold = true;
        }

        /// <summary>
        /// Adds the cell content to the table.
        /// </summary>
        /// <param name="row">Represents the instance of row.</param>
        /// <param name="dataTable">Represents the table of the data.</param>
        private void AddCell(IRow row, DataTable dataTable)
        {
            DataRowCollection dataRowCollection = dataTable.Rows;
            for (int cellIndex = 0; cellIndex <row.Cells.Count; cellIndex++)
            {
                ICell cell = row.Cells[cellIndex];
                //Instance to hold paragraphs in cell.
                IParagraphs paragraphs = cell.TextBody.Paragraphs;
                paragraphs.Add();
                IParagraph paragraph = paragraphs[0];
                paragraph.HorizontalAlignment = HorizontalAlignmentType.Left;
                ITextParts textParts = paragraph.TextParts;
                textParts.Add();

                //Creates a textpart and assigns value to it.
                ITextPart textPart = textParts[0];
                if (cellIndex == 0)
                    textPart.Text = dataTable.TableName;
                else
                    textPart.Text = dataRowCollection[cellIndex - 1].ItemArray[0].ToString();
                IFont font = textPart.Font;
                font.FontName = "Arial";
                font.FontSize = 14;
            }
        }

        /// <summary>
        /// Adds the content for the row and column for the table.
        /// </summary>
        /// <param name="row">Represents the particular row.</param>
        /// <param name="dataRowCollections">Represents the row collections of the data.</param>
        private void AddHeaderRow(IRow row, DataRowCollection dataRowCollections)
        {
            for(int cellIndex = 1; cellIndex < row.Cells.Count;cellIndex++)
            {
                ICell cell = row.Cells[cellIndex];
                cell.TextBody.VerticalAlignment = VerticalAlignmentType.Middle;
                //To add a paragraph inside cell
                IParagraphs paragraphs = cell.TextBody.Paragraphs;
                if (paragraphs.Count == 0)
                    paragraphs.Add();
                IParagraph paragraph = paragraphs[0];
                paragraph.HorizontalAlignment = HorizontalAlignmentType.Center;
                ITextParts textParts = paragraph.TextParts;
                if (textParts.Count == 0)
                    textParts.Add();

                //Creates a textpart and assigns value to it.
                ITextPart textPart = textParts[0];
                textPart.Text = dataRowCollections[cellIndex-1].ItemArray[0].ToString();
                IFont font = textPart.Font;
                font.FontName = "Arial";
                font.FontSize = 14;
                font.Bold = true;
            }            
        }

        /// <summary>
        /// Sets the title for the category in the table.
        /// </summary>
        /// <param name="table">Instance to access the table from the presentation.</param>
        void SetCategoryTitle(ITable table)
        {
            //Instance to hold rows in the table
            table.Rows[0].Height = 81.44;
            //To set text alignment type inside cell            
            table.Rows[0].Cells[0].TextBody.VerticalAlignment = VerticalAlignmentType.Middle;

            //To add a paragraph inside cell
            IParagraphs paragraphs = table.Rows[0].Cells[0].TextBody.Paragraphs;
            paragraphs.Add();
            IParagraph paragraph = paragraphs[0];
            paragraph.HorizontalAlignment = HorizontalAlignmentType.Center;
            ITextParts textParts = paragraph.TextParts;
            textParts.Add();

            //Creates a textpart and assigns value to it.
            ITextPart textPart = textParts[0];
            textPart.Text = "Month";
            IFont font = textPart.Font;
            font.FontName = "Arial";
            font.FontSize = 14;
            font.Bold = true;
        }
        #endregion HelperMethods
    }
}

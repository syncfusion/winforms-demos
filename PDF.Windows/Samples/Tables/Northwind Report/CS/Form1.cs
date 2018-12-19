#region Copyright Syncfusion Inc. 2001 - 2007
//
//  Copyright Syncfusion Inc. 2001 - 2007. All rights reserved.
//
//  Use of this code is subject to the terms of our license.
//  A copy of the current license can be obtained at any time by e-mailing
//  licensing@syncfusion.com. Re-distribution in any form is strictly
//  prohibited. Any infringement will be prosecuted under applicable laws. 
//
#endregion

using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using Syncfusion.Pdf;
using Syncfusion.Windows.Forms;
using Syncfusion.Pdf.Graphics;
using Syncfusion.Pdf.Tables;
using System.Data.OleDb;
using System.Data.SqlServerCe;
using Syncfusion.Licensing;

namespace EssentialPDFSamples
{
    /// <summary>
    /// Summary description for Form1.
    /// </summary>
    public class Form1 : MetroForm
    {
        # region Private Members
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private const string DEF_DB_COMMAND2 = "SELECT CustomerID,CompanyName,ContactName,Address,City,PostalCode,Country,Phone,Fax FROM Customers";
        private GroupBox groupBox1;
        private ComboBox comboBox1;
        private CheckBox builtinstyles;
        private CheckBox lastColumn;
        private CheckBox bandedColumn;
        private CheckBox headerRow;
        private CheckBox lastRow;
        private CheckBox bandedRow;
        private CheckBox firstColumn;
        PdfLightTableBuiltinStyle tablestyle;

        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.Container components = null;
        # endregion

        # region Constructor
        public Form1()
        {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();
            this.MinimizeBox = true;
            Array styleArray = Enum.GetValues(typeof(PdfLightTableBuiltinStyle));
            foreach (PdfLightTableBuiltinStyle style in styleArray)
            {
                this.comboBox1.Items.Add(style);
            }           
            this.comboBox1.SelectedIndex = 26;
            this.groupBox1.Visible = false;
            this.Size = new Size(385, 232);
            this.button1.Location = new Point(286, 161);
            this.button1.Size = new Size(75, 23);
            this.builtinstyles.Location = new Point(3, 167);
            this.builtinstyles.Size = new Size(80, 17);
            this.headerRow.Checked = true;
            this.bandedRow.Checked = true;
            //
            // TODO: Add any constructor code after InitializeComponent call
            //
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.builtinstyles = new System.Windows.Forms.CheckBox();
            this.headerRow = new System.Windows.Forms.CheckBox();
            this.bandedRow = new System.Windows.Forms.CheckBox();
            this.firstColumn = new System.Windows.Forms.CheckBox();
            this.lastRow = new System.Windows.Forms.CheckBox();
            this.bandedColumn = new System.Windows.Forms.CheckBox();
            this.lastColumn = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(298, 302);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(73, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "PDF";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(0, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(375, 52);
            this.label1.TabIndex = 1;
            this.label1.Text = "Click the button to view an PDF document generated by Essential PDF.  Please note" +
    " that Adobe Reader or its equivalent is required to view the resultant document." +
    "";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = System.Drawing.Image.FromFile(GetFullTemplatePath("pdf_header.png", true));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(373, 90);
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lastColumn);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.bandedColumn);
            this.groupBox1.Controls.Add(this.headerRow);
            this.groupBox1.Controls.Add(this.lastRow);
            this.groupBox1.Controls.Add(this.bandedRow);
            this.groupBox1.Controls.Add(this.firstColumn);
            this.groupBox1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.groupBox1.Location = new System.Drawing.Point(3, 177);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(368, 119);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "PdfLightTable Built-in style";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(7, 19);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(150, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // builtinstyles
            // 
            this.builtinstyles.AutoSize = true;
            this.builtinstyles.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.builtinstyles.ForeColor = System.Drawing.Color.MidnightBlue;
            this.builtinstyles.Location = new System.Drawing.Point(3, 154);
            this.builtinstyles.Name = "builtinstyles";
            this.builtinstyles.Size = new System.Drawing.Size(101, 17);
            this.builtinstyles.TabIndex = 26;
            this.builtinstyles.Text = "Built-in styles";
            this.builtinstyles.UseVisualStyleBackColor = true;
            this.builtinstyles.CheckedChanged += new System.EventHandler(this.builtinstyles_CheckedChanged);
            // 
            // headerRow
            // 
            this.headerRow.AutoSize = true;
            this.headerRow.Location = new System.Drawing.Point(9, 57);
            this.headerRow.Name = "headerRow";
            this.headerRow.Size = new System.Drawing.Size(81, 17);
            this.headerRow.TabIndex = 0;
            this.headerRow.Text = "Header row";
            this.headerRow.UseVisualStyleBackColor = true;
            // 
            // bandedRow
            // 
            this.bandedRow.AutoSize = true;
            this.bandedRow.Location = new System.Drawing.Point(141, 57);
            this.bandedRow.Name = "bandedRow";
            this.bandedRow.Size = new System.Drawing.Size(83, 17);
            this.bandedRow.TabIndex = 1;
            this.bandedRow.Text = "Banded row";
            this.bandedRow.UseVisualStyleBackColor = true;
            // 
            // firstColumn
            // 
            this.firstColumn.AutoSize = true;
            this.firstColumn.Location = new System.Drawing.Point(280, 57);
            this.firstColumn.Name = "firstColumn";
            this.firstColumn.Size = new System.Drawing.Size(82, 17);
            this.firstColumn.TabIndex = 2;
            this.firstColumn.Text = "First column";
            this.firstColumn.UseVisualStyleBackColor = true;
            // 
            // lastRow
            // 
            this.lastRow.AutoSize = true;
            this.lastRow.Location = new System.Drawing.Point(9, 91);
            this.lastRow.Name = "lastRow";
            this.lastRow.Size = new System.Drawing.Size(66, 17);
            this.lastRow.TabIndex = 3;
            this.lastRow.Text = "Last row";
            this.lastRow.UseVisualStyleBackColor = true;
            // 
            // bandedColumn
            // 
            this.bandedColumn.AutoSize = true;
            this.bandedColumn.Location = new System.Drawing.Point(141, 91);
            this.bandedColumn.Name = "bandedColumn";
            this.bandedColumn.Size = new System.Drawing.Size(100, 17);
            this.bandedColumn.TabIndex = 4;
            this.bandedColumn.Text = "Banded column";
            this.bandedColumn.UseVisualStyleBackColor = true;
            // 
            // lastColumn
            // 
            this.lastColumn.AutoSize = true;
            this.lastColumn.Location = new System.Drawing.Point(279, 91);
            this.lastColumn.Name = "lastColumn";
            this.lastColumn.Size = new System.Drawing.Size(83, 17);
            this.lastColumn.TabIndex = 5;
            this.lastColumn.Text = "Last column";
            this.lastColumn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(373, 331);
            this.Controls.Add(this.builtinstyles);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Northwind Report";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
			SyncfusionLicenseProvider.RegisterLicense(DemoCommon.FindLicenseKey());
            Application.EnableVisualStyles();
            Application.Run(new Form1());
        }
        # endregion

        # region Events
        private void button1_Click(object sender, System.EventArgs e)
        {
            //Create a new instance of PdfDocument class.
            PdfDocument document = new PdfDocument();

            //Set font
            PdfFont font = new PdfStandardFont(PdfFontFamily.Helvetica, 8);

            // Add a new page to the document.
            PdfPage page = document.Pages.Add();

            //Adding Header
            this.AddHeader(document, "Northwind Customers", "");

            //Use DataTable as source
            PdfLightTable table = new PdfLightTable();

            //Create dataset with the "Customers" table from Northwind database.
            DataSet dataSet = GetNorthwindDataSet(DEF_DB_COMMAND2);

            //Set Data source
            table.DataSource = dataSet.Tables[0];

            # region Cell Styles

            //Create Pdf pen for drawing broder
            PdfPen borderPen = new PdfPen(PdfBrushes.DarkBlue);
            borderPen.Width = 0;

            //Create cell styles
            PdfCellStyle altStyle = new PdfCellStyle();
            altStyle.Font = font;
            altStyle.BackgroundBrush = new PdfSolidBrush(new PdfColor(192, 201, 219));
            altStyle.BorderPen = borderPen;

            PdfCellStyle defStyle = new PdfCellStyle();
            defStyle.Font = font;
            defStyle.BackgroundBrush = PdfBrushes.White;
            defStyle.BorderPen = borderPen;
            defStyle.StringFormat = new PdfStringFormat(PdfTextAlignment.Left, PdfVerticalAlignment.Middle);

            PdfCellStyle headerStyle = new PdfCellStyle(font, PdfBrushes.White, PdfPens.DarkBlue);
            headerStyle.BackgroundBrush = new PdfSolidBrush(Color.FromArgb(33, 67, 126));
            headerStyle.StringFormat = new PdfStringFormat(PdfTextAlignment.Center, PdfVerticalAlignment.Middle);

            # endregion

            # region Format Table
            //Set table alternate row style
            table.Style.AlternateStyle = altStyle;

            //Set default style
            table.Style.DefaultStyle = defStyle;

            //Set header row style         
            table.Style.HeaderStyle = headerStyle;

            //Show the header row
            table.Style.ShowHeader = true;

            //Repeate header in all the pages
            table.Style.RepeatHeader = true;

            //Set header data from column caption
            table.Style.HeaderSource = PdfHeaderSource.ColumnCaptions;

            table.Style.BorderPen = borderPen;
            table.Style.CellPadding = 2;
            table.Columns[1].Width = 65;

            # endregion

            // Create a new instance of PdfLayoutFormat class.
            PdfLayoutFormat format = new PdfLayoutFormat();
            //Set layout properties.
            format.Break = PdfLayoutBreakType.FitElement;
            format.Layout = PdfLayoutType.Paginate;

            if (this.builtinstyles.Checked)
            {
                table.Style.BorderPen = new PdfPen(PdfColor.Empty);
                string styleName = this.comboBox1.SelectedItem.ToString();
                tablestyle = ConvertToPdfLightTableBuiltinStyle(styleName);

                PdfLightTableBuiltinStyleSettings setting = new PdfLightTableBuiltinStyleSettings();
                setting.ApplyStyleForBandedColumns = this.bandedColumn.Checked;
                setting.ApplyStyleForBandedRows = this.bandedRow.Checked;
                setting.ApplyStyleForFirstColumn = this.firstColumn.Checked;
                setting.ApplyStyleForLastColumn = this.lastColumn.Checked;
                setting.ApplyStyleForLastRow = this.lastRow.Checked;
                setting.ApplyStyleForHeaderRow = this.headerRow.Checked;

                table.ApplyBuiltinStyle(tablestyle, setting);
            }

            //Draw table
            table.Draw(page, new PointF(0, 10), format);

            //Save to disk
            document.Save("Sample.pdf");
            document.Close(true);

            //Message box confirmation to view the created PDF document.
            if (MessageBox.Show("Do you want to view the PDF file?", "PDF File Created",
                MessageBoxButtons.YesNo, MessageBoxIcon.Information)
                == DialogResult.Yes)
            {
                //Launching the PDF file using the default Application.[Acrobat Reader]
                System.Diagnostics.Process.Start("Sample.pdf");
                this.Close();
            }
            else
            {
                // Exit
                this.Close();
            }
        }
        # endregion

        # region Helpher Methods

        /// <summary>
        /// Convert string to PdfLightTableBuiltinStyle
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        private PdfLightTableBuiltinStyle ConvertToPdfLightTableBuiltinStyle(string styleName)
        {
            PdfLightTableBuiltinStyle value = (PdfLightTableBuiltinStyle)Enum.Parse(typeof(PdfLightTableBuiltinStyle), styleName);
            return value;
        }

        /// <summary>
        /// Returns dataset.
        /// </summary>
        private DataSet GetNorthwindDataSet(string selectCommand)
        {
            DataSet dataSet = new DataSet();
            try
            {
                AppDomain.CurrentDomain.SetData("SQLServerCompactEditionUnderWebHosting", true);
                //   string SqlMobileConnString1 = @"Data Source = " + GetFullTemplatePath("NorthwindIO_3.5.sdf", false)
                SqlCeConnection connection = new SqlCeConnection();
                if (connection.ServerVersion.StartsWith("3.5"))
                    connection.ConnectionString = "Data Source = " + GetFullTemplatePath("NorthwindIO_3.5.sdf", false);
                else
                    connection.ConnectionString = "Data Source = " + GetFullTemplatePath("NorthwindIO.sdf", false);
                connection.Open();
                SqlCeDataAdapter adapter = new SqlCeDataAdapter(DEF_DB_COMMAND2, connection);
                adapter.Fill(dataSet);
            }
            catch (Exception)
            {
                MessageBox.Show("Cannot load DataSet", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }

            return dataSet;
        }       

        /// <summary>
        /// Adds header to the document.
        /// </summary>
        private void AddHeader(PdfDocument doc, string title, string description)
        {
            RectangleF rect = new RectangleF(0, 0, doc.Pages[0].GetClientSize().Width, 54);
            PdfPageTemplateElement header = new PdfPageTemplateElement(rect);
            PdfGraphics g = header.Graphics;

            //Draw the image in the Header.
            SizeF imageSize = new SizeF(110f, 35f);
            //Locating the logo on the right corner.
            PointF imageLocation = new PointF(g.ClientSize.Width - imageSize.Width - 20, 8);
            PdfImage img = new PdfBitmap(GetFullTemplatePath("logo.jpg", true));
            g.DrawImage(img, imageLocation, imageSize);

            // Update title.
            PdfSolidBrush brush = new PdfSolidBrush(Color.FromArgb(44, 71, 120));
            PdfFont font = new PdfStandardFont(PdfFontFamily.Helvetica, 16, PdfFontStyle.Bold);
            PdfStringFormat format = new PdfStringFormat(PdfTextAlignment.Center, PdfVerticalAlignment.Middle);
            g.DrawString(title, font, brush, new RectangleF(0, 0, header.Width, header.Height), format);

            // Update description.
            brush = new PdfSolidBrush(Color.Gray);
            font = new PdfStandardFont(PdfFontFamily.Helvetica, 6, PdfFontStyle.Bold);
            format = new PdfStringFormat(PdfTextAlignment.Left, PdfVerticalAlignment.Bottom);
            g.DrawString(description, font, brush, new RectangleF(0, 0, header.Width, header.Height - 8), format);

            // Draw lines.
            PdfPen pen = new PdfPen(Color.DarkBlue, 3f);
            g.DrawLine(pen, 0, 0, header.Width, 0);
            pen = new PdfPen(Color.DarkBlue, 2f);
            g.DrawLine(pen, 0, header.Height - 4, header.Width, header.Height - 4);

            doc.Template.Top = header;
        }

        /// <summary>
        /// Gets the full path of the PDF template or image.
        /// </summary>
        /// <param name="fileName">Name of the file</param>
        /// <param name="image">True if image</param>
        /// <returns>Path of the file</returns>
        private string GetFullTemplatePath(string fileName, bool image)
        {
            string fullPath = @"..\..\..\..\..\..\..\Common\";
            string folder = image ? "Images\\PDF" : "Data";

            return string.Format(@"{0}{1}\{2}", fullPath, folder, fileName);
        }

        # endregion

        private void builtinstyles_CheckedChanged(object sender, EventArgs e)
        {
            if (this.groupBox1.Visible)
            {
                this.builtinstyles.Location = new Point(3, 167);
                this.builtinstyles.Size = new Size(80, 17);
                this.button1.Location = new Point(298, 161);
                this.button1.Size = new Size(73, 23);
                this.Size = new Size(385, 232);
                this.groupBox1.Visible = false;
            }
            else
            {
                this.builtinstyles.Location = new Point(3, 157);
                this.builtinstyles.Size = new Size(80, 17);
                this.button1.Location = new Point(298, 302);
                this.button1.Size = new Size(73, 23);
                this.Size = new Size(385, 366);  
                this.groupBox1.Visible = true;
            }           
        }
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
                return System.IO.File.ReadAllText(licenseKeyFile);
            }
            return string.Empty;
        }
    }
}

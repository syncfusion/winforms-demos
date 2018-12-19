using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Syncfusion.Pdf;
using Syncfusion.Pdf.Grid;
using Syncfusion.Pdf.Graphics;
using System.Data.SqlServerCe;
using Syncfusion.Windows.Forms;
using Syncfusion.Licensing;

namespace GridBuiltinStyle
{
    public partial class Form1 : MetroForm
    {
        # region Private Members
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;       
        private GroupBox groupBox1;
        private ComboBox comboBox1;
        private CheckBox lastColumn;
        private CheckBox bandedColumn;
        private CheckBox lastRow;
        private CheckBox firstColumn;
        private CheckBox bandedRow;
        private CheckBox headerRow;
        string styleName;
        private Label label1;

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
            this.comboBox1.SelectedIndex = 0;
            this.headerRow.Checked = true;
            this.bandedRow.Checked = true;
            this.comboBox1.SelectedIndex = 26;
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lastRow = new System.Windows.Forms.CheckBox();
            this.bandedColumn = new System.Windows.Forms.CheckBox();
            this.lastColumn = new System.Windows.Forms.CheckBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.headerRow = new System.Windows.Forms.CheckBox();
            this.bandedRow = new System.Windows.Forms.CheckBox();
            this.firstColumn = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
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
            this.button1.Location = new System.Drawing.Point(303, 263);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(72, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "PDF";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = global::GridBuiltinStyle.Properties.Resources.pdf_header;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(375, 90);
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lastRow);
            this.groupBox1.Controls.Add(this.bandedColumn);
            this.groupBox1.Controls.Add(this.lastColumn);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.headerRow);
            this.groupBox1.Controls.Add(this.bandedRow);
            this.groupBox1.Controls.Add(this.firstColumn);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.groupBox1.Location = new System.Drawing.Point(1, 148);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(374, 108);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Choose built-in style";
            // 
            // lastRow
            // 
            this.lastRow.AutoSize = true;
            this.lastRow.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastRow.Location = new System.Drawing.Point(10, 79);
            this.lastRow.Name = "lastRow";
            this.lastRow.Size = new System.Drawing.Size(66, 17);
            this.lastRow.TabIndex = 3;
            this.lastRow.Text = "Last row";
            this.lastRow.UseVisualStyleBackColor = true;
            // 
            // bandedColumn
            // 
            this.bandedColumn.AutoSize = true;
            this.bandedColumn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bandedColumn.Location = new System.Drawing.Point(142, 78);
            this.bandedColumn.Name = "bandedColumn";
            this.bandedColumn.Size = new System.Drawing.Size(100, 17);
            this.bandedColumn.TabIndex = 4;
            this.bandedColumn.Text = "Banded column";
            this.bandedColumn.UseVisualStyleBackColor = true;
            // 
            // lastColumn
            // 
            this.lastColumn.AutoSize = true;
            this.lastColumn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastColumn.Location = new System.Drawing.Point(279, 78);
            this.lastColumn.Name = "lastColumn";
            this.lastColumn.Size = new System.Drawing.Size(83, 17);
            this.lastColumn.TabIndex = 5;
            this.lastColumn.Text = "Last column";
            this.lastColumn.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "PlainTable1",
            "PlainTable2",
            "PlainTable3",
            "PlainTable4",
            "PlainTable5",
            "GridTable1Light",
            "GridTable1LightAccent1",
            "GridTable1LightAccent2",
            "GridTable1LightAccent3",
            "GridTable1LightAccent4",
            "GridTable1LightAccent5",
            "GridTable1LightAccent6",
            "GridTable2",
            "GridTable2Accent1",
            "GridTable2Accent2",
            "GridTable2Accent3",
            "GridTable2Accent4",
            "GridTable2Accent5",
            "GridTable2Accent6",
            "GridTable3",
            "GridTable3Accent1",
            "GridTable3Accent2",
            "GridTable3Accent3",
            "GridTable3Accent4",
            "GridTable3Accent5",
            "GridTable3Accent6",
            "GridTable4",
            "GridTable4Accent1",
            "GridTable4Accent2",
            "GridTable4Accent3",
            "GridTable4Accent4",
            "GridTable4Accent5",
            "GridTable4Accent6",
            "GridTable5Dark",
            "GridTable5DarkAccent1",
            "GridTable5DarkAccent2",
            "GridTable5DarkAccent3",
            "GridTable5DarkAccent4",
            "GridTable5DarkAccent5",
            "GridTable5DarkAccent6",
            "GridTable6Colorful",
            "GridTable6ColorfulAccent1",
            "GridTable6ColorfulAccent2",
            "GridTable6ColorfulAccent3",
            "GridTable6ColorfulAccent4",
            "GridTable6ColorfulAccent5",
            "GridTable6ColorfulAccent6",
            "GridTable7Colorful",
            "GridTable7ColorfulAccent1",
            "GridTable7ColorfulAccent2",
            "GridTable7ColorfulAccent3",
            "GridTable7ColorfulAccent4",
            "GridTable7ColorfulAccent5",
            "GridTable7ColorfulAccent6",
            "ListTable1Light",
            "ListTable1LightAccent1",
            "ListTable1LightAccent2",
            "ListTable1LightAccent3",
            "ListTable1LightAccent4",
            "ListTable1LightAccent5",
            "ListTable1LightAccent6",
            "ListTable2",
            "ListTable2Accent1",
            "ListTable2Accent2",
            "ListTable2Accent3",
            "ListTable2Accent4",
            "ListTable2Accent5",
            "ListTable2Accent6",
            "ListTable3",
            "ListTable3Accent1",
            "ListTable3Accent2",
            "ListTable3Accent3",
            "ListTable3Accent4",
            "ListTable3Accent5",
            "ListTable3Accent6",
            "ListTable4",
            "ListTable4Accent1",
            "ListTable4Accent2",
            "ListTable4Accent3",
            "ListTable4Accent4",
            "ListTable4Accent5",
            "ListTable4Accent6",
            "ListTable5Dark",
            "ListTable5DarkAccent1",
            "ListTable5DarkAccent2",
            "ListTable5DarkAccent3",
            "ListTable5DarkAccent4",
            "ListTable5DarkAccent5",
            "ListTable5DarkAccent6",
            "ListTable6Colorful",
            "ListTable6ColorfulAccent1",
            "ListTable6ColorfulAccent2",
            "ListTable6ColorfulAccent3",
            "ListTable6ColorfulAccent4",
            "ListTable6ColorfulAccent5",
            "ListTable6ColorfulAccent6",
            "ListTable7Colorful",
            "ListTable7ColorfulAccent1",
            "ListTable7ColorfulAccent2",
            "ListTable7ColorfulAccent3",
            "ListTable7ColorfulAccent4",
            "ListTable7ColorfulAccent5",
            "ListTable7ColorfulAccent6",
            "TableGridLight",
            "TableGrid"});
            this.comboBox1.Location = new System.Drawing.Point(8, 19);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(150, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // headerRow
            // 
            this.headerRow.AutoSize = true;
            this.headerRow.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerRow.Location = new System.Drawing.Point(9, 55);
            this.headerRow.Name = "headerRow";
            this.headerRow.Size = new System.Drawing.Size(81, 17);
            this.headerRow.TabIndex = 0;
            this.headerRow.Text = "Header row";
            this.headerRow.UseVisualStyleBackColor = true;
            // 
            // bandedRow
            // 
            this.bandedRow.AutoSize = true;
            this.bandedRow.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bandedRow.Location = new System.Drawing.Point(142, 55);
            this.bandedRow.Name = "bandedRow";
            this.bandedRow.Size = new System.Drawing.Size(83, 17);
            this.bandedRow.TabIndex = 1;
            this.bandedRow.Text = "Banded row";
            this.bandedRow.UseVisualStyleBackColor = true;
            // 
            // firstColumn
            // 
            this.firstColumn.AutoSize = true;
            this.firstColumn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstColumn.Location = new System.Drawing.Point(279, 55);
            this.firstColumn.Name = "firstColumn";
            this.firstColumn.Size = new System.Drawing.Size(82, 17);
            this.firstColumn.TabIndex = 2;
            this.firstColumn.Text = "First column";
            this.firstColumn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(-2, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(377, 52);
            this.label1.TabIndex = 1;
            this.label1.Text = "Click the button to view an PDF document generated by Essential PDF.  Please note" +
    " that Adobe Reader or its equivalent is required to view the resultant document." +
    "";
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(375, 289);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.MidnightBlue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adventure Cycle Works";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

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
            styleName=this.comboBox1.SelectedItem.ToString();

            //Create a new instance of PdfDocument class.
            PdfDocument document = new PdfDocument();

            //Set font
            PdfFont font = new PdfStandardFont(PdfFontFamily.Helvetica, 7);

            // Add a new page to the document.
            PdfPage page = document.Pages.Add();

            //Creating PdfGrid
            PdfGrid grid = new PdfGrid();             

            grid.Style.Font=font;
            DataSet dataSet = new DataSet();

            dataSet = GetAdventureWorkCycleDataSet();
         
            DataTable dt = dataSet.Tables[0];
            string[] unwantedColumns = { "Freight","EmployeeID", "OrderDate", "RequiredDate", "ShippedDate", "ShipVia", "ShipRegion" };
            foreach (string columnIndex in unwantedColumns)
            {
                dt.Columns.Remove(columnIndex);
            }

            grid.DataSource = dt;
            grid.Style.AllowHorizontalOverflow = true;

            #region PdfGridBuiltinStyleSettings
            PdfGridBuiltinStyleSettings setting = new PdfGridBuiltinStyleSettings();
            setting.ApplyStyleForBandedColumns = this.bandedColumn.Checked;
            setting.ApplyStyleForBandedRows = this.bandedRow.Checked;
            setting.ApplyStyleForFirstColumn = this.firstColumn.Checked;
            setting.ApplyStyleForHeaderRow = this.headerRow.Checked;
            setting.ApplyStyleForLastColumn = this.lastColumn.Checked;
            setting.ApplyStyleForLastRow = this.lastRow.Checked;
            #endregion 

            PdfGridLayoutFormat format = new PdfGridLayoutFormat();
            format.Break = PdfLayoutBreakType.FitPage;
            format.Layout = PdfLayoutType.Paginate;           

            PdfGridBuiltinStyle style = ConvertToPdfGridBuiltinStyle(styleName);

            //Apply Style to PdfGrid            
            grid.ApplyBuiltinStyle(style, setting);

            grid.Draw(page, PointF.Empty, format);

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
        /// Convert string to PdfGridBuiltinStyle
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        private PdfGridBuiltinStyle ConvertToPdfGridBuiltinStyle(string styleName)
        {
            PdfGridBuiltinStyle value = (PdfGridBuiltinStyle)Enum.Parse(typeof(PdfGridBuiltinStyle), styleName);
            return value;
        }

        /// <summary>
        /// Returns dataset.
        /// </summary>
        private DataSet GetAdventureWorkCycleDataSet()
        {
            DataSet dataSet = new DataSet();
            dataSet.ReadXml(GetFullTemplatePath("Orders.xml", false));
            return dataSet;
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

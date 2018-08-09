using System;
using System.Drawing;
using System.Windows.Forms;
using Syncfusion.XlsIO;
using System.ComponentModel;
using Syncfusion.Windows.Forms;
using Syncfusion.Licensing;
using System.IO;
namespace EssentialXlsIOSample
{
    public class Sorting : MetroForm
    {
        #region Constants
        private const string DEFAULTPATH = @"..\..\..\..\..\..\..\Common\Data\XlsIO\{0}";
        #endregion

        #region Fields
        string[] columnNames = { "ID", "Name", "DOJ", "Salary" };
        ExcelEngine excelEngine;
        private PictureBox pictureBox3;
        private CheckBox chkAddThirdLevel;
        private GroupBox grpThirdLevel;
        private Label label4;
        private Button btnViewTemplate;
        private ComboBox cmbFirst;
        private ComboBox cmbThird;
        private ComboBox cmbSecond;
        private GroupBox groupBox4;
        private Button btnSortColor;
        private GroupBox groupBox5;
        private RadioButton rdbOnBottom;
        private RadioButton rdbOnTop;
        private ComboBox cmbSortOn;
        private Label label1;
        OrderBy orderBy;
        SortOn sortOn;

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkAddSecondLevel;
        private System.Windows.Forms.GroupBox grpSecondLevel;
        private System.Windows.Forms.Button btnSortValues;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rdbDescending;
        private System.Windows.Forms.RadioButton rdbAscending;

        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        #endregion

        #region Initialize
        public Sorting()
        {
            InitializeComponent();
            excelEngine = new ExcelEngine();
            orderBy = OrderBy.Ascending;
            rdbAscending.Checked = true;
            cmbFirst.Items.AddRange(columnNames);
            cmbSecond.Items.AddRange(columnNames);
            cmbThird.Items.AddRange(columnNames);
            cmbSortOn.SelectedIndex = 0;
            sortOn = SortOn.CellColor;
            cmbFirst.SelectedIndex = 0;
            cmbSecond.SelectedIndex = 0;
            cmbThird.SelectedIndex = 0;

        }
        #endregion

        #region Sorting
        #region Value based Sort
        private void btnSortValues_Click(object sender, EventArgs e)
        {
            orderBy = (rdbAscending.Checked) ? OrderBy.Ascending : OrderBy.Descending;
            SortValues("ValueSort.xlsx");
            OpenOutput("ValueSort.xlsx");
        }
        #endregion

        #region Color Based Sort
        private void btnSortColor_Click(object sender, EventArgs e)
        {
            orderBy = (rdbOnTop.Checked) ? OrderBy.OnTop : OrderBy.OnBottom;

            SortColor("ColorSort.xlsx");
            OpenOutput("ColorSort.xlsx");
        }
        #endregion

        #region View the Input file
        private void btnViewTemplate_Click(object sender, EventArgs e)
        {
            //Get the path of the input file
            string inputPath = GetFullTemplatePath("SortingData.xlsx");
            //Launching the Excel file using the default Application.[MS Excel Or Free ExcelViewer]
            System.Diagnostics.Process.Start(inputPath);
        }
        #endregion

        #region Set the SecondLevel Visibility (Based on Values Type)
        private void chkAddSecondLevel_CheckedChanged(object sender, EventArgs e)
        {
            grpSecondLevel.Visible = chkAddSecondLevel.Checked;
            chkAddThirdLevel.Visible = chkAddSecondLevel.Checked;

        }
        #endregion

        #region Set the Visibilty Third Level (Based on Values Type)
        private void chkAddThirdLevel_CheckedChanged(object sender, EventArgs e)
        {
            grpThirdLevel.Visible = chkAddThirdLevel.Checked;
        }
        #endregion

        #region Setting the Sort type (Based on Color Type)
        private void cmbSortOn_SelectedIndexChanged(object sender, EventArgs e)
        {
            sortOn = (cmbSortOn.SelectedIndex == 0) ? SortOn.CellColor : SortOn.FontColor;
        }
        #endregion

        #region Dispose the Excel Engine
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            excelEngine.Dispose();
        }
        #endregion
        #endregion

        #region HelperMethods

        #region Get File Path
        /// <summary>
        /// Get the file path of input file and return the same
        /// </summary>
        /// <param name="inputPath">Input file</param>
        /// <returns>path of the input file</returns>
        private string GetFullTemplatePath(string inputFile)
        {
            return string.Format(DEFAULTPATH, inputFile);
        }
        #endregion

        #region Method for Sorting using Color
        private void SortColor(string outFileName)
        {
            #region Workbook Initialize
            //Get the path of Input File
            string inputPath = GetFullTemplatePath("SortingData.xlsx");
            IWorkbook workbook = excelEngine.Excel.Workbooks.Open(inputPath, ExcelOpenType.Automatic);
            IWorksheet worksheet = workbook.Worksheets[1];
            #endregion

            #region Sorting Based on Colors
            IRange range = worksheet["A2:C50"];
            IDataSort sorter = workbook.CreateDataSorter();
            sorter.SortRange = range;
            ISortField field = sorter.SortFields.Add(2, sortOn, orderBy);
            field.Color = Color.Red;
            field = sorter.SortFields.Add(2, sortOn, orderBy);
            field.Color = Color.Blue;

            sorter.Sort();
            #endregion

            #region Worksheet Remove
            workbook.Worksheets.Remove(0);
            #endregion

            #region Workbook Save and Close
            workbook.SaveAs(outFileName);
            workbook.Close();
            #endregion

        }
        #endregion

        #region Method for Sorting using Values
        private void SortValues(string outFileName)
        {
            #region Workbook Initialize
            //Get the path of the input file
            string inputPath = GetFullTemplatePath("SortingData.xlsx");
            IWorkbook workbook = excelEngine.Excel.Workbooks.Open(inputPath, ExcelOpenType.Automatic);
            IWorksheet worksheet = workbook.Worksheets[0];

            #endregion

            #region Sorting Based on Values
            IRange range = worksheet["A2:D51"];

            //Create the data sorter.
            IDataSort sorter = workbook.CreateDataSorter();
            //Specify the range to sort.
            sorter.SortRange = range;

            //Specify the sort field attributes (column index and sort order)
            ISortField field = sorter.SortFields.Add((int)cmbFirst.SelectedIndex, SortOn.Values, orderBy);


            if (chkAddSecondLevel.Checked)
            {
                field = sorter.SortFields.Add((int)cmbSecond.SelectedIndex, SortOn.Values, orderBy);
            }

            if (chkAddThirdLevel.Checked)
            {
                field = sorter.SortFields.Add((int)cmbThird.SelectedIndex, SortOn.Values, orderBy);
            }

            //sort the data based on the sort field attributes.
            sorter.Sort();
            #endregion

            #region Remove the Worksheet
            workbook.Worksheets.Remove(1);
            #endregion

            #region Workbook Save and Close
            workbook.SaveAs(outFileName);
            workbook.Close();
            #endregion
        }
        #endregion

        #region Open the Output File
        private void OpenOutput(string fileName)
        {
            // Message box confirmation to view the created document.
            if (MessageBox.Show("Do you want to view the workbook?", "Workbook has been created",
            MessageBoxButtons.YesNo, MessageBoxIcon.Information)
            == DialogResult.Yes)
            {
                try
                {
                    //Launching the Excel file using the default Application.[MS Excel Or Free ExcelViewer]
                    System.Diagnostics.Process.Start(fileName);

                    //Exit
                    this.Close();
                }
                catch (Win32Exception ex)
                {
                    MessageBox.Show("Excel 2007 is not installed in this system");
                    Console.WriteLine(ex.ToString());
                }
            }
            else
                this.Close();
        }
        #endregion

        #endregion

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sorting));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cmbSortOn = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSortColor = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.rdbOnBottom = new System.Windows.Forms.RadioButton();
            this.rdbOnTop = new System.Windows.Forms.RadioButton();
            this.btnViewTemplate = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbFirst = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rdbDescending = new System.Windows.Forms.RadioButton();
            this.rdbAscending = new System.Windows.Forms.RadioButton();
            this.chkAddThirdLevel = new System.Windows.Forms.CheckBox();
            this.btnSortValues = new System.Windows.Forms.Button();
            this.grpThirdLevel = new System.Windows.Forms.GroupBox();
            this.cmbThird = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.chkAddSecondLevel = new System.Windows.Forms.CheckBox();
            this.grpSecondLevel = new System.Windows.Forms.GroupBox();
            this.cmbSecond = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.grpThirdLevel.SuspendLayout();
            this.grpSecondLevel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.btnViewTemplate);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 98);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(424, 369);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sorting";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cmbSortOn);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.btnSortColor);
            this.groupBox4.Controls.Add(this.groupBox5);
            this.groupBox4.Location = new System.Drawing.Point(9, 245);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(406, 91);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Sort Based on Colors";
            // 
            // cmbSortOn
            // 
            this.cmbSortOn.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSortOn.FormattingEnabled = true;
            this.cmbSortOn.Items.AddRange(new object[] {
            "CellColor",
            "FontColor"});
            this.cmbSortOn.Location = new System.Drawing.Point(276, 25);
            this.cmbSortOn.Name = "cmbSortOn";
            this.cmbSortOn.Size = new System.Drawing.Size(121, 21);
            this.cmbSortOn.TabIndex = 4;
            this.cmbSortOn.SelectedIndexChanged += new System.EventHandler(this.cmbSortOn_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(208, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Sort On";
            // 
            // btnSortColor
            // 
            this.btnSortColor.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSortColor.Location = new System.Drawing.Point(315, 63);
            this.btnSortColor.Name = "btnSortColor";
            this.btnSortColor.Size = new System.Drawing.Size(82, 23);
            this.btnSortColor.TabIndex = 2;
            this.btnSortColor.Text = "Sort Colors";
            this.btnSortColor.UseVisualStyleBackColor = true;
            this.btnSortColor.Click += new System.EventHandler(this.btnSortColor_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.rdbOnBottom);
            this.groupBox5.Controls.Add(this.rdbOnTop);
            this.groupBox5.Location = new System.Drawing.Point(9, 20);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(132, 66);
            this.groupBox5.TabIndex = 0;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Order By";
            // 
            // rdbOnBottom
            // 
            this.rdbOnBottom.AutoSize = true;
            this.rdbOnBottom.Location = new System.Drawing.Point(6, 43);
            this.rdbOnBottom.Name = "rdbOnBottom";
            this.rdbOnBottom.Size = new System.Drawing.Size(82, 17);
            this.rdbOnBottom.TabIndex = 1;
            this.rdbOnBottom.TabStop = true;
            this.rdbOnBottom.Text = "OnBottom";
            this.rdbOnBottom.UseVisualStyleBackColor = true;
            // 
            // rdbOnTop
            // 
            this.rdbOnTop.AutoSize = true;
            this.rdbOnTop.Checked = true;
            this.rdbOnTop.Location = new System.Drawing.Point(6, 20);
            this.rdbOnTop.Name = "rdbOnTop";
            this.rdbOnTop.Size = new System.Drawing.Size(61, 17);
            this.rdbOnTop.TabIndex = 0;
            this.rdbOnTop.TabStop = true;
            this.rdbOnTop.Text = "OnTop";
            this.rdbOnTop.UseVisualStyleBackColor = true;
            // 
            // btnViewTemplate
            // 
            this.btnViewTemplate.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewTemplate.Location = new System.Drawing.Point(312, 341);
            this.btnViewTemplate.Name = "btnViewTemplate";
            this.btnViewTemplate.Size = new System.Drawing.Size(100, 25);
            this.btnViewTemplate.TabIndex = 4;
            this.btnViewTemplate.Text = "Input Template";
            this.btnViewTemplate.UseVisualStyleBackColor = true;
            this.btnViewTemplate.Click += new System.EventHandler(this.btnViewTemplate_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmbFirst);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.chkAddThirdLevel);
            this.groupBox2.Controls.Add(this.btnSortValues);
            this.groupBox2.Controls.Add(this.grpThirdLevel);
            this.groupBox2.Controls.Add(this.chkAddSecondLevel);
            this.groupBox2.Controls.Add(this.grpSecondLevel);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(6, 20);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(409, 219);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sort Based on Values";
            // 
            // cmbFirst
            // 
            this.cmbFirst.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFirst.FormattingEnabled = true;
            this.cmbFirst.Location = new System.Drawing.Point(255, 20);
            this.cmbFirst.Name = "cmbFirst";
            this.cmbFirst.Size = new System.Drawing.Size(65, 21);
            this.cmbFirst.TabIndex = 10;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rdbDescending);
            this.groupBox3.Controls.Add(this.rdbAscending);
            this.groupBox3.Location = new System.Drawing.Point(6, 146);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(154, 64);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "OrderBy";
            // 
            // rdbDescending
            // 
            this.rdbDescending.AutoSize = true;
            this.rdbDescending.Location = new System.Drawing.Point(6, 36);
            this.rdbDescending.Name = "rdbDescending";
            this.rdbDescending.Size = new System.Drawing.Size(90, 17);
            this.rdbDescending.TabIndex = 1;
            this.rdbDescending.TabStop = true;
            this.rdbDescending.Text = "Descending";
            this.rdbDescending.UseVisualStyleBackColor = true;
            // 
            // rdbAscending
            // 
            this.rdbAscending.AutoSize = true;
            this.rdbAscending.Location = new System.Drawing.Point(6, 13);
            this.rdbAscending.Name = "rdbAscending";
            this.rdbAscending.Size = new System.Drawing.Size(83, 17);
            this.rdbAscending.TabIndex = 0;
            this.rdbAscending.TabStop = true;
            this.rdbAscending.Text = "Ascending";
            this.rdbAscending.UseVisualStyleBackColor = true;
            // 
            // chkAddThirdLevel
            // 
            this.chkAddThirdLevel.AutoSize = true;
            this.chkAddThirdLevel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAddThirdLevel.Location = new System.Drawing.Point(333, 61);
            this.chkAddThirdLevel.Name = "chkAddThirdLevel";
            this.chkAddThirdLevel.Size = new System.Drawing.Size(73, 17);
            this.chkAddThirdLevel.TabIndex = 9;
            this.chkAddThirdLevel.Text = "Add Level";
            this.chkAddThirdLevel.UseVisualStyleBackColor = true;
            this.chkAddThirdLevel.Visible = false;
            this.chkAddThirdLevel.CheckedChanged += new System.EventHandler(this.chkAddThirdLevel_CheckedChanged);
            // 
            // btnSortValues
            // 
            this.btnSortValues.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSortValues.Location = new System.Drawing.Point(318, 179);
            this.btnSortValues.Name = "btnSortValues";
            this.btnSortValues.Size = new System.Drawing.Size(85, 23);
            this.btnSortValues.TabIndex = 2;
            this.btnSortValues.Text = "Sort Values";
            this.btnSortValues.UseVisualStyleBackColor = true;
            this.btnSortValues.Click += new System.EventHandler(this.btnSortValues_Click);
            // 
            // grpThirdLevel
            // 
            this.grpThirdLevel.Controls.Add(this.cmbThird);
            this.grpThirdLevel.Controls.Add(this.label4);
            this.grpThirdLevel.Location = new System.Drawing.Point(6, 92);
            this.grpThirdLevel.Name = "grpThirdLevel";
            this.grpThirdLevel.Size = new System.Drawing.Size(322, 48);
            this.grpThirdLevel.TabIndex = 8;
            this.grpThirdLevel.TabStop = false;
            this.grpThirdLevel.Text = "Level";
            this.grpThirdLevel.Visible = false;
            // 
            // cmbThird
            // 
            this.cmbThird.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbThird.FormattingEnabled = true;
            this.cmbThird.Location = new System.Drawing.Point(249, 17);
            this.cmbThird.Name = "cmbThird";
            this.cmbThird.Size = new System.Drawing.Size(65, 21);
            this.cmbThird.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(224, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Choose the thrird column index to sort";
            // 
            // chkAddSecondLevel
            // 
            this.chkAddSecondLevel.AutoSize = true;
            this.chkAddSecondLevel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAddSecondLevel.Location = new System.Drawing.Point(333, 24);
            this.chkAddSecondLevel.Name = "chkAddSecondLevel";
            this.chkAddSecondLevel.Size = new System.Drawing.Size(70, 17);
            this.chkAddSecondLevel.TabIndex = 7;
            this.chkAddSecondLevel.Text = "AddLevel";
            this.chkAddSecondLevel.UseVisualStyleBackColor = true;
            this.chkAddSecondLevel.CheckedChanged += new System.EventHandler(this.chkAddSecondLevel_CheckedChanged);
            // 
            // grpSecondLevel
            // 
            this.grpSecondLevel.Controls.Add(this.cmbSecond);
            this.grpSecondLevel.Controls.Add(this.label3);
            this.grpSecondLevel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpSecondLevel.Location = new System.Drawing.Point(6, 47);
            this.grpSecondLevel.Name = "grpSecondLevel";
            this.grpSecondLevel.Size = new System.Drawing.Size(322, 45);
            this.grpSecondLevel.TabIndex = 6;
            this.grpSecondLevel.TabStop = false;
            this.grpSecondLevel.Text = "Level";
            this.grpSecondLevel.Visible = false;
            // 
            // cmbSecond
            // 
            this.cmbSecond.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSecond.FormattingEnabled = true;
            this.cmbSecond.Location = new System.Drawing.Point(249, 14);
            this.cmbSecond.Name = "cmbSecond";
            this.cmbSecond.Size = new System.Drawing.Size(65, 21);
            this.cmbSecond.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(236, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Choose the Second column index to sort.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(219, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Choose the First column Index to sort";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(0, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(639, 71);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 74;
            this.pictureBox3.TabStop = false;
            // 
            // Sorting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(430, 470);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Sorting";
            this.Text = "Sorting";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.grpThirdLevel.ResumeLayout(false);
            this.grpThirdLevel.PerformLayout();
            this.grpSecondLevel.ResumeLayout(false);
            this.grpSecondLevel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        #region Dispose
        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
			SyncfusionLicenseProvider.RegisterLicense(DemoCommon.FindLicenseKey());
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Sorting());
        }
        #endregion
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
                return File.ReadAllText(licenseKeyFile);
            }
            return string.Empty;
        }
    }
}

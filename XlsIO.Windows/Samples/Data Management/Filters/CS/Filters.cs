using System;
using System.Drawing;
using System.Windows.Forms;
using Syncfusion.XlsIO;
using System.ComponentModel;
using Syncfusion.Windows.Forms;
using System.Collections.Generic;
using System.Reflection;
using Syncfusion.Licensing;
using System.IO;
namespace EssentialXlsIOSample
{
    public class Filters : MetroForm
    {
        #region Constants
        private const string DEFAULTPATH = @"..\..\..\..\..\..\..\Common\Data\XlsIO\{0}";
        #endregion

        #region Fields
        string[] filterType = { "Custom Filter", "Text Filter", "DateTime Filter", "Dynamic Filter","Color Filter", "Icon Filter", "Advanced Filter" };
        ExcelEngine excelEngine;
        private PictureBox pictureBox3;
        private Button btnViewTemplate;

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnFilterData;
        private Label label2;
        private ComboBox cmbFirst;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private RadioButton rdbFilterInPlace;
        private RadioButton rdbFilterCopy;
        private CheckBox cbisUnique;
        private GroupBox groupBox4;
        private GroupBox groupBox5;
        private RadioButton radioButton4;
        private RadioButton radioButton3;
        private Label label3;
        private ComboBox comboBox1;
        private Label label1;
        private Label label4;
        private Label label5;
        private ComboBox comboBox3;
        private GroupBox groupBox6;
        private List<Image> imageList1 = new List<Image>();
        private ImageList imageList;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv comboBoxAdv1;

        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        #endregion

        #region Initialize
        public Filters()
        {
            InitializeComponent();
            excelEngine = new ExcelEngine();
            foreach (string filter in filterType)
            {
                cmbFirst.Items.Add(filter);
            }
            cmbFirst.SelectedIndex = 0;
        }
        #endregion
        

        #region View the Input file
        private void btnViewTemplate_Click(object sender, EventArgs e)
        {
            string inputPath;
            //Get the path of the input file

            if (cmbFirst.SelectedIndex == 6)
            {
                inputPath = GetFullTemplatePath("AdvancedFilterData.xlsx");
            }
            else if(cmbFirst.SelectedIndex == 5)
            {
                inputPath = GetFullTemplatePath("IconFilterData.xlsx");
            }
            else if(cmbFirst.SelectedIndex == 4)
            {
                inputPath = GetFullTemplatePath("FilterData_Color.xlsx");
            }
            else
            {
                inputPath = GetFullTemplatePath("FilterData.xlsx");
            }
            //Launching the Excel file using the default Application.[MS Excel Or Free ExcelViewer]
            System.Diagnostics.Process.Start(inputPath);
        }
        #endregion

        #region Filter Data

        private void btnFilterData_Click(object sender, EventArgs e)
        {
            string fileName;
            if (cmbFirst.SelectedIndex == 6)
            {
                fileName = "AdvancedFilterData.xlsx";
            }
            else if(cmbFirst.SelectedIndex == 5)
            {
                fileName = "IconFilterData.xlsx";
            }
            else if(cmbFirst.SelectedIndex == 4)
            {
                fileName = "FilterData_Color.xlsx";
            }
            else
            {
                fileName = "FilterData.xlsx";
            }
            FilterData(fileName);
            OpenOutput(fileName);
        }

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
                
        #region Method for Sorting using Values
        private void FilterData(string outFileName)
        {
            #region Workbook Initialize
            //Get the path of the input file
            string inputPath = GetFullTemplatePath(outFileName);
            IWorkbook workbook = excelEngine.Excel.Workbooks.Open(inputPath, ExcelOpenType.Automatic);
            IWorksheet sheet = workbook.Worksheets[0];

            #endregion

            int columnIndex = cmbFirst.SelectedIndex;
            if (columnIndex != 6)
            {
                sheet.AutoFilters.FilterRange = sheet.Range[1, 1, 49, 3];

            }
            switch (columnIndex)
            {
                case 0:
                    IAutoFilter filter1 = sheet.AutoFilters[0];
                    filter1.IsAnd = false;
                    filter1.FirstCondition.ConditionOperator = ExcelFilterCondition.Equal;
                    filter1.FirstCondition.DataType = ExcelFilterDataType.String;
                    filter1.FirstCondition.String = "Owner";

                    filter1.SecondCondition.ConditionOperator = ExcelFilterCondition.Equal;
                    filter1.SecondCondition.DataType = ExcelFilterDataType.String;
                    filter1.SecondCondition.String = "Sales Representative";
                    break;

                case 1:
                    IAutoFilter filter2 = sheet.AutoFilters[0];
                    filter2.AddTextFilter(new string[] { "Owner", "Sales Representative", "Sales Associate" });
                    break;

                case 2:
                    IAutoFilter filter3 = sheet.AutoFilters[1];
                    filter3.AddDateFilter(new DateTime(2004, 9, 1, 1, 0, 0, 0), DateTimeGroupingType.month);
                    filter3.AddDateFilter(new DateTime(2011, 1, 1, 1, 0, 0, 0), DateTimeGroupingType.year);
                    break;
                case 4:
                    #region Color Filter
                    sheet.AutoFilters.FilterRange = sheet["A1:C49"];
                    Color color = Color.Empty;
                    switch (comboBox1.SelectedIndex)
                    {
                        case 0:
                            color = Color.Red;
                            break;
                        case 1:
                            color = Color.Blue;
                            break;
                        case 2:
                            color = Color.Green;
                            break;
                        case 3:
                            color = Color.Yellow;
                            break;
                        case 4:
                            //Do nothing.
                            break;
                    }
                    if (radioButton3.Checked)
                    {
                        IAutoFilter filter = sheet.AutoFilters[0];
                        filter.AddColorFilter(color, ExcelColorFilterType.CellColor);
                    }
                    else
                    {
                        IAutoFilter filter = sheet.AutoFilters[2];
                        filter.AddColorFilter(color, ExcelColorFilterType.FontColor);
                    }

                    #endregion

                    break;

                case 5:
                    #region IconFilter

                    sheet.AutoFilters.FilterRange = sheet["A4:D44"];
                    ExcelIconSetType iconset = ExcelIconSetType.ThreeSymbols;
                    int iconId = 0;
                    int filterIndex = 0;
                    bool IdNotSelected = false;
                    switch(this.comboBox3.SelectedIndex)
                    {
                        case 0:
                            iconset = ExcelIconSetType.ThreeSymbols;
                            filterIndex = 3;
                            break;
                        case 1:
                            iconset = ExcelIconSetType.FourRating;
                            filterIndex = 1;
                            break;
                        case 2:
                            iconset = ExcelIconSetType.FiveArrows;
                            filterIndex = 2;
                            break;
                    }
                    switch(this.comboBoxAdv1.SelectedIndex)
                    {
                        case 0:
                            //Do nothing
                            break;
                        case 1:
                            iconId = 1;
                            break;
                        case 2:
                            iconId = 2;
                            break;
                        case 3:
                            if (comboBox3.SelectedIndex == 0)
                                iconset = (ExcelIconSetType)(-1);
                            else
                                iconId = 3;
                            break;
                        case 4:
                            if (comboBox3.SelectedIndex == 1)
                                iconset = (ExcelIconSetType)(-1);
                            else
                                iconId = 4;
                            break;
                        case 5:
                            iconset = (ExcelIconSetType)(-1);
                            break;

                        default:
                            MessageBox.Show("Please Select an Icon!");
                            IdNotSelected = true;
                            break;
                    }

                    
                    if(!IdNotSelected)
                    {
                        IAutoFilter filter = sheet.AutoFilters[filterIndex];
                        filter.AddIconFilter(iconset, iconId);
                    }

                    #endregion

                    break;
                case 6:
                    #region AdvancedFilter

                    IRange filterRange = sheet.Range["A8:G51"];
                    IRange criteriaRange = sheet.Range["A2:B5"];
                    if (rdbFilterInPlace.Checked)
                    {
                        sheet.AdvancedFilter(ExcelFilterAction.FilterInPlace, filterRange, criteriaRange, null, cbisUnique.Checked);
                    }
                    else if (rdbFilterCopy.Checked)
                    {
                        IRange range = sheet.Range["I7:O7"];
                        range.Merge();
                        range.Text = "FilterCopy";
                        range.CellStyle.Font.RGBColor = Color.FromArgb(0, 112, 192);
                        range.HorizontalAlignment = ExcelHAlign.HAlignCenter;
                        range.CellStyle.Font.Bold = true;
                        IRange copyRange = sheet.Range["I8"];
                        sheet.AdvancedFilter(ExcelFilterAction.FilterCopy, filterRange, criteriaRange, copyRange, cbisUnique.Checked);
                    }
                    #endregion

                    break;
                default:
                case 3:
                    IAutoFilter filter4 = sheet.AutoFilters[1];
                    filter4.AddDynamicFilter(DynamicFilterType.Quarter1);
                    break;
            }

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
                    //this.Close();
                }
                catch (Win32Exception ex)
                {
                    MessageBox.Show("Excel 2007 is not installed in this system");
                    Console.WriteLine(ex.ToString());
                }
            }
            //else
            //    this.Close();
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Filters));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbisUnique = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rdbFilterCopy = new System.Windows.Forms.RadioButton();
            this.rdbFilterInPlace = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbFirst = new System.Windows.Forms.ComboBox();
            this.btnViewTemplate = new System.Windows.Forms.Button();
            this.btnFilterData = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.comboBoxAdv1 = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxAdv1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmbFirst);
            this.groupBox1.Controls.Add(this.btnViewTemplate);
            this.groupBox1.Controls.Add(this.btnFilterData);
            this.groupBox1.Location = new System.Drawing.Point(4, 202);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(473, 291);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filters";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.groupBox5);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.comboBox1);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(45, 85);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox4.Size = new System.Drawing.Size(381, 129);
            this.groupBox4.TabIndex = 78;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Color Filter";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.radioButton4);
            this.groupBox5.Controls.Add(this.radioButton3);
            this.groupBox5.Location = new System.Drawing.Point(17, 25);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox5.Size = new System.Drawing.Size(192, 86);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Filter Type";
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton4.Location = new System.Drawing.Point(36, 25);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(112, 24);
            this.radioButton4.TabIndex = 0;
            this.radioButton4.Text = "Font Color";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton3.Location = new System.Drawing.Point(36, 55);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(108, 24);
            this.radioButton3.TabIndex = 1;
            this.radioButton3.Text = "Cell Color";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(217, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Color";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Red",
            "Blue",
            "Green",
            "Yellow",
            "Empty"});
            this.comboBox1.Location = new System.Drawing.Point(266, 56);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.comboBox1.Size = new System.Drawing.Size(100, 28);
            this.comboBox1.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbisUnique);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Enabled = false;
            this.groupBox2.Location = new System.Drawing.Point(45, 85);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox2.Size = new System.Drawing.Size(381, 129);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Advanced Filter";
            // 
            // cbisUnique
            // 
            this.cbisUnique.AutoSize = true;
            this.cbisUnique.Location = new System.Drawing.Point(225, 87);
            this.cbisUnique.Name = "cbisUnique";
            this.cbisUnique.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cbisUnique.Size = new System.Drawing.Size(150, 24);
            this.cbisUnique.TabIndex = 1;
            this.cbisUnique.Text = "Unique Records";
            this.cbisUnique.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rdbFilterCopy);
            this.groupBox3.Controls.Add(this.rdbFilterInPlace);
            this.groupBox3.Location = new System.Drawing.Point(17, 25);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox3.Size = new System.Drawing.Size(192, 86);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Filter Action";
            // 
            // rdbFilterCopy
            // 
            this.rdbFilterCopy.AutoSize = true;
            this.rdbFilterCopy.Location = new System.Drawing.Point(36, 55);
            this.rdbFilterCopy.Name = "rdbFilterCopy";
            this.rdbFilterCopy.Size = new System.Drawing.Size(109, 24);
            this.rdbFilterCopy.TabIndex = 1;
            this.rdbFilterCopy.TabStop = true;
            this.rdbFilterCopy.Text = "Filter Copy";
            this.rdbFilterCopy.UseVisualStyleBackColor = true;
            // 
            // rdbFilterInPlace
            // 
            this.rdbFilterInPlace.AutoSize = true;
            this.rdbFilterInPlace.Location = new System.Drawing.Point(36, 25);
            this.rdbFilterInPlace.Name = "rdbFilterInPlace";
            this.rdbFilterInPlace.Size = new System.Drawing.Size(130, 24);
            this.rdbFilterInPlace.TabIndex = 0;
            this.rdbFilterInPlace.TabStop = true;
            this.rdbFilterInPlace.Text = "Filter In Place";
            this.rdbFilterInPlace.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 40);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Choose the filter type";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbFirst
            // 
            this.cmbFirst.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFirst.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFirst.FormattingEnabled = true;
            this.cmbFirst.Location = new System.Drawing.Point(260, 36);
            this.cmbFirst.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbFirst.Name = "cmbFirst";
            this.cmbFirst.Size = new System.Drawing.Size(166, 29);
            this.cmbFirst.TabIndex = 10;
            this.cmbFirst.SelectedIndexChanged += new System.EventHandler(this.cmbFirst_SelectedIndexChanged);
            // 
            // btnViewTemplate
            // 
            this.btnViewTemplate.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewTemplate.Location = new System.Drawing.Point(45, 233);
            this.btnViewTemplate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnViewTemplate.Name = "btnViewTemplate";
            this.btnViewTemplate.Size = new System.Drawing.Size(171, 38);
            this.btnViewTemplate.TabIndex = 4;
            this.btnViewTemplate.Text = "Input Template";
            this.btnViewTemplate.UseVisualStyleBackColor = true;
            this.btnViewTemplate.Click += new System.EventHandler(this.btnViewTemplate_Click);
            // 
            // btnFilterData
            // 
            this.btnFilterData.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFilterData.Location = new System.Drawing.Point(255, 233);
            this.btnFilterData.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnFilterData.Name = "btnFilterData";
            this.btnFilterData.Size = new System.Drawing.Size(171, 38);
            this.btnFilterData.TabIndex = 2;
            this.btnFilterData.Text = "Filter Data";
            this.btnFilterData.UseVisualStyleBackColor = true;
            this.btnFilterData.Click += new System.EventHandler(this.btnFilterData_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(4, 2);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(473, 110);
            this.pictureBox3.TabIndex = 74;
            this.pictureBox3.TabStop = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(4, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(473, 86);
            this.label1.TabIndex = 74;
            this.label1.Text = "Click the button to view an Excel spreadsheet generated by Essential XlsIO. Pleas" +
    "e note that MS Excel Viewer or MS Excel is required to view the resultant docume" +
    "nt.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(223, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Icon";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "IconSet";
            // 
            // comboBox3
            // 
            this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "ThreeSymbols",
            "FourRatings",
            "FiveArrows"});
            this.comboBox3.Location = new System.Drawing.Point(75, 56);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.comboBox3.Size = new System.Drawing.Size(144, 28);
            this.comboBox3.TabIndex = 5;
            this.comboBox3.SelectedIndex = 2;
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.IconSet_Changed);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.comboBoxAdv1);
            this.groupBox6.Controls.Add(this.comboBox3);
            this.groupBox6.Controls.Add(this.label5);
            this.groupBox6.Controls.Add(this.label4);
            this.groupBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.Location = new System.Drawing.Point(51, 285);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox6.Size = new System.Drawing.Size(381, 129);
            this.groupBox6.TabIndex = 79;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Icon Filter";
            // 
            // comboBoxAdv1
            // 
            this.comboBoxAdv1.AllowDrop = true;
            this.comboBoxAdv1.AllowNewText = false;
            this.comboBoxAdv1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(245)))), ((int)(((byte)(253)))));
            this.comboBoxAdv1.BeforeTouchSize = new System.Drawing.Size(100, 28);
            this.comboBoxAdv1.Border3DStyle = System.Windows.Forms.Border3DStyle.Flat;
            this.comboBoxAdv1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAdv1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxAdv1.ForceImageIndent = true;
            this.comboBoxAdv1.ImageList = this.imageList;
            this.comboBoxAdv1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.comboBoxAdv1.IntegralHeight = false;
            this.comboBoxAdv1.Location = new System.Drawing.Point(265, 56);
            this.comboBoxAdv1.Margin = new System.Windows.Forms.Padding(1, 3, 3, 3);
            this.comboBoxAdv1.MaxDropDownItems = 10;
            this.comboBoxAdv1.Name = "comboBoxAdv1";
            this.comboBoxAdv1.Office2007ColorTheme = Syncfusion.Windows.Forms.Office2007Theme.Black;
            this.comboBoxAdv1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.comboBoxAdv1.ShowImageInTextBox = true;
            this.comboBoxAdv1.ShowImagesInComboListBox = true;
            this.comboBoxAdv1.Size = new System.Drawing.Size(100, 28);
            this.comboBoxAdv1.Style = Syncfusion.Windows.Forms.VisualStyle.Office2010;
            this.comboBoxAdv1.TabIndex = 80;
            this.comboBoxAdv1.Text = "1";
            this.comboBoxAdv1.ListBox.DrawItem += new DrawItemEventHandler(ListBox_DrawItem);
            // 
            // imageList
            // 
            this.imageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            InitBox();
            // 
            // Filters
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(480, 496);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "Filters";
            this.Text = "Filters";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxAdv1)).EndInit();
            this.ResumeLayout(false);

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
            Application.Run(new Filters());
        }
        #endregion

        private void cmbFirst_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbFirst.SelectedIndex == 6)
            {
                //this.groupBox1.Size = new System.Drawing.Size(636, 290);
                this.groupBox2.Enabled = true;
                this.groupBox2.Visible = true;
                this.groupBox4.Enabled = false;
                this.groupBox4.Visible = false;
                this.groupBox5.Enabled = false;
                this.groupBox5.Visible = false;
                this.groupBox6.Visible = false;
                this.groupBox6.Enabled = false;
                this.rdbFilterInPlace.Checked = true;
                this.rdbFilterCopy.Checked = false;
                this.cbisUnique.Checked = false;

            }
            else if (cmbFirst.SelectedIndex == 4)
            {
                this.groupBox2.Enabled = false;
                this.groupBox2.Visible = false;
                this.groupBox4.Enabled = true;
                this.groupBox4.Visible = true;
                this.groupBox5.Enabled = true;
                this.groupBox5.Visible = true;
                this.groupBox6.Visible = false;
                this.comboBox1.Text = "Red";
                this.radioButton4.Checked = true;
            }
            else if(cmbFirst.SelectedIndex == 5)
            {
                this.groupBox2.Enabled = false;
                this.groupBox2.Visible = false;
                this.groupBox4.Enabled = false;
                this.groupBox4.Visible = false;
                this.groupBox5.Enabled = false;
                this.groupBox5.Visible = false;
                this.groupBox6.Visible = true;
                this.groupBox6.Enabled = true;
            }
            else
            {
                this.groupBox2.Enabled = false;
                this.groupBox2.Visible = true;
                this.groupBox4.Enabled = false;
                this.groupBox4.Visible = false;
                this.groupBox5.Enabled = false;
                this.groupBox5.Visible = false;
                this.groupBox6.Visible = false;
            }
        }

        private void ListBox_DrawItem(object sender, DrawItemEventArgs e)
        {
            ListBox list = sender as ListBox;
            string text = list.Items[e.Index].ToString();
            if (e.Index < 0)
                return;
            list.ItemHeight = 13;
            Rectangle Bounds = new Rectangle(30, 1, 10, 10);
            if (list.Items[0].ToString() == text)
            {
                //To Draw the image in listBox
                e.Graphics.DrawImage(this.imageList.Images[0], Bounds);
            }
            Bounds.Y += 12;
            if (list.Items[1].ToString() == text)
            {
                e.Graphics.DrawImage(this.imageList.Images[1], Bounds);
            }
            Bounds.Y += 12;
            if (list.Items[2].ToString() == text)
            {
                e.Graphics.DrawImage(this.imageList.Images[2], Bounds);
            }
            Bounds.Y += 12;
            if (comboBox3.SelectedIndex == 1 || comboBox3.SelectedIndex == 2)
            {
                if (list.Items[3].ToString() == text)
                {
                    e.Graphics.DrawImage(this.imageList.Images[3], Bounds);
                }
                Bounds.Y += 12;
                if (comboBox3.SelectedIndex == 2)
                {
                    if (list.Items[4].ToString() == text)
                    {
                        e.Graphics.DrawImage(this.imageList.Images[0], Bounds);
                    }
                    Bounds.Y += 12;
                }
            }
            //this.comboBoxAdv1.ListBox.Size = new Size(63, 47);
        }
        private void IconSet_Changed(object sender, EventArgs e)
        {
            if (comboBox3.SelectedIndex == 0)
            {
                imageList.Images.Clear();
                this.imageList.Images.Add(Image.FromFile(@"../../Data/CF_IS_RedCrossSymbol.png"));
                this.imageList.Images.Add(Image.FromFile(@"../../Data/CF_IS_YellowExclamationSymbol.png"));
                this.imageList.Images.Add(Image.FromFile(@"../../Data/CF_IS_GreenCheckSymbol.png"));
                this.comboBoxAdv1.Items.Clear();
                this.comboBoxAdv1.Items.AddRange(new object[] { "1", "2", "3", "NoIcon" });
                //this.comboBoxAdv1.SelectedIndex = 0;
            }
            else if (comboBox3.SelectedIndex == 1)
            {
                imageList.Images.Clear();
                imageList.Images.Add(Image.FromFile(@"../../Data/CF_IS_SignalWithOneFillBar.png"));
                imageList.Images.Add(Image.FromFile(@"../../Data/CF_IS_SignalWithTwoFillBars.png"));
                imageList.Images.Add(Image.FromFile(@"../../Data/CF_IS_SignalWithThreeFillBars.png"));
                imageList.Images.Add(Image.FromFile(@"../../Data/CF_IS_SignalWithFourFillBars.png"));
                this.comboBoxAdv1.Items.Clear();
                this.comboBoxAdv1.Items.AddRange(new object[] { "1", "2", "3", "4", "NoIcon" });

            }
            else
            {
                imageList.Images.Clear();
                imageList.Images.Add(Image.FromFile(@"../../Data/CF_IS_RedDownArrow.png"));
                imageList.Images.Add(Image.FromFile(@"../../Data/CF_IS_YellowDownInclineArrow.png"));
                imageList.Images.Add(Image.FromFile(@"../../Data/CF_IS_YellowSideArrow.png"));
                imageList.Images.Add(Image.FromFile(@"../../Data/CF_IS_YellowUpInclineArrow.png"));
                imageList.Images.Add(Image.FromFile(@"../../Data/CF_IS_GreenUpArrow.png"));
                this.comboBoxAdv1.Items.Clear();
                this.comboBoxAdv1.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "NoIcon" });

            }
            this.comboBoxAdv1.SelectedIndex = 0;
        }
        private void InitBox()
        {
            imageList.Images.Clear();
            imageList.Images.Add(Image.FromFile(@"../../Data/CF_IS_RedDownArrow.png"));
            imageList.Images.Add(Image.FromFile(@"../../Data/CF_IS_YellowDownInclineArrow.png"));
            imageList.Images.Add(Image.FromFile(@"../../Data/CF_IS_YellowSideArrow.png"));
            imageList.Images.Add(Image.FromFile(@"../../Data/CF_IS_YellowUpInclineArrow.png"));
            imageList.Images.Add(Image.FromFile(@"../../Data/CF_IS_GreenUpArrow.png"));
            this.comboBoxAdv1.Items.Clear();
            this.comboBoxAdv1.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "NoIcon" });

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
                return File.ReadAllText(licenseKeyFile);
            }
            return string.Empty;
        }
    }
}

#region Copyright Syncfusion Inc. 2001 - 2023
// Copyright Syncfusion Inc. 2001 - 2023. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Syncfusion.Calculate;
using Syncfusion.Windows.Forms;
using Syncfusion.Windows.Forms.Grid;
using Syncfusion.Windows.Forms.Tools.XPMenus;
using Syncfusion.WinForms.Controls;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace CalcEngine.Showcase_2010
{
    public partial class Form1 : SfForm
    {
        #region "API Definition"

        CalcGrid gridControl1;
        private Syncfusion.Calculate.CalcEngine engine;
        string xmlfilePath = "CalcEngine.xml";
        List<sample> dt1 = new List<sample>();
        List<sample> dbdt = new List<sample>();
        DataTable dt = new DataTable();
        DataTable dbDT = new DataTable();
        List<string> dbfunction = new List<string>();

        #endregion

        #region "Icon"

        private string GetIconFile(string bitmapName)
        {
            for (int n = 0; n < 10; n++)
            {
                if (System.IO.File.Exists(bitmapName))
                    return bitmapName;
                bitmapName = @"..\" + bitmapName;
            }
            return bitmapName;
        }

        #endregion

        #region "Constructor"

        public Form1()
        {
            InitializeComponent();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            try
            {
                System.Drawing.Icon ico = new System.Drawing.Icon(GetIconFile(@"common\Images\Grid\Icon\sfgrid1.ico"));
                this.Icon = ico;
            }
            catch { }
            
            //Grid settings has been customized.
            this.GridSettings();
            this.CalculateEngine();
            this.OtherSettings();
            //default load for Grid
            this.formulaCombo.SelectedIndex = formulaNameCollection.IndexOf("SUM");
            this.SizeChanged += Form1_SizeChanged;
            this.MinimumSize = new Size(this.Width - 200, this.Height - 100);
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            this.formulaPanel.Width = this.functionCountLable.Width+(int)DpiAware.LogicalToDeviceUnits(100);
            this.resultPanel.Width = this.formulaPanel.Width;
            gridPanel.Width = this.Width - formulaPanel.Width - gridPanel.Location.X;
            gridPanel.Height = this.Height - this.Style.TitleBar.Height-gridPanel.Margin.Bottom;
            this.formulaPanel.Height = (gridPanel.Height / 4) * 3;
            this.resultPanel.Height = gridPanel.Height - formulaPanel.Height-resultPanel.Margin.Bottom;
            this.syntaxtitle.Height = 30;
            this.formulaPanel.Location = new Point(gridPanel.Location.X + gridPanel.Width + 10, gridPanel.Location.Y);
            this.resultPanel.Location = new Point(gridPanel.Location.X + gridPanel.Width + 10, formulaPanel.Location.Y + formulaPanel.Height+10);
        }

        #endregion

        #region "CalcEngine"

        List<string> formulaNameCollection;
        private void CalculateEngine()
        {
            //Call this to reset static members in case other form is loaded first:
            Syncfusion.Calculate.CalcEngine.ResetSheetFamilyID();
            //Create a CalcEngine object, tie it to the gridDataBoundGrid that implements ICalcData:
            engine = new Syncfusion.Calculate.CalcEngine(gridControl1);
            engine.ParseAndComputeFormula("=A1");

            this.formulaNameCollection = GetFunctionNames();
            this.functionCountLable.Text = "CALCULATE SUPPORTS " + formulaNameCollection.Count.ToString() + " FORMULAS.";
            this.formulaCombo.DataSource = formulaNameCollection;
            this.formulaCombo.SelectedIndex = 0;
        }

        #endregion

        #region "Grid Settings"

        private void GridSettings()
        {
            gridControl1 = new CalcGrid();
            this.gridControl1.BeginUpdate();
            this.gridControl1.Location = new Point(60, 80);
            this.gridControl1.TableStyle.VerticalAlignment = GridVerticalAlignment.Middle;
            this.gridControl1.Size = new Size(this.gridPanel.Size.Width - 116, this.gridPanel.Size.Height - 124);
            this.gridControl1.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Bottom;
            this.gridPanel.Controls.Add(gridControl1);
            this.gridControl1.MetroColorTable.ScrollerBackground = ColorTranslator.FromHtml("#003B51");
            this.gridPanel.BackColor = ColorTranslator.FromHtml("#003B51");
            this.gridControl1.QueryCellInfo += new GridQueryCellInfoEventHandler(gridControl1_QueryCellInfo);
            //Initializes the data to the grid.
                        this.DataToGrid();

            //used to add the db collection to the list.
            this.AddDbFunction();

            this.gridControl1.RowCount = dt.Rows.Count;
            this.gridControl1.ColCount = dt.Columns.Count;
            this.gridControl1.BaseStylesMap["Row Header"].StyleInfo.HorizontalAlignment = GridHorizontalAlignment.Center;
            this.gridControl1.BaseStylesMap["Row Header"].StyleInfo.VerticalAlignment = GridVerticalAlignment.Middle;
            this.gridControl1.PopulateHeaders(GridRangeInfo.Cells(0, 1, gridControl1.RowCount, gridControl1.ColCount), dt);
            this.gridControl1.PopulateValues(GridRangeInfo.Cells(1, 1, gridControl1.RowCount, gridControl1.ColCount), dt);
            this.gridControl1.EndUpdate();            
        }

        private void gridControl1_QueryCellInfo(object sender, GridQueryCellInfoEventArgs e)
        {
            if (e.Style.CellType == GridCellTypeName.TextBox && this.gridControl1.CurrentCell.HasCurrentCellAt(e.RowIndex, e.ColIndex))
            {
                //to adjust the text position in edit mode.
                e.Style.TextMargins.Top = System.Convert.ToInt32(this.gridControl1.RowHeights[e.RowIndex] / 3);
            }
        }

        #endregion

        #region "DB functions"

        private void AddDbFunction()
        {
            dbfunction.Add("DCOUNT");
            dbfunction.Add("DCOUNTA");
            dbfunction.Add("DMIN");
            dbfunction.Add("DMAX");
            dbfunction.Add("DSUM");
            dbfunction.Add("DPRODUCT");
            dbfunction.Add("DAVERAGE");
            dbfunction.Add("DSTDEV");
            dbfunction.Add("DSTDEVP");
            dbfunction.Add("DVAR");
            dbfunction.Add("DVARP");
            dbfunction.Add("DGET");
            dbfunction.Add("COUNTBLANK");
            dbfunction.Add("FORMULATEXT");
            dbfunction.Add("PERCENTRANK.INC");
            dbfunction.Add("PERCENTRANK.EXC");
            dbfunction.Add("PERCENTRANK");
            dbfunction.Add("XIRR");
        }

        #endregion

        #region "Other Settings"

        private void OtherSettings()
        {
            this.formulaPanel.BackColor = ColorTranslator.FromHtml("#003B51");
            this.resultPanel.BackColor = ColorTranslator.FromHtml("#003B51");
            this.formulaCombo.BackColor = ColorTranslator.FromHtml("#003B51");

            #region Events

            this.gridControl1.QueryColWidth += gridControl1_QueryColWidth;
            this.gridControl1.QueryRowHeight += gridControl1_QueryRowHeight;
            this.formulaCombo.SelectedIndexChanged += formulaCombo_SelectedIndexChanged;
            this.textBox1.MouseHover += formulaTextLable_MouseHover;
            this.resultLable.TextChanged += resultLable_TextChanged;
            this.textBox1.TextChanged += buttonEdit1_TextChanged;
            this.textBox1.MouseLeave += buttonEdit1_MouseLeave;
            this.Click += Form1_Click;
            this.formulaPanel.Click += Form1_Click;
            this.resultPanel.Click += Form1_Click;
            this.textBox1.LostFocus += buttonEdit1_LostFocus;
            this.textBox1.LostFocus += textBoxExt1_LostFocus;
            this.textBox1.GotFocus += textBoxExt1_GotFocus;
            this.MouseMove += Form1_MouseMove;
            this.textBox1.KeyPress += new KeyPressEventHandler(textBox1_KeyPress);

            #endregion
        }

        #endregion

        #region "Events and Methods"

        void resultLable_TextChanged(object sender, EventArgs e)
        {
            using (Graphics g = this.CreateGraphics())
            {
                this.resultLable.Font = new Font("Segoe UI Semibold", 27.75f, FontStyle.Regular);
                SizeF sf = TextRenderer.MeasureText(this.resultLable.Text, this.resultLable.Font);
                if (resultLable.Width < sf.Width)
                {
                    this.resultLable.Font = new Font("Segoe UI Semibold", 14f, FontStyle.Regular);
                }
                else
                {
                    this.resultLable.Font = new Font("Segoe UI Semibold", (g.DpiX > 100) ? 23f : 27.75f, FontStyle.Regular);
                }
            }
        }

        void buttonEdit1_TextChanged(object sender, EventArgs e)
        {
            this.textBox1.Font = new Font("Segoe UI Semibold", 14.25f, FontStyle.Bold);
            SizeF sf = TextRenderer.MeasureText(this.textBox1.Text, this.textBox1.Font);
            if (textBox1.Width < sf.Width)
            {
                this.textBox1.Font = new Font("Segoe UI Semibold", 9f, FontStyle.Bold);
            }
            else
            {
                this.textBox1.Font = new Font("Segoe UI Semibold", 14.25f, FontStyle.Bold);
            }
            this.gridControl1.Selections.Clear();
            if (!string.IsNullOrEmpty(this.textBox1.Text) && this.textBox1.Text.IndexOf('(') > -1)
            {
                try
                {
                    string formula = this.textBox1.Text.Substring(this.textBox1.Text.IndexOf("("));
                    string[] args = (formula.Substring(1, (this.textBox1.Text.EndsWith(")") ? formula.Length - 2 : formula.Length - 1)).Replace("(", string.Empty).Replace(")", string.Empty)).Split(new char[] { ',' });
                    foreach (string arg in args)
                    {
                        if (IsCellReference(arg.Replace(" ", string.Empty)))
                        {
                            string[] cells = engine.GetCellsFromArgs(arg.Replace(" ", string.Empty).Replace("\"", ""));
                            int firstRow = engine.RowIndex(cells[0].ToString());
                            int lastRow = engine.RowIndex(cells[cells.Length - 1].ToString());
                            int firstCol = engine.ColIndex(cells[0].ToString());
                            int lastCol = engine.ColIndex(cells[cells.Length - 1].ToString());
                            this.gridControl1.Selections.Add(GridRangeInfo.Cells(firstRow, firstCol, lastRow, lastCol));
                        }
                    }
                }
                catch (Exception ex)
                {
                    this.resultLable.Text = ex.Message;
                }
            }
        }

        public bool IsCellReference(string args)
        {
            bool containsBoth = false;
            bool isAlpha = false, isNum = false;
            if (args.IndexOf(':') != args.LastIndexOf(':'))
            {
                return false;
            }

            foreach (char c in args.ToCharArray())
            {
                if (char.IsLetter(c))
                {
                    isAlpha = true;
                }

                if (char.IsDigit(c))
                {
                    isNum = true;
                }

                if (char.Equals(c, ':'))
                {
                    if (isAlpha && isNum)
                    {
                        containsBoth = true;
                    }
                    isAlpha = false;
                    isNum = false;
                }
            }
            if (args.Contains(":") && !args.Contains("\""))
            {
                if (containsBoth && isAlpha && isNum)
                    return true;
                else if (((isAlpha && !isNum) || (!isAlpha && isNum)) && !containsBoth)
                {
                    return true;
                }
                else
                    return false;
            }
            if (isAlpha && isNum && !args.Contains("\""))
            {
                return true;
            }

            return false;
        }

        void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == 13 && !string.IsNullOrEmpty(this.textBox1.Text))
            {
                this.engine.UseDependencies = false;

                this.resultLable.Text = this.engine.ParseAndComputeFormula(this.textBox1.Text);
                this.engine.UseDependencies = true;
                e.Handled = true;
            }
        }

        void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            Rectangle rect = Screen.GetBounds(this);
            Point loc2 = Screen.GetBounds(this).Location;
        }

        void textBoxExt1_GotFocus(object sender, EventArgs e)
        {
            string s = this.textBox1.Text;
            this.textBox1.ReadOnly = false;
            this.textBox1.Text = "";
            this.textBox1.Text = s;
        }

        void textBoxExt1_LostFocus(object sender, EventArgs e)
        { this.Cursor = Cursors.Default; }


        void Form1_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
            this.textBox1.ReadOnly = true;
        }

        void buttonEdit1_LostFocus(object sender, EventArgs e)
        {this.Cursor = Cursors.Default;}

        void buttonEdit1_MouseLeave(object sender, EventArgs e)
        {this.Cursor = Cursors.Default;}

        void formulaTextLable_MouseHover(object sender, EventArgs e)
        {this.Cursor = Cursors.Hand;}

        private void pictureBox3_Click(object sender, EventArgs e)
        { this.WindowState = FormWindowState.Minimized; }

        private void pictureBox4_Click(object sender, EventArgs e)
        {this.Close();
        }
        
        void gridControl1_QueryRowHeight(object sender, GridRowColSizeEventArgs e)
        {
            e.Size = (this.gridControl1.ClientSize.Height / 11);
            e.Handled = true;
        }
        void gridControl1_QueryColWidth(object sender, GridRowColSizeEventArgs e)
        {
            e.Size = this.gridControl1.ClientSize.Width / 8;
            e.Handled = true;
        }



        /// <summary>
        /// used to calculate the customized values passed.
        /// </summary>
        private void buttonAdv1_Click(object sender, EventArgs e)
        {
            this.engine.UseDependencies = false;
            this.resultLable.Text = this.engine.ParseAndComputeFormula(this.textBox1.Text);
            this.engine.UseDependencies = true;
        }
        
        public List<string> GetFunctionNames()
        {
            List<string> formulaList = new List<string>();
            foreach (string formula in engine.LibraryFunctions.Keys)
            {
                formulaList.Add(formula);
            }
            formulaList.Sort();
            formulaList.RemoveAt(0);
            formulaList.RemoveAt(0);
            formulaList.RemoveAt(0);
            return formulaList;
        }

        void formulaCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            XmlDocument xmldoc = new XmlDocument();
            XmlNodeList xmlnode;
            int i = 0;
            string xmlText = File.ReadAllText(xmlfilePath);
            xmldoc.Load(xmlfilePath);
            xmlnode = xmldoc.GetElementsByTagName(this.formulaCombo.Text.ToString());

            if (dbfunction.IndexOf(this.formulaCombo.Text) > -1)
            {
                this.gridControl1.PopulateHeaders(GridRangeInfo.Cells(0, 1, gridControl1.RowCount, gridControl1.ColCount), dbDT);
                this.gridControl1.PopulateValues(GridRangeInfo.Cells(1, 1, gridControl1.RowCount, gridControl1.ColCount), dbDT);
            }
            else
            {
                this.gridControl1.PopulateHeaders(GridRangeInfo.Cells(0, 1, gridControl1.RowCount, gridControl1.ColCount), dt);
                this.gridControl1.PopulateValues(GridRangeInfo.Cells(1, 1, gridControl1.RowCount, gridControl1.ColCount), dt);
            }
            try
            {
                if (xmlnode.Count == 1)
                {
                    xmlnode[i].ChildNodes.Item(0).InnerText.Trim();
                    this.descrLable.Text = xmlnode[0].ChildNodes.Item(0).InnerText.Trim();
                    this.syntaxLable.Text = xmlnode[i].ChildNodes.Item(1).InnerText.Trim();
                    this.textBox1.Text = xmlnode[i].ChildNodes.Item(2).InnerText.Trim();
                    this.resultLable.Text = engine.ParseAndComputeFormula(this.textBox1.Text);

                }
                else
                {
                    this.textBox1.Text = "";
                    this.descrLable.Text = "Not available";
                    this.syntaxLable.Text = "Not available";
                    this.resultLable.Text = "";
                }
            }
            catch (Exception ex)
            {
                this.resultLable.Text = ex.Message;
            }
        }
        
        #endregion

        #region "Data For Sample"
        
        public class sample
        {

            public string A
            {
                get;
                set;
            }
            public string B
            {
                get;
                set;
            }
            public string C
            {
                get;
                set;
            }
            public string D
            {
                get;
                set;
            }
            public string E
            {
                get;
                set;
            }
            public string F
            {
                get;
                set;
            }
            public string G
            {
                get;
                set;
            }
        }

        private DataTable ConvertToDatatable<sample>(List<sample> data)
        {
            PropertyDescriptorCollection props =
                TypeDescriptor.GetProperties(typeof(sample));
            DataTable table = new DataTable();
            for (int i = 0; i < props.Count; i++)
            {
                PropertyDescriptor prop = props[i];
                if (prop.PropertyType.IsGenericType && prop.PropertyType.GetGenericTypeDefinition() == typeof(Nullable<>))
                    table.Columns.Add(prop.Name, prop.PropertyType.GetGenericArguments()[0]);
                else
                    table.Columns.Add(prop.Name, prop.PropertyType);
            }
            object[] values = new object[props.Count];
            foreach (sample item in data)
            {
                for (int i = 0; i < values.Length; i++)
                {
                    values[i] = props[i].GetValue(item);
                }
                table.Rows.Add(values);
            }
            return table;
        }
        
        private void DataToGrid()
        {
            Random r = new Random(1000);
            dt1.Add(new sample { A = "6", B = "58", C = "35", D = "0.01", E = "7/18/2011 7:45:05 AM", F = "7500", G = "-120000" });
            dt1.Add(new sample { A = "25", B = "11", C = "25", D = "6", E = "TRUE", F = "4", G = "39000" });
            dt1.Add(new sample { A = "0.15", B = "10", C = "23", D = "4", E = "FALSE", F = "3.5", G = "30000" });
            dt1.Add(new sample { A = "0.75", B = "45.35", C = "47.65", D = "0.06", E = "8", F = "1.2", G = "21000" });
            dt1.Add(new sample { A = "0.05", B = "17.56", C = "18.44", D = "10", E = "20", F = "0.908789", G = "37000" });
            dt1.Add(new sample { A = "0.85", B = "16.09", C = "16.91", D = "-200", E = "3", F = "40", G = "46000" });
            dt1.Add(new sample { A = "50", B = "2400", C = "15.20", D = "-500", E = "3", F = "1.5", G = "0.1" });
            dt1.Add(new sample { A = "0.09", B = "300", C = "6", D = "0.068094", E = "8000", F = "10", G = "0.12" });
            dt1.Add(new sample { A = "30", B = "10", C = "4", D = "0.01", E = "FLUID FLOW", F = "2", G = "#NULL!" });
            dt1.Add(new sample { A = "125000", B = "STREET", C = "-200", D = "2", E = "$1000", F = "2000", G = "http://en.wikipedia.org/w/api.php?action=query&list=recentchanges&rcnamespace=0&format=xml" });

            dt = ConvertToDatatable<sample>(dt1);

            dbdt.Add(new sample { A = "Tree", B = "Height", C = "Age", D = "Yield", E = "Profit", F = "Height", G = "13" });
            dbdt.Add(new sample { A = "=\"=Apple\"", B = ">10", C = string.Empty, D = string.Empty, E = string.Empty, F = "<16", G = "12" });
            dbdt.Add(new sample { A = "=\"=Pear\"", B = "", C = string.Empty, D = string.Empty, E = string.Empty, F = string.Empty, G = "11" });
            dbdt.Add(new sample { A = "Tree", B = "Height", C = "Age", D = "Yield", E = "Profit", F = string.Empty, G = "8" });
            dbdt.Add(new sample { A = "Apple", B = "18", C = "20", D = "14", E = "105.00", F = "-$10,000", G = "4" });
            dbdt.Add(new sample { A = "Pear", B = "12", C = "12", D = "10", E = "96.00", F = "$2,750", G = "3" });
            dbdt.Add(new sample { A = "Cherry", B = "13", C = "14", D = "9", E = "105.00", F = "4,250", G = "2" });
            dbdt.Add(new sample { A = "Apple", B = "14", C = "15", D = "10", E = "75.00", F = "1-Jan-08", G = "1" });
            dbdt.Add(new sample { A = "Pear", B = "9", C = "8", D = "8", E = "76.80", F = "1-Mar-08", G = "1" });
            dbdt.Add(new sample { A = "Apple", B = "8", C = "9", D = "6", E = "45.00", F = "30-Oct-08", G = "1" });

            dbDT = ConvertToDatatable<sample>(dbdt);
        }

        #endregion

    }
}


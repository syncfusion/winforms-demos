#region Copyright Syncfusion Inc. 2001-2019.
// Copyright Syncfusion Inc. 2001-2019. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Syncfusion.Windows.Forms.Tools;
using Syncfusion.WinForms.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DataBinding
{
    public partial class Form1 : SfForm
    {
        TreeViewAdv treeViewAdv1 = new TreeViewAdv();
        public Form1()
        {
            InitializeComponent();
            this.treeViewAdv1.Size = new System.Drawing.Size(312, 368);
            this.StartPosition = FormStartPosition.CenterScreen;
            treeViewAdv1.Dock = DockStyle.Fill;
            treeViewAdv1.SelectionMode = TreeSelectionMode.MultiSelectAll;
            panel11.Controls.Add(treeViewAdv1);
            treeViewAdv1.ShowCheckBoxes = true;
            this.Text = "Data Binding";
            List<string> relations = new List<string>();
            relations.Add("Data Table");
            relations.Add("Data Relations");
            comboBox1.DropDownStyle = Syncfusion.WinForms.ListView.Enums.DropDownStyle.DropDownList;
            comboBox1.DataSource = relations;
            comboBox1.AllowDropDownResize = false;
            comboBox1.SelectedIndex = -1;
            comboBox1.SelectedIndex = 0;
            treeViewAdv1.SelfRelationRootValue = "";
            treeViewAdv1.ItemHeight = 25;
            treeViewAdv1.ShowLines = false;
            treeViewAdv1.ThemeName = "Office2019Colorful";
            comboBox1.ThemeName = "Office2019Colorful";
            treeViewAdv1.HideSelection = false;
        }


        Syncfusion.Windows.Forms.Tools.DataRelation ChildRelation1;
        Syncfusion.Windows.Forms.Tools.DataRelation ChildRelation2;
        Syncfusion.Windows.Forms.Tools.DataRelation ChildRelation3;
        bool ColumnsAdded1 = false;
        bool ColumnsAdded2 = false;
        bool ColumnsAdded3 = false;
        BindingSource bindingSource = new BindingSource();
        BindingSource bindingSource2 = new BindingSource();
        BindingSource bindingSource3 = new BindingSource();
        BindingSource bindingSource4 = new BindingSource();
        BindingSource bindingSource5 = new BindingSource();
        DataTable ItemTable = new DataTable("Item");
        DataTable ChildTable1 = new DataTable("ChildTable1");
        DataTable ChildTable2 = new DataTable("ChildTable2");
        DataTable ChildTable3 = new DataTable("ChildTable3");
        DataTable dataTable1 = new DataTable("Continent");
        DataTable FolderTable = new DataTable("Folder");
        DataTable SubFolder1 = new DataTable("SubFolder1");
        DataTable SubFolder2 = new DataTable("SubFolder2");
        DataTable SubFolder3 = new DataTable("SubFolder3");

        DataTable ClassTable = new DataTable("Class");
        DataTable SubClass1 = new DataTable("SubClass1");
        DataTable SubClass2 = new DataTable("SubClass2");
        DataTable SubClass3 = new DataTable("SubClass3");

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                treeViewAdv1.DataSource = null;
                treeViewAdv1.DataMember = "";
                if (!ColumnsAdded1)
                {
                    ColumnsAdded1 = true;
                    treeViewAdv1.DataMember = "";
                    //Add columns to the DataTable
                    dataTable1.Columns.Add("Name", typeof(string));
                    dataTable1.Columns.Add("CountryID", typeof(string));
                    dataTable1.Columns.Add("ContinentID", typeof(string));
                    //dataTable1.Columns.Add("ProjectID", typeof(string));
                    dataTable1.Columns.Add("Capital", typeof(string));
                    dataTable1.Columns.Add("IsActive", typeof(bool));
                    dataTable1.Rows.Add("Asia", "1", "", "Asia", true);
                    dataTable1.Rows.Add("India", "2", "1", "Delhi", false);
                    dataTable1.Rows.Add("China", "3", "1", "Beijing", true);
                    dataTable1.Rows.Add("North America", "4", "", "USA", false);
                    dataTable1.Rows.Add("United States", "5", "4", "New York", true);
                    dataTable1.Rows.Add("Canada", "6", "4", "Ottawa", false);
                    dataTable1.Rows.Add("Europe", "7", "", "EU", true);
                    dataTable1.Rows.Add("UK", "8", "7", "London", false);
                    dataTable1.Rows.Add("Russia", "9", "7", "Moscow", true);
                    dataTable1.Rows.Add("Africa", "10", "", "SA", false);
                    dataTable1.Rows.Add("South Africa", "11", "10", "Cape Town", true);
                    dataTable1.Rows.Add("Zimbabwe", "12", "10", "Harare", false);
                    dataTable1.Rows.Add("Maharashtra", "13", "2", "Bombay", true);
                    dataTable1.Rows.Add("Tamil Nadu", "14", "2", "Madras", false);
                    dataTable1.Rows.Add("Mumbai", "15", "13", "Borivali", true);
                    dataTable1.Rows.Add("Chennai", "16", "14", "Koyambedu", false);
                    dataTable1.Rows.Add("New York", "17", "5", "NY", true);
                    dataTable1.Rows.Add("Albany", "18", "17", "AL", false);
                    dataTable1.Rows.Add("Northen Cape", "19", "11", "NC", true);
                    dataTable1.Rows.Add("CapeTown", "20", "19", "Town", false);
                    dataTable1.Rows.Add("England", "21", "8", "ENG", true);
                    dataTable1.Rows.Add("London", "22", "21", "UK", false);
                    dataTable1.Rows.Add("Shanghai", "23", "3", "SH", true);
                    dataTable1.Rows.Add("Republics", "24", "9", "Repb", false);
                    dataTable1.Rows.Add("Kazan", "25", "24", "Kz", true);
                    dataTable1.Rows.Add("Victoria", "26", "12", "VC", false);
                    dataTable1.Rows.Add("Masvingo", "27", "26", "Mas", true);
                    dataTable1.Rows.Add("Chengudu", "28", "23", "Chen", false);
                    dataTable1.Rows.Add("Ontario", "29", "6", "Ont", true);
                    dataTable1.Rows.Add("Toronto", "30", "29", "TR", true);
                }
                treeViewAdv1.DataRelations.Clear();
                treeViewAdv1.DataMember = "Continent";
                treeViewAdv1.DataRelations.Clear();
                treeViewAdv1.DisplayMember = "Name";
                treeViewAdv1.ParentMember = "ContinentID";
                treeViewAdv1.ChildMember = "CountryID";
                treeViewAdv1.ValueMember = "Capital";
                treeViewAdv1.CheckedMember = "IsActive";
                treeViewAdv1.DataSource = dataTable1;
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                treeViewAdv1.DataSource = null;
                treeViewAdv1.DataMember = "";
                if (!ColumnsAdded2)
                {
                    ColumnsAdded2 = true;

                    treeViewAdv1.DataMember = "";
                    //Add columns to the DataTable
                    FolderTable.Columns.Add("FolderName", typeof(string));
                    FolderTable.Columns.Add("NewFolderName", typeof(string));
                    FolderTable.Columns.Add("FolderParent", typeof(string));
                    FolderTable.Columns.Add("FolderChild", typeof(string));

                    SubFolder1.Columns.Add("SubFolderName1", typeof(string));
                    SubFolder1.Columns.Add("NewSubFolderName1", typeof(string));
                    SubFolder1.Columns.Add("FolderChild", typeof(string));
                    SubFolder1.Columns.Add("SubFolderChild1", typeof(string));
                    SubFolder1.Columns.Add("Checked", typeof(bool));

                    SubFolder2.Columns.Add("SubFolderName2", typeof(string));
                    SubFolder2.Columns.Add("NewSubFolderName2", typeof(string));
                    SubFolder2.Columns.Add("SubFolderChild1", typeof(string));
                    SubFolder2.Columns.Add("SubFolderChild2", typeof(string));

                    SubFolder3.Columns.Add("SubFolderName3", typeof(string));
                    SubFolder3.Columns.Add("NewSubFolderName3", typeof(string));
                    SubFolder3.Columns.Add("SubFolderChild2", typeof(string));
                    SubFolder3.Columns.Add("SubFolderChild3", typeof(string));
                    SubFolder3.Columns.Add("Checked", typeof(bool));

                    for (int i = 0; i < 100; i++)
                    {
                        FolderTable.Rows.Add("Folder" + i.ToString(), "New Folder" + i.ToString(), (i + 1).ToString(), (1000 + i).ToString());

                    }

                    int k = 0;
                    for (int i = 0; i < 100; i++)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            SubFolder1.Rows.Add("Level 1 Sub Folder" + j.ToString(), "Level 1 New Sub Folder" + j.ToString(), (1000 + i).ToString(), (2000 + k).ToString(), true);
                            k++;
                        }
                    }

                    k = 0;
                    for (int i = 0; i < 1000; i++)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            SubFolder2.Rows.Add("Level 2 Sub Folder" + j.ToString(), "Level 2 New Sub Folder" + j.ToString(), (2000 + i).ToString(), (3000 + k).ToString());
                            k++;
                        }
                    }

                    k = 0;
                    for (int i = 0; i < 10000; i++)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            SubFolder3.Rows.Add("Level 3 Sub Folder" + j.ToString(), "Level 3 New Sub Folder" + j.ToString(), (3000 + i).ToString(), (6000 + k).ToString(), true);
                            k++;
                        }
                    }
                }
                ChildRelation1 = new Syncfusion.Windows.Forms.Tools.DataRelation(SubFolder1, "SubFolder1", "SubFolderName1", "FolderChild", "SubFolderChild1", "SubFolderName1", "Checked");
                ChildRelation2 = new Syncfusion.Windows.Forms.Tools.DataRelation(SubFolder2, "SubFolderName2", "SubFolderChild1", "SubFolderChild2");
                ChildRelation3 = new Syncfusion.Windows.Forms.Tools.DataRelation(SubFolder3, "SubFolder3", "SubFolderName3", "SubFolderChild2", "SubFolderChild3", "SubFolderName3", "Checked");
                treeViewAdv1.DataRelations.Clear();

                treeViewAdv1.DisplayMember = "FolderName";
                treeViewAdv1.ParentMember = "FolderParent";
                treeViewAdv1.ChildMember = "FolderChild";
                treeViewAdv1.DataRelations.Add(ChildRelation1);
                treeViewAdv1.DataRelations.Add(ChildRelation2);
                treeViewAdv1.DataRelations.Add(ChildRelation3);
                treeViewAdv1.DataSource = FolderTable;

                DataTable table1 = new DataTable("Table1");
                table1.Columns.Add("Node Level");
                table1.Columns.Add("Display Member");

                table1.Rows.Add("0", "FolderName");
                table1.Rows.Add("0", "NewFolderName");
                table1.Rows.Add("1", "SubFolderName1");
                table1.Rows.Add("1", "NewSubFolderName1");
                table1.Rows.Add("2", "SubFolderName2");
                table1.Rows.Add("2", "NewSubFolderName2");
                table1.Rows.Add("3", "SubFolderName3");
                table1.Rows.Add("3", "NewSubFolderName3");
                DataView view = new DataView(table1);
            }
        }
    }
}

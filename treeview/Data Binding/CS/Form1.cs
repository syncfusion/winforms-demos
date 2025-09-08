#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Syncfusion.Windows.Forms.Tools;
using Syncfusion.WinForms.Controls;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
            relations.Add("Object Relational");
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
        }

        ObservableCollection<State> indiaStateList = null;
        ObservableCollection<State> chinaStateList = null;
        ObservableCollection<State> unitedStatedStateList = null;
        ObservableCollection<State> canadaStateList = null;
        ObservableCollection<State> stateList4 = null;
        ObservableCollection<State> stateList5 = null;
        ObservableCollection<State> stateList6 = null;
        ObservableCollection<State> stateList7 = null;
        ObservableCollection<State> malasiyaStateList = null;
        ObservableCollection<State> indhonasiaStateList = null;
        ObservableCollection<State> japanStateList = null;
        ObservableCollection<State> mexicoStateList = null;
        ObservableCollection<State> cubaStateList = null;
        ObservableCollection<State> hondurasStateList = null;
        ObservableCollection<State> franceStateList = null;
        ObservableCollection<State> spainStateList = null;
        ObservableCollection<State> austriaStateList = null;
        ObservableCollection<State> angolaStateList = null;
        ObservableCollection<State> egyptStatesList = null;
        ObservableCollection<State> nigeriaStateList = null;
        ObservableCollection<State> argentinaStateList = null;
        ObservableCollection<State> brazilStateList = null;
        ObservableCollection<State> colombiaStateList = null;
        ObservableCollection<State> peruStatesList = null;
        ObservableCollection<State> venezuelaStateList = null;




        ObservableCollection<Country> asiaCountryList = null;
        ObservableCollection<Country> northAmericacountriesList = null;
        ObservableCollection<Country> europeCountryList = null;
        ObservableCollection<Country> africacountryList = null;
        ObservableCollection<Country> southAmericaaCountryList = null;


        ObservableCollection<Continent> continentList = null;

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
                this.button1.Visible = true;
                this.button2.Visible = true;
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
                this.button1.Visible = false;
                this.button2.Visible = false;
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
            else if (comboBox1.SelectedIndex == 2)
            {
                BindObjectRelationalData();
            }
        } 

        private void BindObjectRelationalData()
        {
            this.button1.Visible = false;
            this.button2.Visible = false;
            treeViewAdv1.DataSource = null;
            treeViewAdv1.DataMember = "";

            //////////////////////  Asis ////////////////////////////////////

            indiaStateList = new ObservableCollection<State>();

            indiaStateList.Add(new State("Tamil Nadu", 100));
            indiaStateList.Add(new State("Maharastra", 101));
            indiaStateList.Add(new State("Kerala", 102));
            indiaStateList.Add(new State("Karnataka", 103));
            indiaStateList.Add(new State("Gujarat", 104));
            indiaStateList.Add(new State("Delhi", 130));
            indiaStateList.Add(new State("Bihar", 131));

            chinaStateList = new ObservableCollection<State>();

            chinaStateList.Add(new State("Beijing", 105));
            chinaStateList.Add(new State("Shanghai", 106));
            chinaStateList.Add(new State("Guilin", 132));
            chinaStateList.Add(new State("Hong Kong", 133));
            chinaStateList.Add(new State("Xiamen", 134));
            chinaStateList.Add(new State("Haikou", 135));
            chinaStateList.Add(new State("Dali", 136));

            malasiyaStateList = new ObservableCollection<State>();

            malasiyaStateList.Add(new State("Malacca", 137));
            malasiyaStateList.Add(new State("Perlis", 138));
            malasiyaStateList.Add(new State("Sabah", 139));
            malasiyaStateList.Add(new State("Sarawak", 140));
            malasiyaStateList.Add(new State("Johor", 141));
            malasiyaStateList.Add(new State("Pahang", 142));
            malasiyaStateList.Add(new State("Penang", 143));

            indhonasiaStateList = new ObservableCollection<State>();

            indhonasiaStateList.Add(new State("Aceh", 144));
            indhonasiaStateList.Add(new State("Bali", 145));
            indhonasiaStateList.Add(new State("Central Java", 146));
            indhonasiaStateList.Add(new State("East Java", 147));
            indhonasiaStateList.Add(new State("West Java", 148));
            indhonasiaStateList.Add(new State("Papua", 149));
            indhonasiaStateList.Add(new State("Lampung", 150));

            japanStateList = new ObservableCollection<State>();

            japanStateList.Add(new State("Akita", 151));
            japanStateList.Add(new State("Chiba", 152));
            japanStateList.Add(new State("Hokkaido", 153));
            japanStateList.Add(new State("Saitama", 154));
            japanStateList.Add(new State("Tochigi", 155));
            japanStateList.Add(new State("Tokyo", 156));
            japanStateList.Add(new State("Yamagata", 157));

            asiaCountryList = new ObservableCollection<Country>();

            asiaCountryList.Add(new Country("India", 10, indiaStateList));
            asiaCountryList.Add(new Country("China", 11, chinaStateList));
            asiaCountryList.Add(new Country("Malaysia", 20, malasiyaStateList));
            asiaCountryList.Add(new Country("Japan", 21, japanStateList));
            asiaCountryList.Add(new Country("Indonesia", 22, indhonasiaStateList));

            continentList = new ObservableCollection<Continent>();

            continentList.Add(new Continent("Asia", 1, asiaCountryList));

            ///////////////////////////////////  South America /////////////////////////////////

            argentinaStateList = new ObservableCollection<State>();

            argentinaStateList.Add(new State("Chaco", 260));
            argentinaStateList.Add(new State("Jujuy", 261));
            argentinaStateList.Add(new State("Misiones", 262));
            argentinaStateList.Add(new State("Rio Negro", 263));
            argentinaStateList.Add(new State("Santa Fe", 264));
            argentinaStateList.Add(new State("Tucuman", 265));
            argentinaStateList.Add(new State("San Luis", 266));


            brazilStateList = new ObservableCollection<State>();

            brazilStateList.Add(new State("Acre", 267));
            brazilStateList.Add(new State("Alagoas", 268));
            brazilStateList.Add(new State("Bahia", 269));
            brazilStateList.Add(new State("Paraiba", 270));
            brazilStateList.Add(new State("Roraima", 271));
            brazilStateList.Add(new State("Santa Catarina", 272));
            brazilStateList.Add(new State("Sergipe", 273));

            colombiaStateList = new ObservableCollection<State>();

            colombiaStateList.Add(new State("Antioquia", 274));
            colombiaStateList.Add(new State("Bolívar", 275));
            colombiaStateList.Add(new State("Cauca", 276));
            colombiaStateList.Add(new State("Cundinamarca", 277));
            colombiaStateList.Add(new State("Magdalena", 278));
            colombiaStateList.Add(new State("Panama", 279));
            colombiaStateList.Add(new State("Santander", 280));

            peruStatesList = new ObservableCollection<State>();

            peruStatesList.Add(new State("Luya", 281));
            peruStatesList.Add(new State("Aija", 282));
            peruStatesList.Add(new State("Bolognesi", 283));
            peruStatesList.Add(new State("Carhuaz", 284));
            peruStatesList.Add(new State("Corongo", 285));
            peruStatesList.Add(new State("Grau", 286));
            peruStatesList.Add(new State("Islay", 287));


            venezuelaStateList = new ObservableCollection<State>();

            venezuelaStateList.Add(new State("Apure", 288));
            venezuelaStateList.Add(new State("Amazonas", 289));
            venezuelaStateList.Add(new State("Bolívar", 290));
            venezuelaStateList.Add(new State("Carabobo", 291));
            venezuelaStateList.Add(new State("Cojedes", 292));
            venezuelaStateList.Add(new State("Lara", 293));
            venezuelaStateList.Add(new State("Sucre", 294));


            southAmericaaCountryList = new ObservableCollection<Country>();

            southAmericaaCountryList.Add(new Country("Argentina", 31, argentinaStateList));
            southAmericaaCountryList.Add(new Country("Brazil", 32, brazilStateList));
            southAmericaaCountryList.Add(new Country("Colombia", 33, colombiaStateList));
            southAmericaaCountryList.Add(new Country("Peru", 34, peruStatesList));
            southAmericaaCountryList.Add(new Country("Venezuela", 35, venezuelaStateList));


            continentList.Add(new Continent("South America", 5, southAmericaaCountryList));


            /////////////////////////////////////////   North America ////////////////////

            unitedStatedStateList = new ObservableCollection<State>();

            unitedStatedStateList.Add(new State("New York", 158));
            unitedStatedStateList.Add(new State("Hawaii", 159));
            unitedStatedStateList.Add(new State("Greenland", 160));
            unitedStatedStateList.Add(new State("Texas", 161));
            unitedStatedStateList.Add(new State("Florida", 162));
            unitedStatedStateList.Add(new State("Taiwan", 163));
            unitedStatedStateList.Add(new State("California", 164));



            canadaStateList = new ObservableCollection<State>();

            canadaStateList.Add(new State("Alberta", 110));
            canadaStateList.Add(new State("Ontario", 111));
            canadaStateList.Add(new State("Manitoba", 165));
            canadaStateList.Add(new State("Quebec", 166));
            canadaStateList.Add(new State("Sakatchewan", 167));
            canadaStateList.Add(new State("Nova Scotia", 168));
            canadaStateList.Add(new State("New Brunswick", 169));

            mexicoStateList = new ObservableCollection<State>();

            mexicoStateList.Add(new State("Hidalgo", 170));
            mexicoStateList.Add(new State("Chiapas", 171));
            mexicoStateList.Add(new State("Sonora", 172));
            mexicoStateList.Add(new State("Sinalo", 173));
            mexicoStateList.Add(new State("Mexico City", 174));
            mexicoStateList.Add(new State("Yucatan", 175));
            mexicoStateList.Add(new State("Morelos", 176));

            cubaStateList = new ObservableCollection<State>();

            cubaStateList.Add(new State("Artemisa", 177));
            cubaStateList.Add(new State("La Habana", 178));
            cubaStateList.Add(new State("Mayabeque", 179));
            cubaStateList.Add(new State("Matanzas", 180));
            cubaStateList.Add(new State("Cienfuegos", 181));
            cubaStateList.Add(new State("Villa Clara", 182));
            cubaStateList.Add(new State("Sancti Spíritus", 183));

            hondurasStateList = new ObservableCollection<State>();

            hondurasStateList.Add(new State("Atlantida", 184));
            hondurasStateList.Add(new State("Choluteca", 185));
            hondurasStateList.Add(new State("Colon", 186));
            hondurasStateList.Add(new State("Comayagua", 187));
            hondurasStateList.Add(new State("Copan", 188));
            hondurasStateList.Add(new State("Cortes", 189));
            hondurasStateList.Add(new State("El Paraiso", 190));

            northAmericacountriesList = new ObservableCollection<Country>();

            northAmericacountriesList.Add(new Country("United States", 3, unitedStatedStateList));
            northAmericacountriesList.Add(new Country("Canada", 4, canadaStateList));
            northAmericacountriesList.Add(new Country("Mexico", 23, mexicoStateList));
            northAmericacountriesList.Add(new Country("Cuba", 24, cubaStateList));
            northAmericacountriesList.Add(new Country("Honduras", 25, hondurasStateList));

            continentList.Add(new Continent("NorthAmerica", 2, northAmericacountriesList));

            ///////////////// Europe //////////////////////

            stateList4 = new ObservableCollection<State>();

            stateList4.Add(new State("Bavaria", 191));
            stateList4.Add(new State("Hesse", 192));
            stateList4.Add(new State("Saarland", 193));
            stateList4.Add(new State("Hamburg", 194));
            stateList4.Add(new State("Branden Burg", 195));
            stateList4.Add(new State("Thuringia", 196));
            stateList4.Add(new State("Berlin", 197));


            stateList5 = new ObservableCollection<State>();

            stateList5.Add(new State("Agrigento", 198));
            stateList5.Add(new State("Catania", 199));
            stateList5.Add(new State("Foggia", 200));
            stateList5.Add(new State("Gorizia", 201));
            stateList5.Add(new State("Bari", 202));
            stateList5.Add(new State("Messina", 203));
            stateList5.Add(new State("Padua", 204));

            franceStateList = new ObservableCollection<State>();

            franceStateList.Add(new State("Berry", 205));
            franceStateList.Add(new State("Normandy", 206));
            franceStateList.Add(new State("Languedoc", 207));
            franceStateList.Add(new State("Anjou", 208));
            franceStateList.Add(new State("Foix", 209));
            franceStateList.Add(new State("Artois", 210));
            franceStateList.Add(new State("Nivernais", 211));

            spainStateList = new ObservableCollection<State>();

            spainStateList.Add(new State("Almeria", 212));
            spainStateList.Add(new State("Cuenca", 213));
            spainStateList.Add(new State("La Rioja", 214));
            spainStateList.Add(new State("Lugo", 215));
            spainStateList.Add(new State("Palencia", 216));
            spainStateList.Add(new State("Salamanca", 217));
            spainStateList.Add(new State("Segovia", 218));


            austriaStateList = new ObservableCollection<State>();

            austriaStateList.Add(new State("Vienna", 219));
            austriaStateList.Add(new State("Lower Austria", 220));
            austriaStateList.Add(new State("Upper Austria", 221));
            austriaStateList.Add(new State("Styria", 222));
            austriaStateList.Add(new State("Tyrol", 223));
            austriaStateList.Add(new State("Carinthia", 224));
            austriaStateList.Add(new State("Burgenland", 225));


            europeCountryList = new ObservableCollection<Country>();

            europeCountryList.Add(new Country("Austria", 26, austriaStateList));
            europeCountryList.Add(new Country("Germany", 27, stateList4));
            europeCountryList.Add(new Country("Italy", 28, stateList5));
            europeCountryList.Add(new Country("France", 29, franceStateList));
            europeCountryList.Add(new Country("Spain", 30, spainStateList));


            continentList.Add(new Continent("Europe", 3, europeCountryList));

            ////////////////////////////  Africa ////////////////////////////////////////////


            stateList6 = new ObservableCollection<State>();

            stateList6.Add(new State("Northen Cape", 116));
            stateList6.Add(new State("Eastern Cape", 226));
            stateList6.Add(new State("Western Cape", 227));
            stateList6.Add(new State("Limpopo", 228));
            stateList6.Add(new State("Mpumalanga", 229));
            stateList6.Add(new State("Gauteng", 230));
            stateList6.Add(new State("KwaZulu-Natal", 231));


            stateList7 = new ObservableCollection<State>();

            stateList7.Add(new State("Adrar", 232));
            stateList7.Add(new State("Bouira", 233));
            stateList7.Add(new State("Chlef", 234));
            stateList7.Add(new State("Ghardaïa", 235));
            stateList7.Add(new State("Illizi", 236));
            stateList7.Add(new State("Mostaganem", 237));
            stateList7.Add(new State("Oran", 238));

            angolaStateList = new ObservableCollection<State>();

            angolaStateList.Add(new State("Bengo", 239));
            angolaStateList.Add(new State("Benguela", 240));
            angolaStateList.Add(new State("Cabinda", 241));
            angolaStateList.Add(new State("Huambo", 242));
            angolaStateList.Add(new State("Luanda", 243));
            angolaStateList.Add(new State("Malanje", 244));
            angolaStateList.Add(new State("Malanje", 245));

            egyptStatesList = new ObservableCollection<State>();

            egyptStatesList.Add(new State("Cairo", 246));
            egyptStatesList.Add(new State("Alexandria", 247));
            egyptStatesList.Add(new State("Giza", 248));
            egyptStatesList.Add(new State("Port Said", 249));
            egyptStatesList.Add(new State("Tanta", 250));
            egyptStatesList.Add(new State("Faiyum", 251));
            egyptStatesList.Add(new State("Mansoura", 252));


            nigeriaStateList = new ObservableCollection<State>();

            nigeriaStateList.Add(new State("Abia", 253));
            nigeriaStateList.Add(new State("Edo", 254));
            nigeriaStateList.Add(new State("Borno", 255));
            nigeriaStateList.Add(new State("Delta", 256));
            nigeriaStateList.Add(new State("Ondo", 257));
            egyptStatesList.Add(new State("Sokoto", 258));
            nigeriaStateList.Add(new State("Taraba", 259));

            africacountryList = new ObservableCollection<Country>();

            africacountryList.Add(new Country("South Africa", 14, stateList6));
            africacountryList.Add(new Country("Algeria", 15, stateList7));
            africacountryList.Add(new Country("Angola", 31, angolaStateList));
            africacountryList.Add(new Country("Egypt", 32, egyptStatesList));
            africacountryList.Add(new Country("Nigeria", 33, nigeriaStateList));


            continentList.Add(new Continent("Africa", 4, africacountryList));            

            treeViewAdv1.DataRelations.Clear();

            treeViewAdv1.DisplayMember = "ContinentName\\CountryName\\StateName";
            treeViewAdv1.ChildMember = "Continent\\Country\\State";

            treeViewAdv1.DataSource = continentList;

        }

        /// <summary>
        /// Method used to select the single item in treeViewAdv.
        /// </summary>
        /// <param name="sender">Specifies the object.</param>
        /// <param name="e">Specifies the EventArgs that contains the event data.</param>
        private void button1_Click(object sender, EventArgs e)
        {
            treeViewAdv1.SelectedItem = dataTable1.Rows[3];
        }

        /// <summary>
        /// Method used to select multiple items in treeViewAdv.
        /// </summary>
        /// <param name="sender">Specifies the object.</param>
        /// <param name="e">Specifies the EventArgs that contains the event data.</param>
        private void button2_Click(object sender, EventArgs e)
        {
            BindingList<object> rows = new BindingList<object>();
            rows.Add(dataTable1.Rows[0]);
            rows.Add(dataTable1.Rows[1]);
            rows.Add(dataTable1.Rows[13]);
            treeViewAdv1.SelectedItems = rows;
        }
    }
}

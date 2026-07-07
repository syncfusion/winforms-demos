#region Copyright Syncfusion Inc. 2001 - 2015
//
//  Copyright Syncfusion Inc. 2001 - 2015. All rights reserved.
//
//  Use of this code is subject to the terms of our license.
//  A copy of the current license can be obtained at any time by e-mailing
//  licensing@syncfusion.com. Any infringement will be prosecuted under
//  applicable laws. 
//
#endregion

using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

using Syncfusion.Grouping;
using Syncfusion.Windows.Forms.Grid;
using Syncfusion.Windows.Forms.Grid.Grouping;
using Syncfusion.GridHelperClasses;
using Syncfusion.Windows.Forms;
using DemoCommon.Grid;

namespace ForeignKeyReference
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : GridDemoForm
    {
        #region "API definition" 
        private Syncfusion.Windows.Forms.Grid.Grouping.GridGroupingControl gridGroupingControl1;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;
        DataTable usStates, countries;
        private Syncfusion.Windows.Forms.Tools.RadioButtonAdv radHelper;
        private Panel panel1;
        private Panel panel2;
        private Syncfusion.Windows.Forms.Tools.RadioButtonAdv radManual;
        #endregion

        #region "Constructor
        public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
            if (DpiAware.GetCurrentDpi() > 96)
            {
                this.CaptionBarHeight = (int)DpiAware.LogicalToDeviceUnits(this.CaptionBarHeight);
            }
            PopulateUSStates();
            PopulateCountries();

			//this.gridGroupingControl1.DataSource = CreateMainTable();

            SampleCustomization();
           
            this.GridSettings();
        }
        #endregion

        #region "Sample Customization"

        /// <summary>
        /// Helps to setup RelationKind.ForeignKeyReference relation .
        /// </summary>
        private void SampleCustomization()
        {
            gridGroupingControl1.DataSource = null;
            gridGroupingControl1.DataMember = "";

            gridGroupingControl1.TableDescriptor.Relations.Clear();

            this.gridGroupingControl1.Engine.SourceListSet.Add("Countries", countries.DefaultView);
            this.gridGroupingControl1.Engine.SourceListSet.Add("USStates", usStates.DefaultView);

            GridTableDescriptor mainTd = this.gridGroupingControl1.TableDescriptor;


            GridRelationDescriptor usStatesRd = new GridRelationDescriptor();
            usStatesRd.Name = "State";
            usStatesRd.RelationKind = RelationKind.ForeignKeyReference;
            usStatesRd.ChildTableName = "USStates";  // SourceListSet name for lookup
            usStatesRd.RelationKeys.Add("State", "Key");
            usStatesRd.ChildTableDescriptor.Appearance.AlternateRecordFieldCell.BackColor = Color.FromArgb(255, 245, 227);
            //usStatesRd.ChildTableDescriptor.VisibleColumns.Add("Name");
            usStatesRd.ChildTableDescriptor.SortedColumns.Add("Name");
            usStatesRd.ChildTableDescriptor.AllowEdit = false;
            usStatesRd.ChildTableDescriptor.AllowNew = false;  // Make pencil icon disappear, users can't modify states.
            mainTd.Relations.Add(usStatesRd);

            GridRelationDescriptor countriesRd = new GridRelationDescriptor();

            countriesRd.RelationKind = RelationKind.ForeignKeyReference;
            countriesRd.ChildTableName = "Countries";  // SourceListSet name for lookup
            countriesRd.RelationKeys.Add("Country", "CountryCode");
            countriesRd.ChildTableDescriptor.Appearance.AlternateRecordFieldCell.BackColor = Color.FromArgb(255, 245, 227);
            countriesRd.ChildTableDescriptor.AllowEdit = true;
            countriesRd.ChildTableDescriptor.AllowNew = true;  // Make pencil icon appear, allow user to add countries (these setting will be overriden by CountriesCollection.IsReadOnly / CountriesCollection.IsFixedSize properties if they are true).
            mainTd.Relations.Add(countriesRd);

            gridGroupingControl1.DataSource = CreateMainTable();
			this.gridGroupingControl1.TableControl.DpiAware = true;

        }

        #region "Events"

        private void radHelper_CheckedChanged(object sender, EventArgs e)
        {
            if (radHelper.Checked)
            {
				gridGroupingControl1.TableDescriptor.Relations.Clear();
                gridGroupingControl1.DataSource = null;
                gridGroupingControl1.DataMember = "";
                gridGroupingControl1.DataSource = CreateMainTable();
                GridForeignKeyHelper.SetupForeignTableLookUp(gridGroupingControl1, "Country", countries, "CountryCode", "CountryName");
                gridGroupingControl1.TableDescriptor.VisibleColumns.Remove("State");
                GridSettings();
            }
        }

        private void radManual_CheckedChanged(object sender, EventArgs e)
        {
            if (radManual.Checked)
            {
                SampleCustomization();
                GridSettings();
            }
        }
        #endregion

        #endregion

        #region "Sample Grid Settings"

        /// <summary>
        /// GridGrouping control getting started customization.
        /// </summary>
        private void GridSettings()
        {

            this.gridGroupingControl1.TopLevelGroupOptions.ShowAddNewRecordBeforeDetails = false;
            //Used for disabling Caption
            this.gridGroupingControl1.TopLevelGroupOptions.ShowCaption = false;
            //used to set multiextended selection mode in gridgrouping control. 
            this.gridGroupingControl1.TableOptions.ListBoxSelectionMode = SelectionMode.MultiExtended;

            //used to set GridCaptionRowHeight.
            this.gridGroupingControl1.Table.DefaultCaptionRowHeight = (int)DpiAware.LogicalToDeviceUnits(25);
            this.gridGroupingControl1.Table.DefaultColumnHeaderRowHeight = (int)DpiAware.LogicalToDeviceUnits(30);
            this.gridGroupingControl1.Table.DefaultRecordRowHeight = (int)DpiAware.LogicalToDeviceUnits(22);
            this.gridGroupingControl1.AllowProportionalColumnSizing = true;
            //GridColor settings
            this.gridGroupingControl1.TableDescriptor.AllowNew = false;
            this.gridGroupingControl1.TableDescriptor.Appearance.AnyCell.Font.Facename = "Segoe UI";
            this.gridGroupingControl1.TableDescriptor.Appearance.AnyCell.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gridGroupingControl1.TableDescriptor.Appearance.AnyGroupCell.Borders.Bottom = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234))))), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin);
            this.gridGroupingControl1.TableDescriptor.Appearance.AnyGroupCell.Borders.Right = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234))))), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin);
            this.gridGroupingControl1.TableDescriptor.Appearance.AnyGroupCell.Interior = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235))))));
            this.gridGroupingControl1.TableDescriptor.Appearance.AnyGroupCell.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gridGroupingControl1.TableDescriptor.Appearance.AnyRecordFieldCell.Borders.Bottom = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234))))), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin);
            this.gridGroupingControl1.TableDescriptor.Appearance.AnyRecordFieldCell.Borders.Right = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234))))), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin);
            this.gridGroupingControl1.TableDescriptor.Appearance.AnySummaryCell.Borders.Right = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208))))), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin);
            this.gridGroupingControl1.TableDescriptor.Appearance.AnySummaryCell.Borders.Top = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208))))), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin);
            this.gridGroupingControl1.TableDescriptor.Appearance.AnySummaryCell.Interior = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208))))));
            this.gridGroupingControl1.TableDescriptor.Appearance.ColumnHeaderCell.Font.Bold = true;
            this.gridGroupingControl1.TableDescriptor.Appearance.GroupCaptionCell.CellType = "ColumnHeader";
            this.gridGroupingControl1.TableDescriptor.TableOptions.ColumnHeaderRowHeight = (int)DpiAware.LogicalToDeviceUnits(25);
            this.gridGroupingControl1.TableDescriptor.TableOptions.RecordRowHeight = (int)DpiAware.LogicalToDeviceUnits(20);

            //Navigate to other control using tabkey navigation
            this.gridGroupingControl1.WantTabKey = false;
        }

        #endregion

        #region "DataTables"

        private DataTable CreateMainTable()
        {
            DataTable table = new DataTable();
            table.Columns.Add("Id", typeof(string));
            table.Columns.Add("Country", typeof(string));
            table.Columns.Add("State", typeof(string));

            // and then add a few rows:
            for (int i = 0; i < 50; i++)
            {
                table.Rows.Add(table.NewRow());
                table.Rows[i][0] = i;
                table.Rows[i][1] = countries.Rows[i % 8]["CountryCode"].ToString();
                table.Rows[i][2] = usStates.Rows[i % 8]["Key"].ToString();
            }
            return table;
        }

        private void PopulateUSStates()
        {
            usStates = new DataTable("USStates");
            usStates.Columns.Add("Key");
            usStates.Columns.Add("Name");
            usStates.Rows.Add(new object[] { "AL", "Alabama" });
            usStates.Rows.Add(new object[] { "AK", "Alaska" });
            usStates.Rows.Add(new object[] { "AZ", "Arizona" });
            usStates.Rows.Add(new object[]{"AR", "Arkansas"});
            usStates.Rows.Add(new object[]{"CA", "California"});
            usStates.Rows.Add(new object[]{"CO", "Colorado"});
            usStates.Rows.Add(new object[]{"CT", "Connecticut"});
            usStates.Rows.Add(new object[]{"DC", "D.C."});
            usStates.Rows.Add(new object[]{"DE", "Delaware"});
            usStates.Rows.Add(new object[]{"FL", "Florida"});
            usStates.Rows.Add(new object[]{"GA", "Georgia"});
            usStates.Rows.Add(new object[]{"HI", "Hawaii"});
            usStates.Rows.Add(new object[]{"ID", "Idaho"});
            usStates.Rows.Add(new object[]{"IL", "Illinois"});
            usStates.Rows.Add(new object[]{"IN", "Indiana"});
            usStates.Rows.Add(new object[]{"IA", "Iowa"});
            usStates.Rows.Add(new object[]{"KS", "Kansas"});
            usStates.Rows.Add(new object[]{"KY", "Kentucky"});
            usStates.Rows.Add(new object[]{"LA", "Louisiana"});
            usStates.Rows.Add(new object[]{"ME", "Maine"});
            usStates.Rows.Add(new object[]{"MD", "Maryland"});
            usStates.Rows.Add(new object[]{"MA", "Massachusetts"});
            usStates.Rows.Add(new object[]{"MI", "Michigan"});
            usStates.Rows.Add(new object[]{"MN", "Minnesota"});
            usStates.Rows.Add(new object[]{"MS", "Mississippi"});
            usStates.Rows.Add(new object[]{"MO", "Missouri"});
            usStates.Rows.Add(new object[]{"MT", "Montana"});
            usStates.Rows.Add(new object[]{"NE", "Nebraska"});
            usStates.Rows.Add(new object[]{"NV", "Nevada"});
            usStates.Rows.Add(new object[]{"NH", "New Hampshire"});
            usStates.Rows.Add(new object[]{"NJ", "New Jersey"});
            usStates.Rows.Add(new object[]{"NM", "New Mexico"});
            usStates.Rows.Add(new object[]{"NY", "New York"});
            usStates.Rows.Add(new object[]{"NC", "North Carolina"});
            usStates.Rows.Add(new object[]{"ND", "North Dakota"});
            usStates.Rows.Add(new object[]{"OH", "Ohio"});
            usStates.Rows.Add(new object[]{"OK", "Oklahoma"});
            usStates.Rows.Add(new object[]{"OR", "Oregon"});
            usStates.Rows.Add(new object[]{"PA", "Pennsylvania"});
            usStates.Rows.Add(new object[]{"RI", "Rhode Island"});
            usStates.Rows.Add(new object[]{"SC", "South Carolina"});
            usStates.Rows.Add(new object[]{"SD", "South Dakota"});
            usStates.Rows.Add(new object[]{"TN", "Tennessee"});
            usStates.Rows.Add(new object[]{"TX", "Texas"});
            usStates.Rows.Add(new object[]{"UT", "Utah"});
            usStates.Rows.Add(new object[]{"VT", "Vermont"});
            usStates.Rows.Add(new object[]{"VA", "Virginia"});
            usStates.Rows.Add(new object[]{"WA", "Washington"});
            usStates.Rows.Add(new object[]{"WV", "West Virginia"});
            usStates.Rows.Add(new object[]{"WI", "Wisconsin"});
            usStates.Rows.Add(new object[]{"WY", "Wyoming"});
            usStates.Rows.Add(new object[]{"BC", "British Columbia"});
            usStates.Rows.Add(new object[]{"MB", "Manitoba"});
            usStates.Rows.Add(new object[]{"NB", "New Brunswick"});
            usStates.Rows.Add(new object[]{"NL", "Newfoundland and Labrador"});
            usStates.Rows.Add(new object[]{"NT", "Northwest Territories"});
            usStates.Rows.Add(new object[]{"NS", "Nova Scotia"});
            usStates.Rows.Add(new object[]{"NU", "Nunavut"});
            usStates.Rows.Add(new object[]{"ON", "Ontario"});
            usStates.Rows.Add(new object[]{"PE", "Prince Edward Island"});
            usStates.Rows.Add(new object[]{"QC", "Quebec"});
            usStates.Rows.Add(new object[]{"SK", "Saskatchewan"});
            usStates.Rows.Add(new object[] { "YT", "Yukon Territories" });
        }

        private void PopulateCountries()
        {
            countries = new DataTable("Countries");
            countries.Columns.Add("CountryCode");
            countries.Columns.Add("CountryName");
                countries.Rows.Add(new object[]{"US", "United States"});
			countries.Rows.Add(new object[]{"CA", "Canada"});
			countries.Rows.Add(new object[]{"AF", "Afghanistan"});
			countries.Rows.Add(new object[]{"AL", "Albania"});
			countries.Rows.Add(new object[]{"DZ", "Algeria"});
			countries.Rows.Add(new object[]{"AS", "American Samoa"});
			countries.Rows.Add(new object[]{"AD", "Andorra"});
			countries.Rows.Add(new object[]{"AO", "Angola"});
			countries.Rows.Add(new object[]{"AI", "Anguilla"});
			countries.Rows.Add(new object[]{"AQ", "Antarctica"});
			countries.Rows.Add(new object[]{"AG", "Antigua and Barbuda"});
			countries.Rows.Add(new object[]{"AR", "Argentina"});
			countries.Rows.Add(new object[]{"AM", "Armenia"});
			countries.Rows.Add(new object[]{"AW", "Aruba"});
			countries.Rows.Add(new object[]{"AU", "Australia"});
			countries.Rows.Add(new object[]{"AT", "Austria"});
			countries.Rows.Add(new object[]{"AZ", "Azerbaijan"});
			countries.Rows.Add(new object[]{"BS", "Bahamas"});
			countries.Rows.Add(new object[]{"BH", "Bahrain"});
			countries.Rows.Add(new object[]{"BD", "Bangladesh"});
			countries.Rows.Add(new object[]{"BB", "Barbados"});
			countries.Rows.Add(new object[]{"BY", "Belarus"});
			countries.Rows.Add(new object[]{"BE", "Belgium"});
			countries.Rows.Add(new object[]{"BZ", "Belize"});
			countries.Rows.Add(new object[]{"BJ", "Benin"});
			countries.Rows.Add(new object[]{"BM", "Bermuda"});
			countries.Rows.Add(new object[]{"BT", "Bhutan"});
			countries.Rows.Add(new object[]{"BO", "Bolivia"});
			countries.Rows.Add(new object[]{"BA", "Bosnia and Herzegovina"});
			countries.Rows.Add(new object[]{"BW", "Botswana"});
			countries.Rows.Add(new object[]{"BV", "Bouvet Island"});
			countries.Rows.Add(new object[]{"BR", "Brazil"});
			countries.Rows.Add(new object[]{"IO", "British Indian Ocean Territory"});
			countries.Rows.Add(new object[]{"BN", "Brunei Darussalam"});
			countries.Rows.Add(new object[]{"BG", "Bulgaria"});
			countries.Rows.Add(new object[]{"BF", "Burkina Faso"});
			countries.Rows.Add(new object[]{"BI", "Burundi"});
			countries.Rows.Add(new object[]{"KH", "Cambodia"});
			countries.Rows.Add(new object[]{"CM", "Cameroon"});
			countries.Rows.Add(new object[]{"CV", "Cape Verde"});
			countries.Rows.Add(new object[]{"KY", "Cayman Islands"});
			countries.Rows.Add(new object[]{"CF", "Central African Republic"});
			countries.Rows.Add(new object[]{"TD", "Chad"});
			countries.Rows.Add(new object[]{"CL", "Chile"});
			countries.Rows.Add(new object[]{"CN", "China"});
			countries.Rows.Add(new object[]{"CX", "Christmas Island"});
			countries.Rows.Add(new object[]{"CC", "Cocos (Keeling) Islands"});
			countries.Rows.Add(new object[]{"CO", "Colombia"});
			countries.Rows.Add(new object[]{"KM", "Comoros"});
			countries.Rows.Add(new object[]{"CG", "Congo"});
			countries.Rows.Add(new object[]{"CK", "Cook Islands"});
			countries.Rows.Add(new object[]{"CR", "Costa Rica"});
			countries.Rows.Add(new object[]{"CI", "Cote D'Ivoire (Ivory Coast)"});
			countries.Rows.Add(new object[]{"HR", "Croatia (Hrvatska)"});
			countries.Rows.Add(new object[]{"CU", "Cuba"});
			countries.Rows.Add(new object[]{"CY", "Cyprus"});
			countries.Rows.Add(new object[]{"CZ", "Czech Republic"});
			countries.Rows.Add(new object[]{"DK", "Denmark"});
			countries.Rows.Add(new object[]{"DJ", "Djibouti"});
			countries.Rows.Add(new object[]{"DM", "Dominica"});
			countries.Rows.Add(new object[]{"DO", "Dominican Republic"});
			countries.Rows.Add(new object[]{"TP", "East Timor"});
			countries.Rows.Add(new object[]{"EC", "Ecuador"});
			countries.Rows.Add(new object[]{"EG", "Egypt"});
			countries.Rows.Add(new object[]{"SV", "El Salvador"});
			countries.Rows.Add(new object[]{"GQ", "Equatorial Guinea"});
			countries.Rows.Add(new object[]{"ER", "Eritrea"});
			countries.Rows.Add(new object[]{"EE", "Estonia"});
			countries.Rows.Add(new object[]{"ET", "Ethiopia"});
			countries.Rows.Add(new object[]{"FK", "Falkland Islands (Malvinas)"});
			countries.Rows.Add(new object[]{"FO", "Faroe Islands"});
			countries.Rows.Add(new object[]{"FJ", "Fiji"});
			countries.Rows.Add(new object[]{"FI", "Finland"});
			countries.Rows.Add(new object[]{"FR", "France"});
			countries.Rows.Add(new object[]{"GF", "French Guiana"});
			countries.Rows.Add(new object[]{"PF", "French Polynesia"});
			countries.Rows.Add(new object[]{"TF", "French Southern Territories"});
			countries.Rows.Add(new object[]{"GA", "Gabon"});
			countries.Rows.Add(new object[]{"GM", "Gambia"});
			countries.Rows.Add(new object[]{"GZ", "Gaza"});
			countries.Rows.Add(new object[]{"GE", "Georgia"});
			countries.Rows.Add(new object[]{"DE", "Germany"});
			countries.Rows.Add(new object[]{"GH", "Ghana"});
			countries.Rows.Add(new object[]{"GI", "Gibraltar"});
			countries.Rows.Add(new object[]{"GR", "Greece"});
			countries.Rows.Add(new object[]{"GL", "Greenland"});
			countries.Rows.Add(new object[]{"GD", "Grenada"});
			countries.Rows.Add(new object[]{"GP", "Guadeloupe"});
			countries.Rows.Add(new object[]{"GU", "Guam"});
			countries.Rows.Add(new object[]{"GT", "Guatemala"});
			countries.Rows.Add(new object[]{"GN", "Guinea"});
			countries.Rows.Add(new object[]{"GW", "Guinea-Bissau"});
			countries.Rows.Add(new object[]{"GY", "Guyana"});
			countries.Rows.Add(new object[]{"HT", "Haiti"});
			countries.Rows.Add(new object[]{"HM", "Heard and McDonald Islands"});
			countries.Rows.Add(new object[]{"HN", "Honduras"});
			countries.Rows.Add(new object[]{"HK", "Hong Kong"});
			countries.Rows.Add(new object[]{"HU", "Hungary"});
			countries.Rows.Add(new object[]{"IS", "Iceland"});
			countries.Rows.Add(new object[]{"IN", "India"});
			countries.Rows.Add(new object[]{"ID", "Indonesia"});
			countries.Rows.Add(new object[]{"IR", "Iran"});
			countries.Rows.Add(new object[]{"IQ", "Iraq"});
			countries.Rows.Add(new object[]{"IE", "Ireland"});
			countries.Rows.Add(new object[]{"IL", "Israel"});
			countries.Rows.Add(new object[]{"IT", "Italy"});
			countries.Rows.Add(new object[]{"JM", "Jamaica"});
			countries.Rows.Add(new object[]{"JP", "Japan"});
			countries.Rows.Add(new object[]{"JO", "Jordan"});
			countries.Rows.Add(new object[]{"KZ", "Kazakhstan"});
			countries.Rows.Add(new object[]{"KE", "Kenya"});
			countries.Rows.Add(new object[]{"KI", "Kiribati"});
			countries.Rows.Add(new object[]{"KP", "Korea (North)"});
			countries.Rows.Add(new object[]{"KR", "Korea (South)"});
			countries.Rows.Add(new object[]{"KW", "Kuwait"});
			countries.Rows.Add(new object[]{"KG", "Kyrgyzstan"});
			countries.Rows.Add(new object[]{"LA", "Laos"});
			countries.Rows.Add(new object[]{"LV", "Latvia"});
			countries.Rows.Add(new object[]{"LB", "Lebanon"});
			countries.Rows.Add(new object[]{"LS", "Lesotho"});
			countries.Rows.Add(new object[]{"LR", "Liberia"});
			countries.Rows.Add(new object[]{"LY", "Libya"});
			countries.Rows.Add(new object[]{"LI", "Liechtenstein"});
			countries.Rows.Add(new object[]{"LT", "Lithuania"});
			countries.Rows.Add(new object[]{"LU", "Luxembourg"});
			countries.Rows.Add(new object[]{"MO", "Macau"});
			countries.Rows.Add(new object[]{"MK", "Macedonia"});
			countries.Rows.Add(new object[]{"MG", "Madagascar"});
			countries.Rows.Add(new object[]{"MW", "Malawi"});
			countries.Rows.Add(new object[]{"MY", "Malaysia"});
			countries.Rows.Add(new object[]{"MV", "Maldives"});
			countries.Rows.Add(new object[]{"ML", "Mali"});
			countries.Rows.Add(new object[]{"MT", "Malta"});
			countries.Rows.Add(new object[]{"MH", "Marshall Islands"});
			countries.Rows.Add(new object[]{"MQ", "Martinique"});
			countries.Rows.Add(new object[]{"MR", "Mauritania"});
			countries.Rows.Add(new object[]{"MU", "Mauritius"});
			countries.Rows.Add(new object[]{"YT", "Mayotte"});
			countries.Rows.Add(new object[]{"MX", "Mexico"});
			countries.Rows.Add(new object[]{"FM", "Micronesia"});
			countries.Rows.Add(new object[]{"MD", "Moldova"});
			countries.Rows.Add(new object[]{"MC", "Monaco"});
			countries.Rows.Add(new object[]{"MN", "Mongolia"});
			countries.Rows.Add(new object[]{"MS", "Montserrat"});
			countries.Rows.Add(new object[]{"MA", "Morocco"});
			countries.Rows.Add(new object[]{"MZ", "Mozambique"});
			countries.Rows.Add(new object[]{"MM", "Myanmar"});
			countries.Rows.Add(new object[]{"NA", "Namibia"});
			countries.Rows.Add(new object[]{"NR", "Nauru"});
			countries.Rows.Add(new object[]{"NP", "Nepal"});
			countries.Rows.Add(new object[]{"NL", "Netherlands"});
			countries.Rows.Add(new object[]{"AN", "Netherlands Antilles"});
			countries.Rows.Add(new object[]{"NC", "New Caledonia"});
			countries.Rows.Add(new object[]{"NZ", "New Zealand"});
			countries.Rows.Add(new object[]{"NI", "Nicaragua"});
			countries.Rows.Add(new object[]{"NE", "Niger"});
			countries.Rows.Add(new object[]{"NG", "Nigeria"});
			countries.Rows.Add(new object[]{"NU", "Niue"});
			countries.Rows.Add(new object[]{"NF", "Norfolk Island"});
			countries.Rows.Add(new object[]{"MP", "Northern Mariana Islands"});
			countries.Rows.Add(new object[]{"NO", "Norway"});
			countries.Rows.Add(new object[]{"OM", "Oman"});
			countries.Rows.Add(new object[]{"PK", "Pakistan"});
			countries.Rows.Add(new object[]{"PW", "Palau"});
			countries.Rows.Add(new object[]{"PA", "Panama"});
			countries.Rows.Add(new object[]{"PG", "Papua New Guinea"});
			countries.Rows.Add(new object[]{"PY", "Paraguay"});
			countries.Rows.Add(new object[]{"PE", "Peru"});
			countries.Rows.Add(new object[]{"PH", "Philippines"});
			countries.Rows.Add(new object[]{"PN", "Pitcairn"});
			countries.Rows.Add(new object[]{"PL", "Poland"});
			countries.Rows.Add(new object[]{"PT", "Portugal"});
			countries.Rows.Add(new object[]{"PR", "Puerto Rico"});
			countries.Rows.Add(new object[]{"QA", "Qatar"});
			countries.Rows.Add(new object[]{"RE", "Reunion"});
			countries.Rows.Add(new object[]{"RO", "Romania"});
			countries.Rows.Add(new object[]{"RU", "Russian Federation"});
			countries.Rows.Add(new object[]{"RW", "Rwanda"});
			countries.Rows.Add(new object[]{"KN", "Saint Kitts and Nevis"});
			countries.Rows.Add(new object[]{"LC", "Saint Lucia"});
			countries.Rows.Add(new object[]{"VC", "Saint Vincent and the Grenadines"});
			countries.Rows.Add(new object[]{"WS", "Samoa"});
			countries.Rows.Add(new object[]{"SM", "San Marino"});
			countries.Rows.Add(new object[]{"ST", "Sao Tome and Principe"});
			countries.Rows.Add(new object[]{"SA", "Saudi Arabia"});
			countries.Rows.Add(new object[]{"SN", "Senegal"});
			countries.Rows.Add(new object[]{"SC", "Seychelles"});
			countries.Rows.Add(new object[]{"SL", "Sierra Leone"});
			countries.Rows.Add(new object[]{"SG", "Singapore"});
			countries.Rows.Add(new object[]{"SK", "Slovak Republic"});
			countries.Rows.Add(new object[]{"SI", "Slovenia"});
			countries.Rows.Add(new object[]{"SB", "Solomon Islands"});
			countries.Rows.Add(new object[]{"SO", "Somalia"});
			countries.Rows.Add(new object[]{"ZA", "South Africa"});
			countries.Rows.Add(new object[]{"ES", "Spain"});
			countries.Rows.Add(new object[]{"LK", "Sri Lanka"});
			countries.Rows.Add(new object[]{"SH", "St. Helena"});
			countries.Rows.Add(new object[]{"PM", "St. Pierre and Miquelon"});
			countries.Rows.Add(new object[]{"SD", "Sudan"});
			countries.Rows.Add(new object[]{"SR", "Suriname"});
			countries.Rows.Add(new object[]{"SJ", "Svalbard and Jan Mayen Islands"});
			countries.Rows.Add(new object[]{"SZ", "Swaziland"});
			countries.Rows.Add(new object[]{"SE", "Sweden"});
			countries.Rows.Add(new object[]{"CH", "Switzerland"});
			countries.Rows.Add(new object[]{"SY", "Syria"});
			countries.Rows.Add(new object[]{"TW", "Taiwan"});
			countries.Rows.Add(new object[]{"TJ", "Tajikistan"});
			countries.Rows.Add(new object[]{"TZ", "Tanzania"});
			countries.Rows.Add(new object[]{"TH", "Thailand"});
			countries.Rows.Add(new object[]{"TG", "Togo"});
			countries.Rows.Add(new object[]{"TK", "Tokelau"});
			countries.Rows.Add(new object[]{"TO", "Tonga"});
			countries.Rows.Add(new object[]{"TT", "Trinidad and Tobago"});
			countries.Rows.Add(new object[]{"TN", "Tunisia"});
			countries.Rows.Add(new object[]{"TR", "Turkey"});
			countries.Rows.Add(new object[]{"TM", "Turkmenistan"});
			countries.Rows.Add(new object[]{"TC", "Turks and Caicos Islands"});
			countries.Rows.Add(new object[]{"TV", "Tuvalu"});
			countries.Rows.Add(new object[]{"UG", "Uganda"});
			countries.Rows.Add(new object[]{"UA", "Ukraine"});
			countries.Rows.Add(new object[]{"AE", "United Arab Emirates"});
			countries.Rows.Add(new object[]{"GB", "United Kingdom"});
			countries.Rows.Add(new object[]{"UY", "Uruguay"});
			countries.Rows.Add(new object[]{"UM", "US Minor Outlying Islands"});
			countries.Rows.Add(new object[]{"UZ", "Uzbekistan"});
			countries.Rows.Add(new object[]{"VU", "Vanuatu"});
			countries.Rows.Add(new object[]{"VA", "Vatican City State (Holy See)"});
			countries.Rows.Add(new object[]{"VE", "Venezuela"});
			countries.Rows.Add(new object[]{"VN", "Viet Nam"});
			countries.Rows.Add(new object[]{"VG", "Virgin Islands (British)"});
			countries.Rows.Add(new object[]{"VI", "Virgin Islands (U.S.)"});
			countries.Rows.Add(new object[]{"WF", "Wallis and Futuna Islands"});
			countries.Rows.Add(new object[]{"WB", "West Bank"});
			countries.Rows.Add(new object[]{"EH", "Western Sahara"});
			countries.Rows.Add(new object[]{"YE", "Yemen"});
			countries.Rows.Add(new object[]{"YU", "Yugoslavia"});
			countries.Rows.Add(new object[]{"ZR", "Zaire"});
			countries.Rows.Add(new object[]{"ZM", "Zambia"});
			countries.Rows.Add(new object[]{"ZW", "Zimbabwe"});
        }
        #endregion

        #region "Designer Stuffs"

        #region "Dispose"
        /// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

        #endregion

        #region "Windows Form Designer generated code"
        /// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.gridGroupingControl1 = new Syncfusion.Windows.Forms.Grid.Grouping.GridGroupingControl();
            this.radHelper = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
            this.radManual = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.gridGroupingControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radHelper)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radManual)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridGroupingControl1
            // 
            this.gridGroupingControl1.AlphaBlendSelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(94)))), ((int)(((byte)(171)))), ((int)(((byte)(222)))));
            this.gridGroupingControl1.BackColor = System.Drawing.SystemColors.Window;
            this.gridGroupingControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridGroupingControl1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridGroupingControl1.FreezeCaption = false;
            this.gridGroupingControl1.GridOfficeScrollBars = Syncfusion.Windows.Forms.OfficeScrollBars.Metro;
            this.gridGroupingControl1.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro;
            this.gridGroupingControl1.IntelliMousePanning = true;
            this.gridGroupingControl1.Location = new System.Drawing.Point(0, 0);
            this.gridGroupingControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gridGroupingControl1.Name = "gridGroupingControl1";
            this.gridGroupingControl1.ShowCurrentCellBorderBehavior = Syncfusion.Windows.Forms.Grid.GridShowCurrentCellBorder.GrayWhenLostFocus;
            this.gridGroupingControl1.Size = new System.Drawing.Size(1214, 1010);
            this.gridGroupingControl1.TabIndex = 0;
            this.gridGroupingControl1.TableDescriptor.AllowNew = false;
            this.gridGroupingControl1.TableDescriptor.Appearance.AnyCell.Font.Facename = "Segoe UI";
            this.gridGroupingControl1.TableDescriptor.Appearance.AnyCell.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gridGroupingControl1.TableDescriptor.Appearance.AnyGroupCell.Borders.Bottom = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234))))), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin);
            this.gridGroupingControl1.TableDescriptor.Appearance.AnyGroupCell.Borders.Right = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234))))), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin);
            this.gridGroupingControl1.TableDescriptor.Appearance.AnyGroupCell.Interior = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235))))));
            this.gridGroupingControl1.TableDescriptor.Appearance.AnyGroupCell.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gridGroupingControl1.TableDescriptor.Appearance.AnyRecordFieldCell.Borders.Bottom = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234))))), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin);
            this.gridGroupingControl1.TableDescriptor.Appearance.AnyRecordFieldCell.Borders.Right = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234))))), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin);
            this.gridGroupingControl1.TableDescriptor.Appearance.AnySummaryCell.Borders.Right = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208))))), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin);
            this.gridGroupingControl1.TableDescriptor.Appearance.AnySummaryCell.Borders.Top = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208))))), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin);
            this.gridGroupingControl1.TableDescriptor.Appearance.AnySummaryCell.Interior = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208))))));
            this.gridGroupingControl1.TableDescriptor.Appearance.ColumnHeaderCell.Font.Bold = true;
            this.gridGroupingControl1.TableDescriptor.Appearance.GroupCaptionCell.CellType = "ColumnHeader";
            this.gridGroupingControl1.TableDescriptor.TableOptions.ColumnHeaderRowHeight = 38;
            this.gridGroupingControl1.TableDescriptor.TableOptions.RecordRowHeight = 30;
            this.gridGroupingControl1.Text = "gridGroupingControl1";
            // 
            // radHelper
            // 
            this.radHelper.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radHelper.BeforeTouchSize = new System.Drawing.Size(214, 37);
            this.radHelper.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radHelper.ForeColor = System.Drawing.Color.DimGray;
            this.radHelper.ImageCheckBoxSize = new System.Drawing.Size(19, 19);
            this.radHelper.Location = new System.Drawing.Point(28, 55);
            this.radHelper.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radHelper.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.radHelper.Name = "radHelper";
            this.radHelper.Size = new System.Drawing.Size(214, 37);
            this.radHelper.Style = Syncfusion.Windows.Forms.Tools.RadioButtonAdvStyle.Metro;
            this.radHelper.DrawFocusRectangle = true;
            this.radHelper.TabIndex = 1;
            this.radHelper.TabStop = false;
            this.radHelper.Text = "Use ForeignKeyHelper";
            this.radHelper.ThemesEnabled = false;
            this.radHelper.CheckChanged += new System.EventHandler(this.radHelper_CheckedChanged);
            // 
            // radManual
            // 
            this.radManual.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radManual.BeforeTouchSize = new System.Drawing.Size(168, 37);
            this.radManual.Checked = true;
            this.radManual.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radManual.ForeColor = System.Drawing.Color.DimGray;
            this.radManual.ImageCheckBoxSize = new System.Drawing.Size(19, 19);
            this.radManual.Location = new System.Drawing.Point(28, 148);
            this.radManual.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radManual.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.radManual.Name = "radManual";
            this.radManual.Size = new System.Drawing.Size(168, 37);
            this.radManual.Style = Syncfusion.Windows.Forms.Tools.RadioButtonAdvStyle.Metro;
            this.radManual.DrawFocusRectangle = true;
            this.radManual.TabIndex = 2;
            this.radManual.Text = "Manual Relation";
            this.radManual.ThemesEnabled = false;
            this.radManual.CheckChanged += new System.EventHandler(this.radManual_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Dock = DockStyle.Right;
            this.panel1.Controls.Add(this.radHelper);
            this.panel1.Controls.Add(this.radManual);
            this.panel1.Location = new System.Drawing.Point(1252, 18);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(248, 300);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.gridGroupingControl1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1214, 1010);
            this.panel2.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1513, 1010);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(1189, 739);
            
            this.Name = "Form1";
            this.Text = "Foreign-Key Reference ";
            ((System.ComponentModel.ISupportInitialize)(this.gridGroupingControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radHelper)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radManual)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
        {
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense(Syncfusion.Licensing.DemoCommon.FindLicenseKey());
			Application.Run(new Form1());
		}

        #endregion

      
    }
}

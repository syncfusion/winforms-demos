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
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Syncfusion.GridHelperClasses;
using System.Data.SqlClient;
using System.Data.SqlServerCe;
using System.IO;
using DemoCommon.Grid;
using Syncfusion.Windows.Forms.Grid.Grouping;
using System.Text.RegularExpressions;

namespace GridFieldChooser
{
    /// <summary>
    /// Summary description for Form1.
    /// </summary>
    public partial class Form1 : GridDemoForm
    {
        #region API Definitions
        public readonly static string connString = @"Data Source=" + FindFile("NorthwindwithImage.sdf");
        #endregion

        #region Constructor

        /// <summary>
        ///  Form Constructor.
        /// </summary>
        public Form1()
        {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();
            this.GridSettings();
            this.SampleCustomization();
        }
        #endregion

        #region GridSettings

        /// <summary>
        /// Required Method for Grid Settings
        /// </summary>
        void GridSettings()
        {
            #region Datasource
            String commandstring = "select * from Products";
            SqlCeDataAdapter da = new SqlCeDataAdapter(commandstring, connString);

            DataSet ds = new DataSet();

            da.Fill(ds, "Customers");
            gridGroupingControl1.DataSource = ds.Tables[0];
            #endregion

            this.gridGroupingControl1.TableControl.DpiAware = true;
			this.gridGroupingControl1.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro;
            this.gridGroupingControl1.TopLevelGroupOptions.ShowCaption = false;
            this.gridGroupingControl1.TableOptions.ListBoxSelectionMode = SelectionMode.MultiExtended;
            this.gridGroupingControl1.TopLevelGroupOptions.ShowAddNewRecordBeforeDetails = false;
            //Change the header text for column

            #region HeaderText
            foreach (GridColumnDescriptor col in this.gridGroupingControl1.TableDescriptor.Columns)
            {
                Regex rex = new Regex(@"\p{Lu}");
                int index = rex.Match(col.MappingName.Substring(1)).Index;
                string name = "";
                while (index > 0)
                {
                    name += col.MappingName.Substring(0, index + 1) + " ";
                    string secondName = col.MappingName.Substring(index + 1);
                    index = rex.Match(secondName.Substring(1)).Index;
                    while (index > 0)
                    {
                        name += secondName.Substring(0, index + 1) + " ";
                        index = rex.Match(col.MappingName.Substring(name.Replace(" ", "").Length).Substring(1)).Index;
                    }
                }
                name += col.MappingName.Substring(name.Replace(" ", "").Length);
                col.HeaderText = name;
            }
            #endregion
        }

        #endregion

        #region Sample Customization
        /// <summary>
        /// Required Method for sample level customization.
        /// </summary>
        void SampleCustomization()
        {
            FieldChooser fchooser = new FieldChooser(this.gridGroupingControl1);
        }

        #endregion

        #region Methods

        /// <summary>
        /// Gets the path for the sdf File.
        /// </summary> 
        private static string FindFile(string fileName)
        {
            // Check both in parent folder and Parent\Data folders.
            string dataFileName = @"Common\Data\" + fileName;
            for (int n = 0; n < 12; n++)
            {
                if (System.IO.File.Exists(fileName))
                {
                    return new FileInfo(fileName).FullName;
                }
                if (System.IO.File.Exists(dataFileName))
                {
                    return new FileInfo(dataFileName).FullName;
                }
                fileName = @"..\" + fileName;
                dataFileName = @"..\" + dataFileName;
            }
            return fileName;
        }

        #endregion
    }
}

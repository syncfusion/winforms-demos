#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Syncfusion.Grouping;
using Syncfusion.Windows.Forms.Grid;
using Syncfusion.Windows.Forms.Grid.Grouping;
using Syncfusion.Windows.Forms;
using DemoCommon.Grid;

namespace UniformChildList
{

    public partial class Form1 : GridDemoForm
    {
        #region "API Definition"

        BindingList<ParentObj> topList = new BindingList<ParentObj>();
        BindingList<ChildObj> childList = new BindingList<ChildObj>();
        
        #endregion

        #region "Constructor"

        public Form1() {
            InitializeComponent();
            SetupLists();
            
            grid.DataSource = topList;
                        
            this.SampleCustomization();
          
            this.GridSettings();
        }

        #endregion

        #region "Sample Grid Settings"

        /// <summary>
        /// GridGrouping control getting started customization.
        /// </summary>
        private void GridSettings()
        {
            //used for Disablin ShpwCaption and ShowAddnewRecord.
			this.grid.TableControl.DpiAware = true;
            this.grid.TopLevelGroupOptions.ShowAddNewRecordBeforeDetails = false;
            this.grid.TopLevelGroupOptions.ShowCaption = false;

            //used to set multiextended selection mode in gridgrouping control. 
            this.grid.TableOptions.ListBoxSelectionMode = SelectionMode.MultiExtended;

            //used to set GridCaptionRowHeight.
            this.grid.Table.DefaultCaptionRowHeight = (int)DpiAware.LogicalToDeviceUnits(25);
            this.grid.Table.DefaultColumnHeaderRowHeight = (int)DpiAware.LogicalToDeviceUnits(30);
            this.grid.Table.DefaultRecordRowHeight = (int)DpiAware.LogicalToDeviceUnits(22);
            this.grid.AllowProportionalColumnSizing = true;

            this.grid.GetTable("ChildTable").DefaultRecordRowHeight = (int)DpiAware.LogicalToDeviceUnits(22);

            //Navigate to other control using tabkey navigation
            this.grid.WantTabKey = false;
            
        }

        #endregion

        #region "Sample Customization"

        private void SampleCustomization()
        {
            //creating new relation 
            GridRelationDescriptor relation = new GridRelationDescriptor();
            //Setting relationKind as UniformChileList.
            relation.RelationKind = RelationKind.UniformChildList;
            relation.MappingName = "Child";
            relation.Name = "Child";
            relation.ChildTableName = "ChildTable";
            grid.TableDescriptor.Relations.Add(relation);

            this.grid.ShowGroupDropArea = true;
            GridTable chiltTable = grid.GetTable("ChildTable");
            this.grid.AddGroupDropArea(chiltTable);
            chiltTable.TableDescriptor.GroupedColumns.Add("Field1");
        }

        #region DataSource

        Random r = new Random();

        private void SetupLists()
        {

            for (int i = 0; i < 30; i++)
                childList.Add(new ChildObj(string.Format("Name{0}", r.Next(10)), string.Format("Desc{0}", r.Next(20)), r.Next(30)));

            for (int i = 0; i < 5; i++)
            {
                topList.Add(new ParentObj(string.Format("Name{0}", r.Next(5)), string.Format("Desc{0}", r.Next(15)), r.Next(20)));
                for (int j = i * 5; j < (i * 5) + 5; j++)
                    topList[i].Child.Add(childList[j]);
            }


        }

        #endregion

        #region Click Events
        private void button1_Click(object sender, EventArgs e)
        {
            Record rec = grid.Table.Records[grid.Table.Records.Count - 1];
            string field1 = rec.GetValue("Field1").ToString();
            for (int i = 0; i < topList.Count; i++)
            {
                if (field1 == topList[i].Field1)
                    topList[i].Child.Add(new ChildObj(string.Format("Name{0}", r.Next(10)), string.Format("Desc{0}", r.Next(20)), r.Next(30)));
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 5; i++)
                childList.Add(new ChildObj(string.Format("Name{0}", r.Next(10)), string.Format("Desc{0}", r.Next(20)), r.Next(30)));

            topList.Add(new ParentObj(string.Format("Name{0}", r.Next(2)), string.Format("Desc{0}", r.Next(15)), r.Next(20)));
            for (int j = 0; j < 5; j++)
                topList[topList.Count - 1].Child.Add(childList[childList.Count - (1 + j)]);
        }
        #endregion

        #endregion

        #region "Designer Stuffs"

        [STAThread]
        static void Main()
        {
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense(Syncfusion.Licensing.DemoCommon.FindLicenseKey());
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        #endregion


    }
}
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
using Syncfusion.Windows.Forms.Grid.Grouping;
using Syncfusion.Windows.Forms.Grid;
using System.Diagnostics;
using Syncfusion.Windows.Forms;
using DemoCommon.Grid;


namespace RecursiveNestedCollection
{
    public partial class Form1 : GridDemoForm
    {
        #region "Constructor"

        public Form1()
        {
            //Customize the engine to hide the empty child tables.
            GridEngineFactory.Factory = new GroupingEngineFactory();
            //Setup Grid
            BaseClassList theList = CreateDataLists();

            InitializeComponent();
            if (DpiAware.GetCurrentDpi() > 96)
            {
                this.CaptionBarHeight = (int)DpiAware.LogicalToDeviceUnits(this.CaptionBarHeight);
            }

            gridGroupingControl1.DataSource = theList;
            
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
            //used to set multiextended selection mode in gridgrouping control. 
            this.gridGroupingControl1.TableOptions.ListBoxSelectionMode = SelectionMode.MultiExtended;

            this.gridGroupingControl1.TableControl.DpiAware = true;
			//used to set GridCaptionRowHeight.
            this.gridGroupingControl1.Table.DefaultCaptionRowHeight = (int)DpiAware.LogicalToDeviceUnits(25.0f);
            this.gridGroupingControl1.Table.DefaultColumnHeaderRowHeight = (int)DpiAware.LogicalToDeviceUnits(30.0f);
            this.gridGroupingControl1.Table.DefaultRecordRowHeight = (int)DpiAware.LogicalToDeviceUnits(22.0f);
            this.gridGroupingControl1.AllowProportionalColumnSizing = true;
            this.gridGroupingControl1.Table.ExpandAllRecords();
            this.gridGroupingControl1.TopLevelGroupOptions.ShowCaption = false;
            //setting row height for nested tables
            this.gridGroupingControl1.GetTable("List0_Child0").DefaultRecordRowHeight = (int)DpiAware.LogicalToDeviceUnits(22.0f);
            this.gridGroupingControl1.GetTable("List0_NestedChild0").DefaultRecordRowHeight = (int)DpiAware.LogicalToDeviceUnits(22.0f);
            this.gridGroupingControl1.GetTable("List0_Child1").DefaultRecordRowHeight = (int)DpiAware.LogicalToDeviceUnits(22.0f);
            this.gridGroupingControl1.GetTable("List1_Child0").DefaultRecordRowHeight = (int)DpiAware.LogicalToDeviceUnits(22.0f);
            this.gridGroupingControl1.GetTable("List3_Child0").DefaultRecordRowHeight = (int)DpiAware.LogicalToDeviceUnits(22.0f);
            this.gridGroupingControl1.GetTable("List3_Child1").DefaultRecordRowHeight = (int)DpiAware.LogicalToDeviceUnits(22.0f);

           
        }

        #endregion

        #region "Sample Customization"

        #region DataSource files

        public class BaseClassList : List<BaseClass>, ITypedList
        {
            #region ITypedList Members

            public PropertyDescriptorCollection GetItemProperties(PropertyDescriptor[] listAccessors)
            {
                List<PropertyDescriptor> retProperties = new List<PropertyDescriptor>();

                if (Count > 0)
                {
                    BaseClass instance = this[0];

                    // Data
                    foreach (KeyValuePair<string, MyData> data in instance.Data)
                    {
                        retProperties.Add(new BaseClassMyDataPropertyDescriptor(data.Key));
                    }

                    Dictionary<string, string> childKeys = new Dictionary<string, string>();

                    for (int n = 0; n < Count; n++)
                    {
                        instance = this[n];

                        // Children - return property descriptors for all possible children here.
                        foreach (KeyValuePair<string, List<BaseClass>> child in instance.ChildTables)
                        {
                            if (!childKeys.ContainsKey(child.Key))
                            {
                                retProperties.Add(new BaseClassChildrenPropertyDescriptor(child.Key));
                                childKeys.Add(child.Key, child.Key);
                            }
                        }
                    }
                }

                return new PropertyDescriptorCollection(retProperties.ToArray());
            }

            public string GetListName(PropertyDescriptor[] listAccessors)
            {
                return GetType().Name;
            }
            
            #endregion
        }

        private BaseClassList CreateDataLists()
        {
            BaseClassList list;
            BaseClassList newList;

            //The main list
            list = new BaseClassList();
            list.Add(new FirstClass(null, 0, "row0"));
            list.Add(new FirstClass(null, 1, "row1"));
            list.Add(new FirstClass(null, 2, "row2"));
            list.Add(new FirstClass(null, 3, "row3"));
            list.Add(new FirstClass(null, 4, "row4"));
            newList = list;


            #region Child Tables of List[0]
            //First Child of List[0]
            list = new BaseClassList();
            list.Add(new SecondClass(newList[0], 0, "row0_childtable0_row0"));
            list.Add(new SecondClass(newList[0], 1, "row0_childtable0_row1"));
            list.Add(new SecondClass(newList[0], 2, "row0_childtable0_row2"));
            list.Add(new SecondClass(newList[0], 3, "row0_childtable0_row3"));
            list.Add(new SecondClass(newList[0], 4, "row0_childtable0_row4"));
            list.Add(new SecondClass(newList[0], 5, "row0_childtable0_row5"));
            newList[0].ChildTables.Add("List0_Child0", list);

                #region Child of First Child of List[0]
                //first child table of first child of base[0]
                list = new BaseClassList();
                list.Add(new SecondClass(newList[0].ChildTables["List0_Child0"][0], 0, "row0_childtable0_row0_childtable0_row0"));
                list.Add(new SecondClass(newList[0].ChildTables["List0_Child0"][0], 1, "row0_childtable0_row0_childtable0_row1"));
                list.Add(new SecondClass(newList[0].ChildTables["List0_Child0"][0], 2, "row0_childtable0_row0_childtable0_row2"));
                list.Add(new SecondClass(newList[0].ChildTables["List0_Child0"][0], 3, "row0_childtable0_row0_childtable0_row3"));
                list.Add(new SecondClass(newList[0].ChildTables["List0_Child0"][0], 4, "row0_childtable0_row0_childtable0_row4"));
                list.Add(new SecondClass(newList[0].ChildTables["List0_Child0"][0], 5, "row0_childtable0_row0_childtable0_row5"));
                newList[0].ChildTables["List0_Child0"][0].ChildTables.Add("List0_NestedChild0", list);
                #endregion

            //Second Child of List[0]
            list = new BaseClassList();
            list.Add(new FirstClass(newList[0], 0, "row0_childtable1_row0"));
            list.Add(new FirstClass(newList[0], 1, "row0_childtable1_row1"));
            list.Add(new FirstClass(newList[0], 2, "row0_childtable1_row2"));
            list.Add(new FirstClass(newList[0], 3, "row0_childtable1_row3"));
            list.Add(new FirstClass(newList[0], 4, "row0_childtable1_row4"));
            list.Add(new FirstClass(newList[0], 5, "row0_childtable1_row5"));
            newList[0].ChildTables.Add("List0_Child1", list);
            #endregion

            #region Child Table of List[1]
            //Child of List[1]
            list = new BaseClassList();
            list.Add(new SecondClass(newList[1], 0, "row2_childtable1_row0"));
            list.Add(new SecondClass(newList[1], 1, "row2_childtable1_row1"));
            list.Add(new SecondClass(newList[1], 2, "row2_childtable1_row2"));
            list.Add(new SecondClass(newList[1], 3, "row2_childtable1_row3"));
            list.Add(new SecondClass(newList[1], 4, "row2_childtable1_row4"));
            list.Add(new SecondClass(newList[1], 5, "row2_childtable1_row5"));
            newList[1].ChildTables.Add("List1_Child0", list);
            #endregion

            //No Childs for List[2]

            #region Child Tables of List[3]
            //First Child of List[3]
            list = new BaseClassList();
            list.Add(new FirstClass(newList[3], 0, "row4_childtable0_row0"));
            list.Add(new FirstClass(newList[3], 1, "row4_childtable0_row1"));
            list.Add(new FirstClass(newList[3], 2, "row4_childtable0_row2"));
            list.Add(new FirstClass(newList[3], 3, "row4_childtable0_row3"));
            list.Add(new FirstClass(newList[3], 4, "row4_childtable0_row4"));
            list.Add(new FirstClass(newList[3], 5, "row4_childtable0_row5"));
            newList[3].ChildTables.Add("List3_Child0", list);

            //Second Child of List[3]
            list = new BaseClassList();
            list.Add(new SecondClass(newList[3], 0, "row4_childtable1_row0"));
            list.Add(new SecondClass(newList[3], 1, "row4_childtable1_row1"));
            list.Add(new SecondClass(newList[3], 2, "row4_childtable1_row2"));
            list.Add(new SecondClass(newList[3], 3, "row4_childtable1_row3"));
            list.Add(new SecondClass(newList[3], 4, "row4_childtable1_row4"));
            list.Add(new SecondClass(newList[3], 5, "row4_childtable1_row5"));
            newList[3].ChildTables.Add("List3_Child1", list);
            #endregion

            //No Childs for List[4]

            return newList;
        }

        #endregion

        private void SampleCustomization()
        {
            //Handle this event to hide the +/- on the empty records
            this.gridGroupingControl1.QueryCellStyleInfo += new GridTableCellStyleInfoEventHandler(gridGroupingControl1_QueryCellStyleInfo);
        }

        #region "Event"

        //Setting cell type as static for child tables plusminus cell which does nt havae child records 
        void gridGroupingControl1_QueryCellStyleInfo(object sender, GridTableCellStyleInfoEventArgs e)
        {
            if (e.TableCellIdentity.TableCellType == GridTableCellType.RecordPlusMinusCell)
            {
                Element cell = e.TableCellIdentity.DisplayElement;
                Record r = cell.ParentRecord as Record;
                bool makeStatic = true;
                if (r != null && r.NestedTables.Count > 0)
                {
                    foreach (NestedTable nt in r.NestedTables)
                    {
                        if (nt.ChildTable.GetFilteredRecordCount() != 0)
                            makeStatic = false;
                    }
                }
                if (makeStatic)
                {
                    e.Style.CellType = "Static";
                    e.Style.Borders.Bottom = new GridBorder(GridBorderStyle.Solid, Color.FromArgb(208,215,229));
                }
            }
        }
        
        #endregion 

        #endregion
    }
}
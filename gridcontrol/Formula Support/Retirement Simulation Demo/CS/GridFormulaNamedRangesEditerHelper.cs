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
using System.Globalization;
using System.Collections;
using System.Windows.Forms;
using System.ComponentModel;
using System.ComponentModel.Design;
using Syncfusion.Windows.Forms.Grid;
using Syncfusion.ComponentModel;
using System.Collections.Generic;

namespace RetirementSimulation
{
    /// <summary>
    /// A helper class that facilitates displaying and editing a NamedRanges hashtable using a CollectionEditor.
    /// </summary>
    public class GridFormulaNamedRangesEditerHelper
    {
        private GridFormulaEngine engine;

        #region "Constructor"
        /// <summary>
        /// Constructor which allows editing an empty NamedRange list.
        /// </summary>
        public GridFormulaNamedRangesEditerHelper()
        {
            this.namedRanges = new Hashtable();
            SetArrayList();
        }

        /// <summary>
        /// Constructor which allows editing an existing GridFormulaEngine.NamedRanges list.
        /// </summary>
        /// <param name="engine">The GridFormulaEngine object that holds the NamedRanges.</param>
        public GridFormulaNamedRangesEditerHelper(GridFormulaEngine engine)
        {
            this.engine = engine;
            this.namedRanges = engine.NamedRanges;
            SetArrayList();
        }

        #endregion 

        #region Methods
        private void SetArrayList()
        {
            list = new NamedRangeList();
            foreach (string key in this.namedRanges.Keys)
            {
                list.Add(new NamedRange(engine.NamedRangesOriginalNames[key].ToString(), this.namedRanges[key].ToString()));
            }

            ////Do alpha sort on Keys.
            list.Sort(new AlphaComparer());
        }

        private Hashtable namedRanges;
        private NamedRangeList list;

        /// <summary>
        /// Gets or sets NamedRangeList collection holding the GridFormulaEngine.NamedRange information being edited.
        /// </summary>
        public NamedRangeList List
        {
            get { return list; }
            set { list = value; }
        }

        /// <summary>
        /// Custom IComparer object used alphabetize the ranges.
        /// </summary>
        protected class AlphaComparer : IComparer
        {
            /// <summary>
            /// Used internally.
            /// </summary>
            public AlphaComparer()
                : base()
            {
            }

            #region Implementation of IComparer
            /// <summary>
            /// Compares 2 items as strings.
            /// </summary>
            /// <param name="x">The first object to compare.</param>
            /// <param name="y">The second object to compare.</param>
            /// <returns>
            /// Value
            /// Condition
            /// Less than zero
            /// <paramref name="x"/> is less than <paramref name="y"/>.
            /// Zero
            /// <paramref name="x"/> equals <paramref name="y"/>.
            /// Greater than zero
            /// <paramref name="x"/> is greater than <paramref name="y"/>.
            /// </returns>
            /// <exception cref="T:System.ArgumentException">
            /// Neither <paramref name="x"/> nor <paramref name="y"/> implements the <see cref="T:System.IComparable"/> interface.
            /// -or-
            /// <paramref name="x"/> and <paramref name="y"/> are of different types and neither one can handle comparisons with the other.
            /// </exception>
            public int Compare(object x, object y)
            {
                return string.Compare(x.ToString(), y.ToString());
            }
            #endregion}
        }

        /// <summary>
        /// Typed ArrayList that returns NamedRange objects.
        /// </summary>
        public class NamedRangeList : ArrayList
        {
            /// <summary>
            /// Default Constructor.
            /// </summary>
            public NamedRangeList()
                : base()
            {
            }

            /// <summary>
            /// Returns the element as a NamedRange type.
            /// </summary>
            public new NamedRange this[int i]
            {
                get { return (NamedRange)base[i]; }
                set { base[i] = value; }
            }
        }

        #endregion

        #region NamedRange class
        /// <summary>
        /// Holds Key and Value for a named range.
        /// </summary>
        public class NamedRange
        {
            /// <summary>
            /// Default Constructor.
            /// </summary>
            public NamedRange()
            {
                this.key = string.Empty;
                this.val = string.Empty;
            }

            /// <summary>
            ///    Constructor for NamedRange.
            /// </summary>
            /// <param name="key">Name of the NamedRange.</param>
            /// <param name="val">Value of the NamedRange.</param>
            /// <remarks>
            /// GridFormulaEngine allows you to write formulas where strings can be substitued
            /// for explicit values or cell references. For example, instead of hard coding an interest value 
            /// as in formula '= .052 * B12', you could write '= InterestRate * B12' where InterestRate
            /// is the Name for a NameRange object and .052 is its value. Then later, if the interest rate 
            /// changes, you only have to modify the value of the InterestRate NamedRange object, and do
            /// not have to directly modify values in cells. The NamedRange.Key property holds the name and the 
            /// NamedRange.Value property holds the value.
            /// </remarks>
            public NamedRange(string key, string val)
            {
                this.key = key;
                this.val = val;
            }

            private string key;
            private string val;

            /// <summary>
            /// Gets or sets the name used for this named range.
            /// </summary>
            [Description("The name used for this named range.")]
            [Category("NamedRange")]
            public string Key
            {
                get { return key; }
                set { key = value; }
            }

            /// <summary>
            /// Gets or sets the value for this named range.
            /// </summary>
            [Description("The value for this named range.")]
            [Category("NamedRange")]
            public string Value
            {
                get { return val; }
                set { val = value; }
            }

            /// <summary>
            /// Overridden to return the Key property.
            /// </summary>
            /// <returns>The Key property.</returns>
            public override string ToString()
            {
                return key;
            }
        }

        #endregion


        #region "Dialogue"
        /// <summary>
        /// Occurs immediately before the Dialog is displayed. The sender is 
        /// the Dialog being shown.
        /// </summary>
        /// <remarks>
        /// You can handle this event to customize the dialog to some extent.
        /// </remarks>
        /// <example> This code changes the title of the dialog.
        /// <code lang="C#">
        /// </code>
        /// <code lang="VB">
        /// </code>
        /// </example>
        public static event ControlEventHandler ShowingNamedRangesDialog;

        ////Used to expose showing dialog event.
        static private void ServiceContainerShowingDialog(object sender, ControlEventArgs e)
        {
            if (ShowingNamedRangesDialog != null)
            {
                ShowingNamedRangesDialog(sender, e);
            }
        }

        /// <summary>
        /// Displays a collection editor dialog for editing NamedRanges.
        /// </summary>
        /// <param name="engine">The GridFormulaEngine instance whose NamedRanges are being edited.</param>
        public static void ShowNamedRangesDialog(GridFormulaEngine engine)
        {
            GridFormulaNamedRangesEditerHelper editHelper = new GridFormulaNamedRangesEditerHelper(engine);

            CollectionEditor editor1 = new CollectionEditor(typeof(NamedRangeList));

            WindowsFormsEditorServiceContainer esc = new WindowsFormsEditorServiceContainer(null);

            ////Subscribe to the event to change Dialog settings.
            esc.ShowingDialog += new ControlEventHandler(ServiceContainerShowingDialog);

            PropertyDescriptor pd = TypeDescriptor.GetProperties(editHelper)["List"];
            TypeDescriptorContext tdc = new TypeDescriptorContext(editHelper, pd);

            tdc.ServiceProvider = esc;

            GridFormulaNamedRangesEditerHelper.NamedRangeList oldList = pd.GetValue(editHelper) as GridFormulaNamedRangesEditerHelper.NamedRangeList;
            GridFormulaNamedRangesEditerHelper.NamedRangeList newList = editor1.EditValue(tdc, esc, oldList) as GridFormulaNamedRangesEditerHelper.NamedRangeList;

            esc.ShowingDialog -= new ControlEventHandler(ServiceContainerShowingDialog);

            if (newList != null && esc.DialogResult == DialogResult.OK)
            {
                ArrayList needUpdating = new ArrayList();
                ArrayList needDeleting = new ArrayList();

                Hashtable namedRanges = (Hashtable)engine.NamedRanges.Clone();
                List<string> lst = new List<string>();
                foreach (string key in namedRanges.Keys)
                {
                    lst.Add(key);
                }
                lst.Sort();
                engine.NamedRanges.Clear();
                engine.NamedRangesOriginalNames.Clear();
                int i = 0;
                foreach (NamedRange range in newList)
                {
                    string s = range.Key.ToUpper(CultureInfo.InvariantCulture);
                    if (namedRanges.Contains(range.Key) && !string.IsNullOrEmpty(range.Key) && namedRanges[lst[i]].Equals(range.Value))
                        engine.AddNamedRange(range.Key, range.Value);
                    else if (namedRanges.Contains(range.Key) && !string.IsNullOrEmpty(range.Key))
                        engine.AddNamedRange(range.Key, namedRanges[lst[i]].ToString());
                    else if (!namedRanges.Contains(range.Key) && !string.IsNullOrEmpty(range.Key) && !namedRanges.ContainsKey(range.Key))
                        engine.AddNamedRange(range.Key, range.Value);
                    if (namedRanges.ContainsKey(s))
                    {
                        if (namedRanges[s].Equals(range.Value))
                        {
                            needUpdating.Add(s);
                        }
                    }
                    i++;
                }

                foreach (string key in namedRanges.Keys)
                {
                    if (!engine.NamedRanges.ContainsKey(key))
                    {
                        needDeleting.Add(key);
                    }
                }

                if (needDeleting.Count > 0 || needUpdating.Count > 0)
                {
                    foreach (string s in needUpdating)
                    {
                        engine.UpdateDependentNamedRangeCell(s);
                        ////Console.WriteLine("changed: " + s);
                    }

                    foreach (string s in needDeleting)
                    {
                        if (engine.NamedRanges.ContainsKey(s))
                        {
                            engine.UpdateDependentNamedRangeCell(s);
                            engine.RemoveNamedRangeDependency(s);
                            ////Console.WriteLine("deleted: " + s);
                        }
                    }
                }

                engine.AdjustNameRangesForSize();
            }
        }
        #endregion
    }
}

#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Collections.ObjectModel;
using Syncfusion.Data;
using System.Collections;
using System.ComponentModel;
using System;
using Syncfusion.WinForms.DataGrid.RowFilter;
using Syncfusion.WinForms.DataGrid;
using Syncfusion.WinForms.DataGrid.GridFiltering;
using Syncfusion.WinForms.GridCommon;

namespace CustomFilterRow
{
    /// <summary>
    /// Class represents the GridNumericFilterComboBoxRendererExt for customizing the ComboBoxRenderer
    /// </summary>
    public class GridNumericFilterComboBoxRendererExt : FilterRowMultiSelectComboBoxCellRenderer, INotifyPropertyChanged
    {
        private List<FilterElement> numericComboBoxItems;

        public GridNumericFilterComboBoxRendererExt()
            : base()
        {
            SetNumericComboBoxItemsList();
        }

        /// <summary>
        /// Generate the Items for NumericComboBox
        /// </summary>
        /// <returns></returns>
        public void SetNumericComboBoxItemsList()
        {
            numericComboBoxItems = new List<FilterElement>();
            numericComboBoxItems.Add(new FilterElement() { DisplayText = "Between 10001 and 10020" });
            numericComboBoxItems.Add(new FilterElement() { DisplayText = "Between 10030 and 10050" });
            numericComboBoxItems.Add(new FilterElement() { DisplayText = "Between 10060 and 10080" });
            numericComboBoxItems.Add(new FilterElement() { DisplayText = "Between 10090 and 10110" });
            numericComboBoxItems.Add(new FilterElement() { DisplayText = "Between 10120 and 10150" });
            numericComboBoxItems.Add(new FilterElement() { DisplayText = ">10200" });
        }

        protected override void OnInitializeEditElement(Syncfusion.WinForms.DataGrid.DataColumnBase column, Syncfusion.WinForms.GridCommon.ScrollAxis.RowColumnIndex rowColumnIndex, Syncfusion.WinForms.ListView.SfComboBox uiElement)
        {
            base.OnInitializeEditElement(column, rowColumnIndex, uiElement);
            ObservableCollection<object> selItems = new ObservableCollection<object>();
            //Generate the items for FilterRow                 
            uiElement.DataSource = numericComboBoxItems;
            InitializeNumericFilter(column, selItems);

            if (selItems.Count > 0)
                uiElement.SelectedItems = selItems;
            else if (uiElement.SelectedItems != null)
                uiElement.SelectedItems.Clear();
            uiElement.AllowSelectAll = true;
        }

        /// <summary>
        /// Check whether the column having a filterperdicates or not
        /// </summary>
        /// <param name="filterPredicate">FilterPredicates for a column</param>
        /// <param name="filterValue">FilterValue for a column</param>
        /// <returns></returns>
        private bool NeedToAdd(ObservableCollection<FilterPredicate> filterPredicate, string filterValue)
        {
            bool needToAdd = false;
            foreach (var item in filterPredicate)
            {
                if ((item as FilterPredicate).FilterValue.ToString() == filterValue)
                {
                    needToAdd = true;
                    break;
                }
            }
            return needToAdd;
        }

        /// <summary>
        /// Generate the FilterPredicates and apply the filter for a corresponding column
        /// </summary>
        /// <param name="filterValues">Corresponding FilterValue</param>
        /// <param name="totalItems">Corresponding FilterItems</param>
        public override void ProcessMultipleFilters(List<object> filterValues, List<object> totalItems)
        {
            var selectedItems = filterValues.Cast<FilterElement>().ToList();
            var total = totalItems.Cast<FilterElement>().ToList();
            if (selectedItems == null || total == null || filterValues == null)
                return;

            if (selectedItems.Count == total.Count)
            {
                this.ApplyFilters(null, string.Empty);
                this.IsValueChanged = false;
                return;
            }
            var filterPredicates = new List<FilterPredicate>();
            if (filterValues.Count > 0)
            {
                selectedItems.ForEach(item =>
                {
                    //Create the FilterPredicates and Apply the filter
                    ProcessNumericFilter(filterPredicates, item.DisplayText);
                });
            }
            string _filterText = string.Empty;
            //Creates the FilterText
            if (filterPredicates.Count > 0)
            {
                var selectItems = ((IList)filterValues).Cast<FilterElement>().ToList();
                for (int i = 0; i < selectedItems.Count; i++)
                {
                    _filterText += selectedItems[i].DisplayText;
                    if (i != selectedItems.Count - 1)
                        _filterText += " - ";
                }
            }
            if (filterPredicates != null)
                this.ApplyFilters(filterPredicates, _filterText);
            this.IsValueChanged = false;
        }

        /// <summary>
        /// Generate the FiletrPredicates for StronglyTyped
        /// </summary>
        /// <param name="value"></param>
        /// <param name="filterType"></param>
        /// <param name="predType"></param>
        /// <returns></returns>
        private FilterPredicate GetFilterPredicates(object value, FilterType filterType, PredicateType predType)
        {
            return new FilterPredicate()
            {
                FilterBehavior = FilterBehavior.StronglyTyped,
                FilterType = filterType,
                FilterValue = value,
                IsCaseSensitive = false,
                PredicateType = predType
            };
        }

        /// <summary>
        /// Initialize the NumericFilter
        /// </summary>
        /// <param name="dataColumn">Corresponding column</param>
        /// <param name="SelectedItem">SelectedItem for ComboBox</param>
        public void InitializeNumericFilter(DataColumnBase dataColumn, ObservableCollection<object> SelectedItem)
        {
            if (dataColumn.GridColumn.FilteredFrom == FilteredFrom.FilterRow && dataColumn.GridColumn.FilterPredicates.Count > 0)
            {
                if (numericComboBoxItems != null)
                {
                    numericComboBoxItems.ForEach(element =>
                    {
                        //Check if the filter is already applied or not, if applied means again add the filter
                        bool needToAdd = false;
                        switch (element.DisplayText)
                        {
                            case "Between 10001 and 10020":
                                needToAdd = this.NeedToAdd(dataColumn.GridColumn.FilterPredicates, "10001");
                                break;
                            case "Between 10030 and 10050":
                                needToAdd = this.NeedToAdd(dataColumn.GridColumn.FilterPredicates, "10030");
                                break;
                            case "Between 10060 and 10080":
                                needToAdd = this.NeedToAdd(dataColumn.GridColumn.FilterPredicates, "10060");
                                break;
                            case "Between 10090 and 10110":
                                needToAdd = this.NeedToAdd(dataColumn.GridColumn.FilterPredicates, "10090");
                                break;
                            case "Between 10120 and 10150":
                                needToAdd = this.NeedToAdd(dataColumn.GridColumn.FilterPredicates, "10120");
                                break;
                            case ">10200":
                                needToAdd = this.NeedToAdd(dataColumn.GridColumn.FilterPredicates, "10200");
                                break;
                        }
                        if (needToAdd)
                            SelectedItem.Add(element);
                    });
                }
            }
        }

        /// <summary>
        /// Created the filterpredicates for NumericColumn
        /// </summary>
        /// <param name="filterPredicates"></param>
        /// <param name="item"></param>
        public void ProcessNumericFilter(List<FilterPredicate> filterPredicates, string item)
        {
            switch (item)
            {
                case "Between 10001 and 10020":
                    filterPredicates.Add(GetFilterPredicates((int)10001, FilterType.GreaterThan, PredicateType.OrElse));
                    filterPredicates.Add(GetFilterPredicates((int)10020, FilterType.LessThan, PredicateType.And));
                    break;
                case "Between 10030 and 10050":
                    filterPredicates.Add(GetFilterPredicates((int)10030, FilterType.GreaterThan, PredicateType.OrElse));
                    filterPredicates.Add(GetFilterPredicates((int)10050, FilterType.LessThan, PredicateType.And));
                    break;
                case "Between 10060 and 10080":
                    filterPredicates.Add(GetFilterPredicates((int)10060, FilterType.GreaterThan, PredicateType.OrElse));
                    filterPredicates.Add(GetFilterPredicates((int)10080, FilterType.LessThan, PredicateType.And));
                    break;
                case "Between 10090 and 10110":
                    filterPredicates.Add(GetFilterPredicates((int)10090, FilterType.GreaterThan, PredicateType.OrElse));
                    filterPredicates.Add(GetFilterPredicates((int)10110, FilterType.LessThan, PredicateType.And));
                    break;
                case "Between 10120 and 10150":
                    filterPredicates.Add(GetFilterPredicates((int)10120, FilterType.GreaterThan, PredicateType.OrElse));
                    filterPredicates.Add(GetFilterPredicates((int)10150, FilterType.LessThan, PredicateType.And));
                    break;
                case ">10200":
                    filterPredicates.Add(GetFilterPredicates((int)10200, FilterType.GreaterThan, PredicateType.Or));
                    break;
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(String prop)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
            }
        }
    }
}

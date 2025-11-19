#region Copyright Syncfusion Inc. 2001 - 2016
// Copyright Syncfusion Inc. 2001 - 2016. All rights reserved.
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
    /// Class represents the GridTextFilterComboBoxRendererExt for customizing the ComboBoxRenderer
    /// </summary>
    public class GridTextFilterComboBoxRendererExt : FilterRowMultiSelectComboBoxCellRenderer, INotifyPropertyChanged
    {
        private List<FilterElement> textComboBoxItems;

        public GridTextFilterComboBoxRendererExt()
            : base()
        {
            SetTextComboBoxItemsList();
        }

        /// <summary>
        ///  Generate the Items for TextComboBox
        /// </summary>
        /// <returns></returns>
        public void SetTextComboBoxItemsList()
        {
            textComboBoxItems = new List<FilterElement>();
            textComboBoxItems.Add(new FilterElement() { DisplayText = "A to D" });
            textComboBoxItems.Add(new FilterElement() { DisplayText = "E to H" });
            textComboBoxItems.Add(new FilterElement() { DisplayText = "I to L" });
            textComboBoxItems.Add(new FilterElement() { DisplayText = "M to P" });
            textComboBoxItems.Add(new FilterElement() { DisplayText = "Q to U" });
            textComboBoxItems.Add(new FilterElement() { DisplayText = "V to Z" });
        }

        protected override void OnInitializeEditElement(Syncfusion.WinForms.DataGrid.DataColumnBase column, Syncfusion.WinForms.GridCommon.ScrollAxis.RowColumnIndex rowColumnIndex, Syncfusion.WinForms.ListView.SfComboBox uiElement)
        {
            base.OnInitializeEditElement(column, rowColumnIndex, uiElement);
            ObservableCollection<object> selItems = new ObservableCollection<object>();

            //Generate the items for FilterRow 
            uiElement.DataSource = textComboBoxItems;
            InitializeTextFilter(column, selItems);
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
                    ProcessTextFilter(filterPredicates, item.DisplayText);
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
        /// Generate the FiletrPredicates for StringTyped
        /// </summary>
        /// <param name="value"></param>
        /// <param name="filterType"></param>
        /// <param name="predType"></param>
        /// <returns></returns>
        private FilterPredicate GetStringFilterPredicates(object value, FilterType filterType, PredicateType predType)
        {
            return new FilterPredicate()
            {
                FilterBehavior = FilterBehavior.StringTyped,
                FilterType = filterType,
                FilterValue = value,
                IsCaseSensitive = false,
                PredicateType = predType
            };
        }


        /// <summary>
        /// Initialize the TextFilter
        /// </summary>
        /// <param name="dataColumn">Corresponding column</param>
        /// <param name="SelectedItem">SelectedItem for ComboBox</param>
        public void InitializeTextFilter(DataColumnBase dataColumn, ObservableCollection<object> SelectedItem)
        {
            if (dataColumn.GridColumn.FilteredFrom == FilteredFrom.FilterRow && dataColumn.GridColumn.FilterPredicates.Count > 0)
            {
                if (textComboBoxItems != null)
                {
                    textComboBoxItems.ForEach(element =>
                    {
                        //Check if the filter is already applied or not, if applied means again add the filter
                        bool needToAdd = false;
                        switch (element.DisplayText)
                        {
                            case "A to D":
                                needToAdd = this.NeedToAdd(dataColumn.GridColumn.FilterPredicates, "A");
                                break;
                            case "E to H":
                                needToAdd = this.NeedToAdd(dataColumn.GridColumn.FilterPredicates, "E");
                                break;
                            case "I to L":
                                needToAdd = this.NeedToAdd(dataColumn.GridColumn.FilterPredicates, "I");
                                break;
                            case "M to P":
                                needToAdd = this.NeedToAdd(dataColumn.GridColumn.FilterPredicates, "M");
                                break;
                            case "Q to U":
                                needToAdd = this.NeedToAdd(dataColumn.GridColumn.FilterPredicates, "Q");
                                break;
                            case "V to Z":
                                needToAdd = this.NeedToAdd(dataColumn.GridColumn.FilterPredicates, "V");
                                break;

                        }
                        if (needToAdd)
                            SelectedItem.Add(element);
                    });
                }
            }
        }


        /// <summary>
        /// Created the filterpredicates for TextColumn
        /// </summary>
        /// <param name="filterPredicates"></param>
        /// <param name="item"></param>
        public void ProcessTextFilter(List<FilterPredicate> filterPredicates, string item)
        {
            switch (item)
            {
                case "A to D":
                    filterPredicates.Add(GetStringFilterPredicates("A", FilterType.StartsWith, PredicateType.OrElse));
                    filterPredicates.Add(GetStringFilterPredicates("B", FilterType.StartsWith, PredicateType.Or));
                    filterPredicates.Add(GetStringFilterPredicates("C", FilterType.StartsWith, PredicateType.Or));
                    filterPredicates.Add(GetStringFilterPredicates("D", FilterType.StartsWith, PredicateType.Or));
                    break;
                case "E to H":
                    filterPredicates.Add(GetStringFilterPredicates("E", FilterType.StartsWith, PredicateType.OrElse));
                    filterPredicates.Add(GetStringFilterPredicates("F", FilterType.StartsWith, PredicateType.Or));
                    filterPredicates.Add(GetStringFilterPredicates("G", FilterType.StartsWith, PredicateType.Or));
                    filterPredicates.Add(GetStringFilterPredicates("H", FilterType.StartsWith, PredicateType.Or));
                    break;
                case "I to L":
                    filterPredicates.Add(GetStringFilterPredicates("I", FilterType.StartsWith, PredicateType.OrElse));
                    filterPredicates.Add(GetStringFilterPredicates("J", FilterType.StartsWith, PredicateType.Or));
                    filterPredicates.Add(GetStringFilterPredicates("K", FilterType.StartsWith, PredicateType.Or));
                    filterPredicates.Add(GetStringFilterPredicates("L", FilterType.StartsWith, PredicateType.Or));
                    break;
                case "M to P":
                    filterPredicates.Add(GetStringFilterPredicates("M", FilterType.StartsWith, PredicateType.OrElse));
                    filterPredicates.Add(GetStringFilterPredicates("N", FilterType.StartsWith, PredicateType.Or));
                    filterPredicates.Add(GetStringFilterPredicates("O", FilterType.StartsWith, PredicateType.Or));
                    filterPredicates.Add(GetStringFilterPredicates("P", FilterType.StartsWith, PredicateType.Or));
                    break;
                case "Q to U":
                    filterPredicates.Add(GetStringFilterPredicates("Q", FilterType.StartsWith, PredicateType.OrElse));
                    filterPredicates.Add(GetStringFilterPredicates("R", FilterType.StartsWith, PredicateType.Or));
                    filterPredicates.Add(GetStringFilterPredicates("S", FilterType.StartsWith, PredicateType.Or));
                    filterPredicates.Add(GetStringFilterPredicates("T", FilterType.StartsWith, PredicateType.Or));
                    filterPredicates.Add(GetStringFilterPredicates("U", FilterType.StartsWith, PredicateType.Or));
                    break;
                case "V to Z":
                    filterPredicates.Add(GetStringFilterPredicates("V", FilterType.StartsWith, PredicateType.OrElse));
                    filterPredicates.Add(GetStringFilterPredicates("W", FilterType.StartsWith, PredicateType.Or));
                    filterPredicates.Add(GetStringFilterPredicates("X", FilterType.StartsWith, PredicateType.Or));
                    filterPredicates.Add(GetStringFilterPredicates("Y", FilterType.StartsWith, PredicateType.Or));
                    filterPredicates.Add(GetStringFilterPredicates("Z", FilterType.StartsWith, PredicateType.Or));
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

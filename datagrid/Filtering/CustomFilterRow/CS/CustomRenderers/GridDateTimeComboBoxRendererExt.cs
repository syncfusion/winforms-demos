#region Copyright Syncfusion Inc. 2001 - 2016
// Copyright Syncfusion Inc. 2001 - 2016. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Collections.ObjectModel;
using Syncfusion.Data;
using System.Collections;
using System.ComponentModel;
using Syncfusion.WinForms.DataGrid.RowFilter;
using Syncfusion.WinForms.DataGrid;
using System.Windows.Forms;
using Syncfusion.WinForms.DataGrid.GridFiltering;
using Syncfusion.WinForms.GridCommon;

namespace CustomFilterRow
{
    /// <summary>
    /// Class represents the GridDateTimeComboBoxRendererExt for customizing the ComboBoxRenderer
    /// </summary>
    public class GridDateTimeComboBoxRendererExt : FilterRowMultiSelectComboBoxCellRenderer, INotifyPropertyChanged
    {
        private List<FilterElement> dateTimeComboBoxItems;

        public GridDateTimeComboBoxRendererExt()
            : base()
        {
            SetDateTimeComboBoxItemsList();
        }

        /// <summary>
        /// Generate the Items for DateTimeComboBox
        /// </summary>
        public void SetDateTimeComboBoxItemsList()
        {
            var date = DateTime.Today;
            var today = date.DayOfWeek;
            dateTimeComboBoxItems  = new List<FilterElement>();
            dateTimeComboBoxItems.Add(new FilterElement() { DisplayText = "Today" });
            date = date.AddDays(-1);
            today = date.DayOfWeek;
            if (today.ToString() != "Saturday")
                dateTimeComboBoxItems.Add(new FilterElement() { DisplayText = "Yesterday" }); 
            for (int i = 0; i < 7; i++)
            {
                date = date.AddDays(-1);
                today = date.DayOfWeek;
                if (today.ToString() != "Saturday")
                    dateTimeComboBoxItems.Add(new FilterElement() { DisplayText = today.ToString() });
                else
                    break;
            }
            dateTimeComboBoxItems.Add(new FilterElement() { DisplayText = "LastWeek" });
            dateTimeComboBoxItems.Add(new FilterElement() { DisplayText = "LastMonth" });
            dateTimeComboBoxItems.Add(new FilterElement() { DisplayText = "Older" });
        }

        /// <summary>
        /// Set the Margin for a ContentControl 
        /// </summary>
        /// <param name="column"></param>
        /// <param name="rowColumnIndex"></param>
        /// <param name="uiElement"></param>
        protected override void OnInitializeEditElement(DataColumnBase column, Syncfusion.WinForms.GridCommon.ScrollAxis.RowColumnIndex rowColumnIndex, Syncfusion.WinForms.ListView.SfComboBox uiElement)
        {
            base.OnInitializeEditElement(column, rowColumnIndex, uiElement);
            uiElement.Margin = new Padding(5, 0, 0, 0);
            ObservableCollection<object> selItems = new ObservableCollection<object>();
            //Generate the items for FilterRow 
            uiElement.DataSource = dateTimeComboBoxItems;
            uiElement.DisplayMember = "DisplayText";
            InitializeDateFilter(column, selItems);
            if (selItems.Count > 0)
                uiElement.CheckedItems = selItems;
            else if (uiElement.SelectedItems != null)
                uiElement.CheckedItems.Clear();
            uiElement.Text = Convert.ToString(column.GridColumn.FilterRowText);
            uiElement.DropDownStyle = Syncfusion.WinForms.ListView.Enums.DropDownStyle.DropDownList;
            uiElement.AllowSelectAll = true;
            uiElement.DropDownControl.ShowButtons = true;            
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
                    ProcessDateFilter(filterPredicates, item.DisplayText);
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
        /// Initialize the DataFilter
        /// </summary>
        /// <param name="dataColumn">Corresponding column</param>
        /// <param name="SelectedItem">SelectedItem for ComboBox</param>
        public void InitializeDateFilter(DataColumnBase dataColumn, ObservableCollection<object> SelectedItem)
        {
            if (dataColumn.GridColumn.FilteredFrom == FilteredFrom.FilterRow && dataColumn.GridColumn.FilterPredicates.Count > 0)
            {
                if (dateTimeComboBoxItems != null)
                {
                    dateTimeComboBoxItems.ForEach(element =>
                    {
                        //Check if the filter is already applied or not, if applied means again add the filter
                        bool needToAdd = false;
                        var tempdate = DateTime.Today;
                        var day = tempdate.DayOfWeek;
                        switch (element.DisplayText)
                        {
                            case "Today":
                                needToAdd = this.NeedToAdd(dataColumn.GridColumn.FilterPredicates, DateTime.Today.ToString());
                                break;
                            case "Yesterday":
                                needToAdd = this.NeedToAdd(dataColumn.GridColumn.FilterPredicates, DateTime.Today.AddDays(-1).ToString());
                                break;
                            case "Thursday":
                                needToAdd = this.NeedToAdd(dataColumn.GridColumn.FilterPredicates, DateTime.Today.AddDays(-2).ToString());
                                break;
                            case "Wednesday":
                                needToAdd = DateTime.Today.AddDays(-3).DayOfWeek.ToString() == "Wednesday" ? this.NeedToAdd(dataColumn.GridColumn.FilterPredicates, DateTime.Today.AddDays(-3).ToString())
                                           : DateTime.Today.AddDays(-2).DayOfWeek.ToString() == "Wednesday" ? this.NeedToAdd(dataColumn.GridColumn.FilterPredicates, DateTime.Today.AddDays(-2).ToString()) : false;
                                break;
                            case "Tuesday":
                                for (int i = 2; i <= 5; i++)
                                {
                                    tempdate = tempdate.AddDays(-1);
                                    day = tempdate.DayOfWeek;
                                    if (day.ToString() == "Tuesday")
                                    {
                                        needToAdd = this.NeedToAdd(dataColumn.GridColumn.FilterPredicates, tempdate.ToString());
                                        break;
                                    }
                                }
                                break;
                            case "Monday":
                                for (int i = 2; i <= 6; i++)
                                {
                                    tempdate = tempdate.AddDays(-1);
                                    day = tempdate.DayOfWeek;
                                    if (day.ToString() == "Monday")
                                    {
                                        needToAdd = this.NeedToAdd(dataColumn.GridColumn.FilterPredicates, tempdate.ToString());
                                        break;
                                    }
                                }
                                break;
                            case "Sunday":
                                for (int i = 2; i <= 7; i++)
                                {
                                    tempdate = tempdate.AddDays(-1);
                                    day = tempdate.DayOfWeek;
                                    if (day.ToString() == "Sunday")
                                    {
                                        needToAdd = this.NeedToAdd(dataColumn.GridColumn.FilterPredicates, tempdate.ToString());
                                        break;
                                    }
                                }
                                break;
                            case "LastWeek":
                                DateTime startingDate = DateTime.Today;
                                while (startingDate.DayOfWeek != DayOfWeek.Sunday)
                                    startingDate = startingDate.AddDays(-1);
                                DateTime previousWeekStart = startingDate.AddDays(-7);
                                needToAdd = this.NeedToAdd(dataColumn.GridColumn.FilterPredicates, previousWeekStart.ToString());
                                break;
                            case "LastMonth":
                                {
                                    var month = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
                                    var lastdate = month.AddDays(-1);
                                    needToAdd = this.NeedToAdd(dataColumn.GridColumn.FilterPredicates, lastdate.ToString());
                                }
                                break;
                            case "Older":
                                {
                                    var month = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
                                    var firstdate = month.AddMonths(-1);
                                    needToAdd = this.NeedToAdd(dataColumn.GridColumn.FilterPredicates, firstdate.ToString());
                                }
                                break;
                        }
                        if (needToAdd)
                            SelectedItem.Add(element);
                    });
                }
            }
        }


        /// <summary>
        /// Created the filterpredicates for DateTimeColumn
        /// </summary>
        /// <param name="filterPredicates"></param>
        /// <param name="item"></param>
        public void ProcessDateFilter(List<FilterPredicate> filterPredicates, string item)
        {
            var date = DateTime.Today;
            var day = date.DayOfWeek;
            switch (item)
            {
                case "Today":
                    filterPredicates.Add(GetFilterPredicates((DateTime)DateTime.Today, FilterType.Equals, PredicateType.OrElse));
                    break;
                case "Yesterday":
                    filterPredicates.Add(GetFilterPredicates((DateTime)DateTime.Today.AddDays(-1), FilterType.Equals, PredicateType.OrElse));
                    break;
                case "Thursday":
                    filterPredicates.Add(GetFilterPredicates((DateTime)DateTime.Today.AddDays(-2), FilterType.Equals, PredicateType.OrElse));
                    break;
                case "Wednesday":
                    if (DateTime.Today.AddDays(-3).DayOfWeek.ToString() == "Wednesday")
                        filterPredicates.Add(GetFilterPredicates((DateTime)DateTime.Today.AddDays(-3), FilterType.Equals, PredicateType.OrElse));
                    else if (DateTime.Today.AddDays(-2).DayOfWeek.ToString() == "Wednesday")
                        filterPredicates.Add(GetFilterPredicates((DateTime)DateTime.Today.AddDays(-2), FilterType.Equals, PredicateType.OrElse));
                    break;
                case "Tuesday":
                    for (int i = 2; i <= 5; i++)
                    {
                        date = date.AddDays(-1);
                        day = date.DayOfWeek;
                        if (day.ToString() == "Tuesday")
                        {
                            filterPredicates.Add(GetFilterPredicates((DateTime)date, FilterType.Equals, PredicateType.OrElse));
                            break;
                        }
                    }
                    break;
                case "Monday":
                    for (int i = 2; i <= 6; i++)
                    {
                        date = date.AddDays(-1);
                        day = date.DayOfWeek;
                        if (day.ToString() != "Saturday" && day.ToString() == "Monday")
                        {
                            filterPredicates.Add(GetFilterPredicates((DateTime)date, FilterType.Equals, PredicateType.OrElse));
                            break;
                        }
                    }
                    break;
                case "Sunday":
                    for (int i = 2; i <= 7; i++)
                    {
                        date = date.AddDays(-1);
                        day = date.DayOfWeek;
                        if (day.ToString() != "Saturday" && day.ToString() == "Sunday")
                        {
                            filterPredicates.Add(GetFilterPredicates((DateTime)date, FilterType.Equals, PredicateType.OrElse));
                            break;
                        }
                    }
                    break;
                case "LastWeek":
                    {
                        DateTime startingDate = DateTime.Today;

                        while (startingDate.DayOfWeek != DayOfWeek.Sunday)
                            startingDate = startingDate.AddDays(-1);

                        DateTime previousWeekStart = startingDate.AddDays(-7);
                        DateTime previousWeekEnd = startingDate.AddDays(-1);
                        filterPredicates.Add(GetFilterPredicates((DateTime)previousWeekStart, FilterType.GreaterThanOrEqual, PredicateType.OrElse));
                        filterPredicates.Add(GetFilterPredicates((DateTime)previousWeekEnd, FilterType.LessThanOrEqual, PredicateType.And));
                    }
                    break;

                case "LastMonth":
                    {
                        var month = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
                        var firstdate = month.AddMonths(-1);
                        var lastdate = month.AddDays(-1);
                        filterPredicates.Add(GetFilterPredicates((DateTime)firstdate, FilterType.GreaterThanOrEqual, PredicateType.OrElse));
                        filterPredicates.Add(GetFilterPredicates((DateTime)lastdate, FilterType.LessThanOrEqual, PredicateType.And));
                    }
                    break;
                case "Older":
                    {
                        var month = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
                        var firstdate = month.AddMonths(-1);
                        filterPredicates.Add(GetFilterPredicates((DateTime)firstdate, FilterType.LessThan, PredicateType.OrElse));
                    }
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

#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using Syncfusion.WinForms.Core.Utils;
using Syncfusion.WinForms.Controls;
using Syncfusion.WinForms.DataGrid.Enums;
using Syncfusion.WinForms.DataGrid.Styles;
using Syncfusion.WinForms.DataPager.Events;

namespace OnDemandPaging
{
    public partial class Form1 : Form
    {
        #region Fields

        /// <summary>
        /// Specifies the list for the data source.
        /// </summary>
        private List<Employees> employeeCollection;

        /// <summary>
        /// Specifies the busy indicator for displaying the on loading.
        /// </summary>
        private BusyIndicator busyIndicator = new BusyIndicator();

        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the Form.
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            this.Load += OnLoad;
            sfDataPager1.AllowOnDemandPaging = true;
            sfDataPager1.PageCount = 5;
            sfDataPager1.PageSize = 50;
            EmployeeInfoRespository repository = new EmployeeInfoRespository();
            employeeCollection = repository.GetEmployeesDetails_List(1000);
            this.sfDataPager1.OnDemandLoading += OnDemandLoading;
        }

        #endregion

        #region Methods

        /// <summary>
        /// Occurs when the form load.
        /// </summary>
        /// <param name="sender">The object of the sender.</param>
        /// <param name="e">An EventArgs that contains event data.</param>
        private void OnLoad(object sender, System.EventArgs e)
        {
            sfDataGrid.DataSource = sfDataPager1.PagedSource;
        }

        /// <summary>
        /// Occurs when the new page is loaded in the SfDataPager.
        /// </summary>
        /// <param name="sender">The object of the sender.</param>
        /// <param name="e">An OnDemandLoadingEventArgs that contains event data.</param>
        private void OnDemandLoading(object sender, OnDemandLoadingEventArgs e)
        {
#if !NETCORE
            //Show busy indicator while loading the data.
            if (sfDataGrid.TableControl.IsHandleCreated)
            {
                busyIndicator.Show(this.sfDataGrid.TableControl);
                Thread.Sleep(1000);
            }
#endif

            sfDataPager1.LoadDynamicData(e.StartRowIndex, employeeCollection.Skip(e.StartRowIndex).Take(e.PageSize));
            busyIndicator.Hide();
        }

        #endregion
    }
}

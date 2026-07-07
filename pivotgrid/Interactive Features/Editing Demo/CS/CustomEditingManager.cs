#region Copyright Syncfusion Inc. 2001 - 2018
// Copyright Syncfusion Inc. 2001 - 2018. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion

using Syncfusion.Windows.Forms.PivotAnalysis;
using Syncfusion.PivotAnalysis.Base;

namespace EditingDemo
{
    #region Custom Editing Manager

    /// <summary>
    /// Custom editing manager class. 
    /// Override ChangeValue to affect how the change is made or shown.
    /// Here we add a * to the edited value cells.
    /// </summary>
    public class CustomEditingManager : PivotEditingManager
    {
        public CustomEditingManager(PivotGridControlBase pivotGridControlBase) : base(pivotGridControlBase)
        {
        }

        protected override void ChangeValue(object oldValue, object newValue, int row1, int col1, PivotCellInfo pi)
        {
            //do the base change
            base.ChangeValue(oldValue, newValue, row1, col1, pi);

            //mark all the adjusted cell contents
            pi.FormattedText += "*";
        }
    }
    #endregion
}
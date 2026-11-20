#region Copyright Syncfusion Inc. 2001 - 2018
// Copyright Syncfusion Inc. 2001 - 2018. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using System.Text;
using Syncfusion.Windows.Forms;
using Syncfusion.Windows.Forms.Tools;

namespace MessageBoxAdv_2010
{
    public class Localizer : ILocalizationProvider
    {
        #region ILocalizationProvider Members

        public string GetLocalizedString(System.Globalization.CultureInfo culture, string name,object obj)
        {
            switch (name)
            {
                #region MessageBoxAdv
                case ResourceIdentifiers.Retry:
                    return "إعادة المحاولة";
                case ResourceIdentifiers.Abort:
                    return "إجهاض";
                case ResourceIdentifiers.Ignore:
                    return "تجاهل";
                case ResourceIdentifiers.OK:
                    return "حسنا";
                case ResourceIdentifiers.Cancel:
                    return "إلغاء";
                case ResourceIdentifiers.Yes:
                    return "نعم فعلا";
                case ResourceIdentifiers.No:
                    return "لا";
                case ResourceIdentifiers.Info:
                    return "إلغاء";
                #endregion
                default:
                    return string.Empty;
            }
        }

        #endregion
    }
}

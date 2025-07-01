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
using System.Text;
using Syncfusion.Windows.Forms;
using Syncfusion.Windows.Forms.Grid;

using System.Threading;

namespace AlertMessageLocalization
{
    class Localizer : ILocalizationProvider
    {
        #region ILocalizationProvider Members

        bool messageBoxLoc = false;
        public void getstring(bool s)
        {
            messageBoxLoc = s;
        }
        public string GetLocalizedString(System.Globalization.CultureInfo culture, string name, object obj)
        {
            if (messageBoxLoc)
            {
                switch (name)
                {
                    #region Menu Package

                    case GridResourceIdentifiers.Cannotchangepartofamergedcell:
                        return "Ein Teil einer verbundenen Zelle kann nicht geändert werden";
                    case ResourceIdentifiers.OK:
                        return "Ok";

                    case ResourceIdentifiers.Cancel:
                        return "Abbrechen";
                    #endregion

                    default:
                        return string.Empty;
                }
            }
            else
            {
                switch (name)
                {
                    #region Menu Package

                    case GridResourceIdentifiers.Cannotchangepartofamergedcell:
                        return "Cannot change part of a mergedcell ";
                    case ResourceIdentifiers.OK:
                        return "OK";

                    case ResourceIdentifiers.Cancel:
                        return "Cancel";
                    #endregion

                    default:
                        return string.Empty;
                }
            }

        }
        #endregion
    }
}

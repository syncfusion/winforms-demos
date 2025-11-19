#region Copyright Syncfusion Inc. 2001 - 2015
// Copyright Syncfusion Inc. 2001 - 2015. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using System.Text;
using Syncfusion.Windows.Forms;
using Syncfusion.Windows.Forms.Grid;
using Syncfusion.GridHelperClasses;
using System.Threading;

namespace DynamicFilter
{
    class Localizer : ILocalizationProvider
    {
        #region ILocalizationProvider Members

        string str = string.Empty;
        public void getstring(string s)
        {
            str = s;
        }
        public string GetLocalizedString(System.Globalization.CultureInfo culture, string name,object obj)
        {
            if (str == "True")
            {
                switch (name)
                {
                    #region Menu Package
                    case DynamicFilterResourceIdentifiers.StartsWith:
                        return "empieza con";
                    case DynamicFilterResourceIdentifiers.EndsWith:
                        return "termina con";
                    case DynamicFilterResourceIdentifiers.Equal:
                        return "Igual";
                    case DynamicFilterResourceIdentifiers.GreaterThan:
                        return "mayor que";
                    case DynamicFilterResourceIdentifiers.GreaterThanOrEqualTo:
                        return "MayorOIgualQue";
                    case DynamicFilterResourceIdentifiers.LessThan:
                        return "MenorQue";
                    case DynamicFilterResourceIdentifiers.LessThanOrEqualTo:
                        return "MenorOIgualQue";
                    case DynamicFilterResourceIdentifiers.Like:
                        return "como";
                    case DynamicFilterResourceIdentifiers.Match:
                        return "Coincidir";
                    case DynamicFilterResourceIdentifiers.NotEquals:
                        return "NoIgual";
                    case DynamicFilterResourceIdentifiers.ExpressionMATCH:
                        return "ExpresiónCOINCIDIR";
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
                    case DynamicFilterResourceIdentifiers.StartsWith:
                        return "StartsWith";
                    case DynamicFilterResourceIdentifiers.EndsWith:
                        return "EndsWith";
                    case DynamicFilterResourceIdentifiers.Equal:
                        return "Equals";
                    case DynamicFilterResourceIdentifiers.GreaterThan:
                        return "GreaterThan";
                    case DynamicFilterResourceIdentifiers.GreaterThanOrEqualTo:
                        return "GreaterThanOrEqualTo";
                    case DynamicFilterResourceIdentifiers.LessThan:
                        return "LessThan";
                    case DynamicFilterResourceIdentifiers.LessThanOrEqualTo:
                        return "LessThanOrEqualTo";
                    case DynamicFilterResourceIdentifiers.Like:
                        return "Like";
                    case DynamicFilterResourceIdentifiers.Match:
                        return "Match";
                    case DynamicFilterResourceIdentifiers.NotEquals:
                        return "NotEquals";
                    case DynamicFilterResourceIdentifiers.ExpressionMATCH:
                        return "Expression Match";
                    #endregion

                    default:
                        return string.Empty;
                }
            }
        }
        #endregion
    }
}

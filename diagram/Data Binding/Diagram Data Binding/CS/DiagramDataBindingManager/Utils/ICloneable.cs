#region Copyright Syncfusion Inc. 2001 - 2012
// Copyright Syncfusion Inc. 2001 - 2012. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;

namespace Syncfusion.Windows.Forms.Diagram.DataBinding
{
    /// <summary>
    /// Defines a Generic implementation for ICloneable interface.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    interface ICloneable<T>
    {
        T Clone();
    }
}

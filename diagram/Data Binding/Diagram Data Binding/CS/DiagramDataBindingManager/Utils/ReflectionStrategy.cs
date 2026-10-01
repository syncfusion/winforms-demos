#region Copyright Syncfusion Inc. 2001 - 2012
// Copyright Syncfusion Inc. 2001 - 2012. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System.Collections.Generic;

namespace Syncfusion.Windows.Forms.Diagram.DataBinding
{
    /// <summary>
    /// Defines an abstract class for defining Reflection strategy.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public abstract class ReflectionStrategy<T>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReflectionStrategy&lt;T&gt;"/> [ERROR: invalid expression DeclaringTypeKind].
        /// </summary>
        public ReflectionStrategy()
        {
        }

        /// <summary>
        /// Builds up the Reflection info that would be used for getting the Node attribute's information.
        /// </summary>
        public abstract void BuildUp(System.Reflection.Assembly assembly);

        /// <summary>
        /// Clears up all the memory.
        /// </summary>
        public abstract void TearDown();

    }

}

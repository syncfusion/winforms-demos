#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;

using System.Web;

namespace TestTreeApp
{
    [Serializable]
    public class Vision
    {
        private string m_desc;
        private List<Goal> m_goal;
        private int m_yr;
        public string Description { get { return m_desc; } set { m_desc = value; } }
        public int FiscalYear { get { return m_yr; } set { m_yr = value; } }
        public List<Goal> Goals { get { return m_goal; } set { m_goal = value; } }
    }
}
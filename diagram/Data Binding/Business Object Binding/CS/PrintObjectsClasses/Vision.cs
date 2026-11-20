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
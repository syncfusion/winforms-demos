using System;
using System.Collections.Generic;

using System.Web;

namespace TestTreeApp
{
    [Serializable]
    public class Goal
    {
        private string m_desc;
        private List<Objective> m_obj;
        public string Description { get { return m_desc; } set { m_desc = value; } }
        public List<Objective> Objectives { get { return m_obj; } set { m_obj = value; } }
    }
}
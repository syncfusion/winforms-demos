using System;
using System.Collections.Generic;

using System.Web;

namespace TestTreeApp
{
    [Serializable]
    public class Objective
    {
        private string m_desc;
        private List<KeyTask> m_key;
        public string Description { get { return m_desc; } set { m_desc = value; } }
        public List<KeyTask> KeyTasks { get { return m_key; } set { m_key = value; } }
    }
}
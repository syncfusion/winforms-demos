using System;
using System.Collections.Generic;

using System.Web;


    [Serializable]
    public class KeyTask
    {
        private string m_desc;
        private string m_leadr;
        private decimal m_cst;
        public string Description { get { return m_desc; } set { m_desc = value; } }
        public string Leader { get { return m_leadr; } set { m_leadr = value; } }
        public decimal CostSavings { get { return m_cst; } set { m_cst = value; } }
       
    }

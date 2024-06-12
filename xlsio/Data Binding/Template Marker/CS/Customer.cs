#region Copyright Syncfusion Inc. 2001 - 2024
// Copyright Syncfusion Inc. 2001 - 2024. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion

using Syncfusion.XlsIO;
using System.Drawing;
namespace EssentialXlsIOSamples
{
    #region Hyperlink Class

    public class Hyperlink : IHyperLink
    {
        #region Members
        private IApplication m_application;
        private object m_parent;
        private string m_address;
        private string m_name;
        private IRange m_range;
        private string m_screenTip;
        private string m_subAddress;
        private string m_textToDisplay;
        private ExcelHyperLinkType m_type;
        private IShape m_shape;
        private ExcelHyperlinkAttachedType m_attachedType;
        private byte[] m_image;
        #endregion
        public IApplication Application
        {
            get
            {
                return m_application;
            }
            set
            {
                m_application = value;
            }
        }
        public object Parent
        {
            get
            {
                return m_parent;
            }
            set
            {
                m_parent = value;
            }
        }
        public string Address
        {
            get
            {
                return m_address;
            }
            set
            {
                m_address = value;
            }
        }
        public string Name
        {
            get
            {
                return m_name;
            }
            set
            {
                m_name = value;
            }
        }
        public IRange Range
        {
            get
            {
                return m_range;
            }
            set
            {
                m_range = value;
            }
        }
        public string ScreenTip
        {
            get
            {
                return m_screenTip;
            }
            set
            {
                m_screenTip = value;
            }
        }
        public string SubAddress
        {
            get
            {
                return m_subAddress;
            }
            set
            {
                m_subAddress = value;
            }
        }
        public string TextToDisplay
        {
            get
            {
                return m_textToDisplay;
            }
            set
            {
                m_textToDisplay = value;
            }
        }
        public ExcelHyperLinkType Type
        {
            get
            {
                return m_type;
            }
            set
            {
                m_type = value;
            }
        }
        public IShape Shape
        {
            get
            {
                return m_shape;
            }
            set
            {
                m_shape = value;
            }
        }
        public ExcelHyperlinkAttachedType AttachedType
        {
            get
            {
                return m_attachedType;
            }
            set
            {
                m_attachedType = value;
            }
        }
        public byte[] Image
        {
            get
            {
                return m_image;
            }
            set
            {
                m_image = value;
            }
        }

        public Hyperlink(string address, string subAddress, string screenTip, string textToDisplay, ExcelHyperLinkType type, byte[] image)
        {
            Address = address;
            ScreenTip = screenTip;
            SubAddress = subAddress;
            TextToDisplay = textToDisplay;
            Type = type;
            Image = image;
        }
    }

    public class Company
    {
        #region Members
        private string m_name;
        private Hyperlink m_link;
        #endregion
        #region Properties
        public string Name
        {
            get
            {
                return m_name;
            }
            set
            {
                m_name = value;
            }
        }

        public Hyperlink Link
        {
            get
            {
                return m_link;
            }
            set
            {
                m_link = value;
            }
        }
        #endregion
    }

    #endregion

    class Customer
    {
        #region Members
        private string m_salesPerson;
        private string m_salesJanJune;
        private string m_salesJulyDec;
        private int m_change;
        private byte[] m_image;
        private Hyperlink m_hyperlink;
        #endregion

        #region Properties
        public string SalesPerson
        {
            get
            {
                return m_salesPerson;
            }
            set
            {
                m_salesPerson = value;
            }
        }

        public string SalesJanJune
        {
            get
            {
                return m_salesJanJune;
            }
            set
            {
                m_salesJanJune = value;
            }
        }
        public string SalesJulyDec
        {
            get
            {
                return m_salesJulyDec;
            }
            set
            {
                m_salesJulyDec = value;
            }

        }
        public int Change
        {
            get
            {
                return m_change;
            }
            set
            {
                m_change = value;
            }

        }

        public Hyperlink Hyperlink
        {
            get
            {
                return m_hyperlink;
            }
            set
            {
                m_hyperlink = value;
            }

        }

        public byte[] Image
        {
            get
            {
                return m_image;
            }
            set
            {
                m_image = value;
            }
        }
        #endregion

        #region Intialization
        public Customer()
        {
        }
        public Customer(string name,string juneToJuly,string julyToDec,int change,byte[] image)
        {
            this.m_salesPerson = name;
            this.m_salesJanJune = juneToJuly;
            this.m_salesJulyDec = julyToDec;
            this.m_change = change;
            this.m_image = image;
        }
        #endregion
    }
}

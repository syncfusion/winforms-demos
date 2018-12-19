using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Syncfusion.Windows.Forms;
using Syncfusion.Windows.Forms.Tools.XPMenus;

namespace TabbedMDI_2005
{
    public partial class Document1 : MetroForm
    {
        private float fontSize = 12F;

        public Document1(string docName)
            : base()
        {
            InitializeComponent();
            this.Text = docName;
            this.Name = docName;
        }

        private class FontSizes
        {
            public static float Small;
            public static float Medium;
            public static float Large;
            static FontSizes()
            {
                Small = 8f;
                Medium = 12f;
                Large = 24f;
            }
        }

        private FontFamily fontFamily;
        string checkedItem = "";
        private void FormatFont_Clicked(object sender, System.EventArgs e)
        {
            BarItem miClicked = (BarItem)sender;
            miClicked.Checked = true;
            foreach (BarItem item in this.parentBarItem1.Items)
            {
                if (item.Text != miClicked.Text)
                    item.Checked = false;
            }
            foreach (BarItem item in this.parentBarItem2.Items)
            {
                if (item.Text != miClicked.Text)
                    item.Checked = false;
            }

            fontSize = CurrentFontSize(miClicked);
            foreach (BarItem item in this.parentBarItem1.Items)
            {
                if (item.Checked)
                    checkedItem = item.Text;
            }
            fontFamily = CurrentFont(checkedItem);
            this.richTextBox1.Font = new Font(fontFamily, fontSize);
        }

        private FontFamily common;
        private FontFamily CurrentFont(string currentBarItem)
        {
            if (currentBarItem == this.barItem_SansSerif.Text)
                common = new FontFamily("Microsoft Sans Serif");
            else if (currentBarItem == this.barItem_courier.Text)
                common = new FontFamily("Courier New");
            else
                common = new FontFamily("Times New Roman");
            return common;
        }

        private float CurrentFontSize(BarItem currentBarItem)
        {
            float fontCurrent = 0F;
            if (currentBarItem.Text.Equals("Small"))
                fontCurrent = FontSizes.Small;
            else if (currentBarItem.Text.Equals("Medium"))
                fontCurrent = FontSizes.Medium;
            else if (currentBarItem.Text.Equals("Large"))
                fontCurrent = FontSizes.Large;
            else
                fontCurrent = fontSize;
            return fontCurrent;
        }
    }
}
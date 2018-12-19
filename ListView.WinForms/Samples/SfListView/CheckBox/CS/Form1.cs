using Syncfusion.WinForms.Controls;
using Syncfusion.WinForms.ListView.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Checking
{
    public partial class Form1 : SfForm
    {
        #region constructor
        public Form1()
        {
            InitializeComponent();
            OrderInfoCollection data = new OrderInfoCollection();
            this.sfListView1.DataSource = data.OrdersListDetails;
            this.sfListView1.DisplayMember = "ProductName";
            this.sfListViewSettings();
            
            try
            {
                Bitmap bmp = new Bitmap(Image.FromFile(@"../../Icon/sficon.ico"));
                this.Icon = Icon.FromHandle(bmp.GetHicon());
            }
            catch (Exception ex)
            { }
        }
        #endregion

        #region sfListViewSeetings
        void sfListViewSettings()
        {

            this.sfListView1.AllowSelectAll = true;
            this.sfListView1.AllowRecursiveChecking = true;
            this.sfListView1.ShowCheckBoxes = true;
            this.sfListView1.HotTracking = true;
            this.sfListView1.Style.ItemStyle.Font = new Font("Microsoft Sans Serif", 9.75f);
            this.sfListView1.View.GroupDescriptors.Add(new Syncfusion.DataSource.GroupDescriptor("ShipCountry"));
            this.sfListView1.SelectionMode = SelectionMode.One;
            this.sfListView1.ItemHeight = 24;
           
            #region CheckBoxSelection combobox settings
            List<CheckBoxSelection> collection = new List<CheckBoxSelection>();
            collection.Add(new CheckBoxSelection() { Mode = "Default", Value = 1 });
            collection.Add(new CheckBoxSelection() { Mode = "SelectOnCheck", Value = 2 });
            collection.Add(new CheckBoxSelection() { Mode = "CheckOnItemClick", Value = 3 });
            collection.Add(new CheckBoxSelection() { Mode = "SynchronizeSelection", Value = 4 });
            this.chkBoxSelectionCombo.DataSource = collection;
            this.chkBoxSelectionCombo.DisplayMember = "Mode";
            this.chkBoxSelectionCombo.ValueMember = "Mode";
            this.chkBoxSelectionCombo.TextBox.Text = "Default";
            this.chkBoxSelectionCombo.ThemeName = "Office2016Colorful";
            this.chkBoxSelectionCombo.DropDownListView.Style.ItemStyle.Font = new Font("Microsoft Sans Serif", 9.75f);
            #endregion

            #region Selection ComboBox settings
            List<ItemSelectionMode> collection2 = new List<ItemSelectionMode>();
            collection2.Add(new ItemSelectionMode() { Mode = "None", Value = 1 });
            collection2.Add(new ItemSelectionMode() { Mode = "One", Value = 2 });
            collection2.Add(new ItemSelectionMode() { Mode = "MultiSimple", Value = 3 });
            collection2.Add(new ItemSelectionMode() { Mode = "MultiExtended", Value = 4 });
            this.selectionCombo.DataSource = collection2;
            this.selectionCombo.DisplayMember = "Mode";
            this.selectionCombo.ValueMember = "Mode";
            this.selectionCombo.TextBox.Text = "One";
            this.selectionCombo.ThemeName = "Office2016Colorful";
            this.selectionCombo.DropDownListView.Style.ItemStyle.Font = new Font("Microsoft Sans Serif", 9.75f);
            #endregion
        }

        #endregion

        #region events

        private void selectionCombo_SelectedValueChanged(object sender, EventArgs e)
        {
            SelectionMode mode;
            if (Enum.TryParse<SelectionMode>(this.selectionCombo.SelectedValue.ToString(), out mode))
                this.sfListView1.SelectionMode = mode;
        }

        private void chkBoxSelectionCombo_SelectedValueChanged(object sender, EventArgs e)
        {
            CheckBoxSelectionMode mode;
            if (Enum.TryParse<CheckBoxSelectionMode>(this.chkBoxSelectionCombo.SelectedValue.ToString(), out mode))
                this.sfListView1.CheckBoxSelectionMode = mode;
        }
        #endregion
    }

    #region CheckBoxSelection
    public class CheckBoxSelection
    {
        public string Mode { get; set; }
        public int Value { get; set; }
    }

    public class ItemSelectionMode
    {
        public string Mode { get; set; }
        public int Value { get; set; }
    }
    #endregion

    #region ThemeData
    public class ThemeTypes
    {
        public string ThemeName { get; set; }
        public int Value { get; set; }
    }
    #endregion
}

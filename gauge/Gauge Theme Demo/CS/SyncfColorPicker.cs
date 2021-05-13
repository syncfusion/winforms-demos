#region Copyright Syncfusion Inc. 2001 - 2019
// Copyright Syncfusion Inc. 2001 - 2019. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Syncfusion.Windows.Forms.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GaugeTheme_2010
{
    public class SyncfColorPicker : ColorPickerUIAdv
    {
        public SyncfColorPicker()
        {
            this.RecentGroup.Visible = false;
            this.StandardGroup.Visible = false;
            this.ThemeGroup.HeaderHeight = 0;
            this.ThemeGroup.IsSubItemsVisible = true;
            this.BeforeTouchSize = new System.Drawing.Size(13, 13);
            this.ButtonsHeight = 0;
            this.ColorItemSize = new System.Drawing.Size(20, 20);
            this.Location = new System.Drawing.Point(238, 131);
            this.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.MinimumSize = new System.Drawing.Size(206, 132);
            this.SelectedColor = System.Drawing.Color.Empty;
            this.Size = new System.Drawing.Size(242, 156);
            this.MinimumSize = new System.Drawing.Size(242, 156);
            this.Style = Syncfusion.Windows.Forms.Tools.ColorPickerUIAdv.visualstyle.Metro;
            this.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.VerticalItemsSpacing = 6;
        }

        private Control m_ParentControl = null;

        public Control ParentControl
        {
            get { return m_ParentControl; }
            set { m_ParentControl = value; }
        }


    }
}

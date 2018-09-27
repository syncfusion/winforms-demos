using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Syncfusion.Windows.Forms;
using Syncfusion.Windows.Forms.Tools;
using System.Drawing.Drawing2D;
using Syncfusion.Runtime.Serialization;
using System.Collections;
using Syncfusion.Windows.Forms.Tools.XPMenus;


namespace GroupBarDemo_2005
{
    public partial class Form1 : MetroForm
    {
        #region Form's Constructor
        public Form1()
        {
            InitializeComponent();
            //Initial settings
            cmbGBBorder.SelectedIndex = 2;
            cmbTextAlignment.SelectedIndex = 0;
            cmbGBVisualStyle.SelectedIndex = 7;
            cmbPopupResize.SelectedIndex = 0;
            this.cmbOutLookGBStyle.SelectedIndex = 5;
            this.cmbOutLookGBColorScheme.SelectedIndex = 0;
            gbAdvanced.GroupBarItemRemoved += new GroupBarItemEventHandler(gbAdvanced_GroupBarItemRemoved);
            gbAdvanced.GroupBarItemAdded += new GroupBarItemEventHandler(gbAdvanced_GroupBarItemAdded);

            this.cpCustomColor.SelectedColor = System.Drawing.SystemColors.HotTrack;
            this.tabControlAdv1.SelectedIndex = 0;
            this.gbAdvanced.SelectedItem = 1;

            this.imageListAdv1.ToImageList().ColorDepth = ColorDepth.Depth32Bit;
            this.gbOutlook.GroupBarItems[0].Image = this.imageListAdv1.Images[0];
            this.gbOutlook.GroupBarItems[1].Image = this.imageListAdv1.Images[1];
            this.gbOutlook.GroupBarItems[2].Image = this.imageListAdv1.Images[2];
            this.gbOutlook.GroupBarItems[3].Image = this.imageListAdv1.Images[3];
            this.gbOutlook.GroupBarItems[4].Image = this.imageListAdv1.Images[4];
            this.gbOutlook.GroupBarItems[5].Image = this.imageListAdv1.Images[5];
            this.gbOutlook.GroupBarItems[6].Image = this.imageListAdv1.Images[6];
            cpCustomColor.SelectedColor = Color.FromArgb(131, 195, 207);
            SetCustomColor();
            try
            {
                System.Drawing.Icon ico = new System.Drawing.Icon(GetIconFile(@"common\Images\Grid\Icon\sfgrid.ico"));
                this.Icon = ico;
                this.gbVisualStudio.SelectedItem = 0;
            }
            catch { }

        }
        private string GetIconFile(string bitmapName)
        {
            for (int n = 0; n < 10; n++)
            {
                if (System.IO.File.Exists(bitmapName))
                    return bitmapName;

                bitmapName = @"..\" + bitmapName;
            }

            return bitmapName;
        }

        #endregion

        #region VS Like GroupBar


        //Flat Look
        private void flatLookCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            this.gbVisualStudio.FlatLook = this.cbflatLook.Checked;
        }

        //GroupBar BorderStyle
        private void GBBorderComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.gbVisualStudio.BorderStyle = (BorderStyle)Enum.Parse(typeof(BorderStyle), this.cmbGBBorder.SelectedItem.ToString(), true);
        }

        //GroupBar ClientBorder
        private void ClientBorderCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            this.gbVisualStudio.DrawClientBorder = this.cbDrawClientBorder.Checked;
            foreach (GroupBarItem gbItem in this.gbVisualStudio.GroupBarItems)
            {
                gbItem.ClientBorderColors = new Syncfusion.Windows.Forms.Tools.BorderColors(cpBack.SelectedColor, cpBack.SelectedColor, cpBack.SelectedColor, cpBack.SelectedColor);
            }
        }
        //GroupBar Visual style
        private void GBVisualStyleComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.gbVisualStudio.VisualStyle = (VisualStyle)Enum.Parse(typeof(VisualStyle), this.cmbGBVisualStyle.SelectedItem.ToString(), true);
            if (this.gbVisualStudio.VisualStyle == VisualStyle.Default)
                this.cbflatLook.Enabled = true;
            else               
                this.cbflatLook.Enabled = false;

            if (this.gbVisualStudio.VisualStyle == VisualStyle.Office2016Colorful)
            {
                //WinFormsGroupView
                this.WinFormsGroupView.HighlightItemColor = ColorTranslator.FromHtml("#aeaeae");
                this.WinFormsGroupView.SelectedHighlightItemColor = ColorTranslator.FromHtml("#aeaeae");
                this.WinFormsGroupView.HighlightTextColor = this.WinFormsGroupView.SelectedTextColor = Color.Black;
                this.WinFormsGroupView.SelectedItemColor = ColorTranslator.FromHtml("#aeaeae");
                this.WinFormsGroupView.SelectingItemColor = ColorTranslator.FromHtml("#aeaeae");
                this.WinFormsGroupView.SelectingTextColor = Color.Black;

                //ComponentsGroupView

                this.ComponentsGroupView.HighlightItemColor = ColorTranslator.FromHtml("#aeaeae");
                this.ComponentsGroupView.SelectedHighlightItemColor = ColorTranslator.FromHtml("#aeaeae");
                this.ComponentsGroupView.HighlightTextColor = this.WinFormsGroupView.SelectedTextColor = Color.Black;
                this.ComponentsGroupView.SelectedItemColor = ColorTranslator.FromHtml("#aeaeae");
                this.ComponentsGroupView.SelectingItemColor = ColorTranslator.FromHtml("#aeaeae");
                this.ComponentsGroupView.SelectingTextColor = Color.Black;

                //GeneralGroupView
                this.GeneralGroupView.HighlightItemColor = ColorTranslator.FromHtml("#aeaeae");
                this.GeneralGroupView.SelectedHighlightItemColor = ColorTranslator.FromHtml("#aeaeae");
                this.GeneralGroupView.HighlightTextColor = this.WinFormsGroupView.SelectedTextColor = Color.Black;
                this.GeneralGroupView.SelectedItemColor = ColorTranslator.FromHtml("#aeaeae");
                this.GeneralGroupView.SelectingItemColor = ColorTranslator.FromHtml("#aeaeae");
                this.GeneralGroupView.SelectingTextColor = Color.Black;
            }
            else if (this.gbVisualStudio.VisualStyle == VisualStyle.Office2016Black)
            {
                //WinFormsGroupView
                this.WinFormsGroupView.HighlightItemColor = ColorTranslator.FromHtml("#969696");
                this.WinFormsGroupView.SelectedHighlightItemColor = ColorTranslator.FromHtml("#969696");
                this.WinFormsGroupView.HighlightTextColor = this.WinFormsGroupView.SelectedTextColor = ColorTranslator.FromHtml("#f1f1f1");
                this.WinFormsGroupView.SelectedItemColor = ColorTranslator.FromHtml("#969696");
                this.WinFormsGroupView.SelectingItemColor = ColorTranslator.FromHtml("#969696");
                this.WinFormsGroupView.SelectingTextColor = ColorTranslator.FromHtml("#f1f1f1");

                //ComponentsGroupView
                this.ComponentsGroupView.HighlightItemColor = ColorTranslator.FromHtml("#969696");
                this.ComponentsGroupView.SelectedHighlightItemColor = ColorTranslator.FromHtml("#969696");
                this.ComponentsGroupView.HighlightTextColor = this.WinFormsGroupView.SelectedTextColor = ColorTranslator.FromHtml("#f1f1f1");
                this.ComponentsGroupView.SelectedItemColor = ColorTranslator.FromHtml("#969696");
                this.ComponentsGroupView.SelectingItemColor = ColorTranslator.FromHtml("#969696");
                this.ComponentsGroupView.SelectingTextColor = ColorTranslator.FromHtml("#f1f1f1");

                //GeneralGroupView
                this.GeneralGroupView.HighlightItemColor = ColorTranslator.FromHtml("#969696");
                this.GeneralGroupView.SelectedHighlightItemColor = ColorTranslator.FromHtml("#969696");
                this.GeneralGroupView.HighlightTextColor = this.WinFormsGroupView.SelectedTextColor = Color.Black;
                this.GeneralGroupView.SelectedItemColor = ColorTranslator.FromHtml("#969696");
                this.GeneralGroupView.SelectingItemColor = ColorTranslator.FromHtml("#969696");
                this.GeneralGroupView.SelectingTextColor = ColorTranslator.FromHtml("#f1f1f1");
            }
            else if (this.gbVisualStudio.VisualStyle == VisualStyle.Office2016DarkGray)
            {
                //WinFormsGroupView
                this.WinFormsGroupView.SelectedHighlightItemColor = ColorTranslator.FromHtml("#969696");
                this.WinFormsGroupView.HighlightItemColor = ColorTranslator.FromHtml("#969696");
                this.WinFormsGroupView.HighlightTextColor = this.WinFormsGroupView.SelectedTextColor = ColorTranslator.FromHtml("#f1f1f1");
                this.WinFormsGroupView.SelectedItemColor = ColorTranslator.FromHtml("#969696");
                this.WinFormsGroupView.SelectingItemColor = ColorTranslator.FromHtml("#969696");
                this.WinFormsGroupView.SelectingTextColor = ColorTranslator.FromHtml("#f1f1f1");

                //ComponentsGroupView
                this.ComponentsGroupView.HighlightItemColor = ColorTranslator.FromHtml("#969696");
                this.ComponentsGroupView.SelectedHighlightItemColor = ColorTranslator.FromHtml("#969696");
                this.ComponentsGroupView.HighlightTextColor = this.WinFormsGroupView.SelectedTextColor = Color.Black;
                this.ComponentsGroupView.SelectedItemColor = ColorTranslator.FromHtml("#969696");
                this.ComponentsGroupView.SelectingItemColor = ColorTranslator.FromHtml("#969696");
                this.ComponentsGroupView.SelectingTextColor = ColorTranslator.FromHtml("#f1f1f1");

                //GeneralGroupView
                this.GeneralGroupView.HighlightItemColor = ColorTranslator.FromHtml("#969696");
                this.GeneralGroupView.SelectedHighlightItemColor = ColorTranslator.FromHtml("#969696");
                this.GeneralGroupView.HighlightTextColor = this.WinFormsGroupView.SelectedTextColor = Color.Black;
                this.GeneralGroupView.SelectedItemColor = ColorTranslator.FromHtml("#969696");
                this.GeneralGroupView.SelectingItemColor = ColorTranslator.FromHtml("#969696");
                this.GeneralGroupView.SelectingTextColor = ColorTranslator.FromHtml("#f1f1f1");
            }
            else if (this.gbVisualStudio.VisualStyle == VisualStyle.Office2016White)
            {
                //WinFormsGroupView
                this.WinFormsGroupView.SelectedHighlightItemColor = ColorTranslator.FromHtml("#cde6f7");
                this.WinFormsGroupView.HighlightItemColor = ColorTranslator.FromHtml("#cde6f7");
                this.WinFormsGroupView.HighlightTextColor = this.WinFormsGroupView.SelectedTextColor = Color.Black;
                this.WinFormsGroupView.SelectedItemColor = ColorTranslator.FromHtml("#cde6f7");
                this.WinFormsGroupView.SelectingItemColor = ColorTranslator.FromHtml("#cde6f7");
                this.WinFormsGroupView.SelectingTextColor = Color.Black;

                //ComponentsGroupView
                this.ComponentsGroupView.SelectedHighlightItemColor = ColorTranslator.FromHtml("#cde6f7");
                this.ComponentsGroupView.HighlightItemColor = ColorTranslator.FromHtml("#cde6f7");
                this.ComponentsGroupView.HighlightTextColor = this.WinFormsGroupView.SelectedTextColor = Color.Black;
                this.ComponentsGroupView.SelectedItemColor = ColorTranslator.FromHtml("#cde6f7");
                this.ComponentsGroupView.SelectingItemColor = ColorTranslator.FromHtml("#cde6f7");
                this.ComponentsGroupView.SelectingTextColor = Color.Black;

                //GeneralGroupView
                this.GeneralGroupView.SelectedHighlightItemColor = ColorTranslator.FromHtml("#cde6f7");
                this.GeneralGroupView.HighlightItemColor = ColorTranslator.FromHtml("#cde6f7");
                this.GeneralGroupView.HighlightTextColor = this.WinFormsGroupView.SelectedTextColor = Color.Black;
                this.GeneralGroupView.SelectedItemColor = ColorTranslator.FromHtml("#cde6f7");
                this.GeneralGroupView.SelectingItemColor = ColorTranslator.FromHtml("#cde6f7");
                this.GeneralGroupView.SelectingTextColor = Color.Black;
            }
            else
            {
                //WinFormsGroupView
                this.cbflatLook.Enabled = false;
                this.WinFormsGroupView.SelectedItemColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(111)))));
                this.WinFormsGroupView.SelectingItemColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(111)))));
                this.WinFormsGroupView.SelectedHighlightItemColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(128)))), ((int)(((byte)(62)))));
                this.WinFormsGroupView.HighlightItemColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(238)))), ((int)(((byte)(194)))));
                this.WinFormsGroupView.HighlightItemColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(238)))), ((int)(((byte)(194)))));
                this.WinFormsGroupView.HighlightTextColor = System.Drawing.SystemColors.ControlText;
                this.WinFormsGroupView.ForeColor = System.Drawing.SystemColors.ControlText;
                this.WinFormsGroupView.SelectedTextColor = System.Drawing.SystemColors.ControlText;

                //ComponentsGroupView
                this.ComponentsGroupView.SelectedItemColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(111)))));
                this.ComponentsGroupView.SelectingItemColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(111)))));
                this.ComponentsGroupView.SelectedHighlightItemColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(128)))), ((int)(((byte)(62)))));
                this.ComponentsGroupView.HighlightItemColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(238)))), ((int)(((byte)(194)))));
                this.ComponentsGroupView.HighlightItemColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(238)))), ((int)(((byte)(194)))));
                this.ComponentsGroupView.HighlightTextColor = System.Drawing.SystemColors.ControlText;
                this.ComponentsGroupView.ForeColor = System.Drawing.SystemColors.ControlText;
                this.ComponentsGroupView.SelectedTextColor = System.Drawing.SystemColors.ControlText;

                //GeneralGroupView
                this.GeneralGroupView.SelectedItemColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(111)))));
                this.GeneralGroupView.SelectingItemColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(111)))));
                this.GeneralGroupView.SelectedHighlightItemColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(128)))), ((int)(((byte)(62)))));
                this.GeneralGroupView.HighlightItemColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(238)))), ((int)(((byte)(194)))));
                this.GeneralGroupView.HighlightItemColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(238)))), ((int)(((byte)(194)))));
                this.GeneralGroupView.HighlightTextColor = System.Drawing.SystemColors.ControlText;
                this.GeneralGroupView.ForeColor = System.Drawing.SystemColors.ControlText;
                this.GeneralGroupView.SelectedTextColor = System.Drawing.SystemColors.ControlText;
            }
        }

        //Text Alignment
        private void GBTextAlignmentComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.gbVisualStudio.TextAlign = (Syncfusion.Windows.Forms.Tools.TextAlignment)Enum.Parse(typeof(Syncfusion.Windows.Forms.Tools.TextAlignment), this.cmbTextAlignment.SelectedItem.ToString(), true);
        }

        //Integrated scrolling
        private void IntegratedScrollingCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            this.gbVisualStudio.IntegratedScrolling = this.cbIntegratedScrolling.Checked;
        }

        //GroupBar BackColor
        private void GBBackColorPickerButton_ColorSelected(object sender, EventArgs e)
        {
            //this.gbVisualStudio.BackColor = cpBack.SelectedColor;
            this.GeneralGroupView.BackColor = cpBack.SelectedColor;
            this.ComponentsGroupView.BackColor = cpBack.SelectedColor;
            this.WinFormsGroupView.BackColor = cpBack.SelectedColor;
        }

        #endregion

        #region Outlook  GroupBar

        //ShowChevron
        private void ChevronCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            this.gbOutlook.ShowChevron = cbChevron.Checked;
        }

        //Show item image in header
        private void ImageInHeaderCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            this.gbOutlook.ShowItemImageInHeader = cbImageInHeader.Checked;
        }

        //Enable Stacked Mode
        private void StackedModeCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            this.gbOutlook.StackedMode = this.cbStackedMode.Checked;
            this.panel25.Enabled = this.cbStackedMode.Checked;
            this.cbCollapse.Enabled = cbStackedMode.Checked;
        }

        //Visual style
        #region Visual style
        private void OutLookGBStyleComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.gbOutlook.VisualStyle = (VisualStyle)Enum.Parse(typeof(VisualStyle), this.cmbOutLookGBStyle.SelectedItem.ToString(), true);

            this.monthCalendarAdv2.Style = (VisualStyle)Enum.Parse(typeof(VisualStyle), this.cmbOutLookGBStyle.SelectedItem.ToString(), true);
            if (this.cmbOutLookGBStyle.SelectedIndex == 2)
            {
                cmbOutLookGBColorScheme.Enabled = true;
                foreach (Control ctrl in this.gbOutlook.Controls)
                {

                    if (ctrl.GetType() == typeof(XPTaskBar))
                    {
                        XPTaskBar xpt = ctrl as XPTaskBar;
                        xpt.Style = XPTaskBarStyle.Office2007;
                        xpt.ThemesEnabled = false;
                    }
                }

                this.scrollersFrame1.VisualStyle = ScrollBarCustomDrawStyles.Office2007Generic;
                this.scrollersFrame2.VisualStyle = ScrollBarCustomDrawStyles.Office2007Generic;
            }
            if (this.cmbOutLookGBStyle.SelectedIndex == 1)
            {
                cmbOutLookGBColorScheme.Enabled = false;
                foreach (Control ctrl in this.gbOutlook.Controls)
                {

                    if (ctrl.GetType() == typeof(XPTaskBar))
                    {
                        XPTaskBar xpt = ctrl as XPTaskBar;
                        xpt.Style = XPTaskBarStyle.Default;
                        xpt.ThemesEnabled = true;
                    }
                }
                this.scrollersFrame1.VisualStyle = ScrollBarCustomDrawStyles.WindowsXP;
                this.scrollersFrame2.VisualStyle = ScrollBarCustomDrawStyles.WindowsXP;
            }
            else if (this.cmbOutLookGBStyle.SelectedIndex == 0)
            {
                cmbOutLookGBColorScheme.Enabled = false;
                foreach (Control ctrl in this.gbOutlook.Controls)
                {

                    if (ctrl.GetType() == typeof(XPTaskBar))
                    {
                        XPTaskBar xpt = ctrl as XPTaskBar;
                        xpt.Style = XPTaskBarStyle.Default;
                        xpt.ThemesEnabled = false;
                    }
                }
                this.scrollersFrame1.VisualStyle = ScrollBarCustomDrawStyles.Classic;
                this.scrollersFrame2.VisualStyle = ScrollBarCustomDrawStyles.Classic;
            }
        }
        #endregion

        //Color scheme
        private void OutLookGBColorSchemeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cmbOutLookGBColorScheme.SelectedIndex == 0)
                this.gbOutlook.Office2007Theme = Office2007Theme.Managed;
            else
            {
                this.gbOutlook.Office2007Theme = (Office2007Theme)Enum.Parse(typeof(Office2007Theme), this.cmbOutLookGBColorScheme.SelectedItem.ToString(), true);
            }
            this.scrollersFrame1.OfficeColorScheme = (Office2007ColorScheme)Enum.Parse(typeof(Office2007ColorScheme), this.cmbOutLookGBColorScheme.SelectedItem.ToString(), true);
            foreach (Control ctrl in this.gbOutlook.Controls)
            {
                if (ctrl.GetType() == typeof(XPTaskBar))
                {
                    XPTaskBar xpt = ctrl as XPTaskBar;
                    xpt.Office2007ColorScheme = (Office2007Theme)Enum.Parse(typeof(Office2007Theme), this.cmbOutLookGBColorScheme.SelectedItem.ToString(), true);
                }
            }
            this.monthCalendarAdv2.Office2007Theme = (Office2007Theme)Enum.Parse(typeof(Office2007Theme), this.cmbOutLookGBColorScheme.SelectedItem.ToString(), true);

        }

        //Allow collapse
        private void cbAllowCollapse_CheckedChanged(object sender, System.EventArgs e)
        {
            this.gbOutlook.AllowCollapse = cbAllowCollapse.Checked;
            this.panel23.Enabled = cbAllowCollapse.Checked;
        }

        //Collapse GroupBar
        private void cbCollapse_CheckedChanged(object sender, System.EventArgs e)
        {
            this.gbOutlook.Collapsed = cbCollapse.Checked;
        }

        //Show Gripper
        private void cbShowGripper_CheckedChanged(object sender, System.EventArgs e)
        {
            this.gbOutlook.ShowPopupGripper = cbShowGripper.Checked;
        }

        //PopupAuto close 
        private void cbAutoClose_CheckedChanged(object sender, System.EventArgs e)
        {
            this.gbOutlook.PopupAutoClose = this.cbAutoClose.Checked;
        }

        //Collapsed width
        private void CollapsedWidthNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            this.gbOutlook.CollapsedWidth = (int)this.numericCollapsedWidth.Value;
        }

        //PopupResize mode
        private void PopupResizeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.gbOutlook.PopupResizeMode = (PopupResizeMode)Enum.Parse(typeof(PopupResizeMode), this.cmbPopupResize.SelectedItem.ToString());
        }


        #endregion

        #region Advanced Settings

        #region Custom Colors

        #region Custom colors for GroupBar with Office2007 Style
        Office2007Colors colors = Office2007Colors.Default;
        private void cpCustomColor_ColorSelected(object sender, EventArgs e)
        {
            if (this.gbAdvanced.GroupBarItems.Count > 0)
            {
                SetCustomColor();
                this.NestedGroupBar.ProvideGroupBarItemBrush += new ProvideGroupBarItemBrushEventHandler(NestedGroupBar_ProvideGroupBarItemBrush);
            }
        }

        protected void SetCustomColor()
        {
            //Sets custom colors for Office2007 style
            this.gbOutlook.Office2007Theme = Office2007Theme.Managed;
            this.gbAdvanced.Office2007Theme = Office2007Theme.Blue;

            colors.GroupBarItemTextColor = Color.Black;
            colors.GroupBarBorderColor = cpCustomColor.SelectedColor;

            colors.GroupBarHighlightColorDark = Color.FromArgb(248, 215, 185);
            colors.GroupBarHighlightColorLight = Color.FromArgb(255, 233, 215);

            colors.GroupBarItemColorDark = cpCustomColor.SelectedColor;
            colors.GroupBarItemColorLight = Color.FromArgb(235, 246, 248);

            colors.GroupBarSelectedColorDark = Color.FromArgb(255, 191, 135);
            colors.GroupBarSelectedColorLight = Color.FromArgb(255, 233, 215);
            colors.GroupBarSelectedTopColorDark = Color.FromArgb(248, 215, 185);
            colors.GroupBarSelectedTopColorLight = Color.FromArgb(255, 233, 215);

            this.gbAdvanced.GroupBarItems[this.gbAdvanced.SelectedItem].ForeColor = Color.White;
            this.gbAdvanced.Refresh();


        }
        #endregion

        #region Custom color for GroupBar with Office XP style

        private void NestedGroupBar_ProvideGroupBarItemBrush(object sender, ProvideGroupBarItemBrushEventArgs args)
        {
            Blend blend = new Blend();
            blend.Positions = new float[] { 0.0F, 0.4F, 0.4F + 0.001F, 1.0F };
            blend.Factors = new float[] { 0.0F, 0.5F, 1.0F, 0.5F };
            LinearGradientBrush lgb;
            lgb = new LinearGradientBrush(args.Bounds, Color.White, cpCustomColor.SelectedColor, LinearGradientMode.Vertical);
            lgb.Blend = blend;
            args.BackgroundBrush = lgb;


            this.NestedGroupBar.GroupBarItems[0].ClientBorderColors = new Syncfusion.Windows.Forms.Tools.BorderColors(cpCustomColor.SelectedColor, cpCustomColor.SelectedColor, cpCustomColor.SelectedColor, cpCustomColor.SelectedColor);
            this.NestedGroupBar.GroupBarItems[1].ClientBorderColors = new Syncfusion.Windows.Forms.Tools.BorderColors(cpCustomColor.SelectedColor, cpCustomColor.SelectedColor, cpCustomColor.SelectedColor, cpCustomColor.SelectedColor);
            foreach (GroupBarItem gbItem in this.gbAdvanced.GroupBarItems)
            {
                gbItem.ClientBorderColors = new Syncfusion.Windows.Forms.Tools.BorderColors(cpCustomColor.SelectedColor, cpCustomColor.SelectedColor, cpCustomColor.SelectedColor, cpCustomColor.SelectedColor);
            }

            //this.PersonalGroupView.HighlightItemColor = cpCustomColor.SelectedColor;
            //    this.gvOffice.HighlightItemColor = cpCustomColor.SelectedColor;
            
        }
        #endregion
        #endregion


        #region Events
        private ListViewItem listViewItem1;
        private void gbAdvanced_GroupBarItemSelectionChanging(object sender, GroupBarItemSelectionChangingEventArgs args)
        {
            listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] { "GroupBarItemSelectionChanging ", "Previous: " + args.OldSelected.ToString() + " New: " + args.NewSelected.ToString() });
            this.listView1.Items.Add(listViewItem1);
        }
        private void gbAdvanced_GroupBarItemSelected(object sender, EventArgs e)
        {
            GroupBar gb = sender as GroupBar;
            listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] { "GroupBarItemSelected", gb.SelectedItem.ToString() });
            this.listView1.Items.Add(listViewItem1);
        }
        private void gbAdvanced_GroupBarItemRemoved(object sender, GroupBarItemEventArgs args)
        {
            listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] { "GroupBarItemRemoved", "Item Removed: " + args.Item.Text });
            this.listView1.Items.Add(listViewItem1);
        }
        private void gbAdvanced_GroupBarItemAdded(object sender, GroupBarItemEventArgs args)
        {
            listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] { "GroupBarItemAdded", "Item Added: " + args.Item.Text });
            this.listView1.Items.Add(listViewItem1);
        }
        private void gbAdvanced_GroupBarItemRenamed(object obj, GroupItemRenamedEventArgs arg)
        {
            listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] { "GroupBarItemRenamed", "Item Renamed: " + arg.Index + " NewLabel: " + arg.NewLabel + " OldLabel: " + arg.OldLabel });
            this.listView1.Items.Add(listViewItem1);
        }

        // Handler for the GroupView.ShowContextMenu event.
        private void gbAdvanced_ShowContextMenu(object sender, System.EventArgs e)
        {
            ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] { "ContextMenu Shown" });
            this.listView1.Items.Add(listViewItem1);

            Syncfusion.Windows.Forms.Tools.XPMenus.PopupMenu menu = new Syncfusion.Windows.Forms.Tools.XPMenus.PopupMenu();

            menu.ParentBarItem = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            menu.ParentBarItem.Style = Syncfusion.Windows.Forms.VisualStyle.Office2003;

            BarItem additem = new BarItem("Add New Item", new EventHandler(this.gvc_MenuAddNewItem));
            additem.ImageList = this.ilGroupBarSmall;
            additem.ImageIndex = 28;
            menu.ParentBarItem.Items.Add(additem);

            BarItem removeitem = new BarItem("Remove Item", new EventHandler(this.gvc_MenuRemoveItem));
            removeitem.ImageList = this.ilGroupBarSmall;
            removeitem.ImageIndex = 27;
            menu.ParentBarItem.Items.Add(removeitem);

            BarItem renameitem = new BarItem("Rename Item", new EventHandler(this.gvc_MenuRenameItem));
            menu.ParentBarItem.Items.Add(renameitem);

            if (this.gbAdvanced.HighlightItem == -1)
            {
                removeitem.Enabled = false;
                renameitem.Enabled = false;
            }

            menu.Show(this.gbAdvanced, this.gbAdvanced.PointToClient(Cursor.Position));
        }
        public void gvc_MenuAddNewItem(object sender, EventArgs e)
        {
            // Create a new GroupBarItem with the new GroupView as the client
            Syncfusion.Windows.Forms.Tools.GroupBarItem grpbaritem = new Syncfusion.Windows.Forms.Tools.GroupBarItem();

            grpbaritem.Text = String.Empty;
            this.gbAdvanced.GroupBarItems.Add(grpbaritem);
            this.gbAdvanced.InplaceRenameItem(this.gbAdvanced.GroupBarItems.Count - 1);
        }

        private void gvc_MenuRemoveItem(object sender, EventArgs e)
        {
            if (this.gbAdvanced.SelectedItem >= 0 && this.gbAdvanced.GroupBarItems.Count > 0)
            {

                this.gbAdvanced.GroupBarItems.Remove(this.gbAdvanced.GroupBarItems[this.gbAdvanced.ContextMenuItem]);
            }
        }

        private void gvc_MenuRenameItem(object sender, EventArgs e)
        {

            this.gbAdvanced.InplaceRenameItem(this.gbAdvanced.ContextMenuItem);
        }

        private void gbOutlook_StateChanged(object sender, EventArgs e)
        {
            cbCollapse.Checked = this.gbOutlook.Collapsed;
        }

       
        #endregion

        private void gbVisualStudio_GroupBarItemSelected(object sender, EventArgs e)
        {

        }

        #endregion

        private void tabPageOutlook_Click(object sender, EventArgs e)
        {

        }

        private void cbAllowCollapse_CheckStateChanged(object sender, EventArgs e)
        {

        }

        private void panel23_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tabPageAdvanced_Click(object sender, EventArgs e)
        {

        }

        private void cpCustomColor_Click(object sender, EventArgs e)
        {
            this.PersonalGroupView.HighlightItemColor = cpCustomColor.SelectedColor;
            this.gvOffice.HighlightItemColor = cpCustomColor.SelectedColor;
        }

    }
}
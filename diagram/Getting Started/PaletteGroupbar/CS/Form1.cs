#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Syncfusion.Windows.Forms.Diagram.Controls;
using Syncfusion.Windows.Forms.Diagram;
using Syncfusion.Windows.Forms.Tools;
using Syncfusion.Windows.Forms;

namespace PaletteGroupbar
{
    public partial class Form1 : MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            paletteGroupBar1.VisualStyle = VisualStyle.Metro;
            paletteGroupBar1.GroupBarItemAdded += new GroupBarItemEventHandler(paletteGroupBar1_GroupBarItemAdded);
            paletteGroupBar1.NavigationPaneDropDownClick += new NavigationPaneDropDownClickEventHandler(paletteGroupBar1_NavigationPaneDropDownClick);
            //Load xml files
#if !NETCORE
            paletteGroupBar1.LoadPalette(@"..\..\..\..\..\..\common\Data\Diagram\xml\Circuit Shapes.xml");
            paletteGroupBar1.LoadPalette(@"..\..\..\..\..\..\common\Data\Diagram\xml\Basic Shapes.xml");
            paletteGroupBar3.LoadPalette(@"..\..\..\..\..\..\common\Data\Diagram\xml\FloorPlan Shapes.xml");
            paletteGroupBar3.LoadPalette(@"..\..\..\..\..\..\common\Data\Diagram\xml\Flowchart Symbols.xml");
#else
            paletteGroupBar1.LoadPalette(@"..\..\..\..\..\..\..\common\Data\Diagram\xml\Circuit Shapes.xml");
            paletteGroupBar1.LoadPalette(@"..\..\..\..\..\..\..\common\Data\Diagram\xml\Basic Shapes.xml");
            paletteGroupBar3.LoadPalette(@"..\..\..\..\..\..\..\common\Data\Diagram\xml\FloorPlan Shapes.xml");
            paletteGroupBar3.LoadPalette(@"..\..\..\..\..\..\..\common\Data\Diagram\xml\Flowchart Symbols.xml");
#endif

            GroupBarAppearance();
            GroupViewAppearance();
            //Initialize a PaletteGroupbar events
            paletteGroupBar1.GroupBarItemRemoved += new GroupBarItemEventHandler(paletteGroupBar1_GroupBarItemRemoved);
            paletteGroupBar1.GroupBarItemSelected += new EventHandler(paletteGroupBar1_GroupBarItemSelected);
            paletteGroupBar1.GroupBarItemSelectionChanging += new GroupBarItemSelectionChangingEventHandler(paletteGroupBar1_GroupBarItemSelectionChanging);
            paletteGroupBar1.NodeDoubleClick += new NodeEventHandler(paletteGroupBar1_NodeDoubleClick);
            paletteGroupBar1.NodeSelected += new NodeEventHandler(paletteGroupBar1_NodeSelected);
            paletteGroupBar1.StateChanged += new EventHandler(paletteGroupBar1_StateChanged);
            paletteGroupBar1.StateChanging += new CancelEventHandler(paletteGroupBar1_StateChanging);
            paletteGroupBar1.StyleChanged += new EventHandler(paletteGroupBar1_StyleChanged);
            cmbVisualStyle.SelectedItem = paletteGroupBar1.VisualStyle.ToString();
            cmbOffice2007Theme.SelectedIndex = 1;
            cmbTextAlignment.SelectedItem = paletteGroupBar3.TextAlign.ToString();
            cmbGBBorder.SelectedItem = paletteGroupBar3.BorderStyle.ToString();
        }

#region Event Handlers

        void paletteGroupBar1_NavigationPaneDropDownClick(object sender, NavigationPaneDropDownClickEventArgs args)
        {
            txtEvents.Text += "NavigationPaneDropDownClick event fired." + Environment.NewLine;
        }

        void paletteGroupBar1_GroupBarItemAdded(object sender, GroupBarItemEventArgs args)
        {
            txtEvents.Text += "GroupBarItemAdded event fired." + Environment.NewLine;
        }

        void paletteGroupBar1_StyleChanged(object sender, EventArgs e)
        {
            txtEvents.Text += "StyleChanged event fired." + Environment.NewLine;
        }

        void paletteGroupBar1_StateChanging(object sender, CancelEventArgs e)
        {
            txtEvents.Text += "StateChanging event fired." + Environment.NewLine;
        }

        void paletteGroupBar1_StateChanged(object sender, EventArgs e)
        {
            txtEvents.Text += "StateChanged event fired." + Environment.NewLine;
        }

        void paletteGroupBar1_NodeSelected(object sender, NodeEventArgs evtArgs)
        {
            txtEvents.Text += "NodeSelected event fired." + Environment.NewLine;
        }

        void paletteGroupBar1_NodeDoubleClick(object sender, NodeEventArgs evtArgs)
        {
            txtEvents.Text += "NodeDoubleClick event fired." + Environment.NewLine;
        }

        void paletteGroupBar1_GroupBarItemSelectionChanging(object sender, GroupBarItemSelectionChangingEventArgs args)
        {
            txtEvents.Text += "GroupBarItemSelectionChanging event fired." + Environment.NewLine;
        }

        void paletteGroupBar1_GroupBarItemSelected(object sender, EventArgs e)
        {
            txtEvents.Text += "GroupBarItemSelected event fired." + Environment.NewLine;
        }

        void paletteGroupBar1_GroupBarItemRemoved(object sender, GroupBarItemEventArgs args)
        {
            txtEvents.Text += "GroupBarItemRemoved event fired." + Environment.NewLine;
        }

#endregion

#region Button Click Events
        private void btnAddPalette_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = @"XML Files(*.xml)|*.xml";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                paletteGroupBar1.LoadPalette(openFileDialog.FileName);
                GroupBarAppearance();
            }
        }

        private void btnRemovePalette_Click(object sender, EventArgs e)
        {
            if (paletteGroupBar1.SelectedNode != null)
                paletteGroupBar1.CurrentSymbolPalette.RemoveChild(paletteGroupBar1.SelectedNode);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtEvents.Clear();
        }

#endregion

#region SelectedIndex Changed events

        private void cboVisualStyle_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbVisualStyle.SelectedIndex != -1 )
            {
                if (cmbVisualStyle.SelectedItem.ToString() == "Office2007")
                    cmbOffice2007Theme.Enabled = true;
                else
                    cmbOffice2007Theme.Enabled = false;
                paletteGroupBar1.VisualStyle = (VisualStyle)Enum.Parse(typeof(VisualStyle), cmbVisualStyle.SelectedItem.ToString());
            }
        }

        private void cboOffice2007Theme_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbOffice2007Theme.SelectedIndex !=-1)
                paletteGroupBar1.Office2007Theme = (Office2007Theme)Enum.Parse(typeof(Office2007Theme), cmbOffice2007Theme.SelectedItem.ToString());
        }

        private void cmbPopupResize_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.paletteGroupBar1.PopupResizeMode = (PopupResizeMode)Enum.Parse(typeof(PopupResizeMode), this.cmbPopupResize.SelectedItem.ToString());
        }

        private void cmbTextAlignment_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.paletteGroupBar3.TextAlign = (TextAlignment)Enum.Parse(typeof(TextAlignment), this.cmbTextAlignment.SelectedItem.ToString(), true);
        }

        private void cmbGBBorder_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.paletteGroupBar3.BorderStyle = (BorderStyle)Enum.Parse(typeof(BorderStyle), this.cmbGBBorder.SelectedItem.ToString(), true);
        }

#endregion

#region Checkbox CheckedChanged Events

        void cbFlowViewText_CheckedChanged(object sender, System.EventArgs e)
        {
            GroupViewAppearance1(cbFlowViewText.Name);
        }

        void cbButtonView_CheckedChanged(object sender, System.EventArgs e)
        {
            GroupViewAppearance1(cbButtonView.Name);
        }

        void cbThemesEnabled_CheckedChanged(object sender, System.EventArgs e)
        {
            this.paletteGroupBar1.ThemesEnabled = cbThemesEnabled.Checked;
        }

        void cbFlowView_CheckedChanged(object sender, System.EventArgs e)
        {
            GroupViewAppearance1(cbFlowView.Name);
        }

        void cbSmallImageView_CheckedChanged(object sender, System.EventArgs e)
        {
            GroupViewAppearance1(cbSmallImageView.Name);
        }

        void cbShowGripper_CheckedChanged(object sender, System.EventArgs e)
        {
            this.paletteGroupBar1.ShowPopupGripper = cbShowGripper.Checked;
        }

        void cbStackedMode_CheckedChanged(object sender, System.EventArgs e)
        {
            paletteGroupBar1.StackedMode = cbStackedMode.Checked;
            cbChevron.Enabled = cbStackedMode.Checked;
            cbCollapse.Enabled = cbStackedMode.Checked;
            cbAllowCollapse.Enabled = cbStackedMode.Checked;
        }

        void cbChevron_CheckedChanged(object sender, System.EventArgs e)
        {
            paletteGroupBar1.ShowChevron = cbChevron.Checked;
        }

        void cbAllowCollapse_CheckedChanged(object sender, System.EventArgs e)
        {
            this.paletteGroupBar1.AllowCollapse = cbAllowCollapse.Checked;
            this.panel23.Enabled = cbAllowCollapse.Checked;
            this.cbCollapse.Enabled = cbAllowCollapse.Checked;
        }

        void cbAutoClose_CheckedChanged(object sender, System.EventArgs e)
        {
            this.paletteGroupBar1.PopupAutoClose = this.cbAutoClose.Checked;
        }

        void cbCollapse_CheckedChanged(object sender, System.EventArgs e)
        {
            this.paletteGroupBar1.Collapsed = cbCollapse.Checked;
        }        

        private void cbDragNode_CheckedChanged(object sender, EventArgs e)
        {
            this.paletteGroupBar1.ShowDragNodeCue = cbDragNode.Checked;
        }

        private void cbAnimatedSelection_CheckedChanged(object sender, EventArgs e)
        {
            this.paletteGroupBar3.AnimatedSelection = this.cbAnimatedSelection.Checked;
        }

        private void cbIntegratedScrolling_CheckedChanged(object sender, EventArgs e)
        {
            this.paletteGroupBar3.IntegratedScrolling = this.cbIntegratedScrolling.Checked;
        }

        private void cbflatLook_CheckedChanged(object sender, EventArgs e)
        {
            this.paletteGroupBar3.FlatLook = this.cbflatLook.Checked;
        }

        private void cbDrawClientBorder_CheckedChanged(object sender, EventArgs e)
        {
            this.paletteGroupBar3.DrawClientBorder = this.cbDrawClientBorder.Checked;
            foreach (GroupBarItem gbItem in this.paletteGroupBar3.GroupBarItems)
            {
                gbItem.ClientBorderColors = new BorderColors(cpBack.SelectedColor, cpBack.SelectedColor, cpBack.SelectedColor, cpBack.SelectedColor);
            }
        }

        private void cbEditMode_CheckedChanged(object sender, EventArgs e)
        {
            foreach (GroupBarItem item in paletteGroupBar3.GroupBarItems)
            {
                PaletteGroupView groupView = item.Client as PaletteGroupView;
                groupView.EditMode = cbEditMode.Checked;
            }
        }

#endregion

        private void numericCollapsedWidth_ValueChanged(object sender, EventArgs e)
        {
            this.paletteGroupBar1.CollapsedWidth = (int)this.numericCollapsedWidth.Value;
        }

        private void cpBack_ColorSelected(object sender, EventArgs e)
        {
            this.paletteGroupBar3.BackColor = cpBack.SelectedColor;
            foreach (GroupBarItem gbItem in this.paletteGroupBar3.GroupBarItems)
            {
                gbItem.BackColor = cpBack.SelectedColor;
            }
        }

#region Class Helper Methods

        private void GroupBarAppearance()
        {
            this.paletteGroupBar1.BorderColor = System.Drawing.ColorTranslator.FromHtml("#119EDA");
            foreach (GroupBarItem item in paletteGroupBar1.GroupBarItems)
            {
                //palette view settings
                if (item.Client is PaletteGroupView)
                {
                    PaletteGroupView view = item.Client as PaletteGroupView;
                    view.Font = new Font("Segoe UI", 9, System.Drawing.FontStyle.Regular);
                    view.ForeColor = Color.Black;
                    view.FlowView = true;
                    view.ShowToolTips = true;
                    view.ShowFlowViewItemText = true;
                    view.SelectedItemColor = Color.FromArgb(255, 219, 118);
                    view.HighlightItemColor = Color.FromArgb(255, 227, 149);
                    view.SelectingItemColor = Color.FromArgb(255, 238, 184);
                    view.SelectedHighlightItemColor = Color.FromArgb(255, 218, 115);
                    view.FlowViewItemTextLength = (int)DpiAware.LogicalToDeviceUnits(80);
                    view.BackColor = Color.White;
                    view.TextWrap = true;
                    view.FlatLook = true;
                    view.BorderStyle = BorderStyle.FixedSingle;
                    
                }
            }
        }

        private void GroupViewAppearance()
        {
            paletteGroupBar3.VisualStyle = VisualStyle.Metro;
            foreach (GroupBarItem item in paletteGroupBar3.GroupBarItems)
            {
                PaletteGroupView groupView = item.Client as PaletteGroupView;
                groupView.SmallImageView = true;
                groupView.BackColor = Color.White;
                groupView.Font = new Font("Segoe UI", 9, System.Drawing.FontStyle.Regular);
                groupView.ForeColor = Color.Black;
            }
        }

        private void GroupViewAppearance1(string Name)
        {
            foreach (GroupBarItem item in paletteGroupBar1.GroupBarItems)
            {
                PaletteGroupView groupView = item.Client as PaletteGroupView;
                switch (Name)
                {
                    case "cbFlowView":
                        if (cbFlowView.Checked)
                        {
                            groupView.FlowView = true;
                            cbFlowViewText.Enabled = true;
                            numericUpDown1.Enabled = true;
                        }
                        else
                        {
                            groupView.FlowView = false;
                            cbFlowViewText.Enabled = false;
                            numericUpDown1.Enabled = false;
                        }
                        break;
                    case "cbButtonView":
                        if (cbButtonView.Checked)
                            groupView.ButtonView = true;
                        else
                            groupView.ButtonView = false;
                        break;
                    case "cbFlowViewText":
                        if (cbFlowViewText.Checked)
                            groupView.ShowFlowViewItemText = true;
                        else
                            groupView.ShowFlowViewItemText = false;
                        break;
                    case "cbSmallImageView":
                        if (cbSmallImageView.Checked)
                            groupView.SmallImageView = true;
                        else
                            groupView.SmallImageView = false;
                        break;
                    case "numericUpDown1":
                        groupView.FlowViewItemTextLength = Convert.ToInt32(numericUpDown1.Value);
                        break;
                }

            }
        }

#endregion

        private void cbFlowView_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            GroupViewAppearance1(cbFlowView.Name);
        }

        private void cbButtonView_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            GroupViewAppearance1(cbButtonView.Name);
        }

        private void cbFlowViewText_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            GroupViewAppearance1(cbFlowViewText.Name);
        }

        private void cbSmallImageView_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            GroupViewAppearance1(cbSmallImageView.Name);
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            GroupViewAppearance1(numericUpDown1.Name);
        }

        
    }
}
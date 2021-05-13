#region Copyright Syncfusion Inc. 2001 - 2014
// Copyright Syncfusion Inc. 2001 - 2014. All rights reserved.
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
using System.Drawing.Drawing2D;
using System.Text;
using System.IO;
using System.Windows.Forms;
using Syncfusion.Windows.Forms.Tools;
using Syncfusion.Windows.Forms;
using Syncfusion.Drawing;

namespace RibbonControlAdv_2005
{
    public partial class Form1 : RibbonForm
    {
        #region Constructor
        public Form1()
        {
            InitializeComponent();

            this.panel3.Padding = new Padding(50,20,50, 1);
            this.superAccelerator1.SetAccelerator(this.toolStripTabItem2, "R");
            this.gradientPanel1.Visible = false;
            this.richTextBox1.Visible = false;
            this.gridControl1.Visible = false;
            this.ribbonControlAdv1.SelectedTab = toolStripTabItem6;
            this.ribbonControlAdv1.ShowMinimizeButton = true;
            this.statusStripEx1.ContextMenuStrip = null;
            this.toolStripPanelItem24.BackColor = Color.FromArgb(205, 230, 247);
            this.toolStripButton35.BackColor = Color.FromArgb(205, 230, 247);
           
            // To host any .Net control into ToolStripEx, StatusStrip,
            // User can make use of ToolStripControlHost class
            // and host the control inside it and add the host
            // to item collection.
            this.treeViewAdv1.Style = TreeStyle.Metro;
            ToolStripControlHost host1 = new ToolStripControlHost(this.treeViewAdv1);
            this.toolStripEx25.Items.Add(host1);
            GridMetroColors theme = new GridMetroColors();
            theme.HeaderBottomBorderWeight = GridBottomBorderWeight.Thick;
            theme.HeaderBottomBorderColor = ColorTranslator.FromHtml("#217346");
            theme.HeaderColor.HoverColor = ColorTranslator.FromHtml("#9fd5b7");
            theme.HeaderTextColor.NormalTextColor = Color.Black;
            this.gridControl1.SetMetroStyle(theme);
            ToolStripControlHost host2 = new ToolStripControlHost(this.gridControl1);
            this.toolStripEx26.Items.Add(host2);
            ToolStripControlHost host3 = new ToolStripControlHost(this.panel1);
            this.panel1.Visible = false;
            this.toolStripSplitButton1.DropDown = new CustomDropdown(this.colorPickerUIAdv1);
            try
            {
                System.Drawing.Icon ico = new System.Drawing.Icon(GetIconFile(@"common\Images\Grid\Icon\sfgrid.ico"));
                this.Icon = ico;
            }
            catch { }


            foreach (ToolStripTabItem items in this.ribbonControlAdv1.Header.MainItems)
            {
                foreach (ToolStripEx item in items.Panel.Controls)
                {
                    item.LauncherClick += new EventHandler(item_LauncherClick);
                }
            }

            this.ribbonControlAdv1.QuickPanelVisible = true;
            this.HelpButton = false;
            this.ribbonControlAdv1.ShowRibbonDisplayOptionButton = false;
            this.WindowState = FormWindowState.Maximized;

            string path = Application.StartupPath.ToString() + @"..\..\..\Introduction.rtf";
            if (File.Exists(path))
                this.richTextBox2.LoadFile(path, RichTextBoxStreamType.RichText);

            foreach (ToolStripTabItem item in this.ribbonControlAdv1.Header.MainItems)
            {
                foreach (ToolStripEx toolstripex in item.Panel.Controls)
                {
                    toolstripex.AutoSize = true;
                    if (toolstripex.Text == "Labels")
                    {
                        toolstripex.Padding = new Padding(10, 0, 0, 0);
                    }
                }
            }

        }

        /// <summary>
        /// This event raises when the launcher is clicked
        /// </summary>
        /// <param name="sender">Instance of the Object</param>
        /// <param name="e">Contains data for the source</param>
        void item_LauncherClick(object sender, EventArgs e)
        {
            MessageBox.Show("Launcher is clicked", "Launcher");  
        }

        public class CustomDropdown : ToolStripDropDown
        {
            public CustomDropdown(ColorPickerUIAdv controls)
            {
                Items.Add(new ToolStripControlHost(controls));
            }
        }
        #endregion
        #region Form Icon
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
        #region ColorScheme

        private void ColorSchemeButton_Click(object sender, EventArgs e)
        {
            ToolStripButton toolStripButton = sender as ToolStripButton;
            if (toolStripButton == this.toolStripButton29)
            {
                if (toolStripButton.Checked)
                {
                  this.ribbonControlAdv1.OfficeColorScheme = ToolStripEx.ColorScheme.Blue;
                   this.ColorScheme = Syncfusion.Windows.Forms.Tools.RibbonForm.ColorSchemeType.Blue;
                    this.toolStripButton30.Checked = false;
                    this.toolStripButton31.Checked = false;
                }
            }
            if (toolStripButton == this.toolStripButton30)
            {
                if (toolStripButton.Checked)
                {
                  this.ribbonControlAdv1.OfficeColorScheme = ToolStripEx.ColorScheme.Silver;
                    this.ColorScheme = Syncfusion.Windows.Forms.Tools.RibbonForm.ColorSchemeType.Silver;
                    this.toolStripButton29.Checked = false;
                    this.toolStripButton31.Checked = false;
                
                }
            }
            if (toolStripButton == this.toolStripButton31)
            {
                if (toolStripButton.Checked)
                {
                  this.ribbonControlAdv1.OfficeColorScheme = ToolStripEx.ColorScheme.Black;
                    this.ColorScheme = Syncfusion.Windows.Forms.Tools.RibbonForm.ColorSchemeType.Black;
                    this.toolStripButton29.Checked = false;
                    this.toolStripButton30.Checked = false;
                
                }
            }
        }
        #endregion

        #region Launcher
        private void LauncherButton_Click(object sender, EventArgs e)
        {
            ToolStripButton toolStripButton = sender as ToolStripButton;
            if (toolStripButton == this.toolStripButton32)
            {
                if (toolStripButton.Checked)
                {
                  this.ribbonControlAdv1.LauncherStyle = LauncherStyle.Office12;
                    this.toolStripButton33.Checked = false;

                }
            }
            if (toolStripButton == this.toolStripButton33)
            {
                if (toolStripButton.Checked)
                {
                  this.ribbonControlAdv1.LauncherStyle = LauncherStyle.Office2007;
                    this.toolStripButton32.Checked = false;
            
                }
            }
          
        }

        private void toolStripButton34_Click(object sender, EventArgs e)
        {
            this.ribbonControlAdv1.ShowLauncher = toolStripButton34.Checked;
        }
#endregion

        #region QuickPanel

        private void toolStripButton37_Click(object sender, EventArgs e)
        {

            if (toolStripButton37.Checked)
            {
              this.ribbonControlAdv1.QuickPanelVisible = true;
            }
            else
            {
              this.ribbonControlAdv1.QuickPanelVisible = false;
            }

        }
        private void QuickPanelToolStripButton_Click(object sender, EventArgs e)
        {
            ToolStripButton toolStripButton = sender as ToolStripButton;
            if (toolStripButton == this.toolStripButton35)
            {
                if (toolStripButton.Checked)
                {
                  this.ribbonControlAdv1.ShowQuickPanelBelowRibbon = false;
                    this.toolStripButton36.Checked = false;

                }
            }
            if (toolStripButton == this.toolStripButton36)
            {
                if (toolStripButton.Checked)
                {
                  this.ribbonControlAdv1.ShowQuickPanelBelowRibbon = true;
                    this.toolStripButton35.Checked = false;

                }
            }

        }
        #endregion

        #region MenuButton
        private void toolStripButton38_CheckStateChanged(object sender, EventArgs e)
        {
            if (this.toolStripButton38.Checked)
            {
#if NETCORE
                Image img = Image.FromFile("../../../Data/fSEARCH_00.gif");
#else
                Image img = Image.FromFile("../../Data/fSEARCH_00.gif");
#endif
                this.ribbonControlAdv1.MenuButtonImage = img;
            }
            else
            {
#if NETCORE
                Image img = Image.FromFile("../../../Data/sync_icon.ico");
#else
                Image img = Image.FromFile("../../Data/sync_icon.ico");
#endif
                this.ribbonControlAdv1.MenuButtonImage = img;
            }
        }

        private void toolStripCheckBox5_CheckedChanged(object sender, EventArgs e)
        {
            this.ribbonControlAdv1.MenuButtonVisible = toolStripCheckBox5.Checked;
        }

       
#endregion

#region Gallery
        private void numericUpDownExt2_ValueChanged(object sender, EventArgs e)
        {
            this.toolStripGallery2.DropDownDimensions = new System.Drawing.Size(Convert.ToInt16(this.numericUpDownExt2.Value), 0);
        }

        private void numericUpDownExt1_ValueChanged(object sender, EventArgs e)
        {
            this.toolStripGallery2.Dimensions = new System.Drawing.Size(Convert.ToInt16(this.numericUpDownExt1.Value), 0);
        }

        private void ToolStripTabItem_Click(object sender, EventArgs e)
        {
            ToolStripTabItem toolStripTabItem = sender as ToolStripTabItem;
            if (toolStripTabItem == this.toolStripTabItem4)
            {
                this.gradientPanel1.Visible = true;
                this.richTextBox1.Visible = false;
            }
            else if (toolStripTabItem == this.toolStripTabItem9)
            {
                this.gradientPanel1.Visible = false;
                this.richTextBox1.Visible = true;
                this.richTextBox1.Dock = DockStyle.Fill;
               
			}
           else
           {
                this.gradientPanel1.Visible = false;
                this.richTextBox1.Visible = false;
                }

           
        }


#endregion
 
#region CaptionTextStyle
        private void TextStyleToolStripButton_Click(object sender, EventArgs e)
        {
            ToolStripButton toolStripButton = sender as ToolStripButton;
            if (toolStripButton == this.toolStripButton48)
            {
                this.toolStripButton49.Checked = false;
                this.toolStripButton50.Checked = false;
            }
            if (this.toolStripButton48.Checked)
            {
              this.ribbonControlAdv1.CaptionTextStyle = CaptionTextStyle.Plain;
            }
            if (toolStripButton == this.toolStripButton49)
            {
                this.toolStripButton48.Checked = false;
                this.toolStripButton50.Checked = false;
            }
            if (this.toolStripButton49.Checked)
            {
              this.ribbonControlAdv1.CaptionTextStyle = CaptionTextStyle.Etched;
            }
            if (toolStripButton == this.toolStripButton50)
            {
                this.toolStripButton48.Checked = false;
                this.toolStripButton49.Checked = false;
            }
            if (this.toolStripButton50.Checked)
            {
              this.ribbonControlAdv1.CaptionTextStyle = CaptionTextStyle.Shadow;
            }

        }
#endregion

#region TabGroupColor
        private void GroupColorToolStripButton_Click(object sender, EventArgs e)
        {
            ToolStripButton toolStripButton = sender as ToolStripButton;
            if (toolStripButton == this.toolStripButton51)
            {
                if (this.toolStripButton51.Checked)
                {
                    this.toolStripTabGroup1 = new ToolStripTabGroup();
                    this.toolStripTabGroup1.Visible = true;
                   this.toolStripTabGroup1.Name = "TabGroup";
                    this.toolStripTabGroup1.Color = Color.FromArgb(113, 215, 62);
                 this.ribbonControlAdv1.TabGroups.Add(this.toolStripTabGroup1);
                 this.ribbonControlAdv1.TabGroups.SetTabGroup(this.toolStripTabItem4, this.toolStripTabGroup1);
                 this.ribbonControlAdv1.TabGroups.SetTabGroup(this.toolStripTabItem2, this.toolStripTabGroup1);
                 this.toolStripButton52.Checked = false;
                }
            }
            if (toolStripButton == this.toolStripButton52)
            {
                if (this.toolStripButton52.Checked)
                {
                    this.toolStripTabGroup1 = new ToolStripTabGroup();
                    this.toolStripTabGroup1.Visible = true;
                    this.toolStripTabGroup1.Name = "TabGroup";
                    this.toolStripTabGroup1.Color = Color.FromArgb(247, 94, 217);
                    this.ribbonControlAdv1.TabGroups.Add(this.toolStripTabGroup1);
                    this.ribbonControlAdv1.TabGroups.SetTabGroup(this.toolStripTabItem4, this.toolStripTabGroup1);
                    this.ribbonControlAdv1.TabGroups.SetTabGroup(this.toolStripTabItem2, this.toolStripTabGroup1);
                    this.toolStripButton51.Checked = false;
                }
                    
            }
        }
#endregion
             
#region Form_Load
        private void Form1_Load(object sender, EventArgs e)
        {
            string path = Application.StartupPath.ToString() + @"..\..\..\Introduction.rtf";
            if (File.Exists(path))
                this.richTextBox1.LoadFile(path, RichTextBoxStreamType.RichText);

            this.ribbonControlAdv1.SuperAccelerator = this.superAccelerator1;
            this.superAccelerator1.SetAccelerator(this.backStageTab1, "N");
            this.superAccelerator1.SetAccelerator(this.backStageButton2, "O");
            this.superAccelerator1.SetAccelerator(this.backStageButton1, "S");
            this.superAccelerator1.SetAccelerator(this.backStageButton3, "C");

            this.trackBarItem1.TrackBarExControl.BackColor = Color.FromArgb(43, 87, 154);
            this.statusStripEx1.BackColor = Color.FromArgb(43, 87, 154);
            this.trackBarItem1.TrackBarExControl.ButtonColor = Color.White; 
        }
#endregion

#region Launcher_Click
        private void Launcher_Click(object sender, EventArgs e)
        {
            ToolStripEx toolStripEx = sender as ToolStripEx;
            if (toolStripEx.Text == "Launcher")
            {
                this.statusStripLabel1.Text = "Launcher ToolStripEx Launcher clicked";
            }
            else if (toolStripEx.Text == "3 Rows")
            {
                this.statusStripLabel1.Text = "Panel - 3 Rows, Launcher clicked";
            }
            else
            {
                this.statusStripLabel1.Text = toolStripEx.Text + " Launcher clicked";
            }
        }
#endregion
        
#region General Properties
        //To allow or disallow the ribbon from collapsing
        private void toolStripCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            this.ribbonControlAdv1.AllowCollapse = this.toolStripCheckBox1.Checked;
        }

        //To Show the customize Dialog
        private void toolStripButton24_Click_1(object sender, EventArgs e)
        {
            this.ribbonControlAdv1.ShowCustomizeDialog();
        }

        void dropDownBarItem2_BeforePopupItemPaint(object sender, Syncfusion.Windows.Forms.Tools.XPMenus.PopupItemPaintEventArgs drawItemInfo)
        {
            this.popupControlContainer1.Visible = true;
        }

#endregion
                
#region Custom Colors

        private void colorPickerUIAdv1_Picked(object sender, ColorPickerUIAdv.ColorPickedEventArgs args)
        {

            //set the custom color to the form and RibbonControlAdv
            this.ColorScheme = ColorSchemeType.Managed;
            this.ribbonControlAdv1.OfficeColorScheme = ToolStripEx.ColorScheme.Managed;
            Office12ColorTable.ApplyManagedColors(this, args.Color);
            
            //Set the GradientLabel color
           this.gradientLabel1.BackgroundColor =  new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, new System.Drawing.Color[] {
           Color.WhiteSmoke, args.Color, Color.WhiteSmoke});

            // Ensures that the PopupControlContainer is closed after the selection of a color.
            ColorPickerUIAdv cc = sender as ColorPickerUIAdv;
            Syncfusion.Windows.Forms.PopupControlContainer pcc = cc.Parent as Syncfusion.Windows.Forms.PopupControlContainer;
            if(pcc != null)
                pcc.HidePopup(Syncfusion.Windows.Forms.PopupCloseType.Done);
            BrushInfo bInfo = new BrushInfo(Syncfusion.Drawing.GradientStyle.PathEllipse, args.Color, Color.FromArgb(237, 240, 247));
            df.gradientLabel1.BackgroundColor = bInfo;
            df.gradientLabel2.BackgroundColor = bInfo;
            df.gradientLabel3.BackgroundColor = bInfo;
            df.gradientPanel1.BackgroundColor = bInfo;
            this.toolStripButton29.Checked = false;
            this.popupControlContainer1.Size = this.colorPickerUIAdv1.Size;
        }
       
#endregion

#region Retrieve Items Collection

        DialogForm df = new DialogForm();
        private void toolStripButton25_Click(object sender, EventArgs e)
        {
		//df = new DialogForm();
            switch (this.ColorScheme)
            {
                case ColorSchemeType.Blue:
                    df.ColorScheme = Office2007Theme.Blue;
                    df.UpdateFormControlColors(Office2007Theme.Blue);
                    break;
                case ColorSchemeType.Black:
                    df.ColorScheme = Office2007Theme.Black;
                    df.UpdateFormControlColors(Office2007Theme.Black);
                    break;
                case ColorSchemeType.Silver:
                    df.ColorScheme = Office2007Theme.Silver;
                    df.UpdateFormControlColors(Office2007Theme.Silver);
                    break;
            }

            df.TopMost = true;
            df.listBox1.Items.Clear();
            df.listBox2.Items.Clear();
            foreach (ToolStripItem tsItem in this.ribbonControlAdv1.Header.QuickItems)
            {
                df.listBox1.Items.Add(tsItem.Text.ToString());
            }
         
            foreach (ToolStripTabItem tstabItem in this.ribbonControlAdv1.Header.MainItems)
            {               
                df.listBox2.Items.Add(tstabItem.Text.ToString());
            }
            df.ShowDialog();
        }
#endregion

#region Option Controls
        private void toolStripCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            ToolStripCheckBox toolStripCheckBox = sender as ToolStripCheckBox;
            toolStripCheckBox.Text = toolStripCheckBox.CheckState.ToString();
       }

        private void toolStripRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            ToolStripRadioButton toolStripRadioButton = sender as ToolStripRadioButton;
            toolStripRadioButton.Text = toolStripRadioButton.CheckState.ToString();
        }
#endregion
 private void Form1_SizeChanged(object sender, EventArgs e)
        {
            if (this.WindowState != FormWindowState.Maximized)
                this.statusStripEx1.SizingGrip = true;
            else
                this.statusStripEx1.SizingGrip = false;
        }

       private void backStageButton1_Click(object sender, EventArgs e)
       {
          this.backStage1.Hide();
          OpenFileDialog openFileDialog1 = new OpenFileDialog();
          openFileDialog1.InitialDirectory = "c:\\";
          openFileDialog1.ShowDialog();
       }

       private void backStageButton2_Click(object sender, EventArgs e)
       {
           this.backStage1.Hide();
           SaveFileDialog saveFileDialog1 = new SaveFileDialog();
           saveFileDialog1.InitialDirectory = "c:\\";
           saveFileDialog1.ShowDialog();
       }

       private void backStageButton3_Click(object sender, EventArgs e)
       {
           this.Close();
       }
        

    }
}
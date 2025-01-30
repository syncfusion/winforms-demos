#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Drawing;
using System.Windows.Forms;
using Syncfusion.Windows.Forms.Tools;

namespace SimplifiedRibbonDemo
{
    public partial class Form1 : RibbonForm
    {
        /// <summary>
        /// Represents tne ToolStripTabGroup.
        /// </summary>
        Syncfusion.Windows.Forms.Tools.ToolStripTabGroup toolStripTabGroup1 = new Syncfusion.Windows.Forms.Tools.ToolStripTabGroup();

        /// <summary>
        /// Represents tne ImageListAdv.
        /// </summary>
        private ImageListAdv imageListAdv1;

        /// <summary>
        /// Represents tne ColorPickerUIAdv.
        /// </summary>
        private ColorPickerUIAdv colorpicker1;

        /// <summary>
        /// Represents tne ColorPickerUIAdv.
        /// </summary>
        private ColorPickerUIAdv colorpicker2;

        /// <summary>
        /// Creates and initializes the new instance of Form1.
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            foreach (ToolStripTabItem items in this.ribbonControlAdv1.Header.MainItems)
            {
                foreach (ToolStripEx item in items.Panel.Controls)
                {
                    item.LauncherClick += new EventHandler(item_LauncherClick);
                }
            }
            PopulateColorTable();
            PopulateTabGroup();
            SetMediumIcons();
            SetBackStageImages();
            SetDropDownItems();
            int topMargin = (int)Syncfusion.Windows.Forms.DpiAware.LogicalToDeviceUnits(18);
            this.toolStripRadioButton1.Margin = new System.Windows.Forms.Padding(2, topMargin, 2, 2);
            this.toolStripCheckBox3.Checked = true;
            this.toolStripCheckBox4.Checked = this.ShowApplicationIcon;

            this.ribbonControlAdv1.SetDisplayMode(this.toolStripSplitButtonEx4, RibbonItemDisplayMode.Normal);
            this.ribbonControlAdv1.EnableSimplifiedLayoutMode = true;
            this.ribbonControlAdv1.LayoutMode = RibbonLayoutMode.Simplified;
        }

        /// <summary>
        /// Method used to set the BackStageImages.
        /// </summary>
        private void SetBackStageImages()
        {
#if NETCORE
            this.button5.BackgroundImage = Image.FromFile("..//..//..//Images/BackStage Images/Open.png");
            this.button4.BackgroundImage = Image.FromFile("..//..//..//Images/BackStage Images/otheruser.png");
            this.button3.BackgroundImage = Image.FromFile("..//..//..//Images/BackStage Images/importandexport.png");
            this.button2.BackgroundImage = Image.FromFile("..//..//..//Images/BackStage Images/openoutlookdatafile.png");
            this.button1.BackgroundImage = Image.FromFile("..//..//..//Images/BackStage Images/opencalender.png");
            this.backStageTab1.BackgroundImage = Image.FromFile("..//..//..//Images/BackStage Images/info1.png");
            this.backStageTab5.BackgroundImage = Image.FromFile("..//..//..//Images/BackStage Images/print.png");
            this.backStageTab6.BackgroundImage = Image.FromFile("..//..//..//Images/BackStage Images/officeaccount.png");
#else
            this.button5.BackgroundImage = Image.FromFile("..//..//Images/BackStage Images/Open.png");
            this.button4.BackgroundImage = Image.FromFile("..//..//Images/BackStage Images/otheruser.png");
            this.button3.BackgroundImage = Image.FromFile("..//..//Images/BackStage Images/importandexport.png");
            this.button2.BackgroundImage = Image.FromFile("..//..//Images/BackStage Images/openoutlookdatafile.png");
            this.button1.BackgroundImage = Image.FromFile("..//..//Images/BackStage Images/opencalender.png");
            this.backStageTab1.BackgroundImage = Image.FromFile("..//..//Images/BackStage Images/info1.png");
            this.backStageTab5.BackgroundImage = Image.FromFile("..//..//Images/BackStage Images/print.png");
            this.backStageTab6.BackgroundImage = Image.FromFile("..//..//Images/BackStage Images/officeaccount.png");
#endif
        }

        /// <summary>
        /// Method used to set the MediumIcons.
        /// </summary>
        private void SetMediumIcons()
        {
            this.imageListAdv1 = new Syncfusion.Windows.Forms.Tools.ImageListAdv(this.components);
#if NETCORE
            this.imageListAdv1.Images.Add(Image.FromFile("..//..//..//Images/Medium Icons/Team mail20.png"));
            this.imageListAdv1.Images.Add(Image.FromFile("..//..//..//Images/Medium Icons/Paste20.png"));
            this.imageListAdv1.Images.Add(Image.FromFile("..//..//..//Images/Medium Icons/Cut_20.png"));
            this.imageListAdv1.Images.Add(Image.FromFile("..//..//..//Images/Medium Icons/Copy_20.png"));
            this.imageListAdv1.Images.Add(Image.FromFile("..//..//..//Images/Medium Icons/FormatPainter20.png"));
            this.imageListAdv1.Images.Add(Image.FromFile("..//..//..//Images/Medium Icons/Font Increase_20.png"));
            this.imageListAdv1.Images.Add(Image.FromFile("..//..//..//Images/Medium Icons/Font Decrease20.png"));
            this.imageListAdv1.Images.Add(Image.FromFile("..//..//..//Images/Medium Icons/Bullets_20.png"));
            this.imageListAdv1.Images.Add(Image.FromFile("..//..//..//Images/Medium Icons/Numbering_20.png"));
            this.imageListAdv1.Images.Add(Image.FromFile("..//..//..//Images/Medium Icons/Shading_20.png"));
            this.imageListAdv1.Images.Add(Image.FromFile("..//..//..//Images/Medium Icons/Bold_20.png"));
            this.imageListAdv1.Images.Add(Image.FromFile("..//..//..//Images/Medium Icons/Italic_20.png"));
            this.imageListAdv1.Images.Add(Image.FromFile("..//..//..//Images/Medium Icons/Underline_20.png"));
            this.imageListAdv1.Images.Add(Image.FromFile("..//..//..//Images/Medium Icons/Text High light20.png"));
            this.imageListAdv1.Images.Add(Image.FromFile("..//..//..//Images/Medium Icons/Font colors20.png"));
            this.imageListAdv1.Images.Add(Image.FromFile("..//..//..//Images/Medium Icons/AlignLeft_20.png"));
            this.imageListAdv1.Images.Add(Image.FromFile("..//..//..//Images/Medium Icons/Align Center_20.png"));
            this.imageListAdv1.Images.Add(Image.FromFile("..//..//..//Images/Medium Icons/Align Right_20.png"));
            this.imageListAdv1.Images.Add(Image.FromFile("..//..//..//Images/Medium Icons/DecreaseIndent20.png"));
            this.imageListAdv1.Images.Add(Image.FromFile("..//..//..//Images/Medium Icons/IncreaseIndent20.png"));
            this.imageListAdv1.Images.Add(Image.FromFile("..//..//..//Images/Medium Icons/Close20.png"));
#else
            this.imageListAdv1.Images.Add(Image.FromFile("..//..//Images/Medium Icons/Team mail20.png"));
            this.imageListAdv1.Images.Add(Image.FromFile("..//..//Images/Medium Icons/Paste20.png"));
            this.imageListAdv1.Images.Add(Image.FromFile("..//..//Images/Medium Icons/Cut_20.png"));
            this.imageListAdv1.Images.Add(Image.FromFile("..//..//Images/Medium Icons/Copy_20.png"));
            this.imageListAdv1.Images.Add(Image.FromFile("..//..//Images/Medium Icons/FormatPainter20.png"));
            this.imageListAdv1.Images.Add(Image.FromFile("..//..//Images/Medium Icons/Font Increase_20.png"));
            this.imageListAdv1.Images.Add(Image.FromFile("..//..//Images/Medium Icons/Font Decrease20.png"));
            this.imageListAdv1.Images.Add(Image.FromFile("..//..//Images/Medium Icons/Bullets_20.png"));
            this.imageListAdv1.Images.Add(Image.FromFile("..//..//Images/Medium Icons/Numbering_20.png"));
            this.imageListAdv1.Images.Add(Image.FromFile("..//..//Images/Medium Icons/Shading_20.png"));
            this.imageListAdv1.Images.Add(Image.FromFile("..//..//Images/Medium Icons/Bold_20.png"));
            this.imageListAdv1.Images.Add(Image.FromFile("..//..//Images/Medium Icons/Italic_20.png"));
            this.imageListAdv1.Images.Add(Image.FromFile("..//..//Images/Medium Icons/Underline_20.png"));
            this.imageListAdv1.Images.Add(Image.FromFile("..//..//Images/Medium Icons/Text High light20.png"));
            this.imageListAdv1.Images.Add(Image.FromFile("..//..//Images/Medium Icons/Font colors20.png"));
            this.imageListAdv1.Images.Add(Image.FromFile("..//..//Images/Medium Icons/AlignLeft_20.png"));
            this.imageListAdv1.Images.Add(Image.FromFile("..//..//Images/Medium Icons/Align Center_20.png"));
            this.imageListAdv1.Images.Add(Image.FromFile("..//..//Images/Medium Icons/Align Right_20.png"));
            this.imageListAdv1.Images.Add(Image.FromFile("..//..//Images/Medium Icons/DecreaseIndent20.png"));
            this.imageListAdv1.Images.Add(Image.FromFile("..//..//Images/Medium Icons/IncreaseIndent20.png"));
            this.imageListAdv1.Images.Add(Image.FromFile("..//..//Images/Medium Icons/Close20.png"));
#endif

            ToolStripExImageProvider toolStripExImageProvider1 = new ToolStripExImageProvider(toolStripEx1);
            toolStripExImageProvider1.MediumImageList = imageListAdv1;
            toolStripExImageProvider1.SetMediumItemImage(this.toolStripDropDownButton3, 1);
            toolStripExImageProvider1.SetMediumItemImage(this.toolStripButton2, 2);
            toolStripExImageProvider1.SetMediumItemImage(this.toolStripButton3, 3);
            toolStripExImageProvider1.SetMediumItemImage(this.toolStripButton4, 4);

            ToolStripExImageProvider toolStripExImageProvider2 = new ToolStripExImageProvider(toolStripEx5);
            toolStripExImageProvider2.MediumImageList = imageListAdv1;
            toolStripExImageProvider2.SetMediumItemImage(this.toolStripButton16, 5);
            toolStripExImageProvider2.SetMediumItemImage(this.toolStripButton11, 6);
            toolStripExImageProvider2.SetMediumItemImage(this.toolStripSplitButtonEx2, 7);
            toolStripExImageProvider2.SetMediumItemImage(this.toolStripSplitButtonEx4, 8);
            toolStripExImageProvider2.SetMediumItemImage(this.toolStripButton1, 9);
            toolStripExImageProvider2.SetMediumItemImage(this.toolStripButton5, 10);
            toolStripExImageProvider2.SetMediumItemImage(this.toolStripButton6, 11);
            toolStripExImageProvider2.SetMediumItemImage(this.toolStripButton9, 12);
            toolStripExImageProvider2.SetMediumItemImage(this.toolStripSplitButtonEx1, 13);
            toolStripExImageProvider2.SetMediumItemImage(this.toolStripSplitButtonEx3, 14);
            toolStripExImageProvider2.SetMediumItemImage(this.toolStripButton10, 15);
            toolStripExImageProvider2.SetMediumItemImage(this.toolStripButton17, 16);
            toolStripExImageProvider2.SetMediumItemImage(this.toolStripButton18, 17);
            toolStripExImageProvider2.SetMediumItemImage(this.toolStripButton19, 18);
            toolStripExImageProvider2.SetMediumItemImage(this.toolStripButton20, 19);
        }

        /// <summary>
        /// Method used to set the DropDownItems.
        /// </summary>
        private void SetDropDownItems()
        {
            foreach (FontFamily oneFontFamily in FontFamily.Families)
            {
                this.toolStripComboBox1.Items.Add(oneFontFamily.Name);
            }

            this.colorpicker1 = new ColorPickerUIAdv();
            this.toolStripSplitButtonEx1.DropDown = new CustomDropDown(this.colorpicker1);
            this.colorpicker2 = new ColorPickerUIAdv();
            this.toolStripSplitButtonEx3.DropDown = new CustomDropDown(this.colorpicker2);
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

        /// <summary>
        /// This event raises when the Exit BackStageButton is clicked
        /// </summary>
        /// <param name="sender">Instance of the Object</param>
        /// <param name="e">Contains data for the source</param>
        private void backStageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// This event raises when the Form is Loaded.
        /// </summary>
        /// <param name="sender">Instance of the Object.</param>
        /// <param name="e">Contains data for the source.</param>
        private void Form1_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.Padding = new Padding(1);
        }

        #region Avoid flickering
        /// <summary>
        /// Overrides the CreateParams property.
        /// </summary>
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;   // WS_EX_COMPOSITED
                return cp;
            }
        }
        #endregion

        #region Color table
        /// <summary>
        /// Represents the Office2016ColorTable.
        /// </summary>
        Syncfusion.Windows.Forms.Tools.Office2016ColorTable office2016ColorTable1 = new Syncfusion.Windows.Forms.Tools.Office2016ColorTable();

        /// <summary>
        /// Represents the Office2016ColorTable.
        /// </summary>
        Syncfusion.Windows.Forms.Tools.Office2016ColorTable office2016ColorTable2 = new Syncfusion.Windows.Forms.Tools.Office2016ColorTable();

        /// <summary>
        /// Represents the Office2016ColorTable.
        /// </summary>
        Syncfusion.Windows.Forms.Tools.Office2016ColorTable office2016ColorTable3 = new Syncfusion.Windows.Forms.Tools.Office2016ColorTable();

        /// <summary>
        /// Method used to set the values of ColorTable.
        /// </summary>
        private void PopulateColorTable()
        {
            office2016ColorTable1.CheckedTabForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(25)))), ((int)(((byte)(170)))));
            office2016ColorTable1.HeaderColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(25)))), ((int)(((byte)(170)))));
            office2016ColorTable1.HoverCollapsedDropDownButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            office2016ColorTable1.QATDropDownForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            office2016ColorTable1.QuickDropDownPressedcolor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(18)))), ((int)(((byte)(118)))));
            office2016ColorTable1.QuickDropDownSelectedcolor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(29)))), ((int)(((byte)(197)))));
            office2016ColorTable1.SelectedTabColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(29)))), ((int)(((byte)(197)))));
            office2016ColorTable1.SplitButtonBackgroundPressed = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(18)))), ((int)(((byte)(118)))));
            office2016ColorTable1.SplitButtonBackgroundSelected = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(29)))), ((int)(((byte)(197)))));
            office2016ColorTable1.SystemButtonBackground=office2016ColorTable1.TabGroupBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(29)))), ((int)(((byte)(197)))));
            office2016ColorTable1.TabBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(25)))), ((int)(((byte)(170)))));
            office2016ColorTable2.CheckedTabForeColor = office2016ColorTable2.TabGroupForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(115)))), ((int)(((byte)(70)))));
            office2016ColorTable2.HeaderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(115)))), ((int)(((byte)(70)))));
            office2016ColorTable2.HoverCollapsedDropDownButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            office2016ColorTable2.QATDropDownForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            office2016ColorTable2.QuickDropDownSelectedcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(158)))), ((int)(((byte)(97)))));
            office2016ColorTable2.SelectedTabColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(158)))), ((int)(((byte)(97)))));
            office2016ColorTable2.SystemButtonBackground= office2016ColorTable2.TabGroupBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(158)))), ((int)(((byte)(97)))));
            office2016ColorTable2.TabBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(115)))), ((int)(((byte)(70)))));
            office2016ColorTable3.HoverCollapsedDropDownButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            office2016ColorTable3.QATDropDownForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));

        }

        /// <summary>
        /// This event raises when the ToolStripComboBoxEx SelectedIndex is Changed.
        /// </summary>
        /// <param name="sender">Instance of the Object.</param>
        /// <param name="e">Contains data for the source.</param>
        private void toolStripComboBoxEx1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.ribbonControlAdv1.Office2016ColorTable.Clear();
            if(toolStripComboBoxEx1.SelectedIndex==0)
            {
                this.ribbonControlAdv1.Office2016ColorTable.Add(office2016ColorTable3);
                this.ribbonControlAdv1.MenuColor = Color.FromArgb(0, 114, 198);
            }
            else if (toolStripComboBoxEx1.SelectedIndex == 1)
            {
                this.ribbonControlAdv1.Office2016ColorTable.Add(office2016ColorTable1);
                this.ribbonControlAdv1.MenuColor = Color.FromArgb(119, 25, 169);
            }
            else if (toolStripComboBoxEx1.SelectedIndex == 2)
            {
                this.ribbonControlAdv1.Office2016ColorTable.Add(office2016ColorTable2);
                this.ribbonControlAdv1.MenuColor = Color.FromArgb(33, 115, 70);
            }
        }


        #endregion

        /// <summary>
        /// This event raises when the ToolStripCheckBox Checked property is Changed.
        /// </summary>
        /// <param name="sender">Instance of the Object.</param>
        /// <param name="e">Contains data for the source.</param>
        private void toolStripCheckBox4_CheckedChanged(object sender, EventArgs e)
        {
            this.ShowApplicationIcon = this.toolStripCheckBox4.Checked;
        }

        /// <summary>
        /// Method used to set the values of ToolStripTabGroup.
        /// </summary>
        private void PopulateTabGroup()
        {
            toolStripTabGroup1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(70)))), ((int)(((byte)(122)))));
            toolStripTabGroup1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            toolStripTabGroup1.Name = "Correction";
            toolStripTabGroup1.Visible = true;
            this.ribbonControlAdv1.TabGroups.Add(toolStripTabGroup1);
            this.ribbonControlAdv1.TabGroups.SetTabGroup(toolStripTabItem3, toolStripTabGroup1);
        }

        /// <summary>
        /// This event raises when the ToolStripCheckBox Checked property is Changed.
        /// </summary>
        /// <param name="sender">Instance of the Object.</param>
        /// <param name="e">Contains data for the source.</param>
        private void toolStripCheckBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (toolStripCheckBox3.Checked)
            {
                this.ribbonControlAdv1.TabGroups.SetTabGroup(this.toolStripTabItem3, this.toolStripTabGroup1);
            }
            else
            {
                this.ribbonControlAdv1.TabGroups.SetTabGroup(this.toolStripTabItem3, null);
            }
        }

        /// <summary>
        /// Method used to set the CustomSystemButtons.
        /// </summary>
        private void CustomSystemButtons()
        {
            //Instance to create custom button
            RibbonTitleButton button1 = new RibbonTitleButton();
            // Sets the image for the Custom button
#if NETCORE
            button1.Image = Image.FromFile("..//..//..//Images/Minimize-WF.png");
#else
            button1.Image = Image.FromFile("..//..//Images/Minimize-WF.png");
#endif
            // Sets the tooltip text for the custom button 
            button1.ToolTipText = "Minimize form";
            // Sets the Hover backcolor for the custom button
            // Assigns the button to the RibbonControlAdv.
            this.ribbonControlAdv1.MinimizeButton = button1;

            //Instance to create custom button
            RibbonTitleButton button2 = new RibbonTitleButton();
            // Sets the image for the Custom button
#if NETCORE
            button2.Image = Image.FromFile("..//..//..//Images/Maximize3-WF.png");
#else
             button2.Image = Image.FromFile("..//..//Images/Maximize3-WF.png");
#endif
            // Sets the tooltip text for the custom button 
            button2.ToolTipText = "Max form";
            // Sets the Hover backcolor for the custom button
            // Assigns the button to the RibbonControlAdv.
            this.ribbonControlAdv1.MaximizeButton = button2;

            //Instance to create custom button
            RibbonTitleButton button3 = new RibbonTitleButton();
            // Sets the image for the Custom button
#if NETCORE
            button3.Image = Image.FromFile("..//..//..//Images/Restore-01.png");
#else
             button3.Image = Image.FromFile("..//..//Images/Restore-01.png");
#endif
            // Sets the tooltip text for the custom button 
            button3.ToolTipText = "Restore form";
            // Sets the Hover backcolor for the custom button
            // Assigns the button to the RibbonControlAdv.
            this.ribbonControlAdv1.RestoreButton = button3;

            //Instance to create custom button
            RibbonTitleButton button4 = new RibbonTitleButton();
            // Sets the image for the Custom button
#if NETCORE
            button4.Image = Image.FromFile("..//..//..//Images/Close.png");
#else
             button4.Image = Image.FromFile("..//..//Images/Close.png");
#endif
            // Sets the tooltip text for the custom button 
            button4.ToolTipText = "Close form";
            // Sets the Hover backcolor for the custom button
            button4.HoverBackColor = Color.Red;
            // Assigns the button to the RibbonControlAdv.
            this.ribbonControlAdv1.CloseButton = button4;
        }

        /// <summary>
        /// This event raises when the ToolStripRadioButton Checked property is Changed.
        /// </summary>
        /// <param name="sender">Instance of the Object.</param>
        /// <param name="e">Contains data for the source.</param>
        private void toolStripRadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (toolStripRadioButton1.Checked)
            {
                CustomSystemButtons();
            }
            else
            {
                this.ribbonControlAdv1.MinimizeButton = this.ribbonControlAdv1.MaximizeButton = this.ribbonControlAdv1.CloseButton = this.ribbonControlAdv1.RestoreButton = null;
            }
        }
    }

    #region Custom DropDown
    /// <summary>
    ///  Custom dropdown for DropDownbutton
    /// </summary>
    public class CustomDropDown : ToolStripDropDown
    {
        public CustomDropDown(ColorPickerUIAdv colorpicker)
        {
            this.Height = colorpicker.Height;
            this.Items.Add(new ToolStripControlHost(colorpicker));
        }
    }
    #endregion
}

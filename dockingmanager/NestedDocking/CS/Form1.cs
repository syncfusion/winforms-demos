#region Copyright Syncfusion Inc. 2001 - 2019
// Copyright Syncfusion Inc. 2001 - 2019. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion

using Syncfusion.Windows.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NestedDocking
{
    public partial class Form1 : MetroForm
    {
        public Form1()
        {
            InitializeComponent();
            this.tabControlAdv1.ActiveTabColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(191)))));
            this.tabControlAdv1.ActiveTabFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))); 

            this.CaptionBarColor = ColorTranslator.FromHtml("#d6dbe9");
            this.MetroColor = ColorTranslator.FromHtml("#d6dbe9");
            this.dockingManager1.VisualStyle = VisualStyle.VS2010;
            this.CaptionAlign = HorizontalAlignment.Left;
            this.dockingManager1.ActiveCaptionBackground = new Syncfusion.Drawing.BrushInfo(ColorTranslator.FromHtml("#fff29d"));
            this.dockingManager1.DragProviderStyle = Syncfusion.Windows.Forms.Tools.DragProviderStyle.VS2010;
#if NETCORE
            this.richTextBox2.LoadFile("..//..//..//VisualStyles.rtf");
            this.richTextBox3.LoadFile("..//..//..//DockingClientPanel.rtf");
            this.richTextBox4.LoadFile("..//..//..//MDI.rtf");
#else
            this.richTextBox2.LoadFile("..//..//VisualStyles.rtf");
            this.richTextBox3.LoadFile("..//..//DockingClientPanel.rtf");
            this.richTextBox4.LoadFile("..//..//MDI.rtf");
#endif
            this.richTextBox2.ReadOnly = true;
            this.richTextBox3.ReadOnly = true;
            this.richTextBox4.ReadOnly = true;
            this.WindowState = FormWindowState.Maximized;
            this.treeNavigator1.ParentPanel.AutoScroll = false;
            this.treeNavigator2.ParentPanel.AutoScroll = false;
            this.treeNavigator3.ParentPanel.AutoScroll = false;
            this.dockingManager1.NewDockStateEndLoad += new EventHandler(dockingManager1_NewDockStateEndLoad);
            this.tabControlAdv1.ActiveTabColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(191)))));
            this.tabControlAdv1.ActiveTabFont = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControlAdv1.BeforeTouchSize = new System.Drawing.Size(254, 177);
            this.tabControlAdv1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tabControlAdv1.CloseButtonForeColor = System.Drawing.Color.Black;
            this.tabControlAdv1.CloseButtonHoverForeColor = System.Drawing.Color.Black;
            this.tabControlAdv1.CloseButtonPressedForeColor = System.Drawing.Color.Black;
            this.tabControlAdv1.Controls.Add(this.tabPageAdv1);
            this.tabControlAdv1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlAdv1.FocusOnTabClick = false;
            this.tabControlAdv1.HotTrack = true;
            this.tabControlAdv1.InactiveTabColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(78)))), ((int)(((byte)(111)))));
            this.tabControlAdv1.ItemSize = new System.Drawing.Size(77, 26);            
            this.tabControlAdv1.Name = "tabControlAdv1";
            this.tabControlAdv1.ShowCloseButtonForActiveTabOnly = true;
            this.tabControlAdv1.ShowCloseButtonHighLightBackColor = true;
            this.tabControlAdv1.ItemSize = new Size(this.tabControlAdv1.ItemSize.Width, 25);
            this.tabControlAdv1.ShowTabCloseButton = true;            
            this.tabControlAdv1.TabIndex = 0;
            this.tabControlAdv1.TabStyle = typeof(Syncfusion.Windows.Forms.Tools.TabRendererMetro);
            this.tabControlAdv1.TabPanelBackColor = ColorTranslator.FromHtml("#293955");
            this.tabControlAdv1.ActiveTabColor = ColorTranslator.FromHtml("#fff29d");
#if NETCORE
            this.richTextBox1.LoadFile("..//..//..//RichTextBox-files//DockingManager.rtf");
#else
            this.richTextBox1.LoadFile("..//..//RichTextBox-files//DockingManager.rtf");
#endif
            this.richTextBox1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BorderThickness = 8;
            this.BorderColor = ColorTranslator.FromHtml("#d6dbe9"); 
        }

        void dockingManager1_NewDockStateEndLoad(object sender, EventArgs e)
        {
            this.dockingManager1.SetDockLabel(this.panel1, "Lorem");
            this.dockingManager1.SetDockLabel(this.panel2, "Ultricies");
            this.dockingManager1.SetDockLabel(this.panel3, "Magna");
            this.dockingManager1.SetDockLabel(this.panel4, "Quisque");
            this.dockingManager1.SetDockLabel(this.panel5, "Dolor");
        }

    }
}

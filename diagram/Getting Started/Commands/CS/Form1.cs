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
using Syncfusion.Windows.Forms;

namespace Commands
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Application.Idle += new EventHandler(Application_Idle);
        }

        void Application_Idle(object sender, EventArgs e)
        {
            cutToolStripButton.Enabled = diagram1.CanCut;
            copyToolStripButton.Enabled = diagram1.CanCopy;
            alignLeftToolStripButton.Enabled = diagram1.View.SelectionList.Count >= 2;
            alignMiddleToolStripButton.Enabled = alignLeftToolStripButton.Enabled;
            alignRightToolStripButton.Enabled = alignLeftToolStripButton.Enabled;
            alignTopToolStripButton.Enabled = alignLeftToolStripButton.Enabled;
            alignBottomToolStripButton.Enabled = alignLeftToolStripButton.Enabled;
            alignCenterToolStripButton.Enabled = alignLeftToolStripButton.Enabled;
            flipHorizontalToolStripButton.Enabled = diagram1.View.SelectionList.Count > 0;
            flipVerticalToolStripButton.Enabled = flipHorizontalToolStripButton.Enabled;
            rotateLeftToolStripButton.Enabled = flipHorizontalToolStripButton.Enabled;
            rotateRightToolStripButton.Enabled = flipHorizontalToolStripButton.Enabled;
            spaceAcrossToolStripButton.Enabled = alignLeftToolStripButton.Enabled;
            spaceDownToolStripButton.Enabled = alignLeftToolStripButton.Enabled;
            sameWidthToolStripButton.Enabled = alignLeftToolStripButton.Enabled;
            sameHeightToolStripButton.Enabled = alignLeftToolStripButton.Enabled;
            sameSizeToolStripButton.Enabled = alignLeftToolStripButton.Enabled;

        }

         

        private void Form1_Load(object sender, EventArgs e)
        {
#if !NETCORE
            this.diagram1.LoadXml(@"..\..\..\..\..\..\common\Data\Diagram\xml\Commands.xml");
#else
            this.diagram1.LoadXml(@"..\..\..\..\..\..\..\common\Data\Diagram\xml\Commands.xml");
#endif
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            switch (e.ClickedItem.Text)
            {
                case "Cut":
                    diagram1.Controller.Cut();
                    pasteToolStripButton.Enabled = true;
                    break;
                case "Copy":
                    diagram1.Controller.Copy();
                    pasteToolStripButton.Enabled = true;
                    break;
                case "Paste":
                    diagram1.Controller.Paste();
                    pasteToolStripButton.Enabled = false;
                    break;
                case "Align\nLeft":
                    diagram1.AlignLeft();
                    break;
                case "Align\nCenter":
                    diagram1.AlignCenter();
                    break;
                case "Align\nRight":
                    diagram1.AlignRight();
                    break;
                case "Align\nTop":
                    diagram1.AlignTop();
                    break;
                case "Align\nMiddle":
                    diagram1.AlignMiddle();
                    break;
                case "Align\nBottom":
                    diagram1.AlignBottom();
                    break;
                case "Rotate\nLeft":
                    diagram1.Rotate(90);
                    break;
                case "Rotate\nRight":
                    diagram1.Rotate(-90);
                    break;
                case "Flip\nVertical":
                    diagram1.FlipVertical();
                    break;
                case "Flip\nHorizontal":
                    diagram1.FlipHorizontal();
                    break;
                case "Space\nAcross":
                    diagram1.SpaceAcross();
                    break;
                case "Space\nDown":
                    diagram1.SpaceDown();
                    break;
                case "Same\nWidth":
                    diagram1.SameWidth();
                    break;
                case "Same\nHeight":
                    diagram1.SameHeight();
                    break;
                case "Same\nSize":
                    diagram1.SameSize();
                    break;
                
            }
        }
    }
}
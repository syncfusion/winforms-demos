#region Copyright Syncfusion Inc. 2001 - 2012
// Copyright Syncfusion Inc. 2001 - 2012. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using Syncfusion.Windows.Forms.Diagram;
using System.Windows.Forms;

namespace SimpleDrillDown
{
    #region HomePage
    class HomeNode : Group
    {
        public Syncfusion.Windows.Forms.Diagram.Rectangle homerect = null;
        public Syncfusion.Windows.Forms.Diagram.Model mod1;
        public Syncfusion.Windows.Forms.Diagram.Model mod2;
        public Syncfusion.Windows.Forms.Diagram.Controls.Diagram dig;
        BitmapNode bmpnode = null;
        ToolTip tooltips = new ToolTip();
        public HomeNode()
        {
            homerect = new Syncfusion.Windows.Forms.Diagram.Rectangle(30, 30, 80, 30);
            homerect.FillStyle.Color = System.Drawing.Color.RoyalBlue;
            homerect.FillStyle.ForeColor = System.Drawing.Color.White;
            this.AppendChild(homerect);
        }

        public HomeNode(Syncfusion.Windows.Forms.Diagram.Controls.Diagram diagram, Syncfusion.Windows.Forms.Diagram.Model model1, Syncfusion.Windows.Forms.Diagram.Model model2)
        {
#if !NETCORE
            bmpnode = new BitmapNode(new Bitmap(@"..\..\..\..\..\..\common\Images\Diagram\Drill Down images\house_48_hot(1).png"));
#else
            bmpnode = new BitmapNode(new Bitmap(@"..\..\..\..\..\..\..\common\Images\Diagram\Drill Down images\house_48_hot(1).png"));
#endif
            bmpnode.Name = "Grand Mother";
            bmpnode.PinPoint = new Point(30, 30);
            bmpnode.Size = new SizeF(20, 20);
            bmpnode.LineStyle.LineWidth = 0;
            this.AppendChild(bmpnode);	
                 
            mod1 = model1;
            mod2 = model2;
            dig = diagram;

          
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            if (this.bmpnode != null && this.bmpnode.Name == "Grand Mother")
            {
                tooltips.IsBalloon = true;
                tooltips.SetToolTip(this.dig, "Home");
                tooltips.Active = true;
            }
            else
            {
                tooltips.Active = false;
            }
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            tooltips.Active = false;
        }
      
        protected override void OnMouseClick(EventArgs e)
        {
            // Presents the Home page ( Model1 )

            this.dig.Model = this.mod1;

            foreach (Node node in this.mod1.Nodes)
            {
                if (node is TextNode)
                    node.EditStyle.AllowSelect = false;
                if (node != null)
                {
                    this.dig.SelectAll();
                    this.dig.Controller.Delete();
                    this.mod1.Nodes.Clear();
					break;
                }
            }
            this.dig.Model.AppendChild(new GrandMotherSymbolClass(this.dig, this.mod1, this.mod2));

            Syncfusion.Windows.Forms.Diagram.TextNode txtnode1 = new TextNode("Coevals Diagram ");
            txtnode1.FontStyle.Size = 16;
            txtnode1.FontStyle.Family = "Segoe UI";
            txtnode1.FontStyle.Bold = true;

            txtnode1.FontColorStyle.Color = Color.Black;
            txtnode1.LineStyle.LineColor = Color.Transparent;
            txtnode1.SizeToText(new Size(1000, 1000));
            txtnode1.PinPoint = new PointF(300, 25);
            this.dig.Model.AppendChild(txtnode1);

            this.dig.View.SelectionList.Clear();
            this.Nodes.Clear();
        }
    }
#endregion
}

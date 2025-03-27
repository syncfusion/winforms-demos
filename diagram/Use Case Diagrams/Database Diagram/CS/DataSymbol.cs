#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System.Text;
using System.Windows.Forms;
using Syncfusion.Windows.Forms.Tools;
using Syncfusion.Windows.Forms.Diagram.Controls;
using Syncfusion.Windows.Forms.Diagram;
using System.Drawing.Drawing2D;
using System.IO;
using System.Drawing.Printing;
using System.Drawing.Imaging;
using Syncfusion.Windows.Forms;
using System.Collections;
using System.Drawing;
using System;

namespace DatabaseDiagram
{
    [Serializable]
    [System.Security.Permissions.PermissionSet(System.Security.Permissions.SecurityAction.Assert, Name = "FullTrust")]
    public class DataSymbol:Group
    {
        public DataSymbol( ArrayList strColumnName, string strTableName, string primaryKey)
            : base()
        {
            this.Name = strTableName;
            float rectHeight = (strColumnName.Count * 20) + 40;
            Syncfusion.Windows.Forms.Diagram.Rectangle rect = new Syncfusion.Windows.Forms.Diagram.Rectangle(0, 0, 150, rectHeight);
            rect.FillStyle.Color = Color.WhiteSmoke;
            rect.Name = "BaseNode";
            Syncfusion.Windows.Forms.Diagram.Label lbl = new Syncfusion.Windows.Forms.Diagram.Label(rect, strTableName);
            lbl.FontStyle.Family = "Arial";            
            lbl.FontStyle.Size = 9;
            lbl.FontStyle.Bold = true;
            lbl.Position = Position.TopLeft;
            lbl.OffsetX = 65;
            lbl.OffsetY = 18;
            lbl.UpdatePosition = true;
            rect.Labels.Add(lbl);
            this.AppendChild(rect);
            float z = 30;
            for (int i = 0; i < strColumnName.Count; i++)
            {
                TextNode txtNode = new TextNode(strColumnName[i].ToString(), new RectangleF(30, z, 110, 20));
                txtNode.FontStyle.Family = "Arial";
                txtNode.FontStyle.Size = 7;
                txtNode.VerticalAlignment = StringAlignment.Center;
                txtNode.BackgroundStyle.Color = Color.White;
                txtNode.LineStyle.LineColor = Color.LightGray;
                
                Syncfusion.Windows.Forms.Diagram.Rectangle symRect = new Syncfusion.Windows.Forms.Diagram.Rectangle(10, z, 20, 20);
                symRect.FillStyle.Color = Color.WhiteSmoke;
                symRect.FillStyle.Type = FillStyleType.LinearGradient;
                symRect.LineStyle.LineColor = Color.LightGray;
                symRect.EditStyle.AllowSelect = false;
                this.AppendChild(txtNode);
                this.AppendChild(symRect);
                if (primaryKey == txtNode.Text)
                {
#if !NETCORE
                    Bitmap bmp = new Bitmap(@"..\..\..\..\..\..\common\Images\Diagram\class diagram\key.png");
#else
                    Bitmap bmp = new Bitmap(@"..\..\..\..\..\..\..\common\Images\Diagram\class diagram\key.png");
#endif
                    BitmapNode bmpNode = new BitmapNode(bmp, new RectangleF(symRect.BoundingRectangle.X+5, symRect.BoundingRectangle.Y +5, symRect.BoundingRectangle.Width-10, symRect.BoundingRectangle.Height-10));
                    bmpNode.LineStyle.LineColor = Color.Transparent;
                    bmpNode.EditStyle.AllowSelect = false;
                    this.AppendChild(bmpNode);
                }
               
                z = z + 20;
            }
          
        }

    }
}

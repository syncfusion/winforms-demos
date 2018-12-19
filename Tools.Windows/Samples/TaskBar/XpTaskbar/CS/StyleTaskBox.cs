using System;
using System.Collections.Generic;
using System.Text;
using Syncfusion.Windows.Forms.Tools;
using System.Drawing;
using System.Windows.Forms;
using Syncfusion.Drawing;
using System.Reflection;
using System.IO;

namespace TaskBar
{
    class StyleTaskBox :XPTaskBarBox
    {
        Color[] color1 = new Color[] { Color.FromArgb(115, 137, 184), Color.FromArgb(127, 151, 199), Color.FromArgb(162, 183, 226), Color.FromArgb(178, 200, 250) };
        protected override void DrawHeader(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Rectangle header_rect = this.GetHeaderRect();
            Font font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);//, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

            #region GradientBar appearance 
            BrushInfo bf = new BrushInfo(GradientStyle.Vertical, color1);
            BrushPaint.FillRectangle(g, header_rect, bf);
            #endregion

            #region Set Image for Expander
            Rectangle rect = new Rectangle(this.ExpanderButton.Bounds.X - 10, this.ExpanderButton.Bounds.Y - 5, this.GetHeaderButtonSize().Height + 10, this.GetHeaderButtonSize().Width + 10);
            #region Embedding image as a resource
            Assembly asm = this.GetType().Assembly;
            Stream Xpand_str = asm.GetManifestResourceStream("TaskBar.Button-up.png");
            Stream Collapse_str = asm.GetManifestResourceStream("TaskBar.Button-down.png");
            #endregion
            if (this.Collapsed && this.Focused == true)
            {
                Image img = Image.FromStream(Collapse_str);

                g.DrawImage(img, rect);
            }
            else
            {
                Image img = Image.FromStream(Xpand_str);
                g.DrawImage(img, rect);
            }
            #endregion

            #region Border
            Pen pen = new Pen(Color.FromArgb(117, 135, 185), 3);
            g.DrawRectangle(pen, header_rect);
            #endregion

            #region Draw Text
            Brush bu = new SolidBrush(Color.White);
            g.DrawString(this.Text, font, bu, header_rect.X + 10, header_rect.Y + 5);
            #endregion
        }
      

    }
}

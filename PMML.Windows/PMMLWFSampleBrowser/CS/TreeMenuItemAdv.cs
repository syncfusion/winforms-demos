using Syncfusion.Windows.Forms.Tools;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PMMLWFSampleBrowser
{
    public class TreeMenuItemAdv : TreeMenuItem
    {
        public string ModelName { get; set; }
        public bool IsModel { get; set; }
        public string ModelTag { get; set; }
        public string SamplePath { get; set; }
        public string SampleName { get; set; }
        public string SampleTag { get; set; }

        /// <summary>
        /// Constructor
        /// </summary>
        public TreeMenuItemAdv()
        {
            this.ForeColor = Color.Black;
        }

        /// <summary>
        /// Paint the TreeMenuItemExt.
        /// </summary>
        /// <param name="e"></param>
        protected override void OnPaint(System.Windows.Forms.PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            e.Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            SizeF sf = e.Graphics.MeasureString(this.Text, this.Font);

            using (Graphics g = this.CreateGraphics())
            {
                if (g.DpiX >= 120)
                {
                    TextRenderer.DrawText(e.Graphics, this.ModelName, new Font(this.Font.FontFamily, this.Font.Size - 1, this.Font.Style), new Rectangle(this.Location.X + 35, (int)(this.Height / 2 - sf.Height / 2 - 9), (int)this.Width - 35, this.Height), this.ForeColor, TextFormatFlags.EndEllipsis);
                }
                else
                {
                    if(this.IsModel)
                    TextRenderer.DrawText(e.Graphics, this.ModelName, this.Font, new Rectangle(this.Location.X + 15, (int)(this.Height / 2 - sf.Height / 2 - 10), (int)this.Width - 35, this.Height), this.ForeColor, TextFormatFlags.EndEllipsis);
                    else 
                    TextRenderer.DrawText(e.Graphics, this.SampleName, this.Font, new Rectangle(this.Location.X + 15, (int)(this.Height / 2 - sf.Height / 2 - 10), (int)this.Width - 35, this.Height), this.ForeColor, TextFormatFlags.EndEllipsis);
                }
            }
            this.Text = "";

            int X_position = this.Location.X + TextRenderer.MeasureText(this.ModelName, new Font(this.Font.FontFamily, this.Font.Size, FontStyle.Regular)).Width + 10;

            if (this.ModelTag == "PREVIEW" || this.SampleTag == "PREVIEW")
            {
                using (SolidBrush solidBrush = new SolidBrush(ColorTranslator.FromHtml("#f68d38")))
                {
                    e.Graphics.FillRectangle(solidBrush, new Rectangle(X_position + 7, 19, TextRenderer.MeasureText("PREVIEW", new Font("Segoe UI", 7f, FontStyle.Bold)).Width + 5, new Font("Segoe UI", 6f, FontStyle.Bold).Height + 2));

                    using (Graphics g = this.CreateGraphics())
                    {
                        if (g.DpiX > 96)
                            e.Graphics.DrawString("PREVIEW", new Font("Segoe UI", 7f, FontStyle.Bold), Brushes.White, (X_position + 8), 12);
                        else
                            e.Graphics.DrawString("PREVIEW", new Font("Segoe UI", 8f, FontStyle.Bold), Brushes.White, (X_position + 8), 19);
                    }
                }
            }

            if (this.ModelTag == "NEW" || this.SampleTag == "NEW")
            {         
                using (SolidBrush solidBrush = new SolidBrush(ColorTranslator.FromHtml("#14a88e")))
                {
                    e.Graphics.FillRectangle(solidBrush, new Rectangle(X_position + 7, 19, TextRenderer.MeasureText("NEW", new Font("Segoe UI", 7f, FontStyle.Bold)).Width + 3, new Font("Segoe UI", 6f, FontStyle.Bold).Height + 2));

                    using (Graphics g = this.CreateGraphics())
                    {
                        if (g.DpiX > 96)
                            e.Graphics.DrawString("NEW", new Font("Segoe UI", 7f, FontStyle.Bold), Brushes.White, (X_position + 8), 12);
                        else
                            e.Graphics.DrawString("NEW", new Font("Segoe UI", 8f, FontStyle.Bold), Brushes.White, (X_position + 8), 19);
                    }
                }
            }

            if (this.ModelTag == "UPDATED" || this.SampleTag == "UPDATED")
            {
                using (SolidBrush solidBrush = new SolidBrush(ColorTranslator.FromHtml("#268bb5")))
                {
                    e.Graphics.FillRectangle(solidBrush, new Rectangle(X_position + 7, 19, TextRenderer.MeasureText("UPDATED", new Font("Segoe UI", 7f, FontStyle.Bold)).Width + 6, new Font("Segoe UI", 6f, FontStyle.Bold).Height + 2));

                    using (Graphics g = this.CreateGraphics())
                    {
                        if (g.DpiX > 96)
                            e.Graphics.DrawString("UPDATED", new Font("Segoe UI", 7f, FontStyle.Bold), Brushes.White, (X_position + 8), 12);
                        else
                            e.Graphics.DrawString("UPDATED", new Font("Segoe UI", 8f, FontStyle.Bold), Brushes.White, (X_position + 8), 19);
                    }
                }
            }
            base.OnPaint(e);
        }
    }
}

#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Syncfusion.Windows.Forms.Tools;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
public class StyledRenderer : IToggleButtonRenderer
{
    private ToggleButton toggleButton;

    #region IToggleButtonRenderer Members

    public void DrawButton(PaintEventArgs e, ToggleButtonState toggleState, DisplayType displayMode, Font font, ActiveStateCollection activeState, InactiveStateCollection inactiveState, RightToLeft righttoLeft, bool isMouseHover, ToggleButton togglebutton)
    {
        string displaytext = toggleState == ToggleButtonState.Active ? activeState.Text : inactiveState.Text;
        SizeF textsize = e.Graphics.MeasureString(displaytext, font);
        Rectangle controlrect = new Rectangle(e.ClipRectangle.X + 1, e.ClipRectangle.Y + 1, e.ClipRectangle.Width - 4, e.ClipRectangle.Height - 4);
        e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
        GraphicsPath gp = new GraphicsPath();
        using (LinearGradientBrush br = new LinearGradientBrush(e.ClipRectangle, ColorTranslator.FromHtml("#007feb"), ColorTranslator.FromHtml("#51a7f2"), LinearGradientMode.Vertical))
        {
            if (controlrect.Height > 1)
            {
                gp.AddArc(controlrect.X, controlrect.Y, controlrect.Height, controlrect.Height, 180, 90);
                gp.AddArc(controlrect.X + controlrect.Width - controlrect.Height, controlrect.Y, controlrect.Height, controlrect.Height, 270, 90);
                gp.AddArc(controlrect.X + controlrect.Width - controlrect.Height, controlrect.Y + controlrect.Height - controlrect.Height, controlrect.Height, controlrect.Height, 0, 90);
                gp.AddArc(controlrect.X, controlrect.Y + controlrect.Height - controlrect.Height, controlrect.Height, controlrect.Height, 90, 90);
                gp.CloseFigure();
                e.Graphics.DrawPath(new Pen(ColorTranslator.FromHtml("#002f69"), 2), gp);
            }
        }
        GraphicsPath gp1 = new GraphicsPath();
        using (LinearGradientBrush br = new LinearGradientBrush(e.ClipRectangle, ColorTranslator.FromHtml("#007feb"), ColorTranslator.FromHtml("#51a7f2"), LinearGradientMode.Vertical))
        {
            if (controlrect.Height > 1)
            {
                gp1.AddArc(controlrect.X, controlrect.Y + 1, controlrect.Height + 2, controlrect.Height, 180, 90);
                gp1.AddArc(controlrect.X + controlrect.Width - controlrect.Height, controlrect.Y, controlrect.Height, controlrect.Height, 270, 90);
                gp1.AddArc(controlrect.X + 1 + controlrect.Width - controlrect.Height, controlrect.Y + controlrect.Height - controlrect.Height, controlrect.Height, controlrect.Height, 0, 90);
                gp1.AddArc(controlrect.X, controlrect.Y + controlrect.Height - controlrect.Height, controlrect.Height, controlrect.Height, 90, 90);
                gp1.CloseFigure();
                e.Graphics.FillPath(br, gp1);
                gp1.Dispose();
            }
        }
        GraphicsPath gp2 = new GraphicsPath();
        using (LinearGradientBrush br = new LinearGradientBrush(e.ClipRectangle, ColorTranslator.FromHtml("#51a7f2"), ColorTranslator.FromHtml("#51a7f2"), LinearGradientMode.Vertical))
        {
            if (controlrect.Height > 1)
            {
                gp2.AddArc(controlrect.X + 5, controlrect.Y + controlrect.Height / 2, controlrect.Height - controlrect.Height / 2, controlrect.Height / 2, 180, 90);
                gp2.AddArc(controlrect.X + 5 + controlrect.Width - controlrect.Height, controlrect.Y + controlrect.Height / 2, controlrect.Height - controlrect.Height / 2, controlrect.Height / 2, 270, 90);
                gp2.AddArc(controlrect.X + 5 + controlrect.Width - controlrect.Height, controlrect.Y + controlrect.Height - controlrect.Height + controlrect.Height / 2, controlrect.Height - controlrect.Height / 2, controlrect.Height / 2, 0, 90);
                gp2.AddArc(controlrect.X + 5, controlrect.Y + controlrect.Height - controlrect.Height + controlrect.Height / 2, controlrect.Height - controlrect.Height / 2, controlrect.Height / 2, 90, 90);
                gp2.CloseFigure();
                e.Graphics.FillPath(br, gp2);
                gp2.Dispose();
            }
        }
        if (isMouseHover)
            using (SolidBrush br = new SolidBrush(ColorTranslator.FromHtml("#51a7f2")))
            {
                e.Graphics.FillPath(br, gp);
            }
        PointF pt1 = new PointF(e.ClipRectangle.X + e.ClipRectangle.Width / 2 - textsize.Width / 2, e.ClipRectangle.Y + e.ClipRectangle.Height / 2 - textsize.Height / 2);
        using (SolidBrush br = new SolidBrush(activeState.ForeColor))
        {
            if (displayMode == DisplayType.Text)
                e.Graphics.DrawString(displaytext, font, br, pt1);
        }
        gp.Dispose();
    }

    public void DrawSlider(PaintEventArgs e, Point p, ToggleButtonState toggleState, SliderCollection slider, Font font, RightToLeft righttoLeft, bool isMouseMove, bool isMouseHover, ToggleButton togglebutton)
    {
        e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
        Rectangle controlrect = new Rectangle(e.ClipRectangle.X, e.ClipRectangle.Y, slider.Width, slider.Width - 1);
        Rectangle t_sliderRectangle;
        if (!isMouseMove)
        {
            if (toggleState == ToggleButtonState.Inactive)
                t_sliderRectangle = new Rectangle(e.ClipRectangle.X, e.ClipRectangle.Y, e.ClipRectangle.Height - 1, e.ClipRectangle.Height - 1);
            else
                t_sliderRectangle = new Rectangle(e.ClipRectangle.X + e.ClipRectangle.Width - e.ClipRectangle.Height, e.ClipRectangle.Y, e.ClipRectangle.Height - 1, e.ClipRectangle.Height - 1);
        }
        else
            t_sliderRectangle = new Rectangle(p.X, e.ClipRectangle.Y, e.ClipRectangle.Height - 1, e.ClipRectangle.Height - 1);
        if (isMouseHover)
        {
            using (SolidBrush br = new SolidBrush(slider.BackColor))
            {
                e.Graphics.FillEllipse(br, t_sliderRectangle);
                using (Pen pn = new Pen(Color.Gray, 2))
                    e.Graphics.DrawEllipse(pn, t_sliderRectangle);
            }
        }
        else
        {
            using (SolidBrush br = new SolidBrush(slider.BackColor))
            {
                e.Graphics.FillEllipse(br, t_sliderRectangle);
                e.Graphics.DrawEllipse(Pens.Gray, t_sliderRectangle);
            }
        }
    }
    #endregion

    #region IToggleButtonRenderer Members

    public ToggleButton ToggleButton
    {
        get
        {
            return toggleButton;
        }
        set
        {
            toggleButton = value;
        }
    }

    #endregion
}
using System;
using System.Collections.Generic;

using System.Web;
using Syncfusion.Windows.Forms.Diagram;
using System.Runtime.Serialization;


/// <summary>
/// Summary description for CustomRectangle
/// </summary>

[Serializable]
public class CustomRectangle :Rectangle
{
    #region Class Members
    private System.Drawing.Image titleImage = null;

    private string className = string.Empty;
    private string classType = string.Empty;
    private string objectType = string.Empty;

    Label lblClassName = new Label();
    Label lblClassType = new Label();
    Label lblObjectType = new Label();
    #endregion

    #region Class Properties

    public string ClassName
    {
        get { return lblClassName.Text; }
        set { lblClassName.Text = value; }
    }
    public string ClassType
    {
        get { return lblClassType.Text; }
        set { lblClassType.Text = value; }
    }
    public string ObjectType
    {
        get { return lblObjectType.Text; }
        set { lblObjectType.Text = value; }
    }

    public System.Drawing.Image TitleImage
    {
        get { return titleImage; }
        set { titleImage = value; }
    }

    #endregion

    #region Class Initialize/Finalize methods
    /// <summary>
        /// Initializes a new instance of the <see cref="Rectangle"/> class.
        /// </summary>
        /// <param name="x">X-coordinate of rectangle.</param>
        /// <param name="y">Y-coordinate of rectangle.</param>
        /// <param name="width">Width of rectangle.</param>
        /// <param name="height">Height of rectangle.</param>
        public CustomRectangle(float x, float y, float width, float height)
            : this(new System.Drawing.RectangleF(x, y, width, height))
        { 
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Rectangle"/> class.
        /// </summary>
        /// <param name="rcBounds">Rectangle containing position and size.</param>
        public CustomRectangle(System.Drawing.RectangleF rcBounds):base(new System.Drawing.RectangleF(rcBounds.X,rcBounds.Y,rcBounds.Width,rcBounds.Height))
        {
            InitializeRectangle(rcBounds, MeasureUnits.Pixel);
        }

        public CustomRectangle(CustomRectangle src)
            : base(src)
        {
        }

        /// <summary>
        /// Serialization constructor for the ImageLabel class.
        /// </summary>
        /// <param name="info">Serialization state information</param>
        /// <param name="context">Streaming context information</param>
        protected CustomRectangle(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }

        private void InitializeRectangle(System.Drawing.RectangleF rectBounds, MeasureUnits measureUnits)
        {
            this.Labels.Add(lblClassName);
            lblClassName.FontStyle.Family = "Arial";
            lblClassName.FontStyle.Size = 8;
            lblClassName.FontStyle.Bold = true;
            lblClassName.OffsetX = 10;
            lblClassName.OffsetY = 5;
            this.Labels.Add(lblClassType);
            lblClassType.FontStyle.Family = "Arial";
            lblClassType.FontStyle.Size = 8;
            lblClassType.OffsetX = 10;
            lblClassType.OffsetY = 25;

            this.Labels.Add(lblObjectType);
            lblObjectType.FontStyle.Family = "Arial";
            lblObjectType.FontStyle.Size = 7;
            lblObjectType.OffsetX = 10;
            lblObjectType.OffsetY = 45;
            this.LineStyle.LineWidth = 0;

        }

        #endregion

    #region Class Override Methods
        protected override void Render(System.Drawing.Graphics gfx)
        {   
            base.Render(gfx);
            System.Drawing.Drawing2D.GraphicsState graph = gfx.Save();
            if (TitleImage != null)
            {
                gfx.DrawImage(TitleImage,(this.PinPoint.X -25) +(this.Size.Width-this.PinPoint.X),5,17.5f,17.5f);
            }
            gfx.Restore(graph);
        }
        #endregion
}
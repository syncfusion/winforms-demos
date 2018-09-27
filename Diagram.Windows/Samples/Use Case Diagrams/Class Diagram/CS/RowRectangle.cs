using System;
using System.Collections.Generic;

using System.Web;
using Syncfusion.Windows.Forms.Diagram;
using System.Runtime.Serialization;

/// <summary>
/// Summary description for RowRectangle
/// </summary>
[Serializable]
public class RowRectangle : Rectangle
{
    #region Class Properties

    Label lblRowText = new Label();
    public string RowText
    {
        get { return lblRowText.Text; }
        set { lblRowText.Text = value; }
    }

    private System.Drawing.Image rowImage = null;
    public System.Drawing.Image RowImage
    {
        get { return rowImage; }
        set { rowImage = value; }
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
        public RowRectangle(float x, float y, float width, float height)
            : this(new System.Drawing.RectangleF(x, y, width, height))
        { 
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Rectangle"/> class.
        /// </summary>
        /// <param name="rcBounds">Rectangle containing position and size.</param>
        public RowRectangle(System.Drawing.RectangleF rcBounds):base(new System.Drawing.RectangleF(rcBounds.X,rcBounds.Y,rcBounds.Width,rcBounds.Height))
        {
            InitializeRectangle(rcBounds, MeasureUnits.Pixel);
        }

        public RowRectangle(CustomRectangle src)
            : base(src)
        {
        }
        
        /// <summary>
        /// Serialization constructor for the ImageLabel class.
        /// </summary>
        /// <param name="info">Serialization state information</param>
        /// <param name="context">Streaming context information</param>
        protected RowRectangle(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }

        private void InitializeRectangle(System.Drawing.RectangleF rectBounds, MeasureUnits measureUnits)
        {   
            this.Labels.Add(lblRowText);
            lblRowText.FontStyle.Family = "Arial";
            lblRowText.FontStyle.Size = 8;
            lblRowText.OffsetX = 55;
            lblRowText.OffsetY = 5;
            
            
        }

        #endregion

    #region Class Override Methods
        protected override void Render(System.Drawing.Graphics gfx)
        {   
            base.Render(gfx);
            System.Drawing.Drawing2D.GraphicsState graph = gfx.Save();
            if (RowImage != null)
            {
                gfx.DrawImage(RowImage, this.Labels[0].OffsetX -20, 2,17.5f,17.5f);
                gfx.Restore(graph);
            }
        }
        #endregion
}
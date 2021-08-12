using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NavigationDrawTile
{
    public partial class TileControl : Control
    {
        public TileControl()
        {
            //this.Controls.Add(m_Position);
            //this.Controls.Add(m_Organization);
            //this.Controls.Add(m_DOB);
            //this.Controls.Add(m_Location);
            //InitializeLabel();
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.UserPaint, true);
            textsize = TextRenderer.MeasureText(" Date Of Birth", this.Font);
        }
        private Label m_Position = new Label();
        private Label m_Organization = new Label();
        private Label m_DOB = new Label();
        private Label m_Location = new Label();
        private Color m_HeaderColor = Color.Black;
        public Color HeaderColor
        {
            get
            {
                return m_HeaderColor;
            }
            set
            {
                m_HeaderColor = value;
            }
        }
        Size textsize = Size.Empty;

        internal void InitializeLabel(PaintEventArgs e)
        {
            Rectangle outerrect = new Rectangle(0, 0, this.Width, this.Height);
            Rectangle headerrect = new Rectangle(0, 0, this.Width, 45);
            Rectangle imagerect = new Rectangle(15, headerrect.Bottom + 15, this.TileImage.Width,this.TileImage.Height);
            m_Position.Location = new Point(imagerect.Right + 10, headerrect.Bottom + 15);
            m_Organization.Location = new Point(imagerect.Right + 10, m_Position.Bottom + 5);
            m_DOB.Location = new Point(imagerect.Right + 10, m_Organization.Bottom + 5);
            m_Location.Location = new Point(imagerect.Right + 10, m_DOB.Bottom + 5);
            PointF m_PositionLocation = new PointF((float)imagerect.Right + 10, (float)headerrect.Bottom + 15);

            PointF m_OrganizationLocation = new PointF((float)imagerect.Right + 10, (float)m_PositionLocation.Y + textsize.Height+15);
            PointF m_DOBLocation = new PointF((float)imagerect.Right + 10, (float)m_OrganizationLocation.Y + textsize.Height + 15);
            PointF m_LocationLocation = new PointF((float)imagerect.Right + 10, (float)m_DOBLocation.Y + textsize.Height + 15);
            Font boldfont = new Font(this.font, FontStyle.Bold);
            e.Graphics.DrawString("Postion", boldfont, new SolidBrush(TextColor), m_PositionLocation);
            e.Graphics.DrawString("Organizaton", boldfont, new SolidBrush(TextColor), m_OrganizationLocation);
            e.Graphics.DrawString("Date Of Birth", boldfont, new SolidBrush(TextColor), m_DOBLocation);
            e.Graphics.DrawString("Location", boldfont, new SolidBrush(TextColor), m_LocationLocation);
        }
        private String m_HeaderText = "HeaderText";

        private Font font = new Font("Micorsoft San Serif",9.75F);
        public String HeaderText
        {
            get
            {
                return m_HeaderText;
            }
            set
            {
                m_HeaderText = value;
            }
        }

        private Image m_TileImage = new Bitmap(10, 10);
        public Image TileImage
        {
            get
            { 
                return m_TileImage;
            }
            set
            {
                m_TileImage=value;
            }
        }

        private String m_PostionText = "PostionText";
        public String PostionText
        {
            get
            {
                return m_PostionText;
            }
            set
            {
                m_PostionText = value;
            }
        }

        private String m_OrganizatonText = "OrganizatonText";
        public String OrganizatonText
        {
            get
            {
                return m_OrganizatonText;
            }
            set
            {
                m_OrganizatonText = value;
            }
        }

        private String m_LocationText = "LocationText";
        public String LocationText
        {
            get
            {
                return m_LocationText;
            }
            set
            {
                m_LocationText = value;
            }
        }

        private String m_DOBText = "DOBText";
        public String DOBText
        {
            get
            {
                return m_DOBText;
            }
            set
            {
                m_DOBText = value;
            }
        }
        private Color textColor = Color.Black;
        public Color TextColor
        {
            get
            {
                return textColor;
            }
            set
            {
                textColor = value;
            }
        }
        private Color headerTextColor = Color.Black;
        public Color HeaderTextColor
        {
            get
            {
                return headerTextColor;
            }
            set
            {
                headerTextColor = value;
            }
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Rectangle outerrect=new Rectangle(0,0,this.Width,this.Height);
            Rectangle headerrect=new Rectangle(0,0,this.Width,45);
            Rectangle imagerect = new Rectangle(15, headerrect.Bottom+15, this.TileImage.Width,this.TileImage.Height);
            Size textsizes=TextRenderer.MeasureText(HeaderText,this.Font);
            PointF headertext = new PointF(5F, (float)(headerrect.Y + headerrect.Height / 2 - textsizes.Height / 2));
            e.Graphics.DrawRectangle(new Pen(HeaderColor, 2), outerrect);
            e.Graphics.FillRectangle(new SolidBrush(HeaderColor), headerrect);
            if (TileImage != null)
                e.Graphics.DrawImage(TileImage, imagerect);
            e.Graphics.DrawString(this.HeaderText, new Font(this.font.FontFamily, 11, FontStyle.Bold) , new SolidBrush(HeaderTextColor), headertext);
            InitializeLabel(e);
            Drawlabeltext(e);
        }

        private void Drawlabeltext(PaintEventArgs e)
        {
            e.Graphics.DrawString(PostionText, this.font, new SolidBrush(TextColor), (float)m_Position.Bounds.Right + 2, (float)m_Position.Bounds.Y);
            e.Graphics.DrawString(OrganizatonText, this.font, new SolidBrush(TextColor), (float)m_Position.Bounds.Right + 2, (float)m_Organization.Bounds.Y);
            e.Graphics.DrawString(DOBText, this.font, new SolidBrush(TextColor), (float)m_Position.Bounds.Right + 2, (float)m_DOB.Bounds.Y);
            e.Graphics.DrawString(LocationText, this.font, new SolidBrush(TextColor), (float)m_Position.Bounds.Right + 2, (float)m_Location.Bounds.Y);
        }
    }
}

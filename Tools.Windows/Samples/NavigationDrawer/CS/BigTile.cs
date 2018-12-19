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
    public partial class BigTile :Control
    {
        public BigTile()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.UserPaint, true);
            this.Size = new System.Drawing.Size(735, 538);
            textsize = TextRenderer.MeasureText(" Date Of Birth", this.Font);
            this.Controls.Add(bottomdescription);
            InitializeRichTextBox();
        }

      
        Size textsize = Size.Empty;
        private Label m_Position = new Label();
        private Label m_Organization = new Label();
        private Label m_DOB = new Label();
        private Label m_Location = new Label();
        RichTextBox bottomdescription = new RichTextBox();
        private String m_HeaderText = "HeaderText";
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
        private Image m_TileImage = new Bitmap(10, 10);
        public Image TileImage
        {
            get
            {
                return m_TileImage;
            }
            set
            {
                m_TileImage = value;
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
        private String m_Description = "Desc";
        public String Description
        {
            get
            {
                return m_Description;
            }
            set
            {
                m_Description = value;
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
        private Color textColor = Color.White;
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
        protected override void OnFontChanged(EventArgs e)
        {
            base.OnFontChanged(e);
            bottomdescription.Font = this.Font;
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            bottomdescription.Text = Description;
            
            Rectangle outerrect = new Rectangle(0, 0, this.Width, this.Height);
            Rectangle headerrect = new Rectangle(0, 0, this.Width, 75);
            Rectangle imagerect = new Rectangle(15, headerrect.Bottom, 150, 150);
            Font header = new System.Drawing.Font(this.Font.FontFamily,15, FontStyle.Bold);
            Size textsizes = TextRenderer.MeasureText(HeaderText,header);
            PointF headertext = new PointF(5F, (float)(headerrect.Y + headerrect.Height / 2 - textsizes.Height / 2));
            e.Graphics.DrawRectangle(new Pen(HeaderColor, 2), outerrect);
            e.Graphics.FillRectangle(new SolidBrush(HeaderColor), headerrect);
            if (TileImage != null)
                e.Graphics.DrawImage(TileImage, imagerect);
            e.Graphics.DrawString(this.HeaderText,header, new SolidBrush(TextColor), headertext);
            InitializeLabel(e);
            Drawlabeltext(e);
        }
        private void Drawlabeltext(PaintEventArgs e)
        {
            e.Graphics.DrawString(PostionText, new System.Drawing.Font(this.Font.FontFamily,10, FontStyle.Regular), new SolidBrush(TextColor), (float)m_Position.Bounds.Right + 2, (float)m_Position.Bounds.Y);
            e.Graphics.DrawString(OrganizatonText, new System.Drawing.Font(this.Font.FontFamily, 10, FontStyle.Regular), new SolidBrush(TextColor), (float)m_Position.Bounds.Right + 2, (float)m_Organization.Bounds.Y);
            e.Graphics.DrawString(DOBText, new System.Drawing.Font(this.Font.FontFamily, 10, FontStyle.Regular), new SolidBrush(TextColor), (float)m_Position.Bounds.Right + 2, (float)m_DOB.Bounds.Y);
            e.Graphics.DrawString(LocationText, new System.Drawing.Font(this.Font.FontFamily, 10, FontStyle.Regular), new SolidBrush(TextColor), (float)m_Position.Bounds.Right + 2, (float)m_Location.Bounds.Y);
        }


        internal void InitializeLabel(PaintEventArgs e)
        {
            Rectangle outerrect = new Rectangle(0, 0, this.Width, this.Height);
            Rectangle headerrect = new Rectangle(0, 0, this.Width, 75);
            Rectangle imagerect = new Rectangle(15, headerrect.Bottom, 150,150);
            m_Position.Location = new Point(imagerect.Right + 10, headerrect.Bottom + 15);
            m_Organization.Location = new Point(imagerect.Right + 10, m_Position.Bottom + 5);
            m_DOB.Location = new Point(imagerect.Right + 10, m_Organization.Bottom + 5);
            m_Location.Location = new Point(imagerect.Right + 10, m_DOB.Bottom + 5);
            PointF m_PositionLocation = new PointF((float)imagerect.Right + 10, (float)headerrect.Bottom + 15);

            PointF m_OrganizationLocation = new PointF((float)imagerect.Right + 10, (float)m_PositionLocation.Y + textsize.Height + 15);
            PointF m_DOBLocation = new PointF((float)imagerect.Right + 10, (float)m_OrganizationLocation.Y + textsize.Height + 15);
            PointF m_LocationLocation = new PointF((float)imagerect.Right + 10, (float)m_DOBLocation.Y + textsize.Height + 15);
            e.Graphics.DrawString("Postion", new System.Drawing.Font(this.Font.FontFamily, 10, FontStyle.Regular), new SolidBrush(TextColor), m_PositionLocation);
            e.Graphics.DrawString("Organizaton", new System.Drawing.Font(this.Font.FontFamily, 10, FontStyle.Regular), new SolidBrush(TextColor), m_OrganizationLocation);
            e.Graphics.DrawString("Date Of Birth", new System.Drawing.Font(this.Font.FontFamily, 10, FontStyle.Regular), new SolidBrush(TextColor), m_DOBLocation);
            e.Graphics.DrawString("Location", new System.Drawing.Font(this.Font.FontFamily, 10, FontStyle.Regular), new SolidBrush(TextColor), m_LocationLocation);
            InitializeRichTextBox();
        }
        private void InitializeRichTextBox()
        {
            bottomdescription.Font = new System.Drawing.Font(this.Font.FontFamily, 10, FontStyle.Regular);
            bottomdescription.BorderStyle = BorderStyle.None;
            bottomdescription.ForeColor = TextColor;
            bottomdescription.BackColor = this.BackColor;
            //bottomdescription.Dock = DockStyle.Bottom;
            bottomdescription.Location = new Point(15, 250);
            bottomdescription.Width = this.Width - 5;
            bottomdescription.Height = this.Height - 230;
        }
        protected override void OnBackColorChanged(EventArgs e)
        {
            base.OnBackColorChanged(e);
            bottomdescription.BackColor = this.BackColor;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Syncfusion.Windows.Forms.Tools;

namespace RibbonTouchStyleDemo
{
    public partial class Form1 : RibbonForm
    {
        SplashControl splashControl1 = new SplashControl();
        public Form1()
        {
            InitializeComponent();
            this.splashControl1.AutoMode = false;
            this.splashControl1.CustomSplashPanel = this.splashPanel1;
            this.splashControl1.HostForm = this;
            this.splashControl1.UseCustomSplashPanel = true;
            label2.ForeColor = ColorTranslator.FromHtml("#d24726");
            label2.Location = new Point(label2.Location.X + 5, label2.Location.Y - 5);
            label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            x = 28;
            y = 132;

            
            TouchStylecolor.ToolStripSpliterColor = Color.White;

            menucolor(ColorTranslator.FromHtml("#0272c5"));
            applycolor(ColorTranslator.FromHtml("#2a8dd4"));
            
            TouchStylecolor.ToolStripSpliterColor = ColorTranslator.FromHtml("#cccccc");
            TouchStylecolor.ToolStripBorderColor = ColorTranslator.FromHtml("#cccccc");
            TouchStylecolor.ToolstripTabItemBorder = Color.Transparent;
            TouchStylecolor.ToolstripSelectedTabItemBorder = ColorTranslator.FromHtml("#cccccc");
            TouchStylecolor.HoverTabForeColor = ColorTranslator.FromHtml("#d24726");
            TouchStylecolor.MenuButtonArrowColor = Color.White;
            TouchStylecolor.DropDownTextForeColor = Color.Black;
            TouchStylecolor.DropDownMenuItemBackground = ColorTranslator.FromHtml("#0272c5");
            TouchStylecolor.DropDownSelectedTextForeColor = Color.White;
            TouchStylecolor.DropDownBodyColor = Color.White;
            TouchStylecolor.ImageMargin = Color.White;
            TouchStylecolor.DropDownTitleBackground = Color.LightGray;
            TouchStylecolor.ButtonPressedColor = ColorTranslator.FromHtml("#92c0e0");
            TouchStylecolor.ButtonHoverColor = ColorTranslator.FromHtml("#cde6f7");
            TouchStylecolor.ButtonCheckedColor = ColorTranslator.FromHtml("#b1d6f0");
            TouchStylecolor.BackStageNavigationButtonBackColor = ColorTranslator.FromHtml("#d24726");
            TouchStylecolor.ToolstripActiveTabItemForeColor = ColorTranslator.FromHtml("#d24726");
            TouchStylecolor.CloseButtonHoverForeColor = ColorTranslator.FromHtml("#E71E27");
            this.TouchStylecolor.CloseButtonBackground = Color.White;
            TouchStylecolor.MenuButtonHoverArrowColor = ColorTranslator.FromHtml("#EBAFA2");
            TouchStylecolor.HoverTabBackColor = ColorTranslator.FromHtml("#DD5938");
            TouchStylecolor.HoverTabForeColor = Color.White;
            TouchStylecolor.InActiveToolStripTabItemBackColor = ColorTranslator.FromHtml("#d24726");
            this.ribbonControlAdv1.QuickPanelAlignment = QuickPanelAlignment.Top;
            
            this.trackBarItem1.Maximum = 200;
            this.trackBarItem1.TrackBarExControl.Style = TrackBarEx.Theme.Metro;
            this.trackBarItem1.TrackBarExControl.BackColor = Color.FromArgb(43, 87, 154);
            this.trackBarItem1.BackColor = ColorTranslator.FromHtml("#d24726");
            this.trackBarItem1.TrackBarExControl.ButtonSignColor = Color.White;
            this.trackBarItem1.TrackBarExControl.ForeColor = Color.White;
            this.trackBarItem1.TrackBarExControl.Value = 100;           
            this.toolStripStatusLabel1.AutoSize = false;
            ribbonControlAdv1.ApplyTouchStyleColorTable(TouchStylecolor);
            this.panel10.Visible = false;
            this.ribbonControlAdv1.BackStageButtonAlignment = BackButtonAlignment.Center;
            
            this.panel4.Visible = false;
            animationTimer.Tick+=new EventHandler(animationTimer_Tick);
            
            this.ribbonControlAdv1.MenuButtonClick += new EventHandler(ribbonControlAdv1_MenuButtonClick);
            this.toolStripComboBox1.SelectedIndex = 0;
            foreach (Control ctrl in this.panel1.Controls)
            {
                ctrl.MouseDown += new MouseEventHandler(ctrl_MouseDown);
            }
            panel1.MouseDown += new MouseEventHandler(ctrl_MouseDown);
            this.scrollersFrame1.VisualStyle = Syncfusion.Windows.Forms.ScrollBarCustomDrawStyles.Metro;

            foreach (Control ctrl in this.ribbonControlAdv1.Controls)
            {
                ctrl.MouseDown += new MouseEventHandler(ctrl_MouseDown);
            }
            this.ribbonControlAdv1.UseDefaultHighlightColor = false;
            this.multiSelectionComboBox1.PopupControl.BeforePopup += new CancelEventHandler(PopupControl_BeforePopup);
            this.multiSelectionComboBox1.DisplayMode = DisplayMode.DelimiterMode;
            this.multiSelectionComboBox1.ForeColor = Color.White;
            this.WindowState = FormWindowState.Maximized;
            this.multiSelectionComboBox1.TextBox.KeyDown += new KeyEventHandler(multiSelectionComboBox1_KeyDown);
            this.splashControl1.ShowDialogSplash(this);            
            this.buttonAdv3.Click += new EventHandler(buttonAdv3_Click);
            foreach (ToolStripTabItem Ctrl in this.ribbonControlAdv1.Header.MainItems)
            {
                Ctrl.Click += Ctrl_Click;
                Ctrl.Panel.Click += Ctrl_Click;
                foreach (ToolStripEx tools in Ctrl.Panel.Controls)
                {
                    tools.Click += new EventHandler(Ctrl_Click);
                }
            }
            this.picpanel.Click += new EventHandler(Ctrl_Click);
        }
     
        void Ctrl_Click(object sender, EventArgs e)
        {
            this.panel4.Visible = false;
        }

        void buttonAdv3_Click(object sender, EventArgs e)
        {
            this.toolStripButton17.PerformClick();            
        }

        void multiSelectionComboBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.panel4.Visible = false;
                this.superAccelerator1.Active = true;
                this.multiSelectionComboBox1.TextBox.Text = "";
            }
        }

        void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            
        }

        void PopupControl_BeforePopup(object sender, CancelEventArgs e)
        {
            e.Cancel = true;
        }


        void ctrl_MouseDown(object sender, MouseEventArgs e)
        {
            if (animationTimer.Enabled)
                animationTimer.Enabled = false;

            this.panel4.Visible = false;
            this.superAccelerator1.Active = true;
        }

        Timer animationTimer = new Timer();
        
        void ribbonControlAdv1_MenuButtonClick(object sender, EventArgs e)
        {
            this.panel4.Visible = true;
            this.panel4.BringToFront();
            this.superAccelerator1.Active = false;
            this.multiSelectionComboBox1.TextBox.Focus();
           // animationTimer.Enabled = true;
        }
        
        private int leftlocaion = -200;  // start position of the panel
        private int endlocation = 0;      // end position of the panel
        private int increasespeed = 100;     // pixels to move
        private void animationTimer_Tick(object sender, EventArgs e)
        {
            this.panel4.BringToFront();
            // if just starting, move to start location and make visible
            if (!panel4.Visible)
            {
                panel4.Left = leftlocaion;
                panel4.Visible = true;
            }
            this.multiSelectionComboBox1.TextBox.Focus();
            this.superAccelerator1.Active = false;
            // incrementally move
            panel4.Left += increasespeed;
            // make sure we didn't over shoot
            if (panel4.Left > endlocation) panel4.Left = endlocation;

            // have we arrived?
            if (panel4.Left == endlocation)
            {
                animationTimer.Enabled = false;

            }
        }

        Panel picpanel = new Panel();
        int x = 0;
        int y = 0;
       // TouchStyleColorTable
        TouchStyleColorTable TouchStylecolor = new TouchStyleColorTable();
        private void Form1_Load(object sender, EventArgs e)
        {
            this.trackBarItem1.TrackBarExControl.Maximum = 200;
            this.trackBarItem1.TrackBarExControl.Value = 100;
            this.BackColor = Color.White;
            this.ribbonControlAdv1.TitleColor = Color.White;
            this.ribbonControlAdv1.QuickPanelVisible = false;
            this.superAccelerator1.SetMenuButtonAccelerator(this.ribbonControlAdv1, "F");
            this.superAccelerator1.Appearance = Syncfusion.Windows.Forms.Tools.Appearance.Advanced;
            this.superAccelerator1.BackColor = Color.Black;
            this.superAccelerator1.ForeColor = Color.White;
            this.panel1.Height = this.Height - this.ribbonControlAdv1.Height - 3;
            this.panel1.Location = new Point(this.panel1.Location.X, this.ribbonControlAdv1.Location.Y + this.ribbonControlAdv1.Height);
            this.ribbonControlAdv1.RibbonStyle = RibbonStyle.TouchStyle;
            this.trackBarItem1.TrackBarExControl.ValueChanged += new EventHandler(TrackBarExControl_ValueChanged);

            this.buttonAdv1.MouseDown += new MouseEventHandler(buttonAdv1_MouseDown);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.panel1.Controls.Add(this.picpanel);
            this.picpanel.BackColor = Color.White;
            this.picpanel.Dock = DockStyle.Fill;
            this.picpanel.Controls.Add(this.panel3);
            this.panel3.Dock = DockStyle.Fill;
            this.picpanel.Padding = new Padding(this.panel2.Width +100,  100 - this.statusStripEx1.Height,100,100);
            this.panel4.Height = this.Height;

        }

        void TrackBarExControl_ValueChanged(object sender, EventArgs e)
        {
            this.toolStripStatusLabel1.Text = this.trackBarItem1.TrackBarExControl.Value.ToString() + "%";
        }

        void buttonAdv1_MouseDown(object sender, MouseEventArgs e)
        {
            this.panel4.Visible = false;
        }
        
        private void menucolor(Color menucol)
        {
            TouchStylecolor.HeaderColor = ColorTranslator.FromHtml("#d24726");
            TouchStylecolor.BackStageButtonColor = ColorTranslator.FromHtml("#0272c5");
            TouchStylecolor.BackStageTabColor = ColorTranslator.FromHtml("#0272c5");
            TouchStylecolor.ToolStripBorderColor = ColorTranslator.FromHtml("#0272c5");
            TouchStylecolor.ToolstripTabItemBorder = ColorTranslator.FromHtml("#0272c5");
            TouchStylecolor.BottomToolStripBackColor = ColorTranslator.FromHtml("#0272c5");
            this.ribbonControlAdv1.MenuColor = ColorTranslator.FromHtml("#0272c5");
        }
        private void applycolor(Color hovercol)
        {
            TouchStylecolor.MenuButtonHoverArrowColor = ColorTranslator.FromHtml("#2a8dd4");
            TouchStylecolor.BackStageButtonHoverColor = ColorTranslator.FromHtml("#2a8dd4");
            TouchStylecolor.BackStageTabHoverColor = ColorTranslator.FromHtml("#2a8dd4");
        }
        private void Form1_Resize(object sender, EventArgs e)
        {
            this.panel4.Height = this.Height;
            this.panel4.Visible = false;
        }

        private void listView1_MouseLeave_1(object sender, EventArgs e)
        {
            Control list = (sender as ListView);
            list.BackColor = Color.Empty;
        }

        private void listView1_MouseHover(object sender, EventArgs e)
        {
            Control list = (sender as ListView);
            Control pic = (sender as PictureBox);
            if(list!=null || pic !=null)
            list.BackColor = Color.HotPink;
        }

        private void hubTile1_Click(object sender, EventArgs e)
        {
            this.panel3.BackgroundImage = this.hubTile1.ImageSource;
        }     

        private void toolStripButton20_Click(object sender, EventArgs e)
        {
            Image backgroundimage = this.hubTile1.ImageSource;
            HubTile hub = new HubTile();
            this.panel2.Controls.Add(hub);
            hub.Location = new Point(x, y);
            x = 15;
            y = y + 108;
            hub.Size = new Size(163, 100);
            foreach (HubTile ctrl in this.panel2.Controls)
            {
                ctrl.ImageSource = backgroundimage;

            }
        }

        private void buttonAdv1_Click(object sender, EventArgs e)
        {
            this.panel4.Visible = false;
        }

        int slidenumber = 2;
        private void toolStripButton16_Click(object sender, EventArgs e)
        {
            Image backgroundimage = this.hubTile1.ImageSource;
            Label slidelabel = new Label();
            HubTile hub = new HubTile();
            this.panel2.Controls.Add(slidelabel);
            slidelabel.Text = slidenumber.ToString();
            slidelabel.ForeColor = ColorTranslator.FromHtml("#d24726");
            
            slidelabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            slidelabel.AutoSize = true;
            slidenumber++;
            this.panel2.Controls.Add(hub);
            hub.Location = new Point(x, y);
            slidelabel.Location = new Point(x-20, y);
            x = 28;
            y = y + 108;

            hub.Size = new Size(165, 100);
            foreach (Control ctrl in this.panel2.Controls)
            {
                if (ctrl is HubTile)
                    (ctrl as HubTile).ImageSource = backgroundimage;
            }
        }
        
    }
    public class RichTextBoxAdv : RichTextBox
    {
        public bool drag = false;
        public bool enab = false;
        private int m_opacity = 100;
        private int alpha;
        public RichTextBoxAdv()
        {
            SetStyle(ControlStyles.SupportsTransparentBackColor , true);
            SetStyle(ControlStyles.Opaque, true);
            this.BackColor = Color.Transparent;
        }
        public int Opacity
        {
            get
            {
                if (m_opacity > 100)
                {
                    m_opacity = 100;
                }
                else if (m_opacity < 1)
                {
                    m_opacity = 1;
                }
                return this.m_opacity;
            }
            set
            {
                this.m_opacity = value;
                if (this.Parent != null)
                {
                    Parent.Invalidate(this.Bounds, true);
                }
            }
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle = cp.ExStyle | 0x20;
                return cp;
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Rectangle bounds = new Rectangle(0, 0, this.Width - 1, this.Height - 1);

            Color frmColor = this.Parent.BackColor;
            Brush bckColor = default(Brush);

            alpha = (m_opacity * 255) / 100;

            if (drag)
            {
                Color dragBckColor = default(Color);

                if (BackColor != Color.Transparent)
                {
                    int Rb = BackColor.R * alpha / 255 + frmColor.R * (255 - alpha) / 255;
                    int Gb = BackColor.G * alpha / 255 + frmColor.G * (255 - alpha) / 255;
                    int Bb = BackColor.B * alpha / 255 + frmColor.B * (255 - alpha) / 255;
                    dragBckColor = Color.FromArgb(Rb, Gb, Bb);
                }
                else
                {
                    dragBckColor = frmColor;
                }

                alpha = 255;
                bckColor = new SolidBrush(Color.FromArgb(alpha, dragBckColor));
            }
            else
            {
                bckColor = new SolidBrush(Color.FromArgb(alpha, this.BackColor));
            }

            if (this.BackColor != Color.Transparent | drag)
            {
                g.FillRectangle(bckColor, bounds);
            }

            bckColor.Dispose();
            g.Dispose();
            base.OnPaint(e);
        }

        protected override void OnBackColorChanged(EventArgs e)
        {
            if (this.Parent != null)
            {
                Parent.Invalidate(this.Bounds, true);
            }
            base.OnBackColorChanged(e);
        }

        protected override void OnParentBackColorChanged(EventArgs e)
        {
            this.Invalidate();
            base.OnParentBackColorChanged(e);
        }

    }
 }



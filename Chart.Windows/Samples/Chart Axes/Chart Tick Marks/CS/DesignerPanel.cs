using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Windows.Forms;
using Syncfusion.Windows.Forms.Tools;
using Syncfusion.Drawing;


	/// <summary>
	/// DesignerPanel, a GradientPanel with Header.
	/// </summary>
	public class DesignerPanel : GradientPanel
    {
        #region Private Members
      	private System.ComponentModel.Container components = null;
		private Image headerImage;
        private String headerText;
        GradientPanel TopPanel = new GradientPanel();
        Label TextLabel = new Label();
        Color[] color = new Color[] { Color.FromArgb(201, 220, 237), Color.FromArgb(218, 230, 242), Color.FromArgb(227, 236, 243), Color.FromArgb(232, 239, 245), Color.FromArgb(241, 245, 248) };
#endregion

        #region Constructor and Dispose
        public DesignerPanel()
		{
			InitializeComponent();
		}
        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }
		#endregion

        #region InitializeComponent

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
       private void InitializeComponent()
		{
			components = new System.ComponentModel.Container();

            this.BackColor = Color.White;
            this.BorderColor = Color.FromArgb(209, 220, 231);
            this.BorderStyle = BorderStyle.FixedSingle;
            this.Size = new System.Drawing.Size(190, 150);
            this.headerText = "PanelText";
            this.BackgroundColor = new BrushInfo(GradientStyle.Vertical, color);
           
            this.TopPanel.BackgroundColor = this.BackgroundColor;
            this.TopPanel.BorderColor = this.BorderColor;
            this.TopPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "gradientPanel1";
            this.TopPanel.Size = new System.Drawing.Size(188, 26);

            this.TextLabel.Text = this.headerText;
            this.TextLabel.TextAlign = ContentAlignment.MiddleLeft;
            this.TextLabel.ImageAlign = ContentAlignment.MiddleLeft;
            this.TextLabel.Dock = DockStyle.Fill;
            this.TextLabel.BackColor = Color.Transparent;
          

            this.TopPanel.Controls.Add(TextLabel);
            this.TopPanel.TabIndex = 0;
            this.Controls.Add(TopPanel);

        }
#endregion

        #region Properties and events
        [Category("Appearance"),
        Description("HeaderText of the panel")]
        public String HeaderText
        {
            get
            {
                return headerText;
            }
            set
            {
                this.headerText = value;
                this.TextLabel.Text = this.headerText;
                Invalidate();
            }
        }

        [Category("Appearance"),
        Description("Header image of the panel")]
        public Image HeaderImage
        {
            get
            {
                return headerImage;
            }

            set
            {
                this.headerImage = value;
                this.TextLabel.Image = this.headerImage;
                Invalidate();
            }
        }
        protected override void OnPaint(System.Windows.Forms.PaintEventArgs e)
        {
            this.TopPanel.BackgroundColor = this.BackgroundColor;
            this.TopPanel.BorderColor = this.BorderColor;
        }
        #endregion
    }

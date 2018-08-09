using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using Syncfusion.Windows.Forms;
using System.Runtime.InteropServices;
using Syncfusion.Licensing;
using System.IO;

namespace ProgressBarAdvProperties
{
    /// <summary>
    /// Summary description for Form1.
    /// </summary>
    public class Form1 : MetroForm
    {
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.GroupBox groupBox2;
        private Syncfusion.Windows.Forms.Tools.CheckBoxAdv checkBoxAdv2;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv comboBoxAdv1;
        private Syncfusion.Windows.Forms.Tools.CheckBoxAdv checkBoxAdv1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox5;
        private Syncfusion.Windows.Forms.ButtonAdv buttonAdv2;
        private Syncfusion.Windows.Forms.ButtonAdv buttonAdv1;
        private Syncfusion.Windows.Forms.Tools.ProgressBarAdv progressBarAdv1;
        private System.ComponentModel.IContainer components;
        private Label label7;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv comboBoxAdv2;
        private Label label8;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv comboBoxAdv3;
        bool Start;

        [DllImport("user32.dll")]
        static extern bool LockWindowUpdate(IntPtr hWndLock);

        public Form1()
        {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();
            this.comboBoxAdv2.SelectedIndexChanged += ComboBoxAdv2_SelectedIndexChanged;
            this.comboBoxAdv3.SelectedIndexChanged += ComboBoxAdv3_SelectedIndexChanged;      
            this.MinimumSize = this.Size;
            try
            {
                System.Drawing.Icon ico = new System.Drawing.Icon(GetIconFile(@"common\Images\Grid\Icon\sfgrid.ico"));
                this.Icon = ico;
            }
            catch { }

            this.comboBoxAdv2.SelectedIndex = 9;
            //this.comboBoxAdv1.DataSource = Enum.GetValues(typeof (Syncfusion.Windows.Forms.Tools.ProgressBarTextStyles)); 
        }

        private void ComboBoxAdv3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.comboBoxAdv3.SelectedIndex == 0)
            {
                this.progressBarAdv1.TextAlignment = Syncfusion.Windows.Forms.Tools.TextAlignment.Left;
            }
            else if (this.comboBoxAdv3.SelectedIndex == 1)
            {
                this.progressBarAdv1.TextAlignment = Syncfusion.Windows.Forms.Tools.TextAlignment.Center;
            }
            else if (this.comboBoxAdv3.SelectedIndex == 2)
            {
                this.progressBarAdv1.TextAlignment = Syncfusion.Windows.Forms.Tools.TextAlignment.Right;
            }            
        }

        private void ComboBoxAdv2_SelectedIndexChanged(object sender, EventArgs e)
        {           
            if (this.comboBoxAdv2.SelectedIndex == 0)
            {
                this.progressBarAdv1.ProgressStyle = Syncfusion.Windows.Forms.Tools.ProgressBarStyles.Gradient;
            }
            else if (this.comboBoxAdv2.SelectedIndex == 1)
            {
                this.progressBarAdv1.ProgressStyle = Syncfusion.Windows.Forms.Tools.ProgressBarStyles.WaitingGradient;
            }
            else if (this.comboBoxAdv2.SelectedIndex == 2)
            {
                this.progressBarAdv1.ProgressStyle = Syncfusion.Windows.Forms.Tools.ProgressBarStyles.MultipleGradient;
            }
            else if (this.comboBoxAdv2.SelectedIndex == 3)
            {
                this.progressBarAdv1.ProgressStyle = Syncfusion.Windows.Forms.Tools.ProgressBarStyles.Tube;
            }
            else if(this.comboBoxAdv2.SelectedIndex == 4)
            {
                this.progressBarAdv1.ProgressStyle = Syncfusion.Windows.Forms.Tools.ProgressBarStyles.Image;
            }
            else if (this.comboBoxAdv2.SelectedIndex == 5)
            {
                this.progressBarAdv1.ProgressStyle = Syncfusion.Windows.Forms.Tools.ProgressBarStyles.System;
            }
            else if (this.comboBoxAdv2.SelectedIndex == 6)
            {
                this.progressBarAdv1.ProgressStyle = Syncfusion.Windows.Forms.Tools.ProgressBarStyles.Custom;
            }
            else if (this.comboBoxAdv2.SelectedIndex == 7)
            {
                this.progressBarAdv1.ProgressStyle = Syncfusion.Windows.Forms.Tools.ProgressBarStyles.Constant;
            }
            else if (this.comboBoxAdv2.SelectedIndex == 8)
            {
                this.progressBarAdv1.ProgressStyle = Syncfusion.Windows.Forms.Tools.ProgressBarStyles.Metro;
            }
            else if (this.comboBoxAdv2.SelectedIndex == 9)
            {
                this.progressBarAdv1.ProgressStyle = Syncfusion.Windows.Forms.Tools.ProgressBarStyles.Office2016Colorful;
            }
            else if (this.comboBoxAdv2.SelectedIndex == 10)
            {
                this.progressBarAdv1.ProgressStyle = Syncfusion.Windows.Forms.Tools.ProgressBarStyles.Office2016White;
            }
            else if (this.comboBoxAdv2.SelectedIndex == 11)
            {
                this.progressBarAdv1.ProgressStyle = Syncfusion.Windows.Forms.Tools.ProgressBarStyles.Office2016DarkGray;
            }
            else if (this.comboBoxAdv2.SelectedIndex ==12)
            {
                this.progressBarAdv1.ProgressStyle = Syncfusion.Windows.Forms.Tools.ProgressBarStyles.Office2016Black;
            }

            UpdateProgressBarStyleforOffice2016Themes();
        }

        private void UpdateProgressBarStyleforOffice2016Themes()
        {
            LockWindowUpdate(this.Handle);

            if (this.progressBarAdv1.ProgressStyle == Syncfusion.Windows.Forms.Tools.ProgressBarStyles.Office2016Colorful)
            {
                this.CaptionBarColor = ColorTranslator.FromHtml("#0173c7");
                this.CaptionForeColor = ColorTranslator.FromHtml("#ffffff");
                this.ShowIcon = false;
                this.BackColor = ColorTranslator.FromHtml("#ffffff");
                this.ForeColor = ColorTranslator.FromHtml("#262626");
                this.comboBoxAdv2.Style = VisualStyle.Office2016Colorful;
                this.comboBoxAdv1.Style = VisualStyle.Office2016Colorful;
                this.comboBoxAdv3.Style = VisualStyle.Office2016Colorful;
                this.checkBoxAdv1.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Office2016Colorful;
                this.checkBoxAdv2.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Office2016Colorful;
                this.buttonAdv1.Appearance = ButtonAppearance.Office2016Colorful;
                this.buttonAdv2.Appearance = ButtonAppearance.Office2016Colorful;               
                this.label1.ForeColor = ColorTranslator.FromHtml("#262626");
                this.label2.ForeColor = ColorTranslator.FromHtml("#262626");
                this.label3.ForeColor = ColorTranslator.FromHtml("#262626");
                this.label7.ForeColor = ColorTranslator.FromHtml("#262626");
                this.groupBox2.ForeColor = ColorTranslator.FromHtml("#262626");
                this.groupBox2.BackColor = ColorTranslator.FromHtml("#ffffff");
                this.groupBox5.ForeColor = ColorTranslator.FromHtml("#262626");
                this.groupBox5.BackColor = ColorTranslator.FromHtml("#ffffff");
                this.BorderColor = ColorTranslator.FromHtml("#c5c5c5");
            }
            else if (this.progressBarAdv1.ProgressStyle == Syncfusion.Windows.Forms.Tools.ProgressBarStyles.Office2016White)
            {
                this.ShowIcon = false;
                this.BackColor = ColorTranslator.FromHtml("#ffffff");
                this.ForeColor = ColorTranslator.FromHtml("#262626");
                this.CaptionBarColor = ColorTranslator.FromHtml("#ffffff");
                this.CaptionForeColor = ColorTranslator.FromHtml("#262626");
                this.comboBoxAdv2.Style = VisualStyle.Office2016White;
                this.comboBoxAdv1.Style = VisualStyle.Office2016White;
                this.comboBoxAdv3.Style = VisualStyle.Office2016White;
                this.checkBoxAdv1.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Office2016White;
                this.checkBoxAdv2.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Office2016White;
                this.buttonAdv1.Appearance = ButtonAppearance.Office2016White;
                this.buttonAdv2.Appearance = ButtonAppearance.Office2016White;
                this.label1.ForeColor = ColorTranslator.FromHtml("#262626");
                this.label2.ForeColor = ColorTranslator.FromHtml("#262626");
                this.label3.ForeColor = ColorTranslator.FromHtml("#262626");
                this.label7.ForeColor = ColorTranslator.FromHtml("#262626");
                this.groupBox2.ForeColor = ColorTranslator.FromHtml("#262626");
                this.groupBox2.BackColor = ColorTranslator.FromHtml("#ffffff");
                this.groupBox5.ForeColor = ColorTranslator.FromHtml("#262626");
                this.groupBox5.BackColor = ColorTranslator.FromHtml("#ffffff");
                this.BorderColor = ColorTranslator.FromHtml("#c5c5c5");
            }
            else if (this.progressBarAdv1.ProgressStyle == Syncfusion.Windows.Forms.Tools.ProgressBarStyles.Office2016DarkGray)
            {
                this.CaptionBarColor = ColorTranslator.FromHtml("#505050");
                this.CaptionForeColor = ColorTranslator.FromHtml("#f0f0f0");
                this.ShowIcon = false;
                this.BackColor = ColorTranslator.FromHtml("#666666");
                this.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                this.comboBoxAdv2.Style = VisualStyle.Office2016DarkGray;
                this.comboBoxAdv1.Style = VisualStyle.Office2016DarkGray;
                this.comboBoxAdv3.Style = VisualStyle.Office2016DarkGray;                
                this.checkBoxAdv1.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Office2016DarkGray;                
                this.checkBoxAdv2.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Office2016DarkGray;                
                this.buttonAdv1.Appearance = ButtonAppearance.Office2016DarkGray;
                this.buttonAdv2.Appearance = ButtonAppearance.Office2016DarkGray;
                this.label1.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                this.label2.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                this.label3.ForeColor = ColorTranslator.FromHtml("#f0f0f0");                
                this.label7.ForeColor = ColorTranslator.FromHtml("#f0f0f0");                
                this.groupBox2.BackColor = ColorTranslator.FromHtml("#666666");
                this.groupBox2.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                this.groupBox5.BackColor = ColorTranslator.FromHtml("#666666");
                this.groupBox5.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                this.BorderColor = ColorTranslator.FromHtml("#444444");
            }
            else if (this.progressBarAdv1.ProgressStyle == Syncfusion.Windows.Forms.Tools.ProgressBarStyles.Office2016Black)
            {
                this.CaptionBarColor = ColorTranslator.FromHtml("#363636");
                this.CaptionForeColor = ColorTranslator.FromHtml("#f0f0f0");
                this.ShowIcon = false;
                this.BackColor = ColorTranslator.FromHtml("#262626");
                this.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                this.comboBoxAdv2.Style = VisualStyle.Office2016Black;
                this.comboBoxAdv1.Style = VisualStyle.Office2016Black;
                this.comboBoxAdv3.Style = VisualStyle.Office2016Black;                
                this.checkBoxAdv1.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Office2016Black;                
                this.checkBoxAdv2.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Office2016Black;                
                this.buttonAdv1.Appearance = ButtonAppearance.Office2016Black;
                this.buttonAdv2.Appearance = ButtonAppearance.Office2016Black;
                this.label1.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                this.label2.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                this.label3.ForeColor = ColorTranslator.FromHtml("#f0f0f0");                
                this.label7.ForeColor = ColorTranslator.FromHtml("#f0f0f0");                
                this.groupBox2.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                this.groupBox2.BackColor = ColorTranslator.FromHtml("#262626");
                this.groupBox5.ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                this.groupBox5.BackColor = ColorTranslator.FromHtml("#262626");
                this.BorderColor = ColorTranslator.FromHtml("#363636");
            }
            else
            {
                this.ShowIcon = true;
                this.CaptionBarColor = Color.White;
                this.CaptionForeColor = Color.FromArgb(52, 52, 52);                
                this.comboBoxAdv2.Style = VisualStyle.Metro;
                this.comboBoxAdv1.Style = VisualStyle.Metro;
                this.comboBoxAdv3.Style = VisualStyle.Metro;
                this.checkBoxAdv1.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;                
                this.checkBoxAdv2.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;                
                this.label1.ForeColor = SystemColors.ControlText;
                this.label2.ForeColor = SystemColors.ControlText;
                this.label3.ForeColor = SystemColors.ControlText;                
                this.label7.ForeColor = SystemColors.ControlText;                
                this.groupBox2.ForeColor = SystemColors.ControlText;
                this.groupBox2.BackColor = Color.White;
                this.groupBox5.ForeColor = SystemColors.ControlText;
                this.groupBox5.BackColor = Color.White;
                this.BackColor = Color.White;
                this.ForeColor = SystemColors.ControlText;
                this.buttonAdv1.Appearance = ButtonAppearance.Metro;
                this.buttonAdv2.Appearance = ButtonAppearance.Metro;
                this.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            }

            LockWindowUpdate(IntPtr.Zero);
        }

        private string GetIconFile(string bitmapName)
        {
            for (int n = 0; n < 10; n++)
            {
                if (System.IO.File.Exists(bitmapName))
                    return bitmapName;

                bitmapName = @"..\" + bitmapName;
            }

            return bitmapName;
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

        #region Windows Form Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBoxAdv3 = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.comboBoxAdv2 = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.label7 = new System.Windows.Forms.Label();
            this.checkBoxAdv2 = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.comboBoxAdv1 = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.checkBoxAdv1 = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.progressBarAdv1 = new Syncfusion.Windows.Forms.Tools.ProgressBarAdv();
            this.buttonAdv1 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.buttonAdv2 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxAdv3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxAdv2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxAdv2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxAdv1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxAdv1)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.progressBarAdv1)).BeginInit();
            this.SuspendLayout();
            // 
            // Timer
            // 
            this.Timer.Enabled = true;
            this.Timer.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.comboBoxAdv3);
            this.groupBox2.Controls.Add(this.comboBoxAdv2);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.checkBoxAdv2);
            this.groupBox2.Controls.Add(this.comboBoxAdv1);
            this.groupBox2.Controls.Add(this.checkBoxAdv1);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(334, 10);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(312, 382);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Text Properties";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(18, 159);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 14);
            this.label8.TabIndex = 18;
            this.label8.Text = "Text Orientation";
            // 
            // comboBoxAdv3
            // 
            this.comboBoxAdv3.BackColor = System.Drawing.Color.White;
            this.comboBoxAdv3.BeforeTouchSize = new System.Drawing.Size(154, 22);
            this.comboBoxAdv3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAdv3.Font = new System.Drawing.Font("Arial", 8.25F);
            this.comboBoxAdv3.Items.AddRange(new object[] {
            "Left",
            "Center",
            "Right"});
            this.comboBoxAdv3.Location = new System.Drawing.Point(136, 155);
            this.comboBoxAdv3.Name = "comboBoxAdv3";
            this.comboBoxAdv3.Size = new System.Drawing.Size(154, 22);
            this.comboBoxAdv3.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.comboBoxAdv3.TabIndex = 17;
            this.comboBoxAdv3.Text = "Left";
            // 
            // comboBoxAdv2
            // 
            this.comboBoxAdv2.BackColor = System.Drawing.Color.White;
            this.comboBoxAdv2.BeforeTouchSize = new System.Drawing.Size(154, 22);
            this.comboBoxAdv2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAdv2.Font = new System.Drawing.Font("Arial", 8.25F);
            this.comboBoxAdv2.Items.AddRange(new object[] {
            "Gradient",
            "WaitingGradient",
            "MultipleGradient",
            "Tube",
            "Image",
            "System",
            "Custom",
            "Constant",
            "Metro",
            "Office2016Colorful",
            "Office2016White",
            "Office2016DarkGray",
            "Office2016Black"});
            this.comboBoxAdv2.Location = new System.Drawing.Point(135, 197);
            this.comboBoxAdv2.Name = "comboBoxAdv2";
            this.comboBoxAdv2.Size = new System.Drawing.Size(154, 22);
            this.comboBoxAdv2.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.comboBoxAdv2.TabIndex = 14;
            this.comboBoxAdv2.Text = "Gradient";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(20, 201);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 14);
            this.label7.TabIndex = 13;
            this.label7.Text = "Style";
            // 
            // checkBoxAdv2
            // 
            this.checkBoxAdv2.BeforeTouchSize = new System.Drawing.Size(150, 21);
            this.checkBoxAdv2.DrawFocusRectangle = false;
            this.checkBoxAdv2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxAdv2.Location = new System.Drawing.Point(135, 117);
            this.checkBoxAdv2.MetroColor = System.Drawing.Color.DarkGray;
            this.checkBoxAdv2.Name = "checkBoxAdv2";
            this.checkBoxAdv2.Size = new System.Drawing.Size(52, 17);
            this.checkBoxAdv2.StretchImage = false;
            this.checkBoxAdv2.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.checkBoxAdv2.TabIndex = 10;
            this.checkBoxAdv2.Text = "Yes";
            this.checkBoxAdv2.ThemesEnabled = false;
            this.checkBoxAdv2.CheckStateChanged += new System.EventHandler(this.checkBoxAdv2_CheckStateChanged);
            // 
            // comboBoxAdv1
            // 
            this.comboBoxAdv1.BackColor = System.Drawing.Color.White;
            this.comboBoxAdv1.BeforeTouchSize = new System.Drawing.Size(154, 22);
            this.comboBoxAdv1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAdv1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxAdv1.Items.AddRange(new object[] {
            "Percentage",
            "Value",
            "CustomText"});
            this.comboBoxAdv1.Location = new System.Drawing.Point(137, 73);
            this.comboBoxAdv1.MetroColor = System.Drawing.Color.DarkGray;
            this.comboBoxAdv1.Name = "comboBoxAdv1";
            this.comboBoxAdv1.Size = new System.Drawing.Size(154, 22);
            this.comboBoxAdv1.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.comboBoxAdv1.TabIndex = 6;
            this.comboBoxAdv1.Text = "Percentage";
            this.comboBoxAdv1.SelectedIndexChanged += new System.EventHandler(this.comboBoxAdv1_SelectedIndexChanged);
            // 
            // checkBoxAdv1
            // 
            this.checkBoxAdv1.BeforeTouchSize = new System.Drawing.Size(150, 21);
            this.checkBoxAdv1.DrawFocusRectangle = false;
            this.checkBoxAdv1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxAdv1.Location = new System.Drawing.Point(136, 33);
            this.checkBoxAdv1.MetroColor = System.Drawing.Color.DarkGray;
            this.checkBoxAdv1.Name = "checkBoxAdv1";
            this.checkBoxAdv1.Size = new System.Drawing.Size(52, 17);
            this.checkBoxAdv1.StretchImage = false;
            this.checkBoxAdv1.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.checkBoxAdv1.TabIndex = 5;
            this.checkBoxAdv1.Text = "Yes";
            this.checkBoxAdv1.ThemesEnabled = false;
            this.checkBoxAdv1.CheckStateChanged += new System.EventHandler(this.checkBoxAdv1_CheckStateChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 14);
            this.label3.TabIndex = 2;
            this.label3.Text = "Text Shadow";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 14);
            this.label2.TabIndex = 1;
            this.label2.Text = "Text Style";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "Text Visible";
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox5.Controls.Add(this.progressBarAdv1);
            this.groupBox5.Controls.Add(this.buttonAdv1);
            this.groupBox5.Controls.Add(this.buttonAdv2);
            this.groupBox5.Location = new System.Drawing.Point(10, 10);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(312, 382);
            this.groupBox5.TabIndex = 8;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Demo";
            // 
            // progressBarAdv1
            // 
            this.progressBarAdv1.BackgroundFallbackStyle = Syncfusion.Windows.Forms.Tools.ProgressBarBackgroundStyles.VerticalGradient;
            this.progressBarAdv1.BackgroundStyle = Syncfusion.Windows.Forms.Tools.ProgressBarBackgroundStyles.Office2016Colorful;
            this.progressBarAdv1.BackMultipleColors = new System.Drawing.Color[] {
        System.Drawing.Color.Red};
            this.progressBarAdv1.BackSegments = false;
            this.progressBarAdv1.BackTubeEndColor = System.Drawing.Color.White;
            this.progressBarAdv1.BackTubeStartColor = System.Drawing.Color.White;
            this.progressBarAdv1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.progressBarAdv1.CustomText = "Loading";
            this.progressBarAdv1.CustomWaitingRender = false;
            this.progressBarAdv1.ForegroundImage = null;
            this.progressBarAdv1.ForeSegments = false;
            this.progressBarAdv1.Location = new System.Drawing.Point(29, 90);
            this.progressBarAdv1.MultipleColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128))))),
        System.Drawing.Color.Blue,
        System.Drawing.Color.Magenta};
            this.progressBarAdv1.Name = "progressBarAdv1";
            this.progressBarAdv1.ProgressStyle = Syncfusion.Windows.Forms.Tools.ProgressBarStyles.Gradient;
            this.progressBarAdv1.SegmentWidth = 2;
            this.progressBarAdv1.Size = new System.Drawing.Size(248, 24);
            this.progressBarAdv1.TabIndex = 0;
            this.progressBarAdv1.Text = "progressBarAdv1";
            this.progressBarAdv1.TextShadow = false;
            this.progressBarAdv1.TextStyle = Syncfusion.Windows.Forms.Tools.ProgressBarTextStyles.Value;
            this.progressBarAdv1.ThemesEnabled = false;
            this.progressBarAdv1.TubeEndColor = System.Drawing.Color.RosyBrown;
            this.progressBarAdv1.TubeStartColor = System.Drawing.Color.Lime;
            this.progressBarAdv1.Value = 100;
            this.progressBarAdv1.WaitingGradientInterval = 1;
            this.progressBarAdv1.WaitingGradientWidth = 9000;
            // 
            // buttonAdv1
            // 
            this.buttonAdv1.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.buttonAdv1.BackColor = System.Drawing.Color.Silver;
            this.buttonAdv1.BeforeTouchSize = new System.Drawing.Size(75, 23);
            this.buttonAdv1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdv1.ForeColor = System.Drawing.Color.White;
            this.buttonAdv1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAdv1.IsBackStageButton = false;
            this.buttonAdv1.KeepFocusRectangle = false;
            this.buttonAdv1.Location = new System.Drawing.Point(64, 160);
            this.buttonAdv1.Name = "buttonAdv1";
            this.buttonAdv1.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Silver;
            this.buttonAdv1.Size = new System.Drawing.Size(75, 23);
            this.buttonAdv1.TabIndex = 1;
            this.buttonAdv1.Text = "START";
            this.buttonAdv1.UseVisualStyle = true;
            this.buttonAdv1.Click += new System.EventHandler(this.buttonAdv1_Click);
            // 
            // buttonAdv2
            // 
            this.buttonAdv2.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.buttonAdv2.BackColor = System.Drawing.Color.Silver;
            this.buttonAdv2.BeforeTouchSize = new System.Drawing.Size(75, 23);
            this.buttonAdv2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdv2.ForeColor = System.Drawing.Color.White;
            this.buttonAdv2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAdv2.IsBackStageButton = false;
            this.buttonAdv2.KeepFocusRectangle = false;
            this.buttonAdv2.Location = new System.Drawing.Point(160, 160);
            this.buttonAdv2.Name = "buttonAdv2";
            this.buttonAdv2.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Silver;
            this.buttonAdv2.Size = new System.Drawing.Size(75, 23);
            this.buttonAdv2.TabIndex = 2;
            this.buttonAdv2.Text = "STOP";
            this.buttonAdv2.UseVisualStyle = true;
            this.buttonAdv2.Click += new System.EventHandler(this.buttonAdv2_Click);
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 15);
            this.BackColor = System.Drawing.Color.White;
            this.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.ClientSize = new System.Drawing.Size(656, 402);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox5);
            this.DropShadow = true;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProgressBar Features";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxAdv3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxAdv2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxAdv2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxAdv1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxAdv1)).EndInit();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.progressBarAdv1)).EndInit();
            this.ResumeLayout(false);

        }

       

        #endregion

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            SyncfusionLicenseProvider.RegisterLicense(DemoCommon.FindLicenseKey());
            Application.Run(new Form1());
        }

        void Form1_Load(object sender, EventArgs e)
        {
            this.comboBoxAdv1.SelectedIndex = 1;            
        }

        #region Start        
        private void buttonAdv2_Click(object sender, System.EventArgs e)
        {
            Start = false;
        }
        private void buttonAdv1_Click(object sender, System.EventArgs e)
        {
            Start = true;
        }
        #endregion
        
        #region TextShadow
        private void checkBoxAdv2_CheckStateChanged(object sender, System.EventArgs e)
        {
            this.progressBarAdv1.TextShadow = this.checkBoxAdv2.Checked;
        }
        #endregion

        #region TextVisible
        private void checkBoxAdv1_CheckStateChanged(object sender, System.EventArgs e)
        {
            this.progressBarAdv1.TextVisible = this.checkBoxAdv1.Checked;
        }
        #endregion
        
        #region TextStyle
        private void comboBoxAdv1_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (this.comboBoxAdv1.SelectedIndex == 0)
            {
                this.progressBarAdv1.TextStyle = Syncfusion.Windows.Forms.Tools.ProgressBarTextStyles.Percentage;
            }
            if (this.comboBoxAdv1.SelectedIndex == 1)
            {
                this.progressBarAdv1.TextStyle = Syncfusion.Windows.Forms.Tools.ProgressBarTextStyles.Value;
            }
            if (this.comboBoxAdv1.SelectedIndex == 2)
            {
                this.progressBarAdv1.TextStyle = Syncfusion.Windows.Forms.Tools.ProgressBarTextStyles.Custom;
            }

        }
        #endregion      

        #region timer
        private void timer2_Tick(object sender, System.EventArgs e)
        {

            if (Start)
            {
                if (this.progressBarAdv1.Value < 100)
                    this.progressBarAdv1.Value++;
                else
                {
                    this.progressBarAdv1.Value = 0;

                    if (this.comboBoxAdv2.SelectedIndex == 0)
                    {
                        this.progressBarAdv1.ProgressStyle = Syncfusion.Windows.Forms.Tools.ProgressBarStyles.Gradient;
                    }
                    else if (this.comboBoxAdv2.SelectedIndex == 1)
                    {
                        this.progressBarAdv1.ProgressStyle = Syncfusion.Windows.Forms.Tools.ProgressBarStyles.WaitingGradient;
                    }
                    else if (this.comboBoxAdv2.SelectedIndex == 2)
                    {
                        this.progressBarAdv1.ProgressStyle = Syncfusion.Windows.Forms.Tools.ProgressBarStyles.MultipleGradient;
                    }
                    else if (this.comboBoxAdv2.SelectedIndex == 3)
                    {
                        this.progressBarAdv1.ProgressStyle = Syncfusion.Windows.Forms.Tools.ProgressBarStyles.Tube;
                    }
                    else if (this.comboBoxAdv2.SelectedIndex == 4)
                    {
                        this.progressBarAdv1.ProgressStyle = Syncfusion.Windows.Forms.Tools.ProgressBarStyles.Image;
                    }
                    else if (this.comboBoxAdv2.SelectedIndex == 5)
                    {
                        this.progressBarAdv1.ProgressStyle = Syncfusion.Windows.Forms.Tools.ProgressBarStyles.System;
                    }
                    else if (this.comboBoxAdv2.SelectedIndex == 6)
                    {
                        this.progressBarAdv1.ProgressStyle = Syncfusion.Windows.Forms.Tools.ProgressBarStyles.Custom;
                    }
                    else if (this.comboBoxAdv2.SelectedIndex == 7)
                    {
                        this.progressBarAdv1.ProgressStyle = Syncfusion.Windows.Forms.Tools.ProgressBarStyles.Constant;
                    }
                    else if (this.comboBoxAdv2.SelectedIndex == 8)
                    {
                        this.progressBarAdv1.ProgressStyle = Syncfusion.Windows.Forms.Tools.ProgressBarStyles.Metro;
                    }
                    else if (this.comboBoxAdv2.SelectedIndex == 9)
                    {
                        this.progressBarAdv1.ProgressStyle = Syncfusion.Windows.Forms.Tools.ProgressBarStyles.Office2016Colorful;
                    }
                    else if (this.comboBoxAdv2.SelectedIndex == 10)
                    {
                        this.progressBarAdv1.ProgressStyle = Syncfusion.Windows.Forms.Tools.ProgressBarStyles.Office2016White;
                    }
                    else if (this.comboBoxAdv2.SelectedIndex == 11)
                    {
                        this.progressBarAdv1.ProgressStyle = Syncfusion.Windows.Forms.Tools.ProgressBarStyles.Office2016DarkGray;
                    }
                    else if (this.comboBoxAdv2.SelectedIndex == 12)
                    {
                        this.progressBarAdv1.ProgressStyle = Syncfusion.Windows.Forms.Tools.ProgressBarStyles.Office2016Black;
                    }
                }
            }
        }
        #endregion
                             
    }

    /// <summary>
    /// Represents a class that is used to find the licensing file for Syncfusion controls.
    /// </summary>
    public class DemoCommon
    {
        /// <summary>
        /// Finds the license key from the Common folder.
        /// </summary>
        /// <returns>Returns the license key.</returns>
        public static string FindLicenseKey()
        {
            string licenseKeyFile = "..\\Common\\SyncfusionLicense.txt";
            for (int n = 0; n < 20; n++)
            {
                if (!System.IO.File.Exists(licenseKeyFile))
                {
                    licenseKeyFile = @"..\" + licenseKeyFile;
                    continue;
                }
                return File.ReadAllText(licenseKeyFile);
            }
            return string.Empty;
        }
    }

}

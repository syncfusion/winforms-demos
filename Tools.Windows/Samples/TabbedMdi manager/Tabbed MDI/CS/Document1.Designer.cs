namespace TabbedMDI_2005
{
    partial class Document1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Document1));
            this.childFrameBarManager1 = new Syncfusion.Windows.Forms.Tools.XPMenus.ChildFrameBarManager(this);
            this.bar1 = new Syncfusion.Windows.Forms.Tools.XPMenus.Bar(this.childFrameBarManager1, "Format Document");
            this.parentBarItem3 = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.parentBarItem1 = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.barItem_SansSerif = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem_times = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem_courier = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.parentBarItem2 = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.barItem4 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem5 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem6 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.comboBoxBarItem1 = new Syncfusion.Windows.Forms.Tools.XPMenus.ComboBoxBarItem();
            this.comboBoxBarItem2 = new Syncfusion.Windows.Forms.Tools.XPMenus.ComboBoxBarItem();
            this.parentBarItem4 = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.scrollersFrame1 = new Syncfusion.Windows.Forms.ScrollersFrame(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.childFrameBarManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxBarItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxBarItem2)).BeginInit();
            this.SuspendLayout();
            // 
            // childFrameBarManager1
            // 
            this.childFrameBarManager1.BarPositionInfo = ((System.IO.MemoryStream)(resources.GetObject("childFrameBarManager1.BarPositionInfo")));
            this.childFrameBarManager1.Bars.Add(this.bar1);
            this.childFrameBarManager1.Categories.Add("Font Face");
            this.childFrameBarManager1.Categories.Add("FontSize");
            this.childFrameBarManager1.Categories.Add("Format Document");
            this.childFrameBarManager1.Categories.Add("FontFormat");
            this.childFrameBarManager1.CurrentBaseFormType = "Syncfusion.Windows.Forms.MetroForm";
            this.childFrameBarManager1.Form = this;
            this.childFrameBarManager1.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.parentBarItem1,
            this.barItem_SansSerif,
            this.barItem_times,
            this.barItem_courier,
            this.parentBarItem2,
            this.barItem4,
            this.barItem5,
            this.barItem6,
            this.parentBarItem3,
            this.comboBoxBarItem1,
            this.comboBoxBarItem2,
            this.parentBarItem4});
            this.childFrameBarManager1.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            // 
            // bar1
            // 
            this.bar1.BarName = "Format Document";
            this.bar1.BarStyle = ((Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle)((((Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.AllowQuickCustomizing | Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.IsMainMenu) 
            | Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.Visible) 
            | Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.DrawDragBorder)));
            this.bar1.Caption = "Format Document";
            this.bar1.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.parentBarItem3});
            this.bar1.Manager = this.childFrameBarManager1;
            // 
            // parentBarItem3
            // 
            this.parentBarItem3.BarName = "parentBarItem3";
            this.parentBarItem3.CategoryIndex = 2;
            this.parentBarItem3.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parentBarItem3.ID = "Format Document";
            this.parentBarItem3.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.parentBarItem1,
            this.parentBarItem2});
            this.parentBarItem3.MergeOrder = 2;
            this.parentBarItem3.MetroColor = System.Drawing.Color.LightSkyBlue;
            this.parentBarItem3.ShowToolTipInPopUp = false;
            this.parentBarItem3.SizeToFit = true;
            this.parentBarItem3.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.parentBarItem3.Text = "Format Document";
            // 
            // parentBarItem1
            // 
            this.parentBarItem1.BarName = "parentBarItem1";
            this.parentBarItem1.CategoryIndex = 0;
            this.parentBarItem1.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parentBarItem1.ID = "Font Face";
            this.parentBarItem1.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.barItem_SansSerif,
            this.barItem_times,
            this.barItem_courier});
            this.parentBarItem1.MetroColor = System.Drawing.Color.LightSkyBlue;
            this.parentBarItem1.ShowToolTipInPopUp = false;
            this.parentBarItem1.SizeToFit = true;
            this.parentBarItem1.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.parentBarItem1.Text = "Font Face";
            // 
            // barItem_SansSerif
            // 
            this.barItem_SansSerif.BarName = "barItem_SansSerif";
            this.barItem_SansSerif.CategoryIndex = 0;
            this.barItem_SansSerif.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem_SansSerif.ID = "Microsoft Sans Serif";
            this.barItem_SansSerif.ShowToolTipInPopUp = false;
            this.barItem_SansSerif.SizeToFit = true;
            this.barItem_SansSerif.Text = "Microsoft Sans Serif";
            this.barItem_SansSerif.Click += new System.EventHandler(this.FormatFont_Clicked);
            // 
            // barItem_times
            // 
            this.barItem_times.BarName = "barItem_times";
            this.barItem_times.CategoryIndex = 0;
            this.barItem_times.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem_times.ID = "Times New Roman";
            this.barItem_times.ShowToolTipInPopUp = false;
            this.barItem_times.SizeToFit = true;
            this.barItem_times.Text = "Times New Roman";
            this.barItem_times.Click += new System.EventHandler(this.FormatFont_Clicked);
            // 
            // barItem_courier
            // 
            this.barItem_courier.BarName = "barItem_courier";
            this.barItem_courier.CategoryIndex = 0;
            this.barItem_courier.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem_courier.ID = "Courier New";
            this.barItem_courier.ShowToolTipInPopUp = false;
            this.barItem_courier.SizeToFit = true;
            this.barItem_courier.Text = "Courier New";
            this.barItem_courier.Click += new System.EventHandler(this.FormatFont_Clicked);
            // 
            // parentBarItem2
            // 
            this.parentBarItem2.BarName = "parentBarItem2";
            this.parentBarItem2.CategoryIndex = 1;
            this.parentBarItem2.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parentBarItem2.ID = "Font Size";
            this.parentBarItem2.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.barItem4,
            this.barItem5,
            this.barItem6});
            this.parentBarItem2.MetroColor = System.Drawing.Color.LightSkyBlue;
            this.parentBarItem2.ShowToolTipInPopUp = false;
            this.parentBarItem2.SizeToFit = true;
            this.parentBarItem2.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.parentBarItem2.Text = "Font Size";
            // 
            // barItem4
            // 
            this.barItem4.BarName = "barItem4";
            this.barItem4.CategoryIndex = 1;
            this.barItem4.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem4.ID = "Small";
            this.barItem4.ShowToolTipInPopUp = false;
            this.barItem4.SizeToFit = true;
            this.barItem4.Text = "Small";
            this.barItem4.Click += new System.EventHandler(this.FormatFont_Clicked);
            // 
            // barItem5
            // 
            this.barItem5.BarName = "barItem5";
            this.barItem5.CategoryIndex = 1;
            this.barItem5.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem5.ID = "Medium";
            this.barItem5.ShowToolTipInPopUp = false;
            this.barItem5.SizeToFit = true;
            this.barItem5.Text = "Medium";
            this.barItem5.Click += new System.EventHandler(this.FormatFont_Clicked);
            // 
            // barItem6
            // 
            this.barItem6.BarName = "barItem6";
            this.barItem6.CategoryIndex = 1;
            this.barItem6.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem6.ID = "Large";
            this.barItem6.ShowToolTipInPopUp = false;
            this.barItem6.SizeToFit = true;
            this.barItem6.Text = "Large";
            this.barItem6.Click += new System.EventHandler(this.FormatFont_Clicked);
            // 
            // comboBoxBarItem1
            // 
            this.comboBoxBarItem1.BarName = "comboBoxBarItem1";
            this.comboBoxBarItem1.CategoryIndex = 3;
            this.comboBoxBarItem1.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxBarItem1.ID = "FontSize";
            this.comboBoxBarItem1.ShowToolTipInPopUp = false;
            this.comboBoxBarItem1.SizeToFit = true;
            this.comboBoxBarItem1.Text = "FontSize";
            // 
            // comboBoxBarItem2
            // 
            this.comboBoxBarItem2.BarName = "comboBoxBarItem2";
            this.comboBoxBarItem2.CategoryIndex = 3;
            this.comboBoxBarItem2.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxBarItem2.ID = "FontFac";
            this.comboBoxBarItem2.ShowToolTipInPopUp = false;
            this.comboBoxBarItem2.SizeToFit = true;
            this.comboBoxBarItem2.Text = "FontFace";
            // 
            // parentBarItem4
            // 
            this.parentBarItem4.BarName = "parentBarItem4";
            this.parentBarItem4.CategoryIndex = 3;
            this.parentBarItem4.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parentBarItem4.ID = "FontFormat";
            this.parentBarItem4.MetroColor = System.Drawing.Color.LightSkyBlue;
            this.parentBarItem4.ShowToolTipInPopUp = false;
            this.parentBarItem4.SizeToFit = true;
            this.parentBarItem4.Text = "FontFormat";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.White;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.richTextBox1.Location = new System.Drawing.Point(0, 0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(292, 266);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // scrollersFrame1
            // 
            this.scrollersFrame1.AttachedTo = this.richTextBox1;
            this.scrollersFrame1.CustomRender = null;
            this.scrollersFrame1.MetroColorScheme = Syncfusion.Windows.Forms.MetroColorScheme.Managed;
            this.scrollersFrame1.SizeGripperVisibility = Syncfusion.Windows.Forms.SizeGripperVisibility.Auto;
            this.scrollersFrame1.VisualStyle = Syncfusion.Windows.Forms.ScrollBarCustomDrawStyles.Metro;
            // 
            // Document1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.CaptionAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ClientSize = new System.Drawing.Size(292, 266);
            this.Controls.Add(this.richTextBox1);
            this.DropShadow = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IconAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.MetroColor = System.Drawing.Color.White;
            this.Name = "Document1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Document1";
            ((System.ComponentModel.ISupportInitialize)(this.childFrameBarManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxBarItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxBarItem2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Syncfusion.Windows.Forms.Tools.XPMenus.ChildFrameBarManager childFrameBarManager1;
        private Syncfusion.Windows.Forms.Tools.XPMenus.Bar bar1;
        private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem parentBarItem3;
        private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem parentBarItem1;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem_SansSerif;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem_times;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem_courier;
        private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem parentBarItem2;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem4;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem5;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem6;
        private Syncfusion.Windows.Forms.Tools.XPMenus.ComboBoxBarItem comboBoxBarItem1;
        private Syncfusion.Windows.Forms.Tools.XPMenus.ComboBoxBarItem comboBoxBarItem2;
        private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem parentBarItem4;
        private System.Windows.Forms.RichTextBox richTextBox1;
        public Syncfusion.Windows.Forms.ScrollersFrame scrollersFrame1;
    }
}
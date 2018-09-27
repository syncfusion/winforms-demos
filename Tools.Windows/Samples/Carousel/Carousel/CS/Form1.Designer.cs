namespace CarouselDemo_2008
{
    partial class Form1
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
            Syncfusion.Windows.Forms.Tools.CarouselImage carouselImage1 = new Syncfusion.Windows.Forms.Tools.CarouselImage();
            Syncfusion.Windows.Forms.Tools.CarouselImage carouselImage2 = new Syncfusion.Windows.Forms.Tools.CarouselImage();
            Syncfusion.Windows.Forms.Tools.CarouselImage carouselImage3 = new Syncfusion.Windows.Forms.Tools.CarouselImage();
            Syncfusion.Windows.Forms.Tools.CarouselImage carouselImage4 = new Syncfusion.Windows.Forms.Tools.CarouselImage();
            Syncfusion.Windows.Forms.Tools.CarouselImage carouselImage5 = new Syncfusion.Windows.Forms.Tools.CarouselImage();
            Syncfusion.Windows.Forms.Tools.CarouselImage carouselImage6 = new Syncfusion.Windows.Forms.Tools.CarouselImage();
            Syncfusion.Windows.Forms.Tools.CarouselImage carouselImage7 = new Syncfusion.Windows.Forms.Tools.CarouselImage();
            Syncfusion.Windows.Forms.Tools.CarouselImage carouselImage8 = new Syncfusion.Windows.Forms.Tools.CarouselImage();
            Syncfusion.Windows.Forms.Tools.CarouselImage carouselImage9 = new Syncfusion.Windows.Forms.Tools.CarouselImage();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chknvr = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.chkOrig = new System.Windows.Forms.CheckBox();
            this.chkPreview = new System.Windows.Forms.CheckBox();
            this.chkShadow = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.trkSpeed = new System.Windows.Forms.TrackBar();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.trkPersp = new System.Windows.Forms.TrackBar();
            this.chkRotate = new System.Windows.Forms.CheckBox();
            this.comboPath = new System.Windows.Forms.ComboBox();
            this.carousel1 = new Syncfusion.Windows.Forms.Tools.Carousel();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkSpeed)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkPersp)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chknvr);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.chkRotate);
            this.groupBox1.Controls.Add(this.comboPath);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox1.Location = new System.Drawing.Point(881, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(229, 622);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Options";
            // 
            // chknvr
            // 
            this.chknvr.AutoSize = true;
            this.chknvr.Location = new System.Drawing.Point(117, 68);
            this.chknvr.Name = "chknvr";
            this.chknvr.Size = new System.Drawing.Size(90, 17);
            this.chknvr.TabIndex = 5;
            this.chknvr.Text = "Never Rotate";
            this.chknvr.UseVisualStyleBackColor = true;
            this.chknvr.CheckedChanged += new System.EventHandler(this.chknvr_CheckedChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button2);
            this.groupBox4.Controls.Add(this.button1);
            this.groupBox4.Controls.Add(this.chkOrig);
            this.groupBox4.Controls.Add(this.chkPreview);
            this.groupBox4.Controls.Add(this.chkShadow);
            this.groupBox4.Location = new System.Drawing.Point(22, 287);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(191, 186);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Image Optimizations";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(9, 148);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(165, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Image Shade Color";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(9, 115);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(165, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Image Highlight Color";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // chkOrig
            // 
            this.chkOrig.AutoSize = true;
            this.chkOrig.Location = new System.Drawing.Point(9, 84);
            this.chkOrig.Name = "chkOrig";
            this.chkOrig.Size = new System.Drawing.Size(165, 17);
            this.chkOrig.TabIndex = 2;
            this.chkOrig.Text = "Use Original image in preview";
            this.chkOrig.UseVisualStyleBackColor = true;
            this.chkOrig.CheckedChanged += new System.EventHandler(this.chkOrig_CheckedChanged);
            // 
            // chkPreview
            // 
            this.chkPreview.AutoSize = true;
            this.chkPreview.Location = new System.Drawing.Point(9, 58);
            this.chkPreview.Name = "chkPreview";
            this.chkPreview.Size = new System.Drawing.Size(123, 17);
            this.chkPreview.TabIndex = 1;
            this.chkPreview.Text = "ShowImage Preview";
            this.chkPreview.UseVisualStyleBackColor = true;
            this.chkPreview.CheckedChanged += new System.EventHandler(this.chkPreview_CheckedChanged);
            // 
            // chkShadow
            // 
            this.chkShadow.AutoSize = true;
            this.chkShadow.Location = new System.Drawing.Point(9, 31);
            this.chkShadow.Name = "chkShadow";
            this.chkShadow.Size = new System.Drawing.Size(124, 17);
            this.chkShadow.TabIndex = 0;
            this.chkShadow.Text = "ShowImage Shadow";
            this.chkShadow.UseVisualStyleBackColor = true;
            this.chkShadow.CheckedChanged += new System.EventHandler(this.chkShadow_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.trkSpeed);
            this.groupBox3.Location = new System.Drawing.Point(17, 195);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(196, 79);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Transition Speed";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(166, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "0";
            // 
            // trkSpeed
            // 
            this.trkSpeed.LargeChange = 1;
            this.trkSpeed.Location = new System.Drawing.Point(9, 28);
            this.trkSpeed.Minimum = 1;
            this.trkSpeed.Name = "trkSpeed";
            this.trkSpeed.Size = new System.Drawing.Size(146, 45);
            this.trkSpeed.TabIndex = 0;
            this.trkSpeed.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trkSpeed.Value = 1;
            this.trkSpeed.ValueChanged += new System.EventHandler(this.trkSpeed_ValueChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.trkPersp);
            this.groupBox2.Location = new System.Drawing.Point(17, 100);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(196, 79);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Perspective";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(166, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "0";
            // 
            // trkPersp
            // 
            this.trkPersp.LargeChange = 1;
            this.trkPersp.Location = new System.Drawing.Point(9, 22);
            this.trkPersp.Minimum = 2;
            this.trkPersp.Name = "trkPersp";
            this.trkPersp.Size = new System.Drawing.Size(146, 45);
            this.trkPersp.TabIndex = 0;
            this.trkPersp.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trkPersp.Value = 2;
            this.trkPersp.ValueChanged += new System.EventHandler(this.trkPersp_ValueChanged);
            // 
            // chkRotate
            // 
            this.chkRotate.AutoSize = true;
            this.chkRotate.Location = new System.Drawing.Point(17, 68);
            this.chkRotate.Name = "chkRotate";
            this.chkRotate.Size = new System.Drawing.Size(94, 17);
            this.chkRotate.TabIndex = 1;
            this.chkRotate.Text = "Rotate Always";
            this.chkRotate.UseVisualStyleBackColor = true;
            this.chkRotate.CheckedChanged += new System.EventHandler(this.chkRotate_CheckedChanged);
            // 
            // comboPath
            // 
            this.comboPath.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboPath.FormattingEnabled = true;
            this.comboPath.Items.AddRange(new object[] {
            "Default",
            "Orbital",
            "Linear",
            "Oval"});
            this.comboPath.Location = new System.Drawing.Point(17, 30);
            this.comboPath.Name = "comboPath";
            this.comboPath.Size = new System.Drawing.Size(164, 21);
            this.comboPath.TabIndex = 0;
            this.comboPath.SelectedIndexChanged += new System.EventHandler(this.comboPath_SelectedIndexChanged);
            // 
            // carousel1
            // 
            this.carousel1.BackColor = System.Drawing.Color.DimGray;
            this.carousel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.carousel1.HighlightColor = System.Drawing.Color.White;
            carouselImage1.ItemImage = global::CarouselDemo_2008.Properties.Resources.angles_demons;
            carouselImage2.ItemImage = global::CarouselDemo_2008.Properties.Resources.battleship;
            carouselImage3.ItemImage = global::CarouselDemo_2008.Properties.Resources.DarkKnight;
            carouselImage4.ItemImage = global::CarouselDemo_2008.Properties.Resources.Darkness;
            carouselImage5.ItemImage = global::CarouselDemo_2008.Properties.Resources.Holmes;
            carouselImage6.ItemImage = global::CarouselDemo_2008.Properties.Resources.LOW;
            carouselImage7.ItemImage = global::CarouselDemo_2008.Properties.Resources.Miserables;
            carouselImage8.ItemImage = global::CarouselDemo_2008.Properties.Resources.Pirates;
            carouselImage9.ItemImage = global::CarouselDemo_2008.Properties.Resources.twilight;
            this.carousel1.ImageListCollection.Add(carouselImage1);
            this.carousel1.ImageListCollection.Add(carouselImage2);
            this.carousel1.ImageListCollection.Add(carouselImage3);
            this.carousel1.ImageListCollection.Add(carouselImage4);
            this.carousel1.ImageListCollection.Add(carouselImage5);
            this.carousel1.ImageListCollection.Add(carouselImage6);
            this.carousel1.ImageListCollection.Add(carouselImage7);
            this.carousel1.ImageListCollection.Add(carouselImage8);
            this.carousel1.ImageListCollection.Add(carouselImage9);
            this.carousel1.ImageshadeColor = System.Drawing.Color.Black;
            this.carousel1.ImageSlides = true;
            this.carousel1.Location = new System.Drawing.Point(0, 0);
            this.carousel1.Name = "carousel1";
            this.carousel1.PadX = 0;
            this.carousel1.PadY = 0;
            this.carousel1.Perspective = 4F;
            this.carousel1.RotateAlways = false;
            this.carousel1.ShowImagePreview = false;
            this.carousel1.ShowImageShadow = true;
            this.carousel1.Size = new System.Drawing.Size(881, 622);
            this.carousel1.TabIndex = 0;
            this.carousel1.Text = "carousel1";
            this.carousel1.UseOriginalImageinPreview = false;
            this.carousel1.VisualStyle = Syncfusion.Windows.Forms.Tools.CarouselVisualStyle.Default;
            this.carousel1.Paint += new System.Windows.Forms.PaintEventHandler(this.carousel1_Paint);
            this.carousel1.OnCarouselItemSelectionChanging += new Syncfusion.Windows.Forms.Tools.OnCarouselItemSelectionChangingEventHandler(this.carousel1_OnCarouselItemSelectionChanging);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.CaptionAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ClientSize = new System.Drawing.Size(1110, 622);
            this.Controls.Add(this.carousel1);
            this.Controls.Add(this.groupBox1);
            this.DropShadow = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.IconAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.IconTextRelation = System.Windows.Forms.LeftRightAlignment.Left;
            this.MetroColor = System.Drawing.Color.White;
            this.MinimumSize = new System.Drawing.Size(1122, 659);
            this.Name = "Form1";
            this.Text = "Carousel Demo";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkSpeed)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkPersp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox chkOrig;
        private System.Windows.Forms.CheckBox chkPreview;
        private System.Windows.Forms.CheckBox chkShadow;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar trkSpeed;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar trkPersp;
        private System.Windows.Forms.CheckBox chkRotate;
        private System.Windows.Forms.ComboBox comboPath;
        private Syncfusion.Windows.Forms.Tools.Carousel carousel1;
        private System.Windows.Forms.CheckBox chknvr;

    }
}


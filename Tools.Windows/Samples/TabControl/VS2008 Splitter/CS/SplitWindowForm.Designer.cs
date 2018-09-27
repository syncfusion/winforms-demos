namespace TabSplitterContainer_2005
{
    partial class SplitWindowForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SplitWindowForm));
            this.tabSplitterContainer1 = new Syncfusion.Windows.Forms.Tools.TabSplitterContainer();
            this.DesignPage = new Syncfusion.Windows.Forms.Tools.TabSplitterPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.XAMLPage = new Syncfusion.Windows.Forms.Tools.TabSplitterPage();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.tabSplitterContainer1.SuspendLayout();
            this.DesignPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.XAMLPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabSplitterContainer1
            // 
            this.tabSplitterContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabSplitterContainer1.Location = new System.Drawing.Point(0, 0);
            this.tabSplitterContainer1.Name = "tabSplitterContainer1";
            this.tabSplitterContainer1.PrimaryPages.AddRange(new Syncfusion.Windows.Forms.Tools.TabSplitterPage[] {
            this.DesignPage});
            this.tabSplitterContainer1.SecondaryPages.AddRange(new Syncfusion.Windows.Forms.Tools.TabSplitterPage[] {
            this.XAMLPage});
            this.tabSplitterContainer1.Size = new System.Drawing.Size(775, 524);
            this.tabSplitterContainer1.SplitterBackColor = System.Drawing.Color.White;
            this.tabSplitterContainer1.SplitterPosition = 286;
            this.tabSplitterContainer1.Style = Syncfusion.Windows.Forms.Tools.TabSplitterContainerStyle.Office2016Colorful;
            this.tabSplitterContainer1.TabIndex = 0;
            this.tabSplitterContainer1.Text = "tabSplitterContainer1";
            // 
            // DesignPage
            // 
            this.DesignPage.AutoScroll = true;
            this.DesignPage.Controls.Add(this.pictureBox1);
            this.DesignPage.Hide = false;
            this.DesignPage.Image = ((System.Drawing.Image)(resources.GetObject("DesignPage.Image")));
            this.DesignPage.Location = new System.Drawing.Point(0, 0);
            this.DesignPage.Name = "DesignPage";
            this.DesignPage.Size = new System.Drawing.Size(775, 286);
            this.DesignPage.TabIndex = 1;
            this.DesignPage.Text = "Design";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(775, 286);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // XAMLPage
            // 
            this.XAMLPage.AutoScroll = true;
            this.XAMLPage.Controls.Add(this.richTextBox1);
            this.XAMLPage.Hide = false;
            this.XAMLPage.Image = ((System.Drawing.Image)(resources.GetObject("XAMLPage.Image")));
            this.XAMLPage.Location = new System.Drawing.Point(0, 306);
            this.XAMLPage.Name = "XAMLPage";
            this.XAMLPage.Size = new System.Drawing.Size(775, 218);
            this.XAMLPage.TabIndex = 2;
            this.XAMLPage.Text = "XAML";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.White;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(0, 0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(775, 218);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // SplitWindowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(775, 524);
            this.Controls.Add(this.tabSplitterContainer1);
            this.Name = "SplitWindowForm";
            this.ShowIcon = false;
            this.Text = "SplitWindowForm";
            this.tabSplitterContainer1.ResumeLayout(false);
            this.DesignPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.XAMLPage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        internal Syncfusion.Windows.Forms.Tools.TabSplitterContainer tabSplitterContainer1;
        internal Syncfusion.Windows.Forms.Tools.TabSplitterPage DesignPage;
        internal Syncfusion.Windows.Forms.Tools.TabSplitterPage XAMLPage;
        internal System.Windows.Forms.PictureBox pictureBox1;
        internal System.Windows.Forms.RichTextBox richTextBox1;
    }
}
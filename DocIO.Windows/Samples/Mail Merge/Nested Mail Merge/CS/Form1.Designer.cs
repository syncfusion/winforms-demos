namespace NestedMailMerge_2005
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonCreate = new Syncfusion.Windows.Forms.ButtonAdv();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.radioButtonLetter = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
            this.radioButtonReport = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
            this.templateBtn = new Syncfusion.Windows.Forms.ButtonAdv();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.wordDocxRadioBtn = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
            this.wordDocRadioBtn = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
            this.pdfRadioBtn = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.radioButtonExplicit = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
            this.radioButtonImplicit = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radioButtonLetter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioButtonReport)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wordDocxRadioBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wordDocRadioBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pdfRadioBtn)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radioButtonExplicit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioButtonImplicit)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(420, 91);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(0, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(420, 59);
            this.label2.TabIndex = 68;
            this.label2.Text = "Click the button to view the generated Word document or PDF. Please note that Microsoft Word Viewer or Microsoft Word is required to view the resultant Word document and PDF viewer is required to view the resultant PDF.";
            // 
            // buttonCreate
            // 
            this.buttonCreate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCreate.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.buttonCreate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218)))));
            this.buttonCreate.BeforeTouchSize = new System.Drawing.Size(108, 23);
            this.buttonCreate.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.Dashed;
            this.buttonCreate.ComboEditBackColor = System.Drawing.Color.Silver;
            this.buttonCreate.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCreate.ForeColor = System.Drawing.Color.White;
            this.buttonCreate.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonCreate.IsBackStageButton = false;
            this.buttonCreate.KeepFocusRectangle = false;
            this.buttonCreate.Location = new System.Drawing.Point(299, 332);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Managed;
            this.buttonCreate.Size = new System.Drawing.Size(108, 23);
            this.buttonCreate.TabIndex = 73;
            this.buttonCreate.Text = "Generate";
            this.buttonCreate.UseVisualStyle = true;
            this.buttonCreate.UseVisualStyleBackColor = false;
            this.buttonCreate.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.radioButtonLetter);
            this.groupBox1.Controls.Add(this.radioButtonReport);
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(3, 160);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(241, 137);
            this.groupBox1.TabIndex = 84;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nested Mail Merge Template";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(28, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(211, 26);
            this.label4.TabIndex = 87;
            this.label4.Text = "Performs nested mail merge and creates document in Letter format";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(28, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(211, 29);
            this.label3.TabIndex = 86;
            this.label3.Text = "Performs nested mail merge and creates document in Report format";
            // 
            // radioButtonLetter
            // 
            this.radioButtonLetter.BeforeTouchSize = new System.Drawing.Size(115, 17);
            this.radioButtonLetter.Border3DStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.radioButtonLetter.Checked = true;
            this.radioButtonLetter.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold);
            this.radioButtonLetter.ForeColor = System.Drawing.SystemColors.ControlText;
            this.radioButtonLetter.GradientEnd = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.radioButtonLetter.GradientStart = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.radioButtonLetter.Location = new System.Drawing.Point(12, 82);
            this.radioButtonLetter.MetroColor = System.Drawing.Color.Empty;
            this.radioButtonLetter.Name = "radioButtonLetter";
            this.radioButtonLetter.Size = new System.Drawing.Size(115, 17);
            this.radioButtonLetter.TabIndex = 85;
            this.radioButtonLetter.Text = "Letter Format";
            this.radioButtonLetter.ThemesEnabled = true;
            // 
            // radioButtonReport
            // 
            this.radioButtonReport.BeforeTouchSize = new System.Drawing.Size(119, 17);
            this.radioButtonReport.Border3DStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.radioButtonReport.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold);
            this.radioButtonReport.ForeColor = System.Drawing.SystemColors.ControlText;
            this.radioButtonReport.GradientEnd = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.radioButtonReport.GradientStart = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.radioButtonReport.Location = new System.Drawing.Point(12, 20);
            this.radioButtonReport.MetroColor = System.Drawing.Color.Empty;
            this.radioButtonReport.Name = "radioButtonReport";
            this.radioButtonReport.Size = new System.Drawing.Size(119, 17);
            this.radioButtonReport.TabIndex = 84;
            this.radioButtonReport.Text = "Report Format";
            this.radioButtonReport.ThemesEnabled = true;
            // 
            // templateBtn
            // 
            this.templateBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.templateBtn.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.templateBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218)))));
            this.templateBtn.BeforeTouchSize = new System.Drawing.Size(108, 23);
            this.templateBtn.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.Dashed;
            this.templateBtn.ComboEditBackColor = System.Drawing.Color.Silver;
            this.templateBtn.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.templateBtn.ForeColor = System.Drawing.Color.White;
            this.templateBtn.IsBackStageButton = false;
            this.templateBtn.KeepFocusRectangle = false;
            this.templateBtn.Location = new System.Drawing.Point(299, 303);
            this.templateBtn.Name = "templateBtn";
            this.templateBtn.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Managed;
            this.templateBtn.Size = new System.Drawing.Size(108, 23);
            this.templateBtn.TabIndex = 101;
            this.templateBtn.Text = "View Template";
            this.templateBtn.UseVisualStyle = true;
            this.templateBtn.UseVisualStyleBackColor = false;
            this.templateBtn.Click += new System.EventHandler(this.templateBtn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.wordDocxRadioBtn);
            this.groupBox2.Controls.Add(this.wordDocRadioBtn);
            this.groupBox2.Controls.Add(this.pdfRadioBtn);
            this.groupBox2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(3, 303);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(266, 49);
            this.groupBox2.TabIndex = 102;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Save As";
            // 
            // worddocxRadioBtn
            // 
            this.wordDocxRadioBtn.BeforeTouchSize = new System.Drawing.Size(54, 20);
            this.wordDocxRadioBtn.Border3DStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.wordDocxRadioBtn.Checked = true;
            this.wordDocxRadioBtn.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wordDocxRadioBtn.GradientEnd = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.wordDocxRadioBtn.GradientStart = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.wordDocxRadioBtn.Location = new System.Drawing.Point(111, 18);
            this.wordDocxRadioBtn.MetroColor = System.Drawing.Color.Empty;
            this.wordDocxRadioBtn.Name = "wordDocxRadioBtn";
            this.wordDocxRadioBtn.Size = new System.Drawing.Size(54, 20);
            this.wordDocxRadioBtn.TabIndex = 103;
            this.wordDocxRadioBtn.Text = "DOCX";
            this.wordDocxRadioBtn.ThemesEnabled = true;
            // 
            // worddocRadioBtn
            // 
            this.wordDocRadioBtn.BeforeTouchSize = new System.Drawing.Size(46, 20);
            this.wordDocRadioBtn.Border3DStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.wordDocRadioBtn.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.wordDocRadioBtn.GradientEnd = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.wordDocRadioBtn.GradientStart = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.wordDocRadioBtn.Location = new System.Drawing.Point(10, 18);
            this.wordDocRadioBtn.MetroColor = System.Drawing.Color.Empty;
            this.wordDocRadioBtn.Name = "wordDocRadioBtn";
            this.wordDocRadioBtn.Size = new System.Drawing.Size(46, 20);
            this.wordDocRadioBtn.TabIndex = 44;
            this.wordDocRadioBtn.Text = "DOC";
            this.wordDocRadioBtn.ThemesEnabled = true;
            // 
            // pdfRadioBtn
            // 
            this.pdfRadioBtn.BeforeTouchSize = new System.Drawing.Size(43, 20);
            this.pdfRadioBtn.Border3DStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.pdfRadioBtn.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.pdfRadioBtn.GradientEnd = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.pdfRadioBtn.GradientStart = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.pdfRadioBtn.Location = new System.Drawing.Point(217, 18);
            this.pdfRadioBtn.MetroColor = System.Drawing.Color.Empty;
            this.pdfRadioBtn.Name = "pdfRadioBtn";
            this.pdfRadioBtn.Size = new System.Drawing.Size(43, 20);
            this.pdfRadioBtn.TabIndex = 45;
            this.pdfRadioBtn.Text = "PDF";
            this.pdfRadioBtn.ThemesEnabled = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.radioButtonExplicit);
            this.groupBox3.Controls.Add(this.radioButtonImplicit);
            this.groupBox3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold);
            this.groupBox3.ForeColor = System.Drawing.Color.Black;
            this.groupBox3.Location = new System.Drawing.Point(250, 160);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(172, 137);
            this.groupBox3.TabIndex = 88;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Mail Merge Data";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(28, 102);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 26);
            this.label7.TabIndex = 87;
            this.label7.Text = "Uses Explicit relation";
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.label8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label8.Location = new System.Drawing.Point(28, 40);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(138, 29);
            this.label8.TabIndex = 86;
            this.label8.Text = "Uses Implicit relation";
            // 
            // radioButtonExplicit
            // 
            this.radioButtonExplicit.BeforeTouchSize = new System.Drawing.Size(134, 17);
            this.radioButtonExplicit.Border3DStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.radioButtonExplicit.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold);
            this.radioButtonExplicit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.radioButtonExplicit.GradientEnd = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.radioButtonExplicit.GradientStart = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.radioButtonExplicit.Location = new System.Drawing.Point(12, 82);
            this.radioButtonExplicit.MetroColor = System.Drawing.Color.Empty;
            this.radioButtonExplicit.Name = "radioButtonExplicit";
            this.radioButtonExplicit.Size = new System.Drawing.Size(134, 17);
            this.radioButtonExplicit.TabIndex = 85;
            this.radioButtonExplicit.TabStop = false;
            this.radioButtonExplicit.Text = "Explicit relation";
            this.radioButtonExplicit.ThemesEnabled = true;
            // 
            // radioButtonImplicit
            // 
            this.radioButtonImplicit.BeforeTouchSize = new System.Drawing.Size(134, 17);
            this.radioButtonImplicit.Border3DStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.radioButtonImplicit.Checked = true;
            this.radioButtonImplicit.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold);
            this.radioButtonImplicit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.radioButtonImplicit.GradientEnd = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.radioButtonImplicit.GradientStart = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.radioButtonImplicit.Location = new System.Drawing.Point(12, 20);
            this.radioButtonImplicit.MetroColor = System.Drawing.Color.Empty;
            this.radioButtonImplicit.Name = "radioButtonImplicit";
            this.radioButtonImplicit.Size = new System.Drawing.Size(134, 17);
            this.radioButtonImplicit.TabIndex = 84;
            this.radioButtonImplicit.Text = "Implicit relation";
            this.radioButtonImplicit.ThemesEnabled = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218)))));
            this.ClientSize = new System.Drawing.Size(420, 365);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.templateBtn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonCreate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.DropShadow = true;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nested Mail Merge";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radioButtonLetter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioButtonReport)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.wordDocxRadioBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wordDocRadioBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pdfRadioBtn)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radioButtonExplicit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioButtonImplicit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private Syncfusion.Windows.Forms.ButtonAdv buttonCreate;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private Syncfusion.Windows.Forms.Tools.RadioButtonAdv radioButtonLetter;
        private Syncfusion.Windows.Forms.Tools.RadioButtonAdv radioButtonReport;
        private Syncfusion.Windows.Forms.ButtonAdv templateBtn;
        private System.Windows.Forms.GroupBox groupBox2;
        private Syncfusion.Windows.Forms.Tools.RadioButtonAdv wordDocxRadioBtn;
        private Syncfusion.Windows.Forms.Tools.RadioButtonAdv wordDocRadioBtn;
        private Syncfusion.Windows.Forms.Tools.RadioButtonAdv pdfRadioBtn;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private Syncfusion.Windows.Forms.Tools.RadioButtonAdv radioButtonExplicit;
        private Syncfusion.Windows.Forms.Tools.RadioButtonAdv radioButtonImplicit;

    }
}


namespace GettingStarted
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
            this.sfListView1 = new Syncfusion.WinForms.ListView.SfListView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.themeComboBox = new Syncfusion.WinForms.ListView.SfComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.selectionMode_None = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
            this.selectionMode_MultiExt = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
            this.selectionMode_Multiple = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
            this.SelectionMode_One = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.themeComboBox)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.selectionMode_None)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectionMode_MultiExt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectionMode_Multiple)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SelectionMode_One)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // sfListView1
            // 
            this.sfListView1.AccessibleName = "ScrollControl";
            this.sfListView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sfListView1.Location = new System.Drawing.Point(0, 0);
            this.sfListView1.Name = "sfListView1";
            this.sfListView1.Size = new System.Drawing.Size(630, 528);
            this.sfListView1.TabIndex = 0;
            this.sfListView1.Text = "sfListView1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.themeComboBox);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(674, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(230, 528);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Choose theme";
            // 
            // themeComboBox
            // 
            this.themeComboBox.DropDownStyle = Syncfusion.WinForms.ListView.Enums.DropDownStyle.DropDownList;
            this.themeComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.themeComboBox.Location = new System.Drawing.Point(35, 25);
            this.themeComboBox.Margin = new System.Windows.Forms.Padding(5);
            this.themeComboBox.Name = "themeComboBox";
            this.themeComboBox.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.themeComboBox.Size = new System.Drawing.Size(161, 33);
            this.themeComboBox.TabIndex = 2;
            this.themeComboBox.SelectedValueChanged += new System.EventHandler(this.themeComboBox_SelectedValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.selectionMode_None);
            this.groupBox1.Controls.Add(this.selectionMode_MultiExt);
            this.groupBox1.Controls.Add(this.selectionMode_Multiple);
            this.groupBox1.Controls.Add(this.SelectionMode_One);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(35, 81);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(161, 156);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selection mode";
            // 
            // selectionMode_None
            // 
            this.selectionMode_None.AutoSize = true;
            this.selectionMode_None.BeforeTouchSize = new System.Drawing.Size(56, 19);
            this.selectionMode_None.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectionMode_None.Location = new System.Drawing.Point(8, 113);
            this.selectionMode_None.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(89)))), ((int)(((byte)(91)))));
            this.selectionMode_None.Name = "selectionMode_None";
            this.selectionMode_None.Size = new System.Drawing.Size(56, 19);
            this.selectionMode_None.TabIndex = 6;
            this.selectionMode_None.TabStop = false;
            this.selectionMode_None.Text = "None";
            this.selectionMode_None.ThemesEnabled = false;
            this.selectionMode_None.CheckChanged += new System.EventHandler(this.Selection_Mode_CheckedChanged);
            // 
            // selectionMode_MultiExt
            // 
            this.selectionMode_MultiExt.AutoSize = true;
            this.selectionMode_MultiExt.BeforeTouchSize = new System.Drawing.Size(107, 19);
            this.selectionMode_MultiExt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectionMode_MultiExt.Location = new System.Drawing.Point(8, 87);
            this.selectionMode_MultiExt.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(89)))), ((int)(((byte)(91)))));
            this.selectionMode_MultiExt.Name = "selectionMode_MultiExt";
            this.selectionMode_MultiExt.Size = new System.Drawing.Size(107, 19);
            this.selectionMode_MultiExt.TabIndex = 5;
            this.selectionMode_MultiExt.TabStop = false;
            this.selectionMode_MultiExt.Text = "MultiExtended";
            this.selectionMode_MultiExt.ThemesEnabled = false;
            this.selectionMode_MultiExt.CheckChanged += new System.EventHandler(this.Selection_Mode_CheckedChanged);
            // 
            // selectionMode_Multiple
            // 
            this.selectionMode_Multiple.AutoSize = true;
            this.selectionMode_Multiple.BeforeTouchSize = new System.Drawing.Size(92, 19);
            this.selectionMode_Multiple.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectionMode_Multiple.Location = new System.Drawing.Point(8, 60);
            this.selectionMode_Multiple.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(89)))), ((int)(((byte)(91)))));
            this.selectionMode_Multiple.Name = "selectionMode_Multiple";
            this.selectionMode_Multiple.Size = new System.Drawing.Size(92, 19);
            this.selectionMode_Multiple.TabIndex = 4;
            this.selectionMode_Multiple.TabStop = false;
            this.selectionMode_Multiple.Text = "MultiSimple";
            this.selectionMode_Multiple.ThemesEnabled = false;
            this.selectionMode_Multiple.CheckChanged += new System.EventHandler(this.Selection_Mode_CheckedChanged);
            // 
            // SelectionMode_One
            // 
            this.SelectionMode_One.AutoSize = true;
            this.SelectionMode_One.BeforeTouchSize = new System.Drawing.Size(48, 19);
            this.SelectionMode_One.Checked = true;
            this.SelectionMode_One.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectionMode_One.Location = new System.Drawing.Point(8, 33);
            this.SelectionMode_One.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(89)))), ((int)(((byte)(91)))));
            this.SelectionMode_One.Name = "SelectionMode_One";
            this.SelectionMode_One.Size = new System.Drawing.Size(48, 19);
            this.SelectionMode_One.TabIndex = 3;
            this.SelectionMode_One.Text = "One";
            this.SelectionMode_One.ThemesEnabled = false;
            this.SelectionMode_One.CheckChanged += new System.EventHandler(this.Selection_Mode_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.sfListView1);
            this.panel2.Location = new System.Drawing.Point(37, 22);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(630, 528);
            this.panel2.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 576);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Getting Started";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.themeComboBox)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.selectionMode_None)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectionMode_MultiExt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectionMode_Multiple)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SelectionMode_One)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Syncfusion.WinForms.ListView.SfListView sfListView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private Syncfusion.Windows.Forms.Tools.RadioButtonAdv selectionMode_None;
        private Syncfusion.Windows.Forms.Tools.RadioButtonAdv selectionMode_MultiExt;
        private Syncfusion.Windows.Forms.Tools.RadioButtonAdv selectionMode_Multiple;
        private Syncfusion.Windows.Forms.Tools.RadioButtonAdv SelectionMode_One;
        private Syncfusion.WinForms.ListView.SfComboBox themeComboBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
    }
}


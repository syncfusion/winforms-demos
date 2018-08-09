using Syncfusion.Windows.Forms;
using Syncfusion.Windows.Forms.Tools;
namespace TreeViewAdvSearchDemo
{
    partial class TreeViewSearchForm
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
            this.tabControlAdv1 = new Syncfusion.Windows.Forms.Tools.TabControlAdv();
            this.tabPageAdv1 = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.comboBox3 = new ComboBoxAdv();
            this.label5 = new System.Windows.Forms.Label();
            this.button5 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.SearchRangeCombo = new ComboBoxAdv();
            this.label4 = new System.Windows.Forms.Label();
            this.button4 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.button3 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.button2 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.button1 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.SearchOptionCombo = new ComboBoxAdv();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.findTextBox = new System.Windows.Forms.TextBox();
            this.replaceTextbox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.tabControlAdv1)).BeginInit();
            this.tabControlAdv1.SuspendLayout();
            this.tabPageAdv1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlAdv1
            // 
            this.tabControlAdv1.Controls.Add(this.tabPageAdv1);
            this.tabControlAdv1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlAdv1.Location = new System.Drawing.Point(10, 10);
            this.tabControlAdv1.Name = "tabControlAdv1";
            this.tabControlAdv1.Size = new System.Drawing.Size(672, 271);
            this.tabControlAdv1.TabIndex = 0;
            this.tabControlAdv1.TabPanelBackColor = System.Drawing.Color.White;
            this.tabControlAdv1.TabStyle = typeof(Syncfusion.Windows.Forms.Tools.TabRendererMetro);
            // 
            // tabPageAdv1
            // 
            this.tabPageAdv1.Controls.Add(this.replaceTextbox);
            this.tabPageAdv1.Controls.Add(this.findTextBox);
            this.tabPageAdv1.Controls.Add(this.comboBox3);
            this.tabPageAdv1.Controls.Add(this.label5);
            this.tabPageAdv1.Controls.Add(this.button5);
            this.tabPageAdv1.Controls.Add(this.SearchRangeCombo);
            this.tabPageAdv1.Controls.Add(this.label4);
            this.tabPageAdv1.Controls.Add(this.button4);
            this.tabPageAdv1.Controls.Add(this.button3);
            this.tabPageAdv1.Controls.Add(this.button2);
            this.tabPageAdv1.Controls.Add(this.button1);
            this.tabPageAdv1.Controls.Add(this.SearchOptionCombo);
            this.tabPageAdv1.Controls.Add(this.label3);
            this.tabPageAdv1.Controls.Add(this.label2);
            this.tabPageAdv1.Controls.Add(this.label1);
            this.tabPageAdv1.Image = null;
            this.tabPageAdv1.ImageSize = new System.Drawing.Size(16, 16);
            this.tabPageAdv1.Location = new System.Drawing.Point(1, 22);
            this.tabPageAdv1.Name = "tabPageAdv1";
            this.tabPageAdv1.ShowCloseButton = true;
            this.tabPageAdv1.Size = new System.Drawing.Size(669, 247);
            this.tabPageAdv1.TabIndex = 1;
            this.tabPageAdv1.Text = "Search Option";
            this.tabPageAdv1.ThemesEnabled = false;
            // 
            // comboBox3
            // 
            this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox3.Location = new System.Drawing.Point(136, 159);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(363, 21);
            this.comboBox3.TabIndex = 15;
            this.comboBox3.Style = VisualStyle.Metro;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Search Navigation";
            // 
            // button5
            // 
            this.button5.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218)))));
            this.button5.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.IsBackStageButton = false;
            this.button5.Location = new System.Drawing.Point(521, 216);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 13;
            this.button5.Text = "&Done";
            this.button5.UseVisualStyle = true;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // SearchRangeCombo
            // 
            this.SearchRangeCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SearchRangeCombo.Location = new System.Drawing.Point(136, 119);
            this.SearchRangeCombo.Name = "SearchRangeCombo";
            this.SearchRangeCombo.Size = new System.Drawing.Size(363, 21);
            this.SearchRangeCombo.TabIndex = 12;
            this.SearchRangeCombo.SelectedIndexChanged += new System.EventHandler(this.SearchRangeCombo_SelectedIndexChanged);
            this.SearchRangeCombo.Style = VisualStyle.Metro;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Search Range";
            // 
            // button4
            // 
            this.button4.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218)))));
            this.button4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.IsBackStageButton = false;
            this.button4.Location = new System.Drawing.Point(424, 216);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 10;
            this.button4.Text = "&Replace All";
            this.button4.UseVisualStyle = true;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218)))));
            this.button3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.IsBackStageButton = false;
            this.button3.Location = new System.Drawing.Point(332, 216);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 9;
            this.button3.Text = "&Replace";
            this.button3.UseVisualStyle = true;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218)))));
            this.button2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.IsBackStageButton = false;
            this.button2.Location = new System.Drawing.Point(235, 216);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "&Find All";
            this.button2.UseVisualStyle = true;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218)))));
            this.button1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.IsBackStageButton = false;
            this.button1.Location = new System.Drawing.Point(136, 216);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "&Find Next";
            this.button1.UseVisualStyle = true;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SearchOptionCombo
            // 
            this.SearchOptionCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SearchOptionCombo.Location = new System.Drawing.Point(136, 84);
            this.SearchOptionCombo.Name = "SearchOptionCombo";
            this.SearchOptionCombo.Size = new System.Drawing.Size(363, 21);
            this.SearchOptionCombo.TabIndex = 6;
            this.SearchOptionCombo.Style = VisualStyle.Metro;
            this.SearchOptionCombo.SelectedIndexChanged += new System.EventHandler(this.SearchOptionCombo_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Search Option";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Replace With";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Find What";
            // 
            // findTextBox
            // 
            this.findTextBox.Location = new System.Drawing.Point(136, 15);
            this.findTextBox.Name = "findTextBox";
            this.findTextBox.Size = new System.Drawing.Size(363, 20);
            this.findTextBox.TabIndex = 16;
            // 
            // replaceTextbox
            // 
            this.replaceTextbox.Location = new System.Drawing.Point(136, 50);
            this.replaceTextbox.Name = "replaceTextbox";
            this.replaceTextbox.Size = new System.Drawing.Size(363, 20);
            this.replaceTextbox.TabIndex = 17;
            // 
            // TreeViewSearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 291);
            this.ControlBox = false;
            this.Controls.Add(this.tabControlAdv1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximumSize = new System.Drawing.Size(694, 323);
            this.MinimumSize = new System.Drawing.Size(694, 323);
            this.Name = "TreeViewSearchForm";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Text = "TreeViewAdv Search Window";
            ((System.ComponentModel.ISupportInitialize)(this.tabControlAdv1)).EndInit();
            this.tabControlAdv1.ResumeLayout(false);
            this.tabPageAdv1.ResumeLayout(false);
            this.tabPageAdv1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Syncfusion.Windows.Forms.Tools.TabControlAdv tabControlAdv1;
        private Syncfusion.Windows.Forms.Tools.TabPageAdv tabPageAdv1;
        private ComboBoxAdv SearchRangeCombo;
        private System.Windows.Forms.Label label4;
        private ButtonAdv button4;
        private ButtonAdv button3;
        private ButtonAdv button2;
        private ButtonAdv button1;
        private ComboBoxAdv SearchOptionCombo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private ButtonAdv button5;
        private ComboBoxAdv comboBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox replaceTextbox;
        private System.Windows.Forms.TextBox findTextBox;
    }
}
namespace MultiSelection
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
            this.selectAll = new Syncfusion.WinForms.ListView.SfComboBox();
            this.toolTip = new Syncfusion.WinForms.ListView.SfComboBox();
            this.waterMark = new Syncfusion.WinForms.ListView.SfComboBox();
            this.delimiterChar = new Syncfusion.WinForms.ListView.SfComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.themeComboBox = new Syncfusion.WinForms.ListView.SfComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.selectAll)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toolTip)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.waterMark)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.delimiterChar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.themeComboBox)).BeginInit();
            this.SuspendLayout();
            // 
            // selectAll
            // 
            this.selectAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectAll.Location = new System.Drawing.Point(68, 222);
            this.selectAll.Margin = new System.Windows.Forms.Padding(4);
            this.selectAll.Name = "selectAll";
            this.selectAll.Size = new System.Drawing.Size(291, 30);
            this.selectAll.TabIndex = 2;
            // 
            // toolTip
            // 
            this.toolTip.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolTip.Location = new System.Drawing.Point(445, 222);
            this.toolTip.Margin = new System.Windows.Forms.Padding(4);
            this.toolTip.Name = "toolTip";
            this.toolTip.Size = new System.Drawing.Size(291, 30);
            this.toolTip.TabIndex = 3;
            // 
            // waterMark
            // 
            this.waterMark.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.waterMark.Location = new System.Drawing.Point(445, 384);
            this.waterMark.Margin = new System.Windows.Forms.Padding(4);
            this.waterMark.Name = "waterMark";
            this.waterMark.Size = new System.Drawing.Size(291, 30);
            this.waterMark.TabIndex = 5;
            // 
            // delimiterChar
            // 
            this.delimiterChar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delimiterChar.Location = new System.Drawing.Point(68, 384);
            this.delimiterChar.Margin = new System.Windows.Forms.Padding(4);
            this.delimiterChar.Name = "delimiterChar";
            this.delimiterChar.Size = new System.Drawing.Size(291, 30);
            this.delimiterChar.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(68, 192);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 16);
            this.label1.TabIndex = 16;
            this.label1.Text = "Select all";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(445, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 17;
            this.label2.Text = "ToolTip";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(68, 354);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 16);
            this.label3.TabIndex = 18;
            this.label3.Text = "Delimiter character";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(445, 354);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 16);
            this.label4.TabIndex = 19;
            this.label4.Text = "Watermark";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(8, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(793, 40);
            this.label5.TabIndex = 20;
            this.label5.Text = "The following sample demonstrates the default functionalities of SfComboBox with multiselection mode such " +
    "as edit mode, select all item, delimiter character to separate the text and watermark " +
    "text";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(445, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 16);
            this.label6.TabIndex = 21;
            this.label6.Text = "Choose theme";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // themeComboBox
            // 
            this.themeComboBox.DropDownStyle = Syncfusion.WinForms.ListView.Enums.DropDownStyle.DropDownList;
            this.themeComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.themeComboBox.Location = new System.Drawing.Point(557, 89);
            this.themeComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.themeComboBox.Name = "themeComboBox";
            this.themeComboBox.Size = new System.Drawing.Size(155, 30);
            this.themeComboBox.TabIndex = 1;
            this.themeComboBox.SelectedValueChanged += new System.EventHandler(this.themeComboBox_SelectedValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 508);
            this.Controls.Add(this.themeComboBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.waterMark);
            this.Controls.Add(this.delimiterChar);
            this.Controls.Add(this.toolTip);
            this.Controls.Add(this.selectAll);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Multi selection";
            ((System.ComponentModel.ISupportInitialize)(this.selectAll)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toolTip)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.waterMark)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.delimiterChar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.themeComboBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Syncfusion.WinForms.ListView.SfComboBox selectAll;
        private Syncfusion.WinForms.ListView.SfComboBox toolTip;
        private Syncfusion.WinForms.ListView.SfComboBox waterMark;
        private Syncfusion.WinForms.ListView.SfComboBox delimiterChar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private Syncfusion.WinForms.ListView.SfComboBox themeComboBox;
    }
}


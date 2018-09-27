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
            this.editMode = new Syncfusion.WinForms.ListView.SfComboBox();
            this.waterMark = new Syncfusion.WinForms.ListView.SfComboBox();
            this.dropDownStyle = new Syncfusion.WinForms.ListView.SfComboBox();
            this.suggest = new Syncfusion.WinForms.ListView.SfComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.themeComboBox = new Syncfusion.WinForms.ListView.SfComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.suggestAppend = new Syncfusion.WinForms.ListView.SfComboBox();
            this.append = new Syncfusion.WinForms.ListView.SfComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.editMode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.waterMark)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dropDownStyle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.suggest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.themeComboBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.suggestAppend)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.append)).BeginInit();
            this.SuspendLayout();
            // 
            // editMode
            // 
            this.editMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editMode.Location = new System.Drawing.Point(95, 219);
            this.editMode.Margin = new System.Windows.Forms.Padding(4);
            this.editMode.Name = "editMode";
            this.editMode.Size = new System.Drawing.Size(291, 30);
            this.editMode.TabIndex = 2;
            // 
            // waterMark
            // 
            this.waterMark.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.waterMark.Location = new System.Drawing.Point(471, 219);
            this.waterMark.Margin = new System.Windows.Forms.Padding(4);
            this.waterMark.Name = "waterMark";
            this.waterMark.Size = new System.Drawing.Size(291, 30);
            this.waterMark.TabIndex = 3;
            // 
            // dropDownStyle
            // 
            this.dropDownStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dropDownStyle.Location = new System.Drawing.Point(471, 519);
            this.dropDownStyle.Margin = new System.Windows.Forms.Padding(4);
            this.dropDownStyle.Name = "dropDownStyle";
            this.dropDownStyle.Size = new System.Drawing.Size(291, 30);
            this.dropDownStyle.TabIndex = 7;
            // 
            // suggest
            // 
            this.suggest.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.suggest.Location = new System.Drawing.Point(95, 366);
            this.suggest.Margin = new System.Windows.Forms.Padding(4);
            this.suggest.Name = "suggest";
            this.suggest.Size = new System.Drawing.Size(291, 30);
            this.suggest.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(95, 189);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Edit mode";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(468, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 16);
            this.label2.TabIndex = 17;
            this.label2.Text = "Watermark";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(95, 332);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 16);
            this.label3.TabIndex = 18;
            this.label3.Text = "Auto complete with suggest";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(468, 332);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(220, 16);
            this.label4.TabIndex = 19;
            this.label4.Text = "Auto complete with suggest append";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(8, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(858, 38);
            this.label5.TabIndex = 0;
            this.label5.Text = "The following sample demonstrates the default functionalities of SfComboBox such " +
    "as edit mode, AutoCompleteMode, DropDownStyle and Watermark text";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(468, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 16);
            this.label6.TabIndex = 20;
            this.label6.Text = "Choose theme";
            // 
            // themeComboBox
            // 
            this.themeComboBox.DropDownStyle = Syncfusion.WinForms.ListView.Enums.DropDownStyle.DropDownList;
            this.themeComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.themeComboBox.Location = new System.Drawing.Point(583, 89);
            this.themeComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.themeComboBox.Name = "themeComboBox";
            this.themeComboBox.Size = new System.Drawing.Size(170, 30);
            this.themeComboBox.TabIndex = 1;
            this.themeComboBox.SelectedValueChanged += new System.EventHandler(this.themeComboBox_SelectedValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(468, 485);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 16);
            this.label7.TabIndex = 25;
            this.label7.Text = "Drop down list";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(95, 485);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(169, 16);
            this.label8.TabIndex = 24;
            this.label8.Text = "Auto complete with append";
            // 
            // suggestAppend
            // 
            this.suggestAppend.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.suggestAppend.Location = new System.Drawing.Point(471, 366);
            this.suggestAppend.Margin = new System.Windows.Forms.Padding(4);
            this.suggestAppend.Name = "suggestAppend";
            this.suggestAppend.Size = new System.Drawing.Size(291, 30);
            this.suggestAppend.TabIndex = 5;
            // 
            // append
            // 
            this.append.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.append.Location = new System.Drawing.Point(95, 519);
            this.append.Margin = new System.Windows.Forms.Padding(4);
            this.append.Name = "append";
            this.append.Size = new System.Drawing.Size(291, 30);
            this.append.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 614);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.suggestAppend);
            this.Controls.Add(this.append);
            this.Controls.Add(this.themeComboBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dropDownStyle);
            this.Controls.Add(this.suggest);
            this.Controls.Add(this.waterMark);
            this.Controls.Add(this.editMode);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Getting Started";
            ((System.ComponentModel.ISupportInitialize)(this.editMode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.waterMark)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dropDownStyle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.suggest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.themeComboBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.suggestAppend)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.append)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Syncfusion.WinForms.ListView.SfComboBox editMode;
        private Syncfusion.WinForms.ListView.SfComboBox waterMark;
        private Syncfusion.WinForms.ListView.SfComboBox dropDownStyle;
        private Syncfusion.WinForms.ListView.SfComboBox suggest;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private Syncfusion.WinForms.ListView.SfComboBox themeComboBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private Syncfusion.WinForms.ListView.SfComboBox suggestAppend;
        private Syncfusion.WinForms.ListView.SfComboBox append;
    }
}


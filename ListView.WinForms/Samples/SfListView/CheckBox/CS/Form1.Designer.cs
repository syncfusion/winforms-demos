using System;

namespace Checking
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.selectionCombo = new Syncfusion.WinForms.ListView.SfComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.chkBoxSelectionCombo = new Syncfusion.WinForms.ListView.SfComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.sfListView1 = new Syncfusion.WinForms.ListView.SfListView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.selectionCombo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkBoxSelectionCombo)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.selectionCombo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.chkBoxSelectionCombo);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(542, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(336, 116);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Options";
            // 
            // selectionCombo
            // 
            this.selectionCombo.DropDownStyle = Syncfusion.WinForms.ListView.Enums.DropDownStyle.DropDownList;
            this.selectionCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectionCombo.Location = new System.Drawing.Point(152, 65);
            this.selectionCombo.Name = "selectionCombo";
            this.selectionCombo.Size = new System.Drawing.Size(162, 29);
            this.selectionCombo.Style.EditorStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectionCombo.Style.ReadOnlyEditorStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectionCombo.TabIndex = 8;
            this.selectionCombo.SelectedValueChanged += new System.EventHandler(this.selectionCombo_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Selection mode";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Checkbox selection";
            // 
            // chkBoxSelectionCombo
            // 
            this.chkBoxSelectionCombo.DropDownStyle = Syncfusion.WinForms.ListView.Enums.DropDownStyle.DropDownList;
            this.chkBoxSelectionCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBoxSelectionCombo.Location = new System.Drawing.Point(152, 26);
            this.chkBoxSelectionCombo.Name = "chkBoxSelectionCombo";
            this.chkBoxSelectionCombo.Size = new System.Drawing.Size(162, 29);
            this.chkBoxSelectionCombo.Style.EditorStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBoxSelectionCombo.Style.ReadOnlyEditorStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBoxSelectionCombo.TabIndex = 4;
            this.chkBoxSelectionCombo.SelectedValueChanged += new System.EventHandler(this.chkBoxSelectionCombo_SelectedValueChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.sfListView1);
            this.panel2.Location = new System.Drawing.Point(23, 24);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(498, 529);
            this.panel2.TabIndex = 2;
            // 
            // sfListView1
            // 
            this.sfListView1.AccessibleName = "ScrollControl";
            this.sfListView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sfListView1.Location = new System.Drawing.Point(0, 0);
            this.sfListView1.Name = "sfListView1";
            this.sfListView1.Size = new System.Drawing.Size(498, 529);
            this.sfListView1.TabIndex = 0;
            this.sfListView1.Text = "sfListView1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 576);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CheckBox";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.selectionCombo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkBoxSelectionCombo)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Syncfusion.WinForms.ListView.SfListView sfListView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private Syncfusion.WinForms.ListView.SfComboBox chkBoxSelectionCombo;
        private Syncfusion.WinForms.ListView.SfComboBox selectionCombo;
        private System.Windows.Forms.Label label1;
    }
}


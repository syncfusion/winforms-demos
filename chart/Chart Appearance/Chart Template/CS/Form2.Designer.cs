#region Copyright Syncfusion Inc. 2001-2019.
// Copyright Syncfusion Inc. 2001-2019. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
namespace ChartTemplate_2005
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.buttonAdv2 = new System.Windows.Forms.Button();
            this.buttonAdv1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.BackColor = System.Drawing.Color.Transparent;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(13, 17);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(195, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Save changes to the same template";
            this.radioButton1.UseVisualStyleBackColor = false;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.BackColor = System.Drawing.Color.Transparent;
            this.radioButton2.Location = new System.Drawing.Point(13, 50);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(183, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.Text = "Save changes as a new template";
            this.radioButton2.UseVisualStyleBackColor = false;
            // 
            // buttonAdv2
            // 
            this.buttonAdv2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonAdv2.Location = new System.Drawing.Point(112, 85);
            this.buttonAdv2.Name = "buttonAdv2";
            this.buttonAdv2.Size = new System.Drawing.Size(67, 23);
            this.buttonAdv2.TabIndex = 3;
            this.buttonAdv2.Text = "Cancel";
            // 
            // buttonAdv1
            // 
            this.buttonAdv1.Location = new System.Drawing.Point(32, 85);
            this.buttonAdv1.Name = "buttonAdv1";
            this.buttonAdv1.Size = new System.Drawing.Size(67, 23);
            this.buttonAdv1.TabIndex = 2;
            this.buttonAdv1.Text = "Save";
            // 
            // Form2
            // 
            this.AcceptButton = this.buttonAdv1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.buttonAdv2;
            this.ClientSize = new System.Drawing.Size(221, 121);
            this.ControlBox = false;
            this.Controls.Add(this.buttonAdv1);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.buttonAdv2);
            this.Controls.Add(this.radioButton2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Save Template";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.RadioButton radioButton1;
        public System.Windows.Forms.RadioButton radioButton2;
        public System.Windows.Forms.Button buttonAdv2;
        public System.Windows.Forms.Button buttonAdv1;
    }
}
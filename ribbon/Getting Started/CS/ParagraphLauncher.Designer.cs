#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
namespace WF_Word
{
    partial class ParagraphLauncher
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.indentlabel = new System.Windows.Forms.Label();
            this.leftLabel = new System.Windows.Forms.Label();
            this.rightlabel = new System.Windows.Forms.Label();
            this.leftnumericUpDownExt = new Syncfusion.Windows.Forms.Tools.NumericUpDownExt();
            this.rightNumericUpDownExt = new Syncfusion.Windows.Forms.Tools.NumericUpDownExt();
            this.Okbutton = new Syncfusion.Windows.Forms.ButtonAdv();
            this.cancelButtonAdv = new Syncfusion.Windows.Forms.ButtonAdv();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.leftnumericUpDownExt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightNumericUpDownExt)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.rightNumericUpDownExt);
            this.panel1.Controls.Add(this.leftnumericUpDownExt);
            this.panel1.Controls.Add(this.rightlabel);
            this.panel1.Controls.Add(this.leftLabel);
            this.panel1.Controls.Add(this.indentlabel);
            this.panel1.Location = new System.Drawing.Point(6, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(245, 187);
            this.panel1.TabIndex = 0;
            // 
            // indentlabel
            // 
            this.indentlabel.AutoSize = true;
            this.indentlabel.Location = new System.Drawing.Point(15, 10);
            this.indentlabel.Name = "indentlabel";
            this.indentlabel.Size = new System.Drawing.Size(60, 13);
            this.indentlabel.TabIndex = 0;
            this.indentlabel.Text = "Indentation";
            // 
            // leftLabel
            // 
            this.leftLabel.AutoSize = true;
            this.leftLabel.Location = new System.Drawing.Point(15, 70);
            this.leftLabel.Name = "leftLabel";
            this.leftLabel.Size = new System.Drawing.Size(28, 13);
            this.leftLabel.TabIndex = 1;
            this.leftLabel.Text = "Left:";
            // 
            // rightlabel
            // 
            this.rightlabel.AutoSize = true;
            this.rightlabel.Location = new System.Drawing.Point(15, 119);
            this.rightlabel.Name = "rightlabel";
            this.rightlabel.Size = new System.Drawing.Size(35, 13);
            this.rightlabel.TabIndex = 2;
            this.rightlabel.Text = "Right:";
            // 
            // leftnumericUpDownExt
            // 
            this.leftnumericUpDownExt.BeforeTouchSize = new System.Drawing.Size(120, 20);
            this.leftnumericUpDownExt.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.leftnumericUpDownExt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.leftnumericUpDownExt.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.leftnumericUpDownExt.Location = new System.Drawing.Point(90, 63);
            this.leftnumericUpDownExt.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.leftnumericUpDownExt.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.leftnumericUpDownExt.Name = "leftnumericUpDownExt";
            this.leftnumericUpDownExt.Size = new System.Drawing.Size(120, 20);
            this.leftnumericUpDownExt.TabIndex = 3;
            this.leftnumericUpDownExt.VisualStyle = Syncfusion.Windows.Forms.VisualStyle.Metro;
            // 
            // rightNumericUpDownExt
            // 
            this.rightNumericUpDownExt.BeforeTouchSize = new System.Drawing.Size(120, 20);
            this.rightNumericUpDownExt.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.rightNumericUpDownExt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rightNumericUpDownExt.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.rightNumericUpDownExt.Location = new System.Drawing.Point(90, 119);
            this.rightNumericUpDownExt.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.rightNumericUpDownExt.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.rightNumericUpDownExt.Name = "rightNumericUpDownExt";
            this.rightNumericUpDownExt.Size = new System.Drawing.Size(120, 20);
            this.rightNumericUpDownExt.TabIndex = 4;
            this.rightNumericUpDownExt.VisualStyle = Syncfusion.Windows.Forms.VisualStyle.Metro;
            // 
            // Okbutton
            // 
            this.Okbutton.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.Okbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.Okbutton.BeforeTouchSize = new System.Drawing.Size(75, 23);
            this.Okbutton.ForeColor = System.Drawing.Color.Black;
            this.Okbutton.IsBackStageButton = false;
            this.Okbutton.Location = new System.Drawing.Point(96, 208);
            this.Okbutton.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.Okbutton.Name = "Okbutton";
            this.Okbutton.Size = new System.Drawing.Size(75, 23);
            this.Okbutton.TabIndex = 1;
            this.Okbutton.Text = "OK";
            this.Okbutton.UseVisualStyle = true;
            this.Okbutton.Click += new System.EventHandler(this.Okbutton_Click);
            // 
            // cancelButtonAdv
            // 
            this.cancelButtonAdv.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.cancelButtonAdv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.cancelButtonAdv.BeforeTouchSize = new System.Drawing.Size(75, 23);
            this.cancelButtonAdv.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButtonAdv.ForeColor = System.Drawing.Color.Black;
            this.cancelButtonAdv.IsBackStageButton = false;
            this.cancelButtonAdv.Location = new System.Drawing.Point(177, 208);
            this.cancelButtonAdv.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.cancelButtonAdv.Name = "cancelButtonAdv";
            this.cancelButtonAdv.Size = new System.Drawing.Size(75, 23);
            this.cancelButtonAdv.TabIndex = 2;
            this.cancelButtonAdv.Text = "Cancel";
            this.cancelButtonAdv.UseVisualStyle = true;
            // 
            // ParagraphLauncher
            // 
            this.AcceptButton = this.Okbutton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.CancelButton = this.cancelButtonAdv;
            this.CaptionAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ClientSize = new System.Drawing.Size(258, 243);
            this.Controls.Add(this.cancelButtonAdv);
            this.Controls.Add(this.Okbutton);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ParagraphLauncher";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.ShowMaximizeBox = false;
            this.ShowMinimizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Paragraph";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.leftnumericUpDownExt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightNumericUpDownExt)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Syncfusion.Windows.Forms.Tools.NumericUpDownExt rightNumericUpDownExt;
        private Syncfusion.Windows.Forms.Tools.NumericUpDownExt leftnumericUpDownExt;
        private System.Windows.Forms.Label rightlabel;
        private System.Windows.Forms.Label leftLabel;
        private System.Windows.Forms.Label indentlabel;
        private Syncfusion.Windows.Forms.ButtonAdv Okbutton;
        private Syncfusion.Windows.Forms.ButtonAdv cancelButtonAdv;
    }
}
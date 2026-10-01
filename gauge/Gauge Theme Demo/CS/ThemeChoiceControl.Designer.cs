#region Copyright Syncfusion Inc. 2001 - 2019
// Copyright Syncfusion Inc. 2001 - 2019. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
namespace GaugeTheme_2010
{
    partial class ThemeChoiceControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.BrushName = new System.Windows.Forms.Label();
            this.buttonEdit1 = new Syncfusion.Windows.Forms.Tools.ButtonEdit();
            this.buttonEditChildButton1 = new Syncfusion.Windows.Forms.Tools.ButtonEditChildButton();
            this.textBoxExt2 = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            ((System.ComponentModel.ISupportInitialize)(this.buttonEdit1)).BeginInit();
            this.buttonEdit1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxExt2)).BeginInit();
            this.SuspendLayout();
            // 
            // BrushName
            // 
            this.BrushName.AutoSize = true;
            this.BrushName.Location = new System.Drawing.Point(6, 2);
            this.BrushName.Name = "BrushName";
            this.BrushName.Size = new System.Drawing.Size(65, 13);
            this.BrushName.TabIndex = 2;
            this.BrushName.Text = "Brush Name";
            // 
            // buttonEdit1
            // 
            this.buttonEdit1.BeforeTouchSize = new System.Drawing.Size(121, 21);
            this.buttonEdit1.Buttons.Add(this.buttonEditChildButton1);
            this.buttonEdit1.ButtonStyle = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.buttonEdit1.Controls.Add(this.buttonEditChildButton1);
            this.buttonEdit1.Controls.Add(this.textBoxExt2);
            this.buttonEdit1.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonEdit1.Location = new System.Drawing.Point(168, 0);
            this.buttonEdit1.Name = "buttonEdit1";
            this.buttonEdit1.Size = new System.Drawing.Size(121, 21);
            this.buttonEdit1.TabIndex = 3;
            this.buttonEdit1.TextBox = this.textBoxExt2;
            this.buttonEdit1.UseVisualStyle = true;
            // 
            // buttonEditChildButton1
            // 
            this.buttonEditChildButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.buttonEditChildButton1.BeforeTouchSize = new System.Drawing.Size(18, 17);
            this.buttonEditChildButton1.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.Flat;
            this.buttonEditChildButton1.ComboEditBackColor = System.Drawing.SystemColors.Window;
            this.buttonEditChildButton1.ForeColor = System.Drawing.Color.White;
            this.buttonEditChildButton1.Image = null;
            this.buttonEditChildButton1.IsBackStageButton = false;
            this.buttonEditChildButton1.Name = "buttonEditChildButton1";
            this.buttonEditChildButton1.PreferredWidth = 18;
            this.buttonEditChildButton1.TabIndex = 1;
            // 
            // textBoxExt2
            // 
            this.textBoxExt2.BeforeTouchSize = new System.Drawing.Size(99, 13);
            this.textBoxExt2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxExt2.Location = new System.Drawing.Point(2, 4);
            this.textBoxExt2.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.textBoxExt2.Name = "textBoxExt2";
            this.textBoxExt2.Size = new System.Drawing.Size(99, 13);
            this.textBoxExt2.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.textBoxExt2.TabIndex = 0;
            // 
            // ThemeChoiceControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.buttonEdit1);
            this.Controls.Add(this.BrushName);
            this.Name = "ThemeChoiceControl";
            this.Size = new System.Drawing.Size(289, 27);
            ((System.ComponentModel.ISupportInitialize)(this.buttonEdit1)).EndInit();
            this.buttonEdit1.ResumeLayout(false);
            this.buttonEdit1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxExt2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label BrushName;
        public Syncfusion.Windows.Forms.Tools.ButtonEdit buttonEdit1;
        public Syncfusion.Windows.Forms.Tools.ButtonEditChildButton buttonEditChildButton1;
        public Syncfusion.Windows.Forms.Tools.TextBoxExt textBoxExt2;
    }
}

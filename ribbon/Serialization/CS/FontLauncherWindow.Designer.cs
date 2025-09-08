#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
namespace WF_Word
{
    partial class FontLauncherWindow
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
            this.basepanel = new System.Windows.Forms.Panel();
            this.fontcombobox = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.subScriptcheckBox = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.superScriptcheckBox = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.capsCheckBox = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.strikethroughcheckBox = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.effectsLabel = new System.Windows.Forms.Label();
            this.fontColorLabel = new System.Windows.Forms.Label();
            this.SizecomboBox = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.styleComboBox = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.sizelabel = new System.Windows.Forms.Label();
            this.fontstylelabel = new System.Windows.Forms.Label();
            this.fontlabel = new System.Windows.Forms.Label();
            this.cancelbutton = new System.Windows.Forms.Button();
            this.OKbutton = new System.Windows.Forms.Button();
            this.colorPickerButton1 = new Syncfusion.Windows.Forms.ColorPickerButton();
            this.basepanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fontcombobox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subScriptcheckBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.superScriptcheckBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.capsCheckBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.strikethroughcheckBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SizecomboBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.styleComboBox)).BeginInit();
            this.SuspendLayout();
            // 
            // basepanel
            // 
            this.basepanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.basepanel.BackColor = System.Drawing.Color.White;
            this.basepanel.Controls.Add(this.colorPickerButton1);
            this.basepanel.Controls.Add(this.fontcombobox);
            this.basepanel.Controls.Add(this.subScriptcheckBox);
            this.basepanel.Controls.Add(this.superScriptcheckBox);
            this.basepanel.Controls.Add(this.capsCheckBox);
            this.basepanel.Controls.Add(this.strikethroughcheckBox);
            this.basepanel.Controls.Add(this.effectsLabel);
            this.basepanel.Controls.Add(this.fontColorLabel);
            this.basepanel.Controls.Add(this.SizecomboBox);
            this.basepanel.Controls.Add(this.styleComboBox);
            this.basepanel.Controls.Add(this.sizelabel);
            this.basepanel.Controls.Add(this.fontstylelabel);
            this.basepanel.Controls.Add(this.fontlabel);
            this.basepanel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.basepanel.Location = new System.Drawing.Point(6, 15);
            this.basepanel.Name = "basepanel";
            this.basepanel.Size = new System.Drawing.Size(385, 402);
            this.basepanel.TabIndex = 0;
            // 
            // fontcombobox
            // 
            this.fontcombobox.BeforeTouchSize = new System.Drawing.Size(182, 110);
            this.fontcombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.fontcombobox.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fontcombobox.Location = new System.Drawing.Point(17, 70);
            this.fontcombobox.Name = "fontcombobox";
            this.fontcombobox.Size = new System.Drawing.Size(182, 110);
            this.fontcombobox.TabIndex = 14;
            this.fontcombobox.Text = "comboBoxAdv3";
            // 
            // subScriptcheckBox
            // 
            this.subScriptcheckBox.BeforeTouchSize = new System.Drawing.Size(150, 21);
            this.subScriptcheckBox.Location = new System.Drawing.Point(213, 365);
            this.subScriptcheckBox.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(89)))), ((int)(((byte)(91)))));
            this.subScriptcheckBox.Name = "subScriptcheckBox";
            this.subScriptcheckBox.Size = new System.Drawing.Size(150, 21);
            this.subScriptcheckBox.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.subScriptcheckBox.TabIndex = 13;
            this.subScriptcheckBox.Text = "Subscript";
            this.subScriptcheckBox.ThemesEnabled = false;
            // 
            // superScriptcheckBox
            // 
            this.superScriptcheckBox.BeforeTouchSize = new System.Drawing.Size(150, 21);
            this.superScriptcheckBox.Location = new System.Drawing.Point(213, 338);
            this.superScriptcheckBox.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(89)))), ((int)(((byte)(91)))));
            this.superScriptcheckBox.Name = "superScriptcheckBox";
            this.superScriptcheckBox.Size = new System.Drawing.Size(150, 21);
            this.superScriptcheckBox.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.superScriptcheckBox.TabIndex = 12;
            this.superScriptcheckBox.Text = "Superscript";
            this.superScriptcheckBox.ThemesEnabled = false;
            // 
            // capsCheckBox
            // 
            this.capsCheckBox.BeforeTouchSize = new System.Drawing.Size(150, 21);
            this.capsCheckBox.Location = new System.Drawing.Point(17, 365);
            this.capsCheckBox.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(89)))), ((int)(((byte)(91)))));
            this.capsCheckBox.Name = "capsCheckBox";
            this.capsCheckBox.Size = new System.Drawing.Size(150, 21);
            this.capsCheckBox.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.capsCheckBox.TabIndex = 11;
            this.capsCheckBox.Text = "Caps";
            this.capsCheckBox.ThemesEnabled = false;
            // 
            // strikethroughcheckBox
            // 
            this.strikethroughcheckBox.BeforeTouchSize = new System.Drawing.Size(150, 21);
            this.strikethroughcheckBox.Location = new System.Drawing.Point(17, 338);
            this.strikethroughcheckBox.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(89)))), ((int)(((byte)(91)))));
            this.strikethroughcheckBox.Name = "strikethroughcheckBox";
            this.strikethroughcheckBox.Size = new System.Drawing.Size(150, 21);
            this.strikethroughcheckBox.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.strikethroughcheckBox.TabIndex = 10;
            this.strikethroughcheckBox.Text = "Strikethrough";
            this.strikethroughcheckBox.ThemesEnabled = false;
            // 
            // effectsLabel
            // 
            this.effectsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.effectsLabel.AutoSize = true;
            this.effectsLabel.Location = new System.Drawing.Point(17, 309);
            this.effectsLabel.Name = "effectsLabel";
            this.effectsLabel.Size = new System.Drawing.Size(41, 13);
            this.effectsLabel.TabIndex = 7;
            this.effectsLabel.Text = "Effects";
            // 
            // fontColorLabel
            // 
            this.fontColorLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fontColorLabel.AutoSize = true;
            this.fontColorLabel.Location = new System.Drawing.Point(17, 231);
            this.fontColorLabel.Name = "fontColorLabel";
            this.fontColorLabel.Size = new System.Drawing.Size(65, 13);
            this.fontColorLabel.TabIndex = 6;
            this.fontColorLabel.Text = "Font Color:";
            // 
            // SizecomboBox
            // 
            this.SizecomboBox.BeforeTouchSize = new System.Drawing.Size(59, 110);
            this.SizecomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.SizecomboBox.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SizecomboBox.Items.AddRange(new object[] {
            "8",
            "9",
            "10",
            "11",
            "12",
            "14",
            "16",
            "18",
            "20",
            "22",
            "24",
            "26",
            "28",
            "36",
            "48",
            "72"});
            this.SizecomboBox.Location = new System.Drawing.Point(304, 70);
            this.SizecomboBox.Name = "SizecomboBox";
            this.SizecomboBox.Size = new System.Drawing.Size(59, 110);
            this.SizecomboBox.TabIndex = 5;
            // 
            // styleComboBox
            // 
            this.styleComboBox.BeforeTouchSize = new System.Drawing.Size(90, 110);
            this.styleComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.styleComboBox.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.styleComboBox.Items.AddRange(new object[] {
            "Regular",
            "Italic",
            "Bold",
            "Bold Italic"});
            this.styleComboBox.Location = new System.Drawing.Point(205, 70);
            this.styleComboBox.Name = "styleComboBox";
            this.styleComboBox.Size = new System.Drawing.Size(90, 110);
            this.styleComboBox.TabIndex = 3;
            // 
            // sizelabel
            // 
            this.sizelabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sizelabel.AutoSize = true;
            this.sizelabel.Location = new System.Drawing.Point(304, 36);
            this.sizelabel.Name = "sizelabel";
            this.sizelabel.Size = new System.Drawing.Size(30, 13);
            this.sizelabel.TabIndex = 2;
            this.sizelabel.Text = "Size:";
            // 
            // fontstylelabel
            // 
            this.fontstylelabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fontstylelabel.AutoSize = true;
            this.fontstylelabel.Location = new System.Drawing.Point(179, 36);
            this.fontstylelabel.Name = "fontstylelabel";
            this.fontstylelabel.Size = new System.Drawing.Size(60, 13);
            this.fontstylelabel.TabIndex = 1;
            this.fontstylelabel.Text = "Font style:";
            // 
            // fontlabel
            // 
            this.fontlabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fontlabel.AutoSize = true;
            this.fontlabel.Location = new System.Drawing.Point(17, 36);
            this.fontlabel.Name = "fontlabel";
            this.fontlabel.Size = new System.Drawing.Size(34, 13);
            this.fontlabel.TabIndex = 0;
            this.fontlabel.Text = "Font:";
            // 
            // cancelbutton
            // 
            this.cancelbutton.Location = new System.Drawing.Point(317, 425);
            this.cancelbutton.Name = "cancelbutton";
            this.cancelbutton.Size = new System.Drawing.Size(75, 23);
            this.cancelbutton.TabIndex = 17;
            this.cancelbutton.Text = "Cancel";
            this.cancelbutton.UseVisualStyleBackColor = true;
            this.cancelbutton.Click += new System.EventHandler(this.cancelbutton_Click);
            // 
            // OKbutton
            // 
            this.OKbutton.Location = new System.Drawing.Point(236, 425);
            this.OKbutton.Name = "OKbutton";
            this.OKbutton.Size = new System.Drawing.Size(75, 23);
            this.OKbutton.TabIndex = 16;
            this.OKbutton.Text = "OK";
            this.OKbutton.UseVisualStyleBackColor = true;
            this.OKbutton.Click += new System.EventHandler(this.OKbutton_Click);
            // 
            // colorPickerButton1
            // 
            this.colorPickerButton1.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.colorPickerButton1.BackColor = System.Drawing.SystemColors.Control;
            this.colorPickerButton1.BeforeTouchSize = new System.Drawing.Size(163, 23);
            this.colorPickerButton1.ColorUISize = new System.Drawing.Size(208, 230);
            this.colorPickerButton1.ForeColor = System.Drawing.Color.Black;
            this.colorPickerButton1.IsBackStageButton = false;
            this.colorPickerButton1.Location = new System.Drawing.Point(20, 267);
            this.colorPickerButton1.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.colorPickerButton1.Name = "colorPickerButton1";
            this.colorPickerButton1.SelectedAsText = true;
            this.colorPickerButton1.SelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.colorPickerButton1.Size = new System.Drawing.Size(163, 23);
            this.colorPickerButton1.TabIndex = 15;
            this.colorPickerButton1.Text = "ff404040";
            this.colorPickerButton1.UseVisualStyle = true;
            // 
            // FontLauncherWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.CaptionAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.CaptionFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClientSize = new System.Drawing.Size(399, 460);
            this.Controls.Add(this.cancelbutton);
            this.Controls.Add(this.basepanel);
            this.Controls.Add(this.OKbutton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.HelpButton = true;
            this.Name = "FontLauncherWindow";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.ShowMaximizeBox = false;
            this.ShowMinimizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Font";
            this.basepanel.ResumeLayout(false);
            this.basepanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fontcombobox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subScriptcheckBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.superScriptcheckBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.capsCheckBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.strikethroughcheckBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SizecomboBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.styleComboBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel basepanel;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv SizecomboBox;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv styleComboBox;
        private System.Windows.Forms.Label sizelabel;
        private System.Windows.Forms.Label fontstylelabel;
        private System.Windows.Forms.Label fontlabel;
        private Syncfusion.Windows.Forms.Tools.CheckBoxAdv subScriptcheckBox;
        private Syncfusion.Windows.Forms.Tools.CheckBoxAdv superScriptcheckBox;
        private Syncfusion.Windows.Forms.Tools.CheckBoxAdv capsCheckBox;
        private Syncfusion.Windows.Forms.Tools.CheckBoxAdv strikethroughcheckBox;
        private System.Windows.Forms.Label effectsLabel;
        private System.Windows.Forms.Label fontColorLabel;
        private System.Windows.Forms.Button cancelbutton;
        private System.Windows.Forms.Button OKbutton;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv fontcombobox;
        private Syncfusion.Windows.Forms.ColorPickerButton colorPickerButton1;
    }
}
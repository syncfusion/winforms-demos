#region Copyright Syncfusion Inc. 2001-2019.
// Copyright Syncfusion Inc. 2001-2019. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Syncfusion.Windows.Forms.Tools;
using System.Windows.Forms;

namespace ColorPicker_demo
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
            Syncfusion.Windows.Forms.MetroColorTable metroColorTable1 = new Syncfusion.Windows.Forms.MetroColorTable();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label5 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.label3 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.label2 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.colorUIControl1 = new Syncfusion.Windows.Forms.ColorUIControl();
            this.colorPickerButton2 = new Syncfusion.Windows.Forms.ColorPickerButton();
            this.colorPickerUIAdv1 = new Syncfusion.Windows.Forms.Tools.ColorPickerUIAdv();
            this.buttonAdv1 = new System.Windows.Forms.Panel();
            this.buttonAdv2 = new System.Windows.Forms.Panel();
            this.buttonAdv3 = new System.Windows.Forms.Panel();
            this.autoLabel10 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.sfComboBox1 = new Syncfusion.WinForms.ListView.SfComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.sfComboBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label5.Location = new System.Drawing.Point(686, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 16);
            this.label5.TabIndex = 19;
            this.label5.Text = "ColorPickerUIAdv";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label5.ThemeStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label3.Location = new System.Drawing.Point(336, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 16);
            this.label3.TabIndex = 18;
            this.label3.Text = "ColorUIControl";
            this.label3.ThemeStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label2.Location = new System.Drawing.Point(24, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 16);
            this.label2.TabIndex = 17;
            this.label2.Text = "ColorPickerButton";
            this.label2.ThemeStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            // 
            // colorUIControl1
            // 
            this.colorUIControl1.BeforeTouchSize = new System.Drawing.Size(200, 172);
            this.colorUIControl1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.colorUIControl1.Location = new System.Drawing.Point(290, 137);
            this.colorUIControl1.Margin = new System.Windows.Forms.Padding(2);
            this.colorUIControl1.Name = "colorUIControl1";
            this.colorUIControl1.ScrollMetroColorTable = metroColorTable1;
            this.colorUIControl1.SelectedColorGroup = Syncfusion.Windows.Forms.ColorUISelectedGroup.CustomColors;
            this.colorUIControl1.ShowUserSelectionColors = false;
            this.colorUIControl1.Size = new System.Drawing.Size(200, 172);
            this.colorUIControl1.TabIndex = 15;
            this.colorUIControl1.Text = "colorUIControl1";
            this.colorUIControl1.ThemeName = "Office2019Colorful";
            this.colorUIControl1.ThemeStyle.ColorListStyle.PaletteBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.colorUIControl1.ThemeStyle.ColorListStyle.SelectedItemForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.colorUIControl1.ThemeStyle.ColorPaletteStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.colorUIControl1.ThemeStyle.ColorPaletteStyle.SelectedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(103)))), ((int)(((byte)(176)))));
            this.colorUIControl1.ColorSelected += new System.EventHandler(this.colorUIControl1_ColorSelected);
            // 
            // colorPickerButton2
            // 
            this.colorPickerButton2.BeforeTouchSize = new System.Drawing.Size(119, 57);
            this.colorPickerButton2.ColorUISize = new System.Drawing.Size(200, 172);
            this.colorPickerButton2.Location = new System.Drawing.Point(39, 137);
            this.colorPickerButton2.Margin = new System.Windows.Forms.Padding(2);
            this.colorPickerButton2.Name = "colorPickerButton2";
            this.colorPickerButton2.SelectedColorGroup = Syncfusion.Windows.Forms.ColorUISelectedGroup.CustomColors;
            this.colorPickerButton2.Size = new System.Drawing.Size(119, 57);
            this.colorPickerButton2.TabIndex = 14;
            this.colorPickerButton2.Text = "ColorPickerButton";
            this.colorPickerButton2.ThemeName = "Office2019Colorful";
            this.colorPickerButton2.ColorSelected += new System.EventHandler(this.colorPickerButton2_ColorSelected);
            this.colorPickerButton2.Click += new System.EventHandler(this.colorPickerButton2_Click);
            // 
            // colorPickerUIAdv1.RecentGroup
            // 
            this.colorPickerUIAdv1.RecentGroup.HeaderHeight = 17;
            this.colorPickerUIAdv1.RecentGroup.Name = "Recent Colors";
            this.colorPickerUIAdv1.RecentGroup.Visible = false;
            // 
            // colorPickerUIAdv1.StandardGroup
            // 
            this.colorPickerUIAdv1.StandardGroup.HeaderHeight = 17;
            this.colorPickerUIAdv1.StandardGroup.Name = "Standard Colors";
            // 
            // colorPickerUIAdv1.ThemeGroup
            // 
            this.colorPickerUIAdv1.ThemeGroup.HeaderHeight = 17;
            this.colorPickerUIAdv1.ThemeGroup.IsSubItemsVisible = true;
            this.colorPickerUIAdv1.ThemeGroup.Name = "Theme Colors";
            // 
            // colorPickerUIAdv1
            // 
            this.colorPickerUIAdv1.ButtonsHeight = 25;
            this.colorPickerUIAdv1.ColorItemSize = new System.Drawing.Size(17, 17);
            this.colorPickerUIAdv1.Location = new System.Drawing.Point(664, 137);
            this.colorPickerUIAdv1.MinimumSize = new System.Drawing.Size(136, 193);
            this.colorPickerUIAdv1.Name = "colorPickerUIAdv1";
            this.colorPickerUIAdv1.Size = new System.Drawing.Size(212, 237);
            this.colorPickerUIAdv1.TabIndex = 20;
            this.colorPickerUIAdv1.Text = "colorPickerUIAdv1";
            this.colorPickerUIAdv1.ThemeName = "Office2019Colorful";
            this.colorPickerUIAdv1.Picked += new Syncfusion.Windows.Forms.Tools.ColorPickerUIAdv.ColorPickedEventHandler(this.colorPickerUIAdv1_Picked);
            // 
            // buttonAdv1
            // 
            this.buttonAdv1.Location = new System.Drawing.Point(138, 98);
            this.buttonAdv1.Name = "buttonAdv1";
            this.buttonAdv1.Size = new System.Drawing.Size(27, 29);
            this.buttonAdv1.TabIndex = 21;
            // 
            // buttonAdv2
            // 
            this.buttonAdv2.Location = new System.Drawing.Point(432, 98);
            this.buttonAdv2.Name = "buttonAdv2";
            this.buttonAdv2.Size = new System.Drawing.Size(26, 29);
            this.buttonAdv2.TabIndex = 22;
            // 
            // buttonAdv3
            // 
            this.buttonAdv3.Location = new System.Drawing.Point(804, 98);
            this.buttonAdv3.Name = "buttonAdv3";
            this.buttonAdv3.Size = new System.Drawing.Size(27, 29);
            this.buttonAdv3.TabIndex = 23;
            // 
            // autoLabel10
            // 
            this.autoLabel10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoLabel10.Location = new System.Drawing.Point(617, 24);
            this.autoLabel10.Name = "autoLabel10";
            this.autoLabel10.Size = new System.Drawing.Size(107, 16);
            this.autoLabel10.TabIndex = 56;
            this.autoLabel10.Text = "Choose theme";
            this.autoLabel10.ThemeStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            // 
            // sfComboBox1
            // 
            this.sfComboBox1.DropDownStyle = Syncfusion.WinForms.ListView.Enums.DropDownStyle.DropDownList;
            this.sfComboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sfComboBox1.Location = new System.Drawing.Point(719, 23);
            this.sfComboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.sfComboBox1.Name = "sfComboBox1";
            this.sfComboBox1.Size = new System.Drawing.Size(157, 21);
            this.sfComboBox1.Style.EditorStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sfComboBox1.Style.ReadOnlyEditorStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sfComboBox1.TabIndex = 55;
            this.sfComboBox1.SelectedIndexChanged += new System.EventHandler(this.sfComboBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 434);
            this.Controls.Add(this.autoLabel10);
            this.Controls.Add(this.sfComboBox1);
            this.Controls.Add(this.buttonAdv3);
            this.Controls.Add(this.buttonAdv2);
            this.Controls.Add(this.buttonAdv1);
            this.Controls.Add(this.colorPickerUIAdv1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.colorUIControl1);
            this.Controls.Add(this.colorPickerButton2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Color Picker";
            ((System.ComponentModel.ISupportInitialize)(this.sfComboBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private AutoLabel label5;
        private AutoLabel label3;
        private AutoLabel label2;
        private Syncfusion.Windows.Forms.ColorUIControl colorUIControl1;
        private Syncfusion.Windows.Forms.ColorPickerButton colorPickerButton2;
        private Syncfusion.Windows.Forms.Tools.ColorPickerUIAdv colorPickerUIAdv1;
        private Panel buttonAdv1;
        private Panel buttonAdv2;
        private Panel buttonAdv3;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel10;
        private Syncfusion.WinForms.ListView.SfComboBox sfComboBox1;
    }
}


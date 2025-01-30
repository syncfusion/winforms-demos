#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
namespace FindReplace
{
    partial class GridFindReplaceDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GridFindReplaceDialog));
            this.panel1 = new System.Windows.Forms.Panel();
            this.ReplaceAllBtn = new Syncfusion.Windows.Forms.ButtonAdv();
            this.txtReplace = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.replaceLabel = new System.Windows.Forms.Label();
            this.comboBox1 = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.cmbOptions = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.matchAllChkbox = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.checkBox1 = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.searchupChkbox = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.ReplaceBtn = new Syncfusion.Windows.Forms.ButtonAdv();
            this.matchChkbox = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.cancelbtn = new Syncfusion.Windows.Forms.ButtonAdv();
            this.findallBtn = new Syncfusion.Windows.Forms.ButtonAdv();
            this.findnextBtn = new Syncfusion.Windows.Forms.ButtonAdv();
            this.txtSearch = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.findLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtReplace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbOptions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.matchAllChkbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchupChkbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.matchChkbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.ReplaceAllBtn);
            this.panel1.Controls.Add(this.txtReplace);
            this.panel1.Controls.Add(this.replaceLabel);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.cmbOptions);
            this.panel1.Controls.Add(this.matchAllChkbox);
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Controls.Add(this.searchupChkbox);
            this.panel1.Controls.Add(this.ReplaceBtn);
            this.panel1.Controls.Add(this.matchChkbox);
            this.panel1.Controls.Add(this.cancelbtn);
            this.panel1.Controls.Add(this.findallBtn);
            this.panel1.Controls.Add(this.findnextBtn);
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Controls.Add(this.findLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.ForeColor = System.Drawing.Color.DimGray;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(485, 193);
            this.panel1.TabIndex = 0;
            // 
            // ReplaceAllBtn
            // 
            this.ReplaceAllBtn.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.ReplaceAllBtn.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.ReplaceAllBtn.ForeColor = System.Drawing.Color.White;
            this.ReplaceAllBtn.Location = new System.Drawing.Point(361, 63);
            this.ReplaceAllBtn.Name = "ReplaceAllBtn";
            this.ReplaceAllBtn.Size = new System.Drawing.Size(75, 23);
            this.ReplaceAllBtn.TabIndex = 12;
            this.ReplaceAllBtn.Text = "ReplaceAll";
            this.ReplaceAllBtn.UseVisualStyle = true;
            this.ReplaceAllBtn.UseVisualStyleBackColor = true;
            this.ReplaceAllBtn.Click += new System.EventHandler(this.ReplaceAllBtn_Click);
            // 
            // txtReplace
            // 
            this.txtReplace.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtReplace.Location = new System.Drawing.Point(108, 60);
            this.txtReplace.Metrocolor = System.Drawing.Color.Empty;
            this.txtReplace.Name = "txtReplace";
            this.txtReplace.Size = new System.Drawing.Size(142, 20);
            this.txtReplace.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtReplace.TabIndex = 11;
            // 
            // replaceLabel
            // 
            this.replaceLabel.AutoSize = true;
            this.replaceLabel.ForeColor = System.Drawing.Color.DimGray;
            this.replaceLabel.Location = new System.Drawing.Point(24, 63);
            this.replaceLabel.Name = "replaceLabel";
            this.replaceLabel.Size = new System.Drawing.Size(75, 13);
            this.replaceLabel.TabIndex = 10;
            this.replaceLabel.Text = "Replace with :";
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.White;
            this.comboBox1.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.comboBox1.Items.AddRange(new object[] {
            "ColumnOnly",
            "WholeTable"});
            this.comboBox1.ItemsImageIndexes.Add(new Syncfusion.Windows.Forms.Tools.ComboBoxAdv.ImageIndexItem(this.comboBox1, "ColumnOnly"));
            this.comboBox1.ItemsImageIndexes.Add(new Syncfusion.Windows.Forms.Tools.ComboBoxAdv.ImageIndexItem(this.comboBox1, "WholeTable"));
            this.comboBox1.Location = new System.Drawing.Point(153, 135);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(111, 21);
            this.comboBox1.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.comboBox1.TabIndex = 3;
            // 
            // cmbOptions
            // 
            this.cmbOptions.Items.AddRange(new object[] {
            "ColumnOnly",
            "WholeTable"});
            this.cmbOptions.ItemsImageIndexes.Add(new Syncfusion.Windows.Forms.Tools.ComboBoxAdv.ImageIndexItem(this.cmbOptions, "ColumnOnly"));
            this.cmbOptions.ItemsImageIndexes.Add(new Syncfusion.Windows.Forms.Tools.ComboBoxAdv.ImageIndexItem(this.cmbOptions, "WholeTable"));
            this.cmbOptions.Location = new System.Drawing.Point(153, 135);
            this.cmbOptions.Name = "cmbOptions";
            this.cmbOptions.Size = new System.Drawing.Size(111, 21);
            this.cmbOptions.TabIndex = 3;
            // 
            // matchAllChkbox
            // 
            this.matchAllChkbox.DrawFocusRectangle = false;
            this.matchAllChkbox.ForeColor = System.Drawing.Color.DimGray;
            this.matchAllChkbox.Location = new System.Drawing.Point(27, 139);
            this.matchAllChkbox.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.matchAllChkbox.Name = "matchAllChkbox";
            this.matchAllChkbox.Size = new System.Drawing.Size(109, 17);
            this.matchAllChkbox.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.matchAllChkbox.TabIndex = 1;
            this.matchAllChkbox.Text = "MatchWholeCell";
            this.matchAllChkbox.ThemesEnabled = false;
            // 
            // checkBox1
            // 
            this.checkBox1.DrawFocusRectangle = false;
            this.checkBox1.ForeColor = System.Drawing.Color.DimGray;
            this.checkBox1.Location = new System.Drawing.Point(153, 108);
            this.checkBox1.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(77, 17);
            this.checkBox1.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "Search Up";
            this.checkBox1.ThemesEnabled = false;
            // 
            // searchupChkbox
            // 
            this.searchupChkbox.Location = new System.Drawing.Point(153, 108);
            this.searchupChkbox.MetroColor = System.Drawing.Color.Empty;
            this.searchupChkbox.Name = "searchupChkbox";
            this.searchupChkbox.Size = new System.Drawing.Size(77, 17);
            this.searchupChkbox.TabIndex = 2;
            this.searchupChkbox.Text = "Search Up";
            this.searchupChkbox.ThemesEnabled = false;
            // 
            // ReplaceBtn
            // 
            this.ReplaceBtn.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.ReplaceBtn.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.ReplaceBtn.ForeColor = System.Drawing.Color.White;
            this.ReplaceBtn.Location = new System.Drawing.Point(361, 26);
            this.ReplaceBtn.Name = "ReplaceBtn";
            this.ReplaceBtn.Size = new System.Drawing.Size(75, 23);
            this.ReplaceBtn.TabIndex = 9;
            this.ReplaceBtn.Text = "Replace";
            this.ReplaceBtn.UseVisualStyle = true;
            this.ReplaceBtn.UseVisualStyleBackColor = true;
            this.ReplaceBtn.Click += new System.EventHandler(this.ReplaceBtn_Click);
            // 
            // matchChkbox
            // 
            this.matchChkbox.DrawFocusRectangle = false;
            this.matchChkbox.ForeColor = System.Drawing.Color.DimGray;
            this.matchChkbox.Location = new System.Drawing.Point(27, 108);
            this.matchChkbox.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.matchChkbox.Name = "matchChkbox";
            this.matchChkbox.Size = new System.Drawing.Size(83, 17);
            this.matchChkbox.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.matchChkbox.TabIndex = 0;
            this.matchChkbox.Text = "Match Case";
            this.matchChkbox.ThemesEnabled = false;
            // 
            // cancelbtn
            // 
            this.cancelbtn.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.cancelbtn.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.cancelbtn.ForeColor = System.Drawing.Color.White;
            this.cancelbtn.Location = new System.Drawing.Point(316, 108);
            this.cancelbtn.Name = "cancelbtn";
            this.cancelbtn.Size = new System.Drawing.Size(75, 23);
            this.cancelbtn.TabIndex = 7;
            this.cancelbtn.Text = "Cancel";
            this.cancelbtn.UseVisualStyle = true;
            this.cancelbtn.UseVisualStyleBackColor = true;
            this.cancelbtn.Click += new System.EventHandler(this.cancelbtn_Click);
            // 
            // findallBtn
            // 
            this.findallBtn.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.findallBtn.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.findallBtn.ForeColor = System.Drawing.Color.White;
            this.findallBtn.Location = new System.Drawing.Point(269, 63);
            this.findallBtn.Name = "findallBtn";
            this.findallBtn.Size = new System.Drawing.Size(75, 23);
            this.findallBtn.TabIndex = 6;
            this.findallBtn.Text = "Find All";
            this.findallBtn.UseVisualStyle = true;
            this.findallBtn.UseVisualStyleBackColor = true;
            this.findallBtn.Click += new System.EventHandler(this.findallBtn_Click);
            // 
            // findnextBtn
            // 
            this.findnextBtn.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.findnextBtn.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.findnextBtn.ForeColor = System.Drawing.Color.White;
            this.findnextBtn.Location = new System.Drawing.Point(269, 26);
            this.findnextBtn.Name = "findnextBtn";
            this.findnextBtn.Size = new System.Drawing.Size(75, 23);
            this.findnextBtn.TabIndex = 5;
            this.findnextBtn.Text = "Find Next";
            this.findnextBtn.UseVisualStyle = true;
            this.findnextBtn.UseVisualStyleBackColor = true;
            this.findnextBtn.Click += new System.EventHandler(this.findnextBtn_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.Location = new System.Drawing.Point(108, 26);
            this.txtSearch.Metrocolor = System.Drawing.Color.Empty;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(142, 20);
            this.txtSearch.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtSearch.TabIndex = 1;
            // 
            // findLabel
            // 
            this.findLabel.AutoSize = true;
            this.findLabel.ForeColor = System.Drawing.Color.DimGray;
            this.findLabel.Location = new System.Drawing.Point(24, 29);
            this.findLabel.Name = "findLabel";
            this.findLabel.Size = new System.Drawing.Size(59, 13);
            this.findLabel.TabIndex = 0;
            this.findLabel.Text = "Find what :";
            // 
            // GridFindReplaceDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.BorderThickness = 2;
            this.CaptionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.ClientSize = new System.Drawing.Size(485, 193);
            this.Controls.Add(this.panel1);
            this.DropShadow = true;
            
            this.MetroColor = System.Drawing.Color.Transparent;
            this.Name = "GridFindReplaceDialog";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GridFindReplaceDialog";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtReplace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbOptions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.matchAllChkbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchupChkbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.matchChkbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSearch)).EndInit();
            this.ResumeLayout(false);
        }

        #region Icon

        private string GetIconFile(string bitmapName)
        {
            for (int n = 0; n < 10; n++)
            {
                if (System.IO.File.Exists(bitmapName))
                    return bitmapName;

                bitmapName = @"..\" + bitmapName;
            }

            return bitmapName;
        }

        #endregion

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtSearch;
        private System.Windows.Forms.Label findLabel;
        private Syncfusion.Windows.Forms.Tools.CheckBoxAdv matchAllChkbox;
        private Syncfusion.Windows.Forms.Tools.CheckBoxAdv matchChkbox;
        private Syncfusion.Windows.Forms.Tools.CheckBoxAdv searchupChkbox;
        private Syncfusion.Windows.Forms.ButtonAdv findnextBtn;
        private Syncfusion.Windows.Forms.ButtonAdv findallBtn;
        private Syncfusion.Windows.Forms.ButtonAdv cancelbtn;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv cmbOptions;
        private Syncfusion.Windows.Forms.ButtonAdv ReplaceBtn;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtReplace;
        private System.Windows.Forms.Label replaceLabel;
        private Syncfusion.Windows.Forms.ButtonAdv ReplaceAllBtn;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv comboBox1;
        private Syncfusion.Windows.Forms.Tools.CheckBoxAdv checkBox1;
    }
}
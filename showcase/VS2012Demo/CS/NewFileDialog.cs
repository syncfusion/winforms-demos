#region Copyright Syncfusion Inc. 2001-2023.
// Copyright Syncfusion Inc. 2001-2023. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using Syncfusion.Windows.Forms;

namespace VSDemo
{
    /// <summary>
    /// Summary description for NewFileDialog.
    /// </summary>
    public class NewFileDialog : MetroForm
    {

        private VSDemoMainForm mainForm;

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private Syncfusion.Windows.Forms.ButtonAdv okButton;
        private Syncfusion.Windows.Forms.ButtonAdv cancelButton;
        private System.Windows.Forms.ImageList dockingImageList;
        private System.ComponentModel.IContainer components;

        public NewFileDialog()
        {
            InitializeComponent();
        }

        public NewFileDialog(VSDemoMainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            ".cs"}, 63, System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.Window, new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))));
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            ".vb"}, 4, System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.Window, new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))));
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewFileDialog));
            this.listView1 = new System.Windows.Forms.ListView();
            this.dockingImageList = new System.Windows.Forms.ImageList(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.okButton = new Syncfusion.Windows.Forms.ButtonAdv();
            this.cancelButton = new Syncfusion.Windows.Forms.ButtonAdv();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2});
            this.listView1.LargeImageList = this.dockingImageList;
            this.listView1.Location = new System.Drawing.Point(7, 39);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(400, 130);
            this.listView1.SmallImageList = this.dockingImageList;
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // dockingImageList
            // 
            this.dockingImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("dockingImageList.ImageStream")));
            this.dockingImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.dockingImageList.Images.SetKeyName(0, "");
            this.dockingImageList.Images.SetKeyName(1, "");
            this.dockingImageList.Images.SetKeyName(2, "");
            this.dockingImageList.Images.SetKeyName(3, "");
            this.dockingImageList.Images.SetKeyName(4, "");
            this.dockingImageList.Images.SetKeyName(5, "");
            this.dockingImageList.Images.SetKeyName(6, "");
            this.dockingImageList.Images.SetKeyName(7, "");
            this.dockingImageList.Images.SetKeyName(8, "");
            this.dockingImageList.Images.SetKeyName(9, "");
            this.dockingImageList.Images.SetKeyName(10, "");
            this.dockingImageList.Images.SetKeyName(11, "");
            this.dockingImageList.Images.SetKeyName(12, "");
            this.dockingImageList.Images.SetKeyName(13, "");
            this.dockingImageList.Images.SetKeyName(14, "");
            this.dockingImageList.Images.SetKeyName(15, "");
            this.dockingImageList.Images.SetKeyName(16, "");
            this.dockingImageList.Images.SetKeyName(17, "");
            this.dockingImageList.Images.SetKeyName(18, "");
            this.dockingImageList.Images.SetKeyName(19, "");
            this.dockingImageList.Images.SetKeyName(20, "");
            this.dockingImageList.Images.SetKeyName(21, "");
            this.dockingImageList.Images.SetKeyName(22, "");
            this.dockingImageList.Images.SetKeyName(23, "");
            this.dockingImageList.Images.SetKeyName(24, "");
            this.dockingImageList.Images.SetKeyName(25, "");
            this.dockingImageList.Images.SetKeyName(26, "");
            this.dockingImageList.Images.SetKeyName(27, "");
            this.dockingImageList.Images.SetKeyName(28, "");
            this.dockingImageList.Images.SetKeyName(29, "");
            this.dockingImageList.Images.SetKeyName(30, "");
            this.dockingImageList.Images.SetKeyName(31, "");
            this.dockingImageList.Images.SetKeyName(32, "");
            this.dockingImageList.Images.SetKeyName(33, "");
            this.dockingImageList.Images.SetKeyName(34, "");
            this.dockingImageList.Images.SetKeyName(35, "");
            this.dockingImageList.Images.SetKeyName(36, "");
            this.dockingImageList.Images.SetKeyName(37, "");
            this.dockingImageList.Images.SetKeyName(38, "");
            this.dockingImageList.Images.SetKeyName(39, "");
            this.dockingImageList.Images.SetKeyName(40, "");
            this.dockingImageList.Images.SetKeyName(41, "");
            this.dockingImageList.Images.SetKeyName(42, "");
            this.dockingImageList.Images.SetKeyName(43, "");
            this.dockingImageList.Images.SetKeyName(44, "");
            this.dockingImageList.Images.SetKeyName(45, "");
            this.dockingImageList.Images.SetKeyName(46, "");
            this.dockingImageList.Images.SetKeyName(47, "");
            this.dockingImageList.Images.SetKeyName(48, "");
            this.dockingImageList.Images.SetKeyName(49, "");
            this.dockingImageList.Images.SetKeyName(50, "");
            this.dockingImageList.Images.SetKeyName(51, "");
            this.dockingImageList.Images.SetKeyName(52, "");
            this.dockingImageList.Images.SetKeyName(53, "");
            this.dockingImageList.Images.SetKeyName(54, "");
            this.dockingImageList.Images.SetKeyName(55, "");
            this.dockingImageList.Images.SetKeyName(56, "");
            this.dockingImageList.Images.SetKeyName(57, "");
            this.dockingImageList.Images.SetKeyName(58, "");
            this.dockingImageList.Images.SetKeyName(59, "");
            this.dockingImageList.Images.SetKeyName(60, "");
            this.dockingImageList.Images.SetKeyName(61, "");
            this.dockingImageList.Images.SetKeyName(62, "");
            this.dockingImageList.Images.SetKeyName(63, "");
            this.dockingImageList.Images.SetKeyName(64, "");
            this.dockingImageList.Images.SetKeyName(65, "");
            this.dockingImageList.Images.SetKeyName(66, "");
            this.dockingImageList.Images.SetKeyName(67, "");
            this.dockingImageList.Images.SetKeyName(68, "");
            this.dockingImageList.Images.SetKeyName(69, "");
            this.dockingImageList.Images.SetKeyName(70, "");
            this.dockingImageList.Images.SetKeyName(71, "");
            this.dockingImageList.Images.SetKeyName(72, "");
            this.dockingImageList.Images.SetKeyName(73, "");
            this.dockingImageList.Images.SetKeyName(74, "");
            this.dockingImageList.Images.SetKeyName(75, "");
            this.dockingImageList.Images.SetKeyName(76, "");
            this.dockingImageList.Images.SetKeyName(77, "");
            this.dockingImageList.Images.SetKeyName(78, "");
            this.dockingImageList.Images.SetKeyName(79, "");
            this.dockingImageList.Images.SetKeyName(80, "");
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(7, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Templates";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(7, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "FileName";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(7, 202);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(393, 22);
            this.textBox1.TabIndex = 3;
            // 
            // okButton
            // 
            this.okButton.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.okButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218)))));
            this.okButton.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.okButton.Location = new System.Drawing.Point(260, 228);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(62, 18);
            this.okButton.TabIndex = 4;
            this.okButton.Text = "Ok";
            this.okButton.UseVisualStyle = true;
            this.okButton.UseVisualStyleBackColor = false;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.cancelButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218)))));
            this.cancelButton.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.cancelButton.Location = new System.Drawing.Point(340, 228);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(62, 18);
            this.cancelButton.TabIndex = 5;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyle = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // NewFileDialog
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 15);
            this.ClientSize = new System.Drawing.Size(496, 334);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView1);
            this.DropShadow = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.MinimizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.BorderThickness = 2;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.Name = "NewFileDialog";
            this.Text = "NewFileDialog";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private void listView1_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (this.listView1.SelectedItems.Count > 0)
            {
                if (this.listView1.SelectedItems[0].Text != "")
                {
                    if (this.listView1.SelectedItems[0].Text == ".cs")
                    {
                        this.textBox1.Text = "Class1.cs";
                        this.textBox1.Focus();
                    }
                    else if (this.listView1.SelectedItems[0].Text == ".vb")
                    {
                        this.textBox1.Text = "Class1.vb";
                        this.textBox1.Focus();
                    }
                }
            }
        }

        private void okButton_Click(object sender, System.EventArgs e)
        {
            if (textBox1.Text != "")
            {
                if (textBox1.Text.EndsWith(".cs") || textBox1.Text.EndsWith(".vb"))
                {
                    if (!System.IO.File.Exists(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\" + textBox1.Text))
                    {
                        createNewFile();
                    }
                    else
                    {
                        DialogResult dr = MessageBox.Show("File already exists,Overwrite it??", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                        if (dr == DialogResult.OK)
                        {
                            createNewFile();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Enter proper extension for File");
                }
            }
        }

        private void createNewFile()
        {
            try
            {
                Form activeMDIChild = this.mainForm.CheckFormInChildWindow(this.textBox1.Text);
                if (activeMDIChild != null)
                    activeMDIChild.Close();
                System.IO.File.Create(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\" + textBox1.Text);
                mainForm.openFileInCodeEditor(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\" + textBox1.Text);
                this.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void cancelButton_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            this.listView1.View = View.LargeIcon;
        }

        private void button2_Click(object sender, System.EventArgs e)
        {
            this.listView1.View = View.SmallIcon;
        }
    }
}

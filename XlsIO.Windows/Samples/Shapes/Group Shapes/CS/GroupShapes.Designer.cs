namespace EssentialXlsIOSamples
{
    partial class GroupShapes
    {
        #region Fields
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbGroup;
        private System.Windows.Forms.RadioButton rdbUngroup;
        private System.Windows.Forms.Button viewInputTemplate;
        private System.Windows.Forms.RadioButton rdbUngroupAll;
        #endregion        

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GroupShapes));
            this.btnConvert = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbUngroupAll = new System.Windows.Forms.RadioButton();
            this.rdbGroup = new System.Windows.Forms.RadioButton();
            this.rdbUngroup = new System.Windows.Forms.RadioButton();
            this.viewInputTemplate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(342, 197);
            this.btnConvert.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(158, 40);
            this.btnConvert.TabIndex = 0;
            this.btnConvert.Text = "Create Document";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(8, 92);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(494, 85);
            this.label2.TabIndex = 75;
            this.label2.Text = "Click the button to create new group shape or ungroup the existing shapes by Esse" +
    "ntial XlsIO.";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(0, 0);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(508, 71);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox4.TabIndex = 74;
            this.pictureBox4.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbUngroupAll);
            this.groupBox1.Controls.Add(this.rdbGroup);
            this.groupBox1.Controls.Add(this.rdbUngroup);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(10, 188);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(191, 126);
            this.groupBox1.TabIndex = 76;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Choose";
            // 
            // rdbUngroupAll
            // 
            this.rdbUngroupAll.AutoSize = true;
            this.rdbUngroupAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbUngroupAll.Location = new System.Drawing.Point(34, 93);
            this.rdbUngroupAll.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdbUngroupAll.Name = "rdbUngroupAll";
            this.rdbUngroupAll.Size = new System.Drawing.Size(121, 24);
            this.rdbUngroupAll.TabIndex = 79;
            this.rdbUngroupAll.Text = "Ungroup All";
            this.rdbUngroupAll.UseVisualStyleBackColor = true;
            // 
            // rdbGroup
            // 
            this.rdbGroup.AutoSize = true;
            this.rdbGroup.Checked = true;
            this.rdbGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbGroup.Location = new System.Drawing.Point(34, 25);
            this.rdbGroup.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdbGroup.Name = "rdbGroup";
            this.rdbGroup.Size = new System.Drawing.Size(80, 24);
            this.rdbGroup.TabIndex = 1;
            this.rdbGroup.TabStop = true;
            this.rdbGroup.Text = "Group";
            this.rdbGroup.UseVisualStyleBackColor = true;
            // 
            // rdbUngroup
            // 
            this.rdbUngroup.AutoSize = true;
            this.rdbUngroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbUngroup.Location = new System.Drawing.Point(34, 59);
            this.rdbUngroup.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdbUngroup.Name = "rdbUngroup";
            this.rdbUngroup.Size = new System.Drawing.Size(97, 24);
            this.rdbUngroup.TabIndex = 0;
            this.rdbUngroup.Text = "Ungroup";
            this.rdbUngroup.UseVisualStyleBackColor = true;
            // 
            // viewInputTemplate
            // 
            this.viewInputTemplate.Location = new System.Drawing.Point(343, 274);
            this.viewInputTemplate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.viewInputTemplate.Name = "viewInputTemplate";
            this.viewInputTemplate.Size = new System.Drawing.Size(158, 40);
            this.viewInputTemplate.TabIndex = 77;
            this.viewInputTemplate.Text = "Input Template";
            this.viewInputTemplate.UseVisualStyleBackColor = true;
            this.viewInputTemplate.Click += new System.EventHandler(this.viewInputTemplate_Click);
            // 
            // GroupShapes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(508, 318);
            this.Controls.Add(this.viewInputTemplate);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.btnConvert);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "GroupShapes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Group Shape";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        #region Dispose
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
        #endregion
    }
}


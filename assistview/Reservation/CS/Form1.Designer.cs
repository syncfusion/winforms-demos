using Syncfusion.WinForms.AIAssistView;
using System.Drawing;

namespace AssistViewDemo
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
            this.sfaiAssistView1 = new Syncfusion.WinForms.AIAssistView.SfAIAssistView();
            this.SuspendLayout();
            // 
            // sfaiAssistView1
            // 
            this.sfaiAssistView1.BackColor = System.Drawing.Color.White;
            this.sfaiAssistView1.Location = new System.Drawing.Point(41, 40);
            this.sfaiAssistView1.Name = "sfaiAssistView1";
            this.sfaiAssistView1.Size = new System.Drawing.Size(818, 457);
            this.sfaiAssistView1.TabIndex = 0;
            this.sfaiAssistView1.Text = "sfAIAssistView1";
            this.sfaiAssistView1.User.AvatarImage = null;
            this.sfaiAssistView1.User.Name = null;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1240, 526);
            this.Controls.Add(this.sfaiAssistView1);
            this.Name = "Reservation Demo";
            this.Text = "Reservation Demo";
            this.ResumeLayout(false);

        }

        #endregion

        private SfAIAssistView sfaiAssistView1;
    }
}


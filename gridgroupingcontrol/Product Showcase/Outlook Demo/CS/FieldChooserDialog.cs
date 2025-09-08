#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
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

namespace OutlookDemo
{
	/// <summary>
	/// Summary description for FieldChooserDialog.
	/// </summary>
	public class FieldChooserDialog : System.Windows.Forms.Form
	{
		private System.Windows.Forms.ListBox listBox1;
		private System.Windows.Forms.ListBox listBox2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Button button6;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		string[] NewSet;
		public FieldChooserDialog(string[] hiddenSet,string[] visibleSet)
		{
			
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
			for(int i=1;i<hiddenSet.Length;i++)
				if(hiddenSet[i]!=null)
                    this.listBox1.Items.Add(hiddenSet[i]);
			
			for(int i=1;i<visibleSet.Length;i++)
				if(visibleSet[i]!=null)
					this.listBox2.Items.Add(visibleSet[i]);
			if(this.listBox1.Items.Count>0)
				this.listBox1.SelectedIndex=0;

            this.listBox1.SelectedIndexChanged += new EventHandler(listBox1_SelectedIndexChanged);
			this.listBox2.SelectedIndexChanged+=new EventHandler(listBox2_SelectedIndexChanged);
			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

        void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.listBox1.SelectedItem != null)
                this.button1.Enabled = true;
            else
                this.button1.Enabled = false;
        }

		public string[] SelectedFields
		{
			get{return NewSet;}
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.Location = new System.Drawing.Point(8, 24);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(144, 160);
            this.listBox1.TabIndex = 0;
            // 
            // listBox2
            // 
            this.listBox2.Location = new System.Drawing.Point(240, 24);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(152, 160);
            this.listBox2.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1.Location = new System.Drawing.Point(160, 32);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Add >>";

            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Control;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button2.Location = new System.Drawing.Point(160, 64);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "<< Remove";

            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.Control;
            this.button3.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button3.Location = new System.Drawing.Point(400, 32);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(64, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "OK";

            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.Control;
            this.button4.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button4.Location = new System.Drawing.Point(400, 64);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(64, 23);
            this.button4.TabIndex = 5;
            this.button4.Text = "Cancel";

            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.Control;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button5.Location = new System.Drawing.Point(160, 112);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 6;
            this.button5.Text = "MoveUp";

            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.Control;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button6.Location = new System.Drawing.Point(160, 144);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 7;
            this.button6.Text = "MoveDown";

            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Hidden Fields";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(240, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Visible Fields";
            // 
            // FieldChooserDialog
            // 
            this.AcceptButton = this.button3;
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(209)))), ((int)(((byte)(223)))));
            this.CancelButton = this.button4;
            this.ClientSize = new System.Drawing.Size(472, 192);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FieldChooserDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Field Chooser";
            this.ResumeLayout(false);

		}
		#endregion

		private void button1_Click(object sender, System.EventArgs e)
		{
			this.listBox2.Items.Add(this.listBox1.SelectedItem);
			this.listBox1.Items.Remove(this.listBox1.SelectedItem);
		}

		private void button2_Click(object sender, System.EventArgs e)
		{
			this.listBox1.Items.Add(this.listBox2.SelectedItem);
			this.listBox2.Items.Remove(this.listBox2.SelectedItem);
		}

		private void button5_Click(object sender, System.EventArgs e)
		{
			int selindex = this.listBox2.SelectedIndex;
			if(selindex>0)
			{
				object val = this.listBox2.Items[selindex - 1];
				this.listBox2.Items[selindex - 1] = this.listBox2.SelectedItem;
				this.listBox2.Items[selindex] = val;
				this.listBox2.SelectedIndex = selindex - 1;
			}
		}

		private void button6_Click(object sender, System.EventArgs e)
		{
			int selindex = this.listBox2.SelectedIndex;
			if(selindex<this.listBox2.Items.Count-1)
			{
				object val = this.listBox2.Items[selindex + 1];
				this.listBox2.Items[selindex + 1] = this.listBox2.SelectedItem;
				this.listBox2.Items[selindex] = val;
				this.listBox2.SelectedIndex = selindex + 1;
			}
		}

		private void button3_Click(object sender, System.EventArgs e)
		{
			this.NewSet=new string[this.listBox2.Items.Count];
			for (int i = 0; i < this.listBox2.Items.Count; i++)
			{
				this.NewSet[i] = this.listBox2.Items[i].ToString();
			}
		}

		private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
		{
            if (this.listBox2.SelectedItem != null)
            {
                this.button2.Enabled = true;
                if (this.listBox2.SelectedIndex == 0)
                    this.button5.Enabled = false;
                else
                    this.button5.Enabled = true;
                if (this.listBox2.SelectedIndex == listBox2.Items.Count - 1)
                    this.button6.Enabled = false;
                else
                    this.button6.Enabled = true;
            }
            else
                this.button2.Enabled = false;
		}
		
	}
}

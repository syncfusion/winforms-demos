using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

using Syncfusion.Windows.Forms.Tools;

namespace ColorUIDemo
{
	/// <summary>
	/// Summary description for ColorGroup.
	/// </summary>
	public class ColorGroup : System.Windows.Forms.Form
	{
		private Syncfusion.Windows.Forms.ButtonAdv buttonAdv1;
		private Syncfusion.Windows.Forms.ButtonAdv buttonAdv2;
		private System.Windows.Forms.PropertyGrid propertyGrid1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ListBox listBox1;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;
        private System.Windows.Forms.Panel panel1;
		private Syncfusion.Windows.Forms.ButtonAdv btnAdd;
		private Syncfusion.Windows.Forms.ButtonAdv btnRemove;

		private ColorPickerUIAdv colorPickerUIAdv;
		private ArrayList tempCollectionList = new ArrayList();

		public ColorGroup(ColorPickerUIAdv colorPickerUIAdv)
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
			this.colorPickerUIAdv = colorPickerUIAdv;
			FillInListBox();
			this.listBox1.SelectedIndex=0;
            this.propertyGrid1.SelectedObject = this.colorPickerUIAdv.ThemeGroup;
			foreach(object o in this.colorPickerUIAdv.CustomGroups)
				tempCollectionList.Add(o);
			//
			// TODO: Add any constructor code after InitializeComponent call
			//
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
            this.buttonAdv1 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.buttonAdv2 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.propertyGrid1 = new System.Windows.Forms.PropertyGrid();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAdd = new Syncfusion.Windows.Forms.ButtonAdv();
            this.btnRemove = new Syncfusion.Windows.Forms.ButtonAdv();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonAdv1
            // 
            this.buttonAdv1.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2007;
            this.buttonAdv1.KeepFocusRectangle = false;
            this.buttonAdv1.Location = new System.Drawing.Point(248, 344);
            this.buttonAdv1.Name = "buttonAdv1";
            this.buttonAdv1.Size = new System.Drawing.Size(75, 23);
            this.buttonAdv1.TabIndex = 0;
            this.buttonAdv1.Text = "OK";
            this.buttonAdv1.UseVisualStyle = true;
            this.buttonAdv1.Click += new System.EventHandler(this.buttonAdv1_Click);
            // 
            // buttonAdv2
            // 
            this.buttonAdv2.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2007;
            this.buttonAdv2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonAdv2.KeepFocusRectangle = false;
            this.buttonAdv2.Location = new System.Drawing.Point(336, 344);
            this.buttonAdv2.Name = "buttonAdv2";
            this.buttonAdv2.Size = new System.Drawing.Size(75, 23);
            this.buttonAdv2.TabIndex = 1;
            this.buttonAdv2.Text = "Cancel";
            this.buttonAdv2.UseVisualStyle = true;
            this.buttonAdv2.Click += new System.EventHandler(this.buttonAdv2_Click);
            // 
            // propertyGrid1
            // 
            this.propertyGrid1.CommandsBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(235)))), ((int)(((byte)(249)))));
            this.propertyGrid1.LineColor = System.Drawing.SystemColors.ScrollBar;
            this.propertyGrid1.Location = new System.Drawing.Point(16, 24);
            this.propertyGrid1.Name = "propertyGrid1";
            this.propertyGrid1.Size = new System.Drawing.Size(194, 280);
            this.propertyGrid1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Theme Colors:";
            // 
            // listBox1
            // 
            this.listBox1.Location = new System.Drawing.Point(8, 8);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(160, 225);
            this.listBox1.TabIndex = 4;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(235)))), ((int)(((byte)(249)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.propertyGrid1);
            this.panel1.Location = new System.Drawing.Point(200, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(224, 320);
            this.panel1.TabIndex = 9;
            // 
            // btnAdd
            // 
            this.btnAdd.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2007;
            this.btnAdd.KeepFocusRectangle = false;
            this.btnAdd.Location = new System.Drawing.Point(8, 240);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyle = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2007;
            this.btnRemove.KeepFocusRectangle = false;
            this.btnRemove.Location = new System.Drawing.Point(88, 240);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 11;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyle = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // ColorGroup
            // 
            this.AcceptButton = this.buttonAdv1;
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 14);
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(193)))), ((int)(((byte)(236)))));
            this.CancelButton = this.buttonAdv2;
            this.ClientSize = new System.Drawing.Size(432, 374);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.buttonAdv1);
            this.Controls.Add(this.buttonAdv2);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ColorGroup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Color Group";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

		}
		#endregion

		private void FillInListBox()
		{
			this.listBox1.Items.Clear();
            this.listBox1.Items.Add(this.colorPickerUIAdv.ThemeGroup.Name);
            this.listBox1.Items.Add(this.colorPickerUIAdv.StandardGroup.Name);
            this.listBox1.Items.Add(this.colorPickerUIAdv.RecentGroup.Name);
			foreach(ColorUIAdvGroup group in this.colorPickerUIAdv.CustomGroups)
			{
				listBox1.Items.Add(group.Name);
			}
		}

		private void buttonAdv1_Click(object sender, System.EventArgs e)
		{
            this.colorPickerUIAdv.UpdateControl();
			this.Close();
		}

		private void listBox1_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			if(this.listBox1.SelectedItem.ToString()!="" && this.listBox1.SelectedItem !=null)
			{
				this.propertyGrid1.SelectedObject = GetColorUIAdvGroupObject(this.listBox1.SelectedItem.ToString());
			}
		}

		private ColorUIAdvGroup GetColorUIAdvGroupObject(string groupName)
		{
            if (groupName == "Theme Colors")
                return this.colorPickerUIAdv.ThemeGroup;
            else if (groupName == "Standard Colors")
                return this.colorPickerUIAdv.StandardGroup;
            else if (groupName == "Recent Colors")
                return this.colorPickerUIAdv.RecentGroup;
			foreach(ColorUIAdvGroup group in this.colorPickerUIAdv.CustomGroups)
			{
				if(group.Name == groupName)
					return group;
			}
			return null;
		}

		private void FillInColorGroup(ArrayList list)
		{
			this.colorPickerUIAdv.CustomGroups.Clear();
			foreach(object o in list)
			{
				this.colorPickerUIAdv.CustomGroups.Add((ColorUIAdvGroup)o);
			}
		}

		private void btnAdd_Click(object sender, System.EventArgs e)
		{
			ColorUIAdvGroup group = new ColorUIAdvGroup(this.colorPickerUIAdv,Syncfusion.Windows.Forms.Tools.ColorUIAdvGroups.CustomColors,true);
			this.colorPickerUIAdv.CustomGroups.Add(group);
			FillInListBox();
			this.listBox1.SelectedIndex = this.listBox1.Items.Count - 1;
		}

		private void btnRemove_Click(object sender, System.EventArgs e)
		{				
			if(this.listBox1.SelectedItem !=null)
			{
                string colorGroup = this.listBox1.SelectedItem.ToString();
                if (colorGroup != "Theme Colors" && colorGroup != "Standard Colors" && colorGroup != "Recent Colors")
                {
                    ColorUIAdvGroup group = GetColorUIAdvGroupObject(colorGroup);
                    if (group != null)
                    {
                        this.colorPickerUIAdv.CustomGroups.Remove(group);
                        FillInListBox();
                        this.listBox1.SelectedIndex = this.listBox1.Items.Count - 1;
                    }
                }
                else
                    MessageBox.Show("You can remove only custom group colors");
			}
			else
			{
				this.listBox1.SelectedIndex = this.listBox1.Items.Count - 1;
			}					
		}

		private void buttonAdv2_Click(object sender, System.EventArgs e)
		{
			DialogResult dr = MessageBox.Show("Do you want to cancel?","Cancel",MessageBoxButtons.YesNo,MessageBoxIcon.Information);
			if(dr == DialogResult.Yes)
			{
				FillInColorGroup(tempCollectionList);
				this.Close();
			}
		}

	}
}

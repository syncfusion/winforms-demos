using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using Syncfusion.Windows.Forms.Grid;
using Syncfusion.Windows.Forms.Grid.Grouping;
using Syncfusion.Grouping;

namespace OutlookDemo
{
	/// <summary>
	/// Summary description for CurrentView.
	/// </summary>
	public class CurrentView : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button button7;
		private System.Windows.Forms.Button button8;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		GridGroupingControl groupingGrid;
		ContactsPaneForm cform;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public CurrentView(ContactsPaneForm frm)
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			cform=frm;
			groupingGrid=frm.Grid;
			SetFieldsLabel();
			SetGroupByLabel();
			SetSortLabel();
			SetFilterLabel();
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
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.button7 = new System.Windows.Forms.Button();
			this.button8 = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.SystemColors.Control;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.button1.Location = new System.Drawing.Point(8, 16);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(128, 23);
			this.button1.TabIndex = 0;
			this.button1.Text = "Fields...";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.SystemColors.Control;
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.button2.Location = new System.Drawing.Point(8, 48);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(128, 23);
			this.button2.TabIndex = 1;
			this.button2.Text = "Group By...";
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button3
			// 
			this.button3.BackColor = System.Drawing.SystemColors.Control;
			this.button3.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.button3.Location = new System.Drawing.Point(8, 80);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(128, 23);
			this.button3.TabIndex = 2;
			this.button3.Text = "Sort...";
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// button4
			// 
			this.button4.BackColor = System.Drawing.SystemColors.Control;
			this.button4.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.button4.Location = new System.Drawing.Point(8, 112);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(128, 23);
			this.button4.TabIndex = 3;
			this.button4.Text = "Filter...";
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// button5
			// 
			this.button5.BackColor = System.Drawing.SystemColors.Control;
			this.button5.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.button5.Location = new System.Drawing.Point(8, 144);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(128, 23);
			this.button5.TabIndex = 4;
			this.button5.Text = "Format Columns...";
			this.button5.Click += new System.EventHandler(this.button5_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.button1);
			this.groupBox1.Controls.Add(this.button2);
			this.groupBox1.Controls.Add(this.button3);
			this.groupBox1.Controls.Add(this.button4);
			this.groupBox1.Controls.Add(this.button5);
			this.groupBox1.Location = new System.Drawing.Point(8, 8);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(384, 176);
			this.groupBox1.TabIndex = 6;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Description";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(144, 152);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(224, 16);
			this.label5.TabIndex = 9;
			this.label5.Text = "Conditional Font and Color Formatting";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(144, 112);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(232, 24);
			this.label4.TabIndex = 8;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(144, 80);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(232, 24);
			this.label3.TabIndex = 7;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(144, 48);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(232, 24);
			this.label2.TabIndex = 6;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(144, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(232, 24);
			this.label1.TabIndex = 5;
			// 
			// button7
			// 
			this.button7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.button7.BackColor = System.Drawing.SystemColors.Control;
			this.button7.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.button7.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.button7.Location = new System.Drawing.Point(232, 192);
			this.button7.Name = "button7";
			this.button7.TabIndex = 7;
			this.button7.Text = "OK";
			// 
			// button8
			// 
			this.button8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.button8.BackColor = System.Drawing.SystemColors.Control;
			this.button8.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.button8.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.button8.Location = new System.Drawing.Point(312, 192);
			this.button8.Name = "button8";
			this.button8.TabIndex = 8;
			this.button8.Text = "Cancel";
			// 
			// CurrentView
			// 
			this.AcceptButton = this.button7;
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(209)), ((System.Byte)(209)), ((System.Byte)(223)));
			this.CancelButton = this.button8;
			this.ClientSize = new System.Drawing.Size(402, 224);
			this.Controls.Add(this.button8);
			this.Controls.Add(this.button7);
			this.Controls.Add(this.groupBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "CurrentView";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "CurrentView";
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void SetFieldsLabel()
		{
			System.Text.StringBuilder visibleCols=new System.Text.StringBuilder();
			for (int i = 0; i < this.groupingGrid.TableDescriptor.VisibleColumns.Count; i++)
			{
				GridVisibleColumnDescriptor col = this.groupingGrid.TableDescriptor.VisibleColumns[i];
				if (col != null)
				{
					if (visibleCols.Length > 0)
					{
						visibleCols.Append(", ");
					}
					visibleCols.Append(col.Name);
				}
			}
			this.label1.Text = visibleCols.ToString();
		}

		private void SetGroupByLabel()
		{
			System.Text.StringBuilder grps=new System.Text.StringBuilder();
			foreach(SortColumnDescriptor scol in groupingGrid.TableDescriptor.GroupedColumns)
			{
				if(scol!=null)
				{
					if(grps.Length>0)
						grps.Append(", ");
					grps.Append(scol.Name+"("+scol.SortDirection+")");
				}
			}
			if(grps.Length==0)
				this.label2.Text="None";
			else
				this.label2.Text=grps.ToString();
		}

		private void SetSortLabel()
		{
			System.Text.StringBuilder sortCols=new System.Text.StringBuilder();
			foreach(SortColumnDescriptor scol in groupingGrid.TableDescriptor.SortedColumns)
			{
				if(scol!=null)
				{
					if(sortCols.Length>0)
						sortCols.Append(", ");
					sortCols.Append(scol.Name+"("+scol.SortDirection+")");
				}
			}
			if(sortCols.Length==0)
				this.label3.Text="None";
			else
				this.label3.Text=sortCols.ToString();
		}
		private void SetFilterLabel()
		{
			System.Text.StringBuilder filters=new System.Text.StringBuilder();
			foreach(RecordFilterDescriptor filter in groupingGrid.TableDescriptor.RecordFilters)
			{
				if(filter!=null)
				{
					if(filters.Length>0)
						filters.Append(", ");
					foreach(FilterCondition cond in filter.Conditions)
					filters.Append(cond.FilterDescriptor.FieldDescriptor.Name+" "+cond.CompareOperator.ToString()+" "+cond.CompareValue.ToString());
				}
			}
			if(filters.Length==0)
				this.label4.Text="Off";
			else
				this.label4.Text=filters.ToString();
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			cform.barItem4.PerformClick();
			SetFieldsLabel();
		}

		private void button2_Click(object sender, System.EventArgs e)
		{
			cform.barItem3.PerformClick();
			SetGroupByLabel();
		}

		private void button3_Click(object sender, System.EventArgs e)
		{
			cform.barItem6.PerformClick();
			SetSortLabel();
		}

		private void button4_Click(object sender, System.EventArgs e)
		{
			cform.barItem7.PerformClick();
			SetFilterLabel();
		}

		private void button5_Click(object sender, System.EventArgs e)
		{
			FormatColumnsDialog dlg=new FormatColumnsDialog(this.groupingGrid);
			dlg.ShowDialog();
		}
	}
}

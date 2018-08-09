using System.Windows.Forms;

namespace SerializationDemo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pivotGridControl1 = new Syncfusion.Windows.Forms.PivotAnalysis.PivotGridControl(this.components);
            this.seriailize_filtering = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.seriailize_sorting = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.seriailize_grouping = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.seriailize_condformats = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.seriailize_pivotrows = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.seriailize_pivotcolumns = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.seriailize_pivotcalculations = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.seriailize_expandcollapsestate = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.deseriailize_filtering = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.deseriailize_sorting = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.deseriailize_grouping = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.deseriailize_condformats = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.deseriailize_pivotrows = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.deseriailize_pivotcolumns = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.deseriailize_pivotcalculations = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.deseriailize_expandcollapsestate = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonAdv1 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.buttonAdv2 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonAdv3 = new Syncfusion.Windows.Forms.ButtonAdv();
            ((System.ComponentModel.ISupportInitialize)(this.seriailize_filtering)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seriailize_sorting)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seriailize_grouping)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seriailize_condformats)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seriailize_pivotrows)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seriailize_pivotcolumns)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seriailize_pivotcalculations)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seriailize_expandcollapsestate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deseriailize_filtering)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deseriailize_sorting)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deseriailize_grouping)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deseriailize_condformats)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deseriailize_pivotrows)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deseriailize_pivotcolumns)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deseriailize_pivotcalculations)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deseriailize_expandcollapsestate)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pivotGridControl1
            // 
            this.pivotGridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pivotGridControl1.EditManager = null;
            this.pivotGridControl1.Location = new System.Drawing.Point(0, 8);
            this.pivotGridControl1.Margin = new System.Windows.Forms.Padding(0);
            this.pivotGridControl1.Name = "pivotGridControl1";
            this.pivotGridControl1.Size = new System.Drawing.Size(1185, 833);
            this.pivotGridControl1.TabIndex = 0;
            this.pivotGridControl1.Text = "pivotGridControl1";
            this.pivotGridControl1.UpdateManager = null;
            // 
            // seriailize_filtering
            // 
            this.seriailize_filtering.BeforeTouchSize = new System.Drawing.Size(350, 35);
            this.seriailize_filtering.Checked = true;
            this.seriailize_filtering.CheckState = System.Windows.Forms.CheckState.Checked;
            this.seriailize_filtering.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seriailize_filtering.ForeColor = System.Drawing.Color.Black;
            this.seriailize_filtering.ImageCheckBoxSize = new System.Drawing.Size(20, 20);
            this.seriailize_filtering.Location = new System.Drawing.Point(15, 90);
            this.seriailize_filtering.Margin = new System.Windows.Forms.Padding(0);
            this.seriailize_filtering.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.seriailize_filtering.Name = "seriailize_filtering";
            this.seriailize_filtering.Size = new System.Drawing.Size(350, 35);
            this.seriailize_filtering.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.seriailize_filtering.TabIndex = 1;
            this.seriailize_filtering.Text = "Serialize Filtering";
            this.seriailize_filtering.ThemesEnabled = false;
            // 
            // seriailize_sorting
            // 
            this.seriailize_sorting.BeforeTouchSize = new System.Drawing.Size(350, 35);
            this.seriailize_sorting.Checked = true;
            this.seriailize_sorting.CheckState = System.Windows.Forms.CheckState.Checked;
            this.seriailize_sorting.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seriailize_sorting.ForeColor = System.Drawing.Color.Black;
            this.seriailize_sorting.ImageCheckBoxSize = new System.Drawing.Size(20, 20);
            this.seriailize_sorting.Location = new System.Drawing.Point(15, 130);
            this.seriailize_sorting.Margin = new System.Windows.Forms.Padding(0);
            this.seriailize_sorting.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.seriailize_sorting.Name = "seriailize_sorting";
            this.seriailize_sorting.Size = new System.Drawing.Size(350, 35);
            this.seriailize_sorting.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.seriailize_sorting.TabIndex = 2;
            this.seriailize_sorting.Text = "Serialize Sorting";
            this.seriailize_sorting.ThemesEnabled = false;
            // 
            // seriailize_grouping
            // 
            this.seriailize_grouping.BeforeTouchSize = new System.Drawing.Size(350, 35);
            this.seriailize_grouping.Checked = true;
            this.seriailize_grouping.CheckState = System.Windows.Forms.CheckState.Checked;
            this.seriailize_grouping.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seriailize_grouping.ForeColor = System.Drawing.Color.Black;
            this.seriailize_grouping.ImageCheckBoxSize = new System.Drawing.Size(20, 20);
            this.seriailize_grouping.Location = new System.Drawing.Point(15, 170);
            this.seriailize_grouping.Margin = new System.Windows.Forms.Padding(0);
            this.seriailize_grouping.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.seriailize_grouping.Name = "seriailize_grouping";
            this.seriailize_grouping.Size = new System.Drawing.Size(350, 35);
            this.seriailize_grouping.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.seriailize_grouping.TabIndex = 3;
            this.seriailize_grouping.Text = "Serialize Grouping";
            this.seriailize_grouping.ThemesEnabled = false;
            // 
            // seriailize_condformats
            // 
            this.seriailize_condformats.BeforeTouchSize = new System.Drawing.Size(350, 35);
            this.seriailize_condformats.Checked = true;
            this.seriailize_condformats.CheckState = System.Windows.Forms.CheckState.Checked;
            this.seriailize_condformats.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seriailize_condformats.ForeColor = System.Drawing.Color.Black;
            this.seriailize_condformats.ImageCheckBoxSize = new System.Drawing.Size(20, 20);
            this.seriailize_condformats.Location = new System.Drawing.Point(15, 210);
            this.seriailize_condformats.Margin = new System.Windows.Forms.Padding(0);
            this.seriailize_condformats.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.seriailize_condformats.Name = "seriailize_condformats";
            this.seriailize_condformats.Size = new System.Drawing.Size(350, 35);
            this.seriailize_condformats.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.seriailize_condformats.TabIndex = 4;
            this.seriailize_condformats.Text = "Serialize Conditional Formatting";
            this.seriailize_condformats.ThemesEnabled = false;
            // 
            // seriailize_pivotrows
            // 
            this.seriailize_pivotrows.BeforeTouchSize = new System.Drawing.Size(350, 35);
            this.seriailize_pivotrows.Checked = true;
            this.seriailize_pivotrows.CheckState = System.Windows.Forms.CheckState.Checked;
            this.seriailize_pivotrows.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seriailize_pivotrows.ForeColor = System.Drawing.Color.Black;
            this.seriailize_pivotrows.ImageCheckBoxSize = new System.Drawing.Size(20, 20);
            this.seriailize_pivotrows.Location = new System.Drawing.Point(15, 250);
            this.seriailize_pivotrows.Margin = new System.Windows.Forms.Padding(0);
            this.seriailize_pivotrows.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.seriailize_pivotrows.Name = "seriailize_pivotrows";
            this.seriailize_pivotrows.Size = new System.Drawing.Size(350, 35);
            this.seriailize_pivotrows.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.seriailize_pivotrows.TabIndex = 5;
            this.seriailize_pivotrows.Text = "Serailize PivotRows";
            this.seriailize_pivotrows.ThemesEnabled = false;
            // 
            // seriailize_pivotcolumns
            // 
            this.seriailize_pivotcolumns.BeforeTouchSize = new System.Drawing.Size(350, 35);
            this.seriailize_pivotcolumns.Checked = true;
            this.seriailize_pivotcolumns.CheckState = System.Windows.Forms.CheckState.Checked;
            this.seriailize_pivotcolumns.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seriailize_pivotcolumns.ForeColor = System.Drawing.Color.Black;
            this.seriailize_pivotcolumns.ImageCheckBoxSize = new System.Drawing.Size(20, 20);
            this.seriailize_pivotcolumns.Location = new System.Drawing.Point(15, 290);
            this.seriailize_pivotcolumns.Margin = new System.Windows.Forms.Padding(0);
            this.seriailize_pivotcolumns.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.seriailize_pivotcolumns.Name = "seriailize_pivotcolumns";
            this.seriailize_pivotcolumns.Size = new System.Drawing.Size(350, 35);
            this.seriailize_pivotcolumns.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.seriailize_pivotcolumns.TabIndex = 6;
            this.seriailize_pivotcolumns.Text = "Serialize PivotColumns";
            this.seriailize_pivotcolumns.ThemesEnabled = false;
            // 
            // seriailize_pivotcalculations
            // 
            this.seriailize_pivotcalculations.BeforeTouchSize = new System.Drawing.Size(350, 35);
            this.seriailize_pivotcalculations.Checked = true;
            this.seriailize_pivotcalculations.CheckState = System.Windows.Forms.CheckState.Checked;
            this.seriailize_pivotcalculations.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seriailize_pivotcalculations.ForeColor = System.Drawing.Color.Black;
            this.seriailize_pivotcalculations.ImageCheckBoxSize = new System.Drawing.Size(20, 20);
            this.seriailize_pivotcalculations.Location = new System.Drawing.Point(15, 330);
            this.seriailize_pivotcalculations.Margin = new System.Windows.Forms.Padding(0);
            this.seriailize_pivotcalculations.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.seriailize_pivotcalculations.Name = "seriailize_pivotcalculations";
            this.seriailize_pivotcalculations.Size = new System.Drawing.Size(350, 35);
            this.seriailize_pivotcalculations.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.seriailize_pivotcalculations.TabIndex = 7;
            this.seriailize_pivotcalculations.Text = "Serialize PivotCalculations";
            this.seriailize_pivotcalculations.ThemesEnabled = false;
            // 
            // seriailize_expandcollapsestate
            // 
            this.seriailize_expandcollapsestate.BeforeTouchSize = new System.Drawing.Size(350, 35);
            this.seriailize_expandcollapsestate.Checked = true;
            this.seriailize_expandcollapsestate.CheckState = System.Windows.Forms.CheckState.Checked;
            this.seriailize_expandcollapsestate.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seriailize_expandcollapsestate.ForeColor = System.Drawing.Color.Black;
            this.seriailize_expandcollapsestate.ImageCheckBoxSize = new System.Drawing.Size(20, 20);
            this.seriailize_expandcollapsestate.Location = new System.Drawing.Point(15, 370);
            this.seriailize_expandcollapsestate.Margin = new System.Windows.Forms.Padding(0);
            this.seriailize_expandcollapsestate.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.seriailize_expandcollapsestate.Name = "seriailize_expandcollapsestate";
            this.seriailize_expandcollapsestate.Size = new System.Drawing.Size(350, 35);
            this.seriailize_expandcollapsestate.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.seriailize_expandcollapsestate.TabIndex = 8;
            this.seriailize_expandcollapsestate.Text = "Serialize Expand/Collapse State";
            this.seriailize_expandcollapsestate.ThemesEnabled = false;
            // 
            // deseriailize_filtering
            // 
            this.deseriailize_filtering.BeforeTouchSize = new System.Drawing.Size(350, 35);
            this.deseriailize_filtering.Checked = true;
            this.deseriailize_filtering.CheckState = System.Windows.Forms.CheckState.Checked;
            this.deseriailize_filtering.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deseriailize_filtering.ForeColor = System.Drawing.Color.Black;
            this.deseriailize_filtering.ImageCheckBoxSize = new System.Drawing.Size(20, 20);
            this.deseriailize_filtering.Location = new System.Drawing.Point(15, 520);
            this.deseriailize_filtering.Margin = new System.Windows.Forms.Padding(0);
            this.deseriailize_filtering.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.deseriailize_filtering.Name = "deseriailize_filtering";
            this.deseriailize_filtering.Size = new System.Drawing.Size(350, 35);
            this.deseriailize_filtering.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.deseriailize_filtering.TabIndex = 11;
            this.deseriailize_filtering.Text = "Deserialize Filtering";
            this.deseriailize_filtering.ThemesEnabled = false;
            // 
            // deseriailize_sorting
            // 
            this.deseriailize_sorting.BeforeTouchSize = new System.Drawing.Size(350, 35);
            this.deseriailize_sorting.Checked = true;
            this.deseriailize_sorting.CheckState = System.Windows.Forms.CheckState.Checked;
            this.deseriailize_sorting.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deseriailize_sorting.ForeColor = System.Drawing.Color.Black;
            this.deseriailize_sorting.ImageCheckBoxSize = new System.Drawing.Size(20, 20);
            this.deseriailize_sorting.Location = new System.Drawing.Point(15, 560);
            this.deseriailize_sorting.Margin = new System.Windows.Forms.Padding(0);
            this.deseriailize_sorting.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.deseriailize_sorting.Name = "deseriailize_sorting";
            this.deseriailize_sorting.Size = new System.Drawing.Size(350, 35);
            this.deseriailize_sorting.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.deseriailize_sorting.TabIndex = 12;
            this.deseriailize_sorting.Text = "Deserialize Sorting";
            this.deseriailize_sorting.ThemesEnabled = false;
            // 
            // deseriailize_grouping
            // 
            this.deseriailize_grouping.BeforeTouchSize = new System.Drawing.Size(350, 35);
            this.deseriailize_grouping.Checked = true;
            this.deseriailize_grouping.CheckState = System.Windows.Forms.CheckState.Checked;
            this.deseriailize_grouping.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deseriailize_grouping.ForeColor = System.Drawing.Color.Black;
            this.deseriailize_grouping.ImageCheckBoxSize = new System.Drawing.Size(20, 20);
            this.deseriailize_grouping.Location = new System.Drawing.Point(15, 600);
            this.deseriailize_grouping.Margin = new System.Windows.Forms.Padding(0);
            this.deseriailize_grouping.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.deseriailize_grouping.Name = "deseriailize_grouping";
            this.deseriailize_grouping.Size = new System.Drawing.Size(350, 35);
            this.deseriailize_grouping.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.deseriailize_grouping.TabIndex = 13;
            this.deseriailize_grouping.Text = "Deserialize Grouping";
            this.deseriailize_grouping.ThemesEnabled = false;
            // 
            // deseriailize_condformats
            // 
            this.deseriailize_condformats.BeforeTouchSize = new System.Drawing.Size(350, 35);
            this.deseriailize_condformats.Checked = true;
            this.deseriailize_condformats.CheckState = System.Windows.Forms.CheckState.Checked;
            this.deseriailize_condformats.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deseriailize_condformats.ForeColor = System.Drawing.Color.Black;
            this.deseriailize_condformats.ImageCheckBoxSize = new System.Drawing.Size(20, 20);
            this.deseriailize_condformats.Location = new System.Drawing.Point(15, 640);
            this.deseriailize_condformats.Margin = new System.Windows.Forms.Padding(0);
            this.deseriailize_condformats.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.deseriailize_condformats.Name = "deseriailize_condformats";
            this.deseriailize_condformats.Size = new System.Drawing.Size(350, 35);
            this.deseriailize_condformats.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.deseriailize_condformats.TabIndex = 14;
            this.deseriailize_condformats.Text = "Deserialize Conditional Formatting";
            this.deseriailize_condformats.ThemesEnabled = false;
            // 
            // deseriailize_pivotrows
            // 
            this.deseriailize_pivotrows.BeforeTouchSize = new System.Drawing.Size(350, 35);
            this.deseriailize_pivotrows.Checked = true;
            this.deseriailize_pivotrows.CheckState = System.Windows.Forms.CheckState.Checked;
            this.deseriailize_pivotrows.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deseriailize_pivotrows.ForeColor = System.Drawing.Color.Black;
            this.deseriailize_pivotrows.ImageCheckBoxSize = new System.Drawing.Size(20, 20);
            this.deseriailize_pivotrows.Location = new System.Drawing.Point(15, 680);
            this.deseriailize_pivotrows.Margin = new System.Windows.Forms.Padding(0);
            this.deseriailize_pivotrows.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.deseriailize_pivotrows.Name = "deseriailize_pivotrows";
            this.deseriailize_pivotrows.Size = new System.Drawing.Size(350, 35);
            this.deseriailize_pivotrows.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.deseriailize_pivotrows.TabIndex = 15;
            this.deseriailize_pivotrows.Text = "Deserailize PivotRows";
            this.deseriailize_pivotrows.ThemesEnabled = false;
            // 
            // deseriailize_pivotcolumns
            // 
            this.deseriailize_pivotcolumns.BeforeTouchSize = new System.Drawing.Size(350, 35);
            this.deseriailize_pivotcolumns.Checked = true;
            this.deseriailize_pivotcolumns.CheckState = System.Windows.Forms.CheckState.Checked;
            this.deseriailize_pivotcolumns.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deseriailize_pivotcolumns.ForeColor = System.Drawing.Color.Black;
            this.deseriailize_pivotcolumns.ImageCheckBoxSize = new System.Drawing.Size(20, 20);
            this.deseriailize_pivotcolumns.Location = new System.Drawing.Point(15, 720);
            this.deseriailize_pivotcolumns.Margin = new System.Windows.Forms.Padding(0);
            this.deseriailize_pivotcolumns.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.deseriailize_pivotcolumns.Name = "deseriailize_pivotcolumns";
            this.deseriailize_pivotcolumns.Size = new System.Drawing.Size(350, 35);
            this.deseriailize_pivotcolumns.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.deseriailize_pivotcolumns.TabIndex = 16;
            this.deseriailize_pivotcolumns.Text = "Deserialize PivotColumns";
            this.deseriailize_pivotcolumns.ThemesEnabled = false;
            // 
            // deseriailize_pivotcalculations
            // 
            this.deseriailize_pivotcalculations.BeforeTouchSize = new System.Drawing.Size(350, 35);
            this.deseriailize_pivotcalculations.Checked = true;
            this.deseriailize_pivotcalculations.CheckState = System.Windows.Forms.CheckState.Checked;
            this.deseriailize_pivotcalculations.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deseriailize_pivotcalculations.ForeColor = System.Drawing.Color.Black;
            this.deseriailize_pivotcalculations.ImageCheckBoxSize = new System.Drawing.Size(20, 20);
            this.deseriailize_pivotcalculations.Location = new System.Drawing.Point(15, 760);
            this.deseriailize_pivotcalculations.Margin = new System.Windows.Forms.Padding(0);
            this.deseriailize_pivotcalculations.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.deseriailize_pivotcalculations.Name = "deseriailize_pivotcalculations";
            this.deseriailize_pivotcalculations.Size = new System.Drawing.Size(350, 35);
            this.deseriailize_pivotcalculations.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.deseriailize_pivotcalculations.TabIndex = 17;
            this.deseriailize_pivotcalculations.Text = "Deserialize PivotCalculations";
            this.deseriailize_pivotcalculations.ThemesEnabled = false;
            // 
            // deseriailize_expandcollapsestate
            // 
            this.deseriailize_expandcollapsestate.BeforeTouchSize = new System.Drawing.Size(350, 35);
            this.deseriailize_expandcollapsestate.Checked = true;
            this.deseriailize_expandcollapsestate.CheckState = System.Windows.Forms.CheckState.Checked;
            this.deseriailize_expandcollapsestate.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deseriailize_expandcollapsestate.ForeColor = System.Drawing.Color.Black;
            this.deseriailize_expandcollapsestate.ImageCheckBoxSize = new System.Drawing.Size(20, 20);
            this.deseriailize_expandcollapsestate.Location = new System.Drawing.Point(15, 800);
            this.deseriailize_expandcollapsestate.Margin = new System.Windows.Forms.Padding(0);
            this.deseriailize_expandcollapsestate.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.deseriailize_expandcollapsestate.Name = "deseriailize_expandcollapsestate";
            this.deseriailize_expandcollapsestate.Size = new System.Drawing.Size(350, 35);
            this.deseriailize_expandcollapsestate.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.deseriailize_expandcollapsestate.TabIndex = 18;
            this.deseriailize_expandcollapsestate.Text = "Deserialize Expand/Collapse State";
            this.deseriailize_expandcollapsestate.ThemesEnabled = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 45);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 28);
            this.label1.TabIndex = 9;
            this.label1.Text = "Serialization:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 480);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 28);
            this.label2.TabIndex = 10;
            this.label2.Text = "Deserialization:";
            // 
            // buttonAdv1
            // 
            this.buttonAdv1.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.buttonAdv1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(152)))), ((int)(((byte)(218)))));
            this.buttonAdv1.BeforeTouchSize = new System.Drawing.Size(175, 44);
            this.buttonAdv1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdv1.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdv1.ForeColor = System.Drawing.Color.White;
            this.buttonAdv1.IsBackStageButton = false;
            this.buttonAdv1.Location = new System.Drawing.Point(110, 415);
            this.buttonAdv1.Margin = new System.Windows.Forms.Padding(0);
            this.buttonAdv1.Name = "buttonAdv1";
            this.buttonAdv1.Size = new System.Drawing.Size(175, 44);
            this.buttonAdv1.TabIndex = 10;
            this.buttonAdv1.Text = "Serialize";
            this.buttonAdv1.UseVisualStyleBackColor = false;
            this.buttonAdv1.Click += new System.EventHandler(this.buttonAdv1_Click);
            // 
            // buttonAdv2
            // 
            this.buttonAdv2.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.buttonAdv2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(152)))), ((int)(((byte)(218)))));
            this.buttonAdv2.BeforeTouchSize = new System.Drawing.Size(175, 44);
            this.buttonAdv2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdv2.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdv2.ForeColor = System.Drawing.Color.White;
            this.buttonAdv2.IsBackStageButton = false;
            this.buttonAdv2.Location = new System.Drawing.Point(110, 855);
            this.buttonAdv2.Margin = new System.Windows.Forms.Padding(0);
            this.buttonAdv2.Name = "buttonAdv2";
            this.buttonAdv2.Size = new System.Drawing.Size(175, 44);
            this.buttonAdv2.TabIndex = 20;
            this.buttonAdv2.Text = "Deserialize";
            this.buttonAdv2.UseVisualStyleBackColor = false;
            this.buttonAdv2.Click += new System.EventHandler(this.buttonAdv2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonAdv3);
            this.groupBox1.Controls.Add(this.buttonAdv2);
            this.groupBox1.Controls.Add(this.buttonAdv1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.deseriailize_expandcollapsestate);
            this.groupBox1.Controls.Add(this.deseriailize_pivotcalculations);
            this.groupBox1.Controls.Add(this.deseriailize_pivotcolumns);
            this.groupBox1.Controls.Add(this.deseriailize_pivotrows);
            this.groupBox1.Controls.Add(this.deseriailize_condformats);
            this.groupBox1.Controls.Add(this.deseriailize_grouping);
            this.groupBox1.Controls.Add(this.deseriailize_sorting);
            this.groupBox1.Controls.Add(this.deseriailize_filtering);
            this.groupBox1.Controls.Add(this.seriailize_expandcollapsestate);
            this.groupBox1.Controls.Add(this.seriailize_pivotcalculations);
            this.groupBox1.Controls.Add(this.seriailize_pivotcolumns);
            this.groupBox1.Controls.Add(this.seriailize_pivotrows);
            this.groupBox1.Controls.Add(this.seriailize_condformats);
            this.groupBox1.Controls.Add(this.seriailize_grouping);
            this.groupBox1.Controls.Add(this.seriailize_sorting);
            this.groupBox1.Controls.Add(this.seriailize_filtering);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(1198, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(390, 825);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Options";
            // 
            // buttonAdv3
            // 
            this.buttonAdv3.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.buttonAdv3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(152)))), ((int)(((byte)(218)))));
            this.buttonAdv3.BeforeTouchSize = new System.Drawing.Size(175, 44);
            this.buttonAdv3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdv3.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdv3.ForeColor = System.Drawing.Color.White;
            this.buttonAdv3.IsBackStageButton = false;
            this.buttonAdv3.Location = new System.Drawing.Point(110, 915);
            this.buttonAdv3.Margin = new System.Windows.Forms.Padding(0);
            this.buttonAdv3.Name = "buttonAdv3";
            this.buttonAdv3.Size = new System.Drawing.Size(175, 44);
            this.buttonAdv3.TabIndex = 21;
            this.buttonAdv3.Text = "Reset";
            this.buttonAdv3.UseVisualStyleBackColor = false;
            this.buttonAdv3.Click += new System.EventHandler(this.buttonAdv3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.CaptionAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.CaptionBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.CaptionBarHeight = 50;
            this.CaptionButtonColor = System.Drawing.Color.White;
            this.CaptionButtonHoverColor = System.Drawing.Color.White;
            this.CaptionFont = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CaptionForeColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1588, 825);
            this.Controls.Add(this.pivotGridControl1);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1600, 900);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Serialization";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.seriailize_filtering)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seriailize_sorting)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seriailize_grouping)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seriailize_condformats)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seriailize_pivotrows)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seriailize_pivotcolumns)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seriailize_pivotcalculations)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seriailize_expandcollapsestate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deseriailize_filtering)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deseriailize_sorting)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deseriailize_grouping)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deseriailize_condformats)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deseriailize_pivotrows)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deseriailize_pivotcolumns)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deseriailize_pivotcalculations)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deseriailize_expandcollapsestate)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Syncfusion.Windows.Forms.PivotAnalysis.PivotGridControl pivotGridControl1;
        private Syncfusion.Windows.Forms.Tools.CheckBoxAdv seriailize_filtering;
        private Syncfusion.Windows.Forms.Tools.CheckBoxAdv seriailize_sorting;
        private Syncfusion.Windows.Forms.Tools.CheckBoxAdv seriailize_grouping;
        private Syncfusion.Windows.Forms.Tools.CheckBoxAdv seriailize_condformats;
        private Syncfusion.Windows.Forms.Tools.CheckBoxAdv seriailize_pivotrows;
        private Syncfusion.Windows.Forms.Tools.CheckBoxAdv seriailize_pivotcolumns;
        private Syncfusion.Windows.Forms.Tools.CheckBoxAdv seriailize_pivotcalculations;
        private Syncfusion.Windows.Forms.Tools.CheckBoxAdv seriailize_expandcollapsestate;
        private Syncfusion.Windows.Forms.Tools.CheckBoxAdv deseriailize_filtering;
        private Syncfusion.Windows.Forms.Tools.CheckBoxAdv deseriailize_sorting;
        private Syncfusion.Windows.Forms.Tools.CheckBoxAdv deseriailize_grouping;
        private Syncfusion.Windows.Forms.Tools.CheckBoxAdv deseriailize_condformats;
        private Syncfusion.Windows.Forms.Tools.CheckBoxAdv deseriailize_pivotrows;
        private Syncfusion.Windows.Forms.Tools.CheckBoxAdv deseriailize_pivotcolumns;
        private Syncfusion.Windows.Forms.Tools.CheckBoxAdv deseriailize_pivotcalculations;
        private Syncfusion.Windows.Forms.Tools.CheckBoxAdv deseriailize_expandcollapsestate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Syncfusion.Windows.Forms.ButtonAdv buttonAdv1;
        private Syncfusion.Windows.Forms.ButtonAdv buttonAdv2;
        private System.Windows.Forms.GroupBox groupBox1;
        private Syncfusion.Windows.Forms.ButtonAdv buttonAdv3;
    }
}


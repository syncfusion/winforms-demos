#region Copyright Syncfusion Inc. 2001 - 2015
//
//  Copyright Syncfusion Inc. 2001 - 2015. All rights reserved.
//
//  Use of this code is subject to the terms of our license.
//  A copy of the current license can be obtained at any time by e-mailing
//  licensing@syncfusion.com. Any infringement will be prosecuted under
//  applicable laws. 
//
#endregion

using System;
using System.Diagnostics;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

using Syncfusion.Grouping;
using Syncfusion.Windows.Forms.Grid.Grouping;
using Syncfusion.Windows.Forms.Grid;
using Syncfusion.Windows.Forms;
using System.IO;
using DemoCommon.Grid;
using System.Text.RegularExpressions;

namespace TestEngineOptimizations
{
    /// <summary>
    /// Summary description for Form1.
    /// </summary>
    public class Form1 : GridDemoForm
    {
        #region API Definition
        private Syncfusion.Windows.Forms.Grid.Grouping.GridGroupingControl _gridGroupingControl1;
        private IContainer components;
        public ListboxTextWriter Log;
        private GroupBox groupBox1;
        private Label label2;
        private Label label1;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv comboBoxAdv2;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv comboBoxAdv1;
        private ListBox listBox1;
        private Panel panel2;
        Timer t = null;
        ConfigCollection configurations;
        #endregion

        #region Properties
        public ConfigCollection Configurations
        {
            get
            {
                return configurations;
            }
            set
            {
                configurations = value;
            }
        }

        internal GridGroupingControl gridGroupingControl1
        {
            get
            {
                return this._gridGroupingControl1;
            }
            set
            {
                if (this._gridGroupingControl1 != value)
                {
                    if (this._gridGroupingControl1 != null)
                    {
                        this._gridGroupingControl1.PropertyChanging -= new DescriptorPropertyChangedEventHandler(_gridGroupingControl1_PropertyChanging);
                    }
                    this._gridGroupingControl1 = value;
                    if (this._gridGroupingControl1 != null)
                    {
                        this._gridGroupingControl1.PropertyChanging += new DescriptorPropertyChangedEventHandler(_gridGroupingControl1_PropertyChanging);
                    }
                }
            }
        }
        #endregion

        #region Constructor
        public Form1()
        {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();
            if (DpiAware.GetCurrentDpi() > 96)
            {
                this.CaptionBarHeight = (int)DpiAware.LogicalToDeviceUnits(this.CaptionBarHeight);
            }
            //
            // TODO: Add any constructor code after InitializeComponent call
            //       

            configurations = new ConfigCollection();
            configurations.Add(new Config("Reset Datasource"));
            configurations.Add(new Config("Flat Virtual List, 30 million records, Virtual Mode"));
            configurations.Add(new Config("Flat Virtual List, VirtualMode"));
            configurations.Add(new Config("Flat Virtual List, No Optimizations"));
            configurations.Add(new Config("Flat Virtual List, Using Custom Engine"));
            configurations.Add(new Config("Flat Virtual List, Sorted"));
            configurations.Add(new Config("Flat Virtual List, Grouped"));
            configurations.Add(new Config("Flat Virtual List, Grouped, VerticalPixelScroll"));
            configurations.Add(new Config("Flat DataView, VirtualMode, Pass-Through sorting enabled."));
            configurations.Add(new Config("Flat DataView, VirtualMode, Pass-Through sorting disabled."));
            configurations.Add(new Config("Flat DataView, Summaries."));
            configurations.Add(new Config("Flat DataView, Grouped."));

            ////			configurations.Add(new Config());

            InitializeSelectMenu();

            gridGroupingControl1 = new GridGroupingControl();
            Config con = new Config("Flat Virtual List, 30 million records, Virtual Mode");
            con.ApplyTo(this);            
            GridSettings();
            Log = new ListboxTextWriter(this.listBox1);
        }
        #endregion       

        #region Grid Settings
        /// <summary>
        /// Grid Settings for better Look and Fell
        /// </summary>
        private void GridSettings()
        {
            gridGroupingControl1.GridVisualStyles = GridVisualStyles.Metro;
            gridGroupingControl1.GridOfficeScrollBars = OfficeScrollBars.Metro;
            //Used to set the selection mode in grid
            this.gridGroupingControl1.TableOptions.ListBoxSelectionMode = SelectionMode.MultiExtended;
			this.gridGroupingControl1.TableControl.DpiAware = true;
            //Used to set the columns to fit as client size
            this.gridGroupingControl1.AllowProportionalColumnSizing = true;

            //Used to set GridCaptionRowHeight.
            this.gridGroupingControl1.Table.DefaultCaptionRowHeight = (int)DpiAware.LogicalToDeviceUnits(25.0f);
            this.gridGroupingControl1.Table.DefaultColumnHeaderRowHeight = (int)DpiAware.LogicalToDeviceUnits(30.0f);
            this.gridGroupingControl1.Table.DefaultRecordRowHeight = (int)DpiAware.LogicalToDeviceUnits(22.0f);

            //Navigate the tab key to other control
            this.gridGroupingControl1.WantTabKey = false;

            foreach (GridColumnDescriptor col in this.gridGroupingControl1.TableDescriptor.Columns)
            {
                Regex rex = new Regex(@"\p{Lu}");
                int index = rex.Match(col.MappingName.Substring(1)).Index;
                string name = "";
                while (index > 0)
                {
                    name += col.MappingName.Substring(0, index + 1) + " ";
                    string secondName = col.MappingName.Substring(index + 1);
                    index = rex.Match(secondName.Substring(1)).Index;
                    while (index > 0)
                    {
                        name += secondName.Substring(0, index + 1) + " ";
                        index = rex.Match(col.MappingName.Substring(name.Replace(" ", "").Length).Substring(1)).Index;
                    }
                }
                name += col.MappingName.Substring(name.Replace(" ", "").Length);
                col.HeaderText = name;
            }
        }
        #endregion

        #region Logging Memory Usage
        /// <summary>
        /// Logging the Memory usage for evenry performance in grid
        /// </summary>
        void LogMemoryUsage()
        {
            // Force garbage collection and get used memory size
            GC.Collect();
            System.Threading.Thread.Sleep(10);
            GC.Collect();
            System.Threading.Thread.Sleep(100);
            GC.Collect();
            Log.Write("Optimizations for {0}: ", this.gridGroupingControl1.TableDescriptor.Name);
            Log.Write("VirtualMode: {0}, ", this.gridGroupingControl1.Table.VirtualMode);
            Log.Write("WithoutCounter: {0}, ", this.gridGroupingControl1.Table.WithoutCounter);
            Log.WriteLine("RecordsAsDisplayElements: {0}, ", this.gridGroupingControl1.Table.RecordsAsDisplayElements);
            Process myProcess = Process.GetCurrentProcess();
#if SyncfusionFramework2_0
            double workingSetSizeinKiloBytes = myProcess.WorkingSet64 / 1000;
#else
			double workingSetSizeinKiloBytes = myProcess.WorkingSet / 1000;
#endif
            string s = "Process's physical memory usage: " + workingSetSizeinKiloBytes.ToString() + " kb \r\n";
            Log.WriteLine(s);
        }
        #endregion        

        #region Designer Stuffs
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxAdv2 = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.comboBoxAdv1 = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxAdv2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxAdv1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboBoxAdv2);
            this.groupBox1.Controls.Add(this.comboBoxAdv1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(669, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(322, 89);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Menu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Select";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Configuration";
            // 
            // comboBoxAdv2
            // 
            this.comboBoxAdv2.AllowNewText = false;
            this.comboBoxAdv2.BackColor = System.Drawing.Color.White;
            this.comboBoxAdv2.BeforeTouchSize = new System.Drawing.Size(172, 23);
            this.comboBoxAdv2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxAdv2.Location = new System.Drawing.Point(105, 54);
            this.comboBoxAdv2.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.comboBoxAdv2.Name = "comboBoxAdv2";
            this.comboBoxAdv2.DropDownStyle = ComboBoxStyle.DropDownList;
            this.comboBoxAdv2.Size = new System.Drawing.Size(172, 23);
            this.comboBoxAdv2.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.comboBoxAdv2.TabIndex = 2;
            this.comboBoxAdv2.SelectedIndexChanged += new System.EventHandler(this.comboBoxAdv2_SelectedIndexChanged);
            // 
            // comboBoxAdv1
            // 
            this.comboBoxAdv1.AllowNewText = false;
            this.comboBoxAdv1.BackColor = System.Drawing.Color.White;
            this.comboBoxAdv1.BeforeTouchSize = new System.Drawing.Size(172, 23);
            this.comboBoxAdv1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxAdv1.Items.AddRange(new object[] {
            "Modify",
            "Save to",
            "Open",
            "Exit"});
            this.comboBoxAdv1.ItemsImageIndexes.Add(new Syncfusion.Windows.Forms.Tools.ComboBoxAdv.ImageIndexItem(this.comboBoxAdv1, "Modify"));
            this.comboBoxAdv1.ItemsImageIndexes.Add(new Syncfusion.Windows.Forms.Tools.ComboBoxAdv.ImageIndexItem(this.comboBoxAdv1, "Save to"));
            this.comboBoxAdv1.ItemsImageIndexes.Add(new Syncfusion.Windows.Forms.Tools.ComboBoxAdv.ImageIndexItem(this.comboBoxAdv1, "Open"));
            this.comboBoxAdv1.ItemsImageIndexes.Add(new Syncfusion.Windows.Forms.Tools.ComboBoxAdv.ImageIndexItem(this.comboBoxAdv1, "Exit"));
            this.comboBoxAdv1.Location = new System.Drawing.Point(105, 19);
            this.comboBoxAdv1.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.comboBoxAdv1.Name = "comboBoxAdv1";
            this.comboBoxAdv1.DropDownStyle = ComboBoxStyle.DropDownList;
            this.comboBoxAdv1.Size = new System.Drawing.Size(172, 23);
            this.comboBoxAdv1.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.comboBoxAdv1.TabIndex = 1;
            this.comboBoxAdv1.SelectedIndexChanged += new System.EventHandler(this.comboBoxAdv1_SelectedIndexChanged);
            // 
            // listBox1
            // 
            this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox1.HorizontalScrollbar = true;
            this.listBox1.Location = new System.Drawing.Point(669, 111);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(322, 524);
            this.listBox1.TabIndex = 4;
            this.listBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(20, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(622, 626);
            this.panel2.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1012, 656);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.groupBox1);
            this.MinimumSize = new System.Drawing.Size(800, 450);
            this.Name = "Form1";
            this.Text = "Engine Optimization";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxAdv2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxAdv1)).EndInit();
            this.ResumeLayout(false);

        }
        void InitializeSelectMenu()
        {
            System.EventHandler menuItemSelectConfig_Click = new System.EventHandler(this.menuItemSelectConfig_Click);
            ArrayList list = new ArrayList();

            foreach (Config config in configurations)
            {
                list.Add(config.Name);

            }
            this.comboBoxAdv2.DataSource = list;
            this.comboBoxAdv2.SelectedIndex = 1;
        }
        #region Dispose
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
        #endregion
        #endregion

        #region Events
        private void menuItemSelectConfig_Click(object sender, System.EventArgs e)
        {
            MenuItem mi = (MenuItem)sender;
            Config config = this.configurations.Find(mi.Text);
            Log.WriteLine();
            Log.WriteLine("Select Configuration: " + mi.Text);
            Log.WriteLine(config.Comment);

            int time = Environment.TickCount;

            Cursor.Current = Cursors.WaitCursor;
            config.ApplyTo(this);
            this.Refresh();
            Cursor.Current = Cursors.Arrow;

            Log.WriteLine("Elapsed Time: {0}", Environment.TickCount - time);
            gridGroupingControl1.Appearance.AnyCell.Font.Facename = "Verdana";
            gridGroupingControl1.Appearance.AnyCell.TextColor = Color.MidnightBlue;
            this.DropShadow = true;
            this.gridGroupingControl1.GridVisualStyles = GridVisualStyles.Metro;

        }
        private void _gridGroupingControl1_PropertyChanging(object sender, DescriptorPropertyChangedEventArgs e)
        {
            if (Log != null)
            {
                Log.WriteLine(e.ToString());
                if (t != null)
                {
                    t.Tick -= new EventHandler(t_Tick);
                    t.Dispose();
                }
                t = new Timer();
                t.Interval = 100;
                t.Tick += new EventHandler(t_Tick);
                t.Start();
            }
        }

        private void t_Tick(object sender, EventArgs e)
        {
            Timer t = (Timer)sender;
            t.Tick -= new EventHandler(t_Tick);
            t.Dispose();
            this.LogMemoryUsage();
        }

        private void menuItemModifyConfiguration_Click(object sender, System.EventArgs e)
        {
            System.ComponentModel.Design.CollectionEditor ce = new System.ComponentModel.Design.CollectionEditor(this.configurations.GetType());
            Syncfusion.ComponentModel.WindowsFormsEditorServiceContainer esc = new Syncfusion.ComponentModel.WindowsFormsEditorServiceContainer(null);
            PropertyDescriptor pd = TypeDescriptor.GetProperties(this)["Configurations"];
            Syncfusion.ComponentModel.TypeDescriptorContext tdc = new Syncfusion.ComponentModel.TypeDescriptorContext(this, pd);
            tdc.ServiceProvider = esc;

            ce.EditValue(tdc, esc, Configurations);
            InitializeSelectMenu();
        }
        System.IO.MemoryStream stream;
        private void menuItemExitApp_Click(object sender, System.EventArgs e)
        {
            Application.Exit();
        }

        static XmlSerializer configCollectionSerializer;

        static XmlSerializer ConfigCollectionSerializer
        {
            get
            {
                if (configCollectionSerializer == null)
                    configCollectionSerializer = new XmlSerializer(typeof(ConfigCollection));
                return configCollectionSerializer;
            }
        }

        private void menuItemOpenFile_Click(object sender, System.EventArgs e)
        {
            try
            {
                FileDialog dlg = new OpenFileDialog();
                dlg.DefaultExt = "xml";
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    XmlTextReader xr = new XmlTextReader(dlg.FileName);
                    this.configurations = (ConfigCollection)ConfigCollectionSerializer.Deserialize(xr);
                    System.IO.MemoryStream stream2 = new System.IO.MemoryStream(stream.ToArray());
                    this.gridGroupingControl1.ApplyXmlSchema(new XmlTextReader(stream2));
                    xr.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void menuItemSaveToFile_Click(object sender, System.EventArgs e)
        {
            try
            {
                FileDialog dlg = new SaveFileDialog();
                dlg.DefaultExt = "xml";
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    XmlTextWriter xw = new XmlTextWriter(dlg.FileName, System.Text.Encoding.UTF8);
                    xw.Formatting = Formatting.Indented;
                    ConfigCollectionSerializer.Serialize(xw, configurations);
                    stream = new System.IO.MemoryStream();
                    this.gridGroupingControl1.WriteXmlSchema(new XmlTextWriter(stream, null));

                    xw.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void menuItem3_Click(object sender, System.EventArgs e)
        {
            DemoCommon.AboutForm abtForm = new DemoCommon.AboutForm(AppDomain.CurrentDomain.GetAssemblies());
            abtForm.ShowDialog();
        }

        private void comboBoxAdv1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxAdv1.SelectedItem == null)
                return;

            switch (comboBoxAdv1.SelectedItem.ToString())
            {
                case "Modify":
                    System.ComponentModel.Design.CollectionEditor ce = new System.ComponentModel.Design.CollectionEditor(this.configurations.GetType());
                    Syncfusion.ComponentModel.WindowsFormsEditorServiceContainer esc = new Syncfusion.ComponentModel.WindowsFormsEditorServiceContainer(null);
                    PropertyDescriptor pd = TypeDescriptor.GetProperties(this)["Configurations"];
                    Syncfusion.ComponentModel.TypeDescriptorContext tdc = new Syncfusion.ComponentModel.TypeDescriptorContext(this, pd);
                    tdc.ServiceProvider = esc;

                    ce.EditValue(tdc, esc, Configurations);
                    InitializeSelectMenu();
                    break;
                case "Save to":
                    try
                    {
                        FileDialog dlg = new SaveFileDialog();
                        dlg.DefaultExt = "xml";
                        dlg.Filter = "Files(*.xml)|*.Xml";
                        dlg.FileName = "Untitled";
                        if (dlg.ShowDialog() == DialogResult.OK)
                        {
                            XmlTextWriter xw = new XmlTextWriter(dlg.FileName, System.Text.Encoding.UTF8);
                            xw.Formatting = Formatting.Indented;
                            ConfigCollectionSerializer.Serialize(xw, configurations);
                            stream = new System.IO.MemoryStream();
                            this.gridGroupingControl1.WriteXmlSchema(new XmlTextWriter(stream, null));

                            xw.Close();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    break;
                case "Open":
                    try
                    {
                        FileDialog dlg = new OpenFileDialog();
                        dlg.DefaultExt = "xml";
                        dlg.Filter = "Files(*.xml)|*.Xml";
                        dlg.FileName = "Untitled";
                        if (dlg.ShowDialog() == DialogResult.OK)
                        {
                            XmlTextReader xr = new XmlTextReader(dlg.FileName);
                            this.configurations = (ConfigCollection)ConfigCollectionSerializer.Deserialize(xr);
                            if (stream != null)
                            {
                                System.IO.MemoryStream stream2 = new System.IO.MemoryStream(stream.ToArray());
                                this.gridGroupingControl1.ApplyXmlSchema(new XmlTextReader(stream2));
                            }
                            xr.Close();
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    break;
                case "Exit":
                    Application.Exit();
                    break;
            }
        }

        private void comboBoxAdv2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Log != null && comboBoxAdv2.SelectedItem != null)
            {
                //MenuItem mi = (ComboBox)sender;
                Config config = this.configurations.Find(comboBoxAdv2.SelectedItem.ToString());
                Log.WriteLine();
                Log.WriteLine("Select Configuration: " + comboBoxAdv2.SelectedItem.ToString());
                Log.WriteLine(config.Comment);
                int time = Environment.TickCount;
                Cursor.Current = Cursors.WaitCursor;
                config.ApplyTo(this);
                this.Refresh();
                Cursor.Current = Cursors.Arrow;
                Log.WriteLine("Elapsed Time: {0}", Environment.TickCount - time);
                gridGroupingControl1.Appearance.AnyCell.Font.Facename = "Verdana";
                gridGroupingControl1.GridVisualStyles = GridVisualStyles.Metro;
                gridGroupingControl1.GridOfficeScrollBars = OfficeScrollBars.Metro;
                this.BackColor = Color.White;
            }
        }

        #endregion

    }

    #region TextWriter
    /// <summary>
    /// This writer is used to display the actions performed in grid as text.
    /// </summary>
    public class ListboxTextWriter : TextWriter
    {
        ListBox lb;
        string lastItem = "";

        public ListboxTextWriter(ListBox lb)
        {
            this.lb = lb;
        }

        public override void Write(char[] buffer, int index, int count)
        {
            lastItem = new string(buffer, index, count).TrimEnd('\r', '\n', '\0');
            base.Write(buffer, index, count);
            lb.Items.Add(lastItem);
            lb.SelectedIndex = lb.Items.Count - 1;
        }

        public override System.Text.Encoding Encoding
        {
            get
            {
                return System.Text.Encoding.Unicode;
            }
        }
    }
    #endregion
}

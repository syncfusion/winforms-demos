#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Printing;
using Syncfusion.Windows.Forms.Diagram;
using System.Collections;
using Syncfusion.Windows.Forms.Diagram.Controls;
using Syncfusion.Windows.Forms.Tools;
using System.Drawing.Drawing2D;
using System.IO;
using Syncfusion.SVG.IO;
using System.Drawing.Imaging;
using Syncfusion.Windows.Forms;
using System.Data.SqlServerCe;

namespace SaveDiagramAsBinary
{
    public partial class Form1 : Form
    {
        #region Members
        public string fileName;
        string strCon;
        string saveMode = "ADD";
        #endregion

        #region Form initialize
        public Form1()
        {
            InitializeComponent();
            strCon = @"Data Source=..\..\..\..\..\..\common\Data\Diagram\db\Diagram.sdf";
			//upgrade the db to make it compatible
            try
            {
                SqlCeEngine dbEngine = new SqlCeEngine(strCon);
                dbEngine.Upgrade();
            }
            catch (Exception)
            {
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.diagram1.BeginUpdate();

            //Loads the diagram names into the diagramToolStripComboBox.
            LoadDiagramNames();
            string path = @"..\..\..\..\..\..\common\Data\Diagram\xml\Flowchart Symbols.xml";
            this.paletteGroupBar1.LoadPalette(path);            
            DiagramAppearance();
            if (comboOpen.Items.Count > 0)
            {
                comboOpen.SelectedIndex = 0;
                LoadDiagram();
            }
            GroupBarAppearance();
            this.diagram1.EndUpdate();
        }
        #endregion

        #region Private Methods
        /// <summary>
        /// Changes the appearance of the Diagram
        /// </summary>
        private void DiagramAppearance()
        {
            this.diagram1.HorizontalRuler.BackgroundColor = Color.White;
            this.diagram1.VerticalRuler.BackgroundColor = Color.White;  
            this.diagram1.View.Grid.GridStyle = GridStyle.Line;
            this.diagram1.View.Grid.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.diagram1.View.Grid.Color = Color.LightGray;
            this.diagram1.View.Grid.VerticalSpacing = 15;
            this.diagram1.View.Grid.HorizontalSpacing = 15;
            this.diagram1.Model.BackgroundStyle.GradientCenter = 0.5f;
            this.diagram1.View.HandleRenderer.HandleColor = Color.AliceBlue;
            this.diagram1.View.HandleRenderer.HandleOutlineColor = Color.SkyBlue;
            this.diagram1.Model.RenderingStyle.SmoothingMode = SmoothingMode.HighQuality;
            this.diagram1.View.BackgroundColor = Color.White;           
            this.diagram1.View.SelectionList.Clear();
        }

        /// <summary>
        /// Change's the appearance of GroupBar
        /// </summary>
        private void GroupBarAppearance()
        {
            this.paletteGroupBar1.BorderColor = System.Drawing.ColorTranslator.FromHtml("#119EDA");
            foreach (GroupBarItem item in paletteGroupBar1.GroupBarItems)
            {
                //palette view settings
                if (item.Client is PaletteGroupView)
                {
                    PaletteGroupView view = item.Client as PaletteGroupView;
                    view.Font = new Font("Segoe UI", 9, System.Drawing.FontStyle.Regular);
                    view.ForeColor = Color.Black;
                    view.FlowView = true;
                    view.ShowToolTips = true;
                    view.ShowFlowViewItemText = true;
                    view.SelectedItemColor = Color.FromArgb(255, 219, 118);
                    view.HighlightItemColor = Color.FromArgb(255, 227, 149);
                    view.SelectingItemColor = Color.FromArgb(255, 238, 184);
                    view.SelectedHighlightItemColor = Color.FromArgb(255, 218, 115);
                    view.FlowViewItemTextLength = (int)DpiAware.LogicalToDeviceUnits(80);
                    view.BackColor = Color.White;
                    view.TextWrap = true;
                    view.FlatLook = true;
                    view.BorderStyle = BorderStyle.FixedSingle;
                }
            }
        }
        #endregion

        #region InitializeDiagram

        /// <summary>
        /// Loads the Diagram 
        /// </summary>
        private void LoadDiagram()
        {
            //Create an instance of connection and command object.
            SqlCeConnection con = new SqlCeConnection(strCon);
            SqlCeCommand cmd = new SqlCeCommand("SELECT Diagram FROM DiagramContent WHERE DiagramName = @DiagramName", con);

            //Set parameter value.
            cmd.Parameters.AddWithValue("@DiagramName", comboOpen.Text);

            //Execute the command.
            con.Open();
            Byte[] dBinary = (Byte[])cmd.ExecuteScalar();
            con.Close();

            //Load the stream.
            MemoryStream dStream = new MemoryStream(dBinary, 0, dBinary.Length);
            dStream.Position = 0;
            diagram1.LoadBinary(dStream);
            dStream.Close();
        }

        /// <summary>
        /// Create New Diagram
        /// </summary>
        private void AddNewDiagram()
        {
            MemoryStream dStream = new MemoryStream();
            //Create an instance of the save form.
            SaveDialog saveDiagram = new SaveDialog();
            string strDiagramName = string.Empty;

            //Display the save form.
            if (saveDiagram.ShowDialog() == DialogResult.OK)
                strDiagramName = saveDiagram.DiagramName;
            else
                return;

            //Save the diagram content to stream.
            diagram1.SaveBinary(dStream);
            Byte[] dBinary = dStream.ToArray();

            //Create an instance of the connection and command object.
            SqlCeConnection con = new SqlCeConnection(strCon);
            SqlCeCommand cmd = new SqlCeCommand("INSERT INTO DiagramContent (DiagramName, Diagram) VALUES (@DiagramName, @Diagram)", con);

            //Set parameter values
            cmd.Parameters.AddWithValue("@DiagramName", strDiagramName);
            cmd.Parameters.AddWithValue("@Diagram", dBinary);

            //Execute the command.
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            //Reload the diagramToolStripComboBox control.
            LoadDiagramNames();

            comboOpen.SelectedItem = strDiagramName;
        }

        /// <summary>
        /// Updates the diagram in the database
        /// </summary>
        private void UpdateDiagram()
        {
            MemoryStream dStream = new MemoryStream();
            //Save the diagram content to stream.
            diagram1.SaveBinary(dStream);
            Byte[] dBinary = dStream.ToArray();

            //Create an instance of the connection and command object.
            SqlCeConnection con = new SqlCeConnection(strCon);
            SqlCeCommand cmd = new SqlCeCommand("UPDATE DiagramContent SET Diagram = @Diagram WHERE DiagramName = @DiagramName", con);

            //Set parameter value
            cmd.Parameters.AddWithValue("@Diagram", dBinary);
            cmd.Parameters.AddWithValue("@DiagramName", comboOpen.Text);

            //Execute the command.
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        /// <summary>
        /// Deletes the Diagram from database
        /// </summary>
        private void DeleteDiagram()
        {
            //Create an instance of the connection and command object.
            SqlCeConnection con = new SqlCeConnection(strCon);
            SqlCeCommand cmd = new SqlCeCommand("DELETE FROM DiagramContent WHERE DiagramName =@DiagramName", con);

            //Set parameter value
            cmd.Parameters.AddWithValue("@DiagramName", comboOpen.Text);

            //Execute the command.
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        /// <summary>
        /// Clears the diagram
        /// </summary>
        private void ClearDiagram()
        {
            this.diagram1.Model.Clear();
            saveMode = "ADD";
            comboOpen.SelectedIndex = -1;
        }

        /// <summary>
        /// Loads the Diagram Names into the Combo box.
        /// </summary>
        private void LoadDiagramNames()
        {
            int selectedIndex = -1;
            if (comboOpen.SelectedIndex != -1)
                selectedIndex = comboOpen.SelectedIndex;

            //Clear combobox items.
            comboOpen.Items.Clear();

            //Create an instance of datatable, connection and command object.
            DataTable dt = new DataTable();
            SqlCeConnection con = new SqlCeConnection(strCon);
            SqlCeCommand cmd = new SqlCeCommand("SELECT DiagramName FROM DiagramContent ORDER BY DiagramName", con);

            //Add items to the diagramToolStripComboBox control.
            con.Open();
            SqlCeDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboOpen.Items.Add(dr["DiagramName"]);
            }
            con.Close();

            comboOpen.SelectedIndex = selectedIndex;
        }
        #endregion

        #region Event Handlers

        
        #region MenuTools

        private void connectorToolStripButton_DropDownItemClicked(object sender, System.Windows.Forms.ToolStripItemClickedEventArgs e)
        {
            foreach (ToolStripMenuItem item in connectorToolStripButton.DropDownItems)
            {
                if (item.Checked)
                {
                    item.Checked = false;
                }
            }
            (e.ClickedItem as ToolStripMenuItem).Checked = true;
        }

        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            //Clears all the nodes in diagram
            ClearDiagram();
        }

        private void openToolStripButton_Click(object sender, EventArgs e)
        {
            //Validation
            if (string.IsNullOrEmpty(this.comboOpen.Text))
                return;

            saveMode = "UPDATE";
            //Loads the diagram from the database
            LoadDiagram();
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            if (saveMode == "ADD")
                AddNewDiagram();
            else
                UpdateDiagram();
        }

        private void deleteToolStripButton_Click(object sender, EventArgs e)
        {
            //Deletes the specified Diagram.
            DeleteDiagram();

            //Clears all the nodes in diagram
            ClearDiagram();

            //Reload the diagramToolStripComboBox control.
            LoadDiagramNames();

        }

        private void lineConnectorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetActiveTool("LineLinkTool");
        }

        private void directedLineConnectorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetActiveTool("DirectedLineLinkTool");
        }

        private void orthogonalConnectorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetActiveTool("OrthogonalLinkTool");
        }

        private void polylineConnectorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetActiveTool("PolylineLinkTool");
        }

        private void bezierConnectorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetActiveTool("BezierTool");
        }

        private void splineConnectorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetActiveTool("SplineTool");
        }
     
        #endregion

        #endregion      
               
        #region Helper Methods
        /// <summary>
        /// Finds the given diagram from database
        /// </summary>
        /// <param name="mdfFileName">Name of the diagram</param>
        /// <returns>returns the diagram name if found </returns>
        string FindDatabase(string mdfFileName)
        {
            for (int n = 0; n < 10; n++)
            {
                if (System.IO.File.Exists(mdfFileName))
                {
                    return mdfFileName;
                }
                mdfFileName = @"..\" + mdfFileName;
            }
            return "";
        }       
        
        /// <summary>
        /// Activate the given tool
        /// </summary>
        /// <param name="toolName">Tool name to be activated</param>
        private void SetActiveTool(string toolName)
        {
            this.diagram1.Controller.ActivateTool(toolName);
        }
        #endregion      
        
       
    }
}



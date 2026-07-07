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
using System.Collections;
using System.Drawing;
using System.ComponentModel;
using System.IO;
using System.Xml.Serialization;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml;

using Syncfusion.Windows.Forms.Grid;
using Syncfusion.Windows.Forms;

namespace PivotGridLibrary
{
	/// <summary>
	/// Specifies the colors and fonts used in a PivotGridControl
	/// </summary>
	[TypeConverter(typeof(ExpandableObjectConverter))]
	[Serializable]
	public class PivotAppearance : ISerializable
	{
        /// <summary>
        /// Default Constructor. Only present to support XML serialization.
        /// </summary>
        public PivotAppearance()
        {
           
        }

		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="Pivot">The PivotGridControl associated with this appearance object.</param>
		public PivotAppearance(PivotGridControl PivotGridControl)
		{
            this.PivotGridControl = PivotGridControl;
		}

		#region Serialization Support
		/// <summary>
		/// Initializes a new <see cref="PivotAppearance"/> from a serialization stream.
		/// </summary>
		/// <param name="info">An object that holds all the data needed to serialize or deserialize this instance.</param>
		/// <param name="context">Describes the source and destination of the serialized stream specified by info. </param>
		protected PivotAppearance(SerializationInfo info, StreamingContext context)
		{
			this.version = (int) info.GetValue("version", typeof(int));
   			
            this.totalString = (string) info.GetValue("totalString", typeof(string));
            this.grandTotalString = (string)info.GetValue("grandTotalString", typeof(string));
            this.allString = (string)info.GetValue("allString", typeof(string));

			this.valueCell = (GridStyleInfo) info.GetValue("valueCell", typeof(GridStyleInfo));
            this.rowTotalCell = (GridStyleInfo)info.GetValue("rowTotalCell", typeof(GridStyleInfo));
            this.rowExpandCell = (GridStyleInfo)info.GetValue("rowExpandCell", typeof(GridStyleInfo));
            this.rowCell = (GridStyleInfo)info.GetValue("rowCell", typeof(GridStyleInfo));
            this.columnExpandCell = (GridStyleInfo)info.GetValue("columnExpandCell", typeof(GridStyleInfo));
            this.columnTotalCell = (GridStyleInfo)info.GetValue("columnTotalCell", typeof(GridStyleInfo));
            this.columnCell = (GridStyleInfo)info.GetValue("columnCell", typeof(GridStyleInfo));
            this.calculationNameCell = (GridStyleInfo)info.GetValue("calculationNameCell", typeof(GridStyleInfo));
            this.topLeftCell = (GridStyleInfo)info.GetValue("topLeftCell", typeof(GridStyleInfo));

            if (version == 1)
            {
                this.visualStyle = (GridVisualStyles)info.GetValue("visualStyle", typeof(GridVisualStyles));
                this.themesEnabled = (bool)info.GetValue("themesEnabled", typeof(bool));
            }

			//addproperty  - need to add code here when you add a property to PivotAppearance

		}

        // //version = 0  - orignal version release as 5.2.0.xx
        // //version 1 adds:
        //            visualStyle
        //            themedEnabled
        private int version = 1; 
        
		/// <summary>
		/// Attaches an Appearance object to a particular PivotGridControl.
		/// </summary>
		/// <param name="Pivot">The Appearance object.</param>
        public void AttachPivot(PivotGridControl PivotGridControl)
		{
            this.PivotGridControl = PivotGridControl;
            this.PivotGridControl.SetAppearance(this);

            if (TotalStringChanged != null) TotalStringChanged(this, EventArgs.Empty);
            if (GrandTotalStringChanged != null) GrandTotalStringChanged(this, EventArgs.Empty);
            if (AllStringChanged != null) AllStringChanged(this, EventArgs.Empty);

            if (ValueCellChanged != null) ValueCellChanged(this, EventArgs.Empty);
            if (RowCellChanged != null) RowCellChanged(this, EventArgs.Empty);
            if (RowExpandCellChanged != null) RowExpandCellChanged(this, EventArgs.Empty);
            if (RowTotalCellChanged != null) RowTotalCellChanged(this, EventArgs.Empty);

            if (ColumnExpandCellChanged != null) ColumnExpandCellChanged(this, EventArgs.Empty);
            if (ColumnTotalCellChanged != null) ColumnTotalCellChanged(this, EventArgs.Empty);
            if (ColumnCellChanged != null) ColumnCellChanged(this, EventArgs.Empty);
            if (CalculationNameCellChanged != null) CalculationNameCellChanged(this, EventArgs.Empty);
            if (TopLeftCellChanged != null) TopLeftCellChanged(this, EventArgs.Empty);

            if (TotalStringChanged != null) TotalStringChanged(this, EventArgs.Empty);

            if (VisualStyleChanged != null) VisualStyleChanged(this, EventArgs.Empty);
            if (ThemesEnabledChanged != null) ThemesEnabledChanged(this, EventArgs.Empty);

            
			//addproperty - need to add code here when you add a property to PivotAppearance
		}

        internal PivotGridControl PivotGridControl;

		

        /// <summary>
        /// Creates an instance of <see cref="PivotAppearance"/> that was
        /// previously serialized as a XML file.
        /// </summary>
        /// <param name="fileName">The serialized filename.</param>
        /// <returns>A PivotAppearance.</returns>
        public static PivotAppearance LoadXML(string fileName)
        {
            PivotAppearance appearance = null;
            Stream s = File.OpenRead(fileName);

            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(PivotAppearance));
                appearance = serializer.Deserialize(s) as PivotAppearance;
            }
            finally
            {
                s.Close();
            }
            return appearance;
        }

        /// <summary>
        /// Saves this Appearance object in an XML file 
        /// with the specified filename.
        /// </summary>
        public void SaveXML(string fileName)
        {
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(PivotAppearance));
                TextWriter textWriter = new StreamWriter(fileName);

                XmlTextWriter xmlTextWriter = new XmlTextWriter(textWriter);
                xmlTextWriter.Formatting = Formatting.Indented;
                serializer.Serialize(xmlTextWriter, this);
                textWriter.Close();
            }
            catch
            {

            }
           
        }

		

		#region ISerializable Members

		/// <summary>
		/// Implements the ISerializable interface and returns the data needed to serialize the Appearance object.
		/// </summary>
		/// <param name="info">A SerializationInfo object containing the information required to serialize the Appearance object.</param>
		/// <param name="context">A StreamingContext object containing the source and destination of the serialized stream.</param>
		public void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			info.AddValue("version", version);
            info.AddValue("totalString", totalString);
            info.AddValue("grandTotalString", grandTotalString);
            info.AddValue("allString", allString);
            info.AddValue("valueCell", valueCell);
            info.AddValue("rowCell", rowCell);
            info.AddValue("rowExpandCell", rowExpandCell);
            info.AddValue("rowTotalCell", rowTotalCell);
            info.AddValue("columnExpandCell", columnExpandCell);
            info.AddValue("columnTotalCell", columnTotalCell);
            info.AddValue("columnCell", columnCell);
            info.AddValue("calculationNameCell", calculationNameCell);
            info.AddValue("topLeftCell", topLeftCell);

            if (version == 1)
            {
                info.AddValue("visualStyle", visualStyle);
                info.AddValue("themesEnabled", themesEnabled);
            }
			
			//addproperty  - need to add code here when you add a property to PivotAppearance
		}

		#endregion
		#endregion

		#region Properties

		#region strings

		#region Total

		private string totalString = "Total";
		
		/// <summary>
		/// Gets or sets the generic text for the word 'Total' used in summary cells. 
		/// </summary>
		[Browsable(true)]
        [Description("The generic text for the word 'Total' used in summary cells.")]
		[DefaultValue("Total")]
		[Category("Strings")]
        public string TotalString
		{
            get { return totalString; }
			set
			{
                if (value != totalString)
				{
                    totalString = value;
                    if (TotalStringChanged != null)
                        TotalStringChanged(this, EventArgs.Empty);
				}
			}
		}
		/// <summary>
		/// A notification event that is raised after TimeFormat is modified. 
		/// </summary>
        public event EventHandler TotalStringChanged;
		#endregion

        #region GrandTotal

        private string grandTotalString = "GrandTotal";

        /// <summary>
        /// Gets or sets the generic text for the word 'GrandTotal' used in summary cells. 
        /// </summary>
        [Browsable(true)]
        [Description("The generic text for the word 'GrandTotal' used in summary cells.")]
        [DefaultValue("GrandTotal")]
        [Category("Strings")]
        public string GrandTotalString
        {
            get { return grandTotalString; }
            set
            {
                if (value != grandTotalString)
                {
                    grandTotalString = value;
                    if (GrandTotalStringChanged != null)
                        GrandTotalStringChanged(this, EventArgs.Empty);
                }
            }
        }
        /// <summary>
        /// A notification event that is raised after GrandTotalString is modified. 
        /// </summary>
        public event EventHandler GrandTotalStringChanged;
        #endregion

        #region All

        private string allString = "(all)";

        /// <summary>
        /// Gets or sets the generic text for the word '(all)' used in in filter dropdowns. 
        /// </summary>
        [Browsable(true)]
        [Description("The generic text for the word '(all)' used in in filter dropdowns")]
        [DefaultValue("(all)")]
        [Category("Strings")]
        public string AllString
        {
            get { return allString; }
            set
            {
                if (value != allString)
                {
                    allString = value;
                    if (AllStringChanged != null)
                        AllStringChanged(this, EventArgs.Empty);
                }
            }
        }
        /// <summary>
        /// A notification event that is raised after AllString is modified. 
        /// </summary>
        public event EventHandler AllStringChanged;
        #endregion

		#endregion

        #region ValueCell
        private GridStyleInfo valueCell = null;

        /// <summary>
        /// Gets or sets the GridStyleInfo properties for value cells. 
        /// </summary>
        [Browsable(true)]
        [Description("The GridStyleInfo properties for value cells")]
        public GridStyleInfo ValueCell
        {
            get
            {
                if (valueCell == null)
                {
                    valueCell = new GridStyleInfo();
                }
                return valueCell;
            }
            set { valueCell = value; }
        }
        /// <summary>
        /// A notification event that is raised after ValueCell is modified. 
        /// </summary>
        public event EventHandler ValueCellChanged;
        #endregion

        #region CalculationNameCell
        private GridStyleInfo calculationNameCell = null;

        /// <summary>
        /// Gets or sets the GridStyleInfo properties for calculation name cells. 
        /// </summary>
        [Browsable(true)]
        [Description("The GridStyleInfo properties for calcualtion name cells")]
        public GridStyleInfo CalculationNameCell
        {
            get
            {
                if (calculationNameCell == null)
                {
                    calculationNameCell = new GridStyleInfo();
                }
                return calculationNameCell;
            }
            set { calculationNameCell = value; }
        }
        /// <summary>
        /// A notification event that is raised after CalculationNameCell is modified. 
        /// </summary>
        public event EventHandler CalculationNameCellChanged;
        #endregion

        #region TopLeftCell
        private GridStyleInfo topLeftCell = null;

        /// <summary>
        /// Gets or sets the GridStyleInfo properties for topleft cell. 
        /// </summary>
        [Browsable(true)]
        [Description("The GridStyleInfo properties for topleft cells")]
        public GridStyleInfo TopLeftCell
        {
            get
            {
                if (topLeftCell == null)
                {
                    topLeftCell = new GridStyleInfo();
                }
                return topLeftCell;
            }
            set { topLeftCell = value; }
        }
        /// <summary>
        /// A notification event that is raised after TopLeftCell is modified. 
        /// </summary>
        public event EventHandler TopLeftCellChanged;
        #endregion

        #region RowCell
        private GridStyleInfo rowCell = null;

        /// <summary>
        /// Gets or sets the GridStyleInfo properties for row grid cells. 
        /// </summary>
        [Browsable(true)]
        [Description("The GridStyleInfo properties for row grid cells")]
        public GridStyleInfo RowCell
        {
            get
            {
                if (rowCell == null)
                {
                    rowCell = new GridStyleInfo();
                }
                return rowCell;
            }
            set { rowCell = value; }
        }
        /// <summary>
        /// A notification event that is raised after RowCell is modified. 
        /// </summary>
        public event EventHandler RowCellChanged;
        #endregion

        #region RowExpandCell
        private GridStyleInfo rowExpandCell = null;

        /// <summary>
        /// Gets or sets the GridStyleInfo properties for row grid expand cells. 
        /// </summary>
        [Browsable(true)]
        [Description("The GridStyleInfo properties for row expandgrid cells")]
        public GridStyleInfo RowExpandCell
        {
            get
            {
                if (rowExpandCell == null)
                {
                    rowExpandCell = new GridStyleInfo();
                }
                return rowExpandCell;
            }
            set { rowExpandCell = value; }
        }
        /// <summary>
        /// A notification event that is raised after RowExpandCell is modified. 
        /// </summary>
        public event EventHandler RowExpandCellChanged;
        #endregion

        #region RowTotalCell
        private GridStyleInfo rowTotalCell = null;

        /// <summary>
        /// Gets or sets the GridStyleInfo properties for row grid total cells. 
        /// </summary>
        [Browsable(true)]
        [Description("The GridStyleInfo properties for row grid total cells")]
        public GridStyleInfo RowTotalCell
        {
            get
            {
                if (rowTotalCell == null)
                {
                    rowTotalCell = new GridStyleInfo();
                }
                return rowTotalCell;
            }
            set { rowTotalCell = value; }
        }
        /// <summary>
        /// A notification event that is raised after RowExpandCell is modified. 
        /// </summary>
        public event EventHandler RowTotalCellChanged;
        #endregion

        #region ColumnExpandCell
        private GridStyleInfo columnExpandCell = null;

        /// <summary>
        /// Gets or sets the GridStyleInfo properties for column grid expand cells. 
        /// </summary>
        [Browsable(true)]
        [Description("The GridStyleInfo properties for column grid expand cells")]
        public GridStyleInfo ColumnExpandCell
        {
            get
            {
                if (columnExpandCell == null)
                {
                    columnExpandCell = new GridStyleInfo();
                }
                return columnExpandCell;
            }
            set { columnExpandCell = value; }
        }
        /// <summary>
        /// A notification event that is raised after ColumnExpandCell is modified. 
        /// </summary>
        public event EventHandler ColumnExpandCellChanged;
        #endregion

        #region ColumnTotalCell
        private GridStyleInfo columnTotalCell = null;

        /// <summary>
        /// Gets or sets the GridStyleInfo properties for column grid total cells. 
        /// </summary>
        [Browsable(true)]
        [Description("The GridStyleInfo properties for column grid total cells")]
        public GridStyleInfo ColumnTotalCell
        {
            get
            {
                if (columnTotalCell == null)
                {
                    columnTotalCell = new GridStyleInfo();
                }
                return columnTotalCell;
            }
            set { columnTotalCell = value; }
        }
        /// <summary>
        /// A notification event that is raised after ColumnTotaldCell is modified. 
        /// </summary>
        public event EventHandler ColumnTotalCellChanged;
        #endregion

        #region ColumnCell
        private GridStyleInfo columnCell = null;

        /// <summary>
        /// Gets or sets the GridStyleInfo properties for column grid cells. 
        /// </summary>
        [Browsable(true)]
        [Description("The GridStyleInfo properties for column grid cells")]
        public GridStyleInfo ColumnCell
        {
            get
            {
                if (columnCell == null)
                {
                    columnCell = new GridStyleInfo();
                }
                return columnCell;
            }
            set { columnCell = value; }
        }
        /// <summary>
        /// A notification event that is raised after ColumnCell is modified. 
        /// </summary>
        public event EventHandler ColumnCellChanged;
        #endregion

        #region VisualStyle

        private GridVisualStyles visualStyle = GridVisualStyles.Office2007Blue;

        /// <summary>
        /// Gets or sets the GridVisualStyles for the control. 
        /// </summary>
        [Browsable(true)]
        [Description("The GridVisualStyles properties for the control")]
        public GridVisualStyles VisualStyle
        {
            get
            {
                return visualStyle;
            }
            set
            {
                if (visualStyle != value)
                {
                    visualStyle = value;
                    
                    if (VisualStyleChanged != null)
                        VisualStyleChanged(this, EventArgs.Empty);

                }
            }
        }

        /// <summary>
        /// A notification event that is raised after VisualStyle is modified. 
        /// </summary>
        public event EventHandler VisualStyleChanged;


        private bool themesEnabled = true;

        /// <summary>
        /// Gets or sets whether themed system drawing should be supported. This property only has an effect if 
        /// VisualStyle is set to GridVisualStyles.SystemTheme.
        /// </summary>
        [Browsable(true)]
        [Description("Indicates whether themed system drawing is used.")]
        public bool ThemesEnabled
        {
            get { return themesEnabled; }
            set
            {
                if (themesEnabled != value)
                {
                    themesEnabled = value;
                    if (ThemesEnabledChanged != null)
                        ThemesEnabledChanged(this, EventArgs.Empty);
                    
                }
            }
        }

        /// <summary>
        /// A notification event that is raised after ThemesEnabled is modified. 
        /// </summary>
        public event EventHandler ThemesEnabledChanged;

        #endregion

        #endregion

        /// <override />
		public override string ToString()
		{
			return "";
		}
		
	}

    	/// <summary>
	/// Specifies the colors and fonts used in a PivotGridControl
	/// </summary>
    [TypeConverter(typeof(ExpandableObjectConverter))]
    [Serializable]
    public class PivotSchema : ISerializable
    {

           /// <summary>
        /// Default Constructor. Only present to support XML serialization.
        /// </summary>
        public PivotSchema()
        {
           
        }

        public void ApplySchemaToPivotControl(PivotGridControl pivotControl)
        {
            pivotControl.ApplySchema(this);
        }

        public void InitSchemaFromPivotControl(PivotGridControl pivotControl)
        {

        }

        /// <summary>
        /// Creates an instance of <see cref="PivotSchema"/> that was
        /// previously serialized as a XML file.
        /// </summary>
        /// <param name="fileName">The serialized filename.</param>
        /// <returns>A PivotSchema.</returns>
        public static PivotSchema LoadXML(string fileName)
        {
            PivotSchema schema = null;
            Stream s = File.OpenRead(fileName);

            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(PivotSchema));
                schema = serializer.Deserialize(s) as PivotSchema;
            }
            finally
            {
                s.Close();
            }
            return schema;
        }

        #region XML Serialization Support
        /// <summary>
        /// Saves this PivotSchema object in an XML file 
        /// with the specified filename.
        /// </summary>
        public void SaveXML(string fileName)
        {
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(PivotSchema));
                TextWriter textWriter = new StreamWriter(fileName);

                XmlTextWriter xmlTextWriter = new XmlTextWriter(textWriter);
                xmlTextWriter.Formatting = Formatting.Indented;
                serializer.Serialize(xmlTextWriter, this);
                textWriter.Close();
            }
            catch
            {

            }

        }

        #endregion

        #region Binary Serialization Support
        /// <summary>
		/// Initializes a new <see cref="PivotSchema"/> from a serialization stream.
		/// </summary>
		/// <param name="info">An object that holds all the data needed to serialize or deserialize this instance.</param>
		/// <param name="context">Describes the source and destination of the serialized stream specified by info. </param>
        protected PivotSchema(SerializationInfo info, StreamingContext context)
		{
			this.version = (int) info.GetValue("version", typeof(int));
            this.fields = (string[])info.GetValue("fields", typeof(string[]));
            this.rowFields = (string[])info.GetValue("rowFields", typeof(string[]));
            this.columnFields = (string[])info.GetValue("columnFields", typeof(string[]));
            this.filterFields = (string[])info.GetValue("filterFields", typeof(string[]));
            this.filterValues = (string[])info.GetValue("filterValues", typeof(string[]));
            this.valueComputations = (PivotComputationInfo[])info.GetValue("valueComputations", typeof(PivotComputationInfo[]));
   			
 			//addproperty  - need to add code here when you add a property to PivotAppearance
		}

       
        /// <summary>
        /// Implements the ISerializable interface and returns the data needed to serialize the Appearance object.
        /// </summary>
        /// <param name="info">A SerializationInfo object containing the information required to serialize the Appearance object.</param>
        /// <param name="context">A StreamingContext object containing the source and destination of the serialized stream.</param>
        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("version", version);
            info.AddValue("fields", fields);
            info.AddValue("rowFields", rowFields);
            info.AddValue("columnFields", columnFields);
            info.AddValue("filterFields", filterFields);
            info.AddValue("filterValues", filterValues);
            info.AddValue("valueComputations", valueComputations);
          
            //addproperty  - need to add code here when you add a property to PivotAppearance
        }

         #endregion

        #region Properties

        // //version = 0  - orignal version release as 5.2.0.xx
        private int version = 0; 
        
		

        private string[] fields = null;

        public string[] Fields
        {
            get { return fields; }
            set { fields = value; }
        }

        private string[] rowFields = null;

        public string[] RowFields
        {
            get { return rowFields; }
            set { rowFields = value; }
        }

        private string[] columnFields = null;

        public string[] ColumnFields
        {
            get { return columnFields; }
            set { columnFields = value; }
        }

        private PivotComputationInfo[] valueComputations = null;

        public PivotComputationInfo[] ValueComputations
        {
            get { return valueComputations; }
            set { valueComputations = value; }
        }

        private string[] filterFields = null;

        public string[] FilterFields
        {
            get { return filterFields; }
            set { filterFields = value; }
        }

        private string[] filterValues = null;

        public string[] FilterValues
        {
            get { return filterValues; }
            set { filterValues = value; }
        }
		

    

		
		#endregion
    }

}

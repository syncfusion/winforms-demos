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
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using Syncfusion.Windows.Forms.Grid;

namespace EmployeeView
{
    #region "FieldStyle"

    [TypeConverter(typeof(System.ComponentModel.ExpandableObjectConverter))]
	public class FieldStyle
	{
		string fieldName;
		GridStyleInfo style = new GridStyleInfo();

		public string FieldName
		{
			get
			{
				return fieldName;
			}
			set
			{
				fieldName = value;
			}
		}
		
		[DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Content)]
		public GridStyleInfo Style
		{
			get
			{
				return style;
			}
			set
			{
				style = value;
			}
		}
	}
    #endregion

    #region "RecordFieldStyles"

    [TypeConverter(typeof(System.ComponentModel.ExpandableObjectConverter))]
	public class RecordFieldStyles
	{
		string recordKey;
		FieldStyleCollection fieldStyles = new FieldStyleCollection();

		public string RecordKey
		{
			get
			{
				return recordKey;
			}
			set
			{
				recordKey = value;
			}
		}

		[DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Content)]
		public FieldStyleCollection FieldStyles
		{
			get
			{
				return fieldStyles;
			}
			set
			{
				fieldStyles = value;
			}
		}
	}

    #endregion

    #region "TableRecordFieldStyles"
    [TypeConverter(typeof(System.ComponentModel.ExpandableObjectConverter))]
	public class TableRecordFieldStyles
	{
		string tableName;
		RecordFieldStylesCollection recordFieldStyles = new RecordFieldStylesCollection();

		public string TableName
		{
			get
			{
				return tableName;
			}
			set
			{
				tableName = value;
			}
		}

		[DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Content)]
		public RecordFieldStylesCollection RecordFieldStyles
		{
			get
			{
				return recordFieldStyles;
			}
			set
			{
				recordFieldStyles = value;
			}
		}

	}
    #endregion

    #region "'FieldStyleCollection' strongly typed collection class"

    [EditorAttribute(typeof(System.ComponentModel.Design.CollectionEditor), typeof(System.Drawing.Design.UITypeEditor))]
	public class FieldStyleCollection : System.Collections.CollectionBase 
	{
    
		public FieldStyleCollection() 
		{
		}
    
		public FieldStyleCollection(FieldStyleCollection fieValue) 
		{
			this.AddRange(fieValue);
		}
    
		public FieldStyleCollection(FieldStyle[] fieValue) 
		{
			this.AddRange(fieValue);
		}
    
		public FieldStyle this[int intIndex] 
		{
			get 
			{
				return ((FieldStyle)(List[intIndex]));
			}
			set 
			{
				List[intIndex] = value;
			}
		}

		public GridStyleInfo GetStyleByFieldName(string fieldName)
		{
			// Could optize using a sorted list that gets build up in this method and set dirty/cleared
			// whenever OnSet, OnInsert, OnRemove etc. is called

			for (int n = 0; n < Count; n++)
				if (this[n].FieldName == fieldName)
					return this[n].Style;
			return null;
		}

		public GridStyleInfo GetObject(string fieldName)
		{
			GridStyleInfo value = GetStyleByFieldName(fieldName);
			if (value == null)
			{
				FieldStyle obj = new FieldStyle();
				obj.FieldName = fieldName;
				value = obj.Style;
				Add(obj);
			}

			return value;
		}
    
		public int Add(FieldStyle fieValue) 
		{
			return List.Add(fieValue);
		}
    
		public void AddRange(FieldStyle[] fieValue) 
		{
			for (int intCounter = 0; (intCounter < fieValue.Length); intCounter = (intCounter + 1)) 
			{
				this.Add(fieValue[intCounter]);
			}
		}
    
		public void AddRange(FieldStyleCollection fieValue) 
		{
			for (int intCounter = 0; (intCounter < fieValue.Count); intCounter = (intCounter + 1)) 
			{
				this.Add(fieValue[intCounter]);
			}
		}
    
		public bool Contains(FieldStyle fieValue) 
		{
			return List.Contains(fieValue);
		}
    
		public void CopyTo(FieldStyle[] fieArray, int intIndex) 
		{
			List.CopyTo(fieArray, intIndex);
		}
    
		public int IndexOf(FieldStyle fieValue) 
		{
			return List.IndexOf(fieValue);
		}
    
		public void Insert(int intIndex, FieldStyle fieValue) 
		{
			List.Insert(intIndex, fieValue);
		}
    
		public new FieldStyleEnumerator GetEnumerator() 
		{
			return new FieldStyleEnumerator(this);
		}
    
		public void Remove(FieldStyle fieValue) 
		{
			List.Remove(fieValue);
		}
    
		public class FieldStyleEnumerator : object, System.Collections.IEnumerator 
		{
        
			private System.Collections.IEnumerator iEnBase;
        
			private System.Collections.IEnumerable iEnLocal;
        
			public FieldStyleEnumerator(FieldStyleCollection fieMappings) 
			{
				this.iEnLocal = ((System.Collections.IEnumerable)(fieMappings));
				this.iEnBase = iEnLocal.GetEnumerator();
			}
        
			public FieldStyle Current 
			{
				get 
				{
					return ((FieldStyle)(iEnBase.Current));
				}
			}
        
			object System.Collections.IEnumerator.Current 
			{
				get 
				{
					return iEnBase.Current;
				}
			}
        
			public bool MoveNext() 
			{
				return iEnBase.MoveNext();
			}
        
			bool System.Collections.IEnumerator.MoveNext() 
			{
				return iEnBase.MoveNext();
			}
        
			public void Reset() 
			{
				iEnBase.Reset();
			}
        
			void System.Collections.IEnumerator.Reset() 
			{
				iEnBase.Reset();
			}
		}
	}

	#endregion //('FieldStyleCollection' strongly typed collection class)

	#region "'RecordFieldStylesCollection' strongly typed collection class"


    [EditorAttribute(typeof(System.ComponentModel.Design.CollectionEditor), typeof(System.Drawing.Design.UITypeEditor))]
    public class RecordFieldStylesCollection : System.Collections.CollectionBase
    {

        public RecordFieldStylesCollection()
        {
        }

        public RecordFieldStylesCollection(RecordFieldStylesCollection recValue)
        {
            this.AddRange(recValue);
        }

        public RecordFieldStylesCollection(RecordFieldStyles[] recValue)
        {
            this.AddRange(recValue);
        }

        public RecordFieldStyles this[int intIndex]
        {
            get
            {
                return ((RecordFieldStyles)(List[intIndex]));
            }
            set
            {
                List[intIndex] = value;
            }
        }

        public FieldStyleCollection GetFieldStylesByRecordKey(object recordKey)
        {
            string s = recordKey.ToString();

            // Could optize using a sorted list that gets build up in this method and set dirty/cleared
            // whenever OnSet, OnInsert, OnRemove etc. is called

            for (int n = 0; n < Count; n++)
                if (this[n].RecordKey.Equals(s))
                    return this[n].FieldStyles;
            return null;
        }

        public FieldStyleCollection GetObject(object recordKey)
        {
            FieldStyleCollection value = GetFieldStylesByRecordKey(recordKey);
            if (value == null)
            {
                RecordFieldStyles obj = new RecordFieldStyles();
                obj.RecordKey = recordKey.ToString();
                value = obj.FieldStyles;
                Add(obj);
            }

            return value;
        }

        public int Add(RecordFieldStyles recValue)
        {
            return List.Add(recValue);
        }

        public void AddRange(RecordFieldStyles[] recValue)
        {
            for (int intCounter = 0; (intCounter < recValue.Length); intCounter = (intCounter + 1))
            {
                this.Add(recValue[intCounter]);
            }
        }

        public void AddRange(RecordFieldStylesCollection recValue)
        {
            for (int intCounter = 0; (intCounter < recValue.Count); intCounter = (intCounter + 1))
            {
                this.Add(recValue[intCounter]);
            }
        }

        public bool Contains(RecordFieldStyles recValue)
        {
            return List.Contains(recValue);
        }

        public void CopyTo(RecordFieldStyles[] recArray, int intIndex)
        {
            List.CopyTo(recArray, intIndex);
        }

        public int IndexOf(RecordFieldStyles recValue)
        {
            return List.IndexOf(recValue);
        }

        public void Insert(int intIndex, RecordFieldStyles recValue)
        {
            List.Insert(intIndex, recValue);
        }

        public new RecordFieldStylesEnumerator GetEnumerator()
        {
            return new RecordFieldStylesEnumerator(this);
        }

        public void Remove(RecordFieldStyles recValue)
        {
            List.Remove(recValue);
        }

        public class RecordFieldStylesEnumerator : object, System.Collections.IEnumerator
        {

            private System.Collections.IEnumerator iEnBase;

            private System.Collections.IEnumerable iEnLocal;

            public RecordFieldStylesEnumerator(RecordFieldStylesCollection recMappings)
            {
                this.iEnLocal = ((System.Collections.IEnumerable)(recMappings));
                this.iEnBase = iEnLocal.GetEnumerator();
            }

            public RecordFieldStyles Current
            {
                get
                {
                    return ((RecordFieldStyles)(iEnBase.Current));
                }
            }

            object System.Collections.IEnumerator.Current
            {
                get
                {
                    return iEnBase.Current;
                }
            }

            public bool MoveNext()
            {
                return iEnBase.MoveNext();
            }

            bool System.Collections.IEnumerator.MoveNext()
            {
                return iEnBase.MoveNext();
            }

            public void Reset()
            {
                iEnBase.Reset();
            }

            void System.Collections.IEnumerator.Reset()
            {
                iEnBase.Reset();
            }
        }
    }

	#endregion //('RecordFieldStylesCollection' strongly typed collection class)

	#region "'TableRecordFieldStylesCollection' strongly typed collection class"

    [EditorAttribute(typeof(System.ComponentModel.Design.CollectionEditor), typeof(System.Drawing.Design.UITypeEditor))]
    public class TableRecordFieldStylesCollection : System.Collections.CollectionBase
    {

        public TableRecordFieldStylesCollection()
        {
        }

        public TableRecordFieldStylesCollection(TableRecordFieldStylesCollection tabValue)
        {
            this.AddRange(tabValue);
        }

        public TableRecordFieldStylesCollection(TableRecordFieldStyles[] tabValue)
        {
            this.AddRange(tabValue);
        }

        public TableRecordFieldStyles this[int intIndex]
        {
            get
            {
                return ((TableRecordFieldStyles)(List[intIndex]));
            }
            set
            {
                List[intIndex] = value;
            }
        }

        public RecordFieldStylesCollection GetRecordFieldStylesByTableName(string tableName)
        {
            // Could optize using a sorted list that gets build up in this method and set dirty/cleared
            // whenever OnSet, OnInsert, OnRemove etc. is called

            for (int n = 0; n < Count; n++)
                if (this[n].TableName == tableName)
                    return this[n].RecordFieldStyles;

            return null;
        }

        public RecordFieldStylesCollection GetObject(string tableName)
        {
            RecordFieldStylesCollection value = GetRecordFieldStylesByTableName(tableName);
            if (value == null)
            {
                TableRecordFieldStyles obj = new TableRecordFieldStyles();
                obj.TableName = tableName;
                value = obj.RecordFieldStyles;
                Add(obj);
            }

            return value;
        }

        public int Add(TableRecordFieldStyles tabValue)
        {
            return List.Add(tabValue);
        }

        public void AddRange(TableRecordFieldStyles[] tabValue)
        {
            for (int intCounter = 0; (intCounter < tabValue.Length); intCounter = (intCounter + 1))
            {
                this.Add(tabValue[intCounter]);
            }
        }

        public void AddRange(TableRecordFieldStylesCollection tabValue)
        {
            for (int intCounter = 0; (intCounter < tabValue.Count); intCounter = (intCounter + 1))
            {
                this.Add(tabValue[intCounter]);
            }
        }

        public bool Contains(TableRecordFieldStyles tabValue)
        {
            return List.Contains(tabValue);
        }

        public void CopyTo(TableRecordFieldStyles[] tabArray, int intIndex)
        {
            List.CopyTo(tabArray, intIndex);
        }

        public int IndexOf(TableRecordFieldStyles tabValue)
        {
            return List.IndexOf(tabValue);
        }

        public void Insert(int intIndex, TableRecordFieldStyles tabValue)
        {
            List.Insert(intIndex, tabValue);
        }

        public new TableRecordFieldStylesEnumerator GetEnumerator()
        {
            return new TableRecordFieldStylesEnumerator(this);
        }

        public void Remove(TableRecordFieldStyles tabValue)
        {
            List.Remove(tabValue);
        }

        public class TableRecordFieldStylesEnumerator : object, System.Collections.IEnumerator
        {

            private System.Collections.IEnumerator iEnBase;

            private System.Collections.IEnumerable iEnLocal;

            public TableRecordFieldStylesEnumerator(TableRecordFieldStylesCollection tabMappings)
            {
                this.iEnLocal = ((System.Collections.IEnumerable)(tabMappings));
                this.iEnBase = iEnLocal.GetEnumerator();
            }

            public TableRecordFieldStyles Current
            {
                get
                {
                    return ((TableRecordFieldStyles)(iEnBase.Current));
                }
            }

            object System.Collections.IEnumerator.Current
            {
                get
                {
                    return iEnBase.Current;
                }
            }

            public bool MoveNext()
            {
                return iEnBase.MoveNext();
            }

            bool System.Collections.IEnumerator.MoveNext()
            {
                return iEnBase.MoveNext();
            }

            public void Reset()
            {
                iEnBase.Reset();
            }

            void System.Collections.IEnumerator.Reset()
            {
                iEnBase.Reset();
            }
        }
    }
	
	#endregion //('TableRecordFieldStylesCollection' strongly typed collection class)
}

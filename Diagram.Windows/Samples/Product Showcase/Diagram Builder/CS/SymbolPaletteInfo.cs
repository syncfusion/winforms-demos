#region Copyright Syncfusion Inc. 2001-2019.
// Copyright Syncfusion Inc. 2001-2019. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using System.Text;

namespace Syncfusion.Windows.Forms.Diagram.Samples.DiagramTool
{
    [Serializable]
    public class AssociatedSymbolPaletteInfo
    {
        public AssociatedSymbolPaletteInfo( ) {
        }

        public AssociatedSymbolPaletteInfo( string eddFileName , SymbolPaletteInfoCollection sinfo ) {
            this._eddFileName = eddFileName;
            this._sInfo = sinfo;
        }

        private string _eddFileName;
        public string EDDFileName {
            get {
                return _eddFileName;
            }
            set {
                _eddFileName = value;
            }
        }

        private SymbolPaletteInfoCollection _sInfo;
        public SymbolPaletteInfoCollection SymbolPaletteInfo {
            get {
                if ( _sInfo == null )
                    _sInfo = new SymbolPaletteInfoCollection( );
                return _sInfo;
            }
            set {
                _sInfo = value;
            }
        }

    }

    [Serializable]
    public class AssociatedSymbolPaletteInfoCollection: List<AssociatedSymbolPaletteInfo>
    {
        public AssociatedSymbolPaletteInfoCollection( ) {
        }

        public AssociatedSymbolPaletteInfo this[string EddFileName] {
            get {
                int idx = GetIndexOf( EddFileName );
                if ( idx != -1 )
                {
                    return this[idx];
                }
                return null;
            }
        }

        private int GetIndexOf( string eddFileName ) {
            int i = -1;
            foreach ( AssociatedSymbolPaletteInfo info in this )
            {
                if ( info.EDDFileName == eddFileName)
                {
                    i++;
                    break;
                }
            }
            return i;
        }

    }

    
    [Serializable]
    public class SymbolPaletteInfo
    {
        public SymbolPaletteInfo( ) {
        }

        public SymbolPaletteInfo( string symbolName, string fileLocation ) {
            this._symbolName = symbolName;
            this._fileLoc = fileLocation;
        }

        private string _symbolName;
        public string SymbolPaletteName {
            get {
                return _symbolName;
            }
            set {
                _symbolName = value;
            }
        }

        private string _fileLoc;
        public string FileLocation {
            get {
                return _fileLoc;
            }
            set {
                _fileLoc = value;
            }
        }

    }

    [Serializable]
    public class SymbolPaletteInfoCollection : List<SymbolPaletteInfo>
    {
        public SymbolPaletteInfoCollection( ) {
        }

        public SymbolPaletteInfo this[string SymbolPaletteName] {
            get {
                int idx = GetIndexOf( SymbolPaletteName );
                if ( idx != -1 )
                {
                    return this[idx];
                }
                return null;
            }
        }

        private int GetIndexOf( string symbolPaletteName ) {
            int i = -1;
            foreach ( SymbolPaletteInfo info in this )
            {
                if ( info.SymbolPaletteName == symbolPaletteName )
                {
                    i++;
                    break;
                }
            }
            return i;
        }

    }

}

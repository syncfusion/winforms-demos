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
using System.IO;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using Syncfusion.Windows.Forms;
using Syncfusion.Windows.Forms.Grid;

namespace FolderBrowser
{
	/// <summary>
	/// Summary description for FileCollection.
	/// </summary>
	class FileData : ArrayList 
	{
		string ffilePath;
		public FileData(string ffilePath) 
		{
			FilePath = ffilePath;
		}
		public string FilePath 
		{ 
			get { return ffilePath; } 
			set 
			{
				if(FilePath == value) return;
				Clear();
				this.ffilePath = value;
				try 
				{
					string[] dirs = System.IO.Directory.GetDirectories(ffilePath);
					for(int i = 0; i < dirs.Length; i ++)
						Add(new FileDataItem(FileDataItemType.Directory, dirs[i]));
					string[] files = System.IO.Directory.GetFiles(ffilePath);
					for(int i = 0; i < files.Length; i ++)
						Add(new FileDataItem(FileDataItemType.File, files[i]));
				} 
				catch 
				{

				}
			}
		}
		public new FileDataItem this[int index] { get {return base[index] as FileDataItem; } }
		public int IndexOf(string path) 
		{
			for(int i = 0; i < Count; i ++)
				if(path.Equals(this[i].FullName)) return i;
			return -1;
		}
	}
	public enum FileDataItemType {Up = 0, File, Directory};
	public class FileDataItem 
	{
		FileDataItemType fitemType;
		string fname, fdisplayName;
        long ffileSize, dirsize;
		DateTime fmodified;

		public FileDataItem(FileDataItemType fitemType, string fname) 
		{
			this.fitemType = fitemType;
			this.fname = fname;
			this.fdisplayName = ItemType != FileDataItemType.Up ? System.IO.Path.GetFileName(fname) : "..";
			this.ffileSize = -1;
            this.dirsize = 0;
		}
		public FileDataItemType ItemType { get { return this.fitemType; } }
		public string Name { get { return this.fdisplayName; } }
		public string FullName 
		{
			get 
			{
				return ItemType == FileDataItemType.Up ?	
					System.IO.Path.GetDirectoryName(this.fname) : this.fname;
			}
		}
		public string DirectoryName 
		{
			get 
			{
				return ItemType != FileDataItemType.Up ?	
					System.IO.Path.GetDirectoryName(this.fname) : this.fname;
			}
		}
		public int ImageIndex {	get { return (int)ItemType -1; } }
		public long Size 
		{
			get 
			{
				if(ItemType == FileDataItemType.File) 
				{
					UpdateFileInfo();
					return this.ffileSize;
				}
                else if (ItemType == FileDataItemType.Directory)
                {
                    UpdateDirInfo();
                    return this.dirsize;
                }
                else return 0;
			}
		}
		public DateTime Modified 
		{ 
			get 
			{ 
				if(ItemType == FileDataItemType.File) 
				{
					UpdateFileInfo();
					return this.fmodified; 
				} 
				else 
				{
					UpdateDirInfo();
					return this.fmodified;
				}
			} 
		}
		void UpdateFileInfo() 
		{
			if(this.ffileSize >= 0) return;
			System.IO.FileInfo fileInfo = new System.IO.FileInfo(this.fname);
			this.ffileSize = fileInfo.Length;
			this.fmodified = fileInfo.LastWriteTime;
		}
		void UpdateDirInfo() 
		{
			System.IO.DirectoryInfo dirInfo = new System.IO.DirectoryInfo(this.fname);
            try
            {
                FileInfo[] finfo = dirInfo.GetFiles();
                DirectoryInfo[] dinfo = dirInfo.GetDirectories();
                foreach (FileInfo ff in finfo)
                {
                    this.dirsize += ff.Length;
                }
                foreach (DirectoryInfo fd in dinfo)
                {
                    FileInfo[] finfo1 = fd.GetFiles();
                    foreach (FileInfo fi in finfo1)
                    {
                        this.dirsize += fi.Length;
                    }
                }
                this.fmodified = dirInfo.LastWriteTime;
            }
            catch { }
		}
	}
}

using System;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

using Syncfusion.Windows.Forms.Edit;
using Syncfusion.Windows.Forms.Edit.Utils.CodeSnippets;
using Syncfusion.XmlSerializersCreator;

namespace CodeSnippetsExtractor
{
	/// <summary>
	/// Class with static methods extracting code snippets from directories.
	/// </summary>
	public class CodeSnippetsExtractor
	{
		#region Static Methods
		/// <summary>
		/// Extracts code snippets from given folder and adds them to the current language configuration of EditControl.
		/// </summary>
		/// <param name="dir">Path to the directory with code snippets.</param>
		/// <param name="editor">Instance of EditControl to add code snippets to.</param>
		public static void Extract( string dir, EditControl editor )
		{
			CodeSnippetsContainer container = Extract( dir );

			foreach( string containerName in container.ContainersNames )
			{
				editor.Language.AddCodeSnippetsContainer( container.GetContainerByName( containerName ) );
			}

			foreach( string snippetName in container.SnippetsNames )
			{
				editor.Language.AddCodeSnippet( container.GetSnippetByTitle( snippetName ) );
			}
		}
		/// <summary>
		/// Extracts code snippets from given folder and serializes it to Xml file.
		/// </summary>
		/// <param name="dir">Path to directory with code snippets.</param>
		/// <param name="destXml">Rath to the Xml file to write code snippets to.</param>
		public static void Extract( string dir, string destXml )
		{
			XmlTextWriter writer = new XmlTextWriter( destXml, Encoding.Default );
			writer.Formatting = Formatting.Indented;

			CodeSnippetsContainer container = Extract( dir );

			XmlSerializer containerSer = SerializersManager.GetSerializer( typeof( CodeSnippetsContainer ) );
			containerSer.Serialize( writer, container );

			writer.Close();
		}
		/// <summary>
		/// Extracts code snippets from given folder and returns container with extracted items.
		/// </summary>
		/// <param name="dir">Path to the directory with code snippets.</param>
		/// <returns>CodeSnippetsContainer instance with extracted code snippets.</returns>
		public static CodeSnippetsContainer Extract( string dir )
		{
			CodeSnippetsContainer result = new CodeSnippetsContainer();

			Extract( dir, result );

			return result;
		}
		#endregion

		#region Private Methods
		/// <summary>
		/// Extracts code snippets from given folder and stores it in given container.
		/// </summary>
		/// <param name="dir">Path to the directory with code snippets.</param>
		/// <param name="container">Container to store snippets in.</param>
		private static void Extract( string dir, CodeSnippetsContainer container )
		{
			XmlSerializer snippetSer = SerializersManager.GetSerializer( typeof( CodeSnippet ) );

			string[] files = Directory.GetFiles( dir, "*.snippet" );

			foreach( string snippetFileName in files )
			{
				XmlReader reader = new XmlTextReader( snippetFileName );
				reader.MoveToContent();
				reader.Read(); // Read "CodeSnippets" element.
				reader.MoveToContent();

				while( reader.Name == "CodeSnippet" )
				{
					CodeSnippet snippet = ( CodeSnippet )snippetSer.Deserialize( reader );
					container.AddSnippet( snippet );
				}
			}

			string[] dirs = Directory.GetDirectories( dir );

			foreach( string dirName in dirs )
			{
				CodeSnippetsContainer newContainer = new CodeSnippetsContainer();
				int lastSlash = dirName.LastIndexOf( @"\" );
				newContainer.Name = dirName.Substring( lastSlash + 1 );
				Extract( dirName, newContainer );
				container.AddContainer( newContainer );
			}
		}
		#endregion
	}
}
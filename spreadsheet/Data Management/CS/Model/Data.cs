using System.Data;
using System.Data.SqlServerCe;
using System.Reflection;
using System.IO;

namespace ImportDataTable.Model
{
    public class Data
    {
        public static DataTable GetDataTable(string tablename)
        {
            using (SqlCeConnection con = new SqlCeConnection(string.Format(@"Data Source = {0}", FindFile("Northwind.sdf"))))
            {
                con.Open();
                SqlCeDataAdapter sda = new SqlCeDataAdapter(string.Format("SELECT * FROM {0}", tablename), con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                return dt;
            }
        }

        /// <summary>
        /// Below method to find a given database file.
        /// </summary>
        /// <param name="fileName">Database file name.</param>
        /// <returns>Path of the database file.</returns>
        public static string FindFile(string fileName)
        {
            int levelsToCheck = 12;
            string dataFolder = @"Common\Data";

            string rootPath = Path.GetDirectoryName(Assembly.GetEntryAssembly().CodeBase.Replace(@"file:///", ""));

            fileName = Path.GetFileName(fileName);

            for (int n = 0; n < levelsToCheck; n++)
            {
                string filePath = Path.Combine(rootPath, fileName);
                string fileDataPath = Path.Combine(rootPath, dataFolder);

                fileDataPath = Path.Combine(fileDataPath, fileName);

                if (File.Exists(filePath))
                    return new FileInfo(filePath).FullName;

                if (File.Exists(fileDataPath))
                    return new FileInfo(fileDataPath).FullName;

                rootPath = Directory.GetParent(rootPath).FullName;
            }

            return fileName;
        }
    }

}

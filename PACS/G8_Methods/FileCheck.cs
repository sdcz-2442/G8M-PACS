using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace G8_Methods
{
    public class FileCheck
    {
        G8_DataAccess.DataAccess dataAccess = new G8_DataAccess.DataAccess();

        public string generarLetras(string doc)
        {
            Random rand = new Random();
            for (int i = 0; i < 100000; i++)
            {
                int numero = rand.Next(26);
                char letra = (char)(((int)'A') + numero);
                doc += letra;
            }
            return doc;
        }

        public string traducirArchivos(string doc, string ProjectName, string idInnerEncryption)
        {
            string docTraducido = "";

            DataSet dts;
            dataAccess.connectToDDBB(ProjectName);
            dts = dataAccess.getByQuery("SELECT * FROM InnerEncryptionData WHERE IdInnerEncryption = " + Int32.Parse(idInnerEncryption) + " ORDER BY Word ASC", "InnerEncryptionData", ProjectName);
            Dictionary<string, string> dict = dts.Tables[0].AsEnumerable()
            .ToDictionary<DataRow, string, string>(row => row[2].ToString(),
                                       row => row[3].ToString());

            for (int i = 0; i < doc.Length; i++)
            {
                string letra = doc[i].ToString();
                docTraducido += dict[letra];
            }

            return docTraducido;
        }
        public string desTraducirArchivos(string doc, string idInnerEncryption, string ProjectName)
        {
            DataSet dts;
            dataAccess.connectToDDBB(ProjectName);
            string docDestraducido = "";

            if (idInnerEncryption == "")
            {
                MessageBox.Show("Error");
            } else
            {
                dts = dataAccess.getByQuery("SELECT * FROM InnerEncryptionData WHERE IdInnerEncryption = '" + Int32.Parse(idInnerEncryption) + "' ORDER BY Word ASC", "InnerEncryptionData", ProjectName);
                Dictionary<string, string> dict = dts.Tables[0].AsEnumerable()
                .ToDictionary<DataRow, string, string>(row => row[3].ToString(),
                                           row => row[2].ToString());

                for (int i = 0; i < doc.Length; i += 3)
                {
                    string code = doc[i].ToString() + doc[i + 1].ToString() + doc[i + 2].ToString();
                    docDestraducido += dict[code].ToString();
                }
            }
            return docDestraducido;
        }

        public void generarArchivos(string doc, string nombreDocumento, string path)
        {
            //path += "\\" + nombreDocumento + ".txt";
            if (!File.Exists(path))
            {
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.Write(doc);
                }
            }
        }

        public void zippearArchivos(string pathDirectory, string zipDirectory)
        {

            var zipFile = pathDirectory + @"\PACS.zip";
            var files = Directory.GetFiles(pathDirectory);

            using (var archive = ZipFile.Open(zipFile, ZipArchiveMode.Create))
            {
                foreach (var fPath in files)
                {
                    if (!fPath.Contains("PACSSOL"))
                    {
                        archive.CreateEntryFromFile(fPath, Path.GetFileName(fPath));
                    }
                }
            }
        }

        public void zippearArchivoPACSSOL(string pathDirectory, string zipDirectory)
        {

            var zipFile = pathDirectory + @"\PACSSOL.zip";
            var files = Directory.GetFiles(pathDirectory);

            using (var archive = ZipFile.Open(zipFile, ZipArchiveMode.Create))
            {
                foreach (var fPath in files)
                {
                    archive.CreateEntryFromFile(fPath, Path.GetFileName(fPath));
                }
            }
        }
        public void desZippearArchivos(string zipDirectory, string extractDirectory)
        {
            ZipFile.ExtractToDirectory(zipDirectory, extractDirectory);
        }
    }
}

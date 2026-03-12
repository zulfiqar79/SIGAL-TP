using SL.BLL.ExceptionBLL;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SL.DAL.Idioma_dal
{
    public sealed class Idioma_dal
    {
        #region
        private readonly static Idioma_dal _instance = new Idioma_dal();
        public static Idioma_dal Instance { get { return _instance; } }
        private Idioma_dal()
        {

        }
        #endregion

        private string folderLanguage = ConfigurationManager.AppSettings["FolderLanguage"];
        private string filePathLanguage = ConfigurationManager.AppSettings["FilePathLanguage"];
        public string Traducir(string key)
        {
            string filePath = $"{folderLanguage}/{filePathLanguage}{Thread.CurrentThread.CurrentUICulture}";

            using (StreamReader sr = new StreamReader(filePath))
            {
                while (!sr.EndOfStream)
                {
                    string[] dataFile = sr.ReadLine().Split('=');

                    if (dataFile[0] == key)
                    {
                        return dataFile[1];
                    }

                }
            }
            throw new PalabraInexistente();//NoSeEncontroLaPalabraException();
        }
        public List<string> GetIdiomaDisponible()
        {
            //new DirectoryInfo(folderLanguage).GetFiles(); min 38:22
            return null;
        }
    }
}

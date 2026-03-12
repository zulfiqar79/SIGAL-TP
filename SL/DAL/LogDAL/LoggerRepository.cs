using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SL.DAL.LogDAL
{
    internal class LoggerRepository
    {
        private readonly static LoggerRepository _instance = new LoggerRepository();


        //Ruta de almacenaje
        private string logFile = ConfigurationManager.AppSettings["LogFile"]; //Nombre del archivo
        private string logFileName = ConfigurationManager.AppSettings["LogFileName"];
        public static LoggerRepository Instance { get { return _instance; } }

        private LoggerRepository()
        {
        }

        public void WriteLog(string message)
        {
            string fileName = logFile + DateTime.Now.ToString("yyyyMMdd") + logFileName;
            using (StreamWriter sw = new StreamWriter(fileName, true))
            {
                string formattedMessage = $"---!---Error detectado: Fecha y hora: {DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")}- Error: {message} ";
                sw.WriteLine(formattedMessage);
            }
        }
    }
}

using SL.Servicios.Extension;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SL.BLL.ExceptionBLL
{
    internal static class Exception_BLL
    {
        //Acceder a nombres de app settings
        private static string dalAssembly = ConfigurationManager.AppSettings["DALAssembly"];
        private static string bllAssembly = ConfigurationManager.AppSettings["BLLAssembly"];

        public static void Handle(Exception ex, object sender)
        {
            //Aplicar nuestras politicas de excepciones
            //Console.WriteLine(ex.Message);
            //De que ensamblador vino
            string assemblyName = sender.GetType().Module.Name;
            if (assemblyName == dalAssembly)
            {
                DALPolitica(ex);
            }
            if (assemblyName == bllAssembly)
            {
                BLLPolitica(ex);
            }
        }
        public static void DALPolitica(Exception ex)
        {
            //1.Registrar bitacora
            //2.Propagar
            throw new Exception(string.Empty, ex);
        }
        public static void BLLPolitica(Exception ex)
        {
            if (ex.InnerException != null)
            {
                //Excepcion en BLL pero fue originada en DAL
                throw new Exception("Error accediendo a los datos...", ex);
            }
            else
            {
                //Es una exception porpia de BLL, registro bitacora
                LoggerService.WriteLog(ex.Message);
                //2.Propagar
                throw ex;
            }
        }
    }
}

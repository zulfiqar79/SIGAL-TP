using SL.BLL.ExceptionBLL;
using SL.DAL.Idioma_dal;
using SL.Servicios.Extension;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SL.BLL.IdiomaBLL
{
    public sealed class Idioma_bll
    {
        #region Singleton
        private readonly static Idioma_bll _instance = new Idioma_bll();
        public static Idioma_bll Instance { get { return _instance; } }
        private Idioma_bll() { }
        #endregion
        public string Traducir(string key)
        {
            try
            {
                return Idioma_dal.Instance.Traducir(key);
            }
            catch (PalabraInexistente ex)
            {
                //Determinar que hago. 
                //Registrar en el LOG
                LoggerService.WriteLog(ex.Message);
                throw ex;

            }
        }
    }
}

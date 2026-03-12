using SL.BLL.IdiomaBLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SL.Servicios.Extension
{
    public static class StringExtension //service de extension
    {
        
        public static string Traducir(this string palabra)
        {
            return Idioma_bll.Instance.Traducir(palabra);
        }
    }
}

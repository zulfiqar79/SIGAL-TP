using SL.Servicios.Extension;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SL.BLL.ExcepcionBLL
{
    public class DatosFaltantes : Exception
    {
        public DatosFaltantes() : base("Debe completar todos los datos solicitados.".Traducir())
        {

        }
    }
}

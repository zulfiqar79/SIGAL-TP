using SL.Servicios.Extension;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SL.BLL.ExcepcionBLL
{
    public class AlquilerFinalizado : Exception
    {
        public AlquilerFinalizado() : base("El alquiler ya se encuentra finalizado.".Traducir())
        {
        }
    }
}
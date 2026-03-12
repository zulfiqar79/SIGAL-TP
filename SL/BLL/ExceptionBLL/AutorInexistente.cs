using SL.Servicios.Extension;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SL.BLL.ExcepcionBLL
{
    public class AutorInexistente : Exception
    {
        public AutorInexistente() : base("El autor indicado no existe en el sistema.".Traducir())
        {
        }
    }
}

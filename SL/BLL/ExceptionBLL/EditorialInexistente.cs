using SL.Servicios.Extension;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SL.BLL.ExcepcionBLL
{
    public class EditorialInexistente : Exception
    {
        public EditorialInexistente() : base("La editorial no existe en el sistema.".Traducir())
        {
        }
    }
}

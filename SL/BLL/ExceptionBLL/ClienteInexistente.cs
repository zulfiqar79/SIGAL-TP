using SL.Servicios.Extension;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SL.BLL.ExcepcionBLL
{
    public class ClienteInexistente : Exception
    {
        public ClienteInexistente() : base("El cliente que desea eliminar no existe.".Traducir())
        {

        }
    }
}
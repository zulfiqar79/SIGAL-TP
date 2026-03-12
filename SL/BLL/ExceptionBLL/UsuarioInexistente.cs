using SL.Servicios.Extension;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SL.BLL.ExcepcionBLL
{
    public class UsuarioInexistente : Exception
    {
        public UsuarioInexistente() : base("El usuario ingresado no existe en el sistema.".Traducir())
        {

        }
    }
}

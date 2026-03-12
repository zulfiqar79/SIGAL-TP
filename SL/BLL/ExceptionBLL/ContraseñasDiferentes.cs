using SL.Servicios.Extension;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SL.BLL.ExcepcionBLL
{
    public class ContraseñasDiferentes : Exception
    {
        public ContraseñasDiferentes() : base("Las contraseñas indicadas no coinciden".Traducir())
        {
        }
    }
}

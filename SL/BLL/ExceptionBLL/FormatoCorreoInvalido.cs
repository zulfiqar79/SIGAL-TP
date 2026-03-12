using SL.Servicios.Extension;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SL.BLL.ExcepcionBLL
{
    public class FormatoCorreoInvalido : Exception
    {
        public FormatoCorreoInvalido() : base("Formato de correo invalido. El aceptado es @gmail / @hotmail".Traducir())
        {

        }
    }
}
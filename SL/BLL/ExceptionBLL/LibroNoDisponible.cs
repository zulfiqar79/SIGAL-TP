using SL.Servicios.Extension;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SL.BLL.ExcepcionBLL
{
    public class LibroNoDisponible : Exception
    {
        public LibroNoDisponible() : base("Libro no disponible. El libro indicado se encuentra alquilado.".Traducir())
        {
        }
    }
}
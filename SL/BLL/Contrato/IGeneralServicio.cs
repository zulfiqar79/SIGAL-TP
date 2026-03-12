using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SL.BLL.Contrato
{
    public interface IGeneralServicio<T>
    {
        void Insertar(T obj);
        void Eliminar(T obj);
        void Modificar(T obj);
        T Obtener(T obj);
        IEnumerable<T> ObtenerTodo();
    }
}

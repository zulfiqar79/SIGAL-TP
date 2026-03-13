using DAL.AccesoDatos.libro;
using DAL.DAO;

namespace BLL.BusinessLogic.libro.Estrategia
{
    /// <summary>
    /// El autor es nuevo: se toma el ID recién insertado desde la BD.
    /// La editorial ya existe: su ID viene en el objeto Libro.
    /// </summary>
    public class AutorNuevoEditorialExistente : IInsercionLibroStrategy
    {
        public int? ObtenerIdAutor(Libro obj)
            => LibroDAL.Instance.ObtenerUltimoIdAutor();

        public int? ObtenerIdEditorial(Libro obj)
            => obj.ID_EDITORIAL_LIBRO;
    }
}

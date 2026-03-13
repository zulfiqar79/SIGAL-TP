using DAL.AccesoDatos.libro;
using Domain;

namespace BLL.BusinessLogic.libro.Estrategia
{
    /// <summary>
    /// Autor y editorial son nuevos: se toman los IDs recién insertados desde la BD.
    /// </summary>
    public class AutorNuevoEditorialNueva : IInsercionLibroStrategy
    {
        public int? ObtenerIdAutor(Libro obj)
            => LibroDAL.Instance.ObtenerUltimoIdAutor();

        public int? ObtenerIdEditorial(Libro obj)
            => LibroDAL.Instance.ObtenerUltimoIdEditorial();
    }
}

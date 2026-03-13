using DAL.AccesoDatos.libro;
using Domain;

namespace BLL.BusinessLogic.libro.Estrategia
{
    /// <summary>
    /// El autor ya existe: su ID viene en el objeto Libro.
    /// La editorial es nueva: se toma el ID recién insertado desde la BD.
    /// </summary>
    public class AutorExistenteEditorialNueva : IInsercionLibroStrategy
    {
        public int? ObtenerIdAutor(Libro obj)
            => obj.ID_AUTOR_LIBRO;

        public int? ObtenerIdEditorial(Libro obj)
            => LibroDAL.Instance.ObtenerUltimoIdEditorial();
    }
}

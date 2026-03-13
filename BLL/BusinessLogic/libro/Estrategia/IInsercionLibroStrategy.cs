using Domain;

namespace BLL.BusinessLogic.libro.Estrategia
{
    /// <summary>
    /// Estrategia para resolver los IDs de autor y editorial
    /// al momento de insertar un libro. Permite que LibroBLL
    /// use distintos comportamientos sin duplicar código.
    /// </summary>
    public interface IInsercionLibroStrategy
    {
        int? ObtenerIdAutor(Libro obj);
        int? ObtenerIdEditorial(Libro obj);
    }
}

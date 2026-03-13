using DAL.DAO;

namespace BLL.BusinessLogic.libro.Estrategia
{
    /// <summary>
    /// Tanto el autor como la editorial ya existen:
    /// ambos IDs vienen directamente en el objeto Libro.
    /// </summary>
    public class AutorExistenteEditorialExistente : IInsercionLibroStrategy
    {
        public int? ObtenerIdAutor(Libro obj)
            => obj.ID_AUTOR_LIBRO;

        public int? ObtenerIdEditorial(Libro obj)
            => obj.ID_EDITORIAL_LIBRO;
    }
}

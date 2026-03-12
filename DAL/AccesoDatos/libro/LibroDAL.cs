using DAL.DAO;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace DAL.AccesoDatos.libro
{
    public sealed class LibroDAL
    {
        #region
        private readonly static LibroDAL _instance = new LibroDAL();
        public static LibroDAL Instance { get { return _instance; } }
        private LibroDAL()
        {
        }
        #endregion

        public int ObtenerUltimoIdAutor()
        {
            using (base_sigalEntities db = new base_sigalEntities())
            {
                return db.Autor.Max(e => e.ID_AUTOR);
            }
        }

        public int ObtenerUltimoIdEditorial()
        {
            using (base_sigalEntities db = new base_sigalEntities())
            {
                return db.Editorial.Max(e => e.ID_EDITORIAL);
            }
        }

        public void Insertar(Libro libro)
        {
            using (base_sigalEntities db = new base_sigalEntities())
            {
                db.Libro.Add(libro);
                db.SaveChanges();
            }
        }

        public Libro ObtenerPorIdYTitulo(int idLibro, string tituloLibro)
        {
            using (base_sigalEntities db = new base_sigalEntities())
            {
                db.Configuration.LazyLoadingEnabled = false;
                db.Configuration.ProxyCreationEnabled = false;

                return db.Libro
                    .Include(x => x.Autor)
                    .Include(x => x.Editorial)
                    .FirstOrDefault(x => x.ID_LIBRO == idLibro && x.TITULO_LIBRO == tituloLibro);
            }
        }

        public Libro ObtenerPorTituloOId(string tituloLibro, int idLibro)
        {
            using (base_sigalEntities db = new base_sigalEntities())
            {
                db.Configuration.LazyLoadingEnabled = false;
                db.Configuration.ProxyCreationEnabled = false;

                return db.Libro
                    .Include(x => x.Autor)
                    .Include(x => x.Editorial)
                    .FirstOrDefault(x => x.TITULO_LIBRO == tituloLibro || x.ID_LIBRO == idLibro);
            }
        }

        public void Modificar(Libro libro)
        {
            using (base_sigalEntities db = new base_sigalEntities())
            {
                db.Libro.Attach(libro);
                db.Entry(libro).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
        }

        public List<Libro> ListaDeLibroAlquilados()
        {
            using (base_sigalEntities db = new base_sigalEntities())
            {
                db.Configuration.LazyLoadingEnabled = false;
                db.Configuration.ProxyCreationEnabled = false;

                return db.Libro
                    .Include(x => x.Autor)
                    .Include(x => x.Editorial)
                    .Where(x => x.ESTADO_LIBRO == "ALQUILADO")
                    .ToList();
            }
        }

        public IEnumerable<Libro> ObtenerTodo()
        {
            using (base_sigalEntities db = new base_sigalEntities())
            {
                db.Configuration.LazyLoadingEnabled = false;
                db.Configuration.ProxyCreationEnabled = false;

                return db.Libro
                    .Include(x => x.Autor)
                    .Include(x => x.Editorial)
                    .ToList();
            }
        }
    }
}
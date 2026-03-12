using DAL.DAO;
using System.Collections.Generic;
using System.Linq;

namespace DAL.AccesoDatos.libro
{
    public sealed class AutorDAL
    {
        #region Singleton
        private readonly static AutorDAL _instance = new AutorDAL();
        public static AutorDAL Instance { get { return _instance; } }
        private AutorDAL()
        {
        }
        #endregion

        public void Insertar(Autor obj)
        {
            using (base_sigalEntities db = new base_sigalEntities())
            {
                db.Autor.Add(obj);
                db.SaveChanges();
            }
        }

        public Autor Obtener(Autor obj)
        {
            using (base_sigalEntities db = new base_sigalEntities())
            {
                return db.Autor
                    .Where(x => x.NOMBRE_AUTOR == obj.NOMBRE_AUTOR && x.APELLIDO_AUTOR == obj.APELLIDO_AUTOR)
                    .FirstOrDefault();
            }
        }

        public IEnumerable<Autor> ObtenerTodo()
        {
            using (base_sigalEntities db = new base_sigalEntities())
            {
                return db.Autor.ToList();
            }
        }
    }
}
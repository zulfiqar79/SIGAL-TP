using DAL.DAO;
using System.Collections.Generic;
using System.Linq;

namespace DAL.AccesoDatos.libro
{
    public sealed class EditorialDAL
    {
        #region Singleton
        private readonly static EditorialDAL _instance = new EditorialDAL();
        public static EditorialDAL Instance { get { return _instance; } }
        private EditorialDAL()
        {
        }
        #endregion

        public void Insertar(Editorial obj)
        {
            using (base_sigalEntities db = new base_sigalEntities())
            {
                db.Editorial.Add(obj);
                db.SaveChanges();
            }
        }

        public Editorial Obtener(Editorial obj)
        {
            using (base_sigalEntities db = new base_sigalEntities())
            {
                return db.Editorial
                    .Where(x => x.NOMBRE_EDITORIAL == obj.NOMBRE_EDITORIAL)
                    .FirstOrDefault();
            }
        }

        public IEnumerable<Editorial> ObtenerTodo()
        {
            using (base_sigalEntities db = new base_sigalEntities())
            {
                return db.Editorial.ToList();
            }
        }
    }
}
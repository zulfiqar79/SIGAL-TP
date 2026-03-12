using DAL.DAO;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace DAL.AccesoDatos.alquiler
{
    public sealed class AlquilerDAL
    {
        #region
        private readonly static AlquilerDAL _instance = new AlquilerDAL();
        public static AlquilerDAL Instance { get { return _instance; } }
        private AlquilerDAL()
        {
        }
        #endregion

        public int ObtenerUltimoIdDetalleAlquiler()
        {
            using (base_sigalEntities db = new base_sigalEntities())
            {
                return db.DAlquiler.Max(e => e.ID_DETALLE_ALQUILER);
            }
        }

        public void Insertar(Alquiler obj)
        {
            using (base_sigalEntities db = new base_sigalEntities())
            {
                db.Alquiler.Add(obj);
                db.SaveChanges();
            }
        }

        public Alquiler ObtenerUltimoAlquiler()
        {
            using (base_sigalEntities db = new base_sigalEntities())
            {
                return db.Alquiler
                    .OrderByDescending(a => a.ID_ALQUILER)
                    .FirstOrDefault();
            }
        }

        public IEnumerable<DAlquiler> ObtenerPendientesConAlquiler()
        {
            using (base_sigalEntities db = new base_sigalEntities())
            {
                return db.DAlquiler
                    .Where(da => da.ESTADO == "PENDIENTE")
                    .Include(x => x.Alquiler)
                    .ToList();
            }
        }
    }
}
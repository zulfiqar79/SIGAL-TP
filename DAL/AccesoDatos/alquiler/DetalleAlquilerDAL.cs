using DAL.DAO;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DAL.AccesoDatos.alquiler
{
    public sealed class DetalleAlquilerDAL
    {
        #region
        private readonly static DetalleAlquilerDAL _instance = new DetalleAlquilerDAL();
        public static DetalleAlquilerDAL Instance { get { return _instance; } }
        private DetalleAlquilerDAL()
        {
        }
        #endregion

        public int ObtenerUltimoIdPago()
        {
            using (base_sigalEntities db = new base_sigalEntities())
            {
                return db.Pago.Max(x => x.ID_PAGO);
            }
        }

        public void Insertar(DAlquiler obj)
        {
            using (base_sigalEntities db = new base_sigalEntities())
            {
                db.DAlquiler.Add(obj);
                db.SaveChanges();
            }
        }

        public DAlquiler ObtenerPorIdDetalleYLibro(int idDetalleAlquiler, int idLibro)
        {
            using (base_sigalEntities db = new base_sigalEntities())
            {
                return db.DAlquiler
                    .FirstOrDefault(x => x.ID_DETALLE_ALQUILER == idDetalleAlquiler && x.ID_LIBRO == idLibro);
            }
        }

        public void Modificar(DAlquiler obj)
        {
            using (base_sigalEntities db = new base_sigalEntities())
            {
                db.DAlquiler.Attach(obj);
                db.Entry(obj).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
        }

        public List<DAlquiler> ListaAlquilerMesActual()
        {
            using (base_sigalEntities db = new base_sigalEntities())
            {
                db.Configuration.LazyLoadingEnabled = false;
                db.Configuration.ProxyCreationEnabled = false;

                var hoy = DateTime.Now;

                return db.DAlquiler
                    .Where(a => a.FECHA_INICIO.HasValue
                             && a.FECHA_INICIO.Value.Month == hoy.Month
                             && a.FECHA_INICIO.Value.Year == hoy.Year)
                    .ToList();
            }
        }

        public IEnumerable<DAlquiler> ObtenerPendientes()
        {
            using (base_sigalEntities db = new base_sigalEntities())
            {
                return db.DAlquiler
                    .Where(da => da.ESTADO == "PENDIENTE")
                    .ToList();
            }
        }
    }
}
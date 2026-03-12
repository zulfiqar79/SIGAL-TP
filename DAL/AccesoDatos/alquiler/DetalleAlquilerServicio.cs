using SL.BLL.Contrato;
using DAL.DAO;
using SL.Servicios.Extension;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.Entity;
using System.Data.Entity.SqlServer;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SL.BLL.ExcepcionBLL;

namespace DAL.AccesoDatos.alquiler
{
    public sealed class DetalleAlquilerServicio : IGeneralServicio<DAlquiler>
    {
        #region
        private readonly static DetalleAlquilerServicio _instance = new DetalleAlquilerServicio();
        public static DetalleAlquilerServicio Instance { get { return _instance; } }
        private DetalleAlquilerServicio()
        {
        }
        #endregion
        public void Eliminar(DAlquiler obj)
        {
            throw new NotImplementedException();
        }

        public void Insertar(DAlquiler obj)
        {
            try
            {
                using (base_sigalEntities db = new base_sigalEntities())
                {
                    //ejemplo int idAutor = db.Autor.Max(e => e.ID_AUTOR);
                    //buscar id pago
                    int ulti = db.Pago.Max(x => x.ID_PAGO);

                    //fecha inicio, fecha fin, estado
                    DAlquiler d = new DAlquiler()
                    {
                        FECHA_FIN = obj.FECHA_FIN,
                        FECHA_INICIO = obj.FECHA_INICIO,
                        ID_PAGO = ulti,
                        ID_LIBRO = obj.ID_LIBRO,
                        ESTADO = obj.ESTADO
                    };
                    db.DAlquiler.Add(d);
                    db.SaveChanges();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Modificar(DAlquiler obj)
        {
            try
            {
                //modifico el estado del detalle de alquiler
                using (base_sigalEntities db = new base_sigalEntities())
                {
                    // Libro lib = db.Libro.Where(x => x.TITULO_LIBRO == obj.TITULO_LIBRO).First();

                    DAlquiler al = db.DAlquiler.Where(x => x.ID_DETALLE_ALQUILER == obj.ID_DETALLE_ALQUILER && x.ID_LIBRO == obj.ID_LIBRO).First();

                    if (al.ESTADO == "PENDIENTE")
                    {
                        al.ESTADO = "FINALIZADO";
                        db.Entry(al).State = System.Data.Entity.EntityState.Modified;
                        db.SaveChanges();
                    }
                    else if (al.ESTADO == "Finalizado")
                    {
                        throw new AlquilerFinalizado();
                    }
                }
            }
            catch (AlquilerFinalizado ex)
            {//Manejador
                ex.Handle(this);
                throw ex;
            }
            catch (Exception ex)
            {
                ex.Handle(this);
                throw;
            }
        }

        public DAlquiler Obtener(DAlquiler obj)
        {
            throw new NotImplementedException();
        }


        public List<DAlquiler> ListaAlquilerMs()
        {
            using (base_sigalEntities db = new base_sigalEntities())
            {
                //  vj
                //var permisos = db.DAlquiler
                //.SqlQuery($"SELECT * FROM DAlquiler WHERE MONTH(FECHA_INICIO) = MONTH(GETDATE())")
                //.ToList();
                //return permisos;
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


        public IEnumerable<DAlquiler> ObtenerTodo()
        {
            try
            { //Llamar a vista de alquiler_mes
                /*using (base_sigalEntities db = new base_sigalEntities())
                {
                    
                    return db.DAlquiler.Where(da => da.ESTADO == "PENDIENTE").ToList();
                }*/
                using (base_sigalEntities db = new base_sigalEntities())
                {


                    return db.DAlquiler.Where(da => da.ESTADO == "PENDIENTE").ToList();
                }
            }
            catch (Exception ex)
            {
                ex.Handle(this);
                return null;
            }
        }
    }
}

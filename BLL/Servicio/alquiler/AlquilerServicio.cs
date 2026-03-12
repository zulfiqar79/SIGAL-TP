//using BLL.Contrato;
//using DAL.DAO;
//using SL.Servicios.Extension;
//using System;
//using System.Collections.Generic;
//using System.Data.Common;
//using System.Data.Entity;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace BLL.Servicio.alquiler
//{
//    public sealed class AlquilerServicio : IGeneralServicio<Alquiler>
//    {
//        #region
//        private readonly static AlquilerServicio _instance = new AlquilerServicio();
//        public static AlquilerServicio Instance { get { return _instance; } }
//        private AlquilerServicio()
//        {
//        }
//        #endregion
//        public void Insertar(Alquiler obj)
//        {
//            //insertar observaciones cliente y d alquiler
//            try
//            {
//                using (base_sigalEntities db = new base_sigalEntities())
//                {
//                    //bucar DAlquiler
//                    int idDetAlquiler = db.DAlquiler.Max(e => e.ID_DETALLE_ALQUILER);
//                    Alquiler a = new Alquiler()
//                    {
//                        ID_DETALLE_ALQUILER = idDetAlquiler,
//                        ID_CLIENTE = obj.ID_CLIENTE,
//                        OBSERVACIONES = obj.OBSERVACIONES
//                    };
//                    db.Alquiler.Add(a);
//                    db.SaveChanges();
//                }
//            }
//            catch (Exception ex)
//            {  //Llamo al manejador
//                ex.Handle(this);
//            }
//        }

//        public void Eliminar(Alquiler obj)
//        {
//            throw new NotImplementedException();
//        }

//        public void Modificar(Alquiler obj)
//        {
//            throw new NotImplementedException();
//        }

//        public Alquiler Obtener(Alquiler obj)
//        {
//            try
//            {                
//                using (base_sigalEntities db = new base_sigalEntities())
//                {
//                    //bucar ultimo alquiler registrado
//                    Alquiler alquiler = db.Alquiler.OrderByDescending(a => a.ID_ALQUILER).FirstOrDefault();
//                    return alquiler;
//                }                
//            }            
//            catch (Exception ex)
//            {
//                ex.Handle(this);
//                return null;
//            }
//        }

//        public IEnumerable<Alquiler> ObtenerTodo()
//        {
//            try
//            { //Llamar a vista de alquiler_mes
//                using (base_sigalEntities db = new base_sigalEntities())
//                {
//                    var alquileresPendientes = db.DAlquiler
//                                       .Where(da => da.ESTADO == "PENDIENTE")
//                                       .Include(x => x.Alquiler)
//                                       .ToList();
//                    return null;
//                }
//            }
//            catch (Exception ex)
//            {
//                ex.Handle(this);
//                return null;
//            }
//        }


//    }
//}

using DAL.AccesoDatos.alquiler;
using DAL.DAO;
using SL.BLL.Contrato;
using SL.Servicios.Extension;
using System;
using System.Collections.Generic;

namespace BLL.Servicio.alquiler
{
    public sealed class AlquilerServicio : IGeneralServicio<Alquiler>
    {
        #region
        private readonly static AlquilerServicio _instance = new AlquilerServicio();
        public static AlquilerServicio Instance { get { return _instance; } }
        private AlquilerServicio()
        {
        }
        #endregion

        public void Insertar(Alquiler obj)
        {
            try
            {
                int idDetAlquiler = AlquilerDAL.Instance.ObtenerUltimoIdDetalleAlquiler();

                Alquiler alquiler = new Alquiler()
                {
                    ID_DETALLE_ALQUILER = idDetAlquiler,
                    ID_CLIENTE = obj.ID_CLIENTE,
                    OBSERVACIONES = obj.OBSERVACIONES
                };

                AlquilerDAL.Instance.Insertar(alquiler);
            }
            catch (Exception ex)
            {
                ex.Handle(this);
                throw;
            }
        }

        public void Eliminar(Alquiler obj)
        {
            throw new NotImplementedException();
        }

        public void Modificar(Alquiler obj)
        {
            throw new NotImplementedException();
        }

        public Alquiler Obtener(Alquiler obj)
        {
            try
            {
                return AlquilerDAL.Instance.ObtenerUltimoAlquiler();
            }
            catch (Exception ex)
            {
                ex.Handle(this);
                throw;
            }
        }

        public IEnumerable<Alquiler> ObtenerTodo()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<DAlquiler> ObtenerPendientesConAlquiler()
        {
            try
            {
                return AlquilerDAL.Instance.ObtenerPendientesConAlquiler();
            }
            catch (Exception ex)
            {
                ex.Handle(this);
                throw;
            }
        }
    }
}
using DAL.AccesoDatos.alquiler;
using DAL.DAO;
using SL.BLL.Contrato;
using SL.BLL.ExcepcionBLL;
using SL.Servicios.Extension;
using System;
using System.Collections.Generic;

namespace BLL.Servicio.alquiler
{
    public sealed class DetalleAlquilerBLL : IGeneralServicio<DAlquiler>
    {
        #region
        private readonly static DetalleAlquilerBLL _instance = new DetalleAlquilerBLL();
        public static DetalleAlquilerBLL Instance { get { return _instance; } }
        private DetalleAlquilerBLL()
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
                int ultimoIdPago = DetalleAlquilerDAL.Instance.ObtenerUltimoIdPago();

                DAlquiler detalle = new DAlquiler()
                {
                    FECHA_FIN = obj.FECHA_FIN,
                    FECHA_INICIO = obj.FECHA_INICIO,
                    ID_PAGO = ultimoIdPago,
                    ID_LIBRO = obj.ID_LIBRO,
                    ESTADO = obj.ESTADO
                };

                DetalleAlquilerDAL.Instance.Insertar(detalle);
            }
            catch (Exception ex)
            {
                ex.Handle(this);
                throw;
            }
        }

        public void Modificar(DAlquiler obj)
        {
            try
            {
                DAlquiler al = DetalleAlquilerDAL.Instance.ObtenerPorIdDetalleYLibro(obj.ID_DETALLE_ALQUILER, (int)obj.ID_LIBRO);

                if (al == null)
                {
                    return;
                }

                if (al.ESTADO == "PENDIENTE")
                {
                    al.ESTADO = "FINALIZADO";
                    DetalleAlquilerDAL.Instance.Modificar(al);
                }
                else if (al.ESTADO == "FINALIZADO" || al.ESTADO == "Finalizado")
                {
                    throw new AlquilerFinalizado();
                }
            }
            catch (AlquilerFinalizado ex)
            {
                ex.Handle(this);
                throw;
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
            try
            {
                return DetalleAlquilerDAL.Instance.ListaAlquilerMesActual();
            }
            catch (Exception ex)
            {
                ex.Handle(this);
                throw;
            }
        }

        public IEnumerable<DAlquiler> ObtenerTodo()
        {
            try
            {
                return DetalleAlquilerDAL.Instance.ObtenerPendientes();
            }
            catch (Exception ex)
            {
                ex.Handle(this);
                throw;
            }
        }
    }
}

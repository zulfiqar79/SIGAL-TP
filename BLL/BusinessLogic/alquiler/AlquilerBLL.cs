using DAL.AccesoDatos.alquiler;
using Domain;
using SL.BLL.Contrato;
using SL.Servicios.Extension;
using System;
using System.Collections.Generic;

namespace BLL.Servicio.alquiler
{
    public sealed class AlquilerBLL : IGeneralServicio<Alquiler>
    {
        #region
        private readonly static AlquilerBLL _instance = new AlquilerBLL();
        public static AlquilerBLL Instance { get { return _instance; } }
        private AlquilerBLL()
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
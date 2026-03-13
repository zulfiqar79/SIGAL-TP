using DAL.AccesoDatos.alquiler;
using Domain;
using SL.BLL.Contrato;
using SL.Servicios.Extension;
using System;
using System.Collections.Generic;

namespace BLL.Servicio.alquiler
{
    public sealed class PagoBLL : IGeneralServicio<Pago>
    {
        #region
        private readonly static PagoBLL _instance = new PagoBLL();
        public static PagoBLL Instance { get { return _instance; } }
        private PagoBLL()
        {
        }
        #endregion

        public void Eliminar(Pago obj)
        {
            throw new NotImplementedException();
        }

        public void Insertar(Pago obj)
        {
            try
            {
                // acá después podés agregar validaciones de negocio
                // por ejemplo validar monto, fecha, etc.

                PagoDAL.Instance.Insertar(obj);
            }
            catch (Exception ex)
            {
                ex.Handle(this);
                throw;
            }
        }

        public void Modificar(Pago obj)
        {
            throw new NotImplementedException();
        }

        public Pago Obtener(Pago obj)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Pago> ObtenerTodo()
        {
            throw new NotImplementedException();
        }
    }
}
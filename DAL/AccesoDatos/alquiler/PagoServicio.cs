using DAL.DAO;
using SL.BLL.Contrato;
using SL.Servicios.Extension;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.AccesoDatos.alquiler
{
    public sealed class PagoServicio : IGeneralServicio<Pago>
    {
        #region
        private readonly static PagoServicio _instance = new PagoServicio();
        public static PagoServicio Instance { get { return _instance; } }
        private PagoServicio()
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
                using (base_sigalEntities db = new base_sigalEntities())
                {//fecha y monto
                    db.Pago.Add(obj);
                    db.SaveChanges();
                }
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

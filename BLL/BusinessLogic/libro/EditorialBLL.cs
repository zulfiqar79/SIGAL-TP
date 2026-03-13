using DAL.AccesoDatos.libro;
using DAL.DAO;
using SL.BLL.Contrato;
using SL.BLL.ExcepcionBLL;
using SL.Servicios.Extension;
using System;
using System.Collections.Generic;

namespace BLL.Servicio.libro
{
    public sealed class EditorialBLL : IGeneralServicio<Editorial>
    {
        #region Singleton
        private readonly static EditorialBLL _instance = new EditorialBLL();
        public static EditorialBLL Instance { get { return _instance; } }
        private EditorialBLL()
        {
        }
        #endregion

        public void Eliminar(Editorial obj)
        {
            throw new NotImplementedException();
        }

        public void Insertar(Editorial obj)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(obj.NOMBRE_EDITORIAL) || string.IsNullOrWhiteSpace(obj.PAIS))
                {
                    throw new DatosFaltantes();
                }

                EditorialDAL.Instance.Insertar(obj);
            }
            catch (DatosFaltantes ex)
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

        public void Modificar(Editorial obj)
        {
            throw new NotImplementedException();
        }

        public Editorial Obtener(Editorial obj)
        {
            try
            {
                Editorial ed = EditorialDAL.Instance.Obtener(obj);

                if (ed == null)
                {
                    throw new EditorialInexistente();
                }

                return ed;
            }
            catch (EditorialInexistente ex)
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

        public IEnumerable<Editorial> ObtenerTodo()
        {
            try
            {
                return EditorialDAL.Instance.ObtenerTodo();
            }
            catch (Exception ex)
            {
                ex.Handle(this);
                throw;
            }
        }
    }
}
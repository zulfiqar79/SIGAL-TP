using DAL.AccesoDatos.libro;
using Domain;
using SL.BLL.Contrato;
using SL.BLL.ExcepcionBLL;
using SL.Servicios.Extension;
using System;
using System.Collections.Generic;

namespace BLL.Servicio.libro
{
    public sealed class AutorBLL : IGeneralServicio<Autor>
    {
        #region Singleton
        private readonly static AutorBLL _instance = new AutorBLL();
        public static AutorBLL Instance { get { return _instance; } }
        private AutorBLL()
        {
        }
        #endregion

        public void Eliminar(Autor obj)
        {
            throw new NotImplementedException();
        }

        public void Insertar(Autor obj)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(obj.NOMBRE_AUTOR) || string.IsNullOrWhiteSpace(obj.APELLIDO_AUTOR))
                {
                    throw new DatosFaltantes();
                }

                AutorDAL.Instance.Insertar(obj);
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

        public void Modificar(Autor obj)
        {
            throw new NotImplementedException();
        }

        public Autor Obtener(Autor obj)
        {
            try
            {
                Autor aut = AutorDAL.Instance.Obtener(obj);

                if (aut == null)
                {
                    throw new AutorInexistente();
                }

                return aut;
            }
            catch (AutorInexistente ex)
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

        public IEnumerable<Autor> ObtenerTodo()
        {
            try
            {
                return AutorDAL.Instance.ObtenerTodo();
            }
            catch (Exception ex)
            {
                ex.Handle(this);
                throw;
            }
        }
    }
}

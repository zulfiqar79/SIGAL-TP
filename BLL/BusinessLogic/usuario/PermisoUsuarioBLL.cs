using DAL.AccesoDatos.usuario;
using DAL.DAO;
using SL.BLL.Contrato;
using SL.BLL.ExcepcionBLL;
using SL.Servicios.Extension;
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace BLL.Servicio.usuario
{
    public sealed class PermisoUsuarioBLL : IGeneralServicio<UsuarioPermiso>
    {
        #region
        private readonly static PermisoUsuarioBLL _instance = new PermisoUsuarioBLL();
        public static PermisoUsuarioBLL Instance { get { return _instance; } }
        private PermisoUsuarioBLL()
        {
        }
        #endregion

        public BindingList<UsuarioPermiso> lista;

        public void Insertar(UsuarioPermiso obj)
        {
            try
            {
                PermisoUsuarioDAL.Instance.Insertar(obj);
            }
            catch (Exception ex)
            {
                ex.Handle(this);
                throw;
            }
        }

        public void Eliminar(UsuarioPermiso obj)
        {
            try
            {
                List<UsuarioPermiso> permisos = PermisoUsuarioDAL.Instance.ObtenerPermisosPorUsuario(obj.ID_USUARIO);

                if (permisos == null || permisos.Count == 0)
                {
                    throw new UsuarioInexistente();
                }

                PermisoUsuarioDAL.Instance.EliminarPermisosPorUsuario(obj.ID_USUARIO);
            }
            catch (Exception ex)
            {
                ex.Handle(this);
                throw;
            }
        }

        public void Modificar(UsuarioPermiso obj)
        {
            throw new NotImplementedException();
        }

        public UsuarioPermiso Obtener(UsuarioPermiso obj)
        {
            throw new Exception();
        }

        public List<UsuarioPermiso> ListaDePermisos(UsuarioPermiso obj)
        {
            try
            {
                return PermisoUsuarioDAL.Instance.ObtenerPermisosPorUsuario(obj.ID_USUARIO);
            }
            catch (Exception ex)
            {
                ex.Handle(this);
                throw;
            }
        }

        public IEnumerable<UsuarioPermiso> ObtenerTodo()
        {
            throw new NotImplementedException();
        }
    }
}
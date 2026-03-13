using BLL.BusinessLogic.usuario;
using DAL.AccesoDatos.usuario;
using Domain;
using Domain.Composite;
using SL.BLL.Contrato;
using SL.BLL.ExcepcionBLL;
using SL.Servicios.Extension;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

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

        /// <summary>
        /// Asigna los permisos de un componente (Patente o Familia) a un usuario,
        /// reemplazando cualquier permiso previo.
        /// Utiliza el patrón Composite: acepta tanto una Patente individual
        /// como una FamiliaPermiso con múltiples patentes.
        /// Si el usuario no tiene permisos previos, el paso de eliminación es un no-op.
        /// </summary>
        public void AsignarPermisos(int idUsuario, IComponentePermiso componente, string userCreacion)
        {
            try
            {
                // Eliminar permisos anteriores (sin lanzar excepción si no existen)
                PermisoUsuarioDAL.Instance.EliminarPermisosPorUsuario(idUsuario);

                // Insertar todos los IDs que componen el componente
                foreach (int idPermiso in componente.ObtenerIds())
                {
                    PermisoUsuarioDAL.Instance.Insertar(new UsuarioPermiso
                    {
                        ID_USUARIO = idUsuario,
                        ID_PERMISO = idPermiso,
                        USER_CREACION = userCreacion
                    });
                }
            }
            catch (Exception ex)
            {
                ex.Handle(this);
                throw;
            }
        }

        /// <summary>
        /// Verifica si un usuario posee el permiso con el nombre dado,
        /// resolviendo a través del CatalogoPermisos (Patentes individuales).
        /// </summary>
        public bool TienePermiso(int idUsuario, string nombrePermiso)
        {
            try
            {
                List<UsuarioPermiso> permisos = PermisoUsuarioDAL.Instance.ObtenerPermisosPorUsuario(idUsuario);
                return permisos
                    .Select(p => CatalogoPermisos.ObtenerPatente(p.ID_PERMISO))
                    .Where(p => p != null)
                    .Any(p => p.TienePermiso(nombrePermiso));
            }
            catch (Exception ex)
            {
                ex.Handle(this);
                throw;
            }
        }
    }
}
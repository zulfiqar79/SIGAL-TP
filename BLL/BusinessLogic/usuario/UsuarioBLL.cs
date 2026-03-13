using DAL.AccesoDatos.usuario;
using DAL.DAO;
using SL.BLL.Contrato;
using SL.BLL.ExcepcionBLL;
using SL.Servicios.Extension;
using System;
using System.Collections.Generic;

namespace BLL.Servicio.usuario
{
    public sealed class UsuarioBLL : IGeneralServicio<Usuario>
    {
        #region
        private readonly static UsuarioBLL _instance = new UsuarioBLL();
        public static UsuarioBLL Instance { get { return _instance; } }
        private UsuarioBLL()
        {
        }
        #endregion

        private void ValidarDatosUsuario(Usuario obj)
        {
            if (string.IsNullOrWhiteSpace(obj.USUARIO1) || string.IsNullOrWhiteSpace(obj.CONTRA))
            {
                throw new DatosFaltantes();
            }
        }

        public void Insertar(Usuario obj)
        {
            try
            {
                ValidarDatosUsuario(obj);

                UsuarioDAL.Instance.Insertar(obj);
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

        public void Eliminar(Usuario us)
        {
            throw new NotImplementedException();
        }

        public void Modificar(Usuario obj)
        {
            throw new NotImplementedException();
        }

        public Usuario ObtenerUsuarioPermiso(Usuario obj)
        {
            try
            {
                Usuario usuarioBuscado = UsuarioDAL.Instance.ObtenerPorNombreUsuario(obj.USUARIO1);

                if (usuarioBuscado != null)
                {
                    return usuarioBuscado;
                }

                throw new UsuarioInexistente();
            }
            catch (UsuarioInexistente ex)
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

        public Usuario Obtener(Usuario obj)
        {
            try
            {
                ValidarDatosUsuario(obj);

                Usuario usuarioBuscado = UsuarioDAL.Instance.ObtenerPorUsuarioYContrasena(obj.USUARIO1, obj.CONTRA);

                if (usuarioBuscado != null)
                {
                    return usuarioBuscado;
                }

                throw new AccesoDenegadoExcepcion();
            }
            catch (DatosFaltantes ex)
            {
                ex.Handle(this);
                throw;
            }
            catch (AccesoDenegadoExcepcion ex)
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

        public IEnumerable<Usuario> ObtenerTodo()
        {
            throw new NotImplementedException();
        }
    }
}

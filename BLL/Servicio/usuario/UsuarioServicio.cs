//using BLL.Contrato;
//using BLL.Excepcion;
//using DAL.DAO;
//using SL.Servicios.Extension;
//using System;
//using System.CodeDom;
//using System.Collections.Generic;
//using System.Data.Entity;
//using System.Linq;
//using System.Runtime.Remoting.Contexts;
//using System.Text;
//using System.Threading.Tasks;

//namespace BLL.Servicio.usuario
//{
//    public sealed class UsuarioServicio : IGeneralServicio<Usuario>
//    {
//        #region
//        private readonly static UsuarioServicio _instance = new UsuarioServicio();
//        public static UsuarioServicio Instance { get { return _instance; } }
//        private UsuarioServicio()
//        {
//        }
//        #endregion
//        public void Insertar(Usuario obj)
//        {
//            try
//            {
//                using (base_sigalEntities db = new base_sigalEntities())
//                { //evalua si esta completo
//                    if (obj.USUARIO1 == "" || obj.CONTRA == "")
//                    {
//                        throw new DatosFaltantes();
//                    }

//                    //falta reglas de tipo de usuario ej: sig_joh
//                    //

//                    db.Usuario.Add(obj); //agrego
//                    db.SaveChanges(); //inserto en base de datos
//                }
//            }
//            catch (DatosFaltantes ex)
//            {
//                ex.Handle(this);
//                throw ex;
//            }
//        }

//        public void Eliminar(Usuario us)
//        {
//            throw new NotImplementedException();
//        }

//        public void Modificar(Usuario obj)
//        {
//            throw new NotImplementedException();
//        }
//        public Usuario ObtenerUsuarioPermiso(Usuario obj)
//        {
//            try
//            {
//                using (base_sigalEntities db = new base_sigalEntities())
//                {
//                    /*buscar
//                    Usuario validarUsuario = db.Usuario.Where(x => x.USUARIO1 == obj.USUARIO1).First(); obtener el primero*/

//                    //con any, valido si existe el usuario bool existeUsuario = contexto.TuTablaDeUsuarios.Any(u => u.NombreUsuario == nombreUsuario);

//                    var usuarioBuscado = db.Usuario.FirstOrDefault(x => x.USUARIO1 == obj.USUARIO1);

//                    if (usuarioBuscado != null)
//                    {
//                        return usuarioBuscado;
//                    }
//                    if (usuarioBuscado == null)
//                    {
//                        throw new UsuarioInexistente();
//                    }
//                }
//                return null;
//            }
//            catch (UsuarioInexistente ex)
//            {
//                ex.Handle(this);
//                throw ex;
//            }
//        }

//        public Usuario Obtener(Usuario obj)
//        {
//            try
//            {
//                using (base_sigalEntities db = new base_sigalEntities())
//                {
//                    /*buscar
//                    Usuario validarUsuario = db.Usuario.Where(x => x.USUARIO1 == obj.USUARIO1).First(); obtener el primero*/

//                    //con any, valido si existe el usuario bool existeUsuario = contexto.TuTablaDeUsuarios.Any(u => u.NombreUsuario == nombreUsuario);

//                    var usuarioBuscado = db.Usuario.FirstOrDefault(x => x.USUARIO1 == obj.USUARIO1 && x.CONTRA == x.CONTRA);

//                    if (usuarioBuscado != null)
//                    {
//                        if(usuarioBuscado.CONTRA == obj.CONTRA)
//                        {
//                            return usuarioBuscado;
//                        }
//                        throw new AccesoDenegadoExcepcion();
//                    }
//                    if (usuarioBuscado == null)
//                    {
//                        throw new AccesoDenegadoExcepcion();
//                    }
//                }
//                return null;
//            }
//            catch (AccesoDenegadoExcepcion ex)
//            {
//                ex.Handle(this);
//                throw ex;
//            }
//        }

//        public IEnumerable<Usuario> ObtenerTodo()
//        {
//            throw new NotImplementedException();
//        }
//    }
//}

using DAL.AccesoDatos.usuario;
using DAL.DAO;
using SL.BLL.Contrato;
using SL.BLL.ExcepcionBLL;
using SL.Servicios.Extension;
using System;
using System.Collections.Generic;

namespace BLL.Servicio.usuario
{
    public sealed class UsuarioServicio : IGeneralServicio<Usuario>
    {
        #region
        private readonly static UsuarioServicio _instance = new UsuarioServicio();
        public static UsuarioServicio Instance { get { return _instance; } }
        private UsuarioServicio()
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

//using BLL.Contrato;
//using BLL.Excepcion;
//using DAL.DAO;
//using SL.Servicios.Extension;
//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data.Entity;
//using System.Linq;
//using System.Security.Cryptography.X509Certificates;
//using System.Text;
//using System.Threading.Tasks;

//namespace BLL.Servicio.usuario
//{
//    public class PermisoUsuarioServicio : IGeneralServicio<UsuarioPermiso>
//    {
//        #region
//        private readonly static PermisoUsuarioServicio _instance = new PermisoUsuarioServicio();
//        public static PermisoUsuarioServicio Instance { get { return _instance; } }
//        private PermisoUsuarioServicio()
//        {
//        }
//        #endregion
//        public void Eliminar(UsuarioPermiso obj)
//        {
//            try
//            {
//                using (base_sigalEntities db = new base_sigalEntities())
//                {
//                    var permisos = db.UsuarioPermiso
//                        .Where(x => x.ID_USUARIO == obj.ID_USUARIO)
//                        .ToList();

//                    if (permisos.Any())
//                    {
//                        db.UsuarioPermiso.RemoveRange(permisos);
//                        db.SaveChanges();
//                    }
//                    else
//                    {
//                        throw new UsuarioInexistente();
//                    }                  
//                }
//            }
//            catch (Exception ex)
//            {
//                ex.Handle(this);
//                throw;
//            }
//        }

//        public void Insertar(UsuarioPermiso obj)
//        {
//            try
//            {
//                using (base_sigalEntities db = new base_sigalEntities())
//                {
//                    UsuarioPermiso usuario = new UsuarioPermiso()
//                    {
//                        ID_USUARIO = obj.ID_USUARIO,
//                        ID_PERMISO=obj.ID_PERMISO,
//                        FECHA_CREACION=DateTime.Now,
//                        USER_CREACION = obj.USER_CREACION,
//                    };
//                    db.UsuarioPermiso.Add(usuario);
//                    db.SaveChanges();
//                }
//            }
//            catch (Exception ex)
//            {
//                ex.Handle(this);
//                throw;
//            }
//        }

//        public void Modificar(UsuarioPermiso obj)
//        {
//            throw new NotImplementedException();
//        }
//        public BindingList<UsuarioPermiso> lista;
//        public UsuarioPermiso Obtener(UsuarioPermiso obj)
//        {
//            throw new Exception();
//        }
//        public List<UsuarioPermiso> ListaDePermisos (UsuarioPermiso obj)
//        {
//            try
//            {
//                using (base_sigalEntities db = new base_sigalEntities())
//                {
//                    var permisos = db.UsuarioPermiso
//                        .Where(x => x.ID_USUARIO == obj.ID_USUARIO)
//                        .ToList();

//                    return permisos;
//                }
//            }
//            catch (Exception ex)
//            {
//                ex.Handle(this);
//                throw;
//            }           
//        }


//        public IEnumerable<UsuarioPermiso> ObtenerTodo()
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
using System.ComponentModel;

namespace BLL.Servicio.usuario
{
    public sealed class PermisoUsuarioServicio : IGeneralServicio<UsuarioPermiso>
    {
        #region
        private readonly static PermisoUsuarioServicio _instance = new PermisoUsuarioServicio();
        public static PermisoUsuarioServicio Instance { get { return _instance; } }
        private PermisoUsuarioServicio()
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
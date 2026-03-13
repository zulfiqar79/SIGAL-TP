using DAL.DAO;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DAL.AccesoDatos.usuario
{
    public sealed class PermisoUsuarioDAL
    {
        #region
        private readonly static PermisoUsuarioDAL _instance = new PermisoUsuarioDAL();
        public static PermisoUsuarioDAL Instance { get { return _instance; } }
        private PermisoUsuarioDAL()
        {
        }
        #endregion

        public void Insertar(UsuarioPermiso obj)
        {
            using (base_sigalEntities db = new base_sigalEntities())
            {
                UsuarioPermiso usuarioPermiso = new UsuarioPermiso()
                {
                    ID_USUARIO = obj.ID_USUARIO,
                    ID_PERMISO = obj.ID_PERMISO,
                    FECHA_CREACION = DateTime.Now,
                    USER_CREACION = obj.USER_CREACION,
                };

                db.UsuarioPermiso.Add(usuarioPermiso);
                db.SaveChanges();
            }
        }

        public List<UsuarioPermiso> ObtenerPermisosPorUsuario(int idUsuario)
        {
            using (base_sigalEntities db = new base_sigalEntities())
            {
                return db.UsuarioPermiso
                    .Where(x => x.ID_USUARIO == idUsuario)
                    .ToList();
            }
        }

        public void EliminarPermisosPorUsuario(int idUsuario)
        {
            using (base_sigalEntities db = new base_sigalEntities())
            {
                var permisos = db.UsuarioPermiso
                    .Where(x => x.ID_USUARIO == idUsuario)
                    .ToList();

                if (permisos.Any())
                {
                    db.UsuarioPermiso.RemoveRange(permisos);
                    db.SaveChanges();
                }
            }
        }
    }
}
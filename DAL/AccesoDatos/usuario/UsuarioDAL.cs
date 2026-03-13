using DAL.DAO;
using Domain;
using System.Linq;

namespace DAL.AccesoDatos.usuario
{
    public sealed class UsuarioDAL
    {
        #region
        private readonly static UsuarioDAL _instance = new UsuarioDAL();
        public static UsuarioDAL Instance { get { return _instance; } }
        private UsuarioDAL()
        {
        }
        #endregion

        public void Insertar(Usuario obj)
        {
            using (base_sigalEntities db = new base_sigalEntities())
            {
                db.Usuario.Add(obj);
                db.SaveChanges();
            }
        }

        public Usuario ObtenerPorNombreUsuario(string nombreUsuario)
        {
            using (base_sigalEntities db = new base_sigalEntities())
            {
                return db.Usuario.FirstOrDefault(x => x.USUARIO1 == nombreUsuario);
            }
        }

        public Usuario ObtenerPorUsuarioYContrasena(string nombreUsuario, string contrasena)
        {
            using (base_sigalEntities db = new base_sigalEntities())
            {
                return db.Usuario.FirstOrDefault(x => x.USUARIO1 == nombreUsuario && x.CONTRA == contrasena);
            }
        }
    }
}
using DAL.DAO;
using Domain;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace DAL.AccesoDatos.cliente
{
    public sealed class ClienteDAL
    {
        #region
        private readonly static ClienteDAL _instance = new ClienteDAL();
        public static ClienteDAL Instance { get { return _instance; } }
        private ClienteDAL()
        {
        }
        #endregion

        public void Insertar(Cliente obj)
        {
            using (base_sigalEntities db = new base_sigalEntities())
            {
                db.Cliente.Add(obj);
                db.SaveChanges();
            }
        }

        public Cliente ObtenerPorCorreo(string correo)
        {
            using (base_sigalEntities db = new base_sigalEntities())
            {
                return db.Cliente.FirstOrDefault(x => x.CORREO_CLIENTE == correo);
            }
        }

        public void Eliminar(Cliente cliente)
        {
            using (base_sigalEntities db = new base_sigalEntities())
            {
                db.Cliente.Attach(cliente);
                db.Cliente.Remove(cliente);
                db.SaveChanges();
            }
        }

        public IEnumerable<Cliente> ObtenerTodo()
        {
            using (base_sigalEntities db = new base_sigalEntities())
            {
                return db.Cliente.Include(x => x.Alquiler).ToList();
            }
        }
    }
}
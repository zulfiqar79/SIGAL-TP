//using BLL.Contrato;
//using BLL.Excepcion;
//using DAL.DAO;
//using SL.Servicios.Extension;
//using System;
//using System.Collections.Generic;
//using System.ComponentModel.DataAnnotations;
//using System.Data.Entity;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace BLL.Servicio.cliente
//{
//    public sealed class ClienteServicio : IGeneralServicio<Cliente>
//    {
//        #region
//        private readonly static ClienteServicio _instance = new ClienteServicio();
//        public static ClienteServicio Instance { get { return _instance; } }
//        private ClienteServicio()
//        {
//        }

//        public void Insertar(Cliente obj)
//        {
//            try
//            {
//                //validar que correo no exista
//                using (base_sigalEntities db = new base_sigalEntities())
//                {
//                    db.Cliente.Add(obj);
//                    db.SaveChanges();
//                }
//            }
//            catch (Exception ex)
//            {
//                ex.Handle(this);
//                throw;
//            }
//        }

//        public void Eliminar(Cliente obj)
//        {
//            try
//            {
//                using (base_sigalEntities db = new base_sigalEntities())
//                {
//                    var clienteBuscado = db.Cliente.FirstOrDefault(x => x.CORREO_CLIENTE == obj.CORREO_CLIENTE);
//                    //por id x.ID_CLIENTE == obj.ID_CLIENTE &&
//                    if (clienteBuscado != null)
//                    {
//                        db.Cliente.Remove(clienteBuscado);
//                        db.SaveChanges();
//                    }
//                    if (clienteBuscado == null)
//                    {
//                        throw new ClienteInexistente();
//                    }
//                }
//            }
//            catch (ClienteInexistente ex)
//            {
//                ex.Handle(this);
//                throw ex;
//            }
//            catch (Exception ex)
//            {
//                ex.Handle(this);
//                throw;
//            }
//        }

//        public void Modificar(Cliente obj)
//        {
//            throw new NotImplementedException();
//        }

//        public Cliente Obtener(Cliente obj)
//        {
//            try
//            {
//                using (base_sigalEntities db = new base_sigalEntities())
//                { //busca el cliente
//                    Cliente clien = db.Cliente.Where(x => x.CORREO_CLIENTE == obj.CORREO_CLIENTE).First();
//                    return clien;
//                }
//            }
//            catch (Exception ex)
//            {
//                ex.Handle(this);
//                throw;
//            }
//        }

//        public IEnumerable<Cliente> ObtenerTodo()
//        {
//            try
//            {
//                using (base_sigalEntities db = new base_sigalEntities())
//                {

//                    return db.Cliente.Include(x => x.Alquiler).ToList();

//                }
//                //log

//            }
//            catch (Exception ex)
//            {
//                ex.Handle(this);
//                throw;
//            }
//        }
//        #endregion

//    }
//}

using DAL.AccesoDatos.cliente;
using DAL.DAO;
using SL.BLL.Contrato;
using SL.BLL.ExcepcionBLL;
using SL.Servicios.Extension;
using System;
using System.Collections.Generic;

namespace BLL.Servicio.cliente
{
    public sealed class ClienteServicio : IGeneralServicio<Cliente>
    {
        #region
        private readonly static ClienteServicio _instance = new ClienteServicio();
        public static ClienteServicio Instance { get { return _instance; } }
        private ClienteServicio()
        {
        }
        #endregion

        public void Insertar(Cliente obj)
        {
            try
            {
                // acá después podés agregar validaciones
                // por ejemplo validar que el correo no exista

                ClienteDAL.Instance.Insertar(obj);
            }
            catch (Exception ex)
            {
                ex.Handle(this);
                throw;
            }
        }

        public void Eliminar(Cliente obj)
        {
            try
            {
                Cliente clienteBuscado = ClienteDAL.Instance.ObtenerPorCorreo(obj.CORREO_CLIENTE);

                if (clienteBuscado != null)
                {
                    ClienteDAL.Instance.Eliminar(clienteBuscado);
                    return;
                }

                throw new ClienteInexistente();
            }
            catch (ClienteInexistente ex)
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

        public void Modificar(Cliente obj)
        {
            throw new NotImplementedException();
        }

        public Cliente Obtener(Cliente obj)
        {
            try
            {
                Cliente clien = ClienteDAL.Instance.ObtenerPorCorreo(obj.CORREO_CLIENTE);

                if (clien == null)
                {
                    throw new ClienteInexistente();
                }

                return clien;
            }
            catch (ClienteInexistente ex)
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

        public IEnumerable<Cliente> ObtenerTodo()
        {
            try
            {
                return ClienteDAL.Instance.ObtenerTodo();
            }
            catch (Exception ex)
            {
                ex.Handle(this);
                throw;
            }
        }
    }
}

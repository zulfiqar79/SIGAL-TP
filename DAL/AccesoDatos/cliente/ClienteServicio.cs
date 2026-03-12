using DAL.DAO;
using SL.BLL.Contrato;
using SL.BLL.ExcepcionBLL;
using SL.Servicios.Extension;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.AccesoDatos.cliente
{
    public sealed class ClienteServicio : IGeneralServicio<Cliente>
    {
        #region
        private readonly static ClienteServicio _instance = new ClienteServicio();
        public static ClienteServicio Instance { get { return _instance; } }
        private ClienteServicio()
        {
        }

        public void Insertar(Cliente obj)
        {
            try
            {
                //validar que correo no exista
                using (base_sigalEntities db = new base_sigalEntities())
                {
                    db.Cliente.Add(obj);
                    db.SaveChanges();
                }
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
                using (base_sigalEntities db = new base_sigalEntities())
                {
                    var clienteBuscado = db.Cliente.FirstOrDefault(x => x.CORREO_CLIENTE == obj.CORREO_CLIENTE);
                    //por id x.ID_CLIENTE == obj.ID_CLIENTE &&
                    if (clienteBuscado != null)
                    {
                        db.Cliente.Remove(clienteBuscado);
                        db.SaveChanges();
                    }
                    if (clienteBuscado == null)
                    {
                        throw new ClienteInexistente();
                    }
                }
            }
            catch (ClienteInexistente ex)
            {
                ex.Handle(this);
                throw ex;
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
                using (base_sigalEntities db = new base_sigalEntities())
                { //busca el cliente
                    Cliente clien = db.Cliente.Where(x => x.CORREO_CLIENTE == obj.CORREO_CLIENTE).First();
                    return clien;
                }
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
                using (base_sigalEntities db = new base_sigalEntities())
                {

                    return db.Cliente.Include(x => x.Alquiler).ToList();

                }
                //log

            }
            catch (Exception ex)
            {
                ex.Handle(this);
                throw;
            }
        }
        #endregion

    }
}

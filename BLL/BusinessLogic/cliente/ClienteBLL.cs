using DAL.AccesoDatos.cliente;
using DAL.DAO;
using SL.BLL.Contrato;
using SL.BLL.ExcepcionBLL;
using SL.Servicios.Extension;
using System;
using System.Collections.Generic;

namespace BLL.Servicio.cliente
{
    public sealed class ClienteBLL : IGeneralServicio<Cliente>
    {
        #region
        private readonly static ClienteBLL _instance = new ClienteBLL();
        public static ClienteBLL Instance { get { return _instance; } }
        private ClienteBLL()
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

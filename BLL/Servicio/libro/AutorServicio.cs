//using BLL.Contrato;
//using BLL.Excepcion;
//using DAL.DAO;
//using SL.Servicios.Extension;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace BLL.Servicio.libro
//{
//    public sealed class AutorServicio : IGeneralServicio<Autor>
//    {
//        #region
//        private readonly static AutorServicio _instance = new AutorServicio();
//        public static AutorServicio Instance { get { return _instance; } }
//        private AutorServicio()
//        {
//        }
//        #endregion
//        public void Eliminar(Autor obj)
//        {
//            throw new NotImplementedException();
//        }

//        public void Insertar(Autor obj)
//        {
//            try
//            {
//                using (base_sigalEntities db = new base_sigalEntities())
//                {
//                    //validaciones de autor
//                    if(obj.NOMBRE_AUTOR == "" || obj.APELLIDO_AUTOR =="")
//                    {
//                        throw new DatosFaltantes();
//                    }

//                    db.Autor.Add(obj);
//                    db.SaveChanges();
//                }
//            }
//            catch (DatosFaltantes ex)
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

//        public void Modificar(Autor obj)
//        {
//            throw new NotImplementedException();
//        }

//        public Autor Obtener(Autor obj)
//        {
//            try
//            {
//                using (base_sigalEntities db = new base_sigalEntities())
//                { //busca el cliente
//                    Autor aut = db.Autor.Where(x => x.NOMBRE_AUTOR == obj.NOMBRE_AUTOR && obj.APELLIDO_AUTOR == x.APELLIDO_AUTOR).FirstOrDefault();

//                    if(aut != null)
//                    {
//                        return aut;
//                    }
//                    throw new AutorInexistente();
//                }
//            }
//            catch(AutorInexistente ex)
//            {
//                ex.Handle(this);
//                throw;
//            }
//            catch (Exception ex)
//            {
//                ex.Handle(this);
//                throw;
//            }
//        }

//        public IEnumerable<Autor> ObtenerTodo()
//        {
//            throw new NotImplementedException();
//        }
//    }
//}

using DAL.AccesoDatos.libro;
using DAL.DAO;
using SL.BLL.Contrato;
using SL.BLL.ExcepcionBLL;
using SL.Servicios.Extension;
using System;
using System.Collections.Generic;

namespace BLL.Servicio.libro
{
    public sealed class AutorServicio : IGeneralServicio<Autor>
    {
        #region Singleton
        private readonly static AutorServicio _instance = new AutorServicio();
        public static AutorServicio Instance { get { return _instance; } }
        private AutorServicio()
        {
        }
        #endregion

        public void Eliminar(Autor obj)
        {
            throw new NotImplementedException();
        }

        public void Insertar(Autor obj)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(obj.NOMBRE_AUTOR) || string.IsNullOrWhiteSpace(obj.APELLIDO_AUTOR))
                {
                    throw new DatosFaltantes();
                }

                AutorDAL.Instance.Insertar(obj);
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

        public void Modificar(Autor obj)
        {
            throw new NotImplementedException();
        }

        public Autor Obtener(Autor obj)
        {
            try
            {
                Autor aut = AutorDAL.Instance.Obtener(obj);

                if (aut == null)
                {
                    throw new AutorInexistente();
                }

                return aut;
            }
            catch (AutorInexistente ex)
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

        public IEnumerable<Autor> ObtenerTodo()
        {
            try
            {
                return AutorDAL.Instance.ObtenerTodo();
            }
            catch (Exception ex)
            {
                ex.Handle(this);
                throw;
            }
        }
    }
}

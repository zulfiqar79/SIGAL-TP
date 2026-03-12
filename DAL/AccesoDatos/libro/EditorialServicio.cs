//using DAL.DAO;
//using SL.BLL.Contrato;
//using SL.BLL.ExcepcionBLL;
//using SL.Servicios.Extension;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace DAL.AccesoDatos.libro
//{
//    public sealed class EditorialServicio : IGeneralServicio<Editorial>
//    {
//        #region
//        private readonly static EditorialServicio _instance = new EditorialServicio();
//        public static EditorialServicio Instance { get { return _instance; } }
//        private EditorialServicio()
//        {
//        }
//        #endregion
//        public void Eliminar(Editorial obj)
//        {
//            throw new NotImplementedException();
//        }

//        public void Insertar(Editorial obj)
//        {
//            try
//            {
//                using (base_sigalEntities db = new base_sigalEntities())
//                {
//                    //validaciones de autor
//                    if (obj.NOMBRE_EDITORIAL == "" || obj.PAIS == "")
//                    {
//                        throw new DatosFaltantes();
//                    }

//                    db.Editorial.Add(obj);
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

//        public void Modificar(Editorial obj)
//        {
//            throw new NotImplementedException();
//        }

//        public Editorial Obtener(Editorial obj)
//        {
//            try
//            {
//                using (base_sigalEntities db = new base_sigalEntities())
//                { //busca el cliente
//                    Editorial ed = db.Editorial.Where(x => x.NOMBRE_EDITORIAL == obj.NOMBRE_EDITORIAL).FirstOrDefault();

//                    if (ed != null)
//                    {
//                        return ed;
//                    }
//                    throw new EditorialInexistente();
//                }
//            }
//            catch (EditorialInexistente ex)
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

//        public IEnumerable<Editorial> ObtenerTodo()
//        {
//            throw new NotImplementedException();
//        }
//    }
//}

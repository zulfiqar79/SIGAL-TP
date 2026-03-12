//using DAL.DAO;
//using SL.BLL.Contrato;
//using SL.BLL.ExcepcionBLL;
//using SL.Servicios.Extension;
//using System;
//using System.Collections.Generic;
//using System.Data.Entity;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace DAL.AccesoDatos.libro
//{
//    public sealed class LibroServicio : IGeneralServicio<Libro>
//    {
//        #region
//        private readonly static LibroServicio _instance = new LibroServicio();
//        public static LibroServicio Instance { get { return _instance; } }
//        private LibroServicio()
//        {
//        }
//        #endregion
//        public void Insertar(Libro obj)
//        {
//            using (base_sigalEntities db = new base_sigalEntities())
//            {
//                try
//                {
//                    //validaciones libro
//                    if (obj.TITULO_LIBRO == "" || obj.CONTENIDO == "" || obj.ISBN == "")
//                    {
//                        throw new DatosFaltantes();
//                    }

//                    //buscar id del ultimo autor creado
//                    int idAutor = db.Autor.Max(e => e.ID_AUTOR);

//                    //buscar id de la ultima editorial creada
//                    int idEditorial = db.Editorial.Max(e => e.ID_EDITORIAL);

//                    //crear libro
//                    Libro l = new Libro()
//                    {
//                        ID_AUTOR_LIBRO = idAutor,
//                        ID_EDITORIAL_LIBRO = idEditorial,
//                        ISBN = obj.ISBN,
//                        CONTENIDO = obj.CONTENIDO,
//                        TITULO_LIBRO = obj.TITULO_LIBRO,
//                        ESTADO_LIBRO = "DISPONIBLE",
//                        PUBLICADO = obj.PUBLICADO,
//                    };

//                    db.Libro.Add(l);
//                    db.SaveChanges();
//                }
//                catch (DatosFaltantes ex)
//                {
//                    ex.Handle(this);
//                    throw ex;
//                }
//                catch (Exception ex)
//                {
//                    ex.Handle(this);
//                    throw;
//                }
//            }
//        }
//        public void InsertarExistenteAutor(Libro obj)
//        {
//            using (base_sigalEntities db = new base_sigalEntities())
//            {
//                try
//                {
//                    //validaciones libro
//                    if (obj.TITULO_LIBRO == "" || obj.CONTENIDO == "" || obj.ISBN == "")
//                    {
//                        throw new DatosFaltantes();
//                    }


//                    //buscar id de la ultima editorial creada
//                    int idEditorial = db.Editorial.Max(e => e.ID_EDITORIAL);

//                    //crear libro
//                    Libro l = new Libro()
//                    {
//                        ID_AUTOR_LIBRO = obj.ID_AUTOR_LIBRO,
//                        ID_EDITORIAL_LIBRO = idEditorial,
//                        ISBN = obj.ISBN,
//                        CONTENIDO = obj.CONTENIDO,
//                        TITULO_LIBRO = obj.TITULO_LIBRO,
//                        ESTADO_LIBRO = "DISPONIBLE",
//                        PUBLICADO = obj.PUBLICADO,
//                    };

//                    db.Libro.Add(l);
//                    db.SaveChanges();
//                }
//                catch (DatosFaltantes ex)
//                {
//                    ex.Handle(this);
//                    throw ex;
//                }
//                catch (Exception ex)
//                {
//                    ex.Handle(this);
//                    throw;
//                }
//            }
//        }
//        public void InsertarExistenteEditorial(Libro obj)
//        {
//            using (base_sigalEntities db = new base_sigalEntities())
//            {
//                try
//                {
//                    //validaciones libro
//                    if (obj.TITULO_LIBRO == "" || obj.CONTENIDO == "" || obj.ISBN == "")
//                    {
//                        throw new DatosFaltantes();
//                    }

//                    //buscar id del ultimo autor creado
//                    int idAutor = db.Autor.Max(e => e.ID_AUTOR);


//                    //crear libro
//                    Libro l = new Libro()
//                    {
//                        ID_AUTOR_LIBRO = idAutor,
//                        ID_EDITORIAL_LIBRO = obj.ID_EDITORIAL_LIBRO,
//                        ISBN = obj.ISBN,
//                        CONTENIDO = obj.CONTENIDO,
//                        TITULO_LIBRO = obj.TITULO_LIBRO,
//                        ESTADO_LIBRO = "DISPONIBLE",
//                        PUBLICADO = obj.PUBLICADO,
//                    };

//                    db.Libro.Add(l);
//                    db.SaveChanges();
//                }
//                catch (DatosFaltantes ex)
//                {
//                    ex.Handle(this);
//                    throw ex;
//                }
//                catch (Exception ex)
//                {
//                    ex.Handle(this);
//                    throw;
//                }
//            }
//        }
//        public void InsertarExistenteEditorialyAutor(Libro obj)
//        {
//            using (base_sigalEntities db = new base_sigalEntities())
//            {
//                try
//                {
//                    //validaciones libro
//                    if (obj.TITULO_LIBRO == "" || obj.CONTENIDO == "" || obj.ISBN == "")
//                    {
//                        throw new DatosFaltantes();
//                    }

//                    int idAutor = db.Autor.Max(e => e.ID_AUTOR);

//                    //crear libro
//                    Libro l = new Libro()
//                    {
//                        ID_AUTOR_LIBRO = obj.ID_AUTOR_LIBRO,
//                        ID_EDITORIAL_LIBRO = obj.ID_EDITORIAL_LIBRO,
//                        ISBN = obj.ISBN,
//                        CONTENIDO = obj.CONTENIDO,
//                        TITULO_LIBRO = obj.TITULO_LIBRO,
//                        ESTADO_LIBRO = "DISPONIBLE",
//                        PUBLICADO = obj.PUBLICADO,
//                    };

//                    db.Libro.Add(l);
//                    db.SaveChanges();
//                }
//                catch (DatosFaltantes ex)
//                {
//                    ex.Handle(this);
//                    throw ex;
//                }
//                catch (Exception ex)
//                {
//                    ex.Handle(this);
//                    throw;
//                }
//            }
//        }
//        public void Eliminar(Libro obj)
//        {
//            throw new NotImplementedException();
//        }

//        public void Modificar(Libro obj)
//        {
//            try
//            {
//                //modifico el estado del detalle de alquiler
//                using (base_sigalEntities db = new base_sigalEntities())
//                {
//                    // Libro lib = db.Libro.Where(x => x.TITULO_LIBRO == obj.TITULO_LIBRO).First();

//                    Libro lib = db.Libro.Where(x => x.ID_LIBRO == obj.ID_LIBRO && x.TITULO_LIBRO == obj.TITULO_LIBRO).First();

//                    if (lib.ESTADO_LIBRO == "ALQUILADO")
//                    {
//                        lib.ESTADO_LIBRO = "DISPONIBLE";
//                        db.Entry(lib).State = System.Data.Entity.EntityState.Modified;
//                        db.SaveChanges();
//                    }
//                    /* else if (lib.ESTADO_LIBRO == "DISPONIBLE")
//                     {
//                         throw new AlquilerFinalizado();
//                     }*/
//                }
//            }
//            catch (Exception ex)
//            {
//                ex.Handle(this);
//                throw;
//            }
//        }
//        public Libro Obtener(Libro obj)
//        {
//            try
//            {
//                using (base_sigalEntities db = new base_sigalEntities())
//                {
//                    //busca el nombre del libro
//                    Libro lib = db.Libro.Where(x => x.TITULO_LIBRO == obj.TITULO_LIBRO || x.ID_LIBRO == obj.ID_LIBRO).First();

//                    if (lib.ESTADO_LIBRO != "ALQUILADO")
//                    {
//                        lib.ESTADO_LIBRO = "ALQUILADO"; //modifico su estado

//                        //guardo
//                        db.Entry(lib).State = System.Data.Entity.EntityState.Modified;
//                        db.SaveChanges();

//                        //retorno
//                        return lib;
//                    }
//                    else if (lib.ESTADO_LIBRO == "ALQUILADO") //detalle alquiler
//                    {
//                        lib.ESTADO_LIBRO = "DISPONIBLE";
//                        db.Entry(lib).State = System.Data.Entity.EntityState.Modified;
//                        db.SaveChanges();

//                        return lib;
//                    }
//                    return null;
//                }
//            }
//            catch (Exception ex)
//            {
//                ex.Handle(this);
//                throw;
//            }
//        }
//        public List<Libro> ListaDeLibro(Libro obj)
//        {
//            using (base_sigalEntities db = new base_sigalEntities())
//            {
//                var permisos = db.Libro
//                        .SqlQuery($"SELECT * FROM Libro WHERE ESTADO_LIBRO = 'ALQUILADO'")
//                        .ToList();

//                return permisos;
//            }
//        }

//        public IEnumerable<Libro> ObtenerTodo()
//        { //solo los que tengan estado pendiente
//            try
//            {
//                using (base_sigalEntities db = new base_sigalEntities())
//                {
//                    var resultadosAnonimos = db.Libro
//                .Select(libro => new
//                {
//                    ID_LIBRO = libro.ID_LIBRO,
//                    ESTADO_LIBRO = libro.ESTADO_LIBRO,
//                    TITULO_LIBRO = libro.TITULO_LIBRO,
//                    CONTENIDO = libro.CONTENIDO,
//                    PUBLICADO = libro.PUBLICADO,
//                    ISBN = libro.ISBN,
//                    ID_EDITORIAL_LIBRO = libro.ID_EDITORIAL_LIBRO,
//                    ID_AUTOR_LIBRO = libro.ID_AUTOR_LIBRO
//                })
//                .ToList();

//                    // Convertir a instancias de Libro
//                    var resultados = resultadosAnonimos
//                        .Select(libroAnonimo => new Libro
//                        {
//                            ID_LIBRO = libroAnonimo.ID_LIBRO,
//                            ESTADO_LIBRO = libroAnonimo.ESTADO_LIBRO,
//                            TITULO_LIBRO = libroAnonimo.TITULO_LIBRO,
//                            CONTENIDO = libroAnonimo.CONTENIDO,
//                            PUBLICADO = libroAnonimo.PUBLICADO,
//                            ISBN = libroAnonimo.ISBN,
//                            ID_EDITORIAL_LIBRO = libroAnonimo.ID_EDITORIAL_LIBRO,
//                            ID_AUTOR_LIBRO = libroAnonimo.ID_AUTOR_LIBRO
//                        })
//                        .ToList();

//                    return resultados;
//                }
//            }
//            catch (Exception ex)
//            {
//                ex.Handle(this);
//                throw;
//            }
//            throw new NotImplementedException();
//        }

//    }
//}

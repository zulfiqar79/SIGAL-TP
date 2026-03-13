using DAL.AccesoDatos.libro;
using DAL.DAO;
using SL.BLL.Contrato;
using SL.BLL.ExcepcionBLL;
using SL.Servicios.Extension;
using System;
using System.Collections.Generic;

namespace BLL.Servicio.libro
{
    public sealed class LibroBLL : IGeneralServicio<Libro>
    {
        #region
        private readonly static LibroBLL _instance = new LibroBLL();
        public static LibroBLL Instance { get { return _instance; } }
        private LibroBLL()
        {
        }
        #endregion

        private void ValidarLibro(Libro obj)
        {
            if (string.IsNullOrWhiteSpace(obj.TITULO_LIBRO) ||
                string.IsNullOrWhiteSpace(obj.CONTENIDO) ||
                string.IsNullOrWhiteSpace(obj.ISBN))
            {
                throw new DatosFaltantes();
            }
        }

        public void Insertar(Libro obj)
        {
            try
            {
                ValidarLibro(obj);

                int idAutor = LibroDAL.Instance.ObtenerUltimoIdAutor();
                int idEditorial = LibroDAL.Instance.ObtenerUltimoIdEditorial();

                Libro l = new Libro()
                {
                    ID_AUTOR_LIBRO = idAutor,
                    ID_EDITORIAL_LIBRO = idEditorial,
                    ISBN = obj.ISBN,
                    CONTENIDO = obj.CONTENIDO,
                    TITULO_LIBRO = obj.TITULO_LIBRO,
                    ESTADO_LIBRO = "DISPONIBLE",
                    PUBLICADO = obj.PUBLICADO,
                };

                LibroDAL.Instance.Insertar(l);
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

        public void InsertarExistenteAutor(Libro obj)
        {
            try
            {
                ValidarLibro(obj);

                int idEditorial = LibroDAL.Instance.ObtenerUltimoIdEditorial();

                Libro l = new Libro()
                {
                    ID_AUTOR_LIBRO = obj.ID_AUTOR_LIBRO,
                    ID_EDITORIAL_LIBRO = idEditorial,
                    ISBN = obj.ISBN,
                    CONTENIDO = obj.CONTENIDO,
                    TITULO_LIBRO = obj.TITULO_LIBRO,
                    ESTADO_LIBRO = "DISPONIBLE",
                    PUBLICADO = obj.PUBLICADO,
                };

                LibroDAL.Instance.Insertar(l);
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

        public void InsertarExistenteEditorial(Libro obj)
        {
            try
            {
                ValidarLibro(obj);

                int idAutor = LibroDAL.Instance.ObtenerUltimoIdAutor();

                Libro l = new Libro()
                {
                    ID_AUTOR_LIBRO = idAutor,
                    ID_EDITORIAL_LIBRO = obj.ID_EDITORIAL_LIBRO,
                    ISBN = obj.ISBN,
                    CONTENIDO = obj.CONTENIDO,
                    TITULO_LIBRO = obj.TITULO_LIBRO,
                    ESTADO_LIBRO = "DISPONIBLE",
                    PUBLICADO = obj.PUBLICADO,
                };

                LibroDAL.Instance.Insertar(l);
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

        public void InsertarExistenteEditorialyAutor(Libro obj)
        {
            try
            {
                ValidarLibro(obj);

                Libro l = new Libro()
                {
                    ID_AUTOR_LIBRO = obj.ID_AUTOR_LIBRO,
                    ID_EDITORIAL_LIBRO = obj.ID_EDITORIAL_LIBRO,
                    ISBN = obj.ISBN,
                    CONTENIDO = obj.CONTENIDO,
                    TITULO_LIBRO = obj.TITULO_LIBRO,
                    ESTADO_LIBRO = "DISPONIBLE",
                    PUBLICADO = obj.PUBLICADO,
                };

                LibroDAL.Instance.Insertar(l);
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

        public void Eliminar(Libro obj)
        {
            throw new NotImplementedException();
        }

        public void Modificar(Libro obj)
        {
            try
            {
                Libro lib = LibroDAL.Instance.ObtenerPorIdYTitulo(obj.ID_LIBRO, obj.TITULO_LIBRO);

                if (lib != null && lib.ESTADO_LIBRO == "ALQUILADO")
                {
                    lib.ESTADO_LIBRO = "DISPONIBLE";
                    LibroDAL.Instance.Modificar(lib);
                }
            }
            catch (Exception ex)
            {
                ex.Handle(this);
                throw;
            }
        }

        public Libro Obtener(Libro obj)
        {
            try
            {
                Libro lib = LibroDAL.Instance.ObtenerPorTituloOId(obj.TITULO_LIBRO, obj.ID_LIBRO);

                if (lib == null)
                    return null;

                if (lib.ESTADO_LIBRO != "ALQUILADO")
                {
                    lib.ESTADO_LIBRO = "ALQUILADO";
                }
                else
                {
                    lib.ESTADO_LIBRO = "DISPONIBLE";
                }

                LibroDAL.Instance.Modificar(lib);
                return lib;
            }
            catch (Exception ex)
            {
                ex.Handle(this);
                throw;
            }
        }

        public List<Libro> ListaDeLibro(Libro obj)
        {
            try
            {
                return LibroDAL.Instance.ListaDeLibroAlquilados();
            }
            catch (Exception ex)
            {
                ex.Handle(this);
                throw;
            }
        }

        public IEnumerable<Libro> ObtenerTodo()
        {
            try
            {
                return LibroDAL.Instance.ObtenerTodo();
            }
            catch (Exception ex)
            {
                ex.Handle(this);
                throw;
            }
        }
    }
}

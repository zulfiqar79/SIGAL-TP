using Domain;
using Pantallas.Observer;
using SL.BLL.ExcepcionBLL;
using SL.BLL.ExceptionBLL;
using SL.Servicios.Extension;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pantallas
{
    public partial class frmCargaLibro : Form, IFormObserver
    {
        private static List<IFormObserver> formularios = new List<IFormObserver>();
        public frmCargaLibro()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Carga de Libros";
        }

        public void Update(Form form)
        {
            try
            {
                //Datos libro
                lblTitulo.Text = "TITULO*".Traducir();
                lblAno.Text = "AÑO*".Traducir();
                lblISBN.Text = "ISBN*".Traducir();
                lblContenido.Text = "CONTENIDO*".Traducir();

                //Datos Editorial
                lblNombreEDI.Text = "NOMBRE*".Traducir();
                lblTelefonoEDI.Text = "TELEFONO*".Traducir();
                lblDireccionEDI.Text = "DIRECCIÓN".Traducir();
                lblPaisEDI.Text = "PAIS*".Traducir();

                //Datos autor
                lblNombreAU.Text = "NOMBRE*".Traducir();
                lblApellidoAU.Text = "APELLIDO*".Traducir();
                lblNacimientoAU.Text = "AÑO NACIMIENTO*".Traducir();

                //Boton
                btnCargarLibro.Text = "CARGAR LIBRO".Traducir();

                lblObligatorio.Text = "(*) Obligatorio".Traducir();

                //Group Box
                gpDatoLibro.Text = "DATO LIBRO".Traducir();
                gpDatoAutor.Text = "DATO AUTOR".Traducir();
                gpDatoEditorial.Text = "DATO EDITORIAL".Traducir();
                gpSeleccionarExistente.Text = "SELECCIONAR EXISTENTE".Traducir();

                btnAutorConsulta.Text = "AUTOR".Traducir();
                btnEditorialConsulta.Text = "EDITORIAL".Traducir();
            }
            catch(PalabraInexistente ex)
            {
                LoggerService.WriteLog(ex.Message);
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCargarLibro_Click(object sender, EventArgs e)
        {
            try
            {
                if (Autor_Editorial_existente.AutorCargado == true && Autor_Editorial_existente.EditorialCargada == false)
                {
                    //Buscar Autor
                    Autor a2 = new Autor()
                    {
                        NOMBRE_AUTOR = Autor_Editorial_existente.NOMBRE_AUTOR,
                        APELLIDO_AUTOR = Autor_Editorial_existente.APELLIDO_AUTOR,
                    };
                    Autor autorExiste = BLL.Servicio.libro.AutorBLL.Instance.Obtener(a2);
                    //Crear editorial
                    Editorial ed2 = new Editorial()
                    {
                        NOMBRE_EDITORIAL = txtNombreEditorial.Text,
                        TELEFONO = Convert.ToInt32(txtTelefonoEditorial.Text),
                        DIRECCION = txtDireccion.Text,
                        PAIS = txtPais.Text,
                    };
                    BLL.Servicio.libro.EditorialBLL.Instance.Insertar(ed2);
                    //crear libro
                    Libro l2 = new Libro()
                    {
                        ISBN = txtISBN.Text,
                        CONTENIDO = txtContenido.Text,
                        TITULO_LIBRO = txtTituloLibro.Text,
                        PUBLICADO = Convert.ToInt32(txtAno.Text),
                        ID_AUTOR_LIBRO = autorExiste.ID_AUTOR
                    };
                    BLL.Servicio.libro.LibroBLL.Instance.InsertarExistenteAutor(l2);
                    #region botones
                    txtTituloLibro.Clear();
                    txtContenido.Clear();
                    txtISBN.Clear();
                    txtAno.Clear();

                    txtNombreEditorial.Clear();
                    txtTelefonoEditorial.Clear();
                    txtDireccion.Clear();
                    txtPais.Clear();

                    txtNombreAutor.Clear();
                    txtApellido.Clear();
                    txtNacimientoAutor.Clear();
                    #endregion
                    MessageBox.Show("El libro ".Traducir() + "-" + l2.TITULO_LIBRO +" se cargó con el autor existente.".Traducir());
                }
                if (Autor_Editorial_existente.AutorCargado == false && Autor_Editorial_existente.EditorialCargada == true)
                {
                    //crear autor
                    Autor a = new Autor()
                    {
                        NOMBRE_AUTOR = txtNombreAutor.Text,
                        APELLIDO_AUTOR = txtApellido.Text,
                        NACIMIENTO = Convert.ToInt32(txtNacimientoAutor.Text)
                    };
                    BLL.Servicio.libro.AutorBLL.Instance.Insertar(a);

                    //Buscar editorial
                    Editorial edi = new Editorial()
                    {
                        NOMBRE_EDITORIAL = Autor_Editorial_existente.NOMBRE_EDITORIAL
                    };
                    Editorial editorialExiste = BLL.Servicio.libro.EditorialBLL.Instance.Obtener(edi);

                    //crear libro
                    Libro l2 = new Libro()
                    {
                        ISBN = txtISBN.Text,
                        CONTENIDO = txtContenido.Text,
                        TITULO_LIBRO = txtTituloLibro.Text,
                        PUBLICADO = Convert.ToInt32(txtAno.Text),
                        ID_EDITORIAL_LIBRO=editorialExiste.ID_EDITORIAL
                    };
                    BLL.Servicio.libro.LibroBLL.Instance.InsertarExistenteEditorial(l2);
                    #region botones
                    txtTituloLibro.Clear();
                    txtContenido.Clear();
                    txtISBN.Clear();
                    txtAno.Clear();

                    txtNombreEditorial.Clear();
                    txtTelefonoEditorial.Clear();
                    txtDireccion.Clear();
                    txtPais.Clear();

                    txtNombreAutor.Clear();
                    txtApellido.Clear();
                    txtNacimientoAutor.Clear();
                    #endregion
                    MessageBox.Show("El libro ".Traducir() + "-" + l2.TITULO_LIBRO+" se cargó con la editorial existente.".Traducir());
                }

                if (Autor_Editorial_existente.AutorCargado == false && Autor_Editorial_existente.EditorialCargada == false)
                {
                    //crear autor
                    Autor a = new Autor()
                    {
                        NOMBRE_AUTOR = txtNombreAutor.Text,
                        APELLIDO_AUTOR = txtApellido.Text,
                        NACIMIENTO = Convert.ToInt32(txtNacimientoAutor.Text)
                    };
                    BLL.Servicio.libro.AutorBLL.Instance.Insertar(a);

                    //crear editorial
                    Editorial ed = new Editorial()
                    {
                        NOMBRE_EDITORIAL = txtNombreEditorial.Text,
                        TELEFONO = Convert.ToInt32(txtTelefonoEditorial.Text),
                        DIRECCION = txtDireccion.Text,
                        PAIS = txtPais.Text,
                    };
                    BLL.Servicio.libro.EditorialBLL.Instance.Insertar(ed);

                    //crear libro
                    Libro l = new Libro()
                    {
                        ISBN = txtISBN.Text,
                        CONTENIDO = txtContenido.Text,
                        TITULO_LIBRO = txtTituloLibro.Text,
                        PUBLICADO = Convert.ToInt32(txtAno.Text)
                    };
                    BLL.Servicio.libro.LibroBLL.Instance.Insertar(l);

                    #region botones
                    txtTituloLibro.Clear();
                    txtContenido.Clear();
                    txtISBN.Clear();
                    txtAno.Clear();

                    txtNombreEditorial.Clear();
                    txtTelefonoEditorial.Clear();
                    txtDireccion.Clear();
                    txtPais.Clear();

                    txtNombreAutor.Clear();
                    txtApellido.Clear();
                    txtNacimientoAutor.Clear();
                    #endregion

                    MessageBox.Show("El libro ".Traducir() + "-" + l.TITULO_LIBRO+ " se cargó junto con el autor y editorial.".Traducir()); 
                }

                if (Autor_Editorial_existente.AutorCargado == true && Autor_Editorial_existente.EditorialCargada == true)
                {
                    //Buscar autor
                    Autor a2 = new Autor()
                    {
                        NOMBRE_AUTOR = Autor_Editorial_existente.NOMBRE_AUTOR,
                        APELLIDO_AUTOR = Autor_Editorial_existente.APELLIDO_AUTOR,
                    };
                    Autor autorExiste = BLL.Servicio.libro.AutorBLL.Instance.Obtener(a2);

                    //Buscar editorial
                    Editorial edi = new Editorial()
                    {
                        NOMBRE_EDITORIAL = Autor_Editorial_existente.NOMBRE_EDITORIAL
                    };
                    Editorial editorialExiste = BLL.Servicio.libro.EditorialBLL.Instance.Obtener(edi);
                    //Cargar libro
                    Libro l2 = new Libro()
                    {
                        ISBN = txtISBN.Text,
                        CONTENIDO = txtContenido.Text,
                        TITULO_LIBRO = txtTituloLibro.Text,
                        PUBLICADO = Convert.ToInt32(txtAno.Text),
                        ID_AUTOR_LIBRO = autorExiste.ID_AUTOR,
                        ID_EDITORIAL_LIBRO = editorialExiste.ID_EDITORIAL
                    };
                    BLL.Servicio.libro.LibroBLL.Instance.InsertarExistenteEditorialyAutor(l2);
                    #region botones
                    txtTituloLibro.Clear();
                    txtContenido.Clear();
                    txtISBN.Clear();
                    txtAno.Clear();

                    txtNombreEditorial.Clear();
                    txtTelefonoEditorial.Clear();
                    txtDireccion.Clear();
                    txtPais.Clear();

                    txtNombreAutor.Clear();
                    txtApellido.Clear();
                    txtNacimientoAutor.Clear();
                    #endregion
                    MessageBox.Show("El libro ".Traducir() + "-" +l2.TITULO_LIBRO + " se cargó con el autor y editorial existentes.".Traducir());
                }
            }
            catch (DatosFaltantes ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                LoggerService.WriteLog(ex.Message);
                MessageBox.Show(ex.Message);
            }
        }

        private void frmCargaLibro_Load(object sender, EventArgs e)
        {
            Update(this);
            helpProvider1.HelpNamespace = Application.StartupPath + "/Libro.chm";
            helpProvider1.SetHelpString(this, "Carga");
            helpProvider1.SetHelpKeyword(this, "Carga");
            helpProvider1.SetHelpNavigator(this, HelpNavigator.KeywordIndex);

        }

        private void btnAutorConsulta_Click(object sender, EventArgs e)
        {
            frmAutorExistente formAutor = new frmAutorExistente();
            formAutor.Show();
            formularios.Add(formAutor);
        }

        private void btnEditorialConsulta_Click(object sender, EventArgs e)
        {
            frmEditorialExistente formEdi = new frmEditorialExistente();
            formEdi.Show();
            formularios.Add(formEdi);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

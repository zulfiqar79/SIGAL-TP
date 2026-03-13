using Catel.Linq;
using Domain;
using Pantallas.Observer;
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
    public partial class frmLibroAlquilado : Form, IFormObserver
    {
        public frmLibroAlquilado()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Libros Alquilados";
        }

        public void Update(Form form)
        {
            try
            {
                btnConsultarLibro.Text = "CONSULTAR".Traducir();
            }
            catch (PalabraInexistente ex)
            {
                //ex.Handle(this); no sería necesario
                MessageBox.Show(ex.Message);
            }
        }

        private void btnConsultarLibro_Click(object sender, EventArgs e)
        {
            try
            {
                Libro lib = new Libro();
                List<Libro> lista = BLL.Servicio.libro.LibroBLL.Instance.ListaDeLibro(lib);

                verLibros.DataSource = lista
                    .Select(x => new
                    {
                        Titulo       = x.TITULO_LIBRO,
                        Autor        = x.Autor != null ? x.Autor.NOMBRE_AUTOR + " " + x.Autor.APELLIDO_AUTOR : "",
                        Editorial    = x.Editorial != null ? x.Editorial.NOMBRE_EDITORIAL : "",
                        ISBN         = x.ISBN,
                        Anio_Publicado = x.PUBLICADO,
                        Estado       = x.ESTADO_LIBRO,
                        Contenido    = x.CONTENIDO
                    })
                    .ToList();
            }
            catch (Exception ex)
            {
                LoggerService.WriteLog(ex.Message);
                MessageBox.Show(ex.Message);
            }
        }

        private void frmLibroAlquilado_Load(object sender, EventArgs e)
        {
            helpProvider1.HelpNamespace = Application.StartupPath + "/Libro.chm";
            helpProvider1.SetHelpString(this, "AlquilerMes");
            helpProvider1.SetHelpKeyword(this, "AlquilerMes");
            helpProvider1.SetHelpNavigator(this, HelpNavigator.KeywordIndex);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

        
}

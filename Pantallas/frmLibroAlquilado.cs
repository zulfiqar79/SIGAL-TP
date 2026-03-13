using Catel.Linq;
using DAL.DAO;
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
            { //List<UsuarioPermiso> listaDePermisos
                //listaLibros = new BindingList<Libro>(BLL.Servicio.libro.LibroServicio.Instance.ObtenerTodo().ToList());
                //verLibros.DataSource = listaLibros.ToList();
                // ***
                Libro lib = new Libro();
                List<Libro> lista = BLL.Servicio.libro.LibroBLL.Instance.ListaDeLibro(lib);

                verLibros.DataSource = lista;
                //**
                //Libro lib = new Libro();
                //List<Libro> lista = BLL.Servicio.libro.LibroServicio.Instance.ListaDeLibro(lib);

                //verLibros.DataSource = lista
                //    .Select(x => new
                //    {
                //        x.PUBLICADO,
                //        x.ESTADO_LIBRO,
                //        x.TITULO_LIBRO,
                //        x.CONTENIDO,
                //        x.ISBN
                //    })
                //    .ToList();
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

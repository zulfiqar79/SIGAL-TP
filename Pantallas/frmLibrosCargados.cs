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
    public partial class frmLibrosCargados : Form, IFormObserver
    {
        public frmLibrosCargados()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        public void Update(Form form)
        {
            try
            {
                btnConsultarLibro.Text = "CONSULTAR".Traducir();
            }
            catch(PalabraInexistente ex)
            {                
                MessageBox.Show(ex.Message);
            }
        }
        private BindingList<Libro> listaLibro;
        private void btnConsultarLibro_Click(object sender, EventArgs e)
        {
            listaLibro = new BindingList<Libro>(BLL.Servicio.libro.LibroServicio.Instance.ObtenerTodo().ToList());
            verLibros.DataSource = listaLibro;
            
        }
        private void verLibros_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {            
            try
            {
                MessageBox.Show("Se produjo un error al mostrar los datos: " + e.Exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                //registrar el error.
                LoggerService.WriteLog(e.ToString());

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error adicional al manejar el error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmLibrosCargados_Load(object sender, EventArgs e)
        {
            helpProvider1.HelpNamespace = Application.StartupPath + "/Libro.chm";
            helpProvider1.SetHelpString(this, "Cargados");
            helpProvider1.SetHelpKeyword(this, "Cargados");
            helpProvider1.SetHelpNavigator(this, HelpNavigator.KeywordIndex);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

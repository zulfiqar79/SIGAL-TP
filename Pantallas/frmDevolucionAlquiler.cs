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
    public partial class frmDevolucionAlquiler : Form, IFormObserver
    {
        public frmDevolucionAlquiler()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        public void Update(Form form)
        {
            try
            {
                btnRegistrarDevolución.Text = "REGISTRAR DEVOLUCIÓN".Traducir();
                lblCodigoLibro.Text = "CÓDIGO LIBRO*".Traducir();
                lblNombreLibro.Text = "NOMBRE LIBRO*".Traducir();
                lblObligatorio.Text = "(*) Obligatorio".Traducir();
                lblNumAlquiler.Text = "NÚM ALQUILER*".Traducir();
            }
            catch (PalabraInexistente ex)
            {
                LoggerService.WriteLog(ex.Message);
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRegistrarDevolución_Click(object sender, EventArgs e)
        {
            try
            {
                //modificar estado pendiente a finalizado.
                //busco libro
                Libro buscar = new Libro()
                {
                    ID_LIBRO = Convert.ToInt32(txtCodigoLibro.Text),
                    TITULO_LIBRO = txtNombreLibro.Text,
                };
                Libro libEncontrado = BLL.Servicio.libro.LibroServicio.Instance.Obtener(buscar);

                //Busco alquiler, lo modifico a finalizado
                DAlquiler dA = new DAlquiler()
                {
                    ID_DETALLE_ALQUILER = Convert.ToInt32(txtNumAlquiler.Text),
                    ID_LIBRO = libEncontrado.ID_LIBRO,
                };

                BLL.Servicio.alquiler.DetalleAlquilerServicio.Instance.Modificar(dA);
                Form f = new frmMensaje(libEncontrado, null, "REGISTRAR DEVOLUCIÓN", null);
                f.Show();

                //Limpiar
                txtCodigoLibro.Clear();
                txtNombreLibro.Clear();
                txtNumAlquiler.Clear();
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmDevolucionAlquiler_Load(object sender, EventArgs e)
        {
            Update(this);
            helpProvider1.HelpNamespace = Application.StartupPath + "/Alquiler.chm";
            helpProvider1.SetHelpString(this, "Devolucion");
            helpProvider1.SetHelpKeyword(this, "Devolucion");
            helpProvider1.SetHelpNavigator(this, HelpNavigator.KeywordIndex);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

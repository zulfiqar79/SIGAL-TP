using DAL.DAO;
using Pantallas.Observer;
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
    public partial class frmRenovarAlquiler : Form, IFormObserver
    {
        public frmRenovarAlquiler()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Renovar Alquiler";
        }

        public void Update(Form form)
        {
            try
            { 
                lblNumAlquiler.Text = "NÚM ALQUILER*".Traducir();
                lblNombreLibro.Text = "NOMBRE LIBRO*".Traducir();
                lblMontoPago.Text = "MONTO PAGO*".Traducir();
                lblFechaInicio.Text = "FECHA INICIO*".Traducir();
                lblFechaDevolucion.Text = "FECHA DEVOLUCIÓN*".Traducir();
                btnRenovar.Text = "RENOVAR".Traducir();
            }
            catch(Exception ex)
            {
                LoggerService.WriteLog(ex.Message);
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRenovar_Click(object sender, EventArgs e)
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
                Libro libEncontrado = BLL.Servicio.libro.LibroBLL.Instance.Obtener(buscar);

                //Busco alquiler, lo modifico a finalizado
                DAlquiler dA = new DAlquiler()
                {
                    ID_DETALLE_ALQUILER = Convert.ToInt32(txtNumAlquiler.Text),
                    ID_LIBRO = libEncontrado.ID_LIBRO,
                };

                BLL.Servicio.alquiler.DetalleAlquilerBLL.Instance.Modificar(dA);

                //-------------------Registro pago----------------------
                Pago p = new Pago()
                {
                    FECHA_MONTO_PAGO = DateTime.Now,
                    MONTO_PAGO = Convert.ToInt32(txtMontoPago.Text),
                };
                BLL.Servicio.alquiler.PagoBLL.Instance.Insertar(p);

                //---------Detalle del nuev alquiler----------- Lo cargo
                DAlquiler dA2 = new DAlquiler()
                {
                    FECHA_INICIO = dbFechaInicio.Value,
                    FECHA_FIN = dtFechaDevolución.Value,
                    ESTADO = "PENDIENTE",
                    ID_LIBRO = libEncontrado.ID_LIBRO
                    
                };
                
                BLL.Servicio.alquiler.DetalleAlquilerBLL.Instance.Insertar(dA2);

                //Alquiler -------------'renovado'-----------------
                //Buscar cliente
                Cliente buscarCliente = new Cliente()
                {
                    CORREO_CLIENTE = txtCorreoCliente.Text,
                };
                Cliente clienteEncontrado = BLL.Servicio.cliente.ClienteBLL.Instance.Obtener(buscarCliente);

                //cargar alquiler
                Alquiler al = new Alquiler()
                {
                    OBSERVACIONES = "Alquiler renovado",
                    ID_CLIENTE = clienteEncontrado.ID_CLIENTE,
              
                };

                BLL.Servicio.alquiler.AlquilerBLL.Instance.Insertar(al);

                //Busca el ultimo alquiler creado.
                Alquiler alquilerEncontrado = BLL.Servicio.alquiler.AlquilerBLL.Instance.Obtener(al);

                Form f = new frmMensaje(libEncontrado, clienteEncontrado, "ALQUILER RENOVADO", alquilerEncontrado);
                f.Show();
            }
            catch(Exception ex)
            {
                LoggerService.WriteLog(ex.Message);
                MessageBox.Show(ex.Message);
            }
        }

        private void frmRenovarAlquiler_Load(object sender, EventArgs e)
        {
            Update(this);
            helpProvider1.HelpNamespace = Application.StartupPath + "/Alquiler.chm";
            helpProvider1.SetHelpString(this, "Renovar");
            helpProvider1.SetHelpKeyword(this, "Renovar");
            helpProvider1.SetHelpNavigator(this, HelpNavigator.KeywordIndex);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

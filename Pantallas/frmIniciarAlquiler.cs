using DAL.DAO;
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
using System.Reflection.Emit;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pantallas
{
    public partial class frmIniciarAlquiler : Form, IFormObserver
    {
        public frmIniciarAlquiler()
        {
            
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        public void Update(Form form)
        {
            try
            {
                lblNombreLibro.Text = "NOMBRE LIBRO*".Traducir();
                lblCorreoCliente.Text = "CORREO CLIENTE*".Traducir();
                lblPagoAlquiler.Text = "PAGO ALQUILER*".Traducir();
                lblObservaciones.Text = "Observaciones".Traducir();
                lblObligatorio.Text = "(*) Obligatorio".Traducir();
                lblFechaInicio.Text = "FECHA INICIO*".Traducir();
                lblFechaDevolucion.Text = "FECHA DEVOLUCIÓN*".Traducir();
                btnAlquilar.Text = "ALQUILAR".Traducir();
            }
            catch (PalabraInexistente ex)
            {
                LoggerService.WriteLog(ex.Message);
                MessageBox.Show(ex.Message);
            }
        }
        private void btnAlquilar_Click(object sender, EventArgs e)
        {
            try
            {
                //libro
                Libro Buscarlib = new Libro()
                {
                    TITULO_LIBRO = txtLibro.Text,
                };
                //          Buscar libro
                Libro libroEncontrado = BLL.Servicio.libro.LibroServicio.Instance.Obtener(Buscarlib);


                //valido que monto sea numerico
                if (!int.TryParse(txtTotalAlquiler.Text, out int montoPago))
                {
                    MessageBox.Show("El campo PAGO ALQUILER debe ser numérico (solo números).");
                    txtTotalAlquiler.Focus();
                    return;
                }
                //Pago
                Pago p = new Pago()
                {
                    FECHA_MONTO_PAGO = DateTime.Now,
                    MONTO_PAGO = montoPago
                };
                BLL.Servicio.alquiler.PagoServicio.Instance.Insertar(p);                

                //detalle alquiler
                DAlquiler dA = new DAlquiler()
                {
                    FECHA_INICIO = dbFechaInicio.Value,
                    FECHA_FIN = dtFechaDevolución.Value,
                    ESTADO = "PENDIENTE",
                    ID_LIBRO = libroEncontrado.ID_LIBRO
                };

                BLL.Servicio.alquiler.DetalleAlquilerServicio.Instance.Insertar(dA);
                
                //Alquiler
                //            Buscar cliente
                Cliente buscarCliente = new Cliente()
                {
                    CORREO_CLIENTE = txtCliente.Text,
                };
                Cliente clienteEncontrado = BLL.Servicio.cliente.ClienteServicio.Instance.Obtener(buscarCliente);

                //cargar alquiler
                Alquiler al = new Alquiler()
                {
                    OBSERVACIONES = txtObservaciones.Text,
                    ID_CLIENTE = clienteEncontrado.ID_CLIENTE,
                };

                BLL.Servicio.alquiler.AlquilerServicio.Instance.Insertar(al);
                Alquiler a2 = BLL.Servicio.alquiler.AlquilerServicio.Instance.Obtener(al);

                #region botones
                txtCliente.Clear();
                txtLibro.Clear();
                txtObservaciones.Clear(); 
                txtTotalAlquiler.Clear();
                #endregion
                Form f = new frmMensaje(libroEncontrado,clienteEncontrado,"ALQUILER REGISTRADO",a2);
                f.Show();
            }
            catch(LibroNoDisponible ex)
            {
                LoggerService.WriteLog(ex.Message);
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                LoggerService.WriteLog(ex.Message);
                MessageBox.Show(ex.Message);
            }
        }

        private void frmIniciarAlquiler_Load(object sender, EventArgs e)
        {
            Update(this); //IMPORTANTE PONER EN CADA FORM CUANDO INICIA!!!
            helpProvider1.HelpNamespace = Application.StartupPath + "/Alquiler.chm";
            helpProvider1.SetHelpString(this, "Iniciar");
            helpProvider1.SetHelpKeyword(this, "Iniciar");
            helpProvider1.SetHelpNavigator(this, HelpNavigator.KeywordIndex);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

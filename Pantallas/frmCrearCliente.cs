using Domain;
using Pantallas.Observer;
using SL.BLL.ExcepcionBLL;
using SL.BLL.ExceptionBLL;
using SL.Correo;
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
    public partial class frmCrearCliente : Form, IFormObserver
    {
        public frmCrearCliente()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Creacion de Clientes";
        }

        public void Update(Form form)
        {
            try
            {
                lblNombre.Text = "NOMBRE*".Traducir();
                lblApellido.Text = "APELLIDO*".Traducir();
                lblCorreo.Text = "CORREO*".Traducir();
                btnRegistrar.Text = "REGISTRAR".Traducir();
                lblObligatorio.Text = "(*) Obligatorio".Traducir();
            }
            catch (PalabraInexistente ex)
            {
                LoggerService.WriteLog(ex.Message);
                MessageBox.Show(ex.Message);
            }
        }

        private void frmCrearCliente_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;  // Cancela el cierre del formulario
            this.Hide();      // Oculta el formulario en lugar de cerrarlo
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            
            try
            {
                if (String.IsNullOrEmpty(txtNombreCliente.Text) || String.IsNullOrEmpty(txtApellidoCliente.Text) || String.IsNullOrEmpty(txtCorreoCliente.Text))
                {
                    throw new DatosFaltantes();
                }
                //creo cliente
                Cliente c = new Cliente()
                {
                    NOMBRE_CLIENTE = txtNombreCliente.Text,
                    APELLIDO_CLIENTE = txtApellidoCliente.Text,
                    CORREO_CLIENTE = txtCorreoCliente.Text,
                };
                
                string resu = ValidarCorreo.Validar(c.CORREO_CLIENTE);


                if (resu == "true")
                {
                    BLL.Servicio.cliente.ClienteBLL.Instance.Insertar(c);
                    txtNombreCliente.Clear();
                    txtApellidoCliente.Clear();
                    txtCorreoCliente.Clear();
                    Form f = new frmMensaje(null, null, "CLIENTE", null);
                    f.Show();
                }
                else if (resu == "false")
                {
                    throw new FormatoCorreoInvalido();
                }
            }
            catch(FormatoCorreoInvalido ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch(DatosFaltantes ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmCrearCliente_Load(object sender, EventArgs e)
        {
            Update(this);

            helpProvider1.HelpNamespace = Application.StartupPath + "/Cliente_sigal.chm";
            helpProvider1.SetHelpString(this, "Registrar");
            helpProvider1.SetHelpKeyword(this,"Registrar");
            helpProvider1.SetHelpNavigator(this, HelpNavigator.KeywordIndex);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

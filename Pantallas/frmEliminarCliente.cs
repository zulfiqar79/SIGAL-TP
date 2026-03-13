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
    public partial class frmEliminarCliente : Form, IFormObserver
    {
        public frmEliminarCliente()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Eliminar Cliente";
        }

        public void Update(Form form)
        {
            try
            {
                lblObligatorio.Text = "(*) Obligatorio".Traducir();
                lblCorreo.Text = "CORREO*".Traducir();
                btnEliminarCliente.Text = "ELIMINAR".Traducir();
            }
            catch (PalabraInexistente ex)
            {
                LoggerService.WriteLog(ex.Message);
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEliminarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtCorreoCliente.Text) )
                {
                    throw new DatosFaltantes();
                }
                Cliente c = new Cliente()
                {
                    CORREO_CLIENTE = txtCorreoCliente.Text,
                    NOMBRE_CLIENTE = null,
                    ID_CLIENTE = 1
                };
                string resu = ValidarCorreo.Validar(c.CORREO_CLIENTE);
                if (resu == "true")
                {
                    BLL.Servicio.cliente.ClienteBLL.Instance.Eliminar(c);
                    txtCorreoCliente.Clear();

                    Form f = new frmMensaje(null, c, "ELIMINAR CLIENTE", null);
                    f.Show();
                }
                else if (resu == "false") 
                {
                    throw new FormatoCorreoInvalido();
                }
            }
            catch(DatosFaltantes ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch(FormatoCorreoInvalido ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (ClienteInexistente ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception )
            {
                throw;
            }
        }
        private void frmEliminarCliente_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;  // Cancela el cierre del formulario principal
            this.Hide();      // Oculta el formulario principal en lugar de cerrarlo
        }
        private void frmEliminarCliente_Load(object sender, EventArgs e)
        {
            Update(this);
            helpProvider1.HelpNamespace = Application.StartupPath + "/Cliente_sigal.chm";
            helpProvider1.SetHelpString(this, "Eliminar");
            helpProvider1.SetHelpKeyword(this, "Eliminar");
            helpProvider1.SetHelpNavigator(this, HelpNavigator.KeywordIndex);

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

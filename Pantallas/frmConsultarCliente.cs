using BLL.Servicio;
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
    public partial class frmConsultarCliente : Form, IFormObserver
    {
        public frmConsultarCliente()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Consulta de Clientes";
        }
        private void btnConsultarCliente_Click(object sender, EventArgs e)
        {
            var clientes = BLL.Servicio.cliente.ClienteBLL.Instance.ObtenerTodo()
                .Select(x => new
                {
                    Nombre   = x.NOMBRE_CLIENTE,
                    Apellido = x.APELLIDO_CLIENTE,
                    Correo   = x.CORREO_CLIENTE
                })
                .ToList();
            verClientes.DataSource = clientes;
        }
        private void frmConsultarCliente_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;  // Cancela el cierre del formulario
            this.Hide();      // Oculta el formulario en lugar de cerrarlo
        }
        private void verClientes_DataError(object sender, DataGridViewDataErrorEventArgs e)
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

        public void Update(Form form)
        {
            try
            {
                btnConsultarCliente.Text = "CONSULTAR".Traducir();
            }
            catch (PalabraInexistente ex)
            {
                LoggerService.WriteLog(ex.Message);
                MessageBox.Show(ex.Message);
            }
        }

        private void frmConsultarCliente_Load(object sender, EventArgs e)
        {
            Update(this);
            helpProvider1.HelpNamespace = Application.StartupPath + "/Cliente_sigal.chm";
            helpProvider1.SetHelpString(this, "Consultar");
            helpProvider1.SetHelpKeyword(this, "Consultar");
            helpProvider1.SetHelpNavigator(this, HelpNavigator.KeywordIndex);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

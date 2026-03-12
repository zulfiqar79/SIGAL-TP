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
    public partial class frmPregunta : Form, IFormObserver
    {
        public frmPregunta()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void frmPregunta_Load(object sender, EventArgs e)
        {
            Update(this);
            //Inicie en el centro de la pantalla
            
        }

        private void btnSi_Click(object sender, EventArgs e)
        {
            try
            {
                /*foreach (Form form in Application.OpenForms)
                {
                    form.Close();
                }*/
                Application.Exit();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void Update(Form form)
        {
            lblTexto.Text = "¿Está seguro que desea cerrar sesión?".Traducir();
            gpCerrarSesion.Text = "CERRAR SESIÓN".Traducir();
            btnSi.Text = "Sí".Traducir();

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

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
    public partial class frmAlquilerMes : Form, IFormObserver
    {
        public frmAlquilerMes()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Alquileres del Mes";
        }

        public void Update(Form form)
        {
            try
            {
                lblAlquileresDelMes.Text = "ALQUILERES DEL MES".Traducir();
                btnConsultar.Text = "CONSULTAR".Traducir();
            }
            catch (PalabraInexistente ex)
            {
                LoggerService.WriteLog(ex.Message);
                MessageBox.Show(ex.Message);
            }
        }
        
        private void btnConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                List<DAlquiler> lista = BLL.Servicio.alquiler.DetalleAlquilerBLL.Instance.ListaAlquilerMs();
                dgVerAlqui.DataSource = lista;
            }
            catch (Exception ex)
            {
                LoggerService.WriteLog(ex.Message);
                MessageBox.Show(ex.Message);
            }
        }    

        private void frmAlquilerMes_Load(object sender, EventArgs e)
        {
            Update(this); //para que lo aplique.
            helpProvider1.HelpNamespace = Application.StartupPath + "/Alquiler.chm";
            helpProvider1.SetHelpString(this, "AlquilerMes");
            helpProvider1.SetHelpKeyword(this, "AlquilerMes");
            helpProvider1.SetHelpNavigator(this, HelpNavigator.KeywordIndex);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

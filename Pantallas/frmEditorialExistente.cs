using Domain;
using Pantallas.Observer;
using SL.BLL.ExcepcionBLL;
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
    public partial class frmEditorialExistente : Form, IFormObserver
    {
        public frmEditorialExistente()
        {
            InitializeComponent();
        }

        public void Update(Form form)
        {
            try
            {
                lblObligatorio.Text = "(*) Obligatorio".Traducir();
                lblNombre.Text = "NOMBRE*".Traducir();
                btnSeleccionar.Text = "SELECCIONAR".Traducir();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void frmEditorialExistente_Load(object sender, EventArgs e)
        {
            Update(this);
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(txtNombre.Text))
                {
                    throw new DatosFaltantes();
                }
                //Creo edi
                Editorial edi = new Editorial()
                {
                    NOMBRE_EDITORIAL = txtNombre.Text,
                };
                //Verificar si existe el autor
                Editorial ediEx = BLL.Servicio.libro.EditorialBLL.Instance.Obtener(edi);

                if (ediEx != null)
                {
                    //Cargo los datos
                    Autor_Editorial_existente.ID_EDITORIAL= ediEx.ID_EDITORIAL;
                    Autor_Editorial_existente.NOMBRE_EDITORIAL = txtNombre.Text;
                    MessageBox.Show("Se ha seleccionado la editorial.".Traducir());
                    Autor_Editorial_existente.EditorialCargada = true;
                    txtNombre.Clear();
                }

            }
            catch (DatosFaltantes ex)
            {
                txtNombre.Clear();
                MessageBox.Show(ex.Message);
            }
            catch (EditorialInexistente ex)
            {
                txtNombre.Clear();
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                txtNombre.Clear();
                MessageBox.Show(ex.Message);
            }
        }
    }
}

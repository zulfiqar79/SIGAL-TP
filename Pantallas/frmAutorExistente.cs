using DAL.DAO;
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
    public partial class frmAutorExistente : Form, IFormObserver
    {
        public frmAutorExistente()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        public void Update(Form form)
        {
            try
            {
                lblObligatorio.Text = "(*) Obligatorio".Traducir();
                lblNombre.Text = "NOMBRE*".Traducir();
                lblApellido.Text = "APELLIDO*".Traducir();
                btnSeleccionar.Text = "SELECCIONAR".Traducir();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmAutorExistente_Load(object sender, EventArgs e)
        {
            Update(this);
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            try
            {
                if(String.IsNullOrEmpty(txtNombre.Text))
                {
                    throw new DatosFaltantes();
                }
                if (String.IsNullOrEmpty(txtApellido.Text))
                {
                    throw new DatosFaltantes();
                }
                //Creo autor
                Autor autor = new Autor()
                {
                    NOMBRE_AUTOR = txtNombre.Text,
                    APELLIDO_AUTOR = txtApellido.Text,
                };
                //Verificar si existe el autor
                Autor autorExiste = BLL.Servicio.libro.AutorServicio.Instance.Obtener(autor);

                if (autorExiste != null)
                {
                    //Cargo los datos
                    Autor_Editorial_existente.ID_AUTOR = autorExiste.ID_AUTOR;
                    Autor_Editorial_existente.NOMBRE_AUTOR = txtNombre.Text;
                    Autor_Editorial_existente.APELLIDO_AUTOR = txtApellido.Text;
                    MessageBox.Show("Se ha seleccionado el autor.".Traducir());
                    Autor_Editorial_existente.AutorCargado = true;
                    txtNombre.Clear();
                    txtApellido.Clear();
                }

            }
            catch(DatosFaltantes ex)
            {
                txtNombre.Clear();
                txtApellido.Clear();
                MessageBox.Show(ex.Message);
            }
            catch(AutorInexistente ex)
            {
                txtNombre.Clear();
                txtApellido.Clear();
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                txtNombre.Clear();
                txtApellido.Clear();
                MessageBox.Show(ex.Message);
            }
        }       

        private void lblNombre_Click(object sender, EventArgs e)
        {
        }
    }
}

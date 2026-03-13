using DAL.DAO;
using Pantallas.Observer;
using SL.BLL.ExcepcionBLL;
using SL.BLL.ExceptionBLL;
using SL.Cryptoghapy;
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
    public partial class frmCrearUsuario : Form, IFormObserver
    {
        public frmCrearUsuario()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Crear Nuevos Usuarios";
        }

        public void Update(Form form)
        {
            try
            {
                lblUsuario.Text = "USUARIO*".Traducir();
                lblContraseña.Text = "CONTRASEÑA*".Traducir();
                lblRepetirContraseña.Text = "REPETIR CONTRASEÑA*".Traducir();
                btnCrear.Text = "CREAR".Traducir();
                lblObligatorio.Text = "(*) Obligatorio".Traducir();
            }
            catch(PalabraInexistente ex)
            {
                LoggerService.WriteLog(ex.Message);
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            //crear un usuario
            try
            {
                if (string.IsNullOrEmpty(txtUsuario.Text) || string.IsNullOrEmpty(txtContra.Text))
                {
                    throw new DatosFaltantes();
                }

                //Valida si las contraseñas son iguales
                if (txtContra.Text != txtRepetirContra.Text)
                {
                    throw new ContraseñasDiferentes();
                }

                Usuario us = new Usuario() //intancio el usuario
                {
                    USUARIO1 = txtUsuario.Text,
                    CONTRA = CryptographyService.HashPassword(txtContra.Text)
                };

                //se lo paso a BLL
                BLL.Servicio.usuario.UsuarioBLL.Instance.Insertar(us);
                
                
                Form f = new frmMensaje(null,null,"USUARIO",null);
                f.Show();

                #region
                txtUsuario.Clear();
                txtContra.Clear();
                txtRepetirContra.Clear();
                #endregion

            }
            catch (ContraseñasDiferentes ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch(DatosFaltantes ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception)
            {
                throw;
            }

        }

        private void frmCrearUsuario_Load(object sender, EventArgs e)
        {
            Update(this);
            helpProvider1.HelpNamespace = Application.StartupPath + "/Usuario.chm";
            helpProvider1.SetHelpString(this, "Crear");
            helpProvider1.SetHelpKeyword(this, "Crear");
            helpProvider1.SetHelpNavigator(this, HelpNavigator.KeywordIndex);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

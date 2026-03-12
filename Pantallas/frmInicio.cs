using DAL.DAO;
using SL.BLL.ExcepcionBLL;
using SL.Cryptoghapy;
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
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;           
        }

        // u sigal_user p 12345 h 827ccb0eea8a706c4c34a16891f84e7b
        private void btnInicioSesion_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtUsuario.Text) || string.IsNullOrEmpty(txtContra.Text))
                {
                    throw new DatosFaltantes();
                }
                Usuario us = new Usuario()
                {

                    USUARIO1 = txtUsuario.Text,
                    CONTRA = CryptographyService.HashPassword(txtContra.Text)
                };

                
                //buscar el usuario para iniciar sesión, si existe y si son validos los datos ingresados
                Usuario inicio = BLL.Servicio.usuario.UsuarioServicio.Instance.Obtener(us);

                if (inicio != null) //tiene acceso
                {
                    UsuarioActivo.NombreDeUsuario = us.USUARIO1; //Asigno a mi clase static el id

                    //Buscar permisos de mi usuario
                    UsuarioPermiso usuarioPermiso = new UsuarioPermiso()
                    {
                        ID_USUARIO = inicio.ID_USUARIO
                    };
                    List<UsuarioPermiso> listaDePermisos =
                        BLL.Servicio.usuario.PermisoUsuarioServicio.Instance.ListaDePermisos(usuarioPermiso);

                        EvaluarPermisos(listaDePermisos);

                    #region
                    txtContra.Clear();
                    txtUsuario.Clear();
                    #endregion
                    this.Hide(); //ocultar este formulario
                    Form nuev = new frmInicioSigal();
                    nuev.Show();
                }
            }
            catch (DatosFaltantes ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                txtContra.Clear();
                MessageBox.Show(ex.Message);
            }
        }



        private void EvaluarPermisos(List<UsuarioPermiso> list)
        {
            //Asignarlo a mi clase UsuarioActivo statica
            foreach (var permiso in list)
            {
                switch (permiso.ID_PERMISO)
                {
                    case 1:
                        UsuarioActivo.PermisoAlquiler = permiso.ID_PERMISO;
                        break;

                    case 2:
                        UsuarioActivo.PermisoLibro = permiso.ID_PERMISO;
                        break;

                    case 3:
                        UsuarioActivo.PermisoCliente = permiso.ID_PERMISO;
                        break;

                    case 4:
                        UsuarioActivo.PermisoUsuario = permiso.ID_PERMISO;
                        break;

                    default:
                        // Manejar casos no esperados
                        break;
                }
            }
        }

        
        private void frmInicio_Load(object sender, EventArgs e)
        {
           
            
        }
    }
}

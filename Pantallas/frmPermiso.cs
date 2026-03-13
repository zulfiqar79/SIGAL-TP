using BLL.BusinessLogic.usuario;
using Domain;
using Domain.Composite;
using Pantallas.Observer;
using SL.BLL.ExcepcionBLL;
using SL.Servicios.Extension;
using System;
using System.Windows.Forms;

namespace Pantallas
{
    public partial class frmPermiso : Form, IFormObserver
    {
        public frmPermiso()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Permisos";
        }

        public void Update(Form form)
        {
            try
            {
                lblObligatorio.Text = "(*) Obligatorio".Traducir();
                lblUsuario.Text = "Usuario*".Traducir();

                gbUsuario.Text = "USUARIO".Traducir();
                gbGestionAlquiler.Text = "GESTIÓN ALQUILER".Traducir();
                gbGestionCliente.Text = "GESTIÓN CLIENTE".Traducir();
                gbGestionLibro.Text = "GESTIÓN LIBRO".Traducir();

                cbAlquiler.Text = "GESTIÓN ALQUILER".Traducir();
                cbLibro.Text = "GESTIÓN LIBRO".Traducir();
                cbCliente.Text = "GESTIÓN CLIENTE".Traducir();
                cbUsuario.Text = "USUARIO".Traducir();

                btnConfirmar.Text = "CONFIRMAR".Traducir();
            }
            catch (Exception ex)
            {
                LoggerService.WriteLog(ex.Message);
                MessageBox.Show(ex.Message);
            }
        }

        private void frmPermiso_Load(object sender, EventArgs e)
        {
            Update(this);
            helpProvider1.HelpNamespace = Application.StartupPath + "/Usuario.chm";
            helpProvider1.SetHelpString(this, "Permiso");
            helpProvider1.SetHelpKeyword(this, "Permiso");
            helpProvider1.SetHelpNavigator(this, HelpNavigator.KeywordIndex);
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtUsuario.Text))
                    throw new DatosFaltantes();

                bool alq = cbAlquiler.Checked;
                bool lib = cbLibro.Checked;
                bool cli = cbCliente.Checked;
                bool usu = cbUsuario.Checked;

                // Verificar que al menos un permiso esté seleccionado
                if (!alq && !lib && !cli && !usu)
                    throw new DatosFaltantes();

                // Combinaciones inválidas (comportamiento preservado del sistema original)
                bool combinacionInvalida =
                    (!alq && lib && !cli && usu) ||   // solo Libro+Usuario
                    (alq && !lib && cli && !usu) ||   // solo Alquiler+Cliente
                    (alq && lib && cli && !usu) ||    // Alquiler+Libro+Cliente sin Usuario
                    (alq && lib && !cli && usu) ||    // Alquiler+Libro+Usuario sin Cliente
                    (alq && !lib && cli && usu) ||    // Alquiler+Cliente+Usuario sin Libro
                    (!alq && lib && cli && usu);      // Libro+Cliente+Usuario sin Alquiler

                if (combinacionInvalida)
                    throw new ErrorPermiso();

                // Buscar usuario
                Usuario usuario = new Usuario { USUARIO1 = txtUsuario.Text };
                Usuario existeUsuario = BLL.Servicio.usuario.UsuarioBLL.Instance.ObtenerUsuarioPermiso(usuario);
                int idUsuario = existeUsuario.ID_USUARIO;
                string userCreacion = UsuarioActivo.NombreDeUsuario;

                // Construir componente Composite con las Patentes seleccionadas
                FamiliaPermiso seleccion = new FamiliaPermiso("Seleccion");
                if (alq) seleccion.Agregar(CatalogoPermisos.Alquiler);
                if (lib) seleccion.Agregar(CatalogoPermisos.Libro);
                if (cli) seleccion.Agregar(CatalogoPermisos.Cliente);
                if (usu) seleccion.Agregar(CatalogoPermisos.Usuario);

                // Asignar permisos usando el patrón Composite
                BLL.Servicio.usuario.PermisoUsuarioBLL.Instance.AsignarPermisos(idUsuario, seleccion, userCreacion);

                // Mostrar mensaje de confirmación preservando los códigos originales
                string codigoMensaje = DeterminarCodigoMensaje(alq, lib, cli, usu);
                Form f = new frmMensaje(null, null, codigoMensaje, null);
                f.Show();

                // Limpiar formulario
                txtUsuario.Clear();
                cbAlquiler.Checked = false;
                cbLibro.Checked = false;
                cbCliente.Checked = false;
                cbUsuario.Checked = false;
            }
            catch (ErrorPermiso ex)
            {
                LoggerService.WriteLog(ex.Message);
                MessageBox.Show(ex.Message);
            }
            catch (UsuarioInexistente ex)
            {
                LoggerService.WriteLog(ex.Message);
                MessageBox.Show(ex.Message);
            }
            catch (DatosFaltantes ex)
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

        /// <summary>
        /// Determina el código de mensaje a mostrar según los permisos seleccionados,
        /// preservando la correspondencia original con frmMensaje.
        /// </summary>
        private string DeterminarCodigoMensaje(bool alq, bool lib, bool cli, bool usu)
        {
            if (alq && lib && cli && usu) return "PERMISO3"; // Administrador (todos)
            if (alq && lib)              return "PERMISO1"; // Gestión Alquiler + Libro
            if (cli && usu)              return "PERMISO2"; // Gestión Cliente + Usuario
            if (alq && usu)              return "PERMISO8"; // Gestión Alquiler + Usuario
            if (lib && cli)              return "PERMISO9"; // Gestión Libro + Cliente
            if (alq)                     return "PERMISO4"; // Solo Gestión Alquiler
            if (lib)                     return "PERMISO5"; // Solo Gestión Libro
            if (cli)                     return "PERMISO6"; // Solo Gestión Cliente
            // usu == true (única combinación válida restante)
            return "PERMISO7"; // Solo Gestión Usuario
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}


using Catel.Services;
using Pantallas.Observer;
using SL.BLL;
using SL.Servicios.Extension;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.Entity.Core.EntityClient;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pantallas
{
    public partial class frmInicioSigal : Form
    {
        //lista para observer
        private static List<IFormObserver> formularios = new List<IFormObserver>();
        public frmInicioSigal()
        {
            InitializeComponent();
            ocultarSubMenu();
            this.StartPosition = FormStartPosition.CenterScreen;

            this.FormClosing += FrmInicioSigal_FormClosing; // se suscribe al evento para cerrar tdo
        }
        
        private void FrmInicioSigal_FormClosing(object sender, FormClosingEventArgs e)
        {
            //ejecuta cuando el formulario esta cerrando
            Application.Exit(); // Cierra la aplicación por completo
        }

        #region
        private void ocultarSubMenu() //ocualtar paneles submenu
        {
            panelLibroSubMenu.Visible = false;
            panelAlquilerSubMenu.Visible = false;
            panelClienteSubMenu.Visible = false;
            panelIdiomaSubMenu.Visible = false;
            panelUsuarioSubMenu.Visible = false;
        }
        private void subMenu()
        {
            if (panelAlquilerSubMenu.Visible == true)
            {
                panelAlquilerSubMenu.Visible = false;
            }
            if (panelClienteSubMenu.Visible == true)
            {
                panelClienteSubMenu.Visible = false;
            }
            if (panelLibroSubMenu.Visible == true)
            {
                panelLibroSubMenu.Visible = false;
            }
            if (panelIdiomaSubMenu.Visible == true)
            {
                panelIdiomaSubMenu.Visible = false;
            }
            if (panelUsuarioSubMenu.Visible == true)
            {
                panelUsuarioSubMenu.Visible = false;
            }
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                ocultarSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }
        #endregion
        private void btnGestionCliente_Click(object sender, EventArgs e)
        {
        }

        private void btnRegistrarCliente_Click(object sender, EventArgs e)
        {            
            ocultarSubMenu();
        }

        private void btnConsultarCliente_Click(object sender, EventArgs e)
        {
            ocultarSubMenu();
        }

        private void btnEliminarCliente_Click(object sender, EventArgs e)
        {
            ocultarSubMenu();
        }

      

        private void btnCrear_Click(object sender, EventArgs e)
        {
            abrirFormularios(new frmCrearUsuario());
        }

        #region Mostrar formularios
        private Form formularioActivo = null;
        private void abrirFormularios(Form formularioHijo)
        {
            if (formularioActivo != null)
            {
                formularioActivo.Close();
            }
            formularioActivo = formularioHijo;
            formularioHijo.TopLevel = false;
            formularioHijo.Dock = DockStyle.Fill;
            panelContenedor.Controls.Add(formularioHijo);
            panelContenedor.Tag = formularioHijo;
            formularioHijo.BringToFront();
            formularioHijo.Show();
        }

        #endregion

        private void btnGestionAlquiler_Click_1(object sender, EventArgs e)
        {
            showSubMenu(panelAlquilerSubMenu);
            abrirFormularios( new frmNegro());
        }

        private void btnGestionLibro_Click_1(object sender, EventArgs e)
        {
            showSubMenu(panelLibroSubMenu);
            abrirFormularios(new frmNegro());
        }

        private void btnGestionCliente_Click_1(object sender, EventArgs e)
        {
            showSubMenu(panelClienteSubMenu);
            abrirFormularios(new frmNegro());
        }

        private void btnUsuarios_Click_1(object sender, EventArgs e)
        {
            showSubMenu(panelUsuarioSubMenu);
            abrirFormularios(new frmNegro());
        }

        private void btnIdioma_Click_1(object sender, EventArgs e)
        {
            showSubMenu(panelIdiomaSubMenu);
            abrirFormularios(new frmNegro());
        }

        private void btnCrear_Click_1(object sender, EventArgs e)
        {
            var formUsuario = new frmCrearUsuario();
            formUsuario.Show();
            formularios.Add(formUsuario);
        }

        private void btnConsultarCliente_Click_1(object sender, EventArgs e)
        {
            var formCliente = new frmConsultarCliente();
            formCliente.Show();
            formularios.Add(formCliente);
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            abrirFormularios(new frmNegro());
            var formPregunta = new frmPregunta();
            formPregunta.Show();
            ocultarSubMenu();
            formularios.Add(formPregunta);           

        }

        private void btnRegistrarCliente_Click_1(object sender, EventArgs e)
        {
            var crearCliente = new frmCrearCliente(); //Creo formulario
            crearCliente.Show();
            formularios.Add(crearCliente); //Lo agregos al patron observer, para evaluar el idioma
        }

        private void btnEliminarCliente_Click_1(object sender, EventArgs e)
        {
            var EliminarCliente = new frmEliminarCliente();
            EliminarCliente.Show();
            formularios.Add(EliminarCliente);
        }

        private void btnCargaLibro_Click(object sender, EventArgs e)
        {
            var formLibro = new frmCargaLibro();
            formLibro.Show();
            formularios.Add(formLibro);
        }

        private void btnLibroNoDevueltos_Click(object sender, EventArgs e)
        {
            var formAlquiler = new frmLibroAlquilado();
            formAlquiler.Show();
            formularios.Add(formAlquiler);
        }

        private void btnIniciarAlquiler_Click(object sender, EventArgs e)
        {
            var formAlquiler = new frmIniciarAlquiler();
            formAlquiler.Show();
            formularios.Add(formAlquiler);
        }

        private void btnDevolucion_Click(object sender, EventArgs e)
        {
            var formm = new frmDevolucionAlquiler();
            formm.Show();
            formularios.Add(formm);
        }

        private void btnAlquilerMes_Click(object sender, EventArgs e)
        {
            var formAlquiler = new frmAlquilerMes();
            formAlquiler.Show();
            formularios.Add(formAlquiler);
        }

        private void btnIngles_Click(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-US");

            Notify();

            Update(this);
        }

        private void btnEspañol_Click(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("es-AR");

            Notify();

            Update(this);
        }

        private void panelInferior_Paint(object sender, PaintEventArgs e)
        {
        }

        private void frmInicioSigal_Load(object sender, EventArgs e)
        {
            Update(this);
            
            if (UsuarioActivo.PermisoCliente != 3)
            {
                btnRegistrarCliente.Enabled=false;
                btnRegistrarCliente.BackColor = Color.Gray;
                btnConsultarCliente.Enabled = false;
                btnConsultarCliente.BackColor = Color.Gray;
                btnEliminarCliente.Enabled = false;
                btnEliminarCliente.BackColor = Color.Gray;
            }
            if(UsuarioActivo.PermisoUsuario != 4)
            {
                btnCrear.Enabled = false;
                btnCrear.BackColor = Color.Gray;
                btnPermiso.Enabled = false;
                btnPermiso.BackColor = Color.Gray;
                btnBackup.Enabled = false;
                btnBackup.BackColor = Color.Gray;
                btnRestaurarBackup.Enabled = false;
                btnRestaurarBackup.BackColor = Color.Gray;
            }
            if (UsuarioActivo.PermisoAlquiler != 1)
            {
                btnIniciarAlquiler.Enabled = false;
                btnRenovarAlquiler.Enabled = false;
                btnDevolucion.Enabled = false;
                btnAlquilerMes.Enabled = false;
                btnIniciarAlquiler.BackColor = Color.Gray;
                btnRenovarAlquiler.BackColor = Color.Gray;
                btnDevolucion.BackColor = Color.Gray;
                btnAlquilerMes.BackColor = Color.Gray;
            }
            if(UsuarioActivo.PermisoLibro != 2)
            {
                btnCargaLibro.Enabled=false;
                btnLibroNoDevueltos.Enabled = false;
                btnLibrosCargados.Enabled=false;
                btnCargaLibro.BackColor = Color.Gray;
                btnLibroNoDevueltos.BackColor = Color.Gray;
                btnLibrosCargados.BackColor = Color.Gray;
            }
            
        }

        public static void Detach(IFormObserver formulario)
        {
            formularios.Remove(formulario); //para que no se modifique en tiempo de ejecucion
        }
                      

        public void Notify() 
        { //Notifica en la lista 
           foreach(IFormObserver formulario in formularios)
            {
                formulario.Update(this); 
            }
        }

        public void Update(Form form) //Hace el cambio.
        {
            this.Text = "Sistema de Información para la Gestión de Alquileres de Libros".Traducir();
            btnGestionAlquiler.Text = "GESTION ALQUILER".Traducir();
            btnGestionLibro.Text = "GESTION LIBRO".Traducir();
            btnGestionCliente.Text = "GESTION CLIENTE".Traducir();
            btnUsuarios.Text = "USUARIOS".Traducir();
            btnIdioma.Text = "IDIOMA".Traducir();
            btnCerrarSesion.Text = "CERRAR SESION".Traducir();

            btnIniciarAlquiler.Text = "INICIAR ALQUILER".Traducir();
            btnRenovarAlquiler.Text = "RENOVAR ALQUILER".Traducir();
            btnDevolucion.Text = "REGISTRAR DEVOLUCION".Traducir();
            btnAlquilerMes.Text = "ALQUILER DEL MES".Traducir();

            btnCargaLibro.Text = "CARGAR LIBRO".Traducir();
            btnLibroNoDevueltos.Text = "LIBROS ALQUILADOS".Traducir();

            btnRegistrarCliente.Text = "REGISTRAR".Traducir();
            btnEliminarCliente.Text = "ELIMINAR".Traducir();
            btnConsultarCliente.Text = "CONSULTAR".Traducir();
            btnLibrosCargados.Text = "LIBROS CARGADOS".Traducir();
            btnPermiso.Text = "PERMISO".Traducir();

            btnCrear.Text = "CREAR".Traducir();
            btnBackup.Text = "BACKUP".Traducir();
            btnRestaurarBackup.Text = "RESTAURAR BACKUP".Traducir();
        }

        private void btnRenovarAlquiler_Click(object sender, EventArgs e)
        {
            var formm = new frmRenovarAlquiler();
            formm.Show();
            formularios.Add(formm);
        }

        private void btnLibrosCargados_Click(object sender, EventArgs e)
        {
            var formm = new frmLibrosCargados();
            formm.Show();
            formularios.Add(formm);
        }

        private void btnPermiso_Click(object sender, EventArgs e)
        {
            var formm = new frmPermiso();
            formm.Show();
            ocultarSubMenu();
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            using (var saveDialog = new SaveFileDialog())
            {
                saveDialog.Title = "Guardar backup de base de datos".Traducir();
                saveDialog.Filter = "Backup SQL Server (*.bak)|*.bak";
                saveDialog.FileName = "backup_" + DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".bak";

                if (saveDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        BackupBLL servicio = new BackupBLL();
                        servicio.RealizarBackup(saveDialog.FileName);

                        MessageBox.Show("Backup realizado correctamente.".Traducir() + "\n" + saveDialog.FileName,
                            "Backup", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al realizar el backup: ".Traducir() + ex.Message,
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnRestaurarBackup_Click(object sender, EventArgs e)
        {
            using (var openDialog = new OpenFileDialog())
            {
                openDialog.Title = "Seleccionar archivo de backup".Traducir();
                openDialog.Filter = "Backup SQL Server (*.bak)|*.bak";

                if (openDialog.ShowDialog() != DialogResult.OK) return;

                string backupPath = openDialog.FileName;

                if (MessageBox.Show("¿Confirma que desea restaurar la base de datos? Se perderán los datos actuales.".Traducir(),
                    "Confirmar restauración".Traducir(), MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes) return;

                try
                {
                    string efConnectionString = ConfigurationManager.ConnectionStrings["base_sigalEntities"].ConnectionString;
                    var efBuilder = new EntityConnectionStringBuilder(efConnectionString);
                    var sqlBuilder = new System.Data.SqlClient.SqlConnectionStringBuilder(efBuilder.ProviderConnectionString);
                    string rawDatabaseName = sqlBuilder.InitialCatalog;
                    if (!System.Text.RegularExpressions.Regex.IsMatch(rawDatabaseName, @"^[\w\-\. ]+$"))
                    {
                        MessageBox.Show("El nombre de la base de datos contiene caracteres inválidos.".Traducir(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    string quotedDatabaseName = new System.Data.SqlClient.SqlCommandBuilder().QuoteIdentifier(rawDatabaseName);
                    sqlBuilder.InitialCatalog = "master";
                    using (var connection = new SqlConnection(sqlBuilder.ConnectionString))
                    {
                        connection.Open();
                        string query = "ALTER DATABASE " + quotedDatabaseName + " SET SINGLE_USER WITH ROLLBACK IMMEDIATE; " +
                                       "RESTORE DATABASE " + quotedDatabaseName + " FROM DISK = @backupPath WITH REPLACE; " +
                                       "ALTER DATABASE " + quotedDatabaseName + " SET MULTI_USER;";
                        using (var command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@backupPath", backupPath);
                            command.CommandTimeout = 300;
                            command.ExecuteNonQuery();
                        }
                    }
                    MessageBox.Show("Base de datos restaurada correctamente.".Traducir(), "Restaurar Backup".Traducir(), MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al restaurar la base de datos: ".Traducir() + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}

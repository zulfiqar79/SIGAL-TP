using DAL.DAO;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Pantallas
{
    public partial class frmPermiso : Form, IFormObserver
    {
        public frmPermiso()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
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
            catch(Exception ex)
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
                if (String.IsNullOrEmpty(txtUsuario.Text))
                {
                    throw new DatosFaltantes();
                }

                if (cbAlquiler.Checked == true && cbLibro.Checked == true && cbCliente.Checked == false && cbUsuario.Checked == false)
                {
                    //Crear usuario, para validar que exista
                    Usuario usuario = new Usuario();
                    usuario.USUARIO1 = txtUsuario.Text;

                    //Se lo paso a la BLL para que valide si existe
                    Usuario existeUsuario = BLL.Servicio.usuario.UsuarioServicio.Instance.ObtenerUsuarioPermiso(usuario);
                    //obtengo el ID del usuario
                    int ID_USUARIO = existeUsuario.ID_USUARIO;

                    //Eliminar permisos de mi usuario
                    UsuarioPermiso usuarioEliminar = new UsuarioPermiso()
                    {
                        ID_USUARIO = ID_USUARIO
                    };

                    string nomUsu = UsuarioActivo.NombreDeUsuario;
                    

                    BLL.Servicio.usuario.PermisoUsuarioServicio.Instance.Eliminar(usuarioEliminar);
                    //Creo objeto Permiso usuario con el ID del usuario
                    UsuarioPermiso usuarioPermiso = new UsuarioPermiso()
                    {
                        ID_USUARIO = ID_USUARIO, //Asigno ID encontrado
                        ID_PERMISO = 13,
                        USER_CREACION = nomUsu
                    };
                    //Creo objeto Permiso usuario con el ID del usuario
                    UsuarioPermiso usuarioPermiso2 = new UsuarioPermiso()
                    {
                        ID_USUARIO = ID_USUARIO ,//Asigno ID encontrado
                        ID_PERMISO=14,
                        USER_CREACION = nomUsu
                    };
                    //podría cargar 
                    BLL.Servicio.usuario.PermisoUsuarioServicio.Instance.Insertar(usuarioPermiso);
                    BLL.Servicio.usuario.PermisoUsuarioServicio.Instance.Insertar(usuarioPermiso2);

                    Form f = new frmMensaje(null, null, "PERMISO1", null);
                    f.Show();

                    txtUsuario.Clear();
                    cbAlquiler.Checked = false;
                    cbLibro.Checked = false;
                    
                }
                if (cbCliente.Checked == true && cbUsuario.Checked == true && cbAlquiler.Checked == false && cbLibro.Checked == false)
                {
                    //Crear usuario, para validar que exista
                    Usuario usuario = new Usuario();
                    usuario.USUARIO1 = txtUsuario.Text;

                    //Se lo paso a la BLL para que valide si existe
                    Usuario existeUsuario = BLL.Servicio.usuario.UsuarioServicio.Instance.ObtenerUsuarioPermiso(usuario);
                    //obtengo el ID del usuario
                    int ID_USUARIO = existeUsuario.ID_USUARIO;

                    //Eliminar permisos de mi usuario
                    UsuarioPermiso usuarioEliminar = new UsuarioPermiso()
                    {
                        ID_USUARIO = ID_USUARIO
                    };
                    string nomUsu = UsuarioActivo.NombreDeUsuario;

                    BLL.Servicio.usuario.PermisoUsuarioServicio.Instance.Eliminar(usuarioEliminar);

                    //Creo objeto Permiso usuario con el ID del usuario
                    UsuarioPermiso usuarioPermiso = new UsuarioPermiso()
                    {
                        ID_USUARIO = ID_USUARIO, //Asigno ID encontrado
                        ID_PERMISO = 15,
                        USER_CREACION = nomUsu
                    };
                    //Creo objeto Permiso usuario con el ID del usuario
                    UsuarioPermiso usuarioPermiso2 = new UsuarioPermiso()
                    {
                        ID_USUARIO = ID_USUARIO,//Asigno ID encontrado
                        ID_PERMISO = 16,
                        USER_CREACION = nomUsu
                    };
                    //podría cargar 
                    BLL.Servicio.usuario.PermisoUsuarioServicio.Instance.Insertar(usuarioPermiso);
                    BLL.Servicio.usuario.PermisoUsuarioServicio.Instance.Insertar(usuarioPermiso2);

                    Form f = new frmMensaje(null, null, "PERMISO2", null);
                    f.Show();

                    txtUsuario.Clear();
                    cbCliente.Checked = false;
                    cbUsuario.Checked = false;
                }
                if (cbCliente.Checked == true && cbUsuario.Checked == true && cbAlquiler.Checked == true && cbLibro.Checked == true)
                {
                    //Crear usuario, para validar que exista
                    Usuario usuario = new Usuario();
                    usuario.USUARIO1 = txtUsuario.Text;

                    //Se lo paso a la BLL para que valide si existe
                    Usuario existeUsuario = BLL.Servicio.usuario.UsuarioServicio.Instance.ObtenerUsuarioPermiso(usuario);
                    //obtengo el ID del usuario
                    int ID_USUARIO = existeUsuario.ID_USUARIO;

                    //Eliminar permisos de mi usuario
                    UsuarioPermiso usuarioEliminar = new UsuarioPermiso()
                    {
                        ID_USUARIO = ID_USUARIO
                    };
                    string nomUsu = UsuarioActivo.NombreDeUsuario;

                    BLL.Servicio.usuario.PermisoUsuarioServicio.Instance.Eliminar(usuarioEliminar);

                    //Creo objeto Permiso usuario con el ID del usuario
                    UsuarioPermiso usuarioPermiso = new UsuarioPermiso()
                    {
                        ID_USUARIO = ID_USUARIO, //Asigno ID encontrado
                        ID_PERMISO = 13,
                        USER_CREACION = nomUsu
                    };
                    //Creo objeto Permiso usuario con el ID del usuario
                    UsuarioPermiso usuarioPermiso2 = new UsuarioPermiso()
                    {
                        ID_USUARIO = ID_USUARIO,//Asigno ID encontrado
                        ID_PERMISO = 14,
                        USER_CREACION = nomUsu
                    };
                    UsuarioPermiso usuarioPermiso3= new UsuarioPermiso()
                    {
                        ID_USUARIO = ID_USUARIO, //Asigno ID encontrado
                        ID_PERMISO = 15,
                        USER_CREACION = nomUsu
                    };
                    //Creo objeto Permiso usuario con el ID del usuario
                    UsuarioPermiso usuarioPermiso4= new UsuarioPermiso()
                    {
                        ID_USUARIO = ID_USUARIO,//Asigno ID encontrado
                        ID_PERMISO = 16,
                        USER_CREACION = nomUsu
                    };
                    //podría cargar 
                    BLL.Servicio.usuario.PermisoUsuarioServicio.Instance.Insertar(usuarioPermiso);
                    BLL.Servicio.usuario.PermisoUsuarioServicio.Instance.Insertar(usuarioPermiso2);
                    BLL.Servicio.usuario.PermisoUsuarioServicio.Instance.Insertar(usuarioPermiso3);
                    BLL.Servicio.usuario.PermisoUsuarioServicio.Instance.Insertar(usuarioPermiso4);

                    Form f = new frmMensaje(null, null, "PERMISO3", null);
                    f.Show();

                    txtUsuario.Clear();
                    cbAlquiler.Checked = false;
                    cbLibro.Checked = false;
                    cbCliente.Checked = false;
                    cbUsuario.Checked = false;
                }
                if (cbAlquiler.Checked == true && cbLibro.Checked == false && cbCliente.Checked == false && cbUsuario.Checked == false)
                {
                    //Crear usuario, para validar que exista
                    Usuario usuario = new Usuario();
                    usuario.USUARIO1 = txtUsuario.Text;

                    //Se lo paso a la BLL para que valide si existe
                    Usuario existeUsuario = BLL.Servicio.usuario.UsuarioServicio.Instance.ObtenerUsuarioPermiso(usuario);
                    //obtengo el ID del usuario
                    int ID_USUARIO = existeUsuario.ID_USUARIO;

                    //Eliminar permisos de mi usuario
                    UsuarioPermiso usuarioEliminar = new UsuarioPermiso()
                    {
                        ID_USUARIO = ID_USUARIO
                    };

                    string nomUsu = UsuarioActivo.NombreDeUsuario;


                    BLL.Servicio.usuario.PermisoUsuarioServicio.Instance.Eliminar(usuarioEliminar);
                    //Creo objeto Permiso usuario con el ID del usuario
                    UsuarioPermiso usuarioPermiso = new UsuarioPermiso()
                    {
                        ID_USUARIO = ID_USUARIO, //Asigno ID encontrado
                        ID_PERMISO = 13,
                        USER_CREACION = nomUsu
                    };
                    
                    //podría cargar 
                    BLL.Servicio.usuario.PermisoUsuarioServicio.Instance.Insertar(usuarioPermiso);

                    Form f = new frmMensaje(null, null, "PERMISO4", null);
                    f.Show();

                    txtUsuario.Clear();
                    cbAlquiler.Checked = false;
                    cbLibro.Checked = false;
                }
                if (cbAlquiler.Checked == false && cbLibro.Checked == true && cbCliente.Checked == false && cbUsuario.Checked == false)
                {
                    //Crear usuario, para validar que exista
                    Usuario usuario = new Usuario();
                    usuario.USUARIO1 = txtUsuario.Text;

                    //Se lo paso a la BLL para que valide si existe
                    Usuario existeUsuario = BLL.Servicio.usuario.UsuarioServicio.Instance.ObtenerUsuarioPermiso(usuario);
                    //obtengo el ID del usuario
                    int ID_USUARIO = existeUsuario.ID_USUARIO;

                    //Eliminar permisos de mi usuario
                    UsuarioPermiso usuarioEliminar = new UsuarioPermiso()
                    {
                        ID_USUARIO = ID_USUARIO
                    };

                    string nomUsu = UsuarioActivo.NombreDeUsuario;


                    BLL.Servicio.usuario.PermisoUsuarioServicio.Instance.Eliminar(usuarioEliminar);
                    //Creo objeto Permiso usuario con el ID del usuario
                    UsuarioPermiso usuarioPermiso = new UsuarioPermiso()
                    {
                        ID_USUARIO = ID_USUARIO, //Asigno ID encontrado
                        ID_PERMISO = 14,
                        USER_CREACION = nomUsu
                    };
                    //podría cargar 
                    BLL.Servicio.usuario.PermisoUsuarioServicio.Instance.Insertar(usuarioPermiso);

                    Form f = new frmMensaje(null, null, "PERMISO5", null);
                    f.Show();

                    txtUsuario.Clear();
                    cbAlquiler.Checked = false;
                }
                if (cbAlquiler.Checked == false && cbLibro.Checked == false && cbCliente.Checked == true && cbUsuario.Checked == true)
                {
                    //Crear usuario, para validar que exista
                    Usuario usuario = new Usuario();
                    usuario.USUARIO1 = txtUsuario.Text;

                    //Se lo paso a la BLL para que valide si existe
                    Usuario existeUsuario = BLL.Servicio.usuario.UsuarioServicio.Instance.ObtenerUsuarioPermiso(usuario);
                    //obtengo el ID del usuario
                    int ID_USUARIO = existeUsuario.ID_USUARIO;

                    //Eliminar permisos de mi usuario
                    UsuarioPermiso usuarioEliminar = new UsuarioPermiso()
                    {
                        ID_USUARIO = ID_USUARIO
                    };

                    string nomUsu = UsuarioActivo.NombreDeUsuario;


                    BLL.Servicio.usuario.PermisoUsuarioServicio.Instance.Eliminar(usuarioEliminar);
                    //Creo objeto Permiso usuario con el ID del usuario
                    UsuarioPermiso usuarioPermiso2 = new UsuarioPermiso()
                    {
                        ID_USUARIO = ID_USUARIO,//Asigno ID encontrado
                        ID_PERMISO = 15,
                        USER_CREACION = nomUsu
                    };
                    //podría cargar 
                    BLL.Servicio.usuario.PermisoUsuarioServicio.Instance.Insertar(usuarioPermiso2);

                    Form f = new frmMensaje(null, null, "PERMISO6", null);
                    f.Show();

                    txtUsuario.Clear();
                    cbCliente.Checked = false;
                }
                if (cbAlquiler.Checked == false && cbLibro.Checked == false && cbCliente.Checked == false && cbUsuario.Checked == true)
                {
                    //Crear usuario, para validar que exista
                    Usuario usuario = new Usuario();
                    usuario.USUARIO1 = txtUsuario.Text;

                    //Se lo paso a la BLL para que valide si existe
                    Usuario existeUsuario = BLL.Servicio.usuario.UsuarioServicio.Instance.ObtenerUsuarioPermiso(usuario);
                    //obtengo el ID del usuario
                    int ID_USUARIO = existeUsuario.ID_USUARIO;

                    //Eliminar permisos de mi usuario
                    UsuarioPermiso usuarioEliminar = new UsuarioPermiso()
                    {
                        ID_USUARIO = ID_USUARIO
                    };

                    string nomUsu = UsuarioActivo.NombreDeUsuario;


                    BLL.Servicio.usuario.PermisoUsuarioServicio.Instance.Eliminar(usuarioEliminar);

                    //Creo objeto Permiso usuario con el ID del usuario
                    UsuarioPermiso usuarioPermiso2 = new UsuarioPermiso()
                    {
                        ID_USUARIO = ID_USUARIO,//Asigno ID encontrado
                        ID_PERMISO = 16,
                        USER_CREACION = nomUsu
                    };
                    //podría cargar 
                    BLL.Servicio.usuario.PermisoUsuarioServicio.Instance.Insertar(usuarioPermiso2);

                    Form f = new frmMensaje(null, null, "PERMISO7", null);
                    f.Show();

                    txtUsuario.Clear();
                    cbUsuario.Checked = false;
                }
                if (cbAlquiler.Checked == true && cbLibro.Checked == false && cbCliente.Checked == false && cbUsuario.Checked == true)
                {
                    //Crear usuario, para validar que exista
                    Usuario usuario = new Usuario();
                    usuario.USUARIO1 = txtUsuario.Text;

                    //Se lo paso a la BLL para que valide si existe
                    Usuario existeUsuario = BLL.Servicio.usuario.UsuarioServicio.Instance.ObtenerUsuarioPermiso(usuario);
                    //obtengo el ID del usuario
                    int ID_USUARIO = existeUsuario.ID_USUARIO;

                    //Eliminar permisos de mi usuario
                    UsuarioPermiso usuarioEliminar = new UsuarioPermiso()
                    {
                        ID_USUARIO = ID_USUARIO
                    };

                    string nomUsu = UsuarioActivo.NombreDeUsuario;


                    BLL.Servicio.usuario.PermisoUsuarioServicio.Instance.Eliminar(usuarioEliminar);
                    //Creo objeto Permiso usuario con el ID del usuario
                    UsuarioPermiso usuarioPermiso = new UsuarioPermiso()
                    {
                        ID_USUARIO = ID_USUARIO, //Asigno ID encontrado
                        ID_PERMISO = 13,
                        USER_CREACION = nomUsu
                    };
                    //Creo objeto Permiso usuario con el ID del usuario
                    UsuarioPermiso usuarioPermiso2 = new UsuarioPermiso()
                    {
                        ID_USUARIO = ID_USUARIO,//Asigno ID encontrado
                        ID_PERMISO = 16,
                        USER_CREACION = nomUsu
                    };
                    //podría cargar 
                    BLL.Servicio.usuario.PermisoUsuarioServicio.Instance.Insertar(usuarioPermiso);
                    BLL.Servicio.usuario.PermisoUsuarioServicio.Instance.Insertar(usuarioPermiso2);

                    Form f = new frmMensaje(null, null, "PERMISO8", null);
                    f.Show();

                    txtUsuario.Clear();
                    cbAlquiler.Checked = false;
                    cbUsuario.Checked = false;
                }
                if (cbAlquiler.Checked == false && cbLibro.Checked == true && cbCliente.Checked == true && cbUsuario.Checked == false)
                {
                    //Crear usuario, para validar que exista
                    Usuario usuario = new Usuario();
                    usuario.USUARIO1 = txtUsuario.Text;

                    //Se lo paso a la BLL para que valide si existe
                    Usuario existeUsuario = BLL.Servicio.usuario.UsuarioServicio.Instance.ObtenerUsuarioPermiso(usuario);
                    //obtengo el ID del usuario
                    int ID_USUARIO = existeUsuario.ID_USUARIO;

                    //Eliminar permisos de mi usuario
                    UsuarioPermiso usuarioEliminar = new UsuarioPermiso()
                    {
                        ID_USUARIO = ID_USUARIO
                    };

                    string nomUsu = UsuarioActivo.NombreDeUsuario;


                    BLL.Servicio.usuario.PermisoUsuarioServicio.Instance.Eliminar(usuarioEliminar);
                    //Creo objeto Permiso usuario con el ID del usuario
                    UsuarioPermiso usuarioPermiso = new UsuarioPermiso()
                    {
                        ID_USUARIO = ID_USUARIO, //Asigno ID encontrado
                        ID_PERMISO = 14,
                        USER_CREACION = nomUsu
                    };
                    //Creo objeto Permiso usuario con el ID del usuario
                    UsuarioPermiso usuarioPermiso2 = new UsuarioPermiso()
                    {
                        ID_USUARIO = ID_USUARIO,//Asigno ID encontrado
                        ID_PERMISO = 15,
                        USER_CREACION = nomUsu
                    };
                    //podría cargar 
                    BLL.Servicio.usuario.PermisoUsuarioServicio.Instance.Insertar(usuarioPermiso);
                    BLL.Servicio.usuario.PermisoUsuarioServicio.Instance.Insertar(usuarioPermiso2);

                    Form f = new frmMensaje(null, null, "PERMISO9", null);
                    f.Show();

                    txtUsuario.Clear();
                    cbCliente.Checked = false;
                    cbLibro.Checked = false;
                }
                if (cbAlquiler.Checked == false && cbLibro.Checked == true && cbCliente.Checked == false && cbUsuario.Checked == true)
                {
                    throw new ErrorPermiso();
                }
                if (cbAlquiler.Checked == true && cbLibro.Checked == false && cbCliente.Checked == true && cbUsuario.Checked == false)
                {
                    throw new ErrorPermiso();
                }
                if (cbAlquiler.Checked == true && cbLibro.Checked == true && cbCliente.Checked == true && cbUsuario.Checked == false)
                {
                    throw new ErrorPermiso();
                }
                if (cbAlquiler.Checked == true && cbLibro.Checked == true && cbCliente.Checked == false && cbUsuario.Checked == true)
                {
                    throw new ErrorPermiso();
                }
                if (cbAlquiler.Checked == true && cbLibro.Checked == false && cbCliente.Checked == true && cbUsuario.Checked == true)
                {
                    throw new ErrorPermiso();
                }
                if (cbAlquiler.Checked == false && cbLibro.Checked == true && cbCliente.Checked == true && cbUsuario.Checked == true)
                {
                    throw new ErrorPermiso();
                }


            }
            catch(ErrorPermiso ex)
            {
                LoggerService.WriteLog(ex.Message);
                MessageBox.Show(ex.Message);
            }
            catch(UsuarioInexistente ex)
            {
                LoggerService.WriteLog(ex.Message);
                MessageBox.Show(ex.Message);
            }
            catch(DatosFaltantes ex)
            {
                LoggerService.WriteLog(ex.Message);
                MessageBox.Show(ex.Message);
            }
            catch(Exception ex)
            {
                LoggerService.WriteLog(ex.Message);
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

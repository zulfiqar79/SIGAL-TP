using DAL.DAO;
using SL.Servicios.Extension;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pantallas
{
    public partial class frmMensaje : Form
    {
        public Libro l;
        public Cliente c;
        public Alquiler a;
        string tipo;
        public frmMensaje(Libro libr, Cliente clien, string tipo, Alquiler alquiler)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
             l = libr;
             c = clien;
            a = alquiler;
            this.tipo = tipo;
        }

        private void formAlquilerRegistrado_Load(object sender, EventArgs e)
        {
            if (tipo == "ALQUILER REGISTRADO")
            {
                lblTexto.Text = "El alquiler del libro:".Traducir() + l.TITULO_LIBRO;
                lblTexto2.Text = "al cliente con correo:".Traducir() + c.CORREO_CLIENTE;
                lblTexto3.Text ="se realizó. El número es:".Traducir() + a.ID_ALQUILER;
                ALQUILER.Text = "ALQUILER REGISTRADO".Traducir();
            }
            if(tipo == "ALQUILER RENOVADO")
            {
                lblTexto.Text = "El alquiler del cliente:".Traducir() + c.CORREO_CLIENTE;
                lblTexto2.Text = "se ha renovado con el libro:".Traducir() + l.TITULO_LIBRO;
                lblTexto3.Text="El número es:".Traducir() + a.ID_ALQUILER;
                ALQUILER.Text = "ALQUILER RENOVADO".Traducir();
            }
            if (tipo == "REGISTRAR DEVOLUCIÓN")
            {
                lblTexto.Text = "LA DEVOLUCIÓN SE HA REGISTRADO.".Traducir();
                lblTexto2.Text = "FECHA".Traducir();
                lblTexto3.Text = DateTime.Now.ToString();
                ALQUILER.Text = "DEVOLUCIÓN REGISTRADA".Traducir();
            }
            if (tipo == "USUARIO")
            {
                lblTexto.Text = "EL USUARIO SE HA CREADO".Traducir();
                lblTexto2.Text = "FECHA".Traducir();
                lblTexto3.Text = DateTime.Now.ToString();
                ALQUILER.Text = "USUARIO CREADO".Traducir();
            }
            if (tipo == "CLIENTE")
            {
                lblTexto.Text = "EL CLIENTE SE HA CREADO".Traducir();
                lblTexto2.Text = "FECHA".Traducir();
                lblTexto3.Text = DateTime.Now.ToString();
                ALQUILER.Text = "CLIENTE CREADO".Traducir();
            }
            if (tipo == "ELIMINAR CLIENTE")
            {
                lblTexto.Text = "EL CLIENTE CON CORREO:".Traducir() + c.CORREO_CLIENTE;
                lblTexto2.Text = "SE HA ELIMINADO".Traducir();
                lblTexto3.Text = "FECHA".Traducir() + DateTime.Now.ToString();
                ALQUILER.Text = "CLIENTE ELIMINADO".Traducir();
            }
            if(tipo == "PERMISO1")
            {
                lblTexto.Text = "El usuario indicado".Traducir();
                lblTexto2.Text = "tiene los permisos de".Traducir();
                lblTexto3.Text = "Gestión Alquiler y Gestión Libro".Traducir();
                ALQUILER.Text = "PERMISO ASIGNADO".Traducir();
            }
            if (tipo == "PERMISO2")
            {
                lblTexto.Text = "El usuario indicado".Traducir();
                lblTexto2.Text = "tiene los permisos de".Traducir();
                lblTexto3.Text = "Gestión Cliente y Gestión Usuario".Traducir();
                ALQUILER.Text = "PERMISO ASIGNADO".Traducir();
            }
            if (tipo == "PERMISO3")
            {
                lblTexto.Text = "El usuario indicado".Traducir();
                lblTexto2.Text = "tiene los permisos de".Traducir();
                lblTexto3.Text = "Administrador".Traducir();
                ALQUILER.Text = "PERMISO ASIGNADO".Traducir();
            }
            if (tipo == "PERMISO4")
            {
                lblTexto.Text = "El usuario indicado".Traducir();
                lblTexto2.Text = "tiene los permisos de".Traducir();
                lblTexto3.Text = "Gestión Alquiler".Traducir();
                ALQUILER.Text = "PERMISO ASIGNADO".Traducir();
            }
            if (tipo == "PERMISO5")
            {
                lblTexto.Text = "El usuario indicado".Traducir();
                lblTexto2.Text = "tiene los permisos de".Traducir();
                lblTexto3.Text = "Gestión Libro".Traducir();
                ALQUILER.Text = "PERMISO ASIGNADO".Traducir();
            }
            if (tipo == "PERMISO6")
            {
                lblTexto.Text = "El usuario indicado".Traducir();
                lblTexto2.Text = "tiene los permisos de".Traducir();
                lblTexto3.Text = "Gestión Cliente".Traducir();
                ALQUILER.Text = "PERMISO ASIGNADO".Traducir();
            }
            if (tipo == "PERMISO7")
            {
                lblTexto.Text = "El usuario indicado".Traducir();
                lblTexto2.Text = "tiene los permisos de".Traducir();
                lblTexto3.Text = "Gestión Usuario".Traducir();
                ALQUILER.Text = "PERMISO ASIGNADO".Traducir();
            }
            if (tipo == "PERMISO8")
            {
                lblTexto.Text = "El usuario indicado".Traducir();
                lblTexto2.Text = "tiene los permisos de".Traducir();
                lblTexto3.Text = "Gestión Alquiler y Gestión Usuario".Traducir();
                ALQUILER.Text = "PERMISO ASIGNADO".Traducir();
            }
            if (tipo == "PERMISO9")
            {
                lblTexto.Text = "El usuario indicado".Traducir();
                lblTexto2.Text = "tiene los permisos de".Traducir();
                lblTexto3.Text = "Gestión Cliente y Gestión Libro".Traducir();
                ALQUILER.Text = "PERMISO ASIGNADO".Traducir();
            }
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

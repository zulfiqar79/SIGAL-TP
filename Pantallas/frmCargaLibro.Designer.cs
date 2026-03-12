namespace Pantallas
{
    partial class frmCargaLibro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblObligatorio = new System.Windows.Forms.Label();
            this.gpSeleccionarExistente = new System.Windows.Forms.GroupBox();
            this.btnAutorConsulta = new System.Windows.Forms.Button();
            this.btnEditorialConsulta = new System.Windows.Forms.Button();
            this.gpDatoAutor = new System.Windows.Forms.GroupBox();
            this.lblNombreAU = new System.Windows.Forms.Label();
            this.lblNacimientoAU = new System.Windows.Forms.Label();
            this.txtNacimientoAutor = new System.Windows.Forms.TextBox();
            this.txtNombreAutor = new System.Windows.Forms.TextBox();
            this.lblApellidoAU = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.gpDatoEditorial = new System.Windows.Forms.GroupBox();
            this.lblNombreEDI = new System.Windows.Forms.Label();
            this.lblDireccionEDI = new System.Windows.Forms.Label();
            this.lblPaisEDI = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtNombreEditorial = new System.Windows.Forms.TextBox();
            this.txtPais = new System.Windows.Forms.TextBox();
            this.lblTelefonoEDI = new System.Windows.Forms.Label();
            this.txtTelefonoEditorial = new System.Windows.Forms.TextBox();
            this.gpDatoLibro = new System.Windows.Forms.GroupBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblISBN = new System.Windows.Forms.Label();
            this.lblContenido = new System.Windows.Forms.Label();
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.txtTituloLibro = new System.Windows.Forms.TextBox();
            this.txtContenido = new System.Windows.Forms.TextBox();
            this.lblAno = new System.Windows.Forms.Label();
            this.txtAno = new System.Windows.Forms.TextBox();
            this.btnCargarLibro = new System.Windows.Forms.Button();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.gpSeleccionarExistente.SuspendLayout();
            this.gpDatoAutor.SuspendLayout();
            this.gpDatoEditorial.SuspendLayout();
            this.gpDatoLibro.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Controls.Add(this.btnCerrar);
            this.groupBox1.Controls.Add(this.lblObligatorio);
            this.groupBox1.Controls.Add(this.gpSeleccionarExistente);
            this.groupBox1.Controls.Add(this.gpDatoAutor);
            this.groupBox1.Controls.Add(this.gpDatoEditorial);
            this.groupBox1.Controls.Add(this.gpDatoLibro);
            this.groupBox1.Controls.Add(this.btnCargarLibro);
            this.groupBox1.Location = new System.Drawing.Point(39, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(638, 430);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            // 
            // lblObligatorio
            // 
            this.lblObligatorio.AutoSize = true;
            this.lblObligatorio.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblObligatorio.Location = new System.Drawing.Point(17, 385);
            this.lblObligatorio.Name = "lblObligatorio";
            this.lblObligatorio.Size = new System.Drawing.Size(70, 13);
            this.lblObligatorio.TabIndex = 18;
            this.lblObligatorio.Text = "(*) Obligatorio";
            // 
            // gpSeleccionarExistente
            // 
            this.gpSeleccionarExistente.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gpSeleccionarExistente.Controls.Add(this.btnAutorConsulta);
            this.gpSeleccionarExistente.Controls.Add(this.btnEditorialConsulta);
            this.gpSeleccionarExistente.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.gpSeleccionarExistente.Location = new System.Drawing.Point(374, 212);
            this.gpSeleccionarExistente.Name = "gpSeleccionarExistente";
            this.gpSeleccionarExistente.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.gpSeleccionarExistente.Size = new System.Drawing.Size(200, 87);
            this.gpSeleccionarExistente.TabIndex = 17;
            this.gpSeleccionarExistente.TabStop = false;
            this.gpSeleccionarExistente.Text = "SELECCIONAR EXISTENTES";
            // 
            // btnAutorConsulta
            // 
            this.btnAutorConsulta.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAutorConsulta.Location = new System.Drawing.Point(14, 19);
            this.btnAutorConsulta.Name = "btnAutorConsulta";
            this.btnAutorConsulta.Size = new System.Drawing.Size(171, 23);
            this.btnAutorConsulta.TabIndex = 15;
            this.btnAutorConsulta.Text = "AUTOR";
            this.btnAutorConsulta.UseVisualStyleBackColor = true;
            this.btnAutorConsulta.Click += new System.EventHandler(this.btnAutorConsulta_Click);
            // 
            // btnEditorialConsulta
            // 
            this.btnEditorialConsulta.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEditorialConsulta.Location = new System.Drawing.Point(14, 50);
            this.btnEditorialConsulta.Name = "btnEditorialConsulta";
            this.btnEditorialConsulta.Size = new System.Drawing.Size(171, 23);
            this.btnEditorialConsulta.TabIndex = 16;
            this.btnEditorialConsulta.Text = "EDITORIAL";
            this.btnEditorialConsulta.UseVisualStyleBackColor = true;
            this.btnEditorialConsulta.Click += new System.EventHandler(this.btnEditorialConsulta_Click);
            // 
            // gpDatoAutor
            // 
            this.gpDatoAutor.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gpDatoAutor.Controls.Add(this.lblNombreAU);
            this.gpDatoAutor.Controls.Add(this.lblNacimientoAU);
            this.gpDatoAutor.Controls.Add(this.txtNacimientoAutor);
            this.gpDatoAutor.Controls.Add(this.txtNombreAutor);
            this.gpDatoAutor.Controls.Add(this.lblApellidoAU);
            this.gpDatoAutor.Controls.Add(this.txtApellido);
            this.gpDatoAutor.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.gpDatoAutor.Location = new System.Drawing.Point(30, 211);
            this.gpDatoAutor.Name = "gpDatoAutor";
            this.gpDatoAutor.Size = new System.Drawing.Size(287, 131);
            this.gpDatoAutor.TabIndex = 14;
            this.gpDatoAutor.TabStop = false;
            this.gpDatoAutor.Text = "DATO AUTOR";
            // 
            // lblNombreAU
            // 
            this.lblNombreAU.AutoSize = true;
            this.lblNombreAU.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblNombreAU.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblNombreAU.Location = new System.Drawing.Point(19, 25);
            this.lblNombreAU.Name = "lblNombreAU";
            this.lblNombreAU.Size = new System.Drawing.Size(61, 13);
            this.lblNombreAU.TabIndex = 1;
            this.lblNombreAU.Text = "NOMBRE *";
            // 
            // lblNacimientoAU
            // 
            this.lblNacimientoAU.AutoSize = true;
            this.lblNacimientoAU.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblNacimientoAU.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblNacimientoAU.Location = new System.Drawing.Point(19, 90);
            this.lblNacimientoAU.Name = "lblNacimientoAU";
            this.lblNacimientoAU.Size = new System.Drawing.Size(107, 13);
            this.lblNacimientoAU.TabIndex = 11;
            this.lblNacimientoAU.Text = "AÑO NACIMIENTO *";
            // 
            // txtNacimientoAutor
            // 
            this.txtNacimientoAutor.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtNacimientoAutor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNacimientoAutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNacimientoAutor.Location = new System.Drawing.Point(125, 83);
            this.txtNacimientoAutor.Name = "txtNacimientoAutor";
            this.txtNacimientoAutor.Size = new System.Drawing.Size(141, 26);
            this.txtNacimientoAutor.TabIndex = 12;
            this.txtNacimientoAutor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNombreAutor
            // 
            this.txtNombreAutor.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtNombreAutor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombreAutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreAutor.Location = new System.Drawing.Point(125, 19);
            this.txtNombreAutor.Name = "txtNombreAutor";
            this.txtNombreAutor.Size = new System.Drawing.Size(141, 26);
            this.txtNombreAutor.TabIndex = 6;
            this.txtNombreAutor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblApellidoAU
            // 
            this.lblApellidoAU.AutoSize = true;
            this.lblApellidoAU.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblApellidoAU.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblApellidoAU.Location = new System.Drawing.Point(19, 58);
            this.lblApellidoAU.Name = "lblApellidoAU";
            this.lblApellidoAU.Size = new System.Drawing.Size(66, 13);
            this.lblApellidoAU.TabIndex = 4;
            this.lblApellidoAU.Text = "APELLIDO *";
            // 
            // txtApellido
            // 
            this.txtApellido.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtApellido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellido.Location = new System.Drawing.Point(125, 51);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(141, 26);
            this.txtApellido.TabIndex = 7;
            this.txtApellido.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gpDatoEditorial
            // 
            this.gpDatoEditorial.Controls.Add(this.lblNombreEDI);
            this.gpDatoEditorial.Controls.Add(this.lblDireccionEDI);
            this.gpDatoEditorial.Controls.Add(this.lblPaisEDI);
            this.gpDatoEditorial.Controls.Add(this.txtDireccion);
            this.gpDatoEditorial.Controls.Add(this.txtNombreEditorial);
            this.gpDatoEditorial.Controls.Add(this.txtPais);
            this.gpDatoEditorial.Controls.Add(this.lblTelefonoEDI);
            this.gpDatoEditorial.Controls.Add(this.txtTelefonoEditorial);
            this.gpDatoEditorial.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.gpDatoEditorial.Location = new System.Drawing.Point(332, 28);
            this.gpDatoEditorial.Name = "gpDatoEditorial";
            this.gpDatoEditorial.Size = new System.Drawing.Size(266, 162);
            this.gpDatoEditorial.TabIndex = 14;
            this.gpDatoEditorial.TabStop = false;
            this.gpDatoEditorial.Text = "DATO EDITORIAL";
            // 
            // lblNombreEDI
            // 
            this.lblNombreEDI.AutoSize = true;
            this.lblNombreEDI.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblNombreEDI.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblNombreEDI.Location = new System.Drawing.Point(19, 25);
            this.lblNombreEDI.Name = "lblNombreEDI";
            this.lblNombreEDI.Size = new System.Drawing.Size(61, 13);
            this.lblNombreEDI.TabIndex = 1;
            this.lblNombreEDI.Text = "NOMBRE *";
            // 
            // lblDireccionEDI
            // 
            this.lblDireccionEDI.AutoSize = true;
            this.lblDireccionEDI.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDireccionEDI.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDireccionEDI.Location = new System.Drawing.Point(19, 90);
            this.lblDireccionEDI.Name = "lblDireccionEDI";
            this.lblDireccionEDI.Size = new System.Drawing.Size(66, 13);
            this.lblDireccionEDI.TabIndex = 11;
            this.lblDireccionEDI.Text = "DIRECCIÓN";
            // 
            // lblPaisEDI
            // 
            this.lblPaisEDI.AutoSize = true;
            this.lblPaisEDI.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblPaisEDI.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPaisEDI.Location = new System.Drawing.Point(19, 122);
            this.lblPaisEDI.Name = "lblPaisEDI";
            this.lblPaisEDI.Size = new System.Drawing.Size(38, 13);
            this.lblPaisEDI.TabIndex = 2;
            this.lblPaisEDI.Text = "PAÍS *";
            // 
            // txtDireccion
            // 
            this.txtDireccion.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtDireccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccion.Location = new System.Drawing.Point(105, 83);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(141, 26);
            this.txtDireccion.TabIndex = 12;
            this.txtDireccion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNombreEditorial
            // 
            this.txtNombreEditorial.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtNombreEditorial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombreEditorial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreEditorial.Location = new System.Drawing.Point(105, 19);
            this.txtNombreEditorial.Name = "txtNombreEditorial";
            this.txtNombreEditorial.Size = new System.Drawing.Size(141, 26);
            this.txtNombreEditorial.TabIndex = 6;
            this.txtNombreEditorial.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPais
            // 
            this.txtPais.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtPais.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPais.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPais.Location = new System.Drawing.Point(105, 115);
            this.txtPais.Name = "txtPais";
            this.txtPais.Size = new System.Drawing.Size(141, 26);
            this.txtPais.TabIndex = 9;
            this.txtPais.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblTelefonoEDI
            // 
            this.lblTelefonoEDI.AutoSize = true;
            this.lblTelefonoEDI.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTelefonoEDI.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTelefonoEDI.Location = new System.Drawing.Point(19, 58);
            this.lblTelefonoEDI.Name = "lblTelefonoEDI";
            this.lblTelefonoEDI.Size = new System.Drawing.Size(71, 13);
            this.lblTelefonoEDI.TabIndex = 4;
            this.lblTelefonoEDI.Text = "TELEFONO *";
            // 
            // txtTelefonoEditorial
            // 
            this.txtTelefonoEditorial.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtTelefonoEditorial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTelefonoEditorial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefonoEditorial.Location = new System.Drawing.Point(105, 51);
            this.txtTelefonoEditorial.Name = "txtTelefonoEditorial";
            this.txtTelefonoEditorial.Size = new System.Drawing.Size(141, 26);
            this.txtTelefonoEditorial.TabIndex = 7;
            this.txtTelefonoEditorial.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gpDatoLibro
            // 
            this.gpDatoLibro.Controls.Add(this.lblTitulo);
            this.gpDatoLibro.Controls.Add(this.lblISBN);
            this.gpDatoLibro.Controls.Add(this.lblContenido);
            this.gpDatoLibro.Controls.Add(this.txtISBN);
            this.gpDatoLibro.Controls.Add(this.txtTituloLibro);
            this.gpDatoLibro.Controls.Add(this.txtContenido);
            this.gpDatoLibro.Controls.Add(this.lblAno);
            this.gpDatoLibro.Controls.Add(this.txtAno);
            this.gpDatoLibro.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.gpDatoLibro.Location = new System.Drawing.Point(30, 28);
            this.gpDatoLibro.Name = "gpDatoLibro";
            this.gpDatoLibro.Size = new System.Drawing.Size(266, 162);
            this.gpDatoLibro.TabIndex = 13;
            this.gpDatoLibro.TabStop = false;
            this.gpDatoLibro.Text = "DATO LIBRO";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTitulo.Location = new System.Drawing.Point(19, 25);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(53, 13);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "TITULO *";
            // 
            // lblISBN
            // 
            this.lblISBN.AutoSize = true;
            this.lblISBN.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblISBN.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblISBN.Location = new System.Drawing.Point(19, 90);
            this.lblISBN.Name = "lblISBN";
            this.lblISBN.Size = new System.Drawing.Size(39, 13);
            this.lblISBN.TabIndex = 11;
            this.lblISBN.Text = "ISBN *";
            // 
            // lblContenido
            // 
            this.lblContenido.AutoSize = true;
            this.lblContenido.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblContenido.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblContenido.Location = new System.Drawing.Point(19, 122);
            this.lblContenido.Name = "lblContenido";
            this.lblContenido.Size = new System.Drawing.Size(78, 13);
            this.lblContenido.TabIndex = 2;
            this.lblContenido.Text = "CONTENIDO *";
            // 
            // txtISBN
            // 
            this.txtISBN.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtISBN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtISBN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtISBN.Location = new System.Drawing.Point(105, 83);
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.Size = new System.Drawing.Size(141, 26);
            this.txtISBN.TabIndex = 12;
            this.txtISBN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTituloLibro
            // 
            this.txtTituloLibro.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtTituloLibro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTituloLibro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTituloLibro.Location = new System.Drawing.Point(105, 19);
            this.txtTituloLibro.Name = "txtTituloLibro";
            this.txtTituloLibro.Size = new System.Drawing.Size(141, 26);
            this.txtTituloLibro.TabIndex = 6;
            this.txtTituloLibro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtContenido
            // 
            this.txtContenido.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtContenido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtContenido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContenido.Location = new System.Drawing.Point(105, 115);
            this.txtContenido.Name = "txtContenido";
            this.txtContenido.Size = new System.Drawing.Size(141, 26);
            this.txtContenido.TabIndex = 9;
            this.txtContenido.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblAno
            // 
            this.lblAno.AutoSize = true;
            this.lblAno.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblAno.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblAno.Location = new System.Drawing.Point(19, 58);
            this.lblAno.Name = "lblAno";
            this.lblAno.Size = new System.Drawing.Size(37, 13);
            this.lblAno.TabIndex = 4;
            this.lblAno.Text = "AÑO *";
            // 
            // txtAno
            // 
            this.txtAno.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtAno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAno.Location = new System.Drawing.Point(105, 51);
            this.txtAno.Name = "txtAno";
            this.txtAno.Size = new System.Drawing.Size(141, 26);
            this.txtAno.TabIndex = 7;
            this.txtAno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnCargarLibro
            // 
            this.btnCargarLibro.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnCargarLibro.FlatAppearance.BorderSize = 0;
            this.btnCargarLibro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCargarLibro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargarLibro.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCargarLibro.Location = new System.Drawing.Point(386, 354);
            this.btnCargarLibro.Name = "btnCargarLibro";
            this.btnCargarLibro.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnCargarLibro.Size = new System.Drawing.Size(173, 35);
            this.btnCargarLibro.TabIndex = 10;
            this.btnCargarLibro.Text = "CARGAR LIBRO";
            this.btnCargarLibro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCargarLibro.UseVisualStyleBackColor = false;
            this.btnCargarLibro.Click += new System.EventHandler(this.btnCargarLibro_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCerrar.Location = new System.Drawing.Point(614, 9);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(24, 28);
            this.btnCerrar.TabIndex = 14;
            this.btnCerrar.Text = "x";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // frmCargaLibro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(716, 497);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCargaLibro";
            this.Text = "frmCargaLibro";
            this.Load += new System.EventHandler(this.frmCargaLibro_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gpSeleccionarExistente.ResumeLayout(false);
            this.gpDatoAutor.ResumeLayout(false);
            this.gpDatoAutor.PerformLayout();
            this.gpDatoEditorial.ResumeLayout(false);
            this.gpDatoEditorial.PerformLayout();
            this.gpDatoLibro.ResumeLayout(false);
            this.gpDatoLibro.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblObligatorio;
        private System.Windows.Forms.GroupBox gpSeleccionarExistente;
        private System.Windows.Forms.Button btnAutorConsulta;
        private System.Windows.Forms.Button btnEditorialConsulta;
        private System.Windows.Forms.GroupBox gpDatoAutor;
        private System.Windows.Forms.Label lblNombreAU;
        private System.Windows.Forms.Label lblNacimientoAU;
        private System.Windows.Forms.TextBox txtNacimientoAutor;
        private System.Windows.Forms.TextBox txtNombreAutor;
        private System.Windows.Forms.Label lblApellidoAU;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.GroupBox gpDatoEditorial;
        private System.Windows.Forms.Label lblNombreEDI;
        private System.Windows.Forms.Label lblDireccionEDI;
        private System.Windows.Forms.Label lblPaisEDI;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtNombreEditorial;
        private System.Windows.Forms.TextBox txtPais;
        private System.Windows.Forms.Label lblTelefonoEDI;
        private System.Windows.Forms.TextBox txtTelefonoEditorial;
        private System.Windows.Forms.GroupBox gpDatoLibro;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblISBN;
        private System.Windows.Forms.Label lblContenido;
        private System.Windows.Forms.TextBox txtISBN;
        private System.Windows.Forms.TextBox txtTituloLibro;
        private System.Windows.Forms.TextBox txtContenido;
        private System.Windows.Forms.Label lblAno;
        private System.Windows.Forms.TextBox txtAno;
        private System.Windows.Forms.Button btnCargarLibro;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.Button btnCerrar;
    }
}
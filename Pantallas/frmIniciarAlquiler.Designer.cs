namespace Pantallas
{
    partial class frmIniciarAlquiler
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblNombreLibro = new System.Windows.Forms.Label();
            this.txtLibro = new System.Windows.Forms.TextBox();
            this.lblObservaciones = new System.Windows.Forms.Label();
            this.txtObservaciones = new System.Windows.Forms.TextBox();
            this.lblCorreoCliente = new System.Windows.Forms.Label();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.txtTotalAlquiler = new System.Windows.Forms.TextBox();
            this.lblPagoAlquiler = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblFechaInicio = new System.Windows.Forms.Label();
            this.lblFechaDevolucion = new System.Windows.Forms.Label();
            this.dtFechaDevolución = new System.Windows.Forms.DateTimePicker();
            this.dbFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.lblObligatorio = new System.Windows.Forms.Label();
            this.btnAlquilar = new System.Windows.Forms.Button();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Controls.Add(this.btnCerrar);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.lblObligatorio);
            this.groupBox1.Controls.Add(this.btnAlquilar);
            this.groupBox1.Location = new System.Drawing.Point(30, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(609, 317);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblNombreLibro);
            this.groupBox3.Controls.Add(this.txtLibro);
            this.groupBox3.Controls.Add(this.lblObservaciones);
            this.groupBox3.Controls.Add(this.txtObservaciones);
            this.groupBox3.Controls.Add(this.lblCorreoCliente);
            this.groupBox3.Controls.Add(this.txtCliente);
            this.groupBox3.Controls.Add(this.txtTotalAlquiler);
            this.groupBox3.Controls.Add(this.lblPagoAlquiler);
            this.groupBox3.Location = new System.Drawing.Point(15, 19);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(280, 224);
            this.groupBox3.TabIndex = 29;
            this.groupBox3.TabStop = false;
            // 
            // lblNombreLibro
            // 
            this.lblNombreLibro.AutoSize = true;
            this.lblNombreLibro.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblNombreLibro.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblNombreLibro.Location = new System.Drawing.Point(6, 33);
            this.lblNombreLibro.Name = "lblNombreLibro";
            this.lblNombreLibro.Size = new System.Drawing.Size(96, 13);
            this.lblNombreLibro.TabIndex = 1;
            this.lblNombreLibro.Text = "NOMBRE LIBRO *";
            // 
            // txtLibro
            // 
            this.txtLibro.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtLibro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLibro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLibro.Location = new System.Drawing.Point(123, 26);
            this.txtLibro.Name = "txtLibro";
            this.txtLibro.Size = new System.Drawing.Size(141, 26);
            this.txtLibro.TabIndex = 6;
            this.txtLibro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblObservaciones
            // 
            this.lblObservaciones.AutoSize = true;
            this.lblObservaciones.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblObservaciones.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblObservaciones.Location = new System.Drawing.Point(10, 139);
            this.lblObservaciones.Name = "lblObservaciones";
            this.lblObservaciones.Size = new System.Drawing.Size(78, 13);
            this.lblObservaciones.TabIndex = 23;
            this.lblObservaciones.Text = "Observaciones";
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtObservaciones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtObservaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObservaciones.Location = new System.Drawing.Point(9, 173);
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.Size = new System.Drawing.Size(251, 26);
            this.txtObservaciones.TabIndex = 22;
            this.txtObservaciones.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblCorreoCliente
            // 
            this.lblCorreoCliente.AutoSize = true;
            this.lblCorreoCliente.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCorreoCliente.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCorreoCliente.Location = new System.Drawing.Point(6, 65);
            this.lblCorreoCliente.Name = "lblCorreoCliente";
            this.lblCorreoCliente.Size = new System.Drawing.Size(108, 13);
            this.lblCorreoCliente.TabIndex = 2;
            this.lblCorreoCliente.Text = "CORREO CLIENTE *";
            // 
            // txtCliente
            // 
            this.txtCliente.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCliente.Location = new System.Drawing.Point(123, 58);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(141, 26);
            this.txtCliente.TabIndex = 9;
            this.txtCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTotalAlquiler
            // 
            this.txtTotalAlquiler.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtTotalAlquiler.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotalAlquiler.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalAlquiler.Location = new System.Drawing.Point(123, 90);
            this.txtTotalAlquiler.Name = "txtTotalAlquiler";
            this.txtTotalAlquiler.Size = new System.Drawing.Size(141, 26);
            this.txtTotalAlquiler.TabIndex = 10;
            this.txtTotalAlquiler.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblPagoAlquiler
            // 
            this.lblPagoAlquiler.AutoSize = true;
            this.lblPagoAlquiler.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblPagoAlquiler.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPagoAlquiler.Location = new System.Drawing.Point(6, 97);
            this.lblPagoAlquiler.Name = "lblPagoAlquiler";
            this.lblPagoAlquiler.Size = new System.Drawing.Size(100, 13);
            this.lblPagoAlquiler.TabIndex = 11;
            this.lblPagoAlquiler.Text = "PAGO ALQUILER *";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblFechaInicio);
            this.groupBox2.Controls.Add(this.lblFechaDevolucion);
            this.groupBox2.Controls.Add(this.dtFechaDevolución);
            this.groupBox2.Controls.Add(this.dbFechaInicio);
            this.groupBox2.Location = new System.Drawing.Point(311, 24);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(242, 137);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            // 
            // lblFechaInicio
            // 
            this.lblFechaInicio.AutoSize = true;
            this.lblFechaInicio.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblFechaInicio.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblFechaInicio.Location = new System.Drawing.Point(17, 16);
            this.lblFechaInicio.Name = "lblFechaInicio";
            this.lblFechaInicio.Size = new System.Drawing.Size(81, 13);
            this.lblFechaInicio.TabIndex = 24;
            this.lblFechaInicio.Text = "FECHA INICIO*";
            // 
            // lblFechaDevolucion
            // 
            this.lblFechaDevolucion.AutoSize = true;
            this.lblFechaDevolucion.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblFechaDevolucion.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblFechaDevolucion.Location = new System.Drawing.Point(17, 77);
            this.lblFechaDevolucion.Name = "lblFechaDevolucion";
            this.lblFechaDevolucion.Size = new System.Drawing.Size(119, 13);
            this.lblFechaDevolucion.TabIndex = 12;
            this.lblFechaDevolucion.Text = "FECHA DEVOLUCIÓN*";
            // 
            // dtFechaDevolución
            // 
            this.dtFechaDevolución.Location = new System.Drawing.Point(20, 93);
            this.dtFechaDevolución.Name = "dtFechaDevolución";
            this.dtFechaDevolución.Size = new System.Drawing.Size(200, 20);
            this.dtFechaDevolución.TabIndex = 13;
            // 
            // dbFechaInicio
            // 
            this.dbFechaInicio.Location = new System.Drawing.Point(20, 32);
            this.dbFechaInicio.Name = "dbFechaInicio";
            this.dbFechaInicio.Size = new System.Drawing.Size(200, 20);
            this.dbFechaInicio.TabIndex = 25;
            // 
            // lblObligatorio
            // 
            this.lblObligatorio.AutoSize = true;
            this.lblObligatorio.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblObligatorio.Location = new System.Drawing.Point(12, 271);
            this.lblObligatorio.Name = "lblObligatorio";
            this.lblObligatorio.Size = new System.Drawing.Size(70, 13);
            this.lblObligatorio.TabIndex = 21;
            this.lblObligatorio.Text = "(*) Obligatorio";
            // 
            // btnAlquilar
            // 
            this.btnAlquilar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnAlquilar.FlatAppearance.BorderSize = 0;
            this.btnAlquilar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlquilar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlquilar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAlquilar.Location = new System.Drawing.Point(365, 208);
            this.btnAlquilar.Name = "btnAlquilar";
            this.btnAlquilar.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnAlquilar.Size = new System.Drawing.Size(144, 35);
            this.btnAlquilar.TabIndex = 5;
            this.btnAlquilar.Text = "ALQUILAR";
            this.btnAlquilar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlquilar.UseVisualStyleBackColor = false;
            this.btnAlquilar.Click += new System.EventHandler(this.btnAlquilar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(575, 10);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(28, 25);
            this.btnCerrar.TabIndex = 15;
            this.btnCerrar.Text = "x";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // frmIniciarAlquiler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(651, 422);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmIniciarAlquiler";
            this.Text = "frmIniciarAlquiler";
            this.Load += new System.EventHandler(this.frmIniciarAlquiler_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblObligatorio;
        private System.Windows.Forms.DateTimePicker dtFechaDevolución;
        private System.Windows.Forms.Label lblFechaDevolucion;
        private System.Windows.Forms.Label lblPagoAlquiler;
        private System.Windows.Forms.TextBox txtTotalAlquiler;
        private System.Windows.Forms.Label lblNombreLibro;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Label lblCorreoCliente;
        private System.Windows.Forms.Button btnAlquilar;
        private System.Windows.Forms.TextBox txtLibro;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblFechaInicio;
        private System.Windows.Forms.DateTimePicker dbFechaInicio;
        private System.Windows.Forms.Label lblObservaciones;
        private System.Windows.Forms.TextBox txtObservaciones;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.Button btnCerrar;
    }
}
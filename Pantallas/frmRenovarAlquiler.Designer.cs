namespace Pantallas
{
    partial class frmRenovarAlquiler
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
            this.txtCorreoCliente = new System.Windows.Forms.TextBox();
            this.lblCorreoCliente = new System.Windows.Forms.Label();
            this.lblObligatorio = new System.Windows.Forms.Label();
            this.txtCodigoLibro = new System.Windows.Forms.TextBox();
            this.lblIDLibro = new System.Windows.Forms.Label();
            this.lblNombreLibro = new System.Windows.Forms.Label();
            this.txtNombreLibro = new System.Windows.Forms.TextBox();
            this.lblNumAlquiler = new System.Windows.Forms.Label();
            this.txtNumAlquiler = new System.Windows.Forms.TextBox();
            this.lblMontoPago = new System.Windows.Forms.Label();
            this.txtMontoPago = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblFechaInicio = new System.Windows.Forms.Label();
            this.lblFechaDevolucion = new System.Windows.Forms.Label();
            this.dtFechaDevolución = new System.Windows.Forms.DateTimePicker();
            this.dbFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.btnRenovar = new System.Windows.Forms.Button();
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
            this.groupBox1.Controls.Add(this.btnRenovar);
            this.groupBox1.Location = new System.Drawing.Point(58, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(606, 386);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtCorreoCliente);
            this.groupBox3.Controls.Add(this.lblCorreoCliente);
            this.groupBox3.Controls.Add(this.lblObligatorio);
            this.groupBox3.Controls.Add(this.txtCodigoLibro);
            this.groupBox3.Controls.Add(this.lblIDLibro);
            this.groupBox3.Controls.Add(this.lblNombreLibro);
            this.groupBox3.Controls.Add(this.txtNombreLibro);
            this.groupBox3.Controls.Add(this.lblNumAlquiler);
            this.groupBox3.Controls.Add(this.txtNumAlquiler);
            this.groupBox3.Controls.Add(this.lblMontoPago);
            this.groupBox3.Controls.Add(this.txtMontoPago);
            this.groupBox3.Location = new System.Drawing.Point(29, 175);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(531, 184);
            this.groupBox3.TabIndex = 29;
            this.groupBox3.TabStop = false;
            // 
            // txtCorreoCliente
            // 
            this.txtCorreoCliente.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtCorreoCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCorreoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreoCliente.Location = new System.Drawing.Point(293, 41);
            this.txtCorreoCliente.Name = "txtCorreoCliente";
            this.txtCorreoCliente.Size = new System.Drawing.Size(209, 26);
            this.txtCorreoCliente.TabIndex = 29;
            this.txtCorreoCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblCorreoCliente
            // 
            this.lblCorreoCliente.AutoSize = true;
            this.lblCorreoCliente.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCorreoCliente.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCorreoCliente.Location = new System.Drawing.Point(290, 25);
            this.lblCorreoCliente.Name = "lblCorreoCliente";
            this.lblCorreoCliente.Size = new System.Drawing.Size(105, 13);
            this.lblCorreoCliente.TabIndex = 28;
            this.lblCorreoCliente.Text = "CORREO CLIENTE*";
            // 
            // lblObligatorio
            // 
            this.lblObligatorio.AutoSize = true;
            this.lblObligatorio.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblObligatorio.Location = new System.Drawing.Point(24, 158);
            this.lblObligatorio.Name = "lblObligatorio";
            this.lblObligatorio.Size = new System.Drawing.Size(70, 13);
            this.lblObligatorio.TabIndex = 21;
            this.lblObligatorio.Text = "(*) Obligatorio";
            // 
            // txtCodigoLibro
            // 
            this.txtCodigoLibro.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtCodigoLibro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCodigoLibro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoLibro.Location = new System.Drawing.Point(123, 18);
            this.txtCodigoLibro.Name = "txtCodigoLibro";
            this.txtCodigoLibro.Size = new System.Drawing.Size(141, 26);
            this.txtCodigoLibro.TabIndex = 27;
            this.txtCodigoLibro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblIDLibro
            // 
            this.lblIDLibro.AutoSize = true;
            this.lblIDLibro.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblIDLibro.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblIDLibro.Location = new System.Drawing.Point(29, 25);
            this.lblIDLibro.Name = "lblIDLibro";
            this.lblIDLibro.Size = new System.Drawing.Size(88, 13);
            this.lblIDLibro.TabIndex = 26;
            this.lblIDLibro.Text = "CÓDIGO LIBRO*";
            // 
            // lblNombreLibro
            // 
            this.lblNombreLibro.AutoSize = true;
            this.lblNombreLibro.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblNombreLibro.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblNombreLibro.Location = new System.Drawing.Point(24, 71);
            this.lblNombreLibro.Name = "lblNombreLibro";
            this.lblNombreLibro.Size = new System.Drawing.Size(93, 13);
            this.lblNombreLibro.TabIndex = 25;
            this.lblNombreLibro.Text = "NOMBRE LIBRO*";
            // 
            // txtNombreLibro
            // 
            this.txtNombreLibro.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtNombreLibro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombreLibro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreLibro.Location = new System.Drawing.Point(123, 64);
            this.txtNombreLibro.Name = "txtNombreLibro";
            this.txtNombreLibro.Size = new System.Drawing.Size(141, 26);
            this.txtNombreLibro.TabIndex = 24;
            this.txtNombreLibro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblNumAlquiler
            // 
            this.lblNumAlquiler.AutoSize = true;
            this.lblNumAlquiler.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblNumAlquiler.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblNumAlquiler.Location = new System.Drawing.Point(290, 77);
            this.lblNumAlquiler.Name = "lblNumAlquiler";
            this.lblNumAlquiler.Size = new System.Drawing.Size(92, 13);
            this.lblNumAlquiler.TabIndex = 1;
            this.lblNumAlquiler.Text = "NUM ALQUILER*";
            // 
            // txtNumAlquiler
            // 
            this.txtNumAlquiler.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtNumAlquiler.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNumAlquiler.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumAlquiler.Location = new System.Drawing.Point(293, 100);
            this.txtNumAlquiler.Name = "txtNumAlquiler";
            this.txtNumAlquiler.Size = new System.Drawing.Size(209, 26);
            this.txtNumAlquiler.TabIndex = 6;
            this.txtNumAlquiler.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblMontoPago
            // 
            this.lblMontoPago.AutoSize = true;
            this.lblMontoPago.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblMontoPago.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblMontoPago.Location = new System.Drawing.Point(29, 113);
            this.lblMontoPago.Name = "lblMontoPago";
            this.lblMontoPago.Size = new System.Drawing.Size(84, 13);
            this.lblMontoPago.TabIndex = 2;
            this.lblMontoPago.Text = "MONTO PAGO*";
            // 
            // txtMontoPago
            // 
            this.txtMontoPago.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtMontoPago.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMontoPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMontoPago.Location = new System.Drawing.Point(123, 106);
            this.txtMontoPago.Name = "txtMontoPago";
            this.txtMontoPago.Size = new System.Drawing.Size(141, 26);
            this.txtMontoPago.TabIndex = 9;
            this.txtMontoPago.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblFechaInicio);
            this.groupBox2.Controls.Add(this.lblFechaDevolucion);
            this.groupBox2.Controls.Add(this.dtFechaDevolución);
            this.groupBox2.Controls.Add(this.dbFechaInicio);
            this.groupBox2.Location = new System.Drawing.Point(29, 19);
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
            // btnRenovar
            // 
            this.btnRenovar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnRenovar.FlatAppearance.BorderSize = 0;
            this.btnRenovar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRenovar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRenovar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnRenovar.Location = new System.Drawing.Point(353, 74);
            this.btnRenovar.Name = "btnRenovar";
            this.btnRenovar.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnRenovar.Size = new System.Drawing.Size(146, 35);
            this.btnRenovar.TabIndex = 5;
            this.btnRenovar.Text = "RENOVAR";
            this.btnRenovar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRenovar.UseVisualStyleBackColor = false;
            this.btnRenovar.Click += new System.EventHandler(this.btnRenovar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(579, 9);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(27, 21);
            this.btnCerrar.TabIndex = 16;
            this.btnCerrar.Text = "x";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // frmRenovarAlquiler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(730, 506);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmRenovarAlquiler";
            this.Text = "x";
            this.Load += new System.EventHandler(this.frmRenovarAlquiler_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblNumAlquiler;
        private System.Windows.Forms.TextBox txtNumAlquiler;
        private System.Windows.Forms.Label lblMontoPago;
        private System.Windows.Forms.TextBox txtMontoPago;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblFechaInicio;
        private System.Windows.Forms.Label lblFechaDevolucion;
        private System.Windows.Forms.DateTimePicker dtFechaDevolución;
        private System.Windows.Forms.DateTimePicker dbFechaInicio;
        private System.Windows.Forms.Label lblObligatorio;
        private System.Windows.Forms.Button btnRenovar;
        private System.Windows.Forms.TextBox txtNombreLibro;
        private System.Windows.Forms.Label lblNombreLibro;
        private System.Windows.Forms.TextBox txtCodigoLibro;
        private System.Windows.Forms.Label lblIDLibro;
        private System.Windows.Forms.TextBox txtCorreoCliente;
        private System.Windows.Forms.Label lblCorreoCliente;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.Button btnCerrar;
    }
}
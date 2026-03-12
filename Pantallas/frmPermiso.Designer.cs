namespace Pantallas
{
    partial class frmPermiso
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.gbUsuario = new System.Windows.Forms.GroupBox();
            this.cbUsuario = new System.Windows.Forms.CheckBox();
            this.gbGestionLibro = new System.Windows.Forms.GroupBox();
            this.cbLibro = new System.Windows.Forms.CheckBox();
            this.gbGestionCliente = new System.Windows.Forms.GroupBox();
            this.cbCliente = new System.Windows.Forms.CheckBox();
            this.gbGestionAlquiler = new System.Windows.Forms.GroupBox();
            this.cbAlquiler = new System.Windows.Forms.CheckBox();
            this.lblObligatorio = new System.Windows.Forms.Label();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.gbUsuario.SuspendLayout();
            this.gbGestionLibro.SuspendLayout();
            this.gbGestionCliente.SuspendLayout();
            this.gbGestionAlquiler.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Black;
            this.groupBox2.Controls.Add(this.btnCerrar);
            this.groupBox2.Controls.Add(this.gbUsuario);
            this.groupBox2.Controls.Add(this.gbGestionLibro);
            this.groupBox2.Controls.Add(this.gbGestionCliente);
            this.groupBox2.Controls.Add(this.gbGestionAlquiler);
            this.groupBox2.Controls.Add(this.lblObligatorio);
            this.groupBox2.Controls.Add(this.btnConfirmar);
            this.groupBox2.Controls.Add(this.lblUsuario);
            this.groupBox2.Controls.Add(this.txtUsuario);
            this.groupBox2.Location = new System.Drawing.Point(22, 24);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(609, 273);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            // 
            // gbUsuario
            // 
            this.gbUsuario.Controls.Add(this.cbUsuario);
            this.gbUsuario.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.gbUsuario.Location = new System.Drawing.Point(194, 148);
            this.gbUsuario.Name = "gbUsuario";
            this.gbUsuario.Size = new System.Drawing.Size(165, 53);
            this.gbUsuario.TabIndex = 22;
            this.gbUsuario.TabStop = false;
            this.gbUsuario.Text = "USUARIO";
            // 
            // cbUsuario
            // 
            this.cbUsuario.AutoSize = true;
            this.cbUsuario.Location = new System.Drawing.Point(6, 19);
            this.cbUsuario.Name = "cbUsuario";
            this.cbUsuario.Size = new System.Drawing.Size(126, 17);
            this.cbUsuario.TabIndex = 5;
            this.cbUsuario.Text = "GESTION USUARIO";
            this.cbUsuario.UseVisualStyleBackColor = true;
            // 
            // gbGestionLibro
            // 
            this.gbGestionLibro.Controls.Add(this.cbLibro);
            this.gbGestionLibro.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.gbGestionLibro.Location = new System.Drawing.Point(194, 82);
            this.gbGestionLibro.Name = "gbGestionLibro";
            this.gbGestionLibro.Size = new System.Drawing.Size(165, 54);
            this.gbGestionLibro.TabIndex = 21;
            this.gbGestionLibro.TabStop = false;
            this.gbGestionLibro.Text = "GESTION LIBRO";
            // 
            // cbLibro
            // 
            this.cbLibro.AutoSize = true;
            this.cbLibro.Location = new System.Drawing.Point(15, 19);
            this.cbLibro.Name = "cbLibro";
            this.cbLibro.Size = new System.Drawing.Size(109, 17);
            this.cbLibro.TabIndex = 0;
            this.cbLibro.Text = "GESTION LIBRO";
            this.cbLibro.UseVisualStyleBackColor = true;
            // 
            // gbGestionCliente
            // 
            this.gbGestionCliente.Controls.Add(this.cbCliente);
            this.gbGestionCliente.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.gbGestionCliente.Location = new System.Drawing.Point(15, 148);
            this.gbGestionCliente.Name = "gbGestionCliente";
            this.gbGestionCliente.Size = new System.Drawing.Size(173, 53);
            this.gbGestionCliente.TabIndex = 21;
            this.gbGestionCliente.TabStop = false;
            this.gbGestionCliente.Text = "GESTION CLIENTE";
            // 
            // cbCliente
            // 
            this.cbCliente.AutoSize = true;
            this.cbCliente.Location = new System.Drawing.Point(6, 19);
            this.cbCliente.Name = "cbCliente";
            this.cbCliente.Size = new System.Drawing.Size(122, 17);
            this.cbCliente.TabIndex = 3;
            this.cbCliente.Text = "GESTION CLIENTE";
            this.cbCliente.UseVisualStyleBackColor = true;
            // 
            // gbGestionAlquiler
            // 
            this.gbGestionAlquiler.Controls.Add(this.cbAlquiler);
            this.gbGestionAlquiler.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.gbGestionAlquiler.Location = new System.Drawing.Point(15, 82);
            this.gbGestionAlquiler.Name = "gbGestionAlquiler";
            this.gbGestionAlquiler.Size = new System.Drawing.Size(173, 52);
            this.gbGestionAlquiler.TabIndex = 20;
            this.gbGestionAlquiler.TabStop = false;
            this.gbGestionAlquiler.Text = "GESTION ALQUILER";
            // 
            // cbAlquiler
            // 
            this.cbAlquiler.AutoSize = true;
            this.cbAlquiler.Location = new System.Drawing.Point(6, 19);
            this.cbAlquiler.Name = "cbAlquiler";
            this.cbAlquiler.Size = new System.Drawing.Size(130, 17);
            this.cbAlquiler.TabIndex = 0;
            this.cbAlquiler.Text = "GESTION ALQUILER";
            this.cbAlquiler.UseVisualStyleBackColor = true;
            // 
            // lblObligatorio
            // 
            this.lblObligatorio.AutoSize = true;
            this.lblObligatorio.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblObligatorio.Location = new System.Drawing.Point(11, 231);
            this.lblObligatorio.Name = "lblObligatorio";
            this.lblObligatorio.Size = new System.Drawing.Size(70, 13);
            this.lblObligatorio.TabIndex = 19;
            this.lblObligatorio.Text = "(*) Obligatorio";
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnConfirmar.FlatAppearance.BorderSize = 0;
            this.btnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnConfirmar.Location = new System.Drawing.Point(401, 120);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnConfirmar.Size = new System.Drawing.Size(157, 35);
            this.btnConfirmar.TabIndex = 10;
            this.btnConfirmar.Text = "CONFIRMAR ";
            this.btnConfirmar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfirmar.UseVisualStyleBackColor = false;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblUsuario.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblUsuario.Location = new System.Drawing.Point(11, 16);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(60, 13);
            this.lblUsuario.TabIndex = 1;
            this.lblUsuario.Text = "USUARIO*";
            // 
            // txtUsuario
            // 
            this.txtUsuario.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Location = new System.Drawing.Point(14, 32);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(174, 26);
            this.txtUsuario.TabIndex = 6;
            this.txtUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(591, 11);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(18, 23);
            this.btnCerrar.TabIndex = 14;
            this.btnCerrar.Text = "x";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // frmPermiso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(655, 337);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPermiso";
            this.Text = "frmPermisos";
            this.Load += new System.EventHandler(this.frmPermiso_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.gbUsuario.ResumeLayout(false);
            this.gbUsuario.PerformLayout();
            this.gbGestionLibro.ResumeLayout(false);
            this.gbGestionLibro.PerformLayout();
            this.gbGestionCliente.ResumeLayout(false);
            this.gbGestionCliente.PerformLayout();
            this.gbGestionAlquiler.ResumeLayout(false);
            this.gbGestionAlquiler.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblObligatorio;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.GroupBox gbGestionAlquiler;
        private System.Windows.Forms.GroupBox gbUsuario;
        private System.Windows.Forms.CheckBox cbUsuario;
        private System.Windows.Forms.GroupBox gbGestionLibro;
        private System.Windows.Forms.CheckBox cbLibro;
        private System.Windows.Forms.GroupBox gbGestionCliente;
        private System.Windows.Forms.CheckBox cbCliente;
        private System.Windows.Forms.CheckBox cbAlquiler;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.Button btnCerrar;
    }
}
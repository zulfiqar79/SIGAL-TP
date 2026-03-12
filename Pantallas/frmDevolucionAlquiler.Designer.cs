namespace Pantallas
{
    partial class frmDevolucionAlquiler
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
            this.lblNumAlquiler = new System.Windows.Forms.Label();
            this.btnRegistrarDevolución = new System.Windows.Forms.Button();
            this.lblNombreLibro = new System.Windows.Forms.Label();
            this.txtNombreLibro = new System.Windows.Forms.TextBox();
            this.txtNumAlquiler = new System.Windows.Forms.TextBox();
            this.lblCodigoLibro = new System.Windows.Forms.Label();
            this.txtCodigoLibro = new System.Windows.Forms.TextBox();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Controls.Add(this.btnCerrar);
            this.groupBox1.Controls.Add(this.lblObligatorio);
            this.groupBox1.Controls.Add(this.lblNumAlquiler);
            this.groupBox1.Controls.Add(this.btnRegistrarDevolución);
            this.groupBox1.Controls.Add(this.lblNombreLibro);
            this.groupBox1.Controls.Add(this.txtNombreLibro);
            this.groupBox1.Controls.Add(this.txtNumAlquiler);
            this.groupBox1.Controls.Add(this.lblCodigoLibro);
            this.groupBox1.Controls.Add(this.txtCodigoLibro);
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(48, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(542, 226);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            // 
            // lblObligatorio
            // 
            this.lblObligatorio.AutoSize = true;
            this.lblObligatorio.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblObligatorio.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblObligatorio.Location = new System.Drawing.Point(16, 200);
            this.lblObligatorio.Name = "lblObligatorio";
            this.lblObligatorio.Size = new System.Drawing.Size(70, 13);
            this.lblObligatorio.TabIndex = 11;
            this.lblObligatorio.Text = "Obligatorio (*)";
            // 
            // lblNumAlquiler
            // 
            this.lblNumAlquiler.AutoSize = true;
            this.lblNumAlquiler.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblNumAlquiler.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblNumAlquiler.Location = new System.Drawing.Point(44, 106);
            this.lblNumAlquiler.Name = "lblNumAlquiler";
            this.lblNumAlquiler.Size = new System.Drawing.Size(95, 13);
            this.lblNumAlquiler.TabIndex = 10;
            this.lblNumAlquiler.Text = "NÚM ALQUILER *";
            // 
            // btnRegistrarDevolución
            // 
            this.btnRegistrarDevolución.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnRegistrarDevolución.FlatAppearance.BorderSize = 0;
            this.btnRegistrarDevolución.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarDevolución.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarDevolución.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnRegistrarDevolución.Location = new System.Drawing.Point(323, 138);
            this.btnRegistrarDevolución.Name = "btnRegistrarDevolución";
            this.btnRegistrarDevolución.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnRegistrarDevolución.Size = new System.Drawing.Size(163, 54);
            this.btnRegistrarDevolución.TabIndex = 5;
            this.btnRegistrarDevolución.Text = "REGISTRAR DEVOLUCIÓN";
            this.btnRegistrarDevolución.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegistrarDevolución.UseVisualStyleBackColor = false;
            this.btnRegistrarDevolución.Click += new System.EventHandler(this.btnRegistrarDevolución_Click);
            // 
            // lblNombreLibro
            // 
            this.lblNombreLibro.AutoSize = true;
            this.lblNombreLibro.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblNombreLibro.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblNombreLibro.Location = new System.Drawing.Point(240, 34);
            this.lblNombreLibro.Name = "lblNombreLibro";
            this.lblNombreLibro.Size = new System.Drawing.Size(96, 13);
            this.lblNombreLibro.TabIndex = 9;
            this.lblNombreLibro.Text = "NOMBRE LIBRO *";
            // 
            // txtNombreLibro
            // 
            this.txtNombreLibro.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtNombreLibro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombreLibro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreLibro.Location = new System.Drawing.Point(243, 61);
            this.txtNombreLibro.Name = "txtNombreLibro";
            this.txtNombreLibro.Size = new System.Drawing.Size(265, 26);
            this.txtNombreLibro.TabIndex = 8;
            this.txtNombreLibro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNumAlquiler
            // 
            this.txtNumAlquiler.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtNumAlquiler.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNumAlquiler.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumAlquiler.Location = new System.Drawing.Point(47, 138);
            this.txtNumAlquiler.Name = "txtNumAlquiler";
            this.txtNumAlquiler.Size = new System.Drawing.Size(141, 26);
            this.txtNumAlquiler.TabIndex = 7;
            this.txtNumAlquiler.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblCodigoLibro
            // 
            this.lblCodigoLibro.AutoSize = true;
            this.lblCodigoLibro.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCodigoLibro.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCodigoLibro.Location = new System.Drawing.Point(44, 34);
            this.lblCodigoLibro.Name = "lblCodigoLibro";
            this.lblCodigoLibro.Size = new System.Drawing.Size(91, 13);
            this.lblCodigoLibro.TabIndex = 1;
            this.lblCodigoLibro.Text = "CÓDIGO LIBRO *";
            // 
            // txtCodigoLibro
            // 
            this.txtCodigoLibro.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtCodigoLibro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCodigoLibro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoLibro.Location = new System.Drawing.Point(47, 61);
            this.txtCodigoLibro.Name = "txtCodigoLibro";
            this.txtCodigoLibro.Size = new System.Drawing.Size(141, 26);
            this.txtCodigoLibro.TabIndex = 6;
            this.txtCodigoLibro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(511, 9);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(31, 23);
            this.btnCerrar.TabIndex = 15;
            this.btnCerrar.Text = "x";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // frmDevolucionAlquiler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(646, 364);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDevolucionAlquiler";
            this.Text = "frmDevolucionAlquiler";
            this.Load += new System.EventHandler(this.frmDevolucionAlquiler_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblCodigoLibro;
        private System.Windows.Forms.Button btnRegistrarDevolución;
        private System.Windows.Forms.TextBox txtCodigoLibro;
        private System.Windows.Forms.Label lblObligatorio;
        private System.Windows.Forms.Label lblNumAlquiler;
        private System.Windows.Forms.Label lblNombreLibro;
        private System.Windows.Forms.TextBox txtNombreLibro;
        private System.Windows.Forms.TextBox txtNumAlquiler;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.Button btnCerrar;
    }
}
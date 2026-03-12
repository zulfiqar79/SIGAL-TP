namespace Pantallas
{
    partial class frmPregunta
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
            this.lblTexto = new System.Windows.Forms.Label();
            this.btnSi = new System.Windows.Forms.Button();
            this.btnNo = new System.Windows.Forms.Button();
            this.gpCerrarSesion = new System.Windows.Forms.GroupBox();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.gpCerrarSesion.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTexto
            // 
            this.lblTexto.AutoSize = true;
            this.lblTexto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTexto.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTexto.Location = new System.Drawing.Point(16, 31);
            this.lblTexto.Name = "lblTexto";
            this.lblTexto.Size = new System.Drawing.Size(242, 16);
            this.lblTexto.TabIndex = 1;
            this.lblTexto.Text = "¿Esta seguro que desea cerrar sesión?";
            // 
            // btnSi
            // 
            this.btnSi.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSi.Location = new System.Drawing.Point(19, 59);
            this.btnSi.Name = "btnSi";
            this.btnSi.Size = new System.Drawing.Size(103, 23);
            this.btnSi.TabIndex = 2;
            this.btnSi.Text = "Sí";
            this.btnSi.UseVisualStyleBackColor = true;
            this.btnSi.Click += new System.EventHandler(this.btnSi_Click);
            // 
            // btnNo
            // 
            this.btnNo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnNo.Location = new System.Drawing.Point(157, 59);
            this.btnNo.Name = "btnNo";
            this.btnNo.Size = new System.Drawing.Size(101, 23);
            this.btnNo.TabIndex = 3;
            this.btnNo.Text = "No";
            this.btnNo.UseVisualStyleBackColor = true;
            this.btnNo.Click += new System.EventHandler(this.btnNo_Click);
            // 
            // gpCerrarSesion
            // 
            this.gpCerrarSesion.Controls.Add(this.btnCerrar);
            this.gpCerrarSesion.Controls.Add(this.btnSi);
            this.gpCerrarSesion.Controls.Add(this.lblTexto);
            this.gpCerrarSesion.Controls.Add(this.btnNo);
            this.gpCerrarSesion.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.gpCerrarSesion.Location = new System.Drawing.Point(36, 27);
            this.gpCerrarSesion.Name = "gpCerrarSesion";
            this.gpCerrarSesion.Size = new System.Drawing.Size(318, 100);
            this.gpCerrarSesion.TabIndex = 4;
            this.gpCerrarSesion.TabStop = false;
            this.gpCerrarSesion.Text = "CERRAR SESIÓN";
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(292, 10);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(20, 27);
            this.btnCerrar.TabIndex = 5;
            this.btnCerrar.Text = "x";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // frmPregunta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(366, 161);
            this.Controls.Add(this.gpCerrarSesion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPregunta";
            this.Text = "frmPregunta";
            this.Load += new System.EventHandler(this.frmPregunta_Load);
            this.gpCerrarSesion.ResumeLayout(false);
            this.gpCerrarSesion.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblTexto;
        private System.Windows.Forms.Button btnSi;
        private System.Windows.Forms.Button btnNo;
        private System.Windows.Forms.GroupBox gpCerrarSesion;
        private System.Windows.Forms.Button btnCerrar;
    }
}
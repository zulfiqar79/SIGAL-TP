namespace Pantallas
{
    partial class frmMensaje
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
            this.ALQUILER = new System.Windows.Forms.GroupBox();
            this.lblTexto3 = new System.Windows.Forms.Label();
            this.lblTexto2 = new System.Windows.Forms.Label();
            this.lblTexto = new System.Windows.Forms.Label();
            this.btnNo = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.ALQUILER.SuspendLayout();
            this.SuspendLayout();
            // 
            // ALQUILER
            // 
            this.ALQUILER.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ALQUILER.Controls.Add(this.btnCerrar);
            this.ALQUILER.Controls.Add(this.lblTexto3);
            this.ALQUILER.Controls.Add(this.lblTexto2);
            this.ALQUILER.Controls.Add(this.lblTexto);
            this.ALQUILER.Controls.Add(this.btnNo);
            this.ALQUILER.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.ALQUILER.Location = new System.Drawing.Point(55, 31);
            this.ALQUILER.Name = "ALQUILER";
            this.ALQUILER.Size = new System.Drawing.Size(421, 189);
            this.ALQUILER.TabIndex = 5;
            this.ALQUILER.TabStop = false;
            this.ALQUILER.Text = "ALQUILER REGISTRADO";
            // 
            // lblTexto3
            // 
            this.lblTexto3.AutoSize = true;
            this.lblTexto3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTexto3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTexto3.Location = new System.Drawing.Point(16, 93);
            this.lblTexto3.Name = "lblTexto3";
            this.lblTexto3.Size = new System.Drawing.Size(59, 16);
            this.lblTexto3.TabIndex = 5;
            this.lblTexto3.Text = "mensaje";
            // 
            // lblTexto2
            // 
            this.lblTexto2.AutoSize = true;
            this.lblTexto2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTexto2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTexto2.Location = new System.Drawing.Point(16, 60);
            this.lblTexto2.Name = "lblTexto2";
            this.lblTexto2.Size = new System.Drawing.Size(59, 16);
            this.lblTexto2.TabIndex = 4;
            this.lblTexto2.Text = "mensaje";
            // 
            // lblTexto
            // 
            this.lblTexto.AutoSize = true;
            this.lblTexto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTexto.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTexto.Location = new System.Drawing.Point(16, 31);
            this.lblTexto.Name = "lblTexto";
            this.lblTexto.Size = new System.Drawing.Size(59, 16);
            this.lblTexto.TabIndex = 1;
            this.lblTexto.Text = "mensaje";
            // 
            // btnNo
            // 
            this.btnNo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnNo.Location = new System.Drawing.Point(233, 143);
            this.btnNo.Name = "btnNo";
            this.btnNo.Size = new System.Drawing.Size(63, 23);
            this.btnNo.TabIndex = 3;
            this.btnNo.Text = "OK";
            this.btnNo.UseVisualStyleBackColor = true;
            this.btnNo.Click += new System.EventHandler(this.btnNo_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(390, 10);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(25, 22);
            this.btnCerrar.TabIndex = 6;
            this.btnCerrar.Text = "x";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // frmMensaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(532, 257);
            this.Controls.Add(this.ALQUILER);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMensaje";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.formAlquilerRegistrado_Load);
            this.ALQUILER.ResumeLayout(false);
            this.ALQUILER.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox ALQUILER;
        private System.Windows.Forms.Label lblTexto;
        private System.Windows.Forms.Label lblTexto2;
        private System.Windows.Forms.Label lblTexto3;
        private System.Windows.Forms.Button btnNo;
        private System.Windows.Forms.Button btnCerrar;
    }
}
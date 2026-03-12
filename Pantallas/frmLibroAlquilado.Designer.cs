namespace Pantallas
{
    partial class frmLibroAlquilado
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
            this.verLibros = new System.Windows.Forms.DataGridView();
            this.btnConsultarLibro = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.verLibros)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnCerrar);
            this.groupBox2.Controls.Add(this.verLibros);
            this.groupBox2.Location = new System.Drawing.Point(27, 22);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(657, 343);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            // 
            // verLibros
            // 
            this.verLibros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.verLibros.Location = new System.Drawing.Point(6, 19);
            this.verLibros.Name = "verLibros";
            this.verLibros.Size = new System.Drawing.Size(603, 314);
            this.verLibros.TabIndex = 14;
            // 
            // btnConsultarLibro
            // 
            this.btnConsultarLibro.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnConsultarLibro.FlatAppearance.BorderSize = 0;
            this.btnConsultarLibro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultarLibro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultarLibro.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnConsultarLibro.Location = new System.Drawing.Point(6, 12);
            this.btnConsultarLibro.Name = "btnConsultarLibro";
            this.btnConsultarLibro.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnConsultarLibro.Size = new System.Drawing.Size(163, 35);
            this.btnConsultarLibro.TabIndex = 10;
            this.btnConsultarLibro.Text = "CONSULTAR";
            this.btnConsultarLibro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultarLibro.UseVisualStyleBackColor = false;
            this.btnConsultarLibro.Click += new System.EventHandler(this.btnConsultarLibro_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnConsultarLibro);
            this.groupBox1.Location = new System.Drawing.Point(345, 371);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(176, 53);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(630, 9);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(27, 22);
            this.btnCerrar.TabIndex = 21;
            this.btnCerrar.Text = "x";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // frmLibroAlquilado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(711, 447);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLibroAlquilado";
            this.Text = "frmLibroAlquilado";
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.verLibros)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView verLibros;
        private System.Windows.Forms.Button btnConsultarLibro;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.Button btnCerrar;
    }
}
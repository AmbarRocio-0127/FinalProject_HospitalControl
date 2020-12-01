namespace Control_Médico
{
    partial class gestionHosp
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(gestionHosp));
            this.lbltitle = new System.Windows.Forms.Label();
            this.btnmantenimientos = new System.Windows.Forms.Button();
            this.btnprocesos = new System.Windows.Forms.Button();
            this.btbConsultas = new System.Windows.Forms.Button();
            this.Bienvenida = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbltitle
            // 
            this.lbltitle.AutoSize = true;
            this.lbltitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.5F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lbltitle.ForeColor = System.Drawing.Color.Teal;
            this.lbltitle.Location = new System.Drawing.Point(216, 9);
            this.lbltitle.Name = "lbltitle";
            this.lbltitle.Size = new System.Drawing.Size(399, 29);
            this.lbltitle.TabIndex = 0;
            this.lbltitle.Text = "Control De Gestión Hospitalaria";
            // 
            // btnmantenimientos
            // 
            this.btnmantenimientos.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnmantenimientos.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmantenimientos.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnmantenimientos.Location = new System.Drawing.Point(32, 163);
            this.btnmantenimientos.Name = "btnmantenimientos";
            this.btnmantenimientos.Size = new System.Drawing.Size(346, 50);
            this.btnmantenimientos.TabIndex = 1;
            this.btnmantenimientos.Text = "Módulo De Mantenimientos";
            this.btnmantenimientos.UseVisualStyleBackColor = false;
            this.btnmantenimientos.Click += new System.EventHandler(this.btnmantenimientos_Click);
            // 
            // btnprocesos
            // 
            this.btnprocesos.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnprocesos.Font = new System.Drawing.Font("Gill Sans MT", 12F);
            this.btnprocesos.ForeColor = System.Drawing.Color.White;
            this.btnprocesos.Location = new System.Drawing.Point(32, 249);
            this.btnprocesos.Name = "btnprocesos";
            this.btnprocesos.Size = new System.Drawing.Size(346, 50);
            this.btnprocesos.TabIndex = 2;
            this.btnprocesos.Text = "Módulo De Procesos";
            this.btnprocesos.UseVisualStyleBackColor = false;
            this.btnprocesos.Click += new System.EventHandler(this.btnprocesos_Click);
            // 
            // btbConsultas
            // 
            this.btbConsultas.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btbConsultas.Font = new System.Drawing.Font("Gill Sans MT", 12F);
            this.btbConsultas.ForeColor = System.Drawing.Color.White;
            this.btbConsultas.Location = new System.Drawing.Point(32, 335);
            this.btbConsultas.Name = "btbConsultas";
            this.btbConsultas.Size = new System.Drawing.Size(346, 44);
            this.btbConsultas.TabIndex = 3;
            this.btbConsultas.Text = "Módulo De Listados";
            this.btbConsultas.UseVisualStyleBackColor = false;
            this.btbConsultas.Click += new System.EventHandler(this.btbConsultas_Click);
            // 
            // Bienvenida
            // 
            this.Bienvenida.AutoSize = true;
            this.Bienvenida.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Bienvenida.Font = new System.Drawing.Font("Mongolian Baiti", 12F);
            this.Bienvenida.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Bienvenida.Location = new System.Drawing.Point(29, 85);
            this.Bienvenida.Name = "Bienvenida";
            this.Bienvenida.Size = new System.Drawing.Size(319, 32);
            this.Bienvenida.TabIndex = 4;
            this.Bienvenida.Text = "¡Bienvenido al Sistema De Gestión Hospitalaria! \r\nElija la opción Deseada a Conti" +
    "nuación";
            // 
            // gestionHosp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Control_Médico.Properties.Resources.fondo_concepto_medicina_ciencia_41814_21;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(797, 479);
            this.Controls.Add(this.Bienvenida);
            this.Controls.Add(this.btbConsultas);
            this.Controls.Add(this.btnprocesos);
            this.Controls.Add(this.btnmantenimientos);
            this.Controls.Add(this.lbltitle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "gestionHosp";
            this.Text = "Control Medico";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbltitle;
        private System.Windows.Forms.Button btnmantenimientos;
        private System.Windows.Forms.Button btnprocesos;
        private System.Windows.Forms.Button btbConsultas;
        private System.Windows.Forms.Label Bienvenida;
    }
}


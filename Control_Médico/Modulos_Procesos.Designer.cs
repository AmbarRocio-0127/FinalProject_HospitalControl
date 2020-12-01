namespace Control_Médico
{
    partial class Modulos_Procesos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Modulos_Procesos));
            this.lbltitle = new System.Windows.Forms.Label();
            this.btncitasmedicas = new System.Windows.Forms.Button();
            this.btninternamientos = new System.Windows.Forms.Button();
            this.btnAltamedica = new System.Windows.Forms.Button();
            this.lblopcion = new System.Windows.Forms.Label();
            this.btnvolver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbltitle
            // 
            this.lbltitle.AutoSize = true;
            this.lbltitle.Font = new System.Drawing.Font("Mongolian Baiti", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lbltitle.ForeColor = System.Drawing.Color.Teal;
            this.lbltitle.Location = new System.Drawing.Point(241, 9);
            this.lbltitle.Name = "lbltitle";
            this.lbltitle.Size = new System.Drawing.Size(263, 29);
            this.lbltitle.TabIndex = 6;
            this.lbltitle.Text = "Módulo De Procesos";
            // 
            // btncitasmedicas
            // 
            this.btncitasmedicas.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncitasmedicas.ForeColor = System.Drawing.Color.Teal;
            this.btncitasmedicas.Location = new System.Drawing.Point(21, 160);
            this.btncitasmedicas.Name = "btncitasmedicas";
            this.btncitasmedicas.Size = new System.Drawing.Size(346, 50);
            this.btncitasmedicas.TabIndex = 7;
            this.btncitasmedicas.Text = "Agendar Citas Médicas";
            this.btncitasmedicas.UseVisualStyleBackColor = true;
            this.btncitasmedicas.Click += new System.EventHandler(this.btncitasmedicas_Click);
            // 
            // btninternamientos
            // 
            this.btninternamientos.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btninternamientos.ForeColor = System.Drawing.Color.Teal;
            this.btninternamientos.Location = new System.Drawing.Point(21, 239);
            this.btninternamientos.Name = "btninternamientos";
            this.btninternamientos.Size = new System.Drawing.Size(346, 50);
            this.btninternamientos.TabIndex = 8;
            this.btninternamientos.Text = "Registro de Internamientos";
            this.btninternamientos.UseVisualStyleBackColor = true;
            this.btninternamientos.Click += new System.EventHandler(this.btninternamientos_Click);
            // 
            // btnAltamedica
            // 
            this.btnAltamedica.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAltamedica.ForeColor = System.Drawing.Color.Teal;
            this.btnAltamedica.Location = new System.Drawing.Point(21, 320);
            this.btnAltamedica.Name = "btnAltamedica";
            this.btnAltamedica.Size = new System.Drawing.Size(346, 50);
            this.btnAltamedica.TabIndex = 9;
            this.btnAltamedica.Text = "Registro de alta Médica";
            this.btnAltamedica.UseVisualStyleBackColor = true;
            this.btnAltamedica.Click += new System.EventHandler(this.btnAltamedica_Click);
            // 
            // lblopcion
            // 
            this.lblopcion.AutoSize = true;
            this.lblopcion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblopcion.Font = new System.Drawing.Font("Mongolian Baiti", 12F);
            this.lblopcion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblopcion.Location = new System.Drawing.Point(18, 90);
            this.lblopcion.Name = "lblopcion";
            this.lblopcion.Size = new System.Drawing.Size(261, 16);
            this.lblopcion.TabIndex = 10;
            this.lblopcion.Text = "Elija la opción Deseada a Continuación:";
            // 
            // btnvolver
            // 
            this.btnvolver.BackColor = System.Drawing.Color.Teal;
            this.btnvolver.Font = new System.Drawing.Font("Gill Sans MT", 8F);
            this.btnvolver.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnvolver.Location = new System.Drawing.Point(730, 402);
            this.btnvolver.Name = "btnvolver";
            this.btnvolver.Size = new System.Drawing.Size(102, 58);
            this.btnvolver.TabIndex = 11;
            this.btnvolver.Text = "Volver al Menú Principal";
            this.btnvolver.UseVisualStyleBackColor = false;
            this.btnvolver.Click += new System.EventHandler(this.btnvolver_Click);
            // 
            // Modulos_Procesos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Control_Médico.Properties.Resources.fondo_concepto_medicina_ciencia_41814_211;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(844, 472);
            this.Controls.Add(this.btnvolver);
            this.Controls.Add(this.lblopcion);
            this.Controls.Add(this.btnAltamedica);
            this.Controls.Add(this.btninternamientos);
            this.Controls.Add(this.btncitasmedicas);
            this.Controls.Add(this.lbltitle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Modulos_Procesos";
            this.Text = "Módulo de Procesos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbltitle;
        private System.Windows.Forms.Button btncitasmedicas;
        private System.Windows.Forms.Button btninternamientos;
        private System.Windows.Forms.Button btnAltamedica;
        private System.Windows.Forms.Label lblopcion;
        private System.Windows.Forms.Button btnvolver;
    }
}
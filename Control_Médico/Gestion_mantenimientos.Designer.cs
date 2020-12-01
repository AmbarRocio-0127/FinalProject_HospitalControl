namespace Control_Médico
{
    partial class Gestion_mantenimientos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Gestion_mantenimientos));
            this.btnmant_pacientes = new System.Windows.Forms.Button();
            this.btnmant_Doctores = new System.Windows.Forms.Button();
            this.btnmant_Rooms = new System.Windows.Forms.Button();
            this.lbltitle = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnmant_pacientes
            // 
            this.btnmant_pacientes.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmant_pacientes.ForeColor = System.Drawing.Color.Teal;
            this.btnmant_pacientes.Location = new System.Drawing.Point(21, 151);
            this.btnmant_pacientes.Name = "btnmant_pacientes";
            this.btnmant_pacientes.Size = new System.Drawing.Size(346, 50);
            this.btnmant_pacientes.TabIndex = 2;
            this.btnmant_pacientes.Text = "Mantenimiento De Pacientes";
            this.btnmant_pacientes.UseVisualStyleBackColor = true;
            this.btnmant_pacientes.Click += new System.EventHandler(this.btnmant_pacientes_Click);
            // 
            // btnmant_Doctores
            // 
            this.btnmant_Doctores.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmant_Doctores.ForeColor = System.Drawing.Color.Teal;
            this.btnmant_Doctores.Location = new System.Drawing.Point(21, 242);
            this.btnmant_Doctores.Name = "btnmant_Doctores";
            this.btnmant_Doctores.Size = new System.Drawing.Size(346, 50);
            this.btnmant_Doctores.TabIndex = 3;
            this.btnmant_Doctores.Text = "Mantenimiento De Doctores";
            this.btnmant_Doctores.UseVisualStyleBackColor = true;
            this.btnmant_Doctores.Click += new System.EventHandler(this.btnmant_Doctores_Click);
            // 
            // btnmant_Rooms
            // 
            this.btnmant_Rooms.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmant_Rooms.ForeColor = System.Drawing.Color.Teal;
            this.btnmant_Rooms.Location = new System.Drawing.Point(21, 324);
            this.btnmant_Rooms.Name = "btnmant_Rooms";
            this.btnmant_Rooms.Size = new System.Drawing.Size(346, 50);
            this.btnmant_Rooms.TabIndex = 4;
            this.btnmant_Rooms.Text = "Mantenimiento De Habitaciones";
            this.btnmant_Rooms.UseVisualStyleBackColor = true;
            this.btnmant_Rooms.Click += new System.EventHandler(this.btnmant_Rooms_Click);
            // 
            // lbltitle
            // 
            this.lbltitle.AutoSize = true;
            this.lbltitle.Font = new System.Drawing.Font("Mongolian Baiti", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lbltitle.ForeColor = System.Drawing.Color.Teal;
            this.lbltitle.Location = new System.Drawing.Point(187, 40);
            this.lbltitle.Name = "lbltitle";
            this.lbltitle.Size = new System.Drawing.Size(306, 25);
            this.lbltitle.TabIndex = 5;
            this.lbltitle.Text = "Módulo De Mantenimientos";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Teal;
            this.button1.Font = new System.Drawing.Font("Gill Sans MT", 8F);
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(701, 393);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 58);
            this.button1.TabIndex = 6;
            this.button1.Text = "Volver al Menú Principal";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Gestion_mantenimientos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Control_Médico.Properties.Resources.fondo_concepto_medicina_ciencia_41814_21;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(815, 463);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbltitle);
            this.Controls.Add(this.btnmant_Rooms);
            this.Controls.Add(this.btnmant_Doctores);
            this.Controls.Add(this.btnmant_pacientes);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Gestion_mantenimientos";
            this.Text = "Módulo de Mantenimientos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnmant_pacientes;
        private System.Windows.Forms.Button btnmant_Doctores;
        private System.Windows.Forms.Button btnmant_Rooms;
        private System.Windows.Forms.Label lbltitle;
        private System.Windows.Forms.Button button1;
    }
}
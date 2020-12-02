namespace Control_Médico
{
    partial class Alta_medica
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Alta_medica));
            this.lbltitleDoctor = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblidaltas = new System.Windows.Forms.Label();
            this.txtidaltas = new System.Windows.Forms.TextBox();
            this.dataGridViewaltas = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.btnguardarpaciente = new System.Windows.Forms.Button();
            this.btnactualizarpaciente = new System.Windows.Forms.Button();
            this.btnBorraralta = new System.Windows.Forms.Button();
            this.lblwarning = new System.Windows.Forms.Label();
            this.btnvolver = new System.Windows.Forms.Button();
            this.btnbacking = new System.Windows.Forms.Button();
            this.btnlistinternamientos = new System.Windows.Forms.Button();
            this.lblidinternships = new System.Windows.Forms.Label();
            this.txt_IDI = new System.Windows.Forms.TextBox();
            this.txtSalida = new System.Windows.Forms.TextBox();
            this.btnlistaraltas = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewaltas)).BeginInit();
            this.SuspendLayout();
            // 
            // lbltitleDoctor
            // 
            this.lbltitleDoctor.AutoSize = true;
            this.lbltitleDoctor.Font = new System.Drawing.Font("Times New Roman", 25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lbltitleDoctor.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.lbltitleDoctor.Location = new System.Drawing.Point(637, 9);
            this.lbltitleDoctor.Name = "lbltitleDoctor";
            this.lbltitleDoctor.Size = new System.Drawing.Size(352, 39);
            this.lbltitleDoctor.TabIndex = 29;
            this.lbltitleDoctor.Text = "Agenda De Alta Médica";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = global::Control_Médico.Properties.Resources.doctor_paciente_anciano_27170_13;
            this.pictureBox1.Location = new System.Drawing.Point(25, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(344, 223);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            // 
            // lblidaltas
            // 
            this.lblidaltas.AutoSize = true;
            this.lblidaltas.Font = new System.Drawing.Font("Mongolian Baiti", 12F);
            this.lblidaltas.ForeColor = System.Drawing.Color.Teal;
            this.lblidaltas.Location = new System.Drawing.Point(650, 96);
            this.lblidaltas.Name = "lblidaltas";
            this.lblidaltas.Size = new System.Drawing.Size(138, 16);
            this.lblidaltas.TabIndex = 43;
            this.lblidaltas.Text = "Id De Altas Médicas";
            // 
            // txtidaltas
            // 
            this.txtidaltas.Location = new System.Drawing.Point(836, 95);
            this.txtidaltas.Name = "txtidaltas";
            this.txtidaltas.Size = new System.Drawing.Size(212, 20);
            this.txtidaltas.TabIndex = 44;
            // 
            // dataGridViewaltas
            // 
            this.dataGridViewaltas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewaltas.Location = new System.Drawing.Point(2, 238);
            this.dataGridViewaltas.Name = "dataGridViewaltas";
            this.dataGridViewaltas.Size = new System.Drawing.Size(737, 290);
            this.dataGridViewaltas.TabIndex = 51;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Mongolian Baiti", 12F);
            this.label4.ForeColor = System.Drawing.Color.Teal;
            this.label4.Location = new System.Drawing.Point(677, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 16);
            this.label4.TabIndex = 52;
            this.label4.Text = "Fecha de Salida";
            // 
            // btnguardarpaciente
            // 
            this.btnguardarpaciente.BackColor = System.Drawing.Color.Teal;
            this.btnguardarpaciente.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.btnguardarpaciente.ForeColor = System.Drawing.Color.White;
            this.btnguardarpaciente.Location = new System.Drawing.Point(745, 238);
            this.btnguardarpaciente.Name = "btnguardarpaciente";
            this.btnguardarpaciente.Size = new System.Drawing.Size(86, 38);
            this.btnguardarpaciente.TabIndex = 54;
            this.btnguardarpaciente.Text = "Guardar";
            this.btnguardarpaciente.UseVisualStyleBackColor = false;
            this.btnguardarpaciente.Click += new System.EventHandler(this.btnguardarpaciente_Click);
            // 
            // btnactualizarpaciente
            // 
            this.btnactualizarpaciente.BackColor = System.Drawing.Color.Teal;
            this.btnactualizarpaciente.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnactualizarpaciente.ForeColor = System.Drawing.Color.White;
            this.btnactualizarpaciente.Location = new System.Drawing.Point(864, 238);
            this.btnactualizarpaciente.Name = "btnactualizarpaciente";
            this.btnactualizarpaciente.Size = new System.Drawing.Size(81, 38);
            this.btnactualizarpaciente.TabIndex = 55;
            this.btnactualizarpaciente.Text = "Actualizar";
            this.btnactualizarpaciente.UseVisualStyleBackColor = false;
            this.btnactualizarpaciente.Click += new System.EventHandler(this.btnactualizarpaciente_Click);
            // 
            // btnBorraralta
            // 
            this.btnBorraralta.BackColor = System.Drawing.Color.Teal;
            this.btnBorraralta.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.btnBorraralta.ForeColor = System.Drawing.Color.White;
            this.btnBorraralta.Location = new System.Drawing.Point(980, 238);
            this.btnBorraralta.Name = "btnBorraralta";
            this.btnBorraralta.Size = new System.Drawing.Size(85, 38);
            this.btnBorraralta.TabIndex = 56;
            this.btnBorraralta.Text = "Eliminar";
            this.btnBorraralta.UseVisualStyleBackColor = false;
            this.btnBorraralta.Click += new System.EventHandler(this.btnBorraralta_Click);
            // 
            // lblwarning
            // 
            this.lblwarning.AutoSize = true;
            this.lblwarning.Location = new System.Drawing.Point(814, 372);
            this.lblwarning.Name = "lblwarning";
            this.lblwarning.Size = new System.Drawing.Size(225, 78);
            this.lblwarning.TabIndex = 58;
            this.lblwarning.Text = resources.GetString("lblwarning.Text");
            // 
            // btnvolver
            // 
            this.btnvolver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnvolver.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnvolver.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnvolver.Location = new System.Drawing.Point(936, 496);
            this.btnvolver.Name = "btnvolver";
            this.btnvolver.Size = new System.Drawing.Size(103, 42);
            this.btnvolver.TabIndex = 60;
            this.btnvolver.Text = "Ir al Menú Principal";
            this.btnvolver.UseVisualStyleBackColor = false;
            this.btnvolver.Click += new System.EventHandler(this.btnvolver_Click);
            // 
            // btnbacking
            // 
            this.btnbacking.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnbacking.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbacking.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnbacking.Location = new System.Drawing.Point(817, 496);
            this.btnbacking.Name = "btnbacking";
            this.btnbacking.Size = new System.Drawing.Size(87, 42);
            this.btnbacking.TabIndex = 61;
            this.btnbacking.Text = "Volver atrás";
            this.btnbacking.UseVisualStyleBackColor = false;
            this.btnbacking.Click += new System.EventHandler(this.btnbacking_Click);
            // 
            // btnlistinternamientos
            // 
            this.btnlistinternamientos.BackColor = System.Drawing.Color.Teal;
            this.btnlistinternamientos.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlistinternamientos.ForeColor = System.Drawing.Color.White;
            this.btnlistinternamientos.Location = new System.Drawing.Point(783, 292);
            this.btnlistinternamientos.Name = "btnlistinternamientos";
            this.btnlistinternamientos.Size = new System.Drawing.Size(102, 65);
            this.btnlistinternamientos.TabIndex = 62;
            this.btnlistinternamientos.Text = "Listar Internamientos";
            this.btnlistinternamientos.UseVisualStyleBackColor = false;
            this.btnlistinternamientos.Click += new System.EventHandler(this.btnlistinternamientos_Click);
            // 
            // lblidinternships
            // 
            this.lblidinternships.AutoSize = true;
            this.lblidinternships.Font = new System.Drawing.Font("Mongolian Baiti", 12F);
            this.lblidinternships.ForeColor = System.Drawing.Color.Teal;
            this.lblidinternships.Location = new System.Drawing.Point(647, 135);
            this.lblidinternships.Name = "lblidinternships";
            this.lblidinternships.Size = new System.Drawing.Size(141, 16);
            this.lblidinternships.TabIndex = 63;
            this.lblidinternships.Text = "Id De Internamientos";
            // 
            // txt_IDI
            // 
            this.txt_IDI.Location = new System.Drawing.Point(836, 131);
            this.txt_IDI.Name = "txt_IDI";
            this.txt_IDI.Size = new System.Drawing.Size(212, 20);
            this.txt_IDI.TabIndex = 68;
            // 
            // txtSalida
            // 
            this.txtSalida.Location = new System.Drawing.Point(836, 169);
            this.txtSalida.Name = "txtSalida";
            this.txtSalida.Size = new System.Drawing.Size(212, 20);
            this.txtSalida.TabIndex = 69;
            // 
            // btnlistaraltas
            // 
            this.btnlistaraltas.BackColor = System.Drawing.Color.Teal;
            this.btnlistaraltas.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlistaraltas.ForeColor = System.Drawing.Color.White;
            this.btnlistaraltas.Location = new System.Drawing.Point(920, 292);
            this.btnlistaraltas.Name = "btnlistaraltas";
            this.btnlistaraltas.Size = new System.Drawing.Size(102, 65);
            this.btnlistaraltas.TabIndex = 70;
            this.btnlistaraltas.Text = "Listar pacientes de Altas Médicas";
            this.btnlistaraltas.UseVisualStyleBackColor = false;
            this.btnlistaraltas.Click += new System.EventHandler(this.btnlistaraltas_Click);
            // 
            // Alta_medica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1077, 550);
            this.Controls.Add(this.btnlistaraltas);
            this.Controls.Add(this.txtSalida);
            this.Controls.Add(this.txt_IDI);
            this.Controls.Add(this.lblidinternships);
            this.Controls.Add(this.btnlistinternamientos);
            this.Controls.Add(this.btnbacking);
            this.Controls.Add(this.btnvolver);
            this.Controls.Add(this.lblwarning);
            this.Controls.Add(this.btnBorraralta);
            this.Controls.Add(this.btnactualizarpaciente);
            this.Controls.Add(this.btnguardarpaciente);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridViewaltas);
            this.Controls.Add(this.txtidaltas);
            this.Controls.Add(this.lblidaltas);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbltitleDoctor);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Alta_medica";
            this.Text = "Alta Médica";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewaltas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbltitleDoctor;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblidaltas;
        private System.Windows.Forms.TextBox txtidaltas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnguardarpaciente;
        private System.Windows.Forms.Button btnactualizarpaciente;
        private System.Windows.Forms.Button btnBorraralta;
        private System.Windows.Forms.Label lblwarning;
        private System.Windows.Forms.Button btnvolver;
        private System.Windows.Forms.Button btnbacking;
        private System.Windows.Forms.Button btnlistinternamientos;
        private System.Windows.Forms.Label lblidinternships;
        public System.Windows.Forms.DataGridView dataGridViewaltas;
        private System.Windows.Forms.TextBox txt_IDI;
        private System.Windows.Forms.TextBox txtSalida;
        private System.Windows.Forms.Button btnlistaraltas;
    }
}
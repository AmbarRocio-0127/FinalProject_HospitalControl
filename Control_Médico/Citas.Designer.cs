namespace Control_Médico
{
    partial class Citas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Citas));
            this.lbltitleDoctor = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnguardarcitas = new System.Windows.Forms.Button();
            this.btnactualizarcita = new System.Windows.Forms.Button();
            this.btnBorrarcitas = new System.Windows.Forms.Button();
            this.dataGridViewcitas = new System.Windows.Forms.DataGridView();
            this.lblid = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.lblwarning = new System.Windows.Forms.Label();
            this.btnbacking = new System.Windows.Forms.Button();
            this.btnvolver = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblhora = new System.Windows.Forms.Label();
            this.txtpaciente = new System.Windows.Forms.TextBox();
            this.txtdoctor = new System.Windows.Forms.TextBox();
            this.txtfecha = new System.Windows.Forms.TextBox();
            this.txthoracita = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewcitas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbltitleDoctor
            // 
            this.lbltitleDoctor.AutoSize = true;
            this.lbltitleDoctor.Font = new System.Drawing.Font("Times New Roman", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitleDoctor.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.lbltitleDoctor.Location = new System.Drawing.Point(756, 0);
            this.lbltitleDoctor.Name = "lbltitleDoctor";
            this.lbltitleDoctor.Size = new System.Drawing.Size(308, 31);
            this.lbltitleDoctor.TabIndex = 27;
            this.lbltitleDoctor.Text = "Agenda De Citas Médicas";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Mongolian Baiti", 12F);
            this.lblName.ForeColor = System.Drawing.Color.Teal;
            this.lblName.Location = new System.Drawing.Point(731, 134);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(61, 16);
            this.lblName.TabIndex = 28;
            this.lblName.Text = "Paciente";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 12F);
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(740, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 16);
            this.label1.TabIndex = 29;
            this.label1.Text = "Doctor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 12F);
            this.label2.ForeColor = System.Drawing.Color.Teal;
            this.label2.Location = new System.Drawing.Point(672, 212);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 16);
            this.label2.TabIndex = 30;
            this.label2.Text = "Fecha De La Cita";
            // 
            // btnguardarcitas
            // 
            this.btnguardarcitas.BackColor = System.Drawing.Color.Teal;
            this.btnguardarcitas.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.btnguardarcitas.ForeColor = System.Drawing.Color.White;
            this.btnguardarcitas.Location = new System.Drawing.Point(709, 309);
            this.btnguardarcitas.Name = "btnguardarcitas";
            this.btnguardarcitas.Size = new System.Drawing.Size(100, 38);
            this.btnguardarcitas.TabIndex = 34;
            this.btnguardarcitas.Text = "Guardar Cita";
            this.btnguardarcitas.UseVisualStyleBackColor = false;
            this.btnguardarcitas.Click += new System.EventHandler(this.btnguardarcitas_Click);
            // 
            // btnactualizarcita
            // 
            this.btnactualizarcita.BackColor = System.Drawing.Color.Teal;
            this.btnactualizarcita.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnactualizarcita.ForeColor = System.Drawing.Color.White;
            this.btnactualizarcita.Location = new System.Drawing.Point(837, 309);
            this.btnactualizarcita.Name = "btnactualizarcita";
            this.btnactualizarcita.Size = new System.Drawing.Size(90, 38);
            this.btnactualizarcita.TabIndex = 35;
            this.btnactualizarcita.Text = "Actualizar Cita";
            this.btnactualizarcita.UseVisualStyleBackColor = false;
            this.btnactualizarcita.Click += new System.EventHandler(this.btnactualizarcita_Click);
            // 
            // btnBorrarcitas
            // 
            this.btnBorrarcitas.BackColor = System.Drawing.Color.Teal;
            this.btnBorrarcitas.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.btnBorrarcitas.ForeColor = System.Drawing.Color.White;
            this.btnBorrarcitas.Location = new System.Drawing.Point(951, 309);
            this.btnBorrarcitas.Name = "btnBorrarcitas";
            this.btnBorrarcitas.Size = new System.Drawing.Size(100, 38);
            this.btnBorrarcitas.TabIndex = 36;
            this.btnBorrarcitas.Text = "Eliminar Cita";
            this.btnBorrarcitas.UseVisualStyleBackColor = false;
            this.btnBorrarcitas.Click += new System.EventHandler(this.btnBorrarcitas_Click);
            // 
            // dataGridViewcitas
            // 
            this.dataGridViewcitas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewcitas.Location = new System.Drawing.Point(12, 230);
            this.dataGridViewcitas.Name = "dataGridViewcitas";
            this.dataGridViewcitas.Size = new System.Drawing.Size(562, 298);
            this.dataGridViewcitas.TabIndex = 37;
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Font = new System.Drawing.Font("Mongolian Baiti", 12F);
            this.lblid.ForeColor = System.Drawing.Color.Teal;
            this.lblid.Location = new System.Drawing.Point(771, 91);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(21, 16);
            this.lblid.TabIndex = 41;
            this.lblid.Text = "Id";
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(825, 91);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(206, 20);
            this.txtid.TabIndex = 42;
            // 
            // lblwarning
            // 
            this.lblwarning.AutoSize = true;
            this.lblwarning.Location = new System.Drawing.Point(727, 389);
            this.lblwarning.Name = "lblwarning";
            this.lblwarning.Size = new System.Drawing.Size(315, 26);
            this.lblwarning.TabIndex = 43;
            this.lblwarning.Text = "Nota: Solo introduzca el id para actualizar y borrar datos, no para \r\nguardarlos " +
    "ni listarlos.";
            // 
            // btnbacking
            // 
            this.btnbacking.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnbacking.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbacking.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnbacking.Location = new System.Drawing.Point(798, 494);
            this.btnbacking.Name = "btnbacking";
            this.btnbacking.Size = new System.Drawing.Size(87, 42);
            this.btnbacking.TabIndex = 44;
            this.btnbacking.Text = "Volver atrás";
            this.btnbacking.UseVisualStyleBackColor = false;
            this.btnbacking.Click += new System.EventHandler(this.btnbacking_Click);
            // 
            // btnvolver
            // 
            this.btnvolver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnvolver.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnvolver.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnvolver.Location = new System.Drawing.Point(930, 494);
            this.btnvolver.Name = "btnvolver";
            this.btnvolver.Size = new System.Drawing.Size(103, 42);
            this.btnvolver.TabIndex = 45;
            this.btnvolver.Text = "Ir al Menú Principal";
            this.btnvolver.UseVisualStyleBackColor = false;
            this.btnvolver.Click += new System.EventHandler(this.btnvolver_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Image = global::Control_Médico.Properties.Resources.time_481445_12801;
            this.pictureBox2.Location = new System.Drawing.Point(254, 9);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(206, 210);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 39;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = global::Control_Médico.Properties.Resources.mejoras_incapacidad_temporal_ayto_madrid;
            this.pictureBox1.Location = new System.Drawing.Point(12, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(245, 210);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 38;
            this.pictureBox1.TabStop = false;
            // 
            // lblhora
            // 
            this.lblhora.AutoSize = true;
            this.lblhora.Font = new System.Drawing.Font("Mongolian Baiti", 12F);
            this.lblhora.ForeColor = System.Drawing.Color.Teal;
            this.lblhora.Location = new System.Drawing.Point(678, 255);
            this.lblhora.Name = "lblhora";
            this.lblhora.Size = new System.Drawing.Size(114, 16);
            this.lblhora.TabIndex = 46;
            this.lblhora.Text = "Hora De La Cita";
            // 
            // txtpaciente
            // 
            this.txtpaciente.Location = new System.Drawing.Point(825, 134);
            this.txtpaciente.Name = "txtpaciente";
            this.txtpaciente.Size = new System.Drawing.Size(206, 20);
            this.txtpaciente.TabIndex = 51;
            // 
            // txtdoctor
            // 
            this.txtdoctor.Location = new System.Drawing.Point(825, 171);
            this.txtdoctor.Name = "txtdoctor";
            this.txtdoctor.Size = new System.Drawing.Size(206, 20);
            this.txtdoctor.TabIndex = 52;
            // 
            // txtfecha
            // 
            this.txtfecha.Location = new System.Drawing.Point(827, 211);
            this.txtfecha.Name = "txtfecha";
            this.txtfecha.Size = new System.Drawing.Size(206, 20);
            this.txtfecha.TabIndex = 53;
            // 
            // txthoracita
            // 
            this.txthoracita.Location = new System.Drawing.Point(825, 251);
            this.txthoracita.Name = "txthoracita";
            this.txthoracita.Size = new System.Drawing.Size(206, 20);
            this.txthoracita.TabIndex = 54;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(727, 430);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(255, 26);
            this.label3.TabIndex = 67;
            this.label3.Text = "Nota: Introduzca la fecha en formato DD/MM/YYYY\r\ny la hora en formato HH:MM";
            // 
            // Citas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1063, 548);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txthoracita);
            this.Controls.Add(this.txtfecha);
            this.Controls.Add(this.txtdoctor);
            this.Controls.Add(this.txtpaciente);
            this.Controls.Add(this.lblhora);
            this.Controls.Add(this.btnvolver);
            this.Controls.Add(this.btnbacking);
            this.Controls.Add(this.lblwarning);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.lblid);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridViewcitas);
            this.Controls.Add(this.btnBorrarcitas);
            this.Controls.Add(this.btnactualizarcita);
            this.Controls.Add(this.btnguardarcitas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lbltitleDoctor);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Citas";
            this.Text = "Citas Médicas";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewcitas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbltitleDoctor;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnguardarcitas;
        private System.Windows.Forms.Button btnactualizarcita;
        private System.Windows.Forms.Button btnBorrarcitas;
        private System.Windows.Forms.DataGridView dataGridViewcitas;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label lblwarning;
        private System.Windows.Forms.Button btnbacking;
        private System.Windows.Forms.Button btnvolver;
        private System.Windows.Forms.Label lblhora;
        private System.Windows.Forms.TextBox txtpaciente;
        private System.Windows.Forms.TextBox txtdoctor;
        private System.Windows.Forms.TextBox txtfecha;
        private System.Windows.Forms.TextBox txthoracita;
        private System.Windows.Forms.Label label3;
    }
}
namespace Control_Médico
{
    partial class mant_pacientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mant_pacientes));
            this.lblName = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.lblcedula = new System.Windows.Forms.Label();
            this.txtcedula = new System.Windows.Forms.TextBox();
            this.radiobtnAsegurado = new System.Windows.Forms.RadioButton();
            this.radiobtnNoAsegurado = new System.Windows.Forms.RadioButton();
            this.btnguardarpaciente = new System.Windows.Forms.Button();
            this.btnactualizarpaciente = new System.Windows.Forms.Button();
            this.btnBorrarpaciente = new System.Windows.Forms.Button();
            this.lbltitleDoctor = new System.Windows.Forms.Label();
            this.btnvolver = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnbacking = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblid = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.lblwarning = new System.Windows.Forms.Label();
            this.dgvdatasearchpatiente = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdatasearchpatiente)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Mongolian Baiti", 11F);
            this.lblName.ForeColor = System.Drawing.Color.Teal;
            this.lblName.Location = new System.Drawing.Point(577, 150);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(129, 16);
            this.lblName.TabIndex = 6;
            this.lblName.Text = "Nombre y Apellido";
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(744, 146);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(243, 20);
            this.txtname.TabIndex = 17;
            // 
            // lblcedula
            // 
            this.lblcedula.AutoSize = true;
            this.lblcedula.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcedula.ForeColor = System.Drawing.Color.Teal;
            this.lblcedula.Location = new System.Drawing.Point(577, 185);
            this.lblcedula.Name = "lblcedula";
            this.lblcedula.Size = new System.Drawing.Size(52, 16);
            this.lblcedula.TabIndex = 18;
            this.lblcedula.Text = "Cédula";
            // 
            // txtcedula
            // 
            this.txtcedula.Location = new System.Drawing.Point(744, 184);
            this.txtcedula.Name = "txtcedula";
            this.txtcedula.Size = new System.Drawing.Size(243, 20);
            this.txtcedula.TabIndex = 19;
            // 
            // radiobtnAsegurado
            // 
            this.radiobtnAsegurado.AutoSize = true;
            this.radiobtnAsegurado.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radiobtnAsegurado.ForeColor = System.Drawing.Color.Teal;
            this.radiobtnAsegurado.Location = new System.Drawing.Point(707, 267);
            this.radiobtnAsegurado.Name = "radiobtnAsegurado";
            this.radiobtnAsegurado.Size = new System.Drawing.Size(95, 20);
            this.radiobtnAsegurado.TabIndex = 20;
            this.radiobtnAsegurado.TabStop = true;
            this.radiobtnAsegurado.Text = "Asegurado";
            this.radiobtnAsegurado.UseVisualStyleBackColor = true;
            // 
            // radiobtnNoAsegurado
            // 
            this.radiobtnNoAsegurado.AutoSize = true;
            this.radiobtnNoAsegurado.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radiobtnNoAsegurado.ForeColor = System.Drawing.Color.Teal;
            this.radiobtnNoAsegurado.Location = new System.Drawing.Point(868, 267);
            this.radiobtnNoAsegurado.Name = "radiobtnNoAsegurado";
            this.radiobtnNoAsegurado.Size = new System.Drawing.Size(119, 20);
            this.radiobtnNoAsegurado.TabIndex = 21;
            this.radiobtnNoAsegurado.TabStop = true;
            this.radiobtnNoAsegurado.Text = "No Asegurado";
            this.radiobtnNoAsegurado.UseVisualStyleBackColor = true;
            // 
            // btnguardarpaciente
            // 
            this.btnguardarpaciente.BackColor = System.Drawing.Color.Teal;
            this.btnguardarpaciente.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.btnguardarpaciente.ForeColor = System.Drawing.Color.White;
            this.btnguardarpaciente.Location = new System.Drawing.Point(648, 336);
            this.btnguardarpaciente.Name = "btnguardarpaciente";
            this.btnguardarpaciente.Size = new System.Drawing.Size(100, 38);
            this.btnguardarpaciente.TabIndex = 23;
            this.btnguardarpaciente.Text = "Guardar";
            this.btnguardarpaciente.UseVisualStyleBackColor = false;
            this.btnguardarpaciente.Click += new System.EventHandler(this.btnguardarmedico_Click);
            // 
            // btnactualizarpaciente
            // 
            this.btnactualizarpaciente.BackColor = System.Drawing.Color.Teal;
            this.btnactualizarpaciente.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnactualizarpaciente.ForeColor = System.Drawing.Color.White;
            this.btnactualizarpaciente.Location = new System.Drawing.Point(783, 336);
            this.btnactualizarpaciente.Name = "btnactualizarpaciente";
            this.btnactualizarpaciente.Size = new System.Drawing.Size(90, 38);
            this.btnactualizarpaciente.TabIndex = 24;
            this.btnactualizarpaciente.Text = "Actualizar";
            this.btnactualizarpaciente.UseVisualStyleBackColor = false;
            this.btnactualizarpaciente.Click += new System.EventHandler(this.btnactualizarpaciente_Click);
            // 
            // btnBorrarpaciente
            // 
            this.btnBorrarpaciente.BackColor = System.Drawing.Color.Teal;
            this.btnBorrarpaciente.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.btnBorrarpaciente.ForeColor = System.Drawing.Color.White;
            this.btnBorrarpaciente.Location = new System.Drawing.Point(898, 336);
            this.btnBorrarpaciente.Name = "btnBorrarpaciente";
            this.btnBorrarpaciente.Size = new System.Drawing.Size(89, 38);
            this.btnBorrarpaciente.TabIndex = 25;
            this.btnBorrarpaciente.Text = "Eliminar";
            this.btnBorrarpaciente.UseVisualStyleBackColor = false;
            this.btnBorrarpaciente.Click += new System.EventHandler(this.btnBorrarpaciente_Click);
            // 
            // lbltitleDoctor
            // 
            this.lbltitleDoctor.AutoSize = true;
            this.lbltitleDoctor.Font = new System.Drawing.Font("Times New Roman", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitleDoctor.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.lbltitleDoctor.Location = new System.Drawing.Point(659, 23);
            this.lbltitleDoctor.Name = "lbltitleDoctor";
            this.lbltitleDoctor.Size = new System.Drawing.Size(343, 31);
            this.lbltitleDoctor.TabIndex = 26;
            this.lbltitleDoctor.Text = "Mantenimiento De Pacientes";
            // 
            // btnvolver
            // 
            this.btnvolver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnvolver.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnvolver.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnvolver.Location = new System.Drawing.Point(21, 469);
            this.btnvolver.Name = "btnvolver";
            this.btnvolver.Size = new System.Drawing.Size(103, 42);
            this.btnvolver.TabIndex = 28;
            this.btnvolver.Text = "Ir al Menú Principal";
            this.btnvolver.UseVisualStyleBackColor = false;
            this.btnvolver.Click += new System.EventHandler(this.btnvolver_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(629, 187);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "(Sin guiones)";
            // 
            // btnbacking
            // 
            this.btnbacking.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnbacking.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbacking.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnbacking.Location = new System.Drawing.Point(141, 469);
            this.btnbacking.Name = "btnbacking";
            this.btnbacking.Size = new System.Drawing.Size(103, 42);
            this.btnbacking.TabIndex = 30;
            this.btnbacking.Text = "Volver atrás";
            this.btnbacking.UseVisualStyleBackColor = false;
            this.btnbacking.Click += new System.EventHandler(this.btnbacking_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Control_Médico.Properties.Resources._3d_la_gente_blanca_enfermera_llevando_a_un_paciente_en_una_camilla_naranja_aislado_fondo_blanco_f9g4de11;
            this.pictureBox1.Location = new System.Drawing.Point(2, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(260, 217);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Font = new System.Drawing.Font("Mongolian Baiti", 12F);
            this.lblid.ForeColor = System.Drawing.Color.Teal;
            this.lblid.Location = new System.Drawing.Point(662, 109);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(21, 16);
            this.lblid.TabIndex = 31;
            this.lblid.Text = "Id";
            this.lblid.Visible = false;
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(744, 109);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(243, 20);
            this.txtid.TabIndex = 32;
            this.txtid.Visible = false;
            // 
            // lblwarning
            // 
            this.lblwarning.AutoSize = true;
            this.lblwarning.Location = new System.Drawing.Point(629, 396);
            this.lblwarning.Name = "lblwarning";
            this.lblwarning.Size = new System.Drawing.Size(358, 13);
            this.lblwarning.TabIndex = 33;
            this.lblwarning.Text = "Nota: Solo introduzca la cédula del paciente para actualizar y borrar datos.";
            // 
            // dgvdatasearchpatiente
            // 
            this.dgvdatasearchpatiente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdatasearchpatiente.Location = new System.Drawing.Point(2, 226);
            this.dgvdatasearchpatiente.Name = "dgvdatasearchpatiente";
            this.dgvdatasearchpatiente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvdatasearchpatiente.Size = new System.Drawing.Size(536, 237);
            this.dgvdatasearchpatiente.TabIndex = 34;
            // 
            // mant_pacientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1016, 523);
            this.Controls.Add(this.dgvdatasearchpatiente);
            this.Controls.Add(this.lblwarning);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.lblid);
            this.Controls.Add(this.btnbacking);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnvolver);
            this.Controls.Add(this.lbltitleDoctor);
            this.Controls.Add(this.btnBorrarpaciente);
            this.Controls.Add(this.btnactualizarpaciente);
            this.Controls.Add(this.btnguardarpaciente);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.radiobtnNoAsegurado);
            this.Controls.Add(this.radiobtnAsegurado);
            this.Controls.Add(this.txtcedula);
            this.Controls.Add(this.lblcedula);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.lblName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "mant_pacientes";
            this.Text = "Mantenimiento de pacientes";
            this.Load += new System.EventHandler(this.mant_pacientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdatasearchpatiente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label lblcedula;
        private System.Windows.Forms.TextBox txtcedula;
        private System.Windows.Forms.RadioButton radiobtnAsegurado;
        private System.Windows.Forms.RadioButton radiobtnNoAsegurado;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnguardarpaciente;
        private System.Windows.Forms.Button btnactualizarpaciente;
        private System.Windows.Forms.Button btnBorrarpaciente;
        private System.Windows.Forms.Label lbltitleDoctor;
        private System.Windows.Forms.Button btnvolver;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnbacking;
        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label lblwarning;
        private System.Windows.Forms.DataGridView dgvdatasearchpatiente;
    }
}
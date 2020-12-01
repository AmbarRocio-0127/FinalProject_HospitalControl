namespace Control_Médico
{
    partial class Mant_Doctores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mant_Doctores));
            this.btnguardarmedico = new System.Windows.Forms.Button();
            this.btnactualizar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.lblespecialidad = new System.Windows.Forms.Label();
            this.lblexequatur = new System.Windows.Forms.Label();
            this.lbltitleDoctor = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtespecialidad = new System.Windows.Forms.TextBox();
            this.txtexequatur = new System.Windows.Forms.TextBox();
            this.btnvolver = new System.Windows.Forms.Button();
            this.lblcedula_ = new System.Windows.Forms.Label();
            this.txtcedula = new System.Windows.Forms.TextBox();
            this.lblwarning = new System.Windows.Forms.Label();
            this.btnbacking = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dgvdatasearchdoctor = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdatasearchdoctor)).BeginInit();
            this.SuspendLayout();
            // 
            // btnguardarmedico
            // 
            this.btnguardarmedico.BackColor = System.Drawing.Color.Teal;
            this.btnguardarmedico.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.btnguardarmedico.ForeColor = System.Drawing.Color.White;
            this.btnguardarmedico.Location = new System.Drawing.Point(26, 368);
            this.btnguardarmedico.Name = "btnguardarmedico";
            this.btnguardarmedico.Size = new System.Drawing.Size(100, 38);
            this.btnguardarmedico.TabIndex = 1;
            this.btnguardarmedico.Text = "Guardar";
            this.btnguardarmedico.UseVisualStyleBackColor = false;
            this.btnguardarmedico.Click += new System.EventHandler(this.btnguardarmedico_Click);
            // 
            // btnactualizar
            // 
            this.btnactualizar.BackColor = System.Drawing.Color.Teal;
            this.btnactualizar.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnactualizar.ForeColor = System.Drawing.Color.White;
            this.btnactualizar.Location = new System.Drawing.Point(165, 368);
            this.btnactualizar.Name = "btnactualizar";
            this.btnactualizar.Size = new System.Drawing.Size(90, 38);
            this.btnactualizar.TabIndex = 2;
            this.btnactualizar.Text = "Actualizar";
            this.btnactualizar.UseVisualStyleBackColor = false;
            this.btnactualizar.Click += new System.EventHandler(this.btnactualizar_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.BackColor = System.Drawing.Color.Teal;
            this.btnBorrar.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.btnBorrar.ForeColor = System.Drawing.Color.White;
            this.btnBorrar.Location = new System.Drawing.Point(316, 368);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(89, 38);
            this.btnBorrar.TabIndex = 3;
            this.btnBorrar.Text = "Eliminar";
            this.btnBorrar.UseVisualStyleBackColor = false;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Mongolian Baiti", 11F);
            this.lblName.ForeColor = System.Drawing.Color.Teal;
            this.lblName.Location = new System.Drawing.Point(23, 150);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(129, 16);
            this.lblName.TabIndex = 5;
            this.lblName.Text = "Nombre y Apellido";
            // 
            // lblespecialidad
            // 
            this.lblespecialidad.AutoSize = true;
            this.lblespecialidad.Font = new System.Drawing.Font("Mongolian Baiti", 11F);
            this.lblespecialidad.ForeColor = System.Drawing.Color.Teal;
            this.lblespecialidad.Location = new System.Drawing.Point(65, 229);
            this.lblespecialidad.Name = "lblespecialidad";
            this.lblespecialidad.Size = new System.Drawing.Size(87, 16);
            this.lblespecialidad.TabIndex = 6;
            this.lblespecialidad.Text = "Especialidad";
            // 
            // lblexequatur
            // 
            this.lblexequatur.AutoSize = true;
            this.lblexequatur.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblexequatur.ForeColor = System.Drawing.Color.Teal;
            this.lblexequatur.Location = new System.Drawing.Point(80, 268);
            this.lblexequatur.Name = "lblexequatur";
            this.lblexequatur.Size = new System.Drawing.Size(72, 16);
            this.lblexequatur.TabIndex = 7;
            this.lblexequatur.Text = "Exequatur";
            // 
            // lbltitleDoctor
            // 
            this.lbltitleDoctor.AutoSize = true;
            this.lbltitleDoctor.Font = new System.Drawing.Font("Times New Roman", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitleDoctor.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.lbltitleDoctor.Location = new System.Drawing.Point(12, 9);
            this.lbltitleDoctor.Name = "lbltitleDoctor";
            this.lbltitleDoctor.Size = new System.Drawing.Size(336, 31);
            this.lbltitleDoctor.TabIndex = 9;
            this.lbltitleDoctor.Text = "Mantenimiento De Doctores";
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(184, 150);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(243, 20);
            this.txtname.TabIndex = 10;
            // 
            // txtespecialidad
            // 
            this.txtespecialidad.Location = new System.Drawing.Point(184, 225);
            this.txtespecialidad.Name = "txtespecialidad";
            this.txtespecialidad.Size = new System.Drawing.Size(243, 20);
            this.txtespecialidad.TabIndex = 11;
            // 
            // txtexequatur
            // 
            this.txtexequatur.Location = new System.Drawing.Point(184, 268);
            this.txtexequatur.Name = "txtexequatur";
            this.txtexequatur.Size = new System.Drawing.Size(243, 20);
            this.txtexequatur.TabIndex = 12;
            // 
            // btnvolver
            // 
            this.btnvolver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnvolver.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnvolver.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnvolver.Location = new System.Drawing.Point(927, 446);
            this.btnvolver.Name = "btnvolver";
            this.btnvolver.Size = new System.Drawing.Size(103, 42);
            this.btnvolver.TabIndex = 13;
            this.btnvolver.Text = "Ir al Menú Principal";
            this.btnvolver.UseVisualStyleBackColor = false;
            this.btnvolver.Click += new System.EventHandler(this.btnvolver_Click);
            // 
            // lblcedula_
            // 
            this.lblcedula_.AutoSize = true;
            this.lblcedula_.Font = new System.Drawing.Font("Mongolian Baiti", 12F);
            this.lblcedula_.ForeColor = System.Drawing.Color.Teal;
            this.lblcedula_.Location = new System.Drawing.Point(99, 189);
            this.lblcedula_.Name = "lblcedula_";
            this.lblcedula_.Size = new System.Drawing.Size(53, 16);
            this.lblcedula_.TabIndex = 14;
            this.lblcedula_.Text = "Cédula";
            // 
            // txtcedula
            // 
            this.txtcedula.Location = new System.Drawing.Point(184, 188);
            this.txtcedula.Name = "txtcedula";
            this.txtcedula.Size = new System.Drawing.Size(243, 20);
            this.txtcedula.TabIndex = 15;
            // 
            // lblwarning
            // 
            this.lblwarning.AutoSize = true;
            this.lblwarning.Location = new System.Drawing.Point(65, 431);
            this.lblwarning.Name = "lblwarning";
            this.lblwarning.Size = new System.Drawing.Size(315, 26);
            this.lblwarning.TabIndex = 16;
            this.lblwarning.Text = "Nota: Solo introduzca el id para actualizar y borrar datos, no para \r\nguardarlos." +
    "";
            // 
            // btnbacking
            // 
            this.btnbacking.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnbacking.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbacking.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnbacking.Location = new System.Drawing.Point(776, 446);
            this.btnbacking.Name = "btnbacking";
            this.btnbacking.Size = new System.Drawing.Size(103, 42);
            this.btnbacking.TabIndex = 19;
            this.btnbacking.Text = "Volver atrás";
            this.btnbacking.UseVisualStyleBackColor = false;
            this.btnbacking.Click += new System.EventHandler(this.btnbacking_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Control_Médico.Properties.Resources.images;
            this.pictureBox2.Location = new System.Drawing.Point(717, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(162, 166);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 18;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Control_Médico.Properties.Resources.images__1_;
            this.pictureBox1.Location = new System.Drawing.Point(885, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(156, 166);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // dgvdatasearchdoctor
            // 
            this.dgvdatasearchdoctor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdatasearchdoctor.Location = new System.Drawing.Point(455, 203);
            this.dgvdatasearchdoctor.Name = "dgvdatasearchdoctor";
            this.dgvdatasearchdoctor.Size = new System.Drawing.Size(575, 237);
            this.dgvdatasearchdoctor.TabIndex = 40;
            // 
            // Mant_Doctores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1042, 500);
            this.Controls.Add(this.dgvdatasearchdoctor);
            this.Controls.Add(this.btnbacking);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblwarning);
            this.Controls.Add(this.txtcedula);
            this.Controls.Add(this.lblcedula_);
            this.Controls.Add(this.btnvolver);
            this.Controls.Add(this.txtexequatur);
            this.Controls.Add(this.txtespecialidad);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.lbltitleDoctor);
            this.Controls.Add(this.lblexequatur);
            this.Controls.Add(this.lblespecialidad);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnactualizar);
            this.Controls.Add(this.btnguardarmedico);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Mant_Doctores";
            this.Text = "Gestión De Doctores";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdatasearchdoctor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnguardarmedico;
        private System.Windows.Forms.Button btnactualizar;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblespecialidad;
        private System.Windows.Forms.Label lblexequatur;
        private System.Windows.Forms.Label lbltitleDoctor;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtespecialidad;
        private System.Windows.Forms.TextBox txtexequatur;
        private System.Windows.Forms.Button btnvolver;
        private System.Windows.Forms.Label lblcedula_;
        private System.Windows.Forms.TextBox txtcedula;
        private System.Windows.Forms.Label lblwarning;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnbacking;
        private System.Windows.Forms.DataGridView dgvdatasearchdoctor;
    }
}
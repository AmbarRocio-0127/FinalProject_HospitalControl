namespace Control_Médico
{
    partial class Mant_Rooms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mant_Rooms));
            this.lbltitleDoctor = new System.Windows.Forms.Label();
            this.lblnumber = new System.Windows.Forms.Label();
            this.lbltype = new System.Windows.Forms.Label();
            this.lblprecio = new System.Windows.Forms.Label();
            this.txtnum = new System.Windows.Forms.TextBox();
            this.txttype = new System.Windows.Forms.TextBox();
            this.txtprice = new System.Windows.Forms.TextBox();
            this.btnsaveroom = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.lblwarning = new System.Windows.Forms.Label();
            this.btnvolver = new System.Windows.Forms.Button();
            this.btnbacking = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dgvdatasearchroom = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdatasearchroom)).BeginInit();
            this.SuspendLayout();
            // 
            // lbltitleDoctor
            // 
            this.lbltitleDoctor.AutoSize = true;
            this.lbltitleDoctor.Font = new System.Drawing.Font("Times New Roman", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitleDoctor.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.lbltitleDoctor.Location = new System.Drawing.Point(550, 9);
            this.lbltitleDoctor.Name = "lbltitleDoctor";
            this.lbltitleDoctor.Size = new System.Drawing.Size(385, 31);
            this.lbltitleDoctor.TabIndex = 10;
            this.lbltitleDoctor.Text = "Mantenimiento De Habitaciones";
            // 
            // lblnumber
            // 
            this.lblnumber.AutoSize = true;
            this.lblnumber.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnumber.ForeColor = System.Drawing.Color.Teal;
            this.lblnumber.Location = new System.Drawing.Point(585, 115);
            this.lblnumber.Name = "lblnumber";
            this.lblnumber.Size = new System.Drawing.Size(59, 16);
            this.lblnumber.TabIndex = 19;
            this.lblnumber.Text = "Número";
            // 
            // lbltype
            // 
            this.lbltype.AutoSize = true;
            this.lbltype.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltype.ForeColor = System.Drawing.Color.Teal;
            this.lbltype.Location = new System.Drawing.Point(607, 152);
            this.lbltype.Name = "lbltype";
            this.lbltype.Size = new System.Drawing.Size(37, 16);
            this.lbltype.TabIndex = 20;
            this.lbltype.Text = "Tipo";
            // 
            // lblprecio
            // 
            this.lblprecio.AutoSize = true;
            this.lblprecio.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblprecio.ForeColor = System.Drawing.Color.Teal;
            this.lblprecio.Location = new System.Drawing.Point(546, 192);
            this.lblprecio.Name = "lblprecio";
            this.lblprecio.Size = new System.Drawing.Size(98, 16);
            this.lblprecio.TabIndex = 21;
            this.lblprecio.Text = "Precio por Día";
            // 
            // txtnum
            // 
            this.txtnum.Location = new System.Drawing.Point(664, 114);
            this.txtnum.Name = "txtnum";
            this.txtnum.Size = new System.Drawing.Size(243, 20);
            this.txtnum.TabIndex = 22;
            // 
            // txttype
            // 
            this.txttype.Location = new System.Drawing.Point(664, 152);
            this.txttype.Name = "txttype";
            this.txttype.Size = new System.Drawing.Size(243, 20);
            this.txttype.TabIndex = 23;
            // 
            // txtprice
            // 
            this.txtprice.Location = new System.Drawing.Point(664, 188);
            this.txtprice.Name = "txtprice";
            this.txtprice.Size = new System.Drawing.Size(243, 20);
            this.txtprice.TabIndex = 24;
            // 
            // btnsaveroom
            // 
            this.btnsaveroom.BackColor = System.Drawing.Color.Teal;
            this.btnsaveroom.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.btnsaveroom.ForeColor = System.Drawing.Color.White;
            this.btnsaveroom.Location = new System.Drawing.Point(597, 277);
            this.btnsaveroom.Name = "btnsaveroom";
            this.btnsaveroom.Size = new System.Drawing.Size(100, 38);
            this.btnsaveroom.TabIndex = 25;
            this.btnsaveroom.Text = "Guardar";
            this.btnsaveroom.UseVisualStyleBackColor = false;
            this.btnsaveroom.Click += new System.EventHandler(this.btnsaveroom_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.BackColor = System.Drawing.Color.Teal;
            this.btnupdate.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.ForeColor = System.Drawing.Color.White;
            this.btnupdate.Location = new System.Drawing.Point(713, 277);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(90, 38);
            this.btnupdate.TabIndex = 26;
            this.btnupdate.Text = "Actualizar";
            this.btnupdate.UseVisualStyleBackColor = false;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.BackColor = System.Drawing.Color.Teal;
            this.btnBorrar.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.btnBorrar.ForeColor = System.Drawing.Color.White;
            this.btnBorrar.Location = new System.Drawing.Point(818, 277);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(89, 38);
            this.btnBorrar.TabIndex = 27;
            this.btnBorrar.Text = "Eliminar";
            this.btnBorrar.UseVisualStyleBackColor = false;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // lblwarning
            // 
            this.lblwarning.AutoSize = true;
            this.lblwarning.Location = new System.Drawing.Point(572, 365);
            this.lblwarning.Name = "lblwarning";
            this.lblwarning.Size = new System.Drawing.Size(344, 13);
            this.lblwarning.TabIndex = 28;
            this.lblwarning.Text = "Nota: Introduzca el número de habitación para actualizar y borrar datos.";
            // 
            // btnvolver
            // 
            this.btnvolver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnvolver.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnvolver.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnvolver.Location = new System.Drawing.Point(22, 444);
            this.btnvolver.Name = "btnvolver";
            this.btnvolver.Size = new System.Drawing.Size(103, 42);
            this.btnvolver.TabIndex = 29;
            this.btnvolver.Text = "Ir al Menú Principal";
            this.btnvolver.UseVisualStyleBackColor = false;
            this.btnvolver.Click += new System.EventHandler(this.btnvolver_Click);
            // 
            // btnbacking
            // 
            this.btnbacking.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnbacking.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbacking.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnbacking.Location = new System.Drawing.Point(160, 444);
            this.btnbacking.Name = "btnbacking";
            this.btnbacking.Size = new System.Drawing.Size(103, 42);
            this.btnbacking.TabIndex = 30;
            this.btnbacking.Text = "Volver atrás";
            this.btnbacking.UseVisualStyleBackColor = false;
            this.btnbacking.Click += new System.EventHandler(this.btnbacking_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Control_Médico.Properties.Resources.ilustracion_dibujos_animados_transformador_cama_mesita_noche_hospital_aislado_blanco_126520_240;
            this.pictureBox1.Location = new System.Drawing.Point(2, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(237, 189);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // dgvdatasearchroom
            // 
            this.dgvdatasearchroom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdatasearchroom.Location = new System.Drawing.Point(12, 201);
            this.dgvdatasearchroom.Name = "dgvdatasearchroom";
            this.dgvdatasearchroom.Size = new System.Drawing.Size(513, 237);
            this.dgvdatasearchroom.TabIndex = 41;
            // 
            // Mant_Rooms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(947, 498);
            this.Controls.Add(this.dgvdatasearchroom);
            this.Controls.Add(this.btnbacking);
            this.Controls.Add(this.btnvolver);
            this.Controls.Add(this.lblwarning);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btnsaveroom);
            this.Controls.Add(this.txtprice);
            this.Controls.Add(this.txttype);
            this.Controls.Add(this.txtnum);
            this.Controls.Add(this.lblprecio);
            this.Controls.Add(this.lbltype);
            this.Controls.Add(this.lblnumber);
            this.Controls.Add(this.lbltitleDoctor);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Mant_Rooms";
            this.Text = "Mantenimiento de Habitaciones";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdatasearchroom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbltitleDoctor;
        private System.Windows.Forms.Label lblnumber;
        private System.Windows.Forms.Label lbltype;
        private System.Windows.Forms.Label lblprecio;
        private System.Windows.Forms.TextBox txtnum;
        private System.Windows.Forms.TextBox txttype;
        private System.Windows.Forms.TextBox txtprice;
        private System.Windows.Forms.Button btnsaveroom;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Label lblwarning;
        private System.Windows.Forms.Button btnvolver;
        private System.Windows.Forms.Button btnbacking;
        private System.Windows.Forms.DataGridView dgvdatasearchroom;
    }
}
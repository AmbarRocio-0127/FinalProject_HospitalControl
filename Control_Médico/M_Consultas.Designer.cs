namespace Control_Médico
{
    partial class M_Consultas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(M_Consultas));
            this.lblConsultas = new System.Windows.Forms.Label();
            this.buttonvolver = new System.Windows.Forms.Button();
            this.dataGridViewconsulta = new System.Windows.Forms.DataGridView();
            this.Bienvenida = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewconsulta)).BeginInit();
            this.SuspendLayout();
            // 
            // lblConsultas
            // 
            this.lblConsultas.AutoSize = true;
            this.lblConsultas.Font = new System.Drawing.Font("Times New Roman", 30F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsultas.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.lblConsultas.Location = new System.Drawing.Point(660, 9);
            this.lblConsultas.Name = "lblConsultas";
            this.lblConsultas.Size = new System.Drawing.Size(354, 46);
            this.lblConsultas.TabIndex = 29;
            this.lblConsultas.Text = "Módulo De Listados";
            // 
            // buttonvolver
            // 
            this.buttonvolver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonvolver.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonvolver.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonvolver.Location = new System.Drawing.Point(925, 491);
            this.buttonvolver.Name = "buttonvolver";
            this.buttonvolver.Size = new System.Drawing.Size(96, 48);
            this.buttonvolver.TabIndex = 62;
            this.buttonvolver.Text = "Volver al menú principal";
            this.buttonvolver.UseVisualStyleBackColor = false;
            this.buttonvolver.Click += new System.EventHandler(this.buttonvolver_Click);
            // 
            // dataGridViewconsulta
            // 
            this.dataGridViewconsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewconsulta.Location = new System.Drawing.Point(308, 119);
            this.dataGridViewconsulta.Name = "dataGridViewconsulta";
            this.dataGridViewconsulta.Size = new System.Drawing.Size(713, 346);
            this.dataGridViewconsulta.TabIndex = 65;
            // 
            // Bienvenida
            // 
            this.Bienvenida.AutoSize = true;
            this.Bienvenida.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Bienvenida.Font = new System.Drawing.Font("Mongolian Baiti", 12F);
            this.Bienvenida.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Bienvenida.Location = new System.Drawing.Point(12, 23);
            this.Bienvenida.Name = "Bienvenida";
            this.Bienvenida.Size = new System.Drawing.Size(322, 48);
            this.Bienvenida.TabIndex = 74;
            this.Bienvenida.Text = "¡Bienvenido al Módulo De Listados! \r\n\r\nElija la opción Deseada para listar a cont" +
    "inuación.";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Teal;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(15, 119);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(258, 38);
            this.button1.TabIndex = 76;
            this.button1.Text = "Listar Pacientes";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Teal;
            this.button2.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(15, 179);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(258, 38);
            this.button2.TabIndex = 77;
            this.button2.Text = "Listar Doctores";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Teal;
            this.button3.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(15, 240);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(258, 38);
            this.button3.TabIndex = 78;
            this.button3.Text = "Listar Habitaciones";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Teal;
            this.button4.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(20, 300);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(253, 38);
            this.button4.TabIndex = 79;
            this.button4.Text = "Listar Citas";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Teal;
            this.button5.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(20, 358);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(253, 38);
            this.button5.TabIndex = 80;
            this.button5.Text = "Listar Internamientos";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Teal;
            this.button6.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(20, 427);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(253, 38);
            this.button6.TabIndex = 81;
            this.button6.Text = "Listar Pacientes De Alta";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // M_Consultas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1045, 551);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Bienvenida);
            this.Controls.Add(this.dataGridViewconsulta);
            this.Controls.Add(this.buttonvolver);
            this.Controls.Add(this.lblConsultas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "M_Consultas";
            this.Text = "Módulo de Consultas";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewconsulta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblConsultas;
        private System.Windows.Forms.Button buttonvolver;
        private System.Windows.Forms.DataGridView dataGridViewconsulta;
        private System.Windows.Forms.Label Bienvenida;
        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.Button button2;
        public System.Windows.Forms.Button button3;
        public System.Windows.Forms.Button button4;
        public System.Windows.Forms.Button button5;
        public System.Windows.Forms.Button button6;
    }
}
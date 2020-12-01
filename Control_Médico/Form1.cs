using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using MySql.Data.MySqlClient;
using LogicaDeNegocios;

namespace Control_Médico
{
    public partial class gestionHosp : Form
    {
        public gestionHosp()
        {
            InitializeComponent();
        }

        private void btnmantenimientos_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Gestion_mantenimientos gest_mant = new Gestion_mantenimientos();
            gest_mant.Show();
        }

        private void btnprocesos_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Modulos_Procesos mod_proces = new Modulos_Procesos();
            mod_proces.Show();
        }

        private void btbConsultas_Click(object sender, EventArgs e)
        {
            M_Consultas consult = new M_Consultas();
            this.Visible = false;
            consult.Show();
        }
    }
}

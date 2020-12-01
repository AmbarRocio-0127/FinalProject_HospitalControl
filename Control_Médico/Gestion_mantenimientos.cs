using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LogicaDeNegocios;

namespace Control_Médico
{
    public partial class Gestion_mantenimientos : Form
    {
        public Gestion_mantenimientos()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            gestionHosp gest_h = new gestionHosp();
            gest_h.Show();
        }

        private void btnmant_Doctores_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Mant_Doctores mt_doc = new Mant_Doctores();
            mt_doc.Show();
        }

        private void btnmant_pacientes_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            mant_pacientes mn_pac = new mant_pacientes();
            mn_pac.Show();
        }

        private void btnmant_Rooms_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Mant_Rooms mant_room = new Mant_Rooms();
            mant_room.Show();
        }
    }
}

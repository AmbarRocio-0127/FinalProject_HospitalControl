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
    public partial class M_Consultas : Form
    {
        public M_Consultas()
        {
            InitializeComponent();
        }

        Consulta_Context_Strategy consultar;

        private void buttonvolver_Click(object sender, EventArgs e)
        {
            this.Close();
            gestionHosp ges_h = new gestionHosp();
            ges_h.Visible = true;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            consultar = new Consulta_Context_Strategy(new Patiente());
            dataGridViewconsulta.DataSource = consultar.Listar();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            consultar = new Consulta_Context_Strategy(new Doctor());
            dataGridViewconsulta.DataSource = consultar.Listar();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            consultar = new Consulta_Context_Strategy(new Rooms());
            dataGridViewconsulta.DataSource = consultar.Listar();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            consultar = new Consulta_Context_Strategy(new Appointment());
            dataGridViewconsulta.DataSource = consultar.Listar();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            consultar = new Consulta_Context_Strategy(new Internships());
            dataGridViewconsulta.DataSource = consultar.Listar();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            consultar = new Consulta_Context_Strategy(new Alta());
            dataGridViewconsulta.DataSource = consultar.Listar();
        }
    }
}

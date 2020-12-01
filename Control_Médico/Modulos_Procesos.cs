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
    public partial class Modulos_Procesos : Form
    {
        public Modulos_Procesos()
        {
            InitializeComponent();
        }

        private void btnvolver_Click(object sender, EventArgs e)
        {
            this.Close();
            gestionHosp hp = new gestionHosp();
            hp.Visible = true;
        }

        private void btncitasmedicas_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Citas modulo_cita = new Citas();
            modulo_cita.Show();
        }

        private void btninternamientos_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Internamiento internship_ = new Internamiento();
            internship_.Show();
        }

        private void btnAltamedica_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Alta_medica a_m = new Alta_medica();
            a_m.Show();

           /* Alta al = new Alta();
            DataTable data = al.;
            a_m.dataGridViewaltas .DataSource = data;
            ConnectionDB.close_connection();
            MessageBox.Show("¡Por favor, seleccione el id de internamiento del paciente que será dado de alta e ingrese la fecha de salida.!");*/
        }
        
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LogicaDeNegocios;

namespace Control_Médico
{
    public partial class Citas : Form
    {
        public Citas()
        {
            InitializeComponent();
        }

        Appointment ct = new Appointment();
        private void btnbacking_Click(object sender, EventArgs e)
        {
            this.Close();
            Modulos_Procesos m_p = new Modulos_Procesos();
            m_p.Visible = true;
        }

        private void btnvolver_Click(object sender, EventArgs e)
        {
            this.Close();
            gestionHosp gest_ = new gestionHosp();
            gest_.Visible = true;
        }

        private void btnguardarcitas_Click(object sender, EventArgs e)
        {
            try
            {
                ct.Insertar_cita(txtfecha.Text, txthoracita.Text, txtpaciente.Text, txtdoctor.Text);
                MessageBox.Show("¡Datos Insertados exitósamente!");
                dataGridViewcitas.DataSource =  ct.Listar();
            }
            catch(Exception exp)
            {
                MessageBox.Show("ERROR. " + exp.Message);
            }
        }

        private void btnactualizarcita_Click(object sender, EventArgs e)
        {
            try
            {
                ct.Actualizando_cita(txtid.Text, txtfecha.Text, txthoracita.Text, txtpaciente.Text, txtdoctor.Text);
                MessageBox.Show("¡Datos actualizados exitósamente!");
                dataGridViewcitas.DataSource = ct.Listar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR. " + ex.Message);
            }
        }

        private void btnListing_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception exp)
            {
                MessageBox.Show("ERROR. " + exp.Message);
            }
        }

        private void btnBorrarcitas_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("¿Está seguro que desea eliminar éste registro?", "¿Está Seguro?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    ct.Borrar_cita(txtid.Text);
                    MessageBox.Show("¡Cita Borrada Exitósamente!");
                    dataGridViewcitas.DataSource = ct.Listar();
                }
                else
                {
                    MessageBox.Show("No se han realizado cambios en el registro de Citas");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR. " + ex.Message);
            }
        }
    }
}

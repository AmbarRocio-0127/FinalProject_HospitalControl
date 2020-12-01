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
    public partial class mant_pacientes : Form
    {
        Patiente paciente = new Patiente();
        public mant_pacientes()
        {
            InitializeComponent();
        }

        private void btnvolver_Click(object sender, EventArgs e)
        {
            this.Close();
            gestionHosp hp = new gestionHosp();
            hp.Visible = true;
        }
        private void btnbacking_Click(object sender, EventArgs e)
        {
            this.Close();
            Gestion_mantenimientos gest_h = new Gestion_mantenimientos();
            gest_h.Visible = true;
        }

        private void btnguardarmedico_Click(object sender, EventArgs e)
        {
            try
            {
                paciente.Insertar_paciente_(txtcedula.Text, txtname.Text, radiobtnAsegurado.Checked == true ? "Asegurado" : "No Asegurado");
                MessageBox.Show("¡Datos del Paciente Guardados exitósamente!");
                dgvdatasearchpatiente.DataSource = paciente.Listar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR. " + ex.Message);
            }
        }

        private void btnactualizarpaciente_Click(object sender, EventArgs e)
        {
            try
            {
                paciente.Actualizando_paciente_(txtcedula.Text, txtname.Text, radiobtnAsegurado.Checked == true ? "Asegurado" : "No Asegurado");
                MessageBox.Show("¡Datos del paciente actualizados exitósamente!");
                dgvdatasearchpatiente.DataSource = paciente.Listar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR. " + ex.Message);
            }
        }

        private void btnBorrarpaciente_Click(object sender, EventArgs e)
        {
            try
           {
                if (MessageBox.Show("¿Está seguro que desea eliminar éste registro?", "¿Está Seguro?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    paciente.Borrar_paciente(txtcedula.Text);
                    MessageBox.Show("¡Datos del Paciente borrados exitósamente!");
                    dgvdatasearchpatiente.DataSource = paciente.Listar();
                }
                else
                {
                    MessageBox.Show("No se han realizado cambios en el registro de pacientes");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error. " + ex.Message);
            }
        }
    }
}


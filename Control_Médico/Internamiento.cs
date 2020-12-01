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
    public partial class Internamiento : Form
    {
        Internships intern = new Internships();
        public Internamiento()
        {
            InitializeComponent();
        }

        private void btnbacking_Click(object sender, EventArgs e)
        {
            this.Close();
            Modulos_Procesos m_p = new Modulos_Procesos();
            m_p.Visible = true;
        }

        private void btnvolver_Click(object sender, EventArgs e)
        {
            this.Close();
            gestionHosp g_p = new gestionHosp();
            g_p.Visible = true;
        }

        private void btnupdateinternship_Click(object sender, EventArgs e)
        {
            try
            {
                intern.Actualizando_internamiento(txtfecha.Text, txtPaciente.Text, txthabitacion.Text, txtid.Text);
                MessageBox.Show("¡Datos actualizados exitósamente!");
                dataGridView1.DataSource = intern.Listar();
            }
            catch (Exception exp)
            {
                MessageBox.Show("ERROR. " + exp.Message);
            }
        }

        private void btnListing_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.DataSource = intern.Listar();
            }
            catch (Exception exx_)
            {
                MessageBox.Show("Error. " + exx_.Message);
            }
        }

        private void btnBorrarinternamiento_Click(object sender, EventArgs e)
        {
            try
            {
                intern.Borrar_internamiento(txtid.Text);
                MessageBox.Show("¡Datos del internamiento Borrados exitósamente!");
                dataGridView1.DataSource = intern.Listar();

            }
            catch (Exception x)
            {
                MessageBox.Show("ERROR. " + x.Message);
            }
        }

        private void btnguardarintenamiento_Click(object sender, EventArgs e)
        {
            try
            {
                intern.Insertar_internamiento(txtfecha.Text, txtPaciente.Text, txthabitacion.Text);
                MessageBox.Show("¡Internamiento agregado exitósamente!");
                dataGridView1.DataSource = intern.Listar();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error. " + ex.Message);
            }
        }
    }
}

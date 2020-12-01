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
    public partial class Mant_Doctores : Form
    {  
        Doctor doc = new Doctor();
        public Mant_Doctores()
        {
            InitializeComponent();
        }

        private void btnvolver_Click(object sender, EventArgs e)
        {
            this.Close();
            gestionHosp gest_hosp = new gestionHosp();
            gest_hosp.Show();
        }

        private void btnbacking_Click(object sender, EventArgs e)
        {
            this.Close();
            Gestion_mantenimientos ges_mnt = new Gestion_mantenimientos();
            ges_mnt.Visible = true;
        }

        private void btnguardarmedico_Click(object sender, EventArgs e)
        {
            try
            {
                doc.Insertar_doctor(txtname.Text, txtcedula.Text, txtexequatur.Text, txtespecialidad.Text);
                MessageBox.Show("¡Datos del Doctor Guardados exitósamente!");
                dgvdatasearchdoctor.DataSource = doc.Listar();
            }
            catch (Exception exp)
            {
                MessageBox.Show("ERROR. " + exp.Message);
            }
        }

        private void btnactualizar_Click(object sender, EventArgs e)
        {
            try
            {
                doc.Actualizando_doctor(txtname.Text, txtcedula.Text, txtexequatur.Text, txtespecialidad.Text);
                MessageBox.Show("¡Datos del Doctor actualizados exitósamente!");
                dgvdatasearchdoctor.DataSource = doc.Listar();
            }
            catch (Exception exp)
            {
                MessageBox.Show("ERROR. " + exp.Message);
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            try
            {
               if (MessageBox.Show("¿Está seguro que desea eliminar éste registro?", "¿Está Seguro?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    doc.Borrar_doctor(txtcedula.Text);
                    MessageBox.Show("¡Datos del Doctor borrados exitósamente!");
                    dgvdatasearchdoctor.DataSource = doc.Listar();
                }
                else
                {
                    MessageBox.Show("No se han realizado cambios en el registro de doctores");
                }
            }
           catch (Exception exp)
            {
                MessageBox.Show("ERROR. " + exp.Message);
            }
        }
    }
}

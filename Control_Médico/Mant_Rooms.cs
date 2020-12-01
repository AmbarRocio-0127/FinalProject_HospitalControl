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
    public partial class Mant_Rooms : Form 
    {
        Rooms crdRooms = new Rooms();
        public Mant_Rooms()
        {
            InitializeComponent();
        }

        private void btnvolver_Click(object sender, EventArgs e)
        {
            this.Close();
            gestionHosp gst_hsp = new gestionHosp();
            gst_hsp.Visible = true;
        }

        private void btnbacking_Click(object sender, EventArgs e)
        {
            this.Close();
            Gestion_mantenimientos gest_mant = new Gestion_mantenimientos();
            gest_mant.Visible = true;
        }

        private void btnsaveroom_Click(object sender, EventArgs e)
        {
            try
            {
                crdRooms.Insertar_habitacion(txtnum.Text, txttype.Text, txtprice.Text);
                MessageBox.Show("¡Habitación Registrada exitósamente!");
                dgvdatasearchroom.DataSource = crdRooms.Listar();
            }
            catch (Exception exp)
            {
                MessageBox.Show("ERROR. " + exp.Message);
            }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            try
            {
                crdRooms.Actualizando_habitacion(txtnum.Text, txttype.Text, txtprice.Text);
                MessageBox.Show("¡Habitación actualizados exitósamente!");
                dgvdatasearchroom.DataSource = crdRooms.Listar();
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
                    crdRooms.Borrar_habitacion(txtnum.Text);
                    MessageBox.Show("¡Habitación Eliminada exitósamente!");
                    dgvdatasearchroom.DataSource = crdRooms.Listar();
                }
                else
                {
                    MessageBox.Show("No se han realizado cambios en el registro de habitaciones");
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show("ERROR. " + exp.Message);
            }
        }
    }
}

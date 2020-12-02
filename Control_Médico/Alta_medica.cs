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
    public partial class Alta_medica : Form
    {
        public Alta_medica()
        {
            InitializeComponent();
        }
        Alta elt_ = new Alta();
        Internships intern_ = new Internships();

        private void btnbacking_Click(object sender, EventArgs e)
        {
            this.Close();
            Modulos_Procesos m_d = new Modulos_Procesos();
            m_d.Visible = true;
        }

        private void btnvolver_Click(object sender, EventArgs e)
        {
            this.Close();
            gestionHosp gh_ = new gestionHosp();
            gh_.Visible = true;
        }

        private void btnlistinternamientos_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridViewaltas.DataSource = intern_.Listar();
            }
            catch (Exception exx_)
            {
                MessageBox.Show("Error. " + exx_.Message);
            }
        }

        private void btnguardarpaciente_Click(object sender, EventArgs e)
        {
            try
            {
                elt_.Insertar_Alta(txtSalida.Text, txt_IDI.Text);
                MessageBox.Show("¡Datos Insertados exitósamente!");
            }
            catch (Exception exe)
            {
                MessageBox.Show("ERROR. " + exe.Message);
            }
        }

        private void btnactualizarpaciente_Click(object sender, EventArgs e)
        {
            try
            {
                elt_.Actualizando_Alta(txtSalida.Text, txt_IDI.Text, txtidaltas.Text);
                MessageBox.Show("¡Datos actualizados exitósamente!");
            }
            catch (Exception exx)
            {
                MessageBox.Show("ERROR. " + exx.Message);
            }
        }

        private void btnBorraralta_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("¿Está seguro que desea eliminar éste registro?", "¿Está Seguro?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    elt_.Borrar_Alta(txtidaltas.Text);
                    MessageBox.Show("¡Registro Borrada Exitósamente!");
                    dataGridViewaltas.DataSource = elt_.Listar();
                }
                else
                {
                    MessageBox.Show("No se han realizado cambios en el registro Altas Médicas");
                }
            }
            catch (Exception x)
            {
                MessageBox.Show("ERROR. " + x.Message);
            }
        }

        private void btnlistaraltas_Click(object sender, EventArgs e)
        {
            dataGridViewaltas.DataSource = elt_.Listar();
        }

        private void Alta_medica_Load(object sender, EventArgs e)
        {

        }
    }
}

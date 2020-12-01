using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaAccesoDatos;
using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace LogicaDeNegocios
{
    public class Alta : I_Consult_Strategy
    {
        CRUDAltas crdaltas = CRUDAltas.Obtener_Instancia();

        private string Fecha_salida;
        private int id_alta;
        private int id_internamiento;

        public string F_salida
        {
            get
            {
                return Fecha_salida;
            }
            set
            {
                Fecha_salida = value;
            }
        }

        public int ID_A
        {
            get
            {
                return id_alta;
            }
            set
            {
                id_alta = value;
            }
        }

        public int ID_I
        {
            get
            {
                return id_internamiento;
            }
            set
            {
                id_internamiento = value;
            }
        }

        public void Insertar_Alta(string Fecha_alta, string id_internamiento)
        {
            F_salida = Fecha_alta;
            ID_I = Convert.ToInt32(id_internamiento);
            crdaltas.insertando_Alta(F_salida, ID_I);
        }

        public void Actualizando_Alta(string Fecha_alta, string id_internamiento, string id_med_disc)
        {
            F_salida = Fecha_alta;
            ID_I = Convert.ToInt32(id_internamiento);
            ID_A = Convert.ToInt32(id_med_disc);
            crdaltas.Actualizando_Alta(F_salida, ID_I, ID_A);
        }

        public void Borrar_Alta(string id_med_disc)
        {
            ID_A = Convert.ToInt32(id_med_disc);
            crdaltas.Borrar_Alta(ID_A);
        }

        public DataTable Listar()
        {
            DataTable dt = new DataTable();
            dt = crdaltas.Consulta_Altas();
            return dt;
        }
    }
}

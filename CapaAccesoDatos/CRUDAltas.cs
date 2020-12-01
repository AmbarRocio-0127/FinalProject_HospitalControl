using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;
using CapaAccesoDatos;

namespace CapaAccesoDatos
{
    public class CRUDAltas
    {
        private static CRUDAltas Instancia_Altas;

        MySqlDataReader read;
        ClassConexion c = new ClassConexion();
        MySqlCommand comando = new MySqlCommand();
        DataTable tabla_datos = new DataTable();

        private CRUDAltas() { }

        public static CRUDAltas Obtener_Instancia()
        {
            if (Instancia_Altas == null)
            {
                Instancia_Altas = new CRUDAltas();
            }
            return Instancia_Altas;
        }

        public void insertando_Alta(string Fecha_alta, int id_internamiento)
        {
            comando.Connection = c.Open_Conection();
            comando.CommandText = "insert into medical_discharge (Fecha_Alta, id_Internships) values ('" + Fecha_alta + "', " + id_internamiento + ");";
            comando.ExecuteNonQuery();
            c.Closed_Conection();
        }

        public void Actualizando_Alta(string Fecha_alta, int id_internamiento, int id_med_disc)
        {
            comando.Connection = c.Open_Conection();
            comando.CommandText = "Update medical_discharge set Fecha_Alta = '" + Fecha_alta + "', id_internships = " + id_internamiento + " where id_med_disc = " + id_med_disc + ";";
            comando.ExecuteNonQuery();
            c.Closed_Conection();
        }

        public void Borrar_Alta(int idalta)
        {
            comando.Connection = c.Open_Conection();
            comando.CommandText = "Delete from medical_discharge where id_med_disc = " + idalta + ";";
            comando.ExecuteNonQuery();
            c.Closed_Conection();
        }

        public DataTable Consulta_Altas()
        {
            comando.Connection = c.Open_Conection();
            comando.CommandText = "select med.id_med_disc, i.nombre_paciente, i.Fecha_Internamiento, i.numero_habitacion, med.Fecha_Alta" +
            " from internships i inner join medical_discharge med on i.id_internships = med.id_internships;";
            read = comando.ExecuteReader();
            tabla_datos.Load(read);
            c.Closed_Conection();
            return tabla_datos;
        }
    }
}

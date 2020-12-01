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
    public class CRUDInternamiento
    {
        private static CRUDInternamiento instancia_internamiento;

        MySqlDataReader read;
        ClassConexion c = new ClassConexion();
        MySqlCommand comando = new MySqlCommand();
        DataTable tabla_datos = new DataTable();

        private CRUDInternamiento() { }

        public static CRUDInternamiento obtener_instancia()
        {
            if(instancia_internamiento == null)
            {
                instancia_internamiento = new CRUDInternamiento();
            }
            return instancia_internamiento;
        }

        public void insertando_internamiento(string Fecha_Internamiento, string nombrepac, int num_rooms)
        {
            comando.Connection = c.Open_Conection();
            comando.CommandText = "insert into internships (Fecha_Internamiento, nombre_paciente, numero_habitacion) " +
            "values ('" + Fecha_Internamiento + "', '" + nombrepac + "', '" + num_rooms + "');";
            comando.ExecuteNonQuery();
            c.Closed_Conection();
        }

        public void Actualizando_internamiento(string Fecha_Internamiento, string nombrepac, int num_rooms, int id_internamiento)
        {
            comando.Connection = c.Open_Conection();
            comando.CommandText = "Update internships set Fecha_Internamiento = '" + Fecha_Internamiento + "', nombre_paciente = '" + nombrepac + "', numero_habitacion = '" 
           + num_rooms + "'" + "where id_internships = '" + id_internamiento + "';";
            comando.ExecuteNonQuery();
            c.Closed_Conection();
        }

        public void Borrar_internamiento(int idinternamiento)
        {
            comando.Connection = c.Open_Conection();
            comando.CommandText = "Delete from internships where id_internships = '" + idinternamiento + "'";
            comando.ExecuteNonQuery();
            c.Closed_Conection();
        }

        public DataTable Consulta_internamientos()
        {
            comando.Connection = c.Open_Conection();
            comando.CommandText = "Select * from internships;";
            read = comando.ExecuteReader();
            tabla_datos.Load(read);
            c.Closed_Conection();
            return tabla_datos;
        }
    }
}

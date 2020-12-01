using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaAccesoDatos;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace CapaAccesoDatos
{
    public class CRUDCitas
    {
        private static CRUDCitas instancia_citas;

        MySqlDataReader read;
        ClassConexion c = new ClassConexion();
        MySqlCommand comando = new MySqlCommand();
        DataTable tabla_datos = new DataTable();

        private CRUDCitas() { }

        public static CRUDCitas Obteniendo_Instancia()
        {
            if (instancia_citas == null)
            {
                instancia_citas = new CRUDCitas();
            }
            return instancia_citas;
        }

        public void insertando_cita(string fecha, string hora, string Pac, string Doc)
        {
            comando.Connection = c.Open_Conection();
            comando.CommandText = "insert into appointment (Fecha_cita, Hora_Cita, nombre_doctor, nombre_paciente) " +
            "values ('"+fecha+"', '" +hora+"', '"+Doc+"', '"+Pac+"');";
            comando.ExecuteNonQuery();
            c.Closed_Conection();
        }

        public void Actualizando_cita(int idcita, string fecha, string hora, string Doc, string Pac)
        {
            comando.Connection = c.Open_Conection();
            comando.CommandText = "Update appointment set Fecha_cita = '" + fecha + "', Hora_Cita = '" + hora + "', nombre_doctor = '" + Doc + "', " +
            "nombre_paciente ='" + Pac + "' where id_appointment = '"+idcita+"';";
            comando.ExecuteNonQuery();
            c.Closed_Conection();
        }

        public void Borrar_cita(int idcita)
        {
            comando.Connection = c.Open_Conection();
            comando.CommandText = "Delete from appointment where id_appointment = " + idcita + ";";
            comando.ExecuteNonQuery();
            c.Closed_Conection();
        }

        public DataTable Consulta_citas()
        {
            comando.Connection = c.Open_Conection();
            comando.CommandText = "Select * from appointment;";
            read = comando.ExecuteReader();
            tabla_datos.Load(read);
            c.Closed_Conection();
            return tabla_datos;
        }
    }
}

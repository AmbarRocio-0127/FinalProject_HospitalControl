using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace CapaAccesoDatos
{
    public class CRUDPaciente
    {
        private static CRUDPaciente instancia_pac;

        MySqlDataReader read;
        ClassConexion c = new ClassConexion();
        MySqlCommand comando = new MySqlCommand();
        DataTable tabla_datos = new DataTable();

        private CRUDPaciente() { }

        public static CRUDPaciente Obteniendo_Instancia()
        {
            if (instancia_pac == null)
            {
                instancia_pac = new CRUDPaciente();
            }
            return instancia_pac;
        }

        public void insertar_paciente(long ced, string nom, string estado)
        {
            comando.Connection = c.Open_Conection();
            comando.CommandText = "insert into patiente  (Cedula, Nombre, Estado) " +
            "values ('"+ced+"', '"+nom+"', '"+estado+"');";
            comando.ExecuteNonQuery();
            c.Closed_Conection();
        }

        public void Actualizar_paciente(long ced, string nom, string estado)
        {
            comando.Connection =  c.Open_Conection();
            comando.CommandText =  "Update patiente set Nombre='"+nom+"', Estado ='"+estado+"' where Cedula ='"+ced+"';";
            comando.ExecuteNonQuery();
            c.Closed_Conection();
        }

        public void Borrar_Paciente(long id_cedula)
        {
            comando.Connection = c.Open_Conection();
            comando.CommandText = "Delete from patiente where Cedula = '"+id_cedula+"';";
            comando.ExecuteNonQuery();
            MySqlCommand alter = new MySqlCommand(string.Format("alter table patiente drop id_patience;"), ClassConexion.connectiondatabase);
            alter.ExecuteNonQuery();
            MySqlCommand alter2 = new MySqlCommand(string.Format("ALTER TABLE patiente ADD COLUMN id_patience int NOT NULL PRIMARY KEY AUTO_INCREMENT FIRST;"),
            ClassConexion.connectiondatabase);
            alter2.ExecuteNonQuery();
            c.Closed_Conection();
        }

        public DataTable Consulta_Pacientes()
        {
            comando.Connection = c.Open_Conection();
            comando.CommandText = "Select * from patiente;";
            read = comando.ExecuteReader();
            tabla_datos.Load(read);
            c.Closed_Conection();
            return tabla_datos;
        }
    }
}

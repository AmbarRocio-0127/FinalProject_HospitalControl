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
    public class CRUDDoctor
    {
        private static CRUDDoctor instancia_doc;

        MySqlDataReader read;
        ClassConexion c = new ClassConexion();
        MySqlCommand comando = new MySqlCommand();
        DataTable tabla_datos = new DataTable();

        private CRUDDoctor() { }

        public static CRUDDoctor obtener_instancia()
        {
            if (instancia_doc == null)
            {
                instancia_doc = new CRUDDoctor();
            }
            return instancia_doc;
        }

        public void insertar_doctor(string nom, long ced, string exequatur, string especialidad)
        {
            comando.Connection = c.Open_Conection();
            comando.CommandText = "insert into doctor  (Nombre, Cedula, Exequatur, Especialidad) " +
            "values ( '"+nom+"', '"+ced+"', '"+exequatur+"', '"+especialidad+"'); ";
            comando.ExecuteNonQuery();
            c.Closed_Conection();
        }

        public void Actualiar_Doctor(string nom, long ced, string exequatur, string especialidad)
        {
            comando.Connection = c.Open_Conection();
            comando.CommandText =  "Update doctor set Nombre = '"+nom+"', Exequatur = '"+exequatur+"', Especialidad ='"+especialidad+"' where Cedula ='"+ced+"';";
            comando.ExecuteNonQuery();
            c.Closed_Conection();
        }

        public void Borrar_Doctor(long id_cedula)
        {
            comando.Connection = c.Open_Conection();
            comando.CommandText = "Delete from doctor where Cedula = '"+id_cedula+"';";
            comando.ExecuteNonQuery();
            MySqlCommand alter = new MySqlCommand(string.Format("alter table doctor drop id_doctor;"), ClassConexion.connectiondatabase);
            alter.ExecuteNonQuery();
            MySqlCommand alter2 = new MySqlCommand(string.Format("ALTER TABLE doctor ADD COLUMN id_doctor int NOT NULL PRIMARY KEY AUTO_INCREMENT FIRST;"), 
            ClassConexion.connectiondatabase);
            alter2.ExecuteNonQuery();
            c.Closed_Conection();
        }

        public DataTable Consulta_doctor()
        {
            comando.Connection = c.Open_Conection();
            comando.CommandText = "Select * from doctor;";
            read = comando.ExecuteReader();
            tabla_datos.Load(read);
            c.Closed_Conection();
            return tabla_datos;
        }
        
    }
}

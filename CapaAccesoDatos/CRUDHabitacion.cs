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
    public class CRUDHabitacion
    {
        private static CRUDHabitacion habitacion_instancia;

        MySqlDataReader read;
        ClassConexion c = new ClassConexion();
        MySqlCommand comando = new MySqlCommand();
        DataTable tabla_datos = new DataTable();

        private CRUDHabitacion() { }

        public static CRUDHabitacion obtener_instancia()
        {
            if (habitacion_instancia == null)
            {
                habitacion_instancia = new CRUDHabitacion();
            }
            return habitacion_instancia;
        }

        public void insertar_habitacion(int num, string tipo, double precio)
        {
            comando.Connection = c.Open_Conection();
            comando.CommandText = "insert into Rooms  (Número, Tipo, Precio) values ('"+num+"', '"+tipo+"', '"+precio+"'); ";
            comando.ExecuteNonQuery();
            c.Closed_Conection();
        }

        public void Actualizar_habitacion(int num, string tipo, double precio)
        {
            comando.Connection = c.Open_Conection();
            comando.CommandText = "Update Rooms set tipo='"+tipo+"', Precio ='"+precio+"' where Número ='"+num+"';";
            comando.ExecuteNonQuery();
            c.Closed_Conection();
        }

        public void Borrar_habitacion(int num)
        {
            comando.Connection = c.Open_Conection();
            comando.CommandText = "Delete from Rooms where Número = '"+num+"';";
            comando.ExecuteNonQuery();
            MySqlCommand alter = new MySqlCommand(string.Format("alter table Rooms drop id_rooms;"), ClassConexion.connectiondatabase);
            alter.ExecuteNonQuery();
            MySqlCommand alter_ = new MySqlCommand(string.Format("ALTER TABLE Rooms ADD COLUMN id_rooms int NOT NULL PRIMARY KEY AUTO_INCREMENT FIRST;"), 
            ClassConexion.connectiondatabase);
            alter_.ExecuteNonQuery();
            c.Closed_Conection();
        }

        public DataTable Consulta_habitacion()
        {
            comando.Connection = c.Open_Conection();
            comando.CommandText = "Select * from rooms;";
            read = comando.ExecuteReader();
            tabla_datos.Load(read);
            c.Closed_Conection();
            return tabla_datos;
        }
    }
}

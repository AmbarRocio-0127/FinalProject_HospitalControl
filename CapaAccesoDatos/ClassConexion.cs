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
    public class ClassConexion
    {
        public static MySqlConnection connectiondatabase = new MySqlConnection("server=127.0.0.1; database=Hospital_control; Uid=root; pwd=arcr012701;");

        //Metodo para abrir la conexión
        public MySqlConnection Open_Conection()
        {
            if (connectiondatabase.State == ConnectionState.Closed)
            {
                connectiondatabase.Open();
            }
            return connectiondatabase;
        }

        //Metodo para cerrar la conexión
        public MySqlConnection Closed_Conection()
        {
            if (connectiondatabase.State == ConnectionState.Open)
            {
                connectiondatabase.Close();
            }
            return connectiondatabase;
        }

    }
}

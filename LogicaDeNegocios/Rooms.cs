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
    public class Rooms : I_Consult_Strategy 
    {
        CRUDHabitacion crdhab_ = CRUDHabitacion.obtener_instancia();

        private int Numero;
        private string Tipo;
        private double Precio;
        private int id_room;

        public int _Numero
        {
            get
            {
                return Numero;
            }
            set
            {
                Numero = value;
            }
        }
        public string _Tipo
        {
            get
            {
                return Tipo;
            }
            set
            {
                Tipo = value;
            }
        }
        public double _Precio
        {
            get
            {
                return Precio;
            }
            set
            {
                Precio = value;
            }
        }
        public int _id_room
        {
            get
            {
                return id_room;
            }
            set
            {
                id_room = value;
            }
        }
        public void Insertar_habitacion(string num, string tipo, string precio)
        {
            try
            {
                _Numero = Convert.ToInt32(num);
                _Tipo = tipo;
                _Precio = Convert.ToDouble(precio);
                crdhab_.insertar_habitacion(Convert.ToInt32(num), tipo, Convert.ToDouble(precio));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Actualizando_habitacion(string num, string tipo, string precio)
        {
            try
            {
                _Numero = Convert.ToInt32(num);
                _Tipo = tipo;
                _Precio = Convert.ToDouble(precio);
                crdhab_.Actualizar_habitacion(_Numero, _Tipo, _Precio);
           }
           catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Borrar_habitacion(string num)
        {
            try
            {
                _Numero = Convert.ToInt32(num);
                crdhab_.Borrar_habitacion(_Numero);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataTable Listar()
        {
            DataTable dt = new DataTable();
            dt = crdhab_.Consulta_habitacion();
            return dt;
        }
    }

    
}

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
    public class Doctor : Person , I_Consult_Strategy 
    {
        CRUDDoctor crdDoctor = CRUDDoctor.obtener_instancia();

        private string Exequatur;
        private string Especialidad;

        public string _Exequatur
        {
            get
            {
                return Exequatur;
            }
            set
            {
                Exequatur = value;
            }
        }
        public string _Especialidad
        {
            get
            {
                return Especialidad;
            }
            set
            {
                Especialidad = value;
            }
        }
        public void Insertar_doctor(string nom, string ced, string exequatur, string especialidad)
        {
            try
            {
                _Nombre = nom;
                _Cedula = Convert.ToInt64(ced);
                _Exequatur = exequatur;
                _Especialidad = especialidad;
                crdDoctor.insertar_doctor(_Nombre, _Cedula, _Exequatur, _Especialidad);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Actualizando_doctor(string nom, string ced, string exequatur, string especialidad)
        {
            try
            {
                _Nombre = nom;
                _Cedula = Convert.ToInt64(ced);
                _Exequatur = exequatur;
                _Especialidad = especialidad;
                crdDoctor.Actualiar_Doctor (_Nombre, _Cedula, _Exequatur, _Especialidad);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Borrar_doctor(string id_cedula)
        {
            try
            {
                _Cedula = Convert.ToInt64(id_cedula);
                crdDoctor.Borrar_Doctor(_Cedula);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable Listar()
        {
            DataTable dt = new DataTable();
            dt = crdDoctor.Consulta_doctor();
            return dt;
        }
    }
}

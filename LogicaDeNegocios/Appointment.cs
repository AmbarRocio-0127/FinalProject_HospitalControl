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
    public class Appointment : I_Consult_Strategy
    {
        CRUDCitas crdcitas = CRUDCitas.Obteniendo_Instancia();

        private int idcita;
        private string Fecha;
        private string Doctor;
        private string Paciente;
        private string Hora;

        public int idcita_
        {
            get
            {
                return idcita;
            }
            set
            {
                idcita = value;
            }
        }

        public string _Fecha
        {
            get
            {
                return Fecha;
            }
            set
            {
                Fecha = value;
            }
        }

        public string Hora_
        {
            get
            {
                return Hora;
            }
            set
            {
                Hora = value;
            }
        }
        public string _Doctor
        {
            get
            {
                return Doctor;
            }
            set
            {
                Doctor = value;
            }
        }
        public string _Paciente
        {
            get
            {
                return Paciente;
            }
            set
            {
                Paciente = value;
            }
        }

        public void Insertar_cita(string fecha, string hora, string Pac, string Doc)
        {
            try
            {
                _Fecha = fecha;
                Hora = hora;
                _Doctor = Doc;
                _Paciente = Pac;
                crdcitas.insertando_cita(_Fecha, Hora_, _Paciente, _Doctor);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Actualizando_cita(string idcita, string fecha, string hora, string Doc, string Pac)
        {
            try
            {
                idcita_ = Convert.ToInt32(idcita);
                _Fecha = fecha;
                Hora_ = hora;
                _Doctor = Doc;
                _Paciente = Pac;
                crdcitas.Actualizando_cita(idcita_, _Fecha, Hora_, _Paciente, _Doctor);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Borrar_cita(string idcita)
        {
            try
            {
                idcita_ = Convert.ToInt32(idcita);
                crdcitas.Borrar_cita(idcita_);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable Listar()
        {
            DataTable dt = new DataTable();
            dt = crdcitas.Consulta_citas();
            return dt;
        }
    }
}

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
    public class Patiente : Person , I_Consult_Strategy 
    {
        CRUDPaciente CRDPaciente = CRUDPaciente.Obteniendo_Instancia();
        private string Asegurado;

        public string _Asegurado
        {
            get
            {
                return Asegurado;
            }
            set
            {
                Asegurado = value;
            }
        }

        public void Insertar_paciente_(string ced, string nom, string estado)
        {
            try
            {
            _Nombre = nom;
            _Cedula = Convert.ToInt64(ced);
            _Asegurado = Convert.ToString(estado);
            CRDPaciente.insertar_paciente(_Cedula,nom,estado);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Actualizando_paciente_(string ced, string nom, string estado)
        {
            try
            {
                _Nombre = nom;
                _Cedula = Convert.ToInt64(ced);
                _Asegurado = Convert.ToString(estado);
                CRDPaciente.Actualizar_paciente(_Cedula, _Nombre,_Asegurado);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Borrar_paciente(string id_cedula)
        {
            try
            {
                _Cedula = Convert.ToInt64(id_cedula);
                CRDPaciente.Borrar_Paciente(_Cedula);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
       
        public DataTable Listar()
        {
            DataTable dt = new DataTable();
            dt = CRDPaciente.Consulta_Pacientes();
            return dt;
        }
    }
}

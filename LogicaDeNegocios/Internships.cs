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
    public class Internships : I_Consult_Strategy
    {
        CRUDInternamiento crd_intern = CRUDInternamiento.obtener_instancia();

        private int id_intern;
        private string Fecha_internamiento;
        private string nombrepaciente;
        private int numberrooms;

        public int _id_intern
        {
            get
            {
                return id_intern;
            }
            set
            {
                id_intern = value;
            }
        }
        public string _Fecha_Internamiento
        {
            get
            {
                return Fecha_internamiento;
            }
            set
            {
                Fecha_internamiento = value;
            }
        }
        public string nombrepaciente_
        {
            get
            {
                return nombrepaciente;
            }
            set
            {
                nombrepaciente = value;
            }
        }
        public int numberrooms_
        {
            get
            {
                return numberrooms;
            }
            set
            {
                numberrooms = value;
            }
        }

        public void Insertar_internamiento(string Fecha_Internamiento, string nombrepatience, string id_rooms)
        {
            try
            {
                _Fecha_Internamiento = Fecha_Internamiento;
                nombrepaciente_ = nombrepatience;
                crd_intern.insertando_internamiento(_Fecha_Internamiento, nombrepaciente_, Convert.ToInt32(id_rooms));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Actualizando_internamiento(string Fecha_Internamiento, string nom_patience, string num_rooms, string id_internamiento)
        {
            try
            {
                _Fecha_Internamiento = Fecha_Internamiento;
                nombrepaciente_ = nom_patience;
                numberrooms_ = Convert.ToInt32(num_rooms);
                _id_intern = Convert.ToInt32(id_internamiento);
                crd_intern.Actualizando_internamiento(_Fecha_Internamiento, nombrepaciente_, numberrooms_, _id_intern);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Borrar_internamiento(string idinternamiento)
        {
            try
            {
                _id_intern = Convert.ToInt32(idinternamiento);
                crd_intern.Borrar_internamiento(_id_intern);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable Listar()
        {
            DataTable dt = new DataTable();
            dt = crd_intern.Consulta_internamientos();
            return dt;
        }
    }
}

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
    public class Consulta_Context_Strategy
    {
       I_Consult_Strategy ConsultStrategy;

        public Consulta_Context_Strategy(I_Consult_Strategy instancia_consulta)
        {
            this.ConsultStrategy = instancia_consulta;
        }

        public DataTable Listar()
        {
            DataTable d_table = new DataTable();
            ConsultStrategy.Listar();
            d_table = ConsultStrategy.Listar();
            return d_table;

        }
    }
}

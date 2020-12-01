using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaAccesoDatos;

namespace LogicaDeNegocios
{
    public class Person
    {
        private int id;
        private string Nombre;
        private long Cedula;

        public long _Cedula
        {
            get
            {
                return Cedula;
            }
            set
            {
                Cedula = value;
            }
        }
        public int _id
        {
            get
            {
                return id;

            }
            set
            {
                id = value;
            }
        }
        public string _Nombre
        {
            get
            {
                return Nombre;
            }
            set
            {
                Nombre = value;
            }
        }
    }
}

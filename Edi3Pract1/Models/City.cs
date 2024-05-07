using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edi3Pract1.Models
{
    public class City
    {
        private string nombre;
        private int id;

        public City() { }

        public City(string nombre, int id)
        {
            this.Nombre = nombre;
            this.Id = id;
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }


    }
}

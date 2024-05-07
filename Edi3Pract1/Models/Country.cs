using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edi3Pract1.Models
{
    public class Country
    {
        private int id;
        private string nombre;
        private Impuesto impuesto;

        public Country() { }

        public Country(int id, string nombre, Impuesto impuesto)
        {
            this.Nombre = nombre;
            this.Impuesto = impuesto;
            this.Id = id;
        }
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public Impuesto Impuesto
        {
            get { return impuesto; }
            set { impuesto = value; }
        }

       

        public decimal getImpuesto()
        {
            return Impuesto.getCantidad();
        }

    }
}

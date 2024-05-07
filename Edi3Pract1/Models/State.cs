using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edi3Pract1.Models
{
    public class State
    {
        private int id;
        private string nombre;
        private Impuesto impuesto;
        private Country country;


        public State() { }

        public State(int id,string nombre,Impuesto impuesto,Country country)
        {
            this.Id = id;
            this.Nombre = nombre;
            this.Impuesto = impuesto;
            this.Country = country;
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

        private Country Country
        {
            get { return country; }
            set { country = value; }
        }

        public decimal getImpuest()
        {
            return Impuesto.getCantidad();
        }
    }
}

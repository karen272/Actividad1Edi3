using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edi3Pract1.Models
{
    public class Impuesto
    {
        private int id;
        private string nombre;
        private decimal cantidad;

        public Impuesto (int id,string nombre, decimal cantidad)
        {
            this.Id = id;
            this.Nombre = nombre;
            this.Cantidad = cantidad;
        }
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Nombre 
        { 
            get {  return nombre; } 
            set { nombre = value; }
        }

        public decimal Cantidad
        {
            get { return cantidad; }
            set { cantidad = value; }
        }

        public decimal getCantidad()
        {
            return cantidad;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edi3Pract1.Models
{
    public class Product
    {
        private int id;
        private string nombre;
        private decimal precio;
        

        public Product() { }

        public Product (int id,string nombre, decimal precio)
        {
            this.id = id;
            this.Nombre = nombre;
            this.Precio = precio;
            
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

        public decimal Precio
        {
            get { return precio; }
            set { precio = value; }
        }

        public decimal getPrecio()
        {
            return precio;
        }


    }
}

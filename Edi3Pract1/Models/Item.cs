using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edi3Pract1.Models
{
    public class Item
    {
        private int id;
        private int cantidad;
        private Product producto;

        public Item() { }



        public Item(int id,int cantidad, Product producto)
        {
            this.Id = id;
            this.Cantidad = cantidad;
            
            this.Producto = producto;
            
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public int Cantidad
        {
            get { return cantidad; }
            set { cantidad = value; }
        }

       

        public Product Producto
        {
            get { return producto; }
            set { producto = value; }
        }

        
        public Product getProducto()
        {
            return Producto;
        }
        

        public decimal getSubtotal()
        {
            return Producto.getPrecio () * cantidad;
        }
      

    }
}

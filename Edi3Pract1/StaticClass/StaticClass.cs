using Edi3Pract1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Edi3Pract1.StaticClass
{
    public static class StaticClass
    {
        public static List<Product> productos = new List<Product>();
        public static List<Country> countrys = new List<Country>();
        public static List<State> states = new List<State>();
        public static List<Order> orders = new List<Order>();

        public static void InstanciarTodo()
        {
            InstanciarProductos();
            InstanciarPaises();
            InstanciarEstados();
            InstanciarOrdenes();

        }

        public static void InstanciarProductos()
        {
            productos.Add(new Product(1,"Gomitas",50));
            productos.Add(new Product(2,"Chupetin",70));
            productos.Add(new Product(3,"Hamburguesa",20));
            productos.Add(new Product(4,"Remera",26));
            productos.Add(new Product(5,"Gorra",25));
            productos.Add(new Product(6,"Reloj",45));
            productos.Add(new Product(7,"Telefono",27));
            productos.Add(new Product(8,"Parlante",69));
            productos.Add(new Product(9,"Televisor",80));
            productos.Add(new Product(10,"Zapatilla",96));
            productos.Add(new Product(11,"Computadora",92));
        }

        public static void InstanciarPaises()
        {
            countrys.Add(new Country(1, "USA", new Impuesto(1, "IVA", (decimal)0.07)));
            countrys.Add(new Country(2, "EU", new Impuesto(2, "IVA", (decimal)0.21)));
            countrys.Add(new Country(3, "EU", new Impuesto(3, "Mehrwertsteuer", (decimal)0.19)));
            countrys.Add(new Country(4, "EU", new Impuesto(4, "TVA", (decimal)0.20)));
            countrys.Add(new Country(5, "EU", new Impuesto(5, "IVA", (decimal)0.22)));
            countrys.Add(new Country(6, "CH", new Impuesto(6, "VAT", (decimal)0.13)));
            
        }
        public static void InstanciarEstados()
        {
            states.Add(new State(1, "Texas", new Impuesto(3, "IVA", (decimal)0.10), countrys[0]));
            states.Add(new State(2, "California", new Impuesto(4, "IVA", (decimal)0.095), countrys[0]));
            states.Add(new State(3, "Florida", new Impuesto(5, "IVA", (decimal)0.07), countrys[0]));
            states.Add(new State(4, "Nueva York", new Impuesto(6, "IVA", (decimal)0.0895), countrys[0]));
            states.Add(new State(5, "Pensilvania", new Impuesto(7, "IVA", (decimal)0.06), countrys[0]));
        }

        public static void InstanciarOrdenes()
        {
            // Sample orders with various combinations
            orders.Add(new Order(
              new List<Item>()
              {
                new Item(1,1,productos[0]),
                new Item(2,2,productos[2])  
              },
              countrys[1], 
              states[0],   
              "Los Angeles"
            ));

            orders.Add(new Order(
              new List<Item>()
              {
                new Item(3,2,productos[6]), 
                new Item(4,2,productos[8])  
              },
              countrys[1], 
              null,       
              "Barcelona"
            ));

            orders.Add(new Order(
              new List<Item>()
              {
                  new Item(5,1,productos[9]),
                  new Item(6,2, productos[11])
              },
              countrys[4],
              null,
              "Rome"
            ));



        }

    }
}

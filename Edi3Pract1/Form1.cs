using Edi3Pract1.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Edi3Pract1
{
    public partial class Form1 : Form
    {
        private List<Order> orders;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Static.InstanciarTodo();
            orders = ListarOrdenes();

            StringBuilder sb = new StringBuilder();
            foreach (Order order in orders)
            {
                sb.AppendLine($"Order ID: {order.Id}, Location: {order.Country}");
                // Puedes añadir más información de la orden aquí, dependiendo de lo que desees mostrar
                foreach (var item in order.items)
                {
                    sb.AppendLine($"   - Item ID: {item.ID}, Product: {item.Producto.Nombre}, Quantity: {item.Cantidad}, precio: {item.Producto.Precio}");
                }
                sb.AppendLine($"total ---> ${order.getTotalParaPagar()}");
                // Agregar una línea en blanco para separar las órdenes
                sb.AppendLine();
            }

            lblListarOrdenes.Text = sb.ToString();
        }

        public List<Order> ListarOrdenes()
        {
            List<Order> orders = StaticClass.orders;
            orders = StaticClass.orders;
            return orders;
        }


    }
}

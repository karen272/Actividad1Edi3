using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edi3Pract1.Models
{
    public class Order
    {
        public int Id { get;set; }
        private TaxCalculator Calculator;
        private List<Item> Items;
        private Country country;
        private State state;
        private string city;


        public Order() { }

        public Order(List<Item> items,  Country country, State state, string city)
        {
            
            this.Items = items;
            this.Country = country;
            this.State = state;
            this.City = city;
            Calculator = new TaxCalculator();
        }

        

        public Country Country 
        { 
            get { return country; } 
            set { country = value; } 
        }

        public State State
        {
            get { return state; }
            set { state = value; }
        }

        public string City
        {
            get { return city; }
            set { city = value; }
        }
       


        public decimal getSubtotalOrden()
        {
            decimal subtotal = 0;
            foreach (Item item in Items)
            {
                subtotal += item.getSubtotal();
            }
            return subtotal;
        }

        public decimal getTotalOrden()
        {
            decimal total = 0;
            foreach (Item item in Items)
            {
                total += getSubtotalOrden() * Calculator.getImpuestoPorPais(Country, State, item.getProducto());
            }
            return total;
        }

        public decimal getTotalParaPagar()
        {
            return getSubtotalOrden() + getTotalOrden();
        }


        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Order ID: {Id}"); 


            if (Country != null)
            {
                sb.AppendLine($"Country: {Country}");
                if (State != null)
                {
                    sb.AppendLine($"State: {State}");
                }
            }

            if (!string.IsNullOrEmpty(City))
            {
                sb.AppendLine($"City: {City}");
            }

            sb.AppendLine("Items:");
            foreach (Item item in Items)
            {
                sb.AppendLine("#" + item);
            }
            sb.AppendLine($"Subtotal: ${getSubtotalOrden()}");
            sb.AppendLine($"Taxes: ${getTotalOrden()}");
            sb.AppendLine($"Total: ${getTotalParaPagar()}");
            return sb.ToString();
        }





    }
}

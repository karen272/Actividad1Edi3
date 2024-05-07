using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edi3Pract1.Models
{
    public class TaxCalculator
    {
        public TaxCalculator() { }

        public decimal getImpuestoPorPais(Country country, State state, Product producto)
        {
            decimal impuestoPais = 0;
            switch (country.Nombre)
            {
                case "USA":
                    impuestoPais = getUSImp(state);
                    break;
                case "Ch":
                    impuestoPais = getChineseImp(producto);
                    break;
                case "EU":
                    impuestoPais = getEUImp(country);
                    break;
            }
            return impuestoPais;
        }

        private decimal getUSImp(State state)
        {
            return state.getImpuest();
        }
        

        private decimal getChineseImp(Product producto)
        {
            return 0;
        }
        private decimal getEUImp(Country country)
        {
            return country.getImpuesto();
        }



    }
}

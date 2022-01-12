using System;
using System.Collections.Generic;
using System.Text;

namespace CountriesEFC.ViewModel
{
    class CountryEconomicVM
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double GDP { get; set; }
        public double Population { get; set; }
        public double PerCapita { get; set; }
        public override string ToString()
        {
            return String.Format("{0}: {1}, {2} peoples, {3} GDP, ({4} per capita)", Name, Population, GDP, PerCapita);
        }
    }
}

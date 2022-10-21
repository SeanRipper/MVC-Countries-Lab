using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Countries_Lab
{
    public class CountryView
    {
        public Country DisplayCountry { get; set; }
        public CountryView(Country DisplayCountry2)
        {
            DisplayCountry = DisplayCountry2;
        }
        public void Display()
        {
            Console.WriteLine(DisplayCountry.Name);
            Console.WriteLine(DisplayCountry.Continent);
            Console.WriteLine(DisplayCountry.Colors);
        }
    }
}

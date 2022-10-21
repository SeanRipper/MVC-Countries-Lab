using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Countries_Lab
{
    public enum Continent
    {
        NorthAmerica,
        SouthAmerica,
        Africa,
        Asia,
        Europe,
        Australia,
        Antarctica
    }
    public class Country
    {
        public string Name { get; set; }
        public Continent Continent { get; set; }
        public List<string> Colors { get; set; }

        public Country()
        {
            
        }
    }
}

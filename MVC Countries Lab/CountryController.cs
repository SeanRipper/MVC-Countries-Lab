using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Countries_Lab
{
    public class CountryController
    {
        public List<Country> CountryDb { get; set; }
        public CountryController()
        {
            CountryDb = new List<Country>();
        }

        public void CountryAction(Country c)
        {
            CountryView cv = new CountryView(c);
            cv.Display();
        }
        public void WelcomeAction()
        {
            CountryListView clv = new CountryListView(CountryDb);
            Console.WriteLine("Hello, welcome to the country app. Please select a country from the following list.");
        }
        public void CountryListAction(CountryListView clv)
        {
            clv.Display();
            Console.WriteLine("Select which country you'd like to view by entering its index.");
            string input = Console.ReadLine();
            int index = int.Parse(input);
            CountryAction(CountryDb[index]);
        }
    }
}
